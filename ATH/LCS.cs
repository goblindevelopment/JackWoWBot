using System;

namespace Jack.ATH
{
	// Token: 0x02000142 RID: 322
	public class LCS
	{
		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x007348BC File Offset: 0x00732ABC
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x007348D0 File Offset: 0x00732AD0
		public string d1 { get; set; } = "";

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x007348E4 File Offset: 0x00732AE4
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x007348F8 File Offset: 0x00732AF8
		public string d2 { get; set; } = "";

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0073490C File Offset: 0x00732B0C
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00734920 File Offset: 0x00732B20
		public string d3 { get; set; } = "";

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x00734934 File Offset: 0x00732B34
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x00734948 File Offset: 0x00732B48
		public string d4 { get; set; } = "";

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0073495C File Offset: 0x00732B5C
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x00734970 File Offset: 0x00732B70
		public string d10 { get; set; } = "";

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00734984 File Offset: 0x00732B84
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x00734998 File Offset: 0x00732B98
		public string d11 { get; set; } = "";

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x007349AC File Offset: 0x00732BAC
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x007349C0 File Offset: 0x00732BC0
		public string d12 { get; set; } = "";

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x007349D4 File Offset: 0x00732BD4
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x007349E8 File Offset: 0x00732BE8
		public string d50 { get; set; } = "";

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x007349FC File Offset: 0x00732BFC
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x00734A10 File Offset: 0x00732C10
		public string d51 { get; set; } = "";

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x00734A24 File Offset: 0x00732C24
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x00734A38 File Offset: 0x00732C38
		public string d52 { get; set; } = "";

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x00734A4C File Offset: 0x00732C4C
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x00734A60 File Offset: 0x00732C60
		public string d53 { get; set; } = "";

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00734A74 File Offset: 0x00732C74
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x00734A88 File Offset: 0x00732C88
		public string d100 { get; set; } = "";

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00734A9C File Offset: 0x00732C9C
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x00734AB0 File Offset: 0x00732CB0
		public string d101 { get; set; } = "";

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x00734AC4 File Offset: 0x00732CC4
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x00734AD8 File Offset: 0x00732CD8
		public string d102 { get; set; } = "";

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x00734AEC File Offset: 0x00732CEC
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00734B00 File Offset: 0x00732D00
		public string d103 { get; set; } = "";

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00734B14 File Offset: 0x00732D14
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00734B28 File Offset: 0x00732D28
		public string d104 { get; set; } = "";

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x00734B3C File Offset: 0x00732D3C
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x00734B50 File Offset: 0x00732D50
		public string d105 { get; set; } = "";

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00734B64 File Offset: 0x00732D64
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x00734B78 File Offset: 0x00732D78
		public string d200 { get; set; } = "";

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00734B8C File Offset: 0x00732D8C
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00734BA0 File Offset: 0x00732DA0
		public string d201 { get; set; } = "";

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00734BB4 File Offset: 0x00732DB4
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00734BC8 File Offset: 0x00732DC8
		public string d202 { get; set; } = "";

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00734BDC File Offset: 0x00732DDC
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00734BF0 File Offset: 0x00732DF0
		public string d203 { get; set; } = "";

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x00734C04 File Offset: 0x00732E04
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00734C18 File Offset: 0x00732E18
		public string d204 { get; set; } = "";

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x00734C2C File Offset: 0x00732E2C
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00734C40 File Offset: 0x00732E40
		public string d205 { get; set; } = "";

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x00734C54 File Offset: 0x00732E54
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x00734C68 File Offset: 0x00732E68
		public string d300 { get; set; } = "";

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x00734C7C File Offset: 0x00732E7C
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00734C90 File Offset: 0x00732E90
		public string d301 { get; set; } = "";

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00734CA4 File Offset: 0x00732EA4
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x00734CB8 File Offset: 0x00732EB8
		public string d302 { get; set; } = "";

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x00734CCC File Offset: 0x00732ECC
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00734CE0 File Offset: 0x00732EE0
		public string d303 { get; set; } = "";

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x00734CF4 File Offset: 0x00732EF4
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x00734D08 File Offset: 0x00732F08
		public string d304 { get; set; } = "";

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x00734D1C File Offset: 0x00732F1C
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00734D30 File Offset: 0x00732F30
		public string d305 { get; set; } = "";

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x00734D44 File Offset: 0x00732F44
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00734D58 File Offset: 0x00732F58
		public string d400 { get; set; } = "";

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00734D6C File Offset: 0x00732F6C
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00734D80 File Offset: 0x00732F80
		public string d401 { get; set; } = "";

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x00734D94 File Offset: 0x00732F94
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x00734DA8 File Offset: 0x00732FA8
		public string d402 { get; set; } = "";

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x00734DBC File Offset: 0x00732FBC
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00734DD0 File Offset: 0x00732FD0
		public string d403 { get; set; } = "";

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x00734DE4 File Offset: 0x00732FE4
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00734DF8 File Offset: 0x00732FF8
		public string d404 { get; set; } = "";

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x00734E0C File Offset: 0x0073300C
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x00734E20 File Offset: 0x00733020
		public string d405 { get; set; } = "";

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x00734E34 File Offset: 0x00733034
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x00734E48 File Offset: 0x00733048
		public string d500 { get; set; } = "";

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x00734E5C File Offset: 0x0073305C
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x00734E70 File Offset: 0x00733070
		public string d501 { get; set; } = "";

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x00734E84 File Offset: 0x00733084
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x00734E98 File Offset: 0x00733098
		public string d502 { get; set; } = "";

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x00734EAC File Offset: 0x007330AC
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x00734EC0 File Offset: 0x007330C0
		public string d503 { get; set; } = "";

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x00734ED4 File Offset: 0x007330D4
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x00734EE8 File Offset: 0x007330E8
		public string d504 { get; set; } = "";

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x00734EFC File Offset: 0x007330FC
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x00734F10 File Offset: 0x00733110
		public string d505 { get; set; } = "";

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x00734F24 File Offset: 0x00733124
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x00734F38 File Offset: 0x00733138
		public string d600 { get; set; } = "";

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x00734F4C File Offset: 0x0073314C
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x00734F60 File Offset: 0x00733160
		public string d601 { get; set; } = "";

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x00734F74 File Offset: 0x00733174
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x00734F88 File Offset: 0x00733188
		public string d602 { get; set; } = "";

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x00734F9C File Offset: 0x0073319C
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00734FB0 File Offset: 0x007331B0
		public string d603 { get; set; } = "";

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00734FC4 File Offset: 0x007331C4
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00734FD8 File Offset: 0x007331D8
		public string d604 { get; set; } = "";

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00734FEC File Offset: 0x007331EC
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00735000 File Offset: 0x00733200
		public string d605 { get; set; } = "";

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00735014 File Offset: 0x00733214
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x00735028 File Offset: 0x00733228
		public string d700 { get; set; } = "";

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0073503C File Offset: 0x0073323C
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00735050 File Offset: 0x00733250
		public string d701 { get; set; } = "";

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x00735064 File Offset: 0x00733264
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x00735078 File Offset: 0x00733278
		public string d702 { get; set; } = "";

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0073508C File Offset: 0x0073328C
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x007350A0 File Offset: 0x007332A0
		public string d703 { get; set; } = "";

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x007350B4 File Offset: 0x007332B4
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x007350C8 File Offset: 0x007332C8
		public string d710 { get; set; } = "";

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x007350DC File Offset: 0x007332DC
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x007350F0 File Offset: 0x007332F0
		public string d720 { get; set; } = "";

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00735104 File Offset: 0x00733304
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00735118 File Offset: 0x00733318
		public string d730 { get; set; } = "";

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0073512C File Offset: 0x0073332C
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00735140 File Offset: 0x00733340
		public string d800 { get; set; } = "";

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00735154 File Offset: 0x00733354
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x00735168 File Offset: 0x00733368
		public string d801 { get; set; } = "";

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0073517C File Offset: 0x0073337C
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x00735190 File Offset: 0x00733390
		public string d802 { get; set; } = "";

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x007351A4 File Offset: 0x007333A4
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x007351B8 File Offset: 0x007333B8
		public string d803 { get; set; } = "";

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x007351CC File Offset: 0x007333CC
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x007351E0 File Offset: 0x007333E0
		public string d804 { get; set; } = "";

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x007351F4 File Offset: 0x007333F4
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x00735208 File Offset: 0x00733408
		public string d805 { get; set; } = "";
	}
}
