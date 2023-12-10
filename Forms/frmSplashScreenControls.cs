using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;

namespace Jack.Forms
{
	// Token: 0x02000064 RID: 100
	public partial class frmSplashScreenControls : Form
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x00687870 File Offset: 0x00685A70
		public frmSplashScreenControls()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			CustomUI.Set(this, "", false, false, true, false, false, false);
			new frmSplashScreen
			{
				Owner = this
			}.Show();
		}
	}
}
