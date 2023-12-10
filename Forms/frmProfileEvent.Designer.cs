namespace Jack.Forms
{
	// Token: 0x02000088 RID: 136
	public partial class frmProfileEvent : global::System.Windows.Forms.Form
	{
		// Token: 0x06000DC5 RID: 3525 RVA: 0x006B133C File Offset: 0x006AF53C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x006B1368 File Offset: 0x006AF568
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmProfileEvent));
			this.panelBox2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabAction = new global::System.Windows.Forms.TabPage();
			this.panelTabAction = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpSettings = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectSettingsRace = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblSettingsRace = new global::System.Windows.Forms.Label();
			this.btnSettingsTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkSettingsExecuteAlways = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblSettingsExecute = new global::System.Windows.Forms.Label();
			this.checkSettingsExecuteOnce = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectSettingsFaction = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblSettingsFaction = new global::System.Windows.Forms.Label();
			this.grpAction = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnActionTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectAction = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblActionEvent = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.grpConditionAndOr1 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectConditionAndOr1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.grpCondition1 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtCondition1Value2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtCondition1Value = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.selectCondition1Compare = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectCondition1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.checkCondition1 = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpCondition2 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtCondition2Value2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnConditionTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtCondition2Value = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.selectCondition2Compare = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectCondition2 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.checkCondition2 = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabInteractWith = new global::System.Windows.Forms.TabPage();
			this.panelTabInteractWith = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpInteract = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnInteractWithTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkInteractFurthest = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.txtInteractNameOrID = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkInteractAttack = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkInteractClosest = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblInteractNameOrID = new global::System.Windows.Forms.Label();
			this.tabWait = new global::System.Windows.Forms.TabPage();
			this.panelTabWait = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpWaitFor = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkWaitForGate = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.txtWaitForMaxSeconds = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtWaitForNameOrID = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblWaitForMaxSeconds = new global::System.Windows.Forms.Label();
			this.lblWaitFor = new global::System.Windows.Forms.Label();
			this.checkWaitFor = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpWait = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkWait = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.txtWaitSeconds = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkWaitIgnoreAttackers = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblWaitSeconds = new global::System.Windows.Forms.Label();
			this.tabLoadProfile = new global::System.Windows.Forms.TabPage();
			this.panelTabLoadProfile = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpLoadProfile = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectLoadProfile = new global::System.Windows.Forms.ComboBox();
			this.lblLoadProfile = new global::System.Windows.Forms.Label();
			this.tabLoadRotation = new global::System.Windows.Forms.TabPage();
			this.panelTabLoadRotation = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpLoadRotation = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectLoadRotation = new global::System.Windows.Forms.ComboBox();
			this.lblLoadRotation = new global::System.Windows.Forms.Label();
			this.tabRecorder = new global::System.Windows.Forms.TabPage();
			this.panelTabRecorder = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpRecorderMailbox = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnRecorderMailboxTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRecorderMailboxSendlist = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtRecorderMailboxReceiver = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkRecorderMailboxSendPurples = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderMailboxSendGreys = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderMailboxSendBlues = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderMailboxSendGreens = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderMailboxSendWhites = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.sepRecorderMailbox1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblRecorderMailboxReceiver = new global::System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.grpRecorderType = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.panelRecorderInfo = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblRecorderShow = new global::System.Windows.Forms.Label();
			this.lblRecorderInfo = new global::System.Windows.Forms.Label();
			this.lblRecorder = new global::System.Windows.Forms.Label();
			this.lblRecorderLandingField = new global::System.Windows.Forms.Label();
			this.lblRecorderLandingFieldLocation = new global::System.Windows.Forms.Label();
			this.guna2Separator5 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.btnRecorderSetLandingField = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRecorderTypeTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnWaypointDelete = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnWaypointAddAfter = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRecorderSingle = new global::Guna.UI2.WinForms.Guna2Button();
			this.sepRecorder1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.btnRecordStart = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectRecorderCombatMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblRecorderCombatMode = new global::System.Windows.Forms.Label();
			this.selectRecorderRouteType = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblRecorderType = new global::System.Windows.Forms.Label();
			this.listWaypoints = new global::System.Windows.Forms.ListView();
			this.listWaypointsCount = new global::System.Windows.Forms.ColumnHeader();
			this.listWaypointsWaypoint = new global::System.Windows.Forms.ColumnHeader();
			this.grpRecorderFlightMaster = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnRecorderFlightMasterTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectRecorderFlightMasterProfiles = new global::System.Windows.Forms.ComboBox();
			this.selectRecorderFlightMasterFlightPoints = new global::System.Windows.Forms.ComboBox();
			this.lblRecorderFlightMasterProfiles = new global::System.Windows.Forms.Label();
			this.lblRecorderFlightMasterFlightPoints = new global::System.Windows.Forms.Label();
			this.grpRecorderVendor = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblRecorderVendorMountKeybind = new global::System.Windows.Forms.Label();
			this.checkRecorderVendorMount = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.btnRecorderVendorTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRecorderVendorBuylist = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRecorderVendorWhitelist = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkRecorderVendorCanRepair = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderVendorSellGreys = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderVendorSellBlues = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderVendorSellGreens = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRecorderVendorSellWhites = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabCastSpell = new global::System.Windows.Forms.TabPage();
			this.panelTabCastSpell = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpCastSpellTarget = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkCastSpellTarget = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkCastSpellTargetFurthest = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.txtCastSpellTargetNameOrID = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkCastSpellTargetClosest = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblCastSpellTargetNameOrID = new global::System.Windows.Forms.Label();
			this.grpCastSpell = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnCastSpellTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectCastSpell = new global::System.Windows.Forms.ComboBox();
			this.checkCastSpellGroundAOE = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkCastSpellUntilNoAttackers = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkCastSpellWhileWalk = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.guna2Separator2 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblCastSpellRadiusInfo = new global::System.Windows.Forms.Label();
			this.checkCastSpellNoRadiusCheck = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.txtCastSpellRadius = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblCastSpellRadius = new global::System.Windows.Forms.Label();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.btnCastSpellReload = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblCastSpell = new global::System.Windows.Forms.Label();
			this.tabWalkSens = new global::System.Windows.Forms.TabPage();
			this.panelTabWalkSens = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpWalkSens = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnWalkSensDefault = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblWalkSensInfo3 = new global::System.Windows.Forms.Label();
			this.lblWalkSensInfo2 = new global::System.Windows.Forms.Label();
			this.lblWalkSensIndoorData = new global::System.Windows.Forms.Label();
			this.trackWalkSensIndoor = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.lblWalkSensIndoor = new global::System.Windows.Forms.Label();
			this.lblWalkSensOutdoorData = new global::System.Windows.Forms.Label();
			this.trackWalkSensOutdoor = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.sepWalkSens2 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblWalkSensOutdoor = new global::System.Windows.Forms.Label();
			this.sepWalkSens1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblWalkSensInfo1 = new global::System.Windows.Forms.Label();
			this.tabUseHearthstone = new global::System.Windows.Forms.TabPage();
			this.panelTabUseHearthstone = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpUseHearthstone = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectUseHearthstoneLoadProfile = new global::System.Windows.Forms.ComboBox();
			this.lblUseHearthstoneLoadProfile = new global::System.Windows.Forms.Label();
			this.tabFishing = new global::System.Windows.Forms.TabPage();
			this.panelTabFishing = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpFishingOptions = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkFishingOptionsRandomDelay = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpFishingFacing = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnFishingFacingTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnFishingFacingDirection = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblFishingFacingDirection = new global::System.Windows.Forms.Label();
			this.checkFishingFacing = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpFishing = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblFishingKeybind = new global::System.Windows.Forms.Label();
			this.grpFishingCondition = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkFishingConditionFullBags = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.guna2Separator4 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.btnFishingConditionItemlist = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblcheckFishingConditionItemlist = new global::System.Windows.Forms.Label();
			this.checkFishingConditionItemlist = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.guna2Separator3 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.txtFishingConditionSkillLevel = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkFishingConditionSkillLevel = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkFishingCondition = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpFishingBait = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblFishingBaitKeybind = new global::System.Windows.Forms.Label();
			this.checkFishingBait = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabUseTransport = new global::System.Windows.Forms.TabPage();
			this.panelTabUseTransport = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpUseTransportTurn = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectUseTransportTurn = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblUseTransportTurn = new global::System.Windows.Forms.Label();
			this.grpUseTransportLoadProfile = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnUseTransportTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectUseTransportLoadProfile = new global::System.Windows.Forms.ComboBox();
			this.lblUseTransportLoadProfile = new global::System.Windows.Forms.Label();
			this.tabExecuteLUA = new global::System.Windows.Forms.TabPage();
			this.panelTabExecuteLUA = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpExecuteLUA = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkExecuteLUAWhileWalk = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.btnExecuteLUATest = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectExecuteLUAExamples = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.txtExecuteLUA = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnExecuteLUATooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabBattlegroundClassic = new global::System.Windows.Forms.TabPage();
			this.panelTabBattleground = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpBattlegroundClassic = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectBattlegroundClassicStrandOfTheAncients = new global::System.Windows.Forms.ComboBox();
			this.checkBattlegroundClassicStrandOfTheAncients = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.btnTooltipBattlegroundClassic = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkBattlegroundClassicWaitUntilInvitation = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectBattlegroundClassicEyeOfTheStorm = new global::System.Windows.Forms.ComboBox();
			this.selectBattlegroundClassicAlteracValley = new global::System.Windows.Forms.ComboBox();
			this.selectBattlegroundClassicArathiBasin = new global::System.Windows.Forms.ComboBox();
			this.selectBattlegroundClassicWarsongGulch = new global::System.Windows.Forms.ComboBox();
			this.checkBattlegroundClassicEyeOfTheStorm = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkBattlegroundClassicAlteracValley = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkBattlegroundClassicArathiBasin = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkBattlegroundClassicWarsongGulch = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabChangeProfileSettings = new global::System.Windows.Forms.TabPage();
			this.panelTabChangeProfileSettings = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpMobs = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.panelMobs = new global::Guna.UI2.WinForms.Guna2Panel();
			this.richSettingsMobs = new global::System.Windows.Forms.RichTextBox();
			this.lblMobs = new global::System.Windows.Forms.Label();
			this.grpSettingsMode = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkSettingsModeMesh = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsModeFollowFleeingTarget = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectSettingsWaypointMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectSettingsCombatMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblSettingsCombatMode = new global::System.Windows.Forms.Label();
			this.lblSettingsWaypointsMode = new global::System.Windows.Forms.Label();
			this.grpSettingsDistances = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblSettingsDistancesIsReachableZAxis = new global::System.Windows.Forms.Label();
			this.lblSettingsDistancesIsReachable = new global::System.Windows.Forms.Label();
			this.txtSettingsDistancesIsReachable = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblSettingsDistancesMobGroupDetection = new global::System.Windows.Forms.Label();
			this.lblSettingsDistancesInfo = new global::System.Windows.Forms.Label();
			this.lblSettingsDistancesMobGroup = new global::System.Windows.Forms.Label();
			this.txtSettingsDistancesMobGroup = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblSettingsDistancesLocation = new global::System.Windows.Forms.Label();
			this.txtSettingsDistancesLocation = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblSettingsDistancesWaypoint = new global::System.Windows.Forms.Label();
			this.txtSettingsDistancesWaypoint = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.sepSettingsDistances1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.grpSettingsMount = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblSettingsFlightMount = new global::System.Windows.Forms.Label();
			this.checkSettingsFlightMount = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblSettingsGroundMount = new global::System.Windows.Forms.Label();
			this.checkSettingsGroundMount = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpSettingsLoot = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblSettingsLootAvoidElitesDistanceInfo = new global::System.Windows.Forms.Label();
			this.lblSettingsLootAvoidElitesDistance = new global::System.Windows.Forms.Label();
			this.txtSettingsLootAvoidElitesDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkSettingsLootGatherMobs = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.txtSettingsLootQuestItems = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.imgModuleGather = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblSettingsLootGatherDistance = new global::System.Windows.Forms.Label();
			this.txtSettingsLootGatherDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblSettingsLootMaxPathDistance = new global::System.Windows.Forms.Label();
			this.txtSettingsLootMaxPathDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblSettingsLootDistance = new global::System.Windows.Forms.Label();
			this.txtSettingsLootDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.sepOverlayESPObjects2 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.checkSettingsLootSkinning = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsLoot = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsLootHerbalism = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsLootMining = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.panelTitle2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle2 = new global::System.Windows.Forms.Label();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpSelectionCurrent = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblCurrentTargetLocation = new global::System.Windows.Forms.Label();
			this.lblCurrentTarget = new global::System.Windows.Forms.Label();
			this.grpSelectionAroundMe = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSelectionAroundMeTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnAroundMeReload = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectAroundMeItems = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.btnAroundMeItemSelect = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectAroundMeObjects = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.btnAroundMeObjectSelect = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectAroundMeNPCs = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.btnAroundMeNPCSelect = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpSelectionMouseover = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSelectionMouseoverTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkMouseoverLock = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.btnMouseoverSelect = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblMouseoverNameData = new global::System.Windows.Forms.Label();
			this.grpSelectionTarget = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSelectionTargetTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnTargetSelect = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblTargetNameData = new global::System.Windows.Forms.Label();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBox2.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabAction.SuspendLayout();
			this.panelTabAction.SuspendLayout();
			this.grpSettings.SuspendLayout();
			this.grpAction.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.grpConditionAndOr1.SuspendLayout();
			this.grpCondition1.SuspendLayout();
			this.grpCondition2.SuspendLayout();
			this.tabInteractWith.SuspendLayout();
			this.panelTabInteractWith.SuspendLayout();
			this.grpInteract.SuspendLayout();
			this.tabWait.SuspendLayout();
			this.panelTabWait.SuspendLayout();
			this.grpWaitFor.SuspendLayout();
			this.grpWait.SuspendLayout();
			this.tabLoadProfile.SuspendLayout();
			this.panelTabLoadProfile.SuspendLayout();
			this.grpLoadProfile.SuspendLayout();
			this.tabLoadRotation.SuspendLayout();
			this.panelTabLoadRotation.SuspendLayout();
			this.grpLoadRotation.SuspendLayout();
			this.tabRecorder.SuspendLayout();
			this.panelTabRecorder.SuspendLayout();
			this.grpRecorderMailbox.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.grpRecorderType.SuspendLayout();
			this.panelRecorderInfo.SuspendLayout();
			this.grpRecorderFlightMaster.SuspendLayout();
			this.grpRecorderVendor.SuspendLayout();
			this.tabCastSpell.SuspendLayout();
			this.panelTabCastSpell.SuspendLayout();
			this.grpCastSpellTarget.SuspendLayout();
			this.grpCastSpell.SuspendLayout();
			this.tabWalkSens.SuspendLayout();
			this.panelTabWalkSens.SuspendLayout();
			this.grpWalkSens.SuspendLayout();
			this.tabUseHearthstone.SuspendLayout();
			this.panelTabUseHearthstone.SuspendLayout();
			this.grpUseHearthstone.SuspendLayout();
			this.tabFishing.SuspendLayout();
			this.panelTabFishing.SuspendLayout();
			this.grpFishingOptions.SuspendLayout();
			this.grpFishingFacing.SuspendLayout();
			this.grpFishing.SuspendLayout();
			this.grpFishingCondition.SuspendLayout();
			this.grpFishingBait.SuspendLayout();
			this.tabUseTransport.SuspendLayout();
			this.panelTabUseTransport.SuspendLayout();
			this.grpUseTransportTurn.SuspendLayout();
			this.grpUseTransportLoadProfile.SuspendLayout();
			this.tabExecuteLUA.SuspendLayout();
			this.panelTabExecuteLUA.SuspendLayout();
			this.grpExecuteLUA.SuspendLayout();
			this.tabBattlegroundClassic.SuspendLayout();
			this.panelTabBattleground.SuspendLayout();
			this.grpBattlegroundClassic.SuspendLayout();
			this.tabChangeProfileSettings.SuspendLayout();
			this.panelTabChangeProfileSettings.SuspendLayout();
			this.grpMobs.SuspendLayout();
			this.panelMobs.SuspendLayout();
			this.grpSettingsMode.SuspendLayout();
			this.grpSettingsDistances.SuspendLayout();
			this.grpSettingsMount.SuspendLayout();
			this.grpSettingsLoot.SuspendLayout();
			this.imgModuleGather.BeginInit();
			this.panelTitle2.SuspendLayout();
			this.imgTitleEdge2.BeginInit();
			this.panelBox1.SuspendLayout();
			this.grpSelectionCurrent.SuspendLayout();
			this.grpSelectionAroundMe.SuspendLayout();
			this.grpSelectionMouseover.SuspendLayout();
			this.grpSelectionTarget.SuspendLayout();
			this.panelTitle1.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.panelBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox2.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox2.Controls.Add(this.btnTooltip);
			this.panelBox2.Controls.Add(this.tabs);
			this.panelBox2.Controls.Add(this.panelTitle2);
			this.panelBox2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox2.Location = new global::System.Drawing.Point(353, 74);
			this.panelBox2.Name = "panelBox2";
			this.panelBox2.Size = new global::System.Drawing.Size(797, 628);
			this.panelBox2.TabIndex = 68;
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
			this.btnTooltip.Location = new global::System.Drawing.Point(742, 13);
			this.btnTooltip.Name = "btnTooltip";
			this.btnTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnTooltip.TabIndex = 73;
			this.btnTooltip.Click += new global::System.EventHandler(this.btnTooltip_Click);
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabAction);
			this.tabs.Controls.Add(this.tabInteractWith);
			this.tabs.Controls.Add(this.tabWait);
			this.tabs.Controls.Add(this.tabLoadProfile);
			this.tabs.Controls.Add(this.tabLoadRotation);
			this.tabs.Controls.Add(this.tabRecorder);
			this.tabs.Controls.Add(this.tabCastSpell);
			this.tabs.Controls.Add(this.tabWalkSens);
			this.tabs.Controls.Add(this.tabUseHearthstone);
			this.tabs.Controls.Add(this.tabFishing);
			this.tabs.Controls.Add(this.tabUseTransport);
			this.tabs.Controls.Add(this.tabExecuteLUA);
			this.tabs.Controls.Add(this.tabBattlegroundClassic);
			this.tabs.Controls.Add(this.tabChangeProfileSettings);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(140, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(771, 560);
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
			this.tabs.TabButtonSize = new global::System.Drawing.Size(140, 40);
			this.tabs.TabIndex = 67;
			this.tabs.TabMenuBackColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.tabs.TabMenuOrientation = 0;
			this.tabs.SelectedIndexChanged += new global::System.EventHandler(this.tabs_SelectedIndexChanged);
			this.tabAction.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabAction.Controls.Add(this.panelTabAction);
			this.tabAction.ForeColor = global::System.Drawing.Color.White;
			this.tabAction.Location = new global::System.Drawing.Point(4, 124);
			this.tabAction.Name = "tabAction";
			this.tabAction.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabAction.Size = new global::System.Drawing.Size(763, 432);
			this.tabAction.TabIndex = 0;
			this.tabAction.Text = "Action";
			this.panelTabAction.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabAction.AutoScroll = true;
			this.panelTabAction.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabAction.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabAction.Controls.Add(this.grpSettings);
			this.panelTabAction.Controls.Add(this.grpAction);
			this.panelTabAction.Controls.Add(this.tableLayoutPanel1);
			this.panelTabAction.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabAction.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabAction.Name = "panelTabAction";
			this.panelTabAction.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabAction.TabIndex = 67;
			this.grpSettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettings.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettings.Controls.Add(this.selectSettingsRace);
			this.grpSettings.Controls.Add(this.lblSettingsRace);
			this.grpSettings.Controls.Add(this.btnSettingsTooltip);
			this.grpSettings.Controls.Add(this.checkSettingsExecuteAlways);
			this.grpSettings.Controls.Add(this.lblSettingsExecute);
			this.grpSettings.Controls.Add(this.checkSettingsExecuteOnce);
			this.grpSettings.Controls.Add(this.selectSettingsFaction);
			this.grpSettings.Controls.Add(this.lblSettingsFaction);
			this.grpSettings.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettings.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettings.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettings.ForeColor = global::System.Drawing.Color.White;
			this.grpSettings.Location = new global::System.Drawing.Point(14, 342);
			this.grpSettings.Name = "grpSettings";
			this.grpSettings.Size = new global::System.Drawing.Size(649, 185);
			this.grpSettings.TabIndex = 66;
			this.grpSettings.Text = "Settings";
			this.selectSettingsRace.BackColor = global::System.Drawing.Color.Transparent;
			this.selectSettingsRace.BorderColor = global::System.Drawing.Color.Gray;
			this.selectSettingsRace.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectSettingsRace.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectSettingsRace.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectSettingsRace.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectSettingsRace.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectSettingsRace.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsRace.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsRace.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectSettingsRace.ForeColor = global::System.Drawing.Color.White;
			this.selectSettingsRace.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectSettingsRace.ItemHeight = 24;
			this.selectSettingsRace.Location = new global::System.Drawing.Point(180, 134);
			this.selectSettingsRace.Name = "selectSettingsRace";
			this.selectSettingsRace.Size = new global::System.Drawing.Size(200, 30);
			this.selectSettingsRace.TabIndex = 76;
			this.lblSettingsRace.AutoSize = true;
			this.lblSettingsRace.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsRace.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsRace.Location = new global::System.Drawing.Point(22, 141);
			this.lblSettingsRace.Name = "lblSettingsRace";
			this.lblSettingsRace.Size = new global::System.Drawing.Size(35, 15);
			this.lblSettingsRace.TabIndex = 75;
			this.lblSettingsRace.Text = "Race:";
			this.btnSettingsTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSettingsTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSettingsTooltip.BorderRadius = 4;
			this.btnSettingsTooltip.BorderThickness = 1;
			this.btnSettingsTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSettingsTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSettingsTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSettingsTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSettingsTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSettingsTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSettingsTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSettingsTooltip.Location = new global::System.Drawing.Point(602, 8);
			this.btnSettingsTooltip.Name = "btnSettingsTooltip";
			this.btnSettingsTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSettingsTooltip.TabIndex = 74;
			this.btnSettingsTooltip.Click += new global::System.EventHandler(this.btnSettingsTooltip_Click);
			this.checkSettingsExecuteAlways.Animated = true;
			this.checkSettingsExecuteAlways.AutoSize = true;
			this.checkSettingsExecuteAlways.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsExecuteAlways.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsExecuteAlways.CheckedState.BorderRadius = 0;
			this.checkSettingsExecuteAlways.CheckedState.BorderThickness = 0;
			this.checkSettingsExecuteAlways.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsExecuteAlways.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkSettingsExecuteAlways.Location = new global::System.Drawing.Point(249, 61);
			this.checkSettingsExecuteAlways.Name = "checkSettingsExecuteAlways";
			this.checkSettingsExecuteAlways.Size = new global::System.Drawing.Size(63, 19);
			this.checkSettingsExecuteAlways.TabIndex = 73;
			this.checkSettingsExecuteAlways.Text = "Always";
			this.checkSettingsExecuteAlways.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsExecuteAlways.UncheckedState.BorderRadius = 0;
			this.checkSettingsExecuteAlways.UncheckedState.BorderThickness = 1;
			this.checkSettingsExecuteAlways.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsExecuteAlways.UseVisualStyleBackColor = false;
			this.checkSettingsExecuteAlways.CheckedChanged += new global::System.EventHandler(this.checkSettingsExecutionAlways_CheckedChanged);
			this.lblSettingsExecute.AutoSize = true;
			this.lblSettingsExecute.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsExecute.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsExecute.Location = new global::System.Drawing.Point(22, 62);
			this.lblSettingsExecute.Name = "lblSettingsExecute";
			this.lblSettingsExecute.Size = new global::System.Drawing.Size(62, 15);
			this.lblSettingsExecute.TabIndex = 72;
			this.lblSettingsExecute.Text = "Execution:";
			this.checkSettingsExecuteOnce.Animated = true;
			this.checkSettingsExecuteOnce.AutoSize = true;
			this.checkSettingsExecuteOnce.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsExecuteOnce.Checked = true;
			this.checkSettingsExecuteOnce.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsExecuteOnce.CheckedState.BorderRadius = 0;
			this.checkSettingsExecuteOnce.CheckedState.BorderThickness = 0;
			this.checkSettingsExecuteOnce.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsExecuteOnce.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkSettingsExecuteOnce.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkSettingsExecuteOnce.Location = new global::System.Drawing.Point(180, 61);
			this.checkSettingsExecuteOnce.Name = "checkSettingsExecuteOnce";
			this.checkSettingsExecuteOnce.Size = new global::System.Drawing.Size(54, 19);
			this.checkSettingsExecuteOnce.TabIndex = 71;
			this.checkSettingsExecuteOnce.Text = "Once";
			this.checkSettingsExecuteOnce.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsExecuteOnce.UncheckedState.BorderRadius = 0;
			this.checkSettingsExecuteOnce.UncheckedState.BorderThickness = 1;
			this.checkSettingsExecuteOnce.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsExecuteOnce.UseVisualStyleBackColor = false;
			this.checkSettingsExecuteOnce.CheckedChanged += new global::System.EventHandler(this.checkSettingsExecutionOnce_CheckedChanged);
			this.selectSettingsFaction.BackColor = global::System.Drawing.Color.Transparent;
			this.selectSettingsFaction.BorderColor = global::System.Drawing.Color.Gray;
			this.selectSettingsFaction.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectSettingsFaction.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectSettingsFaction.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectSettingsFaction.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectSettingsFaction.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectSettingsFaction.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsFaction.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsFaction.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectSettingsFaction.ForeColor = global::System.Drawing.Color.White;
			this.selectSettingsFaction.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectSettingsFaction.ItemHeight = 24;
			this.selectSettingsFaction.Items.AddRange(new object[]
			{
				"Both",
				"Horde",
				"Alliance"
			});
			this.selectSettingsFaction.Location = new global::System.Drawing.Point(180, 91);
			this.selectSettingsFaction.Name = "selectSettingsFaction";
			this.selectSettingsFaction.Size = new global::System.Drawing.Size(200, 30);
			this.selectSettingsFaction.TabIndex = 70;
			this.lblSettingsFaction.AutoSize = true;
			this.lblSettingsFaction.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsFaction.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsFaction.Location = new global::System.Drawing.Point(22, 98);
			this.lblSettingsFaction.Name = "lblSettingsFaction";
			this.lblSettingsFaction.Size = new global::System.Drawing.Size(49, 15);
			this.lblSettingsFaction.TabIndex = 14;
			this.lblSettingsFaction.Text = "Faction:";
			this.grpAction.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAction.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAction.Controls.Add(this.btnActionTooltip);
			this.grpAction.Controls.Add(this.selectAction);
			this.grpAction.Controls.Add(this.lblActionEvent);
			this.grpAction.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAction.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAction.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAction.ForeColor = global::System.Drawing.Color.White;
			this.grpAction.Location = new global::System.Drawing.Point(14, 14);
			this.grpAction.Name = "grpAction";
			this.grpAction.Size = new global::System.Drawing.Size(649, 110);
			this.grpAction.TabIndex = 64;
			this.grpAction.Text = "Action";
			this.btnActionTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnActionTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnActionTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnActionTooltip.BorderRadius = 4;
			this.btnActionTooltip.BorderThickness = 1;
			this.btnActionTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnActionTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnActionTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnActionTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnActionTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnActionTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnActionTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnActionTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnActionTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnActionTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnActionTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnActionTooltip.Location = new global::System.Drawing.Point(602, 8);
			this.btnActionTooltip.Name = "btnActionTooltip";
			this.btnActionTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnActionTooltip.TabIndex = 73;
			this.btnActionTooltip.Click += new global::System.EventHandler(this.btnActionTooltip_Click);
			this.selectAction.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAction.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAction.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAction.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAction.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAction.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAction.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAction.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAction.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAction.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAction.ForeColor = global::System.Drawing.Color.White;
			this.selectAction.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAction.ItemHeight = 24;
			this.selectAction.Location = new global::System.Drawing.Point(180, 60);
			this.selectAction.Name = "selectAction";
			this.selectAction.Size = new global::System.Drawing.Size(400, 30);
			this.selectAction.TabIndex = 70;
			this.selectAction.DropDown += new global::System.EventHandler(this.selectAction_DropDown);
			this.selectAction.SelectedIndexChanged += new global::System.EventHandler(this.selectAction_SelectedIndexChanged);
			this.lblActionEvent.AutoSize = true;
			this.lblActionEvent.BackColor = global::System.Drawing.Color.Transparent;
			this.lblActionEvent.ForeColor = global::System.Drawing.Color.White;
			this.lblActionEvent.Location = new global::System.Drawing.Point(22, 67);
			this.lblActionEvent.Name = "lblActionEvent";
			this.lblActionEvent.Size = new global::System.Drawing.Size(39, 15);
			this.lblActionEvent.TabIndex = 14;
			this.lblActionEvent.Text = "Event:";
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 35f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 30f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 35f));
			this.tableLayoutPanel1.Controls.Add(this.grpConditionAndOr1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.grpCondition1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.grpCondition2, 2, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(14, 139);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(649, 188);
			this.tableLayoutPanel1.TabIndex = 65;
			this.grpConditionAndOr1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpConditionAndOr1.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpConditionAndOr1.Controls.Add(this.selectConditionAndOr1);
			this.grpConditionAndOr1.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpConditionAndOr1.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpConditionAndOr1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpConditionAndOr1.ForeColor = global::System.Drawing.Color.White;
			this.grpConditionAndOr1.Location = new global::System.Drawing.Point(236, 0);
			this.grpConditionAndOr1.Margin = new global::System.Windows.Forms.Padding(9, 0, 9, 0);
			this.grpConditionAndOr1.Name = "grpConditionAndOr1";
			this.grpConditionAndOr1.Size = new global::System.Drawing.Size(176, 188);
			this.grpConditionAndOr1.TabIndex = 9;
			this.grpConditionAndOr1.Text = "Combine Conditions";
			this.selectConditionAndOr1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectConditionAndOr1.BackColor = global::System.Drawing.Color.Transparent;
			this.selectConditionAndOr1.BorderColor = global::System.Drawing.Color.Gray;
			this.selectConditionAndOr1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectConditionAndOr1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectConditionAndOr1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectConditionAndOr1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectConditionAndOr1.Enabled = false;
			this.selectConditionAndOr1.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectConditionAndOr1.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectConditionAndOr1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectConditionAndOr1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectConditionAndOr1.ForeColor = global::System.Drawing.Color.White;
			this.selectConditionAndOr1.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectConditionAndOr1.ItemHeight = 24;
			this.selectConditionAndOr1.Items.AddRange(new object[]
			{
				"AND",
				"OR"
			});
			this.selectConditionAndOr1.Location = new global::System.Drawing.Point(21, 99);
			this.selectConditionAndOr1.Name = "selectConditionAndOr1";
			this.selectConditionAndOr1.Size = new global::System.Drawing.Size(135, 30);
			this.selectConditionAndOr1.TabIndex = 83;
			this.grpCondition1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpCondition1.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpCondition1.Controls.Add(this.txtCondition1Value2);
			this.grpCondition1.Controls.Add(this.txtCondition1Value);
			this.grpCondition1.Controls.Add(this.selectCondition1Compare);
			this.grpCondition1.Controls.Add(this.selectCondition1);
			this.grpCondition1.Controls.Add(this.checkCondition1);
			this.grpCondition1.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpCondition1.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpCondition1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpCondition1.ForeColor = global::System.Drawing.Color.White;
			this.grpCondition1.Location = new global::System.Drawing.Point(0, 0);
			this.grpCondition1.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpCondition1.Name = "grpCondition1";
			this.grpCondition1.Size = new global::System.Drawing.Size(218, 188);
			this.grpCondition1.TabIndex = 7;
			this.txtCondition1Value2.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition1Value2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCondition1Value2.DefaultText = "";
			this.txtCondition1Value2.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition1Value2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtCondition1Value2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition1Value2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition1Value2.Enabled = false;
			this.txtCondition1Value2.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtCondition1Value2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtCondition1Value2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCondition1Value2.ForeColor = global::System.Drawing.Color.White;
			this.txtCondition1Value2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtCondition1Value2.Location = new global::System.Drawing.Point(121, 138);
			this.txtCondition1Value2.MaxLength = 200;
			this.txtCondition1Value2.Name = "txtCondition1Value2";
			this.txtCondition1Value2.PasswordChar = '\0';
			this.txtCondition1Value2.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtCondition1Value2.PlaceholderText = "";
			this.txtCondition1Value2.SelectedText = "";
			this.txtCondition1Value2.Size = new global::System.Drawing.Size(93, 30);
			this.txtCondition1Value2.TabIndex = 82;
			this.txtCondition1Value2.Visible = false;
			this.txtCondition1Value.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition1Value.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCondition1Value.DefaultText = "";
			this.txtCondition1Value.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition1Value.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtCondition1Value.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition1Value.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition1Value.Enabled = false;
			this.txtCondition1Value.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtCondition1Value.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtCondition1Value.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCondition1Value.ForeColor = global::System.Drawing.Color.White;
			this.txtCondition1Value.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtCondition1Value.Location = new global::System.Drawing.Point(25, 138);
			this.txtCondition1Value.MaxLength = 200;
			this.txtCondition1Value.Name = "txtCondition1Value";
			this.txtCondition1Value.PasswordChar = '\0';
			this.txtCondition1Value.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtCondition1Value.PlaceholderText = "";
			this.txtCondition1Value.SelectedText = "";
			this.txtCondition1Value.Size = new global::System.Drawing.Size(93, 30);
			this.txtCondition1Value.TabIndex = 81;
			this.selectCondition1Compare.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectCondition1Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.selectCondition1Compare.BorderColor = global::System.Drawing.Color.Gray;
			this.selectCondition1Compare.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectCondition1Compare.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectCondition1Compare.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectCondition1Compare.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCondition1Compare.Enabled = false;
			this.selectCondition1Compare.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectCondition1Compare.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition1Compare.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition1Compare.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectCondition1Compare.ForeColor = global::System.Drawing.Color.White;
			this.selectCondition1Compare.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectCondition1Compare.ItemHeight = 24;
			this.selectCondition1Compare.Items.AddRange(new object[]
			{
				"Smaller or Equal",
				"Equal",
				"Greater or Equal",
				"Item ID"
			});
			this.selectCondition1Compare.Location = new global::System.Drawing.Point(25, 99);
			this.selectCondition1Compare.Name = "selectCondition1Compare";
			this.selectCondition1Compare.Size = new global::System.Drawing.Size(168, 30);
			this.selectCondition1Compare.TabIndex = 80;
			this.selectCondition1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectCondition1.BackColor = global::System.Drawing.Color.Transparent;
			this.selectCondition1.BorderColor = global::System.Drawing.Color.Gray;
			this.selectCondition1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectCondition1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectCondition1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectCondition1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCondition1.Enabled = false;
			this.selectCondition1.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectCondition1.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectCondition1.ForeColor = global::System.Drawing.Color.White;
			this.selectCondition1.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectCondition1.ItemHeight = 24;
			this.selectCondition1.Items.AddRange(new object[]
			{
				"Level",
				"Class",
				"Bags are full",
				"Bags are not full",
				"Free bag slots",
				"Bag contains Item (by ID)",
				"Is in Range of... (in Yards)",
				"Skill Name",
				"Skill Level",
				"Low Armor Durability",
				"When Quest(s) completed"
			});
			this.selectCondition1.Location = new global::System.Drawing.Point(25, 60);
			this.selectCondition1.Name = "selectCondition1";
			this.selectCondition1.Size = new global::System.Drawing.Size(168, 30);
			this.selectCondition1.TabIndex = 79;
			this.selectCondition1.SelectedIndexChanged += new global::System.EventHandler(this.selectCondition1_SelectedIndexChanged);
			this.checkCondition1.Animated = true;
			this.checkCondition1.AutoSize = true;
			this.checkCondition1.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCondition1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCondition1.CheckedState.BorderRadius = 0;
			this.checkCondition1.CheckedState.BorderThickness = 0;
			this.checkCondition1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCondition1.Location = new global::System.Drawing.Point(12, 11);
			this.checkCondition1.Name = "checkCondition1";
			this.checkCondition1.Size = new global::System.Drawing.Size(95, 19);
			this.checkCondition1.TabIndex = 33;
			this.checkCondition1.Text = "Condition #1";
			this.checkCondition1.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkCondition1.UncheckedState.BorderRadius = 0;
			this.checkCondition1.UncheckedState.BorderThickness = 1;
			this.checkCondition1.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkCondition1.UseVisualStyleBackColor = false;
			this.checkCondition1.CheckedChanged += new global::System.EventHandler(this.checkCondition1_CheckedChanged);
			this.grpCondition2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpCondition2.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpCondition2.Controls.Add(this.txtCondition2Value2);
			this.grpCondition2.Controls.Add(this.btnConditionTooltip);
			this.grpCondition2.Controls.Add(this.txtCondition2Value);
			this.grpCondition2.Controls.Add(this.selectCondition2Compare);
			this.grpCondition2.Controls.Add(this.selectCondition2);
			this.grpCondition2.Controls.Add(this.checkCondition2);
			this.grpCondition2.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpCondition2.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpCondition2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpCondition2.ForeColor = global::System.Drawing.Color.White;
			this.grpCondition2.Location = new global::System.Drawing.Point(430, 0);
			this.grpCondition2.Margin = new global::System.Windows.Forms.Padding(9, 0, 0, 0);
			this.grpCondition2.Name = "grpCondition2";
			this.grpCondition2.Size = new global::System.Drawing.Size(219, 188);
			this.grpCondition2.TabIndex = 8;
			this.txtCondition2Value2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtCondition2Value2.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition2Value2.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCondition2Value2.DefaultText = "";
			this.txtCondition2Value2.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition2Value2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtCondition2Value2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition2Value2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition2Value2.Enabled = false;
			this.txtCondition2Value2.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtCondition2Value2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtCondition2Value2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCondition2Value2.ForeColor = global::System.Drawing.Color.White;
			this.txtCondition2Value2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtCondition2Value2.Location = new global::System.Drawing.Point(119, 138);
			this.txtCondition2Value2.MaxLength = 200;
			this.txtCondition2Value2.Name = "txtCondition2Value2";
			this.txtCondition2Value2.PasswordChar = '\0';
			this.txtCondition2Value2.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtCondition2Value2.PlaceholderText = "";
			this.txtCondition2Value2.SelectedText = "";
			this.txtCondition2Value2.Size = new global::System.Drawing.Size(72, 30);
			this.txtCondition2Value2.TabIndex = 86;
			this.txtCondition2Value2.Visible = false;
			this.btnConditionTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnConditionTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnConditionTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnConditionTooltip.BorderRadius = 4;
			this.btnConditionTooltip.BorderThickness = 1;
			this.btnConditionTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnConditionTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnConditionTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnConditionTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnConditionTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnConditionTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnConditionTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnConditionTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnConditionTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnConditionTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnConditionTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnConditionTooltip.Location = new global::System.Drawing.Point(172, 8);
			this.btnConditionTooltip.Name = "btnConditionTooltip";
			this.btnConditionTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnConditionTooltip.TabIndex = 85;
			this.btnConditionTooltip.Click += new global::System.EventHandler(this.btnConditionTooltip_Click);
			this.txtCondition2Value.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition2Value.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCondition2Value.DefaultText = "";
			this.txtCondition2Value.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCondition2Value.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtCondition2Value.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition2Value.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCondition2Value.Enabled = false;
			this.txtCondition2Value.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtCondition2Value.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtCondition2Value.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCondition2Value.ForeColor = global::System.Drawing.Color.White;
			this.txtCondition2Value.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtCondition2Value.Location = new global::System.Drawing.Point(25, 138);
			this.txtCondition2Value.MaxLength = 200;
			this.txtCondition2Value.Name = "txtCondition2Value";
			this.txtCondition2Value.PasswordChar = '\0';
			this.txtCondition2Value.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtCondition2Value.PlaceholderText = "";
			this.txtCondition2Value.SelectedText = "";
			this.txtCondition2Value.Size = new global::System.Drawing.Size(93, 30);
			this.txtCondition2Value.TabIndex = 84;
			this.selectCondition2Compare.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectCondition2Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.selectCondition2Compare.BorderColor = global::System.Drawing.Color.Gray;
			this.selectCondition2Compare.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectCondition2Compare.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectCondition2Compare.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectCondition2Compare.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCondition2Compare.Enabled = false;
			this.selectCondition2Compare.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectCondition2Compare.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition2Compare.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition2Compare.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectCondition2Compare.ForeColor = global::System.Drawing.Color.White;
			this.selectCondition2Compare.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectCondition2Compare.ItemHeight = 24;
			this.selectCondition2Compare.Items.AddRange(new object[]
			{
				"Smaller or Equal",
				"Equal",
				"Greater or Equal",
				"Item ID"
			});
			this.selectCondition2Compare.Location = new global::System.Drawing.Point(25, 99);
			this.selectCondition2Compare.Name = "selectCondition2Compare";
			this.selectCondition2Compare.Size = new global::System.Drawing.Size(167, 30);
			this.selectCondition2Compare.TabIndex = 83;
			this.selectCondition2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectCondition2.BackColor = global::System.Drawing.Color.Transparent;
			this.selectCondition2.BorderColor = global::System.Drawing.Color.Gray;
			this.selectCondition2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectCondition2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectCondition2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectCondition2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectCondition2.Enabled = false;
			this.selectCondition2.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectCondition2.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectCondition2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectCondition2.ForeColor = global::System.Drawing.Color.White;
			this.selectCondition2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectCondition2.ItemHeight = 24;
			this.selectCondition2.Items.AddRange(new object[]
			{
				"Level",
				"Class",
				"Bags are full",
				"Bags are not full",
				"Free bag slots",
				"Bag contains Item (by ID)",
				"Is in Range of... (in Yards)",
				"Skill Name",
				"Skill Level",
				"Low Armor Durability",
				"When Quest(s) completed"
			});
			this.selectCondition2.Location = new global::System.Drawing.Point(25, 60);
			this.selectCondition2.Name = "selectCondition2";
			this.selectCondition2.Size = new global::System.Drawing.Size(167, 30);
			this.selectCondition2.TabIndex = 82;
			this.selectCondition2.SelectedIndexChanged += new global::System.EventHandler(this.selectCondition2_SelectedIndexChanged);
			this.checkCondition2.Animated = true;
			this.checkCondition2.AutoSize = true;
			this.checkCondition2.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCondition2.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCondition2.CheckedState.BorderRadius = 0;
			this.checkCondition2.CheckedState.BorderThickness = 0;
			this.checkCondition2.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCondition2.Enabled = false;
			this.checkCondition2.Location = new global::System.Drawing.Point(12, 11);
			this.checkCondition2.Name = "checkCondition2";
			this.checkCondition2.Size = new global::System.Drawing.Size(95, 19);
			this.checkCondition2.TabIndex = 34;
			this.checkCondition2.Text = "Condition #2";
			this.checkCondition2.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkCondition2.UncheckedState.BorderRadius = 0;
			this.checkCondition2.UncheckedState.BorderThickness = 1;
			this.checkCondition2.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkCondition2.UseVisualStyleBackColor = false;
			this.checkCondition2.CheckedChanged += new global::System.EventHandler(this.checkCondition2_CheckedChanged);
			this.tabInteractWith.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabInteractWith.Controls.Add(this.panelTabInteractWith);
			this.tabInteractWith.ForeColor = global::System.Drawing.Color.White;
			this.tabInteractWith.Location = new global::System.Drawing.Point(4, 124);
			this.tabInteractWith.Name = "tabInteractWith";
			this.tabInteractWith.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabInteractWith.Size = new global::System.Drawing.Size(763, 432);
			this.tabInteractWith.TabIndex = 1;
			this.tabInteractWith.Text = "Interact with...";
			this.panelTabInteractWith.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabInteractWith.AutoScroll = true;
			this.panelTabInteractWith.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabInteractWith.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabInteractWith.Controls.Add(this.grpInteract);
			this.panelTabInteractWith.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabInteractWith.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabInteractWith.Name = "panelTabInteractWith";
			this.panelTabInteractWith.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabInteractWith.TabIndex = 65;
			this.grpInteract.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInteract.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInteract.Controls.Add(this.btnInteractWithTooltip);
			this.grpInteract.Controls.Add(this.checkInteractFurthest);
			this.grpInteract.Controls.Add(this.txtInteractNameOrID);
			this.grpInteract.Controls.Add(this.checkInteractAttack);
			this.grpInteract.Controls.Add(this.checkInteractClosest);
			this.grpInteract.Controls.Add(this.lblInteractNameOrID);
			this.grpInteract.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInteract.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInteract.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInteract.ForeColor = global::System.Drawing.Color.White;
			this.grpInteract.Location = new global::System.Drawing.Point(14, 14);
			this.grpInteract.Name = "grpInteract";
			this.grpInteract.Size = new global::System.Drawing.Size(734, 170);
			this.grpInteract.TabIndex = 64;
			this.grpInteract.Text = "Interact with...";
			this.btnInteractWithTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnInteractWithTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnInteractWithTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnInteractWithTooltip.BorderRadius = 4;
			this.btnInteractWithTooltip.BorderThickness = 1;
			this.btnInteractWithTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnInteractWithTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnInteractWithTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnInteractWithTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnInteractWithTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnInteractWithTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnInteractWithTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnInteractWithTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnInteractWithTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnInteractWithTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnInteractWithTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnInteractWithTooltip.Location = new global::System.Drawing.Point(685, 8);
			this.btnInteractWithTooltip.Name = "btnInteractWithTooltip";
			this.btnInteractWithTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnInteractWithTooltip.TabIndex = 103;
			this.btnInteractWithTooltip.Click += new global::System.EventHandler(this.btnInteractWithTooltip_Click);
			this.checkInteractFurthest.Animated = true;
			this.checkInteractFurthest.AutoSize = true;
			this.checkInteractFurthest.BackColor = global::System.Drawing.Color.Transparent;
			this.checkInteractFurthest.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkInteractFurthest.CheckedState.BorderRadius = 0;
			this.checkInteractFurthest.CheckedState.BorderThickness = 0;
			this.checkInteractFurthest.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkInteractFurthest.Location = new global::System.Drawing.Point(259, 105);
			this.checkInteractFurthest.Name = "checkInteractFurthest";
			this.checkInteractFurthest.Size = new global::System.Drawing.Size(69, 19);
			this.checkInteractFurthest.TabIndex = 94;
			this.checkInteractFurthest.Text = "Furthest";
			this.checkInteractFurthest.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkInteractFurthest.UncheckedState.BorderRadius = 0;
			this.checkInteractFurthest.UncheckedState.BorderThickness = 1;
			this.checkInteractFurthest.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkInteractFurthest.UseVisualStyleBackColor = false;
			this.checkInteractFurthest.CheckedChanged += new global::System.EventHandler(this.checkInteractFurthest_CheckedChanged);
			this.txtInteractNameOrID.BorderColor = global::System.Drawing.Color.Gray;
			this.txtInteractNameOrID.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtInteractNameOrID.DefaultText = "";
			this.txtInteractNameOrID.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtInteractNameOrID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtInteractNameOrID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtInteractNameOrID.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtInteractNameOrID.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtInteractNameOrID.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtInteractNameOrID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtInteractNameOrID.ForeColor = global::System.Drawing.Color.White;
			this.txtInteractNameOrID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtInteractNameOrID.Location = new global::System.Drawing.Point(180, 60);
			this.txtInteractNameOrID.MaxLength = 200;
			this.txtInteractNameOrID.Name = "txtInteractNameOrID";
			this.txtInteractNameOrID.PasswordChar = '\0';
			this.txtInteractNameOrID.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtInteractNameOrID.PlaceholderText = "";
			this.txtInteractNameOrID.SelectedText = "";
			this.txtInteractNameOrID.Size = new global::System.Drawing.Size(225, 30);
			this.txtInteractNameOrID.TabIndex = 93;
			this.checkInteractAttack.Animated = true;
			this.checkInteractAttack.AutoSize = true;
			this.checkInteractAttack.BackColor = global::System.Drawing.Color.Transparent;
			this.checkInteractAttack.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkInteractAttack.CheckedState.BorderRadius = 0;
			this.checkInteractAttack.CheckedState.BorderThickness = 0;
			this.checkInteractAttack.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkInteractAttack.Location = new global::System.Drawing.Point(180, 134);
			this.checkInteractAttack.Name = "checkInteractAttack";
			this.checkInteractAttack.Size = new global::System.Drawing.Size(87, 19);
			this.checkInteractAttack.TabIndex = 72;
			this.checkInteractAttack.Text = "Start Attack";
			this.checkInteractAttack.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkInteractAttack.UncheckedState.BorderRadius = 0;
			this.checkInteractAttack.UncheckedState.BorderThickness = 1;
			this.checkInteractAttack.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkInteractAttack.UseVisualStyleBackColor = false;
			this.checkInteractClosest.Animated = true;
			this.checkInteractClosest.AutoSize = true;
			this.checkInteractClosest.BackColor = global::System.Drawing.Color.Transparent;
			this.checkInteractClosest.Checked = true;
			this.checkInteractClosest.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkInteractClosest.CheckedState.BorderRadius = 0;
			this.checkInteractClosest.CheckedState.BorderThickness = 0;
			this.checkInteractClosest.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkInteractClosest.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkInteractClosest.Location = new global::System.Drawing.Point(180, 105);
			this.checkInteractClosest.Name = "checkInteractClosest";
			this.checkInteractClosest.Size = new global::System.Drawing.Size(64, 19);
			this.checkInteractClosest.TabIndex = 71;
			this.checkInteractClosest.Text = "Closest";
			this.checkInteractClosest.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkInteractClosest.UncheckedState.BorderRadius = 0;
			this.checkInteractClosest.UncheckedState.BorderThickness = 1;
			this.checkInteractClosest.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkInteractClosest.UseVisualStyleBackColor = false;
			this.checkInteractClosest.CheckedChanged += new global::System.EventHandler(this.checkInteractClosest_CheckedChanged);
			this.lblInteractNameOrID.AutoSize = true;
			this.lblInteractNameOrID.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInteractNameOrID.Location = new global::System.Drawing.Point(22, 66);
			this.lblInteractNameOrID.Name = "lblInteractNameOrID";
			this.lblInteractNameOrID.Size = new global::System.Drawing.Size(70, 15);
			this.lblInteractNameOrID.TabIndex = 68;
			this.lblInteractNameOrID.Text = "ID or Name:";
			this.tabWait.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabWait.Controls.Add(this.panelTabWait);
			this.tabWait.ForeColor = global::System.Drawing.Color.White;
			this.tabWait.Location = new global::System.Drawing.Point(4, 124);
			this.tabWait.Name = "tabWait";
			this.tabWait.Size = new global::System.Drawing.Size(763, 432);
			this.tabWait.TabIndex = 2;
			this.tabWait.Text = "Wait";
			this.panelTabWait.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabWait.AutoScroll = true;
			this.panelTabWait.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabWait.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabWait.Controls.Add(this.grpWaitFor);
			this.panelTabWait.Controls.Add(this.grpWait);
			this.panelTabWait.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabWait.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabWait.Name = "panelTabWait";
			this.panelTabWait.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabWait.TabIndex = 67;
			this.grpWaitFor.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpWaitFor.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpWaitFor.Controls.Add(this.checkWaitForGate);
			this.grpWaitFor.Controls.Add(this.txtWaitForMaxSeconds);
			this.grpWaitFor.Controls.Add(this.txtWaitForNameOrID);
			this.grpWaitFor.Controls.Add(this.lblWaitForMaxSeconds);
			this.grpWaitFor.Controls.Add(this.lblWaitFor);
			this.grpWaitFor.Controls.Add(this.checkWaitFor);
			this.grpWaitFor.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpWaitFor.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpWaitFor.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpWaitFor.ForeColor = global::System.Drawing.Color.White;
			this.grpWaitFor.Location = new global::System.Drawing.Point(14, 169);
			this.grpWaitFor.Name = "grpWaitFor";
			this.grpWaitFor.Size = new global::System.Drawing.Size(734, 179);
			this.grpWaitFor.TabIndex = 66;
			this.checkWaitForGate.Animated = true;
			this.checkWaitForGate.AutoSize = true;
			this.checkWaitForGate.BackColor = global::System.Drawing.Color.Transparent;
			this.checkWaitForGate.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWaitForGate.CheckedState.BorderRadius = 0;
			this.checkWaitForGate.CheckedState.BorderThickness = 0;
			this.checkWaitForGate.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWaitForGate.Enabled = false;
			this.checkWaitForGate.Location = new global::System.Drawing.Point(180, 144);
			this.checkWaitForGate.Name = "checkWaitForGate";
			this.checkWaitForGate.Size = new global::System.Drawing.Size(131, 19);
			this.checkWaitForGate.TabIndex = 102;
			this.checkWaitForGate.Text = "Is Gate/Door or Flag";
			this.checkWaitForGate.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkWaitForGate.UncheckedState.BorderRadius = 0;
			this.checkWaitForGate.UncheckedState.BorderThickness = 1;
			this.checkWaitForGate.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkWaitForGate.UseVisualStyleBackColor = false;
			this.txtWaitForMaxSeconds.BorderColor = global::System.Drawing.Color.Gray;
			this.txtWaitForMaxSeconds.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtWaitForMaxSeconds.DefaultText = "";
			this.txtWaitForMaxSeconds.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtWaitForMaxSeconds.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtWaitForMaxSeconds.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtWaitForMaxSeconds.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtWaitForMaxSeconds.Enabled = false;
			this.txtWaitForMaxSeconds.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtWaitForMaxSeconds.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtWaitForMaxSeconds.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtWaitForMaxSeconds.ForeColor = global::System.Drawing.Color.White;
			this.txtWaitForMaxSeconds.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtWaitForMaxSeconds.Location = new global::System.Drawing.Point(180, 99);
			this.txtWaitForMaxSeconds.MaxLength = 200;
			this.txtWaitForMaxSeconds.Name = "txtWaitForMaxSeconds";
			this.txtWaitForMaxSeconds.PasswordChar = '\0';
			this.txtWaitForMaxSeconds.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtWaitForMaxSeconds.PlaceholderText = "";
			this.txtWaitForMaxSeconds.SelectedText = "";
			this.txtWaitForMaxSeconds.Size = new global::System.Drawing.Size(225, 30);
			this.txtWaitForMaxSeconds.TabIndex = 101;
			this.txtWaitForNameOrID.BorderColor = global::System.Drawing.Color.Gray;
			this.txtWaitForNameOrID.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtWaitForNameOrID.DefaultText = "";
			this.txtWaitForNameOrID.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtWaitForNameOrID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtWaitForNameOrID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtWaitForNameOrID.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtWaitForNameOrID.Enabled = false;
			this.txtWaitForNameOrID.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtWaitForNameOrID.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtWaitForNameOrID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtWaitForNameOrID.ForeColor = global::System.Drawing.Color.White;
			this.txtWaitForNameOrID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtWaitForNameOrID.Location = new global::System.Drawing.Point(180, 60);
			this.txtWaitForNameOrID.MaxLength = 200;
			this.txtWaitForNameOrID.Name = "txtWaitForNameOrID";
			this.txtWaitForNameOrID.PasswordChar = '\0';
			this.txtWaitForNameOrID.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtWaitForNameOrID.PlaceholderText = "";
			this.txtWaitForNameOrID.SelectedText = "";
			this.txtWaitForNameOrID.Size = new global::System.Drawing.Size(225, 30);
			this.txtWaitForNameOrID.TabIndex = 100;
			this.lblWaitForMaxSeconds.AutoSize = true;
			this.lblWaitForMaxSeconds.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWaitForMaxSeconds.Enabled = false;
			this.lblWaitForMaxSeconds.ForeColor = global::System.Drawing.Color.White;
			this.lblWaitForMaxSeconds.Location = new global::System.Drawing.Point(22, 106);
			this.lblWaitForMaxSeconds.Name = "lblWaitForMaxSeconds";
			this.lblWaitForMaxSeconds.Size = new global::System.Drawing.Size(83, 15);
			this.lblWaitForMaxSeconds.TabIndex = 98;
			this.lblWaitForMaxSeconds.Text = "Max. Seconds:";
			this.lblWaitFor.AutoSize = true;
			this.lblWaitFor.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWaitFor.Enabled = false;
			this.lblWaitFor.ForeColor = global::System.Drawing.Color.White;
			this.lblWaitFor.Location = new global::System.Drawing.Point(22, 67);
			this.lblWaitFor.Name = "lblWaitFor";
			this.lblWaitFor.Size = new global::System.Drawing.Size(70, 15);
			this.lblWaitFor.TabIndex = 96;
			this.lblWaitFor.Text = "ID or Name:";
			this.checkWaitFor.Animated = true;
			this.checkWaitFor.AutoSize = true;
			this.checkWaitFor.BackColor = global::System.Drawing.Color.Transparent;
			this.checkWaitFor.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWaitFor.CheckedState.BorderRadius = 0;
			this.checkWaitFor.CheckedState.BorderThickness = 0;
			this.checkWaitFor.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWaitFor.Location = new global::System.Drawing.Point(12, 11);
			this.checkWaitFor.Name = "checkWaitFor";
			this.checkWaitFor.Size = new global::System.Drawing.Size(77, 19);
			this.checkWaitFor.TabIndex = 95;
			this.checkWaitFor.Text = "Wait for...";
			this.checkWaitFor.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkWaitFor.UncheckedState.BorderRadius = 0;
			this.checkWaitFor.UncheckedState.BorderThickness = 1;
			this.checkWaitFor.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkWaitFor.UseVisualStyleBackColor = false;
			this.checkWaitFor.CheckedChanged += new global::System.EventHandler(this.checkWaitFor_CheckedChanged);
			this.grpWait.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpWait.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpWait.Controls.Add(this.checkWait);
			this.grpWait.Controls.Add(this.txtWaitSeconds);
			this.grpWait.Controls.Add(this.checkWaitIgnoreAttackers);
			this.grpWait.Controls.Add(this.lblWaitSeconds);
			this.grpWait.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpWait.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpWait.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpWait.ForeColor = global::System.Drawing.Color.White;
			this.grpWait.Location = new global::System.Drawing.Point(14, 14);
			this.grpWait.Name = "grpWait";
			this.grpWait.Size = new global::System.Drawing.Size(734, 140);
			this.grpWait.TabIndex = 65;
			this.checkWait.Animated = true;
			this.checkWait.AutoSize = true;
			this.checkWait.BackColor = global::System.Drawing.Color.Transparent;
			this.checkWait.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWait.CheckedState.BorderRadius = 0;
			this.checkWait.CheckedState.BorderThickness = 0;
			this.checkWait.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWait.Location = new global::System.Drawing.Point(12, 11);
			this.checkWait.Name = "checkWait";
			this.checkWait.Size = new global::System.Drawing.Size(50, 19);
			this.checkWait.TabIndex = 95;
			this.checkWait.Text = "Wait";
			this.checkWait.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkWait.UncheckedState.BorderRadius = 0;
			this.checkWait.UncheckedState.BorderThickness = 1;
			this.checkWait.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkWait.UseVisualStyleBackColor = false;
			this.checkWait.CheckedChanged += new global::System.EventHandler(this.checkWait_CheckedChanged);
			this.txtWaitSeconds.BorderColor = global::System.Drawing.Color.Gray;
			this.txtWaitSeconds.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtWaitSeconds.DefaultText = "";
			this.txtWaitSeconds.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtWaitSeconds.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtWaitSeconds.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtWaitSeconds.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtWaitSeconds.Enabled = false;
			this.txtWaitSeconds.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtWaitSeconds.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtWaitSeconds.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtWaitSeconds.ForeColor = global::System.Drawing.Color.White;
			this.txtWaitSeconds.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtWaitSeconds.Location = new global::System.Drawing.Point(180, 60);
			this.txtWaitSeconds.MaxLength = 200;
			this.txtWaitSeconds.Name = "txtWaitSeconds";
			this.txtWaitSeconds.PasswordChar = '\0';
			this.txtWaitSeconds.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtWaitSeconds.PlaceholderText = "";
			this.txtWaitSeconds.SelectedText = "";
			this.txtWaitSeconds.Size = new global::System.Drawing.Size(225, 30);
			this.txtWaitSeconds.TabIndex = 93;
			this.checkWaitIgnoreAttackers.Animated = true;
			this.checkWaitIgnoreAttackers.AutoSize = true;
			this.checkWaitIgnoreAttackers.BackColor = global::System.Drawing.Color.Transparent;
			this.checkWaitIgnoreAttackers.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWaitIgnoreAttackers.CheckedState.BorderRadius = 0;
			this.checkWaitIgnoreAttackers.CheckedState.BorderThickness = 0;
			this.checkWaitIgnoreAttackers.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkWaitIgnoreAttackers.Enabled = false;
			this.checkWaitIgnoreAttackers.Location = new global::System.Drawing.Point(180, 105);
			this.checkWaitIgnoreAttackers.Name = "checkWaitIgnoreAttackers";
			this.checkWaitIgnoreAttackers.Size = new global::System.Drawing.Size(112, 19);
			this.checkWaitIgnoreAttackers.TabIndex = 71;
			this.checkWaitIgnoreAttackers.Text = "Ignore Attackers";
			this.checkWaitIgnoreAttackers.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkWaitIgnoreAttackers.UncheckedState.BorderRadius = 0;
			this.checkWaitIgnoreAttackers.UncheckedState.BorderThickness = 1;
			this.checkWaitIgnoreAttackers.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkWaitIgnoreAttackers.UseVisualStyleBackColor = false;
			this.lblWaitSeconds.AutoSize = true;
			this.lblWaitSeconds.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWaitSeconds.Enabled = false;
			this.lblWaitSeconds.Location = new global::System.Drawing.Point(22, 66);
			this.lblWaitSeconds.Name = "lblWaitSeconds";
			this.lblWaitSeconds.Size = new global::System.Drawing.Size(54, 15);
			this.lblWaitSeconds.TabIndex = 68;
			this.lblWaitSeconds.Text = "Seconds:";
			this.tabLoadProfile.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabLoadProfile.Controls.Add(this.panelTabLoadProfile);
			this.tabLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.tabLoadProfile.Location = new global::System.Drawing.Point(4, 124);
			this.tabLoadProfile.Name = "tabLoadProfile";
			this.tabLoadProfile.Size = new global::System.Drawing.Size(763, 432);
			this.tabLoadProfile.TabIndex = 3;
			this.tabLoadProfile.Text = "Load Profile";
			this.panelTabLoadProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabLoadProfile.AutoScroll = true;
			this.panelTabLoadProfile.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabLoadProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabLoadProfile.Controls.Add(this.grpLoadProfile);
			this.panelTabLoadProfile.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabLoadProfile.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabLoadProfile.Name = "panelTabLoadProfile";
			this.panelTabLoadProfile.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabLoadProfile.TabIndex = 66;
			this.grpLoadProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpLoadProfile.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpLoadProfile.Controls.Add(this.selectLoadProfile);
			this.grpLoadProfile.Controls.Add(this.lblLoadProfile);
			this.grpLoadProfile.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpLoadProfile.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpLoadProfile.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.grpLoadProfile.Location = new global::System.Drawing.Point(14, 14);
			this.grpLoadProfile.Name = "grpLoadProfile";
			this.grpLoadProfile.Size = new global::System.Drawing.Size(734, 108);
			this.grpLoadProfile.TabIndex = 65;
			this.grpLoadProfile.Text = "Load Profile";
			this.selectLoadProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectLoadProfile.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectLoadProfile.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectLoadProfile.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectLoadProfile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectLoadProfile.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.selectLoadProfile.FormattingEnabled = true;
			this.selectLoadProfile.Location = new global::System.Drawing.Point(180, 60);
			this.selectLoadProfile.Name = "selectLoadProfile";
			this.selectLoadProfile.Size = new global::System.Drawing.Size(527, 29);
			this.selectLoadProfile.TabIndex = 71;
			this.lblLoadProfile.AutoSize = true;
			this.lblLoadProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.lblLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.lblLoadProfile.Location = new global::System.Drawing.Point(22, 67);
			this.lblLoadProfile.Name = "lblLoadProfile";
			this.lblLoadProfile.Size = new global::System.Drawing.Size(44, 15);
			this.lblLoadProfile.TabIndex = 14;
			this.lblLoadProfile.Text = "Profile:";
			this.tabLoadRotation.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabLoadRotation.Controls.Add(this.panelTabLoadRotation);
			this.tabLoadRotation.Location = new global::System.Drawing.Point(4, 124);
			this.tabLoadRotation.Name = "tabLoadRotation";
			this.tabLoadRotation.Size = new global::System.Drawing.Size(763, 432);
			this.tabLoadRotation.TabIndex = 14;
			this.tabLoadRotation.Text = "Load Rotation";
			this.panelTabLoadRotation.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabLoadRotation.AutoScroll = true;
			this.panelTabLoadRotation.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabLoadRotation.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabLoadRotation.Controls.Add(this.grpLoadRotation);
			this.panelTabLoadRotation.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabLoadRotation.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabLoadRotation.Name = "panelTabLoadRotation";
			this.panelTabLoadRotation.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabLoadRotation.TabIndex = 67;
			this.grpLoadRotation.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpLoadRotation.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpLoadRotation.Controls.Add(this.selectLoadRotation);
			this.grpLoadRotation.Controls.Add(this.lblLoadRotation);
			this.grpLoadRotation.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpLoadRotation.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpLoadRotation.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpLoadRotation.ForeColor = global::System.Drawing.Color.White;
			this.grpLoadRotation.Location = new global::System.Drawing.Point(14, 14);
			this.grpLoadRotation.Name = "grpLoadRotation";
			this.grpLoadRotation.Size = new global::System.Drawing.Size(734, 108);
			this.grpLoadRotation.TabIndex = 65;
			this.grpLoadRotation.Text = "Load Rotation";
			this.selectLoadRotation.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectLoadRotation.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectLoadRotation.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectLoadRotation.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectLoadRotation.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectLoadRotation.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectLoadRotation.ForeColor = global::System.Drawing.Color.White;
			this.selectLoadRotation.FormattingEnabled = true;
			this.selectLoadRotation.Location = new global::System.Drawing.Point(180, 60);
			this.selectLoadRotation.Name = "selectLoadRotation";
			this.selectLoadRotation.Size = new global::System.Drawing.Size(527, 29);
			this.selectLoadRotation.TabIndex = 71;
			this.lblLoadRotation.AutoSize = true;
			this.lblLoadRotation.BackColor = global::System.Drawing.Color.Transparent;
			this.lblLoadRotation.ForeColor = global::System.Drawing.Color.White;
			this.lblLoadRotation.Location = new global::System.Drawing.Point(22, 67);
			this.lblLoadRotation.Name = "lblLoadRotation";
			this.lblLoadRotation.Size = new global::System.Drawing.Size(55, 15);
			this.lblLoadRotation.TabIndex = 14;
			this.lblLoadRotation.Text = "Rotation:";
			this.tabRecorder.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabRecorder.Controls.Add(this.panelTabRecorder);
			this.tabRecorder.Location = new global::System.Drawing.Point(4, 124);
			this.tabRecorder.Name = "tabRecorder";
			this.tabRecorder.Size = new global::System.Drawing.Size(763, 432);
			this.tabRecorder.TabIndex = 9;
			this.tabRecorder.Text = "Add Vendor, ...";
			this.panelTabRecorder.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabRecorder.AutoScroll = true;
			this.panelTabRecorder.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabRecorder.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabRecorder.Controls.Add(this.grpRecorderMailbox);
			this.panelTabRecorder.Controls.Add(this.tableLayoutPanel2);
			this.panelTabRecorder.Controls.Add(this.grpRecorderFlightMaster);
			this.panelTabRecorder.Controls.Add(this.grpRecorderVendor);
			this.panelTabRecorder.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabRecorder.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabRecorder.Name = "panelTabRecorder";
			this.panelTabRecorder.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabRecorder.TabIndex = 79;
			this.grpRecorderMailbox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpRecorderMailbox.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpRecorderMailbox.Controls.Add(this.btnRecorderMailboxTooltip);
			this.grpRecorderMailbox.Controls.Add(this.btnRecorderMailboxSendlist);
			this.grpRecorderMailbox.Controls.Add(this.txtRecorderMailboxReceiver);
			this.grpRecorderMailbox.Controls.Add(this.checkRecorderMailboxSendPurples);
			this.grpRecorderMailbox.Controls.Add(this.checkRecorderMailboxSendGreys);
			this.grpRecorderMailbox.Controls.Add(this.checkRecorderMailboxSendBlues);
			this.grpRecorderMailbox.Controls.Add(this.checkRecorderMailboxSendGreens);
			this.grpRecorderMailbox.Controls.Add(this.checkRecorderMailboxSendWhites);
			this.grpRecorderMailbox.Controls.Add(this.sepRecorderMailbox1);
			this.grpRecorderMailbox.Controls.Add(this.lblRecorderMailboxReceiver);
			this.grpRecorderMailbox.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpRecorderMailbox.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpRecorderMailbox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRecorderMailbox.ForeColor = global::System.Drawing.Color.White;
			this.grpRecorderMailbox.Location = new global::System.Drawing.Point(14, 713);
			this.grpRecorderMailbox.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpRecorderMailbox.Name = "grpRecorderMailbox";
			this.grpRecorderMailbox.Size = new global::System.Drawing.Size(666, 212);
			this.grpRecorderMailbox.TabIndex = 78;
			this.grpRecorderMailbox.Text = "Mailbox";
			this.btnRecorderMailboxTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderMailboxTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderMailboxTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnRecorderMailboxTooltip.BorderRadius = 4;
			this.btnRecorderMailboxTooltip.BorderThickness = 1;
			this.btnRecorderMailboxTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnRecorderMailboxTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderMailboxTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderMailboxTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderMailboxTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderMailboxTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderMailboxTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderMailboxTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnRecorderMailboxTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnRecorderMailboxTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnRecorderMailboxTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnRecorderMailboxTooltip.Location = new global::System.Drawing.Point(619, 8);
			this.btnRecorderMailboxTooltip.Name = "btnRecorderMailboxTooltip";
			this.btnRecorderMailboxTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnRecorderMailboxTooltip.TabIndex = 94;
			this.btnRecorderMailboxTooltip.Click += new global::System.EventHandler(this.btnRecorderMailboxTooltip_Click);
			this.btnRecorderMailboxSendlist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecorderMailboxSendlist.BorderThickness = 1;
			this.btnRecorderMailboxSendlist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderMailboxSendlist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderMailboxSendlist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecorderMailboxSendlist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecorderMailboxSendlist.Enabled = false;
			this.btnRecorderMailboxSendlist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnRecorderMailboxSendlist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderMailboxSendlist.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderMailboxSendlist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecorderMailboxSendlist.Location = new global::System.Drawing.Point(317, 60);
			this.btnRecorderMailboxSendlist.Name = "btnRecorderMailboxSendlist";
			this.btnRecorderMailboxSendlist.Size = new global::System.Drawing.Size(114, 31);
			this.btnRecorderMailboxSendlist.TabIndex = 93;
			this.btnRecorderMailboxSendlist.Text = "Sendlist";
			this.btnRecorderMailboxSendlist.Click += new global::System.EventHandler(this.btnRecorderMailboxSendlist_Click);
			this.txtRecorderMailboxReceiver.BorderColor = global::System.Drawing.Color.Gray;
			this.txtRecorderMailboxReceiver.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtRecorderMailboxReceiver.DefaultText = "";
			this.txtRecorderMailboxReceiver.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtRecorderMailboxReceiver.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtRecorderMailboxReceiver.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtRecorderMailboxReceiver.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtRecorderMailboxReceiver.Enabled = false;
			this.txtRecorderMailboxReceiver.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtRecorderMailboxReceiver.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtRecorderMailboxReceiver.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtRecorderMailboxReceiver.ForeColor = global::System.Drawing.Color.White;
			this.txtRecorderMailboxReceiver.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtRecorderMailboxReceiver.Location = new global::System.Drawing.Point(180, 162);
			this.txtRecorderMailboxReceiver.MaxLength = 200;
			this.txtRecorderMailboxReceiver.Name = "txtRecorderMailboxReceiver";
			this.txtRecorderMailboxReceiver.PasswordChar = '\0';
			this.txtRecorderMailboxReceiver.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtRecorderMailboxReceiver.PlaceholderText = "";
			this.txtRecorderMailboxReceiver.SelectedText = "";
			this.txtRecorderMailboxReceiver.Size = new global::System.Drawing.Size(251, 30);
			this.txtRecorderMailboxReceiver.TabIndex = 92;
			this.checkRecorderMailboxSendPurples.Animated = true;
			this.checkRecorderMailboxSendPurples.AutoSize = true;
			this.checkRecorderMailboxSendPurples.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderMailboxSendPurples.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendPurples.CheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendPurples.CheckedState.BorderThickness = 0;
			this.checkRecorderMailboxSendPurples.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendPurples.Enabled = false;
			this.checkRecorderMailboxSendPurples.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkRecorderMailboxSendPurples.ForeColor = global::System.Drawing.Color.Fuchsia;
			this.checkRecorderMailboxSendPurples.Location = new global::System.Drawing.Point(180, 85);
			this.checkRecorderMailboxSendPurples.Name = "checkRecorderMailboxSendPurples";
			this.checkRecorderMailboxSendPurples.Size = new global::System.Drawing.Size(109, 19);
			this.checkRecorderMailboxSendPurples.TabIndex = 91;
			this.checkRecorderMailboxSendPurples.Text = "Send all Purples";
			this.checkRecorderMailboxSendPurples.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderMailboxSendPurples.UncheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendPurples.UncheckedState.BorderThickness = 1;
			this.checkRecorderMailboxSendPurples.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderMailboxSendPurples.UseVisualStyleBackColor = false;
			this.checkRecorderMailboxSendGreys.Animated = true;
			this.checkRecorderMailboxSendGreys.AutoSize = true;
			this.checkRecorderMailboxSendGreys.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderMailboxSendGreys.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendGreys.CheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendGreys.CheckedState.BorderThickness = 0;
			this.checkRecorderMailboxSendGreys.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendGreys.Enabled = false;
			this.checkRecorderMailboxSendGreys.ForeColor = global::System.Drawing.Color.DarkGray;
			this.checkRecorderMailboxSendGreys.Location = new global::System.Drawing.Point(25, 60);
			this.checkRecorderMailboxSendGreys.Name = "checkRecorderMailboxSendGreys";
			this.checkRecorderMailboxSendGreys.Size = new global::System.Drawing.Size(99, 19);
			this.checkRecorderMailboxSendGreys.TabIndex = 90;
			this.checkRecorderMailboxSendGreys.Text = "Send all Grays";
			this.checkRecorderMailboxSendGreys.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderMailboxSendGreys.UncheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendGreys.UncheckedState.BorderThickness = 1;
			this.checkRecorderMailboxSendGreys.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderMailboxSendGreys.UseVisualStyleBackColor = false;
			this.checkRecorderMailboxSendBlues.Animated = true;
			this.checkRecorderMailboxSendBlues.AutoSize = true;
			this.checkRecorderMailboxSendBlues.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderMailboxSendBlues.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendBlues.CheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendBlues.CheckedState.BorderThickness = 0;
			this.checkRecorderMailboxSendBlues.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendBlues.Enabled = false;
			this.checkRecorderMailboxSendBlues.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.checkRecorderMailboxSendBlues.Location = new global::System.Drawing.Point(180, 60);
			this.checkRecorderMailboxSendBlues.Name = "checkRecorderMailboxSendBlues";
			this.checkRecorderMailboxSendBlues.Size = new global::System.Drawing.Size(98, 19);
			this.checkRecorderMailboxSendBlues.TabIndex = 89;
			this.checkRecorderMailboxSendBlues.Text = "Send all Blues";
			this.checkRecorderMailboxSendBlues.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderMailboxSendBlues.UncheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendBlues.UncheckedState.BorderThickness = 1;
			this.checkRecorderMailboxSendBlues.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderMailboxSendBlues.UseVisualStyleBackColor = false;
			this.checkRecorderMailboxSendGreens.Animated = true;
			this.checkRecorderMailboxSendGreens.AutoSize = true;
			this.checkRecorderMailboxSendGreens.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderMailboxSendGreens.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendGreens.CheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendGreens.CheckedState.BorderThickness = 0;
			this.checkRecorderMailboxSendGreens.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendGreens.Enabled = false;
			this.checkRecorderMailboxSendGreens.ForeColor = global::System.Drawing.Color.Lime;
			this.checkRecorderMailboxSendGreens.Location = new global::System.Drawing.Point(25, 110);
			this.checkRecorderMailboxSendGreens.Name = "checkRecorderMailboxSendGreens";
			this.checkRecorderMailboxSendGreens.Size = new global::System.Drawing.Size(106, 19);
			this.checkRecorderMailboxSendGreens.TabIndex = 88;
			this.checkRecorderMailboxSendGreens.Text = "Send all Greens";
			this.checkRecorderMailboxSendGreens.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderMailboxSendGreens.UncheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendGreens.UncheckedState.BorderThickness = 1;
			this.checkRecorderMailboxSendGreens.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderMailboxSendGreens.UseVisualStyleBackColor = false;
			this.checkRecorderMailboxSendWhites.Animated = true;
			this.checkRecorderMailboxSendWhites.AutoSize = true;
			this.checkRecorderMailboxSendWhites.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderMailboxSendWhites.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendWhites.CheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendWhites.CheckedState.BorderThickness = 0;
			this.checkRecorderMailboxSendWhites.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderMailboxSendWhites.Enabled = false;
			this.checkRecorderMailboxSendWhites.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkRecorderMailboxSendWhites.Location = new global::System.Drawing.Point(25, 85);
			this.checkRecorderMailboxSendWhites.Name = "checkRecorderMailboxSendWhites";
			this.checkRecorderMailboxSendWhites.Size = new global::System.Drawing.Size(106, 19);
			this.checkRecorderMailboxSendWhites.TabIndex = 87;
			this.checkRecorderMailboxSendWhites.Text = "Send all Whites";
			this.checkRecorderMailboxSendWhites.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderMailboxSendWhites.UncheckedState.BorderRadius = 0;
			this.checkRecorderMailboxSendWhites.UncheckedState.BorderThickness = 1;
			this.checkRecorderMailboxSendWhites.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderMailboxSendWhites.UseVisualStyleBackColor = false;
			this.sepRecorderMailbox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepRecorderMailbox1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepRecorderMailbox1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepRecorderMailbox1.Location = new global::System.Drawing.Point(17, 138);
			this.sepRecorderMailbox1.Name = "sepRecorderMailbox1";
			this.sepRecorderMailbox1.Size = new global::System.Drawing.Size(616, 10);
			this.sepRecorderMailbox1.TabIndex = 71;
			this.lblRecorderMailboxReceiver.AutoSize = true;
			this.lblRecorderMailboxReceiver.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderMailboxReceiver.Enabled = false;
			this.lblRecorderMailboxReceiver.Location = new global::System.Drawing.Point(22, 168);
			this.lblRecorderMailboxReceiver.Name = "lblRecorderMailboxReceiver";
			this.lblRecorderMailboxReceiver.Size = new global::System.Drawing.Size(54, 15);
			this.lblRecorderMailboxReceiver.TabIndex = 70;
			this.lblRecorderMailboxReceiver.Text = "Receiver:";
			this.tableLayoutPanel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 60f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 40f));
			this.tableLayoutPanel2.Controls.Add(this.grpRecorderType, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.listWaypoints, 1, 0);
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(14, 14);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(666, 343);
			this.tableLayoutPanel2.TabIndex = 75;
			this.grpRecorderType.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpRecorderType.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpRecorderType.Controls.Add(this.panelRecorderInfo);
			this.grpRecorderType.Controls.Add(this.lblRecorder);
			this.grpRecorderType.Controls.Add(this.lblRecorderLandingField);
			this.grpRecorderType.Controls.Add(this.lblRecorderLandingFieldLocation);
			this.grpRecorderType.Controls.Add(this.guna2Separator5);
			this.grpRecorderType.Controls.Add(this.btnRecorderSetLandingField);
			this.grpRecorderType.Controls.Add(this.btnRecorderTypeTooltip);
			this.grpRecorderType.Controls.Add(this.btnWaypointDelete);
			this.grpRecorderType.Controls.Add(this.btnWaypointAddAfter);
			this.grpRecorderType.Controls.Add(this.btnRecorderSingle);
			this.grpRecorderType.Controls.Add(this.sepRecorder1);
			this.grpRecorderType.Controls.Add(this.btnRecordStart);
			this.grpRecorderType.Controls.Add(this.selectRecorderCombatMode);
			this.grpRecorderType.Controls.Add(this.lblRecorderCombatMode);
			this.grpRecorderType.Controls.Add(this.selectRecorderRouteType);
			this.grpRecorderType.Controls.Add(this.lblRecorderType);
			this.grpRecorderType.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpRecorderType.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpRecorderType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRecorderType.ForeColor = global::System.Drawing.Color.White;
			this.grpRecorderType.Location = new global::System.Drawing.Point(0, 0);
			this.grpRecorderType.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpRecorderType.Name = "grpRecorderType";
			this.grpRecorderType.Size = new global::System.Drawing.Size(390, 343);
			this.grpRecorderType.TabIndex = 65;
			this.grpRecorderType.Text = "Recorder";
			this.panelRecorderInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelRecorderInfo.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelRecorderInfo.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelRecorderInfo.BorderThickness = 1;
			this.panelRecorderInfo.Controls.Add(this.lblRecorderShow);
			this.panelRecorderInfo.Controls.Add(this.lblRecorderInfo);
			this.panelRecorderInfo.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelRecorderInfo.Location = new global::System.Drawing.Point(26, 260);
			this.panelRecorderInfo.Name = "panelRecorderInfo";
			this.panelRecorderInfo.Size = new global::System.Drawing.Size(339, 64);
			this.panelRecorderInfo.TabIndex = 88;
			this.lblRecorderShow.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRecorderShow.AutoEllipsis = true;
			this.lblRecorderShow.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderShow.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblRecorderShow.Font = new global::System.Drawing.Font("Segoe UI", 12f, global::System.Drawing.FontStyle.Underline);
			this.lblRecorderShow.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblRecorderShow.Location = new global::System.Drawing.Point(15, 30);
			this.lblRecorderShow.Name = "lblRecorderShow";
			this.lblRecorderShow.Size = new global::System.Drawing.Size(311, 21);
			this.lblRecorderShow.TabIndex = 88;
			this.lblRecorderShow.Text = "Show Recorder";
			this.lblRecorderShow.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRecorderShow.Click += new global::System.EventHandler(this.lblRecorderShow_Click);
			this.lblRecorderShow.MouseEnter += new global::System.EventHandler(this.lblRecorderShow_MouseEnter);
			this.lblRecorderShow.MouseLeave += new global::System.EventHandler(this.lblRecorderShow_MouseLeave);
			this.lblRecorderInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRecorderInfo.AutoEllipsis = true;
			this.lblRecorderInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderInfo.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblRecorderInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblRecorderInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorderInfo.Location = new global::System.Drawing.Point(11, 13);
			this.lblRecorderInfo.Name = "lblRecorderInfo";
			this.lblRecorderInfo.Size = new global::System.Drawing.Size(315, 15);
			this.lblRecorderInfo.TabIndex = 87;
			this.lblRecorderInfo.Text = "When should I use a custom route?";
			this.lblRecorderInfo.TextAlign = global::System.Drawing.ContentAlignment.TopCenter;
			this.lblRecorderInfo.Click += new global::System.EventHandler(this.lblRecorderInfo_Click);
			this.lblRecorderInfo.MouseEnter += new global::System.EventHandler(this.lblRecorderInfo_MouseEnter);
			this.lblRecorderInfo.MouseLeave += new global::System.EventHandler(this.lblRecorderInfo_MouseLeave);
			this.lblRecorder.AutoSize = true;
			this.lblRecorder.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorder.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorder.Location = new global::System.Drawing.Point(22, 271);
			this.lblRecorder.Name = "lblRecorder";
			this.lblRecorder.Size = new global::System.Drawing.Size(57, 15);
			this.lblRecorder.TabIndex = 87;
			this.lblRecorder.Text = "Recorder:";
			this.lblRecorderLandingField.AutoSize = true;
			this.lblRecorderLandingField.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderLandingField.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorderLandingField.Location = new global::System.Drawing.Point(22, 173);
			this.lblRecorderLandingField.Name = "lblRecorderLandingField";
			this.lblRecorderLandingField.Size = new global::System.Drawing.Size(81, 15);
			this.lblRecorderLandingField.TabIndex = 86;
			this.lblRecorderLandingField.Text = "Landing Field:";
			this.lblRecorderLandingFieldLocation.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRecorderLandingFieldLocation.AutoEllipsis = true;
			this.lblRecorderLandingFieldLocation.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderLandingFieldLocation.ForeColor = global::System.Drawing.Color.DimGray;
			this.lblRecorderLandingFieldLocation.Location = new global::System.Drawing.Point(180, 215);
			this.lblRecorderLandingFieldLocation.Name = "lblRecorderLandingFieldLocation";
			this.lblRecorderLandingFieldLocation.Size = new global::System.Drawing.Size(184, 15);
			this.lblRecorderLandingFieldLocation.TabIndex = 85;
			this.lblRecorderLandingFieldLocation.Text = "No Landing Field set.";
			this.lblRecorderLandingFieldLocation.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.guna2Separator5.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator5.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator5.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator5.Location = new global::System.Drawing.Point(22, 244);
			this.guna2Separator5.Name = "guna2Separator5";
			this.guna2Separator5.Size = new global::System.Drawing.Size(347, 10);
			this.guna2Separator5.TabIndex = 84;
			this.btnRecorderSetLandingField.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderSetLandingField.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecorderSetLandingField.BorderThickness = 1;
			this.btnRecorderSetLandingField.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderSetLandingField.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderSetLandingField.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecorderSetLandingField.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecorderSetLandingField.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnRecorderSetLandingField.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderSetLandingField.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderSetLandingField.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecorderSetLandingField.Location = new global::System.Drawing.Point(180, 173);
			this.btnRecorderSetLandingField.Name = "btnRecorderSetLandingField";
			this.btnRecorderSetLandingField.Size = new global::System.Drawing.Size(184, 31);
			this.btnRecorderSetLandingField.TabIndex = 83;
			this.btnRecorderSetLandingField.Text = "Set Landing Field";
			this.btnRecorderSetLandingField.Click += new global::System.EventHandler(this.btnRecordSetLandingField_Click);
			this.btnRecorderTypeTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderTypeTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderTypeTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnRecorderTypeTooltip.BorderRadius = 4;
			this.btnRecorderTypeTooltip.BorderThickness = 1;
			this.btnRecorderTypeTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnRecorderTypeTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderTypeTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderTypeTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderTypeTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderTypeTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderTypeTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderTypeTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnRecorderTypeTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnRecorderTypeTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnRecorderTypeTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnRecorderTypeTooltip.Location = new global::System.Drawing.Point(343, 8);
			this.btnRecorderTypeTooltip.Name = "btnRecorderTypeTooltip";
			this.btnRecorderTypeTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnRecorderTypeTooltip.TabIndex = 82;
			this.btnRecorderTypeTooltip.Click += new global::System.EventHandler(this.btnRecorderTypeTooltip_Click);
			this.btnWaypointDelete.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnWaypointDelete.BorderColor = global::System.Drawing.Color.Gray;
			this.btnWaypointDelete.BorderThickness = 1;
			this.btnWaypointDelete.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnWaypointDelete.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnWaypointDelete.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnWaypointDelete.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnWaypointDelete.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnWaypointDelete.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnWaypointDelete.ForeColor = global::System.Drawing.Color.White;
			this.btnWaypointDelete.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnWaypointDelete.Image = global::Jack.Properties.Resources.delete_32;
			this.btnWaypointDelete.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnWaypointDelete.ImageSize = new global::System.Drawing.Size(28, 28);
			this.btnWaypointDelete.Location = new global::System.Drawing.Point(258, 271);
			this.btnWaypointDelete.Name = "btnWaypointDelete";
			this.btnWaypointDelete.Size = new global::System.Drawing.Size(50, 50);
			this.btnWaypointDelete.TabIndex = 81;
			this.btnWaypointDelete.Click += new global::System.EventHandler(this.btnWaypointDelete_Click);
			this.btnWaypointAddAfter.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnWaypointAddAfter.BorderColor = global::System.Drawing.Color.Gray;
			this.btnWaypointAddAfter.BorderThickness = 1;
			this.btnWaypointAddAfter.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnWaypointAddAfter.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnWaypointAddAfter.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnWaypointAddAfter.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnWaypointAddAfter.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnWaypointAddAfter.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.btnWaypointAddAfter.ForeColor = global::System.Drawing.Color.White;
			this.btnWaypointAddAfter.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnWaypointAddAfter.Location = new global::System.Drawing.Point(149, 299);
			this.btnWaypointAddAfter.Name = "btnWaypointAddAfter";
			this.btnWaypointAddAfter.Size = new global::System.Drawing.Size(103, 22);
			this.btnWaypointAddAfter.TabIndex = 80;
			this.btnWaypointAddAfter.Text = "Add After";
			this.btnWaypointAddAfter.TextOffset = new global::System.Drawing.Point(0, -1);
			this.btnWaypointAddAfter.Click += new global::System.EventHandler(this.btnWaypointAddAfter_Click);
			this.btnRecorderSingle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderSingle.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecorderSingle.BorderThickness = 1;
			this.btnRecorderSingle.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderSingle.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderSingle.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecorderSingle.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecorderSingle.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnRecorderSingle.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.btnRecorderSingle.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderSingle.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecorderSingle.Location = new global::System.Drawing.Point(149, 271);
			this.btnRecorderSingle.Name = "btnRecorderSingle";
			this.btnRecorderSingle.Size = new global::System.Drawing.Size(103, 22);
			this.btnRecorderSingle.TabIndex = 79;
			this.btnRecorderSingle.Text = "Add Single";
			this.btnRecorderSingle.TextOffset = new global::System.Drawing.Point(0, -1);
			this.btnRecorderSingle.Click += new global::System.EventHandler(this.btnRecorderSingle_Click);
			this.sepRecorder1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepRecorder1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepRecorder1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepRecorder1.Location = new global::System.Drawing.Point(22, 145);
			this.sepRecorder1.Name = "sepRecorder1";
			this.sepRecorder1.Size = new global::System.Drawing.Size(347, 10);
			this.sepRecorder1.TabIndex = 78;
			this.btnRecordStart.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecordStart.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecordStart.BorderThickness = 1;
			this.btnRecordStart.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecordStart.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecordStart.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecordStart.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecordStart.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnRecordStart.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecordStart.ForeColor = global::System.Drawing.Color.White;
			this.btnRecordStart.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecordStart.Image = global::Jack.Properties.Resources.play_32;
			this.btnRecordStart.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnRecordStart.ImageSize = new global::System.Drawing.Size(28, 28);
			this.btnRecordStart.Location = new global::System.Drawing.Point(314, 271);
			this.btnRecordStart.Name = "btnRecordStart";
			this.btnRecordStart.Size = new global::System.Drawing.Size(50, 50);
			this.btnRecordStart.TabIndex = 73;
			this.btnRecordStart.Click += new global::System.EventHandler(this.btnRecordStart_Click);
			this.selectRecorderCombatMode.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectRecorderCombatMode.BackColor = global::System.Drawing.Color.Transparent;
			this.selectRecorderCombatMode.BorderColor = global::System.Drawing.Color.Gray;
			this.selectRecorderCombatMode.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectRecorderCombatMode.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectRecorderCombatMode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectRecorderCombatMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectRecorderCombatMode.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectRecorderCombatMode.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectRecorderCombatMode.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectRecorderCombatMode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectRecorderCombatMode.ForeColor = global::System.Drawing.Color.White;
			this.selectRecorderCombatMode.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectRecorderCombatMode.ItemHeight = 24;
			this.selectRecorderCombatMode.Items.AddRange(new object[]
			{
				"Defensive",
				"Offensive"
			});
			this.selectRecorderCombatMode.Location = new global::System.Drawing.Point(180, 99);
			this.selectRecorderCombatMode.Name = "selectRecorderCombatMode";
			this.selectRecorderCombatMode.Size = new global::System.Drawing.Size(184, 30);
			this.selectRecorderCombatMode.TabIndex = 72;
			this.lblRecorderCombatMode.AutoSize = true;
			this.lblRecorderCombatMode.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderCombatMode.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorderCombatMode.Location = new global::System.Drawing.Point(22, 106);
			this.lblRecorderCombatMode.Name = "lblRecorderCombatMode";
			this.lblRecorderCombatMode.Size = new global::System.Drawing.Size(87, 15);
			this.lblRecorderCombatMode.TabIndex = 71;
			this.lblRecorderCombatMode.Text = "Combat Mode:";
			this.selectRecorderRouteType.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectRecorderRouteType.BackColor = global::System.Drawing.Color.Transparent;
			this.selectRecorderRouteType.BorderColor = global::System.Drawing.Color.Gray;
			this.selectRecorderRouteType.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectRecorderRouteType.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectRecorderRouteType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectRecorderRouteType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectRecorderRouteType.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectRecorderRouteType.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectRecorderRouteType.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectRecorderRouteType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectRecorderRouteType.ForeColor = global::System.Drawing.Color.White;
			this.selectRecorderRouteType.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectRecorderRouteType.ItemHeight = 24;
			this.selectRecorderRouteType.Items.AddRange(new object[]
			{
				"Vendor",
				"Ghost (Path to Graveyard)",
				"Ghost (Graveyard to Path)",
				"Trainer",
				"Flight Master",
				"Set Hearthstone",
				"Mailbox"
			});
			this.selectRecorderRouteType.Location = new global::System.Drawing.Point(180, 60);
			this.selectRecorderRouteType.Name = "selectRecorderRouteType";
			this.selectRecorderRouteType.Size = new global::System.Drawing.Size(184, 30);
			this.selectRecorderRouteType.TabIndex = 70;
			this.selectRecorderRouteType.SelectedIndexChanged += new global::System.EventHandler(this.selectRecorderRouteType_SelectedIndexChanged);
			this.lblRecorderType.AutoSize = true;
			this.lblRecorderType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderType.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorderType.Location = new global::System.Drawing.Point(22, 67);
			this.lblRecorderType.Name = "lblRecorderType";
			this.lblRecorderType.Size = new global::System.Drawing.Size(61, 15);
			this.lblRecorderType.TabIndex = 14;
			this.lblRecorderType.Text = "Path Type:";
			this.listWaypoints.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listWaypoints.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listWaypoints.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listWaypointsCount,
				this.listWaypointsWaypoint
			});
			this.listWaypoints.ForeColor = global::System.Drawing.Color.White;
			this.listWaypoints.FullRowSelect = true;
			this.listWaypoints.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listWaypoints.HideSelection = false;
			this.listWaypoints.Location = new global::System.Drawing.Point(408, 0);
			this.listWaypoints.Margin = new global::System.Windows.Forms.Padding(9, 0, 0, 0);
			this.listWaypoints.Name = "listWaypoints";
			this.listWaypoints.OwnerDraw = true;
			this.listWaypoints.Size = new global::System.Drawing.Size(258, 343);
			this.listWaypoints.TabIndex = 74;
			this.listWaypoints.UseCompatibleStateImageBehavior = false;
			this.listWaypoints.View = global::System.Windows.Forms.View.Details;
			this.listWaypoints.SelectedIndexChanged += new global::System.EventHandler(this.listWaypoints_SelectedIndexChanged);
			this.listWaypoints.Resize += new global::System.EventHandler(this.listWaypoints_Resize);
			this.listWaypointsCount.Text = "#";
			this.listWaypointsCount.Width = 40;
			this.listWaypointsWaypoint.Text = "Waypoint";
			this.listWaypointsWaypoint.Width = 200;
			this.grpRecorderFlightMaster.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpRecorderFlightMaster.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpRecorderFlightMaster.Controls.Add(this.btnRecorderFlightMasterTooltip);
			this.grpRecorderFlightMaster.Controls.Add(this.selectRecorderFlightMasterProfiles);
			this.grpRecorderFlightMaster.Controls.Add(this.selectRecorderFlightMasterFlightPoints);
			this.grpRecorderFlightMaster.Controls.Add(this.lblRecorderFlightMasterProfiles);
			this.grpRecorderFlightMaster.Controls.Add(this.lblRecorderFlightMasterFlightPoints);
			this.grpRecorderFlightMaster.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpRecorderFlightMaster.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpRecorderFlightMaster.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRecorderFlightMaster.ForeColor = global::System.Drawing.Color.White;
			this.grpRecorderFlightMaster.Location = new global::System.Drawing.Point(14, 556);
			this.grpRecorderFlightMaster.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpRecorderFlightMaster.Name = "grpRecorderFlightMaster";
			this.grpRecorderFlightMaster.Size = new global::System.Drawing.Size(666, 143);
			this.grpRecorderFlightMaster.TabIndex = 77;
			this.grpRecorderFlightMaster.Text = "Flight Master";
			this.btnRecorderFlightMasterTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderFlightMasterTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderFlightMasterTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnRecorderFlightMasterTooltip.BorderRadius = 4;
			this.btnRecorderFlightMasterTooltip.BorderThickness = 1;
			this.btnRecorderFlightMasterTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnRecorderFlightMasterTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderFlightMasterTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderFlightMasterTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderFlightMasterTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderFlightMasterTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderFlightMasterTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderFlightMasterTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnRecorderFlightMasterTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnRecorderFlightMasterTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnRecorderFlightMasterTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnRecorderFlightMasterTooltip.Location = new global::System.Drawing.Point(619, 8);
			this.btnRecorderFlightMasterTooltip.Name = "btnRecorderFlightMasterTooltip";
			this.btnRecorderFlightMasterTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnRecorderFlightMasterTooltip.TabIndex = 83;
			this.btnRecorderFlightMasterTooltip.Click += new global::System.EventHandler(this.btnRecorderFlightMasterTooltip_Click);
			this.selectRecorderFlightMasterProfiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectRecorderFlightMasterProfiles.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectRecorderFlightMasterProfiles.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectRecorderFlightMasterProfiles.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectRecorderFlightMasterProfiles.Enabled = false;
			this.selectRecorderFlightMasterProfiles.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectRecorderFlightMasterProfiles.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectRecorderFlightMasterProfiles.ForeColor = global::System.Drawing.Color.White;
			this.selectRecorderFlightMasterProfiles.FormattingEnabled = true;
			this.selectRecorderFlightMasterProfiles.Location = new global::System.Drawing.Point(180, 95);
			this.selectRecorderFlightMasterProfiles.Name = "selectRecorderFlightMasterProfiles";
			this.selectRecorderFlightMasterProfiles.Size = new global::System.Drawing.Size(461, 29);
			this.selectRecorderFlightMasterProfiles.TabIndex = 76;
			this.selectRecorderFlightMasterFlightPoints.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectRecorderFlightMasterFlightPoints.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectRecorderFlightMasterFlightPoints.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectRecorderFlightMasterFlightPoints.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectRecorderFlightMasterFlightPoints.Enabled = false;
			this.selectRecorderFlightMasterFlightPoints.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectRecorderFlightMasterFlightPoints.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectRecorderFlightMasterFlightPoints.ForeColor = global::System.Drawing.Color.White;
			this.selectRecorderFlightMasterFlightPoints.FormattingEnabled = true;
			this.selectRecorderFlightMasterFlightPoints.Location = new global::System.Drawing.Point(180, 60);
			this.selectRecorderFlightMasterFlightPoints.Name = "selectRecorderFlightMasterFlightPoints";
			this.selectRecorderFlightMasterFlightPoints.Size = new global::System.Drawing.Size(461, 29);
			this.selectRecorderFlightMasterFlightPoints.TabIndex = 75;
			this.lblRecorderFlightMasterProfiles.AutoSize = true;
			this.lblRecorderFlightMasterProfiles.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderFlightMasterProfiles.Enabled = false;
			this.lblRecorderFlightMasterProfiles.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorderFlightMasterProfiles.Location = new global::System.Drawing.Point(22, 103);
			this.lblRecorderFlightMasterProfiles.Name = "lblRecorderFlightMasterProfiles";
			this.lblRecorderFlightMasterProfiles.Size = new global::System.Drawing.Size(131, 15);
			this.lblRecorderFlightMasterProfiles.TabIndex = 73;
			this.lblRecorderFlightMasterProfiles.Text = "Load Profile after flight:";
			this.lblRecorderFlightMasterFlightPoints.AutoSize = true;
			this.lblRecorderFlightMasterFlightPoints.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderFlightMasterFlightPoints.Enabled = false;
			this.lblRecorderFlightMasterFlightPoints.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorderFlightMasterFlightPoints.Location = new global::System.Drawing.Point(22, 67);
			this.lblRecorderFlightMasterFlightPoints.Name = "lblRecorderFlightMasterFlightPoints";
			this.lblRecorderFlightMasterFlightPoints.Size = new global::System.Drawing.Size(70, 15);
			this.lblRecorderFlightMasterFlightPoints.TabIndex = 71;
			this.lblRecorderFlightMasterFlightPoints.Text = "Destination:";
			this.grpRecorderVendor.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpRecorderVendor.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpRecorderVendor.Controls.Add(this.lblRecorderVendorMountKeybind);
			this.grpRecorderVendor.Controls.Add(this.checkRecorderVendorMount);
			this.grpRecorderVendor.Controls.Add(this.btnRecorderVendorTooltip);
			this.grpRecorderVendor.Controls.Add(this.btnRecorderVendorBuylist);
			this.grpRecorderVendor.Controls.Add(this.btnRecorderVendorWhitelist);
			this.grpRecorderVendor.Controls.Add(this.checkRecorderVendorCanRepair);
			this.grpRecorderVendor.Controls.Add(this.checkRecorderVendorSellGreys);
			this.grpRecorderVendor.Controls.Add(this.checkRecorderVendorSellBlues);
			this.grpRecorderVendor.Controls.Add(this.checkRecorderVendorSellGreens);
			this.grpRecorderVendor.Controls.Add(this.checkRecorderVendorSellWhites);
			this.grpRecorderVendor.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpRecorderVendor.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpRecorderVendor.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRecorderVendor.ForeColor = global::System.Drawing.Color.White;
			this.grpRecorderVendor.Location = new global::System.Drawing.Point(14, 371);
			this.grpRecorderVendor.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpRecorderVendor.Name = "grpRecorderVendor";
			this.grpRecorderVendor.Size = new global::System.Drawing.Size(666, 171);
			this.grpRecorderVendor.TabIndex = 76;
			this.grpRecorderVendor.Text = "Vendor";
			this.lblRecorderVendorMountKeybind.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRecorderVendorMountKeybind.AutoEllipsis = true;
			this.lblRecorderVendorMountKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRecorderVendorMountKeybind.Enabled = false;
			this.lblRecorderVendorMountKeybind.ForeColor = global::System.Drawing.Color.White;
			this.lblRecorderVendorMountKeybind.Location = new global::System.Drawing.Point(518, 83);
			this.lblRecorderVendorMountKeybind.Name = "lblRecorderVendorMountKeybind";
			this.lblRecorderVendorMountKeybind.Size = new global::System.Drawing.Size(123, 15);
			this.lblRecorderVendorMountKeybind.TabIndex = 99;
			this.lblRecorderVendorMountKeybind.Text = "[KEYBIND]";
			this.checkRecorderVendorMount.Animated = true;
			this.checkRecorderVendorMount.AutoSize = true;
			this.checkRecorderVendorMount.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderVendorMount.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorMount.CheckedState.BorderRadius = 0;
			this.checkRecorderVendorMount.CheckedState.BorderThickness = 0;
			this.checkRecorderVendorMount.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorMount.Enabled = false;
			this.checkRecorderVendorMount.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkRecorderVendorMount.Location = new global::System.Drawing.Point(501, 60);
			this.checkRecorderVendorMount.Name = "checkRecorderVendorMount";
			this.checkRecorderVendorMount.Size = new global::System.Drawing.Size(124, 19);
			this.checkRecorderVendorMount.TabIndex = 87;
			this.checkRecorderVendorMount.Text = "Use Vendor Mount";
			this.checkRecorderVendorMount.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderVendorMount.UncheckedState.BorderRadius = 0;
			this.checkRecorderVendorMount.UncheckedState.BorderThickness = 1;
			this.checkRecorderVendorMount.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderVendorMount.UseVisualStyleBackColor = false;
			this.checkRecorderVendorMount.CheckedChanged += new global::System.EventHandler(this.checkRecorderVendorMount_CheckedChanged);
			this.btnRecorderVendorTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderVendorTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderVendorTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnRecorderVendorTooltip.BorderRadius = 4;
			this.btnRecorderVendorTooltip.BorderThickness = 1;
			this.btnRecorderVendorTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnRecorderVendorTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderVendorTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderVendorTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderVendorTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderVendorTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderVendorTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderVendorTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnRecorderVendorTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnRecorderVendorTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnRecorderVendorTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnRecorderVendorTooltip.Location = new global::System.Drawing.Point(619, 8);
			this.btnRecorderVendorTooltip.Name = "btnRecorderVendorTooltip";
			this.btnRecorderVendorTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnRecorderVendorTooltip.TabIndex = 89;
			this.btnRecorderVendorTooltip.Click += new global::System.EventHandler(this.btnRecorderVendorTooltip_Click);
			this.btnRecorderVendorBuylist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecorderVendorBuylist.BorderThickness = 1;
			this.btnRecorderVendorBuylist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderVendorBuylist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderVendorBuylist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecorderVendorBuylist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecorderVendorBuylist.Enabled = false;
			this.btnRecorderVendorBuylist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnRecorderVendorBuylist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderVendorBuylist.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderVendorBuylist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecorderVendorBuylist.Location = new global::System.Drawing.Point(317, 98);
			this.btnRecorderVendorBuylist.Name = "btnRecorderVendorBuylist";
			this.btnRecorderVendorBuylist.Size = new global::System.Drawing.Size(114, 31);
			this.btnRecorderVendorBuylist.TabIndex = 88;
			this.btnRecorderVendorBuylist.Text = "Buylist";
			this.btnRecorderVendorBuylist.Click += new global::System.EventHandler(this.btnRecorderVendorBuylist_Click);
			this.btnRecorderVendorWhitelist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecorderVendorWhitelist.BorderThickness = 1;
			this.btnRecorderVendorWhitelist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderVendorWhitelist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderVendorWhitelist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecorderVendorWhitelist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecorderVendorWhitelist.Enabled = false;
			this.btnRecorderVendorWhitelist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnRecorderVendorWhitelist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderVendorWhitelist.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderVendorWhitelist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecorderVendorWhitelist.Location = new global::System.Drawing.Point(317, 60);
			this.btnRecorderVendorWhitelist.Name = "btnRecorderVendorWhitelist";
			this.btnRecorderVendorWhitelist.Size = new global::System.Drawing.Size(114, 31);
			this.btnRecorderVendorWhitelist.TabIndex = 87;
			this.btnRecorderVendorWhitelist.Text = "Whitelist";
			this.btnRecorderVendorWhitelist.Click += new global::System.EventHandler(this.btnRecorderVendorWhitelist_Click);
			this.checkRecorderVendorCanRepair.Animated = true;
			this.checkRecorderVendorCanRepair.AutoSize = true;
			this.checkRecorderVendorCanRepair.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderVendorCanRepair.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorCanRepair.CheckedState.BorderRadius = 0;
			this.checkRecorderVendorCanRepair.CheckedState.BorderThickness = 0;
			this.checkRecorderVendorCanRepair.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorCanRepair.Enabled = false;
			this.checkRecorderVendorCanRepair.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkRecorderVendorCanRepair.Location = new global::System.Drawing.Point(180, 60);
			this.checkRecorderVendorCanRepair.Name = "checkRecorderVendorCanRepair";
			this.checkRecorderVendorCanRepair.Size = new global::System.Drawing.Size(83, 19);
			this.checkRecorderVendorCanRepair.TabIndex = 86;
			this.checkRecorderVendorCanRepair.Text = "Can Repair";
			this.checkRecorderVendorCanRepair.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderVendorCanRepair.UncheckedState.BorderRadius = 0;
			this.checkRecorderVendorCanRepair.UncheckedState.BorderThickness = 1;
			this.checkRecorderVendorCanRepair.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderVendorCanRepair.UseVisualStyleBackColor = false;
			this.checkRecorderVendorSellGreys.Animated = true;
			this.checkRecorderVendorSellGreys.AutoSize = true;
			this.checkRecorderVendorSellGreys.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderVendorSellGreys.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellGreys.CheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellGreys.CheckedState.BorderThickness = 0;
			this.checkRecorderVendorSellGreys.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellGreys.Enabled = false;
			this.checkRecorderVendorSellGreys.ForeColor = global::System.Drawing.Color.DarkGray;
			this.checkRecorderVendorSellGreys.Location = new global::System.Drawing.Point(25, 60);
			this.checkRecorderVendorSellGreys.Name = "checkRecorderVendorSellGreys";
			this.checkRecorderVendorSellGreys.Size = new global::System.Drawing.Size(91, 19);
			this.checkRecorderVendorSellGreys.TabIndex = 85;
			this.checkRecorderVendorSellGreys.Text = "Sell all Grays";
			this.checkRecorderVendorSellGreys.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderVendorSellGreys.UncheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellGreys.UncheckedState.BorderThickness = 1;
			this.checkRecorderVendorSellGreys.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderVendorSellGreys.UseVisualStyleBackColor = false;
			this.checkRecorderVendorSellBlues.Animated = true;
			this.checkRecorderVendorSellBlues.AutoSize = true;
			this.checkRecorderVendorSellBlues.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderVendorSellBlues.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellBlues.CheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellBlues.CheckedState.BorderThickness = 0;
			this.checkRecorderVendorSellBlues.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellBlues.Enabled = false;
			this.checkRecorderVendorSellBlues.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.checkRecorderVendorSellBlues.Location = new global::System.Drawing.Point(25, 135);
			this.checkRecorderVendorSellBlues.Name = "checkRecorderVendorSellBlues";
			this.checkRecorderVendorSellBlues.Size = new global::System.Drawing.Size(90, 19);
			this.checkRecorderVendorSellBlues.TabIndex = 84;
			this.checkRecorderVendorSellBlues.Text = "Sell all Blues";
			this.checkRecorderVendorSellBlues.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderVendorSellBlues.UncheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellBlues.UncheckedState.BorderThickness = 1;
			this.checkRecorderVendorSellBlues.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderVendorSellBlues.UseVisualStyleBackColor = false;
			this.checkRecorderVendorSellGreens.Animated = true;
			this.checkRecorderVendorSellGreens.AutoSize = true;
			this.checkRecorderVendorSellGreens.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderVendorSellGreens.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellGreens.CheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellGreens.CheckedState.BorderThickness = 0;
			this.checkRecorderVendorSellGreens.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellGreens.Enabled = false;
			this.checkRecorderVendorSellGreens.ForeColor = global::System.Drawing.Color.Lime;
			this.checkRecorderVendorSellGreens.Location = new global::System.Drawing.Point(25, 110);
			this.checkRecorderVendorSellGreens.Name = "checkRecorderVendorSellGreens";
			this.checkRecorderVendorSellGreens.Size = new global::System.Drawing.Size(98, 19);
			this.checkRecorderVendorSellGreens.TabIndex = 83;
			this.checkRecorderVendorSellGreens.Text = "Sell all Greens";
			this.checkRecorderVendorSellGreens.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderVendorSellGreens.UncheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellGreens.UncheckedState.BorderThickness = 1;
			this.checkRecorderVendorSellGreens.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderVendorSellGreens.UseVisualStyleBackColor = false;
			this.checkRecorderVendorSellWhites.Animated = true;
			this.checkRecorderVendorSellWhites.AutoSize = true;
			this.checkRecorderVendorSellWhites.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderVendorSellWhites.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellWhites.CheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellWhites.CheckedState.BorderThickness = 0;
			this.checkRecorderVendorSellWhites.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderVendorSellWhites.Enabled = false;
			this.checkRecorderVendorSellWhites.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkRecorderVendorSellWhites.Location = new global::System.Drawing.Point(25, 85);
			this.checkRecorderVendorSellWhites.Name = "checkRecorderVendorSellWhites";
			this.checkRecorderVendorSellWhites.Size = new global::System.Drawing.Size(98, 19);
			this.checkRecorderVendorSellWhites.TabIndex = 82;
			this.checkRecorderVendorSellWhites.Text = "Sell all Whites";
			this.checkRecorderVendorSellWhites.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderVendorSellWhites.UncheckedState.BorderRadius = 0;
			this.checkRecorderVendorSellWhites.UncheckedState.BorderThickness = 1;
			this.checkRecorderVendorSellWhites.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderVendorSellWhites.UseVisualStyleBackColor = false;
			this.tabCastSpell.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabCastSpell.Controls.Add(this.panelTabCastSpell);
			this.tabCastSpell.ForeColor = global::System.Drawing.Color.White;
			this.tabCastSpell.Location = new global::System.Drawing.Point(4, 124);
			this.tabCastSpell.Name = "tabCastSpell";
			this.tabCastSpell.Size = new global::System.Drawing.Size(763, 432);
			this.tabCastSpell.TabIndex = 4;
			this.tabCastSpell.Text = "Cast Spell";
			this.panelTabCastSpell.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabCastSpell.AutoScroll = true;
			this.panelTabCastSpell.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabCastSpell.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabCastSpell.Controls.Add(this.grpCastSpellTarget);
			this.panelTabCastSpell.Controls.Add(this.grpCastSpell);
			this.panelTabCastSpell.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabCastSpell.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabCastSpell.Name = "panelTabCastSpell";
			this.panelTabCastSpell.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabCastSpell.TabIndex = 66;
			this.grpCastSpellTarget.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpCastSpellTarget.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpCastSpellTarget.Controls.Add(this.checkCastSpellTarget);
			this.grpCastSpellTarget.Controls.Add(this.checkCastSpellTargetFurthest);
			this.grpCastSpellTarget.Controls.Add(this.txtCastSpellTargetNameOrID);
			this.grpCastSpellTarget.Controls.Add(this.checkCastSpellTargetClosest);
			this.grpCastSpellTarget.Controls.Add(this.lblCastSpellTargetNameOrID);
			this.grpCastSpellTarget.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpCastSpellTarget.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpCastSpellTarget.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpCastSpellTarget.ForeColor = global::System.Drawing.Color.White;
			this.grpCastSpellTarget.Location = new global::System.Drawing.Point(14, 365);
			this.grpCastSpellTarget.Name = "grpCastSpellTarget";
			this.grpCastSpellTarget.Size = new global::System.Drawing.Size(632, 140);
			this.grpCastSpellTarget.TabIndex = 65;
			this.checkCastSpellTarget.Animated = true;
			this.checkCastSpellTarget.AutoSize = true;
			this.checkCastSpellTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCastSpellTarget.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellTarget.CheckedState.BorderRadius = 0;
			this.checkCastSpellTarget.CheckedState.BorderThickness = 0;
			this.checkCastSpellTarget.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellTarget.Location = new global::System.Drawing.Point(12, 11);
			this.checkCastSpellTarget.Name = "checkCastSpellTarget";
			this.checkCastSpellTarget.Size = new global::System.Drawing.Size(151, 19);
			this.checkCastSpellTarget.TabIndex = 95;
			this.checkCastSpellTarget.Text = "Cast on specified Target";
			this.checkCastSpellTarget.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkCastSpellTarget.UncheckedState.BorderRadius = 0;
			this.checkCastSpellTarget.UncheckedState.BorderThickness = 1;
			this.checkCastSpellTarget.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkCastSpellTarget.UseVisualStyleBackColor = false;
			this.checkCastSpellTarget.CheckedChanged += new global::System.EventHandler(this.checkCastSpellTarget_CheckedChanged);
			this.checkCastSpellTargetFurthest.Animated = true;
			this.checkCastSpellTargetFurthest.AutoSize = true;
			this.checkCastSpellTargetFurthest.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCastSpellTargetFurthest.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellTargetFurthest.CheckedState.BorderRadius = 0;
			this.checkCastSpellTargetFurthest.CheckedState.BorderThickness = 0;
			this.checkCastSpellTargetFurthest.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellTargetFurthest.Enabled = false;
			this.checkCastSpellTargetFurthest.Location = new global::System.Drawing.Point(259, 105);
			this.checkCastSpellTargetFurthest.Name = "checkCastSpellTargetFurthest";
			this.checkCastSpellTargetFurthest.Size = new global::System.Drawing.Size(69, 19);
			this.checkCastSpellTargetFurthest.TabIndex = 94;
			this.checkCastSpellTargetFurthest.Text = "Furthest";
			this.checkCastSpellTargetFurthest.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkCastSpellTargetFurthest.UncheckedState.BorderRadius = 0;
			this.checkCastSpellTargetFurthest.UncheckedState.BorderThickness = 1;
			this.checkCastSpellTargetFurthest.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkCastSpellTargetFurthest.UseVisualStyleBackColor = false;
			this.checkCastSpellTargetFurthest.CheckedChanged += new global::System.EventHandler(this.checkCastSpellTargetFurthest_CheckedChanged);
			this.txtCastSpellTargetNameOrID.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCastSpellTargetNameOrID.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCastSpellTargetNameOrID.DefaultText = "";
			this.txtCastSpellTargetNameOrID.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCastSpellTargetNameOrID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtCastSpellTargetNameOrID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCastSpellTargetNameOrID.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCastSpellTargetNameOrID.Enabled = false;
			this.txtCastSpellTargetNameOrID.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtCastSpellTargetNameOrID.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtCastSpellTargetNameOrID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCastSpellTargetNameOrID.ForeColor = global::System.Drawing.Color.White;
			this.txtCastSpellTargetNameOrID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtCastSpellTargetNameOrID.Location = new global::System.Drawing.Point(180, 60);
			this.txtCastSpellTargetNameOrID.MaxLength = 200;
			this.txtCastSpellTargetNameOrID.Name = "txtCastSpellTargetNameOrID";
			this.txtCastSpellTargetNameOrID.PasswordChar = '\0';
			this.txtCastSpellTargetNameOrID.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtCastSpellTargetNameOrID.PlaceholderText = "";
			this.txtCastSpellTargetNameOrID.SelectedText = "";
			this.txtCastSpellTargetNameOrID.Size = new global::System.Drawing.Size(225, 30);
			this.txtCastSpellTargetNameOrID.TabIndex = 93;
			this.checkCastSpellTargetClosest.Animated = true;
			this.checkCastSpellTargetClosest.AutoSize = true;
			this.checkCastSpellTargetClosest.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCastSpellTargetClosest.Checked = true;
			this.checkCastSpellTargetClosest.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellTargetClosest.CheckedState.BorderRadius = 0;
			this.checkCastSpellTargetClosest.CheckedState.BorderThickness = 0;
			this.checkCastSpellTargetClosest.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellTargetClosest.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkCastSpellTargetClosest.Enabled = false;
			this.checkCastSpellTargetClosest.Location = new global::System.Drawing.Point(180, 105);
			this.checkCastSpellTargetClosest.Name = "checkCastSpellTargetClosest";
			this.checkCastSpellTargetClosest.Size = new global::System.Drawing.Size(64, 19);
			this.checkCastSpellTargetClosest.TabIndex = 71;
			this.checkCastSpellTargetClosest.Text = "Closest";
			this.checkCastSpellTargetClosest.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkCastSpellTargetClosest.UncheckedState.BorderRadius = 0;
			this.checkCastSpellTargetClosest.UncheckedState.BorderThickness = 1;
			this.checkCastSpellTargetClosest.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkCastSpellTargetClosest.UseVisualStyleBackColor = false;
			this.checkCastSpellTargetClosest.CheckedChanged += new global::System.EventHandler(this.checkCastSpellTargetClosest_CheckedChanged);
			this.lblCastSpellTargetNameOrID.AutoSize = true;
			this.lblCastSpellTargetNameOrID.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCastSpellTargetNameOrID.Enabled = false;
			this.lblCastSpellTargetNameOrID.Location = new global::System.Drawing.Point(22, 66);
			this.lblCastSpellTargetNameOrID.Name = "lblCastSpellTargetNameOrID";
			this.lblCastSpellTargetNameOrID.Size = new global::System.Drawing.Size(70, 15);
			this.lblCastSpellTargetNameOrID.TabIndex = 68;
			this.lblCastSpellTargetNameOrID.Text = "ID or Name:";
			this.grpCastSpell.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpCastSpell.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpCastSpell.Controls.Add(this.btnCastSpellTooltip);
			this.grpCastSpell.Controls.Add(this.selectCastSpell);
			this.grpCastSpell.Controls.Add(this.checkCastSpellGroundAOE);
			this.grpCastSpell.Controls.Add(this.checkCastSpellUntilNoAttackers);
			this.grpCastSpell.Controls.Add(this.checkCastSpellWhileWalk);
			this.grpCastSpell.Controls.Add(this.guna2Separator2);
			this.grpCastSpell.Controls.Add(this.lblCastSpellRadiusInfo);
			this.grpCastSpell.Controls.Add(this.checkCastSpellNoRadiusCheck);
			this.grpCastSpell.Controls.Add(this.txtCastSpellRadius);
			this.grpCastSpell.Controls.Add(this.lblCastSpellRadius);
			this.grpCastSpell.Controls.Add(this.guna2Separator1);
			this.grpCastSpell.Controls.Add(this.btnCastSpellReload);
			this.grpCastSpell.Controls.Add(this.lblCastSpell);
			this.grpCastSpell.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpCastSpell.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpCastSpell.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpCastSpell.ForeColor = global::System.Drawing.Color.White;
			this.grpCastSpell.Location = new global::System.Drawing.Point(14, 14);
			this.grpCastSpell.Name = "grpCastSpell";
			this.grpCastSpell.Size = new global::System.Drawing.Size(632, 336);
			this.grpCastSpell.TabIndex = 64;
			this.grpCastSpell.Text = "Cast Spell";
			this.btnCastSpellTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCastSpellTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnCastSpellTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnCastSpellTooltip.BorderRadius = 4;
			this.btnCastSpellTooltip.BorderThickness = 1;
			this.btnCastSpellTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnCastSpellTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnCastSpellTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnCastSpellTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnCastSpellTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnCastSpellTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnCastSpellTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnCastSpellTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnCastSpellTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnCastSpellTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnCastSpellTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnCastSpellTooltip.Location = new global::System.Drawing.Point(585, 8);
			this.btnCastSpellTooltip.Name = "btnCastSpellTooltip";
			this.btnCastSpellTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnCastSpellTooltip.TabIndex = 102;
			this.btnCastSpellTooltip.Click += new global::System.EventHandler(this.btnCastSpellTooltip_Click);
			this.selectCastSpell.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectCastSpell.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectCastSpell.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectCastSpell.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectCastSpell.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectCastSpell.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectCastSpell.ForeColor = global::System.Drawing.Color.White;
			this.selectCastSpell.FormattingEnabled = true;
			this.selectCastSpell.Location = new global::System.Drawing.Point(180, 60);
			this.selectCastSpell.Name = "selectCastSpell";
			this.selectCastSpell.Size = new global::System.Drawing.Size(302, 29);
			this.selectCastSpell.TabIndex = 101;
			this.checkCastSpellGroundAOE.Animated = true;
			this.checkCastSpellGroundAOE.AutoSize = true;
			this.checkCastSpellGroundAOE.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCastSpellGroundAOE.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellGroundAOE.CheckedState.BorderRadius = 0;
			this.checkCastSpellGroundAOE.CheckedState.BorderThickness = 0;
			this.checkCastSpellGroundAOE.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellGroundAOE.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkCastSpellGroundAOE.Location = new global::System.Drawing.Point(180, 298);
			this.checkCastSpellGroundAOE.Name = "checkCastSpellGroundAOE";
			this.checkCastSpellGroundAOE.Size = new global::System.Drawing.Size(216, 19);
			this.checkCastSpellGroundAOE.TabIndex = 100;
			this.checkCastSpellGroundAOE.Text = "Is \"Ground AOE\" (Blizzard, Volley, ...)";
			this.checkCastSpellGroundAOE.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkCastSpellGroundAOE.UncheckedState.BorderRadius = 0;
			this.checkCastSpellGroundAOE.UncheckedState.BorderThickness = 1;
			this.checkCastSpellGroundAOE.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkCastSpellGroundAOE.UseVisualStyleBackColor = false;
			this.checkCastSpellUntilNoAttackers.Animated = true;
			this.checkCastSpellUntilNoAttackers.AutoSize = true;
			this.checkCastSpellUntilNoAttackers.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCastSpellUntilNoAttackers.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellUntilNoAttackers.CheckedState.BorderRadius = 0;
			this.checkCastSpellUntilNoAttackers.CheckedState.BorderThickness = 0;
			this.checkCastSpellUntilNoAttackers.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellUntilNoAttackers.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkCastSpellUntilNoAttackers.Location = new global::System.Drawing.Point(180, 273);
			this.checkCastSpellUntilNoAttackers.Name = "checkCastSpellUntilNoAttackers";
			this.checkCastSpellUntilNoAttackers.Size = new global::System.Drawing.Size(189, 19);
			this.checkCastSpellUntilNoAttackers.TabIndex = 99;
			this.checkCastSpellUntilNoAttackers.Text = "Cast until all attackers are dead";
			this.checkCastSpellUntilNoAttackers.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkCastSpellUntilNoAttackers.UncheckedState.BorderRadius = 0;
			this.checkCastSpellUntilNoAttackers.UncheckedState.BorderThickness = 1;
			this.checkCastSpellUntilNoAttackers.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkCastSpellUntilNoAttackers.UseVisualStyleBackColor = false;
			this.checkCastSpellWhileWalk.Animated = true;
			this.checkCastSpellWhileWalk.AutoSize = true;
			this.checkCastSpellWhileWalk.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCastSpellWhileWalk.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellWhileWalk.CheckedState.BorderRadius = 0;
			this.checkCastSpellWhileWalk.CheckedState.BorderThickness = 0;
			this.checkCastSpellWhileWalk.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellWhileWalk.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkCastSpellWhileWalk.Location = new global::System.Drawing.Point(180, 248);
			this.checkCastSpellWhileWalk.Name = "checkCastSpellWhileWalk";
			this.checkCastSpellWhileWalk.Size = new global::System.Drawing.Size(129, 19);
			this.checkCastSpellWhileWalk.TabIndex = 98;
			this.checkCastSpellWhileWalk.Text = "Can cast while walk";
			this.checkCastSpellWhileWalk.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkCastSpellWhileWalk.UncheckedState.BorderRadius = 0;
			this.checkCastSpellWhileWalk.UncheckedState.BorderThickness = 1;
			this.checkCastSpellWhileWalk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkCastSpellWhileWalk.UseVisualStyleBackColor = false;
			this.guna2Separator2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator2.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator2.Location = new global::System.Drawing.Point(17, 217);
			this.guna2Separator2.Name = "guna2Separator2";
			this.guna2Separator2.Size = new global::System.Drawing.Size(582, 10);
			this.guna2Separator2.TabIndex = 97;
			this.lblCastSpellRadiusInfo.AutoSize = true;
			this.lblCastSpellRadiusInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCastSpellRadiusInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblCastSpellRadiusInfo.Location = new global::System.Drawing.Point(177, 139);
			this.lblCastSpellRadiusInfo.Name = "lblCastSpellRadiusInfo";
			this.lblCastSpellRadiusInfo.Size = new global::System.Drawing.Size(360, 15);
			this.lblCastSpellRadiusInfo.TabIndex = 96;
			this.lblCastSpellRadiusInfo.Text = "Checks if a Mob (any) is in range. Otherwise it will not be executed.";
			this.checkCastSpellNoRadiusCheck.Animated = true;
			this.checkCastSpellNoRadiusCheck.AutoSize = true;
			this.checkCastSpellNoRadiusCheck.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCastSpellNoRadiusCheck.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellNoRadiusCheck.CheckedState.BorderRadius = 0;
			this.checkCastSpellNoRadiusCheck.CheckedState.BorderThickness = 0;
			this.checkCastSpellNoRadiusCheck.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCastSpellNoRadiusCheck.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkCastSpellNoRadiusCheck.Location = new global::System.Drawing.Point(420, 173);
			this.checkCastSpellNoRadiusCheck.Name = "checkCastSpellNoRadiusCheck";
			this.checkCastSpellNoRadiusCheck.Size = new global::System.Drawing.Size(96, 19);
			this.checkCastSpellNoRadiusCheck.TabIndex = 95;
			this.checkCastSpellNoRadiusCheck.Text = "Do not check";
			this.checkCastSpellNoRadiusCheck.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkCastSpellNoRadiusCheck.UncheckedState.BorderRadius = 0;
			this.checkCastSpellNoRadiusCheck.UncheckedState.BorderThickness = 1;
			this.checkCastSpellNoRadiusCheck.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkCastSpellNoRadiusCheck.UseVisualStyleBackColor = false;
			this.checkCastSpellNoRadiusCheck.CheckedChanged += new global::System.EventHandler(this.checkCastSpellNoRadiusCheck_CheckedChanged);
			this.txtCastSpellRadius.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCastSpellRadius.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCastSpellRadius.DefaultText = "0";
			this.txtCastSpellRadius.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtCastSpellRadius.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtCastSpellRadius.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCastSpellRadius.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCastSpellRadius.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtCastSpellRadius.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtCastSpellRadius.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCastSpellRadius.ForeColor = global::System.Drawing.Color.White;
			this.txtCastSpellRadius.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtCastSpellRadius.Location = new global::System.Drawing.Point(180, 167);
			this.txtCastSpellRadius.MaxLength = 2;
			this.txtCastSpellRadius.Name = "txtCastSpellRadius";
			this.txtCastSpellRadius.PasswordChar = '\0';
			this.txtCastSpellRadius.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtCastSpellRadius.PlaceholderText = "";
			this.txtCastSpellRadius.SelectedText = "";
			this.txtCastSpellRadius.Size = new global::System.Drawing.Size(225, 30);
			this.txtCastSpellRadius.TabIndex = 94;
			this.lblCastSpellRadius.AutoSize = true;
			this.lblCastSpellRadius.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCastSpellRadius.ForeColor = global::System.Drawing.Color.White;
			this.lblCastSpellRadius.Location = new global::System.Drawing.Point(22, 175);
			this.lblCastSpellRadius.Name = "lblCastSpellRadius";
			this.lblCastSpellRadius.Size = new global::System.Drawing.Size(45, 15);
			this.lblCastSpellRadius.TabIndex = 73;
			this.lblCastSpellRadius.Text = "Radius:";
			this.guna2Separator1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator1.Location = new global::System.Drawing.Point(17, 109);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(582, 10);
			this.guna2Separator1.TabIndex = 72;
			this.btnCastSpellReload.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCastSpellReload.BorderColor = global::System.Drawing.Color.Gray;
			this.btnCastSpellReload.BorderThickness = 1;
			this.btnCastSpellReload.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnCastSpellReload.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnCastSpellReload.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnCastSpellReload.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnCastSpellReload.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnCastSpellReload.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnCastSpellReload.ForeColor = global::System.Drawing.Color.White;
			this.btnCastSpellReload.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnCastSpellReload.Location = new global::System.Drawing.Point(488, 60);
			this.btnCastSpellReload.Name = "btnCastSpellReload";
			this.btnCastSpellReload.Size = new global::System.Drawing.Size(104, 29);
			this.btnCastSpellReload.TabIndex = 66;
			this.btnCastSpellReload.Text = "Reload";
			this.btnCastSpellReload.Click += new global::System.EventHandler(this.btnCastSpellReload_Click);
			this.lblCastSpell.AutoSize = true;
			this.lblCastSpell.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCastSpell.ForeColor = global::System.Drawing.Color.White;
			this.lblCastSpell.Location = new global::System.Drawing.Point(22, 67);
			this.lblCastSpell.Name = "lblCastSpell";
			this.lblCastSpell.Size = new global::System.Drawing.Size(35, 15);
			this.lblCastSpell.TabIndex = 0;
			this.lblCastSpell.Text = "Spell:";
			this.tabWalkSens.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabWalkSens.Controls.Add(this.panelTabWalkSens);
			this.tabWalkSens.Location = new global::System.Drawing.Point(4, 124);
			this.tabWalkSens.Name = "tabWalkSens";
			this.tabWalkSens.Size = new global::System.Drawing.Size(763, 432);
			this.tabWalkSens.TabIndex = 5;
			this.tabWalkSens.Text = "Walk Sensitivity";
			this.panelTabWalkSens.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabWalkSens.AutoScroll = true;
			this.panelTabWalkSens.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabWalkSens.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabWalkSens.Controls.Add(this.grpWalkSens);
			this.panelTabWalkSens.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabWalkSens.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabWalkSens.Name = "panelTabWalkSens";
			this.panelTabWalkSens.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabWalkSens.TabIndex = 66;
			this.grpWalkSens.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpWalkSens.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpWalkSens.Controls.Add(this.btnWalkSensDefault);
			this.grpWalkSens.Controls.Add(this.lblWalkSensInfo3);
			this.grpWalkSens.Controls.Add(this.lblWalkSensInfo2);
			this.grpWalkSens.Controls.Add(this.lblWalkSensIndoorData);
			this.grpWalkSens.Controls.Add(this.trackWalkSensIndoor);
			this.grpWalkSens.Controls.Add(this.lblWalkSensIndoor);
			this.grpWalkSens.Controls.Add(this.lblWalkSensOutdoorData);
			this.grpWalkSens.Controls.Add(this.trackWalkSensOutdoor);
			this.grpWalkSens.Controls.Add(this.sepWalkSens2);
			this.grpWalkSens.Controls.Add(this.lblWalkSensOutdoor);
			this.grpWalkSens.Controls.Add(this.sepWalkSens1);
			this.grpWalkSens.Controls.Add(this.lblWalkSensInfo1);
			this.grpWalkSens.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpWalkSens.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpWalkSens.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpWalkSens.ForeColor = global::System.Drawing.Color.White;
			this.grpWalkSens.Location = new global::System.Drawing.Point(14, 14);
			this.grpWalkSens.Name = "grpWalkSens";
			this.grpWalkSens.Size = new global::System.Drawing.Size(734, 323);
			this.grpWalkSens.TabIndex = 65;
			this.grpWalkSens.Text = "Walk Sensitivity";
			this.btnWalkSensDefault.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnWalkSensDefault.BorderColor = global::System.Drawing.Color.Gray;
			this.btnWalkSensDefault.BorderThickness = 1;
			this.btnWalkSensDefault.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnWalkSensDefault.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnWalkSensDefault.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnWalkSensDefault.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnWalkSensDefault.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnWalkSensDefault.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnWalkSensDefault.ForeColor = global::System.Drawing.Color.White;
			this.btnWalkSensDefault.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnWalkSensDefault.Location = new global::System.Drawing.Point(631, 61);
			this.btnWalkSensDefault.Name = "btnWalkSensDefault";
			this.btnWalkSensDefault.Size = new global::System.Drawing.Size(87, 26);
			this.btnWalkSensDefault.TabIndex = 105;
			this.btnWalkSensDefault.Text = "Default";
			this.btnWalkSensDefault.Click += new global::System.EventHandler(this.btnWalkSensDefault_Click);
			this.lblWalkSensInfo3.AutoSize = true;
			this.lblWalkSensInfo3.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWalkSensInfo3.ForeColor = global::System.Drawing.Color.White;
			this.lblWalkSensInfo3.Location = new global::System.Drawing.Point(22, 266);
			this.lblWalkSensInfo3.Name = "lblWalkSensInfo3";
			this.lblWalkSensInfo3.Size = new global::System.Drawing.Size(556, 30);
			this.lblWalkSensInfo3.TabIndex = 104;
			this.lblWalkSensInfo3.Text = "These settings remain active as long as the profile is loaded.\r\nSet the same event with default settings on a different Waypoint to reset the settings back to their origin.\r\n";
			this.lblWalkSensInfo2.AutoSize = true;
			this.lblWalkSensInfo2.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWalkSensInfo2.ForeColor = global::System.Drawing.Color.Red;
			this.lblWalkSensInfo2.Location = new global::System.Drawing.Point(22, 248);
			this.lblWalkSensInfo2.Name = "lblWalkSensInfo2";
			this.lblWalkSensInfo2.Size = new global::System.Drawing.Size(48, 15);
			this.lblWalkSensInfo2.TabIndex = 103;
			this.lblWalkSensInfo2.Text = "Beware!";
			this.lblWalkSensIndoorData.AutoSize = true;
			this.lblWalkSensIndoorData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWalkSensIndoorData.ForeColor = global::System.Drawing.Color.White;
			this.lblWalkSensIndoorData.Location = new global::System.Drawing.Point(395, 178);
			this.lblWalkSensIndoorData.Name = "lblWalkSensIndoorData";
			this.lblWalkSensIndoorData.Size = new global::System.Drawing.Size(22, 15);
			this.lblWalkSensIndoorData.TabIndex = 102;
			this.lblWalkSensIndoorData.Text = "0.7";
			this.trackWalkSensIndoor.BackColor = global::System.Drawing.Color.Transparent;
			this.trackWalkSensIndoor.Location = new global::System.Drawing.Point(180, 174);
			this.trackWalkSensIndoor.Maximum = 40;
			this.trackWalkSensIndoor.Name = "trackWalkSensIndoor";
			this.trackWalkSensIndoor.Size = new global::System.Drawing.Size(200, 23);
			this.trackWalkSensIndoor.Style = 1;
			this.trackWalkSensIndoor.TabIndex = 101;
			this.trackWalkSensIndoor.ThumbColor = global::System.Drawing.Color.DeepSkyBlue;
			this.trackWalkSensIndoor.Value = 7;
			this.trackWalkSensIndoor.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.trackWalkSensIndoor_Scroll);
			this.lblWalkSensIndoor.AutoSize = true;
			this.lblWalkSensIndoor.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWalkSensIndoor.ForeColor = global::System.Drawing.Color.White;
			this.lblWalkSensIndoor.Location = new global::System.Drawing.Point(22, 178);
			this.lblWalkSensIndoor.Name = "lblWalkSensIndoor";
			this.lblWalkSensIndoor.Size = new global::System.Drawing.Size(45, 15);
			this.lblWalkSensIndoor.TabIndex = 100;
			this.lblWalkSensIndoor.Text = "Indoor:";
			this.lblWalkSensOutdoorData.AutoSize = true;
			this.lblWalkSensOutdoorData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWalkSensOutdoorData.ForeColor = global::System.Drawing.Color.White;
			this.lblWalkSensOutdoorData.Location = new global::System.Drawing.Point(395, 137);
			this.lblWalkSensOutdoorData.Name = "lblWalkSensOutdoorData";
			this.lblWalkSensOutdoorData.Size = new global::System.Drawing.Size(22, 15);
			this.lblWalkSensOutdoorData.TabIndex = 99;
			this.lblWalkSensOutdoorData.Text = "2.0";
			this.trackWalkSensOutdoor.BackColor = global::System.Drawing.Color.Transparent;
			this.trackWalkSensOutdoor.Location = new global::System.Drawing.Point(180, 133);
			this.trackWalkSensOutdoor.Maximum = 40;
			this.trackWalkSensOutdoor.Name = "trackWalkSensOutdoor";
			this.trackWalkSensOutdoor.Size = new global::System.Drawing.Size(200, 23);
			this.trackWalkSensOutdoor.Style = 1;
			this.trackWalkSensOutdoor.TabIndex = 98;
			this.trackWalkSensOutdoor.ThumbColor = global::System.Drawing.Color.DeepSkyBlue;
			this.trackWalkSensOutdoor.Value = 20;
			this.trackWalkSensOutdoor.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.trackWalkSensOutdoor_Scroll);
			this.sepWalkSens2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepWalkSens2.BackColor = global::System.Drawing.Color.Transparent;
			this.sepWalkSens2.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepWalkSens2.Location = new global::System.Drawing.Point(17, 217);
			this.sepWalkSens2.Name = "sepWalkSens2";
			this.sepWalkSens2.Size = new global::System.Drawing.Size(701, 10);
			this.sepWalkSens2.TabIndex = 97;
			this.lblWalkSensOutdoor.AutoSize = true;
			this.lblWalkSensOutdoor.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWalkSensOutdoor.ForeColor = global::System.Drawing.Color.White;
			this.lblWalkSensOutdoor.Location = new global::System.Drawing.Point(22, 137);
			this.lblWalkSensOutdoor.Name = "lblWalkSensOutdoor";
			this.lblWalkSensOutdoor.Size = new global::System.Drawing.Size(55, 15);
			this.lblWalkSensOutdoor.TabIndex = 73;
			this.lblWalkSensOutdoor.Text = "Outdoor:";
			this.sepWalkSens1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepWalkSens1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepWalkSens1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepWalkSens1.Location = new global::System.Drawing.Point(17, 104);
			this.sepWalkSens1.Name = "sepWalkSens1";
			this.sepWalkSens1.Size = new global::System.Drawing.Size(701, 10);
			this.sepWalkSens1.TabIndex = 72;
			this.lblWalkSensInfo1.AutoSize = true;
			this.lblWalkSensInfo1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblWalkSensInfo1.ForeColor = global::System.Drawing.Color.White;
			this.lblWalkSensInfo1.Location = new global::System.Drawing.Point(22, 67);
			this.lblWalkSensInfo1.Name = "lblWalkSensInfo1";
			this.lblWalkSensInfo1.Size = new global::System.Drawing.Size(248, 15);
			this.lblWalkSensInfo1.TabIndex = 0;
			this.lblWalkSensInfo1.Text = "A higher sensitivity provides a smoother walk.";
			this.tabUseHearthstone.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabUseHearthstone.Controls.Add(this.panelTabUseHearthstone);
			this.tabUseHearthstone.Location = new global::System.Drawing.Point(4, 124);
			this.tabUseHearthstone.Name = "tabUseHearthstone";
			this.tabUseHearthstone.Size = new global::System.Drawing.Size(763, 432);
			this.tabUseHearthstone.TabIndex = 8;
			this.tabUseHearthstone.Text = "Use Hearthstone";
			this.panelTabUseHearthstone.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabUseHearthstone.AutoScroll = true;
			this.panelTabUseHearthstone.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabUseHearthstone.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabUseHearthstone.Controls.Add(this.grpUseHearthstone);
			this.panelTabUseHearthstone.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabUseHearthstone.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabUseHearthstone.Name = "panelTabUseHearthstone";
			this.panelTabUseHearthstone.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabUseHearthstone.TabIndex = 67;
			this.grpUseHearthstone.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpUseHearthstone.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpUseHearthstone.Controls.Add(this.selectUseHearthstoneLoadProfile);
			this.grpUseHearthstone.Controls.Add(this.lblUseHearthstoneLoadProfile);
			this.grpUseHearthstone.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpUseHearthstone.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpUseHearthstone.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpUseHearthstone.ForeColor = global::System.Drawing.Color.White;
			this.grpUseHearthstone.Location = new global::System.Drawing.Point(14, 14);
			this.grpUseHearthstone.Name = "grpUseHearthstone";
			this.grpUseHearthstone.Size = new global::System.Drawing.Size(734, 108);
			this.grpUseHearthstone.TabIndex = 66;
			this.grpUseHearthstone.Text = "Load Profile after usage";
			this.selectUseHearthstoneLoadProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectUseHearthstoneLoadProfile.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectUseHearthstoneLoadProfile.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectUseHearthstoneLoadProfile.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectUseHearthstoneLoadProfile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectUseHearthstoneLoadProfile.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectUseHearthstoneLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.selectUseHearthstoneLoadProfile.FormattingEnabled = true;
			this.selectUseHearthstoneLoadProfile.Location = new global::System.Drawing.Point(180, 60);
			this.selectUseHearthstoneLoadProfile.Name = "selectUseHearthstoneLoadProfile";
			this.selectUseHearthstoneLoadProfile.Size = new global::System.Drawing.Size(527, 29);
			this.selectUseHearthstoneLoadProfile.TabIndex = 72;
			this.lblUseHearthstoneLoadProfile.AutoSize = true;
			this.lblUseHearthstoneLoadProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.lblUseHearthstoneLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.lblUseHearthstoneLoadProfile.Location = new global::System.Drawing.Point(22, 67);
			this.lblUseHearthstoneLoadProfile.Name = "lblUseHearthstoneLoadProfile";
			this.lblUseHearthstoneLoadProfile.Size = new global::System.Drawing.Size(44, 15);
			this.lblUseHearthstoneLoadProfile.TabIndex = 14;
			this.lblUseHearthstoneLoadProfile.Text = "Profile:";
			this.tabFishing.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabFishing.Controls.Add(this.panelTabFishing);
			this.tabFishing.Location = new global::System.Drawing.Point(4, 124);
			this.tabFishing.Name = "tabFishing";
			this.tabFishing.Size = new global::System.Drawing.Size(763, 432);
			this.tabFishing.TabIndex = 10;
			this.tabFishing.Text = "Fishing";
			this.panelTabFishing.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabFishing.AutoScroll = true;
			this.panelTabFishing.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabFishing.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabFishing.Controls.Add(this.grpFishingOptions);
			this.panelTabFishing.Controls.Add(this.grpFishingFacing);
			this.panelTabFishing.Controls.Add(this.grpFishing);
			this.panelTabFishing.Controls.Add(this.grpFishingCondition);
			this.panelTabFishing.Controls.Add(this.grpFishingBait);
			this.panelTabFishing.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabFishing.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabFishing.Name = "panelTabFishing";
			this.panelTabFishing.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabFishing.TabIndex = 70;
			this.grpFishingOptions.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpFishingOptions.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpFishingOptions.Controls.Add(this.checkFishingOptionsRandomDelay);
			this.grpFishingOptions.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpFishingOptions.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpFishingOptions.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpFishingOptions.ForeColor = global::System.Drawing.Color.White;
			this.grpFishingOptions.Location = new global::System.Drawing.Point(14, 649);
			this.grpFishingOptions.Name = "grpFishingOptions";
			this.grpFishingOptions.Size = new global::System.Drawing.Size(614, 104);
			this.grpFishingOptions.TabIndex = 70;
			this.grpFishingOptions.Text = "Options";
			this.checkFishingOptionsRandomDelay.Animated = true;
			this.checkFishingOptionsRandomDelay.AutoSize = true;
			this.checkFishingOptionsRandomDelay.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFishingOptionsRandomDelay.Checked = true;
			this.checkFishingOptionsRandomDelay.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingOptionsRandomDelay.CheckedState.BorderRadius = 0;
			this.checkFishingOptionsRandomDelay.CheckedState.BorderThickness = 0;
			this.checkFishingOptionsRandomDelay.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingOptionsRandomDelay.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkFishingOptionsRandomDelay.ForeColor = global::System.Drawing.Color.White;
			this.checkFishingOptionsRandomDelay.Location = new global::System.Drawing.Point(25, 65);
			this.checkFishingOptionsRandomDelay.Name = "checkFishingOptionsRandomDelay";
			this.checkFishingOptionsRandomDelay.Size = new global::System.Drawing.Size(286, 19);
			this.checkFishingOptionsRandomDelay.TabIndex = 101;
			this.checkFishingOptionsRandomDelay.Text = "Random Delay (Cast and Catch) (Recommended)";
			this.checkFishingOptionsRandomDelay.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkFishingOptionsRandomDelay.UncheckedState.BorderRadius = 0;
			this.checkFishingOptionsRandomDelay.UncheckedState.BorderThickness = 1;
			this.checkFishingOptionsRandomDelay.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkFishingOptionsRandomDelay.UseVisualStyleBackColor = false;
			this.grpFishingFacing.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpFishingFacing.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpFishingFacing.Controls.Add(this.btnFishingFacingTooltip);
			this.grpFishingFacing.Controls.Add(this.btnFishingFacingDirection);
			this.grpFishingFacing.Controls.Add(this.lblFishingFacingDirection);
			this.grpFishingFacing.Controls.Add(this.checkFishingFacing);
			this.grpFishingFacing.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpFishingFacing.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpFishingFacing.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpFishingFacing.ForeColor = global::System.Drawing.Color.White;
			this.grpFishingFacing.Location = new global::System.Drawing.Point(14, 252);
			this.grpFishingFacing.Name = "grpFishingFacing";
			this.grpFishingFacing.Size = new global::System.Drawing.Size(614, 104);
			this.grpFishingFacing.TabIndex = 69;
			this.btnFishingFacingTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnFishingFacingTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnFishingFacingTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnFishingFacingTooltip.BorderRadius = 4;
			this.btnFishingFacingTooltip.BorderThickness = 1;
			this.btnFishingFacingTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnFishingFacingTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnFishingFacingTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnFishingFacingTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnFishingFacingTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnFishingFacingTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnFishingFacingTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnFishingFacingTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnFishingFacingTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnFishingFacingTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnFishingFacingTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnFishingFacingTooltip.Location = new global::System.Drawing.Point(567, 8);
			this.btnFishingFacingTooltip.Name = "btnFishingFacingTooltip";
			this.btnFishingFacingTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnFishingFacingTooltip.TabIndex = 109;
			this.btnFishingFacingTooltip.Click += new global::System.EventHandler(this.btnFishingFacingTooltip_Click);
			this.btnFishingFacingDirection.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnFishingFacingDirection.BorderColor = global::System.Drawing.Color.Gray;
			this.btnFishingFacingDirection.BorderThickness = 1;
			this.btnFishingFacingDirection.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnFishingFacingDirection.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnFishingFacingDirection.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnFishingFacingDirection.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnFishingFacingDirection.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnFishingFacingDirection.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnFishingFacingDirection.ForeColor = global::System.Drawing.Color.White;
			this.btnFishingFacingDirection.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnFishingFacingDirection.Location = new global::System.Drawing.Point(482, 58);
			this.btnFishingFacingDirection.Name = "btnFishingFacingDirection";
			this.btnFishingFacingDirection.Size = new global::System.Drawing.Size(114, 31);
			this.btnFishingFacingDirection.TabIndex = 108;
			this.btnFishingFacingDirection.Text = "Set";
			this.btnFishingFacingDirection.Click += new global::System.EventHandler(this.btnFishingFacingDirection_Click);
			this.lblFishingFacingDirection.AutoSize = true;
			this.lblFishingFacingDirection.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFishingFacingDirection.Enabled = false;
			this.lblFishingFacingDirection.ForeColor = global::System.Drawing.Color.White;
			this.lblFishingFacingDirection.Location = new global::System.Drawing.Point(22, 65);
			this.lblFishingFacingDirection.Name = "lblFishingFacingDirection";
			this.lblFishingFacingDirection.Size = new global::System.Drawing.Size(116, 15);
			this.lblFishingFacingDirection.TabIndex = 99;
			this.lblFishingFacingDirection.Text = "<No Alignment set>";
			this.checkFishingFacing.Animated = true;
			this.checkFishingFacing.AutoSize = true;
			this.checkFishingFacing.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFishingFacing.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingFacing.CheckedState.BorderRadius = 0;
			this.checkFishingFacing.CheckedState.BorderThickness = 0;
			this.checkFishingFacing.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingFacing.Location = new global::System.Drawing.Point(12, 11);
			this.checkFishingFacing.Name = "checkFishingFacing";
			this.checkFishingFacing.Size = new global::System.Drawing.Size(140, 19);
			this.checkFishingFacing.TabIndex = 95;
			this.checkFishingFacing.Text = "Align me to the water";
			this.checkFishingFacing.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkFishingFacing.UncheckedState.BorderRadius = 0;
			this.checkFishingFacing.UncheckedState.BorderThickness = 1;
			this.checkFishingFacing.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkFishingFacing.UseVisualStyleBackColor = false;
			this.checkFishingFacing.CheckedChanged += new global::System.EventHandler(this.checkFishingFacing_CheckedChanged);
			this.grpFishing.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpFishing.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpFishing.Controls.Add(this.lblFishingKeybind);
			this.grpFishing.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpFishing.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpFishing.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpFishing.ForeColor = global::System.Drawing.Color.White;
			this.grpFishing.Location = new global::System.Drawing.Point(14, 14);
			this.grpFishing.Name = "grpFishing";
			this.grpFishing.Size = new global::System.Drawing.Size(614, 104);
			this.grpFishing.TabIndex = 66;
			this.grpFishing.Text = "Fishing";
			this.lblFishingKeybind.AutoSize = true;
			this.lblFishingKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFishingKeybind.ForeColor = global::System.Drawing.Color.White;
			this.lblFishingKeybind.Location = new global::System.Drawing.Point(22, 65);
			this.lblFishingKeybind.Name = "lblFishingKeybind";
			this.lblFishingKeybind.Size = new global::System.Drawing.Size(62, 15);
			this.lblFishingKeybind.TabIndex = 98;
			this.lblFishingKeybind.Text = "[KEYBIND]";
			this.grpFishingCondition.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpFishingCondition.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpFishingCondition.Controls.Add(this.checkFishingConditionFullBags);
			this.grpFishingCondition.Controls.Add(this.guna2Separator4);
			this.grpFishingCondition.Controls.Add(this.btnFishingConditionItemlist);
			this.grpFishingCondition.Controls.Add(this.lblcheckFishingConditionItemlist);
			this.grpFishingCondition.Controls.Add(this.checkFishingConditionItemlist);
			this.grpFishingCondition.Controls.Add(this.guna2Separator3);
			this.grpFishingCondition.Controls.Add(this.txtFishingConditionSkillLevel);
			this.grpFishingCondition.Controls.Add(this.checkFishingConditionSkillLevel);
			this.grpFishingCondition.Controls.Add(this.checkFishingCondition);
			this.grpFishingCondition.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpFishingCondition.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpFishingCondition.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpFishingCondition.ForeColor = global::System.Drawing.Color.White;
			this.grpFishingCondition.Location = new global::System.Drawing.Point(14, 371);
			this.grpFishingCondition.Name = "grpFishingCondition";
			this.grpFishingCondition.Size = new global::System.Drawing.Size(614, 263);
			this.grpFishingCondition.TabIndex = 68;
			this.checkFishingConditionFullBags.Animated = true;
			this.checkFishingConditionFullBags.AutoSize = true;
			this.checkFishingConditionFullBags.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFishingConditionFullBags.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingConditionFullBags.CheckedState.BorderRadius = 0;
			this.checkFishingConditionFullBags.CheckedState.BorderThickness = 0;
			this.checkFishingConditionFullBags.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingConditionFullBags.ForeColor = global::System.Drawing.Color.White;
			this.checkFishingConditionFullBags.Location = new global::System.Drawing.Point(25, 219);
			this.checkFishingConditionFullBags.Name = "checkFishingConditionFullBags";
			this.checkFishingConditionFullBags.Size = new global::System.Drawing.Size(93, 19);
			this.checkFishingConditionFullBags.TabIndex = 109;
			this.checkFishingConditionFullBags.Text = "Bags are full.";
			this.checkFishingConditionFullBags.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkFishingConditionFullBags.UncheckedState.BorderRadius = 0;
			this.checkFishingConditionFullBags.UncheckedState.BorderThickness = 1;
			this.checkFishingConditionFullBags.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkFishingConditionFullBags.UseVisualStyleBackColor = false;
			this.guna2Separator4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator4.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator4.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator4.Location = new global::System.Drawing.Point(17, 183);
			this.guna2Separator4.Name = "guna2Separator4";
			this.guna2Separator4.Size = new global::System.Drawing.Size(579, 10);
			this.guna2Separator4.TabIndex = 108;
			this.btnFishingConditionItemlist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnFishingConditionItemlist.BorderThickness = 1;
			this.btnFishingConditionItemlist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnFishingConditionItemlist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnFishingConditionItemlist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnFishingConditionItemlist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnFishingConditionItemlist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnFishingConditionItemlist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnFishingConditionItemlist.ForeColor = global::System.Drawing.Color.White;
			this.btnFishingConditionItemlist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnFishingConditionItemlist.Location = new global::System.Drawing.Point(180, 134);
			this.btnFishingConditionItemlist.Name = "btnFishingConditionItemlist";
			this.btnFishingConditionItemlist.Size = new global::System.Drawing.Size(114, 31);
			this.btnFishingConditionItemlist.TabIndex = 107;
			this.btnFishingConditionItemlist.Text = "Itemlist";
			this.btnFishingConditionItemlist.Click += new global::System.EventHandler(this.btnFishingConditionItemlist_Click);
			this.lblcheckFishingConditionItemlist.AutoSize = true;
			this.lblcheckFishingConditionItemlist.BackColor = global::System.Drawing.Color.Transparent;
			this.lblcheckFishingConditionItemlist.ForeColor = global::System.Drawing.Color.White;
			this.lblcheckFishingConditionItemlist.Location = new global::System.Drawing.Point(300, 143);
			this.lblcheckFishingConditionItemlist.Name = "lblcheckFishingConditionItemlist";
			this.lblcheckFishingConditionItemlist.Size = new global::System.Drawing.Size(92, 15);
			this.lblcheckFishingConditionItemlist.TabIndex = 106;
			this.lblcheckFishingConditionItemlist.Text = "has been found.";
			this.checkFishingConditionItemlist.Animated = true;
			this.checkFishingConditionItemlist.AutoSize = true;
			this.checkFishingConditionItemlist.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFishingConditionItemlist.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingConditionItemlist.CheckedState.BorderRadius = 0;
			this.checkFishingConditionItemlist.CheckedState.BorderThickness = 0;
			this.checkFishingConditionItemlist.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingConditionItemlist.ForeColor = global::System.Drawing.Color.White;
			this.checkFishingConditionItemlist.Location = new global::System.Drawing.Point(25, 142);
			this.checkFishingConditionItemlist.Name = "checkFishingConditionItemlist";
			this.checkFishingConditionItemlist.Size = new global::System.Drawing.Size(92, 19);
			this.checkFishingConditionItemlist.TabIndex = 104;
			this.checkFishingConditionItemlist.Text = "Items on my";
			this.checkFishingConditionItemlist.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkFishingConditionItemlist.UncheckedState.BorderRadius = 0;
			this.checkFishingConditionItemlist.UncheckedState.BorderThickness = 1;
			this.checkFishingConditionItemlist.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkFishingConditionItemlist.UseVisualStyleBackColor = false;
			this.checkFishingConditionItemlist.CheckedChanged += new global::System.EventHandler(this.checkFishingConditionItemlist_CheckedChanged);
			this.guna2Separator3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator3.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator3.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator3.Location = new global::System.Drawing.Point(17, 106);
			this.guna2Separator3.Name = "guna2Separator3";
			this.guna2Separator3.Size = new global::System.Drawing.Size(579, 10);
			this.guna2Separator3.TabIndex = 103;
			this.txtFishingConditionSkillLevel.BorderColor = global::System.Drawing.Color.Gray;
			this.txtFishingConditionSkillLevel.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtFishingConditionSkillLevel.DefaultText = "";
			this.txtFishingConditionSkillLevel.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtFishingConditionSkillLevel.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtFishingConditionSkillLevel.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFishingConditionSkillLevel.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFishingConditionSkillLevel.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtFishingConditionSkillLevel.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtFishingConditionSkillLevel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtFishingConditionSkillLevel.ForeColor = global::System.Drawing.Color.White;
			this.txtFishingConditionSkillLevel.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtFishingConditionSkillLevel.Location = new global::System.Drawing.Point(180, 60);
			this.txtFishingConditionSkillLevel.MaxLength = 3;
			this.txtFishingConditionSkillLevel.Name = "txtFishingConditionSkillLevel";
			this.txtFishingConditionSkillLevel.PasswordChar = '\0';
			this.txtFishingConditionSkillLevel.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtFishingConditionSkillLevel.PlaceholderText = "75";
			this.txtFishingConditionSkillLevel.SelectedText = "";
			this.txtFishingConditionSkillLevel.Size = new global::System.Drawing.Size(55, 30);
			this.txtFishingConditionSkillLevel.TabIndex = 101;
			this.checkFishingConditionSkillLevel.Animated = true;
			this.checkFishingConditionSkillLevel.AutoSize = true;
			this.checkFishingConditionSkillLevel.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFishingConditionSkillLevel.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingConditionSkillLevel.CheckedState.BorderRadius = 0;
			this.checkFishingConditionSkillLevel.CheckedState.BorderThickness = 0;
			this.checkFishingConditionSkillLevel.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingConditionSkillLevel.ForeColor = global::System.Drawing.Color.White;
			this.checkFishingConditionSkillLevel.Location = new global::System.Drawing.Point(25, 67);
			this.checkFishingConditionSkillLevel.Name = "checkFishingConditionSkillLevel";
			this.checkFishingConditionSkillLevel.Size = new global::System.Drawing.Size(77, 19);
			this.checkFishingConditionSkillLevel.TabIndex = 100;
			this.checkFishingConditionSkillLevel.Text = "Skill Level";
			this.checkFishingConditionSkillLevel.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkFishingConditionSkillLevel.UncheckedState.BorderRadius = 0;
			this.checkFishingConditionSkillLevel.UncheckedState.BorderThickness = 1;
			this.checkFishingConditionSkillLevel.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkFishingConditionSkillLevel.UseVisualStyleBackColor = false;
			this.checkFishingConditionSkillLevel.CheckedChanged += new global::System.EventHandler(this.checkFishingConditionSkillLevel_CheckedChanged);
			this.checkFishingCondition.Animated = true;
			this.checkFishingCondition.AutoSize = true;
			this.checkFishingCondition.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFishingCondition.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingCondition.CheckedState.BorderRadius = 0;
			this.checkFishingCondition.CheckedState.BorderThickness = 0;
			this.checkFishingCondition.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingCondition.Location = new global::System.Drawing.Point(12, 11);
			this.checkFishingCondition.Name = "checkFishingCondition";
			this.checkFishingCondition.Size = new global::System.Drawing.Size(60, 19);
			this.checkFishingCondition.TabIndex = 95;
			this.checkFishingCondition.Text = "Until...";
			this.checkFishingCondition.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkFishingCondition.UncheckedState.BorderRadius = 0;
			this.checkFishingCondition.UncheckedState.BorderThickness = 1;
			this.checkFishingCondition.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkFishingCondition.UseVisualStyleBackColor = false;
			this.checkFishingCondition.CheckedChanged += new global::System.EventHandler(this.checkFishingCondition_CheckedChanged);
			this.grpFishingBait.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpFishingBait.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpFishingBait.Controls.Add(this.lblFishingBaitKeybind);
			this.grpFishingBait.Controls.Add(this.checkFishingBait);
			this.grpFishingBait.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpFishingBait.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpFishingBait.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpFishingBait.ForeColor = global::System.Drawing.Color.White;
			this.grpFishingBait.Location = new global::System.Drawing.Point(14, 133);
			this.grpFishingBait.Name = "grpFishingBait";
			this.grpFishingBait.Size = new global::System.Drawing.Size(614, 104);
			this.grpFishingBait.TabIndex = 67;
			this.lblFishingBaitKeybind.AutoSize = true;
			this.lblFishingBaitKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFishingBaitKeybind.Enabled = false;
			this.lblFishingBaitKeybind.ForeColor = global::System.Drawing.Color.White;
			this.lblFishingBaitKeybind.Location = new global::System.Drawing.Point(22, 65);
			this.lblFishingBaitKeybind.Name = "lblFishingBaitKeybind";
			this.lblFishingBaitKeybind.Size = new global::System.Drawing.Size(62, 15);
			this.lblFishingBaitKeybind.TabIndex = 99;
			this.lblFishingBaitKeybind.Text = "[KEYBIND]";
			this.checkFishingBait.Animated = true;
			this.checkFishingBait.AutoSize = true;
			this.checkFishingBait.BackColor = global::System.Drawing.Color.Transparent;
			this.checkFishingBait.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingBait.CheckedState.BorderRadius = 0;
			this.checkFishingBait.CheckedState.BorderThickness = 0;
			this.checkFishingBait.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkFishingBait.Location = new global::System.Drawing.Point(12, 11);
			this.checkFishingBait.Name = "checkFishingBait";
			this.checkFishingBait.Size = new global::System.Drawing.Size(68, 19);
			this.checkFishingBait.TabIndex = 95;
			this.checkFishingBait.Text = "Use Bait";
			this.checkFishingBait.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkFishingBait.UncheckedState.BorderRadius = 0;
			this.checkFishingBait.UncheckedState.BorderThickness = 1;
			this.checkFishingBait.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkFishingBait.UseVisualStyleBackColor = false;
			this.checkFishingBait.CheckedChanged += new global::System.EventHandler(this.checkFishingBait_CheckedChanged);
			this.tabUseTransport.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabUseTransport.Controls.Add(this.panelTabUseTransport);
			this.tabUseTransport.Location = new global::System.Drawing.Point(4, 124);
			this.tabUseTransport.Name = "tabUseTransport";
			this.tabUseTransport.Size = new global::System.Drawing.Size(763, 432);
			this.tabUseTransport.TabIndex = 11;
			this.tabUseTransport.Text = "Use Transport";
			this.panelTabUseTransport.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabUseTransport.AutoScroll = true;
			this.panelTabUseTransport.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabUseTransport.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabUseTransport.Controls.Add(this.grpUseTransportTurn);
			this.panelTabUseTransport.Controls.Add(this.grpUseTransportLoadProfile);
			this.panelTabUseTransport.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabUseTransport.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabUseTransport.Name = "panelTabUseTransport";
			this.panelTabUseTransport.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabUseTransport.TabIndex = 67;
			this.grpUseTransportTurn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpUseTransportTurn.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpUseTransportTurn.Controls.Add(this.selectUseTransportTurn);
			this.grpUseTransportTurn.Controls.Add(this.lblUseTransportTurn);
			this.grpUseTransportTurn.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpUseTransportTurn.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpUseTransportTurn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpUseTransportTurn.ForeColor = global::System.Drawing.Color.White;
			this.grpUseTransportTurn.Location = new global::System.Drawing.Point(14, 137);
			this.grpUseTransportTurn.Name = "grpUseTransportTurn";
			this.grpUseTransportTurn.Size = new global::System.Drawing.Size(734, 108);
			this.grpUseTransportTurn.TabIndex = 66;
			this.grpUseTransportTurn.Text = "Turn to Exit";
			this.selectUseTransportTurn.BackColor = global::System.Drawing.Color.Transparent;
			this.selectUseTransportTurn.BorderColor = global::System.Drawing.Color.Gray;
			this.selectUseTransportTurn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectUseTransportTurn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectUseTransportTurn.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectUseTransportTurn.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectUseTransportTurn.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectUseTransportTurn.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectUseTransportTurn.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectUseTransportTurn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectUseTransportTurn.ForeColor = global::System.Drawing.Color.White;
			this.selectUseTransportTurn.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectUseTransportTurn.ItemHeight = 24;
			this.selectUseTransportTurn.Items.AddRange(new object[]
			{
				"No Turn",
				"Turn 45° left",
				"Turn 90° left",
				"Turn 135° left",
				"Turn 45° right",
				"Turn 90° right",
				"Turn 135° right",
				"Turn 180°"
			});
			this.selectUseTransportTurn.Location = new global::System.Drawing.Point(180, 60);
			this.selectUseTransportTurn.Name = "selectUseTransportTurn";
			this.selectUseTransportTurn.Size = new global::System.Drawing.Size(200, 30);
			this.selectUseTransportTurn.TabIndex = 71;
			this.lblUseTransportTurn.AutoSize = true;
			this.lblUseTransportTurn.BackColor = global::System.Drawing.Color.Transparent;
			this.lblUseTransportTurn.ForeColor = global::System.Drawing.Color.White;
			this.lblUseTransportTurn.Location = new global::System.Drawing.Point(22, 67);
			this.lblUseTransportTurn.Name = "lblUseTransportTurn";
			this.lblUseTransportTurn.Size = new global::System.Drawing.Size(58, 15);
			this.lblUseTransportTurn.TabIndex = 14;
			this.lblUseTransportTurn.Text = "Direction:";
			this.grpUseTransportLoadProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpUseTransportLoadProfile.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpUseTransportLoadProfile.Controls.Add(this.btnUseTransportTooltip);
			this.grpUseTransportLoadProfile.Controls.Add(this.selectUseTransportLoadProfile);
			this.grpUseTransportLoadProfile.Controls.Add(this.lblUseTransportLoadProfile);
			this.grpUseTransportLoadProfile.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpUseTransportLoadProfile.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpUseTransportLoadProfile.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpUseTransportLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.grpUseTransportLoadProfile.Location = new global::System.Drawing.Point(14, 14);
			this.grpUseTransportLoadProfile.Name = "grpUseTransportLoadProfile";
			this.grpUseTransportLoadProfile.Size = new global::System.Drawing.Size(734, 108);
			this.grpUseTransportLoadProfile.TabIndex = 65;
			this.grpUseTransportLoadProfile.Text = "Load Profile after transport";
			this.btnUseTransportTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnUseTransportTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnUseTransportTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnUseTransportTooltip.BorderRadius = 4;
			this.btnUseTransportTooltip.BorderThickness = 1;
			this.btnUseTransportTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnUseTransportTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnUseTransportTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnUseTransportTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnUseTransportTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnUseTransportTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnUseTransportTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnUseTransportTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnUseTransportTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnUseTransportTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnUseTransportTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnUseTransportTooltip.Location = new global::System.Drawing.Point(687, 8);
			this.btnUseTransportTooltip.Name = "btnUseTransportTooltip";
			this.btnUseTransportTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnUseTransportTooltip.TabIndex = 74;
			this.btnUseTransportTooltip.Click += new global::System.EventHandler(this.btnUseTransportTooltip_Click);
			this.selectUseTransportLoadProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectUseTransportLoadProfile.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectUseTransportLoadProfile.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectUseTransportLoadProfile.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectUseTransportLoadProfile.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectUseTransportLoadProfile.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectUseTransportLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.selectUseTransportLoadProfile.FormattingEnabled = true;
			this.selectUseTransportLoadProfile.Location = new global::System.Drawing.Point(180, 60);
			this.selectUseTransportLoadProfile.Name = "selectUseTransportLoadProfile";
			this.selectUseTransportLoadProfile.Size = new global::System.Drawing.Size(527, 29);
			this.selectUseTransportLoadProfile.TabIndex = 71;
			this.lblUseTransportLoadProfile.AutoSize = true;
			this.lblUseTransportLoadProfile.BackColor = global::System.Drawing.Color.Transparent;
			this.lblUseTransportLoadProfile.ForeColor = global::System.Drawing.Color.White;
			this.lblUseTransportLoadProfile.Location = new global::System.Drawing.Point(22, 67);
			this.lblUseTransportLoadProfile.Name = "lblUseTransportLoadProfile";
			this.lblUseTransportLoadProfile.Size = new global::System.Drawing.Size(44, 15);
			this.lblUseTransportLoadProfile.TabIndex = 14;
			this.lblUseTransportLoadProfile.Text = "Profile:";
			this.tabExecuteLUA.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabExecuteLUA.Controls.Add(this.panelTabExecuteLUA);
			this.tabExecuteLUA.Location = new global::System.Drawing.Point(4, 124);
			this.tabExecuteLUA.Name = "tabExecuteLUA";
			this.tabExecuteLUA.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabExecuteLUA.Size = new global::System.Drawing.Size(763, 432);
			this.tabExecuteLUA.TabIndex = 12;
			this.tabExecuteLUA.Text = "Execute LUA";
			this.panelTabExecuteLUA.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabExecuteLUA.AutoScroll = true;
			this.panelTabExecuteLUA.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabExecuteLUA.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabExecuteLUA.Controls.Add(this.grpExecuteLUA);
			this.panelTabExecuteLUA.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabExecuteLUA.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabExecuteLUA.Name = "panelTabExecuteLUA";
			this.panelTabExecuteLUA.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabExecuteLUA.TabIndex = 68;
			this.grpExecuteLUA.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpExecuteLUA.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpExecuteLUA.Controls.Add(this.checkExecuteLUAWhileWalk);
			this.grpExecuteLUA.Controls.Add(this.btnExecuteLUATest);
			this.grpExecuteLUA.Controls.Add(this.selectExecuteLUAExamples);
			this.grpExecuteLUA.Controls.Add(this.txtExecuteLUA);
			this.grpExecuteLUA.Controls.Add(this.btnExecuteLUATooltip);
			this.grpExecuteLUA.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpExecuteLUA.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpExecuteLUA.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpExecuteLUA.ForeColor = global::System.Drawing.Color.White;
			this.grpExecuteLUA.Location = new global::System.Drawing.Point(14, 14);
			this.grpExecuteLUA.Name = "grpExecuteLUA";
			this.grpExecuteLUA.Size = new global::System.Drawing.Size(732, 305);
			this.grpExecuteLUA.TabIndex = 65;
			this.grpExecuteLUA.Text = "Execute LUA";
			this.checkExecuteLUAWhileWalk.Animated = true;
			this.checkExecuteLUAWhileWalk.AutoSize = true;
			this.checkExecuteLUAWhileWalk.BackColor = global::System.Drawing.Color.Transparent;
			this.checkExecuteLUAWhileWalk.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkExecuteLUAWhileWalk.CheckedState.BorderRadius = 0;
			this.checkExecuteLUAWhileWalk.CheckedState.BorderThickness = 0;
			this.checkExecuteLUAWhileWalk.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkExecuteLUAWhileWalk.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkExecuteLUAWhileWalk.Location = new global::System.Drawing.Point(25, 254);
			this.checkExecuteLUAWhileWalk.Name = "checkExecuteLUAWhileWalk";
			this.checkExecuteLUAWhileWalk.Size = new global::System.Drawing.Size(156, 19);
			this.checkExecuteLUAWhileWalk.TabIndex = 99;
			this.checkExecuteLUAWhileWalk.Text = "Can executed while walk";
			this.checkExecuteLUAWhileWalk.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkExecuteLUAWhileWalk.UncheckedState.BorderRadius = 0;
			this.checkExecuteLUAWhileWalk.UncheckedState.BorderThickness = 1;
			this.checkExecuteLUAWhileWalk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkExecuteLUAWhileWalk.UseVisualStyleBackColor = false;
			this.btnExecuteLUATest.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnExecuteLUATest.BorderColor = global::System.Drawing.Color.Gray;
			this.btnExecuteLUATest.BorderThickness = 1;
			this.btnExecuteLUATest.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnExecuteLUATest.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnExecuteLUATest.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnExecuteLUATest.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnExecuteLUATest.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnExecuteLUATest.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnExecuteLUATest.ForeColor = global::System.Drawing.Color.White;
			this.btnExecuteLUATest.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnExecuteLUATest.Location = new global::System.Drawing.Point(577, 248);
			this.btnExecuteLUATest.Name = "btnExecuteLUATest";
			this.btnExecuteLUATest.Size = new global::System.Drawing.Size(130, 30);
			this.btnExecuteLUATest.TabIndex = 96;
			this.btnExecuteLUATest.Text = "Test";
			this.btnExecuteLUATest.Click += new global::System.EventHandler(this.btnExecuteLUATest_Click);
			this.selectExecuteLUAExamples.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectExecuteLUAExamples.BackColor = global::System.Drawing.Color.Transparent;
			this.selectExecuteLUAExamples.BorderColor = global::System.Drawing.Color.Gray;
			this.selectExecuteLUAExamples.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectExecuteLUAExamples.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectExecuteLUAExamples.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectExecuteLUAExamples.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectExecuteLUAExamples.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectExecuteLUAExamples.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectExecuteLUAExamples.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectExecuteLUAExamples.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectExecuteLUAExamples.ForeColor = global::System.Drawing.Color.White;
			this.selectExecuteLUAExamples.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectExecuteLUAExamples.ItemHeight = 24;
			this.selectExecuteLUAExamples.Location = new global::System.Drawing.Point(25, 67);
			this.selectExecuteLUAExamples.Name = "selectExecuteLUAExamples";
			this.selectExecuteLUAExamples.Size = new global::System.Drawing.Size(682, 30);
			this.selectExecuteLUAExamples.TabIndex = 95;
			this.selectExecuteLUAExamples.SelectedIndexChanged += new global::System.EventHandler(this.selectExecuteLUAExamples_SelectedIndexChanged);
			this.txtExecuteLUA.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtExecuteLUA.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExecuteLUA.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtExecuteLUA.DefaultText = "";
			this.txtExecuteLUA.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExecuteLUA.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtExecuteLUA.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExecuteLUA.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExecuteLUA.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtExecuteLUA.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtExecuteLUA.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtExecuteLUA.ForeColor = global::System.Drawing.Color.White;
			this.txtExecuteLUA.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtExecuteLUA.Location = new global::System.Drawing.Point(25, 103);
			this.txtExecuteLUA.MaxLength = 800;
			this.txtExecuteLUA.Multiline = true;
			this.txtExecuteLUA.Name = "txtExecuteLUA";
			this.txtExecuteLUA.PasswordChar = '\0';
			this.txtExecuteLUA.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtExecuteLUA.PlaceholderText = "Click on the cloud for more info.";
			this.txtExecuteLUA.SelectedText = "";
			this.txtExecuteLUA.Size = new global::System.Drawing.Size(682, 139);
			this.txtExecuteLUA.TabIndex = 94;
			this.btnExecuteLUATooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnExecuteLUATooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnExecuteLUATooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnExecuteLUATooltip.BorderRadius = 4;
			this.btnExecuteLUATooltip.BorderThickness = 1;
			this.btnExecuteLUATooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnExecuteLUATooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnExecuteLUATooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnExecuteLUATooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnExecuteLUATooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnExecuteLUATooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnExecuteLUATooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnExecuteLUATooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnExecuteLUATooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnExecuteLUATooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnExecuteLUATooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnExecuteLUATooltip.Location = new global::System.Drawing.Point(685, 8);
			this.btnExecuteLUATooltip.Name = "btnExecuteLUATooltip";
			this.btnExecuteLUATooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnExecuteLUATooltip.TabIndex = 74;
			this.btnExecuteLUATooltip.Click += new global::System.EventHandler(this.btnExecuteLUATooltip_Click);
			this.tabBattlegroundClassic.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabBattlegroundClassic.Controls.Add(this.panelTabBattleground);
			this.tabBattlegroundClassic.Location = new global::System.Drawing.Point(4, 124);
			this.tabBattlegroundClassic.Name = "tabBattlegroundClassic";
			this.tabBattlegroundClassic.Size = new global::System.Drawing.Size(763, 432);
			this.tabBattlegroundClassic.TabIndex = 13;
			this.tabBattlegroundClassic.Text = "Join Battlegrounds";
			this.panelTabBattleground.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabBattleground.AutoScroll = true;
			this.panelTabBattleground.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabBattleground.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabBattleground.Controls.Add(this.grpBattlegroundClassic);
			this.panelTabBattleground.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabBattleground.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabBattleground.Name = "panelTabBattleground";
			this.panelTabBattleground.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabBattleground.TabIndex = 68;
			this.grpBattlegroundClassic.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpBattlegroundClassic.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpBattlegroundClassic.Controls.Add(this.selectBattlegroundClassicStrandOfTheAncients);
			this.grpBattlegroundClassic.Controls.Add(this.checkBattlegroundClassicStrandOfTheAncients);
			this.grpBattlegroundClassic.Controls.Add(this.btnTooltipBattlegroundClassic);
			this.grpBattlegroundClassic.Controls.Add(this.checkBattlegroundClassicWaitUntilInvitation);
			this.grpBattlegroundClassic.Controls.Add(this.selectBattlegroundClassicEyeOfTheStorm);
			this.grpBattlegroundClassic.Controls.Add(this.selectBattlegroundClassicAlteracValley);
			this.grpBattlegroundClassic.Controls.Add(this.selectBattlegroundClassicArathiBasin);
			this.grpBattlegroundClassic.Controls.Add(this.selectBattlegroundClassicWarsongGulch);
			this.grpBattlegroundClassic.Controls.Add(this.checkBattlegroundClassicEyeOfTheStorm);
			this.grpBattlegroundClassic.Controls.Add(this.checkBattlegroundClassicAlteracValley);
			this.grpBattlegroundClassic.Controls.Add(this.checkBattlegroundClassicArathiBasin);
			this.grpBattlegroundClassic.Controls.Add(this.checkBattlegroundClassicWarsongGulch);
			this.grpBattlegroundClassic.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpBattlegroundClassic.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpBattlegroundClassic.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpBattlegroundClassic.ForeColor = global::System.Drawing.Color.White;
			this.grpBattlegroundClassic.Location = new global::System.Drawing.Point(14, 14);
			this.grpBattlegroundClassic.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpBattlegroundClassic.Name = "grpBattlegroundClassic";
			this.grpBattlegroundClassic.Size = new global::System.Drawing.Size(733, 278);
			this.grpBattlegroundClassic.TabIndex = 80;
			this.grpBattlegroundClassic.Text = "Battlegrounds (Classic)";
			this.selectBattlegroundClassicStrandOfTheAncients.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectBattlegroundClassicStrandOfTheAncients.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectBattlegroundClassicStrandOfTheAncients.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectBattlegroundClassicStrandOfTheAncients.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectBattlegroundClassicStrandOfTheAncients.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectBattlegroundClassicStrandOfTheAncients.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectBattlegroundClassicStrandOfTheAncients.ForeColor = global::System.Drawing.Color.White;
			this.selectBattlegroundClassicStrandOfTheAncients.FormattingEnabled = true;
			this.selectBattlegroundClassicStrandOfTheAncients.Location = new global::System.Drawing.Point(180, 200);
			this.selectBattlegroundClassicStrandOfTheAncients.Name = "selectBattlegroundClassicStrandOfTheAncients";
			this.selectBattlegroundClassicStrandOfTheAncients.Size = new global::System.Drawing.Size(528, 29);
			this.selectBattlegroundClassicStrandOfTheAncients.TabIndex = 93;
			this.checkBattlegroundClassicStrandOfTheAncients.Animated = true;
			this.checkBattlegroundClassicStrandOfTheAncients.AutoSize = true;
			this.checkBattlegroundClassicStrandOfTheAncients.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBattlegroundClassicStrandOfTheAncients.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicStrandOfTheAncients.CheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicStrandOfTheAncients.CheckedState.BorderThickness = 0;
			this.checkBattlegroundClassicStrandOfTheAncients.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicStrandOfTheAncients.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkBattlegroundClassicStrandOfTheAncients.Location = new global::System.Drawing.Point(25, 206);
			this.checkBattlegroundClassicStrandOfTheAncients.Name = "checkBattlegroundClassicStrandOfTheAncients";
			this.checkBattlegroundClassicStrandOfTheAncients.Size = new global::System.Drawing.Size(143, 19);
			this.checkBattlegroundClassicStrandOfTheAncients.TabIndex = 92;
			this.checkBattlegroundClassicStrandOfTheAncients.Text = "Strand of the Ancients";
			this.checkBattlegroundClassicStrandOfTheAncients.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkBattlegroundClassicStrandOfTheAncients.UncheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicStrandOfTheAncients.UncheckedState.BorderThickness = 1;
			this.checkBattlegroundClassicStrandOfTheAncients.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkBattlegroundClassicStrandOfTheAncients.UseVisualStyleBackColor = false;
			this.btnTooltipBattlegroundClassic.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnTooltipBattlegroundClassic.BackColor = global::System.Drawing.Color.Transparent;
			this.btnTooltipBattlegroundClassic.BorderColor = global::System.Drawing.Color.Empty;
			this.btnTooltipBattlegroundClassic.BorderRadius = 4;
			this.btnTooltipBattlegroundClassic.BorderThickness = 1;
			this.btnTooltipBattlegroundClassic.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnTooltipBattlegroundClassic.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnTooltipBattlegroundClassic.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnTooltipBattlegroundClassic.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnTooltipBattlegroundClassic.FillColor = global::System.Drawing.Color.Transparent;
			this.btnTooltipBattlegroundClassic.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTooltipBattlegroundClassic.ForeColor = global::System.Drawing.Color.White;
			this.btnTooltipBattlegroundClassic.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnTooltipBattlegroundClassic.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnTooltipBattlegroundClassic.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnTooltipBattlegroundClassic.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnTooltipBattlegroundClassic.Location = new global::System.Drawing.Point(685, 8);
			this.btnTooltipBattlegroundClassic.Name = "btnTooltipBattlegroundClassic";
			this.btnTooltipBattlegroundClassic.Size = new global::System.Drawing.Size(39, 25);
			this.btnTooltipBattlegroundClassic.TabIndex = 91;
			this.btnTooltipBattlegroundClassic.Click += new global::System.EventHandler(this.btnTooltipBattlegroundClassic_Click);
			this.checkBattlegroundClassicWaitUntilInvitation.Animated = true;
			this.checkBattlegroundClassicWaitUntilInvitation.AutoSize = true;
			this.checkBattlegroundClassicWaitUntilInvitation.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBattlegroundClassicWaitUntilInvitation.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicWaitUntilInvitation.CheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicWaitUntilInvitation.CheckedState.BorderThickness = 0;
			this.checkBattlegroundClassicWaitUntilInvitation.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicWaitUntilInvitation.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkBattlegroundClassicWaitUntilInvitation.Location = new global::System.Drawing.Point(180, 242);
			this.checkBattlegroundClassicWaitUntilInvitation.Name = "checkBattlegroundClassicWaitUntilInvitation";
			this.checkBattlegroundClassicWaitUntilInvitation.Size = new global::System.Drawing.Size(130, 19);
			this.checkBattlegroundClassicWaitUntilInvitation.TabIndex = 90;
			this.checkBattlegroundClassicWaitUntilInvitation.Text = "Wait until invitation";
			this.checkBattlegroundClassicWaitUntilInvitation.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkBattlegroundClassicWaitUntilInvitation.UncheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicWaitUntilInvitation.UncheckedState.BorderThickness = 1;
			this.checkBattlegroundClassicWaitUntilInvitation.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkBattlegroundClassicWaitUntilInvitation.UseVisualStyleBackColor = false;
			this.selectBattlegroundClassicEyeOfTheStorm.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectBattlegroundClassicEyeOfTheStorm.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectBattlegroundClassicEyeOfTheStorm.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectBattlegroundClassicEyeOfTheStorm.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectBattlegroundClassicEyeOfTheStorm.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectBattlegroundClassicEyeOfTheStorm.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectBattlegroundClassicEyeOfTheStorm.ForeColor = global::System.Drawing.Color.White;
			this.selectBattlegroundClassicEyeOfTheStorm.FormattingEnabled = true;
			this.selectBattlegroundClassicEyeOfTheStorm.Location = new global::System.Drawing.Point(180, 165);
			this.selectBattlegroundClassicEyeOfTheStorm.Name = "selectBattlegroundClassicEyeOfTheStorm";
			this.selectBattlegroundClassicEyeOfTheStorm.Size = new global::System.Drawing.Size(528, 29);
			this.selectBattlegroundClassicEyeOfTheStorm.TabIndex = 89;
			this.selectBattlegroundClassicAlteracValley.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectBattlegroundClassicAlteracValley.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectBattlegroundClassicAlteracValley.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectBattlegroundClassicAlteracValley.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectBattlegroundClassicAlteracValley.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectBattlegroundClassicAlteracValley.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectBattlegroundClassicAlteracValley.ForeColor = global::System.Drawing.Color.White;
			this.selectBattlegroundClassicAlteracValley.FormattingEnabled = true;
			this.selectBattlegroundClassicAlteracValley.Location = new global::System.Drawing.Point(180, 130);
			this.selectBattlegroundClassicAlteracValley.Name = "selectBattlegroundClassicAlteracValley";
			this.selectBattlegroundClassicAlteracValley.Size = new global::System.Drawing.Size(528, 29);
			this.selectBattlegroundClassicAlteracValley.TabIndex = 88;
			this.selectBattlegroundClassicArathiBasin.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectBattlegroundClassicArathiBasin.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectBattlegroundClassicArathiBasin.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectBattlegroundClassicArathiBasin.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectBattlegroundClassicArathiBasin.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectBattlegroundClassicArathiBasin.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectBattlegroundClassicArathiBasin.ForeColor = global::System.Drawing.Color.White;
			this.selectBattlegroundClassicArathiBasin.FormattingEnabled = true;
			this.selectBattlegroundClassicArathiBasin.Location = new global::System.Drawing.Point(180, 95);
			this.selectBattlegroundClassicArathiBasin.Name = "selectBattlegroundClassicArathiBasin";
			this.selectBattlegroundClassicArathiBasin.Size = new global::System.Drawing.Size(528, 29);
			this.selectBattlegroundClassicArathiBasin.TabIndex = 87;
			this.selectBattlegroundClassicWarsongGulch.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectBattlegroundClassicWarsongGulch.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectBattlegroundClassicWarsongGulch.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectBattlegroundClassicWarsongGulch.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectBattlegroundClassicWarsongGulch.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectBattlegroundClassicWarsongGulch.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectBattlegroundClassicWarsongGulch.ForeColor = global::System.Drawing.Color.White;
			this.selectBattlegroundClassicWarsongGulch.FormattingEnabled = true;
			this.selectBattlegroundClassicWarsongGulch.Location = new global::System.Drawing.Point(180, 60);
			this.selectBattlegroundClassicWarsongGulch.Name = "selectBattlegroundClassicWarsongGulch";
			this.selectBattlegroundClassicWarsongGulch.Size = new global::System.Drawing.Size(528, 29);
			this.selectBattlegroundClassicWarsongGulch.TabIndex = 86;
			this.checkBattlegroundClassicEyeOfTheStorm.Animated = true;
			this.checkBattlegroundClassicEyeOfTheStorm.AutoSize = true;
			this.checkBattlegroundClassicEyeOfTheStorm.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBattlegroundClassicEyeOfTheStorm.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicEyeOfTheStorm.CheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicEyeOfTheStorm.CheckedState.BorderThickness = 0;
			this.checkBattlegroundClassicEyeOfTheStorm.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicEyeOfTheStorm.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkBattlegroundClassicEyeOfTheStorm.Location = new global::System.Drawing.Point(25, 171);
			this.checkBattlegroundClassicEyeOfTheStorm.Name = "checkBattlegroundClassicEyeOfTheStorm";
			this.checkBattlegroundClassicEyeOfTheStorm.Size = new global::System.Drawing.Size(113, 19);
			this.checkBattlegroundClassicEyeOfTheStorm.TabIndex = 85;
			this.checkBattlegroundClassicEyeOfTheStorm.Text = "Eye of the Storm";
			this.checkBattlegroundClassicEyeOfTheStorm.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkBattlegroundClassicEyeOfTheStorm.UncheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicEyeOfTheStorm.UncheckedState.BorderThickness = 1;
			this.checkBattlegroundClassicEyeOfTheStorm.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkBattlegroundClassicEyeOfTheStorm.UseVisualStyleBackColor = false;
			this.checkBattlegroundClassicAlteracValley.Animated = true;
			this.checkBattlegroundClassicAlteracValley.AutoSize = true;
			this.checkBattlegroundClassicAlteracValley.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBattlegroundClassicAlteracValley.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicAlteracValley.CheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicAlteracValley.CheckedState.BorderThickness = 0;
			this.checkBattlegroundClassicAlteracValley.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicAlteracValley.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkBattlegroundClassicAlteracValley.Location = new global::System.Drawing.Point(25, 136);
			this.checkBattlegroundClassicAlteracValley.Name = "checkBattlegroundClassicAlteracValley";
			this.checkBattlegroundClassicAlteracValley.Size = new global::System.Drawing.Size(96, 19);
			this.checkBattlegroundClassicAlteracValley.TabIndex = 84;
			this.checkBattlegroundClassicAlteracValley.Text = "Alterac Valley";
			this.checkBattlegroundClassicAlteracValley.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkBattlegroundClassicAlteracValley.UncheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicAlteracValley.UncheckedState.BorderThickness = 1;
			this.checkBattlegroundClassicAlteracValley.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkBattlegroundClassicAlteracValley.UseVisualStyleBackColor = false;
			this.checkBattlegroundClassicArathiBasin.Animated = true;
			this.checkBattlegroundClassicArathiBasin.AutoSize = true;
			this.checkBattlegroundClassicArathiBasin.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBattlegroundClassicArathiBasin.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicArathiBasin.CheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicArathiBasin.CheckedState.BorderThickness = 0;
			this.checkBattlegroundClassicArathiBasin.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicArathiBasin.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkBattlegroundClassicArathiBasin.Location = new global::System.Drawing.Point(25, 101);
			this.checkBattlegroundClassicArathiBasin.Name = "checkBattlegroundClassicArathiBasin";
			this.checkBattlegroundClassicArathiBasin.Size = new global::System.Drawing.Size(89, 19);
			this.checkBattlegroundClassicArathiBasin.TabIndex = 83;
			this.checkBattlegroundClassicArathiBasin.Text = "Arathi Basin";
			this.checkBattlegroundClassicArathiBasin.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkBattlegroundClassicArathiBasin.UncheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicArathiBasin.UncheckedState.BorderThickness = 1;
			this.checkBattlegroundClassicArathiBasin.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkBattlegroundClassicArathiBasin.UseVisualStyleBackColor = false;
			this.checkBattlegroundClassicWarsongGulch.Animated = true;
			this.checkBattlegroundClassicWarsongGulch.AutoSize = true;
			this.checkBattlegroundClassicWarsongGulch.BackColor = global::System.Drawing.Color.Transparent;
			this.checkBattlegroundClassicWarsongGulch.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicWarsongGulch.CheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicWarsongGulch.CheckedState.BorderThickness = 0;
			this.checkBattlegroundClassicWarsongGulch.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBattlegroundClassicWarsongGulch.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkBattlegroundClassicWarsongGulch.Location = new global::System.Drawing.Point(25, 66);
			this.checkBattlegroundClassicWarsongGulch.Name = "checkBattlegroundClassicWarsongGulch";
			this.checkBattlegroundClassicWarsongGulch.Size = new global::System.Drawing.Size(107, 19);
			this.checkBattlegroundClassicWarsongGulch.TabIndex = 82;
			this.checkBattlegroundClassicWarsongGulch.Text = "Warsong Gulch";
			this.checkBattlegroundClassicWarsongGulch.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkBattlegroundClassicWarsongGulch.UncheckedState.BorderRadius = 0;
			this.checkBattlegroundClassicWarsongGulch.UncheckedState.BorderThickness = 1;
			this.checkBattlegroundClassicWarsongGulch.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkBattlegroundClassicWarsongGulch.UseVisualStyleBackColor = false;
			this.tabChangeProfileSettings.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabChangeProfileSettings.Controls.Add(this.panelTabChangeProfileSettings);
			this.tabChangeProfileSettings.Location = new global::System.Drawing.Point(4, 124);
			this.tabChangeProfileSettings.Name = "tabChangeProfileSettings";
			this.tabChangeProfileSettings.Size = new global::System.Drawing.Size(763, 432);
			this.tabChangeProfileSettings.TabIndex = 15;
			this.tabChangeProfileSettings.Text = "Change Settings";
			this.panelTabChangeProfileSettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabChangeProfileSettings.AutoScroll = true;
			this.panelTabChangeProfileSettings.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabChangeProfileSettings.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabChangeProfileSettings.Controls.Add(this.grpMobs);
			this.panelTabChangeProfileSettings.Controls.Add(this.grpSettingsMode);
			this.panelTabChangeProfileSettings.Controls.Add(this.grpSettingsDistances);
			this.panelTabChangeProfileSettings.Controls.Add(this.grpSettingsMount);
			this.panelTabChangeProfileSettings.Controls.Add(this.grpSettingsLoot);
			this.panelTabChangeProfileSettings.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabChangeProfileSettings.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabChangeProfileSettings.Name = "panelTabChangeProfileSettings";
			this.panelTabChangeProfileSettings.Size = new global::System.Drawing.Size(763, 432);
			this.panelTabChangeProfileSettings.TabIndex = 68;
			this.grpMobs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpMobs.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMobs.Controls.Add(this.panelMobs);
			this.grpMobs.Controls.Add(this.lblMobs);
			this.grpMobs.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMobs.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpMobs.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpMobs.ForeColor = global::System.Drawing.Color.White;
			this.grpMobs.Location = new global::System.Drawing.Point(14, 1063);
			this.grpMobs.Name = "grpMobs";
			this.grpMobs.Size = new global::System.Drawing.Size(633, 290);
			this.grpMobs.TabIndex = 72;
			this.grpMobs.Text = "Attackable Mobs";
			this.panelMobs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelMobs.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelMobs.BorderColor = global::System.Drawing.Color.Gray;
			this.panelMobs.BorderThickness = 1;
			this.panelMobs.Controls.Add(this.richSettingsMobs);
			this.panelMobs.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.panelMobs.Location = new global::System.Drawing.Point(25, 107);
			this.panelMobs.Name = "panelMobs";
			this.panelMobs.Size = new global::System.Drawing.Size(586, 162);
			this.panelMobs.TabIndex = 70;
			this.richSettingsMobs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richSettingsMobs.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.richSettingsMobs.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richSettingsMobs.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.richSettingsMobs.ForeColor = global::System.Drawing.Color.White;
			this.richSettingsMobs.Location = new global::System.Drawing.Point(10, 10);
			this.richSettingsMobs.Name = "richSettingsMobs";
			this.richSettingsMobs.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richSettingsMobs.Size = new global::System.Drawing.Size(567, 143);
			this.richSettingsMobs.TabIndex = 11;
			this.richSettingsMobs.Text = "";
			this.richSettingsMobs.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.richSettingsMobs_KeyUp);
			this.lblMobs.AutoSize = true;
			this.lblMobs.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMobs.Location = new global::System.Drawing.Point(22, 60);
			this.lblMobs.Name = "lblMobs";
			this.lblMobs.Size = new global::System.Drawing.Size(573, 30);
			this.lblMobs.TabIndex = 69;
			this.lblMobs.Text = "Enter all attackable Mobs (by NAME or ID) \"line by line\" or \"comma separated\".\r\nAdd Wildcards with a * to attack Mobs that \"contains\" the name, like *Wolf or *Wolf Name* or Wolf Name*.";
			this.grpSettingsMode.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsMode.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsMode.Controls.Add(this.checkSettingsModeMesh);
			this.grpSettingsMode.Controls.Add(this.checkSettingsModeFollowFleeingTarget);
			this.grpSettingsMode.Controls.Add(this.selectSettingsWaypointMode);
			this.grpSettingsMode.Controls.Add(this.selectSettingsCombatMode);
			this.grpSettingsMode.Controls.Add(this.lblSettingsCombatMode);
			this.grpSettingsMode.Controls.Add(this.lblSettingsWaypointsMode);
			this.grpSettingsMode.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsMode.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsMode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsMode.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsMode.Location = new global::System.Drawing.Point(14, 14);
			this.grpSettingsMode.Name = "grpSettingsMode";
			this.grpSettingsMode.Size = new global::System.Drawing.Size(635, 215);
			this.grpSettingsMode.TabIndex = 68;
			this.grpSettingsMode.Text = "Mode";
			this.checkSettingsModeMesh.Animated = true;
			this.checkSettingsModeMesh.AutoSize = true;
			this.checkSettingsModeMesh.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsModeMesh.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsModeMesh.CheckedState.BorderRadius = 0;
			this.checkSettingsModeMesh.CheckedState.BorderThickness = 0;
			this.checkSettingsModeMesh.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsModeMesh.Location = new global::System.Drawing.Point(180, 179);
			this.checkSettingsModeMesh.Name = "checkSettingsModeMesh";
			this.checkSettingsModeMesh.Size = new global::System.Drawing.Size(226, 19);
			this.checkSettingsModeMesh.TabIndex = 72;
			this.checkSettingsModeMesh.Text = "Use Auto-Navigation (recommended)";
			this.checkSettingsModeMesh.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsModeMesh.UncheckedState.BorderRadius = 0;
			this.checkSettingsModeMesh.UncheckedState.BorderThickness = 1;
			this.checkSettingsModeMesh.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsModeMesh.UseVisualStyleBackColor = false;
			this.checkSettingsModeMesh.CheckedChanged += new global::System.EventHandler(this.checkSettingsModeMesh_CheckedChanged);
			this.checkSettingsModeFollowFleeingTarget.Animated = true;
			this.checkSettingsModeFollowFleeingTarget.AutoSize = true;
			this.checkSettingsModeFollowFleeingTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsModeFollowFleeingTarget.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsModeFollowFleeingTarget.CheckedState.BorderRadius = 0;
			this.checkSettingsModeFollowFleeingTarget.CheckedState.BorderThickness = 0;
			this.checkSettingsModeFollowFleeingTarget.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsModeFollowFleeingTarget.Location = new global::System.Drawing.Point(180, 150);
			this.checkSettingsModeFollowFleeingTarget.Name = "checkSettingsModeFollowFleeingTarget";
			this.checkSettingsModeFollowFleeingTarget.Size = new global::System.Drawing.Size(140, 19);
			this.checkSettingsModeFollowFleeingTarget.TabIndex = 71;
			this.checkSettingsModeFollowFleeingTarget.Text = "Follow fleeing Targets";
			this.checkSettingsModeFollowFleeingTarget.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsModeFollowFleeingTarget.UncheckedState.BorderRadius = 0;
			this.checkSettingsModeFollowFleeingTarget.UncheckedState.BorderThickness = 1;
			this.checkSettingsModeFollowFleeingTarget.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsModeFollowFleeingTarget.UseVisualStyleBackColor = false;
			this.selectSettingsWaypointMode.BackColor = global::System.Drawing.Color.Transparent;
			this.selectSettingsWaypointMode.BorderColor = global::System.Drawing.Color.Gray;
			this.selectSettingsWaypointMode.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectSettingsWaypointMode.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectSettingsWaypointMode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectSettingsWaypointMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectSettingsWaypointMode.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectSettingsWaypointMode.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsWaypointMode.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsWaypointMode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectSettingsWaypointMode.ForeColor = global::System.Drawing.Color.White;
			this.selectSettingsWaypointMode.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectSettingsWaypointMode.ItemHeight = 24;
			this.selectSettingsWaypointMode.Items.AddRange(new object[]
			{
				"Best",
				"Closest",
				"Straight"
			});
			this.selectSettingsWaypointMode.Location = new global::System.Drawing.Point(180, 105);
			this.selectSettingsWaypointMode.Name = "selectSettingsWaypointMode";
			this.selectSettingsWaypointMode.Size = new global::System.Drawing.Size(140, 30);
			this.selectSettingsWaypointMode.TabIndex = 70;
			this.selectSettingsCombatMode.BackColor = global::System.Drawing.Color.Transparent;
			this.selectSettingsCombatMode.BorderColor = global::System.Drawing.Color.Gray;
			this.selectSettingsCombatMode.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectSettingsCombatMode.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectSettingsCombatMode.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectSettingsCombatMode.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectSettingsCombatMode.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectSettingsCombatMode.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsCombatMode.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectSettingsCombatMode.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectSettingsCombatMode.ForeColor = global::System.Drawing.Color.White;
			this.selectSettingsCombatMode.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectSettingsCombatMode.ItemHeight = 24;
			this.selectSettingsCombatMode.Items.AddRange(new object[]
			{
				"Offensive",
				"Defensive",
				"Gather",
				"Ignore",
				"PvP (Offensive)",
				"PvP (Defensive)"
			});
			this.selectSettingsCombatMode.Location = new global::System.Drawing.Point(180, 60);
			this.selectSettingsCombatMode.Name = "selectSettingsCombatMode";
			this.selectSettingsCombatMode.Size = new global::System.Drawing.Size(140, 30);
			this.selectSettingsCombatMode.TabIndex = 69;
			this.lblSettingsCombatMode.AutoSize = true;
			this.lblSettingsCombatMode.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsCombatMode.Location = new global::System.Drawing.Point(22, 66);
			this.lblSettingsCombatMode.Name = "lblSettingsCombatMode";
			this.lblSettingsCombatMode.Size = new global::System.Drawing.Size(53, 15);
			this.lblSettingsCombatMode.TabIndex = 68;
			this.lblSettingsCombatMode.Text = "Combat:";
			this.lblSettingsWaypointsMode.AutoSize = true;
			this.lblSettingsWaypointsMode.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsWaypointsMode.Location = new global::System.Drawing.Point(22, 111);
			this.lblSettingsWaypointsMode.Name = "lblSettingsWaypointsMode";
			this.lblSettingsWaypointsMode.Size = new global::System.Drawing.Size(66, 15);
			this.lblSettingsWaypointsMode.TabIndex = 67;
			this.lblSettingsWaypointsMode.Text = "Waypoints:";
			this.grpSettingsDistances.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsDistances.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsDistances.Controls.Add(this.lblSettingsDistancesIsReachableZAxis);
			this.grpSettingsDistances.Controls.Add(this.lblSettingsDistancesIsReachable);
			this.grpSettingsDistances.Controls.Add(this.txtSettingsDistancesIsReachable);
			this.grpSettingsDistances.Controls.Add(this.lblSettingsDistancesMobGroupDetection);
			this.grpSettingsDistances.Controls.Add(this.lblSettingsDistancesInfo);
			this.grpSettingsDistances.Controls.Add(this.lblSettingsDistancesMobGroup);
			this.grpSettingsDistances.Controls.Add(this.txtSettingsDistancesMobGroup);
			this.grpSettingsDistances.Controls.Add(this.lblSettingsDistancesLocation);
			this.grpSettingsDistances.Controls.Add(this.txtSettingsDistancesLocation);
			this.grpSettingsDistances.Controls.Add(this.lblSettingsDistancesWaypoint);
			this.grpSettingsDistances.Controls.Add(this.txtSettingsDistancesWaypoint);
			this.grpSettingsDistances.Controls.Add(this.sepSettingsDistances1);
			this.grpSettingsDistances.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsDistances.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsDistances.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsDistances.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsDistances.Location = new global::System.Drawing.Point(14, 752);
			this.grpSettingsDistances.Name = "grpSettingsDistances";
			this.grpSettingsDistances.Size = new global::System.Drawing.Size(633, 296);
			this.grpSettingsDistances.TabIndex = 71;
			this.grpSettingsDistances.Text = "Distances";
			this.lblSettingsDistancesIsReachableZAxis.AutoSize = true;
			this.lblSettingsDistancesIsReachableZAxis.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsDistancesIsReachableZAxis.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsDistancesIsReachableZAxis.Location = new global::System.Drawing.Point(260, 251);
			this.lblSettingsDistancesIsReachableZAxis.Name = "lblSettingsDistancesIsReachableZAxis";
			this.lblSettingsDistancesIsReachableZAxis.Size = new global::System.Drawing.Size(49, 15);
			this.lblSettingsDistancesIsReachableZAxis.TabIndex = 90;
			this.lblSettingsDistancesIsReachableZAxis.Text = "(Z-Axis)";
			this.lblSettingsDistancesIsReachable.AutoSize = true;
			this.lblSettingsDistancesIsReachable.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsDistancesIsReachable.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsDistancesIsReachable.Location = new global::System.Drawing.Point(22, 251);
			this.lblSettingsDistancesIsReachable.Name = "lblSettingsDistancesIsReachable";
			this.lblSettingsDistancesIsReachable.Size = new global::System.Drawing.Size(89, 15);
			this.lblSettingsDistancesIsReachable.TabIndex = 89;
			this.lblSettingsDistancesIsReachable.Text = "General Height:";
			this.txtSettingsDistancesIsReachable.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesIsReachable.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsDistancesIsReachable.DefaultText = "4.5";
			this.txtSettingsDistancesIsReachable.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesIsReachable.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsDistancesIsReachable.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesIsReachable.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesIsReachable.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsDistancesIsReachable.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsDistancesIsReachable.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsDistancesIsReachable.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesIsReachable.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesIsReachable.Location = new global::System.Drawing.Point(180, 244);
			this.txtSettingsDistancesIsReachable.MaxLength = 3;
			this.txtSettingsDistancesIsReachable.Name = "txtSettingsDistancesIsReachable";
			this.txtSettingsDistancesIsReachable.PasswordChar = '\0';
			this.txtSettingsDistancesIsReachable.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesIsReachable.PlaceholderText = "";
			this.txtSettingsDistancesIsReachable.SelectedText = "";
			this.txtSettingsDistancesIsReachable.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsDistancesIsReachable.TabIndex = 88;
			this.lblSettingsDistancesMobGroupDetection.AutoSize = true;
			this.lblSettingsDistancesMobGroupDetection.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsDistancesMobGroupDetection.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsDistancesMobGroupDetection.Location = new global::System.Drawing.Point(260, 215);
			this.lblSettingsDistancesMobGroupDetection.Name = "lblSettingsDistancesMobGroupDetection";
			this.lblSettingsDistancesMobGroupDetection.Size = new global::System.Drawing.Size(130, 15);
			this.lblSettingsDistancesMobGroupDetection.TabIndex = 87;
			this.lblSettingsDistancesMobGroupDetection.Text = "(Mob Group Detection)";
			this.lblSettingsDistancesInfo.AutoSize = true;
			this.lblSettingsDistancesInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsDistancesInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsDistancesInfo.Location = new global::System.Drawing.Point(22, 60);
			this.lblSettingsDistancesInfo.Name = "lblSettingsDistancesInfo";
			this.lblSettingsDistancesInfo.Size = new global::System.Drawing.Size(312, 30);
			this.lblSettingsDistancesInfo.TabIndex = 86;
			this.lblSettingsDistancesInfo.Text = "Jack searches for Mobs around your own current location.\r\nEnter here the radii in yards in which Jack should search.";
			this.lblSettingsDistancesMobGroup.AutoSize = true;
			this.lblSettingsDistancesMobGroup.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsDistancesMobGroup.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsDistancesMobGroup.Location = new global::System.Drawing.Point(22, 215);
			this.lblSettingsDistancesMobGroup.Name = "lblSettingsDistancesMobGroup";
			this.lblSettingsDistancesMobGroup.Size = new global::System.Drawing.Size(83, 15);
			this.lblSettingsDistancesMobGroup.TabIndex = 85;
			this.lblSettingsDistancesMobGroup.Text = "Around Mobs:";
			this.txtSettingsDistancesMobGroup.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesMobGroup.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsDistancesMobGroup.DefaultText = "15";
			this.txtSettingsDistancesMobGroup.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesMobGroup.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsDistancesMobGroup.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesMobGroup.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesMobGroup.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsDistancesMobGroup.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsDistancesMobGroup.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsDistancesMobGroup.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesMobGroup.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesMobGroup.Location = new global::System.Drawing.Point(180, 208);
			this.txtSettingsDistancesMobGroup.MaxLength = 2;
			this.txtSettingsDistancesMobGroup.Name = "txtSettingsDistancesMobGroup";
			this.txtSettingsDistancesMobGroup.PasswordChar = '\0';
			this.txtSettingsDistancesMobGroup.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesMobGroup.PlaceholderText = "";
			this.txtSettingsDistancesMobGroup.SelectedText = "";
			this.txtSettingsDistancesMobGroup.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsDistancesMobGroup.TabIndex = 84;
			this.lblSettingsDistancesLocation.AutoSize = true;
			this.lblSettingsDistancesLocation.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsDistancesLocation.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsDistancesLocation.Location = new global::System.Drawing.Point(22, 179);
			this.lblSettingsDistancesLocation.Name = "lblSettingsDistancesLocation";
			this.lblSettingsDistancesLocation.Size = new global::System.Drawing.Size(122, 15);
			this.lblSettingsDistancesLocation.TabIndex = 83;
			this.lblSettingsDistancesLocation.Text = "Around own location:";
			this.txtSettingsDistancesLocation.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesLocation.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsDistancesLocation.DefaultText = "40";
			this.txtSettingsDistancesLocation.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesLocation.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsDistancesLocation.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesLocation.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesLocation.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsDistancesLocation.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsDistancesLocation.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsDistancesLocation.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesLocation.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesLocation.Location = new global::System.Drawing.Point(180, 172);
			this.txtSettingsDistancesLocation.MaxLength = 2;
			this.txtSettingsDistancesLocation.Name = "txtSettingsDistancesLocation";
			this.txtSettingsDistancesLocation.PasswordChar = '\0';
			this.txtSettingsDistancesLocation.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesLocation.PlaceholderText = "";
			this.txtSettingsDistancesLocation.SelectedText = "";
			this.txtSettingsDistancesLocation.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsDistancesLocation.TabIndex = 82;
			this.lblSettingsDistancesWaypoint.AutoSize = true;
			this.lblSettingsDistancesWaypoint.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsDistancesWaypoint.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsDistancesWaypoint.Location = new global::System.Drawing.Point(22, 143);
			this.lblSettingsDistancesWaypoint.Name = "lblSettingsDistancesWaypoint";
			this.lblSettingsDistancesWaypoint.Size = new global::System.Drawing.Size(109, 15);
			this.lblSettingsDistancesWaypoint.TabIndex = 80;
			this.lblSettingsDistancesWaypoint.Text = "Around Waypoints:";
			this.txtSettingsDistancesWaypoint.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesWaypoint.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsDistancesWaypoint.DefaultText = "25";
			this.txtSettingsDistancesWaypoint.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesWaypoint.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsDistancesWaypoint.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesWaypoint.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsDistancesWaypoint.Enabled = false;
			this.txtSettingsDistancesWaypoint.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsDistancesWaypoint.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsDistancesWaypoint.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsDistancesWaypoint.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesWaypoint.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsDistancesWaypoint.Location = new global::System.Drawing.Point(180, 136);
			this.txtSettingsDistancesWaypoint.MaxLength = 2;
			this.txtSettingsDistancesWaypoint.Name = "txtSettingsDistancesWaypoint";
			this.txtSettingsDistancesWaypoint.PasswordChar = '\0';
			this.txtSettingsDistancesWaypoint.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsDistancesWaypoint.PlaceholderText = "";
			this.txtSettingsDistancesWaypoint.SelectedText = "";
			this.txtSettingsDistancesWaypoint.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsDistancesWaypoint.TabIndex = 79;
			this.sepSettingsDistances1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepSettingsDistances1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepSettingsDistances1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepSettingsDistances1.Location = new global::System.Drawing.Point(20, 106);
			this.sepSettingsDistances1.Name = "sepSettingsDistances1";
			this.sepSettingsDistances1.Size = new global::System.Drawing.Size(593, 10);
			this.sepSettingsDistances1.TabIndex = 77;
			this.grpSettingsMount.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsMount.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsMount.Controls.Add(this.lblSettingsFlightMount);
			this.grpSettingsMount.Controls.Add(this.checkSettingsFlightMount);
			this.grpSettingsMount.Controls.Add(this.lblSettingsGroundMount);
			this.grpSettingsMount.Controls.Add(this.checkSettingsGroundMount);
			this.grpSettingsMount.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsMount.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsMount.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsMount.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsMount.Location = new global::System.Drawing.Point(14, 244);
			this.grpSettingsMount.Name = "grpSettingsMount";
			this.grpSettingsMount.Size = new global::System.Drawing.Size(635, 123);
			this.grpSettingsMount.TabIndex = 69;
			this.grpSettingsMount.Text = "Mount";
			this.lblSettingsFlightMount.AutoSize = true;
			this.lblSettingsFlightMount.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsFlightMount.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsFlightMount.Location = new global::System.Drawing.Point(22, 85);
			this.lblSettingsFlightMount.Name = "lblSettingsFlightMount";
			this.lblSettingsFlightMount.Size = new global::System.Drawing.Size(40, 15);
			this.lblSettingsFlightMount.TabIndex = 73;
			this.lblSettingsFlightMount.Text = "Flight:";
			this.checkSettingsFlightMount.Animated = true;
			this.checkSettingsFlightMount.AutoSize = true;
			this.checkSettingsFlightMount.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsFlightMount.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsFlightMount.CheckedState.BorderRadius = 0;
			this.checkSettingsFlightMount.CheckedState.BorderThickness = 0;
			this.checkSettingsFlightMount.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsFlightMount.Location = new global::System.Drawing.Point(180, 85);
			this.checkSettingsFlightMount.Name = "checkSettingsFlightMount";
			this.checkSettingsFlightMount.Size = new global::System.Drawing.Size(97, 19);
			this.checkSettingsFlightMount.TabIndex = 74;
			this.checkSettingsFlightMount.Text = "Use if learned";
			this.checkSettingsFlightMount.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsFlightMount.UncheckedState.BorderRadius = 0;
			this.checkSettingsFlightMount.UncheckedState.BorderThickness = 1;
			this.checkSettingsFlightMount.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsFlightMount.UseVisualStyleBackColor = false;
			this.checkSettingsFlightMount.CheckedChanged += new global::System.EventHandler(this.checkSettingsFlightMount_CheckedChanged);
			this.lblSettingsGroundMount.AutoSize = true;
			this.lblSettingsGroundMount.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsGroundMount.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsGroundMount.Location = new global::System.Drawing.Point(22, 60);
			this.lblSettingsGroundMount.Name = "lblSettingsGroundMount";
			this.lblSettingsGroundMount.Size = new global::System.Drawing.Size(50, 15);
			this.lblSettingsGroundMount.TabIndex = 71;
			this.lblSettingsGroundMount.Text = "Ground:";
			this.checkSettingsGroundMount.Animated = true;
			this.checkSettingsGroundMount.AutoSize = true;
			this.checkSettingsGroundMount.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsGroundMount.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsGroundMount.CheckedState.BorderRadius = 0;
			this.checkSettingsGroundMount.CheckedState.BorderThickness = 0;
			this.checkSettingsGroundMount.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsGroundMount.Location = new global::System.Drawing.Point(180, 60);
			this.checkSettingsGroundMount.Name = "checkSettingsGroundMount";
			this.checkSettingsGroundMount.Size = new global::System.Drawing.Size(97, 19);
			this.checkSettingsGroundMount.TabIndex = 72;
			this.checkSettingsGroundMount.Text = "Use if learned";
			this.checkSettingsGroundMount.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsGroundMount.UncheckedState.BorderRadius = 0;
			this.checkSettingsGroundMount.UncheckedState.BorderThickness = 1;
			this.checkSettingsGroundMount.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsGroundMount.UseVisualStyleBackColor = false;
			this.checkSettingsGroundMount.CheckedChanged += new global::System.EventHandler(this.checkSettingsGroundMount_CheckedChanged);
			this.grpSettingsLoot.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsLoot.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootAvoidElitesDistanceInfo);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootAvoidElitesDistance);
			this.grpSettingsLoot.Controls.Add(this.txtSettingsLootAvoidElitesDistance);
			this.grpSettingsLoot.Controls.Add(this.checkSettingsLootGatherMobs);
			this.grpSettingsLoot.Controls.Add(this.txtSettingsLootQuestItems);
			this.grpSettingsLoot.Controls.Add(this.imgModuleGather);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootGatherDistance);
			this.grpSettingsLoot.Controls.Add(this.txtSettingsLootGatherDistance);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootMaxPathDistance);
			this.grpSettingsLoot.Controls.Add(this.txtSettingsLootMaxPathDistance);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootDistance);
			this.grpSettingsLoot.Controls.Add(this.txtSettingsLootDistance);
			this.grpSettingsLoot.Controls.Add(this.sepOverlayESPObjects2);
			this.grpSettingsLoot.Controls.Add(this.checkSettingsLootSkinning);
			this.grpSettingsLoot.Controls.Add(this.checkSettingsLoot);
			this.grpSettingsLoot.Controls.Add(this.checkSettingsLootHerbalism);
			this.grpSettingsLoot.Controls.Add(this.checkSettingsLootMining);
			this.grpSettingsLoot.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsLoot.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsLoot.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsLoot.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsLoot.Location = new global::System.Drawing.Point(14, 382);
			this.grpSettingsLoot.Name = "grpSettingsLoot";
			this.grpSettingsLoot.Size = new global::System.Drawing.Size(635, 355);
			this.grpSettingsLoot.TabIndex = 70;
			this.grpSettingsLoot.Text = "Gathering";
			this.lblSettingsLootAvoidElitesDistanceInfo.AutoSize = true;
			this.lblSettingsLootAvoidElitesDistanceInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootAvoidElitesDistanceInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootAvoidElitesDistanceInfo.Location = new global::System.Drawing.Point(260, 311);
			this.lblSettingsLootAvoidElitesDistanceInfo.Name = "lblSettingsLootAvoidElitesDistanceInfo";
			this.lblSettingsLootAvoidElitesDistanceInfo.Size = new global::System.Drawing.Size(118, 15);
			this.lblSettingsLootAvoidElitesDistanceInfo.TabIndex = 102;
			this.lblSettingsLootAvoidElitesDistanceInfo.Text = "yards around a node.";
			this.lblSettingsLootAvoidElitesDistance.AutoSize = true;
			this.lblSettingsLootAvoidElitesDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootAvoidElitesDistance.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootAvoidElitesDistance.Location = new global::System.Drawing.Point(22, 311);
			this.lblSettingsLootAvoidElitesDistance.Name = "lblSettingsLootAvoidElitesDistance";
			this.lblSettingsLootAvoidElitesDistance.Size = new global::System.Drawing.Size(107, 15);
			this.lblSettingsLootAvoidElitesDistance.TabIndex = 101;
			this.lblSettingsLootAvoidElitesDistance.Text = "Avoid Elites within:";
			this.txtSettingsLootAvoidElitesDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootAvoidElitesDistance.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsLootAvoidElitesDistance.DefaultText = "40";
			this.txtSettingsLootAvoidElitesDistance.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootAvoidElitesDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsLootAvoidElitesDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootAvoidElitesDistance.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootAvoidElitesDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsLootAvoidElitesDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsLootAvoidElitesDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsLootAvoidElitesDistance.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsLootAvoidElitesDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsLootAvoidElitesDistance.Location = new global::System.Drawing.Point(180, 304);
			this.txtSettingsLootAvoidElitesDistance.MaxLength = 3;
			this.txtSettingsLootAvoidElitesDistance.Name = "txtSettingsLootAvoidElitesDistance";
			this.txtSettingsLootAvoidElitesDistance.PasswordChar = '\0';
			this.txtSettingsLootAvoidElitesDistance.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootAvoidElitesDistance.PlaceholderText = "";
			this.txtSettingsLootAvoidElitesDistance.SelectedText = "";
			this.txtSettingsLootAvoidElitesDistance.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsLootAvoidElitesDistance.TabIndex = 100;
			this.checkSettingsLootGatherMobs.Animated = true;
			this.checkSettingsLootGatherMobs.AutoSize = true;
			this.checkSettingsLootGatherMobs.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsLootGatherMobs.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootGatherMobs.CheckedState.BorderRadius = 0;
			this.checkSettingsLootGatherMobs.CheckedState.BorderThickness = 0;
			this.checkSettingsLootGatherMobs.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootGatherMobs.ForeColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootGatherMobs.Location = new global::System.Drawing.Point(180, 135);
			this.checkSettingsLootGatherMobs.Name = "checkSettingsLootGatherMobs";
			this.checkSettingsLootGatherMobs.Size = new global::System.Drawing.Size(94, 19);
			this.checkSettingsLootGatherMobs.TabIndex = 96;
			this.checkSettingsLootGatherMobs.Text = "Gather Mobs";
			this.checkSettingsLootGatherMobs.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootGatherMobs.UncheckedState.BorderRadius = 0;
			this.checkSettingsLootGatherMobs.UncheckedState.BorderThickness = 1;
			this.checkSettingsLootGatherMobs.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsLootGatherMobs.UseVisualStyleBackColor = false;
			this.checkSettingsLootGatherMobs.CheckedChanged += new global::System.EventHandler(this.checkSettingsLootGatherMobs_CheckedChanged);
			this.txtSettingsLootQuestItems.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtSettingsLootQuestItems.BorderColor = global::System.Drawing.Color.DimGray;
			this.txtSettingsLootQuestItems.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsLootQuestItems.DefaultText = "";
			this.txtSettingsLootQuestItems.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootQuestItems.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsLootQuestItems.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootQuestItems.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootQuestItems.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsLootQuestItems.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsLootQuestItems.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsLootQuestItems.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsLootQuestItems.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsLootQuestItems.Location = new global::System.Drawing.Point(405, 60);
			this.txtSettingsLootQuestItems.MaxLength = 800;
			this.txtSettingsLootQuestItems.Multiline = true;
			this.txtSettingsLootQuestItems.Name = "txtSettingsLootQuestItems";
			this.txtSettingsLootQuestItems.PasswordChar = '\0';
			this.txtSettingsLootQuestItems.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootQuestItems.PlaceholderText = "Quest Items (by NAME or ID)";
			this.txtSettingsLootQuestItems.SelectedText = "";
			this.txtSettingsLootQuestItems.Size = new global::System.Drawing.Size(206, 94);
			this.txtSettingsLootQuestItems.TabIndex = 95;
			this.txtSettingsLootQuestItems.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.txtSettingsLootQuestItems_MouseClick);
			this.imgModuleGather.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleGather.Image = global::Jack.Properties.Resources.module_gathering;
			this.imgModuleGather.ImageRotate = 0f;
			this.imgModuleGather.Location = new global::System.Drawing.Point(496, 7);
			this.imgModuleGather.Name = "imgModuleGather";
			this.imgModuleGather.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleGather.TabIndex = 90;
			this.imgModuleGather.TabStop = false;
			this.lblSettingsLootGatherDistance.AutoSize = true;
			this.lblSettingsLootGatherDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootGatherDistance.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootGatherDistance.Location = new global::System.Drawing.Point(22, 275);
			this.lblSettingsLootGatherDistance.Name = "lblSettingsLootGatherDistance";
			this.lblSettingsLootGatherDistance.Size = new global::System.Drawing.Size(93, 15);
			this.lblSettingsLootGatherDistance.TabIndex = 85;
			this.lblSettingsLootGatherDistance.Text = "Gather Distance:";
			this.txtSettingsLootGatherDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootGatherDistance.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsLootGatherDistance.DefaultText = "4";
			this.txtSettingsLootGatherDistance.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootGatherDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsLootGatherDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootGatherDistance.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootGatherDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsLootGatherDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsLootGatherDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsLootGatherDistance.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsLootGatherDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsLootGatherDistance.Location = new global::System.Drawing.Point(180, 268);
			this.txtSettingsLootGatherDistance.MaxLength = 1;
			this.txtSettingsLootGatherDistance.Name = "txtSettingsLootGatherDistance";
			this.txtSettingsLootGatherDistance.PasswordChar = '\0';
			this.txtSettingsLootGatherDistance.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootGatherDistance.PlaceholderText = "";
			this.txtSettingsLootGatherDistance.SelectedText = "";
			this.txtSettingsLootGatherDistance.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsLootGatherDistance.TabIndex = 84;
			this.lblSettingsLootMaxPathDistance.AutoSize = true;
			this.lblSettingsLootMaxPathDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootMaxPathDistance.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootMaxPathDistance.Location = new global::System.Drawing.Point(22, 239);
			this.lblSettingsLootMaxPathDistance.Name = "lblSettingsLootMaxPathDistance";
			this.lblSettingsLootMaxPathDistance.Size = new global::System.Drawing.Size(111, 15);
			this.lblSettingsLootMaxPathDistance.TabIndex = 83;
			this.lblSettingsLootMaxPathDistance.Text = "Max. Path Distance:";
			this.txtSettingsLootMaxPathDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootMaxPathDistance.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsLootMaxPathDistance.DefaultText = "100";
			this.txtSettingsLootMaxPathDistance.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootMaxPathDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsLootMaxPathDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootMaxPathDistance.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootMaxPathDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsLootMaxPathDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsLootMaxPathDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsLootMaxPathDistance.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsLootMaxPathDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsLootMaxPathDistance.Location = new global::System.Drawing.Point(180, 232);
			this.txtSettingsLootMaxPathDistance.MaxLength = 4;
			this.txtSettingsLootMaxPathDistance.Name = "txtSettingsLootMaxPathDistance";
			this.txtSettingsLootMaxPathDistance.PasswordChar = '\0';
			this.txtSettingsLootMaxPathDistance.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootMaxPathDistance.PlaceholderText = "";
			this.txtSettingsLootMaxPathDistance.SelectedText = "";
			this.txtSettingsLootMaxPathDistance.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsLootMaxPathDistance.TabIndex = 82;
			this.lblSettingsLootDistance.AutoSize = true;
			this.lblSettingsLootDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootDistance.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootDistance.Location = new global::System.Drawing.Point(22, 203);
			this.lblSettingsLootDistance.Name = "lblSettingsLootDistance";
			this.lblSettingsLootDistance.Size = new global::System.Drawing.Size(109, 15);
			this.lblSettingsLootDistance.TabIndex = 80;
			this.lblSettingsLootDistance.Text = "Detection Distance:";
			this.txtSettingsLootDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootDistance.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtSettingsLootDistance.DefaultText = "40";
			this.txtSettingsLootDistance.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtSettingsLootDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootDistance.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtSettingsLootDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtSettingsLootDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtSettingsLootDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtSettingsLootDistance.ForeColor = global::System.Drawing.Color.White;
			this.txtSettingsLootDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtSettingsLootDistance.Location = new global::System.Drawing.Point(180, 196);
			this.txtSettingsLootDistance.MaxLength = 3;
			this.txtSettingsLootDistance.Name = "txtSettingsLootDistance";
			this.txtSettingsLootDistance.PasswordChar = '\0';
			this.txtSettingsLootDistance.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtSettingsLootDistance.PlaceholderText = "";
			this.txtSettingsLootDistance.SelectedText = "";
			this.txtSettingsLootDistance.Size = new global::System.Drawing.Size(68, 30);
			this.txtSettingsLootDistance.TabIndex = 79;
			this.sepOverlayESPObjects2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepOverlayESPObjects2.BackColor = global::System.Drawing.Color.Transparent;
			this.sepOverlayESPObjects2.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepOverlayESPObjects2.Location = new global::System.Drawing.Point(20, 167);
			this.sepOverlayESPObjects2.Name = "sepOverlayESPObjects2";
			this.sepOverlayESPObjects2.Size = new global::System.Drawing.Size(595, 10);
			this.sepOverlayESPObjects2.TabIndex = 77;
			this.checkSettingsLootSkinning.Animated = true;
			this.checkSettingsLootSkinning.AutoSize = true;
			this.checkSettingsLootSkinning.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsLootSkinning.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootSkinning.CheckedState.BorderRadius = 0;
			this.checkSettingsLootSkinning.CheckedState.BorderThickness = 0;
			this.checkSettingsLootSkinning.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootSkinning.ForeColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootSkinning.Location = new global::System.Drawing.Point(180, 110);
			this.checkSettingsLootSkinning.Name = "checkSettingsLootSkinning";
			this.checkSettingsLootSkinning.Size = new global::System.Drawing.Size(72, 19);
			this.checkSettingsLootSkinning.TabIndex = 76;
			this.checkSettingsLootSkinning.Text = "Skinning";
			this.checkSettingsLootSkinning.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootSkinning.UncheckedState.BorderRadius = 0;
			this.checkSettingsLootSkinning.UncheckedState.BorderThickness = 1;
			this.checkSettingsLootSkinning.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsLootSkinning.UseVisualStyleBackColor = false;
			this.checkSettingsLootSkinning.CheckedChanged += new global::System.EventHandler(this.checkSettingsLootSkinning_CheckedChanged);
			this.checkSettingsLoot.Animated = true;
			this.checkSettingsLoot.AutoSize = true;
			this.checkSettingsLoot.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsLoot.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLoot.CheckedState.BorderRadius = 0;
			this.checkSettingsLoot.CheckedState.BorderThickness = 0;
			this.checkSettingsLoot.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLoot.Location = new global::System.Drawing.Point(25, 60);
			this.checkSettingsLoot.Name = "checkSettingsLoot";
			this.checkSettingsLoot.Size = new global::System.Drawing.Size(50, 19);
			this.checkSettingsLoot.TabIndex = 75;
			this.checkSettingsLoot.Text = "Loot";
			this.checkSettingsLoot.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLoot.UncheckedState.BorderRadius = 0;
			this.checkSettingsLoot.UncheckedState.BorderThickness = 1;
			this.checkSettingsLoot.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsLoot.UseVisualStyleBackColor = false;
			this.checkSettingsLootHerbalism.Animated = true;
			this.checkSettingsLootHerbalism.AutoSize = true;
			this.checkSettingsLootHerbalism.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsLootHerbalism.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootHerbalism.CheckedState.BorderRadius = 0;
			this.checkSettingsLootHerbalism.CheckedState.BorderThickness = 0;
			this.checkSettingsLootHerbalism.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootHerbalism.ForeColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootHerbalism.Location = new global::System.Drawing.Point(180, 85);
			this.checkSettingsLootHerbalism.Name = "checkSettingsLootHerbalism";
			this.checkSettingsLootHerbalism.Size = new global::System.Drawing.Size(80, 19);
			this.checkSettingsLootHerbalism.TabIndex = 74;
			this.checkSettingsLootHerbalism.Text = "Herbalism";
			this.checkSettingsLootHerbalism.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootHerbalism.UncheckedState.BorderRadius = 0;
			this.checkSettingsLootHerbalism.UncheckedState.BorderThickness = 1;
			this.checkSettingsLootHerbalism.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsLootHerbalism.UseVisualStyleBackColor = false;
			this.checkSettingsLootHerbalism.CheckedChanged += new global::System.EventHandler(this.checkSettingsLootHerbalism_CheckedChanged);
			this.checkSettingsLootMining.Animated = true;
			this.checkSettingsLootMining.AutoSize = true;
			this.checkSettingsLootMining.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsLootMining.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootMining.CheckedState.BorderRadius = 0;
			this.checkSettingsLootMining.CheckedState.BorderThickness = 0;
			this.checkSettingsLootMining.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLootMining.ForeColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootMining.Location = new global::System.Drawing.Point(180, 60);
			this.checkSettingsLootMining.Name = "checkSettingsLootMining";
			this.checkSettingsLootMining.Size = new global::System.Drawing.Size(64, 19);
			this.checkSettingsLootMining.TabIndex = 72;
			this.checkSettingsLootMining.Text = "Mining";
			this.checkSettingsLootMining.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkSettingsLootMining.UncheckedState.BorderRadius = 0;
			this.checkSettingsLootMining.UncheckedState.BorderThickness = 1;
			this.checkSettingsLootMining.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkSettingsLootMining.UseVisualStyleBackColor = false;
			this.checkSettingsLootMining.CheckedChanged += new global::System.EventHandler(this.checkSettingsLootMining_CheckedChanged);
			this.panelTitle2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle2.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle2.Controls.Add(this.imgTitleEdge2);
			this.panelTitle2.Controls.Add(this.lblTitle2);
			this.panelTitle2.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle2.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle2.Name = "panelTitle2";
			this.panelTitle2.Size = new global::System.Drawing.Size(550, 38);
			this.panelTitle2.TabIndex = 66;
			this.imgTitleEdge2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge2.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge2.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge2.ImageRotate = 0f;
			this.imgTitleEdge2.Location = new global::System.Drawing.Point(480, 0);
			this.imgTitleEdge2.Name = "imgTitleEdge2";
			this.imgTitleEdge2.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge2.TabIndex = 66;
			this.imgTitleEdge2.TabStop = false;
			this.lblTitle2.AutoSize = true;
			this.lblTitle2.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle2.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle2.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle2.Name = "lblTitle2";
			this.lblTitle2.Size = new global::System.Drawing.Size(171, 15);
			this.lblTitle2.TabIndex = 65;
			this.lblTitle2.Text = "Event Manager";
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.grpSelectionCurrent);
			this.panelBox1.Controls.Add(this.grpSelectionAroundMe);
			this.panelBox1.Controls.Add(this.grpSelectionMouseover);
			this.panelBox1.Controls.Add(this.grpSelectionTarget);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(314, 628);
			this.panelBox1.TabIndex = 69;
			this.grpSelectionCurrent.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSelectionCurrent.BorderColor = global::System.Drawing.Color.FromArgb(62, 73, 92);
			this.grpSelectionCurrent.Controls.Add(this.lblCurrentTargetLocation);
			this.grpSelectionCurrent.Controls.Add(this.lblCurrentTarget);
			this.grpSelectionCurrent.CustomBorderColor = global::System.Drawing.Color.FromArgb(62, 73, 92);
			this.grpSelectionCurrent.FillColor = global::System.Drawing.Color.FromArgb(40, 46, 56);
			this.grpSelectionCurrent.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSelectionCurrent.ForeColor = global::System.Drawing.Color.White;
			this.grpSelectionCurrent.Location = new global::System.Drawing.Point(14, 53);
			this.grpSelectionCurrent.Name = "grpSelectionCurrent";
			this.grpSelectionCurrent.Size = new global::System.Drawing.Size(286, 95);
			this.grpSelectionCurrent.TabIndex = 70;
			this.grpSelectionCurrent.Text = "Current Selection";
			this.lblCurrentTargetLocation.AutoSize = true;
			this.lblCurrentTargetLocation.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCurrentTargetLocation.Font = new global::System.Drawing.Font("Segoe UI", 7f);
			this.lblCurrentTargetLocation.ForeColor = global::System.Drawing.Color.White;
			this.lblCurrentTargetLocation.Location = new global::System.Drawing.Point(23, 71);
			this.lblCurrentTargetLocation.Name = "lblCurrentTargetLocation";
			this.lblCurrentTargetLocation.Size = new global::System.Drawing.Size(88, 12);
			this.lblCurrentTargetLocation.TabIndex = 72;
			this.lblCurrentTargetLocation.Text = "Unknown Position.";
			this.lblCurrentTarget.AutoSize = true;
			this.lblCurrentTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.lblCurrentTarget.ForeColor = global::System.Drawing.Color.White;
			this.lblCurrentTarget.Location = new global::System.Drawing.Point(22, 54);
			this.lblCurrentTarget.Name = "lblCurrentTarget";
			this.lblCurrentTarget.Size = new global::System.Drawing.Size(107, 15);
			this.lblCurrentTarget.TabIndex = 71;
			this.lblCurrentTarget.Text = "No Target selected.";
			this.grpSelectionAroundMe.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSelectionAroundMe.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSelectionAroundMe.Controls.Add(this.btnSelectionAroundMeTooltip);
			this.grpSelectionAroundMe.Controls.Add(this.btnAroundMeReload);
			this.grpSelectionAroundMe.Controls.Add(this.selectAroundMeItems);
			this.grpSelectionAroundMe.Controls.Add(this.btnAroundMeItemSelect);
			this.grpSelectionAroundMe.Controls.Add(this.selectAroundMeObjects);
			this.grpSelectionAroundMe.Controls.Add(this.btnAroundMeObjectSelect);
			this.grpSelectionAroundMe.Controls.Add(this.selectAroundMeNPCs);
			this.grpSelectionAroundMe.Controls.Add(this.btnAroundMeNPCSelect);
			this.grpSelectionAroundMe.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSelectionAroundMe.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSelectionAroundMe.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSelectionAroundMe.ForeColor = global::System.Drawing.Color.White;
			this.grpSelectionAroundMe.Location = new global::System.Drawing.Point(14, 413);
			this.grpSelectionAroundMe.Name = "grpSelectionAroundMe";
			this.grpSelectionAroundMe.Size = new global::System.Drawing.Size(286, 200);
			this.grpSelectionAroundMe.TabIndex = 69;
			this.grpSelectionAroundMe.Text = "Around Me";
			this.btnSelectionAroundMeTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSelectionAroundMeTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionAroundMeTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSelectionAroundMeTooltip.BorderRadius = 4;
			this.btnSelectionAroundMeTooltip.BorderThickness = 1;
			this.btnSelectionAroundMeTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSelectionAroundMeTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionAroundMeTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionAroundMeTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionAroundMeTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionAroundMeTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSelectionAroundMeTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSelectionAroundMeTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSelectionAroundMeTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSelectionAroundMeTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSelectionAroundMeTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSelectionAroundMeTooltip.Location = new global::System.Drawing.Point(128, 8);
			this.btnSelectionAroundMeTooltip.Name = "btnSelectionAroundMeTooltip";
			this.btnSelectionAroundMeTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSelectionAroundMeTooltip.TabIndex = 90;
			this.btnSelectionAroundMeTooltip.Click += new global::System.EventHandler(this.btnSelectionAroundMeTooltip_Click);
			this.btnAroundMeReload.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAroundMeReload.BorderThickness = 1;
			this.btnAroundMeReload.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeReload.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeReload.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAroundMeReload.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAroundMeReload.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAroundMeReload.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAroundMeReload.ForeColor = global::System.Drawing.Color.White;
			this.btnAroundMeReload.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAroundMeReload.Location = new global::System.Drawing.Point(181, 7);
			this.btnAroundMeReload.Name = "btnAroundMeReload";
			this.btnAroundMeReload.Size = new global::System.Drawing.Size(87, 26);
			this.btnAroundMeReload.TabIndex = 89;
			this.btnAroundMeReload.Text = "Reload";
			this.btnAroundMeReload.Click += new global::System.EventHandler(this.btnAroundMeReload_Click);
			this.selectAroundMeItems.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAroundMeItems.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAroundMeItems.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAroundMeItems.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAroundMeItems.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAroundMeItems.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAroundMeItems.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAroundMeItems.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAroundMeItems.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAroundMeItems.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAroundMeItems.ForeColor = global::System.Drawing.Color.White;
			this.selectAroundMeItems.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAroundMeItems.ItemHeight = 24;
			this.selectAroundMeItems.Items.AddRange(new object[]
			{
				"--- Items ---"
			});
			this.selectAroundMeItems.Location = new global::System.Drawing.Point(22, 150);
			this.selectAroundMeItems.Name = "selectAroundMeItems";
			this.selectAroundMeItems.Size = new global::System.Drawing.Size(210, 30);
			this.selectAroundMeItems.TabIndex = 82;
			this.btnAroundMeItemSelect.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAroundMeItemSelect.BorderThickness = 1;
			this.btnAroundMeItemSelect.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeItemSelect.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeItemSelect.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAroundMeItemSelect.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAroundMeItemSelect.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAroundMeItemSelect.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnAroundMeItemSelect.ForeColor = global::System.Drawing.Color.White;
			this.btnAroundMeItemSelect.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAroundMeItemSelect.Location = new global::System.Drawing.Point(238, 150);
			this.btnAroundMeItemSelect.Name = "btnAroundMeItemSelect";
			this.btnAroundMeItemSelect.Size = new global::System.Drawing.Size(30, 30);
			this.btnAroundMeItemSelect.TabIndex = 81;
			this.btnAroundMeItemSelect.Text = "+";
			this.btnAroundMeItemSelect.Click += new global::System.EventHandler(this.btnAroundMeItemSelect_Click);
			this.selectAroundMeObjects.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAroundMeObjects.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAroundMeObjects.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAroundMeObjects.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAroundMeObjects.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAroundMeObjects.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAroundMeObjects.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAroundMeObjects.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAroundMeObjects.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAroundMeObjects.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAroundMeObjects.ForeColor = global::System.Drawing.Color.White;
			this.selectAroundMeObjects.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAroundMeObjects.ItemHeight = 24;
			this.selectAroundMeObjects.Items.AddRange(new object[]
			{
				"--- Game Objects ---"
			});
			this.selectAroundMeObjects.Location = new global::System.Drawing.Point(22, 105);
			this.selectAroundMeObjects.Name = "selectAroundMeObjects";
			this.selectAroundMeObjects.Size = new global::System.Drawing.Size(210, 30);
			this.selectAroundMeObjects.TabIndex = 80;
			this.btnAroundMeObjectSelect.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAroundMeObjectSelect.BorderThickness = 1;
			this.btnAroundMeObjectSelect.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeObjectSelect.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeObjectSelect.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAroundMeObjectSelect.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAroundMeObjectSelect.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAroundMeObjectSelect.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnAroundMeObjectSelect.ForeColor = global::System.Drawing.Color.White;
			this.btnAroundMeObjectSelect.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAroundMeObjectSelect.Location = new global::System.Drawing.Point(238, 105);
			this.btnAroundMeObjectSelect.Name = "btnAroundMeObjectSelect";
			this.btnAroundMeObjectSelect.Size = new global::System.Drawing.Size(30, 30);
			this.btnAroundMeObjectSelect.TabIndex = 79;
			this.btnAroundMeObjectSelect.Text = "+";
			this.btnAroundMeObjectSelect.Click += new global::System.EventHandler(this.btnAroundMeObjectSelect_Click);
			this.selectAroundMeNPCs.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAroundMeNPCs.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAroundMeNPCs.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAroundMeNPCs.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAroundMeNPCs.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAroundMeNPCs.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAroundMeNPCs.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAroundMeNPCs.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAroundMeNPCs.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAroundMeNPCs.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAroundMeNPCs.ForeColor = global::System.Drawing.Color.White;
			this.selectAroundMeNPCs.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAroundMeNPCs.ItemHeight = 24;
			this.selectAroundMeNPCs.Items.AddRange(new object[]
			{
				"--- NPC's ---"
			});
			this.selectAroundMeNPCs.Location = new global::System.Drawing.Point(22, 60);
			this.selectAroundMeNPCs.Name = "selectAroundMeNPCs";
			this.selectAroundMeNPCs.Size = new global::System.Drawing.Size(210, 30);
			this.selectAroundMeNPCs.TabIndex = 78;
			this.btnAroundMeNPCSelect.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAroundMeNPCSelect.BorderThickness = 1;
			this.btnAroundMeNPCSelect.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeNPCSelect.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAroundMeNPCSelect.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAroundMeNPCSelect.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAroundMeNPCSelect.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAroundMeNPCSelect.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnAroundMeNPCSelect.ForeColor = global::System.Drawing.Color.White;
			this.btnAroundMeNPCSelect.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAroundMeNPCSelect.Location = new global::System.Drawing.Point(238, 60);
			this.btnAroundMeNPCSelect.Name = "btnAroundMeNPCSelect";
			this.btnAroundMeNPCSelect.Size = new global::System.Drawing.Size(30, 30);
			this.btnAroundMeNPCSelect.TabIndex = 77;
			this.btnAroundMeNPCSelect.Text = "+";
			this.btnAroundMeNPCSelect.Click += new global::System.EventHandler(this.btnAroundMeNPCSelect_Click);
			this.grpSelectionMouseover.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSelectionMouseover.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSelectionMouseover.Controls.Add(this.btnSelectionMouseoverTooltip);
			this.grpSelectionMouseover.Controls.Add(this.checkMouseoverLock);
			this.grpSelectionMouseover.Controls.Add(this.btnMouseoverSelect);
			this.grpSelectionMouseover.Controls.Add(this.lblMouseoverNameData);
			this.grpSelectionMouseover.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSelectionMouseover.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSelectionMouseover.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSelectionMouseover.ForeColor = global::System.Drawing.Color.White;
			this.grpSelectionMouseover.Location = new global::System.Drawing.Point(14, 273);
			this.grpSelectionMouseover.Name = "grpSelectionMouseover";
			this.grpSelectionMouseover.Size = new global::System.Drawing.Size(286, 124);
			this.grpSelectionMouseover.TabIndex = 68;
			this.grpSelectionMouseover.Text = "Mouseover";
			this.btnSelectionMouseoverTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSelectionMouseoverTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionMouseoverTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSelectionMouseoverTooltip.BorderRadius = 4;
			this.btnSelectionMouseoverTooltip.BorderThickness = 1;
			this.btnSelectionMouseoverTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSelectionMouseoverTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionMouseoverTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionMouseoverTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionMouseoverTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionMouseoverTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSelectionMouseoverTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSelectionMouseoverTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSelectionMouseoverTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSelectionMouseoverTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSelectionMouseoverTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSelectionMouseoverTooltip.Location = new global::System.Drawing.Point(239, 8);
			this.btnSelectionMouseoverTooltip.Name = "btnSelectionMouseoverTooltip";
			this.btnSelectionMouseoverTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSelectionMouseoverTooltip.TabIndex = 77;
			this.btnSelectionMouseoverTooltip.Click += new global::System.EventHandler(this.btnSelectionMouseoverTooltip_Click);
			this.checkMouseoverLock.Animated = true;
			this.checkMouseoverLock.AutoSize = true;
			this.checkMouseoverLock.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMouseoverLock.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMouseoverLock.CheckedState.BorderRadius = 0;
			this.checkMouseoverLock.CheckedState.BorderThickness = 0;
			this.checkMouseoverLock.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMouseoverLock.Location = new global::System.Drawing.Point(25, 87);
			this.checkMouseoverLock.Name = "checkMouseoverLock";
			this.checkMouseoverLock.Size = new global::System.Drawing.Size(51, 19);
			this.checkMouseoverLock.TabIndex = 76;
			this.checkMouseoverLock.Text = "Lock";
			this.checkMouseoverLock.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMouseoverLock.UncheckedState.BorderRadius = 0;
			this.checkMouseoverLock.UncheckedState.BorderThickness = 1;
			this.checkMouseoverLock.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMouseoverLock.UseVisualStyleBackColor = false;
			this.btnMouseoverSelect.BorderColor = global::System.Drawing.Color.Gray;
			this.btnMouseoverSelect.BorderThickness = 1;
			this.btnMouseoverSelect.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnMouseoverSelect.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnMouseoverSelect.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnMouseoverSelect.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnMouseoverSelect.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnMouseoverSelect.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnMouseoverSelect.ForeColor = global::System.Drawing.Color.White;
			this.btnMouseoverSelect.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnMouseoverSelect.Location = new global::System.Drawing.Point(239, 54);
			this.btnMouseoverSelect.Name = "btnMouseoverSelect";
			this.btnMouseoverSelect.Size = new global::System.Drawing.Size(29, 25);
			this.btnMouseoverSelect.TabIndex = 74;
			this.btnMouseoverSelect.Text = "+";
			this.btnMouseoverSelect.Click += new global::System.EventHandler(this.btnMouseoverSelect_Click);
			this.lblMouseoverNameData.AutoSize = true;
			this.lblMouseoverNameData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMouseoverNameData.ForeColor = global::System.Drawing.Color.White;
			this.lblMouseoverNameData.Location = new global::System.Drawing.Point(22, 60);
			this.lblMouseoverNameData.Name = "lblMouseoverNameData";
			this.lblMouseoverNameData.Size = new global::System.Drawing.Size(107, 15);
			this.lblMouseoverNameData.TabIndex = 71;
			this.lblMouseoverNameData.Text = "No Target selected.";
			this.grpSelectionTarget.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSelectionTarget.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSelectionTarget.Controls.Add(this.btnSelectionTargetTooltip);
			this.grpSelectionTarget.Controls.Add(this.btnTargetSelect);
			this.grpSelectionTarget.Controls.Add(this.lblTargetNameData);
			this.grpSelectionTarget.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSelectionTarget.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSelectionTarget.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSelectionTarget.ForeColor = global::System.Drawing.Color.White;
			this.grpSelectionTarget.Location = new global::System.Drawing.Point(14, 163);
			this.grpSelectionTarget.Name = "grpSelectionTarget";
			this.grpSelectionTarget.Size = new global::System.Drawing.Size(286, 95);
			this.grpSelectionTarget.TabIndex = 67;
			this.grpSelectionTarget.Text = "Target";
			this.btnSelectionTargetTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSelectionTargetTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionTargetTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSelectionTargetTooltip.BorderRadius = 4;
			this.btnSelectionTargetTooltip.BorderThickness = 1;
			this.btnSelectionTargetTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSelectionTargetTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionTargetTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionTargetTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionTargetTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSelectionTargetTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSelectionTargetTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSelectionTargetTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSelectionTargetTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSelectionTargetTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSelectionTargetTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSelectionTargetTooltip.Location = new global::System.Drawing.Point(239, 8);
			this.btnSelectionTargetTooltip.Name = "btnSelectionTargetTooltip";
			this.btnSelectionTargetTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSelectionTargetTooltip.TabIndex = 76;
			this.btnSelectionTargetTooltip.Click += new global::System.EventHandler(this.btnSelectionTargetTooltip_Click);
			this.btnTargetSelect.BorderColor = global::System.Drawing.Color.Gray;
			this.btnTargetSelect.BorderThickness = 1;
			this.btnTargetSelect.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnTargetSelect.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnTargetSelect.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnTargetSelect.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnTargetSelect.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnTargetSelect.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnTargetSelect.ForeColor = global::System.Drawing.Color.White;
			this.btnTargetSelect.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnTargetSelect.Location = new global::System.Drawing.Point(239, 54);
			this.btnTargetSelect.Name = "btnTargetSelect";
			this.btnTargetSelect.Size = new global::System.Drawing.Size(29, 25);
			this.btnTargetSelect.TabIndex = 75;
			this.btnTargetSelect.Text = "+";
			this.btnTargetSelect.Click += new global::System.EventHandler(this.btnTargetSelect_Click);
			this.lblTargetNameData.AutoSize = true;
			this.lblTargetNameData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblTargetNameData.ForeColor = global::System.Drawing.Color.White;
			this.lblTargetNameData.Location = new global::System.Drawing.Point(22, 60);
			this.lblTargetNameData.Name = "lblTargetNameData";
			this.lblTargetNameData.Size = new global::System.Drawing.Size(107, 15);
			this.lblTargetNameData.TabIndex = 71;
			this.lblTargetNameData.Text = "No Target selected.";
			this.panelTitle1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle1.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle1.Controls.Add(this.imgTitleEdge1);
			this.panelTitle1.Controls.Add(this.lblTitle1);
			this.panelTitle1.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle1.Name = "panelTitle1";
			this.panelTitle1.Size = new global::System.Drawing.Size(261, 38);
			this.panelTitle1.TabIndex = 66;
			this.imgTitleEdge1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge1.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge1.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge1.ImageRotate = 0f;
			this.imgTitleEdge1.Location = new global::System.Drawing.Point(191, 0);
			this.imgTitleEdge1.Name = "imgTitleEdge1";
			this.imgTitleEdge1.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge1.TabIndex = 66;
			this.imgTitleEdge1.TabStop = false;
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle1.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle1.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new global::System.Drawing.Size(116, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "Selection";
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(870, 702);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 70;
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSave.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.Image = global::Jack.Properties.Resources.btn_save_disabled;
			this.btnSave.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnSave.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSave.ForeColor = global::System.Drawing.Color.White;
			this.btnSave.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.Image = global::Jack.Properties.Resources.btn_save_hover;
			this.btnSave.Image = global::Jack.Properties.Resources.btn_save;
			this.btnSave.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnSave.Location = new global::System.Drawing.Point(30, 0);
			this.btnSave.Name = "btnSave";
			this.btnSave.PressedDepth = 0;
			this.btnSave.Size = new global::System.Drawing.Size(235, 44);
			this.btnSave.TabIndex = 0;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(1174, 786);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.Controls.Add(this.panelBox2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(1174, 786);
			base.Name = "frmProfileEvent";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmProfileEvent";
			base.Load += new global::System.EventHandler(this.frmProfileEvent_Load);
			base.Shown += new global::System.EventHandler(this.frmProfileEvent_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmProfileEvent_VisibleChanged);
			this.panelBox2.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabAction.ResumeLayout(false);
			this.panelTabAction.ResumeLayout(false);
			this.grpSettings.ResumeLayout(false);
			this.grpSettings.PerformLayout();
			this.grpAction.ResumeLayout(false);
			this.grpAction.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.grpConditionAndOr1.ResumeLayout(false);
			this.grpCondition1.ResumeLayout(false);
			this.grpCondition1.PerformLayout();
			this.grpCondition2.ResumeLayout(false);
			this.grpCondition2.PerformLayout();
			this.tabInteractWith.ResumeLayout(false);
			this.panelTabInteractWith.ResumeLayout(false);
			this.grpInteract.ResumeLayout(false);
			this.grpInteract.PerformLayout();
			this.tabWait.ResumeLayout(false);
			this.panelTabWait.ResumeLayout(false);
			this.grpWaitFor.ResumeLayout(false);
			this.grpWaitFor.PerformLayout();
			this.grpWait.ResumeLayout(false);
			this.grpWait.PerformLayout();
			this.tabLoadProfile.ResumeLayout(false);
			this.panelTabLoadProfile.ResumeLayout(false);
			this.grpLoadProfile.ResumeLayout(false);
			this.grpLoadProfile.PerformLayout();
			this.tabLoadRotation.ResumeLayout(false);
			this.panelTabLoadRotation.ResumeLayout(false);
			this.grpLoadRotation.ResumeLayout(false);
			this.grpLoadRotation.PerformLayout();
			this.tabRecorder.ResumeLayout(false);
			this.panelTabRecorder.ResumeLayout(false);
			this.grpRecorderMailbox.ResumeLayout(false);
			this.grpRecorderMailbox.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.grpRecorderType.ResumeLayout(false);
			this.grpRecorderType.PerformLayout();
			this.panelRecorderInfo.ResumeLayout(false);
			this.grpRecorderFlightMaster.ResumeLayout(false);
			this.grpRecorderFlightMaster.PerformLayout();
			this.grpRecorderVendor.ResumeLayout(false);
			this.grpRecorderVendor.PerformLayout();
			this.tabCastSpell.ResumeLayout(false);
			this.panelTabCastSpell.ResumeLayout(false);
			this.grpCastSpellTarget.ResumeLayout(false);
			this.grpCastSpellTarget.PerformLayout();
			this.grpCastSpell.ResumeLayout(false);
			this.grpCastSpell.PerformLayout();
			this.tabWalkSens.ResumeLayout(false);
			this.panelTabWalkSens.ResumeLayout(false);
			this.grpWalkSens.ResumeLayout(false);
			this.grpWalkSens.PerformLayout();
			this.tabUseHearthstone.ResumeLayout(false);
			this.panelTabUseHearthstone.ResumeLayout(false);
			this.grpUseHearthstone.ResumeLayout(false);
			this.grpUseHearthstone.PerformLayout();
			this.tabFishing.ResumeLayout(false);
			this.panelTabFishing.ResumeLayout(false);
			this.grpFishingOptions.ResumeLayout(false);
			this.grpFishingOptions.PerformLayout();
			this.grpFishingFacing.ResumeLayout(false);
			this.grpFishingFacing.PerformLayout();
			this.grpFishing.ResumeLayout(false);
			this.grpFishing.PerformLayout();
			this.grpFishingCondition.ResumeLayout(false);
			this.grpFishingCondition.PerformLayout();
			this.grpFishingBait.ResumeLayout(false);
			this.grpFishingBait.PerformLayout();
			this.tabUseTransport.ResumeLayout(false);
			this.panelTabUseTransport.ResumeLayout(false);
			this.grpUseTransportTurn.ResumeLayout(false);
			this.grpUseTransportTurn.PerformLayout();
			this.grpUseTransportLoadProfile.ResumeLayout(false);
			this.grpUseTransportLoadProfile.PerformLayout();
			this.tabExecuteLUA.ResumeLayout(false);
			this.panelTabExecuteLUA.ResumeLayout(false);
			this.grpExecuteLUA.ResumeLayout(false);
			this.grpExecuteLUA.PerformLayout();
			this.tabBattlegroundClassic.ResumeLayout(false);
			this.panelTabBattleground.ResumeLayout(false);
			this.grpBattlegroundClassic.ResumeLayout(false);
			this.grpBattlegroundClassic.PerformLayout();
			this.tabChangeProfileSettings.ResumeLayout(false);
			this.panelTabChangeProfileSettings.ResumeLayout(false);
			this.grpMobs.ResumeLayout(false);
			this.grpMobs.PerformLayout();
			this.panelMobs.ResumeLayout(false);
			this.grpSettingsMode.ResumeLayout(false);
			this.grpSettingsMode.PerformLayout();
			this.grpSettingsDistances.ResumeLayout(false);
			this.grpSettingsDistances.PerformLayout();
			this.grpSettingsMount.ResumeLayout(false);
			this.grpSettingsMount.PerformLayout();
			this.grpSettingsLoot.ResumeLayout(false);
			this.grpSettingsLoot.PerformLayout();
			this.imgModuleGather.EndInit();
			this.panelTitle2.ResumeLayout(false);
			this.panelTitle2.PerformLayout();
			this.imgTitleEdge2.EndInit();
			this.panelBox1.ResumeLayout(false);
			this.grpSelectionCurrent.ResumeLayout(false);
			this.grpSelectionCurrent.PerformLayout();
			this.grpSelectionAroundMe.ResumeLayout(false);
			this.grpSelectionMouseover.ResumeLayout(false);
			this.grpSelectionMouseover.PerformLayout();
			this.grpSelectionTarget.ResumeLayout(false);
			this.grpSelectionTarget.PerformLayout();
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.imgTitleEdge1.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040004BE RID: 1214
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040004BF RID: 1215
		private global::Guna.UI2.WinForms.Guna2Panel panelBox2;

		// Token: 0x040004C0 RID: 1216
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x040004C1 RID: 1217
		private global::System.Windows.Forms.TabPage tabAction;

		// Token: 0x040004C2 RID: 1218
		private global::System.Windows.Forms.TabPage tabInteractWith;

		// Token: 0x040004C3 RID: 1219
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInteract;

		// Token: 0x040004C4 RID: 1220
		private global::Guna.UI2.WinForms.Guna2CheckBox checkInteractAttack;

		// Token: 0x040004C5 RID: 1221
		private global::Guna.UI2.WinForms.Guna2CheckBox checkInteractClosest;

		// Token: 0x040004C6 RID: 1222
		private global::System.Windows.Forms.Label lblInteractNameOrID;

		// Token: 0x040004C7 RID: 1223
		private global::System.Windows.Forms.TabPage tabWait;

		// Token: 0x040004C8 RID: 1224
		private global::System.Windows.Forms.TabPage tabLoadProfile;

		// Token: 0x040004C9 RID: 1225
		private global::System.Windows.Forms.TabPage tabCastSpell;

		// Token: 0x040004CA RID: 1226
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle2;

		// Token: 0x040004CB RID: 1227
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge2;

		// Token: 0x040004CC RID: 1228
		private global::System.Windows.Forms.Label lblTitle2;

		// Token: 0x040004CD RID: 1229
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x040004CE RID: 1230
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x040004CF RID: 1231
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x040004D0 RID: 1232
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x040004D1 RID: 1233
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSelectionTarget;

		// Token: 0x040004D2 RID: 1234
		private global::System.Windows.Forms.Label lblTargetNameData;

		// Token: 0x040004D3 RID: 1235
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSelectionMouseover;

		// Token: 0x040004D4 RID: 1236
		private global::Guna.UI2.WinForms.Guna2Button btnMouseoverSelect;

		// Token: 0x040004D5 RID: 1237
		private global::System.Windows.Forms.Label lblMouseoverNameData;

		// Token: 0x040004D6 RID: 1238
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMouseoverLock;

		// Token: 0x040004D7 RID: 1239
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSelectionAroundMe;

		// Token: 0x040004D8 RID: 1240
		private global::Guna.UI2.WinForms.Guna2Button btnTargetSelect;

		// Token: 0x040004D9 RID: 1241
		private global::Guna.UI2.WinForms.Guna2Button btnAroundMeNPCSelect;

		// Token: 0x040004DA RID: 1242
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAroundMeNPCs;

		// Token: 0x040004DB RID: 1243
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAroundMeItems;

		// Token: 0x040004DC RID: 1244
		private global::Guna.UI2.WinForms.Guna2Button btnAroundMeItemSelect;

		// Token: 0x040004DD RID: 1245
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAroundMeObjects;

		// Token: 0x040004DE RID: 1246
		private global::Guna.UI2.WinForms.Guna2Button btnAroundMeObjectSelect;

		// Token: 0x040004DF RID: 1247
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSelectionCurrent;

		// Token: 0x040004E0 RID: 1248
		private global::System.Windows.Forms.Label lblCurrentTarget;

		// Token: 0x040004E1 RID: 1249
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAction;

		// Token: 0x040004E2 RID: 1250
		private global::System.Windows.Forms.Label lblActionEvent;

		// Token: 0x040004E3 RID: 1251
		private global::System.Windows.Forms.TabPage tabRecorder;

		// Token: 0x040004E4 RID: 1252
		private global::System.Windows.Forms.TabPage tabWalkSens;

		// Token: 0x040004E5 RID: 1253
		private global::System.Windows.Forms.TabPage tabUseHearthstone;

		// Token: 0x040004E6 RID: 1254
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAction;

		// Token: 0x040004E7 RID: 1255
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x040004E8 RID: 1256
		private global::Guna.UI2.WinForms.Guna2GroupBox grpConditionAndOr1;

		// Token: 0x040004E9 RID: 1257
		private global::Guna.UI2.WinForms.Guna2GroupBox grpCondition1;

		// Token: 0x040004EA RID: 1258
		private global::Guna.UI2.WinForms.Guna2GroupBox grpCondition2;

		// Token: 0x040004EB RID: 1259
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCondition1;

		// Token: 0x040004EC RID: 1260
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCondition2;

		// Token: 0x040004ED RID: 1261
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettings;

		// Token: 0x040004EE RID: 1262
		private global::Guna.UI2.WinForms.Guna2ComboBox selectSettingsFaction;

		// Token: 0x040004EF RID: 1263
		private global::System.Windows.Forms.Label lblSettingsFaction;

		// Token: 0x040004F0 RID: 1264
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsExecuteOnce;

		// Token: 0x040004F1 RID: 1265
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsExecuteAlways;

		// Token: 0x040004F2 RID: 1266
		private global::System.Windows.Forms.Label lblSettingsExecute;

		// Token: 0x040004F3 RID: 1267
		private global::Guna.UI2.WinForms.Guna2ComboBox selectCondition1Compare;

		// Token: 0x040004F4 RID: 1268
		private global::Guna.UI2.WinForms.Guna2ComboBox selectCondition1;

		// Token: 0x040004F5 RID: 1269
		private global::Guna.UI2.WinForms.Guna2TextBox txtCondition1Value;

		// Token: 0x040004F6 RID: 1270
		private global::Guna.UI2.WinForms.Guna2ComboBox selectCondition2Compare;

		// Token: 0x040004F7 RID: 1271
		private global::Guna.UI2.WinForms.Guna2ComboBox selectCondition2;

		// Token: 0x040004F8 RID: 1272
		private global::Guna.UI2.WinForms.Guna2ComboBox selectConditionAndOr1;

		// Token: 0x040004F9 RID: 1273
		private global::Guna.UI2.WinForms.Guna2TextBox txtCondition2Value;

		// Token: 0x040004FA RID: 1274
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRecorderType;

		// Token: 0x040004FB RID: 1275
		private global::Guna.UI2.WinForms.Guna2ComboBox selectRecorderRouteType;

		// Token: 0x040004FC RID: 1276
		private global::System.Windows.Forms.Label lblRecorderType;

		// Token: 0x040004FD RID: 1277
		private global::Guna.UI2.WinForms.Guna2ComboBox selectRecorderCombatMode;

		// Token: 0x040004FE RID: 1278
		private global::System.Windows.Forms.Label lblRecorderCombatMode;

		// Token: 0x040004FF RID: 1279
		private global::Guna.UI2.WinForms.Guna2Button btnRecordStart;

		// Token: 0x04000500 RID: 1280
		private global::System.Windows.Forms.ListView listWaypoints;

		// Token: 0x04000501 RID: 1281
		private global::System.Windows.Forms.ColumnHeader listWaypointsCount;

		// Token: 0x04000502 RID: 1282
		private global::System.Windows.Forms.ColumnHeader listWaypointsWaypoint;

		// Token: 0x04000503 RID: 1283
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000504 RID: 1284
		private global::Guna.UI2.WinForms.Guna2Separator sepRecorder1;

		// Token: 0x04000505 RID: 1285
		private global::Guna.UI2.WinForms.Guna2Button btnWaypointDelete;

		// Token: 0x04000506 RID: 1286
		private global::Guna.UI2.WinForms.Guna2Button btnWaypointAddAfter;

		// Token: 0x04000507 RID: 1287
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderSingle;

		// Token: 0x04000508 RID: 1288
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRecorderVendor;

		// Token: 0x04000509 RID: 1289
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderVendorSellGreys;

		// Token: 0x0400050A RID: 1290
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderVendorSellBlues;

		// Token: 0x0400050B RID: 1291
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderVendorSellGreens;

		// Token: 0x0400050C RID: 1292
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderVendorSellWhites;

		// Token: 0x0400050D RID: 1293
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderVendorCanRepair;

		// Token: 0x0400050E RID: 1294
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderVendorBuylist;

		// Token: 0x0400050F RID: 1295
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderVendorWhitelist;

		// Token: 0x04000510 RID: 1296
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRecorderFlightMaster;

		// Token: 0x04000511 RID: 1297
		private global::System.Windows.Forms.Label lblRecorderFlightMasterFlightPoints;

		// Token: 0x04000512 RID: 1298
		private global::System.Windows.Forms.Label lblRecorderFlightMasterProfiles;

		// Token: 0x04000513 RID: 1299
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRecorderMailbox;

		// Token: 0x04000514 RID: 1300
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderMailboxSendPurples;

		// Token: 0x04000515 RID: 1301
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderMailboxSendGreys;

		// Token: 0x04000516 RID: 1302
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderMailboxSendBlues;

		// Token: 0x04000517 RID: 1303
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderMailboxSendGreens;

		// Token: 0x04000518 RID: 1304
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderMailboxSendWhites;

		// Token: 0x04000519 RID: 1305
		private global::Guna.UI2.WinForms.Guna2Separator sepRecorderMailbox1;

		// Token: 0x0400051A RID: 1306
		private global::System.Windows.Forms.Label lblRecorderMailboxReceiver;

		// Token: 0x0400051B RID: 1307
		private global::Guna.UI2.WinForms.Guna2TextBox txtRecorderMailboxReceiver;

		// Token: 0x0400051C RID: 1308
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderMailboxSendlist;

		// Token: 0x0400051D RID: 1309
		private global::Guna.UI2.WinForms.Guna2TextBox txtInteractNameOrID;

		// Token: 0x0400051E RID: 1310
		private global::Guna.UI2.WinForms.Guna2CheckBox checkInteractFurthest;

		// Token: 0x0400051F RID: 1311
		private global::Guna.UI2.WinForms.Guna2GroupBox grpWait;

		// Token: 0x04000520 RID: 1312
		private global::Guna.UI2.WinForms.Guna2TextBox txtWaitSeconds;

		// Token: 0x04000521 RID: 1313
		private global::Guna.UI2.WinForms.Guna2CheckBox checkWaitIgnoreAttackers;

		// Token: 0x04000522 RID: 1314
		private global::System.Windows.Forms.Label lblWaitSeconds;

		// Token: 0x04000523 RID: 1315
		private global::Guna.UI2.WinForms.Guna2CheckBox checkWait;

		// Token: 0x04000524 RID: 1316
		private global::Guna.UI2.WinForms.Guna2GroupBox grpWaitFor;

		// Token: 0x04000525 RID: 1317
		private global::Guna.UI2.WinForms.Guna2CheckBox checkWaitFor;

		// Token: 0x04000526 RID: 1318
		private global::System.Windows.Forms.Label lblWaitForMaxSeconds;

		// Token: 0x04000527 RID: 1319
		private global::System.Windows.Forms.Label lblWaitFor;

		// Token: 0x04000528 RID: 1320
		private global::Guna.UI2.WinForms.Guna2TextBox txtWaitForNameOrID;

		// Token: 0x04000529 RID: 1321
		private global::Guna.UI2.WinForms.Guna2TextBox txtWaitForMaxSeconds;

		// Token: 0x0400052A RID: 1322
		private global::Guna.UI2.WinForms.Guna2GroupBox grpLoadProfile;

		// Token: 0x0400052B RID: 1323
		private global::System.Windows.Forms.Label lblLoadProfile;

		// Token: 0x0400052C RID: 1324
		private global::Guna.UI2.WinForms.Guna2GroupBox grpCastSpell;

		// Token: 0x0400052D RID: 1325
		private global::Guna.UI2.WinForms.Guna2Button btnCastSpellReload;

		// Token: 0x0400052E RID: 1326
		private global::System.Windows.Forms.Label lblCastSpell;

		// Token: 0x0400052F RID: 1327
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x04000530 RID: 1328
		private global::Guna.UI2.WinForms.Guna2TextBox txtCastSpellRadius;

		// Token: 0x04000531 RID: 1329
		private global::System.Windows.Forms.Label lblCastSpellRadius;

		// Token: 0x04000532 RID: 1330
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCastSpellNoRadiusCheck;

		// Token: 0x04000533 RID: 1331
		private global::System.Windows.Forms.Label lblCastSpellRadiusInfo;

		// Token: 0x04000534 RID: 1332
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator2;

		// Token: 0x04000535 RID: 1333
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCastSpellWhileWalk;

		// Token: 0x04000536 RID: 1334
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCastSpellGroundAOE;

		// Token: 0x04000537 RID: 1335
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCastSpellUntilNoAttackers;

		// Token: 0x04000538 RID: 1336
		private global::Guna.UI2.WinForms.Guna2GroupBox grpCastSpellTarget;

		// Token: 0x04000539 RID: 1337
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCastSpellTargetFurthest;

		// Token: 0x0400053A RID: 1338
		private global::Guna.UI2.WinForms.Guna2TextBox txtCastSpellTargetNameOrID;

		// Token: 0x0400053B RID: 1339
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCastSpellTargetClosest;

		// Token: 0x0400053C RID: 1340
		private global::System.Windows.Forms.Label lblCastSpellTargetNameOrID;

		// Token: 0x0400053D RID: 1341
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCastSpellTarget;

		// Token: 0x0400053E RID: 1342
		private global::Guna.UI2.WinForms.Guna2GroupBox grpWalkSens;

		// Token: 0x0400053F RID: 1343
		private global::Guna.UI2.WinForms.Guna2Separator sepWalkSens2;

		// Token: 0x04000540 RID: 1344
		private global::System.Windows.Forms.Label lblWalkSensOutdoor;

		// Token: 0x04000541 RID: 1345
		private global::Guna.UI2.WinForms.Guna2Separator sepWalkSens1;

		// Token: 0x04000542 RID: 1346
		private global::System.Windows.Forms.Label lblWalkSensInfo1;

		// Token: 0x04000543 RID: 1347
		private global::Guna.UI2.WinForms.Guna2TrackBar trackWalkSensOutdoor;

		// Token: 0x04000544 RID: 1348
		private global::System.Windows.Forms.Label lblWalkSensOutdoorData;

		// Token: 0x04000545 RID: 1349
		private global::System.Windows.Forms.Label lblWalkSensIndoorData;

		// Token: 0x04000546 RID: 1350
		private global::Guna.UI2.WinForms.Guna2TrackBar trackWalkSensIndoor;

		// Token: 0x04000547 RID: 1351
		private global::System.Windows.Forms.Label lblWalkSensIndoor;

		// Token: 0x04000548 RID: 1352
		private global::System.Windows.Forms.Label lblWalkSensInfo2;

		// Token: 0x04000549 RID: 1353
		private global::System.Windows.Forms.Label lblWalkSensInfo3;

		// Token: 0x0400054A RID: 1354
		private global::Guna.UI2.WinForms.Guna2GroupBox grpUseHearthstone;

		// Token: 0x0400054B RID: 1355
		private global::System.Windows.Forms.Label lblUseHearthstoneLoadProfile;

		// Token: 0x0400054C RID: 1356
		private global::Guna.UI2.WinForms.Guna2Button btnAroundMeReload;

		// Token: 0x0400054D RID: 1357
		private global::Guna.UI2.WinForms.Guna2Button btnWalkSensDefault;

		// Token: 0x0400054E RID: 1358
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x0400054F RID: 1359
		private global::Guna.UI2.WinForms.Guna2Button btnSave;

		// Token: 0x04000550 RID: 1360
		private global::System.Windows.Forms.TabPage tabFishing;

		// Token: 0x04000551 RID: 1361
		private global::Guna.UI2.WinForms.Guna2GroupBox grpFishingBait;

		// Token: 0x04000552 RID: 1362
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFishingBait;

		// Token: 0x04000553 RID: 1363
		private global::Guna.UI2.WinForms.Guna2GroupBox grpFishing;

		// Token: 0x04000554 RID: 1364
		private global::System.Windows.Forms.Label lblFishingKeybind;

		// Token: 0x04000555 RID: 1365
		private global::System.Windows.Forms.Label lblFishingBaitKeybind;

		// Token: 0x04000556 RID: 1366
		private global::Guna.UI2.WinForms.Guna2GroupBox grpFishingCondition;

		// Token: 0x04000557 RID: 1367
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFishingCondition;

		// Token: 0x04000558 RID: 1368
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFishingConditionSkillLevel;

		// Token: 0x04000559 RID: 1369
		private global::Guna.UI2.WinForms.Guna2TextBox txtFishingConditionSkillLevel;

		// Token: 0x0400055A RID: 1370
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator3;

		// Token: 0x0400055B RID: 1371
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFishingConditionItemlist;

		// Token: 0x0400055C RID: 1372
		private global::Guna.UI2.WinForms.Guna2Button btnFishingConditionItemlist;

		// Token: 0x0400055D RID: 1373
		private global::System.Windows.Forms.Label lblcheckFishingConditionItemlist;

		// Token: 0x0400055E RID: 1374
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFishingConditionFullBags;

		// Token: 0x0400055F RID: 1375
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator4;

		// Token: 0x04000560 RID: 1376
		private global::Guna.UI2.WinForms.Guna2GroupBox grpFishingFacing;

		// Token: 0x04000561 RID: 1377
		private global::System.Windows.Forms.Label lblFishingFacingDirection;

		// Token: 0x04000562 RID: 1378
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFishingFacing;

		// Token: 0x04000563 RID: 1379
		private global::Guna.UI2.WinForms.Guna2Button btnFishingFacingDirection;

		// Token: 0x04000564 RID: 1380
		private global::Guna.UI2.WinForms.Guna2Panel panelTabAction;

		// Token: 0x04000565 RID: 1381
		private global::Guna.UI2.WinForms.Guna2Panel panelTabCastSpell;

		// Token: 0x04000566 RID: 1382
		private global::Guna.UI2.WinForms.Guna2Panel panelTabFishing;

		// Token: 0x04000567 RID: 1383
		private global::Guna.UI2.WinForms.Guna2Panel panelTabInteractWith;

		// Token: 0x04000568 RID: 1384
		private global::Guna.UI2.WinForms.Guna2Panel panelTabWalkSens;

		// Token: 0x04000569 RID: 1385
		private global::Guna.UI2.WinForms.Guna2Panel panelTabWait;

		// Token: 0x0400056A RID: 1386
		private global::Guna.UI2.WinForms.Guna2Panel panelTabLoadProfile;

		// Token: 0x0400056B RID: 1387
		private global::Guna.UI2.WinForms.Guna2Panel panelTabRecorder;

		// Token: 0x0400056C RID: 1388
		private global::Guna.UI2.WinForms.Guna2Panel panelTabUseHearthstone;

		// Token: 0x0400056D RID: 1389
		private global::System.Windows.Forms.ComboBox selectLoadProfile;

		// Token: 0x0400056E RID: 1390
		private global::System.Windows.Forms.ComboBox selectRecorderFlightMasterProfiles;

		// Token: 0x0400056F RID: 1391
		private global::System.Windows.Forms.ComboBox selectRecorderFlightMasterFlightPoints;

		// Token: 0x04000570 RID: 1392
		private global::System.Windows.Forms.ComboBox selectUseHearthstoneLoadProfile;

		// Token: 0x04000571 RID: 1393
		private global::System.Windows.Forms.ComboBox selectCastSpell;

		// Token: 0x04000572 RID: 1394
		private global::System.Windows.Forms.TabPage tabUseTransport;

		// Token: 0x04000573 RID: 1395
		private global::Guna.UI2.WinForms.Guna2Panel panelTabUseTransport;

		// Token: 0x04000574 RID: 1396
		private global::Guna.UI2.WinForms.Guna2GroupBox grpUseTransportLoadProfile;

		// Token: 0x04000575 RID: 1397
		private global::System.Windows.Forms.ComboBox selectUseTransportLoadProfile;

		// Token: 0x04000576 RID: 1398
		private global::System.Windows.Forms.Label lblUseTransportLoadProfile;

		// Token: 0x04000577 RID: 1399
		private global::Guna.UI2.WinForms.Guna2GroupBox grpUseTransportTurn;

		// Token: 0x04000578 RID: 1400
		private global::System.Windows.Forms.Label lblUseTransportTurn;

		// Token: 0x04000579 RID: 1401
		private global::Guna.UI2.WinForms.Guna2ComboBox selectUseTransportTurn;

		// Token: 0x0400057A RID: 1402
		private global::Guna.UI2.WinForms.Guna2Button btnTooltip;

		// Token: 0x0400057B RID: 1403
		private global::Guna.UI2.WinForms.Guna2Button btnSettingsTooltip;

		// Token: 0x0400057C RID: 1404
		private global::Guna.UI2.WinForms.Guna2Button btnActionTooltip;

		// Token: 0x0400057D RID: 1405
		private global::Guna.UI2.WinForms.Guna2Button btnConditionTooltip;

		// Token: 0x0400057E RID: 1406
		private global::Guna.UI2.WinForms.Guna2Button btnSelectionMouseoverTooltip;

		// Token: 0x0400057F RID: 1407
		private global::Guna.UI2.WinForms.Guna2Button btnSelectionTargetTooltip;

		// Token: 0x04000580 RID: 1408
		private global::Guna.UI2.WinForms.Guna2Button btnSelectionAroundMeTooltip;

		// Token: 0x04000581 RID: 1409
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderTypeTooltip;

		// Token: 0x04000582 RID: 1410
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderMailboxTooltip;

		// Token: 0x04000583 RID: 1411
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderFlightMasterTooltip;

		// Token: 0x04000584 RID: 1412
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderVendorTooltip;

		// Token: 0x04000585 RID: 1413
		private global::Guna.UI2.WinForms.Guna2Button btnCastSpellTooltip;

		// Token: 0x04000586 RID: 1414
		private global::Guna.UI2.WinForms.Guna2Button btnInteractWithTooltip;

		// Token: 0x04000587 RID: 1415
		private global::Guna.UI2.WinForms.Guna2Button btnFishingFacingTooltip;

		// Token: 0x04000588 RID: 1416
		private global::Guna.UI2.WinForms.Guna2Button btnUseTransportTooltip;

		// Token: 0x04000589 RID: 1417
		private global::Guna.UI2.WinForms.Guna2ComboBox selectSettingsRace;

		// Token: 0x0400058A RID: 1418
		private global::System.Windows.Forms.Label lblSettingsRace;

		// Token: 0x0400058B RID: 1419
		private global::System.Windows.Forms.TabPage tabExecuteLUA;

		// Token: 0x0400058C RID: 1420
		private global::Guna.UI2.WinForms.Guna2Panel panelTabExecuteLUA;

		// Token: 0x0400058D RID: 1421
		private global::Guna.UI2.WinForms.Guna2GroupBox grpExecuteLUA;

		// Token: 0x0400058E RID: 1422
		private global::Guna.UI2.WinForms.Guna2Button btnExecuteLUATooltip;

		// Token: 0x0400058F RID: 1423
		private global::Guna.UI2.WinForms.Guna2TextBox txtExecuteLUA;

		// Token: 0x04000590 RID: 1424
		private global::Guna.UI2.WinForms.Guna2ComboBox selectExecuteLUAExamples;

		// Token: 0x04000591 RID: 1425
		private global::Guna.UI2.WinForms.Guna2Button btnExecuteLUATest;

		// Token: 0x04000592 RID: 1426
		private global::Guna.UI2.WinForms.Guna2CheckBox checkExecuteLUAWhileWalk;

		// Token: 0x04000593 RID: 1427
		private global::Guna.UI2.WinForms.Guna2CheckBox checkWaitForGate;

		// Token: 0x04000594 RID: 1428
		private global::System.Windows.Forms.TabPage tabBattlegroundClassic;

		// Token: 0x04000595 RID: 1429
		private global::Guna.UI2.WinForms.Guna2Panel panelTabBattleground;

		// Token: 0x04000596 RID: 1430
		private global::Guna.UI2.WinForms.Guna2GroupBox grpBattlegroundClassic;

		// Token: 0x04000597 RID: 1431
		private global::System.Windows.Forms.ComboBox selectBattlegroundClassicEyeOfTheStorm;

		// Token: 0x04000598 RID: 1432
		private global::System.Windows.Forms.ComboBox selectBattlegroundClassicAlteracValley;

		// Token: 0x04000599 RID: 1433
		private global::System.Windows.Forms.ComboBox selectBattlegroundClassicArathiBasin;

		// Token: 0x0400059A RID: 1434
		private global::System.Windows.Forms.ComboBox selectBattlegroundClassicWarsongGulch;

		// Token: 0x0400059B RID: 1435
		private global::Guna.UI2.WinForms.Guna2CheckBox checkBattlegroundClassicEyeOfTheStorm;

		// Token: 0x0400059C RID: 1436
		private global::Guna.UI2.WinForms.Guna2CheckBox checkBattlegroundClassicAlteracValley;

		// Token: 0x0400059D RID: 1437
		private global::Guna.UI2.WinForms.Guna2CheckBox checkBattlegroundClassicArathiBasin;

		// Token: 0x0400059E RID: 1438
		private global::Guna.UI2.WinForms.Guna2CheckBox checkBattlegroundClassicWarsongGulch;

		// Token: 0x0400059F RID: 1439
		private global::Guna.UI2.WinForms.Guna2CheckBox checkBattlegroundClassicWaitUntilInvitation;

		// Token: 0x040005A0 RID: 1440
		private global::Guna.UI2.WinForms.Guna2Button btnTooltipBattlegroundClassic;

		// Token: 0x040005A1 RID: 1441
		private global::Guna.UI2.WinForms.Guna2TextBox txtCondition1Value2;

		// Token: 0x040005A2 RID: 1442
		private global::Guna.UI2.WinForms.Guna2TextBox txtCondition2Value2;

		// Token: 0x040005A3 RID: 1443
		private global::System.Windows.Forms.TabPage tabLoadRotation;

		// Token: 0x040005A4 RID: 1444
		private global::Guna.UI2.WinForms.Guna2Panel panelTabLoadRotation;

		// Token: 0x040005A5 RID: 1445
		private global::Guna.UI2.WinForms.Guna2GroupBox grpLoadRotation;

		// Token: 0x040005A6 RID: 1446
		private global::System.Windows.Forms.ComboBox selectLoadRotation;

		// Token: 0x040005A7 RID: 1447
		private global::System.Windows.Forms.Label lblLoadRotation;

		// Token: 0x040005A8 RID: 1448
		private global::System.Windows.Forms.TabPage tabChangeProfileSettings;

		// Token: 0x040005A9 RID: 1449
		private global::Guna.UI2.WinForms.Guna2Panel panelTabChangeProfileSettings;

		// Token: 0x040005AA RID: 1450
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsMode;

		// Token: 0x040005AB RID: 1451
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsModeMesh;

		// Token: 0x040005AC RID: 1452
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsModeFollowFleeingTarget;

		// Token: 0x040005AD RID: 1453
		private global::Guna.UI2.WinForms.Guna2ComboBox selectSettingsWaypointMode;

		// Token: 0x040005AE RID: 1454
		private global::Guna.UI2.WinForms.Guna2ComboBox selectSettingsCombatMode;

		// Token: 0x040005AF RID: 1455
		private global::System.Windows.Forms.Label lblSettingsCombatMode;

		// Token: 0x040005B0 RID: 1456
		private global::System.Windows.Forms.Label lblSettingsWaypointsMode;

		// Token: 0x040005B1 RID: 1457
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsDistances;

		// Token: 0x040005B2 RID: 1458
		private global::System.Windows.Forms.Label lblSettingsDistancesIsReachableZAxis;

		// Token: 0x040005B3 RID: 1459
		private global::System.Windows.Forms.Label lblSettingsDistancesIsReachable;

		// Token: 0x040005B4 RID: 1460
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesIsReachable;

		// Token: 0x040005B5 RID: 1461
		private global::System.Windows.Forms.Label lblSettingsDistancesMobGroupDetection;

		// Token: 0x040005B6 RID: 1462
		private global::System.Windows.Forms.Label lblSettingsDistancesInfo;

		// Token: 0x040005B7 RID: 1463
		private global::System.Windows.Forms.Label lblSettingsDistancesMobGroup;

		// Token: 0x040005B8 RID: 1464
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesMobGroup;

		// Token: 0x040005B9 RID: 1465
		private global::System.Windows.Forms.Label lblSettingsDistancesLocation;

		// Token: 0x040005BA RID: 1466
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesLocation;

		// Token: 0x040005BB RID: 1467
		private global::System.Windows.Forms.Label lblSettingsDistancesWaypoint;

		// Token: 0x040005BC RID: 1468
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesWaypoint;

		// Token: 0x040005BD RID: 1469
		private global::Guna.UI2.WinForms.Guna2Separator sepSettingsDistances1;

		// Token: 0x040005BE RID: 1470
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsMount;

		// Token: 0x040005BF RID: 1471
		private global::System.Windows.Forms.Label lblSettingsFlightMount;

		// Token: 0x040005C0 RID: 1472
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsFlightMount;

		// Token: 0x040005C1 RID: 1473
		private global::System.Windows.Forms.Label lblSettingsGroundMount;

		// Token: 0x040005C2 RID: 1474
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsGroundMount;

		// Token: 0x040005C3 RID: 1475
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsLoot;

		// Token: 0x040005C4 RID: 1476
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootGatherMobs;

		// Token: 0x040005C5 RID: 1477
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootQuestItems;

		// Token: 0x040005C6 RID: 1478
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleGather;

		// Token: 0x040005C7 RID: 1479
		private global::System.Windows.Forms.Label lblSettingsLootGatherDistance;

		// Token: 0x040005C8 RID: 1480
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootGatherDistance;

		// Token: 0x040005C9 RID: 1481
		private global::System.Windows.Forms.Label lblSettingsLootMaxPathDistance;

		// Token: 0x040005CA RID: 1482
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootMaxPathDistance;

		// Token: 0x040005CB RID: 1483
		private global::System.Windows.Forms.Label lblSettingsLootDistance;

		// Token: 0x040005CC RID: 1484
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootDistance;

		// Token: 0x040005CD RID: 1485
		private global::Guna.UI2.WinForms.Guna2Separator sepOverlayESPObjects2;

		// Token: 0x040005CE RID: 1486
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootSkinning;

		// Token: 0x040005CF RID: 1487
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLoot;

		// Token: 0x040005D0 RID: 1488
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootHerbalism;

		// Token: 0x040005D1 RID: 1489
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootMining;

		// Token: 0x040005D2 RID: 1490
		private global::Guna.UI2.WinForms.Guna2GroupBox grpMobs;

		// Token: 0x040005D3 RID: 1491
		private global::Guna.UI2.WinForms.Guna2Panel panelMobs;

		// Token: 0x040005D4 RID: 1492
		private global::System.Windows.Forms.RichTextBox richSettingsMobs;

		// Token: 0x040005D5 RID: 1493
		private global::System.Windows.Forms.Label lblMobs;

		// Token: 0x040005D6 RID: 1494
		private global::System.Windows.Forms.Label lblSettingsLootAvoidElitesDistanceInfo;

		// Token: 0x040005D7 RID: 1495
		private global::System.Windows.Forms.Label lblSettingsLootAvoidElitesDistance;

		// Token: 0x040005D8 RID: 1496
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootAvoidElitesDistance;

		// Token: 0x040005D9 RID: 1497
		private global::System.Windows.Forms.ComboBox selectBattlegroundClassicStrandOfTheAncients;

		// Token: 0x040005DA RID: 1498
		private global::Guna.UI2.WinForms.Guna2CheckBox checkBattlegroundClassicStrandOfTheAncients;

		// Token: 0x040005DB RID: 1499
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderVendorMount;

		// Token: 0x040005DC RID: 1500
		private global::System.Windows.Forms.Label lblRecorderVendorMountKeybind;

		// Token: 0x040005DD RID: 1501
		private global::Guna.UI2.WinForms.Guna2GroupBox grpFishingOptions;

		// Token: 0x040005DE RID: 1502
		private global::Guna.UI2.WinForms.Guna2CheckBox checkFishingOptionsRandomDelay;

		// Token: 0x040005DF RID: 1503
		private global::System.Windows.Forms.Label lblCurrentTargetLocation;

		// Token: 0x040005E0 RID: 1504
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderSetLandingField;

		// Token: 0x040005E1 RID: 1505
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator5;

		// Token: 0x040005E2 RID: 1506
		private global::System.Windows.Forms.Label lblRecorderLandingFieldLocation;

		// Token: 0x040005E3 RID: 1507
		private global::System.Windows.Forms.Label lblRecorderLandingField;

		// Token: 0x040005E4 RID: 1508
		private global::System.Windows.Forms.Label lblRecorder;

		// Token: 0x040005E5 RID: 1509
		private global::Guna.UI2.WinForms.Guna2Panel panelRecorderInfo;

		// Token: 0x040005E6 RID: 1510
		private global::System.Windows.Forms.Label lblRecorderShow;

		// Token: 0x040005E7 RID: 1511
		private global::System.Windows.Forms.Label lblRecorderInfo;
	}
}
