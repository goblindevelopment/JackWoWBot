using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
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
	// Token: 0x020000B2 RID: 178
	public partial class frmRotation : Form
	{
		// Token: 0x06001259 RID: 4697 RVA: 0x006ED200 File Offset: 0x006EB400
		public frmRotation()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			frmProfile.ReleaseActivities();
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x006ED224 File Offset: 0x006EB424
		private void frmRotation_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Rotation Manager", true, true, true, true, false, false);
			this.SetWindowSizeAndPosition();
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x006ED248 File Offset: 0x006EB448
		private void SetWindowSizeAndPosition()
		{
			if (Jack.Core.Settings.WindowRotationLocation.X != 0 && Jack.Core.Settings.WindowRotationLocation.Y != 0)
			{
				base.Location = Jack.Core.Settings.WindowRotationLocation;
			}
			if (Jack.Core.Settings.WindowRotationSize.Width != 0 && Jack.Core.Settings.WindowRotationSize.Height != 0)
			{
				base.Width = Jack.Core.Settings.WindowRotationSize.Width;
				base.Height = Jack.Core.Settings.WindowRotationSize.Height;
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmRotation_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x006ED2B0 File Offset: 0x006EB4B0
		private void listSpells_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x006ED2C4 File Offset: 0x006EB4C4
		private void CenterListViewColumns()
		{
			Tools.ColorListViewHeader(ref this.listSpells, null);
			Tools.CenterListViewColumns(this.listSpells, new int[]
			{
				60,
				60,
				35,
				220,
				100
			});
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x006ED2FC File Offset: 0x006EB4FC
		private void frmRotation_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.ResetControls();
				this.LoadSettings();
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x006ED324 File Offset: 0x006EB524
		private void ResetControls()
		{
			int num = 25;
			if (_globals.Ready && ObjectManager.Me != null && ObjectManager.Me.IsMelee)
			{
				num = 5;
			}
			this.txtPullDistance.Text = num.ToString();
			this.selectFindSpells.SelectedIndex = 0;
			this.selectOptions.SelectedIndex = 0;
			this.checkGSE.Checked = false;
			this.txtGSESettingsClickDelay.Text = _globals.GlobalCooldown.ToString();
			this.checkPetCall.Checked = false;
			this.selectPetCallSpell.Enabled = false;
			this.checkPetRevive.Checked = false;
			this.selectPetReviveSpell.Enabled = false;
			this.checkPetFeed.Checked = false;
			this.txtPetFeedMinutes.Text = "30";
			this.checkPetCombat.Checked = false;
			this.txtPetCombatWait.Enabled = false;
			this.txtPetCombatWait.Text = "3";
			this.checkPetCombatParallel.Checked = false;
			frmRotation.CheckKeybinds();
			this.checkPetCombatReact.Checked = false;
			this.selectPetCombatReactSpell.Enabled = false;
			this.checkPetCombatReactStepBack.Enabled = false;
			this.checkEnchantmentMainHand.Checked = false;
			this.checkEnchantmentOffHand.Checked = false;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x006ED460 File Offset: 0x006EB660
		private void LoadSettings()
		{
			this.LoadProfile();
			this.LoadRotationSpellsToFields();
			this.LoadProfileSettings();
			this.LoadClasses();
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x006ED488 File Offset: 0x006EB688
		private void LoadProfile()
		{
			frmRotation.RecordedRotation.Clear();
			frmRotation.RotationSettings.Clear();
			if (frmRotation.Mode == "Edit")
			{
				Json.LoadRotation(frmRotation.ProfileFolder + frmRotation.ProfileName);
				this.lblProfileName.Visible = true;
				this.lblProfileName.Text = frmRotation.ProfileName;
				if (_globals.Rotation.Count > 0)
				{
					object @lock = frmRotation._lock;
					lock (@lock)
					{
						foreach (Rotation item in _globals.Rotation)
						{
							frmRotation.RecordedRotation.Add(item);
						}
					}
					frmRotation.UpdateList();
				}
				frmRotation.RotationSettings.Add(_globals.RotationSettings[0]);
				frmRotation.Settings = frmRotation.RotationSettings[0];
			}
			new Thread(new ThreadStart(this.LoadSpells))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x006ED5B4 File Offset: 0x006EB7B4
		private void LoadSpells()
		{
			while (!base.IsHandleCreated)
			{
				Thread.Sleep(100);
			}
			if (!_globals.Ready)
			{
				Tools.Control("Please enter World first.", "selectSpells", "frmRotation", false, false, false, false, 0);
				Tools.Control("", "btnAdd", "frmRotation", false, false, false, false, 0);
				Tools.ControlSelect("selectSpells", "frmRotation", "", false);
				return;
			}
			Tools.Control("", "btnAdd", "frmRotation", false, false, false, false, 0);
			Tools.Control("", "btnReload", "frmRotation", false, false, false, false, 0);
			Tools.SpellsToSelectionField("selectSpells", "frmRotation", "", true);
			Tools.ItemsToSelectionField("selectSpells", "frmRotation", "", false);
			Tools.Control("", "btnAdd", "frmRotation", true, false, false, false, 0);
			Tools.Control("", "btnAdd", "frmRotation", true, false, false, false, 0);
			Tools.Control("", "btnReload", "frmRotation", true, false, false, false, 0);
			Tools.Control("", "selectSpells", "frmRotation", true, false, false, false, 0);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x006ED6E4 File Offset: 0x006EB8E4
		private void LoadRotationSpellsToFields()
		{
			this.selectPetCallSpell.Items.Clear();
			this.selectPetCallSpell.Items.Add("Select Spell...");
			this.selectPetReviveSpell.Items.Clear();
			this.selectPetReviveSpell.Items.Add("Select Spell...");
			this.selectPetCombatReactSpell.Items.Clear();
			this.selectPetCombatReactSpell.Items.Add("Select Spell...");
			if (frmRotation.RecordedRotation.Count > 0)
			{
				using (List<Rotation>.Enumerator enumerator = frmRotation.RecordedRotation.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Rotation rotation = enumerator.Current;
						this.selectPetCallSpell.Items.Add(rotation.Name + " [" + rotation.ID.ToString() + "]");
						this.selectPetReviveSpell.Items.Add(rotation.Name + " [" + rotation.ID.ToString() + "]");
						this.selectPetCombatReactSpell.Items.Add(rotation.Name + " [" + rotation.ID.ToString() + "]");
					}
					goto IL_195;
				}
			}
			this.selectPetCallSpell.Items.Add("No Spell(s) in Rotation found.");
			this.selectPetReviveSpell.Items.Add("No Spell(s) in Rotation found.");
			this.selectPetCombatReactSpell.Items.Add("No Spell(s) in Rotation found.");
			IL_195:
			this.selectPetCallSpell.SelectedIndex = 0;
			this.selectPetReviveSpell.SelectedIndex = 0;
			this.selectPetCombatReactSpell.SelectedIndex = 0;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x006ED8BC File Offset: 0x006EBABC
		private void LoadProfileSettings()
		{
			if (frmRotation.Mode == "Edit")
			{
				this.txtPullDistance.Text = frmRotation.Settings.PullDistance.ToString();
				this.selectFindSpells.SelectedIndex = this.selectFindSpells.FindStringExact(frmRotation.Settings.FindSpells);
				if (frmRotation.Settings.UseGSE)
				{
					this.checkGSE.Checked = true;
					this.txtGSESettingsClickDelay.Text = frmRotation.Settings.GSEClickDelayInMS.ToString();
				}
				if (frmRotation.Settings.PetCall)
				{
					this.checkPetCall.Checked = true;
					int num = this.selectPetCallSpell.FindString(frmRotation.Settings.PetCallSpellName);
					if (num == -1)
					{
						this.selectPetCallSpell.Items.Add(frmRotation.Settings.PetCallSpellName + " [" + frmRotation.Settings.PetCallSpellID.ToString() + "]");
						this.selectPetCallSpell.SelectedIndex = this.selectPetCallSpell.Items.Count - 1;
					}
					else
					{
						this.selectPetCallSpell.SelectedIndex = num;
					}
				}
				if (frmRotation.Settings.PetRevive)
				{
					this.checkPetRevive.Checked = true;
					int num2 = this.selectPetReviveSpell.FindString(frmRotation.Settings.PetReviveSpellName);
					if (num2 != -1)
					{
						this.selectPetReviveSpell.SelectedIndex = num2;
					}
					else
					{
						this.selectPetReviveSpell.Items.Add(frmRotation.Settings.PetReviveSpellName + " [" + frmRotation.Settings.PetReviveSpellID.ToString() + "]");
						this.selectPetReviveSpell.SelectedIndex = this.selectPetReviveSpell.Items.Count - 1;
					}
				}
				if (frmRotation.Settings.PetFeed)
				{
					this.checkPetFeed.Checked = true;
					this.txtPetFeedMinutes.Text = frmRotation.Settings.PetFeedMinutes.ToString();
				}
				if (frmRotation.Settings.PetCombatStart)
				{
					this.checkPetCombat.Checked = true;
					this.txtPetCombatWait.Text = frmRotation.Settings.PetCombatWait.ToString();
					this.checkPetCombatParallel.Checked = frmRotation.Settings.PetCombatParallel;
				}
				if (frmRotation.Settings.PetCombatReact)
				{
					this.checkPetCombatReact.Checked = true;
					int num3 = this.selectPetCombatReactSpell.FindString(frmRotation.Settings.PetCombatReactSpellName);
					if (num3 != -1)
					{
						this.selectPetCombatReactSpell.SelectedIndex = num3;
					}
					else
					{
						this.selectPetCombatReactSpell.Items.Add(frmRotation.Settings.PetCombatReactSpellName + " [" + frmRotation.Settings.PetCombatReactSpellID.ToString() + "]");
						this.selectPetCombatReactSpell.SelectedIndex = this.selectPetCombatReactSpell.Items.Count - 1;
					}
					this.checkPetCombatReactStepBack.Checked = frmRotation.Settings.PetCombatReactStepBack;
				}
				if (frmRotation.Settings.EnchantMainHand)
				{
					this.checkEnchantmentMainHand.Checked = true;
				}
				if (frmRotation.Settings.EnchantOffHand)
				{
					this.checkEnchantmentOffHand.Checked = true;
				}
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x006EDBE8 File Offset: 0x006EBDE8
		public static void CheckKeybinds()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["PetAttack"] = "lblPetCombatKeybind";
			dictionary["FeedPet"] = "lblPetFeedKeybind";
			dictionary["MainHandEnchantment"] = "lblEnchantmentMainHandKeybind";
			dictionary["OffHandEnchantment"] = "lblEnchantmentOffHandKeybind";
			dictionary["GSE"] = "lblGSESettingsKeybindData";
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
					}), keyValuePair.Value, "frmRotation", Color.LimeGreen, null, false);
				}
				else
				{
					Tools.ControlColor("Please set a Keybind for \"" + keyValuePair.Key + "\" in your Keybinds.", keyValuePair.Value, "frmRotation", Color.Red, null, false);
				}
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x006EDD44 File Offset: 0x006EBF44
		private void LoadClasses()
		{
			this.selectClass.Items.Clear();
			foreach (Constants.UnitClass unitClass in (Constants.UnitClass[])Enum.GetValues(typeof(Constants.UnitClass)))
			{
				string text = unitClass.ToString();
				if (text != "NA")
				{
					this.selectClass.Items.Add(text);
				}
			}
			if (frmRotation.Mode == "Edit" && frmRotation.Settings.Class != "")
			{
				this.selectClass.SelectedIndex = this.selectClass.FindStringExact(frmRotation.Settings.Class);
			}
			else if (_globals.Ready && ObjectManager.Me.Class.ToString().Length > 0)
			{
				this.selectClass.SelectedIndex = this.selectClass.FindStringExact(ObjectManager.Me.Class.ToString());
			}
			else
			{
				this.selectClass.SelectedIndex = 0;
			}
			if (frmRotation.Mode == "Edit" && frmRotation.Settings.ClassType != "")
			{
				this.selectClassType.SelectedIndex = this.selectClassType.FindStringExact(frmRotation.Settings.ClassType);
				return;
			}
			if (_globals.Ready && ObjectManager.Me.IsMelee)
			{
				this.selectClassType.SelectedIndex = this.selectClassType.FindStringExact("Melee");
				return;
			}
			this.selectClassType.SelectedIndex = 0;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x006EDEE8 File Offset: 0x006EC0E8
		private void btnReload_Click(object sender, EventArgs e)
		{
			this.Reload();
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x006EDEFC File Offset: 0x006EC0FC
		private void Reload()
		{
			this.LoadSpells();
			this.LoadRotationSpellsToFields();
			frmRotation.UpdateList();
			this.LoadClasses();
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x006EDF20 File Offset: 0x006EC120
		public static void UpdateList()
		{
			if (frmRotation.RecordedRotation.Count >= 0)
			{
				Dictionary<string[], string[]> dictionary = new Dictionary<string[], string[]>();
				foreach (Rotation rotation in frmRotation.RecordedRotation)
				{
					string text = "";
					string text2 = "";
					if (_globals.Ready && !rotation.IsMacro && !ActionBar.HasSpellInActionBar(rotation.ID))
					{
						text = "Red";
						text2 = "Not available in ActionBar.";
					}
					else
					{
						if (SpellRotation.HasCondition(rotation))
						{
							text = "Green";
							if (rotation.HasPowerType1 || rotation.HasPowerType2)
							{
								text2 += "Power-Type ";
							}
							if (rotation.HasItem)
							{
								text2 += "Item ";
							}
							if (rotation.HasAddition1)
							{
								text2 += "Addition1 ";
							}
							if (rotation.HasAddition2)
							{
								text2 += "Addition2 ";
							}
							if (rotation.HasAddition3)
							{
								text2 += "Addition3 ";
							}
							if (rotation.HasMultipleAttackers)
							{
								text2 += "Multiple-Attackers ";
							}
						}
						if (rotation.AlwaysActiveCombat)
						{
							text2 += "Always Active ";
						}
						if (rotation.DifferentUsage.Length > 0)
						{
							text = "Orange";
							text2 = text2 + rotation.DifferentUsage + " ";
						}
						text2 = text2.TrimEnd(Array.Empty<char>());
						text2 = text2.Replace(" ", " + ");
					}
					string str = "";
					if (rotation.Rank > 0)
					{
						str = " (Rank " + rotation.Rank.ToString() + ")";
					}
					string text3 = rotation.Name + str;
					if (rotation.IsMacro)
					{
						text3 = "[MACRO] " + text3;
					}
					string[] key = new string[]
					{
						rotation.ID.ToString(),
						rotation.RequiredLevel.ToString(),
						rotation.Prio.ToString(),
						text3,
						rotation.Type,
						text2
					};
					dictionary.Add(key, new string[]
					{
						text,
						""
					});
				}
				Tools.ControlListViewCreate(dictionary, "listSpells", "frmRotation", true, -1, null);
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x006EE1A0 File Offset: 0x006EC3A0
		private void btnAdd_Click(object sender, EventArgs e)
		{
			this.AddSpell();
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x006EE1B4 File Offset: 0x006EC3B4
		private void selectSpells_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.AddSpell();
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x006EE1D4 File Offset: 0x006EC3D4
		private void AddSpell()
		{
			string text = this.selectSpells.Text;
			if (text.Contains("["))
			{
				int num = 0;
				if (!int.TryParse(text.Split(new char[]
				{
					'[',
					']'
				})[1], out num))
				{
					MessageBox.Show("The Spell or Item ID could not be recognized.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
				if (num > 0)
				{
					object[] args = new object[]
					{
						num
					};
					Tools.OpenForm("frmRotationAddSpell", true, "frmRotation", args);
					return;
				}
			}
			else
			{
				MessageBox.Show("Please select a Spell or Item first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x006EE270 File Offset: 0x006EC470
		private void listSpells_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.DeleteSpell();
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x006EE290 File Offset: 0x006EC490
		private void DeleteSpell()
		{
			if (this.listSpells.SelectedItems.Count > 0 && this.listSpells.SelectedIndices.Count > 0)
			{
				string text = this.listSpells.SelectedItems[0].SubItems[0].Text;
				int SpellID = Convert.ToInt32(text);
				frmRotation.RecordedRotation.RemoveAll((Rotation x) => x.ID == SpellID);
				frmRotation.UpdateList();
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x006EE314 File Offset: 0x006EC514
		private void listSpells_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.OpenConditions();
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x006EE328 File Offset: 0x006EC528
		private void OpenConditions()
		{
			if (this.listSpells.SelectedItems.Count > 0 && this.listSpells.SelectedIndices.Count > 0)
			{
				string text = this.listSpells.SelectedItems[0].SubItems[0].Text;
				if (text.Length > 0 && Tools.IsNumber(text, 1, 0, 1, 0))
				{
					frmRotationConditions.SpellID = 0;
					frmRotationConditions.RotationSpell = null;
					int num = Convert.ToInt32(text);
					foreach (Rotation rotation in frmRotation.RecordedRotation)
					{
						if (rotation.ID == num)
						{
							frmRotationConditions.SpellID = num;
							frmRotationConditions.RotationSpell = rotation;
							break;
						}
					}
					if (frmRotationConditions.RotationSpell != null)
					{
						Tools.ShowForm("frmRotationConditions");
					}
				}
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x006EE414 File Offset: 0x006EC614
		private void selectOptions_SelectedIndexChanged(object sender, EventArgs e)
		{
			int selectedIndex = this.selectOptions.SelectedIndex;
			if (selectedIndex == 0)
			{
				return;
			}
			if (_globals.Ready)
			{
				this.selectOptions.Enabled = false;
				if (selectedIndex == 1)
				{
					int x = this.lblRotationLoading.Location.X;
					int y = this.listSpells.Location.X + this.listSpells.ClientSize.Height / 2;
					this.lblRotationLoading.Location = new Point(x, y);
					this.ImportRotation();
				}
				else
				{
					if (selectedIndex == 2)
					{
						frmRotation.PlaceSpellsOnActionbars(frmRotation.RecordedRotation);
					}
					else if (selectedIndex == 3)
					{
						this.ClearActionBars();
					}
					this.Reload();
				}
				this.selectOptions.SelectedIndex = 0;
				this.selectOptions.Enabled = true;
				return;
			}
			MessageBox.Show("Please enter the world first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			this.selectOptions.SelectedIndex = 0;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x006EE500 File Offset: 0x006EC700
		private void ImportRotation()
		{
			if (this.ImportRotationRuns)
			{
				return;
			}
			new Thread(new ThreadStart(this.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x006EE534 File Offset: 0x006EC734
		public static bool PlaceSpellsOnActionbars(List<Rotation> Rotation)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (Rotation rotation in Rotation)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Append("/");
				}
				if (!rotation.IsMacro)
				{
					string str = "0";
					if (rotation.IsItem)
					{
						str = "1";
					}
					string str2 = rotation.ID.ToString();
					stringBuilder.Append(str + ";" + str2);
				}
			}
			if (stringBuilder.Length == 0)
			{
				return false;
			}
			string str3 = stringBuilder.ToString();
			Addon.LUA("_importRotation(\"" + str3 + "\")", "0", false, false);
			return true;
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x006EE60C File Offset: 0x006EC80C
		private void ClearActionBars()
		{
			Addon.LUA("_clearActionBars(1)", "0", false, false);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x006EE62C File Offset: 0x006EC82C
		private void checkGSE_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked;
			CustomUI.EnableGroupBox(@checked = this.checkGSE.Checked, this.grpGSESettings, new string[]
			{
				"checkGSE"
			});
			CustomUI.EnableGroupBox(@checked, this.grpGSEImportMacro, new string[]
			{
				"panelGSEImportMacro",
				"richGSEImportMacro"
			});
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x006EE684 File Offset: 0x006EC884
		private void btnGSEImportMacro_Click(object sender, EventArgs e)
		{
			frmRotation.<>c__DisplayClass39_0 CS$<>8__locals1 = new frmRotation.<>c__DisplayClass39_0();
			if (!_globals.Ready)
			{
				MessageBox.Show("Please login and enter the world first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			if (!Addon.IsReady(true, true, false, false))
			{
				return;
			}
			CS$<>8__locals1.ImportPath = _globals.ProcessFolder + "\\Interface\\AddOns\\" + Jack.Core.Settings.AddonName + "\\Import.lua";
			if (!File.Exists(CS$<>8__locals1.ImportPath))
			{
				MessageBox.Show("Couldn't find the Addon Import file.\r\nThis can be related to a faulty addon installation.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			CS$<>8__locals1.Macro = this.richGSEImportMacro.Text.Trim();
			if (CS$<>8__locals1.Macro.Length < 10)
			{
				MessageBox.Show("Please enter a valid GSE macro.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (CS$<>8__locals1.Macro.StartsWith("`"))
			{
				CS$<>8__locals1.Macro = Tools.GetBetween(CS$<>8__locals1.Macro, "```", "```").Trim();
			}
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x006EE794 File Offset: 0x006EC994
		private void btnGSEImportClearMacro_Click(object sender, EventArgs e)
		{
			this.richGSEImportMacro.Text = "";
			this.lblGSEImportStatus.Text = "";
			this.lblGSEImportStatus.ForeColor = Color.White;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x006EE7D4 File Offset: 0x006EC9D4
		private void checkPetCall_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked;
			CustomUI.EnableGroupBox(@checked = this.checkPetCall.Checked, this.grpPetCall, new string[]
			{
				"checkPetCall"
			});
			if (!@checked)
			{
				this.selectPetCallSpell.SelectedIndex = 0;
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x006EE818 File Offset: 0x006ECA18
		private void checkPetRevive_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked;
			CustomUI.EnableGroupBox(@checked = this.checkPetRevive.Checked, this.grpPetRevive, new string[]
			{
				"checkPetRevive"
			});
			if (!@checked)
			{
				this.selectPetReviveSpell.SelectedIndex = 0;
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x006EE85C File Offset: 0x006ECA5C
		private void checkPetFeed_CheckedChanged(object sender, EventArgs e)
		{
			CustomUI.EnableGroupBox(this.checkPetFeed.Checked, this.grpPetFeed, new string[]
			{
				"checkPetFeed"
			});
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x006EE890 File Offset: 0x006ECA90
		private void checkPetCombat_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkPetCombat.Checked;
			this.checkPetCombatReact.Enabled = @checked;
			if (!@checked)
			{
				this.checkPetCombatReact.Checked = @checked;
				this.checkPetCombatParallel.Checked = @checked;
			}
			CustomUI.EnableGroupBox(@checked, this.grpPetCombat, new string[]
			{
				"checkPetCombat"
			});
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x006EE8EC File Offset: 0x006ECAEC
		private void checkPetCombatParallel_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.checkPetCombatParallel.Checked;
			this.lblPetCombatWait1.Enabled = !@checked;
			this.txtPetCombatWait.Enabled = !@checked;
			this.lblPetCombatWait2.Enabled = !@checked;
			if (@checked)
			{
				this.txtPetCombatWait.Text = "0";
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x006EE948 File Offset: 0x006ECB48
		private void checkPetCombatReact_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked;
			CustomUI.EnableGroupBox(@checked = this.checkPetCombatReact.Checked, this.grpPetCombatReact, new string[]
			{
				"checkPetCombatReact"
			});
			if (!@checked)
			{
				this.selectPetCombatReactSpell.SelectedIndex = 0;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x006EE98C File Offset: 0x006ECB8C
		private void selectPetCallSpell_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ChangeDifferentUsage(this.selectPetCallSpell, "Call-Pet");
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x006EE9AC File Offset: 0x006ECBAC
		private void selectPetReviveSpell_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ChangeDifferentUsage(this.selectPetReviveSpell, "Revive-Pet");
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x006EE9CC File Offset: 0x006ECBCC
		private void selectPetCombatReactSpell_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.ChangeDifferentUsage(this.selectPetCombatReactSpell, "Pet-Combat-React");
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x006EE9EC File Offset: 0x006ECBEC
		private void checkEnchantmentMainHand_CheckedChanged(object sender, EventArgs e)
		{
			CustomUI.EnableGroupBox(this.checkEnchantmentMainHand.Checked, this.grpEnchantmentMainHand, new string[]
			{
				"checkEnchantmentMainHand"
			});
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x006EEA20 File Offset: 0x006ECC20
		private void checkEnchantmentOffHand_CheckedChanged(object sender, EventArgs e)
		{
			CustomUI.EnableGroupBox(this.checkEnchantmentOffHand.Checked, this.grpEnchantmentOffHand, new string[]
			{
				"checkEnchantmentOffHand"
			});
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x006EEA54 File Offset: 0x006ECC54
		private void ChangeDifferentUsage(ComboBox Control, string Usage)
		{
			foreach (Rotation rotation in frmRotation.RecordedRotation)
			{
				if (!(rotation.DifferentUsage == Usage))
				{
					if (rotation.DifferentUsage.Contains(Usage))
					{
						rotation.DifferentUsage = rotation.DifferentUsage.Replace(Usage + "/", "").Replace("/" + Usage, "");
					}
				}
				else
				{
					rotation.DifferentUsage = "";
				}
			}
			string text = Control.SelectedItem.ToString();
			if (text.Contains("["))
			{
				string text2 = text.Split(new char[]
				{
					'[',
					']'
				})[1];
				if (Tools.IsNumber(text2, 1, 0, 1, 0))
				{
					int num = Convert.ToInt32(text2);
					foreach (Rotation rotation2 in frmRotation.RecordedRotation)
					{
						if (rotation2.ID == num)
						{
							if (rotation2.DifferentUsage.Length > 0)
							{
								Rotation rotation3 = rotation2;
								rotation3.DifferentUsage = rotation3.DifferentUsage + "/" + Usage;
								break;
							}
							rotation2.DifferentUsage = Usage;
							break;
						}
					}
				}
			}
			frmRotation.UpdateList();
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x006EEBC8 File Offset: 0x006ECDC8
		private void btnSave_Click(object sender, EventArgs e)
		{
			if (frmRotation.RecordedRotation.Count > 0)
			{
				this.SaveSettings();
				object[] args = new object[]
				{
					frmRotation.ProfileFolder,
					frmRotation.ProfileName
				};
				Tools.OpenForm("frmRotationSave", true, "frmRotation", args);
				return;
			}
			MessageBox.Show("Please add at least one Spell or Item to save your Rotation.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x006EEC28 File Offset: 0x006ECE28
		private void SaveSettings()
		{
			frmRotation.RotationSettings.Clear();
			RotationSettings rotationSettings = new RotationSettings();
			rotationSettings.Class = this.selectClass.SelectedItem.ToString();
			rotationSettings.ClassType = this.selectClassType.SelectedItem.ToString();
			int pullDistance = 25;
			string text = this.txtPullDistance.Text;
			if (Tools.IsNumber(text, 1, 0, 0, 0))
			{
				pullDistance = Convert.ToInt32(text);
			}
			else if (_globals.Ready && ObjectManager.Me != null && ObjectManager.Me.IsMelee)
			{
				pullDistance = 5;
			}
			string text2 = this.selectFindSpells.Text;
			rotationSettings.PullDistance = pullDistance;
			rotationSettings.FindSpells = text2;
			if (this.checkGSE.Checked)
			{
				string text3 = this.txtGSESettingsClickDelay.Text;
				if (Tools.IsNumber(text3, 3, 0, 500, 0) && _globals.Keys.ContainsKey("GSE") && _globals.Keys["GSE"] != "NotSet")
				{
					rotationSettings.UseGSE = true;
					rotationSettings.GSEClickDelayInMS = Convert.ToInt32(text3);
				}
				else
				{
					rotationSettings.UseGSE = false;
				}
			}
			else
			{
				rotationSettings.UseGSE = false;
			}
			if (this.checkPetCall.Checked)
			{
				string text4 = this.selectPetCallSpell.SelectedItem.ToString();
				if (text4 != "No Spell(s) in Rotation found." && text4.Contains("["))
				{
					rotationSettings.PetCallSpellName = this.selectPetCallSpell.Text.Split(new char[]
					{
						'['
					})[0].TrimEnd(Array.Empty<char>());
					rotationSettings.PetCallSpellID = Convert.ToInt32(this.selectPetCallSpell.Text.Split(new char[]
					{
						'[',
						']'
					})[1]);
					rotationSettings.PetCall = true;
				}
				else
				{
					rotationSettings.PetCall = false;
				}
			}
			else
			{
				rotationSettings.PetCall = false;
			}
			if (this.checkPetRevive.Checked)
			{
				string text5 = this.selectPetReviveSpell.SelectedItem.ToString();
				if (text5 != "No Spell(s) in Rotation found." && text5.Contains("["))
				{
					rotationSettings.PetReviveSpellName = this.selectPetReviveSpell.Text.Split(new char[]
					{
						'['
					})[0].TrimEnd(Array.Empty<char>());
					rotationSettings.PetReviveSpellID = Convert.ToInt32(this.selectPetReviveSpell.Text.Split(new char[]
					{
						'[',
						']'
					})[1]);
					rotationSettings.PetRevive = true;
				}
				else
				{
					rotationSettings.PetRevive = false;
				}
			}
			else
			{
				rotationSettings.PetRevive = false;
			}
			if (this.checkPetFeed.Checked)
			{
				if (Tools.IsNumber(this.txtPetFeedMinutes.Text, 1, 0, 1, 0) && _globals.Keys.ContainsKey("FeedPet") && _globals.Keys["FeedPet"] != "NotSet")
				{
					rotationSettings.PetFeedMinutes = Convert.ToInt32(this.txtPetFeedMinutes.Text);
					rotationSettings.PetFeedMinutesInMS = rotationSettings.PetFeedMinutes * 60000;
					rotationSettings.PetFeed = true;
				}
				else
				{
					rotationSettings.PetFeed = false;
				}
			}
			else
			{
				rotationSettings.PetFeed = false;
			}
			if (this.checkPetCombat.Checked)
			{
				if (Tools.IsNumber(this.txtPetCombatWait.Text, 1, 0, 0, 0) && _globals.Keys.ContainsKey("PetAttack") && _globals.Keys["PetAttack"] != "NotSet")
				{
					rotationSettings.PetCombatWait = Convert.ToInt32(this.txtPetCombatWait.Text);
					rotationSettings.PetCombatWaitInMS = rotationSettings.PetCombatWait * 1000;
					rotationSettings.PetCombatParallel = this.checkPetCombatParallel.Checked;
					rotationSettings.PetCombatStart = true;
				}
				else
				{
					rotationSettings.PetCombatStart = false;
				}
			}
			else
			{
				rotationSettings.PetCombatStart = false;
			}
			if (this.checkPetCombatReact.Checked)
			{
				string text6 = this.selectPetCombatReactSpell.SelectedItem.ToString();
				if (text6 != "No Spell(s) in Rotation found." && text6.Contains("["))
				{
					rotationSettings.PetCombatReactSpellName = this.selectPetCombatReactSpell.Text.Split(new char[]
					{
						'['
					})[0].TrimEnd(Array.Empty<char>());
					rotationSettings.PetCombatReactSpellID = Convert.ToInt32(this.selectPetCombatReactSpell.Text.Split(new char[]
					{
						'[',
						']'
					})[1]);
					rotationSettings.PetCombatReactStepBack = this.checkPetCombatReactStepBack.Checked;
					rotationSettings.PetCombatReact = true;
				}
				else
				{
					rotationSettings.PetCombatReact = false;
				}
			}
			else
			{
				rotationSettings.PetCombatReact = false;
			}
			if (!this.checkEnchantmentMainHand.Checked)
			{
				rotationSettings.EnchantMainHand = false;
			}
			else if (_globals.Keys.ContainsKey("MainHandEnchantment") && _globals.Keys["MainHandEnchantment"] != "NotSet")
			{
				rotationSettings.EnchantMainHand = true;
			}
			else
			{
				rotationSettings.EnchantMainHand = false;
			}
			if (!this.checkEnchantmentOffHand.Checked)
			{
				rotationSettings.EnchantOffHand = false;
			}
			else if (_globals.Keys.ContainsKey("OffHandEnchantment") && _globals.Keys["OffHandEnchantment"] != "NotSet")
			{
				rotationSettings.EnchantOffHand = true;
			}
			else
			{
				rotationSettings.EnchantOffHand = false;
			}
			frmRotation.RotationSettings.Add(rotationSettings);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x006EF154 File Offset: 0x006ED354
		private void listSpells_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ListView listView = (ListView)sender;
			int index = Convert.ToInt32(e.Column.ToString());
			string text = listView.Columns[index].Text;
			this.OrderBy(text);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x006EF194 File Offset: 0x006ED394
		private void OrderBy(string ColumnName)
		{
			if (ColumnName == "ID")
			{
				frmRotation.RecordedRotation = (from Rotation in frmRotation.RecordedRotation
				orderby Rotation.ID
				select Rotation).ToList<Rotation>();
			}
			else if (ColumnName == "Req. LvL")
			{
				frmRotation.RecordedRotation = (from Rotation in frmRotation.RecordedRotation
				orderby Rotation.RequiredLevel
				select Rotation).ToList<Rotation>();
			}
			else if (ColumnName == "Prio")
			{
				frmRotation.RecordedRotation = (from Rotation in frmRotation.RecordedRotation
				orderby Rotation.Prio
				select Rotation).ToList<Rotation>();
			}
			else if (ColumnName == "Name")
			{
				frmRotation.RecordedRotation = (from Rotation in frmRotation.RecordedRotation
				orderby Rotation.Name
				select Rotation).ToList<Rotation>();
			}
			else if (ColumnName == "Type")
			{
				frmRotation.RecordedRotation = (from Rotation in frmRotation.RecordedRotation
				orderby Rotation.Type
				select Rotation).ToList<Rotation>();
			}
			frmRotation.UpdateList();
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x006EF2F8 File Offset: 0x006ED4F8
		private void listSpells_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				string[] items = new string[]
				{
					"Conditions...",
					"-",
					"Delete"
				};
				Tools.CreateContextMenu(sender, e, "frmRotation", "listSpells", "ItemAction", items, null);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x006EF34C File Offset: 0x006ED54C
		public void ItemAction(object sender, MouseEventArgs e, string Action = "")
		{
			foreach (object obj in (sender as ListView).SelectedItems)
			{
				ListViewItem listViewItem = (ListViewItem)obj;
				string text = listViewItem.SubItems[0].Text;
				string text2 = listViewItem.SubItems[1].Text;
				string text3 = listViewItem.SubItems[2].Text;
				string text4 = listViewItem.SubItems[3].Text;
				string text5 = listViewItem.SubItems[4].Text;
				if (!(Action == "Conditions..."))
				{
					if (Action == "Delete")
					{
						this.DeleteSpell();
					}
				}
				else
				{
					this.OpenConditions();
				}
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x006EF42C File Offset: 0x006ED62C
		public void HideForm()
		{
			Jack.Core.Settings.WindowRotationLocation = base.Location;
			Jack.Core.Settings.WindowRotationSize = new Size(base.Width, base.Height);
			Tools.HideForm("frmRotationConditions");
			base.Visible = false;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x006EF46C File Offset: 0x006ED66C
		private void btnRotationTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string text = "";
			string tabControl = "tabs";
			string selectTabPage = "tabRotation";
			Tooltip tooltip = new Tooltip();
			string title = "Import your Rotation";
			if (Jack.Core.Settings.GameFolder.Length == 0)
			{
				text = Tools.HTMLColor("Please install the Jack Addon first.", "Red") + "\r\n\r\n";
			}
			text += "Click here to import your current Spells, Items and Macros located in your upper and lower actionbars. ";
			text += "Jack will craft a foundation for your rotation. Also further options can be found here to handle";
			text += "your actionbars in a comfortable way.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectOptions";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Rotation";
			text = "Here you can find every added spell as well as brief information about your conditions and settings.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = "tabRotation";
			tooltip2.MarkControlName = "listSpells";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Add Spells";
			text = "You can also add spells manually. This list shows you all the spells your character has. ";
			text += "Search or select a spell and press Enter or ...";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = "tabRotation";
			tooltip3.MarkControlName = "selectSpells";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Add Spells";
			text = "... click here to add the Spell to your Rotation.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = "tabRotation";
			tooltip4.MarkControlName = "btnAdd";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Settings";
			text = "Here you can set general settings for your rotation.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = "tabSettings";
			tooltip5.MarkControlName = "tabs";
			tooltip5.PinTooltipToControl = true;
			Tooltip tooltip6 = new Tooltip();
			title = "Pet";
			text = "All settings for handling pets can be set here.";
			tooltip6.Title = title;
			tooltip6.Text = text;
			tooltip6.FormName = base.Name;
			tooltip6.TabControl = tabControl;
			tooltip6.SelectTabPage = "tabPet";
			tooltip6.MarkControlName = "tabs";
			tooltip6.PinTooltipToControl = true;
			Tooltip tooltip7 = new Tooltip();
			title = "Enchantments";
			text = "All about weapon enchantments can be found here.";
			tooltip7.Title = title;
			tooltip7.Text = text;
			tooltip7.FormName = base.Name;
			tooltip7.TabControl = tabControl;
			tooltip7.SelectTabPage = "tabEnchantment";
			tooltip7.MarkControlName = "tabs";
			tooltip7.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			list.Add(tooltip6);
			list.Add(tooltip7);
			Tools.OpenTooltips(list);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x006EF788 File Offset: 0x006ED988
		private void btnSettingsDistancesTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabSettings";
			Tooltip tooltip = new Tooltip();
			string title = "Combat Distance";
			string text = "Specify the range in yards within which your character should start a combat.\r\n\r\n";
			text += "Jack will be careful to maintain this distance for Melee characters.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "txtPullDistance";
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x006EF820 File Offset: 0x006EDA20
		private void btnSettingsSpellsTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabSettings";
			Tooltip tooltip = new Tooltip();
			string title = "Find Spells";
			string text = "Jack automatically captures spells and items in your action bars. ";
			text += "Leave this option unchanged if you are not sure.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectFindSpells";
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x006EF8B8 File Offset: 0x006EDAB8
		private void btnEnchantmentTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabEnchantment";
			Tooltip tooltip = new Tooltip();
			string title = "Enchantment";
			string text = "Create a macro to apply the poison or enchantment to your Main-Hand weapon.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpEnchantmentMainHand";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Enchantment";
			text = "Create a macro for this as well to apply the poison or enchantment to your Off-Hand weapon.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "grpEnchantmentOffHand";
			tooltip2.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x006EF9A0 File Offset: 0x006EDBA0
		private void btnPetCallTooltip_Click(object sender, EventArgs e)
		{
			this.PetTooltip("selectPetCallSpell");
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x006EF9B8 File Offset: 0x006EDBB8
		private void btnPetReviveTooltip_Click(object sender, EventArgs e)
		{
			this.PetTooltip("selectPetReviveSpell");
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x006EF9D0 File Offset: 0x006EDBD0
		private void btnPetCombatReactTooltip_Click(object sender, EventArgs e)
		{
			this.PetTooltip("selectPetCombatReactSpell");
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x006EF9E8 File Offset: 0x006EDBE8
		private void PetTooltip(string Control)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabPet";
			Tooltip tooltip = new Tooltip();
			string title = "Pet";
			string text = "This spell list shows you all the spells that are already in your rotation. ";
			text += "Please add the spell to your rotation first.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = Control;
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x006F63A4 File Offset: 0x006F45A4
		[CompilerGenerated]
		private void method_0()
		{
			Tools.ControlVisible("lblRotationLoading", "frmRotation", true);
			List<string> list = Addon.LUASync("jkRotation", "Rotation", "", null);
			if (list.Count != 0)
			{
				this.ImportRotationRuns = true;
				int count = frmRotation.RecordedRotation.Count;
				ICollection<Spellbook.SpellList> getSpells = Spellbook.GetSpells;
				using (List<string>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current.Trim();
						if (text.Length != 0 && text.Contains(";"))
						{
							string[] array = text.Split(new char[]
							{
								';'
							});
							if (array.Count<string>() >= 6)
							{
								string text2 = array[0].ToString();
								string text3 = array[1].ToString();
								if (Tools.IsNumber(text2, 1, 0, 1, 0))
								{
									int num = Convert.ToInt32(text2);
									bool flag = false;
									if (text3 == "MACRO")
									{
										string text4 = array[2].ToString();
										string text5 = array[3].ToString();
										string text6 = array[4].ToString();
										if (Tools.IsNumber(text4, 1, 0, 1, 0) && Tools.IsNumber(text5, 1, 0, 1, 0) && text6.Length != 0)
										{
											int bar = Convert.ToInt32(text4);
											int slot = Convert.ToInt32(text5);
											string name = text6;
											string key = "ActionBar" + bar.ToString() + "_" + slot.ToString();
											if (count <= 0)
											{
												goto IL_69D;
											}
											using (List<Rotation>.Enumerator enumerator2 = frmRotation.RecordedRotation.GetEnumerator())
											{
												while (enumerator2.MoveNext())
												{
													Rotation rotation = enumerator2.Current;
													if (rotation.IsMacro && rotation.Name == text6)
													{
														rotation.Bar = bar;
														rotation.Slot = slot;
														rotation.Key = key;
														flag = true;
														break;
													}
												}
												goto IL_69D;
											}
											IL_1D9:
											Rotation rotation2 = new Rotation();
											rotation2.Bar = bar;
											rotation2.Slot = slot;
											rotation2.Key = key;
											rotation2.ID = num;
											rotation2.RequiredLevel = 0;
											rotation2.Name = name;
											rotation2.Rank = 0;
											rotation2.Cooldown = 0;
											rotation2.GlobalCooldown = _globals.GlobalCooldown;
											rotation2.Type = "Combat";
											rotation2.IsItem = false;
											rotation2.IsMacro = true;
											frmRotation.RecordedRotation.Add(rotation2);
											continue;
											IL_69D:
											if (!flag)
											{
												goto IL_1D9;
											}
										}
									}
									else
									{
										string text7 = array[2].ToString();
										string text8 = array[3].ToString();
										string text9 = array[4].ToString();
										string text10 = array[5].ToString();
										if (count > 0)
										{
											using (List<Rotation>.Enumerator enumerator2 = frmRotation.RecordedRotation.GetEnumerator())
											{
												while (enumerator2.MoveNext())
												{
													if (enumerator2.Current.ID == num)
													{
														flag = true;
														break;
													}
												}
											}
										}
										if (!flag)
										{
											string text11 = text3;
											int val = 0;
											int val2 = 0;
											int cooldown = 0;
											int globalCooldown = _globals.GlobalCooldown;
											if (text3.Length > 0 && Tools.IsNumber(text7, 1, 0, 1, 0) && Tools.IsNumber(text8, 1, 0, 1, 0))
											{
												text11 = text3;
												val = Convert.ToInt32(text7);
												val2 = Convert.ToInt32(text8);
											}
											if (Tools.IsNumber(text9, 1, 0, 0, 0) && Tools.IsNumber(text10, 1, 0, 0, 0))
											{
												cooldown = Convert.ToInt32(text9);
												globalCooldown = Convert.ToInt32(text10);
											}
											Items items = ObjectManager.GetItemByID(num);
											bool flag2 = false;
											Spellbook.SpellList spellList = default(Spellbook.SpellList);
											foreach (Spellbook.SpellList spellList2 in getSpells)
											{
												if (spellList2.ID == num)
												{
													spellList = spellList2;
													flag2 = true;
													break;
												}
											}
											if (items == null && !flag2)
											{
												if (!_globals.List_Spells.ContainsKey(num))
												{
													continue;
												}
												string text12 = _globals.List_Spells[num];
												foreach (ActionBar.SpellList spellList3 in ActionBar.GetSpells)
												{
													if (spellList3.Name == text12)
													{
														spellList = default(Spellbook.SpellList);
														spellList.ID = spellList3.ID;
														spellList.Name = text12;
														spellList.RequiredLevel = 0;
														spellList.Rank = 0;
														flag2 = true;
														break;
													}
												}
												if (!flag2)
												{
													continue;
												}
											}
											if (items != null && flag2)
											{
												StringBuilder stringBuilder = new StringBuilder();
												stringBuilder.Append("ID \"" + spellList.ID.ToString() + "\" were found as Spell AND Item.");
												stringBuilder.Append("\r\n\r\n");
												stringBuilder.Append("Spell: \"" + spellList.Name + "\"");
												stringBuilder.Append("\r\n");
												stringBuilder.Append("Item: \"" + items.ItemName + "\"");
												stringBuilder.Append("\r\n\r\n");
												stringBuilder.Append("How would you like to proceed?");
												Tools.CustomMessageBox("Spell or Item", stringBuilder.ToString(), "Add as Item (" + items.ItemName + ")", "Add as Spell (" + spellList.Name + ")", "frmRotation", true);
												if (!frmMessageBox.Button1Pressed)
												{
													items = null;
												}
												else
												{
													flag2 = false;
												}
											}
											if (items != null)
											{
												Rotation rotation3 = new Rotation();
												rotation3.ID = items.ItemID;
												rotation3.RequiredLevel = 0;
												rotation3.Name = items.ItemName;
												rotation3.Rank = 0;
												rotation3.Cooldown = cooldown;
												rotation3.GlobalCooldown = globalCooldown;
												rotation3.Type = "Food/Drink";
												rotation3.IsItem = true;
												rotation3.IsMacro = false;
												frmRotation.RecordedRotation.Add(rotation3);
											}
											else if (flag2)
											{
												string type = "Combat";
												if (spellList.Name.Contains("Conjur"))
												{
													type = "Conjuring";
												}
												Rotation rotation4 = new Rotation();
												if (text11.Length > 0)
												{
													rotation4.PowerType1 = text11;
													rotation4.PowerType1Compare = "Greater or Equal";
													rotation4.PowerType1Value = Math.Max(val, val2);
													rotation4.PowerType1Target = "Player (Me)";
													rotation4.HasPowerType1 = true;
												}
												rotation4.ID = spellList.ID;
												rotation4.RequiredLevel = spellList.RequiredLevel;
												rotation4.Name = spellList.Name;
												rotation4.Rank = spellList.Rank;
												rotation4.Cooldown = cooldown;
												rotation4.GlobalCooldown = globalCooldown;
												rotation4.Type = type;
												rotation4.IsItem = false;
												rotation4.IsMacro = false;
												frmRotation.RecordedRotation.Add(rotation4);
											}
										}
									}
								}
							}
						}
					}
				}
				base.BeginInvoke(new MethodInvoker(delegate()
				{
					this.Reload();
				}));
				Tools.ControlVisible("lblRotationLoading", "frmRotation", false);
				this.ImportRotationRuns = false;
				return;
			}
			Tools.ControlVisible("lblRotationLoading", "frmRotation", false);
			MessageBox.Show("Please make sure you have placed at least one Spell or Macro in your upper or lower Actionbar.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x04000889 RID: 2185
		public static string Mode = "";

		// Token: 0x0400088A RID: 2186
		public static string ProfileFolder = "";

		// Token: 0x0400088B RID: 2187
		public static string ProfileName = "";

		// Token: 0x0400088C RID: 2188
		public static List<Rotation> RecordedRotation = new List<Rotation>();

		// Token: 0x0400088D RID: 2189
		public static List<RotationSettings> RotationSettings = new List<RotationSettings>();

		// Token: 0x0400088E RID: 2190
		public static RotationSettings Settings = null;

		// Token: 0x0400088F RID: 2191
		public static object _lock = new object();

		// Token: 0x04000890 RID: 2192
		private bool ImportRotationRuns;
	}
}
