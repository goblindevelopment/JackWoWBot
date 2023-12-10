namespace Jack.Forms
{
	// Token: 0x02000081 RID: 129
	public partial class frmStore : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C39 RID: 3129 RVA: 0x006A0B08 File Offset: 0x0069ED08
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x006A0B34 File Offset: 0x0069ED34
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmStore));
			this.panelHeader = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnDelete = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnBack = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtSearch = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblStore = new global::System.Windows.Forms.Label();
			this.btnStore = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.panelActionBar = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnRefresh = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelCoins = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblCoins = new global::System.Windows.Forms.Label();
			this.imgCoin = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgClose = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.imgMinimize = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.panelActionBarSep1 = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.panelMenu = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblResetFilter = new global::System.Windows.Forms.Label();
			this.btnFilter = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelFilterProfile = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblFilterRequiredSkill = new global::System.Windows.Forms.Label();
			this.txtFilterRequiredSkill = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblFilterRequiredLevel = new global::System.Windows.Forms.Label();
			this.txtFilterRequiredLevel = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnFilterProfile = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectFilterProfileType = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectFilterProfileSubType = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.panelFilterCharacter = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnFilterCharacter = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectFilterFaction = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectFilterClass = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.panelFilterGame = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnFilterGame = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkFilterClassic = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkFilterClassicEra = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkFilterRetail = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.btnDashboard = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelContent = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgSizer = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelAutoComplete = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelSearchResult = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblSearchResultType = new global::System.Windows.Forms.Label();
			this.lblSearchResultName = new global::System.Windows.Forms.Label();
			this.panelInfo = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblInfo = new global::System.Windows.Forms.Label();
			this.panelInfoSpacer = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelMenuCoins = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnMenuCoinsClose = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnMenuCoinsGet = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnMenuCoinsWeb = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelHeader.SuspendLayout();
			this.panelActionBar.SuspendLayout();
			this.panelCoins.SuspendLayout();
			this.imgCoin.BeginInit();
			this.panelMenu.SuspendLayout();
			this.panelFilterProfile.SuspendLayout();
			this.panelFilterCharacter.SuspendLayout();
			this.panelFilterGame.SuspendLayout();
			this.panelContent.SuspendLayout();
			this.imgSizer.BeginInit();
			this.panelAutoComplete.SuspendLayout();
			this.panelSearchResult.SuspendLayout();
			this.panelInfo.SuspendLayout();
			this.panelMenuCoins.SuspendLayout();
			base.SuspendLayout();
			this.panelHeader.Controls.Add(this.btnDelete);
			this.panelHeader.Controls.Add(this.btnBack);
			this.panelHeader.Controls.Add(this.txtSearch);
			this.panelHeader.Controls.Add(this.lblStore);
			this.panelHeader.Controls.Add(this.btnStore);
			this.panelHeader.Controls.Add(this.panelActionBar);
			this.panelHeader.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new global::System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new global::System.Drawing.Size(1020, 50);
			this.panelHeader.TabIndex = 1;
			this.panelHeader.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
			this.btnDelete.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnDelete.BackColor = global::System.Drawing.Color.Transparent;
			this.btnDelete.BorderColor = global::System.Drawing.Color.Empty;
			this.btnDelete.BorderRadius = 4;
			this.btnDelete.BorderThickness = 1;
			this.btnDelete.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnDelete.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnDelete.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnDelete.FillColor = global::System.Drawing.Color.Transparent;
			this.btnDelete.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnDelete.ForeColor = global::System.Drawing.Color.White;
			this.btnDelete.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnDelete.Image = global::Jack.Properties.Resources.store_delete;
			this.btnDelete.ImageSize = new global::System.Drawing.Size(18, 18);
			this.btnDelete.Location = new global::System.Drawing.Point(700, 9);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(32, 32);
			this.btnDelete.TabIndex = 70;
			this.btnDelete.Visible = false;
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.btnBack.BackColor = global::System.Drawing.Color.Transparent;
			this.btnBack.BorderColor = global::System.Drawing.Color.Empty;
			this.btnBack.BorderRadius = 4;
			this.btnBack.BorderThickness = 1;
			this.btnBack.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBack.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnBack.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBack.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBack.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnBack.ForeColor = global::System.Drawing.Color.White;
			this.btnBack.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnBack.Image = global::Jack.Properties.Resources.store_back;
			this.btnBack.ImageSize = new global::System.Drawing.Size(18, 18);
			this.btnBack.Location = new global::System.Drawing.Point(189, 9);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new global::System.Drawing.Size(32, 32);
			this.btnBack.TabIndex = 69;
			this.btnBack.Visible = false;
			this.btnBack.Click += new global::System.EventHandler(this.btnBack_Click);
			this.txtSearch.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtSearch.BackColor = global::System.Drawing.Color.Transparent;
			this.txtSearch.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.txtSearch.BorderRadius = 4;
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
			this.txtSearch.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(78, 90, 110);
			this.txtSearch.IconRight = global::Jack.Properties.Resources.search_18;
			this.txtSearch.IconRightOffset = new global::System.Drawing.Point(1, 0);
			this.txtSearch.IconRightSize = new global::System.Drawing.Size(18, 18);
			this.txtSearch.Location = new global::System.Drawing.Point(227, 10);
			this.txtSearch.MaxLength = 200;
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.PasswordChar = '\0';
			this.txtSearch.PlaceholderForeColor = global::System.Drawing.Color.DarkGray;
			this.txtSearch.PlaceholderText = "Search for Profiles, Professions and more...";
			this.txtSearch.SelectedText = "";
			this.txtSearch.ShadowDecoration.Color = global::System.Drawing.Color.White;
			this.txtSearch.ShadowDecoration.Shadow = new global::System.Windows.Forms.Padding(0);
			this.txtSearch.Size = new global::System.Drawing.Size(467, 30);
			this.txtSearch.TabIndex = 64;
			this.txtSearch.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
			this.txtSearch.Leave += new global::System.EventHandler(this.txtSearch_Leave);
			this.txtSearch.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
			this.lblStore.AutoSize = true;
			this.lblStore.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStore.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblStore.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblStore.ForeColor = global::System.Drawing.Color.DarkGray;
			this.lblStore.Location = new global::System.Drawing.Point(46, 18);
			this.lblStore.Name = "lblStore";
			this.lblStore.Size = new global::System.Drawing.Size(71, 15);
			this.lblStore.TabIndex = 10;
			this.lblStore.Text = "Profile Store";
			this.lblStore.Click += new global::System.EventHandler(this.btnMenuCoinsWeb_Click);
			this.btnStore.CheckedState.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnStore.HoverState.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.Image = global::Jack.Properties.Resources.shopping_bag_21;
			this.btnStore.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.btnStore.ImageRotate = 0f;
			this.btnStore.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.Location = new global::System.Drawing.Point(12, 8);
			this.btnStore.Name = "btnStore";
			this.btnStore.PressedState.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.Size = new global::System.Drawing.Size(32, 32);
			this.btnStore.TabIndex = 9;
			this.btnStore.Click += new global::System.EventHandler(this.btnMenuCoinsWeb_Click);
			this.panelActionBar.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelActionBar.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelActionBar.Controls.Add(this.btnRefresh);
			this.panelActionBar.Controls.Add(this.panelCoins);
			this.panelActionBar.Controls.Add(this.imgClose);
			this.panelActionBar.Controls.Add(this.imgMinimize);
			this.panelActionBar.Controls.Add(this.panelActionBarSep1);
			this.panelActionBar.Location = new global::System.Drawing.Point(761, 0);
			this.panelActionBar.Name = "panelActionBar";
			this.panelActionBar.Size = new global::System.Drawing.Size(259, 50);
			this.panelActionBar.TabIndex = 8;
			this.panelActionBar.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
			this.btnRefresh.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRefresh.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRefresh.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRefresh.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRefresh.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRefresh.DisabledState.Image = global::Jack.Properties.Resources.refresh_disabled_18;
			this.btnRefresh.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRefresh.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRefresh.ForeColor = global::System.Drawing.Color.White;
			this.btnRefresh.Image = global::Jack.Properties.Resources.refresh_18;
			this.btnRefresh.ImageSize = new global::System.Drawing.Size(18, 18);
			this.btnRefresh.Location = new global::System.Drawing.Point(137, 9);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new global::System.Drawing.Size(32, 32);
			this.btnRefresh.TabIndex = 69;
			this.btnRefresh.Click += new global::System.EventHandler(this.btnRefresh_Click);
			this.panelCoins.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelCoins.BackColor = global::System.Drawing.Color.Transparent;
			this.panelCoins.Controls.Add(this.lblCoins);
			this.panelCoins.Controls.Add(this.imgCoin);
			this.panelCoins.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.panelCoins.FillColor = global::System.Drawing.Color.Transparent;
			this.panelCoins.Location = new global::System.Drawing.Point(16, 13);
			this.panelCoins.Name = "panelCoins";
			this.panelCoins.Size = new global::System.Drawing.Size(90, 24);
			this.panelCoins.TabIndex = 60;
			this.panelCoins.Click += new global::System.EventHandler(this.panelCoins_Click);
			this.lblCoins.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblCoins.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCoins.Font = new global::System.Drawing.Font("Segoe UI", 9.5f);
			this.lblCoins.ForeColor = global::System.Drawing.Color.Goldenrod;
			this.lblCoins.Location = new global::System.Drawing.Point(4, 3);
			this.lblCoins.Name = "lblCoins";
			this.lblCoins.Size = new global::System.Drawing.Size(60, 15);
			this.lblCoins.TabIndex = 61;
			this.lblCoins.Text = "0";
			this.lblCoins.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblCoins.Click += new global::System.EventHandler(this.panelCoins_Click);
			this.imgCoin.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgCoin.BackColor = global::System.Drawing.Color.Transparent;
			this.imgCoin.FillColor = global::System.Drawing.Color.Transparent;
			this.imgCoin.Image = global::Jack.Properties.Resources.coin_24;
			this.imgCoin.ImageRotate = 0f;
			this.imgCoin.Location = new global::System.Drawing.Point(66, 0);
			this.imgCoin.Name = "imgCoin";
			this.imgCoin.Size = new global::System.Drawing.Size(24, 24);
			this.imgCoin.TabIndex = 60;
			this.imgCoin.TabStop = false;
			this.imgCoin.Click += new global::System.EventHandler(this.panelCoins_Click);
			this.imgClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgClose.CheckedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.imgClose.HoverState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Image = global::Jack.Properties.Resources.close_16;
			this.imgClose.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgClose.ImageRotate = 0f;
			this.imgClose.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Location = new global::System.Drawing.Point(215, 9);
			this.imgClose.Name = "imgClose";
			this.imgClose.PressedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Size = new global::System.Drawing.Size(32, 32);
			this.imgClose.TabIndex = 1;
			this.imgClose.Click += new global::System.EventHandler(this.imgClose_Click);
			this.imgMinimize.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgMinimize.CheckedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgMinimize.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.imgMinimize.HoverState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgMinimize.Image = global::Jack.Properties.Resources.minimize_16;
			this.imgMinimize.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgMinimize.ImageRotate = 0f;
			this.imgMinimize.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgMinimize.Location = new global::System.Drawing.Point(177, 9);
			this.imgMinimize.Name = "imgMinimize";
			this.imgMinimize.PressedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgMinimize.Size = new global::System.Drawing.Size(32, 32);
			this.imgMinimize.TabIndex = 2;
			this.imgMinimize.Click += new global::System.EventHandler(this.imgMinimize_Click);
			this.panelActionBarSep1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelActionBarSep1.FillColor = global::System.Drawing.Color.FromArgb(28, 35, 64);
			this.panelActionBarSep1.Location = new global::System.Drawing.Point(119, 12);
			this.panelActionBarSep1.Name = "panelActionBarSep1";
			this.panelActionBarSep1.Size = new global::System.Drawing.Size(10, 26);
			this.panelActionBarSep1.TabIndex = 3;
			this.panelMenu.BackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelMenu.Controls.Add(this.lblResetFilter);
			this.panelMenu.Controls.Add(this.btnFilter);
			this.panelMenu.Controls.Add(this.panelFilterProfile);
			this.panelMenu.Controls.Add(this.panelFilterCharacter);
			this.panelMenu.Controls.Add(this.panelFilterGame);
			this.panelMenu.Controls.Add(this.btnDashboard);
			this.panelMenu.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new global::System.Drawing.Point(0, 50);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new global::System.Drawing.Size(211, 615);
			this.panelMenu.TabIndex = 2;
			this.lblResetFilter.AutoSize = true;
			this.lblResetFilter.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblResetFilter.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblResetFilter.ForeColor = global::System.Drawing.Color.Gray;
			this.lblResetFilter.Location = new global::System.Drawing.Point(73, 581);
			this.lblResetFilter.Name = "lblResetFilter";
			this.lblResetFilter.Size = new global::System.Drawing.Size(64, 13);
			this.lblResetFilter.TabIndex = 159;
			this.lblResetFilter.Text = "Reset Filter";
			this.lblResetFilter.Click += new global::System.EventHandler(this.lblResetFilter_Click);
			this.btnFilter.BorderColor = global::System.Drawing.Color.Gray;
			this.btnFilter.BorderThickness = 1;
			this.btnFilter.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnFilter.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnFilter.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnFilter.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnFilter.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnFilter.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnFilter.ForeColor = global::System.Drawing.Color.White;
			this.btnFilter.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnFilter.Location = new global::System.Drawing.Point(21, 546);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new global::System.Drawing.Size(168, 30);
			this.btnFilter.TabIndex = 68;
			this.btnFilter.Text = "Search";
			this.btnFilter.Click += new global::System.EventHandler(this.btnFilter_Click);
			this.panelFilterProfile.Controls.Add(this.lblFilterRequiredSkill);
			this.panelFilterProfile.Controls.Add(this.txtFilterRequiredSkill);
			this.panelFilterProfile.Controls.Add(this.lblFilterRequiredLevel);
			this.panelFilterProfile.Controls.Add(this.txtFilterRequiredLevel);
			this.panelFilterProfile.Controls.Add(this.btnFilterProfile);
			this.panelFilterProfile.Controls.Add(this.selectFilterProfileType);
			this.panelFilterProfile.Controls.Add(this.selectFilterProfileSubType);
			this.panelFilterProfile.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelFilterProfile.Location = new global::System.Drawing.Point(0, 341);
			this.panelFilterProfile.Name = "panelFilterProfile";
			this.panelFilterProfile.Size = new global::System.Drawing.Size(211, 205);
			this.panelFilterProfile.TabIndex = 62;
			this.lblFilterRequiredSkill.AutoSize = true;
			this.lblFilterRequiredSkill.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblFilterRequiredSkill.ForeColor = global::System.Drawing.Color.White;
			this.lblFilterRequiredSkill.Location = new global::System.Drawing.Point(107, 138);
			this.lblFilterRequiredSkill.Name = "lblFilterRequiredSkill";
			this.lblFilterRequiredSkill.Size = new global::System.Drawing.Size(54, 13);
			this.lblFilterRequiredSkill.TabIndex = 158;
			this.lblFilterRequiredSkill.Text = "Min. Skill";
			this.txtFilterRequiredSkill.BorderColor = global::System.Drawing.Color.Gray;
			this.txtFilterRequiredSkill.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtFilterRequiredSkill.DefaultText = "";
			this.txtFilterRequiredSkill.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtFilterRequiredSkill.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtFilterRequiredSkill.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFilterRequiredSkill.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFilterRequiredSkill.Enabled = false;
			this.txtFilterRequiredSkill.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtFilterRequiredSkill.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtFilterRequiredSkill.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtFilterRequiredSkill.ForeColor = global::System.Drawing.Color.White;
			this.txtFilterRequiredSkill.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtFilterRequiredSkill.Location = new global::System.Drawing.Point(110, 154);
			this.txtFilterRequiredSkill.MaxLength = 3;
			this.txtFilterRequiredSkill.Name = "txtFilterRequiredSkill";
			this.txtFilterRequiredSkill.PasswordChar = '\0';
			this.txtFilterRequiredSkill.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtFilterRequiredSkill.PlaceholderText = "";
			this.txtFilterRequiredSkill.SelectedText = "";
			this.txtFilterRequiredSkill.Size = new global::System.Drawing.Size(79, 30);
			this.txtFilterRequiredSkill.TabIndex = 157;
			this.lblFilterRequiredLevel.AutoSize = true;
			this.lblFilterRequiredLevel.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblFilterRequiredLevel.ForeColor = global::System.Drawing.Color.White;
			this.lblFilterRequiredLevel.Location = new global::System.Drawing.Point(18, 138);
			this.lblFilterRequiredLevel.Name = "lblFilterRequiredLevel";
			this.lblFilterRequiredLevel.Size = new global::System.Drawing.Size(58, 13);
			this.lblFilterRequiredLevel.TabIndex = 154;
			this.lblFilterRequiredLevel.Text = "Min. Level";
			this.txtFilterRequiredLevel.BorderColor = global::System.Drawing.Color.Gray;
			this.txtFilterRequiredLevel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtFilterRequiredLevel.DefaultText = "";
			this.txtFilterRequiredLevel.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtFilterRequiredLevel.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtFilterRequiredLevel.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFilterRequiredLevel.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFilterRequiredLevel.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtFilterRequiredLevel.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtFilterRequiredLevel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtFilterRequiredLevel.ForeColor = global::System.Drawing.Color.White;
			this.txtFilterRequiredLevel.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtFilterRequiredLevel.Location = new global::System.Drawing.Point(21, 154);
			this.txtFilterRequiredLevel.MaxLength = 2;
			this.txtFilterRequiredLevel.Name = "txtFilterRequiredLevel";
			this.txtFilterRequiredLevel.PasswordChar = '\0';
			this.txtFilterRequiredLevel.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtFilterRequiredLevel.PlaceholderText = "";
			this.txtFilterRequiredLevel.SelectedText = "";
			this.txtFilterRequiredLevel.Size = new global::System.Drawing.Size(79, 30);
			this.txtFilterRequiredLevel.TabIndex = 153;
			this.btnFilterProfile.BackColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterProfile.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnFilterProfile.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnFilterProfile.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnFilterProfile.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnFilterProfile.FillColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterProfile.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnFilterProfile.ForeColor = global::System.Drawing.Color.White;
			this.btnFilterProfile.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterProfile.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterProfile.HoverState.FillColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterProfile.Image = global::Jack.Properties.Resources.store_game_24;
			this.btnFilterProfile.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnFilterProfile.ImageOffset = new global::System.Drawing.Point(6, 0);
			this.btnFilterProfile.ImageSize = new global::System.Drawing.Size(24, 24);
			this.btnFilterProfile.Location = new global::System.Drawing.Point(0, 0);
			this.btnFilterProfile.Name = "btnFilterProfile";
			this.btnFilterProfile.PressedDepth = 0;
			this.btnFilterProfile.Size = new global::System.Drawing.Size(211, 42);
			this.btnFilterProfile.TabIndex = 149;
			this.btnFilterProfile.Text = "Profile";
			this.btnFilterProfile.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnFilterProfile.TextOffset = new global::System.Drawing.Point(8, 0);
			this.selectFilterProfileType.BackColor = global::System.Drawing.Color.Transparent;
			this.selectFilterProfileType.BorderColor = global::System.Drawing.Color.Gray;
			this.selectFilterProfileType.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectFilterProfileType.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectFilterProfileType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectFilterProfileType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectFilterProfileType.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectFilterProfileType.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterProfileType.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterProfileType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectFilterProfileType.ForeColor = global::System.Drawing.Color.White;
			this.selectFilterProfileType.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectFilterProfileType.ItemHeight = 24;
			this.selectFilterProfileType.Items.AddRange(new object[]
			{
				"All Types"
			});
			this.selectFilterProfileType.Location = new global::System.Drawing.Point(21, 63);
			this.selectFilterProfileType.Name = "selectFilterProfileType";
			this.selectFilterProfileType.Size = new global::System.Drawing.Size(168, 30);
			this.selectFilterProfileType.TabIndex = 152;
			this.selectFilterProfileType.SelectedIndexChanged += new global::System.EventHandler(this.selectFilterProfileType_SelectedIndexChanged);
			this.selectFilterProfileSubType.BackColor = global::System.Drawing.Color.Transparent;
			this.selectFilterProfileSubType.BorderColor = global::System.Drawing.Color.Gray;
			this.selectFilterProfileSubType.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectFilterProfileSubType.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectFilterProfileSubType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectFilterProfileSubType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectFilterProfileSubType.Enabled = false;
			this.selectFilterProfileSubType.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectFilterProfileSubType.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterProfileSubType.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterProfileSubType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectFilterProfileSubType.ForeColor = global::System.Drawing.Color.White;
			this.selectFilterProfileSubType.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectFilterProfileSubType.ItemHeight = 24;
			this.selectFilterProfileSubType.Items.AddRange(new object[]
			{
				"All Sub-Types"
			});
			this.selectFilterProfileSubType.Location = new global::System.Drawing.Point(21, 102);
			this.selectFilterProfileSubType.Name = "selectFilterProfileSubType";
			this.selectFilterProfileSubType.Size = new global::System.Drawing.Size(168, 30);
			this.selectFilterProfileSubType.TabIndex = 151;
			this.panelFilterCharacter.Controls.Add(this.btnFilterCharacter);
			this.panelFilterCharacter.Controls.Add(this.selectFilterFaction);
			this.panelFilterCharacter.Controls.Add(this.selectFilterClass);
			this.panelFilterCharacter.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelFilterCharacter.Location = new global::System.Drawing.Point(0, 188);
			this.panelFilterCharacter.Name = "panelFilterCharacter";
			this.panelFilterCharacter.Size = new global::System.Drawing.Size(211, 153);
			this.panelFilterCharacter.TabIndex = 61;
			this.btnFilterCharacter.BackColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterCharacter.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnFilterCharacter.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnFilterCharacter.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnFilterCharacter.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnFilterCharacter.FillColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterCharacter.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnFilterCharacter.ForeColor = global::System.Drawing.Color.White;
			this.btnFilterCharacter.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterCharacter.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterCharacter.HoverState.FillColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterCharacter.Image = global::Jack.Properties.Resources.store_game_24;
			this.btnFilterCharacter.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnFilterCharacter.ImageOffset = new global::System.Drawing.Point(6, 0);
			this.btnFilterCharacter.ImageSize = new global::System.Drawing.Size(24, 24);
			this.btnFilterCharacter.Location = new global::System.Drawing.Point(0, 0);
			this.btnFilterCharacter.Name = "btnFilterCharacter";
			this.btnFilterCharacter.PressedDepth = 0;
			this.btnFilterCharacter.Size = new global::System.Drawing.Size(211, 42);
			this.btnFilterCharacter.TabIndex = 38;
			this.btnFilterCharacter.Text = "Character";
			this.btnFilterCharacter.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnFilterCharacter.TextOffset = new global::System.Drawing.Point(8, 0);
			this.selectFilterFaction.BackColor = global::System.Drawing.Color.Transparent;
			this.selectFilterFaction.BorderColor = global::System.Drawing.Color.Gray;
			this.selectFilterFaction.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectFilterFaction.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectFilterFaction.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectFilterFaction.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectFilterFaction.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectFilterFaction.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterFaction.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterFaction.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectFilterFaction.ForeColor = global::System.Drawing.Color.White;
			this.selectFilterFaction.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectFilterFaction.ItemHeight = 24;
			this.selectFilterFaction.Items.AddRange(new object[]
			{
				"All Factions",
				"Alliance",
				"Horde"
			});
			this.selectFilterFaction.Location = new global::System.Drawing.Point(21, 63);
			this.selectFilterFaction.Name = "selectFilterFaction";
			this.selectFilterFaction.Size = new global::System.Drawing.Size(168, 30);
			this.selectFilterFaction.TabIndex = 147;
			this.selectFilterClass.BackColor = global::System.Drawing.Color.Transparent;
			this.selectFilterClass.BorderColor = global::System.Drawing.Color.Gray;
			this.selectFilterClass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectFilterClass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectFilterClass.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectFilterClass.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectFilterClass.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectFilterClass.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterClass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFilterClass.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectFilterClass.ForeColor = global::System.Drawing.Color.White;
			this.selectFilterClass.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectFilterClass.ItemHeight = 24;
			this.selectFilterClass.Items.AddRange(new object[]
			{
				"All Classes",
				"Range",
				"Melee",
				"----------------",
				"Death Knight",
				"Druid",
				"Hunter",
				"Mage",
				"Paladin",
				"Priest",
				"Rogue",
				"Shaman",
				"Warlock",
				"Warrior"
			});
			this.selectFilterClass.Location = new global::System.Drawing.Point(21, 102);
			this.selectFilterClass.Name = "selectFilterClass";
			this.selectFilterClass.Size = new global::System.Drawing.Size(168, 30);
			this.selectFilterClass.TabIndex = 148;
			this.panelFilterGame.Controls.Add(this.btnFilterGame);
			this.panelFilterGame.Controls.Add(this.checkFilterClassic);
			this.panelFilterGame.Controls.Add(this.checkFilterClassicEra);
			this.panelFilterGame.Controls.Add(this.checkFilterRetail);
			this.panelFilterGame.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelFilterGame.Location = new global::System.Drawing.Point(0, 42);
			this.panelFilterGame.Name = "panelFilterGame";
			this.panelFilterGame.Size = new global::System.Drawing.Size(211, 146);
			this.panelFilterGame.TabIndex = 60;
			this.btnFilterGame.BackColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterGame.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnFilterGame.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnFilterGame.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnFilterGame.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnFilterGame.FillColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterGame.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnFilterGame.ForeColor = global::System.Drawing.Color.White;
			this.btnFilterGame.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterGame.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterGame.HoverState.FillColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnFilterGame.Image = global::Jack.Properties.Resources.store_game_24;
			this.btnFilterGame.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnFilterGame.ImageOffset = new global::System.Drawing.Point(6, 0);
			this.btnFilterGame.ImageSize = new global::System.Drawing.Size(24, 24);
			this.btnFilterGame.Location = new global::System.Drawing.Point(0, 0);
			this.btnFilterGame.Name = "btnFilterGame";
			this.btnFilterGame.PressedDepth = 0;
			this.btnFilterGame.Size = new global::System.Drawing.Size(211, 42);
			this.btnFilterGame.TabIndex = 0;
			this.btnFilterGame.Text = "Game";
			this.btnFilterGame.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnFilterGame.TextOffset = new global::System.Drawing.Point(8, 0);
			this.checkFilterClassic.Animated = true;
			this.checkFilterClassic.AutoSize = true;
			this.checkFilterClassic.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFilterClassic.Checked = true;
			this.checkFilterClassic.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFilterClassic.CheckedState.BorderRadius = 0;
			this.checkFilterClassic.CheckedState.BorderThickness = 0;
			this.checkFilterClassic.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFilterClassic.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFilterClassic.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkFilterClassic.ForeColor = global::System.Drawing.Color.White;
			this.checkFilterClassic.Location = new global::System.Drawing.Point(21, 60);
			this.checkFilterClassic.Name = "checkFilterClassic";
			this.checkFilterClassic.Size = new global::System.Drawing.Size(62, 19);
			this.checkFilterClassic.TabIndex = 35;
			this.checkFilterClassic.Text = "Classic";
			this.checkFilterClassic.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkFilterClassic.UncheckedState.BorderRadius = 0;
			this.checkFilterClassic.UncheckedState.BorderThickness = 1;
			this.checkFilterClassic.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkFilterClassic.UseVisualStyleBackColor = false;
			this.checkFilterClassic.CheckedChanged += new global::System.EventHandler(this.checkFilterClassic_CheckedChanged);
			this.checkFilterClassicEra.Animated = true;
			this.checkFilterClassicEra.AutoSize = true;
			this.checkFilterClassicEra.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFilterClassicEra.Checked = true;
			this.checkFilterClassicEra.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFilterClassicEra.CheckedState.BorderRadius = 0;
			this.checkFilterClassicEra.CheckedState.BorderThickness = 0;
			this.checkFilterClassicEra.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFilterClassicEra.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFilterClassicEra.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkFilterClassicEra.ForeColor = global::System.Drawing.Color.White;
			this.checkFilterClassicEra.Location = new global::System.Drawing.Point(21, 85);
			this.checkFilterClassicEra.Name = "checkFilterClassicEra";
			this.checkFilterClassicEra.Size = new global::System.Drawing.Size(116, 19);
			this.checkFilterClassicEra.TabIndex = 36;
			this.checkFilterClassicEra.Text = "Classic Era (SoM)";
			this.checkFilterClassicEra.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkFilterClassicEra.UncheckedState.BorderRadius = 0;
			this.checkFilterClassicEra.UncheckedState.BorderThickness = 1;
			this.checkFilterClassicEra.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkFilterClassicEra.UseVisualStyleBackColor = false;
			this.checkFilterClassicEra.CheckedChanged += new global::System.EventHandler(this.checkFilterClassicEra_CheckedChanged);
			this.checkFilterRetail.Animated = true;
			this.checkFilterRetail.AutoSize = true;
			this.checkFilterRetail.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFilterRetail.Checked = true;
			this.checkFilterRetail.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFilterRetail.CheckedState.BorderRadius = 0;
			this.checkFilterRetail.CheckedState.BorderThickness = 0;
			this.checkFilterRetail.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFilterRetail.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFilterRetail.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkFilterRetail.ForeColor = global::System.Drawing.Color.White;
			this.checkFilterRetail.Location = new global::System.Drawing.Point(21, 110);
			this.checkFilterRetail.Name = "checkFilterRetail";
			this.checkFilterRetail.Size = new global::System.Drawing.Size(55, 19);
			this.checkFilterRetail.TabIndex = 37;
			this.checkFilterRetail.Text = "Retail";
			this.checkFilterRetail.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkFilterRetail.UncheckedState.BorderRadius = 0;
			this.checkFilterRetail.UncheckedState.BorderThickness = 1;
			this.checkFilterRetail.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkFilterRetail.UseVisualStyleBackColor = false;
			this.checkFilterRetail.CheckedChanged += new global::System.EventHandler(this.checkFilterRetail_CheckedChanged);
			this.btnDashboard.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnDashboard.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.btnDashboard.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnDashboard.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnDashboard.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnDashboard.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnDashboard.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnDashboard.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnDashboard.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnDashboard.ForeColor = global::System.Drawing.Color.White;
			this.btnDashboard.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnDashboard.HoverState.CustomBorderColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.btnDashboard.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnDashboard.Image = global::Jack.Properties.Resources.store_home_24;
			this.btnDashboard.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDashboard.ImageOffset = new global::System.Drawing.Point(8, 0);
			this.btnDashboard.Location = new global::System.Drawing.Point(0, 0);
			this.btnDashboard.Name = "btnDashboard";
			this.btnDashboard.PressedDepth = 0;
			this.btnDashboard.Size = new global::System.Drawing.Size(211, 42);
			this.btnDashboard.TabIndex = 160;
			this.btnDashboard.Text = "Dashboard";
			this.btnDashboard.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnDashboard.TextOffset = new global::System.Drawing.Point(11, 0);
			this.btnDashboard.Click += new global::System.EventHandler(this.btnDashboard_Click);
			this.panelContent.BorderRadius = 4;
			this.panelContent.Controls.Add(this.imgSizer);
			this.panelContent.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelContent.Location = new global::System.Drawing.Point(211, 100);
			this.panelContent.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new global::System.Drawing.Size(809, 565);
			this.panelContent.TabIndex = 60;
			this.imgSizer.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgSizer.Cursor = global::System.Windows.Forms.Cursors.SizeNWSE;
			this.imgSizer.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.imgSizer.ImageRotate = 0f;
			this.imgSizer.Location = new global::System.Drawing.Point(795, 560);
			this.imgSizer.Name = "imgSizer";
			this.imgSizer.Padding = new global::System.Windows.Forms.Padding(0, 0, 5, 5);
			this.imgSizer.Size = new global::System.Drawing.Size(14, 5);
			this.imgSizer.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgSizer.TabIndex = 59;
			this.imgSizer.TabStop = false;
			this.imgSizer.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.imgSizer_MouseDown);
			this.imgSizer.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.imgSizer_MouseMove);
			this.imgSizer.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.imgSizer_MouseUp);
			this.panelAutoComplete.BackColor = global::System.Drawing.Color.Transparent;
			this.panelAutoComplete.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.panelAutoComplete.BorderRadius = 4;
			this.panelAutoComplete.BorderThickness = 1;
			this.panelAutoComplete.Controls.Add(this.panelSearchResult);
			this.panelAutoComplete.CustomBorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.panelAutoComplete.CustomBorderThickness = new global::System.Windows.Forms.Padding(1);
			this.panelAutoComplete.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelAutoComplete.Location = new global::System.Drawing.Point(228, 114);
			this.panelAutoComplete.Name = "panelAutoComplete";
			this.panelAutoComplete.Padding = new global::System.Windows.Forms.Padding(3);
			this.panelAutoComplete.Size = new global::System.Drawing.Size(467, 42);
			this.panelAutoComplete.TabIndex = 60;
			this.panelAutoComplete.Visible = false;
			this.panelSearchResult.BackColor = global::System.Drawing.Color.Transparent;
			this.panelSearchResult.BorderColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelSearchResult.BorderRadius = 4;
			this.panelSearchResult.BorderThickness = 1;
			this.panelSearchResult.Controls.Add(this.lblSearchResultType);
			this.panelSearchResult.Controls.Add(this.lblSearchResultName);
			this.panelSearchResult.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.panelSearchResult.CustomBorderColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelSearchResult.CustomBorderThickness = new global::System.Windows.Forms.Padding(1);
			this.panelSearchResult.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelSearchResult.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelSearchResult.Location = new global::System.Drawing.Point(3, 3);
			this.panelSearchResult.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelSearchResult.Name = "panelSearchResult";
			this.panelSearchResult.Size = new global::System.Drawing.Size(461, 36);
			this.panelSearchResult.TabIndex = 61;
			this.panelSearchResult.Visible = false;
			this.lblSearchResultType.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblSearchResultType.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblSearchResultType.ForeColor = global::System.Drawing.Color.Gray;
			this.lblSearchResultType.Location = new global::System.Drawing.Point(333, 8);
			this.lblSearchResultType.Name = "lblSearchResultType";
			this.lblSearchResultType.Size = new global::System.Drawing.Size(120, 19);
			this.lblSearchResultType.TabIndex = 62;
			this.lblSearchResultType.Text = "Search Type";
			this.lblSearchResultType.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblSearchResultName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblSearchResultName.AutoEllipsis = true;
			this.lblSearchResultName.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblSearchResultName.ForeColor = global::System.Drawing.Color.White;
			this.lblSearchResultName.Location = new global::System.Drawing.Point(8, 6);
			this.lblSearchResultName.Name = "lblSearchResultName";
			this.lblSearchResultName.Size = new global::System.Drawing.Size(319, 23);
			this.lblSearchResultName.TabIndex = 61;
			this.lblSearchResultName.Text = "Search Result";
			this.lblSearchResultName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.panelInfo.BackColor = global::System.Drawing.Color.FromArgb(22, 26, 33);
			this.panelInfo.BorderRadius = 4;
			this.panelInfo.Controls.Add(this.lblInfo);
			this.panelInfo.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelInfo.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.panelInfo.Location = new global::System.Drawing.Point(211, 50);
			this.panelInfo.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new global::System.Drawing.Size(809, 42);
			this.panelInfo.TabIndex = 61;
			this.panelInfo.Visible = false;
			this.lblInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.lblInfo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblInfo.Location = new global::System.Drawing.Point(0, 0);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new global::System.Drawing.Size(809, 42);
			this.lblInfo.TabIndex = 60;
			this.lblInfo.Text = "Search Result Info";
			this.lblInfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panelInfoSpacer.BorderRadius = 4;
			this.panelInfoSpacer.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelInfoSpacer.Location = new global::System.Drawing.Point(211, 92);
			this.panelInfoSpacer.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelInfoSpacer.Name = "panelInfoSpacer";
			this.panelInfoSpacer.Size = new global::System.Drawing.Size(809, 8);
			this.panelInfoSpacer.TabIndex = 62;
			this.panelInfoSpacer.Visible = false;
			this.panelMenuCoins.BorderColor = global::System.Drawing.Color.SteelBlue;
			this.panelMenuCoins.BorderThickness = 1;
			this.panelMenuCoins.Controls.Add(this.btnMenuCoinsClose);
			this.panelMenuCoins.Controls.Add(this.btnMenuCoinsGet);
			this.panelMenuCoins.Controls.Add(this.btnMenuCoinsWeb);
			this.panelMenuCoins.Location = new global::System.Drawing.Point(779, 114);
			this.panelMenuCoins.Name = "panelMenuCoins";
			this.panelMenuCoins.Padding = new global::System.Windows.Forms.Padding(1);
			this.panelMenuCoins.Size = new global::System.Drawing.Size(151, 92);
			this.panelMenuCoins.TabIndex = 60;
			this.panelMenuCoins.Visible = false;
			this.btnMenuCoinsClose.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMenuCoinsClose.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMenuCoinsClose.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnMenuCoinsClose.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMenuCoinsClose.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnMenuCoinsClose.FillColor = global::System.Drawing.Color.Black;
			this.btnMenuCoinsClose.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMenuCoinsClose.ForeColor = global::System.Drawing.Color.Gray;
			this.btnMenuCoinsClose.HoverState.FillColor = global::System.Drawing.Color.FromArgb(33, 33, 33);
			this.btnMenuCoinsClose.Location = new global::System.Drawing.Point(1, 61);
			this.btnMenuCoinsClose.Name = "btnMenuCoinsClose";
			this.btnMenuCoinsClose.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnMenuCoinsClose.Size = new global::System.Drawing.Size(149, 30);
			this.btnMenuCoinsClose.TabIndex = 3;
			this.btnMenuCoinsClose.Text = "Close";
			this.btnMenuCoinsClose.Click += new global::System.EventHandler(this.btnMenuCoinsClose_Click);
			this.btnMenuCoinsGet.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMenuCoinsGet.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMenuCoinsGet.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnMenuCoinsGet.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMenuCoinsGet.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnMenuCoinsGet.FillColor = global::System.Drawing.Color.Black;
			this.btnMenuCoinsGet.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMenuCoinsGet.ForeColor = global::System.Drawing.Color.White;
			this.btnMenuCoinsGet.HoverState.FillColor = global::System.Drawing.Color.SteelBlue;
			this.btnMenuCoinsGet.Location = new global::System.Drawing.Point(1, 31);
			this.btnMenuCoinsGet.Name = "btnMenuCoinsGet";
			this.btnMenuCoinsGet.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnMenuCoinsGet.Size = new global::System.Drawing.Size(149, 30);
			this.btnMenuCoinsGet.TabIndex = 0;
			this.btnMenuCoinsGet.Text = "Get Jack Coins";
			this.btnMenuCoinsGet.Click += new global::System.EventHandler(this.btnMenuCoinsGet_Click);
			this.btnMenuCoinsWeb.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMenuCoinsWeb.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMenuCoinsWeb.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnMenuCoinsWeb.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMenuCoinsWeb.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnMenuCoinsWeb.FillColor = global::System.Drawing.Color.Black;
			this.btnMenuCoinsWeb.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMenuCoinsWeb.ForeColor = global::System.Drawing.Color.White;
			this.btnMenuCoinsWeb.HoverState.FillColor = global::System.Drawing.Color.SteelBlue;
			this.btnMenuCoinsWeb.Location = new global::System.Drawing.Point(1, 1);
			this.btnMenuCoinsWeb.Name = "btnMenuCoinsWeb";
			this.btnMenuCoinsWeb.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnMenuCoinsWeb.Size = new global::System.Drawing.Size(149, 30);
			this.btnMenuCoinsWeb.TabIndex = 4;
			this.btnMenuCoinsWeb.Text = "Web Version";
			this.btnMenuCoinsWeb.Click += new global::System.EventHandler(this.btnMenuCoinsWeb_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(1020, 665);
			base.Controls.Add(this.panelMenuCoins);
			base.Controls.Add(this.panelAutoComplete);
			base.Controls.Add(this.panelContent);
			base.Controls.Add(this.panelInfoSpacer);
			base.Controls.Add(this.panelInfo);
			base.Controls.Add(this.panelMenu);
			base.Controls.Add(this.panelHeader);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(1020, 665);
			base.Name = "frmStore";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmStore";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmStore_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmStore_FormClosed);
			base.Load += new global::System.EventHandler(this.frmStore_Load);
			base.Shown += new global::System.EventHandler(this.frmStore_Shown);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.panelActionBar.ResumeLayout(false);
			this.panelCoins.ResumeLayout(false);
			this.imgCoin.EndInit();
			this.panelMenu.ResumeLayout(false);
			this.panelMenu.PerformLayout();
			this.panelFilterProfile.ResumeLayout(false);
			this.panelFilterProfile.PerformLayout();
			this.panelFilterCharacter.ResumeLayout(false);
			this.panelFilterGame.ResumeLayout(false);
			this.panelFilterGame.PerformLayout();
			this.panelContent.ResumeLayout(false);
			this.imgSizer.EndInit();
			this.panelAutoComplete.ResumeLayout(false);
			this.panelSearchResult.ResumeLayout(false);
			this.panelInfo.ResumeLayout(false);
			this.panelMenuCoins.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000425 RID: 1061
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000426 RID: 1062
		private global::Guna.UI2.WinForms.Guna2Panel panelHeader;

		// Token: 0x04000427 RID: 1063
		private global::Guna.UI2.WinForms.Guna2Panel panelMenu;

		// Token: 0x04000428 RID: 1064
		private global::Guna.UI2.WinForms.Guna2Panel panelActionBar;

		// Token: 0x04000429 RID: 1065
		private global::Guna.UI2.WinForms.Guna2ImageButton imgClose;

		// Token: 0x0400042A RID: 1066
		private global::Guna.UI2.WinForms.Guna2ImageButton imgMinimize;

		// Token: 0x0400042B RID: 1067
		private global::Guna.UI2.WinForms.Guna2VSeparator panelActionBarSep1;

		// Token: 0x0400042C RID: 1068
		private global::Guna.UI2.WinForms.Guna2ImageButton btnStore;

		// Token: 0x0400042D RID: 1069
		private global::System.Windows.Forms.Label lblStore;

		// Token: 0x0400042E RID: 1070
		private global::Guna.UI2.WinForms.Guna2TextBox txtSearch;

		// Token: 0x0400042F RID: 1071
		private global::Guna.UI2.WinForms.Guna2PictureBox imgSizer;

		// Token: 0x04000430 RID: 1072
		private global::Guna.UI2.WinForms.Guna2Panel panelContent;

		// Token: 0x04000431 RID: 1073
		private global::Guna.UI2.WinForms.Guna2Panel panelAutoComplete;

		// Token: 0x04000432 RID: 1074
		private global::Guna.UI2.WinForms.Guna2Panel panelSearchResult;

		// Token: 0x04000433 RID: 1075
		private global::System.Windows.Forms.Label lblSearchResultType;

		// Token: 0x04000434 RID: 1076
		private global::System.Windows.Forms.Label lblSearchResultName;

		// Token: 0x04000435 RID: 1077
		private global::Guna.UI2.WinForms.Guna2PictureBox imgCoin;

		// Token: 0x04000436 RID: 1078
		private global::System.Windows.Forms.Label lblCoins;

		// Token: 0x04000437 RID: 1079
		private global::Guna.UI2.WinForms.Guna2Panel panelCoins;

		// Token: 0x04000438 RID: 1080
		private global::Guna.UI2.WinForms.Guna2Panel panelInfo;

		// Token: 0x04000439 RID: 1081
		private global::System.Windows.Forms.Label lblInfo;

		// Token: 0x0400043A RID: 1082
		private global::Guna.UI2.WinForms.Guna2Panel panelInfoSpacer;

		// Token: 0x0400043B RID: 1083
		private global::Guna.UI2.WinForms.Guna2Button btnFilterGame;

		// Token: 0x0400043C RID: 1084
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFilterClassic;

		// Token: 0x0400043D RID: 1085
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFilterRetail;

		// Token: 0x0400043E RID: 1086
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFilterClassicEra;

		// Token: 0x0400043F RID: 1087
		private global::Guna.UI2.WinForms.Guna2Button btnFilterCharacter;

		// Token: 0x04000440 RID: 1088
		private global::Guna.UI2.WinForms.Guna2ComboBox selectFilterProfileSubType;

		// Token: 0x04000441 RID: 1089
		private global::Guna.UI2.WinForms.Guna2Button btnFilterProfile;

		// Token: 0x04000442 RID: 1090
		private global::Guna.UI2.WinForms.Guna2ComboBox selectFilterClass;

		// Token: 0x04000443 RID: 1091
		private global::Guna.UI2.WinForms.Guna2ComboBox selectFilterFaction;

		// Token: 0x04000444 RID: 1092
		private global::Guna.UI2.WinForms.Guna2Panel panelFilterProfile;

		// Token: 0x04000445 RID: 1093
		private global::Guna.UI2.WinForms.Guna2ComboBox selectFilterProfileType;

		// Token: 0x04000446 RID: 1094
		private global::Guna.UI2.WinForms.Guna2Panel panelFilterCharacter;

		// Token: 0x04000447 RID: 1095
		private global::Guna.UI2.WinForms.Guna2Panel panelFilterGame;

		// Token: 0x04000448 RID: 1096
		private global::System.Windows.Forms.Label lblFilterRequiredSkill;

		// Token: 0x04000449 RID: 1097
		private global::Guna.UI2.WinForms.Guna2TextBox txtFilterRequiredSkill;

		// Token: 0x0400044A RID: 1098
		private global::System.Windows.Forms.Label lblFilterRequiredLevel;

		// Token: 0x0400044B RID: 1099
		private global::Guna.UI2.WinForms.Guna2TextBox txtFilterRequiredLevel;

		// Token: 0x0400044C RID: 1100
		private global::Guna.UI2.WinForms.Guna2Button btnFilter;

		// Token: 0x0400044D RID: 1101
		private global::System.Windows.Forms.Label lblResetFilter;

		// Token: 0x0400044E RID: 1102
		private global::Guna.UI2.WinForms.Guna2Button btnBack;

		// Token: 0x0400044F RID: 1103
		private global::Guna.UI2.WinForms.Guna2Button btnDelete;

		// Token: 0x04000450 RID: 1104
		private global::Guna.UI2.WinForms.Guna2Button btnDashboard;

		// Token: 0x04000451 RID: 1105
		private global::Guna.UI2.WinForms.Guna2Button btnRefresh;

		// Token: 0x04000452 RID: 1106
		private global::Guna.UI2.WinForms.Guna2Panel panelMenuCoins;

		// Token: 0x04000453 RID: 1107
		private global::Guna.UI2.WinForms.Guna2Button btnMenuCoinsClose;

		// Token: 0x04000454 RID: 1108
		private global::Guna.UI2.WinForms.Guna2Button btnMenuCoinsGet;

		// Token: 0x04000455 RID: 1109
		private global::Guna.UI2.WinForms.Guna2Button btnMenuCoinsWeb;
	}
}
