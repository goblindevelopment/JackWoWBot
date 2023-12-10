using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Jack.Engine;
using Jack.Models;

namespace Jack.Core
{
	// Token: 0x02000100 RID: 256
	public static class Pathfinder
	{
		// Token: 0x06001788 RID: 6024
		[DllImport("kernel32.dll")]
		private static extern IntPtr LoadLibrary(string lpFileName);

		// Token: 0x06001789 RID: 6025
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern bool FreeLibrary(IntPtr hModule);

		// Token: 0x0600178A RID: 6026
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string procName);

		// Token: 0x0600178B RID: 6027 RVA: 0x0071BBF0 File Offset: 0x00719DF0
		public static void LoadDll()
		{
			IntPtr hModule = Pathfinder.LoadLibrary(Pathfinder.DLLPath);
			Pathfinder.CalculatePath = Marshal.GetDelegateForFunctionPointer<Pathfinder.CalculatePathDelegate>(Pathfinder.GetProcAddress(hModule, "CalculatePath"));
			Pathfinder.FreePath = Marshal.GetDelegateForFunctionPointer<Pathfinder.FreePathArr>(Pathfinder.GetProcAddress(hModule, "FreePathArr"));
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0071BC30 File Offset: 0x00719E30
		public static void UnloadDll()
		{
			foreach (object obj in Process.GetCurrentProcess().Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				if (processModule.FileName == Pathfinder.DLLPath)
				{
					Pathfinder.FreeLibrary(processModule.BaseAddress);
				}
			}
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0071BCA8 File Offset: 0x00719EA8
		public static void ReloadDll()
		{
			Pathfinder.UnloadDll();
			Thread.Sleep(500);
			Pathfinder.LoadDll();
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0071BCCC File Offset: 0x00719ECC
		public unsafe static List<Vector3> Navigate(Vector3 From, Vector3 To, bool Straight = false, int MapID = -1)
		{
			if (MapID == -1)
			{
				MapID = PlayerMe.MeshID;
			}
			string gamePath = "Classic";
			if (_globals.IsRetail)
			{
				gamePath = "Retail";
			}
			List<Vector3> list = new List<Vector3>();
			if (!_globals.IsRetail && !_globals.PathfinderClassicReady)
			{
				return list;
			}
			if (_globals.IsRetail && !_globals.PathfinderRetailReady)
			{
				return list;
			}
			Pathfinder.XYZ start = new Pathfinder.XYZ(From.X, From.Y, From.Z);
			Pathfinder.XYZ end = new Pathfinder.XYZ(To.X, To.Y, To.Z);
			int num;
			Pathfinder.XYZ* ptr = Pathfinder.CalculatePath((uint)MapID, start, end, Straight, out num, gamePath);
			for (int i = 0; i < num; i++)
			{
				list.Add(new Vector3(ptr[i].X, ptr[i].Y, ptr[i].Z));
			}
			Pathfinder.FreePath(ptr);
			list = Pathfinder.StuckPaths(list);
			if (Walk.CheckProfileSettings && Walk.ProfileSettings.FlightMount)
			{
				list = Pathfinder.CalculateFlightPath(list, To);
			}
			return list;
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0071BDE4 File Offset: 0x00719FE4
		private static List<Vector3> CalculateFlightPath(List<Vector3> Waypoints, Vector3 Goal)
		{
			if (Waypoints.Count == 0)
			{
				return Waypoints;
			}
			Vector3 positionVector = ObjectManager.Me.PositionVector3;
			float z = positionVector.Z;
			float z2 = Goal.Z;
			List<Vector3> list = new List<Vector3>();
			if (ObjectManager.Me.IsFlying)
			{
				using (List<Vector3>.Enumerator enumerator = Waypoints.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Vector3 vector = enumerator.Current;
						list.Add(new Vector3(vector.X, vector.Y, z));
					}
					goto IL_7E;
				}
			}
			list = Waypoints;
			IL_7E:
			bool flag = JackMath.ZDifference(positionVector, Goal) < 0f;
			int num = 0;
			float num2 = z;
			List<Vector3> list2 = new List<Vector3>();
			foreach (Vector3 vector2 in list)
			{
				if (JackMath.ZDifference(num2, z2) > 5f)
				{
					if (!flag)
					{
						num2 = vector2.Z - (float)num;
					}
					else
					{
						num2 = vector2.Z + (float)num;
					}
					num += 3;
				}
				list2.Add(new Vector3(vector2.X, vector2.Y, num2));
			}
			if (list2.Count > 0)
			{
				Vector3 item = list2.LastOrDefault<Vector3>();
				for (int i = list2.Count - 1; i >= 0; i--)
				{
					if (i % 5 != 0)
					{
						list2.RemoveAt(i);
					}
				}
				if (!list2.Contains(item))
				{
					list2.Add(item);
				}
			}
			return list2;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0071BF7C File Offset: 0x0071A17C
		public static bool LoadMeshMap(bool Retry = false)
		{
			if (Pathfinder.LoadingMap)
			{
				return false;
			}
			Pathfinder.LoadingMap = true;
			Form form = Application.OpenForms["frmMain"];
			while (form == null)
			{
				form = Application.OpenForms["frmMain"];
				Thread.Sleep(100);
			}
			while (!form.Visible)
			{
				Thread.Sleep(100);
			}
			while (!_globals.IsInWorld)
			{
				Thread.Sleep(100);
			}
			while (PlayerMe.MeshID <= -1)
			{
				Thread.Sleep(250);
			}
			if (Retry)
			{
				Pathfinder.CurrentMeshID = -1;
			}
			int meshID = PlayerMe.MeshID;
			if (Pathfinder.CurrentMeshID == meshID)
			{
				Pathfinder.LoadingMap = false;
				return true;
			}
			if (!_globals.List_MeshMapIDs.Contains(meshID))
			{
				Pathfinder.LoadingMap = false;
				return true;
			}
			Tools.Console("Initializing Pathfinder...", "", "richConsole", "frmMain", true);
			string text = "Loading ";
			if (!_globals.IsInDungeon)
			{
				if (_globals.IsInBattleground)
				{
					text = text + "Battleground: " + PlayerMe.BattlegroundName;
				}
				else
				{
					text = text + "Continent: " + PlayerMe.ContinentName;
				}
			}
			else
			{
				text = text + "Dungeon: " + PlayerMe.DungeonName;
			}
			if (text.Contains(" N/A"))
			{
				new Thread(new ThreadStart(Pathfinder.RetryLoadingMeshMap))
				{
					IsBackground = true
				}.Start();
			}
			Pathfinder.CurrentMeshID = PlayerMe.MeshID;
			Vector3 vector = new Vector3(0f, 0f, 0f);
			object @lock = Pathfinder._lock;
			lock (@lock)
			{
				Tools.Control("", "btnStart", "frmMain", false, false, false, false, 0);
				Tools.Console(text + "...", "", "richConsole", "frmMain", true);
				Pathfinder.Navigate(vector, vector, true, Pathfinder.CurrentMeshID);
				Tools.Control("", "btnStart", "frmMain", true, false, false, false, 0);
				Tools.Console("Pathfinder ready.", "", "richConsole", "frmMain", true);
			}
			Pathfinder.LoadingMap = false;
			return true;
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0071C190 File Offset: 0x0071A390
		private static void RetryLoadingMeshMap()
		{
			Thread.Sleep(5000);
			if (!_globals.Start)
			{
				Pathfinder.LoadMeshMap(true);
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0071C1B8 File Offset: 0x0071A3B8
		private static List<Vector3> StuckPaths(List<Vector3> Waypoints)
		{
			if (ObjectManager.Me.IsFlying || _globals.StuckPaths.Count == 0)
			{
				return Waypoints;
			}
			int zoneID = PlayerMe.ZoneID;
			if (zoneID <= 0)
			{
				return Waypoints;
			}
			List<Vector3> list = new List<Vector3>();
			foreach (Vector3 item in Waypoints)
			{
				list.Add(item);
			}
			List<Vector3> list2 = new List<Vector3>();
			Vector3 vector = Vector3.Zero;
			Vector3 vector2 = Vector3.Zero;
			foreach (StuckPaths stuckPaths in _globals.StuckPaths)
			{
				if (stuckPaths.ZoneID == zoneID)
				{
					int num = -1;
					foreach (Vector3 vector3 in Waypoints.ToList<Vector3>())
					{
						num++;
						if (JackMath.DistanceAround(stuckPaths.Location, vector3) <= (double)stuckPaths.Radius)
						{
							if (vector == Vector3.Zero)
							{
								if (num <= 0)
								{
									vector = Waypoints[0];
								}
								else
								{
									vector = Waypoints[num - 1];
								}
							}
							Waypoints.Remove(vector3);
						}
					}
					if (!(vector == Vector3.Zero))
					{
						bool flag = false;
						using (List<Vector3>.Enumerator enumerator = Waypoints.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Vector3 vector4 = enumerator.Current;
								if (flag)
								{
									vector2 = vector4;
									break;
								}
								flag = (vector4 == vector);
							}
							goto IL_3A1;
						}
						IL_183:
						vector = Vector3.Zero;
						continue;
						IL_3A1:
						if (vector2 == Vector3.Zero)
						{
							goto IL_183;
						}
						int closestCrd = Walk.GetClosestCrd(stuckPaths.Waypoints, vector, 0);
						Vector3 vector5 = stuckPaths.Waypoints[closestCrd];
						int closestCrd2 = Walk.GetClosestCrd(stuckPaths.Waypoints, vector2, 0);
						Vector3 vector6 = stuckPaths.Waypoints[closestCrd2];
						if (vector5 == vector6)
						{
							vector = Vector3.Zero;
							vector2 = Vector3.Zero;
						}
						else
						{
							List<Vector3> list3 = new List<Vector3>();
							list3.Add(vector5);
							Vector3 from = vector5;
							int count = stuckPaths.Waypoints.Count;
							for (;;)
							{
								double num2 = 0.0;
								Vector3 vector7 = Vector3.Zero;
								foreach (Vector3 vector8 in stuckPaths.Waypoints)
								{
									if (!list3.Contains(vector8))
									{
										double num3 = JackMath.Distance(from, vector8, true, true, true);
										if (num2 == 0.0 || (num3 > 0.0 && num3 < num2))
										{
											num2 = num3;
											if (num2 > 0.0)
											{
												vector7 = vector8;
											}
										}
									}
								}
								if (vector7 == Vector3.Zero || vector7 == vector6)
								{
									break;
								}
								list3.Add(vector7);
								from = vector7;
							}
							list3.Add(vector6);
							list2.Clear();
							foreach (Vector3 vector9 in Waypoints)
							{
								list2.Add(vector9);
								if (vector9 == vector)
								{
									foreach (Vector3 item2 in list3)
									{
										list2.Add(item2);
									}
								}
							}
							Waypoints.Clear();
							foreach (Vector3 item3 in list2)
							{
								Waypoints.Add(item3);
							}
							vector = Vector3.Zero;
							vector2 = Vector3.Zero;
						}
					}
				}
			}
			if (list2.Count == 0)
			{
				return list;
			}
			return list2;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0071C660 File Offset: 0x0071A860
		public static bool IsInRange(Vector3 From, Vector3 To)
		{
			if (Walk.CheckProfileSettings)
			{
				if (Walk.ProfileSettings.FlightMount)
				{
					return ObjectManager.Me.IsFlying || (JackMath.Distance(To, true, true, true) <= 40.0 && JackMath.ZDifferenceValue(To.Z) <= 10.0);
				}
				int count = Pathfinder.Navigate(From, To, false, -1).Count;
				if (count > 0 && (count - 1) * Pathfinder.YardsPerWaypoint <= Walk.ProfileSettings.DistancePath)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0071C6E8 File Offset: 0x0071A8E8
		public static bool IsInRange(Vector3 To)
		{
			if (Walk.CheckProfileSettings)
			{
				if (Walk.ProfileSettings.FlightMount)
				{
					return ObjectManager.Me.IsFlying || (JackMath.Distance(To, true, true, true) <= 40.0 && JackMath.ZDifferenceValue(To.Z) <= 10.0);
				}
				int count = Pathfinder.Navigate(ObjectManager.Me.PositionVector3, To, false, -1).Count;
				if (count > 0 && (count - 1) * Pathfinder.YardsPerWaypoint <= Walk.ProfileSettings.DistancePath)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x0071C778 File Offset: 0x0071A978
		public static void ShowPath(object GoFrom = null, object GoTo = null, bool WalkTo = false)
		{
			Vector3 vector = default(Vector3);
			Vector3 vector2 = default(Vector3);
			if (GoFrom == null)
			{
				vector = ObjectManager.Me.PositionVector3;
			}
			else if (!(GoFrom.GetType() == typeof(string)))
			{
				vector = (Vector3)GoFrom;
			}
			else
			{
				vector = Tools.StringToVector3((string)GoFrom);
			}
			if (GoTo != null)
			{
				if (!(GoTo.GetType() == typeof(string)))
				{
					vector2 = (Vector3)GoTo;
				}
				else
				{
					vector2 = Tools.StringToVector3((string)GoTo);
				}
			}
			else
			{
				vector2 = ObjectManager.Me.PositionVector3;
			}
			if (vector != default(Vector3))
			{
				_globals.TestEnv["OverlayTest"] = false;
				Thread.Sleep(100);
				Overlay.TestPath.Clear();
				List<Vector3> list = Pathfinder.Navigate(vector, vector2, false, -1);
				int count = list.Count;
				if (WalkTo)
				{
					_globals.Waypoints.Clear();
				}
				if (count <= 0)
				{
					Tools.Console("Couldn't calculate Path.", "Red", "richConsole", "frmMain", true);
					return;
				}
				foreach (Vector3 item in list)
				{
					Overlay.TestPath.Add(item);
					if (WalkTo)
					{
						_globals.Waypoints.Add(item);
					}
				}
				Window.Activate(null);
				_globals.TestEnv["OverlayTest"] = true;
				Tools.Console("", "", "richConsole", "frmMain", true);
				Tools.Console("=====================================================", "", "richConsole", "frmMain", true);
				Tools.Console("Calculated Waypoints: " + count.ToString(), "", "richConsole", "frmMain", true);
				Tools.Console("3D Distance: " + JackMath.Distance(vector2, true, true, true).ToString() + " yds", "", "richConsole", "frmMain", true);
				Tools.Console("Walk Distance (" + Pathfinder.YardsPerWaypoint.ToString() + " yds between Waypoints): " + ((count - 1) * Pathfinder.YardsPerWaypoint).ToString(), "", "richConsole", "frmMain", true);
				Tools.Console("=====================================================", "", "richConsole", "frmMain", true);
				Tools.Console("", "", "richConsole", "frmMain", true);
				if (WalkTo)
				{
					frmMain.Start();
					return;
				}
			}
			else
			{
				Tools.Console("Couldn't get Type of From Location.", "Red", "richConsole", "frmMain", true);
			}
		}

		// Token: 0x04000AAE RID: 2734
		private static string DLLPath = _globals.JackData + "\\Pathfinder.dll";

		// Token: 0x04000AAF RID: 2735
		public static int YardsPerWaypoint = 4;

		// Token: 0x04000AB0 RID: 2736
		public static int CurrentMeshID = -1;

		// Token: 0x04000AB1 RID: 2737
		public static object _lock = new object();

		// Token: 0x04000AB2 RID: 2738
		private static Pathfinder.CalculatePathDelegate CalculatePath;

		// Token: 0x04000AB3 RID: 2739
		private static Pathfinder.FreePathArr FreePath;

		// Token: 0x04000AB4 RID: 2740
		private static bool LoadingMap = false;

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x060017B1 RID: 6065
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private unsafe delegate Pathfinder.XYZ* CalculatePathDelegate(uint mapId, Pathfinder.XYZ start, Pathfinder.XYZ end, bool straightPath, out int length, string gamePath);

		// Token: 0x02000102 RID: 258
		// (Invoke) Token: 0x060017B5 RID: 6069
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private unsafe delegate void FreePathArr(Pathfinder.XYZ* pathArr);

		// Token: 0x02000103 RID: 259
		public struct XYZ
		{
			// Token: 0x060017B8 RID: 6072 RVA: 0x0071CA5C File Offset: 0x0071AC5C
			internal XYZ(float x, float y, float z)
			{
				this.X = x;
				this.Y = y;
				this.Z = z;
			}

			// Token: 0x04000AB5 RID: 2741
			internal float X;

			// Token: 0x04000AB6 RID: 2742
			internal float Y;

			// Token: 0x04000AB7 RID: 2743
			internal float Z;
		}
	}
}
