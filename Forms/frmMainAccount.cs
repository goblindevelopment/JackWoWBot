using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000087 RID: 135
	public partial class frmMainAccount : Form
	{
		// Token: 0x06000D18 RID: 3352 RVA: 0x006A9528 File Offset: 0x006A7728
		public frmMainAccount()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x006A9548 File Offset: 0x006A7748
		private void frmMainAccount_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmMainAccount_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x006A956C File Offset: 0x006A776C
		private void frmMainAccount_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x006A9590 File Offset: 0x006A7790
		private void LoadControlsAndSettings()
		{
			this.lblGreetingUsername.Text = "Hey " + _globals.UserData["Username"] + "!";
			this.txtAccountLicense.Text = Jack.Core.Settings.License;
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x006A95D8 File Offset: 0x006A77D8
		private void btnAccountLicenseCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.txtAccountLicense.Text);
			if (this.btnAccountLicenseCopy.Text != "Copied")
			{
				Tools.SwitchButtonColor("Copied", this.btnAccountLicenseCopy.Text, "btnAccountLicenseCopy", base.Name, "ForestGreen");
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x006A9634 File Offset: 0x006A7834
		private void lblAccountChangeLicense_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Your license will be reset and Jack will be closed.\r\nPlease restart Jack afterwards.\r\n\r\nDo you want to continue?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Jack.Core.Settings.License = "";
				Jack.Core.Settings.Save();
				Tools.CloseJack(true);
			}
		}
	}
}
