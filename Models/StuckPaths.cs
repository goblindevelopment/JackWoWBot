using System;
using System.Collections.Generic;
using System.Numerics;

namespace Jack.Models
{
	// Token: 0x02000045 RID: 69
	public class StuckPaths
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x006799D8 File Offset: 0x00677BD8
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x006799EC File Offset: 0x00677BEC
		public string Type { get; set; } = "";

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00679A00 File Offset: 0x00677C00
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00679A14 File Offset: 0x00677C14
		public string Name { get; set; } = "";

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00679A28 File Offset: 0x00677C28
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00679A3C File Offset: 0x00677C3C
		public int ZoneID { get; set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00679A50 File Offset: 0x00677C50
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00679A64 File Offset: 0x00677C64
		public string ZoneName { get; set; } = "";

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00679A78 File Offset: 0x00677C78
		// (set) Token: 0x06000681 RID: 1665 RVA: 0x00679A8C File Offset: 0x00677C8C
		public Vector3 Location { get; set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00679AA0 File Offset: 0x00677CA0
		// (set) Token: 0x06000683 RID: 1667 RVA: 0x00679AB4 File Offset: 0x00677CB4
		public List<Vector3> Waypoints { get; set; } = new List<Vector3>();

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00679AC8 File Offset: 0x00677CC8
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00679ADC File Offset: 0x00677CDC
		public double Angle { get; set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00679AF0 File Offset: 0x00677CF0
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00679B04 File Offset: 0x00677D04
		public int Radius { get; set; }

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00679B18 File Offset: 0x00677D18
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00679B2C File Offset: 0x00677D2C
		public int Rotation { get; set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00679B40 File Offset: 0x00677D40
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00679B54 File Offset: 0x00677D54
		public int Division { get; set; } = 2;
	}
}
