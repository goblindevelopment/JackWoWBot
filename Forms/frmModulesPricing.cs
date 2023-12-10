using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000059 RID: 89
	public partial class frmModulesPricing : Form
	{
		// Token: 0x0600087F RID: 2175 RVA: 0x0068305C File Offset: 0x0068125C
		public frmModulesPricing()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x0068307C File Offset: 0x0068127C
		private void frmModulesPricing_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Modules", true, false, true, false, false, true);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x006830A0 File Offset: 0x006812A0
		private void LoadControlsAndSettings()
		{
			if (_globals.ModuleMultiSession > 1)
			{
				CustomUI.EnableGroupBox(false, this.grpSession, null);
				this.imgModuleSession.Image = Resources.module_sessions_disabled;
				this.btnSession.Text = "Activated";
			}
			if (_globals.ModuleGather)
			{
				CustomUI.EnableGroupBox(false, this.grpGather, null);
				this.imgModuleGather.Image = Resources.module_gathering_disabled;
				this.btnGather.Text = "Activated";
			}
			if (_globals.ModuleDungeon)
			{
				CustomUI.EnableGroupBox(false, this.grpDungeon, null);
				this.imgModuleDungeon.Image = Resources.module_dungeons_disabled;
				this.btnDungeon.Text = "Activated";
			}
			if (_globals.ModuleNotifications)
			{
				CustomUI.EnableGroupBox(false, this.grpNotify, null);
				this.imgModuleNotify.Image = Resources.module_notifications_disabled;
				this.btnNotify.Text = "Activated";
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00683180 File Offset: 0x00681380
		private void LinkToModule_Click(object sender, EventArgs e)
		{
			Tools.LinkToModule();
		}
	}
}
