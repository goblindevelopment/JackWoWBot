using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using Jack.ATH;
using Jack.Core;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000EF RID: 239
	public static class Walk
	{
		// Token: 0x0600165C RID: 5724 RVA: 0x0071512C File Offset: 0x0071332C
		public static void ApplySettings()
		{
			Walk.ProfileSettings = _globals.ProfileSettings[0];
			Walk.StayAndTurnOutdoor = Walk.ProfileSettings.StayAndTurnOutdoor;
			Walk.StayAndTurnIndoor = Walk.ProfileSettings.StayAndTurnIndoor;
			_globals.IsPVP = (_globals.IsInBattleground || Walk.ProfileSettings.CombatMode.StartsWith("PvP"));
			EventManager.ResetGlobalEvents();
			EventManager.SetGlobalEventsForMonitor();
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00715194 File Offset: 0x00713394
		public static void StartMonitoring()
		{
			Walk.ApplySettings();
			string combatMode = Walk.ProfileSettings.CombatMode;
			if (combatMode != "Ignore" && combatMode != "Gather" && !combatMode.StartsWith("PvP"))
			{
				if (!Combat.DefensiveRuns)
				{
					new Thread(new ThreadStart(Combat.MonitorDefensiveCombats))
					{
						IsBackground = true
					}.Start();
				}
			}
			else if (Combat.DefensiveRuns)
			{
				Combat.DefensiveStop = true;
			}
			if (Walk.ProfileSettings.Loot)
			{
				if (!Loot.Runs)
				{
					new Thread(new ThreadStart(Loot.Monitor))
					{
						IsBackground = true
					}.Start();
				}
			}
			else if (Loot.Runs)
			{
				Loot.Stop = true;
			}
			if ((!Walk.ProfileSettings.Skinning || !ObjectManager.Me.HasProfession("Skinning")) && !Loot.CanGatherMobs(0, ""))
			{
				if (Skinning.Runs)
				{
					Skinning.Stop = true;
				}
			}
			else if (_globals.ModuleGather && !Skinning.Runs)
			{
				new Thread(new ThreadStart(Skinning.Monitor))
				{
					IsBackground = true
				}.Start();
			}
			if (Walk.ProfileSettings.QuestItems.Count <= 0 && (!Walk.ProfileSettings.Herbalism || !ObjectManager.Me.HasProfession("Herbalism")) && (!Walk.ProfileSettings.Mining || !ObjectManager.Me.HasProfession("Mining")) && !_globals.TestEnv["TestMiningWithoutSkill"] && !_globals.TestEnv["TestHerbalismWithoutSkill"])
			{
				if (Nodes.Runs)
				{
					Nodes.Stop = true;
				}
			}
			else if (_globals.ModuleGather && !Nodes.Runs)
			{
				new Thread(new ThreadStart(Nodes.Monitor))
				{
					IsBackground = true
				}.Start();
			}
			if (MDL.NotifyMe && !SNS.NotificationsRuns)
			{
				new Thread(new ThreadStart(SNS.Notifications))
				{
					IsBackground = true
				}.Start();
			}
			if (!SpellRotation.CheckAlwaysActiveRuns && ObjectManager.HasAlwaysActiveInRotation)
			{
				new Thread(delegate()
				{
					SpellRotation.CheckAlwaysActive();
				})
				{
					IsBackground = true
				}.Start();
			}
			if (!SpellRotation.CheckHealRuns && ObjectManager.HasHealInRotation)
			{
				new Thread(new ThreadStart(SpellRotation.CheckHeal))
				{
					IsBackground = true
				}.Start();
			}
			if (!SpellRotation.CheckFoodDrinkRuns && ObjectManager.HasFoodDrinkInRotation)
			{
				new Thread(new ThreadStart(SpellRotation.CheckFoodDrink))
				{
					IsBackground = true
				}.Start();
			}
			if (!SpellRotation.CheckConjuringRuns && ObjectManager.HasConjuringInRotation)
			{
				new Thread(new ThreadStart(SpellRotation.CheckConjuring))
				{
					IsBackground = true
				}.Start();
			}
			if (!SpellRotation.CheckBuffRuns && (ObjectManager.HasBuffInRotation || ObjectManager.HasDispelInRotation))
			{
				new Thread(new ThreadStart(SpellRotation.CheckBuff))
				{
					IsBackground = true
				}.Start();
			}
			if (combatMode == "Offensive")
			{
				if (!Combat.OffensiveRuns)
				{
					new Thread(new ThreadStart(Combat.MonitorOffensiveCombats))
					{
						IsBackground = true
					}.Start();
				}
			}
			else if (Combat.OffensiveRuns)
			{
				Combat.OffensiveStop = true;
			}
			if (!combatMode.StartsWith("PvP"))
			{
				if (Combat.PVPRuns)
				{
					Combat.PVPStop = true;
				}
			}
			else if (!Combat.PVPRuns)
			{
				new Thread(new ThreadStart(Combat.MonitorPVPCombats))
				{
					IsBackground = true
				}.Start();
			}
			if (!Fly.Runs)
			{
				new Thread(new ThreadStart(Fly.Go))
				{
					IsBackground = true
				}.Start();
			}
			if (!AntiStuck.Runs)
			{
				new Thread(new ThreadStart(AntiStuck.Monitor))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0071553C File Offset: 0x0071373C
		public static void Go()
		{
			Walk.Runs = true;
			MDL.NotifyMe = Convert.ToBoolean(_globals.ModuleNotifications && (Settings.NotificationsDiscord || Settings.NotificationsPushover));
			Walk.ApplySettings();
			Key.Release("All");
			bool flag = false;
			Walk.CanMount = ObjectManager.Me.CanMount;
			Walk.CanFly = ObjectManager.Me.CanFly;
			Walk.CanFastFly = ObjectManager.Me.CanFastFly;
			ActionBar.SetSpellKeys();
			SpellRotation.CreateLists();
			_globals.NoCheck = false;
			Combat.UnitsToAttack.Clear();
			Combat.DefensiveAttackers = false;
			Combat.OffensiveAttackers = false;
			Combat.PVPUnit = null;
			Combat.PVPAttackers = false;
			Loot.List.Clear();
			Skinning.List.Clear();
			Nodes.List.Clear();
			if (EventManager.ClearEndOfRouteOnStartOrRestart)
			{
				EventManager.EndOfRoute.Clear();
			}
			EventManager.ClearEndOfRouteOnStartOrRestart = true;
			EventManager.Execution.Clear();
			EventManager.UseMyHearthstone = false;
			EventManager.HearthstoneEvent = null;
			EventManager.LoadProfileAfterHearthstone = false;
			Monitor.ReactToAttackersInGatherMode = false;
			Monitor.QuestsCompleted = false;
			Monitor.PetCallTryAgain = default(DateTime);
			Monitor.TriggerGlobalEvent = false;
			AntiStuck.Stuck = false;
			AntiStuck.StuckCounter = 0;
			AntiStuck.StuckCircle = false;
			Fly.Stop = false;
			Walk.LastClosestCrdTriggered = -1;
			Walk.ManualGhostRoute = false;
			Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
			if (Walk.IsInMeshMode)
			{
				Walk.DistanceToReach = 3.0;
			}
			Walk.StartMonitoring();
			Window.Activate(null);
			if (_globals.IsPVP)
			{
				Tools.Console("PvP Mode active.", "", "richConsole", "frmMain", true);
			}
			bool flag2 = false;
			if (!ObjectManager.Me.IsGhost)
			{
				if (!Walk.ProfileSettings.GroundMount && !Walk.ProfileSettings.FlightMount && ObjectManager.Me.IsMounted)
				{
					Walk.Mount(false, false);
				}
				else
				{
					Walk.Mount(true, false);
				}
				if (Walk.IsInMeshMode)
				{
					Walk.Facing(_globals.Waypoints[Walk.Counter], null, 1.0, 0.5f, new string[]
					{
						"Combat"
					});
				}
			}
			else
			{
				flag2 = Walk.LoadGhostRoute(false);
			}
			while (_globals.Ready && _globals.Start && MDL.CheckDungeon)
			{
				Vector3 positionVector = ObjectManager.Me.PositionVector3;
				float facing = ObjectManager.Me.Facing;
				Vector3 crd = default(Vector3);
				if (Walk.Counter > _globals.Waypoints.Count - 1)
				{
					Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
				}
				Vector3 vector = _globals.Waypoints[Walk.Counter];
				if (flag2)
				{
					if (ObjectManager.Me.IsGhost)
					{
						Walk.CorpseRun();
					}
					else
					{
						flag2 = false;
						if (_globals.IsPVP)
						{
							flag = true;
						}
					}
				}
				if (!flag2)
				{
					if (Monitor.QuestsCompleted)
					{
						if (Combat.OffensiveRuns)
						{
							Combat.OffensiveStop = true;
						}
						if (Nodes.Runs)
						{
							Nodes.Stop = true;
							Nodes.GatherableObjects.Clear();
						}
						Monitor.QuestsCompleted = false;
						Walk.ProfileSettings.CombatMode = "Defensive";
						Tools.Console("All Quests completed. Defensive Mode enabled.", "", "richConsole", "frmMain", true);
					}
					if (Monitor.PetCall)
					{
						Walk.CallOrRevivePet();
					}
					if (Monitor.PetFeed)
					{
						Walk.FeedPet(false);
					}
					if (Monitor.NeedEnchantment)
					{
						Walk.Enchant();
					}
					if (!SpellRotation.NeedInUse && EventManager.UseMyHearthstone)
					{
						EventManager.UseHearthstone();
					}
					if (EventManager.LoadProfileAfterHearthstone && EventManager.HearthstoneEvent != null)
					{
						EventManager.LoadProfileAfterHearthstone = false;
						EventManager.LoadProfile(EventManager.HearthstoneEvent, EventManager.HearthstoneEvent.UseHearthstoneProfile);
					}
					if (Combat.DefensiveAttackers)
					{
						Key.Release("All");
						Combat.DefensiveAttack();
						flag = true;
						continue;
					}
					if (Combat.PVPAttackers)
					{
						Key.Release("All");
						Combat.PVPAttack();
						flag = true;
						continue;
					}
					if (Monitor.TriggerGlobalEvent && Monitor.NeedGlobalEvent && !ObjectManager.Me.IsInCombat)
					{
						Monitor.TriggerGlobalEvent = false;
						EventManager.LoadRoute(Monitor.NeedGlobalEventEvent);
					}
				}
				if (AntiStuck.Stuck)
				{
					if (AntiStuck.StuckCounter == 3)
					{
						Walk.Counter++;
						if (Walk.Counter > _globals.Waypoints.Count - 1)
						{
							Walk.Counter = 0;
						}
						Walk.Facing(_globals.Waypoints[Walk.Counter], null, Walk.DistanceToReach, 0.5f, new string[]
						{
							"Combat"
						});
						AntiStuck.StuckCounter = 0;
						AntiStuck.Stuck = false;
						AntiStuck.ForceUnstuck = false;
						_globals.NoCheck = false;
					}
				}
				if (AntiStuck.StuckCircle)
				{
					Walk.AntiStuckCircle();
				}
				if (!flag2)
				{
					if (Walk.ProfileSettings.CombatMode == "Offensive" && Combat.OffensiveAttackers)
					{
						Combat.OffensiveAttack();
						if (!Combat.WaitingForFleeingTarget)
						{
							flag = true;
							continue;
						}
						Combat.WaitingForFleeingTarget = false;
						Tools.Console("Recount Targets...", "Blue", "richConsole", "frmMain", true);
						continue;
					}
					else
					{
						if (Monitor.ReactToAttackersInGatherMode)
						{
							Combat.ReactToAttackersInGatherMode();
						}
						if (Monitor.NeedSpell)
						{
							Walk.Check("Conjuring", new Action(SpellRotation.Conjuring), false);
							Walk.Check("Food/Drink", new Action(SpellRotation.FoodDrink), false);
							Walk.Check("Heal", new Action(SpellRotation.Heal), false);
							Walk.Check("Buff/Aura", new Action(SpellRotation.Buff), false);
							Walk.Check("AlwaysActive", new Action(SpellRotation.AlwaysActive), false);
						}
						if (Walk.ProfileSettings.Loot && Loot.LootableUnits.Count > 0 && (Walk.ProfileSettings.CombatMode == "Gather" || ObjectManager.GetAttackers.Count == 0) && (Walk.IsInMeshMode || Walk.CheckClosestCrd("Loot")))
						{
							Overlay.ClearGraphic("Run");
							Fly.Stop = true;
							Key.Release("All");
							Fly.MoveUp(Loot.LootableUnits, null, null);
							Loot.Get();
							Key.Release("All");
							Fly.Stop = false;
							Monitor.AutoDestroy = true;
							flag = true;
							continue;
						}
						if ((Walk.ProfileSettings.Skinning || Loot.CanGatherMobs(0, "")) && Skinning.SkinnableUnits.Count > 0 && (Walk.ProfileSettings.CombatMode == "Gather" || ObjectManager.GetAttackers.Count == 0) && (Walk.IsInMeshMode || Walk.CheckClosestCrd("Skinning")))
						{
							Overlay.ClearGraphic("Run");
							Fly.Stop = true;
							Key.Release("All");
							Fly.MoveUp(Skinning.SkinnableUnits, null, null);
							Skinning.Get();
							Key.Release("All");
							Fly.Stop = false;
							flag = true;
							continue;
						}
						if (((Walk.ProfileSettings.QuestItems.Count > 0 && Nodes.Runs) || Walk.ProfileSettings.Mining || Walk.ProfileSettings.Herbalism || _globals.TestEnv["TestMiningWithoutSkill"] || _globals.TestEnv["TestHerbalismWithoutSkill"]) && Nodes.GatherableObjects.Count > 0 && (Walk.ProfileSettings.CombatMode == "Gather" || ObjectManager.GetAttackers.Count == 0) && (Walk.IsInMeshMode || Walk.CheckClosestCrd("Gather")))
						{
							Overlay.ClearGraphic("Run");
							Fly.Stop = true;
							Key.Release("All");
							Fly.MoveUp(Nodes.GatherableObjects, null, null);
							Nodes.Get();
							Key.Release("All");
							Fly.Stop = false;
							flag = true;
							continue;
						}
					}
				}
				if (flag)
				{
					flag = false;
					crd = _globals.Waypoints[Walk.Counter];
					Walk.Counter = Walk.LocateBestWaypoint(_globals.Waypoints, positionVector, vector, facing);
					if (Walk.IsInMeshMode)
					{
						Walk.Mount(true, false);
						Walk.Facing(_globals.Waypoints[Walk.Counter], null, Walk.DistanceToReach, 0.5f, new string[]
						{
							"Combat"
						});
						if (ObjectManager.HasEvent(crd) != null)
						{
							Tools.Console("Trigger last event...", "", "richConsole", "frmMain", true);
							EventManager.Start(crd);
						}
						if (Walk.Counter >= _globals.Waypoints.Count - 1)
						{
							Walk.Counter = 0;
						}
						else
						{
							Walk.Counter++;
						}
						vector = _globals.Waypoints[Walk.Counter];
					}
				}
				Walk.Mount(true, false);
				double num = JackMath.Distance(vector, true, true, false);
				float turn = Angle.FacingCenter(positionVector, vector, facing);
				if (num <= Walk.DistanceToReach)
				{
					if (ObjectManager.HasEvent(vector) != null)
					{
						EventManager.Start(vector);
					}
					if (Walk.Counter < _globals.Waypoints.Count - 1)
					{
						Walk.Counter++;
					}
					else
					{
						Walk.Counter = 0;
						if (EventManager.EndOfRoute.Count > 0)
						{
							EventManager.DoEndOfRoute();
						}
					}
				}
				Walk.TurnOrMove(turn);
				Walk.Direction(turn, true);
				Thread.Sleep(50);
			}
			Key.Release("All");
			frmMain.Stop();
			Overlay.ClearGraphic("Run");
			Walk.Runs = false;
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x00715E00 File Offset: 0x00714000
		private static void TurnOrMove(float Turn)
		{
			if (PlayerMe.IsIndoor)
			{
				Walk.DistanceToReach = 1.0;
				if (Walk.StayAndTurnAt != Walk.StayAndTurnIndoor)
				{
					Walk.StayAndTurnAt = Walk.StayAndTurnIndoor;
				}
			}
			else
			{
				if (Walk.StayAndTurnAt != Walk.StayAndTurnOutdoor)
				{
					Walk.StayAndTurnAt = Walk.StayAndTurnOutdoor;
				}
				Walk.DistanceToReach = 3.0;
			}
			if (_globals.KeyStatus["MoveForward"])
			{
				if (Turn < Walk.StayAndTurnAt - Walk.StayAndTurnAt * 2f || Turn > Walk.StayAndTurnAt)
				{
					Key.Release("MoveForward");
					return;
				}
				if (!ObjectManager.Me.IsMoving)
				{
					if (_globals.KeyStatus["MoveForward"] && !Window.IsForeground((IntPtr)0))
					{
						Key.Release("MoveForward");
						Thread.Sleep(30);
					}
					Key.Press("MoveForward");
				}
			}
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00715EDC File Offset: 0x007140DC
		public static void Direction(float Turn, bool Walk = true)
		{
			if (Turn < 0f)
			{
				Turn = JackMath.Absolute(Turn, true);
				if (_globals.KeyStatus["TurnRight"])
				{
					Key.Release("TurnRight");
				}
				if (!_globals.KeyStatus["TurnLeft"] && (_globals.KeyStatus["MoveForward"] || !Walk) && Turn < 0.2f && Turn > 0.1f)
				{
					Key.Press("TurnLeft");
					Thread.Sleep((int)((double)(Math.Abs(Turn) * 1328f) * 3.141592653589793 / 10.0));
					Key.Release("TurnLeft");
					return;
				}
				if (!_globals.KeyStatus["TurnLeft"] && Turn > 0.2f)
				{
					Key.Press("TurnLeft");
					return;
				}
				if (Turn <= 0.2f && Walk && !_globals.KeyStatus["MoveForward"])
				{
					Key.Press("MoveForward");
					return;
				}
			}
			else
			{
				if (_globals.KeyStatus["TurnLeft"])
				{
					Key.Release("TurnLeft");
				}
				if (!_globals.KeyStatus["TurnRight"] && (_globals.KeyStatus["MoveForward"] || !Walk) && Turn < 0.2f && Turn > 0.1f)
				{
					Key.Press("TurnRight");
					Thread.Sleep((int)((double)(Turn * 1328f) * 3.141592653589793 / 10.0));
					Key.Release("TurnRight");
					return;
				}
				if (!_globals.KeyStatus["TurnRight"] && Turn > 0.2f)
				{
					Key.Press("TurnRight");
					return;
				}
				if (Turn <= 0.2f && Walk && !_globals.KeyStatus["MoveForward"])
				{
					Key.Press("MoveForward");
				}
			}
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x007160B0 File Offset: 0x007142B0
		public static object[] TypeOfTarget(object Target)
		{
			Vector3 vector = default(Vector3);
			Units units = null;
			if (Target.GetType() == typeof(Vector3))
			{
				vector = (Vector3)Target;
			}
			else
			{
				object @lock;
				if (Target.GetType() == typeof(UInt128))
				{
					UInt128 guid = (UInt128)Target;
					@lock = ObjectManager._lock;
					lock (@lock)
					{
						units = ObjectManager.GetUnitByGUID(guid);
						vector = units.PositionVector3;
						goto IL_A0;
					}
				}
				units = (Units)Target;
				@lock = ObjectManager._lock;
				lock (@lock)
				{
					vector = units.PositionVector3;
				}
			}
			IL_A0:
			return new object[]
			{
				units,
				vector
			};
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0071618C File Offset: 0x0071438C
		public static bool GoTo(object Target, double UntilDistance = 0.0, float UntilAngle = 0f, string[] Options = null)
		{
			object[] array = Walk.TypeOfTarget(Target);
			Units unit = (Units)array[0];
			Vector3 vector = (Vector3)array[1];
			bool result;
			if ((result = Walk.Facing(vector, unit, UntilDistance, UntilAngle, Options)) && JackMath.Distance(vector, true, true, true) > UntilDistance)
			{
				Walk.Move(true);
				result = Walk.Facing(vector, unit, UntilDistance, UntilAngle, Options);
			}
			Key.Release("All");
			return result;
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x007161E8 File Offset: 0x007143E8
		public static bool Facing(Vector3 TargetPosition, Units Unit = null, double UntilDistance = 0.0, float UntilAngle = 0f, string[] Options = null)
		{
			bool flag = true;
			int num = 0;
			if (Options != null)
			{
				num = Options.Count<string>();
			}
			string name = Tools.RandomTimer("Blacklist");
			bool flag2 = false;
			int num2 = 0;
			int num3 = 0;
			bool flag3 = Convert.ToBoolean(ObjectManager.Me.IsDead || ObjectManager.Me.IsGhost);
			bool flag4 = Walk.IsInMeshMode;
			int num4 = 0;
			int num5 = 0;
			List<Vector3> list = new List<Vector3>();
			string name2 = "N/A";
			if (Unit != null)
			{
				name2 = Unit.Name;
				num2 = SpellRotation.RotationSettings.PullDistance + 10;
				num3 = SpellRotation.RotationSettings.PullDistance + 10;
			}
			if (UntilAngle > 0f)
			{
				Walk.StayAndTurnAt = UntilAngle;
			}
			else if (!PlayerMe.IsIndoor)
			{
				if (Walk.StayAndTurnAt != Walk.StayAndTurnOutdoor)
				{
					Walk.StayAndTurnAt = Walk.StayAndTurnOutdoor;
				}
			}
			else if (Walk.StayAndTurnAt != Walk.StayAndTurnIndoor)
			{
				Walk.StayAndTurnAt = Walk.StayAndTurnIndoor;
			}
			while (_globals.Start)
			{
				if (!_globals.NoCheck)
				{
					if (flag3 || !Monitor.NeedSomething || (num != 0 && Options.Contains("AlwaysActiveWay")))
					{
						if (AntiStuck.StuckCircle)
						{
							Walk.AntiStuckCircle();
						}
						Vector3 positionVector = ObjectManager.Me.PositionVector3;
						float facing = ObjectManager.Me.Facing;
						bool isIndoor = PlayerMe.IsIndoor;
						double num6;
						bool flag5;
						if (Unit != null)
						{
							TargetPosition = Unit.PositionVector3;
							num6 = JackMath.Distance(TargetPosition, true, true, true);
							flag5 = true;
						}
						else
						{
							num6 = JackMath.Distance(TargetPosition, true, true, true);
							flag5 = false;
						}
						if (!flag3 && num > 0)
						{
							foreach (string a in Options)
							{
								if (a == "PlayersAroundGather")
								{
									if (!_globals.IsRetail && ObjectManager.GetPlayersAround(TargetPosition, "Gather", 8).Count > 0)
									{
										flag = false;
										break;
									}
								}
								else if (a == "ElitesAroundGather")
								{
									int count = ObjectManager.GetElitesAround(TargetPosition, 40).Count;
									if (count > 0)
									{
										Tools.Console("Canceled. " + count.ToString() + " elite found.", "Orange", "richConsole", "frmMain", true);
										flag = false;
										break;
									}
								}
								else if (!(a == "Combat"))
								{
									if (!(a == "Blacklist"))
									{
										if (a == "Dismount")
										{
											if (num6 <= (double)num2)
											{
												Walk.Mount(false, true);
											}
										}
										else if (!(a == "RunBack"))
										{
											if (!(a == "AlwaysActiveWay"))
											{
												if (a == "RelatedToAnotherPlayer" && Unit != null && Unit.IsRelatedToAnotherPlayer)
												{
													flag = false;
													break;
												}
											}
											else if (num6 <= (double)num3)
											{
												SpellRotation.AlwaysActiveOnMyWayToTarget();
											}
										}
										else if (Unit != null && Unit.IsRunningBack)
										{
											flag = false;
											break;
										}
									}
									else if (flag2)
									{
										if (Timer.Check(name) == 0)
										{
											if (!(Walk.ProfileSettings.CombatMode == "Gather") || ObjectManager.GetAttackers.Count <= 0)
											{
												Walk.AddToBlacklist(TargetPosition, name2);
												flag = false;
												break;
											}
											flag2 = false;
											Tools.Console("Restarted Blacklist Timer because of Combat Situation.", "Orange", "richConsole", "frmMain", true);
										}
									}
									else
									{
										Timer.Set(name, 15000);
										flag2 = true;
									}
								}
								else
								{
									if (Walk.ProfileSettings.CombatMode.StartsWith("PvP") && (ObjectManager.GetAttackers.Count > 0 || Combat.PVPAttackers))
									{
										flag = false;
										break;
									}
									if (Walk.ProfileSettings.CombatMode != "Ignore" && Walk.ProfileSettings.CombatMode != "Gather" && (ObjectManager.GetAttackers.Count > 0 || Combat.OffensiveAttackers))
									{
										flag = false;
										break;
									}
								}
							}
							if (!flag)
							{
								break;
							}
						}
						if (UntilDistance > 0.0 && num6 > UntilDistance && _globals.KeyStatus["MoveForward"] && !ObjectManager.Me.IsMoving)
						{
							Key.Press("MoveForward");
						}
						if (flag4)
						{
							if (num6 > (double)(SpellRotation.RotationSettings.PullDistance + 20))
							{
								Walk.Mount(true, false);
							}
							if (num5 == 0)
							{
								foreach (Vector3 item in Pathfinder.Navigate(ObjectManager.Me.PositionVector3, TargetPosition, false, -1))
								{
									list.Add(item);
									Overlay.MeshPath.Add(item);
								}
								if (list.Count > 0)
								{
									num5 = list.Count - 1;
									Overlay.ShowMeshPath = true;
									if (num > 0 && Options.Contains("MeshFacing"))
									{
										Angle.FaceMe(positionVector, list[0], facing, null, false, 0.5f);
									}
								}
								else
								{
									Tools.Console("Couldn't find Mesh Path. Try another way...", "Red", "richConsole", "frmMain", true);
								}
							}
							else if (flag5 && num5 > 0)
							{
								list[num5] = TargetPosition;
								object lockOverlay = ObjectManager._lockOverlay;
								lock (lockOverlay)
								{
									Overlay.MeshPath[num5] = TargetPosition;
								}
								if (num6 <= 10.0)
								{
									flag4 = false;
								}
							}
							if (list.Count > 0)
							{
								if (JackMath.Distance(list[num4], true, true, false) <= Walk.DistanceToReach)
								{
									if (num4 == num5)
									{
										break;
									}
									num4++;
								}
								float num7 = Angle.FacingCenter(positionVector, list[num4], facing);
								Walk.TurnOrMove(num7);
								Walk.Direction(num7, true);
								if (num6 <= UntilDistance)
								{
									break;
								}
							}
							else
							{
								flag4 = false;
							}
						}
						else
						{
							float num7 = Angle.FacingCenter(positionVector, TargetPosition, facing);
							Walk.Direction(num7, true);
							if (num7 > Walk.StayAndTurnAt - Walk.StayAndTurnAt * 2f && num7 < Walk.StayAndTurnAt && (UntilDistance == 0.0 || num6 <= UntilDistance))
							{
								break;
							}
						}
						Thread.Sleep(10);
						continue;
					}
					flag = false;
				}
				IL_5F2:
				Overlay.ShowMeshPath = false;
				Overlay.MeshPath.Clear();
				if (AntiStuck.Stuck)
				{
					if (AntiStuck.StuckCounter == 3)
					{
						flag = false;
					}
				}
				return flag;
			}
			goto IL_5F2;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x0071682C File Offset: 0x00714A2C
		public static void Move(bool move)
		{
			bool isMoving = ObjectManager.Me.IsMoving;
			if (move && !isMoving)
			{
				while (_globals.Start)
				{
					if (_globals.NoCheck)
					{
						break;
					}
					if (ObjectManager.Me.IsMoving)
					{
						return;
					}
					Key.Press("MoveForward");
					Thread.Sleep(100);
				}
			}
			else if (!move && isMoving)
			{
				while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.IsMoving)
				{
					Key.Release("MoveForward");
					Thread.Sleep(100);
				}
			}
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x007168B0 File Offset: 0x00714AB0
		public static void Mount(bool Mount, bool Force = false)
		{
			if ((!Mount || Walk.ProfileSettings.GroundMount || Walk.ProfileSettings.FlightMount) && (Force || ((!Mount || Walk.CanMount) && !Combat.DefensiveAttackers && !Combat.OffensiveAttackers && !Combat.PVPAttackers)) && !Walk.MountDelay && (!PlayerMe.IsIndoor || ObjectManager.IsInCity))
			{
				if (_globals.IsClassicEra && ObjectManager.Me.IsSwimming)
				{
					return;
				}
				bool isMounted = ObjectManager.Me.IsMounted;
				string mountType = Walk.MountType;
				if (!Mount)
				{
					if (!Mount && isMounted && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir))
					{
						Tools.Console("Dismount -> " + mountType + ".", "Blue", "richConsole", "frmMain", true);
						Key.Press(mountType);
						Thread.Sleep(35);
						Key.Release(mountType);
						Thread.Sleep(250);
						Tools.Console("Dismounted -> " + mountType + ".", "Blue", "richConsole", "frmMain", true);
					}
				}
				else if (!isMounted && !ObjectManager.Me.IsInCombat && !ObjectManager.Me.IsGhost)
				{
					if (Monitor.NeedSomething)
					{
						return;
					}
					Tools.Console("Mount -> " + mountType + ".", "Blue", "richConsole", "frmMain", true);
					if (_globals.IsRetail && (ObjectManager.Me.IsCasting || ObjectManager.Me.IsChanneling))
					{
						Key.Press("MoveForward");
						Thread.Sleep(50);
					}
					Key.Release("All");
					Thread.Sleep(250);
					Key.Press(mountType);
					Thread.Sleep(30);
					Key.Release(mountType);
					Thread.Sleep(Walk.ProfileSettings.ExpertMountDelay);
					while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.IsCasting && !ObjectManager.Me.IsMounted && !Combat.DefensiveAttackers)
					{
						if (Monitor.NeedSomething)
						{
							Key.Press("MoveForward");
							Thread.Sleep(50);
							Key.Release("MoveForward");
							return;
						}
						Thread.Sleep(250);
					}
					if (ObjectManager.Me.IsMounted)
					{
						Tools.Console("Mounted -> " + mountType + ".", "Blue", "richConsole", "frmMain", true);
					}
					else
					{
						Walk.MountDelay = true;
						new Thread(new ThreadStart(Walk.MountWait))
						{
							IsBackground = true
						}.Start();
					}
					if (_globals.Start && !_globals.NoCheck && ObjectManager.Me.IsMounted)
					{
						Angle.FaceMe(ObjectManager.Me.PositionVector3, _globals.Waypoints[Walk.Counter], ObjectManager.Me.Facing, null, false, 0.5f);
						return;
					}
				}
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00716B98 File Offset: 0x00714D98
		public static string MountType
		{
			get
			{
				if (Walk.ProfileSettings.GroundMount)
				{
					return "GroundMount";
				}
				if (!Walk.ProfileSettings.FlightMount)
				{
					return "GroundMount";
				}
				return "FlightMount";
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00716BD0 File Offset: 0x00714DD0
		private static void MountWait()
		{
			Tools.Console("Can't mount here. Try again in a moment...", "Orange", "richConsole", "frmMain", true);
			Thread.Sleep(2000);
			Walk.MountDelay = false;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00716C08 File Offset: 0x00714E08
		public static void AntiStuckCircle()
		{
			Tools.Console("I get dizzy...", "Orange", "richConsole", "frmMain", true);
			Key.Release("All");
			Walk.Counter++;
			if (Walk.Counter > _globals.Waypoints.Count - 1)
			{
				Walk.Counter = 0;
			}
			Angle.FaceMe(ObjectManager.Me.PositionVector3, _globals.Waypoints[Walk.Counter], ObjectManager.Me.Facing, null, false, 0.5f);
			AntiStuck.StuckCircle = false;
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00716C94 File Offset: 0x00714E94
		public static bool IsInMeshMode
		{
			get
			{
				return Walk.ProfileSettings.ModeMesh && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00716CC8 File Offset: 0x00714EC8
		public static string FleeingTarget(Units Unit)
		{
			object @lock = ObjectManager._lock;
			string result;
			lock (@lock)
			{
				if (Walk.ProfileSettings.FollowFleeingTarget)
				{
					while (_globals.Start && !_globals.NoCheck && Unit.IsAlive && Unit.IsFleeing)
					{
						Walk.Facing(Unit.PositionVector3, Unit, (double)SpellRotation.RotationSettings.PullDistance, 0.5f, null);
						Thread.Sleep(100);
					}
					Key.Release("All");
					if (!Unit.IsDead)
					{
						result = "follow";
					}
					else
					{
						result = "dead";
					}
				}
				else
				{
					int count = ObjectManager.GetAttackers.Count;
					if (Combat.UnitsToAttack.Count <= 1 && count <= 0)
					{
						Tools.Console("Waiting for fleeing Target...", "Blue", "richConsole", "frmMain", true);
						while (_globals.Start && !_globals.NoCheck && Unit.IsAlive && Unit.IsFleeing)
						{
							Thread.Sleep(250);
						}
						Thread.Sleep(2000);
						result = "wait";
					}
					else if (count == 1)
					{
						if (!_globals.IsInDungeon)
						{
							result = "follow";
						}
						else
						{
							while (_globals.Start && !_globals.NoCheck && Unit.IsAlive && Unit.IsFleeing && count == 1)
							{
								count = ObjectManager.GetAttackers.Count;
								Thread.Sleep(250);
							}
							Thread.Sleep(2000);
							result = "wait";
						}
					}
					else
					{
						result = "next";
					}
				}
			}
			return result;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00716E5C File Offset: 0x0071505C
		public static bool Check(string ToCheck, Action Method, bool CheckOnly = false)
		{
			if (SpellRotation.Need[ToCheck] == 1)
			{
				if (CheckOnly)
				{
					return true;
				}
				if (SpellRotation.CanCastWhileWalk[ToCheck])
				{
					SpellRotation.Need[ToCheck] = 2;
					new Thread(delegate()
					{
						Method();
					})
					{
						IsBackground = true
					}.Start();
				}
				else
				{
					Key.Release("All");
					Method();
				}
			}
			return false;
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00716ED8 File Offset: 0x007150D8
		public static int GetClosestCrd(List<Vector3> CrdList)
		{
			int num = -1;
			int result = 0;
			double num2 = 0.0;
			foreach (Vector3 position in CrdList)
			{
				num++;
				double num3 = JackMath.Distance(position, true, true, true);
				if (num3 > 0.0 && (num2 == 0.0 || num3 < num2))
				{
					num2 = num3;
					result = num;
				}
			}
			return result;
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00716F60 File Offset: 0x00715160
		public static int GetClosestCrd(List<Vector3> CrdList, Vector3 To, int MaxNext = 0)
		{
			int num = -1;
			int result = 0;
			double num2 = 0.0;
			if (MaxNext <= 0)
			{
				using (List<Vector3>.Enumerator enumerator = CrdList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Vector3 from = enumerator.Current;
						num++;
						double num3 = JackMath.Distance(from, To, true, true, true);
						if (num3 > 0.0)
						{
							if (num2 != 0.0)
							{
								if (num3 >= num2)
								{
									continue;
								}
							}
							num2 = num3;
							result = num;
						}
					}
					return result;
				}
			}
			num = Walk.Counter;
			for (int i = 0; i < MaxNext; i++)
			{
				if (num > CrdList.Count - 1)
				{
					num = 0;
				}
				double num4 = JackMath.Distance(CrdList[num], To, true, true, true);
				if (num4 > 0.0)
				{
					if (num2 != 0.0)
					{
						if (num4 >= num2)
						{
							goto IL_BF;
						}
					}
					num2 = num4;
					result = num;
				}
				IL_BF:
				num += i;
			}
			return result;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0071704C File Offset: 0x0071524C
		public static bool CheckClosestCrd(string Mode)
		{
			Units units = null;
			Objects objects = null;
			Vector3 vector = default(Vector3);
			if (Mode == "Loot")
			{
				units = ObjectManager.GetClosestUnit(Loot.LootableUnits);
			}
			else if (!(Mode == "Skinning"))
			{
				if (Mode == "Gather")
				{
					objects = ObjectManager.GetClosestObject(Nodes.GatherableObjects);
				}
			}
			else
			{
				units = ObjectManager.GetClosestUnit(Skinning.SkinnableUnits);
			}
			if (units != null)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					vector = units.PositionVector3;
					goto IL_A8;
				}
			}
			if (objects != null)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					vector = objects.PositionVector3;
				}
			}
			IL_A8:
			if (vector != default(Vector3))
			{
				if ((!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && JackMath.Distance(vector, true, true, true) <= 30.0)
				{
					return true;
				}
				int closestCrd = Walk.GetClosestCrd(_globals.Waypoints, vector, 8);
				if (closestCrd > -1)
				{
					Overlay.SetGraphic(_globals.Waypoints[closestCrd], vector, "Run", "WhiteTransparent", "", false);
					if (Walk.LastClosestCrdTriggered == closestCrd)
					{
						return true;
					}
					if (JackMath.Distance(_globals.Waypoints[closestCrd], true, true, true) <= 5.0)
					{
						Walk.LastClosestCrdTriggered = closestCrd;
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x007171CC File Offset: 0x007153CC
		public static int GetBestCrd(List<Vector3> CrdList)
		{
			int num = Walk.Counter;
			if (Walk.ProfileSettings.WaypointMode == "Best" || Walk.ProfileSettings.WaypointMode == "Closest")
			{
				num = Walk.GetClosestCrd(CrdList);
				if (!Walk.smethod_0(Walk.Counter, num))
				{
					num = Walk.Counter;
				}
				if (Walk.ProfileSettings.WaypointMode == "Best" && !PlayerMe.IsInDungeon && !PlayerMe.IsIndoor)
				{
					int num2 = CrdList.Count - 1;
					int num3 = num;
					using (List<Vector3>.Enumerator enumerator = CrdList.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Vector3 to = enumerator.Current;
							if (num3 >= num2)
							{
								num3 = 0;
							}
							Vector3 position = CrdList[num3];
							if (Walk.smethod_0(Walk.Counter, num3) && JackMath.Distance(position, true, true, true) <= 10.0 && !JackMath.IsBehind(to, false))
							{
								return num3;
							}
							num3++;
						}
						return num;
					}
					int result;
					return result;
				}
			}
			return num;
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x007172E8 File Offset: 0x007154E8
		private static int LocateBestWaypoint(List<Vector3> CrdList, Vector3 From, Vector3 To, float OriginRotation)
		{
			int bestCrd = Walk.GetBestCrd(CrdList);
			if (!Walk.ProfileSettings.FlightMount && !Walk.IsInMeshMode && JackMath.IsBehind(CrdList[bestCrd], false))
			{
				Key.Release("All");
				Angle.FaceMe(From, To, OriginRotation, null, false, 0.5f);
			}
			return bestCrd;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00717338 File Offset: 0x00715538
		public static Events GetClosestRoute(string RouteType)
		{
			Events events = null;
			if (_globals.Events.Count > 0)
			{
				Dictionary<Vector3, Events> dictionary = new Dictionary<Vector3, Events>();
				foreach (Events events2 in _globals.Events)
				{
					if (events2.RouteType == RouteType && events2.Route.Count > 0)
					{
						Vector3 vector = default(Vector3);
						if (!(events2.RouteType == "Ghost"))
						{
							vector = events2.Route.LastOrDefault<Vector3>();
						}
						else if (!events2.GhostDirectionPathToGraveyard)
						{
							vector = events2.Route.FirstOrDefault<Vector3>();
						}
						else
						{
							vector = events2.Route.LastOrDefault<Vector3>();
						}
						if (vector != default(Vector3) && JackMath.Distance(vector, true, true, true) <= 100.0)
						{
							dictionary.Add(events2.Route.LastOrDefault<Vector3>(), events2);
						}
					}
				}
				if (dictionary.Count > 0)
				{
					List<Vector3> list = new List<Vector3>();
					foreach (KeyValuePair<Vector3, Events> keyValuePair in dictionary)
					{
						list.Add(keyValuePair.Key);
					}
					Vector3 vector2 = list[Walk.GetClosestCrd(list)];
					if (vector2 != default(Vector3))
					{
						events = dictionary[vector2];
						Tools.Console(string.Concat(new string[]
						{
							"Closest ",
							events.RouteType,
							" Route: \"",
							events.Name,
							"\"."
						}), "Blue", "richConsole", "frmMain", true);
					}
				}
			}
			return events;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x0071751C File Offset: 0x0071571C
		public static bool IsOnWhitelist(int DisplayID = 0, string Name = "")
		{
			return Walk.ProfileSettings.WhitelistNameOrID.Count != 0 && (Walk.ProfileSettings.WhitelistNameOrID.Contains(DisplayID.ToString()) || (Name.Length > 0 && Walk.ProfileSettings.WhitelistNameOrID.Contains(Name)));
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00717574 File Offset: 0x00715774
		public static bool IsOnBlacklist(Vector3 Position, int DisplayID = 0, string Name = "")
		{
			Dictionary<string, Vector3> blacklist;
			if (_globals.IsPremiumProfile)
			{
				blacklist = _globals.PremiumLoadedProfileSettings.Blacklist;
			}
			else
			{
				blacklist = Walk.ProfileSettings.Blacklist;
			}
			object lockBlacklist = Walk._lockBlacklist;
			bool result;
			lock (lockBlacklist)
			{
				if (!blacklist.Values.Contains(Position))
				{
					goto IL_4F;
				}
				result = true;
			}
			return result;
			IL_4F:
			return Walk.ProfileSettings.BlacklistNameOrID.Contains(DisplayID.ToString()) || Walk.ProfileSettings.BlacklistNameOrID.Contains(Name);
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00717610 File Offset: 0x00715810
		public static void AddToBlacklist(Vector3 Position, string Name = "")
		{
			if (_globals.Start)
			{
				Dictionary<string, Vector3> blacklist;
				if (_globals.IsPremiumProfile)
				{
					blacklist = _globals.PremiumLoadedProfileSettings.Blacklist;
				}
				else
				{
					blacklist = Walk.ProfileSettings.Blacklist;
				}
				if (!blacklist.Values.Contains(Position))
				{
					Tools.Console("\"" + Name + "\" is too far away or not reachable. Added Position to Blacklist.", "Orange", "richConsole", "frmMain", true);
					object lockBlacklist = Walk._lockBlacklist;
					lock (lockBlacklist)
					{
						blacklist.Add(Name + " [" + Walk.BlacklistID(blacklist) + "]", Position);
						if (_globals.IsPremiumProfile)
						{
							Json.SavePremiumSettings();
							return;
						}
						Json.SaveCurrentProfile(Settings.SelectedProfile);
						return;
					}
				}
				Tools.Console("Position of \"" + Name + "\" is already on Blacklist.", "Orange", "richConsole", "frmMain", true);
			}
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00717700 File Offset: 0x00715900
		public static string BlacklistID(Dictionary<string, Vector3> Blacklist)
		{
			string text = "";
			bool flag = false;
			do
			{
				text = Tools.RandomID.ToString();
				flag = false;
				foreach (KeyValuePair<string, Vector3> keyValuePair in Blacklist)
				{
					if (keyValuePair.Key.Contains(text))
					{
						flag = true;
						break;
					}
				}
			}
			while (flag);
			return text;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00717778 File Offset: 0x00715978
		private static bool LoadGhostRoute(bool Retry = false)
		{
			if (Walk.BattlegroundGhostBehaviour())
			{
				return true;
			}
			if (Walk.CheckCorpsePosition)
			{
				Events closestRoute = Walk.GetClosestRoute("Ghost");
				if (closestRoute != null)
				{
					EventManager.LoadRoute(closestRoute);
					Tools.Console("Closest manual Ghost Route found.", "Green", "richConsole", "frmMain", true);
					Walk.ManualGhostRoute = true;
					return true;
				}
				Tools.Console("Couldn't find any manual Ghost Route.", "Orange", "richConsole", "frmMain", true);
				if (!Walk.IsInMeshMode)
				{
					Tools.Console("Auto-Navigation disabled. Couldn't create a path.", "Red", "richConsole", "frmMain", true);
					return false;
				}
				Tools.Console("Generating Path...", "Orange", "richConsole", "frmMain", true);
				if (Walk.IsInMeshMode)
				{
					List<Vector3> list = Pathfinder.Navigate(ObjectManager.Me.PositionVector3, PlayerMe.CorpsePositionVector3, false, -1);
					bool flag = true;
					if (list.Count == 0)
					{
						flag = false;
						int num = 0;
						while (num < 3 && _globals.Start)
						{
							Tools.Console("Couldn't create a Path. Retry in 2 sec... (" + (num + 1).ToString() + "/3)", "Orange", "richConsole", "frmMain", true);
							Thread.Sleep(2000);
							if (Pathfinder.Navigate(ObjectManager.Me.PositionVector3, PlayerMe.CorpsePositionVector3, false, -1).Count > 0)
							{
								flag = true;
								break;
							}
							num++;
						}
						if (!flag)
						{
							Tools.Console("Couldn't create a Ghost Route.", "Red", "richConsole", "frmMain", true);
						}
					}
					return flag;
				}
			}
			return false;
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x007178E4 File Offset: 0x00715AE4
		private static void CorpseRun()
		{
			if (Walk.BattlegroundGhostBehaviour())
			{
				return;
			}
			if (Walk.CheckCorpsePosition)
			{
				if (Walk.ManualGhostRoute)
				{
					Vector3 vector = default(Vector3);
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						vector = PlayerMe.CorpsePositionVector3;
					}
					if (!_globals.ModuleDungeon || !Monitor.DiedInDungeon)
					{
						if (vector != default(Vector3) && JackMath.Distance(vector, true, true, true) <= 30.0)
						{
							Walk.Revive();
							return;
						}
						if (JackMath.Distance(vector, true, true, true) <= 50.0)
						{
							Tools.Console("Generating path to corpse...", "Blue", "richConsole", "frmMain", true);
							Walk.GoTo(PlayerMe.CorpsePositionVector3, 30.0, 0f, null);
							Walk.Revive();
							return;
						}
					}
				}
				else if (Walk.IsInMeshMode)
				{
					Tools.Console("Go to my corpse...", "Blue", "richConsole", "frmMain", true);
					Walk.GoTo(PlayerMe.CorpsePositionVector3, 30.0, 0f, null);
					Walk.Revive();
				}
			}
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x00717A20 File Offset: 0x00715C20
		private static void Revive()
		{
			Tools.Console("Revive...", "Blue", "richConsole", "frmMain", true);
			Key.Release("All");
			Addon.LUA("_dead()", "0", false, true);
			Json.LoadProfile(Settings.SelectedProfile, false, false, _globals.IsPremiumProfile);
			Walk.Counter = Walk.GetBestCrd(_globals.Waypoints);
			SNS.NotifyGhost("Revived");
			Thread.Sleep(1000);
			if (ObjectManager.GetAttackers.Count == 0 && Monitor.NeedSpell)
			{
				Tools.Console("Refresh first...", "Blue", "richConsole", "frmMain", true);
				Walk.Check("Conjuring", new Action(SpellRotation.Conjuring), false);
				Walk.Check("Food/Drink", new Action(SpellRotation.FoodDrink), false);
				Walk.Check("Heal", new Action(SpellRotation.Heal), false);
				Walk.Check("Buff/Aura", new Action(SpellRotation.Buff), false);
				Walk.Check("AlwaysActive", new Action(SpellRotation.AlwaysActive), false);
			}
			Thread.Sleep(1000);
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x00717B4C File Offset: 0x00715D4C
		private static bool BattlegroundGhostBehaviour()
		{
			if (PlayerMe.IsInBattleground)
			{
				if (ObjectManager.Me.IsGhost)
				{
					Tools.Console("Battleground -> Ghost Mode -> Waiting until revived...", "Blue", "richConsole", "frmMain", true);
					while (_globals.Start && ObjectManager.Me.IsGhost)
					{
						Thread.Sleep(250);
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x00717BA8 File Offset: 0x00715DA8
		private static bool CheckCorpsePosition
		{
			get
			{
				if (!PlayerMe.CorpsePositionVector3.ToString().Contains("E"))
				{
					return true;
				}
				Tools.Console("Corpse Position could not be found.", "Red", "richConsole", "frmMain", true);
				frmMain.Stop();
				return false;
			}
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00717BF8 File Offset: 0x00715DF8
		private static void CallOrRevivePet()
		{
			if ((!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && !ObjectManager.Me.IsMounted)
			{
				bool flag = false;
				if ((!ObjectManager.Pet.IsAvailable || !ObjectManager.Pet.IsSpawned) && SpellRotation.RotationSettings.PetCall && SpellRotation.RotationSettings.PetRevive)
				{
					Rotation rotation = ObjectManager.RotationSpellIsReady(SpellRotation.RotationSettings.PetCallSpellID);
					if (rotation != null)
					{
						flag = Walk.CallPet(rotation, "Call");
					}
				}
				if (!flag && (!ObjectManager.Pet.IsAvailable || !ObjectManager.Pet.IsAlive) && SpellRotation.RotationSettings.PetRevive)
				{
					Rotation rotation2 = ObjectManager.RotationSpellIsReady(SpellRotation.RotationSettings.PetReviveSpellID);
					if (rotation2 != null)
					{
						flag = Walk.CallPet(rotation2, "Revive");
					}
				}
				if (flag)
				{
					Tools.Console("Pet is ready.", "Green", "richConsole", "frmMain", true);
					Walk.FeedPet(true);
				}
				else if (Walk.Check("Food/Drink", new Action(SpellRotation.FoodDrink), true))
				{
					Tools.Console("Can't call/revive Pet -> Low Mana -> Need Food/Drink", "Red", "richConsole", "frmMain", true);
				}
				else
				{
					Tools.Console("Can't call/revive Pet. Will try again soon...", "Red", "richConsole", "frmMain", true);
					Monitor.PetCallTryAgain = DateTime.Now;
				}
			}
			Monitor.PetCall = false;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x00717D4C File Offset: 0x00715F4C
		private static bool CallPet(Rotation Spell, string Mode)
		{
			Key.Release("All");
			Tools.Console(Mode.Replace("Revive", "Reviv") + "ing Pet...", "Blue", "richConsole", "frmMain", true);
			Thread.Sleep(250);
			int num = 0;
			string name = Tools.RandomTimer(Mode + "Pet");
			Timer.Set(name, 12000);
			while (_globals.Start)
			{
				if (ObjectManager.GetAttackers.Count == 0 && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && !ObjectManager.Me.IsMounted && !ObjectManager.Pet.IsReady && Timer.Check(name) != 0 && !ObjectManager.Pet.IsReady)
				{
					if (!ObjectManager.Me.IsCasting && !ObjectManager.Me.IsChanneling)
					{
						if (num >= 3)
						{
							Tools.Console("Couldn't " + Mode.ToLower() + " Pet.", "Red", "richConsole", "frmMain", true);
							break;
						}
						num++;
						Tools.Console(string.Concat(new string[]
						{
							"Trying to ",
							Mode.ToLower(),
							" Pet (",
							num.ToString(),
							"/3)"
						}), "Orange", "richConsole", "frmMain", true);
						Key.Press(Spell.Key);
						Thread.Sleep(30);
						Key.Release(Spell.Key);
					}
					else
					{
						while (_globals.Start && ObjectManager.GetAttackers.Count == 0 && !ObjectManager.Pet.IsReady && Timer.Check(name) != 0)
						{
							Thread.Sleep(250);
						}
					}
					Thread.Sleep(_globals.GlobalCooldown);
					continue;
				}
				IL_1CC:
				return ObjectManager.Pet.IsReady;
			}
			goto IL_1CC;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x00717F30 File Offset: 0x00716130
		private static void FeedPet(bool Force = false)
		{
			if (_globals.Keys.ContainsKey("FeedPet") && _globals.Keys["FeedPet"] != "NotSet" && (Force || Timer.Check("FeedPet") == 0) && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && !ObjectManager.Me.IsInCombat && ObjectManager.Pet.IsReady && (Force || !Monitor.PetCall))
			{
				Tools.Console("Feeding Pet...", "Blue", "richConsole", "frmMain", true);
				Walk.Mount(false, false);
				Thread.Sleep(250);
				Key.Press("FeedPet");
				Thread.Sleep(30);
				Key.Release("FeedPet");
				Thread.Sleep(250);
				if (Timer.Check("FeedPet") == 0)
				{
					Timer.Set("FeedPet", SpellRotation.RotationSettings.PetFeedMinutesInMS);
				}
				Tools.Console("Next feeding in " + SpellRotation.RotationSettings.PetFeedMinutes.ToString() + " minutes.", "Blue", "richConsole", "frmMain", true);
			}
			Monitor.PetFeed = false;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x00718074 File Offset: 0x00716274
		private static void Enchant()
		{
			if ((!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && ObjectManager.GetAttackers.Count == 0)
			{
				if (_globals.Keys.ContainsKey("MainHandEnchantment") && _globals.Keys["MainHandEnchantment"] != "NotSet" && ObjectManager.NeedEnchantment("MainHand"))
				{
					Walk.smethod_1("MainHand");
				}
				if (_globals.Keys.ContainsKey("OffHandEnchantment") && _globals.Keys["OffHandEnchantment"] != "NotSet" && ObjectManager.NeedEnchantment("OffHand"))
				{
					Walk.smethod_1("OffHand");
				}
			}
			Monitor.NeedEnchantment = false;
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00718138 File Offset: 0x00716338
		public static bool CheckProfileSettings
		{
			get
			{
				return Convert.ToBoolean(Walk.ProfileSettings != null && _globals.ProfileSettings != null && _globals.ProfileSettings.Count > 0);
			}
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00718168 File Offset: 0x00716368
		public static void VashjirBehaviour(Vector3 Position, Units Unit = null, Objects Object = null)
		{
			if (!ObjectManager.Me.IsInVashjir)
			{
				return;
			}
			float num = JackMath.ZDifference(Position);
			if (num < 2f && num > -2f)
			{
				return;
			}
			Key.Release("All");
			if (num > 2f)
			{
				Fly.MoveDown(Position, "", false);
			}
			else if (num < -2f)
			{
				Fly.MoveUp(null, Unit, Object);
			}
			Key.Release("All");
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00718254 File Offset: 0x00716454
		[CompilerGenerated]
		internal static bool smethod_0(int CurrentCrd, int ClosestCrd)
		{
			int num = Math.Max(CurrentCrd, ClosestCrd);
			int num2 = Math.Min(CurrentCrd, ClosestCrd);
			return num - num2 <= 5;
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00718278 File Offset: 0x00716478
		[CompilerGenerated]
		internal static void smethod_1(string Hand)
		{
			Tools.Console("Enchanting " + Hand + "...", "Blue", "richConsole", "frmMain", true);
			Key.Release("All");
			Walk.Mount(false, false);
			while (_globals.Start && ObjectManager.GetAttackers.Count == 0 && ObjectManager.NeedEnchantment(Hand))
			{
				Thread.Sleep(250);
				Key.Press(Hand + "Enchantment");
				Thread.Sleep(30);
				Key.Release(Hand + "Enchantment");
				Thread.Sleep(1000);
			}
		}

		// Token: 0x04000A7B RID: 2683
		public static ProfileSettings ProfileSettings = null;

		// Token: 0x04000A7C RID: 2684
		public static object _lockBlacklist = new object();

		// Token: 0x04000A7D RID: 2685
		public static int Counter = 1;

		// Token: 0x04000A7E RID: 2686
		public static double DistanceToReach = 1.0;

		// Token: 0x04000A7F RID: 2687
		public static float StayAndTurnOutdoor = 2f;

		// Token: 0x04000A80 RID: 2688
		public static float StayAndTurnIndoor = 0.7f;

		// Token: 0x04000A81 RID: 2689
		public static float StayAndTurnAt = Walk.StayAndTurnOutdoor;

		// Token: 0x04000A82 RID: 2690
		public static bool CanMount = false;

		// Token: 0x04000A83 RID: 2691
		public static bool CanFly = false;

		// Token: 0x04000A84 RID: 2692
		public static bool CanFastFly = false;

		// Token: 0x04000A85 RID: 2693
		public static bool Runs = false;

		// Token: 0x04000A86 RID: 2694
		private static bool MountDelay = false;

		// Token: 0x04000A87 RID: 2695
		public static int LastClosestCrdTriggered = -1;

		// Token: 0x04000A88 RID: 2696
		private static bool ManualGhostRoute = false;
	}
}
