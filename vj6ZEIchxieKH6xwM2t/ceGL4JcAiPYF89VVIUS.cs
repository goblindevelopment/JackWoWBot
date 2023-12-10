using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Interceptor;
using MyU9Ep58ZH3s5ThDFJQ;
using RotationLabEngine;
using WindowsInput;
using WindowsInput.Native;
using XR7RtrxI8Vm7Dgx9BKr;

namespace vj6ZEIchxieKH6xwM2t
{
	// Token: 0x02000030 RID: 48
	internal class ceGL4JcAiPYF89VVIUS
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x0002A5CC File Offset: 0x000287CC
		public ceGL4JcAiPYF89VVIUS()
		{
			ceGL4JcAiPYF89VVIUS.ze7vE1prqeOLkvimMQU();
			ceGL4JcAiPYF89VVIUS.ARfu9Zp7jgWJW1bC9Yk();
			this.mode = 1;
			this.input = new Input();
			this.r = new Random();
			this.WinInput = new InputSimulator();
			base..ctor();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0002A668 File Offset: 0x00028868
		public void xrtcSrwrsS(string \u0020)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					if (this.mode == 1)
					{
						this.up0cZZyemj(\u0020);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						this.KUEcUvZU0x(\u0020);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				case 3:
					if (ceGL4JcAiPYF89VVIUS.iOr4AAp2bRUNduwO0Jc(\u0020, ""))
					{
						num2 = 2;
						continue;
					}
					return;
				}
				break;
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0002A718 File Offset: 0x00028918
		[CompilerGenerated]
		public void ipnc1Fu5ur(EventHandler<LogEventArgs> \u0020)
		{
			EventHandler<LogEventArgs> eventHandler = this.NewLogEvent;
			EventHandler<LogEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<LogEventArgs> value = (EventHandler<LogEventArgs>)Delegate.Combine(eventHandler2, \u0020);
				eventHandler = Interlocked.CompareExchange<EventHandler<LogEventArgs>>(ref this.NewLogEvent, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0002A758 File Offset: 0x00028958
		[CompilerGenerated]
		public void uLmcpkRn0e(EventHandler<LogEventArgs> \u0020)
		{
			EventHandler<LogEventArgs> eventHandler = this.NewLogEvent;
			EventHandler<LogEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<LogEventArgs> value = (EventHandler<LogEventArgs>)Delegate.Remove(eventHandler2, \u0020);
				eventHandler = Interlocked.CompareExchange<EventHandler<LogEventArgs>>(ref this.NewLogEvent, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0002A798 File Offset: 0x00028998
		public void nrXcI6NjuZ(string \u0020)
		{
			this.NewLogEvent(this, new LogEventArgs(\u0020));
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0002A7C0 File Offset: 0x000289C0
		public bool UTvciVxMpW(int \u0020)
		{
			bool result;
			try
			{
				int num;
				if (\u0020 != 0)
				{
					num = 3;
				}
				else
				{
					if (!ceGL4JcAiPYF89VVIUS.ukMe1Gp611W3r6aDSKl(this.input))
					{
						goto IL_FF;
					}
					num = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
					{
						num = 2;
					}
				}
				for (;;)
				{
					IL_24:
					switch (num)
					{
					case 1:
						goto IL_8D;
					case 2:
						\u0020 = 0;
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a != 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_52;
					case 4:
						goto IL_52;
					case 5:
						result = ceGL4JcAiPYF89VVIUS.DZ47XypnwCpGSpcYB5D(this.input);
						num = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
						{
							num = 1;
							continue;
						}
						continue;
					case 6:
						result = true;
						num = 8;
						continue;
					case 7:
						goto IL_FF;
					case 8:
						goto IL_158;
					}
					break;
					IL_52:
					this.mode = 1;
					num = 6;
				}
				goto IL_150;
				IL_8D:
				return result;
				IL_150:
				result = true;
				IL_158:
				return result;
				IL_FF:
				ceGL4JcAiPYF89VVIUS.tP7pJspN7FpmYBaPhmK(this.input, KeyboardFilterMode.All);
				num = 5;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
				{
					num = 2;
					goto IL_24;
				}
				goto IL_24;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
				{
					num2 = 0;
				}
				for (;;)
				{
					switch (num2)
					{
					default:
						this.nrXcI6NjuZ(ceGL4JcAiPYF89VVIUS.V83PVOp0KGtra8PRj84(ex));
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 != 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						goto IL_1B6;
					}
				}
				IL_1B6:
				result = false;
			}
			return result;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0002A9B0 File Offset: 0x00028BB0
		private void up0cZZyemj(string \u0020)
		{
			long num = ceGL4JcAiPYF89VVIUS.rxRovhpJ6vRMOOdSo3X().ToUnixTimeMilliseconds();
			int num2 = 15;
			for (;;)
			{
				int num3;
				string text;
				int num4;
				bool flag2;
				bool flag3;
				string[] array;
				switch (num2)
				{
				case 0:
					goto IL_13F;
				case 1:
					goto IL_82;
				case 2:
					goto IL_97;
				case 3:
					goto IL_315;
				case 4:
					goto IL_97;
				case 5:
					num3 = 0;
					num2 = 6;
					continue;
				case 6:
					goto IL_82;
				case 7:
					return;
				case 8:
					goto IL_D9;
				case 9:
					goto IL_13F;
				case 10:
					return;
				case 11:
					ceGL4JcAiPYF89VVIUS.h00EC2pMO6bWpqaYrDQ(this.WinInput.Keyboard, ceGL4JcAiPYF89VVIUS.VirtualKeys[text]);
					num2 = 3;
					continue;
				case 12:
					if (num - this.previousKeyTime >= 100L)
					{
						goto IL_1EB;
					}
					num4 = 10;
					break;
				case 13:
					if (ceGL4JcAiPYF89VVIUS.VirtualKeys.ContainsKey(text))
					{
						num2 = 24;
						continue;
					}
					goto IL_315;
				case 14:
					goto IL_336;
				case 15:
					if (ceGL4JcAiPYF89VVIUS.mJYDmLpmsTlvErsZ8TC(\u0020, this.previousKey))
					{
						num2 = 12;
						continue;
					}
					goto IL_1EB;
				case 16:
					goto IL_285;
				case 17:
					if (!(text != ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(510582717 ^ 510577329)))
					{
						num2 = 21;
						continue;
					}
					goto IL_336;
				case 18:
				{
					object obj = ceGL4JcAiPYF89VVIUS.LIGapZpHJ7EfdVN5Gts(\u0020, new char[]
					{
						'+'
					});
					bool flag = obj.Contains(ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-161182833 ^ -161177969));
					flag2 = obj.Contains(ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1810931007 ^ 1810925619));
					flag3 = obj.Contains(ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-825446221 ^ -825449051));
					if (flag)
					{
						this.WinInput.Keyboard.KeyDown(162);
						Thread.Sleep(this.r.Next(5, 10));
					}
					if (flag2)
					{
						this.WinInput.Keyboard.KeyDown(164);
						Thread.Sleep(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 5, 10));
					}
					if (flag3)
					{
						ceGL4JcAiPYF89VVIUS.dABPAGpsKgcNGd18HWa(this.WinInput).KeyDown(160);
						ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 5, 10));
					}
					array = obj;
					num2 = 5;
					continue;
				}
				case 19:
					goto IL_14B;
				case 20:
					goto IL_208;
				case 21:
					goto IL_315;
				case 22:
				{
					bool flag;
					if (flag)
					{
						goto IL_285;
					}
					num2 = 19;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 != 0)
					{
						num2 = 11;
						continue;
					}
					continue;
				}
				case 23:
					goto IL_14B;
				case 24:
					ceGL4JcAiPYF89VVIUS.nRrgTFpX9PW6bjtM7Dn(ceGL4JcAiPYF89VVIUS.dABPAGpsKgcNGd18HWa(this.WinInput), ceGL4JcAiPYF89VVIUS.VirtualKeys[text]);
					ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 30, 50));
					num4 = 11;
					break;
				case 25:
					this.previousKeyTime = num;
					num2 = 18;
					continue;
				default:
					goto IL_13F;
				}
				IL_0C:
				num2 = num4;
				continue;
				IL_82:
				if (num3 < array.Length)
				{
					num2 = 4;
					continue;
				}
				goto IL_208;
				IL_D9:
				ceGL4JcAiPYF89VVIUS.dABPAGpsKgcNGd18HWa(this.WinInput).KeyUp(164);
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_14B:
				if (!flag2)
				{
					num2 = 9;
					continue;
				}
				goto IL_D9;
				IL_13F:
				if (flag3)
				{
					ceGL4JcAiPYF89VVIUS.dABPAGpsKgcNGd18HWa(this.WinInput).KeyUp(160);
					num2 = 7;
					continue;
				}
				return;
				IL_97:
				text = array[num3];
				if (!(text != ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1399929319 << 3 ^ 1685464520)))
				{
					goto IL_315;
				}
				num2 = 17;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_1EB:
				this.previousKey = \u0020;
				num2 = 25;
				continue;
				IL_208:
				ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(this.r.Next(10, 20));
				num2 = 18;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
				{
					num2 = 22;
					continue;
				}
				continue;
				IL_285:
				ceGL4JcAiPYF89VVIUS.dABPAGpsKgcNGd18HWa(this.WinInput).KeyUp(162);
				num2 = 12;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
				{
					num2 = 23;
					continue;
				}
				continue;
				IL_315:
				num3++;
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_336:
				if (text != vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~463906284 ^ -463909115))
				{
					num4 = 13;
					goto IL_0C;
				}
				goto IL_315;
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0002AE74 File Offset: 0x00029074
		private void KUEcUvZU0x(string \u0020)
		{
			int num = 24;
			for (;;)
			{
				int num2 = num;
				int num4;
				for (;;)
				{
					string text;
					long num3;
					bool flag2;
					bool flag3;
					string[] array2;
					switch (num2)
					{
					case 0:
						goto IL_28B;
					case 1:
						goto IL_1B2;
					case 2:
						goto IL_173;
					case 3:
						ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(this.r.Next(20, 40));
						num2 = 27;
						continue;
					case 4:
						ceGL4JcAiPYF89VVIUS.z0bWTOpGSPqcpjEuKtP(this.input, ceGL4JcAiPYF89VVIUS.USCodes[text], KeyState.Up);
						goto IL_173;
					case 5:
						goto IL_24F;
					case 6:
						return;
					case 7:
						Thread.Sleep(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 5, 10));
						num2 = 9;
						continue;
					case 8:
						ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 60, 80));
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 9:
						goto IL_26A;
					case 10:
					{
						this.previousKeyTime = num3;
						string[] array = \u0020.Split(new char[]
						{
							'+'
						});
						bool flag = array.Contains(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(451337338 ^ 451332474));
						flag2 = array.Contains(ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(--1797548854 ^ 1797553722));
						flag3 = array.Contains(ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1690522925 ^ -1690517563));
						if (flag)
						{
							this.input.SendKey(ceGL4JcAiPYF89VVIUS.USCodes[ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1505789866 ^ -1505792682)], KeyState.Down);
							ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 10, 20));
						}
						if (flag2)
						{
							ceGL4JcAiPYF89VVIUS.z0bWTOpGSPqcpjEuKtP(this.input, ceGL4JcAiPYF89VVIUS.USCodes[ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1308721404 ^ 1308726768)], KeyState.Down);
							ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(this.r.Next(10, 20));
						}
						if (flag3)
						{
							this.input.SendKey(ceGL4JcAiPYF89VVIUS.USCodes[ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(185404423 + 1853889833 ^ 2039299110)], KeyState.Down);
							ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 10, 20));
						}
						array2 = array;
						num2 = 22;
						continue;
					}
					case 11:
						return;
					case 12:
						goto IL_21F;
					case 13:
						ceGL4JcAiPYF89VVIUS.z0bWTOpGSPqcpjEuKtP(this.input, ceGL4JcAiPYF89VVIUS.USCodes[ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-553744847 ^ -553741507)], KeyState.Up);
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
						{
							num2 = 30;
							continue;
						}
						continue;
					case 14:
						ceGL4JcAiPYF89VVIUS.z0bWTOpGSPqcpjEuKtP(this.input, ceGL4JcAiPYF89VVIUS.USCodes[text], KeyState.Down);
						num2 = 8;
						continue;
					case 15:
						if (!(\u0020 == this.previousKey))
						{
							num2 = 25;
							continue;
						}
						goto IL_24F;
					case 16:
						goto IL_295;
					case 17:
						goto IL_3FF;
					case 18:
						if (!ceGL4JcAiPYF89VVIUS.iOr4AAp2bRUNduwO0Jc(text, ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1183576799 ^ -1183573983)))
						{
							num2 = 2;
							continue;
						}
						break;
					case 19:
						Thread.Sleep(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 5, 10));
						num2 = 11;
						continue;
					case 20:
						goto IL_1B2;
					case 21:
						goto IL_173;
					case 22:
						goto IL_471;
					case 23:
					{
						DateTimeOffset now;
						num3 = now.ToUnixTimeMilliseconds();
						num2 = 15;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					case 24:
					{
						DateTimeOffset now = DateTimeOffset.Now;
						num2 = 23;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 != 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					}
					case 25:
						goto IL_3FF;
					case 26:
						goto IL_2FF;
					case 27:
					{
						bool flag;
						if (!flag)
						{
							goto IL_26A;
						}
						ceGL4JcAiPYF89VVIUS.z0bWTOpGSPqcpjEuKtP(this.input, ceGL4JcAiPYF89VVIUS.USCodes[ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1386050510 + 11679858 ^ 1397733696)], KeyState.Up);
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					}
					case 28:
						goto IL_3CE;
					case 29:
						return;
					case 30:
						ceGL4JcAiPYF89VVIUS.it10mxpgecgAD1U7GmT(ceGL4JcAiPYF89VVIUS.qaGWocpYi7HMn68dfDY(this.r, 5, 10));
						num2 = 26;
						continue;
					case 31:
						break;
					default:
						goto IL_28B;
					}
					if (!(text != vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-256932895 ^ -256928019)))
					{
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						if (!ceGL4JcAiPYF89VVIUS.iOr4AAp2bRUNduwO0Jc(text, ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(268802365 >> 1 ^ 134404488)))
						{
							num2 = 21;
							continue;
						}
						goto IL_295;
					}
					IL_173:
					num4++;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_295:
					if (ceGL4JcAiPYF89VVIUS.USCodes.ContainsKey(text))
					{
						num2 = 14;
						continue;
					}
					IL_28B:
					goto IL_173;
					IL_1B2:
					if (num4 >= array2.Length)
					{
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					IL_21F:
					text = array2[num4];
					num2 = 18;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
					{
						num2 = 13;
						continue;
					}
					continue;
					IL_24F:
					if (num3 - this.previousKeyTime >= 100L)
					{
						num2 = 17;
						continue;
					}
					return;
					IL_26A:
					if (flag2)
					{
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					IL_2FF:
					if (!flag3)
					{
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					IL_3CE:
					ceGL4JcAiPYF89VVIUS.z0bWTOpGSPqcpjEuKtP(this.input, ceGL4JcAiPYF89VVIUS.USCodes[ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1505789866 ^ -1505792704)], KeyState.Up);
					num2 = 19;
					continue;
					IL_3FF:
					this.previousKey = \u0020;
					num2 = 10;
				}
				IL_471:
				num4 = 0;
				num = 20;
			}
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0002B490 File Offset: 0x00029690
		// Note: this type is marked as 'beforefieldinit'.
		static ceGL4JcAiPYF89VVIUS()
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
					ceGL4JcAiPYF89VVIUS.ARfu9Zp7jgWJW1bC9Yk();
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					ceGL4JcAiPYF89VVIUS.DgsWkQpBWCKMJy8bBSC();
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					ceGL4JcAiPYF89VVIUS.VirtualKeys = new Dictionary<string, VirtualKeyCode>
					{
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(881693030 + 414722879 ^ 1296400645),
							27
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-506871478 - 1486829658 ^ -1993695602),
							49
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(510582717 ^ 510583305),
							50
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1386050510 + 11679858 ^ 1397723642),
							51
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1003780849 ^ -1003767601),
							52
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1374435438 ^ -1374422444),
							53
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(~-1605313923 ^ 1605310542),
							54
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(--1016420359 ^ 1016423893),
							55
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(171996523 ^ 171985075),
							56
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1872685799 ^ -1872680761),
							57
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1992869118 ^ -1992869392),
							48
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-161182833 ^ -161171861),
							189
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1638637009 >> 6 ^ 25596815),
							187
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-289990612 ^ 1144181582 ^ -1434061454),
							8
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-831735385 ^ -831733985),
							9
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(--1797548854 ^ 1797543178),
							81
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1691472209 >> 1 ^ 845731562),
							87
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1050340572 ^ -1050333844),
							69
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1905767247 ^ 1905757441),
							82
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-309791748 - 2077333185 ^ 1907843951),
							84
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1872685799 ^ -1872680125),
							89
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1746511494 ^ -1746508006),
							85
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-831735385 ^ -831748159),
							73
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1048347516 ^ 1048362256),
							79
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886909872),
							80
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1654110737 ^ -473083753 ^ -2124753666),
							219
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(587114080 ^ 587110592),
							221
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(~1005505369 ^ -1005516278),
							13
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-693910567 ^ -693905703),
							162
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1520361985 >> 6 ^ -23741789),
							65
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2066732216 ^ 2066737762),
							83
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-260489887 - 366953631 ^ -627456478),
							68
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(950853533 >> 3 ^ 118859029),
							70
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352740968 ^ -1352732300),
							71
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-553744847 ^ -553731901),
							72
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1745773992 ^ -1745771360),
							74
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(951294359 ^ 47512224 ^ 979852745),
							75
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-87166655 + -2142521002 ^ 2065274259),
							76
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-2083830725 ^ -2083816655),
							186
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-506871478 - 1486829658 ^ -1993689108),
							222
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(212924216 ^ 212912150),
							192
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-309791748 - 2077333185 ^ 1907836973),
							160
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1002815721 ^ -877302260 ^ 261058125),
							220
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1905767247 ^ 1905757223),
							90
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(268206341 ^ 268217669),
							88
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(850579974 + 1765464631 ^ -1678929069),
							67
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-160910942 << 4 ^ 1720395092),
							86
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1881006439 >> 3 ^ 235111254),
							66
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-283366293 ^ -283372565),
							78
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1366152946 ^ -1366157688),
							77
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~603785892 ^ -603796777),
							188
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-384868386 + 510636180 ^ 125775828),
							190
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(978854837 ^ 978852983),
							191
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1858354135 - 1114350030 ^ 744007147),
							161
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1819523060 ^ 1064311800 ^ 1392752896),
							164
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-506871478 - 1486829658 ^ -1993684748),
							32
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-825446221 ^ -825429869),
							20
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(464986539 ^ 465002989),
							112
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--2124070285 ^ 2124086723),
							113
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-693910567 ^ -693927025),
							114
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1810931007 ^ 1810947425),
							115
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(587114080 ^ 587130374),
							116
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1860104403 ^ -1860087997),
							117
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~463906284 ^ -463922587),
							118
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-582433477 + 1816872807 ^ 1234455772),
							119
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1041647104 ^ -1041630586),
							120
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-838478377 ^ -838494887),
							121
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-253515656 ^ -1789645123 ^ 1706542685),
							122
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(828767401 >> 3 ^ 103612215),
							123
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1183576799 ^ -1183560307),
							38
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-253515656 ^ -1789645123 ^ 1706542713),
							40
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(259176490 ^ 259193086),
							39
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(457652205 ^ 457668381),
							37
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1767032709 ^ 1767016077),
							36
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1388170447 ^ -1388154351),
							35
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1750427148 ^ -1750411072),
							46
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1657226489 - -588572257 ^ -2049152492),
							33
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-865714864 ^ -865698758),
							34
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(--1016420359 ^ 1016404361),
							45
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(268802365 >> 1 ^ 134384950),
							42
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(359120413 ^ 359137217),
							144
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1073891089 ^ 1073874193),
							145
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(567103098 ^ 567086162),
							93
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1815843576 ^ -1815859384),
							91
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(--1797548854 ^ 1797531996),
							111
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(268206341 ^ 268223379),
							106
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1041647104 ^ -1041631030),
							103
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(259176490 ^ 259193540),
							104
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1520361985 >> 6 ^ -23738523),
							105
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-443850682 << 3 ^ 744177926),
							100
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(145144672 << 4 ^ -1972636326),
							101
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(268206341 ^ 268223099),
							102
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1505789866 ^ -1505805324),
							97
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1897624240 ^ -1897607530),
							98
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1746511494 ^ -1746527600),
							99
						},
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2040894867 + -686633457 ^ 1354246060),
							96
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(996650866 + -609199087 ^ 387469233),
							110
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1714141621 >> 6 ^ 26798724),
							13
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(268802365 >> 1 ^ 134407918),
							107
						},
						{
							ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1640708702 ^ -1640726218),
							109
						}
					};
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				ceGL4JcAiPYF89VVIUS.USCodes = new Dictionary<string, ushort>
				{
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-443850682 << 3 ^ 744177552),
						1
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039299918),
						2
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-185008287 ^ -185023787),
						3
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1520361985 >> 6 ^ -23742003),
						4
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1668754258 ^ -1668748946),
						5
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1003780849 ^ -1003767607),
						6
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1386050510 + 11679858 ^ 1397723532),
						7
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1657226489 - -588572257 ^ -2049173880),
						8
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1654110737 ^ -473083753 ^ -2124753058),
						9
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1746511494 ^ -1746508636),
						10
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-535478164 ^ -535477602),
						11
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1074597531 ^ 1074606975),
						12
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-886904286 ^ -886908966),
						13
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-535478164 ^ -535462276),
						14
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(268206341 ^ 268208061),
						15
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1858354135 - 1114350030 ^ 744006709),
						16
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1307524010 ^ -1307510252),
						17
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(212924216 ^ 212912496),
						18
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1183576799 ^ -1183566993),
						19
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(152750669 ^ 152761369),
						20
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1374435438 ^ -1374422584),
						21
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(828767401 >> 3 ^ 103580149),
						22
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~-531755127 ^ 531746320),
						23
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-87166655 + -2142521002 ^ 2065274107),
						24
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(587114080 ^ 587110418),
						25
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-256932895 ^ -256918119),
						26
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(567103098 ^ 567111898),
						27
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1872685799 ^ -1872680011),
						28
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352111144 ^ -1352106280),
						29
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(2040894867 + -686633457 ^ 1354259830),
						30
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-860087180 << 5 ^ -1752977318),
						31
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-258475567 << 4 ^ 159359984),
						32
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-309791748 - 2077333185 ^ 1907844061),
						33
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(951294359 ^ 47512224 ^ 979852763),
						34
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1638637009 >> 6 ^ 25596037),
						35
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(579026892 ^ 579010868),
						36
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(145144672 << 4 ^ -1972664066),
						37
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--2124070285 ^ 2124055177),
						38
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886909656),
						39
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-717857995 >> 5 ^ -22442555),
						40
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1734223699 - -1503209248 ^ -231030557),
						41
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1657226489 - -588572257 ^ -2049163700),
						42
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-161182833 ^ -161172263),
						43
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1858354135 - 1114350030 ^ 744007009),
						44
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-384868386 + 510636180 ^ 125778994),
						45
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1858354135 - 1114350030 ^ 744007015),
						46
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(185404423 + 1853889833 ^ 2039289412),
						47
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1055311542 ^ 1055324620),
						48
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(~744818537 ^ -744831210),
						49
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1495818301 ^ -1495818171),
						50
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1640708702 ^ -1640695250),
						51
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1633072087 ^ 1633062001),
						52
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1050340572 ^ -1050333978),
						53
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1388170447 ^ -1388180269),
						54
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1691472209 >> 1 ^ 845741476),
						56
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(145144672 << 4 ^ -1972636156),
						57
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1551733089 >> 2 ^ 387916920),
						58
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(457652205 ^ 457668523),
						59
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(950853533 >> 3 ^ 118873021),
						60
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039310694),
						61
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(835315079 ^ 835298777),
						62
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1089588375 ^ -1089572081),
						63
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(950853533 >> 3 ^ 118872989),
						64
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1055311542 ^ 1055295168),
						65
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-33448599 >> 2 ^ -8378588),
						66
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1308721404 ^ 1308737658),
						67
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-384868386 + 510636180 ^ 125784316),
						68
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1897624240 ^ -1897607736),
						87
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1654110737 ^ -473083753 ^ -2124764636),
						88
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-613886095 << 1 ^ -1227755954),
						72
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(~-531755127 ^ 531738826),
						80
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-831735385 ^ -831719053),
						77
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-256932895 ^ -256916719),
						75
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-506871478 - 1486829658 ^ -1993684488),
						71
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-289990612 ^ 1144181582 ^ -1434088894),
						79
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(326177456 ^ 326194052),
						83
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(850579974 + 1765464631 ^ -1678905997),
						73
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-582433477 + 1816872807 ^ 1234456008),
						81
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1352111144 ^ -1352127914),
						82
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-613886095 << 1 ^ -1227755702),
						55
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(--2124070285 ^ 2124086353),
						69
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(850579974 + 1765464631 ^ -1678905795),
						70
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(881693030 + 414722879 ^ 1296432781),
						93
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1633072087 ^ 1633087895),
						91
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1053049764 ^ -1053032911),
						53
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1860104403 ^ -1860088389),
						55
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(212924216 ^ 212907506),
						71
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(212924216 ^ 212907478),
						72
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-1745773992 ^ -1745757878),
						73
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1074597531 ^ 1074613677),
						75
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2083830725 ^ -2083846303),
						76
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(581513541 ^ 581530171),
						77
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1307524010 ^ -1307539468),
						79
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1765342390 ^ 1765326704),
						80
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(2066732216 ^ 2066716498),
						81
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-161182833 ^ -161165439),
						82
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352111144 ^ -1352126486),
						83
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(1858354135 - 1114350030 ^ 744021611),
						28
					},
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1224731037 ^ -1224721389),
						78
					},
					{
						ceGL4JcAiPYF89VVIUS.Pu9g35pt9oJoGwg5hTc(-235868112 ^ -235883356),
						74
					}
				};
				num2 = 4;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0002CA34 File Offset: 0x0002AC34
		internal static void ze7vE1prqeOLkvimMQU()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0002CA44 File Offset: 0x0002AC44
		internal static void ARfu9Zp7jgWJW1bC9Yk()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x0002CA54 File Offset: 0x0002AC54
		internal static bool NtUZAEpeI1ZPPt449TV()
		{
			return ceGL4JcAiPYF89VVIUS.eRQ4BKpKLEFv8tAHshx == null;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x0002CA68 File Offset: 0x0002AC68
		internal static ceGL4JcAiPYF89VVIUS EZE5mcpkE6Mdo7RZNCo()
		{
			return ceGL4JcAiPYF89VVIUS.eRQ4BKpKLEFv8tAHshx;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x0002CA78 File Offset: 0x0002AC78
		internal static bool iOr4AAp2bRUNduwO0Jc(object A_0, object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0002CA90 File Offset: 0x0002AC90
		internal static bool ukMe1Gp611W3r6aDSKl(object A_0)
		{
			return A_0.IsLoaded;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0002CAA4 File Offset: 0x0002ACA4
		internal static void tP7pJspN7FpmYBaPhmK(object A_0, KeyboardFilterMode value)
		{
			A_0.KeyboardFilterMode = value;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0002CABC File Offset: 0x0002ACBC
		internal static bool DZ47XypnwCpGSpcYB5D(object A_0)
		{
			return A_0.Load();
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		internal static object V83PVOp0KGtra8PRj84(object A_0)
		{
			return A_0.Message;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0002CAE4 File Offset: 0x0002ACE4
		internal static DateTimeOffset rxRovhpJ6vRMOOdSo3X()
		{
			return DateTimeOffset.Now;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0002CAF4 File Offset: 0x0002ACF4
		internal static bool mJYDmLpmsTlvErsZ8TC(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0002CB0C File Offset: 0x0002AD0C
		internal static object LIGapZpHJ7EfdVN5Gts(object A_0, object A_1)
		{
			return A_0.Split(A_1);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0002CB24 File Offset: 0x0002AD24
		internal static object Pu9g35pt9oJoGwg5hTc(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x0002CB38 File Offset: 0x0002AD38
		internal static int qaGWocpYi7HMn68dfDY(object A_0, int A_1, int A_2)
		{
			return A_0.Next(A_1, A_2);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002CB54 File Offset: 0x0002AD54
		internal static object dABPAGpsKgcNGd18HWa(object A_0)
		{
			return A_0.Keyboard;
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002CB68 File Offset: 0x0002AD68
		internal static void it10mxpgecgAD1U7GmT(int A_0)
		{
			Thread.Sleep(A_0);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0002CB7C File Offset: 0x0002AD7C
		internal static object nRrgTFpX9PW6bjtM7Dn(object A_0, VirtualKeyCode A_1)
		{
			return A_0.KeyDown(A_1);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0002CB94 File Offset: 0x0002AD94
		internal static object h00EC2pMO6bWpqaYrDQ(object A_0, VirtualKeyCode A_1)
		{
			return A_0.KeyUp(A_1);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002CBAC File Offset: 0x0002ADAC
		internal static void z0bWTOpGSPqcpjEuKtP(object A_0, ushort key, KeyState state)
		{
			A_0.SendKey(key, state);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0002CBC8 File Offset: 0x0002ADC8
		internal static void DgsWkQpBWCKMJy8bBSC()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x040001D1 RID: 465
		private static readonly Dictionary<string, ushort> USCodes;

		// Token: 0x040001D2 RID: 466
		private static readonly Dictionary<string, VirtualKeyCode> VirtualKeys;

		// Token: 0x040001D3 RID: 467
		public int mode;

		// Token: 0x040001D4 RID: 468
		public Input input;

		// Token: 0x040001D5 RID: 469
		[CompilerGenerated]
		private EventHandler<LogEventArgs> NewLogEvent;

		// Token: 0x040001D6 RID: 470
		private string previousKey;

		// Token: 0x040001D7 RID: 471
		private long previousKeyTime;

		// Token: 0x040001D8 RID: 472
		private Random r;

		// Token: 0x040001D9 RID: 473
		private InputSimulator WinInput;

		// Token: 0x040001DA RID: 474
		internal static ceGL4JcAiPYF89VVIUS eRQ4BKpKLEFv8tAHshx;
	}
}
