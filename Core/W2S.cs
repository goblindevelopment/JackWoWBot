using System;
using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices;
using Jack.Engine;

namespace Jack.Core
{
	// Token: 0x02000104 RID: 260
	public class W2S
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x0071CA80 File Offset: 0x0071AC80
		public static Vector2 Convert(Vector3 pos)
		{
			float positionX = ObjectManager.Camera.PositionX;
			float positionY = ObjectManager.Camera.PositionY;
			float positionZ = ObjectManager.Camera.PositionZ;
			float foV = ObjectManager.Camera.FoV;
			Matrix4x4 matrix4x;
			Matrix4x4.Invert(W2S.Matrix4x4, out matrix4x);
			Vector3 vector = new Vector3(pos.X - positionX, pos.Y - positionY, pos.Z - positionZ);
			if (vector.X * W2S.Matrix4x4.M11 + vector.Y * W2S.Matrix4x4.M12 + vector.Z * W2S.Matrix4x4.M13 < 0f)
			{
				return new Vector2(0f, 0f);
			}
			Vector3 vector2 = new Vector3(matrix4x.M11 * vector.X + matrix4x.M21 * vector.Y + matrix4x.M31 * vector.Z, matrix4x.M12 * vector.X + matrix4x.M22 * vector.Y + matrix4x.M32 * vector.Z, matrix4x.M13 * vector.X + matrix4x.M23 * vector.Y + matrix4x.M33 * vector.Z);
			W2S.Rect rect = default(W2S.Rect);
			W2S.GetClientRect(_globals.processHandle, ref rect);
			float num = 0.017453292f;
			Vector3 vector3 = new Vector3(-vector2.Y, -vector2.Z, vector2.X);
			Vector2 vector4 = new Vector2((float)(rect.Right - rect.Left) / 2f, (float)(rect.Bottom - rect.Top) / 2f);
			Vector2 vector5 = new Vector2(vector4.X / (float)Math.Tan((double)(foV * 55f / 2f * num)), vector4.Y / (float)Math.Tan((double)(foV * 35f / 2f * num)));
			Vector2 vector6 = new Vector2(vector4.X + vector3.X * vector5.X / vector3.Z, vector4.Y + vector3.Y * vector5.Y / vector3.Z);
			if (vector6.X >= 0f && vector6.Y >= 0f && vector6.X <= (float)rect.Right && vector6.Y <= (float)rect.Bottom)
			{
				return vector6;
			}
			return new Vector2(0f, 0f);
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0071CD14 File Offset: 0x0071AF14
		internal static Matrix4x4 Matrix4x4
		{
			get
			{
				Matrix4x4 result;
				try
				{
					byte[] matrix = ObjectManager.Camera.Matrix;
					result = new Matrix4x4(BitConverter.ToSingle(matrix, 0), BitConverter.ToSingle(matrix, 4), BitConverter.ToSingle(matrix, 8), 0f, BitConverter.ToSingle(matrix, 12), BitConverter.ToSingle(matrix, 16), BitConverter.ToSingle(matrix, 20), 0f, BitConverter.ToSingle(matrix, 24), BitConverter.ToSingle(matrix, 28), BitConverter.ToSingle(matrix, 32), 0f, 0f, 0f, 0f, 1f);
				}
				catch
				{
					result = new Matrix4x4(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
				}
				return result;
			}
		}

		// Token: 0x060017BB RID: 6075
		[DllImport("user32.dll")]
		private static extern bool GetClientRect(IntPtr hWnd, ref W2S.Rect rect);

		// Token: 0x060017BC RID: 6076
		[DllImport("user32.dll")]
		public static extern bool GetClientRect(IntPtr hWnd, out Rectangle lpRect);

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x0071CE08 File Offset: 0x0071B008
		public static int WindowWidth
		{
			get
			{
				Rectangle rectangle;
				W2S.GetClientRect(_globals.processHandle, out rectangle);
				return Math.Abs(rectangle.Right - rectangle.Left);
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0071CE38 File Offset: 0x0071B038
		public static int WindowHeight
		{
			get
			{
				Rectangle rectangle;
				W2S.GetClientRect(_globals.processHandle, out rectangle);
				return Math.Abs(rectangle.Bottom - rectangle.Top);
			}
		}

		// Token: 0x02000105 RID: 261
		private struct Rect
		{
			// Token: 0x04000AB8 RID: 2744
			public int Left;

			// Token: 0x04000AB9 RID: 2745
			public int Top;

			// Token: 0x04000ABA RID: 2746
			public int Right;

			// Token: 0x04000ABB RID: 2747
			public int Bottom;
		}
	}
}
