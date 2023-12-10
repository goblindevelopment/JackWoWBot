namespace Jack.Forms
{
	// Token: 0x02000057 RID: 87
	public partial class frmLoading : global::System.Windows.Forms.Form
	{
		// Token: 0x06000859 RID: 2137 RVA: 0x00682584 File Offset: 0x00680784
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x006825B0 File Offset: 0x006807B0
		private void InitializeComponent()
		{
			this.progress = new global::Guna.UI2.WinForms.Guna2ProgressBar();
			base.SuspendLayout();
			this.progress.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.progress.Location = new global::System.Drawing.Point(6, 6);
			this.progress.Name = "progress";
			this.progress.ProgressColor = global::System.Drawing.Color.DeepSkyBlue;
			this.progress.ProgressColor2 = global::System.Drawing.Color.DodgerBlue;
			this.progress.ShowText = true;
			this.progress.Size = new global::System.Drawing.Size(188, 28);
			this.progress.TabIndex = 0;
			this.progress.Text = "Loading...";
			this.progress.TextOffset = new global::System.Drawing.Point(0, 2);
			this.progress.TextRenderingHint = global::System.Drawing.Text.TextRenderingHint.SystemDefault;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(200, 40);
			base.Controls.Add(this.progress);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmLoading";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "frmLoading";
			base.ResumeLayout(false);
		}

		// Token: 0x0400026A RID: 618
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400026B RID: 619
		private global::Guna.UI2.WinForms.Guna2ProgressBar progress;
	}
}
