namespace Jack.Forms
{
	// Token: 0x0200006D RID: 109
	public partial class frmMainOverlay : global::System.Windows.Forms.Form
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x00689738 File Offset: 0x00687938
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00689764 File Offset: 0x00687964
		private void InitializeComponent()
		{
			this.lblOverlayMenuStartStopDefault = new global::System.Windows.Forms.Label();
			this.lblOverlayMenuRecorderDefault = new global::System.Windows.Forms.Label();
			this.lblOverlayMenuConsoleDefault = new global::System.Windows.Forms.Label();
			this.lblOverlayESPUnitsDistance = new global::System.Windows.Forms.Label();
			this.lblOverlayESPUnitsType = new global::System.Windows.Forms.Label();
			this.lblOverlayGFXAntiAliasing = new global::System.Windows.Forms.Label();
			this.lblOverlayGFXFPS = new global::System.Windows.Forms.Label();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnOverlayTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabOverlay = new global::System.Windows.Forms.TabPage();
			this.panelTabOverlay = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpOverlayMenus = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblOverlayMenuStartStop = new global::System.Windows.Forms.Label();
			this.checkOverlayMenuStartStop = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblOverlayMenuRecorder = new global::System.Windows.Forms.Label();
			this.checkOverlayMenuRecorder = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblOverlayMenuConsole = new global::System.Windows.Forms.Label();
			this.checkOverlayMenuConsole = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpOverlayGFX = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectOverlayGFXFPS = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.checkOverlayGFXAntiAliasing = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpOverlayWaypoints = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtOverlayWaypointsDisplayRadius = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblOverlayWaypoints = new global::System.Windows.Forms.Label();
			this.lblOverlayWaypointsDisplayRadius = new global::System.Windows.Forms.Label();
			this.checkOverlayWaypoints = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.tabESP = new global::System.Windows.Forms.TabPage();
			this.panelTabESP = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpOverlayESPUnits = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectOverlayESPUnitsDistance = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectOverlayESPUnitsType = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.checkOverlayESPUnits = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpOverlayESPObjects = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkOverlayESPObjectsFishingPools = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkOverlayESPObjectsContainer = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectOverlayESPObjectsDistance = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.sepOverlayESPObjects1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblOverlayESPObjectsDistance = new global::System.Windows.Forms.Label();
			this.checkOverlayESPObjectsChests = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkOverlayESPObjectsLoots = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkOverlayESPObjectsSkinnables = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkOverlayESPObjectsOres = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkOverlayESPObjectsHerbs = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.checkOverlayESPObjectsGatherableMobs = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.panelBox1.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabOverlay.SuspendLayout();
			this.panelTabOverlay.SuspendLayout();
			this.grpOverlayMenus.SuspendLayout();
			this.grpOverlayGFX.SuspendLayout();
			this.grpOverlayWaypoints.SuspendLayout();
			this.tabESP.SuspendLayout();
			this.panelTabESP.SuspendLayout();
			this.grpOverlayESPUnits.SuspendLayout();
			this.grpOverlayESPObjects.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			base.SuspendLayout();
			this.lblOverlayMenuStartStopDefault.AutoSize = true;
			this.lblOverlayMenuStartStopDefault.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayMenuStartStopDefault.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblOverlayMenuStartStopDefault.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblOverlayMenuStartStopDefault.Location = new global::System.Drawing.Point(275, 112);
			this.lblOverlayMenuStartStopDefault.Name = "lblOverlayMenuStartStopDefault";
			this.lblOverlayMenuStartStopDefault.Size = new global::System.Drawing.Size(81, 15);
			this.lblOverlayMenuStartStopDefault.TabIndex = 70;
			this.lblOverlayMenuStartStopDefault.Text = "Reset Position";
			this.lblOverlayMenuStartStopDefault.Click += new global::System.EventHandler(this.lblOverlayMenuStartStopDefault_Click);
			this.lblOverlayMenuRecorderDefault.AutoSize = true;
			this.lblOverlayMenuRecorderDefault.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayMenuRecorderDefault.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblOverlayMenuRecorderDefault.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblOverlayMenuRecorderDefault.Location = new global::System.Drawing.Point(275, 87);
			this.lblOverlayMenuRecorderDefault.Name = "lblOverlayMenuRecorderDefault";
			this.lblOverlayMenuRecorderDefault.Size = new global::System.Drawing.Size(81, 15);
			this.lblOverlayMenuRecorderDefault.TabIndex = 67;
			this.lblOverlayMenuRecorderDefault.Text = "Reset Position";
			this.lblOverlayMenuRecorderDefault.Click += new global::System.EventHandler(this.lblOverlayMenuRecorderDefault_Click);
			this.lblOverlayMenuConsoleDefault.AutoSize = true;
			this.lblOverlayMenuConsoleDefault.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayMenuConsoleDefault.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblOverlayMenuConsoleDefault.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblOverlayMenuConsoleDefault.Location = new global::System.Drawing.Point(275, 62);
			this.lblOverlayMenuConsoleDefault.Name = "lblOverlayMenuConsoleDefault";
			this.lblOverlayMenuConsoleDefault.Size = new global::System.Drawing.Size(81, 15);
			this.lblOverlayMenuConsoleDefault.TabIndex = 66;
			this.lblOverlayMenuConsoleDefault.Text = "Reset Position";
			this.lblOverlayMenuConsoleDefault.Click += new global::System.EventHandler(this.lblOverlayMenuConsoleDefault_Click);
			this.lblOverlayESPUnitsDistance.AutoSize = true;
			this.lblOverlayESPUnitsDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayESPUnitsDistance.Enabled = false;
			this.lblOverlayESPUnitsDistance.Location = new global::System.Drawing.Point(22, 111);
			this.lblOverlayESPUnitsDistance.Name = "lblOverlayESPUnitsDistance";
			this.lblOverlayESPUnitsDistance.Size = new global::System.Drawing.Size(55, 15);
			this.lblOverlayESPUnitsDistance.TabIndex = 0;
			this.lblOverlayESPUnitsDistance.Text = "Distance:";
			this.lblOverlayESPUnitsType.AutoSize = true;
			this.lblOverlayESPUnitsType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayESPUnitsType.Enabled = false;
			this.lblOverlayESPUnitsType.Location = new global::System.Drawing.Point(22, 66);
			this.lblOverlayESPUnitsType.Name = "lblOverlayESPUnitsType";
			this.lblOverlayESPUnitsType.Size = new global::System.Drawing.Size(34, 15);
			this.lblOverlayESPUnitsType.TabIndex = 21;
			this.lblOverlayESPUnitsType.Text = "Type:";
			this.lblOverlayGFXAntiAliasing.AutoSize = true;
			this.lblOverlayGFXAntiAliasing.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayGFXAntiAliasing.ForeColor = global::System.Drawing.Color.White;
			this.lblOverlayGFXAntiAliasing.Location = new global::System.Drawing.Point(22, 60);
			this.lblOverlayGFXAntiAliasing.Name = "lblOverlayGFXAntiAliasing";
			this.lblOverlayGFXAntiAliasing.Size = new global::System.Drawing.Size(79, 15);
			this.lblOverlayGFXAntiAliasing.TabIndex = 14;
			this.lblOverlayGFXAntiAliasing.Text = "Anti-Aliasing:";
			this.lblOverlayGFXFPS.AutoSize = true;
			this.lblOverlayGFXFPS.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayGFXFPS.ForeColor = global::System.Drawing.Color.White;
			this.lblOverlayGFXFPS.Location = new global::System.Drawing.Point(22, 92);
			this.lblOverlayGFXFPS.Name = "lblOverlayGFXFPS";
			this.lblOverlayGFXFPS.Size = new global::System.Drawing.Size(78, 15);
			this.lblOverlayGFXFPS.TabIndex = 0;
			this.lblOverlayGFXFPS.Text = "Frames (FPS):";
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.btnOverlayTooltip);
			this.panelBox1.Controls.Add(this.tabs);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 22);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(894, 607);
			this.panelBox1.TabIndex = 66;
			this.btnOverlayTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOverlayTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnOverlayTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnOverlayTooltip.BorderRadius = 4;
			this.btnOverlayTooltip.BorderThickness = 1;
			this.btnOverlayTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnOverlayTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnOverlayTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnOverlayTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnOverlayTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnOverlayTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnOverlayTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnOverlayTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnOverlayTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnOverlayTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnOverlayTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnOverlayTooltip.Location = new global::System.Drawing.Point(839, 13);
			this.btnOverlayTooltip.Name = "btnOverlayTooltip";
			this.btnOverlayTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnOverlayTooltip.TabIndex = 75;
			this.btnOverlayTooltip.Click += new global::System.EventHandler(this.btnOverlayTooltip_Click);
			this.tabs.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabOverlay);
			this.tabs.Controls.Add(this.tabESP);
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
			this.tabOverlay.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.tabOverlay.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabOverlay.Controls.Add(this.panelTabOverlay);
			this.tabOverlay.ForeColor = global::System.Drawing.Color.White;
			this.tabOverlay.Location = new global::System.Drawing.Point(184, 4);
			this.tabOverlay.Name = "tabOverlay";
			this.tabOverlay.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabOverlay.Size = new global::System.Drawing.Size(680, 530);
			this.tabOverlay.TabIndex = 0;
			this.tabOverlay.Text = "Overlay";
			this.panelTabOverlay.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabOverlay.AutoScroll = true;
			this.panelTabOverlay.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabOverlay.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabOverlay.Controls.Add(this.grpOverlayMenus);
			this.panelTabOverlay.Controls.Add(this.grpOverlayGFX);
			this.panelTabOverlay.Controls.Add(this.grpOverlayWaypoints);
			this.panelTabOverlay.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabOverlay.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabOverlay.Name = "panelTabOverlay";
			this.panelTabOverlay.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabOverlay.TabIndex = 10;
			this.grpOverlayMenus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpOverlayMenus.AutoScroll = true;
			this.grpOverlayMenus.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayMenus.Controls.Add(this.lblOverlayMenuStartStop);
			this.grpOverlayMenus.Controls.Add(this.checkOverlayMenuStartStop);
			this.grpOverlayMenus.Controls.Add(this.lblOverlayMenuRecorder);
			this.grpOverlayMenus.Controls.Add(this.checkOverlayMenuRecorder);
			this.grpOverlayMenus.Controls.Add(this.lblOverlayMenuConsole);
			this.grpOverlayMenus.Controls.Add(this.checkOverlayMenuConsole);
			this.grpOverlayMenus.Controls.Add(this.lblOverlayMenuStartStopDefault);
			this.grpOverlayMenus.Controls.Add(this.lblOverlayMenuRecorderDefault);
			this.grpOverlayMenus.Controls.Add(this.lblOverlayMenuConsoleDefault);
			this.grpOverlayMenus.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayMenus.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpOverlayMenus.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpOverlayMenus.ForeColor = global::System.Drawing.Color.White;
			this.grpOverlayMenus.Location = new global::System.Drawing.Point(14, 305);
			this.grpOverlayMenus.Name = "grpOverlayMenus";
			this.grpOverlayMenus.Size = new global::System.Drawing.Size(652, 147);
			this.grpOverlayMenus.TabIndex = 9;
			this.grpOverlayMenus.Text = "Menus";
			this.lblOverlayMenuStartStop.AutoSize = true;
			this.lblOverlayMenuStartStop.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayMenuStartStop.ForeColor = global::System.Drawing.Color.White;
			this.lblOverlayMenuStartStop.Location = new global::System.Drawing.Point(22, 110);
			this.lblOverlayMenuStartStop.Name = "lblOverlayMenuStartStop";
			this.lblOverlayMenuStartStop.Size = new global::System.Drawing.Size(63, 15);
			this.lblOverlayMenuStartStop.TabIndex = 75;
			this.lblOverlayMenuStartStop.Text = "Start/Stop:";
			this.checkOverlayMenuStartStop.Animated = true;
			this.checkOverlayMenuStartStop.AutoSize = true;
			this.checkOverlayMenuStartStop.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayMenuStartStop.Checked = true;
			this.checkOverlayMenuStartStop.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayMenuStartStop.CheckedState.BorderRadius = 0;
			this.checkOverlayMenuStartStop.CheckedState.BorderThickness = 0;
			this.checkOverlayMenuStartStop.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayMenuStartStop.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkOverlayMenuStartStop.Location = new global::System.Drawing.Point(180, 110);
			this.checkOverlayMenuStartStop.Name = "checkOverlayMenuStartStop";
			this.checkOverlayMenuStartStop.Size = new global::System.Drawing.Size(55, 19);
			this.checkOverlayMenuStartStop.TabIndex = 76;
			this.checkOverlayMenuStartStop.Text = "Show";
			this.checkOverlayMenuStartStop.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayMenuStartStop.UncheckedState.BorderRadius = 0;
			this.checkOverlayMenuStartStop.UncheckedState.BorderThickness = 1;
			this.checkOverlayMenuStartStop.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayMenuStartStop.UseVisualStyleBackColor = false;
			this.checkOverlayMenuStartStop.CheckedChanged += new global::System.EventHandler(this.checkOverlayMenuStartStop_CheckedChanged);
			this.lblOverlayMenuRecorder.AutoSize = true;
			this.lblOverlayMenuRecorder.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayMenuRecorder.ForeColor = global::System.Drawing.Color.White;
			this.lblOverlayMenuRecorder.Location = new global::System.Drawing.Point(22, 85);
			this.lblOverlayMenuRecorder.Name = "lblOverlayMenuRecorder";
			this.lblOverlayMenuRecorder.Size = new global::System.Drawing.Size(57, 15);
			this.lblOverlayMenuRecorder.TabIndex = 73;
			this.lblOverlayMenuRecorder.Text = "Recorder:";
			this.checkOverlayMenuRecorder.Animated = true;
			this.checkOverlayMenuRecorder.AutoSize = true;
			this.checkOverlayMenuRecorder.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayMenuRecorder.Checked = true;
			this.checkOverlayMenuRecorder.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayMenuRecorder.CheckedState.BorderRadius = 0;
			this.checkOverlayMenuRecorder.CheckedState.BorderThickness = 0;
			this.checkOverlayMenuRecorder.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayMenuRecorder.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkOverlayMenuRecorder.Location = new global::System.Drawing.Point(180, 85);
			this.checkOverlayMenuRecorder.Name = "checkOverlayMenuRecorder";
			this.checkOverlayMenuRecorder.Size = new global::System.Drawing.Size(55, 19);
			this.checkOverlayMenuRecorder.TabIndex = 74;
			this.checkOverlayMenuRecorder.Text = "Show";
			this.checkOverlayMenuRecorder.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayMenuRecorder.UncheckedState.BorderRadius = 0;
			this.checkOverlayMenuRecorder.UncheckedState.BorderThickness = 1;
			this.checkOverlayMenuRecorder.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayMenuRecorder.UseVisualStyleBackColor = false;
			this.checkOverlayMenuRecorder.CheckedChanged += new global::System.EventHandler(this.checkOverlayMenuRecorder_CheckedChanged);
			this.lblOverlayMenuConsole.AutoSize = true;
			this.lblOverlayMenuConsole.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayMenuConsole.ForeColor = global::System.Drawing.Color.White;
			this.lblOverlayMenuConsole.Location = new global::System.Drawing.Point(22, 60);
			this.lblOverlayMenuConsole.Name = "lblOverlayMenuConsole";
			this.lblOverlayMenuConsole.Size = new global::System.Drawing.Size(53, 15);
			this.lblOverlayMenuConsole.TabIndex = 71;
			this.lblOverlayMenuConsole.Text = "Console:";
			this.checkOverlayMenuConsole.Animated = true;
			this.checkOverlayMenuConsole.AutoSize = true;
			this.checkOverlayMenuConsole.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayMenuConsole.Checked = true;
			this.checkOverlayMenuConsole.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayMenuConsole.CheckedState.BorderRadius = 0;
			this.checkOverlayMenuConsole.CheckedState.BorderThickness = 0;
			this.checkOverlayMenuConsole.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayMenuConsole.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkOverlayMenuConsole.Location = new global::System.Drawing.Point(180, 60);
			this.checkOverlayMenuConsole.Name = "checkOverlayMenuConsole";
			this.checkOverlayMenuConsole.Size = new global::System.Drawing.Size(55, 19);
			this.checkOverlayMenuConsole.TabIndex = 72;
			this.checkOverlayMenuConsole.Text = "Show";
			this.checkOverlayMenuConsole.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayMenuConsole.UncheckedState.BorderRadius = 0;
			this.checkOverlayMenuConsole.UncheckedState.BorderThickness = 1;
			this.checkOverlayMenuConsole.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayMenuConsole.UseVisualStyleBackColor = false;
			this.checkOverlayMenuConsole.CheckedChanged += new global::System.EventHandler(this.checkOverlayMenuConsole_CheckedChanged);
			this.grpOverlayGFX.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpOverlayGFX.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayGFX.Controls.Add(this.selectOverlayGFXFPS);
			this.grpOverlayGFX.Controls.Add(this.lblOverlayGFXAntiAliasing);
			this.grpOverlayGFX.Controls.Add(this.lblOverlayGFXFPS);
			this.grpOverlayGFX.Controls.Add(this.checkOverlayGFXAntiAliasing);
			this.grpOverlayGFX.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayGFX.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpOverlayGFX.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpOverlayGFX.ForeColor = global::System.Drawing.Color.White;
			this.grpOverlayGFX.Location = new global::System.Drawing.Point(14, 14);
			this.grpOverlayGFX.Name = "grpOverlayGFX";
			this.grpOverlayGFX.Size = new global::System.Drawing.Size(652, 129);
			this.grpOverlayGFX.TabIndex = 7;
			this.grpOverlayGFX.Text = "GFX";
			this.selectOverlayGFXFPS.BackColor = global::System.Drawing.Color.Transparent;
			this.selectOverlayGFXFPS.BorderColor = global::System.Drawing.Color.Gray;
			this.selectOverlayGFXFPS.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectOverlayGFXFPS.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectOverlayGFXFPS.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectOverlayGFXFPS.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectOverlayGFXFPS.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectOverlayGFXFPS.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayGFXFPS.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayGFXFPS.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectOverlayGFXFPS.ForeColor = global::System.Drawing.Color.White;
			this.selectOverlayGFXFPS.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectOverlayGFXFPS.ItemHeight = 24;
			this.selectOverlayGFXFPS.Items.AddRange(new object[]
			{
				"30",
				"60",
				"90",
				"120"
			});
			this.selectOverlayGFXFPS.Location = new global::System.Drawing.Point(180, 85);
			this.selectOverlayGFXFPS.Name = "selectOverlayGFXFPS";
			this.selectOverlayGFXFPS.Size = new global::System.Drawing.Size(140, 30);
			this.selectOverlayGFXFPS.TabIndex = 63;
			this.selectOverlayGFXFPS.SelectedIndexChanged += new global::System.EventHandler(this.selectOverlayGFXFPS_SelectedIndexChanged);
			this.checkOverlayGFXAntiAliasing.Animated = true;
			this.checkOverlayGFXAntiAliasing.AutoSize = true;
			this.checkOverlayGFXAntiAliasing.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayGFXAntiAliasing.Checked = true;
			this.checkOverlayGFXAntiAliasing.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayGFXAntiAliasing.CheckedState.BorderRadius = 0;
			this.checkOverlayGFXAntiAliasing.CheckedState.BorderThickness = 0;
			this.checkOverlayGFXAntiAliasing.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayGFXAntiAliasing.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkOverlayGFXAntiAliasing.Location = new global::System.Drawing.Point(180, 60);
			this.checkOverlayGFXAntiAliasing.Name = "checkOverlayGFXAntiAliasing";
			this.checkOverlayGFXAntiAliasing.Size = new global::System.Drawing.Size(68, 19);
			this.checkOverlayGFXAntiAliasing.TabIndex = 32;
			this.checkOverlayGFXAntiAliasing.Text = "Enabled";
			this.checkOverlayGFXAntiAliasing.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayGFXAntiAliasing.UncheckedState.BorderRadius = 0;
			this.checkOverlayGFXAntiAliasing.UncheckedState.BorderThickness = 1;
			this.checkOverlayGFXAntiAliasing.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayGFXAntiAliasing.UseVisualStyleBackColor = false;
			this.checkOverlayGFXAntiAliasing.CheckedChanged += new global::System.EventHandler(this.checkOverlayGFXAntiAliasing_CheckedChanged);
			this.grpOverlayWaypoints.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpOverlayWaypoints.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayWaypoints.Controls.Add(this.txtOverlayWaypointsDisplayRadius);
			this.grpOverlayWaypoints.Controls.Add(this.lblOverlayWaypoints);
			this.grpOverlayWaypoints.Controls.Add(this.lblOverlayWaypointsDisplayRadius);
			this.grpOverlayWaypoints.Controls.Add(this.checkOverlayWaypoints);
			this.grpOverlayWaypoints.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayWaypoints.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpOverlayWaypoints.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpOverlayWaypoints.ForeColor = global::System.Drawing.Color.White;
			this.grpOverlayWaypoints.Location = new global::System.Drawing.Point(14, 158);
			this.grpOverlayWaypoints.Name = "grpOverlayWaypoints";
			this.grpOverlayWaypoints.Size = new global::System.Drawing.Size(652, 132);
			this.grpOverlayWaypoints.TabIndex = 8;
			this.grpOverlayWaypoints.Text = "Waypoints";
			this.txtOverlayWaypointsDisplayRadius.BorderColor = global::System.Drawing.Color.Gray;
			this.txtOverlayWaypointsDisplayRadius.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtOverlayWaypointsDisplayRadius.DefaultText = "100";
			this.txtOverlayWaypointsDisplayRadius.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtOverlayWaypointsDisplayRadius.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtOverlayWaypointsDisplayRadius.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtOverlayWaypointsDisplayRadius.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtOverlayWaypointsDisplayRadius.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtOverlayWaypointsDisplayRadius.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtOverlayWaypointsDisplayRadius.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtOverlayWaypointsDisplayRadius.ForeColor = global::System.Drawing.Color.White;
			this.txtOverlayWaypointsDisplayRadius.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtOverlayWaypointsDisplayRadius.Location = new global::System.Drawing.Point(180, 85);
			this.txtOverlayWaypointsDisplayRadius.MaxLength = 4;
			this.txtOverlayWaypointsDisplayRadius.Name = "txtOverlayWaypointsDisplayRadius";
			this.txtOverlayWaypointsDisplayRadius.PasswordChar = '\0';
			this.txtOverlayWaypointsDisplayRadius.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtOverlayWaypointsDisplayRadius.PlaceholderText = "";
			this.txtOverlayWaypointsDisplayRadius.SelectedText = "";
			this.txtOverlayWaypointsDisplayRadius.Size = new global::System.Drawing.Size(140, 30);
			this.txtOverlayWaypointsDisplayRadius.TabIndex = 64;
			this.txtOverlayWaypointsDisplayRadius.TextChanged += new global::System.EventHandler(this.txtOverlayWaypointsDisplayRadius_TextChanged);
			this.lblOverlayWaypoints.AutoSize = true;
			this.lblOverlayWaypoints.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayWaypoints.ForeColor = global::System.Drawing.Color.White;
			this.lblOverlayWaypoints.Location = new global::System.Drawing.Point(22, 60);
			this.lblOverlayWaypoints.Name = "lblOverlayWaypoints";
			this.lblOverlayWaypoints.Size = new global::System.Drawing.Size(66, 15);
			this.lblOverlayWaypoints.TabIndex = 14;
			this.lblOverlayWaypoints.Text = "Waypoints:";
			this.lblOverlayWaypointsDisplayRadius.AutoSize = true;
			this.lblOverlayWaypointsDisplayRadius.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayWaypointsDisplayRadius.ForeColor = global::System.Drawing.Color.White;
			this.lblOverlayWaypointsDisplayRadius.Location = new global::System.Drawing.Point(22, 92);
			this.lblOverlayWaypointsDisplayRadius.Name = "lblOverlayWaypointsDisplayRadius";
			this.lblOverlayWaypointsDisplayRadius.Size = new global::System.Drawing.Size(86, 15);
			this.lblOverlayWaypointsDisplayRadius.TabIndex = 0;
			this.lblOverlayWaypointsDisplayRadius.Text = "Display Radius:";
			this.checkOverlayWaypoints.Animated = true;
			this.checkOverlayWaypoints.AutoSize = true;
			this.checkOverlayWaypoints.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayWaypoints.Checked = true;
			this.checkOverlayWaypoints.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayWaypoints.CheckedState.BorderRadius = 0;
			this.checkOverlayWaypoints.CheckedState.BorderThickness = 0;
			this.checkOverlayWaypoints.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayWaypoints.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkOverlayWaypoints.Location = new global::System.Drawing.Point(180, 60);
			this.checkOverlayWaypoints.Name = "checkOverlayWaypoints";
			this.checkOverlayWaypoints.Size = new global::System.Drawing.Size(55, 19);
			this.checkOverlayWaypoints.TabIndex = 32;
			this.checkOverlayWaypoints.Text = "Show";
			this.checkOverlayWaypoints.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayWaypoints.UncheckedState.BorderRadius = 0;
			this.checkOverlayWaypoints.UncheckedState.BorderThickness = 1;
			this.checkOverlayWaypoints.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayWaypoints.UseVisualStyleBackColor = false;
			this.checkOverlayWaypoints.CheckedChanged += new global::System.EventHandler(this.checkOverlayWaypoints_CheckedChanged);
			this.tabESP.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabESP.Controls.Add(this.panelTabESP);
			this.tabESP.ForeColor = global::System.Drawing.Color.White;
			this.tabESP.Location = new global::System.Drawing.Point(184, 4);
			this.tabESP.Name = "tabESP";
			this.tabESP.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabESP.Size = new global::System.Drawing.Size(680, 530);
			this.tabESP.TabIndex = 1;
			this.tabESP.Text = "ESP";
			this.panelTabESP.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabESP.AutoScroll = true;
			this.panelTabESP.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabESP.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabESP.Controls.Add(this.grpOverlayESPUnits);
			this.panelTabESP.Controls.Add(this.grpOverlayESPObjects);
			this.panelTabESP.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabESP.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabESP.Name = "panelTabESP";
			this.panelTabESP.Size = new global::System.Drawing.Size(680, 530);
			this.panelTabESP.TabIndex = 11;
			this.grpOverlayESPUnits.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpOverlayESPUnits.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpOverlayESPUnits.Controls.Add(this.selectOverlayESPUnitsDistance);
			this.grpOverlayESPUnits.Controls.Add(this.selectOverlayESPUnitsType);
			this.grpOverlayESPUnits.Controls.Add(this.checkOverlayESPUnits);
			this.grpOverlayESPUnits.Controls.Add(this.lblOverlayESPUnitsType);
			this.grpOverlayESPUnits.Controls.Add(this.lblOverlayESPUnitsDistance);
			this.grpOverlayESPUnits.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpOverlayESPUnits.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpOverlayESPUnits.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpOverlayESPUnits.ForeColor = global::System.Drawing.Color.White;
			this.grpOverlayESPUnits.Location = new global::System.Drawing.Point(14, 241);
			this.grpOverlayESPUnits.Name = "grpOverlayESPUnits";
			this.grpOverlayESPUnits.Size = new global::System.Drawing.Size(652, 152);
			this.grpOverlayESPUnits.TabIndex = 7;
			this.selectOverlayESPUnitsDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.selectOverlayESPUnitsDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.selectOverlayESPUnitsDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectOverlayESPUnitsDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectOverlayESPUnitsDistance.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectOverlayESPUnitsDistance.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectOverlayESPUnitsDistance.Enabled = false;
			this.selectOverlayESPUnitsDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectOverlayESPUnitsDistance.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayESPUnitsDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayESPUnitsDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectOverlayESPUnitsDistance.ForeColor = global::System.Drawing.Color.White;
			this.selectOverlayESPUnitsDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectOverlayESPUnitsDistance.ItemHeight = 24;
			this.selectOverlayESPUnitsDistance.Items.AddRange(new object[]
			{
				"10",
				"20",
				"30",
				"40",
				"50",
				"60",
				"70",
				"80",
				"90",
				"100"
			});
			this.selectOverlayESPUnitsDistance.Location = new global::System.Drawing.Point(180, 105);
			this.selectOverlayESPUnitsDistance.Name = "selectOverlayESPUnitsDistance";
			this.selectOverlayESPUnitsDistance.Size = new global::System.Drawing.Size(140, 30);
			this.selectOverlayESPUnitsDistance.TabIndex = 66;
			this.selectOverlayESPUnitsDistance.SelectedIndexChanged += new global::System.EventHandler(this.selectOverlayESPUnitsDistance_SelectedIndexChanged);
			this.selectOverlayESPUnitsType.BackColor = global::System.Drawing.Color.Transparent;
			this.selectOverlayESPUnitsType.BorderColor = global::System.Drawing.Color.Gray;
			this.selectOverlayESPUnitsType.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectOverlayESPUnitsType.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectOverlayESPUnitsType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectOverlayESPUnitsType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectOverlayESPUnitsType.Enabled = false;
			this.selectOverlayESPUnitsType.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectOverlayESPUnitsType.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayESPUnitsType.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayESPUnitsType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectOverlayESPUnitsType.ForeColor = global::System.Drawing.Color.White;
			this.selectOverlayESPUnitsType.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectOverlayESPUnitsType.ItemHeight = 24;
			this.selectOverlayESPUnitsType.Items.AddRange(new object[]
			{
				"None",
				"All NPC's",
				"Horde",
				"Alliance"
			});
			this.selectOverlayESPUnitsType.Location = new global::System.Drawing.Point(180, 60);
			this.selectOverlayESPUnitsType.Name = "selectOverlayESPUnitsType";
			this.selectOverlayESPUnitsType.Size = new global::System.Drawing.Size(140, 30);
			this.selectOverlayESPUnitsType.TabIndex = 65;
			this.selectOverlayESPUnitsType.SelectedIndexChanged += new global::System.EventHandler(this.selectOverlayESPUnitsType_SelectedIndexChanged);
			this.checkOverlayESPUnits.Animated = true;
			this.checkOverlayESPUnits.AutoSize = true;
			this.checkOverlayESPUnits.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPUnits.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPUnits.CheckedState.BorderRadius = 0;
			this.checkOverlayESPUnits.CheckedState.BorderThickness = 0;
			this.checkOverlayESPUnits.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPUnits.Location = new global::System.Drawing.Point(12, 11);
			this.checkOverlayESPUnits.Name = "checkOverlayESPUnits";
			this.checkOverlayESPUnits.Size = new global::System.Drawing.Size(53, 19);
			this.checkOverlayESPUnits.TabIndex = 32;
			this.checkOverlayESPUnits.Text = "Units";
			this.checkOverlayESPUnits.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkOverlayESPUnits.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPUnits.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPUnits.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkOverlayESPUnits.UseVisualStyleBackColor = false;
			this.checkOverlayESPUnits.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPUnits_CheckedChanged);
			this.grpOverlayESPObjects.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpOverlayESPObjects.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsGatherableMobs);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsFishingPools);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsContainer);
			this.grpOverlayESPObjects.Controls.Add(this.selectOverlayESPObjectsDistance);
			this.grpOverlayESPObjects.Controls.Add(this.sepOverlayESPObjects1);
			this.grpOverlayESPObjects.Controls.Add(this.lblOverlayESPObjectsDistance);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsChests);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsLoots);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsSkinnables);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsOres);
			this.grpOverlayESPObjects.Controls.Add(this.checkOverlayESPObjectsHerbs);
			this.grpOverlayESPObjects.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpOverlayESPObjects.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpOverlayESPObjects.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpOverlayESPObjects.ForeColor = global::System.Drawing.Color.White;
			this.grpOverlayESPObjects.Location = new global::System.Drawing.Point(14, 14);
			this.grpOverlayESPObjects.Name = "grpOverlayESPObjects";
			this.grpOverlayESPObjects.Size = new global::System.Drawing.Size(652, 212);
			this.grpOverlayESPObjects.TabIndex = 6;
			this.grpOverlayESPObjects.Text = "Objects";
			this.checkOverlayESPObjectsFishingPools.Animated = true;
			this.checkOverlayESPObjectsFishingPools.AutoSize = true;
			this.checkOverlayESPObjectsFishingPools.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsFishingPools.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsFishingPools.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsFishingPools.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsFishingPools.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsFishingPools.Location = new global::System.Drawing.Point(335, 85);
			this.checkOverlayESPObjectsFishingPools.Name = "checkOverlayESPObjectsFishingPools";
			this.checkOverlayESPObjectsFishingPools.Size = new global::System.Drawing.Size(96, 19);
			this.checkOverlayESPObjectsFishingPools.TabIndex = 66;
			this.checkOverlayESPObjectsFishingPools.Text = "Fishing Pools";
			this.checkOverlayESPObjectsFishingPools.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsFishingPools.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsFishingPools.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsFishingPools.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsFishingPools.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsFishingPools.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsFishingPools_CheckedChanged);
			this.checkOverlayESPObjectsContainer.Animated = true;
			this.checkOverlayESPObjectsContainer.AutoSize = true;
			this.checkOverlayESPObjectsContainer.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsContainer.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsContainer.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsContainer.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsContainer.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsContainer.Location = new global::System.Drawing.Point(335, 60);
			this.checkOverlayESPObjectsContainer.Name = "checkOverlayESPObjectsContainer";
			this.checkOverlayESPObjectsContainer.Size = new global::System.Drawing.Size(78, 19);
			this.checkOverlayESPObjectsContainer.TabIndex = 65;
			this.checkOverlayESPObjectsContainer.Text = "Container";
			this.checkOverlayESPObjectsContainer.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsContainer.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsContainer.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsContainer.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsContainer.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsContainer.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsContainer_CheckedChanged);
			this.selectOverlayESPObjectsDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.selectOverlayESPObjectsDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.selectOverlayESPObjectsDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectOverlayESPObjectsDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectOverlayESPObjectsDistance.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectOverlayESPObjectsDistance.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectOverlayESPObjectsDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectOverlayESPObjectsDistance.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayESPObjectsDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOverlayESPObjectsDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectOverlayESPObjectsDistance.ForeColor = global::System.Drawing.Color.White;
			this.selectOverlayESPObjectsDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectOverlayESPObjectsDistance.ItemHeight = 24;
			this.selectOverlayESPObjectsDistance.Items.AddRange(new object[]
			{
				"10",
				"20",
				"30",
				"40",
				"50",
				"60",
				"70",
				"80",
				"90",
				"100"
			});
			this.selectOverlayESPObjectsDistance.Location = new global::System.Drawing.Point(180, 164);
			this.selectOverlayESPObjectsDistance.Name = "selectOverlayESPObjectsDistance";
			this.selectOverlayESPObjectsDistance.Size = new global::System.Drawing.Size(140, 30);
			this.selectOverlayESPObjectsDistance.TabIndex = 64;
			this.selectOverlayESPObjectsDistance.SelectedIndexChanged += new global::System.EventHandler(this.selectOverlayESPObjectsDistance_SelectedIndexChanged);
			this.sepOverlayESPObjects1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepOverlayESPObjects1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepOverlayESPObjects1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepOverlayESPObjects1.Location = new global::System.Drawing.Point(20, 140);
			this.sepOverlayESPObjects1.Name = "sepOverlayESPObjects1";
			this.sepOverlayESPObjects1.Size = new global::System.Drawing.Size(612, 10);
			this.sepOverlayESPObjects1.TabIndex = 36;
			this.lblOverlayESPObjectsDistance.AutoSize = true;
			this.lblOverlayESPObjectsDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblOverlayESPObjectsDistance.Location = new global::System.Drawing.Point(22, 170);
			this.lblOverlayESPObjectsDistance.Name = "lblOverlayESPObjectsDistance";
			this.lblOverlayESPObjectsDistance.Size = new global::System.Drawing.Size(55, 15);
			this.lblOverlayESPObjectsDistance.TabIndex = 34;
			this.lblOverlayESPObjectsDistance.Text = "Distance:";
			this.checkOverlayESPObjectsChests.Animated = true;
			this.checkOverlayESPObjectsChests.AutoSize = true;
			this.checkOverlayESPObjectsChests.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsChests.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsChests.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsChests.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsChests.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsChests.Location = new global::System.Drawing.Point(180, 110);
			this.checkOverlayESPObjectsChests.Name = "checkOverlayESPObjectsChests";
			this.checkOverlayESPObjectsChests.Size = new global::System.Drawing.Size(61, 19);
			this.checkOverlayESPObjectsChests.TabIndex = 33;
			this.checkOverlayESPObjectsChests.Text = "Chests";
			this.checkOverlayESPObjectsChests.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsChests.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsChests.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsChests.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsChests.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsChests.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsChests_CheckedChanged);
			this.checkOverlayESPObjectsLoots.Animated = true;
			this.checkOverlayESPObjectsLoots.AutoSize = true;
			this.checkOverlayESPObjectsLoots.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsLoots.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsLoots.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsLoots.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsLoots.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsLoots.Location = new global::System.Drawing.Point(180, 85);
			this.checkOverlayESPObjectsLoots.Name = "checkOverlayESPObjectsLoots";
			this.checkOverlayESPObjectsLoots.Size = new global::System.Drawing.Size(55, 19);
			this.checkOverlayESPObjectsLoots.TabIndex = 32;
			this.checkOverlayESPObjectsLoots.Text = "Loots";
			this.checkOverlayESPObjectsLoots.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsLoots.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsLoots.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsLoots.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsLoots.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsLoots.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsLoots_CheckedChanged);
			this.checkOverlayESPObjectsSkinnables.Animated = true;
			this.checkOverlayESPObjectsSkinnables.AutoSize = true;
			this.checkOverlayESPObjectsSkinnables.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsSkinnables.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsSkinnables.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsSkinnables.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsSkinnables.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsSkinnables.Location = new global::System.Drawing.Point(25, 110);
			this.checkOverlayESPObjectsSkinnables.Name = "checkOverlayESPObjectsSkinnables";
			this.checkOverlayESPObjectsSkinnables.Size = new global::System.Drawing.Size(82, 19);
			this.checkOverlayESPObjectsSkinnables.TabIndex = 31;
			this.checkOverlayESPObjectsSkinnables.Text = "Skinnables";
			this.checkOverlayESPObjectsSkinnables.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsSkinnables.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsSkinnables.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsSkinnables.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsSkinnables.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsSkinnables.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsSkinnables_CheckedChanged);
			this.checkOverlayESPObjectsOres.Animated = true;
			this.checkOverlayESPObjectsOres.AutoSize = true;
			this.checkOverlayESPObjectsOres.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsOres.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsOres.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsOres.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsOres.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsOres.Location = new global::System.Drawing.Point(25, 85);
			this.checkOverlayESPObjectsOres.Name = "checkOverlayESPObjectsOres";
			this.checkOverlayESPObjectsOres.Size = new global::System.Drawing.Size(50, 19);
			this.checkOverlayESPObjectsOres.TabIndex = 30;
			this.checkOverlayESPObjectsOres.Text = "Ores";
			this.checkOverlayESPObjectsOres.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsOres.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsOres.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsOres.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsOres.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsOres.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsOres_CheckedChanged);
			this.checkOverlayESPObjectsHerbs.Animated = true;
			this.checkOverlayESPObjectsHerbs.AutoSize = true;
			this.checkOverlayESPObjectsHerbs.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsHerbs.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsHerbs.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsHerbs.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsHerbs.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsHerbs.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkOverlayESPObjectsHerbs.Location = new global::System.Drawing.Point(25, 60);
			this.checkOverlayESPObjectsHerbs.Name = "checkOverlayESPObjectsHerbs";
			this.checkOverlayESPObjectsHerbs.Size = new global::System.Drawing.Size(57, 19);
			this.checkOverlayESPObjectsHerbs.TabIndex = 29;
			this.checkOverlayESPObjectsHerbs.Text = "Herbs";
			this.checkOverlayESPObjectsHerbs.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsHerbs.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsHerbs.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsHerbs.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsHerbs.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsHerbs.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsHerbs_CheckedChanged);
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
			this.lblTitle.Size = new global::System.Drawing.Size(160, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Overlay - ESP";
			this.checkOverlayESPObjectsGatherableMobs.Animated = true;
			this.checkOverlayESPObjectsGatherableMobs.AutoSize = true;
			this.checkOverlayESPObjectsGatherableMobs.BackColor = global::System.Drawing.Color.Transparent;
			this.checkOverlayESPObjectsGatherableMobs.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsGatherableMobs.CheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsGatherableMobs.CheckedState.BorderThickness = 0;
			this.checkOverlayESPObjectsGatherableMobs.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkOverlayESPObjectsGatherableMobs.Location = new global::System.Drawing.Point(180, 60);
			this.checkOverlayESPObjectsGatherableMobs.Name = "checkOverlayESPObjectsGatherableMobs";
			this.checkOverlayESPObjectsGatherableMobs.Size = new global::System.Drawing.Size(116, 19);
			this.checkOverlayESPObjectsGatherableMobs.TabIndex = 67;
			this.checkOverlayESPObjectsGatherableMobs.Text = "Gatherable Mobs";
			this.checkOverlayESPObjectsGatherableMobs.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkOverlayESPObjectsGatherableMobs.UncheckedState.BorderRadius = 0;
			this.checkOverlayESPObjectsGatherableMobs.UncheckedState.BorderThickness = 1;
			this.checkOverlayESPObjectsGatherableMobs.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkOverlayESPObjectsGatherableMobs.UseVisualStyleBackColor = false;
			this.checkOverlayESPObjectsGatherableMobs.CheckedChanged += new global::System.EventHandler(this.checkOverlayESPObjectsGatherableMobs_CheckedChanged);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 629);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainOverlay";
			this.Text = "frmMainOverlay";
			base.Load += new global::System.EventHandler(this.frmMainOverlay_Load);
			base.Shown += new global::System.EventHandler(this.frmMainOverlay_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainOverlay_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabOverlay.ResumeLayout(false);
			this.panelTabOverlay.ResumeLayout(false);
			this.grpOverlayMenus.ResumeLayout(false);
			this.grpOverlayMenus.PerformLayout();
			this.grpOverlayGFX.ResumeLayout(false);
			this.grpOverlayGFX.PerformLayout();
			this.grpOverlayWaypoints.ResumeLayout(false);
			this.grpOverlayWaypoints.PerformLayout();
			this.tabESP.ResumeLayout(false);
			this.panelTabESP.ResumeLayout(false);
			this.grpOverlayESPUnits.ResumeLayout(false);
			this.grpOverlayESPUnits.PerformLayout();
			this.grpOverlayESPObjects.ResumeLayout(false);
			this.grpOverlayESPObjects.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040002F7 RID: 759
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002F8 RID: 760
		private global::System.Windows.Forms.Label lblOverlayMenuStartStopDefault;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.Label lblOverlayMenuRecorderDefault;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.Label lblOverlayMenuConsoleDefault;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.Label lblOverlayESPUnitsDistance;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.Label lblOverlayESPUnitsType;

		// Token: 0x040002FD RID: 765
		private global::System.Windows.Forms.Label lblOverlayGFXAntiAliasing;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.Label lblOverlayGFXFPS;

		// Token: 0x040002FF RID: 767
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000300 RID: 768
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x04000301 RID: 769
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x04000302 RID: 770
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x04000303 RID: 771
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.Forms.TabPage tabOverlay;

		// Token: 0x04000305 RID: 773
		private global::System.Windows.Forms.TabPage tabESP;

		// Token: 0x04000306 RID: 774
		private global::Guna.UI2.WinForms.Guna2GroupBox grpOverlayESPObjects;

		// Token: 0x04000307 RID: 775
		private global::Guna.UI2.WinForms.Guna2GroupBox grpOverlayESPUnits;

		// Token: 0x04000308 RID: 776
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsHerbs;

		// Token: 0x04000309 RID: 777
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPUnits;

		// Token: 0x0400030A RID: 778
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsChests;

		// Token: 0x0400030B RID: 779
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsLoots;

		// Token: 0x0400030C RID: 780
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsSkinnables;

		// Token: 0x0400030D RID: 781
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsOres;

		// Token: 0x0400030E RID: 782
		private global::System.Windows.Forms.Label lblOverlayESPObjectsDistance;

		// Token: 0x0400030F RID: 783
		private global::Guna.UI2.WinForms.Guna2Separator sepOverlayESPObjects1;

		// Token: 0x04000310 RID: 784
		private global::Guna.UI2.WinForms.Guna2GroupBox grpOverlayGFX;

		// Token: 0x04000311 RID: 785
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayGFXAntiAliasing;

		// Token: 0x04000312 RID: 786
		private global::Guna.UI2.WinForms.Guna2GroupBox grpOverlayWaypoints;

		// Token: 0x04000313 RID: 787
		private global::System.Windows.Forms.Label lblOverlayWaypoints;

		// Token: 0x04000314 RID: 788
		private global::System.Windows.Forms.Label lblOverlayWaypointsDisplayRadius;

		// Token: 0x04000315 RID: 789
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayWaypoints;

		// Token: 0x04000316 RID: 790
		private global::Guna.UI2.WinForms.Guna2TextBox txtOverlayWaypointsDisplayRadius;

		// Token: 0x04000317 RID: 791
		private global::Guna.UI2.WinForms.Guna2GroupBox grpOverlayMenus;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.Label lblOverlayMenuRecorder;

		// Token: 0x04000319 RID: 793
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayMenuRecorder;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.Label lblOverlayMenuConsole;

		// Token: 0x0400031B RID: 795
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayMenuConsole;

		// Token: 0x0400031C RID: 796
		private global::System.Windows.Forms.Label lblOverlayMenuStartStop;

		// Token: 0x0400031D RID: 797
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayMenuStartStop;

		// Token: 0x0400031E RID: 798
		private global::Guna.UI2.WinForms.Guna2ComboBox selectOverlayGFXFPS;

		// Token: 0x0400031F RID: 799
		private global::Guna.UI2.WinForms.Guna2ComboBox selectOverlayESPObjectsDistance;

		// Token: 0x04000320 RID: 800
		private global::Guna.UI2.WinForms.Guna2ComboBox selectOverlayESPUnitsDistance;

		// Token: 0x04000321 RID: 801
		private global::Guna.UI2.WinForms.Guna2ComboBox selectOverlayESPUnitsType;

		// Token: 0x04000322 RID: 802
		private global::Guna.UI2.WinForms.Guna2Panel panelTabOverlay;

		// Token: 0x04000323 RID: 803
		private global::Guna.UI2.WinForms.Guna2Panel panelTabESP;

		// Token: 0x04000324 RID: 804
		private global::Guna.UI2.WinForms.Guna2Button btnOverlayTooltip;

		// Token: 0x04000325 RID: 805
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsContainer;

		// Token: 0x04000326 RID: 806
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsFishingPools;

		// Token: 0x04000327 RID: 807
		private global::Guna.UI2.WinForms.Guna2CheckBox checkOverlayESPObjectsGatherableMobs;
	}
}
