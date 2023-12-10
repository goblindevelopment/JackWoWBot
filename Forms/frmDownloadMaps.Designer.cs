namespace Jack.Forms
{
	// Token: 0x02000054 RID: 84
	public partial class frmDownloadMaps : global::System.Windows.Forms.Form
	{
		// Token: 0x060007C9 RID: 1993 RVA: 0x0067E04C File Offset: 0x0067C24C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0067E078 File Offset: 0x0067C278
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Jack.Forms.frmDownloadMaps));
			this.panelBox1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.lblDownloadSizeData = new global::System.Windows.Forms.Label();
			this.lblDownloadSize = new global::System.Windows.Forms.Label();
			this.lblDiskSpaceData = new global::System.Windows.Forms.Label();
			this.lblDiskSpace = new global::System.Windows.Forms.Label();
			this.selectClients = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.lblClient = new global::System.Windows.Forms.Label();
			this.panelTitle = new global::Guna.UI2.WinForms.Guna2Panel();
			this.imgTitleEdge = new global::Guna.UI2.WinForms.Guna2PictureBox();
			this.lblTitle = new global::System.Windows.Forms.Label();
			this.btnCancel = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBtnSave = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnDownload = new global::Guna.UI2.WinForms.Guna2Button();
			this.panelBox1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.imgTitleEdge.BeginInit();
			this.panelBtnSave.SuspendLayout();
			base.SuspendLayout();
			this.panelBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.panelBox1.BorderColor = global::System.Drawing.Color.FromArgb(50, 61, 79);
			this.panelBox1.Controls.Add(this.lblDownloadSizeData);
			this.panelBox1.Controls.Add(this.lblDownloadSize);
			this.panelBox1.Controls.Add(this.lblDiskSpaceData);
			this.panelBox1.Controls.Add(this.lblDiskSpace);
			this.panelBox1.Controls.Add(this.selectClients);
			this.panelBox1.Controls.Add(this.lblClient);
			this.panelBox1.Controls.Add(this.panelTitle);
			this.panelBox1.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.panelBox1.Location = new global::System.Drawing.Point(21, 21);
			this.panelBox1.Name = "panelBox1";
			this.panelBox1.Size = new global::System.Drawing.Size(468, 221);
			this.panelBox1.TabIndex = 79;
			this.lblDownloadSizeData.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblDownloadSizeData.ForeColor = global::System.Drawing.Color.Gray;
			this.lblDownloadSizeData.Location = new global::System.Drawing.Point(140, 178);
			this.lblDownloadSizeData.Name = "lblDownloadSizeData";
			this.lblDownloadSizeData.Size = new global::System.Drawing.Size(67, 13);
			this.lblDownloadSizeData.TabIndex = 77;
			this.lblDownloadSizeData.Text = "~0.4 GB";
			this.lblDownloadSizeData.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblDownloadSize.AutoSize = true;
			this.lblDownloadSize.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblDownloadSize.ForeColor = global::System.Drawing.Color.Gray;
			this.lblDownloadSize.Location = new global::System.Drawing.Point(28, 178);
			this.lblDownloadSize.Name = "lblDownloadSize";
			this.lblDownloadSize.Size = new global::System.Drawing.Size(87, 13);
			this.lblDownloadSize.TabIndex = 76;
			this.lblDownloadSize.Text = "Download Size:";
			this.lblDownloadSize.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDiskSpaceData.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblDiskSpaceData.ForeColor = global::System.Drawing.Color.Gray;
			this.lblDiskSpaceData.Location = new global::System.Drawing.Point(140, 160);
			this.lblDiskSpaceData.Name = "lblDiskSpaceData";
			this.lblDiskSpaceData.Size = new global::System.Drawing.Size(67, 13);
			this.lblDiskSpaceData.TabIndex = 75;
			this.lblDiskSpaceData.Text = "~2.5 GB";
			this.lblDiskSpaceData.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.lblDiskSpace.AutoSize = true;
			this.lblDiskSpace.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.lblDiskSpace.ForeColor = global::System.Drawing.Color.Gray;
			this.lblDiskSpace.Location = new global::System.Drawing.Point(28, 160);
			this.lblDiskSpace.Name = "lblDiskSpace";
			this.lblDiskSpace.Size = new global::System.Drawing.Size(113, 13);
			this.lblDiskSpace.TabIndex = 74;
			this.lblDiskSpace.Text = "Required disk space:";
			this.lblDiskSpace.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.selectClients.BackColor = global::System.Drawing.Color.Transparent;
			this.selectClients.BorderColor = global::System.Drawing.Color.Gray;
			this.selectClients.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(70, 75, 82);
			this.selectClients.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.selectClients.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.selectClients.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.selectClients.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.selectClients.FocusedColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectClients.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.selectClients.Font = new global::System.Drawing.Font("Segoe UI", 21f);
			this.selectClients.ForeColor = global::System.Drawing.Color.White;
			this.selectClients.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.selectClients.IntegralHeight = false;
			this.selectClients.ItemHeight = 43;
			this.selectClients.Items.AddRange(new object[]
			{
				"Classic",
				"Retail",
				"Classic and Retail"
			});
			this.selectClients.Location = new global::System.Drawing.Point(31, 96);
			this.selectClients.Name = "selectClients";
			this.selectClients.Size = new global::System.Drawing.Size(407, 49);
			this.selectClients.StartIndex = 0;
			this.selectClients.TabIndex = 73;
			this.selectClients.SelectedIndexChanged += new global::System.EventHandler(this.selectClients_SelectedIndexChanged);
			this.lblClient.AutoSize = true;
			this.lblClient.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.lblClient.ForeColor = global::System.Drawing.Color.White;
			this.lblClient.Location = new global::System.Drawing.Point(27, 63);
			this.lblClient.Name = "lblClient";
			this.lblClient.Size = new global::System.Drawing.Size(271, 19);
			this.lblClient.TabIndex = 72;
			this.lblClient.Text = "Which client do you want to use Jack with?";
			this.lblClient.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.panelTitle.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelTitle.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			this.panelTitle.Controls.Add(this.imgTitleEdge);
			this.panelTitle.Controls.Add(this.lblTitle);
			this.panelTitle.Location = new global::System.Drawing.Point(0, 0);
			this.panelTitle.Margin = new global::System.Windows.Forms.Padding(0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new global::System.Drawing.Size(246, 38);
			this.panelTitle.TabIndex = 71;
			this.imgTitleEdge.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.imgTitleEdge.FillColor = global::System.Drawing.Color.Transparent;
			this.imgTitleEdge.Image = global::Jack.Properties.Resources.title_edge;
			this.imgTitleEdge.ImageRotate = 0f;
			this.imgTitleEdge.Location = new global::System.Drawing.Point(176, 0);
			this.imgTitleEdge.Name = "imgTitleEdge";
			this.imgTitleEdge.Size = new global::System.Drawing.Size(70, 38);
			this.imgTitleEdge.TabIndex = 66;
			this.imgTitleEdge.TabStop = false;
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new global::System.Drawing.Font("Equalize", 8f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblTitle.ForeColor = global::System.Drawing.Color.FromArgb(153, 157, 169);
			this.lblTitle.Location = new global::System.Drawing.Point(0, 2);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new global::System.Drawing.Size(112, 15);
			this.lblTitle.TabIndex = 65;
			this.lblTitle.Text = "Download";
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
			this.btnCancel.Location = new global::System.Drawing.Point(21, 256);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(120, 30);
			this.btnCancel.TabIndex = 81;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.panelBtnSave.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panelBtnSave.BackgroundImage = global::Jack.Properties.Resources.btn_save_bg;
			this.panelBtnSave.Controls.Add(this.btnDownload);
			this.panelBtnSave.Location = new global::System.Drawing.Point(209, 242);
			this.panelBtnSave.Name = "panelBtnSave";
			this.panelBtnSave.Size = new global::System.Drawing.Size(280, 57);
			this.panelBtnSave.TabIndex = 80;
			this.btnDownload.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnDownload.BackColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.DisabledState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.DisabledState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.DisabledState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.DisabledState.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.DisabledState.Image = global::Jack.Properties.Resources.btn_download_disabled;
			this.btnDownload.FillColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.FocusedColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnDownload.ForeColor = global::System.Drawing.Color.White;
			this.btnDownload.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.HoverState.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnDownload.HoverState.Image = global::Jack.Properties.Resources.btn_download_hover;
			this.btnDownload.Image = global::Jack.Properties.Resources.btn_download;
			this.btnDownload.ImageSize = new global::System.Drawing.Size(235, 44);
			this.btnDownload.Location = new global::System.Drawing.Point(30, 0);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.PressedDepth = 0;
			this.btnDownload.Size = new global::System.Drawing.Size(235, 44);
			this.btnDownload.TabIndex = 0;
			this.btnDownload.Click += new global::System.EventHandler(this.btnDownload_Click);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(509, 321);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.panelBtnSave);
			base.Controls.Add(this.panelBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmDownloadMaps";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmDownloadMaps";
			base.Load += new global::System.EventHandler(this.frmDownloadMaps_Load);
			this.panelBox1.ResumeLayout(false);
			this.panelBox1.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.imgTitleEdge.EndInit();
			this.panelBtnSave.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000233 RID: 563
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000234 RID: 564
		private global::Guna.UI2.WinForms.Guna2Panel panelBtnSave;

		// Token: 0x04000235 RID: 565
		private global::Guna.UI2.WinForms.Guna2Button btnDownload;

		// Token: 0x04000236 RID: 566
		private global::Guna.UI2.WinForms.Guna2Panel panelBox1;

		// Token: 0x04000237 RID: 567
		private global::Guna.UI2.WinForms.Guna2Panel panelTitle;

		// Token: 0x04000238 RID: 568
		private global::Guna.UI2.WinForms.Guna2PictureBox imgTitleEdge;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.Label lblTitle;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.Label lblClient;

		// Token: 0x0400023B RID: 571
		private global::System.Windows.Forms.Label lblDiskSpaceData;

		// Token: 0x0400023C RID: 572
		private global::System.Windows.Forms.Label lblDiskSpace;

		// Token: 0x0400023D RID: 573
		private global::Guna.UI2.WinForms.Guna2ComboBox selectClients;

		// Token: 0x0400023E RID: 574
		private global::Guna.UI2.WinForms.Guna2Button btnCancel;

		// Token: 0x0400023F RID: 575
		private global::System.Windows.Forms.Label lblDownloadSizeData;

		// Token: 0x04000240 RID: 576
		private global::System.Windows.Forms.Label lblDownloadSize;
	}
}
