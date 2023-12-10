using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
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
	// Token: 0x02000088 RID: 136
	public partial class frmProfileEvent : Form
	{
		// Token: 0x06000D40 RID: 3392 RVA: 0x006AA4EC File Offset: 0x006A86EC
		public frmProfileEvent(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x006AA514 File Offset: 0x006A8714
		private void frmProfileEvent_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Event Manager", true, true, true, true, false, false);
			this.SetWindowSizeAndPosition();
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x006AA538 File Offset: 0x006A8738
		private void SetWindowSizeAndPosition()
		{
			if (Jack.Core.Settings.WindowProfileEventSize.Width != 0 && Jack.Core.Settings.WindowProfileEventSize.Height != 0)
			{
				base.Width = Jack.Core.Settings.WindowProfileEventSize.Width;
				base.Height = Jack.Core.Settings.WindowProfileEventSize.Height;
			}
			CustomUI.SetLocation(this, "frmProfile");
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x006AA588 File Offset: 0x006A8788
		private void listWaypoints_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns("");
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x006AA5A0 File Offset: 0x006A87A0
		private void CenterListViewColumns(string Mode = "")
		{
			Tools.ColorListViewHeader(ref this.listWaypoints, null);
			Tools.CenterListViewColumns(this.listWaypoints, new int[]
			{
				40
			});
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmProfileEvent_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x006AA5D0 File Offset: 0x006A87D0
		private void selectAction_DropDown(object sender, EventArgs e)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x006AA5EC File Offset: 0x006A87EC
		private void frmProfileEvent_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.ResetControls();
				this.LoadSettings();
				frmProfileEvent.AutoSwitchTab = true;
			}
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x006AA61C File Offset: 0x006A881C
		private void ResetControls()
		{
			this.Tab(this.tabInteractWith, true);
			this.Tab(this.tabWait, true);
			this.Tab(this.tabLoadProfile, true);
			this.Tab(this.tabLoadRotation, true);
			this.Tab(this.tabRecorder, true);
			this.Tab(this.tabCastSpell, true);
			this.Tab(this.tabWalkSens, true);
			this.Tab(this.tabUseHearthstone, true);
			this.Tab(this.tabFishing, true);
			this.Tab(this.tabUseTransport, true);
			this.Tab(this.tabExecuteLUA, true);
			this.Tab(this.tabBattlegroundClassic, true);
			this.Tab(this.tabChangeProfileSettings, true);
			frmProfileEvent.RecordedEventWaypoints.Clear();
			frmProfileEvent.RecordedWhitelist.Clear();
			frmProfileEvent.RecordedBuylist.Clear();
			frmProfileEvent.RecordedSendlist.Clear();
			frmProfileEvent.RecordedFishingItemlist.Clear();
			this.selectAction.Items.Clear();
			this.selectAction.Items.Add("--- Select Action ---");
			this.selectAction.Items.Add("Add Vendor, Mailbox and More...");
			this.selectAction.Items.Add("Interact with...");
			this.selectAction.Items.Add("Load Profile...");
			this.selectAction.Items.Add("Load Rotation...");
			this.selectAction.Items.Add("Wait...");
			this.selectAction.Items.Add("Cast Spell...");
			this.selectAction.Items.Add("Change Walk Sensitivity...");
			this.selectAction.Items.Add("Use Hearthstone...");
			this.selectAction.Items.Add("Start Fishing...");
			this.selectAction.Items.Add("Use Transport...");
			this.selectAction.Items.Add("Execute LUA...");
			this.selectAction.Items.Add("Join Battlegrounds (Classic)...");
			this.selectAction.Items.Add("Change Profile Settings...");
			this.selectAction.Items.Add("Go through Portal");
			this.selectAction.Items.Add("Start Combat");
			if (!_globals.ModuleDungeon)
			{
				this.selectAction.Items.Add("Enter/Leave Dungeon (Requires Dungeon Module)");
				this.selectAction.Items.Add("Reset Dungeons (Requires Dungeon Module)");
			}
			else
			{
				this.selectAction.Items.Add("Enter/Leave Dungeon");
				this.selectAction.Items.Add("Reset Dungeons");
			}
			this.selectAction.Items.Add("Stop walking");
			this.selectAction.Items.Add("Start walking");
			this.selectAction.Items.Add("Jump");
			this.selectAction.Items.Add("Jump while walk");
			this.selectAction.Items.Add("Walk while Jump");
			this.selectAction.Items.Add("Start Swimming");
			this.selectAction.Items.Add("Stop Swimming");
			this.selectAction.Items.Add("Loot");
			this.selectAction.Items.Add("Facing next Waypoint");
			this.selectAction.Items.Add("Stop");
			this.checkCondition1.Checked = false;
			this.selectCondition1.SelectedIndex = 0;
			this.selectCondition1Compare.SelectedIndex = 0;
			this.txtCondition1Value.Text = "";
			this.txtCondition1Value2.Visible = false;
			this.txtCondition1Value.Width = this.selectCondition1Compare.Width;
			this.checkCondition2.Checked = false;
			this.selectCondition2.SelectedIndex = 0;
			this.selectCondition2Compare.SelectedIndex = 0;
			this.txtCondition2Value.Text = "";
			this.txtCondition2Value2.Visible = false;
			this.txtCondition2Value.Width = this.selectCondition2Compare.Width;
			this.selectConditionAndOr1.SelectedIndex = 0;
			this.checkSettingsExecuteAlways.Checked = false;
			this.checkSettingsExecuteOnce.Checked = true;
			this.selectSettingsFaction.SelectedIndex = 0;
			if (this.selectSettingsRace.Items.Count == 0)
			{
				this.selectSettingsRace.Items.Add("All");
				foreach (object obj in Enum.GetValues(typeof(Constants.PlayerRace)))
				{
					if (obj.ToString() != "NA")
					{
						this.selectSettingsRace.Items.Add(obj.ToString());
					}
				}
			}
			this.selectSettingsRace.SelectedIndex = 0;
			this.txtInteractNameOrID.Text = "";
			this.NoCheck = true;
			this.checkInteractFurthest.Checked = false;
			this.checkInteractClosest.Checked = true;
			this.checkInteractAttack.Checked = false;
			this.NoCheck = false;
			this.txtInteractNameOrID.Enabled = true;
			this.checkWait.Checked = false;
			this.txtWaitSeconds.Text = "";
			this.checkWaitIgnoreAttackers.Checked = false;
			this.checkWaitFor.Checked = false;
			this.txtWaitForNameOrID.Text = "";
			this.txtWaitForMaxSeconds.Text = "";
			this.checkWaitForGate.Checked = false;
			Tools.ProfilesToSelection("selectLoadProfile", "frmProfileEvent", "", true, false);
			if (this.selectLoadProfile.Items.Count > 0)
			{
				this.selectLoadProfile.SelectedIndex = 0;
			}
			Tools.ProfilesToSelection("selectLoadRotation", "frmProfileEvent", "", true, true);
			if (this.selectLoadRotation.Items.Count > 0)
			{
				this.selectLoadRotation.SelectedIndex = 0;
			}
			this.NoCheck = true;
			this.selectRecorderRouteType.SelectedIndex = 0;
			this.NoCheck = false;
			this.selectRecorderCombatMode.SelectedIndex = 0;
			this.listWaypoints.Items.Clear();
			this.panelRecorderInfo.Visible = true;
			this.btnRecordStart.Image = Resources.play_32;
			this.btnRecordStart.FillColor = Color.FromArgb(23, 39, 52);
			frmProfileEvent.LandingField = Vector3.Zero;
			this.lblRecorderLandingFieldLocation.Text = "No Landing Field set.";
			this.lblRecorderLandingFieldLocation.ForeColor = Color.DimGray;
			this.btnRecorderSetLandingField.Text = "Set Landing Field";
			this.btnRecorderSetLandingField.Enabled = true;
			this.lblRecorderLandingField.Enabled = true;
			this.checkRecorderVendorSellGreys.Checked = false;
			this.checkRecorderVendorSellWhites.Checked = false;
			this.checkRecorderVendorSellGreens.Checked = false;
			this.checkRecorderVendorSellBlues.Checked = false;
			this.checkRecorderVendorCanRepair.Checked = false;
			this.checkRecorderVendorMount.Checked = false;
			this.btnRecorderVendorWhitelist.Text = "Whitelist";
			this.btnRecorderVendorBuylist.Text = "Buylist";
			this.selectRecorderFlightMasterFlightPoints.Items.Clear();
			foreach (string item in ObjectManager.GetFlightPointNames)
			{
				this.selectRecorderFlightMasterFlightPoints.Items.Add(item);
			}
			if (this.selectRecorderFlightMasterFlightPoints.Items.Count > 0)
			{
				this.selectRecorderFlightMasterFlightPoints.SelectedIndex = 0;
			}
			Tools.ProfilesToSelection("selectRecorderFlightMasterProfiles", "frmProfileEvent", "", true, false);
			if (this.selectRecorderFlightMasterProfiles.Items.Count > 0)
			{
				this.selectRecorderFlightMasterProfiles.SelectedIndex = 0;
			}
			this.checkRecorderMailboxSendGreys.Checked = false;
			this.checkRecorderMailboxSendWhites.Checked = false;
			this.checkRecorderMailboxSendGreens.Checked = false;
			this.checkRecorderMailboxSendBlues.Checked = false;
			this.checkRecorderMailboxSendPurples.Checked = false;
			this.txtRecorderMailboxReceiver.Text = "";
			this.btnRecorderMailboxSendlist.Text = "Sendlist";
			this.txtCastSpellRadius.Text = "0";
			this.checkCastSpellNoRadiusCheck.Checked = false;
			this.checkCastSpellTarget.Checked = false;
			this.txtCastSpellTargetNameOrID.Text = "";
			this.checkCastSpellTargetFurthest.Checked = false;
			this.checkCastSpellTargetClosest.Checked = true;
			this.trackWalkSensOutdoor.Value = 20;
			this.lblWalkSensOutdoorData.Text = "2.0";
			this.trackWalkSensIndoor.Value = 7;
			this.lblWalkSensIndoorData.Text = "0.7";
			Tools.ProfilesToSelection("selectUseHearthstoneLoadProfile", "frmProfileEvent", "", true, false);
			if (this.selectUseHearthstoneLoadProfile.Items.Count > 0)
			{
				this.selectUseHearthstoneLoadProfile.SelectedIndex = 0;
			}
			this.checkFishingBait.Checked = false;
			this.checkFishingOptionsRandomDelay.Checked = true;
			this.checkFishingFacing.Checked = false;
			this.lblFishingFacingDirection.Text = "<No Alignment set>";
			this.lblFishingFacingDirection.ForeColor = Color.White;
			this.checkFishingCondition.Checked = false;
			this.checkFishingConditionSkillLevel.Checked = false;
			this.txtFishingConditionSkillLevel.Text = "";
			this.checkFishingConditionItemlist.Checked = false;
			this.btnFishingConditionItemlist.Text = "Itemlist";
			this.checkFishingConditionFullBags.Checked = false;
			Tools.ProfilesToSelection("selectUseTransportLoadProfile", "frmProfileEvent", "", true, false);
			if (this.selectUseTransportLoadProfile.Items.Count > 0)
			{
				this.selectUseTransportLoadProfile.SelectedIndex = 0;
			}
			this.selectUseTransportTurn.SelectedIndex = 0;
			if (this.selectExecuteLUAExamples.Items.Count == 0)
			{
				frmProfileEvent.ExecuteLUAExamples.Add("Examples", "");
				frmProfileEvent.ExecuteLUAExamples.Add("Use Item by ID", "/use item:12345");
				frmProfileEvent.ExecuteLUAExamples.Add("Use Item by Name", "/use Hearthstone");
				foreach (KeyValuePair<string, string> keyValuePair in frmProfileEvent.ExecuteLUAExamples)
				{
					this.selectExecuteLUAExamples.Items.Add(keyValuePair.Key);
				}
			}
			this.selectExecuteLUAExamples.SelectedIndex = 0;
			this.txtExecuteLUA.Text = "";
			this.checkExecuteLUAWhileWalk.Checked = false;
			this.checkBattlegroundClassicWarsongGulch.Checked = false;
			this.checkBattlegroundClassicArathiBasin.Checked = false;
			this.checkBattlegroundClassicAlteracValley.Checked = false;
			this.checkBattlegroundClassicEyeOfTheStorm.Checked = false;
			this.checkBattlegroundClassicStrandOfTheAncients.Checked = false;
			Tools.ProfilesToSelection("selectBattlegroundClassicWarsongGulch", "frmProfileEvent", "", true, false);
			if (this.selectBattlegroundClassicWarsongGulch.Items.Count > 0)
			{
				this.selectBattlegroundClassicWarsongGulch.SelectedIndex = 0;
			}
			Tools.ProfilesToSelection("selectBattlegroundClassicArathiBasin", "frmProfileEvent", "", true, false);
			if (this.selectBattlegroundClassicArathiBasin.Items.Count > 0)
			{
				this.selectBattlegroundClassicArathiBasin.SelectedIndex = 0;
			}
			Tools.ProfilesToSelection("selectBattlegroundClassicAlteracValley", "frmProfileEvent", "", true, false);
			if (this.selectBattlegroundClassicAlteracValley.Items.Count > 0)
			{
				this.selectBattlegroundClassicAlteracValley.SelectedIndex = 0;
			}
			Tools.ProfilesToSelection("selectBattlegroundClassicEyeOfTheStorm", "frmProfileEvent", "", true, false);
			if (this.selectBattlegroundClassicEyeOfTheStorm.Items.Count > 0)
			{
				this.selectBattlegroundClassicEyeOfTheStorm.SelectedIndex = 0;
			}
			Tools.ProfilesToSelection("selectBattlegroundClassicStrandOfTheAncients", "frmProfileEvent", "", true, false);
			if (this.selectBattlegroundClassicStrandOfTheAncients.Items.Count > 0)
			{
				this.selectBattlegroundClassicStrandOfTheAncients.SelectedIndex = 0;
			}
			this.checkBattlegroundClassicWaitUntilInvitation.Checked = false;
			this.selectSettingsCombatMode.SelectedIndex = 0;
			this.selectSettingsWaypointMode.SelectedIndex = 0;
			this.checkSettingsModeFollowFleeingTarget.Checked = false;
			this.checkSettingsModeMesh.Checked = true;
			this.checkSettingsGroundMount.Checked = false;
			this.checkSettingsFlightMount.Checked = false;
			this.NoCheck = true;
			this.checkSettingsLootSkinning.Checked = false;
			this.checkSettingsLootHerbalism.Checked = false;
			this.checkSettingsLootMining.Checked = false;
			this.checkSettingsLootGatherMobs.Checked = false;
			this.txtSettingsLootQuestItems.Text = "";
			this.NoCheck = false;
			this.txtSettingsLootDistance.Text = "40";
			this.txtSettingsLootMaxPathDistance.Text = "100";
			this.txtSettingsLootGatherDistance.Text = "4";
			this.txtSettingsLootAvoidElitesDistance.Text = "40";
			if (_globals.ModuleGather)
			{
				this.checkSettingsLootMining.ForeColor = Color.LimeGreen;
				this.checkSettingsLootHerbalism.ForeColor = Color.LimeGreen;
				this.checkSettingsLootSkinning.ForeColor = Color.LimeGreen;
				this.checkSettingsLootGatherMobs.ForeColor = Color.LimeGreen;
				this.txtSettingsLootQuestItems.BorderColor = Color.LimeGreen;
			}
			else
			{
				this.checkSettingsLootMining.ForeColor = Color.DimGray;
				this.checkSettingsLootHerbalism.ForeColor = Color.DimGray;
				this.checkSettingsLootSkinning.ForeColor = Color.DimGray;
				this.checkSettingsLootGatherMobs.ForeColor = Color.DimGray;
				this.txtSettingsLootQuestItems.BorderColor = Color.DimGray;
			}
			this.txtSettingsDistancesWaypoint.Text = "25";
			this.txtSettingsDistancesLocation.Text = "40";
			this.txtSettingsDistancesMobGroup.Text = "15";
			this.txtSettingsDistancesIsReachable.Text = "4.5";
			this.richSettingsMobs.Text = "";
			this.selectAction.SelectedIndex = 0;
			this.EnableRecorder(false);
			this.Tab(this.tabInteractWith, false);
			this.Tab(this.tabWait, false);
			this.Tab(this.tabLoadProfile, false);
			this.Tab(this.tabLoadRotation, false);
			this.Tab(this.tabRecorder, false);
			this.Tab(this.tabCastSpell, false);
			this.Tab(this.tabWalkSens, false);
			this.Tab(this.tabUseHearthstone, false);
			this.Tab(this.tabFishing, false);
			this.Tab(this.tabUseTransport, false);
			this.Tab(this.tabExecuteLUA, false);
			this.Tab(this.tabBattlegroundClassic, false);
			this.Tab(this.tabChangeProfileSettings, false);
			this.LoadAroundMe();
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x006AB4C0 File Offset: 0x006A96C0
		private void LoadSettings()
		{
			_globals.MyHandleProfileEvent = this.method_0();
			new Thread(new ThreadStart(this.GetTarget))
			{
				IsBackground = true
			}.Start();
			this.NoCheck = true;
			this.LoadEvent();
			this.NoCheck = false;
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x006AB50C File Offset: 0x006A970C
		private void LoadEvent()
		{
			this.CenterListViewColumns("");
			if (frmProfileEvent.Mode == "Edit" && frmProfileEvent.Event != null)
			{
				if (frmProfileEvent.Event.Route.Count > 0)
				{
					foreach (Vector3 item in frmProfileEvent.Event.Route)
					{
						frmProfileEvent.RecordedEventWaypoints.Add(item);
					}
					this.panelRecorderInfo.Visible = false;
				}
				if (frmProfileEvent.Event.VendorWhitelist.Count > 0)
				{
					foreach (string item2 in frmProfileEvent.Event.VendorWhitelist)
					{
						frmProfileEvent.RecordedWhitelist.Add(item2);
					}
				}
				if (frmProfileEvent.Event.VendorBuylist.Count > 0)
				{
					foreach (string item3 in frmProfileEvent.Event.VendorBuylist)
					{
						frmProfileEvent.RecordedBuylist.Add(item3);
					}
				}
				if (frmProfileEvent.Event.RecorderMailboxSendlist.Count > 0)
				{
					foreach (string item4 in frmProfileEvent.Event.RecorderMailboxSendlist)
					{
						frmProfileEvent.RecordedSendlist.Add(item4);
					}
				}
				if (frmProfileEvent.Event.FishingConditionItemList.Count > 0)
				{
					foreach (string item5 in frmProfileEvent.Event.FishingConditionItemList)
					{
						frmProfileEvent.RecordedFishingItemlist.Add(item5);
					}
				}
				this.selectAction.SelectedIndex = this.selectAction.FindStringExact(frmProfileEvent.Event.Action);
				if (this.selectAction.SelectedIndex == -1)
				{
					this.selectAction.SelectedIndex = this.selectAction.FindString(frmProfileEvent.Event.Action);
				}
				if (this.selectAction.SelectedIndex == -1)
				{
					this.selectAction.Items.Add(frmProfileEvent.Event.Action);
					this.selectAction.SelectedIndex = this.selectAction.Items.Count - 1;
				}
				this.checkCondition1.Checked = frmProfileEvent.Event.HasCondition1;
				this.checkCondition2.Checked = frmProfileEvent.Event.HasCondition2;
				if (!frmProfileEvent.Event.SettingsExecuteOnce)
				{
					if (frmProfileEvent.Event.SettingsExecuteAlways)
					{
						this.checkSettingsExecuteAlways.Checked = true;
					}
				}
				else
				{
					this.checkSettingsExecuteOnce.Checked = true;
				}
				this.selectSettingsFaction.SelectedIndex = this.selectSettingsFaction.FindStringExact(frmProfileEvent.Event.Faction);
				this.selectSettingsRace.SelectedIndex = this.selectSettingsRace.FindStringExact(frmProfileEvent.Event.Race);
			}
			if (frmProfileEvent.RecordedEventWaypoints.Count > 0)
			{
				frmProfileEvent.UpdateListBoxWaypoints();
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x006AB870 File Offset: 0x006A9A70
		private void LoadSpells()
		{
			while (!base.IsHandleCreated)
			{
				Thread.Sleep(100);
			}
			Tools.Control("clear", "selectCastSpell", "frmProfileEvent", true, false, false, false, 0);
			if (!_globals.Ready)
			{
				Tools.Control("Please enter World first.", "selectCastSpell", "frmProfileEvent", false, false, false, false, 0);
				Tools.ControlSelect("selectCastSpell", "frmProfileEvent", "", false);
				return;
			}
			Tools.Control("", "btnCastSpellReload", "frmProfileEvent", false, false, false, false, 0);
			string selection = "";
			if (frmProfileEvent.Mode == "Edit" && EventManager.IsAction(frmProfileEvent.Event.Action, "Cast Spell..."))
			{
				selection = " [" + frmProfileEvent.Event.CastSpellID.ToString() + "]";
			}
			Tools.SpellsToSelectionField("selectCastSpell", "frmProfileEvent", selection, true);
			Tools.Control("", "btnCastSpellReload", "frmProfileEvent", true, false, false, false, 0);
			Tools.Control("", "selectCastSpell", "frmProfileEvent", true, false, false, false, 0);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x006AB98C File Offset: 0x006A9B8C
		private void selectAction_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.selectAction.Text.ToString();
			if (text.Length > 0)
			{
				this.EnableExecution(false);
				this.EnableInteract(false);
				this.EnableWait(false);
				this.EnableProfile(false);
				this.EnableRotation(false);
				this.EnableRecorder(false);
				this.EnableCastSpell(false);
				this.EnableWalkSens(false);
				this.EnableUseHearthstone(false);
				this.EnableFishing(false);
				this.EnableUseTransport(false);
				this.EnableExecuteLUA(false);
				this.EnableBattlegroundsClassic(false);
				this.EnableChangeProfileSettings(false);
				TabPage tabPage;
				if (!EventManager.IsAction(text, "Add Route..."))
				{
					if (EventManager.IsAction(text, "Interact with..."))
					{
						tabPage = this.tabInteractWith;
						this.EnableExecution(true);
						this.EnableInteract(true);
					}
					else if (!EventManager.IsAction(text, "Wait..."))
					{
						if (!EventManager.IsAction(text, "Load Profile..."))
						{
							if (EventManager.IsAction(text, "Load Rotation..."))
							{
								tabPage = this.tabLoadRotation;
								this.EnableExecution(true);
								this.EnableRotation(true);
							}
							else if (EventManager.IsAction(text, "Cast Spell..."))
							{
								tabPage = this.tabCastSpell;
								this.EnableExecution(true);
								this.EnableCastSpell(true);
							}
							else if (!EventManager.IsAction(text, "Change Walk Sensitivity..."))
							{
								if (!EventManager.IsAction(text, "Use Hearthstone..."))
								{
									if (!EventManager.IsAction(text, "Start Fishing..."))
									{
										if (EventManager.IsAction(text, "Use Transport..."))
										{
											tabPage = this.tabUseTransport;
											this.EnableExecution(true);
											this.EnableUseTransport(true);
										}
										else if (!EventManager.IsAction(text, "Execute LUA..."))
										{
											if (!EventManager.IsAction(text, "Join Battlegrounds (Classic)..."))
											{
												if (EventManager.IsAction(text, "Change Profile Settings..."))
												{
													tabPage = this.tabChangeProfileSettings;
													this.EnableExecution(true);
													this.EnableChangeProfileSettings(true);
												}
												else
												{
													tabPage = null;
													if (!this.ModuleRequired(text))
													{
														this.EnableExecution(true);
													}
													else
													{
														this.selectAction.SelectedIndex = 0;
													}
												}
											}
											else
											{
												tabPage = this.tabBattlegroundClassic;
												this.EnableExecution(true);
												this.EnableBattlegroundsClassic(true);
											}
										}
										else
										{
											tabPage = this.tabExecuteLUA;
											this.EnableExecution(true);
											this.EnableExecuteLUA(true);
										}
									}
									else
									{
										tabPage = this.tabFishing;
										this.EnableExecution(true);
										this.EnableFishing(true);
									}
								}
								else
								{
									tabPage = this.tabUseHearthstone;
									this.EnableExecution(true);
									this.EnableUseHearthstone(true);
								}
							}
							else
							{
								tabPage = this.tabWalkSens;
								this.EnableExecution(true);
								this.EnableWalkSens(true);
							}
						}
						else
						{
							tabPage = this.tabLoadProfile;
							this.EnableExecution(true);
							this.EnableProfile(true);
						}
					}
					else
					{
						tabPage = this.tabWait;
						this.EnableExecution(true);
						this.EnableWait(true);
					}
				}
				else
				{
					tabPage = this.tabRecorder;
					this.EnableExecution(true);
					this.EnableRecorder(true);
				}
				if (frmProfileEvent.AutoSwitchTab && tabPage != null)
				{
					this.tabs.SelectedTab = tabPage;
				}
			}
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x006ABC54 File Offset: 0x006A9E54
		private bool ModuleRequired(string Selection)
		{
			bool flag = false;
			if (!_globals.ModuleDungeon)
			{
				if (!Selection.Contains("Enter/Leave Dungeon"))
				{
					if (Selection.Contains("Reset Dungeons"))
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
			}
			if (flag)
			{
				CustomUI.DialogModule(base.Name);
			}
			return flag;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x006ABC9C File Offset: 0x006A9E9C
		private void EnableExecution(bool Status)
		{
			this.checkSettingsExecuteOnce.Enabled = Status;
			this.checkSettingsExecuteAlways.Enabled = Status;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x006ABCC4 File Offset: 0x006A9EC4
		private void EnableInteract(bool Status)
		{
			this.Tab(this.tabInteractWith, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				this.txtInteractNameOrID.Text = frmProfileEvent.Event.InteractNameOrID;
				this.checkInteractClosest.Checked = frmProfileEvent.Event.InteractWithClosest;
				this.checkInteractFurthest.Checked = frmProfileEvent.Event.InteractWithFurthest;
				this.checkInteractAttack.Checked = frmProfileEvent.Event.InteractWithAttack;
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x006ABD48 File Offset: 0x006A9F48
		private void EnableWait(bool Status)
		{
			this.Tab(this.tabWait, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				if (frmProfileEvent.Event.Wait)
				{
					this.checkWait.Checked = true;
					this.txtWaitSeconds.Text = frmProfileEvent.Event.WaitInSeconds.ToString();
					this.checkWaitIgnoreAttackers.Checked = frmProfileEvent.Event.WaitIgnoreAttackers;
					return;
				}
				if (frmProfileEvent.Event.WaitFor)
				{
					this.checkWaitFor.Checked = true;
					this.txtWaitForNameOrID.Text = frmProfileEvent.Event.WaitForNameOrID.ToString();
					this.txtWaitForMaxSeconds.Text = frmProfileEvent.Event.WaitForMaxSeconds.ToString();
					this.checkWaitForGate.Checked = frmProfileEvent.Event.WaitForGateOrDoor;
				}
			}
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x006ABE30 File Offset: 0x006AA030
		private void EnableProfile(bool Status)
		{
			this.Tab(this.tabLoadProfile, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				string loadProfile = frmProfileEvent.Event.LoadProfile;
				if (File.Exists(_globals.JackProfiles + "\\" + loadProfile + ".json"))
				{
					this.selectLoadProfile.SelectedIndex = this.selectLoadProfile.FindStringExact(loadProfile);
				}
			}
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x006ABE9C File Offset: 0x006AA09C
		private void EnableRotation(bool Status)
		{
			this.Tab(this.tabLoadRotation, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				string loadRotation = frmProfileEvent.Event.LoadRotation;
				if (File.Exists(_globals.JackRotations + "\\" + loadRotation + ".json"))
				{
					this.selectLoadRotation.SelectedIndex = this.selectLoadRotation.FindStringExact(loadRotation);
				}
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x006ABF08 File Offset: 0x006AA108
		private void EnableRecorder(bool Status)
		{
			this.Tab(this.tabRecorder, Status);
			if (Status)
			{
				this.selectRecorderRouteType.SelectedIndex = 0;
				this.selectRecorderCombatMode.SelectedIndex = 0;
				this.selectRecorderFlightMasterFlightPoints.SelectedIndex = 0;
				this.EnableSelectedRouteType(false);
			}
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x006ABF50 File Offset: 0x006AA150
		private void EnableCastSpell(bool Status)
		{
			this.Tab(this.tabCastSpell, Status);
			if (Status)
			{
				new Thread(new ThreadStart(this.LoadSpells))
				{
					IsBackground = true
				}.Start();
				if (frmProfileEvent.Mode == "Edit")
				{
					this.checkCastSpellWhileWalk.Checked = frmProfileEvent.Event.CastSpellWhileWalk;
					this.checkCastSpellUntilNoAttackers.Checked = frmProfileEvent.Event.CastSpellUntilNoAttackers;
					this.txtCastSpellRadius.Text = frmProfileEvent.Event.CastSpellRadius.ToString();
					this.checkCastSpellNoRadiusCheck.Checked = frmProfileEvent.Event.CastSpellNoRadiusCheck;
					this.checkCastSpellGroundAOE.Checked = frmProfileEvent.Event.CastSpellGroundAOE;
					this.checkCastSpellTarget.Checked = frmProfileEvent.Event.CastSpellOnTarget;
					this.txtCastSpellTargetNameOrID.Text = frmProfileEvent.Event.CastSpellTargetNameOrID;
					this.checkCastSpellTargetClosest.Checked = frmProfileEvent.Event.CastSpellTargetClosest;
					this.checkCastSpellTargetFurthest.Checked = frmProfileEvent.Event.CastSpellTargetFurthest;
				}
			}
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x006AC068 File Offset: 0x006AA268
		private void EnableWalkSens(bool Status)
		{
			this.Tab(this.tabWalkSens, Status);
			this.trackWalkSensOutdoor.Value = 20;
			this.lblWalkSensOutdoorData.Text = "2.0";
			this.trackWalkSensIndoor.Value = 7;
			this.lblWalkSensIndoorData.Text = "0.7";
			if (frmProfileEvent.Mode == "Edit")
			{
				this.trackWalkSensOutdoor.Value = Tools.FloatToInt(frmProfileEvent.Event.WalkSensOutdoor, 1);
				this.lblWalkSensOutdoorData.Text = frmProfileEvent.Event.WalkSensOutdoor.ToString("0.0").Replace(",", ".");
				this.trackWalkSensIndoor.Value = Tools.FloatToInt(frmProfileEvent.Event.WalkSensIndoor, 1);
				this.lblWalkSensIndoorData.Text = frmProfileEvent.Event.WalkSensIndoor.ToString("0.0").Replace(",", ".");
			}
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x006AC168 File Offset: 0x006AA368
		private void EnableUseHearthstone(bool Status)
		{
			this.Tab(this.tabUseHearthstone, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				string useHearthstoneProfile = frmProfileEvent.Event.UseHearthstoneProfile;
				if (File.Exists(_globals.JackProfiles + "\\" + useHearthstoneProfile + ".json"))
				{
					this.selectUseHearthstoneLoadProfile.SelectedIndex = this.selectUseHearthstoneLoadProfile.FindStringExact(useHearthstoneProfile);
				}
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x006AC1D4 File Offset: 0x006AA3D4
		private void EnableFishing(bool Status)
		{
			this.Tab(this.tabFishing, Status);
			frmProfileEvent.CheckKeybinds();
			if (frmProfileEvent.Mode == "Edit")
			{
				this.checkFishingBait.Checked = frmProfileEvent.Event.FishingUseBait;
				this.checkFishingFacing.Checked = frmProfileEvent.Event.FishingFacing;
				this.checkFishingCondition.Checked = frmProfileEvent.Event.FishingCondition;
				this.checkFishingOptionsRandomDelay.Checked = frmProfileEvent.Event.FishingRandomDelay;
				if (frmProfileEvent.Event.FishingConditionSkill)
				{
					this.txtFishingConditionSkillLevel.Text = frmProfileEvent.Event.FishingConditionSkillLevel.ToString();
				}
				int count = frmProfileEvent.RecordedFishingItemlist.Count;
				if (count > 0)
				{
					this.btnFishingConditionItemlist.Text = "Itemlist (" + count.ToString() + ")";
				}
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x006AC2B4 File Offset: 0x006AA4B4
		private void EnableUseTransport(bool Status)
		{
			this.Tab(this.tabUseTransport, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				string useTransportProfile = frmProfileEvent.Event.UseTransportProfile;
				if (File.Exists(_globals.JackProfiles + "\\" + useTransportProfile + ".json"))
				{
					this.selectUseTransportLoadProfile.SelectedIndex = this.selectUseTransportLoadProfile.FindStringExact(useTransportProfile);
				}
				this.selectUseTransportTurn.SelectedIndex = this.selectUseTransportTurn.FindStringExact(frmProfileEvent.Event.UseTransportTurn);
				if (this.selectUseTransportTurn.SelectedIndex == -1)
				{
					this.selectUseTransportTurn.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x006AC360 File Offset: 0x006AA560
		private void EnableExecuteLUA(bool Status)
		{
			this.Tab(this.tabExecuteLUA, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				this.txtExecuteLUA.Text = frmProfileEvent.Event.ExecuteLUA.Replace("#", "\n");
				this.checkExecuteLUAWhileWalk.Checked = frmProfileEvent.Event.ExecuteLUAWhileWalk;
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x006AC3C8 File Offset: 0x006AA5C8
		private void EnableBattlegroundsClassic(bool Status)
		{
			this.Tab(this.tabBattlegroundClassic, Status);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				this.checkBattlegroundClassicWarsongGulch.Checked = frmProfileEvent.Event.BattlegroundsClassicWarsongGulch;
				this.checkBattlegroundClassicArathiBasin.Checked = frmProfileEvent.Event.BattlegroundsClassicArathiBasin;
				this.checkBattlegroundClassicAlteracValley.Checked = frmProfileEvent.Event.BattlegroundsClassicAlteracValley;
				this.checkBattlegroundClassicEyeOfTheStorm.Checked = frmProfileEvent.Event.BattlegroundsClassicEyeOfTheStorm;
				this.checkBattlegroundClassicStrandOfTheAncients.Checked = frmProfileEvent.Event.BattlegroundsClassicStrandOfTheAncients;
				if (frmProfileEvent.Event.BattlegroundsClassicWarsongGulchProfile != "")
				{
					string battlegroundsClassicWarsongGulchProfile = frmProfileEvent.Event.BattlegroundsClassicWarsongGulchProfile;
					if (File.Exists(_globals.JackProfiles + "\\" + battlegroundsClassicWarsongGulchProfile + ".json"))
					{
						this.selectBattlegroundClassicWarsongGulch.SelectedIndex = this.selectBattlegroundClassicWarsongGulch.FindStringExact(battlegroundsClassicWarsongGulchProfile);
					}
				}
				if (frmProfileEvent.Event.BattlegroundsClassicArathiBasinProfile != "")
				{
					string battlegroundsClassicArathiBasinProfile = frmProfileEvent.Event.BattlegroundsClassicArathiBasinProfile;
					if (File.Exists(_globals.JackProfiles + "\\" + battlegroundsClassicArathiBasinProfile + ".json"))
					{
						this.selectBattlegroundClassicArathiBasin.SelectedIndex = this.selectBattlegroundClassicArathiBasin.FindStringExact(battlegroundsClassicArathiBasinProfile);
					}
				}
				if (frmProfileEvent.Event.BattlegroundsClassicAlteracValleyProfile != "")
				{
					string battlegroundsClassicAlteracValleyProfile = frmProfileEvent.Event.BattlegroundsClassicAlteracValleyProfile;
					if (File.Exists(_globals.JackProfiles + "\\" + battlegroundsClassicAlteracValleyProfile + ".json"))
					{
						this.selectBattlegroundClassicAlteracValley.SelectedIndex = this.selectBattlegroundClassicAlteracValley.FindStringExact(battlegroundsClassicAlteracValleyProfile);
					}
				}
				if (frmProfileEvent.Event.BattlegroundsClassicEyeOfTheStormProfile != "")
				{
					string battlegroundsClassicEyeOfTheStormProfile = frmProfileEvent.Event.BattlegroundsClassicEyeOfTheStormProfile;
					if (File.Exists(_globals.JackProfiles + "\\" + battlegroundsClassicEyeOfTheStormProfile + ".json"))
					{
						this.selectBattlegroundClassicEyeOfTheStorm.SelectedIndex = this.selectBattlegroundClassicEyeOfTheStorm.FindStringExact(battlegroundsClassicEyeOfTheStormProfile);
					}
				}
				if (frmProfileEvent.Event.BattlegroundsClassicStrandOfTheAncientsProfile != "")
				{
					string battlegroundsClassicStrandOfTheAncientsProfile = frmProfileEvent.Event.BattlegroundsClassicStrandOfTheAncientsProfile;
					if (File.Exists(_globals.JackProfiles + "\\" + battlegroundsClassicStrandOfTheAncientsProfile + ".json"))
					{
						this.selectBattlegroundClassicStrandOfTheAncients.SelectedIndex = this.selectBattlegroundClassicStrandOfTheAncients.FindStringExact(battlegroundsClassicStrandOfTheAncientsProfile);
					}
				}
				this.checkBattlegroundClassicWaitUntilInvitation.Checked = frmProfileEvent.Event.BattlegroundsWaitUntilInvitation;
			}
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x006AC624 File Offset: 0x006AA824
		private void EnableChangeProfileSettings(bool Status)
		{
			this.Tab(this.tabChangeProfileSettings, Status);
			if (Status)
			{
				if (frmProfileEvent.Mode == "Edit")
				{
					this.selectSettingsCombatMode.SelectedIndex = this.selectSettingsCombatMode.FindStringExact(frmProfileEvent.Event.ChangeSettingsCombatMode);
					this.selectSettingsWaypointMode.SelectedIndex = this.selectSettingsWaypointMode.FindStringExact(frmProfileEvent.Event.ChangeSettingsWaypointMode);
					this.checkSettingsModeFollowFleeingTarget.Checked = frmProfileEvent.Event.ChangeSettingsFollowFleeingTarget;
					this.checkSettingsModeMesh.Checked = frmProfileEvent.Event.ChangeSettingsModeMesh;
					this.checkSettingsGroundMount.Checked = frmProfileEvent.Event.ChangeSettingsGroundMount;
					this.checkSettingsFlightMount.Checked = frmProfileEvent.Event.ChangeSettingsFlightMount;
					this.checkSettingsLoot.Checked = frmProfileEvent.Event.ChangeSettingsLoot;
					this.checkSettingsLootMining.Checked = frmProfileEvent.Event.ChangeSettingsMining;
					this.checkSettingsLootHerbalism.Checked = frmProfileEvent.Event.ChangeSettingsHerbalism;
					this.checkSettingsLootSkinning.Checked = frmProfileEvent.Event.ChangeSettingsSkinning;
					this.checkSettingsLootGatherMobs.Checked = frmProfileEvent.Event.ChangeSettingsGatherMobs;
					if (frmProfileEvent.Event.ChangeSettingsQuestItems.Count > 0)
					{
						string text = "";
						foreach (string str in frmProfileEvent.Event.ChangeSettingsQuestItems)
						{
							text = text + str + "\r\n";
						}
						this.txtSettingsLootQuestItems.Text = text;
					}
					this.txtSettingsLootDistance.Text = frmProfileEvent.Event.ChangeSettingsDistanceLoot.ToString();
					this.txtSettingsLootMaxPathDistance.Text = frmProfileEvent.Event.ChangeSettingsDistancePath.ToString();
					this.txtSettingsLootGatherDistance.Text = frmProfileEvent.Event.ChangeSettingsDistanceLootGather.ToString();
					this.txtSettingsLootAvoidElitesDistance.Text = frmProfileEvent.Event.ChangeSettingsDistanceAvoidElites.ToString();
					this.txtSettingsDistancesWaypoint.Text = frmProfileEvent.Event.ChangeSettingsDistanceWaypoint.ToString();
					this.txtSettingsDistancesLocation.Text = frmProfileEvent.Event.ChangeSettingsDistanceLocation.ToString();
					this.txtSettingsDistancesMobGroup.Text = frmProfileEvent.Event.ChangeSettingsDistanceMobGroup.ToString();
					this.txtSettingsDistancesIsReachable.Text = frmProfileEvent.Event.ChangeSettingsDistanceIsReachable.ToString("0.0");
					if (frmProfileEvent.Event.ChangeSettingsAttackableMobs.Count > 0)
					{
						string text2 = "";
						foreach (string str2 in frmProfileEvent.Event.ChangeSettingsAttackableMobs)
						{
							text2 = text2 + str2 + "\r\n";
						}
						this.richSettingsMobs.Text = text2;
						return;
					}
				}
				else if (frmProfile.Mode == "Edit" && _globals.ProfileSettings != null)
				{
					ProfileSettings profileSettings = _globals.ProfileSettings[0];
					this.selectSettingsCombatMode.SelectedIndex = this.selectSettingsCombatMode.FindStringExact(profileSettings.CombatMode);
					this.selectSettingsWaypointMode.SelectedIndex = this.selectSettingsWaypointMode.FindStringExact(profileSettings.WaypointMode);
					this.checkSettingsModeFollowFleeingTarget.Checked = profileSettings.FollowFleeingTarget;
					this.checkSettingsModeMesh.Checked = profileSettings.ModeMesh;
					this.checkSettingsGroundMount.Checked = profileSettings.GroundMount;
					this.checkSettingsFlightMount.Checked = profileSettings.FlightMount;
					this.checkSettingsLoot.Checked = profileSettings.Loot;
					this.checkSettingsLootMining.Checked = profileSettings.Mining;
					this.checkSettingsLootHerbalism.Checked = profileSettings.Herbalism;
					this.checkSettingsLootSkinning.Checked = profileSettings.Skinning;
					this.checkSettingsLootGatherMobs.Checked = profileSettings.GatherMobs;
					if (profileSettings.QuestItems.Count > 0)
					{
						string text3 = "";
						foreach (string str3 in profileSettings.QuestItems)
						{
							text3 = text3 + str3 + "\r\n";
						}
						this.txtSettingsLootQuestItems.Text = text3;
					}
					this.txtSettingsLootDistance.Text = profileSettings.DistanceLoot.ToString();
					this.txtSettingsLootMaxPathDistance.Text = profileSettings.DistancePath.ToString();
					this.txtSettingsLootGatherDistance.Text = profileSettings.DistanceLootGather.ToString();
					this.txtSettingsLootAvoidElitesDistance.Text = profileSettings.DistanceAvoidElites.ToString();
					this.txtSettingsDistancesWaypoint.Text = profileSettings.DistanceWaypoint.ToString();
					this.txtSettingsDistancesLocation.Text = profileSettings.DistanceLocation.ToString();
					this.txtSettingsDistancesMobGroup.Text = profileSettings.DistanceMobGroup.ToString();
					this.txtSettingsDistancesIsReachable.Text = profileSettings.DistanceIsReachable.ToString("0.0");
					if (profileSettings.AttackableMobs.Count > 0)
					{
						string text4 = "";
						foreach (string str4 in profileSettings.AttackableMobs)
						{
							text4 = text4 + str4 + "\r\n";
						}
						this.richSettingsMobs.Text = text4;
					}
				}
			}
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x006ACBF4 File Offset: 0x006AADF4
		private void Tab(TabPage TabPage, bool Status)
		{
			if (Status)
			{
				this.tabs.Controls.Add(TabPage);
				return;
			}
			this.tabs.Controls.Remove(TabPage);
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x006ACC28 File Offset: 0x006AAE28
		private void btnAroundMeReload_Click(object sender, EventArgs e)
		{
			this.LoadAroundMe();
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x006ACC3C File Offset: 0x006AAE3C
		private void LoadAroundMe()
		{
			this.selectAroundMeNPCs.Items.Clear();
			this.selectAroundMeNPCs.Items.Add("--- NPC's ---");
			this.selectAroundMeObjects.Items.Clear();
			this.selectAroundMeObjects.Items.Add("--- Game Objects ---");
			this.selectAroundMeItems.Items.Clear();
			this.selectAroundMeItems.Items.Add("--- Items ---");
			this.ReloadObjects();
			this.selectAroundMeNPCs.SelectedIndex = 0;
			this.selectAroundMeObjects.SelectedIndex = 0;
			this.selectAroundMeItems.SelectedIndex = 0;
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x006ACCE8 File Offset: 0x006AAEE8
		private void ReloadObjects()
		{
			if (_globals.Ready)
			{
				List<Units> getNPCs = ObjectManager.GetNPCs;
				List<Objects> getGameObjects = ObjectManager.GetGameObjects;
				List<Items> getItems = ObjectManager.GetItems;
				foreach (Units units in getNPCs)
				{
					this.selectAroundMeNPCs.Items.Add(units.Name + " [" + units.DisplayID.ToString() + "]");
				}
				foreach (Objects objects in getGameObjects)
				{
					this.selectAroundMeObjects.Items.Add(objects.Name + " [" + objects.DisplayID.ToString() + "]");
				}
				foreach (Items items in getItems)
				{
					this.selectAroundMeItems.Items.Add(items.ItemName.ToString() + " [" + items.ItemID.ToString() + "]");
				}
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x006ACE64 File Offset: 0x006AB064
		private void GetTarget()
		{
			bool flag = false;
			string str = "";
			string str2 = "";
			while (base.Visible)
			{
				if (_globals.Ready)
				{
					flag = false;
					UInt128 targetGUID = ObjectManager.Me.TargetGUID;
					if (targetGUID > 0)
					{
						Units npcbyGUID = ObjectManager.GetNPCByGUID(targetGUID);
						if (npcbyGUID != null)
						{
							object @lock = ObjectManager._lock;
							lock (@lock)
							{
								Tools.Control(npcbyGUID.Name + " [" + npcbyGUID.DisplayID.ToString() + "]", "lblTargetNameData", "frmProfileEvent", true, false, false, false, 0);
								flag = true;
							}
						}
					}
					if (!flag)
					{
						Tools.Control("No Target selected.", "lblTargetNameData", "frmProfileEvent", true, false, false, false, 0);
					}
					if (!this.checkMouseoverLock.Checked)
					{
						UInt128 mouseoverGUID = PlayerMe.MouseoverGUID;
						if (mouseoverGUID > 0)
						{
							Units npcbyGUID2 = ObjectManager.GetNPCByGUID(mouseoverGUID);
							Objects objectByGUID = ObjectManager.GetObjectByGUID(mouseoverGUID);
							if (npcbyGUID2 != null)
							{
								object @lock = ObjectManager._lock;
								lock (@lock)
								{
									str = npcbyGUID2.Name;
									str2 = npcbyGUID2.DisplayID.ToString();
									goto IL_197;
								}
								goto IL_132;
							}
							goto IL_132;
							IL_197:
							Tools.Control(str + " [" + str2 + "]", "lblMouseoverNameData", "frmProfileEvent", true, false, false, false, 0);
							goto IL_17E;
							IL_132:
							if (objectByGUID != null)
							{
								object @lock = ObjectManager._lock;
								lock (@lock)
								{
									str = objectByGUID.Name;
									str2 = objectByGUID.DisplayID.ToString();
									goto IL_197;
								}
							}
							str = "Nothing selected.";
							str2 = "Nothing selected.";
							goto IL_197;
						}
					}
					IL_17E:
					Thread.Sleep(500);
				}
				Thread.Sleep(250);
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x006AD058 File Offset: 0x006AB258
		private void btnTargetSelect_Click(object sender, EventArgs e)
		{
			string text = this.lblTargetNameData.Text;
			this.SetTarget(text, "");
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x006AD080 File Offset: 0x006AB280
		private void btnMouseoverSelect_Click(object sender, EventArgs e)
		{
			string text = this.lblMouseoverNameData.Text;
			this.SetTarget(text, "");
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x006AD0A8 File Offset: 0x006AB2A8
		private void btnAroundMeNPCSelect_Click(object sender, EventArgs e)
		{
			string text = this.selectAroundMeNPCs.Text;
			this.SetTarget(text, "");
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x006AD0D0 File Offset: 0x006AB2D0
		private void btnAroundMeObjectSelect_Click(object sender, EventArgs e)
		{
			string text = this.selectAroundMeObjects.Text;
			this.SetTarget(text, "");
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x006AD0F8 File Offset: 0x006AB2F8
		private void btnAroundMeItemSelect_Click(object sender, EventArgs e)
		{
			string text = this.selectAroundMeItems.Text;
			this.SetTarget(text, "");
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x006AD120 File Offset: 0x006AB320
		private void SetTarget(string Target, string DisplayID = "")
		{
			string text = "";
			if (Target.Contains("["))
			{
				DisplayID = Target.Split(new char[]
				{
					'[',
					']'
				})[1];
				text = Target.Split(new char[]
				{
					'['
				})[0].TrimEnd(Array.Empty<char>());
			}
			if (text.Length > 0 && DisplayID.Length > 0)
			{
				if (!Tools.IsNumber(DisplayID, 1, 0, 0, 0))
				{
					return;
				}
				string position = "";
				Units unitByDisplayID = ObjectManager.GetUnitByDisplayID(Convert.ToInt32(DisplayID));
				Objects objectByDisplayID = ObjectManager.GetObjectByDisplayID(Convert.ToInt32(DisplayID));
				if (unitByDisplayID != null)
				{
					position = unitByDisplayID.PositionVector3.ToString();
				}
				else if (objectByDisplayID != null)
				{
					position = objectByDisplayID.PositionVector3.ToString();
				}
				this.ShowNPCName(true, Target, position);
				string text2 = this.selectAction.Text;
				if (EventManager.IsAction(text2, "Interact with..."))
				{
					this.txtInteractNameOrID.Text = DisplayID;
					return;
				}
				if (EventManager.IsAction(text2, "Cast Spell...") && this.checkCastSpellTarget.Checked)
				{
					this.txtCastSpellTargetNameOrID.Text = DisplayID;
					return;
				}
				if (EventManager.IsAction(text2, "Wait...") && this.checkWaitFor.Checked)
				{
					this.txtWaitForNameOrID.Text = DisplayID;
				}
			}
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x006AD274 File Offset: 0x006AB474
		private void checkCondition1_CheckedChanged(object sender, EventArgs e)
		{
			this.EnableCondition1(this.checkCondition1.Checked);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x006AD294 File Offset: 0x006AB494
		private void checkCondition2_CheckedChanged(object sender, EventArgs e)
		{
			this.EnableCondition2(this.checkCondition2.Checked);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x006AD2B4 File Offset: 0x006AB4B4
		private void EnableCondition1(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpCondition1, new string[]
			{
				"checkCondition1"
			});
			if (Status && frmProfileEvent.Mode == "Edit" && frmProfileEvent.Event.HasCondition1)
			{
				this.selectCondition1.SelectedIndex = this.selectCondition1.FindStringExact(frmProfileEvent.Event.Condition1);
				this.selectCondition1Compare.SelectedIndex = this.selectCondition1Compare.FindStringExact(frmProfileEvent.Event.Condition1Compare);
				this.txtCondition1Value.Text = frmProfileEvent.Event.Condition1Value;
				this.txtCondition1Value2.Text = frmProfileEvent.Event.Condition1Value2;
			}
			this.checkCondition2.Enabled = Status;
			if (!Status)
			{
				this.checkCondition2.Checked = Status;
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x006AD384 File Offset: 0x006AB584
		private void EnableCondition2(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpCondition2, new string[]
			{
				"checkCondition2"
			});
			CustomUI.EnableGroupBox(Status, this.grpConditionAndOr1, null);
			if (Status && frmProfileEvent.Mode == "Edit" && frmProfileEvent.Event.HasCondition2)
			{
				this.selectConditionAndOr1.SelectedIndex = this.selectConditionAndOr1.FindStringExact(frmProfileEvent.Event.ConditionAndOr1);
				this.selectCondition2.SelectedIndex = this.selectCondition2.FindStringExact(frmProfileEvent.Event.Condition2);
				this.selectCondition2Compare.SelectedIndex = this.selectCondition2Compare.FindStringExact(frmProfileEvent.Event.Condition2Compare);
				this.txtCondition2Value.Text = frmProfileEvent.Event.Condition2Value;
				this.txtCondition2Value2.Text = frmProfileEvent.Event.Condition2Value2;
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x006AD46C File Offset: 0x006AB66C
		private void selectCondition1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.selectCondition1.Text == "Bag contains Item (by ID)")
			{
				this.ShowConditionValue2(1, true, "Amount");
			}
			else
			{
				this.ShowConditionValue2(1, false, "");
			}
			if (!this.NoCheck)
			{
				this.SelectCondition(1);
				return;
			}
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x006AD4BC File Offset: 0x006AB6BC
		private void selectCondition2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.selectCondition2.Text == "Bag contains Item (by ID)")
			{
				this.ShowConditionValue2(2, true, "Amount");
			}
			else
			{
				this.ShowConditionValue2(2, false, "");
			}
			if (!this.NoCheck)
			{
				this.SelectCondition(2);
				return;
			}
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x006AD50C File Offset: 0x006AB70C
		private void SelectCondition(int ConditionNumber)
		{
			bool enabled = true;
			bool enabled2 = true;
			string text = "";
			string a = "";
			string placeholderText = "";
			if (ConditionNumber != 1)
			{
				if (ConditionNumber == 2)
				{
					a = this.selectCondition2.Text;
				}
			}
			else
			{
				a = this.selectCondition1.Text;
			}
			if (!(a == "Bags are full") && !(a == "Bags are not full") && !(a == "Low Armor Durability"))
			{
				if (!(a == "Class"))
				{
					if (!(a == "Level"))
					{
						if (!(a == "Skill Name"))
						{
							if (a == "Skill Level")
							{
								placeholderText = "e.g. 225";
							}
							else if (a == "Is in Range of... (in Yards)")
							{
								placeholderText = "e.g. 20";
							}
							else if (a == "Free bag slots")
							{
								placeholderText = "e.g. 5";
							}
							else if (!(a == "Bag contains Item (by ID)"))
							{
								if (a == "When Quest(s) completed")
								{
									text = "Equal";
									enabled = false;
									placeholderText = "e.g. 178, 3961, ...";
								}
							}
							else
							{
								text = "Item ID";
								placeholderText = "e.g. 6948";
							}
						}
						else
						{
							text = "Equal";
							placeholderText = "e.g. Herbalism";
						}
					}
					else
					{
						placeholderText = "e.g. 40";
					}
				}
				else
				{
					text = "Equal";
					placeholderText = "e.g. Mage";
				}
			}
			else
			{
				enabled = false;
				enabled2 = false;
			}
			if (ConditionNumber == 1)
			{
				if (text.Length > 0)
				{
					this.selectCondition1Compare.SelectedIndex = this.selectCondition1Compare.FindStringExact(text);
				}
				this.selectCondition1Compare.Enabled = enabled;
				this.txtCondition1Value.Text = "";
				this.txtCondition1Value.PlaceholderText = placeholderText;
				this.txtCondition1Value.Enabled = enabled2;
				return;
			}
			if (ConditionNumber == 2)
			{
				if (text.Length > 0)
				{
					this.selectCondition2Compare.SelectedIndex = this.selectCondition2Compare.FindStringExact(text);
				}
				this.selectCondition2Compare.Enabled = enabled;
				this.txtCondition2Value.Text = "";
				this.txtCondition2Value.PlaceholderText = placeholderText;
				this.txtCondition2Value.Enabled = enabled2;
			}
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x006AD70C File Offset: 0x006AB90C
		private void ShowConditionValue2(int ConditionNumber, bool Status, string Placeholder)
		{
			if (ConditionNumber != 1)
			{
				if (ConditionNumber == 2)
				{
					this.txtCondition2Value2.Visible = Status;
					this.txtCondition2Value2.PlaceholderText = Placeholder;
					if (Status)
					{
						this.txtCondition2Value.Width = 90;
						this.txtCondition2Value.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
						return;
					}
					this.txtCondition2Value.Width = this.selectCondition2Compare.Width;
					this.txtCondition2Value.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				}
				return;
			}
			this.txtCondition1Value2.Visible = Status;
			this.txtCondition1Value2.PlaceholderText = Placeholder;
			if (!Status)
			{
				this.txtCondition1Value.Width = this.selectCondition1Compare.Width;
				this.txtCondition1Value.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				return;
			}
			this.txtCondition1Value.Width = 90;
			this.txtCondition1Value.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x006AD7D4 File Offset: 0x006AB9D4
		private void checkSettingsExecutionOnce_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkSettingsExecuteOnce.Checked)
			{
				this.checkSettingsExecuteAlways.Checked = false;
				return;
			}
			if (!this.checkSettingsExecuteOnce.Checked && !this.checkSettingsExecuteAlways.Checked)
			{
				this.checkSettingsExecuteOnce.Checked = true;
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x006AD824 File Offset: 0x006ABA24
		private void checkSettingsExecutionAlways_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkSettingsExecuteAlways.Checked)
			{
				this.checkSettingsExecuteOnce.Checked = false;
				return;
			}
			if (!this.checkSettingsExecuteAlways.Checked && !this.checkSettingsExecuteOnce.Checked)
			{
				this.checkSettingsExecuteAlways.Checked = true;
			}
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x006AD874 File Offset: 0x006ABA74
		private void checkInteractClosest_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkInteractClosest.Checked)
			{
				this.checkInteractFurthest.Checked = false;
				return;
			}
			if (!this.checkInteractClosest.Checked && !this.checkInteractFurthest.Checked)
			{
				this.checkInteractClosest.Checked = true;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x006AD8C4 File Offset: 0x006ABAC4
		private void checkInteractFurthest_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkInteractFurthest.Checked)
			{
				this.checkInteractClosest.Checked = false;
				return;
			}
			if (!this.checkInteractFurthest.Checked && !this.checkInteractClosest.Checked)
			{
				this.checkInteractFurthest.Checked = true;
			}
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x006AD914 File Offset: 0x006ABB14
		private void checkWait_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkWait.Checked;
			if (@checked && this.checkWaitFor.Checked)
			{
				this.checkWaitFor.Checked = false;
			}
			CustomUI.EnableGroupBox(@checked, this.grpWait, new string[]
			{
				"checkWait"
			});
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x006AD964 File Offset: 0x006ABB64
		private void checkWaitFor_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkWaitFor.Checked;
			if (@checked && this.checkWait.Checked)
			{
				this.checkWait.Checked = false;
			}
			CustomUI.EnableGroupBox(@checked, this.grpWaitFor, new string[]
			{
				"checkWaitFor"
			});
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x006AD9B4 File Offset: 0x006ABBB4
		private void btnCastSpellReload_Click(object sender, EventArgs e)
		{
			this.LoadSpells();
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x006AD9C8 File Offset: 0x006ABBC8
		private void checkCastSpellTarget_CheckedChanged(object sender, EventArgs e)
		{
			CustomUI.EnableGroupBox(this.checkCastSpellTarget.Checked, this.grpCastSpellTarget, new string[]
			{
				"checkCastSpellTarget"
			});
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x006AD9FC File Offset: 0x006ABBFC
		private void checkCastSpellTargetClosest_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkCastSpellTargetClosest.Checked)
			{
				this.checkCastSpellTargetFurthest.Checked = false;
				return;
			}
			if (!this.checkCastSpellTargetClosest.Checked && !this.checkCastSpellTargetFurthest.Checked)
			{
				this.checkCastSpellTargetClosest.Checked = true;
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x006ADA4C File Offset: 0x006ABC4C
		private void checkCastSpellTargetFurthest_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkCastSpellTargetFurthest.Checked)
			{
				this.checkCastSpellTargetClosest.Checked = false;
				return;
			}
			if (!this.checkCastSpellTargetFurthest.Checked && !this.checkCastSpellTargetClosest.Checked)
			{
				this.checkCastSpellTargetFurthest.Checked = true;
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x006ADA9C File Offset: 0x006ABC9C
		private void checkCastSpellNoRadiusCheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkCastSpellNoRadiusCheck.Checked)
			{
				this.txtCastSpellRadius.Enabled = false;
				this.txtCastSpellRadius.Text = "0";
				return;
			}
			this.txtCastSpellRadius.Enabled = true;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x006ADAE0 File Offset: 0x006ABCE0
		private void lblRecorderInfo_MouseEnter(object sender, EventArgs e)
		{
			this.lblRecorderInfo.ForeColor = Color.CornflowerBlue;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x006ADB00 File Offset: 0x006ABD00
		private void lblRecorderInfo_MouseLeave(object sender, EventArgs e)
		{
			this.lblRecorderInfo.ForeColor = Color.White;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x006ADB20 File Offset: 0x006ABD20
		private void lblRecorderInfo_Click(object sender, EventArgs e)
		{
			string title = "Recorder";
			string text = "The Recorder is only required for <u>Ghost Paths back to dungeons</u>.\r\n\r\n";
			text += "If you use your own recorded route, Jack will only check and trigger this event";
			text += " as soon as the coordinate on which the event is located is reached.\r\n\r\n";
			text += "If you don't use your own route, the event is considered global";
			text += " and will be triggered whenever your conditions are met.";
			CustomUI.Dialog(title, text, "", "frmProfileEvent", true, 0);
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x006ADB7C File Offset: 0x006ABD7C
		private void lblRecorderShow_MouseEnter(object sender, EventArgs e)
		{
			this.lblRecorderShow.ForeColor = Color.LimeGreen;
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x006ADB9C File Offset: 0x006ABD9C
		private void lblRecorderShow_MouseLeave(object sender, EventArgs e)
		{
			this.lblRecorderShow.ForeColor = Color.CornflowerBlue;
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x006ADBBC File Offset: 0x006ABDBC
		private void lblRecorderShow_Click(object sender, EventArgs e)
		{
			this.panelRecorderInfo.Visible = false;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x006ADBD8 File Offset: 0x006ABDD8
		private void selectRecorderRouteType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			this.EnableSelectedRouteType(true);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x006ADBF8 File Offset: 0x006ABDF8
		private void EnableSelectedRouteType(bool NoSelection = false)
		{
			if (!NoSelection && frmProfileEvent.Mode == "Edit" && EventManager.IsAction(frmProfileEvent.Event.Action, "Add Route..."))
			{
				this.selectRecorderRouteType.SelectedIndex = this.selectRecorderRouteType.FindStringExact(frmProfileEvent.Event.RouteType);
				if (this.selectRecorderRouteType.SelectedIndex == -1 && frmProfileEvent.Event.RouteType == "Ghost")
				{
					if (frmProfileEvent.Event.GhostDirectionPathToGraveyard)
					{
						this.selectRecorderRouteType.SelectedIndex = this.selectRecorderRouteType.FindStringExact("Ghost (Path to Graveyard)");
					}
					else
					{
						this.selectRecorderRouteType.SelectedIndex = this.selectRecorderRouteType.FindStringExact("Ghost (Graveyard to Path)");
					}
				}
				if (frmProfileEvent.Event.TargetName.Length > 0)
				{
					this.ShowNPCName(true, frmProfileEvent.Event.TargetName + " [" + frmProfileEvent.Event.TargetDisplayID.ToString() + "]", frmProfileEvent.Event.TargetLocation.ToString());
				}
			}
			string text = this.selectRecorderRouteType.Text;
			if (text.Length > 0)
			{
				if (text == "Vendor")
				{
					this.EnableRecorderLandingField(true);
					this.EnableRecorderVendor(true);
					this.EnableRecorderFlightMaster(false);
					this.EnableRecorderMailbox(false);
					this.selectRecorderCombatMode.Enabled = true;
				}
				else if (!(text == "Trainer") && !(text == "Set Hearthstone"))
				{
					if (text == "Flight Master")
					{
						this.EnableRecorderLandingField(true);
						this.EnableRecorderVendor(false);
						this.EnableRecorderFlightMaster(true);
						this.EnableRecorderMailbox(false);
						this.selectRecorderCombatMode.Enabled = true;
					}
					else if (text == "Mailbox")
					{
						this.EnableRecorderLandingField(true);
						this.EnableRecorderVendor(false);
						this.EnableRecorderFlightMaster(false);
						this.EnableRecorderMailbox(true);
						this.selectRecorderCombatMode.Enabled = true;
					}
					else
					{
						this.EnableRecorderLandingField(false);
						this.EnableRecorderVendor(false);
						this.EnableRecorderFlightMaster(false);
						this.EnableRecorderMailbox(false);
						this.selectRecorderCombatMode.Enabled = false;
					}
				}
				else
				{
					this.EnableRecorderLandingField(true);
					this.EnableRecorderVendor(false);
					this.EnableRecorderFlightMaster(false);
					this.EnableRecorderMailbox(false);
					this.selectRecorderCombatMode.Enabled = true;
				}
				if (frmProfileEvent.Mode != "Edit")
				{
					return;
				}
				this.selectRecorderCombatMode.SelectedIndex = this.selectRecorderCombatMode.FindStringExact(frmProfileEvent.Event.CombatMode);
			}
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x006ADE88 File Offset: 0x006AC088
		private void EnableRecorderLandingField(bool Status)
		{
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				object @lock = frmProfileEvent._lock;
				lock (@lock)
				{
					frmProfileEvent.LandingField = frmProfileEvent.Event.LandingField;
				}
			}
			if (frmProfileEvent.LandingField == Vector3.Zero)
			{
				this.lblRecorderLandingFieldLocation.Text = "No Landing Field set.";
				this.lblRecorderLandingFieldLocation.ForeColor = Color.DimGray;
				this.btnRecorderSetLandingField.Text = "Set Landing Field";
			}
			else
			{
				this.lblRecorderLandingFieldLocation.Text = frmProfileEvent.LandingField.ToString();
				this.lblRecorderLandingFieldLocation.ForeColor = Color.LimeGreen;
				this.btnRecorderSetLandingField.Text = "Delete Landing Field";
			}
			this.btnRecorderSetLandingField.Enabled = Status;
			this.lblRecorderLandingField.Enabled = Status;
			this.lblRecorderLandingFieldLocation.Enabled = Status;
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x006ADF88 File Offset: 0x006AC188
		private void EnableRecorderVendor(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpRecorderVendor, null);
			this.lblRecorderVendorMountKeybind.Enabled = false;
			frmProfileEvent.CheckKeybinds();
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				this.checkRecorderVendorCanRepair.Checked = frmProfileEvent.Event.VendorCanRepair;
				this.checkRecorderVendorSellGreys.Checked = frmProfileEvent.Event.VendorSellGreys;
				this.checkRecorderVendorSellWhites.Checked = frmProfileEvent.Event.VendorSellWhites;
				this.checkRecorderVendorSellGreens.Checked = frmProfileEvent.Event.VendorSellGreens;
				this.checkRecorderVendorSellBlues.Checked = frmProfileEvent.Event.VendorSellBlues;
				this.checkRecorderVendorMount.Checked = frmProfileEvent.Event.VendorMount;
				int count = frmProfileEvent.RecordedWhitelist.Count;
				if (count > 0)
				{
					this.btnRecorderVendorWhitelist.Text = "Whitelist (" + count.ToString() + ")";
				}
				count = frmProfileEvent.RecordedBuylist.Count;
				if (count > 0)
				{
					this.btnRecorderVendorBuylist.Text = "Buylist (" + count.ToString() + ")";
				}
				this.lblTargetNameData.Text = frmProfileEvent.Event.TargetName + " [" + frmProfileEvent.Event.TargetDisplayID.ToString() + "]";
				return;
			}
			this.checkRecorderVendorCanRepair.Checked = false;
			this.checkRecorderVendorSellGreys.Checked = false;
			this.checkRecorderVendorSellWhites.Checked = false;
			this.checkRecorderVendorSellGreens.Checked = false;
			this.checkRecorderVendorSellBlues.Checked = false;
			this.checkRecorderVendorMount.Checked = false;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x006AE12C File Offset: 0x006AC32C
		private void EnableRecorderFlightMaster(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpRecorderFlightMaster, null);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				if (frmProfileEvent.Event.FlightPointID != 0)
				{
					string flightPoint = ObjectManager.GetFlightPoint(frmProfileEvent.Event.FlightPointID);
					if (flightPoint.Length > 0)
					{
						this.selectRecorderFlightMasterFlightPoints.SelectedIndex = this.selectRecorderFlightMasterFlightPoints.FindStringExact(flightPoint);
					}
				}
				if (frmProfileEvent.Event.FlightPointProfile != "")
				{
					string flightPointProfile = frmProfileEvent.Event.FlightPointProfile;
					if (File.Exists(_globals.JackProfiles + "\\" + flightPointProfile + ".json"))
					{
						this.selectRecorderFlightMasterProfiles.SelectedIndex = this.selectRecorderFlightMasterProfiles.FindStringExact(flightPointProfile);
					}
				}
			}
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x006AE1F0 File Offset: 0x006AC3F0
		private void EnableRecorderMailbox(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpRecorderMailbox, null);
			if (Status && frmProfileEvent.Mode == "Edit")
			{
				this.txtRecorderMailboxReceiver.Text = frmProfileEvent.Event.RecorderMailboxReceiver;
				int count = frmProfileEvent.RecordedSendlist.Count;
				if (count > 0)
				{
					this.btnRecorderMailboxSendlist.Text = "Sendlist (" + count.ToString() + ")";
				}
				this.checkRecorderMailboxSendGreys.Checked = frmProfileEvent.Event.RecorderMailboxSendGreys;
				this.checkRecorderMailboxSendWhites.Checked = frmProfileEvent.Event.RecorderMailboxSendWhites;
				this.checkRecorderMailboxSendGreens.Checked = frmProfileEvent.Event.RecorderMailboxSendGreens;
				this.checkRecorderMailboxSendBlues.Checked = frmProfileEvent.Event.RecorderMailboxSendBlues;
				this.checkRecorderMailboxSendPurples.Checked = frmProfileEvent.Event.RecorderMailboxSendPurples;
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x006AE2D4 File Offset: 0x006AC4D4
		private void ShowNPCName(bool Status, string Target, string Position = "")
		{
			if (Status)
			{
				if (Tools.StringToVector3(Position) == Vector3.Zero)
				{
					Position = "Unknown Position";
				}
				CustomUI.ColorGroupBox("Blue", this.grpSelectionCurrent);
				this.lblCurrentTarget.Text = Target;
				this.lblCurrentTargetLocation.Text = Position;
				return;
			}
			CustomUI.ColorGroupBox("Bright", this.grpSelectionCurrent);
			this.lblCurrentTarget.Text = "No Target selected.";
			this.lblCurrentTargetLocation.Text = "Unknown Position";
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x006AE358 File Offset: 0x006AC558
		private void btnRecordStart_Click(object sender, EventArgs e)
		{
			if (!_globals.Ready)
			{
				return;
			}
			if (!frmProfileEvent.RecordingEventRoute)
			{
				frmProfileEvent.RecordingEventRoute = true;
				new Thread(new ThreadStart(this.Record))
				{
					IsBackground = true
				}.Start();
				Window.Activate(null);
				this.btnRecordStart.Image = Resources.stop_white_32;
				this.btnRecordStart.FillColor = Color.Red;
				this.btnRecorderSingle.Enabled = true;
				return;
			}
			frmProfileEvent.RecordingEventRoute = false;
			this.btnRecordStart.Image = Resources.play_32;
			this.btnRecordStart.FillColor = Color.FromArgb(23, 39, 52);
			this.btnRecorderSingle.Enabled = false;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x006AE404 File Offset: 0x006AC604
		private void Record()
		{
			bool flag = true;
			if (frmProfileEvent.RecordedEventWaypoints.Count > 0)
			{
				flag = false;
			}
			if (Jack.Core.Settings.RecorderAutoRecord && flag)
			{
				this.AddWaypoint();
			}
			while (frmProfileEvent.RecordingEventRoute)
			{
				if (Jack.Core.Settings.RecorderAutoRecord && frmProfileEvent.RecordedEventWaypoints.Count > 0 && JackMath.Distance(frmProfileEvent.RecordedEventWaypoints.LastOrDefault<Vector3>(), true, true, true) >= (double)Jack.Core.Settings.RecorderAutoDistance)
				{
					this.AddWaypoint();
				}
				Thread.Sleep(10);
			}
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x006AE478 File Offset: 0x006AC678
		private void AddWaypoint()
		{
			bool flag = false;
			Vector3 positionVector = ObjectManager.Me.PositionVector3;
			using (List<Vector3>.Enumerator enumerator = frmProfileEvent.RecordedEventWaypoints.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == positionVector)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				object @lock = frmProfileEvent._lock;
				lock (@lock)
				{
					frmProfileEvent.RecordedEventWaypoints.Add(positionVector);
					Tools.Control(new string[]
					{
						frmProfileEvent.RecordedEventWaypoints.Count.ToString(),
						frmProfileEvent.RecordedEventWaypoints.Count.ToString() + "|" + positionVector.ToString() + "|"
					}, "listWaypoints", "frmProfileEvent", true, false, false, false, 0);
				}
			}
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x006AE57C File Offset: 0x006AC77C
		private void btnWaypointDelete_Click(object sender, EventArgs e)
		{
			if (this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
			{
				int index = this.listWaypoints.SelectedIndices[0];
				this.DeleteWaypoint(index);
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x006AE5C8 File Offset: 0x006AC7C8
		private void DeleteWaypoint(int Index)
		{
			object @lock = frmProfileEvent._lock;
			lock (@lock)
			{
				if (frmProfileEvent.RecordedEventWaypoints.Count > 1)
				{
					frmProfileEvent.RecordedEventWaypoints.RemoveAt(Index);
				}
				else
				{
					frmProfileEvent.RecordedEventWaypoints.Clear();
				}
			}
			frmProfileEvent.UpdateListBoxWaypoints();
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x006AE62C File Offset: 0x006AC82C
		private void btnRecorderSingle_Click(object sender, EventArgs e)
		{
			if (_globals.Ready && frmProfileEvent.RecordingEventRoute)
			{
				Window.Activate(null);
				this.AddWaypoint();
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x006AE654 File Offset: 0x006AC854
		private void btnWaypointAddAfter_Click(object sender, EventArgs e)
		{
			if (_globals.Ready && frmProfileEvent.RecordedEventWaypoints.Count > 1 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
			{
				if (this.listWaypoints.SelectedIndices[0] == frmProfileEvent.RecordedEventWaypoints.Count - 1)
				{
					this.AddWaypoint();
					return;
				}
				Window.Activate(null);
				Vector3 item = frmProfileEvent.RecordedEventWaypoints[this.listWaypoints.SelectedIndices[0] + 1];
				int index = frmProfileEvent.RecordedEventWaypoints.IndexOf(item);
				frmProfileEvent.RecordedEventWaypoints.Insert(index, ObjectManager.Me.PositionVector3);
				frmProfileEvent.UpdateListBoxWaypoints();
			}
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x006AE718 File Offset: 0x006AC918
		private void btnRecordSetLandingField_Click(object sender, EventArgs e)
		{
			object @lock;
			if (!(frmProfileEvent.LandingField == Vector3.Zero))
			{
				@lock = frmProfileEvent._lock;
				lock (@lock)
				{
					frmProfileEvent.LandingField = Vector3.Zero;
				}
				this.lblRecorderLandingFieldLocation.Text = "No Landing Field set.";
				this.lblRecorderLandingFieldLocation.ForeColor = Color.DimGray;
				this.btnRecorderSetLandingField.Text = "Set Landing Field";
				return;
			}
			if (!_globals.Ready)
			{
				return;
			}
			@lock = frmProfileEvent._lock;
			lock (@lock)
			{
				frmProfileEvent.LandingField = ObjectManager.Me.PositionVector3;
			}
			this.lblRecorderLandingFieldLocation.Text = frmProfileEvent.LandingField.ToString();
			this.lblRecorderLandingFieldLocation.ForeColor = Color.LimeGreen;
			this.btnRecorderSetLandingField.Text = "Delete Landing Field";
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x006AE818 File Offset: 0x006ACA18
		public static void UpdateListBoxWaypoints()
		{
			new Thread(new ThreadStart(frmProfileEvent.UpdateListBoxWaypointsThread))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x006AE844 File Offset: 0x006ACA44
		private static void UpdateListBoxWaypointsThread()
		{
			int num = 1;
			Dictionary<string[], string[]> dictionary = new Dictionary<string[], string[]>();
			foreach (Vector3 vector in frmProfileEvent.RecordedEventWaypoints.ToList<Vector3>())
			{
				string[] key = new string[]
				{
					num.ToString(),
					vector.ToString()
				};
				dictionary.Add(key, null);
				num++;
			}
			Tools.ControlListViewCreate(dictionary, "listWaypoints", "frmProfileEvent", true, -1, null);
			Tools.Control("", "btnWaypointDelete", "frmProfileEvent", false, false, false, false, 0);
			Tools.Control("", "btnWaypointAddAfter", "frmProfileEvent", false, false, false, false, 0);
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x006AE914 File Offset: 0x006ACB14
		private void listWaypoints_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
			{
				this.btnWaypointDelete.Enabled = true;
				this.btnWaypointAddAfter.Enabled = true;
				return;
			}
			this.btnWaypointDelete.Enabled = false;
			this.btnWaypointAddAfter.Enabled = false;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x006AE978 File Offset: 0x006ACB78
		private void btnRecorderVendorWhitelist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"VendorWhitelist"
			};
			Tools.OpenForm("frmList", false, "frmProfileEvent", args);
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x006AE9A8 File Offset: 0x006ACBA8
		private void btnRecorderVendorBuylist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"VendorBuylist"
			};
			Tools.OpenForm("frmList", false, "frmProfileEvent", args);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x006AE9D8 File Offset: 0x006ACBD8
		private void checkRecorderVendorMount_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkRecorderVendorMount.Checked;
			this.lblRecorderVendorMountKeybind.Enabled = @checked;
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x006AEA00 File Offset: 0x006ACC00
		private void btnRecorderMailboxSendlist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"MailboxSendlist"
			};
			Tools.OpenForm("frmList", false, "frmProfileEvent", args);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x006AEA30 File Offset: 0x006ACC30
		private void btnWalkSensDefault_Click(object sender, EventArgs e)
		{
			this.trackWalkSensOutdoor.Value = 20;
			this.lblWalkSensOutdoorData.Text = "2.0";
			this.trackWalkSensIndoor.Value = 7;
			this.lblWalkSensIndoorData.Text = "0.7";
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x006AEA78 File Offset: 0x006ACC78
		private void trackWalkSensOutdoor_Scroll(object sender, EventArgs e)
		{
			string text = this.trackWalkSensOutdoor.Value.ToString("00");
			string text2 = text[0].ToString() + "." + text[1].ToString();
			this.lblWalkSensOutdoorData.Text = text2;
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x006AEAD4 File Offset: 0x006ACCD4
		private void trackWalkSensIndoor_Scroll(object sender, EventArgs e)
		{
			string text = this.trackWalkSensIndoor.Value.ToString("00");
			string text2 = text[0].ToString() + "." + text[1].ToString();
			this.lblWalkSensIndoorData.Text = text2;
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x006AEA78 File Offset: 0x006ACC78
		private void trackWalkSensOutdoor_Scroll(object sender, ScrollEventArgs e)
		{
			string text = this.trackWalkSensOutdoor.Value.ToString("00");
			string text2 = text[0].ToString() + "." + text[1].ToString();
			this.lblWalkSensOutdoorData.Text = text2;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x006AEAD4 File Offset: 0x006ACCD4
		private void trackWalkSensIndoor_Scroll(object sender, ScrollEventArgs e)
		{
			string text = this.trackWalkSensIndoor.Value.ToString("00");
			string text2 = text[0].ToString() + "." + text[1].ToString();
			this.lblWalkSensIndoorData.Text = text2;
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x006AEB30 File Offset: 0x006ACD30
		private void checkFishingBait_CheckedChanged(object sender, EventArgs e)
		{
			CustomUI.EnableGroupBox(this.checkFishingBait.Checked, this.grpFishingBait, new string[]
			{
				"checkFishingBait"
			});
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x006AEB64 File Offset: 0x006ACD64
		private void checkFishingFacing_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked;
			CustomUI.EnableGroupBox(@checked = this.checkFishingFacing.Checked, this.grpFishingFacing, new string[]
			{
				"checkFishingFacing"
			});
			if (@checked && frmProfileEvent.Mode == "Edit" && frmProfileEvent.Event.FishingFacing)
			{
				this.lblFishingFacingDirection.Text = frmProfileEvent.Event.FishingFacingDirection.ToString();
				this.lblFishingFacingDirection.ForeColor = Color.LimeGreen;
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x006AEBEC File Offset: 0x006ACDEC
		private void btnFishingFacingDirection_Click(object sender, EventArgs e)
		{
			if (_globals.Ready)
			{
				this.lblFishingFacingDirection.Text = ObjectManager.Me.PositionVector3.ToString();
				this.lblFishingFacingDirection.ForeColor = Color.LimeGreen;
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x006AEC34 File Offset: 0x006ACE34
		private void checkFishingCondition_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked;
			CustomUI.EnableGroupBox(@checked = this.checkFishingCondition.Checked, this.grpFishingCondition, new string[]
			{
				"checkFishingCondition"
			});
			this.txtFishingConditionSkillLevel.Enabled = false;
			this.btnFishingConditionItemlist.Enabled = false;
			this.lblcheckFishingConditionItemlist.Enabled = false;
			if (@checked && frmProfileEvent.Mode == "Edit" && frmProfileEvent.Event.FishingCondition)
			{
				this.checkFishingConditionSkillLevel.Checked = frmProfileEvent.Event.FishingConditionSkill;
				this.checkFishingConditionItemlist.Checked = frmProfileEvent.Event.FishingConditionItem;
				this.checkFishingConditionFullBags.Checked = frmProfileEvent.Event.FishingConditionFullBags;
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x006AECEC File Offset: 0x006ACEEC
		private void checkFishingConditionSkillLevel_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkFishingConditionSkillLevel.Checked;
			this.txtFishingConditionSkillLevel.Enabled = @checked;
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x006AED14 File Offset: 0x006ACF14
		private void checkFishingConditionItemlist_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkFishingConditionItemlist.Checked;
			this.btnFishingConditionItemlist.Enabled = @checked;
			this.lblcheckFishingConditionItemlist.Enabled = @checked;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x006AED48 File Offset: 0x006ACF48
		private void btnFishingConditionItemlist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"FishingItemlist"
			};
			Tools.OpenForm("frmList", false, "frmProfileEvent", args);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x006AED78 File Offset: 0x006ACF78
		private void selectExecuteLUAExamples_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtExecuteLUA.Text = frmProfileEvent.ExecuteLUAExamples[this.selectExecuteLUAExamples.Text];
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x006AEDA8 File Offset: 0x006ACFA8
		private void btnExecuteLUATest_Click(object sender, EventArgs e)
		{
			if (!_globals.Ready)
			{
				MessageBox.Show("Please enter the world first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (this.CheckLUACommand(this.txtExecuteLUA.Text))
			{
				Addon.LUA(this.txtExecuteLUA.Text, "0", true, true);
				return;
			}
			MessageBox.Show("The entered LUA Command is too short.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x006AEE14 File Offset: 0x006AD014
		private bool CheckLUACommand(string Command)
		{
			Command = Command.Replace("\r\n", " ").Replace("\t", "").Replace("  ", "").Trim();
			return Command.Length >= 3;
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x006AEE64 File Offset: 0x006AD064
		private void checkSettingsLootMining_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			if (!_globals.ModuleGather)
			{
				this.checkSettingsLootMining.CheckedChanged -= this.checkSettingsLootMining_CheckedChanged;
				this.checkSettingsLootMining.Checked = !this.checkSettingsLootMining.Checked;
				this.checkSettingsLootMining.CheckedChanged += this.checkSettingsLootMining_CheckedChanged;
				CustomUI.DialogModule(base.Name);
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x006AEED4 File Offset: 0x006AD0D4
		private void checkSettingsLootHerbalism_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			if (!_globals.ModuleGather)
			{
				this.checkSettingsLootHerbalism.CheckedChanged -= this.checkSettingsLootHerbalism_CheckedChanged;
				this.checkSettingsLootHerbalism.Checked = !this.checkSettingsLootHerbalism.Checked;
				this.checkSettingsLootHerbalism.CheckedChanged += this.checkSettingsLootHerbalism_CheckedChanged;
				CustomUI.DialogModule(base.Name);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x006AEF44 File Offset: 0x006AD144
		private void checkSettingsLootSkinning_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			if (!_globals.ModuleGather)
			{
				this.checkSettingsLootSkinning.CheckedChanged -= this.checkSettingsLootSkinning_CheckedChanged;
				this.checkSettingsLootSkinning.Checked = !this.checkSettingsLootSkinning.Checked;
				this.checkSettingsLootSkinning.CheckedChanged += this.checkSettingsLootSkinning_CheckedChanged;
				CustomUI.DialogModule(base.Name);
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x006AEFB4 File Offset: 0x006AD1B4
		private void checkSettingsLootGatherMobs_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			if (!_globals.ModuleGather)
			{
				this.checkSettingsLootGatherMobs.CheckedChanged -= this.checkSettingsLootGatherMobs_CheckedChanged;
				this.checkSettingsLootGatherMobs.Checked = !this.checkSettingsLootGatherMobs.Checked;
				this.checkSettingsLootGatherMobs.CheckedChanged += this.checkSettingsLootGatherMobs_CheckedChanged;
				CustomUI.DialogModule(base.Name);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x006AF024 File Offset: 0x006AD224
		private void txtSettingsLootQuestItems_MouseClick(object sender, MouseEventArgs e)
		{
			if (!_globals.ModuleGather)
			{
				CustomUI.DialogModule(base.Name);
				this.imgModuleGather.Focus();
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x006AF050 File Offset: 0x006AD250
		private void checkSettingsModeMesh_CheckedChanged(object sender, EventArgs e)
		{
			string text;
			if (this.checkSettingsModeMesh.Checked)
			{
				this.txtSettingsDistancesWaypoint.Enabled = false;
				if (!this.checkSettingsFlightMount.Checked)
				{
					this.txtSettingsLootMaxPathDistance.Enabled = true;
				}
				text = "Jack searches for Mobs around your own current location.\r\n";
				text += "Enter here the Radius in yards in which Jack should search.";
			}
			else
			{
				this.txtSettingsDistancesWaypoint.Enabled = true;
				if (!this.checkSettingsFlightMount.Checked)
				{
					this.txtSettingsLootMaxPathDistance.Enabled = false;
				}
				text = "Jack searches for Mobs around every upcoming Waypoint and around your own current location.\r\n";
				text += "Enter here the Radii in yards in which Jack should search.";
			}
			this.lblSettingsDistancesInfo.Text = text;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x006AF0E8 File Offset: 0x006AD2E8
		private void checkSettingsGroundMount_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkSettingsGroundMount.Checked)
			{
				this.checkSettingsFlightMount.Checked = false;
				this.CombatModeSelection("");
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x006AF11C File Offset: 0x006AD31C
		private void checkSettingsFlightMount_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkSettingsFlightMount.Checked)
			{
				this.checkSettingsGroundMount.Checked = false;
				this.CombatModeSelection("Flight");
				this.txtSettingsLootMaxPathDistance.Enabled = false;
				return;
			}
			this.CombatModeSelection("");
			if (this.checkSettingsModeMesh.Checked)
			{
				this.txtSettingsLootMaxPathDistance.Enabled = true;
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x006AF180 File Offset: 0x006AD380
		private void CombatModeSelection(string Mode = "")
		{
			string text = this.selectSettingsCombatMode.Text;
			this.selectSettingsCombatMode.Items.Clear();
			if (Mode == "Flight")
			{
				this.selectSettingsCombatMode.Items.Add("Defensive");
				this.selectSettingsCombatMode.Items.Add("Ignore");
			}
			else
			{
				this.selectSettingsCombatMode.Items.Add("Offensive");
				this.selectSettingsCombatMode.Items.Add("Defensive");
				this.selectSettingsCombatMode.Items.Add("Gather");
				this.selectSettingsCombatMode.Items.Add("Ignore");
				this.selectSettingsCombatMode.Items.Add("PvP (Offensive)");
				this.selectSettingsCombatMode.Items.Add("PvP (Defensive)");
			}
			int num = this.selectSettingsCombatMode.FindStringExact(text);
			if (num == -1)
			{
				this.selectSettingsCombatMode.SelectedIndex = 0;
				return;
			}
			this.selectSettingsCombatMode.SelectedIndex = num;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x006AF298 File Offset: 0x006AD498
		private void richSettingsMobs_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.Modifiers == Keys.Control && e.KeyCode == Keys.V;
			bool flag2 = e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert;
			string text = this.richSettingsMobs.Text;
			if (flag || flag2)
			{
				string text2 = "";
				foreach (string text3 in text.Split(new char[]
				{
					',',
					'\n'
				}).ToList<string>())
				{
					string text4 = text3.Trim().Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
					if (text4.Length != 0)
					{
						text2 = text2 + text4 + "\r\n";
					}
				}
				this.richSettingsMobs.Text = text2;
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x006AF3A0 File Offset: 0x006AD5A0
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.SaveEvent();
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x006AF3B4 File Offset: 0x006AD5B4
		private void SaveEvent()
		{
			string text = this.selectAction.Text;
			if (text.Contains("---"))
			{
				MessageBox.Show("Please select an Action first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			string text2 = "";
			if (!EventManager.IsAction(text, "Interact with..."))
			{
				if (!EventManager.IsAction(text, "Load Profile..."))
				{
					if (!EventManager.IsAction(text, "Load Rotation..."))
					{
						if (EventManager.IsAction(text, "Wait..."))
						{
							if (this.checkWait.Checked && (this.txtWaitSeconds.Text == "" || !Tools.IsNumber(this.txtWaitSeconds.Text, 1, 0, 1, 0)))
							{
								text2 = "Please enter the time you want to wait in seconds.";
							}
							if (this.checkWaitFor.Checked && (this.txtWaitForNameOrID.Text == "" || !Tools.IsNumber(this.txtWaitForMaxSeconds.Text, 1, 0, 1, 0)))
							{
								text2 = "Please enter the name or ID you want to wait for and a Wait Timer higher than 0.";
							}
							if (!Tools.IsNumber(this.txtWaitForMaxSeconds.Text, 1, 0, 1, 0))
							{
								this.txtWaitForMaxSeconds.Text = "30";
							}
						}
						else if (EventManager.IsAction(text, "Add Route..."))
						{
							string text3 = this.selectRecorderRouteType.Text;
							if (text3.Contains("Ghost") && frmProfileEvent.RecordedEventWaypoints.Count == 0)
							{
								text2 = "Please add some Waypoints first.";
							}
							if (text3 == "Flight Master" && this.selectRecorderFlightMasterProfiles.Text == "")
							{
								text2 = "Please select a Profile first.";
							}
							if (text3 == "Mailbox" && this.txtRecorderMailboxReceiver.Text.Length < 3)
							{
								text2 = "Please enter a valid Receiver / Character name.";
							}
							if (this.lblCurrentTarget.Text == "" && frmProfileEvent.Mode != "Edit" && !text3.Contains("Ghost"))
							{
								text2 = "Please select a Target first.";
							}
							if (!text3.Contains("Ghost") && frmProfileEvent.RecordedEventWaypoints.Count == 0)
							{
								if (!this.checkCondition1.Checked && this.checkSettingsExecuteAlways.Checked)
								{
									text2 = "This event would end in an infinite loop.\r\n";
									text2 += "Please set at least one condition or change the execution setting.";
								}
								else if (Tools.StringToVector3(this.lblCurrentTargetLocation.Text) == Vector3.Zero)
								{
									text2 = "The position of the vendor could not be determined.\r\n";
									text2 += "If it is an event from an older update, please delete and recreate the event or use your own route.";
								}
							}
						}
						else if (!EventManager.IsAction(text, "Cast Spell..."))
						{
							if (!EventManager.IsAction(text, "Use Hearthstone..."))
							{
								if (!EventManager.IsAction(text, "Start Fishing..."))
								{
									if (EventManager.IsAction(text, "Use Transport..."))
									{
										if (this.selectUseTransportLoadProfile.Text == "")
										{
											text2 = "Please select a Profile first.";
										}
									}
									else if (!EventManager.IsAction(text, "Execute LUA..."))
									{
										if (EventManager.IsAction(text, "Join Battlegrounds (Classic)..."))
										{
											bool @checked = this.checkBattlegroundClassicWarsongGulch.Checked;
											bool checked2 = this.checkBattlegroundClassicArathiBasin.Checked;
											bool checked3 = this.checkBattlegroundClassicAlteracValley.Checked;
											bool checked4 = this.checkBattlegroundClassicEyeOfTheStorm.Checked;
											bool checked5 = this.checkBattlegroundClassicStrandOfTheAncients.Checked;
											if (!@checked && !checked2 && !checked3 && !checked4)
											{
												text2 = "Please select at least 1 Battleground.";
											}
											if (text2.Length == 0)
											{
												bool flag = true;
												if (@checked && this.selectBattlegroundClassicWarsongGulch.Text == "")
												{
													flag = false;
												}
												if (checked2 && this.selectBattlegroundClassicArathiBasin.Text == "")
												{
													flag = false;
												}
												if (checked3 && this.selectBattlegroundClassicAlteracValley.Text == "")
												{
													flag = false;
												}
												if (checked4 && this.selectBattlegroundClassicEyeOfTheStorm.Text == "")
												{
													flag = false;
												}
												if (checked4 && this.selectBattlegroundClassicStrandOfTheAncients.Text == "")
												{
													flag = false;
												}
												if (!flag)
												{
													text2 = "Please select a Profile first.";
												}
											}
										}
										else if (EventManager.IsAction(text, "Change Profile Settings..."))
										{
											if (!Tools.IsNumber(this.txtSettingsLootDistance.Text, 1, 0, 0, 0))
											{
												this.txtSettingsLootDistance.Text = "40";
											}
											if (!Tools.IsNumber(this.txtSettingsLootMaxPathDistance.Text, 1, 0, 0, 0))
											{
												this.txtSettingsLootMaxPathDistance.Text = "100";
											}
											if (!Tools.IsNumber(this.txtSettingsLootGatherDistance.Text, 1, 0, 0, 0))
											{
												this.txtSettingsLootGatherDistance.Text = "4";
											}
											if (!Tools.IsNumber(this.txtSettingsLootAvoidElitesDistance.Text, 1, 0, 0, 0))
											{
												this.txtSettingsLootAvoidElitesDistance.Text = "40";
											}
											if (!Tools.IsNumber(this.txtSettingsDistancesWaypoint.Text, 1, 0, 0, 0))
											{
												this.txtSettingsDistancesWaypoint.Text = "25";
											}
											if (!Tools.IsNumber(this.txtSettingsDistancesLocation.Text, 1, 0, 0, 0))
											{
												this.txtSettingsDistancesLocation.Text = "40";
											}
											if (!Tools.IsNumber(this.txtSettingsDistancesMobGroup.Text, 1, 0, 0, 0))
											{
												this.txtSettingsDistancesMobGroup.Text = "15";
											}
											if (!Tools.IsNumber(this.txtSettingsDistancesIsReachable.Text.Replace(".", "").Replace(",", ""), 1, 0, 0, 0))
											{
												this.txtSettingsDistancesIsReachable.Text = "4.5";
											}
										}
									}
									else if (!this.CheckLUACommand(this.txtExecuteLUA.Text))
									{
										text2 = "The entered LUA Command is too short.";
									}
								}
								else
								{
									if (!_globals.Keys.ContainsKey("Fishing") || _globals.Keys["Fishing"] == "NotSet")
									{
										text2 = "Please set your Fishing Keybind first.";
									}
									if (this.checkFishingBait.Checked && (!_globals.Keys.ContainsKey("Bait") || _globals.Keys["Bait"] == "NotSet"))
									{
										text2 = "Please set your Bait Keybind first.";
									}
									if (this.checkFishingFacing.Checked && this.lblFishingFacingDirection.Text == "<No Alignment set>")
									{
										text2 = "Please set the position in which you want to align.";
									}
									if (this.checkFishingCondition.Checked)
									{
										if (!this.checkFishingConditionSkillLevel.Checked && !this.checkFishingConditionItemlist.Checked && !this.checkFishingConditionFullBags.Checked)
										{
											this.checkFishingCondition.Checked = false;
										}
										else
										{
											if (this.checkFishingConditionSkillLevel.Checked && this.checkFishingConditionSkillLevel.Checked && !Tools.IsNumber(this.txtFishingConditionSkillLevel.Text, 1, 0, 1, 0))
											{
												text2 = "Please set a valid Skill Level.";
											}
											if (this.checkFishingConditionItemlist.Checked && frmProfileEvent.RecordedFishingItemlist.Count == 0)
											{
												text2 = "Please add some Items to your Itemlist.";
											}
										}
									}
								}
							}
							else if (this.selectUseHearthstoneLoadProfile.Text == "")
							{
								text2 = "Please select a Profile first.";
							}
						}
						else
						{
							string text4 = this.selectCastSpell.Text;
							string text5 = this.txtCastSpellRadius.Text;
							if (text4.Contains("["))
							{
								if (!Tools.IsNumber(text4.Split(new char[]
								{
									'[',
									']'
								})[1], 1, 0, 1, 0))
								{
									text2 = "The selected Spell has no valid Spell ID.";
								}
								if (!Tools.IsNumber(text5, 1, 0, 0, 99))
								{
									text2 = "Please enter a Distance between 1 and 99.";
								}
								if (this.checkCastSpellTarget.Checked && this.txtCastSpellTargetNameOrID.Text == "")
								{
									text2 = "Please enter a Target ID or Name.";
								}
							}
							else
							{
								text2 = "The selected Spell contains no Spell ID.";
							}
						}
					}
					else if (this.selectLoadRotation.Text == "")
					{
						text2 = "Please select a Rotation first.";
					}
				}
				else if (this.selectLoadProfile.Text == "")
				{
					text2 = "Please select a Profile first.";
				}
			}
			else
			{
				if (this.txtInteractNameOrID.Text == "")
				{
					text2 = "Please enter a name or ID you would like to interact with.";
				}
				if (!this.checkInteractClosest.Checked && !this.checkInteractFurthest.Checked)
				{
					text2 = "Please check a range condition.";
				}
			}
			if (text2.Length == 0)
			{
				if (frmProfileEvent.Mode != "Edit")
				{
					if (EventManager.IsAction(text, "Add Route..."))
					{
						try
						{
							frmProfileEvent.EventName = this.selectRecorderRouteType.Text;
							goto IL_83E;
						}
						catch
						{
							frmProfileEvent.EventName = text;
							goto IL_83E;
						}
					}
					frmProfileEvent.EventName = text;
				}
				IL_83E:
				object[] args = new object[]
				{
					frmProfileEvent.Mode,
					frmProfileEvent.Crd,
					frmProfileEvent.EventName,
					frmProfileEvent.EventID
				};
				Tools.OpenForm("frmProfileEventSave", true, "frmProfileEvent", args);
				return;
			}
			MessageBox.Show(text2, Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x006AFC80 File Offset: 0x006ADE80
		public static void CheckKeybinds()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["Fishing"] = "lblFishingKeybind";
			dictionary["Bait"] = "lblFishingBaitKeybind";
			dictionary["VendorMount"] = "lblRecorderVendorMountKeybind";
			foreach (KeyValuePair<string, string> keyValuePair in dictionary)
			{
				if (_globals.Keys.ContainsKey(keyValuePair.Key) && _globals.Keys[keyValuePair.Key] != "NotSet")
				{
					Tools.ControlColor(string.Concat(new string[]
					{
						"Keybind for ",
						keyValuePair.Key,
						": \"",
						_globals.Keys[keyValuePair.Key],
						"\""
					}), keyValuePair.Value, "frmProfileEvent", Color.LimeGreen, null, false);
				}
				else
				{
					Tools.ControlColor("Please set a Keybind for \"" + keyValuePair.Key + "\" in your Keybinds.", keyValuePair.Value, "frmProfileEvent", Color.Red, null, false);
				}
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x006AFDBC File Offset: 0x006ADFBC
		public void HideForm()
		{
			Jack.Core.Settings.WindowProfileEventSize = new Size(base.Width, base.Height);
			frmProfileEvent.RecordingEventRoute = false;
			base.Visible = false;
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x006AFDEC File Offset: 0x006ADFEC
		private void btnTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabAction";
			Tooltip tooltip = new Tooltip();
			string title = "Action";
			string text = "Select your desired Event here. Events with a \"...\" ";
			text += "at the end contain further options for your selection.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpAction";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Condition 1";
			text = "Set a condition for your event. This way you can determine that the event ";
			text += "will only be executed under your conditions.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "grpCondition1";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Condition 2";
			text = "An additional condition is also possible.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "grpCondition2";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Combine your Conditions";
			text = "Determine whether both conditions must apply or whether only one of the two conditions is sufficient.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "grpConditionAndOr1";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Settings";
			text = "These settings are general and apply to the entire event, regardless of your event selection.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = selectTabPage;
			tooltip5.MarkControlName = "grpSettings";
			tooltip5.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x006B0000 File Offset: 0x006AE200
		private void btnActionTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabAction";
			Tooltip tooltip = new Tooltip();
			string title = "Action";
			string text = "Select your desired Event here. Events with a \"...\" ";
			text += "at the end contain further options for your selection.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectAction";
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x006B0098 File Offset: 0x006AE298
		private void btnConditionTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabAction";
			Tooltip tooltip = new Tooltip();
			string title = "Condition 1";
			string text = "Select your condition.\r\n";
			text += "Depending on the selection, the following fields will adjust accordingly.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectCondition1";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Condition 1";
			text = "Specify whether the value in the next field should match, ";
			text += "be below or above. If it is an item ID, select \"Item ID\".";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "selectCondition1Compare";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Condition 1";
			text = "Enter the desired value here.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "txtCondition1Value";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Condition 2";
			text = "If you want to set a second condition, proceed as with the first.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "grpCondition2";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Settings";
			text = "If you have selected both conditions you can here determine ";
			text += "whether both conditions must apply or whether only one of the two conditions is sufficient.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = selectTabPage;
			tooltip5.MarkControlName = "selectConditionAndOr1";
			tooltip5.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x006B02B8 File Offset: 0x006AE4B8
		private void btnSettingsTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabAction";
			Tooltip tooltip = new Tooltip();
			string title = "Execution: Always";
			string text = "Select \"Always\" to specify that this event will be executed every time ";
			text += "your character enters the waypoint where the event is located, respecting your condition.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "checkSettingsExecuteOnce";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Execution: Once";
			text = "If you choose this option, the event will be executed once and ignored afterwards. ";
			text += "This is valid until a \"Load Profile\" event is triggered.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "checkSettingsExecuteAlways";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Faction and Race";
			text = "Specify for which faction and/or race this event should apply.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "selectSettingsFaction";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x006B0414 File Offset: 0x006AE614
		private void btnSelectionTargetTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			Tooltip tooltip = new Tooltip();
			string title = "Selection: Target";
			string text = "Some events require the specification of a target. Select in-game a target and ...";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.MarkControlName = "grpSelectionTarget";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Selection: Target";
			text = "... click here to add the target to your event.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.MarkControlName = "btnTargetSelect";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x006B04C4 File Offset: 0x006AE6C4
		private void btnSelectionMouseoverTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			Tooltip tooltip = new Tooltip();
			string title = "Selection: Mouseover";
			string text = "Some events require the specification of an object or target. ";
			text += "Move your mouse over the object/target in-game and ...";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.MarkControlName = "grpSelectionMouseover";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Selection: Mouseover";
			text = "... click here to add the target to your event.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.MarkControlName = "btnMouseoverSelect";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Selection: Mouseover";
			text = "The selection via mouseover can quickly lead to selecting a different target than intended.\r\n\r\n";
			text += "Click here to temporarily block further selection.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.MarkControlName = "checkMouseoverLock";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x006B05D8 File Offset: 0x006AE7D8
		private void btnSelectionAroundMeTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			Tooltip tooltip = new Tooltip();
			string title = "Around Me";
			string text = "Some events require the specification of an object or target. ";
			text += "If it is an NPC, you will find all NPC's in the immediate vicinity in this list.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.MarkControlName = "selectAroundMeNPCs";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Condition 1";
			text = "If it is an Object, you will find all Objects in the immediate vicinity in this list.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.MarkControlName = "selectAroundMeObjects";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Condition 2";
			text = "If it is an Item, you will find all Items in your bags in this list.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.MarkControlName = "selectAroundMeItems";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x006B06E0 File Offset: 0x006AE8E0
		private void btnRecorderTypeTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabRecorder";
			Tooltip tooltip = new Tooltip();
			string title = "Route Type";
			string text = "Select the additional \"Route Type\" you want to create. ";
			text += "Depending on the selection, further options are unlocked below.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectRecorderRouteType";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Combat Mode";
			text = "Which Combat Mode should be set for this route?";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "selectRecorderCombatMode";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Landing Field";
			text = "Best suited for flight mode.\r\n";
			text += "If your target is inside an enclosed space (house, cave, tent)";
			text += " then set the landing field outside on the ground or in the air.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "btnRecorderSetLandingField";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Recorder";
			text = "Alternatively, you can set your own route.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			if (frmProfileEvent.RecordedEventWaypoints.Count > 0)
			{
				tooltip4.MarkControlName = "btnRecordStart";
			}
			else
			{
				tooltip4.MarkControlName = "panelRecorderInfo";
			}
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Waypoints";
			text = "In this list all recorded waypoints are displayed. ";
			text += "You can change them as you wish and edit them at any time.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = selectTabPage;
			tooltip5.MarkControlName = "listWaypoints";
			tooltip5.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x006B0928 File Offset: 0x006AEB28
		private void btnRecorderVendorTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabRecorder";
			Tooltip tooltip = new Tooltip();
			string title = "Vendor";
			string text = "Select here general categories by color of the item for sale.\r\n\r\n";
			text += "Jack will not sell items that are necessary for your character such as reagents or items ";
			text += "obtained through professions like Herbs, Ores, Leather, etc.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "checkRecorderVendorSellWhites";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Vendor: Whitelist";
			text = "To be sure that items are not sold you can create a whitelist via this menu.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "btnRecorderVendorWhitelist";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Vendor: Buylist";
			text = "Click here to set a shopping list.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "btnRecorderVendorBuylist";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x006B0A84 File Offset: 0x006AEC84
		private void btnRecorderFlightMasterTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabRecorder";
			Tooltip tooltip = new Tooltip();
			string title = "Flight Master: Destination";
			string text = "Select the arrival destination.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectRecorderFlightMasterFlightPoints";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Flight Master: Load Profile";
			text = "Select the profile that should be loaded once arrived.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "selectRecorderFlightMasterProfiles";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x006B0B6C File Offset: 0x006AED6C
		private void btnRecorderMailboxTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabRecorder";
			Tooltip tooltip = new Tooltip();
			string title = "Mailbox: Send Items";
			string text = "Select here general categories by color of the item for sending.\r\n\r\n";
			text += "Jack will not send items that are necessary for your character such as reagents.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "checkRecorderMailboxSendWhites";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Mailbox: Sendlist";
			text = "This button allows you to create a list for sending specific items.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "btnRecorderMailboxSendlist";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Mailbox: Receiver";
			text = "Enter the character name to which the items should be sent.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "txtRecorderMailboxReceiver";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x006B0CBC File Offset: 0x006AEEBC
		private void btnCastSpellTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabCastSpell";
			Tooltip tooltip = new Tooltip();
			string title = "Cast Spell";
			string text = "Select the spell to be executed.\r\n";
			text += "The spell must be on your lower or upper action bar. Jack does the rest.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectCastSpell";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Mob Radius";
			text = "Checks if there is an mob in the radius specified here. If not, the spell will not be executed.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "txtCastSpellRadius";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Mob Radius";
			text = "To execute the spell in any case, select this option.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "checkCastSpellNoRadiusCheck";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x006B0E0C File Offset: 0x006AF00C
		private void btnInteractWithTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabInteractWith";
			Tooltip tooltip = new Tooltip();
			string title = "Interact with ...";
			string text = "Enter here the name or ID of the object or target you want to interact with.\r\n\r\n";
			text = text + Tools.HTMLColor("TIP!", "DeepSkyBlue") + "\r\n";
			text += "Use one of the options in the left menu (Target, Mouseover or Around Me) to easily select an object or target.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "txtInteractNameOrID";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Start Attack";
			text = "Set this option to set Jack into Combat Mode and starting your rotation until the target is dead.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "checkInteractAttack";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x006B0F1C File Offset: 0x006AF11C
		private void btnFishingFacingTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabFishing";
			Tooltip tooltip = new Tooltip();
			string title = "Fishing: Alignment";
			string text = "Sets the orientation from the shore to the water.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpFishingFacing";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Set Alignment";
			text = "Jump into the water and click here.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "btnFishingFacingDirection";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x006B1004 File Offset: 0x006AF204
		private void btnUseTransportTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabUseTransport";
			Tooltip tooltip = new Tooltip();
			string title = "Transport";
			string text = Tools.HTMLColor("Elevator, Ship or Zepelin", "DeepSkyBlue") + "\r\n";
			text += "Select a waypoint in front of one of these transports and use this event to get from A to B. ";
			text += "The waypoint must be within 25 yds. of the transport and your character must be facing ";
			text += "the entrance of the transport.\r\n\r\n";
			text += "Select here the profile to be loaded after the transport.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpUseTransportLoadProfile";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Turn";
			text = "Choose how many degrees your character should turn to face the exit of the transport ";
			text += "after entering it.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "grpUseTransportTurn";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x006B113C File Offset: 0x006AF33C
		private void btnExecuteLUATooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabExecuteLUA";
			Tooltip tooltip = new Tooltip();
			string title = "Examples";
			string text = "Choose one of the given examples to quickly use a frequently used function.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectExecuteLUAExamples";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "LUA Command";
			text = "If a command starts with a / at the beginning, this command is executed by Jack as a macro. ";
			text += "Mostly these are commands that require a hardware event like pressing a key.\r\n\r\nExample:\r\n";
			text += "/use Hearthstone\r\n\r\n";
			text += "Commands without / can address API functions directly.\r\n\r\nExample:\r\n";
			text += "local unitClass = UnitClass(\"player\"); print(unitClass);";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "txtExecuteLUA";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x006B1254 File Offset: 0x006AF454
		private void btnTooltipBattlegroundClassic_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabBattlegroundClassic";
			Tooltip tooltip = new Tooltip();
			string title = "Battlefield";
			string text = "Choose the Battlegrounds you want to join.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "checkBattlegroundClassicWarsongGulch";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Battlefield Profile";
			text = "Choose the profile to load once you enter the battlefield.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "selectBattlegroundClassicWarsongGulch";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0066A478 File Offset: 0x00668678
		IntPtr method_0()
		{
			return base.Handle;
		}

		// Token: 0x040004AA RID: 1194
		private bool NoCheck = true;

		// Token: 0x040004AB RID: 1195
		public static bool AutoSwitchTab = true;

		// Token: 0x040004AC RID: 1196
		public static string Mode = "";

		// Token: 0x040004AD RID: 1197
		public static string EventName = "";

		// Token: 0x040004AE RID: 1198
		public static int EventID = 0;

		// Token: 0x040004AF RID: 1199
		public static Vector3 Crd;

		// Token: 0x040004B0 RID: 1200
		public static Vector3 LandingField = Vector3.Zero;

		// Token: 0x040004B1 RID: 1201
		public static bool RecordingEventRoute = false;

		// Token: 0x040004B2 RID: 1202
		public static List<Vector3> RecordedEventWaypoints = new List<Vector3>();

		// Token: 0x040004B3 RID: 1203
		public static List<string> RecordedWhitelist = new List<string>();

		// Token: 0x040004B4 RID: 1204
		public static List<string> RecordedBuylist = new List<string>();

		// Token: 0x040004B5 RID: 1205
		public static List<string> RecordedSendlist = new List<string>();

		// Token: 0x040004B6 RID: 1206
		public static List<string> RecordedFishingItemlist = new List<string>();

		// Token: 0x040004B7 RID: 1207
		private static Dictionary<UInt128, string> PlayerList = new Dictionary<UInt128, string>();

		// Token: 0x040004B8 RID: 1208
		private static Dictionary<UInt128, string> Npcs = new Dictionary<UInt128, string>();

		// Token: 0x040004B9 RID: 1209
		private static Dictionary<UInt128, string> GameObjects = new Dictionary<UInt128, string>();

		// Token: 0x040004BA RID: 1210
		private static Dictionary<UInt128, string> Items = new Dictionary<UInt128, string>();

		// Token: 0x040004BB RID: 1211
		private static Dictionary<string, string> ExecuteLUAExamples = new Dictionary<string, string>();

		// Token: 0x040004BC RID: 1212
		public static object _lock = new object();

		// Token: 0x040004BD RID: 1213
		public static Events Event = null;
	}
}
