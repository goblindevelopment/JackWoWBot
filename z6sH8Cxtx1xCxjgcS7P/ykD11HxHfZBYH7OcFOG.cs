using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using MyU9Ep58ZH3s5ThDFJQ;
using wKolMkxZecDx58YaRR4;
using XR7RtrxI8Vm7Dgx9BKr;

namespace z6sH8Cxtx1xCxjgcS7P
{
	// Token: 0x0200006C RID: 108
	internal class ykD11HxHfZBYH7OcFOG
	{
		// Token: 0x060008EC RID: 2284 RVA: 0x00048134 File Offset: 0x00046334
		internal static object[] LOqxYEK3c2()
		{
			return new object[1];
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00048144 File Offset: 0x00046344
		internal static object[] iPaxs6S5Dh<u5Ygf7xgGKRPQ2x4jYQ>(int \u0020, object[] \u0020, object \u0020, ref u5Ygf7xgGKRPQ2x4jYQ \u0020)
		{
			object obj = ykD11HxHfZBYH7OcFOG.jxmIQ8C2ae;
			lock (obj)
			{
				if (!ykD11HxHfZBYH7OcFOG.YEyIU9TvJl)
				{
					ykD11HxHfZBYH7OcFOG.YEyIU9TvJl = true;
					ykD11HxHfZBYH7OcFOG.dEbxB8bRsf();
				}
			}
			ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu e9EX5Muevt1JiiEXHHu = null;
			if (ykD11HxHfZBYH7OcFOG.rImIhEtLPj[\u0020] != null)
			{
				e9EX5Muevt1JiiEXHHu = ykD11HxHfZBYH7OcFOG.rImIhEtLPj[\u0020];
			}
			else
			{
				ykD11HxHfZBYH7OcFOG.veGIAwTQTs.BaseStream.Position = (long)ykD11HxHfZBYH7OcFOG.UlsIi2d2qD[\u0020];
				e9EX5Muevt1JiiEXHHu = new ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu();
				Module module = Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(33554540)).Module;
				int metadataToken = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
				int num = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
				int num2 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
				int num3 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
				e9EX5Muevt1JiiEXHHu.tvNiDLeBvW = module.ResolveMethod(metadataToken);
				ParameterInfo[] parameters = e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.GetParameters();
				e9EX5Muevt1JiiEXHHu.C12iMMW3JJ = new ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp[parameters.Length];
				for (int i = 0; i < parameters.Length; i++)
				{
					Type type = parameters[i].ParameterType;
					ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp yvw1xyuLADtgscreJRp = new ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp();
					yvw1xyuLADtgscreJRp.SDOi93ObSo = type.IsByRef;
					yvw1xyuLADtgscreJRp.rpxidy7fkZ = i;
					e9EX5Muevt1JiiEXHHu.C12iMMW3JJ[i] = yvw1xyuLADtgscreJRp;
					if (type.IsByRef)
					{
						type = type.GetElementType();
					}
					ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ b6YiSr1Ws;
					if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777225)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)14;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777328)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777614)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777253)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777252)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777219)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777256)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777561)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777257)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777333)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777346)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777220)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777245)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777615)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13;
					}
					else if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777323)))
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15;
					}
					else
					{
						b6YiSr1Ws = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)0;
					}
					yvw1xyuLADtgscreJRp.b6YiSr1Ws1 = b6YiSr1Ws;
				}
				e9EX5Muevt1JiiEXHHu.u7wi6eANjd = new List<ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3>(num);
				for (int j = 0; j < num; j++)
				{
					int num4 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3 uao91Iul5XdTuF01HB = new ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3();
					uao91Iul5XdTuF01HB.Sy9iuWyJTO = null;
					if (num4 >= 0 && num4 < 50)
					{
						uao91Iul5XdTuF01HB.ob0itY7ilV = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)(num4 & 31);
						uao91Iul5XdTuF01HB.MnbiZVlnrv = ((num4 & 32) > 0);
					}
					uao91Iul5XdTuF01HB.RxQikAGpbV = j;
					e9EX5Muevt1JiiEXHHu.u7wi6eANjd.Add(uao91Iul5XdTuF01HB);
				}
				e9EX5Muevt1JiiEXHHu.f0ViTMY9D3 = new List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>(num2);
				for (int k = 0; k < num2; k++)
				{
					int num5 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					int num6 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP = new ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP();
					o7BGFwuaTreTeXAneXP.CHVi7uox8r = num5;
					o7BGFwuaTreTeXAneXP.bOdiOkNrnU = num6;
					ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE uvMdGKuKWaf5eqRkwyE = new ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE();
					o7BGFwuaTreTeXAneXP.aE6ioYbwF8 = uvMdGKuKWaf5eqRkwyE;
					num5 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					num6 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					int num7 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					uvMdGKuKWaf5eqRkwyE.oe3ivl4Hb5 = num5;
					uvMdGKuKWaf5eqRkwyE.ICtiRLSqEJ = num6;
					uvMdGKuKWaf5eqRkwyE.HThiPAKxeR = num7;
					if (num7 == 0)
					{
						uvMdGKuKWaf5eqRkwyE.fTxirp6Y0Y = module.ResolveType(ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs));
					}
					else if (num7 == 1)
					{
						uvMdGKuKWaf5eqRkwyE.mK9ibJJLQ8 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					}
					else
					{
						ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					}
					e9EX5Muevt1JiiEXHHu.f0ViTMY9D3.Add(o7BGFwuaTreTeXAneXP);
				}
				e9EX5Muevt1JiiEXHHu.f0ViTMY9D3.Sort(new Comparison<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>(ykD11HxHfZBYH7OcFOG.GUFtio1WcfP82d7tycE<u5Ygf7xgGKRPQ2x4jYQ>.<>9.uaRU74NwKL));
				e9EX5Muevt1JiiEXHHu.UAii4R1MbG = new List<ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt>(num3);
				for (int l = 0; l < num3; l++)
				{
					ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt oswePDupJwenbref1Qt = new ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt();
					byte b = ykD11HxHfZBYH7OcFOG.veGIAwTQTs.ReadByte();
					oswePDupJwenbref1Qt.Igyi81L3PF = (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)b;
					if (b >= 176)
					{
						throw new Exception();
					}
					int num8 = (int)ykD11HxHfZBYH7OcFOG.SqBIl5sXl7[(int)b];
					if (num8 == 0)
					{
						oswePDupJwenbref1Qt.ML8iCQiVG6 = null;
					}
					else
					{
						object ml8iCQiVG;
						switch (num8)
						{
						case 1:
							ml8iCQiVG = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
							break;
						case 2:
							ml8iCQiVG = ykD11HxHfZBYH7OcFOG.veGIAwTQTs.ReadInt64();
							break;
						case 3:
							ml8iCQiVG = ykD11HxHfZBYH7OcFOG.veGIAwTQTs.ReadSingle();
							break;
						case 4:
							ml8iCQiVG = ykD11HxHfZBYH7OcFOG.veGIAwTQTs.ReadDouble();
							break;
						case 5:
						{
							int num9 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
							int[] array = new int[num9];
							for (int m = 0; m < num9; m++)
							{
								array[m] = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
							}
							ml8iCQiVG = array;
							break;
						}
						default:
							throw new Exception();
						}
						oswePDupJwenbref1Qt.ML8iCQiVG6 = ml8iCQiVG;
					}
					e9EX5Muevt1JiiEXHHu.UAii4R1MbG.Add(oswePDupJwenbref1Qt);
				}
				ykD11HxHfZBYH7OcFOG.rImIhEtLPj[\u0020] = e9EX5Muevt1JiiEXHHu;
			}
			ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F xvaV1xuJTWO8QjAwq7F = new ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F();
			xvaV1xuJTWO8QjAwq7F.OOMlcvRAjr = e9EX5Muevt1JiiEXHHu;
			ParameterInfo[] parameters2 = e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.GetParameters();
			bool flag2 = false;
			int num10 = 0;
			if (e9EX5Muevt1JiiEXHHu.tvNiDLeBvW is MethodInfo && ((MethodInfo)e9EX5Muevt1JiiEXHHu.tvNiDLeBvW).ReturnType != Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777218)))
			{
				flag2 = true;
			}
			if (e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.IsStatic)
			{
				xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20 = new ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[parameters2.Length];
				for (int n = 0; n < parameters2.Length; n++)
				{
					Type parameterType = parameters2[n].ParameterType;
					xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[n] = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(parameterType, \u0020[n]);
					if (parameterType.IsByRef)
					{
						num10++;
					}
				}
			}
			else
			{
				xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20 = new ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[parameters2.Length + 1];
				if (e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.DeclaringType.IsValueType)
				{
					xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[0] = new ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N(new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(\u0020), e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.DeclaringType);
				}
				else
				{
					xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[0] = new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(\u0020);
				}
				for (int num11 = 0; num11 < parameters2.Length; num11++)
				{
					Type parameterType2 = parameters2[num11].ParameterType;
					if (parameterType2.IsByRef)
					{
						xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[num11 + 1] = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(parameterType2, \u0020[num11]);
						num10++;
					}
					else
					{
						xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[num11 + 1] = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(parameterType2, \u0020[num11]);
					}
				}
			}
			xvaV1xuJTWO8QjAwq7F.RGflstwkfS = new ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[e9EX5Muevt1JiiEXHHu.u7wi6eANjd.Count];
			for (int num12 = 0; num12 < e9EX5Muevt1JiiEXHHu.u7wi6eANjd.Count; num12++)
			{
				ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3 uao91Iul5XdTuF01HB2 = e9EX5Muevt1JiiEXHHu.u7wi6eANjd[num12];
				switch (uao91Iul5XdTuF01HB2.ob0itY7ilV)
				{
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)0:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = null;
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0, uao91Iul5XdTuF01HB2.ob0itY7ilV);
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(0L, uao91Iul5XdTuF01HB2.ob0itY7ilV);
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(0.0, uao91Iul5XdTuF01HB2.ob0itY7ilV);
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(IntPtr.Zero);
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(UIntPtr.Zero);
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)14:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = null;
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)16:
					xvaV1xuJTWO8QjAwq7F.RGflstwkfS[num12] = new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
					break;
				}
			}
			try
			{
				xvaV1xuJTWO8QjAwq7F.vgtumGHW1N();
			}
			finally
			{
				xvaV1xuJTWO8QjAwq7F.hnPuHBlWWr();
			}
			int num13 = 0;
			if (flag2)
			{
				num13 = 1;
			}
			num13 += num10;
			object[] array2 = new object[num13];
			if (flag2)
			{
				array2[0] = null;
			}
			if (e9EX5Muevt1JiiEXHHu.tvNiDLeBvW is MethodInfo)
			{
				MethodInfo methodInfo = (MethodInfo)e9EX5Muevt1JiiEXHHu.tvNiDLeBvW;
				if (methodInfo.ReturnType != Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777218)) && xvaV1xuJTWO8QjAwq7F.Goelx4gccH != null)
				{
					array2[0] = xvaV1xuJTWO8QjAwq7F.Goelx4gccH.y9jq31urLD(methodInfo.ReturnType);
				}
			}
			if (num10 > 0)
			{
				int num14 = 0;
				if (flag2)
				{
					num14++;
				}
				for (int num15 = 0; num15 < parameters2.Length; num15++)
				{
					Type type2 = parameters2[num15].ParameterType;
					if (type2.IsByRef)
					{
						type2 = type2.GetElementType();
						if (xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[num15] != null)
						{
							if (e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.IsStatic)
							{
								array2[num14] = xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[num15].y9jq31urLD(type2);
							}
							else
							{
								array2[num14] = xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[num15 + 1].y9jq31urLD(type2);
							}
						}
						else
						{
							array2[num14] = null;
						}
						num14++;
					}
				}
			}
			if (!e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.IsStatic && e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.DeclaringType.IsValueType)
			{
				\u0020 = (u5Ygf7xgGKRPQ2x4jYQ)((object)xvaV1xuJTWO8QjAwq7F.XZ2lKJZI20[0].y9jq31urLD(e9EX5Muevt1JiiEXHHu.tvNiDLeBvW.DeclaringType));
			}
			return array2;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00048C48 File Offset: 0x00046E48
		internal static object[] by2xXOQ8u6(int \u0020, object[] \u0020, object \u0020)
		{
			return ykD11HxHfZBYH7OcFOG.iPaxs6S5Dh<int>(\u0020, \u0020, \u0020, ref ykD11HxHfZBYH7OcFOG.t3gIdowUn3);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00048C60 File Offset: 0x00046E60
		internal static object[] jQGxMnXrlX<kq1JXAxGR3xbMtKy30K>(int \u0020, object[] \u0020, ref kq1JXAxGR3xbMtKy30K \u0020)
		{
			return ykD11HxHfZBYH7OcFOG.iPaxs6S5Dh<kq1JXAxGR3xbMtKy30K>(\u0020, \u0020, \u0020, ref \u0020);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00048C7C File Offset: 0x00046E7C
		internal static void dEbxB8bRsf()
		{
			int num = 2;
			int num2 = num;
			byte[] array;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2F;
				case 1:
				{
					BinaryReader binaryReader = new BinaryReader(ykD11HxHfZBYH7OcFOG.GKP2juanBE5ujmvuHQb(ykD11HxHfZBYH7OcFOG.y8y34XaNxltqEGgiFXD(ykD11HxHfZBYH7OcFOG.wrC3bJa6NJwLWwWbW98(33554540)).Assembly, "pEIYjZ8Oi0g613qrFD.5h8c3sqZDxhfFQcTEi"));
					ykD11HxHfZBYH7OcFOG.eRpCGCaJQWYNJQLU69K(ykD11HxHfZBYH7OcFOG.sq9I3Da0jAvWFY8KSBs(binaryReader), 0L);
					array = binaryReader.ReadBytes((int)ykD11HxHfZBYH7OcFOG.DFBJicamlXJMF8NspUO(ykD11HxHfZBYH7OcFOG.sq9I3Da0jAvWFY8KSBs(binaryReader)));
					binaryReader.Close();
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() != null)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					if (ykD11HxHfZBYH7OcFOG.UlsIi2d2qD != null)
					{
						return;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() == null)
					{
						num2 = 1;
					}
					break;
				}
			}
			IL_2F:
			ykD11HxHfZBYH7OcFOG.DgpGLvaHYCY3Zrc5fMk(array);
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00048D4C File Offset: 0x00046F4C
		internal static void LUsxDfXKnr(byte[] \u0020)
		{
			int num = 11;
			for (;;)
			{
				int num2 = num;
				int num6;
				for (;;)
				{
					int num3;
					int num4;
					int num5;
					int num8;
					int num9;
					int num10;
					switch (num2)
					{
					case 0:
						goto IL_1FB;
					case 1:
						goto IL_27E;
					case 2:
						return;
					case 3:
						num3 = 0;
						num2 = 30;
						continue;
					case 4:
						num4 = ykD11HxHfZBYH7OcFOG.pVISElatkxUXvBAoPPf(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
						num2 = 22;
						continue;
					case 5:
						num5++;
						num2 = 27;
						continue;
					case 6:
						goto IL_14B;
					case 7:
						goto IL_2E7;
					case 8:
						break;
					case 9:
					{
						int num7;
						ykD11HxHfZBYH7OcFOG.UlsIi2d2qD[num6] = num7;
						num2 = 17;
						continue;
					}
					case 10:
						ykD11HxHfZBYH7OcFOG.SqBIl5sXl7 = new byte[255];
						num2 = 4;
						continue;
					case 11:
						ykD11HxHfZBYH7OcFOG.veGIAwTQTs = new BinaryReader(new MemoryStream(\u0020));
						num2 = 10;
						continue;
					case 12:
						ykD11HxHfZBYH7OcFOG.SeUI5ROQ4U = new List<string>(num4);
						num2 = 14;
						continue;
					case 13:
						goto IL_3B7;
					case 14:
						num5 = 0;
						num2 = 6;
						if (!ykD11HxHfZBYH7OcFOG.Qo0yaDa7FKVuDfdcr9A())
						{
							num2 = 4;
							continue;
						}
						continue;
					case 15:
						ykD11HxHfZBYH7OcFOG.UlsIi2d2qD = new int[num4];
						num2 = 3;
						continue;
					case 16:
						goto IL_27E;
					case 17:
					{
						int num7;
						num7 += num8;
						num2 = 18;
						continue;
					}
					case 18:
						goto IL_22B;
					case 19:
						goto IL_399;
					case 20:
						goto IL_30B;
					case 21:
						break;
					case 22:
						num9 = 0;
						num2 = 7;
						continue;
					case 23:
						goto IL_16E;
					case 24:
						num3++;
						num2 = 7;
						if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() == null)
						{
							num2 = 19;
							continue;
						}
						continue;
					case 25:
						ykD11HxHfZBYH7OcFOG.SqBIl5sXl7[num10] = ykD11HxHfZBYH7OcFOG.p4GmxDaYk5iKVRXtZ32(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
						num2 = 26;
						continue;
					case 26:
						num9++;
						num2 = 31;
						continue;
					case 27:
						goto IL_14B;
					case 28:
						ykD11HxHfZBYH7OcFOG.UlsIi2d2qD[num3] = ykD11HxHfZBYH7OcFOG.pVISElatkxUXvBAoPPf(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
						num2 = 24;
						if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() != null)
						{
							num2 = 23;
							continue;
						}
						continue;
					case 29:
						goto IL_1A1;
					case 30:
						goto IL_399;
					case 31:
						goto IL_2E7;
					default:
						goto IL_1FB;
					}
					if (num6 >= num4)
					{
						return;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() != null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_14B:
					if (num5 >= num4)
					{
						goto IL_3B7;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.Qo0yaDa7FKVuDfdcr9A())
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_16E:
					ykD11HxHfZBYH7OcFOG.rImIhEtLPj[num3] = null;
					num2 = 28;
					continue;
					IL_399:
					if (num3 >= num4)
					{
						int num7 = (int)ykD11HxHfZBYH7OcFOG.fE7UEMaXrnhiMOnAQte(ykD11HxHfZBYH7OcFOG.veGIAwTQTs.BaseStream);
						num6 = 0;
						num2 = 21;
						continue;
					}
					goto IL_16E;
					IL_1A1:
					num10 = (int)ykD11HxHfZBYH7OcFOG.p4GmxDaYk5iKVRXtZ32(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					num2 = 25;
					continue;
					IL_2E7:
					if (num9 < num4)
					{
						goto IL_1A1;
					}
					num4 = ykD11HxHfZBYH7OcFOG.pVISElatkxUXvBAoPPf(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					num2 = 6;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() == null)
					{
						num2 = 12;
						continue;
					}
					continue;
					IL_27E:
					ykD11HxHfZBYH7OcFOG.SeUI5ROQ4U.Add(ykD11HxHfZBYH7OcFOG.YmdkKmagHCotar7LjhT(ykD11HxHfZBYH7OcFOG.FXKlUtasBrM2YlcAWfx(), ykD11HxHfZBYH7OcFOG.veGIAwTQTs.ReadBytes(ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs))));
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() == null)
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_30B:
					num8 = ykD11HxHfZBYH7OcFOG.UlsIi2d2qD[num6];
					num2 = 9;
					if (!ykD11HxHfZBYH7OcFOG.Qo0yaDa7FKVuDfdcr9A())
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_1FB:
					goto IL_30B;
					IL_3B7:
					num4 = ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(ykD11HxHfZBYH7OcFOG.veGIAwTQTs);
					ykD11HxHfZBYH7OcFOG.rImIhEtLPj = new ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu[num4];
					num2 = 15;
				}
				IL_22B:
				num6++;
				num = 8;
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0004916C File Offset: 0x0004736C
		internal static int YtBxvTIPyC(BinaryReader \u0020)
		{
			int num = 7;
			uint num4;
			for (;;)
			{
				int num2 = num;
				uint num5;
				for (;;)
				{
					bool flag;
					int num3;
					uint num6;
					switch (num2)
					{
					case 1:
						flag = true;
						goto IL_66;
					case 2:
						goto IL_F1;
					case 3:
						goto IL_7C;
					case 4:
						num3++;
						num2 = 5;
						continue;
					case 5:
						goto IL_D7;
					case 6:
						num4 = 0U;
						num2 = 3;
						continue;
					case 7:
						flag = false;
						num2 = 6;
						continue;
					case 8:
						num4 |= (num5 & 63U);
						num2 = 9;
						continue;
					case 9:
						if ((num5 & 64U) == 0U)
						{
							goto IL_66;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Qo0yaDa7FKVuDfdcr9A())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 10:
						if (flag)
						{
							goto IL_92;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Qo0yaDa7FKVuDfdcr9A())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 11:
						goto IL_5F;
					case 12:
						if (num6 >= 128U)
						{
							num2 = 4;
							continue;
						}
						goto IL_F1;
					case 13:
						goto IL_92;
					case 14:
						goto IL_D7;
					}
					goto Block_1;
					IL_66:
					if (num5 < 128U)
					{
						num2 = 10;
						continue;
					}
					num3 = 0;
					num2 = 10;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() == null)
					{
						num2 = 14;
						continue;
					}
					continue;
					IL_D7:
					num6 = (uint)\u0020.ReadByte();
					num4 |= (num6 & 127U) << 7 * num3 + 6;
					num2 = 4;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() == null)
					{
						num2 = 12;
						continue;
					}
					continue;
					IL_F1:
					if (!flag)
					{
						return (int)num4;
					}
					num2 = 5;
					if (ykD11HxHfZBYH7OcFOG.JmWoL6a2k0fdve8nPmU() == null)
					{
						num2 = 11;
					}
				}
				IL_7C:
				num5 = (uint)ykD11HxHfZBYH7OcFOG.p4GmxDaYk5iKVRXtZ32(\u0020);
				num = 8;
			}
			Block_1:
			return (int)num4;
			IL_5F:
			return (int)(~(int)num4);
			IL_92:
			return (int)(~(int)num4);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x0004935C File Offset: 0x0004755C
		public ykD11HxHfZBYH7OcFOG()
		{
			ykD11HxHfZBYH7OcFOG.VkKk0UaMGS8hMfJhtfV();
			ykD11HxHfZBYH7OcFOG.rNwYsZaG9kvHDOcFjAq();
			base..ctor();
			int num = 0;
			if (false)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000493B8 File Offset: 0x000475B8
		// Note: this type is marked as 'beforefieldinit'.
		static ykD11HxHfZBYH7OcFOG()
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					ykD11HxHfZBYH7OcFOG.jxmIQ8C2ae = 1;
					num2 = 3;
					continue;
				case 2:
					ykD11HxHfZBYH7OcFOG.rImIhEtLPj = null;
					ykD11HxHfZBYH7OcFOG.UlsIi2d2qD = null;
					num2 = 0;
					if (false)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					return;
				case 4:
					PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
					num2 = 2;
					continue;
				case 5:
					ykD11HxHfZBYH7OcFOG.VkKk0UaMGS8hMfJhtfV();
					num2 = 4;
					continue;
				}
				ykD11HxHfZBYH7OcFOG.YEyIU9TvJl = false;
				num2 = 1;
				if (true)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00049478 File Offset: 0x00047678
		internal static bool Qo0yaDa7FKVuDfdcr9A()
		{
			return ykD11HxHfZBYH7OcFOG.GOEjtoarY7M9suwDOp7 == null;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x0004948C File Offset: 0x0004768C
		internal static ykD11HxHfZBYH7OcFOG JmWoL6a2k0fdve8nPmU()
		{
			return ykD11HxHfZBYH7OcFOG.GOEjtoarY7M9suwDOp7;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0004949C File Offset: 0x0004769C
		internal static RuntimeTypeHandle wrC3bJa6NJwLWwWbW98(int token)
		{
			return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x000494B0 File Offset: 0x000476B0
		internal static Type y8y34XaNxltqEGgiFXD(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000494C4 File Offset: 0x000476C4
		internal static object GKP2juanBE5ujmvuHQb(object A_0, object A_1)
		{
			return A_0.GetManifestResourceStream(A_1);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000494DC File Offset: 0x000476DC
		internal static object sq9I3Da0jAvWFY8KSBs(object A_0)
		{
			return A_0.BaseStream;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x000494F0 File Offset: 0x000476F0
		internal static void eRpCGCaJQWYNJQLU69K(object A_0, long A_1)
		{
			A_0.Position = A_1;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00049508 File Offset: 0x00047708
		internal static long DFBJicamlXJMF8NspUO(object A_0)
		{
			return A_0.Length;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x0004951C File Offset: 0x0004771C
		internal static void DgpGLvaHYCY3Zrc5fMk(object A_0)
		{
			ykD11HxHfZBYH7OcFOG.LUsxDfXKnr(A_0);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00049530 File Offset: 0x00047730
		internal static int pVISElatkxUXvBAoPPf(object A_0)
		{
			return ykD11HxHfZBYH7OcFOG.YtBxvTIPyC(A_0);
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00049544 File Offset: 0x00047744
		internal static byte p4GmxDaYk5iKVRXtZ32(object A_0)
		{
			return A_0.ReadByte();
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00049558 File Offset: 0x00047758
		internal static object FXKlUtasBrM2YlcAWfx()
		{
			return Encoding.Unicode;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00049568 File Offset: 0x00047768
		internal static object YmdkKmagHCotar7LjhT(object A_0, object A_1)
		{
			return A_0.GetString(A_1);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00049580 File Offset: 0x00047780
		internal static long fE7UEMaXrnhiMOnAQte(object A_0)
		{
			return A_0.Position;
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00049594 File Offset: 0x00047794
		internal static void VkKk0UaMGS8hMfJhtfV()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000495A4 File Offset: 0x000477A4
		internal static void rNwYsZaG9kvHDOcFjAq()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x040003A2 RID: 930
		internal static ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu[] rImIhEtLPj;

		// Token: 0x040003A3 RID: 931
		internal static int[] UlsIi2d2qD;

		// Token: 0x040003A4 RID: 932
		internal static List<string> SeUI5ROQ4U;

		// Token: 0x040003A5 RID: 933
		private static BinaryReader veGIAwTQTs;

		// Token: 0x040003A6 RID: 934
		private static byte[] SqBIl5sXl7;

		// Token: 0x040003A7 RID: 935
		private static bool YEyIU9TvJl;

		// Token: 0x040003A8 RID: 936
		private static object jxmIQ8C2ae;

		// Token: 0x040003A9 RID: 937
		private static int t3gIdowUn3;

		// Token: 0x040003AA RID: 938
		private static ykD11HxHfZBYH7OcFOG GOEjtoarY7M9suwDOp7;

		// Token: 0x0200006D RID: 109
		[StructLayout(LayoutKind.Explicit)]
		public struct E2FUStxjTJDBkKYmvU1
		{
			// Token: 0x040003AB RID: 939
			[FieldOffset(0)]
			public byte N05hvQHtOX;

			// Token: 0x040003AC RID: 940
			[FieldOffset(0)]
			public sbyte lPnhRUkt2T;

			// Token: 0x040003AD RID: 941
			[FieldOffset(0)]
			public ushort cD0hN52nLH;

			// Token: 0x040003AE RID: 942
			[FieldOffset(0)]
			public short sJ3hrPWxX7;

			// Token: 0x040003AF RID: 943
			[FieldOffset(0)]
			public uint Vavhb40As7;

			// Token: 0x040003B0 RID: 944
			[FieldOffset(0)]
			public int RekhP3Apm0;
		}

		// Token: 0x0200006E RID: 110
		private class Y6ZjFnxbSGpN58JxU4F : ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB
		{
			// Token: 0x06000905 RID: 2309 RVA: 0x000495B4 File Offset: 0x000477B4
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.aYsh65bDic = ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic;
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				this.R7lhTZ1BpZ = ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).R7lhTZ1BpZ;
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x00049630 File Offset: 0x00047830
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.eFULqCKWhndmD7291gy(this, \u0020);
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x0004964C File Offset: 0x0004784C
			public Y6ZjFnxbSGpN58JxU4F(bool \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iTiaCQKPZ7eMyMjU2yq();
				base..ctor();
				int num = 2;
				if (true)
				{
					num = 6;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_102;
					case 1:
						goto IL_C3;
					case 2:
						if (!\u0020)
						{
							num = 7;
							continue;
						}
						goto IL_102;
					case 3:
						goto IL_C3;
					case 4:
						break;
					case 5:
						return;
					case 6:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)1;
						num = 2;
						continue;
					case 7:
						break;
					default:
						goto IL_102;
					}
					this.aYsh65bDic.RekhP3Apm0 = 0;
					num = 0;
					if (!false)
					{
						num = 1;
						continue;
					}
					continue;
					IL_C3:
					this.R7lhTZ1BpZ = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11;
					num = 5;
					if (!true)
					{
						num = 2;
						continue;
					}
					continue;
					IL_102:
					this.aYsh65bDic.RekhP3Apm0 = 1;
					num = 3;
				}
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x00049770 File Offset: 0x00047970
			public Y6ZjFnxbSGpN58JxU4F(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iTiaCQKPZ7eMyMjU2yq();
				base..ctor();
				int num = 0;
				if (true)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.aYsh65bDic.RekhP3Apm0 = \u0020.aYsh65bDic.RekhP3Apm0;
						num = 2;
						if (false)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						this.R7lhTZ1BpZ = \u0020.R7lhTZ1BpZ;
						num = 3;
						continue;
					case 3:
						return;
					}
					this.XyUUA5Idue = \u0020.XyUUA5Idue;
					num = 1;
					if (!true)
					{
						num = 0;
					}
				}
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x0004983C File Offset: 0x00047A3C
			public override ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB AxLq8nl88V()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this);
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x0004984C File Offset: 0x00047A4C
			public Y6ZjFnxbSGpN58JxU4F(int \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iTiaCQKPZ7eMyMjU2yq();
				base..ctor();
				int num = 2;
				if (false)
				{
					num = 2;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.aYsh65bDic.RekhP3Apm0 = \u0020;
						num = 3;
						continue;
					case 2:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)1;
						num = 1;
						if (!true)
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
						this.R7lhTZ1BpZ = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5;
						num = 0;
						if (false)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x00049904 File Offset: 0x00047B04
			public Y6ZjFnxbSGpN58JxU4F(uint \u0020)
			{
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Gx91n5KEQB4F2tpbR0X();
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iTiaCQKPZ7eMyMjU2yq();
				base..ctor();
				int num = 1;
				if (false)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)1;
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						return;
					case 3:
						this.R7lhTZ1BpZ = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6;
						num = 1;
						if (true)
						{
							num = 2;
							continue;
						}
						continue;
					}
					this.aYsh65bDic.Vavhb40As7 = \u0020;
					num = 3;
					if (!true)
					{
						num = 3;
					}
				}
			}

			// Token: 0x0600090C RID: 2316 RVA: 0x000499C8 File Offset: 0x00047BC8
			public Y6ZjFnxbSGpN58JxU4F(int \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Gx91n5KEQB4F2tpbR0X();
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iTiaCQKPZ7eMyMjU2yq();
				base..ctor();
				int num = 0;
				if (true)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
					{
						this.R7lhTZ1BpZ = \u0020;
						int num2 = 2;
						num = num2;
						continue;
					}
					case 2:
						return;
					case 3:
						this.aYsh65bDic.RekhP3Apm0 = \u0020;
						num = 1;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)1;
					num = 3;
					if (false)
					{
						num = 1;
					}
				}
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x00049A84 File Offset: 0x00047C84
			public Y6ZjFnxbSGpN58JxU4F(uint \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Gx91n5KEQB4F2tpbR0X();
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iTiaCQKPZ7eMyMjU2yq();
				base..ctor();
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.aYsh65bDic.Vavhb40As7 = \u0020;
						num = 2;
						if (!true)
						{
							num = 2;
							continue;
						}
						continue;
					case 2:
						this.R7lhTZ1BpZ = \u0020;
						num = 0;
						if (!false)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)1;
						num = 0;
						if (!false)
						{
							num = 1;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x00049B3C File Offset: 0x00047D3C
			public override bool WuHqq9Wdbv()
			{
				ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ r7lhTZ1BpZ = this.R7lhTZ1BpZ;
				switch (r7lhTZ1BpZ)
				{
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
					goto IL_58;
				default:
				{
					int num = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
					{
						num = 0;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_49;
						case 2:
							if (r7lhTZ1BpZ != (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15)
							{
								goto IL_58;
							}
							num = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num = 1;
								continue;
							}
							continue;
						}
						if (r7lhTZ1BpZ == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11)
						{
							break;
						}
						num = 2;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num = 0;
						}
					}
					break;
				}
				}
				IL_49:
				return this.aYsh65bDic.RekhP3Apm0 == 0;
				IL_58:
				return this.aYsh65bDic.Vavhb40As7 == 0U;
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x00049C20 File Offset: 0x00047E20
			public override bool icyqdm73mi()
			{
				return !ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WUHG7xKcVZJLx4iBZaA(this);
			}

			// Token: 0x06000910 RID: 2320 RVA: 0x00049C34 File Offset: 0x00047E34
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Q1tqoFEFyp(ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				switch (\u0020)
				{
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
					return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.sPxkgpKukuofmkJnXfZ(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
					return this.PQEqwQ01dQ();
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
					return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.LRKtmkKVkJEgRL7hMhk(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
					return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iLLP8aKyB0grqEgo6m7(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
					return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.CM2AguKxNPTdmUCu4mC(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)14:
					goto IL_E0;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11:
					return this.NtxqQI1Zcd();
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15:
					return this.vRquWm6ZXX();
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)16:
					return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.lpk9ZbK8G34vQyMQvNR(this);
				default:
					goto IL_E0;
				}
				IL_A1:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.VRciYXK5fqd1GM54nwc(this);
				IL_E0:
				ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4 ngYCBhqPZ7YsxPQyJh = (ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)4;
				int num = 1;
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					goto IL_A1;
				case 1:
					throw new Exception(ngYCBhqPZ7YsxPQyJh.ToString());
				default:
					goto IL_A1;
				}
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x00049D40 File Offset: 0x00047F40
			internal override object y9jq31urLD(Type \u0020)
			{
				int num = 26;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_3EF;
						case 2:
							\u0020 = \u0020.GetElementType();
							num2 = 22;
							continue;
						case 3:
							goto IL_367;
						case 4:
							if (\u0020.IsEnum)
							{
								goto IL_3AC;
							}
							num2 = 20;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 7;
								continue;
							}
							continue;
						case 5:
							goto IL_2AD;
						case 6:
							goto IL_27A;
						case 7:
							goto IL_234;
						case 8:
							goto IL_52A;
						case 9:
							goto IL_318;
						case 10:
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(\u0020, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777328))))
							{
								goto IL_367;
							}
							if (\u0020 == ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777614)))
							{
								num2 = 14;
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
								{
									num2 = 19;
									continue;
								}
								continue;
							}
							else
							{
								if (\u0020 == ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777220)))
								{
									goto Block_25;
								}
								if (\u0020 == ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777561)))
								{
									num2 = 15;
									continue;
								}
								if (\u0020 == ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777257)))
								{
									goto IL_234;
								}
								num2 = 17;
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
								{
									num2 = 17;
									continue;
								}
								continue;
							}
							break;
						case 11:
							goto IL_C8;
						case 12:
							if (!(\u0020 == ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777615))))
							{
								num2 = 4;
								continue;
							}
							goto IL_55F;
						case 13:
							goto IL_55F;
						case 14:
							goto IL_417;
						case 15:
							goto IL_4B4;
						case 16:
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(\u0020, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777252))))
							{
								num2 = 10;
								continue;
							}
							goto IL_318;
						case 17:
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(\u0020, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777323))))
							{
								num2 = 18;
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
								{
									num2 = 27;
									continue;
								}
								continue;
							}
							else
							{
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(\u0020, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777245))))
								{
									goto IL_2AD;
								}
								num2 = 11;
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
								{
									num2 = 12;
									continue;
								}
								continue;
							}
							break;
						case 18:
							goto IL_119;
						case 19:
							goto IL_5F8;
						case 20:
							goto IL_348;
						case 21:
							goto IL_ED;
						case 22:
							goto IL_4FA;
						case 23:
							goto IL_3AC;
						case 24:
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777219))))
							{
								num2 = 0;
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							else
							{
								if (\u0020 == Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777256)))
								{
									goto Block_24;
								}
								if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(\u0020, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777253))))
								{
									num2 = 16;
									continue;
								}
								goto IL_52A;
							}
							break;
						case 25:
							goto IL_4FA;
						case 26:
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.lqA7P7KqhIjklSXtpP4(\u0020, null))
							{
								num2 = 25;
								continue;
							}
							goto IL_C8;
						case 27:
							goto IL_631;
						}
						goto Block_1;
						IL_C8:
						if (!\u0020.IsByRef)
						{
							goto IL_4FA;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num2 = 2;
							continue;
						}
						continue;
						IL_ED:
						switch (this.R7lhTZ1BpZ)
						{
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
							goto IL_147;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
							goto IL_169;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
							goto IL_158;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
							goto IL_17A;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
							goto IL_119;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
							goto IL_12A;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
							goto IL_19D;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8:
							goto IL_1AF;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)14:
							goto IL_1C1;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11:
							goto IL_13B;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15:
							goto IL_18B;
						default:
							num2 = 14;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
							{
								num2 = 13;
								continue;
							}
							continue;
						}
						IL_4FA:
						if (\u0020 == null)
						{
							goto IL_ED;
						}
						IL_3EF:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777236))))
						{
							break;
						}
						goto IL_ED;
					}
					num = 24;
					continue;
					Block_25:
					num = 6;
				}
				Block_1:
				goto IL_59A;
				IL_119:
				return this.aYsh65bDic.RekhP3Apm0;
				IL_12A:
				return this.aYsh65bDic.Vavhb40As7;
				IL_13B:
				return this.icyqdm73mi();
				IL_147:
				return this.aYsh65bDic.lPnhRUkt2T;
				IL_158:
				return this.aYsh65bDic.sJ3hrPWxX7;
				IL_169:
				return this.aYsh65bDic.N05hvQHtOX;
				IL_17A:
				return this.aYsh65bDic.cD0hN52nLH;
				IL_18B:
				return (char)this.aYsh65bDic.RekhP3Apm0;
				IL_19D:
				return (long)this.aYsh65bDic.RekhP3Apm0;
				IL_1AF:
				return (ulong)this.aYsh65bDic.Vavhb40As7;
				IL_1C1:
				return this.aYsh65bDic.RekhP3Apm0;
				IL_234:
				return (ulong)this.aYsh65bDic.Vavhb40As7;
				IL_27A:
				return !this.WuHqq9Wdbv();
				IL_2AD:
				return new IntPtr(this.aYsh65bDic.RekhP3Apm0);
				IL_318:
				return this.aYsh65bDic.cD0hN52nLH;
				IL_348:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_367:
				return this.aYsh65bDic.N05hvQHtOX;
				IL_3AC:
				return this.FGexzsssCc(\u0020);
				IL_417:
				goto IL_1C1;
				IL_4B4:
				return (long)this.aYsh65bDic.RekhP3Apm0;
				IL_52A:
				return this.aYsh65bDic.sJ3hrPWxX7;
				IL_55F:
				return new UIntPtr(this.aYsh65bDic.Vavhb40As7);
				IL_59A:
				return this.aYsh65bDic.RekhP3Apm0;
				Block_24:
				return this.aYsh65bDic.Vavhb40As7;
				IL_5F8:
				return this.aYsh65bDic.lPnhRUkt2T;
				IL_631:
				return (char)this.aYsh65bDic.RekhP3Apm0;
			}

			// Token: 0x06000912 RID: 2322 RVA: 0x0004A3C4 File Offset: 0x000485C4
			internal object FGexzsssCc(Type \u0020)
			{
				int num = 8;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_B3;
					case 2:
						goto IL_233;
					case 3:
						goto IL_182;
					case 4:
					{
						Type type;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(type, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777252))))
						{
							num2 = 5;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 4;
								continue;
							}
							continue;
						}
						else
						{
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(type, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777328))))
							{
								goto IL_7C;
							}
							if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777614)))
							{
								num2 = 12;
								continue;
							}
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(type, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777561))))
							{
								num2 = 3;
								continue;
							}
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(type, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777257))))
							{
								goto IL_1FB;
							}
							num2 = 11;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
							{
								num2 = 10;
								continue;
							}
							continue;
						}
						break;
					}
					case 5:
						goto IL_EA;
					case 6:
						goto IL_1FB;
					case 7:
					{
						Type type;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(type, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777219))))
						{
							num2 = 9;
							continue;
						}
						if (type == ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777256)))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						else if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(type, ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.llGGCjK3H7HmGDO1NuC(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777253))))
						{
							num2 = 4;
							continue;
						}
						break;
					}
					case 8:
					{
						Type type = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.OjQyNfKQ56qBof3FCaJ(\u0020);
						num2 = 7;
						continue;
					}
					case 9:
						goto IL_23D;
					case 10:
						goto IL_7C;
					case 11:
					{
						Type type;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Qo7FvCKoCLBUZPoxVC6(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WNTp2bKd5JSutqHCwZn(16777323))))
						{
							num2 = 2;
							continue;
						}
						goto IL_57;
					}
					case 12:
						goto IL_284;
					}
					break;
				}
				goto IL_13B;
				IL_57:
				return Enum.ToObject(\u0020, (ushort)this.aYsh65bDic.RekhP3Apm0);
				IL_7C:
				return Enum.ToObject(\u0020, this.aYsh65bDic.N05hvQHtOX);
				IL_B3:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.KGAN2WK9SaKpqj5dLYn(\u0020, this.aYsh65bDic.Vavhb40As7);
				IL_EA:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AX0sR8KAfyMTEhWoK86(\u0020, this.aYsh65bDic.cD0hN52nLH);
				IL_13B:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zsBC25KwDmGysJ815uD(\u0020, this.aYsh65bDic.sJ3hrPWxX7);
				IL_182:
				return Enum.ToObject(\u0020, (long)this.aYsh65bDic.RekhP3Apm0);
				IL_1FB:
				return Enum.ToObject(\u0020, (ulong)this.aYsh65bDic.Vavhb40As7);
				IL_233:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.oW6QZmKCASFrLMArGny(\u0020, this.aYsh65bDic.RekhP3Apm0);
				IL_23D:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.oW6QZmKCASFrLMArGny(\u0020, this.aYsh65bDic.RekhP3Apm0);
				IL_284:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.nJDcMYKh8pifelkR4un(\u0020, this.aYsh65bDic.lPnhRUkt2T);
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x0004A6D0 File Offset: 0x000488D0
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NtxqQI1Zcd()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WUHG7xKcVZJLx4iBZaA(this))
						{
							goto IL_5B;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				int u = 1;
				goto IL_5C;
				IL_5B:
				u = 0;
				IL_5C:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(u);
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x0004A740 File Offset: 0x00048940
			internal override bool lPSqCCLN7S()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ka05h4KSSIyPyoHdrmh(this);
			}

			// Token: 0x06000915 RID: 2325 RVA: 0x0004A750 File Offset: 0x00048950
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F kZFq9GpslU()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)this.aYsh65bDic.lPnhRUkt2T, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x06000916 RID: 2326 RVA: 0x0004A76C File Offset: 0x0004896C
			public ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F vRquWm6ZXX()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x0004A788 File Offset: 0x00048988
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F PQEqwQ01dQ()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)this.aYsh65bDic.N05hvQHtOX, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x06000918 RID: 2328 RVA: 0x0004A7A4 File Offset: 0x000489A4
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Br0qAy7jU5()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)this.aYsh65bDic.sJ3hrPWxX7, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x06000919 RID: 2329 RVA: 0x0004A7C0 File Offset: 0x000489C0
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QtGqh2NDQ8()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)this.aYsh65bDic.cD0hN52nLH, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x0600091A RID: 2330 RVA: 0x0004A7DC File Offset: 0x000489DC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eoUqScGyAS()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x0600091B RID: 2331 RVA: 0x0004A7F8 File Offset: 0x000489F8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F U0ZqI72BOj()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.Vavhb40As7, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x0600091C RID: 2332 RVA: 0x0004A814 File Offset: 0x00048A14
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN JWZqiAqFR8()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((long)this.aYsh65bDic.RekhP3Apm0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x0600091D RID: 2333 RVA: 0x0004A830 File Offset: 0x00048A30
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN upCqZP4jJd()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((ulong)this.aYsh65bDic.Vavhb40As7, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x0600091E RID: 2334 RVA: 0x0004A84C File Offset: 0x00048A4C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lk5qURpdjk()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.sPxkgpKukuofmkJnXfZ(this);
			}

			// Token: 0x0600091F RID: 2335 RVA: 0x0004A85C File Offset: 0x00048A5C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F HK7q1PliPm()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.LRKtmkKVkJEgRL7hMhk(this);
			}

			// Token: 0x06000920 RID: 2336 RVA: 0x0004A86C File Offset: 0x00048A6C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F FOJqpHkit6()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.VRciYXK5fqd1GM54nwc(this);
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x0004A87C File Offset: 0x00048A7C
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN FmZq4JYpT6()
			{
				return this.JWZqiAqFR8();
			}

			// Token: 0x06000922 RID: 2338 RVA: 0x0004A88C File Offset: 0x00048A8C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F hYvqOWPpOC()
			{
				return this.PQEqwQ01dQ();
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x0004A89C File Offset: 0x00048A9C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F o1ZqfYXchM()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.iLLP8aKyB0grqEgo6m7(this);
			}

			// Token: 0x06000924 RID: 2340 RVA: 0x0004A8AC File Offset: 0x00048AAC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F oAjqFTEeFY()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.CM2AguKxNPTdmUCu4mC(this);
			}

			// Token: 0x06000925 RID: 2341 RVA: 0x0004A8BC File Offset: 0x00048ABC
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN SZBqTRsZeT()
			{
				return this.upCqZP4jJd();
			}

			// Token: 0x06000926 RID: 2342 RVA: 0x0004A8CC File Offset: 0x00048ACC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F ziwqR9N2wv()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((sbyte)this.aYsh65bDic.RekhP3Apm0)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x06000927 RID: 2343 RVA: 0x0004A8E8 File Offset: 0x00048AE8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F j5lqLol41P()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((sbyte)this.aYsh65bDic.Vavhb40As7)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x06000928 RID: 2344 RVA: 0x0004A904 File Offset: 0x00048B04
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NN3qlXny0A()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((short)this.aYsh65bDic.RekhP3Apm0)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x06000929 RID: 2345 RVA: 0x0004A920 File Offset: 0x00048B20
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F cMXqaCAZHq()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((short)this.aYsh65bDic.Vavhb40As7)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x0600092A RID: 2346 RVA: 0x0004A93C File Offset: 0x00048B3C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Vy2qKYUMDe()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x0600092B RID: 2347 RVA: 0x0004A958 File Offset: 0x00048B58
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QmjqeL3I7g()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((int)this.aYsh65bDic.Vavhb40As7), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x0600092C RID: 2348 RVA: 0x0004A974 File Offset: 0x00048B74
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN rMZqkTKtdW()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((long)this.aYsh65bDic.RekhP3Apm0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x0600092D RID: 2349 RVA: 0x0004A990 File Offset: 0x00048B90
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN c1Bqr7stpA()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((long)((ulong)this.aYsh65bDic.Vavhb40As7), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x0600092E RID: 2350 RVA: 0x0004A9AC File Offset: 0x00048BAC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lZtq7DP5OI()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((byte)this.aYsh65bDic.RekhP3Apm0)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x0600092F RID: 2351 RVA: 0x0004A9C8 File Offset: 0x00048BC8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eFOq2JXLOE()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((byte)this.aYsh65bDic.Vavhb40As7)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x06000930 RID: 2352 RVA: 0x0004A9E4 File Offset: 0x00048BE4
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F CVaq6fDwxc()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((ushort)this.aYsh65bDic.RekhP3Apm0)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x06000931 RID: 2353 RVA: 0x0004AA00 File Offset: 0x00048C00
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F rvkqNso51v()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((ushort)this.aYsh65bDic.Vavhb40As7)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x06000932 RID: 2354 RVA: 0x0004AA1C File Offset: 0x00048C1C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F RywqnVZSZT()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((uint)this.aYsh65bDic.RekhP3Apm0), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x06000933 RID: 2355 RVA: 0x0004AA38 File Offset: 0x00048C38
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Jefq04Qqj5()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.Vavhb40As7, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x06000934 RID: 2356 RVA: 0x0004AA54 File Offset: 0x00048C54
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN LYYqJD7UOL()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked((ulong)this.aYsh65bDic.RekhP3Apm0), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x06000935 RID: 2357 RVA: 0x0004AA70 File Offset: 0x00048C70
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN Msjqm6OQGU()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((ulong)this.aYsh65bDic.Vavhb40As7, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x06000936 RID: 2358 RVA: 0x0004AA8C File Offset: 0x00048C8C
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs qJhqHVUG8k()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((float)this.aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000937 RID: 2359 RVA: 0x0004AAA8 File Offset: 0x00048CA8
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs c1GqttOeWQ()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((double)this.aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000938 RID: 2360 RVA: 0x0004AAC4 File Offset: 0x00048CC4
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs HF1qYGZ8gN()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x06000939 RID: 2361 RVA: 0x0004AAE0 File Offset: 0x00048CE0
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb yRRqsHbNK7()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.FmZq4JYpT6().OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.WA4HV2KIL7rm93enGeN(this).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x0600093A RID: 2362 RVA: 0x0004AB38 File Offset: 0x00048D38
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb D1PqgOGTyj()
			{
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Hwt6H7Kip8AQ38HpdB8() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.SnDWf1KZhuoWqOBx9cg(this).OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.nF4HCDKUZktGl2c29pT(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x0600093B RID: 2363 RVA: 0x0004AB90 File Offset: 0x00048D90
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb XWcqXDk1Pt()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.xO1f5TK1WZjC84e4E0C(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)this.Vy2qKYUMDe().aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x0600093C RID: 2364 RVA: 0x0004ABE0 File Offset: 0x00048DE0
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb JjkqMxqLaY()
			{
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Hwt6H7Kip8AQ38HpdB8() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.j0E66FKp9TaKN2RMu3i(this).OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.NXwv9mK4FMZeMc0VjxA(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x0600093D RID: 2365 RVA: 0x0004AC30 File Offset: 0x00048E30
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb APcqGbirjs()
			{
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Hwt6H7Kip8AQ38HpdB8() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.bFVugRKOAwLTsdXHhpe(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Vq6TRqKflPMv89ANqlR(this).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x0600093E RID: 2366 RVA: 0x0004AC88 File Offset: 0x00048E88
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb CY1qBxKBHt()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.Msjqm6OQGU().OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)this.Jefq04Qqj5().aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x0600093F RID: 2367 RVA: 0x0004ACE0 File Offset: 0x00048EE0
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC CpmqDtDe45()
			{
				int num = 3;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ r7lhTZ1BpZ;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_33;
					case 1:
						if (r7lhTZ1BpZ == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11)
						{
							goto IL_AD;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
						}
						break;
					case 2:
						switch (r7lhTZ1BpZ)
						{
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
							goto IL_AD;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
							goto IL_BF;
						default:
							num2 = 1;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 1;
							}
							break;
						}
						break;
					case 3:
						r7lhTZ1BpZ = this.R7lhTZ1BpZ;
						num2 = 2;
						break;
					}
				}
				IL_33:
				if (r7lhTZ1BpZ != (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15)
				{
					goto IL_BF;
				}
				IL_AD:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(-this.aYsh65bDic.RekhP3Apm0);
				IL_BF:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(-(int)((ulong)this.aYsh65bDic.Vavhb40As7)));
			}

			// Token: 0x06000940 RID: 2368 RVA: 0x0004ADC0 File Offset: 0x00048FC0
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Add(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EA;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_37;
					case 3:
						goto IL_CB;
					case 4:
						goto IL_5F;
					default:
						goto IL_EA;
					}
					IL_4A:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num2 = 4;
						continue;
					}
					if (\u0020.tXF8H2TS5Y())
					{
						break;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_EA:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_4A;
				}
				IL_37:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.rJofs6KR2IGm2Ank0c4((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_5F:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 + ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_CB:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000941 RID: 2369 RVA: 0x0004AEC4 File Offset: 0x000490C4
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC LfyqvMrNHx(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_37;
					case 1:
						goto IL_E4;
					case 2:
						\u0020 = \u0020.s9Cd9Og84k();
						break;
					case 3:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 2;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 4:
						goto IL_78;
					}
					if (\u0020.jZ28mHocbm())
					{
						num2 = 4;
					}
					else
					{
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							goto IL_E4;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
						}
					}
				}
				IL_37:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_78:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked(this.aYsh65bDic.RekhP3Apm0 + ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_E4:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YXVrOvKlHepFNo6nTK0((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
			}

			// Token: 0x06000942 RID: 2370 RVA: 0x0004AFC8 File Offset: 0x000491C8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC KrBqjlnYTv(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_37;
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							goto IL_8B;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 2:
						goto IL_7E;
					case 3:
						\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
						break;
					case 4:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							num2 = 3;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					}
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						break;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num2 = 1;
					}
				}
				IL_37:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked(this.aYsh65bDic.Vavhb40As7 + ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7));
				IL_7E:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.nORtGiKK72TLE8012Oj((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_8B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000943 RID: 2371 RVA: 0x0004B0DC File Offset: 0x000492DC
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cmUqbj78eE(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
				{
					goto IL_84;
				}
				\u0020 = \u0020.s9Cd9Og84k();
				int num = 2;
				IL_10:
				switch (num)
				{
				default:
					return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 - ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				case 1:
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				case 2:
					IL_84:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num = 0;
							goto IL_10;
						}
						goto IL_10;
					}
					else if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
					{
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num = 1;
							goto IL_10;
						}
						goto IL_10;
					}
					break;
				case 3:
					break;
				}
				return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).SBRuqvWNJH(this);
			}

			// Token: 0x06000944 RID: 2372 RVA: 0x0004B1C8 File Offset: 0x000493C8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC iHaqzsE4Kf(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_6B;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_78;
					case 3:
						goto IL_58;
					default:
						goto IL_6B;
					}
					IL_AF:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					else
					{
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							num2 = 3;
							continue;
						}
						goto IL_65;
					}
					IL_6B:
					\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
					goto IL_AF;
				}
				IL_58:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.QiqlVqKeG7cwC8n6bA8((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_65:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_78:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked(this.aYsh65bDic.RekhP3Apm0 - ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000945 RID: 2373 RVA: 0x0004B2A8 File Offset: 0x000494A8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC auGdW5LU1o(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_AF;
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_7D;
					case 3:
						break;
					default:
						goto IL_AF;
					}
					if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						goto IL_9F;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_AF:
					\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
					num2 = 3;
				}
				IL_7D:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked(this.aYsh65bDic.Vavhb40As7 - ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7));
				IL_9F:
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
				{
					return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).o7wuohgjfY(this);
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000946 RID: 2374 RVA: 0x0004B388 File Offset: 0x00049588
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cT0dPKbnSa(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
							goto IL_BB;
						case 2:
							goto IL_67;
						case 3:
							goto IL_74;
						case 4:
							goto IL_54;
						case 5:
							if (\u0020.tXF8H2TS5Y())
							{
								goto IL_54;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						goto Block_1;
					}
					IL_3B:
					if (!\u0020.jZ28mHocbm())
					{
						num = 5;
						continue;
					}
					goto IL_BB;
					IL_67:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_3B;
					IL_74:
					if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
					{
						goto IL_3B;
					}
					num = 2;
				}
				Block_1:
				goto IL_8D;
				IL_54:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.uuhyiVKkLbxni9ZLK5D((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_8D:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_BB:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 * ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000947 RID: 2375 RVA: 0x0004B498 File Offset: 0x00049698
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC C3mdEhLvXd(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_3B;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							goto IL_C3;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_C3;
					case 4:
						goto IL_7C;
					case 5:
						goto IL_3B;
					}
					break;
					IL_3B:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num2 = 4;
						continue;
					}
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
					{
						goto IL_5F;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_C3:
					\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num2 = 5;
					}
				}
				goto IL_72;
				IL_5F:
				return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).C3mdEhLvXd(this);
				IL_72:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_7C:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked(this.aYsh65bDic.RekhP3Apm0 * ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000948 RID: 2376 RVA: 0x0004B5B0 File Offset: 0x000497B0
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC jaYdc2eCJF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							goto IL_3B;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_48;
					case 3:
						goto IL_70;
					case 4:
						goto IL_8F;
					case 5:
						goto IL_3B;
					}
					IL_5B:
					if (\u0020.jZ28mHocbm())
					{
						num2 = 4;
						continue;
					}
					if (!\u0020.tXF8H2TS5Y())
					{
						num2 = 3;
						continue;
					}
					break;
					IL_3B:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_5B;
				}
				IL_48:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.lmDyZTKrgsO5bDnFuP4((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_70:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_8F:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked(this.aYsh65bDic.Vavhb40As7 * ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7));
			}

			// Token: 0x06000949 RID: 2377 RVA: 0x0004B6C8 File Offset: 0x000498C8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC XIyd5fI2tA(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						\u0020 = \u0020.s9Cd9Og84k();
						break;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_8A;
					case 3:
						goto IL_D1;
					}
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num2 = 2;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 1;
						}
					}
					else
					{
						if (!\u0020.tXF8H2TS5Y())
						{
							goto IL_DE;
						}
						num2 = 3;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 2;
						}
					}
				}
				IL_8A:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 / ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_D1:
				return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).SNxu3GrT0Y(this);
				IL_DE:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x0600094A RID: 2378 RVA: 0x0004B7B8 File Offset: 0x000499B8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Ut1dxA1rQp(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 3:
						goto IL_59;
					case 4:
						goto IL_8B;
					}
					if (!\u0020.jZ28mHocbm())
					{
						goto IL_7B;
					}
					num2 = 3;
				}
				IL_59:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.Vavhb40As7 / ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7);
				IL_7B:
				if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_8B:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.s7BWNDK7mGkwFgkqtNV((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
			}

			// Token: 0x0600094B RID: 2379 RVA: 0x0004B8AC File Offset: 0x00049AAC
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC yCeduJ3YIo(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
							goto IL_58;
						case 2:
							goto IL_B2;
						case 3:
							goto IL_F9;
						case 4:
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
							{
								goto IL_58;
							}
							num2 = 3;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 1;
								continue;
							}
							continue;
						case 5:
							goto IL_F9;
						}
						goto Block_1;
						IL_F9:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
						{
							num2 = 2;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
							{
								num2 = 2;
							}
						}
						else
						{
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
							{
								goto IL_3B;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
							{
								num2 = 0;
							}
						}
					}
					IL_58:
					\u0020 = \u0020.s9Cd9Og84k();
					num = 5;
				}
				Block_1:
				goto IL_4E;
				IL_3B:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.smrTlfK2D2uZF6b6vDE((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_4E:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_B2:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 % ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x0600094C RID: 2380 RVA: 0x0004B9D8 File Offset: 0x00049BD8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC O5ndVV1NCh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							goto IL_F5;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_3B;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							goto IL_E2;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						goto IL_E2;
					case 5:
						goto IL_F5;
					}
					\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_F5:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						goto IL_79;
					}
					num2 = 3;
					if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
					{
						num2 = 3;
					}
				}
				IL_3B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_79:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.Vavhb40As7 % ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7);
				IL_E2:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.oDfAWaK61x6sslPYMN1((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
			}

			// Token: 0x0600094D RID: 2381 RVA: 0x0004BB00 File Offset: 0x00049D00
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC DyOdyCLR3X(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_3B;
					case 2:
						if (!\u0020.tXF8H2TS5Y())
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 3:
						\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num2 = 5;
							continue;
						}
						continue;
					case 4:
						if (!\u0020.TB5dFM9QIv())
						{
							goto IL_5A;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 3;
							continue;
						}
						continue;
					case 5:
						goto IL_5A;
					}
					break;
					IL_5A:
					if (\u0020.jZ28mHocbm())
					{
						goto IL_E3;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num2 = 2;
					}
				}
				goto IL_89;
				IL_3B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_89:
				return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).DyOdyCLR3X(this);
				IL_E3:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 & ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x0600094E RID: 2382 RVA: 0x0004BC38 File Offset: 0x00049E38
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC dH3d8VFM3E(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
				{
					goto IL_7E;
				}
				goto IL_5C;
				IL_10:
				int num;
				switch (num)
				{
				case 1:
					IL_7E:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						int num2 = 3;
						num = num2;
						goto IL_10;
					}
					if (!\u0020.tXF8H2TS5Y())
					{
						throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
					}
					num = 2;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				case 2:
					return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).dH3d8VFM3E(this);
				case 3:
					return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 | ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				}
				IL_5C:
				\u0020 = \u0020.s9Cd9Og84k();
				num = 1;
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x0600094F RID: 2383 RVA: 0x0004BD34 File Offset: 0x00049F34
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Rw9dqatOP5()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(~this.aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000950 RID: 2384 RVA: 0x0004BD50 File Offset: 0x00049F50
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC lBXdd758He(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_71;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
				{
					num = 0;
				}
				IL_10:
				switch (num)
				{
				case 1:
					goto IL_B5;
				case 2:
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				case 3:
					return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 ^ ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				}
				IL_71:
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
				{
					num = 3;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num = 3;
						goto IL_10;
					}
					goto IL_10;
				}
				else if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
				{
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num = 2;
						goto IL_10;
					}
					goto IL_10;
				}
				IL_B5:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YThxgkKN8DfeEIh0DaM((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
			}

			// Token: 0x06000951 RID: 2385 RVA: 0x0004BE58 File Offset: 0x0004A058
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC L5SdoEFytK(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 6;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F7;
					case 1:
						break;
					case 2:
						goto IL_AD;
					case 3:
						goto IL_73;
					case 4:
						goto IL_64;
					case 5:
						break;
					case 6:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 5;
							continue;
						}
						\u0020 = \u0020.s9Cd9Og84k();
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
							continue;
						}
						continue;
					default:
						goto IL_F7;
					}
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						goto IL_73;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_F7:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
					{
						goto IL_AD;
					}
					num2 = 4;
				}
				IL_64:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_73:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 << ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_AD:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ccVYQvKnZ1w3lXGd4fx((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
			}

			// Token: 0x06000952 RID: 2386 RVA: 0x0004BF74 File Offset: 0x0004A174
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC f17d3EnLUZ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
				{
					goto IL_3E;
				}
				goto IL_82;
				IL_10:
				int num;
				switch (num)
				{
				case 1:
					IL_82:
					\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
					num = 2;
					goto IL_10;
				case 2:
					IL_3E:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
						{
							num = 0;
							goto IL_10;
						}
						goto IL_10;
					}
					else
					{
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							goto IL_ED;
						}
						num = 3;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num = 4;
							goto IL_10;
						}
						goto IL_10;
					}
					break;
				case 3:
					goto IL_ED;
				case 4:
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.RekhP3Apm0 >> ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_ED:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Gnh8VWK0c4yCUhQOxfe((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
			}

			// Token: 0x06000953 RID: 2387 RVA: 0x0004C080 File Offset: 0x0004A280
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC V36dQSy6F7(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
							num2 = 4;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_A2;
					case 3:
						goto IL_6A;
					case 5:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							num2 = 3;
							continue;
						}
						goto IL_77;
					}
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						goto IL_A2;
					}
					num2 = 5;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
					{
						num2 = 5;
					}
				}
				IL_6A:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.NdXfXsKJeUBUeIhcCiC((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_77:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_A2:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.aYsh65bDic.Vavhb40As7 >> ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000954 RID: 2388 RVA: 0x0004C1AC File Offset: 0x0004A3AC
			public override string ToString()
			{
				ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ r7lhTZ1BpZ = this.R7lhTZ1BpZ;
				switch (r7lhTZ1BpZ)
				{
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
					goto IL_77;
				default:
				{
					int num = 0;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num = 0;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_66;
						}
						if (r7lhTZ1BpZ != (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11)
						{
							goto IL_77;
						}
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
						{
							num = 1;
						}
					}
					break;
				}
				}
				IL_66:
				return this.aYsh65bDic.RekhP3Apm0.ToString();
				IL_77:
				return this.aYsh65bDic.Vavhb40As7.ToString();
			}

			// Token: 0x06000955 RID: 2389 RVA: 0x0004C264 File Offset: 0x0004A464
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				return this;
			}

			// Token: 0x06000956 RID: 2390 RVA: 0x0004C270 File Offset: 0x0004A470
			internal override bool y9QdwWY3Xc()
			{
				return true;
			}

			// Token: 0x06000957 RID: 2391 RVA: 0x0004C27C File Offset: 0x0004A47C
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_10C;
					case 2:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							num2 = 5;
							continue;
						}
						goto IL_ED;
					case 3:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YO2lZdKm8Slse1umoLC(\u0020))
						{
							num2 = 2;
							continue;
						}
						goto IL_10C;
					case 4:
						goto IL_47;
					case 5:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
						num2 = 8;
						continue;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.dKclRDKYUHyXhfWNSCx(x0cbwj80qtx55Tsu8UC))
						{
							return false;
						}
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(x0cbwj80qtx55Tsu8UC))
						{
							goto IL_47;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 7:
						goto IL_ED;
					case 8:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.cSVb4uKt29wurdM8ynZ(x0cbwj80qtx55Tsu8UC))
						{
							return false;
						}
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
						{
							num2 = 6;
							continue;
						}
						continue;
					}
					break;
				}
				goto IL_173;
				IL_47:
				return this.aYsh65bDic.RekhP3Apm0 == ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)x0cbwj80qtx55Tsu8UC).aYsh65bDic.RekhP3Apm0;
				IL_ED:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pDAhjVKHxdCNNIR2Zqg((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
				IL_10C:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pDAhjVKHxdCNNIR2Zqg((ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT)\u0020, this);
				IL_173:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pDAhjVKHxdCNNIR2Zqg((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)x0cbwj80qtx55Tsu8UC, this);
			}

			// Token: 0x06000958 RID: 2392 RVA: 0x0004C410 File Offset: 0x0004A610
			private static ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB bbFuPLAiQR(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				for (;;)
				{
					int num2 = num;
					ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
							{
								return qmmmuQuSWS2kKwsrFfB;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								return qmmmuQuSWS2kKwsrFfB;
							}
							num2 = 1;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 0;
								continue;
							}
							continue;
						case 3:
							goto IL_8E;
						}
						goto Block_1;
					}
					IL_8E:
					qmmmuQuSWS2kKwsrFfB = (\u0020 as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
					num = 2;
				}
				Block_1:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020) as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB;
			}

			// Token: 0x06000959 RID: 2393 RVA: 0x0004C4C0 File Offset: 0x0004A6C0
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							x0cbwj80qtx55Tsu8UC = \u0020.s9Cd9Og84k();
							num2 = 5;
							continue;
						case 2:
							if (!x0cbwj80qtx55Tsu8UC.tTi8tbHhPd())
							{
								num2 = 4;
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
								{
									num2 = 6;
									continue;
								}
								continue;
							}
							break;
						case 3:
							return false;
						case 4:
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YO2lZdKm8Slse1umoLC(\u0020))
							{
								num2 = 3;
								if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
								{
									num2 = 3;
									continue;
								}
								continue;
							}
							else
							{
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
								{
									goto IL_145;
								}
								num2 = 1;
								if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							break;
						case 5:
							goto IL_B3;
						case 6:
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(x0cbwj80qtx55Tsu8UC))
							{
								goto IL_186;
							}
							num2 = 8;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 2;
								continue;
							}
							continue;
						case 7:
							return false;
						case 8:
							goto IL_164;
						}
						goto Block_1;
					}
					IL_B3:
					if (!x0cbwj80qtx55Tsu8UC.y9QdwWY3Xc())
					{
						return false;
					}
					num = 2;
				}
				Block_1:
				return false;
				IL_145:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.LlIm9uKs7OFI2CBXhbf((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
				IL_164:
				return this.aYsh65bDic.Vavhb40As7 != ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)x0cbwj80qtx55Tsu8UC).aYsh65bDic.Vavhb40As7;
				IL_186:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.LlIm9uKs7OFI2CBXhbf((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)x0cbwj80qtx55Tsu8UC, this);
			}

			// Token: 0x0600095A RID: 2394 RVA: 0x0004C660 File Offset: 0x0004A860
			public override bool SqWdSNFM0N(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
							{
								goto IL_CA;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							goto IL_CA;
						case 3:
							goto IL_126;
						case 5:
							goto IL_3F;
						case 6:
							goto IL_98;
						}
						IL_5E:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
						{
							num2 = 3;
							continue;
						}
						goto IL_EC;
						IL_CA:
						\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
						num2 = 4;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 2;
							continue;
						}
						continue;
						goto IL_5E;
					}
					IL_126:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
					{
						goto IL_98;
					}
					num = 5;
				}
				IL_3F:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_98:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.U2K5AKKgcYe6Oa0k57g((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_EC:
				return this.aYsh65bDic.RekhP3Apm0 >= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
			}

			// Token: 0x0600095B RID: 2395 RVA: 0x0004C79C File Offset: 0x0004A99C
			public override bool DSNdIxSMBQ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_9E;
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_33;
					case 3:
						goto IL_D0;
					default:
						goto IL_9E;
					}
					IL_79:
					if (\u0020.jZ28mHocbm())
					{
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					else
					{
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							goto IL_DD;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					IL_9E:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_79;
				}
				IL_33:
				return this.aYsh65bDic.Vavhb40As7 >= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
				IL_D0:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.kVxK20KXj7BOkihgNCZ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_DD:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x0600095C RID: 2396 RVA: 0x0004C88C File Offset: 0x0004AA8C
			public override bool DoCdicvJaP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_AE;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						break;
					case 3:
						goto IL_8B;
					default:
						goto IL_AE;
					}
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						goto Block_5;
					}
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
					{
						num2 = 3;
						continue;
					}
					goto IL_98;
					IL_AE:
					\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
					{
						num2 = 0;
					}
				}
				IL_8B:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.OZf20KKMsj6is9WaqD5((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_98:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_5:
				return this.aYsh65bDic.RekhP3Apm0 > ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
			}

			// Token: 0x0600095D RID: 2397 RVA: 0x0004C968 File Offset: 0x0004AB68
			public override bool IJkdZ22aVF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
							num2 = 3;
							continue;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_4D;
					case 4:
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							goto IL_5A;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						goto IL_60;
					}
					IL_A3:
					if (!\u0020.jZ28mHocbm())
					{
						num2 = 4;
						continue;
					}
					goto IL_60;
					goto IL_A3;
				}
				IL_4D:
				return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).Fqpd4WZY4A(this);
				IL_5A:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_60:
				return this.aYsh65bDic.Vavhb40As7 > ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
			}

			// Token: 0x0600095E RID: 2398 RVA: 0x0004CA6C File Offset: 0x0004AC6C
			public override bool VdHdUonKxI(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_5A;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
						{
							goto IL_C3;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() != null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_C3;
					case 4:
						goto IL_3B;
					case 5:
						goto IL_E3;
					}
					break;
					IL_5A:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num2 = 5;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					else
					{
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
						{
							num2 = 4;
							continue;
						}
						break;
					}
					IL_C3:
					\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
					goto IL_5A;
				}
				goto IL_D0;
				IL_3B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_D0:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.Sk4FWZKGaksmwtfgd9g((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				IL_E3:
				return this.aYsh65bDic.RekhP3Apm0 <= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
			}

			// Token: 0x0600095F RID: 2399 RVA: 0x0004CB94 File Offset: 0x0004AD94
			public override bool sxQd1txC3H(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						default:
							goto IL_37;
						case 1:
							goto IL_56;
						case 2:
							break;
						case 3:
							\u0020 = ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.YoKhcSKa6HJRr3jah2y(\u0020);
							num2 = 2;
							continue;
						case 4:
							if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
							{
								goto Block_4;
							}
							break;
						}
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
						{
							goto Block_1;
						}
						if (\u0020.tXF8H2TS5Y())
						{
							goto IL_56;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num2 = 0;
						}
					}
					Block_4:
					num = 3;
				}
				IL_37:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_56:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.F6npeMKB3Csu7nHtW9h((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
				Block_1:
				return this.aYsh65bDic.Vavhb40As7 <= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
			}

			// Token: 0x06000960 RID: 2400 RVA: 0x0004CC8C File Offset: 0x0004AE8C
			public override bool WY8dpeljbh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_8C;
				}
				\u0020 = \u0020.s9Cd9Og84k();
				int num = 2;
				IL_10:
				switch (num)
				{
				case 1:
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				case 2:
					IL_8C:
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
					{
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num = 3;
							goto IL_10;
						}
						goto IL_10;
					}
					else if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
					{
						num = 1;
						if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
						{
							num = 0;
							goto IL_10;
						}
						goto IL_10;
					}
					break;
				case 3:
					return this.aYsh65bDic.RekhP3Apm0 < ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
				}
				return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).DoCdicvJaP(this);
			}

			// Token: 0x06000961 RID: 2401 RVA: 0x0004CD80 File Offset: 0x0004AF80
			public override bool Fqpd4WZY4A(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.AYghvwKFrd2t7gW9qOH(\u0020))
				{
					goto IL_4C;
				}
				\u0020 = \u0020.s9Cd9Og84k();
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.pgVJe6abcYRPXMjFEbX())
				{
					num = 0;
				}
				IL_10:
				switch (num)
				{
				case 1:
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				case 2:
					return this.aYsh65bDic.Vavhb40As7 < ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
				case 3:
					goto IL_C4;
				}
				IL_4C:
				if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.zRwyVIKT0prlIoomDZA(\u0020))
				{
					num = 1;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num = 2;
						goto IL_10;
					}
					goto IL_10;
				}
				else if (!ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.aOZRWGKL8VEmmQPI5U5(\u0020))
				{
					num = 1;
					if (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.ACJJ6pazbRLYXTKGJ3a() == null)
					{
						num = 1;
						goto IL_10;
					}
					goto IL_10;
				}
				IL_C4:
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.kgbhhJKDFN880FkKXpw((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, this);
			}

			// Token: 0x06000962 RID: 2402 RVA: 0x0004CE74 File Offset: 0x0004B074
			// Note: this type is marked as 'beforefieldinit'.
			static Y6ZjFnxbSGpN58JxU4F()
			{
				ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.uoJbdfKv58seAYe5kij();
			}

			// Token: 0x06000963 RID: 2403 RVA: 0x0004CE84 File Offset: 0x0004B084
			internal static bool pgVJe6abcYRPXMjFEbX()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.tgXX7MajadIQ7J9XL5y == null;
			}

			// Token: 0x06000964 RID: 2404 RVA: 0x0004CE98 File Offset: 0x0004B098
			internal static ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F ACJJ6pazbRLYXTKGJ3a()
			{
				return ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F.tgXX7MajadIQ7J9XL5y;
			}

			// Token: 0x06000965 RID: 2405 RVA: 0x0004CEA8 File Offset: 0x0004B0A8
			internal static void eFULqCKWhndmD7291gy(object A_0, object A_1)
			{
				A_0.AxwqVJ6XV5(A_1);
			}

			// Token: 0x06000966 RID: 2406 RVA: 0x0004CEC0 File Offset: 0x0004B0C0
			internal static void iTiaCQKPZ7eMyMjU2yq()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000967 RID: 2407 RVA: 0x0004CED0 File Offset: 0x0004B0D0
			internal static void Gx91n5KEQB4F2tpbR0X()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000968 RID: 2408 RVA: 0x0004CEE0 File Offset: 0x0004B0E0
			internal static bool WUHG7xKcVZJLx4iBZaA(object A_0)
			{
				return A_0.WuHqq9Wdbv();
			}

			// Token: 0x06000969 RID: 2409 RVA: 0x0004CEF4 File Offset: 0x0004B0F4
			internal static object VRciYXK5fqd1GM54nwc(object A_0)
			{
				return A_0.eoUqScGyAS();
			}

			// Token: 0x0600096A RID: 2410 RVA: 0x0004CF08 File Offset: 0x0004B108
			internal static object CM2AguKxNPTdmUCu4mC(object A_0)
			{
				return A_0.U0ZqI72BOj();
			}

			// Token: 0x0600096B RID: 2411 RVA: 0x0004CF1C File Offset: 0x0004B11C
			internal static object sPxkgpKukuofmkJnXfZ(object A_0)
			{
				return A_0.kZFq9GpslU();
			}

			// Token: 0x0600096C RID: 2412 RVA: 0x0004CF30 File Offset: 0x0004B130
			internal static object LRKtmkKVkJEgRL7hMhk(object A_0)
			{
				return A_0.Br0qAy7jU5();
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x0004CF44 File Offset: 0x0004B144
			internal static object iLLP8aKyB0grqEgo6m7(object A_0)
			{
				return A_0.QtGqh2NDQ8();
			}

			// Token: 0x0600096E RID: 2414 RVA: 0x0004CF58 File Offset: 0x0004B158
			internal static object lpk9ZbK8G34vQyMQvNR(object A_0)
			{
				return A_0.AxLq8nl88V();
			}

			// Token: 0x0600096F RID: 2415 RVA: 0x0004CF6C File Offset: 0x0004B16C
			internal static bool lqA7P7KqhIjklSXtpP4(Type A_0, Type A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000970 RID: 2416 RVA: 0x0004CF84 File Offset: 0x0004B184
			internal static RuntimeTypeHandle WNTp2bKd5JSutqHCwZn(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000971 RID: 2417 RVA: 0x0004CF98 File Offset: 0x0004B198
			internal static bool Qo7FvCKoCLBUZPoxVC6(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000972 RID: 2418 RVA: 0x0004CFB0 File Offset: 0x0004B1B0
			internal static Type llGGCjK3H7HmGDO1NuC(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000973 RID: 2419 RVA: 0x0004CFC4 File Offset: 0x0004B1C4
			internal static Type OjQyNfKQ56qBof3FCaJ(Type A_0)
			{
				return Enum.GetUnderlyingType(A_0);
			}

			// Token: 0x06000974 RID: 2420 RVA: 0x0004CFD8 File Offset: 0x0004B1D8
			internal static object oW6QZmKCASFrLMArGny(Type A_0, int A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000975 RID: 2421 RVA: 0x0004CFF0 File Offset: 0x0004B1F0
			internal static object KGAN2WK9SaKpqj5dLYn(Type A_0, uint A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x0004D008 File Offset: 0x0004B208
			internal static object zsBC25KwDmGysJ815uD(Type A_0, short A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x0004D020 File Offset: 0x0004B220
			internal static object AX0sR8KAfyMTEhWoK86(Type A_0, ushort A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000978 RID: 2424 RVA: 0x0004D038 File Offset: 0x0004B238
			internal static object nJDcMYKh8pifelkR4un(Type A_0, sbyte A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000979 RID: 2425 RVA: 0x0004D050 File Offset: 0x0004B250
			internal static bool ka05h4KSSIyPyoHdrmh(object A_0)
			{
				return A_0.icyqdm73mi();
			}

			// Token: 0x0600097A RID: 2426 RVA: 0x0004D064 File Offset: 0x0004B264
			internal static object WA4HV2KIL7rm93enGeN(object A_0)
			{
				return A_0.FOJqpHkit6();
			}

			// Token: 0x0600097B RID: 2427 RVA: 0x0004D078 File Offset: 0x0004B278
			internal static int Hwt6H7Kip8AQ38HpdB8()
			{
				return IntPtr.Size;
			}

			// Token: 0x0600097C RID: 2428 RVA: 0x0004D088 File Offset: 0x0004B288
			internal static object SnDWf1KZhuoWqOBx9cg(object A_0)
			{
				return A_0.SZBqTRsZeT();
			}

			// Token: 0x0600097D RID: 2429 RVA: 0x0004D09C File Offset: 0x0004B29C
			internal static object nF4HCDKUZktGl2c29pT(object A_0)
			{
				return A_0.oAjqFTEeFY();
			}

			// Token: 0x0600097E RID: 2430 RVA: 0x0004D0B0 File Offset: 0x0004B2B0
			internal static object xO1f5TK1WZjC84e4E0C(object A_0)
			{
				return A_0.rMZqkTKtdW();
			}

			// Token: 0x0600097F RID: 2431 RVA: 0x0004D0C4 File Offset: 0x0004B2C4
			internal static object j0E66FKp9TaKN2RMu3i(object A_0)
			{
				return A_0.LYYqJD7UOL();
			}

			// Token: 0x06000980 RID: 2432 RVA: 0x0004D0D8 File Offset: 0x0004B2D8
			internal static object NXwv9mK4FMZeMc0VjxA(object A_0)
			{
				return A_0.RywqnVZSZT();
			}

			// Token: 0x06000981 RID: 2433 RVA: 0x0004D0EC File Offset: 0x0004B2EC
			internal static object bFVugRKOAwLTsdXHhpe(object A_0)
			{
				return A_0.c1Bqr7stpA();
			}

			// Token: 0x06000982 RID: 2434 RVA: 0x0004D100 File Offset: 0x0004B300
			internal static object Vq6TRqKflPMv89ANqlR(object A_0)
			{
				return A_0.QmjqeL3I7g();
			}

			// Token: 0x06000983 RID: 2435 RVA: 0x0004D114 File Offset: 0x0004B314
			internal static bool AYghvwKFrd2t7gW9qOH(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x0004D128 File Offset: 0x0004B328
			internal static bool zRwyVIKT0prlIoomDZA(object A_0)
			{
				return A_0.jZ28mHocbm();
			}

			// Token: 0x06000985 RID: 2437 RVA: 0x0004D13C File Offset: 0x0004B33C
			internal static object rJofs6KR2IGm2Ank0c4(object A_0, object A_1)
			{
				return A_0.Add(A_1);
			}

			// Token: 0x06000986 RID: 2438 RVA: 0x0004D154 File Offset: 0x0004B354
			internal static bool aOZRWGKL8VEmmQPI5U5(object A_0)
			{
				return A_0.tXF8H2TS5Y();
			}

			// Token: 0x06000987 RID: 2439 RVA: 0x0004D168 File Offset: 0x0004B368
			internal static object YXVrOvKlHepFNo6nTK0(object A_0, object A_1)
			{
				return A_0.LfyqvMrNHx(A_1);
			}

			// Token: 0x06000988 RID: 2440 RVA: 0x0004D180 File Offset: 0x0004B380
			internal static object YoKhcSKa6HJRr3jah2y(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000989 RID: 2441 RVA: 0x0004D194 File Offset: 0x0004B394
			internal static object nORtGiKK72TLE8012Oj(object A_0, object A_1)
			{
				return A_0.KrBqjlnYTv(A_1);
			}

			// Token: 0x0600098A RID: 2442 RVA: 0x0004D1AC File Offset: 0x0004B3AC
			internal static object QiqlVqKeG7cwC8n6bA8(object A_0, object A_1)
			{
				return A_0.TEDudmFiUo(A_1);
			}

			// Token: 0x0600098B RID: 2443 RVA: 0x0004D1C4 File Offset: 0x0004B3C4
			internal static object uuhyiVKkLbxni9ZLK5D(object A_0, object A_1)
			{
				return A_0.cT0dPKbnSa(A_1);
			}

			// Token: 0x0600098C RID: 2444 RVA: 0x0004D1DC File Offset: 0x0004B3DC
			internal static object lmDyZTKrgsO5bDnFuP4(object A_0, object A_1)
			{
				return A_0.jaYdc2eCJF(A_1);
			}

			// Token: 0x0600098D RID: 2445 RVA: 0x0004D1F4 File Offset: 0x0004B3F4
			internal static object s7BWNDK7mGkwFgkqtNV(object A_0, object A_1)
			{
				return A_0.s13uQY31x9(A_1);
			}

			// Token: 0x0600098E RID: 2446 RVA: 0x0004D20C File Offset: 0x0004B40C
			internal static object smrTlfK2D2uZF6b6vDE(object A_0, object A_1)
			{
				return A_0.bfduCGLdOq(A_1);
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x0004D224 File Offset: 0x0004B424
			internal static object oDfAWaK61x6sslPYMN1(object A_0, object A_1)
			{
				return A_0.nU0u9SaqhH(A_1);
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x0004D23C File Offset: 0x0004B43C
			internal static object YThxgkKN8DfeEIh0DaM(object A_0, object A_1)
			{
				return A_0.lBXdd758He(A_1);
			}

			// Token: 0x06000991 RID: 2449 RVA: 0x0004D254 File Offset: 0x0004B454
			internal static object ccVYQvKnZ1w3lXGd4fx(object A_0, object A_1)
			{
				return A_0.chhuhxJxVf(A_1);
			}

			// Token: 0x06000992 RID: 2450 RVA: 0x0004D26C File Offset: 0x0004B46C
			internal static object Gnh8VWK0c4yCUhQOxfe(object A_0, object A_1)
			{
				return A_0.h37uAB0IKX(A_1);
			}

			// Token: 0x06000993 RID: 2451 RVA: 0x0004D284 File Offset: 0x0004B484
			internal static object NdXfXsKJeUBUeIhcCiC(object A_0, object A_1)
			{
				return A_0.wY1uwVtTmF(A_1);
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x0004D29C File Offset: 0x0004B49C
			internal static bool YO2lZdKm8Slse1umoLC(object A_0)
			{
				return A_0.MEy8J5BANA();
			}

			// Token: 0x06000995 RID: 2453 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
			internal static bool pDAhjVKHxdCNNIR2Zqg(object A_0, object A_1)
			{
				return A_0.ovDdASrPUT(A_1);
			}

			// Token: 0x06000996 RID: 2454 RVA: 0x0004D2C8 File Offset: 0x0004B4C8
			internal static bool cSVb4uKt29wurdM8ynZ(object A_0)
			{
				return A_0.y9QdwWY3Xc();
			}

			// Token: 0x06000997 RID: 2455 RVA: 0x0004D2DC File Offset: 0x0004B4DC
			internal static bool dKclRDKYUHyXhfWNSCx(object A_0)
			{
				return A_0.tTi8tbHhPd();
			}

			// Token: 0x06000998 RID: 2456 RVA: 0x0004D2F0 File Offset: 0x0004B4F0
			internal static bool LlIm9uKs7OFI2CBXhbf(object A_0, object A_1)
			{
				return A_0.g5sdhSCwCu(A_1);
			}

			// Token: 0x06000999 RID: 2457 RVA: 0x0004D308 File Offset: 0x0004B508
			internal static bool U2K5AKKgcYe6Oa0k57g(object A_0, object A_1)
			{
				return A_0.VdHdUonKxI(A_1);
			}

			// Token: 0x0600099A RID: 2458 RVA: 0x0004D320 File Offset: 0x0004B520
			internal static bool kVxK20KXj7BOkihgNCZ(object A_0, object A_1)
			{
				return A_0.sxQd1txC3H(A_1);
			}

			// Token: 0x0600099B RID: 2459 RVA: 0x0004D338 File Offset: 0x0004B538
			internal static bool OZf20KKMsj6is9WaqD5(object A_0, object A_1)
			{
				return A_0.WY8dpeljbh(A_1);
			}

			// Token: 0x0600099C RID: 2460 RVA: 0x0004D350 File Offset: 0x0004B550
			internal static bool Sk4FWZKGaksmwtfgd9g(object A_0, object A_1)
			{
				return A_0.SqWdSNFM0N(A_1);
			}

			// Token: 0x0600099D RID: 2461 RVA: 0x0004D368 File Offset: 0x0004B568
			internal static bool F6npeMKB3Csu7nHtW9h(object A_0, object A_1)
			{
				return A_0.DSNdIxSMBQ(A_1);
			}

			// Token: 0x0600099E RID: 2462 RVA: 0x0004D380 File Offset: 0x0004B580
			internal static bool kgbhhJKDFN880FkKXpw(object A_0, object A_1)
			{
				return A_0.IJkdZ22aVF(A_1);
			}

			// Token: 0x0600099F RID: 2463 RVA: 0x0004D398 File Offset: 0x0004B598
			internal static void uoJbdfKv58seAYe5kij()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003B1 RID: 945
			public ykD11HxHfZBYH7OcFOG.E2FUStxjTJDBkKYmvU1 aYsh65bDic;

			// Token: 0x040003B2 RID: 946
			public ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ R7lhTZ1BpZ;

			// Token: 0x040003B3 RID: 947
			internal static ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F tgXX7MajadIQ7J9XL5y;
		}

		// Token: 0x0200006F RID: 111
		[StructLayout(LayoutKind.Explicit)]
		private struct e0GjEEuEf6ToqLF4ouH
		{
			// Token: 0x040003B4 RID: 948
			[FieldOffset(0)]
			public byte aFJhev85Ps;

			// Token: 0x040003B5 RID: 949
			[FieldOffset(0)]
			public sbyte Cy7hXktcKo;

			// Token: 0x040003B6 RID: 950
			[FieldOffset(0)]
			public ushort dB3hcB11BZ;

			// Token: 0x040003B7 RID: 951
			[FieldOffset(0)]
			public short DQHhKZDebq;

			// Token: 0x040003B8 RID: 952
			[FieldOffset(0)]
			public uint vsshsTAbx4;

			// Token: 0x040003B9 RID: 953
			[FieldOffset(0)]
			public int HDmhqUiRl0;

			// Token: 0x040003BA RID: 954
			[FieldOffset(0)]
			public ulong SL4hxlZ2Vr;

			// Token: 0x040003BB RID: 955
			[FieldOffset(0)]
			public long Y3Why5AObT;
		}

		// Token: 0x02000070 RID: 112
		private class kQJWGaucMXeMCLLKdvN : ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB
		{
			// Token: 0x060009A0 RID: 2464 RVA: 0x0004D3A8 File Offset: 0x0004B5A8
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.OluhFK2lXQ = ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ;
				this.ioThWif4AI = ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).ioThWif4AI;
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}

			// Token: 0x060009A1 RID: 2465 RVA: 0x0004D414 File Offset: 0x0004B614
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.AxwqVJ6XV5(\u0020);
			}

			// Token: 0x060009A2 RID: 2466 RVA: 0x0004D42C File Offset: 0x0004B62C
			public kQJWGaucMXeMCLLKdvN(long \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 0;
				if (!false)
				{
					num = 2;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.ioThWif4AI = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7;
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)2;
						num = 3;
						continue;
					case 3:
						this.OluhFK2lXQ.Y3Why5AObT = \u0020;
						num = 1;
						if (!false)
						{
							num = 1;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x060009A3 RID: 2467 RVA: 0x0004D4E4 File Offset: 0x0004B6E4
			public kQJWGaucMXeMCLLKdvN(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Uq13ksec6yShYphgScE();
				base..ctor();
				int num = 3;
				if (!true)
				{
					num = 3;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.ioThWif4AI = \u0020.ioThWif4AI;
						num = 1;
						if (!false)
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
						this.XyUUA5Idue = \u0020.XyUUA5Idue;
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					this.OluhFK2lXQ.Y3Why5AObT = \u0020.OluhFK2lXQ.Y3Why5AObT;
					num = 2;
				}
			}

			// Token: 0x060009A4 RID: 2468 RVA: 0x0004D5B0 File Offset: 0x0004B7B0
			public override ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB AxLq8nl88V()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this);
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x0004D5C0 File Offset: 0x0004B7C0
			public kQJWGaucMXeMCLLKdvN(long \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ePWqWqe53Cql0DTfPn2();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.OluhFK2lXQ.Y3Why5AObT = \u0020;
						num = 2;
						if (true)
						{
							num = 2;
							continue;
						}
						continue;
					case 2:
						this.ioThWif4AI = \u0020;
						num = 0;
						if (false)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)2;
						num = 0;
						if (true)
						{
							num = 1;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x0004D678 File Offset: 0x0004B878
			public kQJWGaucMXeMCLLKdvN(ulong \u0020)
			{
				ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ePWqWqe53Cql0DTfPn2();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 0;
				if (!false)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)2;
						num = 0;
						if (!false)
						{
							num = 1;
						}
						break;
					case 1:
						this.OluhFK2lXQ.SL4hxlZ2Vr = \u0020;
						num = 2;
						break;
					case 2:
						this.ioThWif4AI = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8;
						num = 3;
						break;
					case 3:
						return;
					}
				}
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x0004D724 File Offset: 0x0004B924
			public kQJWGaucMXeMCLLKdvN(ulong \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ePWqWqe53Cql0DTfPn2();
				ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Uq13ksec6yShYphgScE();
				base..ctor();
				int num = 3;
				if (true)
				{
					num = 3;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.ioThWif4AI = \u0020;
						num = 0;
						if (!false)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						this.OluhFK2lXQ.SL4hxlZ2Vr = \u0020;
						num = 1;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)2;
						num = 2;
						continue;
					}
					break;
				}
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x0004D7DC File Offset: 0x0004B9DC
			public override bool WuHqq9Wdbv()
			{
				if (this.ioThWif4AI == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7)
				{
					return this.OluhFK2lXQ.Y3Why5AObT == 0L;
				}
				return this.OluhFK2lXQ.SL4hxlZ2Vr == 0UL;
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x0004D818 File Offset: 0x0004BA18
			public override bool icyqdm73mi()
			{
				return !ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.MZoV6BexRIrlRyWSScY(this);
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x0004D82C File Offset: 0x0004BA2C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Q1tqoFEFyp(ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						switch (\u0020)
						{
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
							goto IL_4B;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
							goto IL_52;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
							goto IL_59;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
							goto IL_60;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
							goto IL_67;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
							goto IL_6E;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
							goto IL_2F;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8:
							goto IL_36;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)14:
							break;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11:
							goto IL_3D;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15:
							goto IL_44;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)16:
							goto IL_75;
						default:
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_2F;
					}
					break;
				}
				goto IL_84;
				IL_2F:
				return this.JWZqiAqFR8();
				IL_36:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.SOCCeMeugBbcn7DEuhc(this);
				IL_3D:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.PiY5FAeV3nnwoj0xwqW(this);
				IL_44:
				return this.e45uxGKWxt();
				IL_4B:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.fB6FHJeyr6F6N4WjqCP(this);
				IL_52:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Sa2qVKe8I1OHZYCYspR(this);
				IL_59:
				return this.Br0qAy7jU5();
				IL_60:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.AflrvieqWYo7ccDBOCA(this);
				IL_67:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.RSpoGBedPLd8Ba8r6SB(this);
				IL_6E:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.NeQtNIeofnDOgGGExp4(this);
				IL_75:
				return this.AxLq8nl88V();
				IL_7C:
				throw new Exception(((ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)4).ToString());
				IL_84:
				goto IL_7C;
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x0004D950 File Offset: 0x0004BB50
			internal override object y9jq31urLD(Type \u0020)
			{
				int num = 14;
				int num2 = num;
				for (;;)
				{
					ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ deoHSYuiJEGISeKGmfJ;
					switch (num2)
					{
					case 0:
						goto IL_223;
					case 1:
						goto IL_52B;
					case 2:
						goto IL_87;
					case 3:
						if (\u0020 == ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777253)))
						{
							num2 = 1;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						else if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777252))))
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 7;
								continue;
							}
							continue;
						}
						else
						{
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777328))))
							{
								num2 = 23;
								continue;
							}
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777614))))
							{
								goto IL_1EE;
							}
							num2 = 10;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
							{
								num2 = 11;
								continue;
							}
							continue;
						}
						break;
					case 4:
						goto IL_232;
					case 5:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777219))))
						{
							num2 = 15;
							continue;
						}
						goto IL_87;
					case 6:
						switch (deoHSYuiJEGISeKGmfJ)
						{
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
							goto IL_2EA;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
							goto IL_31D;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
							goto IL_2FB;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
							goto IL_32E;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
							goto IL_30C;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
							goto IL_33F;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
							goto IL_2BC;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8:
							goto IL_2CD;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13:
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)14:
							goto IL_362;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11:
							goto IL_2DE;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15:
							goto IL_350;
						default:
							num2 = 12;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 18;
								continue;
							}
							continue;
						}
						break;
					case 7:
						goto IL_484;
					case 8:
						break;
					case 9:
						goto IL_3D5;
					case 10:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777257))))
						{
							goto IL_3D5;
						}
						if (\u0020 == ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777323)))
						{
							goto IL_45D;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 11:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777220))))
						{
							num2 = 24;
							continue;
						}
						if (!(\u0020 == ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777561))))
						{
							num2 = 10;
							continue;
						}
						goto IL_397;
					case 12:
						goto IL_397;
					case 13:
						if (!\u0020.IsByRef)
						{
							num2 = 8;
							continue;
						}
						\u0020 = \u0020.GetElementType();
						num2 = 20;
						continue;
					case 14:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.t4cGQ3e3V2qV2nnUDZy(\u0020, null))
						{
							num2 = 11;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
							{
								num2 = 13;
								continue;
							}
							continue;
						}
						break;
					case 15:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777256))))
						{
							num2 = 3;
							continue;
						}
						goto IL_232;
					case 16:
						goto IL_41A;
					case 17:
						goto IL_45D;
					case 18:
						goto IL_E2;
					case 19:
						goto IL_1EE;
					case 20:
						break;
					case 21:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236))))
						{
							num2 = 5;
							continue;
						}
						goto IL_1AE;
					case 22:
						goto IL_2BC;
					case 23:
						goto IL_127;
					case 24:
						goto IL_16C;
					default:
						goto IL_223;
					}
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(\u0020, null))
					{
						num2 = 21;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					IL_1AE:
					deoHSYuiJEGISeKGmfJ = this.ioThWif4AI;
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
					{
						num2 = 6;
						continue;
					}
					continue;
					IL_223:
					if (\u0020.IsEnum)
					{
						goto IL_3C7;
					}
					num2 = 16;
				}
				IL_87:
				return this.OluhFK2lXQ.HDmhqUiRl0;
				IL_E2:
				goto IL_362;
				IL_127:
				return this.OluhFK2lXQ.aFJhev85Ps;
				IL_16C:
				return !ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.MZoV6BexRIrlRyWSScY(this);
				IL_1EE:
				return this.OluhFK2lXQ.Cy7hXktcKo;
				IL_232:
				return this.OluhFK2lXQ.vsshsTAbx4;
				IL_2BC:
				return this.OluhFK2lXQ.Y3Why5AObT;
				IL_2CD:
				return this.OluhFK2lXQ.SL4hxlZ2Vr;
				IL_2DE:
				return this.icyqdm73mi();
				IL_2EA:
				return this.OluhFK2lXQ.Cy7hXktcKo;
				IL_2FB:
				return this.OluhFK2lXQ.DQHhKZDebq;
				IL_30C:
				return this.OluhFK2lXQ.HDmhqUiRl0;
				IL_31D:
				return this.OluhFK2lXQ.aFJhev85Ps;
				IL_32E:
				return this.OluhFK2lXQ.dB3hcB11BZ;
				IL_33F:
				return this.OluhFK2lXQ.vsshsTAbx4;
				IL_350:
				return (char)this.OluhFK2lXQ.HDmhqUiRl0;
				IL_362:
				return this.OluhFK2lXQ.Y3Why5AObT;
				IL_397:
				return this.OluhFK2lXQ.Y3Why5AObT;
				IL_3C7:
				return this.TnNu5dBuH7(\u0020);
				IL_3D5:
				return this.OluhFK2lXQ.SL4hxlZ2Vr;
				IL_41A:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_45D:
				return (char)this.OluhFK2lXQ.Y3Why5AObT;
				IL_484:
				return this.OluhFK2lXQ.dB3hcB11BZ;
				IL_52B:
				return this.OluhFK2lXQ.DQHhKZDebq;
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x0004DECC File Offset: 0x0004C0CC
			internal object TnNu5dBuH7(Type \u0020)
			{
				int num = 8;
				int num2 = num;
				for (;;)
				{
					Type type;
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(type, ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777323))))
						{
							num2 = 14;
							continue;
						}
						goto IL_25E;
					case 2:
						goto IL_136;
					case 3:
						if (type == Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777257)))
						{
							goto IL_30C;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(type, ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777328))))
						{
							num2 = 5;
							continue;
						}
						if (type == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777614)))
						{
							num2 = 9;
							continue;
						}
						if (type == ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777561)))
						{
							goto IL_BA;
						}
						num2 = 3;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						goto IL_2C6;
					case 6:
						if (type == ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777252)))
						{
							goto IL_270;
						}
						num2 = 3;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 7:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(type, ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ct3lTZeCIjbmU5Z5FvD(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777219))))
						{
							goto IL_136;
						}
						num2 = 10;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 8:
						type = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.yb4ch7ewW8KHuI2jwTH(\u0020);
						num2 = 7;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 9:
						goto IL_69;
					case 10:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Y9VPp1e9whZXbehjBR9(16777256))))
						{
							goto IL_19F;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 11:
						goto IL_19F;
					case 12:
						goto IL_30C;
					case 13:
						goto IL_BA;
					case 14:
						goto IL_24B;
					}
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nTEKQmeQUemnLmZynDv(type, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777253))))
					{
						goto IL_204;
					}
					num2 = 6;
				}
				IL_69:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.wH5QFDeZeRTqJwhKtFW(\u0020, this.OluhFK2lXQ.Cy7hXktcKo);
				IL_BA:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.P6IL1TeUh1btsHtcul0(\u0020, this.OluhFK2lXQ.Y3Why5AObT);
				IL_136:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.egfS0xeADoGMDj3gqw5(\u0020, this.OluhFK2lXQ.HDmhqUiRl0);
				IL_19F:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.bqrhHjehtXo5TZu3x8c(\u0020, this.OluhFK2lXQ.vsshsTAbx4);
				IL_204:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Cv1OLGeSsO7PaBZE3ih(\u0020, this.OluhFK2lXQ.DQHhKZDebq);
				IL_24B:
				return Enum.ToObject(\u0020, (ushort)this.OluhFK2lXQ.HDmhqUiRl0);
				IL_25E:
				return Enum.ToObject(\u0020, this.OluhFK2lXQ.Y3Why5AObT);
				IL_270:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.QmRVmNeIaKQdWu4WIBA(\u0020, this.OluhFK2lXQ.dB3hcB11BZ);
				IL_2C6:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.rMGncMeiKRBihsuAlnp(\u0020, this.OluhFK2lXQ.aFJhev85Ps);
				IL_30C:
				return Enum.ToObject(\u0020, this.OluhFK2lXQ.SL4hxlZ2Vr);
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x0004E21C File Offset: 0x0004C41C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NtxqQI1Zcd()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (this.WuHqq9Wdbv())
						{
							goto IL_5B;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				int u = 1;
				goto IL_5C;
				IL_5B:
				u = 0;
				IL_5C:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(u);
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x0004E28C File Offset: 0x0004C48C
			internal override bool lPSqCCLN7S()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.MrKrf3e10R4AFRskwrL(this);
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x0004E29C File Offset: 0x0004C49C
			public ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F e45uxGKWxt()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)this.OluhFK2lXQ.Cy7hXktcKo, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x0004E2B8 File Offset: 0x0004C4B8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F kZFq9GpslU()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)this.OluhFK2lXQ.Cy7hXktcKo, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x0004E2D4 File Offset: 0x0004C4D4
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F PQEqwQ01dQ()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)this.OluhFK2lXQ.aFJhev85Ps, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x0004E2F0 File Offset: 0x0004C4F0
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Br0qAy7jU5()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)this.OluhFK2lXQ.DQHhKZDebq, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x0004E30C File Offset: 0x0004C50C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QtGqh2NDQ8()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)this.OluhFK2lXQ.dB3hcB11BZ, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x0004E328 File Offset: 0x0004C528
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eoUqScGyAS()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.OluhFK2lXQ.HDmhqUiRl0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x060009B5 RID: 2485 RVA: 0x0004E344 File Offset: 0x0004C544
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F U0ZqI72BOj()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(this.OluhFK2lXQ.vsshsTAbx4, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x0004E360 File Offset: 0x0004C560
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN JWZqiAqFR8()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x0004E37C File Offset: 0x0004C57C
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN upCqZP4jJd()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.SL4hxlZ2Vr, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x0004E398 File Offset: 0x0004C598
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lk5qURpdjk()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.fB6FHJeyr6F6N4WjqCP(this);
			}

			// Token: 0x060009B9 RID: 2489 RVA: 0x0004E3A8 File Offset: 0x0004C5A8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F HK7q1PliPm()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.xPtQhDepoZBnVhAa35B(this);
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x0004E3B8 File Offset: 0x0004C5B8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F FOJqpHkit6()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.RSpoGBedPLd8Ba8r6SB(this);
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN FmZq4JYpT6()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Igehn4e4gMmn9h6jmDZ(this);
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F hYvqOWPpOC()
			{
				return this.PQEqwQ01dQ();
			}

			// Token: 0x060009BD RID: 2493 RVA: 0x0004E3E8 File Offset: 0x0004C5E8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F o1ZqfYXchM()
			{
				return this.QtGqh2NDQ8();
			}

			// Token: 0x060009BE RID: 2494 RVA: 0x0004E3F8 File Offset: 0x0004C5F8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F oAjqFTEeFY()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.NeQtNIeofnDOgGGExp4(this);
			}

			// Token: 0x060009BF RID: 2495 RVA: 0x0004E408 File Offset: 0x0004C608
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN SZBqTRsZeT()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.SOCCeMeugBbcn7DEuhc(this);
			}

			// Token: 0x060009C0 RID: 2496 RVA: 0x0004E418 File Offset: 0x0004C618
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F ziwqR9N2wv()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((sbyte)this.OluhFK2lXQ.Y3Why5AObT)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x060009C1 RID: 2497 RVA: 0x0004E434 File Offset: 0x0004C634
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F j5lqLol41P()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((sbyte)this.OluhFK2lXQ.SL4hxlZ2Vr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x060009C2 RID: 2498 RVA: 0x0004E450 File Offset: 0x0004C650
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NN3qlXny0A()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((short)this.OluhFK2lXQ.Y3Why5AObT)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x060009C3 RID: 2499 RVA: 0x0004E46C File Offset: 0x0004C66C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F cMXqaCAZHq()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((short)this.OluhFK2lXQ.SL4hxlZ2Vr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x060009C4 RID: 2500 RVA: 0x0004E488 File Offset: 0x0004C688
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Vy2qKYUMDe()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((int)this.OluhFK2lXQ.Y3Why5AObT), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x060009C5 RID: 2501 RVA: 0x0004E4A4 File Offset: 0x0004C6A4
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QmjqeL3I7g()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((int)this.OluhFK2lXQ.SL4hxlZ2Vr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x060009C6 RID: 2502 RVA: 0x0004E4C0 File Offset: 0x0004C6C0
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN rMZqkTKtdW()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x060009C7 RID: 2503 RVA: 0x0004E4DC File Offset: 0x0004C6DC
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN c1Bqr7stpA()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked((long)this.OluhFK2lXQ.SL4hxlZ2Vr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x060009C8 RID: 2504 RVA: 0x0004E4F8 File Offset: 0x0004C6F8
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lZtq7DP5OI()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((byte)this.OluhFK2lXQ.Y3Why5AObT)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x060009C9 RID: 2505 RVA: 0x0004E514 File Offset: 0x0004C714
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eFOq2JXLOE()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((byte)this.OluhFK2lXQ.SL4hxlZ2Vr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x060009CA RID: 2506 RVA: 0x0004E530 File Offset: 0x0004C730
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F CVaq6fDwxc()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((ushort)this.OluhFK2lXQ.Y3Why5AObT)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x060009CB RID: 2507 RVA: 0x0004E54C File Offset: 0x0004C74C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F rvkqNso51v()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((ushort)this.OluhFK2lXQ.SL4hxlZ2Vr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x060009CC RID: 2508 RVA: 0x0004E568 File Offset: 0x0004C768
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F RywqnVZSZT()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((uint)this.OluhFK2lXQ.Y3Why5AObT), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x060009CD RID: 2509 RVA: 0x0004E584 File Offset: 0x0004C784
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Jefq04Qqj5()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((uint)this.OluhFK2lXQ.SL4hxlZ2Vr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x060009CE RID: 2510 RVA: 0x0004E5A0 File Offset: 0x0004C7A0
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN LYYqJD7UOL()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked((ulong)this.OluhFK2lXQ.Y3Why5AObT), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x060009CF RID: 2511 RVA: 0x0004E5BC File Offset: 0x0004C7BC
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN Msjqm6OQGU()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.SL4hxlZ2Vr, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x060009D0 RID: 2512 RVA: 0x0004E5D8 File Offset: 0x0004C7D8
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs qJhqHVUG8k()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((float)this.OluhFK2lXQ.Y3Why5AObT);
			}

			// Token: 0x060009D1 RID: 2513 RVA: 0x0004E5F4 File Offset: 0x0004C7F4
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs c1GqttOeWQ()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((double)this.OluhFK2lXQ.Y3Why5AObT);
			}

			// Token: 0x060009D2 RID: 2514 RVA: 0x0004E610 File Offset: 0x0004C810
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs HF1qYGZ8gN()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.OluhFK2lXQ.SL4hxlZ2Vr);
			}

			// Token: 0x060009D3 RID: 2515 RVA: 0x0004E62C File Offset: 0x0004C82C
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb yRRqsHbNK7()
			{
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ejXhigeOwJThd29Z6Ap() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.FmZq4JYpT6().OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.t3OOHhefJtW6COpXIOW(this).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x060009D4 RID: 2516 RVA: 0x0004E684 File Offset: 0x0004C884
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb D1PqgOGTyj()
			{
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ejXhigeOwJThd29Z6Ap() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Cw2AEkeFIdmgurmYfsj(this).OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)this.oAjqFTEeFY().aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x0004E6D4 File Offset: 0x0004C8D4
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb XWcqXDk1Pt()
			{
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ejXhigeOwJThd29Z6Ap() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.rMZqkTKtdW().OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.rRawPceTVJF3i0LZQnO(this).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x060009D6 RID: 2518 RVA: 0x0004E72C File Offset: 0x0004C92C
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb JjkqMxqLaY()
			{
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ejXhigeOwJThd29Z6Ap() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.LYYqJD7UOL().OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)this.RywqnVZSZT().aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x060009D7 RID: 2519 RVA: 0x0004E77C File Offset: 0x0004C97C
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb APcqGbirjs()
			{
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ejXhigeOwJThd29Z6Ap() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.VDBAc4eRww5UxsOe5GI(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)this.QmjqeL3I7g().aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x060009D8 RID: 2520 RVA: 0x0004E7CC File Offset: 0x0004C9CC
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb CY1qBxKBHt()
			{
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ejXhigeOwJThd29Z6Ap() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(checked((uint)this.OluhFK2lXQ.SL4hxlZ2Vr)));
			}

			// Token: 0x060009D9 RID: 2521 RVA: 0x0004E818 File Offset: 0x0004CA18
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC CpmqDtDe45()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(-this.OluhFK2lXQ.Y3Why5AObT);
			}

			// Token: 0x060009DA RID: 2522 RVA: 0x0004E834 File Offset: 0x0004CA34
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Add(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
						goto IL_7C;
					case 2:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							goto IL_7C;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
					IL_7C:
					if (!\u0020.tTi8tbHhPd())
					{
						goto IL_76;
					}
					num2 = 0;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 0;
					}
				}
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT + ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_76:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009DB RID: 2523 RVA: 0x0004E8F0 File Offset: 0x0004CAF0
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC LfyqvMrNHx(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
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
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked(this.OluhFK2lXQ.Y3Why5AObT + ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT));
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009DC RID: 2524 RVA: 0x0004E9AC File Offset: 0x0004CBAC
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC KrBqjlnYTv(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_37;
					case 1:
						break;
					case 2:
						goto IL_6C;
					case 3:
						goto IL_94;
					case 4:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 3;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					}
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num2 = 0;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 0;
					}
				}
				IL_37:
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_6C:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked(this.OluhFK2lXQ.SL4hxlZ2Vr + ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr));
				IL_94:
				goto IL_37;
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x0004EA9C File Offset: 0x0004CC9C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cmUqbj78eE(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							goto IL_9F;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_9F;
					}
					break;
					IL_9F:
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
					{
						num2 = 1;
					}
				}
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT - ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x0004EB6C File Offset: 0x0004CD6C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC iHaqzsE4Kf(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_59;
					case 1:
						goto IL_59;
					case 2:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 3:
						goto IL_6E;
					case 4:
						break;
					default:
						goto IL_59;
					}
					\u0020 = \u0020.s9Cd9Og84k();
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_59:
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
					{
						goto IL_BC;
					}
					num2 = 3;
				}
				IL_6E:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_BC:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked(this.OluhFK2lXQ.Y3Why5AObT - ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT));
			}

			// Token: 0x060009DF RID: 2527 RVA: 0x0004EC5C File Offset: 0x0004CE5C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC auGdW5LU1o(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_33;
					case 1:
						goto IL_5B;
					case 2:
						\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
						{
							num2 = 1;
						}
						break;
					case 3:
						if (!\u0020.TB5dFM9QIv())
						{
							goto IL_5B;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 2;
						}
						break;
					}
				}
				IL_33:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked(this.OluhFK2lXQ.SL4hxlZ2Vr - ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr));
				IL_5B:
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				goto IL_33;
			}

			// Token: 0x060009E0 RID: 2528 RVA: 0x0004ED3C File Offset: 0x0004CF3C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cT0dPKbnSa(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						\u0020 = \u0020.s9Cd9Og84k();
						break;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_86;
					}
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
					{
						goto IL_A8;
					}
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
					{
						num2 = 2;
					}
				}
				IL_86:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT * ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_A8:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009E1 RID: 2529 RVA: 0x0004EDF8 File Offset: 0x0004CFF8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC C3mdEhLvXd(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_8C;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_58;
					case 3:
						goto IL_99;
					default:
						goto IL_8C;
					}
					IL_67:
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
					{
						goto IL_99;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_8C:
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					goto IL_67;
				}
				IL_58:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_99:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked(this.OluhFK2lXQ.Y3Why5AObT * ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT));
			}

			// Token: 0x060009E2 RID: 2530 RVA: 0x0004EEC8 File Offset: 0x0004D0C8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC jaYdc2eCJF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_26;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
				int num = 1;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
				{
					num = 1;
				}
				IL_10:
				switch (num)
				{
				case 1:
					IL_26:
					if (!\u0020.tTi8tbHhPd())
					{
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num = 2;
							goto IL_10;
						}
						goto IL_10;
					}
					break;
				case 2:
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked(this.OluhFK2lXQ.SL4hxlZ2Vr * ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr));
			}

			// Token: 0x060009E3 RID: 2531 RVA: 0x0004EF98 File Offset: 0x0004D198
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC XIyd5fI2tA(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_33;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
							num2 = 3;
							continue;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_33;
					}
					break;
					IL_33:
					if (!\u0020.tTi8tbHhPd())
					{
						goto IL_BB;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 0;
					}
				}
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT / ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_BB:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009E4 RID: 2532 RVA: 0x0004F068 File Offset: 0x0004D268
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Ut1dxA1rQp(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
				{
					goto IL_26;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
				int num = 1;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
				{
					num = 1;
				}
				IL_10:
				switch (num)
				{
				case 1:
					IL_26:
					if (\u0020.tTi8tbHhPd())
					{
						goto IL_4B;
					}
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				case 2:
					goto IL_4B;
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_4B:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.SL4hxlZ2Vr / ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr);
			}

			// Token: 0x060009E5 RID: 2533 RVA: 0x0004F128 File Offset: 0x0004D328
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC yCeduJ3YIo(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
				{
					goto IL_9F;
				}
				goto IL_7D;
				IL_10:
				int num;
				switch (num)
				{
				case 1:
					IL_7D:
					\u0020 = \u0020.s9Cd9Og84k();
					num = 0;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				case 2:
					return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT % ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				}
				IL_9F:
				if (!\u0020.tTi8tbHhPd())
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				num = 2;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
				{
					num = 2;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x060009E6 RID: 2534 RVA: 0x0004F1F8 File Offset: 0x0004D3F8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC O5ndVV1NCh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							goto IL_33;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_33;
					case 3:
						goto IL_43;
					}
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num2 = 2;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 1;
					}
				}
				IL_33:
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_43:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.SL4hxlZ2Vr % ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr);
			}

			// Token: 0x060009E7 RID: 2535 RVA: 0x0004F2C8 File Offset: 0x0004D4C8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC DyOdyCLR3X(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_5B;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_B2;
					case 3:
						goto IL_33;
					default:
						goto IL_5B;
					}
					IL_68:
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
					{
						break;
					}
					num2 = 2;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_5B:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_68;
				}
				IL_33:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT & ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_B2:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009E8 RID: 2536 RVA: 0x0004F3A8 File Offset: 0x0004D5A8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC dH3d8VFM3E(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
						break;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_61;
					}
					if (!\u0020.tTi8tbHhPd())
					{
						goto IL_83;
					}
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
					{
						num2 = 1;
					}
				}
				IL_61:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT | ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_83:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009E9 RID: 2537 RVA: 0x0004F464 File Offset: 0x0004D664
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Rw9dqatOP5()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(~this.OluhFK2lXQ.Y3Why5AObT);
			}

			// Token: 0x060009EA RID: 2538 RVA: 0x0004F480 File Offset: 0x0004D680
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC lBXdd758He(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
				{
					goto IL_32;
				}
				\u0020 = \u0020.s9Cd9Og84k();
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
				{
					num = 0;
				}
				IL_10:
				switch (num)
				{
				case 1:
					return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT ^ ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT);
				}
				IL_32:
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				num = 1;
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
				{
					num = 0;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x060009EB RID: 2539 RVA: 0x0004F530 File Offset: 0x0004D730
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC L5SdoEFytK(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							if (\u0020.TB5dFM9QIv())
							{
								goto IL_8A;
							}
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							goto IL_5A;
						case 3:
							goto IL_8A;
						case 4:
							goto IL_A0;
						}
						IL_4A:
						if (\u0020.tTi8tbHhPd())
						{
							goto IL_A0;
						}
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.FDjwOseKAW4p25pSZdN(\u0020))
						{
							goto IL_84;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
						goto IL_4A;
					}
					IL_8A:
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num = 5;
				}
				IL_5A:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT << ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.RSpoGBedPLd8Ba8r6SB((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_84:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_A0:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT << ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.HDmhqUiRl0);
			}

			// Token: 0x060009EC RID: 2540 RVA: 0x0004F65C File Offset: 0x0004D85C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC f17d3EnLUZ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_DD;
					case 2:
						goto IL_37;
					case 3:
						\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 3;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					}
					if (\u0020.tTi8tbHhPd())
					{
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
						{
							num2 = 0;
						}
					}
					else
					{
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.FDjwOseKAW4p25pSZdN(\u0020))
						{
							goto IL_41;
						}
						num2 = 2;
					}
				}
				IL_37:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_41:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT >> ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.RSpoGBedPLd8Ba8r6SB((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_DD:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.Y3Why5AObT >> ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.HDmhqUiRl0);
			}

			// Token: 0x060009ED RID: 2541 RVA: 0x0004F780 File Offset: 0x0004D980
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC V36dQSy6F7(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_6D;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						break;
					case 3:
						goto IL_8F;
					default:
						goto IL_6D;
					}
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
					{
						goto Block_4;
					}
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.FDjwOseKAW4p25pSZdN(\u0020))
					{
						num2 = 3;
						continue;
					}
					goto IL_B9;
					IL_6D:
					\u0020 = \u0020.s9Cd9Og84k();
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
					{
						num2 = 1;
					}
				}
				IL_8F:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.SL4hxlZ2Vr >> ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.RSpoGBedPLd8Ba8r6SB((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_B9:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_4:
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(this.OluhFK2lXQ.SL4hxlZ2Vr >> ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.HDmhqUiRl0);
			}

			// Token: 0x060009EE RID: 2542 RVA: 0x0004F880 File Offset: 0x0004DA80
			public override string ToString()
			{
				if (this.ioThWif4AI == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7)
				{
					return this.OluhFK2lXQ.Y3Why5AObT.ToString();
				}
				return this.OluhFK2lXQ.SL4hxlZ2Vr.ToString();
			}

			// Token: 0x060009EF RID: 2543 RVA: 0x0004F8BC File Offset: 0x0004DABC
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				return this;
			}

			// Token: 0x060009F0 RID: 2544 RVA: 0x0004F8C8 File Offset: 0x0004DAC8
			internal override bool y9QdwWY3Xc()
			{
				return true;
			}

			// Token: 0x060009F1 RID: 2545 RVA: 0x0004F8D4 File Offset: 0x0004DAD4
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nH2oB1eeiZ1maoGUR5o(\u0020))
				{
					return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.DWlFbbek8CuM6XQlacj((ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT)\u0020, this);
				}
				int num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
				{
					num = 1;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num = 0;
					}
				}
				else
				{
					x0cbwj80qtx55Tsu8UC = \u0020.s9Cd9Og84k();
					num = 2;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num = 1;
					}
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						goto IL_2A;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(x0cbwj80qtx55Tsu8UC))
						{
							num = 3;
							continue;
						}
						break;
					case 3:
						goto IL_69;
					}
					break;
				}
				return false;
				IL_2A:
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.DWlFbbek8CuM6XQlacj((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
				IL_69:
				return this.OluhFK2lXQ.Y3Why5AObT == ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)x0cbwj80qtx55Tsu8UC).OluhFK2lXQ.Y3Why5AObT;
			}

			// Token: 0x060009F2 RID: 2546 RVA: 0x0004F9D4 File Offset: 0x0004DBD4
			private static ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB Ekjuu6h3dT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB;
				for (;;)
				{
					switch (num2)
					{
					case 2:
						goto IL_37;
					case 3:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							if (\u0020.TB5dFM9QIv())
							{
								goto IL_37;
							}
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 4:
						qmmmuQuSWS2kKwsrFfB = (\u0020 as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
						num2 = 3;
						continue;
					}
					break;
					IL_37:
					qmmmuQuSWS2kKwsrFfB = (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020) as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
					{
						num2 = 0;
					}
				}
				return qmmmuQuSWS2kKwsrFfB;
			}

			// Token: 0x060009F3 RID: 2547 RVA: 0x0004FA94 File Offset: 0x0004DC94
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 5;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return false;
					case 2:
						goto IL_FA;
					case 3:
						if (!x0cbwj80qtx55Tsu8UC.tTi8tbHhPd())
						{
							return false;
						}
						num2 = 2;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 2;
							continue;
						}
						continue;
					case 4:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
							num2 = 3;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					case 5:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.nH2oB1eeiZ1maoGUR5o(\u0020))
						{
							num2 = 4;
							continue;
						}
						return false;
					}
					break;
				}
				return ((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020).g5sdhSCwCu(this);
				IL_FA:
				return this.OluhFK2lXQ.SL4hxlZ2Vr != ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)x0cbwj80qtx55Tsu8UC).OluhFK2lXQ.SL4hxlZ2Vr;
			}

			// Token: 0x060009F4 RID: 2548 RVA: 0x0004FBBC File Offset: 0x0004DDBC
			public override bool SqWdSNFM0N(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_C4;
					case 1:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_AF;
					case 3:
						break;
					case 4:
						goto IL_5E;
					default:
						goto IL_C4;
					}
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num2 = 2;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_AF:
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
					{
						num2 = 4;
						continue;
					}
					break;
					IL_C4:
					goto IL_AF;
				}
				return this.OluhFK2lXQ.Y3Why5AObT >= ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_5E:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009F5 RID: 2549 RVA: 0x0004FC9C File Offset: 0x0004DE9C
			public override bool DSNdIxSMBQ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							goto IL_9D;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_9D;
					}
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 2;
					}
				}
				IL_9D:
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					return this.OluhFK2lXQ.SL4hxlZ2Vr >= ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009F6 RID: 2550 RVA: 0x0004FD58 File Offset: 0x0004DF58
			public override bool DoCdicvJaP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_32;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
				{
					num = 1;
				}
				IL_10:
				switch (num)
				{
				case 1:
					IL_32:
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
					{
						throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
					}
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
				return this.OluhFK2lXQ.Y3Why5AObT > ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT;
			}

			// Token: 0x060009F7 RID: 2551 RVA: 0x0004FE04 File Offset: 0x0004E004
			public override bool IJkdZ22aVF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							goto IL_6B;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_6B;
					case 4:
						goto IL_47;
					}
					break;
					IL_6B:
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
					{
						num2 = 1;
					}
				}
				IL_37:
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_47:
				return this.OluhFK2lXQ.SL4hxlZ2Vr > ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				goto IL_37;
			}

			// Token: 0x060009F8 RID: 2552 RVA: 0x0004FEE0 File Offset: 0x0004E0E0
			public override bool VdHdUonKxI(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_7D;
					case 2:
						\u0020 = \u0020.s9Cd9Og84k();
						goto IL_58;
					case 3:
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							goto IL_58;
						}
						num2 = 2;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
					IL_58:
					if (\u0020.tTi8tbHhPd())
					{
						goto IL_7D;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
					{
						num2 = 0;
					}
				}
				goto IL_A4;
				IL_7D:
				return this.OluhFK2lXQ.Y3Why5AObT <= ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_A4:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x060009F9 RID: 2553 RVA: 0x0004FFBC File Offset: 0x0004E1BC
			public override bool sxQd1txC3H(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_91;
					case 2:
						\u0020 = \u0020.s9Cd9Og84k();
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
						{
							num2 = 2;
							continue;
						}
						goto IL_91;
					}
					break;
				}
				IL_6A:
				return this.OluhFK2lXQ.SL4hxlZ2Vr <= ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_91:
				if (!\u0020.tTi8tbHhPd())
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				goto IL_6A;
			}

			// Token: 0x060009FA RID: 2554 RVA: 0x00050088 File Offset: 0x0004E288
			public override bool WY8dpeljbh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.tCXnvReLEjYmNuKhRwi(\u0020))
				{
					goto IL_78;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
				{
					num = 0;
				}
				IL_10:
				switch (num)
				{
				case 1:
					return this.OluhFK2lXQ.Y3Why5AObT < ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.Y3Why5AObT;
				}
				IL_78:
				if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.Oes0iWean5BEfpMSO0i(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				num = 1;
				if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() != null)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x060009FB RID: 2555 RVA: 0x00050134 File Offset: 0x0004E334
			public override bool Fqpd4WZY4A(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!\u0020.TB5dFM9QIv())
						{
							goto IL_33;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.BWsAFceEWZ18AV4wKTq() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_65;
					case 3:
						goto IL_33;
					}
					\u0020 = ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.ruWVJfelUgkLjyLIcRL(\u0020);
					num2 = 3;
					if (!ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.D4V3XmePpVdHOj2P3mi())
					{
						num2 = 0;
					}
				}
				IL_33:
				if (!\u0020.tTi8tbHhPd())
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_65:
				return this.OluhFK2lXQ.SL4hxlZ2Vr < ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
			}

			// Token: 0x060009FC RID: 2556 RVA: 0x00050210 File Offset: 0x0004E410
			// Note: this type is marked as 'beforefieldinit'.
			static kQJWGaucMXeMCLLKdvN()
			{
				ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.zU9DcwerQmVdIKR7VhA();
			}

			// Token: 0x060009FD RID: 2557 RVA: 0x00050220 File Offset: 0x0004E420
			internal static bool D4V3XmePpVdHOj2P3mi()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.raCL6TeW1M6gB3j5Wys == null;
			}

			// Token: 0x060009FE RID: 2558 RVA: 0x00050234 File Offset: 0x0004E434
			internal static ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN BWsAFceEWZ18AV4wKTq()
			{
				return ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN.raCL6TeW1M6gB3j5Wys;
			}

			// Token: 0x060009FF RID: 2559 RVA: 0x00050244 File Offset: 0x0004E444
			internal static void Uq13ksec6yShYphgScE()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000A00 RID: 2560 RVA: 0x00050254 File Offset: 0x0004E454
			internal static void ePWqWqe53Cql0DTfPn2()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000A01 RID: 2561 RVA: 0x00050264 File Offset: 0x0004E464
			internal static bool MZoV6BexRIrlRyWSScY(object A_0)
			{
				return A_0.WuHqq9Wdbv();
			}

			// Token: 0x06000A02 RID: 2562 RVA: 0x00050278 File Offset: 0x0004E478
			internal static object SOCCeMeugBbcn7DEuhc(object A_0)
			{
				return A_0.upCqZP4jJd();
			}

			// Token: 0x06000A03 RID: 2563 RVA: 0x0005028C File Offset: 0x0004E48C
			internal static object PiY5FAeV3nnwoj0xwqW(object A_0)
			{
				return A_0.NtxqQI1Zcd();
			}

			// Token: 0x06000A04 RID: 2564 RVA: 0x000502A0 File Offset: 0x0004E4A0
			internal static object fB6FHJeyr6F6N4WjqCP(object A_0)
			{
				return A_0.kZFq9GpslU();
			}

			// Token: 0x06000A05 RID: 2565 RVA: 0x000502B4 File Offset: 0x0004E4B4
			internal static object Sa2qVKe8I1OHZYCYspR(object A_0)
			{
				return A_0.PQEqwQ01dQ();
			}

			// Token: 0x06000A06 RID: 2566 RVA: 0x000502C8 File Offset: 0x0004E4C8
			internal static object AflrvieqWYo7ccDBOCA(object A_0)
			{
				return A_0.QtGqh2NDQ8();
			}

			// Token: 0x06000A07 RID: 2567 RVA: 0x000502DC File Offset: 0x0004E4DC
			internal static object RSpoGBedPLd8Ba8r6SB(object A_0)
			{
				return A_0.eoUqScGyAS();
			}

			// Token: 0x06000A08 RID: 2568 RVA: 0x000502F0 File Offset: 0x0004E4F0
			internal static object NeQtNIeofnDOgGGExp4(object A_0)
			{
				return A_0.U0ZqI72BOj();
			}

			// Token: 0x06000A09 RID: 2569 RVA: 0x00050304 File Offset: 0x0004E504
			internal static bool t4cGQ3e3V2qV2nnUDZy(Type A_0, Type A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000A0A RID: 2570 RVA: 0x0005031C File Offset: 0x0004E51C
			internal static bool nTEKQmeQUemnLmZynDv(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000A0B RID: 2571 RVA: 0x00050334 File Offset: 0x0004E534
			internal static Type ct3lTZeCIjbmU5Z5FvD(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000A0C RID: 2572 RVA: 0x00050348 File Offset: 0x0004E548
			internal static RuntimeTypeHandle Y9VPp1e9whZXbehjBR9(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000A0D RID: 2573 RVA: 0x0005035C File Offset: 0x0004E55C
			internal static Type yb4ch7ewW8KHuI2jwTH(Type A_0)
			{
				return Enum.GetUnderlyingType(A_0);
			}

			// Token: 0x06000A0E RID: 2574 RVA: 0x00050370 File Offset: 0x0004E570
			internal static object egfS0xeADoGMDj3gqw5(Type A_0, int A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000A0F RID: 2575 RVA: 0x00050388 File Offset: 0x0004E588
			internal static object bqrhHjehtXo5TZu3x8c(Type A_0, uint A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000A10 RID: 2576 RVA: 0x000503A0 File Offset: 0x0004E5A0
			internal static object Cv1OLGeSsO7PaBZE3ih(Type A_0, short A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000A11 RID: 2577 RVA: 0x000503B8 File Offset: 0x0004E5B8
			internal static object QmRVmNeIaKQdWu4WIBA(Type A_0, ushort A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000A12 RID: 2578 RVA: 0x000503D0 File Offset: 0x0004E5D0
			internal static object rMGncMeiKRBihsuAlnp(Type A_0, byte A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000A13 RID: 2579 RVA: 0x000503E8 File Offset: 0x0004E5E8
			internal static object wH5QFDeZeRTqJwhKtFW(Type A_0, sbyte A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000A14 RID: 2580 RVA: 0x00050400 File Offset: 0x0004E600
			internal static object P6IL1TeUh1btsHtcul0(Type A_0, long A_1)
			{
				return Enum.ToObject(A_0, A_1);
			}

			// Token: 0x06000A15 RID: 2581 RVA: 0x00050418 File Offset: 0x0004E618
			internal static bool MrKrf3e10R4AFRskwrL(object A_0)
			{
				return A_0.icyqdm73mi();
			}

			// Token: 0x06000A16 RID: 2582 RVA: 0x0005042C File Offset: 0x0004E62C
			internal static object xPtQhDepoZBnVhAa35B(object A_0)
			{
				return A_0.Br0qAy7jU5();
			}

			// Token: 0x06000A17 RID: 2583 RVA: 0x00050440 File Offset: 0x0004E640
			internal static object Igehn4e4gMmn9h6jmDZ(object A_0)
			{
				return A_0.JWZqiAqFR8();
			}

			// Token: 0x06000A18 RID: 2584 RVA: 0x00050454 File Offset: 0x0004E654
			internal static int ejXhigeOwJThd29Z6Ap()
			{
				return IntPtr.Size;
			}

			// Token: 0x06000A19 RID: 2585 RVA: 0x00050464 File Offset: 0x0004E664
			internal static object t3OOHhefJtW6COpXIOW(object A_0)
			{
				return A_0.FOJqpHkit6();
			}

			// Token: 0x06000A1A RID: 2586 RVA: 0x00050478 File Offset: 0x0004E678
			internal static object Cw2AEkeFIdmgurmYfsj(object A_0)
			{
				return A_0.SZBqTRsZeT();
			}

			// Token: 0x06000A1B RID: 2587 RVA: 0x0005048C File Offset: 0x0004E68C
			internal static object rRawPceTVJF3i0LZQnO(object A_0)
			{
				return A_0.Vy2qKYUMDe();
			}

			// Token: 0x06000A1C RID: 2588 RVA: 0x000504A0 File Offset: 0x0004E6A0
			internal static object VDBAc4eRww5UxsOe5GI(object A_0)
			{
				return A_0.c1Bqr7stpA();
			}

			// Token: 0x06000A1D RID: 2589 RVA: 0x000504B4 File Offset: 0x0004E6B4
			internal static bool tCXnvReLEjYmNuKhRwi(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000A1E RID: 2590 RVA: 0x000504C8 File Offset: 0x0004E6C8
			internal static object ruWVJfelUgkLjyLIcRL(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000A1F RID: 2591 RVA: 0x000504DC File Offset: 0x0004E6DC
			internal static bool Oes0iWean5BEfpMSO0i(object A_0)
			{
				return A_0.tTi8tbHhPd();
			}

			// Token: 0x06000A20 RID: 2592 RVA: 0x000504F0 File Offset: 0x0004E6F0
			internal static bool FDjwOseKAW4p25pSZdN(object A_0)
			{
				return A_0.snedf8QbBG();
			}

			// Token: 0x06000A21 RID: 2593 RVA: 0x00050504 File Offset: 0x0004E704
			internal static bool nH2oB1eeiZ1maoGUR5o(object A_0)
			{
				return A_0.MEy8J5BANA();
			}

			// Token: 0x06000A22 RID: 2594 RVA: 0x00050518 File Offset: 0x0004E718
			internal static bool DWlFbbek8CuM6XQlacj(object A_0, object A_1)
			{
				return A_0.ovDdASrPUT(A_1);
			}

			// Token: 0x06000A23 RID: 2595 RVA: 0x00050530 File Offset: 0x0004E730
			internal static void zU9DcwerQmVdIKR7VhA()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003BC RID: 956
			public ykD11HxHfZBYH7OcFOG.e0GjEEuEf6ToqLF4ouH OluhFK2lXQ;

			// Token: 0x040003BD RID: 957
			public ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ ioThWif4AI;

			// Token: 0x040003BE RID: 958
			internal static ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN raCL6TeW1M6gB3j5Wys;
		}

		// Token: 0x02000071 RID: 113
		private class vILrVAuVmjGxVilaUfb : ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB
		{
			// Token: 0x06000A24 RID: 2596 RVA: 0x00050540 File Offset: 0x0004E740
			internal void YqIuyfQ6hA(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num;
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
				{
					this.WytiIREvTV = ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).WytiIREvTV;
					num = 1;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num = 1;
					}
				}
				else
				{
					this.AxwqVJ6XV5(\u0020);
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
					{
						num = 0;
					}
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.Btdim12bl2 = ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).Btdim12bl2;
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num = 2;
							continue;
						}
						continue;
					case 2:
						return;
					}
					break;
				}
			}

			// Token: 0x06000A25 RID: 2597 RVA: 0x000505FC File Offset: 0x0004E7FC
			internal unsafe override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 5;
				object obj;
				IntPtr value;
				Type type;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_525;
						case 2:
							if (obj == null)
							{
								num2 = 30;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
								{
									num2 = 36;
									continue;
								}
								continue;
							}
							else
							{
								if (IntPtr.Size != 8)
								{
									goto IL_124;
								}
								num2 = 8;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
								{
									num2 = 5;
									continue;
								}
								continue;
							}
							break;
						case 3:
							return;
						case 4:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
							{
								goto IL_5ED;
							}
							num2 = 27;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 8;
								continue;
							}
							continue;
						case 5:
							if (!\u0020.tXF8H2TS5Y())
							{
								obj = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.tTHe9fe0xHUdtaLg1T1(\u0020, null);
								num2 = 2;
								continue;
							}
							num2 = 4;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 6:
							goto IL_67F;
						case 7:
							return;
						case 8:
							value = new IntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.Y3Why5AObT);
							num2 = 2;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 34;
								continue;
							}
							continue;
						case 9:
							return;
						case 10:
							*(short*)((void*)value) = (short)((ushort)obj);
							num2 = 21;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 11:
							goto IL_283;
						case 12:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777225))))
							{
								num2 = 19;
								continue;
							}
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777328))))
							{
								goto IL_10B;
							}
							num2 = 20;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 5;
								continue;
							}
							continue;
						case 13:
							*(IntPtr*)((void*)value) = (IntPtr)obj;
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 14:
							return;
						case 15:
							*(long*)((void*)value) = (long)obj;
							num2 = 9;
							continue;
						case 16:
							return;
						case 17:
							*(int*)((void*)value) = (int)obj;
							num2 = 18;
							continue;
						case 18:
							return;
						case 19:
							return;
						case 20:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777614))))
							{
								num2 = 1;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
								{
									num2 = 22;
									continue;
								}
								continue;
							}
							else
							{
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777253))))
								{
									goto IL_6FA;
								}
								num2 = 15;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
								{
									num2 = 30;
									continue;
								}
								continue;
							}
							break;
						case 21:
							return;
						case 22:
							*(byte*)((void*)value) = (byte)((sbyte)obj);
							num2 = 26;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 5;
								continue;
							}
							continue;
						case 23:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777561))))
							{
								num2 = 15;
								if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
								{
									num2 = 5;
									continue;
								}
								continue;
							}
							else
							{
								if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777257))))
								{
									num2 = 31;
									continue;
								}
								*(long*)((void*)value) = (long)((ulong)obj);
								num2 = 13;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
								{
									num2 = 24;
									continue;
								}
								continue;
							}
							break;
						case 24:
							return;
						case 25:
							return;
						case 26:
							return;
						case 27:
						{
							IntPtr value2 = new IntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.Y3Why5AObT);
							IntPtr intPtr = new IntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).WytiIREvTV).OluhFK2lXQ.Y3Why5AObT);
							*(long*)((void*)value2) = intPtr.ToInt64();
							num2 = 28;
							continue;
						}
						case 28:
							return;
						case 29:
							goto IL_6FA;
						case 30:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777252))))
							{
								num2 = 10;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
								{
									num2 = 1;
									continue;
								}
								continue;
							}
							else
							{
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777219))))
								{
									num2 = 17;
									continue;
								}
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777256))))
								{
									goto IL_67F;
								}
								num2 = 23;
								if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
								{
									num2 = 5;
									continue;
								}
								continue;
							}
							break;
						case 31:
							if (type == Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777333)))
							{
								num2 = 39;
								continue;
							}
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777346))))
							{
								*(double*)((void*)value) = (double)obj;
								num2 = 33;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
								{
									num2 = 38;
									continue;
								}
								continue;
							}
							else
							{
								if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777220))))
								{
									goto Block_19;
								}
								goto IL_525;
							}
							break;
						case 32:
							goto IL_124;
						case 33:
							goto IL_31F;
						case 34:
							goto IL_300;
						case 35:
							if (type == ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777245)))
							{
								num2 = 13;
								continue;
							}
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777615))))
							{
								goto IL_473;
							}
							num2 = 37;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 10;
								continue;
							}
							continue;
						case 36:
							return;
						case 37:
							goto IL_190;
						case 38:
							return;
						case 39:
							*(float*)((void*)value) = (float)obj;
							num2 = 16;
							continue;
						case 40:
							goto IL_10B;
						}
						goto Block_1;
						IL_10B:
						*(byte*)((void*)value) = (byte)obj;
						num2 = 7;
						continue;
						IL_124:
						value = new IntPtr(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)this.WytiIREvTV).aYsh65bDic.RekhP3Apm0);
						num2 = 13;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 33;
							continue;
						}
						continue;
						IL_525:
						*(byte*)((void*)value) = (((bool)obj) ? 1 : 0);
						num2 = 3;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 3;
							continue;
						}
						continue;
						IL_67F:
						*(int*)((void*)value) = (int)((uint)obj);
						num2 = 6;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 14;
							continue;
						}
						continue;
						IL_6FA:
						*(short*)((void*)value) = (short)obj;
						num2 = 25;
					}
					IL_31F:
					type = obj.GetType();
					num = 12;
					continue;
					Block_19:
					num = 35;
					continue;
					IL_300:
					goto IL_31F;
				}
				Block_1:
				return;
				IL_190:
				*(IntPtr*)((void*)value) = (IntPtr)((UIntPtr)obj);
				return;
				IL_283:
				*(short*)((void*)value) = (short)((char)obj);
				return;
				IL_473:
				if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(type, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777323))))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				goto IL_283;
				IL_5ED:
				IntPtr value3 = new IntPtr(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)this.WytiIREvTV).aYsh65bDic.RekhP3Apm0);
				IntPtr intPtr2 = new IntPtr(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).WytiIREvTV).aYsh65bDic.RekhP3Apm0);
				*(int*)((void*)value3) = intPtr2.ToInt32();
			}

			// Token: 0x06000A26 RID: 2598 RVA: 0x00050DAC File Offset: 0x0004EFAC
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.vuR8Nfetw95X4IuT9oW(this, \u0020);
			}

			// Token: 0x06000A27 RID: 2599 RVA: 0x00050DC8 File Offset: 0x0004EFC8
			public vILrVAuVmjGxVilaUfb(IntPtr \u0020)
			{
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jxW2jheY15Ueucs75Ee();
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.as7lDlesigEDf3nsQy5();
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						return;
					case 3:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
						num = 1;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 4:
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(\u0020.ToInt64());
						num = 5;
						if (true)
						{
							num = 5;
							continue;
						}
						continue;
					case 5:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
						num = 2;
						continue;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(\u0020.ToInt32());
							num = 3;
							continue;
						}
						num = 4;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)3;
					num = 6;
				}
			}

			// Token: 0x06000A28 RID: 2600 RVA: 0x00050EE4 File Offset: 0x0004F0E4
			public vILrVAuVmjGxVilaUfb(UIntPtr \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 3;
				if (true)
				{
					num = 6;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
						num = 3;
						if (!true)
						{
							num = 3;
							continue;
						}
						continue;
					case 2:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
						num = 0;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						if (IntPtr.Size == 8)
						{
							num = 5;
							continue;
						}
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(\u0020.ToUInt32());
						num = 0;
						if (true)
						{
							num = 1;
							continue;
						}
						continue;
					case 5:
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(\u0020.ToUInt64());
						num = 2;
						continue;
					case 6:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)3;
						num = 4;
						continue;
					}
					break;
				}
			}

			// Token: 0x06000A29 RID: 2601 RVA: 0x00051000 File Offset: 0x0004F200
			public vILrVAuVmjGxVilaUfb()
			{
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jxW2jheY15Ueucs75Ee();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)3;
						num = 4;
						continue;
					case 3:
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(0L);
						num = 0;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 4:
					{
						if (IntPtr.Size == 8)
						{
							num = 3;
							continue;
						}
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0);
						int num2 = 5;
						num = num2;
						continue;
					}
					case 5:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
						num = 1;
						if (false)
						{
							num = 0;
							continue;
						}
						continue;
					case 6:
						return;
					}
					this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
					num = 6;
				}
			}

			// Token: 0x06000A2A RID: 2602 RVA: 0x000510FC File Offset: 0x0004F2FC
			public override ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB AxLq8nl88V()
			{
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb
				{
					WytiIREvTV = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.mDKY0Yeg5acPLJYlv2k(this.WytiIREvTV),
					Btdim12bl2 = this.Btdim12bl2
				};
			}

			// Token: 0x06000A2B RID: 2603 RVA: 0x00051128 File Offset: 0x0004F328
			public vILrVAuVmjGxVilaUfb(long \u0020)
			{
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jxW2jheY15Ueucs75Ee();
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.as7lDlesigEDf3nsQy5();
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(\u0020);
						num = 4;
						if (!true)
						{
							num = 2;
							continue;
						}
						continue;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)\u0020);
							num = 5;
							continue;
						}
						num = 1;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						return;
					case 4:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
						num = 3;
						continue;
					case 5:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12;
						num = 6;
						continue;
					case 6:
						return;
					}
					this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)3;
					num = 2;
				}
			}

			// Token: 0x06000A2C RID: 2604 RVA: 0x0005122C File Offset: 0x0004F42C
			public vILrVAuVmjGxVilaUfb(long \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.Btdim12bl2 = \u0020;
						num = 0;
						if (false)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
					{
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)3;
						int num2 = 6;
						num = num2;
						continue;
					}
					case 3:
						return;
					case 4:
						this.Btdim12bl2 = \u0020;
						num = 3;
						continue;
					case 5:
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(\u0020);
						num = 4;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num = 5;
							continue;
						}
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)\u0020);
						num = 1;
						if (!true)
						{
							num = 1;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000A2D RID: 2605 RVA: 0x00051334 File Offset: 0x0004F534
			public vILrVAuVmjGxVilaUfb(ulong \u0020)
			{
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jxW2jheY15Ueucs75Ee();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)4;
						num = 6;
						continue;
					case 3:
						return;
					case 4:
						this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13;
						num = 3;
						continue;
					case 5:
						this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(\u0020);
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					case 6:
					{
						int num2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 5;
						}
						else
						{
							this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)\u0020);
							num2 = 4;
						}
						num = num2;
						continue;
					}
					}
					this.Btdim12bl2 = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13;
					num = 1;
					if (!false)
					{
						num = 1;
					}
				}
			}

			// Token: 0x06000A2E RID: 2606 RVA: 0x00051434 File Offset: 0x0004F634
			public vILrVAuVmjGxVilaUfb(ulong \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jxW2jheY15Ueucs75Ee();
				ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.as7lDlesigEDf3nsQy5();
				base..ctor();
				int num = 3;
				if (!true)
				{
					num = 3;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.Btdim12bl2 = \u0020;
						num = 1;
						if (!true)
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)4;
						num = 6;
						continue;
					case 4:
						this.Btdim12bl2 = \u0020;
						num = 1;
						if (!false)
						{
							num = 5;
							continue;
						}
						continue;
					case 5:
						return;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)\u0020);
							num = 2;
							continue;
						}
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					this.WytiIREvTV = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(\u0020);
					num = 4;
				}
			}

			// Token: 0x06000A2F RID: 2607 RVA: 0x00051544 File Offset: 0x0004F744
			public override bool WuHqq9Wdbv()
			{
				return this.WytiIREvTV.WuHqq9Wdbv();
			}

			// Token: 0x06000A30 RID: 2608 RVA: 0x00051558 File Offset: 0x0004F758
			public override bool icyqdm73mi()
			{
				return !ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.hAdL0geXhtVc2FJFMgL(this);
			}

			// Token: 0x06000A31 RID: 2609 RVA: 0x0005156C File Offset: 0x0004F76C
			internal override bool lPSqCCLN7S()
			{
				return this.icyqdm73mi();
			}

			// Token: 0x06000A32 RID: 2610 RVA: 0x0005157C File Offset: 0x0004F77C
			internal override bool YbodO0QW3H()
			{
				return true;
			}

			// Token: 0x06000A33 RID: 2611 RVA: 0x00051588 File Offset: 0x0004F788
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Q1tqoFEFyp(ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				switch (\u0020)
				{
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
					return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.HbP0CseGDUtC4Nqeyuk(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
					return this.PQEqwQ01dQ();
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
					return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.HtRehKeB1qLcf5XSF9O(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
					return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.LRoZYOeDnfCZrh4BRTN(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
					return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
					return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.R4aj5RejPgcLR2GBsjY(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
					return this.JWZqiAqFR8();
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8:
					return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.mfsi3Meb3tTTWOJhBku(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)14:
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15:
					goto IL_EB;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11:
					return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.Ocy3MqeM8rlpAHGkkft(this);
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12:
					break;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)13:
					return this;
				case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)16:
					return this.AxLq8nl88V();
				default:
					goto IL_EB;
				}
				return this;
				IL_EB:
				ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4 ngYCBhqPZ7YsxPQyJh = (ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)4;
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return this;
				}
				throw new Exception(ngYCBhqPZ7YsxPQyJh.ToString());
			}

			// Token: 0x06000A34 RID: 2612 RVA: 0x0005169C File Offset: 0x0004F89C
			internal IntPtr oM8u8TUrCx()
			{
				if (IntPtr.Size == 8)
				{
					return new IntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.Y3Why5AObT);
				}
				return new IntPtr(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)this.WytiIREvTV).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000A35 RID: 2613 RVA: 0x000516F8 File Offset: 0x0004F8F8
			internal override object y9jq31urLD(Type \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.u9UKxWezChloYTcoFZN(\u0020, null) || !\u0020.IsByRef)
				{
					goto IL_2CA;
				}
				int num = 4;
				for (;;)
				{
					IL_10:
					switch (num)
					{
					default:
						goto IL_4E;
					case 1:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(\u0020, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rW370teJ3mHAJRvSPeU(16777615))))
						{
							num = 6;
							continue;
						}
						if (!(\u0020 == null))
						{
							goto IL_1DB;
						}
						num = 10;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num = 4;
							continue;
						}
						continue;
					case 2:
						goto IL_20F;
					case 3:
						goto IL_2CA;
					case 4:
						\u0020 = \u0020.GetElementType();
						num = 3;
						continue;
					case 5:
						goto IL_142;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_B4;
						}
						num = 4;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num = 8;
							continue;
						}
						continue;
					case 7:
						break;
					case 8:
						goto IL_94;
					case 9:
						goto IL_1DB;
					case 10:
						break;
					case 11:
						goto IL_63;
					case 12:
						goto IL_151;
					}
					IL_1B6:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
					{
						num = 6;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num = 11;
							continue;
						}
						continue;
					}
					else
					{
						if (this.Btdim12bl2 == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12)
						{
							num = 12;
							continue;
						}
						goto IL_171;
					}
					IL_1DB:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FQ13wwemUJ4SwBD8WoE(\u0020, ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.EBgK4leHNLEfKEjtffs(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236))))
					{
						goto IL_1B6;
					}
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num = 5;
					}
				}
				IL_63:
				if (this.Btdim12bl2 == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12)
				{
					return new IntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.Y3Why5AObT);
				}
				return new UIntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_94:
				return new UIntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_B4:
				return new UIntPtr(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)this.WytiIREvTV).aYsh65bDic.Vavhb40As7);
				IL_142:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_151:
				return new IntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.HDmhqUiRl0);
				IL_171:
				return new UIntPtr(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)this.WytiIREvTV).aYsh65bDic.Vavhb40As7);
				IL_20F:
				return new IntPtr(((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.Y3Why5AObT);
				IL_4E:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					num = 2;
					goto IL_10;
				}
				return new IntPtr(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)this.WytiIREvTV).aYsh65bDic.RekhP3Apm0);
				IL_2CA:
				if (\u0020 == Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777245)))
				{
					goto IL_4E;
				}
				num = 0;
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000A36 RID: 2614 RVA: 0x00051A18 File Offset: 0x0004FC18
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NtxqQI1Zcd()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.Ocy3MqeM8rlpAHGkkft(this.WytiIREvTV);
			}

			// Token: 0x06000A37 RID: 2615 RVA: 0x00051A2C File Offset: 0x0004FC2C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F kZFq9GpslU()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.HbP0CseGDUtC4Nqeyuk(this.WytiIREvTV);
			}

			// Token: 0x06000A38 RID: 2616 RVA: 0x00051A40 File Offset: 0x0004FC40
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F PQEqwQ01dQ()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.dKTqOokWF5q5ePDEbTa(this.WytiIREvTV);
			}

			// Token: 0x06000A39 RID: 2617 RVA: 0x00051A54 File Offset: 0x0004FC54
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Br0qAy7jU5()
			{
				return this.WytiIREvTV.Br0qAy7jU5();
			}

			// Token: 0x06000A3A RID: 2618 RVA: 0x00051A68 File Offset: 0x0004FC68
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QtGqh2NDQ8()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.LRoZYOeDnfCZrh4BRTN(this.WytiIREvTV);
			}

			// Token: 0x06000A3B RID: 2619 RVA: 0x00051A7C File Offset: 0x0004FC7C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eoUqScGyAS()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this.WytiIREvTV);
			}

			// Token: 0x06000A3C RID: 2620 RVA: 0x00051A90 File Offset: 0x0004FC90
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F U0ZqI72BOj()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.R4aj5RejPgcLR2GBsjY(this.WytiIREvTV);
			}

			// Token: 0x06000A3D RID: 2621 RVA: 0x00051AA4 File Offset: 0x0004FCA4
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN JWZqiAqFR8()
			{
				return this.WytiIREvTV.JWZqiAqFR8();
			}

			// Token: 0x06000A3E RID: 2622 RVA: 0x00051AB8 File Offset: 0x0004FCB8
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN upCqZP4jJd()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.mfsi3Meb3tTTWOJhBku(this.WytiIREvTV);
			}

			// Token: 0x06000A3F RID: 2623 RVA: 0x00051ACC File Offset: 0x0004FCCC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lk5qURpdjk()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.HbP0CseGDUtC4Nqeyuk(this);
			}

			// Token: 0x06000A40 RID: 2624 RVA: 0x00051ADC File Offset: 0x0004FCDC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F HK7q1PliPm()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.HtRehKeB1qLcf5XSF9O(this);
			}

			// Token: 0x06000A41 RID: 2625 RVA: 0x00051AEC File Offset: 0x0004FCEC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F FOJqpHkit6()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this);
			}

			// Token: 0x06000A42 RID: 2626 RVA: 0x00051AFC File Offset: 0x0004FCFC
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN FmZq4JYpT6()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this);
			}

			// Token: 0x06000A43 RID: 2627 RVA: 0x00051B0C File Offset: 0x0004FD0C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F hYvqOWPpOC()
			{
				return this.PQEqwQ01dQ();
			}

			// Token: 0x06000A44 RID: 2628 RVA: 0x00051B1C File Offset: 0x0004FD1C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F o1ZqfYXchM()
			{
				return this.QtGqh2NDQ8();
			}

			// Token: 0x06000A45 RID: 2629 RVA: 0x00051B2C File Offset: 0x0004FD2C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F oAjqFTEeFY()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.R4aj5RejPgcLR2GBsjY(this);
			}

			// Token: 0x06000A46 RID: 2630 RVA: 0x00051B3C File Offset: 0x0004FD3C
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN SZBqTRsZeT()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.mfsi3Meb3tTTWOJhBku(this);
			}

			// Token: 0x06000A47 RID: 2631 RVA: 0x00051B4C File Offset: 0x0004FD4C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F ziwqR9N2wv()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.n7kbN3kEdBnp1n2jiTX(this.WytiIREvTV);
			}

			// Token: 0x06000A48 RID: 2632 RVA: 0x00051B60 File Offset: 0x0004FD60
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F j5lqLol41P()
			{
				return this.WytiIREvTV.j5lqLol41P();
			}

			// Token: 0x06000A49 RID: 2633 RVA: 0x00051B74 File Offset: 0x0004FD74
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NN3qlXny0A()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.rgahHukcL4UuDJyF0yS(this.WytiIREvTV);
			}

			// Token: 0x06000A4A RID: 2634 RVA: 0x00051B88 File Offset: 0x0004FD88
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F cMXqaCAZHq()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.Sd8PRYk514heRFRi0kW(this.WytiIREvTV);
			}

			// Token: 0x06000A4B RID: 2635 RVA: 0x00051B9C File Offset: 0x0004FD9C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Vy2qKYUMDe()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.laA4QOkxHvvvUXWyxPn(this.WytiIREvTV);
			}

			// Token: 0x06000A4C RID: 2636 RVA: 0x00051BB0 File Offset: 0x0004FDB0
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QmjqeL3I7g()
			{
				return this.WytiIREvTV.QmjqeL3I7g();
			}

			// Token: 0x06000A4D RID: 2637 RVA: 0x00051BC4 File Offset: 0x0004FDC4
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN rMZqkTKtdW()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.KCPBwukuOHaDOOBpOMe(this.WytiIREvTV);
			}

			// Token: 0x06000A4E RID: 2638 RVA: 0x00051BD8 File Offset: 0x0004FDD8
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN c1Bqr7stpA()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.DHEmNgkViqfo5kSdmp7(this.WytiIREvTV);
			}

			// Token: 0x06000A4F RID: 2639 RVA: 0x00051BEC File Offset: 0x0004FDEC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lZtq7DP5OI()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.V0JF7skydqKcLQ8nQ50(this.WytiIREvTV);
			}

			// Token: 0x06000A50 RID: 2640 RVA: 0x00051C00 File Offset: 0x0004FE00
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eFOq2JXLOE()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.l0tmOXk8MepiOVSdIJX(this.WytiIREvTV);
			}

			// Token: 0x06000A51 RID: 2641 RVA: 0x00051C14 File Offset: 0x0004FE14
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F CVaq6fDwxc()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.ykZIpnkqWluMqPAb0ig(this.WytiIREvTV);
			}

			// Token: 0x06000A52 RID: 2642 RVA: 0x00051C28 File Offset: 0x0004FE28
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F rvkqNso51v()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.wPjSjZkdawJdHohDfGA(this.WytiIREvTV);
			}

			// Token: 0x06000A53 RID: 2643 RVA: 0x00051C3C File Offset: 0x0004FE3C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F RywqnVZSZT()
			{
				return this.WytiIREvTV.RywqnVZSZT();
			}

			// Token: 0x06000A54 RID: 2644 RVA: 0x00051C50 File Offset: 0x0004FE50
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Jefq04Qqj5()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.bSVYxAkoNVvqfApJRmF(this.WytiIREvTV);
			}

			// Token: 0x06000A55 RID: 2645 RVA: 0x00051C64 File Offset: 0x0004FE64
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN LYYqJD7UOL()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.N0oXAKk3tqNGOXQOgCv(this.WytiIREvTV);
			}

			// Token: 0x06000A56 RID: 2646 RVA: 0x00051C78 File Offset: 0x0004FE78
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN Msjqm6OQGU()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.N482dwkQTcIxEcBihaU(this.WytiIREvTV);
			}

			// Token: 0x06000A57 RID: 2647 RVA: 0x00051C8C File Offset: 0x0004FE8C
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs qJhqHVUG8k()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.sWXtcTkCoRpfYj3sd1X(this.WytiIREvTV);
			}

			// Token: 0x06000A58 RID: 2648 RVA: 0x00051CA0 File Offset: 0x0004FEA0
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs c1GqttOeWQ()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.OggDKnk9tyTXUDySghs(this.WytiIREvTV);
			}

			// Token: 0x06000A59 RID: 2649 RVA: 0x00051CB4 File Offset: 0x0004FEB4
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs HF1qYGZ8gN()
			{
				return this.WytiIREvTV.HF1qYGZ8gN();
			}

			// Token: 0x06000A5A RID: 2650 RVA: 0x00051CC8 File Offset: 0x0004FEC8
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb yRRqsHbNK7()
			{
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.S4rKQLkw7LMHPDkK0Sy(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.zPJ1OQkAGEYmNAoAWUZ(this).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000A5B RID: 2651 RVA: 0x00051D20 File Offset: 0x0004FF20
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb D1PqgOGTyj()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eMJvnlkh6u3oBgXaOkq(this).OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jG5eJ7kSRYMxsihSQn5(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x06000A5C RID: 2652 RVA: 0x00051D78 File Offset: 0x0004FF78
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb XWcqXDk1Pt()
			{
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.KCPBwukuOHaDOOBpOMe(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)this.Vy2qKYUMDe().aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000A5D RID: 2653 RVA: 0x00051DC8 File Offset: 0x0004FFC8
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb JjkqMxqLaY()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.LYYqJD7UOL().OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.W9kGYwkIvBBb020b3T5(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x06000A5E RID: 2654 RVA: 0x00051E18 File Offset: 0x00050018
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb APcqGbirjs()
			{
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.DHEmNgkViqfo5kSdmp7(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.ixuiFBkiU9BVLYLep2G(this).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000A5F RID: 2655 RVA: 0x00051E68 File Offset: 0x00050068
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb CY1qBxKBHt()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.N482dwkQTcIxEcBihaU(this).OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.bSVYxAkoNVvqfApJRmF(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x06000A60 RID: 2656 RVA: 0x00051EB8 File Offset: 0x000500B8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC CpmqDtDe45()
			{
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(-((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)this.WytiIREvTV).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(-(long)((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)this.WytiIREvTV).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000A61 RID: 2657 RVA: 0x00051F1C File Offset: 0x0005011C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Add(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
				{
					goto IL_179;
				}
				goto IL_BA;
				int num;
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							int num2 = 2;
							num = num2;
							continue;
						}
						goto IL_77;
					case 2:
						goto IL_4B;
					case 3:
						goto IL_EB;
					case 4:
						goto IL_179;
					case 5:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num = 3;
							continue;
						}
						goto IL_117;
					}
					break;
				}
				goto IL_BA;
				IL_4B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT + ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT);
				IL_77:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 + ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_EB:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT + ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT);
				IL_117:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 + ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_BA:
				\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
				num = 4;
				goto IL_10;
				IL_179:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
				{
					num = 5;
					goto IL_10;
				}
				if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				num = 0;
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000A62 RID: 2658 RVA: 0x000520B8 File Offset: 0x000502B8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC LfyqvMrNHx(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
							goto IL_141;
						case 2:
							\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
							goto IL_186;
						case 3:
							if (\u0020.TB5dFM9QIv())
							{
								num2 = 2;
								continue;
							}
							goto IL_186;
						case 4:
							goto IL_3F;
						case 5:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
							{
								num2 = 6;
								continue;
							}
							goto IL_DF;
						case 6:
							goto IL_B3;
						}
						goto Block_1;
						IL_186:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
						{
							num2 = 4;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 5;
							}
						}
						else
						{
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
							{
								break;
							}
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 0;
							}
						}
					}
					IL_141:
					if (IntPtr.Size != 8)
					{
						goto IL_6B;
					}
					num = 4;
				}
				Block_1:
				goto IL_15A;
				IL_3F:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT + ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT));
				IL_6B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 + ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0)));
				IL_B3:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT + ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT));
				IL_DF:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 + ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0)));
				IL_15A:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A63 RID: 2659 RVA: 0x00052270 File Offset: 0x00050470
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC KrBqjlnYTv(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 7;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_192;
						case 2:
							goto IL_43;
						case 3:
							goto IL_DD;
						case 4:
							goto IL_ED;
						case 5:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
							{
								goto IL_6B;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 2;
								continue;
							}
							continue;
						case 7:
							if (!\u0020.TB5dFM9QIv())
							{
								num2 = 6;
								continue;
							}
							goto IL_ED;
						}
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
						{
							break;
						}
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							goto IL_DD;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_ED:
						\u0020 = \u0020.s9Cd9Og84k();
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 0;
						}
					}
					num = 5;
				}
				IL_43:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr + unchecked((ulong)((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7)));
				IL_6B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(checked(this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 + ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7))));
				IL_DD:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr + ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr));
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(checked(this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 + ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7)));
				IL_192:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A64 RID: 2660 RVA: 0x00052448 File Offset: 0x00050648
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cmUqbj78eE(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
							goto IL_127;
						case 2:
							goto IL_E1;
						case 3:
							\u0020 = \u0020.s9Cd9Og84k();
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
							{
								num2 = 1;
								continue;
							}
							continue;
						case 4:
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
							{
								goto IL_127;
							}
							num2 = 2;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 3;
								continue;
							}
							continue;
						case 5:
							goto IL_14C;
						case 6:
							goto IL_7D;
						}
						break;
						IL_E1:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 6;
							continue;
						}
						goto IL_A9;
						IL_127:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
						{
							goto IL_E1;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
						}
					}
					IL_F6:
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
					{
						goto IL_1A5;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
					{
						num = 5;
						continue;
					}
					goto IL_178;
					goto IL_F6;
				}
				IL_7D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_A9:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 - ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_14C:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_178:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_1A5:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A65 RID: 2661 RVA: 0x00052600 File Offset: 0x00050800
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC SBRuqvWNJH(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_192;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							goto IL_54;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 4;
							continue;
						}
						goto IL_145;
					case 4:
						goto IL_119;
					case 5:
						goto IL_61;
					case 6:
						goto IL_54;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_8D;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_192:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 3;
						continue;
					}
					if (!\u0020.tXF8H2TS5Y())
					{
						goto IL_BA;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_54:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					goto IL_192;
				}
				IL_61:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT);
				IL_8D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.RekhP3Apm0 - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0));
				IL_BA:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_119:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT);
				IL_145:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0 - this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000A66 RID: 2662 RVA: 0x000527B4 File Offset: 0x000509B4
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC iHaqzsE4Kf(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_135;
						case 1:
							goto IL_D6;
						case 2:
							\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
							break;
						case 3:
							if (\u0020.TB5dFM9QIv())
							{
								goto Block_4;
							}
							break;
						case 4:
							goto IL_17C;
						case 5:
							goto IL_54;
						case 6:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
							{
								num2 = 5;
								continue;
							}
							goto IL_80;
						default:
							goto IL_135;
						}
						if (\u0020.jZ28mHocbm())
						{
							num2 = 6;
							continue;
						}
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							num2 = 4;
							continue;
						}
						IL_135:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_102;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 1;
						}
					}
					Block_4:
					num = 2;
				}
				IL_54:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT - ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT));
				IL_80:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 - ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0)));
				IL_D6:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT));
				IL_102:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0)));
				IL_17C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A67 RID: 2663 RVA: 0x0005295C File Offset: 0x00050B5C
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC TEDudmFiUo(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_C3;
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						break;
					case 3:
						goto IL_12D;
					case 4:
						if (IntPtr.Size != 8)
						{
							goto IL_159;
						}
						num2 = 3;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 5:
						goto IL_E5;
					case 6:
						goto IL_F8;
					default:
						goto IL_C3;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					else
					{
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							num2 = 5;
							continue;
						}
						goto IL_F8;
					}
					IL_C3:
					\u0020 = \u0020.s9Cd9Og84k();
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
					{
						num2 = 1;
					}
				}
				IL_E5:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_F8:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT - this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT));
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.RekhP3Apm0 - this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0)));
				IL_12D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT - this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT));
				IL_159:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0 - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0)));
			}

			// Token: 0x06000A68 RID: 2664 RVA: 0x00052B24 File Offset: 0x00050D24
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC auGdW5LU1o(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
						num2 = 5;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						if (IntPtr.Size != 8)
						{
							goto IL_85;
						}
						num2 = 4;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_151;
					case 4:
						goto IL_5D;
					case 5:
						break;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 1;
						}
					}
					else
					{
						if (!\u0020.tXF8H2TS5Y())
						{
							goto IL_1AA;
						}
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_17D;
						}
						num2 = 3;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
						}
					}
				}
				IL_5D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr - unchecked((ulong)((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7)));
				IL_85:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 - ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7))));
				IL_151:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr));
				IL_17D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(checked(this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7)));
				IL_1AA:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A69 RID: 2665 RVA: 0x00052CE0 File Offset: 0x00050EE0
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC o7wuohgjfY(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 6;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 4;
							continue;
						}
						goto IL_E9;
					case 2:
						IL_9C:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_171;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_126;
					case 4:
						goto IL_C1;
					case 5:
						goto IL_62;
					case 6:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 5;
							continue;
						}
						goto IL_1A4;
					case 7:
						goto IL_1A4;
					}
					break;
					IL_62:
					if (\u0020.jZ28mHocbm())
					{
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					else
					{
						if (!\u0020.tXF8H2TS5Y())
						{
							num2 = 3;
							continue;
						}
						goto IL_9C;
					}
					IL_1A4:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_62;
				}
				goto IL_145;
				IL_C1:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(unchecked((ulong)((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7) - this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr));
				IL_E9:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(checked(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7 - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7))));
				IL_126:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_145:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr - this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr));
				IL_171:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(checked(((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.Vavhb40As7 - ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7)));
			}

			// Token: 0x06000A6A RID: 2666 RVA: 0x00052EB4 File Offset: 0x000510B4
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cT0dPKbnSa(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						goto IL_139;
					case 2:
						if (!\u0020.TB5dFM9QIv())
						{
							goto IL_139;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						if (\u0020.tXF8H2TS5Y())
						{
							num2 = 5;
							continue;
						}
						goto IL_133;
					case 4:
						goto IL_71;
					case 5:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_106;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						IL_16D:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_9D;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					break;
					IL_139:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						goto IL_16D;
					}
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 3;
					}
				}
				goto IL_DA;
				IL_71:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT * ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_9D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 * ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_DA:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT * ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT);
				IL_106:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 * ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_133:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A6B RID: 2667 RVA: 0x00053078 File Offset: 0x00051278
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC C3mdEhLvXd(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_7B;
					case 1:
						goto IL_8B;
					case 2:
						goto IL_16E;
					case 3:
						goto IL_7B;
					case 4:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 3;
							continue;
						}
						goto IL_137;
					case 5:
						break;
					case 6:
						goto IL_137;
					case 7:
						goto IL_F4;
					case 8:
						goto IL_6C;
					default:
						goto IL_7B;
					}
					IL_47:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_B7;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_F4:
					if (IntPtr.Size == 8)
					{
						num2 = 2;
						continue;
					}
					goto IL_19A;
					IL_137:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_7B:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						goto IL_47;
					}
					if (\u0020.tXF8H2TS5Y())
					{
						goto IL_F4;
					}
					num2 = 8;
				}
				IL_6C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_8B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT * ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT));
				IL_B7:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 * ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0)));
				IL_16E:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT * ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT));
				IL_19A:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(checked(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 * ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.RekhP3Apm0)));
			}

			// Token: 0x06000A6C RID: 2668 RVA: 0x00053254 File Offset: 0x00051454
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC jaYdc2eCJF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
							{
								num2 = 6;
								continue;
							}
							goto IL_B2;
						case 2:
							goto IL_142;
						case 3:
							\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							if (\u0020.TB5dFM9QIv())
							{
								num2 = 3;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
								{
									num2 = 1;
									continue;
								}
								continue;
							}
							break;
						case 5:
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
							{
								goto IL_DF;
							}
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 1;
								continue;
							}
							continue;
						case 6:
							goto IL_86;
						}
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
						{
							break;
						}
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_16A;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 2;
						}
					}
					num = 5;
				}
				IL_86:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr * ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr));
				IL_B2:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 * ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7)));
				IL_DF:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_142:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(checked(this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr * unchecked((ulong)((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7)));
				IL_16A:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(checked(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 * ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7))));
			}

			// Token: 0x06000A6D RID: 2669 RVA: 0x00053418 File Offset: 0x00051618
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC XIyd5fI2tA(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 6;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_15C;
						case 1:
							goto IL_C4;
						case 2:
							if (!\u0020.tXF8H2TS5Y())
							{
								goto Block_3;
							}
							goto IL_19A;
						case 3:
							break;
						case 4:
							goto IL_19A;
						case 5:
							\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 0;
								continue;
							}
							continue;
						case 6:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
							{
								goto Block_8;
							}
							goto IL_15C;
						case 7:
							goto IL_43;
						default:
							goto IL_15C;
						}
						IL_128:
						if (IntPtr.Size != 8)
						{
							goto IL_F0;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
						IL_15C:
						if (\u0020.jZ28mHocbm())
						{
							goto IL_128;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_19A:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_6F;
						}
						num2 = 7;
					}
					Block_8:
					num = 5;
				}
				IL_43:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_6F:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_C4:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_F0:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 / ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				Block_3:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A6E RID: 2670 RVA: 0x000535F4 File Offset: 0x000517F4
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC SNxu3GrT0Y(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_15A;
					case 1:
						\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
						num2 = 3;
						continue;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 4:
						goto IL_FB;
					case 5:
						goto IL_EB;
					default:
						goto IL_15A;
					}
					if (\u0020.jZ28mHocbm())
					{
						num2 = 5;
						continue;
					}
					if (!\u0020.tXF8H2TS5Y())
					{
						goto IL_154;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_15A:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_127;
					}
					num2 = 4;
				}
				IL_EB:
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0 / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0));
				IL_FB:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT);
				IL_127:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0 / this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0));
				IL_154:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A6F RID: 2671 RVA: 0x00053784 File Offset: 0x00051984
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Ut1dxA1rQp(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_76;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 3;
							continue;
						}
						goto IL_101;
					case 3:
						goto IL_D5;
					case 5:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 4;
							continue;
						}
						\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_A2;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					if (\u0020.jZ28mHocbm())
					{
						num2 = 2;
					}
					else
					{
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							goto IL_CF;
						}
						num2 = 5;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 6;
						}
					}
				}
				IL_76:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_A2:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7));
				IL_CF:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_D5:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_101:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 / ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7)));
			}

			// Token: 0x06000A70 RID: 2672 RVA: 0x00053938 File Offset: 0x00051B38
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s13uQY31x9(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_47;
				}
				goto IL_F4;
				int num;
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						goto IL_13B;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_167;
						}
						num = 1;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num = 5;
							continue;
						}
						goto IL_A8;
					case 4:
						goto IL_F4;
					case 5:
						goto IL_7C;
					}
					break;
				}
				goto IL_47;
				IL_7C:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_A8:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7 / this.eoUqScGyAS().aYsh65bDic.Vavhb40As7)));
				IL_13B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr / ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_167:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.Vavhb40As7 / this.eoUqScGyAS().aYsh65bDic.Vavhb40As7));
				IL_47:
				if (\u0020.jZ28mHocbm())
				{
					num = 3;
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num = 2;
						goto IL_10;
					}
					goto IL_10;
				}
				else
				{
					if (\u0020.tXF8H2TS5Y())
					{
						num = 2;
						goto IL_10;
					}
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_F4:
				\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
				num = 0;
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
				{
					num = 0;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000A71 RID: 2673 RVA: 0x00053AE0 File Offset: 0x00051CE0
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC yCeduJ3YIo(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_D4;
						case 2:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
							{
								\u0020 = \u0020.s9Cd9Og84k();
								num2 = 6;
								continue;
							}
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 1;
								continue;
							}
							continue;
						case 3:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
							{
								num2 = 5;
								continue;
							}
							goto IL_193;
						case 4:
							goto IL_5C;
						case 5:
							if (IntPtr.Size != 8)
							{
								goto IL_166;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 6:
							goto IL_D4;
						case 7:
							goto IL_43;
						}
						goto Block_1;
						IL_D4:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
						{
							break;
						}
						num2 = 3;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 0;
						}
					}
					IL_43:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_88;
					}
					num = 4;
				}
				Block_1:
				goto IL_13A;
				IL_5C:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_88:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 % ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_13A:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_166:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 % ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.RekhP3Apm0));
				IL_193:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A72 RID: 2674 RVA: 0x00053CAC File Offset: 0x00051EAC
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC bfduCGLdOq(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							\u0020 = \u0020.s9Cd9Og84k();
							num2 = 5;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 6;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_AB;
					case 3:
						goto IL_71;
					case 4:
						goto IL_151;
					case 5:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_D7;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 7:
						if (\u0020.tXF8H2TS5Y())
						{
							num2 = 5;
							continue;
						}
						goto IL_104;
					}
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 7;
						continue;
					}
					IL_71:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_17D;
					}
					num2 = 4;
				}
				IL_AB:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT % this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT);
				IL_D7:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0 % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0));
				IL_104:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_151:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT);
				IL_17D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0 % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000A73 RID: 2675 RVA: 0x00053E74 File Offset: 0x00052074
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC O5ndVV1NCh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EB;
					case 1:
						goto IL_10D;
					case 2:
						goto IL_43;
					case 3:
						break;
					case 4:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 3;
							continue;
						}
						goto IL_EB;
					case 5:
						goto IL_77;
					case 6:
						if (IntPtr.Size != 8)
						{
							goto IL_139;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 7:
						IL_D6:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 5;
							continue;
						}
						goto IL_A3;
					default:
						goto IL_EB;
					}
					IL_186:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 6;
						continue;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
					{
						goto IL_D6;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_EB:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					goto IL_186;
				}
				IL_43:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_77:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_A3:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 % ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.Vavhb40As7));
				IL_10D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_139:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 % ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7)));
			}

			// Token: 0x06000A74 RID: 2676 RVA: 0x0005403C File Offset: 0x0005223C
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC nU0u9SaqhH(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_DA;
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						break;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 3:
						goto IL_104;
					case 4:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 5;
							continue;
						}
						goto IL_6B;
					case 5:
						goto IL_3F;
					case 6:
						goto IL_148;
					default:
						goto IL_DA;
					}
					if (\u0020.jZ28mHocbm())
					{
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					else if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
					{
						num2 = 3;
						continue;
					}
					IL_DA:
					if (IntPtr.Size != 8)
					{
						goto IL_174;
					}
					num2 = 6;
				}
				IL_3F:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr);
				IL_6B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7 % this.eoUqScGyAS().aYsh65bDic.Vavhb40As7)));
				IL_104:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_148:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr % this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr);
				IL_174:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7 % ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7));
			}

			// Token: 0x06000A75 RID: 2677 RVA: 0x000541F0 File Offset: 0x000523F0
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC DyOdyCLR3X(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_176;
					case 2:
						goto IL_176;
					case 3:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 2;
							continue;
						}
						goto IL_12F;
					case 4:
						goto IL_12F;
					case 5:
						goto IL_43;
					case 6:
						goto IL_151;
					case 7:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 5;
							continue;
						}
						goto IL_6F;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
					{
						num2 = 7;
						continue;
					}
					goto IL_9C;
					IL_12F:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_176:
					if (\u0020.jZ28mHocbm())
					{
						goto IL_151;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num2 = 0;
					}
				}
				IL_43:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT & ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_6F:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 & ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_9C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_151:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT & ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 & ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000A76 RID: 2678 RVA: 0x000543A8 File Offset: 0x000525A8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC dH3d8VFM3E(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_61;
					case 2:
						goto IL_14E;
					case 3:
						goto IL_160;
					case 4:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 3;
							continue;
						}
						goto IL_14E;
					case 5:
						goto IL_160;
					case 6:
						goto IL_185;
					case 7:
						goto IL_43;
					}
					break;
					IL_160:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							num2 = 7;
							continue;
						}
						goto IL_185;
					}
					IL_14E:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					num2 = 5;
					continue;
					IL_185:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_8D;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
					{
						num2 = 0;
					}
				}
				goto IL_D5;
				IL_43:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_61:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT | ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_8D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 | ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_D5:
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT | ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 | ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000A77 RID: 2679 RVA: 0x00054560 File Offset: 0x00052760
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Rw9dqatOP5()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(~ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(~(long)ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000A78 RID: 2680 RVA: 0x000545B8 File Offset: 0x000527B8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC lBXdd758He(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 7;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_F5;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_17D;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_12F;
					case 4:
						goto IL_43;
					case 5:
						goto IL_11A;
					case 6:
						goto IL_F5;
					case 7:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 6;
							continue;
						}
						goto IL_12F;
					}
					break;
					IL_F5:
					if (\u0020.jZ28mHocbm())
					{
						num2 = 2;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 2;
							continue;
						}
						continue;
					}
					else if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
					{
						goto Block_8;
					}
					IL_11A:
					if (IntPtr.Size == 8)
					{
						num2 = 4;
						continue;
					}
					goto IL_6F;
					IL_12F:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					num2 = 1;
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num2 = 1;
					}
				}
				goto IL_151;
				IL_43:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT ^ ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT);
				IL_6F:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 ^ ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_151:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT ^ ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT);
				IL_17D:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 ^ ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				Block_8:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A79 RID: 2681 RVA: 0x00054790 File Offset: 0x00052990
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC L5SdoEFytK(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_BA;
				}
				goto IL_109;
				int num;
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						goto IL_BA;
					case 2:
						goto IL_109;
					case 3:
						goto IL_DF;
					case 4:
						goto IL_36;
					case 5:
						goto IL_12B;
					case 6:
						goto IL_AB;
					}
					if (IntPtr.Size != 8)
					{
						goto IL_155;
					}
					num = 5;
				}
				IL_36:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT << ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.HDmhqUiRl0);
				IL_AB:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_12B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT << ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_155:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((long)ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 << ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
				IL_BA:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
				{
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
				else if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
				{
					num = 6;
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
				IL_DF:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					num = 4;
					goto IL_10;
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((long)this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 << ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.RekhP3Apm0));
				IL_109:
				\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
				num = 0;
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x00054950 File Offset: 0x00052B50
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC f17d3EnLUZ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_32;
				}
				\u0020 = \u0020.s9Cd9Og84k();
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
				{
					num = 0;
				}
				for (;;)
				{
					IL_10:
					switch (num)
					{
					default:
						goto IL_32;
					case 1:
						goto IL_13C;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_16B;
						}
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num = 1;
						}
						break;
					case 3:
						if (!\u0020.tXF8H2TS5Y())
						{
							goto IL_19B;
						}
						num = 2;
						break;
					case 4:
						goto IL_5C;
					case 5:
						goto IL_47;
					}
				}
				IL_5C:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT >> ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				IL_13C:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT >> ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.HDmhqUiRl0);
				IL_16B:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 >> ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.RekhP3Apm0));
				IL_19B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_32:
				if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
				{
					num = 3;
					goto IL_10;
				}
				IL_47:
				if (IntPtr.Size == 8)
				{
					num = 4;
					goto IL_10;
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 >> ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0));
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x00054B00 File Offset: 0x00052D00
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC V36dQSy6F7(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_17C;
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							num2 = 8;
							continue;
						}
						goto IL_17C;
					case 2:
						break;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							goto IL_E6;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						goto IL_117;
					case 5:
						goto IL_D6;
					case 6:
						break;
					case 7:
						goto IL_E6;
					case 8:
						goto IL_191;
					default:
						goto IL_17C;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						break;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_E6:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					num2 = 3;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num2 = 6;
						continue;
					}
					continue;
					IL_17C:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_146;
					}
					num2 = 4;
				}
				IL_D6:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr >> ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 >> ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0)));
				IL_117:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr >> ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.HDmhqUiRl0);
				IL_146:
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 >> ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0)));
				IL_191:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A7C RID: 2684 RVA: 0x00054CF0 File Offset: 0x00052EF0
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC wY1uwVtTmF(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F \u0020)
			{
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((ulong)(\u0020.aYsh65bDic.Vavhb40As7 >> ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0)));
			}

			// Token: 0x06000A7D RID: 2685 RVA: 0x00054D20 File Offset: 0x00052F20
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC h37uAB0IKX(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F \u0020)
			{
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)(\u0020.aYsh65bDic.RekhP3Apm0 >> this.JWZqiAqFR8().OluhFK2lXQ.HDmhqUiRl0));
			}

			// Token: 0x06000A7E RID: 2686 RVA: 0x00054D50 File Offset: 0x00052F50
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC chhuhxJxVf(ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F \u0020)
			{
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)((long)\u0020.aYsh65bDic.RekhP3Apm0 << ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.HDmhqUiRl0));
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x00054D80 File Offset: 0x00052F80
			public override string ToString()
			{
				return this.WytiIREvTV.ToString();
			}

			// Token: 0x06000A80 RID: 2688 RVA: 0x00054D94 File Offset: 0x00052F94
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				return this;
			}

			// Token: 0x06000A81 RID: 2689 RVA: 0x00054DA0 File Offset: 0x00052FA0
			internal override bool y9QdwWY3Xc()
			{
				return true;
			}

			// Token: 0x06000A82 RID: 2690 RVA: 0x00054DAC File Offset: 0x00052FAC
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
						switch (num2)
						{
						case 0:
							goto IL_CF;
						case 1:
							goto IL_14C;
						case 2:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
							{
								num2 = 5;
								continue;
							}
							x0cbwj80qtx55Tsu8UC = \u0020.s9Cd9Og84k();
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.bLM2yekpwkL7HFGgJrV(x0cbwj80qtx55Tsu8UC))
							{
								num2 = 1;
								if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
								{
									num2 = 4;
									continue;
								}
								continue;
							}
							break;
						case 3:
							goto IL_178;
						case 4:
							return false;
						case 5:
							goto IL_19B;
						case 6:
							if (IntPtr.Size == 8)
							{
								num2 = 8;
								continue;
							}
							goto IL_86;
						case 7:
							break;
						case 8:
							goto IL_5E;
						default:
							goto IL_CF;
						}
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(x0cbwj80qtx55Tsu8UC))
						{
							num2 = 6;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						else
						{
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(x0cbwj80qtx55Tsu8UC))
							{
								return false;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						IL_CF:
						ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH();
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
						}
					}
					IL_178:
					if (\u0020.MEy8J5BANA())
					{
						break;
					}
					num = 2;
				}
				return false;
				IL_5E:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT == ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_86:
				return this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 == ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
				IL_14C:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT == ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_19B:
				return ((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020).ovDdASrPUT(this);
			}

			// Token: 0x06000A83 RID: 2691 RVA: 0x00054F84 File Offset: 0x00053184
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 7;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_194;
					case 2:
					{
						ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
						if (!x0cbwj80qtx55Tsu8UC.tXF8H2TS5Y())
						{
							return false;
						}
						num2 = 9;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					case 3:
						goto IL_4B;
					case 4:
						return false;
					case 5:
					{
						ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
						if (!x0cbwj80qtx55Tsu8UC.y9QdwWY3Xc())
						{
							return false;
						}
						if (!x0cbwj80qtx55Tsu8UC.jZ28mHocbm())
						{
							num2 = 2;
							continue;
						}
						goto IL_4B;
					}
					case 6:
					{
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							goto IL_194;
						}
						ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					case 7:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.YBWImQk4sifEOg7YY3e(\u0020))
						{
							num2 = 6;
							continue;
						}
						return false;
					case 8:
						goto IL_10C;
					case 9:
						ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH();
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
					IL_4B:
					if (IntPtr.Size != 8)
					{
						goto IL_137;
					}
					num2 = 8;
				}
				goto IL_1C3;
				IL_10C:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr != ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_137:
				return this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 != ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
				IL_194:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.FwThNtkOpK0JLWcrpr9((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
				IL_1C3:
				return this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr != ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
			}

			// Token: 0x06000A84 RID: 2692 RVA: 0x00055184 File Offset: 0x00053384
			public override bool SqWdSNFM0N(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					goto IL_AF;
				}
				\u0020 = \u0020.s9Cd9Og84k();
				int num = 4;
				for (;;)
				{
					IL_10:
					switch (num)
					{
					default:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_118;
						}
						num = 2;
						break;
					case 1:
					{
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_6E;
						}
						int num2 = 3;
						num = num2;
						break;
					}
					case 2:
						goto IL_ED;
					case 3:
						goto IL_43;
					case 4:
						goto IL_AF;
					}
				}
				IL_43:
				return this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT >= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_6E:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 >= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0;
				IL_ED:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT >= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_118:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 >= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
				IL_AF:
				if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
				{
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
				else
				{
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
					{
						throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
					}
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num = 1;
						goto IL_10;
					}
					goto IL_10;
				}
			}

			// Token: 0x06000A85 RID: 2693 RVA: 0x00055308 File Offset: 0x00053508
			public override bool DSNdIxSMBQ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
							goto IL_BF;
						case 2:
							goto IL_196;
						case 3:
							goto IL_87;
						case 4:
							if (IntPtr.Size != 8)
							{
								goto IL_165;
							}
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 0;
								continue;
							}
							continue;
						case 5:
							goto IL_87;
						case 6:
							if (!\u0020.TB5dFM9QIv())
							{
								goto Block_5;
							}
							goto IL_196;
						case 7:
							goto IL_D4;
						}
						goto Block_1;
						IL_BF:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
						{
							num2 = 7;
							continue;
						}
						goto IL_FF;
						IL_87:
						if (\u0020.jZ28mHocbm())
						{
							goto IL_BF;
						}
						if (\u0020.tXF8H2TS5Y())
						{
							num2 = 4;
							continue;
						}
						goto IL_190;
						IL_196:
						\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
						num2 = 3;
					}
					Block_5:
					num = 5;
				}
				Block_1:
				goto IL_13A;
				IL_D4:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr >= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr;
				IL_FF:
				return this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 >= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
				IL_13A:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr >= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_165:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 >= ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.Vavhb40As7;
				IL_190:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A86 RID: 2694 RVA: 0x000554BC File Offset: 0x000536BC
			public override bool DoCdicvJaP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 5;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_17F;
					case 1:
						break;
					case 2:
						goto IL_1A3;
					case 3:
						goto IL_B9;
					case 4:
						break;
					case 5:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 4;
								continue;
							}
							continue;
						}
						else
						{
							\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 6:
						goto IL_10F;
					case 7:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							goto IL_109;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					default:
						goto IL_17F;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						goto IL_1A3;
					}
					num2 = 7;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num2 = 7;
						continue;
					}
					continue;
					IL_17F:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() == 8)
					{
						num2 = 3;
						continue;
					}
					goto IL_E1;
					IL_1A3:
					if (IntPtr.Size != 8)
					{
						goto IL_137;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num2 = 6;
					}
				}
				IL_B9:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT > ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT;
				IL_E1:
				return this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 > ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).eoUqScGyAS().aYsh65bDic.RekhP3Apm0;
				IL_109:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_10F:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT > ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_137:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 > ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
			}

			// Token: 0x06000A87 RID: 2695 RVA: 0x00055690 File Offset: 0x00053890
			public override bool IJkdZ22aVF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_43;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							goto IL_1B6;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
						{
							num2 = 7;
							continue;
						}
						goto IL_102;
					case 4:
						goto IL_1B6;
					case 5:
						goto IL_108;
					case 6:
						goto IL_43;
					case 7:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_DA;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
					IL_43:
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					else
					{
						if (IntPtr.Size != 8)
						{
							goto IL_130;
						}
						num2 = 3;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					IL_1B6:
					\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
					num2 = 6;
				}
				return this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr > ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_DA:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 > ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7;
				IL_102:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_108:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr > ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_130:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 > ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
			}

			// Token: 0x06000A88 RID: 2696 RVA: 0x00055864 File Offset: 0x00053A64
			public override bool VdHdUonKxI(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
							goto IL_9C;
						case 2:
							goto IL_7D;
						case 3:
							goto IL_4F;
						case 4:
							goto IL_3F;
						case 5:
							\u0020 = \u0020.s9Cd9Og84k();
							num2 = 3;
							continue;
						case 6:
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
							{
								num2 = 5;
								continue;
							}
							goto IL_4F;
						}
						IL_F8:
						if (IntPtr.Size != 8)
						{
							goto IL_C7;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
						IL_4F:
						if (\u0020.jZ28mHocbm())
						{
							break;
						}
						if (\u0020.tXF8H2TS5Y())
						{
							goto IL_F8;
						}
						num2 = 2;
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
						{
							num2 = 1;
						}
					}
					num = 4;
				}
				IL_3F:
				if (IntPtr.Size == 8)
				{
					return this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT <= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT;
				}
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 <= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
				IL_7D:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_9C:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.Y3Why5AObT <= ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT;
				IL_C7:
				return this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 <= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0;
			}

			// Token: 0x06000A89 RID: 2697 RVA: 0x00055A18 File Offset: 0x00053C18
			public override bool sxQd1txC3H(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_182;
					case 2:
						goto IL_1A0;
					case 3:
						goto IL_6C;
					case 4:
						if (\u0020.TB5dFM9QIv())
						{
							goto IL_1A0;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 5:
						goto IL_47;
					case 6:
						goto IL_7C;
					case 7:
						goto IL_15D;
					case 8:
						goto IL_6C;
					}
					break;
					IL_47:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_11D;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_15D:
					if (IntPtr.Size != 8)
					{
						goto IL_A7;
					}
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 6;
						continue;
					}
					continue;
					IL_6C:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						goto IL_15D;
					}
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.QSXl00eN1WHGddjgvtN(\u0020))
					{
						goto IL_47;
					}
					num2 = 1;
					if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_1A0:
					\u0020 = \u0020.s9Cd9Og84k();
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
					{
						num2 = 8;
					}
				}
				goto IL_F2;
				IL_7C:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr <= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_A7:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 <= ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
				IL_F2:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr <= ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr;
				IL_11D:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 <= ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7;
				IL_182:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000A8A RID: 2698 RVA: 0x00055C0C File Offset: 0x00053E0C
			public override bool WY8dpeljbh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1BE;
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							\u0020 = \u0020.s9Cd9Og84k();
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.iDZiJNe2vkoR17Q8qAv())
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_E6;
					case 3:
						goto IL_D1;
					case 4:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_10E;
						}
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						goto IL_43;
					case 6:
						break;
					case 7:
						goto IL_146;
					default:
						goto IL_1BE;
					}
					IL_AC:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
					{
						goto IL_16E;
					}
					num2 = 7;
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() != null)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_D1:
					if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.pv34Lak1gsNrJU17V2B(\u0020))
					{
						num2 = 4;
						continue;
					}
					if (!\u0020.tXF8H2TS5Y())
					{
						num2 = 5;
						continue;
					}
					goto IL_AC;
					IL_1BE:
					goto IL_D1;
				}
				IL_43:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_E6:
				return this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT < ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_10E:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.RekhP3Apm0 < ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.RekhP3Apm0;
				IL_146:
				return this.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT < ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.Y3Why5AObT;
				IL_16E:
				return this.eoUqScGyAS().aYsh65bDic.RekhP3Apm0 < ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.RekhP3Apm0;
			}

			// Token: 0x06000A8B RID: 2699 RVA: 0x00055DE0 File Offset: 0x00053FE0
			public override bool Fqpd4WZY4A(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 6;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_13F;
					case 1:
						goto IL_54;
					case 2:
						goto IL_AF;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.eVgHkQenW7el3VlK9GH() != 8)
						{
							goto IL_7C;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						break;
					case 5:
						\u0020 = ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.VdbkfZkUDW5uWVDJaLe(\u0020);
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.y00YC4e6uDx1h2DQe2P() == null)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.TruILKkZ5gm3fkydW5H(\u0020))
						{
							num2 = 5;
							continue;
						}
						break;
					default:
						goto IL_13F;
					}
					if (\u0020.jZ28mHocbm())
					{
						num2 = 3;
						continue;
					}
					if (!\u0020.tXF8H2TS5Y())
					{
						goto Block_3;
					}
					IL_13F:
					if (IntPtr.Size != 8)
					{
						goto IL_D7;
					}
					num2 = 2;
				}
				IL_54:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7(this).OluhFK2lXQ.SL4hxlZ2Vr < ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_7C:
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s(this).aYsh65bDic.Vavhb40As7 < ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).aYsh65bDic.Vavhb40As7;
				Block_3:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_AF:
				return this.JWZqiAqFR8().OluhFK2lXQ.SL4hxlZ2Vr < ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.jQ12C8kPQaRI1R2vRw7((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).OluhFK2lXQ.SL4hxlZ2Vr;
				IL_D7:
				return this.eoUqScGyAS().aYsh65bDic.Vavhb40As7 < ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.RntIV2ev3E3u19IL42s((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).aYsh65bDic.Vavhb40As7;
			}

			// Token: 0x06000A8C RID: 2700 RVA: 0x00055F84 File Offset: 0x00054184
			// Note: this type is marked as 'beforefieldinit'.
			static vILrVAuVmjGxVilaUfb()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x06000A8D RID: 2701 RVA: 0x00055F94 File Offset: 0x00054194
			internal static bool QSXl00eN1WHGddjgvtN(object A_0)
			{
				return A_0.tXF8H2TS5Y();
			}

			// Token: 0x06000A8E RID: 2702 RVA: 0x00055FA8 File Offset: 0x000541A8
			internal static bool iDZiJNe2vkoR17Q8qAv()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.vfm2fUe75VHyhWtmA4B == null;
			}

			// Token: 0x06000A8F RID: 2703 RVA: 0x00055FBC File Offset: 0x000541BC
			internal static ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb y00YC4e6uDx1h2DQe2P()
			{
				return ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb.vfm2fUe75VHyhWtmA4B;
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x00055FCC File Offset: 0x000541CC
			internal static int eVgHkQenW7el3VlK9GH()
			{
				return IntPtr.Size;
			}

			// Token: 0x06000A91 RID: 2705 RVA: 0x00055FDC File Offset: 0x000541DC
			internal static object tTHe9fe0xHUdtaLg1T1(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000A92 RID: 2706 RVA: 0x00055FF4 File Offset: 0x000541F4
			internal static RuntimeTypeHandle rW370teJ3mHAJRvSPeU(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000A93 RID: 2707 RVA: 0x00056008 File Offset: 0x00054208
			internal static bool FQ13wwemUJ4SwBD8WoE(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000A94 RID: 2708 RVA: 0x00056020 File Offset: 0x00054220
			internal static Type EBgK4leHNLEfKEjtffs(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000A95 RID: 2709 RVA: 0x00056034 File Offset: 0x00054234
			internal static void vuR8Nfetw95X4IuT9oW(object A_0, object A_1)
			{
				A_0.AxwqVJ6XV5(A_1);
			}

			// Token: 0x06000A96 RID: 2710 RVA: 0x0005604C File Offset: 0x0005424C
			internal static void jxW2jheY15Ueucs75Ee()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000A97 RID: 2711 RVA: 0x0005605C File Offset: 0x0005425C
			internal static void as7lDlesigEDf3nsQy5()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000A98 RID: 2712 RVA: 0x0005606C File Offset: 0x0005426C
			internal static object mDKY0Yeg5acPLJYlv2k(object A_0)
			{
				return A_0.AxLq8nl88V();
			}

			// Token: 0x06000A99 RID: 2713 RVA: 0x00056080 File Offset: 0x00054280
			internal static bool hAdL0geXhtVc2FJFMgL(object A_0)
			{
				return A_0.WuHqq9Wdbv();
			}

			// Token: 0x06000A9A RID: 2714 RVA: 0x00056094 File Offset: 0x00054294
			internal static object Ocy3MqeM8rlpAHGkkft(object A_0)
			{
				return A_0.NtxqQI1Zcd();
			}

			// Token: 0x06000A9B RID: 2715 RVA: 0x000560A8 File Offset: 0x000542A8
			internal static object HbP0CseGDUtC4Nqeyuk(object A_0)
			{
				return A_0.kZFq9GpslU();
			}

			// Token: 0x06000A9C RID: 2716 RVA: 0x000560BC File Offset: 0x000542BC
			internal static object HtRehKeB1qLcf5XSF9O(object A_0)
			{
				return A_0.Br0qAy7jU5();
			}

			// Token: 0x06000A9D RID: 2717 RVA: 0x000560D0 File Offset: 0x000542D0
			internal static object LRoZYOeDnfCZrh4BRTN(object A_0)
			{
				return A_0.QtGqh2NDQ8();
			}

			// Token: 0x06000A9E RID: 2718 RVA: 0x000560E4 File Offset: 0x000542E4
			internal static object RntIV2ev3E3u19IL42s(object A_0)
			{
				return A_0.eoUqScGyAS();
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x000560F8 File Offset: 0x000542F8
			internal static object R4aj5RejPgcLR2GBsjY(object A_0)
			{
				return A_0.U0ZqI72BOj();
			}

			// Token: 0x06000AA0 RID: 2720 RVA: 0x0005610C File Offset: 0x0005430C
			internal static object mfsi3Meb3tTTWOJhBku(object A_0)
			{
				return A_0.upCqZP4jJd();
			}

			// Token: 0x06000AA1 RID: 2721 RVA: 0x00056120 File Offset: 0x00054320
			internal static bool u9UKxWezChloYTcoFZN(Type A_0, Type A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000AA2 RID: 2722 RVA: 0x00056138 File Offset: 0x00054338
			internal static object dKTqOokWF5q5ePDEbTa(object A_0)
			{
				return A_0.PQEqwQ01dQ();
			}

			// Token: 0x06000AA3 RID: 2723 RVA: 0x0005614C File Offset: 0x0005434C
			internal static object jQ12C8kPQaRI1R2vRw7(object A_0)
			{
				return A_0.JWZqiAqFR8();
			}

			// Token: 0x06000AA4 RID: 2724 RVA: 0x00056160 File Offset: 0x00054360
			internal static object n7kbN3kEdBnp1n2jiTX(object A_0)
			{
				return A_0.ziwqR9N2wv();
			}

			// Token: 0x06000AA5 RID: 2725 RVA: 0x00056174 File Offset: 0x00054374
			internal static object rgahHukcL4UuDJyF0yS(object A_0)
			{
				return A_0.NN3qlXny0A();
			}

			// Token: 0x06000AA6 RID: 2726 RVA: 0x00056188 File Offset: 0x00054388
			internal static object Sd8PRYk514heRFRi0kW(object A_0)
			{
				return A_0.cMXqaCAZHq();
			}

			// Token: 0x06000AA7 RID: 2727 RVA: 0x0005619C File Offset: 0x0005439C
			internal static object laA4QOkxHvvvUXWyxPn(object A_0)
			{
				return A_0.Vy2qKYUMDe();
			}

			// Token: 0x06000AA8 RID: 2728 RVA: 0x000561B0 File Offset: 0x000543B0
			internal static object KCPBwukuOHaDOOBpOMe(object A_0)
			{
				return A_0.rMZqkTKtdW();
			}

			// Token: 0x06000AA9 RID: 2729 RVA: 0x000561C4 File Offset: 0x000543C4
			internal static object DHEmNgkViqfo5kSdmp7(object A_0)
			{
				return A_0.c1Bqr7stpA();
			}

			// Token: 0x06000AAA RID: 2730 RVA: 0x000561D8 File Offset: 0x000543D8
			internal static object V0JF7skydqKcLQ8nQ50(object A_0)
			{
				return A_0.lZtq7DP5OI();
			}

			// Token: 0x06000AAB RID: 2731 RVA: 0x000561EC File Offset: 0x000543EC
			internal static object l0tmOXk8MepiOVSdIJX(object A_0)
			{
				return A_0.eFOq2JXLOE();
			}

			// Token: 0x06000AAC RID: 2732 RVA: 0x00056200 File Offset: 0x00054400
			internal static object ykZIpnkqWluMqPAb0ig(object A_0)
			{
				return A_0.CVaq6fDwxc();
			}

			// Token: 0x06000AAD RID: 2733 RVA: 0x00056214 File Offset: 0x00054414
			internal static object wPjSjZkdawJdHohDfGA(object A_0)
			{
				return A_0.rvkqNso51v();
			}

			// Token: 0x06000AAE RID: 2734 RVA: 0x00056228 File Offset: 0x00054428
			internal static object bSVYxAkoNVvqfApJRmF(object A_0)
			{
				return A_0.Jefq04Qqj5();
			}

			// Token: 0x06000AAF RID: 2735 RVA: 0x0005623C File Offset: 0x0005443C
			internal static object N0oXAKk3tqNGOXQOgCv(object A_0)
			{
				return A_0.LYYqJD7UOL();
			}

			// Token: 0x06000AB0 RID: 2736 RVA: 0x00056250 File Offset: 0x00054450
			internal static object N482dwkQTcIxEcBihaU(object A_0)
			{
				return A_0.Msjqm6OQGU();
			}

			// Token: 0x06000AB1 RID: 2737 RVA: 0x00056264 File Offset: 0x00054464
			internal static object sWXtcTkCoRpfYj3sd1X(object A_0)
			{
				return A_0.qJhqHVUG8k();
			}

			// Token: 0x06000AB2 RID: 2738 RVA: 0x00056278 File Offset: 0x00054478
			internal static object OggDKnk9tyTXUDySghs(object A_0)
			{
				return A_0.c1GqttOeWQ();
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x0005628C File Offset: 0x0005448C
			internal static object S4rKQLkw7LMHPDkK0Sy(object A_0)
			{
				return A_0.FmZq4JYpT6();
			}

			// Token: 0x06000AB4 RID: 2740 RVA: 0x000562A0 File Offset: 0x000544A0
			internal static object zPJ1OQkAGEYmNAoAWUZ(object A_0)
			{
				return A_0.FOJqpHkit6();
			}

			// Token: 0x06000AB5 RID: 2741 RVA: 0x000562B4 File Offset: 0x000544B4
			internal static object eMJvnlkh6u3oBgXaOkq(object A_0)
			{
				return A_0.SZBqTRsZeT();
			}

			// Token: 0x06000AB6 RID: 2742 RVA: 0x000562C8 File Offset: 0x000544C8
			internal static object jG5eJ7kSRYMxsihSQn5(object A_0)
			{
				return A_0.oAjqFTEeFY();
			}

			// Token: 0x06000AB7 RID: 2743 RVA: 0x000562DC File Offset: 0x000544DC
			internal static object W9kGYwkIvBBb020b3T5(object A_0)
			{
				return A_0.RywqnVZSZT();
			}

			// Token: 0x06000AB8 RID: 2744 RVA: 0x000562F0 File Offset: 0x000544F0
			internal static object ixuiFBkiU9BVLYLep2G(object A_0)
			{
				return A_0.QmjqeL3I7g();
			}

			// Token: 0x06000AB9 RID: 2745 RVA: 0x00056304 File Offset: 0x00054504
			internal static bool TruILKkZ5gm3fkydW5H(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000ABA RID: 2746 RVA: 0x00056318 File Offset: 0x00054518
			internal static object VdbkfZkUDW5uWVDJaLe(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000ABB RID: 2747 RVA: 0x0005632C File Offset: 0x0005452C
			internal static bool pv34Lak1gsNrJU17V2B(object A_0)
			{
				return A_0.jZ28mHocbm();
			}

			// Token: 0x06000ABC RID: 2748 RVA: 0x00056340 File Offset: 0x00054540
			internal static bool bLM2yekpwkL7HFGgJrV(object A_0)
			{
				return A_0.y9QdwWY3Xc();
			}

			// Token: 0x06000ABD RID: 2749 RVA: 0x00056354 File Offset: 0x00054554
			internal static bool YBWImQk4sifEOg7YY3e(object A_0)
			{
				return A_0.MEy8J5BANA();
			}

			// Token: 0x06000ABE RID: 2750 RVA: 0x00056368 File Offset: 0x00054568
			internal static bool FwThNtkOpK0JLWcrpr9(object A_0, object A_1)
			{
				return A_0.g5sdhSCwCu(A_1);
			}

			// Token: 0x040003BF RID: 959
			public ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB WytiIREvTV;

			// Token: 0x040003C0 RID: 960
			public ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ Btdim12bl2;

			// Token: 0x040003C1 RID: 961
			internal static ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb vfm2fUe75VHyhWtmA4B;
		}

		// Token: 0x02000072 RID: 114
		private abstract class QmmmuQuSWS2kKwsrFfB : ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC
		{
			// Token: 0x06000ABF RID: 2751
			public abstract bool WuHqq9Wdbv();

			// Token: 0x06000AC0 RID: 2752
			public abstract bool icyqdm73mi();

			// Token: 0x06000AC1 RID: 2753
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Q1tqoFEFyp(ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020);

			// Token: 0x06000AC2 RID: 2754
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NtxqQI1Zcd();

			// Token: 0x06000AC3 RID: 2755
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F kZFq9GpslU();

			// Token: 0x06000AC4 RID: 2756
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F PQEqwQ01dQ();

			// Token: 0x06000AC5 RID: 2757
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Br0qAy7jU5();

			// Token: 0x06000AC6 RID: 2758
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QtGqh2NDQ8();

			// Token: 0x06000AC7 RID: 2759
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eoUqScGyAS();

			// Token: 0x06000AC8 RID: 2760
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F U0ZqI72BOj();

			// Token: 0x06000AC9 RID: 2761
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN JWZqiAqFR8();

			// Token: 0x06000ACA RID: 2762
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN upCqZP4jJd();

			// Token: 0x06000ACB RID: 2763
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lk5qURpdjk();

			// Token: 0x06000ACC RID: 2764
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F HK7q1PliPm();

			// Token: 0x06000ACD RID: 2765
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F FOJqpHkit6();

			// Token: 0x06000ACE RID: 2766
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN FmZq4JYpT6();

			// Token: 0x06000ACF RID: 2767
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F hYvqOWPpOC();

			// Token: 0x06000AD0 RID: 2768
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F o1ZqfYXchM();

			// Token: 0x06000AD1 RID: 2769
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F oAjqFTEeFY();

			// Token: 0x06000AD2 RID: 2770
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN SZBqTRsZeT();

			// Token: 0x06000AD3 RID: 2771
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F ziwqR9N2wv();

			// Token: 0x06000AD4 RID: 2772
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F j5lqLol41P();

			// Token: 0x06000AD5 RID: 2773
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NN3qlXny0A();

			// Token: 0x06000AD6 RID: 2774
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F cMXqaCAZHq();

			// Token: 0x06000AD7 RID: 2775
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Vy2qKYUMDe();

			// Token: 0x06000AD8 RID: 2776
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QmjqeL3I7g();

			// Token: 0x06000AD9 RID: 2777
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN rMZqkTKtdW();

			// Token: 0x06000ADA RID: 2778
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN c1Bqr7stpA();

			// Token: 0x06000ADB RID: 2779
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lZtq7DP5OI();

			// Token: 0x06000ADC RID: 2780
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eFOq2JXLOE();

			// Token: 0x06000ADD RID: 2781
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F CVaq6fDwxc();

			// Token: 0x06000ADE RID: 2782
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F rvkqNso51v();

			// Token: 0x06000ADF RID: 2783
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F RywqnVZSZT();

			// Token: 0x06000AE0 RID: 2784
			public abstract ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Jefq04Qqj5();

			// Token: 0x06000AE1 RID: 2785
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN LYYqJD7UOL();

			// Token: 0x06000AE2 RID: 2786
			public abstract ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN Msjqm6OQGU();

			// Token: 0x06000AE3 RID: 2787
			public abstract ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs qJhqHVUG8k();

			// Token: 0x06000AE4 RID: 2788
			public abstract ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs c1GqttOeWQ();

			// Token: 0x06000AE5 RID: 2789
			public abstract ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs HF1qYGZ8gN();

			// Token: 0x06000AE6 RID: 2790
			public abstract ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb yRRqsHbNK7();

			// Token: 0x06000AE7 RID: 2791
			public abstract ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb D1PqgOGTyj();

			// Token: 0x06000AE8 RID: 2792
			public abstract ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb XWcqXDk1Pt();

			// Token: 0x06000AE9 RID: 2793
			public abstract ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb JjkqMxqLaY();

			// Token: 0x06000AEA RID: 2794
			public abstract ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb APcqGbirjs();

			// Token: 0x06000AEB RID: 2795
			public abstract ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb CY1qBxKBHt();

			// Token: 0x06000AEC RID: 2796
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC CpmqDtDe45();

			// Token: 0x06000AED RID: 2797
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Add(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AEE RID: 2798
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC LfyqvMrNHx(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AEF RID: 2799
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC KrBqjlnYTv(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF0 RID: 2800
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cmUqbj78eE(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF1 RID: 2801
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC iHaqzsE4Kf(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF2 RID: 2802
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC auGdW5LU1o(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF3 RID: 2803
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cT0dPKbnSa(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF4 RID: 2804
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC C3mdEhLvXd(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF5 RID: 2805
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC jaYdc2eCJF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF6 RID: 2806
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC XIyd5fI2tA(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF7 RID: 2807
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Ut1dxA1rQp(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF8 RID: 2808
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC yCeduJ3YIo(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AF9 RID: 2809
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC O5ndVV1NCh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AFA RID: 2810
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC DyOdyCLR3X(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AFB RID: 2811
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC dH3d8VFM3E(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AFC RID: 2812
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Rw9dqatOP5();

			// Token: 0x06000AFD RID: 2813
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC lBXdd758He(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000AFE RID: 2814
			public abstract ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB AxLq8nl88V();

			// Token: 0x06000AFF RID: 2815
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC L5SdoEFytK(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B00 RID: 2816
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC f17d3EnLUZ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B01 RID: 2817
			public abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC V36dQSy6F7(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B02 RID: 2818
			public abstract bool SqWdSNFM0N(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B03 RID: 2819
			public abstract bool DSNdIxSMBQ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B04 RID: 2820
			public abstract bool DoCdicvJaP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B05 RID: 2821
			public abstract bool IJkdZ22aVF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B06 RID: 2822
			public abstract bool VdHdUonKxI(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B07 RID: 2823
			public abstract bool sxQd1txC3H(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B08 RID: 2824
			public abstract bool WY8dpeljbh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B09 RID: 2825
			public abstract bool Fqpd4WZY4A(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000B0A RID: 2826 RVA: 0x00056380 File Offset: 0x00054580
			internal override bool snedf8QbBG()
			{
				return true;
			}

			// Token: 0x06000B0B RID: 2827 RVA: 0x0005638C File Offset: 0x0005458C
			protected QmmmuQuSWS2kKwsrFfB()
			{
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB.OngYY3kR3rfwuRjQ7lO();
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB.JqlTjNkLiYtJtlQgmyH();
				base..ctor();
				int num = 0;
				if (!false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000B0C RID: 2828 RVA: 0x000563E8 File Offset: 0x000545E8
			// Note: this type is marked as 'beforefieldinit'.
			static QmmmuQuSWS2kKwsrFfB()
			{
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB.MSxEdVklq01nd7eXyC2();
			}

			// Token: 0x06000B0D RID: 2829 RVA: 0x000563F8 File Offset: 0x000545F8
			internal static void OngYY3kR3rfwuRjQ7lO()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000B0E RID: 2830 RVA: 0x00056408 File Offset: 0x00054608
			internal static void JqlTjNkLiYtJtlQgmyH()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000B0F RID: 2831 RVA: 0x00056418 File Offset: 0x00054618
			internal static bool f4m5NtkFm3SCl2N5T1A()
			{
				return ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB.SafGHwkfaybOJmhdPv2 == null;
			}

			// Token: 0x06000B10 RID: 2832 RVA: 0x0005642C File Offset: 0x0005462C
			internal static ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB Ut5TGYkTyHmib80XAGX()
			{
				return ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB.SafGHwkfaybOJmhdPv2;
			}

			// Token: 0x06000B11 RID: 2833 RVA: 0x0005643C File Offset: 0x0005463C
			internal static void MSxEdVklq01nd7eXyC2()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003C2 RID: 962
			private static ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB SafGHwkfaybOJmhdPv2;
		}

		// Token: 0x02000073 RID: 115
		private class oMK8iyuIab2LETlLsfs : ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB
		{
			// Token: 0x06000B12 RID: 2834 RVA: 0x0005644C File Offset: 0x0005464C
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.PvjigoKUew = ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
				this.tEYiYJ2qOF = ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).tEYiYJ2qOF;
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000B13 RID: 2835 RVA: 0x000564B8 File Offset: 0x000546B8
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.TWwfPvkkWp2yixaPHVB(this, \u0020);
			}

			// Token: 0x06000B14 RID: 2836 RVA: 0x000564D0 File Offset: 0x000546D0
			public oMK8iyuIab2LETlLsfs(double \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.AfUvQhkregmHwB6RMek();
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.EmvnUnk7J0M1kx57Ifq();
				base..ctor();
				int num = 0;
				if (!true)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)5;
						num = 3;
						break;
					case 1:
						this.PvjigoKUew = \u0020;
						num = 2;
						if (!false)
						{
							num = 2;
						}
						break;
					case 2:
						return;
					case 3:
						this.tEYiYJ2qOF = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10;
						num = 1;
						if (!false)
						{
							num = 1;
						}
						break;
					}
				}
			}

			// Token: 0x06000B15 RID: 2837 RVA: 0x00056584 File Offset: 0x00054784
			public oMK8iyuIab2LETlLsfs(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.AfUvQhkregmHwB6RMek();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.PvjigoKUew = \u0020.PvjigoKUew;
						num = 2;
						continue;
					case 2:
						return;
					case 3:
						this.XyUUA5Idue = \u0020.XyUUA5Idue;
						num = 0;
						if (!false)
						{
							num = 0;
							continue;
						}
						continue;
					}
					this.tEYiYJ2qOF = \u0020.tEYiYJ2qOF;
					num = 0;
					if (true)
					{
						num = 1;
					}
				}
			}

			// Token: 0x06000B16 RID: 2838 RVA: 0x0005663C File Offset: 0x0005483C
			public override ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB AxLq8nl88V()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this);
			}

			// Token: 0x06000B17 RID: 2839 RVA: 0x0005664C File Offset: 0x0005484C
			public oMK8iyuIab2LETlLsfs(double \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.AfUvQhkregmHwB6RMek();
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.EmvnUnk7J0M1kx57Ifq();
				base..ctor();
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					default:
						this.PvjigoKUew = \u0020;
						num = 3;
						break;
					case 1:
						return;
					case 2:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)5;
						num = 0;
						if (false)
						{
							num = 0;
						}
						break;
					case 3:
						this.tEYiYJ2qOF = \u0020;
						num = 1;
						if (!true)
						{
							num = 0;
						}
						break;
					}
				}
			}

			// Token: 0x06000B18 RID: 2840 RVA: 0x000566F4 File Offset: 0x000548F4
			public oMK8iyuIab2LETlLsfs(float \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.AfUvQhkregmHwB6RMek();
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.EmvnUnk7J0M1kx57Ifq();
				base..ctor();
				int num = 2;
				if (false)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)5;
						num = 0;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						this.tEYiYJ2qOF = (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9;
						num = 1;
						if (!true)
						{
							num = 1;
							continue;
						}
						continue;
					}
					this.PvjigoKUew = (double)\u0020;
					num = 3;
				}
			}

			// Token: 0x06000B19 RID: 2841 RVA: 0x000567A8 File Offset: 0x000549A8
			public oMK8iyuIab2LETlLsfs(float \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.AfUvQhkregmHwB6RMek();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 1;
				if (false)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)5;
						num = 0;
						if (!false)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						this.tEYiYJ2qOF = \u0020;
						num = 2;
						if (true)
						{
							num = 3;
							continue;
						}
						continue;
					case 3:
						return;
					}
					this.PvjigoKUew = (double)\u0020;
					num = 1;
					if (!false)
					{
						num = 2;
					}
				}
			}

			// Token: 0x06000B1A RID: 2842 RVA: 0x00056868 File Offset: 0x00054A68
			public override bool WuHqq9Wdbv()
			{
				return this.PvjigoKUew == 0.0;
			}

			// Token: 0x06000B1B RID: 2843 RVA: 0x00056884 File Offset: 0x00054A84
			public override bool icyqdm73mi()
			{
				return !ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.Ee7lUAk2nt0RsqsdFmI(this);
			}

			// Token: 0x06000B1C RID: 2844 RVA: 0x00056898 File Offset: 0x00054A98
			public override string ToString()
			{
				return this.PvjigoKUew.ToString();
			}

			// Token: 0x06000B1D RID: 2845 RVA: 0x000568AC File Offset: 0x00054AAC
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Q1tqoFEFyp(ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				int num = 1;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4 ngYCBhqPZ7YsxPQyJh;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						switch (\u0020)
						{
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1:
							goto IL_AF;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2:
							goto IL_B6;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3:
							goto IL_BD;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4:
							goto IL_C4;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5:
							goto IL_CB;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6:
							goto IL_D2;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7:
							goto IL_D9;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8:
							goto IL_E0;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9:
							goto IL_9A;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10:
							goto IL_A1;
						case (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)11:
							goto IL_A8;
						default:
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						goto IL_7D;
					}
					ngYCBhqPZ7YsxPQyJh = (ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)4;
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num2 = 2;
					}
				}
				IL_7D:
				throw new Exception(ngYCBhqPZ7YsxPQyJh.ToString());
				IL_9A:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.GvRTDjk6mEt06kZjDuy(this);
				IL_A1:
				return this.c1GqttOeWQ();
				IL_A8:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.vdO5fpkNM62hZBNyWn5(this);
				IL_AF:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tF3RvVkngRTQAMGgOTU(this);
				IL_B6:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.RYSHaNk07SbDaG582bP(this);
				IL_BD:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.wC9kyUkJ0qSPut7PEQt(this);
				IL_C4:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XM1LD6kmmRjdTY9IUR3(this);
				IL_CB:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.O5VvpKkHig16yRiTo1Q(this);
				IL_D2:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.dFKsytkt5onr9CpBt5M(this);
				IL_D9:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tjT3yokYJOtSx8qekI4(this);
				IL_E0:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.HbqpwFks4G8Cnlsb19X(this);
			}

			// Token: 0x06000B1E RID: 2846 RVA: 0x000569BC File Offset: 0x00054BBC
			internal override object y9jq31urLD(Type \u0020)
			{
				int num = 8;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_152;
					case 1:
						goto IL_12D;
					case 2:
						goto IL_78;
					case 3:
						break;
					case 4:
						\u0020 = \u0020.GetElementType();
						goto IL_A8;
					case 5:
						goto IL_165;
					case 6:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.DAqvsOkGBqt8FovP2ov(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.CxWGV8kXZeqGH7RaIDT(16777236))))
						{
							num2 = 3;
							continue;
						}
						goto IL_85;
					case 7:
						goto IL_A8;
					case 8:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.W4s2PIkgWn2PsoIFjaL(\u0020, null))
						{
							goto IL_12D;
						}
						num2 = 7;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
						{
							num2 = 7;
							continue;
						}
						continue;
					default:
						goto IL_152;
					}
					IL_91:
					if (this.tEYiYJ2qOF == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9)
					{
						num2 = 2;
						continue;
					}
					goto IL_85;
					IL_152:
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.DAqvsOkGBqt8FovP2ov(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.CxWGV8kXZeqGH7RaIDT(16777346))))
					{
						goto Block_10;
					}
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.DAqvsOkGBqt8FovP2ov(\u0020, null))
					{
						goto IL_91;
					}
					num2 = 6;
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_A8:
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.DAqvsOkGBqt8FovP2ov(\u0020, ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.A4sKpfkMC07SdsYTNTc(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.CxWGV8kXZeqGH7RaIDT(16777333))))
					{
						goto IL_165;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_12D:
					if (!\u0020.IsByRef)
					{
						goto IL_A8;
					}
					num2 = 4;
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num2 = 1;
					}
				}
				IL_78:
				return (float)this.PvjigoKUew;
				IL_85:
				return this.PvjigoKUew;
				IL_165:
				return (float)this.PvjigoKUew;
				Block_10:
				return this.PvjigoKUew;
			}

			// Token: 0x06000B1F RID: 2847 RVA: 0x00056B80 File Offset: 0x00054D80
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NtxqQI1Zcd()
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_2F;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.Ee7lUAk2nt0RsqsdFmI(this))
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
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
				goto IL_4E;
				IL_2F:
				int u = 1;
				goto IL_7F;
				IL_4E:
				u = 0;
				IL_7F:
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(u);
			}

			// Token: 0x06000B20 RID: 2848 RVA: 0x00056C14 File Offset: 0x00054E14
			internal override bool lPSqCCLN7S()
			{
				return this.icyqdm73mi();
			}

			// Token: 0x06000B21 RID: 2849 RVA: 0x00056C24 File Offset: 0x00054E24
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F kZFq9GpslU()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((sbyte)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x06000B22 RID: 2850 RVA: 0x00056C3C File Offset: 0x00054E3C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F PQEqwQ01dQ()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)((byte)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x06000B23 RID: 2851 RVA: 0x00056C54 File Offset: 0x00054E54
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Br0qAy7jU5()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((short)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x06000B24 RID: 2852 RVA: 0x00056C6C File Offset: 0x00054E6C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QtGqh2NDQ8()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)((ushort)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x06000B25 RID: 2853 RVA: 0x00056C84 File Offset: 0x00054E84
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eoUqScGyAS()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)this.PvjigoKUew, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x06000B26 RID: 2854 RVA: 0x00056C9C File Offset: 0x00054E9C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F U0ZqI72BOj()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)this.PvjigoKUew, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x06000B27 RID: 2855 RVA: 0x00056CB4 File Offset: 0x00054EB4
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN JWZqiAqFR8()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((long)this.PvjigoKUew, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x06000B28 RID: 2856 RVA: 0x00056CCC File Offset: 0x00054ECC
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN upCqZP4jJd()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((ulong)this.PvjigoKUew, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x06000B29 RID: 2857 RVA: 0x00056CE4 File Offset: 0x00054EE4
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lk5qURpdjk()
			{
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tF3RvVkngRTQAMGgOTU(this);
			}

			// Token: 0x06000B2A RID: 2858 RVA: 0x00056CF4 File Offset: 0x00054EF4
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F HK7q1PliPm()
			{
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.wC9kyUkJ0qSPut7PEQt(this);
			}

			// Token: 0x06000B2B RID: 2859 RVA: 0x00056D04 File Offset: 0x00054F04
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F FOJqpHkit6()
			{
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.O5VvpKkHig16yRiTo1Q(this);
			}

			// Token: 0x06000B2C RID: 2860 RVA: 0x00056D14 File Offset: 0x00054F14
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN FmZq4JYpT6()
			{
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tjT3yokYJOtSx8qekI4(this);
			}

			// Token: 0x06000B2D RID: 2861 RVA: 0x00056D24 File Offset: 0x00054F24
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F hYvqOWPpOC()
			{
				return this.PQEqwQ01dQ();
			}

			// Token: 0x06000B2E RID: 2862 RVA: 0x00056D34 File Offset: 0x00054F34
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F o1ZqfYXchM()
			{
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XM1LD6kmmRjdTY9IUR3(this);
			}

			// Token: 0x06000B2F RID: 2863 RVA: 0x00056D44 File Offset: 0x00054F44
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F oAjqFTEeFY()
			{
				return this.U0ZqI72BOj();
			}

			// Token: 0x06000B30 RID: 2864 RVA: 0x00056D54 File Offset: 0x00054F54
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN SZBqTRsZeT()
			{
				return this.upCqZP4jJd();
			}

			// Token: 0x06000B31 RID: 2865 RVA: 0x00056D64 File Offset: 0x00054F64
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F ziwqR9N2wv()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((sbyte)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x06000B32 RID: 2866 RVA: 0x00056D7C File Offset: 0x00054F7C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F j5lqLol41P()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((sbyte)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
			}

			// Token: 0x06000B33 RID: 2867 RVA: 0x00056D94 File Offset: 0x00054F94
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F NN3qlXny0A()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((short)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x06000B34 RID: 2868 RVA: 0x00056DAC File Offset: 0x00054FAC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F cMXqaCAZHq()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((short)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
			}

			// Token: 0x06000B35 RID: 2869 RVA: 0x00056DC4 File Offset: 0x00054FC4
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Vy2qKYUMDe()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((int)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x06000B36 RID: 2870 RVA: 0x00056DDC File Offset: 0x00054FDC
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F QmjqeL3I7g()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((int)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
			}

			// Token: 0x06000B37 RID: 2871 RVA: 0x00056DF4 File Offset: 0x00054FF4
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN rMZqkTKtdW()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked((long)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x06000B38 RID: 2872 RVA: 0x00056E0C File Offset: 0x0005500C
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN c1Bqr7stpA()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked((long)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
			}

			// Token: 0x06000B39 RID: 2873 RVA: 0x00056E24 File Offset: 0x00055024
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F lZtq7DP5OI()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((byte)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x06000B3A RID: 2874 RVA: 0x00056E3C File Offset: 0x0005503C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F eFOq2JXLOE()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((byte)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
			}

			// Token: 0x06000B3B RID: 2875 RVA: 0x00056E54 File Offset: 0x00055054
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F CVaq6fDwxc()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((ushort)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x06000B3C RID: 2876 RVA: 0x00056E6C File Offset: 0x0005506C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F rvkqNso51v()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(checked((ushort)this.PvjigoKUew)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
			}

			// Token: 0x06000B3D RID: 2877 RVA: 0x00056E84 File Offset: 0x00055084
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F RywqnVZSZT()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((uint)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x06000B3E RID: 2878 RVA: 0x00056E9C File Offset: 0x0005509C
			public override ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F Jefq04Qqj5()
			{
				return new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(checked((uint)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
			}

			// Token: 0x06000B3F RID: 2879 RVA: 0x00056EB4 File Offset: 0x000550B4
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN LYYqJD7UOL()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked((ulong)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x06000B40 RID: 2880 RVA: 0x00056ECC File Offset: 0x000550CC
			public override ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN Msjqm6OQGU()
			{
				return new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(checked((ulong)this.PvjigoKUew), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
			}

			// Token: 0x06000B41 RID: 2881 RVA: 0x00056EE4 File Offset: 0x000550E4
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs qJhqHVUG8k()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((float)this.PvjigoKUew, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9);
			}

			// Token: 0x06000B42 RID: 2882 RVA: 0x00056EFC File Offset: 0x000550FC
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs c1GqttOeWQ()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10);
			}

			// Token: 0x06000B43 RID: 2883 RVA: 0x00056F14 File Offset: 0x00055114
			public override ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs HF1qYGZ8gN()
			{
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew);
			}

			// Token: 0x06000B44 RID: 2884 RVA: 0x00056F2C File Offset: 0x0005512C
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb yRRqsHbNK7()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.FmZq4JYpT6().OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.sKdRgTkBgoalWgT2eRn(this).aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000B45 RID: 2885 RVA: 0x00056F84 File Offset: 0x00055184
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb D1PqgOGTyj()
			{
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.mye3grkDdJkCVC8Q8do() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(this.SZBqTRsZeT().OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.w1b3nWkvmOYHi25NW1F(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x06000B46 RID: 2886 RVA: 0x00056FDC File Offset: 0x000551DC
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb XWcqXDk1Pt()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.aCZXHkkj2rTxTf6A1KN(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)this.Vy2qKYUMDe().aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000B47 RID: 2887 RVA: 0x0005702C File Offset: 0x0005522C
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb JjkqMxqLaY()
			{
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.mye3grkDdJkCVC8Q8do() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.ueWCLGkbCQoYlLrKN2X(this).OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.d8oYoWkztdL1ApIgFZr(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x06000B48 RID: 2888 RVA: 0x00057084 File Offset: 0x00055284
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb APcqGbirjs()
			{
				if (IntPtr.Size == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.WOwK42rWcSMQkmjAhQG(this).OluhFK2lXQ.Y3Why5AObT);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)this.QmjqeL3I7g().aYsh65bDic.RekhP3Apm0);
			}

			// Token: 0x06000B49 RID: 2889 RVA: 0x000570DC File Offset: 0x000552DC
			public override ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb CY1qBxKBHt()
			{
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.mye3grkDdJkCVC8Q8do() == 8)
				{
					return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.zIBucQrP2C21JGOiyY2(this).OluhFK2lXQ.SL4hxlZ2Vr);
				}
				return new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((ulong)ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JbCsjerEZPmVdn9m5tC(this).aYsh65bDic.Vavhb40As7);
			}

			// Token: 0x06000B4A RID: 2890 RVA: 0x00057134 File Offset: 0x00055334
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC CpmqDtDe45()
			{
				if (this.tEYiYJ2qOF == (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9)
				{
					return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((float)(-(float)this.PvjigoKUew));
				}
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(-this.PvjigoKUew);
			}

			// Token: 0x06000B4B RID: 2891 RVA: 0x00057170 File Offset: 0x00055370
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Add(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_8B;
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						break;
					case 3:
						goto IL_AD;
					default:
						goto IL_8B;
					}
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						num2 = 3;
						continue;
					}
					break;
					IL_8B:
					\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
					num2 = 2;
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num2 = 2;
					}
				}
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew + ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				IL_AD:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B4C RID: 2892 RVA: 0x00057234 File Offset: 0x00055434
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC LfyqvMrNHx(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
				{
					goto IL_44;
				}
				\u0020 = \u0020.s9Cd9Og84k();
				int num = 1;
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
				{
					num = 1;
				}
				IL_10:
				switch (num)
				{
				case 1:
					IL_44:
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
					}
					num = 0;
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew + ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
			}

			// Token: 0x06000B4D RID: 2893 RVA: 0x000572D8 File Offset: 0x000554D8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC KrBqjlnYTv(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						goto IL_7F;
					case 2:
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto IL_7F;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
					IL_7F:
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						goto IL_79;
					}
					num2 = 0;
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num2 = 0;
					}
				}
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew + ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				IL_79:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B4E RID: 2894 RVA: 0x00057388 File Offset: 0x00055588
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cmUqbj78eE(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_74;
					case 3:
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							num2 = 2;
							continue;
						}
						\u0020 = \u0020.s9Cd9Og84k();
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					if (!\u0020.Qgk8YYFIOA())
					{
						goto IL_8C;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
					{
						num2 = 1;
					}
				}
				IL_74:
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew - ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				IL_8C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B4F RID: 2895 RVA: 0x0005744C File Offset: 0x0005564C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC iHaqzsE4Kf(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 3;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_7B;
					case 3:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 2;
							continue;
						}
						goto IL_B8;
					case 4:
						goto IL_B8;
					}
					break;
					IL_B8:
					\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
					{
						num2 = 0;
					}
				}
				if (!\u0020.Qgk8YYFIOA())
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_7B:
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew - ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
			}

			// Token: 0x06000B50 RID: 2896 RVA: 0x00057534 File Offset: 0x00055734
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC auGdW5LU1o(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto IL_37;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_A6;
					case 3:
						goto IL_37;
					case 4:
						goto IL_88;
					}
					IL_B5:
					if (\u0020.Qgk8YYFIOA())
					{
						break;
					}
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num2 = 2;
						continue;
					}
					continue;
					goto IL_B5;
					IL_37:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_B5;
				}
				IL_88:
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew - ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				IL_A6:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B51 RID: 2897 RVA: 0x0005761C File Offset: 0x0005581C
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cT0dPKbnSa(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
				{
					goto IL_5F;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
				{
					num = 0;
				}
				IL_10:
				switch (num)
				{
				case 0:
					goto IL_5F;
				case 1:
					return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew * ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				case 2:
					break;
				case 3:
					goto IL_CD;
				default:
					goto IL_5F;
				}
				IL_3A:
				if (!\u0020.Qgk8YYFIOA())
				{
					goto IL_CD;
				}
				num = 1;
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
				IL_5F:
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
				{
					num = 3;
					goto IL_10;
				}
				goto IL_3A;
				IL_CD:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B52 RID: 2898 RVA: 0x000576FC File Offset: 0x000558FC
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC C3mdEhLvXd(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_B5;
					case 1:
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						break;
					case 3:
						goto IL_B5;
					case 4:
						goto IL_99;
					}
					\u0020 = \u0020.s9Cd9Og84k();
					num2 = 3;
					continue;
					IL_B5:
					if (\u0020.Qgk8YYFIOA())
					{
						break;
					}
					num2 = 4;
				}
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew * ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				IL_99:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B53 RID: 2899 RVA: 0x000577D4 File Offset: 0x000559D4
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC jaYdc2eCJF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						if (\u0020.TB5dFM9QIv())
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
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
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
				{
					return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew * ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B54 RID: 2900 RVA: 0x00057884 File Offset: 0x00055A84
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC XIyd5fI2tA(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
				{
					goto IL_49;
				}
				goto IL_9C;
				IL_10:
				int num;
				switch (num)
				{
				case 1:
					IL_49:
					if (!\u0020.Qgk8YYFIOA())
					{
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
						{
							num = 2;
							goto IL_10;
						}
						goto IL_10;
					}
					break;
				case 2:
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				case 3:
					IL_9C:
					\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
					{
						num = 1;
						goto IL_10;
					}
					goto IL_10;
				}
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew / ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
			}

			// Token: 0x06000B55 RID: 2901 RVA: 0x00057960 File Offset: 0x00055B60
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Ut1dxA1rQp(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						goto IL_3C;
					case 2:
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto IL_3C;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
					IL_3C:
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						goto IL_79;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
					{
						num2 = 0;
					}
				}
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew / ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				IL_79:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B56 RID: 2902 RVA: 0x00057A10 File Offset: 0x00055C10
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC yCeduJ3YIo(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
				{
					goto IL_85;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
				int num = 2;
				IL_10:
				switch (num)
				{
				case 1:
					goto IL_57;
				case 2:
					IL_85:
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						goto IL_57;
					}
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_57:
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew % ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
			}

			// Token: 0x06000B57 RID: 2903 RVA: 0x00057AC8 File Offset: 0x00055CC8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC O5ndVV1NCh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_2F;
					case 1:
						\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
						break;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							num2 = 1;
							if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					}
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						goto IL_47;
					}
					num2 = 0;
					if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
					{
						num2 = 0;
					}
				}
				IL_2F:
				return new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(this.PvjigoKUew % ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew);
				IL_47:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B58 RID: 2904 RVA: 0x00057B78 File Offset: 0x00055D78
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC DyOdyCLR3X(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B59 RID: 2905 RVA: 0x00057B88 File Offset: 0x00055D88
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC dH3d8VFM3E(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B5A RID: 2906 RVA: 0x00057B98 File Offset: 0x00055D98
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Rw9dqatOP5()
			{
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B5B RID: 2907 RVA: 0x00057BA8 File Offset: 0x00055DA8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC lBXdd758He(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B5C RID: 2908 RVA: 0x00057BB8 File Offset: 0x00055DB8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC L5SdoEFytK(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B5D RID: 2909 RVA: 0x00057BC8 File Offset: 0x00055DC8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC f17d3EnLUZ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x00057BD8 File Offset: 0x00055DD8
			public override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC V36dQSy6F7(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B5F RID: 2911 RVA: 0x00057BE8 File Offset: 0x00055DE8
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				return this;
			}

			// Token: 0x06000B60 RID: 2912 RVA: 0x00057BF4 File Offset: 0x00055DF4
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return false;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(x0cbwj80qtx55Tsu8UC))
						{
							goto IL_7E;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto Block_5;
						}
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
						num2 = 2;
						continue;
					case 4:
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.ibxMoxru5ojdXSARLLQ(\u0020))
						{
							num2 = 3;
							continue;
						}
						break;
					}
					break;
				}
				return false;
				IL_7E:
				return this.PvjigoKUew == ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)x0cbwj80qtx55Tsu8UC).PvjigoKUew;
				Block_5:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tnMl8srVqKja6qiRFbU((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
			}

			// Token: 0x06000B61 RID: 2913 RVA: 0x00057CDC File Offset: 0x00055EDC
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 5;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return false;
					case 2:
						if (x0cbwj80qtx55Tsu8UC.Qgk8YYFIOA())
						{
							num2 = 3;
							continue;
						}
						break;
					case 3:
						goto IL_AF;
					case 4:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto Block_5;
						}
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
						{
							num2 = 2;
							continue;
						}
						continue;
					case 5:
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.ibxMoxru5ojdXSARLLQ(\u0020))
						{
							num2 = 4;
							continue;
						}
						return false;
					}
					break;
				}
				return false;
				IL_AF:
				return this.PvjigoKUew != ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)x0cbwj80qtx55Tsu8UC).PvjigoKUew;
				Block_5:
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.QKVoWNrytmXayBHY1KJ((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
			}

			// Token: 0x06000B62 RID: 2914 RVA: 0x00057DE8 File Offset: 0x00055FE8
			public override bool SqWdSNFM0N(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_33;
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						break;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							num2 = 1;
							if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						break;
					case 3:
						goto IL_9A;
					}
					if (\u0020.Qgk8YYFIOA())
					{
						break;
					}
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
					{
						num2 = 3;
					}
				}
				IL_33:
				return this.PvjigoKUew >= ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
				IL_9A:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B63 RID: 2915 RVA: 0x00057EBC File Offset: 0x000560BC
			public override bool DSNdIxSMBQ(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
				{
					goto IL_36;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
				int num = 2;
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
				{
					num = 2;
				}
				IL_10:
				switch (num)
				{
				case 1:
					goto IL_5B;
				case 2:
					IL_36:
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						goto IL_5B;
					}
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5B:
				return this.PvjigoKUew >= ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
			}

			// Token: 0x06000B64 RID: 2916 RVA: 0x00057F84 File Offset: 0x00056184
			public override bool DoCdicvJaP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
				{
					goto IL_6E;
				}
				\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
				{
					num = 0;
				}
				IL_10:
				switch (num)
				{
				case 1:
					return this.PvjigoKUew > ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
				}
				IL_6E:
				if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				num = 1;
				if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000B65 RID: 2917 RVA: 0x00058024 File Offset: 0x00056224
			public override bool IJkdZ22aVF(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto IL_91;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_91;
					}
					break;
					IL_91:
					\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
					num2 = 3;
				}
				if (\u0020.Qgk8YYFIOA())
				{
					return this.PvjigoKUew > ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
				}
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B66 RID: 2918 RVA: 0x000580E4 File Offset: 0x000562E4
			public override bool VdHdUonKxI(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							goto IL_33;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_33;
					case 3:
						goto IL_99;
					}
					IL_5F:
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						num2 = 3;
						continue;
					}
					goto IL_B0;
					IL_33:
					\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
					goto IL_5F;
				}
				IL_99:
				return this.PvjigoKUew <= ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
				IL_B0:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B67 RID: 2919 RVA: 0x000581A8 File Offset: 0x000563A8
			public override bool sxQd1txC3H(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_33;
					case 1:
						break;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto IL_33;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_55;
					}
					IL_40:
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						num2 = 3;
						continue;
					}
					goto IL_6C;
					IL_33:
					\u0020 = ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.FGSBH8rc5Oprq6IM6bN(\u0020);
					goto IL_40;
				}
				IL_55:
				return this.PvjigoKUew <= ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
				IL_6C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B68 RID: 2920 RVA: 0x0005826C File Offset: 0x0005646C
			public override bool WY8dpeljbh(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A6;
					case 1:
						break;
					case 2:
						if (\u0020.TB5dFM9QIv())
						{
							goto IL_A6;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.tWCyiokKTjvFWEsGMU1())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_33;
					default:
						goto IL_A6;
					}
					IL_4D:
					if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.JIpKgMr59xYEHKrEHRT(\u0020))
					{
						num2 = 3;
						continue;
					}
					goto IL_47;
					IL_A6:
					\u0020 = \u0020.s9Cd9Og84k();
					goto IL_4D;
				}
				IL_33:
				return this.PvjigoKUew < ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
				IL_47:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000B69 RID: 2921 RVA: 0x0005832C File Offset: 0x0005652C
			public override bool Fqpd4WZY4A(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						\u0020 = \u0020.s9Cd9Og84k();
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() == null)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 2:
						if (!ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.P5S4WJrxXTaadkCPlMy(\u0020))
						{
							goto IL_52;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.XjlnYXkekYcYEuRoNyR() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						goto IL_52;
					}
					break;
				}
				goto IL_62;
				IL_52:
				if (!\u0020.Qgk8YYFIOA())
				{
					throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				}
				IL_62:
				return this.PvjigoKUew < ((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020).PvjigoKUew;
			}

			// Token: 0x06000B6A RID: 2922 RVA: 0x000583FC File Offset: 0x000565FC
			// Note: this type is marked as 'beforefieldinit'.
			static oMK8iyuIab2LETlLsfs()
			{
				ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.T7XUnUr8iu5oayuZP0o();
			}

			// Token: 0x06000B6B RID: 2923 RVA: 0x0005840C File Offset: 0x0005660C
			internal static bool tWCyiokKTjvFWEsGMU1()
			{
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.RdUVfFkatysYKapbeSY == null;
			}

			// Token: 0x06000B6C RID: 2924 RVA: 0x00058420 File Offset: 0x00056620
			internal static ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs XjlnYXkekYcYEuRoNyR()
			{
				return ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs.RdUVfFkatysYKapbeSY;
			}

			// Token: 0x06000B6D RID: 2925 RVA: 0x00058430 File Offset: 0x00056630
			internal static void TWwfPvkkWp2yixaPHVB(object A_0, object A_1)
			{
				A_0.AxwqVJ6XV5(A_1);
			}

			// Token: 0x06000B6E RID: 2926 RVA: 0x00058448 File Offset: 0x00056648
			internal static void AfUvQhkregmHwB6RMek()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000B6F RID: 2927 RVA: 0x00058458 File Offset: 0x00056658
			internal static void EmvnUnk7J0M1kx57Ifq()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000B70 RID: 2928 RVA: 0x00058468 File Offset: 0x00056668
			internal static bool Ee7lUAk2nt0RsqsdFmI(object A_0)
			{
				return A_0.WuHqq9Wdbv();
			}

			// Token: 0x06000B71 RID: 2929 RVA: 0x0005847C File Offset: 0x0005667C
			internal static object GvRTDjk6mEt06kZjDuy(object A_0)
			{
				return A_0.qJhqHVUG8k();
			}

			// Token: 0x06000B72 RID: 2930 RVA: 0x00058490 File Offset: 0x00056690
			internal static object vdO5fpkNM62hZBNyWn5(object A_0)
			{
				return A_0.NtxqQI1Zcd();
			}

			// Token: 0x06000B73 RID: 2931 RVA: 0x000584A4 File Offset: 0x000566A4
			internal static object tF3RvVkngRTQAMGgOTU(object A_0)
			{
				return A_0.kZFq9GpslU();
			}

			// Token: 0x06000B74 RID: 2932 RVA: 0x000584B8 File Offset: 0x000566B8
			internal static object RYSHaNk07SbDaG582bP(object A_0)
			{
				return A_0.PQEqwQ01dQ();
			}

			// Token: 0x06000B75 RID: 2933 RVA: 0x000584CC File Offset: 0x000566CC
			internal static object wC9kyUkJ0qSPut7PEQt(object A_0)
			{
				return A_0.Br0qAy7jU5();
			}

			// Token: 0x06000B76 RID: 2934 RVA: 0x000584E0 File Offset: 0x000566E0
			internal static object XM1LD6kmmRjdTY9IUR3(object A_0)
			{
				return A_0.QtGqh2NDQ8();
			}

			// Token: 0x06000B77 RID: 2935 RVA: 0x000584F4 File Offset: 0x000566F4
			internal static object O5VvpKkHig16yRiTo1Q(object A_0)
			{
				return A_0.eoUqScGyAS();
			}

			// Token: 0x06000B78 RID: 2936 RVA: 0x00058508 File Offset: 0x00056708
			internal static object dFKsytkt5onr9CpBt5M(object A_0)
			{
				return A_0.U0ZqI72BOj();
			}

			// Token: 0x06000B79 RID: 2937 RVA: 0x0005851C File Offset: 0x0005671C
			internal static object tjT3yokYJOtSx8qekI4(object A_0)
			{
				return A_0.JWZqiAqFR8();
			}

			// Token: 0x06000B7A RID: 2938 RVA: 0x00058530 File Offset: 0x00056730
			internal static object HbqpwFks4G8Cnlsb19X(object A_0)
			{
				return A_0.upCqZP4jJd();
			}

			// Token: 0x06000B7B RID: 2939 RVA: 0x00058544 File Offset: 0x00056744
			internal static bool W4s2PIkgWn2PsoIFjaL(Type A_0, Type A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000B7C RID: 2940 RVA: 0x0005855C File Offset: 0x0005675C
			internal static RuntimeTypeHandle CxWGV8kXZeqGH7RaIDT(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000B7D RID: 2941 RVA: 0x00058570 File Offset: 0x00056770
			internal static Type A4sKpfkMC07SdsYTNTc(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000B7E RID: 2942 RVA: 0x00058584 File Offset: 0x00056784
			internal static bool DAqvsOkGBqt8FovP2ov(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000B7F RID: 2943 RVA: 0x0005859C File Offset: 0x0005679C
			internal static object sKdRgTkBgoalWgT2eRn(object A_0)
			{
				return A_0.FOJqpHkit6();
			}

			// Token: 0x06000B80 RID: 2944 RVA: 0x000585B0 File Offset: 0x000567B0
			internal static int mye3grkDdJkCVC8Q8do()
			{
				return IntPtr.Size;
			}

			// Token: 0x06000B81 RID: 2945 RVA: 0x000585C0 File Offset: 0x000567C0
			internal static object w1b3nWkvmOYHi25NW1F(object A_0)
			{
				return A_0.oAjqFTEeFY();
			}

			// Token: 0x06000B82 RID: 2946 RVA: 0x000585D4 File Offset: 0x000567D4
			internal static object aCZXHkkj2rTxTf6A1KN(object A_0)
			{
				return A_0.rMZqkTKtdW();
			}

			// Token: 0x06000B83 RID: 2947 RVA: 0x000585E8 File Offset: 0x000567E8
			internal static object ueWCLGkbCQoYlLrKN2X(object A_0)
			{
				return A_0.LYYqJD7UOL();
			}

			// Token: 0x06000B84 RID: 2948 RVA: 0x000585FC File Offset: 0x000567FC
			internal static object d8oYoWkztdL1ApIgFZr(object A_0)
			{
				return A_0.RywqnVZSZT();
			}

			// Token: 0x06000B85 RID: 2949 RVA: 0x00058610 File Offset: 0x00056810
			internal static object WOwK42rWcSMQkmjAhQG(object A_0)
			{
				return A_0.c1Bqr7stpA();
			}

			// Token: 0x06000B86 RID: 2950 RVA: 0x00058624 File Offset: 0x00056824
			internal static object zIBucQrP2C21JGOiyY2(object A_0)
			{
				return A_0.Msjqm6OQGU();
			}

			// Token: 0x06000B87 RID: 2951 RVA: 0x00058638 File Offset: 0x00056838
			internal static object JbCsjerEZPmVdn9m5tC(object A_0)
			{
				return A_0.Jefq04Qqj5();
			}

			// Token: 0x06000B88 RID: 2952 RVA: 0x0005864C File Offset: 0x0005684C
			internal static object FGSBH8rc5Oprq6IM6bN(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000B89 RID: 2953 RVA: 0x00058660 File Offset: 0x00056860
			internal static bool JIpKgMr59xYEHKrEHRT(object A_0)
			{
				return A_0.Qgk8YYFIOA();
			}

			// Token: 0x06000B8A RID: 2954 RVA: 0x00058674 File Offset: 0x00056874
			internal static bool P5S4WJrxXTaadkCPlMy(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000B8B RID: 2955 RVA: 0x00058688 File Offset: 0x00056888
			internal static bool ibxMoxru5ojdXSARLLQ(object A_0)
			{
				return A_0.MEy8J5BANA();
			}

			// Token: 0x06000B8C RID: 2956 RVA: 0x0005869C File Offset: 0x0005689C
			internal static bool tnMl8srVqKja6qiRFbU(object A_0, object A_1)
			{
				return A_0.ovDdASrPUT(A_1);
			}

			// Token: 0x06000B8D RID: 2957 RVA: 0x000586B4 File Offset: 0x000568B4
			internal static bool QKVoWNrytmXayBHY1KJ(object A_0, object A_1)
			{
				return A_0.g5sdhSCwCu(A_1);
			}

			// Token: 0x06000B8E RID: 2958 RVA: 0x000586CC File Offset: 0x000568CC
			internal static void T7XUnUr8iu5oayuZP0o()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003C3 RID: 963
			public double PvjigoKUew;

			// Token: 0x040003C4 RID: 964
			public ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ tEYiYJ2qOF;

			// Token: 0x040003C5 RID: 965
			private static ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs RdUVfFkatysYKapbeSY;
		}

		// Token: 0x02000074 RID: 116
		internal enum DEoHSYuiJEGISeKGmfJ : byte
		{

		}

		// Token: 0x02000075 RID: 117
		internal enum JqHLvcuZWpW1MQBVIOg : byte
		{

		}

		// Token: 0x02000076 RID: 118
		private class YID8t4uU9BPSeIRVEMs : Exception
		{
			// Token: 0x06000B8F RID: 2959 RVA: 0x000586DC File Offset: 0x000568DC
			public YID8t4uU9BPSeIRVEMs(string \u0020)
			{
				ykD11HxHfZBYH7OcFOG.YID8t4uU9BPSeIRVEMs.ylYQuYrhvDYUxp9QF30();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor(\u0020);
				int num = 0;
				if (true)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000B90 RID: 2960 RVA: 0x00058738 File Offset: 0x00056938
			// Note: this type is marked as 'beforefieldinit'.
			static YID8t4uU9BPSeIRVEMs()
			{
				ykD11HxHfZBYH7OcFOG.YID8t4uU9BPSeIRVEMs.MlrGaerSrqWcYBQR6Qu();
			}

			// Token: 0x06000B91 RID: 2961 RVA: 0x00058748 File Offset: 0x00056948
			internal static void ylYQuYrhvDYUxp9QF30()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000B92 RID: 2962 RVA: 0x00058758 File Offset: 0x00056958
			internal static bool zfiuxlrwDAxQ857nQVL()
			{
				return ykD11HxHfZBYH7OcFOG.YID8t4uU9BPSeIRVEMs.GMqBuqr9sNe6GXguuIu == null;
			}

			// Token: 0x06000B93 RID: 2963 RVA: 0x0005876C File Offset: 0x0005696C
			internal static ykD11HxHfZBYH7OcFOG.YID8t4uU9BPSeIRVEMs Mbh5nNrAcGOuMWPXUeX()
			{
				return ykD11HxHfZBYH7OcFOG.YID8t4uU9BPSeIRVEMs.GMqBuqr9sNe6GXguuIu;
			}

			// Token: 0x06000B94 RID: 2964 RVA: 0x0005877C File Offset: 0x0005697C
			internal static void MlrGaerSrqWcYBQR6Qu()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003C8 RID: 968
			internal static ykD11HxHfZBYH7OcFOG.YID8t4uU9BPSeIRVEMs GMqBuqr9sNe6GXguuIu;
		}

		// Token: 0x02000077 RID: 119
		private class A9dEPKu18soOU9o8vkD : Exception
		{
			// Token: 0x06000B95 RID: 2965 RVA: 0x0005878C File Offset: 0x0005698C
			public A9dEPKu18soOU9o8vkD()
			{
				ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD.BujfZ1rUnBwb9d8nKYq();
				ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD.YHsHCur1eoPxtIjQ5Jj();
				base..ctor();
				int num = 0;
				if (!false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000B96 RID: 2966 RVA: 0x000587E8 File Offset: 0x000569E8
			public A9dEPKu18soOU9o8vkD(string \u0020)
			{
				ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD.BujfZ1rUnBwb9d8nKYq();
				ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD.YHsHCur1eoPxtIjQ5Jj();
				base..ctor(\u0020);
				int num = 0;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000B97 RID: 2967 RVA: 0x00058844 File Offset: 0x00056A44
			// Note: this type is marked as 'beforefieldinit'.
			static A9dEPKu18soOU9o8vkD()
			{
				ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD.DIvAKVrpZCqf9SQXnUq();
			}

			// Token: 0x06000B98 RID: 2968 RVA: 0x00058854 File Offset: 0x00056A54
			internal static void BujfZ1rUnBwb9d8nKYq()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000B99 RID: 2969 RVA: 0x00058864 File Offset: 0x00056A64
			internal static void YHsHCur1eoPxtIjQ5Jj()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000B9A RID: 2970 RVA: 0x00058874 File Offset: 0x00056A74
			internal static bool aYAEeBri7U8bXENnlcF()
			{
				return ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD.TO5RPArIGAUB8Sq48OY == null;
			}

			// Token: 0x06000B9B RID: 2971 RVA: 0x00058888 File Offset: 0x00056A88
			internal static ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD IXjau0rZl6Kfn2C7mhu()
			{
				return ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD.TO5RPArIGAUB8Sq48OY;
			}

			// Token: 0x06000B9C RID: 2972 RVA: 0x00058898 File Offset: 0x00056A98
			internal static void DIvAKVrpZCqf9SQXnUq()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003C9 RID: 969
			private static ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD TO5RPArIGAUB8Sq48OY;
		}

		// Token: 0x02000078 RID: 120
		internal class OSWePDupJwenbref1Qt
		{
			// Token: 0x06000B9D RID: 2973 RVA: 0x000588A8 File Offset: 0x00056AA8
			public override string ToString()
			{
				int num = 1;
				int num2 = num;
				object obj;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						obj = this.Igyi81L3PF;
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt.NyOmSrrOR7arYdCbSTH())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				if (this.ML8iCQiVG6 != null)
				{
					return ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt.cNfUFErFj28tmCDOoRM(obj.ToString(), 'H'.ToString(), this.ML8iCQiVG6.ToString());
				}
				return obj.ToString();
			}

			// Token: 0x06000B9E RID: 2974 RVA: 0x00058944 File Offset: 0x00056B44
			public OSWePDupJwenbref1Qt()
			{
				ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt.ru6oGVrT3YJAeJqEqJv();
				ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt.cam44QrRZqSYC0RFSHW();
				this.Igyi81L3PF = (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)126;
				base..ctor();
				int num = 0;
				if (!true)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000B9F RID: 2975 RVA: 0x000589AC File Offset: 0x00056BAC
			// Note: this type is marked as 'beforefieldinit'.
			static OSWePDupJwenbref1Qt()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x06000BA0 RID: 2976 RVA: 0x000589BC File Offset: 0x00056BBC
			internal static object cNfUFErFj28tmCDOoRM(object A_0, object A_1, object A_2)
			{
				return A_0 + A_1 + A_2;
			}

			// Token: 0x06000BA1 RID: 2977 RVA: 0x000589D8 File Offset: 0x00056BD8
			internal static bool NyOmSrrOR7arYdCbSTH()
			{
				return ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt.mBSbUor413CaXRo3sUn == null;
			}

			// Token: 0x06000BA2 RID: 2978 RVA: 0x000589EC File Offset: 0x00056BEC
			internal static ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt UfoXcnrfcMcCsPf05DR()
			{
				return ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt.mBSbUor413CaXRo3sUn;
			}

			// Token: 0x06000BA3 RID: 2979 RVA: 0x000589FC File Offset: 0x00056BFC
			internal static void ru6oGVrT3YJAeJqEqJv()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000BA4 RID: 2980 RVA: 0x00058A0C File Offset: 0x00056C0C
			internal static void cam44QrRZqSYC0RFSHW()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x040003CA RID: 970
			internal ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j Igyi81L3PF;

			// Token: 0x040003CB RID: 971
			internal object ML8iCQiVG6;

			// Token: 0x040003CC RID: 972
			internal static ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt mBSbUor413CaXRo3sUn;
		}

		// Token: 0x02000079 RID: 121
		internal abstract class sK9Zdfu498A1KFPnIfR : ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC
		{
			// Token: 0x06000BA5 RID: 2981 RVA: 0x00058A1C File Offset: 0x00056C1C
			public sK9Zdfu498A1KFPnIfR()
			{
				ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR.oaa7XIrKl4e9mEixL2w();
				ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR.IPQ8J1refSc2s9Ts12b();
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000BA6 RID: 2982 RVA: 0x00058A78 File Offset: 0x00056C78
			internal override bool TB5dFM9QIv()
			{
				return true;
			}

			// Token: 0x06000BA7 RID: 2983
			internal abstract IntPtr kBGdTuP4Wf();

			// Token: 0x06000BA8 RID: 2984
			internal abstract void xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000BA9 RID: 2985 RVA: 0x00058A84 File Offset: 0x00056C84
			internal override bool YbodO0QW3H()
			{
				return true;
			}

			// Token: 0x06000BAA RID: 2986 RVA: 0x00058A90 File Offset: 0x00056C90
			// Note: this type is marked as 'beforefieldinit'.
			static sK9Zdfu498A1KFPnIfR()
			{
				ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR.I8QjBprkK1px36WJQGt();
			}

			// Token: 0x06000BAB RID: 2987 RVA: 0x00058AA0 File Offset: 0x00056CA0
			internal static void oaa7XIrKl4e9mEixL2w()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000BAC RID: 2988 RVA: 0x00058AB0 File Offset: 0x00056CB0
			internal static void IPQ8J1refSc2s9Ts12b()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000BAD RID: 2989 RVA: 0x00058AC0 File Offset: 0x00056CC0
			internal static bool q46RvNrlvEPx1G9WtjR()
			{
				return ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR.Pb2ixorLpDeMeT1NPW2 == null;
			}

			// Token: 0x06000BAE RID: 2990 RVA: 0x00058AD4 File Offset: 0x00056CD4
			internal static ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR io527RraJ9LnZrEM6wY()
			{
				return ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR.Pb2ixorLpDeMeT1NPW2;
			}

			// Token: 0x06000BAF RID: 2991 RVA: 0x00058AE4 File Offset: 0x00056CE4
			internal static void I8QjBprkK1px36WJQGt()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003CD RID: 973
			internal static ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR Pb2ixorLpDeMeT1NPW2;
		}

		// Token: 0x0200007A RID: 122
		internal class ujZOqDuOPGmGA43ZXUu : ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR
		{
			// Token: 0x06000BB0 RID: 2992 RVA: 0x00058AF4 File Offset: 0x00056CF4
			public ujZOqDuOPGmGA43ZXUu(int \u0020, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F \u0020)
			{
				ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.C4VqRGr6LOwJA3RqMSs();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 1;
				if (!false)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
					{
						this.ktEij0hQ7y = \u0020;
						int num2 = 3;
						num = num2;
						continue;
					}
					case 2:
						return;
					case 3:
						this.XnLiabPSAI = \u0020;
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)7;
					num = 2;
					if (!true)
					{
						num = 0;
					}
				}
			}

			// Token: 0x06000BB1 RID: 2993 RVA: 0x00058BAC File Offset: 0x00056DAC
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (\u0020 is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.UpAbgRr7LGVaB9v1dxy())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3 uao91Iul5XdTuF01HB = this.ktEij0hQ7y.OOMlcvRAjr.u7wi6eANjd[this.XnLiabPSAI];
							num2 = 7;
							if (ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.X1wdcpr2VwhGlGal0uB() != null)
							{
								num2 = 6;
								continue;
							}
							continue;
						}
						break;
					case 2:
						return;
					case 3:
						goto IL_E5;
					case 4:
						goto IL_AA;
					case 5:
						goto IL_12B;
					case 6:
					{
						ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3 uao91Iul5XdTuF01HB;
						if ((uao91Iul5XdTuF01HB.ob0itY7ilV & (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)226) > (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)0)
						{
							goto IL_156;
						}
						num2 = 3;
						if (ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.X1wdcpr2VwhGlGal0uB() == null)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					case 7:
						if (\u0020 is ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)
						{
							num2 = 6;
							continue;
						}
						goto IL_E5;
					case 8:
						goto IL_156;
					}
					this.ktEij0hQ7y = ((ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)\u0020).ktEij0hQ7y;
					num2 = 5;
					continue;
					IL_E5:
					ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.jpCyewrnfc7YxBSynCA(this, \u0020);
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.UpAbgRr7LGVaB9v1dxy())
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_156:
					x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.FsLqGTrN4P8a5JKXKZb(\u0020 as ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR);
					num2 = 4;
				}
				return;
				IL_AA:
				ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.jpCyewrnfc7YxBSynCA(this, x0cbwj80qtx55Tsu8UC);
				return;
				IL_12B:
				this.XnLiabPSAI = ((ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)\u0020).XnLiabPSAI;
			}

			// Token: 0x06000BB2 RID: 2994 RVA: 0x00058D28 File Offset: 0x00056F28
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.jpCyewrnfc7YxBSynCA(this, \u0020);
			}

			// Token: 0x06000BB3 RID: 2995 RVA: 0x00058D44 File Offset: 0x00056F44
			internal override IntPtr kBGdTuP4Wf()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000BB4 RID: 2996 RVA: 0x00058D54 File Offset: 0x00056F54
			internal override void xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.ktEij0hQ7y.RGflstwkfS[this.XnLiabPSAI] = \u0020;
			}

			// Token: 0x06000BB5 RID: 2997 RVA: 0x00058D78 File Offset: 0x00056F78
			internal override object y9jq31urLD(Type \u0020)
			{
				if (this.ktEij0hQ7y.RGflstwkfS[this.XnLiabPSAI] == null)
				{
					return null;
				}
				return ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.UyRTH1r0euMy09qkW30(ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.FsLqGTrN4P8a5JKXKZb(this), \u0020);
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x00058DB0 File Offset: 0x00056FB0
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				if (this.ktEij0hQ7y.RGflstwkfS[this.XnLiabPSAI] != null)
				{
					return ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.FsLqGTrN4P8a5JKXKZb(this.ktEij0hQ7y.RGflstwkfS[this.XnLiabPSAI]);
				}
				return new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
			}

			// Token: 0x06000BB7 RID: 2999 RVA: 0x00058E34 File Offset: 0x00057034
			internal override bool y9QdwWY3Xc()
			{
				return ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.IZEoIFrJr6djI8jyWwh(ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.FsLqGTrN4P8a5JKXKZb(this));
			}

			// Token: 0x06000BB8 RID: 3000 RVA: 0x00058E48 File Offset: 0x00057048
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!\u0020.TB5dFM9QIv())
				{
					return false;
				}
				if (\u0020 is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)
				{
					int num = 0;
					if (ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.X1wdcpr2VwhGlGal0uB() == null)
					{
						num = 0;
					}
					for (;;)
					{
						switch (num)
						{
						default:
							if (((ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)\u0020).XnLiabPSAI != this.XnLiabPSAI)
							{
								return false;
							}
							num = 1;
							if (ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.X1wdcpr2VwhGlGal0uB() == null)
							{
								num = 1;
							}
							break;
						case 1:
							return true;
						}
					}
					return true;
				}
				return false;
			}

			// Token: 0x06000BB9 RID: 3001 RVA: 0x00058EE4 File Offset: 0x000570E4
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!\u0020.TB5dFM9QIv())
						{
							return true;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.X1wdcpr2VwhGlGal0uB() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_54;
					}
					if (!(\u0020 is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu))
					{
						return true;
					}
					num2 = 2;
					if (!ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.UpAbgRr7LGVaB9v1dxy())
					{
						num2 = 1;
					}
				}
				IL_54:
				return ((ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)\u0020).XnLiabPSAI != this.XnLiabPSAI;
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x00058F8C File Offset: 0x0005718C
			internal override bool lPSqCCLN7S()
			{
				return ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.FsLqGTrN4P8a5JKXKZb(this).lPSqCCLN7S();
			}

			// Token: 0x06000BBB RID: 3003 RVA: 0x00058FA0 File Offset: 0x000571A0
			// Note: this type is marked as 'beforefieldinit'.
			static ujZOqDuOPGmGA43ZXUu()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x06000BBC RID: 3004 RVA: 0x00058FB0 File Offset: 0x000571B0
			internal static void C4VqRGr6LOwJA3RqMSs()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000BBD RID: 3005 RVA: 0x00058FC0 File Offset: 0x000571C0
			internal static bool UpAbgRr7LGVaB9v1dxy()
			{
				return ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.Pk7EfrrrVmxnyl1Zbmu == null;
			}

			// Token: 0x06000BBE RID: 3006 RVA: 0x00058FD4 File Offset: 0x000571D4
			internal static ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu X1wdcpr2VwhGlGal0uB()
			{
				return ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu.Pk7EfrrrVmxnyl1Zbmu;
			}

			// Token: 0x06000BBF RID: 3007 RVA: 0x00058FE4 File Offset: 0x000571E4
			internal static object FsLqGTrN4P8a5JKXKZb(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000BC0 RID: 3008 RVA: 0x00058FF8 File Offset: 0x000571F8
			internal static void jpCyewrnfc7YxBSynCA(object A_0, object A_1)
			{
				A_0.xZMdRwMHqP(A_1);
			}

			// Token: 0x06000BC1 RID: 3009 RVA: 0x00059010 File Offset: 0x00057210
			internal static object UyRTH1r0euMy09qkW30(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000BC2 RID: 3010 RVA: 0x00059028 File Offset: 0x00057228
			internal static bool IZEoIFrJr6djI8jyWwh(object A_0)
			{
				return A_0.y9QdwWY3Xc();
			}

			// Token: 0x040003CE RID: 974
			private ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F ktEij0hQ7y;

			// Token: 0x040003CF RID: 975
			internal int XnLiabPSAI;

			// Token: 0x040003D0 RID: 976
			internal static ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu Pk7EfrrrVmxnyl1Zbmu;
		}

		// Token: 0x0200007B RID: 123
		internal class Bt9yJsufERU9xtb39mw : ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR
		{
			// Token: 0x06000BC3 RID: 3011 RVA: 0x0005903C File Offset: 0x0005723C
			public Bt9yJsufERU9xtb39mw(int \u0020, Array \u0020)
			{
				ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.Lxusp6rYo5o1PFHBSRc();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.mxvihJLQi8 = \u0020;
						num = 2;
						if (true)
						{
							num = 2;
							continue;
						}
						continue;
					case 2:
					{
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)7;
						int num2 = 3;
						num = num2;
						continue;
					}
					case 3:
						return;
					}
					this.TZdiwHdyok = \u0020;
					num = 0;
					if (!false)
					{
						num = 1;
					}
				}
			}

			// Token: 0x06000BC4 RID: 3012 RVA: 0x000590F4 File Offset: 0x000572F4
			internal override IntPtr kBGdTuP4Wf()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000BC5 RID: 3013 RVA: 0x00059104 File Offset: 0x00057304
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.xZMdRwMHqP(\u0020);
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.ASG1UCrHJLvh0LneXtq())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						if (!(\u0020 is ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw))
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.qh5eS2rtqqbREyK4S7K() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							this.TZdiwHdyok = ((ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw)\u0020).TZdiwHdyok;
							num2 = 3;
							if (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.qh5eS2rtqqbREyK4S7K() != null)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						break;
					case 3:
						this.mxvihJLQi8 = ((ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw)\u0020).mxvihJLQi8;
						num2 = 4;
						if (!ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.ASG1UCrHJLvh0LneXtq())
						{
							num2 = 3;
							continue;
						}
						continue;
					case 4:
						return;
					}
					break;
				}
			}

			// Token: 0x06000BC6 RID: 3014 RVA: 0x000591F0 File Offset: 0x000573F0
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.xZMdRwMHqP(\u0020);
			}

			// Token: 0x06000BC7 RID: 3015 RVA: 0x00059208 File Offset: 0x00057408
			internal override void xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.hYnhM4rgW34mmfJQFGt(this.TZdiwHdyok, ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.cm9M5crs6TDbOypXjMu(\u0020, null), this.mxvihJLQi8);
			}

			// Token: 0x06000BC8 RID: 3016 RVA: 0x00059230 File Offset: 0x00057430
			internal override object y9jq31urLD(Type \u0020)
			{
				return ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.cm9M5crs6TDbOypXjMu(ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.kEVqWorXkUQMTSLA85H(this), \u0020);
			}

			// Token: 0x06000BC9 RID: 3017 RVA: 0x00059248 File Offset: 0x00057448
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(this.TZdiwHdyok.GetType().GetElementType(), this.TZdiwHdyok.GetValue(this.mxvihJLQi8));
			}

			// Token: 0x06000BCA RID: 3018 RVA: 0x00059278 File Offset: 0x00057478
			internal override bool y9QdwWY3Xc()
			{
				return ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.zO7kRIrMHmGwX8uEn7B(this.s9Cd9Og84k());
			}

			// Token: 0x06000BCB RID: 3019 RVA: 0x0005928C File Offset: 0x0005748C
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (\u0020.TB5dFM9QIv())
				{
					if (\u0020 is ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw)
					{
						goto IL_D4;
					}
					int num = 0;
					if (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.ASG1UCrHJLvh0LneXtq())
					{
						num = 0;
					}
					ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw bt9yJsufERU9xtb39mw;
					for (;;)
					{
						IL_10:
						switch (num)
						{
						case 1:
							return false;
						case 2:
							if (bt9yJsufERU9xtb39mw.mxvihJLQi8 != this.mxvihJLQi8)
							{
								num = 4;
								continue;
							}
							if (bt9yJsufERU9xtb39mw.TZdiwHdyok == this.TZdiwHdyok)
							{
								return true;
							}
							num = 1;
							if (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.qh5eS2rtqqbREyK4S7K() == null)
							{
								num = 1;
								continue;
							}
							continue;
						case 3:
							goto IL_D4;
						case 4:
							return false;
						}
						break;
					}
					return false;
					IL_D4:
					bt9yJsufERU9xtb39mw = (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw)\u0020;
					num = 2;
					goto IL_10;
				}
				return false;
			}

			// Token: 0x06000BCC RID: 3020 RVA: 0x00059380 File Offset: 0x00057580
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw bt9yJsufERU9xtb39mw;
						switch (num2)
						{
						case 0:
							goto IL_C0;
						case 1:
							if (!ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.oVSvL9rGoV7jh2u9qyy(\u0020))
							{
								return true;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.qh5eS2rtqqbREyK4S7K() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 2:
							if (bt9yJsufERU9xtb39mw.mxvihJLQi8 != this.mxvihJLQi8)
							{
								return true;
							}
							if (bt9yJsufERU9xtb39mw.TZdiwHdyok != this.TZdiwHdyok)
							{
								num2 = 5;
								continue;
							}
							return false;
						case 3:
							return true;
						case 4:
							break;
						case 5:
							return true;
						default:
							goto IL_C0;
						}
						IL_52:
						bt9yJsufERU9xtb39mw = (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw)\u0020;
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.ASG1UCrHJLvh0LneXtq())
						{
							num2 = 2;
							continue;
						}
						continue;
						IL_C0:
						if (!(\u0020 is ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw))
						{
							break;
						}
						goto IL_52;
					}
					num = 3;
				}
				return true;
			}

			// Token: 0x06000BCD RID: 3021 RVA: 0x00059484 File Offset: 0x00057684
			internal override bool lPSqCCLN7S()
			{
				return this.s9Cd9Og84k().lPSqCCLN7S();
			}

			// Token: 0x06000BCE RID: 3022 RVA: 0x00059498 File Offset: 0x00057698
			// Note: this type is marked as 'beforefieldinit'.
			static Bt9yJsufERU9xtb39mw()
			{
				ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.PDOsLKrBIPoQm0fE7LV();
			}

			// Token: 0x06000BCF RID: 3023 RVA: 0x000594A8 File Offset: 0x000576A8
			internal static void Lxusp6rYo5o1PFHBSRc()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000BD0 RID: 3024 RVA: 0x000594B8 File Offset: 0x000576B8
			internal static bool ASG1UCrHJLvh0LneXtq()
			{
				return ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.dHXrh7rmDqBGbJxn7mL == null;
			}

			// Token: 0x06000BD1 RID: 3025 RVA: 0x000594CC File Offset: 0x000576CC
			internal static ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw qh5eS2rtqqbREyK4S7K()
			{
				return ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw.dHXrh7rmDqBGbJxn7mL;
			}

			// Token: 0x06000BD2 RID: 3026 RVA: 0x000594DC File Offset: 0x000576DC
			internal static object cm9M5crs6TDbOypXjMu(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000BD3 RID: 3027 RVA: 0x000594F4 File Offset: 0x000576F4
			internal static void hYnhM4rgW34mmfJQFGt(object A_0, object A_1, int A_2)
			{
				A_0.SetValue(A_1, A_2);
			}

			// Token: 0x06000BD4 RID: 3028 RVA: 0x00059510 File Offset: 0x00057710
			internal static object kEVqWorXkUQMTSLA85H(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000BD5 RID: 3029 RVA: 0x00059524 File Offset: 0x00057724
			internal static bool zO7kRIrMHmGwX8uEn7B(object A_0)
			{
				return A_0.y9QdwWY3Xc();
			}

			// Token: 0x06000BD6 RID: 3030 RVA: 0x00059538 File Offset: 0x00057738
			internal static bool oVSvL9rGoV7jh2u9qyy(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000BD7 RID: 3031 RVA: 0x0005954C File Offset: 0x0005774C
			internal static void PDOsLKrBIPoQm0fE7LV()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003D1 RID: 977
			private Array TZdiwHdyok;

			// Token: 0x040003D2 RID: 978
			internal int mxvihJLQi8;

			// Token: 0x040003D3 RID: 979
			internal static ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw dHXrh7rmDqBGbJxn7mL;
		}

		// Token: 0x0200007C RID: 124
		internal class mA48iBuFQonZePrECIu : ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR
		{
			// Token: 0x06000BD8 RID: 3032 RVA: 0x0005955C File Offset: 0x0005775C
			public mA48iBuFQonZePrECIu(FieldInfo \u0020, object \u0020)
			{
				ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.tu7YPvrbnt6Pb9TWBtq();
				ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.wx8TOerzZkeGjOr9EPy();
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.PDaii2T9cI = \u0020;
						num = 3;
						break;
					case 1:
						return;
					case 2:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)7;
						num = 1;
						if (!true)
						{
							num = 0;
						}
						break;
					case 3:
						this.sYUi5K28CZ = \u0020;
						num = 2;
						if (false)
						{
							num = 2;
						}
						break;
					}
				}
			}

			// Token: 0x06000BD9 RID: 3033 RVA: 0x00059610 File Offset: 0x00057810
			internal override IntPtr kBGdTuP4Wf()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000BDA RID: 3034 RVA: 0x00059620 File Offset: 0x00057820
			internal override void xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_37;
					case 1:
						if (this.sYUi5K28CZ == null)
						{
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.PJtKhqrvRA7uFI1QwN0())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						break;
					case 2:
						break;
					case 3:
						return;
					case 4:
						ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.X7jEdg7P860rux14u2u(this.PDaii2T9cI, ((ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC)this.sYUi5K28CZ).y9jq31urLD(null), ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.LwLDqp7WxcJQoJIYoo1(\u0020, null));
						num2 = 3;
						continue;
					}
					if (!(this.sYUi5K28CZ is ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC))
					{
						break;
					}
					num2 = 4;
				}
				IL_37:
				this.PDaii2T9cI.SetValue(this.sYUi5K28CZ, ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.LwLDqp7WxcJQoJIYoo1(\u0020, null));
			}

			// Token: 0x06000BDB RID: 3035 RVA: 0x00059710 File Offset: 0x00057910
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						this.sYUi5K28CZ = ((ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu)\u0020).sYUi5K28CZ;
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.PJtKhqrvRA7uFI1QwN0())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_94;
					case 3:
						goto IL_85;
					case 4:
						if (!(\u0020 is ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu))
						{
							num2 = 3;
							continue;
						}
						goto IL_94;
					}
					break;
					IL_94:
					this.PDaii2T9cI = ((ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu)\u0020).PDaii2T9cI;
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.PJtKhqrvRA7uFI1QwN0())
					{
						num2 = 1;
					}
				}
				return;
				IL_85:
				ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.xWsAyc7EOli69OLRIO9(this, \u0020);
			}

			// Token: 0x06000BDC RID: 3036 RVA: 0x000597DC File Offset: 0x000579DC
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.xWsAyc7EOli69OLRIO9(this, \u0020);
			}

			// Token: 0x06000BDD RID: 3037 RVA: 0x000597F8 File Offset: 0x000579F8
			internal override object y9jq31urLD(Type \u0020)
			{
				return ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.F4kt4d7cGOwJxnsa5FC(this).y9jq31urLD(\u0020);
			}

			// Token: 0x06000BDE RID: 3038 RVA: 0x00059810 File Offset: 0x00057A10
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_2F;
					case 2:
						if (this.sYUi5K28CZ == null)
						{
							goto IL_90;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.Ulcd7frjAepcfx4TGg3() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				goto IL_63;
				IL_2F:
				if (!(this.sYUi5K28CZ is ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC))
				{
					goto IL_90;
				}
				IL_63:
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.N6DHWy75A7AysjjTSP4(this.PDaii2T9cI), ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.Mq6k7T7x9GnWPTMlIpO(this.PDaii2T9cI, ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.LwLDqp7WxcJQoJIYoo1((ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC)this.sYUi5K28CZ, null)));
				IL_90:
				return ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.lCaWx07uQqsxP4SS7QW(ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.N6DHWy75A7AysjjTSP4(this.PDaii2T9cI), ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.Mq6k7T7x9GnWPTMlIpO(this.PDaii2T9cI, this.sYUi5K28CZ));
			}

			// Token: 0x06000BDF RID: 3039 RVA: 0x000598F4 File Offset: 0x00057AF4
			internal override bool y9QdwWY3Xc()
			{
				return ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.juDjAt7V7sCOqhG5Pmb(ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.F4kt4d7cGOwJxnsa5FC(this));
			}

			// Token: 0x06000BE0 RID: 3040 RVA: 0x00059908 File Offset: 0x00057B08
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu mA48iBuFQonZePrECIu;
					switch (num2)
					{
					case 1:
						if (\u0020.TB5dFM9QIv())
						{
							goto IL_5E;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.Ulcd7frjAepcfx4TGg3() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_DC;
					case 3:
						return false;
					case 4:
						goto IL_5E;
					case 5:
						if (mA48iBuFQonZePrECIu.PDaii2T9cI != this.PDaii2T9cI)
						{
							return false;
						}
						if (mA48iBuFQonZePrECIu.sYUi5K28CZ != this.sYUi5K28CZ)
						{
							num2 = 3;
							continue;
						}
						return true;
					case 6:
						return false;
					}
					break;
					IL_5E:
					if (!(\u0020 is ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu))
					{
						num2 = 6;
						if (!ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.PJtKhqrvRA7uFI1QwN0())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					IL_DC:
					mA48iBuFQonZePrECIu = (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu)\u0020;
					num2 = 5;
				}
				return false;
			}

			// Token: 0x06000BE1 RID: 3041 RVA: 0x00059A30 File Offset: 0x00057C30
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						return true;
					case 1:
						if (!(\u0020 is ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu))
						{
							return true;
						}
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.PJtKhqrvRA7uFI1QwN0())
						{
							num2 = 4;
						}
						break;
					case 2:
						if (!ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.WBfU9l7ywSXGEQ7MiBb(\u0020))
						{
							return true;
						}
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.PJtKhqrvRA7uFI1QwN0())
						{
							num2 = 1;
						}
						break;
					case 3:
						return true;
					case 4:
					{
						ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu mA48iBuFQonZePrECIu = (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu)\u0020;
						if (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.JC4fGU78P8SW3Cfq4oq(mA48iBuFQonZePrECIu.PDaii2T9cI, this.PDaii2T9cI))
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.Ulcd7frjAepcfx4TGg3() != null)
							{
								num2 = 0;
							}
						}
						else
						{
							if (mA48iBuFQonZePrECIu.sYUi5K28CZ == this.sYUi5K28CZ)
							{
								return false;
							}
							num2 = 3;
							if (!ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.PJtKhqrvRA7uFI1QwN0())
							{
								num2 = 2;
							}
						}
						break;
					}
					}
				}
				return true;
			}

			// Token: 0x06000BE2 RID: 3042 RVA: 0x00059B34 File Offset: 0x00057D34
			internal override bool lPSqCCLN7S()
			{
				return ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.F4kt4d7cGOwJxnsa5FC(this).lPSqCCLN7S();
			}

			// Token: 0x06000BE3 RID: 3043 RVA: 0x00059B48 File Offset: 0x00057D48
			// Note: this type is marked as 'beforefieldinit'.
			static mA48iBuFQonZePrECIu()
			{
				ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.Xkb8vG7q4hOs0kHwJxx();
			}

			// Token: 0x06000BE4 RID: 3044 RVA: 0x00059B58 File Offset: 0x00057D58
			internal static void tu7YPvrbnt6Pb9TWBtq()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000BE5 RID: 3045 RVA: 0x00059B68 File Offset: 0x00057D68
			internal static void wx8TOerzZkeGjOr9EPy()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000BE6 RID: 3046 RVA: 0x00059B78 File Offset: 0x00057D78
			internal static bool PJtKhqrvRA7uFI1QwN0()
			{
				return ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.sksX6JrDREmsNexB9kC == null;
			}

			// Token: 0x06000BE7 RID: 3047 RVA: 0x00059B8C File Offset: 0x00057D8C
			internal static ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu Ulcd7frjAepcfx4TGg3()
			{
				return ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu.sksX6JrDREmsNexB9kC;
			}

			// Token: 0x06000BE8 RID: 3048 RVA: 0x00059B9C File Offset: 0x00057D9C
			internal static object LwLDqp7WxcJQoJIYoo1(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000BE9 RID: 3049 RVA: 0x00059BB4 File Offset: 0x00057DB4
			internal static void X7jEdg7P860rux14u2u(object A_0, object A_1, object A_2)
			{
				A_0.SetValue(A_1, A_2);
			}

			// Token: 0x06000BEA RID: 3050 RVA: 0x00059BD0 File Offset: 0x00057DD0
			internal static void xWsAyc7EOli69OLRIO9(object A_0, object A_1)
			{
				A_0.xZMdRwMHqP(A_1);
			}

			// Token: 0x06000BEB RID: 3051 RVA: 0x00059BE8 File Offset: 0x00057DE8
			internal static object F4kt4d7cGOwJxnsa5FC(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000BEC RID: 3052 RVA: 0x00059BFC File Offset: 0x00057DFC
			internal static Type N6DHWy75A7AysjjTSP4(object A_0)
			{
				return A_0.FieldType;
			}

			// Token: 0x06000BED RID: 3053 RVA: 0x00059C10 File Offset: 0x00057E10
			internal static object Mq6k7T7x9GnWPTMlIpO(object A_0, object A_1)
			{
				return A_0.GetValue(A_1);
			}

			// Token: 0x06000BEE RID: 3054 RVA: 0x00059C28 File Offset: 0x00057E28
			internal static object lCaWx07uQqsxP4SS7QW(Type \u0020, object A_1)
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(\u0020, A_1);
			}

			// Token: 0x06000BEF RID: 3055 RVA: 0x00059C40 File Offset: 0x00057E40
			internal static bool juDjAt7V7sCOqhG5Pmb(object A_0)
			{
				return A_0.y9QdwWY3Xc();
			}

			// Token: 0x06000BF0 RID: 3056 RVA: 0x00059C54 File Offset: 0x00057E54
			internal static bool WBfU9l7ywSXGEQ7MiBb(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000BF1 RID: 3057 RVA: 0x00059C68 File Offset: 0x00057E68
			internal static bool JC4fGU78P8SW3Cfq4oq(object A_0, object A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000BF2 RID: 3058 RVA: 0x00059C80 File Offset: 0x00057E80
			internal static void Xkb8vG7q4hOs0kHwJxx()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003D4 RID: 980
			internal FieldInfo PDaii2T9cI;

			// Token: 0x040003D5 RID: 981
			internal object sYUi5K28CZ;

			// Token: 0x040003D6 RID: 982
			private static ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu sksX6JrDREmsNexB9kC;
		}

		// Token: 0x0200007D RID: 125
		internal class RkaCwuuTDIa2A6Qvy0B : ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR
		{
			// Token: 0x06000BF3 RID: 3059 RVA: 0x00059C90 File Offset: 0x00057E90
			public RkaCwuuTDIa2A6Qvy0B(int \u0020, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.QtpaDM7QPFVNqbZmFbt();
				base..ctor();
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)7;
						num = 0;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						this.LDvilbegjf = \u0020;
						num = 1;
						if (!true)
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
						this.QyFiA2gEDK = \u0020;
						num = 2;
						continue;
					}
					break;
				}
			}

			// Token: 0x06000BF4 RID: 3060 RVA: 0x00059D38 File Offset: 0x00057F38
			internal override IntPtr kBGdTuP4Wf()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000BF5 RID: 3061 RVA: 0x00059D48 File Offset: 0x00057F48
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (\u0020 is ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B)
				{
					goto IL_88;
				}
				ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.BRpI9B7CMycBtFtdDny(this, \u0020);
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.Ea3exc7oIRQmkxqZJdg())
				{
					num = 1;
				}
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.LDvilbegjf = ((ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B)\u0020).LDvilbegjf;
						num = 3;
						if (ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.UbiEYm73iPvt6mTIInP() != null)
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
						return;
					}
					break;
				}
				IL_88:
				this.QyFiA2gEDK = ((ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B)\u0020).QyFiA2gEDK;
				num = 1;
				if (ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.UbiEYm73iPvt6mTIInP() == null)
				{
					num = 2;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000BF6 RID: 3062 RVA: 0x00059E28 File Offset: 0x00058028
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.BRpI9B7CMycBtFtdDny(this, \u0020);
			}

			// Token: 0x06000BF7 RID: 3063 RVA: 0x00059E44 File Offset: 0x00058044
			internal override void xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.QyFiA2gEDK.XZ2lKJZI20[this.LDvilbegjf] = \u0020;
			}

			// Token: 0x06000BF8 RID: 3064 RVA: 0x00059E6C File Offset: 0x0005806C
			internal override object y9jq31urLD(Type \u0020)
			{
				if (this.QyFiA2gEDK.XZ2lKJZI20[this.LDvilbegjf] != null)
				{
					return this.s9Cd9Og84k().y9jq31urLD(\u0020);
				}
				return null;
			}

			// Token: 0x06000BF9 RID: 3065 RVA: 0x00059EE0 File Offset: 0x000580E0
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				if (this.QyFiA2gEDK.XZ2lKJZI20[this.LDvilbegjf] != null)
				{
					return ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.PBPEmp796p0PQJW1hAC(this.QyFiA2gEDK.XZ2lKJZI20[this.LDvilbegjf]);
				}
				return new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
			}

			// Token: 0x06000BFA RID: 3066 RVA: 0x00059F64 File Offset: 0x00058164
			internal override bool y9QdwWY3Xc()
			{
				return this.s9Cd9Og84k().y9QdwWY3Xc();
			}

			// Token: 0x06000BFB RID: 3067 RVA: 0x00059F78 File Offset: 0x00058178
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_2F;
					case 1:
						return false;
					case 2:
						if (\u0020.TB5dFM9QIv())
						{
							goto IL_2F;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.UbiEYm73iPvt6mTIInP() != null)
						{
							num2 = 1;
						}
						break;
					}
				}
				IL_2F:
				return \u0020 is ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B && ((ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B)\u0020).LDvilbegjf == this.LDvilbegjf;
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x0005A020 File Offset: 0x00058220
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.h9PisY7woqC4rEO30t2(\u0020))
				{
					return true;
				}
				while (!(\u0020 is ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B))
				{
					int num = 0;
					if (ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.UbiEYm73iPvt6mTIInP() == null)
					{
						num = 0;
					}
					switch (num)
					{
					case 1:
						goto IL_26;
					case 2:
						continue;
					}
					return true;
				}
				IL_26:
				return ((ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B)\u0020).LDvilbegjf != this.LDvilbegjf;
			}

			// Token: 0x06000BFD RID: 3069 RVA: 0x0005A0D0 File Offset: 0x000582D0
			internal override bool lPSqCCLN7S()
			{
				return ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.UGifsf7AbWWhDo1KD9h(this.s9Cd9Og84k());
			}

			// Token: 0x06000BFE RID: 3070 RVA: 0x0005A0E4 File Offset: 0x000582E4
			// Note: this type is marked as 'beforefieldinit'.
			static RkaCwuuTDIa2A6Qvy0B()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x06000BFF RID: 3071 RVA: 0x0005A0F4 File Offset: 0x000582F4
			internal static void QtpaDM7QPFVNqbZmFbt()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000C00 RID: 3072 RVA: 0x0005A104 File Offset: 0x00058304
			internal static bool Ea3exc7oIRQmkxqZJdg()
			{
				return ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.bWCn9h7diTha1Hd5bun == null;
			}

			// Token: 0x06000C01 RID: 3073 RVA: 0x0005A118 File Offset: 0x00058318
			internal static ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B UbiEYm73iPvt6mTIInP()
			{
				return ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B.bWCn9h7diTha1Hd5bun;
			}

			// Token: 0x06000C02 RID: 3074 RVA: 0x0005A128 File Offset: 0x00058328
			internal static void BRpI9B7CMycBtFtdDny(object A_0, object A_1)
			{
				A_0.xZMdRwMHqP(A_1);
			}

			// Token: 0x06000C03 RID: 3075 RVA: 0x0005A140 File Offset: 0x00058340
			internal static object PBPEmp796p0PQJW1hAC(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000C04 RID: 3076 RVA: 0x0005A154 File Offset: 0x00058354
			internal static bool h9PisY7woqC4rEO30t2(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000C05 RID: 3077 RVA: 0x0005A168 File Offset: 0x00058368
			internal static bool UGifsf7AbWWhDo1KD9h(object A_0)
			{
				return A_0.lPSqCCLN7S();
			}

			// Token: 0x040003D7 RID: 983
			private ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F QyFiA2gEDK;

			// Token: 0x040003D8 RID: 984
			internal int LDvilbegjf;

			// Token: 0x040003D9 RID: 985
			internal static ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B bWCn9h7diTha1Hd5bun;
		}

		// Token: 0x0200007E RID: 126
		internal class oiOGyvuRphUunetu60N : ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR
		{
			// Token: 0x06000C06 RID: 3078 RVA: 0x0005A17C File Offset: 0x0005837C
			public oiOGyvuRphUunetu60N(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020, Type \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.yiA7Qp7irBtSBRc1e7V();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 1:
						return;
					case 2:
						this.cUCiQvZopx = \u0020;
						num = 0;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					case 3:
						this.oLBiUePZ2P = \u0020;
						num = 2;
						continue;
					}
					this.XyUUA5Idue = (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)7;
					num = 0;
					if (true)
					{
						num = 1;
					}
				}
			}

			// Token: 0x06000C07 RID: 3079 RVA: 0x0005A224 File Offset: 0x00058424
			internal override IntPtr kBGdTuP4Wf()
			{
				throw new NotImplementedException();
			}

			// Token: 0x06000C08 RID: 3080 RVA: 0x0005A234 File Offset: 0x00058434
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (\u0020 is ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N)
				{
					goto IL_71;
				}
				ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.hV5a5H7ZF12ZBgglyHV(this.oLBiUePZ2P, \u0020);
				int num = 1;
				if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.YE7lFZ7IGx3XaqKIQfp() != null)
				{
					num = 0;
				}
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						return;
					case 2:
						return;
					case 3:
						goto IL_71;
					}
					this.oLBiUePZ2P = ((ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N)\u0020).oLBiUePZ2P;
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.YE7lFZ7IGx3XaqKIQfp() == null)
					{
						num = 2;
					}
				}
				return;
				IL_71:
				this.cUCiQvZopx = ((ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N)\u0020).cUCiQvZopx;
				num = 0;
				if (!ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.CWbl9Q7SKYDMEgB2wEW())
				{
					num = 0;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000C09 RID: 3081 RVA: 0x0005A308 File Offset: 0x00058508
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.wJt2MJ7UGo2BatDg6xv(this, \u0020);
			}

			// Token: 0x06000C0A RID: 3082 RVA: 0x0005A320 File Offset: 0x00058520
			internal override void xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.oLBiUePZ2P = \u0020;
			}

			// Token: 0x06000C0B RID: 3083 RVA: 0x0005A33C File Offset: 0x0005853C
			internal override object y9jq31urLD(Type \u0020)
			{
				if (this.oLBiUePZ2P == null)
				{
					return new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
				}
				if (!ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.OsaSXY71j8RCPsudl7Y(\u0020, null))
				{
					int num = 1;
					if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.CWbl9Q7SKYDMEgB2wEW())
					{
						num = 1;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							if (!(\u0020 == ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.fwvoRw74SxjdeNEwjPV(ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.UDHTKf7pC5qFtOVXiPO(16777236))))
							{
								goto IL_71;
							}
							num = 0;
							if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.YE7lFZ7IGx3XaqKIQfp() != null)
							{
								num = 0;
								continue;
							}
							continue;
						}
						break;
					}
					goto IL_5F;
					IL_71:
					return ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.DNoGZp7OD9POPq2jNJR(this.oLBiUePZ2P, \u0020);
				}
				IL_5F:
				return ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.DNoGZp7OD9POPq2jNJR(this.oLBiUePZ2P, this.cUCiQvZopx);
			}

			// Token: 0x06000C0C RID: 3084 RVA: 0x0005A3FC File Offset: 0x000585FC
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (this.oLBiUePZ2P == null)
						{
							goto IL_5A;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.YE7lFZ7IGx3XaqKIQfp() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				return ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.iA2eWG7fU59JFqvlkQ7(this.oLBiUePZ2P);
				IL_5A:
				return new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
			}

			// Token: 0x06000C0D RID: 3085 RVA: 0x0005A478 File Offset: 0x00058678
			internal override bool y9QdwWY3Xc()
			{
				return this.s9Cd9Og84k().y9QdwWY3Xc();
			}

			// Token: 0x06000C0E RID: 3086 RVA: 0x0005A48C File Offset: 0x0005868C
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.UdZ4bC7FlLCDF0kI92j(\u0020))
				{
					return false;
				}
				if (\u0020 is ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N)
				{
					int num = 3;
					ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N oiOGyvuRphUunetu60N;
					for (;;)
					{
						switch (num)
						{
						case 1:
							return true;
						case 2:
							if (oiOGyvuRphUunetu60N.oLBiUePZ2P != null)
							{
								return false;
							}
							num = 1;
							if (!ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.CWbl9Q7SKYDMEgB2wEW())
							{
								num = 0;
								continue;
							}
							continue;
						case 3:
							oiOGyvuRphUunetu60N = (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N)\u0020;
							num = 0;
							if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.YE7lFZ7IGx3XaqKIQfp() == null)
							{
								num = 0;
								continue;
							}
							continue;
						case 4:
							return false;
						}
						if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.Q5kiyU7Tx4vnARZInhr(oiOGyvuRphUunetu60N.cUCiQvZopx, this.cUCiQvZopx))
						{
							num = 4;
						}
						else
						{
							if (this.oLBiUePZ2P != null)
							{
								goto IL_32;
							}
							num = 2;
						}
					}
					return true;
					IL_32:
					return ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.MNVtkJ7RvKKa9UXBsLP(this.oLBiUePZ2P, oiOGyvuRphUunetu60N.oLBiUePZ2P);
				}
				return false;
			}

			// Token: 0x06000C0F RID: 3087 RVA: 0x0005A588 File Offset: 0x00058788
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N oiOGyvuRphUunetu60N;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_134;
					case 1:
						return true;
					case 2:
						if (!\u0020.TB5dFM9QIv())
						{
							num2 = 1;
							if (!ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.CWbl9Q7SKYDMEgB2wEW())
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							if (\u0020 is ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N)
							{
								goto IL_134;
							}
							num2 = 4;
							if (!ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.CWbl9Q7SKYDMEgB2wEW())
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						break;
					case 3:
						if (this.oLBiUePZ2P != null)
						{
							goto Block_10;
						}
						break;
					case 4:
						return true;
					case 5:
						return true;
					case 6:
						break;
					case 7:
						return true;
					case 8:
						if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.Q5kiyU7Tx4vnARZInhr(oiOGyvuRphUunetu60N.cUCiQvZopx, this.cUCiQvZopx))
						{
							return true;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.CWbl9Q7SKYDMEgB2wEW())
						{
							num2 = 3;
							continue;
						}
						continue;
					default:
						goto IL_134;
					}
					if (oiOGyvuRphUunetu60N.oLBiUePZ2P != null)
					{
						num2 = 7;
						continue;
					}
					return false;
					IL_134:
					oiOGyvuRphUunetu60N = (ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N)\u0020;
					num2 = 8;
					if (!ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.CWbl9Q7SKYDMEgB2wEW())
					{
						num2 = 5;
					}
				}
				return true;
				Block_10:
				return this.oLBiUePZ2P.g5sdhSCwCu(oiOGyvuRphUunetu60N.oLBiUePZ2P);
			}

			// Token: 0x06000C10 RID: 3088 RVA: 0x0005A708 File Offset: 0x00058908
			internal override bool lPSqCCLN7S()
			{
				return ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.IQRPj17LNn2y2nZB3cK(ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.iA2eWG7fU59JFqvlkQ7(this));
			}

			// Token: 0x06000C11 RID: 3089 RVA: 0x0005A71C File Offset: 0x0005891C
			// Note: this type is marked as 'beforefieldinit'.
			static oiOGyvuRphUunetu60N()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x06000C12 RID: 3090 RVA: 0x0005A72C File Offset: 0x0005892C
			internal static void yiA7Qp7irBtSBRc1e7V()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000C13 RID: 3091 RVA: 0x0005A73C File Offset: 0x0005893C
			internal static bool CWbl9Q7SKYDMEgB2wEW()
			{
				return ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.tuHSse7hffnyXx1jMnC == null;
			}

			// Token: 0x06000C14 RID: 3092 RVA: 0x0005A750 File Offset: 0x00058950
			internal static ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N YE7lFZ7IGx3XaqKIQfp()
			{
				return ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N.tuHSse7hffnyXx1jMnC;
			}

			// Token: 0x06000C15 RID: 3093 RVA: 0x0005A760 File Offset: 0x00058960
			internal static void hV5a5H7ZF12ZBgglyHV(object A_0, object A_1)
			{
				A_0.AxwqVJ6XV5(A_1);
			}

			// Token: 0x06000C16 RID: 3094 RVA: 0x0005A778 File Offset: 0x00058978
			internal static void wJt2MJ7UGo2BatDg6xv(object A_0, object A_1)
			{
				A_0.xZMdRwMHqP(A_1);
			}

			// Token: 0x06000C17 RID: 3095 RVA: 0x0005A790 File Offset: 0x00058990
			internal static bool OsaSXY71j8RCPsudl7Y(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000C18 RID: 3096 RVA: 0x0005A7A8 File Offset: 0x000589A8
			internal static RuntimeTypeHandle UDHTKf7pC5qFtOVXiPO(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000C19 RID: 3097 RVA: 0x0005A7BC File Offset: 0x000589BC
			internal static Type fwvoRw74SxjdeNEwjPV(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x0005A7D0 File Offset: 0x000589D0
			internal static object DNoGZp7OD9POPq2jNJR(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x0005A7E8 File Offset: 0x000589E8
			internal static object iA2eWG7fU59JFqvlkQ7(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000C1C RID: 3100 RVA: 0x0005A7FC File Offset: 0x000589FC
			internal static bool UdZ4bC7FlLCDF0kI92j(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000C1D RID: 3101 RVA: 0x0005A810 File Offset: 0x00058A10
			internal static bool Q5kiyU7Tx4vnARZInhr(Type A_0, Type A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000C1E RID: 3102 RVA: 0x0005A828 File Offset: 0x00058A28
			internal static bool MNVtkJ7RvKKa9UXBsLP(object A_0, object A_1)
			{
				return A_0.ovDdASrPUT(A_1);
			}

			// Token: 0x06000C1F RID: 3103 RVA: 0x0005A840 File Offset: 0x00058A40
			internal static bool IQRPj17LNn2y2nZB3cK(object A_0)
			{
				return A_0.lPSqCCLN7S();
			}

			// Token: 0x040003DA RID: 986
			private ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC oLBiUePZ2P;

			// Token: 0x040003DB RID: 987
			private Type cUCiQvZopx;

			// Token: 0x040003DC RID: 988
			private static ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N tuHSse7hffnyXx1jMnC;
		}

		// Token: 0x0200007F RID: 127
		internal class YVW1xyuLADtgscreJRp
		{
			// Token: 0x06000C20 RID: 3104 RVA: 0x0005A854 File Offset: 0x00058A54
			public YVW1xyuLADtgscreJRp()
			{
				ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp.xMCBdA7eGprvRB8wa2u();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 0;
				if (!false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000C21 RID: 3105 RVA: 0x0005A8B0 File Offset: 0x00058AB0
			// Note: this type is marked as 'beforefieldinit'.
			static YVW1xyuLADtgscreJRp()
			{
				ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp.S6NOu97k7xMfuO8j2wX();
			}

			// Token: 0x06000C22 RID: 3106 RVA: 0x0005A8C0 File Offset: 0x00058AC0
			internal static void xMCBdA7eGprvRB8wa2u()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000C23 RID: 3107 RVA: 0x0005A8D0 File Offset: 0x00058AD0
			internal static bool nkG3AD7aUaQHwAb0UaT()
			{
				return ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp.e1hpbb7lKAOho65y6Ck == null;
			}

			// Token: 0x06000C24 RID: 3108 RVA: 0x0005A8E4 File Offset: 0x00058AE4
			internal static ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp khEsbe7KZfkPCgbg2RL()
			{
				return ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp.e1hpbb7lKAOho65y6Ck;
			}

			// Token: 0x06000C25 RID: 3109 RVA: 0x0005A8F4 File Offset: 0x00058AF4
			internal static void S6NOu97k7xMfuO8j2wX()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003DD RID: 989
			public int rpxidy7fkZ;

			// Token: 0x040003DE RID: 990
			public bool SDOi93ObSo;

			// Token: 0x040003DF RID: 991
			public ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ b6YiSr1Ws1;

			// Token: 0x040003E0 RID: 992
			internal static ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp e1hpbb7lKAOho65y6Ck;
		}

		// Token: 0x02000080 RID: 128
		internal class Uao91Iul5XdTuF01HB3
		{
			// Token: 0x06000C26 RID: 3110 RVA: 0x0005A904 File Offset: 0x00058B04
			public Uao91Iul5XdTuF01HB3()
			{
				ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3.HWMpqd76kOaovDVhOx9();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				this.Sy9iuWyJTO = ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3.kmBkXQ7Nwv0Usp5R8PG(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236));
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000C27 RID: 3111 RVA: 0x0005A97C File Offset: 0x00058B7C
			// Note: this type is marked as 'beforefieldinit'.
			static Uao91Iul5XdTuF01HB3()
			{
				ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3.Psgshk7n8PQYOGITGuX();
			}

			// Token: 0x06000C28 RID: 3112 RVA: 0x0005A98C File Offset: 0x00058B8C
			internal static void HWMpqd76kOaovDVhOx9()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000C29 RID: 3113 RVA: 0x0005A99C File Offset: 0x00058B9C
			internal static Type kmBkXQ7Nwv0Usp5R8PG(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000C2A RID: 3114 RVA: 0x0005A9B0 File Offset: 0x00058BB0
			internal static bool fWiHRV77QGr6RdyfU4f()
			{
				return ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3.bhsV3w7rnt36U2O8ybG == null;
			}

			// Token: 0x06000C2B RID: 3115 RVA: 0x0005A9C4 File Offset: 0x00058BC4
			internal static ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3 pfdn1e72uD7sRk772yT()
			{
				return ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3.bhsV3w7rnt36U2O8ybG;
			}

			// Token: 0x06000C2C RID: 3116 RVA: 0x0005A9D4 File Offset: 0x00058BD4
			internal static void Psgshk7n8PQYOGITGuX()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003E1 RID: 993
			public int RxQikAGpbV;

			// Token: 0x040003E2 RID: 994
			public ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ ob0itY7ilV;

			// Token: 0x040003E3 RID: 995
			public bool MnbiZVlnrv;

			// Token: 0x040003E4 RID: 996
			public Type Sy9iuWyJTO;

			// Token: 0x040003E5 RID: 997
			private static ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3 bhsV3w7rnt36U2O8ybG;
		}

		// Token: 0x02000081 RID: 129
		internal class O7BGFwuaTreTeXAneXP
		{
			// Token: 0x06000C2D RID: 3117 RVA: 0x0005A9E4 File Offset: 0x00058BE4
			public O7BGFwuaTreTeXAneXP()
			{
				ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP.oFAxmq7H3PiInxjCWfM();
				ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP.teA8kZ7ta0chxp5RHtE();
				base..ctor();
				int num = 0;
				if (!true)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000C2E RID: 3118 RVA: 0x0005AA40 File Offset: 0x00058C40
			// Note: this type is marked as 'beforefieldinit'.
			static O7BGFwuaTreTeXAneXP()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x06000C2F RID: 3119 RVA: 0x0005AA50 File Offset: 0x00058C50
			internal static void oFAxmq7H3PiInxjCWfM()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000C30 RID: 3120 RVA: 0x0005AA60 File Offset: 0x00058C60
			internal static void teA8kZ7ta0chxp5RHtE()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000C31 RID: 3121 RVA: 0x0005AA70 File Offset: 0x00058C70
			internal static bool U2wZK17JsOLoFCvBJlD()
			{
				return ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP.NxplM270QSuoxnS7B0T == null;
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x0005AA84 File Offset: 0x00058C84
			internal static ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP sHIQup7mewBp5GwVF2f()
			{
				return ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP.NxplM270QSuoxnS7B0T;
			}

			// Token: 0x040003E6 RID: 998
			public int CHVi7uox8r;

			// Token: 0x040003E7 RID: 999
			public int bOdiOkNrnU;

			// Token: 0x040003E8 RID: 1000
			public ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE aE6ioYbwF8;

			// Token: 0x040003E9 RID: 1001
			private static ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP NxplM270QSuoxnS7B0T;
		}

		// Token: 0x02000082 RID: 130
		internal class UvMdGKuKWaf5eqRkwyE
		{
			// Token: 0x06000C33 RID: 3123 RVA: 0x0005AA94 File Offset: 0x00058C94
			public UvMdGKuKWaf5eqRkwyE()
			{
				ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE.RHKgH07XScGCdiV8tqN();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 0;
				if (!true)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000C34 RID: 3124 RVA: 0x0005AAF0 File Offset: 0x00058CF0
			// Note: this type is marked as 'beforefieldinit'.
			static UvMdGKuKWaf5eqRkwyE()
			{
				ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE.XOvuJs7MBC8H1tgI8dt();
			}

			// Token: 0x06000C35 RID: 3125 RVA: 0x0005AB00 File Offset: 0x00058D00
			internal static void RHKgH07XScGCdiV8tqN()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000C36 RID: 3126 RVA: 0x0005AB10 File Offset: 0x00058D10
			internal static bool F4QC637sdNJpQAN4GCH()
			{
				return ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE.UluytQ7YJbWBn9HfY1J == null;
			}

			// Token: 0x06000C37 RID: 3127 RVA: 0x0005AB24 File Offset: 0x00058D24
			internal static ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE yHrmGa7gVmt0rTIL1VL()
			{
				return ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE.UluytQ7YJbWBn9HfY1J;
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x0005AB34 File Offset: 0x00058D34
			internal static void XOvuJs7MBC8H1tgI8dt()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003EA RID: 1002
			public int oe3ivl4Hb5;

			// Token: 0x040003EB RID: 1003
			public int ICtiRLSqEJ;

			// Token: 0x040003EC RID: 1004
			public byte bxTiNJ1kBv;

			// Token: 0x040003ED RID: 1005
			public Type fTxirp6Y0Y;

			// Token: 0x040003EE RID: 1006
			public int mK9ibJJLQ8;

			// Token: 0x040003EF RID: 1007
			public int HThiPAKxeR;

			// Token: 0x040003F0 RID: 1008
			internal static ykD11HxHfZBYH7OcFOG.UvMdGKuKWaf5eqRkwyE UluytQ7YJbWBn9HfY1J;
		}

		// Token: 0x02000083 RID: 131
		internal class E9EX5Muevt1JiiEXHHu
		{
			// Token: 0x06000C39 RID: 3129 RVA: 0x0005AB44 File Offset: 0x00058D44
			public E9EX5Muevt1JiiEXHHu()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu.GQq9OY7v3wkroYsmNEb();
				base..ctor();
				int num = 0;
				if (!true)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000C3A RID: 3130 RVA: 0x0005ABA0 File Offset: 0x00058DA0
			// Note: this type is marked as 'beforefieldinit'.
			static E9EX5Muevt1JiiEXHHu()
			{
				ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu.VoWYS47jIXdmcmZq5S5();
			}

			// Token: 0x06000C3B RID: 3131 RVA: 0x0005ABB0 File Offset: 0x00058DB0
			internal static void GQq9OY7v3wkroYsmNEb()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x0005ABC0 File Offset: 0x00058DC0
			internal static bool zDWYt77BGxF0XPgVQik()
			{
				return ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu.Ges1Tn7Griq4TU9fw2h == null;
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x0005ABD4 File Offset: 0x00058DD4
			internal static ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu vAbRDs7DgaakUikxPvT()
			{
				return ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu.Ges1Tn7Griq4TU9fw2h;
			}

			// Token: 0x06000C3E RID: 3134 RVA: 0x0005ABE4 File Offset: 0x00058DE4
			internal static void VoWYS47jIXdmcmZq5S5()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003F1 RID: 1009
			internal MethodBase tvNiDLeBvW;

			// Token: 0x040003F2 RID: 1010
			internal List<ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt> UAii4R1MbG;

			// Token: 0x040003F3 RID: 1011
			internal ykD11HxHfZBYH7OcFOG.YVW1xyuLADtgscreJRp[] C12iMMW3JJ;

			// Token: 0x040003F4 RID: 1012
			internal List<ykD11HxHfZBYH7OcFOG.Uao91Iul5XdTuF01HB3> u7wi6eANjd;

			// Token: 0x040003F5 RID: 1013
			internal List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> f0ViTMY9D3;

			// Token: 0x040003F6 RID: 1014
			private static ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu Ges1Tn7Griq4TU9fw2h;
		}

		// Token: 0x02000084 RID: 132
		private class nsVbPXukrvTsEUG8r1V
		{
			// Token: 0x06000C3F RID: 3135 RVA: 0x0005ABF4 File Offset: 0x00058DF4
			public nsVbPXukrvTsEUG8r1V(FieldInfo \u0020, int \u0020)
			{
				ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V.mjFiFt2Po3IGUvqcpOQ();
				ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V.m8t8wm2EeIVpY3EHmix();
				base..ctor();
				int num = 1;
				if (!true)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.cmFiXHaob9 = \u0020;
						num = 2;
						break;
					case 1:
						this.j2bieVonlD = \u0020;
						num = 0;
						if (false)
						{
							num = 0;
						}
						break;
					case 2:
						return;
					}
				}
			}

			// Token: 0x06000C40 RID: 3136 RVA: 0x0005AC88 File Offset: 0x00058E88
			// Note: this type is marked as 'beforefieldinit'.
			static nsVbPXukrvTsEUG8r1V()
			{
				ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V.EcGYGk2coyyGEDOOTKU();
			}

			// Token: 0x06000C41 RID: 3137 RVA: 0x0005AC98 File Offset: 0x00058E98
			internal static void mjFiFt2Po3IGUvqcpOQ()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000C42 RID: 3138 RVA: 0x0005ACA8 File Offset: 0x00058EA8
			internal static void m8t8wm2EeIVpY3EHmix()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000C43 RID: 3139 RVA: 0x0005ACB8 File Offset: 0x00058EB8
			internal static bool XtUDVt7zbJtSAOG4fOu()
			{
				return ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V.bViXIL7bdl3SQLBioX7 == null;
			}

			// Token: 0x06000C44 RID: 3140 RVA: 0x0005ACCC File Offset: 0x00058ECC
			internal static ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V NIfD8x2WfQRDC2PjGD2()
			{
				return ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V.bViXIL7bdl3SQLBioX7;
			}

			// Token: 0x06000C45 RID: 3141 RVA: 0x0005ACDC File Offset: 0x00058EDC
			internal static void EcGYGk2coyyGEDOOTKU()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003F7 RID: 1015
			internal FieldInfo j2bieVonlD;

			// Token: 0x040003F8 RID: 1016
			internal int cmFiXHaob9;

			// Token: 0x040003F9 RID: 1017
			private static ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V bViXIL7bdl3SQLBioX7;
		}

		// Token: 0x02000085 RID: 133
		private class HCp9nIur8g9pimJhW0s
		{
			// Token: 0x06000C46 RID: 3142 RVA: 0x0005ACEC File Offset: 0x00058EEC
			public HCp9nIur8g9pimJhW0s(MethodBase \u0020, List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V> \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				this.Tu1isE3rLC = new List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V>();
				base..ctor();
				this.Tu1isE3rLC = \u0020;
				this.JuWiq9C3Ff = \u0020;
			}

			// Token: 0x06000C47 RID: 3143 RVA: 0x0005AD20 File Offset: 0x00058F20
			public HCp9nIur8g9pimJhW0s(MethodBase \u0020, ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V[] \u0020)
			{
				ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.gPdCbo2V4EE25IJLiHD();
				ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.NDma512ysk17WilaUV1();
				this.Tu1isE3rLC = new List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V>();
				base..ctor();
				int num = 1;
				if (!false)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.Tu1isE3rLC.AddRange(\u0020);
						num = 0;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000C48 RID: 3144 RVA: 0x0005ADB4 File Offset: 0x00058FB4
			public override bool Equals(object \u0020)
			{
				ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s hcp9nIur8g9pimJhW0s = \u0020 as ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s;
				int num;
				int num2;
				if (\u0020 == null)
				{
					num = 3;
				}
				else if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.cE82gM28HddH8EISBLl(this.JuWiq9C3Ff, hcp9nIur8g9pimJhW0s.JuWiq9C3Ff))
				{
					num = 2;
					if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.O5s3wQ2uF1oh8XckJkJ() != null)
					{
						num = 1;
					}
				}
				else if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.krF7292qtRR3R3Zxj1l(this.Tu1isE3rLC) != ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.krF7292qtRR3R3Zxj1l(hcp9nIur8g9pimJhW0s.Tu1isE3rLC))
				{
					num = 7;
				}
				else
				{
					num2 = 0;
					num = 5;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_17E;
					case 1:
						return false;
					case 2:
						return false;
					case 3:
						return false;
					case 4:
						break;
					case 5:
						goto IL_17E;
					case 6:
						return true;
					case 7:
						return false;
					default:
						goto IL_17E;
					}
					IL_91:
					if (this.Tu1isE3rLC[num2].j2bieVonlD != hcp9nIur8g9pimJhW0s.Tu1isE3rLC[num2].j2bieVonlD)
					{
						return false;
					}
					if (this.Tu1isE3rLC[num2].cmFiXHaob9 != hcp9nIur8g9pimJhW0s.Tu1isE3rLC[num2].cmFiXHaob9)
					{
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.O5s3wQ2uF1oh8XckJkJ() != null)
						{
							num = 1;
							continue;
						}
						continue;
					}
					else
					{
						num2++;
						num = 0;
						if (!ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kp9rGt2xIdi8NSOHl5s())
						{
							num = 0;
							continue;
						}
						continue;
					}
					IL_17E:
					if (num2 < ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.krF7292qtRR3R3Zxj1l(this.Tu1isE3rLC))
					{
						goto IL_91;
					}
					num = 6;
				}
				return false;
			}

			// Token: 0x06000C49 RID: 3145 RVA: 0x0005AF5C File Offset: 0x0005915C
			public override int GetHashCode()
			{
				int num = 1;
				int num2 = num;
				int num3;
				for (;;)
				{
					List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V>.Enumerator enumerator;
					switch (num2)
					{
					case 1:
						num3 = this.JuWiq9C3Ff.GetHashCode();
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.O5s3wQ2uF1oh8XckJkJ() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						try
						{
							for (;;)
							{
								IL_9B:
								int num4;
								ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V nsVbPXukrvTsEUG8r1V;
								if (!enumerator.MoveNext())
								{
									num4 = 1;
									if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.O5s3wQ2uF1oh8XckJkJ() != null)
									{
										num4 = 0;
									}
								}
								else
								{
									nsVbPXukrvTsEUG8r1V = enumerator.Current;
									num4 = 0;
									if (!ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kp9rGt2xIdi8NSOHl5s())
									{
										num4 = 0;
									}
								}
								for (;;)
								{
									int num5;
									switch (num4)
									{
									case 1:
										goto IL_D5;
									case 2:
										goto IL_9B;
									case 3:
										num3 = (num3 ^ num5) + num5;
										num4 = 2;
										continue;
									}
									num5 = nsVbPXukrvTsEUG8r1V.j2bieVonlD.GetHashCode() + nsVbPXukrvTsEUG8r1V.cmFiXHaob9;
									num4 = 3;
								}
							}
							IL_D5:
							return num3;
						}
						finally
						{
							((IDisposable)enumerator).Dispose();
						}
						break;
					}
					enumerator = this.Tu1isE3rLC.GetEnumerator();
					num2 = 2;
					if (!ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kp9rGt2xIdi8NSOHl5s())
					{
						num2 = 1;
					}
				}
				return num3;
			}

			// Token: 0x06000C4A RID: 3146 RVA: 0x0005B0BC File Offset: 0x000592BC
			public ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V M6eu7q2go9(int \u0020)
			{
				using (List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V>.Enumerator enumerator = this.Tu1isE3rLC.GetEnumerator())
				{
					ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V result;
					for (;;)
					{
						IL_86:
						if (enumerator.MoveNext())
						{
							goto IL_CA;
						}
						int num = 4;
						if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.O5s3wQ2uF1oh8XckJkJ() != null)
						{
							num = 4;
						}
						ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V nsVbPXukrvTsEUG8r1V;
						for (;;)
						{
							IL_59:
							switch (num)
							{
							default:
								goto IL_77;
							case 1:
								goto IL_CA;
							case 2:
								goto IL_86;
							case 3:
								result = nsVbPXukrvTsEUG8r1V;
								num = 0;
								if (ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kp9rGt2xIdi8NSOHl5s())
								{
									num = 0;
								}
								break;
							case 4:
								goto IL_EF;
							}
						}
						IL_CA:
						nsVbPXukrvTsEUG8r1V = enumerator.Current;
						if (nsVbPXukrvTsEUG8r1V.cmFiXHaob9 == \u0020)
						{
							num = 3;
							goto IL_59;
						}
					}
					IL_77:
					return result;
					IL_EF:;
				}
				return null;
			}

			// Token: 0x06000C4B RID: 3147 RVA: 0x0005B1FC File Offset: 0x000593FC
			public bool V7ou2eLZeg(int \u0020)
			{
				using (List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V>.Enumerator enumerator = this.Tu1isE3rLC.GetEnumerator())
				{
					IL_8B:
					while (enumerator.MoveNext())
					{
						IL_5F:
						while (enumerator.Current.cmFiXHaob9 == \u0020)
						{
							int num = 1;
							if (!ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kp9rGt2xIdi8NSOHl5s())
							{
								num = 1;
							}
							bool result;
							for (;;)
							{
								switch (num)
								{
								default:
									goto IL_4C;
								case 1:
									result = true;
									num = 0;
									if (!ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kp9rGt2xIdi8NSOHl5s())
									{
										num = 0;
									}
									break;
								case 2:
									goto IL_8B;
								case 3:
									goto IL_5F;
								}
							}
							IL_4C:
							return result;
						}
					}
				}
				return false;
			}

			// Token: 0x06000C4C RID: 3148 RVA: 0x0005B31C File Offset: 0x0005951C
			// Note: this type is marked as 'beforefieldinit'.
			static HCp9nIur8g9pimJhW0s()
			{
				ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.Xqn3EZ2dQSbHqJCFHY9();
			}

			// Token: 0x06000C4D RID: 3149 RVA: 0x0005B32C File Offset: 0x0005952C
			internal static void gPdCbo2V4EE25IJLiHD()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000C4E RID: 3150 RVA: 0x0005B33C File Offset: 0x0005953C
			internal static void NDma512ysk17WilaUV1()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x0005B34C File Offset: 0x0005954C
			internal static bool kp9rGt2xIdi8NSOHl5s()
			{
				return ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kDFyJg25mTAMdgRrAgU == null;
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x0005B360 File Offset: 0x00059560
			internal static ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s O5s3wQ2uF1oh8XckJkJ()
			{
				return ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s.kDFyJg25mTAMdgRrAgU;
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x0005B370 File Offset: 0x00059570
			internal static bool cE82gM28HddH8EISBLl(object A_0, object A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x0005B388 File Offset: 0x00059588
			internal static int krF7292qtRR3R3Zxj1l(object A_0)
			{
				return A_0.Count;
			}

			// Token: 0x06000C53 RID: 3155 RVA: 0x0005B39C File Offset: 0x0005959C
			internal static void Xqn3EZ2dQSbHqJCFHY9()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003FA RID: 1018
			private List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V> Tu1isE3rLC;

			// Token: 0x040003FB RID: 1019
			private MethodBase JuWiq9C3Ff;

			// Token: 0x040003FC RID: 1020
			private static ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s kDFyJg25mTAMdgRrAgU;
		}

		// Token: 0x02000086 RID: 134
		private sealed class sxUaepu6HaOlCtHk6W7 : MulticastDelegate
		{
			// Token: 0x06000C54 RID: 3156
			public extern sxUaepu6HaOlCtHk6W7(object \u0020, IntPtr \u0020);

			// Token: 0x06000C55 RID: 3157
			public extern object Invoke(object target, object[] paramters);

			// Token: 0x06000C56 RID: 3158
			public extern IAsyncResult BeginInvoke(object target, object[] paramters, AsyncCallback callback, object @object);

			// Token: 0x06000C57 RID: 3159
			public extern object EndInvoke(IAsyncResult result);

			// Token: 0x06000C58 RID: 3160 RVA: 0x0005B3AC File Offset: 0x000595AC
			static sxUaepu6HaOlCtHk6W7()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}
		}

		// Token: 0x02000087 RID: 135
		private sealed class wWir2guNhxhMbk5v7nG : MulticastDelegate
		{
			// Token: 0x06000C59 RID: 3161
			public extern wWir2guNhxhMbk5v7nG(object \u0020, IntPtr \u0020);

			// Token: 0x06000C5A RID: 3162
			public extern object Invoke(object target);

			// Token: 0x06000C5B RID: 3163
			public extern IAsyncResult BeginInvoke(object target, AsyncCallback callback, object @object);

			// Token: 0x06000C5C RID: 3164
			public extern object EndInvoke(IAsyncResult result);

			// Token: 0x06000C5D RID: 3165 RVA: 0x0005B3BC File Offset: 0x000595BC
			static wWir2guNhxhMbk5v7nG()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}
		}

		// Token: 0x02000088 RID: 136
		private sealed class yxFAYJunxG2abHMChR2 : MulticastDelegate
		{
			// Token: 0x06000C5E RID: 3166
			public extern yxFAYJunxG2abHMChR2(object \u0020, IntPtr \u0020);

			// Token: 0x06000C5F RID: 3167
			public extern void Invoke(IntPtr a, byte b, int c);

			// Token: 0x06000C60 RID: 3168
			public extern IAsyncResult BeginInvoke(IntPtr a, byte b, int c, AsyncCallback callback, object @object);

			// Token: 0x06000C61 RID: 3169
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000C62 RID: 3170 RVA: 0x0005B3CC File Offset: 0x000595CC
			static yxFAYJunxG2abHMChR2()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}
		}

		// Token: 0x02000089 RID: 137
		private sealed class Wbptbeu0dLaolfKjSW5 : MulticastDelegate
		{
			// Token: 0x06000C63 RID: 3171
			public extern Wbptbeu0dLaolfKjSW5(object \u0020, IntPtr \u0020);

			// Token: 0x06000C64 RID: 3172
			public extern void Invoke(IntPtr s, IntPtr t, uint c);

			// Token: 0x06000C65 RID: 3173
			public extern IAsyncResult BeginInvoke(IntPtr s, IntPtr t, uint c, AsyncCallback callback, object @object);

			// Token: 0x06000C66 RID: 3174
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000C67 RID: 3175 RVA: 0x0005B3DC File Offset: 0x000595DC
			static Wbptbeu0dLaolfKjSW5()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}
		}

		// Token: 0x0200008A RID: 138
		internal class XVaV1xuJTWO8QjAwq7F
		{
			// Token: 0x06000C68 RID: 3176 RVA: 0x0005B3EC File Offset: 0x000595EC
			internal void vgtumGHW1N()
			{
				int num = 1;
				int num2 = num;
				bool flag;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						flag = false;
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				this.EolutfH2Wd(ref flag);
			}

			// Token: 0x06000C69 RID: 3177 RVA: 0x0005B450 File Offset: 0x00059650
			internal void hnPuHBlWWr()
			{
				int num = 6;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_E5;
						case 1:
							this.yHPlGnPngy = null;
							num2 = 2;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 2;
								continue;
							}
							continue;
						case 2:
							return;
						case 3:
							if (this.yHPlGnPngy == null)
							{
								return;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 4:
							break;
						case 5:
							goto IL_AB;
						case 6:
							this.Qk8lqGTUrC.bv68jSYg9n();
							num2 = 5;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 3;
								continue;
							}
							continue;
						default:
							goto IL_E5;
						}
						IL_C0:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XREDdD295HMEMvBWcOi(this.yHPlGnPngy);
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_E5:
						using (List<IntPtr>.Enumerator enumerator = this.yHPlGnPngy.GetEnumerator())
						{
							IL_131:
							while (enumerator.MoveNext())
							{
								for (;;)
								{
									IntPtr intPtr = enumerator.Current;
									int num3 = 1;
									if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num3 = 0;
									}
									switch (num3)
									{
									default:
										goto IL_131;
									case 1:
										try
										{
											ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.GSpvE82C0Y4JVrFCtCP(intPtr);
											goto IL_131;
										}
										catch
										{
											goto IL_131;
										}
										break;
									case 2:
										break;
									}
								}
							}
							goto IL_C0;
						}
					}
					IL_AB:
					this.RGflstwkfS = null;
					num = 3;
				}
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x0005B638 File Offset: 0x00059838
			internal void EolutfH2Wd(ref bool \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt oswePDupJwenbref1Qt;
					switch (num2)
					{
					case 0:
						goto IL_75A;
					case 1:
						goto IL_797;
					case 2:
						break;
					case 3:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yKGuKK2AZ5CnX5YYgyb(this.Qk8lqGTUrC);
						num2 = 12;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 11;
							continue;
						}
						continue;
					case 4:
						goto IL_797;
					case 5:
					{
						int num3 = this.t6plBAG1Rr;
						num2 = 13;
						continue;
					}
					case 6:
						goto IL_84D;
					case 7:
						return;
					case 8:
						this.rhZlWn3394 = oswePDupJwenbref1Qt.ML8iCQiVG6;
						num2 = 9;
						continue;
					case 9:
						try
						{
							this.TUsuMiCx57(oswePDupJwenbref1Qt);
							goto IL_76F;
						}
						catch (Exception ex)
						{
							int num4 = 20;
							for (;;)
							{
								List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> list;
								List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> list2;
								ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP2;
								switch (num4)
								{
								case 0:
									goto IL_62E;
								case 1:
									ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(ex));
									num4 = 25;
									if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 3;
										continue;
									}
									continue;
								case 2:
								{
									TargetInvocationException ex2;
									ex = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.gF64Ti2wGIH7XVCEvTr(ex2);
									num4 = 1;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 23;
										continue;
									}
									continue;
								}
								case 3:
								{
									int u;
									ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP = this.wsvughOOGN(u, ex);
									num4 = 5;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 6;
										continue;
									}
									continue;
								}
								case 4:
								{
									TargetInvocationException ex2;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.gF64Ti2wGIH7XVCEvTr(ex2) == null)
									{
										goto IL_2D6;
									}
									num4 = 2;
									if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 2;
										continue;
									}
									continue;
								}
								case 5:
									this.RHilFDgR4P = -1;
									this.vgtumGHW1N();
									num4 = 21;
									continue;
								case 6:
								{
									int u;
									list = this.hUVuXReqHf(u, false);
									list2 = new List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>();
									num4 = 24;
									continue;
								}
								case 7:
								{
									int u = this.bgBlLdPL4Z;
									num4 = 3;
									continue;
								}
								case 8:
								{
									int u;
									this.mpTuYeIsLw(u, o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.oe3ivl4Hb5);
									num4 = 12;
									continue;
								}
								case 9:
									this.t6plBAG1Rr = this.bgBlLdPL4Z;
									num4 = 3;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 5;
										continue;
									}
									continue;
								case 10:
									try
									{
										for (;;)
										{
											IL_3AC:
											List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>.Enumerator enumerator;
											if (enumerator.MoveNext())
											{
												goto IL_472;
											}
											int num5 = 7;
											ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP3;
											for (;;)
											{
												IL_33C:
												switch (num5)
												{
												case 1:
													goto IL_4CA;
												case 2:
													goto IL_495;
												case 3:
													this.bgBlLdPL4Z = o7BGFwuaTreTeXAneXP3.aE6ioYbwF8.mK9ibJJLQ8;
													num5 = 8;
													if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
													{
														num5 = 4;
														continue;
													}
													continue;
												case 4:
													goto IL_431;
												case 5:
													this.vgtumGHW1N();
													num5 = 0;
													if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
													{
														num5 = 0;
														continue;
													}
													continue;
												case 6:
													if (o7BGFwuaTreTeXAneXP3.aE6ioYbwF8.HThiPAKxeR != 0)
													{
														goto IL_4CA;
													}
													goto IL_4F6;
												case 7:
													goto IL_514;
												case 8:
													this.t6plBAG1Rr = this.bgBlLdPL4Z;
													num5 = 5;
													continue;
												case 9:
													goto IL_4F6;
												case 10:
													goto IL_472;
												case 11:
													goto IL_37E;
												case 12:
													goto IL_38D;
												case 13:
													goto IL_3AC;
												}
												if (!this.gvMlV1YWKU)
												{
													num5 = 11;
													continue;
												}
												IL_431:
												this.gvMlV1YWKU = false;
												o7BGFwuaTreTeXAneXP2 = o7BGFwuaTreTeXAneXP3;
												num5 = 2;
												continue;
												IL_4CA:
												ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(ex));
												num5 = 3;
												if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
												{
													num5 = 3;
													continue;
												}
												continue;
												IL_4F6:
												o7BGFwuaTreTeXAneXP2 = o7BGFwuaTreTeXAneXP3;
												num5 = 4;
												if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
												{
													num5 = 12;
												}
											}
											IL_37E:
											continue;
											IL_472:
											o7BGFwuaTreTeXAneXP3 = enumerator.Current;
											num5 = 4;
											if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
											{
												num5 = 6;
												goto IL_33C;
											}
											goto IL_33C;
										}
										IL_38D:
										IL_495:
										IL_514:
										break;
									}
									finally
									{
										List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>.Enumerator enumerator;
										((IDisposable)enumerator).Dispose();
									}
									goto IL_546;
								case 11:
								{
									TargetInvocationException ex2 = (TargetInvocationException)ex;
									num4 = 4;
									continue;
								}
								case 12:
									if (this.RHilFDgR4P < 0)
									{
										goto IL_676;
									}
									num4 = 1;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
									{
										num4 = 0;
										continue;
									}
									continue;
								case 13:
								{
									ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP;
									list2.Add(o7BGFwuaTreTeXAneXP);
									num4 = 18;
									if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 10;
										continue;
									}
									continue;
								}
								case 14:
									\u0020 = true;
									ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yKGuKK2AZ5CnX5YYgyb(this.Qk8lqGTUrC);
									num4 = 7;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
									{
										num4 = 7;
										continue;
									}
									continue;
								case 15:
								{
									List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>.Enumerator enumerator = list2.GetEnumerator();
									num4 = 10;
									continue;
								}
								case 16:
									o7BGFwuaTreTeXAneXP2 = null;
									num4 = 15;
									continue;
								case 17:
									list2.AddRange(list);
									num4 = 0;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 0;
										continue;
									}
									continue;
								case 18:
									goto IL_546;
								case 19:
									goto IL_607;
								case 20:
									if (!(ex is TargetInvocationException))
									{
										goto IL_2D6;
									}
									num4 = 5;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num4 = 11;
										continue;
									}
									continue;
								case 21:
									goto IL_676;
								case 22:
									break;
								case 23:
									goto IL_2D6;
								case 24:
								{
									ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP;
									if (o7BGFwuaTreTeXAneXP != null)
									{
										num4 = 13;
										continue;
									}
									goto IL_546;
								}
								case 25:
								{
									this.bgBlLdPL4Z = this.RHilFDgR4P;
									int num6 = 9;
									num4 = num6;
									continue;
								}
								case 26:
									goto IL_233;
								default:
									goto IL_62E;
								}
								if (o7BGFwuaTreTeXAneXP2 == null)
								{
									num4 = 26;
									continue;
								}
								this.RHilFDgR4P = o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.oe3ivl4Hb5;
								num4 = 7;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num4 = 8;
									continue;
								}
								continue;
								IL_2D6:
								this.vaqlyQlH5E = ex;
								num4 = 14;
								continue;
								IL_607:
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.pSV66K2hQamHiykSsqJ(list) > 0)
								{
									num4 = 17;
									continue;
								}
								goto IL_62E;
								IL_546:
								if (list != null)
								{
									goto IL_607;
								}
								IL_62E:
								List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> list3 = list2;
								Comparison<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> comparison;
								if ((comparison = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.<>9__12_0) == null)
								{
									comparison = (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.<>9__12_0 = new Comparison<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.<>9.OyYUOIbE1C));
								}
								list3.Sort(comparison);
								num4 = 16;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num4 = 0;
								}
							}
							IL_233:
							throw ex;
							IL_676:
							return;
						}
						goto IL_685;
					case 10:
					{
						int num7 = this.bgBlLdPL4Z;
						num2 = 5;
						continue;
					}
					case 11:
					{
						int num7;
						this.bgBlLdPL4Z = num7;
						num2 = 16;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 18;
							continue;
						}
						continue;
					}
					case 12:
						return;
					case 13:
						this.tuEusYG8sM(this.bgBlLdPL4Z, this.t6plBAG1Rr);
						num2 = 17;
						continue;
					case 14:
						goto IL_76F;
					case 15:
						goto IL_6DD;
					case 16:
						goto IL_685;
					case 17:
					{
						int num3;
						this.t6plBAG1Rr = num3;
						num2 = 11;
						continue;
					}
					case 18:
						break;
					case 19:
						goto IL_825;
					default:
						goto IL_75A;
					}
					if (this.jMMlJZsjHx)
					{
						num2 = 6;
						continue;
					}
					if (!this.RQPlpS4Dct)
					{
						this.bgBlLdPL4Z = this.t6plBAG1Rr;
						num2 = 16;
						continue;
					}
					goto IL_6DD;
					IL_685:
					oswePDupJwenbref1Qt = this.OOMlcvRAjr.UAii4R1MbG[this.t6plBAG1Rr];
					num2 = 8;
					continue;
					IL_6DD:
					this.RQPlpS4Dct = false;
					num2 = 7;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num2 = 7;
						continue;
					}
					continue;
					IL_75A:
					if (!this.g2tlnWc570)
					{
						num2 = 2;
						continue;
					}
					goto IL_825;
					IL_797:
					if (this.t6plBAG1Rr > -2)
					{
						goto IL_75A;
					}
					num2 = 3;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_76F:
					this.t6plBAG1Rr++;
					num2 = 0;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_825:
					this.g2tlnWc570 = false;
					num2 = 10;
				}
				return;
				IL_84D:
				this.jMMlJZsjHx = false;
			}

			// Token: 0x06000C6B RID: 3179 RVA: 0x0005BED4 File Offset: 0x0005A0D4
			internal void mpTuYeIsLw(int \u0020, int \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 2:
						if (this.OOMlcvRAjr.f0ViTMY9D3 != null)
						{
							goto IL_5E;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_5E;
					}
					break;
				}
				return;
				IL_5E:
				using (List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>.Enumerator enumerator = this.OOMlcvRAjr.f0ViTMY9D3.GetEnumerator())
				{
					for (;;)
					{
						IL_217:
						if (enumerator.MoveNext())
						{
							goto IL_108;
						}
						int num3 = 10;
						ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP;
						for (;;)
						{
							IL_89:
							bool flag;
							int num4;
							switch (num3)
							{
							case 0:
								goto IL_12B;
							case 1:
								if (o7BGFwuaTreTeXAneXP.aE6ioYbwF8.HThiPAKxeR == 4)
								{
									goto IL_14C;
								}
								num3 = 6;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num3 = 2;
									continue;
								}
								continue;
							case 2:
								goto IL_14C;
							case 3:
								this.t6plBAG1Rr = this.bgBlLdPL4Z;
								flag = false;
								num3 = 0;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num3 = 0;
									continue;
								}
								continue;
							case 4:
								goto IL_1CB;
							case 5:
								if (flag)
								{
									goto IL_1A5;
								}
								num4 = 4;
								break;
							case 6:
								if (o7BGFwuaTreTeXAneXP.aE6ioYbwF8.HThiPAKxeR == 2)
								{
									num3 = 2;
									continue;
								}
								goto IL_217;
							case 7:
								goto IL_1EB;
							case 8:
								goto IL_108;
							case 9:
								goto IL_1A5;
							case 10:
								goto IL_22D;
							case 11:
								if (o7BGFwuaTreTeXAneXP.aE6ioYbwF8.ICtiRLSqEJ > \u0020)
								{
									num3 = 12;
									continue;
								}
								goto IL_1EB;
							case 12:
								goto IL_13D;
							default:
								goto IL_12B;
							}
							IL_85:
							num3 = num4;
							continue;
							IL_12B:
							this.EolutfH2Wd(ref flag);
							num3 = 5;
							continue;
							IL_1EB:
							this.bgBlLdPL4Z = o7BGFwuaTreTeXAneXP.aE6ioYbwF8.oe3ivl4Hb5;
							num3 = 3;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num3 = 1;
								continue;
							}
							continue;
							IL_14C:
							if (o7BGFwuaTreTeXAneXP.aE6ioYbwF8.oe3ivl4Hb5 >= \u0020)
							{
								num4 = 11;
								goto IL_85;
							}
							break;
						}
						IL_13D:
						IL_1CB:
						continue;
						IL_108:
						o7BGFwuaTreTeXAneXP = enumerator.Current;
						num3 = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num3 = 1;
							goto IL_89;
						}
						goto IL_89;
					}
					IL_1A5:
					IL_22D:;
				}
			}

			// Token: 0x06000C6C RID: 3180 RVA: 0x0005C17C File Offset: 0x0005A37C
			internal void tuEusYG8sM(int \u0020, int \u0020)
			{
				if (this.OOMlcvRAjr.f0ViTMY9D3 != null)
				{
					List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>.Enumerator enumerator = this.OOMlcvRAjr.f0ViTMY9D3.GetEnumerator();
					int num = 0;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 0;
					}
					switch (num)
					{
					case 1:
						return;
					}
					try
					{
						for (;;)
						{
							IL_10C:
							if (enumerator.MoveNext())
							{
								goto IL_1BA;
							}
							int num2 = 5;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 1;
							}
							ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP;
							for (;;)
							{
								IL_4B:
								bool flag;
								switch (num2)
								{
								case 0:
									goto IL_EB;
								case 1:
									break;
								case 2:
									goto IL_1BA;
								case 3:
									this.EolutfH2Wd(ref flag);
									num2 = 0;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
									{
										num2 = 0;
										continue;
									}
									continue;
								case 4:
									if (o7BGFwuaTreTeXAneXP.aE6ioYbwF8.ICtiRLSqEJ > \u0020)
									{
										goto Block_14;
									}
									break;
								case 5:
									goto IL_1C8;
								case 6:
									if (o7BGFwuaTreTeXAneXP.aE6ioYbwF8.oe3ivl4Hb5 < \u0020)
									{
										goto IL_10C;
									}
									num2 = 4;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
									{
										num2 = 4;
										continue;
									}
									continue;
								case 7:
									goto IL_10C;
								case 8:
									goto IL_13F;
								case 9:
									flag = false;
									num2 = 3;
									continue;
								case 10:
									this.t6plBAG1Rr = this.bgBlLdPL4Z;
									num2 = 9;
									continue;
								default:
									goto IL_EB;
								}
								this.bgBlLdPL4Z = o7BGFwuaTreTeXAneXP.aE6ioYbwF8.oe3ivl4Hb5;
								num2 = 10;
								continue;
								IL_EB:
								if (!flag)
								{
									break;
								}
								num2 = 4;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 8;
								}
							}
							Block_14:
							continue;
							IL_1BA:
							o7BGFwuaTreTeXAneXP = enumerator.Current;
							if (o7BGFwuaTreTeXAneXP.aE6ioYbwF8.HThiPAKxeR == 2)
							{
								int num3 = 6;
								num2 = num3;
								goto IL_4B;
							}
						}
						IL_13F:
						IL_1C8:;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
			}

			// Token: 0x06000C6D RID: 3181 RVA: 0x0005C3CC File Offset: 0x0005A5CC
			internal ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP wsvughOOGN(int \u0020, Exception \u0020)
			{
				int num = 3;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP;
				for (;;)
				{
					switch (num2)
					{
					default:
						return o7BGFwuaTreTeXAneXP;
					case 1:
						return o7BGFwuaTreTeXAneXP;
					case 2:
						if (this.OOMlcvRAjr.f0ViTMY9D3 != null)
						{
							goto IL_36E;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						break;
					case 4:
						goto IL_36E;
					}
					IL_361:
					o7BGFwuaTreTeXAneXP = null;
					num2 = 2;
					continue;
					IL_36E:
					using (List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>.Enumerator enumerator = this.OOMlcvRAjr.f0ViTMY9D3.GetEnumerator())
					{
						for (;;)
						{
							IL_116:
							int num3;
							ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP2;
							if (!enumerator.MoveNext())
							{
								num3 = 12;
							}
							else
							{
								o7BGFwuaTreTeXAneXP2 = enumerator.Current;
								num3 = 0;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num3 = 14;
								}
							}
							for (;;)
							{
								int num4;
								switch (num3)
								{
								case 0:
									goto IL_238;
								case 1:
									goto IL_2CE;
								case 2:
									if (o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.fTxirp6Y0Y != null)
									{
										goto IL_2FB;
									}
									num3 = 1;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
									{
										num3 = 1;
										continue;
									}
									continue;
								case 3:
									goto IL_19E;
								case 4:
									goto IL_1AF;
								case 5:
									goto IL_298;
								case 6:
									goto IL_271;
								case 7:
									if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.QGq6iQ210OvmpSkyxxS(o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.fTxirp6Y0Y.FullName, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777244)).FullName))
									{
										goto IL_116;
									}
									num4 = 11;
									break;
								case 8:
									goto IL_2FB;
								case 9:
									goto IL_12C;
								case 10:
									o7BGFwuaTreTeXAneXP = o7BGFwuaTreTeXAneXP2;
									num3 = 4;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
									{
										num3 = 4;
										continue;
									}
									continue;
								case 11:
									goto IL_298;
								case 12:
									goto IL_32F;
								case 13:
									if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Pc2QlI2i08jdrbwRHq8(o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.fTxirp6Y0Y, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.rJ4qON2Ir7sBJXNHLSj(\u0020)))
									{
										num3 = 2;
										continue;
									}
									goto IL_298;
								case 14:
									if (o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.HThiPAKxeR == 0)
									{
										num3 = 13;
										continue;
									}
									goto IL_116;
								case 15:
									goto IL_1B9;
								case 16:
									goto IL_116;
								default:
									goto IL_238;
								}
								IL_61:
								num3 = num4;
								continue;
								IL_19E:
								if (o7BGFwuaTreTeXAneXP == null)
								{
									num3 = 10;
									continue;
								}
								if (o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.oe3ivl4Hb5 >= o7BGFwuaTreTeXAneXP.aE6ioYbwF8.oe3ivl4Hb5)
								{
									break;
								}
								o7BGFwuaTreTeXAneXP = o7BGFwuaTreTeXAneXP2;
								num3 = 16;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num3 = 9;
									continue;
								}
								continue;
								IL_271:
								if (\u0020 <= o7BGFwuaTreTeXAneXP2.bOdiOkNrnU)
								{
									goto IL_19E;
								}
								num3 = 2;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num3 = 15;
									continue;
								}
								continue;
								IL_298:
								if (\u0020 < o7BGFwuaTreTeXAneXP2.CHVi7uox8r)
								{
									num4 = 9;
									goto IL_61;
								}
								goto IL_271;
								IL_2FB:
								if (o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.fTxirp6Y0Y.FullName == ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.rJ4qON2Ir7sBJXNHLSj(\u0020).FullName)
								{
									num4 = 5;
									goto IL_61;
								}
								IL_238:
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.QGq6iQ210OvmpSkyxxS(o7BGFwuaTreTeXAneXP2.aE6ioYbwF8.fTxirp6Y0Y.FullName, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236)).FullName))
								{
									goto IL_298;
								}
								num3 = 7;
							}
							IL_12C:
							IL_1AF:
							IL_1B9:
							IL_2CE:;
						}
						IL_32F:
						break;
					}
					goto IL_361;
				}
				return o7BGFwuaTreTeXAneXP;
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x0005C7A8 File Offset: 0x0005A9A8
			internal List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> hUVuXReqHf(int \u0020, bool \u0020)
			{
				if (this.OOMlcvRAjr.f0ViTMY9D3 == null)
				{
					return null;
				}
				List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> list = new List<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP>();
				foreach (ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP o7BGFwuaTreTeXAneXP in this.OOMlcvRAjr.f0ViTMY9D3)
				{
					if ((o7BGFwuaTreTeXAneXP.aE6ioYbwF8.HThiPAKxeR & 1) == 1 && \u0020 >= o7BGFwuaTreTeXAneXP.CHVi7uox8r && \u0020 <= o7BGFwuaTreTeXAneXP.bOdiOkNrnU)
					{
						list.Add(o7BGFwuaTreTeXAneXP);
					}
				}
				if (list.Count == 0)
				{
					return null;
				}
				return list;
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x0005C864 File Offset: 0x0005AA64
			private unsafe void TUsuMiCx57(ykD11HxHfZBYH7OcFOG.OSWePDupJwenbref1Qt \u0020)
			{
				int num = 361;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				IntPtr intPtr;
				Type type;
				object obj;
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB;
				int num3;
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB2;
				uint u;
				FieldInfo fieldInfo;
				Array array;
				IntPtr intPtr2;
				ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4 ngYCBhqPZ7YsxPQyJh;
				for (;;)
				{
					int num2 = num;
					long num4;
					ParameterInfo[] parameters;
					object[] array2;
					ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F y6ZjFnxbSGpN58JxU4F;
					int[] array3;
					ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[] array4;
					ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC3;
					int num8;
					for (;;)
					{
						Module module;
						ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu mA48iBuFQonZePrECIu;
						object obj2;
						ConstructorInfo constructorInfo;
						ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 sxUaepu6HaOlCtHk6W;
						int num5;
						List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V> list;
						bool flag;
						ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s hcp9nIur8g9pimJhW0s;
						switch (num2)
						{
						case 1:
							if (x0cbwj80qtx55Tsu8UC is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)
							{
								num2 = 445;
								continue;
							}
							goto IL_433E;
						case 2:
							goto IL_6219;
						case 3:
							intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.rAg8ryuQY6(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 315;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 266;
								continue;
							}
							continue;
						case 4:
							goto IL_5413;
						case 5:
							return;
						case 6:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(type, obj));
							num2 = 115;
							continue;
						case 7:
							goto IL_4716;
						case 8:
							return;
						case 9:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.jupdeL2kBbQ4FZLkE14(qmmmuQuSWS2kKwsrFfB));
							num2 = 196;
							continue;
						case 10:
							goto IL_2B1A;
						case 11:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto Block_59;
							}
							goto IL_325F;
						case 12:
							goto IL_2A91;
						case 13:
							module = Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module;
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.t9F8Qx6X03Fmee14pr5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SXjTgW6d9WTLVJjAC1A(module, num3)).GetFunctionPointer()));
							num2 = 50;
							continue;
						case 14:
							return;
						case 15:
							if (type.IsByRef)
							{
								num2 = 119;
								continue;
							}
							goto IL_4A2E;
						case 16:
							this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
							num2 = 513;
							continue;
						case 17:
							return;
						case 18:
							this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
							num2 = 230;
							continue;
						case 19:
							goto IL_4518;
						case 20:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								goto IL_39DA;
							}
							num2 = 481;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 457;
								continue;
							}
							continue;
						case 21:
							if (obj != null)
							{
								num2 = 598;
								continue;
							}
							goto IL_4DC5;
						case 22:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 559;
							continue;
						case 23:
							goto IL_372D;
						case 24:
							return;
						case 25:
							goto IL_20CC;
						case 26:
							obj2 = mA48iBuFQonZePrECIu.sYUi5K28CZ;
							num2 = 648;
							continue;
						case 27:
							goto IL_1F1D;
						case 28:
							goto IL_3C85;
						case 29:
							goto IL_54D1;
						case 30:
							goto IL_31B3;
						case 31:
							return;
						case 32:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 699;
							continue;
						case 33:
							goto IL_F2F;
						case 34:
							goto IL_573D;
						case 35:
							goto IL_369B;
						case 36:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 297;
								continue;
							}
							goto IL_421B;
						case 37:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								num2 = 264;
								continue;
							}
							goto IL_5992;
						case 38:
							goto IL_6F0A;
						case 39:
							intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.f5jHoN24g0jBEI5KuTG((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB);
							num2 = 710;
							continue;
						case 40:
							goto IL_551B;
						case 41:
							return;
						case 42:
							goto IL_3622;
						case 43:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777252)), obj));
							num2 = 182;
							continue;
						case 44:
							goto IL_3B23;
						case 45:
							goto IL_5537;
						case 46:
							goto IL_5C56;
						case 47:
							mA48iBuFQonZePrECIu = (x0cbwj80qtx55Tsu8UC as ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu);
							num2 = 60;
							continue;
						case 48:
							return;
						case 49:
							this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(u, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6));
							num2 = 353;
							continue;
						case 50:
							return;
						case 51:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu(fieldInfo, null));
							num2 = 98;
							continue;
						case 52:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 29;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 37;
								continue;
							}
							continue;
						case 53:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0));
							num2 = 454;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 124;
								continue;
							}
							continue;
						case 54:
							fieldInfo = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.firLfX2b9yQe64i2LfW(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							num2 = 78;
							continue;
						case 55:
							goto IL_45C2;
						case 56:
							return;
						case 57:
							goto IL_666F;
						case 58:
							this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Bt9yJsufERU9xtb39mw(qmmmuQuSWS2kKwsrFfB.eoUqScGyAS().aYsh65bDic.RekhP3Apm0, array));
							num2 = 541;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 262;
								continue;
							}
							continue;
						case 59:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(*(sbyte*)((void*)intPtr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1));
							num2 = 9;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 102;
								continue;
							}
							continue;
						case 60:
							if (mA48iBuFQonZePrECIu == null)
							{
								goto IL_3FD7;
							}
							num2 = 327;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 234;
								continue;
							}
							continue;
						case 61:
							intPtr = ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB).oM8u8TUrCx();
							num2 = 59;
							continue;
						case 62:
							goto IL_61EE;
						case 63:
							goto IL_56C1;
						case 64:
							goto IL_26AC;
						case 65:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 296;
								continue;
							}
							goto IL_197B;
						case 66:
						{
							ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC2 = this.Qk8lqGTUrC.cL3qW1trrh();
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eypu226HVfIansf7PwU(x0cbwj80qtx55Tsu8UC2);
							obj = x0cbwj80qtx55Tsu8UC2.y9jq31urLD(null);
							num2 = 244;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 457;
								continue;
							}
							continue;
						}
						case 67:
							goto IL_53FE;
						case 68:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 358;
								continue;
							}
							goto IL_264A;
						case 69:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.MnA3Bc2X79qx1q2YIhE(qmmmuQuSWS2kKwsrFfB));
							num2 = 583;
							continue;
						case 70:
							if (x0cbwj80qtx55Tsu8UC == null)
							{
								goto Block_316;
							}
							goto IL_2DF6;
						case 71:
							return;
						case 72:
							return;
						case 73:
							return;
						case 74:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 117;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 64;
								continue;
							}
							continue;
						case 75:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0));
							num2 = 281;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 185;
								continue;
							}
							continue;
						case 76:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(qmmmuQuSWS2kKwsrFfB))
							{
								goto Block_41;
							}
							goto IL_5E33;
						case 77:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777253)), obj));
							num2 = 255;
							continue;
						case 78:
							goto IL_4175;
						case 79:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(constructorInfo.DeclaringType, obj));
							num2 = 56;
							continue;
						case 80:
							return;
						case 81:
							goto IL_5413;
						case 82:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_32CE;
							}
							num2 = 60;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 490;
								continue;
							}
							continue;
						case 83:
							obj = Activator.CreateInstance(type);
							num2 = 621;
							continue;
						case 84:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								num2 = 375;
								continue;
							}
							goto IL_2938;
						case 85:
							obj2 = Activator.CreateInstance(type);
							num2 = 675;
							continue;
						case 86:
							type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							num2 = 250;
							continue;
						case 87:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_30D6;
							}
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.UVBILW22gJhrJw7HxpS(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
							num2 = 214;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 319;
								continue;
							}
							continue;
						case 88:
							return;
						case 89:
							goto IL_6F0A;
						case 90:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 422;
								continue;
							}
							goto IL_278E;
						case 91:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								num2 = 229;
								continue;
							}
							goto IL_1EAB;
						case 92:
							return;
						case 93:
							goto IL_4929;
						case 94:
							sxUaepu6HaOlCtHk6W = null;
							num2 = 201;
							continue;
						case 95:
							goto IL_5B7E;
						case 96:
							goto IL_1745;
						case 97:
							return;
						case 98:
							return;
						case 99:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null);
							num2 = 203;
							continue;
						case 100:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 669;
								continue;
							}
							goto IL_4BC5;
						case 101:
							return;
						case 102:
							return;
						case 103:
							if (num4 >= 0L)
							{
								num2 = 417;
								continue;
							}
							goto IL_5468;
						case 104:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_31A2;
							}
							num2 = 287;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 365;
								continue;
							}
							continue;
						case 105:
							return;
						case 106:
							goto IL_6EB8;
						case 107:
							goto IL_6658;
						case 108:
							return;
						case 109:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 561;
								continue;
							}
							goto IL_48A6;
						case 110:
							return;
						case 111:
							return;
						case 112:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								num2 = 87;
								continue;
							}
							goto IL_30D6;
						case 113:
							goto IL_53FE;
						case 114:
							if (x0cbwj80qtx55Tsu8UC == null)
							{
								goto IL_2907;
							}
							num2 = 627;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 295;
								continue;
							}
							continue;
						case 115:
							return;
						case 116:
							return;
						case 117:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								goto IL_26AC;
							}
							num2 = 419;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 410;
								continue;
							}
							continue;
						case 118:
							goto IL_39BB;
						case 119:
							type = type.GetElementType();
							num2 = 390;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 14;
								continue;
							}
							continue;
						case 120:
							return;
						case 121:
							return;
						case 122:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mUVF6l2YoIJqbMVd6KH(x0cbwj80qtx55Tsu8UC))
							{
								goto Block_264;
							}
							goto IL_3CAF;
						case 123:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC);
							num2 = 363;
							continue;
						case 124:
							goto IL_1A7C;
						case 125:
							goto IL_1A21;
						case 126:
							return;
						case 127:
							return;
						case 128:
							goto IL_5413;
						case 129:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 333;
							continue;
						case 130:
							return;
						case 131:
							goto IL_5F5C;
						case 132:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Yyfb8u65WZelCkMXfEE(qmmmuQuSWS2kKwsrFfB2, x0cbwj80qtx55Tsu8UC))
							{
								num2 = 389;
								continue;
							}
							goto IL_2D01;
						case 133:
							return;
						case 134:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(x0cbwj80qtx55Tsu8UC);
							num2 = 685;
							continue;
						case 135:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yxTqPB2gVj6q2Wa8L3S(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), x0cbwj80qtx55Tsu8UC);
							num2 = 625;
							continue;
						case 136:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.vb9prK6FhZR1wSy7K4Q(qmmmuQuSWS2kKwsrFfB));
							num2 = 235;
							continue;
						case 137:
							goto IL_607F;
						case 138:
							qmmmuQuSWS2kKwsrFfB2 = (this.Qk8lqGTUrC.cL3qW1trrh() as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
							num2 = 3;
							continue;
						case 139:
							goto IL_1EF7;
						case 141:
							return;
						case 142:
							goto IL_2CB6;
						case 143:
							goto IL_1E39;
						case 144:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mUVF6l2YoIJqbMVd6KH(x0cbwj80qtx55Tsu8UC))
							{
								goto Block_105;
							}
							goto IL_4B0A;
						case 145:
							x0cbwj80qtx55Tsu8UC = null;
							num2 = 208;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 569;
								continue;
							}
							continue;
						case 146:
							goto IL_3F81;
						case 147:
							return;
						case 148:
							return;
						case 149:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, x0cbwj80qtx55Tsu8UC);
							num2 = 213;
							continue;
						case 150:
							if (x0cbwj80qtx55Tsu8UC != null)
							{
								num2 = 721;
								continue;
							}
							goto IL_3F81;
						case 151:
							return;
						case 152:
							goto IL_38EB;
						case 153:
							goto IL_690C;
						case 154:
							return;
						case 155:
							goto IL_433E;
						case 156:
							if (obj == null)
							{
								num2 = 428;
								continue;
							}
							goto IL_4A8A;
						case 157:
							if (x0cbwj80qtx55Tsu8UC == null)
							{
								num2 = 628;
								continue;
							}
							goto IL_4AF0;
						case 158:
							return;
						case 159:
							obj = null;
							num2 = 556;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 535;
								continue;
							}
							continue;
						case 160:
							goto IL_6C36;
						case 161:
							goto IL_38C3;
						case 162:
							goto IL_5F4D;
						case 163:
							return;
						case 164:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.uuOM5c6gsKusAbftgeL(qmmmuQuSWS2kKwsrFfB));
							num2 = 290;
							continue;
						case 165:
							return;
						case 166:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JDTfAS6QHuMfwQeIPNP(qmmmuQuSWS2kKwsrFfB));
							num2 = 260;
							continue;
						case 167:
							goto IL_5FC1;
						case 168:
							if (x0cbwj80qtx55Tsu8UC.snedf8QbBG())
							{
								goto IL_6E00;
							}
							num2 = 233;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 101;
								continue;
							}
							continue;
						case 169:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777614)), obj));
							num2 = 697;
							continue;
						case 170:
							goto IL_1728;
						case 171:
							return;
						case 172:
							fieldInfo = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module.ResolveField(num3);
							num2 = 459;
							continue;
						case 173:
							goto IL_264A;
						case 174:
							goto IL_5081;
						case 175:
							return;
						case 176:
							if (type.IsValueType)
							{
								goto IL_5537;
							}
							num2 = 321;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 181;
								continue;
							}
							continue;
						case 177:
							goto IL_6703;
						case 178:
							return;
						case 179:
							goto IL_2EB9;
						case 180:
							goto IL_325F;
						case 181:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777219)), obj));
							num2 = 347;
							continue;
						case 182:
							return;
						case 183:
							goto IL_1596;
						case 184:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DFvjDg6tlJS04axSBfg(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
							num2 = 498;
							continue;
						case 185:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777333)), obj));
							num2 = 214;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 71;
								continue;
							}
							continue;
						case 186:
							this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null));
							num2 = 485;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 605;
								continue;
							}
							continue;
						case 187:
							goto IL_F35;
						case 188:
							return;
						case 189:
							return;
						case 190:
							return;
						case 191:
							goto IL_3A45;
						case 192:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KBOgmx2frpwcTrqS6uk(qmmmuQuSWS2kKwsrFfB));
							num2 = 265;
							continue;
						case 193:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.bqXHfM2nPCr1sAADGOJ(qmmmuQuSWS2kKwsrFfB));
							num2 = 95;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 126;
								continue;
							}
							continue;
						case 194:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(qmmmuQuSWS2kKwsrFfB))
							{
								num2 = 39;
								continue;
							}
							goto IL_5D7C;
						case 195:
						{
							byte n05hvQHtOX = qmmmuQuSWS2kKwsrFfB2.PQEqwQ01dQ().aYsh65bDic.N05hvQHtOX;
							num2 = 263;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 202;
								continue;
							}
							continue;
						}
						case 196:
							return;
						case 197:
							return;
						case 198:
							goto IL_5959;
						case 199:
							return;
						case 200:
							type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[parameters.Length - 1 - num5]);
							num2 = 545;
							continue;
						case 201:
							if (list == null)
							{
								goto IL_2FE9;
							}
							num2 = 450;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 518;
								continue;
							}
							continue;
						case 202:
							obj = ((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null)).GetValue(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
							num2 = 169;
							continue;
						case 203:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.i61l3vZWFk[obj] = x0cbwj80qtx55Tsu8UC;
							num2 = 92;
							continue;
						case 204:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 93;
								continue;
							}
							goto IL_5F5C;
						case 205:
							return;
						case 206:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(type, obj);
							num2 = 149;
							continue;
						case 207:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto Block_342;
							}
							goto IL_42BC;
						case 208:
							goto IL_5A59;
						case 209:
							goto IL_22B6;
						case 210:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)).SqWdSNFM0N(x0cbwj80qtx55Tsu8UC))
							{
								return;
							}
							num2 = 3;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 16;
								continue;
							}
							continue;
						case 211:
							return;
						case 212:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
							{
								goto IL_44C3;
							}
							num2 = 96;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 18;
								continue;
							}
							continue;
						case 213:
							return;
						case 214:
							return;
						case 215:
							goto IL_F35;
						case 216:
							flag = true;
							num2 = 46;
							continue;
						case 217:
							return;
						case 218:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)).DoCdicvJaP(x0cbwj80qtx55Tsu8UC))
							{
								goto Block_95;
							}
							goto IL_1A7C;
						case 219:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 608;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 383;
								continue;
							}
							continue;
						case 220:
							return;
						case 221:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								goto IL_533B;
							}
							num2 = 416;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 421;
								continue;
							}
							continue;
						case 222:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(x0cbwj80qtx55Tsu8UC);
							num2 = 668;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 602;
								continue;
							}
							continue;
						case 223:
							return;
						case 224:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Yw7pKo6SNAQGhPpJ5ut(qmmmuQuSWS2kKwsrFfB));
							num2 = 127;
							continue;
						case 225:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
							{
								goto IL_3FA3;
							}
							num2 = 672;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 451;
								continue;
							}
							continue;
						case 226:
							obj = x0cbwj80qtx55Tsu8UC.y9jq31urLD(type);
							num2 = 591;
							continue;
						case 227:
							goto IL_6607;
						case 228:
							array = (Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null);
							num2 = 22;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 58;
								continue;
							}
							continue;
						case 229:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 472;
								continue;
							}
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nH3y96N5K9JQHQBgR9F(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
							num2 = 592;
							continue;
						case 230:
							return;
						case 231:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 9;
								continue;
							}
							goto IL_4005;
						case 232:
							array2 = new object[parameters.Length];
							num2 = 482;
							continue;
						case 233:
							goto IL_551B;
						case 234:
							if (obj == null)
							{
								goto IL_3413;
							}
							num2 = 335;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 102;
								continue;
							}
							continue;
						case 235:
							return;
						case 236:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto Block_323;
							}
							goto IL_222C;
						case 237:
							return;
						case 238:
							return;
						case 239:
							type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
							num2 = 690;
							continue;
						case 240:
							return;
						case 241:
							goto IL_2AF9;
						case 242:
							if (x0cbwj80qtx55Tsu8UC == null || !ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
							{
								goto IL_31A2;
							}
							num2 = 104;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 66;
								continue;
							}
							continue;
						case 243:
							goto IL_19F9;
						case 244:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 626;
								continue;
							}
							goto IL_DDB;
						case 245:
							obj = ((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null)).GetValue(qmmmuQuSWS2kKwsrFfB.eoUqScGyAS().aYsh65bDic.RekhP3Apm0);
							num2 = 14;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 77;
								continue;
							}
							continue;
						case 246:
							goto IL_5611;
						case 247:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(intPtr));
							num2 = 293;
							continue;
						case 248:
							goto IL_45D1;
						case 249:
							goto IL_1D97;
						case 250:
							x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
							num2 = 226;
							continue;
						case 251:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto Block_297;
							}
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.pWps6362GVcZA47JFbh(qmmmuQuSWS2kKwsrFfB));
							num2 = 304;
							continue;
						case 252:
							goto IL_1D50;
						case 253:
							if (x0cbwj80qtx55Tsu8UC != null)
							{
								goto IL_2AB7;
							}
							num2 = 480;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 480;
								continue;
							}
							continue;
						case 254:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.sxo0l56ElSwYiAfexBV(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)), x0cbwj80qtx55Tsu8UC))
							{
								num2 = 12;
								continue;
							}
							goto IL_37CD;
						case 255:
							return;
						case 256:
							return;
						case 257:
							return;
						case 258:
							return;
						case 259:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DtYrLN6URkcI4jatjK4(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
							num2 = 63;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 392;
								continue;
							}
							continue;
						case 260:
							return;
						case 261:
							goto IL_DDB;
						case 262:
							goto IL_2DF6;
						case 263:
							u = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.w3ExBC6Ji0VLoUdBlWk(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.Vavhb40As7;
							num2 = 452;
							continue;
						case 264:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 44;
								continue;
							}
							goto IL_F8D;
						case 265:
							return;
						case 266:
							return;
						case 267:
							goto IL_2142;
						case 268:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								goto IL_42E8;
							}
							num2 = 28;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 100;
								continue;
							}
							continue;
						case 269:
							goto IL_433E;
						case 270:
							fieldInfo = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.firLfX2b9yQe64i2LfW(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							num2 = 27;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 51;
								continue;
							}
							continue;
						case 271:
							return;
						case 272:
							return;
						case 273:
							goto IL_41C4;
						case 274:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.BJIdYH6zVWQqA08Nnal(qmmmuQuSWS2kKwsrFfB));
							num2 = 288;
							continue;
						case 275:
							goto IL_4437;
						case 276:
							goto IL_448C;
						case 277:
							return;
						case 278:
						{
							ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR sK9Zdfu498A1KFPnIfR;
							if (sK9Zdfu498A1KFPnIfR == null)
							{
								num2 = 425;
								continue;
							}
							if (!type.IsValueType)
							{
								sK9Zdfu498A1KFPnIfR.xZMdRwMHqP(new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null));
								num2 = 256;
								continue;
							}
							num2 = 408;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 297;
								continue;
							}
							continue;
						}
						case 279:
							if (x0cbwj80qtx55Tsu8UC.snedf8QbBG())
							{
								num2 = 415;
								continue;
							}
							goto IL_31B3;
						case 280:
							return;
						case 281:
							return;
						case 282:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								num2 = 411;
								continue;
							}
							goto IL_59C2;
						case 283:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.svfakY2NeFlhg4Zolle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)), x0cbwj80qtx55Tsu8UC))
							{
								this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1));
								num2 = 527;
								continue;
							}
							num2 = 500;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 92;
								continue;
							}
							continue;
						case 284:
							goto IL_5F18;
						case 285:
							sxUaepu6HaOlCtHk6W = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.pebX2W6K3wIUj7EiTFg(constructorInfo, true, hcp9nIur8g9pimJhW0s);
							num2 = 364;
							continue;
						case 286:
							this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
							num2 = 27;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 237;
								continue;
							}
							continue;
						case 287:
							goto IL_5E1D;
						case 288:
							return;
						case 289:
							obj2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(x0cbwj80qtx55Tsu8UC, null);
							if (obj2 != null)
							{
								num2 = 215;
								continue;
							}
							goto IL_6E28;
						case 290:
							return;
						case 291:
							goto IL_3FD7;
						case 292:
							return;
						case 293:
							return;
						case 294:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								goto IL_5B5D;
							}
							num2 = 162;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 130;
								continue;
							}
							continue;
						case 295:
							goto IL_3D18;
						case 296:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.MnA3Bc2X79qx1q2YIhE(qmmmuQuSWS2kKwsrFfB));
							num2 = 125;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 175;
								continue;
							}
							continue;
						case 297:
							goto IL_4FF0;
						case 298:
							goto IL_1C53;
						case 299:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.zV7hg56f50Txkqee6LU(qmmmuQuSWS2kKwsrFfB));
								num2 = 323;
								continue;
							}
							goto IL_2C73;
						case 300:
							return;
						case 301:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qfjcD02DC7YyAwTRfsu((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).y9jq31urLD(null), qmmmuQuSWS2kKwsrFfB.eoUqScGyAS().aYsh65bDic.RekhP3Apm0);
							num2 = 665;
							continue;
						case 302:
							goto IL_69F6;
						case 303:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
							num2 = 142;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 294;
								continue;
							}
							continue;
						case 304:
							return;
						case 305:
							goto IL_5413;
						case 306:
							goto IL_D67;
						case 307:
							goto IL_44CF;
						case 308:
							goto IL_6047;
						case 309:
							return;
						case 310:
							this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.X23h5V6BX3nZEoQZY2c(array), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5));
							num2 = 141;
							continue;
						case 311:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto Block_221;
							}
							goto IL_5B31;
						case 312:
							return;
						case 313:
							type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							num2 = 418;
							continue;
						case 314:
							return;
						case 315:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.wRg08r60CT0WD97QdhM(intPtr, IntPtr.Zero))
							{
								num2 = 195;
								continue;
							}
							return;
						case 316:
							goto IL_2E1C;
						case 317:
							goto IL_37CD;
						case 318:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.y3Hvl16xbGsKhCwdXLo(fieldInfo));
							num2 = 370;
							continue;
						case 319:
							return;
						case 320:
							goto IL_1BFE;
						case 321:
							goto IL_D67;
						case 322:
							fieldInfo = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.firLfX2b9yQe64i2LfW(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							num2 = 318;
							continue;
						case 323:
							return;
						case 324:
							goto IL_1BB4;
						case 325:
							goto IL_3578;
						case 326:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 572;
							continue;
						case 327:
							if (list != null)
							{
								goto IL_6493;
							}
							num2 = 15;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 423;
								continue;
							}
							continue;
						case 328:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qfjcD02DC7YyAwTRfsu((Array)this.Qk8lqGTUrC.cL3qW1trrh().y9jq31urLD(null), qmmmuQuSWS2kKwsrFfB.eoUqScGyAS().aYsh65bDic.RekhP3Apm0);
							num2 = 163;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 181;
								continue;
							}
							continue;
						case 329:
							return;
						case 330:
							goto IL_CFA;
						case 331:
							array2[array2.Length - 1 - num5] = obj2;
							num2 = 694;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 18;
								continue;
							}
							continue;
						case 332:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dGOTPM2BTBtEuSX6cdQ(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh()), x0cbwj80qtx55Tsu8UC))
							{
								goto IL_3F37;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 333:
							goto IL_60E1;
						case 334:
							return;
						case 335:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(obj.GetType(), obj);
							num2 = 505;
							continue;
						case 336:
							intPtr2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.rAg8ryuQY6(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 414;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 436;
								continue;
							}
							continue;
						case 337:
							return;
						case 338:
							this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
							num2 = 553;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 23;
								continue;
							}
							continue;
						case 339:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DiMWpC64ohDhIPOrnBv(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)), x0cbwj80qtx55Tsu8UC))
							{
								return;
							}
							num2 = 18;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 5;
								continue;
							}
							continue;
						case 340:
							goto IL_34CD;
						case 341:
							return;
						case 342:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(type, obj);
							num2 = 444;
							continue;
						case 343:
							qmmmuQuSWS2kKwsrFfB2 = (ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
							num2 = 537;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 315;
								continue;
							}
							continue;
						case 344:
							return;
						case 345:
							if (y6ZjFnxbSGpN58JxU4F.R7lhTZ1BpZ != (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6)
							{
								goto IL_69F6;
							}
							num4 = (long)((ulong)y6ZjFnxbSGpN58JxU4F.aYsh65bDic.Vavhb40As7);
							num2 = 302;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 87;
								continue;
							}
							continue;
						case 346:
							this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(*(uint*)((void*)intPtr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6));
							num2 = 300;
							continue;
						case 347:
							return;
						case 348:
							obj = x0cbwj80qtx55Tsu8UC.y9jq31urLD(null);
							num2 = 234;
							continue;
						case 349:
							goto IL_C95;
						case 350:
							goto IL_D15;
						case 351:
							return;
						case 352:
							return;
						case 353:
							return;
						case 354:
							goto IL_29DB;
						case 355:
							goto IL_157A;
						case 356:
							goto IL_2DCA;
						case 357:
							goto IL_F35;
						case 358:
							goto IL_5449;
						case 359:
							goto IL_6CA2;
						case 360:
						{
							ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j igyi81L3PF;
							switch (igyi81L3PF)
							{
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)0:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 57;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 532;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)1:
								goto IL_53DD;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)2:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 244;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)3:
								goto IL_1BFE;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)4:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 439;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)5:
								num3 = (int)this.rhZlWn3394;
								num2 = 239;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)6:
								num3 = (int)this.rhZlWn3394;
								num2 = 322;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)7:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)30:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)123:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)125:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)157:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)168:
								return;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)8:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 549;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 281;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)9:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 343;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)10:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 441;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 414;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)11:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 219;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 20;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)12:
								type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(33554540)).Module, (int)this.rhZlWn3394);
								num2 = 700;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)13:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 585;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)14:
								goto IL_1833;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)15:
								goto IL_15CD;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)16:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								if (qmmmuQuSWS2kKwsrFfB == null)
								{
									goto IL_2A6A;
								}
								num2 = 701;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 480;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)17:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 434;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)18:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 6;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 168;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)19:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 299;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 542;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)20:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)71:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)94:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)106:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)124:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)145:
								goto IL_2A70;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)21:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 599;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 606;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)22:
								array3 = (int[])this.rhZlWn3394;
								num2 = 22;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)23:
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kARQfL6wODr8TFJZGyS(ykD11HxHfZBYH7OcFOG.SeUI5ROQ4U) == 0)
								{
									goto IL_62C8;
								}
								num2 = 424;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 332;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)24:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 27;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 52;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)25:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)73:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)80:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)109:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)117:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)132:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)163:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)175:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 718;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)26:
								num3 = (int)this.rhZlWn3394;
								num2 = 586;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 36;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)27:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 99;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)28:
								num3 = (int)this.rhZlWn3394;
								num2 = 191;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)29:
								num3 = (int)this.rhZlWn3394;
								num2 = 270;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)31:
								num3 = (int)this.rhZlWn3394;
								num2 = 414;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 36;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)32:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 207;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)33:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 227;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 551;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)34:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 476;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)35:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mUVF6l2YoIJqbMVd6KH(x0cbwj80qtx55Tsu8UC))
								{
									num2 = 177;
									continue;
								}
								goto IL_19F9;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)36:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 446;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)37:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 144;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 93;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)38:
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, this.XZ2lKJZI20[(int)this.rhZlWn3394]);
								num2 = 155;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 329;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)39:
								this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
								num2 = 232;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 567;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)40:
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((double)this.rhZlWn3394));
								num2 = 463;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)41:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 74;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 17;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)42:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 135;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)43:
								goto IL_5D82;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)44:
								goto IL_1E8A;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)45:
								goto IL_5341;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)46:
								num3 = (int)this.rhZlWn3394;
								num2 = 399;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)47:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 679;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)48:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)149:
								num3 = (int)this.rhZlWn3394;
								num2 = 58;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 86;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)49:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 42;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 210;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)50:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 283;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)51:
								goto IL_5D1E;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)52:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC);
								num2 = 562;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)53:
							{
								object obj3 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Msp8eqXF7P(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.IBiZrr2vGqw2U7SKUdW(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Noob9N2jXyWoaJ1YZTI(obj3, x0cbwj80qtx55Tsu8UC))
								{
									goto IL_5E1D;
								}
								num2 = 53;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 39;
									continue;
								}
								continue;
							}
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)54:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 590;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)55:
								this.gvMlV1YWKU = (bool)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(this.Qk8lqGTUrC.cL3qW1trrh(), Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777220)));
								num2 = 332;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 497;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)56:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 65;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)57:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 543;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 310;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)58:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 78;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 560;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)59:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 311;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 86;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)60:
								num3 = (int)this.rhZlWn3394;
								num2 = 198;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 395;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)61:
								this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.AFnvL92zEHZF9IGY8pJ(this.Qk8lqGTUrC));
								num2 = 711;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)62:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 279;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)63:
								return;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)64:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 468;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)65:
								goto IL_6312;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)66:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 254;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)67:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 326;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)68:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 36;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)69:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 7;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 11;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)70:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 593;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)72:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 486;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 637;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)74:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								if (qmmmuQuSWS2kKwsrFfB != null)
								{
									goto IL_5081;
								}
								num2 = 10;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 662;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)75:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 251;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 96;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)76:
								num3 = (int)this.rhZlWn3394;
								num2 = 172;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 38;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)77:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 236;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 177;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)78:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 597;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)79:
								num3 = (int)this.rhZlWn3394;
								num2 = 450;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 426;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)81:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 705;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)82:
								qmmmuQuSWS2kKwsrFfB = (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC) as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
								num2 = 138;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)83:
								goto IL_5A64;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)84:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 566;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)85:
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.i6Yp1h6Y1FrlQa2qQHM((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)this.Qk8lqGTUrC.cL3qW1trrh()));
								num2 = 121;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 62;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)86:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 122;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)87:
								goto IL_3E31;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)88:
								x0cbwj80qtx55Tsu8UC = this.RGflstwkfS[(int)this.rhZlWn3394];
								num2 = 464;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 317;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)89:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 603;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 373;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)90:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC);
								if (x0cbwj80qtx55Tsu8UC != null)
								{
									goto IL_666F;
								}
								num2 = 12;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 19;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)91:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 610;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)92:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 647;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)93:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 555;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)95:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 222;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)96:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 372;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)97:
								array = (Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null);
								num2 = 310;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)98:
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, this.Qk8lqGTUrC.cL3qW1trrh().s9Cd9Og84k());
								num2 = 612;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 50;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)99:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 21;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 129;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)100:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 495;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 54;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)101:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 378;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 157;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)102:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 367;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 292;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)103:
								obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).y9jq31urLD(null);
								num2 = 145;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)104:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 7;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 25;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)105:
								this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((float)this.rhZlWn3394));
								num2 = 154;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)107:
								num3 = (int)this.rhZlWn3394;
								num2 = 65;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 582;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)108:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC);
								if (x0cbwj80qtx55Tsu8UC != null && ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
								{
									goto Block_370;
								}
								goto IL_28A0;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)110:
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)126:
								num3 = (int)this.rhZlWn3394;
								num2 = 13;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 9;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)111:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 91;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)112:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 519;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 326;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)113:
								goto IL_58F4;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)114:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 571;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 660;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)115:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 447;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)116:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 109;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 401;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)118:
								num3 = (int)this.rhZlWn3394;
								num2 = 12;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 54;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)119:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 68;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 52;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)120:
								num3 = (int)this.rhZlWn3394;
								num2 = 340;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)121:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 691;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 586;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)122:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								if (qmmmuQuSWS2kKwsrFfB == null)
								{
									goto Block_383;
								}
								if (qmmmuQuSWS2kKwsrFfB2 != null)
								{
									num2 = 715;
									continue;
								}
								goto IL_3B4B;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)127:
								num3 = (int)this.rhZlWn3394;
								num2 = 313;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)128:
								this.t6plBAG1Rr = -3;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.ROQy9T2J7rpXtwJLuon(this.Qk8lqGTUrC) > 0)
								{
									num2 = 487;
									continue;
								}
								return;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)129:
								this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null));
								num2 = 116;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)130:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 349;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)131:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 202;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)133:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 245;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)134:
								this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
								num2 = 213;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 381;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)135:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 624;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)136:
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.uFRdvj6cdeOCoudbh3a(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), this.Qk8lqGTUrC.cL3qW1trrh()))
								{
									num2 = 564;
									continue;
								}
								goto IL_67C0;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)137:
								flag = false;
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 59;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 70;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)138:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 391;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)139:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 267;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 371;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)140:
								goto IL_3D78;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)141:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 339;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)142:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 332;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)143:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 651;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)144:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 134;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)146:
							{
								object obj4 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Noob9N2jXyWoaJ1YZTI(obj4, x0cbwj80qtx55Tsu8UC))
								{
									goto IL_3BF8;
								}
								num2 = 59;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 160;
									continue;
								}
								continue;
							}
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)147:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 328;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)148:
								x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
								num2 = 716;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)150:
								qmmmuQuSWS2kKwsrFfB = (this.Qk8lqGTUrC.cL3qW1trrh() as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
								intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DW098i6nFT1RBWiJmJe(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 336;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 200;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)151:
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.RkaCwuuTDIa2A6Qvy0B((int)this.rhZlWn3394, this));
								num2 = 309;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 27;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)152:
								goto IL_2D4D;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)153:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 45;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 218;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)154:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
								num2 = 388;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)155:
								goto IL_2A76;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)156:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 48;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 526;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)158:
								num3 = (int)this.rhZlWn3394;
								num2 = 646;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)159:
								num3 = (int)this.rhZlWn3394;
								type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
								num2 = 504;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)160:
								goto IL_2B54;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)161:
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((long)this.rhZlWn3394));
								num2 = 469;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)162:
								intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.HNttJW633ZrRfjMO9La(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC) as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
								num2 = 366;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 151;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)164:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 231;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 200;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)165:
								goto IL_6B18;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)166:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 32;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)167:
								this.lgq8RX6Fc5(true);
								num2 = 163;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
								{
									num2 = 114;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)169:
								goto IL_27E2;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)170:
								x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
								num2 = 478;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)171:
							{
								ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB3 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.AFnvL92zEHZF9IGY8pJ(this.Qk8lqGTUrC));
								if (qmmmuQuSWS2kKwsrFfB3 == null)
								{
									goto Block_444;
								}
								ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs oMK8iyuIab2LETlLsfs = qmmmuQuSWS2kKwsrFfB3 as ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs;
								num2 = 571;
								continue;
							}
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)172:
								num3 = (int)this.rhZlWn3394;
								num2 = 633;
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)173:
								qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
								num2 = 369;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 430;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j)174:
								goto IL_30DC;
							default:
								num2 = 190;
								continue;
							}
							break;
						}
						case 361:
						{
							ykD11HxHfZBYH7OcFOG.k5A7Al8NeNFaSr1YO2j igyi81L3PF = \u0020.Igyi81L3PF;
							num2 = 360;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 195;
								continue;
							}
							continue;
						}
						case 362:
							goto IL_42BC;
						case 363:
							if (x0cbwj80qtx55Tsu8UC == null)
							{
								goto IL_1745;
							}
							num2 = 10;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 212;
								continue;
							}
							continue;
						case 364:
							goto IL_2FE9;
						case 365:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kJcu0S2sj0oAUHfqmg6(qmmmuQuSWS2kKwsrFfB));
							num2 = 563;
							continue;
						case 366:
							if (this.yHPlGnPngy != null)
							{
								num2 = 548;
								continue;
							}
							goto IL_345B;
						case 367:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 48;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 84;
								continue;
							}
							continue;
						case 368:
							goto IL_2B3B;
						case 369:
							return;
						case 370:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
							num2 = 289;
							continue;
						case 371:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
							num2 = 112;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 372:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 568;
								continue;
							}
							goto IL_157A;
						case 373:
							goto IL_6D79;
						case 374:
							return;
						case 375:
							goto IL_1D78;
						case 376:
							return;
						case 377:
							IL_35ED:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(qmmmuQuSWS2kKwsrFfB))
							{
								goto IL_2B3B;
							}
							num2 = 55;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 20;
								continue;
							}
							continue;
						case 378:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC);
							num2 = 588;
							continue;
						case 379:
							return;
						case 380:
							goto IL_5E33;
						case 381:
							this.g2tlnWc570 = true;
							num2 = 171;
							continue;
						case 382:
							goto IL_43F8;
						case 383:
							goto IL_4A8A;
						case 384:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
							num2 = 473;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 4;
								continue;
							}
							continue;
						case 385:
							goto IL_3E92;
						case 386:
							return;
						case 387:
							goto IL_6587;
						case 388:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_2E5B;
							}
							num2 = 208;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 274;
								continue;
							}
							continue;
						case 389:
							goto IL_3613;
						case 390:
							goto IL_4A2E;
						case 391:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 488;
								continue;
							}
							goto IL_372D;
						case 392:
							return;
						case 393:
							goto IL_2AB7;
						case 394:
							return;
						case 395:
							type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module.ResolveType(num3);
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
							num2 = 301;
							continue;
						case 396:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 146;
								continue;
							}
							goto IL_6332;
						case 397:
							goto IL_6441;
						case 398:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(x0cbwj80qtx55Tsu8UC);
							num2 = 114;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 90;
								continue;
							}
							continue;
						case 399:
							module = Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module;
							num2 = 10;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 159;
								continue;
							}
							continue;
						case 400:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xPKFeF67oIEN2M5pvl0(qmmmuQuSWS2kKwsrFfB));
							num2 = 151;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 97;
								continue;
							}
							continue;
						case 401:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 166;
								continue;
							}
							goto IL_6E4C;
						case 402:
							return;
						case 403:
							goto IL_222C;
						case 404:
							return;
						case 405:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eypu226HVfIansf7PwU(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)).y9jq31urLD(type);
							num2 = 206;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 194;
								continue;
							}
							continue;
						case 406:
							goto IL_4D08;
						case 407:
							goto IL_4C9E;
						case 408:
						{
							obj = Activator.CreateInstance(type);
							ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR sK9Zdfu498A1KFPnIfR;
							sK9Zdfu498A1KFPnIfR.xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(type, obj));
							num2 = 316;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 474;
								continue;
							}
							continue;
						}
						case 409:
							return;
						case 410:
							flag = false;
							num2 = 536;
							continue;
						case 411:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_59C2;
							}
							num2 = 184;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 325;
								continue;
							}
							continue;
						case 412:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nSD07y6AlE0Jma3rCu5(module, (int)this.rhZlWn3394 | 1879048192)));
							num2 = 88;
							continue;
						case 413:
							u = (uint)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XCi8qlVP6o(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3));
							num2 = 49;
							continue;
						case 414:
							constructorInfo = (ConstructorInfo)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SXjTgW6d9WTLVJjAC1A(Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							num2 = 443;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 91;
								continue;
							}
							continue;
						case 415:
							x0cbwj80qtx55Tsu8UC = ((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)x0cbwj80qtx55Tsu8UC).FOJqpHkit6();
							num2 = 30;
							continue;
						case 416:
							goto IL_4614;
						case 417:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.C4RYcd2muw4o4uopGsp(qmmmuQuSWS2kKwsrFfB))
							{
								num2 = 284;
								continue;
							}
							goto IL_5468;
						case 418:
						{
							ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR sK9Zdfu498A1KFPnIfR = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC) as ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR;
							num2 = 278;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 101;
								continue;
							}
							continue;
						}
						case 419:
							goto IL_6D5A;
						case 420:
							return;
						case 421:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto Block_179;
							}
							goto IL_23E3;
						case 422:
							goto IL_28A0;
						case 423:
							list = new List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V>();
							num2 = 245;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 458;
								continue;
							}
							continue;
						case 424:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX(ykD11HxHfZBYH7OcFOG.SeUI5ROQ4U[(int)this.rhZlWn3394]));
							num2 = 151;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 515;
								continue;
							}
							continue;
						case 425:
							goto IL_105A;
						case 426:
							if (x0cbwj80qtx55Tsu8UC != null)
							{
								goto IL_6219;
							}
							num2 = 367;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 707;
								continue;
							}
							continue;
						case 427:
							goto IL_F8D;
						case 428:
							obj = Activator.CreateInstance(type);
							num2 = 383;
							continue;
						case 429:
							goto IL_4DC5;
						case 430:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qfjcD02DC7YyAwTRfsu((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
							num2 = 462;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 170;
								continue;
							}
							continue;
						case 431:
							goto IL_4103;
						case 432:
							return;
						case 433:
							goto IL_2938;
						case 434:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qfjcD02DC7YyAwTRfsu((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).y9jq31urLD(null), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
							num2 = 112;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 185;
								continue;
							}
							continue;
						case 435:
							goto IL_15FA;
						case 436:
							if (intPtr != IntPtr.Zero)
							{
								goto IL_45D1;
							}
							num2 = 496;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 382;
								continue;
							}
							continue;
						case 437:
							if (sxUaepu6HaOlCtHk6W == null)
							{
								num2 = 616;
								continue;
							}
							goto IL_6D79;
						case 438:
							goto IL_1848;
						case 439:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xUDbGN6R4M3a7S23DO1(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)), x0cbwj80qtx55Tsu8UC))
							{
								return;
							}
							num2 = 69;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 338;
								continue;
							}
							continue;
						case 440:
							goto IL_3631;
						case 441:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								goto IL_1E39;
							}
							num2 = 630;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 221;
								continue;
							}
							continue;
						case 442:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777346)), obj));
							num2 = 45;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 223;
								continue;
							}
							continue;
						case 443:
							parameters = constructorInfo.GetParameters();
							num2 = 232;
							continue;
						case 444:
							goto IL_44CF;
						case 445:
							((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)x0cbwj80qtx55Tsu8UC).xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(type, obj2));
							num2 = 155;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 14;
								continue;
							}
							continue;
						case 446:
							goto IL_2523;
						case 447:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								goto IL_53C0;
							}
							num2 = 534;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 484;
								continue;
							}
							continue;
						case 448:
							goto IL_1AD2;
						case 449:
							goto IL_3F37;
						case 450:
							Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module.ResolveType(num3);
							num2 = 509;
							continue;
						case 451:
							goto IL_4594;
						case 452:
						{
							byte n05hvQHtOX;
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.t39osk6bPq79hgBsAAP(intPtr, n05hvQHtOX, (int)u);
							num2 = 580;
							continue;
						}
						case 453:
							goto IL_2907;
						case 454:
							return;
						case 455:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.slfUwc6P1ZXtyGDfV2K(qmmmuQuSWS2kKwsrFfB));
							num2 = 565;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 73;
								continue;
							}
							continue;
						case 456:
							goto IL_29E1;
						case 457:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu(fieldInfo, obj));
							num2 = 657;
							continue;
						case 458:
							goto IL_6493;
						case 459:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.y3Hvl16xbGsKhCwdXLo(fieldInfo));
							num2 = 676;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 513;
								continue;
							}
							continue;
						case 460:
							if (!type.IsAssignableFrom(obj.GetType()))
							{
								this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null));
								num2 = 105;
								continue;
							}
							this.Qk8lqGTUrC.CBp8byx5jM(x0cbwj80qtx55Tsu8UC);
							num2 = 514;
							continue;
						case 461:
							return;
						case 462:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777328)), obj));
							num2 = 581;
							continue;
						case 463:
							return;
						case 464:
							this.Qk8lqGTUrC.CBp8byx5jM(x0cbwj80qtx55Tsu8UC);
							num2 = 73;
							continue;
						case 465:
							goto IL_467F;
						case 466:
							goto IL_67C0;
						case 467:
							this.XZ2lKJZI20[num3] = this.V9yuBsGNOs(this.Qk8lqGTUrC.cL3qW1trrh(), this.OOMlcvRAjr.C12iMMW3JJ[num3 - 1].b6YiSr1Ws1, false);
							num2 = 351;
							continue;
						case 468:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC);
							num2 = 242;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 88;
								continue;
							}
							continue;
						case 469:
							return;
						case 470:
							return;
						case 471:
							list = null;
							num2 = 501;
							continue;
						case 472:
							goto IL_55CC;
						case 473:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(x0cbwj80qtx55Tsu8UC, null);
							num2 = 205;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 570;
								continue;
							}
							continue;
						case 474:
							return;
						case 475:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(qmmmuQuSWS2kKwsrFfB))
							{
								goto IL_58EE;
							}
							num2 = 61;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 27;
								continue;
							}
							continue;
						case 476:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 618;
								continue;
							}
							goto IL_4726;
						case 477:
							IL_4800:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(qmmmuQuSWS2kKwsrFfB))
							{
								num2 = 7;
								continue;
							}
							goto IL_1596;
						case 478:
							goto IL_1C5D;
						case 479:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.YyWJBg68hcawfFVOWa7(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
							num2 = 280;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 43;
								continue;
							}
							continue;
						case 480:
							goto IL_3DAF;
						case 481:
							goto IL_6768;
						case 482:
							array4 = new ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[parameters.Length];
							num2 = 471;
							continue;
						case 483:
							IL_49CB:
							if (qmmmuQuSWS2kKwsrFfB.tXF8H2TS5Y())
							{
								intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.f5jHoN24g0jBEI5KuTG((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB);
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(*(int*)((void*)intPtr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5));
								num2 = 420;
								continue;
							}
							goto IL_2A4C;
						case 484:
							goto IL_2D6B;
						case 485:
							goto IL_4B0A;
						case 486:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(*(short*)((void*)intPtr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3));
							num2 = 165;
							continue;
						case 487:
							this.Goelx4gccH = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
							num2 = 491;
							continue;
						case 488:
							goto IL_3386;
						case 489:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 704;
								continue;
							}
							goto IL_2B83;
						case 490:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								num2 = 153;
								continue;
							}
							goto IL_367D;
						case 491:
							return;
						case 492:
							goto IL_5B5D;
						case 493:
							if (num4 >= 0L)
							{
								num2 = 510;
								continue;
							}
							return;
						case 494:
							goto IL_6E28;
						case 495:
							goto IL_308C;
						case 496:
							goto IL_2A2C;
						case 497:
							this.RQPlpS4Dct = true;
							num2 = 148;
							continue;
						case 498:
							return;
						case 499:
							goto IL_6521;
						case 500:
							goto IL_5A92;
						case 501:
							hcp9nIur8g9pimJhW0s = null;
							num5 = 0;
							num2 = 431;
							continue;
						case 502:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0));
							num2 = 266;
							continue;
						case 503:
							goto IL_5EBF;
						case 504:
						{
							ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR sK9Zdfu498A1KFPnIfR2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC) as ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR;
							if (sK9Zdfu498A1KFPnIfR2 == null)
							{
								goto Block_448;
							}
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(sK9Zdfu498A1KFPnIfR2, type);
							num2 = 21;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 12;
								continue;
							}
							continue;
						}
						case 505:
							goto IL_29E1;
						case 506:
							goto IL_5EAA;
						case 507:
							goto IL_62C8;
						case 508:
							goto IL_B88;
						case 509:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 228;
							continue;
						case 510:
							this.t6plBAG1Rr = array3[(int)(checked((IntPtr)num4))] - 1;
							num2 = 600;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 492;
								continue;
							}
							continue;
						case 511:
							return;
						case 512:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.RHE8vN6vVwFwVlapkgl(qmmmuQuSWS2kKwsrFfB));
							num2 = 205;
							continue;
						case 513:
							return;
						case 514:
							return;
						case 515:
							return;
						case 516:
							return;
						case 517:
							goto IL_2891;
						case 518:
							hcp9nIur8g9pimJhW0s = new ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s(constructorInfo, list);
							num2 = 285;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 226;
								continue;
							}
							continue;
						case 519:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 455;
								continue;
							}
							goto IL_1245;
						case 520:
							goto IL_3DAF;
						case 521:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 69;
								continue;
							}
							goto IL_4518;
						case 522:
							goto IL_365F;
						case 523:
							return;
						case 524:
							goto IL_D41;
						case 525:
							return;
						case 526:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
							num2 = 489;
							continue;
						case 527:
							return;
						case 528:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.EAHrx46L8FTbxLhJXst(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
							num2 = 48;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 12;
								continue;
							}
							continue;
						case 529:
							goto IL_4FD9;
						case 530:
							goto IL_584E;
						case 531:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((long)num3, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12));
							num2 = 272;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 369;
								continue;
							}
							continue;
						case 532:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh()).sxQd1txC3H(x0cbwj80qtx55Tsu8UC))
							{
								return;
							}
							num2 = 226;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 286;
								continue;
							}
							continue;
						case 533:
							goto IL_4567;
						case 534:
							goto IL_1919;
						case 535:
							goto IL_421B;
						case 536:
							if (!type.IsByRef)
							{
								goto IL_3FD7;
							}
							num2 = 17;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 47;
								continue;
							}
							continue;
						case 537:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								goto IL_6252;
							}
							num2 = 600;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 683;
								continue;
							}
							continue;
						case 538:
							goto IL_6139;
						case 539:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								goto IL_4437;
							}
							num2 = 406;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 55;
								continue;
							}
							continue;
						case 540:
							return;
						case 541:
							return;
						case 542:
							obj = ((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).y9jq31urLD(null)).GetValue(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
							num2 = 442;
							continue;
						case 543:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 268;
							continue;
						case 544:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								num2 = 638;
								continue;
							}
							goto IL_1A21;
						case 545:
							obj2 = null;
							num2 = 410;
							continue;
						case 546:
							return;
						case 547:
							return;
						case 548:
							goto IL_3D98;
						case 549:
							if (x0cbwj80qtx55Tsu8UC.snedf8QbBG())
							{
								goto Block_135;
							}
							goto IL_4567;
						case 550:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(*(long*)((void*)intPtr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7));
							num2 = 523;
							continue;
						case 551:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 164;
								continue;
							}
							goto IL_2ED0;
						case 552:
							if (!qmmmuQuSWS2kKwsrFfB.tXF8H2TS5Y())
							{
								goto Block_203;
							}
							goto IL_5E4B;
						case 553:
							return;
						case 554:
							return;
						case 555:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_33F1;
							}
							num2 = 512;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 403;
								continue;
							}
							continue;
						case 556:
							try
							{
								obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(module, num3);
								goto IL_6EB8;
							}
							catch
							{
								try
								{
									obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SXjTgW6d9WTLVJjAC1A(module, num3);
								}
								catch
								{
									int num6 = 0;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
									{
										num6 = 0;
									}
									switch (num6)
									{
									default:
										try
										{
											obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.firLfX2b9yQe64i2LfW(module, num3);
										}
										catch
										{
											int num7 = 0;
											if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
											{
												num7 = 0;
											}
											switch (num7)
											{
											default:
												obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NoufUf6ojMfWgKMUwVO(module, num3);
												break;
											}
										}
										break;
									}
								}
								goto IL_6EB8;
							}
							goto IL_F2F;
						case 557:
							goto IL_2248;
						case 558:
							goto IL_345B;
						case 559:
							num4 = qmmmuQuSWS2kKwsrFfB.JWZqiAqFR8().OluhFK2lXQ.Y3Why5AObT;
							num2 = 103;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 27;
								continue;
							}
							continue;
						case 560:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 539;
							continue;
						case 561:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.o1ZqfYXchM());
							num2 = 554;
							continue;
						case 562:
							x0cbwj80qtx55Tsu8UC3 = this.Qk8lqGTUrC.cL3qW1trrh();
							num2 = 107;
							continue;
						case 563:
							return;
						case 564:
							goto IL_3FB8;
						case 565:
							return;
						case 566:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(x0cbwj80qtx55Tsu8UC);
							num2 = 426;
							continue;
						case 567:
							return;
						case 568:
							goto IL_527D;
						case 569:
							goto IL_50BE;
						case 570:
							if (obj != null)
							{
								num2 = 460;
								continue;
							}
							goto IL_56C1;
						case 571:
						{
							ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs oMK8iyuIab2LETlLsfs;
							if (oMK8iyuIab2LETlLsfs == null)
							{
								return;
							}
							num2 = 574;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 482;
								continue;
							}
							continue;
						}
						case 572:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								goto IL_2AF9;
							}
							num2 = 134;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 152;
								continue;
							}
							continue;
						case 573:
							goto IL_4BC5;
						case 574:
						{
							ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs oMK8iyuIab2LETlLsfs;
							if (double.IsNaN(oMK8iyuIab2LETlLsfs.PvjigoKUew))
							{
								ngYCBhqPZ7YsxPQyJh = (ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)2;
								num2 = 227;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 557;
									continue;
								}
								continue;
							}
							else
							{
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Xx2idY6Wfq4e4FIbJfr(oMK8iyuIab2LETlLsfs.PvjigoKUew))
								{
									ngYCBhqPZ7YsxPQyJh = (ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)1;
									num2 = 416;
									continue;
								}
								return;
							}
							break;
						}
						case 575:
							goto IL_2DCA;
						case 576:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NbAJVcNW3v4hEAXBLcy((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)x0cbwj80qtx55Tsu8UC);
							num2 = 634;
							continue;
						case 577:
							obj2 = Activator.CreateInstance(type);
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 1;
								continue;
							}
							continue;
						case 578:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 282;
							continue;
						case 579:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(qmmmuQuSWS2kKwsrFfB))
							{
								num2 = 451;
								continue;
							}
							goto IL_573D;
						case 580:
							return;
						case 581:
							return;
						case 582:
							this.RGflstwkfS[num3] = this.V9yuBsGNOs(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), this.OOMlcvRAjr.u7wi6eANjd[num3].ob0itY7ilV, this.OOMlcvRAjr.u7wi6eANjd[num3].MnbiZVlnrv);
							num2 = 120;
							continue;
						case 583:
							return;
						case 584:
							goto IL_6F0A;
						case 585:
							goto IL_22A1;
						case 586:
							fieldInfo = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.firLfX2b9yQe64i2LfW(Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
							num2 = 663;
							continue;
						case 587:
							goto IL_1E1B;
						case 588:
							if (x0cbwj80qtx55Tsu8UC != null)
							{
								num2 = 225;
								continue;
							}
							goto IL_3FA3;
						case 589:
							goto IL_5B31;
						case 590:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qfjcD02DC7YyAwTRfsu((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
							num2 = 661;
							continue;
						case 591:
							if (obj != null)
							{
								num2 = 176;
								continue;
							}
							goto IL_D41;
						case 592:
							return;
						case 593:
						{
							bool flag2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.sxo0l56ElSwYiAfexBV(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC)), x0cbwj80qtx55Tsu8UC);
							if (flag2)
							{
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1));
							}
							else
							{
								this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0));
							}
							if (!flag2)
							{
								return;
							}
							num2 = 10;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 4;
								continue;
							}
							continue;
						}
						case 594:
							goto IL_1D50;
						case 595:
							goto IL_53C0;
						case 596:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								goto Block_39;
							}
							goto IL_43F8;
						case 597:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC);
							num2 = 150;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 76;
								continue;
							}
							continue;
						case 598:
							if (type.IsValueType)
							{
								obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.tDD87hmSs4(obj);
							}
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(type, obj);
							num2 = 307;
							continue;
						case 599:
						{
							Array array5 = (Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).y9jq31urLD(null);
							type = array5.GetType().GetElementType();
							array5.SetValue(x0cbwj80qtx55Tsu8UC.y9jq31urLD(type), qmmmuQuSWS2kKwsrFfB.eoUqScGyAS().aYsh65bDic.RekhP3Apm0);
							num2 = 8;
							continue;
						}
						case 600:
							return;
						case 601:
							goto IL_23D1;
						case 602:
							goto IL_4E5C;
						case 603:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 596;
							continue;
						case 604:
							goto IL_1B56;
						case 605:
							return;
						case 606:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_1E66;
							}
							num2 = 674;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 600;
								continue;
							}
							continue;
						case 607:
							goto IL_4103;
						case 608:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								num2 = 249;
								continue;
							}
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								goto IL_4E5C;
							}
							num2 = 190;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 273;
								continue;
							}
							continue;
						case 609:
							return;
						case 610:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 644;
								continue;
							}
							goto IL_3549;
						case 611:
							goto IL_24E7;
						case 612:
							return;
						case 613:
							return;
						case 614:
							goto IL_44C3;
						case 615:
							goto IL_6731;
						case 616:
							goto IL_5EAA;
						case 617:
							x0cbwj80qtx55Tsu8UC = (obj2 as ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC);
							num2 = 291;
							continue;
						case 618:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.lG5Nom6jk8qKhEPw5T1(qmmmuQuSWS2kKwsrFfB));
							num2 = 111;
							continue;
						case 619:
							goto IL_3D98;
						case 620:
							goto IL_6E00;
						case 621:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(type, obj);
							num2 = 584;
							continue;
						case 622:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.IJDk1J2eybZ57T1Swsj(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
							num2 = 257;
							continue;
						case 623:
							return;
						case 624:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								num2 = 167;
								continue;
							}
							goto IL_6441;
						case 625:
							return;
						case 626:
							goto IL_45A3;
						case 627:
							if (!x0cbwj80qtx55Tsu8UC.TB5dFM9QIv())
							{
								num2 = 453;
								continue;
							}
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								goto Block_377;
							}
							goto IL_2907;
						case 628:
							goto IL_48A6;
						case 629:
							return;
						case 630:
							goto IL_3E83;
						case 631:
							return;
						case 632:
							goto IL_6332;
						case 633:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.v2RQvk6DylsVnr666ui(this.OOMlcvRAjr.tvNiDLeBvW))
							{
								goto Block_415;
							}
							goto IL_3E92;
						case 634:
							goto IL_3CAF;
						case 635:
							goto IL_5C56;
						case 636:
							return;
						case 637:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qfjcD02DC7YyAwTRfsu((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
							num2 = 706;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 600;
								continue;
							}
							continue;
						case 638:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 132;
								continue;
							}
							goto IL_1A21;
						case 639:
							return;
						case 640:
							goto IL_6152;
						case 641:
							return;
						case 642:
							goto IL_3E21;
						case 643:
							goto IL_41F4;
						case 644:
							this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Yw7pKo6SNAQGhPpJ5ut(qmmmuQuSWS2kKwsrFfB));
							num2 = 57;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 376;
								continue;
							}
							continue;
						case 645:
							num4 = (long)((int)num4);
							num2 = 604;
							continue;
						case 646:
							type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(33554540)).Module, num3);
							num2 = 384;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 243;
								continue;
							}
							continue;
						case 647:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh()).WY8dpeljbh(x0cbwj80qtx55Tsu8UC))
							{
								num2 = 75;
								continue;
							}
							goto IL_3D18;
						case 648:
							if (obj2 is ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC)
							{
								num2 = 617;
								continue;
							}
							goto IL_67B3;
						case 649:
							goto IL_1F7A;
						case 650:
							goto IL_3413;
						case 651:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_484D;
							}
							num2 = 400;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 255;
								continue;
							}
							continue;
						case 652:
							goto IL_67B3;
						case 653:
							IL_2487:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(qmmmuQuSWS2kKwsrFfB))
							{
								num2 = 438;
								continue;
							}
							goto IL_467F;
						case 654:
							return;
						case 655:
							goto IL_367D;
						case 656:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								num2 = 208;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num2 = 181;
									continue;
								}
								continue;
							}
							else
							{
								if (qmmmuQuSWS2kKwsrFfB == null)
								{
									goto Block_341;
								}
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Yyfb8u65WZelCkMXfEE(qmmmuQuSWS2kKwsrFfB2, x0cbwj80qtx55Tsu8UC))
								{
									num2 = 502;
									continue;
								}
								goto IL_15FA;
							}
							break;
						case 657:
							return;
						case 658:
							return;
						case 659:
							goto IL_4B32;
						case 660:
							obj = ((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).y9jq31urLD(null)).GetValue(qmmmuQuSWS2kKwsrFfB.eoUqScGyAS().aYsh65bDic.RekhP3Apm0);
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777256)), obj));
							num2 = 481;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 698;
								continue;
							}
							continue;
						case 661:
							goto IL_1AF3;
						case 662:
							goto IL_25E2;
						case 663:
							goto IL_6B66;
						case 664:
							goto IL_5E4B;
						case 665:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(type, obj));
							num2 = 72;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 72;
								continue;
							}
							continue;
						case 666:
							goto IL_64B2;
						case 667:
							goto IL_39DA;
						case 668:
							if (x0cbwj80qtx55Tsu8UC == null)
							{
								num2 = 67;
								continue;
							}
							goto IL_6152;
						case 669:
							goto IL_2F13;
						case 670:
							goto IL_278E;
						case 671:
							goto IL_23E3;
						case 672:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_3FA3;
							}
							num2 = 224;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 18;
								continue;
							}
							continue;
						case 673:
							goto IL_4AF0;
						case 674:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.j5lqLol41P());
							num2 = 101;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 38;
								continue;
							}
							continue;
						case 675:
							if (!(x0cbwj80qtx55Tsu8UC is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu))
							{
								num2 = 187;
								continue;
							}
							goto IL_61EE;
						case 676:
							fieldInfo.SetValue(null, obj);
							num2 = 217;
							continue;
						case 677:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC3);
							num2 = 544;
							continue;
						case 678:
							return;
						case 679:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qfjcD02DC7YyAwTRfsu((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(this.Qk8lqGTUrC.cL3qW1trrh(), null), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
							num2 = 43;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 29;
								continue;
							}
							continue;
						case 680:
							goto IL_3FD7;
						case 681:
							return;
						case 682:
							goto IL_6D13;
						case 683:
							goto IL_5492;
						case 684:
							goto IL_2E1C;
						case 685:
							x0cbwj80qtx55Tsu8UC3 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
							num2 = 677;
							continue;
						case 686:
							u = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.w3ExBC6Ji0VLoUdBlWk(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.Vavhb40As7;
							num2 = 359;
							continue;
						case 687:
							goto IL_11A7;
						case 688:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_6994;
							}
							goto IL_D15;
						case 689:
							return;
						case 690:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 95;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 43;
								continue;
							}
							continue;
						case 691:
							qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 82;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 72;
								continue;
							}
							continue;
						case 692:
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JDTfAS6QHuMfwQeIPNP((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)x0cbwj80qtx55Tsu8UC);
							num2 = 209;
							continue;
						case 693:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.j0RygE6ChFrQYPDdRXT(type);
							num2 = 232;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 342;
								continue;
							}
							continue;
						case 694:
							num5++;
							num2 = 607;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 74;
								continue;
							}
							continue;
						case 695:
							return;
						case 696:
							return;
						case 697:
							return;
						case 698:
							return;
						case 699:
							if (qmmmuQuSWS2kKwsrFfB2 == null)
							{
								num2 = 484;
								continue;
							}
							goto IL_6D13;
						case 700:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(this.Qk8lqGTUrC.cL3qW1trrh(), type);
							num2 = 156;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 37;
								continue;
							}
							continue;
						case 701:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.FmZq4JYpT6());
							num2 = 681;
							continue;
						case 702:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 259;
								continue;
							}
							goto IL_5010;
						case 703:
							goto IL_52EF;
						case 704:
							if (qmmmuQuSWS2kKwsrFfB2 != null)
							{
								goto IL_1E1B;
							}
							num2 = 508;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 9;
								continue;
							}
							continue;
						case 705:
							if (qmmmuQuSWS2kKwsrFfB == null)
							{
								goto IL_5D9D;
							}
							num2 = 157;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 193;
								continue;
							}
							continue;
						case 706:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777561)), obj));
							num2 = 272;
							continue;
						case 707:
							goto IL_6994;
						case 708:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(x0cbwj80qtx55Tsu8UC);
							num2 = 157;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 139;
								continue;
							}
							continue;
						case 709:
							return;
						case 710:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eYLLJT2Hd9e0Wdb6UL0() != 8)
							{
								num3 = *(int*)((void*)intPtr);
								num2 = 531;
								continue;
							}
							num2 = 528;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 611;
								continue;
							}
							continue;
						case 711:
							return;
						case 712:
							if (qmmmuQuSWS2kKwsrFfB != null)
							{
								num2 = 192;
								continue;
							}
							goto IL_4CDA;
						case 713:
							return;
						case 714:
							goto IL_6252;
						case 715:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.tkEApG6hNEvTi61vDxs(qmmmuQuSWS2kKwsrFfB, qmmmuQuSWS2kKwsrFfB2));
							num2 = 470;
							continue;
						case 716:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mUVF6l2YoIJqbMVd6KH(x0cbwj80qtx55Tsu8UC))
							{
								goto IL_22B6;
							}
							num2 = 692;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 290;
								continue;
							}
							continue;
						case 717:
							goto IL_2142;
						case 718:
							qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
							num2 = 599;
							continue;
						case 719:
							return;
						case 720:
							goto IL_1815;
						case 721:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
							{
								num2 = 396;
								continue;
							}
							goto IL_3F81;
						case 722:
							goto IL_6587;
						case 723:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(*(ushort*)((void*)intPtr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4));
							num2 = 511;
							continue;
						case 724:
							goto IL_2D01;
						}
						goto Block_1;
						IL_4518:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							num2 = 298;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 112;
								continue;
							}
							continue;
						}
						else
						{
							if (!qmmmuQuSWS2kKwsrFfB.tXF8H2TS5Y())
							{
								num2 = 29;
								continue;
							}
							intPtr = ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB).oM8u8TUrCx();
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(*(double*)((void*)intPtr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)10));
							num2 = 546;
							continue;
						}
						IL_666F:
						if (x0cbwj80qtx55Tsu8UC.TB5dFM9QIv())
						{
							num2 = 521;
							continue;
						}
						goto IL_4518;
						IL_D15:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.EWnKTG2TixUljaDFR5D(qmmmuQuSWS2kKwsrFfB));
						num2 = 21;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 41;
							continue;
						}
						continue;
						IL_D41:
						if (!type.IsValueType)
						{
							goto IL_23D1;
						}
						num2 = 83;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 82;
							continue;
						}
						continue;
						IL_D67:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(type, obj);
						num2 = 27;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 38;
							continue;
						}
						continue;
						IL_DDB:
						this.Qk8lqGTUrC.CBp8byx5jM(qmmmuQuSWS2kKwsrFfB.rvkqNso51v());
						num2 = 695;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 362;
							continue;
						}
						continue;
						IL_F35:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.vrDy8U6Vc3ZKTeuNQSW(fieldInfo, obj2, obj);
						num2 = 211;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 126;
							continue;
						}
						continue;
						IL_F8D:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.a9Dj5469ngL67ye7C67(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
						num2 = 696;
						continue;
						IL_157A:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.c9jFu46THs9bld9aRCx(qmmmuQuSWS2kKwsrFfB));
						num2 = 525;
						continue;
						IL_1596:
						intPtr = ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB).oM8u8TUrCx();
						num2 = 346;
						continue;
						IL_2907:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto Block_124;
						}
						goto IL_4800;
						IL_15FA:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1));
						num2 = 178;
						continue;
						IL_1728:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.qJhqHVUG8k());
						num2 = 713;
						continue;
						IL_44C3:
						if (qmmmuQuSWS2kKwsrFfB != null)
						{
							goto IL_1728;
						}
						IL_1745:
						if (qmmmuQuSWS2kKwsrFfB != null)
						{
							num2 = 579;
							continue;
						}
						goto IL_6E91;
						IL_19F9:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.EWnKTG2TixUljaDFR5D((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)x0cbwj80qtx55Tsu8UC);
						num2 = 164;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 198;
							continue;
						}
						continue;
						IL_1A21:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.uFRdvj6cdeOCoudbh3a(x0cbwj80qtx55Tsu8UC, x0cbwj80qtx55Tsu8UC3))
						{
							this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
							num2 = 80;
							continue;
						}
						return;
						IL_1A7C:
						this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
						num2 = 402;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 185;
							continue;
						}
						continue;
						IL_1BFE:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
						num2 = 554;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 708;
							continue;
						}
						continue;
						IL_365F:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num8]).IsByRef)
						{
							num2 = 305;
							continue;
						}
						if (hcp9nIur8g9pimJhW0s == null)
						{
							num2 = 81;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 717;
								continue;
							}
							continue;
						}
						else
						{
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Kjq5xa6kdOlQKKKNDed(hcp9nIur8g9pimJhW0s, num8))
							{
								num2 = 267;
								continue;
							}
							goto IL_5413;
						}
						IL_1D50:
						if (num8 >= parameters.Length)
						{
							num2 = 79;
							continue;
						}
						goto IL_365F;
						IL_1E1B:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LEeZkcNEH2m16GJP5a6(qmmmuQuSWS2kKwsrFfB, qmmmuQuSWS2kKwsrFfB2));
						num2 = 613;
						continue;
						IL_1E39:
						this.Qk8lqGTUrC.CBp8byx5jM(qmmmuQuSWS2kKwsrFfB.lZtq7DP5OI());
						num2 = 184;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 292;
							continue;
						}
						continue;
						IL_6252:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto Block_387;
						}
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB2.iHaqzsE4Kf(qmmmuQuSWS2kKwsrFfB));
						num2 = 636;
						continue;
						IL_222C:
						this.Qk8lqGTUrC.CBp8byx5jM(qmmmuQuSWS2kKwsrFfB.CY1qBxKBHt());
						num2 = 197;
						continue;
						IL_22B6:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yxTqPB2gVj6q2Wa8L3S(this.Qk8lqGTUrC.cL3qW1trrh(), x0cbwj80qtx55Tsu8UC);
						num2 = 14;
						continue;
						IL_23D1:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
						num2 = 89;
						continue;
						IL_23E3:
						this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.YIFnkv6y2hr2ZRJjbE0(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
						num2 = 199;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 17;
							continue;
						}
						continue;
						IL_6994:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							num2 = 28;
							continue;
						}
						goto IL_2487;
						IL_6219:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
						{
							goto IL_6994;
						}
						num2 = 688;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 449;
							continue;
						}
						continue;
						IL_264A:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nrx4Oo27LiAVUJGhIXw(qmmmuQuSWS2kKwsrFfB));
						num2 = 334;
						continue;
						IL_26AC:
						if (qmmmuQuSWS2kKwsrFfB != null)
						{
							goto IL_2CB6;
						}
						num2 = 118;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 81;
							continue;
						}
						continue;
						IL_278E:
						this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NbAJVcNW3v4hEAXBLcy(qmmmuQuSWS2kKwsrFfB));
						num2 = 344;
						continue;
						IL_28A0:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto IL_58EE;
						}
						num2 = 475;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 251;
							continue;
						}
						continue;
						IL_2938:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto IL_3BB7;
						}
						num2 = 479;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 331;
							continue;
						}
						continue;
						IL_29E1:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, x0cbwj80qtx55Tsu8UC);
						num2 = 188;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 79;
							continue;
						}
						continue;
						IL_2AB7:
						obj2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(x0cbwj80qtx55Tsu8UC, type);
						num2 = 520;
						continue;
						IL_2AF9:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto IL_6268;
						}
						num2 = 622;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 178;
							continue;
						}
						continue;
						IL_2B3B:
						intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.f5jHoN24g0jBEI5KuTG((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB);
						num2 = 550;
						continue;
						IL_31A2:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							num2 = 649;
							continue;
						}
						goto IL_35ED;
						IL_2CB6:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.uME7nq6qgBCyTViFm1x(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
						num2 = 47;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 130;
							continue;
						}
						continue;
						IL_2D01:
						this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
						num2 = 5;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 277;
							continue;
						}
						continue;
						IL_2DCA:
						num8 = 0;
						num2 = 252;
						continue;
						IL_2DF6:
						flag = !x0cbwj80qtx55Tsu8UC.lPSqCCLN7S();
						num2 = 86;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 635;
							continue;
						}
						continue;
						IL_2E1C:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SA7JyV2KGgwSUfx1VU0(array4[num8], ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num8]), array2[num8]));
						num2 = 128;
						continue;
						IL_2EB9:
						if (type.IsValueType)
						{
							num2 = 577;
							continue;
						}
						goto IL_433E;
						IL_2891:
						type = type.GetElementType();
						goto IL_2EB9;
						IL_3DAF:
						if (obj2 != null)
						{
							num2 = 269;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 130;
								continue;
							}
							continue;
						}
						else
						{
							if (!type.IsByRef)
							{
								num2 = 179;
								continue;
							}
							goto IL_2891;
						}
						IL_2FE9:
						obj = null;
						num2 = 437;
						continue;
						IL_31B3:
						this.Qk8lqGTUrC.cL3qW1trrh().qEGqyetc79(x0cbwj80qtx55Tsu8UC);
						num2 = 631;
						continue;
						IL_325F:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.sMm6n861Q7blLnJUiqT(qmmmuQuSWS2kKwsrFfB));
						num2 = 31;
						continue;
						IL_3413:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
						num2 = 456;
						continue;
						IL_345B:
						this.yHPlGnPngy = new List<IntPtr>();
						num2 = 543;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 619;
							continue;
						}
						continue;
						IL_3631:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.oshsg06IcXYWfhXa9nf(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
						num2 = 516;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 126;
							continue;
						}
						continue;
						IL_6D13:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto Block_434;
						}
						goto IL_3631;
						IL_367D:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.ip0IZd6ZyLkOLxjE6Ht(qmmmuQuSWS2kKwsrFfB, qmmmuQuSWS2kKwsrFfB2));
						num2 = 314;
						continue;
						IL_372D:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.c1Bqr7stpA());
						num2 = 314;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 678;
							continue;
						}
						continue;
						IL_3CAF:
						this.Qk8lqGTUrC.cL3qW1trrh().qEGqyetc79(x0cbwj80qtx55Tsu8UC);
						num2 = 629;
						continue;
						IL_3D18:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1));
						num2 = 312;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 260;
							continue;
						}
						continue;
						IL_3D98:
						this.yHPlGnPngy.Add(intPtr);
						num2 = 247;
						continue;
						IL_3E92:
						this.XZ2lKJZI20[num3] = this.V9yuBsGNOs(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), this.OOMlcvRAjr.C12iMMW3JJ[num3].b6YiSr1Ws1, false);
						num2 = 258;
						continue;
						IL_3F37:
						this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
						num2 = 140;
						continue;
						IL_3F81:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto IL_5D7C;
						}
						num2 = 194;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 183;
							continue;
						}
						continue;
						IL_3FD7:
						if (flag)
						{
							goto IL_433E;
						}
						num2 = 253;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 51;
							continue;
						}
						continue;
						IL_4103:
						if (num5 >= parameters.Length)
						{
							num2 = 94;
							continue;
						}
						goto IL_4FD9;
						IL_42BC:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.zn0kuu6s8NwJt5kPGkA(qmmmuQuSWS2kKwsrFfB));
						num2 = 658;
						continue;
						IL_433E:
						array4[array2.Length - 1 - num5] = x0cbwj80qtx55Tsu8UC;
						num2 = 331;
						continue;
						IL_43F8:
						if (qmmmuQuSWS2kKwsrFfB != null)
						{
							num2 = 528;
							continue;
						}
						goto IL_61BC;
						IL_4437:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto IL_29B9;
						}
						num2 = 130;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 184;
							continue;
						}
						continue;
						IL_44CF:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, x0cbwj80qtx55Tsu8UC);
						num2 = 71;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 31;
							continue;
						}
						continue;
						IL_1F1D:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null);
						goto IL_44CF;
						IL_4DC5:
						if (type.IsValueType)
						{
							num2 = 693;
							continue;
						}
						goto IL_1F1D;
						IL_4567:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yxTqPB2gVj6q2Wa8L3S(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), x0cbwj80qtx55Tsu8UC);
						num2 = 108;
						continue;
						IL_45D1:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.wRg08r60CT0WD97QdhM(intPtr2, IntPtr.Zero))
						{
							return;
						}
						num2 = 686;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 205;
							continue;
						}
						continue;
						IL_467F:
						intPtr = ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB).oM8u8TUrCx();
						num2 = 486;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 247;
							continue;
						}
						continue;
						IL_48A6:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto IL_27DC;
						}
						num2 = 552;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 285;
							continue;
						}
						continue;
						IL_4AF0:
						if (x0cbwj80qtx55Tsu8UC.TB5dFM9QIv())
						{
							goto Block_270;
						}
						goto IL_48A6;
						IL_53FE:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto Block_312;
						}
						goto IL_49CB;
						IL_CFA:
						if (qmmmuQuSWS2kKwsrFfB == null)
						{
							goto IL_53FE;
						}
						goto IL_6047;
						IL_6152:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
						{
							num2 = 113;
							continue;
						}
						goto IL_CFA;
						IL_4A2E:
						if (type.IsValueType)
						{
							num2 = 85;
							continue;
						}
						goto IL_F2F;
						IL_4A8A:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(type, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Vjlm2N2lDSCeFJXbM6u(obj))));
						num2 = 147;
						continue;
						IL_4B0A:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kJcu0S2sj0oAUHfqmg6((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)x0cbwj80qtx55Tsu8UC);
						num2 = 87;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 722;
							continue;
						}
						continue;
						IL_4B32:
						if (!(array4[num8] is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu))
						{
							num2 = 684;
							continue;
						}
						goto IL_6607;
						IL_2142:
						if (array4[num8].tXF8H2TS5Y())
						{
							goto Block_93;
						}
						goto IL_4B32;
						IL_4BC5:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.rswRIr6l5N68MvIRO8m(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
						num2 = 189;
						continue;
						IL_4FD9:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
						num2 = 200;
						continue;
						IL_5081:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nl5nqh66evmN1DSumch(qmmmuQuSWS2kKwsrFfB));
						num2 = 97;
						continue;
						IL_53C0:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.lk5qURpdjk());
						num2 = 133;
						continue;
						IL_5413:
						num8++;
						num2 = 393;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 594;
							continue;
						}
						continue;
						IL_5468:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eYLLJT2Hd9e0Wdb6UL0() == 4)
						{
							num2 = 645;
							continue;
						}
						goto IL_1B56;
						IL_551B:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).qEGqyetc79(x0cbwj80qtx55Tsu8UC);
						num2 = 24;
						continue;
						IL_5537:
						obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Vjlm2N2lDSCeFJXbM6u(obj);
						num2 = 168;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 306;
							continue;
						}
						continue;
						IL_56C1:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(null));
						num2 = 254;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 404;
							continue;
						}
						continue;
						IL_573D:
						intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.f5jHoN24g0jBEI5KuTG((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB);
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs(*(float*)((void*)intPtr), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)9));
						num2 = 337;
						continue;
						IL_5B31:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SyVFG66MdZ89MBVZoXi(qmmmuQuSWS2kKwsrFfB));
						num2 = 36;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 238;
							continue;
						}
						continue;
						IL_5B5D:
						if (qmmmuQuSWS2kKwsrFfB != null)
						{
							goto IL_6139;
						}
						num2 = 137;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 12;
							continue;
						}
						continue;
						IL_5C56:
						if (!flag)
						{
							num2 = 276;
							continue;
						}
						this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
						num2 = 17;
						continue;
						IL_5E33:
						intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.f5jHoN24g0jBEI5KuTG((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB);
						num2 = 643;
						continue;
						IL_5E4B:
						intPtr = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.f5jHoN24g0jBEI5KuTG((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)qmmmuQuSWS2kKwsrFfB);
						num2 = 723;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 489;
							continue;
						}
						continue;
						IL_5EAA:
						obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.YEi8uQ6emRDuLHZCbI8(constructorInfo, array2);
						num2 = 356;
						continue;
						IL_5F5C:
						this.Qk8lqGTUrC.CBp8byx5jM(qmmmuQuSWS2kKwsrFfB.FOJqpHkit6());
						num2 = 240;
						continue;
						IL_6047:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.M5vyFA6GppAIgdick7x(qmmmuQuSWS2kKwsrFfB));
						num2 = 386;
						continue;
						IL_61EE:
						((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)x0cbwj80qtx55Tsu8UC).xZMdRwMHqP(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(type, obj2));
						num2 = 357;
						continue;
						IL_62C8:
						module = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module;
						num2 = 314;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 412;
							continue;
						}
						continue;
						IL_6332:
						this.Qk8lqGTUrC.CBp8byx5jM(qmmmuQuSWS2kKwsrFfB.yRRqsHbNK7());
						num2 = 394;
						continue;
						IL_6441:
						this.Qk8lqGTUrC.CBp8byx5jM(qmmmuQuSWS2kKwsrFfB.HK7q1PliPm());
						num2 = 719;
						continue;
						IL_6493:
						list.Add(new ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V(mA48iBuFQonZePrECIu.PDaii2T9cI, num5));
						num2 = 26;
						continue;
						IL_6587:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yxTqPB2gVj6q2Wa8L3S(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), x0cbwj80qtx55Tsu8UC);
						num2 = 651;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 689;
							continue;
						}
						continue;
						IL_6607:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SA7JyV2KGgwSUfx1VU0(array4[num8], ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num8]).GetElementType(), array2[num8]));
						num2 = 81;
						continue;
						IL_67B3:
						flag = true;
						num2 = 680;
						continue;
						IL_67C0:
						this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
						num2 = 352;
						continue;
						IL_6D79:
						obj = sxUaepu6HaOlCtHk6W(null, array2);
						num2 = 575;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 464;
							continue;
						}
						continue;
						IL_6E00:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.MnA3Bc2X79qx1q2YIhE((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)x0cbwj80qtx55Tsu8UC);
						num2 = 40;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 34;
							continue;
						}
						continue;
						IL_6E28:
						type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(fieldInfo);
						num2 = 14;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 15;
							continue;
						}
						continue;
						IL_6EB8:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(obj));
						num2 = 699;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 709;
							continue;
						}
						continue;
						IL_6F0A:
						ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR sK9Zdfu498A1KFPnIfR3 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC) as ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR;
						if (sK9Zdfu498A1KFPnIfR3 == null)
						{
							goto Block_443;
						}
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SA7JyV2KGgwSUfx1VU0(sK9Zdfu498A1KFPnIfR3, x0cbwj80qtx55Tsu8UC);
						num2 = 409;
					}
					IL_C95:
					if (qmmmuQuSWS2kKwsrFfB != null)
					{
						this.Qk8lqGTUrC.CBp8byx5jM(qmmmuQuSWS2kKwsrFfB.Vy2qKYUMDe());
						num = 220;
						continue;
					}
					goto IL_3DF4;
					IL_11A7:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.sZgTvtNc9UkdPZCf9PO(x0cbwj80qtx55Tsu8UC))
					{
						num = 448;
						continue;
					}
					return;
					IL_22A1:
					if (x0cbwj80qtx55Tsu8UC == null)
					{
						num = 642;
						continue;
					}
					goto IL_11A7;
					IL_1815:
					y6ZjFnxbSGpN58JxU4F = (ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)qmmmuQuSWS2kKwsrFfB;
					num = 345;
					continue;
					IL_1B56:
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.bObcNt2tby4WF4mr9is(qmmmuQuSWS2kKwsrFfB))
					{
						goto IL_69F6;
					}
					goto IL_1815;
					IL_5F18:
					goto IL_1B56;
					IL_1833:
					this.lgq8RX6Fc5(false);
					num = 547;
					continue;
					IL_1AD2:
					this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
					num = 158;
					continue;
					IL_1AF3:
					this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777245)), obj));
					num = 374;
					continue;
					IL_1BB4:
					x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.zV7hg56f50Txkqee6LU((ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB)x0cbwj80qtx55Tsu8UC);
					num = 533;
					continue;
					IL_1C5D:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(x0cbwj80qtx55Tsu8UC))
					{
						num = 348;
						continue;
					}
					goto IL_29DB;
					IL_1E8A:
					qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
					num = 303;
					continue;
					IL_1EF7:
					if (qmmmuQuSWS2kKwsrFfB != null)
					{
						num = 35;
						continue;
					}
					goto IL_530F;
					Block_93:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.hRW8tG6r4yKaS2fGtGV((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)array4[num8], ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num8]), array2[num8]));
					num = 4;
					continue;
					Block_105:
					num = 387;
					continue;
					IL_24E7:
					num4 = *(long*)((void*)intPtr);
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb(num4, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)12));
					num = 641;
					continue;
					IL_2523:
					qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
					num = 221;
					continue;
					IL_27E2:
					qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
					num = 712;
					continue;
					Block_124:
					num = 703;
					continue;
					IL_2A76:
					num3 = (int)this.rhZlWn3394;
					num = 413;
					continue;
					IL_2A91:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0));
					num = 540;
					continue;
					IL_2B1A:
					this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
					num = 110;
					continue;
					Block_135:
					num = 324;
					continue;
					IL_308C:
					Array array6 = (Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(this.Qk8lqGTUrC.cL3qW1trrh(), null);
					obj = array6.GetValue(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
					type = array6.GetType().GetElementType();
					num = 6;
					continue;
					IL_30DC:
					qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
					num = 578;
					continue;
					IL_34CD:
					type = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module.ResolveType(num3);
					num = 405;
					continue;
					IL_3578:
					this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.wACY2Z26Rx00o1ndclK(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
					num = 461;
					continue;
					Block_179:
					num = 503;
					continue;
					IL_37CD:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1));
					num = 623;
					continue;
					IL_3D78:
					qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
					num = 299;
					continue;
					IL_3E31:
					this.jMMlJZsjHx = true;
					num = 609;
					continue;
					IL_3FA3:
					if (qmmmuQuSWS2kKwsrFfB != null)
					{
						num = 76;
						continue;
					}
					goto IL_2667;
					IL_4175:
					obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC).y9jq31urLD(null);
					num = 407;
					continue;
					IL_41F4:
					this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)(*(byte*)((void*)intPtr)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2));
					num = 341;
					continue;
					Block_264:
					num = 576;
					continue;
					Block_270:
					num = 109;
					continue;
					IL_4C69:
					if (!x0cbwj80qtx55Tsu8UC.g5sdhSCwCu(x0cbwj80qtx55Tsu8UC3))
					{
						num = 42;
						continue;
					}
					goto IL_64B2;
					IL_5A59:
					Block_341:
					goto IL_4C69;
					IL_4E5C:
					this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.F4qx4Z2GNn5J4ZSdWHL(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
					num = 5;
					continue;
					IL_50BE:
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.i61l3vZWFk.TryGetValue(obj, out x0cbwj80qtx55Tsu8UC))
					{
						num = 186;
						continue;
					}
					goto IL_6521;
					IL_5341:
					qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
					num = 20;
					continue;
					IL_53DD:
					qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
					num = 139;
					continue;
					Block_312:
					num = 161;
					continue;
					Block_316:
					num = 216;
					continue;
					IL_5611:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.oAjqFTEeFY());
					num = 271;
					continue;
					IL_20CC:
					if (qmmmuQuSWS2kKwsrFfB == null)
					{
						goto Block_89;
					}
					goto IL_5611;
					IL_58F4:
					x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
					num = 123;
					continue;
					IL_5A64:
					num3 = (int)this.rhZlWn3394;
					fieldInfo = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.firLfX2b9yQe64i2LfW(Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module, num3);
					num = 66;
					continue;
					IL_5A92:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0));
					num = 379;
					continue;
					IL_5D1E:
					x0cbwj80qtx55Tsu8UC = this.Qk8lqGTUrC.cL3qW1trrh();
					num = 398;
					continue;
					IL_5D82:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
					num = 432;
					continue;
					Block_370:
					num = 90;
					continue;
					IL_60E1:
					if (qmmmuQuSWS2kKwsrFfB2 != null)
					{
						num = 702;
						continue;
					}
					goto IL_5010;
					Block_377:
					num = 136;
					continue;
					Block_387:
					num = 615;
					continue;
					IL_6312:
					qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(this.Qk8lqGTUrC.cL3qW1trrh());
					num = 204;
					continue;
					IL_6521:
					this.Qk8lqGTUrC.CBp8byx5jM(x0cbwj80qtx55Tsu8UC);
					num = 639;
					continue;
					IL_6658:
					qmmmuQuSWS2kKwsrFfB2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nJhaI62OTtFZQY9FGEp(x0cbwj80qtx55Tsu8UC3);
					num = 656;
					continue;
					IL_69F6:
					if (num4 < (long)array3.Length)
					{
						num = 493;
						continue;
					}
					return;
					Block_415:
					num = 467;
					continue;
					IL_6B66:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(fieldInfo.FieldType, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.IP1X5V6O7gDTcLLK7Oi(fieldInfo, null)));
					num = 654;
					continue;
					Block_434:
					num = 530;
				}
				Block_1:
				goto IL_2C53;
				IL_B88:
				goto IL_2B83;
				IL_DB9:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_F2F:
				throw new NullReferenceException();
				IL_105A:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_1245:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_15CD:
				this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu((int)this.rhZlWn3394, this));
				return;
				Block_39:
				goto IL_61BC;
				Block_41:
				goto IL_2667;
				IL_1848:
				goto IL_3D44;
				IL_1919:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_197B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_59:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_1C53:
				goto IL_2D47;
				IL_1D78:
				goto IL_3BB7;
				IL_1D97:
				goto IL_4C86;
				IL_1E66:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_1E84:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_1EAB:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_1F7A:
				goto IL_DB9;
				Block_89:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_95:
				return;
				IL_2248:
				throw new OverflowException(ngYCBhqPZ7YsxPQyJh.ToString());
				IL_25E2:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2667:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_27DC:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_29B9:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_29DB:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2A2C:
				return;
				IL_2A4C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2A6A:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2A70:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2B54:
				throw (Exception)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null);
				IL_2B83:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2C21:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2C53:
				return;
				IL_2C73:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2D47:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2D4D:
				throw this.vaqlyQlH5E;
				IL_2D6B:
				goto IL_1E84;
				IL_2E5B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2ED0:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_2F13:
				goto IL_42E8;
				IL_30D6:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_32CE:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3386:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_33F1:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3549:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3613:
				return;
				IL_3622:
				this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0));
				return;
				IL_369B:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.L3yR9g6pp3lu47yo0eO(qmmmuQuSWS2kKwsrFfB));
				return;
				IL_38C3:
				goto IL_2A4C;
				IL_38EB:
				goto IL_6268;
				IL_395D:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_39BB:
				goto IL_395D;
				IL_39DA:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, qmmmuQuSWS2kKwsrFfB.QmjqeL3I7g());
				return;
				IL_3A45:
				Type type2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.OhecIY2LQxV4Lqk6f4a(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(33554540)).Module, num3);
				qmmmuQuSWS2kKwsrFfB = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(this.Qk8lqGTUrC.cL3qW1trrh());
				array = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.e0SGR8NP4ilFx8EM7MH(type2, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WByUp420D1Qj7bCeZq9(qmmmuQuSWS2kKwsrFfB).aYsh65bDic.RekhP3Apm0);
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(array));
				return;
				IL_3B23:
				goto IL_5992;
				IL_3B4B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3BB7:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3BF8:
				this.t6plBAG1Rr = (int)this.rhZlWn3394 - 1;
				return;
				Block_203:
				goto IL_27DC;
				IL_3C85:
				IL_3D44:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3DF4:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3E21:
				return;
				IL_3E83:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_3FB8:
				return;
				Block_221:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_4005:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_41C4:
				goto IL_4C86;
				IL_421B:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.pGwTaH6N2lt7l24W1uh(qmmmuQuSWS2kKwsrFfB));
				return;
				IL_42E8:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_448C:
				return;
				IL_4594:
				goto IL_6E91;
				IL_45A3:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_45C2:
				goto IL_DB9;
				IL_4614:
				throw new OverflowException(ngYCBhqPZ7YsxPQyJh.ToString());
				IL_4716:
				goto IL_586E;
				IL_4726:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_484D:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_4929:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_4C86:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_4C9E:
				this.Qk8lqGTUrC.CBp8byx5jM(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(fieldInfo.FieldType, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.IP1X5V6O7gDTcLLK7Oi(fieldInfo, obj)));
				return;
				IL_4CDA:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_4D08:
				goto IL_29B9;
				Block_297:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_4FF0:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5010:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_527D:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_52EF:
				goto IL_586E;
				IL_530F:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_533B:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5371:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5449:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5492:
				goto IL_2C21;
				IL_54D1:
				goto IL_2D47;
				IL_55CC:
				goto IL_1EAB;
				Block_323:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_584E:
				goto IL_1E84;
				IL_586E:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_58EE:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5959:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yxTqPB2gVj6q2Wa8L3S(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), x0cbwj80qtx55Tsu8UC);
				return;
				IL_5992:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_59C2:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_342:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5B7E:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P3OhJy2MTyox3MoHoQr((Array)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC), null), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(x0cbwj80qtx55Tsu8UC, type), qmmmuQuSWS2kKwsrFfB.eoUqScGyAS().aYsh65bDic.RekhP3Apm0);
				return;
				IL_5D7C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5D9D:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_5E1D:
				this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1));
				return;
				IL_5EBF:
				goto IL_533B;
				IL_5F4D:
				goto IL_5371;
				IL_5FC1:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_607F:
				goto IL_5371;
				IL_6139:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.PNJrPu6i4W9ajkEyANF(qmmmuQuSWS2kKwsrFfB2, qmmmuQuSWS2kKwsrFfB));
				return;
				IL_61BC:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_383:
				goto IL_3B4B;
				IL_6268:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_64B2:
				this.Qk8lqGTUrC.CBp8byx5jM(new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1));
				return;
				IL_6703:
				goto IL_5959;
				IL_6731:
				goto IL_2C21;
				IL_6768:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_690C:
				goto IL_32CE;
				IL_6B18:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)this.rhZlWn3394));
				return;
				IL_6C36:
				return;
				IL_6CA2:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.FL9drb6md4qRFrBBTRC(intPtr2, intPtr, u);
				return;
				IL_6D5A:
				goto IL_395D;
				IL_6E4C:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				IL_6E91:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_443:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
				Block_444:
				ngYCBhqPZ7YsxPQyJh = (ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)0;
				throw new ArithmeticException(ngYCBhqPZ7YsxPQyJh.ToString());
				Block_448:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000C70 RID: 3184 RVA: 0x000638B0 File Offset: 0x00061AB0
			private ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC V9yuBsGNOs(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020, bool \u0020 = false)
			{
				if (\u0020 || !ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(\u0020))
				{
					goto IL_6E;
				}
				int num = 0;
				if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
				{
					num = 0;
				}
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						goto IL_10E;
					case 2:
						return \u0020;
					case 3:
						goto IL_130;
					case 4:
						goto IL_6E;
					case 5:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.gw3AKONxufIZdFy15cE(\u0020))
						{
							num = 7;
							continue;
						}
						goto IL_DC;
					case 6:
						goto IL_3A;
					case 7:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.C4RYcd2muw4o4uopGsp(\u0020))
						{
							num = 3;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num = 0;
								continue;
							}
							continue;
						}
						else
						{
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(\u0020))
							{
								num = 2;
								continue;
							}
							goto IL_3A;
						}
						break;
					}
					\u0020 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eypu226HVfIansf7PwU(\u0020);
					num = 4;
				}
				IL_3A:
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.I2h8UbNuEt9AoScNDCN((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020, \u0020);
				IL_DC:
				return ((ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN)\u0020).Q1tqoFEFyp(\u0020);
				IL_130:
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.I2h8UbNuEt9AoScNDCN((ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs)\u0020, \u0020);
				IL_6E:
				if (!\u0020.jZ28mHocbm())
				{
					num = 5;
					goto IL_10;
				}
				IL_10E:
				return ((ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F)\u0020).Q1tqoFEFyp(\u0020);
			}

			// Token: 0x06000C71 RID: 3185 RVA: 0x00063A10 File Offset: 0x00061C10
			private ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cpHy3PRSok(int \u0020)
			{
				return this.RGflstwkfS[\u0020];
			}

			// Token: 0x06000C72 RID: 3186 RVA: 0x00063A24 File Offset: 0x00061C24
			private void DKNyQ7ytdI(int \u0020)
			{
				this.KMp8ZUgqIs(\u0020, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC));
			}

			// Token: 0x06000C73 RID: 3187 RVA: 0x00063A4C File Offset: 0x00061C4C
			private static int XCi8qlVP6o(Type \u0020)
			{
				int num = 4;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_37;
					case 2:
						goto IL_6F;
					case 3:
						goto IL_1D1;
					case 4:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVblEuPNaN != null)
						{
							num2 = 3;
							continue;
						}
						goto IL_37;
					}
					break;
					IL_37:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVblEuPNaN = new Dictionary<Type, int>();
					num2 = 2;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num2 = 1;
					}
				}
				int result;
				return result;
				IL_6F:
				try
				{
					int num3 = 0;
					int num4 = 0;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num4 = 0;
					}
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_159;
						case 1:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVblEuPNaN[\u0020] = num3;
							result = num3;
							num4 = 3;
							continue;
						case 2:
							result = num3;
							num4 = 4;
							continue;
						case 3:
							goto IL_175;
						case 4:
							goto IL_C7;
						case 5:
							break;
						default:
							goto IL_159;
						}
						IL_D6:
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777219)), Type.EmptyTypes, true);
						object obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.oBStSmNVvgxhIwuKUHL(dynamicMethod);
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(obj, OpCodes.Sizeof, \u0020);
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(obj, OpCodes.Ret);
						num3 = (int)dynamicMethod.Invoke(null, null);
						num4 = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num4 = 1;
							continue;
						}
						continue;
						IL_159:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVblEuPNaN.TryGetValue(\u0020, out num3))
						{
							goto IL_D6;
						}
						num4 = 2;
					}
					IL_C7:
					IL_175:;
				}
				catch
				{
					int num5 = 0;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num5 = 0;
					}
					switch (num5)
					{
					default:
						result = 0;
						break;
					}
				}
				return result;
				IL_1D1:
				goto IL_6F;
			}

			// Token: 0x06000C74 RID: 3188 RVA: 0x00063C64 File Offset: 0x00061E64
			private void KMp8ZUgqIs(int \u0020, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.RGflstwkfS[\u0020] = this.V9yuBsGNOs(\u0020, this.OOMlcvRAjr.u7wi6eANjd[\u0020].ob0itY7ilV, this.OOMlcvRAjr.u7wi6eANjd[\u0020].MnbiZVlnrv);
			}

			// Token: 0x06000C75 RID: 3189 RVA: 0x00063CC0 File Offset: 0x00061EC0
			private static ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB Ths8UetqTq(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB = \u0020 as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB;
				if (qmmmuQuSWS2kKwsrFfB == null)
				{
					goto IL_91;
				}
				int num = 3;
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						return qmmmuQuSWS2kKwsrFfB;
					case 2:
						qmmmuQuSWS2kKwsrFfB = (\u0020.s9Cd9Og84k() as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 1;
							continue;
						}
						continue;
					case 3:
						return qmmmuQuSWS2kKwsrFfB;
					}
					break;
				}
				IL_91:
				if (\u0020.TB5dFM9QIv())
				{
					num = 2;
					goto IL_10;
				}
				return qmmmuQuSWS2kKwsrFfB;
			}

			// Token: 0x06000C76 RID: 3190 RVA: 0x00063D74 File Offset: 0x00061F74
			private void lgq8RX6Fc5(bool \u0020)
			{
				int num = 57;
				for (;;)
				{
					int num2 = num;
					int num3;
					List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V> list;
					MethodBase methodBase;
					ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu mA48iBuFQonZePrECIu;
					Type type2;
					int metadataToken;
					for (;;)
					{
						ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s hcp9nIur8g9pimJhW0s;
						ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 sxUaepu6HaOlCtHk6W;
						object obj2;
						object[] array;
						object obj;
						object obj3;
						ParameterInfo[] array3;
						ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[] array2;
						Type type;
						ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
						MethodInfo methodInfo;
						int num4;
						ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC2;
						bool flag;
						switch (num2)
						{
						case 0:
							goto IL_43C;
						case 1:
							if (hcp9nIur8g9pimJhW0s != null)
							{
								goto IL_56B;
							}
							num2 = 33;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 43;
								continue;
							}
							continue;
						case 2:
							goto IL_868;
						case 3:
							goto IL_ADF;
						case 4:
							goto IL_7D7;
						case 5:
							goto IL_613;
						case 6:
							goto IL_48F;
						case 7:
							goto IL_368;
						case 8:
							goto IL_6AA;
						case 9:
							goto IL_4B4;
						case 10:
							obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.FOSqgUNoVF68x15PLoV(sxUaepu6HaOlCtHk6W, obj2, array);
							num2 = 59;
							continue;
						case 11:
							goto IL_48F;
						case 12:
							goto IL_3CC;
						case 13:
							goto IL_7D7;
						case 14:
							array[array.Length - 1 - num3] = obj3;
							num2 = 9;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 30;
								continue;
							}
							continue;
						case 15:
							array2 = new ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[array3.Length];
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 16:
							obj3 = null;
							num2 = 60;
							continue;
						case 17:
							goto IL_9CA;
						case 18:
							list = new List<ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V>();
							num2 = 35;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 31;
								continue;
							}
							continue;
						case 19:
							type = type.GetElementType();
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 20:
							if (!(x0cbwj80qtx55Tsu8UC is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu))
							{
								num2 = 21;
								continue;
							}
							goto IL_973;
						case 21:
							goto IL_589;
						case 22:
							goto IL_7FE;
						case 23:
							goto IL_6AA;
						case 24:
							goto IL_82C;
						case 25:
							goto IL_A90;
						case 26:
							goto IL_992;
						case 27:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgGVJC2SyV73ZL4gxdV(this.Qk8lqGTUrC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P2XARSNCyw883fskbwl(methodInfo), obj));
							num2 = 45;
							continue;
						case 28:
							array = new object[array3.Length];
							num2 = 15;
							continue;
						case 29:
							goto IL_589;
						case 30:
							num3++;
							num2 = 75;
							continue;
						case 31:
							goto IL_3CC;
						case 32:
							if (type.IsByRef)
							{
								num2 = 19;
								continue;
							}
							goto IL_43C;
						case 33:
							array3 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.zaNnWqNqBsGL0yFVDL7(methodBase);
							num2 = 28;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 9;
								continue;
							}
							continue;
						case 34:
							IL_462:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.hRW8tG6r4yKaS2fGtGV((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)array2[num4], ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(array3[num4].ParameterType, array[num4]));
							num2 = 44;
							continue;
						case 35:
							goto IL_90B;
						case 36:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.bDCC0WNQQYjx3QODUZ4(methodInfo.ReturnType, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777218))))
							{
								num2 = 27;
								continue;
							}
							return;
						case 37:
							obj3 = mA48iBuFQonZePrECIu.sYUi5K28CZ;
							num2 = 68;
							continue;
						case 38:
							goto IL_322;
						case 39:
							if (type2.IsByRef)
							{
								mA48iBuFQonZePrECIu = (x0cbwj80qtx55Tsu8UC2 as ykD11HxHfZBYH7OcFOG.mA48iBuFQonZePrECIu);
								num2 = 42;
								continue;
							}
							goto IL_A90;
						case 40:
							goto IL_82C;
						case 41:
							if (list != null)
							{
								num2 = 38;
								if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
								{
									num2 = 51;
									continue;
								}
								continue;
							}
							break;
						case 42:
							if (mA48iBuFQonZePrECIu == null)
							{
								goto IL_A90;
							}
							if (list == null)
							{
								num2 = 18;
								continue;
							}
							goto IL_90B;
						case 43:
							goto IL_506;
						case 44:
							goto IL_322;
						case 45:
							return;
						case 46:
							obj2 = x0cbwj80qtx55Tsu8UC.y9jq31urLD(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(methodBase));
							goto IL_2A7;
						case 47:
							break;
						case 48:
							goto IL_523;
						case 49:
							if (x0cbwj80qtx55Tsu8UC2 != null)
							{
								goto Block_56;
							}
							goto IL_5C0;
						case 50:
							goto IL_322;
						case 51:
							hcp9nIur8g9pimJhW0s = new ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s(methodBase, list);
							num2 = 76;
							continue;
						case 52:
							methodInfo = (methodBase as MethodInfo);
							num2 = 27;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 33;
								continue;
							}
							continue;
						case 53:
							goto IL_56B;
						case 54:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SA7JyV2KGgwSUfx1VU0(array2[num4], ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(array3[num4].ParameterType.GetElementType(), array[num4]));
							num2 = 69;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 16;
								continue;
							}
							continue;
						case 55:
							type2 = array3[array3.Length - 1 - num3].ParameterType;
							num2 = 16;
							continue;
						case 56:
							goto IL_4DB;
						case 57:
							metadataToken = (int)this.rhZlWn3394;
							num2 = 9;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 56;
								continue;
							}
							continue;
						case 58:
							goto IL_332;
						case 59:
							goto IL_7FE;
						case 60:
							flag = false;
							num2 = 39;
							continue;
						case 61:
							if (type2.IsByRef)
							{
								goto Block_35;
							}
							goto IL_523;
						case 62:
							obj3 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(x0cbwj80qtx55Tsu8UC2, type2);
							num2 = 82;
							continue;
						case 63:
							if (x0cbwj80qtx55Tsu8UC == null)
							{
								goto IL_2A7;
							}
							num2 = 46;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 20;
								continue;
							}
							continue;
						case 64:
							IL_845:
							type = methodBase.DeclaringType;
							num2 = 32;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 21;
								continue;
							}
							continue;
						case 65:
							goto IL_A90;
						case 66:
							obj2 = Activator.CreateInstance(type);
							num2 = 20;
							continue;
						case 67:
							if (!(x0cbwj80qtx55Tsu8UC2 is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu))
							{
								goto IL_9CA;
							}
							num2 = 78;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 75;
								continue;
							}
							continue;
						case 68:
							if (!(obj3 is ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC))
							{
								goto Block_52;
							}
							goto IL_305;
						case 69:
							goto IL_322;
						case 70:
							goto IL_973;
						case 71:
							sxUaepu6HaOlCtHk6W = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.z0N8L29AAB(methodBase, \u0020);
							num2 = 73;
							continue;
						case 72:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.v2RQvk6DylsVnr666ui(methodBase))
							{
								goto IL_589;
							}
							x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.mHJ0Mr2pIfbJPE7tq2O(this.Qk8lqGTUrC);
							num2 = 63;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 60;
								continue;
							}
							continue;
						case 73:
							goto IL_613;
						case 74:
							goto IL_305;
						case 75:
							goto IL_368;
						case 76:
							sxUaepu6HaOlCtHk6W = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.E7x8lb8VE8(methodBase, \u0020, hcp9nIur8g9pimJhW0s);
							num2 = 65;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 83;
								continue;
							}
							continue;
						case 77:
							goto IL_22C;
						case 78:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.b5kL85NdMhNcs5krUHU((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)x0cbwj80qtx55Tsu8UC2, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(type2, obj3));
							goto IL_9CA;
						case 79:
							if (sxUaepu6HaOlCtHk6W != null)
							{
								num2 = 10;
								continue;
							}
							goto IL_4B4;
						case 80:
							goto IL_589;
						case 81:
							hcp9nIur8g9pimJhW0s = null;
							num3 = 0;
							num2 = 7;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 6;
								continue;
							}
							continue;
						case 82:
							goto IL_5C0;
						case 83:
							goto IL_613;
						default:
							goto IL_43C;
						}
						if (!(methodInfo != null))
						{
							num2 = 5;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 1;
								continue;
							}
							continue;
						}
						else
						{
							if (methodInfo.ReturnType.IsByRef)
							{
								num2 = 71;
								continue;
							}
							goto IL_613;
						}
						IL_22C:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SA7JyV2KGgwSUfx1VU0(array2[num4], ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array3[num4]), array[num4]));
						num2 = 12;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 50;
							continue;
						}
						continue;
						IL_82C:
						if (array2[num4] is ykD11HxHfZBYH7OcFOG.ujZOqDuOPGmGA43ZXUu)
						{
							num2 = 54;
							continue;
						}
						goto IL_22C;
						IL_2A7:
						if (obj2 == null)
						{
							goto IL_845;
						}
						num2 = 20;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 29;
							continue;
						}
						continue;
						IL_305:
						x0cbwj80qtx55Tsu8UC2 = (obj3 as ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC);
						num2 = 65;
						continue;
						IL_322:
						num4++;
						num2 = 6;
						continue;
						IL_3CC:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array3[num4]).IsByRef)
						{
							goto IL_322;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_332:
						if (!(methodInfo != null))
						{
							return;
						}
						num2 = 36;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 12;
							continue;
						}
						continue;
						IL_48F:
						if (num4 >= array3.Length)
						{
							goto IL_332;
						}
						num2 = 12;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 12;
							continue;
						}
						continue;
						IL_43C:
						if (!type.IsValueType)
						{
							goto IL_583;
						}
						num2 = 66;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 22;
							continue;
						}
						continue;
						IL_506:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(array2[num4]))
						{
							goto Block_23;
						}
						goto IL_462;
						IL_56B:
						if (hcp9nIur8g9pimJhW0s.V7ou2eLZeg(num4))
						{
							num2 = 38;
							continue;
						}
						goto IL_506;
						IL_4B4:
						obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eqVvV1N3sELBCi0OWUI(methodBase, obj2, array);
						num2 = 22;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 10;
							continue;
						}
						continue;
						IL_523:
						if (!type2.IsValueType)
						{
							num2 = 17;
							continue;
						}
						obj3 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.j0RygE6ChFrQYPDdRXT(type2);
						num2 = 65;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 67;
							continue;
						}
						continue;
						IL_589:
						obj = null;
						num2 = 79;
						continue;
						IL_5C0:
						if (obj3 != null)
						{
							goto IL_9CA;
						}
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 61;
							continue;
						}
						continue;
						IL_613:
						obj2 = null;
						x0cbwj80qtx55Tsu8UC = null;
						num2 = 72;
						continue;
						IL_6AA:
						flag = true;
						num2 = 25;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 19;
							continue;
						}
						continue;
						IL_7D7:
						x0cbwj80qtx55Tsu8UC2 = this.Qk8lqGTUrC.cL3qW1trrh();
						num2 = 55;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 22;
							continue;
						}
						continue;
						IL_7FE:
						num4 = 0;
						num2 = 11;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
						IL_973:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.b5kL85NdMhNcs5krUHU((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)x0cbwj80qtx55Tsu8UC, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(type, obj2));
						num2 = 80;
						continue;
						IL_992:
						sxUaepu6HaOlCtHk6W = null;
						num2 = 41;
						continue;
						IL_368:
						if (num3 < array3.Length)
						{
							break;
						}
						goto IL_992;
						IL_9CA:
						array2[array.Length - 1 - num3] = x0cbwj80qtx55Tsu8UC2;
						num2 = 14;
						continue;
						IL_A90:
						if (!flag)
						{
							goto Block_57;
						}
						goto IL_9CA;
					}
					num = 4;
					continue;
					IL_4DB:
					methodBase = Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)).Module.ResolveMethod(metadataToken);
					num = 52;
					continue;
					Block_23:
					num = 40;
					continue;
					Block_35:
					num = 3;
					continue;
					IL_868:
					list = null;
					num = 81;
					continue;
					IL_90B:
					list.Add(new ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V(mA48iBuFQonZePrECIu.PDaii2T9cI, num3));
					num = 37;
					continue;
					Block_52:
					num = 23;
					continue;
					Block_56:
					num = 62;
					continue;
					Block_57:
					num = 49;
					continue;
					IL_ADF:
					type2 = type2.GetElementType();
					num = 48;
				}
				return;
				IL_583:
				throw new NullReferenceException();
			}

			// Token: 0x06000C77 RID: 3191 RVA: 0x000648A0 File Offset: 0x00062AA0
			private static ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 z0N8L29AAB(MethodBase \u0020, bool \u0020)
			{
				int num = 95;
				ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 sxUaepu6HaOlCtHk6W;
				for (;;)
				{
					int num2 = num;
					ILGenerator ilgenerator;
					LocalBuilder[] array;
					int num6;
					Type[] array3;
					MethodInfo methodInfo;
					for (;;)
					{
						int num3;
						int num4;
						int num5;
						ParameterInfo[] array2;
						int num7;
						int num8;
						Type elementType;
						switch (num2)
						{
						case 1:
						{
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 result;
							return result;
						}
						case 2:
							if (!\u0020)
							{
								goto IL_2A5;
							}
							num2 = 50;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 36;
								continue;
							}
							continue;
						case 3:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc, array[num3]);
							num2 = 44;
							continue;
						case 4:
							goto IL_AFE;
						case 5:
							goto IL_B36;
						case 6:
							goto IL_87C;
						case 7:
							goto IL_33B;
						case 8:
							goto IL_C46;
						case 9:
							goto IL_303;
						case 10:
							num4 = 0;
							num2 = 46;
							continue;
						case 11:
							goto IL_23B;
						case 12:
							goto IL_596;
						case 13:
							goto IL_525;
						case 14:
							goto IL_938;
						case 15:
							goto IL_5BC;
						case 16:
							goto IL_8E4;
						case 17:
							goto IL_A4C;
						case 18:
							goto IL_303;
						case 19:
							num5++;
							num2 = 13;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 61;
								continue;
							}
							continue;
						case 20:
							if (\u0020.DeclaringType.IsValueType)
							{
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Unbox, \u0020.DeclaringType);
								num2 = 22;
								continue;
							}
							goto IL_5E9;
						case 21:
							array2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.zaNnWqNqBsGL0yFVDL7(\u0020);
							num2 = 49;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 8;
								continue;
							}
							continue;
						case 22:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Stloc, array[array.Length - 1]);
							num2 = 34;
							continue;
						case 23:
							goto IL_D54;
						case 24:
							goto IL_7D3;
						case 25:
							IL_32B:
							if (num6 < array3.Length)
							{
								goto IL_5BC;
							}
							goto IL_23B;
						case 26:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020).IsValueType)
							{
								goto IL_3A5;
							}
							num2 = 9;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 19;
								continue;
							}
							continue;
						case 27:
							goto IL_435;
						case 28:
							goto IL_545;
						case 29:
							goto IL_4C2;
						case 30:
							goto IL_C09;
						case 31:
							goto IL_5D2;
						case 32:
							goto IL_D71;
						case 33:
							IL_216:
							if (num7 >= array3.Length)
							{
								goto IL_76B;
							}
							num2 = 96;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 2;
								continue;
							}
							continue;
						case 34:
							goto IL_BAD;
						case 35:
							goto IL_992;
						case 36:
							goto IL_5E9;
						case 37:
							goto IL_76B;
						case 38:
							goto IL_4C2;
						case 39:
							goto IL_2A5;
						case 40:
							goto IL_972;
						case 41:
							goto IL_D71;
						case 42:
							goto IL_600;
						case 43:
						{
							DynamicMethod dynamicMethod;
							ilgenerator = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.oBStSmNVvgxhIwuKUHL(dynamicMethod);
							num2 = 21;
							continue;
						}
						case 44:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array[num3]).IsValueType)
							{
								num2 = 65;
								continue;
							}
							goto IL_27F;
						case 45:
							goto IL_CDE;
						case 46:
							goto IL_510;
						case 47:
							goto IL_435;
						case 48:
							goto IL_596;
						case 49:
							array3 = new Type[array2.Length];
							num2 = 88;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 93;
								continue;
							}
							continue;
						case 50:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.p3Fl2XInXl.Add(\u0020, sxUaepu6HaOlCtHk6W);
							num2 = 18;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 97;
								continue;
							}
							continue;
						case 51:
							goto IL_CFE;
						case 52:
							ilgenerator.Emit(OpCodes.Box, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P2XARSNCyw883fskbwl(methodInfo));
							num2 = 53;
							continue;
						case 53:
							goto IL_39D;
						case 54:
							return sxUaepu6HaOlCtHk6W;
						case 55:
							goto IL_545;
						case 56:
							goto IL_510;
						case 57:
							goto IL_B17;
						case 58:
							goto IL_3E3;
						case 59:
							goto IL_992;
						case 60:
							goto IL_CDE;
						case 61:
							goto IL_3A5;
						case 62:
							array3[num8] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array2[num8]).GetElementType();
							num2 = 73;
							continue;
						case 63:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldelem_Ref);
							num2 = 82;
							continue;
						case 64:
							goto IL_39D;
						case 65:
							ilgenerator.Emit(OpCodes.Box, array[num3].LocalType);
							num2 = 68;
							continue;
						case 66:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.m37MZrNS7WTihV4Rmpu(ilgenerator, OpCodes.Call, methodInfo, null);
							num2 = 29;
							continue;
						case 67:
							goto IL_545;
						case 68:
							goto IL_27F;
						case 69:
							goto IL_C09;
						case 70:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XFi2p1NwcMMaw2ah9nC(ilgenerator, num3);
							num2 = 3;
							continue;
						case 71:
						{
							DynamicMethod dynamicMethod;
							sxUaepu6HaOlCtHk6W = (ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XvgvQPNUKA1erHJaUlI(dynamicMethod, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554566)));
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						case 72:
							goto IL_4C2;
						case 73:
							goto IL_525;
						case 74:
							num6++;
							num2 = 25;
							continue;
						case 75:
							goto IL_A33;
						case 76:
							ilgenerator.Emit(OpCodes.Ldobj, elementType);
							num2 = 13;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 27;
								continue;
							}
							continue;
						case 77:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XFi2p1NwcMMaw2ah9nC(ilgenerator, num6);
							num2 = 63;
							continue;
						case 78:
							goto IL_39D;
						case 79:
							goto IL_4C2;
						case 80:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Pc2QlI2i08jdrbwRHq8(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P2XARSNCyw883fskbwl(methodInfo), Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777218))))
							{
								goto IL_938;
							}
							goto IL_972;
						case 81:
							goto IL_40A;
						case 82:
							if (!array3[num6].IsValueType)
							{
								goto IL_7D3;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 83:
							goto IL_8FF;
						case 84:
							goto IL_570;
						case 85:
							elementType = methodInfo.ReturnType.GetElementType();
							num2 = 87;
							continue;
						case 86:
							goto IL_45A;
						case 87:
							if (elementType.IsValueType)
							{
								num2 = 76;
								continue;
							}
							goto IL_C46;
						case 88:
							goto IL_39D;
						case 89:
							array[array.Length - 1] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xYLIrcN9cHigshd3beI(ilgenerator, \u0020.DeclaringType.MakeByRefType());
							goto IL_4F9;
						case 90:
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236)), new Type[]
							{
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236)),
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(typeof(object[]).TypeHandle)
							}, true);
							num2 = 9;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 43;
								continue;
							}
							continue;
						}
						case 91:
							goto IL_3E3;
						case 92:
							num4++;
							num2 = 56;
							continue;
						case 93:
							num8 = 0;
							num2 = 59;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 2;
								continue;
							}
							continue;
						case 94:
						{
							if (\u0020)
							{
								goto Block_34;
							}
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 result;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WSKlzoDo0S.TryGetValue(\u0020, out result))
							{
								goto IL_B36;
							}
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						case 95:
						{
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 result = null;
							num2 = 94;
							continue;
						}
						case 96:
							goto IL_AFE;
						case 97:
							return sxUaepu6HaOlCtHk6W;
						case 98:
						{
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 result;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.p3Fl2XInXl.TryGetValue(\u0020, out result))
							{
								return result;
							}
							num2 = 5;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						case 99:
						{
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 result;
							return result;
						}
						}
						goto Block_1;
						IL_435:
						if (!elementType.IsValueType)
						{
							num2 = 64;
							continue;
						}
						ilgenerator.Emit(OpCodes.Box, elementType);
						num2 = 88;
						continue;
						IL_3E3:
						num7 = 0;
						goto IL_216;
						IL_5E9:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Castclass, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020));
						goto IL_3E3;
						IL_23B:
						if (\u0020.IsStatic)
						{
							num2 = 58;
							continue;
						}
						goto IL_87C;
						IL_4F9:
						num6 = 0;
						goto IL_32B;
						IL_510:
						if (num4 < array3.Length)
						{
							num2 = 69;
							continue;
						}
						if (!\u0020.DeclaringType.IsValueType)
						{
							goto IL_4F9;
						}
						num2 = 55;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 89;
							continue;
						}
						continue;
						IL_27F:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Stelem_Ref);
						num2 = 86;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 48;
							continue;
						}
						continue;
						IL_2A5:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WSKlzoDo0S.Add(\u0020, sxUaepu6HaOlCtHk6W);
						num2 = 54;
						continue;
						IL_33B:
						num5 = array3.Length;
						num2 = 9;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 26;
							continue;
						}
						continue;
						IL_992:
						if (num8 >= array3.Length)
						{
							goto IL_33B;
						}
						num2 = 41;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 22;
							continue;
						}
						continue;
						IL_3A5:
						array = new LocalBuilder[num5];
						num2 = 10;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_40A:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P2XARSNCyw883fskbwl(methodInfo).IsValueType)
						{
							goto IL_39D;
						}
						num2 = 37;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 52;
							continue;
						}
						continue;
						IL_938:
						if (methodInfo.ReturnType.IsByRef)
						{
							num2 = 85;
							continue;
						}
						goto IL_40A;
						IL_45A:
						num3++;
						num2 = 17;
						continue;
						IL_303:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array2[num3]).IsByRef)
						{
							goto IL_45A;
						}
						goto IL_570;
						IL_4C2:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NVBpRMNi2egymnpLuwH(methodInfo, null))
						{
							num2 = 80;
							continue;
						}
						goto IL_972;
						IL_525:
						num8++;
						num2 = 35;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 30;
							continue;
						}
						continue;
						IL_545:
						ilgenerator.Emit(OpCodes.Stloc, array[num6]);
						num2 = 20;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 74;
							continue;
						}
						continue;
						IL_570:
						ilgenerator.Emit(OpCodes.Ldarg_1);
						num2 = 45;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 70;
							continue;
						}
						continue;
						IL_596:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Vq2hhRNhFb9WDoAY75l(methodInfo, null))
						{
							num2 = 23;
							continue;
						}
						goto IL_B17;
						IL_5BC:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_1);
						num2 = 77;
						continue;
						IL_5D2:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Vq2hhRNhFb9WDoAY75l(methodInfo, null))
						{
							num2 = 66;
							continue;
						}
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nfZpLpNI1tV3l3TF2SN(ilgenerator, OpCodes.Call, \u0020 as ConstructorInfo);
						num2 = 79;
						continue;
						IL_76B:
						if (!\u0020)
						{
							num2 = 12;
							continue;
						}
						goto IL_5D2;
						IL_600:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Castclass, array3[num6]);
						num2 = 67;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 39;
							continue;
						}
						continue;
						IL_7D3:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.bDCC0WNQQYjx3QODUZ4(array3[num6], Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236))))
						{
							num2 = 28;
							continue;
						}
						goto IL_600;
						IL_87C:
						ilgenerator.Emit(OpCodes.Ldarg_0);
						num2 = 20;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 17;
							continue;
						}
						continue;
						IL_8E4:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloca_S, array[num7]);
						num2 = 45;
						continue;
						IL_AFE:
						if (!array2[num7].ParameterType.IsByRef)
						{
							goto IL_CFE;
						}
						goto IL_8E4;
						IL_8FF:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ret);
						num2 = 71;
						continue;
						IL_A4C:
						if (num3 >= array3.Length)
						{
							goto IL_8FF;
						}
						num2 = 18;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 8;
							continue;
						}
						continue;
						IL_39D:
						num3 = 0;
						goto IL_A4C;
						IL_972:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldnull);
						num2 = 78;
						continue;
						IL_A33:
						array3[num8] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array2[num8]);
						num2 = 13;
						continue;
						IL_D71:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array2[num8]).IsByRef)
						{
							goto IL_A33;
						}
						num2 = 24;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 62;
							continue;
						}
						continue;
						IL_B17:
						ilgenerator.Emit(OpCodes.Callvirt, \u0020 as ConstructorInfo);
						num2 = 38;
						continue;
						IL_B36:
						methodInfo = (\u0020 as MethodInfo);
						num2 = 90;
						continue;
						IL_C09:
						array[num4] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xYLIrcN9cHigshd3beI(ilgenerator, array3[num4]);
						num2 = 92;
						continue;
						IL_C46:
						ilgenerator.Emit(OpCodes.Ldind_Ref, elementType);
						num2 = 47;
						continue;
						IL_CDE:
						num7++;
						num2 = 25;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 33;
							continue;
						}
						continue;
						IL_CFE:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc, array[num7]);
						num2 = 60;
					}
					Block_34:
					num = 98;
					continue;
					IL_9D6:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Unbox_Any, array3[num6]);
					num = 55;
					continue;
					Block_1:
					goto IL_9D6;
					IL_BAD:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc_S, array[array.Length - 1]);
					num = 91;
					continue;
					IL_D54:
					ilgenerator.EmitCall(OpCodes.Callvirt, methodInfo, null);
					num = 72;
				}
				return sxUaepu6HaOlCtHk6W;
			}

			// Token: 0x06000C78 RID: 3192 RVA: 0x0006564C File Offset: 0x0006384C
			private static ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 E7x8lb8VE8(MethodBase \u0020, bool \u0020, ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s \u0020)
			{
				ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 result = null;
				int num;
				if (!\u0020)
				{
					num = 45;
				}
				else
				{
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nwWU0vFu65.TryGetValue(\u0020, out result))
					{
						return result;
					}
					num = 6;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 59;
					}
				}
				ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 sxUaepu6HaOlCtHk6W;
				for (;;)
				{
					int num2;
					int num3;
					Type[] array;
					int num4;
					ILGenerator ilgenerator;
					ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V nsVbPXukrvTsEUG8r1V;
					ParameterInfo[] parameters;
					int num5;
					int num6;
					Type elementType;
					ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V nsVbPXukrvTsEUG8r1V2;
					LocalBuilder[] array2;
					int num7;
					MethodInfo methodInfo;
					int num8;
					switch (num)
					{
					case 0:
						goto IL_81C;
					case 1:
						goto IL_8AB;
					case 2:
						goto IL_656;
					case 3:
						goto IL_8AB;
					case 4:
						IL_F5D:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Kjq5xa6kdOlQKKKNDed(\u0020, num2))
						{
							goto IL_FAE;
						}
						goto IL_413;
					case 5:
					{
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236)), new Type[]
						{
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236)),
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(typeof(object[]).TypeHandle)
						}, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)), true);
						num3 = 104;
						break;
					}
					case 6:
						num4 = array.Length;
						num = 123;
						continue;
					case 7:
						goto IL_1217;
					case 8:
						goto IL_498;
					case 9:
						goto IL_1217;
					case 10:
						goto IL_A83;
					case 11:
						goto IL_2D2;
					case 12:
						goto IL_413;
					case 13:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Rxn8xYN4RmKo095ncPk(ilgenerator, OpCodes.Ldflda, nsVbPXukrvTsEUG8r1V.j2bieVonlD);
						num = 3;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 7;
							continue;
						}
						continue;
					case 14:
						parameters = \u0020.GetParameters();
						num3 = 111;
						break;
					case 15:
						goto IL_1024;
					case 16:
						goto IL_103F;
					case 17:
						goto IL_722;
					case 18:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XFi2p1NwcMMaw2ah9nC(ilgenerator, num5);
						num = 41;
						continue;
					case 19:
						goto IL_5B8;
					case 20:
						IL_A36:
						if (!\u0020)
						{
							goto IL_1270;
						}
						num = 110;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num = 77;
							continue;
						}
						continue;
					case 21:
						goto IL_88B;
					case 22:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XFi2p1NwcMMaw2ah9nC(ilgenerator, num6);
						num = 48;
						continue;
					case 23:
						goto IL_9B6;
					case 24:
						goto IL_1090;
					case 25:
						goto IL_61A;
					case 26:
						goto IL_E31;
					case 27:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Ldobj, elementType);
						num = 63;
						continue;
					case 28:
						goto IL_AF4;
					case 29:
						goto IL_1217;
					case 30:
						goto IL_EB6;
					case 31:
						goto IL_B8E;
					case 32:
						goto IL_6C9;
					case 33:
						goto IL_91F;
					case 34:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVUufcNpVK2NVHgVH5e(nsVbPXukrvTsEUG8r1V2.j2bieVonlD))
						{
							goto IL_10B0;
						}
						num = 82;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 16;
							continue;
						}
						continue;
					case 35:
						goto IL_2AD;
					case 36:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVUufcNpVK2NVHgVH5e(nsVbPXukrvTsEUG8r1V.j2bieVonlD))
						{
							goto IL_968;
						}
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Rxn8xYN4RmKo095ncPk(ilgenerator, OpCodes.Ldsflda, nsVbPXukrvTsEUG8r1V.j2bieVonlD);
						num = 9;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 9;
							continue;
						}
						continue;
					case 37:
						goto IL_80C;
					case 38:
						goto IL_10D6;
					case 39:
						goto IL_1114;
					case 40:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array2[num6]).IsValueType)
						{
							num = 47;
							continue;
						}
						goto IL_3ED;
					case 41:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldelem_Ref);
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Kjq5xa6kdOlQKKKNDed(\u0020, num5))
						{
							goto IL_EB6;
						}
						num = 54;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 98;
							continue;
						}
						continue;
					case 42:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Rxn8xYN4RmKo095ncPk(ilgenerator, OpCodes.Ldflda, nsVbPXukrvTsEUG8r1V.j2bieVonlD);
						num = 46;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num = 41;
							continue;
						}
						continue;
					case 43:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Unbox, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020));
						num = 113;
						continue;
					case 44:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.v2RQvk6DylsVnr666ui(\u0020))
						{
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_0);
							num = 109;
							continue;
						}
						goto IL_61A;
					case 45:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.ajiU1CstPT.TryGetValue(\u0020, out result))
						{
							return result;
						}
						goto IL_AE2;
					case 46:
						goto IL_1217;
					case 47:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Box, array2[num6].LocalType);
						num3 = 75;
						break;
					case 48:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Rxn8xYN4RmKo095ncPk(ilgenerator, OpCodes.Ldsfld, nsVbPXukrvTsEUG8r1V2.j2bieVonlD);
						num = 64;
						continue;
					case 49:
						array2[num7] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xYLIrcN9cHigshd3beI(ilgenerator, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236)));
						num = 55;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num = 107;
							continue;
						}
						continue;
					case 50:
						goto IL_9CD;
					case 51:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Box, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P2XARSNCyw883fskbwl(methodInfo));
						num = 52;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num = 57;
							continue;
						}
						continue;
					case 52:
						goto IL_D5F;
					case 53:
						goto IL_EB6;
					case 54:
						goto IL_722;
					case 55:
						goto IL_ED1;
					case 56:
						goto IL_CB0;
					case 57:
						goto IL_2A0;
					case 58:
						goto IL_670;
					case 59:
						goto IL_AE2;
					case 60:
						goto IL_10B0;
					case 61:
						goto IL_2AD;
					case 62:
						goto IL_F3E;
					case 63:
						goto IL_D8D;
					case 64:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.y3Hvl16xbGsKhCwdXLo(nsVbPXukrvTsEUG8r1V2.j2bieVonlD).IsValueType)
						{
							num = 119;
							continue;
						}
						goto IL_FF4;
					case 65:
						goto IL_88B;
					case 66:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DyO8KsQIjH(ilgenerator, num6);
						num = 97;
						continue;
					case 67:
						goto IL_51F;
					case 68:
						num7 = 0;
						num = 15;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num = 56;
							continue;
						}
						continue;
					case 69:
						goto IL_968;
					case 70:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc_S, array2[array2.Length - 1]);
						num = 25;
						continue;
					case 71:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Castclass, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(nsVbPXukrvTsEUG8r1V.j2bieVonlD));
						num = 9;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 13;
							continue;
						}
						continue;
					case 72:
						goto IL_2A0;
					case 73:
						goto IL_FC2;
					case 74:
						goto IL_58C;
					case 75:
						goto IL_3ED;
					case 76:
						goto IL_8AB;
					case 77:
						goto IL_FAE;
					case 78:
						goto IL_D5F;
					case 79:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc, array2[num6]);
						num = 20;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num = 40;
							continue;
						}
						continue;
					case 80:
						goto IL_C10;
					case 81:
						goto IL_6FC;
					case 82:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_1);
						num = 22;
						continue;
					case 83:
						goto IL_80C;
					case 84:
						goto IL_226;
					case 85:
						goto IL_103F;
					case 86:
						goto IL_9A0;
					case 87:
						goto IL_ED1;
					case 88:
						goto IL_5B8;
					case 89:
						goto IL_AB9;
					case 90:
						goto IL_2A0;
					case 91:
						goto IL_10D6;
					case 92:
						array2[array2.Length - 1] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xYLIrcN9cHigshd3beI(ilgenerator, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020).MakeByRefType());
						num = 84;
						continue;
					case 93:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.m37MZrNS7WTihV4Rmpu(ilgenerator, OpCodes.Callvirt, methodInfo, null);
						num = 76;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 56;
							continue;
						}
						continue;
					case 94:
						goto IL_88B;
					case 95:
						array[num8] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num8]).GetElementType();
						num = 83;
						continue;
					case 96:
						goto IL_D1D;
					case 97:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc, array2[num6]);
						if (!array2[num6].LocalType.IsValueType)
						{
							num = 85;
							continue;
						}
						goto IL_2D2;
					case 98:
						if (!array[num5].IsValueType)
						{
							num = 87;
							continue;
						}
						goto IL_91F;
					case 99:
						goto IL_D8D;
					case 100:
					{
						DynamicMethod dynamicMethod;
						sxUaepu6HaOlCtHk6W = (ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XvgvQPNUKA1erHJaUlI(dynamicMethod, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554566)));
						if (!\u0020)
						{
							num = 62;
							continue;
						}
						goto IL_498;
					}
					case 101:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DyO8KsQIjH(ilgenerator, num6);
						num = 79;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num = 69;
							continue;
						}
						continue;
					case 102:
						num5++;
						num = 19;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num = 4;
							continue;
						}
						continue;
					case 103:
						goto IL_CB0;
					case 104:
					{
						DynamicMethod dynamicMethod;
						ilgenerator = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.oBStSmNVvgxhIwuKUHL(dynamicMethod);
						num = 14;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num = 10;
							continue;
						}
						continue;
					}
					case 105:
						goto IL_88B;
					case 106:
						goto IL_FC2;
					case 107:
						goto IL_6C9;
					case 108:
						goto IL_EB6;
					case 109:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020).IsValueType)
						{
							goto IL_1114;
						}
						num = 29;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num = 43;
							continue;
						}
						continue;
					case 110:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Vq2hhRNhFb9WDoAY75l(methodInfo, null))
						{
							goto IL_58C;
						}
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.m37MZrNS7WTihV4Rmpu(ilgenerator, OpCodes.Call, methodInfo, null);
						num = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num = 1;
							continue;
						}
						continue;
					case 111:
						array = new Type[parameters.Length];
						num8 = 0;
						num = 61;
						continue;
					case 112:
						goto IL_8AB;
					case 113:
						ilgenerator.Emit(OpCodes.Stloc, array2[array2.Length - 1]);
						num = 70;
						continue;
					case 114:
						goto IL_EF9;
					case 115:
						goto IL_4AA;
					case 116:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc, array2[num2]);
						num = 126;
						continue;
					case 117:
						goto IL_61A;
					case 118:
						goto IL_D1D;
					case 119:
						goto IL_4AA;
					case 120:
						goto IL_1270;
					case 121:
						goto IL_5CD;
					case 122:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Box, elementType);
						num3 = 90;
						break;
					case 123:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020).IsValueType)
						{
							goto IL_1090;
						}
						num = 106;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 63;
							continue;
						}
						continue;
					case 124:
						if (!\u0020.DeclaringType.IsValueType)
						{
							goto IL_226;
						}
						num = 72;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 92;
							continue;
						}
						continue;
					case 125:
						goto IL_1217;
					case 126:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Unbox, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(nsVbPXukrvTsEUG8r1V.j2bieVonlD));
						num = 42;
						continue;
					case 127:
						if (!elementType.IsValueType)
						{
							goto IL_EF9;
						}
						num = 27;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num = 22;
							continue;
						}
						continue;
					case 128:
						return result;
					case 129:
						goto IL_4D0;
					case 130:
						goto IL_FF4;
					default:
						goto IL_81C;
					}
					IL_0C:
					num = num3;
					continue;
					IL_226:
					num5 = 0;
					num = 88;
					continue;
					IL_2A0:
					num6 = 0;
					num = 54;
					continue;
					IL_D8D:
					if (elementType.IsValueType)
					{
						num = 122;
						continue;
					}
					goto IL_2A0;
					IL_2AD:
					if (num8 < array.Length)
					{
						goto IL_C10;
					}
					num = 6;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 5;
						continue;
					}
					continue;
					IL_2D2:
					ilgenerator.Emit(OpCodes.Box, array2[num6].LocalType);
					num = 16;
					continue;
					IL_3ED:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Stelem_Ref);
					num = 2;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num = 21;
						continue;
					}
					continue;
					IL_413:
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num2]).IsByRef)
					{
						num = 38;
						continue;
					}
					goto IL_51F;
					IL_656:
					if (num2 < array.Length)
					{
						goto IL_F5D;
					}
					goto IL_A36;
					IL_1217:
					num2++;
					goto IL_656;
					IL_4AA:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Stelem_Ref);
					num = 9;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num = 105;
						continue;
					}
					continue;
					IL_4D0:
					ilgenerator.Emit(OpCodes.Ldarg_1);
					num = 18;
					continue;
					IL_5B8:
					if (num5 >= array.Length)
					{
						num = 44;
						continue;
					}
					goto IL_4D0;
					IL_51F:
					ilgenerator.Emit(OpCodes.Ldloca_S, array2[num2]);
					num = 125;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 38;
						continue;
					}
					continue;
					IL_58C:
					ilgenerator.Emit(OpCodes.Call, \u0020 as ConstructorInfo);
					num = 2;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 3;
						continue;
					}
					continue;
					IL_5CD:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_1);
					num = 101;
					continue;
					IL_AF4:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Kjq5xa6kdOlQKKKNDed(\u0020, num6))
					{
						num = 96;
						continue;
					}
					goto IL_5CD;
					IL_D5F:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num6]).IsByRef)
					{
						goto IL_AF4;
					}
					num = 28;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num = 65;
						continue;
					}
					continue;
					IL_61A:
					num2 = 0;
					num = 1;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 2;
						continue;
					}
					continue;
					IL_6C9:
					num7++;
					num = 103;
					continue;
					IL_6FC:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldnull);
					num = 60;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num = 72;
						continue;
					}
					continue;
					IL_8AB:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NVBpRMNi2egymnpLuwH(methodInfo, null))
					{
						goto IL_6FC;
					}
					num = 0;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 0;
						continue;
					}
					continue;
					IL_722:
					if (num6 >= array.Length)
					{
						goto IL_AB9;
					}
					num = 52;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 12;
						continue;
					}
					continue;
					IL_80C:
					num8++;
					num = 35;
					continue;
					IL_81C:
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Pc2QlI2i08jdrbwRHq8(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P2XARSNCyw883fskbwl(methodInfo), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777218))))
					{
						goto IL_9A0;
					}
					num = 81;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 71;
						continue;
					}
					continue;
					IL_88B:
					num6++;
					num = 17;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 7;
						continue;
					}
					continue;
					IL_91F:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Unbox_Any, array[num5]);
					num = 15;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num = 30;
						continue;
					}
					continue;
					IL_968:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(nsVbPXukrvTsEUG8r1V.j2bieVonlD).IsValueType)
					{
						num = 116;
						continue;
					}
					goto IL_9CD;
					IL_9A0:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.P2XARSNCyw883fskbwl(methodInfo).IsByRef)
					{
						elementType = methodInfo.ReturnType.GetElementType();
						num = 127;
						continue;
					}
					goto IL_1024;
					IL_9B6:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Kjq5xa6kdOlQKKKNDed(\u0020, num7))
					{
						num = 49;
						continue;
					}
					goto IL_B8E;
					IL_CB0:
					if (num7 >= array.Length)
					{
						num = 124;
						continue;
					}
					goto IL_9B6;
					IL_9CD:
					ilgenerator.Emit(OpCodes.Ldloc, array2[num2]);
					num = 61;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num = 71;
						continue;
					}
					continue;
					IL_A83:
					array[num8] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(parameters[num8]);
					num = 37;
					continue;
					IL_C10:
					if (parameters[num8].ParameterType.IsByRef)
					{
						num = 95;
						continue;
					}
					goto IL_A83;
					IL_AB9:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ret);
					num = 100;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 99;
						continue;
					}
					continue;
					IL_AE2:
					methodInfo = (\u0020 as MethodInfo);
					num = 5;
					continue;
					IL_B8E:
					array2[num7] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xYLIrcN9cHigshd3beI(ilgenerator, array[num7]);
					num = 32;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 1;
						continue;
					}
					continue;
					IL_1270:
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Vq2hhRNhFb9WDoAY75l(methodInfo, null))
					{
						num3 = 93;
						goto IL_0C;
					}
					ilgenerator.Emit(OpCodes.Callvirt, \u0020 as ConstructorInfo);
					num = 10;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num = 112;
						continue;
					}
					continue;
					IL_D1D:
					nsVbPXukrvTsEUG8r1V2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.tjOEN6N1MNGKXhQiPMs(\u0020, num6);
					num = 34;
					continue;
					IL_E31:
					ilgenerator.Emit(OpCodes.Castclass, array[num5]);
					num = 19;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 53;
						continue;
					}
					continue;
					IL_ED1:
					if (!(array[num5] != Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236))))
					{
						num = 108;
						continue;
					}
					goto IL_E31;
					IL_EB6:
					ilgenerator.Emit(OpCodes.Stloc, array2[num5]);
					num = 102;
					continue;
					IL_EF9:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Ldind_Ref, elementType);
					num = 99;
					continue;
					IL_FAE:
					nsVbPXukrvTsEUG8r1V = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.tjOEN6N1MNGKXhQiPMs(\u0020, num2);
					num = 36;
					continue;
					IL_FC2:
					array2 = new LocalBuilder[num4];
					num = 49;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 68;
						continue;
					}
					continue;
					IL_FF4:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Box, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array2[num6]));
					num = 115;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 44;
						continue;
					}
					continue;
					IL_103F:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Stelem_Ref);
					num = 94;
					continue;
					IL_1090:
					num4++;
					num = 72;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 73;
						continue;
					}
					continue;
					IL_10B0:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_1);
					num = 65;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 66;
						continue;
					}
					continue;
					IL_10D6:
					ilgenerator.Emit(OpCodes.Ldloc, array2[num2]);
					num = 29;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 11;
						continue;
					}
					continue;
					IL_1114:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Castclass, \u0020.DeclaringType);
					num = 117;
					continue;
					IL_1024:
					if (!methodInfo.ReturnType.IsValueType)
					{
						goto IL_2A0;
					}
					num = 51;
				}
				IL_498:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nwWU0vFu65.Add(\u0020, sxUaepu6HaOlCtHk6W);
				return sxUaepu6HaOlCtHk6W;
				IL_670:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.ajiU1CstPT.Add(\u0020, sxUaepu6HaOlCtHk6W);
				return sxUaepu6HaOlCtHk6W;
				IL_F3E:
				goto IL_670;
			}

			// Token: 0x06000C79 RID: 3193 RVA: 0x0006692C File Offset: 0x00064B2C
			private static ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 KyI8aiUsRE(MethodBase \u0020, bool \u0020, ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s \u0020)
			{
				int num = 26;
				ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 result;
				for (;;)
				{
					int num2 = num;
					LocalBuilder[] array;
					ILGenerator ilgenerator;
					ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V nsVbPXukrvTsEUG8r1V2;
					int num8;
					for (;;)
					{
						ParameterInfo[] array2;
						int num3;
						int num4;
						ykD11HxHfZBYH7OcFOG.nsVbPXukrvTsEUG8r1V nsVbPXukrvTsEUG8r1V;
						ConstructorInfo constructorInfo;
						int num5;
						int num6;
						Type[] array3;
						int num7;
						switch (num2)
						{
						case 0:
							goto IL_BF5;
						case 1:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020).IsValueType)
							{
								array[array.Length - 1] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xYLIrcN9cHigshd3beI(ilgenerator, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020).MakeByRefType());
								num2 = 77;
								continue;
							}
							goto IL_CCF;
						case 2:
							return result;
						case 3:
							array2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.zaNnWqNqBsGL0yFVDL7(\u0020);
							num2 = 48;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 13;
								continue;
							}
							continue;
						case 4:
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236)), new Type[]
							{
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236)),
								typeof(object[])
							}, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)), true);
							num2 = 53;
							continue;
						}
						case 5:
							goto IL_87F;
						case 6:
							goto IL_3DE;
						case 7:
							num3++;
							num2 = 69;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 34;
								continue;
							}
							continue;
						case 8:
							goto IL_BAA;
						case 9:
							goto IL_30D;
						case 10:
							goto IL_79E;
						case 11:
							goto IL_813;
						case 12:
							goto IL_9FA;
						case 13:
							goto IL_477;
						case 14:
							goto IL_457;
						case 15:
							goto IL_B2F;
						case 16:
							goto IL_855;
						case 17:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloca_S, array[num4]);
							num2 = 24;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 11;
								continue;
							}
							continue;
						case 18:
							goto IL_5CF;
						case 19:
							goto IL_412;
						case 20:
							num4 = 0;
							num2 = 18;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 19;
								continue;
							}
							continue;
						case 21:
							goto IL_5FC;
						case 22:
							goto IL_685;
						case 23:
							ilgenerator.Emit(OpCodes.Ldsfld, nsVbPXukrvTsEUG8r1V.j2bieVonlD);
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.y3Hvl16xbGsKhCwdXLo(nsVbPXukrvTsEUG8r1V.j2bieVonlD).IsValueType)
							{
								goto IL_C4E;
							}
							num2 = 25;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 83;
								continue;
							}
							continue;
						case 24:
							goto IL_B1F;
						case 25:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.o5DUHFMp4D.TryGetValue(\u0020, out result))
							{
								num2 = 2;
								continue;
							}
							constructorInfo = (\u0020 as ConstructorInfo);
							num2 = 4;
							continue;
						case 26:
							result = null;
							num2 = 25;
							continue;
						case 27:
							goto IL_2FC;
						case 28:
							goto IL_412;
						case 29:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array[num5]).IsValueType)
							{
								num2 = 30;
								continue;
							}
							goto IL_D5A;
						case 30:
							ilgenerator.Emit(OpCodes.Box, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array[num5]));
							goto IL_D5A;
						case 31:
							goto IL_257;
						case 32:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVUufcNpVK2NVHgVH5e(nsVbPXukrvTsEUG8r1V.j2bieVonlD))
							{
								goto IL_2FC;
							}
							goto IL_685;
						case 33:
							num6++;
							num2 = 88;
							continue;
						case 34:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nfZpLpNI1tV3l3TF2SN(ilgenerator, OpCodes.Newobj, \u0020 as ConstructorInfo);
							num2 = 95;
							continue;
						case 35:
							goto IL_34B;
						case 36:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Kjq5xa6kdOlQKKKNDed(\u0020, num6))
							{
								goto IL_5FC;
							}
							num2 = 11;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 49;
								continue;
							}
							continue;
						case 37:
							goto IL_3A1;
						case 38:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc, array[num5]);
							num2 = 29;
							continue;
						case 39:
							goto IL_277;
						case 40:
							goto IL_4D1;
						case 41:
							goto IL_30D;
						case 42:
							goto IL_257;
						case 43:
							goto IL_C4E;
						case 44:
							goto IL_541;
						case 45:
							goto IL_BCA;
						case 46:
						{
							DynamicMethod dynamicMethod;
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 sxUaepu6HaOlCtHk6W = (ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7)dynamicMethod.CreateDelegate(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554566)));
							num2 = 94;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 3;
								continue;
							}
							continue;
						}
						case 47:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Kjq5xa6kdOlQKKKNDed(\u0020, num5))
							{
								num2 = 9;
								continue;
							}
							goto IL_625;
						case 48:
							array3 = new Type[array2.Length];
							num2 = 81;
							continue;
						case 49:
							goto IL_9FA;
						case 50:
							goto IL_C13;
						case 51:
							goto IL_C41;
						case 52:
							ilgenerator.Emit(OpCodes.Castclass, array3[num6]);
							goto IL_9FA;
						case 53:
						{
							DynamicMethod dynamicMethod;
							ilgenerator = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.oBStSmNVvgxhIwuKUHL(dynamicMethod);
							num2 = 3;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						case 54:
							goto IL_4D1;
						case 55:
							ilgenerator.Emit(OpCodes.Box, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array[num5]));
							num2 = 24;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 80;
								continue;
							}
							continue;
						case 56:
							goto IL_B1F;
						case 57:
							array3[num7] = array2[num7].ParameterType.GetElementType();
							num2 = 14;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 6;
								continue;
							}
							continue;
						case 58:
							goto IL_696;
						case 59:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Castclass, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(nsVbPXukrvTsEUG8r1V2.j2bieVonlD));
							num2 = 44;
							continue;
						case 60:
							goto IL_A25;
						case 61:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DyO8KsQIjH(ilgenerator, num6);
							num2 = 92;
							continue;
						case 62:
							goto IL_B85;
						case 63:
						{
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 sxUaepu6HaOlCtHk6W;
							return sxUaepu6HaOlCtHk6W;
						}
						case 64:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Unbox_Any, array3[num6]);
							num2 = 12;
							continue;
						case 65:
							goto IL_504;
						case 66:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Rxn8xYN4RmKo095ncPk(ilgenerator, OpCodes.Ldflda, nsVbPXukrvTsEUG8r1V2.j2bieVonlD);
							num2 = 73;
							continue;
						case 67:
							goto IL_337;
						case 68:
							goto IL_457;
						case 69:
							goto IL_1D2;
						case 70:
							goto IL_625;
						case 71:
							goto IL_321;
						case 72:
							goto IL_813;
						case 73:
							goto IL_B1F;
						case 74:
							goto IL_855;
						case 75:
							ilgenerator.Emit(OpCodes.Ldloc, array[num5]);
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						case 76:
							break;
						case 77:
							goto IL_CCF;
						case 78:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(\u0020).IsValueType)
							{
								num2 = 7;
								continue;
							}
							goto IL_1D2;
						case 79:
							goto IL_79E;
						case 80:
							goto IL_CAA;
						case 81:
							num7 = 0;
							num2 = 84;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 36;
								continue;
							}
							continue;
						case 82:
							goto IL_C13;
						case 83:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Box, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array[num5]));
							num2 = 43;
							continue;
						case 84:
							goto IL_87F;
						case 85:
							goto IL_ACE;
						case 86:
							ilgenerator.Emit(OpCodes.Unbox, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(nsVbPXukrvTsEUG8r1V2.j2bieVonlD));
							num2 = 66;
							continue;
						case 87:
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.dVUufcNpVK2NVHgVH5e(nsVbPXukrvTsEUG8r1V2.j2bieVonlD))
							{
								goto IL_3DE;
							}
							num2 = 93;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 62;
								continue;
							}
							continue;
						case 88:
							goto IL_B85;
						case 89:
							goto IL_3A1;
						case 90:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XFi2p1NwcMMaw2ah9nC(ilgenerator, num5);
							num2 = 8;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 38;
								continue;
							}
							continue;
						case 91:
							goto IL_5CF;
						case 92:
							ilgenerator.Emit(OpCodes.Ldelem_Ref);
							num2 = 23;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 36;
								continue;
							}
							continue;
						case 93:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Rxn8xYN4RmKo095ncPk(ilgenerator, OpCodes.Ldsflda, nsVbPXukrvTsEUG8r1V2.j2bieVonlD);
							goto IL_B1F;
						case 94:
						{
							ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7 sxUaepu6HaOlCtHk6W;
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.o5DUHFMp4D.Add(\u0020, sxUaepu6HaOlCtHk6W);
							num2 = 63;
							continue;
						}
						case 95:
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(constructorInfo).IsValueType)
							{
								goto IL_696;
							}
							num2 = 96;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num2 = 7;
								continue;
							}
							continue;
						case 96:
							goto IL_C41;
						default:
							goto IL_BF5;
						}
						IL_1A7:
						ilgenerator.Emit(OpCodes.Ldloc, array[num4]);
						num2 = 22;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 86;
							continue;
						}
						continue;
						IL_1D2:
						array = new LocalBuilder[num3];
						num8 = 0;
						num2 = 72;
						continue;
						IL_257:
						num5++;
						num2 = 18;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_C4E:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Stelem_Ref);
						goto IL_257;
						IL_79E:
						if (array2[num5].ParameterType.IsByRef)
						{
							num2 = 47;
							continue;
						}
						goto IL_257;
						IL_2FC:
						ilgenerator.Emit(OpCodes.Ldarg_1);
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XFi2p1NwcMMaw2ah9nC(ilgenerator, num5);
						num2 = 8;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 75;
							continue;
						}
						continue;
						IL_30D:
						nsVbPXukrvTsEUG8r1V = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.tjOEN6N1MNGKXhQiPMs(\u0020, num5);
						num2 = 32;
						continue;
						IL_34B:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.bDCC0WNQQYjx3QODUZ4(array3[num6], Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236))))
						{
							num2 = 52;
							continue;
						}
						goto IL_9FA;
						IL_5FC:
						if (!array3[num6].IsValueType)
						{
							goto IL_34B;
						}
						num2 = 64;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 49;
							continue;
						}
						continue;
						IL_3A1:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array2[num7]).IsByRef)
						{
							goto IL_A25;
						}
						num2 = 41;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 57;
							continue;
						}
						continue;
						IL_412:
						if (num4 >= array3.Length)
						{
							num2 = 34;
							continue;
						}
						goto IL_B2F;
						IL_457:
						num7++;
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 5;
							continue;
						}
						continue;
						IL_477:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ret);
						num2 = 46;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 46;
							continue;
						}
						continue;
						IL_5CF:
						if (num5 < array3.Length)
						{
							num2 = 10;
							continue;
						}
						goto IL_477;
						IL_4D1:
						nsVbPXukrvTsEUG8r1V2 = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.tjOEN6N1MNGKXhQiPMs(\u0020, num4);
						num2 = 87;
						continue;
						IL_504:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array2[num4]).IsByRef)
						{
							goto IL_321;
						}
						num2 = 17;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 13;
							continue;
						}
						continue;
						IL_B2F:
						if (\u0020.V7ou2eLZeg(num4))
						{
							num2 = 40;
							continue;
						}
						goto IL_504;
						IL_625:
						ilgenerator.Emit(OpCodes.Ldarg_1);
						num2 = 90;
						continue;
						IL_685:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_1);
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XFi2p1NwcMMaw2ah9nC(ilgenerator, num5);
						num2 = 23;
						continue;
						IL_696:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(ilgenerator, OpCodes.Box, constructorInfo.DeclaringType);
						num2 = 51;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 9;
							continue;
						}
						continue;
						IL_813:
						if (num8 >= array3.Length)
						{
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							if (!\u0020.V7ou2eLZeg(num8))
							{
								num2 = 16;
								continue;
							}
							break;
						}
						IL_855:
						array[num8] = ilgenerator.DeclareLocal(array3[num8]);
						num2 = 67;
						continue;
						IL_9FA:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Stloc, array[num6]);
						num2 = 25;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 33;
							continue;
						}
						continue;
						IL_A25:
						array3[num7] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.LGJ5aS6auubN8cVos9C(array2[num7]);
						num2 = 68;
						continue;
						IL_ACE:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_1);
						num2 = 48;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 61;
							continue;
						}
						continue;
						IL_B85:
						if (num6 < array3.Length)
						{
							goto IL_ACE;
						}
						num2 = 12;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 20;
							continue;
						}
						continue;
						IL_B1F:
						num4++;
						num2 = 28;
						continue;
						IL_321:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.NyeOwTNA0O2llrCdLqZ(ilgenerator, OpCodes.Ldloc, array[num4]);
						goto IL_B1F;
						IL_BAA:
						num3 = array3.Length;
						num2 = 45;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 78;
							continue;
						}
						continue;
						IL_87F:
						if (num7 < array3.Length)
						{
							goto Block_33;
						}
						goto IL_BAA;
						IL_BF5:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CVNN9GNZyo6A1rxFaGp(array[num5]).IsValueType)
						{
							num2 = 55;
							continue;
						}
						goto IL_CAA;
						IL_C13:
						ilgenerator.Emit(OpCodes.Ldloc, array[num4]);
						num2 = 59;
						continue;
						IL_C41:
						num5 = 0;
						num2 = 91;
						continue;
						IL_CAA:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Stelem_Ref);
						num2 = 31;
						continue;
						IL_CCF:
						num6 = 0;
						num2 = 62;
						continue;
						IL_D5A:
						ilgenerator.Emit(OpCodes.Stelem_Ref);
						num2 = 42;
						continue;
						IL_3DE:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.aqT1md6uwDb4r6DnKUy(nsVbPXukrvTsEUG8r1V2.j2bieVonlD).IsValueType)
						{
							goto Block_10;
						}
						goto IL_1A7;
					}
					IL_277:
					array[num8] = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xYLIrcN9cHigshd3beI(ilgenerator, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236)));
					num = 45;
					continue;
					IL_337:
					num8++;
					num = 11;
					continue;
					IL_BCA:
					goto IL_337;
					Block_10:
					num = 82;
					continue;
					IL_541:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Rxn8xYN4RmKo095ncPk(ilgenerator, OpCodes.Ldflda, nsVbPXukrvTsEUG8r1V2.j2bieVonlD);
					num = 56;
					continue;
					Block_33:
					num = 37;
				}
				return result;
			}

			// Token: 0x06000C7A RID: 3194 RVA: 0x000676C0 File Offset: 0x000658C0
			private static void DyO8KsQIjH(ILGenerator \u0020, int \u0020)
			{
				int num;
				switch (\u0020)
				{
				case -1:
					IL_E2:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(\u0020, OpCodes.Ldc_I4_M1);
					num = 12;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 6;
					}
					break;
				case 0:
					\u0020.Emit(OpCodes.Ldc_I4_0);
					num = 1;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 5;
					}
					break;
				case 1:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(\u0020, OpCodes.Ldc_I4_1);
					num = 6;
					break;
				case 2:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(\u0020, OpCodes.Ldc_I4_2);
					num = 7;
					break;
				case 3:
					\u0020.Emit(OpCodes.Ldc_I4_3);
					num = 8;
					break;
				case 4:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(\u0020, OpCodes.Ldc_I4_4);
					num = 2;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num = 2;
					}
					break;
				case 5:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(\u0020, OpCodes.Ldc_I4_5);
					return;
				case 6:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(\u0020, OpCodes.Ldc_I4_6);
					num = 3;
					break;
				case 7:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(\u0020, OpCodes.Ldc_I4_7);
					num = 9;
					break;
				case 8:
					\u0020.Emit(OpCodes.Ldc_I4_8);
					num = 0;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
					{
						num = 0;
					}
					break;
				default:
					if (\u0020 <= -129)
					{
						goto IL_CC;
					}
					num = 4;
					break;
				}
				for (;;)
				{
					IL_10:
					switch (num)
					{
					case 1:
						goto IL_E2;
					case 2:
						return;
					case 3:
						return;
					case 4:
						if (\u0020 >= 128)
						{
							goto IL_CC;
						}
						num = 13;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num = 7;
							continue;
						}
						continue;
					case 5:
						return;
					case 6:
						return;
					case 7:
						return;
					case 8:
						return;
					case 9:
						return;
					case 10:
						return;
					case 11:
						return;
					case 12:
						return;
					case 13:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.SsOhuwNO3iKvKSx1Jr8(\u0020, OpCodes.Ldc_I4_S, (sbyte)\u0020);
						num = 11;
						continue;
					}
					break;
				}
				return;
				IL_CC:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.paBwgsNf9mSjY1JGwmM(\u0020, OpCodes.Ldc_I4, \u0020);
				num = 10;
				goto IL_10;
			}

			// Token: 0x06000C7B RID: 3195 RVA: 0x000678F4 File Offset: 0x00065AF4
			private static ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Msp8eqXF7P(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					object obj;
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eypu226HVfIansf7PwU(\u0020).MEy8J5BANA())
						{
							goto IL_CD;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
					{
						Type underlyingType = Enum.GetUnderlyingType(obj.GetType());
						num2 = 4;
						continue;
					}
					case 4:
					{
						Type underlyingType;
						object obj2 = Convert.ChangeType(obj, underlyingType);
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Gj88kR3e75(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KlTokE2aNyb32xhd2qp(underlyingType, obj2));
						if (x0cbwj80qtx55Tsu8UC != null)
						{
							num2 = 7;
							continue;
						}
						break;
					}
					case 5:
						if (obj != null)
						{
							goto IL_47;
						}
						num2 = 2;
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						goto IL_47;
					case 7:
						goto IL_AB;
					case 8:
						goto IL_CD;
					}
					break;
					IL_47:
					if (obj.GetType().IsEnum)
					{
						num2 = 3;
						continue;
					}
					break;
					IL_CD:
					obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(\u0020, null);
					num2 = 3;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num2 = 5;
					}
				}
				return \u0020;
				IL_AB:
				return x0cbwj80qtx55Tsu8UC as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB;
			}

			// Token: 0x06000C7C RID: 3196 RVA: 0x00067A58 File Offset: 0x00065C58
			private static ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB Gj88kR3e75(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 2;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (qmmmuQuSWS2kKwsrFfB != null)
						{
							num2 = 3;
							continue;
						}
						if (!\u0020.TB5dFM9QIv())
						{
							return qmmmuQuSWS2kKwsrFfB;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						qmmmuQuSWS2kKwsrFfB = (\u0020 as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						return qmmmuQuSWS2kKwsrFfB;
					case 4:
						return qmmmuQuSWS2kKwsrFfB;
					}
					qmmmuQuSWS2kKwsrFfB = (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.eypu226HVfIansf7PwU(\u0020) as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
					num2 = 3;
					if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
					{
						num2 = 4;
					}
				}
				return qmmmuQuSWS2kKwsrFfB;
			}

			// Token: 0x06000C7D RID: 3197 RVA: 0x00067B28 File Offset: 0x00065D28
			private static IntPtr rAg8ryuQY6(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 4;
				int num2 = num;
				object obj;
				for (;;)
				{
					ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR sK9Zdfu498A1KFPnIfR;
					switch (num2)
					{
					case 0:
						goto IL_F7;
					case 1:
						if (obj == null)
						{
							goto IL_18A;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
						{
							num2 = 7;
							continue;
						}
						continue;
					case 2:
						try
						{
							return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.FverMONFJQqf5fgZuUL(sK9Zdfu498A1KFPnIfR);
						}
						catch
						{
							goto IL_F7;
						}
						goto IL_182;
					case 3:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Lq75Zf2Ro0vIZe9oD0E(\u0020))
						{
							goto IL_5A;
						}
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.TnDQ5H2FKjyPapNdCQK(\u0020))
						{
							goto IL_F7;
						}
						break;
					case 4:
						if (\u0020 != null)
						{
							num2 = 3;
							continue;
						}
						goto IL_A7;
					case 5:
						goto IL_5A;
					case 6:
						goto IL_182;
					case 7:
						if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Pc2QlI2i08jdrbwRHq8(obj.GetType(), ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777245))))
						{
							goto IL_18A;
						}
						num2 = 4;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 6;
							continue;
						}
						continue;
					case 8:
						break;
					case 9:
						goto IL_A7;
					default:
						goto IL_F7;
					}
					sK9Zdfu498A1KFPnIfR = (ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020;
					num2 = 2;
					continue;
					IL_F7:
					obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Hdy8ge2rK4ysVuKoVd5(\u0020, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777245)));
					num2 = 1;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num2 = 0;
					}
				}
				IL_5A:
				return ((ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb)\u0020).oM8u8TUrCx();
				IL_A7:
				return IntPtr.Zero;
				IL_182:
				return (IntPtr)obj;
				IL_18A:
				throw new ykD11HxHfZBYH7OcFOG.A9dEPKu18soOU9o8vkD();
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x00067CE8 File Offset: 0x00065EE8
			private static object tDD87hmSs4(object \u0020)
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_1FE;
					case 2:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.hV4UfuIwMP != null)
						{
							goto IL_225;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						try
						{
							Type type = \u0020.GetType();
							int num3 = 4;
							int num4 = num3;
							ykD11HxHfZBYH7OcFOG.wWir2guNhxhMbk5v7nG wWir2guNhxhMbk5v7nG;
							object result;
							for (;;)
							{
								ykD11HxHfZBYH7OcFOG.wWir2guNhxhMbk5v7nG wWir2guNhxhMbk5v7nG2;
								switch (num4)
								{
								case 1:
									goto IL_132;
								case 2:
									ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.hV4UfuIwMP.Add(type, wWir2guNhxhMbk5v7nG);
									num4 = 3;
									continue;
								case 3:
									goto IL_114;
								case 4:
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.hV4UfuIwMP.TryGetValue(type, out wWir2guNhxhMbk5v7nG2))
									{
										goto IL_151;
									}
									num4 = 0;
									if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
									{
										num4 = 0;
										continue;
									}
									continue;
								case 5:
									goto IL_151;
								}
								IL_78:
								DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777236)), new Type[]
								{
									Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236))
								}, true);
								object obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.oBStSmNVvgxhIwuKUHL(dynamicMethod);
								obj.Emit(OpCodes.Ldarg_0);
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.neCsKcNywEWXTn0WfjH(obj, OpCodes.Unbox_Any, type);
								obj.Emit(OpCodes.Box, type);
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(obj, OpCodes.Ret);
								wWir2guNhxhMbk5v7nG = (ykD11HxHfZBYH7OcFOG.wWir2guNhxhMbk5v7nG)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XvgvQPNUKA1erHJaUlI(dynamicMethod, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(33554567)));
								num4 = 2;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num4 = 0;
									continue;
								}
								continue;
								IL_151:
								result = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.fsUHqwNTmE4q7EioeNl(wWir2guNhxhMbk5v7nG2, \u0020);
								num4 = 1;
								if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
								{
									num4 = 0;
									continue;
								}
								continue;
								goto IL_78;
							}
							IL_114:
							result = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.fsUHqwNTmE4q7EioeNl(wWir2guNhxhMbk5v7nG, \u0020);
							IL_132:
							return result;
						}
						catch
						{
							object result = null;
							int num5 = 0;
							if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
							{
								num5 = 0;
							}
							switch (num5)
							{
							}
							return result;
						}
						goto IL_1FE;
					case 4:
						goto IL_225;
					}
					break;
					IL_1FE:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.hV4UfuIwMP = new Dictionary<Type, ykD11HxHfZBYH7OcFOG.wWir2guNhxhMbk5v7nG>();
					num2 = 4;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_225:
					if (\u0020 == null)
					{
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 3;
					}
				}
				return null;
			}

			// Token: 0x06000C7F RID: 3199 RVA: 0x00067F88 File Offset: 0x00066188
			private static void RZe822qscH(IntPtr \u0020, byte \u0020, int \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qmtUIA9fJG != null)
						{
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777218)), new Type[]
							{
								Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777245)),
								Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777328)),
								ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777219))
							}, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)), true);
							ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_0);
							ilgenerator.Emit(OpCodes.Ldarg_1);
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ldarg_2);
							ilgenerator.Emit(OpCodes.Initblk);
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(ilgenerator, OpCodes.Ret);
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qmtUIA9fJG = (ykD11HxHfZBYH7OcFOG.yxFAYJunxG2abHMChR2)ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.XvgvQPNUKA1erHJaUlI(dynamicMethod, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554568)));
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() == null)
							{
								num2 = 2;
								continue;
							}
							continue;
						}
						break;
					case 3:
						return;
					}
					IL_13A:
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.wHAxJJNRfuA2btHAxl7(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qmtUIA9fJG, \u0020, \u0020, \u0020);
					num2 = 3;
					continue;
					goto IL_13A;
				}
			}

			// Token: 0x06000C80 RID: 3200 RVA: 0x000680E8 File Offset: 0x000662E8
			private static void Nfq86IYQGq(IntPtr \u0020, IntPtr \u0020, uint \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DGiUm2pxpH != null)
						{
							goto IL_54;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.JgSdms2QGvss8ZaODe4() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						goto IL_54;
					}
					DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777218)), new Type[]
					{
						Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777245)),
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777245)),
						Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(16777256))
					}, ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554540)), true);
					object obj = ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.oBStSmNVvgxhIwuKUHL(dynamicMethod);
					obj.Emit(OpCodes.Ldarg_0);
					obj.Emit(OpCodes.Ldarg_1);
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.qbAmmmN8NQcCDwixqxh(obj, OpCodes.Ldarg_2);
					obj.Emit(OpCodes.Cpblk);
					obj.Emit(OpCodes.Ret);
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DGiUm2pxpH = (ykD11HxHfZBYH7OcFOG.Wbptbeu0dLaolfKjSW5)dynamicMethod.CreateDelegate(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.CkMfq82U3XgfEcDf5mg(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.kmQraS2Z5QK7VHATUC0(33554569)));
					num2 = 2;
					if (!ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.yGQQNu23Tk82ma485Sn())
					{
						num2 = 2;
					}
				}
				IL_54:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.AJrcKNNLgYgAvGurHTw(ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DGiUm2pxpH, \u0020, \u0020, \u0020);
			}

			// Token: 0x06000C81 RID: 3201 RVA: 0x00068234 File Offset: 0x00066434
			public XVaV1xuJTWO8QjAwq7F()
			{
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.UWDjUwNlaP08ZDT8KHM();
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.xNF0X9NasLbkQpHJtlO();
				this.XZ2lKJZI20 = new ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[0];
				this.RGflstwkfS = new ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[0];
				this.Qk8lqGTUrC = new ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn();
				this.RHilFDgR4P = -1;
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000C82 RID: 3202 RVA: 0x000682D0 File Offset: 0x000664D0
			// Note: this type is marked as 'beforefieldinit'.
			static XVaV1xuJTWO8QjAwq7F()
			{
				int num = 8;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_8B;
					case 2:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.nwWU0vFu65 = new Dictionary<ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7>();
						num2 = 0;
						if (false)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.i61l3vZWFk = new Dictionary<object, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC>();
						num2 = 6;
						continue;
					case 4:
						PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
						num2 = 0;
						if (!false)
						{
							num2 = 3;
							continue;
						}
						continue;
					case 5:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.WSKlzoDo0S = new Dictionary<MethodBase, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7>();
						num2 = 2;
						continue;
					case 6:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.p3Fl2XInXl = new Dictionary<MethodBase, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7>();
						num2 = 5;
						continue;
					case 7:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.UWDjUwNlaP08ZDT8KHM();
						num2 = 2;
						if (!false)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 8:
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.ognxuZNK0qo1iEmU1dg();
						num2 = 7;
						continue;
					}
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.ajiU1CstPT = new Dictionary<ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7>();
					num2 = 0;
					if (!false)
					{
						num2 = 1;
					}
				}
				IL_8B:
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.o5DUHFMp4D = new Dictionary<ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7>();
			}

			// Token: 0x06000C83 RID: 3203 RVA: 0x000683F4 File Offset: 0x000665F4
			internal static bool yGQQNu23Tk82ma485Sn()
			{
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.vvCdqD2oLmdpfqbMCwD == null;
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x00068408 File Offset: 0x00066608
			internal static ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F JgSdms2QGvss8ZaODe4()
			{
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.vvCdqD2oLmdpfqbMCwD;
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x00068418 File Offset: 0x00066618
			internal static void GSpvE82C0Y4JVrFCtCP(IntPtr A_0)
			{
				Marshal.FreeHGlobal(A_0);
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x0006842C File Offset: 0x0006662C
			internal static void XREDdD295HMEMvBWcOi(object A_0)
			{
				A_0.Clear();
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x00068440 File Offset: 0x00066640
			internal static object gF64Ti2wGIH7XVCEvTr(object A_0)
			{
				return A_0.InnerException;
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x00068454 File Offset: 0x00066654
			internal static void yKGuKK2AZ5CnX5YYgyb(object A_0)
			{
				A_0.bv68jSYg9n();
			}

			// Token: 0x06000C89 RID: 3209 RVA: 0x00068468 File Offset: 0x00066668
			internal static int pSV66K2hQamHiykSsqJ(object A_0)
			{
				return A_0.Count;
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x0006847C File Offset: 0x0006667C
			internal static void JgGVJC2SyV73ZL4gxdV(object A_0, object A_1)
			{
				A_0.CBp8byx5jM(A_1);
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x00068494 File Offset: 0x00066694
			internal static Type rJ4qON2Ir7sBJXNHLSj(object A_0)
			{
				return A_0.GetType();
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x000684A8 File Offset: 0x000666A8
			internal static bool Pc2QlI2i08jdrbwRHq8(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x000684C0 File Offset: 0x000666C0
			internal static RuntimeTypeHandle kmQraS2Z5QK7VHATUC0(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x000684D4 File Offset: 0x000666D4
			internal static Type CkMfq82U3XgfEcDf5mg(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000C8F RID: 3215 RVA: 0x000684E8 File Offset: 0x000666E8
			internal static bool QGq6iQ210OvmpSkyxxS(object A_0, object A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000C90 RID: 3216 RVA: 0x00068500 File Offset: 0x00066700
			internal static object mHJ0Mr2pIfbJPE7tq2O(object A_0)
			{
				return A_0.cL3qW1trrh();
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x00068514 File Offset: 0x00066714
			internal static IntPtr f5jHoN24g0jBEI5KuTG(object A_0)
			{
				return A_0.oM8u8TUrCx();
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x00068528 File Offset: 0x00066728
			internal static object nJhaI62OTtFZQY9FGEp(object A_0)
			{
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Ths8UetqTq(A_0);
			}

			// Token: 0x06000C93 RID: 3219 RVA: 0x0006853C File Offset: 0x0006673C
			internal static object KBOgmx2frpwcTrqS6uk(object A_0)
			{
				return A_0.o1ZqfYXchM();
			}

			// Token: 0x06000C94 RID: 3220 RVA: 0x00068550 File Offset: 0x00066750
			internal static bool TnDQ5H2FKjyPapNdCQK(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x00068564 File Offset: 0x00066764
			internal static object EWnKTG2TixUljaDFR5D(object A_0)
			{
				return A_0.HK7q1PliPm();
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x00068578 File Offset: 0x00066778
			internal static bool Lq75Zf2Ro0vIZe9oD0E(object A_0)
			{
				return A_0.tXF8H2TS5Y();
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x0006858C File Offset: 0x0006678C
			internal static Type OhecIY2LQxV4Lqk6f4a(object A_0, int A_1)
			{
				return A_0.ResolveType(A_1);
			}

			// Token: 0x06000C98 RID: 3224 RVA: 0x000685A4 File Offset: 0x000667A4
			internal static object Vjlm2N2lDSCeFJXbM6u(object A_0)
			{
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.tDD87hmSs4(A_0);
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x000685B8 File Offset: 0x000667B8
			internal static object KlTokE2aNyb32xhd2qp(Type \u0020, object A_1)
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(\u0020, A_1);
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x000685D0 File Offset: 0x000667D0
			internal static void SA7JyV2KGgwSUfx1VU0(object A_0, object A_1)
			{
				A_0.AxwqVJ6XV5(A_1);
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x000685E8 File Offset: 0x000667E8
			internal static object IJDk1J2eybZ57T1Swsj(object A_0, object A_1)
			{
				return A_0.Add(A_1);
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x00068600 File Offset: 0x00066800
			internal static object jupdeL2kBbQ4FZLkE14(object A_0)
			{
				return A_0.XWcqXDk1Pt();
			}

			// Token: 0x06000C9D RID: 3229 RVA: 0x00068614 File Offset: 0x00066814
			internal static object Hdy8ge2rK4ysVuKoVd5(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x0006862C File Offset: 0x0006682C
			internal static object nrx4Oo27LiAVUJGhIXw(object A_0)
			{
				return A_0.Msjqm6OQGU();
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x00068640 File Offset: 0x00066840
			internal static object UVBILW22gJhrJw7HxpS(object A_0, object A_1)
			{
				return A_0.cmUqbj78eE(A_1);
			}

			// Token: 0x06000CA0 RID: 3232 RVA: 0x00068658 File Offset: 0x00066858
			internal static object wACY2Z26Rx00o1ndclK(object A_0, object A_1)
			{
				return A_0.XIyd5fI2tA(A_1);
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x00068670 File Offset: 0x00066870
			internal static bool svfakY2NeFlhg4Zolle(object A_0, object A_1)
			{
				return A_0.DoCdicvJaP(A_1);
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x00068688 File Offset: 0x00066888
			internal static object bqXHfM2nPCr1sAADGOJ(object A_0)
			{
				return A_0.rMZqkTKtdW();
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x0006869C File Offset: 0x0006689C
			internal static object WByUp420D1Qj7bCeZq9(object A_0)
			{
				return A_0.eoUqScGyAS();
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x000686B0 File Offset: 0x000668B0
			internal static int ROQy9T2J7rpXtwJLuon(object A_0)
			{
				return A_0.o7JUtBOnjt();
			}

			// Token: 0x06000CA5 RID: 3237 RVA: 0x000686C4 File Offset: 0x000668C4
			internal static bool C4RYcd2muw4o4uopGsp(object A_0)
			{
				return A_0.Qgk8YYFIOA();
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x000686D8 File Offset: 0x000668D8
			internal static int eYLLJT2Hd9e0Wdb6UL0()
			{
				return IntPtr.Size;
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x000686E8 File Offset: 0x000668E8
			internal static bool bObcNt2tby4WF4mr9is(object A_0)
			{
				return A_0.jZ28mHocbm();
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x000686FC File Offset: 0x000668FC
			internal static bool mUVF6l2YoIJqbMVd6KH(object A_0)
			{
				return A_0.snedf8QbBG();
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x00068710 File Offset: 0x00066910
			internal static object kJcu0S2sj0oAUHfqmg6(object A_0)
			{
				return A_0.FmZq4JYpT6();
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x00068724 File Offset: 0x00066924
			internal static void yxTqPB2gVj6q2Wa8L3S(object A_0, object A_1)
			{
				A_0.qEGqyetc79(A_1);
			}

			// Token: 0x06000CAB RID: 3243 RVA: 0x0006873C File Offset: 0x0006693C
			internal static object MnA3Bc2X79qx1q2YIhE(object A_0)
			{
				return A_0.c1GqttOeWQ();
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x00068750 File Offset: 0x00066950
			internal static void P3OhJy2MTyox3MoHoQr(object A_0, object A_1, int A_2)
			{
				A_0.SetValue(A_1, A_2);
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x0006876C File Offset: 0x0006696C
			internal static object F4qx4Z2GNn5J4ZSdWHL(object A_0, object A_1)
			{
				return A_0.Ut1dxA1rQp(A_1);
			}

			// Token: 0x06000CAE RID: 3246 RVA: 0x00068784 File Offset: 0x00066984
			internal static bool dGOTPM2BTBtEuSX6cdQ(object A_0, object A_1)
			{
				return A_0.VdHdUonKxI(A_1);
			}

			// Token: 0x06000CAF RID: 3247 RVA: 0x0006879C File Offset: 0x0006699C
			internal static object qfjcD02DC7YyAwTRfsu(object A_0, int A_1)
			{
				return A_0.GetValue(A_1);
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x000687B4 File Offset: 0x000669B4
			internal static object IBiZrr2vGqw2U7SKUdW(object A_0)
			{
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Msp8eqXF7P(A_0);
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x000687C8 File Offset: 0x000669C8
			internal static bool Noob9N2jXyWoaJ1YZTI(object A_0, object A_1)
			{
				return A_0.ovDdASrPUT(A_1);
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x000687E0 File Offset: 0x000669E0
			internal static object firLfX2b9yQe64i2LfW(object A_0, int A_1)
			{
				return A_0.ResolveField(A_1);
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x000687F8 File Offset: 0x000669F8
			internal static object AFnvL92zEHZF9IGY8pJ(object A_0)
			{
				return A_0.xOa8zYuH0k();
			}

			// Token: 0x06000CB4 RID: 3252 RVA: 0x0006880C File Offset: 0x00066A0C
			internal static bool Xx2idY6Wfq4e4FIbJfr(double A_0)
			{
				return double.IsInfinity(A_0);
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x00068820 File Offset: 0x00066A20
			internal static object slfUwc6P1ZXtyGDfV2K(object A_0)
			{
				return A_0.CVaq6fDwxc();
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x00068834 File Offset: 0x00066A34
			internal static bool sxo0l56ElSwYiAfexBV(object A_0, object A_1)
			{
				return A_0.Fqpd4WZY4A(A_1);
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x0006884C File Offset: 0x00066A4C
			internal static bool uFRdvj6cdeOCoudbh3a(object A_0, object A_1)
			{
				return A_0.g5sdhSCwCu(A_1);
			}

			// Token: 0x06000CB8 RID: 3256 RVA: 0x00068864 File Offset: 0x00066A64
			internal static bool Yyfb8u65WZelCkMXfEE(object A_0, object A_1)
			{
				return A_0.IJkdZ22aVF(A_1);
			}

			// Token: 0x06000CB9 RID: 3257 RVA: 0x0006887C File Offset: 0x00066A7C
			internal static Type y3Hvl16xbGsKhCwdXLo(object A_0)
			{
				return A_0.FieldType;
			}

			// Token: 0x06000CBA RID: 3258 RVA: 0x00068890 File Offset: 0x00066A90
			internal static Type aqT1md6uwDb4r6DnKUy(object A_0)
			{
				return A_0.DeclaringType;
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x000688A4 File Offset: 0x00066AA4
			internal static void vrDy8U6Vc3ZKTeuNQSW(object A_0, object A_1, object A_2)
			{
				A_0.SetValue(A_1, A_2);
			}

			// Token: 0x06000CBC RID: 3260 RVA: 0x000688C0 File Offset: 0x00066AC0
			internal static object YIFnkv6y2hr2ZRJjbE0(object A_0, object A_1)
			{
				return A_0.yCeduJ3YIo(A_1);
			}

			// Token: 0x06000CBD RID: 3261 RVA: 0x000688D8 File Offset: 0x00066AD8
			internal static object YyWJBg68hcawfFVOWa7(object A_0, object A_1)
			{
				return A_0.O5ndVV1NCh(A_1);
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x000688F0 File Offset: 0x00066AF0
			internal static object uME7nq6qgBCyTViFm1x(object A_0, object A_1)
			{
				return A_0.f17d3EnLUZ(A_1);
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x00068908 File Offset: 0x00066B08
			internal static object SXjTgW6d9WTLVJjAC1A(object A_0, int A_1)
			{
				return A_0.ResolveMethod(A_1);
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x00068920 File Offset: 0x00066B20
			internal static object NoufUf6ojMfWgKMUwVO(object A_0, int A_1)
			{
				return A_0.ResolveMember(A_1);
			}

			// Token: 0x06000CC1 RID: 3265 RVA: 0x00068938 File Offset: 0x00066B38
			internal static IntPtr HNttJW633ZrRfjMO9La(int A_0)
			{
				return Marshal.AllocHGlobal(A_0);
			}

			// Token: 0x06000CC2 RID: 3266 RVA: 0x0006894C File Offset: 0x00066B4C
			internal static object JDTfAS6QHuMfwQeIPNP(object A_0)
			{
				return A_0.qJhqHVUG8k();
			}

			// Token: 0x06000CC3 RID: 3267 RVA: 0x00068960 File Offset: 0x00066B60
			internal static object j0RygE6ChFrQYPDdRXT(Type A_0)
			{
				return Activator.CreateInstance(A_0);
			}

			// Token: 0x06000CC4 RID: 3268 RVA: 0x00068974 File Offset: 0x00066B74
			internal static object a9Dj5469ngL67ye7C67(object A_0, object A_1)
			{
				return A_0.jaYdc2eCJF(A_1);
			}

			// Token: 0x06000CC5 RID: 3269 RVA: 0x0006898C File Offset: 0x00066B8C
			internal static int kARQfL6wODr8TFJZGyS(object A_0)
			{
				return A_0.Count;
			}

			// Token: 0x06000CC6 RID: 3270 RVA: 0x000689A0 File Offset: 0x00066BA0
			internal static object nSD07y6AlE0Jma3rCu5(object A_0, int A_1)
			{
				return A_0.ResolveString(A_1);
			}

			// Token: 0x06000CC7 RID: 3271 RVA: 0x000689B8 File Offset: 0x00066BB8
			internal static object tkEApG6hNEvTi61vDxs(object A_0, object A_1)
			{
				return A_0.lBXdd758He(A_1);
			}

			// Token: 0x06000CC8 RID: 3272 RVA: 0x000689D0 File Offset: 0x00066BD0
			internal static object Yw7pKo6SNAQGhPpJ5ut(object A_0)
			{
				return A_0.hYvqOWPpOC();
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x000689E4 File Offset: 0x00066BE4
			internal static object oshsg06IcXYWfhXa9nf(object A_0, object A_1)
			{
				return A_0.L5SdoEFytK(A_1);
			}

			// Token: 0x06000CCA RID: 3274 RVA: 0x000689FC File Offset: 0x00066BFC
			internal static object PNJrPu6i4W9ajkEyANF(object A_0, object A_1)
			{
				return A_0.cT0dPKbnSa(A_1);
			}

			// Token: 0x06000CCB RID: 3275 RVA: 0x00068A14 File Offset: 0x00066C14
			internal static object ip0IZd6ZyLkOLxjE6Ht(object A_0, object A_1)
			{
				return A_0.DyOdyCLR3X(A_1);
			}

			// Token: 0x06000CCC RID: 3276 RVA: 0x00068A2C File Offset: 0x00066C2C
			internal static object DtYrLN6URkcI4jatjK4(object A_0, object A_1)
			{
				return A_0.C3mdEhLvXd(A_1);
			}

			// Token: 0x06000CCD RID: 3277 RVA: 0x00068A44 File Offset: 0x00066C44
			internal static object sMm6n861Q7blLnJUiqT(object A_0)
			{
				return A_0.NN3qlXny0A();
			}

			// Token: 0x06000CCE RID: 3278 RVA: 0x00068A58 File Offset: 0x00066C58
			internal static object L3yR9g6pp3lu47yo0eO(object A_0)
			{
				return A_0.ziwqR9N2wv();
			}

			// Token: 0x06000CCF RID: 3279 RVA: 0x00068A6C File Offset: 0x00066C6C
			internal static bool DiMWpC64ohDhIPOrnBv(object A_0, object A_1)
			{
				return A_0.DSNdIxSMBQ(A_1);
			}

			// Token: 0x06000CD0 RID: 3280 RVA: 0x00068A84 File Offset: 0x00066C84
			internal static object IP1X5V6O7gDTcLLK7Oi(object A_0, object A_1)
			{
				return A_0.GetValue(A_1);
			}

			// Token: 0x06000CD1 RID: 3281 RVA: 0x00068A9C File Offset: 0x00066C9C
			internal static object zV7hg56f50Txkqee6LU(object A_0)
			{
				return A_0.yRRqsHbNK7();
			}

			// Token: 0x06000CD2 RID: 3282 RVA: 0x00068AB0 File Offset: 0x00066CB0
			internal static object vb9prK6FhZR1wSy7K4Q(object A_0)
			{
				return A_0.oAjqFTEeFY();
			}

			// Token: 0x06000CD3 RID: 3283 RVA: 0x00068AC4 File Offset: 0x00066CC4
			internal static object c9jFu46THs9bld9aRCx(object A_0)
			{
				return A_0.SZBqTRsZeT();
			}

			// Token: 0x06000CD4 RID: 3284 RVA: 0x00068AD8 File Offset: 0x00066CD8
			internal static bool xUDbGN6R4M3a7S23DO1(object A_0, object A_1)
			{
				return A_0.WY8dpeljbh(A_1);
			}

			// Token: 0x06000CD5 RID: 3285 RVA: 0x00068AF0 File Offset: 0x00066CF0
			internal static object EAHrx46L8FTbxLhJXst(object A_0, object A_1)
			{
				return A_0.V36dQSy6F7(A_1);
			}

			// Token: 0x06000CD6 RID: 3286 RVA: 0x00068B08 File Offset: 0x00066D08
			internal static object rswRIr6l5N68MvIRO8m(object A_0, object A_1)
			{
				return A_0.KrBqjlnYTv(A_1);
			}

			// Token: 0x06000CD7 RID: 3287 RVA: 0x00068B20 File Offset: 0x00066D20
			internal static Type LGJ5aS6auubN8cVos9C(object A_0)
			{
				return A_0.ParameterType;
			}

			// Token: 0x06000CD8 RID: 3288 RVA: 0x00068B34 File Offset: 0x00066D34
			internal static object pebX2W6K3wIUj7EiTFg(object A_0, bool \u0020, object A_2)
			{
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.KyI8aiUsRE(A_0, \u0020, A_2);
			}

			// Token: 0x06000CD9 RID: 3289 RVA: 0x00068B50 File Offset: 0x00066D50
			internal static object YEi8uQ6emRDuLHZCbI8(object A_0, object A_1)
			{
				return A_0.Invoke(A_1);
			}

			// Token: 0x06000CDA RID: 3290 RVA: 0x00068B68 File Offset: 0x00066D68
			internal static bool Kjq5xa6kdOlQKKKNDed(object A_0, int \u0020)
			{
				return A_0.V7ou2eLZeg(\u0020);
			}

			// Token: 0x06000CDB RID: 3291 RVA: 0x00068B80 File Offset: 0x00066D80
			internal static void hRW8tG6r4yKaS2fGtGV(object A_0, object A_1)
			{
				A_0.YqIuyfQ6hA(A_1);
			}

			// Token: 0x06000CDC RID: 3292 RVA: 0x00068B98 File Offset: 0x00066D98
			internal static object xPKFeF67oIEN2M5pvl0(object A_0)
			{
				return A_0.Jefq04Qqj5();
			}

			// Token: 0x06000CDD RID: 3293 RVA: 0x00068BAC File Offset: 0x00066DAC
			internal static object pWps6362GVcZA47JFbh(object A_0)
			{
				return A_0.HF1qYGZ8gN();
			}

			// Token: 0x06000CDE RID: 3294 RVA: 0x00068BC0 File Offset: 0x00066DC0
			internal static object nl5nqh66evmN1DSumch(object A_0)
			{
				return A_0.cMXqaCAZHq();
			}

			// Token: 0x06000CDF RID: 3295 RVA: 0x00068BD4 File Offset: 0x00066DD4
			internal static object pGwTaH6N2lt7l24W1uh(object A_0)
			{
				return A_0.JjkqMxqLaY();
			}

			// Token: 0x06000CE0 RID: 3296 RVA: 0x00068BE8 File Offset: 0x00066DE8
			internal static IntPtr DW098i6nFT1RBWiJmJe(object A_0)
			{
				return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.rAg8ryuQY6(A_0);
			}

			// Token: 0x06000CE1 RID: 3297 RVA: 0x00068BFC File Offset: 0x00066DFC
			internal static bool wRg08r60CT0WD97QdhM(IntPtr A_0, IntPtr A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000CE2 RID: 3298 RVA: 0x00068C14 File Offset: 0x00066E14
			internal static object w3ExBC6Ji0VLoUdBlWk(object A_0)
			{
				return A_0.U0ZqI72BOj();
			}

			// Token: 0x06000CE3 RID: 3299 RVA: 0x00068C28 File Offset: 0x00066E28
			internal static void FL9drb6md4qRFrBBTRC(IntPtr \u0020, IntPtr \u0020, uint \u0020)
			{
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.Nfq86IYQGq(\u0020, \u0020, \u0020);
			}

			// Token: 0x06000CE4 RID: 3300 RVA: 0x00068C44 File Offset: 0x00066E44
			internal static object eypu226HVfIansf7PwU(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000CE5 RID: 3301 RVA: 0x00068C58 File Offset: 0x00066E58
			internal static object DFvjDg6tlJS04axSBfg(object A_0, object A_1)
			{
				return A_0.auGdW5LU1o(A_1);
			}

			// Token: 0x06000CE6 RID: 3302 RVA: 0x00068C70 File Offset: 0x00066E70
			internal static object i6Yp1h6Y1FrlQa2qQHM(object A_0)
			{
				return A_0.CpmqDtDe45();
			}

			// Token: 0x06000CE7 RID: 3303 RVA: 0x00068C84 File Offset: 0x00066E84
			internal static object zn0kuu6s8NwJt5kPGkA(object A_0)
			{
				return A_0.LYYqJD7UOL();
			}

			// Token: 0x06000CE8 RID: 3304 RVA: 0x00068C98 File Offset: 0x00066E98
			internal static object uuOM5c6gsKusAbftgeL(object A_0)
			{
				return A_0.RywqnVZSZT();
			}

			// Token: 0x06000CE9 RID: 3305 RVA: 0x00068CAC File Offset: 0x00066EAC
			internal static RuntimeMethodHandle t9F8Qx6X03Fmee14pr5(object A_0)
			{
				return A_0.MethodHandle;
			}

			// Token: 0x06000CEA RID: 3306 RVA: 0x00068CC0 File Offset: 0x00066EC0
			internal static object SyVFG66MdZ89MBVZoXi(object A_0)
			{
				return A_0.D1PqgOGTyj();
			}

			// Token: 0x06000CEB RID: 3307 RVA: 0x00068CD4 File Offset: 0x00066ED4
			internal static object M5vyFA6GppAIgdick7x(object A_0)
			{
				return A_0.FOJqpHkit6();
			}

			// Token: 0x06000CEC RID: 3308 RVA: 0x00068CE8 File Offset: 0x00066EE8
			internal static int X23h5V6BX3nZEoQZY2c(object A_0)
			{
				return A_0.Length;
			}

			// Token: 0x06000CED RID: 3309 RVA: 0x00068CFC File Offset: 0x00066EFC
			internal static bool v2RQvk6DylsVnr666ui(object A_0)
			{
				return A_0.IsStatic;
			}

			// Token: 0x06000CEE RID: 3310 RVA: 0x00068D10 File Offset: 0x00066F10
			internal static object RHE8vN6vVwFwVlapkgl(object A_0)
			{
				return A_0.Rw9dqatOP5();
			}

			// Token: 0x06000CEF RID: 3311 RVA: 0x00068D24 File Offset: 0x00066F24
			internal static object lG5Nom6jk8qKhEPw5T1(object A_0)
			{
				return A_0.eFOq2JXLOE();
			}

			// Token: 0x06000CF0 RID: 3312 RVA: 0x00068D38 File Offset: 0x00066F38
			internal static void t39osk6bPq79hgBsAAP(IntPtr \u0020, byte \u0020, int \u0020)
			{
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.RZe822qscH(\u0020, \u0020, \u0020);
			}

			// Token: 0x06000CF1 RID: 3313 RVA: 0x00068D54 File Offset: 0x00066F54
			internal static object BJIdYH6zVWQqA08Nnal(object A_0)
			{
				return A_0.APcqGbirjs();
			}

			// Token: 0x06000CF2 RID: 3314 RVA: 0x00068D68 File Offset: 0x00066F68
			internal static object NbAJVcNW3v4hEAXBLcy(object A_0)
			{
				return A_0.lk5qURpdjk();
			}

			// Token: 0x06000CF3 RID: 3315 RVA: 0x00068D7C File Offset: 0x00066F7C
			internal static object e0SGR8NP4ilFx8EM7MH(Type A_0, int A_1)
			{
				return Array.CreateInstance(A_0, A_1);
			}

			// Token: 0x06000CF4 RID: 3316 RVA: 0x00068D94 File Offset: 0x00066F94
			internal static object LEeZkcNEH2m16GJP5a6(object A_0, object A_1)
			{
				return A_0.dH3d8VFM3E(A_1);
			}

			// Token: 0x06000CF5 RID: 3317 RVA: 0x00068DAC File Offset: 0x00066FAC
			internal static bool sZgTvtNc9UkdPZCf9PO(object A_0)
			{
				return A_0.lPSqCCLN7S();
			}

			// Token: 0x06000CF6 RID: 3318 RVA: 0x00068DC0 File Offset: 0x00066FC0
			internal static object nH3y96N5K9JQHQBgR9F(object A_0, object A_1)
			{
				return A_0.LfyqvMrNHx(A_1);
			}

			// Token: 0x06000CF7 RID: 3319 RVA: 0x00068DD8 File Offset: 0x00066FD8
			internal static bool gw3AKONxufIZdFy15cE(object A_0)
			{
				return A_0.tTi8tbHhPd();
			}

			// Token: 0x06000CF8 RID: 3320 RVA: 0x00068DEC File Offset: 0x00066FEC
			internal static object I2h8UbNuEt9AoScNDCN(object A_0, ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ \u0020)
			{
				return A_0.Q1tqoFEFyp(\u0020);
			}

			// Token: 0x06000CF9 RID: 3321 RVA: 0x00068E04 File Offset: 0x00067004
			internal static object oBStSmNVvgxhIwuKUHL(object A_0)
			{
				return A_0.GetILGenerator();
			}

			// Token: 0x06000CFA RID: 3322 RVA: 0x00068E18 File Offset: 0x00067018
			internal static void neCsKcNywEWXTn0WfjH(object A_0, OpCode A_1, Type A_2)
			{
				A_0.Emit(A_1, A_2);
			}

			// Token: 0x06000CFB RID: 3323 RVA: 0x00068E34 File Offset: 0x00067034
			internal static void qbAmmmN8NQcCDwixqxh(object A_0, OpCode A_1)
			{
				A_0.Emit(A_1);
			}

			// Token: 0x06000CFC RID: 3324 RVA: 0x00068E4C File Offset: 0x0006704C
			internal static object zaNnWqNqBsGL0yFVDL7(object A_0)
			{
				return A_0.GetParameters();
			}

			// Token: 0x06000CFD RID: 3325 RVA: 0x00068E60 File Offset: 0x00067060
			internal static void b5kL85NdMhNcs5krUHU(object A_0, object A_1)
			{
				A_0.xZMdRwMHqP(A_1);
			}

			// Token: 0x06000CFE RID: 3326 RVA: 0x00068E78 File Offset: 0x00067078
			internal static object FOSqgUNoVF68x15PLoV(object A_0, object A_1, object A_2)
			{
				return A_0(A_1, A_2);
			}

			// Token: 0x06000CFF RID: 3327 RVA: 0x00068E94 File Offset: 0x00067094
			internal static object eqVvV1N3sELBCi0OWUI(object A_0, object A_1, object A_2)
			{
				return A_0.Invoke(A_1, A_2);
			}

			// Token: 0x06000D00 RID: 3328 RVA: 0x00068EB0 File Offset: 0x000670B0
			internal static bool bDCC0WNQQYjx3QODUZ4(Type A_0, Type A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000D01 RID: 3329 RVA: 0x00068EC8 File Offset: 0x000670C8
			internal static Type P2XARSNCyw883fskbwl(object A_0)
			{
				return A_0.ReturnType;
			}

			// Token: 0x06000D02 RID: 3330 RVA: 0x00068EDC File Offset: 0x000670DC
			internal static object xYLIrcN9cHigshd3beI(object A_0, Type A_1)
			{
				return A_0.DeclareLocal(A_1);
			}

			// Token: 0x06000D03 RID: 3331 RVA: 0x00068EF4 File Offset: 0x000670F4
			internal static void XFi2p1NwcMMaw2ah9nC(object A_0, int \u0020)
			{
				ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.DyO8KsQIjH(A_0, \u0020);
			}

			// Token: 0x06000D04 RID: 3332 RVA: 0x00068F0C File Offset: 0x0006710C
			internal static void NyeOwTNA0O2llrCdLqZ(object A_0, OpCode A_1, object A_2)
			{
				A_0.Emit(A_1, A_2);
			}

			// Token: 0x06000D05 RID: 3333 RVA: 0x00068F28 File Offset: 0x00067128
			internal static bool Vq2hhRNhFb9WDoAY75l(object A_0, object A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000D06 RID: 3334 RVA: 0x00068F40 File Offset: 0x00067140
			internal static void m37MZrNS7WTihV4Rmpu(object A_0, OpCode A_1, object A_2, object A_3)
			{
				A_0.EmitCall(A_1, A_2, A_3);
			}

			// Token: 0x06000D07 RID: 3335 RVA: 0x00068F60 File Offset: 0x00067160
			internal static void nfZpLpNI1tV3l3TF2SN(object A_0, OpCode A_1, object A_2)
			{
				A_0.Emit(A_1, A_2);
			}

			// Token: 0x06000D08 RID: 3336 RVA: 0x00068F7C File Offset: 0x0006717C
			internal static bool NVBpRMNi2egymnpLuwH(object A_0, object A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000D09 RID: 3337 RVA: 0x00068F94 File Offset: 0x00067194
			internal static Type CVNN9GNZyo6A1rxFaGp(object A_0)
			{
				return A_0.LocalType;
			}

			// Token: 0x06000D0A RID: 3338 RVA: 0x00068FA8 File Offset: 0x000671A8
			internal static object XvgvQPNUKA1erHJaUlI(object A_0, Type A_1)
			{
				return A_0.CreateDelegate(A_1);
			}

			// Token: 0x06000D0B RID: 3339 RVA: 0x00068FC0 File Offset: 0x000671C0
			internal static object tjOEN6N1MNGKXhQiPMs(object A_0, int \u0020)
			{
				return A_0.M6eu7q2go9(\u0020);
			}

			// Token: 0x06000D0C RID: 3340 RVA: 0x00068FD8 File Offset: 0x000671D8
			internal static bool dVUufcNpVK2NVHgVH5e(object A_0)
			{
				return A_0.IsStatic;
			}

			// Token: 0x06000D0D RID: 3341 RVA: 0x00068FEC File Offset: 0x000671EC
			internal static void Rxn8xYN4RmKo095ncPk(object A_0, OpCode A_1, object A_2)
			{
				A_0.Emit(A_1, A_2);
			}

			// Token: 0x06000D0E RID: 3342 RVA: 0x00069008 File Offset: 0x00067208
			internal static void SsOhuwNO3iKvKSx1Jr8(object A_0, OpCode A_1, sbyte A_2)
			{
				A_0.Emit(A_1, A_2);
			}

			// Token: 0x06000D0F RID: 3343 RVA: 0x00069024 File Offset: 0x00067224
			internal static void paBwgsNf9mSjY1JGwmM(object A_0, OpCode A_1, int A_2)
			{
				A_0.Emit(A_1, A_2);
			}

			// Token: 0x06000D10 RID: 3344 RVA: 0x00069040 File Offset: 0x00067240
			internal static IntPtr FverMONFJQqf5fgZuUL(object A_0)
			{
				return A_0.kBGdTuP4Wf();
			}

			// Token: 0x06000D11 RID: 3345 RVA: 0x00069054 File Offset: 0x00067254
			internal static object fsUHqwNTmE4q7EioeNl(object A_0, object A_1)
			{
				return A_0(A_1);
			}

			// Token: 0x06000D12 RID: 3346 RVA: 0x0006906C File Offset: 0x0006726C
			internal static void wHAxJJNRfuA2btHAxl7(object A_0, IntPtr a, byte b, int c)
			{
				A_0(a, b, c);
			}

			// Token: 0x06000D13 RID: 3347 RVA: 0x0006908C File Offset: 0x0006728C
			internal static void AJrcKNNLgYgAvGurHTw(object A_0, IntPtr s, IntPtr t, uint c)
			{
				A_0(s, t, c);
			}

			// Token: 0x06000D14 RID: 3348 RVA: 0x000690AC File Offset: 0x000672AC
			internal static void UWDjUwNlaP08ZDT8KHM()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000D15 RID: 3349 RVA: 0x000690BC File Offset: 0x000672BC
			internal static void xNF0X9NasLbkQpHJtlO()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000D16 RID: 3350 RVA: 0x000690CC File Offset: 0x000672CC
			internal static void ognxuZNK0qo1iEmU1dg()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x040003FD RID: 1021
			internal ykD11HxHfZBYH7OcFOG.E9EX5Muevt1JiiEXHHu OOMlcvRAjr;

			// Token: 0x040003FE RID: 1022
			internal ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[] XZ2lKJZI20;

			// Token: 0x040003FF RID: 1023
			internal ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC[] RGflstwkfS;

			// Token: 0x04000400 RID: 1024
			internal ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn Qk8lqGTUrC;

			// Token: 0x04000401 RID: 1025
			internal ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Goelx4gccH;

			// Token: 0x04000402 RID: 1026
			internal Exception vaqlyQlH5E;

			// Token: 0x04000403 RID: 1027
			internal List<IntPtr> yHPlGnPngy;

			// Token: 0x04000404 RID: 1028
			private int t6plBAG1Rr;

			// Token: 0x04000405 RID: 1029
			private int bgBlLdPL4Z;

			// Token: 0x04000406 RID: 1030
			private int RHilFDgR4P;

			// Token: 0x04000407 RID: 1031
			private object rhZlWn3394;

			// Token: 0x04000408 RID: 1032
			private bool g2tlnWc570;

			// Token: 0x04000409 RID: 1033
			private bool RQPlpS4Dct;

			// Token: 0x0400040A RID: 1034
			private bool jMMlJZsjHx;

			// Token: 0x0400040B RID: 1035
			private bool gvMlV1YWKU;

			// Token: 0x0400040C RID: 1036
			private static Dictionary<Type, int> dVblEuPNaN;

			// Token: 0x0400040D RID: 1037
			private static Dictionary<object, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC> i61l3vZWFk;

			// Token: 0x0400040E RID: 1038
			private static Dictionary<MethodBase, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7> p3Fl2XInXl;

			// Token: 0x0400040F RID: 1039
			private static Dictionary<MethodBase, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7> WSKlzoDo0S;

			// Token: 0x04000410 RID: 1040
			private static Dictionary<ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7> nwWU0vFu65;

			// Token: 0x04000411 RID: 1041
			private static Dictionary<ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7> ajiU1CstPT;

			// Token: 0x04000412 RID: 1042
			private static Dictionary<ykD11HxHfZBYH7OcFOG.HCp9nIur8g9pimJhW0s, ykD11HxHfZBYH7OcFOG.sxUaepu6HaOlCtHk6W7> o5DUHFMp4D;

			// Token: 0x04000413 RID: 1043
			private static Dictionary<Type, ykD11HxHfZBYH7OcFOG.wWir2guNhxhMbk5v7nG> hV4UfuIwMP;

			// Token: 0x04000414 RID: 1044
			private static ykD11HxHfZBYH7OcFOG.yxFAYJunxG2abHMChR2 qmtUIA9fJG;

			// Token: 0x04000415 RID: 1045
			private static ykD11HxHfZBYH7OcFOG.Wbptbeu0dLaolfKjSW5 DGiUm2pxpH;

			// Token: 0x04000416 RID: 1046
			internal static ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F vvCdqD2oLmdpfqbMCwD;

			// Token: 0x0200008B RID: 139
			[CompilerGenerated]
			[Serializable]
			private sealed class seq2cR1pvdJT3LewuIN
			{
				// Token: 0x06000D17 RID: 3351 RVA: 0x000690DC File Offset: 0x000672DC
				// Note: this type is marked as 'beforefieldinit'.
				static seq2cR1pvdJT3LewuIN()
				{
					vua32v5yjQhjRjK4YIO.aep5UvAyyY();
					vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
					int num = 1;
					if (!false)
					{
						num = 1;
					}
					for (;;)
					{
						switch (num)
						{
						case 1:
							ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.TUEeMoN7bnNhBD0xOXk();
							num = 0;
							if (false)
							{
								num = 0;
								continue;
							}
							continue;
						case 2:
							return;
						}
						ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.<>9 = new ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN();
						int num2 = 2;
						num = num2;
					}
				}

				// Token: 0x06000D18 RID: 3352 RVA: 0x00069168 File Offset: 0x00067368
				public seq2cR1pvdJT3LewuIN()
				{
					vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
					ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.TUEeMoN7bnNhBD0xOXk();
					base..ctor();
					int num = 0;
					if (!true)
					{
						num = 0;
					}
					switch (num)
					{
					default:
						return;
					}
				}

				// Token: 0x06000D19 RID: 3353 RVA: 0x000691C4 File Offset: 0x000673C4
				internal int OyYUOIbE1C(ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP x, ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP y)
				{
					return x.aE6ioYbwF8.oe3ivl4Hb5.CompareTo(y.aE6ioYbwF8.oe3ivl4Hb5);
				}

				// Token: 0x06000D1A RID: 3354 RVA: 0x000691E8 File Offset: 0x000673E8
				internal static void TUEeMoN7bnNhBD0xOXk()
				{
					PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				}

				// Token: 0x06000D1B RID: 3355 RVA: 0x000691F8 File Offset: 0x000673F8
				internal static bool IBTwRRNkeIwLeVlNPGW()
				{
					return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.thqStvNes8Hrm1VWO4d == null;
				}

				// Token: 0x06000D1C RID: 3356 RVA: 0x0006920C File Offset: 0x0006740C
				internal static ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN brKbo0NrQqCrl3po4hg()
				{
					return ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN.thqStvNes8Hrm1VWO4d;
				}

				// Token: 0x04000417 RID: 1047
				public static readonly ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN <>9;

				// Token: 0x04000418 RID: 1048
				public static Comparison<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> <>9__12_0;

				// Token: 0x04000419 RID: 1049
				internal static ykD11HxHfZBYH7OcFOG.XVaV1xuJTWO8QjAwq7F.seq2cR1pvdJT3LewuIN thqStvNes8Hrm1VWO4d;
			}
		}

		// Token: 0x0200008C RID: 140
		internal enum k5A7Al8NeNFaSr1YO2j : byte
		{

		}

		// Token: 0x0200008D RID: 141
		internal enum t6eU758n7rTZi75oJfk : byte
		{

		}

		// Token: 0x0200008E RID: 142
		internal abstract class X0cbwj80qtx55Tsu8UC
		{
			// Token: 0x06000D1D RID: 3357 RVA: 0x0006921C File Offset: 0x0006741C
			public X0cbwj80qtx55Tsu8UC()
			{
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.yCPmAONY08oC42wgpEN();
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.aHkm4SNsSe1wetNUBjF();
				base..ctor();
				int num = 0;
				if (false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000D1E RID: 3358 RVA: 0x00069278 File Offset: 0x00067478
			internal bool MEy8J5BANA()
			{
				return this.XyUUA5Idue == (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)0;
			}

			// Token: 0x06000D1F RID: 3359 RVA: 0x0006928C File Offset: 0x0006748C
			internal bool jZ28mHocbm()
			{
				return this.XyUUA5Idue == (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)1;
			}

			// Token: 0x06000D20 RID: 3360 RVA: 0x000692A0 File Offset: 0x000674A0
			internal bool tXF8H2TS5Y()
			{
				return this.XyUUA5Idue == (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)3 || this.XyUUA5Idue == (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)4;
			}

			// Token: 0x06000D21 RID: 3361 RVA: 0x000692CC File Offset: 0x000674CC
			internal bool tTi8tbHhPd()
			{
				return this.XyUUA5Idue == (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)2;
			}

			// Token: 0x06000D22 RID: 3362 RVA: 0x000692E0 File Offset: 0x000674E0
			internal bool Qgk8YYFIOA()
			{
				return this.XyUUA5Idue == (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)5;
			}

			// Token: 0x06000D23 RID: 3363 RVA: 0x000692F4 File Offset: 0x000674F4
			internal bool fIy8s6aUWX()
			{
				return this.XyUUA5Idue == (ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)6;
			}

			// Token: 0x06000D24 RID: 3364 RVA: 0x00069308 File Offset: 0x00067508
			internal virtual bool TB5dFM9QIv()
			{
				return false;
			}

			// Token: 0x06000D25 RID: 3365 RVA: 0x00069314 File Offset: 0x00067514
			internal virtual bool YbodO0QW3H()
			{
				return false;
			}

			// Token: 0x06000D26 RID: 3366
			internal abstract void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000D27 RID: 3367 RVA: 0x00069320 File Offset: 0x00067520
			internal virtual bool snedf8QbBG()
			{
				return false;
			}

			// Token: 0x06000D28 RID: 3368 RVA: 0x0006932C File Offset: 0x0006752C
			internal X0cbwj80qtx55Tsu8UC(ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 0;
				if (!true)
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
					this.XyUUA5Idue = \u0020;
					num = 0;
					if (!false)
					{
						num = 1;
					}
				}
			}

			// Token: 0x06000D29 RID: 3369
			internal abstract object y9jq31urLD(Type \u0020);

			// Token: 0x06000D2A RID: 3370
			internal abstract bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000D2B RID: 3371
			internal abstract bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000D2C RID: 3372
			internal abstract bool lPSqCCLN7S();

			// Token: 0x06000D2D RID: 3373
			internal abstract ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k();

			// Token: 0x06000D2E RID: 3374 RVA: 0x000693A8 File Offset: 0x000675A8
			internal virtual bool y9QdwWY3Xc()
			{
				return false;
			}

			// Token: 0x06000D2F RID: 3375
			internal abstract void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020);

			// Token: 0x06000D30 RID: 3376 RVA: 0x000693B4 File Offset: 0x000675B4
			internal static ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg f7G8gtLASm(Type \u0020)
			{
				int num = 11;
				for (;;)
				{
					int num2 = num;
					for (;;)
					{
						Type type;
						switch (num2)
						{
						case 0:
							goto IL_186;
						case 1:
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777561))))
							{
								goto Block_21;
							}
							if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777257))))
							{
								num2 = 27;
								continue;
							}
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)8;
						case 2:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)8;
						case 3:
							goto IL_427;
						case 4:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)6;
						case 5:
							break;
						case 6:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)0;
						case 7:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2;
						case 8:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)13;
						case 9:
							if (!type.IsByRef)
							{
								num2 = 2;
								if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 3;
									continue;
								}
								continue;
							}
							break;
						case 10:
							if (type != null)
							{
								num2 = 9;
								continue;
							}
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)18;
						case 11:
							type = \u0020;
							num2 = 10;
							continue;
						case 12:
							if (type == ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777615)))
							{
								num2 = 8;
								if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 8;
									continue;
								}
								continue;
							}
							else
							{
								if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777323))))
								{
									return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15;
								}
								num2 = 0;
								if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							break;
						case 13:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)4;
						case 14:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)1;
						case 15:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)14;
						case 16:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)16;
						case 17:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)17;
						case 18:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)10;
						case 19:
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777614))))
							{
								num2 = 14;
								continue;
							}
							if (!(type == ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777253))))
							{
								num2 = 26;
								continue;
							}
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)3;
						case 20:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11;
						case 21:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)9;
						case 22:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)3;
						case 23:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15;
						case 24:
							if (!type.IsEnum)
							{
								num2 = 17;
								continue;
							}
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)16;
						case 25:
							if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777245))))
							{
								num2 = 12;
								continue;
							}
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)12;
						case 26:
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777252))))
							{
								num2 = 3;
								if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
								{
									num2 = 13;
									continue;
								}
								continue;
							}
							else
							{
								if (type == ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777219)))
								{
									return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)5;
								}
								if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777256))))
								{
									return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)6;
								}
								num2 = 1;
								if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 0;
									continue;
								}
								continue;
							}
							break;
						case 27:
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777333))))
							{
								num2 = 21;
								continue;
							}
							if (type == ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777346)))
							{
								return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)10;
							}
							if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777220))))
							{
								num2 = 25;
								continue;
							}
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11;
						case 28:
							goto IL_427;
						case 29:
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)7;
						default:
							goto IL_186;
						}
						type = type.GetElementType();
						num2 = 28;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 7;
							continue;
						}
						continue;
						IL_427:
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777225))))
						{
							num2 = 15;
							continue;
						}
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hCfRmSNXIpZTuZllSny(type, ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.sqrQRKNMbyrZa0fhSgq(16777328))))
						{
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2;
						}
						num2 = 9;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 19;
							continue;
						}
						continue;
						IL_186:
						if (type == ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.NLLNhsNg4AlbMZAg8Cc(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777236)))
						{
							return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)0;
						}
						num2 = 24;
					}
					Block_21:
					num = 29;
				}
				return (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)8;
			}

			// Token: 0x06000D31 RID: 3377 RVA: 0x000698A4 File Offset: 0x00067AA4
			internal static ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC Ldf8XpjhNW(Type \u0020, object \u0020)
			{
				int num = 91;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					int num2 = num;
					ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg jqHLvcuZWpW1MQBVIOg2;
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg jqHLvcuZWpW1MQBVIOg;
							switch (jqHLvcuZWpW1MQBVIOg)
							{
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)0:
								if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
								{
									x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.KREKDnNBLCkkyr1Ncsy(\u0020);
									num2 = 120;
									continue;
								}
								num2 = 72;
								if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 21;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)1:
								if (jqHLvcuZWpW1MQBVIOg2 > (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2)
								{
									goto IL_11BC;
								}
								if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)1)
								{
									num2 = 4;
									continue;
								}
								goto IL_FE7;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2:
								goto IL_821;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)3:
								if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)3)
								{
									goto IL_BAB;
								}
								num2 = 17;
								if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 10;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)4:
								if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)4)
								{
									goto IL_CBC;
								}
								if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
								{
									num2 = 148;
									continue;
								}
								goto IL_454;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)5:
								if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)5)
								{
									num2 = 26;
									continue;
								}
								goto IL_EFB;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)6:
								if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)6)
								{
									num2 = 15;
									continue;
								}
								goto IL_9A9;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)7:
								if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)7)
								{
									goto IL_A4C;
								}
								num2 = 34;
								if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 37;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)8:
								if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)8)
								{
									num2 = 14;
									continue;
								}
								goto IL_C09;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)9:
								if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)9)
								{
									num2 = 131;
									continue;
								}
								goto IL_FB5;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)10:
								if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)10)
								{
									num2 = 80;
									continue;
								}
								goto IL_492;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11:
								switch (jqHLvcuZWpW1MQBVIOg2)
								{
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)1:
									goto IL_146A;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2:
									goto IL_833;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)3:
									goto IL_D4B;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)4:
									goto IL_A0C;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)5:
									goto IL_5C9;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)6:
									goto IL_97F;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)7:
									x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((long)\u0020 != 0L);
									num2 = 152;
									continue;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)8:
									goto IL_1368;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)9:
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)10:
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)12:
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)13:
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)14:
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15:
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)16:
									goto IL_6EE;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11:
									goto IL_1526;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)17:
									goto IL_6F4;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)18:
									goto IL_764;
								default:
									num2 = 128;
									continue;
								}
								break;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)12:
								goto IL_36D;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)13:
								if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)13)
								{
									x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((UIntPtr)\u0020);
									num2 = 108;
									continue;
								}
								goto IL_E25;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)14:
								x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX(\u0020 as string);
								num2 = 109;
								if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 54;
									continue;
								}
								continue;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15:
								switch (jqHLvcuZWpW1MQBVIOg2)
								{
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)1:
									x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((sbyte)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
									num2 = 168;
									continue;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2:
									goto IL_3A2;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)3:
									goto IL_424;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)4:
									goto IL_14B2;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)5:
									x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)\u0020, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
									num2 = 6;
									if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
									{
										num2 = 11;
										continue;
									}
									continue;
								case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)6:
									x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((uint)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
									num2 = 76;
									continue;
								default:
									num2 = 2;
									if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
									{
										num2 = 82;
										continue;
									}
									continue;
								}
								break;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)16:
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)17:
								goto IL_1206;
							case (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)18:
								goto IL_9C1;
							default:
								num2 = 149;
								continue;
							}
							break;
						}
						case 2:
							goto IL_4E9;
						case 3:
							goto IL_14EE;
						case 4:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2)
							{
								goto Block_77;
							}
							goto IL_37B;
						case 5:
							goto IL_14EE;
						case 6:
							goto IL_14EE;
						case 7:
							goto IL_14EE;
						case 8:
							goto IL_14EE;
						case 9:
							goto IL_A0C;
						case 10:
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((char)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
							num2 = 24;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
							{
								num2 = 153;
								continue;
							}
							continue;
						case 11:
							goto IL_14EE;
						case 12:
							goto IL_821;
						case 13:
							goto IL_D4B;
						case 14:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
							{
								num2 = 115;
								continue;
							}
							goto IL_1011;
						case 15:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
							{
								num2 = 1;
								if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 68;
									continue;
								}
								continue;
							}
							else
							{
								if ((bool)\u0020)
								{
									goto IL_E70;
								}
								num2 = 63;
								if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 31;
									continue;
								}
								continue;
							}
							break;
						case 16:
							goto IL_E83;
						case 17:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
							{
								num2 = 46;
								continue;
							}
							goto IL_123B;
						case 18:
							goto IL_14EE;
						case 19:
							goto IL_14EE;
						case 20:
							goto IL_14EE;
						case 21:
							goto IL_14EE;
						case 22:
							jqHLvcuZWpW1MQBVIOg2 = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.JQIGBxNGrNyGmHhUiTZ(\u0020.GetType());
							num2 = 102;
							if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
							{
								num2 = 88;
								continue;
							}
							continue;
						case 23:
							goto IL_3E6;
						case 24:
							goto IL_CBC;
						case 25:
							goto IL_14EE;
						case 26:
							if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
							{
								goto IL_115D;
							}
							num2 = 40;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
							{
								num2 = 19;
								continue;
							}
							continue;
						case 27:
							goto IL_6EE;
						case 28:
							goto IL_B01;
						case 29:
							goto IL_5E3;
						case 30:
							goto IL_1275;
						case 31:
							goto IL_14EE;
						case 32:
							goto IL_146A;
						case 33:
							goto IL_14EE;
						case 34:
							goto IL_14EE;
						case 35:
							if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								goto IL_7AB;
							}
							num2 = 18;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
							{
								num2 = 47;
								continue;
							}
							continue;
						case 36:
							goto IL_FE7;
						case 37:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
							{
								num2 = 35;
								continue;
							}
							goto IL_EB5;
						case 38:
							goto IL_37B;
						case 39:
							goto IL_A88;
						case 40:
							if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								goto IL_3E6;
							}
							num2 = 146;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
							{
								num2 = 19;
								continue;
							}
							continue;
						case 41:
							goto IL_14EE;
						case 42:
							goto IL_14EE;
						case 43:
							goto IL_11BC;
						case 44:
							goto IL_1526;
						case 45:
							goto IL_140A;
						case 46:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								num2 = 136;
								continue;
							}
							goto IL_6B6;
						case 47:
							goto IL_7E3;
						case 48:
							goto IL_A4C;
						case 49:
							goto IL_77A;
						case 50:
							goto IL_14EE;
						case 51:
							goto IL_492;
						case 52:
							goto IL_14EE;
						case 53:
							goto IL_123B;
						case 54:
							goto IL_36D;
						case 55:
							goto IL_14EE;
						case 56:
							goto IL_14EE;
						case 57:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								num2 = 60;
								continue;
							}
							goto IL_D75;
						case 58:
							goto IL_14EE;
						case 59:
							goto IL_14EE;
						case 60:
							goto IL_970;
						case 61:
							goto IL_14EE;
						case 62:
							goto IL_14EE;
						case 63:
							goto IL_13A8;
						case 64:
							goto IL_14EE;
						case 65:
							goto IL_115D;
						case 66:
							goto IL_8CE;
						case 67:
							goto IL_689;
						case 68:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								num2 = 157;
								continue;
							}
							goto IL_3CE;
						case 69:
							goto IL_141D;
						case 70:
							goto IL_F64;
						case 71:
							goto IL_12A7;
						case 72:
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(\u0020);
							num2 = 33;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
							{
								num2 = 15;
								continue;
							}
							continue;
						case 73:
							goto IL_14EE;
						case 74:
							goto IL_764;
						case 75:
							return x0cbwj80qtx55Tsu8UC;
						case 76:
							goto IL_14EE;
						case 77:
							goto IL_424;
						case 78:
							goto IL_14EE;
						case 79:
							goto IL_89D;
						case 80:
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((double)\u0020);
							num2 = 59;
							continue;
						case 81:
							goto IL_14EE;
						case 82:
							if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								num2 = 10;
								if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
								{
									num2 = 8;
									continue;
								}
								continue;
							}
							break;
						case 83:
							if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)1)
							{
								goto IL_479;
							}
							num2 = 118;
							if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
							{
								num2 = 10;
								continue;
							}
							continue;
						case 84:
							goto IL_5C9;
						case 85:
							goto IL_14EE;
						case 86:
							goto IL_C09;
						case 87:
							goto IL_14EE;
						case 88:
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
							num2 = 106;
							continue;
						case 89:
							goto IL_14EE;
						case 90:
							jqHLvcuZWpW1MQBVIOg2 = (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)18;
							num2 = 101;
							continue;
						case 91:
						{
							ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg jqHLvcuZWpW1MQBVIOg = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.JQIGBxNGrNyGmHhUiTZ(\u0020);
							num2 = 90;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
							{
								num2 = 17;
								continue;
							}
							continue;
						}
						case 92:
							goto IL_1513;
						case 93:
							goto IL_833;
						case 94:
							goto IL_541;
						case 95:
							goto IL_14EE;
						case 96:
							goto IL_133D;
						case 97:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								num2 = 66;
								continue;
							}
							goto IL_8DD;
						case 98:
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
							num2 = 95;
							if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
							{
								num2 = 75;
								continue;
							}
							continue;
						case 99:
							goto IL_E5D;
						case 100:
							goto IL_1185;
						case 101:
							if (\u0020 != null)
							{
								goto Block_79;
							}
							goto IL_8B1;
						case 102:
							goto IL_8B1;
						case 103:
							goto IL_EFB;
						case 104:
							goto IL_1206;
						case 105:
							goto IL_14EE;
						case 106:
							goto IL_14EE;
						case 107:
							goto IL_BAB;
						case 108:
							goto IL_14EE;
						case 109:
							goto IL_14EE;
						case 110:
							goto IL_3CE;
						case 111:
							goto IL_14EE;
						case 112:
							goto IL_132E;
						case 113:
							goto IL_14EE;
						case 114:
							goto IL_14EE;
						case 115:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								goto Block_16;
							}
							goto IL_541;
						case 116:
							goto IL_6B6;
						case 117:
							goto IL_14EE;
						case 118:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2)
							{
								num2 = 165;
								continue;
							}
							goto IL_1185;
						case 119:
							goto IL_BD3;
						case 120:
							goto IL_14EE;
						case 121:
							goto IL_12F2;
						case 122:
							goto IL_97F;
						case 123:
							goto IL_8DD;
						case 124:
							goto IL_14EE;
						case 125:
							goto IL_11DF;
						case 126:
							goto IL_740;
						case 127:
							goto IL_14EE;
						case 128:
							goto IL_6F4;
						case 129:
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
							goto IL_14EE;
						case 130:
							goto IL_14EE;
						case 131:
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.oMK8iyuIab2LETlLsfs((float)\u0020);
							num2 = 3;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
							{
								num2 = 42;
								continue;
							}
							continue;
						case 132:
							goto IL_1368;
						case 133:
							goto IL_D75;
						case 134:
							goto IL_14EE;
						case 135:
							goto IL_EB5;
						case 136:
							goto IL_66A;
						case 137:
							goto IL_14B2;
						case 138:
							goto IL_14EE;
						case 139:
							goto IL_14EE;
						case 140:
							goto IL_454;
						case 141:
							goto IL_14EE;
						case 142:
							goto IL_1275;
						case 143:
							goto IL_E83;
						case 144:
							goto IL_DF1;
						case 145:
							goto IL_1011;
						case 146:
							goto IL_106D;
						case 147:
							goto IL_E70;
						case 148:
							if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)15)
							{
								num2 = 112;
								continue;
							}
							goto IL_3BB;
						case 149:
							goto IL_14EE;
						case 150:
							goto IL_12BE;
						case 151:
							goto IL_7AB;
						case 152:
							goto IL_14EE;
						case 153:
							goto IL_14EE;
						case 154:
							goto IL_13A8;
						case 155:
							goto IL_9C1;
						case 156:
							goto IL_3A2;
						case 157:
							goto IL_1250;
						case 158:
							goto IL_14EE;
						case 159:
							goto IL_40C;
						case 160:
							goto IL_FB5;
						case 161:
							goto IL_9A9;
						case 162:
							goto IL_479;
						case 163:
							goto IL_3BB;
						case 164:
							goto IL_E25;
						case 165:
							goto IL_14DF;
						case 166:
							goto IL_14EE;
						case 167:
							goto IL_133D;
						case 168:
							goto IL_14EE;
						}
						goto Block_1;
						IL_3A2:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((byte)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
						num2 = 6;
						continue;
						IL_3CE:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)((char)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
						num2 = 19;
						continue;
						IL_454:
						if (!(bool)\u0020)
						{
							goto IL_F64;
						}
						num2 = 129;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 60;
							continue;
						}
						continue;
						IL_479:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((byte)((sbyte)\u0020)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
						num2 = 41;
						continue;
						IL_4E9:
						if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
						{
							num2 = 57;
							continue;
						}
						goto IL_DF1;
						IL_821:
						if (jqHLvcuZWpW1MQBVIOg2 <= (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)2)
						{
							num2 = 83;
							continue;
						}
						goto IL_4E9;
						IL_541:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((ulong)((char)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
						num2 = 56;
						continue;
						IL_5C9:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)\u0020 != 0);
						num2 = 58;
						continue;
						IL_6B6:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((short)((char)\u0020)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
						num2 = 3;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_6F4:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(\u0020 != null);
						num2 = 3;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 5;
							continue;
						}
						continue;
						IL_740:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(1L, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
						num2 = 158;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
						{
							num2 = 37;
							continue;
						}
						continue;
						IL_EB5:
						if (!(bool)\u0020)
						{
							num2 = 96;
							continue;
						}
						goto IL_740;
						IL_7AB:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((long)((ulong)((char)\u0020)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
						num2 = 50;
						continue;
						IL_833:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((byte)\u0020 > 0);
						num2 = 141;
						continue;
						IL_8B1:
						x0cbwj80qtx55Tsu8UC = null;
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_8DD:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((sbyte)((char)\u0020)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
						num2 = 114;
						continue;
						IL_97F:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)\u0020 > 0U);
						num2 = 25;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 4;
							continue;
						}
						continue;
						IL_9A9:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((uint)\u0020, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
						num2 = 134;
						continue;
						IL_A0C:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((ushort)\u0020 > 0);
						num2 = 87;
						continue;
						IL_A4C:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((long)\u0020, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
						num2 = 166;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 98;
							continue;
						}
						continue;
						IL_B01:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(0UL, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
						num2 = 127;
						continue;
						IL_1011:
						if ((bool)\u0020)
						{
							x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(1UL, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
							num2 = 138;
							continue;
						}
						goto IL_B01;
						IL_BAB:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((short)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
						num2 = 11;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 111;
							continue;
						}
						continue;
						IL_BD3:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
						num2 = 78;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 67;
							continue;
						}
						continue;
						IL_11BC:
						if (jqHLvcuZWpW1MQBVIOg2 != (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)11)
						{
							num2 = 97;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
							{
								num2 = 46;
								continue;
							}
							continue;
						}
						else
						{
							if ((bool)\u0020)
							{
								num2 = 98;
								continue;
							}
							goto IL_BD3;
						}
						IL_C09:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN((ulong)\u0020, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)8);
						num2 = 8;
						continue;
						IL_CBC:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((ushort)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
						num2 = 17;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
						{
							num2 = 20;
							continue;
						}
						continue;
						IL_D4B:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((short)\u0020 != 0);
						num2 = 64;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 45;
							continue;
						}
						continue;
						IL_DF1:
						if (!(bool)\u0020)
						{
							num2 = 142;
							continue;
						}
						goto IL_12BE;
						IL_E70:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1U, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
						num2 = 7;
						continue;
						IL_E83:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
						num2 = 117;
						continue;
						IL_EFB:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)\u0020, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
						num2 = 121;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 124;
							continue;
						}
						continue;
						IL_F64:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
						num2 = 73;
						continue;
						IL_FE7:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((sbyte)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
						num2 = 105;
						continue;
						IL_115D:
						if (!(bool)\u0020)
						{
							num2 = 16;
							continue;
						}
						goto IL_140A;
						IL_1185:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((byte)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
						num2 = 34;
						continue;
						IL_1206:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hqV8MZkqYB(\u0020);
						num2 = 89;
						continue;
						IL_123B:
						if (!(bool)\u0020)
						{
							num2 = 88;
							continue;
						}
						goto IL_12A7;
						IL_1275:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
						num2 = 61;
						continue;
						IL_12BE:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
						num2 = 130;
						continue;
						IL_12F2:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.oiOGyvuRphUunetu60N(x0cbwj80qtx55Tsu8UC, \u0020.GetElementType());
						num2 = 75;
						continue;
						IL_14EE:
						if (\u0020.IsByRef)
						{
							goto IL_12F2;
						}
						num2 = 69;
						if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 67;
							continue;
						}
						continue;
						IL_133D:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.kQJWGaucMXeMCLLKdvN(0L, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)7);
						goto IL_14EE;
						IL_D75:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((byte)((char)\u0020)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)2);
						goto IL_14EE;
						IL_3E6:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((char)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
						goto IL_14EE;
						IL_3BB:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((char)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)4);
						goto IL_14EE;
						IL_37B:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((sbyte)((byte)\u0020)), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)1);
						goto IL_14EE;
						IL_1368:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((ulong)\u0020 > 0UL);
						num2 = 85;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
						{
							num2 = 12;
							continue;
						}
						continue;
						IL_13A8:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(0U, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)6);
						num2 = 81;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
						{
							num2 = 3;
							continue;
						}
						continue;
						IL_140A:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)5);
						num2 = 113;
						continue;
						IL_146A:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((sbyte)\u0020 != 0);
						num2 = 31;
						continue;
						IL_14B2:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((ushort)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
						num2 = 21;
						continue;
						IL_1526:
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((bool)\u0020);
						num2 = 55;
					}
					IL_36D:
					if (jqHLvcuZWpW1MQBVIOg2 == (ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg)12)
					{
						x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.vILrVAuVmjGxVilaUfb((IntPtr)\u0020);
						num = 52;
						continue;
					}
					goto IL_89D;
					IL_424:
					x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F((int)((short)\u0020), (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)15);
					num = 18;
					continue;
					IL_764:
					x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(false);
					num = 139;
					continue;
					IL_12A7:
					x0cbwj80qtx55Tsu8UC = new ykD11HxHfZBYH7OcFOG.Y6ZjFnxbSGpN58JxU4F(1, (ykD11HxHfZBYH7OcFOG.DEoHSYuiJEGISeKGmfJ)3);
					num = 62;
					continue;
					Block_77:
					num = 67;
					continue;
					Block_79:
					num = 22;
				}
				Block_1:
				goto IL_1021;
				IL_40C:
				throw new InvalidCastException();
				IL_492:
				throw new InvalidCastException();
				Block_16:
				goto IL_A88;
				IL_5E3:
				throw new InvalidCastException();
				IL_66A:
				goto IL_77A;
				IL_689:
				goto IL_E5D;
				IL_6EE:
				throw new InvalidCastException();
				IL_77A:
				throw new InvalidCastException();
				IL_7E3:
				throw new InvalidCastException();
				IL_89D:
				throw new InvalidCastException();
				IL_8CE:
				goto IL_E5D;
				IL_970:
				goto IL_1513;
				IL_9C1:
				throw new InvalidCastException();
				IL_A88:
				throw new InvalidCastException();
				IL_E25:
				throw new InvalidCastException();
				IL_E5D:
				throw new InvalidCastException();
				IL_FB5:
				throw new InvalidCastException();
				IL_1021:
				throw new InvalidCastException();
				IL_106D:
				IL_11DF:
				throw new InvalidCastException();
				IL_1250:
				goto IL_40C;
				IL_132E:
				goto IL_5E3;
				IL_141D:
				return x0cbwj80qtx55Tsu8UC;
				IL_14DF:
				IL_1513:
				throw new InvalidCastException();
			}

			// Token: 0x06000D32 RID: 3378 RVA: 0x0006AE38 File Offset: 0x00069038
			private static ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC hqV8MZkqYB(object \u0020)
			{
				int num = 4;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					Type type;
					object obj;
					switch (num2)
					{
					case 0:
						goto IL_DE;
					case 1:
						x0cbwj80qtx55Tsu8UC = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.CMyUXRNjZncrYRt9eTy(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.deWhFtNv4E6pBgshES7(type, obj));
						num2 = 5;
						continue;
					case 2:
						goto IL_102;
					case 3:
						goto IL_43;
					case 4:
						if (\u0020 == null)
						{
							num2 = 3;
							continue;
						}
						if (!\u0020.GetType().IsEnum)
						{
							num2 = 4;
							if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
							{
								num2 = 6;
								continue;
							}
							continue;
						}
						break;
					case 5:
						if (x0cbwj80qtx55Tsu8UC == null)
						{
							goto IL_10A;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
						{
							num2 = 2;
							continue;
						}
						continue;
					case 6:
						goto IL_4D;
					case 7:
						break;
					default:
						goto IL_DE;
					}
					type = ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.YQyiZVNDTui3iuplRb8(\u0020.GetType());
					num2 = 0;
					if (!ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hE1MeONHgpYNFpZgUfE())
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_DE:
					obj = Convert.ChangeType(\u0020, type);
					num2 = 1;
					if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
					{
						num2 = 1;
					}
				}
				IL_43:
				IL_4D:
				goto IL_10A;
				IL_102:
				return x0cbwj80qtx55Tsu8UC as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB;
				IL_10A:
				return new ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT(\u0020);
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x0006AF70 File Offset: 0x00069170
			private static ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB F8E8G6pPjx(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB qmmmuQuSWS2kKwsrFfB;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A7;
					case 1:
						qmmmuQuSWS2kKwsrFfB = (\u0020 as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 2:
						return qmmmuQuSWS2kKwsrFfB;
					case 3:
						qmmmuQuSWS2kKwsrFfB = (\u0020.s9Cd9Og84k() as ykD11HxHfZBYH7OcFOG.QmmmuQuSWS2kKwsrFfB);
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.ExwYJUNtxncd2B0Ya6I() != null)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 4:
						break;
					default:
						goto IL_A7;
					}
					IL_37:
					if (\u0020.TB5dFM9QIv())
					{
						num2 = 3;
						continue;
					}
					break;
					IL_A7:
					if (qmmmuQuSWS2kKwsrFfB != null)
					{
						break;
					}
					goto IL_37;
				}
				return qmmmuQuSWS2kKwsrFfB;
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x0006B030 File Offset: 0x00069230
			// Note: this type is marked as 'beforefieldinit'.
			static X0cbwj80qtx55Tsu8UC()
			{
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.SuVBoSNbFpDDSKnEICN();
			}

			// Token: 0x06000D35 RID: 3381 RVA: 0x0006B040 File Offset: 0x00069240
			internal static void yCPmAONY08oC42wgpEN()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000D36 RID: 3382 RVA: 0x0006B050 File Offset: 0x00069250
			internal static void aHkm4SNsSe1wetNUBjF()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000D37 RID: 3383 RVA: 0x0006B060 File Offset: 0x00069260
			internal static bool hE1MeONHgpYNFpZgUfE()
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.vlHD7pNmKMwPVJetLFM == null;
			}

			// Token: 0x06000D38 RID: 3384 RVA: 0x0006B074 File Offset: 0x00069274
			internal static ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC ExwYJUNtxncd2B0Ya6I()
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.vlHD7pNmKMwPVJetLFM;
			}

			// Token: 0x06000D39 RID: 3385 RVA: 0x0006B084 File Offset: 0x00069284
			internal static Type NLLNhsNg4AlbMZAg8Cc(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000D3A RID: 3386 RVA: 0x0006B098 File Offset: 0x00069298
			internal static bool hCfRmSNXIpZTuZllSny(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000D3B RID: 3387 RVA: 0x0006B0B0 File Offset: 0x000692B0
			internal static RuntimeTypeHandle sqrQRKNMbyrZa0fhSgq(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000D3C RID: 3388 RVA: 0x0006B0C4 File Offset: 0x000692C4
			internal static ykD11HxHfZBYH7OcFOG.JqHLvcuZWpW1MQBVIOg JQIGBxNGrNyGmHhUiTZ(Type \u0020)
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.f7G8gtLASm(\u0020);
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x0006B0D8 File Offset: 0x000692D8
			internal static object KREKDnNBLCkkyr1Ncsy(object A_0)
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.hqV8MZkqYB(A_0);
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x0006B0EC File Offset: 0x000692EC
			internal static Type YQyiZVNDTui3iuplRb8(Type A_0)
			{
				return Enum.GetUnderlyingType(A_0);
			}

			// Token: 0x06000D3F RID: 3391 RVA: 0x0006B100 File Offset: 0x00069300
			internal static object deWhFtNv4E6pBgshES7(Type \u0020, object A_1)
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.Ldf8XpjhNW(\u0020, A_1);
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x0006B118 File Offset: 0x00069318
			internal static object CMyUXRNjZncrYRt9eTy(object A_0)
			{
				return ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC.F8E8G6pPjx(A_0);
			}

			// Token: 0x06000D41 RID: 3393 RVA: 0x0006B12C File Offset: 0x0006932C
			internal static void SuVBoSNbFpDDSKnEICN()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x0400041C RID: 1052
			internal ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk XyUUA5Idue;

			// Token: 0x0400041D RID: 1053
			private static ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC vlHD7pNmKMwPVJetLFM;
		}

		// Token: 0x0200008F RID: 143
		private class v1ACGu8BI78a29HhfJT : ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC
		{
			// Token: 0x06000D42 RID: 3394 RVA: 0x0006B13C File Offset: 0x0006933C
			public v1ACGu8BI78a29HhfJT()
			{
				ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.HsrneUnE5sd79rZJjVM();
				ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.lr5nqSncJnSZSGcSPtU();
				this..ctor(null);
				int num = 0;
				if (true)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000D43 RID: 3395 RVA: 0x0006B198 File Offset: 0x00069398
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
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
						this.tjOUlprxe0 = ((ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT)\u0020).tjOUlprxe0;
						this.J9aUUuXjxN = ((ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT)\u0020).J9aUUuXjxN;
						num2 = 1;
						if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
						{
							num2 = 0;
							continue;
						}
						continue;
					case 3:
						if (\u0020 is ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT)
						{
							num2 = 2;
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() != null)
							{
								num2 = 0;
								continue;
							}
							continue;
						}
						else
						{
							this.tjOUlprxe0 = ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.aIbTlDn52NLfguy5LEt(\u0020);
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
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
			}

			// Token: 0x06000D44 RID: 3396 RVA: 0x0006B268 File Offset: 0x00069468
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.AxwqVJ6XV5(\u0020);
			}

			// Token: 0x06000D45 RID: 3397 RVA: 0x0006B284 File Offset: 0x00069484
			public v1ACGu8BI78a29HhfJT(object \u0020)
			{
				ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.HsrneUnE5sd79rZJjVM();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor((ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)0);
				int num = 0;
				if (!true)
				{
					num = 0;
				}
				for (;;)
				{
					switch (num)
					{
					default:
						this.tjOUlprxe0 = \u0020;
						num = 1;
						if (!true)
						{
							num = 0;
						}
						break;
					case 1:
						this.J9aUUuXjxN = null;
						num = 0;
						if (!false)
						{
							num = 2;
						}
						break;
					case 2:
						return;
					}
				}
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x0006B324 File Offset: 0x00069524
			public v1ACGu8BI78a29HhfJT(object \u0020, Type \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.lr5nqSncJnSZSGcSPtU();
				base..ctor((ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)0);
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.J9aUUuXjxN = \u0020;
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					case 2:
						this.tjOUlprxe0 = \u0020;
						num = 1;
						if (!true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x0006B3B8 File Offset: 0x000695B8
			public override string ToString()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (this.tjOUlprxe0 == null)
						{
							goto IL_6A;
						}
						num2 = 0;
						if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				return this.tjOUlprxe0.ToString();
				IL_6A:
				return ((ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)5).ToString();
			}

			// Token: 0x06000D48 RID: 3400 RVA: 0x0006B438 File Offset: 0x00069638
			internal override object y9jq31urLD(Type \u0020)
			{
				if (this.tjOUlprxe0 != null)
				{
					int num;
					if (!(\u0020 != null))
					{
						num = 16;
						goto IL_0C;
					}
					goto IL_2F4;
					int num2;
					object obj;
					object obj2;
					for (;;)
					{
						IL_10:
						switch (num2)
						{
						default:
							if (!(\u0020 != null))
							{
								num2 = 9;
								continue;
							}
							break;
						case 1:
							goto IL_334;
						case 2:
							goto IL_184;
						case 3:
							obj = ((FieldInfo)obj).FieldHandle;
							num2 = 37;
							continue;
						case 4:
							break;
						case 5:
							goto IL_127;
						case 6:
							goto IL_2F4;
						case 7:
							goto IL_50A;
						case 8:
							goto IL_2D0;
						case 9:
							goto IL_39A;
						case 10:
							goto IL_228;
						case 11:
							if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.HHG9oAnxXx14kypL5M2(\u0020, null))
							{
								return obj2;
							}
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.HHG9oAnxXx14kypL5M2(obj2.GetType(), \u0020))
							{
								goto IL_334;
							}
							num2 = 3;
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() == null)
							{
								num2 = 13;
								continue;
							}
							continue;
						case 12:
							goto IL_4A1;
						case 13:
							goto IL_37B;
						case 14:
							goto IL_269;
						case 15:
							goto IL_154;
						case 16:
							goto IL_3D1;
						case 17:
							if (!(obj is MethodBase))
							{
								num2 = 33;
								continue;
							}
							obj = ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.Uxc19wn8DW1p8yUrogV((MethodBase)obj);
							num2 = 36;
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
							{
								num2 = 38;
								continue;
							}
							continue;
						case 18:
							if (obj is Type)
							{
								goto IL_5F8;
							}
							num2 = 1;
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() == null)
							{
								num2 = 14;
								continue;
							}
							continue;
						case 19:
							goto IL_1E2;
						case 20:
							goto IL_1A3;
						case 21:
							if (obj is FieldInfo)
							{
								num2 = 3;
								continue;
							}
							goto IL_3F0;
						case 22:
							goto IL_362;
						case 23:
							goto IL_5A8;
						case 24:
							goto IL_3F0;
						case 25:
							goto IL_433;
						case 26:
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.dfreb1nVfEgCeWtBM11(\u0020, ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OsPhVlnu5ea5gWDlRGb(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777512))))
							{
								num2 = 21;
								continue;
							}
							goto IL_3F0;
						case 27:
							if (obj2 == null)
							{
								return obj2;
							}
							num2 = 0;
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
							{
								num2 = 11;
								continue;
							}
							continue;
						case 28:
							goto IL_269;
						case 29:
							goto IL_5C4;
						case 30:
							\u0020 = \u0020.GetElementType();
							num2 = 40;
							if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() != null)
							{
								num2 = 7;
								continue;
							}
							continue;
						case 31:
							goto IL_442;
						case 32:
							obj2 = ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.UNQ4xYnd834P8dJ2gqK((FieldInfo)obj2);
							num2 = 25;
							continue;
						case 33:
							goto IL_358;
						case 34:
							obj2 = ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.FhtulBnqFdhQlmNejdD((ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC)this.tjOUlprxe0, \u0020);
							num2 = 27;
							continue;
						case 35:
							goto IL_5C4;
						case 36:
							goto IL_492;
						case 37:
							goto IL_36C;
						case 38:
							return obj;
						case 39:
							goto IL_2D0;
						case 40:
							goto IL_16A;
						case 41:
							if (obj == null)
							{
								return obj;
							}
							num2 = 0;
							if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
							{
								num2 = 0;
								continue;
							}
							continue;
						case 42:
							goto IL_2D0;
						}
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.HHG9oAnxXx14kypL5M2(obj.GetType(), \u0020))
						{
							num2 = 26;
							continue;
						}
						return obj;
						IL_127:
						obj2 = ((Type)obj2).TypeHandle;
						num2 = 2;
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() != null)
						{
							num2 = 1;
							continue;
						}
						continue;
						IL_4A1:
						if (obj2 is Type)
						{
							goto IL_127;
						}
						num2 = 1;
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
						{
							num2 = 8;
							continue;
						}
						continue;
						IL_5C4:
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.dfreb1nVfEgCeWtBM11(\u0020, Type.GetTypeFromHandle(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777374))))
						{
							goto IL_4A1;
						}
						num2 = 16;
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
						{
							num2 = 42;
							continue;
						}
						continue;
						IL_442:
						if (obj2 is FieldInfo)
						{
							num2 = 32;
							continue;
						}
						goto IL_5C4;
						IL_334:
						if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.dfreb1nVfEgCeWtBM11(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.tRCs1Anyf7Q0BuDENlD(16777512))))
						{
							num2 = 29;
							continue;
						}
						goto IL_442;
						IL_154:
						if (!(obj2 is MethodBase))
						{
							num2 = 22;
							continue;
						}
						goto IL_3B9;
						IL_2D0:
						if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.dfreb1nVfEgCeWtBM11(\u0020, ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OsPhVlnu5ea5gWDlRGb(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777620))))
						{
							num2 = 10;
							continue;
						}
						goto IL_154;
						IL_269:
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.dfreb1nVfEgCeWtBM11(\u0020, Type.GetTypeFromHandle(ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.tRCs1Anyf7Q0BuDENlD(16777620))))
						{
							num2 = 17;
							continue;
						}
						return obj;
						IL_3F0:
						if (!(\u0020 == ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OsPhVlnu5ea5gWDlRGb(MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(16777374))))
						{
							goto IL_269;
						}
						num2 = 18;
					}
					IL_184:
					return obj2;
					IL_1E2:
					if (!(this.J9aUUuXjxN != null))
					{
						num = 34;
						goto IL_0C;
					}
					goto IL_50A;
					IL_228:
					return obj2;
					IL_358:
					return obj;
					IL_362:
					return obj2;
					IL_36C:
					return obj;
					IL_37B:
					return obj2;
					IL_39A:
					return obj;
					IL_3B9:
					return ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.Uxc19wn8DW1p8yUrogV((MethodBase)obj2);
					IL_3D1:
					goto IL_16A;
					IL_433:
					return obj2;
					IL_492:
					return obj;
					IL_50A:
					return ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.FhtulBnqFdhQlmNejdD((ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC)this.tjOUlprxe0, this.J9aUUuXjxN);
					IL_5F8:
					obj = ((Type)obj).TypeHandle;
					num = 36;
					IL_0C:
					num2 = num;
					goto IL_10;
					IL_16A:
					if (this.tjOUlprxe0 is ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC)
					{
						num2 = 19;
						goto IL_10;
					}
					IL_1A3:
					obj = this.tjOUlprxe0;
					num2 = 41;
					goto IL_10;
					IL_2F4:
					if (\u0020.IsByRef)
					{
						num2 = 30;
						goto IL_10;
					}
					goto IL_16A;
				}
				IL_5A8:
				return null;
			}

			// Token: 0x06000D49 RID: 3401 RVA: 0x0006BA8C File Offset: 0x00069C8C
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.Usybh2noxQypscDSm4m(\u0020))
				{
					object obj = this.y9jq31urLD(null);
					object obj2 = \u0020.y9jq31urLD(null);
					return obj == obj2;
				}
				return ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.V1K0g4n33WyE7GbH9o0((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x0006BB08 File Offset: 0x00069D08
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.Usybh2noxQypscDSm4m(\u0020))
						{
							goto IL_50;
						}
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() == null)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				goto IL_75;
				IL_50:
				return ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.qqfiNrnQQBLRhrPAS5F((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
				IL_75:
				object obj = ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.FhtulBnqFdhQlmNejdD(this, null);
				object obj2 = \u0020.y9jq31urLD(null);
				return obj != obj2;
			}

			// Token: 0x06000D4B RID: 3403 RVA: 0x0006BB94 File Offset: 0x00069D94
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				int num = 1;
				int num2 = num;
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						x0cbwj80qtx55Tsu8UC = (this.tjOUlprxe0 as ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC);
						num2 = 0;
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() != null)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				if (x0cbwj80qtx55Tsu8UC == null)
				{
					return this;
				}
				return x0cbwj80qtx55Tsu8UC.s9Cd9Og84k();
			}

			// Token: 0x06000D4C RID: 3404 RVA: 0x0006BC08 File Offset: 0x00069E08
			internal override bool lPSqCCLN7S()
			{
				if (this.tjOUlprxe0 != null)
				{
					ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC x0cbwj80qtx55Tsu8UC = this.tjOUlprxe0 as ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC;
					int num = 0;
					if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.OdR3rmnPqqvBDvKx6pS() == null)
					{
						num = 1;
					}
					for (;;)
					{
						switch (num)
						{
						default:
							return true;
						case 1:
							if (x0cbwj80qtx55Tsu8UC == null)
							{
								num = 3;
								if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
								{
									num = 3;
									continue;
								}
								continue;
							}
							break;
						case 2:
							break;
						case 3:
							return true;
						case 4:
							return false;
						}
						if (ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.FhtulBnqFdhQlmNejdD(x0cbwj80qtx55Tsu8UC, null) == null)
						{
							return false;
						}
						num = 0;
						if (!ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.vyp6hqnWS0HnY1c5S5N())
						{
							num = 0;
						}
					}
					return true;
				}
				return false;
			}

			// Token: 0x06000D4D RID: 3405 RVA: 0x0006BCE8 File Offset: 0x00069EE8
			// Note: this type is marked as 'beforefieldinit'.
			static v1ACGu8BI78a29HhfJT()
			{
				ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.xCkMKtnC0JL0PTfgyyp();
			}

			// Token: 0x06000D4E RID: 3406 RVA: 0x0006BCF8 File Offset: 0x00069EF8
			internal static void HsrneUnE5sd79rZJjVM()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
			}

			// Token: 0x06000D4F RID: 3407 RVA: 0x0006BD08 File Offset: 0x00069F08
			internal static void lr5nqSncJnSZSGcSPtU()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000D50 RID: 3408 RVA: 0x0006BD18 File Offset: 0x00069F18
			internal static bool vyp6hqnWS0HnY1c5S5N()
			{
				return ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.t4gfuCNzskCvvBdiJae == null;
			}

			// Token: 0x06000D51 RID: 3409 RVA: 0x0006BD2C File Offset: 0x00069F2C
			internal static ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT OdR3rmnPqqvBDvKx6pS()
			{
				return ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT.t4gfuCNzskCvvBdiJae;
			}

			// Token: 0x06000D52 RID: 3410 RVA: 0x0006BD3C File Offset: 0x00069F3C
			internal static object aIbTlDn52NLfguy5LEt(object A_0)
			{
				return A_0.s9Cd9Og84k();
			}

			// Token: 0x06000D53 RID: 3411 RVA: 0x0006BD50 File Offset: 0x00069F50
			internal static bool HHG9oAnxXx14kypL5M2(Type A_0, Type A_1)
			{
				return A_0 != A_1;
			}

			// Token: 0x06000D54 RID: 3412 RVA: 0x0006BD68 File Offset: 0x00069F68
			internal static Type OsPhVlnu5ea5gWDlRGb(RuntimeTypeHandle A_0)
			{
				return Type.GetTypeFromHandle(A_0);
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x0006BD7C File Offset: 0x00069F7C
			internal static bool dfreb1nVfEgCeWtBM11(Type A_0, Type A_1)
			{
				return A_0 == A_1;
			}

			// Token: 0x06000D56 RID: 3414 RVA: 0x0006BD94 File Offset: 0x00069F94
			internal static RuntimeTypeHandle tRCs1Anyf7Q0BuDENlD(int token)
			{
				return MQ9uG3xi8RURJ9Fop2C.VO20CqLVtC(token);
			}

			// Token: 0x06000D57 RID: 3415 RVA: 0x0006BDA8 File Offset: 0x00069FA8
			internal static RuntimeMethodHandle Uxc19wn8DW1p8yUrogV(object A_0)
			{
				return A_0.MethodHandle;
			}

			// Token: 0x06000D58 RID: 3416 RVA: 0x0006BDBC File Offset: 0x00069FBC
			internal static object FhtulBnqFdhQlmNejdD(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x0006BDD4 File Offset: 0x00069FD4
			internal static RuntimeFieldHandle UNQ4xYnd834P8dJ2gqK(object A_0)
			{
				return A_0.FieldHandle;
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x0006BDE8 File Offset: 0x00069FE8
			internal static bool Usybh2noxQypscDSm4m(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000D5B RID: 3419 RVA: 0x0006BDFC File Offset: 0x00069FFC
			internal static bool V1K0g4n33WyE7GbH9o0(object A_0, object A_1)
			{
				return A_0.ovDdASrPUT(A_1);
			}

			// Token: 0x06000D5C RID: 3420 RVA: 0x0006BE14 File Offset: 0x0006A014
			internal static bool qqfiNrnQQBLRhrPAS5F(object A_0, object A_1)
			{
				return A_0.g5sdhSCwCu(A_1);
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x0006BE2C File Offset: 0x0006A02C
			internal static void xCkMKtnC0JL0PTfgyyp()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x0400041E RID: 1054
			public object tjOUlprxe0;

			// Token: 0x0400041F RID: 1055
			public Type J9aUUuXjxN;

			// Token: 0x04000420 RID: 1056
			internal static ykD11HxHfZBYH7OcFOG.v1ACGu8BI78a29HhfJT t4gfuCNzskCvvBdiJae;
		}

		// Token: 0x02000090 RID: 144
		private class VdlrZ08DATTq6Pq8viX : ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC
		{
			// Token: 0x06000D5E RID: 3422 RVA: 0x0006BE3C File Offset: 0x0006A03C
			public VdlrZ08DATTq6Pq8viX(string \u0020)
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.X3CKjOnhLbHKoS70NK4();
				base..ctor((ykD11HxHfZBYH7OcFOG.t6eU758n7rTZi75oJfk)6);
				int num = 1;
				if (!false)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.bHMUQRdvHC = \u0020;
						num = 0;
						if (true)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}

			// Token: 0x06000D5F RID: 3423 RVA: 0x0006BEBC File Offset: 0x0006A0BC
			internal override void AxwqVJ6XV5(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.bHMUQRdvHC = ((ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX)\u0020).bHMUQRdvHC;
			}

			// Token: 0x06000D60 RID: 3424 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
			internal override void qEGqyetc79(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.tuDgoZnS95yaLLg1tn1(this, \u0020);
			}

			// Token: 0x06000D61 RID: 3425 RVA: 0x0006BEFC File Offset: 0x0006A0FC
			public override string ToString()
			{
				if (this.bHMUQRdvHC == null)
				{
					goto IL_8F;
				}
				char c = '*';
				int num = 1;
				if (ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.d9VlK5nAvwkZ48Fb531() == null)
				{
					num = 2;
				}
				IL_10:
				ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4 ngYCBhqPZ7YsxPQyJh;
				switch (num)
				{
				case 1:
					return ngYCBhqPZ7YsxPQyJh.ToString();
				case 2:
				{
					object obj = c.ToString();
					object obj2 = this.bHMUQRdvHC;
					c = '*';
					return ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.SOg6r6nIDsq9hcOVysm(obj, obj2, c.ToString());
				}
				}
				IL_8F:
				ngYCBhqPZ7YsxPQyJh = (ykD11HxHfZBYH7OcFOG.ngYCBhqPZ7YsxPQyJh4)5;
				num = 1;
				if (ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.d9VlK5nAvwkZ48Fb531() != null)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}

			// Token: 0x06000D62 RID: 3426 RVA: 0x0006BFC4 File Offset: 0x0006A1C4
			internal override bool lPSqCCLN7S()
			{
				return this.bHMUQRdvHC != null;
			}

			// Token: 0x06000D63 RID: 3427 RVA: 0x0006BFD8 File Offset: 0x0006A1D8
			internal override object y9jq31urLD(Type \u0020)
			{
				return this.bHMUQRdvHC;
			}

			// Token: 0x06000D64 RID: 3428 RVA: 0x0006BFE8 File Offset: 0x0006A1E8
			internal override bool ovDdASrPUT(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.mTlLB6ni6s7AkO8X4wX(\u0020))
				{
					return ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.nXWjftnZEvgrxqwVifL((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
				}
				object obj = this.bHMUQRdvHC;
				object obj2 = \u0020.y9jq31urLD(null);
				return obj == obj2;
			}

			// Token: 0x06000D65 RID: 3429 RVA: 0x0006C034 File Offset: 0x0006A234
			internal override bool g5sdhSCwCu(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				if (ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.mTlLB6ni6s7AkO8X4wX(\u0020))
				{
					return ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.zt5S48nUMnATbbOreWD((ykD11HxHfZBYH7OcFOG.sK9Zdfu498A1KFPnIfR)\u0020, this);
				}
				object obj = this.bHMUQRdvHC;
				object obj2 = ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.CqHZA1n1w6xnmn3xBdY(\u0020, null);
				return obj != obj2;
			}

			// Token: 0x06000D66 RID: 3430 RVA: 0x0006C07C File Offset: 0x0006A27C
			internal override ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC s9Cd9Og84k()
			{
				return this;
			}

			// Token: 0x06000D67 RID: 3431 RVA: 0x0006C088 File Offset: 0x0006A288
			// Note: this type is marked as 'beforefieldinit'.
			static VdlrZ08DATTq6Pq8viX()
			{
				ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.ileyoGnpY7KhDdcCZZ4();
			}

			// Token: 0x06000D68 RID: 3432 RVA: 0x0006C098 File Offset: 0x0006A298
			internal static void X3CKjOnhLbHKoS70NK4()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000D69 RID: 3433 RVA: 0x0006C0A8 File Offset: 0x0006A2A8
			internal static bool G7tVlcnwp21lmSVpij6()
			{
				return ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.FCeAMFn95lUulpuvlgS == null;
			}

			// Token: 0x06000D6A RID: 3434 RVA: 0x0006C0BC File Offset: 0x0006A2BC
			internal static ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX d9VlK5nAvwkZ48Fb531()
			{
				return ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX.FCeAMFn95lUulpuvlgS;
			}

			// Token: 0x06000D6B RID: 3435 RVA: 0x0006C0CC File Offset: 0x0006A2CC
			internal static void tuDgoZnS95yaLLg1tn1(object A_0, object A_1)
			{
				A_0.AxwqVJ6XV5(A_1);
			}

			// Token: 0x06000D6C RID: 3436 RVA: 0x0006C0E4 File Offset: 0x0006A2E4
			internal static object SOg6r6nIDsq9hcOVysm(object A_0, object A_1, object A_2)
			{
				return A_0 + A_1 + A_2;
			}

			// Token: 0x06000D6D RID: 3437 RVA: 0x0006C100 File Offset: 0x0006A300
			internal static bool mTlLB6ni6s7AkO8X4wX(object A_0)
			{
				return A_0.TB5dFM9QIv();
			}

			// Token: 0x06000D6E RID: 3438 RVA: 0x0006C114 File Offset: 0x0006A314
			internal static bool nXWjftnZEvgrxqwVifL(object A_0, object A_1)
			{
				return A_0.ovDdASrPUT(A_1);
			}

			// Token: 0x06000D6F RID: 3439 RVA: 0x0006C12C File Offset: 0x0006A32C
			internal static bool zt5S48nUMnATbbOreWD(object A_0, object A_1)
			{
				return A_0.g5sdhSCwCu(A_1);
			}

			// Token: 0x06000D70 RID: 3440 RVA: 0x0006C144 File Offset: 0x0006A344
			internal static object CqHZA1n1w6xnmn3xBdY(object A_0, Type \u0020)
			{
				return A_0.y9jq31urLD(\u0020);
			}

			// Token: 0x06000D71 RID: 3441 RVA: 0x0006C15C File Offset: 0x0006A35C
			internal static void ileyoGnpY7KhDdcCZZ4()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x04000421 RID: 1057
			public string bHMUQRdvHC;

			// Token: 0x04000422 RID: 1058
			internal static ykD11HxHfZBYH7OcFOG.VdlrZ08DATTq6Pq8viX FCeAMFn95lUulpuvlgS;
		}

		// Token: 0x02000091 RID: 145
		internal class Q7cORx8vedKLjQLTkjn
		{
			// Token: 0x06000D72 RID: 3442 RVA: 0x0006C16C File Offset: 0x0006A36C
			public int o7JUtBOnjt()
			{
				return ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn.kTxaoKnFnJP9SZvsl6V(this.rJBUu4RUeL);
			}

			// Token: 0x06000D73 RID: 3443 RVA: 0x0006C180 File Offset: 0x0006A380
			public void bv68jSYg9n()
			{
				this.rJBUu4RUeL.Clear();
			}

			// Token: 0x06000D74 RID: 3444 RVA: 0x0006C1A0 File Offset: 0x0006A3A0
			public void CBp8byx5jM(ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC \u0020)
			{
				this.rJBUu4RUeL.Add(\u0020);
			}

			// Token: 0x06000D75 RID: 3445 RVA: 0x0006C1BC File Offset: 0x0006A3BC
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC xOa8zYuH0k()
			{
				return this.rJBUu4RUeL[this.rJBUu4RUeL.Count - 1];
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x0006C1E0 File Offset: 0x0006A3E0
			public ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC cL3qW1trrh()
			{
				ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC result = this.xOa8zYuH0k();
				if (ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn.kTxaoKnFnJP9SZvsl6V(this.rJBUu4RUeL) != 0)
				{
					this.rJBUu4RUeL.RemoveAt(ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn.kTxaoKnFnJP9SZvsl6V(this.rJBUu4RUeL) - 1);
				}
				return result;
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x0006C218 File Offset: 0x0006A418
			public Q7cORx8vedKLjQLTkjn()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn.yikXeqnTwZm844RiD5W();
				this.rJBUu4RUeL = new List<ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC>();
				base..ctor();
				int num = 0;
				if (!true)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x0006C284 File Offset: 0x0006A484
			// Note: this type is marked as 'beforefieldinit'.
			static Q7cORx8vedKLjQLTkjn()
			{
				ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn.st4vd1nRGWJWEAowdkb();
			}

			// Token: 0x06000D79 RID: 3449 RVA: 0x0006C294 File Offset: 0x0006A494
			internal static int kTxaoKnFnJP9SZvsl6V(object A_0)
			{
				return A_0.Count;
			}

			// Token: 0x06000D7A RID: 3450 RVA: 0x0006C2A8 File Offset: 0x0006A4A8
			internal static bool UJN8w9nOllWt5Dr0h07()
			{
				return ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn.PbSU8en4oLj8RQVJmqB == null;
			}

			// Token: 0x06000D7B RID: 3451 RVA: 0x0006C2BC File Offset: 0x0006A4BC
			internal static ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn RIW9YonfbUO7c6ATLlg()
			{
				return ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn.PbSU8en4oLj8RQVJmqB;
			}

			// Token: 0x06000D7C RID: 3452 RVA: 0x0006C2CC File Offset: 0x0006A4CC
			internal static void yikXeqnTwZm844RiD5W()
			{
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
			}

			// Token: 0x06000D7D RID: 3453 RVA: 0x0006C2DC File Offset: 0x0006A4DC
			internal static void st4vd1nRGWJWEAowdkb()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}

			// Token: 0x04000423 RID: 1059
			private List<ykD11HxHfZBYH7OcFOG.X0cbwj80qtx55Tsu8UC> rJBUu4RUeL;

			// Token: 0x04000424 RID: 1060
			internal static ykD11HxHfZBYH7OcFOG.Q7cORx8vedKLjQLTkjn PbSU8en4oLj8RQVJmqB;
		}

		// Token: 0x02000092 RID: 146
		internal enum ngYCBhqPZ7YsxPQyJh4
		{

		}

		// Token: 0x02000093 RID: 147
		[CompilerGenerated]
		[Serializable]
		private sealed class GUFtio1WcfP82d7tycE<T>
		{
			// Token: 0x06000D7E RID: 3454 RVA: 0x0006C2EC File Offset: 0x0006A4EC
			// Note: this type is marked as 'beforefieldinit'.
			static GUFtio1WcfP82d7tycE()
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
						num2 = 0;
						if (true)
						{
							num2 = 2;
						}
						break;
					case 1:
						vua32v5yjQhjRjK4YIO.aep5UvAyyY();
						num2 = 0;
						if (true)
						{
							num2 = 0;
						}
						break;
					case 2:
						PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
						num2 = 3;
						if (!true)
						{
							num2 = 2;
						}
						break;
					case 3:
						goto IL_69;
					}
				}
				IL_69:
				ykD11HxHfZBYH7OcFOG.GUFtio1WcfP82d7tycE<T>.<>9 = new ykD11HxHfZBYH7OcFOG.GUFtio1WcfP82d7tycE<T>();
			}

			// Token: 0x06000D7F RID: 3455 RVA: 0x0006C38C File Offset: 0x0006A58C
			public GUFtio1WcfP82d7tycE()
			{
				vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
				PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
				base..ctor();
				int num = 0;
				if (!false)
				{
					num = 0;
				}
				switch (num)
				{
				default:
					return;
				}
			}

			// Token: 0x06000D80 RID: 3456 RVA: 0x0006C3E8 File Offset: 0x0006A5E8
			internal int uaRU74NwKL(ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP x, ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP y)
			{
				return x.aE6ioYbwF8.oe3ivl4Hb5.CompareTo(y.aE6ioYbwF8.oe3ivl4Hb5);
			}

			// Token: 0x06000D81 RID: 3457 RVA: 0x0006C40C File Offset: 0x0006A60C
			internal static bool d3PJGYnevfPp0Lg5wjj()
			{
				return ykD11HxHfZBYH7OcFOG.GUFtio1WcfP82d7tycE<T>.zN4sbinKPelfOiZXqrk == null;
			}

			// Token: 0x06000D82 RID: 3458 RVA: 0x0006C420 File Offset: 0x0006A620
			internal static object x3Ojc4nk3ynlSyUQYIy()
			{
				return ykD11HxHfZBYH7OcFOG.GUFtio1WcfP82d7tycE<T>.zN4sbinKPelfOiZXqrk;
			}

			// Token: 0x04000426 RID: 1062
			public static readonly ykD11HxHfZBYH7OcFOG.GUFtio1WcfP82d7tycE<T> <>9;

			// Token: 0x04000427 RID: 1063
			public static Comparison<ykD11HxHfZBYH7OcFOG.O7BGFwuaTreTeXAneXP> <>9__45_0;

			// Token: 0x04000428 RID: 1064
			internal static object zN4sbinKPelfOiZXqrk;
		}
	}
}
