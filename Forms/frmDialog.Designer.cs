namespace Jack.Forms
{
	// Token: 0x0200004D RID: 77
	public partial class frmDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x0067C3C4 File Offset: 0x0067A5C4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0067C3F0 File Offset: 0x0067A5F0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmDialog));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblDialogText = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnClose = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBox1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.lblDialogText);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(584, 103);
			this.panelBox1.TabIndex = 73;
			this.lblDialogText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblDialogText.AutoSize = false;
			this.lblDialogText.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDialogText.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblDialogText.ForeColor = global::System.Drawing.Color.White;
			this.lblDialogText.Location = new global::System.Drawing.Point(23, 63);
			this.lblDialogText.Name = "lblDialogText";
			this.lblDialogText.Size = new global::System.Drawing.Size(540, 18);
			this.lblDialogText.TabIndex = 72;
			this.lblDialogText.Text = "[INFO]";
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(362, 38);
			this.panelTitle.TabIndex = 71;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(292, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(51, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Info";
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnClose);
			this.panelBtnSave.Location = new global::System.Drawing.Point(328, 177);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 78;
			this.btnClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.BackColor = global::System.Drawing.Color.Transparent;
			this.btnClose.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.Image = global::Jack.Properties.Resources.btn_close_disabled;
			this.btnClose.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClose.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnClose.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnClose.ForeColor = global::System.Drawing.Color.White;
			this.btnClose.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClose.HoverState.Image = global::Jack.Properties.Resources.btn_close_hover;
			this.btnClose.Image = global::Jack.Properties.Resources.btn_close;
			this.btnClose.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnClose.Location = new global::System.Drawing.Point(30, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.PressedDepth = 0;
			this.btnClose.Size = new global::System.Drawing.Size(235, 44);
			this.btnClose.TabIndex = 0;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(632, 260);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmDialog";
			base.Load += new global::System.EventHandler(this.frmDialog_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000203 RID: 515
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000204 RID: 516
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000205 RID: 517
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x04000206 RID: 518
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x04000207 RID: 519
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x04000208 RID: 520
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblDialogText;

		// Token: 0x04000209 RID: 521
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x0400020A RID: 522
		private global::Guna.UI2.WinForms.Guna2Button btnClose;
	}
}
