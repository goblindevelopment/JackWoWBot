using System;

namespace Jack.Models
{
	// Token: 0x0200003A RID: 58
	public class RotationSettings
	{
		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x0067866C File Offset: 0x0067686C
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00678680 File Offset: 0x00676880
		public string Class { get; set; } = "";

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00678694 File Offset: 0x00676894
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x006786A8 File Offset: 0x006768A8
		public string ClassType { get; set; } = "";

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x006786BC File Offset: 0x006768BC
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x006786D0 File Offset: 0x006768D0
		public int PullDistance { get; set; } = 5;

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x006786E4 File Offset: 0x006768E4
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x006786F8 File Offset: 0x006768F8
		public string FindSpells { get; set; } = "By ID";

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0067870C File Offset: 0x0067690C
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00678720 File Offset: 0x00676920
		public bool UseGSE { get; set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00678734 File Offset: 0x00676934
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00678748 File Offset: 0x00676948
		public int GSEClickDelayInMS { get; set; } = 1600;

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0067875C File Offset: 0x0067695C
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00678770 File Offset: 0x00676970
		public bool PetCall { get; set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00678784 File Offset: 0x00676984
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00678798 File Offset: 0x00676998
		public string PetCallSpellName { get; set; } = "";

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x006787AC File Offset: 0x006769AC
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x006787C0 File Offset: 0x006769C0
		public int PetCallSpellID { get; set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x006787D4 File Offset: 0x006769D4
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x006787E8 File Offset: 0x006769E8
		public bool PetRevive { get; set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x006787FC File Offset: 0x006769FC
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x00678810 File Offset: 0x00676A10
		public string PetReviveSpellName { get; set; } = "";

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00678824 File Offset: 0x00676A24
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00678838 File Offset: 0x00676A38
		public int PetReviveSpellID { get; set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0067884C File Offset: 0x00676A4C
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00678860 File Offset: 0x00676A60
		public bool PetFeed { get; set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00678874 File Offset: 0x00676A74
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00678888 File Offset: 0x00676A88
		public int PetFeedMinutes { get; set; } = 30;

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0067889C File Offset: 0x00676A9C
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x006788B0 File Offset: 0x00676AB0
		public int PetFeedMinutesInMS { get; set; } = 1800000;

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x006788C4 File Offset: 0x00676AC4
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x006788D8 File Offset: 0x00676AD8
		public bool PetCombatStart { get; set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x006788EC File Offset: 0x00676AEC
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x00678900 File Offset: 0x00676B00
		public int PetCombatWait { get; set; } = 3;

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00678914 File Offset: 0x00676B14
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x00678928 File Offset: 0x00676B28
		public int PetCombatWaitInMS { get; set; } = 3000;

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0067893C File Offset: 0x00676B3C
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x00678950 File Offset: 0x00676B50
		public bool PetCombatParallel { get; set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00678964 File Offset: 0x00676B64
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x00678978 File Offset: 0x00676B78
		public bool PetCombatReact { get; set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0067898C File Offset: 0x00676B8C
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x006789A0 File Offset: 0x00676BA0
		public string PetCombatReactSpellName { get; set; } = "";

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x006789B4 File Offset: 0x00676BB4
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x006789C8 File Offset: 0x00676BC8
		public int PetCombatReactSpellID { get; set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x006789DC File Offset: 0x00676BDC
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x006789F0 File Offset: 0x00676BF0
		public bool PetCombatReactStepBack { get; set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00678A04 File Offset: 0x00676C04
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00678A18 File Offset: 0x00676C18
		public bool EnchantMainHand { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00678A2C File Offset: 0x00676C2C
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00678A40 File Offset: 0x00676C40
		public bool EnchantOffHand { get; set; }
	}
}
