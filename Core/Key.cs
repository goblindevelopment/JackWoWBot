using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Jack.Core
{
	// Token: 0x02000113 RID: 275
	public static class Key
	{
		// Token: 0x060018DF RID: 6367 RVA: 0x00726050 File Offset: 0x00724250
		public static string Get(string KeyName)
		{
			if (_globals.Keys.ContainsKey(KeyName))
			{
				return _globals.Keys[KeyName];
			}
			return "";
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0072607C File Offset: 0x0072427C
		public static void Press(string Key)
		{
			string text = Key.Get(Key);
			if (text.Length > 0)
			{
				if (!Key.IsPressed(Key))
				{
					_globals.KeyStatus[Key] = true;
					KeyType wParam = (KeyType)Enum.Parse(typeof(KeyType), text);
					Key.PostMessage(_globals.processHandle, 256U, (int)wParam, IntPtr.Zero);
					return;
				}
			}
			else
			{
				Tools.Console("Key (Press) \"" + Key + "\" is not defined.", "Red", "richConsole", "frmMain", true);
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00726100 File Offset: 0x00724300
		public static void MouseClick(string Key)
		{
			string text = Key.Get(Key);
			if (text.Length > 0)
			{
				KeyType wParam = (KeyType)Enum.Parse(typeof(KeyType), text);
				Thread.Sleep(100);
				Key.PostMessage(_globals.processHandle, 513U, (int)wParam, IntPtr.Zero);
				Thread.Sleep(100);
				Key.PostMessage(_globals.processHandle, 514U, (int)wParam, IntPtr.Zero);
				return;
			}
			Tools.Console("Key (MousePress) \"" + Key + "\" is not defined.", "Red", "richConsole", "frmMain", true);
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00726194 File Offset: 0x00724394
		public static void TurnLeft45()
		{
			Key.Press("TurnLeft");
			Thread.Sleep(250);
			Key.Release("TurnLeft");
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x007261C0 File Offset: 0x007243C0
		public static void TurnLeft90()
		{
			Key.Press("TurnLeft");
			Thread.Sleep(500);
			Key.Release("TurnLeft");
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x007261EC File Offset: 0x007243EC
		public static void TurnLeft135()
		{
			Key.Press("TurnLeft");
			Thread.Sleep(750);
			Key.Release("TurnLeft");
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00726218 File Offset: 0x00724418
		public static void TurnRight45()
		{
			Key.Press("TurnRight");
			Thread.Sleep(250);
			Key.Release("TurnRight");
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00726244 File Offset: 0x00724444
		public static void TurnRight90()
		{
			Key.Press("TurnRight");
			Thread.Sleep(500);
			Key.Release("TurnRight");
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00726270 File Offset: 0x00724470
		public static void TurnRight135()
		{
			Key.Press("TurnRight");
			Thread.Sleep(750);
			Key.Release("TurnRight");
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0072629C File Offset: 0x0072449C
		public static void Turn180()
		{
			int num = new Random().Next(0, 2);
			string str = "Left";
			if (num == 1)
			{
				str = "Right";
			}
			Key.Press("Turn" + str);
			Thread.Sleep(1000);
			Key.Release("Turn" + str);
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x007262F0 File Offset: 0x007244F0
		public static void Release(string Key)
		{
			if (Key == "All")
			{
				Key.Release("MoveForward");
				Key.Release("TurnLeft");
				Key.Release("TurnRight");
				Key.Release("MoveDown");
				Key.Release("Jump");
				Key.Release("PitchUp");
				Key.Release("PitchDown");
				Thread.Sleep(30);
				return;
			}
			string text = Key.Get(Key);
			if (text.Length > 0)
			{
				if (Key.IsPressed(Key))
				{
					_globals.KeyStatus[Key] = false;
					KeyType wParam = (KeyType)Enum.Parse(typeof(KeyType), text);
					Key.PostMessage(_globals.processHandle, 257U, (int)wParam, IntPtr.Zero);
					return;
				}
			}
			else
			{
				Tools.Console("Key (Release) \"" + Key + "\" is not defined.", "Red", "richConsole", "frmMain", true);
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x0066CF2C File Offset: 0x0066B12C
		public static bool IsCtrlDown
		{
			get
			{
				return (Control.ModifierKeys & Keys.Control) == Keys.Control;
			}
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x007263D0 File Offset: 0x007245D0
		public static bool IsPressed(string Key)
		{
			return _globals.KeyStatus[Key];
		}

		// Token: 0x060018EC RID: 6380
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x060018ED RID: 6381
		[DllImport("user32.dll")]
		public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, IntPtr lParam);
	}
}
