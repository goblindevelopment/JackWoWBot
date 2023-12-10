using System;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x02000033 RID: 51
	public class Pet : Units
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x00672058 File Offset: 0x00670258
		public Pet(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0067206C File Offset: 0x0067026C
		public void Set()
		{
			try
			{
				UInt128 @uint = (UInt128)Read.Single<UInt128>(Offsets.Local_PetGUID);
				if (@uint > 0)
				{
					_globals.petGUID128 = @uint;
				}
				else
				{
					_globals.petGUID128 = 0;
				}
			}
			catch
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x006720BC File Offset: 0x006702BC
		public bool IsAvailable
		{
			get
			{
				return _globals.petBaseAddress != IntPtr.Zero;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x006720D8 File Offset: 0x006702D8
		public bool IsSpawned
		{
			get
			{
				return Convert.ToBoolean(_globals.petGUID128 > 0 && this.IsAvailable);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00672100 File Offset: 0x00670300
		public bool IsReady
		{
			get
			{
				return Convert.ToBoolean(_globals.petGUID128 > 0 && this.IsAvailable && base.IsAlive);
			}
		}
	}
}
