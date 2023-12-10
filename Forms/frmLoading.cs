using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;

namespace Jack.Forms
{
	// Token: 0x02000057 RID: 87
	public partial class frmLoading : Form
	{
		// Token: 0x06000858 RID: 2136 RVA: 0x00682564 File Offset: 0x00680764
		public frmLoading()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}
	}
}
