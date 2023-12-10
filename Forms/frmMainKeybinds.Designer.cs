namespace Jack.Forms
{
	// Token: 0x02000092 RID: 146
	public partial class frmMainKeybinds : global::System.Windows.Forms.Form
	{
		// Token: 0x06000ED8 RID: 3800 RVA: 0x006CF16C File Offset: 0x006CD36C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x006CF198 File Offset: 0x006CD398
		private void InitializeComponent()
		{
			this.listKeybindsCustom = new global::System.Windows.Forms.ListView();
			this.listKeybindsCustomAction = new global::System.Windows.Forms.ColumnHeader();
			this.listKeybindsCustomKey = new global::System.Windows.Forms.ColumnHeader();
			this.listKeybindsDefault = new global::System.Windows.Forms.ListView();
			this.listKeybindsName = new global::System.Windows.Forms.ColumnHeader();
			this.listKeybindsKey = new global::System.Windows.Forms.ColumnHeader();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblKeybindsCustomInfo = new global::System.Windows.Forms.Label();
			this.btnKeybindsTooltip = new global::Guna.UI2.WinForms.Guna2Button();
			this.table1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.panelBox2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnKeybindsAddonSet = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnKeybindsAddonApply = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelTitle2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.labelTitle2 = new global::System.Windows.Forms.Label();
			this.imgTitleEdge2 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.panelTitle1.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			this.panelBox1.SuspendLayout();
			this.table1.SuspendLayout();
			this.panelBox2.SuspendLayout();
			this.panelTitle2.SuspendLayout();
			this.imgTitleEdge2.BeginInit();
			base.SuspendLayout();
			this.listKeybindsCustom.Alignment = global::System.Windows.Forms.ListViewAlignment.Left;
			this.listKeybindsCustom.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listKeybindsCustom.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listKeybindsCustom.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listKeybindsCustomAction,
				this.listKeybindsCustomKey
			});
			this.listKeybindsCustom.ForeColor = global::System.Drawing.Color.White;
			this.listKeybindsCustom.FullRowSelect = true;
			this.listKeybindsCustom.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listKeybindsCustom.HideSelection = false;
			this.listKeybindsCustom.Location = new global::System.Drawing.Point(14, 53);
			this.listKeybindsCustom.MultiSelect = false;
			this.listKeybindsCustom.Name = "listKeybindsCustom";
			this.listKeybindsCustom.OwnerDraw = true;
			this.listKeybindsCustom.Size = new global::System.Drawing.Size(406, 200);
			this.listKeybindsCustom.TabIndex = 54;
			this.listKeybindsCustom.UseCompatibleStateImageBehavior = false;
			this.listKeybindsCustom.View = global::System.Windows.Forms.View.Details;
			this.listKeybindsCustom.DoubleClick += new global::System.EventHandler(this.listKeybindsCustom_DoubleClick);
			this.listKeybindsCustom.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listKeybindsCustom_KeyDown);
			this.listKeybindsCustomAction.Text = "Action";
			this.listKeybindsCustomAction.Width = 100;
			this.listKeybindsCustomKey.Text = "Key";
			this.listKeybindsCustomKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.listKeybindsCustomKey.Width = 100;
			this.listKeybindsDefault.Alignment = global::System.Windows.Forms.ListViewAlignment.Left;
			this.listKeybindsDefault.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.listKeybindsDefault.BackColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.listKeybindsDefault.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.listKeybindsName,
				this.listKeybindsKey
			});
			this.listKeybindsDefault.ForeColor = global::System.Drawing.Color.White;
			this.listKeybindsDefault.FullRowSelect = true;
			this.listKeybindsDefault.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listKeybindsDefault.HideSelection = false;
			this.listKeybindsDefault.Location = new global::System.Drawing.Point(14, 53);
			this.listKeybindsDefault.MultiSelect = false;
			this.listKeybindsDefault.Name = "listKeybindsDefault";
			this.listKeybindsDefault.OwnerDraw = true;
			this.listKeybindsDefault.Size = new global::System.Drawing.Size(406, 200);
			this.listKeybindsDefault.TabIndex = 53;
			this.listKeybindsDefault.UseCompatibleStateImageBehavior = false;
			this.listKeybindsDefault.View = global::System.Windows.Forms.View.Details;
			this.listKeybindsDefault.DoubleClick += new global::System.EventHandler(this.listKeybindsDefault_DoubleClick);
			this.listKeybindsDefault.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.listKeybindsDefault_KeyDown);
			this.listKeybindsName.Text = "Action";
			this.listKeybindsName.Width = 100;
			this.listKeybindsKey.Text = "Key";
			this.listKeybindsKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.listKeybindsKey.Width = 100;
			this.panelTitle1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle1.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle1.Controls.Add(this.imgTitleEdge1);
			this.panelTitle1.Controls.Add(this.lblTitle1);
			this.panelTitle1.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle1.Name = "panelTitle1";
			this.panelTitle1.Size = new global::System.Drawing.Size(255, 38);
			this.panelTitle1.TabIndex = 68;
			this.imgTitleEdge1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge1.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge1.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge1.ImageRotate = 0f;
			this.imgTitleEdge1.Location = new global::System.Drawing.Point(185, 0);
			this.imgTitleEdge1.Name = "imgTitleEdge1";
			this.imgTitleEdge1.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge1.TabIndex = 66;
			this.imgTitleEdge1.TabStop = false;
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle1.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle1.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new global::System.Drawing.Size(86, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "Custom";
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.lblKeybindsCustomInfo);
			this.panelBox1.Controls.Add(this.btnKeybindsTooltip);
			this.panelBox1.Controls.Add(this.listKeybindsCustom);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(0, 0);
			this.panelBox1.Margin = new global::System.Windows.Forms.Padding(0, 0, 12, 0);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(435, 313);
			this.panelBox1.TabIndex = 67;
			this.lblKeybindsCustomInfo.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblKeybindsCustomInfo.AutoEllipsis = true;
			this.lblKeybindsCustomInfo.ForeColor = global::System.Drawing.Color.White;
			this.lblKeybindsCustomInfo.Location = new global::System.Drawing.Point(14, 270);
			this.lblKeybindsCustomInfo.Name = "lblKeybindsCustomInfo";
			this.lblKeybindsCustomInfo.Size = new global::System.Drawing.Size(406, 26);
			this.lblKeybindsCustomInfo.TabIndex = 75;
			this.lblKeybindsCustomInfo.Text = "Changes to custom keybinds are not automatically applied by Jack.\r\nPlease make sure that these keybinds match the keybinds in game.";
			this.btnKeybindsTooltip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnKeybindsTooltip.BackColor = global::System.Drawing.Color.Transparent;
			this.btnKeybindsTooltip.BorderColor = global::System.Drawing.Color.Empty;
			this.btnKeybindsTooltip.BorderRadius = 4;
			this.btnKeybindsTooltip.BorderThickness = 1;
			this.btnKeybindsTooltip.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.btnKeybindsTooltip.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnKeybindsTooltip.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnKeybindsTooltip.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnKeybindsTooltip.FillColor = global::System.Drawing.Color.Transparent;
			this.btnKeybindsTooltip.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnKeybindsTooltip.ForeColor = global::System.Drawing.Color.White;
			this.btnKeybindsTooltip.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(48, 57, 71);
			this.btnKeybindsTooltip.Image = global::Jack.Properties.Resources.tooltip_30;
			this.btnKeybindsTooltip.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnKeybindsTooltip.ImageSize = new global::System.Drawing.Size(30, 17);
			this.btnKeybindsTooltip.Location = new global::System.Drawing.Point(381, 13);
			this.btnKeybindsTooltip.Name = "btnKeybindsTooltip";
			this.btnKeybindsTooltip.Size = new global::System.Drawing.Size(39, 25);
			this.btnKeybindsTooltip.TabIndex = 74;
			this.btnKeybindsTooltip.Click += new global::System.EventHandler(this.btnKeybindsTooltip_Click);
			this.table1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.table1.ColumnCount = 2;
			this.table1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.table1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.table1.Controls.Add(this.panelBox2, 1, 0);
			this.table1.Controls.Add(this.panelBox1, 0, 0);
			this.table1.Location = new global::System.Drawing.Point(24, 22);
			this.table1.Name = "table1";
			this.table1.RowCount = 1;
			this.table1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.table1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.table1.Size = new global::System.Drawing.Size(894, 313);
			this.table1.TabIndex = 71;
			this.panelBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox2.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox2.Controls.Add(this.btnKeybindsAddonSet);
			this.panelBox2.Controls.Add(this.btnKeybindsAddonApply);
			this.panelBox2.Controls.Add(this.listKeybindsDefault);
			this.panelBox2.Controls.Add(this.panelTitle2);
			this.panelBox2.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox2.Location = new global::System.Drawing.Point(459, 0);
			this.panelBox2.Margin = new global::System.Windows.Forms.Padding(12, 0, 0, 0);
			this.panelBox2.Name = "panelBox2";
			this.panelBox2.Size = new global::System.Drawing.Size(435, 313);
			this.panelBox2.TabIndex = 68;
			this.btnKeybindsAddonSet.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnKeybindsAddonSet.BorderColor = global::System.Drawing.Color.FromArgb(74, 74, 74);
			this.btnKeybindsAddonSet.BorderThickness = 1;
			this.btnKeybindsAddonSet.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnKeybindsAddonSet.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnKeybindsAddonSet.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnKeybindsAddonSet.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnKeybindsAddonSet.FillColor = global::System.Drawing.Color.FromArgb(31, 37, 46);
			this.btnKeybindsAddonSet.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnKeybindsAddonSet.ForeColor = global::System.Drawing.Color.Gray;
			this.btnKeybindsAddonSet.HoverState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnKeybindsAddonSet.HoverState.FillColor = global::System.Drawing.Color.FromArgb(35, 42, 54);
			this.btnKeybindsAddonSet.Location = new global::System.Drawing.Point(14, 269);
			this.btnKeybindsAddonSet.Name = "btnKeybindsAddonSet";
			this.btnKeybindsAddonSet.Size = new global::System.Drawing.Size(130, 30);
			this.btnKeybindsAddonSet.TabIndex = 78;
			this.btnKeybindsAddonSet.Text = "Reset to Default";
			this.btnKeybindsAddonSet.Click += new global::System.EventHandler(this.btnKeybindsAddonSet_Click);
			this.btnKeybindsAddonApply.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnKeybindsAddonApply.BorderColor = global::System.Drawing.Color.Gray;
			this.btnKeybindsAddonApply.BorderThickness = 1;
			this.btnKeybindsAddonApply.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnKeybindsAddonApply.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnKeybindsAddonApply.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnKeybindsAddonApply.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnKeybindsAddonApply.FillColor = global::System.Drawing.Color.FromArgb(0, 119, 230);
			this.btnKeybindsAddonApply.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnKeybindsAddonApply.ForeColor = global::System.Drawing.Color.White;
			this.btnKeybindsAddonApply.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnKeybindsAddonApply.Location = new global::System.Drawing.Point(237, 269);
			this.btnKeybindsAddonApply.Name = "btnKeybindsAddonApply";
			this.btnKeybindsAddonApply.Size = new global::System.Drawing.Size(183, 30);
			this.btnKeybindsAddonApply.TabIndex = 70;
			this.btnKeybindsAddonApply.Text = "Apply Default Keybinds";
			this.btnKeybindsAddonApply.Click += new global::System.EventHandler(this.btnKeybindsAddonApply_Click);
			this.panelTitle2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle2.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle2.Controls.Add(this.labelTitle2);
			this.panelTitle2.Controls.Add(this.imgTitleEdge2);
			this.panelTitle2.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle2.Name = "panelTitle2";
			this.panelTitle2.Size = new global::System.Drawing.Size(255, 38);
			this.panelTitle2.TabIndex = 68;
			this.labelTitle2.AutoSize = true;
			this.labelTitle2.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelTitle2.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.labelTitle2.Location = new global::System.Drawing.Point(0, 2);
			this.labelTitle2.Name = "labelTitle2";
			this.labelTitle2.Size = new global::System.Drawing.Size(98, 15);
			this.labelTitle2.TabIndex = 65;
			this.labelTitle2.Text = "Default";
			this.imgTitleEdge2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge2.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge2.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge2.ImageRotate = 0f;
			this.imgTitleEdge2.Location = new global::System.Drawing.Point(185, 0);
			this.imgTitleEdge2.Name = "imgTitleEdge2";
			this.imgTitleEdge2.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge2.TabIndex = 66;
			this.imgTitleEdge2.TabStop = false;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(940, 335);
			base.Controls.Add(this.table1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmMainKeybinds";
			this.Text = "frmMainKeybinds";
			base.Load += new global::System.EventHandler(this.frmMainKeybinds_Load);
			base.Shown += new global::System.EventHandler(this.frmMainKeybinds_Shown);
			base.SizeChanged += new global::System.EventHandler(this.frmMainKeybinds_SizeChanged);
			base.VisibleChanged += new global::System.EventHandler(this.frmMainKeybinds_VisibleChanged);
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.imgTitleEdge1.EndInit();
			this.panelBox1.ResumeLayout(false);
			this.table1.ResumeLayout(false);
			this.panelBox2.ResumeLayout(false);
			this.panelTitle2.ResumeLayout(false);
			this.panelTitle2.PerformLayout();
			this.imgTitleEdge2.EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400066E RID: 1646
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400066F RID: 1647
		private global::System.Windows.Forms.ListView listKeybindsCustom;

		// Token: 0x04000670 RID: 1648
		private global::System.Windows.Forms.ColumnHeader listKeybindsCustomAction;

		// Token: 0x04000671 RID: 1649
		private global::System.Windows.Forms.ColumnHeader listKeybindsCustomKey;

		// Token: 0x04000672 RID: 1650
		private global::System.Windows.Forms.ListView listKeybindsDefault;

		// Token: 0x04000673 RID: 1651
		private global::System.Windows.Forms.ColumnHeader listKeybindsName;

		// Token: 0x04000674 RID: 1652
		private global::System.Windows.Forms.ColumnHeader listKeybindsKey;

		// Token: 0x04000675 RID: 1653
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x04000676 RID: 1654
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x04000677 RID: 1655
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x04000678 RID: 1656
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000679 RID: 1657
		private global::System.Windows.Forms.TableLayoutPanel table1;

		// Token: 0x0400067A RID: 1658
		private global::Guna.UI2.WinForms.Guna2Panel panelBox2;

		// Token: 0x0400067B RID: 1659
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle2;

		// Token: 0x0400067C RID: 1660
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge2;

		// Token: 0x0400067D RID: 1661
		private global::System.Windows.Forms.Label labelTitle2;

		// Token: 0x0400067E RID: 1662
		private global::Guna.UI2.WinForms.Guna2Button btnKeybindsTooltip;

		// Token: 0x0400067F RID: 1663
		private global::Guna.UI2.WinForms.Guna2Button btnKeybindsAddonApply;

		// Token: 0x04000680 RID: 1664
		private global::System.Windows.Forms.Label lblKeybindsCustomInfo;

		// Token: 0x04000681 RID: 1665
		private global::Guna.UI2.WinForms.Guna2Button btnKeybindsAddonSet;
	}
}
