using System;
using System.Numerics;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x02000030 RID: 48
	public class Camera : SearchObjects
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00671B18 File Offset: 0x0066FD18
		public Camera(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00671C64 File Offset: 0x0066FE64
		public byte[] Matrix
		{
			get
			{
				return _globals.processHandleRead.Memory.Read<byte>(this.baseAddress + Descriptors.Camera_Matrix, 36);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00671C94 File Offset: 0x0066FE94
		public float PositionX
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.Camera_X);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00671CD8 File Offset: 0x0066FED8
		public float PositionY
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.Camera_Y);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00671D1C File Offset: 0x0066FF1C
		public float PositionZ
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.Camera_Z);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00671D60 File Offset: 0x0066FF60
		public Vector3 PositionVector3
		{
			get
			{
				return new Vector3(this.PositionX, this.PositionY, this.PositionZ);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00671D84 File Offset: 0x0066FF84
		public float FoV
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.Camera_Fov);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}
	}
}
