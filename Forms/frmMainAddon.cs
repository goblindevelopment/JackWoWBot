using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x0200008F RID: 143
	public partial class frmMainAddon : Form
	{
		// Token: 0x06000E4D RID: 3661 RVA: 0x006C7070 File Offset: 0x006C5270
		public frmMainAddon()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x006C7090 File Offset: 0x006C5290
		private void frmMainAddon_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmMainAddon_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x006C70B4 File Offset: 0x006C52B4
		private void frmMainAddon_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x006C70D8 File Offset: 0x006C52D8
		private void LoadControlsAndSettings()
		{
			if (Jack.Core.Settings.GameFolder.Length > 0)
			{
				this.txtAddonInstallationFolder.Text = Jack.Core.Settings.GameFolder;
			}
			if (Jack.Core.Settings.AddonName.Length > 0)
			{
				this.txtAddonName.Text = Jack.Core.Settings.AddonName;
			}
			this.checkAddonOptionsAutoEquipWhite.Checked = Jack.Core.Settings.AddonAutoEquipWhite;
			this.checkAddonOptionsAutoEquipGreen.Checked = Jack.Core.Settings.AddonAutoEquipGreen;
			this.checkAddonOptionsAutoEquipBlue.Checked = Jack.Core.Settings.AddonAutoEquipBlue;
			this.checkAddonOptionsAutoEquipPurple.Checked = Jack.Core.Settings.AddonAutoEquipPurple;
			this.checkAddonOptionsAutoEquipBags.Checked = Jack.Core.Settings.AddonAutoEquipBags;
			if (Jack.Core.Settings.AddonAutoDestroyJunklist == null)
			{
				Jack.Core.Settings.AddonAutoDestroyJunklist = new List<string>();
			}
			if (Jack.Core.Settings.AddonAutoDestroyJunklist.Count > 0)
			{
				this.btnAddonOptionsAutoDestroyJunklist.Text = "Junklist (" + Jack.Core.Settings.AddonAutoDestroyJunklist.Count.ToString() + ")";
			}
			this.checkAddonOptionsAutoDestroyGrey.Checked = Jack.Core.Settings.AddonAutoDestroyGreys;
			this.checkAddonOptionsAutoDestroyWhite.Checked = Jack.Core.Settings.AddonAutoDestroyWhites;
			this.checkAddonOptionsAutoDestroyGreen.Checked = Jack.Core.Settings.AddonAutoDestroyGreens;
			this.checkAddonOptionsAutoDestroyBlue.Checked = Jack.Core.Settings.AddonAutoDestroyBlues;
			this.checkAddonOptionsAutoDestroyBOE.Checked = Jack.Core.Settings.AddonAutoDestroyBOE;
			this.NoCheck = true;
			this.checkAddonSettingsAutoCheckOnStart.Checked = Jack.Core.Settings.AddonCheckOnStart;
			this.NoCheck = false;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x006C7228 File Offset: 0x006C5428
		private void txtAddonInstallationFolder_Click(object sender, EventArgs e)
		{
			Addon.SelectWoWFolder();
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x006C723C File Offset: 0x006C543C
		private void btnAddonInstallationInstall_Click(object sender, EventArgs e)
		{
			Addon.Install("JK", true);
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x006C7254 File Offset: 0x006C5454
		private void btnAddonName_Click(object sender, EventArgs e)
		{
			string text = this.txtAddonName.Text.Replace(" ", "");
			this.txtAddonName.Text = text;
			if (text.Length > 0 && Tools.IsAlpha(text))
			{
				string addonName = Jack.Core.Settings.AddonName;
				Jack.Core.Settings.AddonName = text;
				Addon.Install(addonName, false);
				return;
			}
			MessageBox.Show("Please enter a name without any numbers or special characters.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x006C72C4 File Offset: 0x006C54C4
		private void btnAddonOptionsAutoDestroyJunklist_Click(object sender, EventArgs e)
		{
			object[] args = new object[]
			{
				"Junklist"
			};
			Tools.OpenForm("frmList", false, "frmMain", args);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x006C72F4 File Offset: 0x006C54F4
		private void btnAddonOptionsApply_Click(object sender, EventArgs e)
		{
			if (_globals.Start)
			{
				Tools.Console("You can't change these Settings while Jack is running.", "Red", "richConsole", "frmMain", true);
				return;
			}
			if (Jack.Core.Settings.GameFolder.Length > 0)
			{
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_EQUIP",
					"White"
				}, this.checkAddonOptionsAutoEquipWhite.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoEquipWhite = this.checkAddonOptionsAutoEquipWhite.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_EQUIP",
					"Green"
				}, this.checkAddonOptionsAutoEquipGreen.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoEquipGreen = this.checkAddonOptionsAutoEquipGreen.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_EQUIP",
					"Blue"
				}, this.checkAddonOptionsAutoEquipBlue.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoEquipBlue = this.checkAddonOptionsAutoEquipBlue.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_EQUIP",
					"Purple"
				}, this.checkAddonOptionsAutoEquipPurple.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoEquipPurple = this.checkAddonOptionsAutoEquipPurple.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_EQUIP",
					"Bags"
				}, this.checkAddonOptionsAutoEquipBags.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoEquipBags = this.checkAddonOptionsAutoEquipBags.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_DESTROY",
					"Grey"
				}, this.checkAddonOptionsAutoDestroyGrey.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoDestroyGreys = this.checkAddonOptionsAutoDestroyGrey.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_DESTROY",
					"White"
				}, this.checkAddonOptionsAutoDestroyWhite.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoDestroyWhites = this.checkAddonOptionsAutoDestroyWhite.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_DESTROY",
					"Green"
				}, this.checkAddonOptionsAutoDestroyGreen.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoDestroyGreens = this.checkAddonOptionsAutoDestroyGreen.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_DESTROY",
					"Blue"
				}, this.checkAddonOptionsAutoDestroyBlue.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoDestroyBlues = this.checkAddonOptionsAutoDestroyBlue.Checked;
				}
				if (Addon.ChangeSettings(new string[]
				{
					"AUTO_DESTROY",
					"BOE"
				}, this.checkAddonOptionsAutoDestroyBOE.Checked.ToString().ToLower()))
				{
					Jack.Core.Settings.AddonAutoDestroyBOE = this.checkAddonOptionsAutoDestroyBOE.Checked;
				}
				string text = "{}";
				if (Jack.Core.Settings.AddonAutoDestroyJunklist.Count > 0)
				{
					for (int i = 0; i < Jack.Core.Settings.AddonAutoDestroyJunklist.Count; i++)
					{
						if (i != 0)
						{
							text = text + ", \"" + Jack.Core.Settings.AddonAutoDestroyJunklist[i] + "\"";
						}
						else
						{
							text = "\"" + Jack.Core.Settings.AddonAutoDestroyJunklist[i] + "\"";
						}
					}
					text = "{ " + text + " }";
				}
				Addon.ChangeSettings(new string[]
				{
					"AUTO_DESTROY",
					"List"
				}, text);
				Addon.Reload(true);
				Tools.Console("Addon Settings has been applied.", "Green", "richConsole", "frmMain", true);
				return;
			}
			Addon.CheckOnStart();
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x006C76A0 File Offset: 0x006C58A0
		private void checkAddonSettingsAutoCheckOnStart_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.AddonCheckOnStart = this.checkAddonSettingsAutoCheckOnStart.Checked;
			Jack.Core.Settings.Save();
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x006C76CC File Offset: 0x006C58CC
		private void btnAddonTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabAddon";
			Tooltip tooltip = new Tooltip();
			string title = "Addon";
			string text = "Here you can install or reinstall the addon. Select your WoW folder. ";
			text += "Jack will automatically install the addon in all available clients.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpAddonInstallation";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Rename your Addon";
			text = "Make your addon unique and change the name.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "grpAddonName";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Settings: Auto-Equip";
			text = "After a loot, Jack compares your equipment with possibly new ones ";
			text += "from your bags and automatically equips them.\r\n\r\n";
			text += "Set here which categories Jack should automatically equip for you.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = "tabOptions";
			tooltip3.MarkControlName = "grpAddonOptionsAutoEquip";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Settings: Auto-Destroy";
			text = "Choose the item categories that you want Jack to automatically destroy.\r\n\r\n";
			text = text + Tools.HTMLColor("TIP!", "DeepSkyBlue") + "\r\n";
			text += "Important items such as Reagents, Herbs, Ores, Leather, etc. will not be destroyed.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = "tabOptions";
			tooltip4.MarkControlName = "grpAddonOptionsAutoDestroy";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Settings: Auto-Destroy Junklist";
			text = "Put here specific items on a list that Jack should destroy in any case.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = "tabOptions";
			tooltip5.MarkControlName = "btnAddonOptionsAutoDestroyJunklist";
			tooltip5.PinTooltipToControl = true;
			Tooltip tooltip6 = new Tooltip();
			title = "Apply your Addon Settings";
			text = "After you have set your desired settings, click here to transfer the settings to the addon.";
			tooltip6.Title = title;
			tooltip6.Text = text;
			tooltip6.FormName = base.Name;
			tooltip6.TabControl = tabControl;
			tooltip6.SelectTabPage = "tabOptions";
			tooltip6.MarkControlName = "btnAddonOptionsApply";
			tooltip6.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			list.Add(tooltip6);
			Tools.OpenTooltips(list);
		}

		// Token: 0x040005FE RID: 1534
		private bool NoCheck;
	}
}
