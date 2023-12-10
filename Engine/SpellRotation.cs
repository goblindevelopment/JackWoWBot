using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using Jack.Core;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000BF RID: 191
	public static class SpellRotation
	{
		// Token: 0x06001446 RID: 5190 RVA: 0x007048EC File Offset: 0x00702AEC
		public static void Combat(UInt128 UnitGUID)
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Combat"
			}, null);
			List<Rotation> rotationSpellsByType2 = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Heal"
			}, null);
			SpellRotation.SpellRepetitions.Clear();
			SpellRotation.PetAttackUnits.Clear();
			bool flag = SpellRotation.RotationSettings.UseGSE && _globals.Keys.ContainsKey("GSE") && _globals.Keys["GSE"] != "NotSet";
			int gseclickDelayInMS = SpellRotation.RotationSettings.GSEClickDelayInMS;
			while (_globals.Start && !_globals.NoCheck && (ObjectManager.Me.IsInVashjir || !ObjectManager.Me.IsFlying))
			{
				Units unitByGUID = ObjectManager.GetUnitByGUID(UnitGUID);
				Vector3 vector = default(Vector3);
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				bool flag5 = false;
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					if (unitByGUID == null)
					{
						break;
					}
					vector = unitByGUID.PositionVector3;
					flag2 = unitByGUID.IsAlive;
					flag3 = unitByGUID.IsFleeing;
					flag4 = unitByGUID.IsLootable;
				}
				if (!flag2 || flag4)
				{
					Tools.Console("Rotation -> Unit -> Dead", "Blue", "richConsole", "frmMain", true);
					break;
				}
				if (flag3 || JackMath.Distance(vector, true, true, true) >= (double)(SpellRotation.RotationSettings.PullDistance + 5) || !SpellRotation.IsInLineOfSight(UnitGUID))
				{
					break;
				}
				SpellRotation.ForceTarget(UnitGUID);
				SpellRotation.PetAttack(unitByGUID);
				Angle.FaceMe(ObjectManager.Me.PositionVector3, vector, ObjectManager.Me.Facing, unitByGUID, false, 0.5f);
				if (ObjectManager.Me.IsMoving)
				{
					Key.Release("All");
					Key.Press("MoveForward");
					Thread.Sleep(30);
					Key.Release("MoveForward");
					Thread.Sleep(250);
				}
				Walk.VashjirBehaviour(vector, unitByGUID, null);
				foreach (Rotation rotation in rotationSpellsByType2)
				{
					SpellRotation.AlwaysActiveBetween(true);
					if (SpellRotation.CooldownIsReady(rotation) && Timer.Check(rotation.ID) == 0 && SpellRotation.CheckSpellConditions(rotation))
					{
						flag5 = true;
						SpellRotation.TargetMe();
						SpellRotation.CastSpell(rotation, unitByGUID);
						SpellRotation.TargetUnit(UnitGUID);
						SpellRotation.CheckStepBack(rotation);
					}
				}
				foreach (Rotation rotation2 in rotationSpellsByType)
				{
					SpellRotation.AlwaysActiveBetween(true);
					if (SpellRotation.CooldownIsReady(rotation2) && Timer.Check(rotation2.ID) == 0 && SpellRotation.HasCondition(rotation2) && SpellRotation.CheckSpellConditions(rotation2))
					{
						flag5 = true;
						SpellRotation.CastSpell(rotation2, unitByGUID);
						SpellRotation.CheckStepBack(rotation2);
					}
				}
				foreach (Rotation rotation3 in rotationSpellsByType)
				{
					SpellRotation.AlwaysActiveBetween(true);
					if (SpellRotation.CooldownIsReady(rotation3) && Timer.Check(rotation3.ID) == 0 && !SpellRotation.HasCondition(rotation3))
					{
						flag5 = true;
						SpellRotation.CastSpell(rotation3, unitByGUID);
						SpellRotation.CheckStepBack(rotation3);
					}
				}
				if (flag && (DateTime.Now - SpellRotation.LastGSEClick).TotalMilliseconds > (double)gseclickDelayInMS)
				{
					Key.Press("GSE");
					Thread.Sleep(30);
					Key.Release("GSE");
					SpellRotation.LastGSEClick = DateTime.Now;
				}
				if (!flag5 && (ObjectManager.Me.IsInCombat || ObjectManager.GetAttackers.Count > 0))
				{
					SpellRotation.HandleLowPower(new List<string>
					{
						"Heal",
						"Combat"
					}, unitByGUID);
				}
				Thread.Sleep(100);
			}
			SpellRotation.ForceTargetStop = true;
			while (SpellRotation.ForceTargetRuns)
			{
				SpellRotation.ForceTargetStop = true;
				Thread.Sleep(10);
			}
			Tools.Console("Rotation -> Done.", "Blue", "richConsole", "frmMain", true);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00704D30 File Offset: 0x00702F30
		public static void CombatPVP(UInt128 UnitGUID)
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Combat"
			}, null);
			List<Rotation> rotationSpellsByType2 = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Heal"
			}, null);
			SpellRotation.PetAttackUnits.Clear();
			bool flag = SpellRotation.RotationSettings.UseGSE && _globals.Keys.ContainsKey("GSE") && _globals.Keys["GSE"] != "NotSet";
			int gseclickDelayInMS = SpellRotation.RotationSettings.GSEClickDelayInMS;
			while (_globals.Start)
			{
				if (!_globals.NoCheck && !ObjectManager.Me.IsFlying)
				{
					Units unitByGUID = ObjectManager.GetUnitByGUID(UnitGUID);
					Vector3 vector = default(Vector3);
					bool flag2 = false;
					bool flag3 = false;
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						if (unitByGUID == null)
						{
							break;
						}
						vector = unitByGUID.PositionVector3;
						flag2 = unitByGUID.IsAlive;
					}
					if (flag2)
					{
						if (JackMath.Distance(vector, true, true, true) < (double)(SpellRotation.RotationSettings.PullDistance + 5) && SpellRotation.IsInLineOfSight(UnitGUID))
						{
							SpellRotation.ForceTarget(UnitGUID);
							SpellRotation.PetAttack(unitByGUID);
							Angle.FaceMe(ObjectManager.Me.PositionVector3, vector, ObjectManager.Me.Facing, unitByGUID, false, 0.5f);
							if (ObjectManager.Me.IsMoving)
							{
								Key.Release("All");
								Key.Press("MoveForward");
								Thread.Sleep(30);
								Key.Release("MoveForward");
							}
							foreach (Rotation rotation in rotationSpellsByType2)
							{
								SpellRotation.AlwaysActiveBetween(true);
								if (SpellRotation.CooldownIsReady(rotation) && Timer.Check(rotation.ID) == 0 && SpellRotation.CheckSpellConditions(rotation))
								{
									flag3 = true;
									SpellRotation.TargetMe();
									SpellRotation.CastSpell(rotation, unitByGUID);
									SpellRotation.TargetUnit(UnitGUID);
									SpellRotation.CheckStepBack(rotation);
								}
							}
							foreach (Rotation rotation2 in rotationSpellsByType)
							{
								SpellRotation.AlwaysActiveBetween(true);
								if (SpellRotation.CooldownIsReady(rotation2) && Timer.Check(rotation2.ID) == 0 && SpellRotation.HasCondition(rotation2) && SpellRotation.CheckSpellConditions(rotation2))
								{
									flag3 = true;
									SpellRotation.CastSpell(rotation2, unitByGUID);
									SpellRotation.CheckStepBack(rotation2);
								}
							}
							foreach (Rotation rotation3 in rotationSpellsByType)
							{
								SpellRotation.AlwaysActiveBetween(true);
								if (SpellRotation.CooldownIsReady(rotation3) && Timer.Check(rotation3.ID) == 0 && !SpellRotation.HasCondition(rotation3))
								{
									flag3 = true;
									SpellRotation.CastSpell(rotation3, unitByGUID);
									SpellRotation.CheckStepBack(rotation3);
								}
							}
							if (flag && (DateTime.Now - SpellRotation.LastGSEClick).TotalMilliseconds > (double)gseclickDelayInMS)
							{
								Key.Press("GSE");
								Thread.Sleep(30);
								Key.Release("GSE");
								SpellRotation.LastGSEClick = DateTime.Now;
							}
							if (!flag3 && (ObjectManager.Me.IsInCombat || ObjectManager.GetAttackers.Count > 0))
							{
								SpellRotation.HandleLowPower(new List<string>
								{
									"Heal",
									"Combat"
								}, unitByGUID);
							}
							Thread.Sleep(100);
							continue;
						}
					}
					else
					{
						Tools.Console("Rotation -> Unit -> Dead", "Blue", "richConsole", "frmMain", true);
					}
				}
				IL_37D:
				SpellRotation.ForceTargetStop = true;
				while (SpellRotation.ForceTargetRuns)
				{
					SpellRotation.ForceTargetStop = true;
					Thread.Sleep(10);
				}
				Tools.Console("Rotation -> Done.", "Blue", "richConsole", "frmMain", true);
				return;
			}
			goto IL_37D;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00705124 File Offset: 0x00703324
		private static void ForceTarget(UInt128 GUID)
		{
			SpellRotation.<>c__DisplayClass13_0 CS$<>8__locals1 = new SpellRotation.<>c__DisplayClass13_0();
			CS$<>8__locals1.GUID = GUID;
			if (CS$<>8__locals1.GUID != SpellRotation.LastTargetGUID || ObjectManager.Me.TargetGUID == 0)
			{
				SpellRotation.LastTargetGUID = CS$<>8__locals1.GUID;
				new Thread(new ThreadStart(CS$<>8__locals1.method_0))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0070518C File Offset: 0x0070338C
		private static bool IsInLineOfSight(UInt128 UnitGUID)
		{
			if (UnitGUID == 0)
			{
				return true;
			}
			if (PlayerMe.LastErrorMessage.Length == 0)
			{
				return true;
			}
			if (SpellRotation.LOS.Contains(PlayerMe.LastErrorMessage))
			{
				Write.Do(Offsets.Local_LastErrorMessage, "");
				Jack.Engine.Combat.AddLOSTarget(UnitGUID);
				return false;
			}
			return true;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x007051E4 File Offset: 0x007033E4
		public static void PetAttack(Units Unit)
		{
			UInt128 guid = Unit.GUID;
			if (!SpellRotation.PetAttackUnits.Contains(guid) && SpellRotation.RotationSettings.PetCombatStart && ObjectManager.Pet.IsReady && Unit.IsAlive && _globals.Keys.ContainsKey("PetAttack") && _globals.Keys["PetAttack"] != "NotSet")
			{
				Key.Release("All");
				bool flag = false;
				if (ObjectManager.Me.TargetGUID != guid)
				{
					ObjectManager.Interaction(guid, "TargetMouseover");
				}
				Key.Press("PetAttack");
				Thread.Sleep(30);
				Key.Release("PetAttack");
				if (!SpellRotation.RotationSettings.PetCombatParallel)
				{
					Tools.Console("Pet -> Starting Combat...", "Blue", "richConsole", "frmMain", true);
					string name = Tools.RandomTimer("PetStartCombat");
					Timer.Set(name, 10000);
					while (_globals.Start && !_globals.NoCheck && Unit != null && Timer.Check(name) != 0 && Unit.IsAlive && !Unit.IsInCombatWithPet && !Unit.IsInCombatWithMe)
					{
						if (!ObjectManager.Pet.IsMoving)
						{
							Key.Press("PetAttack");
							Thread.Sleep(30);
							Key.Release("PetAttack");
						}
						if (!flag)
						{
							flag = SpellRotation.ReactToAttackers(Unit);
						}
						SpellRotation.FaceAndFollowWhileWait(Unit);
						Thread.Sleep(500);
					}
					if (SpellRotation.RotationSettings.PetCombatWait > 0 && Unit.IsAlive && Unit.IsInCombatWithPet)
					{
						Tools.Console("Waiting " + SpellRotation.RotationSettings.PetCombatWait.ToString() + " sec. for pet... ", "Blue", "richConsole", "frmMain", true);
						name = Tools.RandomTimer("PetStartCombatWait");
						Timer.Set(name, SpellRotation.RotationSettings.PetCombatWaitInMS);
						while (_globals.Start && !_globals.NoCheck && Unit != null && Timer.Check(name) != 0)
						{
							if (!flag)
							{
								flag = SpellRotation.ReactToAttackers(Unit);
							}
							if (!Unit.IsAlive || Unit.IsInCombatWithMe)
							{
								break;
							}
							SpellRotation.FaceAndFollowWhileWait(Unit);
							Thread.Sleep(500);
						}
					}
				}
				else
				{
					Tools.Console("Pet -> Starting Combat (Parallel)...", "Blue", "richConsole", "frmMain", true);
				}
				SpellRotation.PetAttackUnits.Add(guid);
			}
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00705444 File Offset: 0x00703644
		private static bool ReactToAttackers(Units Unit = null)
		{
			if (SpellRotation.RotationSettings.PetCombatReact)
			{
				Rotation rotation = ObjectManager.RotationSpellIsReady(SpellRotation.RotationSettings.PetCombatReactSpellID);
				if (rotation != null && ObjectManager.GetAttackersByDistance((int)JackMath.Distance(ObjectManager.Me.PositionVector3, ObjectManager.Pet.PositionVector3, true, true, true)).Count > 0)
				{
					Units getClosestAttacker = ObjectManager.GetClosestAttacker;
					if (getClosestAttacker != null && getClosestAttacker.GUID128 != Unit.GUID128)
					{
						Tools.Console("Got an uninvited guest. -> Casting \"" + rotation.Name + "\".", "Orange", "richConsole", "frmMain", true);
						Thread.Sleep(250);
						ObjectManager.Interaction(getClosestAttacker.GUID128, "TargetMouseover");
						Thread.Sleep(1000);
						Key.Press(rotation.Key);
						Thread.Sleep(30);
						Key.Release(rotation.Key);
						Thread.Sleep(500);
						ObjectManager.Interaction(Unit.GUID128, "TargetMouseover");
						Thread.Sleep(1000);
						if (SpellRotation.RotationSettings.PetCombatReactStepBack)
						{
							string text = "MoveBackward";
							if (getClosestAttacker.IsBehind)
							{
								text = "MoveForward";
							}
							Tools.Console("Step back -> " + text, "Blue", "richConsole", "frmMain", true);
							Thread.Sleep(250);
							int millisecondsTimeout = SpellRotation.Random.Next(1100, 1400);
							Key.Press(text);
							Thread.Sleep(millisecondsTimeout);
							Key.Release(text);
						}
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x007055D0 File Offset: 0x007037D0
		private static void FaceAndFollowWhileWait(Units Unit)
		{
			Vector3 positionVector = Unit.PositionVector3;
			if (JackMath.Distance(positionVector, true, true, true) > (double)(SpellRotation.RotationSettings.PullDistance + 5))
			{
				Walk.GoTo(positionVector, (double)SpellRotation.RotationSettings.PullDistance, 0f, null);
				return;
			}
			SpellRotation.FacingTarget(Unit);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00705620 File Offset: 0x00703820
		public static void HandleLowPower(List<string> SpellTypes, Units Unit = null)
		{
			if (Unit != null)
			{
				Vector3 positionVector = Unit.PositionVector3;
				UInt128 guid = Unit.GUID128;
				if (JackMath.Distance(positionVector, true, true, true) <= 5.0)
				{
					ObjectManager.Interaction(guid, "InteractMouseover");
				}
				else
				{
					for (int i = SpellTypes.Count - 1; i >= 0; i--)
					{
						if (SpellTypes[i] == "Heal" && ObjectManager.Me.CurrentHealthPercent >= 80)
						{
							SpellTypes.RemoveAt(i);
						}
						else if (SpellTypes[i] == "Combat" && !ObjectManager.Me.IsManaClass)
						{
							SpellTypes.RemoveAt(i);
						}
					}
					if (SpellTypes.Count > 0)
					{
						Rotation rotationSpellWithLowestPower = ObjectManager.GetRotationSpellWithLowestPower(SpellTypes);
						if (rotationSpellWithLowestPower != null && !SpellRotation.HasEnoughPower(rotationSpellWithLowestPower))
						{
							int num;
							if (rotationSpellWithLowestPower.PowerType1Value > 0 && rotationSpellWithLowestPower.PowerType2Value > 0)
							{
								num = Math.Min(rotationSpellWithLowestPower.PowerType1Value, rotationSpellWithLowestPower.PowerType2Value);
							}
							else
							{
								num = Math.Max(rotationSpellWithLowestPower.PowerType1Value, rotationSpellWithLowestPower.PowerType2Value);
							}
							string text;
							if (num != rotationSpellWithLowestPower.PowerType1Value)
							{
								text = rotationSpellWithLowestPower.PowerType2;
							}
							else
							{
								text = rotationSpellWithLowestPower.PowerType1;
							}
							if (num > 0)
							{
								Key.Release("All");
								Tools.Console(string.Concat(new string[]
								{
									"Not enough Power. Need at least ",
									num.ToString(),
									" ",
									text,
									"."
								}), "Orange", "richConsole", "frmMain", true);
								Tools.Console("Starting Melee Attack...", "Blue", "richConsole", "frmMain", true);
								int num2 = ObjectManager.Me.CurrentPower;
								while (_globals.Start && !_globals.NoCheck && (ObjectManager.Me.IsInVashjir || !ObjectManager.Me.IsFlying) && num2 < num && ObjectManager.GetAttackers.Count != 0)
								{
									if (Unit != null)
									{
										positionVector = Unit.PositionVector3;
										if (JackMath.Distance(positionVector, true, true, true) >= 5.0)
										{
											Walk.GoTo(positionVector, 4.0, 0f, new string[]
											{
												"RunBack"
											});
										}
										ObjectManager.Interaction(guid, "InteractMouseover");
										Angle.FaceMe(ObjectManager.Me.PositionVector3, positionVector, ObjectManager.Me.Facing, null, true, 0.5f);
									}
									int currentPower = ObjectManager.Me.CurrentPower;
									if (currentPower > num2)
									{
										num2 = currentPower;
										Tools.Console("Power: " + num2.ToString() + "/" + num.ToString(), "", "richConsole", "frmMain", true);
									}
									Thread.Sleep(500);
								}
							}
							if (ObjectManager.GetAttackers.Count == 0)
							{
								Walk.Check("Conjuring", new Action(SpellRotation.Conjuring), false);
								Walk.Check("Food/Drink", new Action(SpellRotation.FoodDrink), false);
								Walk.Check("Heal", new Action(SpellRotation.Heal), false);
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0070593C File Offset: 0x00703B3C
		public static int GetCooldown(Rotation Spell)
		{
			if (Spell.Cooldown > 0)
			{
				return Spell.Cooldown;
			}
			return _globals.GlobalCooldown;
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00705960 File Offset: 0x00703B60
		public static bool CooldownIsReady(Rotation Spell)
		{
			if (Spell.IsMacro)
			{
				return SpellRotation.CustomCooldownIsReady(Spell);
			}
			return Spell.IsReadyOrExists(Spell.ID, false);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00705988 File Offset: 0x00703B88
		public static bool CustomCooldownIsReady(Rotation Spell)
		{
			return !SpellRotation.CustomCooldownIDs.ContainsKey(Spell.ID) || SpellRotation.CustomCooldownIDs[Spell.ID].AddMilliseconds((double)Spell.Cooldown) <= DateTime.Now;
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x007059D4 File Offset: 0x00703BD4
		public static void CreateCustomCooldown(Rotation Spell)
		{
			if (!SpellRotation.CustomCooldownIDs.ContainsKey(Spell.ID))
			{
				SpellRotation.CustomCooldownIDs.Add(Spell.ID, DateTime.Now);
				return;
			}
			SpellRotation.CustomCooldownIDs[Spell.ID] = DateTime.Now;
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00705A20 File Offset: 0x00703C20
		private static void AddSpellRepetition(Rotation Spell)
		{
			if (Spell.Repetitions == 0)
			{
				return;
			}
			if (!SpellRotation.SpellRepetitions.ContainsKey(Spell.ID))
			{
				SpellRotation.SpellRepetitions.Add(Spell.ID, 1);
				return;
			}
			SpellRotation.SpellRepetitions[Spell.ID] = SpellRotation.SpellRepetitions[Spell.ID] + 1;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00705A7C File Offset: 0x00703C7C
		private static bool SpellRepetitionIsReached(Rotation Spell)
		{
			return Spell.Repetitions > 0 && SpellRotation.SpellRepetitions.ContainsKey(Spell.ID) && SpellRotation.SpellRepetitions[Spell.ID] >= Spell.Repetitions;
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00705AC0 File Offset: 0x00703CC0
		public static void CheckHeal()
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Heal"
			}, null);
			while (_globals.Start)
			{
				if (!SpellRotation.CheckHealRuns)
				{
					SpellRotation.CheckHealRuns = true;
				}
				if (!_globals.NoCheck && SpellRotation.Need["Heal"] == 0 && !ObjectManager.Me.IsInCombat)
				{
					bool flag = false;
					using (List<Rotation>.Enumerator enumerator = rotationSpellsByType.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Rotation rotation = enumerator.Current;
							if (SpellRotation.CooldownIsReady(rotation) && SpellRotation.CheckSpellConditions(rotation))
							{
								flag = true;
								if (!rotation.CanCastWhileWalk)
								{
									SpellRotation.CanCastWhileWalk["Heal"] = false;
									break;
								}
							}
						}
						goto IL_ED;
					}
					IL_B4:
					SpellRotation.Need["Heal"] = 1;
					Tools.Console("Need Heal...", "Blue", "richConsole", "frmMain", true);
					goto IL_DE;
					IL_ED:
					if (flag)
					{
						goto IL_B4;
					}
				}
				IL_DE:
				Thread.Sleep(1000);
			}
			SpellRotation.CheckHealRuns = false;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00705BD8 File Offset: 0x00703DD8
		public static void Heal()
		{
			if (!ObjectManager.Me.IsInCombat)
			{
				foreach (Rotation rotation in ObjectManager.GetRotationSpellsByType(new string[]
				{
					"Heal"
				}, null))
				{
					if (SpellRotation.CooldownIsReady(rotation) && Timer.Check(rotation.ID) == 0 && SpellRotation.CheckSpellConditions(rotation))
					{
						SpellRotation.TargetMe();
						SpellRotation.CastSpell(rotation, null);
						Thread.Sleep(SpellRotation.GetCooldown(rotation));
						SpellRotation.CheckStepBack(rotation);
					}
				}
				SpellRotation.CanCastWhileWalk["Heal"] = true;
				SpellRotation.Need["Heal"] = 0;
			}
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00705CA4 File Offset: 0x00703EA4
		public static void CheckFoodDrink()
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Food/Drink"
			}, null);
			while (_globals.Start)
			{
				if (!SpellRotation.CheckFoodDrinkRuns)
				{
					SpellRotation.CheckFoodDrinkRuns = true;
				}
				if (!_globals.NoCheck && SpellRotation.Need["Food/Drink"] == 0 && !ObjectManager.Me.IsInCombat)
				{
					bool flag = false;
					using (List<Rotation>.Enumerator enumerator = rotationSpellsByType.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Rotation rotation = enumerator.Current;
							if (SpellRotation.CheckSpellConditions(rotation))
							{
								flag = true;
								if (!rotation.CanCastWhileWalk)
								{
									SpellRotation.CanCastWhileWalk["Food/Drink"] = false;
									break;
								}
							}
						}
						goto IL_E2;
					}
					IL_A9:
					SpellRotation.Need["Food/Drink"] = 1;
					Tools.Console("Need Food/Drink...", "Blue", "richConsole", "frmMain", true);
					goto IL_D3;
					IL_E2:
					if (flag)
					{
						goto IL_A9;
					}
				}
				IL_D3:
				Thread.Sleep(1000);
			}
			SpellRotation.CheckFoodDrinkRuns = false;
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00705DB0 File Offset: 0x00703FB0
		public static void FoodDrink()
		{
			if (!ObjectManager.Me.IsInCombat && SpellRotation.Need["Conjuring"] != 1)
			{
				List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
				{
					"Food/Drink"
				}, null);
				List<Rotation> list = new List<Rotation>();
				foreach (Rotation rotation in rotationSpellsByType)
				{
					if (SpellRotation.CheckSpellConditions(rotation))
					{
						list.Add(rotation);
					}
				}
				if (list.Count > 0)
				{
					SpellRotation.CastFoodDrink(list);
				}
				SpellRotation.CanCastWhileWalk["Food/Drink"] = true;
				SpellRotation.Need["Food/Drink"] = 0;
			}
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00705E74 File Offset: 0x00704074
		public static void CheckConjuring()
		{
			if (ObjectManager.GetFreeBagSlots == 0)
			{
				return;
			}
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Conjuring"
			}, null);
			while (_globals.Start)
			{
				if (!SpellRotation.CheckConjuringRuns)
				{
					SpellRotation.CheckConjuringRuns = true;
				}
				if (!_globals.NoCheck && SpellRotation.Need["Conjuring"] == 0 && !ObjectManager.Me.IsInCombat)
				{
					bool flag = false;
					using (List<Rotation>.Enumerator enumerator = rotationSpellsByType.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Rotation rotation = enumerator.Current;
							if (SpellRotation.CheckSpellConditions(rotation))
							{
								flag = true;
								if (!rotation.CanCastWhileWalk)
								{
									SpellRotation.CanCastWhileWalk["Conjuring"] = false;
									break;
								}
							}
						}
						goto IL_E8;
					}
					IL_AF:
					SpellRotation.Need["Conjuring"] = 1;
					Tools.Console("Need new conjured Items...", "Blue", "richConsole", "frmMain", true);
					goto IL_D9;
					IL_E8:
					if (flag)
					{
						goto IL_AF;
					}
				}
				IL_D9:
				Thread.Sleep(1000);
			}
			SpellRotation.CheckConjuringRuns = false;
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00705F84 File Offset: 0x00704184
		public static void Conjuring()
		{
			if (ObjectManager.GetFreeBagSlots == 0)
			{
				SpellRotation.CanCastWhileWalk["Conjuring"] = true;
				SpellRotation.Need["Conjuring"] = 0;
				return;
			}
			if (!ObjectManager.Me.IsInCombat)
			{
				foreach (Rotation rotation in ObjectManager.GetRotationSpellsByType(new string[]
				{
					"Conjuring"
				}, null))
				{
					if (SpellRotation.CheckSpellConditions(rotation))
					{
						if (rotation.ItemAmount <= 0)
						{
							SpellRotation.CastSpell(rotation, null);
							Thread.Sleep(1000);
						}
						else
						{
							int itemAmount = ObjectManager.GetItemAmount(rotation.ItemID);
							while (_globals.Start && !_globals.NoCheck && !ObjectManager.Me.IsInCombat && SpellRotation.HasEnoughPower(rotation) && itemAmount < rotation.ItemAmount)
							{
								SpellRotation.CastSpell(rotation, null);
								Thread.Sleep(1000);
								itemAmount = ObjectManager.GetItemAmount(rotation.ItemID);
								Tools.Console(string.Concat(new string[]
								{
									rotation.ItemName,
									" -> ",
									itemAmount.ToString(),
									"/",
									rotation.ItemAmount.ToString()
								}), "Green", "richConsole", "frmMain", true);
							}
						}
					}
				}
				SpellRotation.CanCastWhileWalk["Conjuring"] = true;
				SpellRotation.Need["Conjuring"] = 0;
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00706138 File Offset: 0x00704338
		public static void CheckBuff()
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Dispel",
				"Buff/Aura"
			}, null);
			while (_globals.Start)
			{
				if (!SpellRotation.CheckBuffRuns)
				{
					SpellRotation.CheckBuffRuns = true;
				}
				if (!_globals.NoCheck && SpellRotation.Need["Buff/Aura"] == 0 && (Walk.ProfileSettings.CombatMode == "Ignore" || Walk.ProfileSettings.CombatMode == "Gather" || !ObjectManager.Me.IsInCombat))
				{
					bool flag = false;
					using (List<Rotation>.Enumerator enumerator = rotationSpellsByType.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Rotation rotation = enumerator.Current;
							if (SpellRotation.CooldownIsReady(rotation))
							{
								int num = rotation.ID;
								if (rotation.DifferentAuraID > 0)
								{
									num = rotation.DifferentAuraID;
								}
								if ((!(rotation.Type == "Buff/Aura") || (!ObjectManager.Me.HasBuff(new int[]
								{
									num
								}) && !ObjectManager.Me.HasBuff(new string[]
								{
									rotation.Name
								}))) && SpellRotation.CheckSpellConditions(rotation))
								{
									flag = true;
									if (!rotation.CanCastWhileWalk)
									{
										SpellRotation.CanCastWhileWalk["Buff/Aura"] = false;
										break;
									}
								}
							}
						}
						goto IL_181;
					}
					IL_148:
					SpellRotation.Need["Buff/Aura"] = 1;
					Tools.Console("Need Buff(s)...", "Blue", "richConsole", "frmMain", true);
					goto IL_172;
					IL_181:
					if (flag)
					{
						goto IL_148;
					}
				}
				IL_172:
				Thread.Sleep(1000);
			}
			SpellRotation.CheckBuffRuns = false;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x007062E4 File Offset: 0x007044E4
		public static void Buff()
		{
			if (Walk.ProfileSettings.CombatMode == "Ignore" || Walk.ProfileSettings.CombatMode == "Gather" || !ObjectManager.Me.IsInCombat)
			{
				foreach (Rotation rotation in ObjectManager.GetRotationSpellsByType(new string[]
				{
					"Dispel",
					"Buff/Aura"
				}, null))
				{
					if (SpellRotation.CooldownIsReady(rotation) && Timer.Check(rotation.ID) == 0)
					{
						int num = rotation.ID;
						if (rotation.DifferentAuraID > 0)
						{
							num = rotation.DifferentAuraID;
						}
						if ((!(rotation.Type == "Buff/Aura") || (!ObjectManager.Me.HasBuff(new int[]
						{
							num
						}) && !ObjectManager.Me.HasBuff(new string[]
						{
							rotation.Name
						}))) && SpellRotation.CheckSpellConditions(rotation))
						{
							SpellRotation.TargetMe();
							SpellRotation.CastSpell(rotation, null);
							Thread.Sleep(SpellRotation.GetCooldown(rotation));
						}
					}
				}
				SpellRotation.CanCastWhileWalk["Buff/Aura"] = true;
				SpellRotation.Need["Buff/Aura"] = 0;
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00706440 File Offset: 0x00704640
		public static void CheckAlwaysActive()
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Dispel",
				"Buff/Aura"
			}, new string[]
			{
				"AlwaysActive"
			});
			while (_globals.Start)
			{
				if (!SpellRotation.CheckAlwaysActiveRuns)
				{
					SpellRotation.CheckAlwaysActiveRuns = true;
				}
				if (!_globals.NoCheck && SpellRotation.Need["AlwaysActive"] == 0)
				{
					bool flag = false;
					bool isInCombat = ObjectManager.Me.IsInCombat;
					using (List<Rotation>.Enumerator enumerator = rotationSpellsByType.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Rotation rotation = enumerator.Current;
							if (((isInCombat && rotation.AlwaysActiveCombat) || (!isInCombat && rotation.AlwaysActiveOutOfCombat)) && SpellRotation.CooldownIsReady(rotation) && Timer.Check(rotation.ID) == 0)
							{
								int num = rotation.ID;
								if (rotation.DifferentAuraID > 0)
								{
									num = rotation.DifferentAuraID;
								}
								if ((!(rotation.Type == "Buff/Aura") || (!ObjectManager.Me.HasBuff(new int[]
								{
									num
								}) && !ObjectManager.Me.HasBuff(new string[]
								{
									rotation.Name
								}))) && SpellRotation.CheckSpellConditions(rotation))
								{
									flag = true;
									if (!rotation.CanCastWhileWalk)
									{
										SpellRotation.CanCastWhileWalk["AlwaysActive"] = false;
										break;
									}
								}
							}
						}
						goto IL_19E;
					}
					IL_165:
					SpellRotation.Need["AlwaysActive"] = 1;
					Tools.Console("Need always active Spells...", "Blue", "richConsole", "frmMain", true);
					goto IL_18F;
					IL_19E:
					if (flag)
					{
						goto IL_165;
					}
				}
				IL_18F:
				Thread.Sleep(1000);
			}
			SpellRotation.CheckAlwaysActiveRuns = false;
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00706608 File Offset: 0x00704808
		public static void AlwaysActive()
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Dispel",
				"Buff/Aura"
			}, new string[]
			{
				"AlwaysActive"
			});
			bool isInCombat = ObjectManager.Me.IsInCombat;
			foreach (Rotation rotation in rotationSpellsByType)
			{
				if (((isInCombat && rotation.AlwaysActiveCombat) || (!isInCombat && rotation.AlwaysActiveOutOfCombat)) && SpellRotation.CooldownIsReady(rotation) && Timer.Check(rotation.ID) == 0)
				{
					int num = rotation.ID;
					if (rotation.DifferentAuraID > 0)
					{
						num = rotation.DifferentAuraID;
					}
					if ((!(rotation.Type == "Buff/Aura") || (!ObjectManager.Me.HasBuff(new int[]
					{
						num
					}) && !ObjectManager.Me.HasBuff(new string[]
					{
						rotation.Name
					}))) && SpellRotation.CheckSpellConditions(rotation))
					{
						SpellRotation.CastSpell(rotation, null);
						Thread.Sleep(SpellRotation.GetCooldown(rotation));
					}
				}
			}
			SpellRotation.CanCastWhileWalk["AlwaysActive"] = true;
			SpellRotation.Need["AlwaysActive"] = 0;
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00706758 File Offset: 0x00704958
		public static void AlwaysActiveBetween(bool MustBeInCombat = false)
		{
			if (MustBeInCombat && !ObjectManager.Me.IsInCombat)
			{
				SpellRotation.Need["AlwaysActive"] = 0;
			}
			else if (Walk.Check("AlwaysActive", new Action(SpellRotation.AlwaysActive), true))
			{
				SpellRotation.AlwaysActive();
				return;
			}
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x007067A8 File Offset: 0x007049A8
		public static void AlwaysActiveOnMyWayToTarget()
		{
			List<Rotation> rotationSpellsByType = ObjectManager.GetRotationSpellsByType(new string[]
			{
				"Dispel",
				"Buff/Aura"
			}, new string[]
			{
				"AlwaysActiveWay"
			});
			bool isMoving = ObjectManager.Me.IsMoving;
			if (rotationSpellsByType.Count > 0)
			{
				foreach (Rotation rotation in rotationSpellsByType)
				{
					if (SpellRotation.CooldownIsReady(rotation) && Timer.Check(rotation.ID) == 0)
					{
						int num = rotation.ID;
						if (rotation.DifferentAuraID > 0)
						{
							num = rotation.DifferentAuraID;
						}
						if ((!(rotation.Type == "Buff/Aura") || (!ObjectManager.Me.HasBuff(new int[]
						{
							num
						}) && !ObjectManager.Me.HasBuff(new string[]
						{
							rotation.Name
						}))) && SpellRotation.CheckSpellConditions(rotation))
						{
							if (!rotation.CanCastWhileWalk && ObjectManager.Me.IsMoving)
							{
								Key.Release("All");
								Thread.Sleep(250);
							}
							SpellRotation.CastSpell(rotation, null);
						}
					}
				}
			}
			if (isMoving)
			{
				Key.Press("MoveForward");
			}
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x007068F8 File Offset: 0x00704AF8
		private static void CastSpell(Rotation Spell, Units Unit = null)
		{
			if (Spell.Key.Length > 0)
			{
				if (Walk.IsInMeshMode)
				{
					SpellRotation.FacingTarget(Unit);
				}
				Tools.Console("Casting \"" + Spell.Name + "\".", "Blue", "richConsole", "frmMain", true);
				string name = Tools.RandomTimer(Spell.ID.ToString());
				Timer.Set(name, SpellRotation.GetCooldown(Spell));
				if (Spell.IsMacro)
				{
					SpellRotation.CreateCustomCooldown(Spell);
				}
				Key.Press(Spell.Key);
				Thread.Sleep(30);
				Key.Release(Spell.Key);
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					if (Unit == null)
					{
						while (_globals.Start && !_globals.NoCheck && !ObjectManager.Me.IsCasting && !ObjectManager.Me.IsChanneling && Timer.Check(name) != 0)
						{
							Thread.Sleep(10);
						}
						while (_globals.Start)
						{
							if (_globals.NoCheck || (!ObjectManager.Me.IsCasting && !ObjectManager.Me.IsChanneling))
							{
								break;
							}
							Thread.Sleep(250);
						}
					}
					else if (ObjectManager.Me.IsCasting || ObjectManager.Me.IsChanneling)
					{
						SpellRotation.AddSpellRepetition(Spell);
						while (_globals.Start)
						{
							if (_globals.NoCheck || !Unit.IsAlive)
							{
								break;
							}
							if (!ObjectManager.Me.IsCasting && !ObjectManager.Me.IsChanneling)
							{
								break;
							}
							SpellRotation.FacingTarget(Unit);
							Thread.Sleep(250);
						}
					}
				}
			}
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00706A98 File Offset: 0x00704C98
		private static void CastFoodDrink(List<Rotation> Spells)
		{
			int count = Spells.Count;
			if (count > 0)
			{
				string text = "";
				string str = "";
				foreach (Rotation rotation in Spells)
				{
					if (text.Length != 0)
					{
						text = text + " + " + rotation.Name;
						str += rotation.ID.ToString();
					}
					else
					{
						text = rotation.Name;
						str = rotation.ID.ToString();
					}
				}
				Tools.Console(string.Concat(new string[]
				{
					"Using ",
					count.ToString(),
					" item(s) -> \"",
					text,
					"\""
				}), "", "richConsole", "frmMain", true);
				Key.Release("All");
				Thread.Sleep(500);
				List<int> getBuffIDs = ObjectManager.Me.GetBuffIDs;
				List<int> list = new List<int>();
				int count2 = getBuffIDs.Count;
				int num = 0;
				foreach (Rotation rotation2 in Spells)
				{
					if (rotation2.IsMacro)
					{
						SpellRotation.CreateCustomCooldown(rotation2);
					}
					Key.Press(rotation2.Key);
					Thread.Sleep(30);
					Key.Release(rotation2.Key);
					if (count > 1)
					{
						Thread.Sleep(SpellRotation.GetCooldown(rotation2));
					}
				}
				Timer.Set(str + "-1", 3000);
				while (_globals.Start && !_globals.NoCheck && Timer.Check(str + "-1") != 0)
				{
					list.Clear();
					list = ObjectManager.Me.GetBuffIDs;
					num = list.Count - count2;
					if (num > 0)
					{
						Tools.Console("Counted " + num.ToString() + " new Buff(s).", "", "richConsole", "frmMain", true);
						break;
					}
					Thread.Sleep(100);
				}
				if (num > 0)
				{
					bool flag = false;
					bool flag2 = false;
					Timer.Set(str + "-2", 20000);
					while (_globals.Start && !_globals.NoCheck && ObjectManager.GetAttackers.Count == 0 && Timer.Check(str + "-2") != 0)
					{
						if (count != 1)
						{
							if (flag && flag2)
							{
								break;
							}
						}
						else if (flag || flag2)
						{
							return;
						}
						foreach (Rotation rotation3 in Spells)
						{
							if (!flag && (rotation3.PowerType1 == "HEALTH (in Percent)" || rotation3.PowerType2 == "HEALTH (in Percent)"))
							{
								if (ObjectManager.Me.CurrentHealthPercent == 100)
								{
									Tools.Console("Health is ready.", "Green", "richConsole", "frmMain", true);
									flag = true;
								}
							}
							if (!flag2 && (rotation3.PowerType1 == "MANA (in Percent)" || rotation3.PowerType2 == "MANA (in Percent)"))
							{
								if (ObjectManager.Me.CurrentManaPercent == 100)
								{
									Tools.Console("Mana is ready.", "Green", "richConsole", "frmMain", true);
									flag2 = true;
								}
							}
						}
						Thread.Sleep(100);
					}
				}
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00706E34 File Offset: 0x00705034
		private static void TargetMe()
		{
			ObjectManager.Interaction(ObjectManager.Me.GUID128, "TargetMouseover");
			Thread.Sleep(200);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00706E64 File Offset: 0x00705064
		private static void TargetUnit(UInt128 UnitGUID)
		{
			ObjectManager.Interaction(UnitGUID, "TargetMouseover");
			Thread.Sleep(200);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00706E8C File Offset: 0x0070508C
		private static void FacingTarget(Units Unit = null)
		{
			if (Unit != null)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					Angle.FaceMe(ObjectManager.Me.PositionVector3, Unit.PositionVector3, ObjectManager.Me.Facing, Unit, false, 0.5f);
				}
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00706EF0 File Offset: 0x007050F0
		private static void CheckStepBack(Rotation Spell)
		{
			if (Spell.HasMultipleAttackers && Spell.MultipleAttackersStepBack)
			{
				int millisecondsTimeout = SpellRotation.Random.Next(1100, 1400);
				Key.Press("MoveBackward");
				Thread.Sleep(millisecondsTimeout);
				Key.Release("MoveBackward");
			}
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00706F3C File Offset: 0x0070513C
		public static bool CheckSpellConditions(Rotation Spell)
		{
			return (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && !(Spell.Key == "") && !SpellRotation.SpellRepetitionIsReached(Spell) && SpellRotation.HasEnoughPower(Spell) && (!Spell.IsItem || ObjectManager.GetItemAmount(Spell.ID) != 0) && (!Spell.HasItem || SpellRotation.ItemConditionReady(Spell)) && (!Spell.HasAddition1 || SpellRotation.Addition1Ready(Spell)) && (!Spell.HasAddition2 || SpellRotation.CanRecast(Spell)) && (!Spell.HasAddition3 || SpellRotation.CanCastIfActive(Spell)) && (!Spell.HasMultipleAttackers || SpellRotation.MultipleAttackersReady(Spell)) && (!Spell.HasMore || SpellRotation.MoreReady(Spell));
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00707018 File Offset: 0x00705218
		public static bool HasCondition(Rotation Spell)
		{
			return Spell.HasPowerType1 || Spell.HasPowerType2 || Spell.HasItem || Spell.HasAddition1 || Spell.HasAddition2 || Spell.HasAddition3 || Spell.HasMultipleAttackers || Spell.HasMore;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00707078 File Offset: 0x00705278
		public static bool HasEnoughPower(Rotation Spell)
		{
			return (!Spell.HasPowerType1 || SpellRotation.PowerTypeReady(Spell, 1)) && (!Spell.HasPowerType2 || SpellRotation.PowerTypeReady(Spell, 2));
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x007070AC File Offset: 0x007052AC
		public static bool PowerTypeReady(Rotation Spell, int WhichPowerType)
		{
			string a;
			string a2;
			int num;
			string unitSelection;
			if (WhichPowerType != 1)
			{
				a = Spell.PowerType2;
				a2 = Spell.PowerType2Compare;
				num = Spell.PowerType2Value;
				unitSelection = Spell.PowerType2Target;
			}
			else
			{
				a = Spell.PowerType1;
				a2 = Spell.PowerType1Compare;
				num = Spell.PowerType1Value;
				unitSelection = Spell.PowerType1Target;
			}
			try
			{
				Units units = SpellRotation.WhichUnit(unitSelection);
				if (units != null)
				{
					int num2;
					if (a == "HEALTH (in Percent)")
					{
						num2 = units.CurrentHealthPercent;
					}
					else if (a == "HEALTH")
					{
						num2 = units.CurrentHealth;
					}
					else if (a == "MANA (in Percent)")
					{
						num2 = units.CurrentManaPercent;
					}
					else if (a == "MANA")
					{
						num2 = units.CurrentMana;
					}
					else if (!(a == "COMBO_POINTS"))
					{
						num2 = units.CurrentPowerPercent;
					}
					else
					{
						units = ObjectManager.Me;
						num2 = units.ComboPoints;
					}
					if (num2 >= 0)
					{
						if (a2 == "Smaller or Equal" && num2 <= num)
						{
							return true;
						}
						if (a2 == "Greater or Equal" && num2 >= num)
						{
							return true;
						}
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x007071F0 File Offset: 0x007053F0
		public static bool ItemConditionReady(Rotation Spell)
		{
			try
			{
				int itemAmount = ObjectManager.GetItemAmount(Spell.ItemID);
				if (itemAmount > 0)
				{
					if (Spell.ItemCompare == "Smaller or Equal" && itemAmount <= Spell.ItemValue)
					{
						return true;
					}
					if (Spell.ItemCompare == "Greater or Equal" && itemAmount >= Spell.ItemValue)
					{
						return true;
					}
				}
				else if (Spell.ItemCompare == "Smaller or Equal")
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00707280 File Offset: 0x00705480
		public static bool Addition1Ready(Rotation Spell)
		{
			try
			{
				Units units = SpellRotation.WhichUnit(Spell.Addition1Target);
				if (units != null && Spell.Addition1Option == "Range in Yards")
				{
					if (Spell.Addition1Compare == "Smaller or Equal" && JackMath.Distance(units.PositionVector3, true, true, true) <= (double)Spell.Addition1Value)
					{
						return true;
					}
					if (Spell.Addition1Compare == "Greater or Equal" && JackMath.Distance(units.PositionVector3, true, true, true) >= (double)Spell.Addition1Value)
					{
						return true;
					}
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00707320 File Offset: 0x00705520
		public static bool CanRecast(Rotation Spell)
		{
			if (Spell.DoNotRecastIfActive || Spell.AlwaysActiveCombat || Spell.AlwaysActiveCombatWay || Spell.AlwaysActiveOutOfCombat)
			{
				try
				{
					Units units;
					if (!Spell.AlwaysActiveCombat && !Spell.AlwaysActiveCombatWay && !Spell.AlwaysActiveOutOfCombat)
					{
						units = SpellRotation.WhichUnit(Spell.DoNotRecastIfActiveTarget);
					}
					else
					{
						units = ObjectManager.Me;
					}
					if (units == null)
					{
						return false;
					}
					int num = Spell.ID;
					if (Spell.DifferentAuraID > 0)
					{
						num = Spell.DifferentAuraID;
					}
					List<int> getBuffIDsCastedByMe = units.GetBuffIDsCastedByMe;
					if (getBuffIDsCastedByMe.Count > 0)
					{
						if (!units.GetBuffNamesCastedByMe.Contains(Spell.Name))
						{
							using (List<int>.Enumerator enumerator = getBuffIDsCastedByMe.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									if (enumerator.Current == num)
									{
										return false;
									}
								}
								goto IL_C9;
							}
						}
						return false;
					}
					IL_C9:;
				}
				catch
				{
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00707420 File Offset: 0x00705620
		public static bool CanCastIfActive(Rotation Spell)
		{
			if (Spell.CastIfActive || (Spell.CastIfActiveSpelllist.Count > 0 && (Spell.AlwaysActiveCombat || Spell.AlwaysActiveCombatWay || Spell.AlwaysActiveOutOfCombat)))
			{
				try
				{
					Units units;
					if (!Spell.AlwaysActiveCombat && !Spell.AlwaysActiveCombatWay && !Spell.AlwaysActiveOutOfCombat)
					{
						units = SpellRotation.WhichUnit(Spell.CastIfActiveTarget);
					}
					else
					{
						units = ObjectManager.Me;
					}
					if (units != null)
					{
						foreach (KeyValuePair<int, string> keyValuePair in units.GetAllAuras)
						{
							foreach (string a in Spell.CastIfActiveSpelllist)
							{
								string str = keyValuePair.Key.ToString();
								string value = keyValuePair.Value;
								if (a == keyValuePair.Key.ToString())
								{
									Tools.Console("Respond to " + str + ".", "Blue", "richConsole", "frmMain", true);
									return true;
								}
								if (a == keyValuePair.Value)
								{
									Tools.Console("Respond to " + value + ".", "Blue", "richConsole", "frmMain", true);
									return true;
								}
							}
						}
					}
				}
				catch
				{
				}
				return false;
			}
			return false;
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x007075EC File Offset: 0x007057EC
		public static bool MultipleAttackersReady(Rotation Spell)
		{
			int distance = 30;
			if (Spell.MultipleAttackersDistance > 0)
			{
				distance = Spell.MultipleAttackersDistance;
			}
			int count = ObjectManager.GetUnitsAround(ObjectManager.Me.PositionVector3, "InCombatWithMeOrPet", distance).Count;
			if (count > 0)
			{
				if (Spell.MultipleAttackersCompare == "Smaller or Equal" && count <= Spell.MultipleAttackersValue)
				{
					return true;
				}
				if (Spell.MultipleAttackersCompare == "Equal")
				{
					if (count == Spell.MultipleAttackersValue)
					{
						return true;
					}
				}
				if (Spell.MultipleAttackersCompare == "Greater or Equal" && count >= Spell.MultipleAttackersValue)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00707688 File Offset: 0x00705888
		public static bool MoreReady(Rotation Spell)
		{
			Units unitByGUID = ObjectManager.GetUnitByGUID(ObjectManager.Me.TargetGUID);
			if (unitByGUID != null)
			{
				object @lock = ObjectManager._lock;
				bool isCasting;
				lock (@lock)
				{
					if (!unitByGUID.IsInCombatWithMe && !unitByGUID.IsInCombatWithPet)
					{
						return false;
					}
					isCasting = unitByGUID.IsCasting;
				}
				return isCasting;
			}
			return false;
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x007076F0 File Offset: 0x007058F0
		private static Units WhichUnit(string UnitSelection)
		{
			if (UnitSelection == "Player (Me)")
			{
				return ObjectManager.Me;
			}
			if (UnitSelection == "Target")
			{
				return ObjectManager.GetUnitByGUID(ObjectManager.Me.TargetGUID);
			}
			if (UnitSelection == "Pet" && ObjectManager.Pet.IsReady)
			{
				return ObjectManager.Pet;
			}
			return null;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00707750 File Offset: 0x00705950
		public static void CreateLists()
		{
			SpellRotation.Need.Clear();
			SpellRotation.Need.Add("AlwaysActive", 0);
			SpellRotation.Need.Add("Heal", 0);
			SpellRotation.Need.Add("Food/Drink", 0);
			SpellRotation.Need.Add("Buff/Aura", 0);
			SpellRotation.Need.Add("Conjuring", 0);
			SpellRotation.CanCastWhileWalk.Clear();
			SpellRotation.CanCastWhileWalk.Add("Combat", true);
			SpellRotation.CanCastWhileWalk.Add("AlwaysActive", true);
			SpellRotation.CanCastWhileWalk.Add("Heal", true);
			SpellRotation.CanCastWhileWalk.Add("Food/Drink", true);
			SpellRotation.CanCastWhileWalk.Add("Buff/Aura", true);
			SpellRotation.CanCastWhileWalk.Add("Conjuring", true);
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x00707824 File Offset: 0x00705A24
		public static bool NeedInUse
		{
			get
			{
				foreach (KeyValuePair<string, int> keyValuePair in SpellRotation.Need)
				{
					if (keyValuePair.Value == 2)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x040009C5 RID: 2501
		public static RotationSettings RotationSettings = new RotationSettings();

		// Token: 0x040009C6 RID: 2502
		public static Dictionary<string, int> Need = new Dictionary<string, int>();

		// Token: 0x040009C7 RID: 2503
		public static Dictionary<string, bool> CanCastWhileWalk = new Dictionary<string, bool>();

		// Token: 0x040009C8 RID: 2504
		private static List<UInt128> PetAttackUnits = new List<UInt128>();

		// Token: 0x040009C9 RID: 2505
		private static Dictionary<int, DateTime> CustomCooldownIDs = new Dictionary<int, DateTime>();

		// Token: 0x040009CA RID: 2506
		private static Dictionary<int, int> SpellRepetitions = new Dictionary<int, int>();

		// Token: 0x040009CB RID: 2507
		private static DateTime LastGSEClick = DateTime.Now;

		// Token: 0x040009CC RID: 2508
		private static Random Random = new Random();

		// Token: 0x040009CD RID: 2509
		private static bool ForceTargetRuns = false;

		// Token: 0x040009CE RID: 2510
		private static bool ForceTargetStop = false;

		// Token: 0x040009CF RID: 2511
		private static UInt128 LastTargetGUID = 0;

		// Token: 0x040009D0 RID: 2512
		private static List<string> LOS = new List<string>
		{
			"Target not in line of sight",
			"Ziel ist nicht im Sichtfeld.",
			"Cible hors du champ de vision",
			"No puedes ver al objetivo",
			"Цель вне поля зрения.",
			"Alvo fora do campo de visão."
		};

		// Token: 0x040009D1 RID: 2513
		public static bool CheckHealRuns = false;

		// Token: 0x040009D2 RID: 2514
		public static bool CheckFoodDrinkRuns = false;

		// Token: 0x040009D3 RID: 2515
		public static bool CheckConjuringRuns = false;

		// Token: 0x040009D4 RID: 2516
		public static bool CheckBuffRuns = false;

		// Token: 0x040009D5 RID: 2517
		public static bool CheckAlwaysActiveRuns = false;
	}
}
