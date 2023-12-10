using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Models;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x020000A7 RID: 167
	public partial class frmProfile : Form
	{
		// Token: 0x0600110A RID: 4362 RVA: 0x006DB000 File Offset: 0x006D9200
		public frmProfile()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			this.listStuckPaths.Controls.Add(this.txtStuckPathsEditList);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x006DB048 File Offset: 0x006D9248
		private void frmProfile_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Path Manager", true, true, true, true, false, false);
			this.SetWindowSizeAndPosition();
			this.tabs.Controls.Remove(this.tabClimbSpots);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x006DB084 File Offset: 0x006D9284
		private void SetWindowSizeAndPosition()
		{
			if (Jack.Core.Settings.WindowProfileSize.Width != 0 && Jack.Core.Settings.WindowProfileSize.Height != 0)
			{
				base.Width = Jack.Core.Settings.WindowProfileSize.Width;
				base.Height = Jack.Core.Settings.WindowProfileSize.Height;
			}
			if (Jack.Core.Settings.WindowProfileLocation.X != 0 && Jack.Core.Settings.WindowProfileLocation.Y != 0)
			{
				base.Location = Jack.Core.Settings.WindowProfileLocation;
			}
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmProfile_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x006DB0EC File Offset: 0x006D92EC
		private void listBlacklistObjects_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x006DB0EC File Offset: 0x006D92EC
		private void listBlacklist_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x006DB0EC File Offset: 0x006D92EC
		private void listWaypoints_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x006DB0EC File Offset: 0x006D92EC
		private void listEvents_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void listClimbSpots_Resize(object sender, EventArgs e)
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x006DB0EC File Offset: 0x006D92EC
		private void listStuckPaths_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x006DB100 File Offset: 0x006D9300
		private void CenterListViewColumns()
		{
			Tools.ColorListViewHeader(ref this.listWaypoints, null);
			Tools.CenterListViewColumns(this.listWaypoints, new int[]
			{
				40,
				-1,
				40
			});
			Tools.ColorListViewHeader(ref this.listEvents, null);
			Tools.CenterListViewColumns(this.listEvents, new int[]
			{
				40
			});
			Tools.ColorListViewHeader(ref this.listBlacklist, null);
			Tools.CenterListViewColumns(this.listBlacklist, null);
			Tools.ColorListViewHeader(ref this.listBlacklistObjects, null);
			ListView listview = this.listBlacklistObjects;
			int[] array = new int[3];
			array[0] = -1;
			array[1] = 60;
			Tools.CenterListViewColumns(listview, array);
			Tools.ColorListViewHeader(ref this.listStuckPaths, null);
			Tools.CenterListViewColumns(this.listStuckPaths, new int[]
			{
				0,
				-1,
				60,
				60,
				60,
				60
			});
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x006DB1C0 File Offset: 0x006D93C0
		private void frmProfile_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				if (_globals.IsPremiumProfile)
				{
					this.HideForm();
					return;
				}
				this.ResetControls();
				this.LoadSettings();
				if (frmMainProfiles.DisplayWaypointsAfterEditorLoaded)
				{
					frmMainOverlay.EnableOverlayWaypoints(true);
					frmProfile.UpdateAndShowOverlayGoals();
				}
			}
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x006DB20C File Offset: 0x006D940C
		private void ResetControls()
		{
			this.listWaypoints.Items.Clear();
			this.listEvents.Items.Clear();
			this.NoCheck = true;
			this.checkRecorderAutoRecord.Checked = Jack.Core.Settings.RecorderAutoRecord;
			this.NoCheck = false;
			this.txtRecorderAutoRecordDistance.Text = Jack.Core.Settings.RecorderAutoDistance.ToString();
			this.txtRecorderShowLast.Text = Jack.Core.Settings.RecorderShowMaxLastWaypoints.ToString();
			this.checkRecorderAutoQuest.Checked = Jack.Core.Settings.RecorderQuestTracker;
			this.selectSettingsCombatMode.SelectedIndex = 0;
			this.selectSettingsWaypointMode.SelectedIndex = 0;
			this.checkSettingsModeFollowFleeingTarget.Checked = false;
			this.checkSettingsModeMesh.Checked = true;
			this.checkSettingsGroundMount.Checked = false;
			this.checkSettingsFlightMount.Checked = false;
			this.checkSettingsLoot.Checked = true;
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
			double num = 4.5;
			this.txtSettingsDistancesIsReachable.Text = num.ToString("0.0");
			this.richMobs.Text = "";
			this.listBlacklist.Items.Clear();
			this.listBlacklistObjects.Items.Clear();
			this.btnBlacklistNameOrID.Text = "Extended Blacklist";
			this.btnWhitelistNameOrID.Text = "Whitelist";
			this.listStuckPaths.Items.Clear();
			this.btnStuckPathsStart.FillColor = Color.FromArgb(0, 119, 230);
			this.btnStuckPathsStart.Text = "Start";
			this.btnStuckPathsAroundMe.FillColor = Color.FromArgb(0, 119, 230);
			this.btnStuckPathsAroundMe.Text = "Around own Location";
			this.btnStuckPathsAroundMeSet.Enabled = false;
			this.txtExpertLootDelay.Text = "100";
			this.txtExpertResurrectDelay.Text = "1";
			this.txtExpertMountDelay.Text = "50";
			this.trackExpertFlightSens.Value = 5;
			this.lblExpertFlightSensData.Text = "5";
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x006DB578 File Offset: 0x006D9778
		private void LoadSettings()
		{
			_globals.MyHandleProfile = this.method_0();
			frmProfile.ReleaseActivities();
			this.LoadProfile();
			this.NoCheck = true;
			this.LoadProfileSettings();
			this.NoCheck = false;
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x006DB5B0 File Offset: 0x006D97B0
		public static void ReleaseActivities()
		{
			if (Walk.Runs || _globals.AutoStart || _globals.Start)
			{
				_globals.AutoStart = false;
				_globals.Start = false;
				string name = Tools.RandomTimer("ReleaseActivities");
				Jack.Engine.Timer.Set(name, 3000);
				while (Walk.Runs && Jack.Engine.Timer.Check(name) != 0)
				{
					Thread.Sleep(10);
				}
				if (_globals.Start || Walk.Runs)
				{
					MessageBox.Show("Jack could not be stopped.\r\nPlease make sure to stop Jack first before continuing.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x006DB630 File Offset: 0x006D9830
		private void LoadProfile()
		{
			object @lock = frmProfile._lock;
			lock (@lock)
			{
				frmProfile.RecordedWaypoints.Clear();
				frmProfile.RecordedEvents.Clear();
				frmProfile.RecordedBlacklist.Clear();
				frmProfile.RecordedBlacklistNameOrID.Clear();
				frmProfile.RecordedWhitelistNameOrID.Clear();
				frmProfile.ProfileSettings.Clear();
				this.lblProfileName.Visible = false;
				if (frmProfile.Mode == "Edit")
				{
					Json.LoadProfile(frmProfile.ProfileFolder + frmProfile.ProfileName, false, true, false);
					this.lblProfileName.Visible = true;
					this.lblProfileName.Text = frmProfile.ProfileName;
					if (_globals.Waypoints.Count > 0)
					{
						foreach (Vector3 item in _globals.Waypoints)
						{
							frmProfile.RecordedWaypoints.Add(item);
						}
					}
					if (_globals.Events.Count > 0)
					{
						foreach (Events item2 in _globals.Events)
						{
							frmProfile.RecordedEvents.Add(item2);
						}
						foreach (Events events in frmProfile.RecordedEvents)
						{
							if (events.ID == 0)
							{
								events.ID = frmProfileEventSave.GenerateID;
							}
						}
					}
					this.btnRecorderSave.Enabled = true;
				}
			}
			_globals.ShowProfile = false;
			_globals.ShowRecordedProfile = true;
			Overlay.MenuCrdIndexAutoSelect = -1;
			new Thread(new ThreadStart(this.OverlayMenu))
			{
				IsBackground = true
			}.Start();
			frmProfile.UpdateListWaypoints(-1);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x006DB868 File Offset: 0x006D9A68
		private void LoadProfileSettings()
		{
			if (_globals.ProfileSettings.Count > 0 && frmProfile.Mode == "Edit")
			{
				frmProfile.ProfileSettings.Add(_globals.ProfileSettings[0]);
				ProfileSettings profileSettings = frmProfile.ProfileSettings[0];
				this.selectSettingsCombatMode.SelectedIndex = profileSettings.CombatModeIndex;
				this.selectSettingsWaypointMode.SelectedIndex = profileSettings.WaypointModeIndex;
				this.checkSettingsModeFollowFleeingTarget.Checked = profileSettings.FollowFleeingTarget;
				this.checkSettingsModeMesh.Checked = profileSettings.ModeMesh;
				this.checkSettingsGroundMount.Checked = profileSettings.GroundMount;
				this.checkSettingsFlightMount.Checked = profileSettings.FlightMount;
				this.checkSettingsLoot.Checked = profileSettings.Loot;
				this.checkSettingsLootSkinning.Checked = profileSettings.Skinning;
				this.checkSettingsLootHerbalism.Checked = profileSettings.Herbalism;
				this.checkSettingsLootMining.Checked = profileSettings.Mining;
				this.checkSettingsLootGatherMobs.Checked = profileSettings.GatherMobs;
				int count = profileSettings.QuestItems.Count;
				if (count > 0)
				{
					string text = "";
					foreach (string str in profileSettings.QuestItems)
					{
						text = text + str + "\r\n";
					}
					this.txtSettingsLootQuestItems.Text = text;
				}
				this.txtSettingsLootDistance.Text = profileSettings.DistanceLoot.ToString();
				this.txtSettingsLootMaxPathDistance.Text = profileSettings.DistancePath.ToString();
				this.txtSettingsLootGatherDistance.Text = profileSettings.DistanceLootGather.ToString();
				this.txtSettingsLootAvoidElitesDistance.Text = profileSettings.DistanceAvoidElites.ToString();
				this.txtSettingsDistancesWaypoint.Text = profileSettings.DistanceWaypoint.ToString();
				this.txtSettingsDistancesLocation.Text = profileSettings.DistanceLocation.ToString();
				this.txtSettingsDistancesMobGroup.Text = profileSettings.DistanceMobGroup.ToString();
				this.txtSettingsDistancesIsReachable.Text = profileSettings.DistanceIsReachable.ToString("0.0");
				count = profileSettings.AttackableMobs.Count;
				if (profileSettings.AttackableMobs != null && profileSettings.AttackableMobs.Count > 0)
				{
					string text2 = "";
					foreach (string str2 in profileSettings.AttackableMobs)
					{
						text2 = text2 + str2 + "\r\n";
					}
					this.richMobs.Text = text2;
				}
				count = profileSettings.Blacklist.Count;
				if (count > 0)
				{
					foreach (KeyValuePair<string, Vector3> keyValuePair in profileSettings.Blacklist)
					{
						frmProfile.RecordedBlacklist.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				count = profileSettings.BlacklistNameOrID.Count;
				if (count > 0)
				{
					foreach (string item in profileSettings.BlacklistNameOrID)
					{
						frmProfile.RecordedBlacklistNameOrID.Add(item);
					}
					this.btnBlacklistNameOrID.Text = "Extended Blacklist (" + count.ToString() + ")";
				}
				count = profileSettings.WhitelistNameOrID.Count;
				if (count > 0)
				{
					foreach (string item2 in profileSettings.WhitelistNameOrID)
					{
						frmProfile.RecordedWhitelistNameOrID.Add(item2);
					}
					this.btnWhitelistNameOrID.Text = "Whitelist (" + count.ToString() + ")";
				}
				this.txtExpertLootDelay.Text = profileSettings.ExpertLootDelay.ToString();
				this.txtExpertResurrectDelay.Text = profileSettings.ExpertResurrectDelay.ToString();
				this.txtExpertMountDelay.Text = profileSettings.ExpertMountDelay.ToString();
				this.trackExpertFlightSens.Value = profileSettings.ExpertFlightTolerance;
				this.lblExpertFlightSensData.Text = profileSettings.ExpertFlightTolerance.ToString();
				frmProfile.UpdateListBlacklist();
			}
			this.UpdateListStuckPaths(-1);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x006DBD20 File Offset: 0x006D9F20
		private void checkRecorderAutoRecord_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkRecorderAutoRecord.Checked;
			this.txtRecorderAutoRecordDistance.Enabled = @checked;
			this.txtRecorderShowLast.Enabled = @checked;
			if (!this.NoCheck)
			{
				Jack.Core.Settings.RecorderAutoRecord = @checked;
				return;
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x006DBD60 File Offset: 0x006D9F60
		private void checkRecorderAutoQuest_CheckedChanged(object sender, EventArgs e)
		{
			if (Jack.Core.Settings.RecorderQuestTracker = this.checkRecorderAutoQuest.Checked)
			{
				this.StartQuestTracker();
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x006DBD88 File Offset: 0x006D9F88
		private void txtRecorderAutoRecordDistance_TextChanged(object sender, EventArgs e)
		{
			bool flag = false;
			int num;
			if (int.TryParse(this.txtRecorderAutoRecordDistance.Text, out num) && num > 0 && num <= 100)
			{
				Jack.Core.Settings.RecorderAutoDistance = num;
				flag = true;
			}
			if (!flag)
			{
				this.txtRecorderAutoRecordDistance.Text = "15";
				this.txtRecorderAutoRecordDistance.SelectAll();
			}
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x006DBDDC File Offset: 0x006D9FDC
		private void txtRecorderShowLast_TextChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			bool flag = false;
			int num;
			if (int.TryParse(this.txtRecorderShowLast.Text, out num) && num > 0 && num <= 999)
			{
				Jack.Core.Settings.RecorderShowMaxLastWaypoints = num;
				flag = true;
			}
			if (!flag)
			{
				this.txtRecorderShowLast.Text = "20";
				this.txtRecorderShowLast.SelectAll();
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x006DBE3C File Offset: 0x006DA03C
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

		// Token: 0x06001121 RID: 4385 RVA: 0x006DBEAC File Offset: 0x006DA0AC
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

		// Token: 0x06001122 RID: 4386 RVA: 0x006DBF1C File Offset: 0x006DA11C
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

		// Token: 0x06001123 RID: 4387 RVA: 0x006DBF8C File Offset: 0x006DA18C
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

		// Token: 0x06001124 RID: 4388 RVA: 0x006DBFFC File Offset: 0x006DA1FC
		private void txtSettingsLootQuestItems_MouseClick(object sender, MouseEventArgs e)
		{
			if (!_globals.ModuleGather)
			{
				CustomUI.DialogModule(base.Name);
				this.imgModuleGather.Focus();
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x006DC028 File Offset: 0x006DA228
		private void btnRecorderStart_Click(object sender, EventArgs e)
		{
			this.StartStop();
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x006DC03C File Offset: 0x006DA23C
		private void StartStop()
		{
			if (_globals.Ready)
			{
				if (_globals.Record)
				{
					_globals.Record = false;
					frmProfile.UpdateListWaypoints(-1);
					this.ResetControlsOnStopOrClose();
					if (frmProfile.RecordedWaypoints.Count > 0)
					{
						Tools.Control("", "btnRecorderSave", "frmProfile", true, false, false, false, 0);
					}
				}
				else
				{
					this.SaveSettings();
					_globals.Record = true;
					_globals.ShowProfile = false;
					new Thread(new ThreadStart(this.Record))
					{
						IsBackground = true
					}.Start();
					Window.Activate(null);
					Tools.ControlColor("Stop", "btnRecorderStart", "frmProfile", Color.Red, null, true);
					Tools.Control("", "btnRecorderSingle", "frmProfile", true, false, false, false, 0);
					Tools.Control("", "btnRecorderSave", "frmProfile", false, false, false, false, 0);
					Tools.Control("", "txtRecorderAutoRecordDistance", "frmProfile", false, false, false, false, 0);
					Tools.Control("", "txtRecorderShowLast", "frmProfile", false, false, false, false, 0);
					if (Jack.Core.Settings.RecorderQuestTracker)
					{
						this.StartQuestTracker();
						return;
					}
				}
			}
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x006DC15C File Offset: 0x006DA35C
		private void ResetControlsOnStopOrClose()
		{
			Tools.ControlColor("Start Recording", "btnRecorderStart", "frmProfile", Color.FromArgb(0, 119, 230), null, true);
			Tools.Control("", "btnRecorderSingle", "frmProfile", false, false, false, false, 0);
			Tools.Control("", "txtRecorderAutoRecordDistance", "frmProfile", true, false, false, false, 0);
			Tools.Control("", "txtRecorderShowLast", "frmProfile", true, false, false, false, 0);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x006DC1D8 File Offset: 0x006DA3D8
		private void Record()
		{
			bool flag = true;
			if (frmProfile.RecordedWaypoints.Count > 0 && frmProfile.Mode != "New")
			{
				flag = false;
			}
			if (Jack.Core.Settings.RecorderAutoRecord && flag)
			{
				this.AddWaypoint();
			}
			while (_globals.Record)
			{
				if (!frmProfileEvent.RecordingEventRoute && Jack.Core.Settings.RecorderAutoRecord && frmProfile.RecordedWaypoints.Count > 0 && JackMath.Distance(frmProfile.RecordedWaypoints.LastOrDefault<Vector3>(), true, true, true) >= (double)Jack.Core.Settings.RecorderAutoDistance)
				{
					this.AddWaypoint();
				}
				Thread.Sleep(10);
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x006DC264 File Offset: 0x006DA464
		private void StartQuestTracker()
		{
			new Thread(new ThreadStart(this.QuestTracker))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x006DC290 File Offset: 0x006DA490
		private void QuestTracker()
		{
			object lockQuestTracker = frmProfile._lockQuestTracker;
			lock (lockQuestTracker)
			{
				Addon.LUA("_setQuestMode(\"Record\")", "0", false, false);
				bool flag2 = false;
				while (_globals.Ready && _globals.Record && Jack.Core.Settings.RecorderQuestTracker)
				{
					if (flag2)
					{
						flag2 = false;
						Frames.ResetText("jkQuest");
					}
					int num = 0;
					while (num < 10 && _globals.Ready && _globals.Record && Jack.Core.Settings.RecorderQuestTracker)
					{
						Thread.Sleep(100);
						num++;
					}
					string text = Frames.GetText("jkQuest", "jkQuestText");
					if (text.Length != 0 && text.Contains(";"))
					{
						string[] array = text.Split(new char[]
						{
							';'
						});
						if (array.Length == 0)
						{
							Tools.Console("The Quest-Return seems broken. (" + text + ").", "Red", "richConsole", "frmMain", true);
							flag2 = true;
						}
						else
						{
							flag2 = true;
							string text2 = array[0];
							string text3 = array[1];
							string text4 = array[2];
							string text5 = array[3];
							bool flag3 = false;
							if (Tools.IsNumber(text4, 1, 0, 1, 0))
							{
								if (text5.Length == 0)
								{
									Tools.Console("Couldn't catch Quest Name.", "Red", "richConsole", "frmMain", true);
								}
								else
								{
									object @lock;
									if (!Tools.IsNumber(text3, 1, 0, 1, 0))
									{
										bool flag4 = false;
										StringBuilder stringBuilder = new StringBuilder();
										stringBuilder.Append("Is this an Object?");
										stringBuilder.Append("\r\n");
										stringBuilder.Append("Get as close as possible to the object.");
										Tools.CustomMessageBox("Take/Turn-In Quest by Object", stringBuilder.ToString(), "Cancel", "Take Quest", "frmProfile", true);
										if (frmMessageBox.Button2Pressed)
										{
											List<UInt128> list = new List<UInt128>();
											foreach (Objects objects in ObjectManager.GetGameObjects)
											{
												list.Add(objects.GUID128);
											}
											Objects closestObject = ObjectManager.GetClosestObject(list);
											if (closestObject == null)
											{
												MessageBox.Show("Couldn't find an object.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
												flag4 = true;
											}
											else
											{
												string str = "";
												int num2 = 0;
												@lock = ObjectManager._lock;
												lock (@lock)
												{
													str = closestObject.Name;
													num2 = closestObject.DisplayID;
												}
												if (MessageBox.Show("\"" + str + "\"\r\n\r\nIs this the right object?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
												{
													text3 = num2.ToString();
													flag3 = true;
												}
												else
												{
													flag4 = true;
												}
											}
										}
										else
										{
											flag4 = true;
										}
										if (flag4)
										{
											continue;
										}
									}
									Vector3 positionVector = ObjectManager.Me.PositionVector3;
									Vector3 vector = default(Vector3);
									double num3 = 5.0;
									foreach (Vector3 vector2 in frmProfile.RecordedWaypoints)
									{
										double num4 = JackMath.Distance(positionVector, vector2, true, true, true);
										if (num4 <= num3)
										{
											num3 = num4;
											vector = vector2;
										}
									}
									if (vector == default(Vector3))
									{
										this.AddWaypoint();
										vector = frmProfile.RecordedWaypoints.LastOrDefault<Vector3>();
									}
									string text6 = "";
									if (flag3)
									{
										text6 = " (Object)";
									}
									Events events = new Events();
									events.Vector3 = vector;
									events.Name = string.Concat(new string[]
									{
										text2,
										" Quest",
										text6,
										": ",
										text5
									});
									events.ID = frmProfileEventSave.GenerateID;
									events.Action = text2 + " Quest";
									events.QuestNPCID = Convert.ToInt32(text3);
									events.QuestID = Convert.ToInt32(text4);
									events.QuestName = text5;
									events.QuestFromObject = flag3;
									@lock = frmProfile._lock;
									lock (@lock)
									{
										frmProfile.RecordedEvents.Add(events);
									}
									frmProfile.UpdateListWaypoints(this.listWaypoints.Items.Count - 1);
								}
							}
							else
							{
								Tools.Console("Couldn't catch Quest ID.", "Red", "richConsole", "frmMain", true);
							}
						}
					}
				}
				Addon.LUA("_setQuestMode(\"Play\")", "0", false, false);
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x006DC770 File Offset: 0x006DA970
		public static void UpdateListWaypoints(int PreSelect = -1)
		{
			new Thread(delegate()
			{
				frmProfile.UpdateListWaypointsThread(PreSelect);
			})
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x006DC7A8 File Offset: 0x006DA9A8
		private static void UpdateListWaypointsThread(int PreSelect = -1)
		{
			string text = "";
			string text2 = "";
			int num = 1;
			string text3 = "";
			Dictionary<string[], string[]> dictionary = new Dictionary<string[], string[]>();
			foreach (Vector3 vector in frmProfile.RecordedWaypoints.ToList<Vector3>())
			{
				text = "";
				text2 = "";
				text3 = "";
				if (ObjectManager.GetEvent(vector) != null)
				{
					List<string> eventNames = ObjectManager.GetEventNames(vector, false);
					text = eventNames.Count.ToString();
					text3 = "Green";
					int num2 = 0;
					using (List<string>.Enumerator enumerator2 = eventNames.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string text4 = enumerator2.Current;
							if (num2 != 0)
							{
								text2 = text2 + ", " + text4;
							}
							else
							{
								text2 += text4;
							}
							num2++;
						}
						goto IL_D4;
					}
					goto IL_C6;
				}
				goto IL_C6;
				IL_D4:
				string[] key = new string[]
				{
					num.ToString(),
					text2,
					text
				};
				dictionary.Add(key, new string[]
				{
					"",
					text3
				});
				num++;
				continue;
				IL_C6:
				text2 = vector.ToString();
				goto IL_D4;
			}
			Tools.ControlListViewCreate(dictionary, "listWaypoints", "frmProfile", true, PreSelect, null);
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x006DC910 File Offset: 0x006DAB10
		private void UpdateListBoxWaypoint(Vector3 Crd)
		{
			int num = 1;
			using (List<Vector3>.Enumerator enumerator = frmProfile.RecordedWaypoints.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == Crd)
					{
						break;
					}
					num++;
				}
			}
			string text = "";
			Color color = default(Color);
			int count = ObjectManager.GetEventNames(Crd, true).Count;
			if (count > 0)
			{
				text = count.ToString();
				color = Color.FromArgb(212, 255, 191);
			}
			else
			{
				color = Color.White;
			}
			Tools.Control(new string[]
			{
				num.ToString(),
				string.Concat(new string[]
				{
					num.ToString(),
					"|",
					Crd.ToString(),
					"|",
					text.ToString()
				})
			}, "listWaypoints", "frmProfile", true, false, false, false, 0);
			Tools.ControlColor("", "listWaypoints", "frmProfile", color, new string[]
			{
				Crd.ToString()
			}, false);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x006DCA44 File Offset: 0x006DAC44
		private void UpdateListBoxEvents()
		{
			Tools.Control(null, "listEvents", "frmProfile", true, false, true, false, 0);
			if (this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0 && frmProfile.RecordedEvents.Count > 0)
			{
				List<string> eventNames = ObjectManager.GetEventNames(frmProfile.RecordedWaypoints[this.listWaypoints.SelectedIndices[0]], true);
				if (eventNames.Count > 0)
				{
					int num = 1;
					foreach (string str in eventNames)
					{
						Tools.Control(new string[]
						{
							num.ToString(),
							num.ToString() + "|" + str
						}, "listEvents", "frmProfile", true, false, false, false, 0);
						num++;
					}
				}
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x006DCB48 File Offset: 0x006DAD48
		private void listWaypoints_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.UpdateListBoxEvents();
			if (this.listWaypoints.SelectedItems.Count == 0)
			{
				object @lock = frmProfile._lock;
				lock (@lock)
				{
					frmProfile.SelectedWaypoints.Clear();
					Tools.CloseForm("frmOverlayMenu", Array.Empty<object>());
				}
			}
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x006DCBB4 File Offset: 0x006DADB4
		public static void UpdateListBlacklist()
		{
			new Thread(new ThreadStart(frmProfile.smethod_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x006DCBE0 File Offset: 0x006DADE0
		private void listBlacklistObjects_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = true;
			if (this.listBlacklistObjects.SelectedItems.Count > 0 && this.listBlacklistObjects.SelectedIndices.Count > 0)
			{
				Objects getObject = this.GetObject;
				if (getObject != null)
				{
					Vector3 vector = default(Vector3);
					string text = "";
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						text = getObject.Name;
						vector = getObject.PositionVector3;
					}
					if (vector != default(Vector3))
					{
						flag = false;
						if (text.Length == 0)
						{
							text = "N/A";
						}
						Overlay.SetGraphic(ObjectManager.Me.PositionVector3, vector, "Record", "Red", text, true);
					}
				}
			}
			if (flag)
			{
				Overlay.ClearGraphic("Record");
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x006DCCC0 File Offset: 0x006DAEC0
		private Objects GetObject
		{
			get
			{
				string text = this.listBlacklistObjects.SelectedItems[0].SubItems[2].Text;
				if (text != null && text.Length > 0)
				{
					return ObjectManager.GetObjectByGUID(Tools.StringToInt128(text));
				}
				return null;
			}
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x006DCD08 File Offset: 0x006DAF08
		private void SaveSettings()
		{
			bool @checked = this.checkRecorderAutoRecord.Checked;
			string text = this.txtRecorderAutoRecordDistance.Text;
			int recorderAutoDistance = 25;
			string text2 = this.txtRecorderShowLast.Text;
			int recorderShowMaxLastWaypoints = 20;
			if (text.Length > 0 && Convert.ToInt32(text) > 0 && Convert.ToInt32(text) <= 300)
			{
				recorderAutoDistance = Convert.ToInt32(text);
			}
			else
			{
				this.txtRecorderAutoRecordDistance.Text = recorderAutoDistance.ToString();
			}
			if (text2.Length > 0 && Convert.ToInt32(text2) > 0 && Convert.ToInt32(text2) <= 999)
			{
				recorderShowMaxLastWaypoints = Convert.ToInt32(text2);
			}
			else
			{
				this.txtRecorderShowLast.Text = recorderShowMaxLastWaypoints.ToString();
			}
			Jack.Core.Settings.RecorderAutoRecord = @checked;
			Jack.Core.Settings.RecorderAutoDistance = recorderAutoDistance;
			Jack.Core.Settings.RecorderShowMaxLastWaypoints = recorderShowMaxLastWaypoints;
			Jack.Core.Settings.Save();
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x006DCDC8 File Offset: 0x006DAFC8
		private void listWaypoints_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.DeleteWaypoints();
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x006DCDE8 File Offset: 0x006DAFE8
		private void DeleteWaypoints()
		{
			if (this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
			{
				ListView.SelectedIndexCollection selectedIndices = this.listWaypoints.SelectedIndices;
				int count = selectedIndices.Count;
				int num = -1;
				int index = count;
				object @lock;
				while (index-- > 0)
				{
					int num2 = selectedIndices[index];
					Vector3 SelectedCrd = frmProfile.RecordedWaypoints[num2];
					num = num2;
					@lock = frmProfile._lock;
					lock (@lock)
					{
						if (frmProfile.RecordedEvents.Count > 0)
						{
							Events Event = ObjectManager.GetEvent(SelectedCrd);
							frmProfile.RecordedEvents.RemoveAll((Events evt) => evt.Vector3 == SelectedCrd && evt.ID == Event.ID);
						}
						frmProfile.RecordedWaypoints.RemoveAt(num2);
					}
				}
				int count2 = frmProfile.RecordedWaypoints.Count;
				int preSelect = -1;
				if (num > -1 && count2 > 0 && num <= count2 - 1)
				{
					preSelect = num;
				}
				frmProfile.UpdateListWaypoints(preSelect);
				@lock = frmProfile._lock;
				lock (@lock)
				{
					frmProfile.SelectedWaypoints.Clear();
				}
			}
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x006DCF40 File Offset: 0x006DB140
		private void AddWaypoint()
		{
			bool flag = false;
			Vector3 positionVector = ObjectManager.Me.PositionVector3;
			using (List<Vector3>.Enumerator enumerator = frmProfile.RecordedWaypoints.GetEnumerator())
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
				object @lock = frmProfile._lock;
				lock (@lock)
				{
					frmProfile.RecordedWaypoints.Add(positionVector);
					Tools.Control(new string[]
					{
						frmProfile.RecordedWaypoints.Count.ToString(),
						frmProfile.RecordedWaypoints.Count.ToString() + "|" + positionVector.ToString() + "|"
					}, "listWaypoints", "frmProfile", true, false, false, false, 0);
				}
			}
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x006DD044 File Offset: 0x006DB244
		private void AddWaypointAfter()
		{
			if (_globals.Ready && frmProfile.RecordedWaypoints.Count > 1 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
			{
				int num = 1;
				if (this.listWaypoints.SelectedIndices[0] == frmProfile.RecordedWaypoints.Count - 1)
				{
					num = 0;
				}
				Window.Activate(null);
				Vector3 item = frmProfile.RecordedWaypoints[this.listWaypoints.SelectedIndices[0] + num];
				int num2 = frmProfile.RecordedWaypoints.IndexOf(item);
				frmProfile.RecordedWaypoints.Insert(num2, ObjectManager.Me.PositionVector3);
				frmProfile.UpdateListWaypoints(num2);
			}
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x006DD104 File Offset: 0x006DB304
		private void btnRecorderSingle_Click(object sender, EventArgs e)
		{
			if (_globals.Ready && _globals.Record)
			{
				Window.Activate(null);
				this.AddWaypoint();
			}
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x006DD12C File Offset: 0x006DB32C
		private void listEvents_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.DeleteEventClick();
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x006DD14C File Offset: 0x006DB34C
		private void DeleteEventClick()
		{
			if (this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0 && this.listEvents.SelectedItems.Count > 0 && this.listEvents.SelectedIndices.Count > 0)
			{
				Vector3 crd = frmProfile.RecordedWaypoints[this.listWaypoints.SelectedIndices[0]];
				int eventID = Convert.ToInt32(this.listEvents.SelectedItems[0].SubItems[1].Text.Split(new char[]
				{
					'[',
					']'
				})[1]);
				this.DeleteEvent(crd, eventID);
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x006DD210 File Offset: 0x006DB410
		private void DeleteEvent(Vector3 Crd, int EventID)
		{
			object @lock = frmProfile._lock;
			lock (@lock)
			{
				if (frmProfile.RecordedEvents.Count > 1)
				{
					frmProfile.RecordedEvents.RemoveAll((Events evt) => evt.Vector3 == Crd && evt.ID == EventID);
				}
				else
				{
					frmProfile.RecordedEvents.Clear();
				}
			}
			this.UpdateListBoxEvents();
			this.UpdateListBoxWaypoint(Crd);
			frmProfile.UpdateAndShowOverlayGoals();
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x006DD2A4 File Offset: 0x006DB4A4
		private void listBlacklist_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.RemoveFromBlacklist();
			}
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x006DD2C4 File Offset: 0x006DB4C4
		private void RemoveFromBlacklist()
		{
			if (this.listBlacklist.SelectedItems.Count > 0 && this.listBlacklist.SelectedIndices.Count > 0)
			{
				string value = this.listBlacklist.SelectedItems[0].SubItems[0].Text.Split(new char[]
				{
					'[',
					']'
				})[1];
				string text = "";
				foreach (KeyValuePair<string, Vector3> keyValuePair in frmProfile.RecordedBlacklist)
				{
					if (keyValuePair.Key.Contains(value))
					{
						text = keyValuePair.Key;
						break;
					}
				}
				if (text.Length > 0)
				{
					frmProfile.RecordedBlacklist.Remove(text);
					frmProfile.UpdateListBlacklist();
				}
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x006DD3B0 File Offset: 0x006DB5B0
		private void listBlacklistObjects_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.AddToBlacklist();
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x006DD3C4 File Offset: 0x006DB5C4
		private void AddToBlacklist()
		{
			if (this.listBlacklistObjects.SelectedItems.Count > 0 && this.listBlacklistObjects.SelectedIndices.Count > 0)
			{
				Objects getObject = this.GetObject;
				if (getObject != null)
				{
					Vector3 vector = default(Vector3);
					string text = "";
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						text = getObject.Name;
						vector = getObject.PositionVector3;
					}
					if (vector != default(Vector3) && text.Length > 0 && !frmProfile.RecordedBlacklist.Values.Contains(vector))
					{
						string str = Walk.BlacklistID(frmProfile.RecordedBlacklist);
						frmProfile.RecordedBlacklist.Add(text + " [" + str + "]", vector);
						frmProfile.UpdateListBlacklist();
					}
				}
			}
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x006DD4B0 File Offset: 0x006DB6B0
		private void btnBlacklistReload_Click(object sender, EventArgs e)
		{
			frmProfile.UpdateListBlacklist();
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x006DD4C4 File Offset: 0x006DB6C4
		private void btnBlacklist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"ObjectBlacklist"
			};
			Tools.OpenForm("frmList", true, "frmProfile", args);
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x006DD4F4 File Offset: 0x006DB6F4
		private void btnObjectsWhitelist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"ObjectWhitelist"
			};
			Tools.OpenForm("frmList", true, "frmProfile", args);
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void listClimbSpots_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void btnClimbSpotAdd_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void checkClimbSpotsSettingsUseClimbSpots_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void checkClimbSpotsSettingsShowConnections_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void listClimbSpots_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void listClimbSpots_MouseDoubleClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void txtClimbSpotsEditRadius_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x006DD524 File Offset: 0x006DB724
		private void listWaypoints_MouseClick(object sender, MouseEventArgs e)
		{
			object @lock = frmProfile._lock;
			lock (@lock)
			{
				frmProfile.SelectedWaypoints.Clear();
				if (frmProfile.RecordedWaypoints.Count > 0 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
				{
					ListView.SelectedIndexCollection selectedIndices = this.listWaypoints.SelectedIndices;
					int count = selectedIndices.Count;
					for (int i = 0; i < count; i++)
					{
						int item = selectedIndices[i];
						frmProfile.SelectedWaypoints.Add(item);
					}
				}
			}
			this.ShowContextMenuWaypoints(sender, e);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x006DD5DC File Offset: 0x006DB7DC
		private void listEvents_MouseUp(object sender, MouseEventArgs e)
		{
			this.ShowContextMenuEvents(sender, e);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x006DD5F4 File Offset: 0x006DB7F4
		private void listEvents_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.CreateOrEditEvent("Edit");
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x006DD60C File Offset: 0x006DB80C
		public void CreateOrEditEvent(string Mode = "")
		{
			if (frmProfile.RecordedWaypoints.Count > 0 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0 && (Mode == "New" || (Mode == "Edit" && this.listEvents.SelectedItems.Count > 0 && this.listEvents.SelectedIndices.Count > 0)))
			{
				frmProfileEvent.Crd = frmProfile.RecordedWaypoints[this.listWaypoints.SelectedIndices[0]];
				frmProfileEvent.EventName = "";
				frmProfileEvent.EventID = 0;
				frmProfileEvent.Event = null;
				if (Mode == "Edit")
				{
					int num = Convert.ToInt32(this.listEvents.SelectedItems[0].SubItems[1].Text.ToString().Split(new char[]
					{
						'[',
						']'
					})[1]);
					if (num > 0)
					{
						frmProfileEvent.Event = ObjectManager.GetEvent(num);
					}
					if (frmProfileEvent.Event == null)
					{
						Mode = "New";
					}
					else
					{
						frmProfileEvent.EventName = frmProfileEvent.Event.Name;
						frmProfileEvent.EventID = frmProfileEvent.Event.ID;
					}
				}
				frmProfileEvent.Mode = Mode;
				Tools.ShowForm("frmProfileEvent");
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x006DD778 File Offset: 0x006DB978
		private void CopyEvent()
		{
			this.CopyEventID = 0;
			if (frmProfile.RecordedWaypoints.Count > 0 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0 && this.listEvents.SelectedItems.Count > 0 && this.listEvents.SelectedIndices.Count > 0)
			{
				int copyEventID = Convert.ToInt32(this.listEvents.SelectedItems[0].SubItems[1].Text.ToString().Split(new char[]
				{
					'[',
					']'
				})[1]);
				this.CopyEventID = copyEventID;
			}
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x006DD838 File Offset: 0x006DBA38
		private void Paste()
		{
			if (this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
			{
				Events @event = ObjectManager.GetEvent(this.CopyEventID);
				if (@event != null)
				{
					int num = 0;
					foreach (object obj in this.listWaypoints.SelectedIndices)
					{
						Vector3 vector = frmProfile.RecordedWaypoints[(int)obj];
						num = (int)obj;
						Events events = (Events)@event.Clone();
						events.ID = frmProfileEventSave.GenerateID;
						events.Vector3 = vector;
						object @lock = frmProfile._lock;
						lock (@lock)
						{
							frmProfile.RecordedEvents.Add(events);
						}
					}
					int preSelect = -1;
					if (num > 0)
					{
						preSelect = num;
					}
					frmProfile.UpdateListWaypoints(preSelect);
					this.CopyEventID = 0;
					return;
				}
			}
			else
			{
				MessageBox.Show("Please select at least one Waypoint.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x006DD974 File Offset: 0x006DBB74
		private void SwitchEvents()
		{
			if (frmProfile.RecordedWaypoints.Count > 0 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0 && this.listEvents.SelectedItems.Count == 2)
			{
				int num = Convert.ToInt32(this.listEvents.SelectedItems[0].SubItems[1].Text.ToString().Split(new char[]
				{
					'[',
					']'
				})[1]);
				int num2 = -1;
				int num3 = Convert.ToInt32(this.listEvents.SelectedItems[1].SubItems[1].Text.ToString().Split(new char[]
				{
					'[',
					']'
				})[1]);
				int num4 = -1;
				int num5 = 0;
				foreach (Events events in frmProfile.RecordedEvents)
				{
					if (num2 == -1 && events.ID == num)
					{
						num2 = num5;
					}
					else if (num4 == -1)
					{
						if (events.ID == num3)
						{
							num4 = num5;
						}
					}
					if (num2 > -1 && num4 > -1)
					{
						break;
					}
					num5++;
				}
				if (num2 > -1 && num4 > -1)
				{
					frmProfile.RecordedEvents.Swap(num2, num4);
				}
				else
				{
					MessageBox.Show("EventIndex_1: " + num2.ToString());
					MessageBox.Show("EventIndex_1: " + num4.ToString());
				}
				this.UpdateListBoxEvents();
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void listClimbSpots_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x006DDB24 File Offset: 0x006DBD24
		private void richMobs_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.Modifiers == Keys.Control && e.KeyCode == Keys.V;
			bool flag2 = e.Modifiers == Keys.Shift && e.KeyCode == Keys.Insert;
			string text = this.richMobs.Text;
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
				this.richMobs.Text = text2;
			}
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x006DDC2C File Offset: 0x006DBE2C
		private void btnStuckPathsStart_Click(object sender, EventArgs e)
		{
			if (!_globals.Ready)
			{
				Tools.ControlColor("Start", "btnStuckPathsStart", "frmProfile", Color.FromArgb(0, 119, 230), null, true);
				return;
			}
			if (this.btnStuckPathsStart.Text == "Start")
			{
				Tools.ControlColor("Stop", "btnStuckPathsStart", "frmProfile", Color.Red, null, true);
				this.StartStuckPaths();
				Window.Activate(null);
				return;
			}
			this.StuckPathsStop = true;
			Tools.ControlColor("Start", "btnStuckPathsStart", "frmProfile", Color.FromArgb(0, 119, 230), null, true);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x006DDCD0 File Offset: 0x006DBED0
		private void StartStuckPaths()
		{
			frmProfile.<>c__DisplayClass91_0 CS$<>8__locals1 = new frmProfile.<>c__DisplayClass91_0();
			CS$<>8__locals1.<>4__this = this;
			this.StuckPathsStop = false;
			Vector3 zero = Vector3.Zero;
			CS$<>8__locals1.LastClick = DateTime.Now;
			CS$<>8__locals1.RadiusClicked = false;
			new object();
			Json.LoadStuckPaths();
			Overlay.RadiusHover = zero;
			Overlay.RadiusClickedSelection.Clear();
			Overlay.RadiusClickedSelection = _globals.StuckPaths;
			Overlay.RadiusRadius = 5;
			Overlay.ShowRadius = true;
			CS$<>8__locals1.MouseoverGUID = 0;
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(CS$<>8__locals1.method_1))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x006DDD80 File Offset: 0x006DBF80
		private void btnStuckPathsReload_Click(object sender, EventArgs e)
		{
			Json.LoadStuckPaths();
			this.UpdateListStuckPaths(-1);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x006DDD9C File Offset: 0x006DBF9C
		private void selectStuckPathsDivision_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.selectStuckPathsDivision.SelectedItem.ToString() == "Full")
			{
				Overlay.RadiusDivision = 2;
				return;
			}
			Overlay.RadiusDivision = 1;
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x006DDDD4 File Offset: 0x006DBFD4
		private void trackStuckPathsRadius_ValueChanged(object sender, EventArgs e)
		{
			string text = this.trackStuckPathsRadius.Value.ToString();
			this.txtStuckPathRadius.Text = text;
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x006DDE04 File Offset: 0x006DC004
		private void txtStuckPathRadius_TextChanged(object sender, EventArgs e)
		{
			string text = this.txtStuckPathRadius.Text;
			if (text == "")
			{
				return;
			}
			if (!Tools.IsNumber(text, 0, 3, 1, 200))
			{
				text = "10";
				this.txtStuckPathRadius.Text = text;
			}
			int num = Convert.ToInt32(text);
			this.trackStuckPathsRadius.Value = num;
			Overlay.RadiusRadius = num;
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x006DDE68 File Offset: 0x006DC068
		private void trackStuckPathsRotation_ValueChanged(object sender, EventArgs e)
		{
			string text = this.trackStuckPathsRotation.Value.ToString();
			this.txtStuckPathRotation.Text = text;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x006DDE98 File Offset: 0x006DC098
		private void txtStuckPathRotation_TextChanged(object sender, EventArgs e)
		{
			string text = this.txtStuckPathRotation.Text;
			if (!(text == ""))
			{
				if (!Tools.IsNumber(text, 0, 2, 0, 10))
				{
					text = "0";
					this.txtStuckPathRotation.Text = text;
				}
				int num = Convert.ToInt32(text);
				this.trackStuckPathsRotation.Value = num;
				Overlay.RadiusRotation = num;
				return;
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x006DDEF8 File Offset: 0x006DC0F8
		private void btnStuckPathsAroundMe_Click(object sender, EventArgs e)
		{
			if (this.btnStuckPathsAroundMe.Text == "Around own Location")
			{
				Overlay.ShowRadiusAroundOwnLocation = true;
				Tools.ControlColor("Hide around own Location", "btnStuckPathsAroundMe", "frmProfile", Color.Red, null, true);
				this.btnStuckPathsAroundMeSet.Enabled = true;
				Window.Activate(null);
				return;
			}
			Overlay.ShowRadiusAroundOwnLocation = false;
			Tools.ControlColor("Around own Location", "btnStuckPathsAroundMe", "frmProfile", Color.FromArgb(0, 119, 230), null, true);
			this.btnStuckPathsAroundMeSet.Enabled = false;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x006DDF88 File Offset: 0x006DC188
		private void btnStuckPathsAroundMeSet_Click(object sender, EventArgs e)
		{
			StuckPaths stuckPaths = new StuckPaths();
			stuckPaths.Name = "Custom";
			stuckPaths.Type = "Around Me";
			stuckPaths.ZoneID = PlayerMe.ZoneID;
			stuckPaths.ZoneName = PlayerMe.ZoneName;
			stuckPaths.Location = ObjectManager.Me.PositionVector3;
			stuckPaths.Angle = Overlay.RadiusAngle;
			stuckPaths.Radius = Overlay.RadiusRadius;
			stuckPaths.Rotation = Overlay.RadiusRotation;
			stuckPaths.Division = Overlay.RadiusDivision;
			for (double num = 0.0; num < 3.141592653589793 * (double)stuckPaths.Division; num += stuckPaths.Angle)
			{
				Vector3 item = new Vector3
				{
					X = (float)((double)stuckPaths.Location.X + (double)stuckPaths.Radius * Math.Cos(num + (double)stuckPaths.Rotation)),
					Y = (float)((double)stuckPaths.Location.Y + (double)stuckPaths.Radius * Math.Sin(num + (double)stuckPaths.Rotation)),
					Z = stuckPaths.Location.Z
				};
				stuckPaths.Waypoints.Add(item);
			}
			_globals.StuckPaths.Add(stuckPaths);
			Json.SaveAndReloadStuckPaths();
			this.UpdateListStuckPaths(this.listStuckPaths.Items.Count);
			Overlay.RadiusClickedSelection = _globals.StuckPaths;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x006DE0E4 File Offset: 0x006DC2E4
		private void selectStuckPathsOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.StuckPathsOrderSelection = this.selectStuckPathsOrder.SelectedItem.ToString();
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x006DE108 File Offset: 0x006DC308
		private void UpdateListStuckPaths(int PreSelect = -1)
		{
			frmProfile.<>c__DisplayClass102_0 CS$<>8__locals1 = new frmProfile.<>c__DisplayClass102_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.PreSelect = PreSelect;
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x006DE144 File Offset: 0x006DC344
		private void listStuckPaths_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (!Tools.ListViewHasSelection(this.listStuckPaths))
			{
				return;
			}
			ListViewHitTestInfo listViewHitTestInfo = this.listStuckPaths.HitTest(e.Location);
			int num = listViewHitTestInfo.Item.SubItems.IndexOf(listViewHitTestInfo.SubItem);
			if (!new List<int>
			{
				2,
				3,
				4
			}.Contains(num))
			{
				return;
			}
			if (num == 2)
			{
				this.EditStuckPath(true);
				return;
			}
			this.SelectedColumnIndex = num;
			Rectangle bounds = listViewHitTestInfo.SubItem.Bounds;
			int num2 = listViewHitTestInfo.Item.GetBounds(ItemBoundsPortion.Label).Left - 1;
			string text = listViewHitTestInfo.SubItem.Text;
			this.txtStuckPathsEditList.Bounds = new Rectangle(bounds.Left + num2, bounds.Top, bounds.Width - num2 - 1, bounds.Height);
			this.txtStuckPathsEditList.Text = text;
			this.txtStuckPathsEditList.SelectAll();
			this.txtStuckPathsEditList.Visible = true;
			this.txtStuckPathsEditList.Focus();
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x006DE258 File Offset: 0x006DC458
		private void listStuckPaths_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtStuckPathsEditList.Visible = false;
			if (!Tools.ListViewHasSelection(this.listStuckPaths))
			{
				Overlay.ShowSavedRadius = false;
				return;
			}
			StuckPaths stuckPaths = _globals.StuckPaths[this.GetSelectedListAndColumnIndex];
			Overlay.SavedRadiusLocation = stuckPaths.Location;
			Overlay.SavedRadiusName = stuckPaths.Name + " (" + stuckPaths.Type + ")";
			Overlay.SavedRadiusAngle = stuckPaths.Angle;
			Overlay.SavedRadiusRadius = stuckPaths.Radius;
			Overlay.SavedRadiusRotation = stuckPaths.Rotation;
			Overlay.SavedRadiusDivision = stuckPaths.Division;
			Overlay.ShowSavedRadius = true;
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x006DE2F4 File Offset: 0x006DC4F4
		private void listStuckPaths_KeyDown(object sender, KeyEventArgs e)
		{
			if (!Tools.ListViewHasSelection(this.listStuckPaths))
			{
				return;
			}
			if (e.KeyCode != Keys.Delete)
			{
				return;
			}
			if (!this.txtStuckPathsEditList.Visible)
			{
				this.DeleteStuckPath();
				return;
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x006DE330 File Offset: 0x006DC530
		private void txtStuckPathsEditList_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return || this.SelectedColumnIndex < 0)
			{
				return;
			}
			if (Tools.ListViewHasSelection(this.listStuckPaths))
			{
				int index = -1;
				try
				{
					index = this.listStuckPaths.SelectedIndices[0];
				}
				catch
				{
					return;
				}
				this.listStuckPaths.Items[index].SubItems[this.SelectedColumnIndex].Text = this.txtStuckPathsEditList.Text;
				this.txtStuckPathsEditList.Visible = false;
				this.SelectedColumnIndex = -1;
				this.EditStuckPath(false);
				return;
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x006DE3D4 File Offset: 0x006DC5D4
		private void EditStuckPath(bool ChangeDivision = false)
		{
			if (!Tools.ListViewHasSelection(this.listStuckPaths))
			{
				return;
			}
			int num = this.listStuckPaths.SelectedIndices[0];
			string text = this.listStuckPaths.Items[num].SubItems[2].Text;
			string text2 = this.listStuckPaths.Items[num].SubItems[3].Text;
			string text3 = this.listStuckPaths.Items[num].SubItems[4].Text;
			if (!Tools.IsNumber(text2, 1, 3, 1, 200))
			{
				text2 = "5";
			}
			if (!Tools.IsNumber(text3, 1, 2, 0, 10))
			{
				text3 = "0";
			}
			int division = 2;
			if (!(text == "Half"))
			{
				if (text == "Full")
				{
					division = 1;
				}
			}
			StuckPaths stuckPaths = _globals.StuckPaths[this.GetSelectedListAndColumnIndex];
			if (ChangeDivision)
			{
				stuckPaths.Division = division;
			}
			stuckPaths.Radius = Convert.ToInt32(text2);
			stuckPaths.Rotation = Convert.ToInt32(text3);
			stuckPaths.Waypoints.Clear();
			for (double num2 = 0.0; num2 < 3.141592653589793 * (double)stuckPaths.Division; num2 += stuckPaths.Angle)
			{
				Vector3 item = new Vector3
				{
					X = (float)((double)stuckPaths.Location.X + (double)stuckPaths.Radius * Math.Cos(num2 + (double)stuckPaths.Rotation)),
					Y = (float)((double)stuckPaths.Location.Y + (double)stuckPaths.Radius * Math.Sin(num2 + (double)stuckPaths.Rotation)),
					Z = stuckPaths.Location.Z
				};
				stuckPaths.Waypoints.Add(item);
			}
			Json.SaveAndReloadStuckPaths();
			this.UpdateListStuckPaths(num);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x006DE5D0 File Offset: 0x006DC7D0
		private void DeleteStuckPath()
		{
			if (!Tools.ListViewHasSelection(this.listStuckPaths))
			{
				return;
			}
			_globals.StuckPaths.RemoveAt(this.GetSelectedListAndColumnIndex);
			Overlay.ShowSavedRadius = false;
			Json.SaveAndReloadStuckPaths();
			this.UpdateListStuckPaths(-1);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06001165 RID: 4453 RVA: 0x006DE610 File Offset: 0x006DC810
		private int GetSelectedListAndColumnIndex
		{
			get
			{
				int index = this.listStuckPaths.SelectedIndices[0];
				return Convert.ToInt32(this.listStuckPaths.Items[index].SubItems[0].Text);
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x006DE658 File Offset: 0x006DC858
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

		// Token: 0x06001167 RID: 4455 RVA: 0x006DE6F0 File Offset: 0x006DC8F0
		private void checkSettingsGroundMount_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkSettingsGroundMount.Checked)
			{
				this.checkSettingsFlightMount.Checked = false;
				this.CombatModeSelection("");
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x006DE724 File Offset: 0x006DC924
		private void checkSettingsFlightMount_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkSettingsFlightMount.Checked)
			{
				this.checkSettingsGroundMount.Checked = false;
				this.CombatModeSelection("Flight");
				this.lblSettingsLootDetectionDistanceInfo.Text = "(Flight line)";
				this.txtSettingsLootMaxPathDistance.Enabled = false;
				return;
			}
			this.CombatModeSelection("");
			this.lblSettingsLootDetectionDistanceInfo.Text = "(3D)";
			if (this.checkSettingsModeMesh.Checked)
			{
				this.txtSettingsLootMaxPathDistance.Enabled = true;
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x006DE7A8 File Offset: 0x006DC9A8
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

		// Token: 0x0600116A RID: 4458 RVA: 0x006DE8C0 File Offset: 0x006DCAC0
		private void btnExpertFlightSensDefault_Click(object sender, EventArgs e)
		{
			this.trackExpertFlightSens.Value = 6;
			this.lblExpertFlightSensData.Text = "6";
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x006DE8EC File Offset: 0x006DCAEC
		private void trackExpertFlightSens_Scroll(object sender, ScrollEventArgs e)
		{
			string text = this.trackExpertFlightSens.Value.ToString();
			this.lblExpertFlightSensData.Text = text;
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x006DE91C File Offset: 0x006DCB1C
		private void ShowContextMenuWaypoints(object sender, MouseEventArgs e)
		{
			if (frmProfile.RecordedWaypoints.Count > 0 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
			{
				if (e.Button == MouseButtons.Right)
				{
					string[] items = new string[0];
					if (this.CopyEventID > 0)
					{
						items = new string[]
						{
							"Create New Event...",
							"Add Waypoint after",
							"-",
							"Paste",
							"-",
							"Delete"
						};
					}
					else
					{
						items = new string[]
						{
							"Create New Event...",
							"Add Waypoint after",
							"-",
							"Delete"
						};
					}
					Tools.CreateContextMenu(sender, e, "frmProfile", "listWaypoints", "ItemActionWaypoints", items, null);
				}
			}
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x006DEA00 File Offset: 0x006DCC00
		public void ItemActionWaypoints(object sender, MouseEventArgs e, string Action = "")
		{
			if (Action == "Create New Event...")
			{
				this.CreateOrEditEvent("New");
				return;
			}
			if (Action == "Add Waypoint after")
			{
				this.AddWaypointAfter();
				return;
			}
			if (Action == "Paste")
			{
				this.Paste();
				return;
			}
			if (Action == "Delete")
			{
				this.DeleteWaypoints();
			}
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x006DEA64 File Offset: 0x006DCC64
		private void ShowContextMenuEvents(object sender, MouseEventArgs e)
		{
			if (!_globals.IsPremiumProfile)
			{
				if (e.Button == MouseButtons.Right)
				{
					if (frmProfile.RecordedWaypoints.Count > 0 && this.listWaypoints.SelectedItems.Count > 0 && this.listWaypoints.SelectedIndices.Count > 0)
					{
						List<string> list = new List<string>();
						int count = this.listEvents.SelectedItems.Count;
						list.Add("Create New Event...");
						if (count > 0 && count <= 2 && this.listEvents.SelectedIndices.Count > 0)
						{
							if (count != 1)
							{
								list.Add("-");
								list.Add("Switch Events");
							}
							else
							{
								list.Add("Edit Event...");
								list.Add("Copy Event...");
								list.Add("-");
								list.Add("Switch Events");
								list.Add("-");
								list.Add("Delete");
							}
						}
						Tools.CreateContextMenu(sender, e, "frmProfile", "listEvents", "ItemActionEvents", list.ToArray(), null);
					}
				}
			}
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x006DEB84 File Offset: 0x006DCD84
		public void ItemActionEvents(object sender, MouseEventArgs e, string Action = "")
		{
			if (Action == "Create New Event...")
			{
				this.CreateOrEditEvent("New");
				return;
			}
			if (Action == "Edit Event...")
			{
				this.CreateOrEditEvent("Edit");
				return;
			}
			if (Action == "Copy Event...")
			{
				this.CopyEvent();
				return;
			}
			if (Action == "Switch Events")
			{
				this.SwitchEvents();
				return;
			}
			if (Action == "Delete")
			{
				this.DeleteEventClick();
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x006DEC00 File Offset: 0x006DCE00
		private void listBlacklist_MouseClick(object sender, MouseEventArgs e)
		{
			if (frmProfile.RecordedBlacklist.Count > 0 && this.listBlacklist.SelectedItems.Count > 0 && this.listBlacklist.SelectedIndices.Count > 0 && e.Button == MouseButtons.Right)
			{
				string[] items = new string[]
				{
					"Delete"
				};
				Tools.CreateContextMenu(sender, e, "frmProfile", "listBlacklist", "ItemActionBlacklist", items, null);
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x006DEC74 File Offset: 0x006DCE74
		public void ItemActionBlacklist(object sender, MouseEventArgs e, string Action = "")
		{
			if (Action == "Delete")
			{
				this.RemoveFromBlacklist();
			}
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x006DEC94 File Offset: 0x006DCE94
		private void listBlacklistObjects_MouseClick(object sender, MouseEventArgs e)
		{
			if (_globals.Ready && ObjectManager.GetAllNodes.Count > 0 && this.listBlacklistObjects.SelectedItems.Count > 0 && this.listBlacklistObjects.SelectedIndices.Count > 0 && e.Button == MouseButtons.Right)
			{
				string[] items = new string[]
				{
					"Add to Blacklist"
				};
				Tools.CreateContextMenu(sender, e, "frmProfile", "listBlacklistObjects", "ItemActionBlacklistObjects", items, null);
			}
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x006DED10 File Offset: 0x006DCF10
		public void ItemActionBlacklistObjects(object sender, MouseEventArgs e, string Action = "")
		{
			if (Action == "Add to Blacklist")
			{
				this.AddToBlacklist();
			}
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x006DED30 File Offset: 0x006DCF30
		public static void UpdateAndShowOverlayGoals()
		{
			new Thread(new ThreadStart(frmProfile.smethod_3))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x006DED5C File Offset: 0x006DCF5C
		private void OverlayMenu()
		{
			while (frmProfile.OverlayMenuRuns)
			{
				Thread.Sleep(50);
			}
			if (!_globals.IsPremiumProfile)
			{
				while (_globals.ShowRecordedProfile)
				{
					if (!frmProfile.OverlayMenuRuns)
					{
						frmProfile.OverlayMenuRuns = true;
					}
					if (Overlay.MenuCrdIndexAutoSelect > -1)
					{
						this.Tab(this.tabRecorder);
						this.SelectWaypoint(Overlay.MenuCrdIndexAutoSelect);
						Overlay.MenuCrdIndexAutoSelect = -1;
					}
					if (Overlay.MenuItem != null)
					{
						string a = (string)Overlay.MenuItem[0];
						int num = Overlay.MenuItem.Count<object>();
						int num2 = 0;
						int id = 0;
						if (num > 1)
						{
							num2 = (int)Overlay.MenuItem[1];
							if (num > 2)
							{
								id = (int)Overlay.MenuItem[2];
							}
						}
						if (!(a == "Create Event..."))
						{
							if (!(a == "Connect Profile..."))
							{
								if (!(a == "Edit Event"))
								{
									if (!(a == "Delete Event"))
									{
										if (a == "Add Waypoint after")
										{
											this.SelectWaypoint(num2);
											this.listWaypoints.Invoke(new MethodInvoker(delegate()
											{
												this.AddWaypointAfter();
											}));
										}
										else if (!(a == "Delete Waypoint"))
										{
											if (!(a == "Record Start") && !(a == "Record Stop"))
											{
												if (a == "Add Single")
												{
													this.AddWaypoint();
												}
											}
											else
											{
												this.StartStop();
											}
										}
										else
										{
											this.SelectWaypoint(num2);
											this.listWaypoints.Invoke(new MethodInvoker(delegate()
											{
												this.DeleteWaypoints();
											}));
										}
									}
									else
									{
										this.SelectWaypoint(num2);
										this.SelectEvent(id);
										this.listEvents.Invoke(new MethodInvoker(delegate()
										{
											this.DeleteEventClick();
										}));
									}
								}
								else
								{
									this.SelectWaypoint(num2);
									this.SelectEvent(id);
									this.listEvents.Invoke(new MethodInvoker(delegate()
									{
										this.CreateOrEditEvent("Edit");
									}));
								}
							}
							else
							{
								this.SelectWaypoint(num2);
								frmOverlayMenu.Mode = "ShowProfiles";
								frmOverlayMenu.Crd = frmProfile.RecordedWaypoints[num2];
								new Thread(delegate()
								{
									Application.Run(new frmOverlayMenu());
								})
								{
									IsBackground = true
								}.Start();
							}
						}
						else
						{
							this.SelectWaypoint(num2);
							this.listWaypoints.Invoke(new MethodInvoker(delegate()
							{
								this.CreateOrEditEvent("New");
							}));
						}
						Overlay.MenuItem = null;
					}
					Thread.Sleep(10);
				}
			}
			frmProfile.OverlayMenuRuns = false;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x006DEFC8 File Offset: 0x006DD1C8
		private void SelectWaypoint(int ID)
		{
			try
			{
				this.listWaypoints.Invoke(new MethodInvoker(delegate()
				{
					try
					{
						this.listWaypoints.SelectedItems.Clear();
						this.listWaypoints.Items[ID].Focused = true;
						this.listWaypoints.Items[ID].Selected = true;
						this.listWaypoints.Items[ID].EnsureVisible();
						this.listWaypoints.Select();
					}
					catch
					{
					}
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x006DF018 File Offset: 0x006DD218
		public void SelectEvent(int ID)
		{
			try
			{
				this.listEvents.Invoke(new MethodInvoker(delegate()
				{
					if (this.listEvents.Items.Count > 0)
					{
						this.listEvents.SelectedItems.Clear();
						for (int i = 0; i < this.listEvents.Items.Count; i++)
						{
							if (this.listEvents.Items[i].SubItems[1].Text.Contains("[" + ID.ToString() + "]"))
							{
								this.listEvents.Items[i].Focused = true;
								this.listEvents.Items[i].Selected = true;
								this.listEvents.Items[i].EnsureVisible();
								this.listEvents.Select();
							}
						}
					}
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x006DF068 File Offset: 0x006DD268
		private void Tab(TabPage TabPage)
		{
			try
			{
				this.tabs.Invoke(new MethodInvoker(delegate()
				{
					if (this.tabs.SelectedTab != this.tabs.TabPages[TabPage.Name])
					{
						this.tabs.SelectedTab = TabPage;
					}
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x006DF0B8 File Offset: 0x006DD2B8
		private void SaveProfileSettings()
		{
			frmProfile.ProfileSettings.Clear();
			List<string> list = new List<string>();
			if (this.richMobs.Text.Length > 0)
			{
				foreach (string text in this.richMobs.Text.Split(new char[]
				{
					'\n'
				}).ToList<string>())
				{
					string text2 = text.Trim().Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
					if (text2.Length != 0)
					{
						list.Add(text2);
					}
				}
			}
			List<string> list2 = new List<string>();
			if (this.txtSettingsLootQuestItems.Text.Length > 0)
			{
				foreach (string text3 in this.txtSettingsLootQuestItems.Text.Split(new char[]
				{
					'\n'
				}).ToList<string>())
				{
					string text4 = text3.Trim().Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
					if (text4.Length != 0)
					{
						list2.Add(text4);
					}
				}
			}
			ProfileSettings profileSettings = new ProfileSettings();
			profileSettings.AttackableMobs = list;
			profileSettings.CombatMode = this.selectSettingsCombatMode.Text;
			profileSettings.CombatModeIndex = this.selectSettingsCombatMode.SelectedIndex;
			profileSettings.WaypointMode = this.selectSettingsWaypointMode.Text;
			profileSettings.WaypointModeIndex = this.selectSettingsWaypointMode.SelectedIndex;
			profileSettings.FollowFleeingTarget = this.checkSettingsModeFollowFleeingTarget.Checked;
			profileSettings.ModeMesh = this.checkSettingsModeMesh.Checked;
			profileSettings.GroundMount = this.checkSettingsGroundMount.Checked;
			profileSettings.FlightMount = this.checkSettingsFlightMount.Checked;
			profileSettings.Loot = this.checkSettingsLoot.Checked;
			profileSettings.Skinning = this.checkSettingsLootSkinning.Checked;
			profileSettings.Herbalism = this.checkSettingsLootHerbalism.Checked;
			profileSettings.Mining = this.checkSettingsLootMining.Checked;
			profileSettings.GatherMobs = this.checkSettingsLootGatherMobs.Checked;
			profileSettings.QuestItems = list2;
			int num = -1;
			double num2 = -1.0;
			if (int.TryParse(this.txtSettingsLootDistance.Text, out num) && num >= 0 && num <= 999)
			{
				profileSettings.DistanceLoot = num;
			}
			num = -1;
			if (int.TryParse(this.txtSettingsLootMaxPathDistance.Text, out num) && num >= 0 && num <= 9999)
			{
				profileSettings.DistancePath = num;
			}
			num = -1;
			if (int.TryParse(this.txtSettingsLootGatherDistance.Text, out num) && num >= 0 && num <= 8)
			{
				profileSettings.DistanceLootGather = num;
			}
			num = -1;
			if (int.TryParse(this.txtSettingsLootAvoidElitesDistance.Text, out num) && num >= 0 && num <= 999)
			{
				profileSettings.DistanceAvoidElites = num;
			}
			num = -1;
			num2 = -1.0;
			if (int.TryParse(this.txtSettingsDistancesWaypoint.Text, out num) && num >= 0 && num <= 99)
			{
				profileSettings.DistanceWaypoint = num;
			}
			num = -1;
			if (int.TryParse(this.txtSettingsDistancesLocation.Text, out num) && num >= 0 && num <= 99)
			{
				profileSettings.DistanceLocation = num;
			}
			num = -1;
			if (int.TryParse(this.txtSettingsDistancesMobGroup.Text, out num) && num >= 0 && num <= 99)
			{
				profileSettings.DistanceMobGroup = num;
			}
			num2 = -1.0;
			if (double.TryParse(this.txtSettingsDistancesIsReachable.Text.Replace(".", ","), out num2) && num2 >= 0.0 && num2 <= 999.0)
			{
				profileSettings.DistanceIsReachable = num2;
			}
			profileSettings.Blacklist.Clear();
			if (frmProfile.RecordedBlacklist.Count > 0)
			{
				foreach (KeyValuePair<string, Vector3> keyValuePair in frmProfile.RecordedBlacklist)
				{
					profileSettings.Blacklist.Add(keyValuePair.Key, keyValuePair.Value);
				}
			}
			profileSettings.BlacklistNameOrID.Clear();
			if (frmProfile.RecordedBlacklistNameOrID.Count > 0)
			{
				foreach (string item in frmProfile.RecordedBlacklistNameOrID)
				{
					profileSettings.BlacklistNameOrID.Add(item);
				}
			}
			profileSettings.WhitelistNameOrID.Clear();
			if (frmProfile.RecordedWhitelistNameOrID.Count > 0)
			{
				foreach (string item2 in frmProfile.RecordedWhitelistNameOrID)
				{
					profileSettings.WhitelistNameOrID.Add(item2);
				}
			}
			num = -1;
			if (int.TryParse(this.txtExpertLootDelay.Text, out num) && num >= 0 && num <= 9999)
			{
				profileSettings.ExpertLootDelay = num;
			}
			num = -1;
			if (int.TryParse(this.txtExpertResurrectDelay.Text, out num) && num >= 0 && num <= 999)
			{
				profileSettings.ExpertResurrectDelay = num;
			}
			num = -1;
			if (int.TryParse(this.txtExpertMountDelay.Text, out num) && num >= 0 && num <= 9999)
			{
				profileSettings.ExpertMountDelay = num;
			}
			profileSettings.ExpertFlightTolerance = this.trackExpertFlightSens.Value;
			frmProfile.ProfileSettings.Add(profileSettings);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x006DF674 File Offset: 0x006DD874
		private void btnRecorderSave_Click(object sender, EventArgs e)
		{
			this.SaveProfile();
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x006DF688 File Offset: 0x006DD888
		private void SaveProfile()
		{
			if (_globals.IsPremiumProfile)
			{
				this.HideForm();
				return;
			}
			if (frmProfile.RecordedWaypoints.Count > 0)
			{
				this.SaveProfileSettings();
				object[] args = new object[]
				{
					frmProfile.Mode,
					frmProfile.ProfileFolder,
					frmProfile.ProfileName
				};
				Tools.OpenForm("frmProfileSave", true, "frmProfile", args);
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x006DF6E8 File Offset: 0x006DD8E8
		public void HideForm()
		{
			bool flag = true;
			if (frmProfile.Mode == "New" && frmProfile.RecordedWaypoints.Count > 0)
			{
				if (MessageBox.Show("This Profile is not saved yet.\r\nDo you want to save it now?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					this.SaveProfile();
					flag = false;
				}
			}
			if (flag)
			{
				Jack.Core.Settings.WindowProfileLocation = base.Location;
				Jack.Core.Settings.WindowProfileSize = new Size(base.Width, base.Height);
				_globals.ShowRecordedProfile = false;
				_globals.Record = false;
				_globals.ShowProfile = Jack.Core.Settings.OverlayWaypoints;
				Overlay.IsRecording = false;
				Overlay.RecorderClicked = false;
				Overlay.ShowRadius = false;
				Overlay.ShowSavedRadius = false;
				Overlay.ShowRadiusAroundOwnLocation = false;
				Overlay.ShowGoalList = false;
				this.StuckPathsStop = true;
				this.SaveSettings();
				object @lock = frmProfile._lock;
				lock (@lock)
				{
					frmProfile.SelectedWaypoints.Clear();
				}
				Overlay.ClearGraphic("Record");
				this.ResetControlsOnStopOrClose();
				Tools.HideForm("frmProfileEvent");
				base.Visible = false;
				Tools.CloseForm("frmOverlayMenu", Array.Empty<object>());
			}
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x006DF80C File Offset: 0x006DDA0C
		public void HideAfterSave()
		{
			Jack.Core.Settings.WindowProfileLocation = base.Location;
			Jack.Core.Settings.WindowProfileSize = new Size(base.Width, base.Height);
			_globals.ShowRecordedProfile = false;
			_globals.Record = false;
			_globals.ShowProfile = Jack.Core.Settings.OverlayWaypoints;
			Overlay.IsRecording = false;
			Overlay.RecorderClicked = false;
			Overlay.ShowRadius = false;
			Overlay.ShowSavedRadius = false;
			Overlay.ShowRadiusAroundOwnLocation = false;
			Overlay.ShowGoalList = false;
			this.StuckPathsStop = true;
			this.SaveSettings();
			object @lock = frmProfile._lock;
			lock (@lock)
			{
				frmProfile.SelectedWaypoints.Clear();
			}
			Overlay.ClearGraphic("Record");
			Tools.HideForm("frmProfileEvent");
			base.Visible = false;
			Tools.CloseForm("frmOverlayMenu", Array.Empty<object>());
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x006DF8E4 File Offset: 0x006DDAE4
		private void btnTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabRecorder";
			Tooltip tooltip = new Tooltip();
			string title = "Start Recording";
			string text = "You can easily start recording a profile by clicking on this button.\r\n\r\n";
			text += "Run your desired path and click again to pause or to add more waypoints to your path.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "btnRecorderStart";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Single Waypoint";
			text = "Use this button to add a single Waypoint.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "btnRecorderSingle";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Waypoints";
			text = "All recorded waypoints are listed here.\r\n";
			text += "Select one or more waypoints to edit them or to add events.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "grpRecorderWaypoints";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Events";
			text = "Create and manage your events with this list.\r\n";
			text += "Each waypoint can contain any number of events.\r\n\r\n";
			text += "With events you can, for example, enter a dungeon or interact with NPC's.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "grpRecorderEvents";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Settings";
			text = "Use this tab to make further settings to your profile.\r\n";
			text += "If you have further questions about these settings, click on the cloud of the respective setting.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = "tabSettings";
			tooltip5.MarkControlName = "tabs";
			tooltip5.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			Tools.OpenTooltips(list);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x006DFB20 File Offset: 0x006DDD20
		private void btnSettingsModeTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabSettings";
			Tooltip tooltip = new Tooltip();
			string title = "Combat Mode";
			string text = Tools.HTMLColor("Offensive", "DeepSkyBlue") + "\r\n";
			text += "Any mob that is on your mob list and within the specified radius will be attacked.\r\n\r\n";
			text = text + Tools.HTMLColor("Defensive", "DeepSkyBlue") + "\r\n";
			text += "It is only attacked when your character gets into a fight.\r\n\r\n";
			text = text + Tools.HTMLColor("Gather", "DeepSkyBlue") + "\r\n";
			text += "The system automatically detects the best conditions to attack. Not every enemy is attacked immediately.\r\n\r\n";
			text = text + Tools.HTMLColor("Ignore", "DeepSkyBlue") + "\r\n";
			text += "Ignore any fight. There is also no reaction to attacks.";
			text = text + Tools.HTMLColor("PvP", "DeepSkyBlue") + "\r\n";
			text += "Recommended for Battlefields.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectSettingsCombatMode";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Waypoints";
			text = Tools.HTMLColor("Best", "DeepSkyBlue") + "\r\n";
			text += "Finds the best waypoint given the situation and orientation.\r\n\r\n";
			text = text + Tools.HTMLColor("Closest", "DeepSkyBlue") + "\r\n";
			text += "Always runs to the closest waypoint.\r\n\r\n";
			text = text + Tools.HTMLColor("Straight", "DeepSkyBlue") + "\r\n";
			text += "Adheres strictly to the specified waypoint sequence.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "selectSettingsWaypointMode";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Mesh Mode";
			text = "Jack detects and avoids objects automatically.\r\n";
			text += "If not activated, the profile must be created with much higher precision.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "checkSettingsModeMesh";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x006DFD9C File Offset: 0x006DDF9C
		private void btnSettingsLootTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabSettings";
			Tooltip tooltip = new Tooltip();
			string title = "Detection Distance";
			string text = "Specifies the range within which Jack should detect and approach loots or gatherable objects.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "txtSettingsLootDistance";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Max. Path Distance";
			text = "The maximum distance of the calculated path.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "txtSettingsLootMaxPathDistance";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Gather Distance";
			text = "The distance between you and the object.\r\n";
			text += "(Should not be larger than 6 yds.)";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "txtSettingsLootGatherDistance";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Avoid Elites";
			text = "Specifies the radius within a node should not be approached if a high-level elite is in it.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "txtSettingsLootAvoidElitesDistance";
			tooltip4.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x006DFF48 File Offset: 0x006DE148
		private void btnSettingsDistancesTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabSettings";
			Tooltip tooltip = new Tooltip();
			string title = "Around Waypoints";
			string text = "The radius around each current and upcoming waypoint.\r\n\r\n";
			text += "(This input is only available if Mesh Mode is disabled).";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "txtSettingsDistancesWaypoint";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Around own location";
			text = "The radius around your own chracter.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "txtSettingsDistancesLocation";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Around Mobs";
			text = "If one or more mobs are found in the radii indicated above, ";
			text += "Jack will check if there are other enemies in the immediate vicinity ";
			text += "of each mob to determine if it is a mob group.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "txtSettingsDistancesMobGroup";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "General Height";
			text = "We do not want to attack mobs that are on a higher or lower level than us. ";
			text += "This setting should only be used in multi-level regions (e.g. caves or buildings).";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "txtSettingsDistancesIsReachable";
			tooltip4.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x006E0118 File Offset: 0x006DE318
		private void btnMobsTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabMobs";
			Tooltip tooltip = new Tooltip();
			string title = "Mobs";
			string text = "When you create a profile with \"Offensive\" Combat Mode, ";
			text += "you should enter here all mobs that Jack should attack.\r\n\r\n";
			text += "Go to <a href=\"https://wowhead.com\">https://wowhead.com</a> and copy/paste the NPC Name-/ID-List into this field. ";
			text += "The list will be automatically formatted.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "panelMobs";
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x006E01C8 File Offset: 0x006DE3C8
		private void btnBlacklistTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabBlacklist";
			Tooltip tooltip = new Tooltip();
			string title = "Blacklisted Objects";
			string text = "This list shows you every blacklisted Object.\r\n";
			text += "These objects were either manually blacklisted by you or automatically blacklisted by Jack.\r\n\r\n";
			text += "Remove objects with the \"DEL\" key.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpBlacklist";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Objects";
			text = "All objects in the vicinity are displayed here. Select an object to set a marker in-game. ";
			text += "This way you know exactly which object it is. ";
			text += "With a double click you can put the object on your blacklist.\r\n\r\n";
			text = text + Tools.HTMLColor("NOTE!", "DeepSkyBlue") + "\r\n";
			text += "If an object is inaccessible to Jack, he will automatically put it on your blacklist.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "grpBlacklistObjects";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Extended Blacklist";
			text = "Click here to blacklist an object by its name or ID. ";
			text += "Objects that are on this list will be ignored completely.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "btnBlacklistNameOrID";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Whitelist";
			text = "If there are objects on this list, only these objects are actually collected.";
			text += "All others are ignored.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "btnWhitelistNameOrID";
			tooltip4.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void guna2Button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x006E03D8 File Offset: 0x006DE5D8
		private void btnStuckPathsTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabStuckPaths";
			Tooltip tooltip = new Tooltip();
			string title = "Stuck Paths";
			string text = "If Jack doesn't see an object he can walk around,";
			text += " click here and move your mouse over the object to set a path around it.\r\n\r\n";
			text += "Jack will automatically build the best path out of your selection.\r\n\r\n";
			text += "All Stuck Paths created are respected by all profiles.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "btnStuckPathsStart";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Options";
			text = "Adjust shape, size and rotation.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "grpStuckPaths";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Around your own location";
			text = "Click here to set a stuck path around your own location.";
			text += " So you have free choice.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "btnStuckPathsAroundMe";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Overview";
			text = "Here you will find an overview of all Stuck Paths that have already been created.";
			text += " You can also adjust your settings here afterwards. Just doubleclick on it.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "listStuckPaths";
			tooltip4.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void btnClimbSpotsTooltip_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x006E05B4 File Offset: 0x006DE7B4
		private void btnExpertTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabExpert";
			Tooltip tooltip = new Tooltip();
			string title = "Expert Settings";
			string text = "Changes to these settings can massively affect what Jack does.\r\n\r\n";
			text += "Please only use these settings if you want to test something or know exactly what you are doing.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpExpertSettings";
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x006EB970 File Offset: 0x006E9B70
		[CompilerGenerated]
		internal static void smethod_0()
		{
			Overlay.ClearGraphic("Record");
			Dictionary<string[], string[]> dictionary = new Dictionary<string[], string[]>();
			foreach (KeyValuePair<string, Vector3> keyValuePair in frmProfile.RecordedBlacklist)
			{
				string[] key = new string[]
				{
					keyValuePair.Key
				};
				dictionary.Add(key, new string[]
				{
					"Red",
					""
				});
			}
			Tools.ControlListViewCreate(dictionary, "listBlacklist", "frmProfile", true, -1, null);
			if (_globals.Ready)
			{
				dictionary.Clear();
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					foreach (Objects objects in ObjectManager.GetAllNodes)
					{
						Vector3 positionVector = objects.PositionVector3;
						string text = "Green";
						if (frmProfile.RecordedBlacklist.Values.Contains(positionVector))
						{
							text = "LavenderBlush";
						}
						string[] key2 = new string[]
						{
							objects.Name,
							JackMath.Distance(positionVector, true, true, true).ToString(),
							objects.GUID128.ToString()
						};
						dictionary.Add(key2, new string[]
						{
							"",
							text
						});
					}
				}
				Tools.ControlListViewCreate(dictionary, "listBlacklistObjects", "frmProfile", true, -1, null);
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x006EBB24 File Offset: 0x006E9D24
		[CompilerGenerated]
		internal static void smethod_1(Vector3 Location)
		{
			if (Overlay.RadiusHover == Location)
			{
				return;
			}
			Overlay.RadiusHover = Location;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x006EBB48 File Offset: 0x006E9D48
		[CompilerGenerated]
		internal static void smethod_2()
		{
			if (Overlay.RadiusHover != Vector3.Zero)
			{
				Overlay.RadiusHover = Vector3.Zero;
			}
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x006EBB70 File Offset: 0x006E9D70
		[CompilerGenerated]
		internal static void smethod_3()
		{
			Dictionary<Vector3, string> dictionary = new Dictionary<Vector3, string>();
			foreach (Events events in frmProfile.RecordedEvents)
			{
				if (EventManager.IsAction(events.Action, "Add Route...") && !(events.RouteType == "Ghost") && !(events.TargetLocation == Vector3.Zero) && !dictionary.ContainsKey(events.TargetLocation))
				{
					string value = events.Name + ", " + events.TargetName;
					if (events.Name == events.TargetName)
					{
						value = events.Name;
					}
					dictionary.Add(events.TargetLocation, value);
				}
			}
			if (dictionary.Count > 0)
			{
				Overlay.GoalList = dictionary;
				Overlay.ShowGoalList = true;
				return;
			}
			Overlay.ShowGoalList = false;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0066A478 File Offset: 0x00668678
		IntPtr method_0()
		{
			return base.Handle;
		}

		// Token: 0x040007AC RID: 1964
		public static string Mode = "";

		// Token: 0x040007AD RID: 1965
		public static string ProfileFolder = "";

		// Token: 0x040007AE RID: 1966
		public static string ProfileName = "";

		// Token: 0x040007AF RID: 1967
		public static Events Event;

		// Token: 0x040007B0 RID: 1968
		public static List<Vector3> RecordedWaypoints = new List<Vector3>();

		// Token: 0x040007B1 RID: 1969
		public static List<Events> RecordedEvents = new List<Events>();

		// Token: 0x040007B2 RID: 1970
		public static Dictionary<string, Vector3> RecordedBlacklist = new Dictionary<string, Vector3>();

		// Token: 0x040007B3 RID: 1971
		public static List<string> RecordedBlacklistNameOrID = new List<string>();

		// Token: 0x040007B4 RID: 1972
		public static List<string> RecordedWhitelistNameOrID = new List<string>();

		// Token: 0x040007B5 RID: 1973
		public static List<ProfileSettings> ProfileSettings = new List<ProfileSettings>();

		// Token: 0x040007B6 RID: 1974
		public static List<int> SelectedWaypoints = new List<int>();

		// Token: 0x040007B7 RID: 1975
		private bool NoCheck;

		// Token: 0x040007B8 RID: 1976
		public static object _lock = new object();

		// Token: 0x040007B9 RID: 1977
		public static object _lockQuestTracker = new object();

		// Token: 0x040007BA RID: 1978
		private int CopyEventID;

		// Token: 0x040007BB RID: 1979
		private bool StuckPathsStop;

		// Token: 0x040007BC RID: 1980
		private string StuckPathsOrderSelection = "Show All";

		// Token: 0x040007BD RID: 1981
		private int SelectedColumnIndex = -1;

		// Token: 0x040007BE RID: 1982
		private static bool OverlayMenuRuns = false;
	}
}
