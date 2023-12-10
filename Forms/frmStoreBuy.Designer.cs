namespace Jack.Forms
{
	// Token: 0x02000078 RID: 120
	public partial class frmStoreBuy : global::System.Windows.Forms.Form
	{
		// Token: 0x06000B20 RID: 2848 RVA: 0x006972F0 File Offset: 0x006954F0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0069731C File Offset: 0x0069551C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmStoreBuy));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblDisplayNameData = new global::System.Windows.Forms.Label();
			this.lblGetJackCoins = new global::System.Windows.Forms.Label();
			this.lblStatus = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.checkRefund = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.checkRequirements = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.lblPriceData = new global::System.Windows.Forms.Label();
			this.imgPriceCoin = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.sep3 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.lblPrice = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.sep2 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.sep1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.panelRequirements = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblClassData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblClass = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblFactionData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblFaction = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblGamesData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblGames = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblProfileTypeData = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblProfileType = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblRequirementsInfo = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnBuy = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBox1.SuspendLayout();
			this.imgPriceCoin.BeginInit();
			this.panelRequirements.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.lblDisplayNameData);
			this.panelBox1.Controls.Add(this.lblGetJackCoins);
			this.panelBox1.Controls.Add(this.lblStatus);
			this.panelBox1.Controls.Add(this.guna2Separator1);
			this.panelBox1.Controls.Add(this.checkRefund);
			this.panelBox1.Controls.Add(this.checkRequirements);
			this.panelBox1.Controls.Add(this.lblPriceData);
			this.panelBox1.Controls.Add(this.imgPriceCoin);
			this.panelBox1.Controls.Add(this.sep3);
			this.panelBox1.Controls.Add(this.lblPrice);
			this.panelBox1.Controls.Add(this.sep2);
			this.panelBox1.Controls.Add(this.sep1);
			this.panelBox1.Controls.Add(this.panelRequirements);
			this.panelBox1.Controls.Add(this.lblRequirementsInfo);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(584, 542);
			this.panelBox1.TabIndex = 76;
			this.lblDisplayNameData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblDisplayNameData.AutoEllipsis = true;
			this.lblDisplayNameData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDisplayNameData.Font = new global::System.Drawing.Font("Segoe UI", 9.5f);
			this.lblDisplayNameData.ForeColor = global::System.Drawing.Color.White;
			this.lblDisplayNameData.Location = new global::System.Drawing.Point(20, 48);
			this.lblDisplayNameData.Name = "lblDisplayNameData";
			this.lblDisplayNameData.Size = new global::System.Drawing.Size(538, 44);
			this.lblDisplayNameData.TabIndex = 87;
			this.lblDisplayNameData.Text = "[DISPLAY_NAME]";
			this.lblDisplayNameData.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGetJackCoins.AutoSize = true;
			this.lblGetJackCoins.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.lblGetJackCoins.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Underline);
			this.lblGetJackCoins.ForeColor = global::System.Drawing.Color.LimeGreen;
			this.lblGetJackCoins.Location = new global::System.Drawing.Point(424, 502);
			this.lblGetJackCoins.Name = "lblGetJackCoins";
			this.lblGetJackCoins.Size = new global::System.Drawing.Size(134, 19);
			this.lblGetJackCoins.TabIndex = 86;
			this.lblGetJackCoins.Text = "Get Jack Coins Now!";
			this.lblGetJackCoins.Visible = false;
			this.lblGetJackCoins.Click += new global::System.EventHandler(this.lblGetJackCoins_Click);
			this.lblStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.lblStatus.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblStatus.ForeColor = global::System.Drawing.Color.White;
			this.lblStatus.Location = new global::System.Drawing.Point(23, 502);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(56, 19);
			this.lblStatus.TabIndex = 84;
			this.lblStatus.Text = "[STATUS]";
			this.lblStatus.TextAlignment = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblStatus.Visible = false;
			this.guna2Separator1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Separator1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.guna2Separator1.Location = new global::System.Drawing.Point(15, 475);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(548, 10);
			this.guna2Separator1.TabIndex = 83;
			this.checkRefund.Animated = true;
			this.checkRefund.AutoSize = true;
			this.checkRefund.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRefund.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRefund.CheckedState.BorderRadius = 0;
			this.checkRefund.CheckedState.BorderThickness = 0;
			this.checkRefund.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRefund.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkRefund.ForeColor = global::System.Drawing.Color.White;
			this.checkRefund.Location = new global::System.Drawing.Point(23, 436);
			this.checkRefund.Name = "checkRefund";
			this.checkRefund.Size = new global::System.Drawing.Size(283, 19);
			this.checkRefund.TabIndex = 82;
			this.checkRefund.Text = "I am aware that \"Jack Coins\" are non-refundable.";
			this.checkRefund.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRefund.UncheckedState.BorderRadius = 0;
			this.checkRefund.UncheckedState.BorderThickness = 1;
			this.checkRefund.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRefund.UseVisualStyleBackColor = false;
			this.checkRefund.CheckedChanged += new global::System.EventHandler(this.checkRefund_CheckedChanged);
			this.checkRequirements.Animated = true;
			this.checkRequirements.AutoSize = true;
			this.checkRequirements.BackColor = global::System.Drawing.Color.Transparent;
			this.checkRequirements.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRequirements.CheckedState.BorderRadius = 0;
			this.checkRequirements.CheckedState.BorderThickness = 0;
			this.checkRequirements.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkRequirements.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.checkRequirements.ForeColor = global::System.Drawing.Color.White;
			this.checkRequirements.Location = new global::System.Drawing.Point(23, 411);
			this.checkRequirements.Name = "checkRequirements";
			this.checkRequirements.Size = new global::System.Drawing.Size(227, 19);
			this.checkRequirements.TabIndex = 81;
			this.checkRequirements.Text = "I have read and meet all requirements.";
			this.checkRequirements.UncheckedState.BorderColor = global::System.Drawing.Color.DimGray;
			this.checkRequirements.UncheckedState.BorderRadius = 0;
			this.checkRequirements.UncheckedState.BorderThickness = 1;
			this.checkRequirements.UncheckedState.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.checkRequirements.UseVisualStyleBackColor = false;
			this.checkRequirements.CheckedChanged += new global::System.EventHandler(this.checkRequirements_CheckedChanged);
			this.lblPriceData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPriceData.Font = new global::System.Drawing.Font("Segoe UI", 9.5f);
			this.lblPriceData.ForeColor = global::System.Drawing.Color.Goldenrod;
			this.lblPriceData.Location = new global::System.Drawing.Point(197, 344);
			this.lblPriceData.Name = "lblPriceData";
			this.lblPriceData.Size = new global::System.Drawing.Size(43, 15);
			this.lblPriceData.TabIndex = 61;
			this.lblPriceData.Text = "0";
			this.lblPriceData.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.imgPriceCoin.BackColor = global::System.Drawing.Color.Transparent;
			this.imgPriceCoin.FillColor = global::System.Drawing.Color.Transparent;
			this.imgPriceCoin.Image = global::Jack.Properties.Resources.coin_24;
			this.imgPriceCoin.ImageRotate = 0f;
			this.imgPriceCoin.Location = new global::System.Drawing.Point(240, 341);
			this.imgPriceCoin.Name = "imgPriceCoin";
			this.imgPriceCoin.Size = new global::System.Drawing.Size(24, 24);
			this.imgPriceCoin.TabIndex = 60;
			this.imgPriceCoin.TabStop = false;
			this.sep3.BackColor = global::System.Drawing.Color.Transparent;
			this.sep3.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sep3.Location = new global::System.Drawing.Point(18, 379);
			this.sep3.Name = "sep3";
			this.sep3.Size = new global::System.Drawing.Size(548, 10);
			this.sep3.TabIndex = 79;
			this.lblPrice.BackColor = global::System.Drawing.Color.Transparent;
			this.lblPrice.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblPrice.ForeColor = global::System.Drawing.Color.White;
			this.lblPrice.Location = new global::System.Drawing.Point(23, 343);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new global::System.Drawing.Size(112, 19);
			this.lblPrice.TabIndex = 78;
			this.lblPrice.Text = "Price in Jack Coins:";
			this.sep2.BackColor = global::System.Drawing.Color.Transparent;
			this.sep2.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sep2.Location = new global::System.Drawing.Point(18, 316);
			this.sep2.Name = "sep2";
			this.sep2.Size = new global::System.Drawing.Size(548, 10);
			this.sep2.TabIndex = 77;
			this.sep1.BackColor = global::System.Drawing.Color.Transparent;
			this.sep1.FillColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.sep1.Location = new global::System.Drawing.Point(18, 98);
			this.sep1.Name = "sep1";
			this.sep1.Size = new global::System.Drawing.Size(548, 10);
			this.sep1.TabIndex = 76;
			this.panelRequirements.BackColor = global::System.Drawing.Color.Transparent;
			this.panelRequirements.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelRequirements.BorderThickness = 1;
			this.panelRequirements.Controls.Add(this.lblClassData);
			this.panelRequirements.Controls.Add(this.lblClass);
			this.panelRequirements.Controls.Add(this.lblFactionData);
			this.panelRequirements.Controls.Add(this.lblFaction);
			this.panelRequirements.Controls.Add(this.lblGamesData);
			this.panelRequirements.Controls.Add(this.lblGames);
			this.panelRequirements.Controls.Add(this.lblProfileTypeData);
			this.panelRequirements.Controls.Add(this.lblProfileType);
			this.panelRequirements.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelRequirements.CustomizableEdges.BottomRight = false;
			this.panelRequirements.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelRequirements.Location = new global::System.Drawing.Point(23, 152);
			this.panelRequirements.Name = "panelRequirements";
			this.panelRequirements.Size = new global::System.Drawing.Size(540, 142);
			this.panelRequirements.TabIndex = 75;
			this.lblClassData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblClassData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblClassData.ForeColor = global::System.Drawing.Color.White;
			this.lblClassData.Location = new global::System.Drawing.Point(170, 104);
			this.lblClassData.Name = "lblClassData";
			this.lblClassData.Size = new global::System.Drawing.Size(47, 19);
			this.lblClassData.TabIndex = 31;
			this.lblClassData.Text = "[CLASS]";
			this.lblClassData.TextAlignment = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblClass.BackColor = global::System.Drawing.Color.Transparent;
			this.lblClass.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblClass.ForeColor = global::System.Drawing.Color.White;
			this.lblClass.Location = new global::System.Drawing.Point(22, 104);
			this.lblClass.Name = "lblClass";
			this.lblClass.Size = new global::System.Drawing.Size(36, 19);
			this.lblClass.TabIndex = 30;
			this.lblClass.Text = "Class:";
			this.lblFactionData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFactionData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblFactionData.ForeColor = global::System.Drawing.Color.White;
			this.lblFactionData.Location = new global::System.Drawing.Point(170, 76);
			this.lblFactionData.Name = "lblFactionData";
			this.lblFactionData.Size = new global::System.Drawing.Size(63, 19);
			this.lblFactionData.TabIndex = 29;
			this.lblFactionData.Text = "[FACTION]";
			this.lblFactionData.TextAlignment = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblFaction.BackColor = global::System.Drawing.Color.Transparent;
			this.lblFaction.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblFaction.ForeColor = global::System.Drawing.Color.White;
			this.lblFaction.Location = new global::System.Drawing.Point(22, 76);
			this.lblFaction.Name = "lblFaction";
			this.lblFaction.Size = new global::System.Drawing.Size(47, 19);
			this.lblFaction.TabIndex = 26;
			this.lblFaction.Text = "Faction:";
			this.lblGamesData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGamesData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblGamesData.ForeColor = global::System.Drawing.Color.White;
			this.lblGamesData.Location = new global::System.Drawing.Point(170, 47);
			this.lblGamesData.Name = "lblGamesData";
			this.lblGamesData.Size = new global::System.Drawing.Size(54, 19);
			this.lblGamesData.TabIndex = 25;
			this.lblGamesData.Text = "[GAMES]";
			this.lblGames.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGames.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblGames.ForeColor = global::System.Drawing.Color.White;
			this.lblGames.Location = new global::System.Drawing.Point(22, 47);
			this.lblGames.Name = "lblGames";
			this.lblGames.Size = new global::System.Drawing.Size(54, 19);
			this.lblGames.TabIndex = 24;
			this.lblGames.Text = "Game(s):";
			this.lblProfileTypeData.BackColor = global::System.Drawing.Color.Transparent;
			this.lblProfileTypeData.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblProfileTypeData.ForeColor = global::System.Drawing.Color.White;
			this.lblProfileTypeData.Location = new global::System.Drawing.Point(170, 18);
			this.lblProfileTypeData.Name = "lblProfileTypeData";
			this.lblProfileTypeData.Size = new global::System.Drawing.Size(91, 19);
			this.lblProfileTypeData.TabIndex = 23;
			this.lblProfileTypeData.Text = "[PROFILE_TYPE]";
			this.lblProfileType.BackColor = global::System.Drawing.Color.Transparent;
			this.lblProfileType.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblProfileType.ForeColor = global::System.Drawing.Color.White;
			this.lblProfileType.Location = new global::System.Drawing.Point(22, 18);
			this.lblProfileType.Name = "lblProfileType";
			this.lblProfileType.Size = new global::System.Drawing.Size(75, 19);
			this.lblProfileType.TabIndex = 22;
			this.lblProfileType.Text = "Profile Type:";
			this.lblRequirementsInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblRequirementsInfo.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblRequirementsInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblRequirementsInfo.Location = new global::System.Drawing.Point(23, 125);
			this.lblRequirementsInfo.Name = "lblRequirementsInfo";
			this.lblRequirementsInfo.Size = new global::System.Drawing.Size(218, 19);
			this.lblRequirementsInfo.TabIndex = 74;
			this.lblRequirementsInfo.Text = "Please check again the requirements.";
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(362, 38);
			this.panelTitle.TabIndex = 71;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(292, 0);
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
			this.lblTitle.Text = "Confirm Purchase";
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnCancel.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.BorderThickness = 1;
			this.btnCancel.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnCancel.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnCancel.FillColor = global::System.Drawing.Color.FromArgb(31, 37, 46);
			this.btnCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnCancel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.btnCancel.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnCancel.Location = new global::System.Drawing.Point(24, 636);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(176, 30);
			this.btnCancel.TabIndex = 75;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnBuy);
			this.panelBtnSave.Location = new global::System.Drawing.Point(328, 616);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 77;
			this.btnBuy.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBuy.BackColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnBuy.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnBuy.DisabledState.Image = global::Jack.Properties.Resources.btn_buy_disabled;
			this.btnBuy.Enabled = false;
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
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(632, 700);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.Controls.Add(this.btnCancel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmStoreBuy";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmStoreBuy";
			base.Load += new global::System.EventHandler(this.frmStoreBuy_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelBox1.PerformLayout();
			this.imgPriceCoin.EndInit();
			this.panelRequirements.ResumeLayout(false);
			this.panelRequirements.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400039B RID: 923
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400039C RID: 924
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400039D RID: 925
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x0400039E RID: 926
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x040003A0 RID: 928
		private global::Guna.UI2.WinForms.Guna2Button btnCancel;

		// Token: 0x040003A1 RID: 929
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x040003A2 RID: 930
		private global::Guna.UI2.WinForms.Guna2Button btnBuy;

		// Token: 0x040003A3 RID: 931
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblRequirementsInfo;

		// Token: 0x040003A4 RID: 932
		private global::Guna.UI2.WinForms.Guna2Panel panelRequirements;

		// Token: 0x040003A5 RID: 933
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblFactionData;

		// Token: 0x040003A6 RID: 934
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblFaction;

		// Token: 0x040003A7 RID: 935
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblGamesData;

		// Token: 0x040003A8 RID: 936
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblGames;

		// Token: 0x040003A9 RID: 937
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblProfileTypeData;

		// Token: 0x040003AA RID: 938
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblProfileType;

		// Token: 0x040003AB RID: 939
		private global::Guna.UI2.WinForms.Guna2Separator sep1;

		// Token: 0x040003AC RID: 940
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblClassData;

		// Token: 0x040003AD RID: 941
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblClass;

		// Token: 0x040003AE RID: 942
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;

		// Token: 0x040003AF RID: 943
		private global::Guna.UI2.WinForms.Guna2Separator sep2;

		// Token: 0x040003B0 RID: 944
		private global::Guna.UI2.WinForms.Guna2Separator sep3;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.Label lblPriceData;

		// Token: 0x040003B2 RID: 946
		private global::Guna.UI2.WinForms.Guna2PictureBox imgPriceCoin;

		// Token: 0x040003B3 RID: 947
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRequirements;

		// Token: 0x040003B4 RID: 948
		private global::Guna.UI2.WinForms.Guna2CheckBox checkRefund;

		// Token: 0x040003B5 RID: 949
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;

		// Token: 0x040003B6 RID: 950
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x040003B7 RID: 951
		private global::System.Windows.Forms.Label lblGetJackCoins;

		// Token: 0x040003B8 RID: 952
		private global::System.Windows.Forms.Label lblDisplayNameData;
	}
}
