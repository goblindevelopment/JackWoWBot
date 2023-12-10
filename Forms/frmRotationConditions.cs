using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Models;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x020000B7 RID: 183
	public partial class frmRotationConditions : Form
	{
		// Token: 0x06001336 RID: 4918 RVA: 0x006F78CC File Offset: 0x006F5ACC
		public frmRotationConditions()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x006F78EC File Offset: 0x006F5AEC
		private void frmRotationConditions_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Spell Conditions", true, true, true, true, false, false);
			this.SetWindowSizeAndPosition();
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x006F7910 File Offset: 0x006F5B10
		private void SetWindowSizeAndPosition()
		{
			if (Jack.Core.Settings.WindowRotationConditionSize.Width != 0 && Jack.Core.Settings.WindowRotationConditionSize.Height != 0)
			{
				base.Width = Jack.Core.Settings.WindowRotationConditionSize.Width;
				base.Height = Jack.Core.Settings.WindowRotationConditionSize.Height;
			}
			CustomUI.SetLocation(this, "frmRotation");
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmRotationConditions_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x006F7960 File Offset: 0x006F5B60
		private void frmRotationConditions_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.ResetControls();
				this.LoadSettings();
			}
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x006F7988 File Offset: 0x006F5B88
		private void ResetControls()
		{
			this.txtPropertiesDifferentAuraID.Text = "";
			this.txtPropertiesRepetitions.Text = "";
			this.btnAddition3CastIfActiveSpelllist.Text = "Spelllist";
			this.SetControls();
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x006F79CC File Offset: 0x006F5BCC
		private void LoadSettings()
		{
			this.lblInfoSpellNameData.Text = frmRotationConditions.RotationSpell.Name + " (" + frmRotationConditions.RotationSpell.ID.ToString() + ")";
			if (frmRotationConditions.RotationSpell.DifferentAuraID > 0)
			{
				this.txtPropertiesDifferentAuraID.Text = frmRotationConditions.RotationSpell.DifferentAuraID.ToString();
			}
			if (frmRotationConditions.RotationSpell.Repetitions > 0)
			{
				this.txtPropertiesRepetitions.Text = frmRotationConditions.RotationSpell.Repetitions.ToString();
			}
			this.txtPropertiesCooldown.Text = frmRotationConditions.RotationSpell.Cooldown.ToString();
			this.txtPropertiesPrio.Text = frmRotationConditions.RotationSpell.Prio.ToString();
			this.LoadItems();
			this.EnableType(true);
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x006F7AAC File Offset: 0x006F5CAC
		private void LoadItems()
		{
			if (_globals.Ready)
			{
				Tools.ItemsToSelectionField("selectItem", "frmRotationConditions", "", true);
				return;
			}
			this.selectItem.Items.Clear();
			this.selectItem.Items.Add("Please login first.");
			this.selectItem.SelectedIndex = 0;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x006F7B08 File Offset: 0x006F5D08
		private void selectType_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.SetControls();
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x006F7B1C File Offset: 0x006F5D1C
		private void SetControls()
		{
			this.tabs.SelectedTab = this.tabGeneral;
			this.checkCanCastWhileWalk.Checked = frmRotationConditions.RotationSpell.CanCastWhileWalk;
			if (this.selectType.SelectedIndex != -1)
			{
				string text = this.selectType.Text;
				if (text == "Combat")
				{
					this.EnablePowerType1(true);
					this.EnablePowerType2(true);
					this.EnableItem(true);
					this.EnableAddition1(true);
					this.EnableAddition2(true);
					this.EnableAddition3(true);
					this.EnableAddition4(false);
					this.EnableMultipleAttackers(true);
					this.EnableMisc(true);
					this.EnableMacro(frmRotationConditions.RotationSpell.IsMacro);
					return;
				}
				if (text == "Heal")
				{
					this.EnablePowerType1(true);
					this.EnablePowerType2(true);
					this.EnableItem(true);
					this.EnableAddition1(true);
					this.EnableAddition2(true);
					this.EnableAddition3(true);
					this.EnableAddition4(false);
					this.EnableMultipleAttackers(true);
					this.EnableMisc(false);
					this.EnableMacro(frmRotationConditions.RotationSpell.IsMacro);
					return;
				}
				if (text == "Food/Drink")
				{
					this.EnablePowerType1(true);
					this.EnablePowerType2(true);
					this.EnableItem(false);
					this.EnableAddition1(false);
					this.EnableAddition2(false);
					this.EnableAddition3(false);
					this.EnableAddition4(false);
					this.EnableMultipleAttackers(false);
					this.EnableMisc(false);
					this.EnableMacro(frmRotationConditions.RotationSpell.IsMacro);
					return;
				}
				if (text == "Buff/Aura")
				{
					this.EnablePowerType1(true);
					this.EnablePowerType2(true);
					this.EnableItem(false);
					this.EnableAddition1(false);
					this.EnableAddition2(false);
					this.EnableAddition3(true);
					this.EnableAddition4(true);
					this.EnableMultipleAttackers(false);
					this.EnableMisc(false);
					this.EnableMacro(frmRotationConditions.RotationSpell.IsMacro);
					return;
				}
				if (text == "Dispel")
				{
					this.EnablePowerType1(true);
					this.EnablePowerType2(true);
					this.EnableItem(false);
					this.EnableAddition1(false);
					this.EnableAddition2(false);
					this.EnableAddition3(true);
					this.EnableAddition4(true);
					this.EnableMultipleAttackers(false);
					this.EnableMisc(false);
					this.EnableMacro(frmRotationConditions.RotationSpell.IsMacro);
					return;
				}
				if (text == "Conjuring")
				{
					this.EnablePowerType1(true);
					this.EnablePowerType2(true);
					this.EnableItem(true);
					this.EnableAddition1(false);
					this.EnableAddition2(false);
					this.EnableAddition3(false);
					this.EnableAddition4(false);
					this.EnableMultipleAttackers(false);
					this.EnableMisc(false);
					this.EnableMacro(frmRotationConditions.RotationSpell.IsMacro);
				}
			}
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x006F7DAC File Offset: 0x006F5FAC
		private void EnableType(bool Status)
		{
			this.grpType.Enabled = Status;
			this.selectType.SelectedIndex = 0;
			if (Status)
			{
				this.selectType.SelectedIndex = this.selectType.FindStringExact(frmRotationConditions.RotationSpell.Type);
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x006F7DF4 File Offset: 0x006F5FF4
		private void EnablePowerType1(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpPowerType1, null);
			this.selectPowerType1Target.SelectedIndex = 0;
			this.selectPowerType1.SelectedIndex = 0;
			this.selectPowerType1Compare.SelectedIndex = 0;
			this.txtPowerType1Value.Text = "";
			if (Status && frmRotationConditions.RotationSpell.HasPowerType1)
			{
				this.selectPowerType1Target.SelectedIndex = this.selectPowerType1Target.FindStringExact(frmRotationConditions.RotationSpell.PowerType1Target);
				this.selectPowerType1.SelectedIndex = this.selectPowerType1.FindStringExact(frmRotationConditions.RotationSpell.PowerType1);
				if (this.selectPowerType1.SelectedIndex == -1)
				{
					int selectedIndex = 0;
					if (frmRotationConditions.RotationSpell.PowerType1.Length > 0)
					{
						this.selectPowerType1.Items.Add(frmRotationConditions.RotationSpell.PowerType1);
						selectedIndex = this.selectPowerType1.Items.Count - 1;
					}
					this.selectPowerType1.SelectedIndex = selectedIndex;
				}
				this.selectPowerType1Compare.SelectedIndex = this.selectPowerType1Compare.FindStringExact(frmRotationConditions.RotationSpell.PowerType1Compare);
				this.txtPowerType1Value.Text = frmRotationConditions.RotationSpell.PowerType1Value.ToString();
			}
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x006F7F30 File Offset: 0x006F6130
		private void EnablePowerType2(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpPowerType2, null);
			this.selectPowerType2Target.SelectedIndex = 0;
			this.selectPowerType2.SelectedIndex = 0;
			this.selectPowerType2Compare.SelectedIndex = 0;
			this.txtPowerType2Value.Text = "";
			if (Status && frmRotationConditions.RotationSpell.HasPowerType2)
			{
				this.selectPowerType2Target.SelectedIndex = this.selectPowerType2Target.FindStringExact(frmRotationConditions.RotationSpell.PowerType2Target);
				this.selectPowerType2.SelectedIndex = this.selectPowerType2.FindStringExact(frmRotationConditions.RotationSpell.PowerType2);
				if (this.selectPowerType2.SelectedIndex == -1)
				{
					int selectedIndex = 0;
					if (frmRotationConditions.RotationSpell.PowerType1.Length > 0)
					{
						this.selectPowerType2.Items.Add(frmRotationConditions.RotationSpell.PowerType1);
						selectedIndex = this.selectPowerType2.Items.Count - 1;
					}
					this.selectPowerType2.SelectedIndex = selectedIndex;
				}
				this.selectPowerType2Compare.SelectedIndex = this.selectPowerType2Compare.FindStringExact(frmRotationConditions.RotationSpell.PowerType2Compare);
				this.txtPowerType2Value.Text = frmRotationConditions.RotationSpell.PowerType2Value.ToString();
			}
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x006F806C File Offset: 0x006F626C
		private void EnableItem(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpItem, null);
			this.selectItem.SelectedIndex = 0;
			this.selectItemCompare.SelectedIndex = 0;
			this.txtItemValue.Text = "";
			this.txtItemAmount.Text = "";
			if (Status && frmRotationConditions.RotationSpell.HasItem)
			{
				int num = this.selectItem.FindString(frmRotationConditions.RotationSpell.ItemName);
				if (num == -1)
				{
					this.selectItem.Items.Add(frmRotationConditions.RotationSpell.ItemName + " [" + frmRotationConditions.RotationSpell.ItemID.ToString() + "]");
					this.selectItem.SelectedIndex = this.selectItem.Items.Count - 1;
				}
				else
				{
					this.selectItem.SelectedIndex = num;
				}
				this.selectItemCompare.SelectedIndex = this.selectItemCompare.FindStringExact(frmRotationConditions.RotationSpell.ItemCompare);
				this.txtItemValue.Text = frmRotationConditions.RotationSpell.ItemValue.ToString();
				this.txtItemAmount.Text = frmRotationConditions.RotationSpell.ItemAmount.ToString();
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x006F81B0 File Offset: 0x006F63B0
		private void EnableAddition1(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpAddition1, null);
			this.selectAddition1Target.SelectedIndex = 0;
			this.selectAddition1Option.SelectedIndex = 0;
			this.selectAddition1Compare.SelectedIndex = 0;
			this.txtAddition1Value.Text = "";
			if (Status && frmRotationConditions.RotationSpell.HasAddition1)
			{
				this.selectAddition1Target.SelectedIndex = this.selectAddition1Target.FindStringExact(frmRotationConditions.RotationSpell.Addition1Target);
				this.selectAddition1Option.SelectedIndex = this.selectAddition1Option.FindStringExact(frmRotationConditions.RotationSpell.Addition1Option);
				this.selectAddition1Compare.SelectedIndex = this.selectAddition1Compare.FindStringExact(frmRotationConditions.RotationSpell.Addition1Compare);
				this.txtAddition1Value.Text = frmRotationConditions.RotationSpell.Addition1Value.ToString();
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x006F8290 File Offset: 0x006F6490
		private void EnableAddition2(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpAddition2, null);
			this.checkAddition2DoNotRecastIfActive.Checked = false;
			this.selectAddition2DoNotRecastIfActiveTarget.SelectedIndex = 0;
			if (Status && frmRotationConditions.RotationSpell.HasAddition2)
			{
				this.checkAddition2DoNotRecastIfActive.Checked = frmRotationConditions.RotationSpell.DoNotRecastIfActive;
				this.selectAddition2DoNotRecastIfActiveTarget.SelectedIndex = this.selectAddition2DoNotRecastIfActiveTarget.FindStringExact(frmRotationConditions.RotationSpell.DoNotRecastIfActiveTarget);
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x006F8308 File Offset: 0x006F6508
		private void EnableAddition3(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpAddition3, null);
			this.checkAddition3CastIfActive.Checked = false;
			this.selectAddition3CastIfActiveTarget.SelectedIndex = 0;
			if (Status && frmRotationConditions.RotationSpell.HasAddition3)
			{
				this.checkAddition3CastIfActive.Checked = frmRotationConditions.RotationSpell.CastIfActive;
				this.selectAddition3CastIfActiveTarget.SelectedIndex = this.selectAddition2DoNotRecastIfActiveTarget.FindStringExact(frmRotationConditions.RotationSpell.CastIfActiveTarget);
			}
			int count = frmRotationConditions.RotationSpell.CastIfActiveSpelllist.Count;
			if (count > 0)
			{
				this.btnAddition3CastIfActiveSpelllist.Text = "Spelllist (" + count.ToString() + ")";
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x006F83B4 File Offset: 0x006F65B4
		private void EnableAddition4(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpAddition4, null);
			this.checkAddition4AlwaysActiveCombat.Checked = false;
			this.checkAddition4AlwaysActiveCombatWay.Checked = false;
			this.checkAddition4AlwaysActiveOutOfCombat.Checked = false;
			if (Status)
			{
				this.checkAddition4AlwaysActiveCombat.Checked = frmRotationConditions.RotationSpell.AlwaysActiveCombat;
				this.checkAddition4AlwaysActiveCombatWay.Checked = frmRotationConditions.RotationSpell.AlwaysActiveCombatWay;
				this.checkAddition4AlwaysActiveOutOfCombat.Checked = frmRotationConditions.RotationSpell.AlwaysActiveOutOfCombat;
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x006F8434 File Offset: 0x006F6634
		private void EnableMultipleAttackers(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpMultipleAttackers, null);
			this.selectMultipleAttackersCompare.SelectedIndex = 0;
			this.txtMultipleAttackersValue.Text = "";
			this.txtMultipleAttackersDistance.Text = "";
			this.checkMultipleAttackersStepBack.Checked = false;
			if (Status && frmRotationConditions.RotationSpell.HasMultipleAttackers)
			{
				this.selectMultipleAttackersCompare.SelectedIndex = this.selectMultipleAttackersCompare.FindStringExact(frmRotationConditions.RotationSpell.MultipleAttackersCompare);
				this.txtMultipleAttackersValue.Text = frmRotationConditions.RotationSpell.MultipleAttackersValue.ToString();
				this.txtMultipleAttackersDistance.Text = frmRotationConditions.RotationSpell.MultipleAttackersDistance.ToString();
				this.checkMultipleAttackersStepBack.Checked = frmRotationConditions.RotationSpell.MultipleAttackersStepBack;
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x006F8504 File Offset: 0x006F6704
		private void EnableMisc(bool Status)
		{
			CustomUI.EnableGroupBox(Status, this.grpMisc, null);
			this.checkMiscTargetIsCasting.Checked = false;
			if (Status)
			{
				this.checkMiscTargetIsCasting.Checked = frmRotationConditions.RotationSpell.TargetIsCasting;
			}
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x006F8544 File Offset: 0x006F6744
		private void EnableMacro(bool Status)
		{
			this.Tab(this.tabMacro, Status);
			CustomUI.EnableGroupBox(Status, this.grpMacro, null);
			if (Status)
			{
				this.txtMacroName.Text = frmRotationConditions.RotationSpell.Name;
				if (frmRotationConditions.RotationSpell.Bar != 1)
				{
					this.selectMacroBar.SelectedIndex = 0;
				}
				else
				{
					this.selectMacroBar.SelectedIndex = 1;
				}
				this.selectMacroSlot.SelectedIndex = this.selectMacroSlot.FindStringExact(frmRotationConditions.RotationSpell.Slot.ToString());
				if (this.selectMacroSlot.SelectedIndex == -1)
				{
					this.selectMacroSlot.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x006F85EC File Offset: 0x006F67EC
		private void btnSave_Click(object sender, EventArgs e)
		{
			string text = this.txtPropertiesCooldown.Text;
			if (Tools.IsNumber(text, 1, 0, 0, 0))
			{
				frmRotationConditions.RotationSpell.Cooldown = Convert.ToInt32(text);
			}
			else
			{
				frmRotationConditions.RotationSpell.Cooldown = 0;
			}
			string text2 = this.txtPropertiesDifferentAuraID.Text;
			if (Tools.IsNumber(text2, 1, 0, 1, 0))
			{
				frmRotationConditions.RotationSpell.DifferentAuraID = Convert.ToInt32(text2);
			}
			else
			{
				frmRotationConditions.RotationSpell.DifferentAuraID = 0;
			}
			string text3 = this.txtPropertiesRepetitions.Text;
			if (!Tools.IsNumber(text3, 1, 0, 1, 0))
			{
				frmRotationConditions.RotationSpell.Repetitions = 0;
			}
			else
			{
				frmRotationConditions.RotationSpell.Repetitions = Convert.ToInt32(text3);
			}
			string text4 = this.txtPropertiesPrio.Text;
			if (Tools.IsNumber(text4, 1, 0, 0, 0))
			{
				frmRotationConditions.RotationSpell.Prio = Convert.ToInt32(text4);
			}
			frmRotationConditions.RotationSpell.Type = this.selectType.SelectedItem.ToString();
			frmRotationConditions.RotationSpell.CanCastWhileWalk = this.checkCanCastWhileWalk.Checked;
			string text5 = this.txtPowerType1Value.Text;
			if (!Tools.IsNumber(text5, 1, 0, 1, 0))
			{
				frmRotationConditions.RotationSpell.HasPowerType1 = false;
			}
			else
			{
				frmRotationConditions.RotationSpell.PowerType1Target = this.selectPowerType1Target.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.PowerType1 = this.selectPowerType1.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.PowerType1Compare = this.selectPowerType1Compare.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.PowerType1Value = Convert.ToInt32(text5);
				frmRotationConditions.RotationSpell.HasPowerType1 = true;
			}
			string text6 = this.txtPowerType2Value.Text;
			if (Tools.IsNumber(text6, 1, 0, 1, 0))
			{
				frmRotationConditions.RotationSpell.PowerType2Target = this.selectPowerType2Target.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.PowerType2 = this.selectPowerType2.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.PowerType2Compare = this.selectPowerType2Compare.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.PowerType2Value = Convert.ToInt32(text6);
				frmRotationConditions.RotationSpell.HasPowerType2 = true;
			}
			else
			{
				frmRotationConditions.RotationSpell.HasPowerType2 = false;
			}
			string text7 = this.txtItemValue.Text;
			if (Tools.IsNumber(text7, 1, 0, 0, 0) && this.selectItem.SelectedItem.ToString() != "Please login first." && this.selectItem.Text.Contains("["))
			{
				frmRotationConditions.RotationSpell.ItemName = this.selectItem.SelectedItem.ToString().Split(new char[]
				{
					'['
				})[0].TrimEnd(Array.Empty<char>());
				frmRotationConditions.RotationSpell.ItemID = Convert.ToInt32(this.selectItem.SelectedItem.ToString().Split(new char[]
				{
					'[',
					']'
				})[1]);
				frmRotationConditions.RotationSpell.ItemCompare = this.selectItemCompare.Text;
				frmRotationConditions.RotationSpell.ItemValue = Convert.ToInt32(text7);
				string text8 = this.txtItemAmount.Text;
				if (Tools.IsNumber(text8, 1, 0, 1, 0))
				{
					frmRotationConditions.RotationSpell.ItemAmount = Convert.ToInt32(text8);
				}
				frmRotationConditions.RotationSpell.HasItem = true;
			}
			else
			{
				frmRotationConditions.RotationSpell.HasItem = false;
			}
			string text9 = this.txtAddition1Value.Text;
			if (!Tools.IsNumber(text9, 1, 0, 1, 0))
			{
				frmRotationConditions.RotationSpell.HasAddition1 = false;
			}
			else
			{
				frmRotationConditions.RotationSpell.Addition1Target = this.selectAddition1Target.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.Addition1Option = this.selectAddition1Option.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.Addition1Compare = this.selectAddition1Compare.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.Addition1Value = Convert.ToInt32(text9);
				frmRotationConditions.RotationSpell.HasAddition1 = true;
			}
			bool @checked;
			if (!(@checked = this.checkAddition2DoNotRecastIfActive.Checked))
			{
				frmRotationConditions.RotationSpell.HasAddition2 = false;
			}
			else
			{
				frmRotationConditions.RotationSpell.DoNotRecastIfActive = @checked;
				frmRotationConditions.RotationSpell.DoNotRecastIfActiveTarget = this.selectAddition2DoNotRecastIfActiveTarget.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.HasAddition2 = true;
			}
			bool checked2;
			if ((checked2 = this.checkAddition3CastIfActive.Checked) && frmRotationConditions.RotationSpell.CastIfActiveSpelllist.Count > 0)
			{
				frmRotationConditions.RotationSpell.CastIfActive = checked2;
				frmRotationConditions.RotationSpell.CastIfActiveTarget = this.selectAddition3CastIfActiveTarget.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.HasAddition3 = true;
			}
			else
			{
				frmRotationConditions.RotationSpell.HasAddition3 = false;
			}
			frmRotationConditions.RotationSpell.AlwaysActiveCombat = this.checkAddition4AlwaysActiveCombat.Checked;
			frmRotationConditions.RotationSpell.AlwaysActiveCombatWay = this.checkAddition4AlwaysActiveCombatWay.Checked;
			frmRotationConditions.RotationSpell.AlwaysActiveOutOfCombat = this.checkAddition4AlwaysActiveOutOfCombat.Checked;
			string text10 = this.txtMultipleAttackersValue.Text;
			if (!Tools.IsNumber(text10, 1, 0, 1, 0))
			{
				frmRotationConditions.RotationSpell.HasMultipleAttackers = false;
			}
			else
			{
				frmRotationConditions.RotationSpell.MultipleAttackersCompare = this.selectMultipleAttackersCompare.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.MultipleAttackersValue = Convert.ToInt32(text10);
				frmRotationConditions.RotationSpell.MultipleAttackersStepBack = this.checkMultipleAttackersStepBack.Checked;
				string text11 = this.txtMultipleAttackersDistance.Text;
				if (Tools.IsNumber(text11, 1, 0, 1, 0))
				{
					frmRotationConditions.RotationSpell.MultipleAttackersDistance = Convert.ToInt32(text11);
				}
				frmRotationConditions.RotationSpell.HasMultipleAttackers = true;
			}
			bool checked3 = this.checkMiscTargetIsCasting.Checked;
			frmRotationConditions.RotationSpell.TargetIsCasting = checked3;
			frmRotationConditions.RotationSpell.HasMore = checked3;
			if (frmRotationConditions.RotationSpell.IsMacro)
			{
				string text12 = this.txtMacroName.Text.Trim();
				if (text12.Length > 0)
				{
					frmRotationConditions.RotationSpell.Name = text12;
				}
				string text13 = this.selectMacroBar.SelectedItem.ToString();
				text13 = text13.Replace("Top", "6").Replace("Bottom", "1");
				string value = this.selectMacroSlot.SelectedItem.ToString();
				frmRotationConditions.RotationSpell.Bar = Convert.ToInt32(text13);
				frmRotationConditions.RotationSpell.Slot = Convert.ToInt32(value);
			}
			frmRotation.UpdateList();
			base.Visible = false;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x006F8C28 File Offset: 0x006F6E28
		private void frmRotationConditions_FormClosing(object sender, FormClosingEventArgs e)
		{
			Jack.Core.Settings.WindowRotationConditionSize = new Size(base.Width, base.Height);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x006F8C4C File Offset: 0x006F6E4C
		private void btnItemReload_Click(object sender, EventArgs e)
		{
			this.LoadItems();
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x006F8C60 File Offset: 0x006F6E60
		private void btnAddition3CastIfActiveSpelllist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"RotationSpelllist"
			};
			Tools.OpenForm("frmList", false, "frmRotationConditions", args);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x006F8C90 File Offset: 0x006F6E90
		private void btnReset_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will reset all conditions related to this Spell.\r\nDo you want to continue?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Reset();
			}
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x006F8CBC File Offset: 0x006F6EBC
		private void Reset()
		{
			Rotation rotation = new Rotation();
			rotation.ID = frmRotationConditions.RotationSpell.ID;
			rotation.RequiredLevel = frmRotationConditions.RotationSpell.RequiredLevel;
			rotation.Name = frmRotationConditions.RotationSpell.Name;
			rotation.Rank = frmRotationConditions.RotationSpell.Rank;
			rotation.Type = frmRotationConditions.RotationSpell.Type;
			rotation.IsItem = frmRotationConditions.RotationSpell.IsItem;
			frmRotation.RecordedRotation.RemoveAll((Rotation x) => x.ID == frmRotationConditions.RotationSpell.ID);
			frmRotation.RecordedRotation.Add(rotation);
			frmRotationConditions.RotationSpell = rotation;
			this.SetControls();
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x006F8D70 File Offset: 0x006F6F70
		private void Tab(TabPage TabPage, bool Status)
		{
			if (Status)
			{
				if (!this.tabs.TabPages.Contains(TabPage))
				{
					this.tabs.Controls.Add(TabPage);
					return;
				}
			}
			else if (this.tabs.TabPages.Contains(TabPage))
			{
				this.tabs.Controls.Remove(TabPage);
			}
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x006F8DCC File Offset: 0x006F6FCC
		public void HideForm()
		{
			Jack.Core.Settings.WindowRotationConditionSize = new Size(base.Width, base.Height);
			base.Visible = false;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x006F8DF8 File Offset: 0x006F6FF8
		private void btnPropertiesTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			Tooltip tooltip = new Tooltip();
			string title = "Cooldown";
			string text = "Enter the spell cooldown in milliseconds.";
			text = text + "A cooldown with 0 uses the global cooldown of " + _globals.GlobalCooldown.ToString() + " ms.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.MarkControlName = "txtPropertiesCooldown";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Different Aura ID";
			text = "Buffs, Dots and Hots can trigger different effects on you and the target, ";
			text += "which have a different ID. If this is the case, you can enter this ID here.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.MarkControlName = "txtPropertiesDifferentAuraID";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Repetitions";
			text = "Set the number of repetitions of this spell per combat. ";
			text += "Applies only to spells that require casting or channeling time.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.MarkControlName = "txtPropertiesRepetitions";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Priority";
			text = "Here you can set your own priority of the order of your spells.\r\n\r\n";
			text += "Jack will always try to follow this order. If no fixed order is set, ";
			text += "Jack will set the priority himself.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.MarkControlName = "txtPropertiesPrio";
			tooltip4.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x006F8F8C File Offset: 0x006F718C
		private void btnTypeTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabGeneral";
			Tooltip tooltip = new Tooltip();
			string title = "Spell Type";
			string text = "Set the Spell Type here. Depending on the selection, other options are activated or deactivated.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectType";
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x006F9018 File Offset: 0x006F7218
		private void btnPowerType1Tooltip_Click(object sender, EventArgs e)
		{
			this.PowerTypeTooltip("1");
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x006F9030 File Offset: 0x006F7230
		private void btnPowerType2Tooltip_Click(object sender, EventArgs e)
		{
			this.PowerTypeTooltip("2");
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x006F9048 File Offset: 0x006F7248
		private void PowerTypeTooltip(string PowerTypeNumber)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabGeneral";
			Tooltip tooltip = new Tooltip();
			string title = "Subject";
			string text = "Select for whom this Power Type should be applied.\r\n\r\n";
			text += "If the Spell requires a \"minimum\" of a certain resource (Mana, Rage, etc.) ";
			text += "it \"must\" be set to one of the Power Types.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "selectPowerType" + PowerTypeNumber + "Target";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Power Type";
			text = "Select the Power Type.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "selectPowerType" + PowerTypeNumber;
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Condition";
			text = "Set a condition.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "selectPowerType" + PowerTypeNumber + "Compare";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Value";
			text = "Set the value of the condition according to the selected Power Type.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = selectTabPage;
			tooltip4.MarkControlName = "txtPowerType" + PowerTypeNumber + "Value";
			tooltip4.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x006F9228 File Offset: 0x006F7428
		private void btnItemTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabGeneral";
			Tooltip tooltip = new Tooltip();
			string title = "Item";
			string text = "Bind an item condition to this spell.\r\n";
			text += "Example: If item XX is available or at least XX number of the item is available.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpItem";
			tooltip.PinTooltipToControl = true;
			list.Add(tooltip);
			Tools.OpenTooltips(list);
		}

		// Token: 0x04000909 RID: 2313
		public static int SpellID;

		// Token: 0x0400090A RID: 2314
		public static Rotation RotationSpell;
	}
}
