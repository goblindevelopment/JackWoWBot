namespace Jack.Forms
{
	// Token: 0x02000055 RID: 85
	public partial class frmLicense : global::System.Windows.Forms.Form
	{
		// Token: 0x060007EE RID: 2030 RVA: 0x0067EFC4 File Offset: 0x0067D1C4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0067EFF0 File Offset: 0x0067D1F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmLicense));
			this.lblInfo = new global::System.Windows.Forms.Label();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.txtLicense = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnActivate = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelBox1.SuspendLayout();
			this.panelTitle1.SuspendLayout();
			this.panelBtnSave.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			base.SuspendLayout();
			this.lblInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblInfo.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.lblInfo.Location = new global::System.Drawing.Point(232, 25);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new global::System.Drawing.Size(330, 13);
			this.lblInfo.TabIndex = 59;
			this.lblInfo.Text = "[INFO]";
			this.lblInfo.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.lblInfo.Visible = false;
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.lblInfo);
			this.panelBox1.Controls.Add(this.txtLicense);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(584, 133);
			this.panelBox1.TabIndex = 72;
			this.txtLicense.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtLicense.BorderColor = global::System.Drawing.Color.Gray;
			this.txtLicense.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtLicense.DefaultText = "";
			this.txtLicense.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtLicense.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtLicense.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtLicense.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtLicense.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtLicense.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtLicense.Font = new global::System.Drawing.Font("Segoe UI", 21f);
			this.txtLicense.ForeColor = global::System.Drawing.Color.White;
			this.txtLicense.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtLicense.Location = new global::System.Drawing.Point(22, 60);
			this.txtLicense.Margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtLicense.MaxLength = 200;
			this.txtLicense.Name = "txtLicense";
			this.txtLicense.PasswordChar = '\0';
			this.txtLicense.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtLicense.PlaceholderText = "Enter License Code";
			this.txtLicense.SelectedText = "";
			this.txtLicense.Size = new global::System.Drawing.Size(540, 49);
			this.txtLicense.TabIndex = 67;
			this.txtLicense.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtLicense_KeyDown);
			this.panelTitle1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle1.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle1.Controls.Add(this.imgTitleEdge1);
			this.panelTitle1.Controls.Add(this.lblTitle1);
			this.panelTitle1.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle1.Name = "panelTitle1";
			this.panelTitle1.Size = new global::System.Drawing.Size(265, 38);
			this.panelTitle1.TabIndex = 66;
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle1.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle1.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new global::System.Drawing.Size(90, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "License";
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnCancel.BorderColor = global::System.Drawing.Color.FromArgb(74, 74, 74);
			this.btnCancel.BorderThickness = 1;
			this.btnCancel.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnCancel.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnCancel.FillColor = global::System.Drawing.Color.FromArgb(31, 37, 46);
			this.btnCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnCancel.ForeColor = global::System.Drawing.Color.Gray;
			this.btnCancel.HoverState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.HoverState.FillColor = global::System.Drawing.Color.FromArgb(35, 42, 54);
			this.btnCancel.Location = new global::System.Drawing.Point(24, 221);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(176, 30);
			this.btnCancel.TabIndex = 78;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnActivate);
			this.panelBtnSave.Location = new global::System.Drawing.Point(328, 207);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 77;
			this.btnActivate.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnActivate.BackColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.DisabledState.Image = global::Jack.Properties.Resources.btn_activate_disabled;
			this.btnActivate.FillColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnActivate.ForeColor = global::System.Drawing.Color.White;
			this.btnActivate.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnActivate.HoverState.Image = global::Jack.Properties.Resources.btn_activate_hover;
			this.btnActivate.Image = global::Jack.Properties.Resources.btn_activate;
			this.btnActivate.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnActivate.Location = new global::System.Drawing.Point(30, 0);
			this.btnActivate.Name = "btnActivate";
			this.btnActivate.PressedDepth = 0;
			this.btnActivate.Size = new global::System.Drawing.Size(235, 44);
			this.btnActivate.TabIndex = 0;
			this.btnActivate.Click += new global::System.EventHandler(this.btnSave_Click);
			this.imgTitleEdge1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge1.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge1.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge1.ImageRotate = 0f;
			this.imgTitleEdge1.Location = new global::System.Drawing.Point(195, 0);
			this.imgTitleEdge1.Name = "imgTitleEdge1";
			this.imgTitleEdge1.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge1.TabIndex = 66;
			this.imgTitleEdge1.TabStop = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(632, 292);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmLicense";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmLicense";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmLicense_FormClosing);
			base.Load += new global::System.EventHandler(this.frmLicense_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.panelBtnSave.ResumeLayout(false);
			this.imgTitleEdge1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000243 RID: 579
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000244 RID: 580
		private global::System.Windows.Forms.Label lblInfo;

		// Token: 0x04000245 RID: 581
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000246 RID: 582
		private global::Guna.UI2.WinForms.Guna2TextBox txtLicense;

		// Token: 0x04000247 RID: 583
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x04000248 RID: 584
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x04000249 RID: 585
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x0400024A RID: 586
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x0400024B RID: 587
		private global::Guna.UI2.WinForms.Guna2Button btnActivate;

		// Token: 0x0400024C RID: 588
		private global::Guna.UI2.WinForms.Guna2Button btnCancel;
	}
}
