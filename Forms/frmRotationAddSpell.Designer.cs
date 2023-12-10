namespace Jack.Forms
{
	// Token: 0x020000B6 RID: 182
	public partial class frmRotationAddSpell : global::System.Windows.Forms.Form
	{
		// Token: 0x0600130F RID: 4879 RVA: 0x006F6EE8 File Offset: 0x006F50E8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x006F6F14 File Offset: 0x006F5114
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmRotationAddSpell));
			this.selectType = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.panelTitle1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge1 = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle1 = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnSave = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBox1.SuspendLayout();
			this.panelTitle1.SuspendLayout();
			this.imgTitleEdge1.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.selectType.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.selectType.BackColor = global::System.Drawing.Color.Transparent;
			this.selectType.BorderColor = global::System.Drawing.Color.Gray;
			this.selectType.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectType.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectType.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectType.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectType.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectType.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectType.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectType.Font = new global::System.Drawing.Font("Segoe UI", 21f);
			this.selectType.ForeColor = global::System.Drawing.Color.White;
			this.selectType.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectType.IntegralHeight = false;
			this.selectType.ItemHeight = 43;
			this.selectType.Items.AddRange(new object[]
			{
				"Combat",
				"Heal",
				"Food/Drink",
				"Buff/Aura",
				"Dispel",
				"Conjuring"
			});
			this.selectType.Location = new global::System.Drawing.Point(22, 60);
			this.selectType.Name = "selectType";
			this.selectType.Size = new global::System.Drawing.Size(394, 49);
			this.selectType.TabIndex = 72;
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.selectType);
			this.panelBox1.Controls.Add(this.panelTitle1);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(24, 74);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(438, 132);
			this.panelBox1.TabIndex = 74;
			this.panelTitle1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle1.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle1.Controls.Add(this.imgTitleEdge1);
			this.panelTitle1.Controls.Add(this.lblTitle1);
			this.panelTitle1.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle1.Name = "panelTitle1";
			this.panelTitle1.Size = new global::System.Drawing.Size(316, 38);
			this.panelTitle1.TabIndex = 66;
			this.imgTitleEdge1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge1.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge1.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge1.ImageRotate = 0f;
			this.imgTitleEdge1.Location = new global::System.Drawing.Point(246, 0);
			this.imgTitleEdge1.Name = "imgTitleEdge1";
			this.imgTitleEdge1.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge1.TabIndex = 66;
			this.imgTitleEdge1.TabStop = false;
			this.lblTitle1.AutoSize = true;
			this.lblTitle1.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle1.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle1.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle1.Name = "lblTitle1";
			this.lblTitle1.Size = new global::System.Drawing.Size(118, 15);
			this.lblTitle1.TabIndex = 65;
			this.lblTitle1.Text = "Add Spell";
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnCancel.BorderColor = global::System.Drawing.Color.FromArgb(74, 74, 74);
			this.btnCancel.BorderThickness = 1;
			this.btnCancel.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnCancel.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnCancel.FillColor = global::System.Drawing.Color.FromArgb(31, 37, 46);
			this.btnCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnCancel.ForeColor = global::System.Drawing.Color.Gray;
			this.btnCancel.HoverState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnCancel.HoverState.FillColor = global::System.Drawing.Color.FromArgb(35, 42, 54);
			this.btnCancel.Location = new global::System.Drawing.Point(24, 220);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(120, 30);
			this.btnCancel.TabIndex = 79;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnSave);
			this.panelBtnSave.Location = new global::System.Drawing.Point(182, 206);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 78;
			this.btnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnSave.BackColor = global::System.Drawing.Color.Transparent;
			this.btnSave.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnSave.DisabledState.Image = global::Jack.Properties.Resources.btn_add_disabled;
			this.btnSave.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnSave.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnSave.ForeColor = global::System.Drawing.Color.White;
			this.btnSave.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnSave.HoverState.Image = global::Jack.Properties.Resources.btn_add_hover;
			this.btnSave.Image = global::Jack.Properties.Resources.btn_add;
			this.btnSave.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnSave.Location = new global::System.Drawing.Point(30, 0);
			this.btnSave.Name = "btnSave";
			this.btnSave.PressedDepth = 0;
			this.btnSave.Size = new global::System.Drawing.Size(235, 44);
			this.btnSave.TabIndex = 0;
			this.btnSave.Click += new global::System.EventHandler(this.btnAdd_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(486, 290);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmRotationAddSpell";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmRotationAddSpell";
			base.Load += new global::System.EventHandler(this.frmRotationAddSpell_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelTitle1.ResumeLayout(false);
			this.panelTitle1.PerformLayout();
			this.imgTitleEdge1.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000900 RID: 2304
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000901 RID: 2305
		private global::Guna.UI2.WinForms.Guna2ComboBox selectType;

		// Token: 0x04000902 RID: 2306
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000903 RID: 2307
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle1;

		// Token: 0x04000904 RID: 2308
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge1;

		// Token: 0x04000905 RID: 2309
		private global::System.Windows.Forms.Label lblTitle1;

		// Token: 0x04000906 RID: 2310
		private global::Guna.UI2.WinForms.Guna2Button btnCancel;

		// Token: 0x04000907 RID: 2311
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x04000908 RID: 2312
		private global::Guna.UI2.WinForms.Guna2Button btnSave;
	}
}
