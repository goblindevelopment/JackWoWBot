using System;
using System.Collections.Generic;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x02000039 RID: 57
	public class Rotation
	{
		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00677CBC File Offset: 0x00675EBC
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00677CD0 File Offset: 0x00675ED0
		public int Bar { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00677CE4 File Offset: 0x00675EE4
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x00677CF8 File Offset: 0x00675EF8
		public int BarIndex { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00677D0C File Offset: 0x00675F0C
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x00677D20 File Offset: 0x00675F20
		public int Slot { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00677D34 File Offset: 0x00675F34
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00677D48 File Offset: 0x00675F48
		public string Key { get; set; } = "";

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00677D5C File Offset: 0x00675F5C
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x00677D70 File Offset: 0x00675F70
		public int ID { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00677D84 File Offset: 0x00675F84
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x00677D98 File Offset: 0x00675F98
		public int DifferentAuraID { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00677DAC File Offset: 0x00675FAC
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00677DC0 File Offset: 0x00675FC0
		public int RequiredLevel { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00677DD4 File Offset: 0x00675FD4
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x00677DE8 File Offset: 0x00675FE8
		public string Name { get; set; } = "";

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00677DFC File Offset: 0x00675FFC
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00677E10 File Offset: 0x00676010
		public int Rank { get; set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00677E24 File Offset: 0x00676024
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00677E38 File Offset: 0x00676038
		public int Prio { get; set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00677E4C File Offset: 0x0067604C
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00677E60 File Offset: 0x00676060
		public bool CanCastWhileWalk { get; set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00677E74 File Offset: 0x00676074
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x00677E88 File Offset: 0x00676088
		public int Cooldown { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00677E9C File Offset: 0x0067609C
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00677EB0 File Offset: 0x006760B0
		public int GlobalCooldown { get; set; } = _globals.GlobalCooldown;

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00677EC4 File Offset: 0x006760C4
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00677ED8 File Offset: 0x006760D8
		public int Repetitions { get; set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00677EEC File Offset: 0x006760EC
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00677F00 File Offset: 0x00676100
		public string Type { get; set; } = "";

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00677F14 File Offset: 0x00676114
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00677F28 File Offset: 0x00676128
		public bool IsItem { get; set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00677F3C File Offset: 0x0067613C
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00677F50 File Offset: 0x00676150
		public bool IsMacro { get; set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00677F64 File Offset: 0x00676164
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x00677F78 File Offset: 0x00676178
		public bool HasPowerType1 { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00677F8C File Offset: 0x0067618C
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00677FA0 File Offset: 0x006761A0
		public string PowerType1Target { get; set; } = "";

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00677FB4 File Offset: 0x006761B4
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x00677FC8 File Offset: 0x006761C8
		public string PowerType1 { get; set; } = "";

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00677FDC File Offset: 0x006761DC
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x00677FF0 File Offset: 0x006761F0
		public string PowerType1Compare { get; set; } = "";

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00678004 File Offset: 0x00676204
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00678018 File Offset: 0x00676218
		public int PowerType1Value { get; set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0067802C File Offset: 0x0067622C
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x00678040 File Offset: 0x00676240
		public bool HasPowerType2 { get; set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00678054 File Offset: 0x00676254
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00678068 File Offset: 0x00676268
		public string PowerType2Target { get; set; } = "";

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0067807C File Offset: 0x0067627C
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00678090 File Offset: 0x00676290
		public string PowerType2 { get; set; } = "";

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x006780A4 File Offset: 0x006762A4
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x006780B8 File Offset: 0x006762B8
		public string PowerType2Compare { get; set; } = "";

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x006780CC File Offset: 0x006762CC
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x006780E0 File Offset: 0x006762E0
		public int PowerType2Value { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x006780F4 File Offset: 0x006762F4
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00678108 File Offset: 0x00676308
		public bool HasItem { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0067811C File Offset: 0x0067631C
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00678130 File Offset: 0x00676330
		public string ItemName { get; set; } = "";

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00678144 File Offset: 0x00676344
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00678158 File Offset: 0x00676358
		public string ItemCompare { get; set; } = "";

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0067816C File Offset: 0x0067636C
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00678180 File Offset: 0x00676380
		public int ItemID { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00678194 File Offset: 0x00676394
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x006781A8 File Offset: 0x006763A8
		public int ItemValue { get; set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x006781BC File Offset: 0x006763BC
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x006781D0 File Offset: 0x006763D0
		public int ItemAmount { get; set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x006781E4 File Offset: 0x006763E4
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x006781F8 File Offset: 0x006763F8
		public bool HasAddition1 { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0067820C File Offset: 0x0067640C
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x00678220 File Offset: 0x00676420
		public string Addition1Target { get; set; } = "";

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00678234 File Offset: 0x00676434
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00678248 File Offset: 0x00676448
		public string Addition1Option { get; set; } = "";

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0067825C File Offset: 0x0067645C
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00678270 File Offset: 0x00676470
		public string Addition1Compare { get; set; } = "";

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00678284 File Offset: 0x00676484
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00678298 File Offset: 0x00676498
		public int Addition1Value { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x006782AC File Offset: 0x006764AC
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x006782C0 File Offset: 0x006764C0
		public bool HasAddition2 { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x006782D4 File Offset: 0x006764D4
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x006782E8 File Offset: 0x006764E8
		public bool DoNotRecastIfActive { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x006782FC File Offset: 0x006764FC
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00678310 File Offset: 0x00676510
		public string DoNotRecastIfActiveTarget { get; set; } = "";

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x00678324 File Offset: 0x00676524
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x00678338 File Offset: 0x00676538
		public bool HasAddition3 { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0067834C File Offset: 0x0067654C
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00678360 File Offset: 0x00676560
		public bool CastIfActive { get; set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00678374 File Offset: 0x00676574
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x00678388 File Offset: 0x00676588
		public List<string> CastIfActiveSpelllist { get; set; } = new List<string>();

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0067839C File Offset: 0x0067659C
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x006783B0 File Offset: 0x006765B0
		public string CastIfActiveTarget { get; set; } = "";

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x006783C4 File Offset: 0x006765C4
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x006783D8 File Offset: 0x006765D8
		public bool AlwaysActiveCombat { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x006783EC File Offset: 0x006765EC
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x00678400 File Offset: 0x00676600
		public bool AlwaysActiveCombatWay { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00678414 File Offset: 0x00676614
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x00678428 File Offset: 0x00676628
		public bool AlwaysActiveOutOfCombat { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0067843C File Offset: 0x0067663C
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x00678450 File Offset: 0x00676650
		public bool HasMultipleAttackers { get; set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00678464 File Offset: 0x00676664
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00678478 File Offset: 0x00676678
		public string MultipleAttackersCompare { get; set; } = "";

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0067848C File Offset: 0x0067668C
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x006784A0 File Offset: 0x006766A0
		public int MultipleAttackersValue { get; set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x006784B4 File Offset: 0x006766B4
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x006784C8 File Offset: 0x006766C8
		public int MultipleAttackersDistance { get; set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x006784DC File Offset: 0x006766DC
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x006784F0 File Offset: 0x006766F0
		public bool MultipleAttackersStepBack { get; set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00678504 File Offset: 0x00676704
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00678518 File Offset: 0x00676718
		public bool HasMore { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0067852C File Offset: 0x0067672C
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00678540 File Offset: 0x00676740
		public bool TargetIsCasting { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00678554 File Offset: 0x00676754
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00678568 File Offset: 0x00676768
		public string DifferentUsage { get; set; } = "";
	}
}
