namespace Jack.Forms
{
	// Token: 0x02000083 RID: 131
	public partial class frmMainModules : global::System.Windows.Forms.Form
	{
		// Token: 0x06000CB8 RID: 3256 RVA: 0x006A50F0 File Offset: 0x006A32F0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x006A511C File Offset: 0x006A331C
		private void InitializeComponent()
		{
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabModuleGather = new global::System.Windows.Forms.TabPage();
			this.panelTabModuleGather = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnGatherActivate = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpModuleGather = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.imgModuleGather = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblGather = new global::System.Windows.Forms.Label();
			this.tabModuleDungeon = new global::System.Windows.Forms.TabPage();
			this.panelTabModuleDungeon = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnDungeonActivate = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpModuleDungeon = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.imgModuleDungeon = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblDungeon = new global::System.Windows.Forms.Label();
			this.tabModuleSession = new global::System.Windows.Forms.TabPage();
			this.panelTabModuleSession = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnSessionActivate = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpModuleSession = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.imgModuleSession = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblSession = new global::System.Windows.Forms.Label();
			this.tabModuleNotifications = new global::System.Windows.Forms.TabPage();
			this.panelTabModuleNotifications = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpNotifyDiscord = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnNotifyDiscordTest = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnNotifyDiscordCopy = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblNotifyDiscordInstructionsTypeIn = new global::System.Windows.Forms.Label();
			this.txtNotifyDiscordMyID = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnNotifyDiscordJoin = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblNotifyDiscordInstructions = new global::System.Windows.Forms.Label();
			this.txtNotifyDiscordUserID = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.sepOverlayESPObjects1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.checkNotifyDiscord = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblNotifyDiscordUserID = new global::System.Windows.Forms.Label();
			this.btnNotificationsActivate = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpNotifications = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkNotificationsGhost = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkNotificationsLevelUp = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpModuleNotifications = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.imgModuleNotify = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblNotifications = new global::System.Windows.Forms.Label();
			this.grpNotifyPushover = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnNotifyPushoverTest = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtNotifyPushoverKey = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblNotifyPushoverKey = new global::System.Windows.Forms.Label();
			this.txtNotifyPushoverToken = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkNotifyPushover = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblNotifyPushoverToken = new global::System.Windows.Forms.Label();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.checkNotificationsEvents = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblNotificationsEventsInfo1 = new global::System.Windows.Forms.Label();
			this.lblNotificationsEventsInfo2 = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabModuleGather.SuspendLayout();
			this.panelTabModuleGather.SuspendLayout();
			this.grpModuleGather.SuspendLayout();
			this.imgModuleGather.BeginInit();
			this.tabModuleDungeon.SuspendLayout();
			this.panelTabModuleDungeon.SuspendLayout();
			this.grpModuleDungeon.SuspendLayout();
			this.imgModuleDungeon.BeginInit();
			this.tabModuleSession.SuspendLayout();
			this.panelTabModuleSession.SuspendLayout();
			this.grpModuleSession.SuspendLayout();
			this.imgModuleSession.BeginInit();
			this.tabModuleNotifications.SuspendLayout();
			this.panelTabModuleNotifications.SuspendLayout();
			this.grpNotifyDiscord.SuspendLayout();
			this.grpNotifications.SuspendLayout();
			this.grpModuleNotifications.SuspendLayout();
			this.imgModuleNotify.BeginInit();
			this.grpNotifyPushover.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.tabs);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 22);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(894, 1078);
			this.panelBox1.TabIndex = 69;
			this.tabs.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabModuleGather);
			this.tabs.Controls.Add(this.tabModuleDungeon);
			this.tabs.Controls.Add(this.tabModuleSession);
			this.tabs.Controls.Add(this.tabModuleNotifications);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(180, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(868, 1009);
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
			this.tabs.TabIndex = 68;
			this.tabs.TabMenuBackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.tabs.SelectedIndexChanged += new global::System.EventHandler(this.tabs_SelectedIndexChanged);
			this.tabModuleGather.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabModuleGather.Controls.Add(this.panelTabModuleGather);
			this.tabModuleGather.ForeColor = global::System.Drawing.Color.White;
			this.tabModuleGather.Location = new global::System.Drawing.Point(184, 4);
			this.tabModuleGather.Name = "tabModuleGather";
			this.tabModuleGather.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabModuleGather.Size = new global::System.Drawing.Size(680, 1001);
			this.tabModuleGather.TabIndex = 0;
			this.tabModuleGather.Text = "Gather";
			this.panelTabModuleGather.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabModuleGather.AutoScroll = true;
			this.panelTabModuleGather.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleGather.Controls.Add(this.btnGatherActivate);
			this.panelTabModuleGather.Controls.Add(this.grpModuleGather);
			this.panelTabModuleGather.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleGather.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabModuleGather.Name = "panelTabModuleGather";
			this.panelTabModuleGather.Size = new global::System.Drawing.Size(680, 1001);
			this.panelTabModuleGather.TabIndex = 94;
			this.btnGatherActivate.BorderColor = global::System.Drawing.Color.Gray;
			this.btnGatherActivate.BorderThickness = 1;
			this.btnGatherActivate.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnGatherActivate.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnGatherActivate.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnGatherActivate.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnGatherActivate.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnGatherActivate.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnGatherActivate.ForeColor = global::System.Drawing.Color.White;
			this.btnGatherActivate.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnGatherActivate.Location = new global::System.Drawing.Point(202, 122);
			this.btnGatherActivate.Name = "btnGatherActivate";
			this.btnGatherActivate.Size = new global::System.Drawing.Size(289, 30);
			this.btnGatherActivate.TabIndex = 90;
			this.btnGatherActivate.Text = "Activate Now!";
			this.btnGatherActivate.Visible = false;
			this.btnGatherActivate.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.grpModuleGather.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpModuleGather.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleGather.Controls.Add(this.imgModuleGather);
			this.grpModuleGather.Controls.Add(this.lblGather);
			this.grpModuleGather.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleGather.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpModuleGather.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpModuleGather.ForeColor = global::System.Drawing.Color.White;
			this.grpModuleGather.Location = new global::System.Drawing.Point(14, 14);
			this.grpModuleGather.Name = "grpModuleGather";
			this.grpModuleGather.Size = new global::System.Drawing.Size(652, 93);
			this.grpModuleGather.TabIndex = 7;
			this.imgModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleGather.Image = global::Jack.Properties.Resources.module_gathering;
			this.imgModuleGather.ImageRotate = 0f;
			this.imgModuleGather.Location = new global::System.Drawing.Point(12, 7);
			this.imgModuleGather.Name = "imgModuleGather";
			this.imgModuleGather.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleGather.TabIndex = 86;
			this.imgModuleGather.TabStop = false;
			this.lblGather.AutoSize = true;
			this.lblGather.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGather.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblGather.Location = new global::System.Drawing.Point(22, 60);
			this.lblGather.Name = "lblGather";
			this.lblGather.Size = new global::System.Drawing.Size(227, 15);
			this.lblGather.TabIndex = 0;
			this.lblGather.Text = "This module is activated and ready to use.";
			this.tabModuleDungeon.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabModuleDungeon.Controls.Add(this.panelTabModuleDungeon);
			this.tabModuleDungeon.ForeColor = global::System.Drawing.Color.White;
			this.tabModuleDungeon.Location = new global::System.Drawing.Point(184, 4);
			this.tabModuleDungeon.Name = "tabModuleDungeon";
			this.tabModuleDungeon.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabModuleDungeon.Size = new global::System.Drawing.Size(680, 1001);
			this.tabModuleDungeon.TabIndex = 1;
			this.tabModuleDungeon.Text = "Dungeon";
			this.panelTabModuleDungeon.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabModuleDungeon.AutoScroll = true;
			this.panelTabModuleDungeon.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabModuleDungeon.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleDungeon.Controls.Add(this.btnDungeonActivate);
			this.panelTabModuleDungeon.Controls.Add(this.grpModuleDungeon);
			this.panelTabModuleDungeon.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleDungeon.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabModuleDungeon.Name = "panelTabModuleDungeon";
			this.panelTabModuleDungeon.Size = new global::System.Drawing.Size(680, 1001);
			this.panelTabModuleDungeon.TabIndex = 94;
			this.btnDungeonActivate.BorderColor = global::System.Drawing.Color.Gray;
			this.btnDungeonActivate.BorderThickness = 1;
			this.btnDungeonActivate.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnDungeonActivate.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnDungeonActivate.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnDungeonActivate.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnDungeonActivate.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnDungeonActivate.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnDungeonActivate.ForeColor = global::System.Drawing.Color.White;
			this.btnDungeonActivate.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnDungeonActivate.Location = new global::System.Drawing.Point(202, 122);
			this.btnDungeonActivate.Name = "btnDungeonActivate";
			this.btnDungeonActivate.Size = new global::System.Drawing.Size(289, 30);
			this.btnDungeonActivate.TabIndex = 92;
			this.btnDungeonActivate.Text = "Activate Now!";
			this.btnDungeonActivate.Visible = false;
			this.btnDungeonActivate.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.grpModuleDungeon.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpModuleDungeon.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleDungeon.Controls.Add(this.imgModuleDungeon);
			this.grpModuleDungeon.Controls.Add(this.lblDungeon);
			this.grpModuleDungeon.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleDungeon.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpModuleDungeon.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpModuleDungeon.ForeColor = global::System.Drawing.Color.White;
			this.grpModuleDungeon.Location = new global::System.Drawing.Point(14, 14);
			this.grpModuleDungeon.Name = "grpModuleDungeon";
			this.grpModuleDungeon.Size = new global::System.Drawing.Size(652, 93);
			this.grpModuleDungeon.TabIndex = 91;
			this.imgModuleDungeon.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleDungeon.Image = global::Jack.Properties.Resources.module_dungeons;
			this.imgModuleDungeon.ImageRotate = 0f;
			this.imgModuleDungeon.Location = new global::System.Drawing.Point(12, 7);
			this.imgModuleDungeon.Name = "imgModuleDungeon";
			this.imgModuleDungeon.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleDungeon.TabIndex = 87;
			this.imgModuleDungeon.TabStop = false;
			this.lblDungeon.AutoSize = true;
			this.lblDungeon.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDungeon.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblDungeon.Location = new global::System.Drawing.Point(22, 60);
			this.lblDungeon.Name = "lblDungeon";
			this.lblDungeon.Size = new global::System.Drawing.Size(227, 15);
			this.lblDungeon.TabIndex = 0;
			this.lblDungeon.Text = "This module is activated and ready to use.";
			this.tabModuleSession.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabModuleSession.Controls.Add(this.panelTabModuleSession);
			this.tabModuleSession.Location = new global::System.Drawing.Point(184, 4);
			this.tabModuleSession.Name = "tabModuleSession";
			this.tabModuleSession.Size = new global::System.Drawing.Size(680, 1001);
			this.tabModuleSession.TabIndex = 2;
			this.tabModuleSession.Text = "Multi-Session";
			this.panelTabModuleSession.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabModuleSession.AutoScroll = true;
			this.panelTabModuleSession.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabModuleSession.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleSession.Controls.Add(this.btnSessionActivate);
			this.panelTabModuleSession.Controls.Add(this.grpModuleSession);
			this.panelTabModuleSession.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleSession.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabModuleSession.Name = "panelTabModuleSession";
			this.panelTabModuleSession.Size = new global::System.Drawing.Size(680, 1001);
			this.panelTabModuleSession.TabIndex = 93;
			this.btnSessionActivate.BorderColor = global::System.Drawing.Color.Gray;
			this.btnSessionActivate.BorderThickness = 1;
			this.btnSessionActivate.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnSessionActivate.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnSessionActivate.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnSessionActivate.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnSessionActivate.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnSessionActivate.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnSessionActivate.ForeColor = global::System.Drawing.Color.White;
			this.btnSessionActivate.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnSessionActivate.Location = new global::System.Drawing.Point(202, 122);
			this.btnSessionActivate.Name = "btnSessionActivate";
			this.btnSessionActivate.Size = new global::System.Drawing.Size(289, 30);
			this.btnSessionActivate.TabIndex = 92;
			this.btnSessionActivate.Text = "Activate Now!";
			this.btnSessionActivate.Visible = false;
			this.btnSessionActivate.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.grpModuleSession.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpModuleSession.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleSession.Controls.Add(this.imgModuleSession);
			this.grpModuleSession.Controls.Add(this.lblSession);
			this.grpModuleSession.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleSession.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpModuleSession.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpModuleSession.ForeColor = global::System.Drawing.Color.White;
			this.grpModuleSession.Location = new global::System.Drawing.Point(14, 14);
			this.grpModuleSession.Name = "grpModuleSession";
			this.grpModuleSession.Size = new global::System.Drawing.Size(652, 93);
			this.grpModuleSession.TabIndex = 91;
			this.imgModuleSession.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleSession.Image = global::Jack.Properties.Resources.module_sessions;
			this.imgModuleSession.ImageRotate = 0f;
			this.imgModuleSession.Location = new global::System.Drawing.Point(12, 7);
			this.imgModuleSession.Name = "imgModuleSession";
			this.imgModuleSession.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleSession.TabIndex = 87;
			this.imgModuleSession.TabStop = false;
			this.lblSession.AutoSize = true;
			this.lblSession.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSession.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblSession.Location = new global::System.Drawing.Point(22, 60);
			this.lblSession.Name = "lblSession";
			this.lblSession.Size = new global::System.Drawing.Size(227, 15);
			this.lblSession.TabIndex = 0;
			this.lblSession.Text = "This module is activated and ready to use.";
			this.tabModuleNotifications.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabModuleNotifications.Controls.Add(this.panelTabModuleNotifications);
			this.tabModuleNotifications.Location = new global::System.Drawing.Point(184, 4);
			this.tabModuleNotifications.Name = "tabModuleNotifications";
			this.tabModuleNotifications.Size = new global::System.Drawing.Size(680, 1001);
			this.tabModuleNotifications.TabIndex = 3;
			this.tabModuleNotifications.Text = "Notifications";
			this.panelTabModuleNotifications.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabModuleNotifications.AutoScroll = true;
			this.panelTabModuleNotifications.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabModuleNotifications.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleNotifications.Controls.Add(this.grpNotifyDiscord);
			this.panelTabModuleNotifications.Controls.Add(this.btnNotificationsActivate);
			this.panelTabModuleNotifications.Controls.Add(this.grpNotifications);
			this.panelTabModuleNotifications.Controls.Add(this.grpModuleNotifications);
			this.panelTabModuleNotifications.Controls.Add(this.grpNotifyPushover);
			this.panelTabModuleNotifications.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabModuleNotifications.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabModuleNotifications.Name = "panelTabModuleNotifications";
			this.panelTabModuleNotifications.Size = new global::System.Drawing.Size(680, 1001);
			this.panelTabModuleNotifications.TabIndex = 97;
			this.grpNotifyDiscord.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpNotifyDiscord.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpNotifyDiscord.Controls.Add(this.btnNotifyDiscordTest);
			this.grpNotifyDiscord.Controls.Add(this.btnNotifyDiscordCopy);
			this.grpNotifyDiscord.Controls.Add(this.lblNotifyDiscordInstructionsTypeIn);
			this.grpNotifyDiscord.Controls.Add(this.txtNotifyDiscordMyID);
			this.grpNotifyDiscord.Controls.Add(this.btnNotifyDiscordJoin);
			this.grpNotifyDiscord.Controls.Add(this.lblNotifyDiscordInstructions);
			this.grpNotifyDiscord.Controls.Add(this.txtNotifyDiscordUserID);
			this.grpNotifyDiscord.Controls.Add(this.sepOverlayESPObjects1);
			this.grpNotifyDiscord.Controls.Add(this.checkNotifyDiscord);
			this.grpNotifyDiscord.Controls.Add(this.lblNotifyDiscordUserID);
			this.grpNotifyDiscord.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpNotifyDiscord.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpNotifyDiscord.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpNotifyDiscord.ForeColor = global::System.Drawing.Color.White;
			this.grpNotifyDiscord.Location = new global::System.Drawing.Point(14, 122);
			this.grpNotifyDiscord.Name = "grpNotifyDiscord";
			this.grpNotifyDiscord.Size = new global::System.Drawing.Size(652, 256);
			this.grpNotifyDiscord.TabIndex = 94;
			this.grpNotifyDiscord.Visible = false;
			this.btnNotifyDiscordTest.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNotifyDiscordTest.BorderThickness = 1;
			this.btnNotifyDiscordTest.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyDiscordTest.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyDiscordTest.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnNotifyDiscordTest.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNotifyDiscordTest.Enabled = false;
			this.btnNotifyDiscordTest.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnNotifyDiscordTest.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnNotifyDiscordTest.ForeColor = global::System.Drawing.Color.White;
			this.btnNotifyDiscordTest.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNotifyDiscordTest.Location = new global::System.Drawing.Point(180, 96);
			this.btnNotifyDiscordTest.Name = "btnNotifyDiscordTest";
			this.btnNotifyDiscordTest.Size = new global::System.Drawing.Size(243, 30);
			this.btnNotifyDiscordTest.TabIndex = 98;
			this.btnNotifyDiscordTest.Text = "Send Test Message";
			this.btnNotifyDiscordTest.Click += new global::System.EventHandler(this.btnNotifyDiscordTest_Click);
			this.btnNotifyDiscordCopy.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNotifyDiscordCopy.BorderThickness = 1;
			this.btnNotifyDiscordCopy.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyDiscordCopy.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyDiscordCopy.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnNotifyDiscordCopy.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNotifyDiscordCopy.Enabled = false;
			this.btnNotifyDiscordCopy.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnNotifyDiscordCopy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnNotifyDiscordCopy.ForeColor = global::System.Drawing.Color.White;
			this.btnNotifyDiscordCopy.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNotifyDiscordCopy.Location = new global::System.Drawing.Point(342, 206);
			this.btnNotifyDiscordCopy.Name = "btnNotifyDiscordCopy";
			this.btnNotifyDiscordCopy.Size = new global::System.Drawing.Size(81, 30);
			this.btnNotifyDiscordCopy.TabIndex = 97;
			this.btnNotifyDiscordCopy.Text = "Copy";
			this.btnNotifyDiscordCopy.Click += new global::System.EventHandler(this.btnNotifyDiscordCopy_Click);
			this.lblNotifyDiscordInstructionsTypeIn.AutoSize = true;
			this.lblNotifyDiscordInstructionsTypeIn.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyDiscordInstructionsTypeIn.Enabled = false;
			this.lblNotifyDiscordInstructionsTypeIn.Location = new global::System.Drawing.Point(177, 213);
			this.lblNotifyDiscordInstructionsTypeIn.Name = "lblNotifyDiscordInstructionsTypeIn";
			this.lblNotifyDiscordInstructionsTypeIn.Size = new global::System.Drawing.Size(47, 15);
			this.lblNotifyDiscordInstructionsTypeIn.TabIndex = 96;
			this.lblNotifyDiscordInstructionsTypeIn.Text = "Type in:";
			this.txtNotifyDiscordMyID.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyDiscordMyID.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtNotifyDiscordMyID.DefaultText = "!myid";
			this.txtNotifyDiscordMyID.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyDiscordMyID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtNotifyDiscordMyID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyDiscordMyID.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyDiscordMyID.Enabled = false;
			this.txtNotifyDiscordMyID.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtNotifyDiscordMyID.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtNotifyDiscordMyID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtNotifyDiscordMyID.ForeColor = global::System.Drawing.Color.White;
			this.txtNotifyDiscordMyID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtNotifyDiscordMyID.Location = new global::System.Drawing.Point(235, 206);
			this.txtNotifyDiscordMyID.Name = "txtNotifyDiscordMyID";
			this.txtNotifyDiscordMyID.PasswordChar = '\0';
			this.txtNotifyDiscordMyID.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtNotifyDiscordMyID.PlaceholderText = "";
			this.txtNotifyDiscordMyID.ReadOnly = true;
			this.txtNotifyDiscordMyID.SelectedText = "";
			this.txtNotifyDiscordMyID.Size = new global::System.Drawing.Size(101, 30);
			this.txtNotifyDiscordMyID.TabIndex = 95;
			this.btnNotifyDiscordJoin.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNotifyDiscordJoin.BorderThickness = 1;
			this.btnNotifyDiscordJoin.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyDiscordJoin.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyDiscordJoin.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnNotifyDiscordJoin.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNotifyDiscordJoin.Enabled = false;
			this.btnNotifyDiscordJoin.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnNotifyDiscordJoin.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnNotifyDiscordJoin.ForeColor = global::System.Drawing.Color.White;
			this.btnNotifyDiscordJoin.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNotifyDiscordJoin.Location = new global::System.Drawing.Point(180, 170);
			this.btnNotifyDiscordJoin.Name = "btnNotifyDiscordJoin";
			this.btnNotifyDiscordJoin.Size = new global::System.Drawing.Size(243, 30);
			this.btnNotifyDiscordJoin.TabIndex = 93;
			this.btnNotifyDiscordJoin.Text = "Join our Discord Server";
			this.btnNotifyDiscordJoin.Click += new global::System.EventHandler(this.btnNotifyDiscordJoin_Click);
			this.lblNotifyDiscordInstructions.AutoSize = true;
			this.lblNotifyDiscordInstructions.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyDiscordInstructions.Enabled = false;
			this.lblNotifyDiscordInstructions.ForeColor = global::System.Drawing.Color.Goldenrod;
			this.lblNotifyDiscordInstructions.Location = new global::System.Drawing.Point(22, 177);
			this.lblNotifyDiscordInstructions.Name = "lblNotifyDiscordInstructions";
			this.lblNotifyDiscordInstructions.Size = new global::System.Drawing.Size(72, 15);
			this.lblNotifyDiscordInstructions.TabIndex = 68;
			this.lblNotifyDiscordInstructions.Text = "Instructions:";
			this.txtNotifyDiscordUserID.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyDiscordUserID.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtNotifyDiscordUserID.DefaultText = "";
			this.txtNotifyDiscordUserID.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyDiscordUserID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtNotifyDiscordUserID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyDiscordUserID.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyDiscordUserID.Enabled = false;
			this.txtNotifyDiscordUserID.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtNotifyDiscordUserID.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtNotifyDiscordUserID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtNotifyDiscordUserID.ForeColor = global::System.Drawing.Color.White;
			this.txtNotifyDiscordUserID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtNotifyDiscordUserID.Location = new global::System.Drawing.Point(180, 60);
			this.txtNotifyDiscordUserID.MaxLength = 50;
			this.txtNotifyDiscordUserID.Name = "txtNotifyDiscordUserID";
			this.txtNotifyDiscordUserID.PasswordChar = '\0';
			this.txtNotifyDiscordUserID.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtNotifyDiscordUserID.PlaceholderText = "Example: 984057282721480704";
			this.txtNotifyDiscordUserID.SelectedText = "";
			this.txtNotifyDiscordUserID.Size = new global::System.Drawing.Size(243, 30);
			this.txtNotifyDiscordUserID.TabIndex = 67;
			this.sepOverlayESPObjects1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepOverlayESPObjects1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepOverlayESPObjects1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepOverlayESPObjects1.Location = new global::System.Drawing.Point(20, 142);
			this.sepOverlayESPObjects1.Name = "sepOverlayESPObjects1";
			this.sepOverlayESPObjects1.Size = new global::System.Drawing.Size(612, 10);
			this.sepOverlayESPObjects1.TabIndex = 66;
			this.checkNotifyDiscord.Animated = true;
			this.checkNotifyDiscord.AutoSize = true;
			this.checkNotifyDiscord.BackColor = global::System.Drawing.Color.Transparent;
			this.checkNotifyDiscord.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotifyDiscord.CheckedState.BorderRadius = 0;
			this.checkNotifyDiscord.CheckedState.BorderThickness = 0;
			this.checkNotifyDiscord.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotifyDiscord.Location = new global::System.Drawing.Point(12, 11);
			this.checkNotifyDiscord.Name = "checkNotifyDiscord";
			this.checkNotifyDiscord.Size = new global::System.Drawing.Size(66, 19);
			this.checkNotifyDiscord.TabIndex = 32;
			this.checkNotifyDiscord.Text = "Discord";
			this.checkNotifyDiscord.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkNotifyDiscord.UncheckedState.BorderRadius = 0;
			this.checkNotifyDiscord.UncheckedState.BorderThickness = 1;
			this.checkNotifyDiscord.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkNotifyDiscord.UseVisualStyleBackColor = false;
			this.checkNotifyDiscord.CheckedChanged += new global::System.EventHandler(this.checkNotifyDiscord_CheckedChanged);
			this.lblNotifyDiscordUserID.AutoSize = true;
			this.lblNotifyDiscordUserID.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyDiscordUserID.Enabled = false;
			this.lblNotifyDiscordUserID.Location = new global::System.Drawing.Point(22, 67);
			this.lblNotifyDiscordUserID.Name = "lblNotifyDiscordUserID";
			this.lblNotifyDiscordUserID.Size = new global::System.Drawing.Size(47, 15);
			this.lblNotifyDiscordUserID.TabIndex = 21;
			this.lblNotifyDiscordUserID.Text = "User ID:";
			this.btnNotificationsActivate.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNotificationsActivate.BorderThickness = 1;
			this.btnNotificationsActivate.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotificationsActivate.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotificationsActivate.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnNotificationsActivate.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNotificationsActivate.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnNotificationsActivate.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnNotificationsActivate.ForeColor = global::System.Drawing.Color.White;
			this.btnNotificationsActivate.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNotificationsActivate.Location = new global::System.Drawing.Point(202, 122);
			this.btnNotificationsActivate.Name = "btnNotificationsActivate";
			this.btnNotificationsActivate.Size = new global::System.Drawing.Size(289, 30);
			this.btnNotificationsActivate.TabIndex = 92;
			this.btnNotificationsActivate.Text = "Activate Now!";
			this.btnNotificationsActivate.Visible = false;
			this.btnNotificationsActivate.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.grpNotifications.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpNotifications.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpNotifications.Controls.Add(this.lblNotificationsEventsInfo2);
			this.grpNotifications.Controls.Add(this.lblNotificationsEventsInfo1);
			this.grpNotifications.Controls.Add(this.guna2Separator1);
			this.grpNotifications.Controls.Add(this.checkNotificationsEvents);
			this.grpNotifications.Controls.Add(this.checkNotificationsGhost);
			this.grpNotifications.Controls.Add(this.checkNotificationsLevelUp);
			this.grpNotifications.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpNotifications.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpNotifications.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpNotifications.ForeColor = global::System.Drawing.Color.White;
			this.grpNotifications.Location = new global::System.Drawing.Point(14, 590);
			this.grpNotifications.Name = "grpNotifications";
			this.grpNotifications.Size = new global::System.Drawing.Size(652, 242);
			this.grpNotifications.TabIndex = 96;
			this.grpNotifications.Text = "Notifications";
			this.checkNotificationsGhost.Animated = true;
			this.checkNotificationsGhost.AutoSize = true;
			this.checkNotificationsGhost.BackColor = global::System.Drawing.Color.Transparent;
			this.checkNotificationsGhost.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotificationsGhost.CheckedState.BorderRadius = 0;
			this.checkNotificationsGhost.CheckedState.BorderThickness = 0;
			this.checkNotificationsGhost.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotificationsGhost.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkNotificationsGhost.Location = new global::System.Drawing.Point(25, 85);
			this.checkNotificationsGhost.Name = "checkNotificationsGhost";
			this.checkNotificationsGhost.Size = new global::System.Drawing.Size(129, 19);
			this.checkNotificationsGhost.TabIndex = 36;
			this.checkNotificationsGhost.Text = "When died/revived.";
			this.checkNotificationsGhost.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkNotificationsGhost.UncheckedState.BorderRadius = 0;
			this.checkNotificationsGhost.UncheckedState.BorderThickness = 1;
			this.checkNotificationsGhost.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkNotificationsGhost.UseVisualStyleBackColor = false;
			this.checkNotificationsGhost.CheckedChanged += new global::System.EventHandler(this.checkNotificationsGhost_CheckedChanged);
			this.checkNotificationsLevelUp.Animated = true;
			this.checkNotificationsLevelUp.AutoSize = true;
			this.checkNotificationsLevelUp.BackColor = global::System.Drawing.Color.Transparent;
			this.checkNotificationsLevelUp.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotificationsLevelUp.CheckedState.BorderRadius = 0;
			this.checkNotificationsLevelUp.CheckedState.BorderThickness = 0;
			this.checkNotificationsLevelUp.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotificationsLevelUp.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkNotificationsLevelUp.Location = new global::System.Drawing.Point(25, 60);
			this.checkNotificationsLevelUp.Name = "checkNotificationsLevelUp";
			this.checkNotificationsLevelUp.Size = new global::System.Drawing.Size(166, 19);
			this.checkNotificationsLevelUp.TabIndex = 35;
			this.checkNotificationsLevelUp.Text = "When reached a new level.";
			this.checkNotificationsLevelUp.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkNotificationsLevelUp.UncheckedState.BorderRadius = 0;
			this.checkNotificationsLevelUp.UncheckedState.BorderThickness = 1;
			this.checkNotificationsLevelUp.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkNotificationsLevelUp.UseVisualStyleBackColor = false;
			this.checkNotificationsLevelUp.CheckedChanged += new global::System.EventHandler(this.checkNotificationsLevelUp_CheckedChanged);
			this.grpModuleNotifications.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpModuleNotifications.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleNotifications.Controls.Add(this.imgModuleNotify);
			this.grpModuleNotifications.Controls.Add(this.lblNotifications);
			this.grpModuleNotifications.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpModuleNotifications.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpModuleNotifications.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpModuleNotifications.ForeColor = global::System.Drawing.Color.White;
			this.grpModuleNotifications.Location = new global::System.Drawing.Point(14, 14);
			this.grpModuleNotifications.Name = "grpModuleNotifications";
			this.grpModuleNotifications.Size = new global::System.Drawing.Size(652, 93);
			this.grpModuleNotifications.TabIndex = 91;
			this.imgModuleNotify.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleNotify.Image = global::Jack.Properties.Resources.module_notifications;
			this.imgModuleNotify.ImageRotate = 0f;
			this.imgModuleNotify.Location = new global::System.Drawing.Point(12, 7);
			this.imgModuleNotify.Name = "imgModuleNotify";
			this.imgModuleNotify.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleNotify.TabIndex = 87;
			this.imgModuleNotify.TabStop = false;
			this.lblNotifications.AutoSize = true;
			this.lblNotifications.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifications.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblNotifications.Location = new global::System.Drawing.Point(22, 60);
			this.lblNotifications.Name = "lblNotifications";
			this.lblNotifications.Size = new global::System.Drawing.Size(227, 15);
			this.lblNotifications.TabIndex = 0;
			this.lblNotifications.Text = "This module is activated and ready to use.";
			this.grpNotifyPushover.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpNotifyPushover.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpNotifyPushover.Controls.Add(this.btnNotifyPushoverTest);
			this.grpNotifyPushover.Controls.Add(this.txtNotifyPushoverKey);
			this.grpNotifyPushover.Controls.Add(this.lblNotifyPushoverKey);
			this.grpNotifyPushover.Controls.Add(this.txtNotifyPushoverToken);
			this.grpNotifyPushover.Controls.Add(this.checkNotifyPushover);
			this.grpNotifyPushover.Controls.Add(this.lblNotifyPushoverToken);
			this.grpNotifyPushover.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpNotifyPushover.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpNotifyPushover.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpNotifyPushover.ForeColor = global::System.Drawing.Color.White;
			this.grpNotifyPushover.Location = new global::System.Drawing.Point(14, 393);
			this.grpNotifyPushover.Name = "grpNotifyPushover";
			this.grpNotifyPushover.Size = new global::System.Drawing.Size(652, 182);
			this.grpNotifyPushover.TabIndex = 95;
			this.grpNotifyPushover.Visible = false;
			this.btnNotifyPushoverTest.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNotifyPushoverTest.BorderThickness = 1;
			this.btnNotifyPushoverTest.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyPushoverTest.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotifyPushoverTest.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnNotifyPushoverTest.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNotifyPushoverTest.Enabled = false;
			this.btnNotifyPushoverTest.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnNotifyPushoverTest.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnNotifyPushoverTest.ForeColor = global::System.Drawing.Color.White;
			this.btnNotifyPushoverTest.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNotifyPushoverTest.Location = new global::System.Drawing.Point(180, 132);
			this.btnNotifyPushoverTest.Name = "btnNotifyPushoverTest";
			this.btnNotifyPushoverTest.Size = new global::System.Drawing.Size(243, 30);
			this.btnNotifyPushoverTest.TabIndex = 99;
			this.btnNotifyPushoverTest.Text = "Send Test Message";
			this.btnNotifyPushoverTest.Click += new global::System.EventHandler(this.btnNotifyPushoverTest_Click);
			this.txtNotifyPushoverKey.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyPushoverKey.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtNotifyPushoverKey.DefaultText = "";
			this.txtNotifyPushoverKey.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyPushoverKey.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtNotifyPushoverKey.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyPushoverKey.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyPushoverKey.Enabled = false;
			this.txtNotifyPushoverKey.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtNotifyPushoverKey.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtNotifyPushoverKey.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtNotifyPushoverKey.ForeColor = global::System.Drawing.Color.White;
			this.txtNotifyPushoverKey.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtNotifyPushoverKey.Location = new global::System.Drawing.Point(180, 96);
			this.txtNotifyPushoverKey.MaxLength = 50;
			this.txtNotifyPushoverKey.Name = "txtNotifyPushoverKey";
			this.txtNotifyPushoverKey.PasswordChar = '\0';
			this.txtNotifyPushoverKey.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtNotifyPushoverKey.PlaceholderText = "";
			this.txtNotifyPushoverKey.SelectedText = "";
			this.txtNotifyPushoverKey.Size = new global::System.Drawing.Size(243, 30);
			this.txtNotifyPushoverKey.TabIndex = 69;
			this.lblNotifyPushoverKey.AutoSize = true;
			this.lblNotifyPushoverKey.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyPushoverKey.Enabled = false;
			this.lblNotifyPushoverKey.Location = new global::System.Drawing.Point(22, 103);
			this.lblNotifyPushoverKey.Name = "lblNotifyPushoverKey";
			this.lblNotifyPushoverKey.Size = new global::System.Drawing.Size(29, 15);
			this.lblNotifyPushoverKey.TabIndex = 68;
			this.lblNotifyPushoverKey.Text = "Key:";
			this.txtNotifyPushoverToken.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyPushoverToken.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtNotifyPushoverToken.DefaultText = "";
			this.txtNotifyPushoverToken.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtNotifyPushoverToken.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtNotifyPushoverToken.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyPushoverToken.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtNotifyPushoverToken.Enabled = false;
			this.txtNotifyPushoverToken.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtNotifyPushoverToken.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtNotifyPushoverToken.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtNotifyPushoverToken.ForeColor = global::System.Drawing.Color.White;
			this.txtNotifyPushoverToken.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtNotifyPushoverToken.Location = new global::System.Drawing.Point(180, 60);
			this.txtNotifyPushoverToken.MaxLength = 50;
			this.txtNotifyPushoverToken.Name = "txtNotifyPushoverToken";
			this.txtNotifyPushoverToken.PasswordChar = '\0';
			this.txtNotifyPushoverToken.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtNotifyPushoverToken.PlaceholderText = "";
			this.txtNotifyPushoverToken.SelectedText = "";
			this.txtNotifyPushoverToken.Size = new global::System.Drawing.Size(243, 30);
			this.txtNotifyPushoverToken.TabIndex = 67;
			this.checkNotifyPushover.Animated = true;
			this.checkNotifyPushover.AutoSize = true;
			this.checkNotifyPushover.BackColor = global::System.Drawing.Color.Transparent;
			this.checkNotifyPushover.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotifyPushover.CheckedState.BorderRadius = 0;
			this.checkNotifyPushover.CheckedState.BorderThickness = 0;
			this.checkNotifyPushover.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotifyPushover.Location = new global::System.Drawing.Point(12, 11);
			this.checkNotifyPushover.Name = "checkNotifyPushover";
			this.checkNotifyPushover.Size = new global::System.Drawing.Size(75, 19);
			this.checkNotifyPushover.TabIndex = 32;
			this.checkNotifyPushover.Text = "Pushover";
			this.checkNotifyPushover.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkNotifyPushover.UncheckedState.BorderRadius = 0;
			this.checkNotifyPushover.UncheckedState.BorderThickness = 1;
			this.checkNotifyPushover.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkNotifyPushover.UseVisualStyleBackColor = false;
			this.checkNotifyPushover.CheckedChanged += new global::System.EventHandler(this.checkNotifyPushover_CheckedChanged);
			this.lblNotifyPushoverToken.AutoSize = true;
			this.lblNotifyPushoverToken.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyPushoverToken.Enabled = false;
			this.lblNotifyPushoverToken.Location = new global::System.Drawing.Point(22, 67);
			this.lblNotifyPushoverToken.Name = "lblNotifyPushoverToken";
			this.lblNotifyPushoverToken.Size = new global::System.Drawing.Size(41, 15);
			this.lblNotifyPushoverToken.TabIndex = 21;
			this.lblNotifyPushoverToken.Text = "Token:";
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
			this.lblTitle.Size = new global::System.Drawing.Size(99, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Modules";
			this.checkNotificationsEvents.Animated = true;
			this.checkNotificationsEvents.AutoSize = true;
			this.checkNotificationsEvents.BackColor = global::System.Drawing.Color.Transparent;
			this.checkNotificationsEvents.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotificationsEvents.CheckedState.BorderRadius = 0;
			this.checkNotificationsEvents.CheckedState.BorderThickness = 0;
			this.checkNotificationsEvents.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkNotificationsEvents.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkNotificationsEvents.Location = new global::System.Drawing.Point(25, 110);
			this.checkNotificationsEvents.Name = "checkNotificationsEvents";
			this.checkNotificationsEvents.Size = new global::System.Drawing.Size(156, 19);
			this.checkNotificationsEvents.TabIndex = 37;
			this.checkNotificationsEvents.Text = "Inform me about events.";
			this.checkNotificationsEvents.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkNotificationsEvents.UncheckedState.BorderRadius = 0;
			this.checkNotificationsEvents.UncheckedState.BorderThickness = 1;
			this.checkNotificationsEvents.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkNotificationsEvents.UseVisualStyleBackColor = false;
			this.checkNotificationsEvents.CheckedChanged += new global::System.EventHandler(this.checkNotificationsEvents_CheckedChanged);
			this.guna2Separator1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator1.Location = new global::System.Drawing.Point(20, 144);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(612, 10);
			this.guna2Separator1.TabIndex = 67;
			this.lblNotificationsEventsInfo1.AutoSize = true;
			this.lblNotificationsEventsInfo1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotificationsEventsInfo1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblNotificationsEventsInfo1.ForeColor = global::System.Drawing.Color.Goldenrod;
			this.lblNotificationsEventsInfo1.Location = new global::System.Drawing.Point(22, 171);
			this.lblNotificationsEventsInfo1.Name = "lblNotificationsEventsInfo1";
			this.lblNotificationsEventsInfo1.Size = new global::System.Drawing.Size(143, 15);
			this.lblNotificationsEventsInfo1.TabIndex = 97;
			this.lblNotificationsEventsInfo1.Text = "Notifcations about Events";
			this.lblNotificationsEventsInfo2.AutoEllipsis = true;
			this.lblNotificationsEventsInfo2.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotificationsEventsInfo2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblNotificationsEventsInfo2.ForeColor = global::System.Drawing.Color.White;
			this.lblNotificationsEventsInfo2.Location = new global::System.Drawing.Point(22, 193);
			this.lblNotificationsEventsInfo2.Name = "lblNotificationsEventsInfo2";
			this.lblNotificationsEventsInfo2.Size = new global::System.Drawing.Size(610, 37);
			this.lblNotificationsEventsInfo2.TabIndex = 98;
			this.lblNotificationsEventsInfo2.Text = "If activated, you will receive a message about all significant events. Events that are executed over a very short time, such as \"Jump\", are excluded.";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 1100);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainModules";
			this.Text = "frmMainModules";
			base.Load += new global::System.EventHandler(this.frmMainModule_Load);
			base.Shown += new global::System.EventHandler(this.frmMainModule_Shown);
			base.SizeChanged += new global::System.EventHandler(this.frmMainModules_SizeChanged);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainModule_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabModuleGather.ResumeLayout(false);
			this.panelTabModuleGather.ResumeLayout(false);
			this.grpModuleGather.ResumeLayout(false);
			this.grpModuleGather.PerformLayout();
			this.imgModuleGather.EndInit();
			this.tabModuleDungeon.ResumeLayout(false);
			this.panelTabModuleDungeon.ResumeLayout(false);
			this.grpModuleDungeon.ResumeLayout(false);
			this.grpModuleDungeon.PerformLayout();
			this.imgModuleDungeon.EndInit();
			this.tabModuleSession.ResumeLayout(false);
			this.panelTabModuleSession.ResumeLayout(false);
			this.grpModuleSession.ResumeLayout(false);
			this.grpModuleSession.PerformLayout();
			this.imgModuleSession.EndInit();
			this.tabModuleNotifications.ResumeLayout(false);
			this.panelTabModuleNotifications.ResumeLayout(false);
			this.grpNotifyDiscord.ResumeLayout(false);
			this.grpNotifyDiscord.PerformLayout();
			this.grpNotifications.ResumeLayout(false);
			this.grpNotifications.PerformLayout();
			this.grpModuleNotifications.ResumeLayout(false);
			this.grpModuleNotifications.PerformLayout();
			this.imgModuleNotify.EndInit();
			this.grpNotifyPushover.ResumeLayout(false);
			this.grpNotifyPushover.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400045A RID: 1114
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400045B RID: 1115
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400045C RID: 1116
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x0400045D RID: 1117
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x0400045E RID: 1118
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x0400045F RID: 1119
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x04000460 RID: 1120
		private global::System.Windows.Forms.TabPage tabModuleGather;

		// Token: 0x04000461 RID: 1121
		private global::Guna.UI2.WinForms.Guna2GroupBox grpModuleGather;

		// Token: 0x04000462 RID: 1122
		private global::System.Windows.Forms.Label lblGather;

		// Token: 0x04000463 RID: 1123
		private global::System.Windows.Forms.TabPage tabModuleDungeon;

		// Token: 0x04000464 RID: 1124
		private global::System.Windows.Forms.TabPage tabModuleSession;

		// Token: 0x04000465 RID: 1125
		private global::System.Windows.Forms.TabPage tabModuleNotifications;

		// Token: 0x04000466 RID: 1126
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleGather;

		// Token: 0x04000467 RID: 1127
		private global::Guna.UI2.WinForms.Guna2Button btnGatherActivate;

		// Token: 0x04000468 RID: 1128
		private global::Guna.UI2.WinForms.Guna2Button btnDungeonActivate;

		// Token: 0x04000469 RID: 1129
		private global::Guna.UI2.WinForms.Guna2GroupBox grpModuleDungeon;

		// Token: 0x0400046A RID: 1130
		private global::System.Windows.Forms.Label lblDungeon;

		// Token: 0x0400046B RID: 1131
		private global::Guna.UI2.WinForms.Guna2Button btnSessionActivate;

		// Token: 0x0400046C RID: 1132
		private global::Guna.UI2.WinForms.Guna2GroupBox grpModuleSession;

		// Token: 0x0400046D RID: 1133
		private global::System.Windows.Forms.Label lblSession;

		// Token: 0x0400046E RID: 1134
		private global::Guna.UI2.WinForms.Guna2Button btnNotificationsActivate;

		// Token: 0x0400046F RID: 1135
		private global::Guna.UI2.WinForms.Guna2GroupBox grpModuleNotifications;

		// Token: 0x04000470 RID: 1136
		private global::System.Windows.Forms.Label lblNotifications;

		// Token: 0x04000471 RID: 1137
		private global::Guna.UI2.WinForms.Guna2GroupBox grpNotifyDiscord;

		// Token: 0x04000472 RID: 1138
		private global::Guna.UI2.WinForms.Guna2CheckBox checkNotifyDiscord;

		// Token: 0x04000473 RID: 1139
		private global::System.Windows.Forms.Label lblNotifyDiscordUserID;

		// Token: 0x04000474 RID: 1140
		private global::Guna.UI2.WinForms.Guna2Separator sepOverlayESPObjects1;

		// Token: 0x04000475 RID: 1141
		private global::Guna.UI2.WinForms.Guna2TextBox txtNotifyDiscordUserID;

		// Token: 0x04000476 RID: 1142
		private global::System.Windows.Forms.Label lblNotifyDiscordInstructionsTypeIn;

		// Token: 0x04000477 RID: 1143
		private global::Guna.UI2.WinForms.Guna2TextBox txtNotifyDiscordMyID;

		// Token: 0x04000478 RID: 1144
		private global::Guna.UI2.WinForms.Guna2Button btnNotifyDiscordJoin;

		// Token: 0x04000479 RID: 1145
		private global::System.Windows.Forms.Label lblNotifyDiscordInstructions;

		// Token: 0x0400047A RID: 1146
		private global::Guna.UI2.WinForms.Guna2Button btnNotifyDiscordTest;

		// Token: 0x0400047B RID: 1147
		private global::Guna.UI2.WinForms.Guna2Button btnNotifyDiscordCopy;

		// Token: 0x0400047C RID: 1148
		private global::Guna.UI2.WinForms.Guna2GroupBox grpNotifyPushover;

		// Token: 0x0400047D RID: 1149
		private global::Guna.UI2.WinForms.Guna2TextBox txtNotifyPushoverToken;

		// Token: 0x0400047E RID: 1150
		private global::Guna.UI2.WinForms.Guna2CheckBox checkNotifyPushover;

		// Token: 0x0400047F RID: 1151
		private global::System.Windows.Forms.Label lblNotifyPushoverToken;

		// Token: 0x04000480 RID: 1152
		private global::Guna.UI2.WinForms.Guna2TextBox txtNotifyPushoverKey;

		// Token: 0x04000481 RID: 1153
		private global::System.Windows.Forms.Label lblNotifyPushoverKey;

		// Token: 0x04000482 RID: 1154
		private global::Guna.UI2.WinForms.Guna2Button btnNotifyPushoverTest;

		// Token: 0x04000483 RID: 1155
		private global::Guna.UI2.WinForms.Guna2GroupBox grpNotifications;

		// Token: 0x04000484 RID: 1156
		private global::Guna.UI2.WinForms.Guna2CheckBox checkNotificationsLevelUp;

		// Token: 0x04000485 RID: 1157
		private global::Guna.UI2.WinForms.Guna2CheckBox checkNotificationsGhost;

		// Token: 0x04000486 RID: 1158
		private global::Guna.UI2.WinForms.Guna2Panel panelTabModuleNotifications;

		// Token: 0x04000487 RID: 1159
		private global::Guna.UI2.WinForms.Guna2Panel panelTabModuleGather;

		// Token: 0x04000488 RID: 1160
		private global::Guna.UI2.WinForms.Guna2Panel panelTabModuleDungeon;

		// Token: 0x04000489 RID: 1161
		private global::Guna.UI2.WinForms.Guna2Panel panelTabModuleSession;

		// Token: 0x0400048A RID: 1162
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleDungeon;

		// Token: 0x0400048B RID: 1163
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleSession;

		// Token: 0x0400048C RID: 1164
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleNotify;

		// Token: 0x0400048D RID: 1165
		private global::System.Windows.Forms.Label lblNotificationsEventsInfo2;

		// Token: 0x0400048E RID: 1166
		private global::System.Windows.Forms.Label lblNotificationsEventsInfo1;

		// Token: 0x0400048F RID: 1167
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x04000490 RID: 1168
		private global::Guna.UI2.WinForms.Guna2CheckBox checkNotificationsEvents;
	}
}
