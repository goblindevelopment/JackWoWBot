namespace Jack.Forms
{
	// Token: 0x02000065 RID: 101
	public partial class frmTooltip : global::System.Windows.Forms.Form
	{
		// Token: 0x06000949 RID: 2377 RVA: 0x0068821C File Offset: 0x0068641C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00688248 File Offset: 0x00686448
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmTooltip));
			this.lblTooltipText = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelMain = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnNext = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgClose = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.lblTooltipTitle = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelMain.SuspendLayout();
			base.SuspendLayout();
			this.lblTooltipText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblTooltipText.AutoSize = false;
			this.lblTooltipText.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTooltipText.Font = new global::System.Drawing.Font("Segoe UI", 10.5f);
			this.lblTooltipText.ForeColor = global::System.Drawing.Color.White;
			this.lblTooltipText.Location = new global::System.Drawing.Point(20, 52);
			this.lblTooltipText.Name = "lblTooltipText";
			this.lblTooltipText.Size = new global::System.Drawing.Size(345, 20);
			this.lblTooltipText.TabIndex = 72;
			this.lblTooltipText.Text = "[INFO]";
			this.panelMain.Controls.Add(this.btnNext);
			this.panelMain.Controls.Add(this.imgClose);
			this.panelMain.Controls.Add(this.lblTooltipTitle);
			this.panelMain.Controls.Add(this.lblTooltipText);
			this.panelMain.CustomBorderColor = global::System.Drawing.Color.Gold;
			this.panelMain.CustomBorderThickness = new global::System.Windows.Forms.Padding(1);
			this.panelMain.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new global::System.Drawing.Point(1, 1);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new global::System.Drawing.Size(387, 126);
			this.panelMain.TabIndex = 73;
			this.btnNext.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnNext.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNext.BorderThickness = 1;
			this.btnNext.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnNext.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnNext.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnNext.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNext.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnNext.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnNext.ForeColor = global::System.Drawing.Color.White;
			this.btnNext.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNext.Location = new global::System.Drawing.Point(271, 87);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new global::System.Drawing.Size(104, 25);
			this.btnNext.TabIndex = 75;
			this.btnNext.Text = "Next";
			this.btnNext.Click += new global::System.EventHandler(this.btnNext_Click);
			this.imgClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgClose.CheckedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.imgClose.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.imgClose.HoverState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Image = global::Jack.Properties.Resources.close_16;
			this.imgClose.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgClose.ImageRotate = 0f;
			this.imgClose.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Location = new global::System.Drawing.Point(352, 3);
			this.imgClose.Name = "imgClose";
			this.imgClose.PressedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Size = new global::System.Drawing.Size(32, 32);
			this.imgClose.TabIndex = 74;
			this.imgClose.Click += new global::System.EventHandler(this.imgClose_Click);
			this.lblTooltipTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTooltipTitle.Font = new global::System.Drawing.Font("Segoe UI", 13f);
			this.lblTooltipTitle.ForeColor = global::System.Drawing.Color.White;
			this.lblTooltipTitle.Location = new global::System.Drawing.Point(20, 17);
			this.lblTooltipTitle.Name = "lblTooltipTitle";
			this.lblTooltipTitle.Size = new global::System.Drawing.Size(55, 25);
			this.lblTooltipTitle.TabIndex = 73;
			this.lblTooltipTitle.Text = "<b>[INFO]</b>";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(389, 128);
			base.Controls.Add(this.panelMain);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmTooltip";
			base.Padding = new global::System.Windows.Forms.Padding(1);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmTooltip";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmTooltip_FormClosing);
			base.Load += new global::System.EventHandler(this.frmTutorial_Load);
			this.panelMain.ResumeLayout(false);
			this.panelMain.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040002DC RID: 732
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002DD RID: 733
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblTooltipText;

		// Token: 0x040002DE RID: 734
		private global::Guna.UI2.WinForms.Guna2Panel panelMain;

		// Token: 0x040002DF RID: 735
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblTooltipTitle;

		// Token: 0x040002E0 RID: 736
		private global::Guna.UI2.WinForms.Guna2ImageButton imgClose;

		// Token: 0x040002E1 RID: 737
		private global::Guna.UI2.WinForms.Guna2Button btnNext;
	}
}
