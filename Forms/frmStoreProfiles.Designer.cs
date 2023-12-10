namespace Jack.Forms
{
	// Token: 0x0200007E RID: 126
	public partial class frmStoreProfiles : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BAC RID: 2988 RVA: 0x0069E23C File Offset: 0x0069C43C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0069E268 File Offset: 0x0069C468
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmStoreProfiles));
			this.panelProfiles = new global::System.Windows.Forms.FlowLayoutPanel();
			this.panelProfile = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelProfileIcons = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelProfileFactions = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgFactionAlliance = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgFactionHorde = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblProfilePrice = new global::System.Windows.Forms.Label();
			this.imgProfileType = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.sepProfile1 = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.sepProfile2 = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.panelAlreadyPurchased = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblAlreadyPurchased = new global::System.Windows.Forms.Label();
			this.imgProfileLoading = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.lblProfileType = new global::System.Windows.Forms.Label();
			this.lblProfileTitle = new global::System.Windows.Forms.Label();
			this.imgProfile = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.progressLoading = new global::Guna.UI2.WinForms.Guna2CircleProgressBar();
			this.lblInfo = new global::System.Windows.Forms.Label();
			this.panelProfiles.SuspendLayout();
			this.panelProfile.SuspendLayout();
			this.panelProfileIcons.SuspendLayout();
			this.panelProfileFactions.SuspendLayout();
			this.imgFactionAlliance.BeginInit();
			this.imgFactionHorde.BeginInit();
			this.imgProfileType.BeginInit();
			this.panelAlreadyPurchased.SuspendLayout();
			this.imgProfile.BeginInit();
			base.SuspendLayout();
			this.panelProfiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelProfiles.AutoScroll = true;
			this.panelProfiles.AutoScrollMargin = new global::System.Drawing.Size(0, 8);
			this.panelProfiles.Controls.Add(this.panelProfile);
			this.panelProfiles.Location = new global::System.Drawing.Point(8, 0);
			this.panelProfiles.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelProfiles.Name = "panelProfiles";
			this.panelProfiles.Size = new global::System.Drawing.Size(773, 502);
			this.panelProfiles.TabIndex = 4;
			this.panelProfiles.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.panelProfiles_Scroll);
			this.panelProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.panelProfile.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.panelProfile.BorderRadius = 4;
			this.panelProfile.BorderThickness = 1;
			this.panelProfile.Controls.Add(this.panelProfileIcons);
			this.panelProfile.Controls.Add(this.panelAlreadyPurchased);
			this.panelProfile.Controls.Add(this.imgProfileLoading);
			this.panelProfile.Controls.Add(this.lblProfileType);
			this.panelProfile.Controls.Add(this.lblProfileTitle);
			this.panelProfile.Controls.Add(this.imgProfile);
			this.panelProfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.panelProfile.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelProfile.Location = new global::System.Drawing.Point(8, 8);
			this.panelProfile.Margin = new global::System.Windows.Forms.Padding(8);
			this.panelProfile.Name = "panelProfile";
			this.panelProfile.ShadowDecoration.BorderRadius = 4;
			this.panelProfile.ShadowDecoration.Color = global::System.Drawing.Color.White;
			this.panelProfile.ShadowDecoration.Depth = 5;
			this.panelProfile.ShadowDecoration.Enabled = true;
			this.panelProfile.Size = new global::System.Drawing.Size(370, 140);
			this.panelProfile.TabIndex = 0;
			this.panelProfile.Visible = false;
			this.panelProfileIcons.Controls.Add(this.panelProfileFactions);
			this.panelProfileIcons.Controls.Add(this.lblProfilePrice);
			this.panelProfileIcons.Controls.Add(this.imgProfileType);
			this.panelProfileIcons.Controls.Add(this.sepProfile1);
			this.panelProfileIcons.Controls.Add(this.sepProfile2);
			this.panelProfileIcons.Location = new global::System.Drawing.Point(115, 101);
			this.panelProfileIcons.Name = "panelProfileIcons";
			this.panelProfileIcons.Size = new global::System.Drawing.Size(255, 25);
			this.panelProfileIcons.TabIndex = 20;
			this.panelProfileFactions.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panelProfileFactions.Controls.Add(this.imgFactionAlliance);
			this.panelProfileFactions.Controls.Add(this.imgFactionHorde);
			this.panelProfileFactions.Location = new global::System.Drawing.Point(0, 3);
			this.panelProfileFactions.Name = "panelProfileFactions";
			this.panelProfileFactions.Size = new global::System.Drawing.Size(40, 20);
			this.panelProfileFactions.TabIndex = 15;
			this.imgFactionAlliance.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.imgFactionAlliance.FillColor = global::System.Drawing.Color.Transparent;
			this.imgFactionAlliance.Image = global::Jack.Properties.Resources.store_faction_alliance_20;
			this.imgFactionAlliance.ImageRotate = 0f;
			this.imgFactionAlliance.Location = new global::System.Drawing.Point(20, 0);
			this.imgFactionAlliance.Name = "imgFactionAlliance";
			this.imgFactionAlliance.Size = new global::System.Drawing.Size(20, 20);
			this.imgFactionAlliance.TabIndex = 14;
			this.imgFactionAlliance.TabStop = false;
			this.imgFactionHorde.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.imgFactionHorde.FillColor = global::System.Drawing.Color.Transparent;
			this.imgFactionHorde.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("imgFactionHorde.Image");
			this.imgFactionHorde.ImageRotate = 0f;
			this.imgFactionHorde.Location = new global::System.Drawing.Point(0, 0);
			this.imgFactionHorde.Name = "imgFactionHorde";
			this.imgFactionHorde.Size = new global::System.Drawing.Size(20, 20);
			this.imgFactionHorde.TabIndex = 13;
			this.imgFactionHorde.TabStop = false;
			this.lblProfilePrice.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblProfilePrice.AutoSize = true;
			this.lblProfilePrice.BackColor = global::System.Drawing.Color.Transparent;
			this.lblProfilePrice.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblProfilePrice.ForeColor = global::System.Drawing.Color.White;
			this.lblProfilePrice.Location = new global::System.Drawing.Point(189, 5);
			this.lblProfilePrice.Name = "lblProfilePrice";
			this.lblProfilePrice.Size = new global::System.Drawing.Size(52, 15);
			this.lblProfilePrice.TabIndex = 19;
			this.lblProfilePrice.Text = "9.999 BC";
			this.lblProfilePrice.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.imgProfileType.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.imgProfileType.FillColor = global::System.Drawing.Color.Transparent;
			this.imgProfileType.Image = global::Jack.Properties.Resources.store_profile_type_wotlk_som;
			this.imgProfileType.ImageRotate = 0f;
			this.imgProfileType.Location = new global::System.Drawing.Point(61, 3);
			this.imgProfileType.Name = "imgProfileType";
			this.imgProfileType.Size = new global::System.Drawing.Size(107, 20);
			this.imgProfileType.TabIndex = 16;
			this.imgProfileType.TabStop = false;
			this.sepProfile1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.sepProfile1.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.sepProfile1.Location = new global::System.Drawing.Point(44, 0);
			this.sepProfile1.Name = "sepProfile1";
			this.sepProfile1.Size = new global::System.Drawing.Size(10, 25);
			this.sepProfile1.TabIndex = 17;
			this.sepProfile2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.sepProfile2.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.sepProfile2.Location = new global::System.Drawing.Point(176, 0);
			this.sepProfile2.Name = "sepProfile2";
			this.sepProfile2.Size = new global::System.Drawing.Size(10, 25);
			this.sepProfile2.TabIndex = 18;
			this.panelAlreadyPurchased.Controls.Add(this.lblAlreadyPurchased);
			this.panelAlreadyPurchased.FillColor = global::System.Drawing.Color.Orange;
			this.panelAlreadyPurchased.Location = new global::System.Drawing.Point(12, 94);
			this.panelAlreadyPurchased.Name = "panelAlreadyPurchased";
			this.panelAlreadyPurchased.Size = new global::System.Drawing.Size(94, 20);
			this.panelAlreadyPurchased.TabIndex = 1;
			this.panelAlreadyPurchased.Visible = false;
			this.lblAlreadyPurchased.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAlreadyPurchased.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblAlreadyPurchased.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblAlreadyPurchased.ForeColor = global::System.Drawing.Color.Black;
			this.lblAlreadyPurchased.Location = new global::System.Drawing.Point(0, 0);
			this.lblAlreadyPurchased.Name = "lblAlreadyPurchased";
			this.lblAlreadyPurchased.Padding = new global::System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblAlreadyPurchased.Size = new global::System.Drawing.Size(94, 20);
			this.lblAlreadyPurchased.TabIndex = 21;
			this.lblAlreadyPurchased.Text = "Owned";
			this.lblAlreadyPurchased.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.imgProfileLoading.AnimatedGIF = true;
			this.imgProfileLoading.CheckedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgProfileLoading.HoverState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgProfileLoading.Image = global::Jack.Properties.Resources.loading_32;
			this.imgProfileLoading.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgProfileLoading.ImageRotate = 0f;
			this.imgProfileLoading.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgProfileLoading.Location = new global::System.Drawing.Point(45, 54);
			this.imgProfileLoading.Name = "imgProfileLoading";
			this.imgProfileLoading.PressedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgProfileLoading.Size = new global::System.Drawing.Size(32, 32);
			this.imgProfileLoading.TabIndex = 1;
			this.lblProfileType.AutoEllipsis = true;
			this.lblProfileType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblProfileType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblProfileType.ForeColor = global::System.Drawing.Color.White;
			this.lblProfileType.Location = new global::System.Drawing.Point(116, 62);
			this.lblProfileType.Name = "lblProfileType";
			this.lblProfileType.Size = new global::System.Drawing.Size(240, 17);
			this.lblProfileType.TabIndex = 12;
			this.lblProfileType.Text = "Profile Type";
			this.lblProfileType.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblProfileTitle.AutoEllipsis = true;
			this.lblProfileTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblProfileTitle.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.lblProfileTitle.ForeColor = global::System.Drawing.Color.White;
			this.lblProfileTitle.Location = new global::System.Drawing.Point(116, 16);
			this.lblProfileTitle.Name = "lblProfileTitle";
			this.lblProfileTitle.Size = new global::System.Drawing.Size(240, 35);
			this.lblProfileTitle.TabIndex = 11;
			this.lblProfileTitle.Text = "Profile Title ProfileProfile Title ProfileProfile Title ProfileProfile Title ProfileProfile Title ProfileProfile Title ProfileProfile Title Profile";
			this.imgProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.imgProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.imgProfile.BorderRadius = 4;
			this.imgProfile.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.imgProfile.ImageRotate = 0f;
			this.imgProfile.Location = new global::System.Drawing.Point(12, 12);
			this.imgProfile.Name = "imgProfile";
			this.imgProfile.Size = new global::System.Drawing.Size(94, 115);
			this.imgProfile.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgProfile.TabIndex = 0;
			this.imgProfile.TabStop = false;
			this.progressLoading.Animated = true;
			this.progressLoading.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.progressLoading.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.progressLoading.FillThickness = 3;
			this.progressLoading.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.progressLoading.ForeColor = global::System.Drawing.Color.White;
			this.progressLoading.Location = new global::System.Drawing.Point(389, 250);
			this.progressLoading.Minimum = 0;
			this.progressLoading.Name = "progressLoading";
			this.progressLoading.ProgressColor = global::System.Drawing.Color.DeepSkyBlue;
			this.progressLoading.ProgressColor2 = global::System.Drawing.Color.DeepSkyBlue;
			this.progressLoading.ProgressThickness = 3;
			this.progressLoading.ShadowDecoration.Mode = 1;
			this.progressLoading.Size = new global::System.Drawing.Size(20, 20);
			this.progressLoading.TabIndex = 114;
			this.progressLoading.Value = 75;
			this.progressLoading.Visible = false;
			this.lblInfo.AutoSize = true;
			this.lblInfo.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblInfo.Location = new global::System.Drawing.Point(321, 281);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new global::System.Drawing.Size(159, 38);
			this.lblInfo.TabIndex = 1;
			this.lblInfo.Text = "Temporary maintenance.\r\nSoon available again.";
			this.lblInfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblInfo.Visible = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(789, 510);
			base.Controls.Add(this.lblInfo);
			base.Controls.Add(this.progressLoading);
			base.Controls.Add(this.panelProfiles);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmStoreProfiles";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmStoreProfiles";
			base.Load += new global::System.EventHandler(this.frmStoreProfiles_Load);
			base.SizeChanged += new global::System.EventHandler(this.frmStoreProfiles_SizeChanged);
			base.Resize += new global::System.EventHandler(this.frmStoreProfiles_Resize);
			this.panelProfiles.ResumeLayout(false);
			this.panelProfile.ResumeLayout(false);
			this.panelProfileIcons.ResumeLayout(false);
			this.panelProfileIcons.PerformLayout();
			this.panelProfileFactions.ResumeLayout(false);
			this.imgFactionAlliance.EndInit();
			this.imgFactionHorde.EndInit();
			this.imgProfileType.EndInit();
			this.panelAlreadyPurchased.ResumeLayout(false);
			this.imgProfile.EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000408 RID: 1032
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000409 RID: 1033
		private global::System.Windows.Forms.FlowLayoutPanel panelProfiles;

		// Token: 0x0400040A RID: 1034
		private global::Guna.UI2.WinForms.Guna2Panel panelProfile;

		// Token: 0x0400040B RID: 1035
		private global::System.Windows.Forms.Label lblProfileTitle;

		// Token: 0x0400040C RID: 1036
		private global::Guna.UI2.WinForms.Guna2PictureBox imgProfile;

		// Token: 0x0400040D RID: 1037
		private global::System.Windows.Forms.Label lblProfileType;

		// Token: 0x0400040E RID: 1038
		private global::Guna.UI2.WinForms.Guna2PictureBox imgFactionHorde;

		// Token: 0x0400040F RID: 1039
		private global::Guna.UI2.WinForms.Guna2PictureBox imgFactionAlliance;

		// Token: 0x04000410 RID: 1040
		private global::Guna.UI2.WinForms.Guna2Panel panelProfileFactions;

		// Token: 0x04000411 RID: 1041
		private global::Guna.UI2.WinForms.Guna2PictureBox imgProfileType;

		// Token: 0x04000412 RID: 1042
		private global::Guna.UI2.WinForms.Guna2VSeparator sepProfile1;

		// Token: 0x04000413 RID: 1043
		private global::System.Windows.Forms.Label lblProfilePrice;

		// Token: 0x04000414 RID: 1044
		private global::Guna.UI2.WinForms.Guna2VSeparator sepProfile2;

		// Token: 0x04000415 RID: 1045
		private global::Guna.UI2.WinForms.Guna2CircleProgressBar progressLoading;

		// Token: 0x04000416 RID: 1046
		private global::Guna.UI2.WinForms.Guna2ImageButton imgProfileLoading;

		// Token: 0x04000417 RID: 1047
		private global::Guna.UI2.WinForms.Guna2Panel panelProfileIcons;

		// Token: 0x04000418 RID: 1048
		private global::System.Windows.Forms.Label lblInfo;

		// Token: 0x04000419 RID: 1049
		private global::Guna.UI2.WinForms.Guna2Panel panelAlreadyPurchased;

		// Token: 0x0400041A RID: 1050
		private global::System.Windows.Forms.Label lblAlreadyPurchased;
	}
}
