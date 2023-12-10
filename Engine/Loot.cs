using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;
using Jack.Core;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000C9 RID: 201
	public static class Loot
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0070DDB8 File Offset: 0x0070BFB8
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x0070DDCC File Offset: 0x0070BFCC
		public static Dictionary<UInt128, bool> List { get; set; } = new Dictionary<UInt128, bool>();

		// Token: 0x06001510 RID: 5392 RVA: 0x0070DDE0 File Offset: 0x0070BFE0
		public static void Monitor()
		{
			while (_globals.Start && !Loot.Stop)
			{
				if (!Loot.Runs)
				{
					Loot.Runs = true;
				}
				if (!_globals.NoCheck && ObjectManager.GetFreeBagSlots > 0)
				{
					foreach (Units units in ObjectManager.GetLoots(0))
					{
						if (Walk.IsOnWhitelist(units.DisplayID, units.Name) || !Walk.IsOnBlacklist(units.PositionVector3, units.DisplayID, units.Name))
						{
							Loot.Add(units.GUID128);
						}
					}
				}
				Thread.Sleep(500);
			}
			Loot.Runs = false;
			Loot.Stop = false;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0070DEB0 File Offset: 0x0070C0B0
		public static void Add(UInt128 UnitGUID)
		{
			object @lock = Loot._lock;
			lock (@lock)
			{
				if (!Loot.List.Keys.Contains(UnitGUID))
				{
					Loot.List.Add(UnitGUID, false);
				}
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x0070DF08 File Offset: 0x0070C108
		public static List<UInt128> LootableUnits
		{
			get
			{
				List<UInt128> list = new List<UInt128>();
				object @lock = Loot._lock;
				lock (@lock)
				{
					foreach (KeyValuePair<UInt128, bool> keyValuePair in Loot.List)
					{
						if (!keyValuePair.Value)
						{
							list.Add(keyValuePair.Key);
						}
					}
				}
				return list;
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0070DF98 File Offset: 0x0070C198
		public static void SetDone(UInt128 UnitGUID)
		{
			object @lock = Loot._lock;
			lock (@lock)
			{
				Loot.List[UnitGUID] = true;
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0070DFE0 File Offset: 0x0070C1E0
		public static void Get()
		{
			object @lock = Loot._lock;
			lock (@lock)
			{
				foreach (UInt128 key in Loot.LootableUnits)
				{
					if (_globals.Start)
					{
						if (!_globals.NoCheck)
						{
							Units closestUnit = ObjectManager.GetClosestUnit(Loot.LootableUnits);
							if (closestUnit == null)
							{
								Loot.List[key] = true;
								continue;
							}
							bool flag2 = true;
							UInt128 @uint = 0;
							Vector3 vector = default(Vector3);
							string text = "";
							int num = 0;
							object lock2 = ObjectManager._lock;
							bool isLootable;
							lock (lock2)
							{
								@uint = closestUnit.GUID128;
								vector = closestUnit.PositionVector3;
								text = closestUnit.Name;
								num = closestUnit.DisplayID;
								isLootable = closestUnit.IsLootable;
							}
							if (!isLootable)
							{
								Loot.SetDone(@uint);
								continue;
							}
							if (Walk.ProfileSettings.FlightMount && !Pathfinder.IsInRange(vector))
							{
								Tools.Console("I should better use my Mount for the next Node...", "Orange", "richConsole", "frmMain", true);
								Walk.Mount(true, false);
								Fly.Trigger();
							}
							else
							{
								Tools.Console("Go to Loot -> " + text, "Blue", "richConsole", "frmMain", true);
								int num2 = Walk.ProfileSettings.DistanceLootGather;
								if (num2 < 4 && !ObjectManager.Me.IsFlying)
								{
									num2 = 4;
								}
								if (JackMath.Distance(vector, true, true, true) > (double)num2)
								{
									flag2 = Walk.GoTo(vector, (double)num2, 0f, new string[]
									{
										"Combat",
										"Blacklist"
									});
								}
								if (Combat.ReactToAttackersInGatherMode())
								{
									flag2 = Walk.GoTo(vector, (double)num2, 0f, null);
								}
								if (Walk.IsOnWhitelist(num, text) || !Walk.IsOnBlacklist(vector, num, text))
								{
									Fly.MoveDown(vector, text, false);
								}
								if (flag2 && (Walk.IsOnWhitelist(num, text) || !Walk.IsOnBlacklist(vector, num, text)))
								{
									Tools.Console("Loot " + text, "Blue", "richConsole", "frmMain", true);
									Thread.Sleep(250);
									ObjectManager.Interaction(@uint, "InteractMouseover");
									Thread.Sleep(Walk.ProfileSettings.ExpertLootDelay);
									Loot.SetDone(@uint);
									Loot.CheckSkin(@uint, num, text);
								}
								else
								{
									if (AntiStuck.Stuck && AntiStuck.StuckCounter == 3)
									{
										Loot.SetDone(@uint);
										break;
									}
									break;
								}
							}
							if (!Walk.ProfileSettings.FlightMount)
							{
								continue;
							}
						}
					}
					break;
				}
			}
			Tools.Console("Loot done.", "Blue", "richConsole", "frmMain", true);
			Jack.Engine.Monitor.AutoDestroy = true;
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0070E300 File Offset: 0x0070C500
		private static void CheckSkin(UInt128 UnitGUID, int UnitID, string UnitName)
		{
			bool flag = false;
			if (Walk.ProfileSettings.Skinning && ObjectManager.Me.HasProfession("Skinning") && (_globals.List_Skinning.Contains(UnitID) || Walk.IsOnWhitelist(UnitID, UnitName)))
			{
				flag = true;
			}
			if (!flag)
			{
				flag = Loot.CanGatherMobs(UnitID, UnitName);
			}
			if (!flag)
			{
				return;
			}
			for (int i = 0; i < 15; i++)
			{
				if (ObjectManager.Me.IsInCombat)
				{
					return;
				}
				Thread.Sleep(100);
			}
			Skinning.Add(UnitGUID);
			Skinning.GetAfterLoot(UnitGUID);
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0070E380 File Offset: 0x0070C580
		public static bool CanGatherMobs(int UnitID = 0, string UnitName = "")
		{
			if (!Walk.ProfileSettings.GatherMobs)
			{
				return false;
			}
			bool flag = ObjectManager.Me.HasProfession("Mining");
			bool flag2 = ObjectManager.Me.HasProfession("Herbalism");
			return (flag || flag2) && (UnitID == 0 || Walk.IsOnWhitelist(UnitID, UnitName) || (flag && _globals.List_MiningMobs.Contains(UnitID)) || (flag2 && _globals.List_HerbalismMobs.Contains(UnitID)));
		}

		// Token: 0x040009FC RID: 2556
		public static object _lock = new object();

		// Token: 0x040009FD RID: 2557
		public static bool Runs = false;

		// Token: 0x040009FE RID: 2558
		public static bool Stop = false;
	}
}
