namespace Jack.Forms
{
	// Token: 0x02000090 RID: 144
	public partial class frmMainSettings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E91 RID: 3729 RVA: 0x006CAFB0 File Offset: 0x006C91B0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x006CAFDC File Offset: 0x006C91DC
		private void InitializeComponent()
		{
			this.lblInfoJackLatestData = new global::System.Windows.Forms.Label();
			this.lblInfoJackVersionData = new global::System.Windows.Forms.Label();
			this.lblInfoJackLatest = new global::System.Windows.Forms.Label();
			this.lblInfoJackVersion = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsRetailPTRBuild = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsRetailBuild = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsRetailPTRStatus = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsRetailPTR = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsRetailStatus = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsRetail = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicEraPTRBuild = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicEraBuild = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicPTRBuild = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicBuild = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicEraPTRStatus = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicEraPTR = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicEraStatus = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicEra = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicPTRStatus = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicPTR = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassicStatus = new global::System.Windows.Forms.Label();
			this.lblInfoBuildsClassic = new global::System.Windows.Forms.Label();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnInfoTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabBuilds = new global::System.Windows.Forms.TabPage();
			this.panelTabBuilds = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpInfoBuildsPTR = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.grpInfoBuildsJack = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblInfoMapsRetailDownload = new global::System.Windows.Forms.Label();
			this.lblInfoMapsClassicDownload = new global::System.Windows.Forms.Label();
			this.lblInfoMapsRetailVersionData = new global::System.Windows.Forms.Label();
			this.lblInfoMapsRetailVersion = new global::System.Windows.Forms.Label();
			this.lblInfoMapsClassicVersionData = new global::System.Windows.Forms.Label();
			this.lblInfoMapsClassicVersion = new global::System.Windows.Forms.Label();
			this.btnInfoBuildsJackUpdates = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpInfoBuildsLive = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.tabChangelog = new global::System.Windows.Forms.TabPage();
			this.grpInfoChangelog = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.richInfoChangelog = new global::System.Windows.Forms.RichTextBox();
			this.tabLog = new global::System.Windows.Forms.TabPage();
			this.grpLog = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.listLogs = new global::System.Windows.Forms.ListView();
			this.listLogsDate = new global::System.Windows.Forms.ColumnHeader();
			this.tabJack = new global::System.Windows.Forms.TabPage();
			this.panelTabJack = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpSettingsJack = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblSettingsJackTray = new global::System.Windows.Forms.Label();
			this.checkSettingsJackTray = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpSettingsGame = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.imgModuleSession = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.checkSettingsGameAutoDetect = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabAutoReconnect = new global::System.Windows.Forms.TabPage();
			this.panelTabAutoReconnect = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpAutoReconnect = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnAutoReconnectSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtAutoReconnectPassword = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkAutoReconnect = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblAutoReconnectPassword = new global::System.Windows.Forms.Label();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.lblInfoAddonLatestData = new global::System.Windows.Forms.Label();
			this.lblInfoAddonLatest = new global::System.Windows.Forms.Label();
			this.lblAddonSettingsPrintVersion = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabBuilds.SuspendLayout();
			this.panelTabBuilds.SuspendLayout();
			this.grpInfoBuildsPTR.SuspendLayout();
			this.grpInfoBuildsJack.SuspendLayout();
			this.grpInfoBuildsLive.SuspendLayout();
			this.tabChangelog.SuspendLayout();
			this.grpInfoChangelog.SuspendLayout();
			this.tabLog.SuspendLayout();
			this.grpLog.SuspendLayout();
			this.tabJack.SuspendLayout();
			this.panelTabJack.SuspendLayout();
			this.grpSettingsJack.SuspendLayout();
			this.grpSettingsGame.SuspendLayout();
			this.imgModuleSession.BeginInit();
			this.tabAutoReconnect.SuspendLayout();
			this.panelTabAutoReconnect.SuspendLayout();
			this.grpAutoReconnect.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			base.SuspendLayout();
			this.lblInfoJackLatestData.AutoSize = true;
			this.lblInfoJackLatestData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoJackLatestData.Location = new global::System.Drawing.Point(177, 85);
			this.lblInfoJackLatestData.Name = "lblInfoJackLatestData";
			this.lblInfoJackLatestData.Size = new global::System.Drawing.Size(62, 15);
			this.lblInfoJackLatestData.TabIndex = 23;
			this.lblInfoJackLatestData.Text = "[VERSION]";
			this.lblInfoJackVersionData.AutoSize = true;
			this.lblInfoJackVersionData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoJackVersionData.Location = new global::System.Drawing.Point(177, 60);
			this.lblInfoJackVersionData.Name = "lblInfoJackVersionData";
			this.lblInfoJackVersionData.Size = new global::System.Drawing.Size(62, 15);
			this.lblInfoJackVersionData.TabIndex = 22;
			this.lblInfoJackVersionData.Text = "[VERSION]";
			this.lblInfoJackLatest.AutoSize = true;
			this.lblInfoJackLatest.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoJackLatest.Location = new global::System.Drawing.Point(22, 85);
			this.lblInfoJackLatest.Name = "lblInfoJackLatest";
			this.lblInfoJackLatest.Size = new global::System.Drawing.Size(41, 15);
			this.lblInfoJackLatest.TabIndex = 16;
			this.lblInfoJackLatest.Text = "Latest:";
			this.lblInfoJackVersion.AutoSize = true;
			this.lblInfoJackVersion.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoJackVersion.Location = new global::System.Drawing.Point(22, 60);
			this.lblInfoJackVersion.Name = "lblInfoJackVersion";
			this.lblInfoJackVersion.Size = new global::System.Drawing.Size(48, 15);
			this.lblInfoJackVersion.TabIndex = 14;
			this.lblInfoJackVersion.Text = "Version:";
			this.lblInfoBuildsRetailPTRBuild.AutoSize = true;
			this.lblInfoBuildsRetailPTRBuild.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsRetailPTRBuild.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsRetailPTRBuild.Location = new global::System.Drawing.Point(177, 110);
			this.lblInfoBuildsRetailPTRBuild.Name = "lblInfoBuildsRetailPTRBuild";
			this.lblInfoBuildsRetailPTRBuild.Size = new global::System.Drawing.Size(47, 15);
			this.lblInfoBuildsRetailPTRBuild.TabIndex = 31;
			this.lblInfoBuildsRetailPTRBuild.Text = "[BUILD]";
			this.lblInfoBuildsRetailBuild.AutoSize = true;
			this.lblInfoBuildsRetailBuild.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsRetailBuild.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsRetailBuild.Location = new global::System.Drawing.Point(177, 110);
			this.lblInfoBuildsRetailBuild.Name = "lblInfoBuildsRetailBuild";
			this.lblInfoBuildsRetailBuild.Size = new global::System.Drawing.Size(47, 15);
			this.lblInfoBuildsRetailBuild.TabIndex = 30;
			this.lblInfoBuildsRetailBuild.Text = "[BUILD]";
			this.lblInfoBuildsRetailPTRStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoBuildsRetailPTRStatus.AutoEllipsis = true;
			this.lblInfoBuildsRetailPTRStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsRetailPTRStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsRetailPTRStatus.Location = new global::System.Drawing.Point(324, 110);
			this.lblInfoBuildsRetailPTRStatus.Name = "lblInfoBuildsRetailPTRStatus";
			this.lblInfoBuildsRetailPTRStatus.Size = new global::System.Drawing.Size(272, 15);
			this.lblInfoBuildsRetailPTRStatus.TabIndex = 29;
			this.lblInfoBuildsRetailPTRStatus.Text = "[STATUS]";
			this.lblInfoBuildsRetailPTRStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoBuildsRetailPTR.AutoSize = true;
			this.lblInfoBuildsRetailPTR.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsRetailPTR.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsRetailPTR.Location = new global::System.Drawing.Point(22, 110);
			this.lblInfoBuildsRetailPTR.Name = "lblInfoBuildsRetailPTR";
			this.lblInfoBuildsRetailPTR.Size = new global::System.Drawing.Size(62, 15);
			this.lblInfoBuildsRetailPTR.TabIndex = 28;
			this.lblInfoBuildsRetailPTR.Text = "Retail PTR:";
			this.lblInfoBuildsRetailStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoBuildsRetailStatus.AutoEllipsis = true;
			this.lblInfoBuildsRetailStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsRetailStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsRetailStatus.Location = new global::System.Drawing.Point(325, 110);
			this.lblInfoBuildsRetailStatus.Name = "lblInfoBuildsRetailStatus";
			this.lblInfoBuildsRetailStatus.Size = new global::System.Drawing.Size(272, 15);
			this.lblInfoBuildsRetailStatus.TabIndex = 27;
			this.lblInfoBuildsRetailStatus.Text = "[STATUS]";
			this.lblInfoBuildsRetailStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoBuildsRetail.AutoSize = true;
			this.lblInfoBuildsRetail.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsRetail.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsRetail.Location = new global::System.Drawing.Point(22, 110);
			this.lblInfoBuildsRetail.Name = "lblInfoBuildsRetail";
			this.lblInfoBuildsRetail.Size = new global::System.Drawing.Size(39, 15);
			this.lblInfoBuildsRetail.TabIndex = 26;
			this.lblInfoBuildsRetail.Text = "Retail:";
			this.lblInfoBuildsClassicEraPTRBuild.AutoSize = true;
			this.lblInfoBuildsClassicEraPTRBuild.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicEraPTRBuild.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicEraPTRBuild.Location = new global::System.Drawing.Point(177, 85);
			this.lblInfoBuildsClassicEraPTRBuild.Name = "lblInfoBuildsClassicEraPTRBuild";
			this.lblInfoBuildsClassicEraPTRBuild.Size = new global::System.Drawing.Size(47, 15);
			this.lblInfoBuildsClassicEraPTRBuild.TabIndex = 25;
			this.lblInfoBuildsClassicEraPTRBuild.Text = "[BUILD]";
			this.lblInfoBuildsClassicEraBuild.AutoSize = true;
			this.lblInfoBuildsClassicEraBuild.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicEraBuild.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicEraBuild.Location = new global::System.Drawing.Point(177, 85);
			this.lblInfoBuildsClassicEraBuild.Name = "lblInfoBuildsClassicEraBuild";
			this.lblInfoBuildsClassicEraBuild.Size = new global::System.Drawing.Size(47, 15);
			this.lblInfoBuildsClassicEraBuild.TabIndex = 24;
			this.lblInfoBuildsClassicEraBuild.Text = "[BUILD]";
			this.lblInfoBuildsClassicPTRBuild.AutoSize = true;
			this.lblInfoBuildsClassicPTRBuild.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicPTRBuild.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicPTRBuild.Location = new global::System.Drawing.Point(177, 60);
			this.lblInfoBuildsClassicPTRBuild.Name = "lblInfoBuildsClassicPTRBuild";
			this.lblInfoBuildsClassicPTRBuild.Size = new global::System.Drawing.Size(47, 15);
			this.lblInfoBuildsClassicPTRBuild.TabIndex = 23;
			this.lblInfoBuildsClassicPTRBuild.Text = "[BUILD]";
			this.lblInfoBuildsClassicBuild.AutoSize = true;
			this.lblInfoBuildsClassicBuild.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicBuild.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicBuild.Location = new global::System.Drawing.Point(177, 60);
			this.lblInfoBuildsClassicBuild.Name = "lblInfoBuildsClassicBuild";
			this.lblInfoBuildsClassicBuild.Size = new global::System.Drawing.Size(47, 15);
			this.lblInfoBuildsClassicBuild.TabIndex = 22;
			this.lblInfoBuildsClassicBuild.Text = "[BUILD]";
			this.lblInfoBuildsClassicEraPTRStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoBuildsClassicEraPTRStatus.AutoEllipsis = true;
			this.lblInfoBuildsClassicEraPTRStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicEraPTRStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicEraPTRStatus.Location = new global::System.Drawing.Point(324, 85);
			this.lblInfoBuildsClassicEraPTRStatus.Name = "lblInfoBuildsClassicEraPTRStatus";
			this.lblInfoBuildsClassicEraPTRStatus.Size = new global::System.Drawing.Size(272, 15);
			this.lblInfoBuildsClassicEraPTRStatus.TabIndex = 21;
			this.lblInfoBuildsClassicEraPTRStatus.Text = "[STATUS]";
			this.lblInfoBuildsClassicEraPTRStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoBuildsClassicEraPTR.AutoSize = true;
			this.lblInfoBuildsClassicEraPTR.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicEraPTR.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicEraPTR.Location = new global::System.Drawing.Point(22, 85);
			this.lblInfoBuildsClassicEraPTR.Name = "lblInfoBuildsClassicEraPTR";
			this.lblInfoBuildsClassicEraPTR.Size = new global::System.Drawing.Size(88, 15);
			this.lblInfoBuildsClassicEraPTR.TabIndex = 20;
			this.lblInfoBuildsClassicEraPTR.Text = "Classic Era PTR:";
			this.lblInfoBuildsClassicEraStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoBuildsClassicEraStatus.AutoEllipsis = true;
			this.lblInfoBuildsClassicEraStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicEraStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicEraStatus.Location = new global::System.Drawing.Point(325, 85);
			this.lblInfoBuildsClassicEraStatus.Name = "lblInfoBuildsClassicEraStatus";
			this.lblInfoBuildsClassicEraStatus.Size = new global::System.Drawing.Size(272, 15);
			this.lblInfoBuildsClassicEraStatus.TabIndex = 19;
			this.lblInfoBuildsClassicEraStatus.Text = "[STATUS]";
			this.lblInfoBuildsClassicEraStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoBuildsClassicEra.AutoSize = true;
			this.lblInfoBuildsClassicEra.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicEra.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicEra.Location = new global::System.Drawing.Point(22, 85);
			this.lblInfoBuildsClassicEra.Name = "lblInfoBuildsClassicEra";
			this.lblInfoBuildsClassicEra.Size = new global::System.Drawing.Size(65, 15);
			this.lblInfoBuildsClassicEra.TabIndex = 18;
			this.lblInfoBuildsClassicEra.Text = "Classic Era:";
			this.lblInfoBuildsClassicPTRStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoBuildsClassicPTRStatus.AutoEllipsis = true;
			this.lblInfoBuildsClassicPTRStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicPTRStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicPTRStatus.Location = new global::System.Drawing.Point(325, 60);
			this.lblInfoBuildsClassicPTRStatus.Name = "lblInfoBuildsClassicPTRStatus";
			this.lblInfoBuildsClassicPTRStatus.Size = new global::System.Drawing.Size(272, 15);
			this.lblInfoBuildsClassicPTRStatus.TabIndex = 17;
			this.lblInfoBuildsClassicPTRStatus.Text = "[STATUS]";
			this.lblInfoBuildsClassicPTRStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoBuildsClassicPTR.AutoSize = true;
			this.lblInfoBuildsClassicPTR.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicPTR.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicPTR.Location = new global::System.Drawing.Point(22, 60);
			this.lblInfoBuildsClassicPTR.Name = "lblInfoBuildsClassicPTR";
			this.lblInfoBuildsClassicPTR.Size = new global::System.Drawing.Size(69, 15);
			this.lblInfoBuildsClassicPTR.TabIndex = 16;
			this.lblInfoBuildsClassicPTR.Text = "Classic PTR:";
			this.lblInfoBuildsClassicStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoBuildsClassicStatus.AutoEllipsis = true;
			this.lblInfoBuildsClassicStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassicStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassicStatus.Location = new global::System.Drawing.Point(325, 60);
			this.lblInfoBuildsClassicStatus.Name = "lblInfoBuildsClassicStatus";
			this.lblInfoBuildsClassicStatus.Size = new global::System.Drawing.Size(272, 15);
			this.lblInfoBuildsClassicStatus.TabIndex = 15;
			this.lblInfoBuildsClassicStatus.Text = "[STATUS]";
			this.lblInfoBuildsClassicStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInfoBuildsClassic.AutoSize = true;
			this.lblInfoBuildsClassic.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoBuildsClassic.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoBuildsClassic.Location = new global::System.Drawing.Point(22, 60);
			this.lblInfoBuildsClassic.Name = "lblInfoBuildsClassic";
			this.lblInfoBuildsClassic.Size = new global::System.Drawing.Size(46, 15);
			this.lblInfoBuildsClassic.TabIndex = 14;
			this.lblInfoBuildsClassic.Text = "Classic:";
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.btnInfoTooltip);
			this.panelBox1.Controls.Add(this.tabs);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 22);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(894, 607);
			this.panelBox1.TabIndex = 67;
			this.btnInfoTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnInfoTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnInfoTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnInfoTooltip.BorderRadius = 4;
			this.btnInfoTooltip.BorderThickness = 1;
			this.btnInfoTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnInfoTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnInfoTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnInfoTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnInfoTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnInfoTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnInfoTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnInfoTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnInfoTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnInfoTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnInfoTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnInfoTooltip.Location = new global::System.Drawing.Point(839, 13);
			this.btnInfoTooltip.Name = "btnInfoTooltip";
			this.btnInfoTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnInfoTooltip.TabIndex = 73;
			this.btnInfoTooltip.Click += new global::System.EventHandler(this.btnInfoTooltip_Click);
			this.tabs.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabBuilds);
			this.tabs.Controls.Add(this.tabChangelog);
			this.tabs.Controls.Add(this.tabLog);
			this.tabs.Controls.Add(this.tabJack);
			this.tabs.Controls.Add(this.tabAutoReconnect);
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
			this.tabBuilds.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabBuilds.Controls.Add(this.panelTabBuilds);
			this.tabBuilds.ForeColor = global::System.Drawing.Color.White;
			this.tabBuilds.Location = new global::System.Drawing.Point(184, 4);
			this.tabBuilds.Name = "tabBuilds";
			this.tabBuilds.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabBuilds.Size = new global::System.Drawing.Size(680, 530);
			this.tabBuilds.TabIndex = 0;
			this.tabBuilds.Text = "Builds";
			this.panelTabBuilds.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabBuilds.AutoScroll = true;
			this.panelTabBuilds.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabBuilds.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabBuilds.Controls.Add(this.grpInfoBuildsPTR);
			this.panelTabBuilds.Controls.Add(this.grpInfoBuildsJack);
			this.panelTabBuilds.Controls.Add(this.grpInfoBuildsLive);
			this.panelTabBuilds.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabBuilds.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabBuilds.Name = "panelTabBuilds";
			this.panelTabBuilds.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabBuilds.TabIndex = 24;
			this.grpInfoBuildsPTR.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInfoBuildsPTR.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsRetailPTRBuild);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsRetailPTRStatus);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsClassicPTR);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsRetailPTR);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsClassicEraPTR);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsClassicEraPTRStatus);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsClassicPTRBuild);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsClassicPTRStatus);
			this.grpInfoBuildsPTR.Controls.Add(this.lblInfoBuildsClassicEraPTRBuild);
			this.grpInfoBuildsPTR.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoBuildsPTR.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInfoBuildsPTR.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInfoBuildsPTR.ForeColor = global::System.Drawing.Color.White;
			this.grpInfoBuildsPTR.Location = new global::System.Drawing.Point(14, 175);
			this.grpInfoBuildsPTR.Name = "grpInfoBuildsPTR";
			this.grpInfoBuildsPTR.Size = new global::System.Drawing.Size(618, 145);
			this.grpInfoBuildsPTR.TabIndex = 24;
			this.grpInfoBuildsPTR.Text = "PTR";
			this.grpInfoBuildsJack.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInfoBuildsJack.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoBuildsJack.Controls.Add(this.lblAddonSettingsPrintVersion);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoAddonLatestData);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoAddonLatest);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoMapsRetailDownload);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoMapsClassicDownload);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoMapsRetailVersionData);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoMapsRetailVersion);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoMapsClassicVersionData);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoMapsClassicVersion);
			this.grpInfoBuildsJack.Controls.Add(this.btnInfoBuildsJackUpdates);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoJackLatestData);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoJackVersionData);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoJackVersion);
			this.grpInfoBuildsJack.Controls.Add(this.lblInfoJackLatest);
			this.grpInfoBuildsJack.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoBuildsJack.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInfoBuildsJack.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInfoBuildsJack.ForeColor = global::System.Drawing.Color.White;
			this.grpInfoBuildsJack.Location = new global::System.Drawing.Point(14, 335);
			this.grpInfoBuildsJack.Name = "grpInfoBuildsJack";
			this.grpInfoBuildsJack.Size = new global::System.Drawing.Size(618, 247);
			this.grpInfoBuildsJack.TabIndex = 23;
			this.grpInfoBuildsJack.Text = "Jack";
			this.lblInfoMapsRetailDownload.AutoSize = true;
			this.lblInfoMapsRetailDownload.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoMapsRetailDownload.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblInfoMapsRetailDownload.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblInfoMapsRetailDownload.Location = new global::System.Drawing.Point(325, 160);
			this.lblInfoMapsRetailDownload.Name = "lblInfoMapsRetailDownload";
			this.lblInfoMapsRetailDownload.Size = new global::System.Drawing.Size(61, 15);
			this.lblInfoMapsRetailDownload.TabIndex = 75;
			this.lblInfoMapsRetailDownload.Text = "Download";
			this.lblInfoMapsRetailDownload.Visible = false;
			this.lblInfoMapsRetailDownload.Click += new global::System.EventHandler(this.lblInfoMapsRetailDownload_Click);
			this.lblInfoMapsClassicDownload.AutoSize = true;
			this.lblInfoMapsClassicDownload.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoMapsClassicDownload.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblInfoMapsClassicDownload.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblInfoMapsClassicDownload.Location = new global::System.Drawing.Point(325, 135);
			this.lblInfoMapsClassicDownload.Name = "lblInfoMapsClassicDownload";
			this.lblInfoMapsClassicDownload.Size = new global::System.Drawing.Size(61, 15);
			this.lblInfoMapsClassicDownload.TabIndex = 74;
			this.lblInfoMapsClassicDownload.Text = "Download";
			this.lblInfoMapsClassicDownload.Visible = false;
			this.lblInfoMapsClassicDownload.Click += new global::System.EventHandler(this.lblInfoMapsClassicDownload_Click);
			this.lblInfoMapsRetailVersionData.AutoSize = true;
			this.lblInfoMapsRetailVersionData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoMapsRetailVersionData.Location = new global::System.Drawing.Point(177, 160);
			this.lblInfoMapsRetailVersionData.Name = "lblInfoMapsRetailVersionData";
			this.lblInfoMapsRetailVersionData.Size = new global::System.Drawing.Size(62, 15);
			this.lblInfoMapsRetailVersionData.TabIndex = 73;
			this.lblInfoMapsRetailVersionData.Text = "[VERSION]";
			this.lblInfoMapsRetailVersion.AutoSize = true;
			this.lblInfoMapsRetailVersion.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoMapsRetailVersion.Location = new global::System.Drawing.Point(22, 160);
			this.lblInfoMapsRetailVersion.Name = "lblInfoMapsRetailVersion";
			this.lblInfoMapsRetailVersion.Size = new global::System.Drawing.Size(71, 15);
			this.lblInfoMapsRetailVersion.TabIndex = 72;
			this.lblInfoMapsRetailVersion.Text = "Retail Maps:";
			this.lblInfoMapsClassicVersionData.AutoSize = true;
			this.lblInfoMapsClassicVersionData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoMapsClassicVersionData.Location = new global::System.Drawing.Point(177, 135);
			this.lblInfoMapsClassicVersionData.Name = "lblInfoMapsClassicVersionData";
			this.lblInfoMapsClassicVersionData.Size = new global::System.Drawing.Size(62, 15);
			this.lblInfoMapsClassicVersionData.TabIndex = 71;
			this.lblInfoMapsClassicVersionData.Text = "[VERSION]";
			this.lblInfoMapsClassicVersion.AutoSize = true;
			this.lblInfoMapsClassicVersion.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoMapsClassicVersion.Location = new global::System.Drawing.Point(22, 135);
			this.lblInfoMapsClassicVersion.Name = "lblInfoMapsClassicVersion";
			this.lblInfoMapsClassicVersion.Size = new global::System.Drawing.Size(78, 15);
			this.lblInfoMapsClassicVersion.TabIndex = 70;
			this.lblInfoMapsClassicVersion.Text = "Classic Maps:";
			this.btnInfoBuildsJackUpdates.BorderColor = global::System.Drawing.Color.Gray;
			this.btnInfoBuildsJackUpdates.BorderThickness = 1;
			this.btnInfoBuildsJackUpdates.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnInfoBuildsJackUpdates.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnInfoBuildsJackUpdates.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnInfoBuildsJackUpdates.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnInfoBuildsJackUpdates.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnInfoBuildsJackUpdates.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnInfoBuildsJackUpdates.ForeColor = global::System.Drawing.Color.White;
			this.btnInfoBuildsJackUpdates.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnInfoBuildsJackUpdates.Location = new global::System.Drawing.Point(25, 195);
			this.btnInfoBuildsJackUpdates.Name = "btnInfoBuildsJackUpdates";
			this.btnInfoBuildsJackUpdates.Size = new global::System.Drawing.Size(158, 30);
			this.btnInfoBuildsJackUpdates.TabIndex = 69;
			this.btnInfoBuildsJackUpdates.Text = "Check for Updates";
			this.btnInfoBuildsJackUpdates.Click += new global::System.EventHandler(this.btnInfoBuildsJackUpdates_Click);
			this.grpInfoBuildsLive.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInfoBuildsLive.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsRetailBuild);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsRetailStatus);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsClassic);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsRetail);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsClassicStatus);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsClassicEraBuild);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsClassicEra);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsClassicBuild);
			this.grpInfoBuildsLive.Controls.Add(this.lblInfoBuildsClassicEraStatus);
			this.grpInfoBuildsLive.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoBuildsLive.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInfoBuildsLive.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInfoBuildsLive.ForeColor = global::System.Drawing.Color.White;
			this.grpInfoBuildsLive.Location = new global::System.Drawing.Point(14, 14);
			this.grpInfoBuildsLive.Name = "grpInfoBuildsLive";
			this.grpInfoBuildsLive.Size = new global::System.Drawing.Size(618, 145);
			this.grpInfoBuildsLive.TabIndex = 7;
			this.grpInfoBuildsLive.Text = "Live";
			this.tabChangelog.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.tabChangelog.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabChangelog.Controls.Add(this.grpInfoChangelog);
			this.tabChangelog.ForeColor = global::System.Drawing.Color.White;
			this.tabChangelog.Location = new global::System.Drawing.Point(184, 4);
			this.tabChangelog.Name = "tabChangelog";
			this.tabChangelog.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabChangelog.Size = new global::System.Drawing.Size(680, 530);
			this.tabChangelog.TabIndex = 1;
			this.tabChangelog.Text = "Changelog";
			this.grpInfoChangelog.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInfoChangelog.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoChangelog.Controls.Add(this.richInfoChangelog);
			this.grpInfoChangelog.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoChangelog.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInfoChangelog.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInfoChangelog.ForeColor = global::System.Drawing.Color.White;
			this.grpInfoChangelog.Location = new global::System.Drawing.Point(14, 14);
			this.grpInfoChangelog.Name = "grpInfoChangelog";
			this.grpInfoChangelog.Size = new global::System.Drawing.Size(652, 503);
			this.grpInfoChangelog.TabIndex = 6;
			this.grpInfoChangelog.Text = "Changelog";
			this.richInfoChangelog.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richInfoChangelog.BackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.richInfoChangelog.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richInfoChangelog.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.richInfoChangelog.ForeColor = global::System.Drawing.Color.White;
			this.richInfoChangelog.Location = new global::System.Drawing.Point(13, 53);
			this.richInfoChangelog.Name = "richInfoChangelog";
			this.richInfoChangelog.ReadOnly = true;
			this.richInfoChangelog.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richInfoChangelog.Size = new global::System.Drawing.Size(625, 437);
			this.richInfoChangelog.TabIndex = 11;
			this.richInfoChangelog.Text = "";
			this.tabLog.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabLog.Controls.Add(this.grpLog);
			this.tabLog.Location = new global::System.Drawing.Point(184, 4);
			this.tabLog.Name = "tabLog";
			this.tabLog.Size = new global::System.Drawing.Size(680, 530);
			this.tabLog.TabIndex = 2;
			this.tabLog.Text = "Log";
			this.grpLog.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpLog.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpLog.Controls.Add(this.listLogs);
			this.grpLog.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpLog.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpLog.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpLog.ForeColor = global::System.Drawing.Color.White;
			this.grpLog.Location = new global::System.Drawing.Point(14, 14);
			this.grpLog.Name = "grpLog";
			this.grpLog.Size = new global::System.Drawing.Size(652, 503);
			this.grpLog.TabIndex = 7;
			this.grpLog.Text = "Log";
			this.listLogs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listLogs.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listLogs.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listLogsDate
			});
			this.listLogs.ForeColor = global::System.Drawing.Color.White;
			this.listLogs.FullRowSelect = true;
			this.listLogs.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listLogs.HideSelection = false;
			this.listLogs.Location = new global::System.Drawing.Point(13, 53);
			this.listLogs.Name = "listLogs";
			this.listLogs.OwnerDraw = true;
			this.listLogs.Size = new global::System.Drawing.Size(626, 438);
			this.listLogs.TabIndex = 52;
			this.listLogs.UseCompatibleStateImageBehavior = false;
			this.listLogs.View = global::System.Windows.Forms.View.Details;
			this.listLogs.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listLogs_MouseDoubleClick);
			this.listLogs.Resize += new global::System.EventHandler(this.listLogs_Resize);
			this.listLogsDate.Text = "Date";
			this.listLogsDate.Width = 300;
			this.tabJack.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabJack.Controls.Add(this.panelTabJack);
			this.tabJack.Location = new global::System.Drawing.Point(184, 4);
			this.tabJack.Name = "tabJack";
			this.tabJack.Size = new global::System.Drawing.Size(680, 530);
			this.tabJack.TabIndex = 3;
			this.tabJack.Text = "Jack";
			this.panelTabJack.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabJack.AutoScroll = true;
			this.panelTabJack.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabJack.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabJack.Controls.Add(this.grpSettingsJack);
			this.panelTabJack.Controls.Add(this.grpSettingsGame);
			this.panelTabJack.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabJack.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabJack.Name = "panelTabJack";
			this.panelTabJack.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabJack.TabIndex = 25;
			this.grpSettingsJack.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsJack.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsJack.Controls.Add(this.lblSettingsJackTray);
			this.grpSettingsJack.Controls.Add(this.checkSettingsJackTray);
			this.grpSettingsJack.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsJack.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsJack.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsJack.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsJack.Location = new global::System.Drawing.Point(14, 125);
			this.grpSettingsJack.Name = "grpSettingsJack";
			this.grpSettingsJack.Size = new global::System.Drawing.Size(652, 96);
			this.grpSettingsJack.TabIndex = 11;
			this.grpSettingsJack.Text = "Jack";
			this.lblSettingsJackTray.AutoSize = true;
			this.lblSettingsJackTray.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsJackTray.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsJackTray.Location = new global::System.Drawing.Point(22, 61);
			this.lblSettingsJackTray.Name = "lblSettingsJackTray";
			this.lblSettingsJackTray.Size = new global::System.Drawing.Size(54, 15);
			this.lblSettingsJackTray.TabIndex = 72;
			this.lblSettingsJackTray.Text = "Window:";
			this.checkSettingsJackTray.Animated = true;
			this.checkSettingsJackTray.AutoSize = true;
			this.checkSettingsJackTray.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsJackTray.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsJackTray.CheckedState.BorderRadius = 0;
			this.checkSettingsJackTray.CheckedState.BorderThickness = 0;
			this.checkSettingsJackTray.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsJackTray.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkSettingsJackTray.Location = new global::System.Drawing.Point(180, 60);
			this.checkSettingsJackTray.Name = "checkSettingsJackTray";
			this.checkSettingsJackTray.Size = new global::System.Drawing.Size(160, 19);
			this.checkSettingsJackTray.TabIndex = 71;
			this.checkSettingsJackTray.Text = "Minimize to Tray on close";
			this.checkSettingsJackTray.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsJackTray.UncheckedState.BorderRadius = 0;
			this.checkSettingsJackTray.UncheckedState.BorderThickness = 1;
			this.checkSettingsJackTray.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsJackTray.UseVisualStyleBackColor = false;
			this.checkSettingsJackTray.CheckedChanged += new global::System.EventHandler(this.checkSettingsJackTray_CheckedChanged);
			this.grpSettingsGame.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsGame.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsGame.Controls.Add(this.imgModuleSession);
			this.grpSettingsGame.Controls.Add(this.checkSettingsGameAutoDetect);
			this.grpSettingsGame.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsGame.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsGame.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsGame.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsGame.Location = new global::System.Drawing.Point(14, 14);
			this.grpSettingsGame.Name = "grpSettingsGame";
			this.grpSettingsGame.Size = new global::System.Drawing.Size(652, 96);
			this.grpSettingsGame.TabIndex = 10;
			this.grpSettingsGame.Text = "Game";
			this.imgModuleSession.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgModuleSession.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleSession.Image = global::Jack.Properties.Resources.module_sessions;
			this.imgModuleSession.ImageRotate = 0f;
			this.imgModuleSession.Location = new global::System.Drawing.Point(515, 7);
			this.imgModuleSession.Name = "imgModuleSession";
			this.imgModuleSession.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleSession.TabIndex = 88;
			this.imgModuleSession.TabStop = false;
			this.checkSettingsGameAutoDetect.Animated = true;
			this.checkSettingsGameAutoDetect.AutoSize = true;
			this.checkSettingsGameAutoDetect.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsGameAutoDetect.Checked = true;
			this.checkSettingsGameAutoDetect.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsGameAutoDetect.CheckedState.BorderRadius = 0;
			this.checkSettingsGameAutoDetect.CheckedState.BorderThickness = 0;
			this.checkSettingsGameAutoDetect.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsGameAutoDetect.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkSettingsGameAutoDetect.ForeColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsGameAutoDetect.Location = new global::System.Drawing.Point(22, 60);
			this.checkSettingsGameAutoDetect.Name = "checkSettingsGameAutoDetect";
			this.checkSettingsGameAutoDetect.Size = new global::System.Drawing.Size(172, 19);
			this.checkSettingsGameAutoDetect.TabIndex = 72;
			this.checkSettingsGameAutoDetect.Text = "Auto-Detect Game Window";
			this.checkSettingsGameAutoDetect.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsGameAutoDetect.UncheckedState.BorderRadius = 0;
			this.checkSettingsGameAutoDetect.UncheckedState.BorderThickness = 1;
			this.checkSettingsGameAutoDetect.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsGameAutoDetect.UseVisualStyleBackColor = false;
			this.checkSettingsGameAutoDetect.CheckedChanged += new global::System.EventHandler(this.checkSettingsGameAutoDetect_CheckedChanged);
			this.tabAutoReconnect.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabAutoReconnect.Controls.Add(this.panelTabAutoReconnect);
			this.tabAutoReconnect.Location = new global::System.Drawing.Point(184, 4);
			this.tabAutoReconnect.Name = "tabAutoReconnect";
			this.tabAutoReconnect.Size = new global::System.Drawing.Size(680, 530);
			this.tabAutoReconnect.TabIndex = 4;
			this.tabAutoReconnect.Text = "Auto-Reconnect";
			this.panelTabAutoReconnect.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabAutoReconnect.AutoScroll = true;
			this.panelTabAutoReconnect.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabAutoReconnect.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabAutoReconnect.Controls.Add(this.grpAutoReconnect);
			this.panelTabAutoReconnect.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabAutoReconnect.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabAutoReconnect.Name = "panelTabAutoReconnect";
			this.panelTabAutoReconnect.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabAutoReconnect.TabIndex = 26;
			this.grpAutoReconnect.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAutoReconnect.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpAutoReconnect.Controls.Add(this.btnAutoReconnectSave);
			this.grpAutoReconnect.Controls.Add(this.txtAutoReconnectPassword);
			this.grpAutoReconnect.Controls.Add(this.checkAutoReconnect);
			this.grpAutoReconnect.Controls.Add(this.lblAutoReconnectPassword);
			this.grpAutoReconnect.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpAutoReconnect.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpAutoReconnect.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAutoReconnect.ForeColor = global::System.Drawing.Color.White;
			this.grpAutoReconnect.Location = new global::System.Drawing.Point(14, 14);
			this.grpAutoReconnect.Name = "grpAutoReconnect";
			this.grpAutoReconnect.Size = new global::System.Drawing.Size(652, 110);
			this.grpAutoReconnect.TabIndex = 8;
			this.btnAutoReconnectSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAutoReconnectSave.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAutoReconnectSave.BorderThickness = 1;
			this.btnAutoReconnectSave.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAutoReconnectSave.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAutoReconnectSave.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAutoReconnectSave.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAutoReconnectSave.Enabled = false;
			this.btnAutoReconnectSave.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAutoReconnectSave.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAutoReconnectSave.ForeColor = global::System.Drawing.Color.White;
			this.btnAutoReconnectSave.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAutoReconnectSave.Location = new global::System.Drawing.Point(525, 60);
			this.btnAutoReconnectSave.Name = "btnAutoReconnectSave";
			this.btnAutoReconnectSave.Size = new global::System.Drawing.Size(104, 30);
			this.btnAutoReconnectSave.TabIndex = 68;
			this.btnAutoReconnectSave.Text = "Save";
			this.btnAutoReconnectSave.Click += new global::System.EventHandler(this.btnAutoReconnectSave_Click);
			this.txtAutoReconnectPassword.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtAutoReconnectPassword.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAutoReconnectPassword.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtAutoReconnectPassword.DefaultText = "";
			this.txtAutoReconnectPassword.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAutoReconnectPassword.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtAutoReconnectPassword.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAutoReconnectPassword.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAutoReconnectPassword.Enabled = false;
			this.txtAutoReconnectPassword.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtAutoReconnectPassword.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtAutoReconnectPassword.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtAutoReconnectPassword.ForeColor = global::System.Drawing.Color.White;
			this.txtAutoReconnectPassword.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtAutoReconnectPassword.Location = new global::System.Drawing.Point(180, 60);
			this.txtAutoReconnectPassword.MaxLength = 200;
			this.txtAutoReconnectPassword.Name = "txtAutoReconnectPassword";
			this.txtAutoReconnectPassword.PasswordChar = '●';
			this.txtAutoReconnectPassword.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtAutoReconnectPassword.PlaceholderText = "";
			this.txtAutoReconnectPassword.SelectedText = "";
			this.txtAutoReconnectPassword.Size = new global::System.Drawing.Size(339, 30);
			this.txtAutoReconnectPassword.TabIndex = 67;
			this.txtAutoReconnectPassword.UseSystemPasswordChar = true;
			this.checkAutoReconnect.Animated = true;
			this.checkAutoReconnect.AutoSize = true;
			this.checkAutoReconnect.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAutoReconnect.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAutoReconnect.CheckedState.BorderRadius = 0;
			this.checkAutoReconnect.CheckedState.BorderThickness = 0;
			this.checkAutoReconnect.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAutoReconnect.Location = new global::System.Drawing.Point(12, 11);
			this.checkAutoReconnect.Name = "checkAutoReconnect";
			this.checkAutoReconnect.Size = new global::System.Drawing.Size(188, 19);
			this.checkAutoReconnect.TabIndex = 32;
			this.checkAutoReconnect.Text = "Reconnect when disconnected";
			this.checkAutoReconnect.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkAutoReconnect.UncheckedState.BorderRadius = 0;
			this.checkAutoReconnect.UncheckedState.BorderThickness = 1;
			this.checkAutoReconnect.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkAutoReconnect.UseVisualStyleBackColor = false;
			this.checkAutoReconnect.CheckedChanged += new global::System.EventHandler(this.checkAutoReconnect_CheckedChanged);
			this.lblAutoReconnectPassword.AutoSize = true;
			this.lblAutoReconnectPassword.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAutoReconnectPassword.Enabled = false;
			this.lblAutoReconnectPassword.Location = new global::System.Drawing.Point(22, 66);
			this.lblAutoReconnectPassword.Name = "lblAutoReconnectPassword";
			this.lblAutoReconnectPassword.Size = new global::System.Drawing.Size(60, 15);
			this.lblAutoReconnectPassword.TabIndex = 21;
			this.lblAutoReconnectPassword.Text = "Password:";
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
			this.lblTitle.Size = new global::System.Drawing.Size(103, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Settings";
			this.lblInfoAddonLatestData.AutoSize = true;
			this.lblInfoAddonLatestData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoAddonLatestData.Location = new global::System.Drawing.Point(177, 110);
			this.lblInfoAddonLatestData.Name = "lblInfoAddonLatestData";
			this.lblInfoAddonLatestData.Size = new global::System.Drawing.Size(62, 15);
			this.lblInfoAddonLatestData.TabIndex = 77;
			this.lblInfoAddonLatestData.Text = "[VERSION]";
			this.lblInfoAddonLatest.AutoSize = true;
			this.lblInfoAddonLatest.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoAddonLatest.Location = new global::System.Drawing.Point(22, 110);
			this.lblInfoAddonLatest.Name = "lblInfoAddonLatest";
			this.lblInfoAddonLatest.Size = new global::System.Drawing.Size(46, 15);
			this.lblInfoAddonLatest.TabIndex = 76;
			this.lblInfoAddonLatest.Text = "Addon:";
			this.lblAddonSettingsPrintVersion.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAddonSettingsPrintVersion.AutoEllipsis = true;
			this.lblAddonSettingsPrintVersion.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddonSettingsPrintVersion.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblAddonSettingsPrintVersion.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblAddonSettingsPrintVersion.Location = new global::System.Drawing.Point(325, 110);
			this.lblAddonSettingsPrintVersion.Name = "lblAddonSettingsPrintVersion";
			this.lblAddonSettingsPrintVersion.Size = new global::System.Drawing.Size(271, 15);
			this.lblAddonSettingsPrintVersion.TabIndex = 78;
			this.lblAddonSettingsPrintVersion.Text = "Show installed version";
			this.lblAddonSettingsPrintVersion.Click += new global::System.EventHandler(this.lblAddonSettingsPrintVersion_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 629);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainSettings";
			this.Text = "frmMainSettings";
			base.Load += new global::System.EventHandler(this.frmMainSettings_Load);
			base.Shown += new global::System.EventHandler(this.frmMainSettings_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainSettings_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabBuilds.ResumeLayout(false);
			this.panelTabBuilds.ResumeLayout(false);
			this.grpInfoBuildsPTR.ResumeLayout(false);
			this.grpInfoBuildsPTR.PerformLayout();
			this.grpInfoBuildsJack.ResumeLayout(false);
			this.grpInfoBuildsJack.PerformLayout();
			this.grpInfoBuildsLive.ResumeLayout(false);
			this.grpInfoBuildsLive.PerformLayout();
			this.tabChangelog.ResumeLayout(false);
			this.grpInfoChangelog.ResumeLayout(false);
			this.tabLog.ResumeLayout(false);
			this.grpLog.ResumeLayout(false);
			this.tabJack.ResumeLayout(false);
			this.panelTabJack.ResumeLayout(false);
			this.grpSettingsJack.ResumeLayout(false);
			this.grpSettingsJack.PerformLayout();
			this.grpSettingsGame.ResumeLayout(false);
			this.grpSettingsGame.PerformLayout();
			this.imgModuleSession.EndInit();
			this.tabAutoReconnect.ResumeLayout(false);
			this.panelTabAutoReconnect.ResumeLayout(false);
			this.grpAutoReconnect.ResumeLayout(false);
			this.grpAutoReconnect.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000624 RID: 1572
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000625 RID: 1573
		private global::System.Windows.Forms.Label lblInfoJackLatestData;

		// Token: 0x04000626 RID: 1574
		private global::System.Windows.Forms.Label lblInfoJackVersionData;

		// Token: 0x04000627 RID: 1575
		private global::System.Windows.Forms.Label lblInfoJackLatest;

		// Token: 0x04000628 RID: 1576
		private global::System.Windows.Forms.Label lblInfoJackVersion;

		// Token: 0x04000629 RID: 1577
		private global::System.Windows.Forms.Label lblInfoBuildsRetailPTRBuild;

		// Token: 0x0400062A RID: 1578
		private global::System.Windows.Forms.Label lblInfoBuildsRetailBuild;

		// Token: 0x0400062B RID: 1579
		private global::System.Windows.Forms.Label lblInfoBuildsRetailPTRStatus;

		// Token: 0x0400062C RID: 1580
		private global::System.Windows.Forms.Label lblInfoBuildsRetailPTR;

		// Token: 0x0400062D RID: 1581
		private global::System.Windows.Forms.Label lblInfoBuildsRetailStatus;

		// Token: 0x0400062E RID: 1582
		private global::System.Windows.Forms.Label lblInfoBuildsRetail;

		// Token: 0x0400062F RID: 1583
		private global::System.Windows.Forms.Label lblInfoBuildsClassicEraPTRBuild;

		// Token: 0x04000630 RID: 1584
		private global::System.Windows.Forms.Label lblInfoBuildsClassicEraBuild;

		// Token: 0x04000631 RID: 1585
		private global::System.Windows.Forms.Label lblInfoBuildsClassicPTRBuild;

		// Token: 0x04000632 RID: 1586
		private global::System.Windows.Forms.Label lblInfoBuildsClassicBuild;

		// Token: 0x04000633 RID: 1587
		private global::System.Windows.Forms.Label lblInfoBuildsClassicEraPTRStatus;

		// Token: 0x04000634 RID: 1588
		private global::System.Windows.Forms.Label lblInfoBuildsClassicEraPTR;

		// Token: 0x04000635 RID: 1589
		private global::System.Windows.Forms.Label lblInfoBuildsClassicEraStatus;

		// Token: 0x04000636 RID: 1590
		private global::System.Windows.Forms.Label lblInfoBuildsClassicEra;

		// Token: 0x04000637 RID: 1591
		private global::System.Windows.Forms.Label lblInfoBuildsClassicPTRStatus;

		// Token: 0x04000638 RID: 1592
		private global::System.Windows.Forms.Label lblInfoBuildsClassicPTR;

		// Token: 0x04000639 RID: 1593
		private global::System.Windows.Forms.Label lblInfoBuildsClassicStatus;

		// Token: 0x0400063A RID: 1594
		private global::System.Windows.Forms.Label lblInfoBuildsClassic;

		// Token: 0x0400063B RID: 1595
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400063C RID: 1596
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x0400063D RID: 1597
		private global::System.Windows.Forms.TabPage tabBuilds;

		// Token: 0x0400063E RID: 1598
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInfoBuildsLive;

		// Token: 0x0400063F RID: 1599
		private global::System.Windows.Forms.TabPage tabChangelog;

		// Token: 0x04000640 RID: 1600
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInfoChangelog;

		// Token: 0x04000641 RID: 1601
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x04000642 RID: 1602
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x04000643 RID: 1603
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x04000644 RID: 1604
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInfoBuildsJack;

		// Token: 0x04000645 RID: 1605
		private global::Guna.UI2.WinForms.Guna2Button btnInfoBuildsJackUpdates;

		// Token: 0x04000646 RID: 1606
		private global::System.Windows.Forms.RichTextBox richInfoChangelog;

		// Token: 0x04000647 RID: 1607
		private global::System.Windows.Forms.TabPage tabLog;

		// Token: 0x04000648 RID: 1608
		private global::Guna.UI2.WinForms.Guna2GroupBox grpLog;

		// Token: 0x04000649 RID: 1609
		private global::System.Windows.Forms.ListView listLogs;

		// Token: 0x0400064A RID: 1610
		private global::System.Windows.Forms.ColumnHeader listLogsDate;

		// Token: 0x0400064B RID: 1611
		private global::System.Windows.Forms.TabPage tabJack;

		// Token: 0x0400064C RID: 1612
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsGame;

		// Token: 0x0400064D RID: 1613
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsGameAutoDetect;

		// Token: 0x0400064E RID: 1614
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsJack;

		// Token: 0x0400064F RID: 1615
		private global::Guna.UI2.WinForms.Guna2Panel panelTabBuilds;

		// Token: 0x04000650 RID: 1616
		private global::Guna.UI2.WinForms.Guna2Panel panelTabJack;

		// Token: 0x04000651 RID: 1617
		private global::Guna.UI2.WinForms.Guna2Button btnInfoTooltip;

		// Token: 0x04000652 RID: 1618
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleSession;

		// Token: 0x04000653 RID: 1619
		private global::System.Windows.Forms.TabPage tabAutoReconnect;

		// Token: 0x04000654 RID: 1620
		private global::Guna.UI2.WinForms.Guna2Panel panelTabAutoReconnect;

		// Token: 0x04000655 RID: 1621
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAutoReconnect;

		// Token: 0x04000656 RID: 1622
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAutoReconnect;

		// Token: 0x04000657 RID: 1623
		private global::System.Windows.Forms.Label lblAutoReconnectPassword;

		// Token: 0x04000658 RID: 1624
		private global::Guna.UI2.WinForms.Guna2TextBox txtAutoReconnectPassword;

		// Token: 0x04000659 RID: 1625
		private global::Guna.UI2.WinForms.Guna2Button btnAutoReconnectSave;

		// Token: 0x0400065A RID: 1626
		private global::System.Windows.Forms.Label lblSettingsJackTray;

		// Token: 0x0400065B RID: 1627
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsJackTray;

		// Token: 0x0400065C RID: 1628
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInfoBuildsPTR;

		// Token: 0x0400065D RID: 1629
		private global::System.Windows.Forms.Label lblInfoMapsRetailVersionData;

		// Token: 0x0400065E RID: 1630
		private global::System.Windows.Forms.Label lblInfoMapsRetailVersion;

		// Token: 0x0400065F RID: 1631
		private global::System.Windows.Forms.Label lblInfoMapsClassicVersionData;

		// Token: 0x04000660 RID: 1632
		private global::System.Windows.Forms.Label lblInfoMapsClassicVersion;

		// Token: 0x04000661 RID: 1633
		private global::System.Windows.Forms.Label lblInfoMapsRetailDownload;

		// Token: 0x04000662 RID: 1634
		private global::System.Windows.Forms.Label lblInfoMapsClassicDownload;

		// Token: 0x04000663 RID: 1635
		private global::System.Windows.Forms.Label lblInfoAddonLatestData;

		// Token: 0x04000664 RID: 1636
		private global::System.Windows.Forms.Label lblInfoAddonLatest;

		// Token: 0x04000665 RID: 1637
		private global::System.Windows.Forms.Label lblAddonSettingsPrintVersion;
	}
}
