using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MyU9Ep58ZH3s5ThDFJQ;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x0200002A RID: 42
	public partial class FrmDownloadUpdate : Form
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x00029838 File Offset: 0x00027A38
		public FrmDownloadUpdate()
		{
			FrmDownloadUpdate.f6iIDQpcpbSlN0MgIQV();
			FrmDownloadUpdate.s9nbkUp5e5tOK3lPbVQ();
			this.dest = "";
			base..ctor();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					this.txCcwt2AaR();
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				}
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000298CC File Offset: 0x00027ACC
		private void S2CcdWRmdc(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000298D8 File Offset: 0x00027AD8
		public void startDownload(string url, string destination, string token, string hwid)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CS$<>8__locals1.destination = destination2;
					num2 = 7;
					continue;
				case 3:
					FrmDownloadUpdate.V6ihhupx3appdf0N8qM(new Thread(new ThreadStart(CS$<>8__locals1.j92cgSDPsi)));
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					CS$<>8__locals1.<>4__this = this;
					CS$<>8__locals1.url = url2;
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 5:
					CS$<>8__locals1.hwid = hwid2;
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					return;
				case 7:
					this.dest = CS$<>8__locals1.destination;
					num2 = 3;
					continue;
				}
				CS$<>8__locals1.token = token2;
				num2 = 4;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00029A18 File Offset: 0x00027C18
		public void startDownloadInstaller(string url, string destination)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_5C;
				case 2:
					CS$<>8__locals1.url = url2;
					num2 = 3;
					continue;
				case 3:
					CS$<>8__locals1.destination = destination2;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					CS$<>8__locals1.<>4__this = this;
					num2 = 2;
					continue;
				case 5:
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				this.dest = CS$<>8__locals1.destination;
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
				{
					num2 = 1;
				}
			}
			IL_5C:
			FrmDownloadUpdate.V6ihhupx3appdf0N8qM(new Thread(new ThreadStart(CS$<>8__locals1.LmWcXjcmJu)));
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00029B0C File Offset: 0x00027D0C
		private void FMRcoHwO3f(object \u0020, DownloadProgressChangedEventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					CS$<>8__locals1.e = \u0020;
					num2 = 3;
					break;
				case 1:
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					goto IL_45;
				case 3:
					CS$<>8__locals1.<>4__this = this;
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_45:
			base.BeginInvoke(new MethodInvoker(CS$<>8__locals1.zwjcM1PcB1));
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00029BBC File Offset: 0x00027DBC
		private void VNYc3Jw3qP(object \u0020, AsyncCompletedEventArgs \u0020)
		{
			FrmDownloadUpdate.<>c__DisplayClass6_0 CS$<>8__locals1 = new FrmDownloadUpdate.<>c__DisplayClass6_0();
			CS$<>8__locals1.e = \u0020;
			int num = 2;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					FrmDownloadUpdate.KOsAR3puPTXY3W1Ylbt(this, new MethodInvoker(CS$<>8__locals1.GGhcGttBES));
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 2:
					CS$<>8__locals1.<>4__this = this;
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00029C70 File Offset: 0x00027E70
		private void N1bcQUwoRr(object \u0020, AsyncCompletedEventArgs \u0020)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					FrmDownloadUpdate.KOsAR3puPTXY3W1Ylbt(this, new MethodInvoker(CS$<>8__locals1.SSQcB4FmCN));
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					CS$<>8__locals1.e = \u0020;
					CS$<>8__locals1.<>4__this = this;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					num2 = 2;
					continue;
				}
				break;
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00029D20 File Offset: 0x00027F20
		private void tAXcC8Lesm(object \u0020, EventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				FormBorderStyle formBorderStyle;
				switch (num2)
				{
				case 1:
					FrmDownloadUpdate.RT2D3ipVlKDLRF1l4LP(this, false);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				case 3:
					FrmDownloadUpdate.qjY9iGp8uXCGPZKroqo(this, FormBorderStyle.None);
					base.FormBorderStyle = formBorderStyle;
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				formBorderStyle = FrmDownloadUpdate.AI1OQDpye3FTP5jMkVa(this);
				num2 = 3;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00029DC4 File Offset: 0x00027FC4
		private void eqHc9vNE0V(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00029E88 File Offset: 0x00028088
		private void txCcwt2AaR()
		{
			int num = 18;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						FrmDownloadUpdate.v5FlhSpZqrMtMMS36Ur(this, AutoScaleMode.Font);
						num2 = 25;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 == 0)
						{
							num2 = 25;
							continue;
						}
						continue;
					case 2:
						FrmDownloadUpdate.XSLer3p4nLDIS0ELw2x(this, false);
						num2 = 21;
						continue;
					case 3:
						FrmDownloadUpdate.FNgPN1p3eHkPb9OO6lp(this.guna2ProgressBar1, 1);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 == 0)
						{
							num2 = 26;
							continue;
						}
						continue;
					case 4:
						this.guna2ProgressBar1.BorderColor = FrmDownloadUpdate.olHcl9pdqsuhCWQmhuO();
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 5:
						FrmDownloadUpdate.HMZUChpiwqmu4UrZ0G2(this, new SizeF(6f, 13f));
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						this.guna2ProgressBar1.ValueChanged += this.eqHc9vNE0V;
						num2 = 5;
						continue;
					case 7:
						FrmDownloadUpdate.HR5kYOpoGNaFl1R19ST(this.guna2ProgressBar1, 5);
						num2 = 3;
						continue;
					case 8:
						FrmDownloadUpdate.vcAChFpIHOPXI7Q4Hsv(this.guna2ProgressBar1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(764415235 ^ 764431273));
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 9:
						FrmDownloadUpdate.wkjBcFpltyvFHkL0s8j(this, false);
						num2 = 11;
						continue;
					case 10:
						goto IL_410;
					case 11:
						return;
					case 12:
						goto IL_33D;
					case 13:
						this.guna2ProgressBar1.Location = new Point(8, 8);
						num2 = 15;
						continue;
					case 14:
						FrmDownloadUpdate.nyIh9JppIKUKwrwaAV5(FrmDownloadUpdate.mGLiu6p1GBsPvXxHTq4(this), this.guna2ProgressBar1);
						FrmDownloadUpdate.qjY9iGp8uXCGPZKroqo(this, FormBorderStyle.FixedDialog);
						num2 = 2;
						continue;
					case 15:
						FrmDownloadUpdate.YyZlpEpCkOLnJt5vL3p(this.guna2ProgressBar1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1495818301 ^ -1495803543));
						num2 = 19;
						continue;
					case 16:
						FrmDownloadUpdate.Kg3JPUpho6w18ieUc4m(this.guna2ProgressBar1, new Size(346, 30));
						num2 = 23;
						continue;
					case 17:
						base.SuspendLayout();
						num2 = 4;
						continue;
					case 18:
						this.guna2ProgressBar1 = new Guna2ProgressBar();
						num2 = 17;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab != 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					case 19:
						FrmDownloadUpdate.ECxbpQpwJ8MLPBZEFep(this.guna2ProgressBar1, FrmDownloadUpdate.EUuoKAp93BRRmGTgotF());
						FrmDownloadUpdate.Fhv8qZpA4k0XdJTKmpQ(this.guna2ProgressBar1, true);
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 20:
						FrmDownloadUpdate.HqFcKtpRICYoTmbmBos(this, new EventHandler(this.S2CcdWRmdc));
						FrmDownloadUpdate.fDkwfvpLGuCLioVABH0(this, new EventHandler(this.tAXcC8Lesm));
						num2 = 9;
						continue;
					case 21:
						base.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1366152946 ^ -1366134818);
						FrmDownloadUpdate.CU2o1UpOIEAnLZZDqYY(this, new Padding(8));
						num2 = 10;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 != 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 22:
						FrmDownloadUpdate.Y3XYKPpFipONML2vfal(this, FormStartPosition.CenterParent);
						num2 = 21;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
						{
							num2 = 24;
							continue;
						}
						continue;
					case 23:
						FrmDownloadUpdate.pfLvODpSqEUBjuvFWxS(this.guna2ProgressBar1, 0);
						num2 = 8;
						continue;
					case 24:
						FrmDownloadUpdate.vcAChFpIHOPXI7Q4Hsv(this, FrmDownloadUpdate.o3KmsUpTCAdOQw4Dopi(-1897624240 ^ -1897608282));
						num2 = 18;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d != 0)
						{
							num2 = 20;
							continue;
						}
						continue;
					case 25:
						FrmDownloadUpdate.vesJI3pUJ3Xg8YAKXXp(this, new Size(362, 46));
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e != 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					case 26:
						FrmDownloadUpdate.gBnagnpQZWcqlrHEJt6(this.guna2ProgressBar1, DockStyle.Fill);
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					}
					this.guna2ProgressBar1.TextRenderingHint = TextRenderingHint.SystemDefault;
					num2 = 6;
				}
				IL_33D:
				base.ShowInTaskbar = false;
				num = 22;
				continue;
				IL_410:
				FrmDownloadUpdate.ljFqenpfiA1njqWwQh6(this, false);
				num = 12;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0002A2BC File Offset: 0x000284BC
		// Note: this type is marked as 'beforefieldinit'.
		static FrmDownloadUpdate()
		{
			FrmDownloadUpdate.iScBdjpatHg792Eufsq();
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0002A2CC File Offset: 0x000284CC
		internal static void f6iIDQpcpbSlN0MgIQV()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0002A2DC File Offset: 0x000284DC
		internal static void s9nbkUp5e5tOK3lPbVQ()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0002A2EC File Offset: 0x000284EC
		internal static bool IPakM5pPuqal0E5cmy9()
		{
			return FrmDownloadUpdate.GSv0cxpWpYC0jq2L43L == null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002A300 File Offset: 0x00028500
		internal static FrmDownloadUpdate g4IPIBpEdJgNrBJOiRr()
		{
			return FrmDownloadUpdate.GSv0cxpWpYC0jq2L43L;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0002A310 File Offset: 0x00028510
		internal static void V6ihhupx3appdf0N8qM(object A_0)
		{
			A_0.Start();
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002A324 File Offset: 0x00028524
		internal static object KOsAR3puPTXY3W1Ylbt(object A_0, object A_1)
		{
			return A_0.BeginInvoke(A_1);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0002A33C File Offset: 0x0002853C
		internal static void RT2D3ipVlKDLRF1l4LP(object A_0, bool A_1)
		{
			A_0.ControlBox = A_1;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0002A354 File Offset: 0x00028554
		internal static FormBorderStyle AI1OQDpye3FTP5jMkVa(object A_0)
		{
			return A_0.FormBorderStyle;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0002A368 File Offset: 0x00028568
		internal static void qjY9iGp8uXCGPZKroqo(object A_0, FormBorderStyle A_1)
		{
			A_0.FormBorderStyle = A_1;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0002A380 File Offset: 0x00028580
		internal static void FhhmdSpqIxYAdNacYKr(object A_0)
		{
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0002A394 File Offset: 0x00028594
		internal static Color olHcl9pdqsuhCWQmhuO()
		{
			return Color.DarkGray;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0002A3A4 File Offset: 0x000285A4
		internal static void HR5kYOpoGNaFl1R19ST(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0002A3BC File Offset: 0x000285BC
		internal static void FNgPN1p3eHkPb9OO6lp(object A_0, int A_1)
		{
			A_0.BorderThickness = A_1;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0002A3D4 File Offset: 0x000285D4
		internal static void gBnagnpQZWcqlrHEJt6(object A_0, DockStyle A_1)
		{
			A_0.Dock = A_1;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0002A3EC File Offset: 0x000285EC
		internal static void YyZlpEpCkOLnJt5vL3p(object A_0, object A_1)
		{
			A_0.Name = A_1;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0002A404 File Offset: 0x00028604
		internal static Color EUuoKAp93BRRmGTgotF()
		{
			return Color.DodgerBlue;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0002A414 File Offset: 0x00028614
		internal static void ECxbpQpwJ8MLPBZEFep(object A_0, Color A_1)
		{
			A_0.ProgressColor = A_1;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0002A42C File Offset: 0x0002862C
		internal static void Fhv8qZpA4k0XdJTKmpQ(object A_0, bool A_1)
		{
			A_0.ShowText = A_1;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0002A444 File Offset: 0x00028644
		internal static void Kg3JPUpho6w18ieUc4m(object A_0, Size A_1)
		{
			A_0.Size = A_1;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0002A45C File Offset: 0x0002865C
		internal static void pfLvODpSqEUBjuvFWxS(object A_0, int A_1)
		{
			A_0.TabIndex = A_1;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0002A474 File Offset: 0x00028674
		internal static void vcAChFpIHOPXI7Q4Hsv(object A_0, object A_1)
		{
			A_0.Text = A_1;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0002A48C File Offset: 0x0002868C
		internal static void HMZUChpiwqmu4UrZ0G2(object A_0, SizeF A_1)
		{
			A_0.AutoScaleDimensions = A_1;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0002A4A4 File Offset: 0x000286A4
		internal static void v5FlhSpZqrMtMMS36Ur(object A_0, AutoScaleMode A_1)
		{
			A_0.AutoScaleMode = A_1;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0002A4BC File Offset: 0x000286BC
		internal static void vesJI3pUJ3Xg8YAKXXp(object A_0, Size A_1)
		{
			A_0.ClientSize = A_1;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0002A4D4 File Offset: 0x000286D4
		internal static object mGLiu6p1GBsPvXxHTq4(object A_0)
		{
			return A_0.Controls;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0002A4E8 File Offset: 0x000286E8
		internal static void nyIh9JppIKUKwrwaAV5(object A_0, object A_1)
		{
			A_0.Add(A_1);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0002A500 File Offset: 0x00028700
		internal static void XSLer3p4nLDIS0ELw2x(object A_0, bool A_1)
		{
			A_0.MaximizeBox = A_1;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0002A518 File Offset: 0x00028718
		internal static void CU2o1UpOIEAnLZZDqYY(object A_0, Padding A_1)
		{
			A_0.Padding = A_1;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0002A530 File Offset: 0x00028730
		internal static void ljFqenpfiA1njqWwQh6(object A_0, bool A_1)
		{
			A_0.ShowIcon = A_1;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0002A548 File Offset: 0x00028748
		internal static void Y3XYKPpFipONML2vfal(object A_0, FormStartPosition A_1)
		{
			A_0.StartPosition = A_1;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0002A560 File Offset: 0x00028760
		internal static object o3KmsUpTCAdOQw4Dopi(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0002A574 File Offset: 0x00028774
		internal static void HqFcKtpRICYoTmbmBos(object A_0, object A_1)
		{
			A_0.Load += A_1;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0002A58C File Offset: 0x0002878C
		internal static void fDkwfvpLGuCLioVABH0(object A_0, object A_1)
		{
			A_0.Shown += A_1;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0002A5A4 File Offset: 0x000287A4
		internal static void wkjBcFpltyvFHkL0s8j(object A_0, bool A_1)
		{
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0002A5BC File Offset: 0x000287BC
		internal static void iScBdjpatHg792Eufsq()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x040001BA RID: 442
		private string dest;

		// Token: 0x040001BC RID: 444
		private Guna2ProgressBar guna2ProgressBar1;

		// Token: 0x040001BD RID: 445
		internal static FrmDownloadUpdate GSv0cxpWpYC0jq2L43L;
	}
}
