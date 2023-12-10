using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Models;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000096 RID: 150
	public partial class frmProfileEventSave : Form
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x006D6680 File Offset: 0x006D4880
		public frmProfileEventSave(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			this.Args = args;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x006D66B4 File Offset: 0x006D48B4
		private void frmEventSave_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Save Event", true, false, true, true, false, false);
			if (this.Args.Count<object>() > 1)
			{
				this.Mode = (string)this.Args[0];
				frmProfileEventSave.Crd = (Vector3)this.Args[1];
				frmProfileEventSave.EventID = frmProfileEventSave.GenerateID;
				if (this.Args.Count<object>() > 2)
				{
					frmProfileEventSave.EventName = (string)this.Args[2];
					if (this.Mode == "Edit")
					{
						frmProfileEventSave.EventID = (int)this.Args[3];
						frmProfileEventSave.Event = ObjectManager.GetEvent(frmProfileEventSave.EventID);
						if (frmProfileEventSave.Event == null)
						{
							MessageBox.Show("This Event could not be found.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						}
					}
				}
			}
			this.txtName.Text = frmProfileEventSave.EventName;
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x006D6794 File Offset: 0x006D4994
		private void txtName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.Save();
			}
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x006D67B4 File Offset: 0x006D49B4
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x006D67C8 File Offset: 0x006D49C8
		private void Save()
		{
			string text = this.txtName.Text.ToString();
			if (text.Length > 0)
			{
				string Action = "";
				bool SettingsExecuteOnce = false;
				bool SettingsExecuteAlways = false;
				string SettingsFaction = "";
				string SettingsRace = "";
				string InteractNameOrID = "";
				bool InteractClosest = false;
				bool InteractFurthest = false;
				bool InteractAttack = false;
				bool Wait = false;
				string WaitInSeconds = "";
				bool WaitIgnoreAttackers = false;
				bool WaitFor = false;
				string WaitForNameOrID = "";
				string WaitForMaxSeconds = "";
				bool WaitForGate = false;
				string LoadProfile = "";
				string LoadRotation = "";
				string Target = "";
				string TargetLocation = "";
				bool HasCondition1 = false;
				string Condition1 = "";
				string Condition1Compare = "";
				string Condition1Value = "";
				string Condition1Value2 = "";
				string ConditionAndOr1 = "";
				bool HasCondition2 = false;
				string Condition2 = "";
				string Condition2Compare = "";
				string Condition2Value = "";
				string Condition2Value2 = "";
				string RecorderRouteType = "";
				string RecorderCombatMode = "";
				bool RecorderVendorCanRepair = false;
				bool RecorderVendorSellGreys = false;
				bool RecorderVendorSellWhites = false;
				bool RecorderVendorSellGreens = false;
				bool RecorderVendorSellBlues = false;
				bool RecorderVendorMount = false;
				string FlightMasterFlightPoint = "";
				string FlightMasterProfile = "";
				string RecorderMailboxReceiver = "";
				bool RecorderMailboxSendGreys = false;
				bool RecorderMailboxSendWhites = false;
				bool RecorderMailboxSendGreens = false;
				bool RecorderMailboxSendBlues = false;
				bool RecorderMailboxSendPurples = false;
				string CastSpell = "";
				bool CastSpellWhileWalk = false;
				bool CastSpellUntilNoAttackers = false;
				string CastSpellRadius = "";
				bool CastSpellNoRadiusCheck = false;
				bool CastSpellOnTarget = false;
				string CastSpellTargetNameOrID = "";
				bool CastSpellTargetClosest = false;
				bool CastSpellTargetFurthest = false;
				bool CastSpellGroundAOE = false;
				string WalkSensOutdoor = "";
				string WalkSensIndoor = "";
				string UseHearthstoneProfile = "";
				bool FishingUseBait = false;
				bool FishingFacing = false;
				string FishingFacingDirection = "";
				bool FishingCondition = false;
				bool FishingConditionSkill = false;
				string FishingConditionSkillLevel = "";
				bool FishingConditionItem = false;
				bool FishingConditionFullBags = false;
				bool FishingRandomDelay = true;
				string UseTransportProfile = "";
				string UseTransportTurn = "";
				string ExecuteLUA = "";
				bool ExecuteLUAWhileWalk = false;
				bool BattlegroundsClassicWarsongGulch = false;
				string BattlegroundsClassicWarsongGulchProfile = "";
				bool BattlegroundsClassicArathiBasin = false;
				string BattlegroundsClassicArathiBasinProfile = "";
				bool BattlegroundsClassicAlteracValley = false;
				string BattlegroundsClassicAlteracValleyProfile = "";
				bool BattlegroundsClassicEyeOfTheStorm = false;
				string BattlegroundsClassicEyeOfTheStormProfile = "";
				bool BattlegroundsClassicStrandOfTheAncients = false;
				string BattlegroundsClassicStrandOfTheAncientsProfile = "";
				bool BattlegroundsClassicWaitUntilInvitation = false;
				string ChangeSettingsCombatMode = "";
				string ChangeSettingsWaypointMode = "";
				bool ChangeSettingsModeFollowFleeingTarget = false;
				bool ChangeSettingsModeMesh = true;
				bool ChangeSettingsGroundMount = false;
				bool ChangeSettingsFlightMount = false;
				bool ChangeSettingsLoot = false;
				bool ChangeSettingsLootMining = false;
				bool ChangeSettingsLootHerbalism = false;
				bool ChangeSettingsLootSkinning = false;
				bool ChangeSettingsLootGatherMobs = false;
				string ChangeSettingsLootQuestItems = "";
				string ChangeSettingsLootDistance = "";
				string ChangeSettingsLootMaxPathDistance = "";
				string ChangeSettingsLootGatherDistance = "";
				string ChangeSettingsLootAvoidElitesDistance = "";
				string ChangeSettingsDistancesWaypoint = "";
				string ChangeSettingsDistancesLocation = "";
				string ChangeSettingsDistancesMobGroup = "";
				string ChangeSettingsDistancesIsReachable = "";
				string ChangeSettingsAttackableMobs = "";
				int targetDisplayID = 0;
				string targetName = "";
				if (this.Mode == "Edit")
				{
					targetDisplayID = frmProfileEventSave.Event.TargetDisplayID;
					targetName = frmProfileEventSave.Event.TargetName;
				}
				Form form = Application.OpenForms["frmProfileEvent"];
				if (form != null)
				{
					Guna2ComboBox selectAction = (Guna2ComboBox)form.Controls.Find("selectAction", true)[0];
					selectAction.Invoke(new Action(delegate()
					{
						Action = selectAction.Text;
					}));
					Guna2CheckBox checkSettingsExecuteOnce = (Guna2CheckBox)form.Controls.Find("checkSettingsExecuteOnce", true)[0];
					checkSettingsExecuteOnce.Invoke(new Action(delegate()
					{
						SettingsExecuteOnce = checkSettingsExecuteOnce.Checked;
					}));
					Guna2CheckBox checkSettingsExecuteAlways = (Guna2CheckBox)form.Controls.Find("checkSettingsExecuteAlways", true)[0];
					checkSettingsExecuteAlways.Invoke(new Action(delegate()
					{
						SettingsExecuteAlways = checkSettingsExecuteAlways.Checked;
					}));
					Guna2ComboBox selectSettingsFaction = (Guna2ComboBox)form.Controls.Find("selectSettingsFaction", true)[0];
					selectSettingsFaction.Invoke(new Action(delegate()
					{
						SettingsFaction = selectSettingsFaction.Text;
					}));
					Guna2ComboBox selectSettingsRace = (Guna2ComboBox)form.Controls.Find("selectSettingsRace", true)[0];
					selectSettingsRace.Invoke(new Action(delegate()
					{
						SettingsRace = selectSettingsRace.Text;
					}));
					Label lblCurrentTarget = (Label)form.Controls.Find("lblCurrentTarget", true)[0];
					lblCurrentTarget.Invoke(new Action(delegate()
					{
						Target = lblCurrentTarget.Text;
					}));
					Label lblCurrentTargetLocation = (Label)form.Controls.Find("lblCurrentTargetLocation", true)[0];
					lblCurrentTargetLocation.Invoke(new Action(delegate()
					{
						TargetLocation = lblCurrentTargetLocation.Text;
					}));
					Guna2CheckBox checkCondition1 = (Guna2CheckBox)form.Controls.Find("checkCondition1", true)[0];
					checkCondition1.Invoke(new Action(delegate()
					{
						HasCondition1 = checkCondition1.Checked;
					}));
					Guna2ComboBox selectCondition1 = (Guna2ComboBox)form.Controls.Find("selectCondition1", true)[0];
					selectCondition1.Invoke(new Action(delegate()
					{
						Condition1 = selectCondition1.Text;
					}));
					Guna2ComboBox selectCondition1Compare = (Guna2ComboBox)form.Controls.Find("selectCondition1Compare", true)[0];
					selectCondition1Compare.Invoke(new Action(delegate()
					{
						Condition1Compare = selectCondition1Compare.Text;
					}));
					Guna2TextBox txtCondition1Value = (Guna2TextBox)form.Controls.Find("txtCondition1Value", true)[0];
					txtCondition1Value.Invoke(new Action(delegate()
					{
						Condition1Value = txtCondition1Value.Text;
					}));
					Guna2TextBox txtCondition1Value2 = (Guna2TextBox)form.Controls.Find("txtCondition1Value2", true)[0];
					txtCondition1Value2.Invoke(new Action(delegate()
					{
						Condition1Value2 = txtCondition1Value2.Text;
					}));
					Guna2ComboBox selectConditionAndOr1 = (Guna2ComboBox)form.Controls.Find("selectConditionAndOr1", true)[0];
					selectConditionAndOr1.Invoke(new Action(delegate()
					{
						ConditionAndOr1 = selectConditionAndOr1.Text;
					}));
					Guna2CheckBox checkCondition2 = (Guna2CheckBox)form.Controls.Find("checkCondition2", true)[0];
					checkCondition2.Invoke(new Action(delegate()
					{
						HasCondition2 = checkCondition2.Checked;
					}));
					Guna2ComboBox selectCondition2 = (Guna2ComboBox)form.Controls.Find("selectCondition2", true)[0];
					selectCondition2.Invoke(new Action(delegate()
					{
						Condition2 = selectCondition2.Text;
					}));
					Guna2ComboBox selectCondition2Compare = (Guna2ComboBox)form.Controls.Find("selectCondition2Compare", true)[0];
					selectCondition2Compare.Invoke(new Action(delegate()
					{
						Condition2Compare = selectCondition2Compare.Text;
					}));
					Guna2TextBox txtCondition2Value = (Guna2TextBox)form.Controls.Find("txtCondition2Value", true)[0];
					txtCondition2Value.Invoke(new Action(delegate()
					{
						Condition2Value = txtCondition2Value.Text;
					}));
					Guna2TextBox txtCondition2Value2 = (Guna2TextBox)form.Controls.Find("txtCondition2Value2", true)[0];
					txtCondition2Value2.Invoke(new Action(delegate()
					{
						Condition2Value2 = txtCondition2Value2.Text;
					}));
					if (EventManager.IsAction(Action, "Interact with..."))
					{
						Guna2TextBox txtInteractNameOrID = (Guna2TextBox)form.Controls.Find("txtInteractNameOrID", true)[0];
						txtInteractNameOrID.Invoke(new Action(delegate()
						{
							InteractNameOrID = txtInteractNameOrID.Text;
						}));
						Guna2CheckBox checkInteractClosest = (Guna2CheckBox)form.Controls.Find("checkInteractClosest", true)[0];
						checkInteractClosest.Invoke(new Action(delegate()
						{
							InteractClosest = checkInteractClosest.Checked;
						}));
						Guna2CheckBox checkInteractFurthest = (Guna2CheckBox)form.Controls.Find("checkInteractFurthest", true)[0];
						checkInteractFurthest.Invoke(new Action(delegate()
						{
							InteractFurthest = checkInteractFurthest.Checked;
						}));
						Guna2CheckBox checkInteractAttack = (Guna2CheckBox)form.Controls.Find("checkInteractAttack", true)[0];
						checkInteractAttack.Invoke(new Action(delegate()
						{
							InteractAttack = checkInteractAttack.Checked;
						}));
					}
					else if (!EventManager.IsAction(Action, "Load Profile..."))
					{
						if (EventManager.IsAction(Action, "Load Rotation..."))
						{
							ComboBox selectLoadRotation = (ComboBox)form.Controls.Find("selectLoadRotation", true)[0];
							selectLoadRotation.Invoke(new Action(delegate()
							{
								LoadRotation = selectLoadRotation.Text;
							}));
						}
						else if (!EventManager.IsAction(Action, "Wait..."))
						{
							if (EventManager.IsAction(Action, "Add Route..."))
							{
								Guna2ComboBox selectRecorderRouteType = (Guna2ComboBox)form.Controls.Find("selectRecorderRouteType", true)[0];
								selectRecorderRouteType.Invoke(new Action(delegate()
								{
									RecorderRouteType = selectRecorderRouteType.Text;
								}));
								Guna2ComboBox selectRecorderCombatMode = (Guna2ComboBox)form.Controls.Find("selectRecorderCombatMode", true)[0];
								selectRecorderCombatMode.Invoke(new Action(delegate()
								{
									RecorderCombatMode = selectRecorderCombatMode.Text;
								}));
								ComboBox selectRecorderFlightMasterFlightPoints = (ComboBox)form.Controls.Find("selectRecorderFlightMasterFlightPoints", true)[0];
								selectRecorderFlightMasterFlightPoints.Invoke(new Action(delegate()
								{
									FlightMasterFlightPoint = selectRecorderFlightMasterFlightPoints.Text;
								}));
								ComboBox selectRecorderFlightMasterProfiles = (ComboBox)form.Controls.Find("selectRecorderFlightMasterProfiles", true)[0];
								selectRecorderFlightMasterProfiles.Invoke(new Action(delegate()
								{
									FlightMasterProfile = selectRecorderFlightMasterProfiles.Text;
								}));
								Guna2CheckBox checkRecorderVendorCanRepair = (Guna2CheckBox)form.Controls.Find("checkRecorderVendorCanRepair", true)[0];
								checkRecorderVendorCanRepair.Invoke(new Action(delegate()
								{
									RecorderVendorCanRepair = checkRecorderVendorCanRepair.Checked;
								}));
								Guna2CheckBox checkRecorderVendorSellGreys = (Guna2CheckBox)form.Controls.Find("checkRecorderVendorSellGreys", true)[0];
								checkRecorderVendorSellGreys.Invoke(new Action(delegate()
								{
									RecorderVendorSellGreys = checkRecorderVendorSellGreys.Checked;
								}));
								Guna2CheckBox checkRecorderVendorSellWhites = (Guna2CheckBox)form.Controls.Find("checkRecorderVendorSellWhites", true)[0];
								checkRecorderVendorSellWhites.Invoke(new Action(delegate()
								{
									RecorderVendorSellWhites = checkRecorderVendorSellWhites.Checked;
								}));
								Guna2CheckBox checkRecorderVendorSellGreens = (Guna2CheckBox)form.Controls.Find("checkRecorderVendorSellGreens", true)[0];
								checkRecorderVendorSellGreens.Invoke(new Action(delegate()
								{
									RecorderVendorSellGreens = checkRecorderVendorSellGreens.Checked;
								}));
								Guna2CheckBox checkRecorderVendorSellBlues = (Guna2CheckBox)form.Controls.Find("checkRecorderVendorSellBlues", true)[0];
								checkRecorderVendorSellBlues.Invoke(new Action(delegate()
								{
									RecorderVendorSellBlues = checkRecorderVendorSellBlues.Checked;
								}));
								Guna2CheckBox checkRecorderVendorMount = (Guna2CheckBox)form.Controls.Find("checkRecorderVendorMount", true)[0];
								checkRecorderVendorMount.Invoke(new Action(delegate()
								{
									RecorderVendorMount = checkRecorderVendorMount.Checked;
								}));
								Guna2CheckBox checkRecorderMailboxSendGreys = (Guna2CheckBox)form.Controls.Find("checkRecorderMailboxSendGreys", true)[0];
								checkRecorderMailboxSendGreys.Invoke(new Action(delegate()
								{
									RecorderMailboxSendGreys = checkRecorderMailboxSendGreys.Checked;
								}));
								Guna2CheckBox checkRecorderMailboxSendWhites = (Guna2CheckBox)form.Controls.Find("checkRecorderMailboxSendWhites", true)[0];
								checkRecorderMailboxSendWhites.Invoke(new Action(delegate()
								{
									RecorderMailboxSendWhites = checkRecorderMailboxSendWhites.Checked;
								}));
								Guna2CheckBox checkRecorderMailboxSendGreens = (Guna2CheckBox)form.Controls.Find("checkRecorderMailboxSendGreens", true)[0];
								checkRecorderMailboxSendGreens.Invoke(new Action(delegate()
								{
									RecorderMailboxSendGreens = checkRecorderMailboxSendGreens.Checked;
								}));
								Guna2CheckBox checkRecorderMailboxSendBlues = (Guna2CheckBox)form.Controls.Find("checkRecorderMailboxSendBlues", true)[0];
								checkRecorderMailboxSendBlues.Invoke(new Action(delegate()
								{
									RecorderMailboxSendBlues = checkRecorderMailboxSendBlues.Checked;
								}));
								Guna2CheckBox checkRecorderMailboxSendPurples = (Guna2CheckBox)form.Controls.Find("checkRecorderMailboxSendPurples", true)[0];
								checkRecorderMailboxSendPurples.Invoke(new Action(delegate()
								{
									RecorderMailboxSendPurples = checkRecorderMailboxSendPurples.Checked;
								}));
								Guna2TextBox txtRecorderMailboxReceiver = (Guna2TextBox)form.Controls.Find("txtRecorderMailboxReceiver", true)[0];
								txtRecorderMailboxReceiver.Invoke(new Action(delegate()
								{
									RecorderMailboxReceiver = txtRecorderMailboxReceiver.Text;
								}));
							}
							else if (!EventManager.IsAction(Action, "Cast Spell..."))
							{
								if (EventManager.IsAction(Action, "Change Walk Sensitivity..."))
								{
									Label lblWalkSensOutdoorData = (Label)form.Controls.Find("lblWalkSensOutdoorData", true)[0];
									lblWalkSensOutdoorData.Invoke(new Action(delegate()
									{
										WalkSensOutdoor = lblWalkSensOutdoorData.Text;
									}));
									Label lblWalkSensIndoorData = (Label)form.Controls.Find("lblWalkSensIndoorData", true)[0];
									lblWalkSensIndoorData.Invoke(new Action(delegate()
									{
										WalkSensIndoor = lblWalkSensIndoorData.Text;
									}));
								}
								else if (!EventManager.IsAction(Action, "Use Hearthstone..."))
								{
									if (!EventManager.IsAction(Action, "Start Fishing..."))
									{
										if (!EventManager.IsAction(Action, "Use Transport..."))
										{
											if (!EventManager.IsAction(Action, "Execute LUA..."))
											{
												if (!EventManager.IsAction(Action, "Join Battlegrounds (Classic)..."))
												{
													if (EventManager.IsAction(Action, "Change Profile Settings..."))
													{
														Guna2ComboBox selectSettingsCombatMode = (Guna2ComboBox)form.Controls.Find("selectSettingsCombatMode", true)[0];
														selectSettingsCombatMode.Invoke(new Action(delegate()
														{
															ChangeSettingsCombatMode = selectSettingsCombatMode.Text;
														}));
														Guna2ComboBox selectSettingsWaypointMode = (Guna2ComboBox)form.Controls.Find("selectSettingsWaypointMode", true)[0];
														selectSettingsWaypointMode.Invoke(new Action(delegate()
														{
															ChangeSettingsWaypointMode = selectSettingsWaypointMode.Text;
														}));
														Guna2CheckBox checkSettingsModeFollowFleeingTarget = (Guna2CheckBox)form.Controls.Find("checkSettingsModeFollowFleeingTarget", true)[0];
														checkSettingsModeFollowFleeingTarget.Invoke(new Action(delegate()
														{
															ChangeSettingsModeFollowFleeingTarget = checkSettingsModeFollowFleeingTarget.Checked;
														}));
														Guna2CheckBox checkSettingsModeMesh = (Guna2CheckBox)form.Controls.Find("checkSettingsModeMesh", true)[0];
														checkSettingsModeMesh.Invoke(new Action(delegate()
														{
															ChangeSettingsModeMesh = checkSettingsModeMesh.Checked;
														}));
														Guna2CheckBox checkSettingsGroundMount = (Guna2CheckBox)form.Controls.Find("checkSettingsGroundMount", true)[0];
														checkSettingsGroundMount.Invoke(new Action(delegate()
														{
															ChangeSettingsGroundMount = checkSettingsGroundMount.Checked;
														}));
														Guna2CheckBox checkSettingsFlightMount = (Guna2CheckBox)form.Controls.Find("checkSettingsFlightMount", true)[0];
														checkSettingsFlightMount.Invoke(new Action(delegate()
														{
															ChangeSettingsFlightMount = checkSettingsFlightMount.Checked;
														}));
														Guna2CheckBox checkSettingsLoot = (Guna2CheckBox)form.Controls.Find("checkSettingsLoot", true)[0];
														checkSettingsLoot.Invoke(new Action(delegate()
														{
															ChangeSettingsLoot = checkSettingsLoot.Checked;
														}));
														Guna2CheckBox checkSettingsLootMining = (Guna2CheckBox)form.Controls.Find("checkSettingsLootMining", true)[0];
														checkSettingsLootMining.Invoke(new Action(delegate()
														{
															ChangeSettingsLootMining = checkSettingsLootMining.Checked;
														}));
														Guna2CheckBox checkSettingsLootHerbalism = (Guna2CheckBox)form.Controls.Find("checkSettingsLootHerbalism", true)[0];
														checkSettingsLootHerbalism.Invoke(new Action(delegate()
														{
															ChangeSettingsLootHerbalism = checkSettingsLootHerbalism.Checked;
														}));
														Guna2CheckBox checkSettingsLootSkinning = (Guna2CheckBox)form.Controls.Find("checkSettingsLootSkinning", true)[0];
														checkSettingsLootSkinning.Invoke(new Action(delegate()
														{
															ChangeSettingsLootSkinning = checkSettingsLootSkinning.Checked;
														}));
														Guna2CheckBox checkSettingsLootGatherMobs = (Guna2CheckBox)form.Controls.Find("checkSettingsLootGatherMobs", true)[0];
														checkSettingsLootGatherMobs.Invoke(new Action(delegate()
														{
															ChangeSettingsLootGatherMobs = checkSettingsLootGatherMobs.Checked;
														}));
														Guna2TextBox txtSettingsLootQuestItems = (Guna2TextBox)form.Controls.Find("txtSettingsLootQuestItems", true)[0];
														txtSettingsLootQuestItems.Invoke(new Action(delegate()
														{
															ChangeSettingsLootQuestItems = txtSettingsLootQuestItems.Text;
														}));
														Guna2TextBox txtSettingsLootDistance = (Guna2TextBox)form.Controls.Find("txtSettingsLootDistance", true)[0];
														txtSettingsLootDistance.Invoke(new Action(delegate()
														{
															ChangeSettingsLootDistance = txtSettingsLootDistance.Text;
														}));
														Guna2TextBox txtSettingsLootMaxPathDistance = (Guna2TextBox)form.Controls.Find("txtSettingsLootMaxPathDistance", true)[0];
														txtSettingsLootMaxPathDistance.Invoke(new Action(delegate()
														{
															ChangeSettingsLootMaxPathDistance = txtSettingsLootMaxPathDistance.Text;
														}));
														Guna2TextBox txtSettingsLootGatherDistance = (Guna2TextBox)form.Controls.Find("txtSettingsLootGatherDistance", true)[0];
														txtSettingsLootGatherDistance.Invoke(new Action(delegate()
														{
															ChangeSettingsLootGatherDistance = txtSettingsLootGatherDistance.Text;
														}));
														Guna2TextBox txtSettingsLootAvoidElitesDistance = (Guna2TextBox)form.Controls.Find("txtSettingsLootAvoidElitesDistance", true)[0];
														txtSettingsLootAvoidElitesDistance.Invoke(new Action(delegate()
														{
															ChangeSettingsLootAvoidElitesDistance = txtSettingsLootAvoidElitesDistance.Text;
														}));
														Guna2TextBox txtSettingsDistancesWaypoint = (Guna2TextBox)form.Controls.Find("txtSettingsDistancesWaypoint", true)[0];
														txtSettingsDistancesWaypoint.Invoke(new Action(delegate()
														{
															ChangeSettingsDistancesWaypoint = txtSettingsDistancesWaypoint.Text;
														}));
														Guna2TextBox txtSettingsDistancesLocation = (Guna2TextBox)form.Controls.Find("txtSettingsDistancesLocation", true)[0];
														txtSettingsDistancesLocation.Invoke(new Action(delegate()
														{
															ChangeSettingsDistancesLocation = txtSettingsDistancesLocation.Text;
														}));
														Guna2TextBox txtSettingsDistancesMobGroup = (Guna2TextBox)form.Controls.Find("txtSettingsDistancesMobGroup", true)[0];
														txtSettingsDistancesMobGroup.Invoke(new Action(delegate()
														{
															ChangeSettingsDistancesMobGroup = txtSettingsDistancesMobGroup.Text;
														}));
														Guna2TextBox txtSettingsDistancesIsReachable = (Guna2TextBox)form.Controls.Find("txtSettingsDistancesIsReachable", true)[0];
														txtSettingsDistancesIsReachable.Invoke(new Action(delegate()
														{
															ChangeSettingsDistancesIsReachable = txtSettingsDistancesIsReachable.Text;
														}));
														RichTextBox richSettingsMobs = (RichTextBox)form.Controls.Find("richSettingsMobs", true)[0];
														richSettingsMobs.Invoke(new Action(delegate()
														{
															ChangeSettingsAttackableMobs = richSettingsMobs.Text;
														}));
													}
												}
												else
												{
													Guna2CheckBox checkBattlegroundClassicWarsongGulch = (Guna2CheckBox)form.Controls.Find("checkBattlegroundClassicWarsongGulch", true)[0];
													checkBattlegroundClassicWarsongGulch.Invoke(new Action(delegate()
													{
														BattlegroundsClassicWarsongGulch = checkBattlegroundClassicWarsongGulch.Checked;
													}));
													ComboBox selectBattlegroundClassicWarsongGulch = (ComboBox)form.Controls.Find("selectBattlegroundClassicWarsongGulch", true)[0];
													selectBattlegroundClassicWarsongGulch.Invoke(new Action(delegate()
													{
														BattlegroundsClassicWarsongGulchProfile = selectBattlegroundClassicWarsongGulch.Text;
													}));
													Guna2CheckBox checkBattlegroundClassicArathiBasin = (Guna2CheckBox)form.Controls.Find("checkBattlegroundClassicArathiBasin", true)[0];
													checkBattlegroundClassicArathiBasin.Invoke(new Action(delegate()
													{
														BattlegroundsClassicArathiBasin = checkBattlegroundClassicArathiBasin.Checked;
													}));
													ComboBox selectBattlegroundClassicArathiBasin = (ComboBox)form.Controls.Find("selectBattlegroundClassicArathiBasin", true)[0];
													selectBattlegroundClassicArathiBasin.Invoke(new Action(delegate()
													{
														BattlegroundsClassicArathiBasinProfile = selectBattlegroundClassicArathiBasin.Text;
													}));
													Guna2CheckBox checkBattlegroundClassicAlteracValley = (Guna2CheckBox)form.Controls.Find("checkBattlegroundClassicAlteracValley", true)[0];
													checkBattlegroundClassicAlteracValley.Invoke(new Action(delegate()
													{
														BattlegroundsClassicAlteracValley = checkBattlegroundClassicAlteracValley.Checked;
													}));
													ComboBox selectBattlegroundClassicAlteracValley = (ComboBox)form.Controls.Find("selectBattlegroundClassicAlteracValley", true)[0];
													selectBattlegroundClassicAlteracValley.Invoke(new Action(delegate()
													{
														BattlegroundsClassicAlteracValleyProfile = selectBattlegroundClassicAlteracValley.Text;
													}));
													Guna2CheckBox checkBattlegroundClassicEyeOfTheStorm = (Guna2CheckBox)form.Controls.Find("checkBattlegroundClassicEyeOfTheStorm", true)[0];
													checkBattlegroundClassicEyeOfTheStorm.Invoke(new Action(delegate()
													{
														BattlegroundsClassicEyeOfTheStorm = checkBattlegroundClassicEyeOfTheStorm.Checked;
													}));
													ComboBox selectBattlegroundClassicEyeOfTheStorm = (ComboBox)form.Controls.Find("selectBattlegroundClassicEyeOfTheStorm", true)[0];
													selectBattlegroundClassicEyeOfTheStorm.Invoke(new Action(delegate()
													{
														BattlegroundsClassicEyeOfTheStormProfile = selectBattlegroundClassicEyeOfTheStorm.Text;
													}));
													Guna2CheckBox checkBattlegroundClassicStrandOfTheAncients = (Guna2CheckBox)form.Controls.Find("checkBattlegroundClassicStrandOfTheAncients", true)[0];
													checkBattlegroundClassicStrandOfTheAncients.Invoke(new Action(delegate()
													{
														BattlegroundsClassicStrandOfTheAncients = checkBattlegroundClassicStrandOfTheAncients.Checked;
													}));
													ComboBox selectBattlegroundClassicStrandOfTheAncients = (ComboBox)form.Controls.Find("selectBattlegroundClassicStrandOfTheAncients", true)[0];
													selectBattlegroundClassicStrandOfTheAncients.Invoke(new Action(delegate()
													{
														BattlegroundsClassicStrandOfTheAncientsProfile = selectBattlegroundClassicStrandOfTheAncients.Text;
													}));
													Guna2CheckBox checkBattlegroundClassicWaitUntilInvitation = (Guna2CheckBox)form.Controls.Find("checkBattlegroundClassicWaitUntilInvitation", true)[0];
													checkBattlegroundClassicWaitUntilInvitation.Invoke(new Action(delegate()
													{
														BattlegroundsClassicWaitUntilInvitation = checkBattlegroundClassicWaitUntilInvitation.Checked;
													}));
												}
											}
											else
											{
												Guna2TextBox txtExecuteLUA = (Guna2TextBox)form.Controls.Find("txtExecuteLUA", true)[0];
												txtExecuteLUA.Invoke(new Action(delegate()
												{
													ExecuteLUA = txtExecuteLUA.Text;
												}));
												Guna2CheckBox checkExecuteLUAWhileWalk = (Guna2CheckBox)form.Controls.Find("checkExecuteLUAWhileWalk", true)[0];
												checkExecuteLUAWhileWalk.Invoke(new Action(delegate()
												{
													ExecuteLUAWhileWalk = checkExecuteLUAWhileWalk.Checked;
												}));
											}
										}
										else
										{
											ComboBox selectUseTransportLoadProfile = (ComboBox)form.Controls.Find("selectUseTransportLoadProfile", true)[0];
											selectUseTransportLoadProfile.Invoke(new Action(delegate()
											{
												UseTransportProfile = selectUseTransportLoadProfile.Text;
											}));
											Guna2ComboBox selectUseTransportTurn = (Guna2ComboBox)form.Controls.Find("selectUseTransportTurn", true)[0];
											selectUseTransportTurn.Invoke(new Action(delegate()
											{
												UseTransportTurn = selectUseTransportTurn.Text;
											}));
										}
									}
									else
									{
										Guna2CheckBox checkFishingBait = (Guna2CheckBox)form.Controls.Find("checkFishingBait", true)[0];
										checkFishingBait.Invoke(new Action(delegate()
										{
											FishingUseBait = checkFishingBait.Checked;
										}));
										Guna2CheckBox checkFishingFacing = (Guna2CheckBox)form.Controls.Find("checkFishingFacing", true)[0];
										checkFishingFacing.Invoke(new Action(delegate()
										{
											FishingFacing = checkFishingFacing.Checked;
										}));
										Label lblFishingFacingDirection = (Label)form.Controls.Find("lblFishingFacingDirection", true)[0];
										lblFishingFacingDirection.Invoke(new Action(delegate()
										{
											FishingFacingDirection = lblFishingFacingDirection.Text;
										}));
										Guna2CheckBox checkFishingCondition = (Guna2CheckBox)form.Controls.Find("checkFishingCondition", true)[0];
										checkFishingCondition.Invoke(new Action(delegate()
										{
											FishingCondition = checkFishingCondition.Checked;
										}));
										Guna2CheckBox checkFishingConditionSkillLevel = (Guna2CheckBox)form.Controls.Find("checkFishingConditionSkillLevel", true)[0];
										checkFishingConditionSkillLevel.Invoke(new Action(delegate()
										{
											FishingConditionSkill = checkFishingConditionSkillLevel.Checked;
										}));
										Guna2TextBox txtFishingConditionSkillLevel = (Guna2TextBox)form.Controls.Find("txtFishingConditionSkillLevel", true)[0];
										txtFishingConditionSkillLevel.Invoke(new Action(delegate()
										{
											FishingConditionSkillLevel = txtFishingConditionSkillLevel.Text;
										}));
										Guna2CheckBox checkFishingConditionItemlist = (Guna2CheckBox)form.Controls.Find("checkFishingConditionItemlist", true)[0];
										checkFishingConditionItemlist.Invoke(new Action(delegate()
										{
											FishingConditionItem = checkFishingConditionItemlist.Checked;
										}));
										Guna2CheckBox checkFishingConditionFullBags = (Guna2CheckBox)form.Controls.Find("checkFishingConditionFullBags", true)[0];
										checkFishingConditionFullBags.Invoke(new Action(delegate()
										{
											FishingConditionFullBags = checkFishingConditionFullBags.Checked;
										}));
										Guna2CheckBox checkFishingOptionsRandomDelay = (Guna2CheckBox)form.Controls.Find("checkFishingOptionsRandomDelay", true)[0];
										checkFishingOptionsRandomDelay.Invoke(new Action(delegate()
										{
											FishingRandomDelay = checkFishingOptionsRandomDelay.Checked;
										}));
									}
								}
								else
								{
									ComboBox selectUseHearthstoneLoadProfile = (ComboBox)form.Controls.Find("selectUseHearthstoneLoadProfile", true)[0];
									selectUseHearthstoneLoadProfile.Invoke(new Action(delegate()
									{
										UseHearthstoneProfile = selectUseHearthstoneLoadProfile.Text;
									}));
								}
							}
							else
							{
								ComboBox selectCastSpell = (ComboBox)form.Controls.Find("selectCastSpell", true)[0];
								selectCastSpell.Invoke(new Action(delegate()
								{
									CastSpell = selectCastSpell.Text;
								}));
								Guna2CheckBox checkCastSpellWhileWalk = (Guna2CheckBox)form.Controls.Find("checkCastSpellWhileWalk", true)[0];
								checkCastSpellWhileWalk.Invoke(new Action(delegate()
								{
									CastSpellWhileWalk = checkCastSpellWhileWalk.Checked;
								}));
								Guna2TextBox txtCastSpellRadius = (Guna2TextBox)form.Controls.Find("txtCastSpellRadius", true)[0];
								txtCastSpellRadius.Invoke(new Action(delegate()
								{
									CastSpellRadius = txtCastSpellRadius.Text;
								}));
								Guna2CheckBox checkCastSpellNoRadiusCheck = (Guna2CheckBox)form.Controls.Find("checkCastSpellNoRadiusCheck", true)[0];
								checkCastSpellNoRadiusCheck.Invoke(new Action(delegate()
								{
									CastSpellNoRadiusCheck = checkCastSpellNoRadiusCheck.Checked;
								}));
								Guna2CheckBox checkCastSpellGroundAOE = (Guna2CheckBox)form.Controls.Find("checkCastSpellGroundAOE", true)[0];
								checkCastSpellGroundAOE.Invoke(new Action(delegate()
								{
									CastSpellGroundAOE = checkCastSpellGroundAOE.Checked;
								}));
								Guna2CheckBox checkCastSpellTarget = (Guna2CheckBox)form.Controls.Find("checkCastSpellTarget", true)[0];
								checkCastSpellTarget.Invoke(new Action(delegate()
								{
									CastSpellOnTarget = checkCastSpellTarget.Checked;
								}));
								Guna2TextBox txtCastSpellTargetNameOrID = (Guna2TextBox)form.Controls.Find("txtCastSpellTargetNameOrID", true)[0];
								txtCastSpellTargetNameOrID.Invoke(new Action(delegate()
								{
									CastSpellTargetNameOrID = txtCastSpellTargetNameOrID.Text;
								}));
								Guna2CheckBox checkCastSpellTargetClosest = (Guna2CheckBox)form.Controls.Find("checkCastSpellTargetClosest", true)[0];
								checkCastSpellTargetClosest.Invoke(new Action(delegate()
								{
									CastSpellTargetClosest = checkCastSpellTargetClosest.Checked;
								}));
								Guna2CheckBox checkCastSpellTargetFurthest = (Guna2CheckBox)form.Controls.Find("checkCastSpellTargetFurthest", true)[0];
								checkCastSpellTargetFurthest.Invoke(new Action(delegate()
								{
									CastSpellTargetFurthest = checkCastSpellTargetFurthest.Checked;
								}));
								Guna2CheckBox checkCastSpellUntilNoAttackers = (Guna2CheckBox)form.Controls.Find("checkCastSpellUntilNoAttackers", true)[0];
								checkCastSpellUntilNoAttackers.Invoke(new Action(delegate()
								{
									CastSpellUntilNoAttackers = checkCastSpellUntilNoAttackers.Checked;
								}));
							}
						}
						else
						{
							Guna2CheckBox checkWait = (Guna2CheckBox)form.Controls.Find("checkWait", true)[0];
							checkWait.Invoke(new Action(delegate()
							{
								Wait = checkWait.Checked;
							}));
							Guna2TextBox txtWaitSeconds = (Guna2TextBox)form.Controls.Find("txtWaitSeconds", true)[0];
							txtWaitSeconds.Invoke(new Action(delegate()
							{
								WaitInSeconds = txtWaitSeconds.Text;
							}));
							Guna2CheckBox checkWaitIgnoreAttackers = (Guna2CheckBox)form.Controls.Find("checkWaitIgnoreAttackers", true)[0];
							checkWaitIgnoreAttackers.Invoke(new Action(delegate()
							{
								WaitIgnoreAttackers = checkWaitIgnoreAttackers.Checked;
							}));
							Guna2CheckBox checkWaitFor = (Guna2CheckBox)form.Controls.Find("checkWaitFor", true)[0];
							checkWaitFor.Invoke(new Action(delegate()
							{
								WaitFor = checkWaitFor.Checked;
							}));
							Guna2TextBox txtWaitForNameOrID = (Guna2TextBox)form.Controls.Find("txtWaitForNameOrID", true)[0];
							txtWaitForNameOrID.Invoke(new Action(delegate()
							{
								WaitForNameOrID = txtWaitForNameOrID.Text;
							}));
							Guna2TextBox txtWaitForMaxSeconds = (Guna2TextBox)form.Controls.Find("txtWaitForMaxSeconds", true)[0];
							txtWaitForMaxSeconds.Invoke(new Action(delegate()
							{
								WaitForMaxSeconds = txtWaitForMaxSeconds.Text;
							}));
							Guna2CheckBox checkWaitForGate = (Guna2CheckBox)form.Controls.Find("checkWaitForGate", true)[0];
							checkWaitForGate.Invoke(new Action(delegate()
							{
								WaitForGate = checkWaitForGate.Checked;
							}));
						}
					}
					else
					{
						ComboBox selectLoadProfile = (ComboBox)form.Controls.Find("selectLoadProfile", true)[0];
						selectLoadProfile.Invoke(new Action(delegate()
						{
							LoadProfile = selectLoadProfile.Text;
						}));
					}
					int index = 0;
					if (this.Mode == "Edit")
					{
						int num = 0;
						using (List<Events>.Enumerator enumerator = frmProfile.RecordedEvents.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.ID == frmProfileEventSave.EventID)
								{
									index = num;
									break;
								}
								num++;
							}
						}
						frmProfile.RecordedEvents.RemoveAll((Events evt) => evt.ID == frmProfileEventSave.Event.ID);
					}
					frmProfileEventSave.Event = new Events();
					if (this.Mode == "Edit" && targetDisplayID.ToString().Length > 0)
					{
						frmProfileEventSave.Event.TargetDisplayID = targetDisplayID;
						frmProfileEventSave.Event.TargetName = targetName;
					}
					frmProfileEventSave.Event.Vector3 = frmProfileEventSave.Crd;
					frmProfileEventSave.Event.Name = text.Replace("[", "(").Replace("]", ")");
					frmProfileEventSave.Event.Action = Action;
					frmProfileEventSave.Event.ID = frmProfileEventSave.EventID;
					frmProfileEventSave.Event.SettingsExecuteOnce = SettingsExecuteOnce;
					frmProfileEventSave.Event.SettingsExecuteAlways = SettingsExecuteAlways;
					frmProfileEventSave.Event.Faction = SettingsFaction;
					frmProfileEventSave.Event.Race = SettingsRace;
					frmProfileEventSave.Event.HasCondition1 = HasCondition1;
					if (HasCondition1)
					{
						frmProfileEventSave.Event.Condition1 = Condition1;
						frmProfileEventSave.Event.Condition1Compare = Condition1Compare;
						frmProfileEventSave.Event.Condition1Value = Condition1Value;
						if (Condition1Value2.Length > 0)
						{
							frmProfileEventSave.Event.Condition1Value2 = Condition1Value2;
						}
					}
					frmProfileEventSave.Event.HasCondition2 = HasCondition2;
					if (HasCondition2)
					{
						frmProfileEventSave.Event.ConditionAndOr1 = ConditionAndOr1;
						frmProfileEventSave.Event.Condition2 = Condition2;
						frmProfileEventSave.Event.Condition2Compare = Condition2Compare;
						frmProfileEventSave.Event.Condition2Value = Condition2Value;
						if (Condition2Value2.Length > 0)
						{
							frmProfileEventSave.Event.Condition2Value2 = Condition2Value2;
						}
					}
					if (EventManager.IsAction(Action, "Add Route..."))
					{
						if (Target.Contains("["))
						{
							string text2 = Target.Split(new char[]
							{
								'['
							})[0].TrimEnd(Array.Empty<char>());
							string s = Target.Split(new char[]
							{
								'[',
								']'
							})[1];
							if (text2.Length > 0)
							{
								frmProfileEventSave.Event.TargetName = text2;
							}
							int num2;
							if (int.TryParse(s, out num2) && num2 > 0)
							{
								frmProfileEventSave.Event.TargetDisplayID = num2;
							}
						}
						frmProfileEventSave.Event.TargetLocation = Tools.StringToVector3(TargetLocation);
						frmProfileEventSave.Event.LandingField = frmProfileEvent.LandingField;
						List<Vector3> list = new List<Vector3>();
						if (frmProfileEvent.RecordedEventWaypoints.Count > 0)
						{
							foreach (Vector3 item in frmProfileEvent.RecordedEventWaypoints)
							{
								list.Add(item);
							}
						}
						bool ghostDirectionPathToGraveyard = true;
						if (RecorderRouteType.StartsWith("Ghost"))
						{
							if (RecorderRouteType.Contains("Graveyard to Path"))
							{
								ghostDirectionPathToGraveyard = false;
							}
							frmProfileEventSave.Event.GhostDirectionPathToGraveyard = ghostDirectionPathToGraveyard;
							RecorderRouteType = "Ghost";
						}
						frmProfileEventSave.Event.Route = list;
						frmProfileEventSave.Event.RouteType = RecorderRouteType;
						frmProfileEventSave.Event.CombatMode = RecorderCombatMode;
						if (RecorderRouteType == "Vendor")
						{
							frmProfileEventSave.Event.VendorCanRepair = RecorderVendorCanRepair;
							frmProfileEventSave.Event.VendorSellGreys = RecorderVendorSellGreys;
							frmProfileEventSave.Event.VendorSellWhites = RecorderVendorSellWhites;
							frmProfileEventSave.Event.VendorSellGreens = RecorderVendorSellGreens;
							frmProfileEventSave.Event.VendorSellBlues = RecorderVendorSellBlues;
							frmProfileEventSave.Event.VendorMount = RecorderVendorMount;
							if (frmProfileEvent.RecordedWhitelist.Count > 0)
							{
								List<string> list2 = new List<string>();
								foreach (string item2 in frmProfileEvent.RecordedWhitelist)
								{
									list2.Add(item2);
								}
								frmProfileEventSave.Event.VendorWhitelist = list2;
							}
							else
							{
								frmProfileEventSave.Event.VendorWhitelist.Clear();
							}
							if (frmProfileEvent.RecordedBuylist.Count > 0)
							{
								List<string> list3 = new List<string>();
								foreach (string item3 in frmProfileEvent.RecordedBuylist)
								{
									list3.Add(item3);
								}
								frmProfileEventSave.Event.VendorBuylist = list3;
							}
							else
							{
								frmProfileEventSave.Event.VendorBuylist.Clear();
							}
						}
						else if (RecorderRouteType == "Flight Master")
						{
							frmProfileEventSave.Event.FlightPointName = FlightMasterFlightPoint;
							frmProfileEventSave.Event.FlightPointID = ObjectManager.GetFlightPoint(FlightMasterFlightPoint);
							frmProfileEventSave.Event.FlightPointProfile = FlightMasterProfile;
						}
						else if (RecorderRouteType == "Mailbox")
						{
							frmProfileEventSave.Event.RecorderMailboxReceiver = RecorderMailboxReceiver;
							if (frmProfileEvent.RecordedSendlist.Count > 0)
							{
								List<string> list4 = new List<string>();
								foreach (string item4 in frmProfileEvent.RecordedSendlist)
								{
									list4.Add(item4);
								}
								frmProfileEventSave.Event.RecorderMailboxSendlist = list4;
							}
							else
							{
								frmProfileEventSave.Event.RecorderMailboxSendlist.Clear();
							}
							frmProfileEventSave.Event.RecorderMailboxSendGreys = RecorderMailboxSendGreys;
							frmProfileEventSave.Event.RecorderMailboxSendWhites = RecorderMailboxSendWhites;
							frmProfileEventSave.Event.RecorderMailboxSendGreens = RecorderMailboxSendGreens;
							frmProfileEventSave.Event.RecorderMailboxSendBlues = RecorderMailboxSendBlues;
							frmProfileEventSave.Event.RecorderMailboxSendPurples = RecorderMailboxSendPurples;
						}
					}
					else if (EventManager.IsAction(Action, "Interact with..."))
					{
						frmProfileEventSave.Event.InteractNameOrID = InteractNameOrID;
						frmProfileEventSave.Event.InteractWithClosest = InteractClosest;
						frmProfileEventSave.Event.InteractWithFurthest = InteractFurthest;
						frmProfileEventSave.Event.InteractWithAttack = InteractAttack;
					}
					else if (!EventManager.IsAction(Action, "Wait..."))
					{
						if (!EventManager.IsAction(Action, "Load Profile...") && !EventManager.IsAction(Action, "Enter/Leave Dungeon..."))
						{
							if (!EventManager.IsAction(Action, "Load Rotation..."))
							{
								if (EventManager.IsAction(Action, "Cast Spell..."))
								{
									frmProfileEventSave.Event.CastSpellID = Convert.ToInt32(CastSpell.Split(new char[]
									{
										'[',
										']'
									})[1]);
									frmProfileEventSave.Event.CastSpellWhileWalk = CastSpellWhileWalk;
									frmProfileEventSave.Event.CastSpellUntilNoAttackers = CastSpellUntilNoAttackers;
									frmProfileEventSave.Event.CastSpellRadius = Convert.ToInt32(CastSpellRadius);
									frmProfileEventSave.Event.CastSpellNoRadiusCheck = CastSpellNoRadiusCheck;
									frmProfileEventSave.Event.CastSpellGroundAOE = CastSpellGroundAOE;
									if (CastSpellOnTarget)
									{
										frmProfileEventSave.Event.CastSpellOnTarget = CastSpellOnTarget;
										frmProfileEventSave.Event.CastSpellTargetNameOrID = CastSpellTargetNameOrID;
										frmProfileEventSave.Event.CastSpellTargetClosest = CastSpellTargetClosest;
										frmProfileEventSave.Event.CastSpellTargetFurthest = CastSpellTargetFurthest;
									}
								}
								else if (!EventManager.IsAction(Action, "Change Walk Sensitivity..."))
								{
									if (!EventManager.IsAction(Action, "Use Hearthstone..."))
									{
										if (EventManager.IsAction(Action, "Start Fishing..."))
										{
											frmProfileEventSave.Event.FishingUseBait = FishingUseBait;
											if (FishingFacing)
											{
												frmProfileEventSave.Event.FishingFacing = FishingFacing;
												frmProfileEventSave.Event.FishingFacingDirection = Tools.StringToVector3(FishingFacingDirection);
											}
											if (FishingCondition)
											{
												frmProfileEventSave.Event.FishingCondition = FishingCondition;
												if (FishingConditionSkill)
												{
													frmProfileEventSave.Event.FishingConditionSkill = FishingConditionSkill;
													frmProfileEventSave.Event.FishingConditionSkillLevel = Convert.ToInt32(FishingConditionSkillLevel);
												}
												if (FishingConditionItem)
												{
													frmProfileEventSave.Event.FishingConditionItem = FishingConditionItem;
													List<string> list5 = new List<string>();
													foreach (string item5 in frmProfileEvent.RecordedFishingItemlist)
													{
														list5.Add(item5);
													}
													frmProfileEventSave.Event.FishingConditionItemList = list5;
												}
												frmProfileEventSave.Event.FishingConditionFullBags = FishingConditionFullBags;
											}
											frmProfileEventSave.Event.FishingRandomDelay = FishingRandomDelay;
										}
										else if (EventManager.IsAction(Action, "Use Transport..."))
										{
											frmProfileEventSave.Event.UseTransportProfile = UseTransportProfile;
											frmProfileEventSave.Event.UseTransportTurn = UseTransportTurn;
										}
										else if (!EventManager.IsAction(Action, "Execute LUA..."))
										{
											if (!EventManager.IsAction(Action, "Join Battlegrounds (Classic)..."))
											{
												if (EventManager.IsAction(Action, "Change Profile Settings..."))
												{
													frmProfileEventSave.Event.ChangeSettingsCombatMode = ChangeSettingsCombatMode;
													frmProfileEventSave.Event.ChangeSettingsWaypointMode = ChangeSettingsWaypointMode;
													frmProfileEventSave.Event.ChangeSettingsFollowFleeingTarget = ChangeSettingsModeFollowFleeingTarget;
													frmProfileEventSave.Event.ChangeSettingsModeMesh = ChangeSettingsModeMesh;
													frmProfileEventSave.Event.ChangeSettingsGroundMount = ChangeSettingsGroundMount;
													frmProfileEventSave.Event.ChangeSettingsFlightMount = ChangeSettingsFlightMount;
													frmProfileEventSave.Event.ChangeSettingsLoot = ChangeSettingsLoot;
													frmProfileEventSave.Event.ChangeSettingsMining = ChangeSettingsLootMining;
													frmProfileEventSave.Event.ChangeSettingsHerbalism = ChangeSettingsLootHerbalism;
													frmProfileEventSave.Event.ChangeSettingsSkinning = ChangeSettingsLootSkinning;
													frmProfileEventSave.Event.ChangeSettingsGatherMobs = ChangeSettingsLootGatherMobs;
													List<string> list6 = new List<string>();
													if (ChangeSettingsLootQuestItems.Length > 0)
													{
														foreach (string text3 in ChangeSettingsLootQuestItems.Split(new char[]
														{
															'\n'
														}).ToList<string>())
														{
															string text4 = text3.Trim().Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
															if (text4.Length != 0)
															{
																list6.Add(text4);
															}
														}
													}
													frmProfileEventSave.Event.ChangeSettingsQuestItems = list6;
													frmProfileEventSave.Event.ChangeSettingsDistanceLoot = Convert.ToInt32(ChangeSettingsLootDistance);
													frmProfileEventSave.Event.ChangeSettingsDistancePath = Convert.ToInt32(ChangeSettingsLootMaxPathDistance);
													frmProfileEventSave.Event.ChangeSettingsDistanceLootGather = Convert.ToInt32(ChangeSettingsLootGatherDistance);
													frmProfileEventSave.Event.ChangeSettingsDistanceAvoidElites = Convert.ToInt32(ChangeSettingsLootAvoidElitesDistance);
													frmProfileEventSave.Event.ChangeSettingsDistanceWaypoint = Convert.ToInt32(ChangeSettingsDistancesWaypoint);
													frmProfileEventSave.Event.ChangeSettingsDistanceLocation = Convert.ToInt32(ChangeSettingsDistancesLocation);
													frmProfileEventSave.Event.ChangeSettingsDistanceMobGroup = Convert.ToInt32(ChangeSettingsDistancesMobGroup);
													double changeSettingsDistanceIsReachable = -1.0;
													if (double.TryParse(ChangeSettingsDistancesIsReachable.Replace(".", ","), out changeSettingsDistanceIsReachable))
													{
														frmProfileEventSave.Event.ChangeSettingsDistanceIsReachable = changeSettingsDistanceIsReachable;
													}
													List<string> list7 = new List<string>();
													if (ChangeSettingsAttackableMobs.Length > 0)
													{
														foreach (string text5 in ChangeSettingsAttackableMobs.Split(new char[]
														{
															'\n'
														}).ToList<string>())
														{
															string text6 = text5.Trim().Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
															if (text6.Length != 0)
															{
																list7.Add(text6);
															}
														}
													}
													frmProfileEventSave.Event.ChangeSettingsAttackableMobs = list7;
												}
											}
											else
											{
												frmProfileEventSave.Event.BattlegroundsClassicWarsongGulch = BattlegroundsClassicWarsongGulch;
												frmProfileEventSave.Event.BattlegroundsClassicArathiBasin = BattlegroundsClassicArathiBasin;
												frmProfileEventSave.Event.BattlegroundsClassicAlteracValley = BattlegroundsClassicAlteracValley;
												frmProfileEventSave.Event.BattlegroundsClassicEyeOfTheStorm = BattlegroundsClassicEyeOfTheStorm;
												frmProfileEventSave.Event.BattlegroundsClassicStrandOfTheAncients = BattlegroundsClassicStrandOfTheAncients;
												if (BattlegroundsClassicWarsongGulch)
												{
													frmProfileEventSave.Event.BattlegroundsClassicWarsongGulchProfile = BattlegroundsClassicWarsongGulchProfile;
												}
												if (BattlegroundsClassicArathiBasin)
												{
													frmProfileEventSave.Event.BattlegroundsClassicArathiBasinProfile = BattlegroundsClassicArathiBasinProfile;
												}
												if (BattlegroundsClassicAlteracValley)
												{
													frmProfileEventSave.Event.BattlegroundsClassicAlteracValleyProfile = BattlegroundsClassicAlteracValleyProfile;
												}
												if (BattlegroundsClassicEyeOfTheStorm)
												{
													frmProfileEventSave.Event.BattlegroundsClassicEyeOfTheStormProfile = BattlegroundsClassicEyeOfTheStormProfile;
												}
												if (BattlegroundsClassicStrandOfTheAncients)
												{
													frmProfileEventSave.Event.BattlegroundsClassicStrandOfTheAncientsProfile = BattlegroundsClassicStrandOfTheAncientsProfile;
												}
												frmProfileEventSave.Event.BattlegroundsWaitUntilInvitation = BattlegroundsClassicWaitUntilInvitation;
											}
										}
										else
										{
											frmProfileEventSave.Event.ExecuteLUA = ExecuteLUA.Replace("\n", "#").Replace("\t", "").Replace("  ", "").Trim();
											frmProfileEventSave.Event.ExecuteLUAWhileWalk = ExecuteLUAWhileWalk;
										}
									}
									else
									{
										frmProfileEventSave.Event.UseHearthstoneProfile = UseHearthstoneProfile;
									}
								}
								else
								{
									frmProfileEventSave.Event.WalkSensOutdoor = float.Parse(WalkSensOutdoor, CultureInfo.InvariantCulture);
									frmProfileEventSave.Event.WalkSensIndoor = float.Parse(WalkSensIndoor, CultureInfo.InvariantCulture);
								}
							}
							else
							{
								frmProfileEventSave.Event.LoadRotation = LoadRotation;
							}
						}
						else
						{
							frmProfileEventSave.Event.LoadProfile = LoadProfile;
						}
					}
					else if (Wait)
					{
						frmProfileEventSave.Event.Wait = Wait;
						int num3 = Convert.ToInt32(WaitInSeconds);
						frmProfileEventSave.Event.WaitInSeconds = num3;
						frmProfileEventSave.Event.WaitInMS = num3 * 1000;
						frmProfileEventSave.Event.WaitIgnoreAttackers = WaitIgnoreAttackers;
						frmProfileEventSave.Event.WaitForNameOrID = "";
					}
					else if (WaitFor)
					{
						frmProfileEventSave.Event.WaitFor = WaitFor;
						frmProfileEventSave.Event.WaitForNameOrID = WaitForNameOrID;
						int num4 = Convert.ToInt32(WaitForMaxSeconds);
						frmProfileEventSave.Event.WaitForMaxSeconds = num4;
						frmProfileEventSave.Event.WaitForMaxSecondsInMS = num4 * 1000;
						frmProfileEventSave.Event.WaitForGateOrDoor = WaitForGate;
						frmProfileEventSave.Event.WaitInSeconds = 0;
						frmProfileEventSave.Event.WaitInMS = 0;
					}
					object @lock = frmProfile._lock;
					lock (@lock)
					{
						frmProfile.RecordedEvents.Add(frmProfileEventSave.Event);
						if (this.Mode == "Edit" && frmProfile.RecordedEvents.Count > 1)
						{
							frmProfile.RecordedEvents.Swap(frmProfile.RecordedEvents.Count - 1, index);
						}
					}
					int num5 = 1;
					List<string> eventNames = ObjectManager.GetEventNames(frmProfileEventSave.Crd, true);
					if (eventNames.Count > 0)
					{
						foreach (string str in eventNames)
						{
							Tools.Control(new string[]
							{
								num5.ToString(),
								num5.ToString() + "|" + str
							}, "listEvents", "frmProfile", true, false, false, false, 0);
							num5++;
						}
					}
					if (num5 > 1)
					{
						num5--;
					}
					int num6 = 0;
					using (List<Vector3>.Enumerator enumerator2 = frmProfile.RecordedWaypoints.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if (enumerator2.Current == frmProfileEventSave.Crd)
							{
								break;
							}
							num6++;
						}
					}
					frmProfile.UpdateListWaypoints(num6);
					frmProfile.UpdateAndShowOverlayGoals();
					Tools.HideForm("frmProfileEvent");
				}
				base.Close();
			}
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00666D70 File Offset: 0x00664F70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x006D966C File Offset: 0x006D786C
		public static int GenerateID
		{
			get
			{
				bool flag = false;
				int num = 0;
				for (;;)
				{
					flag = false;
					num = frmProfileEventSave.Rnd.Next(10000, 99999);
					if (frmProfile.RecordedEvents.Count > 0)
					{
						using (List<Events>.Enumerator enumerator = frmProfile.RecordedEvents.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.ID == num)
								{
									flag = true;
									break;
								}
							}
						}
					}
					if (!flag)
					{
						break;
					}
					Thread.Sleep(5);
				}
				return num;
			}
		}

		// Token: 0x040006BB RID: 1723
		private object[] Args;

		// Token: 0x040006BC RID: 1724
		private string Mode = "";

		// Token: 0x040006BD RID: 1725
		private static Vector3 Crd;

		// Token: 0x040006BE RID: 1726
		private static string EventName = "";

		// Token: 0x040006BF RID: 1727
		private static int EventID = 0;

		// Token: 0x040006C0 RID: 1728
		private static Random Rnd = new Random();

		// Token: 0x040006C1 RID: 1729
		private static Events Event;
	}
}
