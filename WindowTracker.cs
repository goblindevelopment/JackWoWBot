using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using MyU9Ep58ZH3s5ThDFJQ;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x0200004E RID: 78
	public class WindowTracker
	{
		// Token: 0x060007A5 RID: 1957
		[DllImport("user32.dll", EntryPoint = "GetClientRect")]
		private static extern bool WQZcnHApLM(IntPtr \u0020, out WindowTracker.RECT \u0020);

		// Token: 0x060007A6 RID: 1958
		[DllImport("user32.dll")]
		public static extern bool GetWindowRect(IntPtr hWnd, out WindowTracker.RECT lpRect);

		// Token: 0x060007A7 RID: 1959
		[DllImport("user32.dll", EntryPoint = "SetWinEventHook")]
		private static extern IntPtr KcWc0sATTh(uint \u0020, uint \u0020, IntPtr \u0020, WindowTracker.qKk3X55ErqkNnxUyZpx \u0020, uint \u0020, uint \u0020, uint \u0020);

		// Token: 0x060007A8 RID: 1960
		[DllImport("user32.dll")]
		public static extern IntPtr GetForegroundWindow();

		// Token: 0x060007A9 RID: 1961
		[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
		private static extern int oM6cJhqr5h(IntPtr \u0020, out uint \u0020);

		// Token: 0x060007AA RID: 1962
		[DllImport("user32.dll", EntryPoint = "UnhookWinEvent")]
		private static extern bool hYEcmbGPTQ(IntPtr \u0020);

		// Token: 0x060007AB RID: 1963 RVA: 0x0003B858 File Offset: 0x00039A58
		public WindowTracker()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			WindowTracker.E433C3f6InL92Qbw5WE();
			base..ctor();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					WindowTracker.KcWc0sATTh(3U, 3U, IntPtr.Zero, WindowTracker.procDelegate, 0U, 0U, 0U);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				}
			}
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0003B8E4 File Offset: 0x00039AE4
		private static void edlcHV1pg4(IntPtr \u0020, uint \u0020, IntPtr \u0020, int \u0020, int \u0020, uint \u0020, uint \u0020)
		{
			WindowTracker.FfacjtfNtZrBDUrKpqN();
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0003B8EC File Offset: 0x00039AEC
		public static void GetForegroundProcessName()
		{
			int num = 7;
			for (;;)
			{
				int num2 = num;
				Process[] array;
				for (;;)
				{
					Process process;
					int num3;
					bool gameFocused;
					IntPtr foregroundWindow;
					switch (num2)
					{
					case 1:
						if (!WindowTracker.VALYusfHS0KVb3NIvfq(process.ProcessName, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(764415235 ^ 764433595)))
						{
							goto Block_23;
						}
						goto IL_524;
					case 2:
					{
						Rectangle rectangle = WindowTracker.GameRect.ToRectangle();
						num2 = 25;
						continue;
					}
					case 3:
						return;
					case 4:
						num3 = 0;
						num2 = 24;
						continue;
					case 5:
						gameFocused = (process.ProcessName == vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-87166655 + -2142521002 ^ 2065297551));
						goto IL_525;
					case 6:
					{
						uint num4;
						WindowTracker.oM6cJhqr5h(foregroundWindow, out num4);
						num2 = 9;
						continue;
					}
					case 7:
						foregroundWindow = WindowTracker.GetForegroundWindow();
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 8:
						return;
					case 9:
						goto IL_375;
					case 10:
						if (WindowTracker.VALYusfHS0KVb3NIvfq(WindowTracker.HJP6FkfJDqKS0vr8TpI(process), WindowTracker.K8oypifmJg2VCiFRvPV(185404423 + 1853889833 ^ 2039312566)))
						{
							goto IL_524;
						}
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae != 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 11:
						goto IL_38A;
					case 12:
						Console.WriteLine(WindowTracker.K8oypifmJg2VCiFRvPV(1633072087 ^ 1633085833), WindowTracker.titleBarSize);
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 13:
						goto IL_524;
					case 14:
						goto IL_3BD;
					case 15:
						IL_438:
						process = array[num3];
						num2 = 23;
						continue;
					case 16:
						if (!WindowTracker.VALYusfHS0KVb3NIvfq(WindowTracker.HJP6FkfJDqKS0vr8TpI(process), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(567103098 ^ 567089130)))
						{
							goto IL_264;
						}
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 17:
						WindowTracker.GameFocused = false;
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 18:
					{
						WindowTracker.RECT rect;
						WindowTracker.WQZcnHApLM(foregroundWindow, out rect);
						num2 = 16;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 != 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					}
					case 19:
						if (!WindowTracker.GameFocused)
						{
							num2 = 11;
							continue;
						}
						goto IL_3BD;
					case 20:
						goto IL_264;
					case 21:
					{
						Rectangle rectangle;
						int height = rectangle.Height;
						WindowTracker.RECT rect;
						rectangle = rect.ToRectangle();
						WindowTracker.titleBarSize = height - rectangle.Height - WindowTracker.borderSize;
						num2 = 28;
						continue;
					}
					case 22:
						WindowTracker.GetWindowRect(foregroundWindow, out WindowTracker.GameRect);
						num2 = 2;
						continue;
					case 23:
					{
						uint num4;
						if ((long)WindowTracker.YwDXGif0vlBiWMN9cq7(process) == (long)((ulong)num4))
						{
							num2 = 30;
							continue;
						}
						num3++;
						goto IL_456;
					}
					case 24:
						goto IL_456;
					case 25:
					{
						Rectangle rectangle;
						int width = rectangle.Width;
						WindowTracker.RECT rect;
						rectangle = rect.ToRectangle();
						WindowTracker.borderSize = (width - rectangle.Width) / 2;
						num2 = 27;
						continue;
					}
					case 26:
						if (WindowTracker.VALYusfHS0KVb3NIvfq(WindowTracker.HJP6FkfJDqKS0vr8TpI(process), WindowTracker.K8oypifmJg2VCiFRvPV(~2095831454 ^ -2095808599)))
						{
							goto IL_524;
						}
						num2 = 29;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 27:
					{
						Rectangle rectangle = WindowTracker.GameRect.ToRectangle();
						num2 = 21;
						continue;
					}
					case 28:
						WindowTracker.empJCmftKHDqkD4U46p(WindowTracker.K8oypifmJg2VCiFRvPV(1386050510 + 11679858 ^ 1397749366), WindowTracker.borderSize);
						num2 = 12;
						continue;
					case 29:
						if (WindowTracker.VALYusfHS0KVb3NIvfq(process.ProcessName, WindowTracker.K8oypifmJg2VCiFRvPV(1638637009 >> 6 ^ 25622423)) || WindowTracker.VALYusfHS0KVb3NIvfq(process.ProcessName, WindowTracker.K8oypifmJg2VCiFRvPV(2040894867 + -686633457 ^ 1354250840)))
						{
							goto IL_524;
						}
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 30:
						WindowTracker.CurrentProcessName = WindowTracker.HJP6FkfJDqKS0vr8TpI(process);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					Console.WriteLine(WindowTracker.CurrentProcessName);
					num2 = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
					{
						num2 = 10;
						continue;
					}
					continue;
					IL_264:
					if (WindowTracker.VALYusfHS0KVb3NIvfq(process.ProcessName, WindowTracker.K8oypifmJg2VCiFRvPV(-160910942 << 4 ^ 1720402876)) || WindowTracker.VALYusfHS0KVb3NIvfq(WindowTracker.HJP6FkfJDqKS0vr8TpI(process), WindowTracker.K8oypifmJg2VCiFRvPV(1633072087 ^ 1633086079)))
					{
						goto IL_524;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_3BD:
					WindowTracker.GameHWND = foregroundWindow;
					num2 = 18;
					continue;
					IL_456:
					if (num3 < array.Length)
					{
						goto IL_438;
					}
					num2 = 17;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_525:
					WindowTracker.GameFocused = gameFocused;
					num2 = 19;
					continue;
					IL_524:
					gameFocused = true;
					goto IL_525;
				}
				IL_375:
				array = WindowTracker.PYXOjFfnligvDunp2JK();
				num = 4;
				continue;
				Block_23:
				num = 26;
			}
			return;
			IL_38A:;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0003BE2C File Offset: 0x0003A02C
		// Note: this type is marked as 'beforefieldinit'.
		static WindowTracker()
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					WindowTracker.CurrentProcessName = "";
					num2 = 2;
					continue;
				case 2:
					WindowTracker.GameFocused = false;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					WindowTracker.procDelegate = new WindowTracker.qKk3X55ErqkNnxUyZpx(WindowTracker.edlcHV1pg4);
					num2 = 3;
					continue;
				case 5:
					vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
					WindowTracker.E433C3f6InL92Qbw5WE();
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 6:
					WindowTracker.VCNdgmfYHwllT8U7kot();
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 7:
					WindowTracker.titleBarSize = 0;
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				WindowTracker.borderSize = 0;
				num2 = 7;
			}
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x0003BF3C File Offset: 0x0003A13C
		internal static void E433C3f6InL92Qbw5WE()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x0003BF44 File Offset: 0x0003A144
		internal static bool U9iJDMf74DkfaXxD8IO()
		{
			return WindowTracker.IwEXLbfrmYlWQ6bBaFy == null;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0003BF50 File Offset: 0x0003A150
		internal static WindowTracker ULUD9kf220h7nRsOBmI()
		{
			return WindowTracker.IwEXLbfrmYlWQ6bBaFy;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x0003BF58 File Offset: 0x0003A158
		internal static void FfacjtfNtZrBDUrKpqN()
		{
			WindowTracker.GetForegroundProcessName();
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x0003BF60 File Offset: 0x0003A160
		internal static object PYXOjFfnligvDunp2JK()
		{
			return Process.GetProcesses();
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0003BF68 File Offset: 0x0003A168
		internal static int YwDXGif0vlBiWMN9cq7(object A_0)
		{
			return A_0.Id;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0003BF74 File Offset: 0x0003A174
		internal static object HJP6FkfJDqKS0vr8TpI(object A_0)
		{
			return A_0.ProcessName;
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0003BF80 File Offset: 0x0003A180
		internal static object K8oypifmJg2VCiFRvPV(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0003BF8C File Offset: 0x0003A18C
		internal static bool VALYusfHS0KVb3NIvfq(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0003BF9C File Offset: 0x0003A19C
		internal static void empJCmftKHDqkD4U46p(object A_0, object A_1)
		{
			Console.WriteLine(A_0, A_1);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0003BFAC File Offset: 0x0003A1AC
		internal static void VCNdgmfYHwllT8U7kot()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x04000353 RID: 851
		public static string CurrentProcessName;

		// Token: 0x04000354 RID: 852
		public static bool GameFocused;

		// Token: 0x04000355 RID: 853
		public static IntPtr GameHWND;

		// Token: 0x04000356 RID: 854
		public static int borderSize;

		// Token: 0x04000357 RID: 855
		public static int titleBarSize;

		// Token: 0x04000358 RID: 856
		public static WindowTracker.RECT GameRect;

		// Token: 0x04000359 RID: 857
		private const uint EVENT_SYSTEM_FOREGROUND = 3U;

		// Token: 0x0400035A RID: 858
		private const uint WINEVENT_OUTOFCONTEXT = 0U;

		// Token: 0x0400035B RID: 859
		private static WindowTracker.qKk3X55ErqkNnxUyZpx procDelegate;

		// Token: 0x0400035C RID: 860
		internal static WindowTracker IwEXLbfrmYlWQ6bBaFy;

		// Token: 0x0200004F RID: 79
		private sealed class qKk3X55ErqkNnxUyZpx : MulticastDelegate
		{
			// Token: 0x060007BA RID: 1978
			public extern qKk3X55ErqkNnxUyZpx(object \u0020, IntPtr \u0020);

			// Token: 0x060007BB RID: 1979
			public extern void Invoke(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

			// Token: 0x060007BC RID: 1980
			public extern IAsyncResult BeginInvoke(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime, AsyncCallback callback, object @object);

			// Token: 0x060007BD RID: 1981
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x060007BE RID: 1982 RVA: 0x00042430 File Offset: 0x00040630
			static qKk3X55ErqkNnxUyZpx()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}
		}

		// Token: 0x02000050 RID: 80
		public struct RECT
		{
			// Token: 0x060007BF RID: 1983 RVA: 0x00042440 File Offset: 0x00040640
			public Rectangle ToRectangle()
			{
				return WindowTracker.RECT.MFAixXLRadBdmwtZxWn(this.Left, this.Top, this.Right, this.Bottom);
			}

			// Token: 0x060007C0 RID: 1984 RVA: 0x00042468 File Offset: 0x00040668
			public Rectangle ToRectangleOffset(WindowTracker.POINT p)
			{
				return Rectangle.FromLTRB(p.x, p.y, this.Right + p.x, this.Bottom + p.y);
			}

			// Token: 0x060007C1 RID: 1985 RVA: 0x0004249C File Offset: 0x0004069C
			// Note: this type is marked as 'beforefieldinit'.
			static RECT()
			{
				WindowTracker.RECT.zMKDRqLLkABqr8eh2Ig();
			}

			// Token: 0x060007C2 RID: 1986 RVA: 0x000424AC File Offset: 0x000406AC
			internal static Rectangle MFAixXLRadBdmwtZxWn(int A_0, int A_1, int A_2, int A_3)
			{
				return Rectangle.FromLTRB(A_0, A_1, A_2, A_3);
			}

			// Token: 0x060007C3 RID: 1987 RVA: 0x000424CC File Offset: 0x000406CC
			internal static bool g1VIb7LFfDfFWE5fbSF()
			{
				return WindowTracker.RECT.ltAqUrLfw5lPugtH8Gn == null;
			}

			// Token: 0x060007C4 RID: 1988 RVA: 0x000424E0 File Offset: 0x000406E0
			internal static object o3Z7KsLTSu8Sdreo72B()
			{
				return WindowTracker.RECT.ltAqUrLfw5lPugtH8Gn;
			}

			// Token: 0x060007C5 RID: 1989 RVA: 0x000424F0 File Offset: 0x000406F0
			internal static void zMKDRqLLkABqr8eh2Ig()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x0400035D RID: 861
			public int Left;

			// Token: 0x0400035E RID: 862
			public int Top;

			// Token: 0x0400035F RID: 863
			public int Right;

			// Token: 0x04000360 RID: 864
			public int Bottom;

			// Token: 0x04000361 RID: 865
			internal static object ltAqUrLfw5lPugtH8Gn;
		}

		// Token: 0x02000051 RID: 81
		public struct POINT
		{
			// Token: 0x04000362 RID: 866
			public int x;

			// Token: 0x04000363 RID: 867
			public int y;
		}
	}
}
