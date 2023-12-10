using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000055 RID: 85
	public partial class frmLicense : Form
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x0067EDD0 File Offset: 0x0067CFD0
		public frmLicense(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			if (args.Count<object>() > 0)
			{
				this.Info = (string)args[0];
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0067EE1C File Offset: 0x0067D01C
		private void frmLicense_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "License", true, false, true, true, false, false);
			this.LoadLicense();
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0067EE40 File Offset: 0x0067D040
		private void LoadLicense()
		{
			if (this.Info.Length > 0)
			{
				this.lblInfo.Visible = true;
				this.lblInfo.Text = this.Info;
				this.lblInfo.ForeColor = Color.DeepSkyBlue;
			}
			else
			{
				this.lblInfo.Visible = false;
			}
			this.txtLicense.Text = Jack.Core.Settings.License;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0067EEA8 File Offset: 0x0067D0A8
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0067EEBC File Offset: 0x0067D0BC
		private void txtLicense_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.Save();
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0067EEDC File Offset: 0x0067D0DC
		private void Save()
		{
			if (this.IsValidLicense)
			{
				Jack.Core.Settings.License = this.txtLicense.Text;
				Jack.Core.Settings.Save();
				base.Close();
				return;
			}
			MessageBox.Show("Please enter a valid license.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			this.txtLicense.Text = "";
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x0067EF34 File Offset: 0x0067D134
		private bool IsValidLicense
		{
			get
			{
				string text = this.txtLicense.Text;
				return text != this.CurrentLicense && text.Length == 14 && text.Contains("-") && Regex.Match(text, "[A-Z0-9-]+").Success;
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0067EF88 File Offset: 0x0067D188
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0067EF9C File Offset: 0x0067D19C
		private void frmLicense_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.IsValidLicense)
			{
				Jack.Core.Settings.License = "";
				Environment.Exit(0);
			}
		}

		// Token: 0x04000241 RID: 577
		private string CurrentLicense = Jack.Core.Settings.License;

		// Token: 0x04000242 RID: 578
		private string Info = "";
	}
}
