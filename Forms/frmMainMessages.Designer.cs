namespace Jack.Forms
{
	// Token: 0x02000086 RID: 134
	public partial class frmMainMessages : global::System.Windows.Forms.Form
	{
		// Token: 0x06000CF5 RID: 3317 RVA: 0x006A90AC File Offset: 0x006A72AC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x006A90D8 File Offset: 0x006A72D8
		private void InitializeComponent()
		{
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelMessages = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelBox1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.panelMessages);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 22);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(894, 607);
			this.panelBox1.TabIndex = 68;
			this.panelMessages.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelMessages.AutoScroll = true;
			this.panelMessages.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelMessages.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelMessages.Location = new global::System.Drawing.Point(14, 53);
			this.panelMessages.Name = "panelMessages";
			this.panelMessages.Size = new global::System.Drawing.Size(868, 538);
			this.panelMessages.TabIndex = 67;
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(448, 38);
			this.panelTitle.TabIndex = 66;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(112, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Messages";
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(378, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 629);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainMessages";
			this.Text = "frmMainMessages";
			base.Load += new global::System.EventHandler(this.frmMainMessages_Load);
			base.Shown += new global::System.EventHandler(this.frmMainMessages_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainMessages_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000496 RID: 1174
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000497 RID: 1175
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000498 RID: 1176
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x04000499 RID: 1177
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x0400049A RID: 1178
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x0400049B RID: 1179
		private global::Guna.UI2.WinForms.Guna2Panel panelMessages;
	}
}
