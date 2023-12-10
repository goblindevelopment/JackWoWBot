namespace Jack
{
	// Token: 0x0200000E RID: 14
	public partial class frmMain : global::System.Windows.Forms.Form
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00666E18 File Offset: 0x00665018
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00666E44 File Offset: 0x00665044
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.frmMain));
			this.richConsole = new global::System.Windows.Forms.RichTextBox();
			this.panelHeader = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelAccount = new global::Guna.UI2.WinForms.Guna2Panel();
			this.sepAccount = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.btnModuleGather = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.btnStore = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.btnModuleNotifications = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.radioMenuAccount = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnModuleSession = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.btnModuleDungeon = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.panelActionBar = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnMessages = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgClose = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.imgMinimize = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.sepActionBar = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.lblMainTitle = new global::System.Windows.Forms.Label();
			this.panelMenu = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelMainMenuButtons = new global::Guna.UI2.WinForms.Guna2Panel();
			this.radioMenuSettings = new global::Guna.UI2.WinForms.Guna2Button();
			this.radioMenuAddon = new global::Guna.UI2.WinForms.Guna2Button();
			this.radioMenuOverlay = new global::Guna.UI2.WinForms.Guna2Button();
			this.radioMenuKeybinds = new global::Guna.UI2.WinForms.Guna2Button();
			this.radioMenuRotations = new global::Guna.UI2.WinForms.Guna2Button();
			this.radioMenuProfiles = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelContent = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelBottom = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblCancel = new global::System.Windows.Forms.Label();
			this.lblStatus1 = new global::System.Windows.Forms.Label();
			this.panelBtnStart = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnAttach = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnStart = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnTest2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnTest1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgSizer = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelTeam = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnTeamClose = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnTeamReloadCOS = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnTeamStore = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnTeamTools = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnTeamAccount = new global::Guna.UI2.WinForms.Guna2Button();
			this.trayIcon = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.panelHeader.SuspendLayout();
			this.panelAccount.SuspendLayout();
			this.panelActionBar.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.panelMainMenuButtons.SuspendLayout();
			this.panelBottom.SuspendLayout();
			this.panelBtnStart.SuspendLayout();
			this.imgSizer.BeginInit();
			this.panelTeam.SuspendLayout();
			base.SuspendLayout();
			this.richConsole.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richConsole.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.richConsole.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richConsole.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.richConsole.ForeColor = global::System.Drawing.Color.White;
			this.richConsole.Location = new global::System.Drawing.Point(25, 18);
			this.richConsole.Name = "richConsole";
			this.richConsole.ReadOnly = true;
			this.richConsole.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richConsole.Size = new global::System.Drawing.Size(601, 69);
			this.richConsole.TabIndex = 10;
			this.richConsole.Text = "";
			this.richConsole.TextChanged += new global::System.EventHandler(this.richConsole_TextChanged);
			this.richConsole.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.richConsole_MouseDoubleClick);
			this.panelHeader.Controls.Add(this.panelAccount);
			this.panelHeader.Controls.Add(this.panelActionBar);
			this.panelHeader.Controls.Add(this.lblMainTitle);
			this.panelHeader.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new global::System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new global::System.Drawing.Size(940, 50);
			this.panelHeader.TabIndex = 58;
			this.panelAccount.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelAccount.Controls.Add(this.sepAccount);
			this.panelAccount.Controls.Add(this.btnModuleGather);
			this.panelAccount.Controls.Add(this.btnStore);
			this.panelAccount.Controls.Add(this.btnModuleNotifications);
			this.panelAccount.Controls.Add(this.radioMenuAccount);
			this.panelAccount.Controls.Add(this.btnModuleSession);
			this.panelAccount.Controls.Add(this.btnModuleDungeon);
			this.panelAccount.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.panelAccount.Location = new global::System.Drawing.Point(0, 0);
			this.panelAccount.Name = "panelAccount";
			this.panelAccount.Size = new global::System.Drawing.Size(344, 50);
			this.panelAccount.TabIndex = 9;
			this.sepAccount.FillColor = global::System.Drawing.Color.FromArgb(28, 35, 64);
			this.sepAccount.Location = new global::System.Drawing.Point(96, 12);
			this.sepAccount.Name = "sepAccount";
			this.sepAccount.Size = new global::System.Drawing.Size(6, 26);
			this.sepAccount.TabIndex = 4;
			this.btnModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.btnModuleGather.CheckedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleGather.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.btnModuleGather.HoverState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleGather.Image = global::Jack.Properties.Resources.btn_module_gather;
			this.btnModuleGather.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.btnModuleGather.ImageRotate = 0f;
			this.btnModuleGather.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleGather.Location = new global::System.Drawing.Point(112, 10);
			this.btnModuleGather.Name = "btnModuleGather";
			this.btnModuleGather.PressedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleGather.Size = new global::System.Drawing.Size(39, 28);
			this.btnModuleGather.TabIndex = 3;
			this.btnModuleGather.Click += new global::System.EventHandler(this.btnModuleGather_Click);
			this.btnStore.CheckedState.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.btnStore.HoverState.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.Image = global::Jack.Properties.Resources.shopping_bag_21;
			this.btnStore.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.btnStore.ImageRotate = 0f;
			this.btnStore.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.Location = new global::System.Drawing.Point(53, 8);
			this.btnStore.Name = "btnStore";
			this.btnStore.PressedState.ImageSize = new global::System.Drawing.Size(21, 21);
			this.btnStore.Size = new global::System.Drawing.Size(32, 32);
			this.btnStore.TabIndex = 2;
			this.btnStore.Click += new global::System.EventHandler(this.btnStore_Click);
			this.btnModuleNotifications.BackColor = global::System.Drawing.Color.Transparent;
			this.btnModuleNotifications.CheckedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleNotifications.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.btnModuleNotifications.HoverState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleNotifications.Image = global::Jack.Properties.Resources.btn_module_notify;
			this.btnModuleNotifications.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.btnModuleNotifications.ImageRotate = 0f;
			this.btnModuleNotifications.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleNotifications.Location = new global::System.Drawing.Point(280, 10);
			this.btnModuleNotifications.Name = "btnModuleNotifications";
			this.btnModuleNotifications.PressedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleNotifications.Size = new global::System.Drawing.Size(39, 28);
			this.btnModuleNotifications.TabIndex = 4;
			this.btnModuleNotifications.Click += new global::System.EventHandler(this.btnModuleNotifications_Click);
			this.radioMenuAccount.BackColor = global::System.Drawing.Color.Transparent;
			this.radioMenuAccount.ButtonMode = 1;
			this.radioMenuAccount.CheckedState.CustomBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuAccount.CheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.radioMenuAccount.CheckedState.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuAccount.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.radioMenuAccount.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuAccount.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuAccount.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.radioMenuAccount.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.radioMenuAccount.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.radioMenuAccount.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.radioMenuAccount.ForeColor = global::System.Drawing.Color.White;
			this.radioMenuAccount.HoverState.CustomBorderColor = global::System.Drawing.Color.White;
			this.radioMenuAccount.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.radioMenuAccount.Image = global::Jack.Properties.Resources.account_24;
			this.radioMenuAccount.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.radioMenuAccount.ImageSize = new global::System.Drawing.Size(24, 24);
			this.radioMenuAccount.Location = new global::System.Drawing.Point(16, 10);
			this.radioMenuAccount.Name = "radioMenuAccount";
			this.radioMenuAccount.Size = new global::System.Drawing.Size(32, 32);
			this.radioMenuAccount.TabIndex = 1;
			this.radioMenuAccount.CheckedChanged += new global::System.EventHandler(this.RadioButtons_CheckedChanged);
			this.radioMenuAccount.Click += new global::System.EventHandler(this.btnAccount_Click);
			this.btnModuleSession.BackColor = global::System.Drawing.Color.Transparent;
			this.btnModuleSession.CheckedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleSession.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.btnModuleSession.HoverState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleSession.Image = global::Jack.Properties.Resources.btn_module_session;
			this.btnModuleSession.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.btnModuleSession.ImageRotate = 0f;
			this.btnModuleSession.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleSession.Location = new global::System.Drawing.Point(224, 10);
			this.btnModuleSession.Name = "btnModuleSession";
			this.btnModuleSession.PressedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleSession.Size = new global::System.Drawing.Size(39, 28);
			this.btnModuleSession.TabIndex = 3;
			this.btnModuleSession.Click += new global::System.EventHandler(this.btnModuleSession_Click);
			this.btnModuleDungeon.BackColor = global::System.Drawing.Color.Transparent;
			this.btnModuleDungeon.CheckedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleDungeon.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.btnModuleDungeon.HoverState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleDungeon.Image = global::Jack.Properties.Resources.btn_module_dungeon;
			this.btnModuleDungeon.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.btnModuleDungeon.ImageRotate = 0f;
			this.btnModuleDungeon.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleDungeon.Location = new global::System.Drawing.Point(168, 10);
			this.btnModuleDungeon.Name = "btnModuleDungeon";
			this.btnModuleDungeon.PressedState.ImageSize = new global::System.Drawing.Size(39, 28);
			this.btnModuleDungeon.Size = new global::System.Drawing.Size(39, 28);
			this.btnModuleDungeon.TabIndex = 2;
			this.btnModuleDungeon.Click += new global::System.EventHandler(this.btnModuleDungeon_Click);
			this.panelActionBar.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelActionBar.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelActionBar.Controls.Add(this.btnMessages);
			this.panelActionBar.Controls.Add(this.imgClose);
			this.panelActionBar.Controls.Add(this.imgMinimize);
			this.panelActionBar.Controls.Add(this.sepActionBar);
			this.panelActionBar.Location = new global::System.Drawing.Point(673, 0);
			this.panelActionBar.Name = "panelActionBar";
			this.panelActionBar.Size = new global::System.Drawing.Size(267, 50);
			this.panelActionBar.TabIndex = 7;
			this.btnMessages.BackColor = global::System.Drawing.Color.Transparent;
			this.btnMessages.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMessages.BorderRadius = 4;
			this.btnMessages.ButtonMode = 1;
			this.btnMessages.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMessages.CheckedState.CustomBorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMessages.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(45, 54, 69);
			this.btnMessages.CheckedState.ForeColor = global::System.Drawing.Color.Gray;
			this.btnMessages.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMessages.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMessages.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnMessages.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnMessages.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMessages.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMessages.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMessages.ForeColor = global::System.Drawing.Color.Gray;
			this.btnMessages.HoverState.FillColor = global::System.Drawing.Color.FromArgb(45, 54, 69);
			this.btnMessages.Location = new global::System.Drawing.Point(40, 13);
			this.btnMessages.Name = "btnMessages";
			this.btnMessages.Padding = new global::System.Windows.Forms.Padding(0, 0, 0, 1);
			this.btnMessages.Size = new global::System.Drawing.Size(117, 23);
			this.btnMessages.TabIndex = 0;
			this.btnMessages.Text = "0 Messages";
			this.btnMessages.Click += new global::System.EventHandler(this.btnMessages_Click);
			this.imgClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgClose.CheckedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.HoverState.ImageOffset = new global::System.Drawing.Point(0, -1);
			this.imgClose.HoverState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Image = global::Jack.Properties.Resources.close_16;
			this.imgClose.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgClose.ImageRotate = 0f;
			this.imgClose.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgClose.Location = new global::System.Drawing.Point(223, 9);
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
			this.imgMinimize.Location = new global::System.Drawing.Point(185, 9);
			this.imgMinimize.Name = "imgMinimize";
			this.imgMinimize.PressedState.ImageSize = new global::System.Drawing.Size(16, 16);
			this.imgMinimize.Size = new global::System.Drawing.Size(32, 32);
			this.imgMinimize.TabIndex = 2;
			this.imgMinimize.Click += new global::System.EventHandler(this.imgMinimize_Click);
			this.sepActionBar.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepActionBar.FillColor = global::System.Drawing.Color.FromArgb(28, 35, 64);
			this.sepActionBar.Location = new global::System.Drawing.Point(169, 12);
			this.sepActionBar.Name = "sepActionBar";
			this.sepActionBar.Size = new global::System.Drawing.Size(10, 26);
			this.sepActionBar.TabIndex = 3;
			this.lblMainTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblMainTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.lblMainTitle.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblMainTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblMainTitle.Location = new global::System.Drawing.Point(346, 0);
			this.lblMainTitle.Name = "lblMainTitle";
			this.lblMainTitle.Size = new global::System.Drawing.Size(325, 50);
			this.lblMainTitle.TabIndex = 0;
			this.lblMainTitle.Text = "Jack";
			this.lblMainTitle.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMainTitle.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
			this.panelMenu.BackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelMenu.Controls.Add(this.panelMainMenuButtons);
			this.panelMenu.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelMenu.Location = new global::System.Drawing.Point(0, 50);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.ShadowDecoration.Color = global::System.Drawing.Color.White;
			this.panelMenu.ShadowDecoration.Enabled = true;
			this.panelMenu.ShadowDecoration.Mode = 1;
			this.panelMenu.Size = new global::System.Drawing.Size(940, 50);
			this.panelMenu.TabIndex = 59;
			this.panelMainMenuButtons.Controls.Add(this.radioMenuSettings);
			this.panelMainMenuButtons.Controls.Add(this.radioMenuAddon);
			this.panelMainMenuButtons.Controls.Add(this.radioMenuOverlay);
			this.panelMainMenuButtons.Controls.Add(this.radioMenuKeybinds);
			this.panelMainMenuButtons.Controls.Add(this.radioMenuRotations);
			this.panelMainMenuButtons.Controls.Add(this.radioMenuProfiles);
			this.panelMainMenuButtons.Location = new global::System.Drawing.Point(175, 0);
			this.panelMainMenuButtons.Name = "panelMainMenuButtons";
			this.panelMainMenuButtons.Size = new global::System.Drawing.Size(604, 50);
			this.panelMainMenuButtons.TabIndex = 1;
			this.radioMenuSettings.ButtonMode = 1;
			this.radioMenuSettings.CheckedState.CustomBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuSettings.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuSettings.CheckedState.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuSettings.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.radioMenuSettings.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuSettings.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuSettings.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.radioMenuSettings.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.radioMenuSettings.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioMenuSettings.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuSettings.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.radioMenuSettings.ForeColor = global::System.Drawing.Color.White;
			this.radioMenuSettings.HoverState.CustomBorderColor = global::System.Drawing.Color.White;
			this.radioMenuSettings.HoverState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuSettings.Image = global::Jack.Properties.Resources.nav_settings;
			this.radioMenuSettings.ImageOffset = new global::System.Drawing.Point(-1, 0);
			this.radioMenuSettings.ImageSize = new global::System.Drawing.Size(14, 15);
			this.radioMenuSettings.Location = new global::System.Drawing.Point(510, 0);
			this.radioMenuSettings.Name = "radioMenuSettings";
			this.radioMenuSettings.Size = new global::System.Drawing.Size(100, 50);
			this.radioMenuSettings.TabIndex = 5;
			this.radioMenuSettings.Text = "Settings";
			this.radioMenuSettings.CheckedChanged += new global::System.EventHandler(this.RadioButtons_CheckedChanged);
			this.radioMenuSettings.Click += new global::System.EventHandler(this.radioMenuSettings_Click);
			this.radioMenuAddon.ButtonMode = 1;
			this.radioMenuAddon.CheckedState.CustomBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuAddon.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuAddon.CheckedState.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuAddon.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.radioMenuAddon.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuAddon.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuAddon.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.radioMenuAddon.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.radioMenuAddon.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioMenuAddon.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuAddon.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.radioMenuAddon.ForeColor = global::System.Drawing.Color.White;
			this.radioMenuAddon.HoverState.CustomBorderColor = global::System.Drawing.Color.White;
			this.radioMenuAddon.HoverState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuAddon.Image = global::Jack.Properties.Resources.nav_addon;
			this.radioMenuAddon.ImageOffset = new global::System.Drawing.Point(-1, 0);
			this.radioMenuAddon.ImageSize = new global::System.Drawing.Size(14, 15);
			this.radioMenuAddon.Location = new global::System.Drawing.Point(410, 0);
			this.radioMenuAddon.Name = "radioMenuAddon";
			this.radioMenuAddon.Size = new global::System.Drawing.Size(100, 50);
			this.radioMenuAddon.TabIndex = 4;
			this.radioMenuAddon.Text = "Addon";
			this.radioMenuAddon.CheckedChanged += new global::System.EventHandler(this.RadioButtons_CheckedChanged);
			this.radioMenuAddon.Click += new global::System.EventHandler(this.radioMenuAddon_Click);
			this.radioMenuOverlay.ButtonMode = 1;
			this.radioMenuOverlay.CheckedState.CustomBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuOverlay.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuOverlay.CheckedState.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuOverlay.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.radioMenuOverlay.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuOverlay.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuOverlay.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.radioMenuOverlay.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.radioMenuOverlay.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioMenuOverlay.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuOverlay.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.radioMenuOverlay.ForeColor = global::System.Drawing.Color.White;
			this.radioMenuOverlay.HoverState.CustomBorderColor = global::System.Drawing.Color.White;
			this.radioMenuOverlay.HoverState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuOverlay.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("radioMenuOverlay.Image");
			this.radioMenuOverlay.ImageOffset = new global::System.Drawing.Point(-1, 0);
			this.radioMenuOverlay.ImageSize = new global::System.Drawing.Size(14, 15);
			this.radioMenuOverlay.Location = new global::System.Drawing.Point(310, 0);
			this.radioMenuOverlay.Name = "radioMenuOverlay";
			this.radioMenuOverlay.Size = new global::System.Drawing.Size(100, 50);
			this.radioMenuOverlay.TabIndex = 3;
			this.radioMenuOverlay.Text = "Overlay";
			this.radioMenuOverlay.CheckedChanged += new global::System.EventHandler(this.RadioButtons_CheckedChanged);
			this.radioMenuOverlay.Click += new global::System.EventHandler(this.radioMenuOverlay_Click);
			this.radioMenuKeybinds.ButtonMode = 1;
			this.radioMenuKeybinds.CheckedState.CustomBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuKeybinds.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuKeybinds.CheckedState.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuKeybinds.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.radioMenuKeybinds.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuKeybinds.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuKeybinds.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.radioMenuKeybinds.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.radioMenuKeybinds.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioMenuKeybinds.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuKeybinds.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.radioMenuKeybinds.ForeColor = global::System.Drawing.Color.White;
			this.radioMenuKeybinds.HoverState.CustomBorderColor = global::System.Drawing.Color.White;
			this.radioMenuKeybinds.HoverState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuKeybinds.Image = global::Jack.Properties.Resources.nav_keybinds;
			this.radioMenuKeybinds.ImageOffset = new global::System.Drawing.Point(-1, 0);
			this.radioMenuKeybinds.ImageSize = new global::System.Drawing.Size(14, 15);
			this.radioMenuKeybinds.Location = new global::System.Drawing.Point(210, 0);
			this.radioMenuKeybinds.Name = "radioMenuKeybinds";
			this.radioMenuKeybinds.Size = new global::System.Drawing.Size(100, 50);
			this.radioMenuKeybinds.TabIndex = 2;
			this.radioMenuKeybinds.Text = "Keybinds";
			this.radioMenuKeybinds.CheckedChanged += new global::System.EventHandler(this.RadioButtons_CheckedChanged);
			this.radioMenuKeybinds.Click += new global::System.EventHandler(this.radioMenuKeybinds_Click);
			this.radioMenuRotations.ButtonMode = 1;
			this.radioMenuRotations.CheckedState.CustomBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuRotations.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuRotations.CheckedState.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuRotations.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.radioMenuRotations.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuRotations.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuRotations.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.radioMenuRotations.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.radioMenuRotations.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioMenuRotations.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuRotations.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.radioMenuRotations.ForeColor = global::System.Drawing.Color.White;
			this.radioMenuRotations.HoverState.CustomBorderColor = global::System.Drawing.Color.White;
			this.radioMenuRotations.HoverState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuRotations.Image = global::Jack.Properties.Resources.nav_rotations;
			this.radioMenuRotations.ImageOffset = new global::System.Drawing.Point(-2, 0);
			this.radioMenuRotations.ImageSize = new global::System.Drawing.Size(14, 15);
			this.radioMenuRotations.Location = new global::System.Drawing.Point(100, 0);
			this.radioMenuRotations.Name = "radioMenuRotations";
			this.radioMenuRotations.Size = new global::System.Drawing.Size(110, 50);
			this.radioMenuRotations.TabIndex = 1;
			this.radioMenuRotations.Text = "Rotations";
			this.radioMenuRotations.CheckedChanged += new global::System.EventHandler(this.RadioButtons_CheckedChanged);
			this.radioMenuRotations.Click += new global::System.EventHandler(this.radioMenuRotations_Click);
			this.radioMenuProfiles.ButtonMode = 1;
			this.radioMenuProfiles.Checked = true;
			this.radioMenuProfiles.CheckedState.CustomBorderColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuProfiles.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuProfiles.CheckedState.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.radioMenuProfiles.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 3);
			this.radioMenuProfiles.CustomImages.ImageSize = new global::System.Drawing.Size(13, 14);
			this.radioMenuProfiles.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuProfiles.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.radioMenuProfiles.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.radioMenuProfiles.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.radioMenuProfiles.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.radioMenuProfiles.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuProfiles.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.radioMenuProfiles.ForeColor = global::System.Drawing.Color.White;
			this.radioMenuProfiles.HoverState.CustomBorderColor = global::System.Drawing.Color.White;
			this.radioMenuProfiles.HoverState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.radioMenuProfiles.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("radioMenuProfiles.Image");
			this.radioMenuProfiles.ImageOffset = new global::System.Drawing.Point(-1, 0);
			this.radioMenuProfiles.ImageSize = new global::System.Drawing.Size(13, 14);
			this.radioMenuProfiles.Location = new global::System.Drawing.Point(0, 0);
			this.radioMenuProfiles.Name = "radioMenuProfiles";
			this.radioMenuProfiles.Size = new global::System.Drawing.Size(100, 50);
			this.radioMenuProfiles.TabIndex = 0;
			this.radioMenuProfiles.Text = "Profiles";
			this.radioMenuProfiles.CheckedChanged += new global::System.EventHandler(this.RadioButtons_CheckedChanged);
			this.radioMenuProfiles.Click += new global::System.EventHandler(this.radioMenuProfiles_Click);
			this.panelContent.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelContent.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelContent.Location = new global::System.Drawing.Point(0, 100);
			this.panelContent.Name = "panelContent";
			this.panelContent.Size = new global::System.Drawing.Size(940, 335);
			this.panelContent.TabIndex = 60;
			this.panelBottom.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelBottom.Controls.Add(this.lblCancel);
			this.panelBottom.Controls.Add(this.lblStatus1);
			this.panelBottom.Controls.Add(this.panelBtnStart);
			this.panelBottom.Controls.Add(this.btnTest2);
			this.panelBottom.Controls.Add(this.richConsole);
			this.panelBottom.Controls.Add(this.btnTest1);
			this.panelBottom.Controls.Add(this.imgSizer);
			this.panelBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new global::System.Drawing.Point(0, 435);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new global::System.Drawing.Size(940, 105);
			this.panelBottom.TabIndex = 61;
			this.lblCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblCancel.BackColor = global::System.Drawing.Color.Black;
			this.lblCancel.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblCancel.ForeColor = global::System.Drawing.Color.Red;
			this.lblCancel.Location = new global::System.Drawing.Point(487, 57);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Padding = new global::System.Windows.Forms.Padding(5);
			this.lblCancel.Size = new global::System.Drawing.Size(139, 25);
			this.lblCancel.TabIndex = 64;
			this.lblCancel.Text = "Click here to cancel.";
			this.lblCancel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblCancel.Visible = false;
			this.lblCancel.Click += new global::System.EventHandler(this.lblCancel_Click);
			this.lblStatus1.AutoSize = true;
			this.lblStatus1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblStatus1.ForeColor = global::System.Drawing.Color.White;
			this.lblStatus1.Location = new global::System.Drawing.Point(22, 87);
			this.lblStatus1.Name = "lblStatus1";
			this.lblStatus1.Size = new global::System.Drawing.Size(29, 15);
			this.lblStatus1.TabIndex = 63;
			this.lblStatus1.Text = "N/A";
			this.lblStatus1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStatus1.Visible = false;
			this.panelBtnStart.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnStart.BackgroundImage = global::Jack.Properties.Resources.btn_start_bg;
			this.panelBtnStart.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelBtnStart.Controls.Add(this.btnAttach);
			this.panelBtnStart.Controls.Add(this.btnStart);
			this.panelBtnStart.Location = new global::System.Drawing.Point(638, 0);
			this.panelBtnStart.Name = "panelBtnStart";
			this.panelBtnStart.Size = new global::System.Drawing.Size(280, 80);
			this.panelBtnStart.TabIndex = 0;
			this.btnAttach.BackColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.DisabledState.Image = global::Jack.Properties.Resources.btn_attach_disabled;
			this.btnAttach.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAttach.ForeColor = global::System.Drawing.Color.White;
			this.btnAttach.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAttach.HoverState.Image = global::Jack.Properties.Resources.btn_attach_hover;
			this.btnAttach.Image = global::Jack.Properties.Resources.btn_attach;
			this.btnAttach.ImageSize = new global::System.Drawing.Size(25, 64);
			this.btnAttach.Location = new global::System.Drawing.Point(240, 0);
			this.btnAttach.Name = "btnAttach";
			this.btnAttach.PressedDepth = 0;
			this.btnAttach.Size = new global::System.Drawing.Size(25, 64);
			this.btnAttach.TabIndex = 1;
			this.btnAttach.Visible = false;
			this.btnAttach.Click += new global::System.EventHandler(this.btnAttach_Click);
			this.btnStart.BackColor = global::System.Drawing.Color.Transparent;
			this.btnStart.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnStart.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnStart.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnStart.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnStart.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnStart.DisabledState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image");
			this.btnStart.FillColor = global::System.Drawing.Color.Transparent;
			this.btnStart.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnStart.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnStart.ForeColor = global::System.Drawing.Color.White;
			this.btnStart.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnStart.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnStart.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnStart.HoverState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image1");
			this.btnStart.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnStart.Image");
			this.btnStart.ImageSize = new global::System.Drawing.Size(230, 64);
			this.btnStart.Location = new global::System.Drawing.Point(35, 0);
			this.btnStart.Name = "btnStart";
			this.btnStart.PressedDepth = 0;
			this.btnStart.Size = new global::System.Drawing.Size(230, 64);
			this.btnStart.TabIndex = 0;
			this.btnStart.Click += new global::System.EventHandler(this.btnStart_Click);
			this.btnTest2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnTest2.BorderColor = global::System.Drawing.Color.Gray;
			this.btnTest2.BorderThickness = 1;
			this.btnTest2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTest2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTest2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnTest2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTest2.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnTest2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.btnTest2.ForeColor = global::System.Drawing.Color.White;
			this.btnTest2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnTest2.Location = new global::System.Drawing.Point(831, 83);
			this.btnTest2.Name = "btnTest2";
			this.btnTest2.Size = new global::System.Drawing.Size(87, 18);
			this.btnTest2.TabIndex = 61;
			this.btnTest2.Text = "Test 2";
			this.btnTest2.Visible = false;
			this.btnTest2.Click += new global::System.EventHandler(this.btnTest2_Click);
			this.btnTest1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnTest1.BorderColor = global::System.Drawing.Color.Gray;
			this.btnTest1.BorderThickness = 1;
			this.btnTest1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTest1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTest1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnTest1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTest1.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnTest1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.btnTest1.ForeColor = global::System.Drawing.Color.White;
			this.btnTest1.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnTest1.Location = new global::System.Drawing.Point(740, 83);
			this.btnTest1.Name = "btnTest1";
			this.btnTest1.Size = new global::System.Drawing.Size(87, 18);
			this.btnTest1.TabIndex = 60;
			this.btnTest1.Text = "Test 1";
			this.btnTest1.Visible = false;
			this.btnTest1.Click += new global::System.EventHandler(this.btnTest1_Click);
			this.imgSizer.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgSizer.Cursor = global::System.Windows.Forms.Cursors.SizeNWSE;
			this.imgSizer.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("imgSizer.Image");
			this.imgSizer.ImageRotate = 0f;
			this.imgSizer.Location = new global::System.Drawing.Point(922, 87);
			this.imgSizer.Name = "imgSizer";
			this.imgSizer.Padding = new global::System.Windows.Forms.Padding(0, 0, 5, 5);
			this.imgSizer.Size = new global::System.Drawing.Size(18, 18);
			this.imgSizer.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgSizer.TabIndex = 58;
			this.imgSizer.TabStop = false;
			this.imgSizer.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.imgSizer_MouseDown);
			this.imgSizer.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.imgSizer_MouseMove);
			this.imgSizer.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.imgSizer_MouseUp);
			this.panelTeam.BorderColor = global::System.Drawing.Color.SteelBlue;
			this.panelTeam.BorderThickness = 1;
			this.panelTeam.Controls.Add(this.btnTeamClose);
			this.panelTeam.Controls.Add(this.btnTeamReloadCOS);
			this.panelTeam.Controls.Add(this.btnTeamStore);
			this.panelTeam.Controls.Add(this.btnTeamTools);
			this.panelTeam.Controls.Add(this.btnTeamAccount);
			this.panelTeam.Location = new global::System.Drawing.Point(16, 115);
			this.panelTeam.Name = "panelTeam";
			this.panelTeam.Padding = new global::System.Windows.Forms.Padding(1);
			this.panelTeam.Size = new global::System.Drawing.Size(179, 152);
			this.panelTeam.TabIndex = 0;
			this.panelTeam.Visible = false;
			this.btnTeamClose.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamClose.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamClose.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnTeamClose.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTeamClose.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnTeamClose.FillColor = global::System.Drawing.Color.Black;
			this.btnTeamClose.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTeamClose.ForeColor = global::System.Drawing.Color.Gray;
			this.btnTeamClose.HoverState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamClose.Location = new global::System.Drawing.Point(1, 121);
			this.btnTeamClose.Name = "btnTeamClose";
			this.btnTeamClose.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamClose.Size = new global::System.Drawing.Size(177, 30);
			this.btnTeamClose.TabIndex = 3;
			this.btnTeamClose.Text = "Close";
			this.btnTeamClose.Click += new global::System.EventHandler(this.btnTeamClose_Click);
			this.btnTeamReloadCOS.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamReloadCOS.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamReloadCOS.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnTeamReloadCOS.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTeamReloadCOS.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnTeamReloadCOS.FillColor = global::System.Drawing.Color.Black;
			this.btnTeamReloadCOS.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTeamReloadCOS.ForeColor = global::System.Drawing.Color.White;
			this.btnTeamReloadCOS.HoverState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamReloadCOS.Location = new global::System.Drawing.Point(1, 91);
			this.btnTeamReloadCOS.Name = "btnTeamReloadCOS";
			this.btnTeamReloadCOS.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamReloadCOS.Size = new global::System.Drawing.Size(177, 30);
			this.btnTeamReloadCOS.TabIndex = 4;
			this.btnTeamReloadCOS.Text = "Reload Custom Offsets";
			this.btnTeamReloadCOS.Click += new global::System.EventHandler(this.btnTeamReloadCOS_Click);
			this.btnTeamStore.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamStore.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamStore.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnTeamStore.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTeamStore.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnTeamStore.FillColor = global::System.Drawing.Color.Black;
			this.btnTeamStore.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTeamStore.ForeColor = global::System.Drawing.Color.White;
			this.btnTeamStore.HoverState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamStore.Location = new global::System.Drawing.Point(1, 61);
			this.btnTeamStore.Name = "btnTeamStore";
			this.btnTeamStore.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamStore.Size = new global::System.Drawing.Size(177, 30);
			this.btnTeamStore.TabIndex = 2;
			this.btnTeamStore.Text = "Profile Store";
			this.btnTeamStore.Click += new global::System.EventHandler(this.btnTeamStore_Click);
			this.btnTeamTools.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamTools.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamTools.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnTeamTools.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTeamTools.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnTeamTools.FillColor = global::System.Drawing.Color.Black;
			this.btnTeamTools.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTeamTools.ForeColor = global::System.Drawing.Color.White;
			this.btnTeamTools.HoverState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamTools.Location = new global::System.Drawing.Point(1, 31);
			this.btnTeamTools.Name = "btnTeamTools";
			this.btnTeamTools.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamTools.Size = new global::System.Drawing.Size(177, 30);
			this.btnTeamTools.TabIndex = 1;
			this.btnTeamTools.Text = "Tools";
			this.btnTeamTools.Click += new global::System.EventHandler(this.btnTeamTools_Click);
			this.btnTeamAccount.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamAccount.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnTeamAccount.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnTeamAccount.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTeamAccount.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.btnTeamAccount.FillColor = global::System.Drawing.Color.Black;
			this.btnTeamAccount.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTeamAccount.ForeColor = global::System.Drawing.Color.White;
			this.btnTeamAccount.HoverState.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamAccount.Location = new global::System.Drawing.Point(1, 1);
			this.btnTeamAccount.Name = "btnTeamAccount";
			this.btnTeamAccount.PressedColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.btnTeamAccount.Size = new global::System.Drawing.Size(177, 30);
			this.btnTeamAccount.TabIndex = 0;
			this.btnTeamAccount.Text = "Account";
			this.btnTeamAccount.Click += new global::System.EventHandler(this.btnTeamAccount_Click);
			this.trayIcon.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("trayIcon.Icon");
			this.trayIcon.Text = "Jack";
			this.trayIcon.Visible = true;
			this.trayIcon.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 540);
			base.Controls.Add(this.panelTeam);
			base.Controls.Add(this.panelBottom);
			base.Controls.Add(this.panelContent);
			base.Controls.Add(this.panelMenu);
			base.Controls.Add(this.panelHeader);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(750, 530);
			base.Name = "frmMain";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMain";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			base.Load += new global::System.EventHandler(this.frmMain_Load);
			base.Shown += new global::System.EventHandler(this.frmMain_Shown);
			base.SizeChanged += new global::System.EventHandler(this.frmMain_SizeChanged);
			this.panelHeader.ResumeLayout(false);
			this.panelAccount.ResumeLayout(false);
			this.panelActionBar.ResumeLayout(false);
			this.panelMenu.ResumeLayout(false);
			this.panelMainMenuButtons.ResumeLayout(false);
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			this.panelBtnStart.ResumeLayout(false);
			this.imgSizer.EndInit();
			this.panelTeam.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000035 RID: 53
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.RichTextBox richConsole;

		// Token: 0x04000037 RID: 55
		private global::Guna.UI2.WinForms.Guna2Panel panelHeader;

		// Token: 0x04000038 RID: 56
		private global::Guna.UI2.WinForms.Guna2Panel panelMenu;

		// Token: 0x04000039 RID: 57
		private global::Guna.UI2.WinForms.Guna2Panel panelContent;

		// Token: 0x0400003A RID: 58
		private global::Guna.UI2.WinForms.Guna2ImageButton imgMinimize;

		// Token: 0x0400003B RID: 59
		private global::Guna.UI2.WinForms.Guna2ImageButton imgClose;

		// Token: 0x0400003C RID: 60
		private global::Guna.UI2.WinForms.Guna2VSeparator sepActionBar;

		// Token: 0x0400003D RID: 61
		private global::Guna.UI2.WinForms.Guna2Panel panelMainMenuButtons;

		// Token: 0x0400003E RID: 62
		private global::Guna.UI2.WinForms.Guna2Button radioMenuProfiles;

		// Token: 0x0400003F RID: 63
		private global::Guna.UI2.WinForms.Guna2Button radioMenuRotations;

		// Token: 0x04000040 RID: 64
		private global::Guna.UI2.WinForms.Guna2Button radioMenuKeybinds;

		// Token: 0x04000041 RID: 65
		private global::Guna.UI2.WinForms.Guna2Button radioMenuSettings;

		// Token: 0x04000042 RID: 66
		private global::Guna.UI2.WinForms.Guna2Button radioMenuAddon;

		// Token: 0x04000043 RID: 67
		private global::Guna.UI2.WinForms.Guna2Button radioMenuOverlay;

		// Token: 0x04000044 RID: 68
		private global::Guna.UI2.WinForms.Guna2PictureBox imgSizer;

		// Token: 0x04000045 RID: 69
		private global::Guna.UI2.WinForms.Guna2Panel panelActionBar;

		// Token: 0x04000046 RID: 70
		private global::Guna.UI2.WinForms.Guna2Panel panelBottom;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.Label lblMainTitle;

		// Token: 0x04000048 RID: 72
		private global::Guna.UI2.WinForms.Guna2Button btnTest2;

		// Token: 0x04000049 RID: 73
		private global::Guna.UI2.WinForms.Guna2Button btnTest1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Label lblStatus1;

		// Token: 0x0400004B RID: 75
		private global::Guna.UI2.WinForms.Guna2Button btnStart;

		// Token: 0x0400004C RID: 76
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnStart;

		// Token: 0x0400004D RID: 77
		private global::Guna.UI2.WinForms.Guna2Button btnAttach;

		// Token: 0x0400004E RID: 78
		private global::Guna.UI2.WinForms.Guna2ImageButton btnModuleDungeon;

		// Token: 0x0400004F RID: 79
		private global::Guna.UI2.WinForms.Guna2ImageButton btnModuleSession;

		// Token: 0x04000050 RID: 80
		private global::Guna.UI2.WinForms.Guna2ImageButton btnModuleNotifications;

		// Token: 0x04000051 RID: 81
		private global::Guna.UI2.WinForms.Guna2Panel panelAccount;

		// Token: 0x04000052 RID: 82
		private global::Guna.UI2.WinForms.Guna2Button radioMenuAccount;

		// Token: 0x04000053 RID: 83
		private global::Guna.UI2.WinForms.Guna2Button btnMessages;

		// Token: 0x04000054 RID: 84
		private global::Guna.UI2.WinForms.Guna2ImageButton btnModuleGather;

		// Token: 0x04000055 RID: 85
		private global::Guna.UI2.WinForms.Guna2ImageButton btnStore;

		// Token: 0x04000056 RID: 86
		private global::Guna.UI2.WinForms.Guna2VSeparator sepAccount;

		// Token: 0x04000057 RID: 87
		private global::Guna.UI2.WinForms.Guna2Panel panelTeam;

		// Token: 0x04000058 RID: 88
		private global::Guna.UI2.WinForms.Guna2Button btnTeamAccount;

		// Token: 0x04000059 RID: 89
		private global::Guna.UI2.WinForms.Guna2Button btnTeamStore;

		// Token: 0x0400005A RID: 90
		private global::Guna.UI2.WinForms.Guna2Button btnTeamTools;

		// Token: 0x0400005B RID: 91
		private global::Guna.UI2.WinForms.Guna2Button btnTeamClose;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.Label lblCancel;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.NotifyIcon trayIcon;

		// Token: 0x0400005E RID: 94
		private global::Guna.UI2.WinForms.Guna2Button btnTeamReloadCOS;
	}
}
