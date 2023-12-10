namespace Jack.Forms
{
	// Token: 0x02000087 RID: 135
	public partial class frmMainAccount : global::System.Windows.Forms.Form
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x006A9670 File Offset: 0x006A7870
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x006A969C File Offset: 0x006A789C
		private void InitializeComponent()
		{
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelTitle = new global::System.Windows.Forms.Panel();
			this.imgTitleEdge = new global::System.Windows.Forms.PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.lblGreetingUsername = new global::System.Windows.Forms.Label();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabAccount = new global::System.Windows.Forms.TabPage();
			this.panelTabAccount = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpAccountLicense = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblAccountChangeLicense = new global::System.Windows.Forms.Label();
			this.btnAccountLicenseCopy = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtAccountLicense = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblAccountLicense = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.imgTitleEdge).BeginInit();
			this.tabs.SuspendLayout();
			this.tabAccount.SuspendLayout();
			this.panelTabAccount.SuspendLayout();
			this.grpAccountLicense.SuspendLayout();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.Controls.Add(this.lblGreetingUsername);
			this.panelBox1.Controls.Add(this.tabs);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 22);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(894, 607);
			this.panelBox1.TabIndex = 68;
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(448, 38);
			this.panelTitle.TabIndex = 70;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(378, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 67;
			this.imgTitleEdge.TabStop = false;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(98, 15);
			this.lblTitle.TabIndex = 66;
			this.lblTitle.Text = "Account";
			this.lblGreetingUsername.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblGreetingUsername.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblGreetingUsername.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.lblGreetingUsername.Location = new global::System.Drawing.Point(451, 18);
			this.lblGreetingUsername.Name = "lblGreetingUsername";
			this.lblGreetingUsername.Size = new global::System.Drawing.Size(413, 20);
			this.lblGreetingUsername.TabIndex = 69;
			this.lblGreetingUsername.Text = "[GREETING USERNAME]";
			this.lblGreetingUsername.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.tabs.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabAccount);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(180, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(868, 538);
			this.tabs.TabButtonHoverState.BorderColor = global::System.Drawing.Color.Empty;
			this.tabs.TabButtonHoverState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabs.TabButtonHoverState.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.TabButtonHoverState.ForeColor = global::System.Drawing.Color.White;
			this.tabs.TabButtonHoverState.InnerColor = global::System.Drawing.Color.DeepSkyBlue;
			this.tabs.TabButtonIdleState.BorderColor = global::System.Drawing.Color.Empty;
			this.tabs.TabButtonIdleState.FillColor = global::System.Drawing.Color.FromArgb(33, 42, 57);
			this.tabs.TabButtonIdleState.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.TabButtonIdleState.ForeColor = global::System.Drawing.Color.FromArgb(156, 160, 167);
			this.tabs.TabButtonIdleState.InnerColor = global::System.Drawing.Color.FromArgb(53, 64, 82);
			this.tabs.TabButtonSelectedState.BorderColor = global::System.Drawing.Color.Empty;
			this.tabs.TabButtonSelectedState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabs.TabButtonSelectedState.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.TabButtonSelectedState.ForeColor = global::System.Drawing.Color.White;
			this.tabs.TabButtonSelectedState.InnerColor = global::System.Drawing.Color.DeepSkyBlue;
			this.tabs.TabButtonSize = new global::System.Drawing.Size(180, 40);
			this.tabs.TabIndex = 67;
			this.tabs.TabMenuBackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.tabs.SelectedIndexChanged += new global::System.EventHandler(this.tabs_SelectedIndexChanged);
			this.tabAccount.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabAccount.Controls.Add(this.panelTabAccount);
			this.tabAccount.ForeColor = global::System.Drawing.Color.White;
			this.tabAccount.Location = new global::System.Drawing.Point(184, 4);
			this.tabAccount.Name = "tabAccount";
			this.tabAccount.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabAccount.Size = new global::System.Drawing.Size(680, 530);
			this.tabAccount.TabIndex = 0;
			this.tabAccount.Text = "Account";
			this.panelTabAccount.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabAccount.AutoScroll = true;
			this.panelTabAccount.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabAccount.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabAccount.Controls.Add(this.grpAccountLicense);
			this.panelTabAccount.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabAccount.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabAccount.Name = "panelTabAccount";
			this.panelTabAccount.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabAccount.TabIndex = 13;
			this.grpAccountLicense.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAccountLicense.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAccountLicense.Controls.Add(this.lblAccountChangeLicense);
			this.grpAccountLicense.Controls.Add(this.btnAccountLicenseCopy);
			this.grpAccountLicense.Controls.Add(this.txtAccountLicense);
			this.grpAccountLicense.Controls.Add(this.lblAccountLicense);
			this.grpAccountLicense.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAccountLicense.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAccountLicense.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAccountLicense.ForeColor = global::System.Drawing.Color.White;
			this.grpAccountLicense.Location = new global::System.Drawing.Point(14, 14);
			this.grpAccountLicense.Name = "grpAccountLicense";
			this.grpAccountLicense.Size = new global::System.Drawing.Size(652, 129);
			this.grpAccountLicense.TabIndex = 7;
			this.grpAccountLicense.Text = "License";
			this.lblAccountChangeLicense.AutoSize = true;
			this.lblAccountChangeLicense.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAccountChangeLicense.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblAccountChangeLicense.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblAccountChangeLicense.Location = new global::System.Drawing.Point(178, 98);
			this.lblAccountChangeLicense.Name = "lblAccountChangeLicense";
			this.lblAccountChangeLicense.Size = new global::System.Drawing.Size(90, 15);
			this.lblAccountChangeLicense.TabIndex = 69;
			this.lblAccountChangeLicense.Text = "Change License";
			this.lblAccountChangeLicense.Click += new global::System.EventHandler(this.lblAccountChangeLicense_Click);
			this.btnAccountLicenseCopy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAccountLicenseCopy.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAccountLicenseCopy.BorderThickness = 1;
			this.btnAccountLicenseCopy.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAccountLicenseCopy.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAccountLicenseCopy.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAccountLicenseCopy.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAccountLicenseCopy.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAccountLicenseCopy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAccountLicenseCopy.ForeColor = global::System.Drawing.Color.White;
			this.btnAccountLicenseCopy.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAccountLicenseCopy.Location = new global::System.Drawing.Point(525, 59);
			this.btnAccountLicenseCopy.Name = "btnAccountLicenseCopy";
			this.btnAccountLicenseCopy.Size = new global::System.Drawing.Size(104, 30);
			this.btnAccountLicenseCopy.TabIndex = 67;
			this.btnAccountLicenseCopy.Text = "Copy";
			this.btnAccountLicenseCopy.Click += new global::System.EventHandler(this.btnAccountLicenseCopy_Click);
			this.txtAccountLicense.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtAccountLicense.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAccountLicense.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtAccountLicense.DefaultText = "";
			this.txtAccountLicense.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAccountLicense.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtAccountLicense.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAccountLicense.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAccountLicense.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtAccountLicense.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtAccountLicense.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtAccountLicense.ForeColor = global::System.Drawing.Color.White;
			this.txtAccountLicense.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtAccountLicense.Location = new global::System.Drawing.Point(180, 59);
			this.txtAccountLicense.MaxLength = 25;
			this.txtAccountLicense.Name = "txtAccountLicense";
			this.txtAccountLicense.PasswordChar = '\0';
			this.txtAccountLicense.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtAccountLicense.PlaceholderText = "";
			this.txtAccountLicense.ReadOnly = true;
			this.txtAccountLicense.SelectedText = "";
			this.txtAccountLicense.Size = new global::System.Drawing.Size(339, 30);
			this.txtAccountLicense.TabIndex = 65;
			this.lblAccountLicense.AutoSize = true;
			this.lblAccountLicense.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAccountLicense.ForeColor = global::System.Drawing.Color.White;
			this.lblAccountLicense.Location = new global::System.Drawing.Point(22, 66);
			this.lblAccountLicense.Name = "lblAccountLicense";
			this.lblAccountLicense.Size = new global::System.Drawing.Size(49, 15);
			this.lblAccountLicense.TabIndex = 0;
			this.lblAccountLicense.Text = "License:";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 629);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainAccount";
			this.Text = "frmMainAccount";
			base.Load += new global::System.EventHandler(this.frmMainAccount_Load);
			base.Shown += new global::System.EventHandler(this.frmMainAccount_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainAccount_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.imgTitleEdge).EndInit();
			this.tabs.ResumeLayout(false);
			this.tabAccount.ResumeLayout(false);
			this.panelTabAccount.ResumeLayout(false);
			this.grpAccountLicense.ResumeLayout(false);
			this.grpAccountLicense.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400049C RID: 1180
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400049D RID: 1181
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400049E RID: 1182
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x0400049F RID: 1183
		private global::System.Windows.Forms.TabPage tabAccount;

		// Token: 0x040004A0 RID: 1184
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAccountLicense;

		// Token: 0x040004A1 RID: 1185
		private global::Guna.UI2.WinForms.Guna2TextBox txtAccountLicense;

		// Token: 0x040004A2 RID: 1186
		private global::System.Windows.Forms.Label lblAccountLicense;

		// Token: 0x040004A3 RID: 1187
		private global::System.Windows.Forms.Label lblGreetingUsername;

		// Token: 0x040004A4 RID: 1188
		private global::Guna.UI2.WinForms.Guna2Button btnAccountLicenseCopy;

		// Token: 0x040004A5 RID: 1189
		private global::System.Windows.Forms.Label lblAccountChangeLicense;

		// Token: 0x040004A6 RID: 1190
		private global::System.Windows.Forms.Panel panelTitle;

		// Token: 0x040004A7 RID: 1191
		private global::System.Windows.Forms.PictureBox imgTitleEdge;

		// Token: 0x040004A8 RID: 1192
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x040004A9 RID: 1193
		private global::Guna.UI2.WinForms.Guna2Panel panelTabAccount;
	}
}
