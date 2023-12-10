using System;
using System.Threading;
using MyU9Ep58ZH3s5ThDFJQ;
using XR7RtrxI8Vm7Dgx9BKr;

namespace Interceptor
{
	// Token: 0x02000002 RID: 2
	public class Input
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002074 File Offset: 0x00000274
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		public KeyboardFilterMode KeyboardFilterMode { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000029C
		// (set) Token: 0x06000006 RID: 6 RVA: 0x000020AC File Offset: 0x000002AC
		public MouseFilterMode MouseFilterMode { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020C4 File Offset: 0x000002C4
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000020D4 File Offset: 0x000002D4
		public bool IsLoaded { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020F0 File Offset: 0x000002F0
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002100 File Offset: 0x00000300
		public int KeyPressDelay { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000212C File Offset: 0x0000032C
		public int ClickDelay { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002144 File Offset: 0x00000344
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002154 File Offset: 0x00000354
		public int ScrollDelay { get; set; }

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000F RID: 15 RVA: 0x0000216C File Offset: 0x0000036C
		// (remove) Token: 0x06000010 RID: 16 RVA: 0x000021AC File Offset: 0x000003AC
		public event EventHandler<KeyPressedEventArgs> OnKeyPressed;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000011 RID: 17 RVA: 0x000021EC File Offset: 0x000003EC
		// (remove) Token: 0x06000012 RID: 18 RVA: 0x0000222C File Offset: 0x0000042C
		public event EventHandler<MousePressedEventArgs> OnMousePressed;

		// Token: 0x06000013 RID: 19 RVA: 0x0000226C File Offset: 0x0000046C
		public Input()
		{
			Input.lvYnP7onTs0YS6hOEDq();
			Input.JNwQnso0gS5LoH1lmMp();
			base..ctor();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
			{
				num = 1;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					this.context = IntPtr.Zero;
					num = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 == 0)
					{
						num = 3;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					this.KeyboardFilterMode = KeyboardFilterMode.None;
					num = 6;
					continue;
				case 4:
				{
					this.KeyPressDelay = 0;
					int num2 = 5;
					num = num2;
					continue;
				}
				case 5:
					this.ClickDelay = 1;
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 6:
					this.MouseFilterMode = MouseFilterMode.None;
					num = 4;
					continue;
				}
				this.ScrollDelay = 15;
				num = 2;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002374 File Offset: 0x00000574
		public bool Load()
		{
			int num = 4;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						Input.MA1LnfoH8532PfqMq86(this.callbackThread);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						this.callbackThread.Priority = ThreadPriority.Highest;
						num2 = 8;
						continue;
					case 3:
						return false;
					case 4:
						if (this.IsLoaded)
						{
							num2 = 3;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						else
						{
							this.context = InterceptionDriver.CreateContext();
							if (Input.bTkwIYoJ4e3TAoS1h9H(this.context, IntPtr.Zero))
							{
								num2 = 7;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							else
							{
								this.IsLoaded = false;
								num2 = 6;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
						}
						break;
					case 5:
						return true;
					case 6:
						return false;
					case 7:
						goto IL_109;
					case 8:
						Input.r9rlObomQpY4gOn8ZfW(this.callbackThread, true);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					this.IsLoaded = true;
					num2 = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
					{
						num2 = 0;
					}
				}
				IL_109:
				this.callbackThread = new Thread(new ThreadStart(this.dsD3gvE8a));
				num = 2;
			}
			return false;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000024FC File Offset: 0x000006FC
		public void Unload()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (!this.IsLoaded)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_3B;
				case 3:
					InterceptionDriver.DestroyContext(this.context);
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					Input.QyyoeuoteLhQxRKKm2o(this.callbackThread);
					num2 = 3;
					continue;
				case 5:
					return;
				}
				if (!(this.context != IntPtr.Zero))
				{
					return;
				}
				num2 = 4;
			}
			IL_3B:
			this.IsLoaded = false;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025F0 File Offset: 0x000007F0
		private void dsD3gvE8a()
		{
			int num = 10;
			for (;;)
			{
				int num2 = num;
				Stroke stroke;
				KeyPressedEventArgs keyPressedEventArgs;
				for (;;)
				{
					MousePressedEventArgs mousePressedEventArgs;
					switch (num2)
					{
					case 0:
						goto IL_28D;
					case 1:
						if (Input.D1MfUqogpeSZ35gEogi(mousePressedEventArgs))
						{
							num2 = 12;
							continue;
						}
						stroke.Mouse.X = Input.VWnuPsoXUHtsqWnnMmB(mousePressedEventArgs);
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 2:
						goto IL_2EA;
					case 3:
						this.Unload();
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						goto IL_131;
					case 5:
						stroke.Mouse.Rolling = Input.qyyBqMoMlSODOdc78PD(mousePressedEventArgs);
						num2 = 15;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 6:
						if (!Input.L6K22foBdeRb8QODMKG(keyPressedEventArgs))
						{
							goto Block_15;
						}
						goto IL_131;
					case 7:
						goto IL_19A;
					case 8:
						stroke.Mouse.Y = mousePressedEventArgs.Y;
						num2 = 21;
						continue;
					case 9:
						InterceptionDriver.SetFilter(this.context, new Predicate(InterceptionDriver.IsMouse), (int)this.MouseFilterMode);
						num2 = 17;
						continue;
					case 10:
						InterceptionDriver.SetFilter(this.context, new Predicate(InterceptionDriver.IsKeyboard), (int)this.KeyboardFilterMode);
						num2 = 9;
						continue;
					case 11:
						this.OnMousePressed(this, mousePressedEventArgs);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 12:
						goto IL_131;
					case 13:
						goto IL_3D6;
					case 14:
						stroke.Key.State = Input.PjJDMFovIjZm8tSoOs8(keyPressedEventArgs);
						break;
					case 15:
						goto IL_3D6;
					case 16:
						goto IL_214;
					case 17:
						stroke = default(Stroke);
						num2 = 23;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 == 0)
						{
							num2 = 12;
							continue;
						}
						continue;
					case 18:
						goto IL_175;
					case 19:
						if (this.OnKeyPressed != null)
						{
							num2 = 22;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
							{
								num2 = 16;
								continue;
							}
							continue;
						}
						break;
					case 20:
						this.OnKeyPressed(this, keyPressedEventArgs);
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 21:
						stroke.Mouse.State = mousePressedEventArgs.State;
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 22:
					{
						KeyPressedEventArgs keyPressedEventArgs2 = new KeyPressedEventArgs();
						Input.YIaGxHoGdgVhnlYtFRA(keyPressedEventArgs2, stroke.Key.Code);
						keyPressedEventArgs2.State = stroke.Key.State;
						keyPressedEventArgs = keyPressedEventArgs2;
						num2 = 20;
						continue;
					}
					case 23:
						goto IL_131;
					default:
						goto IL_28D;
					}
					IL_D5:
					InterceptionDriver.Send(this.context, this.deviceId, ref stroke, 1U);
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_3D6:
					if (InterceptionDriver.IsKeyboard(this.deviceId) <= 0)
					{
						goto IL_D5;
					}
					num2 = 19;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
					{
						num2 = 19;
						continue;
					}
					continue;
					IL_28D:
					goto IL_3D6;
					IL_131:
					if (InterceptionDriver.Receive(this.context, this.deviceId = InterceptionDriver.Wait(this.context), ref stroke, 1U) > 0)
					{
						goto IL_214;
					}
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_175:
					if (this.OnMousePressed != null)
					{
						goto IL_2EA;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_214:
					if (InterceptionDriver.IsMouse(this.deviceId) > 0)
					{
						goto IL_175;
					}
					num2 = 7;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 == 0)
					{
						num2 = 13;
						continue;
					}
					continue;
					IL_2EA:
					MousePressedEventArgs mousePressedEventArgs2 = new MousePressedEventArgs();
					Input.bkK2A6oYg7DymUjnC17(mousePressedEventArgs2, stroke.Mouse.X);
					mousePressedEventArgs2.Y = stroke.Mouse.Y;
					mousePressedEventArgs2.State = stroke.Mouse.State;
					Input.qg6yDXosSpK3XGugPsX(mousePressedEventArgs2, stroke.Mouse.Rolling);
					mousePressedEventArgs = mousePressedEventArgs2;
					num2 = 11;
				}
				Block_15:
				stroke.Key.Code = Input.E3OI6woDdcmGcSpdX7r(keyPressedEventArgs);
				num = 14;
			}
			IL_19A:
			throw new Exception(Input.sFnlpEojPWZISHjMmwm(764415235 ^ 764415235));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002A54 File Offset: 0x00000C54
		public void SendKey(ushort key, KeyState state)
		{
			int num = 5;
			for (;;)
			{
				int num2 = num;
				KeyStroke key2;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (this.KeyPressDelay <= 0)
						{
							return;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_912464c7521643f2968751cbbc64f3cf != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_102;
					case 3:
						return;
					case 4:
						key2 = default(KeyStroke);
						num2 = 2;
						continue;
					case 5:
					{
						Stroke stroke = default(Stroke);
						num2 = 4;
						continue;
					}
					case 6:
						key2.State = state;
						num2 = 7;
						continue;
					case 7:
					{
						Stroke stroke;
						stroke.Key = key2;
						InterceptionDriver.Send(this.context, this.deviceId, ref stroke, 1U);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					}
					Input.KeZXbGob2xtSRaMv152(this.KeyPressDelay);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num2 = 3;
					}
				}
				IL_102:
				key2.Code = key;
				num = 6;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002B78 File Offset: 0x00000D78
		public void SendKey(ushort key)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.SendKey(key, KeyState.Down);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					Input.KeZXbGob2xtSRaMv152(this.KeyPressDelay);
					num2 = 3;
					continue;
				case 3:
					goto IL_91;
				}
				if (this.KeyPressDelay <= 0)
				{
					break;
				}
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b != 0)
				{
					num2 = 1;
				}
			}
			IL_91:
			this.SendKey(key, KeyState.Up);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002C24 File Offset: 0x00000E24
		public void SendKeys(params ushort[] keys)
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				int num3;
				for (;;)
				{
					ushort key;
					switch (num2)
					{
					case 2:
						num3 = 0;
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						this.SendKey(key);
						num3++;
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						goto IL_D2;
					case 6:
						return;
					case 7:
						goto IL_D2;
					}
					break;
					IL_D2:
					key = keys[num3];
					num2 = 4;
				}
				IL_71:
				if (num3 < keys.Length)
				{
					num = 5;
					continue;
				}
				break;
				IL_62:
				goto IL_71;
				goto IL_62;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002D34 File Offset: 0x00000F34
		// Note: this type is marked as 'beforefieldinit'.
		static Input()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002D44 File Offset: 0x00000F44
		internal static bool KcMk37o6TN4C8PLGrHb()
		{
			return Input.MDIja7o2fxYdovsR7es == null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002D58 File Offset: 0x00000F58
		internal static Input m1sZMtoNfe0nd8Ut8Kw()
		{
			return Input.MDIja7o2fxYdovsR7es;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002D68 File Offset: 0x00000F68
		internal static void lvYnP7onTs0YS6hOEDq()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002D78 File Offset: 0x00000F78
		internal static void JNwQnso0gS5LoH1lmMp()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002D88 File Offset: 0x00000F88
		internal static bool bTkwIYoJ4e3TAoS1h9H(IntPtr A_0, IntPtr A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002DA0 File Offset: 0x00000FA0
		internal static void r9rlObomQpY4gOn8ZfW(object A_0, bool A_1)
		{
			A_0.IsBackground = A_1;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002DB8 File Offset: 0x00000FB8
		internal static void MA1LnfoH8532PfqMq86(object A_0)
		{
			A_0.Start();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002DCC File Offset: 0x00000FCC
		internal static void QyyoeuoteLhQxRKKm2o(object A_0)
		{
			A_0.Abort();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002DE0 File Offset: 0x00000FE0
		internal static void bkK2A6oYg7DymUjnC17(object A_0, int value)
		{
			A_0.X = value;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002DF8 File Offset: 0x00000FF8
		internal static void qg6yDXosSpK3XGugPsX(object A_0, short value)
		{
			A_0.Rolling = value;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002E10 File Offset: 0x00001010
		internal static bool D1MfUqogpeSZ35gEogi(object A_0)
		{
			return A_0.Handled;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002E24 File Offset: 0x00001024
		internal static int VWnuPsoXUHtsqWnnMmB(object A_0)
		{
			return A_0.X;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002E38 File Offset: 0x00001038
		internal static short qyyBqMoMlSODOdc78PD(object A_0)
		{
			return A_0.Rolling;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E4C File Offset: 0x0000104C
		internal static void YIaGxHoGdgVhnlYtFRA(object A_0, ushort value)
		{
			A_0.Key = value;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002E64 File Offset: 0x00001064
		internal static bool L6K22foBdeRb8QODMKG(object A_0)
		{
			return A_0.Handled;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002E78 File Offset: 0x00001078
		internal static ushort E3OI6woDdcmGcSpdX7r(object A_0)
		{
			return A_0.Key;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002E8C File Offset: 0x0000108C
		internal static KeyState PjJDMFovIjZm8tSoOs8(object A_0)
		{
			return A_0.State;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002EA0 File Offset: 0x000010A0
		internal static object sFnlpEojPWZISHjMmwm(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002EB4 File Offset: 0x000010B4
		internal static void KeZXbGob2xtSRaMv152(int A_0)
		{
			Thread.Sleep(A_0);
		}

		// Token: 0x04000001 RID: 1
		private IntPtr context;

		// Token: 0x04000002 RID: 2
		private Thread callbackThread;

		// Token: 0x0400000B RID: 11
		private int deviceId;

		// Token: 0x0400000C RID: 12
		internal static Input MDIja7o2fxYdovsR7es;
	}
}
