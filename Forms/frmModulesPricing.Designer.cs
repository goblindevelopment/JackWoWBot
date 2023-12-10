namespace Jack.Forms
{
	// Token: 0x02000059 RID: 89
	public partial class frmModulesPricing : global::System.Windows.Forms.Form
	{
		// Token: 0x06000883 RID: 2179 RVA: 0x00683194 File Offset: 0x00681394
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x006831C0 File Offset: 0x006813C0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmModulesPricing));
			this.grpGather = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnGather = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgModuleGather = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelGather = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblGatherInfo2 = new global::System.Windows.Forms.Label();
			this.lblGatherTitle2 = new global::System.Windows.Forms.Label();
			this.lblGatherInfo1 = new global::System.Windows.Forms.Label();
			this.lblGatherTitle1 = new global::System.Windows.Forms.Label();
			this.lblGatherPrice = new global::System.Windows.Forms.Label();
			this.grpDungeon = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.panelDungeon = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblModuleInfo2 = new global::System.Windows.Forms.Label();
			this.lblModuleTitle2 = new global::System.Windows.Forms.Label();
			this.lblModuleInfo1 = new global::System.Windows.Forms.Label();
			this.lblModuleTitle1 = new global::System.Windows.Forms.Label();
			this.lblDungeonPrice = new global::System.Windows.Forms.Label();
			this.btnDungeon = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgModuleDungeon = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.grpNotify = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnNotify = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgModuleNotify = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelNotify = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblNotifyInfo2 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblNotifyInfo1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblNotifyTitle1 = new global::System.Windows.Forms.Label();
			this.lblNotifyPrice = new global::System.Windows.Forms.Label();
			this.grpSession = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.btnSession = new global::Guna.UI2.WinForms.Guna2Button();
			this.imgModuleSession = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelSession = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblSessionInfo2 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblSessionInfo1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblSessionTitle1 = new global::System.Windows.Forms.Label();
			this.lblSessionPrice = new global::System.Windows.Forms.Label();
			this.grpGather.SuspendLayout();
			this.imgModuleGather.BeginInit();
			this.panelGather.SuspendLayout();
			this.grpDungeon.SuspendLayout();
			this.panelDungeon.SuspendLayout();
			this.imgModuleDungeon.BeginInit();
			this.grpNotify.SuspendLayout();
			this.imgModuleNotify.BeginInit();
			this.panelNotify.SuspendLayout();
			this.grpSession.SuspendLayout();
			this.imgModuleSession.BeginInit();
			this.panelSession.SuspendLayout();
			base.SuspendLayout();
			this.grpGather.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpGather.Controls.Add(this.btnGather);
			this.grpGather.Controls.Add(this.imgModuleGather);
			this.grpGather.Controls.Add(this.panelGather);
			this.grpGather.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpGather.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 50, 0, 0);
			this.grpGather.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpGather.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpGather.ForeColor = global::System.Drawing.Color.White;
			this.grpGather.Location = new global::System.Drawing.Point(237, 86);
			this.grpGather.Name = "grpGather";
			this.grpGather.Size = new global::System.Drawing.Size(208, 338);
			this.grpGather.TabIndex = 117;
			this.btnGather.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnGather.BorderColor = global::System.Drawing.Color.Gray;
			this.btnGather.BorderThickness = 1;
			this.btnGather.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnGather.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnGather.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnGather.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnGather.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnGather.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnGather.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnGather.ForeColor = global::System.Drawing.Color.White;
			this.btnGather.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnGather.Location = new global::System.Drawing.Point(0, 291);
			this.btnGather.Name = "btnGather";
			this.btnGather.Size = new global::System.Drawing.Size(208, 47);
			this.btnGather.TabIndex = 100;
			this.btnGather.Text = "SHOP NOW";
			this.btnGather.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.imgModuleGather.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleGather.Image = global::Jack.Properties.Resources.module_gathering;
			this.imgModuleGather.ImageRotate = 0f;
			this.imgModuleGather.Location = new global::System.Drawing.Point(37, 13);
			this.imgModuleGather.Name = "imgModuleGather";
			this.imgModuleGather.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleGather.TabIndex = 99;
			this.imgModuleGather.TabStop = false;
			this.panelGather.BackColor = global::System.Drawing.Color.Transparent;
			this.panelGather.BackgroundImage = global::Jack.Properties.Resources.module_gather_bg;
			this.panelGather.Controls.Add(this.lblGatherInfo2);
			this.panelGather.Controls.Add(this.lblGatherTitle2);
			this.panelGather.Controls.Add(this.lblGatherInfo1);
			this.panelGather.Controls.Add(this.lblGatherTitle1);
			this.panelGather.Controls.Add(this.lblGatherPrice);
			this.panelGather.Location = new global::System.Drawing.Point(0, 51);
			this.panelGather.Name = "panelGather";
			this.panelGather.Size = new global::System.Drawing.Size(208, 239);
			this.panelGather.TabIndex = 102;
			this.lblGatherInfo2.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblGatherInfo2.Location = new global::System.Drawing.Point(18, 136);
			this.lblGatherInfo2.Name = "lblGatherInfo2";
			this.lblGatherInfo2.Size = new global::System.Drawing.Size(169, 44);
			this.lblGatherInfo2.TabIndex = 106;
			this.lblGatherInfo2.Text = "+ Applies to all sessions\r\n+ Immediately available";
			this.lblGatherTitle2.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold);
			this.lblGatherTitle2.ForeColor = global::System.Drawing.Color.Gold;
			this.lblGatherTitle2.Location = new global::System.Drawing.Point(18, 112);
			this.lblGatherTitle2.Name = "lblGatherTitle2";
			this.lblGatherTitle2.Size = new global::System.Drawing.Size(169, 21);
			this.lblGatherTitle2.TabIndex = 105;
			this.lblGatherTitle2.Text = "Advantages";
			this.lblGatherInfo1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblGatherInfo1.Location = new global::System.Drawing.Point(18, 44);
			this.lblGatherInfo1.Name = "lblGatherInfo1";
			this.lblGatherInfo1.Size = new global::System.Drawing.Size(187, 61);
			this.lblGatherInfo1.TabIndex = 104;
			this.lblGatherInfo1.Text = "+ Mining and Herbalism\r\n+ Skinning\r\n+ All Gather Events";
			this.lblGatherTitle1.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold);
			this.lblGatherTitle1.ForeColor = global::System.Drawing.Color.Gold;
			this.lblGatherTitle1.Location = new global::System.Drawing.Point(18, 20);
			this.lblGatherTitle1.Name = "lblGatherTitle1";
			this.lblGatherTitle1.Size = new global::System.Drawing.Size(169, 21);
			this.lblGatherTitle1.TabIndex = 103;
			this.lblGatherTitle1.Text = "Use all Professions";
			this.lblGatherPrice.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblGatherPrice.BackColor = global::System.Drawing.Color.Transparent;
			this.lblGatherPrice.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold);
			this.lblGatherPrice.ForeColor = global::System.Drawing.Color.Gold;
			this.lblGatherPrice.Location = new global::System.Drawing.Point(0, 188);
			this.lblGatherPrice.Name = "lblGatherPrice";
			this.lblGatherPrice.Size = new global::System.Drawing.Size(208, 37);
			this.lblGatherPrice.TabIndex = 101;
			this.lblGatherPrice.Text = "4.99 €";
			this.lblGatherPrice.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.grpDungeon.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpDungeon.Controls.Add(this.panelDungeon);
			this.grpDungeon.Controls.Add(this.btnDungeon);
			this.grpDungeon.Controls.Add(this.imgModuleDungeon);
			this.grpDungeon.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpDungeon.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 50, 0, 0);
			this.grpDungeon.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpDungeon.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpDungeon.ForeColor = global::System.Drawing.Color.White;
			this.grpDungeon.Location = new global::System.Drawing.Point(460, 86);
			this.grpDungeon.Name = "grpDungeon";
			this.grpDungeon.Size = new global::System.Drawing.Size(208, 338);
			this.grpDungeon.TabIndex = 119;
			this.panelDungeon.BackColor = global::System.Drawing.Color.Transparent;
			this.panelDungeon.BackgroundImage = global::Jack.Properties.Resources.module_dungeon_bg;
			this.panelDungeon.Controls.Add(this.lblModuleInfo2);
			this.panelDungeon.Controls.Add(this.lblModuleTitle2);
			this.panelDungeon.Controls.Add(this.lblModuleInfo1);
			this.panelDungeon.Controls.Add(this.lblModuleTitle1);
			this.panelDungeon.Controls.Add(this.lblDungeonPrice);
			this.panelDungeon.Location = new global::System.Drawing.Point(0, 51);
			this.panelDungeon.Name = "panelDungeon";
			this.panelDungeon.Size = new global::System.Drawing.Size(208, 239);
			this.panelDungeon.TabIndex = 103;
			this.lblModuleInfo2.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblModuleInfo2.Location = new global::System.Drawing.Point(18, 136);
			this.lblModuleInfo2.Name = "lblModuleInfo2";
			this.lblModuleInfo2.Size = new global::System.Drawing.Size(169, 44);
			this.lblModuleInfo2.TabIndex = 110;
			this.lblModuleInfo2.Text = "+ Applies to all sessions\r\n+ Immediately available";
			this.lblModuleTitle2.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold);
			this.lblModuleTitle2.ForeColor = global::System.Drawing.Color.Gold;
			this.lblModuleTitle2.Location = new global::System.Drawing.Point(18, 112);
			this.lblModuleTitle2.Name = "lblModuleTitle2";
			this.lblModuleTitle2.Size = new global::System.Drawing.Size(169, 21);
			this.lblModuleTitle2.TabIndex = 109;
			this.lblModuleTitle2.Text = "Advantages";
			this.lblModuleInfo1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblModuleInfo1.Location = new global::System.Drawing.Point(18, 44);
			this.lblModuleInfo1.Name = "lblModuleInfo1";
			this.lblModuleInfo1.Size = new global::System.Drawing.Size(185, 61);
			this.lblModuleInfo1.TabIndex = 108;
			this.lblModuleInfo1.Text = "+ All Dungeon Entries\r\n+ All \"Go Through\" Portals\r\n+ All Dungeon Events";
			this.lblModuleTitle1.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold);
			this.lblModuleTitle1.ForeColor = global::System.Drawing.Color.Gold;
			this.lblModuleTitle1.Location = new global::System.Drawing.Point(18, 20);
			this.lblModuleTitle1.Name = "lblModuleTitle1";
			this.lblModuleTitle1.Size = new global::System.Drawing.Size(169, 21);
			this.lblModuleTitle1.TabIndex = 107;
			this.lblModuleTitle1.Text = "Use all Dungeons";
			this.lblDungeonPrice.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblDungeonPrice.BackColor = global::System.Drawing.Color.Transparent;
			this.lblDungeonPrice.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold);
			this.lblDungeonPrice.ForeColor = global::System.Drawing.Color.Gold;
			this.lblDungeonPrice.Location = new global::System.Drawing.Point(0, 188);
			this.lblDungeonPrice.Name = "lblDungeonPrice";
			this.lblDungeonPrice.Size = new global::System.Drawing.Size(208, 37);
			this.lblDungeonPrice.TabIndex = 101;
			this.lblDungeonPrice.Text = "4.99 €";
			this.lblDungeonPrice.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.btnDungeon.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnDungeon.BorderColor = global::System.Drawing.Color.Gray;
			this.btnDungeon.BorderThickness = 1;
			this.btnDungeon.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnDungeon.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnDungeon.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnDungeon.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnDungeon.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnDungeon.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnDungeon.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnDungeon.ForeColor = global::System.Drawing.Color.White;
			this.btnDungeon.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnDungeon.Location = new global::System.Drawing.Point(0, 291);
			this.btnDungeon.Name = "btnDungeon";
			this.btnDungeon.Size = new global::System.Drawing.Size(208, 47);
			this.btnDungeon.TabIndex = 101;
			this.btnDungeon.Text = "SHOP NOW";
			this.btnDungeon.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.imgModuleDungeon.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleDungeon.Image = global::Jack.Properties.Resources.module_dungeons;
			this.imgModuleDungeon.ImageRotate = 0f;
			this.imgModuleDungeon.Location = new global::System.Drawing.Point(33, 13);
			this.imgModuleDungeon.Name = "imgModuleDungeon";
			this.imgModuleDungeon.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleDungeon.TabIndex = 99;
			this.imgModuleDungeon.TabStop = false;
			this.grpNotify.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpNotify.Controls.Add(this.btnNotify);
			this.grpNotify.Controls.Add(this.imgModuleNotify);
			this.grpNotify.Controls.Add(this.panelNotify);
			this.grpNotify.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpNotify.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 50, 0, 0);
			this.grpNotify.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpNotify.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpNotify.ForeColor = global::System.Drawing.Color.White;
			this.grpNotify.Location = new global::System.Drawing.Point(683, 114);
			this.grpNotify.Name = "grpNotify";
			this.grpNotify.Size = new global::System.Drawing.Size(187, 279);
			this.grpNotify.TabIndex = 121;
			this.btnNotify.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnNotify.BorderColor = global::System.Drawing.Color.Gray;
			this.btnNotify.BorderThickness = 1;
			this.btnNotify.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnNotify.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotify.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnNotify.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnNotify.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnNotify.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnNotify.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnNotify.ForeColor = global::System.Drawing.Color.White;
			this.btnNotify.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnNotify.Location = new global::System.Drawing.Point(0, 232);
			this.btnNotify.Name = "btnNotify";
			this.btnNotify.Size = new global::System.Drawing.Size(187, 47);
			this.btnNotify.TabIndex = 101;
			this.btnNotify.Text = "SHOP NOW";
			this.btnNotify.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.imgModuleNotify.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleNotify.Image = global::Jack.Properties.Resources.module_notifications;
			this.imgModuleNotify.ImageRotate = 0f;
			this.imgModuleNotify.Location = new global::System.Drawing.Point(31, 13);
			this.imgModuleNotify.Name = "imgModuleNotify";
			this.imgModuleNotify.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleNotify.TabIndex = 99;
			this.imgModuleNotify.TabStop = false;
			this.panelNotify.BackColor = global::System.Drawing.Color.Transparent;
			this.panelNotify.BackgroundImage = global::Jack.Properties.Resources.module_notify_bg;
			this.panelNotify.Controls.Add(this.lblNotifyInfo2);
			this.panelNotify.Controls.Add(this.lblNotifyInfo1);
			this.panelNotify.Controls.Add(this.lblNotifyTitle1);
			this.panelNotify.Controls.Add(this.lblNotifyPrice);
			this.panelNotify.Location = new global::System.Drawing.Point(0, 51);
			this.panelNotify.Name = "panelNotify";
			this.panelNotify.Size = new global::System.Drawing.Size(187, 180);
			this.panelNotify.TabIndex = 104;
			this.lblNotifyInfo2.AutoSize = false;
			this.lblNotifyInfo2.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyInfo2.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblNotifyInfo2.ForeColor = global::System.Drawing.Color.White;
			this.lblNotifyInfo2.Location = new global::System.Drawing.Point(23, 86);
			this.lblNotifyInfo2.Name = "lblNotifyInfo2";
			this.lblNotifyInfo2.Size = new global::System.Drawing.Size(160, 42);
			this.lblNotifyInfo2.TabIndex = 111;
			this.lblNotifyInfo2.Text = "Never miss important events again!";
			this.lblNotifyInfo1.AutoSize = false;
			this.lblNotifyInfo1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyInfo1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblNotifyInfo1.ForeColor = global::System.Drawing.Color.White;
			this.lblNotifyInfo1.Location = new global::System.Drawing.Point(23, 45);
			this.lblNotifyInfo1.Name = "lblNotifyInfo1";
			this.lblNotifyInfo1.Size = new global::System.Drawing.Size(160, 42);
			this.lblNotifyInfo1.TabIndex = 110;
			this.lblNotifyInfo1.Text = "Stay informed via<br>\r\n<b>Discord</b> and <b>Pushover</b>.";
			this.lblNotifyTitle1.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold);
			this.lblNotifyTitle1.ForeColor = global::System.Drawing.Color.Gold;
			this.lblNotifyTitle1.Location = new global::System.Drawing.Point(19, 20);
			this.lblNotifyTitle1.Name = "lblNotifyTitle1";
			this.lblNotifyTitle1.Size = new global::System.Drawing.Size(169, 21);
			this.lblNotifyTitle1.TabIndex = 109;
			this.lblNotifyTitle1.Text = "Keep up to date";
			this.lblNotifyPrice.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblNotifyPrice.BackColor = global::System.Drawing.Color.Transparent;
			this.lblNotifyPrice.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold);
			this.lblNotifyPrice.ForeColor = global::System.Drawing.Color.Gold;
			this.lblNotifyPrice.Location = new global::System.Drawing.Point(0, 132);
			this.lblNotifyPrice.Name = "lblNotifyPrice";
			this.lblNotifyPrice.Size = new global::System.Drawing.Size(187, 37);
			this.lblNotifyPrice.TabIndex = 103;
			this.lblNotifyPrice.Text = "2.99 €";
			this.lblNotifyPrice.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.grpSession.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSession.Controls.Add(this.btnSession);
			this.grpSession.Controls.Add(this.imgModuleSession);
			this.grpSession.Controls.Add(this.panelSession);
			this.grpSession.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpSession.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 50, 0, 0);
			this.grpSession.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpSession.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpSession.ForeColor = global::System.Drawing.Color.White;
			this.grpSession.Location = new global::System.Drawing.Point(35, 114);
			this.grpSession.Name = "grpSession";
			this.grpSession.Size = new global::System.Drawing.Size(187, 279);
			this.grpSession.TabIndex = 120;
			this.btnSession.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSession.BorderColor = global::System.Drawing.Color.Gray;
			this.btnSession.BorderThickness = 1;
			this.btnSession.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnSession.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnSession.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnSession.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnSession.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnSession.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnSession.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.btnSession.ForeColor = global::System.Drawing.Color.White;
			this.btnSession.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnSession.Location = new global::System.Drawing.Point(0, 232);
			this.btnSession.Name = "btnSession";
			this.btnSession.Size = new global::System.Drawing.Size(187, 47);
			this.btnSession.TabIndex = 101;
			this.btnSession.Text = "SHOP NOW";
			this.btnSession.Click += new global::System.EventHandler(this.LinkToModule_Click);
			this.imgModuleSession.BackColor = global::System.Drawing.Color.Transparent;
			this.imgModuleSession.Image = global::Jack.Properties.Resources.module_sessions;
			this.imgModuleSession.ImageRotate = 0f;
			this.imgModuleSession.Location = new global::System.Drawing.Point(28, 13);
			this.imgModuleSession.Name = "imgModuleSession";
			this.imgModuleSession.Size = new global::System.Drawing.Size(137, 24);
			this.imgModuleSession.TabIndex = 99;
			this.imgModuleSession.TabStop = false;
			this.panelSession.BackColor = global::System.Drawing.Color.Transparent;
			this.panelSession.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelSession.BackgroundImage");
			this.panelSession.Controls.Add(this.lblSessionInfo2);
			this.panelSession.Controls.Add(this.lblSessionInfo1);
			this.panelSession.Controls.Add(this.lblSessionTitle1);
			this.panelSession.Controls.Add(this.lblSessionPrice);
			this.panelSession.Location = new global::System.Drawing.Point(0, 51);
			this.panelSession.Name = "panelSession";
			this.panelSession.Size = new global::System.Drawing.Size(187, 180);
			this.panelSession.TabIndex = 105;
			this.lblSessionInfo2.AutoSize = false;
			this.lblSessionInfo2.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSessionInfo2.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblSessionInfo2.ForeColor = global::System.Drawing.Color.White;
			this.lblSessionInfo2.Location = new global::System.Drawing.Point(23, 86);
			this.lblSessionInfo2.Name = "lblSessionInfo2";
			this.lblSessionInfo2.Size = new global::System.Drawing.Size(160, 42);
			this.lblSessionInfo2.TabIndex = 114;
			this.lblSessionInfo2.Text = "Use it without restrictions like your main license.";
			this.lblSessionInfo1.AutoSize = false;
			this.lblSessionInfo1.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSessionInfo1.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblSessionInfo1.ForeColor = global::System.Drawing.Color.White;
			this.lblSessionInfo1.Location = new global::System.Drawing.Point(23, 45);
			this.lblSessionInfo1.Name = "lblSessionInfo1";
			this.lblSessionInfo1.Size = new global::System.Drawing.Size(160, 42);
			this.lblSessionInfo1.TabIndex = 113;
			this.lblSessionInfo1.Text = "Add another session to your license.";
			this.lblSessionTitle1.Font = new global::System.Drawing.Font("Segoe UI", 10f, global::System.Drawing.FontStyle.Bold);
			this.lblSessionTitle1.ForeColor = global::System.Drawing.Color.Gold;
			this.lblSessionTitle1.Location = new global::System.Drawing.Point(19, 20);
			this.lblSessionTitle1.Name = "lblSessionTitle1";
			this.lblSessionTitle1.Size = new global::System.Drawing.Size(169, 21);
			this.lblSessionTitle1.TabIndex = 112;
			this.lblSessionTitle1.Text = "Save Money!";
			this.lblSessionPrice.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblSessionPrice.BackColor = global::System.Drawing.Color.Transparent;
			this.lblSessionPrice.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold);
			this.lblSessionPrice.ForeColor = global::System.Drawing.Color.Gold;
			this.lblSessionPrice.Location = new global::System.Drawing.Point(0, 132);
			this.lblSessionPrice.Name = "lblSessionPrice";
			this.lblSessionPrice.Size = new global::System.Drawing.Size(187, 37);
			this.lblSessionPrice.TabIndex = 102;
			this.lblSessionPrice.Text = "9.99 €";
			this.lblSessionPrice.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(905, 461);
			base.Controls.Add(this.grpNotify);
			base.Controls.Add(this.grpSession);
			base.Controls.Add(this.grpDungeon);
			base.Controls.Add(this.grpGather);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmModulesPricing";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmModulesPricing";
			base.Load += new global::System.EventHandler(this.frmModulesPricing_Load);
			this.grpGather.ResumeLayout(false);
			this.imgModuleGather.EndInit();
			this.panelGather.ResumeLayout(false);
			this.grpDungeon.ResumeLayout(false);
			this.panelDungeon.ResumeLayout(false);
			this.imgModuleDungeon.EndInit();
			this.grpNotify.ResumeLayout(false);
			this.imgModuleNotify.EndInit();
			this.panelNotify.ResumeLayout(false);
			this.grpSession.ResumeLayout(false);
			this.imgModuleSession.EndInit();
			this.panelSession.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000277 RID: 631
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000278 RID: 632
		private global::Guna.UI2.WinForms.Guna2GroupBox grpGather;

		// Token: 0x04000279 RID: 633
		private global::Guna.UI2.WinForms.Guna2GroupBox grpDungeon;

		// Token: 0x0400027A RID: 634
		private global::Guna.UI2.WinForms.Guna2GroupBox grpNotify;

		// Token: 0x0400027B RID: 635
		private global::Guna.UI2.WinForms.Guna2GroupBox grpSession;

		// Token: 0x0400027C RID: 636
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleGather;

		// Token: 0x0400027D RID: 637
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleDungeon;

		// Token: 0x0400027E RID: 638
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleSession;

		// Token: 0x0400027F RID: 639
		private global::Guna.UI2.WinForms.Guna2PictureBox imgModuleNotify;

		// Token: 0x04000280 RID: 640
		private global::Guna.UI2.WinForms.Guna2Button btnGather;

		// Token: 0x04000281 RID: 641
		private global::Guna.UI2.WinForms.Guna2Button btnDungeon;

		// Token: 0x04000282 RID: 642
		private global::Guna.UI2.WinForms.Guna2Button btnNotify;

		// Token: 0x04000283 RID: 643
		private global::Guna.UI2.WinForms.Guna2Button btnSession;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Forms.Label lblGatherPrice;

		// Token: 0x04000285 RID: 645
		private global::System.Windows.Forms.Label lblNotifyPrice;

		// Token: 0x04000286 RID: 646
		private global::System.Windows.Forms.Label lblSessionPrice;

		// Token: 0x04000287 RID: 647
		private global::Guna.UI2.WinForms.Guna2Panel panelGather;

		// Token: 0x04000288 RID: 648
		private global::Guna.UI2.WinForms.Guna2Panel panelDungeon;

		// Token: 0x04000289 RID: 649
		private global::System.Windows.Forms.Label lblDungeonPrice;

		// Token: 0x0400028A RID: 650
		private global::Guna.UI2.WinForms.Guna2Panel panelNotify;

		// Token: 0x0400028B RID: 651
		private global::Guna.UI2.WinForms.Guna2Panel panelSession;

		// Token: 0x0400028C RID: 652
		private global::System.Windows.Forms.Label lblGatherInfo2;

		// Token: 0x0400028D RID: 653
		private global::System.Windows.Forms.Label lblGatherTitle2;

		// Token: 0x0400028E RID: 654
		private global::System.Windows.Forms.Label lblGatherInfo1;

		// Token: 0x0400028F RID: 655
		private global::System.Windows.Forms.Label lblGatherTitle1;

		// Token: 0x04000290 RID: 656
		private global::System.Windows.Forms.Label lblModuleInfo2;

		// Token: 0x04000291 RID: 657
		private global::System.Windows.Forms.Label lblModuleTitle2;

		// Token: 0x04000292 RID: 658
		private global::System.Windows.Forms.Label lblModuleInfo1;

		// Token: 0x04000293 RID: 659
		private global::System.Windows.Forms.Label lblModuleTitle1;

		// Token: 0x04000294 RID: 660
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblNotifyInfo2;

		// Token: 0x04000295 RID: 661
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblNotifyInfo1;

		// Token: 0x04000296 RID: 662
		private global::System.Windows.Forms.Label lblNotifyTitle1;

		// Token: 0x04000297 RID: 663
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblSessionInfo2;

		// Token: 0x04000298 RID: 664
		private global::Guna.UI2.WinForms.Guna2HtmlLabel lblSessionInfo1;

		// Token: 0x04000299 RID: 665
		private global::System.Windows.Forms.Label lblSessionTitle1;
	}
}
