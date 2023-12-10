namespace Jack.Forms
{
	// Token: 0x020000B9 RID: 185
	public partial class frmRotationSave : global::System.Windows.Forms.Form
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x0070155C File Offset: 0x006FF75C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00701588 File Offset: 0x006FF788
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmRotationSave));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.txtName = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnRecorderSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnCancel = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBox1.SuspendLayout();
			this.panelTitle1.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.txtName);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(584, 133);
			this.panelBox1.TabIndex = 71;
			this.txtName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtName.BorderColor = global::System.Drawing.Color.Gray;
			this.txtName.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtName.DefaultText = "";
			this.txtName.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtName.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtName.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtName.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtName.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtName.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtName.Font = new global::System.Drawing.Font("Segoe UI", 21f);
			this.txtName.ForeColor = global::System.Drawing.Color.White;
			this.txtName.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtName.Location = new global::System.Drawing.Point(22, 60);
			this.txtName.Margin = new global::System.Windows.Forms.Padding(5, 6, 5, 6);
			this.txtName.MaxLength = 200;
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = '\0';
			this.txtName.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtName.PlaceholderText = "Rotation Name";
			this.txtName.SelectedText = "";
			this.txtName.Size = new global::System.Drawing.Size(540, 49);
			this.txtName.TabIndex = 67;
			this.txtName.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
			this.panelTitle1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle1.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle1.Controls.Add(this.imgTitleEdge1);
			this.panelTitle1.Controls.Add(this.lblTitle1);
			this.panelTitle1.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle1.Name = "panelTitle1";
			this.panelTitle1.Size = new global::System.Drawing.Size(340, 38);
			this.panelTitle1.TabIndex = 66;
			this.imgTitleEdge1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge1.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge1.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge1.ImageRotate = 0f;
			this.imgTitleEdge1.Location = new global::System.Drawing.Point(270, 0);
			this.imgTitleEdge1.Name = "imgTitleEdge1";
			this.imgTitleEdge1.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge1.TabIndex = 66;
			this.imgTitleEdge1.TabStop = false;
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle1.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle1.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new global::System.Drawing.Size(162, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "Save Rotation";
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnRecorderSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(328, 207);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 73;
			this.btnRecorderSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderSave.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.Image = global::Jack.Properties.Resources.btn_save_disabled;
			this.btnRecorderSave.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderSave.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderSave.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.HoverState.Image = global::Jack.Properties.Resources.btn_save_hover;
			this.btnRecorderSave.Image = global::Jack.Properties.Resources.btn_save;
			this.btnRecorderSave.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnRecorderSave.Location = new global::System.Drawing.Point(30, 0);
			this.btnRecorderSave.Name = "btnRecorderSave";
			this.btnRecorderSave.PressedDepth = 0;
			this.btnRecorderSave.Size = new global::System.Drawing.Size(235, 44);
			this.btnRecorderSave.TabIndex = 0;
			this.btnRecorderSave.Click += new global::System.EventHandler(this.btnSave_Click);
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
			this.btnCancel.TabIndex = 74;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(632, 291);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmRotationSave";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmRotationSave";
			base.Load += new global::System.EventHandler(this.frmRotationSave_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.imgTitleEdge1.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400097F RID: 2431
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000980 RID: 2432
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000981 RID: 2433
		private global::Guna.UI2.WinForms.Guna2TextBox txtName;

		// Token: 0x04000982 RID: 2434
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x04000983 RID: 2435
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x04000984 RID: 2436
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x04000985 RID: 2437
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x04000986 RID: 2438
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderSave;

		// Token: 0x04000987 RID: 2439
		private global::Guna.UI2.WinForms.Guna2Button btnCancel;
	}
}
