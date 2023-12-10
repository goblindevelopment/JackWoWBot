using System;

namespace Jack.ATH
{
	// Token: 0x0200013A RID: 314
	public class MSG
	{
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00732A0C File Offset: 0x00730C0C
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00732A20 File Offset: 0x00730C20
		public string Type { get; set; } = "";

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00732A34 File Offset: 0x00730C34
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x00732A48 File Offset: 0x00730C48
		public string Title { get; set; } = "";

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x00732A5C File Offset: 0x00730C5C
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x00732A70 File Offset: 0x00730C70
		public string Message { get; set; } = "";

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00732A84 File Offset: 0x00730C84
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x00732A98 File Offset: 0x00730C98
		public string DateOrigin { get; set; } = "";

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00732AAC File Offset: 0x00730CAC
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x00732AC0 File Offset: 0x00730CC0
		public string DateExpiration { get; set; } = "";
	}
}
