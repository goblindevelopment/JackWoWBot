namespace Jack.Forms
{
	// Token: 0x020000A7 RID: 167
	public partial class frmProfile : global::System.Windows.Forms.Form
	{
		// Token: 0x06001188 RID: 4488 RVA: 0x006E064C File Offset: 0x006DE84C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x006E0678 File Offset: 0x006DE878
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmProfile));
			this.lblRecorderShowLastWaypoints = new global::System.Windows.Forms.Label();
			this.lblRecorderShowLast = new global::System.Windows.Forms.Label();
			this.lblRecorderAutoRecordDistance = new global::System.Windows.Forms.Label();
			this.lblRecorderAutoRecord = new global::System.Windows.Forms.Label();
			this.listWaypoints = new global::System.Windows.Forms.ListView();
			this.listWaypointsCount = new global::System.Windows.Forms.ColumnHeader();
			this.listWaypointsEvents = new global::System.Windows.Forms.ColumnHeader();
			this.listWaypointsEventsCount = new global::System.Windows.Forms.ColumnHeader();
			this.listEvents = new global::System.Windows.Forms.ListView();
			this.listEventsCount = new global::System.Windows.Forms.ColumnHeader();
			this.listEventsEvent = new global::System.Windows.Forms.ColumnHeader();
			this.listBlacklist = new global::System.Windows.Forms.ListView();
			this.listBlacklistName = new global::System.Windows.Forms.ColumnHeader();
			this.listBlacklistObjects = new global::System.Windows.Forms.ListView();
			this.listBlacklistObjectsName = new global::System.Windows.Forms.ColumnHeader();
			this.listBlacklistObjectsDistance = new global::System.Windows.Forms.ColumnHeader();
			this.listBlacklistObjectsGUID = new global::System.Windows.Forms.ColumnHeader();
			this.lblProfileName = new global::System.Windows.Forms.Label();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelRecorder = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpRecorder = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkRecorderAutoQuest = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblRecorderAutoRecordDistanceYards = new global::System.Windows.Forms.Label();
			this.btnRecorderSingle = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRecorderStart = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtRecorderShowLast = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtRecorderAutoRecordDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkRecorderAutoRecord = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabRecorder = new global::System.Windows.Forms.TabPage();
			this.tableRecorder = new global::System.Windows.Forms.TableLayoutPanel();
			this.grpRecorderEvents = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.grpRecorderWaypoints = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.tabSettings = new global::System.Windows.Forms.TabPage();
			this.panelTabSettings = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpSettingsMode = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSettingsModeTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkSettingsModeMesh = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsModeFollowFleeingTarget = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectSettingsWaypointMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectSettingsCombatMode = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblSettingsCombatMode = new global::System.Windows.Forms.Label();
			this.lblSettingsWaypointsMode = new global::System.Windows.Forms.Label();
			this.grpSettingsDistances = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSettingsDistancesTooltip = new global::Guna.UI2.WinForms.Guna2Button();
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
			this.btnSettingsLootTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblSettingsLootGatherDistance = new global::System.Windows.Forms.Label();
			this.txtSettingsLootGatherDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblSettingsLootMaxPathDistance = new global::System.Windows.Forms.Label();
			this.txtSettingsLootMaxPathDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblSettingsLootDetectionDistanceInfo = new global::System.Windows.Forms.Label();
			this.lblSettingsLootDistance = new global::System.Windows.Forms.Label();
			this.txtSettingsLootDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.sepOverlayESPObjects2 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.checkSettingsLootSkinning = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsLoot = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsLootHerbalism = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkSettingsLootMining = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabMobs = new global::System.Windows.Forms.TabPage();
			this.grpMobs = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnMobsTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelMobs = new global::Guna.UI2.WinForms.Guna2Panel();
			this.richMobs = new global::System.Windows.Forms.RichTextBox();
			this.lblMobs = new global::System.Windows.Forms.Label();
			this.tabBlacklist = new global::System.Windows.Forms.TabPage();
			this.tableBlacklist = new global::System.Windows.Forms.TableLayoutPanel();
			this.grpBlacklistObjects = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnBlacklistTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnBlacklistReload = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpBlacklist = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnWhitelistNameOrID = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnBlacklistNameOrID = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabStuckPaths = new global::System.Windows.Forms.TabPage();
			this.panelTabStuckPaths = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpStuckPaths = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnStuckPathsTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnStuckPathsReload = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectStuckPathsOrder = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.btnStuckPathsAroundMeSet = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnStuckPathsAroundMe = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.txtStuckPathsEditList = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.listStuckPaths = new global::System.Windows.Forms.ListView();
			this.listStuckPathsIndex = new global::System.Windows.Forms.ColumnHeader();
			this.listStuckPathsName = new global::System.Windows.Forms.ColumnHeader();
			this.listStuckPathsDivision = new global::System.Windows.Forms.ColumnHeader();
			this.listStuckPathsRadius = new global::System.Windows.Forms.ColumnHeader();
			this.listStuckPathsRotation = new global::System.Windows.Forms.ColumnHeader();
			this.listStuckPathsDistance = new global::System.Windows.Forms.ColumnHeader();
			this.lblStuckPathsDivision = new global::System.Windows.Forms.Label();
			this.selectStuckPathsDivision = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.txtStuckPathRotation = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.trackStuckPathsRotation = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.lblStuckPathsRotation = new global::System.Windows.Forms.Label();
			this.txtStuckPathRadius = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnStuckPathsStart = new global::Guna.UI2.WinForms.Guna2Button();
			this.trackStuckPathsRadius = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.lblStuckPathsRadius = new global::System.Windows.Forms.Label();
			this.sepStuckPaths1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.tabClimbSpots = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.grpClimbSpots = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnClimbSpotsTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtClimbSpotsEditRadius = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblClimbSpotCheckSpotRadius = new global::System.Windows.Forms.Label();
			this.txtClimbSpotCheckSpotRadius = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkClimbSpotCheckSpot = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.btnClimbSpotAdd = new global::Guna.UI2.WinForms.Guna2Button();
			this.listClimbSpots = new global::System.Windows.Forms.ListView();
			this.listClimbSpotsCount = new global::System.Windows.Forms.ColumnHeader();
			this.listClimbSpotsSpot = new global::System.Windows.Forms.ColumnHeader();
			this.listClimbSpotsCheckSpot = new global::System.Windows.Forms.ColumnHeader();
			this.listClimbSpotsRadius = new global::System.Windows.Forms.ColumnHeader();
			this.grpClimbSettings = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkClimbSpotsSettingsShowConnections = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkClimbSpotsSettingsHerbs = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkClimbSpotsSettingsOres = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkClimbSpotsSettingsUseClimbSpots = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabExpert = new global::System.Windows.Forms.TabPage();
			this.panelTabExpert = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpExpertFlightSens = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnExpertFlightSensDefault = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblExpertFlightSensData = new global::System.Windows.Forms.Label();
			this.trackExpertFlightSens = new global::Guna.UI2.WinForms.Guna2TrackBar();
			this.lblExpertFlightSens = new global::System.Windows.Forms.Label();
			this.sepExpertFlightSens1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblExpertFlightSensInfo1 = new global::System.Windows.Forms.Label();
			this.grpExpertSettings = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblExpertMountDelayMS = new global::System.Windows.Forms.Label();
			this.txtExpertMountDelay = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblExpertMountDelay = new global::System.Windows.Forms.Label();
			this.lblExpertResurrectDelayMS = new global::System.Windows.Forms.Label();
			this.txtExpertResurrectDelay = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblExpertResurrectDelay = new global::System.Windows.Forms.Label();
			this.btnExpertTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblExpertLootDelayMs = new global::System.Windows.Forms.Label();
			this.txtExpertLootDelay = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblExpertLootDelay = new global::System.Windows.Forms.Label();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnRecorderSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblClimbSpotsInfo = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.panelRecorder.SuspendLayout();
			this.grpRecorder.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabRecorder.SuspendLayout();
			this.tableRecorder.SuspendLayout();
			this.grpRecorderEvents.SuspendLayout();
			this.grpRecorderWaypoints.SuspendLayout();
			this.tabSettings.SuspendLayout();
			this.panelTabSettings.SuspendLayout();
			this.grpSettingsMode.SuspendLayout();
			this.grpSettingsDistances.SuspendLayout();
			this.grpSettingsMount.SuspendLayout();
			this.grpSettingsLoot.SuspendLayout();
			this.imgModuleGather.BeginInit();
			this.tabMobs.SuspendLayout();
			this.grpMobs.SuspendLayout();
			this.panelMobs.SuspendLayout();
			this.tabBlacklist.SuspendLayout();
			this.tableBlacklist.SuspendLayout();
			this.grpBlacklistObjects.SuspendLayout();
			this.grpBlacklist.SuspendLayout();
			this.tabStuckPaths.SuspendLayout();
			this.panelTabStuckPaths.SuspendLayout();
			this.grpStuckPaths.SuspendLayout();
			this.tabClimbSpots.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.grpClimbSpots.SuspendLayout();
			this.grpClimbSettings.SuspendLayout();
			this.tabExpert.SuspendLayout();
			this.panelTabExpert.SuspendLayout();
			this.grpExpertFlightSens.SuspendLayout();
			this.grpExpertSettings.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.lblRecorderShowLastWaypoints.AutoSize = true;
			this.lblRecorderShowLastWaypoints.Location = new global::System.Drawing.Point(260, 128);
			this.lblRecorderShowLastWaypoints.Name = "lblRecorderShowLastWaypoints";
			this.lblRecorderShowLastWaypoints.Size = new global::System.Drawing.Size(66, 15);
			this.lblRecorderShowLastWaypoints.TabIndex = 59;
			this.lblRecorderShowLastWaypoints.Text = "Waypoints.";
			this.lblRecorderShowLast.AutoSize = true;
			this.lblRecorderShowLast.Location = new global::System.Drawing.Point(22, 128);
			this.lblRecorderShowLast.Name = "lblRecorderShowLast";
			this.lblRecorderShowLast.Size = new global::System.Drawing.Size(57, 15);
			this.lblRecorderShowLast.TabIndex = 57;
			this.lblRecorderShowLast.Text = "Show last";
			this.lblRecorderAutoRecordDistance.AutoSize = true;
			this.lblRecorderAutoRecordDistance.Location = new global::System.Drawing.Point(22, 93);
			this.lblRecorderAutoRecordDistance.Name = "lblRecorderAutoRecordDistance";
			this.lblRecorderAutoRecordDistance.Size = new global::System.Drawing.Size(86, 15);
			this.lblRecorderAutoRecordDistance.TabIndex = 18;
			this.lblRecorderAutoRecordDistance.Text = "Auto-Distance:";
			this.lblRecorderAutoRecord.AutoSize = true;
			this.lblRecorderAutoRecord.Location = new global::System.Drawing.Point(22, 60);
			this.lblRecorderAutoRecord.Name = "lblRecorderAutoRecord";
			this.lblRecorderAutoRecord.Size = new global::System.Drawing.Size(78, 15);
			this.lblRecorderAutoRecord.TabIndex = 16;
			this.lblRecorderAutoRecord.Text = "Auto-Record:";
			this.listWaypoints.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listWaypoints.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listWaypoints.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listWaypointsCount,
				this.listWaypointsEvents,
				this.listWaypointsEventsCount
			});
			this.listWaypoints.ForeColor = global::System.Drawing.Color.White;
			this.listWaypoints.FullRowSelect = true;
			this.listWaypoints.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listWaypoints.HideSelection = false;
			this.listWaypoints.Location = new global::System.Drawing.Point(10, 51);
			this.listWaypoints.Name = "listWaypoints";
			this.listWaypoints.OwnerDraw = true;
			this.listWaypoints.Size = new global::System.Drawing.Size(376, 123);
			this.listWaypoints.TabIndex = 51;
			this.listWaypoints.UseCompatibleStateImageBehavior = false;
			this.listWaypoints.View = global::System.Windows.Forms.View.Details;
			this.listWaypoints.SelectedIndexChanged += new global::System.EventHandler(this.listWaypoints_SelectedIndexChanged);
			this.listWaypoints.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listWaypoints_KeyDown);
			this.listWaypoints.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listWaypoints_MouseClick);
			this.listWaypoints.Resize += new global::System.EventHandler(this.listWaypoints_Resize);
			this.listWaypointsCount.Text = "#";
			this.listWaypointsCount.Width = 40;
			this.listWaypointsEvents.Text = "Waypoint/Event";
			this.listWaypointsEvents.Width = 200;
			this.listWaypointsEventsCount.Text = "";
			this.listEvents.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listEvents.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listEvents.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listEventsCount,
				this.listEventsEvent
			});
			this.listEvents.ForeColor = global::System.Drawing.Color.White;
			this.listEvents.FullRowSelect = true;
			this.listEvents.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listEvents.HideSelection = false;
			this.listEvents.Location = new global::System.Drawing.Point(10, 51);
			this.listEvents.Name = "listEvents";
			this.listEvents.OwnerDraw = true;
			this.listEvents.Size = new global::System.Drawing.Size(376, 123);
			this.listEvents.TabIndex = 52;
			this.listEvents.UseCompatibleStateImageBehavior = false;
			this.listEvents.View = global::System.Windows.Forms.View.Details;
			this.listEvents.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listEvents_KeyDown);
			this.listEvents.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listEvents_MouseDoubleClick);
			this.listEvents.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.listEvents_MouseUp);
			this.listEvents.Resize += new global::System.EventHandler(this.listEvents_Resize);
			this.listEventsCount.Text = "#";
			this.listEventsCount.Width = 40;
			this.listEventsEvent.Text = "Event";
			this.listEventsEvent.Width = 250;
			this.listBlacklist.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listBlacklist.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listBlacklist.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listBlacklistName
			});
			this.listBlacklist.ForeColor = global::System.Drawing.Color.White;
			this.listBlacklist.FullRowSelect = true;
			this.listBlacklist.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listBlacklist.HideSelection = false;
			this.listBlacklist.Location = new global::System.Drawing.Point(10, 51);
			this.listBlacklist.MultiSelect = false;
			this.listBlacklist.Name = "listBlacklist";
			this.listBlacklist.OwnerDraw = true;
			this.listBlacklist.Size = new global::System.Drawing.Size(376, 85);
			this.listBlacklist.TabIndex = 57;
			this.listBlacklist.UseCompatibleStateImageBehavior = false;
			this.listBlacklist.View = global::System.Windows.Forms.View.Details;
			this.listBlacklist.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listBlacklist_KeyDown);
			this.listBlacklist.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listBlacklist_MouseClick);
			this.listBlacklist.Resize += new global::System.EventHandler(this.listBlacklist_Resize);
			this.listBlacklistName.Text = "Object Name";
			this.listBlacklistName.Width = 180;
			this.listBlacklistObjects.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listBlacklistObjects.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listBlacklistObjects.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listBlacklistObjectsName,
				this.listBlacklistObjectsDistance,
				this.listBlacklistObjectsGUID
			});
			this.listBlacklistObjects.ForeColor = global::System.Drawing.Color.White;
			this.listBlacklistObjects.FullRowSelect = true;
			this.listBlacklistObjects.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listBlacklistObjects.HideSelection = false;
			this.listBlacklistObjects.Location = new global::System.Drawing.Point(10, 51);
			this.listBlacklistObjects.MultiSelect = false;
			this.listBlacklistObjects.Name = "listBlacklistObjects";
			this.listBlacklistObjects.OwnerDraw = true;
			this.listBlacklistObjects.Size = new global::System.Drawing.Size(376, 85);
			this.listBlacklistObjects.TabIndex = 55;
			this.listBlacklistObjects.UseCompatibleStateImageBehavior = false;
			this.listBlacklistObjects.View = global::System.Windows.Forms.View.Details;
			this.listBlacklistObjects.SelectedIndexChanged += new global::System.EventHandler(this.listBlacklistObjects_SelectedIndexChanged);
			this.listBlacklistObjects.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listBlacklistObjects_MouseClick);
			this.listBlacklistObjects.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listBlacklistObjects_MouseDoubleClick);
			this.listBlacklistObjects.Resize += new global::System.EventHandler(this.listBlacklistObjects_Resize);
			this.listBlacklistObjectsName.Text = "Object Name";
			this.listBlacklistObjectsName.Width = 180;
			this.listBlacklistObjectsDistance.Text = "Distance";
			this.listBlacklistObjectsDistance.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.listBlacklistObjectsGUID.Text = "";
			this.listBlacklistObjectsGUID.Width = 0;
			this.lblProfileName.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblProfileName.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.lblProfileName.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.lblProfileName.Location = new global::System.Drawing.Point(24, 612);
			this.lblProfileName.Name = "lblProfileName";
			this.lblProfileName.Size = new global::System.Drawing.Size(571, 23);
			this.lblProfileName.TabIndex = 51;
			this.lblProfileName.Text = "[PROFILE NAME]";
			this.lblProfileName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblProfileName.Visible = false;
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.btnTooltip);
			this.panelBox1.Controls.Add(this.panelRecorder);
			this.panelBox1.Controls.Add(this.tabs);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(873, 517);
			this.panelBox1.TabIndex = 67;
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
			this.btnTooltip.Location = new global::System.Drawing.Point(818, 13);
			this.btnTooltip.Name = "btnTooltip";
			this.btnTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnTooltip.TabIndex = 72;
			this.btnTooltip.Click += new global::System.EventHandler(this.btnTooltip_Click);
			this.panelRecorder.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelRecorder.BackColor = global::System.Drawing.Color.Transparent;
			this.panelRecorder.BorderColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelRecorder.BorderThickness = 2;
			this.panelRecorder.Controls.Add(this.grpRecorder);
			this.panelRecorder.CustomBorderColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelRecorder.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelRecorder.Location = new global::System.Drawing.Point(14, 301);
			this.panelRecorder.Name = "panelRecorder";
			this.panelRecorder.Size = new global::System.Drawing.Size(847, 202);
			this.panelRecorder.TabIndex = 69;
			this.grpRecorder.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpRecorder.BorderColor = global::System.Drawing.Color.FromArgb(62, 73, 92);
			this.grpRecorder.Controls.Add(this.checkRecorderAutoQuest);
			this.grpRecorder.Controls.Add(this.lblRecorderAutoRecordDistanceYards);
			this.grpRecorder.Controls.Add(this.btnRecorderSingle);
			this.grpRecorder.Controls.Add(this.btnRecorderStart);
			this.grpRecorder.Controls.Add(this.txtRecorderShowLast);
			this.grpRecorder.Controls.Add(this.txtRecorderAutoRecordDistance);
			this.grpRecorder.Controls.Add(this.checkRecorderAutoRecord);
			this.grpRecorder.Controls.Add(this.lblRecorderShowLastWaypoints);
			this.grpRecorder.Controls.Add(this.lblRecorderShowLast);
			this.grpRecorder.Controls.Add(this.lblRecorderAutoRecord);
			this.grpRecorder.Controls.Add(this.lblRecorderAutoRecordDistance);
			this.grpRecorder.CustomBorderColor = global::System.Drawing.Color.FromArgb(62, 73, 92);
			this.grpRecorder.FillColor = global::System.Drawing.Color.FromArgb(40, 46, 56);
			this.grpRecorder.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRecorder.ForeColor = global::System.Drawing.Color.White;
			this.grpRecorder.Location = new global::System.Drawing.Point(18, 13);
			this.grpRecorder.Name = "grpRecorder";
			this.grpRecorder.Size = new global::System.Drawing.Size(810, 171);
			this.grpRecorder.TabIndex = 68;
			this.grpRecorder.Text = "Recorder";
			this.checkRecorderAutoQuest.Animated = true;
			this.checkRecorderAutoQuest.AutoSize = true;
			this.checkRecorderAutoQuest.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderAutoQuest.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderAutoQuest.CheckedState.BorderRadius = 0;
			this.checkRecorderAutoQuest.CheckedState.BorderThickness = 0;
			this.checkRecorderAutoQuest.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderAutoQuest.Location = new global::System.Drawing.Point(263, 60);
			this.checkRecorderAutoQuest.Name = "checkRecorderAutoQuest";
			this.checkRecorderAutoQuest.Size = new global::System.Drawing.Size(99, 19);
			this.checkRecorderAutoQuest.TabIndex = 72;
			this.checkRecorderAutoQuest.Text = "Quest-Tracker";
			this.checkRecorderAutoQuest.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderAutoQuest.UncheckedState.BorderRadius = 0;
			this.checkRecorderAutoQuest.UncheckedState.BorderThickness = 1;
			this.checkRecorderAutoQuest.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderAutoQuest.UseVisualStyleBackColor = false;
			this.checkRecorderAutoQuest.CheckedChanged += new global::System.EventHandler(this.checkRecorderAutoQuest_CheckedChanged);
			this.lblRecorderAutoRecordDistanceYards.AutoSize = true;
			this.lblRecorderAutoRecordDistanceYards.Location = new global::System.Drawing.Point(260, 93);
			this.lblRecorderAutoRecordDistanceYards.Name = "lblRecorderAutoRecordDistanceYards";
			this.lblRecorderAutoRecordDistanceYards.Size = new global::System.Drawing.Size(28, 15);
			this.lblRecorderAutoRecordDistanceYards.TabIndex = 71;
			this.lblRecorderAutoRecordDistanceYards.Text = "yds.";
			this.btnRecorderSingle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderSingle.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecorderSingle.BorderThickness = 1;
			this.btnRecorderSingle.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderSingle.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderSingle.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecorderSingle.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecorderSingle.Enabled = false;
			this.btnRecorderSingle.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnRecorderSingle.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderSingle.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderSingle.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecorderSingle.Location = new global::System.Drawing.Point(603, 112);
			this.btnRecorderSingle.Name = "btnRecorderSingle";
			this.btnRecorderSingle.Size = new global::System.Drawing.Size(185, 35);
			this.btnRecorderSingle.TabIndex = 69;
			this.btnRecorderSingle.Text = "Add Single";
			this.btnRecorderSingle.Click += new global::System.EventHandler(this.btnRecorderSingle_Click);
			this.btnRecorderStart.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderStart.BorderColor = global::System.Drawing.Color.Gray;
			this.btnRecorderStart.BorderThickness = 1;
			this.btnRecorderStart.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderStart.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnRecorderStart.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnRecorderStart.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRecorderStart.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnRecorderStart.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderStart.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderStart.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnRecorderStart.Location = new global::System.Drawing.Point(603, 68);
			this.btnRecorderStart.Name = "btnRecorderStart";
			this.btnRecorderStart.Size = new global::System.Drawing.Size(185, 38);
			this.btnRecorderStart.TabIndex = 68;
			this.btnRecorderStart.Text = "Start Recording";
			this.btnRecorderStart.Click += new global::System.EventHandler(this.btnRecorderStart_Click);
			this.txtRecorderShowLast.BorderColor = global::System.Drawing.Color.Gray;
			this.txtRecorderShowLast.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtRecorderShowLast.DefaultText = "20";
			this.txtRecorderShowLast.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtRecorderShowLast.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtRecorderShowLast.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtRecorderShowLast.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtRecorderShowLast.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtRecorderShowLast.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtRecorderShowLast.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtRecorderShowLast.ForeColor = global::System.Drawing.Color.White;
			this.txtRecorderShowLast.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtRecorderShowLast.Location = new global::System.Drawing.Point(180, 121);
			this.txtRecorderShowLast.MaxLength = 3;
			this.txtRecorderShowLast.Name = "txtRecorderShowLast";
			this.txtRecorderShowLast.PasswordChar = '\0';
			this.txtRecorderShowLast.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtRecorderShowLast.PlaceholderText = "";
			this.txtRecorderShowLast.SelectedText = "";
			this.txtRecorderShowLast.Size = new global::System.Drawing.Size(68, 30);
			this.txtRecorderShowLast.TabIndex = 66;
			this.txtRecorderShowLast.TextChanged += new global::System.EventHandler(this.txtRecorderShowLast_TextChanged);
			this.txtRecorderAutoRecordDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.txtRecorderAutoRecordDistance.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtRecorderAutoRecordDistance.DefaultText = "15";
			this.txtRecorderAutoRecordDistance.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtRecorderAutoRecordDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtRecorderAutoRecordDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtRecorderAutoRecordDistance.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtRecorderAutoRecordDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtRecorderAutoRecordDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtRecorderAutoRecordDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtRecorderAutoRecordDistance.ForeColor = global::System.Drawing.Color.White;
			this.txtRecorderAutoRecordDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtRecorderAutoRecordDistance.Location = new global::System.Drawing.Point(180, 85);
			this.txtRecorderAutoRecordDistance.MaxLength = 3;
			this.txtRecorderAutoRecordDistance.Name = "txtRecorderAutoRecordDistance";
			this.txtRecorderAutoRecordDistance.PasswordChar = '\0';
			this.txtRecorderAutoRecordDistance.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtRecorderAutoRecordDistance.PlaceholderText = "";
			this.txtRecorderAutoRecordDistance.SelectedText = "";
			this.txtRecorderAutoRecordDistance.Size = new global::System.Drawing.Size(68, 30);
			this.txtRecorderAutoRecordDistance.TabIndex = 65;
			this.txtRecorderAutoRecordDistance.TextChanged += new global::System.EventHandler(this.txtRecorderAutoRecordDistance_TextChanged);
			this.checkRecorderAutoRecord.Animated = true;
			this.checkRecorderAutoRecord.AutoSize = true;
			this.checkRecorderAutoRecord.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRecorderAutoRecord.Checked = true;
			this.checkRecorderAutoRecord.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderAutoRecord.CheckedState.BorderRadius = 0;
			this.checkRecorderAutoRecord.CheckedState.BorderThickness = 0;
			this.checkRecorderAutoRecord.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRecorderAutoRecord.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkRecorderAutoRecord.Location = new global::System.Drawing.Point(180, 60);
			this.checkRecorderAutoRecord.Name = "checkRecorderAutoRecord";
			this.checkRecorderAutoRecord.Size = new global::System.Drawing.Size(68, 19);
			this.checkRecorderAutoRecord.TabIndex = 60;
			this.checkRecorderAutoRecord.Text = "Enabled";
			this.checkRecorderAutoRecord.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRecorderAutoRecord.UncheckedState.BorderRadius = 0;
			this.checkRecorderAutoRecord.UncheckedState.BorderThickness = 1;
			this.checkRecorderAutoRecord.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRecorderAutoRecord.UseVisualStyleBackColor = false;
			this.checkRecorderAutoRecord.CheckedChanged += new global::System.EventHandler(this.checkRecorderAutoRecord_CheckedChanged);
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabRecorder);
			this.tabs.Controls.Add(this.tabSettings);
			this.tabs.Controls.Add(this.tabMobs);
			this.tabs.Controls.Add(this.tabBlacklist);
			this.tabs.Controls.Add(this.tabStuckPaths);
			this.tabs.Controls.Add(this.tabClimbSpots);
			this.tabs.Controls.Add(this.tabExpert);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(120, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(847, 248);
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
			this.tabRecorder.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabRecorder.Controls.Add(this.tableRecorder);
			this.tabRecorder.ForeColor = global::System.Drawing.Color.White;
			this.tabRecorder.Location = new global::System.Drawing.Point(4, 44);
			this.tabRecorder.Name = "tabRecorder";
			this.tabRecorder.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabRecorder.Size = new global::System.Drawing.Size(839, 200);
			this.tabRecorder.TabIndex = 0;
			this.tabRecorder.Text = "Recorder";
			this.tableRecorder.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableRecorder.ColumnCount = 2;
			this.tableRecorder.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableRecorder.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableRecorder.Controls.Add(this.grpRecorderEvents, 1, 0);
			this.tableRecorder.Controls.Add(this.grpRecorderWaypoints, 0, 0);
			this.tableRecorder.Location = new global::System.Drawing.Point(14, 14);
			this.tableRecorder.Name = "tableRecorder";
			this.tableRecorder.RowCount = 1;
			this.tableRecorder.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableRecorder.Size = new global::System.Drawing.Size(810, 185);
			this.tableRecorder.TabIndex = 8;
			this.grpRecorderEvents.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpRecorderEvents.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpRecorderEvents.Controls.Add(this.listEvents);
			this.grpRecorderEvents.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpRecorderEvents.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpRecorderEvents.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRecorderEvents.ForeColor = global::System.Drawing.Color.White;
			this.grpRecorderEvents.Location = new global::System.Drawing.Point(414, 0);
			this.grpRecorderEvents.Margin = new global::System.Windows.Forms.Padding(9, 0, 0, 0);
			this.grpRecorderEvents.Name = "grpRecorderEvents";
			this.grpRecorderEvents.Size = new global::System.Drawing.Size(396, 185);
			this.grpRecorderEvents.TabIndex = 8;
			this.grpRecorderEvents.Text = "Events";
			this.grpRecorderWaypoints.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpRecorderWaypoints.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpRecorderWaypoints.Controls.Add(this.listWaypoints);
			this.grpRecorderWaypoints.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpRecorderWaypoints.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpRecorderWaypoints.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRecorderWaypoints.ForeColor = global::System.Drawing.Color.White;
			this.grpRecorderWaypoints.Location = new global::System.Drawing.Point(0, 0);
			this.grpRecorderWaypoints.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpRecorderWaypoints.Name = "grpRecorderWaypoints";
			this.grpRecorderWaypoints.Size = new global::System.Drawing.Size(396, 185);
			this.grpRecorderWaypoints.TabIndex = 7;
			this.grpRecorderWaypoints.Text = "Waypoints";
			this.tabSettings.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabSettings.Controls.Add(this.panelTabSettings);
			this.tabSettings.ForeColor = global::System.Drawing.Color.White;
			this.tabSettings.Location = new global::System.Drawing.Point(4, 44);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Size = new global::System.Drawing.Size(839, 200);
			this.tabSettings.TabIndex = 1;
			this.tabSettings.Text = "Settings";
			this.panelTabSettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabSettings.AutoScroll = true;
			this.panelTabSettings.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabSettings.Controls.Add(this.grpSettingsMode);
			this.panelTabSettings.Controls.Add(this.grpSettingsDistances);
			this.panelTabSettings.Controls.Add(this.grpSettingsMount);
			this.panelTabSettings.Controls.Add(this.grpSettingsLoot);
			this.panelTabSettings.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabSettings.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabSettings.Name = "panelTabSettings";
			this.panelTabSettings.Size = new global::System.Drawing.Size(839, 200);
			this.panelTabSettings.TabIndex = 68;
			this.grpSettingsMode.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsMode.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsMode.Controls.Add(this.btnSettingsModeTooltip);
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
			this.grpSettingsMode.Size = new global::System.Drawing.Size(652, 215);
			this.grpSettingsMode.TabIndex = 64;
			this.grpSettingsMode.Text = "Mode";
			this.btnSettingsModeTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSettingsModeTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsModeTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSettingsModeTooltip.BorderRadius = 4;
			this.btnSettingsModeTooltip.BorderThickness = 1;
			this.btnSettingsModeTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSettingsModeTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsModeTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsModeTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsModeTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsModeTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSettingsModeTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSettingsModeTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSettingsModeTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSettingsModeTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSettingsModeTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSettingsModeTooltip.Location = new global::System.Drawing.Point(605, 8);
			this.btnSettingsModeTooltip.Name = "btnSettingsModeTooltip";
			this.btnSettingsModeTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSettingsModeTooltip.TabIndex = 73;
			this.btnSettingsModeTooltip.Click += new global::System.EventHandler(this.btnSettingsModeTooltip_Click);
			this.checkSettingsModeMesh.Animated = true;
			this.checkSettingsModeMesh.AutoSize = true;
			this.checkSettingsModeMesh.BackColor = global::System.Drawing.Color.Transparent;
			this.checkSettingsModeMesh.Checked = true;
			this.checkSettingsModeMesh.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsModeMesh.CheckedState.BorderRadius = 0;
			this.checkSettingsModeMesh.CheckedState.BorderThickness = 0;
			this.checkSettingsModeMesh.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsModeMesh.CheckState = global::System.Windows.Forms.CheckState.Checked;
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
			this.grpSettingsDistances.Controls.Add(this.btnSettingsDistancesTooltip);
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
			this.grpSettingsDistances.Size = new global::System.Drawing.Size(652, 296);
			this.grpSettingsDistances.TabIndex = 67;
			this.grpSettingsDistances.Text = "Distances";
			this.btnSettingsDistancesTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSettingsDistancesTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsDistancesTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSettingsDistancesTooltip.BorderRadius = 4;
			this.btnSettingsDistancesTooltip.BorderThickness = 1;
			this.btnSettingsDistancesTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSettingsDistancesTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsDistancesTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsDistancesTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsDistancesTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsDistancesTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSettingsDistancesTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSettingsDistancesTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSettingsDistancesTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSettingsDistancesTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSettingsDistancesTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSettingsDistancesTooltip.Location = new global::System.Drawing.Point(605, 8);
			this.btnSettingsDistancesTooltip.Name = "btnSettingsDistancesTooltip";
			this.btnSettingsDistancesTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSettingsDistancesTooltip.TabIndex = 91;
			this.btnSettingsDistancesTooltip.Click += new global::System.EventHandler(this.btnSettingsDistancesTooltip_Click);
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
			this.sepSettingsDistances1.Size = new global::System.Drawing.Size(612, 10);
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
			this.grpSettingsMount.Size = new global::System.Drawing.Size(652, 123);
			this.grpSettingsMount.TabIndex = 65;
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
			this.grpSettingsLoot.Controls.Add(this.btnSettingsLootTooltip);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootGatherDistance);
			this.grpSettingsLoot.Controls.Add(this.txtSettingsLootGatherDistance);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootMaxPathDistance);
			this.grpSettingsLoot.Controls.Add(this.txtSettingsLootMaxPathDistance);
			this.grpSettingsLoot.Controls.Add(this.lblSettingsLootDetectionDistanceInfo);
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
			this.grpSettingsLoot.Size = new global::System.Drawing.Size(652, 355);
			this.grpSettingsLoot.TabIndex = 66;
			this.grpSettingsLoot.Text = "Gathering";
			this.lblSettingsLootAvoidElitesDistanceInfo.AutoSize = true;
			this.lblSettingsLootAvoidElitesDistanceInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootAvoidElitesDistanceInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootAvoidElitesDistanceInfo.Location = new global::System.Drawing.Point(260, 311);
			this.lblSettingsLootAvoidElitesDistanceInfo.Name = "lblSettingsLootAvoidElitesDistanceInfo";
			this.lblSettingsLootAvoidElitesDistanceInfo.Size = new global::System.Drawing.Size(118, 15);
			this.lblSettingsLootAvoidElitesDistanceInfo.TabIndex = 99;
			this.lblSettingsLootAvoidElitesDistanceInfo.Text = "yards around a node.";
			this.lblSettingsLootAvoidElitesDistance.AutoSize = true;
			this.lblSettingsLootAvoidElitesDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootAvoidElitesDistance.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootAvoidElitesDistance.Location = new global::System.Drawing.Point(22, 311);
			this.lblSettingsLootAvoidElitesDistance.Name = "lblSettingsLootAvoidElitesDistance";
			this.lblSettingsLootAvoidElitesDistance.Size = new global::System.Drawing.Size(107, 15);
			this.lblSettingsLootAvoidElitesDistance.TabIndex = 98;
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
			this.txtSettingsLootAvoidElitesDistance.TabIndex = 97;
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
			this.txtSettingsLootQuestItems.Size = new global::System.Drawing.Size(223, 94);
			this.txtSettingsLootQuestItems.TabIndex = 95;
			this.txtSettingsLootQuestItems.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.txtSettingsLootQuestItems_MouseClick);
			this.imgModuleGather.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleGather.Image = global::Jack.Properties.Resources.module_gathering;
			this.imgModuleGather.ImageRotate = 0f;
			this.imgModuleGather.Location = new global::System.Drawing.Point(513, 7);
			this.imgModuleGather.Name = "imgModuleGather";
			this.imgModuleGather.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleGather.TabIndex = 90;
			this.imgModuleGather.TabStop = false;
			this.btnSettingsLootTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSettingsLootTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsLootTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSettingsLootTooltip.BorderRadius = 4;
			this.btnSettingsLootTooltip.BorderThickness = 1;
			this.btnSettingsLootTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSettingsLootTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsLootTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsLootTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsLootTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsLootTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSettingsLootTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSettingsLootTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSettingsLootTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSettingsLootTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSettingsLootTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSettingsLootTooltip.Location = new global::System.Drawing.Point(605, 196);
			this.btnSettingsLootTooltip.Name = "btnSettingsLootTooltip";
			this.btnSettingsLootTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSettingsLootTooltip.TabIndex = 89;
			this.btnSettingsLootTooltip.Click += new global::System.EventHandler(this.btnSettingsLootTooltip_Click);
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
			this.lblSettingsLootDetectionDistanceInfo.AutoSize = true;
			this.lblSettingsLootDetectionDistanceInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsLootDetectionDistanceInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblSettingsLootDetectionDistanceInfo.Location = new global::System.Drawing.Point(260, 203);
			this.lblSettingsLootDetectionDistanceInfo.Name = "lblSettingsLootDetectionDistanceInfo";
			this.lblSettingsLootDetectionDistanceInfo.Size = new global::System.Drawing.Size(29, 15);
			this.lblSettingsLootDetectionDistanceInfo.TabIndex = 81;
			this.lblSettingsLootDetectionDistanceInfo.Text = "(3D)";
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
			this.sepOverlayESPObjects2.Size = new global::System.Drawing.Size(612, 10);
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
			this.checkSettingsLoot.Checked = true;
			this.checkSettingsLoot.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLoot.CheckedState.BorderRadius = 0;
			this.checkSettingsLoot.CheckedState.BorderThickness = 0;
			this.checkSettingsLoot.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkSettingsLoot.CheckState = global::System.Windows.Forms.CheckState.Checked;
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
			this.tabMobs.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabMobs.Controls.Add(this.grpMobs);
			this.tabMobs.ForeColor = global::System.Drawing.Color.White;
			this.tabMobs.Location = new global::System.Drawing.Point(4, 44);
			this.tabMobs.Name = "tabMobs";
			this.tabMobs.Size = new global::System.Drawing.Size(839, 200);
			this.tabMobs.TabIndex = 2;
			this.tabMobs.Text = "Mobs";
			this.grpMobs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpMobs.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMobs.Controls.Add(this.btnMobsTooltip);
			this.grpMobs.Controls.Add(this.panelMobs);
			this.grpMobs.Controls.Add(this.lblMobs);
			this.grpMobs.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMobs.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpMobs.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpMobs.ForeColor = global::System.Drawing.Color.White;
			this.grpMobs.Location = new global::System.Drawing.Point(14, 14);
			this.grpMobs.Name = "grpMobs";
			this.grpMobs.Size = new global::System.Drawing.Size(810, 183);
			this.grpMobs.TabIndex = 55;
			this.grpMobs.Text = "Attackable Mobs";
			this.btnMobsTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnMobsTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnMobsTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnMobsTooltip.BorderRadius = 4;
			this.btnMobsTooltip.BorderThickness = 1;
			this.btnMobsTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnMobsTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnMobsTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnMobsTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnMobsTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnMobsTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnMobsTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnMobsTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnMobsTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnMobsTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnMobsTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnMobsTooltip.Location = new global::System.Drawing.Point(763, 8);
			this.btnMobsTooltip.Name = "btnMobsTooltip";
			this.btnMobsTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnMobsTooltip.TabIndex = 74;
			this.btnMobsTooltip.Click += new global::System.EventHandler(this.btnMobsTooltip_Click);
			this.panelMobs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelMobs.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelMobs.BorderColor = global::System.Drawing.Color.Gray;
			this.panelMobs.BorderThickness = 1;
			this.panelMobs.Controls.Add(this.richMobs);
			this.panelMobs.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.panelMobs.Location = new global::System.Drawing.Point(25, 107);
			this.panelMobs.Name = "panelMobs";
			this.panelMobs.Size = new global::System.Drawing.Size(763, 55);
			this.panelMobs.TabIndex = 70;
			this.richMobs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richMobs.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.richMobs.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richMobs.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.richMobs.ForeColor = global::System.Drawing.Color.White;
			this.richMobs.Location = new global::System.Drawing.Point(10, 10);
			this.richMobs.Name = "richMobs";
			this.richMobs.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richMobs.Size = new global::System.Drawing.Size(744, 36);
			this.richMobs.TabIndex = 11;
			this.richMobs.Text = "";
			this.richMobs.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.richMobs_KeyUp);
			this.lblMobs.AutoSize = true;
			this.lblMobs.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMobs.Location = new global::System.Drawing.Point(22, 60);
			this.lblMobs.Name = "lblMobs";
			this.lblMobs.Size = new global::System.Drawing.Size(573, 30);
			this.lblMobs.TabIndex = 69;
			this.lblMobs.Text = "Enter all attackable Mobs (by NAME or ID) \"line by line\" or \"comma separated\".\r\nAdd Wildcards with a * to attack Mobs that \"contains\" the name, like *Wolf or *Wolf Name* or Wolf Name*.";
			this.tabBlacklist.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabBlacklist.Controls.Add(this.tableBlacklist);
			this.tabBlacklist.ForeColor = global::System.Drawing.Color.White;
			this.tabBlacklist.Location = new global::System.Drawing.Point(4, 44);
			this.tabBlacklist.Name = "tabBlacklist";
			this.tabBlacklist.Size = new global::System.Drawing.Size(839, 200);
			this.tabBlacklist.TabIndex = 3;
			this.tabBlacklist.Text = "Black-/Whitelist";
			this.tableBlacklist.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableBlacklist.ColumnCount = 2;
			this.tableBlacklist.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableBlacklist.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableBlacklist.Controls.Add(this.grpBlacklistObjects, 1, 0);
			this.tableBlacklist.Controls.Add(this.grpBlacklist, 0, 0);
			this.tableBlacklist.Location = new global::System.Drawing.Point(14, 14);
			this.tableBlacklist.Name = "tableBlacklist";
			this.tableBlacklist.RowCount = 1;
			this.tableBlacklist.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableBlacklist.Size = new global::System.Drawing.Size(810, 183);
			this.tableBlacklist.TabIndex = 58;
			this.grpBlacklistObjects.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpBlacklistObjects.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpBlacklistObjects.Controls.Add(this.btnBlacklistTooltip);
			this.grpBlacklistObjects.Controls.Add(this.btnBlacklistReload);
			this.grpBlacklistObjects.Controls.Add(this.listBlacklistObjects);
			this.grpBlacklistObjects.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpBlacklistObjects.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpBlacklistObjects.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpBlacklistObjects.ForeColor = global::System.Drawing.Color.White;
			this.grpBlacklistObjects.Location = new global::System.Drawing.Point(414, 0);
			this.grpBlacklistObjects.Margin = new global::System.Windows.Forms.Padding(9, 0, 0, 0);
			this.grpBlacklistObjects.Name = "grpBlacklistObjects";
			this.grpBlacklistObjects.Size = new global::System.Drawing.Size(396, 183);
			this.grpBlacklistObjects.TabIndex = 8;
			this.grpBlacklistObjects.Text = "Objects";
			this.btnBlacklistTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBlacklistTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnBlacklistTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnBlacklistTooltip.BorderRadius = 4;
			this.btnBlacklistTooltip.BorderThickness = 1;
			this.btnBlacklistTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnBlacklistTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBlacklistTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnBlacklistTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBlacklistTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBlacklistTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnBlacklistTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnBlacklistTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnBlacklistTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnBlacklistTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnBlacklistTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnBlacklistTooltip.Location = new global::System.Drawing.Point(349, 8);
			this.btnBlacklistTooltip.Name = "btnBlacklistTooltip";
			this.btnBlacklistTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnBlacklistTooltip.TabIndex = 75;
			this.btnBlacklistTooltip.Click += new global::System.EventHandler(this.btnBlacklistTooltip_Click);
			this.btnBlacklistReload.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBlacklistReload.BorderColor = global::System.Drawing.Color.Gray;
			this.btnBlacklistReload.BorderThickness = 1;
			this.btnBlacklistReload.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnBlacklistReload.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnBlacklistReload.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnBlacklistReload.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnBlacklistReload.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnBlacklistReload.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnBlacklistReload.ForeColor = global::System.Drawing.Color.White;
			this.btnBlacklistReload.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnBlacklistReload.Location = new global::System.Drawing.Point(10, 146);
			this.btnBlacklistReload.Name = "btnBlacklistReload";
			this.btnBlacklistReload.Size = new global::System.Drawing.Size(376, 26);
			this.btnBlacklistReload.TabIndex = 71;
			this.btnBlacklistReload.Text = "Reload";
			this.btnBlacklistReload.Click += new global::System.EventHandler(this.btnBlacklistReload_Click);
			this.grpBlacklist.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpBlacklist.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpBlacklist.Controls.Add(this.btnWhitelistNameOrID);
			this.grpBlacklist.Controls.Add(this.btnBlacklistNameOrID);
			this.grpBlacklist.Controls.Add(this.listBlacklist);
			this.grpBlacklist.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpBlacklist.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpBlacklist.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpBlacklist.ForeColor = global::System.Drawing.Color.White;
			this.grpBlacklist.Location = new global::System.Drawing.Point(0, 0);
			this.grpBlacklist.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpBlacklist.Name = "grpBlacklist";
			this.grpBlacklist.Size = new global::System.Drawing.Size(396, 183);
			this.grpBlacklist.TabIndex = 7;
			this.grpBlacklist.Text = "Blacklisted Objects";
			this.btnWhitelistNameOrID.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnWhitelistNameOrID.BorderColor = global::System.Drawing.Color.Gray;
			this.btnWhitelistNameOrID.BorderThickness = 1;
			this.btnWhitelistNameOrID.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnWhitelistNameOrID.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnWhitelistNameOrID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnWhitelistNameOrID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnWhitelistNameOrID.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnWhitelistNameOrID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnWhitelistNameOrID.ForeColor = global::System.Drawing.Color.White;
			this.btnWhitelistNameOrID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnWhitelistNameOrID.Location = new global::System.Drawing.Point(231, 146);
			this.btnWhitelistNameOrID.Name = "btnWhitelistNameOrID";
			this.btnWhitelistNameOrID.Size = new global::System.Drawing.Size(155, 26);
			this.btnWhitelistNameOrID.TabIndex = 73;
			this.btnWhitelistNameOrID.Text = "Whitelist";
			this.btnWhitelistNameOrID.Click += new global::System.EventHandler(this.btnObjectsWhitelist_Click);
			this.btnBlacklistNameOrID.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnBlacklistNameOrID.BorderColor = global::System.Drawing.Color.Gray;
			this.btnBlacklistNameOrID.BorderThickness = 1;
			this.btnBlacklistNameOrID.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnBlacklistNameOrID.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnBlacklistNameOrID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnBlacklistNameOrID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnBlacklistNameOrID.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnBlacklistNameOrID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnBlacklistNameOrID.ForeColor = global::System.Drawing.Color.White;
			this.btnBlacklistNameOrID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnBlacklistNameOrID.Location = new global::System.Drawing.Point(10, 146);
			this.btnBlacklistNameOrID.Name = "btnBlacklistNameOrID";
			this.btnBlacklistNameOrID.Size = new global::System.Drawing.Size(155, 26);
			this.btnBlacklistNameOrID.TabIndex = 72;
			this.btnBlacklistNameOrID.Text = "Extended Blacklist";
			this.btnBlacklistNameOrID.Click += new global::System.EventHandler(this.btnBlacklist_Click);
			this.tabStuckPaths.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabStuckPaths.Controls.Add(this.panelTabStuckPaths);
			this.tabStuckPaths.Location = new global::System.Drawing.Point(4, 44);
			this.tabStuckPaths.Name = "tabStuckPaths";
			this.tabStuckPaths.Size = new global::System.Drawing.Size(839, 200);
			this.tabStuckPaths.TabIndex = 6;
			this.tabStuckPaths.Text = "Stuck Paths";
			this.panelTabStuckPaths.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabStuckPaths.AutoScroll = true;
			this.panelTabStuckPaths.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabStuckPaths.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabStuckPaths.Controls.Add(this.grpStuckPaths);
			this.panelTabStuckPaths.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabStuckPaths.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabStuckPaths.Name = "panelTabStuckPaths";
			this.panelTabStuckPaths.Size = new global::System.Drawing.Size(839, 200);
			this.panelTabStuckPaths.TabIndex = 65;
			this.grpStuckPaths.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpStuckPaths.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpStuckPaths.Controls.Add(this.btnStuckPathsTooltip);
			this.grpStuckPaths.Controls.Add(this.btnStuckPathsReload);
			this.grpStuckPaths.Controls.Add(this.selectStuckPathsOrder);
			this.grpStuckPaths.Controls.Add(this.btnStuckPathsAroundMeSet);
			this.grpStuckPaths.Controls.Add(this.btnStuckPathsAroundMe);
			this.grpStuckPaths.Controls.Add(this.guna2Separator1);
			this.grpStuckPaths.Controls.Add(this.txtStuckPathsEditList);
			this.grpStuckPaths.Controls.Add(this.listStuckPaths);
			this.grpStuckPaths.Controls.Add(this.lblStuckPathsDivision);
			this.grpStuckPaths.Controls.Add(this.selectStuckPathsDivision);
			this.grpStuckPaths.Controls.Add(this.txtStuckPathRotation);
			this.grpStuckPaths.Controls.Add(this.trackStuckPathsRotation);
			this.grpStuckPaths.Controls.Add(this.lblStuckPathsRotation);
			this.grpStuckPaths.Controls.Add(this.txtStuckPathRadius);
			this.grpStuckPaths.Controls.Add(this.btnStuckPathsStart);
			this.grpStuckPaths.Controls.Add(this.trackStuckPathsRadius);
			this.grpStuckPaths.Controls.Add(this.lblStuckPathsRadius);
			this.grpStuckPaths.Controls.Add(this.sepStuckPaths1);
			this.grpStuckPaths.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpStuckPaths.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpStuckPaths.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpStuckPaths.ForeColor = global::System.Drawing.Color.White;
			this.grpStuckPaths.Location = new global::System.Drawing.Point(14, 14);
			this.grpStuckPaths.Name = "grpStuckPaths";
			this.grpStuckPaths.Size = new global::System.Drawing.Size(788, 339);
			this.grpStuckPaths.TabIndex = 81;
			this.grpStuckPaths.Text = "Stuck Paths";
			this.btnStuckPathsTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnStuckPathsTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnStuckPathsTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnStuckPathsTooltip.BorderRadius = 4;
			this.btnStuckPathsTooltip.BorderThickness = 1;
			this.btnStuckPathsTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnStuckPathsTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnStuckPathsTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnStuckPathsTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnStuckPathsTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnStuckPathsTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnStuckPathsTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnStuckPathsTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnStuckPathsTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnStuckPathsTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnStuckPathsTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnStuckPathsTooltip.Location = new global::System.Drawing.Point(741, 8);
			this.btnStuckPathsTooltip.Name = "btnStuckPathsTooltip";
			this.btnStuckPathsTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnStuckPathsTooltip.TabIndex = 120;
			this.btnStuckPathsTooltip.Click += new global::System.EventHandler(this.btnStuckPathsTooltip_Click);
			this.btnStuckPathsReload.BorderColor = global::System.Drawing.Color.Gray;
			this.btnStuckPathsReload.BorderThickness = 1;
			this.btnStuckPathsReload.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnStuckPathsReload.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnStuckPathsReload.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnStuckPathsReload.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnStuckPathsReload.DisabledState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image");
			this.btnStuckPathsReload.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnStuckPathsReload.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnStuckPathsReload.ForeColor = global::System.Drawing.Color.White;
			this.btnStuckPathsReload.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnStuckPathsReload.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnStuckPathsReload.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnStuckPathsReload.Image");
			this.btnStuckPathsReload.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnStuckPathsReload.ImageOffset = new global::System.Drawing.Point(2, 0);
			this.btnStuckPathsReload.ImageSize = new global::System.Drawing.Size(18, 18);
			this.btnStuckPathsReload.Location = new global::System.Drawing.Point(318, 61);
			this.btnStuckPathsReload.Name = "btnStuckPathsReload";
			this.btnStuckPathsReload.Size = new global::System.Drawing.Size(44, 30);
			this.btnStuckPathsReload.TabIndex = 119;
			this.btnStuckPathsReload.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnStuckPathsReload.Click += new global::System.EventHandler(this.btnStuckPathsReload_Click);
			this.selectStuckPathsOrder.BackColor = global::System.Drawing.Color.Transparent;
			this.selectStuckPathsOrder.BorderColor = global::System.Drawing.Color.Gray;
			this.selectStuckPathsOrder.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectStuckPathsOrder.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectStuckPathsOrder.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectStuckPathsOrder.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectStuckPathsOrder.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectStuckPathsOrder.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectStuckPathsOrder.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectStuckPathsOrder.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectStuckPathsOrder.ForeColor = global::System.Drawing.Color.White;
			this.selectStuckPathsOrder.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectStuckPathsOrder.ItemHeight = 24;
			this.selectStuckPathsOrder.Items.AddRange(new object[]
			{
				"Show All",
				"Only in my Zone"
			});
			this.selectStuckPathsOrder.Location = new global::System.Drawing.Point(180, 61);
			this.selectStuckPathsOrder.Name = "selectStuckPathsOrder";
			this.selectStuckPathsOrder.Size = new global::System.Drawing.Size(127, 30);
			this.selectStuckPathsOrder.StartIndex = 0;
			this.selectStuckPathsOrder.TabIndex = 118;
			this.selectStuckPathsOrder.SelectedIndexChanged += new global::System.EventHandler(this.selectStuckPathsOrder_SelectedIndexChanged);
			this.btnStuckPathsAroundMeSet.BorderColor = global::System.Drawing.Color.Gray;
			this.btnStuckPathsAroundMeSet.BorderThickness = 1;
			this.btnStuckPathsAroundMeSet.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnStuckPathsAroundMeSet.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnStuckPathsAroundMeSet.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnStuckPathsAroundMeSet.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnStuckPathsAroundMeSet.Enabled = false;
			this.btnStuckPathsAroundMeSet.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnStuckPathsAroundMeSet.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnStuckPathsAroundMeSet.ForeColor = global::System.Drawing.Color.White;
			this.btnStuckPathsAroundMeSet.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnStuckPathsAroundMeSet.Location = new global::System.Drawing.Point(273, 288);
			this.btnStuckPathsAroundMeSet.Name = "btnStuckPathsAroundMeSet";
			this.btnStuckPathsAroundMeSet.Size = new global::System.Drawing.Size(92, 30);
			this.btnStuckPathsAroundMeSet.TabIndex = 117;
			this.btnStuckPathsAroundMeSet.Text = "Set";
			this.btnStuckPathsAroundMeSet.Click += new global::System.EventHandler(this.btnStuckPathsAroundMeSet_Click);
			this.btnStuckPathsAroundMe.BorderColor = global::System.Drawing.Color.Gray;
			this.btnStuckPathsAroundMe.BorderThickness = 1;
			this.btnStuckPathsAroundMe.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnStuckPathsAroundMe.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnStuckPathsAroundMe.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnStuckPathsAroundMe.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnStuckPathsAroundMe.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnStuckPathsAroundMe.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnStuckPathsAroundMe.ForeColor = global::System.Drawing.Color.White;
			this.btnStuckPathsAroundMe.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnStuckPathsAroundMe.Location = new global::System.Drawing.Point(25, 288);
			this.btnStuckPathsAroundMe.Name = "btnStuckPathsAroundMe";
			this.btnStuckPathsAroundMe.Size = new global::System.Drawing.Size(239, 30);
			this.btnStuckPathsAroundMe.TabIndex = 116;
			this.btnStuckPathsAroundMe.Text = "Around own Location";
			this.btnStuckPathsAroundMe.Click += new global::System.EventHandler(this.btnStuckPathsAroundMe_Click);
			this.guna2Separator1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator1.Location = new global::System.Drawing.Point(17, 263);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(350, 10);
			this.guna2Separator1.TabIndex = 112;
			this.txtStuckPathsEditList.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtStuckPathsEditList.BorderColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathsEditList.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtStuckPathsEditList.DefaultText = "";
			this.txtStuckPathsEditList.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathsEditList.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtStuckPathsEditList.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtStuckPathsEditList.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtStuckPathsEditList.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtStuckPathsEditList.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtStuckPathsEditList.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtStuckPathsEditList.ForeColor = global::System.Drawing.Color.White;
			this.txtStuckPathsEditList.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtStuckPathsEditList.Location = new global::System.Drawing.Point(344, 130);
			this.txtStuckPathsEditList.MaxLength = 3;
			this.txtStuckPathsEditList.Name = "txtStuckPathsEditList";
			this.txtStuckPathsEditList.PasswordChar = '\0';
			this.txtStuckPathsEditList.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathsEditList.PlaceholderText = "";
			this.txtStuckPathsEditList.SelectedText = "";
			this.txtStuckPathsEditList.Size = new global::System.Drawing.Size(28, 23);
			this.txtStuckPathsEditList.TabIndex = 107;
			this.txtStuckPathsEditList.Visible = false;
			this.txtStuckPathsEditList.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.txtStuckPathsEditList_KeyUp);
			this.listStuckPaths.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listStuckPaths.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listStuckPaths.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listStuckPathsIndex,
				this.listStuckPathsName,
				this.listStuckPathsDivision,
				this.listStuckPathsRadius,
				this.listStuckPathsRotation,
				this.listStuckPathsDistance
			});
			this.listStuckPaths.ForeColor = global::System.Drawing.Color.White;
			this.listStuckPaths.FullRowSelect = true;
			this.listStuckPaths.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listStuckPaths.HideSelection = false;
			this.listStuckPaths.Location = new global::System.Drawing.Point(384, 61);
			this.listStuckPaths.MultiSelect = false;
			this.listStuckPaths.Name = "listStuckPaths";
			this.listStuckPaths.OwnerDraw = true;
			this.listStuckPaths.Size = new global::System.Drawing.Size(384, 257);
			this.listStuckPaths.TabIndex = 106;
			this.listStuckPaths.UseCompatibleStateImageBehavior = false;
			this.listStuckPaths.View = global::System.Windows.Forms.View.Details;
			this.listStuckPaths.SelectedIndexChanged += new global::System.EventHandler(this.listStuckPaths_SelectedIndexChanged);
			this.listStuckPaths.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listStuckPaths_KeyDown);
			this.listStuckPaths.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listStuckPaths_MouseDoubleClick);
			this.listStuckPaths.Resize += new global::System.EventHandler(this.listStuckPaths_Resize);
			this.listStuckPathsIndex.Text = "";
			this.listStuckPathsIndex.Width = 0;
			this.listStuckPathsName.Text = "Name";
			this.listStuckPathsName.Width = 156;
			this.listStuckPathsDivision.Text = "Division";
			this.listStuckPathsRadius.Text = "Radius";
			this.listStuckPathsRadius.Width = 50;
			this.listStuckPathsRotation.Text = "Rotation";
			this.listStuckPathsDistance.Text = "Distance";
			this.lblStuckPathsDivision.AutoSize = true;
			this.lblStuckPathsDivision.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStuckPathsDivision.ForeColor = global::System.Drawing.Color.White;
			this.lblStuckPathsDivision.Location = new global::System.Drawing.Point(22, 138);
			this.lblStuckPathsDivision.Name = "lblStuckPathsDivision";
			this.lblStuckPathsDivision.Size = new global::System.Drawing.Size(52, 15);
			this.lblStuckPathsDivision.TabIndex = 105;
			this.lblStuckPathsDivision.Text = "Division:";
			this.selectStuckPathsDivision.BackColor = global::System.Drawing.Color.Transparent;
			this.selectStuckPathsDivision.BorderColor = global::System.Drawing.Color.Gray;
			this.selectStuckPathsDivision.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectStuckPathsDivision.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectStuckPathsDivision.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectStuckPathsDivision.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectStuckPathsDivision.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectStuckPathsDivision.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectStuckPathsDivision.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectStuckPathsDivision.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectStuckPathsDivision.ForeColor = global::System.Drawing.Color.White;
			this.selectStuckPathsDivision.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectStuckPathsDivision.ItemHeight = 24;
			this.selectStuckPathsDivision.Items.AddRange(new object[]
			{
				"Full",
				"Half"
			});
			this.selectStuckPathsDivision.Location = new global::System.Drawing.Point(180, 130);
			this.selectStuckPathsDivision.Name = "selectStuckPathsDivision";
			this.selectStuckPathsDivision.Size = new global::System.Drawing.Size(127, 30);
			this.selectStuckPathsDivision.StartIndex = 0;
			this.selectStuckPathsDivision.TabIndex = 104;
			this.selectStuckPathsDivision.SelectedIndexChanged += new global::System.EventHandler(this.selectStuckPathsDivision_SelectedIndexChanged);
			this.txtStuckPathRotation.BorderColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathRotation.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtStuckPathRotation.DefaultText = "0";
			this.txtStuckPathRotation.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathRotation.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtStuckPathRotation.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtStuckPathRotation.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtStuckPathRotation.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtStuckPathRotation.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtStuckPathRotation.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtStuckPathRotation.ForeColor = global::System.Drawing.Color.White;
			this.txtStuckPathRotation.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtStuckPathRotation.Location = new global::System.Drawing.Point(318, 220);
			this.txtStuckPathRotation.MaxLength = 3;
			this.txtStuckPathRotation.Name = "txtStuckPathRotation";
			this.txtStuckPathRotation.PasswordChar = '\0';
			this.txtStuckPathRotation.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathRotation.PlaceholderText = "";
			this.txtStuckPathRotation.SelectedText = "";
			this.txtStuckPathRotation.Size = new global::System.Drawing.Size(44, 30);
			this.txtStuckPathRotation.TabIndex = 103;
			this.txtStuckPathRotation.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtStuckPathRotation.TextChanged += new global::System.EventHandler(this.txtStuckPathRotation_TextChanged);
			this.trackStuckPathsRotation.BackColor = global::System.Drawing.Color.Transparent;
			this.trackStuckPathsRotation.LargeChange = 2;
			this.trackStuckPathsRotation.Location = new global::System.Drawing.Point(180, 224);
			this.trackStuckPathsRotation.Maximum = 10;
			this.trackStuckPathsRotation.Name = "trackStuckPathsRotation";
			this.trackStuckPathsRotation.Size = new global::System.Drawing.Size(127, 23);
			this.trackStuckPathsRotation.Style = 1;
			this.trackStuckPathsRotation.TabIndex = 102;
			this.trackStuckPathsRotation.ThumbColor = global::System.Drawing.Color.DeepSkyBlue;
			this.trackStuckPathsRotation.Value = 0;
			this.trackStuckPathsRotation.ValueChanged += new global::System.EventHandler(this.trackStuckPathsRotation_ValueChanged);
			this.lblStuckPathsRotation.AutoSize = true;
			this.lblStuckPathsRotation.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStuckPathsRotation.ForeColor = global::System.Drawing.Color.White;
			this.lblStuckPathsRotation.Location = new global::System.Drawing.Point(22, 228);
			this.lblStuckPathsRotation.Name = "lblStuckPathsRotation";
			this.lblStuckPathsRotation.Size = new global::System.Drawing.Size(55, 15);
			this.lblStuckPathsRotation.TabIndex = 101;
			this.lblStuckPathsRotation.Text = "Rotation:";
			this.txtStuckPathRadius.BorderColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathRadius.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtStuckPathRadius.DefaultText = "5";
			this.txtStuckPathRadius.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathRadius.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtStuckPathRadius.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtStuckPathRadius.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtStuckPathRadius.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtStuckPathRadius.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtStuckPathRadius.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtStuckPathRadius.ForeColor = global::System.Drawing.Color.White;
			this.txtStuckPathRadius.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtStuckPathRadius.Location = new global::System.Drawing.Point(318, 175);
			this.txtStuckPathRadius.MaxLength = 3;
			this.txtStuckPathRadius.Name = "txtStuckPathRadius";
			this.txtStuckPathRadius.PasswordChar = '\0';
			this.txtStuckPathRadius.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtStuckPathRadius.PlaceholderText = "";
			this.txtStuckPathRadius.SelectedText = "";
			this.txtStuckPathRadius.Size = new global::System.Drawing.Size(44, 30);
			this.txtStuckPathRadius.TabIndex = 100;
			this.txtStuckPathRadius.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.txtStuckPathRadius.TextChanged += new global::System.EventHandler(this.txtStuckPathRadius_TextChanged);
			this.btnStuckPathsStart.BorderColor = global::System.Drawing.Color.Gray;
			this.btnStuckPathsStart.BorderThickness = 1;
			this.btnStuckPathsStart.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnStuckPathsStart.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnStuckPathsStart.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnStuckPathsStart.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnStuckPathsStart.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnStuckPathsStart.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnStuckPathsStart.ForeColor = global::System.Drawing.Color.White;
			this.btnStuckPathsStart.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnStuckPathsStart.Location = new global::System.Drawing.Point(22, 61);
			this.btnStuckPathsStart.Name = "btnStuckPathsStart";
			this.btnStuckPathsStart.Size = new global::System.Drawing.Size(87, 30);
			this.btnStuckPathsStart.TabIndex = 69;
			this.btnStuckPathsStart.Text = "Start";
			this.btnStuckPathsStart.Click += new global::System.EventHandler(this.btnStuckPathsStart_Click);
			this.trackStuckPathsRadius.BackColor = global::System.Drawing.Color.Transparent;
			this.trackStuckPathsRadius.LargeChange = 10;
			this.trackStuckPathsRadius.Location = new global::System.Drawing.Point(180, 179);
			this.trackStuckPathsRadius.Maximum = 200;
			this.trackStuckPathsRadius.Minimum = 1;
			this.trackStuckPathsRadius.Name = "trackStuckPathsRadius";
			this.trackStuckPathsRadius.Size = new global::System.Drawing.Size(127, 23);
			this.trackStuckPathsRadius.Style = 1;
			this.trackStuckPathsRadius.TabIndex = 98;
			this.trackStuckPathsRadius.ThumbColor = global::System.Drawing.Color.DeepSkyBlue;
			this.trackStuckPathsRadius.Value = 5;
			this.trackStuckPathsRadius.ValueChanged += new global::System.EventHandler(this.trackStuckPathsRadius_ValueChanged);
			this.lblStuckPathsRadius.AutoSize = true;
			this.lblStuckPathsRadius.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStuckPathsRadius.ForeColor = global::System.Drawing.Color.White;
			this.lblStuckPathsRadius.Location = new global::System.Drawing.Point(22, 183);
			this.lblStuckPathsRadius.Name = "lblStuckPathsRadius";
			this.lblStuckPathsRadius.Size = new global::System.Drawing.Size(45, 15);
			this.lblStuckPathsRadius.TabIndex = 73;
			this.lblStuckPathsRadius.Text = "Radius:";
			this.sepStuckPaths1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepStuckPaths1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepStuckPaths1.Location = new global::System.Drawing.Point(17, 104);
			this.sepStuckPaths1.Name = "sepStuckPaths1";
			this.sepStuckPaths1.Size = new global::System.Drawing.Size(350, 10);
			this.sepStuckPaths1.TabIndex = 72;
			this.tabClimbSpots.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabClimbSpots.Controls.Add(this.tableLayoutPanel1);
			this.tabClimbSpots.Location = new global::System.Drawing.Point(4, 44);
			this.tabClimbSpots.Name = "tabClimbSpots";
			this.tabClimbSpots.Size = new global::System.Drawing.Size(839, 200);
			this.tabClimbSpots.TabIndex = 5;
			this.tabClimbSpots.Text = "Climb Spots";
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.grpClimbSpots, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.grpClimbSettings, 0, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(14, 14);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(810, 183);
			this.tableLayoutPanel1.TabIndex = 59;
			this.grpClimbSpots.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpClimbSpots.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpClimbSpots.Controls.Add(this.btnClimbSpotsTooltip);
			this.grpClimbSpots.Controls.Add(this.txtClimbSpotsEditRadius);
			this.grpClimbSpots.Controls.Add(this.lblClimbSpotCheckSpotRadius);
			this.grpClimbSpots.Controls.Add(this.txtClimbSpotCheckSpotRadius);
			this.grpClimbSpots.Controls.Add(this.checkClimbSpotCheckSpot);
			this.grpClimbSpots.Controls.Add(this.btnClimbSpotAdd);
			this.grpClimbSpots.Controls.Add(this.listClimbSpots);
			this.grpClimbSpots.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpClimbSpots.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpClimbSpots.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpClimbSpots.ForeColor = global::System.Drawing.Color.White;
			this.grpClimbSpots.Location = new global::System.Drawing.Point(414, 0);
			this.grpClimbSpots.Margin = new global::System.Windows.Forms.Padding(9, 0, 0, 0);
			this.grpClimbSpots.Name = "grpClimbSpots";
			this.grpClimbSpots.Size = new global::System.Drawing.Size(396, 183);
			this.grpClimbSpots.TabIndex = 8;
			this.grpClimbSpots.Text = "Climb Spots";
			this.btnClimbSpotsTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClimbSpotsTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnClimbSpotsTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnClimbSpotsTooltip.BorderRadius = 4;
			this.btnClimbSpotsTooltip.BorderThickness = 1;
			this.btnClimbSpotsTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnClimbSpotsTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnClimbSpotsTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnClimbSpotsTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClimbSpotsTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnClimbSpotsTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnClimbSpotsTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnClimbSpotsTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnClimbSpotsTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnClimbSpotsTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnClimbSpotsTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnClimbSpotsTooltip.Location = new global::System.Drawing.Point(349, 8);
			this.btnClimbSpotsTooltip.Name = "btnClimbSpotsTooltip";
			this.btnClimbSpotsTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnClimbSpotsTooltip.TabIndex = 77;
			this.btnClimbSpotsTooltip.Click += new global::System.EventHandler(this.btnClimbSpotsTooltip_Click);
			this.txtClimbSpotsEditRadius.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtClimbSpotsEditRadius.BorderColor = global::System.Drawing.Color.Gray;
			this.txtClimbSpotsEditRadius.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtClimbSpotsEditRadius.DefaultText = "";
			this.txtClimbSpotsEditRadius.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtClimbSpotsEditRadius.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtClimbSpotsEditRadius.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtClimbSpotsEditRadius.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtClimbSpotsEditRadius.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtClimbSpotsEditRadius.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtClimbSpotsEditRadius.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtClimbSpotsEditRadius.ForeColor = global::System.Drawing.Color.White;
			this.txtClimbSpotsEditRadius.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtClimbSpotsEditRadius.Location = new global::System.Drawing.Point(306, 9);
			this.txtClimbSpotsEditRadius.MaxLength = 3;
			this.txtClimbSpotsEditRadius.Name = "txtClimbSpotsEditRadius";
			this.txtClimbSpotsEditRadius.PasswordChar = '\0';
			this.txtClimbSpotsEditRadius.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtClimbSpotsEditRadius.PlaceholderText = "";
			this.txtClimbSpotsEditRadius.SelectedText = "";
			this.txtClimbSpotsEditRadius.Size = new global::System.Drawing.Size(28, 23);
			this.txtClimbSpotsEditRadius.TabIndex = 76;
			this.txtClimbSpotsEditRadius.Visible = false;
			this.txtClimbSpotsEditRadius.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.txtClimbSpotsEditRadius_KeyDown);
			this.lblClimbSpotCheckSpotRadius.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblClimbSpotCheckSpotRadius.AutoSize = true;
			this.lblClimbSpotCheckSpotRadius.BackColor = global::System.Drawing.Color.Transparent;
			this.lblClimbSpotCheckSpotRadius.ForeColor = global::System.Drawing.Color.White;
			this.lblClimbSpotCheckSpotRadius.Location = new global::System.Drawing.Point(187, 152);
			this.lblClimbSpotCheckSpotRadius.Name = "lblClimbSpotCheckSpotRadius";
			this.lblClimbSpotCheckSpotRadius.Size = new global::System.Drawing.Size(28, 15);
			this.lblClimbSpotCheckSpotRadius.TabIndex = 75;
			this.lblClimbSpotCheckSpotRadius.Text = "yds.";
			this.txtClimbSpotCheckSpotRadius.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.txtClimbSpotCheckSpotRadius.BorderColor = global::System.Drawing.Color.Gray;
			this.txtClimbSpotCheckSpotRadius.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtClimbSpotCheckSpotRadius.DefaultText = "30";
			this.txtClimbSpotCheckSpotRadius.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtClimbSpotCheckSpotRadius.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtClimbSpotCheckSpotRadius.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtClimbSpotCheckSpotRadius.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtClimbSpotCheckSpotRadius.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtClimbSpotCheckSpotRadius.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtClimbSpotCheckSpotRadius.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtClimbSpotCheckSpotRadius.ForeColor = global::System.Drawing.Color.White;
			this.txtClimbSpotCheckSpotRadius.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtClimbSpotCheckSpotRadius.Location = new global::System.Drawing.Point(113, 146);
			this.txtClimbSpotCheckSpotRadius.MaxLength = 3;
			this.txtClimbSpotCheckSpotRadius.Name = "txtClimbSpotCheckSpotRadius";
			this.txtClimbSpotCheckSpotRadius.PasswordChar = '\0';
			this.txtClimbSpotCheckSpotRadius.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtClimbSpotCheckSpotRadius.PlaceholderText = "";
			this.txtClimbSpotCheckSpotRadius.SelectedText = "";
			this.txtClimbSpotCheckSpotRadius.Size = new global::System.Drawing.Size(68, 26);
			this.txtClimbSpotCheckSpotRadius.TabIndex = 74;
			this.checkClimbSpotCheckSpot.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.checkClimbSpotCheckSpot.Animated = true;
			this.checkClimbSpotCheckSpot.AutoSize = true;
			this.checkClimbSpotCheckSpot.BackColor = global::System.Drawing.Color.Transparent;
			this.checkClimbSpotCheckSpot.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotCheckSpot.CheckedState.BorderRadius = 0;
			this.checkClimbSpotCheckSpot.CheckedState.BorderThickness = 0;
			this.checkClimbSpotCheckSpot.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotCheckSpot.Location = new global::System.Drawing.Point(10, 151);
			this.checkClimbSpotCheckSpot.Name = "checkClimbSpotCheckSpot";
			this.checkClimbSpotCheckSpot.Size = new global::System.Drawing.Size(97, 19);
			this.checkClimbSpotCheckSpot.TabIndex = 73;
			this.checkClimbSpotCheckSpot.Text = "Is Check Spot";
			this.checkClimbSpotCheckSpot.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkClimbSpotCheckSpot.UncheckedState.BorderRadius = 0;
			this.checkClimbSpotCheckSpot.UncheckedState.BorderThickness = 1;
			this.checkClimbSpotCheckSpot.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkClimbSpotCheckSpot.UseVisualStyleBackColor = false;
			this.btnClimbSpotAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClimbSpotAdd.BorderColor = global::System.Drawing.Color.Gray;
			this.btnClimbSpotAdd.BorderThickness = 1;
			this.btnClimbSpotAdd.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnClimbSpotAdd.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnClimbSpotAdd.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnClimbSpotAdd.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnClimbSpotAdd.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnClimbSpotAdd.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnClimbSpotAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnClimbSpotAdd.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnClimbSpotAdd.Location = new global::System.Drawing.Point(306, 146);
			this.btnClimbSpotAdd.Name = "btnClimbSpotAdd";
			this.btnClimbSpotAdd.Size = new global::System.Drawing.Size(80, 26);
			this.btnClimbSpotAdd.TabIndex = 72;
			this.btnClimbSpotAdd.Text = "Add";
			this.btnClimbSpotAdd.Click += new global::System.EventHandler(this.btnClimbSpotAdd_Click);
			this.listClimbSpots.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listClimbSpots.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listClimbSpots.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listClimbSpotsCount,
				this.listClimbSpotsSpot,
				this.listClimbSpotsCheckSpot,
				this.listClimbSpotsRadius
			});
			this.listClimbSpots.ForeColor = global::System.Drawing.Color.White;
			this.listClimbSpots.FullRowSelect = true;
			this.listClimbSpots.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listClimbSpots.HideSelection = false;
			this.listClimbSpots.Location = new global::System.Drawing.Point(10, 51);
			this.listClimbSpots.Name = "listClimbSpots";
			this.listClimbSpots.OwnerDraw = true;
			this.listClimbSpots.Size = new global::System.Drawing.Size(376, 85);
			this.listClimbSpots.TabIndex = 55;
			this.listClimbSpots.UseCompatibleStateImageBehavior = false;
			this.listClimbSpots.View = global::System.Windows.Forms.View.Details;
			this.listClimbSpots.SelectedIndexChanged += new global::System.EventHandler(this.listClimbSpots_SelectedIndexChanged);
			this.listClimbSpots.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listClimbSpots_KeyDown);
			this.listClimbSpots.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listClimbSpots_MouseClick);
			this.listClimbSpots.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listClimbSpots_MouseDoubleClick);
			this.listClimbSpots.Resize += new global::System.EventHandler(this.listClimbSpots_Resize);
			this.listClimbSpotsCount.Text = "#";
			this.listClimbSpotsCount.Width = 40;
			this.listClimbSpotsSpot.Text = "Spot";
			this.listClimbSpotsSpot.Width = 120;
			this.listClimbSpotsCheckSpot.Text = "Check Spot";
			this.listClimbSpotsCheckSpot.Width = 75;
			this.listClimbSpotsRadius.Text = "Radius";
			this.listClimbSpotsRadius.Width = 50;
			this.grpClimbSettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpClimbSettings.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpClimbSettings.Controls.Add(this.lblClimbSpotsInfo);
			this.grpClimbSettings.Controls.Add(this.checkClimbSpotsSettingsShowConnections);
			this.grpClimbSettings.Controls.Add(this.checkClimbSpotsSettingsHerbs);
			this.grpClimbSettings.Controls.Add(this.checkClimbSpotsSettingsOres);
			this.grpClimbSettings.Controls.Add(this.checkClimbSpotsSettingsUseClimbSpots);
			this.grpClimbSettings.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpClimbSettings.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpClimbSettings.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpClimbSettings.ForeColor = global::System.Drawing.Color.White;
			this.grpClimbSettings.Location = new global::System.Drawing.Point(0, 0);
			this.grpClimbSettings.Margin = new global::System.Windows.Forms.Padding(0, 0, 9, 0);
			this.grpClimbSettings.Name = "grpClimbSettings";
			this.grpClimbSettings.Size = new global::System.Drawing.Size(396, 183);
			this.grpClimbSettings.TabIndex = 7;
			this.checkClimbSpotsSettingsShowConnections.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.checkClimbSpotsSettingsShowConnections.Animated = true;
			this.checkClimbSpotsSettingsShowConnections.AutoSize = true;
			this.checkClimbSpotsSettingsShowConnections.BackColor = global::System.Drawing.Color.Transparent;
			this.checkClimbSpotsSettingsShowConnections.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsShowConnections.CheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsShowConnections.CheckedState.BorderThickness = 0;
			this.checkClimbSpotsSettingsShowConnections.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsShowConnections.Enabled = false;
			this.checkClimbSpotsSettingsShowConnections.Location = new global::System.Drawing.Point(260, 11);
			this.checkClimbSpotsSettingsShowConnections.Name = "checkClimbSpotsSettingsShowConnections";
			this.checkClimbSpotsSettingsShowConnections.Size = new global::System.Drawing.Size(125, 19);
			this.checkClimbSpotsSettingsShowConnections.TabIndex = 65;
			this.checkClimbSpotsSettingsShowConnections.Text = "Show Connections";
			this.checkClimbSpotsSettingsShowConnections.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkClimbSpotsSettingsShowConnections.UncheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsShowConnections.UncheckedState.BorderThickness = 1;
			this.checkClimbSpotsSettingsShowConnections.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkClimbSpotsSettingsShowConnections.UseVisualStyleBackColor = false;
			this.checkClimbSpotsSettingsShowConnections.CheckedChanged += new global::System.EventHandler(this.checkClimbSpotsSettingsShowConnections_CheckedChanged);
			this.checkClimbSpotsSettingsHerbs.Animated = true;
			this.checkClimbSpotsSettingsHerbs.AutoSize = true;
			this.checkClimbSpotsSettingsHerbs.BackColor = global::System.Drawing.Color.Transparent;
			this.checkClimbSpotsSettingsHerbs.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsHerbs.CheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsHerbs.CheckedState.BorderThickness = 0;
			this.checkClimbSpotsSettingsHerbs.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsHerbs.Enabled = false;
			this.checkClimbSpotsSettingsHerbs.Location = new global::System.Drawing.Point(22, 85);
			this.checkClimbSpotsSettingsHerbs.Name = "checkClimbSpotsSettingsHerbs";
			this.checkClimbSpotsSettingsHerbs.Size = new global::System.Drawing.Size(97, 19);
			this.checkClimbSpotsSettingsHerbs.TabIndex = 64;
			this.checkClimbSpotsSettingsHerbs.Text = "Use for Herbs";
			this.checkClimbSpotsSettingsHerbs.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkClimbSpotsSettingsHerbs.UncheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsHerbs.UncheckedState.BorderThickness = 1;
			this.checkClimbSpotsSettingsHerbs.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkClimbSpotsSettingsHerbs.UseVisualStyleBackColor = false;
			this.checkClimbSpotsSettingsOres.Animated = true;
			this.checkClimbSpotsSettingsOres.AutoSize = true;
			this.checkClimbSpotsSettingsOres.BackColor = global::System.Drawing.Color.Transparent;
			this.checkClimbSpotsSettingsOres.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsOres.CheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsOres.CheckedState.BorderThickness = 0;
			this.checkClimbSpotsSettingsOres.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsOres.Enabled = false;
			this.checkClimbSpotsSettingsOres.Location = new global::System.Drawing.Point(22, 60);
			this.checkClimbSpotsSettingsOres.Name = "checkClimbSpotsSettingsOres";
			this.checkClimbSpotsSettingsOres.Size = new global::System.Drawing.Size(90, 19);
			this.checkClimbSpotsSettingsOres.TabIndex = 63;
			this.checkClimbSpotsSettingsOres.Text = "Use for Ores";
			this.checkClimbSpotsSettingsOres.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkClimbSpotsSettingsOres.UncheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsOres.UncheckedState.BorderThickness = 1;
			this.checkClimbSpotsSettingsOres.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkClimbSpotsSettingsOres.UseVisualStyleBackColor = false;
			this.checkClimbSpotsSettingsUseClimbSpots.Animated = true;
			this.checkClimbSpotsSettingsUseClimbSpots.AutoSize = true;
			this.checkClimbSpotsSettingsUseClimbSpots.BackColor = global::System.Drawing.Color.Transparent;
			this.checkClimbSpotsSettingsUseClimbSpots.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsUseClimbSpots.CheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsUseClimbSpots.CheckedState.BorderThickness = 0;
			this.checkClimbSpotsSettingsUseClimbSpots.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkClimbSpotsSettingsUseClimbSpots.Location = new global::System.Drawing.Point(12, 11);
			this.checkClimbSpotsSettingsUseClimbSpots.Name = "checkClimbSpotsSettingsUseClimbSpots";
			this.checkClimbSpotsSettingsUseClimbSpots.Size = new global::System.Drawing.Size(112, 19);
			this.checkClimbSpotsSettingsUseClimbSpots.TabIndex = 62;
			this.checkClimbSpotsSettingsUseClimbSpots.Text = "Use Climb Spots";
			this.checkClimbSpotsSettingsUseClimbSpots.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkClimbSpotsSettingsUseClimbSpots.UncheckedState.BorderRadius = 0;
			this.checkClimbSpotsSettingsUseClimbSpots.UncheckedState.BorderThickness = 1;
			this.checkClimbSpotsSettingsUseClimbSpots.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkClimbSpotsSettingsUseClimbSpots.UseVisualStyleBackColor = false;
			this.checkClimbSpotsSettingsUseClimbSpots.CheckedChanged += new global::System.EventHandler(this.checkClimbSpotsSettingsUseClimbSpots_CheckedChanged);
			this.tabExpert.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabExpert.Controls.Add(this.panelTabExpert);
			this.tabExpert.ForeColor = global::System.Drawing.Color.White;
			this.tabExpert.Location = new global::System.Drawing.Point(4, 44);
			this.tabExpert.Name = "tabExpert";
			this.tabExpert.Size = new global::System.Drawing.Size(839, 200);
			this.tabExpert.TabIndex = 4;
			this.tabExpert.Text = "Expert";
			this.panelTabExpert.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabExpert.AutoScroll = true;
			this.panelTabExpert.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabExpert.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabExpert.Controls.Add(this.grpExpertFlightSens);
			this.panelTabExpert.Controls.Add(this.grpExpertSettings);
			this.panelTabExpert.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabExpert.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabExpert.Name = "panelTabExpert";
			this.panelTabExpert.Size = new global::System.Drawing.Size(839, 200);
			this.panelTabExpert.TabIndex = 64;
			this.grpExpertFlightSens.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpExpertFlightSens.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpExpertFlightSens.Controls.Add(this.btnExpertFlightSensDefault);
			this.grpExpertFlightSens.Controls.Add(this.lblExpertFlightSensData);
			this.grpExpertFlightSens.Controls.Add(this.trackExpertFlightSens);
			this.grpExpertFlightSens.Controls.Add(this.lblExpertFlightSens);
			this.grpExpertFlightSens.Controls.Add(this.sepExpertFlightSens1);
			this.grpExpertFlightSens.Controls.Add(this.lblExpertFlightSensInfo1);
			this.grpExpertFlightSens.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpExpertFlightSens.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpExpertFlightSens.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpExpertFlightSens.ForeColor = global::System.Drawing.Color.White;
			this.grpExpertFlightSens.Location = new global::System.Drawing.Point(14, 228);
			this.grpExpertFlightSens.Name = "grpExpertFlightSens";
			this.grpExpertFlightSens.Size = new global::System.Drawing.Size(754, 180);
			this.grpExpertFlightSens.TabIndex = 66;
			this.grpExpertFlightSens.Text = "Flight Sensitivity";
			this.btnExpertFlightSensDefault.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnExpertFlightSensDefault.BorderColor = global::System.Drawing.Color.Gray;
			this.btnExpertFlightSensDefault.BorderThickness = 1;
			this.btnExpertFlightSensDefault.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnExpertFlightSensDefault.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnExpertFlightSensDefault.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnExpertFlightSensDefault.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnExpertFlightSensDefault.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnExpertFlightSensDefault.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnExpertFlightSensDefault.ForeColor = global::System.Drawing.Color.White;
			this.btnExpertFlightSensDefault.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnExpertFlightSensDefault.Location = new global::System.Drawing.Point(651, 61);
			this.btnExpertFlightSensDefault.Name = "btnExpertFlightSensDefault";
			this.btnExpertFlightSensDefault.Size = new global::System.Drawing.Size(87, 26);
			this.btnExpertFlightSensDefault.TabIndex = 105;
			this.btnExpertFlightSensDefault.Text = "Default";
			this.btnExpertFlightSensDefault.Click += new global::System.EventHandler(this.btnExpertFlightSensDefault_Click);
			this.lblExpertFlightSensData.AutoSize = true;
			this.lblExpertFlightSensData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertFlightSensData.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertFlightSensData.Location = new global::System.Drawing.Point(395, 137);
			this.lblExpertFlightSensData.Name = "lblExpertFlightSensData";
			this.lblExpertFlightSensData.Size = new global::System.Drawing.Size(13, 15);
			this.lblExpertFlightSensData.TabIndex = 99;
			this.lblExpertFlightSensData.Text = "6";
			this.trackExpertFlightSens.BackColor = global::System.Drawing.Color.Transparent;
			this.trackExpertFlightSens.Location = new global::System.Drawing.Point(180, 133);
			this.trackExpertFlightSens.Maximum = 12;
			this.trackExpertFlightSens.Minimum = 3;
			this.trackExpertFlightSens.Name = "trackExpertFlightSens";
			this.trackExpertFlightSens.Size = new global::System.Drawing.Size(200, 23);
			this.trackExpertFlightSens.Style = 1;
			this.trackExpertFlightSens.TabIndex = 98;
			this.trackExpertFlightSens.ThumbColor = global::System.Drawing.Color.DeepSkyBlue;
			this.trackExpertFlightSens.Value = 6;
			this.trackExpertFlightSens.Scroll += new global::System.Windows.Forms.ScrollEventHandler(this.trackExpertFlightSens_Scroll);
			this.lblExpertFlightSens.AutoSize = true;
			this.lblExpertFlightSens.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertFlightSens.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertFlightSens.Location = new global::System.Drawing.Point(22, 137);
			this.lblExpertFlightSens.Name = "lblExpertFlightSens";
			this.lblExpertFlightSens.Size = new global::System.Drawing.Size(55, 15);
			this.lblExpertFlightSens.TabIndex = 73;
			this.lblExpertFlightSens.Text = "Outdoor:";
			this.sepExpertFlightSens1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepExpertFlightSens1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepExpertFlightSens1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepExpertFlightSens1.Location = new global::System.Drawing.Point(17, 104);
			this.sepExpertFlightSens1.Name = "sepExpertFlightSens1";
			this.sepExpertFlightSens1.Size = new global::System.Drawing.Size(721, 10);
			this.sepExpertFlightSens1.TabIndex = 72;
			this.lblExpertFlightSensInfo1.AutoSize = true;
			this.lblExpertFlightSensInfo1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertFlightSensInfo1.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertFlightSensInfo1.Location = new global::System.Drawing.Point(22, 67);
			this.lblExpertFlightSensInfo1.Name = "lblExpertFlightSensInfo1";
			this.lblExpertFlightSensInfo1.Size = new global::System.Drawing.Size(252, 15);
			this.lblExpertFlightSensInfo1.TabIndex = 0;
			this.lblExpertFlightSensInfo1.Text = "A higher sensitivity provides a smoother flight.";
			this.grpExpertSettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpExpertSettings.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpExpertSettings.Controls.Add(this.lblExpertMountDelayMS);
			this.grpExpertSettings.Controls.Add(this.txtExpertMountDelay);
			this.grpExpertSettings.Controls.Add(this.lblExpertMountDelay);
			this.grpExpertSettings.Controls.Add(this.lblExpertResurrectDelayMS);
			this.grpExpertSettings.Controls.Add(this.txtExpertResurrectDelay);
			this.grpExpertSettings.Controls.Add(this.lblExpertResurrectDelay);
			this.grpExpertSettings.Controls.Add(this.btnExpertTooltip);
			this.grpExpertSettings.Controls.Add(this.lblExpertLootDelayMs);
			this.grpExpertSettings.Controls.Add(this.txtExpertLootDelay);
			this.grpExpertSettings.Controls.Add(this.lblExpertLootDelay);
			this.grpExpertSettings.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpExpertSettings.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpExpertSettings.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpExpertSettings.ForeColor = global::System.Drawing.Color.White;
			this.grpExpertSettings.Location = new global::System.Drawing.Point(14, 14);
			this.grpExpertSettings.Name = "grpExpertSettings";
			this.grpExpertSettings.Size = new global::System.Drawing.Size(771, 199);
			this.grpExpertSettings.TabIndex = 63;
			this.grpExpertSettings.Text = "Settings";
			this.lblExpertMountDelayMS.AutoSize = true;
			this.lblExpertMountDelayMS.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertMountDelayMS.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertMountDelayMS.Location = new global::System.Drawing.Point(259, 157);
			this.lblExpertMountDelayMS.Name = "lblExpertMountDelayMS";
			this.lblExpertMountDelayMS.Size = new global::System.Drawing.Size(23, 15);
			this.lblExpertMountDelayMS.TabIndex = 81;
			this.lblExpertMountDelayMS.Text = "ms";
			this.txtExpertMountDelay.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExpertMountDelay.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtExpertMountDelay.DefaultText = "50";
			this.txtExpertMountDelay.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExpertMountDelay.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtExpertMountDelay.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExpertMountDelay.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExpertMountDelay.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtExpertMountDelay.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtExpertMountDelay.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtExpertMountDelay.ForeColor = global::System.Drawing.Color.White;
			this.txtExpertMountDelay.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtExpertMountDelay.Location = new global::System.Drawing.Point(180, 150);
			this.txtExpertMountDelay.MaxLength = 3;
			this.txtExpertMountDelay.Name = "txtExpertMountDelay";
			this.txtExpertMountDelay.PasswordChar = '\0';
			this.txtExpertMountDelay.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtExpertMountDelay.PlaceholderText = "";
			this.txtExpertMountDelay.SelectedText = "";
			this.txtExpertMountDelay.Size = new global::System.Drawing.Size(68, 30);
			this.txtExpertMountDelay.TabIndex = 80;
			this.lblExpertMountDelay.AutoSize = true;
			this.lblExpertMountDelay.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertMountDelay.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertMountDelay.Location = new global::System.Drawing.Point(22, 157);
			this.lblExpertMountDelay.Name = "lblExpertMountDelay";
			this.lblExpertMountDelay.Size = new global::System.Drawing.Size(78, 15);
			this.lblExpertMountDelay.TabIndex = 79;
			this.lblExpertMountDelay.Text = "Mount Delay:";
			this.lblExpertResurrectDelayMS.AutoSize = true;
			this.lblExpertResurrectDelayMS.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertResurrectDelayMS.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertResurrectDelayMS.Location = new global::System.Drawing.Point(259, 112);
			this.lblExpertResurrectDelayMS.Name = "lblExpertResurrectDelayMS";
			this.lblExpertResurrectDelayMS.Size = new global::System.Drawing.Size(27, 15);
			this.lblExpertResurrectDelayMS.TabIndex = 78;
			this.lblExpertResurrectDelayMS.Text = "sec.";
			this.txtExpertResurrectDelay.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExpertResurrectDelay.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtExpertResurrectDelay.DefaultText = "1";
			this.txtExpertResurrectDelay.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExpertResurrectDelay.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtExpertResurrectDelay.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExpertResurrectDelay.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExpertResurrectDelay.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtExpertResurrectDelay.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtExpertResurrectDelay.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtExpertResurrectDelay.ForeColor = global::System.Drawing.Color.White;
			this.txtExpertResurrectDelay.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtExpertResurrectDelay.Location = new global::System.Drawing.Point(180, 105);
			this.txtExpertResurrectDelay.MaxLength = 3;
			this.txtExpertResurrectDelay.Name = "txtExpertResurrectDelay";
			this.txtExpertResurrectDelay.PasswordChar = '\0';
			this.txtExpertResurrectDelay.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtExpertResurrectDelay.PlaceholderText = "";
			this.txtExpertResurrectDelay.SelectedText = "";
			this.txtExpertResurrectDelay.Size = new global::System.Drawing.Size(68, 30);
			this.txtExpertResurrectDelay.TabIndex = 77;
			this.lblExpertResurrectDelay.AutoSize = true;
			this.lblExpertResurrectDelay.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertResurrectDelay.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertResurrectDelay.Location = new global::System.Drawing.Point(22, 112);
			this.lblExpertResurrectDelay.Name = "lblExpertResurrectDelay";
			this.lblExpertResurrectDelay.Size = new global::System.Drawing.Size(91, 15);
			this.lblExpertResurrectDelay.TabIndex = 76;
			this.lblExpertResurrectDelay.Text = "Resurrect Delay:";
			this.btnExpertTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnExpertTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnExpertTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnExpertTooltip.BorderRadius = 4;
			this.btnExpertTooltip.BorderThickness = 1;
			this.btnExpertTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnExpertTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnExpertTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnExpertTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnExpertTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnExpertTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnExpertTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnExpertTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnExpertTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnExpertTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnExpertTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnExpertTooltip.Location = new global::System.Drawing.Point(724, 8);
			this.btnExpertTooltip.Name = "btnExpertTooltip";
			this.btnExpertTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnExpertTooltip.TabIndex = 75;
			this.btnExpertTooltip.Click += new global::System.EventHandler(this.btnExpertTooltip_Click);
			this.lblExpertLootDelayMs.AutoSize = true;
			this.lblExpertLootDelayMs.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertLootDelayMs.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertLootDelayMs.Location = new global::System.Drawing.Point(259, 67);
			this.lblExpertLootDelayMs.Name = "lblExpertLootDelayMs";
			this.lblExpertLootDelayMs.Size = new global::System.Drawing.Size(23, 15);
			this.lblExpertLootDelayMs.TabIndex = 67;
			this.lblExpertLootDelayMs.Text = "ms";
			this.txtExpertLootDelay.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExpertLootDelay.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtExpertLootDelay.DefaultText = "100";
			this.txtExpertLootDelay.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtExpertLootDelay.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtExpertLootDelay.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExpertLootDelay.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtExpertLootDelay.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtExpertLootDelay.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtExpertLootDelay.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtExpertLootDelay.ForeColor = global::System.Drawing.Color.White;
			this.txtExpertLootDelay.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtExpertLootDelay.Location = new global::System.Drawing.Point(180, 60);
			this.txtExpertLootDelay.MaxLength = 4;
			this.txtExpertLootDelay.Name = "txtExpertLootDelay";
			this.txtExpertLootDelay.PasswordChar = '\0';
			this.txtExpertLootDelay.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtExpertLootDelay.PlaceholderText = "";
			this.txtExpertLootDelay.SelectedText = "";
			this.txtExpertLootDelay.Size = new global::System.Drawing.Size(68, 30);
			this.txtExpertLootDelay.TabIndex = 66;
			this.lblExpertLootDelay.AutoSize = true;
			this.lblExpertLootDelay.BackColor = global::System.Drawing.Color.Transparent;
			this.lblExpertLootDelay.ForeColor = global::System.Drawing.Color.White;
			this.lblExpertLootDelay.Location = new global::System.Drawing.Point(22, 67);
			this.lblExpertLootDelay.Name = "lblExpertLootDelay";
			this.lblExpertLootDelay.Size = new global::System.Drawing.Size(66, 15);
			this.lblExpertLootDelay.TabIndex = 14;
			this.lblExpertLootDelay.Text = "Loot Delay:";
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(427, 38);
			this.panelTitle.TabIndex = 66;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(357, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(158, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Path Manager";
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnRecorderSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(617, 591);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 68;
			this.btnRecorderSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRecorderSave.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.DisabledState.Image = global::Jack.Properties.Resources.btn_save_disabled;
			this.btnRecorderSave.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRecorderSave.ForeColor = global::System.Drawing.Color.White;
			this.btnRecorderSave.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRecorderSave.HoverState.Image = global::Jack.Properties.Resources.btn_save_hover;
			this.btnRecorderSave.Image = global::Jack.Properties.Resources.btn_save;
			this.btnRecorderSave.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnRecorderSave.Location = new global::System.Drawing.Point(30, 0);
			this.btnRecorderSave.Name = "btnRecorderSave";
			this.btnRecorderSave.PressedDepth = 0;
			this.btnRecorderSave.Size = new global::System.Drawing.Size(235, 44);
			this.btnRecorderSave.TabIndex = 0;
			this.btnRecorderSave.Click += new global::System.EventHandler(this.btnRecorderSave_Click);
			this.lblClimbSpotsInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblClimbSpotsInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblClimbSpotsInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.lblClimbSpotsInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblClimbSpotsInfo.Location = new global::System.Drawing.Point(22, 121);
			this.lblClimbSpotsInfo.Name = "lblClimbSpotsInfo";
			this.lblClimbSpotsInfo.Size = new global::System.Drawing.Size(350, 34);
			this.lblClimbSpotsInfo.TabIndex = 72;
			this.lblClimbSpotsInfo.Text = "Only use this option if you want to farm in Retail with a ground mount.";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(920, 675);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.Controls.Add(this.lblProfileName);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(920, 675);
			base.Name = "frmProfile";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmProfile";
			base.Load += new global::System.EventHandler(this.frmProfile_Load);
			base.Shown += new global::System.EventHandler(this.frmProfile_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmProfile_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.panelRecorder.ResumeLayout(false);
			this.grpRecorder.ResumeLayout(false);
			this.grpRecorder.PerformLayout();
			this.tabs.ResumeLayout(false);
			this.tabRecorder.ResumeLayout(false);
			this.tableRecorder.ResumeLayout(false);
			this.grpRecorderEvents.ResumeLayout(false);
			this.grpRecorderWaypoints.ResumeLayout(false);
			this.tabSettings.ResumeLayout(false);
			this.panelTabSettings.ResumeLayout(false);
			this.grpSettingsMode.ResumeLayout(false);
			this.grpSettingsMode.PerformLayout();
			this.grpSettingsDistances.ResumeLayout(false);
			this.grpSettingsDistances.PerformLayout();
			this.grpSettingsMount.ResumeLayout(false);
			this.grpSettingsMount.PerformLayout();
			this.grpSettingsLoot.ResumeLayout(false);
			this.grpSettingsLoot.PerformLayout();
			this.imgModuleGather.EndInit();
			this.tabMobs.ResumeLayout(false);
			this.grpMobs.ResumeLayout(false);
			this.grpMobs.PerformLayout();
			this.panelMobs.ResumeLayout(false);
			this.tabBlacklist.ResumeLayout(false);
			this.tableBlacklist.ResumeLayout(false);
			this.grpBlacklistObjects.ResumeLayout(false);
			this.grpBlacklist.ResumeLayout(false);
			this.tabStuckPaths.ResumeLayout(false);
			this.panelTabStuckPaths.ResumeLayout(false);
			this.grpStuckPaths.ResumeLayout(false);
			this.grpStuckPaths.PerformLayout();
			this.tabClimbSpots.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.grpClimbSpots.ResumeLayout(false);
			this.grpClimbSpots.PerformLayout();
			this.grpClimbSettings.ResumeLayout(false);
			this.grpClimbSettings.PerformLayout();
			this.tabExpert.ResumeLayout(false);
			this.panelTabExpert.ResumeLayout(false);
			this.grpExpertFlightSens.ResumeLayout(false);
			this.grpExpertFlightSens.PerformLayout();
			this.grpExpertSettings.ResumeLayout(false);
			this.grpExpertSettings.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040007BF RID: 1983
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040007C0 RID: 1984
		private global::System.Windows.Forms.Label lblRecorderAutoRecordDistance;

		// Token: 0x040007C1 RID: 1985
		private global::System.Windows.Forms.Label lblRecorderAutoRecord;

		// Token: 0x040007C2 RID: 1986
		private global::System.Windows.Forms.ListView listWaypoints;

		// Token: 0x040007C3 RID: 1987
		private global::System.Windows.Forms.ListView listEvents;

		// Token: 0x040007C4 RID: 1988
		private global::System.Windows.Forms.ColumnHeader listWaypointsEvents;

		// Token: 0x040007C5 RID: 1989
		private global::System.Windows.Forms.ColumnHeader listEventsEvent;

		// Token: 0x040007C6 RID: 1990
		private global::System.Windows.Forms.ColumnHeader listWaypointsCount;

		// Token: 0x040007C7 RID: 1991
		private global::System.Windows.Forms.ColumnHeader listEventsCount;

		// Token: 0x040007C8 RID: 1992
		private global::System.Windows.Forms.Label lblRecorderShowLast;

		// Token: 0x040007C9 RID: 1993
		private global::System.Windows.Forms.Label lblRecorderShowLastWaypoints;

		// Token: 0x040007CA RID: 1994
		private global::System.Windows.Forms.ListView listBlacklistObjects;

		// Token: 0x040007CB RID: 1995
		private global::System.Windows.Forms.ColumnHeader listBlacklistObjectsName;

		// Token: 0x040007CC RID: 1996
		private global::System.Windows.Forms.ColumnHeader listBlacklistObjectsDistance;

		// Token: 0x040007CD RID: 1997
		private global::System.Windows.Forms.ColumnHeader listBlacklistObjectsGUID;

		// Token: 0x040007CE RID: 1998
		private global::System.Windows.Forms.ListView listBlacklist;

		// Token: 0x040007CF RID: 1999
		private global::System.Windows.Forms.ColumnHeader listBlacklistName;

		// Token: 0x040007D0 RID: 2000
		private global::System.Windows.Forms.ColumnHeader listWaypointsEventsCount;

		// Token: 0x040007D1 RID: 2001
		private global::System.Windows.Forms.Label lblProfileName;

		// Token: 0x040007D2 RID: 2002
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x040007D3 RID: 2003
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x040007D4 RID: 2004
		private global::System.Windows.Forms.TabPage tabRecorder;

		// Token: 0x040007D5 RID: 2005
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRecorderWaypoints;

		// Token: 0x040007D6 RID: 2006
		private global::System.Windows.Forms.TabPage tabSettings;

		// Token: 0x040007D7 RID: 2007
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x040007D8 RID: 2008
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x040007D9 RID: 2009
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x040007DA RID: 2010
		private global::System.Windows.Forms.TableLayoutPanel tableRecorder;

		// Token: 0x040007DB RID: 2011
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRecorderEvents;

		// Token: 0x040007DC RID: 2012
		private global::System.Windows.Forms.TabPage tabMobs;

		// Token: 0x040007DD RID: 2013
		private global::System.Windows.Forms.TabPage tabBlacklist;

		// Token: 0x040007DE RID: 2014
		private global::System.Windows.Forms.TabPage tabExpert;

		// Token: 0x040007DF RID: 2015
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRecorder;

		// Token: 0x040007E0 RID: 2016
		private global::Guna.UI2.WinForms.Guna2Panel panelRecorder;

		// Token: 0x040007E1 RID: 2017
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderAutoRecord;

		// Token: 0x040007E2 RID: 2018
		private global::Guna.UI2.WinForms.Guna2TextBox txtRecorderAutoRecordDistance;

		// Token: 0x040007E3 RID: 2019
		private global::Guna.UI2.WinForms.Guna2TextBox txtRecorderShowLast;

		// Token: 0x040007E4 RID: 2020
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderSingle;

		// Token: 0x040007E5 RID: 2021
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderStart;

		// Token: 0x040007E6 RID: 2022
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsMode;

		// Token: 0x040007E7 RID: 2023
		private global::Guna.UI2.WinForms.Guna2GroupBox grpExpertSettings;

		// Token: 0x040007E8 RID: 2024
		private global::System.Windows.Forms.Label lblExpertLootDelay;

		// Token: 0x040007E9 RID: 2025
		private global::Guna.UI2.WinForms.Guna2ComboBox selectSettingsWaypointMode;

		// Token: 0x040007EA RID: 2026
		private global::Guna.UI2.WinForms.Guna2ComboBox selectSettingsCombatMode;

		// Token: 0x040007EB RID: 2027
		private global::System.Windows.Forms.Label lblSettingsCombatMode;

		// Token: 0x040007EC RID: 2028
		private global::System.Windows.Forms.Label lblSettingsWaypointsMode;

		// Token: 0x040007ED RID: 2029
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsModeMesh;

		// Token: 0x040007EE RID: 2030
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsModeFollowFleeingTarget;

		// Token: 0x040007EF RID: 2031
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsMount;

		// Token: 0x040007F0 RID: 2032
		private global::System.Windows.Forms.Label lblSettingsFlightMount;

		// Token: 0x040007F1 RID: 2033
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsFlightMount;

		// Token: 0x040007F2 RID: 2034
		private global::System.Windows.Forms.Label lblSettingsGroundMount;

		// Token: 0x040007F3 RID: 2035
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsGroundMount;

		// Token: 0x040007F4 RID: 2036
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsLoot;

		// Token: 0x040007F5 RID: 2037
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootHerbalism;

		// Token: 0x040007F6 RID: 2038
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootMining;

		// Token: 0x040007F7 RID: 2039
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootSkinning;

		// Token: 0x040007F8 RID: 2040
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLoot;

		// Token: 0x040007F9 RID: 2041
		private global::Guna.UI2.WinForms.Guna2Separator sepOverlayESPObjects2;

		// Token: 0x040007FA RID: 2042
		private global::System.Windows.Forms.Label lblSettingsLootDistance;

		// Token: 0x040007FB RID: 2043
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootDistance;

		// Token: 0x040007FC RID: 2044
		private global::System.Windows.Forms.Label lblSettingsLootDetectionDistanceInfo;

		// Token: 0x040007FD RID: 2045
		private global::System.Windows.Forms.Label lblSettingsLootMaxPathDistance;

		// Token: 0x040007FE RID: 2046
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootMaxPathDistance;

		// Token: 0x040007FF RID: 2047
		private global::System.Windows.Forms.Label lblSettingsLootGatherDistance;

		// Token: 0x04000800 RID: 2048
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootGatherDistance;

		// Token: 0x04000801 RID: 2049
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsDistances;

		// Token: 0x04000802 RID: 2050
		private global::System.Windows.Forms.Label lblSettingsDistancesMobGroup;

		// Token: 0x04000803 RID: 2051
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesMobGroup;

		// Token: 0x04000804 RID: 2052
		private global::System.Windows.Forms.Label lblSettingsDistancesLocation;

		// Token: 0x04000805 RID: 2053
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesLocation;

		// Token: 0x04000806 RID: 2054
		private global::System.Windows.Forms.Label lblSettingsDistancesWaypoint;

		// Token: 0x04000807 RID: 2055
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesWaypoint;

		// Token: 0x04000808 RID: 2056
		private global::Guna.UI2.WinForms.Guna2Separator sepSettingsDistances1;

		// Token: 0x04000809 RID: 2057
		private global::System.Windows.Forms.Label lblSettingsDistancesInfo;

		// Token: 0x0400080A RID: 2058
		private global::System.Windows.Forms.Label lblSettingsDistancesMobGroupDetection;

		// Token: 0x0400080B RID: 2059
		private global::System.Windows.Forms.Label lblSettingsDistancesIsReachableZAxis;

		// Token: 0x0400080C RID: 2060
		private global::System.Windows.Forms.Label lblSettingsDistancesIsReachable;

		// Token: 0x0400080D RID: 2061
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsDistancesIsReachable;

		// Token: 0x0400080E RID: 2062
		private global::Guna.UI2.WinForms.Guna2GroupBox grpMobs;

		// Token: 0x0400080F RID: 2063
		private global::System.Windows.Forms.Label lblMobs;

		// Token: 0x04000810 RID: 2064
		private global::System.Windows.Forms.RichTextBox richMobs;

		// Token: 0x04000811 RID: 2065
		private global::Guna.UI2.WinForms.Guna2Panel panelMobs;

		// Token: 0x04000812 RID: 2066
		private global::System.Windows.Forms.TableLayoutPanel tableBlacklist;

		// Token: 0x04000813 RID: 2067
		private global::Guna.UI2.WinForms.Guna2GroupBox grpBlacklistObjects;

		// Token: 0x04000814 RID: 2068
		private global::Guna.UI2.WinForms.Guna2GroupBox grpBlacklist;

		// Token: 0x04000815 RID: 2069
		private global::Guna.UI2.WinForms.Guna2Button btnBlacklistReload;

		// Token: 0x04000816 RID: 2070
		private global::Guna.UI2.WinForms.Guna2TextBox txtExpertLootDelay;

		// Token: 0x04000817 RID: 2071
		private global::System.Windows.Forms.Label lblExpertLootDelayMs;

		// Token: 0x04000818 RID: 2072
		private global::Guna.UI2.WinForms.Guna2Button btnBlacklistNameOrID;

		// Token: 0x04000819 RID: 2073
		private global::System.Windows.Forms.TabPage tabClimbSpots;

		// Token: 0x0400081A RID: 2074
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x0400081B RID: 2075
		private global::Guna.UI2.WinForms.Guna2GroupBox grpClimbSpots;

		// Token: 0x0400081C RID: 2076
		private global::System.Windows.Forms.ListView listClimbSpots;

		// Token: 0x0400081D RID: 2077
		private global::System.Windows.Forms.ColumnHeader listClimbSpotsSpot;

		// Token: 0x0400081E RID: 2078
		private global::System.Windows.Forms.ColumnHeader listClimbSpotsCheckSpot;

		// Token: 0x0400081F RID: 2079
		private global::Guna.UI2.WinForms.Guna2GroupBox grpClimbSettings;

		// Token: 0x04000820 RID: 2080
		private global::Guna.UI2.WinForms.Guna2CheckBox checkClimbSpotCheckSpot;

		// Token: 0x04000821 RID: 2081
		private global::Guna.UI2.WinForms.Guna2Button btnClimbSpotAdd;

		// Token: 0x04000822 RID: 2082
		private global::System.Windows.Forms.ColumnHeader listClimbSpotsCount;

		// Token: 0x04000823 RID: 2083
		private global::Guna.UI2.WinForms.Guna2CheckBox checkClimbSpotsSettingsUseClimbSpots;

		// Token: 0x04000824 RID: 2084
		private global::System.Windows.Forms.Label lblClimbSpotCheckSpotRadius;

		// Token: 0x04000825 RID: 2085
		private global::Guna.UI2.WinForms.Guna2TextBox txtClimbSpotCheckSpotRadius;

		// Token: 0x04000826 RID: 2086
		private global::System.Windows.Forms.ColumnHeader listClimbSpotsRadius;

		// Token: 0x04000827 RID: 2087
		private global::Guna.UI2.WinForms.Guna2CheckBox checkClimbSpotsSettingsHerbs;

		// Token: 0x04000828 RID: 2088
		private global::Guna.UI2.WinForms.Guna2CheckBox checkClimbSpotsSettingsOres;

		// Token: 0x04000829 RID: 2089
		private global::Guna.UI2.WinForms.Guna2CheckBox checkClimbSpotsSettingsShowConnections;

		// Token: 0x0400082A RID: 2090
		private global::Guna.UI2.WinForms.Guna2TextBox txtClimbSpotsEditRadius;

		// Token: 0x0400082B RID: 2091
		private global::System.Windows.Forms.Label lblRecorderAutoRecordDistanceYards;

		// Token: 0x0400082C RID: 2092
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x0400082D RID: 2093
		private global::Guna.UI2.WinForms.Guna2Button btnRecorderSave;

		// Token: 0x0400082E RID: 2094
		private global::Guna.UI2.WinForms.Guna2Panel panelTabSettings;

		// Token: 0x0400082F RID: 2095
		private global::Guna.UI2.WinForms.Guna2Panel panelTabExpert;

		// Token: 0x04000830 RID: 2096
		private global::Guna.UI2.WinForms.Guna2Button btnTooltip;

		// Token: 0x04000831 RID: 2097
		private global::Guna.UI2.WinForms.Guna2Button btnSettingsModeTooltip;

		// Token: 0x04000832 RID: 2098
		private global::Guna.UI2.WinForms.Guna2Button btnSettingsLootTooltip;

		// Token: 0x04000833 RID: 2099
		private global::Guna.UI2.WinForms.Guna2Button btnSettingsDistancesTooltip;

		// Token: 0x04000834 RID: 2100
		private global::Guna.UI2.WinForms.Guna2Button btnMobsTooltip;

		// Token: 0x04000835 RID: 2101
		private global::Guna.UI2.WinForms.Guna2Button btnBlacklistTooltip;

		// Token: 0x04000836 RID: 2102
		private global::Guna.UI2.WinForms.Guna2Button btnClimbSpotsTooltip;

		// Token: 0x04000837 RID: 2103
		private global::Guna.UI2.WinForms.Guna2Button btnExpertTooltip;

		// Token: 0x04000838 RID: 2104
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleGather;

		// Token: 0x04000839 RID: 2105
		private global::Guna.UI2.WinForms.Guna2Button btnWhitelistNameOrID;

		// Token: 0x0400083A RID: 2106
		private global::System.Windows.Forms.Label lblExpertResurrectDelayMS;

		// Token: 0x0400083B RID: 2107
		private global::Guna.UI2.WinForms.Guna2TextBox txtExpertResurrectDelay;

		// Token: 0x0400083C RID: 2108
		private global::System.Windows.Forms.Label lblExpertResurrectDelay;

		// Token: 0x0400083D RID: 2109
		private global::Guna.UI2.WinForms.Guna2GroupBox grpExpertFlightSens;

		// Token: 0x0400083E RID: 2110
		private global::Guna.UI2.WinForms.Guna2Button btnExpertFlightSensDefault;

		// Token: 0x0400083F RID: 2111
		private global::System.Windows.Forms.Label lblExpertFlightSensData;

		// Token: 0x04000840 RID: 2112
		private global::Guna.UI2.WinForms.Guna2TrackBar trackExpertFlightSens;

		// Token: 0x04000841 RID: 2113
		private global::System.Windows.Forms.Label lblExpertFlightSens;

		// Token: 0x04000842 RID: 2114
		private global::Guna.UI2.WinForms.Guna2Separator sepExpertFlightSens1;

		// Token: 0x04000843 RID: 2115
		private global::System.Windows.Forms.Label lblExpertFlightSensInfo1;

		// Token: 0x04000844 RID: 2116
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRecorderAutoQuest;

		// Token: 0x04000845 RID: 2117
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootQuestItems;

		// Token: 0x04000846 RID: 2118
		private global::Guna.UI2.WinForms.Guna2CheckBox checkSettingsLootGatherMobs;

		// Token: 0x04000847 RID: 2119
		private global::System.Windows.Forms.Label lblSettingsLootAvoidElitesDistance;

		// Token: 0x04000848 RID: 2120
		private global::Guna.UI2.WinForms.Guna2TextBox txtSettingsLootAvoidElitesDistance;

		// Token: 0x04000849 RID: 2121
		private global::System.Windows.Forms.Label lblSettingsLootAvoidElitesDistanceInfo;

		// Token: 0x0400084A RID: 2122
		private global::System.Windows.Forms.Label lblExpertMountDelayMS;

		// Token: 0x0400084B RID: 2123
		private global::Guna.UI2.WinForms.Guna2TextBox txtExpertMountDelay;

		// Token: 0x0400084C RID: 2124
		private global::System.Windows.Forms.Label lblExpertMountDelay;

		// Token: 0x0400084D RID: 2125
		private global::System.Windows.Forms.TabPage tabStuckPaths;

		// Token: 0x0400084E RID: 2126
		private global::Guna.UI2.WinForms.Guna2Panel panelTabStuckPaths;

		// Token: 0x0400084F RID: 2127
		private global::Guna.UI2.WinForms.Guna2Button btnStuckPathsStart;

		// Token: 0x04000850 RID: 2128
		private global::Guna.UI2.WinForms.Guna2GroupBox grpStuckPaths;

		// Token: 0x04000851 RID: 2129
		private global::Guna.UI2.WinForms.Guna2TrackBar trackStuckPathsRadius;

		// Token: 0x04000852 RID: 2130
		private global::System.Windows.Forms.Label lblStuckPathsRadius;

		// Token: 0x04000853 RID: 2131
		private global::Guna.UI2.WinForms.Guna2Separator sepStuckPaths1;

		// Token: 0x04000854 RID: 2132
		private global::Guna.UI2.WinForms.Guna2TextBox txtStuckPathRadius;

		// Token: 0x04000855 RID: 2133
		private global::System.Windows.Forms.Label lblStuckPathsDivision;

		// Token: 0x04000856 RID: 2134
		private global::Guna.UI2.WinForms.Guna2ComboBox selectStuckPathsDivision;

		// Token: 0x04000857 RID: 2135
		private global::Guna.UI2.WinForms.Guna2TextBox txtStuckPathRotation;

		// Token: 0x04000858 RID: 2136
		private global::Guna.UI2.WinForms.Guna2TrackBar trackStuckPathsRotation;

		// Token: 0x04000859 RID: 2137
		private global::System.Windows.Forms.Label lblStuckPathsRotation;

		// Token: 0x0400085A RID: 2138
		private global::System.Windows.Forms.ListView listStuckPaths;

		// Token: 0x0400085B RID: 2139
		private global::System.Windows.Forms.ColumnHeader listStuckPathsName;

		// Token: 0x0400085C RID: 2140
		private global::System.Windows.Forms.ColumnHeader listStuckPathsDivision;

		// Token: 0x0400085D RID: 2141
		private global::System.Windows.Forms.ColumnHeader listStuckPathsRadius;

		// Token: 0x0400085E RID: 2142
		private global::System.Windows.Forms.ColumnHeader listStuckPathsRotation;

		// Token: 0x0400085F RID: 2143
		private global::System.Windows.Forms.ColumnHeader listStuckPathsDistance;

		// Token: 0x04000860 RID: 2144
		private global::Guna.UI2.WinForms.Guna2TextBox txtStuckPathsEditList;

		// Token: 0x04000861 RID: 2145
		private global::System.Windows.Forms.ColumnHeader listStuckPathsIndex;

		// Token: 0x04000862 RID: 2146
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x04000863 RID: 2147
		private global::Guna.UI2.WinForms.Guna2Button btnStuckPathsAroundMe;

		// Token: 0x04000864 RID: 2148
		private global::Guna.UI2.WinForms.Guna2Button btnStuckPathsAroundMeSet;

		// Token: 0x04000865 RID: 2149
		private global::Guna.UI2.WinForms.Guna2ComboBox selectStuckPathsOrder;

		// Token: 0x04000866 RID: 2150
		private global::Guna.UI2.WinForms.Guna2Button btnStuckPathsReload;

		// Token: 0x04000867 RID: 2151
		private global::Guna.UI2.WinForms.Guna2Button btnStuckPathsTooltip;

		// Token: 0x04000868 RID: 2152
		private global::System.Windows.Forms.Label lblClimbSpotsInfo;
	}
}
