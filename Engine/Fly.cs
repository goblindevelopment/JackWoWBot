using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using Jack.Core;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000C5 RID: 197
	public static class Fly
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0070D2E8 File Offset: 0x0070B4E8
		// (set) Token: 0x060014F0 RID: 5360 RVA: 0x0070D2FC File Offset: 0x0070B4FC
		public static bool Stop { get; set; }

		// Token: 0x060014F1 RID: 5361 RVA: 0x0070D310 File Offset: 0x0070B510
		public static void Go()
		{
			int num = 5;
			if (Walk.CheckProfileSettings && Walk.ProfileSettings.ExpertFlightTolerance >= 3)
			{
				num = Walk.ProfileSettings.ExpertFlightTolerance;
			}
			if (Walk.CanFastFly)
			{
				num++;
			}
			while (_globals.Start)
			{
				if (!Fly.Runs)
				{
					Fly.Runs = true;
				}
				try
				{
					if (!Fly.Stop && (ObjectManager.Me.IsInVashjir || (Walk.CanFly && Walk.CheckProfileSettings && Walk.ProfileSettings.FlightMount && ObjectManager.Me.IsMounted)))
					{
						Fly.SetDistanceToReach(true);
						float z = _globals.Waypoints[Walk.Counter].Z;
						float num2 = JackMath.Absolute(JackMath.ZDifferenceValue(z), true);
						double num3 = JackMath.ZDifferenceValue(z);
						if (num2 <= (float)num)
						{
							Fly.ReleaseKeys();
							Fly.PitchMe();
						}
						else if (num3 < 0.0)
						{
							Fly.Direction(z, "Jump", "MoveDown");
						}
						else if (num3 > 0.0)
						{
							Fly.Direction(z, "MoveDown", "Jump");
						}
					}
					else
					{
						Fly.SetDistanceToReach(false);
					}
				}
				catch
				{
				}
				Thread.Sleep(250);
			}
			Fly.Runs = false;
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0070D46C File Offset: 0x0070B66C
		private static void Direction(float ToPositionZ, string Press, string Release)
		{
			if (_globals.KeyStatus[Release])
			{
				Key.Release(Release);
				Thread.Sleep(30);
			}
			Key.Press(Press);
			while (!Fly.Stop && _globals.Start && ObjectManager.Me.IsFlying && ((Press == "Jump" && JackMath.ZDifferenceValue(ToPositionZ) < 0.0) || (Press == "MoveDown" && JackMath.ZDifferenceValue(ToPositionZ) > 0.0)))
			{
				Key.Press(Press);
				Thread.Sleep(10);
			}
			if (Fly.Stop)
			{
				Fly.ReleaseKeys();
			}
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0070D50C File Offset: 0x0070B70C
		private static void SetDistanceToReach(bool Flight = true)
		{
			if (Flight && Walk.DistanceToReach < 4.0)
			{
				Walk.DistanceToReach = 4.0;
				return;
			}
			if (!Flight && Walk.DistanceToReach == 4.0)
			{
				Walk.DistanceToReach = 1.0;
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0070D55C File Offset: 0x0070B75C
		private static void ReleaseKeys()
		{
			if (_globals.KeyStatus["Jump"])
			{
				Key.Release("Jump");
			}
			if (_globals.KeyStatus["MoveDown"])
			{
				Key.Release("MoveDown");
			}
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0070D5A0 File Offset: 0x0070B7A0
		public static bool MoveDown(Vector3 Position = default(Vector3), string Name = "", bool IsNode = false)
		{
			if (!ObjectManager.Me.IsFlying)
			{
				return true;
			}
			Tools.Console("Flying down...", "Blue", "richConsole", "frmMain", true);
			while (_globals.KeyStatus["MoveDown"])
			{
				Thread.Sleep(100);
			}
			Key.Release("All");
			Key.Press("MoveDown");
			string name = Tools.RandomTimer("MoveDown");
			Timer.Set(name, 15000);
			List<Player> list = new List<Player>();
			while (_globals.Start && ObjectManager.Me.IsFlying && Timer.Check(name) != 0 && list.Count == 0)
			{
				if (IsNode)
				{
					list = ObjectManager.GetPlayersAround(Position, "Gather", 8);
				}
				if (ObjectManager.Me.IsInVashjir && JackMath.ZDifference(Position, 2.0))
				{
					break;
				}
				Thread.Sleep(250);
			}
			Key.Release("MoveDown");
			if (!_globals.IsRetail && IsNode && (list.Count > 0 || ObjectManager.GetPlayersAround(Position, "Gather", 8).Count > 0))
			{
				Tools.Console("Another player was faster...", "", "richConsole", "frmMain", true);
				return false;
			}
			if (Position != default(Vector3) && (JackMath.Distance(Position, true, true, true) > 8.0 || Timer.Check(name) == 0))
			{
				Walk.AddToBlacklist(Position, Name);
			}
			return true;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0070D700 File Offset: 0x0070B900
		public static void MoveUp(List<UInt128> Until = null, Units Unit = null, Objects Object = null)
		{
			if (ObjectManager.Me.IsFlying && (ObjectManager.Me.IsInVashjir || ObjectManager.GetAttackers.Count == 0))
			{
				Vector3 vector = default(Vector3);
				string name = "N/A";
				if (Until != null)
				{
					Unit = ObjectManager.GetClosestUnit(Until);
				}
				if (Unit != null)
				{
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						vector = Unit.PositionVector3;
						name = Unit.Name;
						goto IL_A8;
					}
				}
				if (Until != null)
				{
					Object = ObjectManager.GetClosestObject(Until);
				}
				if (Object != null)
				{
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						vector = Object.PositionVector3;
						name = Object.Name;
					}
				}
				IL_A8:
				if (vector != default(Vector3) && JackMath.ZDifferenceValue(vector.Z) < 0.0)
				{
					Tools.Console("Flying up...", "Blue", "richConsole", "frmMain", true);
					while (_globals.KeyStatus["Jump"])
					{
						Thread.Sleep(100);
					}
					Key.Release("All");
					Key.Press("Jump");
					string name2 = Tools.RandomTimer("MoveUp");
					Timer.Set(name2, 10000);
					while (_globals.Start && ObjectManager.Me.IsFlying && JackMath.ZDifferenceValue(vector.Z) < 5.0 && Timer.Check(name2) != 0)
					{
						Thread.Sleep(250);
					}
					Key.Release("Jump");
					if (ObjectManager.Me.IsInVashjir && Unit != null)
					{
						return;
					}
					if (vector != default(Vector3) && (JackMath.ZDifferenceValue(vector.Z) < 3.0 || Timer.Check(name2) == 0))
					{
						Walk.AddToBlacklist(vector, name);
					}
				}
			}
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x0070D8F0 File Offset: 0x0070BAF0
		private static void PitchMe()
		{
			if (ObjectManager.Me.IsFlying)
			{
				if ((double)ObjectManager.Me.Pitch < -0.1)
				{
					Key.Press("PitchUp");
					while (!Fly.Stop && _globals.Start && ObjectManager.Me.IsFlying && (double)ObjectManager.Me.Pitch < -0.005)
					{
						Thread.Sleep(10);
					}
					Key.Release("PitchUp");
					return;
				}
				if ((double)ObjectManager.Me.Pitch > 0.1)
				{
					Key.Press("PitchDown");
					while (!Fly.Stop && _globals.Start && ObjectManager.Me.IsFlying && (double)ObjectManager.Me.Pitch > 0.005)
					{
						Thread.Sleep(10);
					}
					Key.Release("PitchDown");
				}
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0070D9D8 File Offset: 0x0070BBD8
		public static void Trigger()
		{
			if (ObjectManager.Me.IsInVashjir)
			{
				return;
			}
			if (ObjectManager.Me.IsMounted && ObjectManager.GetAttackers.Count == 0)
			{
				Key.Press("Jump");
				string name = Tools.RandomTimer("WaitToFly");
				Timer.Set(name, 1500);
				while (!ObjectManager.Me.IsFlying && Timer.Check(name) != 0)
				{
					Thread.Sleep(100);
				}
				Key.Release("Jump");
			}
		}

		// Token: 0x040009F2 RID: 2546
		public static bool Runs;
	}
}
