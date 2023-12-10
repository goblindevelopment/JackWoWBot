using System;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x02000031 RID: 49
	public class Container : SearchObjects
	{
		// Token: 0x060003D4 RID: 980 RVA: 0x00671B18 File Offset: 0x0066FD18
		public Container(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00671DC8 File Offset: 0x0066FFC8
		public int NumSlots
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(this.baseAddress + Descriptors.ContainerFields_NumSlots);
				}
				return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ContainerFields_NumSlots);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x00671E14 File Offset: 0x00670014
		public int FreeSlots
		{
			get
			{
				int num = 0;
				for (int i = 0; i < this.NumSlots; i++)
				{
					try
					{
						UInt128 a;
						if (_globals.ObjectManagerRetail)
						{
							a = (UInt128)Read.Combined<UInt128>(this.baseAddress + Descriptors.ContainerFields_BagSlots + Descriptors.ContainerFields_BagSlotsNext * i);
						}
						else
						{
							a = (UInt128)Read.Combined<UInt128>(base.DescriptorFields + Descriptors.ContainerFields_BagSlots + Descriptors.ContainerFields_BagSlotsNext * i);
						}
						if (a <= 0)
						{
							num++;
						}
					}
					catch
					{
					}
				}
				return num;
			}
		}
	}
}
