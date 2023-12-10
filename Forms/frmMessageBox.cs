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
	// Token: 0x02000058 RID: 88
	public partial class frmMessageBox : Form
	{
		// Token: 0x06000860 RID: 2144 RVA: 0x006826F4 File Offset: 0x006808F4
		public frmMessageBox()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00682714 File Offset: 0x00680914
		private void frmMessageBox_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, frmMessageBox.Dialog["Title"], true, true, true, true, false, false);
			this.LoadControls();
			this.SetCustomSize(frmMessageBox.Dialog["Text"]);
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00682758 File Offset: 0x00680958
		private void LoadControls()
		{
			frmMessageBox.Button1Pressed = false;
			frmMessageBox.Button2Pressed = false;
			this.lblDialogText.Text = frmMessageBox.Dialog["Text"];
			this.btn1.Text = frmMessageBox.Dialog["Button1"];
			this.btn2.Text = frmMessageBox.Dialog["Button2"];
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x006827C0 File Offset: 0x006809C0
		private void SetCustomSize(string DialogText)
		{
			int num = 0;
			using (Graphics graphics = base.CreateGraphics())
			{
				num = (int)Math.Ceiling((double)graphics.MeasureString(DialogText, this.lblDialogText.Font, this.lblDialogText.Width).Height) - this.lblDialogText.Height;
			}
			base.Height = base.Height + num + 5;
			this.MinimumSize = new Size(base.Width, base.Height);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00682854 File Offset: 0x00680A54
		private void btn1_Click(object sender, EventArgs e)
		{
			frmMessageBox.Button1Pressed = true;
			base.Close();
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00682870 File Offset: 0x00680A70
		private void btn2_Click(object sender, EventArgs e)
		{
			frmMessageBox.Button2Pressed = true;
			base.Close();
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00682FF8 File Offset: 0x006811F8
		// Note: this type is marked as 'beforefieldinit'.
		static frmMessageBox()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["Title"] = "";
			dictionary["Text"] = "";
			dictionary["Button1"] = "";
			dictionary["Button2"] = "";
			frmMessageBox.Dialog = dictionary;
		}

		// Token: 0x0400026C RID: 620
		public static bool Button1Pressed = false;

		// Token: 0x0400026D RID: 621
		public static bool Button2Pressed = false;

		// Token: 0x0400026E RID: 622
		public static Dictionary<string, string> Dialog;
	}
}
