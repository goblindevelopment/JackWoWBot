namespace Jack.Forms
{
	// Token: 0x020000B7 RID: 183
	public partial class frmRotationConditions : global::System.Windows.Forms.Form
	{
		// Token: 0x0600135A RID: 4954 RVA: 0x006F92C0 File Offset: 0x006F74C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x006F92EC File Offset: 0x006F74EC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmRotationConditions));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpProperties = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtPropertiesCooldown = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblPropertiesCooldown = new global::System.Windows.Forms.Label();
			this.btnPropertiesTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.checkCanCastWhileWalk = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.txtPropertiesPrio = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblPropertiesRepetitions = new global::System.Windows.Forms.Label();
			this.txtPropertiesDifferentAuraID = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblPropertiesDifferentAuraID = new global::System.Windows.Forms.Label();
			this.btnReset = new global::Guna.UI2.WinForms.Guna2Button();
			this.grpInfo = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblInfoSpellNameData = new global::System.Windows.Forms.Label();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.panelBox2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabGeneral = new global::System.Windows.Forms.TabPage();
			this.panelTabGeneral = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpItem = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnItemTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectItem = new global::System.Windows.Forms.ComboBox();
			this.txtItemAmount = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnItemReload = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtItemValue = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblItemAmount = new global::System.Windows.Forms.Label();
			this.selectItemCompare = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblItemCompare = new global::System.Windows.Forms.Label();
			this.lblItem = new global::System.Windows.Forms.Label();
			this.grpType = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnTypeTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectType = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblType = new global::System.Windows.Forms.Label();
			this.grpPowerType2 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnPowerType2Tooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtPowerType2Value = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.selectPowerType2Compare = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblPowerType2Compare = new global::System.Windows.Forms.Label();
			this.selectPowerType2 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblPowerType2 = new global::System.Windows.Forms.Label();
			this.selectPowerType2Target = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblPowerType2Subject = new global::System.Windows.Forms.Label();
			this.grpPowerType1 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnPowerType1Tooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtPowerType1Value = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.selectPowerType1Compare = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblPowerType1Compare = new global::System.Windows.Forms.Label();
			this.selectPowerType1 = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblPowerType1 = new global::System.Windows.Forms.Label();
			this.selectPowerType1Target = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblPowerType1Subject = new global::System.Windows.Forms.Label();
			this.tabOptions = new global::System.Windows.Forms.TabPage();
			this.panelTabOptions = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpAddition1 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtAddition1Value = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.selectAddition1Compare = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblAddition1Compare = new global::System.Windows.Forms.Label();
			this.selectAddition1Option = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblAddition1Option = new global::System.Windows.Forms.Label();
			this.selectAddition1Target = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblAddition1Target = new global::System.Windows.Forms.Label();
			this.grpAddition4 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkAddition4AlwaysActiveOutOfCombat = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddition4AlwaysActiveCombatWay = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkAddition4AlwaysActiveCombat = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpAddition2 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkAddition2DoNotRecastIfActive = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectAddition2DoNotRecastIfActiveTarget = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblAddition2DoNotRecastIfActiveTarget = new global::System.Windows.Forms.Label();
			this.grpAddition3 = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblAddition3CastIfActiveOn = new global::System.Windows.Forms.Label();
			this.btnAddition3CastIfActiveSpelllist = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectAddition3CastIfActiveTarget = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblAddition3CastIfActiveTarget = new global::System.Windows.Forms.Label();
			this.checkAddition3CastIfActive = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblAddition3CastIfActiveSpelllist = new global::System.Windows.Forms.Label();
			this.tabMore = new global::System.Windows.Forms.TabPage();
			this.panelTabMore = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpMisc = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkMiscTargetIsCasting = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpMultipleAttackers = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblMultipleAttackers = new global::System.Windows.Forms.Label();
			this.guna2Separator2 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.checkMultipleAttackersStepBack = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblMultipleAttackersYards = new global::System.Windows.Forms.Label();
			this.lblMultipleAttackersWithin = new global::System.Windows.Forms.Label();
			this.txtMultipleAttackersDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtMultipleAttackersValue = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.selectMultipleAttackersCompare = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblMultipleAttackersCompare = new global::System.Windows.Forms.Label();
			this.tabMacro = new global::System.Windows.Forms.TabPage();
			this.panelTabMacro = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpMacro = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectMacroSlot = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblMacroSlot = new global::System.Windows.Forms.Label();
			this.selectMacroBar = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblMacroBar = new global::System.Windows.Forms.Label();
			this.txtMacroName = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblMacroName = new global::System.Windows.Forms.Label();
			this.panelTitle2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle2 = new global::System.Windows.Forms.Label();
			this.lblProfileName = new global::System.Windows.Forms.Label();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtPropertiesRepetitions = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblPropertiesPrio = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.grpProperties.SuspendLayout();
			this.grpInfo.SuspendLayout();
			this.panelTitle1.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			this.panelBox2.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.panelTabGeneral.SuspendLayout();
			this.grpItem.SuspendLayout();
			this.grpType.SuspendLayout();
			this.grpPowerType2.SuspendLayout();
			this.grpPowerType1.SuspendLayout();
			this.tabOptions.SuspendLayout();
			this.panelTabOptions.SuspendLayout();
			this.grpAddition1.SuspendLayout();
			this.grpAddition4.SuspendLayout();
			this.grpAddition2.SuspendLayout();
			this.grpAddition3.SuspendLayout();
			this.tabMore.SuspendLayout();
			this.panelTabMore.SuspendLayout();
			this.grpMisc.SuspendLayout();
			this.grpMultipleAttackers.SuspendLayout();
			this.tabMacro.SuspendLayout();
			this.panelTabMacro.SuspendLayout();
			this.grpMacro.SuspendLayout();
			this.panelTitle2.SuspendLayout();
			this.imgTitleEdge2.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.grpProperties);
			this.panelBox1.Controls.Add(this.btnReset);
			this.panelBox1.Controls.Add(this.grpInfo);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(314, 503);
			this.panelBox1.TabIndex = 71;
			this.grpProperties.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpProperties.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpProperties.Controls.Add(this.txtPropertiesRepetitions);
			this.grpProperties.Controls.Add(this.lblPropertiesPrio);
			this.grpProperties.Controls.Add(this.txtPropertiesCooldown);
			this.grpProperties.Controls.Add(this.lblPropertiesCooldown);
			this.grpProperties.Controls.Add(this.btnPropertiesTooltip);
			this.grpProperties.Controls.Add(this.guna2Separator1);
			this.grpProperties.Controls.Add(this.checkCanCastWhileWalk);
			this.grpProperties.Controls.Add(this.txtPropertiesPrio);
			this.grpProperties.Controls.Add(this.lblPropertiesRepetitions);
			this.grpProperties.Controls.Add(this.txtPropertiesDifferentAuraID);
			this.grpProperties.Controls.Add(this.lblPropertiesDifferentAuraID);
			this.grpProperties.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpProperties.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpProperties.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpProperties.ForeColor = global::System.Drawing.Color.White;
			this.grpProperties.Location = new global::System.Drawing.Point(14, 163);
			this.grpProperties.Name = "grpProperties";
			this.grpProperties.Size = new global::System.Drawing.Size(286, 281);
			this.grpProperties.TabIndex = 68;
			this.grpProperties.Text = "Properties";
			this.txtPropertiesCooldown.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesCooldown.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPropertiesCooldown.DefaultText = "";
			this.txtPropertiesCooldown.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesCooldown.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPropertiesCooldown.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesCooldown.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesCooldown.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPropertiesCooldown.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPropertiesCooldown.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPropertiesCooldown.ForeColor = global::System.Drawing.Color.White;
			this.txtPropertiesCooldown.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPropertiesCooldown.Location = new global::System.Drawing.Point(171, 60);
			this.txtPropertiesCooldown.MaxLength = 6;
			this.txtPropertiesCooldown.Name = "txtPropertiesCooldown";
			this.txtPropertiesCooldown.PasswordChar = '\0';
			this.txtPropertiesCooldown.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesCooldown.PlaceholderText = "";
			this.txtPropertiesCooldown.SelectedText = "";
			this.txtPropertiesCooldown.Size = new global::System.Drawing.Size(89, 30);
			this.txtPropertiesCooldown.TabIndex = 100;
			this.lblPropertiesCooldown.AutoSize = true;
			this.lblPropertiesCooldown.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPropertiesCooldown.ForeColor = global::System.Drawing.Color.White;
			this.lblPropertiesCooldown.Location = new global::System.Drawing.Point(22, 67);
			this.lblPropertiesCooldown.Name = "lblPropertiesCooldown";
			this.lblPropertiesCooldown.Size = new global::System.Drawing.Size(92, 15);
			this.lblPropertiesCooldown.TabIndex = 99;
			this.lblPropertiesCooldown.Text = "Cooldown (ms):";
			this.btnPropertiesTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnPropertiesTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPropertiesTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnPropertiesTooltip.BorderRadius = 4;
			this.btnPropertiesTooltip.BorderThickness = 1;
			this.btnPropertiesTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPropertiesTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnPropertiesTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnPropertiesTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPropertiesTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPropertiesTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPropertiesTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnPropertiesTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnPropertiesTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnPropertiesTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPropertiesTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnPropertiesTooltip.Location = new global::System.Drawing.Point(239, 8);
			this.btnPropertiesTooltip.Name = "btnPropertiesTooltip";
			this.btnPropertiesTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnPropertiesTooltip.TabIndex = 98;
			this.btnPropertiesTooltip.Click += new global::System.EventHandler(this.btnPropertiesTooltip_Click);
			this.guna2Separator1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator1.Location = new global::System.Drawing.Point(12, 213);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(262, 10);
			this.guna2Separator1.TabIndex = 97;
			this.checkCanCastWhileWalk.Animated = true;
			this.checkCanCastWhileWalk.AutoSize = true;
			this.checkCanCastWhileWalk.BackColor = global::System.Drawing.Color.Transparent;
			this.checkCanCastWhileWalk.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCanCastWhileWalk.CheckedState.BorderRadius = 0;
			this.checkCanCastWhileWalk.CheckedState.BorderThickness = 0;
			this.checkCanCastWhileWalk.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkCanCastWhileWalk.Location = new global::System.Drawing.Point(25, 242);
			this.checkCanCastWhileWalk.Name = "checkCanCastWhileWalk";
			this.checkCanCastWhileWalk.Size = new global::System.Drawing.Size(129, 19);
			this.checkCanCastWhileWalk.TabIndex = 72;
			this.checkCanCastWhileWalk.Text = "Can cast while walk";
			this.checkCanCastWhileWalk.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkCanCastWhileWalk.UncheckedState.BorderRadius = 0;
			this.checkCanCastWhileWalk.UncheckedState.BorderThickness = 1;
			this.checkCanCastWhileWalk.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkCanCastWhileWalk.UseVisualStyleBackColor = false;
			this.txtPropertiesPrio.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesPrio.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPropertiesPrio.DefaultText = "";
			this.txtPropertiesPrio.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesPrio.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPropertiesPrio.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesPrio.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesPrio.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPropertiesPrio.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPropertiesPrio.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPropertiesPrio.ForeColor = global::System.Drawing.Color.White;
			this.txtPropertiesPrio.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPropertiesPrio.Location = new global::System.Drawing.Point(171, 168);
			this.txtPropertiesPrio.MaxLength = 10;
			this.txtPropertiesPrio.Name = "txtPropertiesPrio";
			this.txtPropertiesPrio.PasswordChar = '\0';
			this.txtPropertiesPrio.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesPrio.PlaceholderText = "";
			this.txtPropertiesPrio.SelectedText = "";
			this.txtPropertiesPrio.Size = new global::System.Drawing.Size(89, 30);
			this.txtPropertiesPrio.TabIndex = 96;
			this.lblPropertiesRepetitions.AutoSize = true;
			this.lblPropertiesRepetitions.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPropertiesRepetitions.ForeColor = global::System.Drawing.Color.White;
			this.lblPropertiesRepetitions.Location = new global::System.Drawing.Point(22, 139);
			this.lblPropertiesRepetitions.Name = "lblPropertiesRepetitions";
			this.lblPropertiesRepetitions.Size = new global::System.Drawing.Size(99, 15);
			this.lblPropertiesRepetitions.TabIndex = 95;
			this.lblPropertiesRepetitions.Text = "Reps per combat:";
			this.txtPropertiesDifferentAuraID.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesDifferentAuraID.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPropertiesDifferentAuraID.DefaultText = "";
			this.txtPropertiesDifferentAuraID.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesDifferentAuraID.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPropertiesDifferentAuraID.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesDifferentAuraID.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesDifferentAuraID.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPropertiesDifferentAuraID.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPropertiesDifferentAuraID.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPropertiesDifferentAuraID.ForeColor = global::System.Drawing.Color.White;
			this.txtPropertiesDifferentAuraID.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPropertiesDifferentAuraID.Location = new global::System.Drawing.Point(171, 96);
			this.txtPropertiesDifferentAuraID.MaxLength = 10;
			this.txtPropertiesDifferentAuraID.Name = "txtPropertiesDifferentAuraID";
			this.txtPropertiesDifferentAuraID.PasswordChar = '\0';
			this.txtPropertiesDifferentAuraID.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesDifferentAuraID.PlaceholderText = "";
			this.txtPropertiesDifferentAuraID.SelectedText = "";
			this.txtPropertiesDifferentAuraID.Size = new global::System.Drawing.Size(89, 30);
			this.txtPropertiesDifferentAuraID.TabIndex = 94;
			this.lblPropertiesDifferentAuraID.AutoSize = true;
			this.lblPropertiesDifferentAuraID.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPropertiesDifferentAuraID.ForeColor = global::System.Drawing.Color.White;
			this.lblPropertiesDifferentAuraID.Location = new global::System.Drawing.Point(22, 103);
			this.lblPropertiesDifferentAuraID.Name = "lblPropertiesDifferentAuraID";
			this.lblPropertiesDifferentAuraID.Size = new global::System.Drawing.Size(98, 15);
			this.lblPropertiesDifferentAuraID.TabIndex = 71;
			this.lblPropertiesDifferentAuraID.Text = "Different Aura ID:";
			this.btnReset.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnReset.BorderColor = global::System.Drawing.Color.Gray;
			this.btnReset.BorderThickness = 1;
			this.btnReset.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnReset.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnReset.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnReset.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnReset.FillColor = global::System.Drawing.Color.SlateGray;
			this.btnReset.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnReset.ForeColor = global::System.Drawing.Color.White;
			this.btnReset.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnReset.Location = new global::System.Drawing.Point(14, 460);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new global::System.Drawing.Size(286, 30);
			this.btnReset.TabIndex = 69;
			this.btnReset.Text = "Reset";
			this.btnReset.Click += new global::System.EventHandler(this.btnReset_Click);
			this.grpInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpInfo.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfo.Controls.Add(this.lblInfoSpellNameData);
			this.grpInfo.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpInfo.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpInfo.ForeColor = global::System.Drawing.Color.White;
			this.grpInfo.Location = new global::System.Drawing.Point(14, 53);
			this.grpInfo.Name = "grpInfo";
			this.grpInfo.Size = new global::System.Drawing.Size(286, 95);
			this.grpInfo.TabIndex = 67;
			this.grpInfo.Text = "Info";
			this.lblInfoSpellNameData.AutoSize = true;
			this.lblInfoSpellNameData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoSpellNameData.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoSpellNameData.Location = new global::System.Drawing.Point(22, 60);
			this.lblInfoSpellNameData.Name = "lblInfoSpellNameData";
			this.lblInfoSpellNameData.Size = new global::System.Drawing.Size(94, 15);
			this.lblInfoSpellNameData.TabIndex = 71;
			this.lblInfoSpellNameData.Text = "[SpellName] (ID)";
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
			this.lblTitle1.Size = new global::System.Drawing.Size(129, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "Properties";
			this.panelBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox2.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox2.Controls.Add(this.tabs);
			this.panelBox2.Controls.Add(this.panelTitle2);
			this.panelBox2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox2.Location = new global::System.Drawing.Point(353, 74);
			this.panelBox2.Name = "panelBox2";
			this.panelBox2.Size = new global::System.Drawing.Size(622, 503);
			this.panelBox2.TabIndex = 70;
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabGeneral);
			this.tabs.Controls.Add(this.tabOptions);
			this.tabs.Controls.Add(this.tabMore);
			this.tabs.Controls.Add(this.tabMacro);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(140, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(596, 437);
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
			this.tabGeneral.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabGeneral.Controls.Add(this.panelTabGeneral);
			this.tabGeneral.ForeColor = global::System.Drawing.Color.White;
			this.tabGeneral.Location = new global::System.Drawing.Point(4, 44);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabGeneral.Size = new global::System.Drawing.Size(588, 389);
			this.tabGeneral.TabIndex = 0;
			this.tabGeneral.Text = "General";
			this.panelTabGeneral.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabGeneral.AutoScroll = true;
			this.panelTabGeneral.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabGeneral.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabGeneral.Controls.Add(this.grpItem);
			this.panelTabGeneral.Controls.Add(this.grpType);
			this.panelTabGeneral.Controls.Add(this.grpPowerType2);
			this.panelTabGeneral.Controls.Add(this.grpPowerType1);
			this.panelTabGeneral.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabGeneral.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabGeneral.Name = "panelTabGeneral";
			this.panelTabGeneral.Size = new global::System.Drawing.Size(588, 389);
			this.panelTabGeneral.TabIndex = 68;
			this.grpItem.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpItem.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpItem.Controls.Add(this.btnItemTooltip);
			this.grpItem.Controls.Add(this.selectItem);
			this.grpItem.Controls.Add(this.txtItemAmount);
			this.grpItem.Controls.Add(this.btnItemReload);
			this.grpItem.Controls.Add(this.txtItemValue);
			this.grpItem.Controls.Add(this.lblItemAmount);
			this.grpItem.Controls.Add(this.selectItemCompare);
			this.grpItem.Controls.Add(this.lblItemCompare);
			this.grpItem.Controls.Add(this.lblItem);
			this.grpItem.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpItem.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpItem.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpItem.ForeColor = global::System.Drawing.Color.White;
			this.grpItem.Location = new global::System.Drawing.Point(14, 535);
			this.grpItem.Name = "grpItem";
			this.grpItem.Size = new global::System.Drawing.Size(528, 183);
			this.grpItem.TabIndex = 67;
			this.grpItem.Text = "Item";
			this.btnItemTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnItemTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnItemTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnItemTooltip.BorderRadius = 4;
			this.btnItemTooltip.BorderThickness = 1;
			this.btnItemTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnItemTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnItemTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnItemTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnItemTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnItemTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnItemTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnItemTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnItemTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnItemTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnItemTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnItemTooltip.Location = new global::System.Drawing.Point(481, 8);
			this.btnItemTooltip.Name = "btnItemTooltip";
			this.btnItemTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnItemTooltip.TabIndex = 103;
			this.btnItemTooltip.Click += new global::System.EventHandler(this.btnItemTooltip_Click);
			this.selectItem.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectItem.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectItem.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectItem.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectItem.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectItem.ForeColor = global::System.Drawing.Color.White;
			this.selectItem.FormattingEnabled = true;
			this.selectItem.Location = new global::System.Drawing.Point(180, 60);
			this.selectItem.Name = "selectItem";
			this.selectItem.Size = new global::System.Drawing.Size(225, 29);
			this.selectItem.TabIndex = 102;
			this.txtItemAmount.BorderColor = global::System.Drawing.Color.Gray;
			this.txtItemAmount.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtItemAmount.DefaultText = "";
			this.txtItemAmount.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtItemAmount.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtItemAmount.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtItemAmount.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtItemAmount.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtItemAmount.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtItemAmount.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtItemAmount.ForeColor = global::System.Drawing.Color.White;
			this.txtItemAmount.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtItemAmount.Location = new global::System.Drawing.Point(180, 133);
			this.txtItemAmount.MaxLength = 3;
			this.txtItemAmount.Name = "txtItemAmount";
			this.txtItemAmount.PasswordChar = '\0';
			this.txtItemAmount.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtItemAmount.PlaceholderText = "";
			this.txtItemAmount.SelectedText = "";
			this.txtItemAmount.Size = new global::System.Drawing.Size(98, 30);
			this.txtItemAmount.TabIndex = 96;
			this.btnItemReload.BorderColor = global::System.Drawing.Color.Gray;
			this.btnItemReload.BorderThickness = 1;
			this.btnItemReload.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnItemReload.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnItemReload.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnItemReload.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnItemReload.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnItemReload.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnItemReload.ForeColor = global::System.Drawing.Color.White;
			this.btnItemReload.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnItemReload.Location = new global::System.Drawing.Point(420, 60);
			this.btnItemReload.Name = "btnItemReload";
			this.btnItemReload.Size = new global::System.Drawing.Size(98, 30);
			this.btnItemReload.TabIndex = 95;
			this.btnItemReload.Text = "Reload";
			this.btnItemReload.Click += new global::System.EventHandler(this.btnItemReload_Click);
			this.txtItemValue.BorderColor = global::System.Drawing.Color.Gray;
			this.txtItemValue.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtItemValue.DefaultText = "";
			this.txtItemValue.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtItemValue.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtItemValue.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtItemValue.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtItemValue.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtItemValue.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtItemValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtItemValue.ForeColor = global::System.Drawing.Color.White;
			this.txtItemValue.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtItemValue.Location = new global::System.Drawing.Point(420, 97);
			this.txtItemValue.MaxLength = 3;
			this.txtItemValue.Name = "txtItemValue";
			this.txtItemValue.PasswordChar = '\0';
			this.txtItemValue.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtItemValue.PlaceholderText = "";
			this.txtItemValue.SelectedText = "";
			this.txtItemValue.Size = new global::System.Drawing.Size(98, 30);
			this.txtItemValue.TabIndex = 94;
			this.lblItemAmount.AutoSize = true;
			this.lblItemAmount.BackColor = global::System.Drawing.Color.Transparent;
			this.lblItemAmount.ForeColor = global::System.Drawing.Color.White;
			this.lblItemAmount.Location = new global::System.Drawing.Point(22, 140);
			this.lblItemAmount.Name = "lblItemAmount";
			this.lblItemAmount.Size = new global::System.Drawing.Size(54, 15);
			this.lblItemAmount.TabIndex = 73;
			this.lblItemAmount.Text = "Amount:";
			this.selectItemCompare.BackColor = global::System.Drawing.Color.Transparent;
			this.selectItemCompare.BorderColor = global::System.Drawing.Color.Gray;
			this.selectItemCompare.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectItemCompare.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectItemCompare.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectItemCompare.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectItemCompare.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectItemCompare.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectItemCompare.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectItemCompare.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectItemCompare.ForeColor = global::System.Drawing.Color.White;
			this.selectItemCompare.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectItemCompare.ItemHeight = 24;
			this.selectItemCompare.Items.AddRange(new object[]
			{
				"Smaller or Equal",
				"Greater or Equal"
			});
			this.selectItemCompare.Location = new global::System.Drawing.Point(180, 97);
			this.selectItemCompare.Name = "selectItemCompare";
			this.selectItemCompare.Size = new global::System.Drawing.Size(225, 30);
			this.selectItemCompare.TabIndex = 72;
			this.lblItemCompare.AutoSize = true;
			this.lblItemCompare.BackColor = global::System.Drawing.Color.Transparent;
			this.lblItemCompare.ForeColor = global::System.Drawing.Color.White;
			this.lblItemCompare.Location = new global::System.Drawing.Point(22, 104);
			this.lblItemCompare.Name = "lblItemCompare";
			this.lblItemCompare.Size = new global::System.Drawing.Size(63, 15);
			this.lblItemCompare.TabIndex = 71;
			this.lblItemCompare.Text = "Condition:";
			this.lblItem.AutoSize = true;
			this.lblItem.BackColor = global::System.Drawing.Color.Transparent;
			this.lblItem.ForeColor = global::System.Drawing.Color.White;
			this.lblItem.Location = new global::System.Drawing.Point(22, 67);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new global::System.Drawing.Size(34, 15);
			this.lblItem.TabIndex = 14;
			this.lblItem.Text = "Item:";
			this.grpType.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpType.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpType.Controls.Add(this.btnTypeTooltip);
			this.grpType.Controls.Add(this.selectType);
			this.grpType.Controls.Add(this.lblType);
			this.grpType.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpType.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpType.ForeColor = global::System.Drawing.Color.White;
			this.grpType.Location = new global::System.Drawing.Point(14, 14);
			this.grpType.Name = "grpType";
			this.grpType.Size = new global::System.Drawing.Size(528, 110);
			this.grpType.TabIndex = 64;
			this.grpType.Text = "Type";
			this.btnTypeTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnTypeTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnTypeTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnTypeTooltip.BorderRadius = 4;
			this.btnTypeTooltip.BorderThickness = 1;
			this.btnTypeTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnTypeTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnTypeTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnTypeTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnTypeTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnTypeTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnTypeTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnTypeTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnTypeTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnTypeTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnTypeTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnTypeTooltip.Location = new global::System.Drawing.Point(481, 8);
			this.btnTypeTooltip.Name = "btnTypeTooltip";
			this.btnTypeTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnTypeTooltip.TabIndex = 99;
			this.btnTypeTooltip.Click += new global::System.EventHandler(this.btnTypeTooltip_Click);
			this.selectType.BackColor = global::System.Drawing.Color.Transparent;
			this.selectType.BorderColor = global::System.Drawing.Color.Gray;
			this.selectType.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectType.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectType.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectType.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectType.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectType.ForeColor = global::System.Drawing.Color.White;
			this.selectType.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectType.ItemHeight = 24;
			this.selectType.Items.AddRange(new object[]
			{
				"Combat",
				"Heal",
				"Food/Drink",
				"Buff/Aura",
				"Dispel",
				"Conjuring"
			});
			this.selectType.Location = new global::System.Drawing.Point(180, 60);
			this.selectType.Name = "selectType";
			this.selectType.Size = new global::System.Drawing.Size(225, 30);
			this.selectType.TabIndex = 70;
			this.selectType.SelectedIndexChanged += new global::System.EventHandler(this.selectType_SelectedIndexChanged);
			this.lblType.AutoSize = true;
			this.lblType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblType.ForeColor = global::System.Drawing.Color.White;
			this.lblType.Location = new global::System.Drawing.Point(22, 67);
			this.lblType.Name = "lblType";
			this.lblType.Size = new global::System.Drawing.Size(62, 15);
			this.lblType.TabIndex = 14;
			this.lblType.Text = "Spell Type:";
			this.grpPowerType2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpPowerType2.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpPowerType2.Controls.Add(this.btnPowerType2Tooltip);
			this.grpPowerType2.Controls.Add(this.txtPowerType2Value);
			this.grpPowerType2.Controls.Add(this.selectPowerType2Compare);
			this.grpPowerType2.Controls.Add(this.lblPowerType2Compare);
			this.grpPowerType2.Controls.Add(this.selectPowerType2);
			this.grpPowerType2.Controls.Add(this.lblPowerType2);
			this.grpPowerType2.Controls.Add(this.selectPowerType2Target);
			this.grpPowerType2.Controls.Add(this.lblPowerType2Subject);
			this.grpPowerType2.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpPowerType2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpPowerType2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpPowerType2.ForeColor = global::System.Drawing.Color.White;
			this.grpPowerType2.Location = new global::System.Drawing.Point(14, 337);
			this.grpPowerType2.Name = "grpPowerType2";
			this.grpPowerType2.Size = new global::System.Drawing.Size(528, 183);
			this.grpPowerType2.TabIndex = 66;
			this.grpPowerType2.Text = "Power Type #2";
			this.btnPowerType2Tooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnPowerType2Tooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType2Tooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnPowerType2Tooltip.BorderRadius = 4;
			this.btnPowerType2Tooltip.BorderThickness = 1;
			this.btnPowerType2Tooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPowerType2Tooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType2Tooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType2Tooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType2Tooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType2Tooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPowerType2Tooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnPowerType2Tooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnPowerType2Tooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnPowerType2Tooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPowerType2Tooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnPowerType2Tooltip.Location = new global::System.Drawing.Point(481, 8);
			this.btnPowerType2Tooltip.Name = "btnPowerType2Tooltip";
			this.btnPowerType2Tooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnPowerType2Tooltip.TabIndex = 100;
			this.btnPowerType2Tooltip.Click += new global::System.EventHandler(this.btnPowerType2Tooltip_Click);
			this.txtPowerType2Value.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPowerType2Value.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPowerType2Value.DefaultText = "";
			this.txtPowerType2Value.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPowerType2Value.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPowerType2Value.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPowerType2Value.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPowerType2Value.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPowerType2Value.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPowerType2Value.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPowerType2Value.ForeColor = global::System.Drawing.Color.White;
			this.txtPowerType2Value.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPowerType2Value.Location = new global::System.Drawing.Point(420, 133);
			this.txtPowerType2Value.MaxLength = 4;
			this.txtPowerType2Value.Name = "txtPowerType2Value";
			this.txtPowerType2Value.PasswordChar = '\0';
			this.txtPowerType2Value.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPowerType2Value.PlaceholderText = "";
			this.txtPowerType2Value.SelectedText = "";
			this.txtPowerType2Value.Size = new global::System.Drawing.Size(98, 30);
			this.txtPowerType2Value.TabIndex = 94;
			this.selectPowerType2Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPowerType2Compare.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPowerType2Compare.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPowerType2Compare.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPowerType2Compare.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPowerType2Compare.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPowerType2Compare.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPowerType2Compare.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType2Compare.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType2Compare.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPowerType2Compare.ForeColor = global::System.Drawing.Color.White;
			this.selectPowerType2Compare.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPowerType2Compare.ItemHeight = 24;
			this.selectPowerType2Compare.Items.AddRange(new object[]
			{
				"Smaller or Equal",
				"Greater or Equal"
			});
			this.selectPowerType2Compare.Location = new global::System.Drawing.Point(180, 133);
			this.selectPowerType2Compare.Name = "selectPowerType2Compare";
			this.selectPowerType2Compare.Size = new global::System.Drawing.Size(225, 30);
			this.selectPowerType2Compare.TabIndex = 74;
			this.lblPowerType2Compare.AutoSize = true;
			this.lblPowerType2Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPowerType2Compare.ForeColor = global::System.Drawing.Color.White;
			this.lblPowerType2Compare.Location = new global::System.Drawing.Point(22, 140);
			this.lblPowerType2Compare.Name = "lblPowerType2Compare";
			this.lblPowerType2Compare.Size = new global::System.Drawing.Size(63, 15);
			this.lblPowerType2Compare.TabIndex = 73;
			this.lblPowerType2Compare.Text = "Condition:";
			this.selectPowerType2.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPowerType2.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPowerType2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPowerType2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPowerType2.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPowerType2.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPowerType2.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPowerType2.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPowerType2.ForeColor = global::System.Drawing.Color.White;
			this.selectPowerType2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPowerType2.ItemHeight = 24;
			this.selectPowerType2.Items.AddRange(new object[]
			{
				"HEALTH (in Percent)",
				"HEALTH",
				"MANA (in Percent)",
				"MANA",
				"RAGE",
				"FOCUS",
				"ENERGY",
				"COMBO_POINTS",
				"HAPPINESS",
				"RUNES",
				"RUNIC_POWER",
				"SOUL_SHARDS",
				"HOLY_POWER",
				"STAGGER",
				"CHI",
				"FURY",
				"PAIN",
				"LUNAR_POWER",
				"INSANITY"
			});
			this.selectPowerType2.Location = new global::System.Drawing.Point(180, 97);
			this.selectPowerType2.Name = "selectPowerType2";
			this.selectPowerType2.Size = new global::System.Drawing.Size(225, 30);
			this.selectPowerType2.TabIndex = 72;
			this.lblPowerType2.AutoSize = true;
			this.lblPowerType2.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPowerType2.ForeColor = global::System.Drawing.Color.White;
			this.lblPowerType2.Location = new global::System.Drawing.Point(22, 104);
			this.lblPowerType2.Name = "lblPowerType2";
			this.lblPowerType2.Size = new global::System.Drawing.Size(70, 15);
			this.lblPowerType2.TabIndex = 71;
			this.lblPowerType2.Text = "Power Type:";
			this.selectPowerType2Target.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPowerType2Target.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPowerType2Target.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPowerType2Target.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPowerType2Target.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPowerType2Target.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPowerType2Target.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPowerType2Target.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType2Target.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType2Target.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPowerType2Target.ForeColor = global::System.Drawing.Color.White;
			this.selectPowerType2Target.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPowerType2Target.ItemHeight = 24;
			this.selectPowerType2Target.Items.AddRange(new object[]
			{
				"Player (Me)",
				"Target",
				"Pet"
			});
			this.selectPowerType2Target.Location = new global::System.Drawing.Point(180, 60);
			this.selectPowerType2Target.Name = "selectPowerType2Target";
			this.selectPowerType2Target.Size = new global::System.Drawing.Size(225, 30);
			this.selectPowerType2Target.TabIndex = 70;
			this.lblPowerType2Subject.AutoSize = true;
			this.lblPowerType2Subject.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPowerType2Subject.ForeColor = global::System.Drawing.Color.White;
			this.lblPowerType2Subject.Location = new global::System.Drawing.Point(22, 67);
			this.lblPowerType2Subject.Name = "lblPowerType2Subject";
			this.lblPowerType2Subject.Size = new global::System.Drawing.Size(49, 15);
			this.lblPowerType2Subject.TabIndex = 14;
			this.lblPowerType2Subject.Text = "Subject:";
			this.grpPowerType1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpPowerType1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpPowerType1.Controls.Add(this.btnPowerType1Tooltip);
			this.grpPowerType1.Controls.Add(this.txtPowerType1Value);
			this.grpPowerType1.Controls.Add(this.selectPowerType1Compare);
			this.grpPowerType1.Controls.Add(this.lblPowerType1Compare);
			this.grpPowerType1.Controls.Add(this.selectPowerType1);
			this.grpPowerType1.Controls.Add(this.lblPowerType1);
			this.grpPowerType1.Controls.Add(this.selectPowerType1Target);
			this.grpPowerType1.Controls.Add(this.lblPowerType1Subject);
			this.grpPowerType1.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpPowerType1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpPowerType1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpPowerType1.ForeColor = global::System.Drawing.Color.White;
			this.grpPowerType1.Location = new global::System.Drawing.Point(14, 139);
			this.grpPowerType1.Name = "grpPowerType1";
			this.grpPowerType1.Size = new global::System.Drawing.Size(528, 183);
			this.grpPowerType1.TabIndex = 65;
			this.grpPowerType1.Text = "Power Type #1";
			this.btnPowerType1Tooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnPowerType1Tooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType1Tooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnPowerType1Tooltip.BorderRadius = 4;
			this.btnPowerType1Tooltip.BorderThickness = 1;
			this.btnPowerType1Tooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPowerType1Tooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType1Tooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType1Tooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType1Tooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPowerType1Tooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPowerType1Tooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnPowerType1Tooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnPowerType1Tooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnPowerType1Tooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPowerType1Tooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnPowerType1Tooltip.Location = new global::System.Drawing.Point(481, 8);
			this.btnPowerType1Tooltip.Name = "btnPowerType1Tooltip";
			this.btnPowerType1Tooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnPowerType1Tooltip.TabIndex = 100;
			this.btnPowerType1Tooltip.Click += new global::System.EventHandler(this.btnPowerType1Tooltip_Click);
			this.txtPowerType1Value.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPowerType1Value.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPowerType1Value.DefaultText = "";
			this.txtPowerType1Value.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPowerType1Value.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPowerType1Value.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPowerType1Value.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPowerType1Value.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPowerType1Value.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPowerType1Value.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPowerType1Value.ForeColor = global::System.Drawing.Color.White;
			this.txtPowerType1Value.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPowerType1Value.Location = new global::System.Drawing.Point(420, 133);
			this.txtPowerType1Value.MaxLength = 4;
			this.txtPowerType1Value.Name = "txtPowerType1Value";
			this.txtPowerType1Value.PasswordChar = '\0';
			this.txtPowerType1Value.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPowerType1Value.PlaceholderText = "";
			this.txtPowerType1Value.SelectedText = "";
			this.txtPowerType1Value.Size = new global::System.Drawing.Size(98, 30);
			this.txtPowerType1Value.TabIndex = 94;
			this.selectPowerType1Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPowerType1Compare.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPowerType1Compare.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPowerType1Compare.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPowerType1Compare.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPowerType1Compare.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPowerType1Compare.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPowerType1Compare.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType1Compare.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType1Compare.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPowerType1Compare.ForeColor = global::System.Drawing.Color.White;
			this.selectPowerType1Compare.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPowerType1Compare.ItemHeight = 24;
			this.selectPowerType1Compare.Items.AddRange(new object[]
			{
				"Smaller or Equal",
				"Greater or Equal"
			});
			this.selectPowerType1Compare.Location = new global::System.Drawing.Point(180, 133);
			this.selectPowerType1Compare.Name = "selectPowerType1Compare";
			this.selectPowerType1Compare.Size = new global::System.Drawing.Size(225, 30);
			this.selectPowerType1Compare.TabIndex = 74;
			this.lblPowerType1Compare.AutoSize = true;
			this.lblPowerType1Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPowerType1Compare.ForeColor = global::System.Drawing.Color.White;
			this.lblPowerType1Compare.Location = new global::System.Drawing.Point(22, 140);
			this.lblPowerType1Compare.Name = "lblPowerType1Compare";
			this.lblPowerType1Compare.Size = new global::System.Drawing.Size(63, 15);
			this.lblPowerType1Compare.TabIndex = 73;
			this.lblPowerType1Compare.Text = "Condition:";
			this.selectPowerType1.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPowerType1.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPowerType1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPowerType1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPowerType1.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPowerType1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPowerType1.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPowerType1.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPowerType1.ForeColor = global::System.Drawing.Color.White;
			this.selectPowerType1.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPowerType1.ItemHeight = 24;
			this.selectPowerType1.Items.AddRange(new object[]
			{
				"HEALTH (in Percent)",
				"HEALTH",
				"MANA (in Percent)",
				"MANA",
				"RAGE",
				"FOCUS",
				"ENERGY",
				"COMBO_POINTS",
				"HAPPINESS",
				"RUNES",
				"RUNIC_POWER",
				"SOUL_SHARDS",
				"HOLY_POWER",
				"STAGGER",
				"CHI",
				"FURY",
				"PAIN",
				"LUNAR_POWER",
				"INSANITY"
			});
			this.selectPowerType1.Location = new global::System.Drawing.Point(180, 97);
			this.selectPowerType1.Name = "selectPowerType1";
			this.selectPowerType1.Size = new global::System.Drawing.Size(225, 30);
			this.selectPowerType1.TabIndex = 72;
			this.lblPowerType1.AutoSize = true;
			this.lblPowerType1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPowerType1.ForeColor = global::System.Drawing.Color.White;
			this.lblPowerType1.Location = new global::System.Drawing.Point(22, 104);
			this.lblPowerType1.Name = "lblPowerType1";
			this.lblPowerType1.Size = new global::System.Drawing.Size(70, 15);
			this.lblPowerType1.TabIndex = 71;
			this.lblPowerType1.Text = "Power Type:";
			this.selectPowerType1Target.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPowerType1Target.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPowerType1Target.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPowerType1Target.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPowerType1Target.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPowerType1Target.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPowerType1Target.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPowerType1Target.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType1Target.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPowerType1Target.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPowerType1Target.ForeColor = global::System.Drawing.Color.White;
			this.selectPowerType1Target.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPowerType1Target.ItemHeight = 24;
			this.selectPowerType1Target.Items.AddRange(new object[]
			{
				"Player (Me)",
				"Target",
				"Pet"
			});
			this.selectPowerType1Target.Location = new global::System.Drawing.Point(180, 60);
			this.selectPowerType1Target.Name = "selectPowerType1Target";
			this.selectPowerType1Target.Size = new global::System.Drawing.Size(225, 30);
			this.selectPowerType1Target.TabIndex = 70;
			this.lblPowerType1Subject.AutoSize = true;
			this.lblPowerType1Subject.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPowerType1Subject.ForeColor = global::System.Drawing.Color.White;
			this.lblPowerType1Subject.Location = new global::System.Drawing.Point(22, 67);
			this.lblPowerType1Subject.Name = "lblPowerType1Subject";
			this.lblPowerType1Subject.Size = new global::System.Drawing.Size(49, 15);
			this.lblPowerType1Subject.TabIndex = 14;
			this.lblPowerType1Subject.Text = "Subject:";
			this.tabOptions.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabOptions.Controls.Add(this.panelTabOptions);
			this.tabOptions.ForeColor = global::System.Drawing.Color.White;
			this.tabOptions.Location = new global::System.Drawing.Point(4, 44);
			this.tabOptions.Name = "tabOptions";
			this.tabOptions.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabOptions.Size = new global::System.Drawing.Size(588, 389);
			this.tabOptions.TabIndex = 1;
			this.tabOptions.Text = "Options";
			this.panelTabOptions.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabOptions.AutoScroll = true;
			this.panelTabOptions.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabOptions.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabOptions.Controls.Add(this.grpAddition1);
			this.panelTabOptions.Controls.Add(this.grpAddition4);
			this.panelTabOptions.Controls.Add(this.grpAddition2);
			this.panelTabOptions.Controls.Add(this.grpAddition3);
			this.panelTabOptions.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabOptions.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabOptions.Name = "panelTabOptions";
			this.panelTabOptions.Size = new global::System.Drawing.Size(588, 389);
			this.panelTabOptions.TabIndex = 70;
			this.grpAddition1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddition1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition1.Controls.Add(this.txtAddition1Value);
			this.grpAddition1.Controls.Add(this.selectAddition1Compare);
			this.grpAddition1.Controls.Add(this.lblAddition1Compare);
			this.grpAddition1.Controls.Add(this.selectAddition1Option);
			this.grpAddition1.Controls.Add(this.lblAddition1Option);
			this.grpAddition1.Controls.Add(this.selectAddition1Target);
			this.grpAddition1.Controls.Add(this.lblAddition1Target);
			this.grpAddition1.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddition1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddition1.ForeColor = global::System.Drawing.Color.White;
			this.grpAddition1.Location = new global::System.Drawing.Point(14, 14);
			this.grpAddition1.Name = "grpAddition1";
			this.grpAddition1.Size = new global::System.Drawing.Size(525, 183);
			this.grpAddition1.TabIndex = 66;
			this.grpAddition1.Text = "Addition #1";
			this.txtAddition1Value.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAddition1Value.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtAddition1Value.DefaultText = "";
			this.txtAddition1Value.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtAddition1Value.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtAddition1Value.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAddition1Value.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtAddition1Value.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtAddition1Value.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtAddition1Value.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtAddition1Value.ForeColor = global::System.Drawing.Color.White;
			this.txtAddition1Value.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtAddition1Value.Location = new global::System.Drawing.Point(420, 133);
			this.txtAddition1Value.MaxLength = 3;
			this.txtAddition1Value.Name = "txtAddition1Value";
			this.txtAddition1Value.PasswordChar = '\0';
			this.txtAddition1Value.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtAddition1Value.PlaceholderText = "";
			this.txtAddition1Value.SelectedText = "";
			this.txtAddition1Value.Size = new global::System.Drawing.Size(98, 30);
			this.txtAddition1Value.TabIndex = 94;
			this.selectAddition1Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAddition1Compare.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAddition1Compare.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAddition1Compare.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAddition1Compare.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAddition1Compare.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAddition1Compare.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAddition1Compare.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition1Compare.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition1Compare.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAddition1Compare.ForeColor = global::System.Drawing.Color.White;
			this.selectAddition1Compare.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAddition1Compare.ItemHeight = 24;
			this.selectAddition1Compare.Items.AddRange(new object[]
			{
				"Smaller or Equal",
				"Greater or Equal"
			});
			this.selectAddition1Compare.Location = new global::System.Drawing.Point(180, 133);
			this.selectAddition1Compare.Name = "selectAddition1Compare";
			this.selectAddition1Compare.Size = new global::System.Drawing.Size(225, 30);
			this.selectAddition1Compare.TabIndex = 74;
			this.lblAddition1Compare.AutoSize = true;
			this.lblAddition1Compare.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddition1Compare.ForeColor = global::System.Drawing.Color.White;
			this.lblAddition1Compare.Location = new global::System.Drawing.Point(22, 140);
			this.lblAddition1Compare.Name = "lblAddition1Compare";
			this.lblAddition1Compare.Size = new global::System.Drawing.Size(63, 15);
			this.lblAddition1Compare.TabIndex = 73;
			this.lblAddition1Compare.Text = "Condition:";
			this.selectAddition1Option.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAddition1Option.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAddition1Option.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAddition1Option.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAddition1Option.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAddition1Option.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAddition1Option.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAddition1Option.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition1Option.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition1Option.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAddition1Option.ForeColor = global::System.Drawing.Color.White;
			this.selectAddition1Option.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAddition1Option.ItemHeight = 24;
			this.selectAddition1Option.Items.AddRange(new object[]
			{
				"Range in Yards"
			});
			this.selectAddition1Option.Location = new global::System.Drawing.Point(180, 97);
			this.selectAddition1Option.Name = "selectAddition1Option";
			this.selectAddition1Option.Size = new global::System.Drawing.Size(225, 30);
			this.selectAddition1Option.TabIndex = 72;
			this.lblAddition1Option.AutoSize = true;
			this.lblAddition1Option.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddition1Option.ForeColor = global::System.Drawing.Color.White;
			this.lblAddition1Option.Location = new global::System.Drawing.Point(22, 104);
			this.lblAddition1Option.Name = "lblAddition1Option";
			this.lblAddition1Option.Size = new global::System.Drawing.Size(47, 15);
			this.lblAddition1Option.TabIndex = 71;
			this.lblAddition1Option.Text = "Option:";
			this.selectAddition1Target.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAddition1Target.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAddition1Target.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAddition1Target.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAddition1Target.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAddition1Target.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAddition1Target.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAddition1Target.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition1Target.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition1Target.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAddition1Target.ForeColor = global::System.Drawing.Color.White;
			this.selectAddition1Target.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAddition1Target.ItemHeight = 24;
			this.selectAddition1Target.Items.AddRange(new object[]
			{
				"Target",
				"Pet"
			});
			this.selectAddition1Target.Location = new global::System.Drawing.Point(180, 60);
			this.selectAddition1Target.Name = "selectAddition1Target";
			this.selectAddition1Target.Size = new global::System.Drawing.Size(225, 30);
			this.selectAddition1Target.TabIndex = 70;
			this.lblAddition1Target.AutoSize = true;
			this.lblAddition1Target.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddition1Target.ForeColor = global::System.Drawing.Color.White;
			this.lblAddition1Target.Location = new global::System.Drawing.Point(22, 67);
			this.lblAddition1Target.Name = "lblAddition1Target";
			this.lblAddition1Target.Size = new global::System.Drawing.Size(49, 15);
			this.lblAddition1Target.TabIndex = 14;
			this.lblAddition1Target.Text = "Subject:";
			this.grpAddition4.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddition4.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition4.Controls.Add(this.checkAddition4AlwaysActiveOutOfCombat);
			this.grpAddition4.Controls.Add(this.checkAddition4AlwaysActiveCombatWay);
			this.grpAddition4.Controls.Add(this.checkAddition4AlwaysActiveCombat);
			this.grpAddition4.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition4.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddition4.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddition4.ForeColor = global::System.Drawing.Color.White;
			this.grpAddition4.Location = new global::System.Drawing.Point(14, 593);
			this.grpAddition4.Name = "grpAddition4";
			this.grpAddition4.Size = new global::System.Drawing.Size(525, 146);
			this.grpAddition4.TabIndex = 69;
			this.grpAddition4.Text = "Addition #4";
			this.checkAddition4AlwaysActiveOutOfCombat.Animated = true;
			this.checkAddition4AlwaysActiveOutOfCombat.AutoSize = true;
			this.checkAddition4AlwaysActiveOutOfCombat.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddition4AlwaysActiveOutOfCombat.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition4AlwaysActiveOutOfCombat.CheckedState.BorderRadius = 0;
			this.checkAddition4AlwaysActiveOutOfCombat.CheckedState.BorderThickness = 0;
			this.checkAddition4AlwaysActiveOutOfCombat.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition4AlwaysActiveOutOfCombat.Location = new global::System.Drawing.Point(22, 110);
			this.checkAddition4AlwaysActiveOutOfCombat.Name = "checkAddition4AlwaysActiveOutOfCombat";
			this.checkAddition4AlwaysActiveOutOfCombat.Size = new global::System.Drawing.Size(207, 19);
			this.checkAddition4AlwaysActiveOutOfCombat.TabIndex = 97;
			this.checkAddition4AlwaysActiveOutOfCombat.Text = "Always active while out of combat";
			this.checkAddition4AlwaysActiveOutOfCombat.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddition4AlwaysActiveOutOfCombat.UncheckedState.BorderRadius = 0;
			this.checkAddition4AlwaysActiveOutOfCombat.UncheckedState.BorderThickness = 1;
			this.checkAddition4AlwaysActiveOutOfCombat.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddition4AlwaysActiveOutOfCombat.UseVisualStyleBackColor = false;
			this.checkAddition4AlwaysActiveCombatWay.Animated = true;
			this.checkAddition4AlwaysActiveCombatWay.AutoSize = true;
			this.checkAddition4AlwaysActiveCombatWay.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddition4AlwaysActiveCombatWay.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition4AlwaysActiveCombatWay.CheckedState.BorderRadius = 0;
			this.checkAddition4AlwaysActiveCombatWay.CheckedState.BorderThickness = 0;
			this.checkAddition4AlwaysActiveCombatWay.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition4AlwaysActiveCombatWay.Location = new global::System.Drawing.Point(22, 85);
			this.checkAddition4AlwaysActiveCombatWay.Name = "checkAddition4AlwaysActiveCombatWay";
			this.checkAddition4AlwaysActiveCombatWay.Size = new global::System.Drawing.Size(247, 19);
			this.checkAddition4AlwaysActiveCombatWay.TabIndex = 96;
			this.checkAddition4AlwaysActiveCombatWay.Text = "Always active while on the way to combat";
			this.checkAddition4AlwaysActiveCombatWay.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddition4AlwaysActiveCombatWay.UncheckedState.BorderRadius = 0;
			this.checkAddition4AlwaysActiveCombatWay.UncheckedState.BorderThickness = 1;
			this.checkAddition4AlwaysActiveCombatWay.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddition4AlwaysActiveCombatWay.UseVisualStyleBackColor = false;
			this.checkAddition4AlwaysActiveCombat.Animated = true;
			this.checkAddition4AlwaysActiveCombat.AutoSize = true;
			this.checkAddition4AlwaysActiveCombat.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddition4AlwaysActiveCombat.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition4AlwaysActiveCombat.CheckedState.BorderRadius = 0;
			this.checkAddition4AlwaysActiveCombat.CheckedState.BorderThickness = 0;
			this.checkAddition4AlwaysActiveCombat.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition4AlwaysActiveCombat.Location = new global::System.Drawing.Point(22, 60);
			this.checkAddition4AlwaysActiveCombat.Name = "checkAddition4AlwaysActiveCombat";
			this.checkAddition4AlwaysActiveCombat.Size = new global::System.Drawing.Size(185, 19);
			this.checkAddition4AlwaysActiveCombat.TabIndex = 95;
			this.checkAddition4AlwaysActiveCombat.Text = "Always active while in combat";
			this.checkAddition4AlwaysActiveCombat.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddition4AlwaysActiveCombat.UncheckedState.BorderRadius = 0;
			this.checkAddition4AlwaysActiveCombat.UncheckedState.BorderThickness = 1;
			this.checkAddition4AlwaysActiveCombat.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddition4AlwaysActiveCombat.UseVisualStyleBackColor = false;
			this.grpAddition2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddition2.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition2.Controls.Add(this.checkAddition2DoNotRecastIfActive);
			this.grpAddition2.Controls.Add(this.selectAddition2DoNotRecastIfActiveTarget);
			this.grpAddition2.Controls.Add(this.lblAddition2DoNotRecastIfActiveTarget);
			this.grpAddition2.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddition2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddition2.ForeColor = global::System.Drawing.Color.White;
			this.grpAddition2.Location = new global::System.Drawing.Point(14, 212);
			this.grpAddition2.Name = "grpAddition2";
			this.grpAddition2.Size = new global::System.Drawing.Size(525, 140);
			this.grpAddition2.TabIndex = 67;
			this.grpAddition2.Text = "Addition #2";
			this.checkAddition2DoNotRecastIfActive.Animated = true;
			this.checkAddition2DoNotRecastIfActive.AutoSize = true;
			this.checkAddition2DoNotRecastIfActive.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddition2DoNotRecastIfActive.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition2DoNotRecastIfActive.CheckedState.BorderRadius = 0;
			this.checkAddition2DoNotRecastIfActive.CheckedState.BorderThickness = 0;
			this.checkAddition2DoNotRecastIfActive.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition2DoNotRecastIfActive.Location = new global::System.Drawing.Point(180, 60);
			this.checkAddition2DoNotRecastIfActive.Name = "checkAddition2DoNotRecastIfActive";
			this.checkAddition2DoNotRecastIfActive.Size = new global::System.Drawing.Size(160, 19);
			this.checkAddition2DoNotRecastIfActive.TabIndex = 95;
			this.checkAddition2DoNotRecastIfActive.Text = "Do not recast if active on:";
			this.checkAddition2DoNotRecastIfActive.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddition2DoNotRecastIfActive.UncheckedState.BorderRadius = 0;
			this.checkAddition2DoNotRecastIfActive.UncheckedState.BorderThickness = 1;
			this.checkAddition2DoNotRecastIfActive.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddition2DoNotRecastIfActive.UseVisualStyleBackColor = false;
			this.selectAddition2DoNotRecastIfActiveTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAddition2DoNotRecastIfActiveTarget.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAddition2DoNotRecastIfActiveTarget.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAddition2DoNotRecastIfActiveTarget.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAddition2DoNotRecastIfActiveTarget.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAddition2DoNotRecastIfActiveTarget.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAddition2DoNotRecastIfActiveTarget.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAddition2DoNotRecastIfActiveTarget.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition2DoNotRecastIfActiveTarget.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition2DoNotRecastIfActiveTarget.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAddition2DoNotRecastIfActiveTarget.ForeColor = global::System.Drawing.Color.White;
			this.selectAddition2DoNotRecastIfActiveTarget.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAddition2DoNotRecastIfActiveTarget.ItemHeight = 24;
			this.selectAddition2DoNotRecastIfActiveTarget.Items.AddRange(new object[]
			{
				"Player (Me)",
				"Target",
				"Pet"
			});
			this.selectAddition2DoNotRecastIfActiveTarget.Location = new global::System.Drawing.Point(180, 89);
			this.selectAddition2DoNotRecastIfActiveTarget.Name = "selectAddition2DoNotRecastIfActiveTarget";
			this.selectAddition2DoNotRecastIfActiveTarget.Size = new global::System.Drawing.Size(225, 30);
			this.selectAddition2DoNotRecastIfActiveTarget.TabIndex = 72;
			this.lblAddition2DoNotRecastIfActiveTarget.AutoSize = true;
			this.lblAddition2DoNotRecastIfActiveTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddition2DoNotRecastIfActiveTarget.ForeColor = global::System.Drawing.Color.White;
			this.lblAddition2DoNotRecastIfActiveTarget.Location = new global::System.Drawing.Point(22, 96);
			this.lblAddition2DoNotRecastIfActiveTarget.Name = "lblAddition2DoNotRecastIfActiveTarget";
			this.lblAddition2DoNotRecastIfActiveTarget.Size = new global::System.Drawing.Size(49, 15);
			this.lblAddition2DoNotRecastIfActiveTarget.TabIndex = 71;
			this.lblAddition2DoNotRecastIfActiveTarget.Text = "Subject:";
			this.grpAddition3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAddition3.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition3.Controls.Add(this.lblAddition3CastIfActiveOn);
			this.grpAddition3.Controls.Add(this.btnAddition3CastIfActiveSpelllist);
			this.grpAddition3.Controls.Add(this.selectAddition3CastIfActiveTarget);
			this.grpAddition3.Controls.Add(this.lblAddition3CastIfActiveTarget);
			this.grpAddition3.Controls.Add(this.checkAddition3CastIfActive);
			this.grpAddition3.Controls.Add(this.lblAddition3CastIfActiveSpelllist);
			this.grpAddition3.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAddition3.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAddition3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAddition3.ForeColor = global::System.Drawing.Color.White;
			this.grpAddition3.Location = new global::System.Drawing.Point(14, 367);
			this.grpAddition3.Name = "grpAddition3";
			this.grpAddition3.Size = new global::System.Drawing.Size(525, 211);
			this.grpAddition3.TabIndex = 68;
			this.grpAddition3.Text = "Addition #3";
			this.lblAddition3CastIfActiveOn.AutoSize = true;
			this.lblAddition3CastIfActiveOn.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddition3CastIfActiveOn.ForeColor = global::System.Drawing.Color.White;
			this.lblAddition3CastIfActiveOn.Location = new global::System.Drawing.Point(177, 132);
			this.lblAddition3CastIfActiveOn.Name = "lblAddition3CastIfActiveOn";
			this.lblAddition3CastIfActiveOn.Size = new global::System.Drawing.Size(98, 15);
			this.lblAddition3CastIfActiveOn.TabIndex = 99;
			this.lblAddition3CastIfActiveOn.Text = "... are active on ...";
			this.btnAddition3CastIfActiveSpelllist.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAddition3CastIfActiveSpelllist.BorderThickness = 1;
			this.btnAddition3CastIfActiveSpelllist.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddition3CastIfActiveSpelllist.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAddition3CastIfActiveSpelllist.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAddition3CastIfActiveSpelllist.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddition3CastIfActiveSpelllist.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAddition3CastIfActiveSpelllist.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnAddition3CastIfActiveSpelllist.ForeColor = global::System.Drawing.Color.White;
			this.btnAddition3CastIfActiveSpelllist.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAddition3CastIfActiveSpelllist.Location = new global::System.Drawing.Point(180, 89);
			this.btnAddition3CastIfActiveSpelllist.Name = "btnAddition3CastIfActiveSpelllist";
			this.btnAddition3CastIfActiveSpelllist.Size = new global::System.Drawing.Size(225, 30);
			this.btnAddition3CastIfActiveSpelllist.TabIndex = 98;
			this.btnAddition3CastIfActiveSpelllist.Text = "Spelllist";
			this.btnAddition3CastIfActiveSpelllist.Click += new global::System.EventHandler(this.btnAddition3CastIfActiveSpelllist_Click);
			this.selectAddition3CastIfActiveTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.selectAddition3CastIfActiveTarget.BorderColor = global::System.Drawing.Color.Gray;
			this.selectAddition3CastIfActiveTarget.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectAddition3CastIfActiveTarget.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectAddition3CastIfActiveTarget.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectAddition3CastIfActiveTarget.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectAddition3CastIfActiveTarget.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectAddition3CastIfActiveTarget.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition3CastIfActiveTarget.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectAddition3CastIfActiveTarget.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectAddition3CastIfActiveTarget.ForeColor = global::System.Drawing.Color.White;
			this.selectAddition3CastIfActiveTarget.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectAddition3CastIfActiveTarget.ItemHeight = 24;
			this.selectAddition3CastIfActiveTarget.Items.AddRange(new object[]
			{
				"Player (Me)",
				"Target",
				"Pet"
			});
			this.selectAddition3CastIfActiveTarget.Location = new global::System.Drawing.Point(180, 161);
			this.selectAddition3CastIfActiveTarget.Name = "selectAddition3CastIfActiveTarget";
			this.selectAddition3CastIfActiveTarget.Size = new global::System.Drawing.Size(225, 30);
			this.selectAddition3CastIfActiveTarget.TabIndex = 97;
			this.lblAddition3CastIfActiveTarget.AutoSize = true;
			this.lblAddition3CastIfActiveTarget.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddition3CastIfActiveTarget.ForeColor = global::System.Drawing.Color.White;
			this.lblAddition3CastIfActiveTarget.Location = new global::System.Drawing.Point(22, 168);
			this.lblAddition3CastIfActiveTarget.Name = "lblAddition3CastIfActiveTarget";
			this.lblAddition3CastIfActiveTarget.Size = new global::System.Drawing.Size(49, 15);
			this.lblAddition3CastIfActiveTarget.TabIndex = 96;
			this.lblAddition3CastIfActiveTarget.Text = "Subject:";
			this.checkAddition3CastIfActive.Animated = true;
			this.checkAddition3CastIfActive.AutoSize = true;
			this.checkAddition3CastIfActive.BackColor = global::System.Drawing.Color.Transparent;
			this.checkAddition3CastIfActive.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition3CastIfActive.CheckedState.BorderRadius = 0;
			this.checkAddition3CastIfActive.CheckedState.BorderThickness = 0;
			this.checkAddition3CastIfActive.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkAddition3CastIfActive.Location = new global::System.Drawing.Point(180, 60);
			this.checkAddition3CastIfActive.Name = "checkAddition3CastIfActive";
			this.checkAddition3CastIfActive.Size = new global::System.Drawing.Size(152, 19);
			this.checkAddition3CastIfActive.TabIndex = 95;
			this.checkAddition3CastIfActive.Text = "Cast when Spells/Auras:";
			this.checkAddition3CastIfActive.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkAddition3CastIfActive.UncheckedState.BorderRadius = 0;
			this.checkAddition3CastIfActive.UncheckedState.BorderThickness = 1;
			this.checkAddition3CastIfActive.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkAddition3CastIfActive.UseVisualStyleBackColor = false;
			this.lblAddition3CastIfActiveSpelllist.AutoSize = true;
			this.lblAddition3CastIfActiveSpelllist.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAddition3CastIfActiveSpelllist.ForeColor = global::System.Drawing.Color.White;
			this.lblAddition3CastIfActiveSpelllist.Location = new global::System.Drawing.Point(22, 96);
			this.lblAddition3CastIfActiveSpelllist.Name = "lblAddition3CastIfActiveSpelllist";
			this.lblAddition3CastIfActiveSpelllist.Size = new global::System.Drawing.Size(50, 15);
			this.lblAddition3CastIfActiveSpelllist.TabIndex = 71;
			this.lblAddition3CastIfActiveSpelllist.Text = "Spelllist:";
			this.tabMore.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabMore.Controls.Add(this.panelTabMore);
			this.tabMore.ForeColor = global::System.Drawing.Color.White;
			this.tabMore.Location = new global::System.Drawing.Point(4, 44);
			this.tabMore.Name = "tabMore";
			this.tabMore.Size = new global::System.Drawing.Size(588, 389);
			this.tabMore.TabIndex = 2;
			this.tabMore.Text = "More";
			this.panelTabMore.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabMore.AutoScroll = true;
			this.panelTabMore.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabMore.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabMore.Controls.Add(this.grpMisc);
			this.panelTabMore.Controls.Add(this.grpMultipleAttackers);
			this.panelTabMore.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabMore.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabMore.Name = "panelTabMore";
			this.panelTabMore.Size = new global::System.Drawing.Size(588, 389);
			this.panelTabMore.TabIndex = 69;
			this.grpMisc.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpMisc.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMisc.Controls.Add(this.checkMiscTargetIsCasting);
			this.grpMisc.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMisc.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpMisc.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpMisc.ForeColor = global::System.Drawing.Color.White;
			this.grpMisc.Location = new global::System.Drawing.Point(14, 244);
			this.grpMisc.Name = "grpMisc";
			this.grpMisc.Size = new global::System.Drawing.Size(560, 96);
			this.grpMisc.TabIndex = 68;
			this.grpMisc.Text = "Misc.";
			this.checkMiscTargetIsCasting.Animated = true;
			this.checkMiscTargetIsCasting.AutoSize = true;
			this.checkMiscTargetIsCasting.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMiscTargetIsCasting.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMiscTargetIsCasting.CheckedState.BorderRadius = 0;
			this.checkMiscTargetIsCasting.CheckedState.BorderThickness = 0;
			this.checkMiscTargetIsCasting.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMiscTargetIsCasting.Location = new global::System.Drawing.Point(22, 60);
			this.checkMiscTargetIsCasting.Name = "checkMiscTargetIsCasting";
			this.checkMiscTargetIsCasting.Size = new global::System.Drawing.Size(189, 19);
			this.checkMiscTargetIsCasting.TabIndex = 99;
			this.checkMiscTargetIsCasting.Text = "Use only when target is casting";
			this.checkMiscTargetIsCasting.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMiscTargetIsCasting.UncheckedState.BorderRadius = 0;
			this.checkMiscTargetIsCasting.UncheckedState.BorderThickness = 1;
			this.checkMiscTargetIsCasting.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMiscTargetIsCasting.UseVisualStyleBackColor = false;
			this.grpMultipleAttackers.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpMultipleAttackers.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMultipleAttackers.Controls.Add(this.lblMultipleAttackers);
			this.grpMultipleAttackers.Controls.Add(this.guna2Separator2);
			this.grpMultipleAttackers.Controls.Add(this.checkMultipleAttackersStepBack);
			this.grpMultipleAttackers.Controls.Add(this.lblMultipleAttackersYards);
			this.grpMultipleAttackers.Controls.Add(this.lblMultipleAttackersWithin);
			this.grpMultipleAttackers.Controls.Add(this.txtMultipleAttackersDistance);
			this.grpMultipleAttackers.Controls.Add(this.txtMultipleAttackersValue);
			this.grpMultipleAttackers.Controls.Add(this.selectMultipleAttackersCompare);
			this.grpMultipleAttackers.Controls.Add(this.lblMultipleAttackersCompare);
			this.grpMultipleAttackers.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMultipleAttackers.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpMultipleAttackers.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpMultipleAttackers.ForeColor = global::System.Drawing.Color.White;
			this.grpMultipleAttackers.Location = new global::System.Drawing.Point(14, 14);
			this.grpMultipleAttackers.Name = "grpMultipleAttackers";
			this.grpMultipleAttackers.Size = new global::System.Drawing.Size(560, 215);
			this.grpMultipleAttackers.TabIndex = 67;
			this.grpMultipleAttackers.Text = "Multiple Attackers";
			this.lblMultipleAttackers.AutoSize = true;
			this.lblMultipleAttackers.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMultipleAttackers.ForeColor = global::System.Drawing.Color.White;
			this.lblMultipleAttackers.Location = new global::System.Drawing.Point(22, 104);
			this.lblMultipleAttackers.Name = "lblMultipleAttackers";
			this.lblMultipleAttackers.Size = new global::System.Drawing.Size(59, 15);
			this.lblMultipleAttackers.TabIndex = 100;
			this.lblMultipleAttackers.Text = "Attackers:";
			this.guna2Separator2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator2.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator2.Location = new global::System.Drawing.Point(15, 146);
			this.guna2Separator2.Name = "guna2Separator2";
			this.guna2Separator2.Size = new global::System.Drawing.Size(530, 10);
			this.guna2Separator2.TabIndex = 99;
			this.checkMultipleAttackersStepBack.Animated = true;
			this.checkMultipleAttackersStepBack.AutoSize = true;
			this.checkMultipleAttackersStepBack.BackColor = global::System.Drawing.Color.Transparent;
			this.checkMultipleAttackersStepBack.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMultipleAttackersStepBack.CheckedState.BorderRadius = 0;
			this.checkMultipleAttackersStepBack.CheckedState.BorderThickness = 0;
			this.checkMultipleAttackersStepBack.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkMultipleAttackersStepBack.Location = new global::System.Drawing.Point(180, 175);
			this.checkMultipleAttackersStepBack.Name = "checkMultipleAttackersStepBack";
			this.checkMultipleAttackersStepBack.Size = new global::System.Drawing.Size(159, 19);
			this.checkMultipleAttackersStepBack.TabIndex = 98;
			this.checkMultipleAttackersStepBack.Text = "Step back after execution";
			this.checkMultipleAttackersStepBack.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkMultipleAttackersStepBack.UncheckedState.BorderRadius = 0;
			this.checkMultipleAttackersStepBack.UncheckedState.BorderThickness = 1;
			this.checkMultipleAttackersStepBack.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkMultipleAttackersStepBack.UseVisualStyleBackColor = false;
			this.lblMultipleAttackersYards.AutoSize = true;
			this.lblMultipleAttackersYards.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMultipleAttackersYards.ForeColor = global::System.Drawing.Color.White;
			this.lblMultipleAttackersYards.Location = new global::System.Drawing.Point(420, 104);
			this.lblMultipleAttackersYards.Name = "lblMultipleAttackersYards";
			this.lblMultipleAttackersYards.Size = new global::System.Drawing.Size(28, 15);
			this.lblMultipleAttackersYards.TabIndex = 97;
			this.lblMultipleAttackersYards.Text = "yds.";
			this.lblMultipleAttackersWithin.AutoSize = true;
			this.lblMultipleAttackersWithin.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMultipleAttackersWithin.ForeColor = global::System.Drawing.Color.White;
			this.lblMultipleAttackersWithin.Location = new global::System.Drawing.Point(273, 104);
			this.lblMultipleAttackersWithin.Name = "lblMultipleAttackersWithin";
			this.lblMultipleAttackersWithin.Size = new global::System.Drawing.Size(40, 15);
			this.lblMultipleAttackersWithin.TabIndex = 96;
			this.lblMultipleAttackersWithin.Text = "within";
			this.txtMultipleAttackersDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMultipleAttackersDistance.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMultipleAttackersDistance.DefaultText = "";
			this.txtMultipleAttackersDistance.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMultipleAttackersDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtMultipleAttackersDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMultipleAttackersDistance.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMultipleAttackersDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtMultipleAttackersDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtMultipleAttackersDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMultipleAttackersDistance.ForeColor = global::System.Drawing.Color.White;
			this.txtMultipleAttackersDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtMultipleAttackersDistance.Location = new global::System.Drawing.Point(330, 97);
			this.txtMultipleAttackersDistance.MaxLength = 3;
			this.txtMultipleAttackersDistance.Name = "txtMultipleAttackersDistance";
			this.txtMultipleAttackersDistance.PasswordChar = '\0';
			this.txtMultipleAttackersDistance.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtMultipleAttackersDistance.PlaceholderText = "";
			this.txtMultipleAttackersDistance.SelectedText = "";
			this.txtMultipleAttackersDistance.Size = new global::System.Drawing.Size(75, 30);
			this.txtMultipleAttackersDistance.TabIndex = 95;
			this.txtMultipleAttackersValue.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMultipleAttackersValue.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMultipleAttackersValue.DefaultText = "";
			this.txtMultipleAttackersValue.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMultipleAttackersValue.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtMultipleAttackersValue.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMultipleAttackersValue.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMultipleAttackersValue.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtMultipleAttackersValue.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtMultipleAttackersValue.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMultipleAttackersValue.ForeColor = global::System.Drawing.Color.White;
			this.txtMultipleAttackersValue.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtMultipleAttackersValue.Location = new global::System.Drawing.Point(180, 97);
			this.txtMultipleAttackersValue.MaxLength = 3;
			this.txtMultipleAttackersValue.Name = "txtMultipleAttackersValue";
			this.txtMultipleAttackersValue.PasswordChar = '\0';
			this.txtMultipleAttackersValue.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtMultipleAttackersValue.PlaceholderText = "";
			this.txtMultipleAttackersValue.SelectedText = "";
			this.txtMultipleAttackersValue.Size = new global::System.Drawing.Size(75, 30);
			this.txtMultipleAttackersValue.TabIndex = 94;
			this.selectMultipleAttackersCompare.BackColor = global::System.Drawing.Color.Transparent;
			this.selectMultipleAttackersCompare.BorderColor = global::System.Drawing.Color.Gray;
			this.selectMultipleAttackersCompare.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectMultipleAttackersCompare.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectMultipleAttackersCompare.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectMultipleAttackersCompare.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectMultipleAttackersCompare.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectMultipleAttackersCompare.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectMultipleAttackersCompare.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectMultipleAttackersCompare.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectMultipleAttackersCompare.ForeColor = global::System.Drawing.Color.White;
			this.selectMultipleAttackersCompare.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectMultipleAttackersCompare.ItemHeight = 24;
			this.selectMultipleAttackersCompare.Items.AddRange(new object[]
			{
				"Smaller or Equal",
				"Equal",
				"Greater or Equal"
			});
			this.selectMultipleAttackersCompare.Location = new global::System.Drawing.Point(180, 60);
			this.selectMultipleAttackersCompare.Name = "selectMultipleAttackersCompare";
			this.selectMultipleAttackersCompare.Size = new global::System.Drawing.Size(225, 30);
			this.selectMultipleAttackersCompare.TabIndex = 70;
			this.lblMultipleAttackersCompare.AutoSize = true;
			this.lblMultipleAttackersCompare.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMultipleAttackersCompare.ForeColor = global::System.Drawing.Color.White;
			this.lblMultipleAttackersCompare.Location = new global::System.Drawing.Point(22, 67);
			this.lblMultipleAttackersCompare.Name = "lblMultipleAttackersCompare";
			this.lblMultipleAttackersCompare.Size = new global::System.Drawing.Size(63, 15);
			this.lblMultipleAttackersCompare.TabIndex = 14;
			this.lblMultipleAttackersCompare.Text = "Condition:";
			this.tabMacro.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabMacro.Controls.Add(this.panelTabMacro);
			this.tabMacro.Location = new global::System.Drawing.Point(4, 44);
			this.tabMacro.Name = "tabMacro";
			this.tabMacro.Size = new global::System.Drawing.Size(588, 389);
			this.tabMacro.TabIndex = 3;
			this.tabMacro.Text = "Macro";
			this.panelTabMacro.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabMacro.AutoScroll = true;
			this.panelTabMacro.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabMacro.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabMacro.Controls.Add(this.grpMacro);
			this.panelTabMacro.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabMacro.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabMacro.Name = "panelTabMacro";
			this.panelTabMacro.Size = new global::System.Drawing.Size(588, 389);
			this.panelTabMacro.TabIndex = 70;
			this.grpMacro.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpMacro.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMacro.Controls.Add(this.selectMacroSlot);
			this.grpMacro.Controls.Add(this.lblMacroSlot);
			this.grpMacro.Controls.Add(this.selectMacroBar);
			this.grpMacro.Controls.Add(this.lblMacroBar);
			this.grpMacro.Controls.Add(this.txtMacroName);
			this.grpMacro.Controls.Add(this.lblMacroName);
			this.grpMacro.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpMacro.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpMacro.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpMacro.ForeColor = global::System.Drawing.Color.White;
			this.grpMacro.Location = new global::System.Drawing.Point(14, 14);
			this.grpMacro.Name = "grpMacro";
			this.grpMacro.Size = new global::System.Drawing.Size(560, 182);
			this.grpMacro.TabIndex = 67;
			this.grpMacro.Text = "Macro";
			this.selectMacroSlot.BackColor = global::System.Drawing.Color.Transparent;
			this.selectMacroSlot.BorderColor = global::System.Drawing.Color.Gray;
			this.selectMacroSlot.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectMacroSlot.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectMacroSlot.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectMacroSlot.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectMacroSlot.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectMacroSlot.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectMacroSlot.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectMacroSlot.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectMacroSlot.ForeColor = global::System.Drawing.Color.White;
			this.selectMacroSlot.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectMacroSlot.ItemHeight = 24;
			this.selectMacroSlot.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12"
			});
			this.selectMacroSlot.Location = new global::System.Drawing.Point(180, 132);
			this.selectMacroSlot.Name = "selectMacroSlot";
			this.selectMacroSlot.Size = new global::System.Drawing.Size(98, 30);
			this.selectMacroSlot.StartIndex = 0;
			this.selectMacroSlot.TabIndex = 98;
			this.lblMacroSlot.AutoSize = true;
			this.lblMacroSlot.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMacroSlot.ForeColor = global::System.Drawing.Color.White;
			this.lblMacroSlot.Location = new global::System.Drawing.Point(22, 141);
			this.lblMacroSlot.Name = "lblMacroSlot";
			this.lblMacroSlot.Size = new global::System.Drawing.Size(30, 15);
			this.lblMacroSlot.TabIndex = 97;
			this.lblMacroSlot.Text = "Slot:";
			this.selectMacroBar.BackColor = global::System.Drawing.Color.Transparent;
			this.selectMacroBar.BorderColor = global::System.Drawing.Color.Gray;
			this.selectMacroBar.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectMacroBar.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectMacroBar.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectMacroBar.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectMacroBar.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectMacroBar.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectMacroBar.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectMacroBar.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectMacroBar.ForeColor = global::System.Drawing.Color.White;
			this.selectMacroBar.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectMacroBar.ItemHeight = 24;
			this.selectMacroBar.Items.AddRange(new object[]
			{
				"Top",
				"Bottom"
			});
			this.selectMacroBar.Location = new global::System.Drawing.Point(180, 96);
			this.selectMacroBar.Name = "selectMacroBar";
			this.selectMacroBar.Size = new global::System.Drawing.Size(98, 30);
			this.selectMacroBar.StartIndex = 0;
			this.selectMacroBar.TabIndex = 96;
			this.lblMacroBar.AutoSize = true;
			this.lblMacroBar.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMacroBar.ForeColor = global::System.Drawing.Color.White;
			this.lblMacroBar.Location = new global::System.Drawing.Point(22, 105);
			this.lblMacroBar.Name = "lblMacroBar";
			this.lblMacroBar.Size = new global::System.Drawing.Size(65, 15);
			this.lblMacroBar.TabIndex = 95;
			this.lblMacroBar.Text = "Action Bar:";
			this.txtMacroName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtMacroName.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroName.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMacroName.DefaultText = "";
			this.txtMacroName.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtMacroName.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtMacroName.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroName.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMacroName.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtMacroName.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtMacroName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMacroName.ForeColor = global::System.Drawing.Color.White;
			this.txtMacroName.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtMacroName.Location = new global::System.Drawing.Point(180, 60);
			this.txtMacroName.MaxLength = 150;
			this.txtMacroName.Name = "txtMacroName";
			this.txtMacroName.PasswordChar = '\0';
			this.txtMacroName.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtMacroName.PlaceholderText = "";
			this.txtMacroName.SelectedText = "";
			this.txtMacroName.Size = new global::System.Drawing.Size(353, 30);
			this.txtMacroName.TabIndex = 94;
			this.lblMacroName.AutoSize = true;
			this.lblMacroName.BackColor = global::System.Drawing.Color.Transparent;
			this.lblMacroName.ForeColor = global::System.Drawing.Color.White;
			this.lblMacroName.Location = new global::System.Drawing.Point(22, 67);
			this.lblMacroName.Name = "lblMacroName";
			this.lblMacroName.Size = new global::System.Drawing.Size(42, 15);
			this.lblMacroName.TabIndex = 14;
			this.lblMacroName.Text = "Name:";
			this.panelTitle2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle2.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle2.Controls.Add(this.imgTitleEdge2);
			this.panelTitle2.Controls.Add(this.lblTitle2);
			this.panelTitle2.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle2.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle2.Name = "panelTitle2";
			this.panelTitle2.Size = new global::System.Drawing.Size(375, 38);
			this.panelTitle2.TabIndex = 66;
			this.imgTitleEdge2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge2.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge2.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge2.ImageRotate = 0f;
			this.imgTitleEdge2.Location = new global::System.Drawing.Point(305, 0);
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
			this.lblTitle2.Text = "Spell Manager";
			this.lblProfileName.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblProfileName.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.lblProfileName.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.lblProfileName.Location = new global::System.Drawing.Point(353, 598);
			this.lblProfileName.Name = "lblProfileName";
			this.lblProfileName.Size = new global::System.Drawing.Size(325, 23);
			this.lblProfileName.TabIndex = 73;
			this.lblProfileName.Text = "[PROFILE NAME]";
			this.lblProfileName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblProfileName.Visible = false;
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(695, 577);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 72;
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
			this.txtPropertiesRepetitions.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesRepetitions.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPropertiesRepetitions.DefaultText = "";
			this.txtPropertiesRepetitions.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesRepetitions.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPropertiesRepetitions.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesRepetitions.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPropertiesRepetitions.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPropertiesRepetitions.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPropertiesRepetitions.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPropertiesRepetitions.ForeColor = global::System.Drawing.Color.White;
			this.txtPropertiesRepetitions.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPropertiesRepetitions.Location = new global::System.Drawing.Point(171, 132);
			this.txtPropertiesRepetitions.MaxLength = 10;
			this.txtPropertiesRepetitions.Name = "txtPropertiesRepetitions";
			this.txtPropertiesRepetitions.PasswordChar = '\0';
			this.txtPropertiesRepetitions.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPropertiesRepetitions.PlaceholderText = "";
			this.txtPropertiesRepetitions.SelectedText = "";
			this.txtPropertiesRepetitions.Size = new global::System.Drawing.Size(89, 30);
			this.txtPropertiesRepetitions.TabIndex = 102;
			this.lblPropertiesPrio.AutoSize = true;
			this.lblPropertiesPrio.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPropertiesPrio.ForeColor = global::System.Drawing.Color.White;
			this.lblPropertiesPrio.Location = new global::System.Drawing.Point(22, 175);
			this.lblPropertiesPrio.Name = "lblPropertiesPrio";
			this.lblPropertiesPrio.Size = new global::System.Drawing.Size(48, 15);
			this.lblPropertiesPrio.TabIndex = 101;
			this.lblPropertiesPrio.Text = "Priority:";
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(999, 661);
			base.Controls.Add(this.lblProfileName);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.Controls.Add(this.panelBox2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(999, 661);
			base.Name = "frmRotationConditions";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmRotationConditions";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmRotationConditions_FormClosing);
			base.Load += new global::System.EventHandler(this.frmRotationConditions_Load);
			base.Shown += new global::System.EventHandler(this.frmRotationConditions_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmRotationConditions_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.grpProperties.ResumeLayout(false);
			this.grpProperties.PerformLayout();
			this.grpInfo.ResumeLayout(false);
			this.grpInfo.PerformLayout();
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.imgTitleEdge1.EndInit();
			this.panelBox2.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabGeneral.ResumeLayout(false);
			this.panelTabGeneral.ResumeLayout(false);
			this.grpItem.ResumeLayout(false);
			this.grpItem.PerformLayout();
			this.grpType.ResumeLayout(false);
			this.grpType.PerformLayout();
			this.grpPowerType2.ResumeLayout(false);
			this.grpPowerType2.PerformLayout();
			this.grpPowerType1.ResumeLayout(false);
			this.grpPowerType1.PerformLayout();
			this.tabOptions.ResumeLayout(false);
			this.panelTabOptions.ResumeLayout(false);
			this.grpAddition1.ResumeLayout(false);
			this.grpAddition1.PerformLayout();
			this.grpAddition4.ResumeLayout(false);
			this.grpAddition4.PerformLayout();
			this.grpAddition2.ResumeLayout(false);
			this.grpAddition2.PerformLayout();
			this.grpAddition3.ResumeLayout(false);
			this.grpAddition3.PerformLayout();
			this.tabMore.ResumeLayout(false);
			this.panelTabMore.ResumeLayout(false);
			this.grpMisc.ResumeLayout(false);
			this.grpMisc.PerformLayout();
			this.grpMultipleAttackers.ResumeLayout(false);
			this.grpMultipleAttackers.PerformLayout();
			this.tabMacro.ResumeLayout(false);
			this.panelTabMacro.ResumeLayout(false);
			this.grpMacro.ResumeLayout(false);
			this.grpMacro.PerformLayout();
			this.panelTitle2.ResumeLayout(false);
			this.panelTitle2.PerformLayout();
			this.imgTitleEdge2.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400090B RID: 2315
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400090C RID: 2316
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400090D RID: 2317
		private global::Guna.UI2.WinForms.Guna2GroupBox grpProperties;

		// Token: 0x0400090E RID: 2318
		private global::System.Windows.Forms.Label lblPropertiesDifferentAuraID;

		// Token: 0x0400090F RID: 2319
		private global::Guna.UI2.WinForms.Guna2GroupBox grpInfo;

		// Token: 0x04000910 RID: 2320
		private global::System.Windows.Forms.Label lblInfoSpellNameData;

		// Token: 0x04000911 RID: 2321
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x04000912 RID: 2322
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x04000913 RID: 2323
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x04000914 RID: 2324
		private global::Guna.UI2.WinForms.Guna2Panel panelBox2;

		// Token: 0x04000915 RID: 2325
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x04000916 RID: 2326
		private global::System.Windows.Forms.TabPage tabGeneral;

		// Token: 0x04000917 RID: 2327
		private global::Guna.UI2.WinForms.Guna2GroupBox grpType;

		// Token: 0x04000918 RID: 2328
		private global::Guna.UI2.WinForms.Guna2ComboBox selectType;

		// Token: 0x04000919 RID: 2329
		private global::System.Windows.Forms.TabPage tabOptions;

		// Token: 0x0400091A RID: 2330
		private global::System.Windows.Forms.TabPage tabMore;

		// Token: 0x0400091B RID: 2331
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle2;

		// Token: 0x0400091C RID: 2332
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge2;

		// Token: 0x0400091D RID: 2333
		private global::System.Windows.Forms.Label lblTitle2;

		// Token: 0x0400091E RID: 2334
		private global::Guna.UI2.WinForms.Guna2TextBox txtPropertiesDifferentAuraID;

		// Token: 0x0400091F RID: 2335
		private global::Guna.UI2.WinForms.Guna2TextBox txtPropertiesPrio;

		// Token: 0x04000920 RID: 2336
		private global::System.Windows.Forms.Label lblPropertiesRepetitions;

		// Token: 0x04000921 RID: 2337
		private global::Guna.UI2.WinForms.Guna2Button btnReset;

		// Token: 0x04000922 RID: 2338
		private global::Guna.UI2.WinForms.Guna2CheckBox checkCanCastWhileWalk;

		// Token: 0x04000923 RID: 2339
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x04000924 RID: 2340
		private global::Guna.UI2.WinForms.Guna2GroupBox grpPowerType1;

		// Token: 0x04000925 RID: 2341
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPowerType1Target;

		// Token: 0x04000926 RID: 2342
		private global::Guna.UI2.WinForms.Guna2TextBox txtPowerType1Value;

		// Token: 0x04000927 RID: 2343
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPowerType1Compare;

		// Token: 0x04000928 RID: 2344
		private global::System.Windows.Forms.Label lblPowerType1Compare;

		// Token: 0x04000929 RID: 2345
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPowerType1;

		// Token: 0x0400092A RID: 2346
		private global::System.Windows.Forms.Label lblPowerType1;

		// Token: 0x0400092B RID: 2347
		private global::System.Windows.Forms.Label lblPowerType1Subject;

		// Token: 0x0400092C RID: 2348
		private global::System.Windows.Forms.Label lblType;

		// Token: 0x0400092D RID: 2349
		private global::Guna.UI2.WinForms.Guna2GroupBox grpPowerType2;

		// Token: 0x0400092E RID: 2350
		private global::Guna.UI2.WinForms.Guna2TextBox txtPowerType2Value;

		// Token: 0x0400092F RID: 2351
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPowerType2Compare;

		// Token: 0x04000930 RID: 2352
		private global::System.Windows.Forms.Label lblPowerType2Compare;

		// Token: 0x04000931 RID: 2353
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPowerType2;

		// Token: 0x04000932 RID: 2354
		private global::System.Windows.Forms.Label lblPowerType2;

		// Token: 0x04000933 RID: 2355
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPowerType2Target;

		// Token: 0x04000934 RID: 2356
		private global::System.Windows.Forms.Label lblPowerType2Subject;

		// Token: 0x04000935 RID: 2357
		private global::Guna.UI2.WinForms.Guna2GroupBox grpItem;

		// Token: 0x04000936 RID: 2358
		private global::Guna.UI2.WinForms.Guna2TextBox txtItemValue;

		// Token: 0x04000937 RID: 2359
		private global::System.Windows.Forms.Label lblItemAmount;

		// Token: 0x04000938 RID: 2360
		private global::Guna.UI2.WinForms.Guna2ComboBox selectItemCompare;

		// Token: 0x04000939 RID: 2361
		private global::System.Windows.Forms.Label lblItemCompare;

		// Token: 0x0400093A RID: 2362
		private global::System.Windows.Forms.Label lblItem;

		// Token: 0x0400093B RID: 2363
		private global::Guna.UI2.WinForms.Guna2Button btnItemReload;

		// Token: 0x0400093C RID: 2364
		private global::Guna.UI2.WinForms.Guna2TextBox txtItemAmount;

		// Token: 0x0400093D RID: 2365
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddition1;

		// Token: 0x0400093E RID: 2366
		private global::Guna.UI2.WinForms.Guna2TextBox txtAddition1Value;

		// Token: 0x0400093F RID: 2367
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAddition1Compare;

		// Token: 0x04000940 RID: 2368
		private global::System.Windows.Forms.Label lblAddition1Compare;

		// Token: 0x04000941 RID: 2369
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAddition1Option;

		// Token: 0x04000942 RID: 2370
		private global::System.Windows.Forms.Label lblAddition1Option;

		// Token: 0x04000943 RID: 2371
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAddition1Target;

		// Token: 0x04000944 RID: 2372
		private global::System.Windows.Forms.Label lblAddition1Target;

		// Token: 0x04000945 RID: 2373
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddition2;

		// Token: 0x04000946 RID: 2374
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAddition2DoNotRecastIfActiveTarget;

		// Token: 0x04000947 RID: 2375
		private global::System.Windows.Forms.Label lblAddition2DoNotRecastIfActiveTarget;

		// Token: 0x04000948 RID: 2376
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddition2DoNotRecastIfActive;

		// Token: 0x04000949 RID: 2377
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddition3;

		// Token: 0x0400094A RID: 2378
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddition3CastIfActive;

		// Token: 0x0400094B RID: 2379
		private global::System.Windows.Forms.Label lblAddition3CastIfActiveSpelllist;

		// Token: 0x0400094C RID: 2380
		private global::System.Windows.Forms.Label lblAddition3CastIfActiveOn;

		// Token: 0x0400094D RID: 2381
		private global::Guna.UI2.WinForms.Guna2Button btnAddition3CastIfActiveSpelllist;

		// Token: 0x0400094E RID: 2382
		private global::Guna.UI2.WinForms.Guna2ComboBox selectAddition3CastIfActiveTarget;

		// Token: 0x0400094F RID: 2383
		private global::System.Windows.Forms.Label lblAddition3CastIfActiveTarget;

		// Token: 0x04000950 RID: 2384
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAddition4;

		// Token: 0x04000951 RID: 2385
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddition4AlwaysActiveOutOfCombat;

		// Token: 0x04000952 RID: 2386
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddition4AlwaysActiveCombatWay;

		// Token: 0x04000953 RID: 2387
		private global::Guna.UI2.WinForms.Guna2CheckBox checkAddition4AlwaysActiveCombat;

		// Token: 0x04000954 RID: 2388
		private global::Guna.UI2.WinForms.Guna2GroupBox grpMultipleAttackers;

		// Token: 0x04000955 RID: 2389
		private global::System.Windows.Forms.Label lblMultipleAttackersYards;

		// Token: 0x04000956 RID: 2390
		private global::System.Windows.Forms.Label lblMultipleAttackersWithin;

		// Token: 0x04000957 RID: 2391
		private global::Guna.UI2.WinForms.Guna2TextBox txtMultipleAttackersDistance;

		// Token: 0x04000958 RID: 2392
		private global::Guna.UI2.WinForms.Guna2TextBox txtMultipleAttackersValue;

		// Token: 0x04000959 RID: 2393
		private global::Guna.UI2.WinForms.Guna2ComboBox selectMultipleAttackersCompare;

		// Token: 0x0400095A RID: 2394
		private global::System.Windows.Forms.Label lblMultipleAttackersCompare;

		// Token: 0x0400095B RID: 2395
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMultipleAttackersStepBack;

		// Token: 0x0400095C RID: 2396
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator2;

		// Token: 0x0400095D RID: 2397
		private global::System.Windows.Forms.Label lblMultipleAttackers;

		// Token: 0x0400095E RID: 2398
		private global::Guna.UI2.WinForms.Guna2GroupBox grpMisc;

		// Token: 0x0400095F RID: 2399
		private global::Guna.UI2.WinForms.Guna2CheckBox checkMiscTargetIsCasting;

		// Token: 0x04000960 RID: 2400
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x04000961 RID: 2401
		private global::Guna.UI2.WinForms.Guna2Button btnSave;

		// Token: 0x04000962 RID: 2402
		private global::Guna.UI2.WinForms.Guna2Panel panelTabGeneral;

		// Token: 0x04000963 RID: 2403
		private global::Guna.UI2.WinForms.Guna2Panel panelTabOptions;

		// Token: 0x04000964 RID: 2404
		private global::Guna.UI2.WinForms.Guna2Panel panelTabMore;

		// Token: 0x04000965 RID: 2405
		private global::System.Windows.Forms.ComboBox selectItem;

		// Token: 0x04000966 RID: 2406
		private global::System.Windows.Forms.Label lblProfileName;

		// Token: 0x04000967 RID: 2407
		private global::Guna.UI2.WinForms.Guna2Button btnPropertiesTooltip;

		// Token: 0x04000968 RID: 2408
		private global::Guna.UI2.WinForms.Guna2Button btnItemTooltip;

		// Token: 0x04000969 RID: 2409
		private global::Guna.UI2.WinForms.Guna2Button btnTypeTooltip;

		// Token: 0x0400096A RID: 2410
		private global::Guna.UI2.WinForms.Guna2Button btnPowerType2Tooltip;

		// Token: 0x0400096B RID: 2411
		private global::Guna.UI2.WinForms.Guna2Button btnPowerType1Tooltip;

		// Token: 0x0400096C RID: 2412
		private global::System.Windows.Forms.TabPage tabMacro;

		// Token: 0x0400096D RID: 2413
		private global::Guna.UI2.WinForms.Guna2Panel panelTabMacro;

		// Token: 0x0400096E RID: 2414
		private global::Guna.UI2.WinForms.Guna2GroupBox grpMacro;

		// Token: 0x0400096F RID: 2415
		private global::Guna.UI2.WinForms.Guna2TextBox txtMacroName;

		// Token: 0x04000970 RID: 2416
		private global::System.Windows.Forms.Label lblMacroName;

		// Token: 0x04000971 RID: 2417
		private global::Guna.UI2.WinForms.Guna2TextBox txtPropertiesCooldown;

		// Token: 0x04000972 RID: 2418
		private global::System.Windows.Forms.Label lblPropertiesCooldown;

		// Token: 0x04000973 RID: 2419
		private global::Guna.UI2.WinForms.Guna2ComboBox selectMacroSlot;

		// Token: 0x04000974 RID: 2420
		private global::System.Windows.Forms.Label lblMacroSlot;

		// Token: 0x04000975 RID: 2421
		private global::Guna.UI2.WinForms.Guna2ComboBox selectMacroBar;

		// Token: 0x04000976 RID: 2422
		private global::System.Windows.Forms.Label lblMacroBar;

		// Token: 0x04000977 RID: 2423
		private global::Guna.UI2.WinForms.Guna2TextBox txtPropertiesRepetitions;

		// Token: 0x04000978 RID: 2424
		private global::System.Windows.Forms.Label lblPropertiesPrio;
	}
}
