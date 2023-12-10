using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000090 RID: 144
	public partial class frmMainSettings : Form
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x006CA6AC File Offset: 0x006C88AC
		public frmMainSettings()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x006CA6CC File Offset: 0x006C88CC
		private void frmMainSettings_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmMainSettings_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x006CA6F0 File Offset: 0x006C88F0
		private void listLogs_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x006CA704 File Offset: 0x006C8904
		private void CenterListViewColumns()
		{
			Tools.ColorListViewHeader(ref this.listLogs, null);
			Tools.CenterListViewColumns(this.listLogs, null);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x006CA72C File Offset: 0x006C892C
		private void frmMainSettings_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x006CA750 File Offset: 0x006C8950
		private void LoadControlsAndSettings()
		{
			if (!_globals.IsTeam)
			{
				this.grpInfoBuildsPTR.Visible = false;
				this.grpInfoBuildsJack.Location = new Point(this.grpInfoBuildsPTR.Location.X, this.grpInfoBuildsPTR.Location.Y);
			}
			Initialize.SetInfo();
			this.LoadChangelog();
			new Thread(new ThreadStart(this.LoadLogs))
			{
				IsBackground = true
			}.Start();
			this.NoCheck = true;
			if (_globals.ModuleMultiSession > 1)
			{
				this.checkSettingsGameAutoDetect.ForeColor = Color.LimeGreen;
				this.checkSettingsGameAutoDetect.Checked = Jack.Core.Settings.JackAutoDetectWindow;
			}
			else
			{
				this.checkSettingsGameAutoDetect.ForeColor = Color.DimGray;
			}
			this.checkSettingsJackTray.Checked = Jack.Core.Settings.JackTray;
			this.txtAutoReconnectPassword.Text = Jack.Core.Settings.JackAutoReconnectPassword;
			this.checkAutoReconnect.Checked = Jack.Core.Settings.JackAutoReconnect;
			this.NoCheck = false;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x006CA848 File Offset: 0x006C8A48
		private void lblAddonSettingsPrintVersion_Click(object sender, EventArgs e)
		{
			if (!_globals.Ready)
			{
				MessageBox.Show("Please start the game and enter the world first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (Addon.IsReady(true, true, false, false))
			{
				Addon.LUA("_printVersion()", "0", false, true);
				new Thread(new ThreadStart(this.ChangePrintAddonVersionLabel))
				{
					IsBackground = true
				}.Start();
				return;
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x006CA8B0 File Offset: 0x006C8AB0
		private void ChangePrintAddonVersionLabel()
		{
			Tools.ControlColor("See game chat...", "lblAddonSettingsPrintVersion", "frmMainSettings", Color.LimeGreen, null, false);
			Thread.Sleep(2000);
			Tools.ControlColor("Show installed version", "lblAddonSettingsPrintVersion", "frmMainSettings", Color.CornflowerBlue, null, false);
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x006CA900 File Offset: 0x006C8B00
		private void lblInfoMapsClassicDownload_Click(object sender, EventArgs e)
		{
			this.lblInfoMapsClassicDownload.Visible = false;
			Initialize.CheckForPathfinderFiles("Classic");
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x006CA924 File Offset: 0x006C8B24
		private void lblInfoMapsRetailDownload_Click(object sender, EventArgs e)
		{
			this.lblInfoMapsRetailDownload.Visible = false;
			Initialize.CheckForPathfinderFiles("Retail");
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x006CA948 File Offset: 0x006C8B48
		private void btnInfoBuildsJackUpdates_Click(object sender, EventArgs e)
		{
			Tools.ButtonTimer("Check for Updates", "Check for Updates", 10, "btnInfoBuildsJackUpdates", "frmMainSettings");
			new Thread(delegate()
			{
				Initialize.CheckForUpdates(false);
			})
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x006CA9A0 File Offset: 0x006C8BA0
		private void LoadChangelog()
		{
			List<string> list = new List<string>();
			if (_globals.IsTeam)
			{
				Initialize.LoadToList(Initialize.GetResources("Jack._TEAM_.Changelog", false), list);
			}
			else
			{
				Initialize.LoadToList(Initialize.GetResources("Jack.Lists.Changelog", false), list);
			}
			string text = "";
			foreach (string str in list)
			{
				text = text + str + "\r\n";
			}
			this.richInfoChangelog.Text = text;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x006CAA38 File Offset: 0x006C8C38
		private void LoadLogs()
		{
			string text = DateTime.Now.ToString("dd.MM.yyyy");
			Dictionary<string[], string[]> dictionary = new Dictionary<string[], string[]>();
			string[] key = new string[]
			{
				text + " [Latest] (Today)"
			};
			dictionary.Add(key, new string[]
			{
				"",
				"Green"
			});
			foreach (string path in Directory.EnumerateFiles(_globals.JackLogs, "*.txt"))
			{
				string text2 = Path.GetFileName(path).Replace(".txt", "");
				if (text2 != text)
				{
					key = new string[]
					{
						text2
					};
					dictionary.Add(key, null);
				}
			}
			Tools.ControlListViewCreate(dictionary, "listLogs", "frmMainSettings", true, -1, null);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x006CAB20 File Offset: 0x006C8D20
		private void listLogs_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (Tools.ListViewHasSelection(this.listLogs))
			{
				string text = this.listLogs.SelectedItems[0].SubItems[0].Text;
				string text2 = _globals.JackLogs + "\\" + text + ".txt";
				text2 = text2.Replace(" [Latest] (Today)", "");
				if (File.Exists(text2))
				{
					Process.Start(text2);
				}
			}
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x006CAB94 File Offset: 0x006C8D94
		public static void OpenLogByConsole()
		{
			string str = DateTime.Now.ToString("dd.MM.yyyy");
			string text = _globals.JackLogs + "\\" + str + ".txt";
			if (File.Exists(text))
			{
				Process.Start(text);
			}
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x006CABDC File Offset: 0x006C8DDC
		private void checkSettingsGameAutoDetect_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			bool @checked = this.checkSettingsGameAutoDetect.Checked;
			if (_globals.ModuleMultiSession <= 1)
			{
				this.checkSettingsGameAutoDetect.CheckedChanged -= this.checkSettingsGameAutoDetect_CheckedChanged;
				this.checkSettingsGameAutoDetect.Checked = !@checked;
				this.checkSettingsGameAutoDetect.CheckedChanged += this.checkSettingsGameAutoDetect_CheckedChanged;
				CustomUI.DialogModule("frmMain");
				return;
			}
			Jack.Core.Settings.JackAutoDetectWindow = @checked;
			Tools.ControlVisible("btnAttach", "frmMain", !@checked);
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x006CAC68 File Offset: 0x006C8E68
		private void checkSettingsJackTray_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.JackTray = this.checkSettingsJackTray.Checked;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x006CAC90 File Offset: 0x006C8E90
		private void checkAutoReconnect_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked;
			if ((@checked = this.checkAutoReconnect.Checked) && this.txtAutoReconnectPassword.Text.Length == 0)
			{
				Jack.Core.Settings.JackAutoReconnect = false;
			}
			else
			{
				Jack.Core.Settings.JackAutoReconnect = @checked;
			}
			CustomUI.EnableGroupBox(@checked, this.grpAutoReconnect, new string[]
			{
				"checkAutoReconnect"
			});
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x006CACE8 File Offset: 0x006C8EE8
		private void btnAutoReconnectSave_Click(object sender, EventArgs e)
		{
			string text = this.txtAutoReconnectPassword.Text;
			if (this.btnAutoReconnectSave.Text != "Saved")
			{
				Jack.Core.Settings.JackAutoReconnectPassword = Crypt.Base64Encode(text);
				Tools.SwitchButtonColor("Saved", this.btnAutoReconnectSave.Text, "btnAutoReconnectSave", base.Name, "ForestGreen");
			}
			Jack.Core.Settings.JackAutoReconnect = (text.Length > 0);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x006CAD58 File Offset: 0x006C8F58
		private void btnInfoTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			Tooltip tooltip = new Tooltip();
			string title = "Builds";
			string text = "Here you can find all information about your currently installed WoW clients.\r\n\r\n";
			text += "You can also find out if Jack supports this client. ";
			text += "If the client is currently not supported, our team is already working on an update.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = "tabBuilds";
			tooltip.MarkControlName = "grpInfoBuildsLive";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Jack";
			text = "All information about Jack, the current version and updates. ";
			text += "You will be automatically informed as soon as an update is available.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = "tabBuilds";
			tooltip2.MarkControlName = "grpInfoBuildsJack";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Changelog";
			text = "Every change at a glance.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = "tabChangelog";
			tooltip3.MarkControlName = "grpInfoChangelog";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "Log";
			text = "Jack will create a new log for you every day. Here you can find all the logs already created. ";
			text += "Double click on a log to open it.\r\n\r\n";
			text = text + Tools.HTMLColor("TIP!", "DeepSkyBlue") + "\r\n";
			text += "Double-click on your console, in the lower left corner of Jack, to directly open the current log.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = "tabLog";
			tooltip4.MarkControlName = "grpLog";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "Settings";
			text = "Here you can find all settings concerning Jack.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = "tabJack";
			tooltip5.MarkControlName = "grpSettingsJack";
			tooltip5.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			Tools.OpenTooltips(list);
		}

		// Token: 0x04000623 RID: 1571
		private bool NoCheck;
	}
}
