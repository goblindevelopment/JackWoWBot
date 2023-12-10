namespace Jack.Forms
{
	// Token: 0x020000B2 RID: 178
	public partial class frmRotation : global::System.Windows.Forms.Form
	{
		// Token: 0x06001295 RID: 4757 RVA: 0x006EFA7C File Offset: 0x006EDC7C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x006EFAA8 File Offset: 0x006EDCA8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmRotation));
			this.listSpells = new global::System.Windows.Forms.ListView();
			this.listSpellsID = new global::System.Windows.Forms.ColumnHeader();
			this.listSpellsRequiredLevel = new global::System.Windows.Forms.ColumnHeader();
			this.listSpellsPrio = new global::System.Windows.Forms.ColumnHeader();
			this.listSpellsName = new global::System.Windows.Forms.ColumnHeader();
			this.listSpellsType = new global::System.Windows.Forms.ColumnHeader();
			this.listSpellsConditions = new global::System.Windows.Forms.ColumnHeader();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnRotationTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabs = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabRotation = new global::System.Windows.Forms.TabPage();
			this.lblRotationLoading = new global::System.Windows.Forms.Label();
			this.selectOptions = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.btnReload = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectSpells = new global::System.Windows.Forms.ComboBox();
			this.btnAdd = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabGSE = new global::System.Windows.Forms.TabPage();
			this.panelTabGSE = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpGSESettings = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblGSESettingsKeybindData = new global::System.Windows.Forms.Label();
			this.lblGSESettingsKeybind = new global::System.Windows.Forms.Label();
			this.lblGSESettingsClickDelayMS = new global::System.Windows.Forms.Label();
			this.txtGSESettingsClickDelay = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblGSESettingsClickDelay = new global::System.Windows.Forms.Label();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkGSE = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpGSEImportMacro = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnGSEImportMacro = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelGSEImportMacro = new global::Guna.UI2.WinForms.Guna2Panel();
			this.richGSEImportMacro = new global::System.Windows.Forms.RichTextBox();
			this.tabSettings = new global::System.Windows.Forms.TabPage();
			this.panelTabSettings = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpSettingsSpells = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSettingsSpellsTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectFindSpells = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblFindSpells = new global::System.Windows.Forms.Label();
			this.grpSettingsCharacter = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.selectClassType = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.selectClass = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblSettingsCharacterClass = new global::System.Windows.Forms.Label();
			this.lblSettingsCharacterClassType = new global::System.Windows.Forms.Label();
			this.grpSettingsDistances = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSettingsDistancesTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblPullDistanceYds = new global::System.Windows.Forms.Label();
			this.txtPullDistance = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.lblPullDistance = new global::System.Windows.Forms.Label();
			this.tabPet = new global::System.Windows.Forms.TabPage();
			this.panelTabPet = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpPetFeed = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblPetFeedMinutes2 = new global::System.Windows.Forms.Label();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblPetFeedKeybind = new global::System.Windows.Forms.Label();
			this.txtPetFeedMinutes = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkPetFeed = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblPetFeedMinutes1 = new global::System.Windows.Forms.Label();
			this.grpPetCall = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnPetCallTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectPetCallSpell = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.checkPetCall = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblPetCallInfo = new global::System.Windows.Forms.Label();
			this.grpPetCombatReact = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnPetCombatReactTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.checkPetCombatReactStepBack = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.selectPetCombatReactSpell = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.sepPetCombatReact1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblPetCombatReactInfo = new global::System.Windows.Forms.Label();
			this.checkPetCombatReact = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblPetCombatReactSpell = new global::System.Windows.Forms.Label();
			this.grpPetRevive = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnPetReviveTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.selectPetReviveSpell = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.checkPetRevive = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblPetReviveSpell = new global::System.Windows.Forms.Label();
			this.grpPetCombat = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.checkPetCombatParallel = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblPetCombatWait2 = new global::System.Windows.Forms.Label();
			this.sepPetCombat1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblPetCombatKeybind = new global::System.Windows.Forms.Label();
			this.txtPetCombatWait = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.checkPetCombat = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblPetCombatWait1 = new global::System.Windows.Forms.Label();
			this.tabEnchantment = new global::System.Windows.Forms.TabPage();
			this.panelTabEnchantment = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpEnchantmentOffHand = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblEnchantmentOffHandKeybind = new global::System.Windows.Forms.Label();
			this.checkEnchantmentOffHand = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.grpEnchantmentMainHand = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnEnchantmentTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblEnchantmentMainHandKeybind = new global::System.Windows.Forms.Label();
			this.checkEnchantmentMainHand = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblProfileName = new global::System.Windows.Forms.Label();
			this.btnGSEImportClearMacro = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblGSEImportStatus = new global::System.Windows.Forms.Label();
			this.panelBox1.SuspendLayout();
			this.tabs.SuspendLayout();
			this.tabRotation.SuspendLayout();
			this.tabGSE.SuspendLayout();
			this.panelTabGSE.SuspendLayout();
			this.grpGSESettings.SuspendLayout();
			this.grpGSEImportMacro.SuspendLayout();
			this.panelGSEImportMacro.SuspendLayout();
			this.tabSettings.SuspendLayout();
			this.panelTabSettings.SuspendLayout();
			this.grpSettingsSpells.SuspendLayout();
			this.grpSettingsCharacter.SuspendLayout();
			this.grpSettingsDistances.SuspendLayout();
			this.tabPet.SuspendLayout();
			this.panelTabPet.SuspendLayout();
			this.grpPetFeed.SuspendLayout();
			this.grpPetCall.SuspendLayout();
			this.grpPetCombatReact.SuspendLayout();
			this.grpPetRevive.SuspendLayout();
			this.grpPetCombat.SuspendLayout();
			this.tabEnchantment.SuspendLayout();
			this.panelTabEnchantment.SuspendLayout();
			this.grpEnchantmentOffHand.SuspendLayout();
			this.grpEnchantmentMainHand.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.listSpells.Alignment = global::System.Windows.Forms.ListViewAlignment.Left;
			this.listSpells.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listSpells.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listSpells.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listSpellsID,
				this.listSpellsRequiredLevel,
				this.listSpellsPrio,
				this.listSpellsName,
				this.listSpellsType,
				this.listSpellsConditions
			});
			this.listSpells.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.listSpells.ForeColor = global::System.Drawing.Color.White;
			this.listSpells.FullRowSelect = true;
			this.listSpells.HideSelection = false;
			this.listSpells.Location = new global::System.Drawing.Point(14, 49);
			this.listSpells.MultiSelect = false;
			this.listSpells.Name = "listSpells";
			this.listSpells.OwnerDraw = true;
			this.listSpells.Size = new global::System.Drawing.Size(840, 366);
			this.listSpells.TabIndex = 52;
			this.listSpells.UseCompatibleStateImageBehavior = false;
			this.listSpells.View = global::System.Windows.Forms.View.Details;
			this.listSpells.ColumnClick += new global::System.Windows.Forms.ColumnClickEventHandler(this.listSpells_ColumnClick);
			this.listSpells.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listSpells_KeyDown);
			this.listSpells.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.listSpells_MouseClick);
			this.listSpells.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listSpells_MouseDoubleClick);
			this.listSpells.Resize += new global::System.EventHandler(this.listSpells_Resize);
			this.listSpellsID.Text = "ID";
			this.listSpellsRequiredLevel.Text = "Req. LvL";
			this.listSpellsPrio.Text = "Prio";
			this.listSpellsPrio.Width = 35;
			this.listSpellsName.Text = "Name";
			this.listSpellsName.Width = 220;
			this.listSpellsType.Text = "Type";
			this.listSpellsType.Width = 100;
			this.listSpellsConditions.Text = "Conditions";
			this.listSpellsConditions.Width = 345;
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.btnRotationTooltip);
			this.panelBox1.Controls.Add(this.tabs);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(1042, 504);
			this.panelBox1.TabIndex = 68;
			this.btnRotationTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRotationTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnRotationTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnRotationTooltip.BorderRadius = 4;
			this.btnRotationTooltip.BorderThickness = 1;
			this.btnRotationTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnRotationTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnRotationTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnRotationTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRotationTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnRotationTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRotationTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnRotationTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnRotationTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnRotationTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnRotationTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnRotationTooltip.Location = new global::System.Drawing.Point(987, 13);
			this.btnRotationTooltip.Name = "btnRotationTooltip";
			this.btnRotationTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnRotationTooltip.TabIndex = 77;
			this.btnRotationTooltip.Click += new global::System.EventHandler(this.btnRotationTooltip_Click);
			this.tabs.Alignment = global::System.Windows.Forms.TabAlignment.Left;
			this.tabs.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tabs.Controls.Add(this.tabRotation);
			this.tabs.Controls.Add(this.tabGSE);
			this.tabs.Controls.Add(this.tabSettings);
			this.tabs.Controls.Add(this.tabPet);
			this.tabs.Controls.Add(this.tabEnchantment);
			this.tabs.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.tabs.ItemSize = new global::System.Drawing.Size(140, 40);
			this.tabs.Location = new global::System.Drawing.Point(14, 53);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new global::System.Drawing.Size(1016, 437);
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
			this.tabs.SelectedIndexChanged += new global::System.EventHandler(this.tabs_SelectedIndexChanged);
			this.tabRotation.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.tabRotation.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabRotation.Controls.Add(this.lblRotationLoading);
			this.tabRotation.Controls.Add(this.selectOptions);
			this.tabRotation.Controls.Add(this.btnReload);
			this.tabRotation.Controls.Add(this.selectSpells);
			this.tabRotation.Controls.Add(this.btnAdd);
			this.tabRotation.Controls.Add(this.listSpells);
			this.tabRotation.ForeColor = global::System.Drawing.Color.White;
			this.tabRotation.Location = new global::System.Drawing.Point(144, 4);
			this.tabRotation.Name = "tabRotation";
			this.tabRotation.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabRotation.Size = new global::System.Drawing.Size(868, 429);
			this.tabRotation.TabIndex = 0;
			this.tabRotation.Text = "Rotation";
			this.lblRotationLoading.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRotationLoading.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRotationLoading.Location = new global::System.Drawing.Point(14, 219);
			this.lblRotationLoading.Name = "lblRotationLoading";
			this.lblRotationLoading.Size = new global::System.Drawing.Size(840, 38);
			this.lblRotationLoading.TabIndex = 102;
			this.lblRotationLoading.Text = "Syncing...";
			this.lblRotationLoading.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblRotationLoading.Visible = false;
			this.selectOptions.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectOptions.BackColor = global::System.Drawing.Color.Transparent;
			this.selectOptions.BorderColor = global::System.Drawing.Color.Gray;
			this.selectOptions.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectOptions.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectOptions.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectOptions.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectOptions.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectOptions.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOptions.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectOptions.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectOptions.ForeColor = global::System.Drawing.Color.White;
			this.selectOptions.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectOptions.ItemHeight = 24;
			this.selectOptions.Items.AddRange(new object[]
			{
				"--- Options ---",
				"Import my actionbars",
				"Add rotation to my actionbars",
				"Clear my actionbars"
			});
			this.selectOptions.Location = new global::System.Drawing.Point(634, 14);
			this.selectOptions.Name = "selectOptions";
			this.selectOptions.Size = new global::System.Drawing.Size(220, 30);
			this.selectOptions.TabIndex = 101;
			this.selectOptions.SelectedIndexChanged += new global::System.EventHandler(this.selectOptions_SelectedIndexChanged);
			this.btnReload.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnReload.BorderColor = global::System.Drawing.Color.Gray;
			this.btnReload.BorderThickness = 1;
			this.btnReload.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.btnReload.DisabledState.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.btnReload.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnReload.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnReload.DisabledState.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("resource.Image");
			this.btnReload.FillColor = global::System.Drawing.Color.Black;
			this.btnReload.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold);
			this.btnReload.ForeColor = global::System.Drawing.Color.White;
			this.btnReload.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnReload.HoverState.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnReload.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("btnReload.Image");
			this.btnReload.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnReload.ImageOffset = new global::System.Drawing.Point(-5, 0);
			this.btnReload.Location = new global::System.Drawing.Point(469, 14);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new global::System.Drawing.Size(30, 29);
			this.btnReload.TabIndex = 99;
			this.btnReload.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.btnReload.Click += new global::System.EventHandler(this.btnReload_Click);
			this.selectSpells.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectSpells.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.selectSpells.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.selectSpells.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectSpells.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.selectSpells.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.selectSpells.ForeColor = global::System.Drawing.Color.White;
			this.selectSpells.FormattingEnabled = true;
			this.selectSpells.Location = new global::System.Drawing.Point(14, 14);
			this.selectSpells.Name = "selectSpells";
			this.selectSpells.Size = new global::System.Drawing.Size(449, 29);
			this.selectSpells.TabIndex = 70;
			this.selectSpells.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.selectSpells_KeyDown);
			this.btnAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAdd.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAdd.BorderThickness = 1;
			this.btnAdd.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAdd.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAdd.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAdd.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAdd.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAdd.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(505, 14);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(92, 29);
			this.btnAdd.TabIndex = 69;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.tabGSE.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabGSE.Controls.Add(this.panelTabGSE);
			this.tabGSE.Location = new global::System.Drawing.Point(144, 4);
			this.tabGSE.Name = "tabGSE";
			this.tabGSE.Size = new global::System.Drawing.Size(868, 429);
			this.tabGSE.TabIndex = 5;
			this.tabGSE.Text = "GSE";
			this.panelTabGSE.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabGSE.AutoScroll = true;
			this.panelTabGSE.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabGSE.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabGSE.Controls.Add(this.grpGSESettings);
			this.panelTabGSE.Controls.Add(this.grpGSEImportMacro);
			this.panelTabGSE.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabGSE.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabGSE.Name = "panelTabGSE";
			this.panelTabGSE.Size = new global::System.Drawing.Size(868, 429);
			this.panelTabGSE.TabIndex = 100;
			this.grpGSESettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpGSESettings.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpGSESettings.Controls.Add(this.lblGSESettingsKeybindData);
			this.grpGSESettings.Controls.Add(this.lblGSESettingsKeybind);
			this.grpGSESettings.Controls.Add(this.lblGSESettingsClickDelayMS);
			this.grpGSESettings.Controls.Add(this.txtGSESettingsClickDelay);
			this.grpGSESettings.Controls.Add(this.lblGSESettingsClickDelay);
			this.grpGSESettings.Controls.Add(this.guna2Button1);
			this.grpGSESettings.Controls.Add(this.checkGSE);
			this.grpGSESettings.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpGSESettings.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpGSESettings.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpGSESettings.ForeColor = global::System.Drawing.Color.White;
			this.grpGSESettings.Location = new global::System.Drawing.Point(14, 14);
			this.grpGSESettings.Name = "grpGSESettings";
			this.grpGSESettings.Size = new global::System.Drawing.Size(805, 153);
			this.grpGSESettings.TabIndex = 97;
			this.lblGSESettingsKeybindData.AutoSize = true;
			this.lblGSESettingsKeybindData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGSESettingsKeybindData.Enabled = false;
			this.lblGSESettingsKeybindData.Location = new global::System.Drawing.Point(177, 112);
			this.lblGSESettingsKeybindData.Name = "lblGSESettingsKeybindData";
			this.lblGSESettingsKeybindData.Size = new global::System.Drawing.Size(62, 15);
			this.lblGSESettingsKeybindData.TabIndex = 104;
			this.lblGSESettingsKeybindData.Text = "[KEYBIND]";
			this.lblGSESettingsKeybind.AutoSize = true;
			this.lblGSESettingsKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGSESettingsKeybind.Enabled = false;
			this.lblGSESettingsKeybind.Location = new global::System.Drawing.Point(22, 112);
			this.lblGSESettingsKeybind.Name = "lblGSESettingsKeybind";
			this.lblGSESettingsKeybind.Size = new global::System.Drawing.Size(53, 15);
			this.lblGSESettingsKeybind.TabIndex = 103;
			this.lblGSESettingsKeybind.Text = "Keybind:";
			this.lblGSESettingsClickDelayMS.AutoSize = true;
			this.lblGSESettingsClickDelayMS.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGSESettingsClickDelayMS.Enabled = false;
			this.lblGSESettingsClickDelayMS.Location = new global::System.Drawing.Point(255, 67);
			this.lblGSESettingsClickDelayMS.Name = "lblGSESettingsClickDelayMS";
			this.lblGSESettingsClickDelayMS.Size = new global::System.Drawing.Size(79, 15);
			this.lblGSESettingsClickDelayMS.TabIndex = 102;
			this.lblGSESettingsClickDelayMS.Text = "ms (min. 500)";
			this.txtGSESettingsClickDelay.BorderColor = global::System.Drawing.Color.Gray;
			this.txtGSESettingsClickDelay.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtGSESettingsClickDelay.DefaultText = "1000";
			this.txtGSESettingsClickDelay.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtGSESettingsClickDelay.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtGSESettingsClickDelay.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtGSESettingsClickDelay.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtGSESettingsClickDelay.Enabled = false;
			this.txtGSESettingsClickDelay.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtGSESettingsClickDelay.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtGSESettingsClickDelay.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtGSESettingsClickDelay.ForeColor = global::System.Drawing.Color.White;
			this.txtGSESettingsClickDelay.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtGSESettingsClickDelay.Location = new global::System.Drawing.Point(180, 60);
			this.txtGSESettingsClickDelay.MaxLength = 4;
			this.txtGSESettingsClickDelay.Name = "txtGSESettingsClickDelay";
			this.txtGSESettingsClickDelay.PasswordChar = '\0';
			this.txtGSESettingsClickDelay.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtGSESettingsClickDelay.PlaceholderText = "";
			this.txtGSESettingsClickDelay.SelectedText = "";
			this.txtGSESettingsClickDelay.Size = new global::System.Drawing.Size(69, 30);
			this.txtGSESettingsClickDelay.TabIndex = 101;
			this.lblGSESettingsClickDelay.AutoSize = true;
			this.lblGSESettingsClickDelay.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGSESettingsClickDelay.Enabled = false;
			this.lblGSESettingsClickDelay.Location = new global::System.Drawing.Point(22, 67);
			this.lblGSESettingsClickDelay.Name = "lblGSESettingsClickDelay";
			this.lblGSESettingsClickDelay.Size = new global::System.Drawing.Size(68, 15);
			this.lblGSESettingsClickDelay.TabIndex = 99;
			this.lblGSESettingsClickDelay.Text = "Click Delay:";
			this.guna2Button1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderColor = global::System.Drawing.Color.Empty;
			this.guna2Button1.BorderRadius = 4;
			this.guna2Button1.BorderThickness = 1;
			this.guna2Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.guna2Button1.Image = global::Jack.Properties.Resources.tooltip_30;
			this.guna2Button1.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.guna2Button1.ImageSize = new global::System.Drawing.Size(30, 17);
			this.guna2Button1.Location = new global::System.Drawing.Point(758, 8);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(39, 25);
			this.guna2Button1.TabIndex = 98;
			this.checkGSE.Animated = true;
			this.checkGSE.AutoSize = true;
			this.checkGSE.BackColor = global::System.Drawing.Color.Transparent;
			this.checkGSE.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGSE.CheckedState.BorderRadius = 0;
			this.checkGSE.CheckedState.BorderThickness = 0;
			this.checkGSE.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkGSE.Location = new global::System.Drawing.Point(12, 11);
			this.checkGSE.Name = "checkGSE";
			this.checkGSE.Size = new global::System.Drawing.Size(68, 19);
			this.checkGSE.TabIndex = 95;
			this.checkGSE.Text = "Use GSE";
			this.checkGSE.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkGSE.UncheckedState.BorderRadius = 0;
			this.checkGSE.UncheckedState.BorderThickness = 1;
			this.checkGSE.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkGSE.UseVisualStyleBackColor = false;
			this.checkGSE.CheckedChanged += new global::System.EventHandler(this.checkGSE_CheckedChanged);
			this.grpGSEImportMacro.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpGSEImportMacro.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpGSEImportMacro.Controls.Add(this.lblGSEImportStatus);
			this.grpGSEImportMacro.Controls.Add(this.btnGSEImportClearMacro);
			this.grpGSEImportMacro.Controls.Add(this.btnGSEImportMacro);
			this.grpGSEImportMacro.Controls.Add(this.panelGSEImportMacro);
			this.grpGSEImportMacro.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpGSEImportMacro.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpGSEImportMacro.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpGSEImportMacro.ForeColor = global::System.Drawing.Color.White;
			this.grpGSEImportMacro.Location = new global::System.Drawing.Point(14, 182);
			this.grpGSEImportMacro.Name = "grpGSEImportMacro";
			this.grpGSEImportMacro.Size = new global::System.Drawing.Size(805, 277);
			this.grpGSEImportMacro.TabIndex = 98;
			this.grpGSEImportMacro.Text = "Import GSE Macro";
			this.btnGSEImportMacro.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGSEImportMacro.BorderColor = global::System.Drawing.Color.Gray;
			this.btnGSEImportMacro.BorderThickness = 1;
			this.btnGSEImportMacro.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnGSEImportMacro.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnGSEImportMacro.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnGSEImportMacro.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnGSEImportMacro.Enabled = false;
			this.btnGSEImportMacro.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnGSEImportMacro.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnGSEImportMacro.ForeColor = global::System.Drawing.Color.White;
			this.btnGSEImportMacro.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnGSEImportMacro.Location = new global::System.Drawing.Point(651, 222);
			this.btnGSEImportMacro.Name = "btnGSEImportMacro";
			this.btnGSEImportMacro.Size = new global::System.Drawing.Size(130, 29);
			this.btnGSEImportMacro.TabIndex = 72;
			this.btnGSEImportMacro.Text = "Import";
			this.btnGSEImportMacro.Click += new global::System.EventHandler(this.btnGSEImportMacro_Click);
			this.panelGSEImportMacro.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelGSEImportMacro.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.panelGSEImportMacro.BorderColor = global::System.Drawing.Color.Gray;
			this.panelGSEImportMacro.BorderThickness = 1;
			this.panelGSEImportMacro.Controls.Add(this.richGSEImportMacro);
			this.panelGSEImportMacro.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.panelGSEImportMacro.Location = new global::System.Drawing.Point(25, 67);
			this.panelGSEImportMacro.Name = "panelGSEImportMacro";
			this.panelGSEImportMacro.Size = new global::System.Drawing.Size(756, 149);
			this.panelGSEImportMacro.TabIndex = 71;
			this.richGSEImportMacro.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richGSEImportMacro.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.richGSEImportMacro.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richGSEImportMacro.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.richGSEImportMacro.ForeColor = global::System.Drawing.Color.White;
			this.richGSEImportMacro.Location = new global::System.Drawing.Point(10, 10);
			this.richGSEImportMacro.Name = "richGSEImportMacro";
			this.richGSEImportMacro.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richGSEImportMacro.Size = new global::System.Drawing.Size(737, 130);
			this.richGSEImportMacro.TabIndex = 11;
			this.richGSEImportMacro.Text = "";
			this.tabSettings.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabSettings.Controls.Add(this.panelTabSettings);
			this.tabSettings.ForeColor = global::System.Drawing.Color.White;
			this.tabSettings.Location = new global::System.Drawing.Point(144, 4);
			this.tabSettings.Name = "tabSettings";
			this.tabSettings.Size = new global::System.Drawing.Size(868, 429);
			this.tabSettings.TabIndex = 2;
			this.tabSettings.Text = "Settings";
			this.panelTabSettings.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabSettings.AutoScroll = true;
			this.panelTabSettings.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabSettings.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabSettings.Controls.Add(this.grpSettingsSpells);
			this.panelTabSettings.Controls.Add(this.grpSettingsCharacter);
			this.panelTabSettings.Controls.Add(this.grpSettingsDistances);
			this.panelTabSettings.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabSettings.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabSettings.Name = "panelTabSettings";
			this.panelTabSettings.Size = new global::System.Drawing.Size(868, 429);
			this.panelTabSettings.TabIndex = 90;
			this.grpSettingsSpells.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsSpells.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsSpells.Controls.Add(this.btnSettingsSpellsTooltip);
			this.grpSettingsSpells.Controls.Add(this.selectFindSpells);
			this.grpSettingsSpells.Controls.Add(this.lblFindSpells);
			this.grpSettingsSpells.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsSpells.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsSpells.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsSpells.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsSpells.Location = new global::System.Drawing.Point(14, 309);
			this.grpSettingsSpells.Name = "grpSettingsSpells";
			this.grpSettingsSpells.Size = new global::System.Drawing.Size(808, 110);
			this.grpSettingsSpells.TabIndex = 89;
			this.grpSettingsSpells.Text = "Spells";
			this.btnSettingsSpellsTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSettingsSpellsTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsSpellsTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnSettingsSpellsTooltip.BorderRadius = 4;
			this.btnSettingsSpellsTooltip.BorderThickness = 1;
			this.btnSettingsSpellsTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSettingsSpellsTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsSpellsTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsSpellsTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsSpellsTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSettingsSpellsTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSettingsSpellsTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnSettingsSpellsTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnSettingsSpellsTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnSettingsSpellsTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnSettingsSpellsTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnSettingsSpellsTooltip.Location = new global::System.Drawing.Point(761, 8);
			this.btnSettingsSpellsTooltip.Name = "btnSettingsSpellsTooltip";
			this.btnSettingsSpellsTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSettingsSpellsTooltip.TabIndex = 96;
			this.btnSettingsSpellsTooltip.Click += new global::System.EventHandler(this.btnSettingsSpellsTooltip_Click);
			this.selectFindSpells.BackColor = global::System.Drawing.Color.Transparent;
			this.selectFindSpells.BorderColor = global::System.Drawing.Color.Gray;
			this.selectFindSpells.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectFindSpells.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectFindSpells.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectFindSpells.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectFindSpells.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectFindSpells.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFindSpells.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectFindSpells.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectFindSpells.ForeColor = global::System.Drawing.Color.White;
			this.selectFindSpells.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectFindSpells.ItemHeight = 24;
			this.selectFindSpells.Items.AddRange(new object[]
			{
				"By ID",
				"By Name"
			});
			this.selectFindSpells.Location = new global::System.Drawing.Point(180, 60);
			this.selectFindSpells.Name = "selectFindSpells";
			this.selectFindSpells.Size = new global::System.Drawing.Size(140, 30);
			this.selectFindSpells.TabIndex = 94;
			this.lblFindSpells.AutoSize = true;
			this.lblFindSpells.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFindSpells.Location = new global::System.Drawing.Point(22, 67);
			this.lblFindSpells.Name = "lblFindSpells";
			this.lblFindSpells.Size = new global::System.Drawing.Size(66, 15);
			this.lblFindSpells.TabIndex = 68;
			this.lblFindSpells.Text = "Find Spells:";
			this.grpSettingsCharacter.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsCharacter.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsCharacter.Controls.Add(this.selectClassType);
			this.grpSettingsCharacter.Controls.Add(this.selectClass);
			this.grpSettingsCharacter.Controls.Add(this.lblSettingsCharacterClass);
			this.grpSettingsCharacter.Controls.Add(this.lblSettingsCharacterClassType);
			this.grpSettingsCharacter.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsCharacter.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsCharacter.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsCharacter.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsCharacter.Location = new global::System.Drawing.Point(14, 14);
			this.grpSettingsCharacter.Name = "grpSettingsCharacter";
			this.grpSettingsCharacter.Size = new global::System.Drawing.Size(808, 154);
			this.grpSettingsCharacter.TabIndex = 87;
			this.grpSettingsCharacter.Text = "Character";
			this.selectClassType.BackColor = global::System.Drawing.Color.Transparent;
			this.selectClassType.BorderColor = global::System.Drawing.Color.Gray;
			this.selectClassType.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectClassType.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectClassType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectClassType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectClassType.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectClassType.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectClassType.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectClassType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectClassType.ForeColor = global::System.Drawing.Color.White;
			this.selectClassType.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectClassType.ItemHeight = 24;
			this.selectClassType.Items.AddRange(new object[]
			{
				"Range",
				"Melee"
			});
			this.selectClassType.Location = new global::System.Drawing.Point(180, 105);
			this.selectClassType.Name = "selectClassType";
			this.selectClassType.Size = new global::System.Drawing.Size(140, 30);
			this.selectClassType.TabIndex = 70;
			this.selectClass.BackColor = global::System.Drawing.Color.Transparent;
			this.selectClass.BorderColor = global::System.Drawing.Color.Gray;
			this.selectClass.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectClass.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectClass.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectClass.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectClass.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectClass.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectClass.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectClass.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectClass.ForeColor = global::System.Drawing.Color.White;
			this.selectClass.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectClass.ItemHeight = 24;
			this.selectClass.Location = new global::System.Drawing.Point(180, 60);
			this.selectClass.Name = "selectClass";
			this.selectClass.Size = new global::System.Drawing.Size(140, 30);
			this.selectClass.TabIndex = 69;
			this.lblSettingsCharacterClass.AutoSize = true;
			this.lblSettingsCharacterClass.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsCharacterClass.Location = new global::System.Drawing.Point(22, 67);
			this.lblSettingsCharacterClass.Name = "lblSettingsCharacterClass";
			this.lblSettingsCharacterClass.Size = new global::System.Drawing.Size(37, 15);
			this.lblSettingsCharacterClass.TabIndex = 68;
			this.lblSettingsCharacterClass.Text = "Class:";
			this.lblSettingsCharacterClassType.AutoSize = true;
			this.lblSettingsCharacterClassType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSettingsCharacterClassType.Location = new global::System.Drawing.Point(22, 112);
			this.lblSettingsCharacterClassType.Name = "lblSettingsCharacterClassType";
			this.lblSettingsCharacterClassType.Size = new global::System.Drawing.Size(64, 15);
			this.lblSettingsCharacterClassType.TabIndex = 67;
			this.lblSettingsCharacterClassType.Text = "Class Type:";
			this.grpSettingsDistances.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpSettingsDistances.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsDistances.Controls.Add(this.btnSettingsDistancesTooltip);
			this.grpSettingsDistances.Controls.Add(this.lblPullDistanceYds);
			this.grpSettingsDistances.Controls.Add(this.txtPullDistance);
			this.grpSettingsDistances.Controls.Add(this.lblPullDistance);
			this.grpSettingsDistances.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSettingsDistances.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSettingsDistances.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSettingsDistances.ForeColor = global::System.Drawing.Color.White;
			this.grpSettingsDistances.Location = new global::System.Drawing.Point(14, 183);
			this.grpSettingsDistances.Name = "grpSettingsDistances";
			this.grpSettingsDistances.Size = new global::System.Drawing.Size(808, 110);
			this.grpSettingsDistances.TabIndex = 88;
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
			this.btnSettingsDistancesTooltip.Location = new global::System.Drawing.Point(761, 8);
			this.btnSettingsDistancesTooltip.Name = "btnSettingsDistancesTooltip";
			this.btnSettingsDistancesTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnSettingsDistancesTooltip.TabIndex = 95;
			this.btnSettingsDistancesTooltip.Click += new global::System.EventHandler(this.btnSettingsDistancesTooltip_Click);
			this.lblPullDistanceYds.AutoSize = true;
			this.lblPullDistanceYds.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPullDistanceYds.Location = new global::System.Drawing.Point(335, 67);
			this.lblPullDistanceYds.Name = "lblPullDistanceYds";
			this.lblPullDistanceYds.Size = new global::System.Drawing.Size(28, 15);
			this.lblPullDistanceYds.TabIndex = 94;
			this.lblPullDistanceYds.Text = "yds.";
			this.txtPullDistance.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPullDistance.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPullDistance.DefaultText = "";
			this.txtPullDistance.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPullDistance.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPullDistance.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPullDistance.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPullDistance.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPullDistance.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPullDistance.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPullDistance.ForeColor = global::System.Drawing.Color.White;
			this.txtPullDistance.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPullDistance.Location = new global::System.Drawing.Point(180, 60);
			this.txtPullDistance.MaxLength = 3;
			this.txtPullDistance.Name = "txtPullDistance";
			this.txtPullDistance.PasswordChar = '\0';
			this.txtPullDistance.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPullDistance.PlaceholderText = "";
			this.txtPullDistance.SelectedText = "";
			this.txtPullDistance.Size = new global::System.Drawing.Size(140, 30);
			this.txtPullDistance.TabIndex = 93;
			this.lblPullDistance.AutoSize = true;
			this.lblPullDistance.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPullDistance.Location = new global::System.Drawing.Point(22, 67);
			this.lblPullDistance.Name = "lblPullDistance";
			this.lblPullDistance.Size = new global::System.Drawing.Size(101, 15);
			this.lblPullDistance.TabIndex = 68;
			this.lblPullDistance.Text = "Combat Distance:";
			this.tabPet.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabPet.Controls.Add(this.panelTabPet);
			this.tabPet.ForeColor = global::System.Drawing.Color.White;
			this.tabPet.Location = new global::System.Drawing.Point(144, 4);
			this.tabPet.Name = "tabPet";
			this.tabPet.Size = new global::System.Drawing.Size(868, 429);
			this.tabPet.TabIndex = 3;
			this.tabPet.Text = "Pet";
			this.panelTabPet.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabPet.AutoScroll = true;
			this.panelTabPet.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabPet.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabPet.Controls.Add(this.grpPetFeed);
			this.panelTabPet.Controls.Add(this.grpPetCall);
			this.panelTabPet.Controls.Add(this.grpPetCombatReact);
			this.panelTabPet.Controls.Add(this.grpPetRevive);
			this.panelTabPet.Controls.Add(this.grpPetCombat);
			this.panelTabPet.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabPet.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabPet.Name = "panelTabPet";
			this.panelTabPet.Size = new global::System.Drawing.Size(868, 429);
			this.panelTabPet.TabIndex = 96;
			this.grpPetFeed.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpPetFeed.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetFeed.Controls.Add(this.lblPetFeedMinutes2);
			this.grpPetFeed.Controls.Add(this.guna2Separator1);
			this.grpPetFeed.Controls.Add(this.lblPetFeedKeybind);
			this.grpPetFeed.Controls.Add(this.txtPetFeedMinutes);
			this.grpPetFeed.Controls.Add(this.checkPetFeed);
			this.grpPetFeed.Controls.Add(this.lblPetFeedMinutes1);
			this.grpPetFeed.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetFeed.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpPetFeed.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpPetFeed.ForeColor = global::System.Drawing.Color.White;
			this.grpPetFeed.Location = new global::System.Drawing.Point(14, 264);
			this.grpPetFeed.Name = "grpPetFeed";
			this.grpPetFeed.Size = new global::System.Drawing.Size(807, 180);
			this.grpPetFeed.TabIndex = 95;
			this.lblPetFeedMinutes2.AutoSize = true;
			this.lblPetFeedMinutes2.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetFeedMinutes2.Enabled = false;
			this.lblPetFeedMinutes2.Location = new global::System.Drawing.Point(335, 136);
			this.lblPetFeedMinutes2.Name = "lblPetFeedMinutes2";
			this.lblPetFeedMinutes2.Size = new global::System.Drawing.Size(53, 15);
			this.lblPetFeedMinutes2.TabIndex = 99;
			this.lblPetFeedMinutes2.Text = "Minutes.";
			this.guna2Separator1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Separator1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator1.Location = new global::System.Drawing.Point(17, 99);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(772, 10);
			this.guna2Separator1.TabIndex = 98;
			this.lblPetFeedKeybind.AutoSize = true;
			this.lblPetFeedKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetFeedKeybind.Enabled = false;
			this.lblPetFeedKeybind.ForeColor = global::System.Drawing.Color.White;
			this.lblPetFeedKeybind.Location = new global::System.Drawing.Point(22, 65);
			this.lblPetFeedKeybind.Name = "lblPetFeedKeybind";
			this.lblPetFeedKeybind.Size = new global::System.Drawing.Size(62, 15);
			this.lblPetFeedKeybind.TabIndex = 97;
			this.lblPetFeedKeybind.Text = "[KEYBIND]";
			this.txtPetFeedMinutes.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPetFeedMinutes.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPetFeedMinutes.DefaultText = "30";
			this.txtPetFeedMinutes.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPetFeedMinutes.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPetFeedMinutes.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPetFeedMinutes.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPetFeedMinutes.Enabled = false;
			this.txtPetFeedMinutes.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPetFeedMinutes.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPetFeedMinutes.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPetFeedMinutes.ForeColor = global::System.Drawing.Color.White;
			this.txtPetFeedMinutes.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPetFeedMinutes.Location = new global::System.Drawing.Point(180, 128);
			this.txtPetFeedMinutes.MaxLength = 3;
			this.txtPetFeedMinutes.Name = "txtPetFeedMinutes";
			this.txtPetFeedMinutes.PasswordChar = '\0';
			this.txtPetFeedMinutes.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPetFeedMinutes.PlaceholderText = "";
			this.txtPetFeedMinutes.SelectedText = "";
			this.txtPetFeedMinutes.Size = new global::System.Drawing.Size(140, 30);
			this.txtPetFeedMinutes.TabIndex = 96;
			this.checkPetFeed.Animated = true;
			this.checkPetFeed.AutoSize = true;
			this.checkPetFeed.BackColor = global::System.Drawing.Color.Transparent;
			this.checkPetFeed.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetFeed.CheckedState.BorderRadius = 0;
			this.checkPetFeed.CheckedState.BorderThickness = 0;
			this.checkPetFeed.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetFeed.Location = new global::System.Drawing.Point(12, 11);
			this.checkPetFeed.Name = "checkPetFeed";
			this.checkPetFeed.Size = new global::System.Drawing.Size(71, 19);
			this.checkPetFeed.TabIndex = 95;
			this.checkPetFeed.Text = "Feed Pet";
			this.checkPetFeed.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkPetFeed.UncheckedState.BorderRadius = 0;
			this.checkPetFeed.UncheckedState.BorderThickness = 1;
			this.checkPetFeed.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkPetFeed.UseVisualStyleBackColor = false;
			this.checkPetFeed.CheckedChanged += new global::System.EventHandler(this.checkPetFeed_CheckedChanged);
			this.lblPetFeedMinutes1.AutoSize = true;
			this.lblPetFeedMinutes1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetFeedMinutes1.Enabled = false;
			this.lblPetFeedMinutes1.Location = new global::System.Drawing.Point(22, 136);
			this.lblPetFeedMinutes1.Name = "lblPetFeedMinutes1";
			this.lblPetFeedMinutes1.Size = new global::System.Drawing.Size(35, 15);
			this.lblPetFeedMinutes1.TabIndex = 68;
			this.lblPetFeedMinutes1.Text = "Every";
			this.grpPetCall.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpPetCall.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetCall.Controls.Add(this.btnPetCallTooltip);
			this.grpPetCall.Controls.Add(this.selectPetCallSpell);
			this.grpPetCall.Controls.Add(this.checkPetCall);
			this.grpPetCall.Controls.Add(this.lblPetCallInfo);
			this.grpPetCall.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetCall.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpPetCall.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpPetCall.ForeColor = global::System.Drawing.Color.White;
			this.grpPetCall.Location = new global::System.Drawing.Point(14, 14);
			this.grpPetCall.Name = "grpPetCall";
			this.grpPetCall.Size = new global::System.Drawing.Size(807, 110);
			this.grpPetCall.TabIndex = 91;
			this.btnPetCallTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnPetCallTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPetCallTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnPetCallTooltip.BorderRadius = 4;
			this.btnPetCallTooltip.BorderThickness = 1;
			this.btnPetCallTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPetCallTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnPetCallTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnPetCallTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPetCallTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPetCallTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPetCallTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnPetCallTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnPetCallTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnPetCallTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPetCallTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnPetCallTooltip.Location = new global::System.Drawing.Point(760, 8);
			this.btnPetCallTooltip.Name = "btnPetCallTooltip";
			this.btnPetCallTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnPetCallTooltip.TabIndex = 99;
			this.btnPetCallTooltip.Click += new global::System.EventHandler(this.btnPetCallTooltip_Click);
			this.selectPetCallSpell.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPetCallSpell.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPetCallSpell.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPetCallSpell.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPetCallSpell.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPetCallSpell.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPetCallSpell.Enabled = false;
			this.selectPetCallSpell.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPetCallSpell.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPetCallSpell.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPetCallSpell.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPetCallSpell.ForeColor = global::System.Drawing.Color.White;
			this.selectPetCallSpell.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPetCallSpell.ItemHeight = 24;
			this.selectPetCallSpell.Items.AddRange(new object[]
			{
				"By ID",
				"By Name"
			});
			this.selectPetCallSpell.Location = new global::System.Drawing.Point(180, 60);
			this.selectPetCallSpell.Name = "selectPetCallSpell";
			this.selectPetCallSpell.Size = new global::System.Drawing.Size(540, 30);
			this.selectPetCallSpell.TabIndex = 94;
			this.selectPetCallSpell.SelectedIndexChanged += new global::System.EventHandler(this.selectPetCallSpell_SelectedIndexChanged);
			this.checkPetCall.Animated = true;
			this.checkPetCall.AutoSize = true;
			this.checkPetCall.BackColor = global::System.Drawing.Color.Transparent;
			this.checkPetCall.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCall.CheckedState.BorderRadius = 0;
			this.checkPetCall.CheckedState.BorderThickness = 0;
			this.checkPetCall.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCall.Location = new global::System.Drawing.Point(12, 11);
			this.checkPetCall.Name = "checkPetCall";
			this.checkPetCall.Size = new global::System.Drawing.Size(66, 19);
			this.checkPetCall.TabIndex = 95;
			this.checkPetCall.Text = "Call Pet";
			this.checkPetCall.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkPetCall.UncheckedState.BorderRadius = 0;
			this.checkPetCall.UncheckedState.BorderThickness = 1;
			this.checkPetCall.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkPetCall.UseVisualStyleBackColor = false;
			this.checkPetCall.CheckedChanged += new global::System.EventHandler(this.checkPetCall_CheckedChanged);
			this.lblPetCallInfo.AutoSize = true;
			this.lblPetCallInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetCallInfo.Enabled = false;
			this.lblPetCallInfo.Location = new global::System.Drawing.Point(22, 67);
			this.lblPetCallInfo.Name = "lblPetCallInfo";
			this.lblPetCallInfo.Size = new global::System.Drawing.Size(35, 15);
			this.lblPetCallInfo.TabIndex = 68;
			this.lblPetCallInfo.Text = "Spell:";
			this.grpPetCombatReact.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpPetCombatReact.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetCombatReact.Controls.Add(this.btnPetCombatReactTooltip);
			this.grpPetCombatReact.Controls.Add(this.checkPetCombatReactStepBack);
			this.grpPetCombatReact.Controls.Add(this.selectPetCombatReactSpell);
			this.grpPetCombatReact.Controls.Add(this.sepPetCombatReact1);
			this.grpPetCombatReact.Controls.Add(this.lblPetCombatReactInfo);
			this.grpPetCombatReact.Controls.Add(this.checkPetCombatReact);
			this.grpPetCombatReact.Controls.Add(this.lblPetCombatReactSpell);
			this.grpPetCombatReact.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetCombatReact.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpPetCombatReact.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpPetCombatReact.ForeColor = global::System.Drawing.Color.White;
			this.grpPetCombatReact.Location = new global::System.Drawing.Point(14, 687);
			this.grpPetCombatReact.Name = "grpPetCombatReact";
			this.grpPetCombatReact.Size = new global::System.Drawing.Size(807, 229);
			this.grpPetCombatReact.TabIndex = 94;
			this.btnPetCombatReactTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnPetCombatReactTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPetCombatReactTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnPetCombatReactTooltip.BorderRadius = 4;
			this.btnPetCombatReactTooltip.BorderThickness = 1;
			this.btnPetCombatReactTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPetCombatReactTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnPetCombatReactTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnPetCombatReactTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPetCombatReactTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPetCombatReactTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPetCombatReactTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnPetCombatReactTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnPetCombatReactTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnPetCombatReactTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPetCombatReactTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnPetCombatReactTooltip.Location = new global::System.Drawing.Point(760, 8);
			this.btnPetCombatReactTooltip.Name = "btnPetCombatReactTooltip";
			this.btnPetCombatReactTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnPetCombatReactTooltip.TabIndex = 101;
			this.btnPetCombatReactTooltip.Click += new global::System.EventHandler(this.btnPetCombatReactTooltip_Click);
			this.checkPetCombatReactStepBack.Animated = true;
			this.checkPetCombatReactStepBack.AutoSize = true;
			this.checkPetCombatReactStepBack.BackColor = global::System.Drawing.Color.Transparent;
			this.checkPetCombatReactStepBack.Checked = true;
			this.checkPetCombatReactStepBack.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombatReactStepBack.CheckedState.BorderRadius = 0;
			this.checkPetCombatReactStepBack.CheckedState.BorderThickness = 0;
			this.checkPetCombatReactStepBack.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombatReactStepBack.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.checkPetCombatReactStepBack.Enabled = false;
			this.checkPetCombatReactStepBack.Location = new global::System.Drawing.Point(180, 187);
			this.checkPetCombatReactStepBack.Name = "checkPetCombatReactStepBack";
			this.checkPetCombatReactStepBack.Size = new global::System.Drawing.Size(159, 19);
			this.checkPetCombatReactStepBack.TabIndex = 100;
			this.checkPetCombatReactStepBack.Text = "Step back after execution";
			this.checkPetCombatReactStepBack.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkPetCombatReactStepBack.UncheckedState.BorderRadius = 0;
			this.checkPetCombatReactStepBack.UncheckedState.BorderThickness = 1;
			this.checkPetCombatReactStepBack.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkPetCombatReactStepBack.UseVisualStyleBackColor = false;
			this.selectPetCombatReactSpell.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPetCombatReactSpell.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPetCombatReactSpell.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPetCombatReactSpell.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPetCombatReactSpell.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPetCombatReactSpell.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPetCombatReactSpell.Enabled = false;
			this.selectPetCombatReactSpell.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPetCombatReactSpell.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPetCombatReactSpell.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPetCombatReactSpell.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPetCombatReactSpell.ForeColor = global::System.Drawing.Color.White;
			this.selectPetCombatReactSpell.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPetCombatReactSpell.ItemHeight = 24;
			this.selectPetCombatReactSpell.Items.AddRange(new object[]
			{
				"By ID",
				"By Name"
			});
			this.selectPetCombatReactSpell.Location = new global::System.Drawing.Point(180, 142);
			this.selectPetCombatReactSpell.Name = "selectPetCombatReactSpell";
			this.selectPetCombatReactSpell.Size = new global::System.Drawing.Size(540, 30);
			this.selectPetCombatReactSpell.TabIndex = 99;
			this.selectPetCombatReactSpell.SelectedIndexChanged += new global::System.EventHandler(this.selectPetCombatReactSpell_SelectedIndexChanged);
			this.sepPetCombatReact1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepPetCombatReact1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepPetCombatReact1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepPetCombatReact1.Location = new global::System.Drawing.Point(17, 113);
			this.sepPetCombatReact1.Name = "sepPetCombatReact1";
			this.sepPetCombatReact1.Size = new global::System.Drawing.Size(772, 10);
			this.sepPetCombatReact1.TabIndex = 98;
			this.lblPetCombatReactInfo.AutoSize = true;
			this.lblPetCombatReactInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetCombatReactInfo.Enabled = false;
			this.lblPetCombatReactInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblPetCombatReactInfo.Location = new global::System.Drawing.Point(22, 65);
			this.lblPetCombatReactInfo.Name = "lblPetCombatReactInfo";
			this.lblPetCombatReactInfo.Size = new global::System.Drawing.Size(319, 30);
			this.lblPetCombatReactInfo.TabIndex = 97;
			this.lblPetCombatReactInfo.Text = "This Spell is executed as soon as an attacker focuses on you\r\nwhile \"Pet should start Combat\" is active.";
			this.checkPetCombatReact.Animated = true;
			this.checkPetCombatReact.AutoSize = true;
			this.checkPetCombatReact.BackColor = global::System.Drawing.Color.Transparent;
			this.checkPetCombatReact.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombatReact.CheckedState.BorderRadius = 0;
			this.checkPetCombatReact.CheckedState.BorderThickness = 0;
			this.checkPetCombatReact.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombatReact.Enabled = false;
			this.checkPetCombatReact.Location = new global::System.Drawing.Point(12, 11);
			this.checkPetCombatReact.Name = "checkPetCombatReact";
			this.checkPetCombatReact.Size = new global::System.Drawing.Size(119, 19);
			this.checkPetCombatReact.TabIndex = 95;
			this.checkPetCombatReact.Text = "React to attackers";
			this.checkPetCombatReact.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkPetCombatReact.UncheckedState.BorderRadius = 0;
			this.checkPetCombatReact.UncheckedState.BorderThickness = 1;
			this.checkPetCombatReact.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkPetCombatReact.UseVisualStyleBackColor = false;
			this.checkPetCombatReact.CheckedChanged += new global::System.EventHandler(this.checkPetCombatReact_CheckedChanged);
			this.lblPetCombatReactSpell.AutoSize = true;
			this.lblPetCombatReactSpell.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetCombatReactSpell.Enabled = false;
			this.lblPetCombatReactSpell.Location = new global::System.Drawing.Point(22, 150);
			this.lblPetCombatReactSpell.Name = "lblPetCombatReactSpell";
			this.lblPetCombatReactSpell.Size = new global::System.Drawing.Size(35, 15);
			this.lblPetCombatReactSpell.TabIndex = 68;
			this.lblPetCombatReactSpell.Text = "Spell:";
			this.grpPetRevive.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpPetRevive.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetRevive.Controls.Add(this.btnPetReviveTooltip);
			this.grpPetRevive.Controls.Add(this.selectPetReviveSpell);
			this.grpPetRevive.Controls.Add(this.checkPetRevive);
			this.grpPetRevive.Controls.Add(this.lblPetReviveSpell);
			this.grpPetRevive.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetRevive.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpPetRevive.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpPetRevive.ForeColor = global::System.Drawing.Color.White;
			this.grpPetRevive.Location = new global::System.Drawing.Point(14, 139);
			this.grpPetRevive.Name = "grpPetRevive";
			this.grpPetRevive.Size = new global::System.Drawing.Size(807, 110);
			this.grpPetRevive.TabIndex = 92;
			this.btnPetReviveTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnPetReviveTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnPetReviveTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnPetReviveTooltip.BorderRadius = 4;
			this.btnPetReviveTooltip.BorderThickness = 1;
			this.btnPetReviveTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnPetReviveTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnPetReviveTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnPetReviveTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPetReviveTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnPetReviveTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPetReviveTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnPetReviveTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnPetReviveTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnPetReviveTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPetReviveTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnPetReviveTooltip.Location = new global::System.Drawing.Point(760, 8);
			this.btnPetReviveTooltip.Name = "btnPetReviveTooltip";
			this.btnPetReviveTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnPetReviveTooltip.TabIndex = 100;
			this.btnPetReviveTooltip.Click += new global::System.EventHandler(this.btnPetReviveTooltip_Click);
			this.selectPetReviveSpell.BackColor = global::System.Drawing.Color.Transparent;
			this.selectPetReviveSpell.BorderColor = global::System.Drawing.Color.Gray;
			this.selectPetReviveSpell.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectPetReviveSpell.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectPetReviveSpell.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectPetReviveSpell.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectPetReviveSpell.Enabled = false;
			this.selectPetReviveSpell.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectPetReviveSpell.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPetReviveSpell.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectPetReviveSpell.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.selectPetReviveSpell.ForeColor = global::System.Drawing.Color.White;
			this.selectPetReviveSpell.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectPetReviveSpell.ItemHeight = 24;
			this.selectPetReviveSpell.Items.AddRange(new object[]
			{
				"By ID",
				"By Name"
			});
			this.selectPetReviveSpell.Location = new global::System.Drawing.Point(180, 60);
			this.selectPetReviveSpell.Name = "selectPetReviveSpell";
			this.selectPetReviveSpell.Size = new global::System.Drawing.Size(540, 30);
			this.selectPetReviveSpell.TabIndex = 94;
			this.selectPetReviveSpell.SelectedIndexChanged += new global::System.EventHandler(this.selectPetReviveSpell_SelectedIndexChanged);
			this.checkPetRevive.Animated = true;
			this.checkPetRevive.AutoSize = true;
			this.checkPetRevive.BackColor = global::System.Drawing.Color.Transparent;
			this.checkPetRevive.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetRevive.CheckedState.BorderRadius = 0;
			this.checkPetRevive.CheckedState.BorderThickness = 0;
			this.checkPetRevive.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetRevive.Location = new global::System.Drawing.Point(12, 11);
			this.checkPetRevive.Name = "checkPetRevive";
			this.checkPetRevive.Size = new global::System.Drawing.Size(80, 19);
			this.checkPetRevive.TabIndex = 95;
			this.checkPetRevive.Text = "Revive Pet";
			this.checkPetRevive.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkPetRevive.UncheckedState.BorderRadius = 0;
			this.checkPetRevive.UncheckedState.BorderThickness = 1;
			this.checkPetRevive.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkPetRevive.UseVisualStyleBackColor = false;
			this.checkPetRevive.CheckedChanged += new global::System.EventHandler(this.checkPetRevive_CheckedChanged);
			this.lblPetReviveSpell.AutoSize = true;
			this.lblPetReviveSpell.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetReviveSpell.Enabled = false;
			this.lblPetReviveSpell.Location = new global::System.Drawing.Point(22, 67);
			this.lblPetReviveSpell.Name = "lblPetReviveSpell";
			this.lblPetReviveSpell.Size = new global::System.Drawing.Size(35, 15);
			this.lblPetReviveSpell.TabIndex = 68;
			this.lblPetReviveSpell.Text = "Spell:";
			this.grpPetCombat.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpPetCombat.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetCombat.Controls.Add(this.checkPetCombatParallel);
			this.grpPetCombat.Controls.Add(this.lblPetCombatWait2);
			this.grpPetCombat.Controls.Add(this.sepPetCombat1);
			this.grpPetCombat.Controls.Add(this.lblPetCombatKeybind);
			this.grpPetCombat.Controls.Add(this.txtPetCombatWait);
			this.grpPetCombat.Controls.Add(this.checkPetCombat);
			this.grpPetCombat.Controls.Add(this.lblPetCombatWait1);
			this.grpPetCombat.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpPetCombat.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpPetCombat.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpPetCombat.ForeColor = global::System.Drawing.Color.White;
			this.grpPetCombat.Location = new global::System.Drawing.Point(14, 459);
			this.grpPetCombat.Name = "grpPetCombat";
			this.grpPetCombat.Size = new global::System.Drawing.Size(807, 213);
			this.grpPetCombat.TabIndex = 93;
			this.checkPetCombatParallel.Animated = true;
			this.checkPetCombatParallel.AutoSize = true;
			this.checkPetCombatParallel.BackColor = global::System.Drawing.Color.Transparent;
			this.checkPetCombatParallel.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombatParallel.CheckedState.BorderRadius = 0;
			this.checkPetCombatParallel.CheckedState.BorderThickness = 0;
			this.checkPetCombatParallel.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombatParallel.Enabled = false;
			this.checkPetCombatParallel.Location = new global::System.Drawing.Point(180, 173);
			this.checkPetCombatParallel.Name = "checkPetCombatParallel";
			this.checkPetCombatParallel.Size = new global::System.Drawing.Size(294, 19);
			this.checkPetCombatParallel.TabIndex = 100;
			this.checkPetCombatParallel.Text = "Do not wait. (Start immediately with own rotation.)";
			this.checkPetCombatParallel.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkPetCombatParallel.UncheckedState.BorderRadius = 0;
			this.checkPetCombatParallel.UncheckedState.BorderThickness = 1;
			this.checkPetCombatParallel.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkPetCombatParallel.UseVisualStyleBackColor = false;
			this.checkPetCombatParallel.CheckedChanged += new global::System.EventHandler(this.checkPetCombatParallel_CheckedChanged);
			this.lblPetCombatWait2.AutoSize = true;
			this.lblPetCombatWait2.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetCombatWait2.Enabled = false;
			this.lblPetCombatWait2.Location = new global::System.Drawing.Point(335, 136);
			this.lblPetCombatWait2.Name = "lblPetCombatWait2";
			this.lblPetCombatWait2.Size = new global::System.Drawing.Size(146, 15);
			this.lblPetCombatWait2.TabIndex = 99;
			this.lblPetCombatWait2.Text = "sec. after Pet has attacked.";
			this.sepPetCombat1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.sepPetCombat1.BackColor = global::System.Drawing.Color.Transparent;
			this.sepPetCombat1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sepPetCombat1.Location = new global::System.Drawing.Point(17, 99);
			this.sepPetCombat1.Name = "sepPetCombat1";
			this.sepPetCombat1.Size = new global::System.Drawing.Size(772, 10);
			this.sepPetCombat1.TabIndex = 98;
			this.lblPetCombatKeybind.AutoSize = true;
			this.lblPetCombatKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetCombatKeybind.Enabled = false;
			this.lblPetCombatKeybind.ForeColor = global::System.Drawing.Color.White;
			this.lblPetCombatKeybind.Location = new global::System.Drawing.Point(22, 65);
			this.lblPetCombatKeybind.Name = "lblPetCombatKeybind";
			this.lblPetCombatKeybind.Size = new global::System.Drawing.Size(62, 15);
			this.lblPetCombatKeybind.TabIndex = 97;
			this.lblPetCombatKeybind.Text = "[KEYBIND]";
			this.txtPetCombatWait.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPetCombatWait.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPetCombatWait.DefaultText = "3";
			this.txtPetCombatWait.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtPetCombatWait.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtPetCombatWait.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPetCombatWait.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPetCombatWait.Enabled = false;
			this.txtPetCombatWait.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtPetCombatWait.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtPetCombatWait.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPetCombatWait.ForeColor = global::System.Drawing.Color.White;
			this.txtPetCombatWait.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtPetCombatWait.Location = new global::System.Drawing.Point(180, 128);
			this.txtPetCombatWait.MaxLength = 3;
			this.txtPetCombatWait.Name = "txtPetCombatWait";
			this.txtPetCombatWait.PasswordChar = '\0';
			this.txtPetCombatWait.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtPetCombatWait.PlaceholderText = "";
			this.txtPetCombatWait.SelectedText = "";
			this.txtPetCombatWait.Size = new global::System.Drawing.Size(140, 30);
			this.txtPetCombatWait.TabIndex = 96;
			this.checkPetCombat.Animated = true;
			this.checkPetCombat.AutoSize = true;
			this.checkPetCombat.BackColor = global::System.Drawing.Color.Transparent;
			this.checkPetCombat.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombat.CheckedState.BorderRadius = 0;
			this.checkPetCombat.CheckedState.BorderThickness = 0;
			this.checkPetCombat.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkPetCombat.Location = new global::System.Drawing.Point(12, 11);
			this.checkPetCombat.Name = "checkPetCombat";
			this.checkPetCombat.Size = new global::System.Drawing.Size(154, 19);
			this.checkPetCombat.TabIndex = 95;
			this.checkPetCombat.Text = "Pet should start Combat";
			this.checkPetCombat.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkPetCombat.UncheckedState.BorderRadius = 0;
			this.checkPetCombat.UncheckedState.BorderThickness = 1;
			this.checkPetCombat.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkPetCombat.UseVisualStyleBackColor = false;
			this.checkPetCombat.CheckedChanged += new global::System.EventHandler(this.checkPetCombat_CheckedChanged);
			this.lblPetCombatWait1.AutoSize = true;
			this.lblPetCombatWait1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPetCombatWait1.Enabled = false;
			this.lblPetCombatWait1.Location = new global::System.Drawing.Point(22, 136);
			this.lblPetCombatWait1.Name = "lblPetCombatWait1";
			this.lblPetCombatWait1.Size = new global::System.Drawing.Size(49, 15);
			this.lblPetCombatWait1.TabIndex = 68;
			this.lblPetCombatWait1.Text = "Wait for";
			this.tabEnchantment.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.tabEnchantment.Controls.Add(this.panelTabEnchantment);
			this.tabEnchantment.Location = new global::System.Drawing.Point(144, 4);
			this.tabEnchantment.Name = "tabEnchantment";
			this.tabEnchantment.Size = new global::System.Drawing.Size(868, 429);
			this.tabEnchantment.TabIndex = 4;
			this.tabEnchantment.Text = "Enchantment";
			this.panelTabEnchantment.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTabEnchantment.AutoScroll = true;
			this.panelTabEnchantment.AutoScrollMargin = new global::System.Drawing.Size(0, 14);
			this.panelTabEnchantment.BackColor = global::System.Drawing.Color.Transparent;
			this.panelTabEnchantment.Controls.Add(this.grpEnchantmentOffHand);
			this.panelTabEnchantment.Controls.Add(this.grpEnchantmentMainHand);
			this.panelTabEnchantment.FillColor = global::System.Drawing.Color.Transparent;
			this.panelTabEnchantment.Location = new global::System.Drawing.Point(0, 0);
			this.panelTabEnchantment.Name = "panelTabEnchantment";
			this.panelTabEnchantment.Size = new global::System.Drawing.Size(868, 429);
			this.panelTabEnchantment.TabIndex = 98;
			this.grpEnchantmentOffHand.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpEnchantmentOffHand.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpEnchantmentOffHand.Controls.Add(this.lblEnchantmentOffHandKeybind);
			this.grpEnchantmentOffHand.Controls.Add(this.checkEnchantmentOffHand);
			this.grpEnchantmentOffHand.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpEnchantmentOffHand.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpEnchantmentOffHand.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpEnchantmentOffHand.ForeColor = global::System.Drawing.Color.White;
			this.grpEnchantmentOffHand.Location = new global::System.Drawing.Point(14, 133);
			this.grpEnchantmentOffHand.Name = "grpEnchantmentOffHand";
			this.grpEnchantmentOffHand.Size = new global::System.Drawing.Size(839, 104);
			this.grpEnchantmentOffHand.TabIndex = 97;
			this.lblEnchantmentOffHandKeybind.AutoSize = true;
			this.lblEnchantmentOffHandKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblEnchantmentOffHandKeybind.Enabled = false;
			this.lblEnchantmentOffHandKeybind.ForeColor = global::System.Drawing.Color.White;
			this.lblEnchantmentOffHandKeybind.Location = new global::System.Drawing.Point(22, 65);
			this.lblEnchantmentOffHandKeybind.Name = "lblEnchantmentOffHandKeybind";
			this.lblEnchantmentOffHandKeybind.Size = new global::System.Drawing.Size(62, 15);
			this.lblEnchantmentOffHandKeybind.TabIndex = 97;
			this.lblEnchantmentOffHandKeybind.Text = "[KEYBIND]";
			this.checkEnchantmentOffHand.Animated = true;
			this.checkEnchantmentOffHand.AutoSize = true;
			this.checkEnchantmentOffHand.BackColor = global::System.Drawing.Color.Transparent;
			this.checkEnchantmentOffHand.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkEnchantmentOffHand.CheckedState.BorderRadius = 0;
			this.checkEnchantmentOffHand.CheckedState.BorderThickness = 0;
			this.checkEnchantmentOffHand.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkEnchantmentOffHand.Location = new global::System.Drawing.Point(12, 11);
			this.checkEnchantmentOffHand.Name = "checkEnchantmentOffHand";
			this.checkEnchantmentOffHand.Size = new global::System.Drawing.Size(75, 19);
			this.checkEnchantmentOffHand.TabIndex = 95;
			this.checkEnchantmentOffHand.Text = "Off Hand";
			this.checkEnchantmentOffHand.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkEnchantmentOffHand.UncheckedState.BorderRadius = 0;
			this.checkEnchantmentOffHand.UncheckedState.BorderThickness = 1;
			this.checkEnchantmentOffHand.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkEnchantmentOffHand.UseVisualStyleBackColor = false;
			this.checkEnchantmentOffHand.CheckedChanged += new global::System.EventHandler(this.checkEnchantmentOffHand_CheckedChanged);
			this.grpEnchantmentMainHand.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpEnchantmentMainHand.BorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpEnchantmentMainHand.Controls.Add(this.btnEnchantmentTooltip);
			this.grpEnchantmentMainHand.Controls.Add(this.lblEnchantmentMainHandKeybind);
			this.grpEnchantmentMainHand.Controls.Add(this.checkEnchantmentMainHand);
			this.grpEnchantmentMainHand.CustomBorderColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.grpEnchantmentMainHand.FillColor = global::System.Drawing.Color.FromArgb(48, 52, 56);
			this.grpEnchantmentMainHand.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpEnchantmentMainHand.ForeColor = global::System.Drawing.Color.White;
			this.grpEnchantmentMainHand.Location = new global::System.Drawing.Point(14, 14);
			this.grpEnchantmentMainHand.Name = "grpEnchantmentMainHand";
			this.grpEnchantmentMainHand.Size = new global::System.Drawing.Size(839, 104);
			this.grpEnchantmentMainHand.TabIndex = 96;
			this.btnEnchantmentTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnEnchantmentTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnEnchantmentTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnEnchantmentTooltip.BorderRadius = 4;
			this.btnEnchantmentTooltip.BorderThickness = 1;
			this.btnEnchantmentTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnEnchantmentTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnEnchantmentTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnEnchantmentTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnEnchantmentTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnEnchantmentTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnEnchantmentTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnEnchantmentTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnEnchantmentTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnEnchantmentTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnEnchantmentTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnEnchantmentTooltip.Location = new global::System.Drawing.Point(792, 8);
			this.btnEnchantmentTooltip.Name = "btnEnchantmentTooltip";
			this.btnEnchantmentTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnEnchantmentTooltip.TabIndex = 98;
			this.btnEnchantmentTooltip.Click += new global::System.EventHandler(this.btnEnchantmentTooltip_Click);
			this.lblEnchantmentMainHandKeybind.AutoSize = true;
			this.lblEnchantmentMainHandKeybind.BackColor = global::System.Drawing.Color.Transparent;
			this.lblEnchantmentMainHandKeybind.Enabled = false;
			this.lblEnchantmentMainHandKeybind.ForeColor = global::System.Drawing.Color.White;
			this.lblEnchantmentMainHandKeybind.Location = new global::System.Drawing.Point(22, 65);
			this.lblEnchantmentMainHandKeybind.Name = "lblEnchantmentMainHandKeybind";
			this.lblEnchantmentMainHandKeybind.Size = new global::System.Drawing.Size(62, 15);
			this.lblEnchantmentMainHandKeybind.TabIndex = 97;
			this.lblEnchantmentMainHandKeybind.Text = "[KEYBIND]";
			this.checkEnchantmentMainHand.Animated = true;
			this.checkEnchantmentMainHand.AutoSize = true;
			this.checkEnchantmentMainHand.BackColor = global::System.Drawing.Color.Transparent;
			this.checkEnchantmentMainHand.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkEnchantmentMainHand.CheckedState.BorderRadius = 0;
			this.checkEnchantmentMainHand.CheckedState.BorderThickness = 0;
			this.checkEnchantmentMainHand.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkEnchantmentMainHand.Location = new global::System.Drawing.Point(12, 11);
			this.checkEnchantmentMainHand.Name = "checkEnchantmentMainHand";
			this.checkEnchantmentMainHand.Size = new global::System.Drawing.Size(85, 19);
			this.checkEnchantmentMainHand.TabIndex = 95;
			this.checkEnchantmentMainHand.Text = "Main Hand";
			this.checkEnchantmentMainHand.UncheckedState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.checkEnchantmentMainHand.UncheckedState.BorderRadius = 0;
			this.checkEnchantmentMainHand.UncheckedState.BorderThickness = 1;
			this.checkEnchantmentMainHand.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.checkEnchantmentMainHand.UseVisualStyleBackColor = false;
			this.checkEnchantmentMainHand.CheckedChanged += new global::System.EventHandler(this.checkEnchantmentMainHand_CheckedChanged);
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(596, 38);
			this.panelTitle.TabIndex = 66;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(526, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(202, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Rotation Manager";
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(786, 578);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 71;
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
			this.lblProfileName.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblProfileName.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.lblProfileName.ForeColor = global::System.Drawing.Color.DeepSkyBlue;
			this.lblProfileName.Location = new global::System.Drawing.Point(24, 599);
			this.lblProfileName.Name = "lblProfileName";
			this.lblProfileName.Size = new global::System.Drawing.Size(708, 23);
			this.lblProfileName.TabIndex = 72;
			this.lblProfileName.Text = "[PROFILE NAME]";
			this.lblProfileName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblProfileName.Visible = false;
			this.btnGSEImportClearMacro.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnGSEImportClearMacro.BorderColor = global::System.Drawing.Color.FromArgb(74, 74, 74);
			this.btnGSEImportClearMacro.BorderThickness = 1;
			this.btnGSEImportClearMacro.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnGSEImportClearMacro.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnGSEImportClearMacro.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnGSEImportClearMacro.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnGSEImportClearMacro.FillColor = global::System.Drawing.Color.FromArgb(31, 37, 46);
			this.btnGSEImportClearMacro.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnGSEImportClearMacro.ForeColor = global::System.Drawing.Color.Gray;
			this.btnGSEImportClearMacro.HoverState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnGSEImportClearMacro.HoverState.FillColor = global::System.Drawing.Color.FromArgb(35, 42, 54);
			this.btnGSEImportClearMacro.Location = new global::System.Drawing.Point(25, 222);
			this.btnGSEImportClearMacro.Name = "btnGSEImportClearMacro";
			this.btnGSEImportClearMacro.Size = new global::System.Drawing.Size(130, 29);
			this.btnGSEImportClearMacro.TabIndex = 79;
			this.btnGSEImportClearMacro.Text = "Clear";
			this.btnGSEImportClearMacro.Click += new global::System.EventHandler(this.btnGSEImportClearMacro_Click);
			this.lblGSEImportStatus.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblGSEImportStatus.AutoEllipsis = true;
			this.lblGSEImportStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGSEImportStatus.Enabled = false;
			this.lblGSEImportStatus.Location = new global::System.Drawing.Point(232, 230);
			this.lblGSEImportStatus.Name = "lblGSEImportStatus";
			this.lblGSEImportStatus.Size = new global::System.Drawing.Size(336, 15);
			this.lblGSEImportStatus.TabIndex = 105;
			this.lblGSEImportStatus.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(1090, 661);
			base.Controls.Add(this.lblProfileName);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(1090, 645);
			base.Name = "frmRotation";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmRotation";
			base.Load += new global::System.EventHandler(this.frmRotation_Load);
			base.Shown += new global::System.EventHandler(this.frmRotation_Shown);
			base.VisibleChanged += new global::System.EventHandler(this.frmRotation_VisibleChanged);
			this.panelBox1.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.tabRotation.ResumeLayout(false);
			this.tabGSE.ResumeLayout(false);
			this.panelTabGSE.ResumeLayout(false);
			this.grpGSESettings.ResumeLayout(false);
			this.grpGSESettings.PerformLayout();
			this.grpGSEImportMacro.ResumeLayout(false);
			this.panelGSEImportMacro.ResumeLayout(false);
			this.tabSettings.ResumeLayout(false);
			this.panelTabSettings.ResumeLayout(false);
			this.grpSettingsSpells.ResumeLayout(false);
			this.grpSettingsSpells.PerformLayout();
			this.grpSettingsCharacter.ResumeLayout(false);
			this.grpSettingsCharacter.PerformLayout();
			this.grpSettingsDistances.ResumeLayout(false);
			this.grpSettingsDistances.PerformLayout();
			this.tabPet.ResumeLayout(false);
			this.panelTabPet.ResumeLayout(false);
			this.grpPetFeed.ResumeLayout(false);
			this.grpPetFeed.PerformLayout();
			this.grpPetCall.ResumeLayout(false);
			this.grpPetCall.PerformLayout();
			this.grpPetCombatReact.ResumeLayout(false);
			this.grpPetCombatReact.PerformLayout();
			this.grpPetRevive.ResumeLayout(false);
			this.grpPetRevive.PerformLayout();
			this.grpPetCombat.ResumeLayout(false);
			this.grpPetCombat.PerformLayout();
			this.tabEnchantment.ResumeLayout(false);
			this.panelTabEnchantment.ResumeLayout(false);
			this.grpEnchantmentOffHand.ResumeLayout(false);
			this.grpEnchantmentOffHand.PerformLayout();
			this.grpEnchantmentMainHand.ResumeLayout(false);
			this.grpEnchantmentMainHand.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000891 RID: 2193
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000892 RID: 2194
		private global::System.Windows.Forms.ListView listSpells;

		// Token: 0x04000893 RID: 2195
		private global::System.Windows.Forms.ColumnHeader listSpellsName;

		// Token: 0x04000894 RID: 2196
		private global::System.Windows.Forms.ColumnHeader listSpellsID;

		// Token: 0x04000895 RID: 2197
		private global::System.Windows.Forms.ColumnHeader listSpellsType;

		// Token: 0x04000896 RID: 2198
		private global::System.Windows.Forms.ColumnHeader listSpellsRequiredLevel;

		// Token: 0x04000897 RID: 2199
		private global::System.Windows.Forms.ColumnHeader listSpellsConditions;

		// Token: 0x04000898 RID: 2200
		private global::System.Windows.Forms.ColumnHeader listSpellsPrio;

		// Token: 0x04000899 RID: 2201
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400089A RID: 2202
		private global::Guna.UI2.WinForms.Guna2TabControl tabs;

		// Token: 0x0400089B RID: 2203
		private global::System.Windows.Forms.TabPage tabRotation;

		// Token: 0x0400089C RID: 2204
		private global::System.Windows.Forms.TabPage tabSettings;

		// Token: 0x0400089D RID: 2205
		private global::System.Windows.Forms.TabPage tabPet;

		// Token: 0x0400089E RID: 2206
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x0400089F RID: 2207
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x040008A0 RID: 2208
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x040008A1 RID: 2209
		private global::Guna.UI2.WinForms.Guna2Button btnAdd;

		// Token: 0x040008A2 RID: 2210
		private global::System.Windows.Forms.ComboBox selectSpells;

		// Token: 0x040008A3 RID: 2211
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsCharacter;

		// Token: 0x040008A4 RID: 2212
		private global::Guna.UI2.WinForms.Guna2ComboBox selectClassType;

		// Token: 0x040008A5 RID: 2213
		private global::Guna.UI2.WinForms.Guna2ComboBox selectClass;

		// Token: 0x040008A6 RID: 2214
		private global::System.Windows.Forms.Label lblSettingsCharacterClass;

		// Token: 0x040008A7 RID: 2215
		private global::System.Windows.Forms.Label lblSettingsCharacterClassType;

		// Token: 0x040008A8 RID: 2216
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsDistances;

		// Token: 0x040008A9 RID: 2217
		private global::System.Windows.Forms.Label lblPullDistanceYds;

		// Token: 0x040008AA RID: 2218
		private global::Guna.UI2.WinForms.Guna2TextBox txtPullDistance;

		// Token: 0x040008AB RID: 2219
		private global::System.Windows.Forms.Label lblPullDistance;

		// Token: 0x040008AC RID: 2220
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSettingsSpells;

		// Token: 0x040008AD RID: 2221
		private global::Guna.UI2.WinForms.Guna2ComboBox selectFindSpells;

		// Token: 0x040008AE RID: 2222
		private global::System.Windows.Forms.Label lblFindSpells;

		// Token: 0x040008AF RID: 2223
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPetCallSpell;

		// Token: 0x040008B0 RID: 2224
		private global::Guna.UI2.WinForms.Guna2GroupBox grpPetCall;

		// Token: 0x040008B1 RID: 2225
		private global::Guna.UI2.WinForms.Guna2CheckBox checkPetCall;

		// Token: 0x040008B2 RID: 2226
		private global::System.Windows.Forms.Label lblPetCallInfo;

		// Token: 0x040008B3 RID: 2227
		private global::Guna.UI2.WinForms.Guna2GroupBox grpPetRevive;

		// Token: 0x040008B4 RID: 2228
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPetReviveSpell;

		// Token: 0x040008B5 RID: 2229
		private global::Guna.UI2.WinForms.Guna2CheckBox checkPetRevive;

		// Token: 0x040008B6 RID: 2230
		private global::System.Windows.Forms.Label lblPetReviveSpell;

		// Token: 0x040008B7 RID: 2231
		private global::Guna.UI2.WinForms.Guna2GroupBox grpPetCombat;

		// Token: 0x040008B8 RID: 2232
		private global::Guna.UI2.WinForms.Guna2CheckBox checkPetCombat;

		// Token: 0x040008B9 RID: 2233
		private global::System.Windows.Forms.Label lblPetCombatWait1;

		// Token: 0x040008BA RID: 2234
		private global::Guna.UI2.WinForms.Guna2TextBox txtPetCombatWait;

		// Token: 0x040008BB RID: 2235
		private global::Guna.UI2.WinForms.Guna2Separator sepPetCombat1;

		// Token: 0x040008BC RID: 2236
		private global::System.Windows.Forms.Label lblPetCombatKeybind;

		// Token: 0x040008BD RID: 2237
		private global::System.Windows.Forms.Label lblPetCombatWait2;

		// Token: 0x040008BE RID: 2238
		private global::Guna.UI2.WinForms.Guna2GroupBox grpPetCombatReact;

		// Token: 0x040008BF RID: 2239
		private global::Guna.UI2.WinForms.Guna2Separator sepPetCombatReact1;

		// Token: 0x040008C0 RID: 2240
		private global::System.Windows.Forms.Label lblPetCombatReactInfo;

		// Token: 0x040008C1 RID: 2241
		private global::Guna.UI2.WinForms.Guna2CheckBox checkPetCombatReact;

		// Token: 0x040008C2 RID: 2242
		private global::System.Windows.Forms.Label lblPetCombatReactSpell;

		// Token: 0x040008C3 RID: 2243
		private global::Guna.UI2.WinForms.Guna2ComboBox selectPetCombatReactSpell;

		// Token: 0x040008C4 RID: 2244
		private global::Guna.UI2.WinForms.Guna2CheckBox checkPetCombatReactStepBack;

		// Token: 0x040008C5 RID: 2245
		private global::Guna.UI2.WinForms.Guna2CheckBox checkPetCombatParallel;

		// Token: 0x040008C6 RID: 2246
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x040008C7 RID: 2247
		private global::Guna.UI2.WinForms.Guna2Button btnSave;

		// Token: 0x040008C8 RID: 2248
		private global::Guna.UI2.WinForms.Guna2GroupBox grpPetFeed;

		// Token: 0x040008C9 RID: 2249
		private global::System.Windows.Forms.Label lblPetFeedMinutes2;

		// Token: 0x040008CA RID: 2250
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x040008CB RID: 2251
		private global::System.Windows.Forms.Label lblPetFeedKeybind;

		// Token: 0x040008CC RID: 2252
		private global::Guna.UI2.WinForms.Guna2TextBox txtPetFeedMinutes;

		// Token: 0x040008CD RID: 2253
		private global::Guna.UI2.WinForms.Guna2CheckBox checkPetFeed;

		// Token: 0x040008CE RID: 2254
		private global::System.Windows.Forms.Label lblPetFeedMinutes1;

		// Token: 0x040008CF RID: 2255
		private global::System.Windows.Forms.TabPage tabEnchantment;

		// Token: 0x040008D0 RID: 2256
		private global::Guna.UI2.WinForms.Guna2GroupBox grpEnchantmentOffHand;

		// Token: 0x040008D1 RID: 2257
		private global::System.Windows.Forms.Label lblEnchantmentOffHandKeybind;

		// Token: 0x040008D2 RID: 2258
		private global::Guna.UI2.WinForms.Guna2CheckBox checkEnchantmentOffHand;

		// Token: 0x040008D3 RID: 2259
		private global::Guna.UI2.WinForms.Guna2GroupBox grpEnchantmentMainHand;

		// Token: 0x040008D4 RID: 2260
		private global::System.Windows.Forms.Label lblEnchantmentMainHandKeybind;

		// Token: 0x040008D5 RID: 2261
		private global::Guna.UI2.WinForms.Guna2CheckBox checkEnchantmentMainHand;

		// Token: 0x040008D6 RID: 2262
		private global::Guna.UI2.WinForms.Guna2Panel panelTabSettings;

		// Token: 0x040008D7 RID: 2263
		private global::Guna.UI2.WinForms.Guna2Panel panelTabPet;

		// Token: 0x040008D8 RID: 2264
		private global::Guna.UI2.WinForms.Guna2Panel panelTabEnchantment;

		// Token: 0x040008D9 RID: 2265
		private global::System.Windows.Forms.Label lblProfileName;

		// Token: 0x040008DA RID: 2266
		private global::Guna.UI2.WinForms.Guna2Button btnRotationTooltip;

		// Token: 0x040008DB RID: 2267
		private global::Guna.UI2.WinForms.Guna2Button btnSettingsDistancesTooltip;

		// Token: 0x040008DC RID: 2268
		private global::Guna.UI2.WinForms.Guna2Button btnSettingsSpellsTooltip;

		// Token: 0x040008DD RID: 2269
		private global::Guna.UI2.WinForms.Guna2Button btnEnchantmentTooltip;

		// Token: 0x040008DE RID: 2270
		private global::Guna.UI2.WinForms.Guna2Button btnPetCallTooltip;

		// Token: 0x040008DF RID: 2271
		private global::Guna.UI2.WinForms.Guna2Button btnPetReviveTooltip;

		// Token: 0x040008E0 RID: 2272
		private global::Guna.UI2.WinForms.Guna2Button btnPetCombatReactTooltip;

		// Token: 0x040008E1 RID: 2273
		private global::Guna.UI2.WinForms.Guna2Button btnReload;

		// Token: 0x040008E2 RID: 2274
		private global::Guna.UI2.WinForms.Guna2ComboBox selectOptions;

		// Token: 0x040008E3 RID: 2275
		private global::System.Windows.Forms.Label lblRotationLoading;

		// Token: 0x040008E4 RID: 2276
		private global::System.Windows.Forms.TabPage tabGSE;

		// Token: 0x040008E5 RID: 2277
		private global::Guna.UI2.WinForms.Guna2GroupBox grpGSESettings;

		// Token: 0x040008E6 RID: 2278
		private global::System.Windows.Forms.Label lblGSESettingsClickDelay;

		// Token: 0x040008E7 RID: 2279
		private global::Guna.UI2.WinForms.Guna2CheckBox checkGSE;

		// Token: 0x040008E8 RID: 2280
		private global::Guna.UI2.WinForms.Guna2TextBox txtGSESettingsClickDelay;

		// Token: 0x040008E9 RID: 2281
		private global::System.Windows.Forms.Label lblGSESettingsClickDelayMS;

		// Token: 0x040008EA RID: 2282
		private global::Guna.UI2.WinForms.Guna2GroupBox grpGSEImportMacro;

		// Token: 0x040008EB RID: 2283
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x040008EC RID: 2284
		private global::Guna.UI2.WinForms.Guna2Panel panelGSEImportMacro;

		// Token: 0x040008ED RID: 2285
		private global::System.Windows.Forms.RichTextBox richGSEImportMacro;

		// Token: 0x040008EE RID: 2286
		private global::Guna.UI2.WinForms.Guna2Button btnGSEImportMacro;

		// Token: 0x040008EF RID: 2287
		private global::Guna.UI2.WinForms.Guna2Panel panelTabGSE;

		// Token: 0x040008F0 RID: 2288
		private global::System.Windows.Forms.Label lblGSESettingsKeybindData;

		// Token: 0x040008F1 RID: 2289
		private global::System.Windows.Forms.Label lblGSESettingsKeybind;

		// Token: 0x040008F2 RID: 2290
		private global::Guna.UI2.WinForms.Guna2Button btnGSEImportClearMacro;

		// Token: 0x040008F3 RID: 2291
		private global::System.Windows.Forms.Label lblGSEImportStatus;
	}
}
