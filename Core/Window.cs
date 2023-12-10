using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Jack.Engine;

namespace Jack.Core
{
	// Token: 0x0200010C RID: 268
	public static class Window
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x007248B4 File Offset: 0x00722AB4
		public static void Activate(Form Form = null)
		{
			if (Form == null)
			{
				object @lock = Window._lock;
				lock (@lock)
				{
					Window.SetForegroundWindow(_globals.processHandle);
					return;
				}
			}
			Window.SetForegroundWindow(Form.Handle);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00724908 File Offset: 0x00722B08
		public static void Activate(IntPtr Handle)
		{
			if (Handle != IntPtr.Zero)
			{
				Window.SetForegroundWindow(Handle);
			}
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0072492C File Offset: 0x00722B2C
		public static bool IsForeground(IntPtr Handle = default(IntPtr))
		{
			if (Handle == (IntPtr)0)
			{
				Handle = _globals.processHandle;
			}
			return Window.GetForegroundWindow() == Handle;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00724958 File Offset: 0x00722B58
		public static void Enable(IntPtr Handle = default(IntPtr), bool Enable = true)
		{
			if (Handle == (IntPtr)0)
			{
				Handle = _globals.processHandle;
			}
			Window.EnableWindow(Handle, Enable);
			_globals.WindowEnabled = Enable;
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x00724984 File Offset: 0x00722B84
		public static bool IsMyHandle
		{
			get
			{
				return Window.IsForeground((IntPtr)0) || Window.IsForeground(_globals.MyHandle) || Window.IsForeground(_globals.MyHandleProfile) || Window.IsForeground(_globals.MyHandleProfileEvent);
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x007249C4 File Offset: 0x00722BC4
		public static int[] Dimensions
		{
			get
			{
				if (_globals.processHandle == IntPtr.Zero)
				{
					return new int[]
					{
						-1,
						-1
					};
				}
				int cbAttribute = Marshal.SizeOf(typeof(Window.Rect));
				Window.Rect rect;
				Window.DwmGetWindowAttribute(_globals.processHandle, 9, out rect, cbAttribute);
				int cbAttribute2 = Marshal.SizeOf(typeof(Window.Rect));
				Window.Rect rect2;
				Window.DwmGetWindowAttribute(_globals.processHandle, 5, out rect2, cbAttribute2);
				Window.Rect rect3 = default(Window.Rect);
				Window.GetClientRect(_globals.processHandle, ref rect3);
				int num = rect2.Bottom - rect2.Top;
				return new int[]
				{
					rect.Left,
					rect.Top + num,
					rect3.Right,
					rect3.Bottom - num
				};
			}
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00724A88 File Offset: 0x00722C88
		public static bool IsFullScreen(Screen screen = null)
		{
			if (_globals.processHandle == IntPtr.Zero)
			{
				return false;
			}
			if (screen == null)
			{
				screen = Screen.PrimaryScreen;
			}
			Window.Rect rect = default(Window.Rect);
			Window.GetWindowRect(new HandleRef(null, _globals.processHandle), ref rect);
			return screen.Bounds.Width == rect.Right - rect.Left && screen.Bounds.Height == rect.Bottom - rect.Top;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00724B0C File Offset: 0x00722D0C
		public static void Attach(int ProcessID = 0)
		{
			if (_globals.ModuleMultiSession > 1)
			{
				Tools.Control("", "btnAttach", "frmMain", false, false, false, false, 0);
				if (ProcessID == 0)
				{
					while (!Tools.MouseIsPressed("Left"))
					{
						Thread.Sleep(10);
					}
					Thread.Sleep(250);
					IntPtr foregroundWindow = Window.GetForegroundWindow();
					if (foregroundWindow != IntPtr.Zero)
					{
						try
						{
							Window.GetWindowThreadProcessId(foregroundWindow, out ProcessID);
						}
						catch
						{
							ProcessID = 0;
						}
					}
				}
				if (ProcessID > 0)
				{
					Process processById = Process.GetProcessById(ProcessID);
					List<string> list = new List<string>
					{
						_globals.ProcessNameClassicPTR,
						_globals.ProcessNameClassic,
						_globals.ProcessNameRetailPTR,
						_globals.ProcessNameRetail
					};
					if (_globals.IsTeam)
					{
						list.Add(_globals.ProcessNameCustom_1);
					}
					if (processById != null)
					{
						if (list.Contains(processById.ProcessName))
						{
							if (_globals.GameOpen)
							{
								GameClient.Reset(true);
							}
							Tools.Console("Attaching Jack (" + ProcessID.ToString() + ")...", "Orange", "richConsole", "frmMain", true);
							GameClient.AttachProcessID = ProcessID;
						}
						else
						{
							Tools.Console("Please choose a WoW window.", "Red", "richConsole", "frmMain", true);
						}
					}
					else
					{
						Tools.Console("The process could not be found.", "Red", "richConsole", "frmMain", true);
					}
				}
				else
				{
					Tools.Console("The process could not be found.", "Red", "richConsole", "frmMain", true);
				}
				Tools.Control("", "btnAttach", "frmMain", true, false, false, false, 0);
			}
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00724CA4 File Offset: 0x00722EA4
		public static void SetParentWindow(IntPtr ChildWindow)
		{
			if (_globals.processHandle == IntPtr.Zero)
			{
				return;
			}
			Window.SetWindowLong(ChildWindow, -8, _globals.processHandle);
		}

		// Token: 0x06001864 RID: 6244
		[DllImport("User32.dll")]
		private static extern int SetForegroundWindow(IntPtr point);

		// Token: 0x06001865 RID: 6245
		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		// Token: 0x06001866 RID: 6246
		[DllImport("user32.dll")]
		private static extern bool GetClientRect(IntPtr hWnd, ref Window.Rect rect);

		// Token: 0x06001867 RID: 6247
		[DllImport("user32.dll")]
		private static extern int GetWindowRect(HandleRef hWnd, [In] [Out] ref Window.Rect rect);

		// Token: 0x06001868 RID: 6248
		[DllImport("user32.dll")]
		private static extern int GetWindowRect(IntPtr hWnd, out Rectangle rect);

		// Token: 0x06001869 RID: 6249
		[DllImport("user32.dll")]
		private static extern bool EnableWindow(IntPtr hWnd, bool enable);

		// Token: 0x0600186A RID: 6250
		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowThreadProcessId(IntPtr hWnd, out int processId);

		// Token: 0x0600186B RID: 6251
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

		// Token: 0x0600186C RID: 6252
		[DllImport("dwmapi.dll")]
		private static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Window.Rect pvAttribute, int cbAttribute);

		// Token: 0x04000B92 RID: 2962
		private static readonly object _lock = new object();

		// Token: 0x0200010D RID: 269
		private struct Rect
		{
			// Token: 0x04000B93 RID: 2963
			public int Left;

			// Token: 0x04000B94 RID: 2964
			public int Top;

			// Token: 0x04000B95 RID: 2965
			public int Right;

			// Token: 0x04000B96 RID: 2966
			public int Bottom;
		}

		// Token: 0x0200010E RID: 270
		[Flags]
		private enum DwmWindowAttribute : uint
		{
			// Token: 0x04000B98 RID: 2968
			DWMWA_NCRENDERING_ENABLED = 1U,
			// Token: 0x04000B99 RID: 2969
			DWMWA_NCRENDERING_POLICY = 2U,
			// Token: 0x04000B9A RID: 2970
			DWMWA_TRANSITIONS_FORCEDISABLED = 3U,
			// Token: 0x04000B9B RID: 2971
			DWMWA_ALLOW_NCPAINT = 4U,
			// Token: 0x04000B9C RID: 2972
			DWMWA_CAPTION_BUTTON_BOUNDS = 5U,
			// Token: 0x04000B9D RID: 2973
			DWMWA_NONCLIENT_RTL_LAYOUT = 6U,
			// Token: 0x04000B9E RID: 2974
			DWMWA_FORCE_ICONIC_REPRESENTATION = 7U,
			// Token: 0x04000B9F RID: 2975
			DWMWA_FLIP3D_POLICY = 8U,
			// Token: 0x04000BA0 RID: 2976
			DWMWA_EXTENDED_FRAME_BOUNDS = 9U,
			// Token: 0x04000BA1 RID: 2977
			DWMWA_HAS_ICONIC_BITMAP = 10U,
			// Token: 0x04000BA2 RID: 2978
			DWMWA_DISALLOW_PEEK = 11U,
			// Token: 0x04000BA3 RID: 2979
			DWMWA_EXCLUDED_FROM_PEEK = 12U,
			// Token: 0x04000BA4 RID: 2980
			DWMWA_CLOAK = 13U,
			// Token: 0x04000BA5 RID: 2981
			DWMWA_CLOAKED = 14U,
			// Token: 0x04000BA6 RID: 2982
			DWMWA_FREEZE_REPRESENTATION = 15U,
			// Token: 0x04000BA7 RID: 2983
			DWMWA_LAST = 16U
		}
	}
}
