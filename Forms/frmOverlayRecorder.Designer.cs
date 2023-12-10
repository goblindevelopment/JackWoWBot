namespace Jack.Forms
{
	// Token: 0x0200005A RID: 90
	public partial class frmOverlayRecorder : global::System.Windows.Forms.Form
	{
		// Token: 0x0600089A RID: 2202 RVA: 0x0068502C File Offset: 0x0068322C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00685058 File Offset: 0x00683258
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.btnPlay = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnPause = new global::Guna.UI2.WinForms.Guna2Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 35f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 30f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 35f));
			this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 2, 0);
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(500, 40);
			this.tableLayoutPanel1.TabIndex = 66;
			this.guna2Panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.guna2Panel1.Controls.Add(this.btnPause);
			this.guna2Panel1.Controls.Add(this.btnPlay);
			this.guna2Panel1.Location = new global::System.Drawing.Point(325, 0);
			this.guna2Panel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(175, 40);
			this.guna2Panel1.TabIndex = 10;
			this.btnPlay.BorderColor = global::System.Drawing.Color.Gray;
			this.btnPlay.BorderThickness = 1;
			this.btnPlay.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnPlay.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnPlay.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnPlay.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnPlay.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnPlay.Enabled = false;
			this.btnPlay.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnPlay.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPlay.ForeColor = global::System.Drawing.Color.White;
			this.btnPlay.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnPlay.Image = global::Jack.Properties.Resources.play_32;
			this.btnPlay.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPlay.ImageSize = new global::System.Drawing.Size(28, 28);
			this.btnPlay.Location = new global::System.Drawing.Point(135, 0);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new global::System.Drawing.Size(40, 40);
			this.btnPlay.TabIndex = 74;
			this.btnPause.BorderColor = global::System.Drawing.Color.Gray;
			this.btnPause.BorderThickness = 1;
			this.btnPause.CustomBorderThickness = new global::System.Windows.Forms.Padding(1, 1, 0, 1);
			this.btnPause.DisabledState.BorderColor = global::System.Drawing.Color.DimGray;
			this.btnPause.DisabledState.CustomBorderColor = global::System.Drawing.Color.DimGray;
			this.btnPause.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(27, 33, 43);
			this.btnPause.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnPause.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.btnPause.FillColor = global::System.Drawing.Color.FromArgb(23, 39, 52);
			this.btnPause.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnPause.ForeColor = global::System.Drawing.Color.White;
			this.btnPause.HoverState.BorderColor = global::System.Drawing.Color.White;
			this.btnPause.Image = global::Jack.Properties.Resources.play_32;
			this.btnPause.ImageOffset = new global::System.Drawing.Point(1, 0);
			this.btnPause.ImageSize = new global::System.Drawing.Size(28, 28);
			this.btnPause.Location = new global::System.Drawing.Point(95, 0);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new global::System.Drawing.Size(40, 40);
			this.btnPause.TabIndex = 75;
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.FromArgb(14, 17, 22);
			base.ClientSize = new global::System.Drawing.Size(500, 177);
			base.Controls.Add(this.tableLayoutPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmOverlayRecorder";
			base.Opacity = 0.9;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "frmOverlayRecorder";
			base.Load += new global::System.EventHandler(this.frmOverlayRecorder_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400029F RID: 671
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040002A0 RID: 672
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x040002A1 RID: 673
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x040002A2 RID: 674
		private global::Guna.UI2.WinForms.Guna2Button btnPause;

		// Token: 0x040002A3 RID: 675
		private global::Guna.UI2.WinForms.Guna2Button btnPlay;
	}
}
