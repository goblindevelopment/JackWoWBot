using System;
using System.Collections.Generic;
using System.Numerics;

namespace Jack.Models
{
	// Token: 0x02000038 RID: 56
	public class ProfileSettings
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0067760C File Offset: 0x0067580C
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x00677620 File Offset: 0x00675820
		public string CombatMode { get; set; } = "Offensive";

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00677634 File Offset: 0x00675834
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x00677648 File Offset: 0x00675848
		public int CombatModeIndex { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0067765C File Offset: 0x0067585C
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x00677670 File Offset: 0x00675870
		public string WaypointMode { get; set; } = "Best";

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00677684 File Offset: 0x00675884
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00677698 File Offset: 0x00675898
		public bool ModeMesh { get; set; } = true;

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x006776AC File Offset: 0x006758AC
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x006776C0 File Offset: 0x006758C0
		public int WaypointModeIndex { get; set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x006776D4 File Offset: 0x006758D4
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x006776E8 File Offset: 0x006758E8
		public bool FollowFleeingTarget { get; set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x006776FC File Offset: 0x006758FC
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x00677710 File Offset: 0x00675910
		public bool GroundMount { get; set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00677724 File Offset: 0x00675924
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00677738 File Offset: 0x00675938
		public bool FlightMount { get; set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0067774C File Offset: 0x0067594C
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00677760 File Offset: 0x00675960
		public bool Loot { get; set; } = true;

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00677774 File Offset: 0x00675974
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00677788 File Offset: 0x00675988
		public bool Skinning { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0067779C File Offset: 0x0067599C
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x006777B0 File Offset: 0x006759B0
		public bool Herbalism { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x006777C4 File Offset: 0x006759C4
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x006777D8 File Offset: 0x006759D8
		public bool Mining { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x006777EC File Offset: 0x006759EC
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x00677800 File Offset: 0x00675A00
		public bool GatherMobs { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x00677814 File Offset: 0x00675A14
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x00677828 File Offset: 0x00675A28
		public List<string> QuestItems { get; set; } = new List<string>();

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0067783C File Offset: 0x00675A3C
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x00677850 File Offset: 0x00675A50
		public int DistanceLoot { get; set; } = 40;

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00677864 File Offset: 0x00675A64
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x00677878 File Offset: 0x00675A78
		public int DistancePath { get; set; } = 100;

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0067788C File Offset: 0x00675A8C
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x006778A0 File Offset: 0x00675AA0
		public int DistanceLootGather { get; set; } = 4;

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x006778B4 File Offset: 0x00675AB4
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x006778C8 File Offset: 0x00675AC8
		public int DistanceAvoidElites { get; set; } = 40;

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x006778DC File Offset: 0x00675ADC
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x006778F0 File Offset: 0x00675AF0
		public int DistanceWaypoint { get; set; } = 15;

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00677904 File Offset: 0x00675B04
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x00677918 File Offset: 0x00675B18
		public int DistanceLocation { get; set; } = 40;

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0067792C File Offset: 0x00675B2C
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x00677940 File Offset: 0x00675B40
		public int DistanceMobGroup { get; set; } = 20;

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x00677954 File Offset: 0x00675B54
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x00677968 File Offset: 0x00675B68
		public double DistanceIsReachable { get; set; } = 4.5;

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0067797C File Offset: 0x00675B7C
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00677990 File Offset: 0x00675B90
		public List<string> AttackableMobs { get; set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x006779A4 File Offset: 0x00675BA4
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x006779B8 File Offset: 0x00675BB8
		public Dictionary<string, Vector3> Blacklist { get; set; } = new Dictionary<string, Vector3>();

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x006779CC File Offset: 0x00675BCC
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x006779E0 File Offset: 0x00675BE0
		public List<string> BlacklistNameOrID { get; set; } = new List<string>();

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x006779F4 File Offset: 0x00675BF4
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x00677A08 File Offset: 0x00675C08
		public List<string> WhitelistNameOrID { get; set; } = new List<string>();

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00677A1C File Offset: 0x00675C1C
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00677A30 File Offset: 0x00675C30
		public List<string[]> ClimbSpots { get; set; } = new List<string[]>();

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00677A44 File Offset: 0x00675C44
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x00677A58 File Offset: 0x00675C58
		public bool UseClimbSpots { get; set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x00677A6C File Offset: 0x00675C6C
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x00677A80 File Offset: 0x00675C80
		public bool ShowClimbSpotConnections { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x00677A94 File Offset: 0x00675C94
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x00677AA8 File Offset: 0x00675CA8
		public bool ClimbSpotsOres { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x00677ABC File Offset: 0x00675CBC
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x00677AD0 File Offset: 0x00675CD0
		public bool ClimbSpotsHerbs { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00677AE4 File Offset: 0x00675CE4
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x00677AF8 File Offset: 0x00675CF8
		public int ExpertLootDelay { get; set; } = 100;

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00677B0C File Offset: 0x00675D0C
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x00677B20 File Offset: 0x00675D20
		public int ExpertResurrectDelay { get; set; } = 1;

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x00677B34 File Offset: 0x00675D34
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x00677B48 File Offset: 0x00675D48
		public int ExpertMountDelay { get; set; } = 50;

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x00677B5C File Offset: 0x00675D5C
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00677B70 File Offset: 0x00675D70
		public float StayAndTurnOutdoor { get; set; } = 2f;

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00677B84 File Offset: 0x00675D84
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00677B98 File Offset: 0x00675D98
		public float StayAndTurnIndoor { get; set; } = 0.7f;

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00677BAC File Offset: 0x00675DAC
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00677BC0 File Offset: 0x00675DC0
		public int ExpertFlightTolerance { get; set; } = 5;
	}
}
