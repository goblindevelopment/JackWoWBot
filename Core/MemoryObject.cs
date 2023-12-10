using System;

namespace Jack.Core
{
	// Token: 0x02000133 RID: 307
	public abstract class MemoryObject
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x0072E304 File Offset: 0x0072C504
		public MemoryObject(IntPtr baseAddress)
		{
			this.baseAddress = baseAddress;
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x0072E320 File Offset: 0x0072C520
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0072E334 File Offset: 0x0072C534
		public IntPtr BaseAddress
		{
			get
			{
				return this.baseAddress;
			}
			set
			{
				this.baseAddress = value;
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x0072E348 File Offset: 0x0072C548
		internal void UpdateBaseAddress(IntPtr address)
		{
			this.BaseAddress = address;
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x0072E35C File Offset: 0x0072C55C
		public bool IsValid
		{
			get
			{
				return this.BaseAddress != IntPtr.Zero;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0072E37C File Offset: 0x0072C57C
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0072E390 File Offset: 0x0072C590
		public virtual UInt128 GUID128
		{
			get
			{
				return this.GUID;
			}
			set
			{
				this.GUID = value;
			}
		}

		// Token: 0x04000F58 RID: 3928
		public IntPtr baseAddress;

		// Token: 0x04000F59 RID: 3929
		public UInt128 GUID;
	}
}
