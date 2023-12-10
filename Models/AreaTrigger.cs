using System;
using System.Numerics;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x0200002F RID: 47
	public class AreaTrigger : SearchObjects
	{
		// Token: 0x060003C5 RID: 965 RVA: 0x00671B18 File Offset: 0x0066FD18
		public AreaTrigger(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00671B2C File Offset: 0x0066FD2C
		public virtual UInt128 CreatorGUID
		{
			get
			{
				return (UInt128)Read.Combined<UInt128>(this.baseAddress + Descriptors.AreaTrigger_CreatorGUID);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00671B54 File Offset: 0x0066FD54
		public float PositionX
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.AreaTriggerFields_X);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00671B98 File Offset: 0x0066FD98
		public float PositionY
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.AreaTriggerFields_Y);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00671BDC File Offset: 0x0066FDDC
		public float PositionZ
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.AreaTriggerFields_Z);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00671C20 File Offset: 0x0066FE20
		public virtual Vector2 PositionVector2
		{
			get
			{
				return new Vector2(this.PositionX, this.PositionY);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00671C40 File Offset: 0x0066FE40
		public virtual Vector3 PositionVector3
		{
			get
			{
				return new Vector3(this.PositionX, this.PositionY, this.PositionZ);
			}
		}
	}
}
