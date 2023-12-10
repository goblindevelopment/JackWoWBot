using System;
using System.Collections.Generic;
using System.Drawing;

namespace Jack.Forms.Store
{
	// Token: 0x020000BA RID: 186
	public class StoreProfiles
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00701F58 File Offset: 0x00700158
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00701F6C File Offset: 0x0070016C
		public int ID { get; set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00701F80 File Offset: 0x00700180
		// (set) Token: 0x060013C6 RID: 5062 RVA: 0x00701F94 File Offset: 0x00700194
		public string Product { get; set; } = "";

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00701FA8 File Offset: 0x007001A8
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x00701FBC File Offset: 0x007001BC
		public string DisplayName { get; set; } = "";

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00701FD0 File Offset: 0x007001D0
		// (set) Token: 0x060013CA RID: 5066 RVA: 0x00701FE4 File Offset: 0x007001E4
		public string ProfileType { get; set; } = "";

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x00701FF8 File Offset: 0x007001F8
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x0070200C File Offset: 0x0070020C
		public string ProfileSubType { get; set; } = "";

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x00702020 File Offset: 0x00700220
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00702034 File Offset: 0x00700234
		public bool Classic { get; set; } = true;

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060013CF RID: 5071 RVA: 0x00702048 File Offset: 0x00700248
		// (set) Token: 0x060013D0 RID: 5072 RVA: 0x0070205C File Offset: 0x0070025C
		public bool ClassicEra { get; set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x00702070 File Offset: 0x00700270
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x00702084 File Offset: 0x00700284
		public bool Retail { get; set; }

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00702098 File Offset: 0x00700298
		// (set) Token: 0x060013D4 RID: 5076 RVA: 0x007020AC File Offset: 0x007002AC
		public string Faction { get; set; } = "";

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x007020C0 File Offset: 0x007002C0
		// (set) Token: 0x060013D6 RID: 5078 RVA: 0x007020D4 File Offset: 0x007002D4
		public string Class { get; set; } = "";

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x007020E8 File Offset: 0x007002E8
		// (set) Token: 0x060013D8 RID: 5080 RVA: 0x007020FC File Offset: 0x007002FC
		public bool HasRequirements { get; set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060013D9 RID: 5081 RVA: 0x00702110 File Offset: 0x00700310
		// (set) Token: 0x060013DA RID: 5082 RVA: 0x00702124 File Offset: 0x00700324
		public string RequiredLevel { get; set; } = "";

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00702138 File Offset: 0x00700338
		// (set) Token: 0x060013DC RID: 5084 RVA: 0x0070214C File Offset: 0x0070034C
		public string RequiredSkill { get; set; } = "";

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060013DD RID: 5085 RVA: 0x00702160 File Offset: 0x00700360
		// (set) Token: 0x060013DE RID: 5086 RVA: 0x00702174 File Offset: 0x00700374
		public string RequiredDescription { get; set; } = "";

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060013DF RID: 5087 RVA: 0x00702188 File Offset: 0x00700388
		// (set) Token: 0x060013E0 RID: 5088 RVA: 0x0070219C File Offset: 0x0070039C
		public bool RequiresModule { get; set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x007021B0 File Offset: 0x007003B0
		// (set) Token: 0x060013E2 RID: 5090 RVA: 0x007021C4 File Offset: 0x007003C4
		public bool RequiresModuleGather { get; set; }

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x007021D8 File Offset: 0x007003D8
		// (set) Token: 0x060013E4 RID: 5092 RVA: 0x007021EC File Offset: 0x007003EC
		public bool RequiresModuleDungeon { get; set; }

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00702200 File Offset: 0x00700400
		// (set) Token: 0x060013E6 RID: 5094 RVA: 0x00702214 File Offset: 0x00700414
		public string Description { get; set; } = "";

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00702228 File Offset: 0x00700428
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x0070223C File Offset: 0x0070043C
		public bool IsBundle { get; set; }

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00702250 File Offset: 0x00700450
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x00702264 File Offset: 0x00700464
		public bool IsConnected { get; set; }

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x00702278 File Offset: 0x00700478
		// (set) Token: 0x060013EC RID: 5100 RVA: 0x0070228C File Offset: 0x0070048C
		public List<int> ConnectedProfiles { get; set; } = new List<int>();

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x007022A0 File Offset: 0x007004A0
		// (set) Token: 0x060013EE RID: 5102 RVA: 0x007022B4 File Offset: 0x007004B4
		public int ParentProfileID { get; set; }

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x007022C8 File Offset: 0x007004C8
		// (set) Token: 0x060013F0 RID: 5104 RVA: 0x007022DC File Offset: 0x007004DC
		public List<string> ImageNames { get; set; } = new List<string>();

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x007022F0 File Offset: 0x007004F0
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x00702304 File Offset: 0x00700504
		public List<Bitmap> FullImages { get; set; } = new List<Bitmap>();

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00702318 File Offset: 0x00700518
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x0070232C File Offset: 0x0070052C
		public Bitmap PreviewImage { get; set; }

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00702340 File Offset: 0x00700540
		// (set) Token: 0x060013F6 RID: 5110 RVA: 0x00702354 File Offset: 0x00700554
		public double Price { get; set; }

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00702368 File Offset: 0x00700568
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0070237C File Offset: 0x0070057C
		public List<string> Keywords { get; set; } = new List<string>();

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00702390 File Offset: 0x00700590
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x007023A4 File Offset: 0x007005A4
		public string StoreName { get; set; } = "";

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x007023B8 File Offset: 0x007005B8
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x007023CC File Offset: 0x007005CC
		public string StoreDiscordUsername { get; set; } = "";

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x007023E0 File Offset: 0x007005E0
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x007023F4 File Offset: 0x007005F4
		public string StoreEmail { get; set; } = "";

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00702408 File Offset: 0x00700608
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0070241C File Offset: 0x0070061C
		public bool AlreadyPurchased { get; set; }

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00702430 File Offset: 0x00700630
		// (set) Token: 0x06001402 RID: 5122 RVA: 0x00702444 File Offset: 0x00700644
		public bool IsTopGoldmaking { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x00702458 File Offset: 0x00700658
		// (set) Token: 0x06001404 RID: 5124 RVA: 0x0070246C File Offset: 0x0070066C
		public bool IsTopDungeon { get; set; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00702480 File Offset: 0x00700680
		// (set) Token: 0x06001406 RID: 5126 RVA: 0x00702494 File Offset: 0x00700694
		public bool IsTopGathering { get; set; }
	}
}
