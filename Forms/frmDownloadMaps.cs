using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000054 RID: 84
	public partial class frmDownloadMaps : Form
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x0067DEC8 File Offset: 0x0067C0C8
		public frmDownloadMaps()
		{
			Dictionary<string, string[]> dictionary = new Dictionary<string, string[]>();
			dictionary["Classic"] = new string[]
			{
				"~2.5 GB",
				"~0.4 GB"
			};
			dictionary["Retail"] = new string[]
			{
				"~17.0 GB",
				"~2.7 GB"
			};
			dictionary["Classic and Retail"] = new string[]
			{
				"~19.5 GB",
				"~3.1 GB"
			};
			this.ClientAndDiskSpace = dictionary;
			base..ctor();
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0067DF58 File Offset: 0x0067C158
		private void frmDownloadMaps_Load(object sender, EventArgs e)
		{
			this.selectClients.Items.Clear();
			foreach (KeyValuePair<string, string[]> keyValuePair in this.ClientAndDiskSpace)
			{
				this.selectClients.Items.Add(keyValuePair.Key);
			}
			this.selectClients.SelectedIndex = 0;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0067DFDC File Offset: 0x0067C1DC
		private void selectClients_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = this.selectClients.SelectedItem.ToString();
			string text2 = this.ClientAndDiskSpace[text][0];
			string text3 = this.ClientAndDiskSpace[text][1];
			this.lblDiskSpaceData.Text = text2;
			this.lblDownloadSizeData.Text = text3;
			frmDownloadMaps.WhichClients = text;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00666D70 File Offset: 0x00664F70
		private void btnDownload_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x0067E038 File Offset: 0x0067C238
		private void btnCancel_Click(object sender, EventArgs e)
		{
			Tools.CloseJack(true);
		}

		// Token: 0x04000231 RID: 561
		public static string WhichClients = "Classic";

		// Token: 0x04000232 RID: 562
		private Dictionary<string, string[]> ClientAndDiskSpace;
	}
}
