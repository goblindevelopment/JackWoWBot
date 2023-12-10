namespace Jack.Forms
{
	// Token: 0x02000075 RID: 117
	public partial class frmStoreDashboard : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x00695A58 File Offset: 0x00693C58
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00695A84 File Offset: 0x00693C84
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmStoreDashboard));
			this.panelDashboard = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgJackPackLoading = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.panelContent = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpProfiles = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.panelProfiles = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelProfile = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblDisplayName = new global::System.Windows.Forms.Label();
			this.imgGames = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelFactions = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgFactionHorde = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgFactionAlliance = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.imgJackPack = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelDashboard.SuspendLayout();
			this.panelContent.SuspendLayout();
			this.grpProfiles.SuspendLayout();
			this.panelProfiles.SuspendLayout();
			this.panelProfile.SuspendLayout();
			this.imgGames.BeginInit();
			this.panelFactions.SuspendLayout();
			this.imgFactionHorde.BeginInit();
			this.imgFactionAlliance.BeginInit();
			this.imgJackPack.BeginInit();
			base.SuspendLayout();
			this.panelDashboard.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelDashboard.AutoScroll = true;
			this.panelDashboard.AutoScrollMargin = new global::System.Drawing.Size(0, 8);
			this.panelDashboard.Controls.Add(this.imgJackPackLoading);
			this.panelDashboard.Controls.Add(this.panelContent);
			this.panelDashboard.Controls.Add(this.imgJackPack);
			this.panelDashboard.Location = new global::System.Drawing.Point(8, 0);
			this.panelDashboard.Name = "panelDashboard";
			this.panelDashboard.Size = new global::System.Drawing.Size(773, 617);
			this.panelDashboard.TabIndex = 0;
			this.imgJackPackLoading.AnimatedGIF = true;
			this.imgJackPackLoading.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.imgJackPackLoading.CheckedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgJackPackLoading.HoverState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgJackPackLoading.Image = global::Jack.Properties.Resources.loading_32;
			this.imgJackPackLoading.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgJackPackLoading.ImageRotate = 0f;
			this.imgJackPackLoading.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgJackPackLoading.Location = new global::System.Drawing.Point(371, 68);
			this.imgJackPackLoading.Name = "imgJackPackLoading";
			this.imgJackPackLoading.PressedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgJackPackLoading.Size = new global::System.Drawing.Size(32, 32);
			this.imgJackPackLoading.TabIndex = 14;
			this.panelContent.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelContent.BorderThickness = 1;
			this.panelContent.Controls.Add(this.grpProfiles);
			this.panelContent.Location = new global::System.Drawing.Point(8, 173);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new global::System.Drawing.Size(757, 331);
			this.panelContent.TabIndex = 13;
			this.grpProfiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpProfiles.BackColor = global::System.Drawing.Color.Transparent;
			this.grpProfiles.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpProfiles.BorderRadius = 4;
			this.grpProfiles.Controls.Add(this.panelProfiles);
			this.grpProfiles.Controls.Add(this.lblTitle);
			this.grpProfiles.CustomBorderColor = global::System.Drawing.Color.SteelBlue;
			this.grpProfiles.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpProfiles.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpProfiles.ForeColor = global::System.Drawing.Color.White;
			this.grpProfiles.Location = new global::System.Drawing.Point(0, 0);
			this.grpProfiles.Name = "grpProfiles";
			this.grpProfiles.Size = new global::System.Drawing.Size(757, 315);
			this.grpProfiles.TabIndex = 12;
			this.grpProfiles.Visible = false;
			this.panelProfiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelProfiles.BorderThickness = 1;
			this.panelProfiles.Controls.Add(this.panelProfile);
			this.panelProfiles.Location = new global::System.Drawing.Point(0, 40);
			this.panelProfiles.Name = "panelProfiles";
			this.panelProfiles.Size = new global::System.Drawing.Size(757, 275);
			this.panelProfiles.TabIndex = 18;
			this.panelProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelProfile.Controls.Add(this.lblDisplayName);
			this.panelProfile.Controls.Add(this.imgGames);
			this.panelProfile.Controls.Add(this.panelFactions);
			this.panelProfile.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.panelProfile.Location = new global::System.Drawing.Point(0, 0);
			this.panelProfile.Name = "panelProfile";
			this.panelProfile.Size = new global::System.Drawing.Size(757, 55);
			this.panelProfile.TabIndex = 17;
			this.lblDisplayName.AutoEllipsis = true;
			this.lblDisplayName.Font = new global::System.Drawing.Font("Segoe UI", 9.5f);
			this.lblDisplayName.Location = new global::System.Drawing.Point(72, 18);
			this.lblDisplayName.Name = "lblDisplayName";
			this.lblDisplayName.Size = new global::System.Drawing.Size(530, 19);
			this.lblDisplayName.TabIndex = 18;
			this.lblDisplayName.Text = "[DISPLAY_NAME]";
			this.lblDisplayName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.imgGames.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgGames.FillColor = global::System.Drawing.Color.Transparent;
			this.imgGames.Image = global::Jack.Properties.Resources.store_profile_type_wotlk_som;
			this.imgGames.ImageRotate = 0f;
			this.imgGames.Location = new global::System.Drawing.Point(628, 18);
			this.imgGames.Name = "imgGames";
			this.imgGames.Size = new global::System.Drawing.Size(107, 20);
			this.imgGames.TabIndex = 19;
			this.imgGames.TabStop = false;
			this.panelFactions.Controls.Add(this.imgFactionHorde);
			this.panelFactions.Controls.Add(this.imgFactionAlliance);
			this.panelFactions.Location = new global::System.Drawing.Point(14, 18);
			this.panelFactions.Name = "panelFactions";
			this.panelFactions.Size = new global::System.Drawing.Size(40, 20);
			this.panelFactions.TabIndex = 18;
			this.imgFactionHorde.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.imgFactionHorde.FillColor = global::System.Drawing.Color.Transparent;
			this.imgFactionHorde.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("imgFactionHorde.Image");
			this.imgFactionHorde.ImageRotate = 0f;
			this.imgFactionHorde.Location = new global::System.Drawing.Point(0, 0);
			this.imgFactionHorde.Name = "imgFactionHorde";
			this.imgFactionHorde.Size = new global::System.Drawing.Size(20, 20);
			this.imgFactionHorde.TabIndex = 13;
			this.imgFactionHorde.TabStop = false;
			this.imgFactionAlliance.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.imgFactionAlliance.FillColor = global::System.Drawing.Color.Transparent;
			this.imgFactionAlliance.Image = global::Jack.Properties.Resources.store_faction_alliance_20;
			this.imgFactionAlliance.ImageRotate = 0f;
			this.imgFactionAlliance.Location = new global::System.Drawing.Point(20, 0);
			this.imgFactionAlliance.Name = "imgFactionAlliance";
			this.imgFactionAlliance.Size = new global::System.Drawing.Size(20, 20);
			this.imgFactionAlliance.TabIndex = 14;
			this.imgFactionAlliance.TabStop = false;
			this.lblTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTitle.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblTitle.ForeColor = global::System.Drawing.Color.White;
			this.lblTitle.Location = new global::System.Drawing.Point(11, 10);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(174, 19);
			this.lblTitle.TabIndex = 16;
			this.lblTitle.Text = "Popular <b>Goldmaking</b> Profiles";
			this.imgJackPack.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgJackPack.BackColor = global::System.Drawing.Color.Transparent;
			this.imgJackPack.BorderRadius = 4;
			this.imgJackPack.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.imgJackPack.FillColor = global::System.Drawing.Color.Transparent;
			this.imgJackPack.ImageRotate = 0f;
			this.imgJackPack.Location = new global::System.Drawing.Point(8, 8);
			this.imgJackPack.Name = "imgJackPack";
			this.imgJackPack.Size = new global::System.Drawing.Size(757, 150);
			this.imgJackPack.TabIndex = 5;
			this.imgJackPack.TabStop = false;
			this.imgJackPack.Click += new global::System.EventHandler(this.imgJackPack_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(789, 625);
			base.Controls.Add(this.panelDashboard);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmStoreDashboard";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmStoreDashboard";
			base.Load += new global::System.EventHandler(this.frmStoreDashboard_Load);
			base.SizeChanged += new global::System.EventHandler(this.frmStoreDashboard_SizeChanged);
			base.Resize += new global::System.EventHandler(this.frmStoreDashboard_Resize);
			this.panelDashboard.ResumeLayout(false);
			this.panelContent.ResumeLayout(false);
			this.grpProfiles.ResumeLayout(false);
			this.grpProfiles.PerformLayout();
			this.panelProfiles.ResumeLayout(false);
			this.panelProfile.ResumeLayout(false);
			this.imgGames.EndInit();
			this.panelFactions.ResumeLayout(false);
			this.imgFactionHorde.EndInit();
			this.imgFactionAlliance.EndInit();
			this.imgJackPack.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000387 RID: 903
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000388 RID: 904
		private global::Guna.UI2.WinForms.Guna2Panel panelDashboard;

		// Token: 0x04000389 RID: 905
		private global::Guna.UI2.WinForms.Guna2PictureBox imgJackPack;

		// Token: 0x0400038A RID: 906
		private global::Guna.UI2.WinForms.Guna2GroupBox grpProfiles;

		// Token: 0x0400038B RID: 907
		private global::Guna.UI2.WinForms.Guna2Panel panelContent;

		// Token: 0x0400038C RID: 908
		private global::Guna.UI2.WinForms.Guna2Panel panelProfile;

		// Token: 0x0400038D RID: 909
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;

		// Token: 0x0400038E RID: 910
		private global::Guna.UI2.WinForms.Guna2Panel panelFactions;

		// Token: 0x0400038F RID: 911
		private global::Guna.UI2.WinForms.Guna2PictureBox imgFactionAlliance;

		// Token: 0x04000390 RID: 912
		private global::Guna.UI2.WinForms.Guna2PictureBox imgFactionHorde;

		// Token: 0x04000391 RID: 913
		private global::Guna.UI2.WinForms.Guna2PictureBox imgGames;

		// Token: 0x04000392 RID: 914
		private global::System.Windows.Forms.Label lblDisplayName;

		// Token: 0x04000393 RID: 915
		private global::Guna.UI2.WinForms.Guna2Panel panelProfiles;

		// Token: 0x04000394 RID: 916
		private global::Guna.UI2.WinForms.Guna2ImageButton imgJackPackLoading;
	}
}
