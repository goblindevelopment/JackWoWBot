using System;
using System.Collections.Generic;
using System.Numerics;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x0200004C RID: 76
	public class Objects : SearchObjects
	{
		// Token: 0x06000709 RID: 1801 RVA: 0x00671B18 File Offset: 0x0066FD18
		public Objects(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0067BB50 File Offset: 0x00679D50
		public virtual UInt128 CreatorGUID
		{
			get
			{
				return (UInt128)Read.Combined<UInt128>(this.baseAddress + Descriptors.ObjectFields_CreatorGUID);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0067BB78 File Offset: 0x00679D78
		public Constants.ObjectType Type
		{
			get
			{
				Constants.ObjectType result;
				try
				{
					result = (Constants.ObjectType)Read.Combined<byte>(this.baseAddress + Descriptors.ObjectFields_Type);
				}
				catch
				{
					result = Constants.ObjectType.NA;
				}
				return result;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0067BBBC File Offset: 0x00679DBC
		public Constants.ObjectDetail Detail
		{
			get
			{
				int num;
				if (!_globals.ObjectManagerRetail)
				{
					num = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ObjectFields_Detail);
				}
				else
				{
					num = (int)Read.Combined<int>(this.baseAddress + Descriptors.ObjectFields_Detail);
				}
				return (Constants.ObjectDetail)(num >> 8 & 255);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0067BC14 File Offset: 0x00679E14
		public bool IsGather
		{
			get
			{
				return this.Detail == Constants.ObjectDetail.Chest || this.Detail == Constants.ObjectDetail.GatheringNode;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x0067BC38 File Offset: 0x00679E38
		public bool IsHerb
		{
			get
			{
				return _globals.List_Herbalism.ContainsKey(this.ItemID);
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0067BC58 File Offset: 0x00679E58
		public bool IsOre
		{
			get
			{
				return _globals.List_Mining.ContainsKey(this.ItemID);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0067BC78 File Offset: 0x00679E78
		public bool IsChest
		{
			get
			{
				return Convert.ToBoolean(this.IsGather && !this.IsHerb && !this.IsOre);
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0067BCA8 File Offset: 0x00679EA8
		public bool IsContainer
		{
			get
			{
				return _globals.List_Container.Contains(this.ItemID);
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0067BCC8 File Offset: 0x00679EC8
		public bool IsFishingPool
		{
			get
			{
				return this.Detail == Constants.ObjectDetail.FishingNode || _globals.List_FishingPools.Contains(this.ItemID);
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0067BCF4 File Offset: 0x00679EF4
		public float PositionX
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.ObjectFields_X);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0067BD38 File Offset: 0x00679F38
		public float PositionY
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.ObjectFields_Y);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0067BD7C File Offset: 0x00679F7C
		public float PositionZ
		{
			get
			{
				float result;
				try
				{
					result = (float)Read.Combined<float>(this.baseAddress + Descriptors.ObjectFields_Z);
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0067BDC0 File Offset: 0x00679FC0
		public virtual Vector2 PositionVector2
		{
			get
			{
				return new Vector2(this.PositionX, this.PositionY);
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0067BDE0 File Offset: 0x00679FE0
		public virtual Vector3 PositionVector3
		{
			get
			{
				return new Vector3(this.PositionX, this.PositionY, this.PositionZ);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0067BE04 File Offset: 0x0067A004
		public bool IsBehind
		{
			get
			{
				return JackMath.IsBehind(this.PositionVector3, false);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0067BE20 File Offset: 0x0067A020
		public bool IsBehindOverlay
		{
			get
			{
				return JackMath.IsBehind(this.PositionVector3, true);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0067BE3C File Offset: 0x0067A03C
		public string Name
		{
			get
			{
				return (string)Read.Combined<string>((IntPtr)Read.Combined<IntPtr>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.ObjectFields_Name1) + Descriptors.ObjectFields_Name2));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0067BE84 File Offset: 0x0067A084
		public int DisplayID
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(this.baseAddress + Descriptors.ObjectFields_DisplayID);
				}
				return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ObjectFields_DisplayID);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0067BED0 File Offset: 0x0067A0D0
		public int ItemID
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(this.baseAddress + Descriptors.ObjectFields_ItemID);
				}
				return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.ObjectFields_ItemID);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x0067BF1C File Offset: 0x0067A11C
		public int Flags
		{
			get
			{
				return (int)Read.Combined<int>(this.baseAddress + Descriptors.ObjectFields_Flags);
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x0067BF44 File Offset: 0x0067A144
		public int LowFlags
		{
			get
			{
				return (int)Read.Combined<int>(this.baseAddress + Descriptors.ObjectFields_LowFlags);
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x0067BF6C File Offset: 0x0067A16C
		public bool IsLocked
		{
			get
			{
				return Convert.ToBoolean((long)this.LowFlags & 2L);
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0067BF90 File Offset: 0x0067A190
		public bool IsAvailable
		{
			get
			{
				return (int)Read.Combined<int>(this.baseAddress + Descriptors.ObjectFields_Available) > 0;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x0067BFBC File Offset: 0x0067A1BC
		public string GetTransportType
		{
			get
			{
				int displayID = this.DisplayID;
				foreach (KeyValuePair<int, string> keyValuePair in _globals.List_Transports)
				{
					if (keyValuePair.Key == displayID)
					{
						return keyValuePair.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x0067C02C File Offset: 0x0067A22C
		public Matrix4x4 Matrix
		{
			get
			{
				try
				{
					byte[] value = _globals.processHandleRead.Memory.Read<byte>(this.baseAddress + Descriptors.ObjectFields_Matrix, 36);
					return new Matrix4x4(BitConverter.ToSingle(value, 0), BitConverter.ToSingle(value, 4), BitConverter.ToSingle(value, 8), 0f, BitConverter.ToSingle(value, 12), BitConverter.ToSingle(value, 16), BitConverter.ToSingle(value, 20), 0f, BitConverter.ToSingle(value, 24), BitConverter.ToSingle(value, 28), BitConverter.ToSingle(value, 32), 0f, 0f, 0f, 0f, 1f);
				}
				catch
				{
				}
				return new Matrix4x4(0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f);
			}
		}
	}
}
