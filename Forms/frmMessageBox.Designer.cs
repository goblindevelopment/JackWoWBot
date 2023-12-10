namespace Jack.Forms
{
	// Token: 0x02000058 RID: 88
	public partial class frmMessageBox : global::System.Windows.Forms.Form
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x0068288C File Offset: 0x00680A8C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x006828B8 File Offset: 0x00680AB8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmMessageBox));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.lblDialogText = new global::System.Windows.Forms.Label();
			this.btn2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.btn1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBox1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
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
			this.panelBox1.TabIndex = 74;
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
			this.lblDialogText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblDialogText.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblDialogText.ForeColor = global::System.Drawing.Color.White;
			this.lblDialogText.Location = new global::System.Drawing.Point(23, 61);
			this.lblDialogText.Name = "lblDialogText";
			this.lblDialogText.Size = new global::System.Drawing.Size(540, 18);
			this.lblDialogText.TabIndex = 73;
			this.lblDialogText.Text = "[TEXT]";
			this.btn2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btn2.BorderColor = global::System.Drawing.Color.Gray;
			this.btn2.BorderThickness = 1;
			this.btn2.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btn2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btn2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btn2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btn2.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btn2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btn2.ForeColor = global::System.Drawing.Color.White;
			this.btn2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btn2.Location = new global::System.Drawing.Point(383, 192);
			this.btn2.Name = "btn2";
			this.btn2.Size = new global::System.Drawing.Size(225, 30);
			this.btn2.TabIndex = 76;
			this.btn2.Text = "BTN2";
			this.btn2.Click += new global::System.EventHandler(this.btn2_Click);
			this.btn1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btn1.BorderColor = global::System.Drawing.Color.Gray;
			this.btn1.BorderThickness = 1;
			this.btn1.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btn1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btn1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btn1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btn1.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btn1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btn1.ForeColor = global::System.Drawing.Color.White;
			this.btn1.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btn1.Location = new global::System.Drawing.Point(24, 192);
			this.btn1.Name = "btn1";
			this.btn1.Size = new global::System.Drawing.Size(225, 30);
			this.btn1.TabIndex = 77;
			this.btn1.Text = "BTN1";
			this.btn1.Click += new global::System.EventHandler(this.btn1_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(632, 247);
			base.Controls.Add(this.btn1);
			base.Controls.Add(this.btn2);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmMessageBox";
			this.Text = "frmMessageBox";
			base.Load += new global::System.EventHandler(this.frmMessageBox_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400026F RID: 623
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000270 RID: 624
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000271 RID: 625
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x04000272 RID: 626
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x04000273 RID: 627
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x04000274 RID: 628
		private global::System.Windows.Forms.Label lblDialogText;

		// Token: 0x04000275 RID: 629
		private global::Guna.UI2.WinForms.Guna2Button btn2;

		// Token: 0x04000276 RID: 630
		private global::Guna.UI2.WinForms.Guna2Button btn1;
	}
}
