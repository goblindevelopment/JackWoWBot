using System;
using System.Runtime.InteropServices;

namespace Jack.Forms
{
	// Token: 0x0200008A RID: 138
	internal class APIHelp
	{
		// Token: 0x06000E46 RID: 3654
		[DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool UpdateLayeredWindow(IntPtr hwnd, IntPtr hdcDst, ref APIHelp.Point pptDst, ref APIHelp.Size psize, IntPtr hdcSrc, ref APIHelp.Point pptSrc, uint crKey, [In] ref APIHelp.BLENDFUNCTION pblend, uint dwFlags);

		// Token: 0x06000E47 RID: 3655
		[DllImport("gdi32.dll", SetLastError = true)]
		public static extern IntPtr CreateCompatibleDC([In] IntPtr hdc);

		// Token: 0x06000E48 RID: 3656
		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject([In] IntPtr hdc, [In] IntPtr hgdiobj);

		// Token: 0x06000E49 RID: 3657
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hWnd);

		// Token: 0x06000E4A RID: 3658
		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC([In] IntPtr hdc);

		// Token: 0x06000E4B RID: 3659
		[DllImport("gdi32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteObject([In] IntPtr hObject);

		// Token: 0x040005EE RID: 1518
		public const int WS_EX_LAYERED = 524288;

		// Token: 0x040005EF RID: 1519
		public const int ULW_ALPHA = 2;

		// Token: 0x040005F0 RID: 1520
		public const byte AC_SRC_OVER = 0;

		// Token: 0x040005F1 RID: 1521
		public const byte AC_SRC_ALPHA = 1;

		// Token: 0x0200008B RID: 139
		public struct Point
		{
			// Token: 0x040005F2 RID: 1522
			public int x;

			// Token: 0x040005F3 RID: 1523
			public int y;
		}

		// Token: 0x0200008C RID: 140
		public struct Size
		{
			// Token: 0x040005F4 RID: 1524
			public int cx;

			// Token: 0x040005F5 RID: 1525
			public int cy;
		}

		// Token: 0x0200008D RID: 141
		public struct ARGB
		{
			// Token: 0x040005F6 RID: 1526
			public byte Blue;

			// Token: 0x040005F7 RID: 1527
			public byte Green;

			// Token: 0x040005F8 RID: 1528
			public byte Red;

			// Token: 0x040005F9 RID: 1529
			public byte Alpha;
		}

		// Token: 0x0200008E RID: 142
		public struct BLENDFUNCTION
		{
			// Token: 0x040005FA RID: 1530
			public byte BlendOp;

			// Token: 0x040005FB RID: 1531
			public byte BlendFlags;

			// Token: 0x040005FC RID: 1532
			public byte SourceConstantAlpha;

			// Token: 0x040005FD RID: 1533
			public byte AlphaFormat;
		}
	}
}
