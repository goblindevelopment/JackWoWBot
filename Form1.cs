using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using bSZew2cfycgxx2Qytd1;
using FMUtils.KeyboardHook;
using Guna.UI2.WinForms;
using Interceptor;
using jKfdjbkhweMBv9T4LF;
using Microsoft.CodeDom.Providers.DotNetCompilerPlatform;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.WindowsAPICodePack.Dialogs;
using MyU9Ep58ZH3s5ThDFJQ;
using Newtonsoft.Json;
using oUFoSKR3C2hCk1na34;
using PFKsXUln68gK98ndGV;
using pv3wLjFLovBNS8B3YH;
using qh4tv5C06LoTjDckaL;
using RotationLabEngine.Properties;
using Sk5EtwKTjRJr4xlhBC;
using vj6ZEIchxieKH6xwM2t;
using WK.Libraries.SharpClipboardNS;
using wKolMkxZecDx58YaRR4;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x0200001D RID: 29
	public partial class Form1 : Form
	{
		// Token: 0x060000C7 RID: 199
		[DllImport("gdi32.dll", EntryPoint = "AddFontMemResourceEx")]
		private static extern IntPtr qZE0Hoe5K(IntPtr \u0020, uint \u0020, IntPtr \u0020, [In] ref uint \u0020);

		// Token: 0x060000C8 RID: 200 RVA: 0x000051EC File Offset: 0x000033EC
		public static string ConvertToGameKey(string keys)
		{
			int num = 6;
			int num2 = num;
			string[] array;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_129;
				case 1:
					goto IL_DB;
				case 2:
					goto IL_EB;
				case 3:
					goto IL_119;
				case 4:
					break;
				case 5:
					num3 = 0;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 6:
					array = keys.Split(new char[]
					{
						'+'
					});
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 7:
					goto IL_119;
				default:
					goto IL_129;
				}
				IL_86:
				array[num3] = Form1.WoWKeys[array[num3]];
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 != 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_EB:
				if (Form1.WoWKeys.ContainsKey(array[num3]))
				{
					goto IL_86;
				}
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_119:
				if (num3 >= array.Length)
				{
					break;
				}
				goto IL_EB;
				IL_DB:
				num3++;
				num2 = 7;
				continue;
				IL_129:
				goto IL_DB;
			}
			return Form1.iL51BVQjDDFv8h51MTQ(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1048347516 ^ 1048348524), array);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00005334 File Offset: 0x00003534
		private void IxQJYdW2r()
		{
			try
			{
				if (Directory.Exists(Form1.Bp8crKQbU76Tg68kvQp(-582433477 + 1816872807 ^ 1234438324)))
				{
					goto IL_10B;
				}
				int num = 3;
				string[] files;
				Icon icon;
				for (;;)
				{
					IL_35:
					int num2;
					switch (num)
					{
					case 1:
						if (files.Length == 0)
						{
							goto IL_153;
						}
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
					{
						Bitmap bitmap = (Bitmap)Form1.Bj5kyqCPWxnFPEQJGPe(Form1.xv1g48CWlI8vVbXlHcX(files[num2]), 64, 64, null, IntPtr.Zero);
						Form1.r2qrNWCEYHb1avWEaL1(bitmap);
						icon = Form1.Aa13RWC5p96ZAdLTQUD(Form1.my3DbMCcXZbYCmecXeg(bitmap));
						num = 4;
						continue;
					}
					case 3:
						goto IL_EC;
					case 4:
						goto IL_57;
					case 5:
						goto IL_10B;
					}
					num2 = Form1.Of4KHkQzwdMbXcku9yf(this.random, 0, files.Length);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
					{
						num = 2;
					}
				}
				IL_57:
				Form1.ccKgXrCx2StFhg4s46p(this, icon);
				IL_EC:
				IL_153:
				return;
				IL_10B:
				files = Directory.GetFiles(Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134400136), Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218525819), SearchOption.TopDirectoryOnly);
				num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
				{
					num = 1;
					goto IL_35;
				}
				goto IL_35;
			}
			catch
			{
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000054C4 File Offset: 0x000036C4
		public Form1()
		{
			Form1.PwaWInCuQyb2BJJJoIR();
			Form1.CDo8HXCVVJibMvMqBvF();
			this.fonts = new PrivateFontCollection();
			this.fontsBold = new PrivateFontCollection();
			this.fontsConsole = new PrivateFontCollection();
			this.fontsLED = new PrivateFontCollection();
			this.MagistralBook = new PrivateFontCollection();
			this.MagistralMedium = new PrivateFontCollection();
			this.MagistralBold = new PrivateFontCollection();
			this.wowhead = new WowheadInfo();
			this.random = new Random();
			this.ks = new ceGL4JcAiPYF89VVIUS();
			this.KeyBindRow = -1;
			this.previousClipboardContent = "";
			base..ctor();
			int num = 41;
			for (;;)
			{
				int num5;
				byte[] array2;
				switch (num)
				{
				case 0:
					goto IL_68A;
				case 1:
					Form1.F8DDPrC4dhV11PnsIC6(this.btnStartStop, new Font(Form1.B5t9xvCpPTNI9krvIau(this.MagistralBold)[0], Form1.iwndZfCfoQap3URLrTC(Form1.kHr34aCONeoYV2e6tqZ(this.btnStartStop))));
					num = 35;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 == 0)
					{
						num = 5;
						continue;
					}
					continue;
				case 2:
				{
					IntPtr intPtr;
					uint num2;
					Form1.qZE0Hoe5K(intPtr, (uint)Form1.b93dlyCSswkm6GuUpmV().Length, IntPtr.Zero, ref num2);
					num = 5;
					continue;
				}
				case 3:
				{
					IntPtr intPtr2;
					Form1.Ew4uvHChfJ5UO6bBn6n(this.fontsConsole, intPtr2, Form1.HQlak7CwOROmoBKpVmu().Length);
					num = 45;
					continue;
				}
				case 4:
				{
					ImageList imageList;
					Form1.yeEr8KC3tmD8prHDjCB(Form1.GaMaotCqWxchpV0yRLI(imageList), Resources.settings);
					num = 37;
					continue;
				}
				case 5:
				{
					IntPtr intPtr;
					Form1.zEOOHQCIOvrgTrDAGWE(intPtr);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
					{
						num = 0;
						continue;
					}
					continue;
				}
				case 6:
				{
					ImageList imageList;
					Form1.htxL3fCyLlCk5SrYoDM(imageList, ColorDepth.Depth32Bit);
					num = 14;
					continue;
				}
				case 7:
				{
					IntPtr intPtr2;
					Marshal.FreeCoTaskMem(intPtr2);
					num = 38;
					continue;
				}
				case 8:
				{
					ImageList imageList;
					Form1.yeEr8KC3tmD8prHDjCB(Form1.GaMaotCqWxchpV0yRLI(imageList), Form1.jhpoyQCoFNajNh754ly());
					num = 15;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
					{
						num = 47;
						continue;
					}
					continue;
				}
				case 9:
					return;
				case 10:
				{
					ImageList imageList;
					Form1.GaMaotCqWxchpV0yRLI(imageList).Add(Form1.vbs04YCdZsieDgf7KmL());
					num = 8;
					continue;
				}
				case 11:
				{
					uint num3 = 0U;
					num = 3;
					continue;
				}
				case 12:
				{
					byte[] array = Form1.Cc3ITiC1MaI7qrQHlZg();
					num = 24;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d == 0)
					{
						num = 22;
						continue;
					}
					continue;
				}
				case 13:
				{
					uint num4 = 0U;
					num = 20;
					continue;
				}
				case 14:
				{
					ImageList imageList;
					Form1.YVdnPmC8Fdoibuo8lAN(imageList, new Size(24, 24));
					num5 = 10;
					break;
				}
				case 15:
				{
					IntPtr intPtr3;
					uint num6;
					Form1.qZE0Hoe5K(intPtr3, (uint)Resources.Marine_Bold.Length, IntPtr.Zero, ref num6);
					num = 22;
					continue;
				}
				case 16:
				{
					uint num6 = 0U;
					num = 31;
					continue;
				}
				case 17:
					this.RrpEvm3iON();
					num = 7;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab == 0)
					{
						num = 27;
						continue;
					}
					continue;
				case 18:
					Form1.ncynG5CT8UsyjBsDC3f(this.DataGridSettings, false);
					num = 9;
					continue;
				case 19:
				{
					byte[] magistral_Bold;
					IntPtr intPtr4;
					Form1.zh2Jv8CATF85TWtqJI6(magistral_Bold, 0, intPtr4, magistral_Bold.Length);
					num = 23;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
					{
						num = 46;
						continue;
					}
					continue;
				}
				case 20:
				{
					IntPtr intPtr5;
					Form1.Ew4uvHChfJ5UO6bBn6n(this.MagistralBook, intPtr5, Form1.UbuLBZCiIdYYPfR8hM4().Length);
					num = 39;
					continue;
				}
				case 21:
				{
					ImageList imageList;
					Form1.yhxkS5C9aXPyOelZpN6(this.guna2TabControl1, imageList);
					num = 49;
					continue;
				}
				case 22:
				{
					IntPtr intPtr3;
					Form1.zEOOHQCIOvrgTrDAGWE(intPtr3);
					num5 = 28;
					break;
				}
				case 23:
				{
					byte[] magistral_Bold;
					IntPtr intPtr4 = Form1.cHCHwsCZDgihOO79EbS(magistral_Bold.Length);
					num = 19;
					continue;
				}
				case 24:
				{
					byte[] array;
					IntPtr intPtr3 = Form1.cHCHwsCZDgihOO79EbS(array.Length);
					num = 42;
					continue;
				}
				case 25:
				{
					IntPtr intPtr5 = Marshal.AllocCoTaskMem(array2.Length);
					num = 43;
					continue;
				}
				case 26:
				{
					byte[] array3;
					IntPtr intPtr2 = Marshal.AllocCoTaskMem(array3.Length);
					num = 23;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
					{
						num = 36;
						continue;
					}
					continue;
				}
				case 27:
					this.IxQJYdW2r();
					num = 21;
					continue;
				case 28:
					Form1.F8DDPrC4dhV11PnsIC6(this.textConsole, new Font(Form1.B5t9xvCpPTNI9krvIau(this.fontsConsole)[0], 11f));
					num = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				case 29:
				{
					IntPtr intPtr4;
					Form1.zEOOHQCIOvrgTrDAGWE(intPtr4);
					num = 12;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af != 0)
					{
						num = 5;
						continue;
					}
					continue;
				}
				case 30:
				{
					uint num2 = 0U;
					num = 32;
					continue;
				}
				case 31:
				{
					IntPtr intPtr3;
					this.MagistralMedium.AddMemoryFont(intPtr3, Form1.Cc3ITiC1MaI7qrQHlZg().Length);
					num = 15;
					continue;
				}
				case 32:
				{
					IntPtr intPtr;
					this.fontsLED.AddMemoryFont(intPtr, Form1.b93dlyCSswkm6GuUpmV().Length);
					num = 2;
					continue;
				}
				case 33:
				{
					IntPtr intPtr4;
					uint num7;
					Form1.qZE0Hoe5K(intPtr4, (uint)Form1.Rd8iRYCUDaMrjvhgZZM().Length, IntPtr.Zero, ref num7);
					num = 29;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
					{
						num = 9;
						continue;
					}
					continue;
				}
				case 34:
				{
					byte[] magistral_Bold = Resources.Magistral_Bold;
					num = 13;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 != 0)
					{
						num = 23;
						continue;
					}
					continue;
				}
				case 35:
					Form1.wEyJSbCFacgSXItvROk(this.textStatus, new Font(Form1.B5t9xvCpPTNI9krvIau(this.MagistralBook)[0], 13f));
					num5 = 18;
					break;
				case 36:
				{
					IntPtr intPtr2;
					byte[] array3;
					Form1.zh2Jv8CATF85TWtqJI6(array3, 0, intPtr2, array3.Length);
					num = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae != 0)
					{
						num = 11;
						continue;
					}
					continue;
				}
				case 37:
				{
					ImageList imageList;
					imageList.Images.Add(Form1.WDUPtKCCDw4KSKvvjb4());
					num = 17;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 != 0)
					{
						num = 7;
						continue;
					}
					continue;
				}
				case 38:
				{
					byte[] array4 = Form1.b93dlyCSswkm6GuUpmV();
					num = 48;
					continue;
				}
				case 39:
				{
					uint num4;
					IntPtr intPtr5;
					Form1.qZE0Hoe5K(intPtr5, (uint)Form1.UbuLBZCiIdYYPfR8hM4().Length, IntPtr.Zero, ref num4);
					num = 28;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
					{
						num = 40;
						continue;
					}
					continue;
				}
				case 40:
				{
					IntPtr intPtr5;
					Form1.zEOOHQCIOvrgTrDAGWE(intPtr5);
					num = 34;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a != 0)
					{
						num = 22;
						continue;
					}
					continue;
				}
				case 41:
				{
					ImageList imageList = new ImageList();
					num = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
					{
						num = 6;
						continue;
					}
					continue;
				}
				case 42:
				{
					byte[] array;
					IntPtr intPtr3;
					Form1.zh2Jv8CATF85TWtqJI6(array, 0, intPtr3, array.Length);
					num = 16;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num = 10;
						continue;
					}
					continue;
				}
				case 43:
				{
					IntPtr intPtr5;
					Form1.zh2Jv8CATF85TWtqJI6(array2, 0, intPtr5, array2.Length);
					num = 13;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
					{
						num = 8;
						continue;
					}
					continue;
				}
				case 44:
				{
					IntPtr intPtr;
					byte[] array4;
					Marshal.Copy(array4, 0, intPtr, array4.Length);
					num = 30;
					continue;
				}
				case 45:
				{
					IntPtr intPtr2;
					uint num3;
					Form1.qZE0Hoe5K(intPtr2, (uint)Resources.UbuntuMono_Regular.Length, IntPtr.Zero, ref num3);
					num = 7;
					continue;
				}
				case 46:
				{
					uint num7 = 0U;
					num = 50;
					continue;
				}
				case 47:
				{
					ImageList imageList;
					Form1.yeEr8KC3tmD8prHDjCB(Form1.GaMaotCqWxchpV0yRLI(imageList), Form1.RAiKYsCQ2wMSh7DlDF3());
					num = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num = 4;
						continue;
					}
					continue;
				}
				case 48:
				{
					byte[] array4;
					IntPtr intPtr = Marshal.AllocCoTaskMem(array4.Length);
					num = 44;
					continue;
				}
				case 49:
				{
					byte[] array3 = Form1.HQlak7CwOROmoBKpVmu();
					num = 26;
					continue;
				}
				case 50:
				{
					IntPtr intPtr4;
					this.MagistralBold.AddMemoryFont(intPtr4, Form1.Rd8iRYCUDaMrjvhgZZM().Length);
					num = 33;
					continue;
				}
				default:
					goto IL_68A;
				}
				num = num5;
				continue;
				IL_68A:
				array2 = Form1.UbuLBZCiIdYYPfR8hM4();
				num = 25;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00005C70 File Offset: 0x00003E70
		private int coHmct1JQ(string \u0020, int \u0020)
		{
			int result;
			if (!int.TryParse(\u0020, out result))
			{
				return \u0020;
			}
			return result;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005CCC File Offset: 0x00003ECC
		private void wDvHiFolp(object \u0020, EventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			Form1.<Form1_Shown>d__24 <Form1_Shown>d__;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					<Form1_Shown>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					<Form1_Shown>d__.<>1__state = -1;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					goto IL_4F;
				}
				<Form1_Shown>d__.<>4__this = this;
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e != 0)
				{
					num2 = 2;
				}
			}
			IL_4F:
			<Form1_Shown>d__.<>t__builder.Start<Form1.<Form1_Shown>d__24>(ref <Form1_Shown>d__);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005D84 File Offset: 0x00003F84
		private void c1vtdShD1(object \u0020, KeyPressedEventArgs \u0020)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005D88 File Offset: 0x00003F88
		private void NoCYLbiqG()
		{
			yQGkVJcOSOQdjuwds7e.ini.Persist(Encoding.UTF8);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005DA0 File Offset: 0x00003FA0
		private void HgcsxIbkl(Control.ControlCollection \u0020)
		{
			for (;;)
			{
				IEnumerator enumerator = Form1.nJDCuJCRrgUeFA82EQZ(\u0020);
				try
				{
					for (;;)
					{
						int num;
						Control control;
						if (!Form1.AWksX3CaF27NUnPDnvS(enumerator))
						{
							num = 2;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
							{
								num = 2;
							}
						}
						else
						{
							control = (Control)Form1.ocqRt1CLNxqeknLG33w(enumerator);
							num = 3;
						}
						for (;;)
						{
							switch (num)
							{
							case 1:
								goto IL_44;
							case 2:
								goto IL_10E;
							case 3:
								if (Form1.OROF9nCl3q4uMeX8ApH(control) == null)
								{
									goto IL_44;
								}
								num = 4;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
								{
									num = 4;
									continue;
								}
								continue;
							case 4:
								this.HgcsxIbkl(Form1.OROF9nCl3q4uMeX8ApH(control));
								num = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
								{
									num = 1;
									continue;
								}
								continue;
							}
							break;
							IL_44:
							control.Font = new Font(Form1.B5t9xvCpPTNI9krvIau(this.fontsLED)[0], Form1.iwndZfCfoQap3URLrTC(Form1.kHr34aCONeoYV2e6tqZ(control)));
							num = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
							{
								num = 0;
							}
						}
					}
					IL_10E:
					break;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc != 0)
					{
						num2 = 0;
					}
					for (;;)
					{
						switch (num2)
						{
						default:
							if (disposable != null)
							{
								goto IL_171;
							}
							num2 = 1;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 == 0)
							{
								num2 = 1;
							}
							break;
						case 1:
							goto IL_17D;
						case 2:
							goto IL_171;
						}
					}
					IL_171:
					Form1.TX4EfrCKNxMbkrcZehx(disposable);
					IL_17D:;
				}
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005F74 File Offset: 0x00004174
		private void GOBgUcgxI(object \u0020, EventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				Form1.<Form1_Load>d__28 <Form1_Load>d__;
				switch (num2)
				{
				case 1:
					<Form1_Load>d__.<>t__builder = Form1.p1LuAOCetKbs7pSxl81();
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					<Form1_Load>d__.<>1__state = -1;
					<Form1_Load>d__.<>t__builder.Start<Form1.<Form1_Load>d__28>(ref <Form1_Load>d__);
					num2 = 3;
					continue;
				case 3:
					return;
				}
				<Form1_Load>d__.<>4__this = this;
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000601C File Offset: 0x0000421C
		private void VSwXr9cV0(bool \u0020 = false)
		{
			try
			{
				QkZCxleFAdLKmShDaf qkZCxleFAdLKmShDaf = Form1.bkc6gMCkJ6B4GSDpZR9(yQGkVJcOSOQdjuwds7e.ini.GetValue(Form1.Bp8crKQbU76Tg68kvQp(--1016420359 ^ 1016421077), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789513274), Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352741974)));
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 1:
					{
						FrmDownloadUpdate frmDownloadUpdate = new FrmDownloadUpdate();
						string destination;
						frmDownloadUpdate.startDownload(Form1.O1Q87IC0MLP2DPdBqmx(), destination, Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(-384868386 + 510636180 ^ 125768352), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2083830725 ^ -2083830049), Form1.Bp8crKQbU76Tg68kvQp(1905767247 ^ 1905768317)), Form1.UxjaDkCmutc5QJXE7Mj());
						Form1.Hm39RACHCHBBu0j5C3L(frmDownloadUpdate);
						num = 12;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 == 0)
						{
							num = 4;
							continue;
						}
						continue;
					}
					case 3:
						if (qkZCxleFAdLKmShDaf.Error != null)
						{
							goto IL_10B;
						}
						if (!qkZCxleFAdLKmShDaf.HasUpdate)
						{
							num = 6;
							continue;
						}
						goto IL_1DF;
					case 4:
						goto IL_10B;
					case 5:
						goto IL_182;
					case 6:
						goto IL_182;
					case 7:
						goto IL_1DF;
					case 8:
						Form1.YcZQDGCrd604D2KnaUs(this, qkZCxleFAdLKmShDaf.Error, Form1.Bp8crKQbU76Tg68kvQp(1714141621 >> 6 ^ 26782534), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						num = 10;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 != 0)
						{
							num = 6;
							continue;
						}
						continue;
					case 9:
					{
						this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(1881006439 >> 3 ^ 235124916), qkZCxleFAdLKmShDaf.Version));
						string destination = Form1.ECjoxLCnKi1kGfesUXO(Form1.LUR5vMCNLulnOAoYLUD(Form1.MZkk37C6N2MRGVPg3wl(Form1.z4yfFkC2QcWXXQG7aMx())), Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(~344187374 ^ -344188203), qkZCxleFAdLKmShDaf.Type));
						num = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					case 12:
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(326177456 ^ 326178384));
						num = 11;
						continue;
					case 13:
						goto IL_122;
					}
					break;
					IL_10B:
					this.WriteLog(qkZCxleFAdLKmShDaf.Error);
					num = 8;
					continue;
					IL_122:
					MessageBox.Show(this, Form1.Bp8crKQbU76Tg68kvQp(1691472209 >> 1 ^ 845737380), Form1.Bp8crKQbU76Tg68kvQp(-2083830725 ^ -2083831475), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 != 0)
					{
						num = 0;
						continue;
					}
					continue;
					IL_182:
					if (!\u0020)
					{
						num = 2;
						continue;
					}
					goto IL_122;
					IL_1DF:
					Form1.YcZQDGCrd604D2KnaUs(this, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(152750669 ^ 152751729) + qkZCxleFAdLKmShDaf.Version + Form1.Bp8crKQbU76Tg68kvQp(-1002815721 ^ -877302260 ^ 261051713), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-256932895 ^ -256931947), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					num = 9;
				}
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 == 0)
				{
					num2 = 0;
				}
				for (;;)
				{
					switch (num2)
					{
					default:
						this.WriteLog(ex.Message);
						Form1.PamqU2CtDmFnvOAlqmr(ex.Message);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 != 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						goto IL_390;
					}
				}
				IL_390:;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000063E0 File Offset: 0x000045E0
		private void GtfM1mavy(object \u0020, ElapsedEventArgs \u0020)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_92;
				case 2:
					return;
				case 3:
					Form1.xZBP3cCshH5lcITFW7O(this.RotationObj);
					num2 = 2;
					continue;
				case 4:
					goto IL_AC;
				case 5:
					if (this.RotationObj == null)
					{
						num2 = 4;
						continue;
					}
					goto IL_92;
				}
				int num3;
				this.PulseTimer.Interval = (double)num3;
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 == 0)
				{
					num2 = 3;
					continue;
				}
				continue;
				IL_92:
				int num4 = this.coHmct1JQ(Form1.dL7f3BCYsvs5WvdCOPK(this.textPulseFrequency), 100);
				num3 = num4 - (Form1.Of4KHkQzwdMbXcku9yf(this.random, 0, num4 / 5) - num4 / 10);
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
				{
					num2 = 0;
				}
			}
			return;
			IL_AC:;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000064E4 File Offset: 0x000046E4
		private void R9FGO3e4G(object \u0020, DoSpellCastArgs \u0020)
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				string text;
				string text2;
				switch (num2)
				{
				case 1:
					return;
				case 2:
					this.WriteLog(string.Concat(new string[]
					{
						Form1.Bp8crKQbU76Tg68kvQp(-1750427148 ^ -1750426552),
						text,
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1073891089 ^ 1073889997),
						text2,
						Form1.Bp8crKQbU76Tg68kvQp(-289990612 ^ 1144181582 ^ -1434071418)
					}));
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					text2 = this.RotationObj.CR._GetSpellKeybind(Form1.QUORgpCgkRIM8fePjQB(\u0020));
					num2 = 7;
					continue;
				case 4:
					if (this.RotationObj != null)
					{
						num2 = 3;
						continue;
					}
					return;
				case 5:
					return;
				case 6:
					goto IL_192;
				case 7:
					text = this.RotationObj.CR._GetSpellName(Form1.QUORgpCgkRIM8fePjQB(\u0020));
					num2 = 8;
					continue;
				case 8:
					if (Form1.R25qmmCXN2J9g6WCi7p(text2, ""))
					{
						goto IL_192;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-258475567 << 4 ^ 159357178), text, Form1.Bp8crKQbU76Tg68kvQp(1073891089 ^ 1073889545)));
				num2 = 5;
				continue;
				IL_192:
				Form1.SnT5xGCMapUAIVcnOPs(this.RotationObj.CR, text2);
				this.ks.xrtcSrwrsS(text2);
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 == 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000066C4 File Offset: 0x000048C4
		private void sJfBx4rUu(object \u0020, DoItemCastArgs \u0020)
		{
			int num = 3;
			int num2 = num;
			string text2;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					string text;
					this.ks.xrtcSrwrsS(text);
					num2 = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				}
				case 2:
				{
					string text = Form1.Aae7UcCDXg5aDtUfeAM(this.RotationObj.CR, Form1.eIlRfICBG8T4hp42Atx(\u0020));
					num2 = 5;
					continue;
				}
				case 3:
					if (this.RotationObj == null)
					{
						return;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
				{
					string text;
					Form1.SnT5xGCMapUAIVcnOPs(this.RotationObj.CR, text);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 5:
					text2 = this.RotationObj.CR._GetItemName(\u0020.ItemId);
					num2 = 7;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 6:
				{
					string text;
					this.WriteLog(Form1.eR4IbwCvGKOICfdxxUZ(new string[]
					{
						Form1.Bp8crKQbU76Tg68kvQp(1657092858 << 1 ^ -980782134),
						text2,
						Form1.Bp8crKQbU76Tg68kvQp(~-531755127 ^ 531756458),
						text,
						Form1.Bp8crKQbU76Tg68kvQp(-1008853611 >> 6 ^ -15762030)
					}));
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 7:
				{
					string text;
					if (!Form1.R25qmmCXN2J9g6WCi7p(text, ""))
					{
						goto IL_1B0;
					}
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				break;
			}
			return;
			IL_1B0:
			this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(Form1.Bp8crKQbU76Tg68kvQp(1657226489 - -588572257 ^ -2049168126), text2, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1765342390 ^ 1765341870)));
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000068B8 File Offset: 0x00004AB8
		private void WhODwOfTo(object \u0020, DoMacroCastArgs \u0020)
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 1:
						this.WriteLog(string.Concat(new string[]
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~2095831454 ^ -2095832925),
							Form1.F05MgDCjWlGHhEaoK7T(\u0020),
							Form1.Bp8crKQbU76Tg68kvQp(-1745773992 ^ -1745772668),
							text,
							Form1.Bp8crKQbU76Tg68kvQp(-825446221 ^ -825445033)
						}));
						num2 = 8;
						continue;
					case 2:
						return;
					case 3:
						if (this.RotationObj == null)
						{
							goto Block_2;
						}
						goto IL_171;
					case 4:
						Form1.tguPeVCzRe0O5dnbe3w(this.ks, Form1.Bp8crKQbU76Tg68kvQp(-789419076 ^ -35552607 ^ 756281253));
						num2 = 11;
						continue;
					case 5:
						Form1.SnT5xGCMapUAIVcnOPs(this.RotationObj.CR, text);
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 6:
						return;
					case 7:
						Form1.tguPeVCzRe0O5dnbe3w(this.ks, text);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 8:
						return;
					case 9:
						goto IL_171;
					case 10:
						Form1.SnT5xGCMapUAIVcnOPs(this.RotationObj.CR, Form1.Bp8crKQbU76Tg68kvQp(1767032709 ^ 1767031101));
						num2 = 4;
						continue;
					case 11:
						return;
					}
					IL_65:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1745773992 ^ -1745773354));
					num2 = 10;
					continue;
					IL_171:
					if (Form1.t0poRRCb3dy0hjmaGAe(Form1.F05MgDCjWlGHhEaoK7T(\u0020), Form1.Bp8crKQbU76Tg68kvQp(-1872685799 ^ -1872686181)))
					{
						goto IL_65;
					}
					text = this.RotationObj.CR._GetMacroKeybind(Form1.F05MgDCjWlGHhEaoK7T(\u0020));
					if (Form1.R25qmmCXN2J9g6WCi7p(text, ""))
					{
						num2 = 5;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387932858) + Form1.F05MgDCjWlGHhEaoK7T(\u0020) + vua32v5yjQhjRjK4YIO.BRA5TcZvlv(359120413 ^ 359118853));
						num2 = 6;
					}
				}
				Block_2:
				num = 2;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006B38 File Offset: 0x00004D38
		private void VumvwT5L8(object \u0020, LogEventArgs \u0020)
		{
			this.WriteLog(\u0020.Message);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00006B4C File Offset: 0x00004D4C
		public void WriteLog(string message)
		{
			int num = 8;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					string text;
					Form1.KSbjNact9uOZdZOHtsk ksbjNact9uOZdZOHtsk;
					switch (num2)
					{
					case 0:
						goto IL_1DA;
					case 1:
						Form1.rAuZQ69cjt14Aowg3ql(this.textConsole, text);
						num2 = 11;
						continue;
					case 2:
						Form1.eNBQOZ9uWGAashSF6eX(this.textConsole, this.textConsole.Lines.Skip(Form1.kwR7CG9xd04qDvwY5y6(this.textConsole).Length - 500).ToArray<string>());
						num2 = 12;
						continue;
					case 3:
						Form1.HQRrBT9PKpv5VrOTZd9(this, ksbjNact9uOZdZOHtsk, new object[]
						{
							message
						});
						num2 = 10;
						continue;
					case 4:
						return;
					case 5:
						if (this.random.Next(0, 10) == 10 && Form1.kwR7CG9xd04qDvwY5y6(this.textConsole).Length > 500)
						{
							num2 = 2;
							continue;
						}
						goto IL_A7;
					case 6:
						goto IL_171;
					case 7:
						goto IL_1AA;
					case 8:
						if (!Form1.R25qmmCXN2J9g6WCi7p(this.previousLog, message))
						{
							num2 = 7;
							continue;
						}
						goto IL_171;
					case 9:
						break;
					case 10:
						goto IL_19B;
					case 11:
						Directory.CreateDirectory(this.logpath);
						Form1.TQW4mo95LTjdIcaZtKR(Form1.ECjoxLCnKi1kGfesUXO(this.logpath, Form1.Tk6SeD9ENWhOjXlRDZj().ToString(Form1.Bp8crKQbU76Tg68kvQp(-235868112 ^ -235866252)) + vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1657092858 << 1 ^ -980782424)), text);
						num2 = 5;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 12:
						goto IL_A7;
					default:
						goto IL_1DA;
					}
					IL_50:
					text = string.Format(Form1.Bp8crKQbU76Tg68kvQp(~2095831454 ^ -2095832721), Form1.Tk6SeD9ENWhOjXlRDZj().ToString(Form1.Bp8crKQbU76Tg68kvQp(1657092858 << 1 ^ -980782372)), message);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_912464c7521643f2968751cbbc64f3cf != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_1DA:
					ksbjNact9uOZdZOHtsk = new Form1.KSbjNact9uOZdZOHtsk(this.WriteLog);
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_171:
					if (!Form1.JYJDmA9WailJDaAwjJU(this.textConsole))
					{
						goto IL_50;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
					{
						num2 = 0;
					}
				}
				IL_A7:
				this.previousLog = message;
				num = 4;
				continue;
				IL_19B:
				goto IL_A7;
			}
			return;
			IL_1AA:;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00006DC4 File Offset: 0x00004FC4
		private bool Wbxjf6xC1(string \u0020)
		{
			bool result;
			try
			{
				string u = Form1.ClqSlp9VPgVT4Q4yauG(\u0020);
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_C3;
					case 2:
						if (!this.uMJPEie7eU(u))
						{
							num = 4;
							continue;
						}
						goto IL_C3;
					case 3:
						goto IL_E0;
					case 4:
						this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(1881006439 >> 3 ^ 235125572), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(579026892 ^ 579025082), 16);
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
					IL_C3:
					result = true;
					num = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
					{
						num = 3;
					}
				}
				result = false;
				IL_E0:;
			}
			catch (Exception ex)
			{
				this.WriteLog(Form1.kOc5F69yJ86BNFa86ex(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~-1482987862 ^ 1482989239), Array.Empty<object>()));
				int num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e != 0)
				{
					num2 = 0;
				}
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.WriteLog(Form1.kOc5F69yJ86BNFa86ex(Form1.S4fI7n98VeDLqrofMh3(ex), Array.Empty<object>()));
						num2 = 2;
						continue;
					case 2:
						result = false;
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006F6C File Offset: 0x0000516C
		private void hiwbIxx8u()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.RotationObj != null)
					{
						goto IL_18ED;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
			return;
			IL_18ED:
			try
			{
				Form1.<>c__DisplayClass39_0 CS$<>8__locals1 = new Form1.<>c__DisplayClass39_0();
				int num3 = 46;
				for (;;)
				{
					int num4 = num3;
					Form1.<>c__DisplayClass39_2 CS$<>8__locals2;
					Form1.<>c__DisplayClass39_1 CS$<>8__locals3;
					for (;;)
					{
						int num5;
						int num6;
						Dictionary<string, RotationSetting>.Enumerator enumerator2;
						switch (num4)
						{
						case 0:
							goto IL_FC6;
						case 1:
							goto IL_106A;
						case 2:
							goto IL_F2A;
						case 3:
							CS$<>8__locals2.locale = Form1.VuXCjt9QTRVabsm0Q0q(this.guna2ComboBox1);
							num4 = 13;
							continue;
						case 4:
							if (!this.c87PPMGnNc(this.payload))
							{
								goto Block_19;
							}
							goto IL_1298;
						case 5:
						{
							bool flag = this.c4APrDbmcW(CS$<>8__locals3.spellId);
							num4 = 10;
							continue;
						}
						case 6:
						{
							Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(CS$<>8__locals3.row.Cells, Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134399170)), CS$<>8__locals3.spellId.ToString());
							string text;
							Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals3.row), Form1.Bp8crKQbU76Tg68kvQp(-1505789866 ^ -1505791944)), text);
							num4 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 != 0)
							{
								num4 = 0;
								continue;
							}
							continue;
						}
						case 7:
							num5++;
							num4 = 19;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
							{
								num4 = 10;
								continue;
							}
							continue;
						case 8:
						{
							Dictionary<string, bool>.Enumerator enumerator = this.RotationObj.CR._ModifierList.GetEnumerator();
							num4 = 23;
							continue;
						}
						case 9:
						{
							bool flag2;
							Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals2.row)[Form1.Bp8crKQbU76Tg68kvQp(-1860104403 ^ -1860106361)].Value = flag2;
							num4 = 43;
							continue;
						}
						case 10:
							goto IL_830;
						case 11:
							goto IL_EDF;
						case 12:
							CS$<>8__locals2.itemId = this.RotationObj.CR._ItemList[num5];
							num4 = 3;
							continue;
						case 13:
						{
							string value = this.rBWPY7olng(CS$<>8__locals2.itemId);
							num4 = 30;
							continue;
						}
						case 14:
						{
							bool flag;
							Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals3.row), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1681481889 ^ 1681483787)).Value = flag;
							num4 = 31;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
							{
								num4 = 6;
								continue;
							}
							continue;
						}
						case 15:
							goto IL_765;
						case 16:
							goto IL_16D1;
						case 17:
						{
							string text = this.dEAPtSbpdV(CS$<>8__locals3.spellId);
							num4 = 5;
							continue;
						}
						case 18:
							num6++;
							num4 = 57;
							continue;
						case 19:
							goto IL_16D1;
						case 20:
							CS$<>8__locals1.isWrath = this.RotationObj.CR.WrathRotation;
							num4 = 26;
							continue;
						case 21:
							goto IL_106A;
						case 22:
							break;
						case 23:
							try
							{
								for (;;)
								{
									IL_59C:
									Dictionary<string, bool>.Enumerator enumerator;
									int num7;
									KeyValuePair<string, bool> keyValuePair;
									if (!enumerator.MoveNext())
									{
										num7 = 1;
										if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
										{
											num7 = 1;
										}
									}
									else
									{
										keyValuePair = enumerator.Current;
										num7 = 2;
									}
									for (;;)
									{
										switch (num7)
										{
										default:
										{
											int num8;
											object obj = Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell), num8);
											string key = keyValuePair.Key;
											string value2 = this.USfPgt6bmR(key);
											bool flag3 = this.arHP0GxtL7(key);
											Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(obj), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1746511494 ^ -1746513584)), Form1.vPMnx19iyvGR7LPR7VD());
											Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(obj.Cells, Form1.Bp8crKQbU76Tg68kvQp(-902888658 ^ -902886638)), Form1.Bp8crKQbU76Tg68kvQp(-443850682 << 3 ^ 744164038));
											Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(obj), Form1.Bp8crKQbU76Tg68kvQp(2040894867 + -686633457 ^ 1354263550)), key);
											Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(obj), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~603785892 ^ -603783883)).Value = value2;
											Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(obj), Form1.Bp8crKQbU76Tg68kvQp(-1307524010 ^ -1307521840)).Value = Form1.Bp8crKQbU76Tg68kvQp(1905767247 ^ 1905769425);
											Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(obj.Cells, Form1.Bp8crKQbU76Tg68kvQp(2090212177 ^ 2090210299)), flag3);
											Form1.Pm37Al9AFmk2r038rJP(obj, Form1.Bp8crKQbU76Tg68kvQp(359120413 ^ 359118607) + key);
											num7 = 3;
											break;
										}
										case 1:
											goto IL_5EE;
										case 2:
										{
											int num8 = Form1.n0TXku93uqD8ldIhtAU(Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell));
											num7 = 0;
											if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e == 0)
											{
												num7 = 0;
											}
											break;
										}
										case 3:
											goto IL_59C;
										}
									}
								}
								IL_5EE:
								goto IL_645;
							}
							finally
							{
								Dictionary<string, bool>.Enumerator enumerator;
								((IDisposable)enumerator).Dispose();
							}
							goto IL_620;
						case 24:
							goto IL_17DC;
						case 25:
							num6 = 0;
							num4 = 37;
							continue;
						case 26:
							this.RotationObj.CR.PreCastTimeWindow = this.coHmct1JQ(this.textPreCast.Text, 100);
							this.RotationObj.CR._EnableManualCastQueue = this.toggleManualCastQueue.Checked;
							this.RotationObj.CR._AutoTab = Form1.hmoH8S9qggmufh0cX8H(this.toggleAutoTab);
							num4 = 21;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da != 0)
							{
								num4 = 32;
								continue;
							}
							continue;
						case 27:
							try
							{
								while (enumerator2.MoveNext())
								{
									DataGridViewRow dataGridViewRow;
									DataGridViewComboBoxCell dataGridViewComboBoxCell;
									DataGridViewCheckBoxCell dataGridViewCheckBoxCell;
									for (;;)
									{
										IL_D5E:
										KeyValuePair<string, RotationSetting> keyValuePair2 = enumerator2.Current;
										int index = Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSettings).Add();
										int num9 = 27;
										for (;;)
										{
											int num10 = num9;
											DataGridViewTextBoxCell dataGridViewTextBoxCell2;
											for (;;)
											{
												object obj2;
												DataGridViewTextBoxCell dataGridViewTextBoxCell;
												switch (num10)
												{
												case 0:
													goto IL_C57;
												case 1:
													if (obj2 != null)
													{
														num10 = 16;
														continue;
													}
													goto IL_D8B;
												case 2:
													Form1.ze7t0E9w2LsX5xTVcPJ(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow), 0), keyValuePair2.Value.DisplayName);
													num10 = 36;
													continue;
												case 3:
													goto IL_BFA;
												case 4:
												{
													int objectType = keyValuePair2.Value.ObjectType;
													num10 = 6;
													continue;
												}
												case 5:
												{
													object obj3 = Form1.mT7yA59fEsvRQPaqowU(dataGridViewComboBoxCell);
													object[] possibleValues = keyValuePair2.Value.PossibleValues;
													Form1.VTLYQo9Fvvx2PVEKJvR(obj3, possibleValues);
													num10 = 1;
													if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 != 0)
													{
														num10 = 0;
														continue;
													}
													continue;
												}
												case 6:
												{
													int objectType;
													switch (objectType)
													{
													case 1:
														goto IL_A1E;
													case 2:
														goto IL_C57;
													case 3:
														break;
													case 4:
														goto IL_BFA;
													default:
														num10 = 17;
														if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
														{
															num10 = 32;
															continue;
														}
														continue;
													}
													break;
												}
												case 7:
													Form1.QLQ5bP9OmmP2XdLtuP7(Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow), 1, dataGridViewTextBoxCell);
													num10 = 13;
													continue;
												case 8:
													goto IL_D8B;
												case 9:
													if (obj2 == null)
													{
														num10 = 39;
														continue;
													}
													goto IL_D09;
												case 10:
													goto IL_D4B;
												case 11:
													goto IL_971;
												case 12:
													goto IL_B2E;
												case 13:
													goto IL_AC1;
												case 14:
													goto IL_B6B;
												case 15:
													Form1.ze7t0E9w2LsX5xTVcPJ(dataGridViewCheckBoxCell, obj2);
													num10 = 14;
													if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb != 0)
													{
														num10 = 6;
														continue;
													}
													continue;
												case 16:
													dataGridViewComboBoxCell.Value = obj2;
													num10 = 29;
													continue;
												case 17:
													goto IL_A1E;
												case 18:
													goto IL_A9B;
												case 19:
													if (obj2 == null)
													{
														goto IL_CA0;
													}
													num10 = 8;
													if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
													{
														num10 = 15;
														continue;
													}
													continue;
												case 20:
													goto IL_B7A;
												case 21:
													goto IL_CA0;
												case 22:
													goto IL_D09;
												case 23:
													Form1.QLQ5bP9OmmP2XdLtuP7(Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow), 1, dataGridViewTextBoxCell2);
													num10 = 12;
													continue;
												case 24:
													goto IL_B7A;
												case 25:
													goto IL_B1A;
												case 26:
													break;
												case 27:
													dataGridViewRow = Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSettings)[index];
													num10 = 2;
													continue;
												case 28:
													obj2 = this.Qf3PeL7IS9(keyValuePair2.Key);
													num10 = 1;
													if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 != 0)
													{
														num10 = 4;
														continue;
													}
													continue;
												case 29:
													goto IL_B9C;
												case 30:
													goto IL_BCF;
												case 31:
													goto IL_AD4;
												case 32:
													goto IL_D2C;
												case 33:
													goto IL_D4B;
												case 34:
													Form1.qYVKgb9puAV9MnSNafW(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow), 0), keyValuePair2.Value.Description);
													num10 = 28;
													continue;
												case 35:
													goto IL_D5E;
												case 36:
													Form1.UkSXdn911SSi2g6aYmO(dataGridViewRow.Cells[0], keyValuePair2.Key);
													num10 = 34;
													continue;
												case 37:
													goto IL_AAE;
												case 38:
													Form1.aHxrU194hTCElcZl7GK(dataGridViewTextBoxCell2, 10);
													num10 = 23;
													continue;
												case 39:
													goto IL_BCF;
												default:
													goto IL_C57;
												}
												dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
												if (obj2 != null)
												{
													goto IL_AAE;
												}
												num10 = 8;
												if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 != 0)
												{
													num10 = 24;
													continue;
												}
												continue;
												IL_A1E:
												dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
												num10 = 9;
												continue;
												IL_AAE:
												Form1.ze7t0E9w2LsX5xTVcPJ(dataGridViewTextBoxCell, obj2);
												num10 = 33;
												continue;
												IL_B7A:
												Form1.ze7t0E9w2LsX5xTVcPJ(dataGridViewTextBoxCell, (string)keyValuePair2.Value.DefaultValue);
												num10 = 10;
												continue;
												IL_BCF:
												dataGridViewTextBoxCell2.Value = ((int)keyValuePair2.Value.DefaultValue).ToString();
												num10 = 31;
												continue;
												IL_BFA:
												dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
												num10 = 5;
												continue;
												IL_C57:
												dataGridViewCheckBoxCell = new DataGridViewCheckBoxCell();
												num10 = 19;
												if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 == 0)
												{
													num10 = 9;
													continue;
												}
												continue;
												IL_CA0:
												Form1.ze7t0E9w2LsX5xTVcPJ(dataGridViewCheckBoxCell, (bool)keyValuePair2.Value.DefaultValue);
												num10 = 25;
												if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
												{
													num10 = 21;
													continue;
												}
												continue;
												IL_D09:
												Form1.ze7t0E9w2LsX5xTVcPJ(dataGridViewTextBoxCell2, obj2);
												num10 = 4;
												if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
												{
													num10 = 18;
													continue;
												}
												continue;
												IL_D4B:
												Form1.aHxrU194hTCElcZl7GK(dataGridViewTextBoxCell, 100);
												num10 = 7;
												continue;
												IL_D8B:
												Form1.ze7t0E9w2LsX5xTVcPJ(dataGridViewComboBoxCell, (string)keyValuePair2.Value.DefaultValue);
												num10 = 11;
												if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
												{
													num10 = 8;
												}
											}
											IL_AD4:
											Form1.UkSXdn911SSi2g6aYmO(dataGridViewTextBoxCell2, Form1.Bp8crKQbU76Tg68kvQp(~-531755127 ^ 531757420));
											num9 = 38;
											continue;
											IL_A9B:
											goto IL_AD4;
										}
									}
									IL_971:
									Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow)[1] = dataGridViewComboBoxCell;
									IL_AC1:
									continue;
									IL_B1A:
									Form1.QLQ5bP9OmmP2XdLtuP7(Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow), 1, dataGridViewCheckBoxCell);
									continue;
									IL_B6B:
									goto IL_B1A;
									IL_B2E:
									IL_D2C:
									continue;
									IL_B9C:
									goto IL_971;
								}
								goto IL_17DC;
							}
							finally
							{
								((IDisposable)enumerator2).Dispose();
							}
							goto IL_E26;
						case 28:
							this.REbz8r6MU();
							num4 = 4;
							continue;
						case 29:
							num5 = 0;
							num4 = 4;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba == 0)
							{
								num4 = 16;
								continue;
							}
							continue;
						case 30:
						{
							bool flag2 = this.iHiP2WWDhA(CS$<>8__locals2.itemId);
							num4 = 8;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
							{
								num4 = 68;
								continue;
							}
							continue;
						}
						case 31:
							Form1.Pm37Al9AFmk2r038rJP(CS$<>8__locals3.row, Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(-1505789866 ^ -1505791854), CS$<>8__locals3.spellId.ToString()));
							num4 = 72;
							continue;
						case 32:
							this.RotationObj.CR._AttackPlayerNotInCombat = this.toggleAttackOutOfCombat.Checked;
							num4 = 44;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 == 0)
							{
								num4 = 51;
								continue;
							}
							continue;
						case 33:
						{
							int num11;
							CS$<>8__locals2.row = Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell), num11);
							num4 = 12;
							continue;
						}
						case 34:
							this.payload.RotationName = this.RotationObj.CR.RotationName;
							this.payload.ClassId = this.RotationObj.CR.ProfileClass;
							this.payload.EngineVersion = Form1.O8qjlc9LqAOYURuI3cp(Form1.z4yfFkC2QcWXXQG7aMx().GetName()).ToString();
							num4 = 56;
							continue;
						case 35:
							if (!this.i7hPmyi0ro(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, this.eQ0PRDEBNy(), Form1.Bp8crKQbU76Tg68kvQp(1765342390 ^ 1765340320), Form1.Bp8crKQbU76Tg68kvQp(-1388170447 ^ -1388170813))))
							{
								goto IL_F04;
							}
							num4 = 41;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df == 0)
							{
								num4 = 2;
								continue;
							}
							continue;
						case 36:
							goto IL_645;
						case 37:
							goto IL_73B;
						case 38:
							goto IL_111D;
						case 39:
							goto IL_17DC;
						case 40:
						{
							int num11 = Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell).Add();
							num4 = 33;
							continue;
						}
						case 41:
							goto IL_17C;
						case 42:
							goto IL_11FE;
						case 43:
							Form1.Pm37Al9AFmk2r038rJP(CS$<>8__locals2.row, Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(978854837 ^ 978856813), CS$<>8__locals2.itemId.ToString()));
							num4 = 61;
							continue;
						case 44:
						{
							int index2 = Form1.n0TXku93uqD8ldIhtAU(Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell));
							num4 = 67;
							continue;
						}
						case 45:
							goto IL_17C5;
						case 46:
							goto IL_161E;
						case 47:
							CS$<>8__locals3.locale = Form1.VuXCjt9QTRVabsm0Q0q(this.guna2ComboBox1);
							num4 = 17;
							continue;
						case 48:
						{
							string value;
							CS$<>8__locals2.row.Cells[Form1.Bp8crKQbU76Tg68kvQp(-1755352853 ^ -1755350907)].Value = value;
							num4 = 62;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 == 0)
							{
								num4 = 25;
								continue;
							}
							continue;
						}
						case 49:
							try
							{
								for (;;)
								{
									Dictionary<string, Macro>.Enumerator enumerator3;
									if (enumerator3.MoveNext())
									{
										goto IL_137F;
									}
									int num12 = 1;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 == 0)
									{
										num12 = 1;
									}
									int index3;
									for (;;)
									{
										IL_1365:
										switch (num12)
										{
										case 1:
											goto IL_1553;
										case 2:
											goto IL_137F;
										case 3:
											index3 = Form1.n0TXku93uqD8ldIhtAU(Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell));
											num12 = 0;
											if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da != 0)
											{
												num12 = 0;
												continue;
											}
											continue;
										}
										break;
									}
									IL_13C8:
									DataGridViewRow dataGridViewRow2 = Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell)[index3];
									KeyValuePair<string, Macro> keyValuePair3;
									string key2 = keyValuePair3.Key;
									string text2 = this.z32PsuBVWT(key2);
									bool flag4 = this.AXCPN1OpQT(key2);
									Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(dataGridViewRow2.Cells, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789419076 ^ -35552607 ^ 756277559)), Form1.YfVuPM9IOO9J2dZfQI1());
									Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow2)[Form1.Bp8crKQbU76Tg68kvQp(-1041647104 ^ -1041649092)], Form1.Bp8crKQbU76Tg68kvQp(-1183576799 ^ -1183578687));
									Form1.ug99IX99DgGu6ej4UWl(dataGridViewRow2.Cells, Form1.Bp8crKQbU76Tg68kvQp(-1696412362 - -137042106 ^ -1559368276)).Value = key2;
									Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow2), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1881006439 >> 3 ^ 235123778)), text2);
									Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(dataGridViewRow2.Cells, Form1.Bp8crKQbU76Tg68kvQp(951294359 ^ 47512224 ^ 979856305)), Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218524865));
									Form1.ou1LFn9CnJlfE3Jsl57(dataGridViewRow2)[Form1.Bp8crKQbU76Tg68kvQp(-1734223699 - -1503209248 ^ -231016601)].Value = flag4;
									Form1.Pm37Al9AFmk2r038rJP(dataGridViewRow2, Form1.Bp8crKQbU76Tg68kvQp(~2095831454 ^ -2095829361) + key2);
									continue;
									goto IL_13C8;
									IL_137F:
									keyValuePair3 = enumerator3.Current;
									num12 = 2;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
									{
										num12 = 3;
										goto IL_1365;
									}
									goto IL_1365;
								}
								IL_1553:
								goto IL_EDF;
							}
							finally
							{
								Dictionary<string, Macro>.Enumerator enumerator3;
								((IDisposable)enumerator3).Dispose();
							}
							goto IL_1585;
						case 50:
							this.payload.ToggleList = Form1.EgRD1y9R0gmcbIMx29L(this.RotationObj.CR._InGameToggleList);
							num4 = 52;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
							{
								num4 = 1;
								continue;
							}
							continue;
						case 51:
							goto IL_620;
						case 52:
							this.payload.Classic = (this.RotationObj.CR.TBCRotation || this.RotationObj.CR.WrathRotation);
							num4 = 34;
							continue;
						case 53:
							break;
						case 54:
							this.payload = new xcBF6XfpTXPOK6FjeY();
							num4 = 65;
							continue;
						case 55:
							goto IL_F04;
						case 56:
							goto IL_E26;
						case 57:
							goto IL_73B;
						case 58:
						{
							Dictionary<string, Macro>.Enumerator enumerator3 = this.RotationObj.CR._MacroList.GetEnumerator();
							num4 = 49;
							continue;
						}
						case 59:
							goto IL_15D9;
						case 60:
							this.payload.DebuffList = Form1.GSWLte9T8QA1V1QV6BA(this.RotationObj.CR._DebuffList);
							num4 = 69;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
							{
								num4 = 32;
								continue;
							}
							continue;
						case 61:
							Task.Run(new Func<Task>(CS$<>8__locals2.iwkcsGnRub));
							num4 = 7;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa != 0)
							{
								num4 = 2;
								continue;
							}
							continue;
						case 62:
							Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals2.row), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-185008287 ^ -185010201)), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1374435438 ^ -1374433524));
							num4 = 2;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
							{
								num4 = 9;
								continue;
							}
							continue;
						case 63:
							IL_39B:
							this.payload.ItemList = this.RotationObj.CR._ItemList.ToArray();
							num4 = 29;
							continue;
						case 64:
							this.payload.SpellList = this.RotationObj.CR._SpellList.ToArray();
							num4 = 25;
							continue;
						case 65:
							this.isPopulating = true;
							num4 = 35;
							continue;
						case 66:
							goto IL_F2A;
						case 67:
						{
							int index2;
							CS$<>8__locals3.row = this.DataGridSpell.Rows[index2];
							num4 = 9;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 != 0)
							{
								num4 = 75;
								continue;
							}
							continue;
						}
						case 68:
							Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals2.row), Form1.Bp8crKQbU76Tg68kvQp(1621542659 + 1028479281 ^ -1644943330)), Resources.inv_misc_questionmark);
							Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals2.row), Form1.Bp8crKQbU76Tg68kvQp(-1352111144 ^ -1352113180)), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-693910567 ^ -693908715));
							num4 = 15;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 != 0)
							{
								num4 = 15;
								continue;
							}
							continue;
						case 69:
							this.payload.UnitList = Form1.EgRD1y9R0gmcbIMx29L(this.RotationObj.CR._UnitList);
							num4 = 16;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 == 0)
							{
								num4 = 50;
								continue;
							}
							continue;
						case 70:
							goto IL_1267;
						case 71:
							this.ypdPc1AgQB();
							goto IL_1298;
						case 72:
							Task.Run(new Func<Task>(CS$<>8__locals3.kRXcYCrDWi));
							num4 = 18;
							continue;
						case 73:
							goto IL_183D;
						case 74:
							this.payload.BuffList = Form1.GSWLte9T8QA1V1QV6BA(this.RotationObj.CR._BuffList);
							num4 = 60;
							continue;
						case 75:
							CS$<>8__locals3.spellId = this.RotationObj.CR._SpellList[num6];
							num4 = 4;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
							{
								num4 = 47;
								continue;
							}
							continue;
						default:
							goto IL_FC6;
						}
						CS$<>8__locals2 = new Form1.<>c__DisplayClass39_2();
						CS$<>8__locals2.CS$<>8__locals2 = CS$<>8__locals1;
						num4 = 40;
						continue;
						IL_1585:
						if (Form1.M1NYUr9dQRdhwvcp9Ub(this.RotationObj.CR._ItemList) > 0)
						{
							goto IL_39B;
						}
						num4 = 42;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 != 0)
						{
							num4 = 19;
							continue;
						}
						continue;
						IL_106A:
						if (Form1.M1NYUr9dQRdhwvcp9Ub(this.RotationObj.CR._SpellList) > 0)
						{
							num4 = 64;
							continue;
						}
						goto IL_1585;
						IL_73B:
						if (num6 < Form1.M1NYUr9dQRdhwvcp9Ub(this.RotationObj.CR._SpellList))
						{
							goto Block_14;
						}
						goto IL_1585;
						IL_620:
						this.RotationObj.CR._AttackTargetNotInCombat = Form1.hmoH8S9qggmufh0cX8H(this.toggleAttackTargetNotInCombat);
						num4 = 54;
						continue;
						IL_645:
						if (Form1.bivtut9ZTVL3yFc6hxt(this.RotationObj.CR._RotationSettings) <= 0)
						{
							num4 = 39;
							continue;
						}
						goto IL_1267;
						IL_EDF:
						if (this.RotationObj.CR._ModifierList.Count > 0)
						{
							num4 = 8;
							continue;
						}
						goto IL_645;
						IL_11FE:
						if (Form1.Jf4yM19S9e6PagK7Ua6(this.RotationObj.CR._MacroList) > 0)
						{
							num4 = 58;
							continue;
						}
						goto IL_EDF;
						IL_16D1:
						if (num5 < Form1.M1NYUr9dQRdhwvcp9Ub(this.RotationObj.CR._ItemList))
						{
							num4 = 22;
							continue;
						}
						goto IL_11FE;
						IL_E26:
						this.payload.HealingRotation = Form1.vBOHXp9l4X6t1ftHRyp(this.RotationObj.CR);
						num4 = 28;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
						{
							num4 = 11;
							continue;
						}
						continue;
						IL_F04:
						this.toggleAutoBind.Checked = false;
						num4 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
						{
							num4 = 0;
							continue;
						}
						continue;
						IL_F2A:
						CS$<>8__locals3 = new Form1.<>c__DisplayClass39_1();
						num4 = 45;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
						{
							num4 = 15;
							continue;
						}
						continue;
						IL_FC6:
						Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals3.row)[Form1.Bp8crKQbU76Tg68kvQp(-87166655 + -2142521002 ^ 2065277457)], Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993703314));
						num4 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 != 0)
						{
							num4 = 14;
							continue;
						}
						continue;
						IL_1267:
						enumerator2 = this.RotationObj.CR._RotationSettings.GetEnumerator();
						num4 = 18;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
						{
							num4 = 27;
							continue;
						}
						continue;
						IL_1298:
						Task.Run(new Func<Task>(this.u1xEzCrJH1));
						num4 = 73;
						continue;
						IL_17DC:
						this.isPopulating = false;
						num4 = 57;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
						{
							num4 = 74;
						}
					}
					IL_17C:
					this.toggleAutoBind.Checked = true;
					num3 = 21;
					continue;
					Block_14:
					num3 = 66;
					continue;
					IL_765:
					Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(CS$<>8__locals2.row.Cells, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1897624240 ^ -1897626356)), CS$<>8__locals2.itemId.ToString());
					num3 = 48;
					continue;
					IL_830:
					Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(Form1.ou1LFn9CnJlfE3Jsl57(CS$<>8__locals3.row), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1933679734 ^ -1218001364 ^ -1004055952)), Resources.inv_misc_questionmark);
					num3 = 59;
					continue;
					Block_19:
					num3 = 71;
					continue;
					IL_111D:
					CS$<>8__locals1.IsTBC = this.RotationObj.CR.TBCRotation;
					num3 = 20;
					continue;
					IL_15D9:
					Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ug99IX99DgGu6ej4UWl(CS$<>8__locals3.row.Cells, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789516002)), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1640708702 ^ -1640706580));
					num3 = 6;
					continue;
					IL_161E:
					CS$<>8__locals1.<>4__this = this;
					num3 = 38;
					continue;
					IL_17C5:
					CS$<>8__locals3.CS$<>8__locals1 = CS$<>8__locals1;
					num3 = 44;
				}
				IL_183D:;
			}
			catch (Exception ex)
			{
				int num13 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 == 0)
				{
					num13 = 0;
				}
				for (;;)
				{
					switch (num13)
					{
					case 1:
						this.WriteLog(Form1.S4fI7n98VeDLqrofMh3(ex));
						this.isPopulating = false;
						num13 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
						{
							num13 = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000088D0 File Offset: 0x00006AD0
		private void REbz8r6MU()
		{
			int num = 15;
			for (;;)
			{
				int num2 = num;
				string text;
				ValueTuple<string, object> valueTuple;
				int num3;
				for (;;)
				{
					Macro macro;
					string text2;
					string text3;
					switch (num2)
					{
					case 0:
						goto IL_266;
					case 1:
						this.payload.AutoBind.Add(new string[]
						{
							Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553742565),
							text,
							((int)valueTuple.Item2).ToString(),
							""
						});
						num2 = 27;
						continue;
					case 2:
						break;
					case 3:
						text2 = macro.Example;
						num2 = 20;
						continue;
					case 4:
						return;
					case 5:
						this.payload.AutoBind.Add(new string[]
						{
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1858354135 - 1114350030 ^ 744002349),
							text,
							((int)valueTuple.Item2).ToString(),
							""
						});
						num2 = 2;
						continue;
					case 6:
						text2 = macro.SpellID.ToString();
						num2 = 17;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 7:
						goto IL_596;
					case 8:
						goto IL_2AA;
					case 9:
						goto IL_436;
					case 10:
						goto IL_142;
					case 11:
						goto IL_2BD;
					case 12:
						if (Form1.t0poRRCb3dy0hjmaGAe(macro.Example, Form1.Bp8crKQbU76Tg68kvQp(-309791748 - 2077333185 ^ 1907840099)))
						{
							num2 = 8;
							continue;
						}
						if (!Form1.t0poRRCb3dy0hjmaGAe(macro.Example, Form1.Bp8crKQbU76Tg68kvQp(~1005505369 ^ -1005503018)))
						{
							goto IL_142;
						}
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
						{
							num2 = 19;
							continue;
						}
						continue;
					case 13:
						goto IL_436;
					case 14:
						if (!this.toggleAutoBind.Checked)
						{
							return;
						}
						num2 = 21;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
						{
							num2 = 21;
							continue;
						}
						continue;
					case 15:
						this.payload.AutoBind = new List<string[]>();
						num2 = 14;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 != 0)
						{
							num2 = 14;
							continue;
						}
						continue;
					case 16:
						goto IL_1C8;
					case 17:
						goto IL_462;
					case 18:
						if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(1526149240 >> 4 ^ 95386147)))
						{
							goto IL_596;
						}
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 19:
						goto IL_2AA;
					case 20:
						if (Form1.t0poRRCb3dy0hjmaGAe(macro.Example, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(835315079 ^ 835316913)))
						{
							goto IL_2AA;
						}
						num2 = 30;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 == 0)
						{
							num2 = 17;
							continue;
						}
						continue;
					case 21:
						if (Form1.nv6npl9aKjnqZefm9T5(this.DataGridSpell) <= 0)
						{
							goto Block_5;
						}
						goto IL_2BD;
					case 22:
						goto IL_2AA;
					case 23:
						if (!Form1.t0poRRCb3dy0hjmaGAe(text, ""))
						{
							num2 = 3;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
							{
								num2 = 16;
								continue;
							}
							continue;
						}
						break;
					case 24:
						goto IL_517;
					case 25:
						goto IL_49B;
					case 26:
						goto IL_17C;
					case 27:
						break;
					case 28:
						text3 = Form1.Bp8crKQbU76Tg68kvQp(1858354135 - 1114350030 ^ 744002361);
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 29:
						goto IL_403;
					case 30:
						if (Form1.t0poRRCb3dy0hjmaGAe(macro.Example, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-256932895 ^ -256931161)))
						{
							goto IL_2AA;
						}
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
						{
							num2 = 12;
							continue;
						}
						continue;
					default:
						goto IL_266;
					}
					IL_98:
					num3++;
					num2 = 13;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_142:
					if (Form1.t0poRRCb3dy0hjmaGAe(macro.Example, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-185008287 ^ -185010461)))
					{
						num2 = 22;
						continue;
					}
					goto IL_462;
					IL_17C:
					macro = this.RotationObj.CR._MacroList[(string)valueTuple.Item2];
					num2 = 28;
					continue;
					IL_49B:
					if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(1765342390 ^ 1765340550)))
					{
						goto IL_98;
					}
					goto IL_17C;
					IL_596:
					if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(790722942 ^ 790720596)))
					{
						goto IL_49B;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_2AA:
					text3 = macro.Example;
					num2 = 6;
					continue;
					IL_2BD:
					num3 = 0;
					num2 = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
					IL_403:
					text = (string)Form1.pcPY5y9KGlwdMXMKiKS(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(this.DataGridSpell.Rows[num3]), 3));
					num2 = 23;
					continue;
					IL_266:
					goto IL_403;
					IL_436:
					if (num3 >= this.DataGridSpell.RowCount)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_462:
					this.payload.AutoBind.Add(new string[]
					{
						text3,
						text,
						text2,
						macro.SpellRank.ToString()
					});
					goto IL_98;
				}
				IL_1C8:
				text = Form1.ConvertToGameKey(text);
				valueTuple = this.kMtEcHIh0v(num3);
				num = 18;
				continue;
				Block_5:
				num = 24;
			}
			return;
			IL_517:;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00008EC0 File Offset: 0x000070C0
		private string G0uPWiK6gP(string \u0020, bool \u0020, string \u0020)
		{
			int num = 16;
			string text2;
			for (;;)
			{
				int num2 = num;
				string text;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_139;
					case 1:
						goto IL_39E;
					case 2:
						goto IL_187;
					case 3:
						goto IL_361;
					case 4:
						break;
					case 5:
						goto IL_2D0;
					case 6:
						text = Form1.KeGMkh9k3wWtJuTwR6v(text, Form1.Bp8crKQbU76Tg68kvQp(--2124070285 ^ 2124067943), "");
						num2 = 19;
						continue;
					case 7:
						goto IL_23B;
					case 8:
						goto IL_2D0;
					case 9:
						goto IL_C0;
					case 10:
						goto IL_3D3;
					case 11:
						goto IL_4CD;
					case 12:
						goto IL_187;
					case 13:
						goto IL_139;
					case 14:
						goto IL_4CD;
					case 15:
						if (!text.Contains(Form1.Bp8crKQbU76Tg68kvQp(1526149240 >> 4 ^ 95386259)))
						{
							goto IL_29A;
						}
						goto IL_427;
					case 16:
						text = Form1.C34fSD9eBoX3mFWsdS9(this.textGameFolder);
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 != 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					case 17:
						goto IL_37F;
					case 18:
						goto IL_4CD;
					case 19:
						goto IL_309;
					case 20:
						goto IL_338;
					case 21:
						goto IL_4CD;
					case 22:
						text2 = Path.Combine(text, Form1.Bp8crKQbU76Tg68kvQp(-1007749927 ^ -1007747347));
						goto IL_4CD;
					case 23:
						IL_1CB:
						if (!text.Contains(Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993703108)))
						{
							num2 = 13;
							continue;
						}
						break;
					case 24:
						goto IL_427;
					case 25:
						if (\u0020 == Form1.Bp8crKQbU76Tg68kvQp(790722942 ^ 790721406))
						{
							num2 = 26;
							continue;
						}
						goto IL_3D3;
					case 26:
						text2 = Path.Combine(text, Form1.Bp8crKQbU76Tg68kvQp(-1746511494 ^ -1746513040));
						num2 = 18;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					default:
						goto IL_139;
					}
					text = Form1.KeGMkh9k3wWtJuTwR6v(text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1905767247 ^ 1905769091), "");
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_C0:
					text2 = Form1.ECjoxLCnKi1kGfesUXO(text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(790722942 ^ 790721322));
					num2 = 11;
					continue;
					IL_3D3:
					if (!(\u0020 == Form1.Bp8crKQbU76Tg68kvQp(1765342390 ^ 1765340830)))
					{
						goto IL_C0;
					}
					num2 = 15;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 != 0)
					{
						num2 = 22;
						continue;
					}
					continue;
					IL_139:
					if (Form1.hQ2ZTb9rR1X4L1j8WZE(text, Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463907847)))
					{
						num2 = 6;
						continue;
					}
					goto IL_309;
					IL_187:
					if (Form1.t0poRRCb3dy0hjmaGAe(\u0020, Form1.Bp8crKQbU76Tg68kvQp(-2083830725 ^ -2083828205)))
					{
						goto IL_338;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_29A:
					if (!Form1.hQ2ZTb9rR1X4L1j8WZE(text, Form1.Bp8crKQbU76Tg68kvQp(-1007749927 ^ -1007747731)))
					{
						goto IL_1CB;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
					IL_427:
					text = Form1.KeGMkh9k3wWtJuTwR6v(text, Form1.Bp8crKQbU76Tg68kvQp(268206341 ^ 268208273), "");
					goto IL_29A;
					IL_2D0:
					text2 = Form1.ECjoxLCnKi1kGfesUXO(text, Form1.Bp8crKQbU76Tg68kvQp(-1939306647 + 173235911 ^ -1766069100));
					num2 = 14;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
					IL_309:
					if (\u0020)
					{
						num2 = 25;
						continue;
					}
					goto IL_39E;
					IL_338:
					text2 = Form1.ECjoxLCnKi1kGfesUXO(text, Form1.Bp8crKQbU76Tg68kvQp(-1939306647 + 173235911 ^ -1766069066));
					num2 = 21;
					continue;
					IL_39E:
					if (\u0020 == Form1.Bp8crKQbU76Tg68kvQp(1810931007 ^ 1810929471))
					{
						goto IL_361;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_4CD:
					if (!Form1.yPJO1R97UVt1wSq3mkW(text2))
					{
						num2 = 17;
						continue;
					}
					goto IL_385;
					IL_361:
					text2 = Form1.ECjoxLCnKi1kGfesUXO(text, Form1.Bp8crKQbU76Tg68kvQp(359120413 ^ 359117943));
					goto IL_4CD;
				}
				IL_23B:
				text = text.Replace(Form1.Bp8crKQbU76Tg68kvQp(-2018852357 ^ -2018850737), "");
				num = 23;
			}
			IL_37F:
			return "";
			IL_385:
			return Path.Combine(text2, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(464986539 ^ 464988947), \u0020);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000093B0 File Offset: 0x000075B0
		private bool c87PPMGnNc(xcBF6XfpTXPOK6FjeY \u0020)
		{
			try
			{
				this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(Form1.Bp8crKQbU76Tg68kvQp(-1696412362 - -137042106 ^ -1559367892), Form1.C34fSD9eBoX3mFWsdS9(this.textAddonName), Form1.Bp8crKQbU76Tg68kvQp(~-531755127 ^ 531757924)));
				int num = 18;
				int num2 = num;
				bool result2;
				for (;;)
				{
					HttpResponseMessage result;
					HttpStatusCode httpStatusCode;
					HC6h6qTeMKAGQ2QRdU hc6h6qTeMKAGQ2QRdU;
					string text2;
					switch (num2)
					{
					case 0:
						goto IL_685;
					case 1:
						goto IL_429;
					case 2:
						goto IL_3C4;
					case 3:
						goto IL_38C;
					case 4:
						if (Form1.EfLCsT90cDsYMKf0SMe(result))
						{
							num2 = 9;
							continue;
						}
						httpStatusCode = result.StatusCode;
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 != 0)
						{
							num2 = 31;
							continue;
						}
						continue;
					case 5:
						\u0020.RefreshRate = this.coHmct1JQ(this.textAddonRefreshRate.Text, 100);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						goto IL_3BA;
					case 7:
						if (hc6h6qTeMKAGQ2QRdU.Error == null)
						{
							goto IL_359;
						}
						num2 = 20;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
						{
							num2 = 24;
							continue;
						}
						continue;
					case 8:
						goto IL_7A6;
					case 9:
						hc6h6qTeMKAGQ2QRdU = JsonConvert.DeserializeObject<HC6h6qTeMKAGQ2QRdU>(Form1.Iao2ih9J9mkhFrdI4vw(result).ReadAsStringAsync().Result);
						num2 = 7;
						continue;
					case 10:
						this.a1iPoaymn2(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2102188928 ^ -2102189080), hc6h6qTeMKAGQ2QRdU.Error, 16);
						result2 = false;
						num2 = 6;
						continue;
					case 11:
						break;
					case 12:
					{
						HttpClient httpClient = new HttpClient();
						Form1.H3NFNt9NSNX8XWJpBNr(Form1.iqL1Pn96yiNTT5Ebe8R(httpClient), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~-531755127 ^ 531755322), Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1797548854 ^ 1797548516), Form1.Bp8crKQbU76Tg68kvQp(-1007749927 ^ -1007749571), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1755352853 ^ -1755351813)));
						httpClient.DefaultRequestHeaders.Add(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(457652205 ^ 457651895), Form1.UxjaDkCmutc5QJXE7Mj());
						string content2;
						StringContent content = new StringContent(content2, Form1.WMrrh19npvwTJaYhTvb(), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2066732216 ^ 2066735008));
						result = httpClient.PostAsync(icdoeGQQtZwolxBdqe.Qp6ArDHfx(), content).Result;
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					case 13:
						goto IL_65B;
					case 14:
						try
						{
							for (;;)
							{
								Dictionary<string, string>.Enumerator enumerator;
								if (enumerator.MoveNext())
								{
									goto IL_5EE;
								}
								int num3 = 7;
								int num4 = num3;
								KeyValuePair<string, string> keyValuePair;
								string text;
								byte[] array;
								string text3;
								for (;;)
								{
									IL_4A4:
									switch (num4)
									{
									case 1:
										goto IL_5A7;
									case 2:
										text = Form1.ECjoxLCnKi1kGfesUXO(text2, keyValuePair.Key);
										num4 = 5;
										if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 == 0)
										{
											num4 = 4;
											continue;
										}
										continue;
									case 3:
										goto IL_601;
									case 4:
										goto IL_5EE;
									case 5:
										Form1.Cj7omJ9mldksKr3kMYx(Form1.LUR5vMCNLulnOAoYLUD(text));
										num4 = 8;
										continue;
									case 6:
										goto IL_4D6;
									case 7:
										goto IL_629;
									case 8:
										array = Form1.YNLgDQ9H3N5sF2omwls(keyValuePair.Value);
										num4 = 0;
										if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
										{
											num4 = 0;
											continue;
										}
										continue;
									case 9:
										goto IL_5A7;
									}
									if (Form1.t0poRRCb3dy0hjmaGAe(Path.GetExtension(text).ToUpper(), Form1.Bp8crKQbU76Tg68kvQp(1881006439 >> 3 ^ 235122698)))
									{
										goto IL_601;
									}
									num4 = 1;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
									{
										num4 = 0;
										continue;
									}
									continue;
									IL_5A7:
									text3 = Form1.HVIBP89trVUInd61kbk(Form1.WMrrh19npvwTJaYhTvb(), array);
									num4 = 6;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
									{
										num4 = 5;
									}
								}
								IL_4D6:
								Form1.W3fsFw9YlpEyHyS6P5v(text, text3, Form1.WMrrh19npvwTJaYhTvb());
								continue;
								IL_601:
								File.WriteAllBytes(text, array);
								continue;
								IL_5EE:
								keyValuePair = enumerator.Current;
								num4 = 2;
								goto IL_4A4;
							}
							IL_629:;
						}
						finally
						{
							Dictionary<string, string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						goto IL_65B;
					case 15:
					{
						string content2 = Form1.MemHBp92QvU2RQyb8SZ(\u0020);
						num2 = 12;
						continue;
					}
					case 16:
						goto IL_7A6;
					case 17:
						\u0020.AddonName = this.textAddonName.Text;
						num2 = 5;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 18:
						\u0020.PixelLocation = this.comboPixelLocation.SelectedIndex;
						num2 = 17;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a != 0)
						{
							num2 = 15;
							continue;
						}
						continue;
					case 19:
						result2 = true;
						num2 = 21;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 20:
						goto IL_7F9;
					case 21:
						goto IL_192;
					case 22:
						Form1.Kkf2lh9gFFtl0X8OnPB(this.btnReGenerateAddon, false);
						num2 = 19;
						continue;
					case 23:
						goto IL_41C;
					case 24:
						if (Form1.t0poRRCb3dy0hjmaGAe(hc6h6qTeMKAGQ2QRdU.Error, ""))
						{
							num2 = 25;
							continue;
						}
						break;
					case 25:
						goto IL_359;
					case 26:
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(1308721404 ^ 1308724404));
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e != 0)
						{
							num2 = 23;
							continue;
						}
						continue;
					case 27:
						this.RotationObj._AddonBuiltSuccess = true;
						num2 = 22;
						continue;
					case 28:
						goto IL_1A1;
					case 29:
						goto IL_41C;
					case 30:
					{
						Dictionary<string, string>.Enumerator enumerator = hc6h6qTeMKAGQ2QRdU.Files.GetEnumerator();
						num2 = 14;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 31:
						if (httpStatusCode.ToString() == Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993702206))
						{
							num2 = 26;
							continue;
						}
						goto IL_429;
					default:
						goto IL_685;
					}
					this.WriteLog(hc6h6qTeMKAGQ2QRdU.Error);
					num2 = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
					{
						num2 = 9;
						continue;
					}
					continue;
					IL_359:
					if (hc6h6qTeMKAGQ2QRdU.Files != null)
					{
						num2 = 16;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					}
					IL_3C4:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--2124070285 ^ 2124068529));
					result2 = false;
					num2 = 3;
					continue;
					IL_7A6:
					text2 = this.G0uPWiK6gP(this.textAddonName.Text, this.RotationObj.CR.WrathRotation || this.RotationObj.CR.TBCRotation, Form1.dL7f3BCYsvs5WvdCOPK(this.comboGameVersion));
					if (text2 == "")
					{
						goto IL_1A1;
					}
					Form1.Cj7omJ9mldksKr3kMYx(text2);
					num2 = 30;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 != 0)
					{
						num2 = 21;
						continue;
					}
					continue;
					IL_41C:
					result2 = false;
					num2 = 20;
					continue;
					IL_429:
					object obj = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1654110737 ^ -473083753 ^ -2124749276);
					httpStatusCode = Form1.E0ad0c9Xp3Km6FgC2i7(result);
					this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(obj, httpStatusCode.ToString()));
					num2 = 29;
					continue;
					IL_65B:
					Form1.q054c59sprWGHa2INgJ(this.RotationObj, hc6h6qTeMKAGQ2QRdU.CheckR, hc6h6qTeMKAGQ2QRdU.CheckG, hc6h6qTeMKAGQ2QRdU.CheckB);
					num2 = 27;
					continue;
					IL_685:
					this.RotationObj._PixelLocation = this.comboPixelLocation.SelectedIndex;
					num2 = 15;
				}
				IL_192:
				return result2;
				IL_1A1:
				throw new Exception(Form1.Bp8crKQbU76Tg68kvQp(850579974 + 1765464631 ^ -1678923859));
				IL_38C:
				IL_3BA:
				IL_7F9:
				return result2;
			}
			catch (JsonReaderException)
			{
				int num5 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				default:
					this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-235868112 ^ -235864868));
					break;
				}
			}
			catch (AggregateException ex)
			{
				IEnumerator<Exception> enumerator2 = ex.InnerExceptions.GetEnumerator();
				try
				{
					for (;;)
					{
						if (Form1.AWksX3CaF27NUnPDnvS(enumerator2))
						{
							goto IL_8EA;
						}
						int num6 = 2;
						IL_892:
						switch (num6)
						{
						case 1:
						{
							IL_8EA:
							Exception ex2 = enumerator2.Current;
							this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387934568), Form1.S4fI7n98VeDLqrofMh3(ex2)));
							num6 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
							{
								num6 = 0;
								goto IL_892;
							}
							goto IL_892;
						}
						case 2:
							goto IL_90E;
						}
					}
					IL_90E:;
				}
				finally
				{
					if (enumerator2 != null)
					{
						Form1.TX4EfrCKNxMbkrcZehx(enumerator2);
						int num7 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						}
					}
				}
			}
			catch (Exception ex3)
			{
				int num8 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
				{
					num8 = 0;
				}
				switch (num8)
				{
				default:
					this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(567103098 ^ 567100234), Form1.S4fI7n98VeDLqrofMh3(ex3)));
					break;
				}
			}
			return false;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00009E0C File Offset: 0x0000800C
		private bool uMJPEie7eU(string \u0020)
		{
			int num = 10;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_A6F;
					case 2:
						if (!Form1.t0poRRCb3dy0hjmaGAe(this.G0uPWiK6gP(Form1.C34fSD9eBoX3mFWsdS9(this.textAddonName), false, Form1.dL7f3BCYsvs5WvdCOPK(this.comboGameVersion)), ""))
						{
							goto IL_4A;
						}
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 3:
						goto IL_995;
					case 4:
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-1199763274 ^ -1199759694));
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						if (!Form1.A8qQK69MwoTyxr0lqBr(Form1.C34fSD9eBoX3mFWsdS9(this.textAddonName)))
						{
							num2 = 2;
							continue;
						}
						goto IL_A36;
					case 6:
					{
						bool result;
						return result;
					}
					case 7:
						try
						{
							this.JJlPuoQns9(true);
							int num3 = 2;
							bool result;
							for (;;)
							{
								Type type;
								int num4;
								CompilerResults compilerResults;
								AssemblyName assemblyName;
								int num5;
								AssemblyName[] array;
								bool flag;
								switch (num3)
								{
								case 0:
									goto IL_7D4;
								case 1:
									goto IL_82B;
								case 2:
									Form1.D0SEq59GiW0DLYLsp4b(this.guna2TabControl1, 1);
									num3 = 9;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 != 0)
									{
										num3 = 9;
										continue;
									}
									continue;
								case 3:
									this.WriteLog(string.Format(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-582433477 + 1816872807 ^ 1234436974), Array.Empty<object>()));
									num3 = 35;
									continue;
								case 4:
									this.WriteLog(string.Format(Form1.Bp8crKQbU76Tg68kvQp(-1041647104 ^ -1041648224), type.Name));
									num4 = 10;
									break;
								case 5:
									this.RotationObj.CR.DoSpellCast += this.R9FGO3e4G;
									num3 = 16;
									continue;
								case 6:
									goto IL_7A6;
								case 7:
									goto IL_496;
								case 8:
								{
									IEnumerator enumerator = Form1.bQkfm0wcy2aHQGWvITH(Form1.eI4MZ4wPyCHku7j7w7Q(compilerResults));
									num3 = 42;
									continue;
								}
								case 9:
									new Dictionary<string, string>().Add(Form1.Bp8crKQbU76Tg68kvQp(359120413 ^ 359117081), Form1.Bp8crKQbU76Tg68kvQp(-1640708702 ^ -1640707452));
									num3 = 26;
									continue;
								case 10:
									goto IL_3A6;
								case 11:
									goto IL_275;
								case 12:
									try
									{
										List<string> list;
										list.Add(Form1.MZkk37C6N2MRGVPg3wl(Assembly.ReflectionOnlyLoad(Form1.QkNBnZ9vbk4MjBDixMT(assemblyName))));
										goto IL_7D4;
									}
									catch (Exception)
									{
										goto IL_7D4;
									}
									goto IL_3A6;
								case 13:
								{
									Type type2 = compilerResults.CompiledAssembly.GetType(type.FullName);
									num3 = 27;
									continue;
								}
								case 14:
									Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell).Clear();
									num3 = 40;
									continue;
								case 15:
									goto IL_275;
								case 16:
									this.RotationObj.CR.DoItemCast += this.sJfBx4rUu;
									num3 = 33;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 == 0)
									{
										num3 = 6;
										continue;
									}
									continue;
								case 17:
									goto IL_899;
								case 18:
									goto IL_1E0;
								case 19:
									this.JJlPuoQns9(false);
									num3 = 38;
									continue;
								case 20:
									goto IL_7C3;
								case 21:
								{
									List<string> list;
									CompilerParameters compilerParameters;
									Form1.knhZ8F9zsnwXBsJJ7Aa(Form1.Aw2LLk9bgSh17C9eowC(compilerParameters), Form1.EgRD1y9R0gmcbIMx29L(list));
									num3 = 32;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
									{
										num3 = 29;
										continue;
									}
									continue;
								}
								case 22:
									goto IL_23A;
								case 23:
									goto IL_4D6;
								case 24:
									num5 = 0;
									num3 = 28;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 == 0)
									{
										num3 = 28;
										continue;
									}
									continue;
								case 25:
									this.hiwbIxx8u();
									num3 = 30;
									continue;
								case 26:
								{
									CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider(new ProviderOptions(Form1.Pp4QKUC71vtkcGEBPyV(Path.GetDirectoryName(Form1.z4yfFkC2QcWXXQG7aMx().Location), Form1.Bp8crKQbU76Tg68kvQp(--1016420359 ^ 1016420149)), 0));
									CompilerParameters compilerParameters2 = new CompilerParameters();
									compilerParameters2.GenerateInMemory = true;
									Form1.HeD8SA9BKy4H7DNP3bb(compilerParameters2, false);
									CompilerParameters compilerParameters = compilerParameters2;
									AssemblyName[] referencedAssemblies = Form1.ewK0m59DeeWnE6RHcvv(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(33554481)).Assembly.GetReferencedAssemblies();
									List<string> list = new List<string>();
									array = referencedAssemblies;
									num3 = 23;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
									{
										num3 = 24;
										continue;
									}
									continue;
								}
								case 27:
								{
									Type type2;
									this.RotationObj = (RotationLab)Form1.Bh1gb9wupfk4LEKmKWc(type2);
									num3 = 16;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
									{
										num3 = 39;
										continue;
									}
									continue;
								}
								case 28:
									goto IL_82B;
								case 29:
									Form1.Kkf2lh9gFFtl0X8OnPB(this.toggleAutoBind, true);
									num3 = 22;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
									{
										num3 = 25;
										continue;
									}
									continue;
								case 30:
									flag = true;
									num3 = 15;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 == 0)
									{
										num3 = 11;
										continue;
									}
									continue;
								case 31:
								{
									List<string> list;
									list.Add(Form1.MZkk37C6N2MRGVPg3wl(Type.GetTypeFromHandle(Form1.pHJddX9jNf3s9CAWG8N(33554481)).Assembly));
									num3 = 11;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
									{
										num3 = 21;
										continue;
									}
									continue;
								}
								case 32:
								{
									CompilerParameters compilerParameters;
									CSharpCodeProvider csharpCodeProvider;
									compilerResults = Form1.bhmI45wWenwVdaFOg0o(csharpCodeProvider, compilerParameters, new string[]
									{
										\u0020
									});
									num4 = 44;
									break;
								}
								case 33:
									this.RotationObj.CR.DoMacroCast += this.WhODwOfTo;
									num3 = 14;
									continue;
								case 34:
									num5 = 0;
									goto IL_23A;
								case 35:
									goto IL_71A;
								case 36:
									goto IL_4D6;
								case 37:
									if (this.RotationObj == null)
									{
										goto IL_7A6;
									}
									num3 = 19;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
									{
										num3 = 2;
										continue;
									}
									continue;
								case 38:
									goto IL_519;
								case 39:
									this.RotationObj.CR.NewLogEvent += this.VumvwT5L8;
									num3 = 5;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 != 0)
									{
										num3 = 1;
										continue;
									}
									continue;
								case 40:
									Form1.T19uCXwVH28rOQKbQEo(this.DataGridSpell);
									num3 = 43;
									continue;
								case 41:
									Form1.sUjhuww8NXuIRvabnt2(this.RotationObj);
									num3 = 29;
									continue;
								case 42:
									try
									{
										IEnumerator enumerator;
										while (enumerator.MoveNext())
										{
											for (;;)
											{
												IL_600:
												CompilerError compilerError = (CompilerError)Form1.ocqRt1CLNxqeknLG33w(enumerator);
												int num6 = 1;
												if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 != 0)
												{
													num6 = 0;
												}
												for (;;)
												{
													switch (num6)
													{
													case 1:
														this.WriteLog(Form1.Q1mXpDw5XrPNoHCtUIq(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1218526815 ^ -1218523605), compilerError.Line, compilerError.ErrorText));
														num6 = 0;
														if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 == 0)
														{
															num6 = 0;
															continue;
														}
														continue;
													case 2:
														goto IL_600;
													}
													goto Block_41;
												}
											}
											Block_41:;
										}
										goto IL_71A;
									}
									finally
									{
										IEnumerator enumerator;
										IDisposable disposable = enumerator as IDisposable;
										int num7 = 1;
										if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
										{
											num7 = 0;
										}
										for (;;)
										{
											switch (num7)
											{
											case 1:
												if (disposable != null)
												{
													Form1.TX4EfrCKNxMbkrcZehx(disposable);
													num7 = 0;
													if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
													{
														num7 = 0;
														continue;
													}
													continue;
												}
												break;
											}
											break;
										}
									}
									goto IL_69E;
								case 43:
									Form1.gPQJPBwyEyMsJ2t08lw(this.DataGridSettings.Rows);
									Form1.T19uCXwVH28rOQKbQEo(this.DataGridSettings);
									num3 = 41;
									continue;
								case 44:
									goto IL_69E;
								default:
									goto IL_7D4;
								}
								num3 = num4;
								continue;
								IL_1E0:
								Type[] array2;
								type = array2[num5];
								num3 = 4;
								continue;
								IL_23A:
								if (num5 >= array2.Length)
								{
									num3 = 11;
									continue;
								}
								goto IL_1E0;
								IL_275:
								if (!flag)
								{
									num3 = 3;
									continue;
								}
								goto IL_71A;
								IL_3A6:
								if (Form1.t0poRRCb3dy0hjmaGAe(type.BaseType.ToString(), "RotationLabEngine.RotationLab"))
								{
									num3 = 13;
									continue;
								}
								num5++;
								num3 = 22;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a == 0)
								{
									num3 = 21;
									continue;
								}
								continue;
								IL_496:
								this.WriteLog(Form1.kOc5F69yJ86BNFa86ex(Form1.Bp8crKQbU76Tg68kvQp(1691472209 >> 1 ^ 845735932), Array.Empty<object>()));
								num3 = 8;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 != 0)
								{
									num3 = 4;
									continue;
								}
								continue;
								IL_69E:
								if (Form1.zOqwP4wEDEGDTn6Rb4q(Form1.eI4MZ4wPyCHku7j7w7Q(compilerResults)) <= 0)
								{
									num3 = 23;
									continue;
								}
								goto IL_496;
								IL_4D6:
								Type[] array3 = Form1.qrpKgdwxqN1NdIQdKHp(compilerResults.CompiledAssembly);
								flag = false;
								array2 = array3;
								num3 = 34;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
								{
									num3 = 22;
									continue;
								}
								continue;
								IL_71A:
								this.RotationIsLoading = false;
								num3 = 37;
								continue;
								IL_7A6:
								result = false;
								num3 = 1;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 == 0)
								{
									num3 = 17;
									continue;
								}
								continue;
								IL_7C3:
								assemblyName = array[num5];
								num3 = 12;
								continue;
								IL_82B:
								if (num5 >= array.Length)
								{
									num3 = 31;
									continue;
								}
								goto IL_7C3;
								IL_7D4:
								num5++;
								num3 = 1;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
								{
									num3 = 0;
								}
							}
							IL_519:
							result = true;
							IL_899:
							return result;
						}
						catch (Exception ex)
						{
							int num8 = 1;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 == 0)
							{
								num8 = 2;
							}
							bool result;
							for (;;)
							{
								switch (num8)
								{
								case 1:
									result = false;
									num8 = 4;
									continue;
								case 2:
									this.WriteLog(Form1.kOc5F69yJ86BNFa86ex(Form1.Bp8crKQbU76Tg68kvQp(835315079 ^ 835319207), Array.Empty<object>()));
									this.WriteLog(string.Format(Form1.S4fI7n98VeDLqrofMh3(ex), Array.Empty<object>()));
									num8 = 3;
									continue;
								case 3:
									this.RotationObj = null;
									num8 = 0;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
									{
										num8 = 0;
										continue;
									}
									continue;
								case 4:
									goto IL_986;
								case 5:
									this.RotationIsLoading = false;
									num8 = 1;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
									{
										num8 = 1;
										continue;
									}
									continue;
								}
								this.JJlPuoQns9(true);
								num8 = 5;
							}
							IL_986:
							return result;
						}
						goto IL_995;
					case 8:
						goto IL_A36;
					case 9:
						return true;
					case 10:
						if (this.RotationIsLoading)
						{
							num2 = 8;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
							{
								num2 = 9;
								continue;
							}
							continue;
						}
						else
						{
							this.RotationIsLoading = true;
							num2 = 5;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					goto Block_1;
					IL_995:
					if (Form1.t0poRRCb3dy0hjmaGAe(this.G0uPWiK6gP(Form1.C34fSD9eBoX3mFWsdS9(this.textAddonName), true, Form1.dL7f3BCYsvs5WvdCOPK(this.comboGameVersion)), ""))
					{
						num2 = 4;
						continue;
					}
					break;
					IL_A36:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(145144672 << 4 ^ -1972651164));
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 != 0)
					{
						num2 = 0;
					}
				}
				IL_4A:
				num = 7;
			}
			Block_1:
			goto IL_AAF;
			IL_A6F:
			this.RotationIsLoading = false;
			return false;
			IL_AAF:
			this.RotationIsLoading = false;
			return false;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000A970 File Offset: 0x00008B70
		private void ypdPc1AgQB()
		{
			Form1.gPQJPBwyEyMsJ2t08lw(this.DataGridSpell.Rows);
			Form1.T19uCXwVH28rOQKbQEo(this.DataGridSpell);
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
			{
				num = 1;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					this.DataGridSettings.Rows.Clear();
					num = 3;
					continue;
				case 2:
					this.JJlPuoQns9(true);
					num = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				case 3:
					Form1.T19uCXwVH28rOQKbQEo(this.DataGridSettings);
					num = 4;
					continue;
				case 4:
					this.RotationObj = null;
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 5:
					return;
				}
				Form1.Kkf2lh9gFFtl0X8OnPB(this.toggleAutoBind, false);
				num = 2;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000AA6C File Offset: 0x00008C6C
		private void rN2P5SD3kk(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000AA70 File Offset: 0x00008C70
		private bool DBLPxXeTOK(bool \u0020)
		{
			int num = 2;
			string text;
			for (;;)
			{
				int num2 = num;
				Process process;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_16E;
					case 1:
						MessageBox.Show(Form1.Bp8crKQbU76Tg68kvQp(185404423 + 1853889833 ^ 2039295576), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1041647104 ^ -1041651094), MessageBoxButtons.OK, MessageBoxIcon.Hand);
						num2 = 16;
						continue;
					case 2:
						if (Form1.AZK5cIwqqmGNHPDYmtM(Form1.Bp8crKQbU76Tg68kvQp(1858354135 - 1114350030 ^ 744000091)))
						{
							goto IL_C5;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						Form1.MXxNjTwhZN9psiFirA3(process).ReadToEnd();
						num2 = 9;
						continue;
					case 4:
						if (\u0020)
						{
							num2 = 7;
							continue;
						}
						goto IL_1A3;
					case 5:
						Form1.sM0Yavww8yIdf81aRXq(process);
						num2 = 12;
						continue;
					case 6:
						Form1.qmbWLhwoeZnX4ZBTNau(Form1.gSCRVtwdibsMxy3ZA7F(process), Form1.Bp8crKQbU76Tg68kvQp(-2083830725 ^ -2083826583));
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 7:
						goto IL_185;
					case 8:
						if (\u0020)
						{
							num2 = 13;
							continue;
						}
						goto IL_1C1;
					case 9:
						Form1.dVsfuOwS4qFf6ikHRiY(process);
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 10:
						break;
					case 11:
						goto IL_1C1;
					case 12:
						text = Form1.GVh1f2wAPaF4Ufp7Ub4(process.StandardOutput);
						num2 = 3;
						continue;
					case 13:
						Form1.nJ9YMdw3yyHE0IeE5vC(Form1.gSCRVtwdibsMxy3ZA7F(process), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1050340572 ^ -1050344516));
						num2 = 10;
						continue;
					case 14:
						process.StartInfo.RedirectStandardOutput = true;
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 15:
						goto IL_60;
					case 16:
						return false;
					default:
						goto IL_16E;
					}
					IL_EA:
					Form1.lCLPn4wQmOtT0KkyGgm(Form1.gSCRVtwdibsMxy3ZA7F(process), ProcessWindowStyle.Hidden);
					Form1.gSCRVtwdibsMxy3ZA7F(process).UseShellExecute = false;
					num2 = 14;
					continue;
					IL_1C1:
					Form1.nJ9YMdw3yyHE0IeE5vC(Form1.gSCRVtwdibsMxy3ZA7F(process), Form1.Bp8crKQbU76Tg68kvQp(-161182833 ^ -161178845));
					goto IL_EA;
					IL_16E:
					Form1.sI79t2wCWsu7Tumo2yW(Form1.gSCRVtwdibsMxy3ZA7F(process), true);
					num2 = 15;
				}
				IL_60:
				Form1.rCn5X2w9u3TSRhNXPde(process.StartInfo, true);
				num = 5;
				continue;
				IL_C5:
				process = new Process();
				num = 6;
			}
			return false;
			IL_185:
			return Form1.hQ2ZTb9rR1X4L1j8WZE(text, Form1.Bp8crKQbU76Tg68kvQp(-613886095 << 1 ^ -1227768282));
			IL_1A3:
			return Form1.hQ2ZTb9rR1X4L1j8WZE(text, Form1.Bp8crKQbU76Tg68kvQp(1654110737 ^ -473083753 ^ -2124744078));
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000AD34 File Offset: 0x00008F34
		private void JJlPuoQns9(bool \u0020)
		{
			int num = 19;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_24E;
					case 2:
						Form1.UItrdLwU1vRfSfQhlDs(this.statusIcon, Form1.iAw4jCwZ2rrmM3NSXjo());
						num2 = 21;
						continue;
					case 3:
						Form1.Sv1WQbwf5nFmk6BuCdD(this.btnStartStop, Form1.Y1UIkkw4SWDmFnSC63U(255, 77, 165));
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						if (this.PulseTimer.Enabled)
						{
							goto Block_2;
						}
						goto IL_2C9;
					case 5:
						goto IL_CC;
					case 6:
						Form1.iSOs1Zwpnwp4TrgI3NY(this.btnStartStop, Form1.Bp8crKQbU76Tg68kvQp(1526149240 >> 4 ^ 95380141));
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 7:
						return;
					case 8:
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-87166655 + -2142521002 ^ 2065283859));
						num2 = 6;
						continue;
					case 9:
						Form1.PNVsMCw1D5ZEZdSk8wJ(this.PulseTimer, false);
						num2 = 17;
						continue;
					case 10:
						goto IL_2C9;
					case 11:
						Form1.Sv1WQbwf5nFmk6BuCdD(this.btnStartStop, Form1.Y1UIkkw4SWDmFnSC63U(0, 230, 27));
						num2 = 23;
						continue;
					case 12:
						Form1.vLsqXrwIGmhVc2NjlCh(this.btnStartStop, true);
						num2 = 22;
						continue;
					case 13:
						this.btnStartStop.FillColor = Color.FromArgb(255, 77, 133);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 14:
						if (this.RotationObj != null)
						{
							num2 = 4;
							continue;
						}
						return;
					case 15:
						Form1.iSOs1Zwpnwp4TrgI3NY(this.btnStartStop, Form1.Bp8crKQbU76Tg68kvQp(-160910942 << 4 ^ 1720388438));
						num2 = 8;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
						{
							num2 = 20;
							continue;
						}
						continue;
					case 16:
						Form1.vLsqXrwIGmhVc2NjlCh(this.btnStartStop, false);
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 17:
						goto IL_169;
					case 18:
						Form1.v5COPWwi2eCOL5fBEpU(this.textStatus, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(212924216 ^ 212919824));
						num2 = 16;
						continue;
					case 19:
						if (this.RotationObj != null)
						{
							this.textStatus.Text = this.RotationObj.CR.RotationName;
							num2 = 12;
							continue;
						}
						num2 = 18;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a == 0)
						{
							num2 = 12;
							continue;
						}
						continue;
					case 20:
						Form1.b0EJIhwOxZFnSyTHl3t(this.btnStartStop, Form1.Y1UIkkw4SWDmFnSC63U(0, 201, 145));
						num2 = 11;
						continue;
					case 21:
						goto IL_2A3;
					case 22:
						goto IL_2A3;
					case 23:
						Form1.UItrdLwU1vRfSfQhlDs(this.statusIcon, Resources.pause);
						num2 = 7;
						continue;
					}
					goto Block_1;
					IL_24E:
					if (this.PulseTimer.Enabled)
					{
						num2 = 9;
						continue;
					}
					return;
					IL_2A3:
					if (!\u0020)
					{
						num2 = 14;
						continue;
					}
					goto IL_24E;
					IL_2C9:
					Form1.PNVsMCw1D5ZEZdSk8wJ(this.PulseTimer, true);
					num2 = 8;
				}
				Block_2:
				num = 5;
				continue;
				IL_169:
				this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-185008287 ^ -185012687));
				num = 15;
			}
			Block_1:
			Form1.UItrdLwU1vRfSfQhlDs(this.statusIcon, Form1.UW559kwFspTgAGXicuC());
			IL_CC:;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000B0F0 File Offset: 0x000092F0
		private void q0bPVKEo5e(object \u0020, EventArgs \u0020)
		{
			this.textConsole.Text = "";
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000B10C File Offset: 0x0000930C
		private void WoPPyq4IqG(object \u0020, EventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.RotationObj == null)
					{
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						this.JJlPuoQns9(Form1.SwdjYEwTTDc7l6IAKcI(this.PulseTimer));
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				case 2:
					return;
				case 3:
					return;
				}
				this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-886904286 ^ -886903478), Form1.Bp8crKQbU76Tg68kvQp(2090212177 ^ 2090207975), 16);
				num2 = 3;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000B1E4 File Offset: 0x000093E4
		private void WQxP8vS9pB()
		{
			int num = 8;
			int num2 = num;
			for (;;)
			{
				InA3Q4LFDQmiFopNqj inA3Q4LFDQmiFopNqj;
				switch (num2)
				{
				case 0:
					goto IL_B2;
				case 1:
					if (inA3Q4LFDQmiFopNqj == null)
					{
						goto IL_10D;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_12C;
				case 3:
					goto IL_10D;
				case 4:
					goto IL_121;
				case 5:
					break;
				case 6:
					goto IL_140;
				case 7:
					goto IL_10D;
				case 8:
					if (!(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(-865714864 ^ -865714302), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~-1482987862 ^ 1482988465), "") != ""))
					{
						num2 = 7;
						continue;
					}
					goto IL_140;
				case 9:
					break;
				default:
					goto IL_B2;
				}
				IL_44:
				Application.Exit();
				num2 = 4;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
				{
					num2 = 4;
					continue;
				}
				continue;
				IL_B2:
				yQGkVJcOSOQdjuwds7e.AuthenticatedUserData = inA3Q4LFDQmiFopNqj;
				num2 = 3;
				continue;
				IL_10D:
				if (yQGkVJcOSOQdjuwds7e.AuthenticatedUserData == null)
				{
					num2 = 9;
					continue;
				}
				goto IL_12C;
				IL_140:
				inA3Q4LFDQmiFopNqj = icdoeGQQtZwolxBdqe.xD5ivBQoQ(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(-289990612 ^ 1144181582 ^ -1434072656), Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387933884), ""));
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_12C:
				if (yQGkVJcOSOQdjuwds7e.AuthenticatedUserData.Error == null)
				{
					break;
				}
				goto IL_44;
			}
			IL_121:
			this.cYNEF6qcZK();
			return;
			goto IL_121;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000B39C File Offset: 0x0000959C
		private void q8VPqoL1QU(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000B3A0 File Offset: 0x000095A0
		private Task<string> pusPdeMv5g()
		{
			Form1.<GetRandomAddonName>d__54 <GetRandomAddonName>d__;
			<GetRandomAddonName>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetRandomAddonName>d__.<>4__this = this;
			<GetRandomAddonName>d__.<>1__state = -1;
			<GetRandomAddonName>d__.<>t__builder.Start<Form1.<GetRandomAddonName>d__54>(ref <GetRandomAddonName>d__);
			return <GetRandomAddonName>d__.<>t__builder.Task;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000B3E4 File Offset: 0x000095E4
		private void a1iPoaymn2(string \u0020, string \u0020, MessageDialogIcon \u0020)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.guna2MessageDialog1.Text = \u0020;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					this.guna2MessageDialog1.Caption = \u0020;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					Form1.J9JiEZwRU7OOsHQqQGj(this.guna2MessageDialog1, \u0020);
					num2 = 2;
					continue;
				}
				break;
			}
			Form1.wBtRtdwLtN599Ci7kp7(this.guna2MessageDialog1);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000B490 File Offset: 0x00009690
		public string detectGameFolder()
		{
			int num = 7;
			int num2 = num;
			string text;
			for (;;)
			{
				int num3;
				string[] array;
				switch (num2)
				{
				case 1:
					if (!Form1.yPJO1R97UVt1wSq3mkW(text))
					{
						num2 = 3;
						continue;
					}
					return text;
				case 2:
					goto IL_A0;
				case 3:
					num3++;
					goto IL_180;
				case 4:
					goto IL_180;
				case 5:
					return text;
				case 6:
					num3 = 0;
					num2 = 4;
					continue;
				case 7:
					array = new string[]
					{
						Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679323996),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1005505369 ^ -1005508986),
						Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510578161),
						Form1.Bp8crKQbU76Tg68kvQp(1858354135 - 1114350030 ^ 743999639),
						Form1.Bp8crKQbU76Tg68kvQp(1767032709 ^ 1767036277),
						Form1.Bp8crKQbU76Tg68kvQp(1633072087 ^ 1633067155),
						Form1.Bp8crKQbU76Tg68kvQp(-789513950 ^ -789517638),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1621542659 + 1028479281 ^ -1644940322),
						Form1.Bp8crKQbU76Tg68kvQp(-789513950 ^ -789517056)
					};
					num2 = 6;
					continue;
				}
				IL_7F:
				text = array[num3];
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_180:
				if (num3 < array.Length)
				{
					goto IL_7F;
				}
				num2 = 2;
			}
			return text;
			IL_A0:
			return "";
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000B640 File Offset: 0x00009840
		private void Ou9P3PUgcH(object \u0020, EventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				{
					CommonOpenFileDialog commonOpenFileDialog;
					commonOpenFileDialog.InitialDirectory = Form1.Bp8crKQbU76Tg68kvQp(1767032709 ^ 1767035871);
					num2 = 3;
					break;
				}
				case 2:
				{
					CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
					{
						num2 = 1;
					}
					break;
				}
				case 3:
				{
					CommonOpenFileDialog commonOpenFileDialog;
					commonOpenFileDialog.IsFolderPicker = true;
					if (Form1.Wy8KOUwlyVZy2EfGZpX(commonOpenFileDialog) != 1)
					{
						return;
					}
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 4:
				{
					CommonOpenFileDialog commonOpenFileDialog;
					Form1.v5COPWwi2eCOL5fBEpU(this.textGameFolder, commonOpenFileDialog.FileName);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000B720 File Offset: 0x00009920
		private void nxaPQhW9Tc()
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					ListViewItem listViewItem;
					string u = Path.Combine(Form1.hYHrEswknLW9n6JvQfY(Form1.SnLjCmweoIc1jgcm8Oi(listViewItem.SubItems, 1)), Form1.nEGpV3wrtMWl4QMjGvA(listViewItem));
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				case 2:
				{
					string u;
					this.Wbxjf6xC1(u);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 4:
					if (Form1.r7R9ASwa70Hp12oeIES(this.listView1).Count <= 0)
					{
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						ListViewItem listViewItem = Form1.MgOsqHwKnr0xGhdS5E0(this.listView1.SelectedItems, 0);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000B824 File Offset: 0x00009A24
		private void Q5cPCli6Fm()
		{
			if (this.listView1.SelectedItems.Count > 0)
			{
				Form1.r7R9ASwa70Hp12oeIES(this.listView1)[0].Remove();
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 == 0)
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
					this.zHaPASVJsS();
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 == 0)
					{
						num = 1;
					}
				}
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		private void iROP9qRNDm(object \u0020, EventArgs \u0020)
		{
			this.nxaPQhW9Tc();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		private void aYGPw86yRS(string \u0020, bool \u0020)
		{
			int num = 1;
			for (;;)
			{
				int num2 = num;
				string b;
				int num3;
				for (;;)
				{
					string fileName;
					switch (num2)
					{
					case 0:
						goto IL_1A2;
					case 1:
						if (Form1.Dk5U3Pw2eyFPjgn6a6Q(Form1.bS0UYLw7HwicoyCY5HU(this.listView1)) <= 0)
						{
							num2 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 == 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_C6;
					case 3:
					{
						string text = Form1.LUR5vMCNLulnOAoYLUD(\u0020);
						string[] items = new string[]
						{
							text
						};
						num2 = 11;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
						{
							num2 = 12;
							continue;
						}
						continue;
					}
					case 4:
						goto IL_E6;
					case 5:
						return;
					case 6:
						goto IL_13A;
					case 7:
						return;
					case 8:
						if (\u0020)
						{
							goto IL_C6;
						}
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 9:
						goto IL_13A;
					case 10:
						if (Form1.jaVJwbwNH3YGplDDAt0(\u0020) == b)
						{
							num2 = 11;
							continue;
						}
						num3++;
						num2 = 9;
						continue;
					case 11:
						Form1.e7YffHw6rpIQnREW2gH(this.listView1.Items, num3).Selected = true;
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 == 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 12:
					{
						string[] items;
						Form1.rSbKNrw0JjGG0pTWuWN(Form1.OIRLQ6wnLJqC8sB9M1D(Form1.bS0UYLw7HwicoyCY5HU(this.listView1), fileName)).AddRange(items);
						num2 = 8;
						continue;
					}
					case 13:
						goto IL_156;
					case 14:
						break;
					default:
						goto IL_1A2;
					}
					num3 = 0;
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
					IL_B4:
					fileName = Path.GetFileName(\u0020);
					num2 = 3;
					continue;
					IL_1A2:
					goto IL_B4;
					IL_13A:
					if (num3 >= this.listView1.Items.Count)
					{
						goto IL_B4;
					}
					break;
					IL_C6:
					this.zHaPASVJsS();
					num2 = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
					{
						num2 = 3;
					}
				}
				IL_E6:
				b = Form1.ECjoxLCnKi1kGfesUXO(Form1.SnLjCmweoIc1jgcm8Oi(this.listView1.Items[num3].SubItems, 1).Text, Form1.nEGpV3wrtMWl4QMjGvA(Form1.e7YffHw6rpIQnREW2gH(Form1.bS0UYLw7HwicoyCY5HU(this.listView1), num3))).ToLower();
				num = 10;
			}
			return;
			IL_156:;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000BB40 File Offset: 0x00009D40
		private void zHaPASVJsS()
		{
			int num = 10;
			for (;;)
			{
				int num2 = num;
				List<string> list;
				for (;;)
				{
					int num3;
					string text;
					switch (num2)
					{
					case 1:
						goto IL_1C8;
					case 3:
						num3++;
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 4:
					{
						string item = Form1.ECjoxLCnKi1kGfesUXO(Form1.SnLjCmweoIc1jgcm8Oi(Form1.rSbKNrw0JjGG0pTWuWN(Form1.e7YffHw6rpIQnREW2gH(Form1.bS0UYLw7HwicoyCY5HU(this.listView1), num3)), 1).Text, Form1.e7YffHw6rpIQnREW2gH(this.listView1.Items, num3).Text).ToLower();
						num2 = 11;
						continue;
					}
					case 5:
						goto IL_9C;
					case 6:
						goto IL_9C;
					case 7:
						Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(-865714864 ^ -865720028), Form1.Bp8crKQbU76Tg68kvQp(212924216 ^ 212919230), text);
						num2 = 8;
						continue;
					case 8:
						goto IL_E1;
					case 9:
						if (Form1.Dk5U3Pw2eyFPjgn6a6Q(Form1.bS0UYLw7HwicoyCY5HU(this.listView1)) > 0)
						{
							goto IL_1C8;
						}
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 10:
						goto IL_7D;
					case 11:
					{
						string item;
						list.Add(item);
						num2 = 3;
						continue;
					}
					}
					IL_190:
					text = Form1.iL51BVQjDDFv8h51MTQ(Form1.Bp8crKQbU76Tg68kvQp(-1307524010 ^ -1307520968), Form1.EgRD1y9R0gmcbIMx29L(list));
					num2 = 7;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_9C:
					if (num3 < Form1.Dk5U3Pw2eyFPjgn6a6Q(Form1.bS0UYLw7HwicoyCY5HU(this.listView1)))
					{
						goto Block_4;
					}
					goto IL_190;
					IL_1C8:
					num3 = 0;
					num2 = 6;
				}
				IL_7D:
				list = new List<string>();
				num = 9;
				continue;
				Block_4:
				num = 4;
			}
			IL_E1:
			this.NoCYLbiqG();
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000BD54 File Offset: 0x00009F54
		private void VTVPhEoam5(object \u0020, EventArgs \u0020)
		{
			int num = 2;
			for (;;)
			{
				int num2 = num;
				CommonOpenFileDialog commonOpenFileDialog;
				IEnumerator<string> enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1CE;
					case 1:
						break;
					case 2:
						commonOpenFileDialog = new CommonOpenFileDialog();
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_3C;
					case 4:
						Form1.I3iPMqwHpab4n2JrZOx(commonOpenFileDialog, false);
						num2 = 7;
						continue;
					case 5:
						try
						{
							for (;;)
							{
								if (Form1.AWksX3CaF27NUnPDnvS(enumerator))
								{
									goto IL_A0;
								}
								int num3 = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 != 0)
								{
									num3 = 1;
								}
								IL_8A:
								switch (num3)
								{
								default:
								{
									IL_A0:
									string u = enumerator.Current;
									num3 = 2;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a == 0)
									{
										num3 = 1;
										goto IL_8A;
									}
									goto IL_8A;
								}
								case 1:
									goto IL_F7;
								case 2:
								{
									string u;
									this.aYGPw86yRS(u, true);
									break;
								}
								}
							}
							IL_F7:
							return;
						}
						finally
						{
							if (enumerator != null)
							{
								Form1.TX4EfrCKNxMbkrcZehx(enumerator);
								int num4 = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								}
							}
						}
						break;
					case 6:
						return;
					case 7:
						commonOpenFileDialog.Multiselect = true;
						Form1.uZnAk6wtpQNcHXbqqWb(commonOpenFileDialog).Add(new CommonFileDialogFilter(Form1.Bp8crKQbU76Tg68kvQp(1765342390 ^ 1765337122), Form1.Bp8crKQbU76Tg68kvQp(457652205 ^ 457646937)));
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					default:
						goto IL_1CE;
					}
					Form1.qhySZ1wm2U3O24tPP01(commonOpenFileDialog, Form1.MZkk37C6N2MRGVPg3wl(Form1.z4yfFkC2QcWXXQG7aMx()));
					num2 = 4;
					continue;
					IL_1CE:
					if (Form1.Wy8KOUwlyVZy2EfGZpX(commonOpenFileDialog) != 1)
					{
						return;
					}
					num2 = 3;
				}
				IL_3C:
				enumerator = commonOpenFileDialog.FileNames.GetEnumerator();
				num = 5;
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000BF78 File Offset: 0x0000A178
		private void JkdPSyxNld(object \u0020, EventArgs \u0020)
		{
			Form1.EaqCr3wYwj8s8ef9lTX(this.loadSelectedToolStripMenuItem, Form1.r7R9ASwa70Hp12oeIES(this.listView1).Count > 0);
			Form1.EaqCr3wYwj8s8ef9lTX(this.removeScriptToolStripMenuItem, this.listView1.SelectedItems.Count > 0);
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 != 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					Form1.EaqCr3wYwj8s8ef9lTX(this.editToolStripMenuItem, Form1.UfluBywsWTuHLy3r4xI(Form1.r7R9ASwa70Hp12oeIES(this.listView1)) > 0);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				}
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000C034 File Offset: 0x0000A234
		private void t9oPIem1jh(object \u0020, EventArgs \u0020)
		{
			this.Q5cPCli6Fm();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000C03C File Offset: 0x0000A23C
		private void VQOPixEpHO(object \u0020, EventArgs \u0020)
		{
			this.nxaPQhW9Tc();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000C044 File Offset: 0x0000A244
		private void SLOPZM2P2W(object \u0020, KeyPressEventArgs \u0020)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000C048 File Offset: 0x0000A248
		private void jBrPUjKb0L(object \u0020, KeyEventArgs \u0020)
		{
			if (Form1.CigDHrwg9cN7ubZxisW(\u0020) == Keys.Delete)
			{
				this.Q5cPCli6Fm();
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
		private void WnBP1xM1Lx(object \u0020, EventArgs \u0020)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
				{
					string text;
					Form1.by3dlKwXHA90Foj4ht1(text);
					num2 = 5;
					break;
				}
				case 1:
				{
					string text;
					if (!File.Exists(text))
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					goto IL_A4;
				case 3:
					if (Form1.UfluBywsWTuHLy3r4xI(Form1.r7R9ASwa70Hp12oeIES(this.listView1)) <= 0)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						ListViewItem listViewItem = Form1.r7R9ASwa70Hp12oeIES(this.listView1)[0];
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
						{
							num2 = 4;
						}
					}
					break;
				case 4:
				{
					ListViewItem listViewItem;
					string text = Form1.ECjoxLCnKi1kGfesUXO(Form1.SnLjCmweoIc1jgcm8Oi(listViewItem.SubItems, 1).Text, Form1.nEGpV3wrtMWl4QMjGvA(listViewItem));
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 == 0)
					{
						num2 = 1;
					}
					break;
				}
				case 5:
					return;
				}
			}
			return;
			IL_A4:;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000C1BC File Offset: 0x0000A3BC
		private void tZWPpV6nDf(object \u0020, EventArgs \u0020)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.NoCYLbiqG();
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(-87166655 + -2142521002 ^ 2065279045), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1654110737 ^ -473083753 ^ -2124743092), this.textGameFolder.Text);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					if (!this.isPopulating)
					{
						num2 = 2;
						continue;
					}
					return;
				}
				break;
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C290 File Offset: 0x0000A490
		private void Ek3P4S9JfW(object \u0020, EventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					if (this.isPopulating)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						yQGkVJcOSOQdjuwds7e.ini.SetValue(Form1.Bp8crKQbU76Tg68kvQp(-865714864 ^ -865714302), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-185008287 ^ -185013373), this.textAddonName.Text);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			this.NoCYLbiqG();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000C348 File Offset: 0x0000A548
		private void t2sPOHFX1j(object \u0020, EventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.isPopulating)
					{
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(-1008853611 >> 6 ^ -15762780), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-309791748 - 2077333185 ^ 1907837387), this.guna2ComboBox1.Text);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				case 2:
					goto IL_29;
				}
				break;
			}
			return;
			IL_29:
			this.NoCYLbiqG();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000C40C File Offset: 0x0000A60C
		private void DxqPf0BvVp(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 2:
					goto IL_EC;
				case 3:
					goto IL_38;
				case 5:
					if (!(Form1.xmlyIZwBrCvjcnmAewP(Form1.jCAxm7wM3ZGPkj7Rpmx((DataGridView)\u0020), Form1.fyqaZpwG9rn6JoNyMFh(\u0020)) is DataGridViewButtonColumn))
					{
						num2 = 4;
						continue;
					}
					goto IL_38;
				case 6:
					this.PanelKeyBind.Show();
					this.guna2ProgressIndicator1.Start();
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
				IL_38:
				if (Form1.RTCKYiwDUxx2CWFs9Xr(\u0020) < 0)
				{
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				IL_EC:
				this.KeyBindRow = Form1.RTCKYiwDUxx2CWFs9Xr(\u0020);
				num2 = 6;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000C51C File Offset: 0x0000A71C
		private void xXcPFcWVgN(KeyboardHookEventArgs \u0020)
		{
			int num = 37;
			for (;;)
			{
				int num2 = num;
				ValueTuple<string, object> valueTuple;
				string text;
				List<string> list;
				for (;;)
				{
					Dictionary<string, string>.Enumerator enumerator;
					string text2;
					switch (num2)
					{
					case 0:
						goto IL_2FA;
					case 1:
						goto IL_112;
					case 2:
						goto IL_2C0;
					case 3:
						goto IL_481;
					case 4:
						goto IL_13B;
					case 5:
						goto IL_E7;
					case 6:
						goto IL_583;
					case 7:
						break;
					case 8:
						if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(~603785892 ^ -603784065)))
						{
							goto IL_182;
						}
						num2 = 15;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 != 0)
						{
							num2 = 12;
							continue;
						}
						continue;
					case 9:
						goto IL_634;
					case 10:
						goto IL_2A0;
					case 11:
						try
						{
							for (;;)
							{
								IL_206:
								if (enumerator.MoveNext())
								{
									goto IL_23E;
								}
								int num3 = 2;
								KeyValuePair<string, string> keyValuePair;
								for (;;)
								{
									IL_1EC:
									switch (num3)
									{
									case 1:
										if (keyValuePair.Value == text)
										{
											num3 = 3;
											continue;
										}
										goto IL_206;
									case 2:
										goto IL_27E;
									case 3:
										goto IL_21C;
									}
									goto Block_24;
								}
								IL_21C:
								this.RotationObj.CR._ModifierList[keyValuePair.Key] = false;
								continue;
								Block_24:
								IL_23E:
								keyValuePair = enumerator.Current;
								num3 = 1;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 != 0)
								{
									num3 = 1;
									goto IL_1EC;
								}
								goto IL_1EC;
							}
							IL_27E:
							goto IL_481;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						goto IL_2A0;
					case 12:
						goto IL_640;
					case 13:
						goto IL_182;
					case 14:
						goto IL_640;
					case 15:
						this.NB3PXVFFB9((int)valueTuple.Item2, text, true);
						num2 = 32;
						continue;
					case 16:
						goto IL_422;
					case 17:
						return;
					case 18:
						Form1.ze7t0E9w2LsX5xTVcPJ(Form1.ou1LFn9CnJlfE3Jsl57(Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell)[this.KeyBindRow])[3], text);
						num2 = 34;
						continue;
					case 19:
						break;
					case 20:
						goto IL_15E;
					case 21:
						goto IL_14B;
					case 22:
						goto IL_32B;
					case 23:
						goto IL_1B3;
					case 24:
						list.Add(Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764418051));
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 25:
						goto IL_4BC;
					case 26:
						goto IL_459;
					case 27:
						goto IL_15E;
					case 28:
						goto IL_4BC;
					case 29:
						goto IL_2C0;
					case 30:
						if (this.KeyBindRow < 0)
						{
							num2 = 4;
							continue;
						}
						goto IL_1B3;
					case 31:
						goto IL_2C0;
					case 32:
						goto IL_2C0;
					case 33:
						if (Form1.R25qmmCXN2J9g6WCi7p(text2, Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510577305)))
						{
							goto IL_14B;
						}
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 34:
						valueTuple = this.kMtEcHIh0v(this.KeyBindRow);
						num2 = 8;
						continue;
					case 35:
						IL_3DF:
						if (!(text != ""))
						{
							return;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 36:
						if (!Form1.tphZQZwvIW3ycDZ8MxO(\u0020))
						{
							goto IL_583;
						}
						num2 = 24;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 37:
						list = new List<string>();
						num2 = 36;
						continue;
					case 38:
						goto IL_2C0;
					default:
						goto IL_2FA;
					}
					if (!(valueTuple.Item1 == vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1905767247 ^ 1905769087)))
					{
						num2 = 12;
						continue;
					}
					this.q68PGtQd25((string)valueTuple.Item2, text, true);
					num2 = 31;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_112:
					this.btnReGenerateAddon.Enabled = true;
					num2 = 9;
					continue;
					IL_2C0:
					if (!Form1.hmoH8S9qggmufh0cX8H(this.toggleAutoBind))
					{
						goto IL_634;
					}
					goto IL_112;
					IL_14B:
					list.Add(text2);
					num2 = 26;
					continue;
					IL_15E:
					if (!Form1.wwyinjwjYFEZbP3eSk9(\u0020))
					{
						num2 = 28;
						continue;
					}
					goto IL_422;
					IL_182:
					if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-582433477 + 1816872807 ^ 1234437512)))
					{
						num2 = 19;
						continue;
					}
					goto IL_5CA;
					IL_1B3:
					Form1.PEPZVxAWWQQspQuoWWB(this.PanelKeyBind);
					num2 = 18;
					continue;
					IL_2FA:
					enumerator = this.RotationObj.CR._ModifierKeyBind.GetEnumerator();
					num2 = 11;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_32B:
					this.nk7PBgcZ93((string)valueTuple.Item2, text, true);
					num2 = 2;
					continue;
					IL_640:
					if (!(valueTuple.Item1 == Form1.Bp8crKQbU76Tg68kvQp(-1755352853 ^ -1755355683)))
					{
						num2 = 29;
						continue;
					}
					goto IL_32B;
					IL_13B:
					if (this.RotationObj == null)
					{
						return;
					}
					goto IL_3DF;
					IL_634:
					this.KeyBindRow = -1;
					goto IL_13B;
					IL_422:
					list.Add(Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993695770));
					num2 = 25;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_459:
					text = Form1.iL51BVQjDDFv8h51MTQ(Form1.Bp8crKQbU76Tg68kvQp(-1003780849 ^ -1003777985), Form1.EgRD1y9R0gmcbIMx29L(list));
					num2 = 30;
					continue;
					IL_2A0:
					goto IL_459;
					IL_481:
					Form1.YR746FAPR19rQo7v20x(this.RotationObj.CR, text);
					num2 = 17;
					continue;
					IL_4BC:
					text2 = Form1.PfOUHRwzGl6YKvQPWO8(new KeysConverter(), Form1.JOeMOtwbVjvSGnSYbHA(\u0020));
					num2 = 33;
					continue;
					IL_583:
					if (\u0020.isAltPressed)
					{
						break;
					}
					num2 = 27;
				}
				IL_E7:
				list.Add(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-160910942 << 4 ^ 1720389420));
				num = 20;
				continue;
				IL_5CA:
				this.GmXPMShcpi((int)valueTuple.Item2, text, true);
				num = 38;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
		private void QXxPTKsMf9(KeyboardHookEventArgs \u0020)
		{
			int num = 5;
			for (;;)
			{
				int num2 = num;
				List<string> list;
				for (;;)
				{
					string text;
					string text2;
					switch (num2)
					{
					case 0:
						goto IL_305;
					case 1:
						try
						{
							for (;;)
							{
								IL_109:
								Dictionary<string, string>.Enumerator enumerator;
								if (enumerator.MoveNext())
								{
									goto IL_12F;
								}
								int num3 = 2;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
								{
									num3 = 2;
								}
								KeyValuePair<string, string> keyValuePair;
								for (;;)
								{
									IL_CD:
									switch (num3)
									{
									case 1:
										goto IL_E7;
									case 2:
										goto IL_17F;
									case 3:
										goto IL_12F;
									}
									if (!(keyValuePair.Value == text))
									{
										goto IL_109;
									}
									num3 = 0;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da != 0)
									{
										num3 = 1;
									}
								}
								IL_E7:
								this.RotationObj.CR._ModifierList[keyValuePair.Key] = true;
								continue;
								IL_12F:
								keyValuePair = enumerator.Current;
								num3 = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 != 0)
								{
									num3 = 0;
									goto IL_CD;
								}
								goto IL_CD;
							}
							IL_17F:
							return;
						}
						finally
						{
							Dictionary<string, string>.Enumerator enumerator;
							((IDisposable)enumerator).Dispose();
						}
						break;
					case 2:
						goto IL_29E;
					case 3:
					{
						Dictionary<string, string>.Enumerator enumerator = this.RotationObj.CR._ModifierKeyBind.GetEnumerator();
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 4:
						if (!\u0020.isCtrlPressed)
						{
							goto IL_305;
						}
						goto IL_210;
					case 5:
						goto IL_A4;
					case 6:
						if (this.RotationObj == null)
						{
							return;
						}
						num2 = 10;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 7:
						goto IL_210;
					case 8:
						goto IL_34C;
					case 9:
						goto IL_2AC;
					case 10:
						if (Form1.R25qmmCXN2J9g6WCi7p(text, ""))
						{
							num2 = 3;
							continue;
						}
						return;
					case 11:
						goto IL_31A;
					case 12:
						if (!(text2 != vua32v5yjQhjRjK4YIO.BRA5TcZvlv(996650866 + -609199087 ^ 387456679)))
						{
							num2 = 15;
							continue;
						}
						goto IL_29E;
					case 13:
						return;
					case 14:
						list.Add(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-825446221 ^ -825449025));
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 != 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					case 15:
						break;
					case 16:
						goto IL_34C;
					default:
						goto IL_305;
					}
					IL_60:
					text = Form1.iL51BVQjDDFv8h51MTQ(Form1.Bp8crKQbU76Tg68kvQp(1681481889 ^ 1681487249), Form1.EgRD1y9R0gmcbIMx29L(list));
					num2 = 6;
					continue;
					goto IL_60;
					IL_210:
					list.Add(Form1.Bp8crKQbU76Tg68kvQp(-1089588375 ^ -1089591703));
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_2AC:
					if (Form1.wwyinjwjYFEZbP3eSk9(\u0020))
					{
						goto IL_31A;
					}
					num2 = 16;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
					IL_305:
					if (\u0020.isAltPressed)
					{
						num2 = 14;
						continue;
					}
					goto IL_2AC;
					IL_31A:
					list.Add(Form1.Bp8crKQbU76Tg68kvQp(~2095831454 ^ -2095828105));
					num2 = 8;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_34C:
					text2 = new KeysConverter().ConvertToString(Form1.JOeMOtwbVjvSGnSYbHA(\u0020));
					num2 = 12;
					continue;
					IL_29E:
					list.Add(text2);
					goto IL_60;
				}
				IL_A4:
				list = new List<string>();
				num = 4;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000CF40 File Offset: 0x0000B140
		private string eQ0PRDEBNy()
		{
			if (this.RotationObj != null)
			{
				while (this.RotationObj.CR.RotationName != "")
				{
					int num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num = 0;
					}
					switch (num)
					{
					default:
						return Form1.Bp8crKQbU76Tg68kvQp(1691472209 >> 1 ^ 845741460) + Form1.jaVJwbwNH3YGplDDAt0(this.RotationObj.CR.RotationName);
					case 1:
						break;
					}
				}
			}
			return "";
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000D008 File Offset: 0x0000B208
		private string CpNPLL0Dun(string \u0020)
		{
			string text = this.r8KPKLamC6(\u0020);
			return Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-831735385 ^ -831737705), Form1.NNB2gjAEJQ8lcLOwdaL(text, 1, 7));
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000D044 File Offset: 0x0000B244
		private string hMtPl8aCRq(string \u0020)
		{
			string text = this.r8KPKLamC6(\u0020);
			return Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(451337338 ^ 451332412), Form1.NNB2gjAEJQ8lcLOwdaL(text, 1, 7));
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000D080 File Offset: 0x0000B280
		private string TlfPaJs9tN(string \u0020)
		{
			string text = this.r8KPKLamC6(\u0020);
			return Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~603785892 ^ -603791349), text.Substring(1, 7));
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000D0BC File Offset: 0x0000B2BC
		private string r8KPKLamC6(string \u0020)
		{
			int num = 1;
			int num2 = num;
			StringBuilder stringBuilder;
			for (;;)
			{
				byte[] array;
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_49;
				case 1:
				{
					object obj = new SHA256Managed();
					stringBuilder = new StringBuilder();
					array = Form1.qlQRLCA5dcYXyTYPoLX(obj, Form1.A6TDSQAcKqRqD1mtmGh(Form1.WMrrh19npvwTJaYhTvb(), \u0020));
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 2:
					goto IL_DD;
				case 3:
					break;
				case 4:
				{
					byte b;
					stringBuilder.Append(b.ToString(Form1.Bp8crKQbU76Tg68kvQp(~2095831454 ^ -2095828163)));
					num2 = 6;
					continue;
				}
				case 5:
					break;
				case 6:
					num3++;
					num2 = 5;
					continue;
				default:
					goto IL_49;
				}
				if (num3 < array.Length)
				{
					byte b = array[num3];
					num2 = 4;
					continue;
				}
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
				{
					num2 = 2;
					continue;
				}
				continue;
				IL_49:
				num3 = 0;
				num2 = 3;
			}
			IL_DD:
			return stringBuilder.ToString();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		private object Qf3PeL7IS9(string \u0020)
		{
			int num = 7;
			string value;
			bool flag;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					int objectType;
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
						goto IL_1A1;
					case 2:
						goto IL_22D;
					case 3:
						return value;
					case 4:
						if (!(value != ""))
						{
							goto Block_4;
						}
						break;
					case 5:
						return value;
					case 6:
					{
						string text;
						if (text != "")
						{
							num2 = 15;
							continue;
						}
						goto IL_160;
					}
					case 7:
					{
						string text = this.eQ0PRDEBNy();
						num2 = 6;
						continue;
					}
					case 8:
					{
						string text;
						value = yQGkVJcOSOQdjuwds7e.ini.GetValue(text, this.TlfPaJs9tN(\u0020), "");
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					case 9:
						goto IL_14E;
					case 10:
						switch (objectType)
						{
						case 1:
							goto IL_24B;
						case 2:
							goto IL_14E;
						case 3:
							this.ttqPkelxwN(\u0020, value, false);
							num2 = 5;
							continue;
						case 4:
							this.ttqPkelxwN(\u0020, value, false);
							num2 = 3;
							continue;
						}
						goto Block_2;
					case 11:
						goto IL_21E;
					case 12:
						break;
					case 13:
						return value;
					case 14:
						goto IL_24B;
					case 15:
						if (this.RotationObj.CR._RotationSettings.ContainsKey(\u0020))
						{
							num2 = 8;
							continue;
						}
						goto IL_160;
					default:
						goto IL_125;
					}
					objectType = this.RotationObj.CR._RotationSettings[\u0020].ObjectType;
					num2 = 10;
					continue;
					IL_125:
					int num3;
					this.ttqPkelxwN(\u0020, num3, false);
					num2 = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
					{
						num2 = 13;
						continue;
					}
					continue;
					IL_14E:
					flag = this.i7hPmyi0ro(value);
					this.ttqPkelxwN(\u0020, flag, false);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_24B:
					if (int.TryParse(value, out num3))
					{
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(Form1.Bp8crKQbU76Tg68kvQp(996650866 + -609199087 ^ 387456743), \u0020, Form1.Bp8crKQbU76Tg68kvQp(978854837 ^ 978859541)));
						num2 = 11;
					}
				}
				Block_2:
				num = 2;
			}
			return value;
			Block_4:
			IL_160:
			return null;
			IL_1A1:
			return flag;
			IL_21E:
			IL_22D:
			goto IL_160;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000D448 File Offset: 0x0000B648
		private void ttqPkelxwN(string \u0020, object \u0020, bool \u0020)
		{
			int num = 28;
			for (;;)
			{
				int num2 = num;
				string text;
				string text2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_4EB;
					case 1:
						goto IL_225;
					case 2:
						goto IL_225;
					case 3:
						goto IL_254;
					case 4:
						goto IL_2EA;
					case 5:
						this.WriteLog(Form1.bojNR6AxVgsJ3A8NLLT(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1366152946 ^ -1366147898), \u0020, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(259176490 ^ 259173850), \u0020.ToString()));
						num2 = 24;
						continue;
					case 6:
						goto IL_401;
					case 7:
						goto IL_225;
					case 8:
						text = this.TlfPaJs9tN(\u0020);
						num2 = 15;
						continue;
					case 9:
						goto IL_2B5;
					case 10:
						this.WriteLog(Form1.bojNR6AxVgsJ3A8NLLT(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1638637009 >> 6 ^ 25607103), \u0020, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2083830725 ^ -2083827253), (string)\u0020));
						num2 = 2;
						continue;
					case 11:
						goto IL_171;
					case 12:
						return;
					case 13:
					{
						int objectType;
						switch (objectType)
						{
						case 1:
							goto IL_171;
						case 2:
							if (!(\u0020 is bool))
							{
								num2 = 18;
								continue;
							}
							goto IL_2B5;
						case 3:
							goto IL_4EB;
						case 4:
							goto IL_F8;
						default:
							num2 = 7;
							continue;
						}
						break;
					}
					case 14:
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-289990612 ^ 1144181582 ^ -1434067286) + \u0020 + Form1.Bp8crKQbU76Tg68kvQp(-1505789866 ^ -1505792602) + ((bool)\u0020).ToString());
						num2 = 17;
						continue;
					case 15:
						if (Form1.R25qmmCXN2J9g6WCi7p(text2, ""))
						{
							num2 = 25;
							continue;
						}
						return;
					case 16:
						return;
					case 17:
						goto IL_225;
					case 18:
						goto IL_2EA;
					case 19:
						goto IL_F8;
					case 20:
						if (!\u0020)
						{
							return;
						}
						text2 = this.eQ0PRDEBNy();
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
						{
							num2 = 8;
							continue;
						}
						continue;
					case 21:
						goto IL_35E;
					case 22:
						goto IL_225;
					case 23:
						break;
					case 24:
						goto IL_225;
					case 25:
					{
						int objectType = this.RotationObj.CR._RotationSettings[\u0020].ObjectType;
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 26:
						goto IL_225;
					case 27:
						goto IL_468;
					case 28:
						if (this.RotationObj == null)
						{
							num2 = 8;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa == 0)
							{
								num2 = 27;
								continue;
							}
							continue;
						}
						else if (!this.RotationObj.CR._RotationSettings.ContainsKey(\u0020))
						{
							num2 = 12;
							continue;
						}
						break;
					default:
						goto IL_4EB;
					}
					this.RotationObj.CR._RotationSettings[\u0020].CurrentValue = \u0020;
					num2 = 20;
					continue;
					IL_F8:
					yQGkVJcOSOQdjuwds7e.ini.SetValue(text2, text, (string)\u0020);
					num2 = 10;
					continue;
					IL_171:
					if (\u0020 is int)
					{
						goto IL_401;
					}
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_225:
					this.NoCYLbiqG();
					num2 = 16;
					continue;
					IL_2B5:
					Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text2, text, this.LoQPHyeILJ((bool)\u0020));
					num2 = 14;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
					{
						num2 = 13;
						continue;
					}
					continue;
					IL_2EA:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1897624240 ^ -1897620642) + \u0020 + Form1.Bp8crKQbU76Tg68kvQp(-1224731037 ^ -1224736727));
					num2 = 26;
					continue;
					IL_4EB:
					Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text2, text, (string)\u0020);
					this.WriteLog(Form1.bojNR6AxVgsJ3A8NLLT(Form1.Bp8crKQbU76Tg68kvQp(-1089588375 ^ -1089591647), \u0020, Form1.Bp8crKQbU76Tg68kvQp(-160910942 << 4 ^ 1720389584), (string)\u0020));
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 == 0)
					{
						num2 = 0;
					}
				}
				IL_35E:
				this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1638637009 >> 6 ^ 25606265), \u0020, Form1.Bp8crKQbU76Tg68kvQp(978854837 ^ 978859519)));
				num = 22;
				continue;
				IL_401:
				Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text2, text, ((int)\u0020).ToString());
				num = 5;
				continue;
				IL_254:
				goto IL_35E;
			}
			return;
			IL_468:;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D968 File Offset: 0x0000BB68
		private bool c4APrDbmcW(int \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
				{
					string text;
					if (!Form1.t0poRRCb3dy0hjmaGAe(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(289037427 >> 1 ^ 144521295), \u0020.ToString()), Form1.Bp8crKQbU76Tg68kvQp(289037427 >> 1 ^ 144518347)), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039299918)))
					{
						return false;
					}
					this.PlpP7TiE7d(\u0020, true, false);
					num2 = 3;
					break;
				}
				case 1:
				{
					string text;
					if (!Form1.R25qmmCXN2J9g6WCi7p(text, ""))
					{
						return false;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
				{
					string text = this.eQ0PRDEBNy();
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 3:
					return true;
				}
			}
			return true;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000DA70 File Offset: 0x0000BC70
		private void PlpP7TiE7d(int \u0020, bool \u0020, bool \u0020)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 1:
					goto IL_41;
				case 2:
					goto IL_12A;
				case 3:
					Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352738322), \u0020.ToString()), this.LoQPHyeILJ(\u0020));
					num2 = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 == 0)
					{
						num2 = 7;
						continue;
					}
					continue;
				case 4:
					goto IL_11B;
				case 5:
					if (this.RotationObj != null)
					{
						goto IL_12A;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					if (Form1.R25qmmCXN2J9g6WCi7p(text, ""))
					{
						num2 = 3;
						continue;
					}
					return;
				case 7:
					goto IL_156;
				case 8:
					if (!\u0020)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				text = this.eQ0PRDEBNy();
				num2 = 6;
				continue;
				IL_12A:
				this.RotationObj.CR._SetSpellIsDisabled(\u0020, \u0020);
				num2 = 8;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
				{
					num2 = 5;
				}
			}
			return;
			IL_41:
			IL_11B:
			return;
			IL_156:
			this.NoCYLbiqG();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		private bool iHiP2WWDhA(int \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 1:
					text = this.eQ0PRDEBNy();
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_C0;
				case 3:
					if (!(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(-831735385 ^ -831738077), \u0020.ToString()), Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387933866)) == vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1905767247 ^ 1905763633)))
					{
						return false;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				if (!Form1.R25qmmCXN2J9g6WCi7p(text, ""))
				{
					return false;
				}
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b != 0)
				{
					num2 = 3;
				}
			}
			IL_C0:
			this.YKrP6Pbm3D(\u0020, true, false);
			return true;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		private void YKrP6Pbm3D(int \u0020, bool \u0020, bool \u0020)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (\u0020)
					{
						num2 = 4;
						continue;
					}
					return;
				case 2:
					this.RotationObj.CR._SetItemIsDisabled(\u0020, \u0020);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					if (this.RotationObj != null)
					{
						num2 = 2;
						continue;
					}
					return;
				case 4:
				{
					string text = this.eQ0PRDEBNy();
					if (!Form1.R25qmmCXN2J9g6WCi7p(text, ""))
					{
						return;
					}
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				}
				case 5:
					return;
				case 6:
				{
					string text;
					yQGkVJcOSOQdjuwds7e.ini.SetValue(text, Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1016420359 ^ 1016417923), \u0020.ToString()), this.LoQPHyeILJ(\u0020));
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				}
				this.NoCYLbiqG();
				num2 = 5;
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000DE14 File Offset: 0x0000C014
		private bool AXCPN1OpQT(string \u0020)
		{
			string text = this.eQ0PRDEBNy();
			if (Form1.R25qmmCXN2J9g6WCi7p(text, ""))
			{
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_E2;
					case 2:
						return true;
					case 3:
						return false;
					}
					if (!Form1.t0poRRCb3dy0hjmaGAe(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(1055311542 ^ 1055314816), this.CpNPLL0Dun(\u0020)), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1008853611 >> 6 ^ -15762812)), Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679325398)))
					{
						num = 3;
						continue;
					}
					IL_E2:
					this.MxXPnSINT1(\u0020, true, false);
					num = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 == 0)
					{
						num = 2;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000DF28 File Offset: 0x0000C128
		private void MxXPnSINT1(string \u0020, bool \u0020, bool \u0020)
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					goto IL_C5;
				case 1:
					yQGkVJcOSOQdjuwds7e.ini.SetValue(text, Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2040894867 + -686633457 ^ 1354266260), this.CpNPLL0Dun(\u0020)), this.LoQPHyeILJ(\u0020));
					num2 = 2;
					continue;
				case 2:
					goto IL_5E;
				case 3:
					this.RotationObj.CR._SetMacroIsDisabled(\u0020, \u0020);
					num2 = 6;
					continue;
				case 4:
					if (this.RotationObj == null)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					break;
				case 6:
					if (!\u0020)
					{
						num2 = 7;
						continue;
					}
					break;
				case 7:
					goto IL_115;
				default:
					goto IL_C5;
				}
				text = this.eQ0PRDEBNy();
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_C5:
				if (!(text != ""))
				{
					return;
				}
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d != 0)
				{
					num2 = 1;
				}
			}
			IL_5E:
			this.NoCYLbiqG();
			return;
			IL_115:;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000E068 File Offset: 0x0000C268
		private bool arHP0GxtL7(string \u0020)
		{
			int num = 1;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 1:
						text = this.eQ0PRDEBNy();
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_30;
					case 3:
						return true;
					case 4:
						return false;
					}
					if (!(text != ""))
					{
						return false;
					}
					if (Form1.t0poRRCb3dy0hjmaGAe(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Bp8crKQbU76Tg68kvQp(-309791748 - 2077333185 ^ 1907836941) + this.hMtPl8aCRq(\u0020), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2066732216 ^ 2066732618)), Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352738330)))
					{
						break;
					}
					num2 = 4;
				}
				IL_30:
				this.jOcPJQZG8P(\u0020, true, false);
				num = 3;
			}
			return false;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000E17C File Offset: 0x0000C37C
		private void jOcPJQZG8P(string \u0020, bool \u0020, bool \u0020)
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
					{
						string text;
						Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Bp8crKQbU76Tg68kvQp(-1495818301 ^ -1495823627) + this.hMtPl8aCRq(\u0020), this.LoQPHyeILJ(\u0020));
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					case 2:
						goto IL_E5;
					case 3:
						if (this.RotationObj == null)
						{
							return;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						return;
					case 5:
					{
						string text;
						if (!Form1.R25qmmCXN2J9g6WCi7p(text, ""))
						{
							return;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					case 6:
						if (\u0020)
						{
							string text = this.eQ0PRDEBNy();
							num2 = 5;
							continue;
						}
						return;
					}
					this.NoCYLbiqG();
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e != 0)
					{
						num2 = 1;
					}
				}
				IL_E5:
				Form1.xWgqMhAuItN0YhGCRGs(this.RotationObj.CR, \u0020, \u0020);
				num = 6;
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		private bool i7hPmyi0ro(string \u0020)
		{
			return Form1.t0poRRCb3dy0hjmaGAe(\u0020, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1008853611 >> 6 ^ -15766008));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000E2D8 File Offset: 0x0000C4D8
		private string LoQPHyeILJ(bool \u0020)
		{
			if (!\u0020)
			{
				return Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374436000);
			}
			return Form1.Bp8crKQbU76Tg68kvQp(978854837 ^ 978859467);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000E348 File Offset: 0x0000C548
		private string dEAPtSbpdV(int \u0020)
		{
			int num = 2;
			int num2 = num;
			string text2;
			for (;;)
			{
				switch (num2)
				{
				case 1:
				{
					string text;
					if (text != "")
					{
						text2 = Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1992869118 ^ -1992871386), \u0020.ToString()), "");
						num2 = 5;
						continue;
					}
					goto IL_E7;
				}
				case 2:
				{
					string text = this.eQ0PRDEBNy();
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 3:
					goto IL_8F;
				case 5:
					if (Form1.R25qmmCXN2J9g6WCi7p(text2, ""))
					{
						goto IL_8F;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
				IL_8F:
				this.NB3PXVFFB9(\u0020, text2, false);
				num2 = 4;
			}
			return text2;
			IL_E7:
			return "";
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000E450 File Offset: 0x0000C650
		private string rBWPY7olng(int \u0020)
		{
			string text = this.eQ0PRDEBNy();
			if (Form1.R25qmmCXN2J9g6WCi7p(text, ""))
			{
				int num = 2;
				string value;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return value;
					case 2:
						value = yQGkVJcOSOQdjuwds7e.ini.GetValue(text, Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(1048347516 ^ 1048349270), \u0020.ToString()), "");
						num = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
						{
							num = 4;
							continue;
						}
						continue;
					case 3:
						return value;
					case 4:
						if (!Form1.R25qmmCXN2J9g6WCi7p(value, ""))
						{
							num = 1;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
							{
								num = 1;
								continue;
							}
							continue;
						}
						break;
					}
					this.GmXPMShcpi(\u0020, value, false);
					num = 3;
				}
				return value;
			}
			return "";
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000E55C File Offset: 0x0000C75C
		private string z32PsuBVWT(string \u0020)
		{
			string text = this.eQ0PRDEBNy();
			if (text != "")
			{
				goto IL_43;
			}
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
			{
				num = 0;
			}
			string value;
			for (;;)
			{
				IL_09:
				switch (num)
				{
				case 1:
					this.q68PGtQd25(\u0020, value, false);
					num = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 != 0)
					{
						num = 1;
						continue;
					}
					continue;
				case 2:
					return value;
				case 3:
					goto IL_43;
				case 4:
					if (!Form1.R25qmmCXN2J9g6WCi7p(value, ""))
					{
						return value;
					}
					num = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				}
				break;
			}
			return "";
			IL_43:
			value = yQGkVJcOSOQdjuwds7e.ini.GetValue(text, this.CpNPLL0Dun(\u0020), "");
			num = 4;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
			{
				num = 2;
				goto IL_09;
			}
			goto IL_09;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000E664 File Offset: 0x0000C864
		private string USfPgt6bmR(string \u0020)
		{
			int num = 3;
			int num2 = num;
			string text;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 1:
					if (!(text != ""))
					{
						return text;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					if (Form1.R25qmmCXN2J9g6WCi7p(text2, ""))
					{
						goto IL_D3;
					}
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 3:
					text2 = this.eQ0PRDEBNy();
					num2 = 2;
					continue;
				case 4:
					goto IL_77;
				case 5:
					goto IL_D3;
				}
				break;
				IL_D3:
				text = Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, text2, this.hMtPl8aCRq(\u0020), "");
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
				{
					num2 = 1;
				}
			}
			this.nk7PBgcZ93(\u0020, text, false);
			return text;
			IL_77:
			return "";
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000E778 File Offset: 0x0000C978
		private void NB3PXVFFB9(int \u0020, string \u0020, bool \u0020)
		{
			int num = 2;
			for (;;)
			{
				int num2 = num;
				string text;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						Form1.BZx4uIAVbOsBPvee1L3(this.RotationObj.CR, \u0020, \u0020);
						num2 = 7;
						continue;
					case 2:
						if (this.RotationObj != null)
						{
							num2 = 1;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 3:
						if (text != "")
						{
							Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(828767401 >> 3 ^ 103593649), \u0020.ToString()), \u0020);
							num2 = 5;
							continue;
						}
						break;
					case 4:
						goto IL_3C;
					case 5:
						this.NoCYLbiqG();
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 7:
						if (\u0020)
						{
							goto IL_3C;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_3C:
				text = this.eQ0PRDEBNy();
				num = 3;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		private void GmXPMShcpi(int \u0020, string \u0020, bool \u0020)
		{
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 1:
						this.RotationObj.CR._SetItemKeybind(\u0020, \u0020);
						num2 = 6;
						continue;
					case 2:
						if (this.RotationObj == null)
						{
							return;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						text = this.eQ0PRDEBNy();
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						this.NoCYLbiqG();
						num2 = 5;
						continue;
					case 5:
						return;
					case 6:
						if (\u0020)
						{
							num2 = 3;
							continue;
						}
						return;
					case 7:
						goto IL_3D;
					}
					if (!(text != ""))
					{
						break;
					}
					Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text, Form1.Bp8crKQbU76Tg68kvQp(-289990612 ^ 1144181582 ^ -1434074552) + \u0020.ToString(), \u0020);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
					{
						num2 = 4;
					}
				}
				num = 7;
			}
			return;
			IL_3D:;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		private void q68PGtQd25(string \u0020, string \u0020, bool \u0020)
		{
			int num = 5;
			for (;;)
			{
				int num2 = num;
				string text;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (\u0020)
						{
							num2 = 2;
							continue;
						}
						break;
					case 2:
						goto IL_B3;
					case 3:
						if (text != "")
						{
							Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text, this.CpNPLL0Dun(\u0020), \u0020);
							num2 = 3;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
							{
								num2 = 6;
								continue;
							}
							continue;
						}
						break;
					case 4:
						Form1.Fb7l2uAyPPo8WJLu8Lr(this.RotationObj.CR, \u0020, \u0020);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 5:
						if (this.RotationObj != null)
						{
							num2 = 4;
							continue;
						}
						break;
					case 6:
						this.NoCYLbiqG();
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					return;
				}
				IL_B3:
				text = this.eQ0PRDEBNy();
				num = 3;
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000EB08 File Offset: 0x0000CD08
		private void nk7PBgcZ93(string \u0020, string \u0020, bool \u0020)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.NoCYLbiqG();
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 2:
				{
					string text = this.eQ0PRDEBNy();
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				case 3:
				{
					string text;
					if (!Form1.R25qmmCXN2J9g6WCi7p(text, ""))
					{
						return;
					}
					yQGkVJcOSOQdjuwds7e.ini.SetValue(text, this.hMtPl8aCRq(\u0020), \u0020);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 4:
					Form1.CUXBNXA86Zx40HpySNN(this.RotationObj.CR, \u0020, \u0020);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
					if (this.RotationObj == null)
					{
						return;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					return;
				}
				if (!\u0020)
				{
					break;
				}
				num2 = 2;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000EC34 File Offset: 0x0000CE34
		private void YC1PD1ftiH(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000EC38 File Offset: 0x0000CE38
		private void FWPPvUIwph(object \u0020, EventArgs \u0020)
		{
			this.KeyBindRow = -1;
			Form1.PEPZVxAWWQQspQuoWWB(this.PanelKeyBind);
			int num = 1;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df == 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					Form1.hA10HjAqAx1Xo9rd956(this.guna2ProgressIndicator1);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		private void qe2PjOjxIv(object \u0020, MouseEventArgs \u0020)
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		private void GZcPbDw0ua(object \u0020, MouseEventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			DataGridView.HitTestInfo hitTestInfo;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					hitTestInfo = Form1.PM5C3KAoCVQ2wZWf2hp(this.DataGridSpell, \u0020.X, \u0020.Y);
					num2 = 3;
					continue;
				case 2:
					if (Form1.PQntv3AdaAxC9s7U1x4(\u0020) != MouseButtons.Right)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					if (Form1.ahXGp6A3a1E3JmpEjpv(hitTestInfo) <= -1)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					goto IL_30;
				}
				Form1.B7QCBeAQ0M4muOnl6cq(this.DataGridSpell);
				num2 = 4;
			}
			IL_30:
			Form1.VlPKSqAC3r5le3hSQ1S(Form1.lkI3An9h4MMoumNf3eC(this.DataGridSpell.Rows, Form1.ahXGp6A3a1E3JmpEjpv(hitTestInfo)), true);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000EDA4 File Offset: 0x0000CFA4
		private void qfTPzcffVJ(object \u0020, EventArgs \u0020)
		{
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					ValueTuple<string, object> valueTuple;
					switch (num2)
					{
					case 0:
						goto IL_1D5;
					case 1:
						goto IL_25E;
					case 2:
						break;
					case 3:
						break;
					case 4:
						this.NB3PXVFFB9((int)valueTuple.Item2, "", true);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						goto IL_230;
					case 6:
						if (Form1.UkGlVdA90MYg97LCGUo(this.DataGridSpell).Count <= 0)
						{
							goto Block_5;
						}
						goto IL_11B;
					case 7:
						if (Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(152750669 ^ 152748905)))
						{
							num2 = 4;
							continue;
						}
						if (valueTuple.Item1 == Form1.Bp8crKQbU76Tg68kvQp(-1041647104 ^ -1041648854))
						{
							goto IL_1D5;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 8:
						goto IL_25E;
					case 9:
						goto IL_25E;
					case 10:
						valueTuple = this.kMtEcHIh0v(Form1.fXqdpEAAZxwNygyDTVE(Form1.UkGlVdA90MYg97LCGUo(this.DataGridSpell)[0]));
						num2 = 7;
						continue;
					case 11:
						return;
					case 12:
						goto IL_25E;
					case 13:
						goto IL_11B;
					case 14:
						goto IL_1F7;
					default:
						goto IL_1D5;
					}
					if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(185404423 + 1853889833 ^ 2039291904)))
					{
						num2 = 12;
						continue;
					}
					goto IL_1F7;
					IL_11B:
					Form1.ze7t0E9w2LsX5xTVcPJ(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.Oy2ujMAwwsQqeC7QmTc(this.DataGridSpell.SelectedRows, 0)), 3), "");
					num2 = 10;
					continue;
					IL_1D5:
					this.GmXPMShcpi((int)valueTuple.Item2, "", true);
					num2 = 9;
					continue;
					IL_1F7:
					this.q68PGtQd25((string)valueTuple.Item2, "", true);
					num2 = 8;
					continue;
					IL_25E:
					if (!this.toggleAutoBind.Checked)
					{
						return;
					}
					Form1.Kkf2lh9gFFtl0X8OnPB(this.btnReGenerateAddon, true);
					num2 = 11;
				}
				Block_5:
				num = 5;
			}
			return;
			IL_230:;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000F024 File Offset: 0x0000D224
		private string K4kEWiAGW5(Macro \u0020)
		{
			int num = 6;
			string result;
			string text;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_4BF;
					case 1:
						goto IL_414;
					case 2:
					{
						int num3 = Form1.VuXCjt9QTRVabsm0Q0q(this.guna2ComboBox1);
						num2 = 32;
						continue;
					}
					case 3:
						goto IL_56E;
					case 4:
						goto IL_62D;
					case 5:
						if (\u0020.SpellID <= 0)
						{
							return result;
						}
						num2 = 14;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					case 6:
						result = \u0020.Example;
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 7:
						goto IL_21C;
					case 8:
						goto IL_18A;
					case 9:
						goto IL_458;
					case 10:
						goto IL_458;
					case 11:
						goto IL_199;
					case 12:
						break;
					case 13:
						goto IL_28A;
					case 14:
						goto IL_136;
					case 15:
						goto IL_355;
					case 16:
						goto IL_458;
					case 17:
						goto IL_458;
					case 18:
						goto IL_246;
					case 19:
						goto IL_15C;
					case 20:
						goto IL_458;
					case 21:
						goto IL_C6;
					case 22:
						goto IL_2E7;
					case 23:
						goto IL_5E6;
					case 24:
						goto IL_458;
					case 25:
						goto IL_32B;
					case 26:
						goto IL_1DB;
					case 27:
						goto IL_458;
					case 28:
						goto IL_458;
					case 29:
						goto IL_458;
					case 30:
						goto IL_3E6;
					case 31:
						result = Form1.gXqn73AST9qZHOxNh5u(Form1.Bp8crKQbU76Tg68kvQp(-1734223699 - -1503209248 ^ -231020423), text);
						num2 = 8;
						continue;
					case 32:
					{
						int num3;
						switch (num3)
						{
						case 0:
							goto IL_28A;
						case 1:
							goto IL_4BF;
						case 2:
							goto IL_199;
						case 3:
							goto IL_62D;
						case 4:
							goto IL_2E7;
						case 5:
							text = string.Format(Form1.Bp8crKQbU76Tg68kvQp(-1089588375 ^ -1089591835), text, \u0020.SpellRank);
							num2 = 10;
							continue;
						case 6:
							goto IL_246;
						case 7:
							goto IL_3E6;
						case 8:
							goto IL_56E;
						default:
							num2 = 16;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 == 0)
							{
								num2 = 4;
								continue;
							}
							continue;
						}
						break;
					}
					case 33:
						return result;
					case 34:
						goto IL_395;
					case 35:
						goto IL_32B;
					case 36:
						if (\u0020.SpellRank > 0)
						{
							num2 = 2;
							continue;
						}
						goto IL_458;
					default:
						goto IL_4BF;
					}
					IL_1F9:
					result = string.Format(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1750427148 ^ -1750430058), text);
					num2 = 21;
					continue;
					IL_395:
					if (!Form1.t0poRRCb3dy0hjmaGAe(\u0020.Example, Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463908059)))
					{
						num2 = 25;
						continue;
					}
					goto IL_1F9;
					IL_458:
					if (!(text != ""))
					{
						num2 = 33;
						continue;
					}
					goto IL_395;
					IL_21C:
					if (Form1.t0poRRCb3dy0hjmaGAe(\u0020.Example, Form1.Bp8crKQbU76Tg68kvQp(-1746511494 ^ -1746513860)))
					{
						num2 = 23;
						continue;
					}
					return result;
					IL_414:
					if (Form1.t0poRRCb3dy0hjmaGAe(\u0020.Example, Form1.Bp8crKQbU76Tg68kvQp(-838478377 ^ -838476633)))
					{
						result = Form1.gXqn73AST9qZHOxNh5u(Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218520587), text);
						num2 = 19;
						continue;
					}
					goto IL_21C;
					IL_355:
					if (!Form1.t0poRRCb3dy0hjmaGAe(\u0020.Example, Form1.Bp8crKQbU76Tg68kvQp(1654110737 ^ -473083753 ^ -2124750076)))
					{
						goto IL_414;
					}
					num2 = 16;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 != 0)
					{
						num2 = 26;
						continue;
					}
					continue;
					IL_32B:
					if (Form1.t0poRRCb3dy0hjmaGAe(\u0020.Example, Form1.Bp8crKQbU76Tg68kvQp(-1860104403 ^ -1860106635)))
					{
						num2 = 31;
						continue;
					}
					goto IL_355;
					IL_246:
					text = string.Format(Form1.Bp8crKQbU76Tg68kvQp(1638637009 >> 6 ^ 25606483), text, \u0020.SpellRank);
					num2 = 24;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a != 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_28A:
					text = Form1.Q1mXpDw5XrPNoHCtUIq(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(790722942 ^ 790720498), text, \u0020.SpellRank);
					num2 = 28;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c != 0)
					{
						num2 = 19;
						continue;
					}
					continue;
					IL_2E7:
					text = Form1.Q1mXpDw5XrPNoHCtUIq(Form1.Bp8crKQbU76Tg68kvQp(1819523060 ^ 1064311800 ^ 1392753418), text, \u0020.SpellRank);
					num2 = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af != 0)
					{
						num2 = 6;
						continue;
					}
					continue;
					IL_3E6:
					text = string.Format(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(212924216 ^ 212918394), text, \u0020.SpellRank);
					num2 = 29;
					continue;
					IL_4BF:
					text = Form1.Q1mXpDw5XrPNoHCtUIq(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1002815721 ^ -877302260 ^ 261048241), text, \u0020.SpellRank);
					num2 = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
					{
						num2 = 20;
						continue;
					}
					continue;
					IL_56E:
					text = Form1.Q1mXpDw5XrPNoHCtUIq(Form1.Bp8crKQbU76Tg68kvQp(-911697958 - 376275890 ^ -1287978228), text, \u0020.SpellRank);
					num2 = 17;
					continue;
					IL_62D:
					text = string.Format(Form1.Bp8crKQbU76Tg68kvQp(1654110737 ^ -473083753 ^ -2124743592), text, \u0020.SpellRank);
					num2 = 27;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 != 0)
					{
						num2 = 14;
						continue;
					}
					continue;
					IL_199:
					text = Form1.Q1mXpDw5XrPNoHCtUIq(Form1.Bp8crKQbU76Tg68kvQp(1157945476 >> 1 ^ 578976390), text, \u0020.SpellRank);
					goto IL_458;
				}
				IL_136:
				text = Form1.DiISakAh6XsRZOkhj9g(this.RotationObj.CR, \u0020.SpellID);
				num = 36;
			}
			IL_C6:
			IL_15C:
			IL_18A:
			return result;
			IL_1DB:
			result = Form1.gXqn73AST9qZHOxNh5u(Form1.Bp8crKQbU76Tg68kvQp(-1199763274 ^ -1199765320), text);
			return result;
			IL_5E6:
			return string.Format(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(457652205 ^ 457650039), text);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000F6BC File Offset: 0x0000D8BC
		private void S17EP91CD7(object \u0020, EventArgs \u0020)
		{
			int num = 11;
			int num2 = num;
			for (;;)
			{
				Form2 form;
				string key;
				switch (num2)
				{
				case 1:
					Form1.iSOs1Zwpnwp4TrgI3NY(form, this.RotationObj.CR._MacroList[key].Name);
					form.ShowDialog(this);
					num2 = 5;
					continue;
				case 2:
				{
					ValueTuple<string, object> valueTuple;
					key = (string)valueTuple.Item2;
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				}
				case 3:
					if (this.RotationObj.CR._MacroList.ContainsKey(key))
					{
						goto IL_229;
					}
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					form = new Form2();
					num2 = 7;
					continue;
				case 5:
					return;
				case 6:
					return;
				case 7:
					this.HgcsxIbkl(Form1.OROF9nCl3q4uMeX8ApH(form));
					Form1.nR8KFlAIayfuxUL1pH8(form, this.RotationObj.CR._MacroList[key].Name);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 8:
					goto IL_229;
				case 9:
					return;
				case 10:
				{
					ValueTuple<string, object> valueTuple;
					if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(-2102188928 ^ -2102186576)))
					{
						return;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				case 11:
				{
					ValueTuple<string, object> valueTuple = this.WBrE5Z3CmD();
					num2 = 10;
					continue;
				}
				}
				Form1.TZmYiMAiKRGH0OdKopw(form, this.K4kEWiAGW5(this.RotationObj.CR._MacroList[key]));
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_229:
				if (Form1.R25qmmCXN2J9g6WCi7p(this.RotationObj.CR._MacroList[key].Example, ""))
				{
					num2 = 4;
				}
				else
				{
					this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-1939306647 + 173235911 ^ -1766064388), Form1.Bp8crKQbU76Tg68kvQp(-831735385 ^ -831741571), 48);
					num2 = 9;
				}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000F928 File Offset: 0x0000DB28
		private void LcuEEIQO6v(object \u0020, CancelEventArgs \u0020)
		{
			ContextMenuStrip contextMenuStrip = (ContextMenuStrip)\u0020;
			Form1.auwpOsAZUOh1Ov1sMg7(contextMenuStrip)[0].Enabled = Form1.R25qmmCXN2J9g6WCi7p(this.fEjExORiTp(), "");
			contextMenuStrip.Items[2].Enabled = Form1.t0poRRCb3dy0hjmaGAe(this.WBrE5Z3CmD().Item1, Form1.Bp8crKQbU76Tg68kvQp(1765342390 ^ 1765340550));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000F994 File Offset: 0x0000DB94
		private ValueTuple<string, object> kMtEcHIh0v(int \u0020)
		{
			if (\u0020 > -1 && \u0020 < this.DataGridSpell.RowCount)
			{
				string text = (string)this.DataGridSpell.Rows[\u0020].Tag;
				string text2 = text.Substring(2, text.Length - 2);
				if (text.StartsWith(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1933679734 ^ -1218001364 ^ -1004055906)))
				{
					return new ValueTuple<string, object>(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-613886095 << 1 ^ -1227774010), int.Parse(text2));
				}
				if (text.StartsWith(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1858354135 - 1114350030 ^ 744002257)))
				{
					return new ValueTuple<string, object>(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-717857995 >> 5 ^ -22430733), int.Parse(text2));
				}
				if (text.StartsWith(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-535478164 ^ -535476094)))
				{
					return new ValueTuple<string, object>(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~-531755127 ^ 531757382), text2);
				}
				if (text.StartsWith(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(268802365 >> 1 ^ 134399372)))
				{
					return new ValueTuple<string, object>(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(451337338 ^ 451332428), text2);
				}
			}
			return new ValueTuple<string, object>("", "");
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		private ValueTuple<string, object> WBrE5Z3CmD()
		{
			if (this.DataGridSpell.SelectedRows.Count > 0)
			{
				int index = this.DataGridSpell.SelectedRows[0].Index;
				return this.kMtEcHIh0v(index);
			}
			return new ValueTuple<string, object>("", "");
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000FB44 File Offset: 0x0000DD44
		private string fEjExORiTp()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (Form1.Tax82pAU3vjRnUZrRhF(Form1.UkGlVdA90MYg97LCGUo(this.DataGridSpell)) > 0)
					{
						goto IL_5E;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return "";
			IL_5E:
			return (string)Form1.pcPY5y9KGlwdMXMKiKS(Form1.BY2tjA9UXGPZOAf0dBk(Form1.UkGlVdA90MYg97LCGUo(this.DataGridSpell)[0].Cells, 3));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		private void KhrEuZlNy8(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			DataGridView dataGridView = (DataGridView)\u0020;
			if (\u0020.RowIndex < 0)
			{
				goto IL_4B9;
			}
			int num = 13;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
			{
				num = 29;
			}
			ValueTuple<string, object> valueTuple;
			bool flag;
			for (;;)
			{
				IL_09:
				int num2;
				string text;
				string text2;
				switch (num)
				{
				case 0:
					goto IL_56C;
				case 1:
					goto IL_44D;
				case 2:
					goto IL_478;
				case 3:
					goto IL_592;
				case 4:
					goto IL_287;
				case 5:
					Form1.IWMBi6AOVaRiLvC0OqM(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).DefaultCellStyle, Form1.owsKLyA4wBvfP9xBMsH());
					num = 14;
					continue;
				case 6:
					if (!(valueTuple.Item1 == vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886898924)))
					{
						num = 27;
						continue;
					}
					goto IL_4A8;
				case 7:
					return;
				case 8:
					goto IL_4F6;
				case 9:
					goto IL_24B;
				case 10:
					goto IL_24B;
				case 11:
					goto IL_195;
				case 12:
					goto IL_4B9;
				case 13:
					if (!(valueTuple.Item1 == vua32v5yjQhjRjK4YIO.BRA5TcZvlv(510582717 ^ 510580365)))
					{
						num = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					else if (flag)
					{
						num2 = 16;
					}
					else
					{
						this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(579026892 ^ 579020232), text));
						num = 36;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
						{
							num = 19;
							continue;
						}
						continue;
					}
					break;
				case 14:
					goto IL_649;
				case 15:
					goto IL_4A8;
				case 16:
					this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(212924216 ^ 212922072) + text);
					num = 25;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
					{
						num = 3;
						continue;
					}
					continue;
				case 17:
					return;
				case 18:
					return;
				case 19:
					goto IL_4CE;
				case 20:
					goto IL_5CC;
				case 21:
					this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(-1388170447 ^ -1388173033), text));
					num = 28;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af != 0)
					{
						num = 22;
						continue;
					}
					continue;
				case 22:
					goto IL_668;
				case 23:
					if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(~-1605313923 ^ 1605315752)))
					{
						num = 13;
						continue;
					}
					goto IL_2D0;
				case 24:
					if (valueTuple.Item1 == vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1734223699 - -1503209248 ^ -231016727))
					{
						goto IL_497;
					}
					num = 23;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
					{
						num = 15;
						continue;
					}
					continue;
				case 25:
					goto IL_1F2;
				case 26:
					goto IL_2D0;
				case 27:
					goto IL_1B0;
				case 28:
					goto IL_668;
				case 29:
					if (Form1.BY2tjA9UXGPZOAf0dBk(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).Cells, 5).Value != null)
					{
						num = 34;
						continue;
					}
					goto IL_4B9;
				case 30:
					goto IL_612;
				case 31:
					goto IL_5CC;
				case 32:
					goto IL_5A1;
				case 33:
					goto IL_70E;
				case 34:
				{
					bool flag2 = (bool)Form1.pcPY5y9KGlwdMXMKiKS(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.OVBZrb9ojeyna2RDdQV(dataGridView)[Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)]), 5));
					text2 = (string)Form1.pcPY5y9KGlwdMXMKiKS(Form1.BY2tjA9UXGPZOAf0dBk(Form1.lkI3An9h4MMoumNf3eC(dataGridView.Rows, Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).Cells, 3));
					if (!flag2)
					{
						goto IL_195;
					}
					goto IL_5A1;
				}
				case 35:
					goto IL_BB;
				case 36:
					goto IL_1F2;
				case 37:
					goto IL_612;
				case 38:
					goto IL_322;
				case 39:
					goto IL_497;
				case 40:
					return;
				case 41:
					text = (string)Form1.pcPY5y9KGlwdMXMKiKS(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.lkI3An9h4MMoumNf3eC(dataGridView.Rows, \u0020.RowIndex)), 2));
					flag = (bool)Form1.BY2tjA9UXGPZOAf0dBk(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).Cells, 5).Value;
					num = 24;
					continue;
				default:
					goto IL_56C;
				}
				IL_05:
				num = num2;
				continue;
				IL_BB:
				this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(1157945476 >> 1 ^ 578975196), text));
				num2 = 3;
				goto IL_05;
				IL_195:
				if (Form1.t0poRRCb3dy0hjmaGAe(text2, ""))
				{
					num = 5;
					continue;
				}
				goto IL_44D;
				IL_1F2:
				this.MxXPnSINT1((string)valueTuple.Item2, flag, true);
				num = 18;
				continue;
				IL_24B:
				this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510576253), text));
				num = 33;
				continue;
				IL_287:
				valueTuple = this.kMtEcHIh0v(\u0020.RowIndex);
				num = 41;
				continue;
				IL_56C:
				if (\u0020.RowIndex >= 0)
				{
					goto IL_287;
				}
				num = 8;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
				{
					num = 2;
					continue;
				}
				continue;
				IL_322:
				this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679322096) + text);
				num = 20;
				continue;
				IL_497:
				if (!flag)
				{
					num = 30;
					continue;
				}
				goto IL_322;
				IL_44D:
				Form1.IWMBi6AOVaRiLvC0OqM(Form1.sJUbGPA1F87XKx5jD7y(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), Form1.RTCKYiwDUxx2CWFs9Xr(\u0020))), Form1.pd7LrbAfTlIgHjZelLV());
				num = 12;
				continue;
				IL_4A8:
				if (flag)
				{
					num = 21;
					continue;
				}
				IL_4CE:
				this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(~344187374 ^ -344193975) + text);
				num = 22;
				continue;
				IL_5A1:
				Form1.sJUbGPA1F87XKx5jD7y(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), Form1.RTCKYiwDUxx2CWFs9Xr(\u0020))).BackColor = Form1.R50AVEApehog1u7m1vA();
				num = 2;
				continue;
				IL_5CC:
				this.PlpP7TiE7d((int)valueTuple.Item2, flag, true);
				num = 8;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
				{
					num = 40;
					continue;
				}
				continue;
				IL_612:
				this.WriteLog(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218520867), text));
				num = 31;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea == 0)
				{
					num = 16;
					continue;
				}
				continue;
				IL_668:
				this.jOcPJQZG8P((string)valueTuple.Item2, flag, true);
				num = 7;
				continue;
				IL_2D0:
				if (flag)
				{
					goto IL_BB;
				}
				num = 9;
			}
			return;
			IL_1B0:
			return;
			IL_478:
			goto IL_4B9;
			IL_4F6:
			return;
			IL_592:
			goto IL_70E;
			IL_649:
			goto IL_4B9;
			IL_70E:
			this.YKrP6Pbm3D((int)valueTuple.Item2, flag, true);
			return;
			IL_4B9:
			if (this.isPopulating)
			{
				num = 17;
				goto IL_09;
			}
			if (Form1.fyqaZpwG9rn6JoNyMFh(\u0020) == this.ColDisabled.Index)
			{
				num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
				{
					num = 0;
					goto IL_09;
				}
				goto IL_09;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00010310 File Offset: 0x0000E510
		private void sTHEVX9tZk(object \u0020, DataGridViewCellMouseEventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					if (Form1.XQIYesATie0HrSfWncI(\u0020) == -1)
					{
						return;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (Form1.uMv4MMAFZcnpw03Or0F(\u0020) != Form1.fXqdpEAAZxwNygyDTVE(this.ColDisabled))
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					goto IL_7F;
				}
			}
			return;
			IL_7F:
			this.DataGridSpell.EndEdit();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000103AC File Offset: 0x0000E5AC
		private void kc4EykwsKR(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_28;
				case 1:
					if (\u0020.RowIndex == -1)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (Form1.fyqaZpwG9rn6JoNyMFh(\u0020) != Form1.fXqdpEAAZxwNygyDTVE(this.ColDisabled))
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_28:
			Form1.sLwZW9ARogEIrEZrfRG(this.DataGridSpell);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00010448 File Offset: 0x0000E648
		private void D16E86EP4x(object \u0020, MouseEventArgs \u0020)
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0001044C File Offset: 0x0000E64C
		private void tTiEqKcc7I(object \u0020, DataGridViewCellMouseEventArgs \u0020)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00010450 File Offset: 0x0000E650
		private void L7kEdmBJ7I(object \u0020, MouseEventArgs \u0020)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00010454 File Offset: 0x0000E654
		private void jZQEoVW1yy(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			int num = 6;
			for (;;)
			{
				int num2 = num;
				DataGridView dataGridView;
				for (;;)
				{
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_38;
					case 3:
						Form1.vDEnJBALEixUpl2aVN7(dataGridView, true);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						if (Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.OVBZrb9ojeyna2RDdQV(dataGridView)[Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)]), 1) is DataGridViewComboBoxCell && flag)
						{
							num2 = 3;
							continue;
						}
						return;
					case 5:
						flag2 = (Form1.fyqaZpwG9rn6JoNyMFh(\u0020) == 1);
						goto IL_FF;
					case 6:
						if (Form1.RTCKYiwDUxx2CWFs9Xr(\u0020) != -1)
						{
							num2 = 5;
							continue;
						}
						flag2 = false;
						goto IL_FF;
					}
					Form1.f6Li07AlLLxhacGc2pe((ComboBox)dataGridView.EditingControl, true);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_FF:
					flag = flag2;
					num2 = 2;
				}
				IL_38:
				dataGridView = (\u0020 as DataGridView);
				num = 4;
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0001056C File Offset: 0x0000E76C
		private void cdME3nlFFC(object \u0020, DataGridViewCellValidatingEventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (\u0020.RowIndex == -1)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218525495), Form1.Bp8crKQbU76Tg68kvQp(587114080 ^ 587119848), 16);
					num2 = 7;
					continue;
				case 3:
				{
					DataGridView dataGridView = \u0020 as DataGridView;
					num2 = 4;
					continue;
				}
				case 4:
				{
					DataGridView dataGridView;
					if (Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), Form1.QyjFOvAKC3tZKpJbmVN(\u0020))), 1) is DataGridViewTextBoxCell)
					{
						num2 = 6;
						continue;
					}
					return;
				}
				case 5:
					return;
				case 6:
				{
					DataGridView dataGridView;
					if (Form1.tBmLfKAejD2nitXJts3((DataGridViewTextBoxCell)Form1.ou1LFn9CnJlfE3Jsl57(Form1.OVBZrb9ojeyna2RDdQV(dataGridView)[Form1.QyjFOvAKC3tZKpJbmVN(\u0020)])[1]) != 10)
					{
						return;
					}
					num2 = 8;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 7:
					return;
				case 8:
				{
					int num3;
					if (int.TryParse(Form1.lllqf3Akf7ocUv0LVuV(\u0020.FormattedValue), out num3))
					{
						num2 = 5;
						continue;
					}
					\u0020.Cancel = true;
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				}
				if (Form1.bS06amAaciu5BEFVDsl(\u0020) != 1)
				{
					break;
				}
				num2 = 3;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00010700 File Offset: 0x0000E900
		private void K0NEQWtCWT(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			int num = 6;
			for (;;)
			{
				int num2 = num;
				string text;
				DataGridView dataGridView;
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_1F3;
					case 1:
						return;
					case 2:
						return;
					case 3:
					{
						int objectType = this.RotationObj.CR._RotationSettings[text].ObjectType;
						num2 = 5;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
						{
							num2 = 9;
							continue;
						}
						continue;
					}
					case 4:
						return;
					case 5:
						dataGridView = (DataGridView)\u0020;
						num2 = 13;
						continue;
					case 6:
						if (!this.isPopulating)
						{
							num2 = 5;
							continue;
						}
						return;
					case 7:
						goto IL_258;
					case 8:
						break;
					case 9:
					{
						int objectType;
						switch (objectType)
						{
						case 1:
							if (!int.TryParse((string)Form1.pcPY5y9KGlwdMXMKiKS(Form1.ou1LFn9CnJlfE3Jsl57(dataGridView.Rows[Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)])[1]), out num3))
							{
								goto Block_10;
							}
							goto IL_195;
						case 2:
							goto IL_11D;
						case 3:
							this.ttqPkelxwN(text, (string)Form1.BY2tjA9UXGPZOAf0dBk(Form1.lkI3An9h4MMoumNf3eC(dataGridView.Rows, Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).Cells, 1).Value, true);
							num2 = 1;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							this.ttqPkelxwN(text, (string)Form1.BY2tjA9UXGPZOAf0dBk(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).Cells, 1).Value, true);
							num2 = 2;
							continue;
						}
						return;
					}
					case 10:
						this.ttqPkelxwN(text, num3, true);
						num2 = 12;
						continue;
					case 11:
						return;
					case 12:
						return;
					case 13:
						if (Form1.fyqaZpwG9rn6JoNyMFh(\u0020) != 1)
						{
							return;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 14:
						if (!this.RotationObj.CR._RotationSettings.ContainsKey(text))
						{
							return;
						}
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 15:
						return;
					case 16:
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(1621542659 + 1028479281 ^ -1644938504) + text + Form1.Bp8crKQbU76Tg68kvQp(-552555469 << 5 ^ -501899930));
						num2 = 15;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 != 0)
						{
							num2 = 6;
							continue;
						}
						continue;
					default:
						goto IL_1F3;
					}
					IL_195:
					this.RotationObj.CR._RotationSettings[text].CurrentValue = num3;
					num2 = 10;
					continue;
					IL_258:
					text = (string)Form1.OC0plaArTpT1KWPTYJl(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.lkI3An9h4MMoumNf3eC(Form1.OVBZrb9ojeyna2RDdQV(dataGridView), \u0020.RowIndex)), 0));
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 == 0)
					{
						num2 = 14;
						continue;
					}
					continue;
					IL_1F3:
					if (Form1.RTCKYiwDUxx2CWFs9Xr(\u0020) < 0)
					{
						goto Block_7;
					}
					goto IL_258;
				}
				IL_11D:
				this.ttqPkelxwN(text, (bool)Form1.pcPY5y9KGlwdMXMKiKS(Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.OVBZrb9ojeyna2RDdQV(dataGridView)[Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)]), 1)), true);
				num = 11;
				continue;
				Block_10:
				num = 16;
			}
			return;
			Block_7:;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00010A80 File Offset: 0x0000EC80
		private void fyxEC5gkgr(object \u0020, EventArgs \u0020)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(828767401 >> 3 ^ 103595335), Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134404082), Form1.dL7f3BCYsvs5WvdCOPK(this.textAddonRefreshRate));
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 2:
					this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(Form1.Bp8crKQbU76Tg68kvQp(790722942 ^ 790716998), this.textAddonRefreshRate.Text, Form1.Bp8crKQbU76Tg68kvQp(-1745773992 ^ -1745780420)));
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					if (!this.isPopulating)
					{
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					break;
				case 4:
					goto IL_30;
				}
				break;
			}
			return;
			IL_30:
			this.NoCYLbiqG();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00010BB8 File Offset: 0x0000EDB8
		private void UT0E953o2n(object \u0020, EventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.isPopulating)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					else
					{
						this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(Form1.Bp8crKQbU76Tg68kvQp(1657092858 << 1 ^ -980783516), this.textPulseFrequency.Text, Form1.Bp8crKQbU76Tg68kvQp(-1041647104 ^ -1041653404)));
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				case 2:
					Form1.r6SRRlA7UeL9qLnD1CJ(this.PulseTimer, (double)this.coHmct1JQ(this.textPulseFrequency.Text, 100));
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					goto IL_D4;
				case 4:
					return;
				}
				yQGkVJcOSOQdjuwds7e.ini.SetValue(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1379737334 ^ 1231131185 ^ -459050519), Form1.Bp8crKQbU76Tg68kvQp(581513541 ^ 581511923), Form1.dL7f3BCYsvs5WvdCOPK(this.textPulseFrequency));
				num2 = 3;
			}
			IL_D4:
			this.NoCYLbiqG();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00010CFC File Offset: 0x0000EEFC
		private void KvFEw6f8MB(object \u0020, EventArgs \u0020)
		{
			if (this.RotationObj == null)
			{
				goto IL_3A;
			}
			goto IL_BA;
			int num;
			for (;;)
			{
				IL_09:
				switch (num)
				{
				case 1:
					goto IL_3A;
				case 2:
				{
					this.NoCYLbiqG();
					int num2 = 3;
					num = num2;
					continue;
				}
				case 3:
					return;
				case 4:
					goto IL_BA;
				case 5:
					this.RotationObj.CR.PreCastTimeWindow = this.coHmct1JQ(this.textPreCast.Text, 100);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				}
				break;
			}
			return;
			IL_3A:
			if (!this.isPopulating)
			{
				Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(259176490 ^ 259177208), Form1.Bp8crKQbU76Tg68kvQp(-1734223699 - -1503209248 ^ -231021505), this.textPreCast.Text);
				num = 2;
				goto IL_09;
			}
			num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 != 0)
			{
				num = 0;
				goto IL_09;
			}
			goto IL_09;
			IL_BA:
			this.WriteLog(Form1.K9Pe9MCGnvxj9HG2tCV(Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374430122), Form1.dL7f3BCYsvs5WvdCOPK(this.textPreCast), Form1.Bp8crKQbU76Tg68kvQp(-613886095 << 1 ^ -1227770490)));
			num = 5;
			goto IL_09;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00010E58 File Offset: 0x0000F058
		private void lUnEAuUX3G(object \u0020, EventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.DBLPxXeTOK(true))
					{
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-1992869118 ^ -1992868758), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1750427148 ^ -1750432448), 16);
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				case 2:
					return;
				}
				break;
			}
			this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(~1005505369 ^ -1005508446), Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463911419), 64);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00010F28 File Offset: 0x0000F128
		private void aUZEhKW1OD(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00010F2C File Offset: 0x0000F12C
		private void lcdESXG0qv(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00010F30 File Offset: 0x0000F130
		private void bGnEIsOAQl(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00010F34 File Offset: 0x0000F134
		private void cKREickEAi(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00010F38 File Offset: 0x0000F138
		private void LgTEZbWlNY(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00010F3C File Offset: 0x0000F13C
		private void tqjEUbdvIM(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00010F40 File Offset: 0x0000F140
		private void KP5E133DDE(object \u0020, EventArgs \u0020)
		{
			if (!this.isPopulating)
			{
				if (Form1.QV7X3NA2hAq2jTBgKkc(this.ks, Form1.VuXCjt9QTRVabsm0Q0q(this.comboKeyboard)))
				{
					goto IL_103;
				}
				int num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
				{
					num = 4;
				}
				for (;;)
				{
					IL_09:
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.NoCYLbiqG();
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 == 0)
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_103;
					case 4:
						this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-1199763274 ^ -1199761442), Form1.Bp8crKQbU76Tg68kvQp(152750669 ^ 152754173), 16);
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 5:
						return;
					}
					break;
				}
				return;
				IL_103:
				Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(1638637009 >> 6 ^ 25603237), Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764416157), Form1.dL7f3BCYsvs5WvdCOPK(this.comboKeyboard));
				num = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
				{
					num = 2;
					goto IL_09;
				}
				goto IL_09;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000110B4 File Offset: 0x0000F2B4
		private void SOUEpVuGNI(object \u0020, EventArgs \u0020)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (!this.DBLPxXeTOK(false))
					{
						goto IL_50;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				}
				this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-1003780849 ^ -1003775733), Form1.Bp8crKQbU76Tg68kvQp(1621542659 + 1028479281 ^ -1644937610), 64);
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
				{
					num2 = 2;
				}
			}
			return;
			IL_50:
			this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(828767401 >> 3 ^ 103594237), Form1.Bp8crKQbU76Tg68kvQp(1767032709 ^ 1767037281), 16);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0001118C File Offset: 0x0000F38C
		private void YD3E4VlwQP(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00011190 File Offset: 0x0000F390
		private void ONNEOhLkog(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (Form1.fyqaZpwG9rn6JoNyMFh(\u0020) == Form1.fXqdpEAAZxwNygyDTVE(this.ColBindBtn))
					{
						return;
					}
					num2 = 5;
					break;
				case 2:
					if (Form1.fyqaZpwG9rn6JoNyMFh(\u0020) == this.ColDisabled.Index)
					{
						return;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					Form1.JtpUCIA6ql2rHeWhmlc(this.guna2ProgressIndicator1);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					this.PanelKeyBind.Show();
					num2 = 3;
					break;
				case 5:
					if (Form1.RTCKYiwDUxx2CWFs9Xr(\u0020) == -1)
					{
						return;
					}
					this.KeyBindRow = Form1.RTCKYiwDUxx2CWFs9Xr(\u0020);
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00011294 File Offset: 0x0000F494
		private void cjvEfiBKRs(object \u0020, EventArgs \u0020)
		{
			Process.Start(Form1.Bp8crKQbU76Tg68kvQp(~1053049764 ^ -1053056103));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000112B8 File Offset: 0x0000F4B8
		private void cYNEF6qcZK()
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				DateTime dateTime;
				switch (num2)
				{
				case 1:
				{
					TimeSpan u;
					this.txtLicenseExpiry.Text = Form1.bojNR6AxVgsJ3A8NLLT(dateTime.ToString(), Form1.Bp8crKQbU76Tg68kvQp(-1668754258 ^ -1668746054), this.gHwET9ohqC(u), Form1.Bp8crKQbU76Tg68kvQp(-2083830725 ^ -2083822553));
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 2:
					goto IL_FE;
				case 3:
					if (yQGkVJcOSOQdjuwds7e.AuthenticatedUserData.Username == null)
					{
						num2 = 2;
						continue;
					}
					goto IL_158;
				case 4:
					if (yQGkVJcOSOQdjuwds7e.AuthenticatedUserData == null)
					{
						goto IL_FE;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
				{
					DateTime dateTime2 = dateTime.AddSeconds((double)yQGkVJcOSOQdjuwds7e.AuthenticatedUserData.Expiry);
					num2 = 10;
					continue;
				}
				case 6:
				{
					DateTime t = dateTime;
					DateTime dateTime2 = DateTime.Now;
					if (t < dateTime2.ToLocalTime())
					{
						num2 = 7;
						continue;
					}
					DateTime d = dateTime;
					dateTime2 = DateTime.Now;
					TimeSpan u = d - dateTime2.ToLocalTime();
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 7:
					this.WQxP8vS9pB();
					num2 = 9;
					continue;
				case 8:
					goto IL_158;
				case 9:
					return;
				case 10:
				{
					DateTime dateTime2;
					dateTime = dateTime2.ToLocalTime();
					num2 = 6;
					continue;
				}
				}
				break;
				IL_FE:
				Form1.AwZW73ANDfVtQ8Wom9a();
				num2 = 8;
				continue;
				IL_158:
				this.txtUsername.Text = yQGkVJcOSOQdjuwds7e.AuthenticatedUserData.Username;
				Form1.v5COPWwi2eCOL5fBEpU(this.txtLicenseType, yQGkVJcOSOQdjuwds7e.AuthenticatedUserData.License);
				dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
				num2 = 5;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000114AC File Offset: 0x0000F6AC
		private string gHwET9ohqC(TimeSpan \u0020)
		{
			int num = 1;
			int num2 = num;
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_4A;
				case 1:
					text = Form1.tPRjXMAnjgJBpdn2bDi(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1386050510 + 11679858 ^ 1397722210), (\u0020.Duration().Days <= 0) ? string.Empty : Form1.Q1mXpDw5XrPNoHCtUIq(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(464986539 ^ 464978323), \u0020.Days, (\u0020.Days == 1) ? string.Empty : Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553742571)), (\u0020.Duration().Hours > 0) ? string.Format(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(289037427 >> 1 ^ 144510561), \u0020.Hours, (\u0020.Hours == 1) ? string.Empty : Form1.Bp8crKQbU76Tg68kvQp(587114080 ^ 587116356)) : string.Empty, (\u0020.Duration().Minutes > 0) ? Form1.Q1mXpDw5XrPNoHCtUIq(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1797548854 ^ 1797540684), \u0020.Minutes, (\u0020.Minutes == 1) ? string.Empty : Form1.Bp8crKQbU76Tg68kvQp(-1696412362 - -137042106 ^ -1559368492)) : string.Empty);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					break;
				case 3:
					text = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1714141621 >> 6 ^ 26775106);
					num2 = 4;
					continue;
				case 4:
					return text;
				case 5:
					goto IL_7A;
				default:
					goto IL_4A;
				}
				IL_34:
				if (Form1.fydyYQAJZ7JXnyCmg2b(text))
				{
					num2 = 3;
					continue;
				}
				break;
				IL_7A:
				text = text.Substring(0, text.Length - 2);
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_4A:
				if (!Form1.TCSUtSA0qbO5mKZSB64(text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1308721404 ^ 1308729440)))
				{
					goto IL_34;
				}
				goto IL_7A;
			}
			return text;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00011708 File Offset: 0x0000F908
		private void ftfERfREJm(object \u0020, EventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.WQxP8vS9pB();
					Form1.Kkf2lh9gFFtl0X8OnPB(this.guna2Button5, true);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					Form1.Kkf2lh9gFFtl0X8OnPB(this.guna2Button5, false);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00011794 File Offset: 0x0000F994
		private void I24ELh0UQR(object \u0020, EventArgs \u0020)
		{
			this.cYNEF6qcZK();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0001179C File Offset: 0x0000F99C
		private void foWElCNBCW(object \u0020, EventArgs \u0020)
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					Form1.AwZW73ANDfVtQ8Wom9a();
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					Form1.YcZQDGCrd604D2KnaUs(this, Form1.Bp8crKQbU76Tg68kvQp(-564572999 ^ -564564989), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~344187374 ^ -344178895), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 4:
					Form1.zSl4jPAmUWI3aXVVRsg(yQGkVJcOSOQdjuwds7e.ini);
					Form1.Ne2jFjAHIGhFTjTxmi1();
					num2 = 3;
					continue;
				case 5:
					yQGkVJcOSOQdjuwds7e.ini.SetValue(Form1.Bp8crKQbU76Tg68kvQp(--2124070285 ^ 2124070751), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(835315079 ^ 835315555), "");
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 6:
					this.guna2Button7.Enabled = false;
					num2 = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				Form1.Kkf2lh9gFFtl0X8OnPB(this.guna2Button7, true);
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000118FC File Offset: 0x0000FAFC
		private void oWSEaTalVP(object \u0020, SharpClipboard.ClipboardChangedEventArgs \u0020)
		{
			try
			{
				if (Form1.mFBiPEAttwBGKEuAKZJ(\u0020) == null)
				{
					int num = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 == 0)
					{
						num = 1;
					}
					for (;;)
					{
						string text;
						string u3;
						byte[] u4;
						switch (num)
						{
						case 0:
							goto IL_16B;
						case 1:
						{
							string u = text.Substring(12, Form1.dXPZq9AgCrJqtPRJoa7(text) - 12);
							this.TioEK1kyGk(u);
							num = 8;
							continue;
						}
						case 2:
						{
							string text2;
							byte[] u2 = Form1.qlQRLCA5dcYXyTYPoLX(SHA256.Create(), Form1.A6TDSQAcKqRqD1mtmGh(Encoding.ASCII, text2));
							num = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
							{
								num = 0;
								continue;
							}
							continue;
						}
						case 3:
						{
							u3 = (string)Form1.A9qxBkAYOVqHpKl0B1W(\u0020);
							string text2 = Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(--2124070285 ^ 2124061881), yQGkVJcOSOQdjuwds7e.AuthenticatedUserData.Username);
							num = 2;
							continue;
						}
						case 4:
							if (Form1.R25qmmCXN2J9g6WCi7p(text, ""))
							{
								goto IL_135;
							}
							num = 6;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
							{
								num = 7;
								continue;
							}
							continue;
						case 5:
						{
							byte[] u2;
							text = this.BfAEeDOtLe(u3, u2, u4);
							num = 3;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 != 0)
							{
								num = 4;
								continue;
							}
							continue;
						}
						case 6:
							goto IL_210;
						case 7:
							break;
						case 8:
							Form1.P8VPokAXAGYYix6GMOl(this.previousClipboardContent);
							num = 11;
							continue;
						case 9:
							break;
						case 10:
							goto IL_135;
						case 11:
							goto IL_D6;
						default:
							goto IL_16B;
						}
						IL_A1:
						this.previousClipboardContent = u3;
						num = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
						{
							num = 3;
							continue;
						}
						continue;
						IL_135:
						if (!text.StartsWith(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1089588375 ^ -1089596887)))
						{
							goto IL_A1;
						}
						num = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
						{
							num = 0;
							continue;
						}
						continue;
						IL_16B:
						byte[] array = new byte[16];
						Form1.I4i3UJAsKsZZvMMcHsE(array, fieldof(<PrivateImplementationDetails>.23BB602B8723695D26F37A4FC6A046D7D1084339241A3D4B0A764D1F13CD94A0).FieldHandle);
						u4 = array;
						num = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 != 0)
						{
							num = 5;
						}
					}
					IL_D6:;
				}
				IL_210:;
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00011B4C File Offset: 0x0000FD4C
		private void TioEK1kyGk(string \u0020)
		{
			base.Focus();
			this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(464986539 ^ 464978167));
			int num = 2;
			for (;;)
			{
				Rxlep3aFWM75xoYk07 rxlep3aFWM75xoYk;
				int num2;
				string text2;
				switch (num)
				{
				case 1:
					this.WriteLog(rxlep3aFWM75xoYk.Error);
					num = 17;
					continue;
				case 2:
				{
					string value = yQGkVJcOSOQdjuwds7e.ini.GetValue(Form1.Bp8crKQbU76Tg68kvQp(-865714864 ^ -865714302), Form1.Bp8crKQbU76Tg68kvQp(~-1605313923 ^ 1605314406), Form1.Bp8crKQbU76Tg68kvQp(-1352111144 ^ -1352110102));
					num = 5;
					continue;
				}
				case 4:
				{
					string value;
					string text = Form1.K9Pe9MCGnvxj9HG2tCV(Form1.Bp8crKQbU76Tg68kvQp(-161182833 ^ -161174959), yQGkVJcOSOQdjuwds7e.AuthenticatedUserData.Username, value);
					num2 = 13;
					goto IL_05;
				}
				case 5:
				{
					string value;
					rxlep3aFWM75xoYk = Form1.y9SJnNAM5qLMwgboJZx(value, \u0020);
					num2 = 6;
					goto IL_05;
				}
				case 6:
					if (rxlep3aFWM75xoYk == null)
					{
						return;
					}
					num = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 == 0)
					{
						num = 9;
						continue;
					}
					continue;
				case 7:
					return;
				case 8:
					goto IL_20D;
				case 9:
					if (rxlep3aFWM75xoYk.Error != null)
					{
						num = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
						{
							num = 1;
							continue;
						}
						continue;
					}
					else
					{
						if (rxlep3aFWM75xoYk.Code == null)
						{
							num = 15;
							continue;
						}
						goto IL_155;
					}
					break;
				case 10:
					goto IL_155;
				case 11:
					return;
				case 12:
					goto IL_329;
				case 13:
				{
					string text;
					byte[] u = Form1.mqJliVAGhxhuLmyijAu().ComputeHash(Form1.A6TDSQAcKqRqD1mtmGh(Form1.VBBke5ABL0fGVx6oWe0(), text));
					byte[] array = new byte[16];
					Form1.I4i3UJAsKsZZvMMcHsE(array, fieldof(<PrivateImplementationDetails>.645CBB3A09696E08B9F8DF545107D27F009E8665E1F1FFE8BD74BFA5A8B5ED89).FieldHandle);
					byte[] u2 = array;
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
					{
						num = 16;
						continue;
					}
					continue;
				}
				case 14:
					this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-1745773992 ^ -1745773264), Form1.Bp8crKQbU76Tg68kvQp(-33448599 >> 2 ^ -8363988), 16);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 16:
				{
					byte[] u;
					byte[] u2;
					text2 = this.BfAEeDOtLe(rxlep3aFWM75xoYk.Code, u, u2);
					num = 18;
					continue;
				}
				case 17:
					return;
				case 18:
					if (!Form1.R25qmmCXN2J9g6WCi7p(text2, ""))
					{
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-940667910 + -206218605 ^ -1146894465));
						num = 14;
						continue;
					}
					goto IL_20D;
				}
				break;
				IL_05:
				num = num2;
				continue;
				IL_155:
				this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-911697958 - 376275890 ^ -1287965310) + rxlep3aFWM75xoYk.Title);
				num = 4;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba != 0)
				{
					num = 2;
					continue;
				}
				continue;
				IL_20D:
				if (this.uMJPEie7eU(text2))
				{
					num = 3;
					continue;
				}
				IL_329:
				this.a1iPoaymn2(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1183576799 ^ -1183577527), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1765342390 ^ 1765342144), 16);
				num = 11;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00011EB4 File Offset: 0x000100B4
		private string BfAEeDOtLe(string \u0020, byte[] \u0020, byte[] \u0020)
		{
			string result;
			try
			{
				Aes aes = Aes.Create();
				Form1.Or1pbIADv1aJKprm95B(aes, CipherMode.CBC);
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c == 0)
				{
					num = 6;
				}
				string text;
				for (;;)
				{
					MemoryStream memoryStream;
					ICryptoTransform transform;
					switch (num)
					{
					case 0:
						goto IL_44;
					case 1:
						aes.IV = \u0020;
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						try
						{
							byte[] array = Form1.YNLgDQ9H3N5sF2omwls(\u0020);
							int num2 = 2;
							for (;;)
							{
								CryptoStream cryptoStream;
								byte[] array2;
								switch (num2)
								{
								case 1:
									goto IL_168;
								case 2:
									cryptoStream.Write(array, 0, array.Length);
									num2 = 0;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 3:
									text = Form1.shNpO2AbP2HNnJXWn67(Form1.VBBke5ABL0fGVx6oWe0(), array2, 0, array2.Length);
									num2 = 1;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 == 0)
									{
										num2 = 1;
										continue;
									}
									continue;
								}
								Form1.RcEYAhAjnDiXquWMER9(cryptoStream);
								array2 = memoryStream.ToArray();
								num2 = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 != 0)
								{
									num2 = 3;
								}
							}
							IL_168:
							goto IL_3B;
						}
						finally
						{
							Form1.w7YVoeAz5uxNKRp4KoW(memoryStream);
							int num3 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							default:
							{
								CryptoStream cryptoStream;
								Form1.w7YVoeAz5uxNKRp4KoW(cryptoStream);
								break;
							}
							}
						}
						goto IL_1C7;
					case 3:
						goto IL_3B;
					case 4:
					{
						CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						num = 7;
						continue;
					}
					case 5:
						goto IL_1C7;
					case 6:
						Form1.Hvv9pDAvhuIUo91bAqb(aes, \u0020);
						num = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
						{
							num = 1;
							continue;
						}
						continue;
					case 7:
						text = "";
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
						{
							num = 2;
							continue;
						}
						continue;
					default:
						goto IL_44;
					}
					IL_0D:
					int num4;
					num = num4;
					continue;
					IL_44:
					memoryStream = new MemoryStream();
					num4 = 5;
					goto IL_0D;
					IL_1C7:
					transform = aes.CreateDecryptor();
					num4 = 4;
					goto IL_0D;
				}
				IL_3B:
				result = text;
			}
			catch (Exception)
			{
				result = "";
				int num5 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
			}
			return result;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00012160 File Offset: 0x00010360
		private void rL0Ekwd61e(object \u0020, CoreWebView2InitializationCompletedEventArgs \u0020)
		{
			int num = 4;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Form1.HpSj1ShxJrFDYM9mKKh(Form1.zUUh4ThP0Cc01ljHSYy(this.webView21).Settings, false);
					Form1.isrmPlhcCJpL6lhWQ33(Form1.zUUh4ThP0Cc01ljHSYy(this.webView21)).AreDevToolsEnabled = false;
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 2:
					Form1.xqTYPEh8U46L1n2RUWw(Form1.zUUh4ThP0Cc01ljHSYy(this.webView21).Settings, false);
					num2 = 7;
					continue;
				case 3:
					Form1.KONeC5hEKxX0Z0ta49X(Form1.zUUh4ThP0Cc01ljHSYy(this.webView21).Settings, false);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
				case 4:
				{
					string text = Form1.gCfIFQhWEiQQUoe2LbH(Form1.JreG9FCJDuB09aS2wIs(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(1074597531 ^ 1074596937), Form1.Bp8crKQbU76Tg68kvQp(185404423 + 1853889833 ^ 2039294932), Form1.Bp8crKQbU76Tg68kvQp(996650866 + -609199087 ^ 387452849)));
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 5:
					Form1.xEyOJlhycZJ4bCYeokt(Form1.zUUh4ThP0Cc01ljHSYy(this.webView21).Settings, false);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 6:
					Form1.isrmPlhcCJpL6lhWQ33(Form1.zUUh4ThP0Cc01ljHSYy(this.webView21)).IsGeneralAutofillEnabled = false;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
				{
					string text;
					Form1.K0eZHIhqibE7gQmMyZe(this.webView21.CoreWebView2, text);
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
					{
						num2 = 9;
						continue;
					}
					continue;
				}
				case 8:
					Form1.Um95h5h5y5PURIROh8b(Form1.isrmPlhcCJpL6lhWQ33(Form1.zUUh4ThP0Cc01ljHSYy(this.webView21)), false);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 9:
					return;
				}
				Form1.NSHU0QhuMMlNtgBZOOS(Form1.isrmPlhcCJpL6lhWQ33(this.webView21.CoreWebView2), false);
				Form1.TrJet9hVwrXyrUFBPF0(Form1.isrmPlhcCJpL6lhWQ33(this.webView21.CoreWebView2), false);
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
				{
					num2 = 5;
				}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000123BC File Offset: 0x000105BC
		private void jSiErYjHGN(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000123C0 File Offset: 0x000105C0
		private void lylE711fuA(object \u0020, CoreWebView2WebMessageReceivedEventArgs \u0020)
		{
			int num = 3;
			int num2 = num;
			string[] array;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (array.Length == 2)
					{
						num2 = 7;
						continue;
					}
					return;
				case 2:
				{
					string text;
					if (Form1.R25qmmCXN2J9g6WCi7p(text, ""))
					{
						num2 = 5;
						continue;
					}
					return;
				}
				case 3:
				{
					string text = Form1.eU2YUmhdXSY7sxouHZn(\u0020);
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 4:
					this.TioEK1kyGk(array[1]);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 5:
				{
					string text;
					if (text == null)
					{
						return;
					}
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
				}
				case 6:
				{
					string text2;
					if (Form1.t0poRRCb3dy0hjmaGAe(text2, Form1.Bp8crKQbU76Tg68kvQp(-309791748 - 2077333185 ^ 1907851021)))
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					else
					{
						if (Form1.t0poRRCb3dy0hjmaGAe(text2, Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553737101)))
						{
							goto IL_10D;
						}
						num2 = 9;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				case 7:
				{
					string text2 = array[0];
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				}
				case 8:
				{
					string text;
					array = text.Split(new char[]
					{
						':'
					});
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				case 9:
					return;
				}
				break;
			}
			return;
			IL_10D:
			Process.Start(Form1.Pp4QKUC71vtkcGEBPyV(Form1.Bp8crKQbU76Tg68kvQp(464986539 ^ 464978917), array[1]));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00012598 File Offset: 0x00010798
		private void PxaE2vArLc(object \u0020, EventArgs \u0020)
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return;
				case 2:
					goto IL_60;
				case 3:
					this.NoCYLbiqG();
					num2 = 7;
					continue;
				case 4:
					goto IL_BA;
				case 5:
					if (Form1.hmoH8S9qggmufh0cX8H(this.toggleManualCastQueue))
					{
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(152750669 ^ 152758523));
						num2 = 8;
						continue;
					}
					break;
				case 6:
					if (this.RotationObj == null)
					{
						goto IL_60;
					}
					num2 = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					return;
				case 8:
					goto IL_BA;
				}
				this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(268206341 ^ 268215273));
				num2 = 4;
				continue;
				IL_60:
				if (!this.isPopulating)
				{
					Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(145144672 << 4 ^ -1972652846), Form1.Bp8crKQbU76Tg68kvQp(-1696412362 - -137042106 ^ -1559378220), this.LoQPHyeILJ(Form1.hmoH8S9qggmufh0cX8H(this.toggleManualCastQueue)));
					num2 = 3;
					continue;
				}
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_BA:
				this.RotationObj.CR._EnableManualCastQueue = Form1.hmoH8S9qggmufh0cX8H(this.toggleManualCastQueue);
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0001273C File Offset: 0x0001093C
		private void oBeE6By6hS(object \u0020, FormClosingEventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					Form1.tf1IRnh3KfRL7nHrgBI(this.ks.input);
					goto IL_57;
				case 2:
					if (!Form1.GA7nSPhom1mPs43ihkM(this.ks.input))
					{
						goto IL_57;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
				IL_57:
				Form1.pHs98vhQco1vII4ggHY(0);
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 != 0)
				{
					num2 = 0;
				}
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000127D8 File Offset: 0x000109D8
		private void OwCENMvKJ9(object \u0020, DataGridViewDataErrorEventArgs \u0020)
		{
			\u0020.Cancel = true;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000127E8 File Offset: 0x000109E8
		private void Ww0Encmx5U(object \u0020, DataGridViewCellEventArgs \u0020)
		{
			try
			{
				if (Form1.fyqaZpwG9rn6JoNyMFh(\u0020) == 0 && \u0020.RowIndex >= 0)
				{
					int num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num = 0;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							Form1.jjZ4QDh9WnrfumnYDdq(this.toolTip1, this.DataGridSettings, Form1.dw09RchCcS3CmseATIW(this.DataGridSettings, \u0020.ColumnIndex, Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).ToolTipText);
							num = 2;
							continue;
						case 2:
							goto IL_D3;
						}
						if (!Form1.R25qmmCXN2J9g6WCi7p(Form1.dw09RchCcS3CmseATIW(this.DataGridSettings, \u0020.ColumnIndex, Form1.RTCKYiwDUxx2CWFs9Xr(\u0020)).ToolTipText, ""))
						{
							break;
						}
						num = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c != 0)
						{
							num = 1;
						}
					}
				}
				IL_D3:;
			}
			catch
			{
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000128EC File Offset: 0x00010AEC
		private void o30E0pYois(object \u0020, EventArgs \u0020)
		{
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_101;
					case 1:
						if (Form1.hmoH8S9qggmufh0cX8H(this.toggleAttackOutOfCombat))
						{
							num2 = 7;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(850579974 + 1765464631 ^ -1678929985));
							num2 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						if (this.RotationObj != null)
						{
							num2 = 0;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 == 0)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 3:
						return;
					case 4:
						goto IL_101;
					case 5:
						goto IL_196;
					case 6:
						yQGkVJcOSOQdjuwds7e.ini.SetValue(Form1.Bp8crKQbU76Tg68kvQp(-717857995 >> 5 ^ -22433781), Form1.Bp8crKQbU76Tg68kvQp(-552555469 << 5 ^ -501897824), this.LoQPHyeILJ(Form1.hmoH8S9qggmufh0cX8H(this.toggleAttackOutOfCombat)));
						num2 = 5;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 7:
						this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553736841));
						num2 = 4;
						continue;
					case 8:
						return;
					default:
						goto IL_101;
					}
					IL_EC:
					if (!this.isPopulating)
					{
						num2 = 6;
						continue;
					}
					return;
					IL_101:
					this.RotationObj.CR._AttackPlayerNotInCombat = this.toggleAttackOutOfCombat.Checked;
					goto IL_EC;
				}
				IL_196:
				this.NoCYLbiqG();
				num = 8;
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00012AA4 File Offset: 0x00010CA4
		private void TvaEJRleMj(object \u0020, EventArgs \u0020)
		{
			int num = 6;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_112;
				case 1:
					goto IL_122;
				case 2:
					return;
				case 3:
					break;
				case 4:
					this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(--1722095099 ^ 1722103325));
					num2 = 8;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
				case 5:
					if (this.toggleAutoTab.Checked)
					{
						num2 = 4;
						continue;
					}
					goto IL_122;
				case 6:
					if (this.RotationObj != null)
					{
						num2 = 5;
						continue;
					}
					break;
				case 7:
					goto IL_ED;
				case 8:
					goto IL_ED;
				default:
					goto IL_112;
				}
				if (this.isPopulating)
				{
					break;
				}
				Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1657092858 << 1 ^ -980781274), Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463897053), this.LoQPHyeILJ(Form1.hmoH8S9qggmufh0cX8H(this.toggleAutoTab)));
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_ED:
				this.RotationObj.CR._AutoTab = Form1.hmoH8S9qggmufh0cX8H(this.toggleAutoTab);
				num2 = 3;
				continue;
				IL_112:
				this.NoCYLbiqG();
				num2 = 2;
				continue;
				IL_122:
				this.WriteLog(Form1.Bp8crKQbU76Tg68kvQp(-256932895 ^ -256923669));
				num2 = 5;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
				{
					num2 = 7;
				}
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00012C44 File Offset: 0x00010E44
		private void TklEm7gGaH(object \u0020, EventArgs \u0020)
		{
			this.DataGridSettings.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00012C64 File Offset: 0x00010E64
		private void MdCEHVZI5R(object \u0020, KeyEventArgs \u0020)
		{
			\u0020.Handled = true;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00012C78 File Offset: 0x00010E78
		private void ToxEtY80GO(object \u0020, EventArgs \u0020)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this.VSwXr9cV0(true);
					Form1.Kkf2lh9gFFtl0X8OnPB(this.guna2Button8, true);
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					Form1.Kkf2lh9gFFtl0X8OnPB(this.guna2Button8, false);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				break;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00012D08 File Offset: 0x00010F08
		private void G4UEYoOwtn(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00012D0C File Offset: 0x00010F0C
		private void fpgEsMDB25(object \u0020, EventArgs \u0020)
		{
			int num = 7;
			for (;;)
			{
				int num2 = num;
				string text;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_17A;
					case 2:
						this.a1iPoaymn2(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-940667910 + -206218605 ^ -1146895665), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1815843576 ^ -1815852704), 64);
						num2 = 4;
						continue;
					case 3:
						goto IL_17A;
					case 4:
						return;
					case 5:
						Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1638637009 >> 6 ^ 25601633), this.LoQPHyeILJ(this.toggleAutoBind.Checked));
						this.NoCYLbiqG();
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 != 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 6:
						if (this.isPopulating)
						{
							return;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 7:
						Form1.Kkf2lh9gFFtl0X8OnPB(this.btnReGenerateAddon, this.toggleAutoBind.Checked);
						num2 = 6;
						continue;
					case 8:
						goto IL_12C;
					case 9:
						if (text != "")
						{
							num2 = 5;
							continue;
						}
						goto IL_17A;
					}
					if (this.RotationObj != null)
					{
						break;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_17A:
					if (!Form1.hmoH8S9qggmufh0cX8H(this.toggleAutoBind))
					{
						return;
					}
					num2 = 2;
				}
				IL_12C:
				text = this.eQ0PRDEBNy();
				num = 9;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00012ECC File Offset: 0x000110CC
		private void nQxEgvxUEU(object \u0020, EventArgs \u0020)
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_3D;
					case 2:
						this.REbz8r6MU();
						num2 = 5;
						continue;
					case 3:
						if (this.RotationObj != null)
						{
							num2 = 2;
							continue;
						}
						goto IL_3D;
					case 4:
						return;
					case 5:
						if (!this.c87PPMGnNc(this.payload))
						{
							num2 = 6;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 != 0)
							{
								num2 = 7;
								continue;
							}
							continue;
						}
						break;
					case 6:
						return;
					case 7:
						this.a1iPoaymn2(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1366152946 ^ -1366160380), Form1.Bp8crKQbU76Tg68kvQp(-1224731037 ^ -1224724373), 16);
						num2 = 6;
						continue;
					}
					goto Block_1;
				}
				IL_3D:
				this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(-253515656 ^ -1789645123 ^ 1706533839), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1797548854 ^ 1797541400), 16);
				num = 4;
			}
			Block_1:
			this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(579026892 ^ 579017370), Form1.Bp8crKQbU76Tg68kvQp(-789419076 ^ -35552607 ^ 756272225), 64);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00013048 File Offset: 0x00011248
		private void EZAEX9oRuv(object \u0020, EventArgs \u0020)
		{
			int num = 15;
			for (;;)
			{
				int num2 = num;
				int num3;
				int num5;
				List<string> list;
				for (;;)
				{
					ValueTuple<string, object> valueTuple;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_60D;
					case 1:
						return;
					case 2:
						goto IL_386;
					case 3:
						goto IL_688;
					case 4:
						goto IL_D0;
					case 5:
						if (this.DataGridSpell.RowCount <= 0)
						{
							num2 = 38;
							continue;
						}
						goto IL_D0;
					case 6:
						num3 = 0;
						num2 = 27;
						continue;
					case 7:
						goto IL_2A7;
					case 8:
						goto IL_538;
					case 9:
						this.GmXPMShcpi((int)valueTuple.Item2, (string)Form1.pcPY5y9KGlwdMXMKiKS(Form1.BY2tjA9UXGPZOAf0dBk(Form1.OVBZrb9ojeyna2RDdQV(this.DataGridSpell)[num4].Cells, 3)), true);
						num2 = 17;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
						{
							num2 = 30;
							continue;
						}
						continue;
					case 10:
						if (!(valueTuple.Item1 == vua32v5yjQhjRjK4YIO.BRA5TcZvlv(881693030 + 414722879 ^ 1296414081)))
						{
							goto IL_485;
						}
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
						{
							num2 = 24;
							continue;
						}
						continue;
					case 11:
						break;
					case 12:
						goto IL_44F;
					case 13:
						goto IL_485;
					case 14:
						if (Form1.YcZQDGCrd604D2KnaUs(this, Form1.Bp8crKQbU76Tg68kvQp(-1050340572 ^ -1050331740), Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510589109), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
						{
							return;
						}
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 15:
						if (this.RotationObj != null)
						{
							num2 = 14;
							continue;
						}
						goto IL_2A7;
					case 16:
						goto IL_538;
					case 17:
						goto IL_4CF;
					case 18:
						goto IL_192;
					case 19:
						goto IL_1A2;
					case 20:
						break;
					case 21:
						this.q68PGtQd25((string)valueTuple.Item2, (string)Form1.ou1LFn9CnJlfE3Jsl57(this.DataGridSpell.Rows[num4])[3].Value, true);
						goto IL_192;
					case 22:
						if (!Form1.hmoH8S9qggmufh0cX8H(this.toggleAutoBind))
						{
							goto Block_24;
						}
						goto IL_652;
					case 23:
						if (Form1.CannotUseShift.Contains(Form1.AutoBindList[num5]))
						{
							goto IL_538;
						}
						goto IL_3F5;
					case 24:
						this.NB3PXVFFB9((int)valueTuple.Item2, (string)Form1.BY2tjA9UXGPZOAf0dBk(Form1.ou1LFn9CnJlfE3Jsl57(Form1.lkI3An9h4MMoumNf3eC(this.DataGridSpell.Rows, num4)), 3).Value, true);
						num2 = 18;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 25:
						goto IL_3F5;
					case 26:
						goto IL_652;
					case 27:
						goto IL_386;
					case 28:
						if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1199763274 ^ -1199766144)))
						{
							goto Block_5;
						}
						goto IL_192;
					case 29:
						if (Form1.R25qmmCXN2J9g6WCi7p(Form1.AutoBindModifierList[num3], ""))
						{
							num2 = 12;
							continue;
						}
						list.Add(Form1.AutoBindList[num5]);
						num2 = 16;
						continue;
					case 30:
						goto IL_192;
					case 31:
						goto IL_688;
					case 32:
						goto IL_678;
					case 33:
						goto IL_1A2;
					case 34:
						goto IL_1CF;
					case 35:
						goto IL_50A;
					case 36:
						if (num4 >= Form1.JSwh4OhwKkR6QvxFcsw(list) - 1)
						{
							goto IL_192;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 37:
						return;
					case 38:
						goto IL_5EE;
					default:
						goto IL_60D;
					}
					if (num5 < Form1.AutoBindList.Length)
					{
						num2 = 29;
						continue;
					}
					goto IL_678;
					IL_D0:
					list = new List<string>();
					num2 = 6;
					continue;
					IL_192:
					num4++;
					num2 = 19;
					continue;
					IL_4CF:
					if (!(valueTuple.Item1 == Form1.Bp8crKQbU76Tg68kvQp(-185008287 ^ -185010607)))
					{
						goto IL_192;
					}
					num2 = 18;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
					{
						num2 = 21;
						continue;
					}
					continue;
					IL_1A2:
					if (num4 >= Form1.nv6npl9aKjnqZefm9T5(this.DataGridSpell))
					{
						num2 = 9;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
						{
							num2 = 22;
							continue;
						}
						continue;
					}
					else
					{
						valueTuple = this.kMtEcHIh0v(num4);
						num2 = 28;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
						{
							num2 = 28;
							continue;
						}
						continue;
					}
					IL_1CF:
					num4 = 0;
					num2 = 17;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c7104ccd40024e009409c6d14eb5a99a == 0)
					{
						num2 = 33;
						continue;
					}
					continue;
					IL_386:
					if (num3 >= Form1.AutoBindModifierList.Length)
					{
						goto IL_1CF;
					}
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_2A7:
					this.a1iPoaymn2(Form1.Bp8crKQbU76Tg68kvQp(~-1605313923 ^ 1605304456), Form1.Bp8crKQbU76Tg68kvQp(-886904286 ^ -886911220), 16);
					num2 = 37;
					continue;
					IL_538:
					num5++;
					num2 = 20;
					continue;
					IL_60D:
					Form1.ze7t0E9w2LsX5xTVcPJ(this.DataGridSpell.Rows[num4].Cells[3], list[num4]);
					num2 = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 == 0)
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_652:
					Form1.Kkf2lh9gFFtl0X8OnPB(this.btnReGenerateAddon, true);
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_678:
					num3++;
					num2 = 2;
					continue;
					IL_688:
					num5 = 0;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e != 0)
					{
						num2 = 11;
						continue;
					}
					continue;
					IL_485:
					if (!Form1.t0poRRCb3dy0hjmaGAe(valueTuple.Item1, Form1.Bp8crKQbU76Tg68kvQp(-825446221 ^ -825443943)))
					{
						goto IL_4CF;
					}
					num2 = 9;
				}
				Block_5:
				num = 36;
				continue;
				IL_3F5:
				list.Add(Form1.AutoBindModifierList[num3] + Form1.Bp8crKQbU76Tg68kvQp(-764151834 ^ -764157226) + Form1.AutoBindList[num5]);
				num = 8;
				continue;
				Block_24:
				num = 35;
				continue;
				IL_44F:
				if (!Form1.t0poRRCb3dy0hjmaGAe(Form1.AutoBindModifierList[num3], vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-33448599 >> 2 ^ -8359348)))
				{
					goto IL_3F5;
				}
				num = 23;
			}
			return;
			IL_50A:
			IL_5EE:;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00013710 File Offset: 0x00011910
		private void bI8EMuHWqG(object \u0020, EventArgs \u0020)
		{
			if (this.isPopulating)
			{
				return;
			}
			Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(-1399929319 << 3 ^ 1685467674), Form1.Bp8crKQbU76Tg68kvQp(~1053049764 ^ -1053058185), this.comboPixelLocation.Text);
			int num = 1;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					this.NoCYLbiqG();
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000137C0 File Offset: 0x000119C0
		private void F7ZEGtXl5q(object \u0020, EventArgs \u0020)
		{
			int num = 8;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1A6;
					case 1:
						break;
					case 2:
						return;
					case 3:
						goto IL_88;
					case 4:
						goto IL_101;
					case 5:
						goto IL_176;
					case 6:
						yQGkVJcOSOQdjuwds7e.ini.SetValue(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886904592), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352740968 ^ -1352734616), this.LoQPHyeILJ(Form1.hmoH8S9qggmufh0cX8H(this.toggleAttackTargetNotInCombat)));
						num2 = 9;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
						{
							num2 = 7;
							continue;
						}
						continue;
					case 7:
						if (this.toggleAttackTargetNotInCombat.Checked)
						{
							goto IL_88;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 8:
						if (this.RotationObj != null)
						{
							goto Block_4;
						}
						goto IL_101;
					case 9:
						this.NoCYLbiqG();
						num2 = 2;
						continue;
					default:
						goto IL_1A6;
					}
					IL_B9:
					this.RotationObj.CR._AttackTargetNotInCombat = this.toggleAttackTargetNotInCombat.Checked;
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_88:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1526149240 >> 4 ^ 95376461));
					goto IL_B9;
					IL_101:
					if (!this.isPopulating)
					{
						num2 = 6;
						continue;
					}
					return;
					IL_176:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352740968 ^ -1352734716));
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_1A6:
					goto IL_176;
				}
				Block_4:
				num = 7;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00013984 File Offset: 0x00011B84
		private void pgQEBUuSJP(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00013988 File Offset: 0x00011B88
		private void ysDEDSih55(object \u0020, EventArgs \u0020)
		{
			if (!this.isPopulating)
			{
				Form1.dqlXqlwJW7DeFVLCb8n(yQGkVJcOSOQdjuwds7e.ini, Form1.Bp8crKQbU76Tg68kvQp(1810931007 ^ 1810931693), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(828767401 >> 3 ^ 103585719), this.comboGameVersion.Text);
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.NoCYLbiqG();
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
				return;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00013B28 File Offset: 0x00011D28
		private void RrpEvm3iON()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(Type.GetTypeFromHandle(Form1.pHJddX9jNf3s9CAWG8N(33554461)));
			int num = 1128;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					goto IL_D7B1;
				case 1:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2TabControl2, new Size(731, 420));
					num = 823;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d == 0)
					{
						num = 532;
						continue;
					}
					continue;
				case 2:
					Form1.UPgX00hIfNTJfSQunfn(this.guna2BorderlessForm1, true);
					num = 946;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
					{
						num = 1346;
						continue;
					}
					continue;
				case 3:
					Form1.u2jKCGiuYuHiMgf1sx7(this.textPreCast, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1755352853 ^ -1755359017), 9f));
					num = 173;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 != 0)
					{
						num = 156;
						continue;
					}
					continue;
				case 4:
					this.menuStrip1.Padding = new Padding(5, 2, 0, 2);
					num = 249;
					continue;
				case 5:
					this.guna2Button8 = new Guna2Button();
					num = 1151;
					continue;
				case 6:
					this.guna2GradientPanel1.Margin = new Padding(2);
					num2 = 1360;
					break;
				case 7:
					this.ColSettingsValue = new DataGridViewTextBoxColumn();
					num = 697;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
					{
						num = 766;
						continue;
					}
					continue;
				case 8:
					Form1.NEVx6ciQWUA1CnM79yH(this.comboPixelLocation, 30);
					num = 1164;
					continue;
				case 9:
					Form1.MBxdu8iw8gTc2lKiMol(this.comboGameVersion, new EventHandler(this.ysDEDSih55));
					num = 301;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 != 0)
					{
						num = 357;
						continue;
					}
					continue;
				case 10:
					Form1.rNH3WfhJCd14ZcstGLE(this.tabLog, 1);
					Form1.U3XM2Qhm2XM60XWh7EK(this.tabLog, new Point(184, 4));
					num2 = 521;
					break;
				case 11:
					Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAttackOutOfCombat).InnerColor = Form1.pd7LrbAfTlIgHjZelLV();
					Form1.fSKvdPhXB121ntJCND9(this.toggleAttackOutOfCombat, new Point(12, 113));
					num2 = 115;
					break;
				case 12:
					Form1.bAfsNnixIiVZajHwRbB(this.textPulseFrequency, Form1.VA4WwsiygtFFKaVPeZt());
					num2 = 429;
					break;
				case 13:
					this.guna2TabSettings.Dock = DockStyle.Fill;
					this.guna2TabSettings.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-1696412362 - -137042106 ^ -1559376436), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1168;
					continue;
				case 14:
					this.comboPixelLocation.DropDownStyle = ComboBoxStyle.DropDownList;
					num = 229;
					continue;
				case 15:
					this.webView21.EndInit();
					num = 495;
					continue;
				case 16:
					this.removeScriptToolStripMenuItem = new ToolStripMenuItem();
					num = 599;
					continue;
				case 17:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabAccount), this.label10);
					num = 82;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 != 0)
					{
						num = 13;
						continue;
					}
					continue;
				case 18:
					Form1.wxMaZnI7u1L89VdGNLA(this.label15, true);
					num = 908;
					continue;
				case 19:
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabPage2.Controls, this.label7);
					num = 792;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 == 0)
					{
						num = 1327;
						continue;
					}
					continue;
				case 20:
					Form1.UtcbqjSETttS7ihWoUi(this.listView1.Columns, new ColumnHeader[]
					{
						this.columnHeader1,
						this.columnHeader2
					});
					num = 587;
					continue;
				case 21:
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					Form1.B9NkxySv08excapIeQS(dataGridViewCellStyle, Form1.Y1UIkkw4SWDmFnSC63U(231, 229, 255));
					num = 723;
					continue;
				}
				case 22:
					Form1.rNXejGSp5vN1fxhySyd(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button7), Color.DarkGray);
					num = 1289;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
					{
						num = 1082;
						continue;
					}
					continue;
				case 23:
					this.DataGridSpell.AllowUserToDeleteRows = false;
					num = 1363;
					continue;
				case 24:
					Form1.a5OmidS81nno4H3n5TQ(this.listView1, new EventHandler(this.VQOPixEpHO));
					num = 570;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a != 0)
					{
						num = 688;
						continue;
					}
					continue;
				case 25:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabPage4, true);
					num = 20;
					continue;
				case 26:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button7, Form1.Bp8crKQbU76Tg68kvQp(-1746511494 ^ -1746508968));
					num = 838;
					continue;
				case 27:
					Form1.cjbEqXhOkHto9Mpb3TF(this.guna2GradientPanel1.Controls, this.guna2ControlBox1);
					num = 1120;
					continue;
				case 28:
					Form1.F8DDPrC4dhV11PnsIC6(this.menuStrip1, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1007749927 ^ -1007756059), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 323;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num = 145;
						continue;
					}
					continue;
				case 29:
					Form1.DIHdSHS7iP1A7KmNMB1(this.btnStartStop.DisabledState, Color.DarkGray);
					num = 1291;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
					{
						num = 1309;
						continue;
					}
					continue;
				case 30:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabAccount, true);
					num = 631;
					continue;
				case 31:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					Form1.cCHgJfSYhohxmE8w4BT(dataGridViewCellStyle2, Form1.pd7LrbAfTlIgHjZelLV());
					Form1.B9NkxySv08excapIeQS(dataGridViewCellStyle2, Form1.SpVp1pSsuOkIuaZ0gb7());
					num = 68;
					continue;
				}
				case 32:
					Form1.c0T4oUhzseliJt6JbSj(this.comboGameVersion, 25);
					num = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
					{
						num = 5;
						continue;
					}
					continue;
				case 33:
					Form1.fSKvdPhXB121ntJCND9(this.label17, new Point(279, 196));
					num = 318;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 != 0)
					{
						num = 280;
						continue;
					}
					continue;
				case 34:
					Form1.BYULIGhFpBJPZrMGUKF(this.label16, Form1.Bp8crKQbU76Tg68kvQp(-860087180 << 5 ^ -1752973394));
					num = 902;
					continue;
				case 35:
					this.ColIcon = new DataGridViewImageColumn();
					num2 = 491;
					break;
				case 36:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2).Add(this.guna2Button2);
					num = 394;
					continue;
				case 37:
					this.comboKeyboard.DrawMode = DrawMode.OwnerDrawFixed;
					num = 1351;
					continue;
				case 38:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button4, new Font(Form1.Bp8crKQbU76Tg68kvQp(-552555469 << 5 ^ -501895588), 9f));
					this.guna2Button4.ForeColor = Color.White;
					num = 526;
					continue;
				case 39:
					this.guna2TabControl2.TabMenuOrientation = 0;
					num2 = 543;
					break;
				case 40:
					this.toggleManualCastQueue = new Guna2ToggleSwitch();
					num = 1079;
					continue;
				case 41:
					Form1.PMxUPdSrxvVlWwnXnBc(this.guna2Button2, true);
					num = 325;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
					{
						num = 74;
						continue;
					}
					continue;
				case 42:
				{
					Guna2NumericUpDown guna2NumericUpDown = this.textAddonRefreshRate;
					int[] array = new int[4];
					array[0] = 1000;
					guna2NumericUpDown.Maximum = new decimal(array);
					num = 57;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb != 0)
					{
						num = 26;
						continue;
					}
					continue;
				}
				case 43:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabLog, Form1.Bp8crKQbU76Tg68kvQp(850579974 + 1765464631 ^ -1678933977));
					num = 1259;
					continue;
				case 44:
					Form1.PMxUPdSrxvVlWwnXnBc(this.guna2Button6, true);
					num = 1270;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 == 0)
					{
						num = 744;
						continue;
					}
					continue;
				case 45:
					Form1.HU61GfI0Rv3AMEKtWnE(this.toggleAttackTargetNotInCombat).InnerBorderColor = Color.White;
					num = 412;
					continue;
				case 46:
					this.statusIcon.EndInit();
					num = 340;
					continue;
				case 47:
					Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabSettings).ForeColor = Form1.Y1UIkkw4SWDmFnSC63U(156, 160, 167);
					num = 655;
					continue;
				case 48:
					this.label12.Name = Form1.Bp8crKQbU76Tg68kvQp(~603785892 ^ -603797937);
					num2 = 1167;
					break;
				case 49:
					this.tabPage4.PerformLayout();
					num = 112;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num = 136;
						continue;
					}
					continue;
				case 50:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					Form1.sHSPBYSXYHPhTAgWo8a(dataGridViewCellStyle2, DataGridViewTriState.True);
					num2 = 1069;
					break;
				}
				case 51:
					Form1.AQ5PKbSlGpZgbylJlqA(this.PanelKeyBind, Form1.HWi2GWSiSnTprngPudf());
					num2 = 1144;
					break;
				case 52:
					Form1.pdJJHQZZlfNROfR2yZ0(this, AutoScaleMode.Font);
					num = 174;
					continue;
				case 53:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings).HeaderStyle.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789524194), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 879;
					continue;
				case 54:
					Form1.JBnCqRhMbY6dWf5nXZF(this.label9, new Padding(2, 0, 2, 0));
					num = 354;
					continue;
				case 55:
					Form1.Fb8UmLiRlpCh8WUG8v0(Form1.gBFD6UiIE14syZ5nRUZ(this.txtLicenseExpiry), Form1.Y1UIkkw4SWDmFnSC63U(226, 226, 226));
					num = 852;
					continue;
				case 56:
					this.tabPage5.Location = new Point(4, 34);
					num = 1096;
					continue;
				case 57:
				{
					Guna2NumericUpDown guna2NumericUpDown2 = this.textAddonRefreshRate;
					int[] array2 = new int[4];
					array2[0] = 10;
					guna2NumericUpDown2.Minimum = new decimal(array2);
					num = 826;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 495;
						continue;
					}
					continue;
				}
				case 58:
					Form1.AYECD2IZo1Hm07wV025(this.DataGridSettings, new DataGridViewCellMouseEventHandler(this.tTiEqKcc7I));
					num = 1353;
					continue;
				case 59:
					Form1.wmRhA7IJQPxYMOFAKt5(Form1.HU61GfI0Rv3AMEKtWnE(this.toggleAutoBind), Color.FromArgb(125, 137, 149));
					num = 289;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
					{
						num = 226;
						continue;
					}
					continue;
				case 60:
					Form1.J9JiEZwRU7OOsHQqQGj(this.guna2MessageDialog1, 0);
					num = 449;
					continue;
				case 61:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label11, Form1.Bp8crKQbU76Tg68kvQp(-940667910 + -206218605 ^ -1146890939));
					num = 1088;
					continue;
				case 62:
					Form1.F8DDPrC4dhV11PnsIC6(this.label12, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-87166655 + -2142521002 ^ 2065269419), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 483;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 == 0)
					{
						num = 287;
						continue;
					}
					continue;
				case 63:
					Form1.F8DDPrC4dhV11PnsIC6(this.label8, new Font(Form1.Bp8crKQbU76Tg68kvQp(1621542659 + 1028479281 ^ -1644951544), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 189;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
					{
						num = 582;
						continue;
					}
					continue;
				case 64:
					Form1.F8DDPrC4dhV11PnsIC6(this.listView1, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039283980), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 163;
					continue;
				case 65:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button6, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1048347516 ^ 1048361260));
					num = 1007;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a != 0)
					{
						num = 128;
						continue;
					}
					continue;
				case 66:
					Form1.UItrdLwU1vRfSfQhlDs(this.guna2PictureBox1, (Image)Form1.hAZMV0SINDD87NABFkp(componentResourceManager, Form1.Bp8crKQbU76Tg68kvQp(-1224731037 ^ -1224725071)));
					num = 1089;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb != 0)
					{
						num = 384;
						continue;
					}
					continue;
				case 67:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.label7, new EventHandler(this.tqjEUbdvIM));
					num = 486;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 != 0)
					{
						num = 377;
						continue;
					}
					continue;
				case 68:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					Form1.gFnm6BIteqtbpYI3Km4(dataGridViewCellStyle2, Form1.gDTkfBSgI078eL8rUC0());
					num = 50;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e == 0)
					{
						num = 37;
						continue;
					}
					continue;
				}
				case 69:
					this.guna2GradientPanel3.BorderThickness = 1;
					Form1.OROF9nCl3q4uMeX8ApH(this.guna2GradientPanel3).Add(this.guna2Button9);
					num = 801;
					continue;
				case 70:
					Form1.wn4MVbhaDtLVWnT24Xb(Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabSettings), Form1.pd7LrbAfTlIgHjZelLV());
					num = 1162;
					continue;
				case 71:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2Button5, Color.White);
					this.guna2Button5.Location = new Point(14, 209);
					num = 484;
					continue;
				case 72:
					Form1.STG6BrIaHEj0qxrKnDQ(this.ColName, 6);
					num = 1115;
					continue;
				case 73:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2TabControl1), this.tabRotation);
					num = 1195;
					continue;
				case 74:
					this.btnReGenerateAddon = new Guna2Button();
					num = 856;
					continue;
				case 75:
					Form1.xXBXrNZ41pXZ0s2hpb0(this, Form1.Bp8crKQbU76Tg68kvQp(289037427 >> 1 ^ 144511915));
					num = 609;
					continue;
				case 76:
					this.guna2PictureBox1.Margin = new Padding(2);
					num = 890;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be != 0)
					{
						num = 467;
						continue;
					}
					continue;
				case 77:
					Form1.rNH3WfhJCd14ZcstGLE(this.tabPage1, 2);
					num = 331;
					continue;
				case 78:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabAccount);
					num2 = 346;
					break;
				case 79:
					Form1.JBnCqRhMbY6dWf5nXZF(this.tabPage2, new Padding(2));
					num = 238;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 == 0)
					{
						num = 59;
						continue;
					}
					continue;
				case 80:
					Form1.q97Fy4SR0JyfF4xKLTS(this.textConsole, true);
					num = 653;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
					{
						num = 983;
						continue;
					}
					continue;
				case 81:
					this.label6.Text = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1933679734 ^ -1218001364 ^ -1004048522);
					this.textPreCast.BackColor = Form1.HWi2GWSiSnTprngPudf();
					num = 540;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
					{
						num = 11;
						continue;
					}
					continue;
				case 82:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabAccount).Add(this.txtLicenseType);
					num = 1103;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df == 0)
					{
						num = 1004;
						continue;
					}
					continue;
				case 83:
					Form1.fSKvdPhXB121ntJCND9(this.label5, new Point(189, 10));
					num = 120;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 != 0)
					{
						num = 344;
						continue;
					}
					continue;
				case 84:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabSettings, false);
					num = 1017;
					continue;
				case 85:
					Form1.BYULIGhFpBJPZrMGUKF(this.toggleAutoBind, Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374427054));
					num = 489;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae != 0)
					{
						num = 1072;
						continue;
					}
					continue;
				case 86:
					Form1.QXLTdLiS2A3LwtG90ws(Form1.DUmRGwi33SRyIHDjWmi(this.guna2ComboBox1), Color.FromArgb(94, 148, 255));
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2ComboBox1, new Font(Form1.Bp8crKQbU76Tg68kvQp(-860087180 << 5 ^ -1752979780), 10f));
					num2 = 106;
					break;
				case 87:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					dataGridViewCellStyle3.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1050340572 ^ -1050330344), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1358;
					continue;
				}
				case 88:
					Form1.wMMuMWiaRiJ3MryRMFB(this.txtLicenseType, "");
					num = 1325;
					continue;
				case 89:
					this.btnCancelBind.Name = Form1.Bp8crKQbU76Tg68kvQp(-789419076 ^ -35552607 ^ 756270571);
					num = 247;
					continue;
				case 90:
					Form1.bAfsNnixIiVZajHwRbB(this.textAddonRefreshRate, Form1.VA4WwsiygtFFKaVPeZt());
					num = 1252;
					continue;
				case 91:
					this.DataGridSettings.Size = new Size(719, 378);
					num = 592;
					continue;
				case 92:
					Form1.AQ5PKbSlGpZgbylJlqA(this.textPulseFrequency, Color.Transparent);
					Form1.gGHMpMi50ocPwkUtejc(this.textPulseFrequency, 5);
					num = 12;
					continue;
				case 93:
					Form1.agCnAuI950lG7RyZyp7(Form1.NTYtH4ICbD0jWXFC4ol(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), Color.White);
					num2 = 1063;
					break;
				case 94:
					Form1.OpcykuImY77kfmRtox1(this.toggleAttackTargetNotInCombat, new EventHandler(this.F7ZEGtXl5q));
					num = 1135;
					continue;
				case 95:
					Form1.DIHdSHS7iP1A7KmNMB1(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button8), Color.DarkGray);
					num = 1177;
					continue;
				case 96:
					this.guna2Button3.Size = new Size(127, 36);
					num = 436;
					continue;
				case 97:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.tabPage3, Color.DimGray);
					num = 1110;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
					{
						num = 866;
						continue;
					}
					continue;
				case 98:
					this.textGameFolder.DefaultText = "";
					Form1.TEkSI5i126jFtHpxr4P(this.textGameFolder.DisabledState, Form1.Y1UIkkw4SWDmFnSC63U(208, 208, 208));
					num = 1050;
					continue;
				case 99:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabAccount).Add(this.txtUsername);
					num = 1037;
					continue;
				case 100:
					this.DataGridSpell.ThemeStyle.AlternatingRowsStyle.BackColor = Form1.pd7LrbAfTlIgHjZelLV();
					Form1.POOgCgIxT4AvjYeRVwd(Form1.IxeeAFI56iP6msjRr8x(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), null);
					num2 = 806;
					break;
				case 101:
					Form1.CxP1olSUjKIoBxtX0u6(this.tabPage1, 0);
					num = 220;
					continue;
				case 102:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label10, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-860087180 << 5 ^ -1752976294));
					num = 313;
					continue;
				case 103:
					this.textGameFolder.SelectedText = "";
					num = 886;
					continue;
				case 104:
					this.label14.TabIndex = 33;
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label14, Form1.Bp8crKQbU76Tg68kvQp(-1089588375 ^ -1089594367));
					num = 185;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
					{
						num = 25;
						continue;
					}
					continue;
				case 105:
					Form1.rMNt2hhkQfYxahtLlNM(Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabControl1), Form1.Y1UIkkw4SWDmFnSC63U(188, 188, 188));
					Form1.WF4fHNh7qIIDfcgMAes(this.guna2TabControl1, HorizontalAlignment.Left);
					num = 141;
					continue;
				case 106:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2ComboBox1, Form1.Y1UIkkw4SWDmFnSC63U(68, 88, 112));
					num2 = 1106;
					break;
				case 107:
					Form1.XT9GbTSoNQNEAtQu6FN(this.columnHeader2, 327);
					num2 = 28;
					break;
				case 108:
					Form1.CxP1olSUjKIoBxtX0u6(this.tabLog, 5);
					num = 39;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 == 0)
					{
						num = 43;
						continue;
					}
					continue;
				case 109:
					this.statusIcon.TabIndex = 4;
					num2 = 896;
					break;
				case 110:
					Form1.PMxUPdSrxvVlWwnXnBc(this.guna2Button5, true);
					num = 1208;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
					{
						num = 156;
						continue;
					}
					continue;
				case 111:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button2, 7);
					num = 663;
					continue;
				case 112:
					Form1.VvJdQASJ2W9KramGnMU(this.DataGridSpell, false);
					num = 140;
					continue;
				case 113:
					this.textStatus = new Guna2TextBox();
					num = 531;
					continue;
				case 114:
					Form1.gGHMpMi50ocPwkUtejc(this.textAddonRefreshRate, 5);
					num = 90;
					continue;
				case 115:
					Form1.BYULIGhFpBJPZrMGUKF(this.toggleAttackOutOfCombat, Form1.Bp8crKQbU76Tg68kvQp(-185008287 ^ -185021211));
					num = 276;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d == 0)
					{
						num = 197;
						continue;
					}
					continue;
				case 116:
				{
					DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
					num = 917;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
					{
						num = 131;
						continue;
					}
					continue;
				}
				case 117:
					Form1.BelJUdIfWaaWNT5ivWk(this.ColIcon, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(212924216 ^ 212926226));
					num = 500;
					continue;
				case 118:
					Form1.JBnCqRhMbY6dWf5nXZF(this.label10, new Padding(2, 0, 2, 0));
					num = 854;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
					{
						num = 85;
						continue;
					}
					continue;
				case 119:
					this.webView21.DefaultBackgroundColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 978;
					continue;
				case 120:
					Form1.xlhy3UZSAFrXUcbdLNU(this.sharpClipboard1, true);
					num = 647;
					continue;
				case 121:
					Form1.F8DDPrC4dhV11PnsIC6(this.comboPixelLocation, new Font(Form1.Bp8crKQbU76Tg68kvQp(259176490 ^ 259166230), 10f));
					num = 233;
					continue;
				case 122:
					this.guna2Button3.Name = Form1.Bp8crKQbU76Tg68kvQp(-1690522925 ^ -1690526239);
					num = 96;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 != 0)
					{
						num = 22;
						continue;
					}
					continue;
				case 123:
					this.ColBindBtn.FillWeight = 90.27778f;
					num = 211;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 == 0)
					{
						num = 308;
						continue;
					}
					continue;
				case 124:
					Form1.OT5lfdZ82ChkuedMGB6(this.guna2MessageDialog1, 1);
					num2 = 1161;
					break;
				case 125:
					this.DataGridSpell.Margin = new Padding(0);
					this.DataGridSpell.MultiSelect = false;
					num2 = 1294;
					break;
				case 126:
					this.textAddonName.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-1002815721 ^ -877302260 ^ 261060903), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 859;
					continue;
				case 127:
					Form1.fSKvdPhXB121ntJCND9(this.toggleAutoBind, new Point(4, 9));
					num = 85;
					continue;
				case 128:
					this.guna2Button1.Animated = true;
					num = 275;
					continue;
				case 129:
					this.tabAccount = new TabPage();
					num = 5;
					continue;
				case 130:
					this.comboGameVersion = new Guna2ComboBox();
					this.label17 = new Label();
					num = 1337;
					continue;
				case 131:
					Form1.Kkf2lh9gFFtl0X8OnPB(this.toggleAutoBind, false);
					num2 = 127;
					break;
				case 132:
					this.timer1.Interval = 60000;
					num = 811;
					continue;
				case 133:
					this.DataGridSettings.CellValueChanged += this.K0NEQWtCWT;
					num = 525;
					continue;
				case 134:
					Form1.Jjn59PSdJFuo2LP4v7L(this.columnHeader2, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(996650866 + -609199087 ^ 387457609));
					num = 107;
					continue;
				case 135:
					Form1.BYULIGhFpBJPZrMGUKF(this.btnReGenerateAddon, Form1.Bp8crKQbU76Tg68kvQp(-860087180 << 5 ^ -1752981112));
					num = 1251;
					continue;
				case 136:
					this.menuStrip1.ResumeLayout(false);
					Form1.GtWSMsZTTqoBGllCQwV(this.menuStrip1);
					num = 549;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 != 0)
					{
						num = 356;
						continue;
					}
					continue;
				case 137:
					this.tabPage5.UseVisualStyleBackColor = true;
					num = 202;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
					{
						num = 849;
						continue;
					}
					continue;
				case 138:
					this.btnStartStop.DisabledState.FillColor2 = Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169);
					Form1.kjNI22Z57lKULC4Mx8H(this.btnStartStop).ForeColor = Color.FromArgb(141, 141, 141);
					num = 980;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
					{
						num = 314;
						continue;
					}
					continue;
				case 139:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings).GridColor = Form1.Y1UIkkw4SWDmFnSC63U(231, 229, 255);
					num = 167;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
					{
						num = 1271;
						continue;
					}
					continue;
				case 140:
					Form1.rKgWEMSmKw4ZRqoLtHs(this.DataGridSpell, DataGridViewCellBorderStyle.SingleHorizontal);
					num = 1223;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 == 0)
					{
						num = 1247;
						continue;
					}
					continue;
				case 141:
					this.guna2TabControl1.TabButtonImageOffset = new Point(10, 0);
					Form1.b93ptlhlJQMfCjQWJts(Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabControl1), Color.Empty);
					num2 = 962;
					break;
				case 142:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label4, new Size(174, 20));
					num = 358;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
					{
						num = 556;
						continue;
					}
					continue;
				case 143:
					Form1.sUSlgdhHRw1CXHlv9uV(this.tabSettings, new Size(731, 420));
					num = 536;
					continue;
				case 144:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button9, Form1.Bp8crKQbU76Tg68kvQp(259176490 ^ 259170082));
					num2 = 504;
					break;
				case 145:
					Form1.rNXejGSp5vN1fxhySyd(Form1.Gypb9bSfb8dfe9D7Fgg(this.btnCancelBind), Form1.giuhSiS4f07IhTOwgHy());
					num = 333;
					continue;
				case 146:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabKeybinds, Form1.Bp8crKQbU76Tg68kvQp(-1352111144 ^ -1352120500));
					num = 691;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num = 357;
						continue;
					}
					continue;
				case 147:
					Form1.rAerOJSBbLMmf4J5KMd(this.DataGridSpell.Columns, new DataGridViewColumn[]
					{
						this.ColIcon,
						this.ColType,
						this.ColName,
						this.ColKeybind,
						this.ColBindBtn,
						this.ColDisabled
					});
					num = 1155;
					continue;
				case 148:
					Form1.fSKvdPhXB121ntJCND9(this.guna2Button6, new Point(181, 209));
					num = 1059;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
					{
						num = 362;
						continue;
					}
					continue;
				case 149:
					Form1.rNXejGSp5vN1fxhySyd(this.guna2Button1.DisabledState, Color.DarkGray);
					num = 85;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
					{
						num = 191;
						continue;
					}
					continue;
				case 150:
					this.DataGridSettings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
					num = 758;
					continue;
				case 151:
					Form1.cjbEqXhOkHto9Mpb3TF(base.Controls, this.guna2GradientPanel2);
					num = 888;
					continue;
				case 152:
					this.DataGridSettings.DataError += this.OwCENMvKJ9;
					num = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 == 0)
					{
						num = 1060;
						continue;
					}
					continue;
				case 153:
					Form1.tRMKuWiiLgmaY6xGY7v(Form1.gBFD6UiIE14syZ5nRUZ(this.txtLicenseType), Form1.Y1UIkkw4SWDmFnSC63U(138, 138, 138));
					num = 164;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e == 0)
					{
						num = 454;
						continue;
					}
					continue;
				case 154:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2).Add(this.comboKeyboard);
					num2 = 19;
					break;
				case 155:
					this.label3 = new Label();
					num = 1160;
					continue;
				case 156:
					Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAutoTab).InnerBorderColor = Form1.pd7LrbAfTlIgHjZelLV();
					this.toggleAutoTab.CheckedState.InnerColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 795;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
					{
						num = 264;
						continue;
					}
					continue;
				case 157:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2GradientPanel2, 8);
					num = 187;
					continue;
				case 158:
					this.label7 = new Label();
					num = 1031;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a == 0)
					{
						num = 706;
						continue;
					}
					continue;
				case 159:
					Form1.twywWuI6kMlWTtwfxxc(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAutoBind), Color.FromArgb(94, 148, 255));
					num = 870;
					continue;
				case 160:
					this.tabAccount.Size = new Size(731, 420);
					num = 702;
					continue;
				case 161:
					this.label12 = new Label();
					this.toggleAttackOutOfCombat = new Guna2ToggleSwitch();
					num = 566;
					continue;
				case 162:
					Form1.Lg0ScKIpjNLeXbDQTVP(this.ColKeybind, DataGridViewAutoSizeColumnMode.Fill);
					this.ColKeybind.FillWeight = 70f;
					num = 1273;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 != 0)
					{
						num = 51;
						continue;
					}
					continue;
				case 163:
					Form1.qeI8EWScfNcUJNVdERV(this.listView1, true);
					num = 857;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
					{
						num = 348;
						continue;
					}
					continue;
				case 164:
					Form1.JBnCqRhMbY6dWf5nXZF(this.labelKeyPreview, new Padding(3, 0, 3, 58));
					num = 1229;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 1021;
						continue;
					}
					continue;
				case 165:
					Form1.otmlDCIMLcd9h5DidGC(this.DataGridSettings, false);
					num = 629;
					continue;
				case 166:
					this.tabPage4.Text = Form1.Bp8crKQbU76Tg68kvQp(-1815843576 ^ -1815853964);
					num = 25;
					continue;
				case 167:
					this.DataGridSpell.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					num = 366;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a == 0)
					{
						num = 880;
						continue;
					}
					continue;
				case 168:
					Form1.GtfMAhi4Efiicblyei4(this.txtUsername, "");
					num = 368;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 == 0)
					{
						num = 561;
						continue;
					}
					continue;
				case 169:
					Form1.BelJUdIfWaaWNT5ivWk(this.ColSettingsValue, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-443850682 << 3 ^ 744174304));
					num = 999;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
					{
						num = 138;
						continue;
					}
					continue;
				case 170:
					Form1.BYULIGhFpBJPZrMGUKF(this.btnStartStop, Form1.Bp8crKQbU76Tg68kvQp(-256932895 ^ -256917663));
					num2 = 735;
					break;
				case 171:
					Form1.IdQ3l0iTV65Ufl1oFyW(this.txtLicenseType, 5);
					num = 1345;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
					{
						num = 410;
						continue;
					}
					continue;
				case 172:
					this.guna2TabSettings = new Guna2TabControl();
					num = 214;
					continue;
				case 173:
					Form1.ct6f95iVW7aY43cQu7Z(this.textPreCast, Form1.FKa6C7hD8TGBG7hXjxm());
					num = 89;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f != 0)
					{
						num = 210;
						continue;
					}
					continue;
				case 174:
					base.ClientSize = new Size(919, 554);
					num = 547;
					continue;
				case 175:
					Form1.rNH3WfhJCd14ZcstGLE(this.tabAccount, 4);
					num = 1038;
					continue;
				case 176:
					Form1.AQ5PKbSlGpZgbylJlqA(this.labelKeyPreview, Color.Transparent);
					Form1.F8DDPrC4dhV11PnsIC6(this.labelKeyPreview, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(289037427 >> 1 ^ 144508421), 18f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num2 = 992;
					break;
				case 177:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabKeybinds).Add(this.PanelKeyBind);
					num = 1140;
					continue;
				case 178:
					this.txtLicenseExpiry.Location = new Point(14, 163);
					num2 = 760;
					break;
				case 179:
					Form1.bnrr8uiplYjGFY5NtLt(this.txtUsername, '\0');
					num = 86;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
					{
						num = 168;
						continue;
					}
					continue;
				case 180:
					this.toolStripSeparator1.Size = new Size(167, 6);
					num = 1298;
					continue;
				case 181:
				{
					DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
					num = 1117;
					continue;
				}
				case 182:
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					Form1.Rer5dAStiGn1xeOjxdw(dataGridViewCellStyle, DataGridViewContentAlignment.MiddleLeft);
					num = 353;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd == 0)
					{
						num = 308;
						continue;
					}
					continue;
				}
				case 183:
					this.webView21.BeginInit();
					num = 1188;
					continue;
				case 184:
					this.guna2TabControl2.TabButtonSelectedState.ForeColor = Form1.FKa6C7hD8TGBG7hXjxm();
					num2 = 1027;
					break;
				case 185:
					Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAutoBind).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255);
					num = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e != 0)
					{
						num = 159;
						continue;
					}
					continue;
				case 186:
					Form1.QEHe5jIW3kjEoOObLPC(this.DataGridSettings, false);
					num = 300;
					continue;
				case 187:
					this.statusIcon.BackColor = Form1.HWi2GWSiSnTprngPudf();
					num = 197;
					continue;
				case 188:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabPage3);
					num = 174;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 != 0)
					{
						num = 183;
						continue;
					}
					continue;
				case 189:
					Form1.KpJINqSqH6xqYtcPTR3(this.DataGridSpell, new KeyEventHandler(this.MdCEHVZI5R));
					num = 1302;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num = 1284;
						continue;
					}
					continue;
				case 190:
					this.guna2Button9.Name = Form1.Bp8crKQbU76Tg68kvQp(~1053049764 ^ -1053060425);
					num2 = 1339;
					break;
				case 191:
					this.guna2Button1.DisabledState.CustomBorderColor = Form1.giuhSiS4f07IhTOwgHy();
					Form1.wr5o3ESO7nyo3wXgm1J(this.guna2Button1.DisabledState, Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169));
					num = 1174;
					continue;
				case 192:
					this.textPulseFrequency.BeginInit();
					num = 1264;
					continue;
				case 193:
					Form1.PMxUPdSrxvVlWwnXnBc(this.guna2Button4, true);
					num = 212;
					continue;
				case 194:
					Form1.BYULIGhFpBJPZrMGUKF(this.listView1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(145144672 << 4 ^ -1972658274));
					num = 984;
					continue;
				case 195:
					this.guna2ControlBox1.Size = new Size(26, 28);
					num = 62;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
					{
						num = 261;
						continue;
					}
					continue;
				case 196:
					this.guna2GradientPanel3.Controls.Add(this.label14);
					num = 1347;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num = 419;
						continue;
					}
					continue;
				case 197:
					Form1.r72bbiiGeTaV9ecgvYb(this.statusIcon, Color.Transparent);
					num = 309;
					continue;
				case 198:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5).Add(this.label6);
					num = 834;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
					{
						num = 547;
						continue;
					}
					continue;
				case 199:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabPage3, false);
					num = 15;
					continue;
				case 200:
					Form1.jYIvwlSFeUP8EP4RD48(this.guna2Button7.DisabledState, Color.FromArgb(141, 141, 141));
					num = 1189;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 != 0)
					{
						num = 431;
						continue;
					}
					continue;
				case 201:
					this.guna2GradientPanel3.BorderColor = Form1.G9eLqeSP2XWNAQfY8h5();
					num = 69;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num = 21;
						continue;
					}
					continue;
				case 202:
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					Form1.cCHgJfSYhohxmE8w4BT(dataGridViewCellStyle, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 21;
					continue;
				}
				case 203:
					this.label2.Text = Form1.Bp8crKQbU76Tg68kvQp(-1002815721 ^ -877302260 ^ 261056993);
					Form1.Pj5rjPhYZsKmoJgcMvx(this.label2, new EventHandler(this.aUZEhKW1OD));
					num = 41;
					continue;
				case 204:
					this.label9.AutoSize = true;
					num = 1181;
					continue;
				case 205:
					Form1.UKbNgvhKj1KrPfkYk1l(this.guna2TabControl1.TabButtonSelectedState, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1366152946 ^ -1366163078), 10f));
					Form1.nga6WgheeytD1C2eoXZ(this.guna2TabControl1.TabButtonSelectedState, Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 336;
					break;
				case 206:
					Form1.STG6BrIaHEj0qxrKnDQ(this.ColSettingsValue, 6);
					num2 = 169;
					break;
				case 207:
					this.sharpClipboard1 = new SharpClipboard(this.components);
					num = 1243;
					continue;
				case 208:
					this.comboKeyboard.Location = new Point(11, 281);
					Form1.BYULIGhFpBJPZrMGUKF(this.comboKeyboard, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-253515656 ^ -1789645123 ^ 1706537291));
					num2 = 270;
					break;
				case 209:
					Form1.jyjAD8InwfkZ05g28Ir(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAutoBind), Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 131;
					break;
				case 210:
					Form1.fSKvdPhXB121ntJCND9(this.textPreCast, new Point(369, 30));
					num = 310;
					continue;
				case 211:
					Form1.kwtQAaZcMY6Hv2kogtG(this.btnStartStop, true);
					num = 659;
					continue;
				case 212:
					Form1.I5salaIrpg8plUCDDAh(this.guna2Button4, 5);
					Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button4).BorderColor = Form1.giuhSiS4f07IhTOwgHy();
					Form1.DIHdSHS7iP1A7KmNMB1(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button4), Color.DarkGray);
					num = 944;
					continue;
				case 213:
					Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabControl2).Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387927140), 9f);
					num = 100;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 != 0)
					{
						num = 184;
						continue;
					}
					continue;
				case 214:
					this.tabPage1 = new TabPage();
					num = 1083;
					continue;
				case 215:
					this.guna2Button8.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-1897624240 ^ -1897618068), 9f);
					num = 750;
					continue;
				case 216:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabAccount), this.guna2Button6);
					num = 239;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 != 0)
					{
						num = 148;
						continue;
					}
					continue;
				case 217:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2).Add(this.comboPixelLocation);
					num = 570;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 == 0)
					{
						num = 841;
						continue;
					}
					continue;
				case 218:
					Form1.fSKvdPhXB121ntJCND9(this.webView21, new Point(2, 2));
					num = 916;
					continue;
				case 219:
					Form1.t0odiWIO3jYbIe5tBDa(this.ColIcon, DataGridViewImageCellLayout.Stretch);
					num = 1113;
					continue;
				case 220:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabPage1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-902888658 ^ -902876312));
					num = 568;
					continue;
				case 221:
					this.toolStripMenuItemClearBind.Size = new Size(170, 24);
					num = 365;
					continue;
				case 222:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.label6, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 227;
					continue;
				case 223:
					this.DataGridSpell.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
					num = 1071;
					continue;
				case 224:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabPage5, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1621542659 + 1028479281 ^ -1644949188));
					num = 137;
					continue;
				case 225:
					this.btnCancelBind = new Guna2Button();
					this.labelKeyPreview = new Label();
					num = 1310;
					continue;
				case 226:
					this.ColType.Name = Form1.Bp8crKQbU76Tg68kvQp(-2102188928 ^ -2102186820);
					num = 594;
					continue;
				case 227:
					this.label6.Location = new Point(365, 10);
					Form1.JBnCqRhMbY6dWf5nXZF(this.label6, new Padding(2, 0, 2, 0));
					Form1.BYULIGhFpBJPZrMGUKF(this.label6, Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510585505));
					num = 401;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 != 0)
					{
						num = 1157;
						continue;
					}
					continue;
				case 228:
					this.guna2Button5 = new Guna2Button();
					num = 297;
					continue;
				case 229:
					Form1.QKARLdioNwUFu7gp91N(this.comboPixelLocation, Color.FromArgb(94, 148, 255));
					Form1.DUmRGwi33SRyIHDjWmi(this.comboPixelLocation).BorderColor = Color.FromArgb(94, 148, 255);
					num = 121;
					continue;
				case 230:
					this.comboKeyboard.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-253515656 ^ -1789645123 ^ 1706536697), 10f);
					num = 767;
					continue;
				case 231:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2TabControl2, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2040894867 + -686633457 ^ 1354255190));
					num2 = 472;
					break;
				case 232:
					this.DataGridSpell.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
					num2 = 147;
					break;
				case 233:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.comboPixelLocation, Form1.Y1UIkkw4SWDmFnSC63U(68, 88, 112));
					num = 8;
					continue;
				case 234:
					this.guna2Button1.Margin = new Padding(2);
					num = 1250;
					continue;
				case 235:
					this.guna2ControlBox1.Margin = new Padding(2);
					num = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c7104ccd40024e009409c6d14eb5a99a == 0)
					{
						num = 1331;
						continue;
					}
					continue;
				case 236:
					Form1.rNH3WfhJCd14ZcstGLE(this.tabPage4, 1);
					num = 1148;
					continue;
				case 237:
					Form1.tJ9boRIAZlHYfAtIVO0(Form1.NTYtH4ICbD0jWXFC4ol(this.DataGridSpell.ThemeStyle), 40);
					num = 267;
					continue;
				case 238:
					Form1.BYULIGhFpBJPZrMGUKF(this.tabPage2, Form1.Bp8crKQbU76Tg68kvQp(1633072087 ^ 1633060323));
					num = 1150;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
					{
						num = 557;
						continue;
					}
					continue;
				case 239:
					this.tabAccount.Controls.Add(this.guna2Button5);
					num = 837;
					continue;
				case 240:
					this.label10.Location = new Point(10, 142);
					num2 = 118;
					break;
				case 241:
					Form1.QKARLdioNwUFu7gp91N(this.guna2ComboBox1, Color.FromArgb(94, 148, 255));
					num = 86;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b != 0)
					{
						num = 33;
						continue;
					}
					continue;
				case 242:
					this.guna2TabControl2.TabButtonIdleState.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-1668754258 ^ -1668744046), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					Form1.nga6WgheeytD1C2eoXZ(this.guna2TabControl2.TabButtonIdleState, Color.FromArgb(156, 160, 167));
					num = 1038;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 != 0)
					{
						num = 1121;
						continue;
					}
					continue;
				case 243:
					this.label14.Location = new Point(47, 11);
					Form1.BYULIGhFpBJPZrMGUKF(this.label14, Form1.Bp8crKQbU76Tg68kvQp(451337338 ^ 451343148));
					this.label14.Size = new Size(270, 19);
					num = 104;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
					{
						num = 55;
						continue;
					}
					continue;
				case 244:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button3, Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463901347));
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button3, new EventHandler(this.lUnEAuUX3G));
					num = 474;
					continue;
				case 245:
					this.guna2TabSettings.ItemSize = new Size(176, 30);
					num = 1191;
					continue;
				case 246:
					Form1.c0T4oUhzseliJt6JbSj(this.label15, 22);
					num = 703;
					continue;
				case 247:
					this.btnCancelBind.Size = new Size(99, 38);
					num2 = 676;
					break;
				case 248:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabLog), this.guna2Button1);
					num = 197;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
					{
						num = 503;
						continue;
					}
					continue;
				case 249:
					this.menuStrip1.Size = new Size(719, 28);
					num2 = 636;
					break;
				case 250:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button1, new EventHandler(this.q0bPVKEo5e));
					num = 869;
					continue;
				case 251:
					Form1.H2Y868imN0R3hi3RCni(this.guna2ControlBox1.ShadowDecoration, new Padding(1));
					num = 94;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba == 0)
					{
						num = 195;
						continue;
					}
					continue;
				case 252:
					Form1.sUSlgdhHRw1CXHlv9uV(this.toggleAutoTab, new Size(41, 23));
					num = 1202;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
					{
						num = 1201;
						continue;
					}
					continue;
				case 253:
					Form1.SchZQeiNyn2h4aGZyAH(this.guna2ControlBox1, 5);
					num = 228;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
					{
						num = 772;
						continue;
					}
					continue;
				case 254:
					Form1.m07tEyiqJ14uAJStg1D(this.comboGameVersion, 5);
					num = 271;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
					{
						num = 54;
						continue;
					}
					continue;
				case 255:
				{
					DataGridViewCellStyle dataGridViewCellStyle5;
					this.DataGridSpell.DefaultCellStyle = dataGridViewCellStyle5;
					num = 972;
					continue;
				}
				case 256:
					Form1.sTh4N1hfYNMMTCB8Ac1(this.guna2TabControl1, true);
					num = 534;
					continue;
				case 257:
					Form1.fSKvdPhXB121ntJCND9(this.comboPixelLocation, new Point(11, 149));
					num = 1304;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 == 0)
					{
						num = 1063;
						continue;
					}
					continue;
				case 258:
					Form1.BYULIGhFpBJPZrMGUKF(this.tabPage4, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-384868386 + 510636180 ^ 125778202));
					num = 924;
					continue;
				case 259:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.btnReGenerateAddon, Form1.Bp8crKQbU76Tg68kvQp(-283366293 ^ -283376805));
					num = 1073;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
					{
						num = 1315;
						continue;
					}
					continue;
				case 260:
					this.textConsole = new TextBox();
					num = 1226;
					continue;
				case 261:
					this.guna2ControlBox1.TabIndex = 4;
					num = 417;
					continue;
				case 262:
					Form1.j3fKIdidqWrQeM9mduN(this.comboPixelLocation, DrawMode.OwnerDrawFixed);
					num = 14;
					continue;
				case 263:
					Form1.BYULIGhFpBJPZrMGUKF(this.txtUsername, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1016420359 ^ 1016423233));
					num = 625;
					continue;
				case 264:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2).Add(this.guna2Button4);
					num = 310;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num = 675;
						continue;
					}
					continue;
				case 265:
					Form1.OpcykuImY77kfmRtox1(this.toggleAutoBind, new EventHandler(this.fpgEsMDB25));
					num = 638;
					continue;
				case 266:
				{
					DataGridViewCellStyle dataGridViewCellStyle5;
					dataGridViewCellStyle5.SelectionForeColor = Form1.Y1UIkkw4SWDmFnSC63U(71, 69, 94);
					num2 = 1305;
					break;
				}
				case 267:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell).RowsStyle.SelectionBackColor = Form1.Y1UIkkw4SWDmFnSC63U(231, 229, 255);
					num = 759;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 != 0)
					{
						num = 897;
						continue;
					}
					continue;
				case 268:
					Form1.tJ9boRIAZlHYfAtIVO0(Form1.NTYtH4ICbD0jWXFC4ol(this.DataGridSettings.ThemeStyle), 33);
					num = 611;
					continue;
				case 269:
					this.DataGridSpell.RowHeadersWidth = 51;
					Form1.B1wnEuSzNHT41iFvSNM(Form1.OH0ytaSbKMHlvY1b5HH(this.DataGridSpell), this.contextMenuShowMacro);
					this.DataGridSpell.RowTemplate.Height = 40;
					num = 722;
					continue;
				case 270:
					Form1.sUSlgdhHRw1CXHlv9uV(this.comboKeyboard, new Size(509, 36));
					num2 = 919;
					break;
				case 271:
					Form1.j3fKIdidqWrQeM9mduN(this.comboGameVersion, DrawMode.OwnerDrawFixed);
					num = 167;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
					{
						num = 402;
						continue;
					}
					continue;
				case 272:
					Form1.UKbNgvhKj1KrPfkYk1l(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabSettings), new Font(Form1.Bp8crKQbU76Tg68kvQp(-613886095 << 1 ^ -1227782434), 9f));
					num2 = 1301;
					break;
				case 273:
					Form1.TEkSI5i126jFtHpxr4P(Form1.hgQ7OUiLBG9h0tLB2Ug(this.txtUsername), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					num = 846;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b != 0)
					{
						num = 1356;
						continue;
					}
					continue;
				case 274:
					Form1.kAoHyLiOcqbsYb6GYdV(this.txtLicenseType, "");
					num = 1049;
					continue;
				case 275:
					this.guna2Button1.BorderRadius = 10;
					num = 149;
					continue;
				case 276:
					this.toggleAttackOutOfCombat.Size = new Size(41, 23);
					num = 243;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 == 0)
					{
						num = 671;
						continue;
					}
					continue;
				case 277:
				{
					DataGridViewCellStyle dataGridViewCellStyle4;
					this.DataGridSettings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
					num = 1330;
					continue;
				}
				case 278:
					this.tabPage4.TabIndex = 1;
					num = 166;
					continue;
				case 279:
					this.toolTip1.AutoPopDelay = 10000;
					num = 882;
					continue;
				case 280:
					Form1.BYULIGhFpBJPZrMGUKF(this.DataGridSettings, Form1.Bp8crKQbU76Tg68kvQp(-384868386 + 510636180 ^ 125771800));
					num = 165;
					continue;
				case 281:
					Form1.I5salaIrpg8plUCDDAh(this.guna2Button8, 5);
					this.guna2Button8.DisabledState.BorderColor = Color.DarkGray;
					num = 95;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
					{
						num = 40;
						continue;
					}
					continue;
				case 282:
					Form1.GtfMAhi4Efiicblyei4(this.txtLicenseType, "");
					Form1.TQ7387iKhdplLvSeKQ7(this.txtLicenseType, true);
					num = 274;
					continue;
				case 283:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label3, Form1.Bp8crKQbU76Tg68kvQp(-838478377 ^ -838472347));
					this.label3.Click += this.lcdESXG0qv;
					num = 1344;
					continue;
				case 284:
					this.toolStripSeparator1.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1157945476 >> 1 ^ 578961920);
					num2 = 180;
					break;
				case 285:
					Form1.Jlq43diUhDdv5DIhVjg(this.textGameFolder).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255);
					num = 1011;
					continue;
				case 286:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label5, new Size(147, 20));
					num = 1361;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
					{
						num = 1198;
						continue;
					}
					continue;
				case 287:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button2, new EventHandler(this.Ou9P3PUgcH));
					num = 910;
					continue;
				case 288:
					Form1.AQ5PKbSlGpZgbylJlqA(this.txtUsername, Form1.HWi2GWSiSnTprngPudf());
					num = 805;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 != 0)
					{
						num = 109;
						continue;
					}
					continue;
				case 289:
					Form1.twywWuI6kMlWTtwfxxc(Form1.HU61GfI0Rv3AMEKtWnE(this.toggleAutoBind), Form1.Y1UIkkw4SWDmFnSC63U(125, 137, 149));
					num2 = 769;
					break;
				case 290:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2GradientPanel2), this.textStatus);
					num = 550;
					continue;
				case 291:
					this.txtLicenseExpiry.FillColor = Color.FromArgb(240, 240, 240);
					num = 1020;
					continue;
				case 292:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5), this.toggleAttackTargetNotInCombat);
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5).Add(this.label13);
					num = 1349;
					continue;
				case 293:
					Form1.wn4MVbhaDtLVWnT24Xb(this.guna2TabControl2.TabButtonHoverState, Color.White);
					num = 815;
					continue;
				case 294:
					Form1.kj4P6wZd7UCdDhdtFYa(this.imageList2, (ImageListStreamer)Form1.hAZMV0SINDD87NABFkp(componentResourceManager, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-860087180 << 5 ^ -1752976868)));
					num = 501;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
					{
						num = 858;
						continue;
					}
					continue;
				case 295:
					Form1.gWt4yZibQt8uoyok1N0(this.textStatus, CharacterCasing.Upper);
					num = 335;
					continue;
				case 296:
					Form1.GaMaotCqWxchpV0yRLI(this.imageList3).SetKeyName(3, Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387928000));
					this.imageList3.Images.SetKeyName(4, Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764421823));
					num = 1116;
					continue;
				case 297:
					this.txtLicenseExpiry = new Guna2TextBox();
					num = 807;
					continue;
				case 298:
					Form1.Kk0xPCSG2g31xCMwluA(this.DataGridSettings, 30);
					num = 513;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 != 0)
					{
						num = 614;
						continue;
					}
					continue;
				case 299:
					this.btnStartStop.TabIndex = 1;
					num2 = 1268;
					break;
				case 300:
					Form1.no90GHIE0Dao6auK2XZ(this.DataGridSettings, false);
					num = 91;
					continue;
				case 301:
					this.toolTip1.AutomaticDelay = 100;
					num = 126;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 == 0)
					{
						num = 279;
						continue;
					}
					continue;
				case 302:
					this.ColDisabled.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					num = 1109;
					continue;
				case 303:
					Form1.AwaROtiFKjpY0D2Lhkk(this.textAddonName, new EventHandler(this.Ek3P4S9JfW));
					num = 786;
					continue;
				case 304:
					Form1.ts5qOphSdFeFDL1nGkF(this.textPreCast);
					num = 192;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
					{
						num = 131;
						continue;
					}
					continue;
				case 305:
					Form1.TEkSI5i126jFtHpxr4P(Form1.gBFD6UiIE14syZ5nRUZ(this.textStatus), Form1.Y1UIkkw4SWDmFnSC63U(208, 208, 208));
					num = 863;
					continue;
				case 306:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.comboGameVersion, Color.FromArgb(68, 88, 112));
					this.comboGameVersion.ItemHeight = 30;
					num = 530;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 == 0)
					{
						num = 572;
						continue;
					}
					continue;
				case 307:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label15, new Size(101, 20));
					num = 190;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a == 0)
					{
						num = 246;
						continue;
					}
					continue;
				case 308:
					this.ColBindBtn.HeaderText = "";
					num = 165;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 != 0)
					{
						num = 348;
						continue;
					}
					continue;
				case 309:
					Form1.UItrdLwU1vRfSfQhlDs(this.statusIcon, Resources.sleeping);
					num = 374;
					continue;
				case 310:
				{
					Guna2NumericUpDown guna2NumericUpDown3 = this.textPreCast;
					int[] array3 = new int[4];
					array3[0] = 1000;
					guna2NumericUpDown3.Maximum = new decimal(array3);
					num = 246;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 == 0)
					{
						num = 386;
						continue;
					}
					continue;
				}
				case 311:
					this.imageList3.TransparentColor = Form1.HWi2GWSiSnTprngPudf();
					num = 508;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 != 0)
					{
						num = 861;
						continue;
					}
					continue;
				case 312:
					this.txtLicenseExpiry.Name = Form1.Bp8crKQbU76Tg68kvQp(-1872685799 ^ -1872678979);
					num2 = 1311;
					break;
				case 313:
					Form1.AQ5PKbSlGpZgbylJlqA(this.txtLicenseType, Form1.HWi2GWSiSnTprngPudf());
					num = 171;
					continue;
				case 314:
					Form1.fSKvdPhXB121ntJCND9(this.toggleManualCastQueue, new Point(12, 84));
					num = 705;
					continue;
				case 315:
					Form1.MyWd6GZRsTANcsJlHcx(this.DataGridSpell);
					num = 998;
					continue;
				case 316:
					Form1.OH0ytaSbKMHlvY1b5HH(this.DataGridSettings).Height = 33;
					num = 927;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 == 0)
					{
						num = 147;
						continue;
					}
					continue;
				case 317:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label1, new Size(171, 20));
					this.label1.TabIndex = 5;
					num2 = 667;
					break;
				case 318:
					Form1.JBnCqRhMbY6dWf5nXZF(this.label17, new Padding(2, 0, 2, 0));
					num = 460;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 != 0)
					{
						num = 282;
						continue;
					}
					continue;
				case 319:
					this.label11.ForeColor = Color.DimGray;
					this.label11.Location = new Point(59, 85);
					num2 = 1223;
					break;
				case 320:
					this.webView21.Click += this.jSiErYjHGN;
					num = 809;
					continue;
				case 321:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2GradientPanel1, 7);
					num = 1281;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
					{
						num = 980;
						continue;
					}
					continue;
				case 322:
					Form1.HhDmpfIIC3sgidl7lWO(this.DataGridSpell, new DataGridViewCellEventHandler(this.kc4EykwsKR));
					Form1.HOhFwLIij7nr09HKWqJ(this.DataGridSpell, new DataGridViewCellEventHandler(this.ONNEOhLkog));
					num = 1348;
					continue;
				case 323:
					this.menuStrip1.GripMargin = new Padding(0);
					num = 121;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
					{
						num = 519;
						continue;
					}
					continue;
				case 324:
					Form1.JBnCqRhMbY6dWf5nXZF(this.label3, new Padding(2, 0, 2, 0));
					num = 855;
					continue;
				case 325:
					Form1.I5salaIrpg8plUCDDAh(this.guna2Button2, 5);
					num = 894;
					continue;
				case 326:
					Form1.xuq2OwSyC9MGZIJyWQi(this.listView1, new EventHandler(this.JkdPSyxNld));
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
					{
						num = 24;
						continue;
					}
					continue;
				case 327:
					Form1.lG5b8lZhnSxB4pV8GJt(this.sharpClipboard1.ObservableFormats, true);
					num = 120;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
					{
						num = 81;
						continue;
					}
					continue;
				case 328:
					Form1.yKlIRZhgGPwQdBNUf1A(this.guna2TabControl2, new Size(176, 30));
					num = 1341;
					continue;
				case 329:
					Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button9).BorderColor = Form1.giuhSiS4f07IhTOwgHy();
					num = 399;
					continue;
				case 330:
					this.tabLog = new TabPage();
					num = 835;
					continue;
				case 331:
					this.tabPage1.Location = new Point(4, 34);
					num = 1086;
					continue;
				case 332:
					this.textGameFolder.Margin = new Padding(2);
					num = 982;
					continue;
				case 333:
					Form1.DIHdSHS7iP1A7KmNMB1(this.btnCancelBind.DisabledState, Color.DarkGray);
					num = 632;
					continue;
				case 334:
					Form1.S5UODsIbUiIGX8BHlL0(this.DataGridSettings.ThemeStyle.RowsStyle, DataGridViewCellBorderStyle.SingleHorizontal);
					num = 630;
					continue;
				case 335:
					Form1.bAfsNnixIiVZajHwRbB(this.textStatus, Form1.glHvxQizGEmlSdVxtOt());
					Form1.wMMuMWiaRiJ3MryRMFB(this.textStatus, Form1.Bp8crKQbU76Tg68kvQp(1819523060 ^ 1064311800 ^ 1392753956));
					num = 299;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
					{
						num = 305;
						continue;
					}
					continue;
				case 336:
					Form1.rMNt2hhkQfYxahtLlNM(this.guna2TabControl1.TabButtonSelectedState, Form1.Y1UIkkw4SWDmFnSC63U(0, 96, 127));
					num = 1097;
					continue;
				case 337:
					Form1.DUmRGwi33SRyIHDjWmi(this.comboKeyboard).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255);
					num = 230;
					continue;
				case 338:
				{
					object obj = this.textPulseFrequency;
					int[] array4 = new int[4];
					array4[0] = 10;
					Form1.oWydCqi8UgPIsjPhBA9(obj, new decimal(array4));
					Form1.BYULIGhFpBJPZrMGUKF(this.textPulseFrequency, Form1.Bp8crKQbU76Tg68kvQp(1819523060 ^ 1064311800 ^ 1392744850));
					num = 1058;
					continue;
				}
				case 339:
					this.toggleAutoBind = new Guna2ToggleSwitch();
					num = 878;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 != 0)
					{
						num = 1010;
						continue;
					}
					continue;
				case 340:
					base.ResumeLayout(false);
					num = 939;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 == 0)
					{
						num = 295;
						continue;
					}
					continue;
				case 341:
					Form1.FMmXXUSCJBZ0ICUrYk0(this.removeScriptToolStripMenuItem, new Size(97, 24));
					num = 1263;
					continue;
				case 342:
					Form1.P5eeUsS9qDJS8JGNAGm(this.editToolStripMenuItem, Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679318110));
					num = 785;
					continue;
				case 343:
					this.loadSelectedToolStripMenuItem.Name = Form1.Bp8crKQbU76Tg68kvQp(1633072087 ^ 1633065529);
					num2 = 674;
					break;
				case 344:
					Form1.JBnCqRhMbY6dWf5nXZF(this.label5, new Padding(2, 0, 2, 0));
					num = 954;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num = 609;
						continue;
					}
					continue;
				case 345:
					Form1.jyjAD8InwfkZ05g28Ir(Form1.HU61GfI0Rv3AMEKtWnE(this.toggleManualCastQueue), Color.White);
					num = 640;
					continue;
				case 346:
					Form1.NI0nbahhQrIJ1PGSqQI(this.guna2GradientPanel1);
					num = 445;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
					{
						num = 839;
						continue;
					}
					continue;
				case 347:
					this.textAddonName.Margin = new Padding(2);
					this.textAddonName.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-506871478 - 1486829658 ^ -1993691076);
					num = 793;
					continue;
				case 348:
					Form1.STG6BrIaHEj0qxrKnDQ(this.ColBindBtn, 80);
					num = 973;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 != 0)
					{
						num = 1105;
						continue;
					}
					continue;
				case 349:
					Form1.Ejey22SwIyfvnrggGSM(this.addScriptToolStripMenuItem, new EventHandler(this.VTVPhEoam5));
					num = 115;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa == 0)
					{
						num = 1260;
						continue;
					}
					continue;
				case 350:
					Form1.jyjAD8InwfkZ05g28Ir(Form1.HU61GfI0Rv3AMEKtWnE(this.toggleAutoTab), Form1.pd7LrbAfTlIgHjZelLV());
					num = 617;
					continue;
				case 351:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5).Add(this.label16);
					num = 292;
					continue;
				case 352:
					this.label15.Margin = new Padding(2, 0, 2, 0);
					num = 1165;
					continue;
				case 353:
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					Form1.IWMBi6AOVaRiLvC0OqM(dataGridViewCellStyle, Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 761;
					break;
				}
				case 354:
					Form1.BYULIGhFpBJPZrMGUKF(this.label9, Form1.Bp8crKQbU76Tg68kvQp(-886904286 ^ -886910664));
					num = 684;
					continue;
				case 355:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button1, Form1.Bp8crKQbU76Tg68kvQp(-309791748 - 2077333185 ^ 1907847547));
					num = 1230;
					continue;
				case 356:
					Form1.kLAGfDZ1w3Csel834qc(this, FormBorderStyle.None);
					num = 1297;
					continue;
				case 357:
					Form1.wxMaZnI7u1L89VdGNLA(this.label17, true);
					num = 387;
					continue;
				case 358:
					Form1.TEkSI5i126jFtHpxr4P(Form1.hgQ7OUiLBG9h0tLB2Ug(this.txtLicenseExpiry), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					num = 178;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
					{
						num = 60;
						continue;
					}
					continue;
				case 359:
					Form1.c0T4oUhzseliJt6JbSj(this.comboKeyboard, 19);
					num = 708;
					continue;
				case 360:
				{
					Guna2NumericUpDown guna2NumericUpDown4 = this.textPulseFrequency;
					int[] array5 = new int[4];
					array5[0] = 1000;
					guna2NumericUpDown4.Maximum = new decimal(array5);
					num = 338;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 == 0)
					{
						num = 295;
						continue;
					}
					continue;
				}
				case 361:
					Form1.FPnOSWI8T7fyCLYT9Mg(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell), Form1.Y1UIkkw4SWDmFnSC63U(231, 229, 255));
					num = 598;
					continue;
				case 362:
					Form1.F8DDPrC4dhV11PnsIC6(this.label6, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1654110737 ^ -473083753 ^ -2124758342), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 222;
					continue;
				case 363:
					this.guna2GradientPanel2.BorderThickness = 1;
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2GradientPanel2), this.statusIcon);
					num = 290;
					continue;
				case 364:
					Form1.BExsmoIBUlEI92ahy6J(Form1.OH0ytaSbKMHlvY1b5HH(this.DataGridSettings), 1);
					num = 316;
					continue;
				case 365:
					Form1.P5eeUsS9qDJS8JGNAGm(this.toolStripMenuItemClearBind, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789522682));
					num = 558;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num = 362;
						continue;
					}
					continue;
				case 366:
					this.label8 = new Label();
					num = 692;
					continue;
				case 367:
					this.tabKeybinds.TabIndex = 1;
					num = 146;
					continue;
				case 368:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label11, new Size(211, 23));
					num = 1222;
					continue;
				case 369:
					this.guna2TabControl2.TabMenuBackColor = Color.White;
					num = 39;
					continue;
				case 370:
					Form1.BYULIGhFpBJPZrMGUKF(this.menuStrip1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1860104403 ^ -1860098309));
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 == 0)
					{
						num = 4;
						continue;
					}
					continue;
				case 371:
					Form1.cjbEqXhOkHto9Mpb3TF(this.PanelKeyBind.Controls, this.labelKeyPreview);
					num = 719;
					continue;
				case 372:
					this.guna2DragControl1.TargetControl = this.guna2GradientPanel1;
					num = 1233;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 != 0)
					{
						num = 558;
						continue;
					}
					continue;
				case 373:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabSettings, Form1.Bp8crKQbU76Tg68kvQp(-838478377 ^ -838469075));
					this.tabSettings.UseVisualStyleBackColor = true;
					num = 1319;
					continue;
				case 374:
					this.statusIcon.ImageRotate = 0f;
					num2 = 404;
					break;
				case 375:
					Form1.F8DDPrC4dhV11PnsIC6(this.label2, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1388170447 ^ -1388176627), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 1100;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
					{
						num = 1032;
						continue;
					}
					continue;
				case 376:
					Form1.m07tEyiqJ14uAJStg1D(this.guna2ComboBox1, 5);
					num = 964;
					continue;
				case 377:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2), this.label3);
					num = 798;
					continue;
				case 378:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					Form1.URcVOuSDSFDRM7OmWTX(dataGridViewCellStyle2, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(850579974 + 1765464631 ^ -1678932991), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 31;
					continue;
				}
				case 379:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2TabControl2, new Font(Form1.Bp8crKQbU76Tg68kvQp(1767032709 ^ 1767042847), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 603;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
					{
						num = 62;
						continue;
					}
					continue;
				case 380:
					Form1.c0T4oUhzseliJt6JbSj(this.label10, 14);
					num = 102;
					continue;
				case 381:
					Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button3).ForeColor = Color.FromArgb(141, 141, 141);
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button3, new Font(Form1.Bp8crKQbU76Tg68kvQp(~1053049764 ^ -1053059993), 9f));
					num = 1234;
					continue;
				case 382:
					this.tabRotation.TabIndex = 0;
					num = 1104;
					continue;
				case 383:
					Form1.DIHdSHS7iP1A7KmNMB1(this.btnReGenerateAddon.DisabledState, Color.DarkGray);
					num = 496;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d != 0)
					{
						num = 1183;
						continue;
					}
					continue;
				case 384:
					Form1.HjK5KFI2DSeCFHmC5pL(this.toggleManualCastQueue).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255);
					num = 741;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
					{
						num = 582;
						continue;
					}
					continue;
				case 385:
					Form1.WEEKU5ISYMiMN2vRBsC(this.DataGridSpell, new DataGridViewCellEventHandler(this.DxqPf0BvVp));
					num = 322;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 == 0)
					{
						num = 39;
						continue;
					}
					continue;
				case 386:
					this.textPreCast.Name = Form1.Bp8crKQbU76Tg68kvQp(~-531755127 ^ 531744062);
					this.textPreCast.Size = new Size(152, 35);
					num = 1134;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num = 1014;
						continue;
					}
					continue;
				case 387:
					this.label17.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-902888658 ^ -902878446), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 33;
					continue;
				case 388:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.label5, Color.DimGray);
					num2 = 83;
					break;
				case 389:
					Form1.U3XM2Qhm2XM60XWh7EK(this.tabPage2, new Point(4, 34));
					num = 79;
					continue;
				case 390:
					Form1.zKIb6qIUoerGPumUHJO(this.DataGridSpell, new DataGridViewCellEventHandler(this.KhrEuZlNy8));
					num = 32;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
					{
						num = 189;
						continue;
					}
					continue;
				case 391:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2Button2, Form1.pd7LrbAfTlIgHjZelLV());
					num = 635;
					continue;
				case 392:
					Form1.BYULIGhFpBJPZrMGUKF(this.tabKeybinds, Form1.Bp8crKQbU76Tg68kvQp(-552555469 << 5 ^ -501896678));
					num = 574;
					continue;
				case 393:
					Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabControl1).Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1218526815 ^ -1218516523), 10f);
					num2 = 649;
					break;
				case 394:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2), this.textGameFolder);
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabPage2.Controls, this.label1);
					this.tabPage2.ForeColor = Color.DimGray;
					num = 911;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
					{
						num = 546;
						continue;
					}
					continue;
				case 395:
					Form1.bnrr8uiplYjGFY5NtLt(this.textStatus, '\0');
					num2 = 451;
					break;
				case 396:
					Form1.BYULIGhFpBJPZrMGUKF(this.tabPage3, Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993694744));
					num = 1002;
					continue;
				case 397:
					this.guna2DragControl2 = new Guna2DragControl(this.components);
					this.guna2GradientPanel2 = new Guna2GradientPanel();
					num = 1317;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num = 1246;
						continue;
					}
					continue;
				case 398:
					Form1.rNH3WfhJCd14ZcstGLE(this.tabPage5, 6);
					num = 56;
					continue;
				case 399:
					Form1.DIHdSHS7iP1A7KmNMB1(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button9), Color.DarkGray);
					Form1.wr5o3ESO7nyo3wXgm1J(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button9), Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169));
					num = 721;
					continue;
				case 400:
					this.textGameFolder.Padding = new Padding(2, 0, 2, 0);
					num = 727;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 != 0)
					{
						num = 376;
						continue;
					}
					continue;
				case 401:
					this.label2 = new Label();
					num = 1219;
					continue;
				case 402:
					Form1.gGZnrriA34hqIifEHcW(this.comboGameVersion, ComboBoxStyle.DropDownList);
					Form1.QKARLdioNwUFu7gp91N(this.comboGameVersion, Color.FromArgb(94, 148, 255));
					num2 = 508;
					break;
				case 403:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label5, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(587114080 ^ 587109138));
					num = 92;
					continue;
				case 404:
					this.statusIcon.Location = new Point(26, 14);
					num = 883;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a != 0)
					{
						num = 787;
						continue;
					}
					continue;
				case 405:
					this.listView1 = new ListView();
					num = 439;
					continue;
				case 406:
					Form1.wEyJSbCFacgSXItvROk(this.textStatus, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1520361985 >> 6 ^ -23745461), 9f));
					Form1.gXLZdyZWdMVsRAfFt9y(this.textStatus, Form1.pd7LrbAfTlIgHjZelLV());
					num = 634;
					continue;
				case 407:
					this.columnHeader2 = new ColumnHeader();
					num = 988;
					continue;
				case 408:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5).Add(this.label12);
					num = 322;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 != 0)
					{
						num = 1158;
						continue;
					}
					continue;
				case 409:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2ComboBox1, Form1.Bp8crKQbU76Tg68kvQp(-1745773992 ^ -1745771814));
					num2 = 946;
					break;
				case 410:
					this.guna2Button9.TabIndex = 35;
					num = 144;
					continue;
				case 411:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2Button7, Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 1061;
					break;
				case 412:
					Form1.HU61GfI0Rv3AMEKtWnE(this.toggleAttackTargetNotInCombat).InnerColor = Form1.pd7LrbAfTlIgHjZelLV();
					num2 = 94;
					break;
				case 413:
					Form1.Ejey22SwIyfvnrggGSM(this.loadSelectedToolStripMenuItem, new EventHandler(this.iROP9qRNDm));
					Form1.z9Mdc3SQmvCHbuhnA9j(this.addScriptToolStripMenuItem, Resources.add);
					num = 747;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
					{
						num = 375;
						continue;
					}
					continue;
				case 414:
					Form1.F8DDPrC4dhV11PnsIC6(this.label1, new Font(Form1.Bp8crKQbU76Tg68kvQp(978854837 ^ 978848649), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 1204;
					continue;
				case 415:
					Form1.fSKvdPhXB121ntJCND9(this.txtLicenseType, new Point(14, 97));
					this.txtLicenseType.Margin = new Padding(2);
					num = 1040;
					continue;
				case 416:
					Form1.bAfsNnixIiVZajHwRbB(this.txtLicenseExpiry, Form1.VA4WwsiygtFFKaVPeZt());
					num = 1066;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
					{
						num = 1156;
						continue;
					}
					continue;
				case 417:
					Form1.V2VuSDiHi2u8pdosmn2(this.guna2ControlBox1, true);
					num = 822;
					continue;
				case 418:
					this.guna2Button9.Location = new Point(413, 5);
					num = 190;
					continue;
				case 419:
					Form1.c0T4oUhzseliJt6JbSj(this.label13, 29);
					num = 612;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
					{
						num = 1041;
						continue;
					}
					continue;
				case 420:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					Form1.O31LTUSM513icv5yigG(this.DataGridSpell, dataGridViewCellStyle3);
					num = 266;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab == 0)
					{
						num = 542;
						continue;
					}
					continue;
				}
				case 421:
					this.listView1.Location = new Point(2, 30);
					num = 1119;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
					{
						num = 698;
						continue;
					}
					continue;
				case 422:
					this.guna2TabSettings.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-258475567 << 4 ^ 159362334);
					num = 1262;
					continue;
				case 423:
					Form1.C31yKlIK6enWtdykbpD(this.ColDisabled, DataGridViewTriState.False);
					num = 533;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 == 0)
					{
						num = 308;
						continue;
					}
					continue;
				case 424:
					Form1.c0T4oUhzseliJt6JbSj(this.textAddonName, 9);
					Form1.UDBpMTifsAVJ3rf3uW5(this.textAddonName, new Point(-2, 0));
					num = 89;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
					{
						num = 303;
						continue;
					}
					continue;
				case 425:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2TabControl1), this.tabSettings);
					num = 969;
					continue;
				case 426:
					Form1.scPSmFihKgRV47xXFZQ(this.comboGameVersion, 0);
					num = 32;
					continue;
				case 427:
				{
					DataGridViewCellStyle dataGridViewCellStyle6;
					Form1.WokGlvITygHmuJPTud4(dataGridViewCellStyle6, new Padding(5, 0, 0, 0));
					num = 1216;
					continue;
				}
				case 428:
					this.guna2TabControl2 = new Guna2TabControl();
					num = 814;
					continue;
				case 429:
					Form1.u2jKCGiuYuHiMgf1sx7(this.textPulseFrequency, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2083830725 ^ -2083820537), 9f));
					num = 1006;
					continue;
				case 430:
					this.guna2GradientPanel3.PerformLayout();
					num = 84;
					continue;
				case 431:
					this.guna2TabControl1.TabMenuBackColor = Form1.Y1UIkkw4SWDmFnSC63U(218, 218, 218);
					num = 538;
					continue;
				case 432:
					Form1.tRMKuWiiLgmaY6xGY7v(Form1.Jlq43diUhDdv5DIhVjg(this.textAddonName), Form1.Y1UIkkw4SWDmFnSC63U(64, 64, 64));
					num = 111;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea != 0)
					{
						num = 126;
						continue;
					}
					continue;
				case 433:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2TabControl1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1939306647 + 173235911 ^ -1766076832));
					num = 11;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
					{
						num = 646;
						continue;
					}
					continue;
				case 434:
					Form1.Cv9NRmI4hrLJaPHB83g(this.ColDisabled, Form1.Bp8crKQbU76Tg68kvQp(-1495818301 ^ -1495813523));
					num = 1261;
					continue;
				case 435:
					Form1.EaqCr3wYwj8s8ef9lTX(this.loadSelectedToolStripMenuItem, false);
					Form1.z9Mdc3SQmvCHbuhnA9j(this.loadSelectedToolStripMenuItem, Resources.send);
					num = 343;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 != 0)
					{
						num = 188;
						continue;
					}
					continue;
				case 436:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button3, 20);
					num = 197;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
					{
						num = 244;
						continue;
					}
					continue;
				case 437:
					Form1.I5salaIrpg8plUCDDAh(this.guna2Button9, 5);
					num = 329;
					continue;
				case 438:
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabPage2.Controls, this.label2);
					num = 20;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
					{
						num = 36;
						continue;
					}
					continue;
				case 439:
					this.columnHeader1 = new ColumnHeader();
					num = 407;
					continue;
				case 440:
					this.ColBindBtn = new DataGridViewButtonColumn();
					num = 473;
					continue;
				case 441:
					this.guna2ProgressIndicator1 = new Guna2ProgressIndicator();
					num2 = 225;
					break;
				case 442:
					this.label10.Size = new Size(101, 20);
					num = 89;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
					{
						num = 380;
						continue;
					}
					continue;
				case 443:
					Form1.cjbEqXhOkHto9Mpb3TF(this.guna2TabControl2.Controls, this.tabPage3);
					num = 510;
					continue;
				case 444:
					Form1.JBnCqRhMbY6dWf5nXZF(this.guna2GradientPanel2, new Padding(2));
					num = 1029;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 == 0)
					{
						num = 190;
						continue;
					}
					continue;
				case 445:
					Form1.MfatdIi2l6oI10Dp7f2(this.guna2ControlBox1, true);
					num = 1064;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
					{
						num = 1;
						continue;
					}
					continue;
				case 446:
					this.label2.Margin = new Padding(2, 0, 2, 0);
					num = 694;
					continue;
				case 447:
					Form1.YPRcuOZoty6L8p0TrHX(this.openFileDialog1, Form1.Bp8crKQbU76Tg68kvQp(~2095831454 ^ -2095834253));
					num = 567;
					continue;
				case 448:
					Form1.fSKvdPhXB121ntJCND9(this.label7, new Point(11, 262));
					num = 734;
					continue;
				case 449:
					this.guna2MessageDialog1.Parent = this;
					num = 99;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
					{
						num = 124;
						continue;
					}
					continue;
				case 450:
					this.label4.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-309791748 - 2077333185 ^ 1907848455), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 679;
					continue;
				case 451:
					Form1.GtfMAhi4Efiicblyei4(this.textStatus, "");
					num = 965;
					continue;
				case 452:
					this.textStatus.TabIndex = 3;
					num = 1357;
					continue;
				case 453:
					Form1.EuGjb6SauPVqqcdQRHP(this.PanelKeyBind, 20);
					num = 730;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
					{
						num = 406;
						continue;
					}
					continue;
				case 454:
					Form1.GOQ6mliZ99yg9aWmiSk(Form1.gBFD6UiIE14syZ5nRUZ(this.txtLicenseType), Form1.Y1UIkkw4SWDmFnSC63U(138, 138, 138));
					num = 971;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 == 0)
					{
						num = 979;
						continue;
					}
					continue;
				case 455:
					Form1.BYULIGhFpBJPZrMGUKF(this.textStatus, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-443850682 << 3 ^ 744177240));
					num = 282;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 != 0)
					{
						num = 1217;
						continue;
					}
					continue;
				case 456:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button6, 17);
					num = 64;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 == 0)
					{
						num = 65;
						continue;
					}
					continue;
				case 457:
					this.textAddonRefreshRate = new Guna2NumericUpDown();
					num = 1203;
					continue;
				case 458:
					Form1.Lg0ScKIpjNLeXbDQTVP(this.ColBindBtn, DataGridViewAutoSizeColumnMode.None);
					num = 123;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba != 0)
					{
						num = 88;
						continue;
					}
					continue;
				case 459:
					Form1.NI0nbahhQrIJ1PGSqQI(this.guna2GradientPanel2);
					num = 1187;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
					{
						num = 589;
						continue;
					}
					continue;
				case 460:
					Form1.BYULIGhFpBJPZrMGUKF(this.label17, Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463902857));
					num = 564;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num = 26;
						continue;
					}
					continue;
				case 461:
					Form1.BYULIGhFpBJPZrMGUKF(this.PanelKeyBind, Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764420523));
					num = 546;
					continue;
				case 462:
					Form1.BYULIGhFpBJPZrMGUKF(this.label8, Form1.Bp8crKQbU76Tg68kvQp(-256932895 ^ -256919423));
					Form1.sUSlgdhHRw1CXHlv9uV(this.label8, new Size(75, 20));
					num = 541;
					continue;
				case 463:
					Form1.UDBpMTifsAVJ3rf3uW5(this.txtLicenseType, new Point(-2, 0));
					num = 204;
					continue;
				case 464:
					this.guna2PictureBox1.Location = new Point(10, 9);
					num = 76;
					continue;
				case 465:
					Form1.U3XM2Qhm2XM60XWh7EK(this.tabKeybinds, new Point(184, 4));
					num = 551;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
					{
						num = 269;
						continue;
					}
					continue;
				case 466:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabPage3, true);
					num = 833;
					continue;
				case 467:
					Form1.uyiPqPilkVZPP2eqCPv(this.guna2Button8, Form1.guNG4gh19ILHCqNxi2h());
					num = 215;
					continue;
				case 468:
					this.DataGridSettings.AllowUserToResizeRows = false;
					num = 794;
					continue;
				case 469:
					this.guna2ControlBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
					num = 226;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba != 0)
					{
						num = 445;
						continue;
					}
					continue;
				case 470:
					Form1.vTvWhXSNL5wYWtHE0QY(this.DataGridSettings, false);
					num = 468;
					continue;
				case 471:
					Form1.BYULIGhFpBJPZrMGUKF(this.label4, Form1.Bp8crKQbU76Tg68kvQp(-1505789866 ^ -1505800816));
					num = 142;
					continue;
				case 472:
					this.guna2TabControl2.SelectedIndex = 0;
					num = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				case 473:
					this.ColDisabled = new DataGridViewCheckBoxColumn();
					num = 699;
					continue;
				case 474:
					Form1.AQ5PKbSlGpZgbylJlqA(this.comboKeyboard, Color.Transparent);
					num = 412;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
					{
						num = 565;
						continue;
					}
					continue;
				case 475:
					Form1.pFoxNeSZ5YRTR9whdfW(Form1.GaMaotCqWxchpV0yRLI(this.imageList2), 1, Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679314496));
					num2 = 618;
					break;
				case 476:
					Form1.c0T4oUhzseliJt6JbSj(this.textGameFolder, 6);
					num = 276;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e == 0)
					{
						num = 1084;
						continue;
					}
					continue;
				case 477:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2Button5, new Size(160, 42));
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button5, 16);
					num = 1299;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
					{
						num = 324;
						continue;
					}
					continue;
				case 478:
					Form1.jjZ4QDh9WnrfumnYDdq(this.toolTip1, this.label16, Form1.Bp8crKQbU76Tg68kvQp(-865714864 ^ -865727282));
					num = 770;
					continue;
				case 479:
					Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button2).ForeColor = Form1.Y1UIkkw4SWDmFnSC63U(141, 141, 141);
					num2 = 518;
					break;
				case 480:
					Form1.wxMaZnI7u1L89VdGNLA(this.label3, true);
					num = 489;
					continue;
				case 481:
					Form1.Dcb5bSIwp9OrjHe2mgd(this.DataGridSpell.ThemeStyle.RowsStyle, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 237;
					continue;
				case 482:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label2, new Size(98, 20));
					num = 1171;
					continue;
				case 483:
					this.label12.ForeColor = Form1.G9eLqeSP2XWNAQfY8h5();
					num = 1091;
					continue;
				case 484:
					this.guna2Button5.Name = Form1.Bp8crKQbU76Tg68kvQp(-825446221 ^ -825455931);
					num = 477;
					continue;
				case 485:
					Form1.dYGjm9S6AyCC0N2dwKP(this.DataGridSpell, false);
					num = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 != 0)
					{
						num = 23;
						continue;
					}
					continue;
				case 486:
					Form1.AQ5PKbSlGpZgbylJlqA(this.guna2ComboBox1, Color.Transparent);
					num2 = 376;
					break;
				case 487:
					Form1.c0T4oUhzseliJt6JbSj(this.label12, 27);
					num = 1122;
					continue;
				case 488:
					this.toggleAutoTab.UncheckedState.FillColor = Form1.Y1UIkkw4SWDmFnSC63U(125, 137, 149);
					num = 1022;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
					{
						num = 484;
						continue;
					}
					continue;
				case 489:
					this.label3.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-235868112 ^ -235874292), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 720;
					continue;
				case 490:
					Form1.CxP1olSUjKIoBxtX0u6(this.tabPage5, 2);
					num = 224;
					continue;
				case 491:
					this.ColType = new DataGridViewTextBoxColumn();
					num = 936;
					continue;
				case 492:
					Form1.Cv9NRmI4hrLJaPHB83g(this.ColIcon, "");
					num = 219;
					continue;
				case 493:
					Form1.JBnCqRhMbY6dWf5nXZF(this.label8, new Padding(2, 0, 2, 0));
					num = 92;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
					{
						num = 462;
						continue;
					}
					continue;
				case 494:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings).BackColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 139;
					continue;
				case 495:
					this.tabPage4.ResumeLayout(false);
					num = 49;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
					{
						num = 9;
						continue;
					}
					continue;
				case 496:
					Form1.BYULIGhFpBJPZrMGUKF(this.tabRotation, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(212924216 ^ 212918270));
					num = 517;
					continue;
				case 497:
					this.toggleAttackOutOfCombat.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
					num = 422;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
					{
						num = 596;
						continue;
					}
					continue;
				case 498:
					this.ColType.MinimumWidth = 100;
					num = 226;
					continue;
				case 499:
					this.txtUsername.Margin = new Padding(2);
					num = 263;
					continue;
				case 500:
					this.ColIcon.ReadOnly = true;
					num = 673;
					continue;
				case 501:
					this.timer1 = new System.Windows.Forms.Timer(this.components);
					num = 207;
					continue;
				case 502:
				{
					DataGridViewCellStyle dataGridViewCellStyle7;
					Form1.qAY2DbS0lQMxESRlAmp(this.DataGridSpell, dataGridViewCellStyle7);
					num = 63;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c7104ccd40024e009409c6d14eb5a99a == 0)
					{
						num = 167;
						continue;
					}
					continue;
				}
				case 503:
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabLog.Controls, this.textConsole);
					num = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
					{
						num = 8;
						continue;
					}
					continue;
				case 504:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button9, new EventHandler(this.EZAEX9oRuv));
					num = 1186;
					continue;
				case 505:
					this.imageList2 = new ImageList(this.components);
					num = 1201;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 == 0)
					{
						num = 1218;
						continue;
					}
					continue;
				case 506:
				{
					DataGridViewCellStyle dataGridViewCellStyle5;
					dataGridViewCellStyle5.ForeColor = Form1.G9eLqeSP2XWNAQfY8h5();
					num = 515;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
					{
						num = 650;
						continue;
					}
					continue;
				}
				case 507:
					Form1.GTMMr4ILDsKXD57tVjr(this.ColSettingsName, 90.27778f);
					num = 1054;
					continue;
				case 508:
					Form1.QXLTdLiS2A3LwtG90ws(Form1.DUmRGwi33SRyIHDjWmi(this.comboGameVersion), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					this.comboGameVersion.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(850579974 + 1765464631 ^ -1678932991), 10f);
					num = 306;
					continue;
				case 509:
					this.btnStartStop.DisabledState.BorderColor = Color.DarkGray;
					num2 = 29;
					break;
				case 510:
					Form1.OROF9nCl3q4uMeX8ApH(this.guna2TabControl2).Add(this.tabPage4);
					num = 1065;
					continue;
				case 511:
					Form1.BYULIGhFpBJPZrMGUKF(this.label13, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1505789866 ^ -1505801620));
					num = 893;
					continue;
				case 512:
					Form1.OwXluvird6m1iOdasF2(this.guna2GradientPanel1, LinearGradientMode.Vertical);
					num = 689;
					continue;
				case 513:
					this.PanelKeyBind = new Guna2ContainerControl();
					num = 441;
					continue;
				case 514:
					Form1.sCe17XiYW9iTPSTjkEk(this.statusIcon, PictureBoxSizeMode.StretchImage);
					num = 109;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 101;
						continue;
					}
					continue;
				case 515:
					this.DataGridSpell.RowHeadersVisible = false;
					num = 269;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
					{
						num = 34;
						continue;
					}
					continue;
				case 516:
					this.txtUsername.Size = new Size(509, 33);
					num = 1163;
					continue;
				case 517:
					Form1.sUSlgdhHRw1CXHlv9uV(this.tabRotation, new Size(731, 420));
					num = 382;
					continue;
				case 518:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button2, new Font(Form1.Bp8crKQbU76Tg68kvQp(790722942 ^ 790712642), 9f));
					num = 391;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
					{
						num = 218;
						continue;
					}
					continue;
				case 519:
					Form1.G1bergS3wlgABlFmf1Z(this.menuStrip1, new Size(20, 20));
					this.menuStrip1.Items.AddRange(new ToolStripItem[]
					{
						this.loadSelectedToolStripMenuItem,
						this.addScriptToolStripMenuItem,
						this.removeScriptToolStripMenuItem,
						this.editToolStripMenuItem
					});
					num = 383;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
					{
						num = 1278;
						continue;
					}
					continue;
				case 520:
					Form1.OmMH5wINnsrGWBpyo6n(this.toggleAttackOutOfCombat.UncheckedState, Form1.pd7LrbAfTlIgHjZelLV());
					num = 1316;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 == 0)
					{
						num = 250;
						continue;
					}
					continue;
				case 521:
					Form1.JBnCqRhMbY6dWf5nXZF(this.tabLog, new Padding(2));
					num = 1350;
					continue;
				case 522:
					this.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-87166655 + -2142521002 ^ 2065269419), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 356;
					continue;
				case 523:
					Form1.GTMMr4ILDsKXD57tVjr(this.ColSettingsValue, 90.27778f);
					num = 1338;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
					{
						num = 1078;
						continue;
					}
					continue;
				case 524:
					this.tabPage2.PerformLayout();
					num = 243;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
					{
						num = 743;
						continue;
					}
					continue;
				case 525:
					this.DataGridSettings.CurrentCellDirtyStateChanged += this.TklEm7gGaH;
					num = 152;
					continue;
				case 526:
					Form1.fSKvdPhXB121ntJCND9(this.guna2Button4, new Point(151, 331));
					num = 748;
					continue;
				case 527:
					Form1.Fb8UmLiRlpCh8WUG8v0(this.txtLicenseType.DisabledState, Color.FromArgb(226, 226, 226));
					num = 31;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
					{
						num = 153;
						continue;
					}
					continue;
				case 528:
					this.contextMenuShowMacro.SuspendLayout();
					this.guna2GradientPanel3.SuspendLayout();
					num = 1242;
					continue;
				case 529:
				{
					DataGridViewCellStyle dataGridViewCellStyle5;
					Form1.IWMBi6AOVaRiLvC0OqM(dataGridViewCellStyle5, Color.White);
					Form1.URcVOuSDSFDRM7OmWTX(dataGridViewCellStyle5, new Font(Form1.Bp8crKQbU76Tg68kvQp(828767401 >> 3 ^ 103585705), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num2 = 506;
					break;
				}
				case 530:
					Form1.sLBp4vhs8n4RKjjB6is(this.textConsole, DockStyle.Fill);
					num2 = 746;
					break;
				case 531:
					this.btnStartStop = new Guna2GradientButton();
					this.guna2MessageDialog1 = new Guna2MessageDialog();
					num = 505;
					continue;
				case 532:
					this.guna2GradientPanel2.GradientMode = LinearGradientMode.Vertical;
					num = 976;
					continue;
				case 533:
					Form1.nZesEQIFV9dQquxGUD5(this.ColDisabled, 70);
					num = 1329;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b != 0)
					{
						num = 833;
						continue;
					}
					continue;
				case 534:
					this.guna2TabControl1.ItemSize = new Size(180, 45);
					num = 956;
					continue;
				case 535:
					this.guna2GradientPanel2.FillColor = Form1.Y1UIkkw4SWDmFnSC63U(60, 60, 60);
					num = 236;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 == 0)
					{
						num = 803;
						continue;
					}
					continue;
				case 536:
					Form1.CxP1olSUjKIoBxtX0u6(this.tabSettings, 2);
					num2 = 373;
					break;
				case 537:
					Form1.OqRJI9IewOiqmFiV0R3(this.contextMenuShowMacro, new CancelEventHandler(this.LcuEEIQO6v));
					num = 1244;
					continue;
				case 538:
					Form1.eFeObWh0FiV2NaypcSU(this.tabRotation, true);
					num = 813;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 == 0)
					{
						num = 329;
						continue;
					}
					continue;
				case 539:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2TabSettings, 0);
					num2 = 1303;
					break;
				case 540:
					Form1.gGHMpMi50ocPwkUtejc(this.textPreCast, 5);
					num = 1211;
					continue;
				case 541:
					Form1.c0T4oUhzseliJt6JbSj(this.label8, 10);
					num = 1320;
					continue;
				case 542:
					Form1.Kk0xPCSG2g31xCMwluA(this.DataGridSpell, 30);
					num = 232;
					continue;
				case 543:
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabPage3.Controls, this.webView21);
					num = 97;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 55;
						continue;
					}
					continue;
				case 544:
					Form1.voYLFshjBEBI0ODwIr7(this.txtLicenseType, new Padding(2, 0, 2, 0));
					num = 1108;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
					{
						num = 994;
						continue;
					}
					continue;
				case 545:
				{
					DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
					num = 657;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
					{
						num = 365;
						continue;
					}
					continue;
				}
				case 546:
					this.PanelKeyBind.Size = new Size(313, 231);
					Form1.c0T4oUhzseliJt6JbSj(this.PanelKeyBind, 4);
					num = 808;
					continue;
				case 547:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.lhQG5DZUPFpbhUYGZty(this), this.guna2TabControl1);
					num = 151;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba != 0)
					{
						num = 26;
						continue;
					}
					continue;
				case 548:
					Form1.tRMKuWiiLgmaY6xGY7v(this.txtUsername.FocusedState, Form1.Y1UIkkw4SWDmFnSC63U(64, 64, 64));
					num = 1021;
					continue;
				case 549:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabLog, false);
					num = 1093;
					continue;
				case 550:
					Form1.cjbEqXhOkHto9Mpb3TF(this.guna2GradientPanel2.Controls, this.btnStartStop);
					num = 1209;
					continue;
				case 551:
					Form1.JBnCqRhMbY6dWf5nXZF(this.tabKeybinds, new Padding(0));
					num = 392;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
					{
						num = 225;
						continue;
					}
					continue;
				case 552:
					this.label13 = new Label();
					this.toggleAutoTab = new Guna2ToggleSwitch();
					num = 161;
					continue;
				case 553:
					this.textPreCast = new Guna2NumericUpDown();
					num = 633;
					continue;
				case 554:
					Form1.qUoa3MS2blaFwKqpFJ7(this.labelKeyPreview, ContentAlignment.MiddleCenter);
					num = 26;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 == 0)
					{
						num = 485;
						continue;
					}
					continue;
				case 555:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2ComboBox1, 11);
					Form1.MBxdu8iw8gTc2lKiMol(this.guna2ComboBox1, new EventHandler(this.t2sPOHFX1j));
					num = 480;
					continue;
				case 556:
					Form1.c0T4oUhzseliJt6JbSj(this.label4, 19);
					num = 306;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
					{
						num = 817;
						continue;
					}
					continue;
				case 557:
					this.btnStartStop.ForeColor = Color.White;
					num2 = 757;
					break;
				case 558:
					Form1.Ejey22SwIyfvnrggGSM(this.toolStripMenuItemClearBind, new EventHandler(this.qfTPzcffVJ));
					num = 284;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf == 0)
					{
						num = 74;
						continue;
					}
					continue;
				case 559:
					Form1.twywWuI6kMlWTtwfxxc(this.toggleAttackTargetNotInCombat.CheckedState, Color.FromArgb(94, 148, 255));
					num = 259;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 == 0)
					{
						num = 914;
						continue;
					}
					continue;
				case 560:
					Form1.wn4MVbhaDtLVWnT24Xb(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl1), Form1.Y1UIkkw4SWDmFnSC63U(188, 188, 188));
					num = 973;
					continue;
				case 561:
					this.txtUsername.ReadOnly = true;
					num = 1322;
					continue;
				case 562:
					this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
					num = 1205;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
					{
						num = 830;
						continue;
					}
					continue;
				case 563:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					Form1.sHSPBYSXYHPhTAgWo8a(dataGridViewCellStyle3, DataGridViewTriState.True);
					num = 420;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 != 0)
					{
						num = 36;
						continue;
					}
					continue;
				}
				case 564:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label17, new Size(100, 20));
					this.label17.TabIndex = 24;
					num2 = 1099;
					break;
				case 565:
					this.comboKeyboard.BorderRadius = 5;
					num = 37;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num = 9;
						continue;
					}
					continue;
				case 566:
					this.label11 = new Label();
					num = 40;
					continue;
				case 567:
					Form1.WeAMDIZ3OJV2FuY6yVH(this.timer1, true);
					num = 132;
					continue;
				case 568:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabPage1, true);
					num = 1359;
					continue;
				case 569:
					this.guna2TabControl1.Dock = DockStyle.Fill;
					num = 709;
					continue;
				case 570:
					Form1.fSKvdPhXB121ntJCND9(this.toggleAttackTargetNotInCombat, new Point(12, 142));
					num = 1013;
					continue;
				case 571:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					dataGridViewCellStyle3.BackColor = Color.FromArgb(76, 132, 255);
					num = 23;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 != 0)
					{
						num = 87;
						continue;
					}
					continue;
				}
				case 572:
					Form1.alCM98iCFxYevvKLalT(this.comboGameVersion).AddRange(new object[]
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1691472209 >> 1 ^ 845731228),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039292696),
						Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993702672)
					});
					num = 845;
					continue;
				case 573:
					Form1.jyjAD8InwfkZ05g28Ir(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAttackTargetNotInCombat), Color.White);
					num = 351;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 != 0)
					{
						num = 570;
						continue;
					}
					continue;
				case 574:
					Form1.sUSlgdhHRw1CXHlv9uV(this.tabKeybinds, new Size(731, 420));
					num = 121;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 == 0)
					{
						num = 367;
						continue;
					}
					continue;
				case 575:
					Form1.jjcAKNhRfBLpRys7iFS(this.guna2TabControl1, 0);
					num = 922;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d95aff6635834f54a612ecd769021757 == 0)
					{
						num = 36;
						continue;
					}
					continue;
				case 576:
					Form1.XT9GbTSoNQNEAtQu6FN(this.columnHeader1, 198);
					num = 134;
					continue;
				case 577:
					Form1.F8DDPrC4dhV11PnsIC6(this.label10, new Font(Form1.Bp8crKQbU76Tg68kvQp(-161182833 ^ -161176653), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 1125;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
					{
						num = 895;
						continue;
					}
					continue;
				case 578:
					Form1.NI0nbahhQrIJ1PGSqQI(this.guna2TabSettings);
					num = 261;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
					{
						num = 697;
						continue;
					}
					continue;
				case 579:
					this.guna2Button3.BorderRadius = 5;
					num = 1221;
					continue;
				case 580:
					Form1.thaHaeigK1YcARZBfq2(this.statusIcon, true);
					num = 912;
					continue;
				case 581:
					Form1.U78ErFiW8ytOndbO7FA(this.DataGridSettings, new DataGridViewCellEventHandler(this.jZQEoVW1yy));
					num = 678;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
					{
						num = 868;
						continue;
					}
					continue;
				case 582:
					this.label8.ForeColor = Form1.G9eLqeSP2XWNAQfY8h5();
					num = 1139;
					continue;
				case 583:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2Button1, new Size(39, 37));
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button1, 6);
					num = 355;
					continue;
				case 584:
					this.guna2TabSettings.Size = new Size(731, 420);
					num = 922;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 != 0)
					{
						num = 1236;
						continue;
					}
					continue;
				case 585:
					Form1.GtWSMsZTTqoBGllCQwV(this.tabAccount);
					num = 1166;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a != 0)
					{
						num = 656;
						continue;
					}
					continue;
				case 586:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.label13, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 940;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 == 0)
					{
						num = 137;
						continue;
					}
					continue;
				case 587:
					Form1.sLBp4vhs8n4RKjjB6is(this.listView1, DockStyle.Fill);
					num = 64;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
					{
						num = 32;
						continue;
					}
					continue;
				case 588:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.label9, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 1047;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 == 0)
					{
						num = 414;
						continue;
					}
					continue;
				case 589:
					Form1.Lg0ScKIpjNLeXbDQTVP(this.ColSettingsValue, DataGridViewAutoSizeColumnMode.Fill);
					num = 523;
					continue;
				case 590:
					Form1.tRMKuWiiLgmaY6xGY7v(this.txtLicenseExpiry.FocusedState, Form1.Y1UIkkw4SWDmFnSC63U(64, 64, 64));
					num = 1235;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 != 0)
					{
						num = 124;
						continue;
					}
					continue;
				case 591:
					Form1.kuuVDJivF2fmWwSDAEy(this.textStatus, Form1.HWi2GWSiSnTprngPudf());
					num = 1201;
					continue;
				case 592:
					Form1.c0T4oUhzseliJt6JbSj(this.DataGridSettings, 3);
					num = 744;
					continue;
				case 593:
					this.webView21.CreationProperties = null;
					num = 119;
					continue;
				case 594:
					Form1.qBhlhiIlRfXyLrXRVfV(this.ColType, true);
					Form1.Lg0ScKIpjNLeXbDQTVP(this.ColName, DataGridViewAutoSizeColumnMode.Fill);
					num = 1207;
					continue;
				case 595:
					Form1.H2Y868imN0R3hi3RCni(Form1.aAPe6rZxwU6t38Vswk4(this.btnStartStop), new Padding(2));
					num = 655;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 != 0)
					{
						num = 953;
						continue;
					}
					continue;
				case 596:
					Form1.twywWuI6kMlWTtwfxxc(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAttackOutOfCombat), Color.FromArgb(94, 148, 255));
					Form1.OmMH5wINnsrGWBpyo6n(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAttackOutOfCombat), Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 11;
					break;
				case 597:
					Form1.nZesEQIFV9dQquxGUD5(this.ColBindBtn, 80);
					num = 302;
					continue;
				case 598:
					Form1.TJq9P8Iq2rqwaZGcKXi(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell).HeaderStyle, Color.FromArgb(100, 88, 255));
					num2 = 775;
					break;
				case 599:
					this.editToolStripMenuItem = new ToolStripMenuItem();
					num = 820;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num = 68;
						continue;
					}
					continue;
				case 600:
					this.tabPage3.Margin = new Padding(2);
					num = 396;
					continue;
				case 601:
					this.guna2Button3.Margin = new Padding(2);
					num = 40;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 != 0)
					{
						num = 122;
						continue;
					}
					continue;
				case 602:
					this.PanelKeyBind.ResumeLayout(false);
					num = 931;
					continue;
				case 603:
					Form1.yhxkS5C9aXPyOelZpN6(this.guna2TabControl2, this.imageList3);
					num2 = 328;
					break;
				case 604:
					Form1.c0T4oUhzseliJt6JbSj(this.label16, 31);
					num = 1269;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num = 1214;
						continue;
					}
					continue;
				case 605:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2Button2, new Size(63, 33));
					num = 111;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
					{
						num = 91;
						continue;
					}
					continue;
				case 606:
					this.tabSettings.ImageIndex = 3;
					num = 1192;
					continue;
				case 607:
					Form1.RaAXdAhZ3eX1aiYGeFQ(this.guna2BorderlessForm1, 0.6);
					num = 792;
					continue;
				case 608:
					this.webView21 = new WebView2();
					num = 1012;
					continue;
				case 609:
					Form1.Ad7GlFZOdTMGNgNof4T(this, FormStartPosition.CenterScreen);
					num = 651;
					continue;
				case 610:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5), this.label11);
					num = 1001;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 != 0)
					{
						num = 513;
						continue;
					}
					continue;
				case 611:
					Form1.NTYtH4ICbD0jWXFC4ol(this.DataGridSettings.ThemeStyle).SelectionBackColor = Form1.Y1UIkkw4SWDmFnSC63U(231, 229, 255);
					num = 1032;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
					{
						num = 1200;
						continue;
					}
					continue;
				case 612:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.btnCancelBind, Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 963;
					break;
				case 613:
					this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
					num = 372;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
					{
						num = 142;
						continue;
					}
					continue;
				case 614:
					Form1.DqpuD4IY1WemtTnDXyG(this.DataGridSettings, DataGridViewColumnHeadersHeightSizeMode.DisableResizing);
					num = 161;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 != 0)
					{
						num = 891;
						continue;
					}
					continue;
				case 615:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2Button2, Form1.Bp8crKQbU76Tg68kvQp(835315079 ^ 835312789));
					num = 605;
					continue;
				case 616:
					Form1.l8ayRqZymWsqQc7NdKi(this.guna2MessageDialog1, null);
					num = 60;
					continue;
				case 617:
					Form1.OpcykuImY77kfmRtox1(this.toggleAutoTab, new EventHandler(this.TvaEJRleMj));
					num = 878;
					continue;
				case 618:
					Form1.GaMaotCqWxchpV0yRLI(this.imageList2).SetKeyName(2, Form1.Bp8crKQbU76Tg68kvQp(-1307524010 ^ -1307510616));
					num = 447;
					continue;
				case 619:
					Form1.GtfMAhi4Efiicblyei4(this.textAddonName, "");
					num = 873;
					continue;
				case 620:
					Form1.sUSlgdhHRw1CXHlv9uV(this.comboGameVersion, new Size(241, 36));
					num = 418;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
					{
						num = 426;
						continue;
					}
					continue;
				case 621:
					this.textStatus.BackColor = Form1.Y1UIkkw4SWDmFnSC63U(60, 60, 60);
					num = 576;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
					{
						num = 591;
						continue;
					}
					continue;
				case 622:
					Form1.JBnCqRhMbY6dWf5nXZF(this.tabSettings, new Padding(0));
					num = 925;
					continue;
				case 623:
					Form1.KWXkJRZCQ2vp6uQLTcI(this.sharpClipboard1).All = true;
					num = 765;
					continue;
				case 624:
					this.btnStartStop.BorderRadius = 10;
					num = 196;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 != 0)
					{
						num = 509;
						continue;
					}
					continue;
				case 625:
					Form1.voYLFshjBEBI0ODwIr7(this.txtUsername, new Padding(2, 0, 2, 0));
					num = 179;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d != 0)
					{
						num = 120;
						continue;
					}
					continue;
				case 626:
					this.ColKeybind.ReadOnly = true;
					num = 458;
					continue;
				case 627:
					Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabControl2).BorderColor = Color.Empty;
					num = 695;
					continue;
				case 628:
					Form1.DIHdSHS7iP1A7KmNMB1(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button5), Form1.giuhSiS4f07IhTOwgHy());
					num = 1343;
					continue;
				case 629:
					Form1.AnC9VRIGRR3wvvwCd4a(this.DataGridSettings, 51);
					num = 364;
					continue;
				case 630:
					Form1.LHKTq0Iz7DUG2RUA0mp(Form1.NTYtH4ICbD0jWXFC4ol(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings)), new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-717857995 >> 5 ^ -22439195), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					Form1.NTYtH4ICbD0jWXFC4ol(this.DataGridSettings.ThemeStyle).ForeColor = Form1.G9eLqeSP2XWNAQfY8h5();
					num = 268;
					continue;
				case 631:
					this.guna2Button8.Animated = true;
					num = 281;
					continue;
				case 632:
					Form1.wr5o3ESO7nyo3wXgm1J(Form1.Gypb9bSfb8dfe9D7Fgg(this.btnCancelBind), Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169));
					num = 822;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
					{
						num = 1196;
						continue;
					}
					continue;
				case 633:
					this.label5 = new Label();
					num = 784;
					continue;
				case 634:
					this.textStatus.HoverState.BorderColor = Color.FromArgb(60, 60, 60);
					num = 864;
					continue;
				case 635:
					Form1.fSKvdPhXB121ntJCND9(this.guna2Button2, new Point(457, 27));
					num = 1248;
					continue;
				case 636:
					this.menuStrip1.TabIndex = 14;
					num = 1253;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea != 0)
					{
						num = 1366;
						continue;
					}
					continue;
				case 637:
					this.guna2TabControl1.ResumeLayout(false);
					num = 238;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 == 0)
					{
						num = 1132;
						continue;
					}
					continue;
				case 638:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabSettings), this.guna2TabSettings);
					num = 606;
					continue;
				case 639:
					this.textAddonRefreshRate.EndInit();
					num = 832;
					continue;
				case 640:
					Form1.OpcykuImY77kfmRtox1(this.toggleManualCastQueue, new EventHandler(this.PxaE2vArLc));
					Form1.wxMaZnI7u1L89VdGNLA(this.label6, true);
					num = 362;
					continue;
				case 641:
					this.guna2Button6 = new Guna2Button();
					num2 = 228;
					break;
				case 642:
				{
					Guna2NumericUpDown guna2NumericUpDown5 = this.textPulseFrequency;
					int[] array6 = new int[4];
					array6[0] = 10;
					guna2NumericUpDown5.Value = new decimal(array6);
					Form1.wxMaZnI7u1L89VdGNLA(this.label4, true);
					num = 450;
					continue;
				}
				case 643:
					Form1.Lg0ScKIpjNLeXbDQTVP(this.ColSettingsName, DataGridViewAutoSizeColumnMode.Fill);
					num = 701;
					continue;
				case 644:
					this.labelKeyPreview.Size = new Size(215, 41);
					num = 847;
					continue;
				case 645:
					this.label11.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1005505369 ^ -1005511526), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num2 = 319;
					break;
				case 646:
					Form1.c0iNFuhTJsEkerxoDF5(this.guna2TabControl1, new Point(0, 0));
					num = 575;
					continue;
				case 647:
					this.sharpClipboard1.Tag = null;
					num = 1028;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 != 0)
					{
						num = 657;
						continue;
					}
					continue;
				case 648:
					Form1.AQ5PKbSlGpZgbylJlqA(this.textAddonRefreshRate, Color.Transparent);
					num = 114;
					continue;
				case 649:
					this.guna2TabControl1.TabButtonIdleState.ForeColor = Color.FromArgb(100, 100, 100);
					num = 105;
					continue;
				case 650:
				{
					DataGridViewCellStyle dataGridViewCellStyle5;
					Form1.B9NkxySv08excapIeQS(dataGridViewCellStyle5, Color.FromArgb(231, 229, 255));
					num = 266;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c != 0)
					{
						num = 86;
						continue;
					}
					continue;
				}
				case 651:
					Form1.Scmd91ZfPmDHvRhwdPD(this, new FormClosingEventHandler(this.oBeE6By6hS));
					num = 1215;
					continue;
				case 652:
					Form1.sUSlgdhHRw1CXHlv9uV(this.textStatus, new Size(593, 43));
					num = 452;
					continue;
				case 653:
					this.tabAccount.Margin = new Padding(2);
					num = 1131;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 != 0)
					{
						num = 206;
						continue;
					}
					continue;
				case 654:
					this.textStatus.Margin = new Padding(2);
					num = 455;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num = 376;
						continue;
					}
					continue;
				case 655:
					Form1.rMNt2hhkQfYxahtLlNM(this.guna2TabSettings.TabButtonIdleState, Form1.Y1UIkkw4SWDmFnSC63U(224, 224, 224));
					Form1.b93ptlhlJQMfCjQWJts(Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabSettings), Color.Empty);
					num = 20;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
					{
						num = 70;
						continue;
					}
					continue;
				case 656:
					this.guna2ControlBox1 = new Guna2ControlBox();
					num = 90;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e == 0)
					{
						num = 1258;
						continue;
					}
					continue;
				case 657:
				{
					DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
					num = 1313;
					continue;
				}
				case 658:
					this.label3.TabIndex = 10;
					num = 283;
					continue;
				case 659:
					Form1.AQ5PKbSlGpZgbylJlqA(this.btnStartStop, Form1.HWi2GWSiSnTprngPudf());
					num2 = 729;
					break;
				case 660:
					this.btnReGenerateAddon.Location = new Point(570, 5);
					num = 82;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba != 0)
					{
						num = 135;
						continue;
					}
					continue;
				case 661:
					Form1.BYULIGhFpBJPZrMGUKF(this.contextMenuShowMacro, Form1.Bp8crKQbU76Tg68kvQp(~744818537 ^ -744827562));
					num = 1152;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
					{
						num = 1098;
						continue;
					}
					continue;
				case 662:
					this.ColSettingsName.ReadOnly = true;
					num = 589;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2a54bde8cc7e419395a5bfe6af1796c0 != 0)
					{
						num = 304;
						continue;
					}
					continue;
				case 663:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button2, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-283366293 ^ -283372219));
					num2 = 287;
					break;
				case 664:
					this.guna2Button8.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
					num = 467;
					continue;
				case 665:
					Form1.TEkSI5i126jFtHpxr4P(Form1.Jlq43diUhDdv5DIhVjg(this.textAddonName), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					num = 432;
					continue;
				case 666:
					this.guna2ProgressIndicator1.UseTransparentBackground = true;
					Form1.PMxUPdSrxvVlWwnXnBc(this.btnCancelBind, true);
					num = 816;
					continue;
				case 667:
					this.label1.Text = Form1.Bp8crKQbU76Tg68kvQp(1681481889 ^ 1681480137);
					num = 948;
					continue;
				case 668:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2Button4, new Size(133, 36));
					num = 1267;
					continue;
				case 669:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabKeybinds).Add(this.guna2GradientPanel3);
					num = 929;
					continue;
				case 670:
					Form1.F8DDPrC4dhV11PnsIC6(this.btnStartStop, new Font(Form1.Bp8crKQbU76Tg68kvQp(1881006439 >> 3 ^ 235115536), 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 557;
					continue;
				case 671:
					Form1.c0T4oUhzseliJt6JbSj(this.toggleAttackOutOfCombat, 26);
					num = 903;
					continue;
				case 672:
					Form1.Ejey22SwIyfvnrggGSM(this.toolStripMenuItemShowMacro, new EventHandler(this.S17EP91CD7));
					num = 201;
					continue;
				case 673:
					Form1.nZesEQIFV9dQquxGUD5(this.ColIcon, 40);
					num = 713;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 != 0)
					{
						num = 1145;
						continue;
					}
					continue;
				case 674:
					Form1.FMmXXUSCJBZ0ICUrYk0(this.loadSelectedToolStripMenuItem, new Size(76, 24));
					num = 932;
					continue;
				case 675:
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabPage2.Controls, this.guna2Button3);
					num = 154;
					continue;
				case 676:
					Form1.c0T4oUhzseliJt6JbSj(this.btnCancelBind, 4);
					num = 1362;
					continue;
				case 677:
					Form1.rNXejGSp5vN1fxhySyd(Form1.Gypb9bSfb8dfe9D7Fgg(this.btnReGenerateAddon), Form1.giuhSiS4f07IhTOwgHy());
					num = 383;
					continue;
				case 678:
					this.label15 = new Label();
					num = 828;
					continue;
				case 679:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.label4, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 823;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
					{
						num = 933;
						continue;
					}
					continue;
				case 680:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2TabSettings), this.tabPage5);
					num = 762;
					continue;
				case 681:
					Form1.GOQ6mliZ99yg9aWmiSk(this.txtLicenseExpiry.DisabledState, Color.FromArgb(138, 138, 138));
					num = 78;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
					{
						num = 291;
						continue;
					}
					continue;
				case 682:
					this.guna2ComboBox1.Items.AddRange(new object[]
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1657226489 - -588572257 ^ -2049172342),
						Form1.Bp8crKQbU76Tg68kvQp(289037427 >> 1 ^ 144513499),
						Form1.Bp8crKQbU76Tg68kvQp(152750669 ^ 152763811),
						Form1.Bp8crKQbU76Tg68kvQp(-87166655 + -2142521002 ^ 2065276271),
						Form1.Bp8crKQbU76Tg68kvQp(-865714864 ^ -865729190),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(212924216 ^ 212913934),
						Form1.Bp8crKQbU76Tg68kvQp(-1860104403 ^ -1860094105),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1765342390 ^ 1765328104),
						Form1.Bp8crKQbU76Tg68kvQp(-283366293 ^ -283372517)
					});
					num = 810;
					continue;
				case 683:
					Form1.IxeeAFI56iP6msjRr8x(this.DataGridSettings.ThemeStyle).SelectionForeColor = Color.Empty;
					num2 = 494;
					break;
				case 684:
					this.label9.Size = new Size(92, 20);
					num = 1143;
					continue;
				case 685:
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					Form1.uBn3qVIshudVq1FlrYJ(this.DataGridSettings, dataGridViewCellStyle);
					num = 1290;
					continue;
				}
				case 686:
					Form1.AQ5PKbSlGpZgbylJlqA(this.txtLicenseExpiry, Form1.HWi2GWSiSnTprngPudf());
					this.txtLicenseExpiry.BorderRadius = 5;
					num = 416;
					continue;
				case 687:
					this.toggleAttackTargetNotInCombat = new Guna2ToggleSwitch();
					num = 552;
					continue;
				case 688:
					Form1.KpJINqSqH6xqYtcPTR3(this.listView1, new KeyEventHandler(this.jBrPUjKb0L));
					this.listView1.KeyPress += this.SLOPZM2P2W;
					num = 945;
					continue;
				case 689:
					this.guna2GradientPanel1.Location = new Point(0, 0);
					num2 = 6;
					break;
				case 690:
					this.webView21.WebMessageReceived += this.lylE711fuA;
					num2 = 320;
					break;
				case 691:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabKeybinds, true);
					num = 51;
					continue;
				case 692:
					this.guna2GradientPanel1 = new Guna2GradientPanel();
					num = 642;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 == 0)
					{
						num = 656;
						continue;
					}
					continue;
				case 693:
					this.label12.Click += this.pgQEBUuSJP;
					num = 344;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 != 0)
					{
						num = 497;
						continue;
					}
					continue;
				case 694:
					Form1.BYULIGhFpBJPZrMGUKF(this.label2, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1551733089 >> 2 ^ 387931314));
					num = 482;
					continue;
				case 695:
					Form1.wn4MVbhaDtLVWnT24Xb(Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabControl2), Form1.pd7LrbAfTlIgHjZelLV());
					num = 173;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e != 0)
					{
						num = 242;
						continue;
					}
					continue;
				case 696:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2GradientPanel3, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1388170447 ^ -1388175885));
					num = 1048;
					continue;
				case 697:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabPage1);
					Form1.ts5qOphSdFeFDL1nGkF(this.DataGridSettings);
					num = 400;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
					{
						num = 1340;
						continue;
					}
					continue;
				case 698:
					Form1.rMNt2hhkQfYxahtLlNM(this.guna2TabControl1.TabButtonHoverState, Color.Gray);
					num = 371;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 != 0)
					{
						num = 751;
						continue;
					}
					continue;
				case 699:
					this.contextMenuShowMacro = new ContextMenuStrip(this.components);
					num = 1199;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
					{
						num = 620;
						continue;
					}
					continue;
				case 700:
					Form1.paCfMOIyGFSfS1fATPZ(Form1.IxeeAFI56iP6msjRr8x(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), Color.Empty);
					num2 = 867;
					break;
				case 701:
				{
					DataGridViewCellStyle dataGridViewCellStyle8;
					Form1.WokGlvITygHmuJPTud4(dataGridViewCellStyle8, new Padding(5, 0, 0, 0));
					num = 1210;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 != 0)
					{
						num = 224;
						continue;
					}
					continue;
				}
				case 702:
					this.tabAccount.TabIndex = 3;
					num = 1272;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea == 0)
					{
						num = 677;
						continue;
					}
					continue;
				case 703:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label15, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1379737334 ^ 1231131185 ^ -459061783));
					num = 193;
					continue;
				case 704:
					Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabControl2).BorderColor = Color.Empty;
					num = 711;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba != 0)
					{
						num = 250;
						continue;
					}
					continue;
				case 705:
					Form1.BYULIGhFpBJPZrMGUKF(this.toggleManualCastQueue, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1224731037 ^ -1224727923));
					num = 712;
					continue;
				case 706:
					Form1.sUSlgdhHRw1CXHlv9uV(this.tabPage5, new Size(723, 382));
					num = 490;
					continue;
				case 707:
					Form1.oTjtXbZIIoS4LWlsrED(this.toolTip1, 20);
					num = 829;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab != 0)
					{
						num = 357;
						continue;
					}
					continue;
				case 708:
					Form1.MBxdu8iw8gTc2lKiMol(this.comboKeyboard, new EventHandler(this.KP5E133DDE));
					num = 1214;
					continue;
				case 709:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2TabControl1, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1003780849 ^ -1003770573), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 187;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 != 0)
					{
						num = 256;
						continue;
					}
					continue;
				case 710:
					this.label11.AutoSize = true;
					num = 645;
					continue;
				case 711:
					Form1.wn4MVbhaDtLVWnT24Xb(Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabControl2), Form1.pd7LrbAfTlIgHjZelLV());
					num = 213;
					continue;
				case 712:
					this.toggleManualCastQueue.Size = new Size(41, 23);
					num = 774;
					continue;
				case 713:
					this.guna2GradientPanel3 = new Guna2GradientPanel();
					num = 265;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 == 0)
					{
						num = 1066;
						continue;
					}
					continue;
				case 714:
					Form1.jWG6fiIvV7ToNrN8jql(this.DataGridSettings.ThemeStyle.HeaderStyle, DataGridViewColumnHeadersHeightSizeMode.DisableResizing);
					Form1.L8MkK2IQffWUKgICJNj(Form1.pGgBCJIdLumlibNFUV8(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings)), 30);
					num = 335;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
					{
						num = 938;
						continue;
					}
					continue;
				case 715:
					this.ColType.HeaderText = Form1.Bp8crKQbU76Tg68kvQp(-1224731037 ^ -1224721433);
					num = 498;
					continue;
				case 716:
					this.guna2Button6.Size = new Size(170, 42);
					num = 456;
					continue;
				case 717:
					Form1.xq58MxSWykoPsdPyBfR(this.webView21, 1.0);
					num = 358;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
					{
						num = 970;
						continue;
					}
					continue;
				case 718:
					Form1.qBhlhiIlRfXyLrXRVfV(this.ColName, true);
					num2 = 162;
					break;
				case 719:
					this.PanelKeyBind.FillColor = Form1.KmbavbSejbEltY0hQn0();
					this.PanelKeyBind.Location = new Point(28, 93);
					num = 66;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
					{
						num = 461;
						continue;
					}
					continue;
				case 720:
					Form1.fSKvdPhXB121ntJCND9(this.label3, new Point(11, 196));
					num = 324;
					continue;
				case 721:
					Form1.jYIvwlSFeUP8EP4RD48(this.guna2Button9.DisabledState, Form1.Y1UIkkw4SWDmFnSC63U(141, 141, 141));
					num2 = 1285;
					break;
				case 722:
					this.DataGridSpell.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					num = 790;
					continue;
				case 723:
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					Form1.gFnm6BIteqtbpYI3Km4(dataGridViewCellStyle, Color.FromArgb(71, 69, 94));
					Form1.sHSPBYSXYHPhTAgWo8a(dataGridViewCellStyle, DataGridViewTriState.False);
					num = 222;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea != 0)
					{
						num = 685;
						continue;
					}
					continue;
				}
				case 724:
					Form1.m07tEyiqJ14uAJStg1D(this.comboPixelLocation, 5);
					num = 262;
					continue;
				case 725:
					this.btnCancelBind.BorderRadius = 5;
					num = 103;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 == 0)
					{
						num = 145;
						continue;
					}
					continue;
				case 726:
					Form1.sUSlgdhHRw1CXHlv9uV(this.textAddonRefreshRate, new Size(152, 35));
					num = 1078;
					continue;
				case 727:
					Form1.bnrr8uiplYjGFY5NtLt(this.textGameFolder, '\0');
					num = 789;
					continue;
				case 728:
					Form1.scPSmFihKgRV47xXFZQ(this.guna2ComboBox1, 0);
					num = 555;
					continue;
				case 729:
					this.btnStartStop.BorderColor = Color.Silver;
					num = 624;
					continue;
				case 730:
					Form1.MKQJJgSKWytIG94Qcm4(this.PanelKeyBind, 1);
					num = 1127;
					continue;
				case 731:
					Form1.z9Mdc3SQmvCHbuhnA9j(this.removeScriptToolStripMenuItem, Form1.tKulMWShFC9ddfy5ena());
					num = 706;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab == 0)
					{
						num = 1075;
						continue;
					}
					continue;
				case 732:
					this.PanelKeyBind.Visible = false;
					num = 1043;
					continue;
				case 733:
					this.DataGridSettings.AllowUserToDeleteRows = false;
					num = 470;
					continue;
				case 734:
					this.label7.Margin = new Padding(2, 0, 2, 0);
					num = 843;
					continue;
				case 735:
					Form1.aAPe6rZxwU6t38Vswk4(this.btnStartStop).BorderRadius = 10;
					num = 991;
					continue;
				case 736:
					this.comboKeyboard = new Guna2ComboBox();
					num = 158;
					continue;
				case 737:
					Form1.gBFD6UiIE14syZ5nRUZ(this.textAddonName).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(208, 208, 208);
					Form1.gBFD6UiIE14syZ5nRUZ(this.textAddonName).FillColor = Form1.Y1UIkkw4SWDmFnSC63U(226, 226, 226);
					num = 1123;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea == 0)
					{
						num = 812;
						continue;
					}
					continue;
				case 738:
					Form1.OmMH5wINnsrGWBpyo6n(this.toggleManualCastQueue.UncheckedState, Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 345;
					break;
				case 739:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.tabPage4, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 236;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
					{
						num = 46;
						continue;
					}
					continue;
				case 740:
					Form1.wr5o3ESO7nyo3wXgm1J(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button2), Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169));
					num2 = 479;
					break;
				case 741:
					Form1.twywWuI6kMlWTtwfxxc(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleManualCastQueue), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					Form1.OmMH5wINnsrGWBpyo6n(this.toggleManualCastQueue.CheckedState, Form1.pd7LrbAfTlIgHjZelLV());
					num = 995;
					continue;
				case 742:
					Form1.uTiOQBIXIYQh2Byxyr4(this.DataGridSettings, false);
					num = 840;
					continue;
				case 743:
					this.tabAccount.ResumeLayout(false);
					num2 = 585;
					break;
				case 744:
					Form1.Rl1RQKID8eZtBFjhyyR(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings).AlternatingRowsStyle, Form1.pd7LrbAfTlIgHjZelLV());
					Form1.IxeeAFI56iP6msjRr8x(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings)).Font = null;
					num2 = 1282;
					break;
				case 745:
					this.label1.AutoSize = true;
					num = 414;
					continue;
				case 746:
					Form1.F8DDPrC4dhV11PnsIC6(this.textConsole, new Font(Form1.Bp8crKQbU76Tg68kvQp(2040894867 + -686633457 ^ 1354256356), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 1042;
					continue;
				case 747:
					Form1.pO88tISAdsdR80aCRiT(this.addScriptToolStripMenuItem, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~344187374 ^ -344181719));
					num = 909;
					continue;
				case 748:
					Form1.JBnCqRhMbY6dWf5nXZF(this.guna2Button4, new Padding(2, 2, 2, 14));
					num = 935;
					continue;
				case 749:
					this.ColSettingsName = new DataGridViewTextBoxColumn();
					num = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 != 0)
					{
						num = 7;
						continue;
					}
					continue;
				case 750:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2Button8, Form1.pd7LrbAfTlIgHjZelLV());
					num = 1333;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
					{
						num = 232;
						continue;
					}
					continue;
				case 751:
					this.guna2TabControl1.TabButtonIdleState.BorderColor = Color.Empty;
					Form1.wn4MVbhaDtLVWnT24Xb(Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabControl1), Form1.Y1UIkkw4SWDmFnSC63U(218, 218, 218));
					num2 = 393;
					break;
				case 752:
					Form1.BYULIGhFpBJPZrMGUKF(this.label1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~2095831454 ^ -2095833287));
					num = 317;
					continue;
				case 753:
					Form1.pMcELVSTsaMWxAYDlvZ(this.guna2Button1, true);
					num = 250;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 != 0)
					{
						num = 98;
						continue;
					}
					continue;
				case 754:
					this.guna2GradientPanel3.Dock = DockStyle.Bottom;
					num = 872;
					continue;
				case 755:
					Form1.twywWuI6kMlWTtwfxxc(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAutoTab), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					num = 156;
					continue;
				case 756:
					Form1.RsaqC7h6uTpcoFADpiT(this.guna2TabControl2, new Size(176, 30));
					num = 1266;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 != 0)
					{
						num = 1296;
						continue;
					}
					continue;
				case 757:
					Form1.fSKvdPhXB121ntJCND9(this.btnStartStop, new Point(779, 9));
					num = 1323;
					continue;
				case 758:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
					num = 787;
					continue;
				}
				case 759:
					this.guna2TabControl1.Controls.Add(this.tabKeybinds);
					num = 425;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num = 332;
						continue;
					}
					continue;
				case 760:
					Form1.JBnCqRhMbY6dWf5nXZF(this.txtLicenseExpiry, new Padding(2));
					num = 87;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 != 0)
					{
						num = 312;
						continue;
					}
					continue;
				case 761:
				{
					DataGridViewCellStyle dataGridViewCellStyle;
					Form1.URcVOuSDSFDRM7OmWTX(dataGridViewCellStyle, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(145144672 << 4 ^ -1972658628), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 74;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
					{
						num = 202;
						continue;
					}
					continue;
				}
				case 762:
					Form1.cjbEqXhOkHto9Mpb3TF(this.guna2TabSettings.Controls, this.tabPage2);
					num = 13;
					continue;
				case 763:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabAccount), this.guna2Button8);
					num = 778;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a != 0)
					{
						num = 133;
						continue;
					}
					continue;
				case 764:
					this.DataGridSettings.MultiSelect = false;
					num = 280;
					continue;
				case 765:
					Form1.qeii3EZ92Gnjx4nu7we(Form1.KWXkJRZCQ2vp6uQLTcI(this.sharpClipboard1), false);
					num = 947;
					continue;
				case 766:
					this.tabPage5 = new TabPage();
					num = 1026;
					continue;
				case 767:
					this.comboKeyboard.ForeColor = Color.FromArgb(68, 88, 112);
					num = 777;
					continue;
				case 768:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.guna2TabControl2, false);
					num = 199;
					continue;
				case 769:
					Form1.OmMH5wINnsrGWBpyo6n(Form1.HU61GfI0Rv3AMEKtWnE(this.toggleAutoBind), Form1.pd7LrbAfTlIgHjZelLV());
					num = 24;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num = 783;
						continue;
					}
					continue;
				case 770:
					Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAttackTargetNotInCombat).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255);
					num = 559;
					continue;
				case 771:
					this.tabRotation.Margin = new Padding(0);
					num = 496;
					continue;
				case 772:
					this.guna2ControlBox1.BorderThickness = 1;
					num = 981;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a != 0)
					{
						num = 863;
						continue;
					}
					continue;
				case 773:
					Form1.wr5o3ESO7nyo3wXgm1J(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button3), Color.FromArgb(169, 169, 169));
					num = 381;
					continue;
				case 774:
					Form1.c0T4oUhzseliJt6JbSj(this.toggleManualCastQueue, 24);
					num = 1245;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 != 0)
					{
						num = 647;
						continue;
					}
					continue;
				case 775:
					Form1.pGgBCJIdLumlibNFUV8(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)).BorderStyle = DataGridViewHeaderBorderStyle.None;
					num = 985;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 != 0)
					{
						num = 203;
						continue;
					}
					continue;
				case 776:
					Form1.wmRhA7IJQPxYMOFAKt5(this.toggleAttackTargetNotInCombat.UncheckedState, Color.FromArgb(125, 137, 149));
					num = 108;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
					{
						num = 796;
						continue;
					}
					continue;
				case 777:
					Form1.NEVx6ciQWUA1CnM79yH(this.comboKeyboard, 30);
					num = 1274;
					continue;
				case 778:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabAccount).Add(this.guna2Button7);
					num = 216;
					continue;
				case 779:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabKeybinds, false);
					num = 283;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 != 0)
					{
						num = 602;
						continue;
					}
					continue;
				case 780:
					Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabSettings).FillColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 1009;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_669639b2fc7d4196b99820c1478aeb2d == 0)
					{
						num = 553;
						continue;
					}
					continue;
				case 781:
					Form1.pFoxNeSZ5YRTR9whdfW(Form1.GaMaotCqWxchpV0yRLI(this.imageList3), 1, Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463900297));
					Form1.GaMaotCqWxchpV0yRLI(this.imageList3).SetKeyName(2, Form1.Bp8crKQbU76Tg68kvQp(-1495818301 ^ -1495812929));
					num = 296;
					continue;
				case 782:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button8, new EventHandler(this.ToxEtY80GO));
					num = 1138;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
					{
						num = 950;
						continue;
					}
					continue;
				case 783:
					this.toggleAutoBind.UncheckedState.InnerColor = Color.White;
					num = 265;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a != 0)
					{
						num = 183;
						continue;
					}
					continue;
				case 784:
					this.textPulseFrequency = new Guna2NumericUpDown();
					this.label4 = new Label();
					num = 457;
					continue;
				case 785:
					Form1.Ejey22SwIyfvnrggGSM(this.editToolStripMenuItem, new EventHandler(this.WnBP1xM1Lx));
					num = 831;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
					{
						num = 684;
						continue;
					}
					continue;
				case 786:
					Form1.wxMaZnI7u1L89VdGNLA(this.label2, true);
					num = 375;
					continue;
				case 787:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					Form1.IWMBi6AOVaRiLvC0OqM(dataGridViewCellStyle2, Color.FromArgb(76, 132, 255));
					num = 362;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
					{
						num = 378;
						continue;
					}
					continue;
				}
				case 788:
					Form1.pFoxNeSZ5YRTR9whdfW(this.imageList3.Images, 6, Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374425992));
					num = 177;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
					{
						num = 248;
						continue;
					}
					continue;
				case 789:
					this.textGameFolder.PlaceholderText = "";
					num = 103;
					continue;
				case 790:
					Form1.QEHe5jIW3kjEoOObLPC(this.DataGridSpell, false);
					num = 1179;
					continue;
				case 791:
					Form1.FMmXXUSCJBZ0ICUrYk0(this.editToolStripMenuItem, new Size(69, 24));
					num2 = 342;
					break;
				case 792:
					Form1.wOWaSEhUFckT1vLaok7(this.guna2BorderlessForm1, false);
					num = 1111;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 == 0)
					{
						num = 974;
						continue;
					}
					continue;
				case 793:
					this.textAddonName.Padding = new Padding(2, 0, 2, 0);
					num = 1074;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num = 300;
						continue;
					}
					continue;
				case 794:
				{
					DataGridViewCellStyle dataGridViewCellStyle4;
					Form1.IWMBi6AOVaRiLvC0OqM(dataGridViewCellStyle4, Color.White);
					num = 277;
					continue;
				}
				case 795:
					Form1.fSKvdPhXB121ntJCND9(this.toggleAutoTab, new Point(12, 171));
					num = 1004;
					continue;
				case 796:
					Form1.twywWuI6kMlWTtwfxxc(this.toggleAttackTargetNotInCombat.UncheckedState, Color.FromArgb(125, 137, 149));
					num = 38;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
					{
						num = 45;
						continue;
					}
					continue;
				case 797:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.btnReGenerateAddon, Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 660;
					break;
				case 798:
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabPage2.Controls, this.textAddonName);
					num2 = 438;
					break;
				case 799:
					Form1.PMxUPdSrxvVlWwnXnBc(this.guna2Button3, true);
					num = 579;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
					{
						num = 256;
						continue;
					}
					continue;
				case 800:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabPage1, false);
					this.DataGridSettings.EndInit();
					num = 1080;
					continue;
				case 801:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2GradientPanel3), this.btnReGenerateAddon);
					num = 196;
					continue;
				case 802:
					this.label7.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(~344187374 ^ -344181203), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 42;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
					{
						num = 448;
						continue;
					}
					continue;
				case 803:
					this.guna2GradientPanel2.FillColor2 = Color.FromArgb(60, 60, 60);
					num2 = 532;
					break;
				case 804:
					this.guna2TabControl1.TabIndex = 6;
					num = 422;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
					{
						num = 431;
						continue;
					}
					continue;
				case 805:
					Form1.IdQ3l0iTV65Ufl1oFyW(this.txtUsername, 5);
					num = 942;
					continue;
				case 806:
					Form1.HbkIbNIuh8Zmqq7AKE1(Form1.IxeeAFI56iP6msjRr8x(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), Color.Empty);
					num = 1056;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 == 0)
					{
						num = 839;
						continue;
					}
					continue;
				case 807:
					this.label10 = new Label();
					num = 959;
					continue;
				case 808:
					Form1.SRjnkfSkHA1Z9aBxE8R(this.PanelKeyBind, true);
					num = 732;
					continue;
				case 809:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage4), this.listView1);
					num = 1364;
					continue;
				case 810:
					this.guna2ComboBox1.Location = new Point(11, 215);
					num = 409;
					continue;
				case 811:
					Form1.TPKNrkZQIIv0BEhtcQb(this.timer1, new EventHandler(this.I24ELh0UQR));
					num = 987;
					continue;
				case 812:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					Form1.Rer5dAStiGn1xeOjxdw(dataGridViewCellStyle3, DataGridViewContentAlignment.MiddleLeft);
					num = 571;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd == 0)
					{
						num = 0;
						continue;
					}
					continue;
				}
				case 813:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabRotation), this.guna2TabControl2);
					num2 = 1149;
					break;
				case 814:
					this.tabPage3 = new TabPage();
					num = 608;
					continue;
				case 815:
					Form1.UKbNgvhKj1KrPfkYk1l(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl2), new Font(Form1.Bp8crKQbU76Tg68kvQp(-160910942 << 4 ^ 1720398364), 9f));
					num = 842;
					continue;
				case 816:
					this.btnCancelBind.BackColor = Form1.HWi2GWSiSnTprngPudf();
					num = 725;
					continue;
				case 817:
					this.label4.Text = Form1.Bp8crKQbU76Tg68kvQp(-1007749927 ^ -1007763185);
					num = 648;
					continue;
				case 818:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button8, 19);
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button8, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789419076 ^ -35552607 ^ 756273407));
					num = 782;
					continue;
				case 819:
					this.PanelKeyBind.Controls.Add(this.btnCancelBind);
					num = 371;
					continue;
				case 820:
					this.imageList3 = new ImageList(this.components);
					num = 330;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 != 0)
					{
						num = 218;
						continue;
					}
					continue;
				case 821:
					Form1.hdgSGoIH5MU8ZqAJQQV(this.DataGridSettings, Form1.pd7LrbAfTlIgHjZelLV());
					this.DataGridSettings.BorderStyle = BorderStyle.None;
					num2 = 1023;
					break;
				case 822:
					Form1.AQ5PKbSlGpZgbylJlqA(this.guna2PictureBox1, Form1.HWi2GWSiSnTprngPudf());
					num = 66;
					continue;
				case 823:
					Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl2).BorderColor = Color.Empty;
					num = 293;
					continue;
				case 824:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.label16, Form1.G9eLqeSP2XWNAQfY8h5());
					num = 115;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
					{
						num = 1232;
						continue;
					}
					continue;
				case 825:
					this.txtLicenseExpiry.PlaceholderText = "";
					num = 1141;
					continue;
				case 826:
					Form1.BYULIGhFpBJPZrMGUKF(this.textAddonRefreshRate, Form1.Bp8crKQbU76Tg68kvQp(1810931007 ^ 1810934583));
					num2 = 726;
					break;
				case 827:
					Form1.xwCl3nZuD0aj5Q7mMpW(this.btnStartStop, true);
					num2 = 885;
					break;
				case 828:
					this.guna2Button4 = new Guna2Button();
					num = 860;
					continue;
				case 829:
					this.comboGameVersion.BackColor = Form1.HWi2GWSiSnTprngPudf();
					num2 = 254;
					break;
				case 830:
					Form1.voYLFshjBEBI0ODwIr7(this.tabPage1, new Padding(2));
					this.tabPage1.Size = new Size(723, 382);
					num = 101;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 != 0)
					{
						num = 76;
						continue;
					}
					continue;
				case 831:
					this.imageList3.ImageStream = (ImageListStreamer)Form1.hAZMV0SINDD87NABFkp(componentResourceManager, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1308721404 ^ 1308732414));
					num = 118;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
					{
						num = 311;
						continue;
					}
					continue;
				case 832:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabPage2, false);
					num = 524;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba == 0)
					{
						num = 118;
						continue;
					}
					continue;
				case 833:
					Form1.dfY6Z2hb6gnKZv6QTdm(this.webView21, true);
					num = 499;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
					{
						num = 593;
						continue;
					}
					continue;
				case 834:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5).Add(this.textPreCast);
					num2 = 1249;
					break;
				case 835:
					this.guna2Button1 = new Guna2Button();
					num = 260;
					continue;
				case 836:
					Form1.U3XM2Qhm2XM60XWh7EK(this.tabPage3, new Point(4, 34));
					num = 600;
					continue;
				case 837:
					this.tabAccount.Controls.Add(this.txtLicenseExpiry);
					num2 = 17;
					break;
				case 838:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button7, new EventHandler(this.foWElCNBCW));
					num = 44;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e != 0)
					{
						num = 4;
						continue;
					}
					continue;
				case 839:
					Form1.ts5qOphSdFeFDL1nGkF(this.guna2PictureBox1);
					num = 459;
					continue;
				case 840:
					Form1.vJ6cNnSjslYmMsSaLt1(this.DataGridSettings, Form1.Y1UIkkw4SWDmFnSC63U(231, 229, 255));
					num = 1055;
					continue;
				case 841:
					this.tabPage2.Controls.Add(this.label15);
					num = 264;
					continue;
				case 842:
					Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl2).ForeColor = Form1.D20T76hGKJkfHDfFXfT();
					Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl2).InnerColor = Form1.wOp4nxhB3jetdEd5vg5();
					num = 303;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
					{
						num = 627;
						continue;
					}
					continue;
				case 843:
					this.label7.Name = Form1.Bp8crKQbU76Tg68kvQp(~1053049764 ^ -1053062153);
					this.label7.Size = new Size(76, 20);
					Form1.c0T4oUhzseliJt6JbSj(this.label7, 18);
					num = 1126;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
					{
						num = 838;
						continue;
					}
					continue;
				case 844:
					Form1.JBnCqRhMbY6dWf5nXZF(this.guna2TabControl2, new Padding(2));
					num = 231;
					continue;
				case 845:
					Form1.fSKvdPhXB121ntJCND9(this.comboGameVersion, new Point(279, 215));
					num = 1291;
					continue;
				case 846:
					this.guna2Button7.Size = new Size(164, 42);
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button7, 18);
					num = 26;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e != 0)
					{
						num = 4;
						continue;
					}
					continue;
				case 847:
					this.labelKeyPreview.TabIndex = 3;
					this.labelKeyPreview.Text = Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463898795);
					num2 = 554;
					break;
				case 848:
					Form1.DIHdSHS7iP1A7KmNMB1(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button3), Form1.giuhSiS4f07IhTOwgHy());
					num = 773;
					continue;
				case 849:
					this.label16.AutoSize = true;
					num = 1169;
					continue;
				case 850:
					this.statusIcon.Size = new Size(33, 32);
					num = 514;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
					{
						num = 449;
						continue;
					}
					continue;
				case 851:
					this.ColKeybind.MinimumWidth = 6;
					this.ColKeybind.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2090212177 ^ 2090210111);
					num = 626;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num = 94;
						continue;
					}
					continue;
				case 852:
					Form1.tRMKuWiiLgmaY6xGY7v(Form1.gBFD6UiIE14syZ5nRUZ(this.txtLicenseExpiry), Form1.Y1UIkkw4SWDmFnSC63U(138, 138, 138));
					num = 681;
					continue;
				case 853:
					this.toolTip1.IsBalloon = true;
					num = 707;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa != 0)
					{
						num = 405;
						continue;
					}
					continue;
				case 854:
					Form1.BYULIGhFpBJPZrMGUKF(this.label10, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(457652205 ^ 457641253));
					num = 442;
					continue;
				case 855:
					Form1.BYULIGhFpBJPZrMGUKF(this.label3, Form1.Bp8crKQbU76Tg68kvQp(-1008853611 >> 6 ^ -15777580));
					num2 = 990;
					break;
				case 856:
					this.label14 = new Label();
					num = 180;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
					{
						num = 339;
						continue;
					}
					continue;
				case 857:
					Form1.BYPHtuS5OYTilSPEolI(this.listView1, false);
					num2 = 421;
					break;
				case 858:
					this.imageList2.TransparentColor = Form1.HWi2GWSiSnTprngPudf();
					Form1.GaMaotCqWxchpV0yRLI(this.imageList2).SetKeyName(0, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789527058));
					num = 203;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
					{
						num = 475;
						continue;
					}
					continue;
				case 859:
					Form1.TEkSI5i126jFtHpxr4P(this.textAddonName.HoverState, Color.FromArgb(94, 148, 255));
					Form1.fSKvdPhXB121ntJCND9(this.textAddonName, new Point(11, 90));
					num2 = 347;
					break;
				case 860:
					this.guna2Button3 = new Guna2Button();
					num = 736;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 != 0)
					{
						num = 316;
						continue;
					}
					continue;
				case 861:
					Form1.pFoxNeSZ5YRTR9whdfW(Form1.GaMaotCqWxchpV0yRLI(this.imageList3), 0, Form1.Bp8crKQbU76Tg68kvQp(-185008287 ^ -185019309));
					num = 781;
					continue;
				case 862:
					Form1.sUSlgdhHRw1CXHlv9uV(this.toggleAttackTargetNotInCombat, new Size(41, 23));
					num = 899;
					continue;
				case 863:
					Form1.Fb8UmLiRlpCh8WUG8v0(Form1.gBFD6UiIE14syZ5nRUZ(this.textStatus), Form1.Y1UIkkw4SWDmFnSC63U(226, 226, 226));
					Form1.tRMKuWiiLgmaY6xGY7v(Form1.gBFD6UiIE14syZ5nRUZ(this.textStatus), Form1.Y1UIkkw4SWDmFnSC63U(138, 138, 138));
					Form1.GOQ6mliZ99yg9aWmiSk(Form1.gBFD6UiIE14syZ5nRUZ(this.textStatus), Form1.Y1UIkkw4SWDmFnSC63U(138, 138, 138));
					Form1.bF72MSiemya99sOoryl(this.textStatus, Color.FromArgb(60, 60, 60));
					num = 179;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
					{
						num = 1293;
						continue;
					}
					continue;
				case 864:
					Form1.wgvdrvZPNCOcP3CZ17u(this.textStatus, new Size(32, 32));
					num = 1092;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 881;
						continue;
					}
					continue;
				case 865:
					Form1.rNH3WfhJCd14ZcstGLE(this.tabRotation, 0);
					num = 997;
					continue;
				case 866:
					Form1.wMMuMWiaRiJ3MryRMFB(this.txtUsername, "");
					num = 1283;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
					{
						num = 134;
						continue;
					}
					continue;
				case 867:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell).BackColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 361;
					continue;
				case 868:
					this.DataGridSettings.CellMouseEnter += this.Ww0Encmx5U;
					num = 58;
					continue;
				case 869:
					this.textConsole.BorderStyle = BorderStyle.None;
					num = 449;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
					{
						num = 530;
						continue;
					}
					continue;
				case 870:
					Form1.OmMH5wINnsrGWBpyo6n(this.toggleAutoBind.CheckedState, Color.White);
					num = 181;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 == 0)
					{
						num = 209;
						continue;
					}
					continue;
				case 871:
					Form1.H46hiSSL9IXx2IUG475(this.textConsole, ScrollBars.Vertical);
					Form1.sUSlgdhHRw1CXHlv9uV(this.textConsole, new Size(731, 420));
					num = 757;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
					{
						num = 974;
						continue;
					}
					continue;
				case 872:
					Form1.CHP8NWIk4DVxW1wS7KP(this.guna2GradientPanel3, Form1.Y1UIkkw4SWDmFnSC63U(224, 224, 224));
					Form1.fSKvdPhXB121ntJCND9(this.guna2GradientPanel3, new Point(0, 378));
					num = 304;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 == 0)
					{
						num = 696;
						continue;
					}
					continue;
				case 873:
					Form1.kAoHyLiOcqbsYb6GYdV(this.textAddonName, "");
					num = 171;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 != 0)
					{
						num = 1342;
						continue;
					}
					continue;
				case 874:
					this.tabPage4.Margin = new Padding(2);
					num = 258;
					continue;
				case 875:
					this.toolTip1.SetToolTip(this.label12, Form1.Bp8crKQbU76Tg68kvQp(457652205 ^ 457639539));
					num = 693;
					continue;
				case 876:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2PictureBox1, new Size(224, 48));
					Form1.sCe17XiYW9iTPSTjkEk(this.guna2PictureBox1, PictureBoxSizeMode.StretchImage);
					num = 1081;
					continue;
				case 877:
					Form1.MBxdu8iw8gTc2lKiMol(this.comboPixelLocation, new EventHandler(this.bI8EMuHWqG));
					num = 17;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 == 0)
					{
						num = 18;
						continue;
					}
					continue;
				case 878:
					Form1.wxMaZnI7u1L89VdGNLA(this.label12, true);
					num = 62;
					continue;
				case 879:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings).HeaderStyle.ForeColor = Color.White;
					num = 714;
					continue;
				case 880:
					this.DataGridSpell.BackgroundColor = Color.White;
					num = 1118;
					continue;
				case 881:
					Form1.BelJUdIfWaaWNT5ivWk(this.ColSettingsName, Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553732463));
					num = 662;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
					{
						num = 215;
						continue;
					}
					continue;
				case 882:
					this.toolTip1.InitialDelay = 100;
					num = 853;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num = 214;
						continue;
					}
					continue;
				case 883:
					Form1.JBnCqRhMbY6dWf5nXZF(this.statusIcon, new Padding(2));
					this.statusIcon.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1858354135 - 1114350030 ^ 744007257);
					num2 = 850;
					break;
				case 884:
					this.txtLicenseType.TabIndex = 13;
					num = 463;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 != 0)
					{
						num = 349;
						continue;
					}
					continue;
				case 885:
					this.btnStartStop.Click += this.WoPPyq4IqG;
					Form1.FO7CTrZVy9iq7i2SVpZ(this.guna2MessageDialog1, 0);
					num = 616;
					continue;
				case 886:
					Form1.sUSlgdhHRw1CXHlv9uV(this.textGameFolder, new Size(441, 33));
					num = 476;
					continue;
				case 887:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2ProgressIndicator1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1157945476 >> 1 ^ 578961542));
					num = 1133;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 == 0)
					{
						num = 964;
						continue;
					}
					continue;
				case 888:
					Form1.cjbEqXhOkHto9Mpb3TF(base.Controls, this.guna2GradientPanel1);
					num = 522;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a != 0)
					{
						num = 375;
						continue;
					}
					continue;
				case 889:
					Form1.sUSlgdhHRw1CXHlv9uV(this.tabPage2, new Size(723, 382));
					num = 442;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
					{
						num = 1213;
						continue;
					}
					continue;
				case 890:
					this.guna2PictureBox1.Name = Form1.Bp8crKQbU76Tg68kvQp(790722942 ^ 790709628);
					num = 71;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
					{
						num = 876;
						continue;
					}
					continue;
				case 891:
					Form1.rAerOJSBbLMmf4J5KMd(Form1.jCAxm7wM3ZGPkj7Rpmx(this.DataGridSettings), new DataGridViewColumn[]
					{
						this.ColSettingsName,
						this.ColSettingsValue
					});
					num = 182;
					continue;
				case 892:
					Form1.AwaROtiFKjpY0D2Lhkk(this.textGameFolder, new EventHandler(this.tZWPpV6nDf));
					num = 481;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
					{
						num = 745;
						continue;
					}
					continue;
				case 893:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label13, new Size(128, 23));
					num = 419;
					continue;
				case 894:
					this.guna2Button2.DisabledState.BorderColor = Color.DarkGray;
					num = 1102;
					continue;
				case 895:
					Form1.JBnCqRhMbY6dWf5nXZF(this.label1, new Padding(2, 0, 2, 0));
					num = 752;
					continue;
				case 896:
					Form1.aoeEisiBjPmBWjmPoeZ(this.statusIcon, false);
					num2 = 580;
					break;
				case 897:
					Form1.dvBRlGIhy56hFVtjNLt(Form1.NTYtH4ICbD0jWXFC4ol(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), Form1.Y1UIkkw4SWDmFnSC63U(71, 69, 94));
					num2 = 385;
					break;
				case 898:
					Form1.BelJUdIfWaaWNT5ivWk(this.ColDisabled, Form1.Bp8crKQbU76Tg68kvQp(-1897624240 ^ -1897626118));
					num = 423;
					continue;
				case 899:
					Form1.c0T4oUhzseliJt6JbSj(this.toggleAttackTargetNotInCombat, 30);
					num = 776;
					continue;
				case 900:
					this.comboKeyboard.FocusedColor = Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255);
					num = 235;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
					{
						num = 337;
						continue;
					}
					continue;
				case 901:
					Form1.Fb8UmLiRlpCh8WUG8v0(this.txtUsername.DisabledState, Color.FromArgb(226, 226, 226));
					num = 1326;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 != 0)
					{
						num = 210;
						continue;
					}
					continue;
				case 902:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label16, new Size(344, 23));
					num = 604;
					continue;
				case 903:
					this.toggleAttackOutOfCombat.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
					num = 1000;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num = 187;
						continue;
					}
					continue;
				case 904:
					this.label5.AutoSize = true;
					num2 = 1241;
					break;
				case 905:
					this.textGameFolder.DisabledState.PlaceholderForeColor = Form1.Y1UIkkw4SWDmFnSC63U(138, 138, 138);
					num = 285;
					continue;
				case 906:
					this.btnCancelBind.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1005505369 ^ -1005511526), 9f);
					num = 612;
					continue;
				case 907:
					Form1.acYlSOiJcoJP0X8UbEL(Form1.Ch22WCi0tQuJvsxSHTH(this.guna2ControlBox1), true);
					num2 = 251;
					break;
				case 908:
					Form1.F8DDPrC4dhV11PnsIC6(this.label15, new Font(Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510588801), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 1265;
					continue;
				case 909:
					Form1.FMmXXUSCJBZ0ICUrYk0(this.addScriptToolStripMenuItem, new Size(71, 24));
					Form1.P5eeUsS9qDJS8JGNAGm(this.addScriptToolStripMenuItem, Form1.Bp8crKQbU76Tg68kvQp(-1520361985 >> 6 ^ -23745017));
					num = 349;
					continue;
				case 910:
					Form1.IdQ3l0iTV65Ufl1oFyW(this.textGameFolder, 5);
					num = 1090;
					continue;
				case 911:
					this.tabPage2.ImageIndex = 3;
					num = 26;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab == 0)
					{
						num = 389;
						continue;
					}
					continue;
				case 912:
					Form1.YAW99MiDY6HFI2Fbo0b(this.textStatus, true);
					num = 621;
					continue;
				case 913:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabKeybinds);
					num = 971;
					continue;
				case 914:
					Form1.OmMH5wINnsrGWBpyo6n(Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAttackTargetNotInCombat), Color.White);
					num = 573;
					continue;
				case 915:
					Form1.HjK5KFI2DSeCFHmC5pL(this.toggleAutoTab).BorderColor = Color.FromArgb(94, 148, 255);
					num = 755;
					continue;
				case 916:
					Form1.BYULIGhFpBJPZrMGUKF(this.webView21, Form1.Bp8crKQbU76Tg68kvQp(-2102188928 ^ -2102194734));
					num = 1238;
					continue;
				case 917:
				{
					DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
					num2 = 181;
					break;
				}
				case 918:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabPage2, true);
					num = 1198;
					continue;
				case 919:
					Form1.scPSmFihKgRV47xXFZQ(this.comboKeyboard, 0);
					num = 359;
					continue;
				case 920:
					Form1.qZEtwphNdGF2BbmdyPh(this.guna2TabControl1, HorizontalAlignment.Left);
					Form1.E1E0QthnssGuPPwPGp7(this.guna2TabControl1, new Point(15, 0));
					num = 804;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
					{
						num = 586;
						continue;
					}
					continue;
				case 921:
					Form1.mBAPbIiEnNpQ5yIyBrW(this.DataGridSettings, new MouseEventHandler(this.D16E86EP4x));
					num = 643;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 != 0)
					{
						num = 48;
						continue;
					}
					continue;
				case 922:
					this.guna2TabControl1.Size = new Size(919, 428);
					num = 1287;
					continue;
				case 923:
					this.textGameFolder = new Guna2TextBox();
					this.label1 = new Label();
					num = 129;
					continue;
				case 924:
					this.tabPage4.Padding = new Padding(2);
					num = 966;
					continue;
				case 925:
					Form1.BYULIGhFpBJPZrMGUKF(this.tabSettings, Form1.Bp8crKQbU76Tg68kvQp(451337338 ^ 451343258));
					num = 143;
					continue;
				case 926:
					Form1.FMmXXUSCJBZ0ICUrYk0(this.toolStripMenuItemShowMacro, new Size(170, 24));
					num = 1076;
					continue;
				case 927:
					this.DataGridSettings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
					num = 186;
					continue;
				case 928:
					Form1.tRMKuWiiLgmaY6xGY7v(this.txtLicenseType.FocusedState, Form1.Y1UIkkw4SWDmFnSC63U(64, 64, 64));
					Form1.wEyJSbCFacgSXItvROk(this.txtLicenseType, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218516579), 10f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num2 = 1312;
					break;
				case 929:
					this.tabKeybinds.ImageIndex = 2;
					num = 465;
					continue;
				case 930:
					this.addScriptToolStripMenuItem = new ToolStripMenuItem();
					num = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f6be3324a0314b2e90c5fdfd38911414 != 0)
					{
						num = 16;
						continue;
					}
					continue;
				case 931:
					this.PanelKeyBind.PerformLayout();
					num = 315;
					continue;
				case 932:
					Form1.P5eeUsS9qDJS8JGNAGm(this.loadSelectedToolStripMenuItem, Form1.Bp8crKQbU76Tg68kvQp(-1505789866 ^ -1505799558));
					num = 28;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
					{
						num = 413;
						continue;
					}
					continue;
				case 933:
					this.label4.Location = new Point(8, 10);
					this.label4.Margin = new Padding(2, 0, 2, 0);
					num = 471;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 != 0)
					{
						num = 292;
						continue;
					}
					continue;
				case 934:
					Form1.i8t5oYZA0h2Zq94fUDR(this.sharpClipboard1.ObservableFormats, false);
					num2 = 327;
					break;
				case 935:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2Button4, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(212924216 ^ 212910538));
					num = 668;
					continue;
				case 936:
					this.ColName = new DataGridViewTextBoxColumn();
					this.ColKeybind = new DataGridViewTextBoxColumn();
					num = 440;
					continue;
				case 937:
					Form1.DvTSVlIPDVXe6NjL9Ia(this.DataGridSpell, false);
					num = 1332;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
					{
						num = 1138;
						continue;
					}
					continue;
				case 938:
					Form1.TxLE6fIjE2x9ruJ0YKZ(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings), false);
					num2 = 1184;
					break;
				case 939:
					return;
				case 940:
					this.label13.Location = new Point(59, 172);
					num = 511;
					continue;
				case 941:
					Form1.c0T4oUhzseliJt6JbSj(this.toggleAutoBind, 32);
					num = 59;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 == 0)
					{
						num = 3;
						continue;
					}
					continue;
				case 942:
					Form1.bAfsNnixIiVZajHwRbB(this.txtUsername, Form1.VA4WwsiygtFFKaVPeZt());
					num = 866;
					continue;
				case 943:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2), this.comboGameVersion);
					num2 = 1051;
					break;
				case 944:
					Form1.wr5o3ESO7nyo3wXgm1J(this.guna2Button4.DisabledState, Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169));
					num = 1197;
					continue;
				case 945:
					Form1.Jjn59PSdJFuo2LP4v7L(this.columnHeader1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-940667910 + -206218605 ^ -1146892487));
					num2 = 576;
					break;
				case 946:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2ComboBox1, new Size(241, 36));
					num = 728;
					continue;
				case 947:
					Form1.GP9Tc3ZwKcmFGgSKjSl(this.sharpClipboard1.ObservableFormats, false);
					num = 934;
					continue;
				case 948:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.label1, new EventHandler(this.YD3E4VlwQP));
					num2 = 763;
					break;
				case 949:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button1, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1495818301 ^ -1495812097), 9f));
					this.guna2Button1.ForeColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 961;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 == 0)
					{
						num = 1231;
						continue;
					}
					continue;
				case 950:
					this.guna2GradientPanel3.TabIndex = 5;
					num = 1255;
					continue;
				case 951:
					Form1.wxMaZnI7u1L89VdGNLA(this.label8, true);
					num = 63;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
					{
						num = 21;
						continue;
					}
					continue;
				case 952:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabLog);
					num = 913;
					continue;
				case 953:
					Form1.sUSlgdhHRw1CXHlv9uV(this.btnStartStop, new Size(128, 43));
					num = 299;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
					{
						num = 70;
						continue;
					}
					continue;
				case 954:
					this.label5.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1860104403 ^ -1860093361);
					num = 286;
					continue;
				case 955:
					Form1.jYIvwlSFeUP8EP4RD48(this.guna2Button5.DisabledState, Form1.Y1UIkkw4SWDmFnSC63U(141, 141, 141));
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button5, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(679327912 ^ 679317652), 9f));
					num = 71;
					continue;
				case 956:
					this.guna2TabControl1.Location = new Point(0, 63);
					num2 = 1057;
					break;
				case 957:
					Form1.nga6WgheeytD1C2eoXZ(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl1), Form1.Y1UIkkw4SWDmFnSC63U(58, 58, 58));
					num = 698;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
					{
						num = 494;
						continue;
					}
					continue;
				case 958:
					this.listView1.TabIndex = 13;
					num = 1256;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
					{
						num = 1208;
						continue;
					}
					continue;
				case 959:
					this.txtLicenseType = new Guna2TextBox();
					num = 1153;
					continue;
				case 960:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabRotation, true);
					num = 59;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e != 0)
					{
						num = 1336;
						continue;
					}
					continue;
				case 961:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabPage2);
					num = 23;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
					{
						num = 78;
						continue;
					}
					continue;
				case 962:
					Form1.wn4MVbhaDtLVWnT24Xb(Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabControl1), Form1.Y1UIkkw4SWDmFnSC63U(0, 122, 159));
					num2 = 205;
					break;
				case 963:
					Form1.fSKvdPhXB121ntJCND9(this.btnCancelBind, new Point(-9, 120));
					num = 25;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 == 0)
					{
						num = 89;
						continue;
					}
					continue;
				case 964:
					Form1.j3fKIdidqWrQeM9mduN(this.guna2ComboBox1, DrawMode.OwnerDrawFixed);
					num = 1037;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 != 0)
					{
						num = 1068;
						continue;
					}
					continue;
				case 965:
					Form1.TQ7387iKhdplLvSeKQ7(this.textStatus, true);
					Form1.kAoHyLiOcqbsYb6GYdV(this.textStatus, "");
					num = 431;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
					{
						num = 652;
						continue;
					}
					continue;
				case 966:
					Form1.sUSlgdhHRw1CXHlv9uV(this.tabPage4, new Size(723, 382));
					num = 278;
					continue;
				case 967:
					this.comboPixelLocation.Size = new Size(509, 36);
					num = 1276;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 != 0)
					{
						num = 1254;
						continue;
					}
					continue;
				case 968:
					this.guna2BorderlessForm1.ContainerControl = this;
					num = 41;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9ed32793f344edc971bad365818217d == 0)
					{
						num = 607;
						continue;
					}
					continue;
				case 969:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2TabControl1), this.tabAccount);
					num = 149;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 != 0)
					{
						num = 569;
						continue;
					}
					continue;
				case 970:
					this.webView21.CoreWebView2InitializationCompleted += this.rL0Ekwd61e;
					num = 690;
					continue;
				case 971:
					Form1.NI0nbahhQrIJ1PGSqQI(this.PanelKeyBind);
					num = 1224;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be != 0)
					{
						num = 944;
						continue;
					}
					continue;
				case 972:
					Form1.sLBp4vhs8n4RKjjB6is(this.DataGridSpell, DockStyle.Fill);
					num = 1307;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 == 0)
					{
						num = 1068;
						continue;
					}
					continue;
				case 973:
					Form1.UKbNgvhKj1KrPfkYk1l(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl1), new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039284036), 10f));
					num = 957;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd == 0)
					{
						num = 234;
						continue;
					}
					continue;
				case 974:
					this.textConsole.TabIndex = 7;
					num = 177;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 != 0)
					{
						num = 101;
						continue;
					}
					continue;
				case 975:
					this.comboPixelLocation = new Guna2ComboBox();
					num2 = 678;
					break;
				case 976:
					Form1.fSKvdPhXB121ntJCND9(this.guna2GradientPanel2, new Point(0, 491));
					num = 329;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
					{
						num = 444;
						continue;
					}
					continue;
				case 977:
					Form1.wn4MVbhaDtLVWnT24Xb(this.guna2TabSettings.TabButtonHoverState, Color.White);
					num = 272;
					continue;
				case 978:
					Form1.sLBp4vhs8n4RKjjB6is(this.webView21, DockStyle.Fill);
					num = 218;
					continue;
				case 979:
					Form1.bF72MSiemya99sOoryl(this.txtLicenseType, Form1.Y1UIkkw4SWDmFnSC63U(240, 240, 240));
					Form1.TEkSI5i126jFtHpxr4P(this.txtLicenseType.FocusedState, Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					num = 675;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c == 0)
					{
						num = 928;
						continue;
					}
					continue;
				case 980:
					this.btnStartStop.FillColor = Color.FromArgb(0, 122, 159);
					num = 670;
					continue;
				case 981:
					Form1.D0PVq6inSGOc9NA41Gn(this.guna2ControlBox1, Form1.Y1UIkkw4SWDmFnSC63U(139, 152, 166));
					num = 1124;
					continue;
				case 982:
					Form1.BYULIGhFpBJPZrMGUKF(this.textGameFolder, Form1.Bp8crKQbU76Tg68kvQp(-902888658 ^ -902874602));
					num = 400;
					continue;
				case 983:
					this.textConsole.Name = Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679318728);
					num = 1018;
					continue;
				case 984:
					Form1.Y8x1VxSxRrOsTm7B7kb(this.listView1, false);
					num = 895;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
					{
						num = 1225;
						continue;
					}
					continue;
				case 985:
					Form1.SD02sxIoDCoV72J4ZU5(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell).HeaderStyle, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1797548854 ^ 1797538570), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 910;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 == 0)
					{
						num = 1194;
						continue;
					}
					continue;
				case 986:
					Form1.t8cqeBhr9tQbN9Ufa16(this.guna2TabSettings).BorderColor = Color.Empty;
					num = 780;
					continue;
				case 987:
					this.sharpClipboard1.MonitorClipboard = true;
					num = 623;
					continue;
				case 988:
					this.menuStrip1 = new MenuStrip();
					num = 1085;
					continue;
				case 989:
					Form1.eFeObWh0FiV2NaypcSU(this.tabPage2, true);
					num = 943;
					continue;
				case 990:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label3, new Size(95, 20));
					num2 = 658;
					break;
				case 991:
					Form1.acYlSOiJcoJP0X8UbEL(this.btnStartStop.ShadowDecoration, true);
					num = 595;
					continue;
				case 992:
					this.labelKeyPreview.ForeColor = Color.FromArgb(64, 64, 64);
					num2 = 1136;
					break;
				case 993:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button5, new EventHandler(this.ftfERfREJm));
					num = 686;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
					{
						num = 219;
						continue;
					}
					continue;
				case 994:
					Form1.OpcykuImY77kfmRtox1(this.toggleAttackOutOfCombat, new EventHandler(this.o30E0pYois));
					num2 = 710;
					break;
				case 995:
					Form1.HjK5KFI2DSeCFHmC5pL(this.toggleManualCastQueue).InnerColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 314;
					continue;
				case 996:
					this.txtUsername = new Guna2TextBox();
					num = 366;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e != 0)
					{
						num = 20;
						continue;
					}
					continue;
				case 997:
					Form1.U3XM2Qhm2XM60XWh7EK(this.tabRotation, new Point(184, 4));
					num = 771;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e9a32e0c5583434583e6a99f38209d4e == 0)
					{
						num = 151;
						continue;
					}
					continue;
				case 998:
					this.contextMenuShowMacro.ResumeLayout(false);
					Form1.KqEGC6ZFSRhE9SaLP4V(this.guna2GradientPanel3, false);
					num = 430;
					continue;
				case 999:
					this.ColSettingsValue.SortMode = DataGridViewColumnSortMode.NotSortable;
					num = 351;
					continue;
				case 1000:
					this.toggleAttackOutOfCombat.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
					num = 82;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num = 520;
						continue;
					}
					continue;
				case 1001:
					Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5).Add(this.toggleManualCastQueue);
					num = 198;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
					{
						num = 74;
						continue;
					}
					continue;
				case 1002:
					Form1.voYLFshjBEBI0ODwIr7(this.tabPage3, new Padding(2));
					this.tabPage3.Size = new Size(723, 382);
					num = 1137;
					continue;
				case 1003:
					Form1.MyWd6GZRsTANcsJlHcx(this.guna2PictureBox1);
					num = 1024;
					continue;
				case 1004:
					this.toggleAutoTab.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-33448599 >> 2 ^ -8366676);
					num = 252;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be != 0)
					{
						num = 229;
						continue;
					}
					continue;
				case 1005:
					this.DataGridSpell.ThemeStyle.ReadOnly = false;
					num = 93;
					continue;
				case 1006:
					Form1.ct6f95iVW7aY43cQu7Z(this.textPulseFrequency, Form1.FKa6C7hD8TGBG7hXjxm());
					num = 1016;
					continue;
				case 1007:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button6, new EventHandler(this.cjvEfiBKRs));
					num2 = 110;
					break;
				case 1008:
					Form1.eWtKAdiMQJ3ku2SW7mE(this.guna2DragControl2, 0.6);
					this.guna2DragControl2.TargetControl = this.guna2PictureBox1;
					num = 1352;
					continue;
				case 1009:
					this.guna2TabSettings.TabButtonIdleState.Font = new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~-531755127 ^ 531748938), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num2 = 47;
					break;
				case 1010:
					this.tabSettings = new TabPage();
					num = 172;
					continue;
				case 1011:
					this.textGameFolder.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(2090212177 ^ 2090218349), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 1173;
					continue;
				case 1012:
					this.tabPage4 = new TabPage();
					num = 195;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
					{
						num = 405;
						continue;
					}
					continue;
				case 1013:
					Form1.BYULIGhFpBJPZrMGUKF(this.toggleAttackTargetNotInCombat, Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387929508));
					num = 801;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba == 0)
					{
						num = 862;
						continue;
					}
					continue;
				case 1014:
					Form1.F8DDPrC4dhV11PnsIC6(this.label14, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1746511494 ^ -1746505402), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
					this.label14.ForeColor = Form1.G9eLqeSP2XWNAQfY8h5();
					num = 243;
					continue;
				case 1015:
					this.guna2GradientPanel1.FillColor2 = Color.FromArgb(60, 60, 60);
					num2 = 512;
					break;
				case 1016:
					Form1.fSKvdPhXB121ntJCND9(this.textPulseFrequency, new Point(192, 30));
					num = 360;
					continue;
				case 1017:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.guna2TabSettings, false);
					num = 800;
					continue;
				case 1018:
					this.textConsole.ReadOnly = true;
					num = 280;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_54c2f8a2b1dd479e83e6b60054e43e88 == 0)
					{
						num = 871;
						continue;
					}
					continue;
				case 1019:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label12, new Size(344, 23));
					num = 487;
					continue;
				case 1020:
					Form1.Jlq43diUhDdv5DIhVjg(this.txtLicenseExpiry).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255);
					num = 590;
					continue;
				case 1021:
					Form1.wEyJSbCFacgSXItvROk(this.txtUsername, new Font(Form1.Bp8crKQbU76Tg68kvQp(1621542659 + 1028479281 ^ -1644951544), 10f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 273;
					continue;
				case 1022:
					Form1.OmMH5wINnsrGWBpyo6n(this.toggleAutoTab.UncheckedState, Form1.pd7LrbAfTlIgHjZelLV());
					num = 350;
					continue;
				case 1023:
					Form1.rKgWEMSmKw4ZRqoLtHs(this.DataGridSettings, DataGridViewCellBorderStyle.SingleHorizontal);
					num = 101;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num = 150;
						continue;
					}
					continue;
				case 1024:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.guna2GradientPanel2, false);
					num = 46;
					continue;
				case 1025:
					Form1.GOQ6mliZ99yg9aWmiSk(Form1.gBFD6UiIE14syZ5nRUZ(this.textAddonName), Color.FromArgb(138, 138, 138));
					num = 314;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a == 0)
					{
						num = 665;
						continue;
					}
					continue;
				case 1026:
					this.label16 = new Label();
					num = 687;
					continue;
				case 1027:
					Form1.rMNt2hhkQfYxahtLlNM(this.guna2TabControl2.TabButtonSelectedState, Form1.Y1UIkkw4SWDmFnSC63U(76, 132, 255));
					num = 756;
					continue;
				case 1028:
					this.sharpClipboard1.ClipboardChanged += this.oWSEaTalVP;
					num = 301;
					continue;
				case 1029:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2GradientPanel2, Form1.Bp8crKQbU76Tg68kvQp(~-1605313923 ^ 1605310884));
					num = 1055;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 == 0)
					{
						num = 1367;
						continue;
					}
					continue;
				case 1030:
					Form1.eF0FoaS1sQWGM7A5mGR(this.btnStartStop, AnchorStyles.Bottom | AnchorStyles.Right);
					num = 211;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a != 0)
					{
						num = 192;
						continue;
					}
					continue;
				case 1031:
					this.guna2ComboBox1 = new Guna2ComboBox();
					num = 49;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 != 0)
					{
						num = 155;
						continue;
					}
					continue;
				case 1032:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5), this.label4);
					num = 1107;
					continue;
				case 1033:
					Form1.UuXRD3IgMlNN2nOkkF0(this.DataGridSettings, DataGridViewEditMode.EditOnEnter);
					num = 742;
					continue;
				case 1034:
					this.btnReGenerateAddon.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(1654110737 ^ -473083753 ^ -2124758342), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num2 = 797;
					break;
				case 1035:
					Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button6).CustomBorderColor = Form1.giuhSiS4f07IhTOwgHy();
					Form1.wr5o3ESO7nyo3wXgm1J(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button6), Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169));
					Form1.jYIvwlSFeUP8EP4RD48(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button6), Color.FromArgb(141, 141, 141));
					num = 1036;
					continue;
				case 1036:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button6, new Font(Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352734812), 9f));
					num = 1275;
					continue;
				case 1037:
					Form1.cjbEqXhOkHto9Mpb3TF(this.tabAccount.Controls, this.label8);
					num = 175;
					continue;
				case 1038:
					this.tabAccount.Location = new Point(184, 4);
					num = 653;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 != 0)
					{
						num = 70;
						continue;
					}
					continue;
				case 1039:
					this.toolStripMenuItemShowMacro = new ToolStripMenuItem();
					num2 = 713;
					break;
				case 1040:
					this.txtLicenseType.Name = Form1.Bp8crKQbU76Tg68kvQp(-1668754258 ^ -1668747692);
					num = 544;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 != 0)
					{
						num = 328;
						continue;
					}
					continue;
				case 1041:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label13, Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374423586));
					num = 1114;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 973;
						continue;
					}
					continue;
				case 1042:
					Form1.fSKvdPhXB121ntJCND9(this.textConsole, new Point(0, 0));
					num = 80;
					continue;
				case 1043:
					Form1.fSKvdPhXB121ntJCND9(this.guna2ProgressIndicator1, new Point(97, 74));
					num2 = 887;
					break;
				case 1044:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabPage2, Form1.Bp8crKQbU76Tg68kvQp(-1307524010 ^ -1307512290));
					num = 156;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37a20c2e025c4269a91da4cf2ed7e3df != 0)
					{
						num = 918;
						continue;
					}
					continue;
				case 1045:
					Form1.c0T4oUhzseliJt6JbSj(this.DataGridSpell, 2);
					num = 47;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da != 0)
					{
						num = 100;
						continue;
					}
					continue;
				case 1046:
					this.toolStripSeparator1 = new ToolStripSeparator();
					num = 1039;
					continue;
				case 1047:
					Form1.fSKvdPhXB121ntJCND9(this.label9, new Point(10, 75));
					num = 54;
					continue;
				case 1048:
					this.guna2GradientPanel3.Size = new Size(731, 42);
					num = 75;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
					{
						num = 950;
						continue;
					}
					continue;
				case 1049:
					this.txtLicenseType.Size = new Size(509, 33);
					num = 884;
					continue;
				case 1050:
					Form1.Fb8UmLiRlpCh8WUG8v0(Form1.gBFD6UiIE14syZ5nRUZ(this.textGameFolder), Form1.Y1UIkkw4SWDmFnSC63U(226, 226, 226));
					Form1.gBFD6UiIE14syZ5nRUZ(this.textGameFolder).ForeColor = Color.FromArgb(138, 138, 138);
					num2 = 905;
					break;
				case 1051:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2), this.label17);
					num2 = 217;
					break;
				case 1052:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					dataGridViewCellStyle3.SelectionBackColor = Form1.SpVp1pSsuOkIuaZ0gb7();
					num = 1073;
					continue;
				}
				case 1053:
					this.guna2TabSettings.TabButtonSelectedState.ForeColor = Color.Black;
					num = 1284;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 != 0)
					{
						num = 618;
						continue;
					}
					continue;
				case 1054:
					Form1.Cv9NRmI4hrLJaPHB83g(this.ColSettingsName, Form1.Bp8crKQbU76Tg68kvQp(--1797548854 ^ 1797544888));
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 1055:
					Form1.fSKvdPhXB121ntJCND9(this.DataGridSettings, new Point(2, 2));
					this.DataGridSettings.Margin = new Padding(0);
					num = 695;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a != 0)
					{
						num = 764;
						continue;
					}
					continue;
				case 1056:
					Form1.FHsxx6IVReXxj50lsQM(Form1.IxeeAFI56iP6msjRr8x(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), Color.Empty);
					num = 700;
					continue;
				case 1057:
					this.guna2TabControl1.Margin = new Padding(0);
					num = 433;
					continue;
				case 1058:
					Form1.sUSlgdhHRw1CXHlv9uV(this.textPulseFrequency, new Size(152, 35));
					num = 1176;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 != 0)
					{
						num = 1012;
						continue;
					}
					continue;
				case 1059:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2Button6, Form1.Bp8crKQbU76Tg68kvQp(1767032709 ^ 1767046577));
					num = 573;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
					{
						num = 716;
						continue;
					}
					continue;
				case 1060:
					this.DataGridSettings.MouseDown += this.L7kEdmBJ7I;
					num = 921;
					continue;
				case 1061:
					Form1.fSKvdPhXB121ntJCND9(this.guna2Button7, new Point(358, 209));
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2Button7, Form1.Bp8crKQbU76Tg68kvQp(~-1605313923 ^ 1605312388));
					num = 846;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 != 0)
					{
						num = 244;
						continue;
					}
					continue;
				case 1062:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabRotation);
					num = 116;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c7104ccd40024e009409c6d14eb5a99a == 0)
					{
						num = 1324;
						continue;
					}
					continue;
				case 1063:
					Form1.NTYtH4ICbD0jWXFC4ol(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)).BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
					num = 1129;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
					{
						num = 1237;
						continue;
					}
					continue;
				case 1064:
					Form1.AQ5PKbSlGpZgbylJlqA(this.guna2ControlBox1, Form1.HWi2GWSiSnTprngPudf());
					num = 1239;
					continue;
				case 1065:
					Form1.sLBp4vhs8n4RKjjB6is(this.guna2TabControl2, DockStyle.Fill);
					num = 379;
					continue;
				case 1066:
					this.guna2Button9 = new Guna2Button();
					num = 74;
					continue;
				case 1067:
					this.label6.TabIndex = 23;
					num = 81;
					continue;
				case 1068:
					Form1.gGZnrriA34hqIifEHcW(this.guna2ComboBox1, ComboBoxStyle.DropDownList);
					num = 241;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 == 0)
					{
						num = 147;
						continue;
					}
					continue;
				case 1069:
				{
					DataGridViewCellStyle dataGridViewCellStyle2;
					Form1.O31LTUSM513icv5yigG(this.DataGridSettings, dataGridViewCellStyle2);
					num = 298;
					continue;
				}
				case 1070:
					this.txtLicenseExpiry.TextOffset = new Point(-2, 0);
					num = 1314;
					continue;
				case 1071:
					Form1.L8MkK2IQffWUKgICJNj(Form1.pGgBCJIdLumlibNFUV8(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), 30);
					num2 = 1005;
					break;
				case 1072:
					Form1.sUSlgdhHRw1CXHlv9uV(this.toggleAutoBind, new Size(41, 23));
					num = 941;
					continue;
				case 1073:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					dataGridViewCellStyle3.SelectionForeColor = Form1.gDTkfBSgI078eL8rUC0();
					num = 563;
					continue;
				}
				case 1074:
					Form1.bnrr8uiplYjGFY5NtLt(this.textAddonName, '\0');
					num = 619;
					continue;
				case 1075:
					this.removeScriptToolStripMenuItem.Name = Form1.Bp8crKQbU76Tg68kvQp(--2124070285 ^ 2124060663);
					num = 103;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 != 0)
					{
						num = 341;
						continue;
					}
					continue;
				case 1076:
					this.toolStripMenuItemShowMacro.Text = Form1.Bp8crKQbU76Tg68kvQp(1074597531 ^ 1074602047);
					num = 672;
					continue;
				case 1077:
					this.guna2GradientPanel1.BorderColor = Color.Silver;
					num = 27;
					continue;
				case 1078:
					Form1.c0T4oUhzseliJt6JbSj(this.textAddonRefreshRate, 18);
					num = 1306;
					continue;
				case 1079:
					this.label6 = new Label();
					num = 518;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
					{
						num = 553;
						continue;
					}
					continue;
				case 1080:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabPage5, false);
					num = 1206;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
					{
						num = 527;
						continue;
					}
					continue;
				case 1081:
					Form1.ADQeAgis8rtmU242cdc(this.guna2PictureBox1, 1);
					this.guna2PictureBox1.TabStop = false;
					Form1.thaHaeigK1YcARZBfq2(this.guna2PictureBox1, true);
					num = 613;
					continue;
				case 1082:
					Form1.GOQ6mliZ99yg9aWmiSk(Form1.gBFD6UiIE14syZ5nRUZ(this.txtUsername), Color.FromArgb(138, 138, 138));
					this.txtUsername.FillColor = Color.FromArgb(240, 240, 240);
					Form1.TEkSI5i126jFtHpxr4P(Form1.Jlq43diUhDdv5DIhVjg(this.txtUsername), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					num = 548;
					continue;
				case 1083:
					this.DataGridSettings = new Guna2DataGridView();
					num = 749;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 != 0)
					{
						num = 335;
						continue;
					}
					continue;
				case 1084:
					Form1.UDBpMTifsAVJ3rf3uW5(this.textGameFolder, new Point(-2, 0));
					num2 = 892;
					break;
				case 1085:
					this.loadSelectedToolStripMenuItem = new ToolStripMenuItem();
					num = 930;
					continue;
				case 1086:
					this.tabPage1.Margin = new Padding(2);
					num = 290;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 == 0)
					{
						num = 1087;
						continue;
					}
					continue;
				case 1087:
					this.tabPage1.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1797548854 ^ 1797544708);
					num = 830;
					continue;
				case 1088:
					this.toolTip1.SetToolTip(this.label11, Form1.Bp8crKQbU76Tg68kvQp(1386050510 + 11679858 ^ 1397727164));
					num = 384;
					continue;
				case 1089:
					Form1.jFEDIBitpCPjeWrEdkl(this.guna2PictureBox1, 0f);
					num = 464;
					continue;
				case 1090:
					Form1.bAfsNnixIiVZajHwRbB(this.textGameFolder, Form1.VA4WwsiygtFFKaVPeZt());
					num = 92;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 == 0)
					{
						num = 98;
						continue;
					}
					continue;
				case 1091:
					Form1.fSKvdPhXB121ntJCND9(this.label12, new Point(59, 114));
					num = 48;
					continue;
				case 1092:
					this.textStatus.Location = new Point(65, 8);
					num = 538;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
					{
						num = 654;
						continue;
					}
					continue;
				case 1093:
					Form1.GtWSMsZTTqoBGllCQwV(this.tabLog);
					num = 779;
					continue;
				case 1094:
					this.guna2DragControl1 = new Guna2DragControl(this.components);
					num = 397;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num = 236;
						continue;
					}
					continue;
				case 1095:
					Form1.pMcELVSTsaMWxAYDlvZ(this.btnCancelBind, true);
					num = 1212;
					continue;
				case 1096:
					this.tabPage5.Name = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1755352853 ^ -1755365345);
					num = 706;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
					{
						num = 169;
						continue;
					}
					continue;
				case 1097:
					Form1.RsaqC7h6uTpcoFADpiT(this.guna2TabControl1, new Size(180, 45));
					num = 920;
					continue;
				case 1098:
					Form1.Cv9NRmI4hrLJaPHB83g(this.ColName, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-87166655 + -2142521002 ^ 2065270535));
					num2 = 72;
					break;
				case 1099:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label17, Form1.Bp8crKQbU76Tg68kvQp(-764151834 ^ -764163440));
					Form1.oSbS6yZi1nlb76ZQy80(this, new SizeF(8f, 20f));
					num = 52;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec != 0)
					{
						num = 2;
						continue;
					}
					continue;
				case 1100:
					Form1.fSKvdPhXB121ntJCND9(this.label2, new Point(11, 72));
					num = 446;
					continue;
				case 1101:
					this.contextMenuShowMacro.Items.AddRange(new ToolStripItem[]
					{
						this.toolStripMenuItemClearBind,
						this.toolStripSeparator1,
						this.toolStripMenuItemShowMacro
					});
					num = 661;
					continue;
				case 1102:
					Form1.DIHdSHS7iP1A7KmNMB1(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button2), Form1.giuhSiS4f07IhTOwgHy());
					num = 740;
					continue;
				case 1103:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabAccount), this.label9);
					num = 99;
					continue;
				case 1104:
					this.tabRotation.Text = Form1.Bp8crKQbU76Tg68kvQp(-831735385 ^ -831745721);
					num = 889;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_114c8e4d680c4b9997b685901f6ff336 != 0)
					{
						num = 960;
						continue;
					}
					continue;
				case 1105:
					Form1.BelJUdIfWaaWNT5ivWk(this.ColBindBtn, Form1.Bp8crKQbU76Tg68kvQp(1308721404 ^ 1308723322));
					num = 1354;
					continue;
				case 1106:
					Form1.NEVx6ciQWUA1CnM79yH(this.guna2ComboBox1, 30);
					num = 682;
					continue;
				case 1107:
					this.tabPage5.Controls.Add(this.textAddonRefreshRate);
					num = 398;
					continue;
				case 1108:
					Form1.bnrr8uiplYjGFY5NtLt(this.txtLicenseType, '\0');
					num = 282;
					continue;
				case 1109:
					Form1.GTMMr4ILDsKXD57tVjr(this.ColDisabled, 138.8889f);
					num = 434;
					continue;
				case 1110:
					this.tabPage3.ImageIndex = 0;
					num = 508;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e == 0)
					{
						num = 836;
						continue;
					}
					continue;
				case 1111:
					this.guna2BorderlessForm1.ShadowColor = Form1.guNG4gh19ILHCqNxi2h();
					Form1.Ym8RuUhp4dIFAy6u2Me(this.guna2BorderlessForm1, true);
					num = 1286;
					continue;
				case 1112:
					this.menuStrip1.SuspendLayout();
					num = 952;
					continue;
				case 1113:
					this.ColIcon.MinimumWidth = 40;
					num = 117;
					continue;
				case 1114:
					this.toolTip1.SetToolTip(this.label13, Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553733025));
					num = 915;
					continue;
				case 1115:
					Form1.BelJUdIfWaaWNT5ivWk(this.ColName, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-838478377 ^ -838476405));
					num2 = 718;
					break;
				case 1116:
					Form1.pFoxNeSZ5YRTR9whdfW(this.imageList3.Images, 5, Form1.Bp8crKQbU76Tg68kvQp(268206341 ^ 268217045));
					num = 788;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 == 0)
					{
						num = 28;
						continue;
					}
					continue;
				case 1117:
				{
					DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
					num2 = 562;
					break;
				}
				case 1118:
					this.DataGridSpell.BorderStyle = BorderStyle.None;
					num = 112;
					continue;
				case 1119:
					Form1.JBnCqRhMbY6dWf5nXZF(this.listView1, new Padding(3, 3, 3, 58));
					num = 1308;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 == 0)
					{
						num = 1240;
						continue;
					}
					continue;
				case 1120:
					Form1.OROF9nCl3q4uMeX8ApH(this.guna2GradientPanel1).Add(this.guna2PictureBox1);
					this.guna2GradientPanel1.Dock = DockStyle.Top;
					num = 1253;
					continue;
				case 1121:
					this.guna2TabControl2.TabButtonIdleState.InnerColor = Form1.Y1UIkkw4SWDmFnSC63U(224, 224, 224);
					num = 704;
					continue;
				case 1122:
					this.label12.Text = Form1.Bp8crKQbU76Tg68kvQp(185404423 + 1853889833 ^ 2039290390);
					num = 159;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
					{
						num = 875;
						continue;
					}
					continue;
				case 1123:
					Form1.tRMKuWiiLgmaY6xGY7v(Form1.gBFD6UiIE14syZ5nRUZ(this.textAddonName), Color.FromArgb(138, 138, 138));
					num2 = 1025;
					break;
				case 1124:
					this.guna2ControlBox1.IconColor = Form1.pd7LrbAfTlIgHjZelLV();
					Form1.fSKvdPhXB121ntJCND9(this.guna2ControlBox1, new Point(876, 17));
					num = 235;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 == 0)
					{
						num = 164;
						continue;
					}
					continue;
				case 1125:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.label10, Color.DimGray);
					num = 240;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
					{
						num = 25;
						continue;
					}
					continue;
				case 1126:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label7, Form1.Bp8crKQbU76Tg68kvQp(850579974 + 1765464631 ^ -1678926975));
					num = 67;
					continue;
				case 1127:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.PanelKeyBind), this.guna2ProgressIndicator1);
					num = 819;
					continue;
				case 1128:
				{
					DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
					num = 545;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea == 0)
					{
						num = 27;
						continue;
					}
					continue;
				}
				case 1129:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button7, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1551733089 >> 2 ^ 387927140), 9f));
					num = 411;
					continue;
				case 1130:
					Form1.c0T4oUhzseliJt6JbSj(this.comboPixelLocation, 23);
					num = 877;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 == 0)
					{
						num = 567;
						continue;
					}
					continue;
				case 1131:
					this.tabAccount.Name = Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218512835);
					num = 141;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f != 0)
					{
						num = 160;
						continue;
					}
					continue;
				case 1132:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.tabRotation, false);
					num = 684;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
					{
						num = 768;
						continue;
					}
					continue;
				case 1133:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2ProgressIndicator1, new Size(75, 68));
					num = 713;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd19de316ac941abb4bc8c157ab3d341 == 0)
					{
						num = 1288;
						continue;
					}
					continue;
				case 1134:
					Form1.c0T4oUhzseliJt6JbSj(this.textPreCast, 22);
					num = 904;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb != 0)
					{
						num = 813;
						continue;
					}
					continue;
				case 1135:
					Form1.wxMaZnI7u1L89VdGNLA(this.label13, true);
					num = 1228;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num = 1181;
						continue;
					}
					continue;
				case 1136:
					this.labelKeyPreview.Location = new Point(69, 108);
					num = 164;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f == 0)
					{
						num = 13;
						continue;
					}
					continue;
				case 1137:
					this.tabPage3.TabIndex = 0;
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabPage3, Form1.Bp8crKQbU76Tg68kvQp(587114080 ^ 587108172));
					num = 466;
					continue;
				case 1138:
					Form1.PMxUPdSrxvVlWwnXnBc(this.guna2Button7, true);
					Form1.I5salaIrpg8plUCDDAh(this.guna2Button7, 5);
					num = 22;
					continue;
				case 1139:
					Form1.fSKvdPhXB121ntJCND9(this.label8, new Point(10, 9));
					num = 493;
					continue;
				case 1140:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabKeybinds), this.DataGridSpell);
					num = 170;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c02245dc84a14a53adc46bd8002cd2b2 == 0)
					{
						num = 669;
						continue;
					}
					continue;
				case 1141:
					Form1.TQ7387iKhdplLvSeKQ7(this.txtLicenseExpiry, true);
					this.txtLicenseExpiry.SelectedText = "";
					num = 1335;
					continue;
				case 1142:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage1), this.DataGridSettings);
					num = 1193;
					continue;
				case 1143:
					Form1.c0T4oUhzseliJt6JbSj(this.label9, 12);
					num = 239;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_14783df6d9f947ad8c31e2be62e41a18 != 0)
					{
						num = 1175;
						continue;
					}
					continue;
				case 1144:
					this.PanelKeyBind.BorderColor = Form1.guNG4gh19ILHCqNxi2h();
					num = 21;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
					{
						num = 453;
						continue;
					}
					continue;
				case 1145:
					this.ColType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
					num = 427;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 == 0)
					{
						num = 256;
						continue;
					}
					continue;
				case 1146:
					this.tabLog.Size = new Size(731, 420);
					num = 108;
					continue;
				case 1147:
					this.txtLicenseExpiry.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
					num = 30;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 != 0)
					{
						num = 55;
						continue;
					}
					continue;
				case 1148:
					Form1.U3XM2Qhm2XM60XWh7EK(this.tabPage4, new Point(4, 34));
					num = 158;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 == 0)
					{
						num = 874;
						continue;
					}
					continue;
				case 1149:
					Form1.F8DDPrC4dhV11PnsIC6(this.tabRotation, new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-161182833 ^ -161176811), 8.25f));
					num = 865;
					continue;
				case 1150:
					Form1.voYLFshjBEBI0ODwIr7(this.tabPage2, new Padding(2));
					num = 889;
					continue;
				case 1151:
					this.guna2Button7 = new Guna2Button();
					num = 641;
					continue;
				case 1152:
					Form1.sUSlgdhHRw1CXHlv9uV(this.contextMenuShowMacro, new Size(171, 58));
					num = 537;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 == 0)
					{
						num = 300;
						continue;
					}
					continue;
				case 1153:
					this.label9 = new Label();
					num = 996;
					continue;
				case 1154:
					Form1.Ejey22SwIyfvnrggGSM(this.removeScriptToolStripMenuItem, new EventHandler(this.t9oPIem1jh));
					Form1.EaqCr3wYwj8s8ef9lTX(this.editToolStripMenuItem, false);
					num2 = 1170;
					break;
				case 1155:
				{
					DataGridViewCellStyle dataGridViewCellStyle5;
					Form1.Rer5dAStiGn1xeOjxdw(dataGridViewCellStyle5, DataGridViewContentAlignment.MiddleLeft);
					num = 529;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
					{
						num = 199;
						continue;
					}
					continue;
				}
				case 1156:
					Form1.wMMuMWiaRiJ3MryRMFB(this.txtLicenseExpiry, "");
					num = 1147;
					continue;
				case 1157:
					Form1.sUSlgdhHRw1CXHlv9uV(this.label6, new Size(91, 20));
					num = 1067;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0656062713004318aa3a835b6bf28eab != 0)
					{
						num = 415;
						continue;
					}
					continue;
				case 1158:
					this.tabPage5.Controls.Add(this.toggleAttackOutOfCombat);
					num = 86;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
					{
						num = 610;
						continue;
					}
					continue;
				case 1159:
					Form1.sUSlgdhHRw1CXHlv9uV(this.DataGridSpell, new Size(731, 378));
					num = 627;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 != 0)
					{
						num = 1045;
						continue;
					}
					continue;
				case 1160:
					this.textAddonName = new Guna2TextBox();
					num = 401;
					continue;
				case 1161:
					Form1.utyvnhZqF726m1cVEH7(this.guna2MessageDialog1, null);
					num = 294;
					continue;
				case 1162:
					Form1.UKbNgvhKj1KrPfkYk1l(Form1.CjCbtvh2yRUkguJMX9P(this.guna2TabSettings), new Font(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2018852357 ^ -2018842169), 9f));
					num = 1053;
					continue;
				case 1163:
					Form1.c0T4oUhzseliJt6JbSj(this.txtUsername, 11);
					this.txtUsername.TextOffset = new Point(-2, 0);
					num = 951;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af != 0)
					{
						num = 359;
						continue;
					}
					continue;
				case 1164:
					Form1.HknG7ni99eBPTOLlrcb(Form1.alCM98iCFxYevvKLalT(this.comboPixelLocation), new object[]
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1872685799 ^ -1872682125),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1074597531 ^ 1074608357)
					});
					num = 257;
					continue;
				case 1165:
					Form1.BYULIGhFpBJPZrMGUKF(this.label15, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-613886095 << 1 ^ -1227778014));
					num = 307;
					continue;
				case 1166:
					Form1.KqEGC6ZFSRhE9SaLP4V(this.guna2GradientPanel1, false);
					num = 1003;
					continue;
				case 1167:
					Form1.OyAwT6ic1QM8iT89i3U(this.label12, RightToLeft.Yes);
					num = 600;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 != 0)
					{
						num = 1019;
						continue;
					}
					continue;
				case 1168:
					this.guna2TabSettings.ImageList = this.imageList3;
					num = 245;
					continue;
				case 1169:
					Form1.F8DDPrC4dhV11PnsIC6(this.label16, new Font(Form1.Bp8crKQbU76Tg68kvQp(1048347516 ^ 1048357696), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 824;
					continue;
				case 1170:
					this.editToolStripMenuItem.Image = Form1.juNGPTSSDEGN1Db1ybK();
					Form1.pO88tISAdsdR80aCRiT(this.editToolStripMenuItem, Form1.Bp8crKQbU76Tg68kvQp(-886904286 ^ -886914838));
					num = 791;
					continue;
				case 1171:
					this.label2.TabIndex = 8;
					num = 203;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd == 0)
					{
						num = 90;
						continue;
					}
					continue;
				case 1172:
					this.labelKeyPreview.AutoSize = true;
					num2 = 176;
					break;
				case 1173:
					Form1.TEkSI5i126jFtHpxr4P(Form1.hgQ7OUiLBG9h0tLB2Ug(this.textGameFolder), Color.FromArgb(94, 148, 255));
					num = 1016;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e == 0)
					{
						num = 1182;
						continue;
					}
					continue;
				case 1174:
					Form1.jYIvwlSFeUP8EP4RD48(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button1), Form1.Y1UIkkw4SWDmFnSC63U(141, 141, 141));
					num = 949;
					continue;
				case 1175:
					this.label9.Text = Form1.Bp8crKQbU76Tg68kvQp(-825446221 ^ -825455719);
					num = 288;
					continue;
				case 1176:
					this.textPulseFrequency.TabIndex = 20;
					num2 = 642;
					break;
				case 1177:
					Form1.wr5o3ESO7nyo3wXgm1J(this.guna2Button8.DisabledState, Color.FromArgb(169, 169, 169));
					num = 664;
					continue;
				case 1178:
				{
					Form1.qOx35PSnKLxqQrPtR2m(this.DataGridSpell, false);
					DataGridViewCellStyle dataGridViewCellStyle7;
					Form1.IWMBi6AOVaRiLvC0OqM(dataGridViewCellStyle7, Form1.pd7LrbAfTlIgHjZelLV());
					num2 = 502;
					break;
				}
				case 1179:
					Form1.ncynG5CT8UsyjBsDC3f(this.DataGridSpell, false);
					num = 937;
					continue;
				case 1180:
					Form1.HU61GfI0Rv3AMEKtWnE(this.toggleManualCastQueue).FillColor = Form1.Y1UIkkw4SWDmFnSC63U(125, 137, 149);
					num = 738;
					continue;
				case 1181:
					this.label9.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-289990612 ^ 1144181582 ^ -1434066082), 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 588;
					continue;
				case 1182:
					Form1.fSKvdPhXB121ntJCND9(this.textGameFolder, new Point(11, 27));
					num = 332;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
					{
						num = 215;
						continue;
					}
					continue;
				case 1183:
					Form1.wr5o3ESO7nyo3wXgm1J(this.btnReGenerateAddon.DisabledState, Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169));
					num = 971;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
					{
						num = 1334;
						continue;
					}
					continue;
				case 1184:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings).RowsStyle.BackColor = Form1.pd7LrbAfTlIgHjZelLV();
					num = 334;
					continue;
				case 1185:
					Form1.rNXejGSp5vN1fxhySyd(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button6), Form1.giuhSiS4f07IhTOwgHy());
					num = 1035;
					continue;
				case 1186:
					Form1.PMxUPdSrxvVlWwnXnBc(this.btnReGenerateAddon, true);
					num = 48;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
					{
						num = 1355;
						continue;
					}
					continue;
				case 1187:
					Form1.ts5qOphSdFeFDL1nGkF(this.statusIcon);
					base.SuspendLayout();
					num = 2;
					continue;
				case 1188:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabPage4);
					num = 1112;
					continue;
				case 1189:
					Form1.uyiPqPilkVZPP2eqCPv(this.guna2Button7, Color.FromArgb(255, 128, 0));
					num = 1129;
					continue;
				case 1190:
					Form1.bnrr8uiplYjGFY5NtLt(this.txtLicenseExpiry, '\0');
					num = 825;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
					{
						num = 352;
						continue;
					}
					continue;
				case 1191:
					this.guna2TabSettings.Location = new Point(0, 0);
					num = 961;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 != 0)
					{
						num = 1254;
						continue;
					}
					continue;
				case 1192:
					Form1.U3XM2Qhm2XM60XWh7EK(this.tabSettings, new Point(184, 4));
					num = 622;
					continue;
				case 1193:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.tabPage1, Color.DimGray);
					num = 77;
					continue;
				case 1194:
					Form1.dgeks9I3VodlDjWpuW7(Form1.pGgBCJIdLumlibNFUV8(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell)), Color.White);
					num = 223;
					continue;
				case 1195:
					this.guna2TabControl1.Controls.Add(this.tabLog);
					num = 759;
					continue;
				case 1196:
					Form1.Gypb9bSfb8dfe9D7Fgg(this.btnCancelBind).ForeColor = Form1.Y1UIkkw4SWDmFnSC63U(141, 141, 141);
					num2 = 906;
					break;
				case 1197:
					Form1.jYIvwlSFeUP8EP4RD48(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button4), Form1.Y1UIkkw4SWDmFnSC63U(141, 141, 141));
					num = 38;
					continue;
				case 1198:
					Form1.AQ5PKbSlGpZgbylJlqA(this.comboPixelLocation, Color.Transparent);
					num2 = 724;
					break;
				case 1199:
					this.toolStripMenuItemClearBind = new ToolStripMenuItem();
					num = 1046;
					continue;
				case 1200:
					Form1.dvBRlGIhy56hFVtjNLt(Form1.NTYtH4ICbD0jWXFC4ol(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings)), Form1.Y1UIkkw4SWDmFnSC63U(71, 69, 94));
					num = 581;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae == 0)
					{
						num = 24;
						continue;
					}
					continue;
				case 1201:
					Form1.ALY22AijnRSR6O15eYd(this.textStatus, 0);
					num = 295;
					continue;
				case 1202:
					Form1.c0T4oUhzseliJt6JbSj(this.toggleAutoTab, 28);
					Form1.HU61GfI0Rv3AMEKtWnE(this.toggleAutoTab).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(125, 137, 149);
					num = 488;
					continue;
				case 1203:
					this.tabPage2 = new TabPage();
					num = 975;
					continue;
				case 1204:
					this.label1.Location = new Point(11, 9);
					num = 895;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
					{
						num = 261;
						continue;
					}
					continue;
				case 1205:
					this.guna2TabControl1 = new Guna2TabControl();
					num = 1257;
					continue;
				case 1206:
					Form1.GtWSMsZTTqoBGllCQwV(this.tabPage5);
					Form1.MyWd6GZRsTANcsJlHcx(this.textPreCast);
					Form1.MyWd6GZRsTANcsJlHcx(this.textPulseFrequency);
					num = 639;
					continue;
				case 1207:
					this.ColName.FillWeight = 90.27778f;
					num = 1098;
					continue;
				case 1208:
					Form1.I5salaIrpg8plUCDDAh(this.guna2Button5, 5);
					Form1.rNXejGSp5vN1fxhySyd(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button5), Form1.giuhSiS4f07IhTOwgHy());
					num = 628;
					continue;
				case 1209:
					Form1.sLBp4vhs8n4RKjjB6is(this.guna2GradientPanel2, DockStyle.Bottom);
					num = 535;
					continue;
				case 1210:
				{
					DataGridViewCellStyle dataGridViewCellStyle8;
					Form1.QI0AhFIR1knu9ucab2n(this.ColSettingsName, dataGridViewCellStyle8);
					num = 123;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
					{
						num = 507;
						continue;
					}
					continue;
				}
				case 1211:
					Form1.bAfsNnixIiVZajHwRbB(this.textPreCast, Cursors.IBeam);
					num = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef != 0)
					{
						num = 3;
						continue;
					}
					continue;
				case 1212:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.btnCancelBind, new EventHandler(this.FWPPvUIwph));
					num = 1172;
					continue;
				case 1213:
					Form1.CxP1olSUjKIoBxtX0u6(this.tabPage2, 1);
					num = 1044;
					continue;
				case 1214:
					Form1.wxMaZnI7u1L89VdGNLA(this.label7, true);
					num = 802;
					continue;
				case 1215:
					base.Load += this.GOBgUcgxI;
					base.Shown += this.wDvHiFolp;
					num = 637;
					continue;
				case 1216:
				{
					DataGridViewCellStyle dataGridViewCellStyle6;
					Form1.QI0AhFIR1knu9ucab2n(this.ColType, dataGridViewCellStyle6);
					num = 1365;
					continue;
				}
				case 1217:
					Form1.voYLFshjBEBI0ODwIr7(this.textStatus, new Padding(26, 0, 0, 0));
					num2 = 395;
					break;
				case 1218:
					this.openFileDialog1 = new OpenFileDialog();
					this.guna2NotificationPaint1 = new Guna2NotificationPaint(this.components);
					num = 183;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num = 501;
						continue;
					}
					continue;
				case 1219:
					this.guna2Button2 = new Guna2Button();
					num = 37;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
					{
						num = 923;
						continue;
					}
					continue;
				case 1220:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button4, Form1.Bp8crKQbU76Tg68kvQp(567103098 ^ 567114100));
					Form1.Pj5rjPhYZsKmoJgcMvx(this.guna2Button4, new EventHandler(this.SOUEpVuGNI));
					num2 = 799;
					break;
				case 1221:
					this.guna2Button3.DisabledState.BorderColor = Form1.giuhSiS4f07IhTOwgHy();
					num = 848;
					continue;
				case 1222:
					Form1.c0T4oUhzseliJt6JbSj(this.label11, 25);
					num = 61;
					continue;
				case 1223:
					Form1.BYULIGhFpBJPZrMGUKF(this.label11, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1041647104 ^ -1041659466));
					num = 368;
					continue;
				case 1224:
					Form1.ts5qOphSdFeFDL1nGkF(this.DataGridSpell);
					num = 528;
					continue;
				case 1225:
					Form1.sUSlgdhHRw1CXHlv9uV(this.listView1, new Size(719, 350));
					num = 958;
					continue;
				case 1226:
					this.tabKeybinds = new TabPage();
					num = 513;
					continue;
				case 1227:
					Form1.Lg0ScKIpjNLeXbDQTVP(this.ColIcon, DataGridViewAutoSizeColumnMode.None);
					num = 492;
					continue;
				case 1228:
					this.label13.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-1041647104 ^ -1041657284), 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 40;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_ce59933fd09643e182b90c09334cb5d2 == 0)
					{
						num = 586;
						continue;
					}
					continue;
				case 1229:
					Form1.BYULIGhFpBJPZrMGUKF(this.labelKeyPreview, Form1.Bp8crKQbU76Tg68kvQp(-283366293 ^ -283377329));
					num = 644;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
					{
						num = 639;
						continue;
					}
					continue;
				case 1230:
					this.guna2Button1.TextRenderingHint = TextRenderingHint.AntiAlias;
					num2 = 753;
					break;
				case 1231:
					Form1.fSKvdPhXB121ntJCND9(this.guna2Button1, new Point(666, 375));
					num = 234;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 16;
						continue;
					}
					continue;
				case 1232:
					Form1.fSKvdPhXB121ntJCND9(this.label16, new Point(59, 143));
					num = 34;
					continue;
				case 1233:
					Form1.fW5jjUiXsjSfqLiKplO(this.guna2DragControl1, true);
					num = 1008;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
					{
						num = 133;
						continue;
					}
					continue;
				case 1234:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2Button3, Form1.pd7LrbAfTlIgHjZelLV());
					num = 1266;
					continue;
				case 1235:
					this.txtLicenseExpiry.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-1406908615 ^ 676245432 ^ -2073378627), 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 358;
					continue;
				case 1236:
					Form1.b93ptlhlJQMfCjQWJts(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabSettings), Color.Empty);
					num = 499;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cc95b2f29ca843e1a5155e0d5770ad09 != 0)
					{
						num = 977;
						continue;
					}
					continue;
				case 1237:
					Form1.B8c6UEIcxWgItx92tUl(this.DataGridSpell).RowsStyle.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-443850682 << 3 ^ 744172044), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = 481;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 != 0)
					{
						num = 245;
						continue;
					}
					continue;
				case 1238:
					this.webView21.Size = new Size(719, 378);
					num = 1318;
					continue;
				case 1239:
					Form1.eGWnMxi65OSwTQYt7n4(this.guna2ControlBox1, Form1.Y1UIkkw4SWDmFnSC63U(224, 224, 224));
					num = 236;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8590fa2330a9409ebec2e2249b244600 == 0)
					{
						num = 253;
						continue;
					}
					continue;
				case 1240:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2Button8, Form1.Bp8crKQbU76Tg68kvQp(1638637009 >> 6 ^ 25597873));
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2Button8, new Size(508, 42));
					num = 818;
					continue;
				case 1241:
					Form1.F8DDPrC4dhV11PnsIC6(this.label5, new Font(Form1.Bp8crKQbU76Tg68kvQp(~-1482987862 ^ 1482994025), 9f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 388;
					continue;
				case 1242:
					this.tabSettings.SuspendLayout();
					num = 578;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 == 0)
					{
						num = 210;
						continue;
					}
					continue;
				case 1243:
					this.toolTip1 = new ToolTip(this.components);
					num = 130;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 != 0)
					{
						num = 126;
						continue;
					}
					continue;
				case 1244:
					Form1.pO88tISAdsdR80aCRiT(this.toolStripMenuItemClearBind, Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374426498));
					num = 221;
					continue;
				case 1245:
					Form1.HU61GfI0Rv3AMEKtWnE(this.toggleManualCastQueue).BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(125, 137, 149);
					num2 = 1180;
					break;
				case 1246:
					Form1.ujfH77SVCnHBuUNBj9v(this.listView1, View.Details);
					num = 326;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_bbde65f049484d1e84226476c9c6bfea == 0)
					{
						num = 317;
						continue;
					}
					continue;
				case 1247:
					Form1.KYZsvsSHA47xpxgVViu(this.DataGridSpell, DataGridViewHeaderBorderStyle.None);
					num2 = 812;
					break;
				case 1248:
					this.guna2Button2.Margin = new Padding(2);
					num = 615;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 != 0)
					{
						num = 579;
						continue;
					}
					continue;
				case 1249:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5), this.label5);
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5), this.textPulseFrequency);
					num = 1032;
					continue;
				case 1250:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2Button1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(881693030 + 414722879 ^ 1296404609));
					num2 = 583;
					break;
				case 1251:
					this.btnReGenerateAddon.Size = new Size(158, 31);
					Form1.c0T4oUhzseliJt6JbSj(this.btnReGenerateAddon, 34);
					num = 259;
					continue;
				case 1252:
					this.textAddonRefreshRate.Font = new Font(Form1.Bp8crKQbU76Tg68kvQp(-2018852357 ^ -2018842169), 9f);
					Form1.ct6f95iVW7aY43cQu7Z(this.textAddonRefreshRate, Color.Black);
					num = 1277;
					continue;
				case 1253:
					Form1.oSrhFjikdPlqytd0vSX(this.guna2GradientPanel1, Form1.Y1UIkkw4SWDmFnSC63U(64, 64, 64));
					num = 1015;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
					{
						num = 197;
						continue;
					}
					continue;
				case 1254:
					Form1.JBnCqRhMbY6dWf5nXZF(this.guna2TabSettings, new Padding(2));
					num = 422;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d7db82c175de47d2b5f36bc0c7f71006 != 0)
					{
						num = 70;
						continue;
					}
					continue;
				case 1255:
					Form1.PMxUPdSrxvVlWwnXnBc(this.guna2Button9, true);
					num = 437;
					continue;
				case 1256:
					Form1.IpgtX9SulMDveECTBOB(this.listView1, false);
					num = 1246;
					continue;
				case 1257:
					this.tabRotation = new TabPage();
					num = 428;
					continue;
				case 1258:
					this.guna2PictureBox1 = new Guna2PictureBox();
					num = 1094;
					continue;
				case 1259:
					Form1.zrr9k9htR9NUTAHlE3g(this.tabLog, true);
					Form1.eF0FoaS1sQWGM7A5mGR(this.guna2Button1, AnchorStyles.Right);
					num = 98;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
					{
						num = 128;
						continue;
					}
					continue;
				case 1260:
					this.removeScriptToolStripMenuItem.Enabled = false;
					num = 731;
					continue;
				case 1261:
					Form1.STG6BrIaHEj0qxrKnDQ(this.ColDisabled, 70);
					num = 462;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 != 0)
					{
						num = 898;
						continue;
					}
					continue;
				case 1262:
					Form1.jjcAKNhRfBLpRys7iFS(this.guna2TabSettings, 0);
					num = 584;
					continue;
				case 1263:
					Form1.P5eeUsS9qDJS8JGNAGm(this.removeScriptToolStripMenuItem, Form1.Bp8crKQbU76Tg68kvQp(951294359 ^ 47512224 ^ 979847567));
					num = 1154;
					continue;
				case 1264:
					Form1.ts5qOphSdFeFDL1nGkF(this.textAddonRefreshRate);
					num = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
					{
						num = 961;
						continue;
					}
					continue;
				case 1265:
					Form1.fSKvdPhXB121ntJCND9(this.label15, new Point(11, 131));
					num = 116;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 == 0)
					{
						num = 352;
						continue;
					}
					continue;
				case 1266:
					Form1.fSKvdPhXB121ntJCND9(this.guna2Button3, new Point(11, 331));
					num2 = 601;
					break;
				case 1267:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2Button4, 21);
					num2 = 1220;
					break;
				case 1268:
					this.btnStartStop.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
					num = 827;
					continue;
				case 1269:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label16, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1089588375 ^ -1089600983));
					num = 478;
					continue;
				case 1270:
					this.guna2Button6.BorderRadius = 5;
					num = 1185;
					continue;
				case 1271:
					Form1.pGgBCJIdLumlibNFUV8(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings)).BackColor = Form1.Y1UIkkw4SWDmFnSC63U(100, 88, 255);
					num = 1292;
					continue;
				case 1272:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.tabAccount, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1714141621 >> 6 ^ 26777426));
					num = 30;
					continue;
				case 1273:
					Form1.Cv9NRmI4hrLJaPHB83g(this.ColKeybind, Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134406402));
					num = 851;
					continue;
				case 1274:
					Form1.HknG7ni99eBPTOLlrcb(Form1.alCM98iCFxYevvKLalT(this.comboKeyboard), new object[]
					{
						Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387928886),
						Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387928870)
					});
					num2 = 208;
					break;
				case 1275:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2Button6, Form1.pd7LrbAfTlIgHjZelLV());
					num = 148;
					continue;
				case 1276:
					this.comboPixelLocation.StartIndex = 0;
					num = 471;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
					{
						num = 1130;
						continue;
					}
					continue;
				case 1277:
					Form1.fSKvdPhXB121ntJCND9(this.textAddonRefreshRate, new Point(12, 30));
					num = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_912464c7521643f2968751cbbc64f3cf == 0)
					{
						num = 42;
						continue;
					}
					continue;
				case 1278:
					this.menuStrip1.Location = new Point(2, 2);
					num = 370;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num = 79;
						continue;
					}
					continue;
				case 1279:
					Form1.HGlKd5hvsT3Rl0VTrEp(this.guna2Button9, Form1.pd7LrbAfTlIgHjZelLV());
					num = 418;
					continue;
				case 1280:
					Form1.sUSlgdhHRw1CXHlv9uV(this.guna2GradientPanel1, new Size(919, 63));
					num = 321;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_450de79ddfe6409a988b8682e74747f2 != 0)
					{
						num = 109;
						continue;
					}
					continue;
				case 1281:
					Form1.zFQ3WEi7DcDeehUBE0t(this.guna2GradientPanel1, new PaintEventHandler(this.N4qEjP9q8I));
					num = 469;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 != 0)
					{
						num = 20;
						continue;
					}
					continue;
				case 1282:
					Form1.HbkIbNIuh8Zmqq7AKE1(Form1.IxeeAFI56iP6msjRr8x(Form1.B8c6UEIcxWgItx92tUl(this.DataGridSettings)), Color.Empty);
					Form1.FHsxx6IVReXxj50lsQM(this.DataGridSettings.ThemeStyle.AlternatingRowsStyle, Color.Empty);
					num = 386;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d6675f44e192471dbaeaf2d22fed78ae != 0)
					{
						num = 683;
						continue;
					}
					continue;
				case 1283:
					Form1.TEkSI5i126jFtHpxr4P(Form1.gBFD6UiIE14syZ5nRUZ(this.txtUsername), Form1.Y1UIkkw4SWDmFnSC63U(208, 208, 208));
					num = 68;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 == 0)
					{
						num = 901;
						continue;
					}
					continue;
				case 1284:
					Form1.rMNt2hhkQfYxahtLlNM(this.guna2TabSettings.TabButtonSelectedState, Form1.Y1UIkkw4SWDmFnSC63U(76, 132, 255));
					num = 1300;
					continue;
				case 1285:
					Form1.F8DDPrC4dhV11PnsIC6(this.guna2Button9, new Font(Form1.Bp8crKQbU76Tg68kvQp(-253515656 ^ -1789645123 ^ 1706536697), 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0));
					num = 822;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 == 0)
					{
						num = 1279;
						continue;
					}
					continue;
				case 1286:
					Form1.rwewK0h4reiUaHQDmoU(this.guna2TabControl1, TabAlignment.Left);
					num = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
					{
						num = 73;
						continue;
					}
					continue;
				case 1287:
					Form1.b93ptlhlJQMfCjQWJts(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabControl1), Color.Empty);
					num = 560;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 == 0)
					{
						num = 154;
						continue;
					}
					continue;
				case 1288:
					Form1.c0T4oUhzseliJt6JbSj(this.guna2ProgressIndicator1, 5);
					num = 666;
					continue;
				case 1289:
					Form1.DIHdSHS7iP1A7KmNMB1(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button7), Form1.giuhSiS4f07IhTOwgHy());
					num = 208;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
					{
						num = 1321;
						continue;
					}
					continue;
				case 1290:
					Form1.sLBp4vhs8n4RKjjB6is(this.DataGridSettings, DockStyle.Fill);
					num2 = 1033;
					break;
				case 1291:
					Form1.BYULIGhFpBJPZrMGUKF(this.comboGameVersion, Form1.Bp8crKQbU76Tg68kvQp(~-1605313923 ^ 1605310658));
					num = 620;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
					{
						num = 250;
						continue;
					}
					continue;
				case 1292:
					this.DataGridSettings.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
					num = 53;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 == 0)
					{
						num = 50;
						continue;
					}
					continue;
				case 1293:
					Form1.TEkSI5i126jFtHpxr4P(Form1.Jlq43diUhDdv5DIhVjg(this.textStatus), Color.FromArgb(60, 60, 60));
					num2 = 406;
					break;
				case 1294:
					this.DataGridSpell.Name = Form1.Bp8crKQbU76Tg68kvQp(-860087180 << 5 ^ -1752980506);
					num = 515;
					continue;
				case 1295:
					this.guna2TabSettings.TabMenuOrientation = 0;
					num = 1142;
					continue;
				case 1296:
					this.guna2TabControl2.TabIndex = 3;
					num = 369;
					continue;
				case 1297:
					Form1.Y1lD2KZpgU9xXi0yV6l(this, this.menuStrip1);
					num = 65;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
					{
						num = 75;
						continue;
					}
					continue;
				case 1298:
					Form1.pO88tISAdsdR80aCRiT(this.toolStripMenuItemShowMacro, Form1.Bp8crKQbU76Tg68kvQp(-1872685799 ^ -1872675979));
					num = 318;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
					{
						num = 926;
						continue;
					}
					continue;
				case 1299:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.guna2Button5, Form1.Bp8crKQbU76Tg68kvQp(1654110737 ^ -473083753 ^ -2124754924));
					num = 993;
					continue;
				case 1300:
					Form1.RsaqC7h6uTpcoFADpiT(this.guna2TabSettings, new Size(176, 30));
					num = 539;
					continue;
				case 1301:
					Form1.nga6WgheeytD1C2eoXZ(this.guna2TabSettings.TabButtonHoverState, Color.Teal);
					Form1.rMNt2hhkQfYxahtLlNM(Form1.lhQ6buhLkE4fXJ5pm8a(this.guna2TabSettings), Color.PowderBlue);
					num = 986;
					continue;
				case 1302:
					Form1.vY9JJWI1Z0hangdfdIF(this.DataGridSpell, new MouseEventHandler(this.GZcPbDw0ua));
					num = 1227;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 == 0)
					{
						num = 613;
						continue;
					}
					continue;
				case 1303:
					this.guna2TabSettings.TabMenuBackColor = Color.White;
					num = 1295;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 != 0)
					{
						num = 503;
						continue;
					}
					continue;
				case 1304:
					this.comboPixelLocation.Name = Form1.Bp8crKQbU76Tg68kvQp(-1668754258 ^ -1668750794);
					num = 967;
					continue;
				case 1305:
				{
					DataGridViewCellStyle dataGridViewCellStyle5;
					Form1.sHSPBYSXYHPhTAgWo8a(dataGridViewCellStyle5, DataGridViewTriState.False);
					num = 255;
					continue;
				}
				case 1306:
				{
					Guna2NumericUpDown guna2NumericUpDown6 = this.textAddonRefreshRate;
					int[] array7 = new int[4];
					array7[0] = 10;
					guna2NumericUpDown6.Value = new decimal(array7);
					num = 456;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num = 989;
						continue;
					}
					continue;
				}
				case 1307:
					this.DataGridSpell.EnableHeadersVisualStyles = false;
					Form1.vJ6cNnSjslYmMsSaLt1(this.DataGridSpell, Form1.Y1UIkkw4SWDmFnSC63U(231, 229, 255));
					this.DataGridSpell.Location = new Point(0, 0);
					num2 = 125;
					break;
				case 1308:
					this.listView1.MultiSelect = false;
					num2 = 194;
					break;
				case 1309:
					Form1.kjNI22Z57lKULC4Mx8H(this.btnStartStop).FillColor = Form1.Y1UIkkw4SWDmFnSC63U(169, 169, 169);
					num = 138;
					continue;
				case 1310:
					this.DataGridSpell = new Guna2DataGridView();
					num = 35;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 != 0)
					{
						num = 32;
						continue;
					}
					continue;
				case 1311:
					Form1.voYLFshjBEBI0ODwIr7(this.txtLicenseExpiry, new Padding(2, 0, 2, 0));
					num = 1190;
					continue;
				case 1312:
					Form1.TEkSI5i126jFtHpxr4P(Form1.hgQ7OUiLBG9h0tLB2Ug(this.txtLicenseType), Form1.Y1UIkkw4SWDmFnSC63U(94, 148, 255));
					num = 124;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e3b631d8a3e54afc92ab7132d2862d60 == 0)
					{
						num = 415;
						continue;
					}
					continue;
				case 1313:
				{
					DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
					num = 116;
					continue;
				}
				case 1314:
					this.label10.AutoSize = true;
					num = 577;
					continue;
				case 1315:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.btnReGenerateAddon, new EventHandler(this.nQxEgvxUEU));
					Form1.wxMaZnI7u1L89VdGNLA(this.label14, true);
					num = 1014;
					continue;
				case 1316:
					this.toggleAttackOutOfCombat.UncheckedState.InnerColor = Color.White;
					num = 994;
					continue;
				case 1317:
					this.statusIcon = new Guna2PictureBox();
					num = 113;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
					{
						num = 39;
						continue;
					}
					continue;
				case 1318:
					Form1.c0T4oUhzseliJt6JbSj(this.webView21, 0);
					num = 717;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
					{
						num = 391;
						continue;
					}
					continue;
				case 1319:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.guna2TabSettings), this.tabPage1);
					num2 = 680;
					break;
				case 1320:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.label8, Form1.Bp8crKQbU76Tg68kvQp(-1690522925 ^ -1690529373));
					num = 1077;
					continue;
				case 1321:
					Form1.wr5o3ESO7nyo3wXgm1J(Form1.Gypb9bSfb8dfe9D7Fgg(this.guna2Button7), Color.FromArgb(169, 169, 169));
					num = 200;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_521a515f15c94d10b5254529acc6f115 == 0)
					{
						num = 67;
						continue;
					}
					continue;
				case 1322:
					this.txtUsername.SelectedText = "";
					num = 516;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 != 0)
					{
						num = 19;
						continue;
					}
					continue;
				case 1323:
					Form1.JBnCqRhMbY6dWf5nXZF(this.btnStartStop, new Padding(2));
					num = 170;
					continue;
				case 1324:
					this.guna2TabControl2.SuspendLayout();
					num = 188;
					continue;
				case 1325:
					this.txtLicenseType.DisabledState.BorderColor = Form1.Y1UIkkw4SWDmFnSC63U(208, 208, 208);
					num = 527;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
					{
						num = 111;
						continue;
					}
					continue;
				case 1326:
					this.txtUsername.DisabledState.ForeColor = Form1.Y1UIkkw4SWDmFnSC63U(138, 138, 138);
					num = 1082;
					continue;
				case 1327:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage2), this.guna2ComboBox1);
					num2 = 377;
					break;
				case 1328:
					this.textAddonName.DefaultText = "";
					num = 737;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 != 0)
					{
						num = 585;
						continue;
					}
					continue;
				case 1329:
					Form1.G1bergS3wlgABlFmf1Z(this.contextMenuShowMacro, new Size(20, 20));
					num = 1101;
					continue;
				case 1330:
					this.DataGridSettings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					num = 514;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
					{
						num = 821;
						continue;
					}
					continue;
				case 1331:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2ControlBox1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(581513541 ^ 581503723));
					num = 907;
					continue;
				case 1332:
					Form1.no90GHIE0Dao6auK2XZ(this.DataGridSpell, false);
					num = 1159;
					continue;
				case 1333:
					this.guna2Button8.Location = new Point(13, 260);
					num = 1240;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
					{
						num = 747;
						continue;
					}
					continue;
				case 1334:
					Form1.jYIvwlSFeUP8EP4RD48(Form1.Gypb9bSfb8dfe9D7Fgg(this.btnReGenerateAddon), Form1.Y1UIkkw4SWDmFnSC63U(141, 141, 141));
					num = 610;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc != 0)
					{
						num = 1034;
						continue;
					}
					continue;
				case 1335:
					this.txtLicenseExpiry.Size = new Size(509, 33);
					Form1.c0T4oUhzseliJt6JbSj(this.txtLicenseExpiry, 15);
					num = 517;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
					{
						num = 1070;
						continue;
					}
					continue;
				case 1336:
					Form1.Pj5rjPhYZsKmoJgcMvx(this.tabRotation, new EventHandler(this.pUGEbCek1K));
					num = 443;
					continue;
				case 1337:
					this.guna2TabControl1.SuspendLayout();
					num = 1062;
					continue;
				case 1338:
					this.ColSettingsValue.HeaderText = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1224731037 ^ -1224726879);
					num = 206;
					continue;
				case 1339:
					this.guna2Button9.Size = new Size(149, 31);
					num2 = 410;
					break;
				case 1340:
					Form1.NI0nbahhQrIJ1PGSqQI(this.tabPage5);
					num = 304;
					continue;
				case 1341:
					Form1.fSKvdPhXB121ntJCND9(this.guna2TabControl2, new Point(0, 0));
					num = 844;
					continue;
				case 1342:
					this.textAddonName.Size = new Size(509, 33);
					num = 424;
					continue;
				case 1343:
					Form1.wr5o3ESO7nyo3wXgm1J(this.guna2Button5.DisabledState, Color.FromArgb(169, 169, 169));
					num = 955;
					continue;
				case 1344:
					this.textAddonName.BorderRadius = 5;
					this.textAddonName.Cursor = Form1.VA4WwsiygtFFKaVPeZt();
					num = 1328;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_32f345487a004baaa2d77f4407dc7bbc == 0)
					{
						num = 236;
						continue;
					}
					continue;
				case 1345:
					this.txtLicenseType.Cursor = Form1.VA4WwsiygtFFKaVPeZt();
					num = 88;
					continue;
				case 1346:
					Form1.YU5b4UhihCdJO3ZW3gp(this.guna2BorderlessForm1, 28);
					num = 968;
					continue;
				case 1347:
					this.guna2GradientPanel3.Controls.Add(this.toggleAutoBind);
					num = 754;
					continue;
				case 1348:
					Form1.AYECD2IZo1Hm07wV025(this.DataGridSpell, new DataGridViewCellMouseEventHandler(this.sTHEVX9tZk));
					num = 390;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
					{
						num = 285;
						continue;
					}
					continue;
				case 1349:
					Form1.cjbEqXhOkHto9Mpb3TF(Form1.OROF9nCl3q4uMeX8ApH(this.tabPage5), this.toggleAutoTab);
					num = 408;
					continue;
				case 1350:
					Form1.BYULIGhFpBJPZrMGUKF(this.tabLog, Form1.Bp8crKQbU76Tg68kvQp(-1872685799 ^ -1872676589));
					num = 1146;
					continue;
				case 1351:
					Form1.gGZnrriA34hqIifEHcW(this.comboKeyboard, ComboBoxStyle.DropDownList);
					num = 262;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 != 0)
					{
						num = 900;
						continue;
					}
					continue;
				case 1352:
					this.guna2DragControl2.UseTransparentDrag = true;
					num = 181;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
					{
						num = 363;
						continue;
					}
					continue;
				case 1353:
					Form1.vH8OAmiPKT3MN4Z9ja6(this.DataGridSettings, new DataGridViewCellValidatingEventHandler(this.cdME3nlFFC));
					num = 133;
					continue;
				case 1354:
					this.ColBindBtn.ReadOnly = true;
					num = 116;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a == 0)
					{
						num = 597;
						continue;
					}
					continue;
				case 1355:
					Form1.I5salaIrpg8plUCDDAh(this.btnReGenerateAddon, 5);
					num = 677;
					continue;
				case 1356:
					Form1.fSKvdPhXB121ntJCND9(this.txtUsername, new Point(14, 31));
					num = 40;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
					{
						num = 499;
						continue;
					}
					continue;
				case 1357:
					Form1.bNdtf5ZEqUbnGHHBO8s(this.textStatus, false);
					num = 1030;
					continue;
				case 1358:
				{
					DataGridViewCellStyle dataGridViewCellStyle3;
					Form1.cCHgJfSYhohxmE8w4BT(dataGridViewCellStyle3, Color.White);
					num = 1052;
					continue;
				}
				case 1359:
					Form1.dYGjm9S6AyCC0N2dwKP(this.DataGridSettings, false);
					num = 733;
					continue;
				case 1360:
					Form1.BYULIGhFpBJPZrMGUKF(this.guna2GradientPanel1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-860087180 << 5 ^ -1752976124));
					num = 1280;
					continue;
				case 1361:
					Form1.c0T4oUhzseliJt6JbSj(this.label5, 21);
					num = 403;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 != 0)
					{
						num = 364;
						continue;
					}
					continue;
				case 1362:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.btnCancelBind, Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352736116));
					num = 1095;
					continue;
				case 1363:
					Form1.vTvWhXSNL5wYWtHE0QY(this.DataGridSpell, false);
					num = 1178;
					continue;
				case 1364:
					this.tabPage4.Controls.Add(this.menuStrip1);
					num = 739;
					continue;
				case 1365:
					Form1.GTMMr4ILDsKXD57tVjr(this.ColType, 50f);
					num = 715;
					continue;
				case 1366:
					Form1.iSOs1Zwpnwp4TrgI3NY(this.menuStrip1, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-552555469 << 5 ^ -501895242));
					num2 = 435;
					break;
				case 1367:
					this.guna2GradientPanel2.Size = new Size(919, 63);
					num = 101;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
					{
						num = 157;
						continue;
					}
					continue;
				default:
					goto IL_D7B1;
				}
				num = num2;
				continue;
				IL_D7B1:
				Form1.STG6BrIaHEj0qxrKnDQ(this.ColSettingsName, 80);
				num = 881;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00022774 File Offset: 0x00020974
		private void N4qEjP9q8I(object \u0020, PaintEventArgs \u0020)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00022778 File Offset: 0x00020978
		private void pUGEbCek1K(object \u0020, EventArgs \u0020)
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0002277C File Offset: 0x0002097C
		// Note: this type is marked as 'beforefieldinit'.
		static Form1()
		{
			int num = 6;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						Form1.AutoBindModifierList = new string[]
						{
							"",
							Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764418069),
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(996650866 + -609199087 ^ 387456643),
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-940667910 + -206218605 ^ -1146883199)
						};
						num2 = 3;
						continue;
					case 3:
						Form1.CannotUseShift = new List<string>
						{
							Form1.Bp8crKQbU76Tg68kvQp(-1860104403 ^ -1860089057),
							Form1.Bp8crKQbU76Tg68kvQp(-1406908615 ^ 676245432 ^ -2073383793),
							Form1.Bp8crKQbU76Tg68kvQp(-384868386 + 510636180 ^ 125785040),
							Form1.Bp8crKQbU76Tg68kvQp(~-531755127 ^ 531739568),
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(828767401 >> 3 ^ 103611519),
							Form1.Bp8crKQbU76Tg68kvQp(-1406908615 ^ 676245432 ^ -2073384009),
							Form1.Bp8crKQbU76Tg68kvQp(951294359 ^ 47512224 ^ 979837037),
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(828767401 >> 3 ^ 103611627),
							Form1.Bp8crKQbU76Tg68kvQp(-260489887 - 366953631 ^ -627459576),
							Form1.Bp8crKQbU76Tg68kvQp(1657092858 << 1 ^ -980797670),
							Form1.Bp8crKQbU76Tg68kvQp(1055311542 ^ 1055294884)
						};
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						Form1.WoWKeys = new Dictionary<string, string>
						{
							{
								Form1.Bp8crKQbU76Tg68kvQp(~2095831454 ^ -2095834175),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1621542659 + 1028479281 ^ -1644946018)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-902888658 ^ -902884016),
								Form1.Bp8crKQbU76Tg68kvQp(-260489887 - 366953631 ^ -627446084)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-258475567 << 4 ^ 159359140),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1388170447 ^ -1388179835)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1933679734 ^ -1218001364 ^ -1004050464),
								Form1.Bp8crKQbU76Tg68kvQp(-1224731037 ^ -1224725543)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(850579974 + 1765464631 ^ -1678929411),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886908958)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039289078),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1933679734 ^ -1218001364 ^ -1004050532)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2090212177 ^ 2090215069),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(259176490 ^ 259163622)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(--1722095099 ^ 1722099753),
								Form1.Bp8crKQbU76Tg68kvQp(-1939306647 + 173235911 ^ -1766073374)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-717857995 >> 5 ^ -22442239),
								Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553731095)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1933679734 ^ -1218001364 ^ -1004050556),
								Form1.Bp8crKQbU76Tg68kvQp(1810931007 ^ 1810931937)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1053049764 ^ -1053049175),
								Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463906591)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1765342390 ^ 1765327186),
								Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134400142)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(--1722095099 ^ 1722099715),
								Form1.Bp8crKQbU76Tg68kvQp(451337338 ^ 451338864)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510583213),
								Form1.Bp8crKQbU76Tg68kvQp(464986539 ^ 464986039)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(2066732216 ^ 2066731520),
								Form1.Bp8crKQbU76Tg68kvQp(-1366152946 ^ -1366157508)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1819523060 ^ 1064311800 ^ 1392742960),
								Form1.Bp8crKQbU76Tg68kvQp(-253515656 ^ -1789645123 ^ 1706539257)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(567103098 ^ 567111736),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1055311542 ^ 1055324404)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1218526815 ^ -1218510871),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-860087180 << 5 ^ -1752977208)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(951294359 ^ 47512224 ^ 979852665),
								Form1.Bp8crKQbU76Tg68kvQp(-283366293 ^ -283373019)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134410954),
								Form1.Bp8crKQbU76Tg68kvQp(-260489887 - 366953631 ^ -627456362)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(850579974 + 1765464631 ^ -1678929305),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1551733089 >> 2 ^ 387930626)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1526149240 >> 4 ^ 95374695),
								Form1.Bp8crKQbU76Tg68kvQp(1048347516 ^ 1048362268)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(510582717 ^ 510583259),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-553744847 ^ -553732009)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1638637009 >> 6 ^ 25595931),
								Form1.Bp8crKQbU76Tg68kvQp(-535478164 ^ -535462400)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(145144672 << 4 ^ -1972664206),
								Form1.Bp8crKQbU76Tg68kvQp(-717857995 >> 5 ^ -22442837)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-940667910 + -206218605 ^ -1146889995),
								Form1.Bp8crKQbU76Tg68kvQp(-2018852357 ^ -2018836639)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(828767401 >> 3 ^ 103579957),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1399929319 << 3 ^ 1685468460)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1002815721 ^ -877302260 ^ 261058487),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1157945476 >> 1 ^ 578966264)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1388170447 ^ -1388173775),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1089588375 ^ -1089598047)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1690522925 ^ -1690528761),
								Form1.Bp8crKQbU76Tg68kvQp(2066732216 ^ 2066737772)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(579026892 ^ 579010838),
								Form1.Bp8crKQbU76Tg68kvQp(-1755352853 ^ -1755361743)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1755352853 ^ -1755361781),
								Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764425187)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1755352853 ^ -1755361779),
								Form1.Bp8crKQbU76Tg68kvQp(-235868112 ^ -235876650)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1905767247 ^ 1905757603),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1722095099 ^ 1722100503)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(171996523 ^ 171985817),
								Form1.Bp8crKQbU76Tg68kvQp(-1406908615 ^ 676245432 ^ -2073373069)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(--2124070285 ^ 2124055413),
								Form1.Bp8crKQbU76Tg68kvQp(-1897624240 ^ -1897614424)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-613886095 << 1 ^ -1227780068),
								Form1.Bp8crKQbU76Tg68kvQp(~1005505369 ^ -1005516200)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1668754258 ^ -1668748374),
								Form1.Bp8crKQbU76Tg68kvQp(1633072087 ^ 1633062099)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993689094),
								Form1.Bp8crKQbU76Tg68kvQp(-1183576799 ^ -1183567305)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2102188928 ^ -2102191204),
								Form1.Bp8crKQbU76Tg68kvQp(881693030 + 414722879 ^ 1296401293)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-911697958 - 376275890 ^ -1287967994),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(850579974 + 1765464631 ^ -1678929025)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-33448599 >> 2 ^ -8359348),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-838478377 ^ -838473057)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1714141621 >> 6 ^ 26775984),
								Form1.Bp8crKQbU76Tg68kvQp(-260489887 - 366953631 ^ -627456096)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1810931007 ^ 1810932311),
								Form1.Bp8crKQbU76Tg68kvQp(2040894867 + -686633457 ^ 1354259658)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~744818537 ^ -744827690),
								Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679318760)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(2040894867 + -686633457 ^ 1354259660),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1005505369 ^ -1005515832)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-582433477 + 1816872807 ^ 1234449366),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(764415235 ^ 764424823)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1495818301 ^ -1495818055),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1654110737 ^ -473083753 ^ -2124753412)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1657226489 - -588572257 ^ -2049174310),
								Form1.Bp8crKQbU76Tg68kvQp(1654110737 ^ -473083753 ^ -2124753658)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1495818301 ^ -1495818171),
								Form1.Bp8crKQbU76Tg68kvQp(1933679734 ^ -1218001364 ^ -1004050980)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(679327912 ^ 679315236),
								Form1.Bp8crKQbU76Tg68kvQp(1048347516 ^ 1048362204)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1696412362 - -137042106 ^ -1559373226),
								Form1.Bp8crKQbU76Tg68kvQp(996650866 + -609199087 ^ 387462207)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1551733089 >> 2 ^ 387931034),
								Form1.Bp8crKQbU76Tg68kvQp(259176490 ^ 259164150)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-902888658 ^ -902873908),
								Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374422822)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-256932895 ^ -256928019),
								Form1.Bp8crKQbU76Tg68kvQp(1048347516 ^ 1048362118)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(579026892 ^ 579043272),
								Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463922687)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1765342390 ^ 1765325974),
								Form1.Bp8crKQbU76Tg68kvQp(-1734223699 - -1503209248 ^ -231030785)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(~344187374 ^ -344170921),
								Form1.Bp8crKQbU76Tg68kvQp(1714141621 >> 6 ^ 26799776)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-384868386 + 510636180 ^ 125784124),
								Form1.Bp8crKQbU76Tg68kvQp(145144672 << 4 ^ -1972636082)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352111144 ^ -1352127602),
								Form1.Bp8crKQbU76Tg68kvQp(1810931007 ^ 1810947433)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-384868386 + 510636180 ^ 125784108),
								Form1.Bp8crKQbU76Tg68kvQp(~344187374 ^ -344170929)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1053049764 ^ -1053033411),
								Form1.Bp8crKQbU76Tg68kvQp(-789419076 ^ -35552607 ^ 756263291)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(145144672 << 4 ^ -1972636050),
								Form1.Bp8crKQbU76Tg68kvQp(1819523060 ^ 1064311800 ^ 1392766050)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1696412362 - -137042106 ^ -1559386746),
								Form1.Bp8crKQbU76Tg68kvQp(-1668754258 ^ -1668770600)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1860104403 ^ -1860087981),
								Form1.Bp8crKQbU76Tg68kvQp(950853533 >> 3 ^ 118872973)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1654110737 ^ -473083753 ^ -2124764672),
								Form1.Bp8crKQbU76Tg68kvQp(-2018852357 ^ -2018868867)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1767032709 ^ 1767016203),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1654110737 ^ -473083753 ^ -2124764664)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--2124070285 ^ 2124086549),
								Form1.Bp8crKQbU76Tg68kvQp(-1008853611 >> 6 ^ -15779602)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(996650866 + -609199087 ^ 387468065),
								Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352757446)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1399929319 << 3 ^ 1685483620),
								Form1.Bp8crKQbU76Tg68kvQp(950853533 >> 3 ^ 118872903)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(~603785892 ^ -603802137),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--2124070285 ^ 2124086597)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1690522925 ^ -1690506745),
								Form1.Bp8crKQbU76Tg68kvQp(-1860104403 ^ -1860087857)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1520361985 >> 6 ^ -23739257),
								Form1.Bp8crKQbU76Tg68kvQp(1055311542 ^ 1055295050)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(~-1605313923 ^ 1605330058),
								Form1.Bp8crKQbU76Tg68kvQp(289037427 >> 1 ^ 144535341)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1640708702 ^ -1640725374),
								Form1.Bp8crKQbU76Tg68kvQp(1681481889 ^ 1681465739)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1055311542 ^ 1055295362),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1007749927 ^ -1007766041)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764431437),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2102188928 ^ -2102172198)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-789419076 ^ -35552607 ^ 756263031),
								Form1.Bp8crKQbU76Tg68kvQp(~-531755127 ^ 531738892)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(510582717 ^ 510565939),
								Form1.Bp8crKQbU76Tg68kvQp(1526149240 >> 4 ^ 95367839)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-506871478 - 1486829658 ^ -1993684648),
								Form1.Bp8crKQbU76Tg68kvQp(996650866 + -609199087 ^ 387467841)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1307524010 ^ -1307540086),
								Form1.Bp8crKQbU76Tg68kvQp(-1815843576 ^ -1815859994)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134385310),
								Form1.Bp8crKQbU76Tg68kvQp(145144672 << 4 ^ -1972636656)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(2066732216 ^ 2066716304),
								Form1.Bp8crKQbU76Tg68kvQp(978854837 ^ 978870657)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1881006439 >> 3 ^ 235142764),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1307524010 ^ -1307539954)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(996650866 + -609199087 ^ 387467753),
								Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352757790)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-940667910 + -206218605 ^ -1146903525),
								Form1.Bp8crKQbU76Tg68kvQp(171996523 ^ 171980737)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(950853533 >> 3 ^ 118872377),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(171996523 ^ 171980727)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(764415235 ^ 764432365),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1053049764 ^ -1053032613)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1495818301 ^ -1495802671),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-506871478 - 1486829658 ^ -1993684012)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-87166655 + -2142521002 ^ 2065295777),
								Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553728647)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-825446221 ^ -825429015),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(152750669 ^ 152733985)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(145144672 << 4 ^ -1972636290),
								Form1.Bp8crKQbU76Tg68kvQp(2066732216 ^ 2066716456)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1767032709 ^ 1767015463),
								Form1.Bp8crKQbU76Tg68kvQp(451337338 ^ 451321806)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(457652205 ^ 457667627),
								Form1.Bp8crKQbU76Tg68kvQp(881693030 + 414722879 ^ 1296433021)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1668754258 ^ -1668769980),
								Form1.Bp8crKQbU76Tg68kvQp(-1939306647 + 173235911 ^ -1766087220)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(828767401 >> 3 ^ 103611291),
								Form1.Bp8crKQbU76Tg68kvQp(1074597531 ^ 1074612923)
							},
							{
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1621542659 + 1028479281 ^ -1644927994),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(567103098 ^ 567085630)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1352740968 ^ -1352758278),
								Form1.Bp8crKQbU76Tg68kvQp(-1089588375 ^ -1089597997)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(-1640708702 ^ -1640697902),
								Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764430719)
							},
							{
								Form1.Bp8crKQbU76Tg68kvQp(1681481889 ^ 1681466421),
								vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1388170447 ^ -1388152935)
							}
						};
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						goto IL_16C2;
					case 6:
						vua32v5yjQhjRjK4YIO.aep5UvAyyY();
						num2 = 5;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					Form1.AutoBindList = new string[]
					{
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1992869118 ^ -1992883058),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789526908),
						Form1.Bp8crKQbU76Tg68kvQp(-693910567 ^ -693895775),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1755352853 ^ -1755361717),
						Form1.Bp8crKQbU76Tg68kvQp(828767401 >> 3 ^ 103579843),
						Form1.Bp8crKQbU76Tg68kvQp(1048347516 ^ 1048362102),
						Form1.Bp8crKQbU76Tg68kvQp(-553744847 ^ -553731795),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-552555469 << 5 ^ -501892702),
						Form1.Bp8crKQbU76Tg68kvQp(-253515656 ^ -1789645123 ^ 1706539499),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(451337338 ^ 451320046),
						Form1.Bp8crKQbU76Tg68kvQp(-1041647104 ^ -1041657744),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2090212177 ^ 2090229603),
						Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134383760),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2090212177 ^ 2090227955),
						Form1.Bp8crKQbU76Tg68kvQp(-902888658 ^ -902872856),
						Form1.Bp8crKQbU76Tg68kvQp(-1734223699 - -1503209248 ^ -231031769),
						Form1.Bp8crKQbU76Tg68kvQp(~744818537 ^ -744834144),
						Form1.Bp8crKQbU76Tg68kvQp(764415235 ^ 764431961),
						Form1.Bp8crKQbU76Tg68kvQp(-764151834 ^ -764169064),
						Form1.Bp8crKQbU76Tg68kvQp(-1505789866 ^ -1505805668),
						Form1.Bp8crKQbU76Tg68kvQp(1881006439 >> 3 ^ 235142850),
						Form1.Bp8crKQbU76Tg68kvQp(1714141621 >> 6 ^ 26799604),
						Form1.Bp8crKQbU76Tg68kvQp(-1374435438 ^ -1374452476),
						Form1.Bp8crKQbU76Tg68kvQp(567103098 ^ 567086096),
						Form1.Bp8crKQbU76Tg68kvQp(~463906284 ^ -463922405),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-902888658 ^ -902872562),
						Form1.Bp8crKQbU76Tg68kvQp(-1505789866 ^ -1505805982),
						Form1.Bp8crKQbU76Tg68kvQp(-911697958 - 376275890 ^ -1287957146),
						Form1.Bp8crKQbU76Tg68kvQp(-693910567 ^ -693927245),
						Form1.Bp8crKQbU76Tg68kvQp(1055311542 ^ 1055295216),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-825446221 ^ -825429763),
						Form1.Bp8crKQbU76Tg68kvQp(-825446221 ^ -825429787),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1722095099 ^ 1722111397),
						Form1.Bp8crKQbU76Tg68kvQp(828767401 >> 3 ^ 103612403),
						Form1.Bp8crKQbU76Tg68kvQp(-1007749927 ^ -1007766345),
						Form1.Bp8crKQbU76Tg68kvQp(-161182833 ^ -161166343),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(259176490 ^ 259192916),
						Form1.Bp8crKQbU76Tg68kvQp(268802365 >> 1 ^ 134384664),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~-1605313923 ^ 1605330188),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-825446221 ^ -825429973),
						Form1.Bp8crKQbU76Tg68kvQp(-256932895 ^ -256916669),
						vua32v5yjQhjRjK4YIO.BRA5TcZvlv(268206341 ^ 268221665),
						Form1.Bp8crKQbU76Tg68kvQp(~-1482987862 ^ 1482990765)
					};
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 == 0)
					{
						num2 = 0;
					}
				}
				IL_16C2:
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				Form1.CDo8HXCVVJibMvMqBvF();
				num = 4;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00023E68 File Offset: 0x00022068
		[CompilerGenerated]
		private Task u1xEzCrJH1()
		{
			Form1.<<InitializeRotationSettings>b__39_0>d <<InitializeRotationSettings>b__39_0>d;
			<<InitializeRotationSettings>b__39_0>d.<>t__builder = Form1.uHZ3cfZLmqsjg5RooWH();
			<<InitializeRotationSettings>b__39_0>d.<>4__this = this;
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 != 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					<<InitializeRotationSettings>b__39_0>d.<>t__builder.Start<Form1.<<InitializeRotationSettings>b__39_0>d>(ref <<InitializeRotationSettings>b__39_0>d);
					num = 2;
					continue;
				case 2:
					goto IL_8C;
				}
				<<InitializeRotationSettings>b__39_0>d.<>1__state = -1;
				num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
				{
					num = 1;
				}
			}
			IL_8C:
			return <<InitializeRotationSettings>b__39_0>d.<>t__builder.Task;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00023F10 File Offset: 0x00022110
		internal static object iL51BVQjDDFv8h51MTQ(object A_0, object A_1)
		{
			return string.Join(A_0, A_1);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00023F20 File Offset: 0x00022120
		internal static bool mKiNRJQDOVTKDN2u5W2()
		{
			return Form1.DZ0WUqQBPfg6ulLNkXV == null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00023F2C File Offset: 0x0002212C
		internal static Form1 LL5lO3QvO32B1Ytjwld()
		{
			return Form1.DZ0WUqQBPfg6ulLNkXV;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00023F34 File Offset: 0x00022134
		internal static object Bp8crKQbU76Tg68kvQp(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00023F40 File Offset: 0x00022140
		internal static int Of4KHkQzwdMbXcku9yf(object A_0, int A_1, int A_2)
		{
			return A_0.Next(A_1, A_2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00023F54 File Offset: 0x00022154
		internal static object xv1g48CWlI8vVbXlHcX(object A_0)
		{
			return Image.FromFile(A_0);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00023F60 File Offset: 0x00022160
		internal static object Bj5kyqCPWxnFPEQJGPe(object A_0, int A_1, int A_2, object A_3, IntPtr A_4)
		{
			return A_0.GetThumbnailImage(A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00023F7C File Offset: 0x0002217C
		internal static void r2qrNWCEYHb1avWEaL1(object A_0)
		{
			A_0.MakeTransparent();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00023F88 File Offset: 0x00022188
		internal static IntPtr my3DbMCcXZbYCmecXeg(object A_0)
		{
			return A_0.GetHicon();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00023F94 File Offset: 0x00022194
		internal static object Aa13RWC5p96ZAdLTQUD(IntPtr A_0)
		{
			return Icon.FromHandle(A_0);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00023FA0 File Offset: 0x000221A0
		internal static void ccKgXrCx2StFhg4s46p(object A_0, object A_1)
		{
			A_0.Icon = A_1;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00023FB0 File Offset: 0x000221B0
		internal static void PwaWInCuQyb2BJJJoIR()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00023FB8 File Offset: 0x000221B8
		internal static void CDo8HXCVVJibMvMqBvF()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00023FC0 File Offset: 0x000221C0
		internal static void htxL3fCyLlCk5SrYoDM(object A_0, ColorDepth A_1)
		{
			A_0.ColorDepth = A_1;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00023FD0 File Offset: 0x000221D0
		internal static void YVdnPmC8Fdoibuo8lAN(object A_0, Size A_1)
		{
			A_0.ImageSize = A_1;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00023FE0 File Offset: 0x000221E0
		internal static object GaMaotCqWxchpV0yRLI(object A_0)
		{
			return A_0.Images;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00023FEC File Offset: 0x000221EC
		internal static object vbs04YCdZsieDgf7KmL()
		{
			return Resources.rpg_game;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00023FF4 File Offset: 0x000221F4
		internal static object jhpoyQCoFNajNh754ly()
		{
			return Resources.document;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00023FFC File Offset: 0x000221FC
		internal static void yeEr8KC3tmD8prHDjCB(object A_0, object A_1)
		{
			A_0.Add(A_1);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0002400C File Offset: 0x0002220C
		internal static object RAiKYsCQ2wMSh7DlDF3()
		{
			return Resources.keyboard__3_;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00024014 File Offset: 0x00022214
		internal static object WDUPtKCCDw4KSKvvjb4()
		{
			return Resources.favourite;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0002401C File Offset: 0x0002221C
		internal static void yhxkS5C9aXPyOelZpN6(object A_0, object A_1)
		{
			A_0.ImageList = A_1;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0002402C File Offset: 0x0002222C
		internal static object HQlak7CwOROmoBKpVmu()
		{
			return Resources.UbuntuMono_Regular;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00024034 File Offset: 0x00022234
		internal static void zh2Jv8CATF85TWtqJI6(object A_0, int A_1, IntPtr A_2, int A_3)
		{
			Marshal.Copy(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0002404C File Offset: 0x0002224C
		internal static void Ew4uvHChfJ5UO6bBn6n(object A_0, IntPtr A_1, int A_2)
		{
			A_0.AddMemoryFont(A_1, A_2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00024060 File Offset: 0x00022260
		internal static object b93dlyCSswkm6GuUpmV()
		{
			return Resources.Marine_Regular;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00024068 File Offset: 0x00022268
		internal static void zEOOHQCIOvrgTrDAGWE(IntPtr A_0)
		{
			Marshal.FreeCoTaskMem(A_0);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00024074 File Offset: 0x00022274
		internal static object UbuLBZCiIdYYPfR8hM4()
		{
			return Resources.Magistral_Book;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0002407C File Offset: 0x0002227C
		internal static IntPtr cHCHwsCZDgihOO79EbS(int A_0)
		{
			return Marshal.AllocCoTaskMem(A_0);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00024088 File Offset: 0x00022288
		internal static object Rd8iRYCUDaMrjvhgZZM()
		{
			return Resources.Magistral_Bold;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00024090 File Offset: 0x00022290
		internal static object Cc3ITiC1MaI7qrQHlZg()
		{
			return Resources.Marine_Bold;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00024098 File Offset: 0x00022298
		internal static object B5t9xvCpPTNI9krvIau(object A_0)
		{
			return A_0.Families;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000240A4 File Offset: 0x000222A4
		internal static void F8DDPrC4dhV11PnsIC6(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000240B4 File Offset: 0x000222B4
		internal static object kHr34aCONeoYV2e6tqZ(object A_0)
		{
			return A_0.Font;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000240C0 File Offset: 0x000222C0
		internal static float iwndZfCfoQap3URLrTC(object A_0)
		{
			return A_0.Size;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000240CC File Offset: 0x000222CC
		internal static void wEyJSbCFacgSXItvROk(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000240DC File Offset: 0x000222DC
		internal static void ncynG5CT8UsyjBsDC3f(object A_0, bool A_1)
		{
			A_0.ShowCellToolTips = A_1;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000240EC File Offset: 0x000222EC
		internal static object nJDCuJCRrgUeFA82EQZ(object A_0)
		{
			return A_0.GetEnumerator();
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000240F8 File Offset: 0x000222F8
		internal static object ocqRt1CLNxqeknLG33w(object A_0)
		{
			return ((IEnumerator)A_0).Current;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00024104 File Offset: 0x00022304
		internal static object OROF9nCl3q4uMeX8ApH(object A_0)
		{
			return A_0.Controls;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00024110 File Offset: 0x00022310
		internal static bool AWksX3CaF27NUnPDnvS(object A_0)
		{
			return ((IEnumerator)A_0).MoveNext();
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0002411C File Offset: 0x0002231C
		internal static void TX4EfrCKNxMbkrcZehx(object A_0)
		{
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00024128 File Offset: 0x00022328
		internal static AsyncVoidMethodBuilder p1LuAOCetKbs7pSxl81()
		{
			return AsyncVoidMethodBuilder.Create();
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00024130 File Offset: 0x00022330
		internal static object bkc6gMCkJ6B4GSDpZR9(object A_0)
		{
			return icdoeGQQtZwolxBdqe.yKc1JfyrE(A_0);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0002413C File Offset: 0x0002233C
		internal static DialogResult YcZQDGCrd604D2KnaUs(object A_0, object A_1, object A_2, MessageBoxButtons A_3, MessageBoxIcon A_4)
		{
			return MessageBox.Show(A_0, A_1, A_2, A_3, A_4);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00024158 File Offset: 0x00022358
		internal static object Pp4QKUC71vtkcGEBPyV(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00024168 File Offset: 0x00022368
		internal static object z4yfFkC2QcWXXQG7aMx()
		{
			return Assembly.GetExecutingAssembly();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00024170 File Offset: 0x00022370
		internal static object MZkk37C6N2MRGVPg3wl(object A_0)
		{
			return A_0.Location;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0002417C File Offset: 0x0002237C
		internal static object LUR5vMCNLulnOAoYLUD(object A_0)
		{
			return Path.GetDirectoryName(A_0);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00024188 File Offset: 0x00022388
		internal static object ECjoxLCnKi1kGfesUXO(object A_0, object A_1)
		{
			return Path.Combine(A_0, A_1);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00024198 File Offset: 0x00022398
		internal static object O1Q87IC0MLP2DPdBqmx()
		{
			return icdoeGQQtZwolxBdqe.Da6STDcvv();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000241A0 File Offset: 0x000223A0
		internal static object JreG9FCJDuB09aS2wIs(object A_0, object A_1, object A_2, object A_3)
		{
			return A_0.GetValue(A_1, A_2, A_3);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000241B8 File Offset: 0x000223B8
		internal static object UxjaDkCmutc5QJXE7Mj()
		{
			return icdoeGQQtZwolxBdqe.Qnow9skY1();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000241C0 File Offset: 0x000223C0
		internal static DialogResult Hm39RACHCHBBu0j5C3L(object A_0)
		{
			return A_0.ShowDialog();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000241CC File Offset: 0x000223CC
		internal static DialogResult PamqU2CtDmFnvOAlqmr(object A_0)
		{
			return MessageBox.Show(A_0);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000241D8 File Offset: 0x000223D8
		internal static object dL7f3BCYsvs5WvdCOPK(object A_0)
		{
			return A_0.Text;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000241E4 File Offset: 0x000223E4
		internal static void xZBP3cCshH5lcITFW7O(object A_0)
		{
			A_0.Pulse();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000241F0 File Offset: 0x000223F0
		internal static int QUORgpCgkRIM8fePjQB(object A_0)
		{
			return A_0.SpellId;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000241FC File Offset: 0x000223FC
		internal static bool R25qmmCXN2J9g6WCi7p(object A_0, object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002420C File Offset: 0x0002240C
		internal static void SnT5xGCMapUAIVcnOPs(object A_0, object A_1)
		{
			A_0._ProgrammaticCast(A_1);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002421C File Offset: 0x0002241C
		internal static object K9Pe9MCGnvxj9HG2tCV(object A_0, object A_1, object A_2)
		{
			return A_0 + A_1 + A_2;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00024230 File Offset: 0x00022430
		internal static int eIlRfICBG8T4hp42Atx(object A_0)
		{
			return A_0.ItemId;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0002423C File Offset: 0x0002243C
		internal static object Aae7UcCDXg5aDtUfeAM(object A_0, int itemId)
		{
			return A_0._GetItemKeybind(itemId);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0002424C File Offset: 0x0002244C
		internal static object eR4IbwCvGKOICfdxxUZ(object A_0)
		{
			return string.Concat(A_0);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00024258 File Offset: 0x00022458
		internal static object F05MgDCjWlGHhEaoK7T(object A_0)
		{
			return A_0.MacroName;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00024264 File Offset: 0x00022464
		internal static bool t0poRRCb3dy0hjmaGAe(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00024274 File Offset: 0x00022474
		internal static void tguPeVCzRe0O5dnbe3w(object A_0, object A_1)
		{
			A_0.xrtcSrwrsS(A_1);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00024284 File Offset: 0x00022484
		internal static bool JYJDmA9WailJDaAwjJU(object A_0)
		{
			return A_0.InvokeRequired;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00024290 File Offset: 0x00022490
		internal static object HQRrBT9PKpv5VrOTZd9(object A_0, object A_1, object A_2)
		{
			return A_0.Invoke(A_1, A_2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000242A4 File Offset: 0x000224A4
		internal static DateTime Tk6SeD9ENWhOjXlRDZj()
		{
			return DateTime.Now;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000242AC File Offset: 0x000224AC
		internal static void rAuZQ69cjt14Aowg3ql(object A_0, object A_1)
		{
			A_0.AppendText(A_1);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000242BC File Offset: 0x000224BC
		internal static void TQW4mo95LTjdIcaZtKR(object A_0, object A_1)
		{
			File.AppendAllText(A_0, A_1);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000242CC File Offset: 0x000224CC
		internal static object kwR7CG9xd04qDvwY5y6(object A_0)
		{
			return A_0.Lines;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000242D8 File Offset: 0x000224D8
		internal static void eNBQOZ9uWGAashSF6eX(object A_0, object A_1)
		{
			A_0.Lines = A_1;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000242E8 File Offset: 0x000224E8
		internal static object ClqSlp9VPgVT4Q4yauG(object A_0)
		{
			return File.ReadAllText(A_0);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000242F4 File Offset: 0x000224F4
		internal static object kOc5F69yJ86BNFa86ex(object A_0, object A_1)
		{
			return string.Format(A_0, A_1);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00024304 File Offset: 0x00022504
		internal static object S4fI7n98VeDLqrofMh3(object A_0)
		{
			return A_0.Message;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00024310 File Offset: 0x00022510
		internal static bool hmoH8S9qggmufh0cX8H(object A_0)
		{
			return A_0.Checked;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0002431C File Offset: 0x0002251C
		internal static int M1NYUr9dQRdhwvcp9Ub(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00024328 File Offset: 0x00022528
		internal static object OVBZrb9ojeyna2RDdQV(object A_0)
		{
			return A_0.Rows;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00024334 File Offset: 0x00022534
		internal static int n0TXku93uqD8ldIhtAU(object A_0)
		{
			return A_0.Add();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00024340 File Offset: 0x00022540
		internal static int VuXCjt9QTRVabsm0Q0q(object A_0)
		{
			return A_0.SelectedIndex;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0002434C File Offset: 0x0002254C
		internal static object ou1LFn9CnJlfE3Jsl57(object A_0)
		{
			return A_0.Cells;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00024358 File Offset: 0x00022558
		internal static object ug99IX99DgGu6ej4UWl(object A_0, object A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00024368 File Offset: 0x00022568
		internal static void ze7t0E9w2LsX5xTVcPJ(object A_0, object A_1)
		{
			A_0.Value = A_1;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00024378 File Offset: 0x00022578
		internal static void Pm37Al9AFmk2r038rJP(object A_0, object A_1)
		{
			A_0.Tag = A_1;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00024388 File Offset: 0x00022588
		internal static object lkI3An9h4MMoumNf3eC(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00024398 File Offset: 0x00022598
		internal static int Jf4yM19S9e6PagK7Ua6(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000243A4 File Offset: 0x000225A4
		internal static object YfVuPM9IOO9J2dZfQI1()
		{
			return Resources.trade_engineering;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000243AC File Offset: 0x000225AC
		internal static object vPMnx19iyvGR7LPR7VD()
		{
			return Resources.click;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000243B4 File Offset: 0x000225B4
		internal static int bivtut9ZTVL3yFc6hxt(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000243C0 File Offset: 0x000225C0
		internal static object BY2tjA9UXGPZOAf0dBk(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000243D0 File Offset: 0x000225D0
		internal static void UkSXdn911SSi2g6aYmO(object A_0, object A_1)
		{
			A_0.Tag = A_1;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000243E0 File Offset: 0x000225E0
		internal static void qYVKgb9puAV9MnSNafW(object A_0, object A_1)
		{
			A_0.ToolTipText = A_1;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000243F0 File Offset: 0x000225F0
		internal static void aHxrU194hTCElcZl7GK(object A_0, int A_1)
		{
			A_0.MaxInputLength = A_1;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00024400 File Offset: 0x00022600
		internal static void QLQ5bP9OmmP2XdLtuP7(object A_0, int A_1, object A_2)
		{
			A_0[A_1] = A_2;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00024414 File Offset: 0x00022614
		internal static object mT7yA59fEsvRQPaqowU(object A_0)
		{
			return A_0.Items;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00024420 File Offset: 0x00022620
		internal static void VTLYQo9Fvvx2PVEKJvR(object A_0, object A_1)
		{
			A_0.AddRange(A_1);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00024430 File Offset: 0x00022630
		internal static object GSWLte9T8QA1V1QV6BA(object A_0)
		{
			return A_0.ToArray();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0002443C File Offset: 0x0002263C
		internal static object EgRD1y9R0gmcbIMx29L(object A_0)
		{
			return A_0.ToArray();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00024448 File Offset: 0x00022648
		internal static object O8qjlc9LqAOYURuI3cp(object A_0)
		{
			return A_0.Version;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00024454 File Offset: 0x00022654
		internal static bool vBOHXp9l4X6t1ftHRyp(object A_0)
		{
			return A_0.HealingRotation;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00024460 File Offset: 0x00022660
		internal static int nv6npl9aKjnqZefm9T5(object A_0)
		{
			return A_0.RowCount;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0002446C File Offset: 0x0002266C
		internal static object pcPY5y9KGlwdMXMKiKS(object A_0)
		{
			return A_0.Value;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00024478 File Offset: 0x00022678
		internal static object C34fSD9eBoX3mFWsdS9(object A_0)
		{
			return A_0.Text;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00024484 File Offset: 0x00022684
		internal static object KeGMkh9k3wWtJuTwR6v(object A_0, object A_1, object A_2)
		{
			return A_0.Replace(A_1, A_2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00024498 File Offset: 0x00022698
		internal static bool hQ2ZTb9rR1X4L1j8WZE(object A_0, object A_1)
		{
			return A_0.Contains(A_1);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000244A8 File Offset: 0x000226A8
		internal static bool yPJO1R97UVt1wSq3mkW(object A_0)
		{
			return Directory.Exists(A_0);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000244B4 File Offset: 0x000226B4
		internal static object MemHBp92QvU2RQyb8SZ(object A_0)
		{
			return JsonConvert.SerializeObject(A_0);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000244C0 File Offset: 0x000226C0
		internal static object iqL1Pn96yiNTT5Ebe8R(object A_0)
		{
			return A_0.DefaultRequestHeaders;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000244CC File Offset: 0x000226CC
		internal static void H3NFNt9NSNX8XWJpBNr(object A_0, object A_1, object A_2)
		{
			A_0.Add(A_1, A_2);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000244E0 File Offset: 0x000226E0
		internal static object WMrrh19npvwTJaYhTvb()
		{
			return Encoding.UTF8;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000244E8 File Offset: 0x000226E8
		internal static bool EfLCsT90cDsYMKf0SMe(object A_0)
		{
			return A_0.IsSuccessStatusCode;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000244F4 File Offset: 0x000226F4
		internal static object Iao2ih9J9mkhFrdI4vw(object A_0)
		{
			return A_0.Content;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00024500 File Offset: 0x00022700
		internal static object Cj7omJ9mldksKr3kMYx(object A_0)
		{
			return Directory.CreateDirectory(A_0);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0002450C File Offset: 0x0002270C
		internal static object YNLgDQ9H3N5sF2omwls(object A_0)
		{
			return Convert.FromBase64String(A_0);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00024518 File Offset: 0x00022718
		internal static object HVIBP89trVUInd61kbk(object A_0, object A_1)
		{
			return A_0.GetString(A_1);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00024528 File Offset: 0x00022728
		internal static void W3fsFw9YlpEyHyS6P5v(object A_0, object A_1, object A_2)
		{
			File.WriteAllText(A_0, A_1, A_2);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0002453C File Offset: 0x0002273C
		internal static void q054c59sprWGHa2INgJ(object A_0, int R, int G, int B)
		{
			A_0._SetCheckPixels(R, G, B);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00024554 File Offset: 0x00022754
		internal static void Kkf2lh9gFFtl0X8OnPB(object A_0, bool A_1)
		{
			A_0.Enabled = A_1;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00024564 File Offset: 0x00022764
		internal static HttpStatusCode E0ad0c9Xp3Km6FgC2i7(object A_0)
		{
			return A_0.StatusCode;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00024570 File Offset: 0x00022770
		internal static bool A8qQK69MwoTyxr0lqBr(object A_0)
		{
			return string.IsNullOrWhiteSpace(A_0);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0002457C File Offset: 0x0002277C
		internal static void D0SEq59GiW0DLYLsp4b(object A_0, int A_1)
		{
			A_0.SelectTab(A_1);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0002458C File Offset: 0x0002278C
		internal static void HeD8SA9BKy4H7DNP3bb(object A_0, bool A_1)
		{
			A_0.GenerateExecutable = A_1;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0002459C File Offset: 0x0002279C
		internal static Type ewK0m59DeeWnE6RHcvv(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000245A8 File Offset: 0x000227A8
		internal static object QkNBnZ9vbk4MjBDixMT(object A_0)
		{
			return A_0.FullName;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000245B4 File Offset: 0x000227B4
		internal static RuntimeTypeHandle pHJddX9jNf3s9CAWG8N(int token)
		{
			return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000245C0 File Offset: 0x000227C0
		internal static object Aw2LLk9bgSh17C9eowC(object A_0)
		{
			return A_0.ReferencedAssemblies;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000245CC File Offset: 0x000227CC
		internal static void knhZ8F9zsnwXBsJJ7Aa(object A_0, object A_1)
		{
			A_0.AddRange(A_1);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000245DC File Offset: 0x000227DC
		internal static object bhmI45wWenwVdaFOg0o(object A_0, object A_1, object A_2)
		{
			return A_0.CompileAssemblyFromSource(A_1, A_2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000245F0 File Offset: 0x000227F0
		internal static object eI4MZ4wPyCHku7j7w7Q(object A_0)
		{
			return A_0.Errors;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000245FC File Offset: 0x000227FC
		internal static int zOqwP4wEDEGDTn6Rb4q(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00024608 File Offset: 0x00022808
		internal static object bQkfm0wcy2aHQGWvITH(object A_0)
		{
			return A_0.GetEnumerator();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00024614 File Offset: 0x00022814
		internal static object Q1mXpDw5XrPNoHCtUIq(object A_0, object A_1, object A_2)
		{
			return string.Format(A_0, A_1, A_2);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00024628 File Offset: 0x00022828
		internal static object qrpKgdwxqN1NdIQdKHp(object A_0)
		{
			return A_0.GetTypes();
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00024634 File Offset: 0x00022834
		internal static object Bh1gb9wupfk4LEKmKWc(Type A_0)
		{
			return Activator.CreateInstance(A_0);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00024640 File Offset: 0x00022840
		internal static void T19uCXwVH28rOQKbQEo(object A_0)
		{
			A_0.Refresh();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0002464C File Offset: 0x0002284C
		internal static void gPQJPBwyEyMsJ2t08lw(object A_0)
		{
			A_0.Clear();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00024658 File Offset: 0x00022858
		internal static void sUjhuww8NXuIRvabnt2(object A_0)
		{
			A_0.Initialize();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00024664 File Offset: 0x00022864
		internal static bool AZK5cIwqqmGNHPDYmtM(object A_0)
		{
			return File.Exists(A_0);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00024670 File Offset: 0x00022870
		internal static object gSCRVtwdibsMxy3ZA7F(object A_0)
		{
			return A_0.StartInfo;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0002467C File Offset: 0x0002287C
		internal static void qmbWLhwoeZnX4ZBTNau(object A_0, object A_1)
		{
			A_0.FileName = A_1;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0002468C File Offset: 0x0002288C
		internal static void nJ9YMdw3yyHE0IeE5vC(object A_0, object A_1)
		{
			A_0.Arguments = A_1;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0002469C File Offset: 0x0002289C
		internal static void lCLPn4wQmOtT0KkyGgm(object A_0, ProcessWindowStyle A_1)
		{
			A_0.WindowStyle = A_1;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000246AC File Offset: 0x000228AC
		internal static void sI79t2wCWsu7Tumo2yW(object A_0, bool A_1)
		{
			A_0.RedirectStandardError = A_1;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000246BC File Offset: 0x000228BC
		internal static void rCn5X2w9u3TSRhNXPde(object A_0, bool A_1)
		{
			A_0.CreateNoWindow = A_1;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000246CC File Offset: 0x000228CC
		internal static bool sM0Yavww8yIdf81aRXq(object A_0)
		{
			return A_0.Start();
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000246D8 File Offset: 0x000228D8
		internal static object GVh1f2wAPaF4Ufp7Ub4(object A_0)
		{
			return A_0.ReadToEnd();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000246E4 File Offset: 0x000228E4
		internal static object MXxNjTwhZN9psiFirA3(object A_0)
		{
			return A_0.StandardError;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000246F0 File Offset: 0x000228F0
		internal static void dVsfuOwS4qFf6ikHRiY(object A_0)
		{
			A_0.WaitForExit();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000246FC File Offset: 0x000228FC
		internal static void vLsqXrwIGmhVc2NjlCh(object A_0, bool A_1)
		{
			A_0.Visible = A_1;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0002470C File Offset: 0x0002290C
		internal static void v5COPWwi2eCOL5fBEpU(object A_0, object A_1)
		{
			A_0.Text = A_1;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0002471C File Offset: 0x0002291C
		internal static object iAw4jCwZ2rrmM3NSXjo()
		{
			return Resources.sleeping;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00024724 File Offset: 0x00022924
		internal static void UItrdLwU1vRfSfQhlDs(object A_0, object A_1)
		{
			A_0.Image = A_1;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00024734 File Offset: 0x00022934
		internal static void PNVsMCw1D5ZEZdSk8wJ(object A_0, bool A_1)
		{
			A_0.Enabled = A_1;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00024744 File Offset: 0x00022944
		internal static void iSOs1Zwpnwp4TrgI3NY(object A_0, object A_1)
		{
			A_0.Text = A_1;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00024754 File Offset: 0x00022954
		internal static Color Y1UIkkw4SWDmFnSC63U(int A_0, int A_1, int A_2)
		{
			return Color.FromArgb(A_0, A_1, A_2);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00024768 File Offset: 0x00022968
		internal static void b0EJIhwOxZFnSyTHl3t(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00024778 File Offset: 0x00022978
		internal static void Sv1WQbwf5nFmk6BuCdD(object A_0, Color A_1)
		{
			A_0.FillColor2 = A_1;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00024788 File Offset: 0x00022988
		internal static object UW559kwFspTgAGXicuC()
		{
			return Resources.play;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00024790 File Offset: 0x00022990
		internal static bool SwdjYEwTTDc7l6IAKcI(object A_0)
		{
			return A_0.Enabled;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0002479C File Offset: 0x0002299C
		internal static void J9JiEZwRU7OOsHQqQGj(object A_0, MessageDialogIcon A_1)
		{
			A_0.Icon = A_1;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000247AC File Offset: 0x000229AC
		internal static DialogResult wBtRtdwLtN599Ci7kp7(object A_0)
		{
			return A_0.Show();
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000247B8 File Offset: 0x000229B8
		internal static CommonFileDialogResult Wy8KOUwlyVZy2EfGZpX(object A_0)
		{
			return A_0.ShowDialog();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000247C4 File Offset: 0x000229C4
		internal static object r7R9ASwa70Hp12oeIES(object A_0)
		{
			return A_0.SelectedItems;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000247D0 File Offset: 0x000229D0
		internal static object MgOsqHwKnr0xGhdS5E0(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000247E0 File Offset: 0x000229E0
		internal static object SnLjCmweoIc1jgcm8Oi(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000247F0 File Offset: 0x000229F0
		internal static object hYHrEswknLW9n6JvQfY(object A_0)
		{
			return A_0.Text;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000247FC File Offset: 0x000229FC
		internal static object nEGpV3wrtMWl4QMjGvA(object A_0)
		{
			return A_0.Text;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00024808 File Offset: 0x00022A08
		internal static object bS0UYLw7HwicoyCY5HU(object A_0)
		{
			return A_0.Items;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00024814 File Offset: 0x00022A14
		internal static int Dk5U3Pw2eyFPjgn6a6Q(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00024820 File Offset: 0x00022A20
		internal static object e7YffHw6rpIQnREW2gH(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00024830 File Offset: 0x00022A30
		internal static object jaVJwbwNH3YGplDDAt0(object A_0)
		{
			return A_0.ToLower();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0002483C File Offset: 0x00022A3C
		internal static object OIRLQ6wnLJqC8sB9M1D(object A_0, object A_1)
		{
			return A_0.Add(A_1);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0002484C File Offset: 0x00022A4C
		internal static object rSbKNrw0JjGG0pTWuWN(object A_0)
		{
			return A_0.SubItems;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00024858 File Offset: 0x00022A58
		internal static void dqlXqlwJW7DeFVLCb8n(object A_0, object A_1, object A_2, object A_3)
		{
			A_0.SetValue(A_1, A_2, A_3);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00024870 File Offset: 0x00022A70
		internal static void qhySZ1wm2U3O24tPP01(object A_0, object A_1)
		{
			A_0.InitialDirectory = A_1;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00024880 File Offset: 0x00022A80
		internal static void I3iPMqwHpab4n2JrZOx(object A_0, bool A_1)
		{
			A_0.IsFolderPicker = A_1;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00024890 File Offset: 0x00022A90
		internal static object uZnAk6wtpQNcHXbqqWb(object A_0)
		{
			return A_0.Filters;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0002489C File Offset: 0x00022A9C
		internal static void EaqCr3wYwj8s8ef9lTX(object A_0, bool A_1)
		{
			A_0.Enabled = A_1;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000248AC File Offset: 0x00022AAC
		internal static int UfluBywsWTuHLy3r4xI(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000248B8 File Offset: 0x00022AB8
		internal static Keys CigDHrwg9cN7ubZxisW(object A_0)
		{
			return A_0.KeyCode;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000248C4 File Offset: 0x00022AC4
		internal static object by3dlKwXHA90Foj4ht1(object A_0)
		{
			return Process.Start(A_0);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000248D0 File Offset: 0x00022AD0
		internal static object jCAxm7wM3ZGPkj7Rpmx(object A_0)
		{
			return A_0.Columns;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000248DC File Offset: 0x00022ADC
		internal static int fyqaZpwG9rn6JoNyMFh(object A_0)
		{
			return A_0.ColumnIndex;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000248E8 File Offset: 0x00022AE8
		internal static object xmlyIZwBrCvjcnmAewP(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000248F8 File Offset: 0x00022AF8
		internal static int RTCKYiwDUxx2CWFs9Xr(object A_0)
		{
			return A_0.RowIndex;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00024904 File Offset: 0x00022B04
		internal static bool tphZQZwvIW3ycDZ8MxO(object A_0)
		{
			return A_0.isCtrlPressed;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00024910 File Offset: 0x00022B10
		internal static bool wwyinjwjYFEZbP3eSk9(object A_0)
		{
			return A_0.isShiftPressed;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0002491C File Offset: 0x00022B1C
		internal static Keys JOeMOtwbVjvSGnSYbHA(object A_0)
		{
			return A_0.Key;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00024928 File Offset: 0x00022B28
		internal static object PfOUHRwzGl6YKvQPWO8(object A_0, object A_1)
		{
			return A_0.ConvertToString(A_1);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00024938 File Offset: 0x00022B38
		internal static void PEPZVxAWWQQspQuoWWB(object A_0)
		{
			A_0.Hide();
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00024944 File Offset: 0x00022B44
		internal static void YR746FAPR19rQo7v20x(object A_0, object A_1)
		{
			A_0._PlayerManualCast(A_1);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00024954 File Offset: 0x00022B54
		internal static object NNB2gjAEJQ8lcLOwdaL(object A_0, int A_1, int A_2)
		{
			return A_0.Substring(A_1, A_2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00024968 File Offset: 0x00022B68
		internal static object A6TDSQAcKqRqD1mtmGh(object A_0, object A_1)
		{
			return A_0.GetBytes(A_1);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00024978 File Offset: 0x00022B78
		internal static object qlQRLCA5dcYXyTYPoLX(object A_0, object A_1)
		{
			return A_0.ComputeHash(A_1);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00024988 File Offset: 0x00022B88
		internal static object bojNR6AxVgsJ3A8NLLT(object A_0, object A_1, object A_2, object A_3)
		{
			return A_0 + A_1 + A_2 + A_3;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000249A0 File Offset: 0x00022BA0
		internal static void xWgqMhAuItN0YhGCRGs(object A_0, object A_1, bool disabled)
		{
			A_0._SetModifierKeyIsDisabled(A_1, disabled);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000249B4 File Offset: 0x00022BB4
		internal static void BZx4uIAVbOsBPvee1L3(object A_0, int spellId, object A_2)
		{
			A_0._SetSpellKeybind(spellId, A_2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000249C8 File Offset: 0x00022BC8
		internal static void Fb7l2uAyPPo8WJLu8Lr(object A_0, object A_1, object A_2)
		{
			A_0._SetMacroKeybind(A_1, A_2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000249DC File Offset: 0x00022BDC
		internal static void CUXBNXA86Zx40HpySNN(object A_0, object A_1, object A_2)
		{
			A_0._SetModifierKeybind(A_1, A_2);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000249F0 File Offset: 0x00022BF0
		internal static void hA10HjAqAx1Xo9rd956(object A_0)
		{
			A_0.Stop();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000249FC File Offset: 0x00022BFC
		internal static MouseButtons PQntv3AdaAxC9s7U1x4(object A_0)
		{
			return A_0.Button;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00024A08 File Offset: 0x00022C08
		internal static object PM5C3KAoCVQ2wZWf2hp(object A_0, int A_1, int A_2)
		{
			return A_0.HitTest(A_1, A_2);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00024A1C File Offset: 0x00022C1C
		internal static int ahXGp6A3a1E3JmpEjpv(object A_0)
		{
			return A_0.RowIndex;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00024A28 File Offset: 0x00022C28
		internal static void B7QCBeAQ0M4muOnl6cq(object A_0)
		{
			A_0.ClearSelection();
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00024A34 File Offset: 0x00022C34
		internal static void VlPKSqAC3r5le3hSQ1S(object A_0, bool A_1)
		{
			A_0.Selected = A_1;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00024A44 File Offset: 0x00022C44
		internal static object UkGlVdA90MYg97LCGUo(object A_0)
		{
			return A_0.SelectedRows;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00024A50 File Offset: 0x00022C50
		internal static object Oy2ujMAwwsQqeC7QmTc(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00024A60 File Offset: 0x00022C60
		internal static int fXqdpEAAZxwNygyDTVE(object A_0)
		{
			return A_0.Index;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00024A6C File Offset: 0x00022C6C
		internal static object DiISakAh6XsRZOkhj9g(object A_0, int spellId)
		{
			return A_0._GetSpellName(spellId);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00024A7C File Offset: 0x00022C7C
		internal static object gXqn73AST9qZHOxNh5u(object A_0, object A_1)
		{
			return string.Format(A_0, A_1);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00024A8C File Offset: 0x00022C8C
		internal static void nR8KFlAIayfuxUL1pH8(object A_0, object A_1)
		{
			A_0.setMacroTitle(A_1);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00024A9C File Offset: 0x00022C9C
		internal static void TZmYiMAiKRGH0OdKopw(object A_0, object A_1)
		{
			A_0.setMacroText(A_1);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00024AAC File Offset: 0x00022CAC
		internal static object auwpOsAZUOh1Ov1sMg7(object A_0)
		{
			return A_0.Items;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00024AB8 File Offset: 0x00022CB8
		internal static int Tax82pAU3vjRnUZrRhF(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00024AC4 File Offset: 0x00022CC4
		internal static object sJUbGPA1F87XKx5jD7y(object A_0)
		{
			return A_0.DefaultCellStyle;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00024AD0 File Offset: 0x00022CD0
		internal static Color R50AVEApehog1u7m1vA()
		{
			return Color.LightPink;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00024AD8 File Offset: 0x00022CD8
		internal static Color owsKLyA4wBvfP9xBMsH()
		{
			return Color.LightGoldenrodYellow;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00024AE0 File Offset: 0x00022CE0
		internal static void IWMBi6AOVaRiLvC0OqM(object A_0, Color A_1)
		{
			A_0.BackColor = A_1;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00024AF0 File Offset: 0x00022CF0
		internal static Color pd7LrbAfTlIgHjZelLV()
		{
			return Color.White;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00024AF8 File Offset: 0x00022CF8
		internal static int uMv4MMAFZcnpw03Or0F(object A_0)
		{
			return A_0.ColumnIndex;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00024B04 File Offset: 0x00022D04
		internal static int XQIYesATie0HrSfWncI(object A_0)
		{
			return A_0.RowIndex;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00024B10 File Offset: 0x00022D10
		internal static bool sLwZW9ARogEIrEZrfRG(object A_0)
		{
			return A_0.EndEdit();
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00024B1C File Offset: 0x00022D1C
		internal static bool vDEnJBALEixUpl2aVN7(object A_0, bool A_1)
		{
			return A_0.BeginEdit(A_1);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00024B2C File Offset: 0x00022D2C
		internal static void f6Li07AlLLxhacGc2pe(object A_0, bool A_1)
		{
			A_0.DroppedDown = A_1;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00024B3C File Offset: 0x00022D3C
		internal static int bS06amAaciu5BEFVDsl(object A_0)
		{
			return A_0.ColumnIndex;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00024B48 File Offset: 0x00022D48
		internal static int QyjFOvAKC3tZKpJbmVN(object A_0)
		{
			return A_0.RowIndex;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00024B54 File Offset: 0x00022D54
		internal static int tBmLfKAejD2nitXJts3(object A_0)
		{
			return A_0.MaxInputLength;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00024B60 File Offset: 0x00022D60
		internal static object lllqf3Akf7ocUv0LVuV(object A_0)
		{
			return Convert.ToString(A_0);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00024B6C File Offset: 0x00022D6C
		internal static object OC0plaArTpT1KWPTYJl(object A_0)
		{
			return A_0.Tag;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00024B78 File Offset: 0x00022D78
		internal static void r6SRRlA7UeL9qLnD1CJ(object A_0, double A_1)
		{
			A_0.Interval = A_1;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00024B88 File Offset: 0x00022D88
		internal static bool QV7X3NA2hAq2jTBgKkc(object A_0, int \u0020)
		{
			return A_0.UTvciVxMpW(\u0020);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00024B98 File Offset: 0x00022D98
		internal static void JtpUCIA6ql2rHeWhmlc(object A_0)
		{
			A_0.Start();
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00024BA4 File Offset: 0x00022DA4
		internal static void AwZW73ANDfVtQ8Wom9a()
		{
			Application.Exit();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00024BAC File Offset: 0x00022DAC
		internal static object tPRjXMAnjgJBpdn2bDi(object A_0, object A_1, object A_2, object A_3)
		{
			return string.Format(A_0, A_1, A_2, A_3);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00024BC4 File Offset: 0x00022DC4
		internal static bool TCSUtSA0qbO5mKZSB64(object A_0, object A_1)
		{
			return A_0.EndsWith(A_1);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00024BD4 File Offset: 0x00022DD4
		internal static bool fydyYQAJZ7JXnyCmg2b(object A_0)
		{
			return string.IsNullOrEmpty(A_0);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00024BE0 File Offset: 0x00022DE0
		internal static void zSl4jPAmUWI3aXVVRsg(object A_0)
		{
			A_0.Persist();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00024BEC File Offset: 0x00022DEC
		internal static bool Ne2jFjAHIGhFTjTxmi1()
		{
			return icdoeGQQtZwolxBdqe.mmmZKEZw3();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00024BF4 File Offset: 0x00022DF4
		internal static SharpClipboard.ContentTypes mFBiPEAttwBGKEuAKZJ(object A_0)
		{
			return A_0.ContentType;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00024C00 File Offset: 0x00022E00
		internal static object A9qxBkAYOVqHpKl0B1W(object A_0)
		{
			return A_0.Content;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00024C0C File Offset: 0x00022E0C
		internal static void I4i3UJAsKsZZvMMcHsE(object A_0, RuntimeFieldHandle A_1)
		{
			RuntimeHelpers.InitializeArray(A_0, A_1);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00024C1C File Offset: 0x00022E1C
		internal static int dXPZq9AgCrJqtPRJoa7(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00024C28 File Offset: 0x00022E28
		internal static void P8VPokAXAGYYix6GMOl(object A_0)
		{
			Clipboard.SetText(A_0);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00024C34 File Offset: 0x00022E34
		internal static object y9SJnNAM5qLMwgboJZx(object A_0, object A_1)
		{
			return icdoeGQQtZwolxBdqe.TgQUk35PZ(A_0, A_1);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00024C44 File Offset: 0x00022E44
		internal static object mqJliVAGhxhuLmyijAu()
		{
			return SHA256.Create();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00024C4C File Offset: 0x00022E4C
		internal static object VBBke5ABL0fGVx6oWe0()
		{
			return Encoding.ASCII;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00024C54 File Offset: 0x00022E54
		internal static void Or1pbIADv1aJKprm95B(object A_0, CipherMode A_1)
		{
			A_0.Mode = A_1;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00024C64 File Offset: 0x00022E64
		internal static void Hvv9pDAvhuIUo91bAqb(object A_0, object A_1)
		{
			A_0.Key = A_1;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00024C74 File Offset: 0x00022E74
		internal static void RcEYAhAjnDiXquWMER9(object A_0)
		{
			A_0.FlushFinalBlock();
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00024C80 File Offset: 0x00022E80
		internal static object shNpO2AbP2HNnJXWn67(object A_0, object A_1, int A_2, int A_3)
		{
			return A_0.GetString(A_1, A_2, A_3);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00024C98 File Offset: 0x00022E98
		internal static void w7YVoeAz5uxNKRp4KoW(object A_0)
		{
			A_0.Close();
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00024CA4 File Offset: 0x00022EA4
		internal static object gCfIFQhWEiQQUoe2LbH(object A_0)
		{
			return icdoeGQQtZwolxBdqe.yWpI5dOqO(A_0);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00024CB0 File Offset: 0x00022EB0
		internal static object zUUh4ThP0Cc01ljHSYy(object A_0)
		{
			return A_0.CoreWebView2;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00024CBC File Offset: 0x00022EBC
		internal static void KONeC5hEKxX0Z0ta49X(object A_0, bool A_1)
		{
			A_0.AreBrowserAcceleratorKeysEnabled = A_1;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00024CCC File Offset: 0x00022ECC
		internal static object isrmPlhcCJpL6lhWQ33(object A_0)
		{
			return A_0.Settings;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00024CD8 File Offset: 0x00022ED8
		internal static void Um95h5h5y5PURIROh8b(object A_0, bool A_1)
		{
			A_0.AreDefaultContextMenusEnabled = A_1;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00024CE8 File Offset: 0x00022EE8
		internal static void HpSj1ShxJrFDYM9mKKh(object A_0, bool A_1)
		{
			A_0.AreDefaultScriptDialogsEnabled = A_1;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00024CF8 File Offset: 0x00022EF8
		internal static void NSHU0QhuMMlNtgBZOOS(object A_0, bool A_1)
		{
			A_0.IsZoomControlEnabled = A_1;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00024D08 File Offset: 0x00022F08
		internal static void TrJet9hVwrXyrUFBPF0(object A_0, bool A_1)
		{
			A_0.IsPasswordAutosaveEnabled = A_1;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00024D18 File Offset: 0x00022F18
		internal static void xEyOJlhycZJ4bCYeokt(object A_0, bool A_1)
		{
			A_0.IsStatusBarEnabled = A_1;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00024D28 File Offset: 0x00022F28
		internal static void xqTYPEh8U46L1n2RUWw(object A_0, bool A_1)
		{
			A_0.IsBuiltInErrorPageEnabled = A_1;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00024D38 File Offset: 0x00022F38
		internal static void K0eZHIhqibE7gQmMyZe(object A_0, object A_1)
		{
			A_0.Navigate(A_1);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00024D48 File Offset: 0x00022F48
		internal static object eU2YUmhdXSY7sxouHZn(object A_0)
		{
			return A_0.TryGetWebMessageAsString();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00024D54 File Offset: 0x00022F54
		internal static bool GA7nSPhom1mPs43ihkM(object A_0)
		{
			return A_0.IsLoaded;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00024D60 File Offset: 0x00022F60
		internal static void tf1IRnh3KfRL7nHrgBI(object A_0)
		{
			A_0.Unload();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00024D6C File Offset: 0x00022F6C
		internal static void pHs98vhQco1vII4ggHY(int A_0)
		{
			Environment.Exit(A_0);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00024D78 File Offset: 0x00022F78
		internal static object dw09RchCcS3CmseATIW(object A_0, int A_1, int A_2)
		{
			return A_0[A_1, A_2];
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00024D8C File Offset: 0x00022F8C
		internal static void jjZ4QDh9WnrfumnYDdq(object A_0, object A_1, object A_2)
		{
			A_0.SetToolTip(A_1, A_2);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00024DA0 File Offset: 0x00022FA0
		internal static int JSwh4OhwKkR6QvxFcsw(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00024DAC File Offset: 0x00022FAC
		internal static void MQIB1bhArSPVHWLFbwW(object A_0, bool A_1)
		{
			A_0.Dispose(A_1);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00024DBC File Offset: 0x00022FBC
		internal static void NI0nbahhQrIJ1PGSqQI(object A_0)
		{
			A_0.SuspendLayout();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00024DC8 File Offset: 0x00022FC8
		internal static void ts5qOphSdFeFDL1nGkF(object A_0)
		{
			((ISupportInitialize)A_0).BeginInit();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00024DD4 File Offset: 0x00022FD4
		internal static void UPgX00hIfNTJfSQunfn(object A_0, bool A_1)
		{
			A_0.AnimateWindow = A_1;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00024DE4 File Offset: 0x00022FE4
		internal static void YU5b4UhihCdJO3ZW3gp(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00024DF4 File Offset: 0x00022FF4
		internal static void RaAXdAhZ3eX1aiYGeFQ(object A_0, double A_1)
		{
			A_0.DockIndicatorTransparencyValue = A_1;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00024E04 File Offset: 0x00023004
		internal static void wOWaSEhUFckT1vLaok7(object A_0, bool A_1)
		{
			A_0.ResizeForm = A_1;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00024E14 File Offset: 0x00023014
		internal static Color guNG4gh19ILHCqNxi2h()
		{
			return Color.Gray;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00024E1C File Offset: 0x0002301C
		internal static void Ym8RuUhp4dIFAy6u2Me(object A_0, bool A_1)
		{
			A_0.TransparentWhileDrag = A_1;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00024E2C File Offset: 0x0002302C
		internal static void rwewK0h4reiUaHQDmoU(object A_0, TabAlignment A_1)
		{
			A_0.Alignment = A_1;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00024E3C File Offset: 0x0002303C
		internal static void cjbEqXhOkHto9Mpb3TF(object A_0, object A_1)
		{
			A_0.Add(A_1);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00024E4C File Offset: 0x0002304C
		internal static void sTh4N1hfYNMMTCB8Ac1(object A_0, bool A_1)
		{
			A_0.HotTrack = A_1;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00024E5C File Offset: 0x0002305C
		internal static void BYULIGhFpBJPZrMGUKF(object A_0, object A_1)
		{
			A_0.Name = A_1;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00024E6C File Offset: 0x0002306C
		internal static void c0iNFuhTJsEkerxoDF5(object A_0, Point A_1)
		{
			A_0.Padding = A_1;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00024E7C File Offset: 0x0002307C
		internal static void jjcAKNhRfBLpRys7iFS(object A_0, int A_1)
		{
			A_0.SelectedIndex = A_1;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00024E8C File Offset: 0x0002308C
		internal static object lhQ6buhLkE4fXJ5pm8a(object A_0)
		{
			return A_0.TabButtonHoverState;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00024E98 File Offset: 0x00023098
		internal static void b93ptlhlJQMfCjQWJts(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00024EA8 File Offset: 0x000230A8
		internal static void wn4MVbhaDtLVWnT24Xb(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00024EB8 File Offset: 0x000230B8
		internal static void UKbNgvhKj1KrPfkYk1l(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00024EC8 File Offset: 0x000230C8
		internal static void nga6WgheeytD1C2eoXZ(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00024ED8 File Offset: 0x000230D8
		internal static void rMNt2hhkQfYxahtLlNM(object A_0, Color A_1)
		{
			A_0.InnerColor = A_1;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00024EE8 File Offset: 0x000230E8
		internal static object t8cqeBhr9tQbN9Ufa16(object A_0)
		{
			return A_0.TabButtonIdleState;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00024EF4 File Offset: 0x000230F4
		internal static void WF4fHNh7qIIDfcgMAes(object A_0, HorizontalAlignment A_1)
		{
			A_0.TabButtonImageAlign = A_1;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00024F04 File Offset: 0x00023104
		internal static object CjCbtvh2yRUkguJMX9P(object A_0)
		{
			return A_0.TabButtonSelectedState;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00024F10 File Offset: 0x00023110
		internal static void RsaqC7h6uTpcoFADpiT(object A_0, Size A_1)
		{
			A_0.TabButtonSize = A_1;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00024F20 File Offset: 0x00023120
		internal static void qZEtwphNdGF2BbmdyPh(object A_0, HorizontalAlignment A_1)
		{
			A_0.TabButtonTextAlign = A_1;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00024F30 File Offset: 0x00023130
		internal static void E1E0QthnssGuPPwPGp7(object A_0, Point A_1)
		{
			A_0.TabButtonTextOffset = A_1;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00024F40 File Offset: 0x00023140
		internal static void eFeObWh0FiV2NaypcSU(object A_0, bool A_1)
		{
			A_0.AutoScroll = A_1;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00024F50 File Offset: 0x00023150
		internal static void rNH3WfhJCd14ZcstGLE(object A_0, int A_1)
		{
			A_0.ImageIndex = A_1;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00024F60 File Offset: 0x00023160
		internal static void U3XM2Qhm2XM60XWh7EK(object A_0, Point A_1)
		{
			A_0.Location = A_1;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00024F70 File Offset: 0x00023170
		internal static void sUSlgdhHRw1CXHlv9uV(object A_0, Size A_1)
		{
			A_0.Size = A_1;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00024F80 File Offset: 0x00023180
		internal static void zrr9k9htR9NUTAHlE3g(object A_0, bool A_1)
		{
			A_0.UseVisualStyleBackColor = A_1;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00024F90 File Offset: 0x00023190
		internal static void Pj5rjPhYZsKmoJgcMvx(object A_0, object A_1)
		{
			A_0.Click += A_1;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00024FA0 File Offset: 0x000231A0
		internal static void sLBp4vhs8n4RKjjB6is(object A_0, DockStyle A_1)
		{
			A_0.Dock = A_1;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00024FB0 File Offset: 0x000231B0
		internal static void yKlIRZhgGPwQdBNUf1A(object A_0, Size A_1)
		{
			A_0.ItemSize = A_1;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00024FC0 File Offset: 0x000231C0
		internal static void fSKvdPhXB121ntJCND9(object A_0, Point A_1)
		{
			A_0.Location = A_1;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00024FD0 File Offset: 0x000231D0
		internal static void JBnCqRhMbY6dWf5nXZF(object A_0, Padding A_1)
		{
			A_0.Margin = A_1;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00024FE0 File Offset: 0x000231E0
		internal static Color D20T76hGKJkfHDfFXfT()
		{
			return Color.Teal;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00024FE8 File Offset: 0x000231E8
		internal static Color wOp4nxhB3jetdEd5vg5()
		{
			return Color.PowderBlue;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00024FF0 File Offset: 0x000231F0
		internal static Color FKa6C7hD8TGBG7hXjxm()
		{
			return Color.Black;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00024FF8 File Offset: 0x000231F8
		internal static void HGlKd5hvsT3Rl0VTrEp(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00025008 File Offset: 0x00023208
		internal static void voYLFshjBEBI0ODwIr7(object A_0, Padding A_1)
		{
			A_0.Padding = A_1;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00025018 File Offset: 0x00023218
		internal static void dfY6Z2hb6gnKZv6QTdm(object A_0, bool A_1)
		{
			A_0.AllowExternalDrop = A_1;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00025028 File Offset: 0x00023228
		internal static void c0T4oUhzseliJt6JbSj(object A_0, int A_1)
		{
			A_0.TabIndex = A_1;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00025038 File Offset: 0x00023238
		internal static void xq58MxSWykoPsdPyBfR(object A_0, double A_1)
		{
			A_0.ZoomFactor = A_1;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00025048 File Offset: 0x00023248
		internal static Color G9eLqeSP2XWNAQfY8h5()
		{
			return Color.DimGray;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00025050 File Offset: 0x00023250
		internal static void UtcbqjSETttS7ihWoUi(object A_0, object A_1)
		{
			A_0.AddRange(A_1);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00025060 File Offset: 0x00023260
		internal static void qeI8EWScfNcUJNVdERV(object A_0, bool A_1)
		{
			A_0.FullRowSelect = A_1;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00025070 File Offset: 0x00023270
		internal static void BYPHtuS5OYTilSPEolI(object A_0, bool A_1)
		{
			A_0.HideSelection = A_1;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00025080 File Offset: 0x00023280
		internal static void Y8x1VxSxRrOsTm7B7kb(object A_0, bool A_1)
		{
			A_0.ShowGroups = A_1;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00025090 File Offset: 0x00023290
		internal static void IpgtX9SulMDveECTBOB(object A_0, bool A_1)
		{
			A_0.UseCompatibleStateImageBehavior = A_1;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000250A0 File Offset: 0x000232A0
		internal static void ujfH77SVCnHBuUNBj9v(object A_0, View A_1)
		{
			A_0.View = A_1;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000250B0 File Offset: 0x000232B0
		internal static void xuq2OwSyC9MGZIJyWQi(object A_0, object A_1)
		{
			A_0.SelectedIndexChanged += A_1;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000250C0 File Offset: 0x000232C0
		internal static void a5OmidS81nno4H3n5TQ(object A_0, object A_1)
		{
			A_0.DoubleClick += A_1;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000250D0 File Offset: 0x000232D0
		internal static void KpJINqSqH6xqYtcPTR3(object A_0, object A_1)
		{
			A_0.KeyDown += A_1;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000250E0 File Offset: 0x000232E0
		internal static void Jjn59PSdJFuo2LP4v7L(object A_0, object A_1)
		{
			A_0.Text = A_1;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000250F0 File Offset: 0x000232F0
		internal static void XT9GbTSoNQNEAtQu6FN(object A_0, int A_1)
		{
			A_0.Width = A_1;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00025100 File Offset: 0x00023300
		internal static void G1bergS3wlgABlFmf1Z(object A_0, Size A_1)
		{
			A_0.ImageScalingSize = A_1;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00025110 File Offset: 0x00023310
		internal static void z9Mdc3SQmvCHbuhnA9j(object A_0, object A_1)
		{
			A_0.Image = A_1;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00025120 File Offset: 0x00023320
		internal static void FMmXXUSCJBZ0ICUrYk0(object A_0, Size A_1)
		{
			A_0.Size = A_1;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00025130 File Offset: 0x00023330
		internal static void P5eeUsS9qDJS8JGNAGm(object A_0, object A_1)
		{
			A_0.Text = A_1;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00025140 File Offset: 0x00023340
		internal static void Ejey22SwIyfvnrggGSM(object A_0, object A_1)
		{
			A_0.Click += A_1;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00025150 File Offset: 0x00023350
		internal static void pO88tISAdsdR80aCRiT(object A_0, object A_1)
		{
			A_0.Name = A_1;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00025160 File Offset: 0x00023360
		internal static object tKulMWShFC9ddfy5ena()
		{
			return Resources.clear;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00025168 File Offset: 0x00023368
		internal static object juNGPTSSDEGN1Db1ybK()
		{
			return Resources.pencil;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00025170 File Offset: 0x00023370
		internal static object hAZMV0SINDD87NABFkp(object A_0, object A_1)
		{
			return A_0.GetObject(A_1);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00025180 File Offset: 0x00023380
		internal static Color HWi2GWSiSnTprngPudf()
		{
			return Color.Transparent;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00025188 File Offset: 0x00023388
		internal static void pFoxNeSZ5YRTR9whdfW(object A_0, int A_1, object A_2)
		{
			A_0.SetKeyName(A_1, A_2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0002519C File Offset: 0x0002339C
		internal static void CxP1olSUjKIoBxtX0u6(object A_0, int A_1)
		{
			A_0.TabIndex = A_1;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x000251AC File Offset: 0x000233AC
		internal static void eF0FoaS1sQWGM7A5mGR(object A_0, AnchorStyles A_1)
		{
			A_0.Anchor = A_1;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000251BC File Offset: 0x000233BC
		internal static void rNXejGSp5vN1fxhySyd(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000251CC File Offset: 0x000233CC
		internal static Color giuhSiS4f07IhTOwgHy()
		{
			return Color.DarkGray;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000251D4 File Offset: 0x000233D4
		internal static void wr5o3ESO7nyo3wXgm1J(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000251E4 File Offset: 0x000233E4
		internal static object Gypb9bSfb8dfe9D7Fgg(object A_0)
		{
			return A_0.DisabledState;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000251F0 File Offset: 0x000233F0
		internal static void jYIvwlSFeUP8EP4RD48(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00025200 File Offset: 0x00023400
		internal static void pMcELVSTsaMWxAYDlvZ(object A_0, bool A_1)
		{
			A_0.UseTransparentBackground = A_1;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00025210 File Offset: 0x00023410
		internal static void q97Fy4SR0JyfF4xKLTS(object A_0, bool A_1)
		{
			A_0.Multiline = A_1;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00025220 File Offset: 0x00023420
		internal static void H46hiSSL9IXx2IUG475(object A_0, ScrollBars A_1)
		{
			A_0.ScrollBars = A_1;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00025230 File Offset: 0x00023430
		internal static void AQ5PKbSlGpZgbylJlqA(object A_0, Color A_1)
		{
			A_0.BackColor = A_1;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00025240 File Offset: 0x00023440
		internal static void EuGjb6SauPVqqcdQRHP(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00025250 File Offset: 0x00023450
		internal static void MKQJJgSKWytIG94Qcm4(object A_0, int A_1)
		{
			A_0.BorderThickness = A_1;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00025260 File Offset: 0x00023460
		internal static Color KmbavbSejbEltY0hQn0()
		{
			return Color.GhostWhite;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00025268 File Offset: 0x00023468
		internal static void SRjnkfSkHA1Z9aBxE8R(object A_0, bool A_1)
		{
			A_0.UseTransparentBackground = A_1;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00025278 File Offset: 0x00023478
		internal static void PMxUPdSrxvVlWwnXnBc(object A_0, bool A_1)
		{
			A_0.Animated = A_1;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00025288 File Offset: 0x00023488
		internal static void DIHdSHS7iP1A7KmNMB1(object A_0, Color A_1)
		{
			A_0.CustomBorderColor = A_1;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00025298 File Offset: 0x00023498
		internal static void qUoa3MS2blaFwKqpFJ7(object A_0, ContentAlignment A_1)
		{
			A_0.TextAlign = A_1;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000252A8 File Offset: 0x000234A8
		internal static void dYGjm9S6AyCC0N2dwKP(object A_0, bool A_1)
		{
			A_0.AllowUserToAddRows = A_1;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000252B8 File Offset: 0x000234B8
		internal static void vTvWhXSNL5wYWtHE0QY(object A_0, bool A_1)
		{
			A_0.AllowUserToResizeColumns = A_1;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000252C8 File Offset: 0x000234C8
		internal static void qOx35PSnKLxqQrPtR2m(object A_0, bool A_1)
		{
			A_0.AllowUserToResizeRows = A_1;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000252D8 File Offset: 0x000234D8
		internal static void qAY2DbS0lQMxESRlAmp(object A_0, object A_1)
		{
			A_0.AlternatingRowsDefaultCellStyle = A_1;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000252E8 File Offset: 0x000234E8
		internal static void VvJdQASJ2W9KramGnMU(object A_0, bool A_1)
		{
			A_0.CausesValidation = A_1;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000252F8 File Offset: 0x000234F8
		internal static void rKgWEMSmKw4ZRqoLtHs(object A_0, DataGridViewCellBorderStyle A_1)
		{
			A_0.CellBorderStyle = A_1;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00025308 File Offset: 0x00023508
		internal static void KYZsvsSHA47xpxgVViu(object A_0, DataGridViewHeaderBorderStyle A_1)
		{
			A_0.ColumnHeadersBorderStyle = A_1;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00025318 File Offset: 0x00023518
		internal static void Rer5dAStiGn1xeOjxdw(object A_0, DataGridViewContentAlignment A_1)
		{
			A_0.Alignment = A_1;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00025328 File Offset: 0x00023528
		internal static void cCHgJfSYhohxmE8w4BT(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00025338 File Offset: 0x00023538
		internal static Color SpVp1pSsuOkIuaZ0gb7()
		{
			return SystemColors.Highlight;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00025340 File Offset: 0x00023540
		internal static Color gDTkfBSgI078eL8rUC0()
		{
			return SystemColors.HighlightText;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00025348 File Offset: 0x00023548
		internal static void sHSPBYSXYHPhTAgWo8a(object A_0, DataGridViewTriState A_1)
		{
			A_0.WrapMode = A_1;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00025358 File Offset: 0x00023558
		internal static void O31LTUSM513icv5yigG(object A_0, object A_1)
		{
			A_0.ColumnHeadersDefaultCellStyle = A_1;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00025368 File Offset: 0x00023568
		internal static void Kk0xPCSG2g31xCMwluA(object A_0, int A_1)
		{
			A_0.ColumnHeadersHeight = A_1;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00025378 File Offset: 0x00023578
		internal static void rAerOJSBbLMmf4J5KMd(object A_0, object A_1)
		{
			A_0.AddRange(A_1);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00025388 File Offset: 0x00023588
		internal static void URcVOuSDSFDRM7OmWTX(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00025398 File Offset: 0x00023598
		internal static void B9NkxySv08excapIeQS(object A_0, Color A_1)
		{
			A_0.SelectionBackColor = A_1;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000253A8 File Offset: 0x000235A8
		internal static void vJ6cNnSjslYmMsSaLt1(object A_0, Color A_1)
		{
			A_0.GridColor = A_1;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000253B8 File Offset: 0x000235B8
		internal static object OH0ytaSbKMHlvY1b5HH(object A_0)
		{
			return A_0.RowTemplate;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000253C4 File Offset: 0x000235C4
		internal static void B1wnEuSzNHT41iFvSNM(object A_0, object A_1)
		{
			A_0.ContextMenuStrip = A_1;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000253D4 File Offset: 0x000235D4
		internal static void QEHe5jIW3kjEoOObLPC(object A_0, bool A_1)
		{
			A_0.ShowCellErrors = A_1;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000253E4 File Offset: 0x000235E4
		internal static void DvTSVlIPDVXe6NjL9Ia(object A_0, bool A_1)
		{
			A_0.ShowEditingIcon = A_1;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000253F4 File Offset: 0x000235F4
		internal static void no90GHIE0Dao6auK2XZ(object A_0, bool A_1)
		{
			A_0.ShowRowErrors = A_1;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00025404 File Offset: 0x00023604
		internal static object B8c6UEIcxWgItx92tUl(object A_0)
		{
			return A_0.ThemeStyle;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00025410 File Offset: 0x00023610
		internal static object IxeeAFI56iP6msjRr8x(object A_0)
		{
			return A_0.AlternatingRowsStyle;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0002541C File Offset: 0x0002361C
		internal static void POOgCgIxT4AvjYeRVwd(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0002542C File Offset: 0x0002362C
		internal static void HbkIbNIuh8Zmqq7AKE1(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0002543C File Offset: 0x0002363C
		internal static void FHsxx6IVReXxj50lsQM(object A_0, Color A_1)
		{
			A_0.SelectionBackColor = A_1;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0002544C File Offset: 0x0002364C
		internal static void paCfMOIyGFSfS1fATPZ(object A_0, Color A_1)
		{
			A_0.SelectionForeColor = A_1;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0002545C File Offset: 0x0002365C
		internal static void FPnOSWI8T7fyCLYT9Mg(object A_0, Color A_1)
		{
			A_0.GridColor = A_1;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0002546C File Offset: 0x0002366C
		internal static void TJq9P8Iq2rqwaZGcKXi(object A_0, Color A_1)
		{
			A_0.BackColor = A_1;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0002547C File Offset: 0x0002367C
		internal static object pGgBCJIdLumlibNFUV8(object A_0)
		{
			return A_0.HeaderStyle;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00025488 File Offset: 0x00023688
		internal static void SD02sxIoDCoV72J4ZU5(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00025498 File Offset: 0x00023698
		internal static void dgeks9I3VodlDjWpuW7(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000254A8 File Offset: 0x000236A8
		internal static void L8MkK2IQffWUKgICJNj(object A_0, int A_1)
		{
			A_0.Height = A_1;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000254B8 File Offset: 0x000236B8
		internal static object NTYtH4ICbD0jWXFC4ol(object A_0)
		{
			return A_0.RowsStyle;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000254C4 File Offset: 0x000236C4
		internal static void agCnAuI950lG7RyZyp7(object A_0, Color A_1)
		{
			A_0.BackColor = A_1;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000254D4 File Offset: 0x000236D4
		internal static void Dcb5bSIwp9OrjHe2mgd(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000254E4 File Offset: 0x000236E4
		internal static void tJ9boRIAZlHYfAtIVO0(object A_0, int A_1)
		{
			A_0.Height = A_1;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000254F4 File Offset: 0x000236F4
		internal static void dvBRlGIhy56hFVtjNLt(object A_0, Color A_1)
		{
			A_0.SelectionForeColor = A_1;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00025504 File Offset: 0x00023704
		internal static void WEEKU5ISYMiMN2vRBsC(object A_0, object A_1)
		{
			A_0.CellContentClick += A_1;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00025514 File Offset: 0x00023714
		internal static void HhDmpfIIC3sgidl7lWO(object A_0, object A_1)
		{
			A_0.CellContentDoubleClick += A_1;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00025524 File Offset: 0x00023724
		internal static void HOhFwLIij7nr09HKWqJ(object A_0, object A_1)
		{
			A_0.CellDoubleClick += A_1;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00025534 File Offset: 0x00023734
		internal static void AYECD2IZo1Hm07wV025(object A_0, object A_1)
		{
			A_0.CellMouseUp += A_1;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00025544 File Offset: 0x00023744
		internal static void zKIb6qIUoerGPumUHJO(object A_0, object A_1)
		{
			A_0.CellValueChanged += A_1;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00025554 File Offset: 0x00023754
		internal static void vY9JJWI1Z0hangdfdIF(object A_0, object A_1)
		{
			A_0.MouseDown += A_1;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00025564 File Offset: 0x00023764
		internal static void Lg0ScKIpjNLeXbDQTVP(object A_0, DataGridViewAutoSizeColumnMode A_1)
		{
			A_0.AutoSizeMode = A_1;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00025574 File Offset: 0x00023774
		internal static void Cv9NRmI4hrLJaPHB83g(object A_0, object A_1)
		{
			A_0.HeaderText = A_1;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00025584 File Offset: 0x00023784
		internal static void t0odiWIO3jYbIe5tBDa(object A_0, DataGridViewImageCellLayout A_1)
		{
			A_0.ImageLayout = A_1;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00025594 File Offset: 0x00023794
		internal static void BelJUdIfWaaWNT5ivWk(object A_0, object A_1)
		{
			A_0.Name = A_1;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000255A4 File Offset: 0x000237A4
		internal static void nZesEQIFV9dQquxGUD5(object A_0, int A_1)
		{
			A_0.Width = A_1;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000255B4 File Offset: 0x000237B4
		internal static void WokGlvITygHmuJPTud4(object A_0, Padding A_1)
		{
			A_0.Padding = A_1;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000255C4 File Offset: 0x000237C4
		internal static void QI0AhFIR1knu9ucab2n(object A_0, object A_1)
		{
			A_0.DefaultCellStyle = A_1;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000255D4 File Offset: 0x000237D4
		internal static void GTMMr4ILDsKXD57tVjr(object A_0, float A_1)
		{
			A_0.FillWeight = A_1;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000255E4 File Offset: 0x000237E4
		internal static void qBhlhiIlRfXyLrXRVfV(object A_0, bool A_1)
		{
			A_0.ReadOnly = A_1;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000255F4 File Offset: 0x000237F4
		internal static void STG6BrIaHEj0qxrKnDQ(object A_0, int A_1)
		{
			A_0.MinimumWidth = A_1;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00025604 File Offset: 0x00023804
		internal static void C31yKlIK6enWtdykbpD(object A_0, DataGridViewTriState A_1)
		{
			A_0.Resizable = A_1;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00025614 File Offset: 0x00023814
		internal static void OqRJI9IewOiqmFiV0R3(object A_0, object A_1)
		{
			A_0.Opening += A_1;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00025624 File Offset: 0x00023824
		internal static void CHP8NWIk4DVxW1wS7KP(object A_0, Color A_1)
		{
			A_0.FillColor2 = A_1;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00025634 File Offset: 0x00023834
		internal static void I5salaIrpg8plUCDDAh(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00025644 File Offset: 0x00023844
		internal static void wxMaZnI7u1L89VdGNLA(object A_0, bool A_1)
		{
			A_0.AutoSize = A_1;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00025654 File Offset: 0x00023854
		internal static object HjK5KFI2DSeCFHmC5pL(object A_0)
		{
			return A_0.CheckedState;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00025660 File Offset: 0x00023860
		internal static void twywWuI6kMlWTtwfxxc(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00025670 File Offset: 0x00023870
		internal static void OmMH5wINnsrGWBpyo6n(object A_0, Color A_1)
		{
			A_0.InnerBorderColor = A_1;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00025680 File Offset: 0x00023880
		internal static void jyjAD8InwfkZ05g28Ir(object A_0, Color A_1)
		{
			A_0.InnerColor = A_1;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00025690 File Offset: 0x00023890
		internal static object HU61GfI0Rv3AMEKtWnE(object A_0)
		{
			return A_0.UncheckedState;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0002569C File Offset: 0x0002389C
		internal static void wmRhA7IJQPxYMOFAKt5(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x000256AC File Offset: 0x000238AC
		internal static void OpcykuImY77kfmRtox1(object A_0, object A_1)
		{
			A_0.CheckedChanged += A_1;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000256BC File Offset: 0x000238BC
		internal static void hdgSGoIH5MU8ZqAJQQV(object A_0, Color A_1)
		{
			A_0.BackgroundColor = A_1;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000256CC File Offset: 0x000238CC
		internal static void gFnm6BIteqtbpYI3Km4(object A_0, Color A_1)
		{
			A_0.SelectionForeColor = A_1;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000256DC File Offset: 0x000238DC
		internal static void DqpuD4IY1WemtTnDXyG(object A_0, DataGridViewColumnHeadersHeightSizeMode A_1)
		{
			A_0.ColumnHeadersHeightSizeMode = A_1;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000256EC File Offset: 0x000238EC
		internal static void uBn3qVIshudVq1FlrYJ(object A_0, object A_1)
		{
			A_0.DefaultCellStyle = A_1;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000256FC File Offset: 0x000238FC
		internal static void UuXRD3IgMlNN2nOkkF0(object A_0, DataGridViewEditMode A_1)
		{
			A_0.EditMode = A_1;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0002570C File Offset: 0x0002390C
		internal static void uTiOQBIXIYQh2Byxyr4(object A_0, bool A_1)
		{
			A_0.EnableHeadersVisualStyles = A_1;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0002571C File Offset: 0x0002391C
		internal static void otmlDCIMLcd9h5DidGC(object A_0, bool A_1)
		{
			A_0.RowHeadersVisible = A_1;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0002572C File Offset: 0x0002392C
		internal static void AnC9VRIGRR3wvvwCd4a(object A_0, int A_1)
		{
			A_0.RowHeadersWidth = A_1;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0002573C File Offset: 0x0002393C
		internal static void BExsmoIBUlEI92ahy6J(object A_0, int A_1)
		{
			A_0.DividerHeight = A_1;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0002574C File Offset: 0x0002394C
		internal static void Rl1RQKID8eZtBFjhyyR(object A_0, Color A_1)
		{
			A_0.BackColor = A_1;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0002575C File Offset: 0x0002395C
		internal static void jWG6fiIvV7ToNrN8jql(object A_0, DataGridViewColumnHeadersHeightSizeMode A_1)
		{
			A_0.HeaightSizeMode = A_1;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0002576C File Offset: 0x0002396C
		internal static void TxLE6fIjE2x9ruJ0YKZ(object A_0, bool A_1)
		{
			A_0.ReadOnly = A_1;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0002577C File Offset: 0x0002397C
		internal static void S5UODsIbUiIGX8BHlL0(object A_0, DataGridViewCellBorderStyle A_1)
		{
			A_0.BorderStyle = A_1;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0002578C File Offset: 0x0002398C
		internal static void LHKTq0Iz7DUG2RUA0mp(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0002579C File Offset: 0x0002399C
		internal static void U78ErFiW8ytOndbO7FA(object A_0, object A_1)
		{
			A_0.CellEnter += A_1;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000257AC File Offset: 0x000239AC
		internal static void vH8OAmiPKT3MN4Z9ja6(object A_0, object A_1)
		{
			A_0.CellValidating += A_1;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x000257BC File Offset: 0x000239BC
		internal static void mBAPbIiEnNpQ5yIyBrW(object A_0, object A_1)
		{
			A_0.MouseUp += A_1;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000257CC File Offset: 0x000239CC
		internal static void OyAwT6ic1QM8iT89i3U(object A_0, RightToLeft A_1)
		{
			A_0.RightToLeft = A_1;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x000257DC File Offset: 0x000239DC
		internal static void gGHMpMi50ocPwkUtejc(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x000257EC File Offset: 0x000239EC
		internal static void bAfsNnixIiVZajHwRbB(object A_0, object A_1)
		{
			A_0.Cursor = A_1;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x000257FC File Offset: 0x000239FC
		internal static void u2jKCGiuYuHiMgf1sx7(object A_0, object A_1)
		{
			A_0.Font = A_1;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0002580C File Offset: 0x00023A0C
		internal static void ct6f95iVW7aY43cQu7Z(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0002581C File Offset: 0x00023A1C
		internal static object VA4WwsiygtFFKaVPeZt()
		{
			return Cursors.IBeam;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00025824 File Offset: 0x00023A24
		internal static void oWydCqi8UgPIsjPhBA9(object A_0, decimal A_1)
		{
			A_0.Minimum = A_1;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00025834 File Offset: 0x00023A34
		internal static void m07tEyiqJ14uAJStg1D(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00025844 File Offset: 0x00023A44
		internal static void j3fKIdidqWrQeM9mduN(object A_0, DrawMode A_1)
		{
			A_0.DrawMode = A_1;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00025854 File Offset: 0x00023A54
		internal static void QKARLdioNwUFu7gp91N(object A_0, Color A_1)
		{
			A_0.FocusedColor = A_1;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00025864 File Offset: 0x00023A64
		internal static object DUmRGwi33SRyIHDjWmi(object A_0)
		{
			return A_0.FocusedState;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00025870 File Offset: 0x00023A70
		internal static void NEVx6ciQWUA1CnM79yH(object A_0, int A_1)
		{
			A_0.ItemHeight = A_1;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00025880 File Offset: 0x00023A80
		internal static object alCM98iCFxYevvKLalT(object A_0)
		{
			return A_0.Items;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0002588C File Offset: 0x00023A8C
		internal static void HknG7ni99eBPTOLlrcb(object A_0, object A_1)
		{
			A_0.AddRange(A_1);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0002589C File Offset: 0x00023A9C
		internal static void MBxdu8iw8gTc2lKiMol(object A_0, object A_1)
		{
			A_0.SelectedIndexChanged += A_1;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x000258AC File Offset: 0x00023AAC
		internal static void gGZnrriA34hqIifEHcW(object A_0, ComboBoxStyle A_1)
		{
			A_0.DropDownStyle = A_1;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x000258BC File Offset: 0x00023ABC
		internal static void scPSmFihKgRV47xXFZQ(object A_0, int A_1)
		{
			A_0.StartIndex = A_1;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x000258CC File Offset: 0x00023ACC
		internal static void QXLTdLiS2A3LwtG90ws(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x000258DC File Offset: 0x00023ADC
		internal static object gBFD6UiIE14syZ5nRUZ(object A_0)
		{
			return A_0.DisabledState;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x000258E8 File Offset: 0x00023AE8
		internal static void tRMKuWiiLgmaY6xGY7v(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x000258F8 File Offset: 0x00023AF8
		internal static void GOQ6mliZ99yg9aWmiSk(object A_0, Color A_1)
		{
			A_0.PlaceholderForeColor = A_1;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00025908 File Offset: 0x00023B08
		internal static object Jlq43diUhDdv5DIhVjg(object A_0)
		{
			return A_0.FocusedState;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00025914 File Offset: 0x00023B14
		internal static void TEkSI5i126jFtHpxr4P(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00025924 File Offset: 0x00023B24
		internal static void bnrr8uiplYjGFY5NtLt(object A_0, char A_1)
		{
			A_0.PasswordChar = A_1;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00025934 File Offset: 0x00023B34
		internal static void GtfMAhi4Efiicblyei4(object A_0, object A_1)
		{
			A_0.PlaceholderText = A_1;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00025944 File Offset: 0x00023B44
		internal static void kAoHyLiOcqbsYb6GYdV(object A_0, object A_1)
		{
			A_0.SelectedText = A_1;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00025954 File Offset: 0x00023B54
		internal static void UDBpMTifsAVJ3rf3uW5(object A_0, Point A_1)
		{
			A_0.TextOffset = A_1;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00025964 File Offset: 0x00023B64
		internal static void AwaROtiFKjpY0D2Lhkk(object A_0, object A_1)
		{
			A_0.TextChanged += A_1;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00025974 File Offset: 0x00023B74
		internal static void IdQ3l0iTV65Ufl1oFyW(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00025984 File Offset: 0x00023B84
		internal static void Fb8UmLiRlpCh8WUG8v0(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00025994 File Offset: 0x00023B94
		internal static object hgQ7OUiLBG9h0tLB2Ug(object A_0)
		{
			return A_0.HoverState;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000259A0 File Offset: 0x00023BA0
		internal static void uyiPqPilkVZPP2eqCPv(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000259B0 File Offset: 0x00023BB0
		internal static void wMMuMWiaRiJ3MryRMFB(object A_0, object A_1)
		{
			A_0.DefaultText = A_1;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000259C0 File Offset: 0x00023BC0
		internal static void TQ7387iKhdplLvSeKQ7(object A_0, bool A_1)
		{
			A_0.ReadOnly = A_1;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x000259D0 File Offset: 0x00023BD0
		internal static void bF72MSiemya99sOoryl(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x000259E0 File Offset: 0x00023BE0
		internal static void oSrhFjikdPlqytd0vSX(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x000259F0 File Offset: 0x00023BF0
		internal static void OwXluvird6m1iOdasF2(object A_0, LinearGradientMode A_1)
		{
			A_0.GradientMode = A_1;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00025A00 File Offset: 0x00023C00
		internal static void zFQ3WEi7DcDeehUBE0t(object A_0, object A_1)
		{
			A_0.Paint += A_1;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00025A10 File Offset: 0x00023C10
		internal static void MfatdIi2l6oI10Dp7f2(object A_0, bool A_1)
		{
			A_0.Animated = A_1;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00025A20 File Offset: 0x00023C20
		internal static void eGWnMxi65OSwTQYt7n4(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00025A30 File Offset: 0x00023C30
		internal static void SchZQeiNyn2h4aGZyAH(object A_0, int A_1)
		{
			A_0.BorderRadius = A_1;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00025A40 File Offset: 0x00023C40
		internal static void D0PVq6inSGOc9NA41Gn(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00025A50 File Offset: 0x00023C50
		internal static object Ch22WCi0tQuJvsxSHTH(object A_0)
		{
			return A_0.ShadowDecoration;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00025A5C File Offset: 0x00023C5C
		internal static void acYlSOiJcoJP0X8UbEL(object A_0, bool A_1)
		{
			A_0.Enabled = A_1;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00025A6C File Offset: 0x00023C6C
		internal static void H2Y868imN0R3hi3RCni(object A_0, Padding A_1)
		{
			A_0.Shadow = A_1;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00025A7C File Offset: 0x00023C7C
		internal static void V2VuSDiHi2u8pdosmn2(object A_0, bool A_1)
		{
			A_0.UseTransparentBackground = A_1;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00025A8C File Offset: 0x00023C8C
		internal static void jFEDIBitpCPjeWrEdkl(object A_0, float A_1)
		{
			A_0.ImageRotate = A_1;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00025A9C File Offset: 0x00023C9C
		internal static void sCe17XiYW9iTPSTjkEk(object A_0, PictureBoxSizeMode A_1)
		{
			A_0.SizeMode = A_1;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00025AAC File Offset: 0x00023CAC
		internal static void ADQeAgis8rtmU242cdc(object A_0, int A_1)
		{
			A_0.TabIndex = A_1;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00025ABC File Offset: 0x00023CBC
		internal static void thaHaeigK1YcARZBfq2(object A_0, bool A_1)
		{
			A_0.UseTransparentBackground = A_1;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00025ACC File Offset: 0x00023CCC
		internal static void fW5jjUiXsjSfqLiKplO(object A_0, bool A_1)
		{
			A_0.UseTransparentDrag = A_1;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00025ADC File Offset: 0x00023CDC
		internal static void eWtKAdiMQJ3ku2SW7mE(object A_0, double A_1)
		{
			A_0.DockIndicatorTransparencyValue = A_1;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00025AEC File Offset: 0x00023CEC
		internal static void r72bbiiGeTaV9ecgvYb(object A_0, Color A_1)
		{
			A_0.FillColor = A_1;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00025AFC File Offset: 0x00023CFC
		internal static void aoeEisiBjPmBWjmPoeZ(object A_0, bool A_1)
		{
			A_0.TabStop = A_1;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00025B0C File Offset: 0x00023D0C
		internal static void YAW99MiDY6HFI2Fbo0b(object A_0, bool A_1)
		{
			A_0.Animated = A_1;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00025B1C File Offset: 0x00023D1C
		internal static void kuuVDJivF2fmWwSDAEy(object A_0, Color A_1)
		{
			A_0.BorderColor = A_1;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00025B2C File Offset: 0x00023D2C
		internal static void ALY22AijnRSR6O15eYd(object A_0, int A_1)
		{
			A_0.BorderThickness = A_1;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00025B3C File Offset: 0x00023D3C
		internal static void gWt4yZibQt8uoyok1N0(object A_0, CharacterCasing A_1)
		{
			A_0.CharacterCasing = A_1;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00025B4C File Offset: 0x00023D4C
		internal static object glHvxQizGEmlSdVxtOt()
		{
			return Cursors.Default;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00025B54 File Offset: 0x00023D54
		internal static void gXLZdyZWdMVsRAfFt9y(object A_0, Color A_1)
		{
			A_0.ForeColor = A_1;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00025B64 File Offset: 0x00023D64
		internal static void wgvdrvZPNCOcP3CZ17u(object A_0, Size A_1)
		{
			A_0.IconLeftSize = A_1;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00025B74 File Offset: 0x00023D74
		internal static void bNdtf5ZEqUbnGHHBO8s(object A_0, bool A_1)
		{
			A_0.TabStop = A_1;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00025B84 File Offset: 0x00023D84
		internal static void kwtQAaZcMY6Hv2kogtG(object A_0, bool A_1)
		{
			A_0.Animated = A_1;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00025B94 File Offset: 0x00023D94
		internal static object kjNI22Z57lKULC4Mx8H(object A_0)
		{
			return A_0.DisabledState;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00025BA0 File Offset: 0x00023DA0
		internal static object aAPe6rZxwU6t38Vswk4(object A_0)
		{
			return A_0.ShadowDecoration;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00025BAC File Offset: 0x00023DAC
		internal static void xwCl3nZuD0aj5Q7mMpW(object A_0, bool A_1)
		{
			A_0.UseTransparentBackground = A_1;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00025BBC File Offset: 0x00023DBC
		internal static void FO7CTrZVy9iq7i2SVpZ(object A_0, MessageDialogButtons A_1)
		{
			A_0.Buttons = A_1;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00025BCC File Offset: 0x00023DCC
		internal static void l8ayRqZymWsqQc7NdKi(object A_0, object A_1)
		{
			A_0.Caption = A_1;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00025BDC File Offset: 0x00023DDC
		internal static void OT5lfdZ82ChkuedMGB6(object A_0, MessageDialogStyle A_1)
		{
			A_0.Style = A_1;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00025BEC File Offset: 0x00023DEC
		internal static void utyvnhZqF726m1cVEH7(object A_0, object A_1)
		{
			A_0.Text = A_1;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00025BFC File Offset: 0x00023DFC
		internal static void kj4P6wZd7UCdDhdtFYa(object A_0, object A_1)
		{
			A_0.ImageStream = A_1;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00025C0C File Offset: 0x00023E0C
		internal static void YPRcuOZoty6L8p0TrHX(object A_0, object A_1)
		{
			A_0.FileName = A_1;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00025C1C File Offset: 0x00023E1C
		internal static void WeAMDIZ3OJV2FuY6yVH(object A_0, bool A_1)
		{
			A_0.Enabled = A_1;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00025C2C File Offset: 0x00023E2C
		internal static void TPKNrkZQIIv0BEhtcQb(object A_0, object A_1)
		{
			A_0.Tick += A_1;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00025C3C File Offset: 0x00023E3C
		internal static object KWXkJRZCQ2vp6uQLTcI(object A_0)
		{
			return A_0.ObservableFormats;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00025C48 File Offset: 0x00023E48
		internal static void qeii3EZ92Gnjx4nu7we(object A_0, bool A_1)
		{
			A_0.Files = A_1;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00025C58 File Offset: 0x00023E58
		internal static void GP9Tc3ZwKcmFGgSKjSl(object A_0, bool A_1)
		{
			A_0.Images = A_1;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00025C68 File Offset: 0x00023E68
		internal static void i8t5oYZA0h2Zq94fUDR(object A_0, bool A_1)
		{
			A_0.Others = A_1;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00025C78 File Offset: 0x00023E78
		internal static void lG5b8lZhnSxB4pV8GJt(object A_0, bool A_1)
		{
			A_0.Texts = A_1;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00025C88 File Offset: 0x00023E88
		internal static void xlhy3UZSAFrXUcbdLNU(object A_0, bool A_1)
		{
			A_0.ObserveLastEntry = A_1;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00025C98 File Offset: 0x00023E98
		internal static void oTjtXbZIIoS4LWlsrED(object A_0, int A_1)
		{
			A_0.ReshowDelay = A_1;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00025CA8 File Offset: 0x00023EA8
		internal static void oSbS6yZi1nlb76ZQy80(object A_0, SizeF A_1)
		{
			A_0.AutoScaleDimensions = A_1;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00025CB8 File Offset: 0x00023EB8
		internal static void pdJJHQZZlfNROfR2yZ0(object A_0, AutoScaleMode A_1)
		{
			A_0.AutoScaleMode = A_1;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00025CC8 File Offset: 0x00023EC8
		internal static object lhQG5DZUPFpbhUYGZty(object A_0)
		{
			return A_0.Controls;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00025CD4 File Offset: 0x00023ED4
		internal static void kLAGfDZ1w3Csel834qc(object A_0, FormBorderStyle A_1)
		{
			A_0.FormBorderStyle = A_1;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00025CE4 File Offset: 0x00023EE4
		internal static void Y1lD2KZpgU9xXi0yV6l(object A_0, object A_1)
		{
			A_0.MainMenuStrip = A_1;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00025CF4 File Offset: 0x00023EF4
		internal static void xXBXrNZ41pXZ0s2hpb0(object A_0, object A_1)
		{
			A_0.Name = A_1;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00025D04 File Offset: 0x00023F04
		internal static void Ad7GlFZOdTMGNgNof4T(object A_0, FormStartPosition A_1)
		{
			A_0.StartPosition = A_1;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00025D14 File Offset: 0x00023F14
		internal static void Scmd91ZfPmDHvRhwdPD(object A_0, object A_1)
		{
			A_0.FormClosing += A_1;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00025D24 File Offset: 0x00023F24
		internal static void KqEGC6ZFSRhE9SaLP4V(object A_0, bool A_1)
		{
			A_0.ResumeLayout(A_1);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00025D34 File Offset: 0x00023F34
		internal static void GtWSMsZTTqoBGllCQwV(object A_0)
		{
			A_0.PerformLayout();
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00025D40 File Offset: 0x00023F40
		internal static void MyWd6GZRsTANcsJlHcx(object A_0)
		{
			((ISupportInitialize)A_0).EndInit();
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00025D4C File Offset: 0x00023F4C
		internal static AsyncTaskMethodBuilder uHZ3cfZLmqsjg5RooWH()
		{
			return AsyncTaskMethodBuilder.Create();
		}

		// Token: 0x040000F7 RID: 247
		private PrivateFontCollection fonts;

		// Token: 0x040000F8 RID: 248
		private PrivateFontCollection fontsBold;

		// Token: 0x040000F9 RID: 249
		private PrivateFontCollection fontsConsole;

		// Token: 0x040000FA RID: 250
		private PrivateFontCollection fontsLED;

		// Token: 0x040000FB RID: 251
		private PrivateFontCollection MagistralBook;

		// Token: 0x040000FC RID: 252
		private PrivateFontCollection MagistralMedium;

		// Token: 0x040000FD RID: 253
		private PrivateFontCollection MagistralBold;

		// Token: 0x040000FE RID: 254
		private WowheadInfo wowhead;

		// Token: 0x040000FF RID: 255
		private RotationLab RotationObj;

		// Token: 0x04000100 RID: 256
		private WindowTracker FGTracker;

		// Token: 0x04000101 RID: 257
		private System.Timers.Timer PulseTimer;

		// Token: 0x04000102 RID: 258
		private string previousLog;

		// Token: 0x04000103 RID: 259
		private string logpath;

		// Token: 0x04000104 RID: 260
		private Hook KeyboardHook;

		// Token: 0x04000105 RID: 261
		private xcBF6XfpTXPOK6FjeY payload;

		// Token: 0x04000106 RID: 262
		private static readonly Dictionary<string, string> WoWKeys;

		// Token: 0x04000107 RID: 263
		private static readonly string[] AutoBindList;

		// Token: 0x04000108 RID: 264
		private static readonly string[] AutoBindModifierList;

		// Token: 0x04000109 RID: 265
		private static List<string> CannotUseShift;

		// Token: 0x0400010A RID: 266
		private Random random;

		// Token: 0x0400010B RID: 267
		private bool RotationIsLoading;

		// Token: 0x0400010C RID: 268
		private ceGL4JcAiPYF89VVIUS ks;

		// Token: 0x0400010D RID: 269
		private int KeyBindRow;

		// Token: 0x0400010E RID: 270
		private bool isPopulating;

		// Token: 0x0400010F RID: 271
		private string previousClipboardContent;

		// Token: 0x04000111 RID: 273
		private Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000112 RID: 274
		private Guna2TabControl guna2TabControl1;

		// Token: 0x04000113 RID: 275
		private TabPage tabRotation;

		// Token: 0x04000114 RID: 276
		private TabPage tabKeybinds;

		// Token: 0x04000115 RID: 277
		private TabPage tabSettings;

		// Token: 0x04000116 RID: 278
		private Guna2GradientPanel guna2GradientPanel1;

		// Token: 0x04000117 RID: 279
		private Guna2DragControl guna2DragControl1;

		// Token: 0x04000118 RID: 280
		private Guna2PictureBox guna2PictureBox1;

		// Token: 0x04000119 RID: 281
		private Guna2DragControl guna2DragControl2;

		// Token: 0x0400011A RID: 282
		private TabPage tabLog;

		// Token: 0x0400011B RID: 283
		private TabPage tabAccount;

		// Token: 0x0400011C RID: 284
		private TextBox textConsole;

		// Token: 0x0400011D RID: 285
		private Guna2Button guna2Button1;

		// Token: 0x0400011E RID: 286
		private Guna2GradientPanel guna2GradientPanel2;

		// Token: 0x0400011F RID: 287
		private Guna2GradientButton btnStartStop;

		// Token: 0x04000120 RID: 288
		private Guna2TextBox textStatus;

		// Token: 0x04000121 RID: 289
		private Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000122 RID: 290
		private Guna2MessageDialog guna2MessageDialog1;

		// Token: 0x04000123 RID: 291
		private ImageList imageList2;

		// Token: 0x04000124 RID: 292
		private Guna2PictureBox statusIcon;

		// Token: 0x04000125 RID: 293
		private Guna2TabControl guna2TabSettings;

		// Token: 0x04000126 RID: 294
		private TabPage tabPage1;

		// Token: 0x04000127 RID: 295
		private TabPage tabPage2;

		// Token: 0x04000128 RID: 296
		private OpenFileDialog openFileDialog1;

		// Token: 0x04000129 RID: 297
		private Guna2TextBox textAddonName;

		// Token: 0x0400012A RID: 298
		private Label label2;

		// Token: 0x0400012B RID: 299
		private Guna2Button guna2Button2;

		// Token: 0x0400012C RID: 300
		private Guna2TextBox textGameFolder;

		// Token: 0x0400012D RID: 301
		private Label label1;

		// Token: 0x0400012E RID: 302
		private Guna2TabControl guna2TabControl2;

		// Token: 0x0400012F RID: 303
		private TabPage tabPage3;

		// Token: 0x04000130 RID: 304
		private TabPage tabPage4;

		// Token: 0x04000131 RID: 305
		private ImageList imageList3;

		// Token: 0x04000132 RID: 306
		private ListView listView1;

		// Token: 0x04000133 RID: 307
		private ColumnHeader columnHeader1;

		// Token: 0x04000134 RID: 308
		private ColumnHeader columnHeader2;

		// Token: 0x04000135 RID: 309
		private MenuStrip menuStrip1;

		// Token: 0x04000136 RID: 310
		private ToolStripMenuItem addScriptToolStripMenuItem;

		// Token: 0x04000137 RID: 311
		private ToolStripMenuItem loadSelectedToolStripMenuItem;

		// Token: 0x04000138 RID: 312
		private ToolStripMenuItem removeScriptToolStripMenuItem;

		// Token: 0x04000139 RID: 313
		private ToolStripMenuItem editToolStripMenuItem;

		// Token: 0x0400013A RID: 314
		private Guna2ComboBox guna2ComboBox1;

		// Token: 0x0400013B RID: 315
		private Label label3;

		// Token: 0x0400013C RID: 316
		private Guna2DataGridView DataGridSpell;

		// Token: 0x0400013D RID: 317
		private Guna2NotificationPaint guna2NotificationPaint1;

		// Token: 0x0400013E RID: 318
		private Guna2ContainerControl PanelKeyBind;

		// Token: 0x0400013F RID: 319
		private Guna2ProgressIndicator guna2ProgressIndicator1;

		// Token: 0x04000140 RID: 320
		private Guna2Button btnCancelBind;

		// Token: 0x04000141 RID: 321
		private Label labelKeyPreview;

		// Token: 0x04000142 RID: 322
		private ContextMenuStrip contextMenuShowMacro;

		// Token: 0x04000143 RID: 323
		private ToolStripMenuItem toolStripMenuItemShowMacro;

		// Token: 0x04000144 RID: 324
		private ToolStripMenuItem toolStripMenuItemClearBind;

		// Token: 0x04000145 RID: 325
		private ToolStripSeparator toolStripSeparator1;

		// Token: 0x04000146 RID: 326
		private Guna2DataGridView DataGridSettings;

		// Token: 0x04000147 RID: 327
		private DataGridViewTextBoxColumn ColSettingsName;

		// Token: 0x04000148 RID: 328
		private DataGridViewTextBoxColumn ColSettingsValue;

		// Token: 0x04000149 RID: 329
		private Guna2Button guna2Button4;

		// Token: 0x0400014A RID: 330
		private Guna2Button guna2Button3;

		// Token: 0x0400014B RID: 331
		private Guna2ComboBox comboKeyboard;

		// Token: 0x0400014C RID: 332
		private Label label7;

		// Token: 0x0400014D RID: 333
		private Guna2Button guna2Button6;

		// Token: 0x0400014E RID: 334
		private Guna2Button guna2Button5;

		// Token: 0x0400014F RID: 335
		private Guna2TextBox txtLicenseExpiry;

		// Token: 0x04000150 RID: 336
		private Label label10;

		// Token: 0x04000151 RID: 337
		private Guna2TextBox txtLicenseType;

		// Token: 0x04000152 RID: 338
		private Label label9;

		// Token: 0x04000153 RID: 339
		private Guna2TextBox txtUsername;

		// Token: 0x04000154 RID: 340
		private Label label8;

		// Token: 0x04000155 RID: 341
		private System.Windows.Forms.Timer timer1;

		// Token: 0x04000156 RID: 342
		private Guna2Button guna2Button7;

		// Token: 0x04000157 RID: 343
		private SharpClipboard sharpClipboard1;

		// Token: 0x04000158 RID: 344
		private WebView2 webView21;

		// Token: 0x04000159 RID: 345
		private TabPage tabPage5;

		// Token: 0x0400015A RID: 346
		private Label label11;

		// Token: 0x0400015B RID: 347
		private Guna2ToggleSwitch toggleManualCastQueue;

		// Token: 0x0400015C RID: 348
		private Label label6;

		// Token: 0x0400015D RID: 349
		private Guna2NumericUpDown textPreCast;

		// Token: 0x0400015E RID: 350
		private Label label5;

		// Token: 0x0400015F RID: 351
		private Guna2NumericUpDown textPulseFrequency;

		// Token: 0x04000160 RID: 352
		private Label label4;

		// Token: 0x04000161 RID: 353
		private Guna2NumericUpDown textAddonRefreshRate;

		// Token: 0x04000162 RID: 354
		private ToolTip toolTip1;

		// Token: 0x04000163 RID: 355
		private Label label13;

		// Token: 0x04000164 RID: 356
		private Guna2ToggleSwitch toggleAutoTab;

		// Token: 0x04000165 RID: 357
		private Label label12;

		// Token: 0x04000166 RID: 358
		private Guna2ToggleSwitch toggleAttackOutOfCombat;

		// Token: 0x04000167 RID: 359
		private Guna2Button guna2Button8;

		// Token: 0x04000168 RID: 360
		private DataGridViewImageColumn ColIcon;

		// Token: 0x04000169 RID: 361
		private DataGridViewTextBoxColumn ColType;

		// Token: 0x0400016A RID: 362
		private DataGridViewTextBoxColumn ColName;

		// Token: 0x0400016B RID: 363
		private DataGridViewTextBoxColumn ColKeybind;

		// Token: 0x0400016C RID: 364
		private DataGridViewButtonColumn ColBindBtn;

		// Token: 0x0400016D RID: 365
		private DataGridViewCheckBoxColumn ColDisabled;

		// Token: 0x0400016E RID: 366
		private Guna2GradientPanel guna2GradientPanel3;

		// Token: 0x0400016F RID: 367
		private Guna2Button btnReGenerateAddon;

		// Token: 0x04000170 RID: 368
		private Label label14;

		// Token: 0x04000171 RID: 369
		private Guna2ToggleSwitch toggleAutoBind;

		// Token: 0x04000172 RID: 370
		private Guna2Button guna2Button9;

		// Token: 0x04000173 RID: 371
		private Guna2ComboBox comboPixelLocation;

		// Token: 0x04000174 RID: 372
		private Label label15;

		// Token: 0x04000175 RID: 373
		private Label label16;

		// Token: 0x04000176 RID: 374
		private Guna2ToggleSwitch toggleAttackTargetNotInCombat;

		// Token: 0x04000177 RID: 375
		private Guna2ComboBox comboGameVersion;

		// Token: 0x04000178 RID: 376
		private Label label17;

		// Token: 0x04000179 RID: 377
		internal static Form1 DZ0WUqQBPfg6ulLNkXV;

		// Token: 0x0200001E RID: 30
		private sealed class KSbjNact9uOZdZOHtsk : MulticastDelegate
		{
			// Token: 0x06000371 RID: 881
			public extern KSbjNact9uOZdZOHtsk(object \u0020, IntPtr \u0020);

			// Token: 0x06000372 RID: 882
			public extern void Invoke(string text);

			// Token: 0x06000373 RID: 883
			public extern IAsyncResult BeginInvoke(string text, AsyncCallback callback, object @object);

			// Token: 0x06000374 RID: 884
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000375 RID: 885 RVA: 0x0003C710 File Offset: 0x0003A910
			static KSbjNact9uOZdZOHtsk()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}
		}
	}
}
