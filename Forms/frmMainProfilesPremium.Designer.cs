namespace Jack.Forms
{
	// Token: 0x0200006E RID: 110
	public partial class frmMainProfilesPremium : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A08 RID: 2568 RVA: 0x0068F848 File Offset: 0x0068DA48
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0068F874 File Offset: 0x0068DA74
		private void InitializeComponent()
		{
			this.panelBox2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabGeneral = new global::System.Windows.Forms.TabPage();
			this.panelTabGeneral = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpGeneralPREVIEW = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkGeneralBattlegroundEyeOfTheStorm = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkGeneralBattlegroundAlteracValley = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkGeneralBattlegroundArathiBasin = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkGeneralBattlegroundWarsongGulch = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.sepGeneral1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.checkGeneralFlightMount = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkGeneralGroundMount = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkGeneralFollowFleeingTarget = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectGeneralWaypointMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectGeneralCombatMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.tabMailbox = new global::System.Windows.Forms.TabPage();
			this.panelTabMailbox = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblMailboxStatus = new global::System.Windows.Forms.Label();
			this.grpMailboxPREVIEW = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnMailboxCopy = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnMailboxReceiverApply = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblMailboxTitle = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.btnMailboxSendlist = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtMailboxReceiver = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkMailboxSendPurples = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkMailboxSendGreys = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkMailboxSendBlues = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkMailboxSendGreens = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkMailboxSendWhites = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabVendor = new global::System.Windows.Forms.TabPage();
			this.panelTabVendor = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblVendorStatus = new global::System.Windows.Forms.Label();
			this.grpVendorPREVIEW = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnVendorCopy = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnVendorBuylist = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnVendorWhitelist = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkVendorCanRepair = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkVendorSellGreys = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkVendorSellBlues = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkVendorSellGreens = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkVendorSellWhites = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblVendorTitle = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.tabGathering = new global::System.Windows.Forms.TabPage();
			this.panelTabGathering = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblGatherStatus = new global::System.Windows.Forms.Label();
			this.grpSettingsLootPREVIEW = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnGatheringCopy = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgModuleGather = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.checkGatherSkinning = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkGatherHerbalism = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkGatherMining = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabInfo = new global::System.Windows.Forms.TabPage();
			this.panelTabInfo = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpInfoRequirements = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblInfoRequirementsSkillData = new global::System.Windows.Forms.Label();
			this.lblInfoRequirementsSkill = new global::System.Windows.Forms.Label();
			this.lblInfoRequirementsLevelData = new global::System.Windows.Forms.Label();
			this.lblInfoRequirementsLevel = new global::System.Windows.Forms.Label();
			this.grpInfoContact = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblInfoContactEmailData = new global::System.Windows.Forms.Label();
			this.lblInfoContactEmail = new global::System.Windows.Forms.Label();
			this.lblInfoContactDiscordUsernameData = new global::System.Windows.Forms.Label();
			this.lblInfoContactDiscordUsername = new global::System.Windows.Forms.Label();
			this.lblInfoContactStoreNameData = new global::System.Windows.Forms.Label();
			this.lblInfoContactStoreName = new global::System.Windows.Forms.Label();
			this.panelTitle2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle2 = new global::System.Windows.Forms.Label();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnClose = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkGeneralBattlegroundStrandOfTheAncients = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.panelBox2.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.panelTabGeneral.SuspendLayout();
			this.grpGeneralPREVIEW.SuspendLayout();
			this.tabMailbox.SuspendLayout();
			this.panelTabMailbox.SuspendLayout();
			this.grpMailboxPREVIEW.SuspendLayout();
			this.tabVendor.SuspendLayout();
			this.panelTabVendor.SuspendLayout();
			this.grpVendorPREVIEW.SuspendLayout();
			this.tabGathering.SuspendLayout();
			this.panelTabGathering.SuspendLayout();
			this.grpSettingsLootPREVIEW.SuspendLayout();
			this.imgModuleGather.BeginInit();
			this.tabInfo.SuspendLayout();
			this.panelTabInfo.SuspendLayout();
			this.grpInfoRequirements.SuspendLayout();
			this.grpInfoContact.SuspendLayout();
			this.panelTitle2.SuspendLayout();
			this.imgTitleEdge2.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.panelBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox2.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox2.Controls.Add(this.btnTooltip);
			this.panelBox2.Controls.Add(this.tabs);
			this.panelBox2.Controls.Add(this.panelTitle2);
			this.panelBox2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox2.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox2.Name = "panelBox2";
			this.panelBox2.Size = new global::System.Drawing.Size(632, 542);
			this.panelBox2.TabIndex = 72;
			this.btnTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnTooltip.BorderRadius = 4;
			this.btnTooltip.BorderThickness = 1;
			this.btnTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnTooltip.Location = new global::System.Drawing.Point(577, 13);
			this.btnTooltip.Name = "btnTooltip";
			this.btnTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnTooltip.TabIndex = 71;
			this.btnTooltip.Click += new global::System.EventHandler(this.btnTooltip_Click);
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabGeneral);
			this.tabs.Controls.Add(this.tabMailbox);
			this.tabs.Controls.Add(this.tabVendor);
			this.tabs.Controls.Add(this.tabGathering);
			this.tabs.Controls.Add(this.tabInfo);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(120, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(606, 476);
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
			this.tabs.TabButtonSize = new global::System.Drawing.Size(120, 40);
			this.tabs.TabIndex = 67;
			this.tabs.TabMenuBackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.tabs.TabMenuOrientation = 0;
			this.tabs.SelectedIndexChanged += new global::System.EventHandler(this.tabs_SelectedIndexChanged);
			this.tabGeneral.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabGeneral.Controls.Add(this.panelTabGeneral);
			this.tabGeneral.Location = new global::System.Drawing.Point(4, 44);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Size = new global::System.Drawing.Size(598, 428);
			this.tabGeneral.TabIndex = 4;
			this.tabGeneral.Text = "General";
			this.panelTabGeneral.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabGeneral.AutoScroll = true;
			this.panelTabGeneral.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabGeneral.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabGeneral.Controls.Add(this.grpGeneralPREVIEW);
			this.panelTabGeneral.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabGeneral.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabGeneral.Name = "panelTabGeneral";
			this.panelTabGeneral.Size = new global::System.Drawing.Size(598, 428);
			this.panelTabGeneral.TabIndex = 120;
			this.grpGeneralPREVIEW.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpGeneralPREVIEW.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralBattlegroundStrandOfTheAncients);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralBattlegroundEyeOfTheStorm);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralBattlegroundAlteracValley);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralBattlegroundArathiBasin);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralBattlegroundWarsongGulch);
			this.grpGeneralPREVIEW.Controls.Add(this.sepGeneral1);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralFlightMount);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralGroundMount);
			this.grpGeneralPREVIEW.Controls.Add(this.checkGeneralFollowFleeingTarget);
			this.grpGeneralPREVIEW.Controls.Add(this.selectGeneralWaypointMode);
			this.grpGeneralPREVIEW.Controls.Add(this.selectGeneralCombatMode);
			this.grpGeneralPREVIEW.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpGeneralPREVIEW.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpGeneralPREVIEW.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpGeneralPREVIEW.ForeColor = global::System.Drawing.Color.White;
			this.grpGeneralPREVIEW.Location = new global::System.Drawing.Point(14, 14);
			this.grpGeneralPREVIEW.Name = "grpGeneralPREVIEW";
			this.grpGeneralPREVIEW.Size = new global::System.Drawing.Size(567, 234);
			this.grpGeneralPREVIEW.TabIndex = 68;
			this.grpGeneralPREVIEW.Text = "General";
			this.grpGeneralPREVIEW.Visible = false;
			this.checkGeneralBattlegroundEyeOfTheStorm.Animated = true;
			this.checkGeneralBattlegroundEyeOfTheStorm.AutoSize = true;
			this.checkGeneralBattlegroundEyeOfTheStorm.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralBattlegroundEyeOfTheStorm.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundEyeOfTheStorm.CheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundEyeOfTheStorm.CheckedState.BorderThickness = 0;
			this.checkGeneralBattlegroundEyeOfTheStorm.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundEyeOfTheStorm.Enabled = false;
			this.checkGeneralBattlegroundEyeOfTheStorm.Location = new global::System.Drawing.Point(186, 196);
			this.checkGeneralBattlegroundEyeOfTheStorm.Name = "checkGeneralBattlegroundEyeOfTheStorm";
			this.checkGeneralBattlegroundEyeOfTheStorm.Size = new global::System.Drawing.Size(137, 19);
			this.checkGeneralBattlegroundEyeOfTheStorm.TabIndex = 83;
			this.checkGeneralBattlegroundEyeOfTheStorm.Text = "Join Eye of the Storm";
			this.checkGeneralBattlegroundEyeOfTheStorm.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralBattlegroundEyeOfTheStorm.UncheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundEyeOfTheStorm.UncheckedState.BorderThickness = 1;
			this.checkGeneralBattlegroundEyeOfTheStorm.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralBattlegroundEyeOfTheStorm.UseVisualStyleBackColor = false;
			this.checkGeneralBattlegroundAlteracValley.Animated = true;
			this.checkGeneralBattlegroundAlteracValley.AutoSize = true;
			this.checkGeneralBattlegroundAlteracValley.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralBattlegroundAlteracValley.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundAlteracValley.CheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundAlteracValley.CheckedState.BorderThickness = 0;
			this.checkGeneralBattlegroundAlteracValley.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundAlteracValley.Enabled = false;
			this.checkGeneralBattlegroundAlteracValley.Location = new global::System.Drawing.Point(186, 171);
			this.checkGeneralBattlegroundAlteracValley.Name = "checkGeneralBattlegroundAlteracValley";
			this.checkGeneralBattlegroundAlteracValley.Size = new global::System.Drawing.Size(120, 19);
			this.checkGeneralBattlegroundAlteracValley.TabIndex = 82;
			this.checkGeneralBattlegroundAlteracValley.Text = "Join Alterac Valley";
			this.checkGeneralBattlegroundAlteracValley.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralBattlegroundAlteracValley.UncheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundAlteracValley.UncheckedState.BorderThickness = 1;
			this.checkGeneralBattlegroundAlteracValley.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralBattlegroundAlteracValley.UseVisualStyleBackColor = false;
			this.checkGeneralBattlegroundArathiBasin.Animated = true;
			this.checkGeneralBattlegroundArathiBasin.AutoSize = true;
			this.checkGeneralBattlegroundArathiBasin.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralBattlegroundArathiBasin.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundArathiBasin.CheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundArathiBasin.CheckedState.BorderThickness = 0;
			this.checkGeneralBattlegroundArathiBasin.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundArathiBasin.Enabled = false;
			this.checkGeneralBattlegroundArathiBasin.Location = new global::System.Drawing.Point(25, 196);
			this.checkGeneralBattlegroundArathiBasin.Name = "checkGeneralBattlegroundArathiBasin";
			this.checkGeneralBattlegroundArathiBasin.Size = new global::System.Drawing.Size(113, 19);
			this.checkGeneralBattlegroundArathiBasin.TabIndex = 81;
			this.checkGeneralBattlegroundArathiBasin.Text = "Join Arathi Basin";
			this.checkGeneralBattlegroundArathiBasin.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralBattlegroundArathiBasin.UncheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundArathiBasin.UncheckedState.BorderThickness = 1;
			this.checkGeneralBattlegroundArathiBasin.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralBattlegroundArathiBasin.UseVisualStyleBackColor = false;
			this.checkGeneralBattlegroundWarsongGulch.Animated = true;
			this.checkGeneralBattlegroundWarsongGulch.AutoSize = true;
			this.checkGeneralBattlegroundWarsongGulch.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralBattlegroundWarsongGulch.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundWarsongGulch.CheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundWarsongGulch.CheckedState.BorderThickness = 0;
			this.checkGeneralBattlegroundWarsongGulch.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundWarsongGulch.Enabled = false;
			this.checkGeneralBattlegroundWarsongGulch.Location = new global::System.Drawing.Point(25, 171);
			this.checkGeneralBattlegroundWarsongGulch.Name = "checkGeneralBattlegroundWarsongGulch";
			this.checkGeneralBattlegroundWarsongGulch.Size = new global::System.Drawing.Size(131, 19);
			this.checkGeneralBattlegroundWarsongGulch.TabIndex = 80;
			this.checkGeneralBattlegroundWarsongGulch.Text = "Join Warsong Gulch";
			this.checkGeneralBattlegroundWarsongGulch.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralBattlegroundWarsongGulch.UncheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundWarsongGulch.UncheckedState.BorderThickness = 1;
			this.checkGeneralBattlegroundWarsongGulch.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralBattlegroundWarsongGulch.UseVisualStyleBackColor = false;
			this.sepGeneral1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepGeneral1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepGeneral1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepGeneral1.Location = new global::System.Drawing.Point(16, 144);
			this.sepGeneral1.Name = "sepGeneral1";
			this.sepGeneral1.Size = new global::System.Drawing.Size(535, 10);
			this.sepGeneral1.TabIndex = 79;
			this.checkGeneralFlightMount.Animated = true;
			this.checkGeneralFlightMount.AutoSize = true;
			this.checkGeneralFlightMount.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralFlightMount.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralFlightMount.CheckedState.BorderRadius = 0;
			this.checkGeneralFlightMount.CheckedState.BorderThickness = 0;
			this.checkGeneralFlightMount.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralFlightMount.Location = new global::System.Drawing.Point(297, 111);
			this.checkGeneralFlightMount.Name = "checkGeneralFlightMount";
			this.checkGeneralFlightMount.Size = new global::System.Drawing.Size(169, 19);
			this.checkGeneralFlightMount.TabIndex = 78;
			this.checkGeneralFlightMount.Text = "Use Flight Mount if learned";
			this.checkGeneralFlightMount.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralFlightMount.UncheckedState.BorderRadius = 0;
			this.checkGeneralFlightMount.UncheckedState.BorderThickness = 1;
			this.checkGeneralFlightMount.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralFlightMount.UseVisualStyleBackColor = false;
			this.checkGeneralGroundMount.Animated = true;
			this.checkGeneralGroundMount.AutoSize = true;
			this.checkGeneralGroundMount.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralGroundMount.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralGroundMount.CheckedState.BorderRadius = 0;
			this.checkGeneralGroundMount.CheckedState.BorderThickness = 0;
			this.checkGeneralGroundMount.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralGroundMount.Location = new global::System.Drawing.Point(297, 87);
			this.checkGeneralGroundMount.Name = "checkGeneralGroundMount";
			this.checkGeneralGroundMount.Size = new global::System.Drawing.Size(179, 19);
			this.checkGeneralGroundMount.TabIndex = 77;
			this.checkGeneralGroundMount.Text = "Use Ground Mount if learned";
			this.checkGeneralGroundMount.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralGroundMount.UncheckedState.BorderRadius = 0;
			this.checkGeneralGroundMount.UncheckedState.BorderThickness = 1;
			this.checkGeneralGroundMount.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralGroundMount.UseVisualStyleBackColor = false;
			this.checkGeneralFollowFleeingTarget.Animated = true;
			this.checkGeneralFollowFleeingTarget.AutoSize = true;
			this.checkGeneralFollowFleeingTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralFollowFleeingTarget.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralFollowFleeingTarget.CheckedState.BorderRadius = 0;
			this.checkGeneralFollowFleeingTarget.CheckedState.BorderThickness = 0;
			this.checkGeneralFollowFleeingTarget.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralFollowFleeingTarget.Location = new global::System.Drawing.Point(297, 62);
			this.checkGeneralFollowFleeingTarget.Name = "checkGeneralFollowFleeingTarget";
			this.checkGeneralFollowFleeingTarget.Size = new global::System.Drawing.Size(140, 19);
			this.checkGeneralFollowFleeingTarget.TabIndex = 76;
			this.checkGeneralFollowFleeingTarget.Text = "Follow fleeing Targets";
			this.checkGeneralFollowFleeingTarget.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralFollowFleeingTarget.UncheckedState.BorderRadius = 0;
			this.checkGeneralFollowFleeingTarget.UncheckedState.BorderThickness = 1;
			this.checkGeneralFollowFleeingTarget.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralFollowFleeingTarget.UseVisualStyleBackColor = false;
			this.selectGeneralWaypointMode.BackColor = global::System.Drawing.Color.Transparent;
			this.selectGeneralWaypointMode.BorderColor = global::System.Drawing.Color.Gray;
			this.selectGeneralWaypointMode.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectGeneralWaypointMode.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectGeneralWaypointMode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectGeneralWaypointMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectGeneralWaypointMode.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectGeneralWaypointMode.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectGeneralWaypointMode.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectGeneralWaypointMode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectGeneralWaypointMode.ForeColor = global::System.Drawing.Color.White;
			this.selectGeneralWaypointMode.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectGeneralWaypointMode.ItemHeight = 24;
			this.selectGeneralWaypointMode.Items.AddRange(new object[]
			{
				"--- Waypoint Mode ---",
				"Best",
				"Closest",
				"Straight"
			});
			this.selectGeneralWaypointMode.Location = new global::System.Drawing.Point(25, 98);
			this.selectGeneralWaypointMode.Name = "selectGeneralWaypointMode";
			this.selectGeneralWaypointMode.Size = new global::System.Drawing.Size(236, 30);
			this.selectGeneralWaypointMode.StartIndex = 0;
			this.selectGeneralWaypointMode.TabIndex = 75;
			this.selectGeneralCombatMode.BackColor = global::System.Drawing.Color.Transparent;
			this.selectGeneralCombatMode.BorderColor = global::System.Drawing.Color.Gray;
			this.selectGeneralCombatMode.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectGeneralCombatMode.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectGeneralCombatMode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectGeneralCombatMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectGeneralCombatMode.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectGeneralCombatMode.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectGeneralCombatMode.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectGeneralCombatMode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectGeneralCombatMode.ForeColor = global::System.Drawing.Color.White;
			this.selectGeneralCombatMode.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectGeneralCombatMode.ItemHeight = 24;
			this.selectGeneralCombatMode.Items.AddRange(new object[]
			{
				"--- Combat Mode ---",
				"Offensive",
				"Defensive",
				"Gather",
				"Ignore",
				"PvP (Offensive)",
				"PvP (Defensive)"
			});
			this.selectGeneralCombatMode.Location = new global::System.Drawing.Point(25, 62);
			this.selectGeneralCombatMode.Name = "selectGeneralCombatMode";
			this.selectGeneralCombatMode.Size = new global::System.Drawing.Size(236, 30);
			this.selectGeneralCombatMode.StartIndex = 0;
			this.selectGeneralCombatMode.TabIndex = 74;
			this.tabMailbox.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabMailbox.Controls.Add(this.panelTabMailbox);
			this.tabMailbox.Location = new global::System.Drawing.Point(4, 44);
			this.tabMailbox.Name = "tabMailbox";
			this.tabMailbox.Size = new global::System.Drawing.Size(598, 428);
			this.tabMailbox.TabIndex = 1;
			this.tabMailbox.Text = "Mailbox";
			this.panelTabMailbox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabMailbox.AutoScroll = true;
			this.panelTabMailbox.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabMailbox.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabMailbox.Controls.Add(this.lblMailboxStatus);
			this.panelTabMailbox.Controls.Add(this.grpMailboxPREVIEW);
			this.panelTabMailbox.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabMailbox.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabMailbox.Name = "panelTabMailbox";
			this.panelTabMailbox.Size = new global::System.Drawing.Size(598, 428);
			this.panelTabMailbox.TabIndex = 117;
			this.lblMailboxStatus.AutoSize = true;
			this.lblMailboxStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMailboxStatus.ForeColor = global::System.Drawing.Color.Gray;
			this.lblMailboxStatus.Location = new global::System.Drawing.Point(181, 237);
			this.lblMailboxStatus.Name = "lblMailboxStatus";
			this.lblMailboxStatus.Size = new global::System.Drawing.Size(191, 19);
			this.lblMailboxStatus.TabIndex = 117;
			this.lblMailboxStatus.Text = "No Mailbox Settings available.";
			this.lblMailboxStatus.Visible = false;
			this.grpMailboxPREVIEW.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpMailboxPREVIEW.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMailboxPREVIEW.Controls.Add(this.btnMailboxCopy);
			this.grpMailboxPREVIEW.Controls.Add(this.btnMailboxReceiverApply);
			this.grpMailboxPREVIEW.Controls.Add(this.lblMailboxTitle);
			this.grpMailboxPREVIEW.Controls.Add(this.btnMailboxSendlist);
			this.grpMailboxPREVIEW.Controls.Add(this.txtMailboxReceiver);
			this.grpMailboxPREVIEW.Controls.Add(this.checkMailboxSendPurples);
			this.grpMailboxPREVIEW.Controls.Add(this.checkMailboxSendGreys);
			this.grpMailboxPREVIEW.Controls.Add(this.checkMailboxSendBlues);
			this.grpMailboxPREVIEW.Controls.Add(this.checkMailboxSendGreens);
			this.grpMailboxPREVIEW.Controls.Add(this.checkMailboxSendWhites);
			this.grpMailboxPREVIEW.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMailboxPREVIEW.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpMailboxPREVIEW.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpMailboxPREVIEW.ForeColor = global::System.Drawing.Color.White;
			this.grpMailboxPREVIEW.Location = new global::System.Drawing.Point(14, 14);
			this.grpMailboxPREVIEW.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpMailboxPREVIEW.Name = "grpMailboxPREVIEW";
			this.grpMailboxPREVIEW.Size = new global::System.Drawing.Size(567, 199);
			this.grpMailboxPREVIEW.TabIndex = 115;
			this.grpMailboxPREVIEW.Visible = false;
			this.btnMailboxCopy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMailboxCopy.BorderColor = global::System.Drawing.Color.Gray;
			this.btnMailboxCopy.BorderThickness = 1;
			this.btnMailboxCopy.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnMailboxCopy.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnMailboxCopy.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMailboxCopy.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMailboxCopy.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnMailboxCopy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMailboxCopy.ForeColor = global::System.Drawing.Color.White;
			this.btnMailboxCopy.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnMailboxCopy.Image = global::Jack.Properties.Resources.copy_16;
			this.btnMailboxCopy.ImageSize = new global::System.Drawing.Size(16, 16);
			this.btnMailboxCopy.Location = new global::System.Drawing.Point(532, 5);
			this.btnMailboxCopy.Name = "btnMailboxCopy";
			this.btnMailboxCopy.Size = new global::System.Drawing.Size(30, 30);
			this.btnMailboxCopy.TabIndex = 96;
			this.btnMailboxReceiverApply.BorderColor = global::System.Drawing.Color.Gray;
			this.btnMailboxReceiverApply.BorderThickness = 1;
			this.btnMailboxReceiverApply.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnMailboxReceiverApply.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnMailboxReceiverApply.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMailboxReceiverApply.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMailboxReceiverApply.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnMailboxReceiverApply.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMailboxReceiverApply.ForeColor = global::System.Drawing.Color.White;
			this.btnMailboxReceiverApply.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnMailboxReceiverApply.Location = new global::System.Drawing.Point(317, 62);
			this.btnMailboxReceiverApply.Name = "btnMailboxReceiverApply";
			this.btnMailboxReceiverApply.Size = new global::System.Drawing.Size(114, 30);
			this.btnMailboxReceiverApply.TabIndex = 95;
			this.btnMailboxReceiverApply.Text = "Apply";
			this.lblMailboxTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMailboxTitle.ForeColor = global::System.Drawing.Color.White;
			this.lblMailboxTitle.Location = new global::System.Drawing.Point(11, 12);
			this.lblMailboxTitle.Name = "lblMailboxTitle";
			this.lblMailboxTitle.Size = new global::System.Drawing.Size(39, 15);
			this.lblMailboxTitle.TabIndex = 94;
			this.lblMailboxTitle.Text = "Mailbox";
			this.btnMailboxSendlist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnMailboxSendlist.BorderThickness = 1;
			this.btnMailboxSendlist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnMailboxSendlist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnMailboxSendlist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMailboxSendlist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMailboxSendlist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnMailboxSendlist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMailboxSendlist.ForeColor = global::System.Drawing.Color.White;
			this.btnMailboxSendlist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnMailboxSendlist.Location = new global::System.Drawing.Point(317, 111);
			this.btnMailboxSendlist.Name = "btnMailboxSendlist";
			this.btnMailboxSendlist.Size = new global::System.Drawing.Size(114, 31);
			this.btnMailboxSendlist.TabIndex = 93;
			this.btnMailboxSendlist.Text = "Sendlist";
			this.txtMailboxReceiver.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMailboxReceiver.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMailboxReceiver.DefaultText = "";
			this.txtMailboxReceiver.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMailboxReceiver.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtMailboxReceiver.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMailboxReceiver.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMailboxReceiver.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtMailboxReceiver.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtMailboxReceiver.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMailboxReceiver.ForeColor = global::System.Drawing.Color.White;
			this.txtMailboxReceiver.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtMailboxReceiver.Location = new global::System.Drawing.Point(25, 62);
			this.txtMailboxReceiver.MaxLength = 200;
			this.txtMailboxReceiver.Name = "txtMailboxReceiver";
			this.txtMailboxReceiver.PasswordChar = '\0';
			this.txtMailboxReceiver.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtMailboxReceiver.PlaceholderText = "Receiver";
			this.txtMailboxReceiver.SelectedText = "";
			this.txtMailboxReceiver.Size = new global::System.Drawing.Size(286, 30);
			this.txtMailboxReceiver.TabIndex = 92;
			this.checkMailboxSendPurples.Animated = true;
			this.checkMailboxSendPurples.AutoSize = true;
			this.checkMailboxSendPurples.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMailboxSendPurples.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendPurples.CheckedState.BorderRadius = 0;
			this.checkMailboxSendPurples.CheckedState.BorderThickness = 0;
			this.checkMailboxSendPurples.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendPurples.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkMailboxSendPurples.ForeColor = global::System.Drawing.Color.Fuchsia;
			this.checkMailboxSendPurples.Location = new global::System.Drawing.Point(180, 136);
			this.checkMailboxSendPurples.Name = "checkMailboxSendPurples";
			this.checkMailboxSendPurples.Size = new global::System.Drawing.Size(109, 19);
			this.checkMailboxSendPurples.TabIndex = 91;
			this.checkMailboxSendPurples.Text = "Send all Purples";
			this.checkMailboxSendPurples.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMailboxSendPurples.UncheckedState.BorderRadius = 0;
			this.checkMailboxSendPurples.UncheckedState.BorderThickness = 1;
			this.checkMailboxSendPurples.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMailboxSendPurples.UseVisualStyleBackColor = false;
			this.checkMailboxSendGreys.Animated = true;
			this.checkMailboxSendGreys.AutoSize = true;
			this.checkMailboxSendGreys.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMailboxSendGreys.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendGreys.CheckedState.BorderRadius = 0;
			this.checkMailboxSendGreys.CheckedState.BorderThickness = 0;
			this.checkMailboxSendGreys.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendGreys.ForeColor = global::System.Drawing.Color.DarkGray;
			this.checkMailboxSendGreys.Location = new global::System.Drawing.Point(25, 111);
			this.checkMailboxSendGreys.Name = "checkMailboxSendGreys";
			this.checkMailboxSendGreys.Size = new global::System.Drawing.Size(99, 19);
			this.checkMailboxSendGreys.TabIndex = 90;
			this.checkMailboxSendGreys.Text = "Send all Grays";
			this.checkMailboxSendGreys.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMailboxSendGreys.UncheckedState.BorderRadius = 0;
			this.checkMailboxSendGreys.UncheckedState.BorderThickness = 1;
			this.checkMailboxSendGreys.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMailboxSendGreys.UseVisualStyleBackColor = false;
			this.checkMailboxSendBlues.Animated = true;
			this.checkMailboxSendBlues.AutoSize = true;
			this.checkMailboxSendBlues.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMailboxSendBlues.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendBlues.CheckedState.BorderRadius = 0;
			this.checkMailboxSendBlues.CheckedState.BorderThickness = 0;
			this.checkMailboxSendBlues.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendBlues.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.checkMailboxSendBlues.Location = new global::System.Drawing.Point(180, 111);
			this.checkMailboxSendBlues.Name = "checkMailboxSendBlues";
			this.checkMailboxSendBlues.Size = new global::System.Drawing.Size(98, 19);
			this.checkMailboxSendBlues.TabIndex = 89;
			this.checkMailboxSendBlues.Text = "Send all Blues";
			this.checkMailboxSendBlues.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMailboxSendBlues.UncheckedState.BorderRadius = 0;
			this.checkMailboxSendBlues.UncheckedState.BorderThickness = 1;
			this.checkMailboxSendBlues.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMailboxSendBlues.UseVisualStyleBackColor = false;
			this.checkMailboxSendGreens.Animated = true;
			this.checkMailboxSendGreens.AutoSize = true;
			this.checkMailboxSendGreens.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMailboxSendGreens.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendGreens.CheckedState.BorderRadius = 0;
			this.checkMailboxSendGreens.CheckedState.BorderThickness = 0;
			this.checkMailboxSendGreens.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendGreens.ForeColor = global::System.Drawing.Color.Lime;
			this.checkMailboxSendGreens.Location = new global::System.Drawing.Point(25, 161);
			this.checkMailboxSendGreens.Name = "checkMailboxSendGreens";
			this.checkMailboxSendGreens.Size = new global::System.Drawing.Size(106, 19);
			this.checkMailboxSendGreens.TabIndex = 88;
			this.checkMailboxSendGreens.Text = "Send all Greens";
			this.checkMailboxSendGreens.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMailboxSendGreens.UncheckedState.BorderRadius = 0;
			this.checkMailboxSendGreens.UncheckedState.BorderThickness = 1;
			this.checkMailboxSendGreens.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMailboxSendGreens.UseVisualStyleBackColor = false;
			this.checkMailboxSendWhites.Animated = true;
			this.checkMailboxSendWhites.AutoSize = true;
			this.checkMailboxSendWhites.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMailboxSendWhites.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendWhites.CheckedState.BorderRadius = 0;
			this.checkMailboxSendWhites.CheckedState.BorderThickness = 0;
			this.checkMailboxSendWhites.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMailboxSendWhites.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkMailboxSendWhites.Location = new global::System.Drawing.Point(25, 136);
			this.checkMailboxSendWhites.Name = "checkMailboxSendWhites";
			this.checkMailboxSendWhites.Size = new global::System.Drawing.Size(106, 19);
			this.checkMailboxSendWhites.TabIndex = 87;
			this.checkMailboxSendWhites.Text = "Send all Whites";
			this.checkMailboxSendWhites.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMailboxSendWhites.UncheckedState.BorderRadius = 0;
			this.checkMailboxSendWhites.UncheckedState.BorderThickness = 1;
			this.checkMailboxSendWhites.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMailboxSendWhites.UseVisualStyleBackColor = false;
			this.tabVendor.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabVendor.Controls.Add(this.panelTabVendor);
			this.tabVendor.Location = new global::System.Drawing.Point(4, 44);
			this.tabVendor.Name = "tabVendor";
			this.tabVendor.Size = new global::System.Drawing.Size(598, 428);
			this.tabVendor.TabIndex = 2;
			this.tabVendor.Text = "Vendor";
			this.panelTabVendor.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabVendor.AutoScroll = true;
			this.panelTabVendor.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabVendor.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabVendor.Controls.Add(this.lblVendorStatus);
			this.panelTabVendor.Controls.Add(this.grpVendorPREVIEW);
			this.panelTabVendor.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabVendor.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabVendor.Name = "panelTabVendor";
			this.panelTabVendor.Size = new global::System.Drawing.Size(598, 428);
			this.panelTabVendor.TabIndex = 118;
			this.lblVendorStatus.AutoSize = true;
			this.lblVendorStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblVendorStatus.ForeColor = global::System.Drawing.Color.Gray;
			this.lblVendorStatus.Location = new global::System.Drawing.Point(181, 204);
			this.lblVendorStatus.Name = "lblVendorStatus";
			this.lblVendorStatus.Size = new global::System.Drawing.Size(187, 19);
			this.lblVendorStatus.TabIndex = 116;
			this.lblVendorStatus.Text = "No Vendor Settings available.";
			this.lblVendorStatus.Visible = false;
			this.grpVendorPREVIEW.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpVendorPREVIEW.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpVendorPREVIEW.Controls.Add(this.btnVendorCopy);
			this.grpVendorPREVIEW.Controls.Add(this.btnVendorBuylist);
			this.grpVendorPREVIEW.Controls.Add(this.btnVendorWhitelist);
			this.grpVendorPREVIEW.Controls.Add(this.checkVendorCanRepair);
			this.grpVendorPREVIEW.Controls.Add(this.checkVendorSellGreys);
			this.grpVendorPREVIEW.Controls.Add(this.checkVendorSellBlues);
			this.grpVendorPREVIEW.Controls.Add(this.checkVendorSellGreens);
			this.grpVendorPREVIEW.Controls.Add(this.checkVendorSellWhites);
			this.grpVendorPREVIEW.Controls.Add(this.lblVendorTitle);
			this.grpVendorPREVIEW.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpVendorPREVIEW.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpVendorPREVIEW.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpVendorPREVIEW.ForeColor = global::System.Drawing.Color.White;
			this.grpVendorPREVIEW.Location = new global::System.Drawing.Point(14, 14);
			this.grpVendorPREVIEW.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpVendorPREVIEW.Name = "grpVendorPREVIEW";
			this.grpVendorPREVIEW.Size = new global::System.Drawing.Size(567, 171);
			this.grpVendorPREVIEW.TabIndex = 115;
			this.grpVendorPREVIEW.Visible = false;
			this.btnVendorCopy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnVendorCopy.BorderColor = global::System.Drawing.Color.Gray;
			this.btnVendorCopy.BorderThickness = 1;
			this.btnVendorCopy.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnVendorCopy.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnVendorCopy.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnVendorCopy.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnVendorCopy.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnVendorCopy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnVendorCopy.ForeColor = global::System.Drawing.Color.White;
			this.btnVendorCopy.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnVendorCopy.Image = global::Jack.Properties.Resources.copy_16;
			this.btnVendorCopy.ImageSize = new global::System.Drawing.Size(16, 16);
			this.btnVendorCopy.Location = new global::System.Drawing.Point(532, 5);
			this.btnVendorCopy.Name = "btnVendorCopy";
			this.btnVendorCopy.Size = new global::System.Drawing.Size(30, 30);
			this.btnVendorCopy.TabIndex = 98;
			this.btnVendorBuylist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnVendorBuylist.BorderThickness = 1;
			this.btnVendorBuylist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnVendorBuylist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnVendorBuylist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnVendorBuylist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnVendorBuylist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnVendorBuylist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnVendorBuylist.ForeColor = global::System.Drawing.Color.White;
			this.btnVendorBuylist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnVendorBuylist.Location = new global::System.Drawing.Point(317, 98);
			this.btnVendorBuylist.Name = "btnVendorBuylist";
			this.btnVendorBuylist.Size = new global::System.Drawing.Size(114, 31);
			this.btnVendorBuylist.TabIndex = 97;
			this.btnVendorBuylist.Text = "Buylist";
			this.btnVendorWhitelist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnVendorWhitelist.BorderThickness = 1;
			this.btnVendorWhitelist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnVendorWhitelist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnVendorWhitelist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnVendorWhitelist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnVendorWhitelist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnVendorWhitelist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnVendorWhitelist.ForeColor = global::System.Drawing.Color.White;
			this.btnVendorWhitelist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnVendorWhitelist.Location = new global::System.Drawing.Point(317, 60);
			this.btnVendorWhitelist.Name = "btnVendorWhitelist";
			this.btnVendorWhitelist.Size = new global::System.Drawing.Size(114, 31);
			this.btnVendorWhitelist.TabIndex = 96;
			this.btnVendorWhitelist.Text = "Whitelist";
			this.checkVendorCanRepair.Animated = true;
			this.checkVendorCanRepair.AutoSize = true;
			this.checkVendorCanRepair.BackColor = global::System.Drawing.Color.Transparent;
			this.checkVendorCanRepair.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorCanRepair.CheckedState.BorderRadius = 0;
			this.checkVendorCanRepair.CheckedState.BorderThickness = 0;
			this.checkVendorCanRepair.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorCanRepair.Enabled = false;
			this.checkVendorCanRepair.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkVendorCanRepair.Location = new global::System.Drawing.Point(180, 60);
			this.checkVendorCanRepair.Name = "checkVendorCanRepair";
			this.checkVendorCanRepair.Size = new global::System.Drawing.Size(83, 19);
			this.checkVendorCanRepair.TabIndex = 95;
			this.checkVendorCanRepair.Text = "Can Repair";
			this.checkVendorCanRepair.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkVendorCanRepair.UncheckedState.BorderRadius = 0;
			this.checkVendorCanRepair.UncheckedState.BorderThickness = 1;
			this.checkVendorCanRepair.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkVendorCanRepair.UseVisualStyleBackColor = false;
			this.checkVendorSellGreys.Animated = true;
			this.checkVendorSellGreys.AutoSize = true;
			this.checkVendorSellGreys.BackColor = global::System.Drawing.Color.Transparent;
			this.checkVendorSellGreys.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellGreys.CheckedState.BorderRadius = 0;
			this.checkVendorSellGreys.CheckedState.BorderThickness = 0;
			this.checkVendorSellGreys.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellGreys.ForeColor = global::System.Drawing.Color.DarkGray;
			this.checkVendorSellGreys.Location = new global::System.Drawing.Point(25, 60);
			this.checkVendorSellGreys.Name = "checkVendorSellGreys";
			this.checkVendorSellGreys.Size = new global::System.Drawing.Size(91, 19);
			this.checkVendorSellGreys.TabIndex = 94;
			this.checkVendorSellGreys.Text = "Sell all Grays";
			this.checkVendorSellGreys.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkVendorSellGreys.UncheckedState.BorderRadius = 0;
			this.checkVendorSellGreys.UncheckedState.BorderThickness = 1;
			this.checkVendorSellGreys.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkVendorSellGreys.UseVisualStyleBackColor = false;
			this.checkVendorSellBlues.Animated = true;
			this.checkVendorSellBlues.AutoSize = true;
			this.checkVendorSellBlues.BackColor = global::System.Drawing.Color.Transparent;
			this.checkVendorSellBlues.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellBlues.CheckedState.BorderRadius = 0;
			this.checkVendorSellBlues.CheckedState.BorderThickness = 0;
			this.checkVendorSellBlues.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellBlues.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.checkVendorSellBlues.Location = new global::System.Drawing.Point(25, 135);
			this.checkVendorSellBlues.Name = "checkVendorSellBlues";
			this.checkVendorSellBlues.Size = new global::System.Drawing.Size(90, 19);
			this.checkVendorSellBlues.TabIndex = 93;
			this.checkVendorSellBlues.Text = "Sell all Blues";
			this.checkVendorSellBlues.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkVendorSellBlues.UncheckedState.BorderRadius = 0;
			this.checkVendorSellBlues.UncheckedState.BorderThickness = 1;
			this.checkVendorSellBlues.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkVendorSellBlues.UseVisualStyleBackColor = false;
			this.checkVendorSellGreens.Animated = true;
			this.checkVendorSellGreens.AutoSize = true;
			this.checkVendorSellGreens.BackColor = global::System.Drawing.Color.Transparent;
			this.checkVendorSellGreens.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellGreens.CheckedState.BorderRadius = 0;
			this.checkVendorSellGreens.CheckedState.BorderThickness = 0;
			this.checkVendorSellGreens.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellGreens.ForeColor = global::System.Drawing.Color.Lime;
			this.checkVendorSellGreens.Location = new global::System.Drawing.Point(25, 110);
			this.checkVendorSellGreens.Name = "checkVendorSellGreens";
			this.checkVendorSellGreens.Size = new global::System.Drawing.Size(98, 19);
			this.checkVendorSellGreens.TabIndex = 92;
			this.checkVendorSellGreens.Text = "Sell all Greens";
			this.checkVendorSellGreens.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkVendorSellGreens.UncheckedState.BorderRadius = 0;
			this.checkVendorSellGreens.UncheckedState.BorderThickness = 1;
			this.checkVendorSellGreens.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkVendorSellGreens.UseVisualStyleBackColor = false;
			this.checkVendorSellWhites.Animated = true;
			this.checkVendorSellWhites.AutoSize = true;
			this.checkVendorSellWhites.BackColor = global::System.Drawing.Color.Transparent;
			this.checkVendorSellWhites.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellWhites.CheckedState.BorderRadius = 0;
			this.checkVendorSellWhites.CheckedState.BorderThickness = 0;
			this.checkVendorSellWhites.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkVendorSellWhites.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkVendorSellWhites.Location = new global::System.Drawing.Point(25, 85);
			this.checkVendorSellWhites.Name = "checkVendorSellWhites";
			this.checkVendorSellWhites.Size = new global::System.Drawing.Size(98, 19);
			this.checkVendorSellWhites.TabIndex = 91;
			this.checkVendorSellWhites.Text = "Sell all Whites";
			this.checkVendorSellWhites.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkVendorSellWhites.UncheckedState.BorderRadius = 0;
			this.checkVendorSellWhites.UncheckedState.BorderThickness = 1;
			this.checkVendorSellWhites.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkVendorSellWhites.UseVisualStyleBackColor = false;
			this.lblVendorTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblVendorTitle.ForeColor = global::System.Drawing.Color.White;
			this.lblVendorTitle.Location = new global::System.Drawing.Point(11, 12);
			this.lblVendorTitle.Name = "lblVendorTitle";
			this.lblVendorTitle.Size = new global::System.Drawing.Size(37, 15);
			this.lblVendorTitle.TabIndex = 90;
			this.lblVendorTitle.Text = "Vendor";
			this.tabGathering.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabGathering.Controls.Add(this.panelTabGathering);
			this.tabGathering.Location = new global::System.Drawing.Point(4, 44);
			this.tabGathering.Name = "tabGathering";
			this.tabGathering.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabGathering.Size = new global::System.Drawing.Size(598, 428);
			this.tabGathering.TabIndex = 3;
			this.tabGathering.Text = "Gathering";
			this.panelTabGathering.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabGathering.AutoScroll = true;
			this.panelTabGathering.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabGathering.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabGathering.Controls.Add(this.lblGatherStatus);
			this.panelTabGathering.Controls.Add(this.grpSettingsLootPREVIEW);
			this.panelTabGathering.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabGathering.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabGathering.Name = "panelTabGathering";
			this.panelTabGathering.Size = new global::System.Drawing.Size(598, 428);
			this.panelTabGathering.TabIndex = 119;
			this.lblGatherStatus.AutoSize = true;
			this.lblGatherStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGatherStatus.ForeColor = global::System.Drawing.Color.Gray;
			this.lblGatherStatus.Location = new global::System.Drawing.Point(181, 204);
			this.lblGatherStatus.Name = "lblGatherStatus";
			this.lblGatherStatus.Size = new global::System.Drawing.Size(185, 19);
			this.lblGatherStatus.TabIndex = 117;
			this.lblGatherStatus.Text = "No Gather Settings available.";
			this.lblGatherStatus.Visible = false;
			this.grpSettingsLootPREVIEW.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsLootPREVIEW.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsLootPREVIEW.Controls.Add(this.btnGatheringCopy);
			this.grpSettingsLootPREVIEW.Controls.Add(this.imgModuleGather);
			this.grpSettingsLootPREVIEW.Controls.Add(this.checkGatherSkinning);
			this.grpSettingsLootPREVIEW.Controls.Add(this.checkGatherHerbalism);
			this.grpSettingsLootPREVIEW.Controls.Add(this.checkGatherMining);
			this.grpSettingsLootPREVIEW.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsLootPREVIEW.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsLootPREVIEW.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsLootPREVIEW.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsLootPREVIEW.Location = new global::System.Drawing.Point(14, 14);
			this.grpSettingsLootPREVIEW.Name = "grpSettingsLootPREVIEW";
			this.grpSettingsLootPREVIEW.Size = new global::System.Drawing.Size(567, 146);
			this.grpSettingsLootPREVIEW.TabIndex = 67;
			this.grpSettingsLootPREVIEW.Text = "Gathering";
			this.grpSettingsLootPREVIEW.Visible = false;
			this.btnGatheringCopy.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGatheringCopy.BorderColor = global::System.Drawing.Color.Gray;
			this.btnGatheringCopy.BorderThickness = 1;
			this.btnGatheringCopy.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnGatheringCopy.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnGatheringCopy.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnGatheringCopy.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnGatheringCopy.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnGatheringCopy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnGatheringCopy.ForeColor = global::System.Drawing.Color.White;
			this.btnGatheringCopy.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnGatheringCopy.Image = global::Jack.Properties.Resources.copy_16;
			this.btnGatheringCopy.ImageSize = new global::System.Drawing.Size(16, 16);
			this.btnGatheringCopy.Location = new global::System.Drawing.Point(532, 5);
			this.btnGatheringCopy.Name = "btnGatheringCopy";
			this.btnGatheringCopy.Size = new global::System.Drawing.Size(30, 30);
			this.btnGatheringCopy.TabIndex = 99;
			this.imgModuleGather.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleGather.Image = global::Jack.Properties.Resources.module_gathering;
			this.imgModuleGather.ImageRotate = 0f;
			this.imgModuleGather.Location = new global::System.Drawing.Point(388, 7);
			this.imgModuleGather.Name = "imgModuleGather";
			this.imgModuleGather.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleGather.TabIndex = 90;
			this.imgModuleGather.TabStop = false;
			this.checkGatherSkinning.Animated = true;
			this.checkGatherSkinning.AutoSize = true;
			this.checkGatherSkinning.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGatherSkinning.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGatherSkinning.CheckedState.BorderRadius = 0;
			this.checkGatherSkinning.CheckedState.BorderThickness = 0;
			this.checkGatherSkinning.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGatherSkinning.ForeColor = global::System.Drawing.Color.White;
			this.checkGatherSkinning.Location = new global::System.Drawing.Point(25, 110);
			this.checkGatherSkinning.Name = "checkGatherSkinning";
			this.checkGatherSkinning.Size = new global::System.Drawing.Size(72, 19);
			this.checkGatherSkinning.TabIndex = 76;
			this.checkGatherSkinning.Text = "Skinning";
			this.checkGatherSkinning.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGatherSkinning.UncheckedState.BorderRadius = 0;
			this.checkGatherSkinning.UncheckedState.BorderThickness = 1;
			this.checkGatherSkinning.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGatherSkinning.UseVisualStyleBackColor = false;
			this.checkGatherHerbalism.Animated = true;
			this.checkGatherHerbalism.AutoSize = true;
			this.checkGatherHerbalism.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGatherHerbalism.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGatherHerbalism.CheckedState.BorderRadius = 0;
			this.checkGatherHerbalism.CheckedState.BorderThickness = 0;
			this.checkGatherHerbalism.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGatherHerbalism.ForeColor = global::System.Drawing.Color.White;
			this.checkGatherHerbalism.Location = new global::System.Drawing.Point(25, 85);
			this.checkGatherHerbalism.Name = "checkGatherHerbalism";
			this.checkGatherHerbalism.Size = new global::System.Drawing.Size(80, 19);
			this.checkGatherHerbalism.TabIndex = 74;
			this.checkGatherHerbalism.Text = "Herbalism";
			this.checkGatherHerbalism.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGatherHerbalism.UncheckedState.BorderRadius = 0;
			this.checkGatherHerbalism.UncheckedState.BorderThickness = 1;
			this.checkGatherHerbalism.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGatherHerbalism.UseVisualStyleBackColor = false;
			this.checkGatherMining.Animated = true;
			this.checkGatherMining.AutoSize = true;
			this.checkGatherMining.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGatherMining.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGatherMining.CheckedState.BorderRadius = 0;
			this.checkGatherMining.CheckedState.BorderThickness = 0;
			this.checkGatherMining.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGatherMining.ForeColor = global::System.Drawing.Color.White;
			this.checkGatherMining.Location = new global::System.Drawing.Point(25, 60);
			this.checkGatherMining.Name = "checkGatherMining";
			this.checkGatherMining.Size = new global::System.Drawing.Size(64, 19);
			this.checkGatherMining.TabIndex = 72;
			this.checkGatherMining.Text = "Mining";
			this.checkGatherMining.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGatherMining.UncheckedState.BorderRadius = 0;
			this.checkGatherMining.UncheckedState.BorderThickness = 1;
			this.checkGatherMining.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGatherMining.UseVisualStyleBackColor = false;
			this.tabInfo.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabInfo.Controls.Add(this.panelTabInfo);
			this.tabInfo.ForeColor = global::System.Drawing.Color.White;
			this.tabInfo.Location = new global::System.Drawing.Point(4, 44);
			this.tabInfo.Name = "tabInfo";
			this.tabInfo.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabInfo.Size = new global::System.Drawing.Size(598, 428);
			this.tabInfo.TabIndex = 0;
			this.tabInfo.Text = "Info";
			this.panelTabInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabInfo.AutoScroll = true;
			this.panelTabInfo.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabInfo.Controls.Add(this.grpInfoRequirements);
			this.panelTabInfo.Controls.Add(this.grpInfoContact);
			this.panelTabInfo.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabInfo.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabInfo.Name = "panelTabInfo";
			this.panelTabInfo.Size = new global::System.Drawing.Size(598, 428);
			this.panelTabInfo.TabIndex = 118;
			this.grpInfoRequirements.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInfoRequirements.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoRequirements.Controls.Add(this.lblInfoRequirementsSkillData);
			this.grpInfoRequirements.Controls.Add(this.lblInfoRequirementsSkill);
			this.grpInfoRequirements.Controls.Add(this.lblInfoRequirementsLevelData);
			this.grpInfoRequirements.Controls.Add(this.lblInfoRequirementsLevel);
			this.grpInfoRequirements.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoRequirements.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInfoRequirements.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInfoRequirements.ForeColor = global::System.Drawing.Color.White;
			this.grpInfoRequirements.Location = new global::System.Drawing.Point(14, 14);
			this.grpInfoRequirements.Name = "grpInfoRequirements";
			this.grpInfoRequirements.Size = new global::System.Drawing.Size(567, 126);
			this.grpInfoRequirements.TabIndex = 116;
			this.grpInfoRequirements.Text = "Requirements";
			this.lblInfoRequirementsSkillData.AutoSize = true;
			this.lblInfoRequirementsSkillData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoRequirementsSkillData.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblInfoRequirementsSkillData.Location = new global::System.Drawing.Point(180, 88);
			this.lblInfoRequirementsSkillData.Name = "lblInfoRequirementsSkillData";
			this.lblInfoRequirementsSkillData.Size = new global::System.Drawing.Size(77, 15);
			this.lblInfoRequirementsSkillData.TabIndex = 99;
			this.lblInfoRequirementsSkillData.Text = "Not required.";
			this.lblInfoRequirementsSkill.AutoSize = true;
			this.lblInfoRequirementsSkill.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoRequirementsSkill.Location = new global::System.Drawing.Point(22, 88);
			this.lblInfoRequirementsSkill.Name = "lblInfoRequirementsSkill";
			this.lblInfoRequirementsSkill.Size = new global::System.Drawing.Size(61, 15);
			this.lblInfoRequirementsSkill.TabIndex = 98;
			this.lblInfoRequirementsSkill.Text = "Skill Level:";
			this.lblInfoRequirementsLevelData.AutoSize = true;
			this.lblInfoRequirementsLevelData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoRequirementsLevelData.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblInfoRequirementsLevelData.Location = new global::System.Drawing.Point(180, 64);
			this.lblInfoRequirementsLevelData.Name = "lblInfoRequirementsLevelData";
			this.lblInfoRequirementsLevelData.Size = new global::System.Drawing.Size(77, 15);
			this.lblInfoRequirementsLevelData.TabIndex = 97;
			this.lblInfoRequirementsLevelData.Text = "Not required.";
			this.lblInfoRequirementsLevel.AutoSize = true;
			this.lblInfoRequirementsLevel.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoRequirementsLevel.Location = new global::System.Drawing.Point(22, 64);
			this.lblInfoRequirementsLevel.Name = "lblInfoRequirementsLevel";
			this.lblInfoRequirementsLevel.Size = new global::System.Drawing.Size(37, 15);
			this.lblInfoRequirementsLevel.TabIndex = 96;
			this.lblInfoRequirementsLevel.Text = "Level:";
			this.grpInfoContact.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInfoContact.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoContact.Controls.Add(this.lblInfoContactEmailData);
			this.grpInfoContact.Controls.Add(this.lblInfoContactEmail);
			this.grpInfoContact.Controls.Add(this.lblInfoContactDiscordUsernameData);
			this.grpInfoContact.Controls.Add(this.lblInfoContactDiscordUsername);
			this.grpInfoContact.Controls.Add(this.lblInfoContactStoreNameData);
			this.grpInfoContact.Controls.Add(this.lblInfoContactStoreName);
			this.grpInfoContact.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfoContact.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInfoContact.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInfoContact.ForeColor = global::System.Drawing.Color.White;
			this.grpInfoContact.Location = new global::System.Drawing.Point(14, 155);
			this.grpInfoContact.Name = "grpInfoContact";
			this.grpInfoContact.Size = new global::System.Drawing.Size(567, 153);
			this.grpInfoContact.TabIndex = 115;
			this.grpInfoContact.Text = "Contact";
			this.lblInfoContactEmailData.AutoSize = true;
			this.lblInfoContactEmailData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoContactEmailData.Location = new global::System.Drawing.Point(180, 112);
			this.lblInfoContactEmailData.Name = "lblInfoContactEmailData";
			this.lblInfoContactEmailData.Size = new global::System.Drawing.Size(49, 15);
			this.lblInfoContactEmailData.TabIndex = 101;
			this.lblInfoContactEmailData.Text = "[EMAIL]";
			this.lblInfoContactEmail.AutoSize = true;
			this.lblInfoContactEmail.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoContactEmail.Location = new global::System.Drawing.Point(22, 112);
			this.lblInfoContactEmail.Name = "lblInfoContactEmail";
			this.lblInfoContactEmail.Size = new global::System.Drawing.Size(44, 15);
			this.lblInfoContactEmail.TabIndex = 100;
			this.lblInfoContactEmail.Text = "E-Mail:";
			this.lblInfoContactDiscordUsernameData.AutoSize = true;
			this.lblInfoContactDiscordUsernameData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoContactDiscordUsernameData.Location = new global::System.Drawing.Point(180, 88);
			this.lblInfoContactDiscordUsernameData.Name = "lblInfoContactDiscordUsernameData";
			this.lblInfoContactDiscordUsernameData.Size = new global::System.Drawing.Size(130, 15);
			this.lblInfoContactDiscordUsernameData.TabIndex = 99;
			this.lblInfoContactDiscordUsernameData.Text = "[DISCORD_USERNAME]";
			this.lblInfoContactDiscordUsername.AutoSize = true;
			this.lblInfoContactDiscordUsername.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoContactDiscordUsername.Location = new global::System.Drawing.Point(22, 88);
			this.lblInfoContactDiscordUsername.Name = "lblInfoContactDiscordUsername";
			this.lblInfoContactDiscordUsername.Size = new global::System.Drawing.Size(106, 15);
			this.lblInfoContactDiscordUsername.TabIndex = 98;
			this.lblInfoContactDiscordUsername.Text = "Discord Username:";
			this.lblInfoContactStoreNameData.AutoSize = true;
			this.lblInfoContactStoreNameData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoContactStoreNameData.Location = new global::System.Drawing.Point(180, 64);
			this.lblInfoContactStoreNameData.Name = "lblInfoContactStoreNameData";
			this.lblInfoContactStoreNameData.Size = new global::System.Drawing.Size(87, 15);
			this.lblInfoContactStoreNameData.TabIndex = 97;
			this.lblInfoContactStoreNameData.Text = "[STORE_NAME]";
			this.lblInfoContactStoreName.AutoSize = true;
			this.lblInfoContactStoreName.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoContactStoreName.Location = new global::System.Drawing.Point(22, 64);
			this.lblInfoContactStoreName.Name = "lblInfoContactStoreName";
			this.lblInfoContactStoreName.Size = new global::System.Drawing.Size(72, 15);
			this.lblInfoContactStoreName.TabIndex = 96;
			this.lblInfoContactStoreName.Text = "Store Name:";
			this.panelTitle2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle2.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle2.Controls.Add(this.imgTitleEdge2);
			this.panelTitle2.Controls.Add(this.lblTitle2);
			this.panelTitle2.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle2.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle2.Name = "panelTitle2";
			this.panelTitle2.Size = new global::System.Drawing.Size(398, 38);
			this.panelTitle2.TabIndex = 66;
			this.imgTitleEdge2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge2.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge2.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge2.ImageRotate = 0f;
			this.imgTitleEdge2.Location = new global::System.Drawing.Point(328, 0);
			this.imgTitleEdge2.Name = "imgTitleEdge2";
			this.imgTitleEdge2.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge2.TabIndex = 66;
			this.imgTitleEdge2.TabStop = false;
			this.lblTitle2.AutoSize = true;
			this.lblTitle2.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle2.ForeColor = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.lblTitle2.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Size = new global::System.Drawing.Size(193, 15);
			this.lblTitle2.TabIndex = 65;
			this.lblTitle2.Text = "Profile Settings";
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnClose);
			this.panelBtnSave.Location = new global::System.Drawing.Point(376, 616);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 73;
			this.btnClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.BackColor = global::System.Drawing.Color.Transparent;
			this.btnClose.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnClose.DisabledState.Image = global::Jack.Properties.Resources.btn_close_disabled;
			this.btnClose.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClose.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnClose.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnClose.ForeColor = global::System.Drawing.Color.White;
			this.btnClose.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnClose.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClose.HoverState.Image = global::Jack.Properties.Resources.btn_close_hover;
			this.btnClose.Image = global::Jack.Properties.Resources.btn_close;
			this.btnClose.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnClose.Location = new global::System.Drawing.Point(30, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.PressedDepth = 0;
			this.btnClose.Size = new global::System.Drawing.Size(235, 44);
			this.btnClose.TabIndex = 0;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.checkGeneralBattlegroundStrandOfTheAncients.Animated = true;
			this.checkGeneralBattlegroundStrandOfTheAncients.AutoSize = true;
			this.checkGeneralBattlegroundStrandOfTheAncients.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGeneralBattlegroundStrandOfTheAncients.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundStrandOfTheAncients.CheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundStrandOfTheAncients.CheckedState.BorderThickness = 0;
			this.checkGeneralBattlegroundStrandOfTheAncients.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGeneralBattlegroundStrandOfTheAncients.Enabled = false;
			this.checkGeneralBattlegroundStrandOfTheAncients.Location = new global::System.Drawing.Point(350, 171);
			this.checkGeneralBattlegroundStrandOfTheAncients.Name = "checkGeneralBattlegroundStrandOfTheAncients";
			this.checkGeneralBattlegroundStrandOfTheAncients.Size = new global::System.Drawing.Size(167, 19);
			this.checkGeneralBattlegroundStrandOfTheAncients.TabIndex = 84;
			this.checkGeneralBattlegroundStrandOfTheAncients.Text = "Join Strand of the Ancients";
			this.checkGeneralBattlegroundStrandOfTheAncients.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkGeneralBattlegroundStrandOfTheAncients.UncheckedState.BorderRadius = 0;
			this.checkGeneralBattlegroundStrandOfTheAncients.UncheckedState.BorderThickness = 1;
			this.checkGeneralBattlegroundStrandOfTheAncients.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkGeneralBattlegroundStrandOfTheAncients.UseVisualStyleBackColor = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(680, 700);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new global::System.Drawing.Size(680, 700);
			base.Name = "frmMainProfilesPremium";
			this.Text = "frmMainProfilesPremium";
			base.Load += new global::System.EventHandler(this.frmMainProfilesPremium_Load);
			base.Shown += new global::System.EventHandler(this.frmMainProfilesPremium_Shown);
			base.Resize += new global::System.EventHandler(this.frmMainProfilesPremium_Resize);
			this.panelBox2.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.panelTabGeneral.ResumeLayout(false);
			this.grpGeneralPREVIEW.ResumeLayout(false);
			this.grpGeneralPREVIEW.PerformLayout();
			this.tabMailbox.ResumeLayout(false);
			this.panelTabMailbox.ResumeLayout(false);
			this.panelTabMailbox.PerformLayout();
			this.grpMailboxPREVIEW.ResumeLayout(false);
			this.grpMailboxPREVIEW.PerformLayout();
			this.tabVendor.ResumeLayout(false);
			this.panelTabVendor.ResumeLayout(false);
			this.panelTabVendor.PerformLayout();
			this.grpVendorPREVIEW.ResumeLayout(false);
			this.grpVendorPREVIEW.PerformLayout();
			this.tabGathering.ResumeLayout(false);
			this.panelTabGathering.ResumeLayout(false);
			this.panelTabGathering.PerformLayout();
			this.grpSettingsLootPREVIEW.ResumeLayout(false);
			this.grpSettingsLootPREVIEW.PerformLayout();
			this.imgModuleGather.EndInit();
			this.tabInfo.ResumeLayout(false);
			this.panelTabInfo.ResumeLayout(false);
			this.grpInfoRequirements.ResumeLayout(false);
			this.grpInfoRequirements.PerformLayout();
			this.grpInfoContact.ResumeLayout(false);
			this.grpInfoContact.PerformLayout();
			this.panelTitle2.ResumeLayout(false);
			this.panelTitle2.PerformLayout();
			this.imgTitleEdge2.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000329 RID: 809
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400032A RID: 810
		private global::Guna.UI2.WinForms.Guna2Panel panelBox2;

		// Token: 0x0400032B RID: 811
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x0400032C RID: 812
		private global::System.Windows.Forms.TabPage tabInfo;

		// Token: 0x0400032D RID: 813
		private global::System.Windows.Forms.TabPage tabMailbox;

		// Token: 0x0400032E RID: 814
		private global::Guna.UI2.WinForms.Guna2Panel panelTabMailbox;

		// Token: 0x0400032F RID: 815
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle2;

		// Token: 0x04000330 RID: 816
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge2;

		// Token: 0x04000331 RID: 817
		private global::System.Windows.Forms.Label lblTitle2;

		// Token: 0x04000332 RID: 818
		private global::Guna.UI2.WinForms.Guna2Panel panelTabInfo;

		// Token: 0x04000333 RID: 819
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x04000334 RID: 820
		private global::Guna.UI2.WinForms.Guna2Button btnClose;

		// Token: 0x04000335 RID: 821
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInfoContact;

		// Token: 0x04000336 RID: 822
		private global::System.Windows.Forms.Label lblInfoContactEmailData;

		// Token: 0x04000337 RID: 823
		private global::System.Windows.Forms.Label lblInfoContactEmail;

		// Token: 0x04000338 RID: 824
		private global::System.Windows.Forms.Label lblInfoContactDiscordUsernameData;

		// Token: 0x04000339 RID: 825
		private global::System.Windows.Forms.Label lblInfoContactDiscordUsername;

		// Token: 0x0400033A RID: 826
		private global::System.Windows.Forms.Label lblInfoContactStoreNameData;

		// Token: 0x0400033B RID: 827
		private global::System.Windows.Forms.Label lblInfoContactStoreName;

		// Token: 0x0400033C RID: 828
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInfoRequirements;

		// Token: 0x0400033D RID: 829
		private global::System.Windows.Forms.Label lblInfoRequirementsSkillData;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.Forms.Label lblInfoRequirementsSkill;

		// Token: 0x0400033F RID: 831
		private global::System.Windows.Forms.Label lblInfoRequirementsLevelData;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Label lblInfoRequirementsLevel;

		// Token: 0x04000341 RID: 833
		private global::System.Windows.Forms.TabPage tabVendor;

		// Token: 0x04000342 RID: 834
		private global::Guna.UI2.WinForms.Guna2Panel panelTabVendor;

		// Token: 0x04000343 RID: 835
		private global::Guna.UI2.WinForms.Guna2GroupBox grpVendorPREVIEW;

		// Token: 0x04000344 RID: 836
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblVendorTitle;

		// Token: 0x04000345 RID: 837
		private global::Guna.UI2.WinForms.Guna2Button btnVendorBuylist;

		// Token: 0x04000346 RID: 838
		private global::Guna.UI2.WinForms.Guna2Button btnVendorWhitelist;

		// Token: 0x04000347 RID: 839
		private global::Guna.UI2.WinForms.Guna2CheckBox checkVendorCanRepair;

		// Token: 0x04000348 RID: 840
		private global::Guna.UI2.WinForms.Guna2CheckBox checkVendorSellGreys;

		// Token: 0x04000349 RID: 841
		private global::Guna.UI2.WinForms.Guna2CheckBox checkVendorSellBlues;

		// Token: 0x0400034A RID: 842
		private global::Guna.UI2.WinForms.Guna2CheckBox checkVendorSellGreens;

		// Token: 0x0400034B RID: 843
		private global::Guna.UI2.WinForms.Guna2CheckBox checkVendorSellWhites;

		// Token: 0x0400034C RID: 844
		private global::Guna.UI2.WinForms.Guna2GroupBox grpMailboxPREVIEW;

		// Token: 0x0400034D RID: 845
		private global::Guna.UI2.WinForms.Guna2Button btnMailboxSendlist;

		// Token: 0x0400034E RID: 846
		private global::Guna.UI2.WinForms.Guna2TextBox txtMailboxReceiver;

		// Token: 0x0400034F RID: 847
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMailboxSendPurples;

		// Token: 0x04000350 RID: 848
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMailboxSendGreys;

		// Token: 0x04000351 RID: 849
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMailboxSendBlues;

		// Token: 0x04000352 RID: 850
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMailboxSendGreens;

		// Token: 0x04000353 RID: 851
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMailboxSendWhites;

		// Token: 0x04000354 RID: 852
		private global::System.Windows.Forms.Label lblVendorStatus;

		// Token: 0x04000355 RID: 853
		private global::System.Windows.Forms.Label lblMailboxStatus;

		// Token: 0x04000356 RID: 854
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblMailboxTitle;

		// Token: 0x04000357 RID: 855
		private global::Guna.UI2.WinForms.Guna2Button btnMailboxReceiverApply;

		// Token: 0x04000358 RID: 856
		private global::Guna.UI2.WinForms.Guna2Button btnTooltip;

		// Token: 0x04000359 RID: 857
		private global::System.Windows.Forms.TabPage tabGathering;

		// Token: 0x0400035A RID: 858
		private global::Guna.UI2.WinForms.Guna2Panel panelTabGathering;

		// Token: 0x0400035B RID: 859
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsLootPREVIEW;

		// Token: 0x0400035C RID: 860
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleGather;

		// Token: 0x0400035D RID: 861
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGatherSkinning;

		// Token: 0x0400035E RID: 862
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGatherHerbalism;

		// Token: 0x0400035F RID: 863
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGatherMining;

		// Token: 0x04000360 RID: 864
		private global::System.Windows.Forms.Label lblGatherStatus;

		// Token: 0x04000361 RID: 865
		private global::System.Windows.Forms.TabPage tabGeneral;

		// Token: 0x04000362 RID: 866
		private global::Guna.UI2.WinForms.Guna2GroupBox grpGeneralPREVIEW;

		// Token: 0x04000363 RID: 867
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralFollowFleeingTarget;

		// Token: 0x04000364 RID: 868
		private global::Guna.UI2.WinForms.Guna2ComboBox selectGeneralWaypointMode;

		// Token: 0x04000365 RID: 869
		private global::Guna.UI2.WinForms.Guna2ComboBox selectGeneralCombatMode;

		// Token: 0x04000366 RID: 870
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralFlightMount;

		// Token: 0x04000367 RID: 871
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralGroundMount;

		// Token: 0x04000368 RID: 872
		private global::Guna.UI2.WinForms.Guna2Panel panelTabGeneral;

		// Token: 0x04000369 RID: 873
		private global::Guna.UI2.WinForms.Guna2Separator sepGeneral1;

		// Token: 0x0400036A RID: 874
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralBattlegroundEyeOfTheStorm;

		// Token: 0x0400036B RID: 875
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralBattlegroundAlteracValley;

		// Token: 0x0400036C RID: 876
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralBattlegroundArathiBasin;

		// Token: 0x0400036D RID: 877
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralBattlegroundWarsongGulch;

		// Token: 0x0400036E RID: 878
		private global::Guna.UI2.WinForms.Guna2Button btnMailboxCopy;

		// Token: 0x0400036F RID: 879
		private global::Guna.UI2.WinForms.Guna2Button btnVendorCopy;

		// Token: 0x04000370 RID: 880
		private global::Guna.UI2.WinForms.Guna2Button btnGatheringCopy;

		// Token: 0x04000371 RID: 881
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGeneralBattlegroundStrandOfTheAncients;
	}
}
