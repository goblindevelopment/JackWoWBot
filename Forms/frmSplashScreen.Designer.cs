namespace Jack.Forms
{
	// Token: 0x02000089 RID: 137
	public partial class frmSplashScreen : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E33 RID: 3635 RVA: 0x006C6F6C File Offset: 0x006C516C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x006C6F98 File Offset: 0x006C5198
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmSplashScreen));
			base.SuspendLayout();
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new global::System.Drawing.Size(280, 285);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmSplashScreen";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmSplashScreen";
			base.TopMost = true;
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmSplashScreen_FormClosed);
			base.Load += new global::System.EventHandler(this.frmSplashScreen_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x040005ED RID: 1517
		private global::System.ComponentModel.IContainer components;
	}
}
