using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000089 RID: 137
	public partial class frmSplashScreen : Form
	{
		// Token: 0x06000E2E RID: 3630 RVA: 0x006C6D58 File Offset: 0x006C4F58
		public frmSplashScreen()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			CustomUI.Set(this, "", false, false, true, false, false, false);
			this.SplashHandle = this.method_0();
			new Thread(new ThreadStart(this.SetTopMost))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x006C6DC4 File Offset: 0x006C4FC4
		private void SetTopMost()
		{
			while (this.IsOpen)
			{
				Window.Activate(this.SplashHandle);
				Thread.Sleep(100);
			}
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x006C6DF0 File Offset: 0x006C4FF0
		private void frmSplashScreen_FormClosed(object sender, FormClosedEventArgs e)
		{
			APIHelp.SelectObject(this.memDc, this.hOldBmp);
			APIHelp.DeleteObject(this.hBmp);
			APIHelp.DeleteDC(this.memDc);
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x006C6E28 File Offset: 0x006C5028
		private void frmSplashScreen_Load(object sender, EventArgs e)
		{
			APIHelp.BLENDFUNCTION blendfunction;
			blendfunction.BlendOp = 0;
			blendfunction.BlendFlags = 0;
			blendfunction.SourceConstantAlpha = byte.MaxValue;
			blendfunction.AlphaFormat = 1;
			IntPtr dc = APIHelp.GetDC(IntPtr.Zero);
			Bitmap bitmap2;
			Bitmap bitmap = bitmap2 = new Bitmap(Resources.splash_3);
			try
			{
				this.memDc = APIHelp.CreateCompatibleDC(dc);
				this.hBmp = bitmap.GetHbitmap(Color.FromArgb(0));
				this.hOldBmp = APIHelp.SelectObject(this.memDc, this.hBmp);
			}
			finally
			{
				if (bitmap2 != null)
				{
					((IDisposable)bitmap2).Dispose();
				}
			}
			APIHelp.DeleteDC(dc);
			APIHelp.Point point;
			point.x = base.Location.X;
			point.y = base.Location.Y;
			APIHelp.Point point2;
			point2.x = 0;
			point2.y = 0;
			APIHelp.Size size;
			size.cx = base.Width;
			size.cy = base.Height;
			APIHelp.UpdateLayeredWindow(base.Handle, IntPtr.Zero, ref point, ref size, this.memDc, ref point2, 0U, ref blendfunction, 2U);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x006C6F44 File Offset: 0x006C5144
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 524288;
				return createParams;
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x0066A478 File Offset: 0x00668678
		IntPtr method_0()
		{
			return base.Handle;
		}

		// Token: 0x040005E8 RID: 1512
		private IntPtr SplashHandle = IntPtr.Zero;

		// Token: 0x040005E9 RID: 1513
		private bool IsOpen = true;

		// Token: 0x040005EA RID: 1514
		private IntPtr memDc;

		// Token: 0x040005EB RID: 1515
		private IntPtr hBmp;

		// Token: 0x040005EC RID: 1516
		private IntPtr hOldBmp;
	}
}
