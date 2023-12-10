namespace Jack.Forms
{
	// Token: 0x02000056 RID: 86
	public partial class frmList : global::System.Windows.Forms.Form
	{
		// Token: 0x0600081B RID: 2075 RVA: 0x00680C20 File Offset: 0x0067EE20
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00680C4C File Offset: 0x0067EE4C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmList));
			this.table1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.panelBox2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnReload = new global::Guna.UI2.WinForms.Guna2Button();
			this.listData = new global::System.Windows.Forms.ListView();
			this.listDataID = new global::System.Windows.Forms.ColumnHeader();
			this.listDataName = new global::System.Windows.Forms.ColumnHeader();
			this.panelTitle2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.labelTitle2 = new global::System.Windows.Forms.Label();
			this.imgTitleEdge2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.grpAdd = new global::Guna.UI2.WinForms.Guna2GroupBox();
			this.txtValue2 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtValue1 = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnAdd = new global::Guna.UI2.WinForms.Guna2Button();
			this.txtName = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.richList = new global::System.Windows.Forms.RichTextBox();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.lblInfo = new global::System.Windows.Forms.Label();
			this.table1.SuspendLayout();
			this.panelBox2.SuspendLayout();
			this.panelTitle2.SuspendLayout();
			this.imgTitleEdge2.BeginInit();
			this.panelBox1.SuspendLayout();
			this.grpAdd.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.panelTitle1.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.table1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.table1.ColumnCount = 2;
			this.table1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.table1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.table1.Controls.Add(this.panelBox2, 1, 0);
			this.table1.Controls.Add(this.panelBox1, 0, 0);
			this.table1.Location = new global::System.Drawing.Point(24, 74);
			this.table1.Name = "table1";
			this.table1.RowCount = 1;
			this.table1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.table1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 461f));
			this.table1.Size = new global::System.Drawing.Size(617, 429);
			this.table1.TabIndex = 72;
			this.panelBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox2.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox2.Controls.Add(this.btnReload);
			this.panelBox2.Controls.Add(this.listData);
			this.panelBox2.Controls.Add(this.panelTitle2);
			this.panelBox2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox2.Location = new global::System.Drawing.Point(320, 0);
			this.panelBox2.Margin = new global::System.Windows.Forms.Padding(12, 0, 0, 0);
			this.panelBox2.Name = "panelBox2";
			this.panelBox2.Size = new global::System.Drawing.Size(297, 429);
			this.panelBox2.TabIndex = 68;
			this.btnReload.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnReload.BorderColor = global::System.Drawing.Color.Gray;
			this.btnReload.BorderThickness = 1;
			this.btnReload.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnReload.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnReload.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnReload.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnReload.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnReload.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnReload.ForeColor = global::System.Drawing.Color.White;
			this.btnReload.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnReload.Location = new global::System.Drawing.Point(14, 385);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new global::System.Drawing.Size(268, 30);
			this.btnReload.TabIndex = 69;
			this.btnReload.Text = "Reload";
			this.btnReload.Click += new global::System.EventHandler(this.btnReload_Click);
			this.listData.Alignment = global::System.Windows.Forms.ListViewAlignment.Left;
			this.listData.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listData.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listData.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listDataID,
				this.listDataName
			});
			this.listData.ForeColor = global::System.Drawing.Color.White;
			this.listData.FullRowSelect = true;
			this.listData.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listData.HideSelection = false;
			this.listData.Location = new global::System.Drawing.Point(14, 53);
			this.listData.MultiSelect = false;
			this.listData.Name = "listData";
			this.listData.OwnerDraw = true;
			this.listData.Size = new global::System.Drawing.Size(268, 326);
			this.listData.TabIndex = 53;
			this.listData.UseCompatibleStateImageBehavior = false;
			this.listData.View = global::System.Windows.Forms.View.Details;
			this.listData.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.listData_MouseDoubleClick);
			this.listData.Resize += new global::System.EventHandler(this.listData_Resize);
			this.listDataID.Text = "ID";
			this.listDataName.Text = "Name";
			this.listDataName.Width = 146;
			this.panelTitle2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle2.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle2.Controls.Add(this.labelTitle2);
			this.panelTitle2.Controls.Add(this.imgTitleEdge2);
			this.panelTitle2.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle2.Name = "panelTitle2";
			this.panelTitle2.Size = new global::System.Drawing.Size(117, 38);
			this.panelTitle2.TabIndex = 68;
			this.labelTitle2.AutoSize = true;
			this.labelTitle2.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelTitle2.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.labelTitle2.Location = new global::System.Drawing.Point(0, 2);
			this.labelTitle2.Name = "labelTitle2";
			this.labelTitle2.Size = new global::System.Drawing.Size(59, 15);
			this.labelTitle2.TabIndex = 65;
			this.labelTitle2.Text = "Data";
			this.imgTitleEdge2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge2.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge2.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge2.ImageRotate = 0f;
			this.imgTitleEdge2.Location = new global::System.Drawing.Point(47, 0);
			this.imgTitleEdge2.Name = "imgTitleEdge2";
			this.imgTitleEdge2.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge2.TabIndex = 66;
			this.imgTitleEdge2.TabStop = false;
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.grpAdd);
			this.panelBox1.Controls.Add(this.guna2Panel1);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(0, 0);
			this.panelBox1.Margin = new global::System.Windows.Forms.Padding(0, 0, 12, 0);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(296, 429);
			this.panelBox1.TabIndex = 67;
			this.grpAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.grpAdd.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAdd.Controls.Add(this.txtValue2);
			this.grpAdd.Controls.Add(this.txtValue1);
			this.grpAdd.Controls.Add(this.btnAdd);
			this.grpAdd.Controls.Add(this.txtName);
			this.grpAdd.CustomBorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.grpAdd.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.grpAdd.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.grpAdd.ForeColor = global::System.Drawing.Color.White;
			this.grpAdd.Location = new global::System.Drawing.Point(14, 200);
			this.grpAdd.Name = "grpAdd";
			this.grpAdd.Size = new global::System.Drawing.Size(268, 215);
			this.grpAdd.TabIndex = 72;
			this.grpAdd.Text = "Add";
			this.txtValue2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtValue2.BorderColor = global::System.Drawing.Color.Gray;
			this.txtValue2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtValue2.DefaultText = "";
			this.txtValue2.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtValue2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtValue2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtValue2.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtValue2.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtValue2.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtValue2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtValue2.ForeColor = global::System.Drawing.Color.White;
			this.txtValue2.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtValue2.Location = new global::System.Drawing.Point(25, 131);
			this.txtValue2.Name = "txtValue2";
			this.txtValue2.PasswordChar = '\0';
			this.txtValue2.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtValue2.PlaceholderText = "When to buy (e.g. 2)";
			this.txtValue2.SelectedText = "";
			this.txtValue2.Size = new global::System.Drawing.Size(219, 30);
			this.txtValue2.TabIndex = 70;
			this.txtValue1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtValue1.BorderColor = global::System.Drawing.Color.Gray;
			this.txtValue1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtValue1.DefaultText = "";
			this.txtValue1.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtValue1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtValue1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtValue1.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtValue1.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtValue1.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtValue1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtValue1.ForeColor = global::System.Drawing.Color.White;
			this.txtValue1.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtValue1.Location = new global::System.Drawing.Point(25, 95);
			this.txtValue1.Name = "txtValue1";
			this.txtValue1.PasswordChar = '\0';
			this.txtValue1.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtValue1.PlaceholderText = "Purchase Quantity (e.g. 20)";
			this.txtValue1.SelectedText = "";
			this.txtValue1.Size = new global::System.Drawing.Size(219, 30);
			this.txtValue1.TabIndex = 68;
			this.btnAdd.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnAdd.BorderColor = global::System.Drawing.Color.Gray;
			this.btnAdd.BorderThickness = 1;
			this.btnAdd.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnAdd.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnAdd.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnAdd.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAdd.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnAdd.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAdd.ForeColor = global::System.Drawing.Color.White;
			this.btnAdd.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnAdd.Location = new global::System.Drawing.Point(25, 167);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new global::System.Drawing.Size(219, 30);
			this.btnAdd.TabIndex = 66;
			this.btnAdd.Text = "Add";
			this.btnAdd.Click += new global::System.EventHandler(this.btnAdd_Click);
			this.txtName.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtName.BorderColor = global::System.Drawing.Color.Gray;
			this.txtName.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.txtName.DefaultText = "";
			this.txtName.DisabledState.BorderColor = global::System.Drawing.Color.Gray;
			this.txtName.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.txtName.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtName.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtName.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.txtName.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.txtName.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtName.ForeColor = global::System.Drawing.Color.White;
			this.txtName.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.txtName.Location = new global::System.Drawing.Point(25, 59);
			this.txtName.Name = "txtName";
			this.txtName.PasswordChar = '\0';
			this.txtName.PlaceholderForeColor = global::System.Drawing.Color.Gray;
			this.txtName.PlaceholderText = "Name or ID";
			this.txtName.SelectedText = "";
			this.txtName.Size = new global::System.Drawing.Size(219, 30);
			this.txtName.TabIndex = 65;
			this.guna2Panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Panel1.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.guna2Panel1.BorderColor = global::System.Drawing.Color.Gray;
			this.guna2Panel1.BorderThickness = 1;
			this.guna2Panel1.Controls.Add(this.richList);
			this.guna2Panel1.CustomBorderColor = global::System.Drawing.Color.Gray;
			this.guna2Panel1.Location = new global::System.Drawing.Point(14, 53);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(268, 132);
			this.guna2Panel1.TabIndex = 71;
			this.richList.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.richList.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.richList.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richList.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.richList.ForeColor = global::System.Drawing.Color.White;
			this.richList.Location = new global::System.Drawing.Point(10, 10);
			this.richList.Name = "richList";
			this.richList.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.richList.Size = new global::System.Drawing.Size(249, 113);
			this.richList.TabIndex = 11;
			this.richList.Text = "";
			this.panelTitle1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle1.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle1.Controls.Add(this.lblTitle1);
			this.panelTitle1.Controls.Add(this.imgTitleEdge1);
			this.panelTitle1.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle1.Name = "panelTitle1";
			this.panelTitle1.Size = new global::System.Drawing.Size(116, 38);
			this.panelTitle1.TabIndex = 68;
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle1.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle1.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new global::System.Drawing.Size(51, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "List";
			this.imgTitleEdge1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge1.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge1.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge1.ImageRotate = 0f;
			this.imgTitleEdge1.Location = new global::System.Drawing.Point(46, 0);
			this.imgTitleEdge1.Name = "imgTitleEdge1";
			this.imgTitleEdge1.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge1.TabIndex = 66;
			this.imgTitleEdge1.TabStop = false;
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(361, 503);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 75;
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
			this.btnSave.Location = new global::System.Drawing.Point(30, -1);
			this.btnSave.Name = "btnSave";
			this.btnSave.PressedDepth = 0;
			this.btnSave.Size = new global::System.Drawing.Size(235, 44);
			this.btnSave.TabIndex = 0;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.lblInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblInfo.BackColor = global::System.Drawing.Color.Transparent;
			this.lblInfo.ForeColor = global::System.Drawing.Color.CornflowerBlue;
			this.lblInfo.Location = new global::System.Drawing.Point(24, 510);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new global::System.Drawing.Size(296, 48);
			this.lblInfo.TabIndex = 76;
			this.lblInfo.Text = "[INFO]";
			this.lblInfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(662, 583);
			base.Controls.Add(this.lblInfo);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.table1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(662, 583);
			base.Name = "frmList";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmList";
			base.Load += new global::System.EventHandler(this.frmList_Load);
			this.table1.ResumeLayout(false);
			this.panelBox2.ResumeLayout(false);
			this.panelTitle2.ResumeLayout(false);
			this.panelTitle2.PerformLayout();
			this.imgTitleEdge2.EndInit();
			this.panelBox1.ResumeLayout(false);
			this.grpAdd.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.imgTitleEdge1.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000252 RID: 594
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000253 RID: 595
		private global::System.Windows.Forms.TableLayoutPanel table1;

		// Token: 0x04000254 RID: 596
		private global::Guna.UI2.WinForms.Guna2Panel panelBox2;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Forms.ListView listData;

		// Token: 0x04000256 RID: 598
		private global::System.Windows.Forms.ColumnHeader listDataID;

		// Token: 0x04000257 RID: 599
		private global::System.Windows.Forms.ColumnHeader listDataName;

		// Token: 0x04000258 RID: 600
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle2;

		// Token: 0x04000259 RID: 601
		private global::System.Windows.Forms.Label labelTitle2;

		// Token: 0x0400025A RID: 602
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge2;

		// Token: 0x0400025B RID: 603
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x0400025C RID: 604
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x0400025D RID: 605
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x0400025E RID: 606
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x0400025F RID: 607
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x04000260 RID: 608
		private global::System.Windows.Forms.RichTextBox richList;

		// Token: 0x04000261 RID: 609
		private global::Guna.UI2.WinForms.Guna2GroupBox grpAdd;

		// Token: 0x04000262 RID: 610
		private global::Guna.UI2.WinForms.Guna2Button btnAdd;

		// Token: 0x04000263 RID: 611
		private global::Guna.UI2.WinForms.Guna2TextBox txtName;

		// Token: 0x04000264 RID: 612
		private global::Guna.UI2.WinForms.Guna2TextBox txtValue1;

		// Token: 0x04000265 RID: 613
		private global::Guna.UI2.WinForms.Guna2TextBox txtValue2;

		// Token: 0x04000266 RID: 614
		private global::Guna.UI2.WinForms.Guna2Button btnReload;

		// Token: 0x04000267 RID: 615
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x04000268 RID: 616
		private global::Guna.UI2.WinForms.Guna2Button btnSave;

		// Token: 0x04000269 RID: 617
		private global::System.Windows.Forms.Label lblInfo;
	}
}
