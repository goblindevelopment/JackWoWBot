using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using MyU9Ep58ZH3s5ThDFJQ;
using wKolMkxZecDx58YaRR4;
using XR7RtrxI8Vm7Dgx9BKr;

namespace xDwZPux4SDqHCadp1SC
{
	// Token: 0x0200006B RID: 107
	internal class g7nourxp055gaU44Yrc
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x00047A0C File Offset: 0x00045C0C
		internal static void lLHifFIsCLsZtjvFfN0i()
		{
			if (!g7nourxp055gaU44Yrc.fO61e1VaT4)
			{
				int num = 74565;
				g7nourxp055gaU44Yrc.fO61e1VaT4 = true;
				object currentDomain = AppDomain.CurrentDomain;
				g7nourxp055gaU44Yrc.S5r1TrMslH = (num == 1193046);
				g7nourxp055gaU44Yrc.KsS7KeacG3hv9NdSpdA(currentDomain, new ResolveEventHandler(g7nourxp055gaU44Yrc.U7IxOhJZBU));
				g7nourxp055gaU44Yrc.yk3pdWa5r8wEHYcZqIO();
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00047A60 File Offset: 0x00045C60
		private static Assembly U7IxOhJZBU(object \u0020, ResolveEventArgs \u0020)
		{
			Hashtable aly1MDGy = g7nourxp055gaU44Yrc.ALy1MDGy45;
			Assembly result;
			lock (aly1MDGy)
			{
				string text = g7nourxp055gaU44Yrc.clgYKdaud0BoRAvykGc(g7nourxp055gaU44Yrc.XclCYFaxgKEpMq0pJ9G(\u0020));
				object obj = g7nourxp055gaU44Yrc.Axncn1aV3NNR72f4giQ(g7nourxp055gaU44Yrc.ALy1MDGy45, text);
				if (obj == null)
				{
					try
					{
						string text2 = g7nourxp055gaU44Yrc.lZyixeay4TgPHHY52dF(text);
						foreach (Assembly assembly in g7nourxp055gaU44Yrc.UgyRCJa8yfkM06RufCN().GetAssemblies())
						{
							if (g7nourxp055gaU44Yrc.oQ5NlxaowmHMKyN04W7(g7nourxp055gaU44Yrc.OR7Soiad0g2QBQoyl6c(g7nourxp055gaU44Yrc.x28kvBaqhwIwHDxUvHS(assembly))) == g7nourxp055gaU44Yrc.oQ5NlxaowmHMKyN04W7(text2))
							{
								if (!g7nourxp055gaU44Yrc.S5r1TrMslH)
								{
									return assembly;
								}
								if (g7nourxp055gaU44Yrc.ne06DtaQC55Dhhfn5W1(text, g7nourxp055gaU44Yrc.YAkPLoa3DAqLDoKvSq6(assembly.GetName()).ToString()))
								{
									return assembly;
								}
							}
						}
					}
					catch
					{
					}
				}
				if (obj == null)
				{
					try
					{
						g7nourxp055gaU44Yrc.YDR5fBaCF9Vr43RGpwu(true);
						string text3 = g7nourxp055gaU44Yrc.lZyixeay4TgPHHY52dF(text);
						byte[] u = g7nourxp055gaU44Yrc.ALbL01awVLLr9XdnQ6A(g7nourxp055gaU44Yrc.yyMCula9kJML55GsMn5(), text3);
						string text4 = g7nourxp055gaU44Yrc.pi0adBaS2ljmuxBSnSJ(g7nourxp055gaU44Yrc.bHZlX2aADPKEDRc3Nfw(326177456 ^ 326202610), g7nourxp055gaU44Yrc.baDne7ah1wCbxSSBb3D(vua32v5yjQhjRjK4YIO.LxG5S2Hn4o(u)));
						Stream stream = g7nourxp055gaU44Yrc.nt4teYaiR9ERmXa4gaA(Type.GetTypeFromHandle(g7nourxp055gaU44Yrc.AaN87XaI3eDGaj4Rphr(33554539)).Assembly, text4);
						if (stream != null)
						{
							try
							{
								vua32v5yjQhjRjK4YIO.jsNEGrxyc7c7MqjFUgf jsNEGrxyc7c7MqjFUgf = new vua32v5yjQhjRjK4YIO.jsNEGrxyc7c7MqjFUgf(stream);
								g7nourxp055gaU44Yrc.oaMPuGaZXkyqNTbMY0A(jsNEGrxyc7c7MqjFUgf).Position = 0L;
								byte[] array = new byte[stream.Length];
								g7nourxp055gaU44Yrc.emYci4aUUSFW7V4P4hl(jsNEGrxyc7c7MqjFUgf, array, 0, array.Length);
								g7nourxp055gaU44Yrc.sSVVP4a19eIhsY8pwST(jsNEGrxyc7c7MqjFUgf);
								bool flag2 = false;
								Assembly assembly2 = null;
								try
								{
									assembly2 = g7nourxp055gaU44Yrc.k94SCuapSAfq5oOORcH(array);
								}
								catch (FileLoadException)
								{
									flag2 = true;
								}
								catch (BadImageFormatException)
								{
									flag2 = true;
								}
								if (flag2)
								{
									string text5 = Path.Combine(g7nourxp055gaU44Yrc.SUJ4hvaODZ0HnWUNmJb(g7nourxp055gaU44Yrc.CaAFTwa4rGxvCjAvmf1(), text4), g7nourxp055gaU44Yrc.pi0adBaS2ljmuxBSnSJ(text3, g7nourxp055gaU44Yrc.bHZlX2aADPKEDRc3Nfw(-1745773992 ^ -1745748934)));
									if (!File.Exists(text5) || !g7nourxp055gaU44Yrc.UMTxV0afPQRN5bOhsmU(g7nourxp055gaU44Yrc.Ct916PUAMe, text5))
									{
										try
										{
											g7nourxp055gaU44Yrc.iTQMrcaFXuevd0eLh9U(g7nourxp055gaU44Yrc.Ct916PUAMe, text5, null);
											if (!g7nourxp055gaU44Yrc.dvFIuMaTVmJu18a9pYu(Path.GetDirectoryName(text5)))
											{
												g7nourxp055gaU44Yrc.LxW0EmaL8wJg22Vsu8P(g7nourxp055gaU44Yrc.lvUr24aRaOUtTwJhaOa(text5));
											}
											FileStream fileStream = new FileStream(text5, FileMode.Create, FileAccess.Write);
											fileStream.Write(array, 0, array.Length);
											fileStream.Close();
										}
										catch (Exception)
										{
										}
									}
									assembly2 = Assembly.LoadFile(text5);
									g7nourxp055gaU44Yrc.FNQiasalMW860ik9a0F(g7nourxp055gaU44Yrc.ALy1MDGy45, text, assembly2);
								}
								else
								{
									g7nourxp055gaU44Yrc.FNQiasalMW860ik9a0F(g7nourxp055gaU44Yrc.ALy1MDGy45, text, assembly2);
								}
								return assembly2;
							}
							catch (Exception)
							{
							}
						}
						goto IL_282;
					}
					catch (Exception)
					{
						goto IL_282;
					}
					goto IL_275;
					IL_282:
					return null;
				}
				IL_275:
				result = (Assembly)obj;
			}
			return result;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00047DB4 File Offset: 0x00045FB4
		private static string HuFxfqytqZ(string \u0020)
		{
			string text = \u0020.Trim();
			int num = g7nourxp055gaU44Yrc.r9uQaaaaVA7MtqnTDad(text, ',');
			if (num >= 0)
			{
				text = g7nourxp055gaU44Yrc.k7wJZraKmpoUHnmqksr(text, 0, num);
			}
			return text;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00047DEC File Offset: 0x00045FEC
		public g7nourxp055gaU44Yrc()
		{
			g7nourxp055gaU44Yrc.YsxIIbaedLoR6hKgDrp();
			base..ctor();
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00047E00 File Offset: 0x00046000
		// Note: this type is marked as 'beforefieldinit'.
		static g7nourxp055gaU44Yrc()
		{
			g7nourxp055gaU44Yrc.uwnqxPakR2B2mfkawBl();
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			g7nourxp055gaU44Yrc.ALy1MDGy45 = new Hashtable();
			g7nourxp055gaU44Yrc.Ct916PUAMe = new Hashtable();
			g7nourxp055gaU44Yrc.S5r1TrMslH = false;
			g7nourxp055gaU44Yrc.fO61e1VaT4 = false;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00047E34 File Offset: 0x00046034
		internal static void KsS7KeacG3hv9NdSpdA(object A_0, object A_1)
		{
			A_0.AssemblyResolve += A_1;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00047E4C File Offset: 0x0004604C
		internal static void yk3pdWa5r8wEHYcZqIO()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00047E5C File Offset: 0x0004605C
		internal static object XclCYFaxgKEpMq0pJ9G(object A_0)
		{
			return A_0.Name;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00047E70 File Offset: 0x00046070
		internal static object clgYKdaud0BoRAvykGc(object A_0)
		{
			return A_0.Trim();
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00047E84 File Offset: 0x00046084
		internal static object Axncn1aV3NNR72f4giQ(object A_0, object A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00047E9C File Offset: 0x0004609C
		internal static object lZyixeay4TgPHHY52dF(object A_0)
		{
			return g7nourxp055gaU44Yrc.HuFxfqytqZ(A_0);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00047EB0 File Offset: 0x000460B0
		internal static object UgyRCJa8yfkM06RufCN()
		{
			return AppDomain.CurrentDomain;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00047EC0 File Offset: 0x000460C0
		internal static object x28kvBaqhwIwHDxUvHS(object A_0)
		{
			return A_0.GetName();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00047ED4 File Offset: 0x000460D4
		internal static object OR7Soiad0g2QBQoyl6c(object A_0)
		{
			return A_0.Name;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00047EE8 File Offset: 0x000460E8
		internal static object oQ5NlxaowmHMKyN04W7(object A_0)
		{
			return A_0.ToUpper();
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00047EFC File Offset: 0x000460FC
		internal static object YAkPLoa3DAqLDoKvSq6(object A_0)
		{
			return A_0.Version;
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00047F10 File Offset: 0x00046110
		internal static bool ne06DtaQC55Dhhfn5W1(object A_0, object A_1)
		{
			return A_0.Contains(A_1);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00047F28 File Offset: 0x00046128
		internal static void YDR5fBaCF9Vr43RGpwu(bool A_0)
		{
			RSACryptoServiceProvider.UseMachineKeyStore = A_0;
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00047F3C File Offset: 0x0004613C
		internal static object yyMCula9kJML55GsMn5()
		{
			return Encoding.Unicode;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00047F4C File Offset: 0x0004614C
		internal static object ALbL01awVLLr9XdnQ6A(object A_0, object A_1)
		{
			return A_0.GetBytes(A_1);
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00047F64 File Offset: 0x00046164
		internal static object bHZlX2aADPKEDRc3Nfw(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00047F78 File Offset: 0x00046178
		internal static object baDne7ah1wCbxSSBb3D(object A_0)
		{
			return Convert.ToBase64String(A_0);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00047F8C File Offset: 0x0004618C
		internal static object pi0adBaS2ljmuxBSnSJ(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00047FA4 File Offset: 0x000461A4
		internal static RuntimeTypeHandle AaN87XaI3eDGaj4Rphr(int token)
		{
			return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00047FB8 File Offset: 0x000461B8
		internal static object nt4teYaiR9ERmXa4gaA(object A_0, object A_1)
		{
			return A_0.GetManifestResourceStream(A_1);
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00047FD0 File Offset: 0x000461D0
		internal static object oaMPuGaZXkyqNTbMY0A(object A_0)
		{
			return A_0.m9OIO8Q0EK();
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00047FE4 File Offset: 0x000461E4
		internal static int emYci4aUUSFW7V4P4hl(object A_0, object A_1, int \u0020, int \u0020)
		{
			return A_0.VLRxqVOcxZ(A_1, \u0020, \u0020);
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00048004 File Offset: 0x00046204
		internal static void sSVVP4a19eIhsY8pwST(object A_0)
		{
			A_0.DIaxoZpvij();
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00048018 File Offset: 0x00046218
		internal static object k94SCuapSAfq5oOORcH(object A_0)
		{
			return Assembly.Load(A_0);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x0004802C File Offset: 0x0004622C
		internal static object CaAFTwa4rGxvCjAvmf1()
		{
			return Path.GetTempPath();
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x0004803C File Offset: 0x0004623C
		internal static object SUJ4hvaODZ0HnWUNmJb(object A_0, object A_1)
		{
			return Path.Combine(A_0, A_1);
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00048054 File Offset: 0x00046254
		internal static bool UMTxV0afPQRN5bOhsmU(object A_0, object A_1)
		{
			return A_0.ContainsKey(A_1);
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0004806C File Offset: 0x0004626C
		internal static void iTQMrcaFXuevd0eLh9U(object A_0, object A_1, object A_2)
		{
			A_0[A_1] = A_2;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00048088 File Offset: 0x00046288
		internal static bool dvFIuMaTVmJu18a9pYu(object A_0)
		{
			return Directory.Exists(A_0);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x0004809C File Offset: 0x0004629C
		internal static object lvUr24aRaOUtTwJhaOa(object A_0)
		{
			return Path.GetDirectoryName(A_0);
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000480B0 File Offset: 0x000462B0
		internal static object LxW0EmaL8wJg22Vsu8P(object A_0)
		{
			return Directory.CreateDirectory(A_0);
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x000480C4 File Offset: 0x000462C4
		internal static void FNQiasalMW860ik9a0F(object A_0, object A_1, object A_2)
		{
			A_0.Add(A_1, A_2);
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x000480E0 File Offset: 0x000462E0
		internal static int r9uQaaaaVA7MtqnTDad(object A_0, char A_1)
		{
			return A_0.IndexOf(A_1);
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x000480F8 File Offset: 0x000462F8
		internal static object k7wJZraKmpoUHnmqksr(object A_0, int A_1, int A_2)
		{
			return A_0.Substring(A_1, A_2);
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00048114 File Offset: 0x00046314
		internal static void YsxIIbaedLoR6hKgDrp()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00048124 File Offset: 0x00046324
		internal static void uwnqxPakR2B2mfkawBl()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x0400039E RID: 926
		private static Hashtable ALy1MDGy45;

		// Token: 0x0400039F RID: 927
		private static Hashtable Ct916PUAMe;

		// Token: 0x040003A0 RID: 928
		private static bool S5r1TrMslH;

		// Token: 0x040003A1 RID: 929
		private static bool fO61e1VaT4;
	}
}
