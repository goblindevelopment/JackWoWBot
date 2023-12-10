using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Jack.Core;
using Jack.Models;
using Process.NET;

namespace Jack.Engine
{
	// Token: 0x020000E4 RID: 228
	internal class GameClient
	{
		// Token: 0x06001604 RID: 5636 RVA: 0x00713FD0 File Offset: 0x007121D0
		public static void Check()
		{
			while (Application.OpenForms.OfType<frmMain>().Count<frmMain>() == 0)
			{
				Thread.Sleep(500);
			}
			Process[] array = null;
			for (;;)
			{
				Process[] array2 = null;
				Process process = null;
				if (_globals.ModuleMultiSession == 1)
				{
					goto IL_64;
				}
				if (Settings.JackAutoDetectWindow)
				{
					goto IL_64;
				}
				if (GameClient.AttachProcessID > 0)
				{
					process = Process.GetProcessById(GameClient.AttachProcessID);
					GameClient.AttachProcessID = 0;
				}
				IL_D5:
				if (((array2 != null && array2.Length != 0) || process != null) && !_globals.GameOpen)
				{
					Process process2 = null;
					if (array2 != null && array2.Length != 0)
					{
						process2 = array2[0];
					}
					else if (_globals.ModuleMultiSession > 1 && process != null)
					{
						process2 = process;
					}
					if (process2 != null && process2.MainModule != null && process2.MainModule.FileName != null)
					{
						_globals.ProcessName = process2.ProcessName;
						_globals.ExeName = _globals.ProcessName + ".exe";
						_globals.ProcessFolder = process2.MainModule.FileName.Replace("\\" + _globals.ExeName, "");
						_globals.DetectedBuild = FileVersionInfo.GetVersionInfo(_globals.ProcessFolder + "\\" + _globals.ExeName).FileVersion.Replace(" ", "");
						_globals.ObjectManagerRetail = true;
						_globals.IsClassicEra = _globals.ProcessFolder.Contains("_era_");
						_globals.IsRetail = !_globals.ProcessFolder.Contains("_classic_");
						_globals.IsClassic = (!_globals.IsClassicEra && !_globals.IsRetail);
						if (Initialize.Lists & Initialize.Dictionaries)
						{
							Tools.Console("Lists refreshed.", "", "richConsole", "frmMain", true);
						}
						else
						{
							Tools.Console("Couldn't load Lists.", "Red", "richConsole", "frmMain", true);
						}
						if (!Initialize.MeshMapIDs)
						{
							Tools.Console("Couldn't load Mesh Maps.", "Red", "richConsole", "frmMain", true);
						}
						Build.CheckAndSetOffsets();
						for (;;)
						{
							try
							{
								if (!(Process.GetProcessById(process2.Id).MainWindowHandle != IntPtr.Zero) || Process.GetProcessById(process2.Id).MainWindowTitle.Length <= 0)
								{
									goto IL_4DD;
								}
							}
							catch
							{
								goto IL_4DD;
							}
							break;
							IL_4DD:
							Thread.Sleep(100);
						}
						_globals.processHandle = Process.GetProcessById(process2.Id).MainWindowHandle;
						_globals.processID = process2.Id;
						_globals.processHandleWrite = GameClient.OpenProcess(GameClient.ProcessAccessFlags.All, false, process2.Id);
						_globals.processPointerWrite = GameClient.GetModuleBaseAddress(process2, _globals.ExeName, _globals.processID);
						if (_globals.processHandle != IntPtr.Zero && _globals.processHandleWrite != IntPtr.Zero && _globals.processPointerWrite != IntPtr.Zero)
						{
							_globals.GameOpen = true;
							new Thread(new ThreadStart(GameClient.GameReady))
							{
								IsBackground = true
							}.Start();
							string mainWindowTitle = Process.GetProcessById(process2.Id).MainWindowTitle;
							Tools.Console("Found Game: \"" + mainWindowTitle + "\" " + "[" + _globals.processID.ToString() + "]", "Green", "richConsole", "frmMain", true);
						}
						else
						{
							Tools.Console("Couldn't handle process.", "Red", "richConsole", "frmMain", true);
						}
					}
				}
				if (_globals.GameOpen && !_globals.IsInWorld)
				{
					try
					{
						_globals.processHandleRead = new ProcessSharp(_globals.processID, 1);
						_globals.processPointerRead = _globals.processHandleRead[_globals.processHandleRead.ModuleFactory.MainModule.BaseAddress];
						if (_globals.ObjectManagerRetail)
						{
							_globals.baseObjectManager = _globals.processPointerRead.Read<IntPtr>(Offsets.ObjectManager_Base) + 8;
						}
						else
						{
							_globals.baseObjectManager = _globals.processPointerRead.Read<IntPtr>(Offsets.ObjectManager_Base);
						}
						_globals.playerGUID128 = PlayerMe.LocalGUID;
					}
					catch
					{
					}
					if (_globals.baseObjectManager != IntPtr.Zero && !PlayerMe.LoadingScreen && PlayerMe.LocalGUID != 0)
					{
						_globals.IsInWorld = true;
						while (_globals.playerBaseAddress == IntPtr.Zero)
						{
							Thread.Sleep(500);
						}
						while (PlayerMe.LoadingScreen)
						{
							Thread.Sleep(500);
						}
						Settings.ApplyOnStartBeforeReady();
						_globals.Ready = true;
						Settings.ApplyOnStartAfterReady();
						Tools.Console("In World.", "Green", "richConsole", "frmMain", true);
					}
				}
				Thread.Sleep(500);
				continue;
				IL_64:
				Process[] processesByName = Process.GetProcessesByName(_globals.ProcessNameClassicPTR);
				Process[] processesByName2 = Process.GetProcessesByName(_globals.ProcessNameClassic);
				Process[] processesByName3 = Process.GetProcessesByName(_globals.ProcessNameRetail);
				Process[] processesByName4 = Process.GetProcessesByName(_globals.ProcessNameRetailPTR);
				if (_globals.IsTeam)
				{
					array = Process.GetProcessesByName(_globals.ProcessNameCustom_1);
				}
				if (processesByName.Length != 0)
				{
					array2 = processesByName;
					goto IL_D5;
				}
				if (processesByName2.Length != 0)
				{
					array2 = processesByName2;
					goto IL_D5;
				}
				if (processesByName3.Length != 0)
				{
					array2 = processesByName3;
					goto IL_D5;
				}
				if (processesByName4.Length != 0)
				{
					array2 = processesByName4;
					goto IL_D5;
				}
				if (_globals.IsTeam && array.Length != 0)
				{
					array2 = array;
					goto IL_D5;
				}
				goto IL_D5;
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x007144E4 File Offset: 0x007126E4
		public static void GameReady()
		{
			for (;;)
			{
				if (_globals.GameOpen)
				{
					if (!Process.GetProcesses().Any((Process x) => x.Id == _globals.processID))
					{
						break;
					}
				}
				if (_globals.IsInWorld && PlayerMe.LocalGUID == 0)
				{
					AutoReconnect.Start();
					GameClient.Reset(false);
				}
				else if (_globals.Ready)
				{
					if (PlayerMe.LoadingScreen)
					{
						GameClient.Reset(false);
					}
					else
					{
						GameClient.CheckCamera();
					}
				}
				Thread.Sleep(100);
			}
			GameClient.Reset(true);
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00714570 File Offset: 0x00712770
		public static void Reset(bool Full = false)
		{
			_globals.Ready = false;
			if (!Full)
			{
				Tools.Console("Out of World.", "Orange", "richConsole", "frmMain", true);
			}
			else
			{
				_globals.GameOpen = false;
				_globals.ProcessFolder = "";
				Pathfinder.CurrentMeshID = -1;
				Pathfinder.ReloadDll();
				Tools.Console("Game closed.", "Orange", "richConsole", "frmMain", true);
			}
			_globals.baseObjectManager = IntPtr.Zero;
			_globals.playerBaseAddress = IntPtr.Zero;
			_globals.IsInWorld = false;
			_globals.Start = false;
			Tools.Control("", "btnStart", "frmMain", false, false, false, false, 0);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00714610 File Offset: 0x00712810
		private static void CheckCamera()
		{
			if (!_globals.TestEnv["NoCameraCheck"])
			{
				float positionX = ObjectManager.Camera.PositionX;
				float positionY = ObjectManager.Camera.PositionY;
				if (positionX != 0f)
				{
					if (positionY != 0f && !positionX.ToString().Contains("E") && !positionY.ToString().Contains("E"))
					{
						return;
					}
				}
				GameClient.Reset(false);
				Settings.SetCamera();
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00714688 File Offset: 0x00712888
		public static bool ProcessExists
		{
			get
			{
				return Process.GetProcesses().Any((Process x) => x.Id == _globals.processID);
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x007146C0 File Offset: 0x007128C0
		private static IntPtr GetModuleBaseAddress(Process proc, string modName, int procID = 0)
		{
			IntPtr result = IntPtr.Zero;
			bool flag = false;
			foreach (ProcessModule processModule in proc.Modules)
			{
				if (processModule.ModuleName == modName)
				{
					if (procID <= 0)
					{
						flag = true;
					}
					else if (proc.Id == procID)
					{
						flag = true;
					}
				}
				if (flag)
				{
					result = processModule.BaseAddress;
					break;
				}
			}
			return result;
		}

		// Token: 0x0600160A RID: 5642
		[DllImport("kernel32.dll", SetLastError = true)]
		private static extern IntPtr OpenProcess(GameClient.ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		// Token: 0x04000A51 RID: 2641
		public static int AttachProcessID;

		// Token: 0x04000A52 RID: 2642
		private const int PROCESS_VM_WRITE = 32;

		// Token: 0x04000A53 RID: 2643
		private const int PROCESS_VM_OPERATION = 8;

		// Token: 0x020000E5 RID: 229
		[Flags]
		public enum ProcessAccessFlags : uint
		{
			// Token: 0x04000A55 RID: 2645
			All = 2035711U,
			// Token: 0x04000A56 RID: 2646
			Terminate = 1U,
			// Token: 0x04000A57 RID: 2647
			CreateThread = 2U,
			// Token: 0x04000A58 RID: 2648
			VirtualMemoryOperation = 8U,
			// Token: 0x04000A59 RID: 2649
			VirtualMemoryRead = 16U,
			// Token: 0x04000A5A RID: 2650
			VirtualMemoryWrite = 32U,
			// Token: 0x04000A5B RID: 2651
			DuplicateHandle = 64U,
			// Token: 0x04000A5C RID: 2652
			CreateProcess = 128U,
			// Token: 0x04000A5D RID: 2653
			SetQuota = 256U,
			// Token: 0x04000A5E RID: 2654
			SetInformation = 512U,
			// Token: 0x04000A5F RID: 2655
			QueryInformation = 1024U,
			// Token: 0x04000A60 RID: 2656
			QueryLimitedInformation = 4096U,
			// Token: 0x04000A61 RID: 2657
			Synchronize = 1048576U
		}
	}
}
