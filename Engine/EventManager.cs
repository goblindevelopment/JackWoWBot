using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using Jack.ATH;
using Jack.Core;
using Jack.Forms;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000C1 RID: 193
	public static class EventManager
	{
		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00707A14 File Offset: 0x00705C14
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x00707A28 File Offset: 0x00705C28
		public static List<int> Execution { get; set; } = new List<int>();

		// Token: 0x06001488 RID: 5256 RVA: 0x00707A3C File Offset: 0x00705C3C
		public static void Start(Vector3 Crd)
		{
			foreach (Events events in _globals.Events)
			{
				if (!(events.Vector3 != Crd) && EventManager.CheckConditions(events) && (!EventManager.IsAction(events.Action, "Add Route...") || events.Route.Count != 0))
				{
					EventManager.GettingAttacked = false;
					string name = events.Name;
					string action = events.Action;
					if (_globals.KeyStatus["TurnLeft"])
					{
						Key.Release("TurnLeft");
					}
					if (_globals.KeyStatus["TurnRight"])
					{
						Key.Release("TurnRight");
					}
					Tools.Console("# Event -> " + name, "Blue", "richConsole", "frmMain", true);
					if (EventManager.IsAction(action, "Add Route..."))
					{
						EventManager.LoadRoute(events);
					}
					else if (EventManager.IsAction(action, "Interact with..."))
					{
						EventManager.InteractWith(events);
					}
					else if (!EventManager.IsAction(action, "Wait..."))
					{
						if (EventManager.IsAction(action, "Load Profile..."))
						{
							EventManager.LoadProfile(events, "");
							break;
						}
						if (!EventManager.IsAction(action, "Cast Spell..."))
						{
							if (EventManager.IsAction(action, "Change Walk Sensitivity..."))
							{
								EventManager.ChangeWalkSens(events);
							}
							else if (EventManager.IsAction(action, "Enter/Leave Dungeon"))
							{
								EventManager.EnterLeaveDungeon(events);
							}
							else if (EventManager.IsAction(action, "Go through Portal"))
							{
								EventManager.GoThroughPortal();
							}
							else if (EventManager.IsAction(action, "Start Combat"))
							{
								EventManager.StartCombat(events);
							}
							else if (EventManager.IsAction(action, "Start walking"))
							{
								EventManager.StartWalking();
							}
							else if (EventManager.IsAction(action, "Stop walking"))
							{
								EventManager.StopWalking();
							}
							else if (EventManager.IsAction(action, "Use Hearthstone..."))
							{
								EventManager.CheckHearthstone(events);
							}
							else if (!EventManager.IsAction(action, "Start Fishing..."))
							{
								if (EventManager.IsAction(action, "Jump"))
								{
									EventManager.Jump();
								}
								else if (EventManager.IsAction(action, "Jump while walk"))
								{
									EventManager.JumpWhileWalk();
								}
								else if (!EventManager.IsAction(action, "Walk while Jump"))
								{
									if (EventManager.IsAction(action, "Loot"))
									{
										EventManager.Loot();
									}
									else if (EventManager.IsAction(action, "Reset Dungeons"))
									{
										EventManager.ResetDungeons();
									}
									else if (!EventManager.IsAction(action, "Facing next Waypoint"))
									{
										if (EventManager.IsAction(action, "Use Transport..."))
										{
											EventManager.UseTransport(events);
											break;
										}
										if (EventManager.IsAction(action, "Start Swimming"))
										{
											EventManager.StartSwimming();
										}
										else if (EventManager.IsAction(action, "Stop Swimming"))
										{
											EventManager.StopSwimming();
										}
										else if (EventManager.IsAction(action, "Execute LUA..."))
										{
											EventManager.ExecuteLUA(events);
										}
										else
										{
											if (EventManager.IsAction(action, "Join Battlegrounds (Classic)..."))
											{
												EventManager.JoinBattlegroundsClassic(events);
												break;
											}
											if (EventManager.IsAction(action, "Stop"))
											{
												EventManager.Stop(true);
												break;
											}
											if (EventManager.IsAction(action, "Take Quest"))
											{
												EventManager.TakeQuest(events);
											}
											else if (EventManager.IsAction(action, "Turn-In Quest"))
											{
												EventManager.TurnInQuest(events);
											}
											else if (!EventManager.IsAction(action, "Load Rotation..."))
											{
												if (EventManager.IsAction(action, "Change Profile Settings..."))
												{
													EventManager.ChangeProfileSettings(events);
												}
											}
											else
											{
												EventManager.LoadRotation(events);
											}
										}
									}
									else
									{
										EventManager.FacingNextWaypoint();
									}
								}
								else
								{
									EventManager.WalkWhileJump();
								}
							}
							else
							{
								EventManager.Fishing(events);
							}
						}
						else
						{
							EventManager.CastSpell(events);
						}
					}
					else
					{
						EventManager.Wait(events);
					}
					EventManager.AddToExecutionListWhenNecessary(events);
					Fly.Stop = false;
				}
			}
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00707DF4 File Offset: 0x00705FF4
		public static void AddToExecutionListWhenNecessary(Events Event)
		{
			object lockExecutionList = EventManager._lockExecutionList;
			lock (lockExecutionList)
			{
				if (!Event.SettingsExecuteAlways && !EventManager.Execution.Contains(Event.ID))
				{
					EventManager.Execution.Add(Event.ID);
				}
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00707E58 File Offset: 0x00706058
		private static bool IsOnExecutionList(Events Event)
		{
			object lockExecutionList = EventManager._lockExecutionList;
			bool result;
			lock (lockExecutionList)
			{
				result = EventManager.Execution.Contains(Event.ID);
			}
			return result;
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00707EA4 File Offset: 0x007060A4
		public static void LoadRoute(Events Event)
		{
			EventManager.<>c__DisplayClass17_0 CS$<>8__locals1;
			CS$<>8__locals1.Event = Event;
			if (CS$<>8__locals1.Event == null)
			{
				return;
			}
			CS$<>8__locals1.RouteType = CS$<>8__locals1.Event.RouteType;
			CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[0];
			if (CS$<>8__locals1.RouteType == "Vendor")
			{
				if (CS$<>8__locals1.Event.VendorMount)
				{
					CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[]
					{
						"Fly down",
						"Vendor Mount",
						"Walk back"
					};
				}
				else
				{
					CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[]
					{
						"Fly down",
						"Navigate to location",
						"Talk to NPC",
						CS$<>8__locals1.Event.RouteType,
						"Turn180",
						"Reset Global Events",
						"Walk back"
					};
				}
				Walk.ProfileSettings.CombatMode = CS$<>8__locals1.Event.CombatMode;
				EventManager.smethod_0(false, ref CS$<>8__locals1);
				return;
			}
			if (CS$<>8__locals1.RouteType == "Trainer" || CS$<>8__locals1.RouteType == "Set Hearthstone")
			{
				CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[]
				{
					"Fly down",
					"Navigate to location",
					"Talk to NPC",
					CS$<>8__locals1.Event.RouteType,
					"Turn180",
					"Reset Global Events",
					"Walk back"
				};
				Walk.ProfileSettings.CombatMode = CS$<>8__locals1.Event.CombatMode;
				EventManager.smethod_0(false, ref CS$<>8__locals1);
				return;
			}
			if (CS$<>8__locals1.RouteType == "Mailbox")
			{
				if (EventManager.HasItemsToSend(CS$<>8__locals1.Event, 0))
				{
					CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[]
					{
						"Fly down",
						"Navigate to location",
						"Interact with Object",
						CS$<>8__locals1.Event.RouteType,
						"Turn180",
						"Reset Global Events",
						"Walk back"
					};
					Walk.ProfileSettings.CombatMode = CS$<>8__locals1.Event.CombatMode;
					EventManager.smethod_0(false, ref CS$<>8__locals1);
					return;
				}
				return;
			}
			else
			{
				if (!(CS$<>8__locals1.RouteType == "Flight Master"))
				{
					if (CS$<>8__locals1.RouteType == "Ghost")
					{
						if (_globals.ModuleDungeon && Monitor.DiedInDungeon)
						{
							CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[]
							{
								"Fly down",
								"Go through Portal",
								"Load default Profile"
							};
						}
						else
						{
							CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[]
							{
								"Fly down",
								"Load default Profile"
							};
						}
						Walk.ProfileSettings.CombatMode = CS$<>8__locals1.Event.CombatMode;
						EventManager.smethod_0(CS$<>8__locals1.Event.GhostDirectionPathToGraveyard, ref CS$<>8__locals1);
					}
					return;
				}
				CS$<>8__locals1.WhatToDoAtEndOfRoute = new string[]
				{
					"Fly down",
					"Navigate to location",
					"Dismount",
					"Talk to NPC",
					CS$<>8__locals1.Event.RouteType,
					"Load Profile {" + CS$<>8__locals1.Event.FlightPointProfile + "}"
				};
				Walk.ProfileSettings.CombatMode = CS$<>8__locals1.Event.CombatMode;
				EventManager.smethod_0(false, ref CS$<>8__locals1);
				return;
			}
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x007081C8 File Offset: 0x007063C8
		private static void NewEndOfRoute(Events Event, string[] ToDo)
		{
			EventManager.EndOfRoute.Clear();
			List<string> list = new List<string>();
			foreach (string item in ToDo)
			{
				list.Add(item);
			}
			EventManager.EndOfRoute.Add(Event, list);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0070820C File Offset: 0x0070640C
		public static void DoEndOfRoute()
		{
			if (EventManager.EndOfRoute.Count > 0)
			{
				bool flag = true;
				Events events = EventManager.EndOfRoute.Keys.FirstOrDefault<Events>();
				List<string> list = new List<string>();
				list = EventManager.EndOfRoute.Values.FirstOrDefault<List<string>>();
				foreach (string text in list)
				{
					EventManager.GettingAttacked = false;
					if (!(text == "Fly down"))
					{
						if (!(text == "Navigate to location"))
						{
							if (!(text == "Talk to NPC"))
							{
								if (text == "Interact with Object")
								{
									EventManager.InteractWithObject(events, false);
								}
								else if (!(text == "Dismount"))
								{
									if (!(text == "Vendor"))
									{
										if (!(text == "Vendor Mount"))
										{
											if (!(text == "Trainer"))
											{
												if (text == "Set Hearthstone")
												{
													EventManager.SetHearthstone(events);
												}
												else if (text == "Flight Master")
												{
													EventManager.FlightMaster(events);
												}
												else if (!(text == "Mailbox"))
												{
													if (text == "Reverse Route")
													{
														EventManager.ReverseRoute(events);
													}
													else if (text == "Load default Profile")
													{
														EventManager.LoadDefaultProfile();
													}
													else if (!text.Contains("Load Profile {"))
													{
														if (!(text == "Walk back"))
														{
															if (!(text == "Walk"))
															{
																if (!(text == "Turn180"))
																{
																	if (!(text == "Go through Portal"))
																	{
																		if (text == "Reset Global Events")
																		{
																			EventManager.ResetGlobalEvents();
																		}
																	}
																	else
																	{
																		EventManager.GoThroughPortal();
																	}
																}
																else
																{
																	Key.Turn180();
																}
															}
															else
															{
																EventManager.StartWalking();
															}
														}
														else
														{
															EventManager.WalkBack(events);
															flag = false;
														}
													}
													else
													{
														string profileName = text.Split(new char[]
														{
															'{',
															'}'
														})[1];
														EventManager.LoadProfile(events, profileName);
													}
												}
												else
												{
													EventManager.Mailbox();
												}
											}
											else
											{
												EventManager.Trainer(events);
											}
										}
										else
										{
											EventManager.VendorMount(events);
										}
									}
									else
									{
										EventManager.Vendor();
									}
								}
								else
								{
									EventManager.Dismount();
								}
							}
							else
							{
								EventManager.TalkToNPC(events, false);
							}
						}
						else if (EventManager.NavigateToLocation(events, list))
						{
							flag = false;
							break;
						}
					}
					else
					{
						EventManager.FlyDown();
					}
					if (EventManager.CancelEndOfRoute)
					{
						EventManager.CancelEndOfRoute = false;
						_globals.Start = false;
						flag = true;
						break;
					}
				}
				if (flag)
				{
					EventManager.EndOfRoute.Clear();
				}
				Fly.Stop = false;
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x007084BC File Offset: 0x007066BC
		private static void FlyDown()
		{
			if (ObjectManager.Me.IsFlying)
			{
				Fly.Stop = true;
				Key.Release("All");
				Fly.MoveDown(default(Vector3), "", false);
			}
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x007084FC File Offset: 0x007066FC
		private static bool NavigateToLocation(Events Event, List<string> DoEndOfRoute = null)
		{
			if (Event.Route.Count > 0)
			{
				return false;
			}
			List<Vector3> list = Pathfinder.Navigate(ObjectManager.Me.PositionVector3, Event.TargetLocation, false, -1);
			object @lock = EventManager._lock;
			lock (@lock)
			{
				_globals.Waypoints.Clear();
				foreach (Vector3 item in list)
				{
					_globals.Waypoints.Add(item);
				}
				Walk.Counter = 0;
			}
			if (DoEndOfRoute != null)
			{
				foreach (string text in DoEndOfRoute.ToList<string>())
				{
					DoEndOfRoute.Remove(text);
					if (text == "Navigate to location")
					{
						break;
					}
				}
			}
			EventManager.NewEndOfRoute(Event, DoEndOfRoute.ToArray());
			return true;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0070861C File Offset: 0x0070681C
		public static void TalkToNPC(object EventOrDisplayID, bool LastTry = false)
		{
			int num;
			if (EventOrDisplayID.GetType() == typeof(Events))
			{
				num = ((Events)EventOrDisplayID).TargetDisplayID;
			}
			else
			{
				num = (int)EventOrDisplayID;
			}
			Key.Release("All");
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				Units npcbyDisplayID = ObjectManager.GetNPCByDisplayID(num);
				if (npcbyDisplayID != null)
				{
					Vector3 positionVector = npcbyDisplayID.PositionVector3;
					Tools.Console("Talking to NPC \"" + npcbyDisplayID.Name + "\".", "Blue", "richConsole", "frmMain", true);
					if (JackMath.Distance(positionVector, true, true, true) > 4.0)
					{
						double num2 = JackMath.Distance(npcbyDisplayID.PositionVector3, true, true, true);
						while (_globals.Start && !_globals.NoCheck && num2 > 2.5)
						{
							Walk.Facing(npcbyDisplayID.PositionVector3, npcbyDisplayID, 2.0, 0.5f, null);
							num2 = JackMath.Distance(npcbyDisplayID.PositionVector3, true, true, true);
							Thread.Sleep(100);
						}
					}
					Key.Release("All");
					Thread.Sleep(250);
					while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.TargetDisplayID != num)
					{
						ObjectManager.Interaction(num, "TargetMouseover");
						Thread.Sleep(500);
					}
					ObjectManager.Interaction(num, "InteractMouseover");
				}
				else if (LastTry)
				{
					EventManager.CancelEndOfRoute = true;
				}
				else
				{
					Tools.Console("NPC not found.", "Blue", "richConsole", "frmMain", true);
					Tools.Console("Try again in 2 sec.", "Blue", "richConsole", "frmMain", true);
					Thread.Sleep(2000);
					EventManager.TalkToNPC(EventOrDisplayID, true);
				}
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x007087F8 File Offset: 0x007069F8
		public static void Vendor()
		{
			Tools.Console("Selling...", "Blue", "richConsole", "frmMain", true);
			int count = ObjectManager.GetItems.Count;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				if (count > 0)
				{
					string name = Tools.RandomTimer("Vendor");
					Timer.Set(name, 60000);
					while (_globals.Start)
					{
						if (_globals.NoCheck || Timer.Check(name) == 0)
						{
							break;
						}
						Thread.Sleep(2000);
						if (Frames.Check("jkWaitForNPC", "Done", true))
						{
							Frames.ResetText("jkWaitForNPC");
							break;
						}
					}
				}
			}
			int count2 = ObjectManager.GetItems.Count;
			string text = "Vendor done.";
			if (count2 < count)
			{
				text = (count - count2).ToString() + " items sold. Vendor done.";
			}
			SNS.NotifyEvent(text);
			Tools.Console(text, "", "richConsole", "frmMain", true);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00708900 File Offset: 0x00706B00
		private static void VendorMount(Events Event)
		{
			if (!_globals.Keys.ContainsKey("VendorMount") || _globals.Keys["VendorMount"] == "NotSet")
			{
				Tools.Console("VendorMount Keybind is not set.", "Red", "richConsole", "frmMain", true);
				return;
			}
			Key.Release("All");
			Thread.Sleep(250);
			string name = Tools.RandomTimer("Dismount");
			Timer.Set(name, 5000);
			while (_globals.Start && !_globals.NoCheck && Timer.Check(name) != 0 && ObjectManager.Me.IsMounted)
			{
				Walk.Mount(false, false);
				Thread.Sleep(250);
			}
			name = Tools.RandomTimer("Mount");
			Timer.Set(name, 60000);
			Vector3 positionVector = ObjectManager.Me.PositionVector3;
			int num = 0;
			while (_globals.Start && !_globals.NoCheck && Timer.Check(name) != 0)
			{
				EventManager.WatchAttackers(positionVector);
				Thread.Sleep(250);
				if (!ObjectManager.Me.IsCasting && !ObjectManager.Me.IsChanneling)
				{
					Thread.Sleep(500);
					if (ObjectManager.Me.IsMounted || num >= 8)
					{
						break;
					}
					Key.Release("All");
					Thread.Sleep(250);
					Key.Press("VendorMount");
					Thread.Sleep(30);
					Key.Release("VendorMount");
					num++;
				}
			}
			if (!ObjectManager.Me.IsMounted || num >= 8)
			{
				Tools.Console("Couldn't cast Vendor Mount.", "Red", "richConsole", "frmMain", true);
				return;
			}
			int targetDisplayID = Event.TargetDisplayID;
			Units units = null;
			UInt128 @uint = 0;
			name = Tools.RandomTimer("SelectVendor");
			Timer.Set(name, 30000);
			while (_globals.Start && !_globals.NoCheck && Timer.Check(name) != 0)
			{
				Thread.Sleep(500);
				units = ObjectManager.GetFurthestNPCByDisplayID(targetDisplayID);
				if (units != null)
				{
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						@uint = units.GUID128;
						if (@uint != EventManager.LastVendorMountGUID)
						{
							break;
						}
					}
				}
			}
			if (units == null)
			{
				Tools.Console("Couldn't find Vendor.", "Red", "richConsole", "frmMain", true);
				return;
			}
			EventManager.LastVendorMountGUID = @uint;
			while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.TargetGUID != @uint)
			{
				ObjectManager.Interaction(@uint, "TargetMouseover");
				Thread.Sleep(500);
			}
			ObjectManager.Interaction(@uint, "InteractMouseover");
			Thread.Sleep(500);
			EventManager.Vendor();
			Walk.Mount(false, false);
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00708BD0 File Offset: 0x00706DD0
		private static void Trainer(Events Event)
		{
			Tools.Console("Train...", "Blue", "richConsole", "frmMain", true);
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				string name = Tools.RandomTimer("Trainer");
				Timer.Set(name, 30000);
				while (_globals.Start)
				{
					if (_globals.NoCheck || Timer.Check(name) == 0)
					{
						break;
					}
					Thread.Sleep(2000);
					if (Frames.Check("jkWaitForNPC", "Done", true))
					{
						Frames.ResetText("jkWaitForNPC");
						break;
					}
				}
			}
			Tools.Console("Training completed.", "Blue", "richConsole", "frmMain", true);
			SNS.NotifyEvent("Training completed.");
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00708CA0 File Offset: 0x00706EA0
		private static void SetHearthstone(Events Event)
		{
			string str = EventManager.ZoneNameAddition(true, false);
			Tools.Console("Set Hearthstone" + str + ".", "Blue", "richConsole", "frmMain", true);
			SNS.NotifyEvent("Hearthstone set" + str + ".");
			Thread.Sleep(2000);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00708CFC File Offset: 0x00706EFC
		private static void CheckHearthstone(Events Event)
		{
			if (!Spell.IsReadyOrExists(8690, true))
			{
				EventManager.HearthstoneEvent = Event;
				EventManager.UseMyHearthstone = true;
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00708D24 File Offset: 0x00706F24
		public static void UseHearthstone()
		{
			if (!ObjectManager.Me.IsInCombat)
			{
				EventManager.FlyDown();
				Key.Release("All");
				_globals.AutoStart = true;
				Thread.Sleep(1000);
				while (_globals.Start && !_globals.NoCheck && !ObjectManager.Me.IsInCombat && !ObjectManager.Me.IsCasting)
				{
					Key.Press("Hearthstone");
					Thread.Sleep(30);
					Key.Release("Hearthstone");
					Thread.Sleep(1000);
				}
				string name = Tools.RandomTimer("Hearthstone");
				Timer.Set(name, 8000);
				while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.IsCasting && !ObjectManager.Me.IsInCombat)
				{
					Thread.Sleep(250);
				}
				Thread.Sleep(2000);
				while (!_globals.Start && !_globals.NoCheck)
				{
					Thread.Sleep(100);
				}
				_globals.AutoStart = false;
				if (!ObjectManager.Me.IsInCombat && Timer.Check(name) == 0)
				{
					EventManager.LoadProfileAfterHearthstone = true;
					EventManager.UseMyHearthstone = false;
				}
				SNS.NotifyEvent("Used my Hearthstone" + EventManager.ZoneNameAddition(true, false) + ".");
				Fly.Stop = false;
			}
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00708E5C File Offset: 0x0070705C
		public static void Fishing(Events Event)
		{
			EventManager.FlyDown();
			Jack.Engine.Fishing.Event = Event;
			Jack.Engine.Fishing.IsFaced = false;
			Jack.Engine.Fishing.Start(Event.Vector3, Event.FishingUseBait);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00708E8C File Offset: 0x0070708C
		private static void FlightMaster(Events Event)
		{
			_globals.NoCheck = true;
			while (_globals.Start)
			{
				Thread.Sleep(1500);
				if (ObjectManager.Me.IsMounted && ObjectManager.Me.IsMoving)
				{
					break;
				}
				EventManager.TalkToNPC(Event, false);
			}
			Tools.Console("-> Flying to \"" + Event.FlightPointName + "\".", "Blue", "richConsole", "frmMain", true);
			while (_globals.Start && ObjectManager.Me.IsMounted && ObjectManager.Me.IsMoving)
			{
				Thread.Sleep(1000);
			}
			Tools.Console("Arrived" + EventManager.ZoneNameAddition(true, false) + ".", "Blue", "richConsole", "frmMain", true);
			SNS.NotifyEvent("Arrived" + EventManager.ZoneNameAddition(true, false) + ".");
			Thread.Sleep(1000);
			_globals.NoCheck = false;
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00708F7C File Offset: 0x0070717C
		private static void InteractWith(Events Event)
		{
			Key.Release("All");
			string interactNameOrID = Event.InteractNameOrID;
			Units units = null;
			Objects objects = null;
			if (Event.InteractNameOrID.Length > 0)
			{
				int displayID = 0;
				if (!int.TryParse(Event.InteractNameOrID, out displayID))
				{
					Units npcbyName = ObjectManager.GetNPCByName(interactNameOrID);
					Objects objectByName = ObjectManager.GetObjectByName(interactNameOrID);
					object @lock;
					if (npcbyName != null)
					{
						@lock = ObjectManager._lock;
						lock (@lock)
						{
							if (!Event.InteractWithClosest)
							{
								units = ObjectManager.GetFurthestNPCByDisplayID(npcbyName.DisplayID);
							}
							else
							{
								units = ObjectManager.GetClosestNPCByDisplayID(npcbyName.DisplayID);
							}
						}
					}
					if (objectByName == null)
					{
						goto IL_107;
					}
					@lock = ObjectManager._lock;
					lock (@lock)
					{
						if (Event.InteractWithClosest)
						{
							objects = ObjectManager.GetClosestObjectByDisplayID(objectByName.DisplayID);
							goto IL_107;
						}
						objects = ObjectManager.GetFurthestObjectByDisplayID(objectByName.DisplayID);
						goto IL_107;
					}
				}
				if (!Event.InteractWithClosest)
				{
					units = ObjectManager.GetFurthestNPCByDisplayID(displayID);
					objects = ObjectManager.GetFurthestObjectByDisplayID(displayID);
				}
				else
				{
					units = ObjectManager.GetClosestNPCByDisplayID(displayID);
					objects = ObjectManager.GetClosestObjectByDisplayID(displayID);
				}
			}
			IL_107:
			UInt128 @uint = 0;
			Vector3 vector = default(Vector3);
			bool flag2 = false;
			if (units != null)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					@uint = units.GUID128;
					vector = units.PositionVector3;
					goto IL_187;
				}
			}
			if (objects != null)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					@uint = objects.GUID128;
					vector = objects.PositionVector3;
					flag2 = objects.IsGather;
				}
			}
			IL_187:
			if (!(@uint > 0) || !(vector != default(Vector3)))
			{
				Tools.Console("Couldn't find \"" + interactNameOrID + "\".", "Orange", "richConsole", "frmMain", true);
				return;
			}
			int num = 4;
			bool flag3 = true;
			if (Event.InteractWithAttack)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					if (units != null)
					{
						flag3 = units.IsAlive;
					}
				}
				num = SpellRotation.RotationSettings.PullDistance;
			}
			if (!flag3)
			{
				Tools.Console("Unit is dead.", "Blue", "richConsole", "frmMain", true);
				return;
			}
			EventManager.FlyDown();
			Tools.Console("Event -> Interact with \"" + interactNameOrID + "\".", "Blue", "richConsole", "frmMain", true);
			if (units != null)
			{
				while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.TargetGUID != @uint)
				{
					ObjectManager.Interaction(@uint, "TargetMouseover");
					Thread.Sleep(100);
				}
			}
			if (JackMath.Distance(vector, true, true, true) > (double)num)
			{
				Walk.Facing(vector, units, (double)num, 0.5f, null);
				Key.Release("All");
			}
			if (!Event.InteractWithAttack)
			{
				ObjectManager.Interaction(@uint, "InteractMouseover");
				Timer.Set("InteractWith", 1500);
				while (_globals.Start && !_globals.NoCheck && Timer.Check("InteractWith") != 0)
				{
					Thread.Sleep(500);
					ObjectManager.Interaction(@uint, "InteractMouseover");
				}
				if (flag2)
				{
					int num2 = 0;
					string name = Tools.RandomTimer("InteractWith");
					Timer.Set(name, 30000);
					while (_globals.Start && !_globals.NoCheck && Timer.Check(name) != 0)
					{
						EventManager.WatchAttackers(vector);
						object @lock = ObjectManager._lock;
						lock (@lock)
						{
							if (objects == null)
							{
								break;
							}
							if (!ObjectManager.Me.IsCasting)
							{
								if (num2 == 2)
								{
									Tools.Console("Event -> Interact with \"" + interactNameOrID + "\" -> Locked or not usable.", "Blue", "richConsole", "frmMain", true);
									break;
								}
								ObjectManager.Interaction(@uint, "InteractMouseover");
								num2++;
							}
							else
							{
								while (ObjectManager.Me.IsCasting && ObjectManager.GetAttackers.Count == 0)
								{
									Thread.Sleep(250);
								}
								if (ObjectManager.GetAttackers.Count == 0)
								{
									break;
								}
							}
						}
						Thread.Sleep(250);
					}
				}
				while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.IsCasting)
				{
					Thread.Sleep(250);
				}
				Thread.Sleep(1000);
				return;
			}
			Tools.Console("Event -> Interact with \"" + interactNameOrID + "\" -> Attack", "Blue", "richConsole", "frmMain", true);
			Combat.SearchForUnitsToAttack(vector);
			Combat.OffensiveAttack();
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00709460 File Offset: 0x00707660
		public static void InteractWithObject(object EventOrDisplayID, bool LastTry = false)
		{
			int num;
			if (!(EventOrDisplayID.GetType() == typeof(Events)))
			{
				num = (int)EventOrDisplayID;
			}
			else
			{
				num = ((Events)EventOrDisplayID).TargetDisplayID;
			}
			Key.Release("All");
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				Objects objectByDisplayID = ObjectManager.GetObjectByDisplayID(num);
				if (objectByDisplayID != null)
				{
					Vector3 positionVector = objectByDisplayID.PositionVector3;
					Tools.Console(string.Concat(new string[]
					{
						"Interact with \"",
						objectByDisplayID.Name,
						"\" (",
						num.ToString(),
						")."
					}), "Blue", "richConsole", "frmMain", true);
					if (JackMath.Distance(positionVector, true, true, true) > 4.0)
					{
						Walk.GoTo(positionVector, 4.0, 0.5f, null);
						Key.Release("All");
					}
					Thread.Sleep(250);
					ObjectManager.Interaction(num, "InteractMouseover");
				}
				else if (!LastTry)
				{
					Tools.Console("Object not found.", "Blue", "richConsole", "frmMain", true);
					Tools.Console("Try again in 2 sec.", "Blue", "richConsole", "frmMain", true);
					Thread.Sleep(2000);
					EventManager.InteractWithObject(EventOrDisplayID, true);
				}
				else
				{
					EventManager.CancelEndOfRoute = true;
				}
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x007095E4 File Offset: 0x007077E4
		public static void Mailbox()
		{
			Tools.Console("Sending Items...", "Blue", "richConsole", "frmMain", true);
			int count = ObjectManager.GetItems.Count;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				if (count > 0)
				{
					string name = Tools.RandomTimer("Mailbox");
					Timer.Set(name, 60000);
					while (_globals.Start)
					{
						if (_globals.NoCheck || Timer.Check(name) == 0)
						{
							break;
						}
						Thread.Sleep(2000);
						if (Frames.Check("jkWaitForNPC", "Done", true))
						{
							Frames.ResetText("jkWaitForNPC");
							break;
						}
					}
				}
			}
			int count2 = ObjectManager.GetItems.Count;
			string text = "Mailing done.";
			if (count2 < count)
			{
				text = (count - count2).ToString() + " items sent. Mailing done.";
			}
			SNS.NotifyEvent(text);
			Tools.Console(text, "", "richConsole", "frmMain", true);
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x007096EC File Offset: 0x007078EC
		private static void Wait(Events Event)
		{
			if (Event.Wait && Event.WaitInSeconds > 0 && Event.WaitInMS > 0)
			{
				Key.Release("All");
				Tools.Console("Event -> Waiting for \"" + Event.WaitInSeconds.ToString() + " seconds\"...", "Blue", "richConsole", "frmMain", true);
				string name = "Wait-" + EventManager.Rnd.Next(100000, 999999).ToString();
				Timer.Set(name, Event.WaitInMS);
				while (_globals.Start && !_globals.NoCheck && Timer.Check(name) != 0)
				{
					if (!Event.WaitIgnoreAttackers)
					{
						EventManager.WatchAttackers(Event.Vector3);
					}
					Thread.Sleep(250);
				}
				if (!Event.WaitIgnoreAttackers)
				{
					EventManager.WatchAttackers(Event.Vector3);
					return;
				}
			}
			else if (Event.WaitFor && Event.WaitForNameOrID.Length > 0)
			{
				Key.Release("All");
				Tools.Console(string.Concat(new string[]
				{
					"Event -> Waiting for \"",
					Event.WaitForNameOrID.ToString(),
					"\" (max. ",
					Event.WaitForMaxSeconds.ToString(),
					" sec.)..."
				}), "Blue", "richConsole", "frmMain", true);
				string waitForNameOrID = Event.WaitForNameOrID;
				Units units = null;
				Objects objects = null;
				if (Event.WaitForNameOrID.Length > 0 && Event.WaitForMaxSecondsInMS > 0)
				{
					string name2 = Tools.RandomTimer("WaitFor");
					Timer.Set(name2, Event.WaitForMaxSecondsInMS);
					while (_globals.Start && !_globals.NoCheck && Timer.Check(name2) != 0)
					{
						if (Tools.IsNumber(Event.WaitForNameOrID, 1, 0, 1, 0))
						{
							int displayID = Convert.ToInt32(Event.WaitForNameOrID);
							units = ObjectManager.GetClosestNPCByDisplayID(displayID);
							objects = ObjectManager.GetClosestObjectByDisplayID(displayID);
						}
						else
						{
							Units npcbyName = ObjectManager.GetNPCByName(waitForNameOrID);
							Objects objectByName = ObjectManager.GetObjectByName(waitForNameOrID);
							if (npcbyName != null)
							{
								object @lock = ObjectManager._lock;
								lock (@lock)
								{
									units = ObjectManager.GetClosestNPCByDisplayID(npcbyName.DisplayID);
								}
							}
							if (objectByName != null)
							{
								object @lock = ObjectManager._lock;
								lock (@lock)
								{
									objects = ObjectManager.GetClosestObjectByDisplayID(objectByName.DisplayID);
								}
							}
						}
						if (units != null || objects != null)
						{
							break;
						}
						Thread.Sleep(1000);
					}
					if (Event.WaitForGateOrDoor && objects != null)
					{
						name2 = Tools.RandomTimer("GetGates");
						Timer.Set(name2, 3000);
						Tools.Console("Tracking Gate(s)...", "Blue", "richConsole", "frmMain", true);
						List<Objects> list = new List<Objects>();
						List<Objects> list2 = new List<Objects>();
						int num = 0;
						int num2 = 0;
						while (_globals.Start && !_globals.NoCheck && Timer.Check(name2) != 0)
						{
							object @lock = ObjectManager._lock;
							lock (@lock)
							{
								list = ObjectManager.GetObjectsByDisplayID(objects.DisplayID);
								num = list.Count;
								if (list2.Count == 0)
								{
									list2 = list;
								}
							}
							Thread.Sleep(500);
						}
						if (num == 0)
						{
							Tools.Console("No Gate(s) found.", "Orange", "richConsole", "frmMain", true);
							return;
						}
						if (_globals.IsInBattleground)
						{
							bool flag2 = false;
							if (PlayerMe.BattlegroundName.Contains("Warsong") && num == 4)
							{
								flag2 = true;
							}
							if (flag2)
							{
								Tools.Console("Gates are already open.", "Green", "richConsole", "frmMain", true);
								return;
							}
						}
						Tools.Console(num.ToString() + " Gate(s) counted.", "", "richConsole", "frmMain", true);
						Tools.Console("Waiting for new Gate state...", "", "richConsole", "frmMain", true);
						name2 = Tools.RandomTimer("WaitForGates");
						Timer.Set(name2, Event.WaitForMaxSecondsInMS);
						bool flag3 = false;
						while (_globals.Start && !_globals.NoCheck && Timer.Check(name2) != 0)
						{
							object @lock = ObjectManager._lock;
							lock (@lock)
							{
								list = ObjectManager.GetObjectsByDisplayID(objects.DisplayID);
								num2 = list.Count;
								using (List<Objects>.Enumerator enumerator = list2.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										Objects objects2 = enumerator.Current;
										Objects objectByDisplayID = ObjectManager.GetObjectByDisplayID(objects2.DisplayID);
										if (objectByDisplayID != null)
										{
											int flags = objects2.Flags;
											int flags2 = objectByDisplayID.Flags;
											if (flags > 0 && flags2 > 0 && flags != flags2)
											{
												flag3 = true;
												break;
											}
										}
									}
									goto IL_4A7;
								}
							}
							IL_498:
							Thread.Sleep(500);
							continue;
							IL_4A7:
							if (num2 < num || flag3)
							{
								Tools.Console("Gate(s) are open.", "", "richConsole", "frmMain", true);
								return;
							}
							goto IL_498;
						}
					}
				}
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00709C24 File Offset: 0x00707E24
		private static void ReverseRoute(Events Event)
		{
			object @lock = EventManager._lock;
			lock (@lock)
			{
				_globals.Waypoints.Clear();
				foreach (Vector3 item in Event.Route)
				{
					_globals.Waypoints.Add(item);
				}
				_globals.Waypoints.Reverse();
				Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00709CC8 File Offset: 0x00707EC8
		public static void LoadProfile(Events Event = null, string ProfileName = "")
		{
			if (Event != null && ProfileName.Length == 0)
			{
				ProfileName = Event.LoadProfile;
			}
			if (ProfileName.Length > 0)
			{
				Json.LoadProfile(ProfileName, false, false, _globals.IsPremiumProfile);
				Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
				Walk.StartMonitoring();
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00709D14 File Offset: 0x00707F14
		private static void LoadDefaultProfile()
		{
			Tools.Console("Load default Profile \"" + Settings.SelectedProfile + "\".", "Blue", "richConsole", "frmMain", true);
			Json.LoadProfile(Settings.SelectedProfile, false, false, _globals.IsPremiumProfile);
			Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
			Walk.StartMonitoring();
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00709D70 File Offset: 0x00707F70
		private static void WalkBack(Events Event)
		{
			Tools.Console("Walk back to \"" + Settings.SelectedProfile + "\".", "Blue", "richConsole", "frmMain", true);
			List<Vector3> list = new List<Vector3>();
			if (Event.Route.Count <= 0)
			{
				if (Walk.ProfileSettings.FlightMount && Event.LandingField != Vector3.Zero)
				{
					list = Pathfinder.Navigate(ObjectManager.Me.PositionVector3, Event.LandingField, false, -1);
				}
				else
				{
					Json.LoadProfile(Settings.SelectedProfile, false, false, _globals.IsPremiumProfile);
					Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
					list = Pathfinder.Navigate(ObjectManager.Me.PositionVector3, _globals.Waypoints[Walk.Counter], false, -1);
				}
				object @lock = EventManager._lock;
				lock (@lock)
				{
					_globals.Waypoints.Clear();
					foreach (Vector3 item in list)
					{
						_globals.Waypoints.Add(item);
					}
					Walk.Counter = 0;
					goto IL_123;
				}
			}
			EventManager.ReverseRoute(Event);
			IL_123:
			EventManager.NewEndOfRoute(Event, new string[]
			{
				"Load default Profile"
			});
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00709ED0 File Offset: 0x007080D0
		private static void StartWalking()
		{
			Key.Press("MoveForward");
			Thread.Sleep(250);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00709EF4 File Offset: 0x007080F4
		private static void StopWalking()
		{
			Key.Release("All");
			while (_globals.Start && _globals.NoCheck && ObjectManager.Me.IsMoving)
			{
				Key.Release("All");
				Thread.Sleep(500);
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00709F3C File Offset: 0x0070813C
		private static void Dismount()
		{
			Key.Release("All");
			Walk.Mount(false, false);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x00709F5C File Offset: 0x0070815C
		private static void Jump()
		{
			bool flag = _globals.KeyStatus["MoveForward"];
			Key.Release("All");
			Thread.Sleep(250);
			Key.Press("Jump");
			Thread.Sleep(250);
			Key.Release("Jump");
			Thread.Sleep(750);
			if (flag)
			{
				Key.Press("MoveForward");
			}
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00709FC0 File Offset: 0x007081C0
		private static void JumpWhileWalk()
		{
			bool flag = _globals.KeyStatus["MoveForward"];
			Key.Press("MoveForward");
			Thread.Sleep(50);
			Key.Press("Jump");
			Thread.Sleep(50);
			Key.Release("Jump");
			Thread.Sleep(950);
			if (!flag)
			{
				Key.Release("MoveForward");
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0070A020 File Offset: 0x00708220
		private static void WalkWhileJump()
		{
			bool flag = _globals.KeyStatus["MoveForward"];
			Key.Release("All");
			Thread.Sleep(250);
			Key.Press("Jump");
			Thread.Sleep(50);
			Key.Release("Jump");
			Thread.Sleep(200);
			Key.Press("MoveForward");
			Thread.Sleep(500);
			Key.Release("MoveForward");
			Thread.Sleep(1000);
			if (flag)
			{
				Key.Press("MoveForward");
			}
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0070A0AC File Offset: 0x007082AC
		private static void EnterLeaveDungeon(Events Event)
		{
			if (!_globals.ModuleDungeon)
			{
				Tools.Console("This Event requires the Dungeon Module.", "Orange", "richConsole", "frmMain", true);
				return;
			}
			EventManager.FlyDown();
			_globals.AutoStart = true;
			if (_globals.Start && !_globals.NoCheck && !ObjectManager.Me.IsMoving)
			{
				Key.Press("MoveForward");
			}
			while (_globals.Start && !_globals.NoCheck && !ObjectManager.Me.IsMoving)
			{
				Key.Press("MoveForward");
				Thread.Sleep(500);
			}
			string name = Tools.RandomTimer("DungeonLoadingScreen");
			Timer.Set(name, 20000);
			if (PlayerMe.IsInDungeon)
			{
				while (!_globals.NoCheck && PlayerMe.IsInDungeon && Timer.Check(name) != 0)
				{
					Thread.Sleep(50);
				}
			}
			else
			{
				while (!_globals.NoCheck && !PlayerMe.IsInDungeon && Timer.Check(name) != 0)
				{
					Thread.Sleep(50);
				}
			}
			Key.Release("MoveForward");
			while (!_globals.Ready && !_globals.NoCheck && Timer.Check(name) != 0)
			{
				Thread.Sleep(100);
			}
			Thread.Sleep(2000);
			_globals.AutoStart = false;
			if (PlayerMe.IsInDungeon)
			{
				Tools.Console("Event -> " + Event.Name + " -> Dungeon entered.", "Blue", "richConsole", "frmMain", true);
				SNS.NotifyEvent("Entered Dungeon" + EventManager.ZoneNameAddition(true, false) + ".");
				return;
			}
			Tools.Console("Event -> " + Event.Name + " -> Dungeon leaved.", "Blue", "richConsole", "frmMain", true);
			SNS.NotifyEvent("Leave Dungeon" + EventManager.ZoneNameAddition(true, false) + ".");
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0070A264 File Offset: 0x00708464
		private static void CastSpell(Events Event)
		{
			int count = ObjectManager.GetUnitsAround(ObjectManager.Me.PositionVector3, "CastSpell", Event.CastSpellRadius).Count;
			if (!Event.CastSpellUntilNoAttackers && !Event.CastSpellNoRadiusCheck && count <= 0)
			{
				Tools.Console(string.Concat(new string[]
				{
					"Event -> ",
					Event.Name,
					" -> No Units around ",
					Event.CastSpellRadius.ToString(),
					" yards."
				}), "Orange", "richConsole", "frmMain", true);
			}
			else
			{
				bool flag = true;
				if (!Event.CastSpellWhileWalk && ObjectManager.Me.IsMoving)
				{
					Key.Release("All");
					Thread.Sleep(250);
				}
				if (Event.CastSpellOnTarget)
				{
					flag = false;
					int num = 0;
					int num2 = 0;
					if (int.TryParse(Event.CastSpellTargetNameOrID, out num2))
					{
						if (num2 > 0)
						{
							num = num2;
						}
					}
					else
					{
						Units npcbyName = ObjectManager.GetNPCByName(Event.CastSpellTargetNameOrID);
						if (npcbyName != null)
						{
							object @lock = ObjectManager._lock;
							lock (@lock)
							{
								num = npcbyName.DisplayID;
							}
						}
					}
					if (num > 0)
					{
						Units units;
						if (Event.CastSpellTargetClosest)
						{
							units = ObjectManager.GetClosestNPCByDisplayID(num);
						}
						else
						{
							units = ObjectManager.GetFurthestNPCByDisplayID(num);
						}
						if (units != null)
						{
							object @lock = ObjectManager._lock;
							lock (@lock)
							{
								UInt128 guid = units.GUID128;
								while (_globals.Start && !_globals.NoCheck && units != null && ObjectManager.Me.TargetGUID != guid)
								{
									ObjectManager.Interaction(guid, "TargetMouseover");
									Thread.Sleep(500);
								}
								if (ObjectManager.Me.TargetGUID == guid)
								{
									flag = true;
								}
							}
						}
					}
				}
				if (!flag)
				{
					Tools.Console("Event -> " + Event.Name + " -> Target not found.", "Orange", "richConsole", "frmMain", true);
					return;
				}
				string spellName = Spell.GetSpellName(Event.CastSpellID);
				int num3 = 0;
				int num4 = 0;
				foreach (ActionBar.SpellList spellList in ActionBar.GetSpells)
				{
					if (spellList.Bar == 1 || spellList.Bar == 6)
					{
						if (spellList.ID == Event.CastSpellID)
						{
							num3 = spellList.Bar;
							num4 = spellList.Slot;
							break;
						}
					}
				}
				if (num3 <= 0 || num4 <= 0)
				{
					Tools.Console(string.Concat(new string[]
					{
						"Event -> ",
						Event.Name,
						" -> Spell \"",
						spellName,
						" (",
						Event.CastSpellID.ToString(),
						")\" could not found in ActionBars."
					}), "Orange", "richConsole", "frmMain", true);
					return;
				}
				string text = "ActionBar" + num3.ToString() + "_" + num4.ToString();
				if (Event.CastSpellUntilNoAttackers)
				{
					int num5;
					if (Event.CastSpellNoRadiusCheck)
					{
						num5 = ObjectManager.GetAttackers.Count;
					}
					else
					{
						num5 = ObjectManager.GetAttackersByDistance(Event.CastSpellRadius).Count;
					}
					int num6 = num5;
					Tools.Console(string.Concat(new string[]
					{
						"Event -> ",
						Event.Name,
						" -> Cast Spell \"",
						spellName,
						" (",
						Event.CastSpellID.ToString(),
						")\" -> ",
						num6.ToString(),
						" Mobs left."
					}), "Blue", "richConsole", "frmMain", true);
					while (_globals.Start)
					{
						if (_globals.NoCheck || num6 <= 0)
						{
							break;
						}
						if (num6 < num5)
						{
							Tools.Console("Event -> " + num6.ToString() + " Mobs left.", "Blue", "richConsole", "frmMain", true);
							num5 = num6;
						}
						if (Event.CastSpellGroundAOE)
						{
							EventManager.CastGroundAOE(ObjectManager.GetClosestAttacker, text, true);
						}
						else
						{
							Key.Press(text);
							Thread.Sleep(30);
							Key.Release(text);
						}
						if (Event.CastSpellNoRadiusCheck)
						{
							num6 = ObjectManager.GetAttackers.Count;
						}
						else
						{
							num6 = ObjectManager.GetAttackersByDistance(Event.CastSpellRadius).Count;
						}
						Thread.Sleep(_globals.GlobalCooldown);
					}
				}
				else
				{
					if (Event.CastSpellGroundAOE)
					{
						EventManager.CastGroundAOE(ObjectManager.GetClosestAttacker, text, false);
					}
					else
					{
						Key.Press(text);
						Thread.Sleep(30);
						Key.Release(text);
					}
					Tools.Console(string.Concat(new string[]
					{
						"Event -> ",
						Event.Name,
						" -> Spell \"",
						spellName,
						" (",
						Event.CastSpellID.ToString(),
						")\" executed."
					}), "Blue", "richConsole", "frmMain", true);
				}
				if (!Event.CastSpellWhileWalk)
				{
					Thread.Sleep(_globals.GlobalCooldown);
					return;
				}
			}
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0070A79C File Offset: 0x0070899C
		private static void ChangeWalkSens(Events Event)
		{
			Walk.StayAndTurnIndoor = Event.WalkSensIndoor;
			Walk.StayAndTurnOutdoor = Event.WalkSensOutdoor;
			if (!PlayerMe.IsIndoor)
			{
				Walk.StayAndTurnAt = Walk.StayAndTurnOutdoor;
			}
			else
			{
				Walk.StayAndTurnAt = Walk.StayAndTurnIndoor;
			}
			Tools.Console(string.Concat(new string[]
			{
				"Event -> Changed Walk Sensitivity to \"Indoor: ",
				Walk.StayAndTurnIndoor.ToString(),
				"\" and \"Outdoor: ",
				Walk.StayAndTurnOutdoor.ToString(),
				"\""
			}), "", "richConsole", "frmMain", true);
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0070A830 File Offset: 0x00708A30
		private static void CastGroundAOE(Units Unit, string KeyToPress, bool CheckIfInCombat = false)
		{
			if (Unit != null)
			{
				Vector3 vector = default(Vector3);
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					vector = Unit.PositionVector3;
				}
				Angle.FaceMe(ObjectManager.Me.PositionVector3, vector, ObjectManager.Me.Facing, null, false, 0.1f);
				while (_globals.Start)
				{
					if (!_globals.NoCheck && !ObjectManager.Me.IsChanneling)
					{
						bool isInCombat = ObjectManager.Me.IsInCombat;
						if (!CheckIfInCombat || isInCombat)
						{
							Key.Press(KeyToPress);
							Thread.Sleep(30);
							Key.Release(KeyToPress);
							Thread.Sleep(250);
							Tools.SetCursor(vector, true);
							Thread.Sleep(1000);
							continue;
						}
					}
					IL_E6:
					while (_globals.Start && !_globals.NoCheck && ObjectManager.Me.IsChanneling)
					{
						bool isInCombat2 = ObjectManager.Me.IsInCombat;
						if (CheckIfInCombat && !isInCombat2)
						{
							break;
						}
						Thread.Sleep(250);
					}
					return;
				}
				goto IL_E6;
			}
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0070A93C File Offset: 0x00708B3C
		private static void Stop(bool SendNotification = true)
		{
			_globals.AutoStart = false;
			_globals.Start = false;
			if (SendNotification)
			{
				SNS.NotifyEvent("Jack stopped.");
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0070A964 File Offset: 0x00708B64
		private static void Loot()
		{
			object @lock = Jack.Engine.Loot._lock;
			lock (@lock)
			{
				Jack.Engine.Loot.List.Clear();
				List<Units> loots = ObjectManager.GetLoots(0);
				object lock2 = ObjectManager._lock;
				lock (lock2)
				{
					foreach (Units units in loots)
					{
						if (units != null)
						{
							UInt128 guid = units.GUID128;
							if (!Jack.Engine.Loot.List.ContainsKey(guid))
							{
								Jack.Engine.Loot.List.Add(guid, false);
							}
						}
					}
				}
			}
			if (Jack.Engine.Loot.LootableUnits.Count > 0)
			{
				EventManager.FlyDown();
				Jack.Engine.Loot.Get();
			}
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0070AA4C File Offset: 0x00708C4C
		private static void ResetDungeons()
		{
			if (_globals.ModuleDungeon)
			{
				Addon.LUA("ResetInstances()", "0", false, true);
				return;
			}
			Tools.Console("This Event requires the Dungeon Module.", "Orange", "richConsole", "frmMain", true);
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0070AA8C File Offset: 0x00708C8C
		private static void FacingNextWaypoint()
		{
			EventManager.StopWalking();
			int num = Walk.GetClosestCrd(_globals.Waypoints) + 1;
			if (num > _globals.Waypoints.Count - 1)
			{
				num = 0;
			}
			Angle.FaceMe(ObjectManager.Me.PositionVector3, _globals.Waypoints[num], ObjectManager.Me.Facing, null, false, 0.05f);
			Thread.Sleep(500);
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0070AAF4 File Offset: 0x00708CF4
		private static void UseTransport(Events Event)
		{
			Key.Release("All");
			EventManager.WalkToTransport = false;
			Tools.Console("Waiting for Transport...", "Blue", "richConsole", "frmMain", true);
			SNS.NotifyEvent("Waiting for Transport" + EventManager.ZoneNameAddition(true, false) + "...");
			new Thread(new ThreadStart(EventManager.WatchTransportArrive))
			{
				IsBackground = true
			}.Start();
			while (_globals.Start && !_globals.NoCheck && !EventManager.WalkToTransport)
			{
				Thread.Sleep(500);
			}
			if (EventManager.WalkToTransport && EventManager.Transport != null)
			{
				Tools.Console("Entering Transport...", "Blue", "richConsole", "frmMain", true);
				string a = "";
				double num = 0.0;
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					a = EventManager.Transport.GetTransportType;
					num = JackMath.Distance(EventManager.Transport.PositionVector3, true, true, true);
				}
				double num2 = 0.0;
				while (_globals.Start)
				{
					if (!_globals.NoCheck)
					{
						if (!ObjectManager.Me.IsMoving)
						{
							Key.Press("MoveForward");
						}
						@lock = ObjectManager._lock;
						lock (@lock)
						{
							num2 = JackMath.Distance(EventManager.Transport.PositionVector3, true, true, true);
						}
						if (num2 <= 1000.0 && (!(a == "Tram") || num2 <= num))
						{
							Thread.Sleep(250);
							continue;
						}
						Thread.Sleep(500);
					}
					IL_19D:
					num2 = 0.0;
					Key.Release("All");
					string useTransportTurn = Event.UseTransportTurn;
					if (!useTransportTurn.Contains("left"))
					{
						if (!useTransportTurn.Contains("right"))
						{
							if (Event.UseTransportTurn.Contains("180"))
							{
								Key.Turn180();
							}
						}
						else if (!useTransportTurn.Contains("45"))
						{
							if (!useTransportTurn.Contains("90"))
							{
								if (useTransportTurn.Contains("135"))
								{
									Key.TurnRight135();
								}
							}
							else
							{
								Key.TurnRight90();
							}
						}
						else
						{
							Key.TurnRight45();
						}
					}
					else if (!useTransportTurn.Contains("45"))
					{
						if (!useTransportTurn.Contains("90"))
						{
							if (useTransportTurn.Contains("135"))
							{
								Key.TurnLeft135();
							}
						}
						else
						{
							Key.TurnLeft90();
						}
					}
					else
					{
						Key.TurnLeft45();
					}
					if (ObjectManager.TransportNeedReload(EventManager.Transport))
					{
						Tools.Console("Transport entered. Awaiting Reload...", "Blue", "richConsole", "frmMain", true);
						Tools.ControlVisible("lblCancel", "frmMain", true);
						_globals.AutoStart = true;
						while (_globals.Start)
						{
							if (!_globals.Ready || frmMain.Cancel)
							{
								IL_3AB:
								while (!_globals.Start && !frmMain.Cancel)
								{
									Thread.Sleep(500);
								}
								EventManager.Transport = null;
								while (_globals.Start && !_globals.NoCheck && EventManager.Transport == null && !frmMain.Cancel)
								{
									EventManager.Transport = ObjectManager.GetObjectByDisplayID(EventManager.TransportID);
									Thread.Sleep(250);
								}
								Tools.ControlVisible("lblCancel", "frmMain", false);
								if (frmMain.Cancel)
								{
									_globals.Start = false;
								}
								_globals.AutoStart = false;
								goto IL_412;
							}
							Thread.Sleep(1000);
						}
						goto IL_3AB;
					}
					Tools.Console("Transport entered.", "Blue", "richConsole", "frmMain", true);
					Vector3 vector = default(Vector3);
					@lock = ObjectManager._lock;
					lock (@lock)
					{
						vector = EventManager.Transport.PositionVector3;
					}
					Vector3 right = vector;
					while (_globals.Start && !_globals.NoCheck)
					{
						@lock = ObjectManager._lock;
						lock (@lock)
						{
							right = EventManager.Transport.PositionVector3;
						}
						Thread.Sleep(1000);
						if (vector != default(Vector3) && vector != right)
						{
							break;
						}
					}
					Tools.Console("My journey begins...", "Blue", "richConsole", "frmMain", true);
					IL_412:
					if (!frmMain.Cancel)
					{
						Thread.Sleep(500);
						while (_globals.Start && !_globals.NoCheck)
						{
							num = 0.0;
							double num3 = 0.0;
							@lock = ObjectManager._lock;
							lock (@lock)
							{
								num = JackMath.Distance(EventManager.Transport.PositionVector3, true, true, true);
								Thread.Sleep(1000);
								num3 = JackMath.Distance(EventManager.Transport.PositionVector3, true, true, true);
							}
							if (num > 0.0 && num3 > 0.0 && num3 == num)
							{
								break;
							}
						}
						Tools.Console("Destination arrived. Leaving Transport...", "Blue", "richConsole", "frmMain", true);
						SNS.NotifyEvent("Destination arrived" + EventManager.ZoneNameAddition(true, false) + ".");
						while (_globals.Start && !_globals.NoCheck)
						{
							if (!ObjectManager.Me.IsMoving)
							{
								Key.Press("MoveForward");
							}
							@lock = ObjectManager._lock;
							lock (@lock)
							{
								num2 = JackMath.Distance(EventManager.Transport.PositionVector3, true, true, true);
							}
							if (num2 < 1000.0)
							{
								Thread.Sleep(1000);
								break;
							}
							Thread.Sleep(250);
						}
						Json.LoadProfile(Event.UseTransportProfile, false, false, _globals.IsPremiumProfile);
						Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
					}
					frmMain.Cancel = false;
					return;
				}
				goto IL_19D;
			}
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0070B0EC File Offset: 0x007092EC
		private static void WatchTransportArrive()
		{
			bool flag = true;
			bool flag2 = false;
			while (_globals.Start && !_globals.NoCheck && !EventManager.WalkToTransport)
			{
				EventManager.Transport = ObjectManager.GetClosestTransport;
				if (EventManager.Transport != null)
				{
					double num = 0.0;
					double num2 = 0.0;
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						EventManager.TransportID = EventManager.Transport.DisplayID;
						num = JackMath.Distance(EventManager.Transport.PositionVector3, true, true, true);
						Thread.Sleep(1000);
						num2 = JackMath.Distance(EventManager.Transport.PositionVector3, true, true, true);
					}
					if (num > 0.0 && num2 > 0.0)
					{
						if (num2 == num)
						{
							if (num2 <= 25.0)
							{
								if (flag2)
								{
									goto IL_10C;
								}
								if (flag)
								{
									Tools.Console("I'd better wait. Better safe than sorry.", "Blue", "richConsole", "frmMain", true);
									flag2 = true;
									goto IL_10C;
								}
								EventManager.WalkToTransport = true;
								goto IL_10C;
							}
						}
					}
					if (flag2)
					{
						flag2 = false;
					}
				}
				else
				{
					Thread.Sleep(1000);
				}
				IL_10C:
				flag = false;
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0070B224 File Offset: 0x00709424
		private static void StartSwimming()
		{
			if (!EventManager.SwimmingRuns)
			{
				EventManager.SwimmingRuns = true;
				Tools.Console("Let's get wet!", "Blue", "richConsole", "frmMain", true);
				new Thread(new ThreadStart(EventManager.smethod_1))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0070B278 File Offset: 0x00709478
		private static void StopSwimming()
		{
			EventManager.SwimmingRuns = false;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x0070B28C File Offset: 0x0070948C
		private static void GoThroughPortal()
		{
			EventManager.WaitForReload(true, true);
			SNS.NotifyEvent("Passed through Portal" + EventManager.ZoneNameAddition(true, false) + ".");
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0070B2BC File Offset: 0x007094BC
		private static void StartCombat(Events Event)
		{
			int count = ObjectManager.GetAttackers.Count;
			if (count <= 0)
			{
				Tools.Console("Event -> " + Event.Name + " -> No Attackers found.", "Blue", "richConsole", "frmMain", true);
				return;
			}
			Tools.Console(string.Concat(new string[]
			{
				"Event -> ",
				Event.Name,
				" -> ",
				count.ToString(),
				" Attackers counted."
			}), "Blue", "richConsole", "frmMain", true);
			while (_globals.Start && !_globals.NoCheck && count > 0)
			{
				Combat.SearchForUnitsToAttack(ObjectManager.Me.PositionVector3);
				Combat.OffensiveAttack();
				count = ObjectManager.GetAttackers.Count;
				if (count > 0)
				{
					Tools.Console(string.Concat(new string[]
					{
						"Event -> ",
						Event.Name,
						" -> ",
						count.ToString(),
						" Attackers left."
					}), "Blue", "richConsole", "frmMain", true);
				}
			}
			Tools.Console("Event -> " + Event.Name + " -> Done.", "Blue", "richConsole", "frmMain", true);
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x0070B3FC File Offset: 0x007095FC
		private static void ExecuteLUA(Events Event)
		{
			bool executeLUAWhileWalk = Event.ExecuteLUAWhileWalk;
			if (!executeLUAWhileWalk)
			{
				EventManager.StopWalking();
			}
			Addon.LUA(Event.ExecuteLUA, "0", false, true);
			if (!executeLUAWhileWalk)
			{
				Thread.Sleep(2000);
				if (ObjectManager.Me.IsCasting)
				{
					string name = Tools.RandomTimer("ExecuteLUA");
					Timer.Set(name, 20000);
					while (_globals.Start && !_globals.NoCheck && Timer.Check(name) != 0 && ObjectManager.Me.IsCasting)
					{
						Thread.Sleep(500);
					}
				}
			}
			Tools.Console("LUA Command executed.", "Blue", "richConsole", "frmMain", true);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0070B4A0 File Offset: 0x007096A0
		private static void JoinBattlegroundsClassic(Events Event)
		{
			if (_globals.IsRetail)
			{
				Tools.Console("This Event can't be executed in Retail.", "Red", "richConsole", "frmMain", true);
				return;
			}
			if (EventManager.IsInBattlegroundQueue)
			{
				Tools.Console("Already in queue...", "Orange", "richConsole", "frmMain", true);
				return;
			}
			Key.Release("All");
			bool value = Event.BattlegroundsClassicWarsongGulch;
			bool value2 = Event.BattlegroundsClassicArathiBasin;
			bool value3 = Event.BattlegroundsClassicAlteracValley;
			bool value4 = Event.BattlegroundsClassicEyeOfTheStorm;
			bool value5 = Event.BattlegroundsClassicStrandOfTheAncients;
			if (_globals.IsPremiumProfile && _globals.PremiumLoadedProfileSettings != null)
			{
				value = _globals.PremiumLoadedProfileSettings.BattlegroundWarsongGulch;
				value2 = _globals.PremiumLoadedProfileSettings.BattlegroundArathiBasin;
				value3 = _globals.PremiumLoadedProfileSettings.BattlegroundAlteracValley;
				value4 = _globals.PremiumLoadedProfileSettings.BattlegroundEyeOfTheStorm;
				value5 = _globals.PremiumLoadedProfileSettings.BattlegroundStrandOfTheAncients;
			}
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
			dictionary.Add("Warsong Gulch", value);
			dictionary.Add("Arathi Basin", value2);
			dictionary.Add("Alterac Valley", value3);
			dictionary.Add("Eye of the Storm", value4);
			dictionary.Add("Strand of the Ancients", value5);
			int num = 0;
			foreach (KeyValuePair<string, bool> keyValuePair in dictionary)
			{
				num++;
				string key = keyValuePair.Key;
				if (keyValuePair.Value)
				{
					Tools.Console("Queue Battleground -> " + key, "Blue", "richConsole", "frmMain", true);
					Addon.LUA("/click BattlegroundType" + num.ToString() + "\n/click BattlefieldFrameJoinButton", "0", false, false);
					Thread.Sleep(1000);
				}
			}
			EventManager.IsInBattlegroundQueue = true;
			new Thread(delegate()
			{
				EventManager.WaitingForBattlegroundsClassic(Event);
			})
			{
				IsBackground = true
			}.Start();
			if (Event.BattlegroundsWaitUntilInvitation)
			{
				EventManager.Stop(false);
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0070B6B0 File Offset: 0x007098B0
		private static void WaitingForBattlegroundsClassic(Events Event)
		{
			string selectedProfile = Settings.SelectedProfile;
			frmMain.Cancel = false;
			Tools.Control("Cancel Battleground Event", "lblCancel", "frmMain", true, false, false, false, 0);
			Tools.ControlVisible("lblCancel", "frmMain", true);
			Tools.Console("Waiting for Invitation...", "Blue", "richConsole", "frmMain", true);
			bool flag = false;
			while (!frmMain.Cancel && !flag)
			{
				int num = 0;
				while (num < 25 && !frmMain.Cancel)
				{
					Thread.Sleep(100);
					num++;
				}
				if (flag = Frames.Check("jkPVP", "CanJoin", true))
				{
					if (ObjectManager.Me.IsInCombat)
					{
						Tools.Console("Waiting for joining Battleground until combat has finished...", "Blue", "richConsole", "frmMain", true);
						while (ObjectManager.Me.IsInCombat)
						{
							Thread.Sleep(1000);
						}
						Thread.Sleep(2000);
					}
					Key.Press("JackMacro");
					Thread.Sleep(35);
					Key.Release("JackMacro");
					break;
				}
			}
			if (!frmMain.Cancel && flag)
			{
				flag = false;
				Tools.Console("Preparing for Battleground...", "Blue", "richConsole", "frmMain", true);
				while (!frmMain.Cancel)
				{
					if (flag)
					{
						break;
					}
					int num2 = 0;
					while (num2 < 25 && !frmMain.Cancel)
					{
						Thread.Sleep(100);
						num2++;
					}
					if (flag = Frames.Check("jkPVP", "BattlegroundJoined", true))
					{
						Key.Press("JackMacro");
						Thread.Sleep(35);
						Key.Release("JackMacro");
						Thread.Sleep(2000);
						while (!frmMain.Cancel && !_globals.Ready)
						{
							Thread.Sleep(500);
						}
						break;
					}
				}
			}
			if (!frmMain.Cancel && flag)
			{
				EventManager.LoadProfileAfterBattleground = true;
				EventManager.ProfileAfterBattleground = selectedProfile;
				Tools.Console("Joined Battleground -> " + PlayerMe.BattlegroundName, "Blue", "richConsole", "frmMain", true);
				string battlegroundName = PlayerMe.BattlegroundName;
				if (battlegroundName.Contains("Warsong"))
				{
					Json.LoadProfile(Event.BattlegroundsClassicWarsongGulchProfile, false, false, _globals.IsPremiumProfile);
				}
				else if (battlegroundName.Contains("Arathi"))
				{
					Json.LoadProfile(Event.BattlegroundsClassicArathiBasinProfile, false, false, _globals.IsPremiumProfile);
				}
				else if (battlegroundName.Contains("Alterac"))
				{
					Json.LoadProfile(Event.BattlegroundsClassicAlteracValleyProfile, false, false, _globals.IsPremiumProfile);
				}
				else if (!battlegroundName.Contains("Storm"))
				{
					if (battlegroundName.Contains("Ancients"))
					{
						Json.LoadProfile(Event.BattlegroundsClassicStrandOfTheAncientsProfile, false, false, _globals.IsPremiumProfile);
					}
				}
				else
				{
					Json.LoadProfile(Event.BattlegroundsClassicEyeOfTheStormProfile, false, false, _globals.IsPremiumProfile);
				}
				frmMain.Start();
				if (_globals.Start)
				{
					new Thread(delegate()
					{
						EventManager.WaitingForBattlegroundEnd(Event);
					})
					{
						IsBackground = true
					}.Start();
					EventManager.ForcingStartWhileInBattleground = true;
					new Thread(new ThreadStart(EventManager.ForcingStartInBattleground))
					{
						IsBackground = true
					}.Start();
				}
				SNS.NotifyEvent("Battleground joined -> " + battlegroundName);
			}
			if (frmMain.Cancel)
			{
				Tools.Console("Waiting for Battlegrounds cancelled.", "Red", "richConsole", "frmMain", true);
			}
			Tools.ControlVisible("lblCancel", "frmMain", false);
			Tools.Control("Click here to cancel.", "lblCancel", "frmMain", true, false, false, false, 0);
			frmMain.Cancel = false;
			EventManager.IsInBattlegroundQueue = false;
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0070BA28 File Offset: 0x00709C28
		private static void WaitingForBattlegroundEnd(Events Event)
		{
			bool flag = false;
			while (!flag)
			{
				if (!EventManager.LoadProfileAfterBattleground || EventManager.ProfileAfterBattleground.Length == 0)
				{
					return;
				}
				if (flag = Frames.Check("jkPVP", "BattlegroundEnd", true))
				{
					Tools.Console("Leaving Battleground...", "Blue", "richConsole", "frmMain", true);
					Addon.LUA("LeaveBattlefield()", "0", false, false);
					EventManager.ForcingStartWhileInBattleground = false;
					EventManager.WaitForReload(false, false);
					Thread.Sleep(2000);
					Tools.Console("Battleground leaved.", "Blue", "richConsole", "frmMain", true);
					Json.LoadProfile(EventManager.ProfileAfterBattleground, false, false, _globals.IsPremiumProfile);
					EventManager.LoadProfileAfterBattleground = false;
					EventManager.ProfileAfterBattleground = "";
					frmMain.Start();
					return;
				}
				Thread.Sleep(5000);
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0070BAFC File Offset: 0x00709CFC
		public static void ForcingStartInBattleground()
		{
			while (EventManager.ForcingStartWhileInBattleground)
			{
				int num = 0;
				while (num < 10 && EventManager.ForcingStartWhileInBattleground)
				{
					Thread.Sleep(100);
					num++;
				}
				if (!_globals.Start && EventManager.ForcingStartWhileInBattleground)
				{
					int num2 = 0;
					while (num2 < 50 && EventManager.ForcingStartWhileInBattleground)
					{
						Thread.Sleep(100);
						num2++;
					}
					if (!_globals.Start && EventManager.ForcingStartWhileInBattleground)
					{
						Tools.Console("Forcing Start...", "Orange", "richConsole", "frmMain", true);
						frmMain.Start();
					}
				}
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0070BB84 File Offset: 0x00709D84
		private static void TakeQuest(Events Event)
		{
			if (_globals.QuestIDsCompleted.Count == 0 || _globals.QuestIDsCompletedPlayerName != _globals.PlayerName)
			{
				Key.Release("All");
				_globals.QuestIDsCompleted.Clear();
				_globals.QuestIDsCompletedPlayerName = _globals.PlayerName;
				List<string> list = Addon.LUASync("jkCompletedQuestIds", "Quest IDs", "", null);
				if (list.Count > 0)
				{
					foreach (string text in list)
					{
						if (Tools.IsNumber(text, 1, 0, 1, 0))
						{
							int item = Convert.ToInt32(text);
							if (!_globals.QuestIDsCompleted.Contains(item))
							{
								_globals.QuestIDsCompleted.Add(item);
							}
						}
					}
				}
			}
			int questID = Event.QuestID;
			if (_globals.QuestIDsCompleted.Contains(Event.QuestID))
			{
				Tools.Console("I've already completed this quest (" + questID.ToString() + ").", "Orange", "richConsole", "frmMain", true);
				return;
			}
			Key.Release("All");
			Addon.LUA("_setQuestName(\"" + Event.QuestName + "\")", "0", false, false);
			if (Event.QuestFromObject)
			{
				Tools.Console(Event.QuestNPCID.ToString(), "", "richConsole", "frmMain", true);
				if (ObjectManager.GetObjectByDisplayID(Event.QuestNPCID) == null)
				{
					Tools.Console("Couldn't find object to take quest from.", "Red", "richConsole", "frmMain", true);
					return;
				}
				EventManager.InteractWithObject(Event.QuestNPCID, false);
			}
			else
			{
				EventManager.TalkToNPC(Event.QuestNPCID, false);
			}
			Thread.Sleep(3500);
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0070BD4C File Offset: 0x00709F4C
		private static void TurnInQuest(Events Event)
		{
			int questID = Event.QuestID;
			if (!_globals.QuestIDsCompleted.Contains(Event.QuestID))
			{
				Key.Release("All");
				Addon.LUA("_setQuestName(\"" + Event.QuestName + "\")", "0", false, false);
				if (!Event.QuestFromObject)
				{
					EventManager.TalkToNPC(Event.QuestNPCID, false);
				}
				else
				{
					if (ObjectManager.GetObjectByDisplayID(Event.QuestNPCID) == null)
					{
						Tools.Console("Couldn't find object for turn-in.", "Red", "richConsole", "frmMain", true);
						return;
					}
					EventManager.InteractWithObject(Event.QuestNPCID, false);
				}
				Thread.Sleep(3500);
				_globals.QuestIDsCompleted.Add(questID);
				return;
			}
			Tools.Console("I've already completed this quest (" + questID.ToString() + ").", "Blue", "richConsole", "frmMain", true);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0070BE38 File Offset: 0x0070A038
		private static void LoadRotation(Events Event)
		{
			string path = _globals.JackRotations + "\\" + Event.LoadRotation + ".json";
			if (Settings.SelectedRotation == Event.LoadRotation)
			{
				Tools.Console("Rotation \"" + Event.LoadRotation + "\" is already active.", "Blue", "richConsole", "frmMain", true);
				return;
			}
			if (!File.Exists(path))
			{
				Tools.Console("Rotation \"" + Event.LoadRotation + "\" not found.", "Red", "richConsole", "frmMain", true);
				return;
			}
			string text = File.ReadAllText(path);
			if (text.Length == 0 || !text.Contains("|#|"))
			{
				Tools.Console("Rotation \"" + Event.LoadRotation + "\" could not be read.", "Red", "richConsole", "frmMain", true);
				return;
			}
			string[] array = Regex.Split(text, "\\|\\#\\|");
			string text2 = array[0];
			string text3 = array[1];
			if (text2.Length != 0 && text3.Length != 0)
			{
				Json.LoadRotation(Event.LoadRotation);
				frmRotation.PlaceSpellsOnActionbars(_globals.Rotation);
				ActionBar.SetSpellKeys();
				SpellRotation.CreateLists();
				Walk.StartMonitoring();
				Tools.Console("Rotation \"" + Event.LoadRotation + "\" imported.", "Green", "richConsole", "frmMain", true);
				return;
			}
			Tools.Console("Rotation \"" + Event.LoadRotation + "\" could not be read.", "Red", "richConsole", "frmMain", true);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0070BFBC File Offset: 0x0070A1BC
		public static void ChangeProfileSettings(Events Event)
		{
			if (!Walk.CheckProfileSettings)
			{
				Tools.Console("Couldn't change Profile Settings.", "Red", "richConsole", "frmMain", true);
				return;
			}
			ProfileSettings profileSettings = _globals.ProfileSettings[0];
			profileSettings.CombatMode = Event.ChangeSettingsCombatMode;
			profileSettings.WaypointMode = Event.ChangeSettingsWaypointMode;
			profileSettings.FollowFleeingTarget = Event.ChangeSettingsFollowFleeingTarget;
			profileSettings.ModeMesh = Event.ChangeSettingsModeMesh;
			if (profileSettings.GroundMount && !Event.ChangeSettingsGroundMount)
			{
				Walk.Mount(false, false);
			}
			else if (profileSettings.FlightMount && !Event.ChangeSettingsFlightMount)
			{
				Walk.Mount(false, false);
			}
			profileSettings.GroundMount = Event.ChangeSettingsGroundMount;
			profileSettings.FlightMount = Event.ChangeSettingsFlightMount;
			profileSettings.Loot = Event.ChangeSettingsLoot;
			profileSettings.Skinning = Event.ChangeSettingsSkinning;
			profileSettings.Herbalism = Event.ChangeSettingsHerbalism;
			profileSettings.Mining = Event.ChangeSettingsMining;
			profileSettings.GatherMobs = Event.ChangeSettingsGatherMobs;
			profileSettings.QuestItems.Clear();
			foreach (string item in Event.ChangeSettingsQuestItems)
			{
				profileSettings.QuestItems.Add(item);
			}
			profileSettings.DistanceLoot = Event.ChangeSettingsDistanceLoot;
			profileSettings.DistancePath = Event.ChangeSettingsDistancePath;
			profileSettings.DistanceLootGather = Event.ChangeSettingsDistanceLootGather;
			profileSettings.DistanceAvoidElites = Event.ChangeSettingsDistanceAvoidElites;
			profileSettings.DistanceWaypoint = Event.ChangeSettingsDistanceWaypoint;
			profileSettings.DistanceLocation = Event.ChangeSettingsDistanceLocation;
			profileSettings.DistanceMobGroup = Event.ChangeSettingsDistanceMobGroup;
			profileSettings.DistanceIsReachable = Event.ChangeSettingsDistanceIsReachable;
			if (profileSettings.AttackableMobs != null)
			{
				profileSettings.AttackableMobs.Clear();
			}
			else
			{
				profileSettings.AttackableMobs = new List<string>();
			}
			foreach (string item2 in Event.ChangeSettingsAttackableMobs)
			{
				profileSettings.AttackableMobs.Add(item2);
			}
			Walk.StartMonitoring();
			Tools.Console("Profile Settings changed successful.", "Green", "richConsole", "frmMain", true);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0070C1EC File Offset: 0x0070A3EC
		public static void WatchAttackers(Vector3 GoBackTo)
		{
			if (ObjectManager.GetAttackers.Count > 0)
			{
				EventManager.GettingAttacked = true;
				Combat.DefensiveAttack();
				return;
			}
			if (EventManager.GettingAttacked)
			{
				EventManager.GettingAttacked = false;
				EventManager.Loot();
				Walk.GoTo(GoBackTo, 1.0, 0.5f, null);
				Key.Release("All");
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0070C24C File Offset: 0x0070A44C
		public static void WaitForReload(bool MoveForward = false, bool AutoStart = true)
		{
			if (AutoStart)
			{
				_globals.AutoStart = true;
			}
			string name = Tools.RandomTimer("WaitForReload1");
			Timer.Set(name, 20000);
			while (_globals.Start && _globals.Ready && Timer.Check(name) != 0)
			{
				if (MoveForward && !ObjectManager.Me.IsMoving)
				{
					Key.Press("MoveForward");
				}
				Thread.Sleep(500);
			}
			name = Tools.RandomTimer("WaitForReload2");
			Timer.Set(name, 10000);
			while (!_globals.Start && Timer.Check(name) != 0)
			{
				Key.Release("MoveForward");
				Thread.Sleep(500);
			}
			_globals.AutoStart = false;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0070C2F4 File Offset: 0x0070A4F4
		public static bool CheckConditions(Events Event)
		{
			if (EventManager.IsOnExecutionList(Event))
			{
				return false;
			}
			if (Event.RouteType == "Ghost")
			{
				return false;
			}
			if (Event.Faction != "Both" && Event.Faction != ObjectManager.Me.Faction.ToString())
			{
				return false;
			}
			if (Event.Race != "All" && Event.Race != ObjectManager.Me.Race.ToString())
			{
				return false;
			}
			if (!Event.HasCondition1)
			{
				return true;
			}
			if (Event.HasCondition2)
			{
				if (!(Event.ConditionAndOr1 == "AND"))
				{
					if (Event.ConditionAndOr1 == "OR" && (EventManager.CheckCondition(Event, 1) || EventManager.CheckCondition(Event, 2)))
					{
						return true;
					}
				}
				else if (EventManager.CheckCondition(Event, 1) && EventManager.CheckCondition(Event, 2))
				{
					return true;
				}
				return false;
			}
			return EventManager.CheckCondition(Event, 1);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0070C3F4 File Offset: 0x0070A5F4
		private static bool CheckCondition(Events Event, int ConditionNumber)
		{
			string a = "";
			string @operator = "";
			string text = "";
			string text2 = "";
			if (ConditionNumber == 1)
			{
				a = Event.Condition1;
				@operator = Event.Condition1Compare;
				text = Event.Condition1Value;
				text2 = Event.Condition1Value2;
			}
			else if (ConditionNumber == 2)
			{
				a = Event.Condition2;
				@operator = Event.Condition2Compare;
				text = Event.Condition2Value;
				text2 = Event.Condition2Value2;
			}
			if (a == "Level")
			{
				return EventManager.ConditionCompare(ObjectManager.Me.Level, @operator, text);
			}
			if (a == "Class")
			{
				return EventManager.ConditionCompare(ObjectManager.Me.Class.ToString(), @operator, text);
			}
			if (a == "Bags are full")
			{
				return Convert.ToBoolean(ObjectManager.GetFreeBagSlots <= 2);
			}
			if (a == "Bags are not full")
			{
				return Convert.ToBoolean(ObjectManager.GetFreeBagSlots > 0);
			}
			if (a == "Low Armor Durability")
			{
				return Convert.ToBoolean(Event.VendorCanRepair && PlayerMe.NeedRepair);
			}
			if (a == "Free bag slots")
			{
				if (Tools.IsNumber(text, 0, 0, 0, 0))
				{
					return EventManager.ConditionCompare(ObjectManager.GetFreeBagSlots, @operator, text);
				}
			}
			else if (a == "Bag contains Item (by ID)")
			{
				if (!Tools.IsNumber(text, 1, 0, 1, 0))
				{
					return false;
				}
				int num = Convert.ToInt32(text);
				if (ObjectManager.GetItemByDisplayID(num) == null)
				{
					return false;
				}
				if (text2.Length > 0 && Tools.IsNumber(text2, 1, 0, 1, 0))
				{
					int num2 = Convert.ToInt32(text2);
					return ObjectManager.GetItemAmount(num) >= num2;
				}
				return true;
			}
			else
			{
				if (a == "Is in Range of... (in Yards)")
				{
					Units units = null;
					Objects objects = null;
					if (Event.InteractNameOrID.Length <= 0)
					{
						if (Event.TargetDisplayID > 0)
						{
							units = ObjectManager.GetNPCByDisplayID(Event.TargetDisplayID);
							objects = ObjectManager.GetObjectByDisplayID(Event.TargetDisplayID);
						}
					}
					else
					{
						string interactNameOrID = Event.InteractNameOrID;
						int displayID = 0;
						if (int.TryParse(interactNameOrID, out displayID))
						{
							units = ObjectManager.GetNPCByDisplayID(displayID);
							objects = ObjectManager.GetObjectByDisplayID(displayID);
						}
						else
						{
							units = ObjectManager.GetNPCByName(interactNameOrID);
							objects = ObjectManager.GetObjectByName(interactNameOrID);
						}
					}
					object @lock;
					if (units != null)
					{
						@lock = ObjectManager._lock;
						lock (@lock)
						{
							return EventManager.ConditionCompare((int)JackMath.Distance(units.PositionVector3, true, true, true), @operator, text);
						}
					}
					if (objects == null)
					{
						return false;
					}
					@lock = ObjectManager._lock;
					bool result;
					lock (@lock)
					{
						result = EventManager.ConditionCompare((int)JackMath.Distance(objects.PositionVector3, true, true, true), @operator, text);
					}
					return result;
				}
				if (a == "Skill Name")
				{
					return ObjectManager.Me.HasProfession(text);
				}
				if (!(a == "Skill Level"))
				{
					if (a == "When Quest(s) completed" && Monitor.QuestsEventCompleted)
					{
						Monitor.QuestsCompleted = false;
						Monitor.QuestsEventCompleted = false;
						return true;
					}
				}
				else
				{
					if (Event.Condition1 == "Skill Name" && ObjectManager.Me.HasProfession(Event.Condition1Value))
					{
						return EventManager.ConditionCompare((int)ObjectManager.Me.ProfessionRank(Event.Condition1Value), @operator, text);
					}
					if (Event.Condition2 == "Skill Name" && ObjectManager.Me.HasProfession(Event.Condition2Value))
					{
						return EventManager.ConditionCompare((int)ObjectManager.Me.ProfessionRank(Event.Condition2Value), @operator, text);
					}
				}
			}
			return false;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0070C780 File Offset: 0x0070A980
		private static int GetConditionValue(string Value = "")
		{
			int result = 0;
			int.TryParse(Value, out result);
			return result;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0070C79C File Offset: 0x0070A99C
		private static bool ConditionCompare(int Condition, string Operator, string Value)
		{
			int conditionValue = EventManager.GetConditionValue(Value);
			if (!(Operator == "Smaller or Equal"))
			{
				if (!(Operator == "Equal"))
				{
					if (Operator == "Greater or Equal")
					{
						if (Condition >= conditionValue)
						{
							return true;
						}
					}
					else if (Operator == "Item ID" && Condition == conditionValue)
					{
						return true;
					}
				}
				else if (Condition == conditionValue)
				{
					return true;
				}
			}
			else if (Condition <= conditionValue)
			{
				return true;
			}
			return false;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0070C800 File Offset: 0x0070AA00
		private static bool ConditionCompare(string Condition, string Operator, string Value)
		{
			return Condition == Value;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0070C81C File Offset: 0x0070AA1C
		private static bool CheckDefaultVendorConditions(Events Event)
		{
			return ObjectManager.GetFreeBagSlots <= 2 || (Event.VendorCanRepair && PlayerMe.NeedRepair) || EventManager.CheckBuylist(Event);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0070C84C File Offset: 0x0070AA4C
		public static bool CheckBuylist(Events Event)
		{
			if (Event.VendorBuylist.Count > 0)
			{
				using (List<string>.Enumerator enumerator = Event.VendorBuylist.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						if (text.Contains(";"))
						{
							string[] array = text.Split(new char[]
							{
								';'
							});
							if (array.Count<string>() > 1)
							{
								string itemNameOrID = array[0];
								string s = array[2];
								int num = -1;
								if (int.TryParse(s, out num) && num > -1 && ObjectManager.GetItemAmount(itemNameOrID) <= num)
								{
									return true;
								}
							}
						}
					}
					return false;
				}
				bool result;
				return result;
			}
			return false;
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0070C900 File Offset: 0x0070AB00
		public static bool HasItemsToSend(Events Event, int Amount = 0)
		{
			if (_globals.IsPremiumProfile && _globals.PremiumLoadedProfileSettings.MailboxReceiver.Length == 0)
			{
				Tools.Console("No recipient was entered.", "Red", "richConsole", "frmMain", true);
				return false;
			}
			if (Event.RecorderMailboxSendGreys || Event.RecorderMailboxSendWhites || Event.RecorderMailboxSendGreens || Event.RecorderMailboxSendBlues || Event.RecorderMailboxSendPurples)
			{
				return true;
			}
			int num = 0;
			if (Event.RecorderMailboxSendlist.Count > 0)
			{
				using (List<Items>.Enumerator enumerator = ObjectManager.GetItemsInBags.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Items items = enumerator.Current;
						if (Event.RecorderMailboxSendlist.Contains(items.ItemID.ToString()) || Event.RecorderMailboxSendlist.Contains(items.ItemName))
						{
							if (Amount <= 0)
							{
								return true;
							}
							num++;
						}
					}
					goto IL_E0;
				}
				bool result;
				return result;
			}
			IL_E0:
			if (Amount > 0 && num >= Amount)
			{
				return true;
			}
			Tools.Console("No items found to send.", "Orange", "richConsole", "frmMain", true);
			return false;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0070CA24 File Offset: 0x0070AC24
		public static void SetGlobalEventsForMonitor()
		{
			object lockEvents = _globals._lockEvents;
			lock (lockEvents)
			{
				object lockGlobalEvents = Monitor._lockGlobalEvents;
				lock (lockGlobalEvents)
				{
					Monitor.WatchGlobalEvents.Clear();
					if (_globals.Events.Count != 0)
					{
						foreach (Events events in _globals.Events)
						{
							if (!EventManager.IsOnExecutionList(events) && EventManager.IsAction(events.Action, "Add Route...") && !(events.RouteType == "Ghost") && events.Route.Count <= 0 && !(events.TargetLocation == Vector3.Zero))
							{
								Monitor.WatchGlobalEvents.Add(events);
							}
						}
					}
				}
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0070CB38 File Offset: 0x0070AD38
		public static void ResetGlobalEvents()
		{
			Monitor.NeedGlobalEvent = false;
			Monitor.NeedGlobalEventEvent = null;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0070CB54 File Offset: 0x0070AD54
		public static bool IsAction(string ActionName1, string ActionName2)
		{
			return ActionName1 == ActionName2 || (ActionName1 != ActionName2 && EventManager.ActionIDs.ContainsKey(ActionName1) && EventManager.ActionIDs.ContainsKey(ActionName2) && EventManager.ActionIDs[ActionName1] == EventManager.ActionIDs[ActionName2]);
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0070CBAC File Offset: 0x0070ADAC
		public static bool IsAction(string ActionName1, List<string> ActionNames)
		{
			using (List<string>.Enumerator enumerator = ActionNames.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string text = enumerator.Current;
					if (ActionName1 == text)
					{
						return true;
					}
					if (ActionName1 != text && EventManager.ActionIDs.ContainsKey(ActionName1) && EventManager.ActionIDs.ContainsKey(text) && EventManager.ActionIDs[ActionName1] == EventManager.ActionIDs[text])
					{
						return true;
					}
				}
				return false;
			}
			bool result;
			return result;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0070CC44 File Offset: 0x0070AE44
		public static string ZoneNameAddition(bool SpaceBefore = false, bool SpaceAfter = false)
		{
			string text = "";
			string zoneName = PlayerMe.ZoneName;
			if (zoneName != "N/A")
			{
				if (SpaceBefore)
				{
					text += " ";
				}
				text = text + "(" + zoneName + ")";
				if (SpaceAfter)
				{
					text += " ";
				}
			}
			return text;
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0070CC9C File Offset: 0x0070AE9C
		// Note: this type is marked as 'beforefieldinit'.
		static EventManager()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			dictionary["Add Route..."] = 1;
			dictionary["Add Vendor, Mailbox and More..."] = 1;
			dictionary["Interact with..."] = 2;
			dictionary["Load Profile..."] = 3;
			dictionary["Load Rotation..."] = 4;
			dictionary["Wait..."] = 5;
			dictionary["Cast Spell..."] = 6;
			dictionary["Change Walk Sensitivity..."] = 7;
			dictionary["Use Hearthstone..."] = 8;
			dictionary["Start Fishing..."] = 9;
			dictionary["Use Transport..."] = 10;
			dictionary["Execute LUA..."] = 11;
			dictionary["Join Battlegrounds (Classic)..."] = 12;
			dictionary["Change Profile Settings..."] = 13;
			dictionary["Go through Portal"] = 14;
			dictionary["Start Combat"] = 15;
			dictionary["Enter/Leave Dungeon"] = 16;
			dictionary["Enter/Leave Dungeon (Requires Dungeon Module)"] = 16;
			dictionary["Reset Dungeons"] = 17;
			dictionary["Reset Dungeons (Requires Dungeon Module)"] = 17;
			dictionary["Stop walking"] = 18;
			dictionary["Start walking"] = 19;
			dictionary["Jump"] = 20;
			dictionary["Jump while walk"] = 21;
			dictionary["Walk while Jump"] = 22;
			dictionary["Start Swimming"] = 23;
			dictionary["Stop Swimming"] = 24;
			dictionary["Loot"] = 25;
			dictionary["Facing next Waypoint"] = 26;
			dictionary["Stop"] = 27;
			EventManager.ActionIDs = dictionary;
		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0070CEC8 File Offset: 0x0070B0C8
		[CompilerGenerated]
		internal static void smethod_0(bool Reverse = false, ref EventManager.<>c__DisplayClass17_0 <>c__DisplayClass17_0_0)
		{
			List<Vector3> list = new List<Vector3>();
			if (<>c__DisplayClass17_0_0.Event.Route.Count <= 0)
			{
				if (Walk.ProfileSettings.FlightMount)
				{
					int closestCrd = Walk.GetClosestCrd(_globals.Waypoints);
					Vector3 right = _globals.Waypoints[closestCrd];
					int num = 0;
					Vector3 vector = Vector3.Zero;
					if (<>c__DisplayClass17_0_0.Event.LandingField != Vector3.Zero && <>c__DisplayClass17_0_0.Event.TargetLocation != Vector3.Zero)
					{
						vector = <>c__DisplayClass17_0_0.Event.LandingField;
						num = Walk.GetClosestCrd(_globals.Waypoints, <>c__DisplayClass17_0_0.Event.LandingField, 0);
					}
					else if (<>c__DisplayClass17_0_0.Event.TargetLocation != Vector3.Zero)
					{
						vector = <>c__DisplayClass17_0_0.Event.TargetLocation;
						num = Walk.GetClosestCrd(_globals.Waypoints, <>c__DisplayClass17_0_0.Event.TargetLocation, 0);
					}
					if (num <= _globals.Waypoints.Count - 1)
					{
						Vector3 right2 = _globals.Waypoints[num];
						bool flag = false;
						foreach (Vector3 vector2 in _globals.Waypoints)
						{
							if (!flag)
							{
								flag = (vector2 == right);
							}
							if (flag)
							{
								list.Add(vector2);
								if (vector2 == right2)
								{
									break;
								}
							}
						}
					}
					if (list.Count > 0 && vector != Vector3.Zero)
					{
						List<Vector3> list2 = Pathfinder.Navigate(list.LastOrDefault<Vector3>(), vector, false, -1);
						if (list2.Count != 0)
						{
							using (List<Vector3>.Enumerator enumerator = list2.GetEnumerator())
							{
								while (enumerator.MoveNext())
								{
									Vector3 item = enumerator.Current;
									list.Add(item);
								}
								goto IL_20A;
							}
						}
						list.Add(vector);
					}
				}
				else if (<>c__DisplayClass17_0_0.Event.TargetLocation != Vector3.Zero)
				{
					list = Pathfinder.Navigate(ObjectManager.Me.PositionVector3, <>c__DisplayClass17_0_0.Event.TargetLocation, false, -1);
				}
			}
			else
			{
				list = <>c__DisplayClass17_0_0.Event.Route;
			}
			IL_20A:
			if (list.Count == 0)
			{
				SNS.NotifyEvent("Vendor.");
				Tools.Console("\"" + <>c__DisplayClass17_0_0.RouteType + "\" Route couldn't be loaded.", "Red", "richConsole", "frmMain", true);
				return;
			}
			object @lock = EventManager._lock;
			lock (@lock)
			{
				_globals.Waypoints.Clear();
				foreach (Vector3 item2 in list)
				{
					_globals.Waypoints.Add(item2);
				}
				if (Reverse)
				{
					EventManager.ReverseRoute(<>c__DisplayClass17_0_0.Event);
				}
				Walk.Counter = Walk.GetClosestCrd(_globals.Waypoints);
				if (<>c__DisplayClass17_0_0.WhatToDoAtEndOfRoute.Count<string>() > 0)
				{
					EventManager.NewEndOfRoute(<>c__DisplayClass17_0_0.Event, <>c__DisplayClass17_0_0.WhatToDoAtEndOfRoute);
				}
				SNS.NotifyEvent("On my way to: \"" + <>c__DisplayClass17_0_0.RouteType + "\".");
				Tools.Console("Loaded \"" + <>c__DisplayClass17_0_0.RouteType + "\" Route.", "Blue", "richConsole", "frmMain", true);
			}
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0070D234 File Offset: 0x0070B434
		[CompilerGenerated]
		internal static void smethod_1()
		{
			while (_globals.Start && !_globals.NoCheck && EventManager.SwimmingRuns)
			{
				if (ObjectManager.Me.IsSwimming)
				{
					Key.Press("Jump");
					while (ObjectManager.Me.IsSwimming)
					{
						Thread.Sleep(250);
					}
					Key.Release("Jump");
				}
				Thread.Sleep(3000);
			}
			Tools.Console("Swimming stopped.", "Blue", "richConsole", "frmMain", true);
		}

		// Token: 0x040009D7 RID: 2519
		public static Dictionary<Events, List<string>> EndOfRoute = new Dictionary<Events, List<string>>();

		// Token: 0x040009D9 RID: 2521
		public static bool ClearEndOfRouteOnStartOrRestart = true;

		// Token: 0x040009DA RID: 2522
		public static bool CancelEndOfRoute = false;

		// Token: 0x040009DB RID: 2523
		public static bool UseMyHearthstone = false;

		// Token: 0x040009DC RID: 2524
		public static Events HearthstoneEvent = null;

		// Token: 0x040009DD RID: 2525
		public static bool LoadProfileAfterHearthstone = false;

		// Token: 0x040009DE RID: 2526
		public static bool GettingAttacked = false;

		// Token: 0x040009DF RID: 2527
		private static Random Rnd = new Random();

		// Token: 0x040009E0 RID: 2528
		public static object _lock = new object();

		// Token: 0x040009E1 RID: 2529
		public static object _lockExecutionList = new object();

		// Token: 0x040009E2 RID: 2530
		private static UInt128 LastVendorMountGUID = 0;

		// Token: 0x040009E3 RID: 2531
		private static Objects Transport = null;

		// Token: 0x040009E4 RID: 2532
		private static int TransportID = 0;

		// Token: 0x040009E5 RID: 2533
		private static bool WalkToTransport = false;

		// Token: 0x040009E6 RID: 2534
		private static bool SwimmingRuns = false;

		// Token: 0x040009E7 RID: 2535
		private static bool IsInBattlegroundQueue = false;

		// Token: 0x040009E8 RID: 2536
		public static bool ForcingStartWhileInBattleground = false;

		// Token: 0x040009E9 RID: 2537
		private static string ProfileAfterBattleground = "";

		// Token: 0x040009EA RID: 2538
		public static bool LoadProfileAfterBattleground = false;

		// Token: 0x040009EB RID: 2539
		public static Dictionary<string, int> ActionIDs;
	}
}
