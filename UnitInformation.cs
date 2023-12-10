using System;
using System.Collections.Generic;
using MyU9Ep58ZH3s5ThDFJQ;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x02000041 RID: 65
	public class UnitInformation
	{
		// Token: 0x06000588 RID: 1416 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
		public UnitInformation()
		{
			UnitInformation.wOJOHcOdnmmiZ0S8yY2();
			UnitInformation.AUtbr9Oo6IAhaIYaN1i();
			this.Buffs = new Dictionary<int, BuffsDebuffs>();
			this.Debuffs = new Dictionary<int, BuffsDebuffs>();
			base..ctor();
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_d808aff233c746968dbfcb5437cf67e9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0002D930 File Offset: 0x0002BB30
		// Note: this type is marked as 'beforefieldinit'.
		static UnitInformation()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0002D940 File Offset: 0x0002BB40
		internal static void wOJOHcOdnmmiZ0S8yY2()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0002D950 File Offset: 0x0002BB50
		internal static void AUtbr9Oo6IAhaIYaN1i()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0002D960 File Offset: 0x0002BB60
		internal static bool J3WGtbO8dwtYWdbBar6()
		{
			return UnitInformation.PNgfsrOynBMaAi2bMLU == null;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0002D974 File Offset: 0x0002BB74
		internal static UnitInformation hqIXLuOqMKVPBkmOYlf()
		{
			return UnitInformation.PNgfsrOynBMaAi2bMLU;
		}

		// Token: 0x0400026D RID: 621
		public int CurrentHP;

		// Token: 0x0400026E RID: 622
		public int MaxHP;

		// Token: 0x0400026F RID: 623
		public int CurrentPower;

		// Token: 0x04000270 RID: 624
		public int MaxPower;

		// Token: 0x04000271 RID: 625
		public int HPPercent;

		// Token: 0x04000272 RID: 626
		public int PowerPercent;

		// Token: 0x04000273 RID: 627
		public int PowerTypeIndex;

		// Token: 0x04000274 RID: 628
		public bool PlayerCanAttack;

		// Token: 0x04000275 RID: 629
		public bool IsFriend;

		// Token: 0x04000276 RID: 630
		public bool IsInCombat;

		// Token: 0x04000277 RID: 631
		public bool IsPVP;

		// Token: 0x04000278 RID: 632
		public bool IsDead;

		// Token: 0x04000279 RID: 633
		public bool IsTargetingPlayer;

		// Token: 0x0400027A RID: 634
		public int NPCID;

		// Token: 0x0400027B RID: 635
		public int CurrentCastID;

		// Token: 0x0400027C RID: 636
		public int CurrentCastElapsedDuration;

		// Token: 0x0400027D RID: 637
		public int CurrentCastTimeRemaining;

		// Token: 0x0400027E RID: 638
		public int CurrentCastPercent;

		// Token: 0x0400027F RID: 639
		public bool CurrentCastInterruptible;

		// Token: 0x04000280 RID: 640
		public bool CurrentCastIsChannelling;

		// Token: 0x04000281 RID: 641
		public int UnitRange;

		// Token: 0x04000282 RID: 642
		public int Level;

		// Token: 0x04000283 RID: 643
		public bool IsAutoAttacking;

		// Token: 0x04000284 RID: 644
		public bool UnitIsPlayer;

		// Token: 0x04000285 RID: 645
		public bool UnitIsTarget;

		// Token: 0x04000286 RID: 646
		public bool UnitIsFocus;

		// Token: 0x04000287 RID: 647
		public bool UnitIsMouseover;

		// Token: 0x04000288 RID: 648
		public int RaidGroupNumber;

		// Token: 0x04000289 RID: 649
		public bool IsMainTank;

		// Token: 0x0400028A RID: 650
		public string PlayerGUID;

		// Token: 0x0400028B RID: 651
		public int PlayerTimeToDie;

		// Token: 0x0400028C RID: 652
		public int PlayerClass;

		// Token: 0x0400028D RID: 653
		public Dictionary<int, BuffsDebuffs> Buffs;

		// Token: 0x0400028E RID: 654
		public Dictionary<int, BuffsDebuffs> Debuffs;

		// Token: 0x0400028F RID: 655
		internal static UnitInformation PNgfsrOynBMaAi2bMLU;
	}
}
