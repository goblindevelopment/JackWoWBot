using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Jack.Engine;

namespace Jack.Core
{
	// Token: 0x020000FB RID: 251
	public static class AutoReconnect
	{
		// Token: 0x0600171F RID: 5919 RVA: 0x0071A918 File Offset: 0x00718B18
		public static void Start()
		{
			if (AutoReconnect.IsRunning)
			{
				return;
			}
			AutoReconnect.IsRunning = true;
			if (_globals.ProcessFolder.Length == 0 || _globals.processID == 0)
			{
				AutoReconnect.IsRunning = false;
				return;
			}
			if (Settings.JackAutoReconnectPassword.Length != 0)
			{
				AutoReconnect.ProcessID = _globals.processID;
				AutoReconnect.ProcessFolder = _globals.ProcessFolder;
				AutoReconnect.ExeName = _globals.ExeName;
				AutoReconnect.FullExePath = AutoReconnect.ProcessFolder + "\\" + AutoReconnect.ExeName;
				if (Settings.JackAutoReconnect)
				{
					new Thread(new ThreadStart(AutoReconnect.AutoLogin))
					{
						IsBackground = true
					}.Start();
				}
				return;
			}
			AutoReconnect.IsRunning = false;
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0071A9BC File Offset: 0x00718BBC
		public static void AutoLogin()
		{
			if (AutoReconnect.SendPing())
			{
				AutoReconnect.IsRunning = false;
				return;
			}
			Tools.Console("Connection lost. Auto-Reconnect started...", "Orange", "richConsole", "frmMain", true);
			Tools.ControlVisible("lblCancel", "frmMain", true);
			if (!AutoReconnect.CheckConnection())
			{
				AutoReconnect.smethod_0();
				return;
			}
			Tools.Console("Closing WoW...", "Orange", "richConsole", "frmMain", true);
			Tools.KillProcessAndChilds(AutoReconnect.ProcessID);
			string name = Tools.RandomTimer("AutoReconnect1");
			Jack.Engine.Timer.Set(name, 20000);
			while (!frmMain.Cancel && _globals.GameOpen && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(1000);
			}
			if (frmMain.Cancel || _globals.GameOpen)
			{
				Tools.Console("Couldn't close WoW. Auto-Reconnect stopped.", "Red", "richConsole", "frmMain", true);
				AutoReconnect.smethod_0();
				return;
			}
			Tools.Console("Starting WoW...", "Orange", "richConsole", "frmMain", true);
			if (_globals.ModuleMultiSession > 1 && !Settings.JackAutoDetectWindow)
			{
				int num = Tools.StartProcessGetID(AutoReconnect.FullExePath, "");
				if (num == 0 || frmMain.Cancel)
				{
					Tools.Console("Couldn't receive process data. Auto-Reconnect stopped.", "Red", "richConsole", "frmMain", true);
					AutoReconnect.smethod_0();
					return;
				}
				Window.Attach(num);
			}
			else
			{
				Tools.StartProcess(AutoReconnect.FullExePath, "", false);
			}
			Tools.Console("Waiting for Login Screen...", "Orange", "richConsole", "frmMain", true);
			name = Tools.RandomTimer("AutoReconnect2");
			Jack.Engine.Timer.Set(name, 20000);
			while (!frmMain.Cancel && !_globals.GameOpen && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(1000);
			}
			if (frmMain.Cancel || !_globals.GameOpen)
			{
				Tools.Console("Start or attaching failed. Auto-Reconnect stopped.", "Red", "richConsole", "frmMain", true);
				AutoReconnect.smethod_0();
				return;
			}
			Thread.Sleep(15000);
			int num2 = 0;
			while (!frmMain.Cancel && !Window.IsForeground((IntPtr)0))
			{
				Window.Activate(null);
				Thread.Sleep(2000);
				num2++;
				if (num2 == 10)
				{
					break;
				}
			}
			if (num2 == 10 || frmMain.Cancel)
			{
				Tools.Console("Couldn't activate Window. Auto-Reconnect stopped.", "Red", "richConsole", "frmMain", true);
				AutoReconnect.smethod_0();
				return;
			}
			Tools.Console("Login...", "Orange", "richConsole", "frmMain", true);
			SendKeys.SendWait(Crypt.Base64Decode(Settings.JackAutoReconnectPassword));
			Thread.Sleep(1000);
			SendKeys.SendWait("{ENTER}");
			int num3 = 0;
			while (num3 < 10 && !frmMain.Cancel)
			{
				Thread.Sleep(1000);
				num3++;
			}
			if (frmMain.Cancel)
			{
				return;
			}
			SendKeys.SendWait("{ENTER}");
			Thread.Sleep(1000);
			Tools.Console("Waiting until ready...", "Orange", "richConsole", "frmMain", true);
			name = Tools.RandomTimer("AutoReconnect3");
			Jack.Engine.Timer.Set(name, 30000);
			while (!frmMain.Cancel && !_globals.Ready && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(1000);
			}
			AutoReconnect.smethod_0();
			if (_globals.Ready && !frmMain.Cancel)
			{
				frmMain.Start();
				return;
			}
			Tools.Console("Not ready. Auto-Reconnect stopped.", "Red", "richConsole", "frmMain", true);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0071AD10 File Offset: 0x00718F10
		private static bool CheckConnection()
		{
			Tools.Console("Waiting for connection...", "Orange", "richConsole", "frmMain", true);
			Thread.Sleep(10000);
			bool flag;
			if (!(flag = AutoReconnect.SendPing()))
			{
				while (!flag && !frmMain.Cancel)
				{
					Tools.Console("Offline. Next Check in 10 sec...", "Red", "richConsole", "frmMain", true);
					int num = 0;
					while (num < 10 && !frmMain.Cancel)
					{
						Thread.Sleep(1000);
						num++;
					}
					flag = AutoReconnect.SendPing();
				}
				if (!frmMain.Cancel)
				{
					Tools.Console("Online.", "Green", "richConsole", "frmMain", true);
					return true;
				}
				Tools.Console("Auto-Reconnect cancelled.", "Red", "richConsole", "frmMain", true);
			}
			return false;
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0071ADD8 File Offset: 0x00718FD8
		private static bool SendPing()
		{
			try
			{
				string hostNameOrAddress = "8.8.8.8";
				byte[] buffer = new byte[32];
				Ping ping = new Ping();
				PingOptions options = new PingOptions();
				return ping.Send(hostNameOrAddress, 1000, buffer, options).Status == IPStatus.Success;
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0071AE68 File Offset: 0x00719068
		[CompilerGenerated]
		internal static void smethod_0()
		{
			Tools.ControlVisible("lblCancel", "frmMain", false);
			frmMain.Cancel = false;
			AutoReconnect.IsRunning = false;
		}

		// Token: 0x04000AA3 RID: 2723
		public static int ProcessID = 0;

		// Token: 0x04000AA4 RID: 2724
		public static string ProcessFolder = "";

		// Token: 0x04000AA5 RID: 2725
		public static string ExeName = "";

		// Token: 0x04000AA6 RID: 2726
		public static string FullExePath = "";

		// Token: 0x04000AA7 RID: 2727
		public static bool IsRunning = false;
	}
}
