using System;
using System.Collections.Generic;
using System.Linq;
using MyU9Ep58ZH3s5ThDFJQ;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x02000038 RID: 56
	public static class PowerType
	{
		// Token: 0x0600054D RID: 1357 RVA: 0x0002D0F4 File Offset: 0x0002B2F4
		public static string PowerIndexToName(int powerIndex)
		{
			if (!PowerType.PowerIndexMap.ContainsKey(powerIndex))
			{
				return "";
			}
			return PowerType.PowerIndexMap[powerIndex];
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0002D164 File Offset: 0x0002B364
		public static int PowerNameToIndex(string powerName)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_75;
				}
				CS$<>8__locals1.powerName = powerName2;
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
				{
					num2 = 1;
				}
			}
			IL_75:
			return PowerType.PowerIndexMap.Where(new Func<KeyValuePair<int, string>, bool>(CS$<>8__locals1.gLKcDMyIS6)).Select(new Func<KeyValuePair<int, string>, int>(PowerType.<>c.<>9.JdjcvneL24)).FirstOrDefault<int>();
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0002D230 File Offset: 0x0002B430
		// Note: this type is marked as 'beforefieldinit'.
		static PowerType()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			PowerType.KZhUnU4ks1GYqOsnlVc();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 != 0)
			{
				num = 0;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					PowerType.PowerIndexMap = new Dictionary<int, string>
					{
						{
							0,
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(268802365 >> 1 ^ 134384490)
						},
						{
							1,
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(850579974 + 1765464631 ^ -1678908355)
						},
						{
							2,
							PowerType.GMbIRM47BVBBmaR2XpQ(579026892 ^ 579041216)
						},
						{
							3,
							PowerType.GMbIRM47BVBBmaR2XpQ(-764151834 ^ -764166148)
						},
						{
							6,
							PowerType.GMbIRM47BVBBmaR2XpQ(~603785892 ^ -603800207)
						},
						{
							7,
							PowerType.GMbIRM47BVBBmaR2XpQ(790722942 ^ 790704444)
						},
						{
							8,
							PowerType.GMbIRM47BVBBmaR2XpQ(-33448599 >> 2 ^ -8376576)
						},
						{
							9,
							PowerType.GMbIRM47BVBBmaR2XpQ(--1797548854 ^ 1797530436)
						},
						{
							11,
							PowerType.GMbIRM47BVBBmaR2XpQ(1681481889 ^ 1681467433)
						},
						{
							12,
							PowerType.GMbIRM47BVBBmaR2XpQ(145144672 << 4 ^ -1972633954)
						},
						{
							13,
							PowerType.GMbIRM47BVBBmaR2XpQ(1691472209 >> 1 ^ 845717504)
						},
						{
							16,
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-764151834 ^ -764166310)
						},
						{
							17,
							vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-160910942 << 4 ^ 1720406778)
						},
						{
							18,
							PowerType.GMbIRM47BVBBmaR2XpQ(1810931007 ^ 1810945497)
						}
					};
					num = 2;
					continue;
				case 2:
					return;
				}
				PowerType.Y6DCHe4rg74klACgMsm();
				num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 != 0)
				{
					num = 0;
				}
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0002D430 File Offset: 0x0002B630
		internal static bool wQrwbf4KXWDY3tN6MZI()
		{
			return PowerType.XL3nqV4aRJRrM6bkmGo == null;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0002D444 File Offset: 0x0002B644
		internal static PowerType GxnMMQ4eNqLdBrVyWiQ()
		{
			return PowerType.XL3nqV4aRJRrM6bkmGo;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0002D454 File Offset: 0x0002B654
		internal static void KZhUnU4ks1GYqOsnlVc()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0002D464 File Offset: 0x0002B664
		internal static void Y6DCHe4rg74klACgMsm()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0002D474 File Offset: 0x0002B674
		internal static object GMbIRM47BVBBmaR2XpQ(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x04000233 RID: 563
		public const string None = "None";

		// Token: 0x04000234 RID: 564
		public const string Mana = "Mana";

		// Token: 0x04000235 RID: 565
		public const string Rage = "Rage";

		// Token: 0x04000236 RID: 566
		public const string Focus = "Focus";

		// Token: 0x04000237 RID: 567
		public const string Energy = "Energy";

		// Token: 0x04000238 RID: 568
		public const string RunicPower = "RunicPower";

		// Token: 0x04000239 RID: 569
		public const string SoulShards = "SoulShards";

		// Token: 0x0400023A RID: 570
		public const string LunarPower = "LunarPower";

		// Token: 0x0400023B RID: 571
		public const string HolyPower = "HolyPower";

		// Token: 0x0400023C RID: 572
		public const string Maelstrom = "Maelstrom";

		// Token: 0x0400023D RID: 573
		public const string Chi = "Chi";

		// Token: 0x0400023E RID: 574
		public const string Insanity = "Insanity";

		// Token: 0x0400023F RID: 575
		public const string ArcaneCharges = "ArcaneCharges";

		// Token: 0x04000240 RID: 576
		public const string Fury = "Fury";

		// Token: 0x04000241 RID: 577
		public const string Pain = "Pain";

		// Token: 0x04000242 RID: 578
		private static readonly Dictionary<int, string> PowerIndexMap;

		// Token: 0x04000243 RID: 579
		private static PowerType XL3nqV4aRJRrM6bkmGo;
	}
}
