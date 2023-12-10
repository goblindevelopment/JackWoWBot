namespace Jack.Forms
{
	// Token: 0x0200004E RID: 78
	public partial class frmDownload : global::System.Windows.Forms.Form
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x0067D7AC File Offset: 0x0067B9AC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0067D7D8 File Offset: 0x0067B9D8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmDownload));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.progress = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			this.lblProgress = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.Controls.Add(this.progress);
			this.panelBox1.Controls.Add(this.lblProgress);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(21, 21);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(584, 106);
			this.panelBox1.TabIndex = 73;
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(298, 38);
			this.panelTitle.TabIndex = 69;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(228, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(90, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Install";
			this.progress.ForeColor = global::System.Drawing.Color.Black;
			this.progress.Location = new global::System.Drawing.Point(22, 60);
			this.progress.Name = "progress";
			this.progress.ProgressColor = global::System.Drawing.Color.DodgerBlue;
			this.progress.ProgressColor2 = global::System.Drawing.Color.MidnightBlue;
			this.progress.Size = new global::System.Drawing.Size(540, 23);
			this.progress.TabIndex = 68;
			this.progress.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.lblProgress.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblProgress.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.lblProgress.Location = new global::System.Drawing.Point(268, 28);
			this.lblProgress.Name = "lblProgress";
			this.lblProgress.Size = new global::System.Drawing.Size(294, 20);
			this.lblProgress.TabIndex = 59;
			this.lblProgress.Text = "Installing...";
			this.lblProgress.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(625, 149);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDownload";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Install";
			base.Shown += new global::System.EventHandler(this.Download_Shown);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000219 RID: 537
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400021A RID: 538
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.Label lblProgress;

		// Token: 0x0400021C RID: 540
		private global::Guna.UI2.WinForms.Guna2ProgressBar progress;

		// Token: 0x0400021D RID: 541
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x0400021E RID: 542
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x0400021F RID: 543
		private global::System.Windows.Forms.Label lblTitle;
	}
}
