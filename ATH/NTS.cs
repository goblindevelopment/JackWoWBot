using System;

namespace Jack.ATH
{
	// Token: 0x02000139 RID: 313
	public class NTS
	{
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00732940 File Offset: 0x00730B40
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00732954 File Offset: 0x00730B54
		public string Type { get; set; } = "";

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00732968 File Offset: 0x00730B68
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0073297C File Offset: 0x00730B7C
		public string Message { get; set; } = "";

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00732990 File Offset: 0x00730B90
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x007329A4 File Offset: 0x00730BA4
		public long DateTimeCreate { get; set; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x007329B8 File Offset: 0x00730BB8
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x007329CC File Offset: 0x00730BCC
		public bool Sent { get; set; }
	}
}
