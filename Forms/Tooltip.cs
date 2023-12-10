using System;
using System.Drawing;

namespace Jack.Forms
{
	// Token: 0x0200006C RID: 108
	public class Tooltip
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00688B50 File Offset: 0x00686D50
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00688B64 File Offset: 0x00686D64
		public string Title { get; set; } = "";

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00688B78 File Offset: 0x00686D78
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00688B8C File Offset: 0x00686D8C
		public string Text { get; set; } = "";

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00688BA0 File Offset: 0x00686DA0
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x00688BB4 File Offset: 0x00686DB4
		public string FormName { get; set; } = "";

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x00688BC8 File Offset: 0x00686DC8
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x00688BDC File Offset: 0x00686DDC
		public string MarkControlName { get; set; } = "";

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x00688BF0 File Offset: 0x00686DF0
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x00688C04 File Offset: 0x00686E04
		public string TabControl { get; set; } = "";

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x00688C18 File Offset: 0x00686E18
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00688C2C File Offset: 0x00686E2C
		public string SelectTabPage { get; set; } = "";

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00688C40 File Offset: 0x00686E40
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00688C54 File Offset: 0x00686E54
		public bool PinTooltipToControl { get; set; }

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00688C68 File Offset: 0x00686E68
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00688C7C File Offset: 0x00686E7C
		public Color DefaultColor { get; set; }
	}
}
