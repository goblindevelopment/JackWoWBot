using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Jack.Core;

namespace Jack.Engine
{
	// Token: 0x020000E7 RID: 231
	internal class Pixel
	{
		// Token: 0x0600162E RID: 5678 RVA: 0x00714784 File Offset: 0x00712984
		public static bool IsVisible(string Dot)
		{
			Pixel.Dots argb;
			if (_globals.Ready && Enum.TryParse<Pixel.Dots>(Dot, out argb))
			{
				int[] dimensions = Window.Dimensions;
				if (dimensions.Count<int>() > 0)
				{
					bool flag = true;
					int num = dimensions[0];
					int num2 = dimensions[1];
					if (Pixel.WindowX == num)
					{
						if (Pixel.WindowY == num2)
						{
							goto IL_44;
						}
					}
					flag = Pixel.SetRectangle();
					IL_44:
					if (flag)
					{
						Color pixelColor = Color.FromArgb((int)argb);
						if (Pixel.Search(new Rectangle(Pixel.RectangleX, Pixel.RectangleY, Pixel.RectangleWidth, Pixel.RectangleHeight), pixelColor, 1).Count<Point>() > 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0071480C File Offset: 0x00712A0C
		public static bool SetRectangle()
		{
			int[] dimensions = Window.Dimensions;
			if (dimensions.Count<int>() > 0)
			{
				Color pixelColor = Color.FromArgb(16711757);
				int num = dimensions[0];
				int num2 = dimensions[1];
				List<Point> list = Pixel.Search(new Rectangle(num, num2, 100, 100), pixelColor, 1);
				int num3 = list.Count<Point>();
				if (num3 > 0)
				{
					int index = 0;
					int index2 = 1;
					if (num3 == 8)
					{
						index = 1;
						index2 = 3;
					}
					Pixel.WindowX = num;
					Pixel.WindowY = num2;
					Pixel.RectangleX = list[index].X;
					Pixel.RectangleY = list[index].Y;
					Pixel.RectangleWidth = list[index2].X - list[index].X;
					Pixel.RectangleHeight = 2;
					Tools.Console("Addon adjusted.", "", "richConsole", "frmMain", true);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x007148FC File Offset: 0x00712AFC
		private unsafe static List<Point> Search(Rectangle Rect, Color PixelColor, int ShadeVariation)
		{
			List<Point> list = new List<Point>();
			Bitmap bitmap = new Bitmap(Rect.Width, Rect.Height, PixelFormat.Format24bppRgb);
			int num = 1;
			if (1 >= Screen.AllScreens.Length)
			{
				num = 0;
			}
			int left = Screen.AllScreens[num].Bounds.Left;
			int top = Screen.AllScreens[num].Bounds.Top;
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CopyFromScreen(Rect.X + left, Rect.Y + top, 0, 0, Rect.Size, CopyPixelOperation.SourceCopy);
			}
			BitmapData bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			int[] array = new int[]
			{
				(int)PixelColor.B,
				(int)PixelColor.G,
				(int)PixelColor.R
			};
			for (int i = 0; i < bitmapData.Height; i++)
			{
				byte* ptr = (byte*)((void*)bitmapData.Scan0) + i * bitmapData.Stride;
				for (int j = 0; j < bitmapData.Width; j++)
				{
					if (((int)ptr[j * 3] >= array[0] - ShadeVariation & (int)ptr[j * 3] <= array[0] + ShadeVariation) && ((int)ptr[j * 3 + 1] >= array[1] - ShadeVariation & (int)ptr[j * 3 + 1] <= array[1] + ShadeVariation) && ((int)ptr[j * 3 + 2] >= array[2] - ShadeVariation & (int)ptr[j * 3 + 2] <= array[2] + ShadeVariation))
					{
						list.Add(new Point(j + Rect.X, i + Rect.Y));
					}
				}
			}
			bitmap.Dispose();
			return list;
		}

		// Token: 0x06001631 RID: 5681
		[DllImport("user32.dll")]
		private static extern bool SetCursorPos(int X, int Y);

		// Token: 0x04000A65 RID: 2661
		private static int WindowX;

		// Token: 0x04000A66 RID: 2662
		private static int WindowY;

		// Token: 0x04000A67 RID: 2663
		private static int RectangleX;

		// Token: 0x04000A68 RID: 2664
		private static int RectangleY;

		// Token: 0x04000A69 RID: 2665
		private static int RectangleWidth;

		// Token: 0x04000A6A RID: 2666
		private static int RectangleHeight;

		// Token: 0x020000E8 RID: 232
		private enum Dots
		{
			// Token: 0x04000A6C RID: 2668
			Orientation = 16711757,
			// Token: 0x04000A6D RID: 2669
			FullBags = 1710618,
			// Token: 0x04000A6E RID: 2670
			NeedRepair = 1710643,
			// Token: 0x04000A6F RID: 2671
			Hearthstone = 1710669,
			// Token: 0x04000A70 RID: 2672
			NPC = 1710694
		}
	}
}
