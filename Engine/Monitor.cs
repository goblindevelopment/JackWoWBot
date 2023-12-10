using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Jack.ATH;
using Jack.Core;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000CA RID: 202
	internal class Monitor
	{
		// Token: 0x0600151D RID: 5405 RVA: 0x0070E428 File Offset: 0x0070C628
		public static void Watch()
		{
			for (;;)
			{
				if (!Monitor.Runs)
				{
					Monitor.Runs = true;
				}
				if (_globals.IsInWorld && ObjectManager.Me != null)
				{
					Monitor.MonitorDeath();
					if (Monitor.DelayLoopContent1Sec == 0)
					{
						Monitor.MonitorGather();
						Monitor.MonitorPet();
						Monitor.MonitorEnchantments();
						Monitor.MonitorAutoDestroy();
						Monitor.MonitorGlobalEvents();
					}
					if (Monitor.DelayLoopContent3Sec == 0)
					{
						Monitor.MonitorQuests();
					}
				}
				if (Monitor.DelayLoopContent5Sec == 0 && Tools.CountProcess("JKA", "", false) == 0)
				{
					MessageBox.Show("Jack could not start/read all necessary files.\r\nPlease make sure you have added the entire Jack folder to your exceptions.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
				}
				if (Monitor.DelayLoopContent1Sec == 0)
				{
					Tools.SaveLog();
				}
				Monitor.DelayLoopContent1Sec++;
				Monitor.DelayLoopContent2Sec++;
				Monitor.DelayLoopContent3Sec++;
				Monitor.DelayLoopContent4Sec++;
				Monitor.DelayLoopContent5Sec++;
				if (Monitor.DelayLoopContent1Sec == 4)
				{
					Monitor.DelayLoopContent1Sec = 0;
				}
				if (Monitor.DelayLoopContent2Sec == 8)
				{
					Monitor.DelayLoopContent2Sec = 0;
				}
				if (Monitor.DelayLoopContent3Sec == 12)
				{
					Monitor.DelayLoopContent3Sec = 0;
				}
				if (Monitor.DelayLoopContent4Sec == 16)
				{
					Monitor.DelayLoopContent4Sec = 0;
				}
				if (Monitor.DelayLoopContent5Sec == 20)
				{
					Monitor.DelayLoopContent5Sec = 0;
				}
				Thread.Sleep(250);
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0070E560 File Offset: 0x0070C760
		private static void MonitorDeath()
		{
			if (!_globals.Start)
			{
				return;
			}
			if (!ObjectManager.Me.IsDead)
			{
				return;
			}
			_globals.Start = false;
			Monitor.DiedInDungeon = false;
			if (_globals.ModuleDungeon && PlayerMe.IsInDungeon)
			{
				Monitor.DiedInDungeon = true;
				Tools.Console("I died (Dungeon) ;(", "Orange", "richConsole", "frmMain", true);
			}
			else
			{
				Tools.Console("I died ;(", "Orange", "richConsole", "frmMain", true);
			}
			SNS.NotifyGhost("Died");
			while (Walk.Runs)
			{
				Thread.Sleep(500);
			}
			int num = 1;
			if (Walk.ProfileSettings != null)
			{
				num = Walk.ProfileSettings.ExpertResurrectDelay;
			}
			Tools.Console("Releasing corpse in " + num.ToString() + " sec...", "Blue", "richConsole", "frmMain", true);
			Thread.Sleep(num * 1000);
			Addon.LUA("_dead()", "0", false, true);
			string name = Tools.RandomTimer("Dead");
			Jack.Engine.Timer.Set(name, 2000);
			while (_globals.Ready && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(500);
			}
			while (!_globals.Ready && !ObjectManager.Me.IsDead)
			{
				Thread.Sleep(500);
			}
			if (!_globals.Ready)
			{
				name = Tools.RandomTimer("DeadReadyCheck");
				Jack.Engine.Timer.Set(name, 10000);
				while (!_globals.Ready && Jack.Engine.Timer.Check(name) != 0)
				{
					Thread.Sleep(500);
				}
			}
			Thread.Sleep(1000);
			frmMain.Start();
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0070E6E8 File Offset: 0x0070C8E8
		private static void MonitorGather()
		{
			if (!_globals.Ready || !_globals.Start)
			{
				return;
			}
			if (Monitor.ReactToAttackersInGatherMode)
			{
				return;
			}
			if (Walk.ProfileSettings == null)
			{
				return;
			}
			if (ObjectManager.Me.IsFlying && !ObjectManager.Me.IsInVashjir)
			{
				return;
			}
			if (Walk.ProfileSettings.CombatMode == "Gather" && Walk.ProfileSettings.GroundMount && ObjectManager.GetAttackers.Count > 0 && !ObjectManager.Me.IsMounted)
			{
				Monitor.ReactToAttackersInGatherMode = true;
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0070E770 File Offset: 0x0070C970
		private static void MonitorPet()
		{
			if (!_globals.Ready || !_globals.Start)
			{
				return;
			}
			if (Walk.ProfileSettings == null)
			{
				return;
			}
			if (SpellRotation.RotationSettings == null)
			{
				return;
			}
			if (ObjectManager.Me.IsFlying && !ObjectManager.Me.IsInVashjir)
			{
				return;
			}
			if (!Walk.ProfileSettings.FlightMount && !Monitor.PetCall && (Monitor.PetCallTryAgain == default(DateTime) || DateTime.Now.AddSeconds(10.0) <= Monitor.PetCallTryAgain) && (SpellRotation.RotationSettings.PetRevive || SpellRotation.RotationSettings.PetCall) && (!ObjectManager.Me.IsFlying || ObjectManager.Me.IsInVashjir) && !ObjectManager.Me.IsMounted && (!ObjectManager.Pet.IsAvailable || !ObjectManager.Pet.IsReady || !ObjectManager.Pet.IsAlive))
			{
				Rotation rotationSpellByID;
				if (!SpellRotation.RotationSettings.PetRevive)
				{
					rotationSpellByID = ObjectManager.GetRotationSpellByID(SpellRotation.RotationSettings.PetCallSpellID);
				}
				else
				{
					rotationSpellByID = ObjectManager.GetRotationSpellByID(SpellRotation.RotationSettings.PetReviveSpellID);
				}
				if (rotationSpellByID != null && SpellRotation.CooldownIsReady(rotationSpellByID))
				{
					Monitor.PetCall = true;
				}
			}
			if (!Monitor.PetFeed && SpellRotation.RotationSettings.PetFeed && Jack.Engine.Timer.Check("FeedPet") == 0)
			{
				Monitor.PetFeed = true;
			}
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0070E8D8 File Offset: 0x0070CAD8
		private static void MonitorEnchantments()
		{
			if (!_globals.Ready || !_globals.Start)
			{
				return;
			}
			if (Monitor.NeedEnchantment)
			{
				return;
			}
			if (Walk.ProfileSettings == null)
			{
				return;
			}
			if (SpellRotation.RotationSettings == null)
			{
				return;
			}
			if (ObjectManager.Me.IsFlying && !ObjectManager.Me.IsInVashjir)
			{
				return;
			}
			if (SpellRotation.RotationSettings.EnchantMainHand && ObjectManager.NeedEnchantment("MainHand"))
			{
				Monitor.NeedEnchantment = true;
				return;
			}
			if (SpellRotation.RotationSettings.EnchantOffHand && ObjectManager.NeedEnchantment("OffHand"))
			{
				Monitor.NeedEnchantment = true;
			}
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0070E964 File Offset: 0x0070CB64
		private static void MonitorAutoDestroy()
		{
			if (!_globals.Ready || !_globals.Start)
			{
				return;
			}
			if (!Monitor.AutoDestroy)
			{
				return;
			}
			if (ObjectManager.Me.IsFlying && !ObjectManager.Me.IsInVashjir)
			{
				return;
			}
			if (!ObjectManager.Me.IsInCombat)
			{
				Monitor.AutoDestroy = false;
				Addon.AutoDestroy();
				return;
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0070E9BC File Offset: 0x0070CBBC
		private static void MonitorGlobalEvents()
		{
			if (!_globals.Ready || !_globals.Start)
			{
				return;
			}
			if (Monitor.NeedGlobalEvent)
			{
				return;
			}
			if (!ObjectManager.Me.IsInCombat)
			{
				object lockGlobalEvents = Monitor._lockGlobalEvents;
				lock (lockGlobalEvents)
				{
					if (Monitor.WatchGlobalEvents.Count != 0)
					{
						Dictionary<Events, Vector3> dictionary = new Dictionary<Events, Vector3>();
						string a = "";
						foreach (Events events in Monitor.WatchGlobalEvents)
						{
							if (EventManager.CheckConditions(events))
							{
								if (a == "")
								{
									a = events.RouteType;
								}
								if (!(a != events.RouteType))
								{
									dictionary.Add(events, events.TargetLocation);
								}
							}
						}
						if (dictionary.Count != 0)
						{
							if (dictionary.Count == 1)
							{
								Monitor.smethod_0(dictionary.FirstOrDefault<KeyValuePair<Events, Vector3>>().Key);
							}
							else
							{
								Vector3 positionVector = ObjectManager.Me.PositionVector3;
								double num = 0.0;
								Events @event = null;
								foreach (KeyValuePair<Events, Vector3> keyValuePair in dictionary)
								{
									Events key = keyValuePair.Key;
									double num2 = JackMath.Distance(positionVector, keyValuePair.Value, true, true, true);
									if (num == 0.0 || num2 < num)
									{
										num = num2;
										@event = key;
									}
								}
								Monitor.smethod_0(@event);
							}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0070EB9C File Offset: 0x0070CD9C
		private static void MonitorQuests()
		{
			if (!_globals.Ready || !_globals.Start)
			{
				return;
			}
			if (Monitor.CheckQuestIDs.Length == 0)
			{
				return;
			}
			if (Monitor.QuestsCompleted)
			{
				Monitor.QuestsCompleted = false;
			}
			if (Monitor.QuestsEventCompleted)
			{
				Monitor.QuestsEventCompleted = false;
			}
			if (Addon.LUAAwaitingResult("_questsCompleted(\"" + Monitor.CheckQuestIDs + "\")", true, 2000) != "true")
			{
				return;
			}
			Monitor.CheckQuestIDs = "";
			Monitor.QuestsCompleted = true;
			Monitor.QuestsEventCompleted = true;
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x0070EC24 File Offset: 0x0070CE24
		public static bool NeedSomething
		{
			get
			{
				if (!ObjectManager.Me.IsInCombat)
				{
					if (Monitor.NeedSpell)
					{
						return true;
					}
					if (Monitor.PetCall || Monitor.PetFeed)
					{
						return true;
					}
					if (Monitor.NeedEnchantment)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0070EC60 File Offset: 0x0070CE60
		public static bool NeedSpell
		{
			get
			{
				if (!SpellRotation.NeedInUse)
				{
					if (Walk.Check("Conjuring", new Action(SpellRotation.Conjuring), true))
					{
						return true;
					}
					if (Walk.Check("Food/Drink", new Action(SpellRotation.FoodDrink), true))
					{
						return true;
					}
					if (Walk.Check("Heal", new Action(SpellRotation.Heal), true))
					{
						return true;
					}
					if (Walk.Check("Buff/Aura", new Action(SpellRotation.Buff), true))
					{
						return true;
					}
					if (Walk.Check("AlwaysActive", new Action(SpellRotation.AlwaysActive), true))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0070EDA4 File Offset: 0x0070CFA4
		[CompilerGenerated]
		internal static void smethod_0(Events Event)
		{
			EventManager.AddToExecutionListWhenNecessary(Event);
			Monitor.NeedGlobalEventEvent = Event;
			Monitor.NeedGlobalEvent = true;
			Monitor.TriggerGlobalEvent = true;
			Tools.Console("Global Event \"" + Event.RouteType + "\" triggered.", "Blue", "richConsole", "frmMain", true);
		}

		// Token: 0x040009FF RID: 2559
		private static int DelayLoopContent1Sec = 0;

		// Token: 0x04000A00 RID: 2560
		private static int DelayLoopContent2Sec = 0;

		// Token: 0x04000A01 RID: 2561
		private static int DelayLoopContent3Sec = 0;

		// Token: 0x04000A02 RID: 2562
		private static int DelayLoopContent4Sec = 0;

		// Token: 0x04000A03 RID: 2563
		private static int DelayLoopContent5Sec = 0;

		// Token: 0x04000A04 RID: 2564
		public static bool Runs = false;

		// Token: 0x04000A05 RID: 2565
		public static bool MeIsDead = false;

		// Token: 0x04000A06 RID: 2566
		public static bool DiedInDungeon = false;

		// Token: 0x04000A07 RID: 2567
		public static bool ReactToAttackersInGatherMode = false;

		// Token: 0x04000A08 RID: 2568
		public static bool PetCall = false;

		// Token: 0x04000A09 RID: 2569
		public static bool PetFeed = false;

		// Token: 0x04000A0A RID: 2570
		public static DateTime PetCallTryAgain = default(DateTime);

		// Token: 0x04000A0B RID: 2571
		public static bool NeedEnchantment = false;

		// Token: 0x04000A0C RID: 2572
		public static bool AutoDestroy = false;

		// Token: 0x04000A0D RID: 2573
		public static object _lockGlobalEvents = new object();

		// Token: 0x04000A0E RID: 2574
		public static List<Events> WatchGlobalEvents = new List<Events>();

		// Token: 0x04000A0F RID: 2575
		public static bool NeedGlobalEvent = false;

		// Token: 0x04000A10 RID: 2576
		public static bool TriggerGlobalEvent = false;

		// Token: 0x04000A11 RID: 2577
		public static Events NeedGlobalEventEvent = null;

		// Token: 0x04000A12 RID: 2578
		public static string CheckQuestIDs = "";

		// Token: 0x04000A13 RID: 2579
		public static bool QuestsCompleted = false;

		// Token: 0x04000A14 RID: 2580
		public static bool QuestsEventCompleted = false;
	}
}
