using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MyU9Ep58ZH3s5ThDFJQ;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x02000048 RID: 72
	public class RotationLab
	{
		// Token: 0x0600071F RID: 1823
		[DllImport("gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "BitBlt", ExactSpelling = true, SetLastError = true)]
		private static extern int QUhcRNgNQQ(IntPtr \u0020, int \u0020, int \u0020, int \u0020, int \u0020, IntPtr \u0020, int \u0020, int \u0020, int \u0020);

		// Token: 0x06000720 RID: 1824 RVA: 0x000350BC File Offset: 0x000332BC
		public void _SetCheckPixels(int R, int G, int B)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.CheckR = R;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				}
				this.CheckB = B;
				this.CheckG = G;
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00035140 File Offset: 0x00033340
		private int T9ScL73g8k(Color \u0020)
		{
			return 65536 * (int)\u0020.R + 256 * (int)\u0020.G + (int)\u0020.B;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00035168 File Offset: 0x00033368
		private bool ji3clPYm2y(int \u0020)
		{
			return \u0020 == 255;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00035174 File Offset: 0x00033374
		private bool Gytca2Eyra()
		{
			bool result;
			try
			{
				int num = 700;
				int num2 = 48;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 != 0)
				{
					num2 = 47;
				}
				int num4;
				Color color;
				Color u2;
				string text;
				int num21;
				for (;;)
				{
					int num3;
					int num5;
					Color color2;
					int num6;
					int num8;
					Bitmap bitmap;
					int num9;
					int num10;
					int num11;
					Color color3;
					BuffsDebuffs buffsDebuffs;
					Dictionary<string, UnitInformation> dictionary;
					int num12;
					Color u3;
					int num13;
					int r;
					bool flag;
					Dictionary<int, SpellInformation> dictionary2;
					int num14;
					Color u4;
					int num15;
					Dictionary<int, ItemInformation> dictionary3;
					int num16;
					bool flag2;
					int num17;
					bool flag3;
					BuffsDebuffs buffsDebuffs2;
					int num18;
					int num19;
					int b;
					Color u5;
					int num20;
					Color u6;
					int num22;
					int u8;
					int num27;
					int g;
					int num28;
					Color u9;
					Color u10;
					switch (num2)
					{
					case 0:
						goto IL_18CE;
					case 1:
						goto IL_7E0;
					case 2:
						num3 = 0;
						num2 = 267;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 == 0)
						{
							num2 = 68;
							continue;
						}
						continue;
					case 3:
						goto IL_14F4;
					case 4:
						num3 = 0;
						num2 = 26;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af == 0)
						{
							num2 = 27;
							continue;
						}
						continue;
					case 5:
						if (num4 + 1 == (int)color.G)
						{
							num2 = 23;
							continue;
						}
						goto IL_21B1;
					case 6:
						goto IL_2703;
					case 7:
						num5 = 0;
						num2 = 37;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 == 0)
						{
							num2 = 38;
							continue;
						}
						continue;
					case 8:
						RotationLab.ybwkVIOgbYM3M2pKHMO(this.CR, RotationLab.hyOVLrOXaO40SpKFcFP(RotationLab.MHhyiHOtXqhFeE532tB(1654110737 ^ -473083753 ^ -2124765934), this.CR._InGameToggleList[num4]));
						num2 = 350;
						continue;
					case 9:
						this.CR._PlayerRuneType[2] = (int)color2.B;
						num6 = 424;
						break;
					case 10:
					{
						int num7;
						if (num7 != 1)
						{
							num2 = 313;
							continue;
						}
						goto IL_3535;
					}
					case 11:
						num8 = 0;
						num2 = 307;
						continue;
					case 12:
						goto IL_2F73;
					case 13:
						goto IL_24B9;
					case 14:
						goto IL_31BD;
					case 15:
					{
						Color pixel = bitmap.GetPixel(num9 + 1, 0);
						Color u;
						this.CR._PlayerPower[num10] = this.T9ScL73g8k(u);
						num2 = 226;
						continue;
					}
					case 16:
						if (num11 <= 0)
						{
							goto IL_3B09;
						}
						num2 = 283;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
						{
							num2 = 370;
							continue;
						}
						continue;
					case 17:
						goto IL_2ABD;
					case 18:
						goto IL_3282;
					case 19:
						goto IL_AB0;
					case 20:
						color3 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, 15, 0);
						num2 = 293;
						continue;
					case 21:
						goto IL_E2D;
					case 22:
						buffsDebuffs.Stacks = (int)u2.G;
						if (!dictionary[text].Debuffs.ContainsKey(this.CR._DebuffList[buffsDebuffs.Index]))
						{
							goto IL_10CA;
						}
						num2 = 437;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 != 0)
						{
							num2 = 252;
							continue;
						}
						continue;
					case 23:
						if (RotationLab.ba0qyZOH9EcifSiyJwt(this.CR._InGameToggleList) <= num4)
						{
							num2 = 369;
							continue;
						}
						goto IL_323C;
					case 24:
						goto IL_30BE;
					case 25:
						RotationLab.nN4dlcOjRD0DnIoUbPk(this.CR.GlyphList);
						num2 = 18;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_912464c7521643f2968751cbbc64f3cf == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 26:
						num12 = 0;
						num6 = 299;
						break;
					case 27:
						goto IL_2A26;
					case 28:
						num3 = 0;
						num2 = 319;
						continue;
					case 29:
						goto IL_348A;
					case 30:
						goto IL_346E;
					case 31:
					{
						List<SpellCast> spellCastHistory = this.CR.SpellCastHistory;
						int index = 0;
						SpellCast spellCast = new SpellCast();
						spellCast.SpellId = num11;
						DateTimeOffset dateTimeOffset = RotationLab.nTPRdGO0vwiYH4yBXcT();
						spellCast.Timestamp = dateTimeOffset.ToUnixTimeMilliseconds();
						spellCastHistory.Insert(index, spellCast);
						if (RotationLab.SgXMFrOJuydnwEmfCMt(this.CR.SpellCastHistory) > 100)
						{
							RotationLab.Mq77IGOmag33RGpudiJ(this.CR.SpellCastHistory, RotationLab.SgXMFrOJuydnwEmfCMt(this.CR.SpellCastHistory) - 1);
							num2 = 345;
							continue;
						}
						goto IL_3B09;
					}
					case 32:
						goto IL_14F4;
					case 33:
						goto IL_348A;
					case 34:
						this.CR.TargetCreatureType = (int)u3.B;
						num2 = 68;
						continue;
					case 35:
						if ((int)color3.R == this.CheckR)
						{
							num2 = 237;
							continue;
						}
						goto IL_3709;
					case 36:
						if (u2.B != 140)
						{
							goto IL_3FDA;
						}
						num2 = 326;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 == 0)
						{
							num2 = 366;
							continue;
						}
						continue;
					case 37:
						goto IL_1719;
					case 38:
						num13 = 0;
						num2 = 204;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_912464c7521643f2968751cbbc64f3cf != 0)
						{
							num2 = 47;
							continue;
						}
						continue;
					case 39:
						goto IL_1A41;
					case 40:
						r = (int)u2.R;
						num2 = 432;
						continue;
					case 41:
						buffsDebuffs.Index = num5 - 1;
						num2 = 160;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
						{
							num2 = 127;
							continue;
						}
						continue;
					case 42:
						flag = false;
						num2 = 402;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_912464c7521643f2968751cbbc64f3cf != 0)
						{
							num2 = 77;
							continue;
						}
						continue;
					case 43:
						goto IL_3203;
					case 44:
						goto IL_891;
					case 45:
						goto IL_3282;
					case 46:
						dictionary2 = new Dictionary<int, SpellInformation>();
						num2 = 62;
						continue;
					case 47:
						goto IL_2682;
					case 48:
						if (RotationLab.h3bR2nOeoSINbIeDGtm(this.CR))
						{
							num2 = 151;
							continue;
						}
						goto IL_16D3;
					case 49:
						goto IL_1D81;
					case 50:
						goto IL_419C;
					case 51:
						this.CR.PlayerHasOneHand = this.ji3clPYm2y((int)u3.B);
						num2 = 304;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 != 0)
						{
							num2 = 112;
							continue;
						}
						continue;
					case 52:
					{
						Graphics graphics = RotationLab.RQAK4OOrfZieTkW4BBS(bitmap);
						num6 = 273;
						break;
					}
					case 53:
						goto IL_1EAC;
					case 54:
						goto IL_3B09;
					case 55:
						switch (num14)
						{
						case 40:
							goto IL_1F3C;
						case 41:
							this.CR.FireTotemTimeRemaining = this.T9ScL73g8k(u4);
							num2 = 6;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
							{
								num2 = 33;
								continue;
							}
							continue;
						case 42:
							goto IL_76F;
						case 43:
							goto IL_103E;
						case 44:
							goto IL_3741;
						case 45:
							this.CR.EarthTotemTimeElasped = this.T9ScL73g8k(u4);
							num2 = 155;
							continue;
						case 46:
							goto IL_16EC;
						case 47:
							goto IL_3C4C;
						case 48:
							goto IL_2060;
						case 49:
							goto IL_16A6;
						case 50:
							goto IL_2743;
						case 51:
							goto IL_3E94;
						default:
							num2 = 37;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 != 0)
							{
								num2 = 70;
								continue;
							}
							continue;
						}
						break;
					case 56:
						goto IL_2A26;
					case 57:
						num15 = 64;
						num2 = 427;
						continue;
					case 58:
						goto IL_323C;
					case 59:
						dictionary[text].UnitIsMouseover = this.ji3clPYm2y((int)u2.B);
						goto IL_2A26;
					case 60:
						goto IL_710;
					case 61:
						if ((int)u2.G <= RotationLab.SgtbJDOvuGP5yrNSsj7(this.CR._ItemList))
						{
							num12 = this.CR._ItemList[(int)(u2.G - 1)];
							num2 = 184;
							continue;
						}
						goto IL_34CA;
					case 62:
						dictionary3 = new Dictionary<int, ItemInformation>();
						num6 = 28;
						break;
					case 63:
						goto IL_2A26;
					case 64:
						goto IL_125D;
					case 65:
						if (color.R == 200)
						{
							num2 = 5;
							continue;
						}
						goto IL_21B1;
					case 66:
						goto IL_36B7;
					case 67:
						num16 = 0;
						goto IL_14F4;
					case 68:
						goto IL_3B09;
					case 69:
						goto IL_302D;
					case 70:
						goto IL_348A;
					case 71:
						if (this.CR._ToggleOptionEnabled[num4] != flag2)
						{
							num2 = 338;
							continue;
						}
						goto IL_E4D;
					case 72:
						goto IL_1A41;
					case 73:
						this.CR._PlayerRuneType[5] = (int)color2.B;
						num2 = 13;
						continue;
					case 74:
						goto IL_3E94;
					case 75:
						goto IL_2C7C;
					case 76:
						if (num17 != 62)
						{
							num2 = 295;
							continue;
						}
						goto IL_12BE;
					case 77:
						goto IL_3B09;
					case 78:
						goto IL_300A;
					case 79:
						dictionary2[num16].ChargeMax = (int)u2.G;
						num2 = 3;
						continue;
					case 80:
						goto IL_17C9;
					case 81:
						goto IL_348A;
					case 82:
						if (u2.G <= 0)
						{
							goto IL_96E;
						}
						num2 = 293;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
						{
							num2 = 348;
							continue;
						}
						continue;
					case 83:
						result = true;
						num2 = 26;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
						{
							num2 = 85;
							continue;
						}
						continue;
					case 84:
						flag3 = false;
						num2 = 99;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 == 0)
						{
							num2 = 96;
							continue;
						}
						continue;
					case 85:
						goto IL_42C3;
					case 86:
						goto IL_3B09;
					case 87:
						goto IL_E4D;
					case 88:
						goto IL_2CF5;
					case 89:
						goto IL_3CAF;
					case 90:
						goto IL_2CB8;
					case 91:
						goto IL_14F4;
					case 92:
						dictionary[text].PowerTypeIndex = (int)u2.B;
						goto IL_2A26;
					case 93:
						this.CR._PlayerRuneType[1] = (int)color2.G;
						num2 = 9;
						continue;
					case 94:
						if (u2.B != 68)
						{
							goto IL_34F4;
						}
						num6 = 162;
						break;
					case 95:
						this.CR._SpellInfo = dictionary2;
						this.CR._ItemInfo = dictionary3;
						num2 = 54;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 != 0)
						{
							num2 = 83;
							continue;
						}
						continue;
					case 96:
						this.CR.PlayerRaceId = (int)u3.G;
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
						{
							num2 = 154;
							continue;
						}
						continue;
					case 97:
						dictionary[text].Buffs[this.CR._BuffList[buffsDebuffs2.Index]] = buffsDebuffs2;
						num2 = 85;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
						{
							num2 = 344;
							continue;
						}
						continue;
					case 98:
						this.CR.PlayerIsOutdoor = this.ji3clPYm2y((int)u3.G);
						num2 = 144;
						continue;
					case 99:
						flag = false;
						num6 = 325;
						break;
					case 100:
						this.CR.PlayerTankingStatus = (int)u3.G;
						num2 = 232;
						continue;
					case 101:
						if (this._PixelLocation == 1)
						{
							num2 = 353;
							continue;
						}
						goto IL_309F;
					case 102:
						goto IL_236B;
					case 103:
						goto IL_1B57;
					case 104:
						goto IL_CC1;
					case 105:
						goto IL_220C;
					case 106:
						if ((int)color3.B != this.CheckB)
						{
							num2 = 138;
							continue;
						}
						goto IL_11E7;
					case 107:
						goto IL_151C;
					case 108:
						goto IL_1A41;
					case 109:
						goto IL_3282;
					case 110:
						goto IL_2591;
					case 111:
						goto IL_348A;
					case 112:
						goto IL_3FFB;
					case 113:
						goto IL_ACD;
					case 114:
						goto IL_31E6;
					case 115:
						goto IL_24B9;
					case 116:
						num18 = 16;
						num2 = 423;
						continue;
					case 117:
						goto IL_B7C;
					case 118:
						goto IL_348A;
					case 119:
						goto IL_3B09;
					case 120:
						goto IL_13E2;
					case 121:
						if (u2.B != 168)
						{
							goto IL_2CA6;
						}
						if (u2.G <= 0)
						{
							goto Block_163;
						}
						goto IL_20FB;
					case 122:
						num19 = 2;
						num2 = 415;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 != 0)
						{
							num2 = 381;
							continue;
						}
						continue;
					case 123:
						goto IL_4285;
					case 124:
						goto IL_17F2;
					case 125:
						goto IL_DEB;
					case 126:
						num13 = 0;
						num2 = 287;
						continue;
					case 127:
						goto IL_2840;
					case 128:
						goto IL_2A26;
					case 129:
					{
						Color u = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num9, 0);
						num6 = 15;
						break;
					}
					case 130:
						goto IL_2A26;
					case 131:
						goto IL_2663;
					case 132:
						goto IL_348A;
					case 133:
						goto IL_17F2;
					case 134:
						goto IL_2A26;
					case 135:
						dictionary[text].CurrentCastIsChannelling = this.ji3clPYm2y((int)u2.G);
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 == 0)
						{
							num2 = 59;
							continue;
						}
						continue;
					case 136:
						goto IL_3B09;
					case 137:
						goto IL_93B;
					case 138:
						goto IL_3709;
					case 139:
						goto IL_1946;
					case 140:
						goto IL_3D8F;
					case 141:
						goto IL_117A;
					case 142:
						goto IL_38B4;
					case 143:
						goto IL_3B09;
					case 144:
						this.CR.PlayerIsInRaid = this.ji3clPYm2y((int)u3.B);
						num2 = 376;
						continue;
					case 145:
						dictionary[text].UnitIsTarget = this.ji3clPYm2y((int)u2.B);
						num6 = 220;
						break;
					case 146:
						dictionary2.Add(num16, new SpellInformation());
						num6 = 190;
						break;
					case 147:
						goto IL_2DFE;
					case 148:
					{
						DateTimeOffset dateTimeOffset = RotationLab.nTPRdGO0vwiYH4yBXcT();
						num2 = 280;
						continue;
					}
					case 149:
						if (u2.B == 132)
						{
							num2 = 358;
							continue;
						}
						goto IL_2851;
					case 150:
						dictionary[text] = new UnitInformation();
						num2 = 4;
						continue;
					case 151:
						num = 1150;
						num2 = 386;
						continue;
					case 152:
						goto IL_B64;
					case 153:
						goto IL_14F4;
					case 154:
						this.CR.PlayerIsInVehicle = this.ji3clPYm2y((int)u3.B);
						num2 = 211;
						continue;
					case 155:
						goto IL_348A;
					case 156:
						goto IL_3B09;
					case 157:
						goto IL_B64;
					case 158:
						goto IL_3FDA;
					case 159:
						goto IL_2D4A;
					case 160:
						goto IL_17F2;
					case 161:
						goto IL_36D4;
					case 162:
						if (u2.G > 0)
						{
							num2 = 61;
							continue;
						}
						goto IL_34CA;
					case 163:
						goto IL_7E0;
					case 164:
						goto IL_3741;
					case 165:
						goto IL_F38;
					case 166:
					{
						bool flag4 = this.ji3clPYm2y((int)u2.B);
						num2 = 413;
						continue;
					}
					case 167:
						goto IL_14CF;
					case 168:
						dictionary[text].IsInCombat = this.ji3clPYm2y((int)u2.B);
						num2 = 326;
						continue;
					case 169:
						goto IL_348A;
					case 170:
						goto IL_3B09;
					case 171:
						dictionary[text].Debuffs[this.CR._DebuffList[buffsDebuffs.Index]] = buffsDebuffs;
						num2 = 283;
						continue;
					case 172:
						goto IL_1368;
					case 173:
					{
						Color pixel2;
						if (this.T9ScL73g8k(pixel2) == this._lastCastInGameTimestamp)
						{
							goto IL_3B09;
						}
						this._lastCastInGameTimestamp = this.T9ScL73g8k(pixel2);
						num2 = 31;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					}
					case 174:
						goto IL_72A;
					case 175:
						goto IL_3945;
					case 176:
						if (u2.G == 67)
						{
							num2 = 435;
							continue;
						}
						goto IL_2840;
					case 177:
						b = (int)color.B;
						num2 = 118;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
						{
							num2 = 249;
							continue;
						}
						continue;
					case 178:
						if (num15 == 64)
						{
							num2 = 392;
							continue;
						}
						goto IL_1CF3;
					case 179:
						goto IL_2A26;
					case 180:
						goto IL_186F;
					case 181:
						switch (num3)
						{
						case 1:
							goto IL_148F;
						case 2:
							goto IL_1E1F;
						case 3:
							goto IL_1368;
						case 4:
							goto IL_E2D;
						case 5:
							goto IL_2703;
						case 6:
							goto IL_1946;
						case 7:
							goto IL_247A;
						case 8:
							goto IL_29AC;
						case 9:
							goto IL_DEB;
						case 10:
							goto IL_2D4A;
						case 11:
							goto IL_E77;
						case 12:
							goto IL_17C9;
						case 13:
							goto IL_CF1;
						case 14:
							goto IL_11C2;
						case 15:
							goto IL_33AE;
						case 16:
							goto IL_2283;
						case 17:
							goto IL_3050;
						case 18:
							dictionary[text].PlayerClass = (int)u2.R;
							goto IL_2A26;
						default:
							num2 = 13;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
							{
								num2 = 78;
								continue;
							}
							continue;
						}
						break;
					case 182:
						this.CR.LossOfControlType = (int)u5.G;
						num2 = 239;
						continue;
					case 183:
						dictionary[text].UnitRange = (int)u2.G;
						num2 = 335;
						continue;
					case 184:
						dictionary3.Add(num12, new ItemInformation());
						dictionary3[num12].Index = (int)(u2.G - 1);
						num2 = 2;
						continue;
					case 185:
						goto IL_1CF3;
					case 186:
						goto IL_2888;
					case 187:
						goto IL_ACD;
					case 188:
						goto IL_148F;
					case 189:
						goto IL_3107;
					case 190:
						dictionary2[num16].Index = (int)(u2.G - 1);
						num2 = 397;
						continue;
					case 191:
						buffsDebuffs2.Index = num8 - 1;
						num2 = 291;
						continue;
					case 192:
						goto IL_2A26;
					case 193:
						goto IL_2851;
					case 194:
						goto IL_1A41;
					case 195:
						num20 = 52;
						num2 = 252;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 196:
						goto IL_B64;
					case 197:
						goto IL_300A;
					case 198:
						if (num13 == 2)
						{
							buffsDebuffs.SrcPlayer = this.ji3clPYm2y((int)u2.R);
							num2 = 22;
							continue;
						}
						num2 = 48;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d != 0)
						{
							num2 = 133;
							continue;
						}
						continue;
					case 199:
						goto IL_E77;
					case 200:
						goto IL_2A26;
					case 201:
						IL_1C48:
						buffsDebuffs.TimeRemaining = this.T9ScL73g8k(u2);
						num2 = 367;
						continue;
					case 202:
						dictionary[text].UnitIsPlayer = this.ji3clPYm2y((int)u2.G);
						num6 = 145;
						break;
					case 203:
						if (!(this._PreviousPriorityPixelColor == color3))
						{
							num2 = 113;
							continue;
						}
						goto IL_3D52;
					case 204:
						num16 = 0;
						num2 = 26;
						continue;
					case 205:
						if (u2.B != 88)
						{
							goto IL_312E;
						}
						num2 = 286;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
						{
							num2 = 87;
							continue;
						}
						continue;
					case 206:
						goto IL_11C2;
					case 207:
						goto IL_3CCE;
					case 208:
						goto IL_2F9C;
					case 209:
						goto IL_1D81;
					case 210:
						goto IL_26E4;
					case 211:
						goto IL_3B09;
					case 212:
						goto IL_125D;
					case 213:
						switch (num19)
						{
						case 2:
							goto IL_3D8F;
						case 3:
							goto IL_891;
						case 4:
							goto IL_31E6;
						case 5:
							this.CR.OffHandSwingTimer = this.T9ScL73g8k(u6);
							num6 = 234;
							break;
						case 6:
							goto IL_236B;
						case 7:
							goto IL_3BAF;
						case 8:
							this.CR.HunterSwingSpeed = this.T9ScL73g8k(u6);
							num6 = 39;
							break;
						case 9:
							this.CR.PlayerComboPoints = (int)u6.R;
							this.CR.CurrentGCD = (int)u6.G;
							this.CR.TotalGCD = (int)u6.B;
							num2 = 421;
							continue;
						case 10:
							goto IL_2694;
						default:
							num2 = 72;
							continue;
						}
						break;
					case 214:
						goto IL_2565;
					case 215:
						num20++;
						num2 = 19;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
						{
							num2 = 430;
							continue;
						}
						continue;
					case 216:
						if (u2.G == 167)
						{
							num2 = 149;
							continue;
						}
						goto IL_2851;
					case 217:
						dictionary[text].UnitIsFocus = this.ji3clPYm2y((int)u2.B);
						num6 = 128;
						break;
					case 218:
						this.CR.PlayerHasShield = this.ji3clPYm2y((int)u3.G);
						num2 = 51;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
						{
							num2 = 35;
							continue;
						}
						continue;
					case 219:
						goto IL_3BAF;
					case 220:
						goto IL_2A26;
					case 221:
						goto IL_3B09;
					case 222:
						goto IL_1D6E;
					case 223:
						goto IL_20FB;
					case 224:
						goto IL_2A26;
					case 225:
						dictionary[text].RaidGroupNumber = (int)u2.G;
						num2 = 118;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
						{
							num2 = 217;
							continue;
						}
						continue;
					case 226:
					{
						Color pixel;
						this.CR._PlayerPowerMax[num10] = this.T9ScL73g8k(pixel);
						num2 = 231;
						continue;
					}
					case 227:
						goto IL_348A;
					case 228:
						goto IL_3203;
					case 229:
						goto IL_2800;
					case 230:
						goto IL_74D;
					case 231:
						num9 += 2;
						num2 = 161;
						continue;
					case 232:
						this.CR.PlayerThreatPercent = (int)u3.B;
						goto IL_3B09;
					case 233:
						goto IL_36D4;
					case 234:
						goto IL_1A41;
					case 235:
						goto IL_348A;
					case 236:
						num16 = 0;
						num2 = 53;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 == 0)
						{
							num2 = 152;
							continue;
						}
						continue;
					case 237:
						if ((int)color3.G != this.CheckG)
						{
							goto IL_3709;
						}
						num2 = 37;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 != 0)
						{
							num2 = 106;
							continue;
						}
						continue;
					case 238:
						goto IL_3945;
					case 239:
						goto IL_186F;
					case 240:
					{
						RotationLab.zssL4wOki38cl9gQEMR(Screen.PrimaryScreen);
						int u7 = WindowTracker.titleBarSize + WindowTracker.GameRect.Top;
						num2 = 101;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 == 0)
						{
							num2 = 98;
							continue;
						}
						continue;
					}
					case 241:
						goto IL_3B09;
					case 242:
						goto IL_1E42;
					case 243:
						goto IL_2682;
					case 244:
						goto IL_1E42;
					case 245:
						if (u2.R != 60)
						{
							goto IL_312E;
						}
						num2 = 133;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea != 0)
						{
							num2 = 205;
							continue;
						}
						continue;
					case 246:
						goto IL_3D52;
					case 247:
						goto IL_AEF;
					case 248:
						goto IL_3535;
					case 249:
						if (this.CR._ToggleSelectIndex[num4] == b)
						{
							goto IL_710;
						}
						num6 = 361;
						break;
					case 250:
						if (u2.B == 125)
						{
							num2 = 342;
							continue;
						}
						goto IL_F67;
					case 251:
						goto IL_3E57;
					case 252:
						goto IL_F15;
					case 253:
					{
						int num7;
						num7++;
						goto IL_2A26;
					}
					case 254:
						goto IL_1E1F;
					case 255:
						goto IL_3B09;
					case 256:
						goto IL_D39;
					case 257:
						goto IL_41CE;
					case 258:
						goto IL_3203;
					case 259:
						goto IL_3B09;
					case 260:
						goto IL_76F;
					case 261:
						goto IL_14F4;
					case 262:
						goto IL_3050;
					case 263:
						goto IL_348A;
					case 264:
						if ((int)u2.G > RotationLab.ba0qyZOH9EcifSiyJwt(this.CR._UnitList))
						{
							num2 = 89;
							continue;
						}
						goto IL_3DFE;
					case 265:
						goto IL_4245;
					case 266:
						this.CR.PlayerHasPet = this.ji3clPYm2y((int)u3.B);
						num6 = 255;
						break;
					case 267:
						goto IL_B64;
					case 268:
						goto IL_201A;
					case 269:
						num4 = num21 - num22;
						num6 = 65;
						break;
					case 270:
						color3 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, 1, 0);
						num2 = 136;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 != 0)
						{
							num2 = 203;
							continue;
						}
						continue;
					case 271:
						goto IL_12BE;
					case 272:
						goto IL_3B09;
					case 273:
						try
						{
							Graphics graphics2 = RotationLab.lXJINnO76Losn8OV48H(IntPtr.Zero);
							int num23 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
							{
								num23 = 0;
							}
							switch (num23)
							{
							default:
								try
								{
									IntPtr hdc = graphics2.GetHdc();
									int num24 = 2;
									for (;;)
									{
										switch (num24)
										{
										case 1:
										{
											Graphics graphics;
											graphics.ReleaseHdc();
											RotationLab.vqyoX4O64QjtQlS76vJ(graphics2);
											num24 = 0;
											if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
											{
												num24 = 0;
												continue;
											}
											continue;
										}
										case 2:
										{
											Graphics graphics;
											int u7;
											RotationLab.QUhcRNgNQQ(RotationLab.j7uvfjO2FijJbhp9aou(graphics), 0, 0, num, 1, hdc, u8, u7, 13369376);
											num24 = 1;
											if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc != 0)
											{
												num24 = 1;
												continue;
											}
											continue;
										}
										}
										break;
									}
								}
								finally
								{
									if (graphics2 != null)
									{
										((IDisposable)graphics2).Dispose();
										int num25 = 0;
										if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a == 0)
										{
											num25 = 0;
										}
										switch (num25)
										{
										}
									}
								}
								goto IL_14CF;
							}
						}
						finally
						{
							Graphics graphics;
							if (graphics != null)
							{
								((IDisposable)graphics).Dispose();
								int num26 = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
								{
									num26 = 0;
								}
								switch (num26)
								{
								}
							}
						}
						goto IL_419C;
					case 274:
						if (u2.B == 88)
						{
							goto IL_3140;
						}
						num2 = 294;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab != 0)
						{
							num2 = 193;
							continue;
						}
						continue;
					case 275:
						dictionary2[num16].NoMana = this.ji3clPYm2y((int)u2.G);
						num2 = 195;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a == 0)
						{
							num2 = 311;
							continue;
						}
						continue;
					case 276:
						goto IL_1B57;
					case 277:
						goto IL_16A6;
					case 278:
						goto IL_103E;
					case 279:
						if (this.CR.PlayerClass != 7)
						{
							goto IL_B7C;
						}
						num2 = 321;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
						{
							num2 = 275;
							continue;
						}
						continue;
					case 280:
					{
						DateTimeOffset dateTimeOffset;
						if (dateTimeOffset.ToUnixTimeSeconds() - this._LastGlyphRead <= 5L)
						{
							num2 = 45;
							continue;
						}
						goto IL_AB0;
					}
					case 281:
						goto IL_12DC;
					case 282:
						goto IL_2A26;
					case 283:
						goto IL_346E;
					case 284:
						goto IL_1C8A;
					case 285:
						switch (num27)
						{
						case 58:
							this.CR.SpellIsTargeting = this.ji3clPYm2y((int)u5.R);
							num2 = 182;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
							{
								num2 = 25;
								continue;
							}
							continue;
						case 59:
							goto IL_7F3;
						case 60:
							goto IL_2565;
						default:
							num2 = 180;
							continue;
						}
						break;
					case 286:
						if (u2.G > 0)
						{
							goto IL_2CB8;
						}
						num2 = 155;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af == 0)
						{
							num2 = 208;
							continue;
						}
						continue;
					case 287:
						buffsDebuffs = new BuffsDebuffs();
						num2 = 41;
						continue;
					case 288:
						dictionary[text].PlayerGUID = "";
						num2 = 63;
						continue;
					case 289:
						goto IL_CF1;
					case 290:
						goto IL_20DA;
					case 291:
						goto IL_1B57;
					case 292:
						goto IL_189A;
					case 293:
						if (RotationLab.pKxnieOnohF6DXibEsK(this._PreviousStandardPixelColor, color3))
						{
							goto IL_CA4;
						}
						num2 = 50;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 != 0)
						{
							num2 = 243;
							continue;
						}
						continue;
					case 294:
						goto IL_DBC;
					case 295:
						if (num17 == 63)
						{
							goto IL_35BE;
						}
						num6 = 115;
						break;
					case 296:
						goto IL_7F3;
					case 297:
						dictionary[text].IsDead = this.ji3clPYm2y((int)u2.G);
						num2 = 408;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 == 0)
						{
							num2 = 64;
							continue;
						}
						continue;
					case 298:
						goto IL_2EAE;
					case 299:
						buffsDebuffs = new BuffsDebuffs();
						num2 = 398;
						continue;
					case 300:
						switch (num3)
						{
						case 1:
							goto IL_2F73;
						case 2:
							goto IL_3B46;
						case 3:
							goto IL_2663;
						case 4:
							goto IL_4245;
						case 5:
							goto IL_2C20;
						default:
							num2 = 153;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a != 0)
							{
								num2 = 122;
								continue;
							}
							continue;
						}
						break;
					case 301:
						goto IL_CA4;
					case 302:
						goto IL_1B57;
					case 303:
						goto IL_D1A;
					case 304:
						goto IL_3B09;
					case 305:
						goto IL_1D6E;
					case 306:
						goto IL_96E;
					case 307:
					{
						int num7 = 0;
						num2 = 7;
						continue;
					}
					case 308:
						this.CR.CurrentGroupNumber = (int)u3.G;
						num2 = 34;
						continue;
					case 309:
						goto IL_3C4C;
					case 310:
						goto IL_17F2;
					case 311:
						dictionary2[num16].IsInRange = this.ji3clPYm2y((int)u2.B);
						num2 = 394;
						continue;
					case 312:
						goto IL_2060;
					case 313:
					{
						int num7;
						if (num7 == 2)
						{
							goto IL_41CE;
						}
						num2 = 10;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 != 0)
						{
							num2 = 103;
							continue;
						}
						continue;
					}
					case 314:
						if (u2.G == 167)
						{
							num2 = 36;
							continue;
						}
						goto IL_3FDA;
					case 315:
						num21 = num22;
						num2 = 212;
						continue;
					case 316:
					{
						if (g <= 0 || g >= 25)
						{
							goto IL_2CF5;
						}
						bool flag4;
						this.CR._TalentTree[r - 1, g - 1] = flag4;
						num2 = 32;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
						{
							num2 = 43;
							continue;
						}
						continue;
					}
					case 317:
						goto IL_111C;
					case 318:
						goto IL_2A26;
					case 319:
						text = "";
						num2 = 11;
						continue;
					case 320:
						goto IL_346E;
					case 321:
						num14 = 40;
						goto IL_2EAE;
					case 322:
						buffsDebuffs2.Stacks = (int)u2.G;
						if (dictionary[text].Buffs.ContainsKey(this.CR._BuffList[buffsDebuffs2.Index]))
						{
							num2 = 439;
							continue;
						}
						goto IL_2ABD;
					case 323:
					{
						DateTimeOffset dateTimeOffset = RotationLab.nTPRdGO0vwiYH4yBXcT();
						this._LastGlyphRead = dateTimeOffset.ToUnixTimeSeconds();
						num6 = 25;
						break;
					}
					case 324:
						this.CR.ChatFocused = this.ji3clPYm2y((int)u3.B);
						num2 = 259;
						continue;
					case 325:
						num28 = 130;
						num2 = 207;
						continue;
					case 326:
						goto IL_2A26;
					case 327:
						goto IL_B4E;
					case 328:
						goto IL_BEE;
					case 329:
						goto IL_2283;
					case 330:
						goto IL_1568;
					case 331:
						this.CR.AOEUnitCount = (int)u3.G;
						this.CR.AOEMeleeUnitCount = (int)u3.B;
						num2 = 368;
						continue;
					case 332:
					{
						DateTimeOffset dateTimeOffset = RotationLab.nTPRdGO0vwiYH4yBXcT();
						this._LastTalentRead = dateTimeOffset.ToUnixTimeSeconds();
						num2 = 228;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
						{
							num2 = 90;
							continue;
						}
						continue;
					}
					case 333:
						goto IL_1F3C;
					case 334:
						goto IL_2743;
					case 335:
						dictionary[text].Level = (int)u2.B;
						num6 = 56;
						break;
					case 336:
						goto IL_309F;
					case 337:
						num28++;
						num2 = 346;
						continue;
					case 338:
						if (flag2)
						{
							num2 = 2;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae != 0)
							{
								num2 = 8;
								continue;
							}
							continue;
						}
						else
						{
							this.CR.WriteLog(string.Format(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--2124070285 ^ 2124083771), this.CR._InGameToggleList[num4]));
							num2 = 87;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
							{
								num2 = 58;
								continue;
							}
							continue;
						}
						break;
					case 339:
						goto IL_186F;
					case 340:
						goto IL_318A;
					case 341:
						goto IL_35BE;
					case 342:
						if (u2.G > 0)
						{
							num2 = 264;
							continue;
						}
						goto IL_F38;
					case 343:
						this.CR.PlayerIsMounted = this.ji3clPYm2y((int)u3.G);
						num2 = 266;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 != 0)
						{
							num2 = 31;
							continue;
						}
						continue;
					case 344:
						goto IL_222C;
					case 345:
						goto IL_3B09;
					case 346:
						goto IL_3CCE;
					case 347:
						switch (num18)
						{
						case 16:
							goto IL_3A54;
						case 17:
							goto IL_1C8A;
						case 18:
							this.CR.LastNotBehindTargetTime = this.T9ScL73g8k(u3);
							num2 = 170;
							continue;
						case 19:
							goto IL_36B7;
						case 20:
							goto IL_3B09;
						case 21:
							goto IL_1568;
						case 22:
							goto IL_111C;
						case 23:
							goto IL_3BFB;
						case 24:
							this.CR.PlayerIsInGroup = this.ji3clPYm2y((int)u3.R);
							num2 = 100;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d != 0)
							{
								num2 = 343;
								continue;
							}
							continue;
						case 25:
							goto IL_2EC1;
						case 26:
							goto IL_93B;
						case 27:
							goto IL_9B6;
						case 28:
							goto IL_2DFE;
						case 29:
							goto IL_1230;
						case 30:
							goto IL_74D;
						case 31:
							goto IL_2E63;
						case 32:
							goto IL_1DC1;
						case 33:
							goto IL_41EC;
						case 34:
							goto IL_3FFB;
						case 35:
							goto IL_151C;
						case 36:
							goto IL_2608;
						case 37:
							goto IL_2591;
						case 38:
							goto IL_D4F;
						case 39:
							goto IL_1EF1;
						default:
							num2 = 221;
							continue;
						}
						break;
					case 348:
						if ((int)u2.G > RotationLab.ba0qyZOH9EcifSiyJwt(this.CR._UnitList))
						{
							goto IL_96E;
						}
						text = this.CR._UnitList[(int)(u2.G - 1)];
						num2 = 141;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 == 0)
						{
							num2 = 150;
							continue;
						}
						continue;
					case 349:
						goto IL_2800;
					case 350:
						goto IL_E4D;
					case 351:
						if (num3 == 2)
						{
							goto IL_ED2;
						}
						num2 = 362;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e != 0)
						{
							num2 = 360;
							continue;
						}
						continue;
					case 352:
						goto IL_105B;
					case 353:
					{
						int u7 = WindowTracker.GameRect.Bottom - 1 - WindowTracker.borderSize;
						num2 = 336;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 != 0)
						{
							num2 = 197;
							continue;
						}
						continue;
					}
					case 354:
						goto IL_1DC1;
					case 355:
						goto IL_B4E;
					case 356:
						goto IL_2A26;
					case 357:
					{
						DateTimeOffset dateTimeOffset;
						if (dateTimeOffset.ToUnixTimeSeconds() - this._LastTalentRead <= 5L)
						{
							goto IL_3203;
						}
						flag3 = true;
						num2 = 199;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
						{
							num2 = 332;
							continue;
						}
						continue;
					}
					case 358:
					{
						DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
						num2 = 357;
						continue;
					}
					case 359:
						goto IL_21B1;
					case 360:
						if (u2.B != 88)
						{
							goto IL_10A8;
						}
						if (u2.G <= 0)
						{
							num2 = 142;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 != 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						else
						{
							if ((int)u2.G <= this.CR._DebuffList.Count)
							{
								goto IL_1802;
							}
							num2 = 292;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
							{
								num2 = 273;
								continue;
							}
							continue;
						}
						break;
					case 361:
						RotationLab.ybwkVIOgbYM3M2pKHMO(this.CR, string.Format(RotationLab.MHhyiHOtXqhFeE532tB(1386050510 + 11679858 ^ 1397744440), RotationLab.EmpaWJOsrmYuBnmdnWH(this.CR, num4, b)));
						num2 = 60;
						continue;
					case 362:
						goto IL_B64;
					case 363:
						goto IL_2EC1;
					case 364:
						goto IL_2C20;
					case 365:
						if (u2.G == 67)
						{
							num2 = 375;
							continue;
						}
						goto IL_D1A;
					case 366:
						flag3 = false;
						goto IL_3203;
					case 367:
						goto IL_17F2;
					case 368:
						goto IL_3B09;
					case 369:
						goto IL_20DA;
					case 370:
					{
						Color pixel2 = bitmap.GetPixel(61, 0);
						num2 = 173;
						continue;
					}
					case 371:
						goto IL_3B46;
					case 372:
						if (u2.B == 123)
						{
							num2 = 82;
							continue;
						}
						goto IL_99B;
					case 373:
						goto IL_3140;
					case 374:
						goto IL_3B09;
					case 375:
						if (u2.B == 75)
						{
							num2 = 148;
							continue;
						}
						goto IL_D1A;
					case 376:
						goto IL_3B09;
					case 377:
						this.CR._PlayerRuneType[4] = (int)color2.G;
						num2 = 73;
						continue;
					case 378:
						goto IL_9B6;
					case 379:
						dictionary[text].IsFriend = this.ji3clPYm2y((int)u2.G);
						num2 = 168;
						continue;
					case 380:
						goto IL_3661;
					case 381:
						buffsDebuffs2 = new BuffsDebuffs();
						num2 = 191;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 == 0)
						{
							num2 = 94;
							continue;
						}
						continue;
					case 382:
						if (u2.R != 58)
						{
							goto IL_99B;
						}
						num2 = 372;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 != 0)
						{
							num2 = 293;
							continue;
						}
						continue;
					case 383:
						goto IL_3282;
					case 384:
						goto IL_2E63;
					case 385:
						dictionary[text].PowerPercent = (int)u2.G;
						num2 = 92;
						continue;
					case 386:
						goto IL_16D3;
					case 387:
						goto IL_11E7;
					case 388:
						goto IL_185C;
					case 389:
						goto IL_3B09;
					case 390:
						goto IL_186F;
					case 391:
						goto IL_3BFB;
					case 392:
						this.CR.PlayerArmorPenetration = this.T9ScL73g8k(u9);
						num2 = 162;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_912464c7521643f2968751cbbc64f3cf == 0)
						{
							num2 = 185;
							continue;
						}
						continue;
					case 393:
						goto IL_3A54;
					case 394:
						goto IL_14F4;
					case 395:
						goto IL_1AE8;
					case 396:
						goto IL_2CF5;
					case 397:
						num3 = 0;
						num2 = 9;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
						{
							num2 = 32;
							continue;
						}
						continue;
					case 398:
						buffsDebuffs2 = new BuffsDebuffs();
						num2 = 82;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
						{
							num2 = 84;
							continue;
						}
						continue;
					case 399:
						goto IL_ED2;
					case 400:
						goto IL_1A41;
					case 401:
						goto IL_3B09;
					case 402:
						goto IL_3282;
					case 403:
						this.CR._PlayerRuneCD[num20 - 52] = this.T9ScL73g8k(u10);
						num2 = 215;
						continue;
					case 404:
						goto IL_2A26;
					case 405:
						goto IL_1802;
					case 406:
						goto IL_B21;
					case 407:
						IL_358F:
						dictionary3[num12].Count = (int)u2.R;
						num2 = 196;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
						{
							num2 = 160;
							continue;
						}
						continue;
					case 408:
						dictionary[text].IsTargetingPlayer = this.ji3clPYm2y((int)u2.B);
						goto IL_2A26;
					case 409:
						goto IL_29AC;
					case 410:
					{
						int num7 = 0;
						num2 = 381;
						continue;
					}
					case 411:
						goto IL_247A;
					case 412:
						goto IL_2694;
					case 413:
						if (r <= 0)
						{
							num2 = 88;
							continue;
						}
						goto IL_31BD;
					case 414:
						goto IL_1230;
					case 415:
						goto IL_1719;
					case 416:
						goto IL_3DFE;
					case 417:
						goto IL_220C;
					case 418:
						goto IL_1081;
					case 419:
						goto IL_222C;
					case 420:
						goto IL_34CA;
					case 421:
						goto IL_1A41;
					case 422:
						goto IL_1A41;
					case 423:
						goto IL_72A;
					case 424:
						goto IL_24B9;
					case 425:
						goto IL_41EC;
					case 426:
						goto IL_F67;
					case 427:
						goto IL_185C;
					case 428:
						goto IL_16EC;
					case 429:
						goto IL_13E2;
					case 430:
						goto IL_F15;
					case 431:
						goto IL_33AE;
					case 432:
						g = (int)u2.G;
						num2 = 166;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d == 0)
						{
							num2 = 104;
							continue;
						}
						continue;
					case 433:
						goto IL_2608;
					case 434:
						goto IL_1EF1;
					case 435:
						if (u2.B == 78)
						{
							num2 = 42;
							continue;
						}
						goto IL_2840;
					case 436:
						goto IL_D4F;
					case 437:
						goto IL_4285;
					case 438:
						goto IL_10CA;
					case 439:
						goto IL_117A;
					default:
						goto IL_18CE;
					}
					IL_22:
					num2 = num6;
					continue;
					IL_CF1:
					dictionary[text].IsAutoAttacking = this.ji3clPYm2y((int)u2.R);
					num6 = 202;
					goto IL_22;
					IL_710:
					this.CR._ToggleSelectIndex[num4] = b;
					num2 = 417;
					continue;
					IL_72A:
					if (num18 <= 39)
					{
						goto IL_201A;
					}
					num2 = 112;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
					{
						num2 = 279;
						continue;
					}
					continue;
					IL_74D:
					this.CR.Trinket1Usable = this.ji3clPYm2y((int)u3.R);
					num2 = 50;
					continue;
					IL_76F:
					this.CR.FireTotemTimeElasped = this.T9ScL73g8k(u4);
					num2 = 81;
					continue;
					IL_7E0:
					if (num27 > 59)
					{
						num2 = 57;
						continue;
					}
					goto IL_D39;
					IL_7F3:
					this.CR.PlayerAttackPower = this.T9ScL73g8k(u5);
					num2 = 390;
					continue;
					IL_891:
					this.CR.MainHandSwingTimer = this.T9ScL73g8k(u6);
					num2 = 400;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d == 0)
					{
						num2 = 38;
						continue;
					}
					continue;
					IL_93B:
					this.CR.PlayerHasTwoHand = this.ji3clPYm2y((int)u3.R);
					num2 = 331;
					continue;
					IL_99B:
					if (RotationLab.IyKakoOG3H8CEpRrTjf(text, ""))
					{
						num2 = 181;
						continue;
					}
					goto IL_2A26;
					IL_9B6:
					this.CR.PlayerIsTankingTarget = this.ji3clPYm2y((int)u3.R);
					num2 = 100;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d == 0)
					{
						num2 = 15;
						continue;
					}
					continue;
					IL_AB0:
					flag = true;
					num2 = 75;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
					{
						num2 = 323;
						continue;
					}
					continue;
					IL_ACD:
					this._PreviousPriorityPixelColor = color3;
					num2 = 122;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 != 0)
					{
						num2 = 101;
						continue;
					}
					continue;
					IL_AEF:
					flag2 = this.ji3clPYm2y((int)color.B);
					num2 = 71;
					continue;
					IL_323C:
					if (!RotationLab.i6qJhDOY8tEP8eDbkxS(this.CR._InGameToggleList[num4], RotationLab.MHhyiHOtXqhFeE532tB(-1897624240 ^ -1897609822)))
					{
						goto IL_AEF;
					}
					num2 = 177;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 != 0)
					{
						num2 = 130;
						continue;
					}
					continue;
					IL_3709:
					this._PixelReadFailCount++;
					if (this._PixelReadFailCount == 10)
					{
						num2 = 406;
						continue;
					}
					result = false;
					num2 = 251;
					continue;
					IL_B4E:
					u10 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num20, 0);
					num2 = 403;
					continue;
					IL_B64:
					if (u2.R == 43)
					{
						num2 = 216;
						continue;
					}
					goto IL_2851;
					IL_B7C:
					if (this.CR.PlayerClass == 6)
					{
						num2 = 195;
						continue;
					}
					goto IL_3661;
					IL_2EAE:
					if (num14 <= 51)
					{
						num2 = 49;
						continue;
					}
					goto IL_B7C;
					IL_BEE:
					num8 = (int)u2.G;
					num2 = 169;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab == 0)
					{
						num2 = 410;
						continue;
					}
					continue;
					IL_2CB8:
					if ((int)u2.G > this.CR._BuffList.Count)
					{
						goto Block_155;
					}
					goto IL_BEE;
					IL_CA4:
					result = true;
					num2 = 395;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
					{
						num2 = 71;
						continue;
					}
					continue;
					IL_CC1:
					num16 = this.CR._SpellList[(int)(u2.G - 1)];
					num2 = 146;
					continue;
					IL_20FB:
					if ((int)u2.G > RotationLab.SgtbJDOvuGP5yrNSsj7(this.CR._SpellList))
					{
						num2 = 210;
						continue;
					}
					goto IL_CC1;
					IL_D39:
					u5 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num27, 0);
					num2 = 285;
					continue;
					IL_D4F:
					this.CR.WindFuryCD = this.T9ScL73g8k(u3);
					num2 = 401;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 != 0)
					{
						num2 = 97;
						continue;
					}
					continue;
					IL_DBC:
					num3++;
					num2 = 337;
					continue;
					IL_3282:
					if (u2.R == 88 && u2.G == 88)
					{
						num2 = 274;
						continue;
					}
					goto IL_DBC;
					IL_DEB:
					dictionary[text].CurrentCastID = this.T9ScL73g8k(u2);
					num2 = 404;
					continue;
					IL_34F4:
					if (num12 <= 0)
					{
						num2 = 157;
						continue;
					}
					if (num3 == 1)
					{
						goto IL_358F;
					}
					num2 = 351;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 != 0)
					{
						num2 = 33;
						continue;
					}
					continue;
					IL_14F4:
					if (u2.R != 90)
					{
						goto IL_34F4;
					}
					num2 = 94;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e == 0)
					{
						num2 = 11;
						continue;
					}
					continue;
					IL_2CA6:
					if (num16 > 0)
					{
						num2 = 300;
						continue;
					}
					goto IL_14F4;
					IL_F67:
					if (u2.R != 82)
					{
						goto IL_2CA6;
					}
					num2 = 121;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 != 0)
					{
						num2 = 15;
						continue;
					}
					continue;
					IL_2A26:
					if (u2.R == 59)
					{
						num2 = 250;
						continue;
					}
					goto IL_F67;
					IL_300A:
					if (num28 < 19)
					{
						goto IL_2A26;
					}
					num2 = 29;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d != 0)
					{
						num2 = 245;
						continue;
					}
					continue;
					IL_E2D:
					dictionary[text].MaxPower = this.T9ScL73g8k(u2);
					num2 = 200;
					continue;
					IL_E4D:
					this.CR._ToggleOptionEnabled[num4] = flag2;
					num2 = 105;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
					{
						num2 = 38;
						continue;
					}
					continue;
					IL_E77:
					dictionary[text].CurrentCastTimeRemaining = this.T9ScL73g8k(u2);
					num2 = 134;
					continue;
					IL_ED2:
					dictionary3[num12].CooldownRemaining = this.T9ScL73g8k(u2);
					num2 = 236;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
					{
						num2 = 91;
						continue;
					}
					continue;
					IL_F15:
					if (num20 > 57)
					{
						goto IL_12DC;
					}
					num2 = 327;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
					{
						num2 = 199;
						continue;
					}
					continue;
					IL_103E:
					this.CR.EarthTotemSpellId = this.T9ScL73g8k(u4);
					num2 = 169;
					continue;
					IL_105B:
					if (!buffsDebuffs.SrcPlayer)
					{
						goto IL_346E;
					}
					num2 = 171;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
					{
						num2 = 10;
						continue;
					}
					continue;
					IL_4285:
					if (dictionary[text].Debuffs[this.CR._DebuffList[buffsDebuffs.Index]].SrcPlayer)
					{
						num2 = 320;
						continue;
					}
					goto IL_105B;
					IL_10A8:
					if (num5 <= 0)
					{
						num2 = 310;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 == 0)
						{
							num2 = 38;
							continue;
						}
						continue;
					}
					else
					{
						if (num13 != 1)
						{
							num2 = 198;
							continue;
						}
						goto IL_1C48;
					}
					IL_1B57:
					if (u2.R != 65)
					{
						goto IL_10A8;
					}
					num2 = 293;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
					{
						num2 = 360;
						continue;
					}
					continue;
					IL_312E:
					if (num8 > 0)
					{
						num2 = 10;
						continue;
					}
					goto IL_1B57;
					IL_10CA:
					dictionary[text].Debuffs.Add(this.CR._DebuffList[buffsDebuffs.Index], buffsDebuffs);
					num2 = 30;
					continue;
					IL_111C:
					this.CR.LossOfControlTimeRemaining = this.T9ScL73g8k(u3);
					num2 = 119;
					continue;
					IL_11C2:
					dictionary[text].CurrentCastInterruptible = this.ji3clPYm2y((int)u2.R);
					num2 = 135;
					continue;
					IL_11E7:
					this._PixelReadFailCount = 0;
					num2 = 159;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
					{
						num2 = 270;
						continue;
					}
					continue;
					IL_1230:
					this.CR.PlayerThreatValue = this.T9ScL73g8k(u3);
					num2 = 26;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 == 0)
					{
						num2 = 54;
						continue;
					}
					continue;
					IL_125D:
					if (num21 > num22 + 19)
					{
						goto IL_20DA;
					}
					num2 = 175;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
					{
						num2 = 130;
						continue;
					}
					continue;
					IL_12BE:
					this.CR._PlayerRuneType[0] = (int)color2.R;
					num2 = 93;
					continue;
					IL_12DC:
					num17 = 62;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_1368:
					dictionary[text].CurrentPower = this.T9ScL73g8k(u2);
					num2 = 356;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d == 0)
					{
						num2 = 78;
						continue;
					}
					continue;
					IL_13E2:
					color2 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num17, 0);
					num2 = 76;
					continue;
					IL_148F:
					dictionary[text].CurrentHP = this.T9ScL73g8k(u2) * 100;
					num2 = 130;
					continue;
					IL_14CF:
					color3 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, 0, 0);
					num2 = 35;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
					{
						num2 = 9;
						continue;
					}
					continue;
					IL_151C:
					this.CR.TargetTTD = this.T9ScL73g8k(u3);
					num2 = 86;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
					{
						num2 = 68;
						continue;
					}
					continue;
					IL_1568:
					this.CR.LossOfControlSpellId = this.T9ScL73g8k(u3);
					num2 = 136;
					continue;
					IL_16A6:
					this.CR.AirTotemSpellId = this.T9ScL73g8k(u4);
					num2 = 227;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
					{
						num2 = 100;
						continue;
					}
					continue;
					IL_16D3:
					bitmap = new Bitmap(num, 1, PixelFormat.Format32bppArgb);
					num2 = 240;
					continue;
					IL_16EC:
					this.CR.WaterTotemSpellId = this.T9ScL73g8k(u4);
					num2 = 199;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
					{
						num2 = 235;
						continue;
					}
					continue;
					IL_1719:
					if (num19 > 10)
					{
						num2 = 20;
						continue;
					}
					goto IL_2888;
					IL_17C9:
					dictionary[text].CurrentCastPercent = (int)u2.R;
					num2 = 183;
					continue;
					IL_17F2:
					num13++;
					num2 = 253;
					continue;
					IL_1802:
					num5 = (int)u2.G;
					num2 = 45;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
					{
						num2 = 126;
						continue;
					}
					continue;
					IL_185C:
					if (num15 <= 64)
					{
						num2 = 349;
						continue;
					}
					goto IL_30BE;
					IL_1946:
					dictionary[text].PlayerCanAttack = this.ji3clPYm2y((int)u2.R);
					num2 = 379;
					continue;
					IL_1A41:
					num19++;
					num2 = 37;
					continue;
					IL_3D8F:
					this.CR.PlayerClass = (int)u6.G;
					goto IL_1A41;
					IL_236B:
					this.CR.OffhandSwingSpeed = this.T9ScL73g8k(u6);
					goto IL_1A41;
					IL_1C8A:
					this.CR.LastDodgeTime = this.T9ScL73g8k(u3);
					num2 = 77;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 != 0)
					{
						num2 = 30;
						continue;
					}
					continue;
					IL_1CF3:
					num15++;
					num2 = 388;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 != 0)
					{
						num2 = 17;
						continue;
					}
					continue;
					IL_1D6E:
					num10 = (num9 - 70) / 2;
					num2 = 129;
					continue;
					IL_1D81:
					u4 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num14, 0);
					num2 = 55;
					continue;
					IL_1E1F:
					dictionary[text].MaxHP = this.T9ScL73g8k(u2) * 100;
					num2 = 318;
					continue;
					IL_1E42:
					u2 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num28, 0);
					num2 = 265;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d != 0)
					{
						num2 = 382;
						continue;
					}
					continue;
					IL_1EAC:
					num22 = 105;
					num2 = 315;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
					{
						num2 = 241;
						continue;
					}
					continue;
					IL_36D4:
					if (num9 > 70 + (this.CR._PlayerPower.Length - 1) * 2)
					{
						goto IL_1EAC;
					}
					num2 = 180;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
					{
						num2 = 305;
						continue;
					}
					continue;
					IL_1EF1:
					this.CR.PlayerSpec = (int)u3.R;
					num2 = 96;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_1F3C:
					this.CR.FireTotemSpellId = this.T9ScL73g8k(u4);
					num2 = 263;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
					{
						num2 = 105;
						continue;
					}
					continue;
					IL_201A:
					u3 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num18, 0);
					num2 = 347;
					continue;
					IL_2060:
					this.CR.WaterTotemTimeElasped = this.T9ScL73g8k(u4);
					num2 = 18;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 == 0)
					{
						num2 = 111;
						continue;
					}
					continue;
					IL_20DA:
					dictionary = new Dictionary<string, UnitInformation>();
					num2 = 17;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 != 0)
					{
						num2 = 46;
						continue;
					}
					continue;
					IL_220C:
					num21++;
					num2 = 64;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 != 0)
					{
						num2 = 24;
						continue;
					}
					continue;
					IL_222C:
					num8 = 0;
					num2 = 205;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
					{
						num2 = 276;
						continue;
					}
					continue;
					IL_117A:
					if (!dictionary[text].Buffs[this.CR._BuffList[buffsDebuffs2.Index]].SrcPlayer && buffsDebuffs2.SrcPlayer)
					{
						num6 = 97;
						goto IL_22;
					}
					goto IL_222C;
					IL_2283:
					if (!dictionary[text].UnitIsPlayer)
					{
						num2 = 288;
						continue;
					}
					dictionary[text].PlayerGUID = u2.R.ToString(RotationLab.MHhyiHOtXqhFeE532tB(-1007749927 ^ -1007757159)) + u2.G.ToString(RotationLab.MHhyiHOtXqhFeE532tB(-1218526815 ^ -1218515487)) + u2.B.ToString(RotationLab.MHhyiHOtXqhFeE532tB(-2018852357 ^ -2018841157));
					num2 = 179;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
					{
						num2 = 9;
						continue;
					}
					continue;
					IL_247A:
					dictionary[text].IsPVP = this.ji3clPYm2y((int)u2.R);
					num2 = 297;
					continue;
					IL_24B9:
					num17++;
					num2 = 69;
					continue;
					IL_2565:
					this.CR.PlayerCovenant = (int)u5.R;
					num2 = 172;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
					{
						num2 = 339;
						continue;
					}
					continue;
					IL_2591:
					this.CR.EnemyMinTTD = this.T9ScL73g8k(u3);
					num2 = 119;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 == 0)
					{
						num2 = 241;
						continue;
					}
					continue;
					IL_2608:
					this.CR.EnemyMaxTTD = this.T9ScL73g8k(u3);
					num2 = 156;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
					IL_2663:
					dictionary2[num16].ChargeCurrent = (int)u2.R;
					num2 = 79;
					continue;
					IL_2682:
					this._PreviousStandardPixelColor = color3;
					num2 = 116;
					continue;
					IL_2694:
					this.CR.MainHandSwingTimerWeakAura = this.T9ScL73g8k(u6);
					num2 = 108;
					continue;
					IL_2703:
					dictionary[text].HPPercent = (int)u2.R;
					num2 = 385;
					continue;
					IL_2743:
					this.CR.AirTotemTimeRemaining = this.T9ScL73g8k(u4);
					num2 = 29;
					continue;
					IL_2800:
					u9 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num15, 0);
					num2 = 178;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd == 0)
					{
						num2 = 155;
						continue;
					}
					continue;
					IL_2840:
					if (!flag)
					{
						num2 = 383;
						continue;
					}
					this.CR.GlyphList.Add(this.T9ScL73g8k(u2));
					num2 = 109;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 == 0)
					{
						num2 = 99;
						continue;
					}
					continue;
					IL_D1A:
					if (u2.R == 134)
					{
						num6 = 176;
						goto IL_22;
					}
					goto IL_2840;
					IL_3203:
					if (u2.R == 134)
					{
						num2 = 365;
						continue;
					}
					goto IL_D1A;
					IL_3FDA:
					if (!flag3)
					{
						goto IL_3203;
					}
					num2 = 22;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
					{
						num2 = 40;
						continue;
					}
					continue;
					IL_2851:
					if (u2.R != 43)
					{
						goto IL_3FDA;
					}
					num2 = 314;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num2 = 41;
						continue;
					}
					continue;
					IL_2888:
					u6 = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num19, 0);
					num2 = 213;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
					{
						num2 = 166;
						continue;
					}
					continue;
					IL_29AC:
					dictionary[text].NPCID = this.T9ScL73g8k(u2);
					num2 = 282;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num2 = 79;
						continue;
					}
					continue;
					IL_2ABD:
					dictionary[text].Buffs.Add(this.CR._BuffList[buffsDebuffs2.Index], buffsDebuffs2);
					num2 = 284;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
					{
						num2 = 419;
						continue;
					}
					continue;
					IL_2C20:
					dictionary2[num16].ChargeTime = this.T9ScL73g8k(u2);
					num2 = 67;
					continue;
					IL_2CF5:
					this.CR.WriteLog(string.Format(RotationLab.MHhyiHOtXqhFeE532tB(-789419076 ^ -35552607 ^ 756267977), r, g, num28));
					num2 = 258;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 != 0)
					{
						num2 = 216;
						continue;
					}
					continue;
					IL_31BD:
					if (r < 4)
					{
						num6 = 316;
						goto IL_22;
					}
					goto IL_2CF5;
					IL_2D4A:
					dictionary[text].CurrentCastElapsedDuration = this.T9ScL73g8k(u2);
					num2 = 192;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d == 0)
					{
						num2 = 47;
						continue;
					}
					continue;
					IL_2DFE:
					this.CR.PlayerRawThreatPercent = (int)u3.R;
					num2 = 308;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 != 0)
					{
						num2 = 79;
						continue;
					}
					continue;
					IL_2E63:
					this.CR.Trinket1CooldownRemaining = this.T9ScL73g8k(u3);
					num2 = 389;
					continue;
					IL_2EC1:
					this.CR.PlayerIsMoving = this.ji3clPYm2y((int)u3.R);
					num2 = 218;
					continue;
					IL_302D:
					if (num17 > 63)
					{
						goto IL_3661;
					}
					num2 = 429;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 == 0)
					{
						num2 = 337;
						continue;
					}
					continue;
					IL_18CE:
					goto IL_302D;
					IL_3050:
					dictionary[text].PlayerTimeToDie = this.T9ScL73g8k(u2);
					num2 = 224;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
					{
						num2 = 152;
						continue;
					}
					continue;
					IL_309F:
					u8 = WindowTracker.GameRect.Left + WindowTracker.borderSize + 10;
					num2 = 52;
					continue;
					IL_30BE:
					num9 = 70;
					num2 = 233;
					continue;
					IL_3140:
					this.CR._UnitInfo = dictionary;
					num2 = 95;
					continue;
					IL_3CCE:
					if (num28 <= num - 1)
					{
						num2 = 242;
						continue;
					}
					goto IL_3140;
					IL_31E6:
					this.CR.MainHandSwingSpeed = this.T9ScL73g8k(u6);
					num2 = 194;
					continue;
					IL_33AE:
					dictionary[text].IsMainTank = this.ji3clPYm2y((int)u2.R);
					num2 = 225;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
					{
						num2 = 217;
						continue;
					}
					continue;
					IL_346E:
					num5 = 0;
					num2 = 124;
					continue;
					IL_3535:
					buffsDebuffs2.TimeRemaining = this.T9ScL73g8k(u2);
					num2 = 302;
					continue;
					IL_35BE:
					this.CR._PlayerRuneType[3] = (int)color2.R;
					num2 = 65;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 == 0)
					{
						num2 = 377;
						continue;
					}
					continue;
					IL_3661:
					num27 = 58;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_36B7:
					this.CR.LastNotInLineOfSightTime = this.T9ScL73g8k(u3);
					num2 = 374;
					continue;
					IL_3945:
					color = RotationLab.souMiQONFJxvqHRk1rF(bitmap, num21, 0);
					num2 = 269;
					continue;
					IL_3A54:
					num11 = this.T9ScL73g8k(u3);
					num2 = 16;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
					{
						num2 = 16;
						continue;
					}
					continue;
					IL_3B09:
					num18++;
					num2 = 174;
					continue;
					IL_1DC1:
					this.CR.Trinket2CooldownRemaining = this.T9ScL73g8k(u3);
					goto IL_3B09;
					IL_3B46:
					dictionary2[num16].CooldownRemaining = this.T9ScL73g8k(u2);
					num2 = 261;
					continue;
					IL_3BAF:
					this.CR.HunterSwingTimer = this.T9ScL73g8k(u6);
					num2 = 422;
					continue;
					IL_3BFB:
					this.CR.PlayerForm = (int)u3.R;
					num2 = 98;
					continue;
					IL_3C4C:
					this.CR.WaterTotemTimeRemaining = this.T9ScL73g8k(u4);
					num2 = 118;
					continue;
					IL_3DFE:
					if (RotationLab.Sfj2B9OBTPJxBjPACV1(text, this.CR._UnitList[(int)(u2.G - 1)]))
					{
						text = "";
						num2 = 426;
						continue;
					}
					num2 = 313;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
					{
						num2 = 340;
						continue;
					}
					continue;
					IL_3E94:
					this.CR.AirTotemTimeElasped = this.T9ScL73g8k(u4);
					num2 = 132;
					continue;
					IL_3FFB:
					this.CR.OffHandEnchantExpiration = this.T9ScL73g8k(u3);
					num2 = 135;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 != 0)
					{
						num2 = 143;
						continue;
					}
					continue;
					IL_419C:
					this.CR.Trinket2Usable = this.ji3clPYm2y((int)u3.G);
					num2 = 105;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
					{
						num2 = 324;
						continue;
					}
					continue;
					IL_41CE:
					buffsDebuffs2.SrcPlayer = this.ji3clPYm2y((int)u2.R);
					num2 = 322;
					continue;
					IL_41EC:
					this.CR.MainHandEnchantExpiration = this.T9ScL73g8k(u3);
					num2 = 272;
					continue;
					IL_4245:
					dictionary2[num16].ChargeCooldownRemaining = this.T9ScL73g8k(u2);
					num2 = 57;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
					{
						num2 = 91;
						continue;
					}
					continue;
					IL_186F:
					num27++;
					num6 = 163;
					goto IL_22;
					IL_2F73:
					dictionary2[num16].Usable = this.ji3clPYm2y((int)u2.R);
					num6 = 275;
					goto IL_22;
					IL_348A:
					num14++;
					num6 = 298;
					goto IL_22;
					IL_3741:
					this.CR.EarthTotemTimeRemaining = this.T9ScL73g8k(u4);
					goto IL_348A;
				}
				IL_96E:
				throw new Exception(RotationLab.hyOVLrOXaO40SpKFcFP(RotationLab.MHhyiHOtXqhFeE532tB(-160910942 << 4 ^ 1720404598), u2.G));
				IL_B21:
				throw new Exception(string.Format(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(326177456 ^ 326197062), Array.Empty<object>()));
				IL_F38:
				throw new Exception(RotationLab.yXOG9hOD9CsPLqyWqNv(RotationLab.MHhyiHOtXqhFeE532tB(1881006439 >> 3 ^ 235138390), text, u2.G));
				IL_1081:
				throw new Exception(string.Format(RotationLab.MHhyiHOtXqhFeE532tB(-1199763274 ^ -1199750752), u2.G));
				IL_189A:
				goto IL_1081;
				IL_1AE8:
				return result;
				IL_21B1:
				throw new Exception(RotationLab.Own7isOMGIUYXHTLq2V(RotationLab.MHhyiHOtXqhFeE532tB(-1406908615 ^ 676245432 ^ -2073385125), new object[]
				{
					num21,
					color.G,
					num4 + 1,
					color.R
				}));
				IL_26E4:
				IL_2C7C:
				throw new Exception(RotationLab.hyOVLrOXaO40SpKFcFP(RotationLab.MHhyiHOtXqhFeE532tB(-161182833 ^ -161162857), (int)(u2.G - 1)));
				Block_155:
				goto IL_3107;
				Block_163:
				goto IL_2C7C;
				IL_2F9C:
				IL_3107:
				throw new Exception(string.Format(RotationLab.MHhyiHOtXqhFeE532tB(581513541 ^ 581526003), u2.G));
				IL_318A:
				goto IL_F38;
				IL_34CA:
				throw new Exception(string.Format(RotationLab.MHhyiHOtXqhFeE532tB(-161182833 ^ -161162765), (int)(u2.G - 1)));
				IL_38B4:
				goto IL_1081;
				IL_3CAF:
				goto IL_F38;
				IL_3D52:
				result = true;
				IL_3E57:
				IL_42C3:;
			}
			catch (Exception ex)
			{
				int num29 = 2;
				for (;;)
				{
					switch (num29)
					{
					default:
						RotationLab.ybwkVIOgbYM3M2pKHMO(this.CR, ex.Message);
						break;
					case 1:
						goto IL_434C;
					case 2:
						if (this.CR._LastPixelReadSuccess)
						{
							num29 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 == 0)
							{
								num29 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					result = false;
					num29 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num29 = 1;
					}
				}
				IL_434C:;
			}
			return result;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00039528 File Offset: 0x00037728
		private void OkTcKPYbFo()
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.LastAutoTab = RotationLab.nTPRdGO0vwiYH4yBXcT().ToUnixTimeMilliseconds();
					num2 = 4;
					continue;
				case 5:
					goto IL_EF;
				case 6:
					if (!RotationLab.Mi5moZObdWkqvPmZktJ(this.CR))
					{
						num2 = 5;
						continue;
					}
					goto IL_137;
				case 7:
					goto IL_50;
				case 8:
					goto IL_EF;
				case 9:
					goto IL_137;
				}
				break;
				IL_50:
				this.CR.UseMacro(RotationLab.MHhyiHOtXqhFeE532tB(-1089588375 ^ -1089587733));
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 != 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_EF:
				if (!this.CR.PlayerIsInCombat)
				{
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				else
				{
					if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.LastAutoTab > 1500L)
					{
						goto IL_50;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				IL_137:
				if (RotationLab.psg06JOzMdiwJ54bb85(this.CR))
				{
					goto IL_EF;
				}
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000396C4 File Offset: 0x000378C4
		public void Pulse()
		{
			DateTimeOffset dateTimeOffset;
			try
			{
				if (!this._AddonBuiltSuccess)
				{
					return;
				}
				for (;;)
				{
					IL_542:
					if (!this._isPulsing)
					{
						goto IL_1EF;
					}
					int num = 19;
					for (;;)
					{
						IL_2C:
						string text;
						int num2;
						switch (num)
						{
						case 0:
							goto IL_566;
						case 1:
							goto IL_200;
						case 2:
							if (this.CR._AutoTab)
							{
								goto IL_59C;
							}
							num = 22;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 != 0)
							{
								num = 25;
								continue;
							}
							continue;
						case 3:
						{
							bool lastPixelReadSuccess = this.CR._LastPixelReadSuccess;
							if (this.CR.PlayerClass == this.CR.ProfileClass)
							{
								goto IL_6BC;
							}
							num = 27;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
							{
								num = 14;
								continue;
							}
							continue;
						}
						case 4:
							goto IL_566;
						case 5:
							goto IL_73B;
						case 6:
							goto IL_229;
						case 7:
							goto IL_8EC;
						case 8:
							goto IL_6BC;
						case 9:
							goto IL_59C;
						case 10:
							goto IL_4D7;
						case 11:
							goto IL_2C5;
						case 12:
							goto IL_707;
						case 13:
							goto IL_6ED;
						case 14:
							if (!WindowTracker.GameFocused)
							{
								goto IL_707;
							}
							goto IL_897;
						case 15:
							this.LastErrorMessage = text;
							num = 67;
							continue;
						case 16:
							goto IL_4D7;
						case 17:
							goto IL_897;
						case 18:
							this.OkTcKPYbFo();
							num = 59;
							continue;
						case 19:
							goto IL_888;
						case 20:
							goto IL_1EF;
						case 21:
							goto IL_582;
						case 22:
							if (!this.CR.PlayerIsDead)
							{
								num = 56;
								continue;
							}
							goto IL_531;
						case 23:
							RotationLab.ybwkVIOgbYM3M2pKHMO(this.CR, text);
							num = 15;
							continue;
						case 24:
							goto IL_37E;
						case 25:
							goto IL_32D;
						case 26:
							goto IL_3CA;
						case 27:
							if (this.CR.PlayerClass == 0)
							{
								num = 8;
								continue;
							}
							text = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-693910567 ^ -693923639);
							num = 4;
							continue;
						case 28:
							if (this.CR._AttackTargetNotInCombat)
							{
								goto IL_582;
							}
							num = 16;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
							{
								num = 14;
								continue;
							}
							continue;
						case 29:
							goto IL_962;
						case 30:
							goto IL_4B9;
						case 31:
							if (!this.CR.PlayerIsMounted)
							{
								goto IL_86E;
							}
							num = 50;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 != 0)
							{
								num = 64;
								continue;
							}
							continue;
						case 32:
							goto IL_4B9;
						case 33:
							dateTimeOffset = RotationLab.nTPRdGO0vwiYH4yBXcT();
							this._LastPulseTimestamp = dateTimeOffset.ToUnixTimeMilliseconds();
							num = 4;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 == 0)
							{
								num = 11;
								continue;
							}
							continue;
						case 34:
							goto IL_531;
						case 35:
							this._isPulsing = false;
							num = 33;
							continue;
						case 36:
							if (!this.CR._AttackPlayerNotInCombat)
							{
								num = 10;
								continue;
							}
							goto IL_795;
						case 37:
							goto IL_6BC;
						case 38:
							goto IL_258;
						case 39:
							goto IL_152;
						case 40:
							goto IL_566;
						case 41:
							goto IL_542;
						case 42:
							if (dateTimeOffset.ToUnixTimeMilliseconds() - this._LastPulseTimestamp < 20L)
							{
								goto IL_258;
							}
							num = 14;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
							{
								num = 4;
								continue;
							}
							continue;
						case 43:
							goto IL_531;
						case 44:
							goto IL_531;
						case 45:
							goto IL_4D7;
						case 46:
							goto IL_672;
						case 47:
							this.RotationOutOfCombat();
							goto IL_5EB;
						case 48:
							goto IL_566;
						case 49:
							goto IL_531;
						case 50:
							goto IL_86E;
						case 51:
							goto IL_41E;
						case 52:
							if (!RotationLab.eSkFFpfEQJiwIps98VM(this.CR))
							{
								num = 36;
								continue;
							}
							goto IL_795;
						case 53:
							goto IL_464;
						case 54:
							if (!this.WgpcePRclf())
							{
								goto IL_672;
							}
							num2 = 35;
							break;
						case 55:
							goto IL_29B;
						case 56:
							if (RotationLab.eSkFFpfEQJiwIps98VM(this.CR))
							{
								num = 2;
								continue;
							}
							goto IL_32D;
						case 57:
							goto IL_73B;
						case 58:
							goto IL_60F;
						case 59:
							goto IL_32D;
						case 60:
							goto IL_229;
						case 61:
							goto IL_92A;
						case 62:
							goto IL_531;
						case 63:
							goto IL_795;
						case 64:
							goto IL_531;
						case 65:
							goto IL_23E;
						case 66:
							goto IL_200;
						case 67:
							goto IL_72C;
						case 68:
							goto IL_6D6;
						case 69:
							RotationLab.b8Bv8IfcZmXRJQXEpjC(this);
							num = 52;
							continue;
						case 70:
							goto IL_566;
						default:
							goto IL_566;
						}
						IL_28:
						num = num2;
						continue;
						IL_4B9:
						if (!this.CR.TogglePause)
						{
							num2 = 48;
							goto IL_28;
						}
						goto IL_60F;
						IL_152:
						if (!this.CR.PlayerIsMounted)
						{
							num = 32;
							continue;
						}
						goto IL_41E;
						IL_229:
						if (this.CR.ChatFocused)
						{
							text = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~744818537 ^ -744838298);
							num = 40;
							continue;
						}
						goto IL_152;
						IL_200:
						if (RotationLab.h3bR2nOeoSINbIeDGtm(this.CR))
						{
							num = 5;
							continue;
						}
						goto IL_4D7;
						IL_23E:
						if (!RotationLab.psg06JOzMdiwJ54bb85(this.CR))
						{
							num = 57;
							continue;
						}
						goto IL_200;
						IL_582:
						if (!RotationLab.pFKvxTfxxqfbhuUo9k4(this.CR))
						{
							num = 66;
							continue;
						}
						goto IL_23E;
						IL_795:
						if (RotationLab.HEMIYlf5IglmLcDhw72(this.CR))
						{
							goto IL_582;
						}
						num = 28;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 != 0)
						{
							num = 21;
							continue;
						}
						continue;
						IL_897:
						this.CR._LastPixelReadSuccess = this.Gytca2Eyra();
						if (!this.CR.ChatFocused)
						{
							goto IL_92A;
						}
						num = 35;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 == 0)
						{
							num = 49;
							continue;
						}
						continue;
						IL_29B:
						if (RotationLab.IyKakoOG3H8CEpRrTjf(text, ""))
						{
							num = 23;
							continue;
						}
						goto IL_962;
						IL_566:
						if (!(this.LastErrorMessage != text))
						{
							num = 7;
							continue;
						}
						goto IL_29B;
						IL_6D6:
						text = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2102188928 ^ -2102167786);
						goto IL_566;
						IL_6BC:
						if (!this.CR.SpellIsTargeting)
						{
							num = 6;
							continue;
						}
						goto IL_6D6;
						IL_32D:
						this._isPulsing = true;
						num = 69;
						continue;
						IL_59C:
						if (!RotationLab.h3bR2nOeoSINbIeDGtm(this.CR))
						{
							num = 18;
							continue;
						}
						goto IL_32D;
						IL_3CA:
						if (this.CR.PlayerClass != this.CR.ProfileClass)
						{
							goto IL_531;
						}
						num = 22;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba != 0)
						{
							num = 0;
							continue;
						}
						continue;
						IL_86E:
						if (this.CR.SpellIsTargeting)
						{
							num = 43;
							continue;
						}
						goto IL_3CA;
						IL_41E:
						text = RotationLab.MHhyiHOtXqhFeE532tB(-1352111144 ^ -1352122476);
						num = 37;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
						{
							num = 70;
							continue;
						}
						continue;
						IL_464:
						if (RotationLab.jcx27VfPA7rrxUVNNo9(this.CR))
						{
							num = 31;
							continue;
						}
						goto IL_531;
						IL_6ED:
						if (!this.CR._LastPixelReadSuccess)
						{
							num = 34;
							continue;
						}
						goto IL_464;
						IL_92A:
						if (RotationLab.i7ZFKBfWf7MbWVVhWxw(this.CR))
						{
							num2 = 44;
							goto IL_28;
						}
						goto IL_6ED;
						IL_531:
						text = "";
						num = 3;
						continue;
						IL_60F:
						text = RotationLab.MHhyiHOtXqhFeE532tB(-1860104403 ^ -1860084855);
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
						{
							num = 0;
							continue;
						}
						continue;
						IL_672:
						RotationLab.CMO9dGfuB2UjYYlif1y(this);
						num = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
						{
							num = 45;
							continue;
						}
						continue;
						IL_73B:
						if (!this.CR._EnableManualCastQueue)
						{
							goto IL_672;
						}
						num = 45;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
						{
							num = 54;
							continue;
						}
						continue;
						IL_707:
						RotationLab.ybwkVIOgbYM3M2pKHMO(this.CR, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1745773992 ^ -1745760602));
						num = 29;
						continue;
						IL_4D7:
						if (!RotationLab.eSkFFpfEQJiwIps98VM(this.CR))
						{
							num2 = 47;
							goto IL_28;
						}
						IL_5EB:
						this._isPulsing = false;
						num2 = 24;
						goto IL_28;
					}
					IL_1EF:
					dateTimeOffset = DateTimeOffset.Now;
					num = 42;
					goto IL_2C;
				}
				IL_258:
				IL_2C5:
				return;
				IL_37E:
				IL_72C:
				goto IL_962;
				IL_888:
				return;
				IL_8EC:
				IL_962:;
			}
			catch (Exception ex)
			{
				int num3 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					this.CR.WriteLog(ex.Message);
					break;
				}
			}
			dateTimeOffset = RotationLab.nTPRdGO0vwiYH4yBXcT();
			this._LastPulseTimestamp = dateTimeOffset.ToUnixTimeMilliseconds();
			int num4 = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 != 0)
			{
				num4 = 0;
			}
			switch (num4)
			{
			}
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0003A0D4 File Offset: 0x000382D4
		private bool WgpcePRclf()
		{
			int num = 9;
			int num2 = num;
			for (;;)
			{
				DateTimeOffset dateTimeOffset;
				switch (num2)
				{
				case 0:
					goto IL_251;
				case 1:
					goto IL_131;
				case 2:
					dateTimeOffset = RotationLab.nTPRdGO0vwiYH4yBXcT();
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					if (dateTimeOffset.ToUnixTimeMilliseconds() - this.CR._ManualCastQueueTimestamp >= 1650L)
					{
						return false;
					}
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					if (this.CR.LastCastSpellId == this.CR._ManualCastQueueSpellID)
					{
						return false;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
					{
						num2 = 15;
						continue;
					}
					continue;
				case 5:
					goto IL_41F;
				case 6:
					return true;
				case 7:
					if (dateTimeOffset.ToUnixTimeMilliseconds() - this.CR._ManualCastQueueTimestamp < 1650L)
					{
						num2 = 16;
						continue;
					}
					return false;
				case 8:
					if (this.CR._ManualCastQueueSpellID > 0)
					{
						num2 = 2;
						continue;
					}
					return false;
				case 9:
					if (this.CR._ManualCastType == 1)
					{
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					else if (this.CR._ManualCastType == 2)
					{
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					}
					else
					{
						if (this.CR._ManualCastType == 3)
						{
							num2 = 11;
							continue;
						}
						return false;
					}
					break;
				case 10:
					goto IL_3FF;
				case 11:
					if (this.CR._ManualCastQueueMacroName != "")
					{
						num2 = 18;
						continue;
					}
					return false;
				case 12:
					return true;
				case 13:
					if (this.CR._ManualCastQueueItemID <= 0)
					{
						num2 = 23;
						continue;
					}
					goto IL_251;
				case 14:
					if (!this.CR.CanUseItem(this.CR._ManualCastQueueItemID, -1))
					{
						num2 = 5;
						continue;
					}
					goto IL_3FF;
				case 15:
					this.CR.WriteLog(RotationLab.qa5vMafVwrlso0XVhnw(RotationLab.MHhyiHOtXqhFeE532tB(-161182833 ^ -161161517), this.CR._GetSpellName(this.CR._ManualCastQueueSpellID)));
					if (this.CR.CanCastSpell(this.CR._ManualCastQueueSpellID, -1, false))
					{
						num2 = 17;
						continue;
					}
					return false;
				case 16:
					RotationLab.ybwkVIOgbYM3M2pKHMO(this.CR, RotationLab.qa5vMafVwrlso0XVhnw(RotationLab.MHhyiHOtXqhFeE532tB(-1640708702 ^ -1640722398), this.CR._GetItemName(this.CR._ManualCastQueueItemID)));
					num2 = 13;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
					{
						num2 = 14;
						continue;
					}
					continue;
				case 17:
					RotationLab.Iu2xYvfyE5EBrbgnKuq(this.CR, this.CR._ManualCastQueueSpellID);
					num2 = 6;
					continue;
				case 18:
					dateTimeOffset = DateTimeOffset.Now;
					if (dateTimeOffset.ToUnixTimeMilliseconds() - this.CR._ManualCastQueueTimestamp >= 1650L)
					{
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				case 19:
					if (!this.CR.CanUseMacro(this.CR._ManualCastQueueMacroName, -1))
					{
						num2 = 21;
						continue;
					}
					goto IL_2EE;
				case 20:
					goto IL_2EE;
				case 21:
					goto IL_3F0;
				case 22:
					break;
				case 23:
					goto IL_297;
				default:
					goto IL_251;
				}
				this.CR.WriteLog(RotationLab.MHhyiHOtXqhFeE532tB(-838478377 ^ -838500239) + this.CR._ManualCastQueueMacroName);
				num2 = 19;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
				{
					num2 = 8;
					continue;
				}
				continue;
				IL_251:
				dateTimeOffset = DateTimeOffset.Now;
				num2 = 7;
				continue;
				IL_3FF:
				RotationLab.UEPKIEf8C68ijv2xkes(this.CR, this.CR._ManualCastQueueItemID);
				num2 = 12;
			}
			IL_131:
			return false;
			IL_297:
			return false;
			IL_2EE:
			RotationLab.H9Mgpqfq3eENMhVAbDX(this.CR, this.CR._ManualCastQueueMacroName);
			return true;
			IL_3F0:
			IL_41F:
			return false;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0003A52C File Offset: 0x0003872C
		public virtual void Initialize()
		{
			this.CR.WriteLog(RotationLab.MHhyiHOtXqhFeE532tB(-1089588375 ^ -1089575257));
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0003A550 File Offset: 0x00038750
		public virtual void RotationInCombat()
		{
			RotationLab.ybwkVIOgbYM3M2pKHMO(this.CR, RotationLab.MHhyiHOtXqhFeE532tB(-33448599 >> 2 ^ -8375956));
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003A580 File Offset: 0x00038780
		public virtual void Rotation()
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0003A584 File Offset: 0x00038784
		public virtual void RotationOutOfCombat()
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0003A588 File Offset: 0x00038788
		public RotationLab()
		{
			RotationLab.vghwt9fdGNq0yMbA2xf();
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			this.CR = new RotationLabHelper();
			base..ctor();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0003A5F0 File Offset: 0x000387F0
		// Note: this type is marked as 'beforefieldinit'.
		static RotationLab()
		{
			RotationLab.oSFvPwfoEd2icU5iIMv();
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0003A5F8 File Offset: 0x000387F8
		internal static bool SS9us4OaQSN8JhE81u0()
		{
			return RotationLab.IkaI0sOl2YkNEh4eD20 == null;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003A604 File Offset: 0x00038804
		internal static RotationLab mNL47YOKW5g8MjQmEhT()
		{
			return RotationLab.IkaI0sOl2YkNEh4eD20;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0003A60C File Offset: 0x0003880C
		internal static bool h3bR2nOeoSINbIeDGtm(object A_0)
		{
			return A_0.HealingRotation;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003A618 File Offset: 0x00038818
		internal static Rectangle zssL4wOki38cl9gQEMR(object A_0)
		{
			return A_0.Bounds;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0003A624 File Offset: 0x00038824
		internal static object RQAK4OOrfZieTkW4BBS(object A_0)
		{
			return Graphics.FromImage(A_0);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0003A630 File Offset: 0x00038830
		internal static object lXJINnO76Losn8OV48H(IntPtr A_0)
		{
			return Graphics.FromHwnd(A_0);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0003A63C File Offset: 0x0003883C
		internal static IntPtr j7uvfjO2FijJbhp9aou(object A_0)
		{
			return A_0.GetHdc();
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0003A648 File Offset: 0x00038848
		internal static void vqyoX4O64QjtQlS76vJ(object A_0)
		{
			A_0.ReleaseHdc();
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0003A654 File Offset: 0x00038854
		internal static Color souMiQONFJxvqHRk1rF(object A_0, int A_1, int A_2)
		{
			return A_0.GetPixel(A_1, A_2);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0003A668 File Offset: 0x00038868
		internal static bool pKxnieOnohF6DXibEsK(Color A_0, Color A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0003A678 File Offset: 0x00038878
		internal static DateTimeOffset nTPRdGO0vwiYH4yBXcT()
		{
			return DateTimeOffset.Now;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0003A680 File Offset: 0x00038880
		internal static int SgXMFrOJuydnwEmfCMt(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0003A68C File Offset: 0x0003888C
		internal static void Mq77IGOmag33RGpudiJ(object A_0, int A_1)
		{
			A_0.RemoveAt(A_1);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0003A69C File Offset: 0x0003889C
		internal static int ba0qyZOH9EcifSiyJwt(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0003A6A8 File Offset: 0x000388A8
		internal static object MHhyiHOtXqhFeE532tB(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0003A6B4 File Offset: 0x000388B4
		internal static bool i6qJhDOY8tEP8eDbkxS(object A_0, object A_1)
		{
			return A_0.StartsWith(A_1);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0003A6C4 File Offset: 0x000388C4
		internal static object EmpaWJOsrmYuBnmdnWH(object A_0, int menuIndex, int selectedIndex)
		{
			return A_0._GetToggleMenuText(menuIndex, selectedIndex);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0003A6D8 File Offset: 0x000388D8
		internal static void ybwkVIOgbYM3M2pKHMO(object A_0, object A_1)
		{
			A_0.WriteLog(A_1);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0003A6E8 File Offset: 0x000388E8
		internal static object hyOVLrOXaO40SpKFcFP(object A_0, object A_1)
		{
			return string.Format(A_0, A_1);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0003A6F8 File Offset: 0x000388F8
		internal static object Own7isOMGIUYXHTLq2V(object A_0, object A_1)
		{
			return string.Format(A_0, A_1);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0003A708 File Offset: 0x00038908
		internal static bool IyKakoOG3H8CEpRrTjf(object A_0, object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0003A718 File Offset: 0x00038918
		internal static bool Sfj2B9OBTPJxBjPACV1(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0003A728 File Offset: 0x00038928
		internal static object yXOG9hOD9CsPLqyWqNv(object A_0, object A_1, object A_2)
		{
			return string.Format(A_0, A_1, A_2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0003A73C File Offset: 0x0003893C
		internal static int SgtbJDOvuGP5yrNSsj7(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0003A748 File Offset: 0x00038948
		internal static void nN4dlcOjRD0DnIoUbPk(object A_0)
		{
			A_0.Clear();
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0003A754 File Offset: 0x00038954
		internal static bool Mi5moZObdWkqvPmZktJ(object A_0)
		{
			return A_0.TargetExists;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0003A760 File Offset: 0x00038960
		internal static bool psg06JOzMdiwJ54bb85(object A_0)
		{
			return A_0.TargetIsDead;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0003A76C File Offset: 0x0003896C
		internal static bool i7ZFKBfWf7MbWVVhWxw(object A_0)
		{
			return A_0.TogglePause;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0003A778 File Offset: 0x00038978
		internal static bool jcx27VfPA7rrxUVNNo9(object A_0)
		{
			return A_0.PlayerExists;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0003A784 File Offset: 0x00038984
		internal static bool eSkFFpfEQJiwIps98VM(object A_0)
		{
			return A_0.PlayerIsInCombat;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0003A790 File Offset: 0x00038990
		internal static void b8Bv8IfcZmXRJQXEpjC(object A_0)
		{
			A_0.Rotation();
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0003A79C File Offset: 0x0003899C
		internal static bool HEMIYlf5IglmLcDhw72(object A_0)
		{
			return A_0.TargetIsInCombat;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0003A7A8 File Offset: 0x000389A8
		internal static bool pFKvxTfxxqfbhuUo9k4(object A_0)
		{
			return A_0.PlayerCanAttackTarget;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0003A7B4 File Offset: 0x000389B4
		internal static void CMO9dGfuB2UjYYlif1y(object A_0)
		{
			A_0.RotationInCombat();
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0003A7C0 File Offset: 0x000389C0
		internal static object qa5vMafVwrlso0XVhnw(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0003A7D0 File Offset: 0x000389D0
		internal static void Iu2xYvfyE5EBrbgnKuq(object A_0, int spellId)
		{
			A_0.CastSpell(spellId);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0003A7E0 File Offset: 0x000389E0
		internal static void UEPKIEf8C68ijv2xkes(object A_0, int itemId)
		{
			A_0.UseItem(itemId);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0003A7F0 File Offset: 0x000389F0
		internal static void H9Mgpqfq3eENMhVAbDX(object A_0, object A_1)
		{
			A_0.UseMacro(A_1);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0003A800 File Offset: 0x00038A00
		internal static void vghwt9fdGNq0yMbA2xf()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0003A808 File Offset: 0x00038A08
		internal static void oSFvPwfoEd2icU5iIMv()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x04000317 RID: 791
		private Color _PreviousPriorityPixelColor;

		// Token: 0x04000318 RID: 792
		private Color _PreviousStandardPixelColor;

		// Token: 0x04000319 RID: 793
		private int CheckR;

		// Token: 0x0400031A RID: 794
		private int CheckG;

		// Token: 0x0400031B RID: 795
		private int CheckB;

		// Token: 0x0400031C RID: 796
		public bool _AddonBuiltSuccess;

		// Token: 0x0400031D RID: 797
		private long _LastTalentRead;

		// Token: 0x0400031E RID: 798
		private long _LastGlyphRead;

		// Token: 0x0400031F RID: 799
		private int _lastCastTimestamp;

		// Token: 0x04000320 RID: 800
		private int _lastCastInGameTimestamp;

		// Token: 0x04000321 RID: 801
		public RotationLabHelper CR;

		// Token: 0x04000322 RID: 802
		private int _PixelReadFailCount;

		// Token: 0x04000323 RID: 803
		private long LastAutoTab;

		// Token: 0x04000324 RID: 804
		private long _LastPulseTimestamp;

		// Token: 0x04000325 RID: 805
		private bool _isPulsing;

		// Token: 0x04000326 RID: 806
		public int _PixelLocation;

		// Token: 0x04000327 RID: 807
		private string LastErrorMessage;

		// Token: 0x04000328 RID: 808
		internal static RotationLab IkaI0sOl2YkNEh4eD20;
	}
}
