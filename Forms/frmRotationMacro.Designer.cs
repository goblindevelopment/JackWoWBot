namespace Jack.Forms
{
	// Token: 0x02000063 RID: 99
	public partial class frmRotationMacro : global::System.Windows.Forms.Form
	{
		// Token: 0x06000917 RID: 2327 RVA: 0x00686970 File Offset: 0x00684B70
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0068699C File Offset: 0x00684B9C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmRotationMacro));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.txtMacroName = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtMacroValue = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.txtMacroCooldown = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblMacroCooldown = new global::System.Windows.Forms.Label();
			this.lblMacroCooldownSeconds = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.panelTitle1.SuspendLayout();
			this.panelBtnSave.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.lblMacroCooldownSeconds);
			this.panelBox1.Controls.Add(this.lblMacroCooldown);
			this.panelBox1.Controls.Add(this.txtMacroCooldown);
			this.panelBox1.Controls.Add(this.txtMacroName);
			this.panelBox1.Controls.Add(this.txtMacroValue);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(438, 282);
			this.panelBox1.TabIndex = 75;
			this.txtMacroName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtMacroName.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroName.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMacroName.DefaultText = "";
			this.txtMacroName.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroName.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtMacroName.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroName.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroName.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtMacroName.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtMacroName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMacroName.ForeColor = global::System.Drawing.Color.White;
			this.txtMacroName.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtMacroName.Location = new global::System.Drawing.Point(22, 60);
			this.txtMacroName.MaxLength = 150;
			this.txtMacroName.Name = "txtMacroName";
			this.txtMacroName.PasswordChar = '\0';
			this.txtMacroName.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtMacroName.PlaceholderText = "Name";
			this.txtMacroName.SelectedText = "";
			this.txtMacroName.Size = new global::System.Drawing.Size(394, 30);
			this.txtMacroName.TabIndex = 97;
			this.txtMacroValue.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtMacroValue.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroValue.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMacroValue.DefaultText = "";
			this.txtMacroValue.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroValue.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtMacroValue.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroValue.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroValue.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtMacroValue.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtMacroValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMacroValue.ForeColor = global::System.Drawing.Color.White;
			this.txtMacroValue.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtMacroValue.Location = new global::System.Drawing.Point(22, 96);
			this.txtMacroValue.MaxLength = 255;
			this.txtMacroValue.Multiline = true;
			this.txtMacroValue.Name = "txtMacroValue";
			this.txtMacroValue.PasswordChar = '\0';
			this.txtMacroValue.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtMacroValue.PlaceholderText = "/cast Spell";
			this.txtMacroValue.SelectedText = "";
			this.txtMacroValue.Size = new global::System.Drawing.Size(394, 129);
			this.txtMacroValue.TabIndex = 95;
			this.panelTitle1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle1.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle1.Controls.Add(this.imgTitleEdge1);
			this.panelTitle1.Controls.Add(this.lblTitle1);
			this.panelTitle1.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle1.Name = "panelTitle1";
			this.panelTitle1.Size = new global::System.Drawing.Size(316, 38);
			this.panelTitle1.TabIndex = 66;
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle1.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle1.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new global::System.Drawing.Size(73, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "Macro";
			this.guna2Button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.guna2Button1.BorderColor = global::System.Drawing.Color.FromArgb(74, 74, 74);
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(31, 37, 46);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Gray;
			this.guna2Button1.HoverState.BorderColor = global::System.Drawing.Color.DimGray;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(35, 42, 54);
			this.guna2Button1.Location = new global::System.Drawing.Point(24, 370);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(120, 30);
			this.guna2Button1.TabIndex = 77;
			this.guna2Button1.Text = "Cancel";
			this.guna2Button1.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(182, 356);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 76;
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSave.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.Image = global::Jack.Properties.Resources.btn_add_disabled;
			this.btnSave.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnSave.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSave.ForeColor = global::System.Drawing.Color.White;
			this.btnSave.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.Image = global::Jack.Properties.Resources.btn_add_hover;
			this.btnSave.Image = global::Jack.Properties.Resources.btn_add;
			this.btnSave.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnSave.Location = new global::System.Drawing.Point(30, 0);
			this.btnSave.Name = "btnSave";
			this.btnSave.PressedDepth = 0;
			this.btnSave.Size = new global::System.Drawing.Size(235, 44);
			this.btnSave.TabIndex = 0;
			this.btnSave.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.imgTitleEdge1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge1.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge1.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge1.ImageRotate = 0f;
			this.imgTitleEdge1.Location = new global::System.Drawing.Point(246, 0);
			this.imgTitleEdge1.Name = "imgTitleEdge1";
			this.imgTitleEdge1.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge1.TabIndex = 66;
			this.imgTitleEdge1.TabStop = false;
			this.txtMacroCooldown.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.txtMacroCooldown.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroCooldown.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMacroCooldown.DefaultText = "0";
			this.txtMacroCooldown.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroCooldown.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtMacroCooldown.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroCooldown.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroCooldown.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtMacroCooldown.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtMacroCooldown.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMacroCooldown.ForeColor = global::System.Drawing.Color.White;
			this.txtMacroCooldown.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtMacroCooldown.Location = new global::System.Drawing.Point(86, 231);
			this.txtMacroCooldown.MaxLength = 4;
			this.txtMacroCooldown.Name = "txtMacroCooldown";
			this.txtMacroCooldown.PasswordChar = '\0';
			this.txtMacroCooldown.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtMacroCooldown.PlaceholderText = "";
			this.txtMacroCooldown.SelectedText = "";
			this.txtMacroCooldown.Size = new global::System.Drawing.Size(60, 30);
			this.txtMacroCooldown.TabIndex = 98;
			this.txtMacroCooldown.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.lblMacroCooldown.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblMacroCooldown.AutoSize = true;
			this.lblMacroCooldown.ForeColor = global::System.Drawing.Color.White;
			this.lblMacroCooldown.Location = new global::System.Drawing.Point(21, 240);
			this.lblMacroCooldown.Name = "lblMacroCooldown";
			this.lblMacroCooldown.Size = new global::System.Drawing.Size(57, 13);
			this.lblMacroCooldown.TabIndex = 99;
			this.lblMacroCooldown.Text = "Cooldown:";
			this.lblMacroCooldownSeconds.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblMacroCooldownSeconds.AutoSize = true;
			this.lblMacroCooldownSeconds.ForeColor = global::System.Drawing.Color.White;
			this.lblMacroCooldownSeconds.Location = new global::System.Drawing.Point(152, 240);
			this.lblMacroCooldownSeconds.Name = "lblMacroCooldownSeconds";
			this.lblMacroCooldownSeconds.Size = new global::System.Drawing.Size(29, 13);
			this.lblMacroCooldownSeconds.TabIndex = 100;
			this.lblMacroCooldownSeconds.Text = "Sec.";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(486, 440);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(486, 406);
			base.Name = "frmRotationMacro";
			this.Text = "frmRotationMacro";
			base.Load += new global::System.EventHandler(this.frmRotationMacro_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelBox1.PerformLayout();
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.panelBtnSave.ResumeLayout(false);
			this.imgTitleEdge1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002CA RID: 714
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002CB RID: 715
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x040002CC RID: 716
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x040002CD RID: 717
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x040002CE RID: 718
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x040002CF RID: 719
		private global::Guna.UI2.WinForms.Guna2TextBox txtMacroValue;

		// Token: 0x040002D0 RID: 720
		private global::Guna.UI2.WinForms.Guna2TextBox txtMacroName;

		// Token: 0x040002D1 RID: 721
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x040002D2 RID: 722
		private global::Guna.UI2.WinForms.Guna2Button btnSave;

		// Token: 0x040002D3 RID: 723
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x040002D4 RID: 724
		private global::System.Windows.Forms.Label lblMacroCooldownSeconds;

		// Token: 0x040002D5 RID: 725
		private global::System.Windows.Forms.Label lblMacroCooldown;

		// Token: 0x040002D6 RID: 726
		private global::Guna.UI2.WinForms.Guna2TextBox txtMacroCooldown;
	}
}
