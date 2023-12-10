using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using bSZew2cfycgxx2Qytd1;
using Guna.UI2.WinForms;
using HXZlbT7UB5IYGdPogh;
using MyU9Ep58ZH3s5ThDFJQ;
using PFKsXUln68gK98ndGV;
using qh4tv5C06LoTjDckaL;
using wKolMkxZecDx58YaRR4;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x02000029 RID: 41
	public partial class FormLogin : Form
	{
		// Token: 0x06000426 RID: 1062 RVA: 0x00027130 File Offset: 0x00025330
		public FormLogin()
		{
			FormLogin.Gli1IuUf4eJ2x46uj2e();
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			base..ctor();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e != 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.oP1cqEEoBC();
				num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be != 0)
				{
					num = 0;
				}
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000271B4 File Offset: 0x000253B4
		private void CDKccEHDtI(string \u0020, string \u0020, MessageBoxIcon \u0020)
		{
			FormLogin.FIVmLOUFLjotdF57r8O(this, \u0020, \u0020, MessageBoxButtons.OK, \u0020);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000271D4 File Offset: 0x000253D4
		private void EF2c5Y431h(object \u0020, EventArgs \u0020)
		{
			int num = 14;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					fdnuM4r7mAGiieBZPu fdnuM4r7mAGiieBZPu;
					InA3Q4LFDQmiFopNqj inA3Q4LFDQmiFopNqj;
					switch (num2)
					{
					case 1:
						goto IL_3AA;
					case 2:
						goto IL_21D;
					case 3:
						goto IL_2FD;
					case 4:
						fdnuM4r7mAGiieBZPu = FormLogin.TImMdCUlqel3AsiYKeU(this.txtUsername.Text, this.textPassword.Text);
						num2 = 11;
						continue;
					case 5:
						this.CDKccEHDtI(FormLogin.y0b3dSUaVghYC7Y2OZU(-1307524010 ^ -1307524290), fdnuM4r7mAGiieBZPu.Error, MessageBoxIcon.Hand);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 6:
						FormLogin.YxIJrgUrcWFa80bWKZS(yQGkVJcOSOQdjuwds7e.ini);
						num2 = 12;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 != 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 7:
						FormLogin.tYIOgSU7bpsZKIeXEuk(this);
						goto IL_3AA;
					case 8:
						goto IL_3F6;
					case 9:
						goto IL_2A3;
					case 10:
						return;
					case 11:
						if (fdnuM4r7mAGiieBZPu != null && fdnuM4r7mAGiieBZPu.Error != null)
						{
							num2 = 5;
							continue;
						}
						if (fdnuM4r7mAGiieBZPu.Token != null)
						{
							goto IL_11F;
						}
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 == 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					case 12:
						yQGkVJcOSOQdjuwds7e.AuthenticatedUserData = inA3Q4LFDQmiFopNqj;
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 13:
						goto IL_3F6;
					case 14:
						if (!(FormLogin.eLTx0xUTyoqVMyI4S4Q(this.txtUsername) != ""))
						{
							goto Block_9;
						}
						goto IL_21D;
					case 15:
						goto IL_3AA;
					case 16:
						goto IL_2A3;
					case 17:
						goto IL_D0;
					case 18:
						goto IL_3AA;
					case 19:
						FormLogin.bRIXYGUk8PjxbrsYlw3(yQGkVJcOSOQdjuwds7e.ini, FormLogin.y0b3dSUaVghYC7Y2OZU(-693910567 ^ -693911285), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-693910567 ^ -693911235), fdnuM4r7mAGiieBZPu.Token);
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 20:
						if (inA3Q4LFDQmiFopNqj == null)
						{
							num2 = 15;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
							{
								num2 = 22;
								continue;
							}
							continue;
						}
						else
						{
							if (inA3Q4LFDQmiFopNqj.Error != null)
							{
								num2 = 9;
								continue;
							}
							goto IL_D0;
						}
						break;
					case 21:
						goto IL_11F;
					case 22:
						goto IL_2FD;
					case 23:
						return;
					case 24:
						inA3Q4LFDQmiFopNqj = FormLogin.BxH1Z8UeV74m6sKFR06(fdnuM4r7mAGiieBZPu.Token);
						num2 = 10;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
						{
							num2 = 20;
							continue;
						}
						continue;
					case 25:
						goto IL_3AA;
					}
					IL_8B:
					FormLogin.DhRoWMULf2ObRlVwpxm(this.guna2GradientButton1, false);
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_D0:
					if (inA3Q4LFDQmiFopNqj.Username == null)
					{
						goto IL_2A3;
					}
					num2 = 11;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
					{
						num2 = 19;
						continue;
					}
					continue;
					IL_11F:
					FormLogin.PJua3hUKbHTEo4QpKIm(fdnuM4r7mAGiieBZPu.Token);
					num2 = 24;
					continue;
					IL_2A3:
					this.CDKccEHDtI(FormLogin.y0b3dSUaVghYC7Y2OZU(-1307524010 ^ -1307524290), inA3Q4LFDQmiFopNqj.Error, MessageBoxIcon.Hand);
					num2 = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 != 0)
					{
						num2 = 25;
						continue;
					}
					continue;
					IL_2FD:
					this.CDKccEHDtI(FormLogin.y0b3dSUaVghYC7Y2OZU(-1050340572 ^ -1050340276), FormLogin.y0b3dSUaVghYC7Y2OZU(-564572999 ^ -564590159), MessageBoxIcon.Hand);
					num2 = 18;
					continue;
					IL_3AA:
					FormLogin.DhRoWMULf2ObRlVwpxm(this.guna2GradientButton1, true);
					num2 = 10;
					continue;
					IL_3F6:
					this.CDKccEHDtI(FormLogin.y0b3dSUaVghYC7Y2OZU(-1399929319 << 3 ^ 1685469088), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(951294359 ^ 47512224 ^ 979838563), MessageBoxIcon.Exclamation);
					num2 = 21;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 == 0)
					{
						num2 = 23;
						continue;
					}
					continue;
					IL_21D:
					if (!FormLogin.NSEEbmURCEx30jq7eRh(FormLogin.eLTx0xUTyoqVMyI4S4Q(this.textPassword), ""))
					{
						goto Block_11;
					}
					goto IL_8B;
				}
				Block_9:
				num = 13;
				continue;
				Block_11:
				num = 8;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00027624 File Offset: 0x00025824
		private void koXcxqeKeE(object \u0020, EventArgs \u0020)
		{
			FormLogin.mP7F3PU2CQnPexKs3Ye(FormLogin.y0b3dSUaVghYC7Y2OZU(828767401 >> 3 ^ 103610895));
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00027650 File Offset: 0x00025850
		private void rNicuo1Ctr(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0002765C File Offset: 0x0002585C
		private void qrKcVZIAiM(object \u0020, KeyEventArgs \u0020)
		{
			if (FormLogin.GfCKd6U6HhuZdteSSNt(\u0020) == Keys.Return)
			{
				this.EF2c5Y431h(\u0020, null);
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x000276BC File Offset: 0x000258BC
		private void wXIcyyiivn(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000276C8 File Offset: 0x000258C8
		private void pvjc8Vu8Qt(object \u0020, KeyEventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (FormLogin.GfCKd6U6HhuZdteSSNt(\u0020) != Keys.Return)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			this.EF2c5Y431h(\u0020, null);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000277F0 File Offset: 0x000259F0
		private void oP1cqEEoBC()
		{
			int num = 134;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						FormLogin.EKiK5XUvAhaeyQ7X0rU(this.txtUsername, "");
						num2 = 14;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 == 0)
						{
							num2 = 21;
							continue;
						}
						continue;
					case 2:
						FormLogin.HryO4P13gbySQ2kXBSe(this.guna2GradientButton1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886920092));
						num2 = 118;
						continue;
					case 3:
						FormLogin.DfS0WN1QdruKWGSlf46(FormLogin.mV38ms1VbYQNFeUpvVX(this.guna2GradientButton2), FormLogin.GPqAJ21yE1OKZhm7kc0());
						num2 = 7;
						continue;
					case 4:
						FormLogin.FSICPWUMQ10Ai3ikM7w(this.textPassword, new Point(12, 120));
						num2 = 49;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 != 0)
						{
							num2 = 58;
							continue;
						}
						continue;
					case 5:
						FormLogin.Mpkj0E1sTCiQxHLiIh4(this, new SizeF(6f, 13f));
						num2 = 37;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae != 0)
						{
							num2 = 110;
							continue;
						}
						continue;
					case 6:
						FormLogin.HryO4P13gbySQ2kXBSe(this, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-940667910 + -206218605 ^ -1146904373));
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 != 0)
						{
							num2 = 50;
							continue;
						}
						continue;
					case 7:
						FormLogin.mV38ms1VbYQNFeUpvVX(this.guna2GradientButton2).CustomBorderColor = FormLogin.GPqAJ21yE1OKZhm7kc0();
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
						{
							num2 = 131;
							continue;
						}
						continue;
					case 8:
						this.textPassword = new Guna2TextBox();
						num2 = 15;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 == 0)
						{
							num2 = 55;
							continue;
						}
						continue;
					case 9:
						goto IL_1396;
					case 10:
						FormLogin.gVEGcy1R7WIIgVTSLH4(this.guna2GradientPanel1, LinearGradientMode.Vertical);
						num2 = 23;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa == 0)
						{
							num2 = 84;
							continue;
						}
						continue;
					case 11:
						goto IL_33C;
					case 12:
						FormLogin.qmMXPd1pCOY1QTwPXAZ(this.guna2BorderlessForm1, true);
						FormLogin.am5WOo14tYD0TiGZ38o(this.guna2GradientPanel1, Color.Silver);
						num2 = 66;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 == 0)
						{
							num2 = 43;
							continue;
						}
						continue;
					case 13:
						goto IL_137A;
					case 14:
						FormLogin.hKmPNuUtbUpqB2W8ZDj(this.txtUsername).ForeColor = FormLogin.ccT00mUsUy7TJ3MFLQ6(138, 138, 138);
						FormLogin.JVM7WkUgoKsNGBCvUsI(FormLogin.hKmPNuUtbUpqB2W8ZDj(this.txtUsername), Color.FromArgb(138, 138, 138));
						num2 = 122;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 != 0)
						{
							num2 = 19;
							continue;
						}
						continue;
					case 15:
						FormLogin.xCFjLuUmm9ObmywAkFt(this.txtUsername, 5);
						FormLogin.Icu7LmUHTXZ6mOhqUbL(this.txtUsername, Cursors.IBeam);
						num2 = 60;
						continue;
					case 16:
						this.guna2ControlBox1.BorderThickness = 1;
						num2 = 105;
						continue;
					case 17:
						goto IL_1041;
					case 18:
						FormLogin.mSfWtC1isbJslVTJjmx(this.guna2BorderlessForm1, 25);
						num2 = 91;
						continue;
					case 19:
						goto IL_125C;
					case 20:
						FormLogin.QYxSIb1XvcCYRsHohqG(this, FormBorderStyle.None);
						num2 = 64;
						continue;
					case 21:
						this.txtUsername.Size = new Size(349, 36);
						num2 = 21;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
						{
							num2 = 96;
							continue;
						}
						continue;
					case 22:
						FormLogin.jqqbAf15C3Q3OHfylmH(this.guna2GradientButton1, new Size(244, 37));
						num2 = 49;
						continue;
					case 23:
						this.guna2PictureBox1.ImageRotate = 0f;
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
						{
							num2 = 28;
							continue;
						}
						continue;
					case 24:
						FormLogin.R9Udsd1uMycLLATJwUx(this.guna2GradientButton2, 5);
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 25:
						FormLogin.hKmPNuUtbUpqB2W8ZDj(this.textPassword).ForeColor = Color.FromArgb(138, 138, 138);
						this.textPassword.DisabledState.PlaceholderForeColor = FormLogin.ccT00mUsUy7TJ3MFLQ6(138, 138, 138);
						num2 = 86;
						continue;
					case 26:
						goto IL_1474;
					case 27:
						this.guna2GradientButton2.TabIndex = 5;
						num2 = 72;
						continue;
					case 28:
						FormLogin.FSICPWUMQ10Ai3ikM7w(this.guna2PictureBox1, new Point(9, 8));
						num2 = 53;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
						{
							num2 = 19;
							continue;
						}
						continue;
					case 29:
						this.guna2PictureBox1.Size = new Size(192, 42);
						num2 = 36;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 != 0)
						{
							num2 = 51;
							continue;
						}
						continue;
					case 30:
						this.guna2GradientPanel1.TabIndex = 8;
						num2 = 78;
						continue;
					case 31:
						FormLogin.LEffyH1o2LjYfejP1ER(this.guna2GradientButton2, FormLogin.d4wJAD1hIEImjIZKZJZ());
						num2 = 94;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa != 0)
						{
							num2 = 61;
							continue;
						}
						continue;
					case 32:
						FormLogin.asupEo1t9rZ10vsa5mn(this.guna2DragControl1, 0.6);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 33:
						this.guna2ControlBox1.TabIndex = 4;
						num2 = 83;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
						{
							num2 = 28;
							continue;
						}
						continue;
					case 34:
						this.guna2ControlBox1.Location = new Point(344, 15);
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
						{
							num2 = 82;
							continue;
						}
						continue;
					case 35:
						this.guna2ControlBox1 = new Guna2ControlBox();
						num2 = 54;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 == 0)
						{
							num2 = 29;
							continue;
						}
						continue;
					case 36:
						FormLogin.R9Udsd1uMycLLATJwUx(this.guna2GradientButton1, 5);
						num2 = 107;
						continue;
					case 37:
						this.guna2GradientButton2.Size = new Size(90, 37);
						num2 = 27;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 38:
						FormLogin.nkvgXy1fENwk96syEER(base.Controls, this.guna2GradientButton1);
						num2 = 47;
						continue;
					case 39:
						FormLogin.K3SKTo1LQW0uZQlcrW2(this.guna2GradientPanel1, new Padding(2));
						num2 = 47;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d != 0)
						{
							num2 = 57;
							continue;
						}
						continue;
					case 40:
						FormLogin.K5hUd01q7KiHxZFQsu0(FormLogin.mV38ms1VbYQNFeUpvVX(this.guna2GradientButton1), FormLogin.ccT00mUsUy7TJ3MFLQ6(141, 141, 141));
						num2 = 113;
						continue;
					case 41:
						this.guna2PictureBox1.BeginInit();
						FormLogin.d5LYDiUJRCro1TrXORc(this);
						num2 = 15;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 42:
						this.textPassword.BorderRadius = 5;
						num2 = 121;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 43:
						FormLogin.OgPZSb1GtFE8kRv8m9J(this, false);
						num2 = 71;
						continue;
					case 44:
						FormLogin.rTb8ZAUjGchk32iTgWH(this.txtUsername, new EventHandler(this.wXIcyyiivn));
						FormLogin.zreG8mUbIMKkBUXgAhO(this.txtUsername, new KeyEventHandler(this.pvjc8Vu8Qt));
						num2 = 42;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
						{
							num2 = 23;
							continue;
						}
						continue;
					case 45:
						goto IL_56F;
					case 46:
						this.guna2DragControl2 = new Guna2DragControl(this.components);
						num2 = 114;
						continue;
					case 47:
						FormLogin.nkvgXy1fENwk96syEER(base.Controls, this.textPassword);
						num2 = 119;
						continue;
					case 48:
						FormLogin.pr3QoL1jhy9OfDatiGC(this.guna2PictureBox1);
						num2 = 59;
						continue;
					case 49:
						FormLogin.bLtH6i1x8G0pLl0slGt(this.guna2GradientButton1, 4);
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 50:
						FormLogin.MVw0fC1vc1ACY9d0Ndk(this.guna2GradientPanel1, false);
						num2 = 48;
						continue;
					case 51:
						this.guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
						num2 = 52;
						continue;
					case 52:
						FormLogin.DAU7VG1JjByru9Asypy(this.guna2PictureBox1, 1);
						num2 = 67;
						continue;
					case 53:
						FormLogin.K3SKTo1LQW0uZQlcrW2(this.guna2PictureBox1, new Padding(2));
						num2 = 19;
						continue;
					case 54:
						this.guna2PictureBox1 = new Guna2PictureBox();
						num2 = 68;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
						{
							num2 = 128;
							continue;
						}
						continue;
					case 55:
						this.guna2GradientButton1 = new Guna2GradientButton();
						num2 = 111;
						continue;
					case 56:
						goto IL_83A;
					case 57:
						FormLogin.HRPtsxUG81FtrJtuZXT(this.guna2GradientPanel1, FormLogin.y0b3dSUaVghYC7Y2OZU(1933679734 ^ -1218001364 ^ -1004052002));
						num2 = 115;
						continue;
					case 58:
						goto IL_A2F;
					case 59:
						FormLogin.Ic6go31bXYTOaRgiXVJ(this, false);
						num2 = 135;
						continue;
					case 60:
						this.txtUsername.DefaultText = "";
						num2 = 85;
						continue;
					case 61:
						FormLogin.mV38ms1VbYQNFeUpvVX(this.guna2GradientButton1).FillColor2 = FormLogin.ccT00mUsUy7TJ3MFLQ6(169, 169, 169);
						num2 = 40;
						continue;
					case 62:
						goto IL_C67;
					case 63:
						FormLogin.K5hUd01q7KiHxZFQsu0(this.guna2GradientButton2.DisabledState, FormLogin.ccT00mUsUy7TJ3MFLQ6(141, 141, 141));
						num2 = 99;
						continue;
					case 64:
						FormLogin.oECdLj1MviqCZZpJBrS(this, false);
						num2 = 43;
						continue;
					case 65:
						FormLogin.NKAskP19TnT2S7Vmi6R(this.guna2GradientButton2.DisabledState, FormLogin.ccT00mUsUy7TJ3MFLQ6(169, 169, 169));
						num2 = 59;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
						{
							num2 = 63;
							continue;
						}
						continue;
					case 66:
						FormLogin.nkvgXy1fENwk96syEER(FormLogin.NOKh6m1Olsjmp8Xwitn(this.guna2GradientPanel1), this.guna2ControlBox1);
						num2 = 76;
						continue;
					case 67:
						FormLogin.dx19EW1mYdHFYYj5AHE(this.guna2PictureBox1, false);
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 68:
						FormLogin.nIwxetUDEtwoxjTPXsV(this.txtUsername, FormLogin.y0b3dSUaVghYC7Y2OZU(464986539 ^ 464984795));
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 69:
						FormLogin.HRPtsxUG81FtrJtuZXT(this.guna2ControlBox1, FormLogin.y0b3dSUaVghYC7Y2OZU(790722942 ^ 790708944));
						FormLogin.uEyK0Q17R0BlJQhZHmS(this.guna2ControlBox1.ShadowDecoration, true);
						FormLogin.yBPWk216MdFKv0nY8dI(FormLogin.hKYVjv121qLesdrWdT0(this.guna2ControlBox1), new Padding(1));
						num2 = 127;
						continue;
					case 70:
						this.textPassword.PasswordChar = '*';
						num2 = 11;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					case 71:
						base.Name = FormLogin.y0b3dSUaVghYC7Y2OZU(1308721404 ^ 1308739176);
						num2 = 74;
						continue;
					case 72:
						goto IL_A94;
					case 73:
						this.guna2GradientPanel1.FillColor = Color.FromArgb(64, 64, 64);
						num2 = 106;
						continue;
					case 74:
						FormLogin.g15HY11BhD48TIuIkfy(this, false);
						num2 = 97;
						continue;
					case 75:
						FormLogin.rQZcfS1FeTibHnx0KKi(this.guna2GradientPanel1, DockStyle.Top);
						num2 = 73;
						continue;
					case 76:
						goto IL_CE4;
					case 77:
						FormLogin.DQ0s1C1njOGGnubG9pt(this.guna2PictureBox1, FormLogin.nN71eS1axwJHbfYrOtx());
						num2 = 92;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 == 0)
						{
							num2 = 91;
							continue;
						}
						continue;
					case 78:
						goto IL_7B5;
					case 79:
						FormLogin.mV38ms1VbYQNFeUpvVX(this.guna2GradientButton1).FillColor = FormLogin.ccT00mUsUy7TJ3MFLQ6(169, 169, 169);
						num2 = 61;
						continue;
					case 80:
						this.guna2GradientButton1.Location = new Point(117, 171);
						num2 = 51;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
						{
							num2 = 104;
							continue;
						}
						continue;
					case 81:
						this.guna2GradientPanel1 = new Guna2GradientPanel();
						num2 = 35;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 82:
						this.guna2ControlBox1.Margin = new Padding(2);
						num2 = 47;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db != 0)
						{
							num2 = 69;
							continue;
						}
						continue;
					case 83:
						FormLogin.G8MpRn1NSP1vbaYMnjS(this.guna2ControlBox1, true);
						num2 = 77;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 != 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					case 84:
						this.guna2GradientPanel1.Location = new Point(0, 0);
						num2 = 39;
						continue;
					case 85:
						FormLogin.W151ZtUYPr1U2J5yKvk(FormLogin.hKmPNuUtbUpqB2W8ZDj(this.txtUsername), Color.FromArgb(208, 208, 208));
						num2 = 117;
						continue;
					case 86:
						FormLogin.iYcOnS1E7vB2rXuX6EP(this.textPassword).BorderColor = Color.FromArgb(94, 148, 255);
						num2 = 123;
						continue;
					case 87:
						goto IL_C0C;
					case 88:
						FormLogin.ie0IVDUBPShi9GnPGc2(this.txtUsername, '\0');
						num2 = 68;
						continue;
					case 89:
						goto IL_76D;
					case 90:
						FormLogin.FSICPWUMQ10Ai3ikM7w(this.txtUsername, new Point(12, 69));
						num2 = 62;
						continue;
					case 91:
						FormLogin.t1CDfT1ZklrFj2cSJpM(this.guna2BorderlessForm1, this);
						num2 = 39;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
						{
							num2 = 109;
							continue;
						}
						continue;
					case 92:
					{
						ComponentResourceManager componentResourceManager;
						this.guna2PictureBox1.Image = (Image)FormLogin.xJ8LlP103bU0XlalBr3(componentResourceManager, FormLogin.y0b3dSUaVghYC7Y2OZU(-764151834 ^ -764163020));
						num2 = 23;
						continue;
					}
					case 93:
						FormLogin.UiTLgm18xl9aGmX7utx(this.guna2GradientButton1.DisabledState, FormLogin.GPqAJ21yE1OKZhm7kc0());
						num2 = 79;
						continue;
					case 94:
						FormLogin.FSICPWUMQ10Ai3ikM7w(this.guna2GradientButton2, new Point(12, 171));
						num2 = 56;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 95:
						FormLogin.xa8wVW1dR2tCekR6Qka(this.guna2GradientButton2, new Font(FormLogin.y0b3dSUaVghYC7Y2OZU(-886904286 ^ -886914530), 9f));
						num2 = 31;
						continue;
					case 96:
						this.txtUsername.TabIndex = 2;
						num2 = 15;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 != 0)
						{
							num2 = 44;
							continue;
						}
						continue;
					case 97:
						FormLogin.URNbPX1DHV5o4g780Pl(this, FormStartPosition.CenterScreen);
						num2 = 6;
						continue;
					case 98:
						FormLogin.jqqbAf15C3Q3OHfylmH(this.textPassword, new Size(349, 36));
						num2 = 125;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
						{
							num2 = 77;
							continue;
						}
						continue;
					case 99:
						this.guna2GradientButton2.FillColor = FormLogin.jovJTt1wC8qQ2EsSw8I();
						FormLogin.b6i7YJ1ADj1BlniQtKw(this.guna2GradientButton2, FormLogin.jovJTt1wC8qQ2EsSw8I());
						num2 = 10;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
						{
							num2 = 95;
							continue;
						}
						continue;
					case 100:
						FormLogin.EKiK5XUvAhaeyQ7X0rU(this.textPassword, "");
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
						{
							num2 = 98;
							continue;
						}
						continue;
					case 101:
						goto IL_B06;
					case 102:
						base.ClientSize = new Size(381, 230);
						num2 = 57;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 != 0)
						{
							num2 = 87;
							continue;
						}
						continue;
					case 103:
						FormLogin.Yl8yg41IK1fwomh4y5Z(this.guna2BorderlessForm1, true);
						num2 = 18;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 104:
						FormLogin.HRPtsxUG81FtrJtuZXT(this.guna2GradientButton1, FormLogin.y0b3dSUaVghYC7Y2OZU(-1089588375 ^ -1089571469));
						num2 = 12;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					case 105:
						FormLogin.ONFfKA1k3bWmRnffPji(this.guna2ControlBox1, FormLogin.ccT00mUsUy7TJ3MFLQ6(139, 152, 166));
						num2 = 126;
						continue;
					case 106:
						FormLogin.cryaY21THecEXcTc7fL(this.guna2GradientPanel1, FormLogin.ccT00mUsUy7TJ3MFLQ6(60, 60, 60));
						num2 = 10;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 107:
						FormLogin.mV38ms1VbYQNFeUpvVX(this.guna2GradientButton1).BorderColor = FormLogin.GPqAJ21yE1OKZhm7kc0();
						num2 = 93;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
						{
							num2 = 60;
							continue;
						}
						continue;
					case 108:
						FormLogin.DUrrqV1cwMfE7H9Dq5O(this.textPassword).BorderColor = FormLogin.ccT00mUsUy7TJ3MFLQ6(94, 148, 255);
						num2 = 4;
						continue;
					case 109:
						FormLogin.PyO8gc1UbHSiXHDbDTC(this.guna2BorderlessForm1, 0.6);
						FormLogin.eil1WS11FJcRlh7bo9t(this.guna2BorderlessForm1, false);
						num2 = 12;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 110:
						base.AutoScaleMode = AutoScaleMode.Font;
						num2 = 102;
						continue;
					case 111:
						this.guna2GradientButton2 = new Guna2GradientButton();
						num2 = 26;
						continue;
					case 112:
						this.guna2ControlBox1.BackColor = FormLogin.nN71eS1axwJHbfYrOtx();
						FormLogin.toLyOq1KdaG9k2htxnT(this.guna2ControlBox1, FormLogin.ccT00mUsUy7TJ3MFLQ6(224, 224, 224));
						num2 = 120;
						continue;
					case 113:
						FormLogin.xa8wVW1dR2tCekR6Qka(this.guna2GradientButton1, new Font(FormLogin.y0b3dSUaVghYC7Y2OZU(-1352740968 ^ -1352734812), 9f));
						num2 = 11;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
						{
							num2 = 116;
							continue;
						}
						continue;
					case 114:
						FormLogin.VW7HBxU028VrgJgrvwP(this.guna2GradientPanel1);
						num2 = 41;
						continue;
					case 115:
						this.guna2GradientPanel1.Size = new Size(381, 55);
						num2 = 30;
						continue;
					case 116:
						FormLogin.LEffyH1o2LjYfejP1ER(this.guna2GradientButton1, Color.White);
						num2 = 36;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab == 0)
						{
							num2 = 80;
							continue;
						}
						continue;
					case 117:
						this.txtUsername.DisabledState.FillColor = FormLogin.ccT00mUsUy7TJ3MFLQ6(226, 226, 226);
						num2 = 14;
						continue;
					case 118:
						this.guna2GradientButton1.Click += this.EF2c5Y431h;
						num2 = 24;
						continue;
					case 119:
						base.Controls.Add(this.txtUsername);
						num2 = 19;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
						{
							num2 = 20;
							continue;
						}
						continue;
					case 120:
						FormLogin.jULRxh1e7ykYJthhH0T(this.guna2ControlBox1, 5);
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 121:
						FormLogin.Icu7LmUHTXZ6mOhqUbL(this.textPassword, FormLogin.D5dKRZUzLWj2SGRA6XM());
						FormLogin.sm1E861WXPEmwcOJMno(this.textPassword, "");
						num2 = 45;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
						{
							num2 = 45;
							continue;
						}
						continue;
					case 122:
						FormLogin.W151ZtUYPr1U2J5yKvk(this.txtUsername.FocusedState, Color.FromArgb(94, 148, 255));
						num2 = 124;
						continue;
					case 123:
						FormLogin.uTaAXZUXGoHrplnvrAA(this.textPassword, new Font(FormLogin.y0b3dSUaVghYC7Y2OZU(-552555469 << 5 ^ -501895588), 9f));
						num2 = 108;
						continue;
					case 124:
						FormLogin.uTaAXZUXGoHrplnvrAA(this.txtUsername, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(881693030 + 414722879 ^ 1296405657), 9f));
						FormLogin.W151ZtUYPr1U2J5yKvk(this.txtUsername.HoverState, FormLogin.ccT00mUsUy7TJ3MFLQ6(94, 148, 255));
						num2 = 37;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c == 0)
						{
							num2 = 90;
							continue;
						}
						continue;
					case 125:
						FormLogin.bLtH6i1x8G0pLl0slGt(this.textPassword, 3);
						num2 = 13;
						continue;
					case 126:
						FormLogin.DAgmBU1rnkVM73sgRif(this.guna2ControlBox1, Color.White);
						num2 = 34;
						continue;
					case 127:
						this.guna2ControlBox1.Size = new Size(22, 24);
						num2 = 33;
						continue;
					case 128:
						this.guna2DragControl1 = new Guna2DragControl(this.components);
						num2 = 46;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 == 0)
						{
							num2 = 17;
							continue;
						}
						continue;
					case 129:
						this.txtUsername = new Guna2TextBox();
						num2 = 5;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 130:
						FormLogin.MlFaXY1SMNxETYeFkI8(this.guna2GradientButton2, new EventHandler(this.koXcxqeKeE));
						num2 = 103;
						continue;
					case 131:
						FormLogin.xkVH2Q1C0KEhshSetH4(FormLogin.mV38ms1VbYQNFeUpvVX(this.guna2GradientButton2), FormLogin.ccT00mUsUy7TJ3MFLQ6(169, 169, 169));
						num2 = 65;
						continue;
					case 132:
						FormLogin.a0fCmD1Y2ra37sRgeen(this.guna2DragControl2, true);
						num2 = 5;
						continue;
					case 133:
					{
						ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(FormLogin.iLmYASUnrbdcELxvlNw(33554473)));
						num2 = 123;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
						{
							num2 = 129;
							continue;
						}
						continue;
					}
					case 134:
						this.components = new Container();
						num2 = 133;
						continue;
					case 135:
						return;
					}
					this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
					FormLogin.a0fCmD1Y2ra37sRgeen(this.guna2DragControl1, true);
					num2 = 66;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 == 0)
					{
						num2 = 89;
					}
				}
				IL_33C:
				this.textPassword.PlaceholderText = FormLogin.y0b3dSUaVghYC7Y2OZU(-2018852357 ^ -2018867203);
				num = 100;
				continue;
				IL_56F:
				FormLogin.hKmPNuUtbUpqB2W8ZDj(this.textPassword).BorderColor = FormLogin.ccT00mUsUy7TJ3MFLQ6(208, 208, 208);
				FormLogin.M2uWMP1PYSQmcVGmjjS(FormLogin.hKmPNuUtbUpqB2W8ZDj(this.textPassword), FormLogin.ccT00mUsUy7TJ3MFLQ6(226, 226, 226));
				num = 25;
				continue;
				IL_76D:
				FormLogin.asupEo1t9rZ10vsa5mn(this.guna2DragControl2, 0.6);
				num = 101;
				continue;
				IL_7B5:
				this.guna2ControlBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
				num = 17;
				continue;
				IL_83A:
				this.guna2GradientButton2.Name = FormLogin.y0b3dSUaVghYC7Y2OZU(1810931007 ^ 1810946923);
				num = 37;
				continue;
				IL_A2F:
				FormLogin.HRPtsxUG81FtrJtuZXT(this.textPassword, FormLogin.y0b3dSUaVghYC7Y2OZU(~1053049764 ^ -1053034063));
				num = 70;
				continue;
				IL_A94:
				this.guna2GradientButton2.Text = FormLogin.y0b3dSUaVghYC7Y2OZU(1767032709 ^ 1767014661);
				num = 130;
				continue;
				IL_B06:
				this.guna2DragControl2.TargetControl = this.guna2PictureBox1;
				num = 132;
				continue;
				IL_C0C:
				FormLogin.fv0XEF1gPluTQaUxauT(this).Add(this.guna2GradientPanel1);
				FormLogin.nkvgXy1fENwk96syEER(base.Controls, this.guna2GradientButton2);
				num = 38;
				continue;
				IL_C67:
				FormLogin.HRPtsxUG81FtrJtuZXT(this.txtUsername, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(790722942 ^ 790708792));
				num = 88;
				continue;
				IL_CE4:
				FormLogin.nkvgXy1fENwk96syEER(this.guna2GradientPanel1.Controls, this.guna2PictureBox1);
				num = 75;
				continue;
				IL_1041:
				FormLogin.jjGktQ1lMB8jjPQTbmQ(this.guna2ControlBox1, true);
				num = 112;
				continue;
				IL_125C:
				this.guna2PictureBox1.Name = FormLogin.y0b3dSUaVghYC7Y2OZU(579026892 ^ 579011534);
				num = 29;
				continue;
				IL_137A:
				this.textPassword.TextChanged += this.rNicuo1Ctr;
				FormLogin.zreG8mUbIMKkBUXgAhO(this.textPassword, new KeyEventHandler(this.qrKcVZIAiM));
				num = 36;
				continue;
				IL_1396:
				FormLogin.SeeIwc1HVGcBYgfQGE2(this.guna2PictureBox1, true);
				num = 32;
				continue;
				IL_1474:
				this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
				num = 81;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00028F8C File Offset: 0x0002718C
		// Note: this type is marked as 'beforefieldinit'.
		static FormLogin()
		{
			FormLogin.nufxec1znnMnPU86P90();
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00028F9C File Offset: 0x0002719C
		internal static void Gli1IuUf4eJ2x46uj2e()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00028FAC File Offset: 0x000271AC
		internal static bool QaZuPoU4uukeWaekYZU()
		{
			return FormLogin.HnOCB9UpVjmQm8oY9Bq == null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00028FC0 File Offset: 0x000271C0
		internal static FormLogin slGMlPUOC9Hwc0nKAny()
		{
			return FormLogin.HnOCB9UpVjmQm8oY9Bq;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00028FD0 File Offset: 0x000271D0
		internal static DialogResult FIVmLOUFLjotdF57r8O(object A_0, object A_1, object A_2, MessageBoxButtons A_3, MessageBoxIcon A_4)
		{
			return MessageBox.Show(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00028FF4 File Offset: 0x000271F4
		internal static object eLTx0xUTyoqVMyI4S4Q(object A_0)
		{
			return A_0.Text;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00029008 File Offset: 0x00027208
		internal static bool NSEEbmURCEx30jq7eRh(object A_0, object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00029020 File Offset: 0x00027220
		internal static void DhRoWMULf2ObRlVwpxm(object A_0, bool A_1)
		{
			A_0.Enabled = A_1;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00029038 File Offset: 0x00027238
		internal static object TImMdCUlqel3AsiYKeU(object A_0, object A_1)
		{
			return icdoeGQQtZwolxBdqe.Login(A_0, A_1);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00029050 File Offset: 0x00027250
		internal static object y0b3dSUaVghYC7Y2OZU(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00029064 File Offset: 0x00027264
		internal static void PJua3hUKbHTEo4QpKIm(object A_0)
		{
			Console.WriteLine(A_0);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00029078 File Offset: 0x00027278
		internal static object BxH1Z8UeV74m6sKFR06(object A_0)
		{
			return icdoeGQQtZwolxBdqe.xD5ivBQoQ(A_0);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0002908C File Offset: 0x0002728C
		internal static void bRIXYGUk8PjxbrsYlw3(object A_0, object A_1, object A_2, object A_3)
		{
			A_0.SetValue(A_1, A_2, A_3);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000290AC File Offset: 0x000272AC
		internal static void YxIJrgUrcWFa80bWKZS(object A_0)
		{
			A_0.Persist();
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000290C0 File Offset: 0x000272C0
		internal static void tYIOgSU7bpsZKIeXEuk(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000290D4 File Offset: 0x000272D4
		internal static object mP7F3PU2CQnPexKs3Ye(object A_0)
		{
			return Process.Start(A_0);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x000290E8 File Offset: 0x000272E8
		internal static Keys GfCKd6U6HhuZdteSSNt(object A_0)
		{
			return A_0.KeyCode;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000290FC File Offset: 0x000272FC
		internal static void PO6DtnUNJ2VUEXxfW8l(object A_0)
		{
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00029110 File Offset: 0x00027310
		internal static RuntimeTypeHandle iLmYASUnrbdcELxvlNw(int token)
		{
			return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00029124 File Offset: 0x00027324
		internal static void VW7HBxU028VrgJgrvwP(object A_0)
		{
			A_0.SuspendLayout();
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00029138 File Offset: 0x00027338
		internal static void d5LYDiUJRCro1TrXORc(object A_0)
		{
			A_0.SuspendLayout();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0002914C File Offset: 0x0002734C
		internal static void xCFjLuUmm9ObmywAkFt(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00029164 File Offset: 0x00027364
		internal static void Icu7LmUHTXZ6mOhqUbL(object A_0, object A_1)
		{
			A_0.Cursor = A_1;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0002917C File Offset: 0x0002737C
		internal static object hKmPNuUtbUpqB2W8ZDj(object A_0)
		{
			return A_0.DisabledState;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00029190 File Offset: 0x00027390
		internal static void W151ZtUYPr1U2J5yKvk(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x000291A8 File Offset: 0x000273A8
		internal static Color ccT00mUsUy7TJ3MFLQ6(int A_0, int A_1, int A_2)
		{
			return Color.FromArgb(A_0, A_1, A_2);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x000291C4 File Offset: 0x000273C4
		internal static void JVM7WkUgoKsNGBCvUsI(object A_0, Color A_1)
		{
			A_0.PlaceholderForeColor = A_1;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000291DC File Offset: 0x000273DC
		internal static void uTaAXZUXGoHrplnvrAA(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000291F4 File Offset: 0x000273F4
		internal static void FSICPWUMQ10Ai3ikM7w(object A_0, Point A_1)
		{
			A_0.Location = A_1;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0002920C File Offset: 0x0002740C
		internal static void HRPtsxUG81FtrJtuZXT(object A_0, object A_1)
		{
			A_0.Name = A_1;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00029224 File Offset: 0x00027424
		internal static void ie0IVDUBPShi9GnPGc2(object A_0, char A_1)
		{
			A_0.PasswordChar = A_1;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0002923C File Offset: 0x0002743C
		internal static void nIwxetUDEtwoxjTPXsV(object A_0, object A_1)
		{
			A_0.PlaceholderText = A_1;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00029254 File Offset: 0x00027454
		internal static void EKiK5XUvAhaeyQ7X0rU(object A_0, object A_1)
		{
			A_0.SelectedText = A_1;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0002926C File Offset: 0x0002746C
		internal static void rTb8ZAUjGchk32iTgWH(object A_0, object A_1)
		{
			A_0.TextChanged += A_1;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00029284 File Offset: 0x00027484
		internal static void zreG8mUbIMKkBUXgAhO(object A_0, object A_1)
		{
			A_0.KeyDown += A_1;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0002929C File Offset: 0x0002749C
		internal static object D5dKRZUzLWj2SGRA6XM()
		{
			return Cursors.IBeam;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000292AC File Offset: 0x000274AC
		internal static void sm1E861WXPEmwcOJMno(object A_0, object A_1)
		{
			A_0.DefaultText = A_1;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000292C4 File Offset: 0x000274C4
		internal static void M2uWMP1PYSQmcVGmjjS(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000292DC File Offset: 0x000274DC
		internal static object iYcOnS1E7vB2rXuX6EP(object A_0)
		{
			return A_0.FocusedState;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000292F0 File Offset: 0x000274F0
		internal static object DUrrqV1cwMfE7H9Dq5O(object A_0)
		{
			return A_0.HoverState;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00029304 File Offset: 0x00027504
		internal static void jqqbAf15C3Q3OHfylmH(object A_0, Size A_1)
		{
			A_0.Size = A_1;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0002931C File Offset: 0x0002751C
		internal static void bLtH6i1x8G0pLl0slGt(object A_0, int A_1)
		{
			A_0.TabIndex = A_1;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00029334 File Offset: 0x00027534
		internal static void R9Udsd1uMycLLATJwUx(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0002934C File Offset: 0x0002754C
		internal static object mV38ms1VbYQNFeUpvVX(object A_0)
		{
			return A_0.DisabledState;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00029360 File Offset: 0x00027560
		internal static Color GPqAJ21yE1OKZhm7kc0()
		{
			return Color.DarkGray;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00029370 File Offset: 0x00027570
		internal static void UiTLgm18xl9aGmX7utx(object A_0, Color A_1)
		{
			A_0.CustomBorderColor = A_1;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00029388 File Offset: 0x00027588
		internal static void K5hUd01q7KiHxZFQsu0(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000293A0 File Offset: 0x000275A0
		internal static void xa8wVW1dR2tCekR6Qka(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000293B8 File Offset: 0x000275B8
		internal static void LEffyH1o2LjYfejP1ER(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000293D0 File Offset: 0x000275D0
		internal static void HryO4P13gbySQ2kXBSe(object A_0, object A_1)
		{
			A_0.Text = A_1;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000293E8 File Offset: 0x000275E8
		internal static void DfS0WN1QdruKWGSlf46(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00029400 File Offset: 0x00027600
		internal static void xkVH2Q1C0KEhshSetH4(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00029418 File Offset: 0x00027618
		internal static void NKAskP19TnT2S7Vmi6R(object A_0, Color A_1)
		{
			A_0.FillColor2 = A_1;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00029430 File Offset: 0x00027630
		internal static Color jovJTt1wC8qQ2EsSw8I()
		{
			return Color.Gray;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00029440 File Offset: 0x00027640
		internal static void b6i7YJ1ADj1BlniQtKw(object A_0, Color A_1)
		{
			A_0.FillColor2 = A_1;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00029458 File Offset: 0x00027658
		internal static Color d4wJAD1hIEImjIZKZJZ()
		{
			return Color.White;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00029468 File Offset: 0x00027668
		internal static void MlFaXY1SMNxETYeFkI8(object A_0, object A_1)
		{
			A_0.Click += A_1;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00029480 File Offset: 0x00027680
		internal static void Yl8yg41IK1fwomh4y5Z(object A_0, bool A_1)
		{
			A_0.AnimateWindow = A_1;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00029498 File Offset: 0x00027698
		internal static void mSfWtC1isbJslVTJjmx(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000294B0 File Offset: 0x000276B0
		internal static void t1CDfT1ZklrFj2cSJpM(object A_0, object A_1)
		{
			A_0.ContainerControl = A_1;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000294C8 File Offset: 0x000276C8
		internal static void PyO8gc1UbHSiXHDbDTC(object A_0, double A_1)
		{
			A_0.DockIndicatorTransparencyValue = A_1;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000294E0 File Offset: 0x000276E0
		internal static void eil1WS11FJcRlh7bo9t(object A_0, bool A_1)
		{
			A_0.ResizeForm = A_1;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000294F8 File Offset: 0x000276F8
		internal static void qmMXPd1pCOY1QTwPXAZ(object A_0, bool A_1)
		{
			A_0.TransparentWhileDrag = A_1;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00029510 File Offset: 0x00027710
		internal static void am5WOo14tYD0TiGZ38o(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00029528 File Offset: 0x00027728
		internal static object NOKh6m1Olsjmp8Xwitn(object A_0)
		{
			return A_0.Controls;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0002953C File Offset: 0x0002773C
		internal static void nkvgXy1fENwk96syEER(object A_0, object A_1)
		{
			A_0.Add(A_1);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00029554 File Offset: 0x00027754
		internal static void rQZcfS1FeTibHnx0KKi(object A_0, DockStyle A_1)
		{
			A_0.Dock = A_1;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0002956C File Offset: 0x0002776C
		internal static void cryaY21THecEXcTc7fL(object A_0, Color A_1)
		{
			A_0.FillColor2 = A_1;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00029584 File Offset: 0x00027784
		internal static void gVEGcy1R7WIIgVTSLH4(object A_0, LinearGradientMode A_1)
		{
			A_0.GradientMode = A_1;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0002959C File Offset: 0x0002779C
		internal static void K3SKTo1LQW0uZQlcrW2(object A_0, Padding A_1)
		{
			A_0.Margin = A_1;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000295B4 File Offset: 0x000277B4
		internal static void jjGktQ1lMB8jjPQTbmQ(object A_0, bool A_1)
		{
			A_0.Animated = A_1;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000295CC File Offset: 0x000277CC
		internal static Color nN71eS1axwJHbfYrOtx()
		{
			return Color.Transparent;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000295DC File Offset: 0x000277DC
		internal static void toLyOq1KdaG9k2htxnT(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000295F4 File Offset: 0x000277F4
		internal static void jULRxh1e7ykYJthhH0T(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0002960C File Offset: 0x0002780C
		internal static void ONFfKA1k3bWmRnffPji(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00029624 File Offset: 0x00027824
		internal static void DAgmBU1rnkVM73sgRif(object A_0, Color A_1)
		{
			A_0.IconColor = A_1;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0002963C File Offset: 0x0002783C
		internal static void uEyK0Q17R0BlJQhZHmS(object A_0, bool A_1)
		{
			A_0.Enabled = A_1;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00029654 File Offset: 0x00027854
		internal static object hKYVjv121qLesdrWdT0(object A_0)
		{
			return A_0.ShadowDecoration;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00029668 File Offset: 0x00027868
		internal static void yBPWk216MdFKv0nY8dI(object A_0, Padding A_1)
		{
			A_0.Shadow = A_1;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00029680 File Offset: 0x00027880
		internal static void G8MpRn1NSP1vbaYMnjS(object A_0, bool A_1)
		{
			A_0.UseTransparentBackground = A_1;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00029698 File Offset: 0x00027898
		internal static void DQ0s1C1njOGGnubG9pt(object A_0, Color A_1)
		{
			A_0.BackColor = A_1;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000296B0 File Offset: 0x000278B0
		internal static object xJ8LlP103bU0XlalBr3(object A_0, object A_1)
		{
			return A_0.GetObject(A_1);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x000296C8 File Offset: 0x000278C8
		internal static void DAU7VG1JjByru9Asypy(object A_0, int A_1)
		{
			A_0.TabIndex = A_1;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x000296E0 File Offset: 0x000278E0
		internal static void dx19EW1mYdHFYYj5AHE(object A_0, bool A_1)
		{
			A_0.TabStop = A_1;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x000296F8 File Offset: 0x000278F8
		internal static void SeeIwc1HVGcBYgfQGE2(object A_0, bool A_1)
		{
			A_0.UseTransparentBackground = A_1;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00029710 File Offset: 0x00027910
		internal static void asupEo1t9rZ10vsa5mn(object A_0, double A_1)
		{
			A_0.DockIndicatorTransparencyValue = A_1;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00029728 File Offset: 0x00027928
		internal static void a0fCmD1Y2ra37sRgeen(object A_0, bool A_1)
		{
			A_0.UseTransparentDrag = A_1;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00029740 File Offset: 0x00027940
		internal static void Mpkj0E1sTCiQxHLiIh4(object A_0, SizeF A_1)
		{
			A_0.AutoScaleDimensions = A_1;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00029758 File Offset: 0x00027958
		internal static object fv0XEF1gPluTQaUxauT(object A_0)
		{
			return A_0.Controls;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0002976C File Offset: 0x0002796C
		internal static void QYxSIb1XvcCYRsHohqG(object A_0, FormBorderStyle A_1)
		{
			A_0.FormBorderStyle = A_1;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00029784 File Offset: 0x00027984
		internal static void oECdLj1MviqCZZpJBrS(object A_0, bool A_1)
		{
			A_0.MaximizeBox = A_1;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0002979C File Offset: 0x0002799C
		internal static void OgPZSb1GtFE8kRv8m9J(object A_0, bool A_1)
		{
			A_0.MinimizeBox = A_1;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000297B4 File Offset: 0x000279B4
		internal static void g15HY11BhD48TIuIkfy(object A_0, bool A_1)
		{
			A_0.ShowIcon = A_1;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x000297CC File Offset: 0x000279CC
		internal static void URNbPX1DHV5o4g780Pl(object A_0, FormStartPosition A_1)
		{
			A_0.StartPosition = A_1;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000297E4 File Offset: 0x000279E4
		internal static void MVw0fC1vc1ACY9d0Ndk(object A_0, bool A_1)
		{
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000297FC File Offset: 0x000279FC
		internal static void pr3QoL1jhy9OfDatiGC(object A_0)
		{
			((ISupportInitialize)A_0).EndInit();
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00029810 File Offset: 0x00027A10
		internal static void Ic6go31bXYTOaRgiXVJ(object A_0, bool A_1)
		{
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00029828 File Offset: 0x00027A28
		internal static void nufxec1znnMnPU86P90()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x040001AF RID: 431
		private Guna2TextBox txtUsername;

		// Token: 0x040001B0 RID: 432
		private Guna2TextBox textPassword;

		// Token: 0x040001B1 RID: 433
		private Guna2GradientButton guna2GradientButton1;

		// Token: 0x040001B2 RID: 434
		private Guna2GradientButton guna2GradientButton2;

		// Token: 0x040001B3 RID: 435
		private Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x040001B4 RID: 436
		private Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x040001B5 RID: 437
		private Guna2ControlBox guna2ControlBox1;

		// Token: 0x040001B6 RID: 438
		private Guna2PictureBox guna2PictureBox1;

		// Token: 0x040001B7 RID: 439
		private Guna2DragControl guna2DragControl1;

		// Token: 0x040001B8 RID: 440
		private Guna2DragControl guna2DragControl2;

		// Token: 0x040001B9 RID: 441
		internal static FormLogin HnOCB9UpVjmQm8oY9Bq;
	}
}
