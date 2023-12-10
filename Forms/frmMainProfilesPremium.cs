using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.ATH;
using Jack.Core;
using Jack.Properties;
using Newtonsoft.Json;

namespace Jack.Forms
{
	// Token: 0x0200006E RID: 110
	public partial class frmMainProfilesPremium : Form
	{
		// Token: 0x060009E2 RID: 2530 RVA: 0x0068D010 File Offset: 0x0068B210
		public frmMainProfilesPremium()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0068D030 File Offset: 0x0068B230
		private void frmMainProfilesPremium_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Profile Settings", true, true, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0068D054 File Offset: 0x0068B254
		private void frmMainProfilesPremium_Shown(object sender, EventArgs e)
		{
			this.SetContent();
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0068D054 File Offset: 0x0068B254
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetContent();
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0068D054 File Offset: 0x0068B254
		private void frmMainProfilesPremium_Resize(object sender, EventArgs e)
		{
			this.SetContent();
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0068D068 File Offset: 0x0068B268
		private void SetContent()
		{
			CustomUI.ResizeContent(base.Controls);
			this.lblMailboxStatus.Left = (this.panelTabMailbox.ClientSize.Width - this.lblMailboxStatus.Width) / 2;
			this.lblMailboxStatus.Top = (this.panelTabMailbox.ClientSize.Height - this.lblMailboxStatus.Height) / 2;
			this.lblVendorStatus.Left = (this.panelTabVendor.ClientSize.Width - this.lblVendorStatus.Width) / 2;
			this.lblVendorStatus.Top = (this.panelTabVendor.ClientSize.Height - this.lblVendorStatus.Height) / 2;
			this.lblGatherStatus.Left = (this.panelTabGathering.ClientSize.Width - this.lblGatherStatus.Width) / 2;
			this.lblGatherStatus.Top = (this.panelTabGathering.ClientSize.Height - this.lblGatherStatus.Height) / 2;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x0068D188 File Offset: 0x0068B388
		private void LoadControlsAndSettings()
		{
			if (frmMainProfilesPremium.Profile != null)
			{
				this.SetAvailableProfileSettings();
				this.SetInfo();
				return;
			}
			base.Close();
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0068D1B0 File Offset: 0x0068B3B0
		private void SetAvailableProfileSettings()
		{
			frmMainProfilesPremium.<>c__DisplayClass8_0 CS$<>8__locals1;
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.CountAllControls = 0;
			CS$<>8__locals1.CountCurrentControl = 0;
			CS$<>8__locals1.CountFirst = false;
			int i = 1;
			while (i <= 2)
			{
				CS$<>8__locals1.CountFirst = (i == 1);
				if (!CS$<>8__locals1.CountFirst)
				{
					Tools.SetProgress("frmLoading", "progress", CS$<>8__locals1.CountAllControls, true, "");
				}
				if (frmMainProfilesPremium.Profile.IsConnected)
				{
					using (List<PFLS>.Enumerator enumerator = PFL.GetConnectedProfiles(frmMainProfilesPremium.Profile).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							PFLS profile = enumerator.Current;
							this.method_0(profile, ref CS$<>8__locals1);
						}
						goto IL_AD;
					}
					goto IL_A0;
				}
				goto IL_A0;
				IL_AD:
				i++;
				continue;
				IL_A0:
				this.method_0(frmMainProfilesPremium.Profile, ref CS$<>8__locals1);
				goto IL_AD;
			}
			if (this.GetNextLocation(this.panelTabMailbox).Y == 14)
			{
				this.lblMailboxStatus.Visible = true;
			}
			if (this.GetNextLocation(this.panelTabVendor).Y == 14)
			{
				this.lblVendorStatus.Visible = true;
			}
			if (this.GetNextLocation(this.panelTabGathering).Y == 14)
			{
				this.lblGatherStatus.Visible = true;
			}
			Tools.CloseForm("frmLoading", Array.Empty<object>());
			Form form = Application.OpenForms["frmMain"];
			base.Location = new Point(form.Location.X + (form.Width - base.Width) / 2, form.Location.Y + (form.Height - base.Height) / 2);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0068D360 File Offset: 0x0068B560
		private void CreateGeneral(int ProfileID, string ProfileDisplayName, PremiumSettings PremiumProfileSettings)
		{
			string str = ProfileID.ToString();
			string combatMode = PremiumProfileSettings.CombatMode;
			string waypointMode = PremiumProfileSettings.WaypointMode;
			bool followFleeingTarget = PremiumProfileSettings.FollowFleeingTarget;
			bool groundMount = PremiumProfileSettings.GroundMount;
			bool flightMount = PremiumProfileSettings.FlightMount;
			bool hasPvP;
			bool @checked = (hasPvP = PremiumProfileSettings.HasPvP) && PremiumProfileSettings.BattlegroundWarsongGulch;
			bool checked2 = hasPvP && PremiumProfileSettings.BattlegroundArathiBasin;
			bool checked3 = hasPvP && PremiumProfileSettings.BattlegroundAlteracValley;
			bool checked4 = hasPvP && PremiumProfileSettings.BattlegroundEyeOfTheStorm;
			bool checked5 = hasPvP && PremiumProfileSettings.BattlegroundStrandOfTheAncients;
			Guna2GroupBox guna2GroupBox = this.CreateGroupBox("grpGeneral_" + str, ProfileDisplayName, this.GetNextLocation(this.panelTabGeneral), new Size(519, 234));
			object[] items;
			if (flightMount)
			{
				items = new object[]
				{
					"--- Combat Mode ---",
					"Defensive",
					"Ignore"
				};
			}
			else
			{
				items = new object[]
				{
					"--- Combat Mode ---",
					"Offensive",
					"Defensive",
					"Gather",
					"Ignore",
					"PvP (Offensive)",
					"PvP (Defensive)"
				};
			}
			object[] items2 = new object[]
			{
				"--- Waypoint Mode ---",
				"Best",
				"Closest",
				"Straight"
			};
			Guna2ComboBox guna2ComboBox = this.CreateSelect("selectGeneralCombatMode_" + str, items, combatMode, new Point(25, 62), new Size(236, 30));
			Guna2ComboBox guna2ComboBox2 = this.CreateSelect("selectGeneralWaypointMode_" + str, items2, waypointMode, new Point(25, 98), new Size(236, 30));
			Guna2CheckBox guna2CheckBox = this.CreateCheckBox("checkFollowFleeingTarget_" + str, "Follow fleeing Target", new Point(297, 62), default(Color), true, followFleeingTarget);
			Guna2CheckBox guna2CheckBox2 = this.CreateCheckBox("checkGroundMount_" + str, "Use Ground Mount if learned", new Point(297, 87), default(Color), true, groundMount);
			Guna2CheckBox guna2CheckBox3 = this.CreateCheckBox("checkFlightMount_" + str, "Use Flight Mount if learned", new Point(297, 111), default(Color), true, flightMount);
			Guna2Separator value = this.CreateSeparator("sepGeneral1_" + str, new Point(16, 144));
			Guna2CheckBox guna2CheckBox4 = this.CreateCheckBox("checkGeneralBattlegroundWarsongGulch_" + str, "Join Warsong Gulch", new Point(25, 171), default(Color), hasPvP, @checked);
			Guna2CheckBox guna2CheckBox5 = this.CreateCheckBox("checkGeneralBattlegroundArathiBasin_" + str, "Join Arathi Basin", new Point(25, 196), default(Color), hasPvP, checked2);
			Guna2CheckBox guna2CheckBox6 = this.CreateCheckBox("checkGeneralBattlegroundAlteracValley_" + str, "Join Alterac Valley", new Point(186, 171), default(Color), hasPvP, checked3);
			Guna2CheckBox guna2CheckBox7 = this.CreateCheckBox("checkGeneralBattlegroundEyeOfTheStorm_" + str, "Join Eye of the Storm", new Point(186, 196), default(Color), hasPvP, checked4);
			Guna2CheckBox guna2CheckBox8 = this.CreateCheckBox("checkGeneralBattlegroundStrandOfTheAncients_" + str, "Join Strand of the Ancients", new Point(350, 171), default(Color), hasPvP, checked5);
			guna2GroupBox.Controls.Add(guna2ComboBox);
			guna2GroupBox.Controls.Add(guna2ComboBox2);
			guna2GroupBox.Controls.Add(guna2CheckBox);
			guna2GroupBox.Controls.Add(guna2CheckBox2);
			guna2GroupBox.Controls.Add(guna2CheckBox3);
			guna2GroupBox.Controls.Add(value);
			guna2GroupBox.Controls.Add(guna2CheckBox4);
			guna2GroupBox.Controls.Add(guna2CheckBox5);
			guna2GroupBox.Controls.Add(guna2CheckBox6);
			guna2GroupBox.Controls.Add(guna2CheckBox7);
			guna2GroupBox.Controls.Add(guna2CheckBox8);
			guna2ComboBox.SelectedIndexChanged += delegate(object sender, EventArgs e)
			{
				this.selectGeneral_SelectedIndexChanged(sender, e, ProfileID);
			};
			guna2ComboBox2.SelectedIndexChanged += delegate(object sender, EventArgs e)
			{
				this.selectGeneral_SelectedIndexChanged(sender, e, ProfileID);
			};
			guna2CheckBox.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneral_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox2.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneral_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox3.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneral_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox4.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneralPvP_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox5.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneralPvP_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox6.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneralPvP_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox7.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneralPvP_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox8.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkGeneralPvP_CheckedChanged(sender, e, ProfileID);
			};
			this.panelTabGeneral.Controls.Add(guna2GroupBox);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0068D83C File Offset: 0x0068BA3C
		private void selectGeneral_SelectedIndexChanged(object sender, EventArgs e, int ProfileID)
		{
			Guna2ComboBox guna2ComboBox = sender as Guna2ComboBox;
			string text = guna2ComboBox.SelectedItem.ToString();
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null)
			{
				if (text.Length > 0 && !text.Contains("---"))
				{
					if (guna2ComboBox.Name.Contains("CombatMode"))
					{
						profileByID.CombatMode = text;
					}
					else if (guna2ComboBox.Name.Contains("WaypointMode"))
					{
						profileByID.WaypointMode = text;
					}
				}
				Json.SaveAndReloadPremiumSettings();
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0068D8B8 File Offset: 0x0068BAB8
		private void checkGeneral_CheckedChanged(object sender, EventArgs e, int ProfileID)
		{
			Guna2CheckBox guna2CheckBox = sender as Guna2CheckBox;
			bool @checked = guna2CheckBox.Checked;
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null)
			{
				int checked2 = 1;
				if (@checked)
				{
					checked2 = 2;
				}
				if (guna2CheckBox.Name.Contains("FollowFleeingTarget"))
				{
					profileByID.FollowFleeingTarget = @checked;
				}
				else if (!guna2CheckBox.Name.Contains("GroundMount"))
				{
					if (guna2CheckBox.Name.Contains("FlightMount"))
					{
						profileByID.FlightMount = @checked;
						if (@checked)
						{
							Tools.Control("", "checkGroundMount_" + ProfileID.ToString(), "frmMainProfilesPremium", true, false, false, false, checked2);
							this.CombatModeSelection("selectGeneralCombatMode_" + ProfileID.ToString(), "Flight");
						}
						else
						{
							this.CombatModeSelection("selectGeneralCombatMode_" + ProfileID.ToString(), "");
						}
					}
				}
				else
				{
					profileByID.GroundMount = @checked;
					if (@checked)
					{
						Tools.Control("", "checkFlightMount_" + ProfileID.ToString(), "frmMainProfilesPremium", true, false, false, false, checked2);
						this.CombatModeSelection("selectGeneralCombatMode_" + ProfileID.ToString(), "");
					}
				}
				Json.SaveAndReloadPremiumSettings();
			}
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0068D9EC File Offset: 0x0068BBEC
		private void CombatModeSelection(string ControlName, string Mode = "")
		{
			frmMainProfilesPremium.<>c__DisplayClass12_0 CS$<>8__locals1 = new frmMainProfilesPremium.<>c__DisplayClass12_0();
			CS$<>8__locals1.Mode = Mode;
			Form form = Application.OpenForms["frmMainProfilesPremium"];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					Control[] array = form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						CS$<>8__locals1.Control = array[0];
						if (CS$<>8__locals1.Control != null)
						{
							if (form.InvokeRequired)
							{
								CS$<>8__locals1.Control.Invoke(new Action(delegate()
								{
									base.method_0();
								}));
							}
							else
							{
								CS$<>8__locals1.method_0();
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0068DA80 File Offset: 0x0068BC80
		private void checkGeneralPvP_CheckedChanged(object sender, EventArgs e, int ProfileID)
		{
			Guna2CheckBox guna2CheckBox = sender as Guna2CheckBox;
			bool @checked = guna2CheckBox.Checked;
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null)
			{
				if (!guna2CheckBox.Name.Contains("Warsong"))
				{
					if (!guna2CheckBox.Name.Contains("Arathi"))
					{
						if (!guna2CheckBox.Name.Contains("Alterac"))
						{
							if (guna2CheckBox.Name.Contains("Storm"))
							{
								profileByID.BattlegroundEyeOfTheStorm = @checked;
							}
							else if (guna2CheckBox.Name.Contains("Ancients"))
							{
								profileByID.BattlegroundStrandOfTheAncients = @checked;
							}
						}
						else
						{
							profileByID.BattlegroundAlteracValley = @checked;
						}
					}
					else
					{
						profileByID.BattlegroundArathiBasin = @checked;
					}
				}
				else
				{
					profileByID.BattlegroundWarsongGulch = @checked;
				}
				Json.SaveAndReloadPremiumSettings();
			}
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0068DB34 File Offset: 0x0068BD34
		private void CreateMailbox(int ProfileID, string ProfileDisplayName, PremiumSettings PremiumProfileSettings)
		{
			string str = ProfileID.ToString();
			string mailboxReceiver = PremiumProfileSettings.MailboxReceiver;
			bool mailboxSendGreys = PremiumProfileSettings.MailboxSendGreys;
			bool mailboxSendWhites = PremiumProfileSettings.MailboxSendWhites;
			bool mailboxSendGreens = PremiumProfileSettings.MailboxSendGreens;
			bool mailboxSendBlues = PremiumProfileSettings.MailboxSendBlues;
			bool mailboxSendPurples = PremiumProfileSettings.MailboxSendPurples;
			List<string> mailboxSendlist = PremiumProfileSettings.MailboxSendlist;
			Guna2GroupBox guna2GroupBox = this.CreateGroupBox("grpMailbox_" + str, ProfileDisplayName, this.GetNextLocation(this.panelTabMailbox), new Size(519, 199));
			Guna2TextBox txtMailboxReceiver = this.CreateTextBox("txtMailboxReceiver_" + str, mailboxReceiver, "Receiver", new Point(25, 62), new Size(286, 30));
			Guna2CheckBox guna2CheckBox = this.CreateCheckBox("checkMailboxSendGreys_" + str, "Send all Grays", new Point(25, 111), Color.DarkGray, true, mailboxSendGreys);
			Guna2CheckBox guna2CheckBox2 = this.CreateCheckBox("checkMailboxSendWhites_" + str, "Send all Whites", new Point(25, 136), default(Color), true, mailboxSendWhites);
			Guna2CheckBox guna2CheckBox3 = this.CreateCheckBox("checkMailboxSendGreens_" + str, "Send all Greens", new Point(25, 161), Color.Lime, true, mailboxSendGreens);
			Guna2CheckBox guna2CheckBox4 = this.CreateCheckBox("checkMailboxSendBlues_" + str, "Send all Blues", new Point(180, 111), Color.DeepSkyBlue, true, mailboxSendBlues);
			Guna2CheckBox guna2CheckBox5 = this.CreateCheckBox("checkMailboxSendPurples_" + str, "Send all Purples", new Point(180, 136), Color.Fuchsia, true, mailboxSendPurples);
			string text = "Sendlist";
			int count = mailboxSendlist.Count;
			if (count > 0)
			{
				text = text + " (" + count.ToString() + ")";
			}
			Guna2Button guna2Button = this.CreateButton("btnMailboxReceiverApply_" + str, "Apply", new Point(317, 62), new Size(114, 31), "TopLeft");
			Guna2Button guna2Button2 = this.CreateButton("btnMailboxSendlist_" + str, text, new Point(317, 111), new Size(114, 31), "TopLeft");
			Guna2Button guna2Button3 = this.CreateCopyButton("btnMailboxCopy_" + str, guna2GroupBox.Width);
			guna2GroupBox.Controls.Add(txtMailboxReceiver);
			guna2GroupBox.Controls.Add(guna2CheckBox);
			guna2GroupBox.Controls.Add(guna2CheckBox2);
			guna2GroupBox.Controls.Add(guna2CheckBox3);
			guna2GroupBox.Controls.Add(guna2CheckBox4);
			guna2GroupBox.Controls.Add(guna2CheckBox5);
			guna2GroupBox.Controls.Add(guna2Button);
			guna2GroupBox.Controls.Add(guna2Button2);
			guna2GroupBox.Controls.Add(guna2Button3);
			guna2CheckBox.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkMailbox_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox2.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkMailbox_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox3.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkMailbox_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox4.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkMailbox_CheckedChanged(sender, e, ProfileID);
			};
			guna2CheckBox5.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkMailbox_CheckedChanged(sender, e, ProfileID);
			};
			guna2Button.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.btnMailboxReceiver(sender, e, ProfileID, txtMailboxReceiver.Text);
			};
			guna2Button2.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.btnMailboxList(sender, e, ProfileID);
			};
			guna2Button3.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.btnMailboxCopySettings(sender, e, ProfileID);
			};
			this.panelTabMailbox.Controls.Add(guna2GroupBox);
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0068DEB0 File Offset: 0x0068C0B0
		private void btnMailboxReceiver(object sender, EventArgs e, int ProfileID, string Receiver)
		{
			Guna2Button guna2Button = sender as Guna2Button;
			if (guna2Button.Text != "Saved")
			{
				Tools.SwitchButtonColor("Saved", guna2Button.Text, guna2Button.Name, base.Name, "ForestGreen");
			}
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID == null)
			{
				return;
			}
			profileByID.MailboxReceiver = Receiver;
			Json.SaveAndReloadPremiumSettings();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0068DF10 File Offset: 0x0068C110
		private void btnMailboxList(object sender, EventArgs e, int ProfileID)
		{
			Guna2Button guna2Button = sender as Guna2Button;
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null)
			{
				frmList.CustomList = profileByID.MailboxSendlist;
				frmList.CustomButtonName = guna2Button.Name;
				frmList.CustomFormName = "frmMainProfilesPremium";
				object[] args = new object[]
				{
					"MailboxSendlist"
				};
				Tools.OpenForm("frmList", true, "frmMainProfilesPremium", args);
				profileByID.MailboxSendlist = frmList.CustomList;
				Json.SaveAndReloadPremiumSettings();
				this.ResetFrmList();
				return;
			}
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0068DF88 File Offset: 0x0068C188
		private void checkMailbox_CheckedChanged(object sender, EventArgs e, int ProfileID)
		{
			Guna2CheckBox guna2CheckBox = sender as Guna2CheckBox;
			bool @checked = guna2CheckBox.Checked;
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null)
			{
				if (guna2CheckBox.Name.Contains("Greys"))
				{
					profileByID.MailboxSendGreys = @checked;
				}
				else if (!guna2CheckBox.Name.Contains("Whites"))
				{
					if (!guna2CheckBox.Name.Contains("Greens"))
					{
						if (guna2CheckBox.Name.Contains("Blues"))
						{
							profileByID.MailboxSendBlues = @checked;
						}
						else if (guna2CheckBox.Name.Contains("Purples"))
						{
							profileByID.MailboxSendPurples = @checked;
						}
					}
					else
					{
						profileByID.MailboxSendGreens = @checked;
					}
				}
				else
				{
					profileByID.MailboxSendWhites = @checked;
				}
				Json.SaveAndReloadPremiumSettings();
			}
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0068E03C File Offset: 0x0068C23C
		private void btnMailboxCopySettings(object sender, EventArgs e, int ProfileID)
		{
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID == null || !frmMainProfilesPremium.Profile.IsConnected)
			{
				return;
			}
			if (MessageBox.Show("Do you want to apply these settings to all profiles?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}
			string mailboxReceiver = profileByID.MailboxReceiver;
			bool mailboxSendGreys = profileByID.MailboxSendGreys;
			bool mailboxSendWhites = profileByID.MailboxSendWhites;
			bool mailboxSendGreens = profileByID.MailboxSendGreens;
			bool mailboxSendBlues = profileByID.MailboxSendBlues;
			bool mailboxSendPurples = profileByID.MailboxSendPurples;
			List<string> mailboxSendlist = profileByID.MailboxSendlist;
			foreach (PFLS pfls in PFL.GetConnectedProfiles(frmMainProfilesPremium.Profile))
			{
				PremiumSettings profileByID2 = PremiumSettings.GetProfileByID(pfls.ID);
				if (profileByID2 != null && profileByID2.HasMailbox)
				{
					profileByID2.MailboxReceiver = mailboxReceiver;
					profileByID2.MailboxSendGreys = mailboxSendGreys;
					profileByID2.MailboxSendWhites = mailboxSendWhites;
					profileByID2.MailboxSendGreens = mailboxSendGreens;
					profileByID2.MailboxSendBlues = mailboxSendBlues;
					profileByID2.MailboxSendPurples = mailboxSendPurples;
					profileByID2.MailboxSendlist = mailboxSendlist;
				}
			}
			MessageBox.Show("All settings have been applied successfully.\r\nPlease re-edit this profile to see the changes.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Json.SaveAndReloadPremiumSettings();
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0068E168 File Offset: 0x0068C368
		private void CreateVendor(int ProfileID, string ProfileDisplayName, string NPCName, Dictionary<string, object> Vendor)
		{
			string str = ProfileID.ToString();
			bool @checked = (bool)Vendor["SellGreys"];
			bool checked2 = (bool)Vendor["SellWhites"];
			bool checked3 = (bool)Vendor["SellGreens"];
			bool checked4 = (bool)Vendor["SellBlues"];
			bool checked5 = (bool)Vendor["CanRepair"];
			List<string> Whitelist = JsonConvert.DeserializeObject<List<string>>(Vendor["Whitelist"].ToString());
			List<string> Buylist = JsonConvert.DeserializeObject<List<string>>(Vendor["Buylist"].ToString());
			Guna2GroupBox guna2GroupBox = this.CreateGroupBox("grpVendor_" + str, NPCName + " (" + ProfileDisplayName + ")", this.GetNextLocation(this.panelTabVendor), new Size(519, 171));
			Guna2CheckBox guna2CheckBox = this.CreateCheckBox("checkVendorSellGreys_" + str, "Sell all Grays", new Point(25, 60), Color.DarkGray, true, @checked);
			Guna2CheckBox guna2CheckBox2 = this.CreateCheckBox("checkVendorSellWhites_" + str, "Sell all Whites", new Point(25, 85), default(Color), true, checked2);
			Guna2CheckBox guna2CheckBox3 = this.CreateCheckBox("checkVendorSellGreens_" + str, "Sell all Greens", new Point(25, 110), Color.Lime, true, checked3);
			Guna2CheckBox guna2CheckBox4 = this.CreateCheckBox("checkVendorSellBlues_" + str, "Sell all Blues", new Point(25, 135), Color.DeepSkyBlue, true, checked4);
			Guna2CheckBox value = this.CreateCheckBox("checkVendorCanRepair_" + str, "Can Repair", new Point(180, 60), default(Color), false, checked5);
			string text = "Whitelist";
			int count = Whitelist.Count;
			if (count > 0)
			{
				text = text + " (" + count.ToString() + ")";
			}
			string text2 = "Buylist";
			int count2 = Buylist.Count;
			if (count2 > 0)
			{
				text2 = text2 + " (" + count2.ToString() + ")";
			}
			Guna2Button guna2Button = this.CreateButton("btnVendorWhitelist_" + str, text, new Point(317, 60), new Size(114, 31), "TopLeft");
			Guna2Button guna2Button2 = this.CreateButton("btnVendorBuylist_" + str, text2, new Point(317, 98), new Size(114, 31), "TopLeft");
			Guna2Button guna2Button3 = this.CreateCopyButton("btnMailboxCopy_" + str, guna2GroupBox.Width);
			guna2GroupBox.Controls.Add(guna2CheckBox);
			guna2GroupBox.Controls.Add(guna2CheckBox2);
			guna2GroupBox.Controls.Add(guna2CheckBox3);
			guna2GroupBox.Controls.Add(guna2CheckBox4);
			guna2GroupBox.Controls.Add(value);
			guna2GroupBox.Controls.Add(guna2Button);
			guna2GroupBox.Controls.Add(guna2Button2);
			guna2GroupBox.Controls.Add(guna2Button3);
			guna2CheckBox.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkVendor_CheckedChanged(sender, e, ProfileID, NPCName);
			};
			guna2CheckBox2.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkVendor_CheckedChanged(sender, e, ProfileID, NPCName);
			};
			guna2CheckBox3.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkVendor_CheckedChanged(sender, e, ProfileID, NPCName);
			};
			guna2CheckBox4.CheckedChanged += delegate(object sender, EventArgs e)
			{
				this.checkVendor_CheckedChanged(sender, e, ProfileID, NPCName);
			};
			guna2Button.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.btnVendorList(sender, e, ProfileID, NPCName, Whitelist);
			};
			guna2Button2.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.btnVendorList(sender, e, ProfileID, NPCName, Buylist);
			};
			guna2Button3.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.btnVendorCopySettings(sender, e, ProfileID, NPCName);
			};
			this.panelTabVendor.Controls.Add(guna2GroupBox);
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0068E53C File Offset: 0x0068C73C
		private void btnVendorList(object sender, EventArgs e, int ProfileID, string NPCName, List<string> WhichList)
		{
			Guna2Button guna2Button = sender as Guna2Button;
			string text = "Whitelist";
			if (guna2Button.Name.Contains("Buylist"))
			{
				text = "Buylist";
			}
			frmList.CustomList = WhichList;
			frmList.CustomButtonName = guna2Button.Name;
			frmList.CustomFormName = "frmMainProfilesPremium";
			object[] args = new object[]
			{
				"Vendor" + text
			};
			Tools.OpenForm("frmList", true, "frmMain", args);
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null && profileByID.Vendor.ContainsKey(NPCName))
			{
				profileByID.Vendor[NPCName][text] = frmList.CustomList;
				Json.SaveAndReloadPremiumSettings();
			}
			this.ResetFrmList();
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0068E5EC File Offset: 0x0068C7EC
		private void checkVendor_CheckedChanged(object sender, EventArgs e, int ProfileID, string NPCName)
		{
			Guna2CheckBox guna2CheckBox = sender as Guna2CheckBox;
			string key = "";
			if (!guna2CheckBox.Name.Contains("Greys"))
			{
				if (guna2CheckBox.Name.Contains("Whites"))
				{
					key = "SellWhites";
				}
				else if (!guna2CheckBox.Name.Contains("Greens"))
				{
					if (guna2CheckBox.Name.Contains("Blues"))
					{
						key = "SellBlues";
					}
				}
				else
				{
					key = "SellGreens";
				}
			}
			else
			{
				key = "SellGreys";
			}
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null && profileByID.Vendor.ContainsKey(NPCName))
			{
				profileByID.Vendor[NPCName][key] = guna2CheckBox.Checked;
				Json.SaveAndReloadPremiumSettings();
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0068E6A8 File Offset: 0x0068C8A8
		private void btnVendorCopySettings(object sender, EventArgs e, int ProfileID, string NPCName)
		{
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID == null || !frmMainProfilesPremium.Profile.IsConnected || !profileByID.Vendor.ContainsKey(NPCName))
			{
				return;
			}
			if (MessageBox.Show("Do you want to apply these settings to all profiles?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Dictionary<string, object> dictionary = profileByID.Vendor[NPCName];
				bool flag = (bool)dictionary["SellGreys"];
				bool flag2 = (bool)dictionary["SellWhites"];
				bool flag3 = (bool)dictionary["SellGreens"];
				bool flag4 = (bool)dictionary["SellBlues"];
				List<string> value = JsonConvert.DeserializeObject<List<string>>(dictionary["Whitelist"].ToString());
				List<string> value2 = JsonConvert.DeserializeObject<List<string>>(dictionary["Buylist"].ToString());
				foreach (KeyValuePair<string, Dictionary<string, object>> keyValuePair in profileByID.Vendor)
				{
					string key = keyValuePair.Key;
					Dictionary<string, object> value3 = keyValuePair.Value;
					if (!(key == NPCName))
					{
						value3["SellGreys"] = flag;
						value3["SellWhites"] = flag2;
						value3["SellGreens"] = flag3;
						value3["SellBlues"] = flag4;
						value3["Whitelist"] = value;
						value3["Buylist"] = value2;
					}
				}
				foreach (PFLS pfls in PFL.GetConnectedProfiles(frmMainProfilesPremium.Profile))
				{
					PremiumSettings profileByID2 = PremiumSettings.GetProfileByID(pfls.ID);
					if (profileByID2 != null && profileByID2.HasVendor)
					{
						foreach (KeyValuePair<string, Dictionary<string, object>> keyValuePair2 in profileByID2.Vendor)
						{
							string key2 = keyValuePair2.Key;
							Dictionary<string, object> value4 = keyValuePair2.Value;
							value4["SellGreys"] = flag;
							value4["SellWhites"] = flag2;
							value4["SellGreens"] = flag3;
							value4["SellBlues"] = flag4;
							value4["Whitelist"] = value;
							value4["Buylist"] = value2;
						}
					}
				}
				MessageBox.Show("All settings have been applied successfully.\r\nPlease re-edit this profile to see the changes.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Json.SaveAndReloadPremiumSettings();
				return;
			}
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0068E974 File Offset: 0x0068CB74
		private void CreateGather(int ProfileID, string ProfileDisplayName, PremiumSettings PremiumProfileSettings)
		{
			string str = ProfileID.ToString();
			bool gatherMining = PremiumProfileSettings.GatherMining;
			bool gatherHerbalism = PremiumProfileSettings.GatherHerbalism;
			bool gatherSkinning = PremiumProfileSettings.GatherSkinning;
			Guna2GroupBox guna2GroupBox = this.CreateGroupBox("grpGather_" + str, ProfileDisplayName, this.GetNextLocation(this.panelTabGathering), new Size(519, 146));
			Guna2CheckBox guna2CheckBox = this.CreateCheckBox("checkGatherMining_" + str, "Mining", new Point(25, 60), default(Color), true, gatherMining);
			Guna2CheckBox guna2CheckBox2 = this.CreateCheckBox("checkGatherHerbalism_" + str, "Herbalism", new Point(25, 85), default(Color), true, gatherHerbalism);
			Guna2CheckBox guna2CheckBox3 = this.CreateCheckBox("checkGatherSkinning_" + str, "Skinning", new Point(25, 110), default(Color), true, gatherSkinning);
			Guna2Button guna2Button = this.CreateCopyButton("btnMailboxCopy_" + str, guna2GroupBox.Width);
			Guna2PictureBox guna2PictureBox = new Guna2PictureBox();
			guna2PictureBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			guna2PictureBox.BackColor = Color.Transparent;
			guna2PictureBox.Image = Resources.module_gathering;
			guna2PictureBox.ImageRotate = 0f;
			guna2PictureBox.Location = new Point(345, 7);
			guna2PictureBox.Name = "imgModuleGather";
			guna2PictureBox.Size = new Size(137, 24);
			guna2PictureBox.TabIndex = 90;
			guna2PictureBox.TabStop = false;
			guna2GroupBox.Controls.Add(guna2CheckBox);
			guna2GroupBox.Controls.Add(guna2CheckBox2);
			guna2GroupBox.Controls.Add(guna2CheckBox3);
			guna2GroupBox.Controls.Add(guna2PictureBox);
			guna2GroupBox.Controls.Add(guna2Button);
			if (_globals.ModuleGather)
			{
				guna2CheckBox.CheckedChanged += delegate(object sender, EventArgs e)
				{
					this.checkGather_CheckedChanged(sender, e, ProfileID);
				};
				guna2CheckBox2.CheckedChanged += delegate(object sender, EventArgs e)
				{
					this.checkGather_CheckedChanged(sender, e, ProfileID);
				};
				guna2CheckBox3.CheckedChanged += delegate(object sender, EventArgs e)
				{
					this.checkGather_CheckedChanged(sender, e, ProfileID);
				};
				guna2Button.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.btnGatherCopySettings(sender, e, ProfileID);
				};
			}
			else
			{
				guna2CheckBox.Enabled = false;
				guna2CheckBox2.Enabled = false;
				guna2CheckBox3.Enabled = false;
				guna2Button.Enabled = false;
				guna2PictureBox.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.checkGather_MouseClick(sender, e);
				};
			}
			this.panelTabGathering.Controls.Add(guna2GroupBox);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x0068EBE4 File Offset: 0x0068CDE4
		private void checkGather_CheckedChanged(object sender, EventArgs e, int ProfileID)
		{
			Guna2CheckBox guna2CheckBox = sender as Guna2CheckBox;
			bool @checked = guna2CheckBox.Checked;
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID != null)
			{
				if (guna2CheckBox.Name.Contains("Mining"))
				{
					profileByID.GatherMining = @checked;
				}
				else if (!guna2CheckBox.Name.Contains("Herbalism"))
				{
					if (guna2CheckBox.Name.Contains("Skinning"))
					{
						profileByID.GatherSkinning = @checked;
					}
				}
				else
				{
					profileByID.GatherHerbalism = @checked;
				}
				Json.SaveAndReloadPremiumSettings();
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0068EC60 File Offset: 0x0068CE60
		private void checkGather_MouseClick(object sender, MouseEventArgs e)
		{
			CustomUI.DialogModule("frmMainProfilesPremium");
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0068EC78 File Offset: 0x0068CE78
		private void btnGatherCopySettings(object sender, EventArgs e, int ProfileID)
		{
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(ProfileID);
			if (profileByID == null || !frmMainProfilesPremium.Profile.IsConnected)
			{
				return;
			}
			if (MessageBox.Show("Do you want to apply these settings to all profiles?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
			{
				return;
			}
			bool gatherMining = profileByID.GatherMining;
			bool gatherHerbalism = profileByID.GatherHerbalism;
			bool gatherSkinning = profileByID.GatherSkinning;
			foreach (PFLS pfls in PFL.GetConnectedProfiles(frmMainProfilesPremium.Profile))
			{
				PremiumSettings profileByID2 = PremiumSettings.GetProfileByID(pfls.ID);
				if (profileByID2 != null && profileByID2.HasGather)
				{
					profileByID2.GatherMining = gatherMining;
					profileByID2.GatherHerbalism = gatherHerbalism;
					profileByID2.GatherSkinning = gatherSkinning;
				}
			}
			MessageBox.Show("All settings have been applied successfully.\r\nPlease re-edit this profile to see the changes.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Json.SaveAndReloadPremiumSettings();
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0068ED60 File Offset: 0x0068CF60
		private Point GetNextLocation(Guna2Panel Panel)
		{
			int x = 14;
			int num = 14;
			foreach (object obj in Panel.Controls)
			{
				if (obj.GetType() == typeof(Guna2GroupBox))
				{
					Guna2GroupBox guna2GroupBox = obj as Guna2GroupBox;
					if (!guna2GroupBox.Name.Contains("PREVIEW"))
					{
						num += guna2GroupBox.Height + 14;
					}
				}
			}
			return new Point(x, num);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0068EE00 File Offset: 0x0068D000
		private Guna2GroupBox CreateGroupBox(string Name, string Text, Point Location, Size Size)
		{
			Guna2GroupBox guna2GroupBox = new Guna2GroupBox();
			guna2GroupBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			guna2GroupBox.BorderColor = Color.FromArgb(50, 61, 79);
			guna2GroupBox.CustomBorderColor = Color.FromArgb(50, 61, 79);
			guna2GroupBox.FillColor = Color.FromArgb(27, 33, 43);
			guna2GroupBox.Font = new Font("Segoe UI", 9f);
			guna2GroupBox.ForeColor = Color.White;
			guna2GroupBox.Margin = new Padding(0, 0, 9, 0);
			guna2GroupBox.Location = Location;
			guna2GroupBox.Size = Size;
			guna2GroupBox.Name = Name;
			guna2GroupBox.Text = "";
			string str = "";
			if (Name.Contains("_"))
			{
				str = Name.Split(new char[]
				{
					'_'
				})[1];
			}
			Guna2HtmlLabel guna2HtmlLabel = new Guna2HtmlLabel();
			guna2HtmlLabel.BackColor = Color.Transparent;
			guna2HtmlLabel.ForeColor = Color.White;
			guna2HtmlLabel.Location = new Point(11, 12);
			guna2HtmlLabel.Name = "lblGrpTitle_" + str;
			guna2HtmlLabel.Size = new Size(41, 17);
			guna2HtmlLabel.Text = Text;
			guna2GroupBox.Controls.Add(guna2HtmlLabel);
			return guna2GroupBox;
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0068EF28 File Offset: 0x0068D128
		private Guna2CheckBox CreateCheckBox(string Name, string Text, Point Location, Color Clr = default(Color), bool Enabled = true, bool Checked = false)
		{
			if (Clr == default(Color))
			{
				Clr = Color.White;
			}
			return new Guna2CheckBox
			{
				Animated = true,
				AutoSize = true,
				BackColor = Color.Transparent,
				CheckedState = 
				{
					BorderColor = Color.FromArgb(94, 148, 255),
					BorderRadius = 0,
					BorderThickness = 0,
					FillColor = Color.FromArgb(94, 148, 255)
				},
				ForeColor = Clr,
				UncheckedState = 
				{
					BorderColor = Color.DimGray,
					BorderRadius = 0,
					BorderThickness = 1,
					FillColor = Color.FromArgb(50, 61, 79)
				},
				UseVisualStyleBackColor = false,
				Location = Location,
				Name = Name,
				Text = Text,
				Enabled = Enabled,
				Checked = Checked
			};
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0068F030 File Offset: 0x0068D230
		private Guna2Button CreateButton(string Name, string Text, Point Location, Size Size, string Anchor = "TopLeft")
		{
			AnchorStyles anchor = AnchorStyles.Top | AnchorStyles.Left;
			if (Anchor == "TopRight")
			{
				anchor = (AnchorStyles.Top | AnchorStyles.Right);
			}
			return new Guna2Button
			{
				BorderColor = Color.Gray,
				BorderThickness = 1,
				DisabledState = 
				{
					BorderColor = Color.DimGray,
					CustomBorderColor = Color.DimGray,
					FillColor = Color.FromArgb(27, 33, 43),
					ForeColor = Color.FromArgb(141, 141, 141)
				},
				FillColor = Color.FromArgb(0, 119, 230),
				Font = new Font("Segoe UI", 9f),
				ForeColor = Color.White,
				HoverState = 
				{
					BorderColor = Color.White
				},
				Anchor = anchor,
				Location = Location,
				Size = Size,
				Name = Name,
				Text = Text
			};
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0068F124 File Offset: 0x0068D324
		private Guna2Button CreateCopyButton(string Name, int GroupWidth)
		{
			Guna2Button guna2Button = new Guna2Button();
			guna2Button.BorderColor = Color.Gray;
			guna2Button.BorderThickness = 1;
			guna2Button.DisabledState.BorderColor = Color.DimGray;
			guna2Button.DisabledState.CustomBorderColor = Color.DimGray;
			guna2Button.DisabledState.FillColor = Color.FromArgb(27, 33, 43);
			guna2Button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			guna2Button.FillColor = Color.FromArgb(0, 119, 230);
			guna2Button.Font = new Font("Segoe UI", 9f);
			guna2Button.ForeColor = Color.White;
			guna2Button.HoverState.BorderColor = Color.White;
			guna2Button.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			guna2Button.Image = Resources.copy_16;
			guna2Button.ImageSize = new Size(16, 16);
			guna2Button.Size = new Size(30, 30);
			guna2Button.Location = new Point(GroupWidth - (guna2Button.Width + 5), 5);
			guna2Button.Name = Name;
			return guna2Button;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0068F230 File Offset: 0x0068D430
		private Guna2TextBox CreateTextBox(string Name, string Text, string Placeholder, Point Location, Size Size)
		{
			return new Guna2TextBox
			{
				BorderColor = Color.Gray,
				Cursor = Cursors.IBeam,
				DisabledState = 
				{
					BorderColor = Color.Gray,
					FillColor = Color.FromArgb(70, 75, 82),
					ForeColor = Color.FromArgb(138, 138, 138),
					PlaceholderForeColor = Color.FromArgb(138, 138, 138)
				},
				FillColor = Color.FromArgb(23, 39, 52),
				FocusedState = 
				{
					BorderColor = Color.FromArgb(94, 148, 255)
				},
				Font = new Font("Segoe UI", 9f),
				ForeColor = Color.White,
				HoverState = 
				{
					BorderColor = Color.White
				},
				MaxLength = 200,
				PasswordChar = '\0',
				PlaceholderForeColor = Color.Gray,
				SelectedText = "",
				Location = Location,
				Size = Size,
				Name = Name,
				PlaceholderText = Placeholder,
				DefaultText = Text
			};
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0068F368 File Offset: 0x0068D568
		private Guna2ComboBox CreateSelect(string Name, object[] Items, string SelectedItem, Point Location, Size Size)
		{
			Guna2ComboBox guna2ComboBox = new Guna2ComboBox();
			guna2ComboBox.BackColor = Color.Transparent;
			guna2ComboBox.BorderColor = Color.Gray;
			guna2ComboBox.DisabledState.FillColor = Color.FromArgb(70, 75, 82);
			guna2ComboBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			guna2ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
			guna2ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			guna2ComboBox.FillColor = Color.FromArgb(23, 39, 52);
			guna2ComboBox.FocusedColor = Color.FromArgb(94, 148, 255);
			guna2ComboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			guna2ComboBox.Font = new Font("Segoe UI", 9f);
			guna2ComboBox.ForeColor = Color.White;
			guna2ComboBox.HoverState.BorderColor = Color.White;
			guna2ComboBox.ItemHeight = 24;
			guna2ComboBox.Items.AddRange(Items);
			guna2ComboBox.Location = Location;
			guna2ComboBox.Size = Size;
			guna2ComboBox.Name = Name;
			if (Items.Count<object>() > 0)
			{
				if (SelectedItem.Length > 0)
				{
					guna2ComboBox.SelectedIndex = guna2ComboBox.FindStringExact(SelectedItem);
				}
				if (guna2ComboBox.SelectedIndex == -1)
				{
					guna2ComboBox.SelectedIndex = 0;
				}
			}
			return guna2ComboBox;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0068F4A8 File Offset: 0x0068D6A8
		private Guna2Separator CreateSeparator(string Name, Point Location)
		{
			return new Guna2Separator
			{
				Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right),
				BackColor = Color.Transparent,
				FillColor = Color.FromArgb(50, 61, 79),
				Size = new Size(500, 10),
				Location = Location,
				Name = Name
			};
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0068F500 File Offset: 0x0068D700
		private void SetInfo()
		{
			if (frmMainProfilesPremium.Profile.RequiredLevel > 0)
			{
				this.lblInfoRequirementsLevelData.ForeColor = Color.Orange;
				this.lblInfoRequirementsLevelData.Text = frmMainProfilesPremium.Profile.RequiredLevel.ToString();
			}
			if (frmMainProfilesPremium.Profile.RequiredSkill > 0)
			{
				this.lblInfoRequirementsSkillData.ForeColor = Color.Orange;
				this.lblInfoRequirementsSkillData.Text = frmMainProfilesPremium.Profile.RequiredSkill.ToString();
			}
			this.lblInfoContactStoreNameData.Text = frmMainProfilesPremium.Profile.VendorStoreName;
			this.lblInfoContactDiscordUsernameData.Text = frmMainProfilesPremium.Profile.VendorDiscordUsername;
			this.lblInfoContactEmailData.Text = frmMainProfilesPremium.Profile.VendorEmail;
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00682420 File Offset: 0x00680620
		private void ResetFrmList()
		{
			frmList.CustomList = null;
			frmList.CustomButtonName = "";
			frmList.CustomFormName = "";
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0068F5C0 File Offset: 0x0068D7C0
		private void btnClose_Click(object sender, EventArgs e)
		{
			Json.LoadProfile(frmMainProfilesPremium.Profile.ID.ToString(), true, true, true);
			base.Close();
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0068F5F0 File Offset: 0x0068D7F0
		private void btnTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			Tooltip tooltip = new Tooltip();
			string title = "General";
			string text = "You can change all general settings for this profile and all sub-profiles here. ";
			text += "The default settings are set by the Profile Creator. It is best to adapt them to your wishes.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = "tabGeneral";
			tooltip.MarkControlName = "tabs";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Mailbox";
			text = "Here you can make all settings related to mailboxes in the entire profile. ";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = "tabMailbox";
			tooltip2.MarkControlName = "tabs";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Vendor";
			text = "Set additional settings for vendors here. In the title you will find the NPC name of the vendor.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = "tabVendor";
			tooltip3.MarkControlName = "tabs";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Gathering";
			text = "If a profile includes Gathering, you can set what you want to gather here.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = "tabGathering";
			tooltip4.MarkControlName = "tabs";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Info";
			text = "Here you can find some information about the profile itself.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = "tabInfo";
			tooltip5.MarkControlName = "grpInfoRequirements";
			tooltip5.PinTooltipToControl = true;
			Tooltip tooltip6 = new Tooltip();
			title = "Contact";
			text = "And the contact details from the seller of this profile.";
			tooltip6.Title = title;
			tooltip6.Text = text;
			tooltip6.FormName = base.Name;
			tooltip6.MarkControlName = "grpInfoContact";
			tooltip6.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			list.Add(tooltip6);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00694978 File Offset: 0x00692B78
		[CompilerGenerated]
		private void method_0(PFLS Profile, ref frmMainProfilesPremium.<>c__DisplayClass8_0 <>c__DisplayClass8_0_0)
		{
			PremiumSettings profileByID = PremiumSettings.GetProfileByID(Profile.ID);
			if (profileByID != null)
			{
				if (profileByID.HasGeneral)
				{
					if (<>c__DisplayClass8_0_0.CountFirst)
					{
						int countAllControls = <>c__DisplayClass8_0_0.CountAllControls;
						<>c__DisplayClass8_0_0.CountAllControls = countAllControls + 1;
					}
					else
					{
						this.CreateGeneral(Profile.ID, Profile.DisplayName, profileByID);
						this.method_1(ref <>c__DisplayClass8_0_0);
					}
				}
				if (profileByID.HasMailbox)
				{
					if (!<>c__DisplayClass8_0_0.CountFirst)
					{
						this.CreateMailbox(Profile.ID, Profile.DisplayName, profileByID);
						this.method_1(ref <>c__DisplayClass8_0_0);
					}
					else
					{
						int countAllControls = <>c__DisplayClass8_0_0.CountAllControls;
						<>c__DisplayClass8_0_0.CountAllControls = countAllControls + 1;
					}
				}
				if (profileByID.HasVendor)
				{
					foreach (KeyValuePair<string, Dictionary<string, object>> keyValuePair in profileByID.Vendor)
					{
						string key = keyValuePair.Key;
						Dictionary<string, object> value = keyValuePair.Value;
						if (<>c__DisplayClass8_0_0.CountFirst)
						{
							int countAllControls = <>c__DisplayClass8_0_0.CountAllControls;
							<>c__DisplayClass8_0_0.CountAllControls = countAllControls + 1;
						}
						else
						{
							this.CreateVendor(Profile.ID, Profile.DisplayName, key, value);
							this.method_1(ref <>c__DisplayClass8_0_0);
						}
					}
				}
				if (profileByID.HasGather)
				{
					if (<>c__DisplayClass8_0_0.CountFirst)
					{
						int countAllControls = <>c__DisplayClass8_0_0.CountAllControls;
						<>c__DisplayClass8_0_0.CountAllControls = countAllControls + 1;
						return;
					}
					this.CreateGather(Profile.ID, Profile.DisplayName, profileByID);
					this.method_1(ref <>c__DisplayClass8_0_0);
				}
			}
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00694ADC File Offset: 0x00692CDC
		[CompilerGenerated]
		private void method_1(ref frmMainProfilesPremium.<>c__DisplayClass8_0 <>c__DisplayClass8_0_0)
		{
			int countCurrentControl = <>c__DisplayClass8_0_0.CountCurrentControl;
			<>c__DisplayClass8_0_0.CountCurrentControl = countCurrentControl + 1;
			Tools.SetProgress("frmLoading", "progress", <>c__DisplayClass8_0_0.CountCurrentControl, false, "");
		}

		// Token: 0x04000328 RID: 808
		public static PFLS Profile;
	}
}
