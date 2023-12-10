using System;
using System.Collections.Generic;

namespace Jack.ATH
{
	// Token: 0x02000138 RID: 312
	public class PFLS
	{
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x00732688 File Offset: 0x00730888
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x0073269C File Offset: 0x0073089C
		public int ID { get; set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x007326B0 File Offset: 0x007308B0
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x007326C4 File Offset: 0x007308C4
		public int ParentProfileID { get; set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x007326D8 File Offset: 0x007308D8
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x007326EC File Offset: 0x007308EC
		public List<int> ConnectedProfiles { get; set; } = new List<int>();

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x00732700 File Offset: 0x00730900
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x00732714 File Offset: 0x00730914
		public string DisplayName { get; set; } = "";

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x00732728 File Offset: 0x00730928
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x0073273C File Offset: 0x0073093C
		public string FileName { get; set; } = "";

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00732750 File Offset: 0x00730950
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00732764 File Offset: 0x00730964
		public string Profile { get; set; } = "";

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00732778 File Offset: 0x00730978
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0073278C File Offset: 0x0073098C
		public bool IsClickable { get; set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x007327A0 File Offset: 0x007309A0
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x007327B4 File Offset: 0x007309B4
		public bool IsBundle { get; set; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x007327C8 File Offset: 0x007309C8
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x007327DC File Offset: 0x007309DC
		public bool IsConnected { get; set; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x007327F0 File Offset: 0x007309F0
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x00732804 File Offset: 0x00730A04
		public bool HasRequirements { get; set; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00732818 File Offset: 0x00730A18
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0073282C File Offset: 0x00730A2C
		public int RequiredLevel { get; set; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00732840 File Offset: 0x00730A40
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x00732854 File Offset: 0x00730A54
		public int RequiredSkill { get; set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00732868 File Offset: 0x00730A68
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0073287C File Offset: 0x00730A7C
		public string VendorStoreName { get; set; } = "";

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00732890 File Offset: 0x00730A90
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x007328A4 File Offset: 0x00730AA4
		public string VendorDiscordUsername { get; set; } = "";

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x007328B8 File Offset: 0x00730AB8
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x007328CC File Offset: 0x00730ACC
		public string VendorEmail { get; set; } = "";
	}
}
