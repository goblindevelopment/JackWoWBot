using System;
using System.Numerics;

namespace Jack.Models
{
	// Token: 0x02000032 RID: 50
	public class FromList
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x00671EB0 File Offset: 0x006700B0
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00671EC4 File Offset: 0x006700C4
		public string Name { get; set; } = "";

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00671ED8 File Offset: 0x006700D8
		// (set) Token: 0x060003DA RID: 986 RVA: 0x00671EEC File Offset: 0x006700EC
		public int Level { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00671F00 File Offset: 0x00670100
		// (set) Token: 0x060003DC RID: 988 RVA: 0x00671F14 File Offset: 0x00670114
		public string LocationName { get; set; } = "";

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00671F28 File Offset: 0x00670128
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00671F3C File Offset: 0x0067013C
		public int DisplayID { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00671F50 File Offset: 0x00670150
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00671F64 File Offset: 0x00670164
		public int ZoneID { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00671F78 File Offset: 0x00670178
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00671F8C File Offset: 0x0067018C
		public int MeshMapID { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00671FA0 File Offset: 0x006701A0
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00671FB4 File Offset: 0x006701B4
		public string Faction { get; set; } = "";

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00671FC8 File Offset: 0x006701C8
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x00671FDC File Offset: 0x006701DC
		public string Skills { get; set; } = "";

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00671FF0 File Offset: 0x006701F0
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00672004 File Offset: 0x00670204
		public Vector3 Position { get; set; }
	}
}
