using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.ATH;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000083 RID: 131
	public partial class frmMainModules : Form
	{
		// Token: 0x06000CA3 RID: 3235 RVA: 0x006A491C File Offset: 0x006A2B1C
		public frmMainModules(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x006A493C File Offset: 0x006A2B3C
		private void frmMainModule_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmMainModule_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x006A4960 File Offset: 0x006A2B60
		private void frmMainModules_SizeChanged(object sender, EventArgs e)
		{
			if (frmMainModules.Module.Length > 0)
			{
				int width = this.tabs.TabPages["tabModule" + frmMainModules.Module].Size.Width;
				this.btnGatherActivate.Left = (width - this.btnGatherActivate.Width) / 2;
				this.btnDungeonActivate.Left = (width - this.btnDungeonActivate.Width) / 2;
				this.btnSessionActivate.Left = (width - this.btnSessionActivate.Width) / 2;
				this.btnNotificationsActivate.Left = (width - this.btnNotificationsActivate.Width) / 2;
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x006A4A14 File Offset: 0x006A2C14
		private void frmMainModule_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x006A4A38 File Offset: 0x006A2C38
		private void LoadControlsAndSettings()
		{
			if (frmMainModules.Module.Length > 0)
			{
				this.tabs.SelectedTab = this.tabs.TabPages["tabModule" + frmMainModules.Module];
				Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
				dictionary["Gather"] = _globals.ModuleGather;
				dictionary["Dungeon"] = _globals.ModuleDungeon;
				dictionary["Session"] = (_globals.ModuleMultiSession > 1);
				dictionary["Notifications"] = _globals.ModuleNotifications;
				Dictionary<string, bool> dictionary2 = dictionary;
				foreach (KeyValuePair<string, bool> keyValuePair in dictionary2)
				{
					Tools.ControlVisible("btn" + keyValuePair.Key + "Activate", "frmMainModules", !keyValuePair.Value);
					if (keyValuePair.Value)
					{
						Tools.ControlColor("This module is activated and ready to use.", "lbl" + keyValuePair.Key, "frmMainModules", Color.LimeGreen, null, false);
					}
					else
					{
						Tools.ControlColor("This module is only available after activation.", "lbl" + keyValuePair.Key, "frmMainModules", Color.DarkGray, null, false);
					}
				}
				this.EnableNotifications(dictionary2["Notifications"]);
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x006A4BA0 File Offset: 0x006A2DA0
		private void EnableNotifications(bool Status)
		{
			this.NoCheck = true;
			this.checkNotifyDiscord.Checked = false;
			this.grpNotifyDiscord.Visible = Status;
			this.checkNotifyPushover.Checked = false;
			this.grpNotifyPushover.Visible = Status;
			this.checkNotificationsLevelUp.Checked = Jack.Core.Settings.NotificationsLevelUp;
			this.checkNotificationsGhost.Checked = Jack.Core.Settings.NotificationsGhost;
			this.checkNotificationsEvents.Checked = Jack.Core.Settings.NotificationsEvent;
			this.NoCheck = false;
			if (Status)
			{
				this.checkNotifyDiscord.Checked = Jack.Core.Settings.NotificationsDiscord;
				this.txtNotifyDiscordUserID.Text = Jack.Core.Settings.NotificationsDiscordUserID;
				this.checkNotifyPushover.Checked = Jack.Core.Settings.NotificationsPushover;
				this.txtNotifyPushoverToken.Text = Jack.Core.Settings.NotificationsPushoverToken;
				this.txtNotifyPushoverKey.Text = Jack.Core.Settings.NotificationsPushoverKey;
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x006A4C70 File Offset: 0x006A2E70
		private void checkNotifyDiscord_CheckedChanged(object sender, EventArgs e)
		{
			CustomUI.EnableGroupBox(this.checkNotifyDiscord.Checked, this.grpNotifyDiscord, new string[]
			{
				"checkNotifyDiscord"
			});
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x006A4CA4 File Offset: 0x006A2EA4
		private void btnNotifyDiscordTest_Click(object sender, EventArgs e)
		{
			string UserID = this.txtNotifyDiscordUserID.Text.Replace(" ", "");
			if (UserID.Length > 0 && UserID.All(new Func<char, bool>(char.IsDigit)))
			{
				Tools.ButtonTimer("Send Test Message", "Please wait...", 10, "btnNotifyDiscordTest", "frmMainModules");
				new Thread(delegate()
				{
					this.SendDiscordTestMessage(UserID);
				})
				{
					IsBackground = true
				}.Start();
				return;
			}
			MessageBox.Show("Please enter a valid User ID.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x006A4D54 File Offset: 0x006A2F54
		private void SendDiscordTestMessage(string UserID)
		{
			string plainText = "Hey Jack!\r\nYour test was successful.";
			string a = REQ.Ath("NTS", "&ntst=Discord&duid=" + UserID + "&dmsg=" + Crypt.Base64Encode(plainText));
			string text;
			MessageBoxIcon icon;
			if (a == "Success")
			{
				text = "Your message is on its way!";
				icon = MessageBoxIcon.Asterisk;
				Jack.Core.Settings.NotificationsDiscord = true;
				Jack.Core.Settings.NotificationsDiscordUserID = UserID;
				Jack.Core.Settings.Save();
			}
			else if (a == "WrongUserID")
			{
				text = "This User could not be found.\r\nPlease check your User ID and make sure you've joined our Discord.";
				icon = MessageBoxIcon.Exclamation;
			}
			else
			{
				text = "Connection could not be established.\r\nPlease try again later or contact the support.";
				icon = MessageBoxIcon.Exclamation;
			}
			MessageBox.Show(text, Tools.RandomString(15, false), MessageBoxButtons.OK, icon);
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x006A4DEC File Offset: 0x006A2FEC
		private void btnNotifyDiscordJoin_Click(object sender, EventArgs e)
		{
			if (_globals.LCS.d800.Length > 0)
			{
				Process.Start(_globals.LCS.d800);
			}
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x006A4E1C File Offset: 0x006A301C
		private void btnNotifyDiscordCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.txtNotifyDiscordMyID.Text);
			if (this.btnNotifyDiscordCopy.Text != "Copied")
			{
				Tools.SwitchButtonColor("Copied", this.btnNotifyDiscordCopy.Text, "btnNotifyDiscordCopy", base.Name, "ForestGreen");
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void lblNotifyPushoverTutorial_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x006A4E78 File Offset: 0x006A3078
		private void checkNotifyPushover_CheckedChanged(object sender, EventArgs e)
		{
			CustomUI.EnableGroupBox(this.checkNotifyPushover.Checked, this.grpNotifyPushover, new string[]
			{
				"checkNotifyPushover"
			});
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x006A4EAC File Offset: 0x006A30AC
		private void btnNotifyPushoverTest_Click(object sender, EventArgs e)
		{
			string PushoverToken = this.txtNotifyPushoverToken.Text.Replace(" ", "");
			string PushoverKey = this.txtNotifyPushoverKey.Text.Replace(" ", "");
			if (PushoverToken.Length > 0 && PushoverKey.Length > 0 && PushoverToken != PushoverKey)
			{
				Tools.ButtonTimer("Send Test Message", "Please wait...", 10, "btnNotifyPushoverTest", "frmMainModules");
				new Thread(delegate()
				{
					this.SendPushoverTestMessage(PushoverToken, PushoverKey);
				})
				{
					IsBackground = true
				}.Start();
				return;
			}
			MessageBox.Show("Please check your Token and Key.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x006A4F84 File Offset: 0x006A3184
		private void SendPushoverTestMessage(string PushoverToken, string PushoverKey)
		{
			string text = Tools.CallURL("https://api.pushover.net/1/messages.json", "", "", "", new Dictionary<string, string>
			{
				{
					"token",
					PushoverToken
				},
				{
					"&user",
					PushoverKey
				},
				{
					"&message",
					"Hey Jack!\r\nYour test was successful."
				}
			});
			string text2 = "";
			MessageBoxIcon icon = MessageBoxIcon.Asterisk;
			if (text.Length > 0)
			{
				text = text.Replace("\"", "");
				if (text.Contains("status:1"))
				{
					text2 = "Your message is on its way!";
					icon = MessageBoxIcon.Asterisk;
					Jack.Core.Settings.NotificationsPushover = true;
					Jack.Core.Settings.NotificationsPushoverToken = PushoverToken;
					Jack.Core.Settings.NotificationsPushoverKey = PushoverKey;
					Jack.Core.Settings.Save();
				}
			}
			if (text2 == "")
			{
				text2 = "The message could not be delivered.";
				icon = MessageBoxIcon.Exclamation;
			}
			MessageBox.Show(text2, Tools.RandomString(15, false), MessageBoxButtons.OK, icon);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x006A5054 File Offset: 0x006A3254
		private void checkNotificationsLevelUp_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.NotificationsLevelUp = this.checkNotificationsLevelUp.Checked;
			Jack.Core.Settings.Save();
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x006A5080 File Offset: 0x006A3280
		private void checkNotificationsGhost_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.NotificationsGhost = this.checkNotificationsGhost.Checked;
			Jack.Core.Settings.Save();
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x006A50AC File Offset: 0x006A32AC
		private void checkNotificationsEvents_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.NotificationsEvent = this.checkNotificationsEvents.Checked;
			Jack.Core.Settings.Save();
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x006A50D8 File Offset: 0x006A32D8
		private void LinkToModule_Click(object sender, EventArgs e)
		{
			CustomUI.DialogModule("frmMain");
		}

		// Token: 0x04000458 RID: 1112
		private bool NoCheck;

		// Token: 0x04000459 RID: 1113
		public static string Module = "Gather";
	}
}
