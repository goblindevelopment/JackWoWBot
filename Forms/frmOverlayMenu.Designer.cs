namespace Jack.Forms
{
	// Token: 0x0200005D RID: 93
	public partial class frmOverlayMenu : global::System.Windows.Forms.Form
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x00686094 File Offset: 0x00684294
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x006860C0 File Offset: 0x006842C0
		private void InitializeComponent()
		{
			this.panelMenu = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnMenu = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.panelMenu.SuspendLayout();
			base.SuspendLayout();
			this.panelMenu.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelMenu.Controls.Add(this.btnMenu);
			this.panelMenu.Controls.Add(this.lblTitle);
			this.panelMenu.Location = new global::System.Drawing.Point(12, 12);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new global::System.Drawing.Size(240, 178);
			this.panelMenu.TabIndex = 0;
			this.panelMenu.Visible = false;
			this.btnMenu.BorderColor = global::System.Drawing.Color.Gray;
			this.btnMenu.BorderThickness = 1;
			this.btnMenu.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnMenu.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnMenu.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMenu.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMenu.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnMenu.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnMenu.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMenu.ForeColor = global::System.Drawing.Color.White;
			this.btnMenu.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnMenu.Location = new global::System.Drawing.Point(0, 28);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new global::System.Drawing.Size(240, 30);
			this.btnMenu.TabIndex = 69;
			this.btnMenu.Text = "Menu Item 1";
			this.lblTitle.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.lblTitle.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblTitle.ForeColor = global::System.Drawing.Color.White;
			this.lblTitle.Location = new global::System.Drawing.Point(0, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(240, 28);
			this.lblTitle.TabIndex = 70;
			this.lblTitle.Text = "Header Title";
			this.lblTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(264, 202);
			base.Controls.Add(this.panelMenu);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmOverlayMenu";
			base.Opacity = 0.9;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmOverlayMenu";
			base.TopMost = true;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmOverlayMenu_FormClosing);
			base.Load += new global::System.EventHandler(this.frmOverlayMenu_Load);
			this.panelMenu.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040002BA RID: 698
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002BB RID: 699
		private global::Guna.UI2.WinForms.Guna2Panel panelMenu;

		// Token: 0x040002BC RID: 700
		private global::Guna.UI2.WinForms.Guna2Button btnMenu;

		// Token: 0x040002BD RID: 701
		private global::System.Windows.Forms.Label lblTitle;
	}
}
