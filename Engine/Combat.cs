using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using Jack.ATH;
using Jack.Core;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000BE RID: 190
	public static class Combat
	{
		// Token: 0x06001430 RID: 5168 RVA: 0x007035F8 File Offset: 0x007017F8
		public static void MonitorDefensiveCombats()
		{
			while (_globals.Start && MDL.CheckDungeon && !Combat.DefensiveStop)
			{
				if (!Combat.DefensiveRuns)
				{
					Combat.DefensiveRuns = true;
				}
				if (!_globals.NoCheck && !Combat.DefensiveAttackers && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && ObjectManager.GetAttacker != null)
				{
					Combat.DefensiveAttackers = true;
				}
				Thread.Sleep(500);
			}
			Combat.DefensiveRuns = false;
			Combat.DefensiveStop = false;
			Combat.DefensiveAttackers = false;
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0070367C File Offset: 0x0070187C
		public static void MonitorOffensiveCombats()
		{
			Combat.OffensiveAttackers = false;
			while (_globals.Start && MDL.CheckDungeon && !Combat.OffensiveStop)
			{
				if (!Combat.OffensiveRuns)
				{
					Combat.OffensiveRuns = true;
				}
				if (!_globals.NoCheck && !Combat.OffensiveAttackers)
				{
					Vector3 vector = default(Vector3);
					if (Loot.LootableUnits.Count > 0)
					{
						Units closestUnit = ObjectManager.GetClosestUnit(Loot.LootableUnits);
						object @lock = ObjectManager._lock;
						lock (@lock)
						{
							if (closestUnit != null)
							{
								vector = closestUnit.PositionVector3;
							}
							goto IL_13B;
						}
						goto IL_8E;
					}
					goto IL_8E;
					IL_126:
					Combat.SearchForUnitsToAttack(vector);
					goto IL_12C;
					IL_8E:
					if (Skinning.SkinnableUnits.Count > 0)
					{
						Units closestUnit2 = ObjectManager.GetClosestUnit(Skinning.SkinnableUnits);
						object @lock = ObjectManager._lock;
						lock (@lock)
						{
							if (closestUnit2 != null)
							{
								vector = closestUnit2.PositionVector3;
							}
							goto IL_13B;
						}
					}
					if (Nodes.GatherableObjects.Count > 0)
					{
						Objects closestObject = ObjectManager.GetClosestObject(Nodes.GatherableObjects);
						object @lock = ObjectManager._lock;
						lock (@lock)
						{
							if (closestObject != null)
							{
								vector = closestObject.PositionVector3;
							}
							goto IL_13B;
						}
					}
					try
					{
						vector = _globals.Waypoints[Walk.Counter];
						goto IL_13B;
					}
					catch
					{
						goto IL_13B;
					}
					goto IL_126;
					IL_13B:
					if (vector != default(Vector3))
					{
						goto IL_126;
					}
				}
				IL_12C:
				Thread.Sleep(500);
			}
			Combat.OffensiveRuns = false;
			Combat.OffensiveStop = false;
			Combat.OffensiveAttackers = false;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x00703820 File Offset: 0x00701A20
		public static void SearchForUnitsToAttack(Vector3 ToAttackPosition)
		{
			Combat.UnitsToAttack.Clear();
			if (!Walk.IsInMeshMode)
			{
				Combat.UnitsToAttack = ObjectManager.GetUnitsAroundUnits(ObjectManager.GetUnitsAround(ToAttackPosition, "Offensive", Walk.ProfileSettings.DistanceWaypoint), "UnitToUnitOffensive", Walk.ProfileSettings.DistanceMobGroup);
			}
			Dictionary<UInt128, Units> unitsAroundUnits = ObjectManager.GetUnitsAroundUnits(ObjectManager.GetUnitsAround(ObjectManager.Me.PositionVector3, "Offensive", Walk.ProfileSettings.DistanceLocation), "UnitToUnitOffensive", Walk.ProfileSettings.DistanceMobGroup);
			if (unitsAroundUnits.Count > 0)
			{
				foreach (KeyValuePair<UInt128, Units> keyValuePair in unitsAroundUnits)
				{
					if (!Combat.UnitsToAttack.ContainsKey(keyValuePair.Key) && !Combat.IsLOSTarget(keyValuePair.Key))
					{
						Combat.UnitsToAttack.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
			}
			if (Combat.UnitsToAttack.Count > 0)
			{
				Combat.OffensiveAttackers = true;
				Tools.Console("Attack (Offensive) -> " + Combat.UnitsToAttack.Count.ToString() + " Mobs...", "Blue", "richConsole", "frmMain", true);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00703968 File Offset: 0x00701B68
		public static void AddLOSTarget(UInt128 UnitGUID)
		{
			object @lock = Combat._lock;
			lock (@lock)
			{
				if (!Combat.NotInLOSTargets.ContainsKey(UnitGUID))
				{
					Combat.NotInLOSTargets.Add(UnitGUID, DateTime.Now);
					Tools.Console("Added Target to not-in-LOS targets.", "Orange", "richConsole", "frmMain", true);
				}
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x007039D8 File Offset: 0x00701BD8
		private static bool IsLOSTarget(UInt128 UnitGUID)
		{
			object @lock = Combat._lock;
			bool result;
			lock (@lock)
			{
				if (!Combat.NotInLOSTargets.ContainsKey(UnitGUID))
				{
					return false;
				}
				if (Combat.NotInLOSTargets[UnitGUID].AddMinutes(1.0) <= DateTime.Now)
				{
					Combat.NotInLOSTargets.Remove(UnitGUID);
					Tools.Console("Removed Target from not-in-LOS targets.", "", "richConsole", "frmMain", true);
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00703A78 File Offset: 0x00701C78
		public static void MonitorPVPCombats()
		{
			Combat.PVPAttackers = false;
			while (_globals.Start && MDL.CheckDungeon && !Combat.PVPStop)
			{
				Thread.Sleep(500);
				if (!Combat.PVPRuns)
				{
					Combat.PVPRuns = true;
				}
				if (!_globals.NoCheck && !Combat.PVPAttackers && ObjectManager.Me.IsAlive)
				{
					List<Units> getAttackers = ObjectManager.GetAttackers;
					if (getAttackers.Count > 0)
					{
						Units closestUnit = ObjectManager.GetClosestUnit(getAttackers);
						object @lock = ObjectManager._lock;
						lock (@lock)
						{
							if (closestUnit != null && Combat.PlayerIsInRange(closestUnit.PositionVector3) && !Combat.IsLOSTarget(closestUnit.GUID128))
							{
								Tools.Console("Getting attacked...", "Blue", "richConsole", "frmMain", true);
								Combat.PVPUnit = closestUnit;
								Combat.PVPAttackers = true;
								continue;
							}
						}
					}
					if (!(Walk.ProfileSettings.CombatMode != "PvP (Offensive)"))
					{
						Vector3 vector = default(Vector3);
						try
						{
							vector = _globals.Waypoints[Walk.Counter];
						}
						catch
						{
						}
						if (!(vector == default(Vector3)))
						{
							List<Units> unitsAround = ObjectManager.GetUnitsAround(vector, "PvP", 8);
							if (unitsAround.Count != 0)
							{
								Units closestUnit2 = ObjectManager.GetClosestUnit(unitsAround);
								object @lock = ObjectManager._lock;
								lock (@lock)
								{
									if (Combat.IsLOSTarget(closestUnit2.GUID128))
									{
										continue;
									}
								}
								Combat.PVPUnit = closestUnit2;
								Combat.PVPAttackers = true;
								Tools.Console("Attacking PvP Unit...", "Blue", "richConsole", "frmMain", true);
							}
						}
					}
				}
			}
			Combat.PVPRuns = false;
			Combat.PVPStop = false;
			Combat.PVPAttackers = false;
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00703C60 File Offset: 0x00701E60
		public static void OffensiveAttack()
		{
			if (MDL.CheckDungeon)
			{
				if (ObjectManager.Me.IsInVashjir)
				{
					Fly.Stop = true;
				}
				if (_globals.KeyStatus["TurnLeft"])
				{
					Key.Release("TurnLeft");
				}
				if (_globals.KeyStatus["TurnRight"])
				{
					Key.Release("TurnRight");
				}
				while (_globals.Start && !_globals.NoCheck)
				{
					if (Monitor.QuestsCompleted && !ObjectManager.Me.IsInCombat)
					{
						Tools.Console("Quest completed. Clearing Attacker List...", "", "richConsole", "frmMain", true);
						Combat.UnitsToAttack.Clear();
						break;
					}
					List<UInt128> list = new List<UInt128>();
					foreach (Units units in ObjectManager.GetAttackers)
					{
						if (!Combat.UnitsToAttack.ContainsKey(units.GUID))
						{
							Tools.Console("Found new Attackers...", "", "richConsole", "frmMain", true);
							Combat.UnitsToAttack.Add(units.GUID, units);
						}
					}
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						foreach (KeyValuePair<UInt128, Units> keyValuePair in Combat.UnitsToAttack)
						{
							if (keyValuePair.Value.IsDead || keyValuePair.Value.IsRunningBack || Combat.IsLOSTarget(keyValuePair.Key) || keyValuePair.Value.IsRelatedToAnotherPlayer)
							{
								list.Add(keyValuePair.Key);
							}
						}
					}
					foreach (UInt128 key in list)
					{
						Combat.UnitsToAttack.Remove(key);
					}
					if (Combat.UnitsToAttack.Count == 0)
					{
						break;
					}
					@lock = ObjectManager._lock;
					lock (@lock)
					{
						Units closestUnit = ObjectManager.GetClosestUnit(Combat.UnitsToAttack);
						if (closestUnit != null)
						{
							UInt128 guid = closestUnit.GUID128;
							string name = closestUnit.Name;
							while (_globals.Start && !_globals.NoCheck && closestUnit != null && closestUnit.IsAlive)
							{
								Vector3 positionVector = closestUnit.PositionVector3;
								if (ObjectManager.Me.IsInVashjir)
								{
									Walk.VashjirBehaviour(positionVector, closestUnit, null);
								}
								if (closestUnit.IsFleeing)
								{
									string a = Walk.FleeingTarget(closestUnit);
									if (a == "next" || a == "dead")
									{
										break;
									}
									if (a == "wait")
									{
										Combat.WaitingForFleeingTarget = true;
										break;
									}
								}
								if (Combat.IsLOSTarget(guid))
								{
									break;
								}
								if (closestUnit.IsRunningBack)
								{
									Tools.Console("Cancel attack. \"" + name + "\" is running back.", "Orange", "richConsole", "frmMain", true);
									break;
								}
								if (ObjectManager.Me.TargetGUID != guid)
								{
									ObjectManager.Interaction(guid, "InteractMouseover");
								}
								if (closestUnit.IsBehind)
								{
									Key.Release("All");
									Angle.FaceMe(ObjectManager.Me.PositionVector3, positionVector, ObjectManager.Me.Facing, closestUnit, false, 0.5f);
								}
								if (AntiStuck.StuckCircle)
								{
									Walk.AntiStuckCircle();
								}
								if (closestUnit.IsRelatedToAnotherPlayer)
								{
									Tools.Console("Cancel attack. \"" + name + "\" is getting attacked by another player.", "Orange", "richConsole", "frmMain", true);
									break;
								}
								if (JackMath.Distance(positionVector, true, true, true) > (double)SpellRotation.RotationSettings.PullDistance)
								{
									Walk.Facing(positionVector, closestUnit, (double)SpellRotation.RotationSettings.PullDistance, 0.5f, new string[]
									{
										"Dismount",
										"RunBack",
										"AlwaysActiveWay",
										"RelatedToAnotherPlayer"
									});
								}
								else
								{
									if (_globals.KeyStatus["MoveForward"])
									{
										Key.Release("All");
									}
									Walk.Facing(positionVector, closestUnit, (double)SpellRotation.RotationSettings.PullDistance, 0.5f, new string[]
									{
										"Dismount",
										"RunBack",
										"AlwaysActiveWay"
									});
									Key.Release("All");
									if (SpellRotation.RotationSettings.PullDistance <= 3)
									{
										ObjectManager.Interaction(guid, "InteractMouseover");
									}
									SpellRotation.Combat(guid);
								}
								Thread.Sleep(10);
							}
							if (Combat.WaitingForFleeingTarget)
							{
								break;
							}
							Thread.Sleep(500);
							if (Walk.ProfileSettings.Loot && ObjectManager.GetAttackers.Count == 0)
							{
								Loot.Add(guid);
								Loot.Get();
							}
						}
					}
					Thread.Sleep(10);
				}
				Tools.Console("Combat (Offensive) done.", "", "richConsole", "frmMain", true);
				Combat.OffensiveAttackers = false;
				if (ObjectManager.Me.IsInVashjir)
				{
					Fly.Stop = false;
				}
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x007041EC File Offset: 0x007023EC
		public static void DefensiveAttack()
		{
			if (ObjectManager.Me.IsInVashjir)
			{
				Fly.Stop = true;
			}
			while (_globals.Start && !_globals.NoCheck && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && MDL.CheckDungeon)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					Units getClosestAttacker = ObjectManager.GetClosestAttacker;
					if (getClosestAttacker == null)
					{
						break;
					}
					UInt128 guid = getClosestAttacker.GUID128;
					Tools.Console("Attack (Defensive) -> " + getClosestAttacker.Name, "Blue", "richConsole", "frmMain", true);
					while (_globals.Start && !_globals.NoCheck && ObjectManager.GetUnitByGUID(guid) != null && getClosestAttacker.IsAlive && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir))
					{
						Vector3 positionVector = getClosestAttacker.PositionVector3;
						if (ObjectManager.Me.IsInVashjir)
						{
							Walk.VashjirBehaviour(positionVector, getClosestAttacker, null);
						}
						if (getClosestAttacker.IsFleeing && Walk.FleeingTarget(getClosestAttacker) != "follow")
						{
							break;
						}
						if (ObjectManager.Me.TargetGUID != guid)
						{
							ObjectManager.Interaction(guid, "InteractMouseover");
						}
						if (getClosestAttacker.IsBehind)
						{
							Key.Release("All");
							Angle.FaceMe(ObjectManager.Me.PositionVector3, positionVector, ObjectManager.Me.Facing, getClosestAttacker, false, 0.5f);
						}
						if (AntiStuck.StuckCircle)
						{
							Walk.AntiStuckCircle();
						}
						if (JackMath.Distance(positionVector, true, true, true) > (double)SpellRotation.RotationSettings.PullDistance)
						{
							Walk.Facing(positionVector, getClosestAttacker, (double)SpellRotation.RotationSettings.PullDistance, 0.5f, new string[]
							{
								"RunBack"
							});
						}
						else
						{
							if (_globals.KeyStatus["MoveForward"])
							{
								Key.Release("All");
							}
							if (SpellRotation.RotationSettings.PullDistance <= SpellRotation.RotationSettings.PullDistance)
							{
								ObjectManager.Interaction(guid, "InteractMouseover");
							}
							SpellRotation.Combat(guid);
						}
						Thread.Sleep(10);
					}
					Thread.Sleep(500);
					if (Walk.ProfileSettings.Loot && ObjectManager.GetAttackers.Count == 0)
					{
						Loot.Add(guid);
						Loot.Get();
					}
					if (ObjectManager.GetAttacker == null)
					{
						break;
					}
				}
			}
			Combat.DefensiveAttackers = false;
			if (ObjectManager.Me.IsInVashjir)
			{
				Fly.Stop = false;
			}
			Tools.Console("Combat (Defensive) done.", "Blue", "richConsole", "frmMain", true);
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0070449C File Offset: 0x0070269C
		public static void PVPAttack()
		{
			while (_globals.Start)
			{
				if (!_globals.NoCheck && !ObjectManager.Me.IsFlying && MDL.CheckDungeon)
				{
					if (_globals.KeyStatus["TurnLeft"])
					{
						Key.Release("TurnLeft");
					}
					if (_globals.KeyStatus["TurnRight"])
					{
						Key.Release("TurnRight");
					}
					if (!ObjectManager.Me.IsDead && !ObjectManager.Me.IsGhost)
					{
						Units units = null;
						UInt128 @uint = 0;
						Vector3 vector = default(Vector3);
						bool flag = false;
						double num = 0.0;
						object @lock = ObjectManager._lock;
						lock (@lock)
						{
							units = ObjectManager.GetUnitByGUID(Combat.PVPUnit.GUID128);
							if (units == null)
							{
								break;
							}
							vector = units.PositionVector3;
							if (vector == default(Vector3))
							{
								break;
							}
							@uint = units.GUID128;
							flag = units.IsAlive;
							num = JackMath.Distance(vector, true, true, true);
						}
						if (!(@uint == 0))
						{
							if (flag)
							{
								if (!Combat.IsLOSTarget(@uint))
								{
									if (Combat.PlayerIsInRange(vector))
									{
										if (ObjectManager.Me.TargetGUID != @uint)
										{
											ObjectManager.Interaction(@uint, "InteractMouseover");
										}
										if (units.IsBehind)
										{
											Key.Release("All");
											Angle.FaceMe(ObjectManager.Me.PositionVector3, vector, ObjectManager.Me.Facing, units, false, 0.5f);
										}
										if (AntiStuck.StuckCircle)
										{
											Walk.AntiStuckCircle();
										}
										if (units.IsBehind)
										{
											Key.Release("All");
											Angle.FaceMe(ObjectManager.Me.PositionVector3, vector, ObjectManager.Me.Facing, units, false, 0.5f);
										}
										if (num > (double)SpellRotation.RotationSettings.PullDistance)
										{
											Walk.Facing(vector, units, (double)SpellRotation.RotationSettings.PullDistance, 0.5f, new string[]
											{
												"PvP"
											});
											continue;
										}
										if (_globals.KeyStatus["MoveForward"])
										{
											Key.Release("All");
										}
										SpellRotation.CombatPVP(@uint);
										continue;
									}
									else
									{
										Tools.Console("Unit is too far away.", "Orange", "richConsole", "frmMain", true);
									}
								}
							}
							else
							{
								Tools.Console("Unit died.", "Blue", "richConsole", "frmMain", true);
							}
						}
						else
						{
							Tools.Console("Unit lost.", "Blue", "richConsole", "frmMain", true);
						}
					}
				}
				IL_27D:
				Combat.PVPUnit = null;
				Combat.PVPAttackers = false;
				return;
			}
			goto IL_27D;
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00704744 File Offset: 0x00702944
		public static bool ReactToAttackersInGatherMode()
		{
			bool result = false;
			if (_globals.ModuleGather && !Walk.ProfileSettings.FlightMount && Walk.ProfileSettings.CombatMode == "Gather" && ObjectManager.GetAttackers.Count > 0)
			{
				Combat.UnitsToAttack.Clear();
				foreach (Units units in ObjectManager.GetAttackers)
				{
					Combat.UnitsToAttack.Add(units.GUID128, units);
				}
				Combat.OffensiveAttack();
				result = true;
			}
			Monitor.ReactToAttackersInGatherMode = false;
			return result;
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x007047F4 File Offset: 0x007029F4
		public static bool PlayerIsInRange(Vector3 PlayerPosition)
		{
			int num = Math.Max(Walk.ProfileSettings.DistanceWaypoint, SpellRotation.RotationSettings.PullDistance);
			return JackMath.Distance(PlayerPosition, true, true, true) <= (double)num;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0070482C File Offset: 0x00702A2C
		public static void DismountDruidInFlightFormOnAttackWhileGathering()
		{
			if (!Walk.CheckProfileSettings)
			{
				return;
			}
			if (!Walk.ProfileSettings.FlightMount)
			{
				return;
			}
			if (!ObjectManager.Me.IsDruid)
			{
				return;
			}
			if (ObjectManager.Me.IsInFlightForm)
			{
				Walk.Mount(false, false);
				Thread.Sleep(500);
				return;
			}
		}

		// Token: 0x040009B7 RID: 2487
		public static bool DefensiveAttackers = false;

		// Token: 0x040009B8 RID: 2488
		public static bool OffensiveAttackers = false;

		// Token: 0x040009B9 RID: 2489
		public static bool PVPAttackers = false;

		// Token: 0x040009BA RID: 2490
		public static bool WaitingForFleeingTarget = false;

		// Token: 0x040009BB RID: 2491
		public static Dictionary<UInt128, Units> UnitsToAttack = new Dictionary<UInt128, Units>();

		// Token: 0x040009BC RID: 2492
		public static Dictionary<UInt128, DateTime> NotInLOSTargets = new Dictionary<UInt128, DateTime>();

		// Token: 0x040009BD RID: 2493
		public static object _lock = new object();

		// Token: 0x040009BE RID: 2494
		public static bool DefensiveRuns = false;

		// Token: 0x040009BF RID: 2495
		public static bool DefensiveStop = false;

		// Token: 0x040009C0 RID: 2496
		public static bool OffensiveRuns = false;

		// Token: 0x040009C1 RID: 2497
		public static bool OffensiveStop = false;

		// Token: 0x040009C2 RID: 2498
		public static bool PVPRuns = false;

		// Token: 0x040009C3 RID: 2499
		public static bool PVPStop = false;

		// Token: 0x040009C4 RID: 2500
		public static Units PVPUnit = null;
	}
}
