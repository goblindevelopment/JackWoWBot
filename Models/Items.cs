using System;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x02000044 RID: 68
	public class Items : SearchObjects
	{
		// Token: 0x0600066F RID: 1647 RVA: 0x00671B18 File Offset: 0x0066FD18
		public Items(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x006796D8 File Offset: 0x006778D8
		public virtual UInt128 OwnerGUID
		{
			get
			{
				UInt128 result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (UInt128)Read.Combined<UInt128>(this.baseAddress + Descriptors.ItemFields_OwnerGUID);
					}
					else
					{
						result = (UInt128)Read.Combined<UInt128>(base.DescriptorFields + Descriptors.ItemFields_OwnerGUID);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00679744 File Offset: 0x00677944
		public int StackCount
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.ItemFields_StackCount);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ItemFields_StackCount);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x006797A8 File Offset: 0x006779A8
		public int EffectID
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.ItemFields_EffectID);
					}
					else
					{
						result = 0;
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x006797F4 File Offset: 0x006779F4
		public int ItemID
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.ItemFields_ItemID);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ItemFields_ItemID);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00679858 File Offset: 0x00677A58
		public int Durability
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.ItemFields_Durability);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ItemFields_Durability);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x006798BC File Offset: 0x00677ABC
		public int MaxDurability
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.ItemFields_MaxDurability);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ItemFields_MaxDurability);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00679920 File Offset: 0x00677B20
		public UInt128 ContainedInGUID
		{
			get
			{
				UInt128 result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (UInt128)Read.Combined<UInt128>(this.baseAddress + Descriptors.ItemFields_ContainedIn);
					}
					else
					{
						result = (UInt128)Read.Combined<UInt128>(base.DescriptorFields + Descriptors.ItemFields_ContainedIn);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0067998C File Offset: 0x00677B8C
		public string ItemName
		{
			get
			{
				string result = "";
				try
				{
					if (_globals.List_Items.ContainsKey(this.ItemID))
					{
						result = _globals.List_Items[this.ItemID];
					}
				}
				catch
				{
				}
				return result;
			}
		}
	}
}
