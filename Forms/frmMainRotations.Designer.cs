namespace Jack.Forms
{
	// Token: 0x02000093 RID: 147
	public partial class frmMainRotations : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F3B RID: 3899 RVA: 0x006D1C8C File Offset: 0x006CFE8C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x006D1CB8 File Offset: 0x006CFEB8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmMainRotations));
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.selectDisplayMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.btnErase = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnNoProfiles = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnCreateFolder = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtSearch = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.listProfiles = new global::System.Windows.Forms.ListView();
			this.listProfilesName = new global::System.Windows.Forms.ColumnHeader();
			this.listProfilesUpdated = new global::System.Windows.Forms.ColumnHeader();
			this.imageListSmall = new global::System.Windows.Forms.ImageList(this.components);
			this.btnCreateProfile = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnDelete = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRename = new global::Guna.UI2.WinForms.Guna2Button();
			this.toolTips = new global::System.Windows.Forms.ToolTip(this.components);
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			this.panelBox1.SuspendLayout();
			base.SuspendLayout();
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(448, 38);
			this.panelTitle.TabIndex = 68;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(202, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Rotation Manager";
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(378, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.Controls.Add(this.selectDisplayMode);
			this.panelBox1.Controls.Add(this.btnErase);
			this.panelBox1.Controls.Add(this.btnNoProfiles);
			this.panelBox1.Controls.Add(this.btnCreateFolder);
			this.panelBox1.Controls.Add(this.txtSearch);
			this.panelBox1.Controls.Add(this.listProfiles);
			this.panelBox1.Controls.Add(this.btnCreateProfile);
			this.panelBox1.Controls.Add(this.btnDelete);
			this.panelBox1.Controls.Add(this.btnRename);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 22);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(894, 313);
			this.panelBox1.TabIndex = 67;
			this.selectDisplayMode.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectDisplayMode.BackColor = global::System.Drawing.Color.Transparent;
			this.selectDisplayMode.BorderColor = global::System.Drawing.Color.Gray;
			this.selectDisplayMode.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectDisplayMode.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectDisplayMode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectDisplayMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectDisplayMode.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectDisplayMode.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectDisplayMode.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectDisplayMode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectDisplayMode.ForeColor = global::System.Drawing.Color.White;
			this.selectDisplayMode.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectDisplayMode.ItemHeight = 24;
			this.selectDisplayMode.Items.AddRange(new object[]
			{
				"List",
				"Large Icon",
				"Tile",
				"Details"
			});
			this.selectDisplayMode.Location = new global::System.Drawing.Point(486, 17);
			this.selectDisplayMode.Name = "selectDisplayMode";
			this.selectDisplayMode.Size = new global::System.Drawing.Size(140, 30);
			this.selectDisplayMode.TabIndex = 62;
			this.selectDisplayMode.SelectedIndexChanged += new global::System.EventHandler(this.selectDisplayMode_SelectedIndexChanged);
			this.btnErase.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnErase.BorderColor = global::System.Drawing.Color.Gray;
			this.btnErase.BorderThickness = 1;
			this.btnErase.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnErase.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnErase.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnErase.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnErase.DisabledState.Image = global::Jack.Properties.Resources.erase_disabled_32;
			this.btnErase.Enabled = false;
			this.btnErase.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnErase.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnErase.ForeColor = global::System.Drawing.Color.White;
			this.btnErase.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnErase.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnErase.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnErase.Image");
			this.btnErase.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnErase.Location = new global::System.Drawing.Point(838, 17);
			this.btnErase.Name = "btnErase";
			this.btnErase.Size = new global::System.Drawing.Size(40, 30);
			this.btnErase.TabIndex = 64;
			this.btnErase.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnErase.Click += new global::System.EventHandler(this.btnErase_Click);
			this.btnNoProfiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnNoProfiles.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNoProfiles.BorderThickness = 1;
			this.btnNoProfiles.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnNoProfiles.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNoProfiles.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnNoProfiles.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnNoProfiles.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNoProfiles.DisabledState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image");
			this.btnNoProfiles.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnNoProfiles.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnNoProfiles.ForeColor = global::System.Drawing.Color.White;
			this.btnNoProfiles.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNoProfiles.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnNoProfiles.Image = global::Jack.Properties.Resources.create_rotation_48;
			this.btnNoProfiles.ImageSize = new global::System.Drawing.Size(40, 40);
			this.btnNoProfiles.Location = new global::System.Drawing.Point(14, 206);
			this.btnNoProfiles.Name = "btnNoProfiles";
			this.btnNoProfiles.Size = new global::System.Drawing.Size(33, 53);
			this.btnNoProfiles.TabIndex = 61;
			this.btnNoProfiles.Text = " Create a new Rotation...";
			this.btnNoProfiles.Visible = false;
			this.btnNoProfiles.Click += new global::System.EventHandler(this.btnNoProfiles_Click);
			this.btnCreateFolder.BorderColor = global::System.Drawing.Color.Gray;
			this.btnCreateFolder.BorderThickness = 1;
			this.btnCreateFolder.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnCreateFolder.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnCreateFolder.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnCreateFolder.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnCreateFolder.DisabledState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image1");
			this.btnCreateFolder.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnCreateFolder.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnCreateFolder.ForeColor = global::System.Drawing.Color.White;
			this.btnCreateFolder.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnCreateFolder.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnCreateFolder.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnCreateFolder.Image");
			this.btnCreateFolder.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnCreateFolder.Location = new global::System.Drawing.Point(14, 89);
			this.btnCreateFolder.Name = "btnCreateFolder";
			this.btnCreateFolder.Size = new global::System.Drawing.Size(40, 30);
			this.btnCreateFolder.TabIndex = 56;
			this.btnCreateFolder.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.toolTips.SetToolTip(this.btnCreateFolder, "Create new Folder");
			this.btnCreateFolder.Click += new global::System.EventHandler(this.btnCreateFolder_Click);
			this.txtSearch.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtSearch.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSearch.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSearch.DefaultText = "";
			this.txtSearch.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSearch.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSearch.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSearch.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSearch.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSearch.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSearch.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSearch.ForeColor = global::System.Drawing.Color.White;
			this.txtSearch.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSearch.Location = new global::System.Drawing.Point(632, 17);
			this.txtSearch.MaxLength = 100;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PasswordChar = '\0';
			this.txtSearch.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSearch.PlaceholderText = "Search...";
			this.txtSearch.SelectedText = "";
			this.txtSearch.Size = new global::System.Drawing.Size(200, 30);
			this.txtSearch.TabIndex = 63;
			this.txtSearch.TextChanged += new global::System.EventHandler(this.txtSearch_TextChanged);
			this.listProfiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listProfiles.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listProfiles.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listProfilesName,
				this.listProfilesUpdated
			});
			this.listProfiles.ForeColor = global::System.Drawing.Color.White;
			this.listProfiles.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.None;
			this.listProfiles.HideSelection = false;
			this.listProfiles.LabelEdit = true;
			this.listProfiles.LargeImageList = this.imageListSmall;
			this.listProfiles.Location = new global::System.Drawing.Point(60, 53);
			this.listProfiles.Name = "listProfiles";
			this.listProfiles.Size = new global::System.Drawing.Size(818, 244);
			this.listProfiles.SmallImageList = this.imageListSmall;
			this.listProfiles.TabIndex = 57;
			this.listProfiles.UseCompatibleStateImageBehavior = false;
			this.listProfiles.View = global::System.Windows.Forms.View.List;
			this.listProfiles.AfterLabelEdit += new global::System.Windows.Forms.LabelEditEventHandler(this.listProfiles_AfterLabelEdit);
			this.listProfiles.SelectedIndexChanged += new global::System.EventHandler(this.listProfiles_SelectedIndexChanged);
			this.listProfiles.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listProfiles_KeyDown);
			this.listProfiles.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listProfiles_MouseDoubleClick);
			this.listProfiles.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.listProfiles_MouseDown);
			this.listProfiles.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.listProfiles_MouseMove);
			this.listProfiles.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listProfiles_MouseUp);
			this.listProfilesName.Text = "";
			this.listProfilesName.Width = 0;
			this.listProfilesUpdated.Text = "Updated";
			this.listProfilesUpdated.Width = 0;
			this.imageListSmall.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageListSmall.ImageStream");
			this.imageListSmall.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageListSmall.Images.SetKeyName(0, "folder_32.png");
			this.imageListSmall.Images.SetKeyName(1, "rotation_32.png");
			this.btnCreateProfile.BorderColor = global::System.Drawing.Color.Gray;
			this.btnCreateProfile.BorderThickness = 1;
			this.btnCreateProfile.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnCreateProfile.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnCreateProfile.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnCreateProfile.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnCreateProfile.DisabledState.Image = global::Jack.Properties.Resources.create_rotation_disable_32;
			this.btnCreateProfile.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnCreateProfile.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnCreateProfile.ForeColor = global::System.Drawing.Color.White;
			this.btnCreateProfile.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnCreateProfile.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnCreateProfile.Image = global::Jack.Properties.Resources.create_rotation_32;
			this.btnCreateProfile.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnCreateProfile.Location = new global::System.Drawing.Point(14, 53);
			this.btnCreateProfile.Name = "btnCreateProfile";
			this.btnCreateProfile.Size = new global::System.Drawing.Size(40, 30);
			this.btnCreateProfile.TabIndex = 58;
			this.btnCreateProfile.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.toolTips.SetToolTip(this.btnCreateProfile, "Create new Rotation");
			this.btnCreateProfile.Click += new global::System.EventHandler(this.btnCreateProfile_Click);
			this.btnDelete.BorderColor = global::System.Drawing.Color.Gray;
			this.btnDelete.BorderThickness = 1;
			this.btnDelete.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnDelete.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnDelete.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnDelete.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnDelete.DisabledState.Image = global::Jack.Properties.Resources.delete_disabled_32;
			this.btnDelete.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnDelete.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = global::System.Drawing.Color.White;
			this.btnDelete.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnDelete.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnDelete.Image = global::Jack.Properties.Resources.delete_32;
			this.btnDelete.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDelete.Location = new global::System.Drawing.Point(14, 161);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(40, 30);
			this.btnDelete.TabIndex = 59;
			this.btnDelete.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.toolTips.SetToolTip(this.btnDelete, "Delete");
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.btnRename.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRename.BorderThickness = 1;
			this.btnRename.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRename.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnRename.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnRename.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRename.DisabledState.Image = global::Jack.Properties.Resources.rename_disabled_32;
			this.btnRename.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnRename.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnRename.ForeColor = global::System.Drawing.Color.White;
			this.btnRename.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRename.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnRename.Image = global::Jack.Properties.Resources.rename_32;
			this.btnRename.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnRename.Location = new global::System.Drawing.Point(14, 125);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new global::System.Drawing.Size(40, 30);
			this.btnRename.TabIndex = 60;
			this.btnRename.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.toolTips.SetToolTip(this.btnRename, "Rename");
			this.btnRename.Click += new global::System.EventHandler(this.btnRename_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 335);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainRotations";
			this.Text = "frmMainRotations";
			base.Load += new global::System.EventHandler(this.frmMainRotations_Load);
			base.Shown += new global::System.EventHandler(this.frmMainRotations_Shown);
			base.SizeChanged += new global::System.EventHandler(this.frmMainRotations_SizeChanged);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainRotations_VisibleChanged);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			this.panelBox1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400068A RID: 1674
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400068B RID: 1675
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x0400068C RID: 1676
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x0400068D RID: 1677
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x0400068E RID: 1678
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400068F RID: 1679
		private global::Guna.UI2.WinForms.Guna2ComboBox selectDisplayMode;

		// Token: 0x04000690 RID: 1680
		private global::Guna.UI2.WinForms.Guna2Button btnErase;

		// Token: 0x04000691 RID: 1681
		private global::Guna.UI2.WinForms.Guna2Button btnNoProfiles;

		// Token: 0x04000692 RID: 1682
		private global::Guna.UI2.WinForms.Guna2Button btnCreateFolder;

		// Token: 0x04000693 RID: 1683
		private global::Guna.UI2.WinForms.Guna2TextBox txtSearch;

		// Token: 0x04000694 RID: 1684
		private global::System.Windows.Forms.ListView listProfiles;

		// Token: 0x04000695 RID: 1685
		private global::System.Windows.Forms.ColumnHeader listProfilesName;

		// Token: 0x04000696 RID: 1686
		private global::System.Windows.Forms.ColumnHeader listProfilesUpdated;

		// Token: 0x04000697 RID: 1687
		private global::Guna.UI2.WinForms.Guna2Button btnCreateProfile;

		// Token: 0x04000698 RID: 1688
		private global::Guna.UI2.WinForms.Guna2Button btnDelete;

		// Token: 0x04000699 RID: 1689
		private global::Guna.UI2.WinForms.Guna2Button btnRename;

		// Token: 0x0400069A RID: 1690
		private global::System.Windows.Forms.ImageList imageListSmall;

		// Token: 0x0400069B RID: 1691
		private global::System.Windows.Forms.ToolTip toolTips;
	}
}
