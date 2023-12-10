namespace Jack.Forms
{
	// Token: 0x0200008F RID: 143
	public partial class frmMainAddon : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E5A RID: 3674 RVA: 0x006C7980 File Offset: 0x006C5B80
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x006C79AC File Offset: 0x006C5BAC
		private void InitializeComponent()
		{
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnAddonTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabAddon = new global::System.Windows.Forms.TabPage();
			this.panelTabAddon = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpAddonName = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnAddonName = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtAddonName = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblAddonName = new global::System.Windows.Forms.Label();
			this.grpAddonInstallation = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnAddonInstallationInstall = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtAddonInstallationFolder = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblAddonInstallationFolder = new global::System.Windows.Forms.Label();
			this.tabOptions = new global::System.Windows.Forms.TabPage();
			this.panelTabOptions = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpAddonSettings = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkAddonSettingsAutoCheckOnStart = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpAddonOptionsAutoEquip = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkAddonOptionsAutoEquipBags = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.btnAddonOptionsApply1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkAddonOptionsAutoEquipPurple = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddonOptionsAutoEquipBlue = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddonOptionsAutoEquipGreen = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddonOptionsAutoEquipWhite = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpAddonOptionsAutoDestroy = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnAddonOptionsApply2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnAddonOptionsAutoDestroyJunklist = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkAddonOptionsAutoDestroyBOE = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddonOptionsAutoDestroyGrey = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddonOptionsAutoDestroyBlue = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddonOptionsAutoDestroyGreen = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddonOptionsAutoDestroyWhite = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.panelBox1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			this.tabs.SuspendLayout();
			this.tabAddon.SuspendLayout();
			this.panelTabAddon.SuspendLayout();
			this.grpAddonName.SuspendLayout();
			this.grpAddonInstallation.SuspendLayout();
			this.tabOptions.SuspendLayout();
			this.panelTabOptions.SuspendLayout();
			this.grpAddonSettings.SuspendLayout();
			this.grpAddonOptionsAutoEquip.SuspendLayout();
			this.grpAddonOptionsAutoDestroy.SuspendLayout();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.btnAddonTooltip);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.Controls.Add(this.tabs);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 22);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(894, 607);
			this.panelBox1.TabIndex = 67;
			this.btnAddonTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAddonTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnAddonTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnAddonTooltip.BorderRadius = 4;
			this.btnAddonTooltip.BorderThickness = 1;
			this.btnAddonTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnAddonTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnAddonTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnAddonTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAddonTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAddonTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddonTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnAddonTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnAddonTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnAddonTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnAddonTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnAddonTooltip.Location = new global::System.Drawing.Point(839, 13);
			this.btnAddonTooltip.Name = "btnAddonTooltip";
			this.btnAddonTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnAddonTooltip.TabIndex = 74;
			this.btnAddonTooltip.Click += new global::System.EventHandler(this.btnAddonTooltip_Click);
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(448, 38);
			this.panelTitle.TabIndex = 66;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(378, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(72, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Addon";
			this.tabs.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabAddon);
			this.tabs.Controls.Add(this.tabOptions);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(180, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(868, 538);
			this.tabs.TabButtonHoverState.BorderColor = global::System.Drawing.Color.Empty;
			this.tabs.TabButtonHoverState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabs.TabButtonHoverState.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.TabButtonHoverState.ForeColor = global::System.Drawing.Color.White;
			this.tabs.TabButtonHoverState.InnerColor = global::System.Drawing.Color.DeepSkyBlue;
			this.tabs.TabButtonIdleState.BorderColor = global::System.Drawing.Color.Empty;
			this.tabs.TabButtonIdleState.FillColor = global::System.Drawing.Color.FromArgb(33, 42, 57);
			this.tabs.TabButtonIdleState.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.TabButtonIdleState.ForeColor = global::System.Drawing.Color.FromArgb(156, 160, 167);
			this.tabs.TabButtonIdleState.InnerColor = global::System.Drawing.Color.FromArgb(53, 64, 82);
			this.tabs.TabButtonSelectedState.BorderColor = global::System.Drawing.Color.Empty;
			this.tabs.TabButtonSelectedState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabs.TabButtonSelectedState.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.TabButtonSelectedState.ForeColor = global::System.Drawing.Color.White;
			this.tabs.TabButtonSelectedState.InnerColor = global::System.Drawing.Color.DeepSkyBlue;
			this.tabs.TabButtonSize = new global::System.Drawing.Size(180, 40);
			this.tabs.TabIndex = 67;
			this.tabs.TabMenuBackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.tabs.SelectedIndexChanged += new global::System.EventHandler(this.tabs_SelectedIndexChanged);
			this.tabAddon.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabAddon.Controls.Add(this.panelTabAddon);
			this.tabAddon.ForeColor = global::System.Drawing.Color.White;
			this.tabAddon.Location = new global::System.Drawing.Point(184, 4);
			this.tabAddon.Name = "tabAddon";
			this.tabAddon.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabAddon.Size = new global::System.Drawing.Size(680, 530);
			this.tabAddon.TabIndex = 0;
			this.tabAddon.Text = "Addon";
			this.panelTabAddon.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabAddon.AutoScroll = true;
			this.panelTabAddon.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabAddon.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabAddon.Controls.Add(this.grpAddonName);
			this.panelTabAddon.Controls.Add(this.grpAddonInstallation);
			this.panelTabAddon.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabAddon.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabAddon.Name = "panelTabAddon";
			this.panelTabAddon.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabAddon.TabIndex = 13;
			this.grpAddonName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddonName.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonName.Controls.Add(this.btnAddonName);
			this.grpAddonName.Controls.Add(this.txtAddonName);
			this.grpAddonName.Controls.Add(this.lblAddonName);
			this.grpAddonName.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonName.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddonName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddonName.ForeColor = global::System.Drawing.Color.White;
			this.grpAddonName.Location = new global::System.Drawing.Point(14, 137);
			this.grpAddonName.Name = "grpAddonName";
			this.grpAddonName.Size = new global::System.Drawing.Size(652, 108);
			this.grpAddonName.TabIndex = 8;
			this.grpAddonName.Text = "Name";
			this.btnAddonName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAddonName.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAddonName.BorderThickness = 1;
			this.btnAddonName.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonName.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonName.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAddonName.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddonName.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAddonName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddonName.ForeColor = global::System.Drawing.Color.White;
			this.btnAddonName.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAddonName.Location = new global::System.Drawing.Point(525, 59);
			this.btnAddonName.Name = "btnAddonName";
			this.btnAddonName.Size = new global::System.Drawing.Size(104, 30);
			this.btnAddonName.TabIndex = 66;
			this.btnAddonName.Text = "Rename";
			this.btnAddonName.Click += new global::System.EventHandler(this.btnAddonName_Click);
			this.txtAddonName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtAddonName.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAddonName.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtAddonName.DefaultText = "JK";
			this.txtAddonName.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAddonName.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtAddonName.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAddonName.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAddonName.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtAddonName.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtAddonName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtAddonName.ForeColor = global::System.Drawing.Color.White;
			this.txtAddonName.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtAddonName.Location = new global::System.Drawing.Point(180, 59);
			this.txtAddonName.MaxLength = 100;
			this.txtAddonName.Name = "txtAddonName";
			this.txtAddonName.PasswordChar = '\0';
			this.txtAddonName.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtAddonName.PlaceholderText = "";
			this.txtAddonName.SelectedText = "";
			this.txtAddonName.Size = new global::System.Drawing.Size(339, 30);
			this.txtAddonName.TabIndex = 65;
			this.lblAddonName.AutoSize = true;
			this.lblAddonName.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddonName.ForeColor = global::System.Drawing.Color.White;
			this.lblAddonName.Location = new global::System.Drawing.Point(22, 66);
			this.lblAddonName.Name = "lblAddonName";
			this.lblAddonName.Size = new global::System.Drawing.Size(42, 15);
			this.lblAddonName.TabIndex = 0;
			this.lblAddonName.Text = "Name:";
			this.grpAddonInstallation.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddonInstallation.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonInstallation.Controls.Add(this.btnAddonInstallationInstall);
			this.grpAddonInstallation.Controls.Add(this.txtAddonInstallationFolder);
			this.grpAddonInstallation.Controls.Add(this.lblAddonInstallationFolder);
			this.grpAddonInstallation.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonInstallation.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddonInstallation.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddonInstallation.ForeColor = global::System.Drawing.Color.White;
			this.grpAddonInstallation.Location = new global::System.Drawing.Point(14, 14);
			this.grpAddonInstallation.Name = "grpAddonInstallation";
			this.grpAddonInstallation.Size = new global::System.Drawing.Size(652, 108);
			this.grpAddonInstallation.TabIndex = 7;
			this.grpAddonInstallation.Text = "Installation";
			this.btnAddonInstallationInstall.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAddonInstallationInstall.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAddonInstallationInstall.BorderThickness = 1;
			this.btnAddonInstallationInstall.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonInstallationInstall.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonInstallationInstall.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAddonInstallationInstall.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddonInstallationInstall.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAddonInstallationInstall.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddonInstallationInstall.ForeColor = global::System.Drawing.Color.White;
			this.btnAddonInstallationInstall.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAddonInstallationInstall.Location = new global::System.Drawing.Point(525, 59);
			this.btnAddonInstallationInstall.Name = "btnAddonInstallationInstall";
			this.btnAddonInstallationInstall.Size = new global::System.Drawing.Size(104, 30);
			this.btnAddonInstallationInstall.TabIndex = 66;
			this.btnAddonInstallationInstall.Text = "Install";
			this.btnAddonInstallationInstall.Click += new global::System.EventHandler(this.btnAddonInstallationInstall_Click);
			this.txtAddonInstallationFolder.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtAddonInstallationFolder.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAddonInstallationFolder.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtAddonInstallationFolder.DefaultText = "";
			this.txtAddonInstallationFolder.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAddonInstallationFolder.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtAddonInstallationFolder.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAddonInstallationFolder.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAddonInstallationFolder.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtAddonInstallationFolder.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtAddonInstallationFolder.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtAddonInstallationFolder.ForeColor = global::System.Drawing.Color.White;
			this.txtAddonInstallationFolder.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtAddonInstallationFolder.Location = new global::System.Drawing.Point(180, 59);
			this.txtAddonInstallationFolder.Name = "txtAddonInstallationFolder";
			this.txtAddonInstallationFolder.PasswordChar = '\0';
			this.txtAddonInstallationFolder.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtAddonInstallationFolder.PlaceholderText = "";
			this.txtAddonInstallationFolder.ReadOnly = true;
			this.txtAddonInstallationFolder.SelectedText = "";
			this.txtAddonInstallationFolder.Size = new global::System.Drawing.Size(339, 30);
			this.txtAddonInstallationFolder.TabIndex = 65;
			this.txtAddonInstallationFolder.Click += new global::System.EventHandler(this.txtAddonInstallationFolder_Click);
			this.lblAddonInstallationFolder.AutoSize = true;
			this.lblAddonInstallationFolder.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddonInstallationFolder.ForeColor = global::System.Drawing.Color.White;
			this.lblAddonInstallationFolder.Location = new global::System.Drawing.Point(22, 66);
			this.lblAddonInstallationFolder.Name = "lblAddonInstallationFolder";
			this.lblAddonInstallationFolder.Size = new global::System.Drawing.Size(75, 15);
			this.lblAddonInstallationFolder.TabIndex = 0;
			this.lblAddonInstallationFolder.Text = "WoW Folder:";
			this.tabOptions.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabOptions.Controls.Add(this.panelTabOptions);
			this.tabOptions.ForeColor = global::System.Drawing.Color.White;
			this.tabOptions.Location = new global::System.Drawing.Point(184, 4);
			this.tabOptions.Name = "tabOptions";
			this.tabOptions.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabOptions.Size = new global::System.Drawing.Size(680, 530);
			this.tabOptions.TabIndex = 1;
			this.tabOptions.Text = "Options";
			this.panelTabOptions.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabOptions.AutoScroll = true;
			this.panelTabOptions.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabOptions.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabOptions.Controls.Add(this.grpAddonSettings);
			this.panelTabOptions.Controls.Add(this.grpAddonOptionsAutoEquip);
			this.panelTabOptions.Controls.Add(this.grpAddonOptionsAutoDestroy);
			this.panelTabOptions.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabOptions.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabOptions.Name = "panelTabOptions";
			this.panelTabOptions.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabOptions.TabIndex = 69;
			this.grpAddonSettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddonSettings.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonSettings.Controls.Add(this.checkAddonSettingsAutoCheckOnStart);
			this.grpAddonSettings.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonSettings.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddonSettings.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddonSettings.ForeColor = global::System.Drawing.Color.White;
			this.grpAddonSettings.Location = new global::System.Drawing.Point(14, 390);
			this.grpAddonSettings.Name = "grpAddonSettings";
			this.grpAddonSettings.Size = new global::System.Drawing.Size(652, 96);
			this.grpAddonSettings.TabIndex = 69;
			this.grpAddonSettings.Text = "Settings";
			this.checkAddonSettingsAutoCheckOnStart.Animated = true;
			this.checkAddonSettingsAutoCheckOnStart.AutoSize = true;
			this.checkAddonSettingsAutoCheckOnStart.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonSettingsAutoCheckOnStart.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonSettingsAutoCheckOnStart.CheckedState.BorderRadius = 0;
			this.checkAddonSettingsAutoCheckOnStart.CheckedState.BorderThickness = 0;
			this.checkAddonSettingsAutoCheckOnStart.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonSettingsAutoCheckOnStart.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkAddonSettingsAutoCheckOnStart.Location = new global::System.Drawing.Point(25, 60);
			this.checkAddonSettingsAutoCheckOnStart.Name = "checkAddonSettingsAutoCheckOnStart";
			this.checkAddonSettingsAutoCheckOnStart.Size = new global::System.Drawing.Size(225, 19);
			this.checkAddonSettingsAutoCheckOnStart.TabIndex = 35;
			this.checkAddonSettingsAutoCheckOnStart.Text = "Check if the addon is available at start";
			this.checkAddonSettingsAutoCheckOnStart.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonSettingsAutoCheckOnStart.UncheckedState.BorderRadius = 0;
			this.checkAddonSettingsAutoCheckOnStart.UncheckedState.BorderThickness = 1;
			this.checkAddonSettingsAutoCheckOnStart.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonSettingsAutoCheckOnStart.UseVisualStyleBackColor = false;
			this.checkAddonSettingsAutoCheckOnStart.CheckedChanged += new global::System.EventHandler(this.checkAddonSettingsAutoCheckOnStart_CheckedChanged);
			this.grpAddonOptionsAutoEquip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddonOptionsAutoEquip.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonOptionsAutoEquip.Controls.Add(this.checkAddonOptionsAutoEquipBags);
			this.grpAddonOptionsAutoEquip.Controls.Add(this.btnAddonOptionsApply1);
			this.grpAddonOptionsAutoEquip.Controls.Add(this.checkAddonOptionsAutoEquipPurple);
			this.grpAddonOptionsAutoEquip.Controls.Add(this.checkAddonOptionsAutoEquipBlue);
			this.grpAddonOptionsAutoEquip.Controls.Add(this.checkAddonOptionsAutoEquipGreen);
			this.grpAddonOptionsAutoEquip.Controls.Add(this.checkAddonOptionsAutoEquipWhite);
			this.grpAddonOptionsAutoEquip.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonOptionsAutoEquip.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddonOptionsAutoEquip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddonOptionsAutoEquip.ForeColor = global::System.Drawing.Color.White;
			this.grpAddonOptionsAutoEquip.Location = new global::System.Drawing.Point(14, 14);
			this.grpAddonOptionsAutoEquip.Name = "grpAddonOptionsAutoEquip";
			this.grpAddonOptionsAutoEquip.Size = new global::System.Drawing.Size(652, 173);
			this.grpAddonOptionsAutoEquip.TabIndex = 62;
			this.grpAddonOptionsAutoEquip.Text = "Auto-Equip";
			this.checkAddonOptionsAutoEquipBags.Animated = true;
			this.checkAddonOptionsAutoEquipBags.AutoSize = true;
			this.checkAddonOptionsAutoEquipBags.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoEquipBags.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipBags.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipBags.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoEquipBags.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipBags.ForeColor = global::System.Drawing.Color.White;
			this.checkAddonOptionsAutoEquipBags.Location = new global::System.Drawing.Point(180, 60);
			this.checkAddonOptionsAutoEquipBags.Name = "checkAddonOptionsAutoEquipBags";
			this.checkAddonOptionsAutoEquipBags.Size = new global::System.Drawing.Size(51, 19);
			this.checkAddonOptionsAutoEquipBags.TabIndex = 38;
			this.checkAddonOptionsAutoEquipBags.Text = "Bags";
			this.checkAddonOptionsAutoEquipBags.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoEquipBags.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipBags.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoEquipBags.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoEquipBags.UseVisualStyleBackColor = false;
			this.btnAddonOptionsApply1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAddonOptionsApply1.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAddonOptionsApply1.BorderThickness = 1;
			this.btnAddonOptionsApply1.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonOptionsApply1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonOptionsApply1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAddonOptionsApply1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddonOptionsApply1.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAddonOptionsApply1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddonOptionsApply1.ForeColor = global::System.Drawing.Color.White;
			this.btnAddonOptionsApply1.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAddonOptionsApply1.Location = new global::System.Drawing.Point(487, 124);
			this.btnAddonOptionsApply1.Name = "btnAddonOptionsApply1";
			this.btnAddonOptionsApply1.Size = new global::System.Drawing.Size(130, 30);
			this.btnAddonOptionsApply1.TabIndex = 68;
			this.btnAddonOptionsApply1.Text = "Apply";
			this.btnAddonOptionsApply1.Click += new global::System.EventHandler(this.btnAddonOptionsApply_Click);
			this.checkAddonOptionsAutoEquipPurple.Animated = true;
			this.checkAddonOptionsAutoEquipPurple.AutoSize = true;
			this.checkAddonOptionsAutoEquipPurple.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoEquipPurple.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipPurple.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipPurple.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoEquipPurple.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipPurple.ForeColor = global::System.Drawing.Color.Fuchsia;
			this.checkAddonOptionsAutoEquipPurple.Location = new global::System.Drawing.Point(25, 135);
			this.checkAddonOptionsAutoEquipPurple.Name = "checkAddonOptionsAutoEquipPurple";
			this.checkAddonOptionsAutoEquipPurple.Size = new global::System.Drawing.Size(60, 19);
			this.checkAddonOptionsAutoEquipPurple.TabIndex = 37;
			this.checkAddonOptionsAutoEquipPurple.Text = "Purple";
			this.checkAddonOptionsAutoEquipPurple.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoEquipPurple.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipPurple.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoEquipPurple.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoEquipPurple.UseVisualStyleBackColor = false;
			this.checkAddonOptionsAutoEquipBlue.Animated = true;
			this.checkAddonOptionsAutoEquipBlue.AutoSize = true;
			this.checkAddonOptionsAutoEquipBlue.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoEquipBlue.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipBlue.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipBlue.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoEquipBlue.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipBlue.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.checkAddonOptionsAutoEquipBlue.Location = new global::System.Drawing.Point(25, 110);
			this.checkAddonOptionsAutoEquipBlue.Name = "checkAddonOptionsAutoEquipBlue";
			this.checkAddonOptionsAutoEquipBlue.Size = new global::System.Drawing.Size(49, 19);
			this.checkAddonOptionsAutoEquipBlue.TabIndex = 36;
			this.checkAddonOptionsAutoEquipBlue.Text = "Blue";
			this.checkAddonOptionsAutoEquipBlue.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoEquipBlue.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipBlue.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoEquipBlue.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoEquipBlue.UseVisualStyleBackColor = false;
			this.checkAddonOptionsAutoEquipGreen.Animated = true;
			this.checkAddonOptionsAutoEquipGreen.AutoSize = true;
			this.checkAddonOptionsAutoEquipGreen.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoEquipGreen.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipGreen.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipGreen.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoEquipGreen.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipGreen.ForeColor = global::System.Drawing.Color.Lime;
			this.checkAddonOptionsAutoEquipGreen.Location = new global::System.Drawing.Point(25, 85);
			this.checkAddonOptionsAutoEquipGreen.Name = "checkAddonOptionsAutoEquipGreen";
			this.checkAddonOptionsAutoEquipGreen.Size = new global::System.Drawing.Size(57, 19);
			this.checkAddonOptionsAutoEquipGreen.TabIndex = 35;
			this.checkAddonOptionsAutoEquipGreen.Text = "Green";
			this.checkAddonOptionsAutoEquipGreen.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoEquipGreen.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipGreen.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoEquipGreen.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoEquipGreen.UseVisualStyleBackColor = false;
			this.checkAddonOptionsAutoEquipWhite.Animated = true;
			this.checkAddonOptionsAutoEquipWhite.AutoSize = true;
			this.checkAddonOptionsAutoEquipWhite.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoEquipWhite.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipWhite.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipWhite.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoEquipWhite.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoEquipWhite.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkAddonOptionsAutoEquipWhite.Location = new global::System.Drawing.Point(25, 60);
			this.checkAddonOptionsAutoEquipWhite.Name = "checkAddonOptionsAutoEquipWhite";
			this.checkAddonOptionsAutoEquipWhite.Size = new global::System.Drawing.Size(57, 19);
			this.checkAddonOptionsAutoEquipWhite.TabIndex = 34;
			this.checkAddonOptionsAutoEquipWhite.Text = "White";
			this.checkAddonOptionsAutoEquipWhite.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoEquipWhite.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoEquipWhite.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoEquipWhite.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoEquipWhite.UseVisualStyleBackColor = false;
			this.grpAddonOptionsAutoDestroy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddonOptionsAutoDestroy.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonOptionsAutoDestroy.Controls.Add(this.btnAddonOptionsApply2);
			this.grpAddonOptionsAutoDestroy.Controls.Add(this.btnAddonOptionsAutoDestroyJunklist);
			this.grpAddonOptionsAutoDestroy.Controls.Add(this.checkAddonOptionsAutoDestroyBOE);
			this.grpAddonOptionsAutoDestroy.Controls.Add(this.checkAddonOptionsAutoDestroyGrey);
			this.grpAddonOptionsAutoDestroy.Controls.Add(this.checkAddonOptionsAutoDestroyBlue);
			this.grpAddonOptionsAutoDestroy.Controls.Add(this.checkAddonOptionsAutoDestroyGreen);
			this.grpAddonOptionsAutoDestroy.Controls.Add(this.checkAddonOptionsAutoDestroyWhite);
			this.grpAddonOptionsAutoDestroy.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddonOptionsAutoDestroy.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddonOptionsAutoDestroy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddonOptionsAutoDestroy.ForeColor = global::System.Drawing.Color.White;
			this.grpAddonOptionsAutoDestroy.Location = new global::System.Drawing.Point(14, 202);
			this.grpAddonOptionsAutoDestroy.Name = "grpAddonOptionsAutoDestroy";
			this.grpAddonOptionsAutoDestroy.Size = new global::System.Drawing.Size(652, 173);
			this.grpAddonOptionsAutoDestroy.TabIndex = 63;
			this.grpAddonOptionsAutoDestroy.Text = "Auto-Destroy";
			this.btnAddonOptionsApply2.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAddonOptionsApply2.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAddonOptionsApply2.BorderThickness = 1;
			this.btnAddonOptionsApply2.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonOptionsApply2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonOptionsApply2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAddonOptionsApply2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddonOptionsApply2.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAddonOptionsApply2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddonOptionsApply2.ForeColor = global::System.Drawing.Color.White;
			this.btnAddonOptionsApply2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAddonOptionsApply2.Location = new global::System.Drawing.Point(487, 124);
			this.btnAddonOptionsApply2.Name = "btnAddonOptionsApply2";
			this.btnAddonOptionsApply2.Size = new global::System.Drawing.Size(130, 30);
			this.btnAddonOptionsApply2.TabIndex = 69;
			this.btnAddonOptionsApply2.Text = "Apply";
			this.btnAddonOptionsApply2.Click += new global::System.EventHandler(this.btnAddonOptionsApply_Click);
			this.btnAddonOptionsAutoDestroyJunklist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAddonOptionsAutoDestroyJunklist.BorderThickness = 1;
			this.btnAddonOptionsAutoDestroyJunklist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonOptionsAutoDestroyJunklist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddonOptionsAutoDestroyJunklist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAddonOptionsAutoDestroyJunklist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddonOptionsAutoDestroyJunklist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAddonOptionsAutoDestroyJunklist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddonOptionsAutoDestroyJunklist.ForeColor = global::System.Drawing.Color.White;
			this.btnAddonOptionsAutoDestroyJunklist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAddonOptionsAutoDestroyJunklist.Location = new global::System.Drawing.Point(180, 124);
			this.btnAddonOptionsAutoDestroyJunklist.Name = "btnAddonOptionsAutoDestroyJunklist";
			this.btnAddonOptionsAutoDestroyJunklist.Size = new global::System.Drawing.Size(104, 30);
			this.btnAddonOptionsAutoDestroyJunklist.TabIndex = 67;
			this.btnAddonOptionsAutoDestroyJunklist.Text = "Junklist";
			this.btnAddonOptionsAutoDestroyJunklist.Click += new global::System.EventHandler(this.btnAddonOptionsAutoDestroyJunklist_Click);
			this.checkAddonOptionsAutoDestroyBOE.Animated = true;
			this.checkAddonOptionsAutoDestroyBOE.AutoSize = true;
			this.checkAddonOptionsAutoDestroyBOE.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoDestroyBOE.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyBOE.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyBOE.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoDestroyBOE.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyBOE.ForeColor = global::System.Drawing.Color.White;
			this.checkAddonOptionsAutoDestroyBOE.Location = new global::System.Drawing.Point(180, 60);
			this.checkAddonOptionsAutoDestroyBOE.Name = "checkAddonOptionsAutoDestroyBOE";
			this.checkAddonOptionsAutoDestroyBOE.Size = new global::System.Drawing.Size(46, 19);
			this.checkAddonOptionsAutoDestroyBOE.TabIndex = 38;
			this.checkAddonOptionsAutoDestroyBOE.Text = "BoE";
			this.checkAddonOptionsAutoDestroyBOE.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoDestroyBOE.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyBOE.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoDestroyBOE.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoDestroyBOE.UseVisualStyleBackColor = false;
			this.checkAddonOptionsAutoDestroyGrey.Animated = true;
			this.checkAddonOptionsAutoDestroyGrey.AutoSize = true;
			this.checkAddonOptionsAutoDestroyGrey.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoDestroyGrey.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyGrey.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyGrey.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoDestroyGrey.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyGrey.ForeColor = global::System.Drawing.Color.DarkGray;
			this.checkAddonOptionsAutoDestroyGrey.Location = new global::System.Drawing.Point(25, 60);
			this.checkAddonOptionsAutoDestroyGrey.Name = "checkAddonOptionsAutoDestroyGrey";
			this.checkAddonOptionsAutoDestroyGrey.Size = new global::System.Drawing.Size(50, 19);
			this.checkAddonOptionsAutoDestroyGrey.TabIndex = 37;
			this.checkAddonOptionsAutoDestroyGrey.Text = "Gray";
			this.checkAddonOptionsAutoDestroyGrey.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoDestroyGrey.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyGrey.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoDestroyGrey.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoDestroyGrey.UseVisualStyleBackColor = false;
			this.checkAddonOptionsAutoDestroyBlue.Animated = true;
			this.checkAddonOptionsAutoDestroyBlue.AutoSize = true;
			this.checkAddonOptionsAutoDestroyBlue.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoDestroyBlue.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyBlue.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyBlue.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoDestroyBlue.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyBlue.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.checkAddonOptionsAutoDestroyBlue.Location = new global::System.Drawing.Point(25, 135);
			this.checkAddonOptionsAutoDestroyBlue.Name = "checkAddonOptionsAutoDestroyBlue";
			this.checkAddonOptionsAutoDestroyBlue.Size = new global::System.Drawing.Size(49, 19);
			this.checkAddonOptionsAutoDestroyBlue.TabIndex = 36;
			this.checkAddonOptionsAutoDestroyBlue.Text = "Blue";
			this.checkAddonOptionsAutoDestroyBlue.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoDestroyBlue.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyBlue.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoDestroyBlue.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoDestroyBlue.UseVisualStyleBackColor = false;
			this.checkAddonOptionsAutoDestroyGreen.Animated = true;
			this.checkAddonOptionsAutoDestroyGreen.AutoSize = true;
			this.checkAddonOptionsAutoDestroyGreen.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoDestroyGreen.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyGreen.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyGreen.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoDestroyGreen.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyGreen.ForeColor = global::System.Drawing.Color.Lime;
			this.checkAddonOptionsAutoDestroyGreen.Location = new global::System.Drawing.Point(25, 110);
			this.checkAddonOptionsAutoDestroyGreen.Name = "checkAddonOptionsAutoDestroyGreen";
			this.checkAddonOptionsAutoDestroyGreen.Size = new global::System.Drawing.Size(57, 19);
			this.checkAddonOptionsAutoDestroyGreen.TabIndex = 35;
			this.checkAddonOptionsAutoDestroyGreen.Text = "Green";
			this.checkAddonOptionsAutoDestroyGreen.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoDestroyGreen.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyGreen.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoDestroyGreen.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoDestroyGreen.UseVisualStyleBackColor = false;
			this.checkAddonOptionsAutoDestroyWhite.Animated = true;
			this.checkAddonOptionsAutoDestroyWhite.AutoSize = true;
			this.checkAddonOptionsAutoDestroyWhite.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddonOptionsAutoDestroyWhite.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyWhite.CheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyWhite.CheckedState.BorderThickness = 0;
			this.checkAddonOptionsAutoDestroyWhite.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddonOptionsAutoDestroyWhite.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkAddonOptionsAutoDestroyWhite.Location = new global::System.Drawing.Point(25, 85);
			this.checkAddonOptionsAutoDestroyWhite.Name = "checkAddonOptionsAutoDestroyWhite";
			this.checkAddonOptionsAutoDestroyWhite.Size = new global::System.Drawing.Size(57, 19);
			this.checkAddonOptionsAutoDestroyWhite.TabIndex = 34;
			this.checkAddonOptionsAutoDestroyWhite.Text = "White";
			this.checkAddonOptionsAutoDestroyWhite.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddonOptionsAutoDestroyWhite.UncheckedState.BorderRadius = 0;
			this.checkAddonOptionsAutoDestroyWhite.UncheckedState.BorderThickness = 1;
			this.checkAddonOptionsAutoDestroyWhite.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddonOptionsAutoDestroyWhite.UseVisualStyleBackColor = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 629);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainAddon";
			this.Text = "frmMainAddon";
			base.Load += new global::System.EventHandler(this.frmMainAddon_Load);
			base.Shown += new global::System.EventHandler(this.frmMainAddon_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainAddon_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			this.tabs.ResumeLayout(false);
			this.tabAddon.ResumeLayout(false);
			this.panelTabAddon.ResumeLayout(false);
			this.grpAddonName.ResumeLayout(false);
			this.grpAddonName.PerformLayout();
			this.grpAddonInstallation.ResumeLayout(false);
			this.grpAddonInstallation.PerformLayout();
			this.tabOptions.ResumeLayout(false);
			this.panelTabOptions.ResumeLayout(false);
			this.grpAddonSettings.ResumeLayout(false);
			this.grpAddonSettings.PerformLayout();
			this.grpAddonOptionsAutoEquip.ResumeLayout(false);
			this.grpAddonOptionsAutoEquip.PerformLayout();
			this.grpAddonOptionsAutoDestroy.ResumeLayout(false);
			this.grpAddonOptionsAutoDestroy.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040005FF RID: 1535
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000600 RID: 1536
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000601 RID: 1537
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x04000602 RID: 1538
		private global::System.Windows.Forms.TabPage tabAddon;

		// Token: 0x04000603 RID: 1539
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddonInstallation;

		// Token: 0x04000604 RID: 1540
		private global::System.Windows.Forms.Label lblAddonInstallationFolder;

		// Token: 0x04000605 RID: 1541
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x04000606 RID: 1542
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x04000607 RID: 1543
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x04000608 RID: 1544
		private global::System.Windows.Forms.TabPage tabOptions;

		// Token: 0x04000609 RID: 1545
		private global::Guna.UI2.WinForms.Guna2TextBox txtAddonInstallationFolder;

		// Token: 0x0400060A RID: 1546
		private global::Guna.UI2.WinForms.Guna2Button btnAddonInstallationInstall;

		// Token: 0x0400060B RID: 1547
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddonName;

		// Token: 0x0400060C RID: 1548
		private global::Guna.UI2.WinForms.Guna2Button btnAddonName;

		// Token: 0x0400060D RID: 1549
		private global::Guna.UI2.WinForms.Guna2TextBox txtAddonName;

		// Token: 0x0400060E RID: 1550
		private global::System.Windows.Forms.Label lblAddonName;

		// Token: 0x0400060F RID: 1551
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddonOptionsAutoEquip;

		// Token: 0x04000610 RID: 1552
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoEquipPurple;

		// Token: 0x04000611 RID: 1553
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoEquipBlue;

		// Token: 0x04000612 RID: 1554
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoEquipGreen;

		// Token: 0x04000613 RID: 1555
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoEquipWhite;

		// Token: 0x04000614 RID: 1556
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoEquipBags;

		// Token: 0x04000615 RID: 1557
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddonOptionsAutoDestroy;

		// Token: 0x04000616 RID: 1558
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoDestroyBOE;

		// Token: 0x04000617 RID: 1559
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoDestroyGrey;

		// Token: 0x04000618 RID: 1560
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoDestroyBlue;

		// Token: 0x04000619 RID: 1561
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoDestroyGreen;

		// Token: 0x0400061A RID: 1562
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonOptionsAutoDestroyWhite;

		// Token: 0x0400061B RID: 1563
		private global::Guna.UI2.WinForms.Guna2Button btnAddonOptionsAutoDestroyJunklist;

		// Token: 0x0400061C RID: 1564
		private global::Guna.UI2.WinForms.Guna2Button btnAddonOptionsApply1;

		// Token: 0x0400061D RID: 1565
		private global::Guna.UI2.WinForms.Guna2Panel panelTabAddon;

		// Token: 0x0400061E RID: 1566
		private global::Guna.UI2.WinForms.Guna2Panel panelTabOptions;

		// Token: 0x0400061F RID: 1567
		private global::Guna.UI2.WinForms.Guna2Button btnAddonTooltip;

		// Token: 0x04000620 RID: 1568
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddonSettings;

		// Token: 0x04000621 RID: 1569
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddonSettingsAutoCheckOnStart;

		// Token: 0x04000622 RID: 1570
		private global::Guna.UI2.WinForms.Guna2Button btnAddonOptionsApply2;
	}
}
