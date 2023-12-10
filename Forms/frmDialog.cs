using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x0200004D RID: 77
	public partial class frmDialog : Form
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x0067C138 File Offset: 0x0067A338
		public frmDialog(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			if (args.Count<object>() > 0)
			{
				this.DialogTitle = (string)args[0];
				this.DialogText = (string)args[1];
				this.DialogTitleColor = (string)args[2];
				this.DialogTimer = (int)args[3];
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0067C1BC File Offset: 0x0067A3BC
		private void frmDialog_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Info", true, true, true, true, false, false);
			this.LoadControls();
			this.SetCustomSize();
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0067C1E8 File Offset: 0x0067A3E8
		private void LoadControls()
		{
			this.lblTitle.Text = this.DialogTitle;
			if (this.DialogTitleColor.Length > 0)
			{
				this.lblTitle.ForeColor = Tools.GetColor(this.DialogTitleColor);
			}
			this.lblDialogText.Text = this.DialogText.Replace("\r\n", "<br>").Replace("\n", "<br>").Replace("</font>", "</font>.");
			if (this.DialogTimer > 0)
			{
				new Thread(new ThreadStart(this.CloseTimer))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0067C290 File Offset: 0x0067A490
		private void SetCustomSize()
		{
			int num = 0;
			using (Graphics graphics = base.CreateGraphics())
			{
				num = (int)Math.Ceiling((double)graphics.MeasureString(this.DialogText, this.lblDialogText.Font, this.lblDialogText.Width).Height) - this.lblDialogText.Height;
			}
			base.Height += num;
			this.MinimumSize = new Size(base.Width, base.Height);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0067C328 File Offset: 0x0067A528
		private void CloseTimer()
		{
			string name = Tools.RandomTimer("CloseTimer");
			Jack.Engine.Timer.Set(name, this.DialogTimer * 1000);
			int num = this.DialogTimer;
			while (Tools.IsFormOpen("frmDialog") && Jack.Engine.Timer.Check(name) != 0)
			{
				Tools.Control("Info (" + num.ToString() + ")", "lblHeaderTitle", "frmDialog", true, false, false, false, 0);
				Thread.Sleep(1000);
				num--;
			}
			if (Tools.IsFormOpen("frmDialog"))
			{
				Tools.CloseForm("frmDialog", Array.Empty<object>());
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00666D70 File Offset: 0x00664F70
		private void btnClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040001FF RID: 511
		private string DialogTitle = "";

		// Token: 0x04000200 RID: 512
		private string DialogText = "";

		// Token: 0x04000201 RID: 513
		private string DialogTitleColor = "";

		// Token: 0x04000202 RID: 514
		private int DialogTimer;
	}
}
