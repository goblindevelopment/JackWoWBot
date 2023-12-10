using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x0200005A RID: 90
	public partial class frmOverlayRecorder : Form
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x00684E80 File Offset: 0x00683080
		public frmOverlayRecorder()
		{
			this.InitializeComponent();
			this.ThisFormName = base.Name;
			this.ThisFormHandle = this.method_0();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00684ED0 File Offset: 0x006830D0
		private void frmOverlayRecorder_Load(object sender, EventArgs e)
		{
			if (!_globals.GameOpen)
			{
				Tools.CloseForm(this.ThisFormName, Array.Empty<object>());
			}
			this.AttachToWindow();
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00684EFC File Offset: 0x006830FC
		private void AttachToWindow()
		{
			frmOverlayRecorder.<>c__DisplayClass7_0 CS$<>8__locals1 = new frmOverlayRecorder.<>c__DisplayClass7_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.OverlaySize = 600;
			Window.SetParentWindow(this.ThisFormHandle);
			CS$<>8__locals1.CurrentClientIsFullScreen = Window.IsFullScreen(null);
			int[] dimensions = Window.Dimensions;
			CS$<>8__locals1.CurrentClientPosX = dimensions[0] + 1;
			CS$<>8__locals1.CurrentClientPosY = dimensions[1];
			CS$<>8__locals1.CurrentClientWidth = dimensions[2];
			int latestClientHeight = dimensions[3];
			base.Size = new Size(CS$<>8__locals1.CurrentClientWidth - CS$<>8__locals1.OverlaySize, 40);
			this.ThisFormSize.Width = CS$<>8__locals1.CurrentClientWidth - CS$<>8__locals1.OverlaySize;
			CS$<>8__locals1.CurrentClientPosX += (CS$<>8__locals1.CurrentClientWidth - this.ThisFormSize.Width) / 2;
			base.Location = new Point(CS$<>8__locals1.CurrentClientPosX, CS$<>8__locals1.CurrentClientPosY);
			CS$<>8__locals1.LatestClientIsFullScreen = CS$<>8__locals1.CurrentClientIsFullScreen;
			CS$<>8__locals1.LatestClientWindowPosition = dimensions;
			CS$<>8__locals1.LatestClientPosX = CS$<>8__locals1.CurrentClientPosX;
			CS$<>8__locals1.LatestClientPosY = CS$<>8__locals1.CurrentClientPosY;
			CS$<>8__locals1.LatestClientWidth = CS$<>8__locals1.CurrentClientWidth;
			CS$<>8__locals1.LatestClientHeight = latestClientHeight;
			CS$<>8__locals1.IsHidden = false;
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0066A478 File Offset: 0x00668678
		IntPtr method_0()
		{
			return base.Handle;
		}

		// Token: 0x0400029A RID: 666
		private string ThisFormName = "";

		// Token: 0x0400029B RID: 667
		private Size ThisFormSize;

		// Token: 0x0400029C RID: 668
		private IntPtr ThisFormHandle = IntPtr.Zero;

		// Token: 0x0400029D RID: 669
		public static bool Runs;

		// Token: 0x0400029E RID: 670
		public static bool Stop;
	}
}
