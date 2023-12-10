namespace Jack.Forms
{
	// Token: 0x02000064 RID: 100
	public partial class frmSplashScreenControls : global::System.Windows.Forms.Form
	{
		// Token: 0x06000934 RID: 2356 RVA: 0x006878B4 File Offset: 0x00685AB4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x006878E0 File Offset: 0x00685AE0
		private void InitializeComponent()
		{
			this.progress = new global::Guna.UI2.WinForms.Guna2VProgressBar();
			base.SuspendLayout();
			this.progress.BackColor = global::System.Drawing.Color.Transparent;
			this.progress.BorderColor = global::System.Drawing.Color.Transparent;
			this.progress.BorderRadius = 5;
			this.progress.FillColor = global::System.Drawing.Color.Transparent;
			this.progress.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.progress.Location = new global::System.Drawing.Point(35, 78);
			this.progress.Name = "progress";
			this.progress.ProgressColor = global::System.Drawing.Color.FromArgb(141, 181, 194);
			this.progress.ProgressColor2 = global::System.Drawing.Color.DodgerBlue;
			this.progress.Size = new global::System.Drawing.Size(176, 176);
			this.progress.TabIndex = 71;
			this.progress.TextMode = 0;
			this.progress.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.White;
			base.ClientSize = new global::System.Drawing.Size(280, 285);
			base.Controls.Add(this.progress);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frmSplashScreenControls";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSplashScreenControls";
			base.TransparencyKey = global::System.Drawing.Color.White;
			base.ResumeLayout(false);
		}

		// Token: 0x040002D7 RID: 727
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002D8 RID: 728
		private global::Guna.UI2.WinForms.Guna2VProgressBar progress;
	}
}
