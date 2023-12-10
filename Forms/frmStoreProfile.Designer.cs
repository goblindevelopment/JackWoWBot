namespace Jack.Forms
{
	// Token: 0x0200007A RID: 122
	public partial class frmStoreProfile : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B58 RID: 2904 RVA: 0x00699AB4 File Offset: 0x00697CB4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00699AE0 File Offset: 0x00697CE0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmStoreProfile));
			this.panelProfile = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelPrice = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelPriceCoins = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblPrice = new global::System.Windows.Forms.Label();
			this.panelMore = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpContact = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblAboutEmailData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblAboutEmail = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblAboutDiscordData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblAboutDiscord = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblAboutStoreNameData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblAboutStoreName = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelContactSpacer = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelNoRequirements = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelModules = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblNoRequirementsData = new global::System.Windows.Forms.Label();
			this.panelNoRequirementsSpacer = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpRequirements = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblRequiredDescriptionMore = new global::System.Windows.Forms.Label();
			this.lblRequiredDescription = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblRequiredDescriptionData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblRequiredSkillData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblRequiredSkill = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblRequiredLevelData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblRequiredLevel = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelAlreadyPurchasedSpacer = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelAlreadyPurchased = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblAlreadyPurchased = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelInfo = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblInfoFactionData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.sepInfo2 = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.sepInfo1 = new global::Guna.UI2.WinForms.Guna2VSeparator();
			this.panelProfileFactions = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblInfoClassData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblInfoFactions = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblInfoType = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblInfoProfileType = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.grpDescription = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.lblDisplayName = new global::System.Windows.Forms.Label();
			this.lblDescriptionMore = new global::System.Windows.Forms.Label();
			this.lblDescription = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblInfoProfileTypeData = new global::System.Windows.Forms.Label();
			this.lblInfoGamesData = new global::System.Windows.Forms.Label();
			this.imgPriceCoin = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgBundle = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnBuy = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgModuleDungeon = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgModuleGather = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgFactionAlliance = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgFactionHorde = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgGames = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgLoading_4 = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.img_4 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgLoading_3 = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.img_3 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgLoading_2 = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.img_2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.imgLoading_1 = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.img_1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelProfile.SuspendLayout();
			this.panelPrice.SuspendLayout();
			this.panelPriceCoins.SuspendLayout();
			this.panelMore.SuspendLayout();
			this.grpContact.SuspendLayout();
			this.panelNoRequirements.SuspendLayout();
			this.panelModules.SuspendLayout();
			this.grpRequirements.SuspendLayout();
			this.panelAlreadyPurchased.SuspendLayout();
			this.panelInfo.SuspendLayout();
			this.panelProfileFactions.SuspendLayout();
			this.grpDescription.SuspendLayout();
			this.imgPriceCoin.BeginInit();
			this.imgBundle.BeginInit();
			this.panelBtnSave.SuspendLayout();
			this.imgModuleDungeon.BeginInit();
			this.imgModuleGather.BeginInit();
			this.imgFactionAlliance.BeginInit();
			this.imgFactionHorde.BeginInit();
			this.imgGames.BeginInit();
			this.img_4.BeginInit();
			this.img_3.BeginInit();
			this.img_2.BeginInit();
			this.img_1.BeginInit();
			base.SuspendLayout();
			this.panelProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelProfile.AutoScroll = true;
			this.panelProfile.AutoScrollMargin = new global::System.Drawing.Size(0, 8);
			this.panelProfile.Controls.Add(this.panelPrice);
			this.panelProfile.Controls.Add(this.imgBundle);
			this.panelProfile.Controls.Add(this.panelBtnSave);
			this.panelProfile.Controls.Add(this.panelMore);
			this.panelProfile.Controls.Add(this.panelInfo);
			this.panelProfile.Controls.Add(this.grpDescription);
			this.panelProfile.Controls.Add(this.imgLoading_4);
			this.panelProfile.Controls.Add(this.img_4);
			this.panelProfile.Controls.Add(this.imgLoading_3);
			this.panelProfile.Controls.Add(this.img_3);
			this.panelProfile.Controls.Add(this.imgLoading_2);
			this.panelProfile.Controls.Add(this.img_2);
			this.panelProfile.Controls.Add(this.imgLoading_1);
			this.panelProfile.Controls.Add(this.img_1);
			this.panelProfile.FillColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelProfile.Location = new global::System.Drawing.Point(8, 0);
			this.panelProfile.Name = "panelProfile";
			this.panelProfile.Size = new global::System.Drawing.Size(773, 1043);
			this.panelProfile.TabIndex = 4;
			this.panelPrice.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelPrice.BackColor = global::System.Drawing.Color.Transparent;
			this.panelPrice.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelPrice.BorderRadius = 4;
			this.panelPrice.BorderThickness = 1;
			this.panelPrice.Controls.Add(this.panelPriceCoins);
			this.panelPrice.CustomBorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelPrice.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelPrice.Location = new global::System.Drawing.Point(318, 448);
			this.panelPrice.Name = "panelPrice";
			this.panelPrice.ShadowDecoration.Color = global::System.Drawing.Color.White;
			this.panelPrice.ShadowDecoration.Depth = 8;
			this.panelPrice.Size = new global::System.Drawing.Size(124, 50);
			this.panelPrice.TabIndex = 73;
			this.panelPriceCoins.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelPriceCoins.BackColor = global::System.Drawing.Color.Transparent;
			this.panelPriceCoins.Controls.Add(this.lblPrice);
			this.panelPriceCoins.Controls.Add(this.imgPriceCoin);
			this.panelPriceCoins.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.panelPriceCoins.FillColor = global::System.Drawing.Color.Transparent;
			this.panelPriceCoins.Location = new global::System.Drawing.Point(25, 13);
			this.panelPriceCoins.Name = "panelPriceCoins";
			this.panelPriceCoins.Size = new global::System.Drawing.Size(71, 24);
			this.panelPriceCoins.TabIndex = 61;
			this.lblPrice.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblPrice.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPrice.Font = new global::System.Drawing.Font("Segoe UI", 9.5f);
			this.lblPrice.ForeColor = global::System.Drawing.Color.Goldenrod;
			this.lblPrice.Location = new global::System.Drawing.Point(4, 3);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new global::System.Drawing.Size(43, 15);
			this.lblPrice.TabIndex = 61;
			this.lblPrice.Text = "0";
			this.lblPrice.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.panelMore.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelMore.BackColor = global::System.Drawing.Color.Transparent;
			this.panelMore.BorderColor = global::System.Drawing.Color.Transparent;
			this.panelMore.BorderRadius = 4;
			this.panelMore.BorderThickness = 1;
			this.panelMore.Controls.Add(this.grpContact);
			this.panelMore.Controls.Add(this.panelContactSpacer);
			this.panelMore.Controls.Add(this.panelNoRequirements);
			this.panelMore.Controls.Add(this.panelNoRequirementsSpacer);
			this.panelMore.Controls.Add(this.grpRequirements);
			this.panelMore.Controls.Add(this.panelAlreadyPurchasedSpacer);
			this.panelMore.Controls.Add(this.panelAlreadyPurchased);
			this.panelMore.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.panelMore.FillColor = global::System.Drawing.Color.Transparent;
			this.panelMore.Location = new global::System.Drawing.Point(8, 506);
			this.panelMore.Name = "panelMore";
			this.panelMore.Size = new global::System.Drawing.Size(757, 528);
			this.panelMore.TabIndex = 13;
			this.grpContact.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpContact.BorderRadius = 4;
			this.grpContact.Controls.Add(this.lblAboutEmailData);
			this.grpContact.Controls.Add(this.lblAboutEmail);
			this.grpContact.Controls.Add(this.lblAboutDiscordData);
			this.grpContact.Controls.Add(this.lblAboutDiscord);
			this.grpContact.Controls.Add(this.lblAboutStoreNameData);
			this.grpContact.Controls.Add(this.lblAboutStoreName);
			this.grpContact.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpContact.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.grpContact.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpContact.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpContact.ForeColor = global::System.Drawing.Color.White;
			this.grpContact.Location = new global::System.Drawing.Point(0, 377);
			this.grpContact.Name = "grpContact";
			this.grpContact.Size = new global::System.Drawing.Size(757, 150);
			this.grpContact.TabIndex = 16;
			this.grpContact.Text = "Contact";
			this.lblAboutEmailData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAboutEmailData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAboutEmailData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblAboutEmailData.ForeColor = global::System.Drawing.Color.White;
			this.lblAboutEmailData.Location = new global::System.Drawing.Point(180, 110);
			this.lblAboutEmailData.Name = "lblAboutEmailData";
			this.lblAboutEmailData.Size = new global::System.Drawing.Size(47, 19);
			this.lblAboutEmailData.TabIndex = 73;
			this.lblAboutEmailData.Text = "[EMAIL]";
			this.lblAboutEmail.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAboutEmail.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAboutEmail.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblAboutEmail.ForeColor = global::System.Drawing.Color.White;
			this.lblAboutEmail.Location = new global::System.Drawing.Point(22, 110);
			this.lblAboutEmail.Name = "lblAboutEmail";
			this.lblAboutEmail.Size = new global::System.Drawing.Size(43, 19);
			this.lblAboutEmail.TabIndex = 72;
			this.lblAboutEmail.Text = "E-Mail:";
			this.lblAboutDiscordData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAboutDiscordData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAboutDiscordData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblAboutDiscordData.ForeColor = global::System.Drawing.Color.White;
			this.lblAboutDiscordData.Location = new global::System.Drawing.Point(180, 85);
			this.lblAboutDiscordData.Name = "lblAboutDiscordData";
			this.lblAboutDiscordData.Size = new global::System.Drawing.Size(138, 19);
			this.lblAboutDiscordData.TabIndex = 71;
			this.lblAboutDiscordData.Text = "[DISCORD_USERNAME]";
			this.lblAboutDiscord.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAboutDiscord.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAboutDiscord.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblAboutDiscord.ForeColor = global::System.Drawing.Color.White;
			this.lblAboutDiscord.Location = new global::System.Drawing.Point(22, 85);
			this.lblAboutDiscord.Name = "lblAboutDiscord";
			this.lblAboutDiscord.Size = new global::System.Drawing.Size(51, 19);
			this.lblAboutDiscord.TabIndex = 70;
			this.lblAboutDiscord.Text = "Discord:";
			this.lblAboutStoreNameData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAboutStoreNameData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAboutStoreNameData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblAboutStoreNameData.ForeColor = global::System.Drawing.Color.White;
			this.lblAboutStoreNameData.Location = new global::System.Drawing.Point(180, 60);
			this.lblAboutStoreNameData.Name = "lblAboutStoreNameData";
			this.lblAboutStoreNameData.Size = new global::System.Drawing.Size(92, 19);
			this.lblAboutStoreNameData.TabIndex = 69;
			this.lblAboutStoreNameData.Text = "[STORE_NAME]";
			this.lblAboutStoreName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAboutStoreName.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAboutStoreName.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblAboutStoreName.ForeColor = global::System.Drawing.Color.White;
			this.lblAboutStoreName.Location = new global::System.Drawing.Point(22, 60);
			this.lblAboutStoreName.Name = "lblAboutStoreName";
			this.lblAboutStoreName.Size = new global::System.Drawing.Size(76, 19);
			this.lblAboutStoreName.TabIndex = 68;
			this.lblAboutStoreName.Text = "Store Name:";
			this.panelContactSpacer.BackColor = global::System.Drawing.Color.Transparent;
			this.panelContactSpacer.BorderColor = global::System.Drawing.Color.Transparent;
			this.panelContactSpacer.BorderRadius = 4;
			this.panelContactSpacer.BorderThickness = 1;
			this.panelContactSpacer.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.panelContactSpacer.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelContactSpacer.FillColor = global::System.Drawing.Color.Transparent;
			this.panelContactSpacer.Location = new global::System.Drawing.Point(0, 369);
			this.panelContactSpacer.Name = "panelContactSpacer";
			this.panelContactSpacer.Size = new global::System.Drawing.Size(757, 8);
			this.panelContactSpacer.TabIndex = 15;
			this.panelNoRequirements.BackColor = global::System.Drawing.Color.Transparent;
			this.panelNoRequirements.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelNoRequirements.BorderRadius = 4;
			this.panelNoRequirements.BorderThickness = 1;
			this.panelNoRequirements.Controls.Add(this.panelModules);
			this.panelNoRequirements.Controls.Add(this.lblNoRequirementsData);
			this.panelNoRequirements.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelNoRequirements.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelNoRequirements.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelNoRequirements.Location = new global::System.Drawing.Point(0, 309);
			this.panelNoRequirements.Name = "panelNoRequirements";
			this.panelNoRequirements.Size = new global::System.Drawing.Size(757, 60);
			this.panelNoRequirements.TabIndex = 18;
			this.panelModules.Controls.Add(this.imgModuleDungeon);
			this.panelModules.Controls.Add(this.imgModuleGather);
			this.panelModules.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.panelModules.Location = new global::System.Drawing.Point(249, 32);
			this.panelModules.Name = "panelModules";
			this.panelModules.Size = new global::System.Drawing.Size(254, 20);
			this.panelModules.TabIndex = 89;
			this.panelModules.Visible = false;
			this.lblNoRequirementsData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblNoRequirementsData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblNoRequirementsData.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblNoRequirementsData.Location = new global::System.Drawing.Point(0, 19);
			this.lblNoRequirementsData.Name = "lblNoRequirementsData";
			this.lblNoRequirementsData.Size = new global::System.Drawing.Size(757, 23);
			this.lblNoRequirementsData.TabIndex = 0;
			this.lblNoRequirementsData.Text = "This Profile has no further requirements.";
			this.lblNoRequirementsData.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panelNoRequirementsSpacer.BackColor = global::System.Drawing.Color.Transparent;
			this.panelNoRequirementsSpacer.BorderColor = global::System.Drawing.Color.Transparent;
			this.panelNoRequirementsSpacer.BorderRadius = 4;
			this.panelNoRequirementsSpacer.BorderThickness = 1;
			this.panelNoRequirementsSpacer.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.panelNoRequirementsSpacer.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelNoRequirementsSpacer.FillColor = global::System.Drawing.Color.Transparent;
			this.panelNoRequirementsSpacer.Location = new global::System.Drawing.Point(0, 301);
			this.panelNoRequirementsSpacer.Name = "panelNoRequirementsSpacer";
			this.panelNoRequirementsSpacer.Size = new global::System.Drawing.Size(757, 8);
			this.panelNoRequirementsSpacer.TabIndex = 14;
			this.panelNoRequirementsSpacer.Visible = false;
			this.grpRequirements.BackColor = global::System.Drawing.Color.Transparent;
			this.grpRequirements.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpRequirements.BorderRadius = 4;
			this.grpRequirements.Controls.Add(this.lblRequiredDescriptionMore);
			this.grpRequirements.Controls.Add(this.lblRequiredDescription);
			this.grpRequirements.Controls.Add(this.lblRequiredDescriptionData);
			this.grpRequirements.Controls.Add(this.lblRequiredSkillData);
			this.grpRequirements.Controls.Add(this.lblRequiredSkill);
			this.grpRequirements.Controls.Add(this.lblRequiredLevelData);
			this.grpRequirements.Controls.Add(this.lblRequiredLevel);
			this.grpRequirements.CustomBorderColor = global::System.Drawing.Color.SteelBlue;
			this.grpRequirements.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.grpRequirements.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpRequirements.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpRequirements.ForeColor = global::System.Drawing.Color.White;
			this.grpRequirements.Location = new global::System.Drawing.Point(0, 49);
			this.grpRequirements.Name = "grpRequirements";
			this.grpRequirements.Size = new global::System.Drawing.Size(757, 252);
			this.grpRequirements.TabIndex = 11;
			this.grpRequirements.Text = "Requirements";
			this.grpRequirements.Visible = false;
			this.lblRequiredDescriptionMore.AutoSize = true;
			this.lblRequiredDescriptionMore.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequiredDescriptionMore.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblRequiredDescriptionMore.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblRequiredDescriptionMore.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblRequiredDescriptionMore.Location = new global::System.Drawing.Point(20, 220);
			this.lblRequiredDescriptionMore.Name = "lblRequiredDescriptionMore";
			this.lblRequiredDescriptionMore.Size = new global::System.Drawing.Size(67, 15);
			this.lblRequiredDescriptionMore.TabIndex = 73;
			this.lblRequiredDescriptionMore.Text = "Show More";
			this.lblRequiredDescriptionMore.Visible = false;
			this.lblRequiredDescriptionMore.Click += new global::System.EventHandler(this.lblRequiredDescriptionMore_Click);
			this.lblRequiredDescription.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRequiredDescription.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequiredDescription.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblRequiredDescription.ForeColor = global::System.Drawing.Color.White;
			this.lblRequiredDescription.Location = new global::System.Drawing.Point(22, 119);
			this.lblRequiredDescription.Name = "lblRequiredDescription";
			this.lblRequiredDescription.Size = new global::System.Drawing.Size(117, 17);
			this.lblRequiredDescription.TabIndex = 72;
			this.lblRequiredDescription.Text = "<u>Further Requirements</u>";
			this.lblRequiredDescriptionData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRequiredDescriptionData.AutoSize = false;
			this.lblRequiredDescriptionData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequiredDescriptionData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblRequiredDescriptionData.ForeColor = global::System.Drawing.Color.White;
			this.lblRequiredDescriptionData.Location = new global::System.Drawing.Point(22, 139);
			this.lblRequiredDescriptionData.Name = "lblRequiredDescriptionData";
			this.lblRequiredDescriptionData.Size = new global::System.Drawing.Size(710, 70);
			this.lblRequiredDescriptionData.TabIndex = 71;
			this.lblRequiredDescriptionData.Text = "No further requirements.";
			this.lblRequiredSkillData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRequiredSkillData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequiredSkillData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblRequiredSkillData.ForeColor = global::System.Drawing.Color.White;
			this.lblRequiredSkillData.Location = new global::System.Drawing.Point(180, 85);
			this.lblRequiredSkillData.Name = "lblRequiredSkillData";
			this.lblRequiredSkillData.Size = new global::System.Drawing.Size(25, 19);
			this.lblRequiredSkillData.TabIndex = 70;
			this.lblRequiredSkillData.Text = "[00]";
			this.lblRequiredSkill.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRequiredSkill.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequiredSkill.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblRequiredSkill.ForeColor = global::System.Drawing.Color.White;
			this.lblRequiredSkill.Location = new global::System.Drawing.Point(22, 85);
			this.lblRequiredSkill.Name = "lblRequiredSkill";
			this.lblRequiredSkill.Size = new global::System.Drawing.Size(111, 19);
			this.lblRequiredSkill.TabIndex = 69;
			this.lblRequiredSkill.Text = "<i>Required Skill Level:</i>";
			this.lblRequiredLevelData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRequiredLevelData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequiredLevelData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblRequiredLevelData.ForeColor = global::System.Drawing.Color.White;
			this.lblRequiredLevelData.Location = new global::System.Drawing.Point(180, 60);
			this.lblRequiredLevelData.Name = "lblRequiredLevelData";
			this.lblRequiredLevelData.Size = new global::System.Drawing.Size(25, 19);
			this.lblRequiredLevelData.TabIndex = 68;
			this.lblRequiredLevelData.Text = "[00]";
			this.lblRequiredLevel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRequiredLevel.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequiredLevel.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblRequiredLevel.ForeColor = global::System.Drawing.Color.White;
			this.lblRequiredLevel.Location = new global::System.Drawing.Point(22, 60);
			this.lblRequiredLevel.Name = "lblRequiredLevel";
			this.lblRequiredLevel.Size = new global::System.Drawing.Size(86, 19);
			this.lblRequiredLevel.TabIndex = 15;
			this.lblRequiredLevel.Text = "<i>Required Level:</i>";
			this.panelAlreadyPurchasedSpacer.BackColor = global::System.Drawing.Color.Transparent;
			this.panelAlreadyPurchasedSpacer.BorderColor = global::System.Drawing.Color.Transparent;
			this.panelAlreadyPurchasedSpacer.BorderRadius = 4;
			this.panelAlreadyPurchasedSpacer.BorderThickness = 1;
			this.panelAlreadyPurchasedSpacer.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.panelAlreadyPurchasedSpacer.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelAlreadyPurchasedSpacer.FillColor = global::System.Drawing.Color.Transparent;
			this.panelAlreadyPurchasedSpacer.Location = new global::System.Drawing.Point(0, 41);
			this.panelAlreadyPurchasedSpacer.Name = "panelAlreadyPurchasedSpacer";
			this.panelAlreadyPurchasedSpacer.Size = new global::System.Drawing.Size(757, 8);
			this.panelAlreadyPurchasedSpacer.TabIndex = 19;
			this.panelAlreadyPurchasedSpacer.Visible = false;
			this.panelAlreadyPurchased.BackColor = global::System.Drawing.Color.Transparent;
			this.panelAlreadyPurchased.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelAlreadyPurchased.BorderRadius = 4;
			this.panelAlreadyPurchased.BorderThickness = 1;
			this.panelAlreadyPurchased.Controls.Add(this.lblAlreadyPurchased);
			this.panelAlreadyPurchased.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelAlreadyPurchased.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panelAlreadyPurchased.FillColor = global::System.Drawing.Color.Orange;
			this.panelAlreadyPurchased.Location = new global::System.Drawing.Point(0, 0);
			this.panelAlreadyPurchased.Name = "panelAlreadyPurchased";
			this.panelAlreadyPurchased.Size = new global::System.Drawing.Size(757, 41);
			this.panelAlreadyPurchased.TabIndex = 20;
			this.panelAlreadyPurchased.Visible = false;
			this.lblAlreadyPurchased.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblAlreadyPurchased.AutoSize = false;
			this.lblAlreadyPurchased.BackColor = global::System.Drawing.Color.Transparent;
			this.lblAlreadyPurchased.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Underline);
			this.lblAlreadyPurchased.ForeColor = global::System.Drawing.Color.Black;
			this.lblAlreadyPurchased.Location = new global::System.Drawing.Point(0, 8);
			this.lblAlreadyPurchased.Name = "lblAlreadyPurchased";
			this.lblAlreadyPurchased.Size = new global::System.Drawing.Size(757, 28);
			this.lblAlreadyPurchased.TabIndex = 16;
			this.lblAlreadyPurchased.Text = "You already owned this Profile.";
			this.lblAlreadyPurchased.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panelInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.panelInfo.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelInfo.BorderRadius = 4;
			this.panelInfo.BorderThickness = 1;
			this.panelInfo.Controls.Add(this.lblInfoGamesData);
			this.panelInfo.Controls.Add(this.lblInfoProfileTypeData);
			this.panelInfo.Controls.Add(this.lblInfoFactionData);
			this.panelInfo.Controls.Add(this.sepInfo2);
			this.panelInfo.Controls.Add(this.sepInfo1);
			this.panelInfo.Controls.Add(this.panelProfileFactions);
			this.panelInfo.Controls.Add(this.lblInfoClassData);
			this.panelInfo.Controls.Add(this.lblInfoFactions);
			this.panelInfo.Controls.Add(this.imgGames);
			this.panelInfo.Controls.Add(this.lblInfoType);
			this.panelInfo.Controls.Add(this.lblInfoProfileType);
			this.panelInfo.CustomBorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelInfo.CustomizableEdges.BottomRight = false;
			this.panelInfo.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelInfo.Location = new global::System.Drawing.Point(318, 326);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new global::System.Drawing.Size(447, 115);
			this.panelInfo.TabIndex = 12;
			this.lblInfoFactionData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoFactionData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfoFactionData.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoFactionData.Location = new global::System.Drawing.Point(215, 76);
			this.lblInfoFactionData.Name = "lblInfoFactionData";
			this.lblInfoFactionData.Size = new global::System.Drawing.Size(63, 19);
			this.lblInfoFactionData.TabIndex = 29;
			this.lblInfoFactionData.Text = "[FACTION]";
			this.lblInfoFactionData.TextAlignment = global::System.Drawing.ContentAlignment.MiddleRight;
			this.sepInfo2.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.sepInfo2.Location = new global::System.Drawing.Point(285, 76);
			this.sepInfo2.Name = "sepInfo2";
			this.sepInfo2.Size = new global::System.Drawing.Size(10, 21);
			this.sepInfo2.TabIndex = 28;
			this.sepInfo1.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.sepInfo1.Location = new global::System.Drawing.Point(285, 48);
			this.sepInfo1.Name = "sepInfo1";
			this.sepInfo1.Size = new global::System.Drawing.Size(10, 21);
			this.sepInfo1.TabIndex = 17;
			this.panelProfileFactions.Controls.Add(this.imgFactionAlliance);
			this.panelProfileFactions.Controls.Add(this.imgFactionHorde);
			this.panelProfileFactions.Location = new global::System.Drawing.Point(170, 76);
			this.panelProfileFactions.Name = "panelProfileFactions";
			this.panelProfileFactions.Size = new global::System.Drawing.Size(40, 20);
			this.panelProfileFactions.TabIndex = 15;
			this.lblInfoClassData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoClassData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfoClassData.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoClassData.Location = new global::System.Drawing.Point(300, 76);
			this.lblInfoClassData.Name = "lblInfoClassData";
			this.lblInfoClassData.Size = new global::System.Drawing.Size(47, 19);
			this.lblInfoClassData.TabIndex = 27;
			this.lblInfoClassData.Text = "[CLASS]";
			this.lblInfoFactions.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoFactions.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfoFactions.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoFactions.Location = new global::System.Drawing.Point(22, 76);
			this.lblInfoFactions.Name = "lblInfoFactions";
			this.lblInfoFactions.Size = new global::System.Drawing.Size(81, 19);
			this.lblInfoFactions.TabIndex = 26;
			this.lblInfoFactions.Text = "Playable with:";
			this.lblInfoType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoType.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfoType.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoType.Location = new global::System.Drawing.Point(22, 47);
			this.lblInfoType.Name = "lblInfoType";
			this.lblInfoType.Size = new global::System.Drawing.Size(87, 19);
			this.lblInfoType.TabIndex = 24;
			this.lblInfoType.Text = "Can used with:";
			this.lblInfoProfileType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoProfileType.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfoProfileType.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoProfileType.Location = new global::System.Drawing.Point(22, 18);
			this.lblInfoProfileType.Name = "lblInfoProfileType";
			this.lblInfoProfileType.Size = new global::System.Drawing.Size(75, 19);
			this.lblInfoProfileType.TabIndex = 22;
			this.lblInfoProfileType.Text = "Profile Type:";
			this.grpDescription.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpDescription.BorderColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpDescription.BorderRadius = 4;
			this.grpDescription.Controls.Add(this.lblDisplayName);
			this.grpDescription.Controls.Add(this.lblDescriptionMore);
			this.grpDescription.Controls.Add(this.lblDescription);
			this.grpDescription.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpDescription.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpDescription.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpDescription.ForeColor = global::System.Drawing.Color.White;
			this.grpDescription.Location = new global::System.Drawing.Point(318, 8);
			this.grpDescription.Name = "grpDescription";
			this.grpDescription.Size = new global::System.Drawing.Size(447, 310);
			this.grpDescription.TabIndex = 10;
			this.lblDisplayName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblDisplayName.AutoEllipsis = true;
			this.lblDisplayName.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDisplayName.Font = new global::System.Drawing.Font("Segoe UI", 9.5f);
			this.lblDisplayName.Location = new global::System.Drawing.Point(11, 1);
			this.lblDisplayName.Name = "lblDisplayName";
			this.lblDisplayName.Size = new global::System.Drawing.Size(421, 36);
			this.lblDisplayName.TabIndex = 68;
			this.lblDisplayName.Text = "[DISPLAY_NAME]";
			this.lblDisplayName.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDescriptionMore.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.lblDescriptionMore.AutoSize = true;
			this.lblDescriptionMore.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDescriptionMore.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblDescriptionMore.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.lblDescriptionMore.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblDescriptionMore.Location = new global::System.Drawing.Point(20, 278);
			this.lblDescriptionMore.Name = "lblDescriptionMore";
			this.lblDescriptionMore.Size = new global::System.Drawing.Size(67, 15);
			this.lblDescriptionMore.TabIndex = 67;
			this.lblDescriptionMore.Text = "Show More";
			this.lblDescriptionMore.Visible = false;
			this.lblDescriptionMore.Click += new global::System.EventHandler(this.lblDescriptionMore_Click);
			this.lblDescription.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblDescription.AutoSize = false;
			this.lblDescription.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDescription.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblDescription.ForeColor = global::System.Drawing.Color.White;
			this.lblDescription.Location = new global::System.Drawing.Point(22, 60);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new global::System.Drawing.Size(400, 204);
			this.lblDescription.TabIndex = 15;
			this.lblDescription.Text = "[DESCRIPTION]";
			this.lblInfoProfileTypeData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoProfileTypeData.AutoEllipsis = true;
			this.lblInfoProfileTypeData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoProfileTypeData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfoProfileTypeData.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoProfileTypeData.Location = new global::System.Drawing.Point(166, 18);
			this.lblInfoProfileTypeData.Name = "lblInfoProfileTypeData";
			this.lblInfoProfileTypeData.Size = new global::System.Drawing.Size(266, 20);
			this.lblInfoProfileTypeData.TabIndex = 30;
			this.lblInfoProfileTypeData.Text = "[PROFILE_TYPE]";
			this.lblInfoGamesData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfoGamesData.AutoEllipsis = true;
			this.lblInfoGamesData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfoGamesData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblInfoGamesData.ForeColor = global::System.Drawing.Color.White;
			this.lblInfoGamesData.Location = new global::System.Drawing.Point(296, 47);
			this.lblInfoGamesData.Name = "lblInfoGamesData";
			this.lblInfoGamesData.Size = new global::System.Drawing.Size(136, 20);
			this.lblInfoGamesData.TabIndex = 31;
			this.lblInfoGamesData.Text = "[GAMES_DATA]";
			this.imgPriceCoin.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgPriceCoin.BackColor = global::System.Drawing.Color.Transparent;
			this.imgPriceCoin.FillColor = global::System.Drawing.Color.Transparent;
			this.imgPriceCoin.Image = global::Jack.Properties.Resources.coin_24;
			this.imgPriceCoin.ImageRotate = 0f;
			this.imgPriceCoin.Location = new global::System.Drawing.Point(47, 0);
			this.imgPriceCoin.Name = "imgPriceCoin";
			this.imgPriceCoin.Size = new global::System.Drawing.Size(24, 24);
			this.imgPriceCoin.TabIndex = 60;
			this.imgPriceCoin.TabStop = false;
			this.imgBundle.BackColor = global::System.Drawing.Color.Transparent;
			this.imgBundle.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.imgBundle.FillColor = global::System.Drawing.Color.Transparent;
			this.imgBundle.Image = global::Jack.Properties.Resources.store_banner_bundle;
			this.imgBundle.ImageRotate = 0f;
			this.imgBundle.Location = new global::System.Drawing.Point(224, 8);
			this.imgBundle.Name = "imgBundle";
			this.imgBundle.Size = new global::System.Drawing.Size(84, 89);
			this.imgBundle.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgBundle.TabIndex = 72;
			this.imgBundle.TabStop = false;
			this.imgBundle.Visible = false;
			this.imgBundle.Click += new global::System.EventHandler(this.imgBundle_Click);
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnBuy);
			this.panelBtnSave.Location = new global::System.Drawing.Point(485, 441);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 71;
			this.btnBuy.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBuy.BackColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnBuy.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.Image = global::Jack.Properties.Resources.btn_buy_disabled;
			this.btnBuy.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnBuy.ForeColor = global::System.Drawing.Color.White;
			this.btnBuy.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.HoverState.Image = global::Jack.Properties.Resources.btn_buy_hover;
			this.btnBuy.Image = global::Jack.Properties.Resources.btn_buy;
			this.btnBuy.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnBuy.Location = new global::System.Drawing.Point(30, 0);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.PressedDepth = 0;
			this.btnBuy.Size = new global::System.Drawing.Size(235, 44);
			this.btnBuy.TabIndex = 0;
			this.btnBuy.Click += new global::System.EventHandler(this.btnBuy_Click);
			this.imgModuleDungeon.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleDungeon.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.imgModuleDungeon.Image = global::Jack.Properties.Resources.module_dungeons_small;
			this.imgModuleDungeon.ImageRotate = 0f;
			this.imgModuleDungeon.Location = new global::System.Drawing.Point(135, 0);
			this.imgModuleDungeon.Name = "imgModuleDungeon";
			this.imgModuleDungeon.Size = new global::System.Drawing.Size(113, 20);
			this.imgModuleDungeon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgModuleDungeon.TabIndex = 88;
			this.imgModuleDungeon.TabStop = false;
			this.imgModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleGather.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.imgModuleGather.Image = global::Jack.Properties.Resources.module_gathering_small;
			this.imgModuleGather.ImageRotate = 0f;
			this.imgModuleGather.Location = new global::System.Drawing.Point(15, 0);
			this.imgModuleGather.Name = "imgModuleGather";
			this.imgModuleGather.Size = new global::System.Drawing.Size(113, 20);
			this.imgModuleGather.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.imgModuleGather.TabIndex = 87;
			this.imgModuleGather.TabStop = false;
			this.imgFactionAlliance.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.imgFactionAlliance.FillColor = global::System.Drawing.Color.Transparent;
			this.imgFactionAlliance.Image = global::Jack.Properties.Resources.store_faction_alliance_20;
			this.imgFactionAlliance.ImageRotate = 0f;
			this.imgFactionAlliance.Location = new global::System.Drawing.Point(20, 0);
			this.imgFactionAlliance.Name = "imgFactionAlliance";
			this.imgFactionAlliance.Size = new global::System.Drawing.Size(20, 20);
			this.imgFactionAlliance.TabIndex = 14;
			this.imgFactionAlliance.TabStop = false;
			this.imgFactionHorde.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.imgFactionHorde.FillColor = global::System.Drawing.Color.Transparent;
			this.imgFactionHorde.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("imgFactionHorde.Image");
			this.imgFactionHorde.ImageRotate = 0f;
			this.imgFactionHorde.Location = new global::System.Drawing.Point(0, 0);
			this.imgFactionHorde.Name = "imgFactionHorde";
			this.imgFactionHorde.Size = new global::System.Drawing.Size(20, 20);
			this.imgFactionHorde.TabIndex = 13;
			this.imgFactionHorde.TabStop = false;
			this.imgGames.FillColor = global::System.Drawing.Color.Transparent;
			this.imgGames.Image = global::Jack.Properties.Resources.store_profile_type_wotlk_som;
			this.imgGames.ImageRotate = 0f;
			this.imgGames.Location = new global::System.Drawing.Point(170, 48);
			this.imgGames.Name = "imgGames";
			this.imgGames.Size = new global::System.Drawing.Size(107, 20);
			this.imgGames.TabIndex = 16;
			this.imgGames.TabStop = false;
			this.imgLoading_4.AnimatedGIF = true;
			this.imgLoading_4.CheckedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_4.HoverState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_4.Image = global::Jack.Properties.Resources.loading_32;
			this.imgLoading_4.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgLoading_4.ImageRotate = 0f;
			this.imgLoading_4.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_4.Location = new global::System.Drawing.Point(247, 425);
			this.imgLoading_4.Name = "imgLoading_4";
			this.imgLoading_4.PressedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_4.Size = new global::System.Drawing.Size(32, 32);
			this.imgLoading_4.TabIndex = 9;
			this.img_4.BackColor = global::System.Drawing.Color.Transparent;
			this.img_4.BorderRadius = 4;
			this.img_4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.img_4.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.img_4.ImageRotate = 0f;
			this.img_4.Location = new global::System.Drawing.Point(214, 383);
			this.img_4.Name = "img_4";
			this.img_4.Size = new global::System.Drawing.Size(94, 115);
			this.img_4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.img_4.TabIndex = 8;
			this.img_4.TabStop = false;
			this.imgLoading_3.AnimatedGIF = true;
			this.imgLoading_3.CheckedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_3.HoverState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_3.Image = global::Jack.Properties.Resources.loading_32;
			this.imgLoading_3.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgLoading_3.ImageRotate = 0f;
			this.imgLoading_3.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_3.Location = new global::System.Drawing.Point(141, 425);
			this.imgLoading_3.Name = "imgLoading_3";
			this.imgLoading_3.PressedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_3.Size = new global::System.Drawing.Size(32, 32);
			this.imgLoading_3.TabIndex = 7;
			this.img_3.BackColor = global::System.Drawing.Color.Transparent;
			this.img_3.BorderRadius = 4;
			this.img_3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.img_3.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.img_3.ImageRotate = 0f;
			this.img_3.Location = new global::System.Drawing.Point(111, 383);
			this.img_3.Name = "img_3";
			this.img_3.Size = new global::System.Drawing.Size(94, 115);
			this.img_3.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.img_3.TabIndex = 6;
			this.img_3.TabStop = false;
			this.imgLoading_2.AnimatedGIF = true;
			this.imgLoading_2.CheckedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_2.HoverState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_2.Image = global::Jack.Properties.Resources.loading_32;
			this.imgLoading_2.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgLoading_2.ImageRotate = 0f;
			this.imgLoading_2.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_2.Location = new global::System.Drawing.Point(41, 425);
			this.imgLoading_2.Name = "imgLoading_2";
			this.imgLoading_2.PressedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_2.Size = new global::System.Drawing.Size(32, 32);
			this.imgLoading_2.TabIndex = 5;
			this.img_2.BackColor = global::System.Drawing.Color.Transparent;
			this.img_2.BorderRadius = 4;
			this.img_2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.img_2.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.img_2.ImageRotate = 0f;
			this.img_2.Location = new global::System.Drawing.Point(8, 383);
			this.img_2.Name = "img_2";
			this.img_2.Size = new global::System.Drawing.Size(94, 115);
			this.img_2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.img_2.TabIndex = 4;
			this.img_2.TabStop = false;
			this.imgLoading_1.AnimatedGIF = true;
			this.imgLoading_1.CheckedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_1.HoverState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_1.Image = global::Jack.Properties.Resources.loading_32;
			this.imgLoading_1.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.imgLoading_1.ImageRotate = 0f;
			this.imgLoading_1.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_1.Location = new global::System.Drawing.Point(141, 177);
			this.imgLoading_1.Name = "imgLoading_1";
			this.imgLoading_1.PressedState.ImageSize = new global::System.Drawing.Size(32, 32);
			this.imgLoading_1.Size = new global::System.Drawing.Size(32, 32);
			this.imgLoading_1.TabIndex = 3;
			this.img_1.BackColor = global::System.Drawing.Color.Transparent;
			this.img_1.BorderRadius = 4;
			this.img_1.FillColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.img_1.ImageRotate = 0f;
			this.img_1.Location = new global::System.Drawing.Point(8, 8);
			this.img_1.Name = "img_1";
			this.img_1.Size = new global::System.Drawing.Size(300, 367);
			this.img_1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.img_1.TabIndex = 2;
			this.img_1.TabStop = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(789, 1051);
			base.Controls.Add(this.panelProfile);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmStoreProfile";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmStoreProfile";
			base.Load += new global::System.EventHandler(this.frmStoreProfile_Load);
			base.Resize += new global::System.EventHandler(this.frmStoreProfile_Resize);
			this.panelProfile.ResumeLayout(false);
			this.panelPrice.ResumeLayout(false);
			this.panelPriceCoins.ResumeLayout(false);
			this.panelMore.ResumeLayout(false);
			this.grpContact.ResumeLayout(false);
			this.grpContact.PerformLayout();
			this.panelNoRequirements.ResumeLayout(false);
			this.panelModules.ResumeLayout(false);
			this.grpRequirements.ResumeLayout(false);
			this.grpRequirements.PerformLayout();
			this.panelAlreadyPurchased.ResumeLayout(false);
			this.panelInfo.ResumeLayout(false);
			this.panelInfo.PerformLayout();
			this.panelProfileFactions.ResumeLayout(false);
			this.grpDescription.ResumeLayout(false);
			this.grpDescription.PerformLayout();
			this.imgPriceCoin.EndInit();
			this.imgBundle.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			this.imgModuleDungeon.EndInit();
			this.imgModuleGather.EndInit();
			this.imgFactionAlliance.EndInit();
			this.imgFactionHorde.EndInit();
			this.imgGames.EndInit();
			this.img_4.EndInit();
			this.img_3.EndInit();
			this.img_2.EndInit();
			this.img_1.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040003BC RID: 956
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003BD RID: 957
		private global::Guna.UI2.WinForms.Guna2ImageButton imgLoading_1;

		// Token: 0x040003BE RID: 958
		private global::Guna.UI2.WinForms.Guna2PictureBox img_1;

		// Token: 0x040003BF RID: 959
		private global::Guna.UI2.WinForms.Guna2Panel panelProfile;

		// Token: 0x040003C0 RID: 960
		private global::Guna.UI2.WinForms.Guna2ImageButton imgLoading_4;

		// Token: 0x040003C1 RID: 961
		private global::Guna.UI2.WinForms.Guna2PictureBox img_4;

		// Token: 0x040003C2 RID: 962
		private global::Guna.UI2.WinForms.Guna2ImageButton imgLoading_3;

		// Token: 0x040003C3 RID: 963
		private global::Guna.UI2.WinForms.Guna2PictureBox img_3;

		// Token: 0x040003C4 RID: 964
		private global::Guna.UI2.WinForms.Guna2ImageButton imgLoading_2;

		// Token: 0x040003C5 RID: 965
		private global::Guna.UI2.WinForms.Guna2PictureBox img_2;

		// Token: 0x040003C6 RID: 966
		private global::Guna.UI2.WinForms.Guna2GroupBox grpDescription;

		// Token: 0x040003C7 RID: 967
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;

		// Token: 0x040003C8 RID: 968
		private global::System.Windows.Forms.Label lblDescriptionMore;

		// Token: 0x040003C9 RID: 969
		private global::Guna.UI2.WinForms.Guna2Panel panelInfo;

		// Token: 0x040003CA RID: 970
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblInfoProfileType;

		// Token: 0x040003CB RID: 971
		private global::Guna.UI2.WinForms.Guna2Panel panelProfileFactions;

		// Token: 0x040003CC RID: 972
		private global::Guna.UI2.WinForms.Guna2PictureBox imgFactionAlliance;

		// Token: 0x040003CD RID: 973
		private global::Guna.UI2.WinForms.Guna2PictureBox imgFactionHorde;

		// Token: 0x040003CE RID: 974
		private global::Guna.UI2.WinForms.Guna2PictureBox imgGames;

		// Token: 0x040003CF RID: 975
		private global::Guna.UI2.WinForms.Guna2VSeparator sepInfo1;

		// Token: 0x040003D0 RID: 976
		private global::Guna.UI2.WinForms.Guna2VSeparator sepInfo2;

		// Token: 0x040003D1 RID: 977
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblInfoClassData;

		// Token: 0x040003D2 RID: 978
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblInfoFactions;

		// Token: 0x040003D3 RID: 979
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblInfoType;

		// Token: 0x040003D4 RID: 980
		private global::Guna.UI2.WinForms.Guna2Panel panelMore;

		// Token: 0x040003D5 RID: 981
		private global::Guna.UI2.WinForms.Guna2GroupBox grpRequirements;

		// Token: 0x040003D6 RID: 982
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblRequiredLevel;

		// Token: 0x040003D7 RID: 983
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblRequiredSkillData;

		// Token: 0x040003D8 RID: 984
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblRequiredSkill;

		// Token: 0x040003D9 RID: 985
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblRequiredLevelData;

		// Token: 0x040003DA RID: 986
		private global::System.Windows.Forms.Label lblRequiredDescriptionMore;

		// Token: 0x040003DB RID: 987
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblRequiredDescription;

		// Token: 0x040003DC RID: 988
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblRequiredDescriptionData;

		// Token: 0x040003DD RID: 989
		private global::Guna.UI2.WinForms.Guna2Panel panelNoRequirementsSpacer;

		// Token: 0x040003DE RID: 990
		private global::Guna.UI2.WinForms.Guna2GroupBox grpContact;

		// Token: 0x040003DF RID: 991
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblAboutEmailData;

		// Token: 0x040003E0 RID: 992
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblAboutEmail;

		// Token: 0x040003E1 RID: 993
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblAboutDiscordData;

		// Token: 0x040003E2 RID: 994
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblAboutDiscord;

		// Token: 0x040003E3 RID: 995
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblAboutStoreNameData;

		// Token: 0x040003E4 RID: 996
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblAboutStoreName;

		// Token: 0x040003E5 RID: 997
		private global::Guna.UI2.WinForms.Guna2Panel panelContactSpacer;

		// Token: 0x040003E6 RID: 998
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblInfoFactionData;

		// Token: 0x040003E7 RID: 999
		private global::Guna.UI2.WinForms.Guna2Panel panelNoRequirements;

		// Token: 0x040003E8 RID: 1000
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x040003E9 RID: 1001
		private global::Guna.UI2.WinForms.Guna2Button btnBuy;

		// Token: 0x040003EA RID: 1002
		private global::Guna.UI2.WinForms.Guna2PictureBox imgBundle;

		// Token: 0x040003EB RID: 1003
		private global::System.Windows.Forms.Label lblDisplayName;

		// Token: 0x040003EC RID: 1004
		private global::Guna.UI2.WinForms.Guna2Panel panelPrice;

		// Token: 0x040003ED RID: 1005
		private global::Guna.UI2.WinForms.Guna2Panel panelPriceCoins;

		// Token: 0x040003EE RID: 1006
		private global::System.Windows.Forms.Label lblPrice;

		// Token: 0x040003EF RID: 1007
		private global::Guna.UI2.WinForms.Guna2PictureBox imgPriceCoin;

		// Token: 0x040003F0 RID: 1008
		private global::Guna.UI2.WinForms.Guna2Panel panelAlreadyPurchased;

		// Token: 0x040003F1 RID: 1009
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblAlreadyPurchased;

		// Token: 0x040003F2 RID: 1010
		private global::Guna.UI2.WinForms.Guna2Panel panelAlreadyPurchasedSpacer;

		// Token: 0x040003F3 RID: 1011
		private global::System.Windows.Forms.Label lblNoRequirementsData;

		// Token: 0x040003F4 RID: 1012
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleGather;

		// Token: 0x040003F5 RID: 1013
		private global::Guna.UI2.WinForms.Guna2Panel panelModules;

		// Token: 0x040003F6 RID: 1014
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleDungeon;

		// Token: 0x040003F7 RID: 1015
		private global::System.Windows.Forms.Label lblInfoProfileTypeData;

		// Token: 0x040003F8 RID: 1016
		private global::System.Windows.Forms.Label lblInfoGamesData;
	}
}
