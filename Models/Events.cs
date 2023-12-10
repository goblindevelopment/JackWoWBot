using System;
using System.Collections.Generic;
using System.Numerics;

namespace Jack.Models
{
	// Token: 0x02000037 RID: 55
	public class Events : ICloneable
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00676004 File Offset: 0x00674204
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00676018 File Offset: 0x00674218
		public Vector3 Vector3 { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0067602C File Offset: 0x0067422C
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00676040 File Offset: 0x00674240
		public string Name { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00676054 File Offset: 0x00674254
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00676068 File Offset: 0x00674268
		public int ID { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0067607C File Offset: 0x0067427C
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00676090 File Offset: 0x00674290
		public string Action { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x006760A4 File Offset: 0x006742A4
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x006760B8 File Offset: 0x006742B8
		public Vector3 TargetLocation { get; set; } = Vector3.Zero;

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x006760CC File Offset: 0x006742CC
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x006760E0 File Offset: 0x006742E0
		public Vector3 LandingField { get; set; } = Vector3.Zero;

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x006760F4 File Offset: 0x006742F4
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00676108 File Offset: 0x00674308
		public bool SettingsExecuteOnce { get; set; } = true;

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0067611C File Offset: 0x0067431C
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00676130 File Offset: 0x00674330
		public bool SettingsExecuteAlways { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00676144 File Offset: 0x00674344
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00676158 File Offset: 0x00674358
		public bool SettingsExecuteGlobal { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0067616C File Offset: 0x0067436C
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00676180 File Offset: 0x00674380
		public string Faction { get; set; } = "Both";

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00676194 File Offset: 0x00674394
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x006761A8 File Offset: 0x006743A8
		public string Race { get; set; } = "All";

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x006761BC File Offset: 0x006743BC
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x006761D0 File Offset: 0x006743D0
		public bool HasCondition1 { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x006761E4 File Offset: 0x006743E4
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x006761F8 File Offset: 0x006743F8
		public string Condition1 { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0067620C File Offset: 0x0067440C
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00676220 File Offset: 0x00674420
		public string Condition1Compare { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00676234 File Offset: 0x00674434
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00676248 File Offset: 0x00674448
		public string Condition1Value { get; set; } = "";

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0067625C File Offset: 0x0067445C
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00676270 File Offset: 0x00674470
		public string Condition1Value2 { get; set; } = "";

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00676284 File Offset: 0x00674484
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00676298 File Offset: 0x00674498
		public string ConditionAndOr1 { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x006762AC File Offset: 0x006744AC
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x006762C0 File Offset: 0x006744C0
		public bool HasCondition2 { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x006762D4 File Offset: 0x006744D4
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x006762E8 File Offset: 0x006744E8
		public string Condition2 { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x006762FC File Offset: 0x006744FC
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00676310 File Offset: 0x00674510
		public string Condition2Compare { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00676324 File Offset: 0x00674524
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00676338 File Offset: 0x00674538
		public string Condition2Value { get; set; } = "";

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0067634C File Offset: 0x0067454C
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00676360 File Offset: 0x00674560
		public string Condition2Value2 { get; set; } = "";

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00676374 File Offset: 0x00674574
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00676388 File Offset: 0x00674588
		public string InteractNameOrID { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0067639C File Offset: 0x0067459C
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x006763B0 File Offset: 0x006745B0
		public bool InteractWithClosest { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x006763C4 File Offset: 0x006745C4
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x006763D8 File Offset: 0x006745D8
		public bool InteractWithFurthest { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x006763EC File Offset: 0x006745EC
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00676400 File Offset: 0x00674600
		public bool InteractWithAttack { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00676414 File Offset: 0x00674614
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00676428 File Offset: 0x00674628
		public bool Wait { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0067643C File Offset: 0x0067463C
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00676450 File Offset: 0x00674650
		public int WaitInSeconds { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00676464 File Offset: 0x00674664
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x00676478 File Offset: 0x00674678
		public int WaitInMS { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0067648C File Offset: 0x0067468C
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x006764A0 File Offset: 0x006746A0
		public bool WaitIgnoreAttackers { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x006764B4 File Offset: 0x006746B4
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x006764C8 File Offset: 0x006746C8
		public bool WaitFor { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x006764DC File Offset: 0x006746DC
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x006764F0 File Offset: 0x006746F0
		public string WaitForNameOrID { get; set; } = "";

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x00676504 File Offset: 0x00674704
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x00676518 File Offset: 0x00674718
		public int WaitForMaxSeconds { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0067652C File Offset: 0x0067472C
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00676540 File Offset: 0x00674740
		public int WaitForMaxSecondsInMS { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00676554 File Offset: 0x00674754
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00676568 File Offset: 0x00674768
		public bool WaitForGateOrDoor { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0067657C File Offset: 0x0067477C
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00676590 File Offset: 0x00674790
		public string LoadProfile { get; set; } = "";

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x006765A4 File Offset: 0x006747A4
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x006765B8 File Offset: 0x006747B8
		public int MapID { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x006765CC File Offset: 0x006747CC
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x006765E0 File Offset: 0x006747E0
		public int TargetDisplayID { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x006765F4 File Offset: 0x006747F4
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00676608 File Offset: 0x00674808
		public string TargetName { get; set; } = "";

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0067661C File Offset: 0x0067481C
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00676630 File Offset: 0x00674830
		public string RouteType { get; set; } = "";

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00676644 File Offset: 0x00674844
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00676658 File Offset: 0x00674858
		public string CombatMode { get; set; } = "Defensive";

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0067666C File Offset: 0x0067486C
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00676680 File Offset: 0x00674880
		public List<Vector3> Route { get; set; } = new List<Vector3>();

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00676694 File Offset: 0x00674894
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x006766A8 File Offset: 0x006748A8
		public bool VendorCanRepair { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x006766BC File Offset: 0x006748BC
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x006766D0 File Offset: 0x006748D0
		public bool VendorSellGreys { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x006766E4 File Offset: 0x006748E4
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x006766F8 File Offset: 0x006748F8
		public bool VendorSellWhites { get; set; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0067670C File Offset: 0x0067490C
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00676720 File Offset: 0x00674920
		public bool VendorSellGreens { get; set; }

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00676734 File Offset: 0x00674934
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00676748 File Offset: 0x00674948
		public bool VendorSellBlues { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x0067675C File Offset: 0x0067495C
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00676770 File Offset: 0x00674970
		public bool VendorMount { get; set; }

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00676784 File Offset: 0x00674984
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00676798 File Offset: 0x00674998
		public List<string> VendorWhitelist { get; set; } = new List<string>();

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x006767AC File Offset: 0x006749AC
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x006767C0 File Offset: 0x006749C0
		public List<string> VendorBuylist { get; set; } = new List<string>();

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x006767D4 File Offset: 0x006749D4
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x006767E8 File Offset: 0x006749E8
		public int FlightPointID { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x006767FC File Offset: 0x006749FC
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00676810 File Offset: 0x00674A10
		public string FlightPointName { get; set; } = "";

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00676824 File Offset: 0x00674A24
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00676838 File Offset: 0x00674A38
		public string FlightPointProfile { get; set; } = "";

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0067684C File Offset: 0x00674A4C
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00676860 File Offset: 0x00674A60
		public string RecorderMailboxReceiver { get; set; } = "";

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00676874 File Offset: 0x00674A74
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00676888 File Offset: 0x00674A88
		public bool RecorderMailboxSendGreys { get; set; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0067689C File Offset: 0x00674A9C
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x006768B0 File Offset: 0x00674AB0
		public bool RecorderMailboxSendWhites { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x006768C4 File Offset: 0x00674AC4
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x006768D8 File Offset: 0x00674AD8
		public bool RecorderMailboxSendGreens { get; set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x006768EC File Offset: 0x00674AEC
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00676900 File Offset: 0x00674B00
		public bool RecorderMailboxSendBlues { get; set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00676914 File Offset: 0x00674B14
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00676928 File Offset: 0x00674B28
		public bool RecorderMailboxSendPurples { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x0067693C File Offset: 0x00674B3C
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00676950 File Offset: 0x00674B50
		public List<string> RecorderMailboxSendlist { get; set; } = new List<string>();

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00676964 File Offset: 0x00674B64
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00676978 File Offset: 0x00674B78
		public bool GhostDirectionPathToGraveyard { get; set; } = true;

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x0067698C File Offset: 0x00674B8C
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x006769A0 File Offset: 0x00674BA0
		public int CastSpellID { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x006769B4 File Offset: 0x00674BB4
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x006769C8 File Offset: 0x00674BC8
		public bool CastSpellWhileWalk { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x006769DC File Offset: 0x00674BDC
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x006769F0 File Offset: 0x00674BF0
		public bool CastSpellUntilNoAttackers { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00676A04 File Offset: 0x00674C04
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00676A18 File Offset: 0x00674C18
		public int CastSpellRadius { get; set; } = 10;

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00676A2C File Offset: 0x00674C2C
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00676A40 File Offset: 0x00674C40
		public bool CastSpellNoRadiusCheck { get; set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00676A54 File Offset: 0x00674C54
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00676A68 File Offset: 0x00674C68
		public bool CastSpellGroundAOE { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00676A7C File Offset: 0x00674C7C
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00676A90 File Offset: 0x00674C90
		public bool CastSpellOnTarget { get; set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00676AA4 File Offset: 0x00674CA4
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00676AB8 File Offset: 0x00674CB8
		public string CastSpellTargetNameOrID { get; set; } = "";

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00676ACC File Offset: 0x00674CCC
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00676AE0 File Offset: 0x00674CE0
		public bool CastSpellTargetClosest { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00676AF4 File Offset: 0x00674CF4
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00676B08 File Offset: 0x00674D08
		public bool CastSpellTargetFurthest { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00676B1C File Offset: 0x00674D1C
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00676B30 File Offset: 0x00674D30
		public bool FacingStayHere { get; set; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00676B44 File Offset: 0x00674D44
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00676B58 File Offset: 0x00674D58
		public float WalkSensIndoor { get; set; } = 2f;

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00676B6C File Offset: 0x00674D6C
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00676B80 File Offset: 0x00674D80
		public float WalkSensOutdoor { get; set; } = 0.7f;

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00676B94 File Offset: 0x00674D94
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00676BA8 File Offset: 0x00674DA8
		public string UseHearthstoneProfile { get; set; } = "";

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00676BBC File Offset: 0x00674DBC
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00676BD0 File Offset: 0x00674DD0
		public bool FishingUseBait { get; set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00676BE4 File Offset: 0x00674DE4
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00676BF8 File Offset: 0x00674DF8
		public bool FishingFacing { get; set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00676C0C File Offset: 0x00674E0C
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00676C20 File Offset: 0x00674E20
		public Vector3 FishingFacingDirection { get; set; } = Vector3.Zero;

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00676C34 File Offset: 0x00674E34
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00676C48 File Offset: 0x00674E48
		public bool FishingCondition { get; set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00676C5C File Offset: 0x00674E5C
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00676C70 File Offset: 0x00674E70
		public bool FishingConditionSkill { get; set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00676C84 File Offset: 0x00674E84
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00676C98 File Offset: 0x00674E98
		public int FishingConditionSkillLevel { get; set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00676CAC File Offset: 0x00674EAC
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00676CC0 File Offset: 0x00674EC0
		public bool FishingConditionItem { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00676CD4 File Offset: 0x00674ED4
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00676CE8 File Offset: 0x00674EE8
		public List<string> FishingConditionItemList { get; set; } = new List<string>();

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00676CFC File Offset: 0x00674EFC
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00676D10 File Offset: 0x00674F10
		public bool FishingConditionFullBags { get; set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x00676D24 File Offset: 0x00674F24
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00676D38 File Offset: 0x00674F38
		public bool FishingRandomDelay { get; set; } = true;

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00676D4C File Offset: 0x00674F4C
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00676D60 File Offset: 0x00674F60
		public string UseTransportProfile { get; set; } = "";

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00676D74 File Offset: 0x00674F74
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00676D88 File Offset: 0x00674F88
		public string UseTransportTurn { get; set; } = "";

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00676D9C File Offset: 0x00674F9C
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00676DB0 File Offset: 0x00674FB0
		public string ExecuteLUA { get; set; } = "";

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00676DC4 File Offset: 0x00674FC4
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00676DD8 File Offset: 0x00674FD8
		public bool ExecuteLUAWhileWalk { get; set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x00676DEC File Offset: 0x00674FEC
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00676E00 File Offset: 0x00675000
		public bool BattlegroundsClassicWarsongGulch { get; set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00676E14 File Offset: 0x00675014
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00676E28 File Offset: 0x00675028
		public string BattlegroundsClassicWarsongGulchProfile { get; set; } = "";

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00676E3C File Offset: 0x0067503C
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00676E50 File Offset: 0x00675050
		public bool BattlegroundsClassicArathiBasin { get; set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x00676E64 File Offset: 0x00675064
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00676E78 File Offset: 0x00675078
		public string BattlegroundsClassicArathiBasinProfile { get; set; } = "";

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00676E8C File Offset: 0x0067508C
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00676EA0 File Offset: 0x006750A0
		public bool BattlegroundsClassicAlteracValley { get; set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00676EB4 File Offset: 0x006750B4
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00676EC8 File Offset: 0x006750C8
		public string BattlegroundsClassicAlteracValleyProfile { get; set; } = "";

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00676EDC File Offset: 0x006750DC
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00676EF0 File Offset: 0x006750F0
		public bool BattlegroundsClassicEyeOfTheStorm { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x00676F04 File Offset: 0x00675104
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00676F18 File Offset: 0x00675118
		public string BattlegroundsClassicEyeOfTheStormProfile { get; set; } = "";

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00676F2C File Offset: 0x0067512C
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00676F40 File Offset: 0x00675140
		public bool BattlegroundsClassicStrandOfTheAncients { get; set; }

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00676F54 File Offset: 0x00675154
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00676F68 File Offset: 0x00675168
		public string BattlegroundsClassicStrandOfTheAncientsProfile { get; set; } = "";

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x00676F7C File Offset: 0x0067517C
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00676F90 File Offset: 0x00675190
		public bool BattlegroundsWaitUntilInvitation { get; set; } = true;

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x00676FA4 File Offset: 0x006751A4
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00676FB8 File Offset: 0x006751B8
		public int QuestNPCID { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00676FCC File Offset: 0x006751CC
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00676FE0 File Offset: 0x006751E0
		public int QuestID { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00676FF4 File Offset: 0x006751F4
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00677008 File Offset: 0x00675208
		public string QuestName { get; set; } = "";

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0067701C File Offset: 0x0067521C
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00677030 File Offset: 0x00675230
		public bool QuestFromObject { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x00677044 File Offset: 0x00675244
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00677058 File Offset: 0x00675258
		public string LoadRotation { get; set; } = "";

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0067706C File Offset: 0x0067526C
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00677080 File Offset: 0x00675280
		public string ChangeSettingsCombatMode { get; set; } = "Offensive";

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00677094 File Offset: 0x00675294
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x006770A8 File Offset: 0x006752A8
		public string ChangeSettingsWaypointMode { get; set; } = "Best";

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x006770BC File Offset: 0x006752BC
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x006770D0 File Offset: 0x006752D0
		public bool ChangeSettingsModeMesh { get; set; } = true;

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x006770E4 File Offset: 0x006752E4
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x006770F8 File Offset: 0x006752F8
		public bool ChangeSettingsFollowFleeingTarget { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0067710C File Offset: 0x0067530C
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00677120 File Offset: 0x00675320
		public bool ChangeSettingsGroundMount { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x00677134 File Offset: 0x00675334
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00677148 File Offset: 0x00675348
		public bool ChangeSettingsFlightMount { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0067715C File Offset: 0x0067535C
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00677170 File Offset: 0x00675370
		public bool ChangeSettingsLoot { get; set; } = true;

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x00677184 File Offset: 0x00675384
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00677198 File Offset: 0x00675398
		public bool ChangeSettingsSkinning { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x006771AC File Offset: 0x006753AC
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x006771C0 File Offset: 0x006753C0
		public bool ChangeSettingsHerbalism { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x006771D4 File Offset: 0x006753D4
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x006771E8 File Offset: 0x006753E8
		public bool ChangeSettingsMining { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x006771FC File Offset: 0x006753FC
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00677210 File Offset: 0x00675410
		public bool ChangeSettingsGatherMobs { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00677224 File Offset: 0x00675424
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00677238 File Offset: 0x00675438
		public List<string> ChangeSettingsQuestItems { get; set; } = new List<string>();

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x0067724C File Offset: 0x0067544C
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00677260 File Offset: 0x00675460
		public int ChangeSettingsDistanceLoot { get; set; } = 40;

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x00677274 File Offset: 0x00675474
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00677288 File Offset: 0x00675488
		public int ChangeSettingsDistancePath { get; set; } = 100;

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0067729C File Offset: 0x0067549C
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x006772B0 File Offset: 0x006754B0
		public int ChangeSettingsDistanceLootGather { get; set; } = 4;

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x006772C4 File Offset: 0x006754C4
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x006772D8 File Offset: 0x006754D8
		public int ChangeSettingsDistanceAvoidElites { get; set; } = 40;

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x006772EC File Offset: 0x006754EC
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00677300 File Offset: 0x00675500
		public int ChangeSettingsDistanceWaypoint { get; set; } = 15;

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00677314 File Offset: 0x00675514
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00677328 File Offset: 0x00675528
		public int ChangeSettingsDistanceLocation { get; set; } = 40;

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x0067733C File Offset: 0x0067553C
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00677350 File Offset: 0x00675550
		public int ChangeSettingsDistanceMobGroup { get; set; } = 20;

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x00677364 File Offset: 0x00675564
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00677378 File Offset: 0x00675578
		public double ChangeSettingsDistanceIsReachable { get; set; } = 4.5;

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x0067738C File Offset: 0x0067558C
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x006773A0 File Offset: 0x006755A0
		public List<string> ChangeSettingsAttackableMobs { get; set; } = new List<string>();

		// Token: 0x06000558 RID: 1368 RVA: 0x006773B4 File Offset: 0x006755B4
		public object Clone()
		{
			return base.MemberwiseClone();
		}
	}
}
