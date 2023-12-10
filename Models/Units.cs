using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Jack.Core;
using Jack.Engine;

namespace Jack.Models
{
	// Token: 0x02000046 RID: 70
	public class Units : SearchObjects
	{
		// Token: 0x0600068D RID: 1677 RVA: 0x00671B18 File Offset: 0x0066FD18
		public Units(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00679BB0 File Offset: 0x00677DB0
		public UInt128 TargetGUID
		{
			get
			{
				UInt128 result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (UInt128)Read.Combined<UInt128>(this.baseAddress + Descriptors.UnitFields_TargetGUID);
					}
					else
					{
						result = (UInt128)Read.Combined<UInt128>(base.DescriptorFields + Descriptors.UnitFields_TargetGUID);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00679C1C File Offset: 0x00677E1C
		public int TargetDisplayID
		{
			get
			{
				int result;
				try
				{
					if (this.TargetGUID > 0)
					{
						Units unitByGUID = ObjectManager.GetUnitByGUID(this.TargetGUID);
						if (unitByGUID != null)
						{
							return unitByGUID.DisplayID;
						}
					}
					result = 0;
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00679C6C File Offset: 0x00677E6C
		public int Level
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_Level);
				}
				return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_Level);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00679CB8 File Offset: 0x00677EB8
		public int CurrentHealth
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_CurrentHealth);
				}
				return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_CurrentHealth);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00679D04 File Offset: 0x00677F04
		public int MaxHealth
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_MaxHealth);
				}
				return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_MaxHealth);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00679D50 File Offset: 0x00677F50
		public int CurrentHealthPercent
		{
			get
			{
				return JackMath.CalcToPercent(this.CurrentHealth, this.MaxHealth);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00679D70 File Offset: 0x00677F70
		public int GetPowerNumber
		{
			get
			{
				int num = 1;
				if (this.IsDruid)
				{
					if (!this.IsInBearForm)
					{
						if (this.IsInCatForm)
						{
							num = 3;
						}
					}
					else
					{
						num = 2;
					}
				}
				return num - 1;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00679DA0 File Offset: 0x00677FA0
		public int CurrentPower
		{
			get
			{
				int offset = Descriptors.UnitFields_CurrentPower + this.GetPowerNumber * 4;
				int num;
				if (_globals.ObjectManagerRetail)
				{
					num = (int)Read.Combined<int>(this.baseAddress + offset);
				}
				else
				{
					num = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_CurrentPower);
				}
				if (this.IsWarrior || (this.IsDruid && this.IsInBearForm))
				{
					num = (int)Math.Floor((double)(num / 10));
				}
				return num;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00679E20 File Offset: 0x00678020
		public int MaxPower
		{
			get
			{
				int offset = Descriptors.UnitFields_MaxPower + this.GetPowerNumber * 4;
				int num;
				if (!_globals.ObjectManagerRetail)
				{
					num = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_MaxPower);
				}
				else
				{
					num = (int)Read.Combined<int>(this.baseAddress + offset);
				}
				if (this.IsWarrior || (this.IsDruid && this.IsInBearForm))
				{
					num = (int)Math.Floor((double)(num / 10));
				}
				return num;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00679EA0 File Offset: 0x006780A0
		public int CurrentPowerPercent
		{
			get
			{
				if (!this.IsWarrior && (!this.IsDruid || !this.IsInBearForm))
				{
					return JackMath.CalcToPercent(this.CurrentPower, this.MaxPower);
				}
				return this.CurrentPower;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00679EE0 File Offset: 0x006780E0
		public int CurrentMana
		{
			get
			{
				int result;
				if (_globals.ObjectManagerRetail)
				{
					result = (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_CurrentPower);
				}
				else
				{
					result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_CurrentPower);
				}
				return result;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00679F30 File Offset: 0x00678130
		public int MaxMana
		{
			get
			{
				int result;
				if (!_globals.ObjectManagerRetail)
				{
					result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_MaxPower);
				}
				else
				{
					result = (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_MaxPower);
				}
				return result;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x00679F80 File Offset: 0x00678180
		public int CurrentManaPercent
		{
			get
			{
				return JackMath.CalcToPercent(this.CurrentMana, this.MaxMana);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00679FA0 File Offset: 0x006781A0
		public int ComboPointsDruid
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_ComboPointsDruid);
				}
				return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_ComboPointsDruid);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00679FEC File Offset: 0x006781EC
		public int ComboPoints
		{
			get
			{
				if (this.IsDruid)
				{
					return this.ComboPointsDruid;
				}
				if (!_globals.ObjectManagerRetail)
				{
					return (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_ComboPoints);
				}
				return (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_ComboPoints);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0067A044 File Offset: 0x00678244
		public float Facing
		{
			get
			{
				return (float)Read.Combined<float>(this.baseAddress + Descriptors.UnitFields_Facing);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0067A06C File Offset: 0x0067826C
		public float Pitch
		{
			get
			{
				return (float)Read.Combined<float>(this.baseAddress + Descriptors.UnitFields_Pitch);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x0067A094 File Offset: 0x00678294
		public string Name
		{
			get
			{
				return (string)Read.Combined<string>((IntPtr)Read.Combined<IntPtr>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_2) + Descriptors.UnitFields_Name));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0067A0DC File Offset: 0x006782DC
		public float Speed
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (float)Read.Combined<float>(this.baseAddress + Descriptors.UnitFields_Speed);
				}
				return (float)Read.Combined<float>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_1) + Descriptors.UnitFields_Speed);
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0067A13C File Offset: 0x0067833C
		public bool IsMoving
		{
			get
			{
				return this.Speed > 0f;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0067A158 File Offset: 0x00678358
		public float PositionX
		{
			get
			{
				float result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (float)Read.Combined<float>(this.baseAddress + Descriptors.UnitFields_X);
					}
					else
					{
						result = (float)Read.Combined<float>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_1) + Descriptors.UnitFields_X);
					}
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0067A1D4 File Offset: 0x006783D4
		public float PositionY
		{
			get
			{
				float result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (float)Read.Combined<float>(this.baseAddress + Descriptors.UnitFields_Y);
					}
					else
					{
						result = (float)Read.Combined<float>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_1) + Descriptors.UnitFields_Y);
					}
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0067A250 File Offset: 0x00678450
		public float PositionZ
		{
			get
			{
				float result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (float)Read.Combined<float>(this.baseAddress + Descriptors.UnitFields_Z);
					}
					else
					{
						result = (float)Read.Combined<float>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_1) + Descriptors.UnitFields_Z);
					}
				}
				catch
				{
					result = 0f;
				}
				return result;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0067A2CC File Offset: 0x006784CC
		public virtual Vector2 PositionVector2
		{
			get
			{
				return new Vector2(this.PositionX, this.PositionY);
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0067A2EC File Offset: 0x006784EC
		public virtual Vector3 PositionVector3
		{
			get
			{
				return new Vector3(this.PositionX, this.PositionY, this.PositionZ);
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0067A310 File Offset: 0x00678510
		public bool IsCasting
		{
			get
			{
				return (bool)Read.Combined<bool>(this.baseAddress + Descriptors.UnitFields_IsCasting);
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0067A338 File Offset: 0x00678538
		public bool IsChanneling
		{
			get
			{
				return (bool)Read.Combined<bool>(this.baseAddress + Descriptors.UnitFields_IsChanneling);
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0067A360 File Offset: 0x00678560
		public Constants.PlayerRace Race
		{
			get
			{
				Constants.PlayerRace result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (Constants.PlayerRace)((int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_Race));
					}
					else
					{
						result = (Constants.PlayerRace)((int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_Race));
					}
				}
				catch
				{
					result = (Constants.PlayerRace)0;
				}
				return result;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0067A3C4 File Offset: 0x006785C4
		public bool IsAlliance
		{
			get
			{
				return this.Race.Equals(Constants.PlayerRace.Human) || this.Race.Equals(Constants.PlayerRace.Dwarf) || this.Race.Equals(Constants.PlayerRace.NightElf) || this.Race.Equals(Constants.PlayerRace.Gnome) || this.Race.Equals(Constants.PlayerRace.Draenei) || this.Race.Equals(Constants.PlayerRace.Worgen);
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0067A494 File Offset: 0x00678694
		public bool IsHorde
		{
			get
			{
				return this.Race.Equals(Constants.PlayerRace.Orc) || this.Race.Equals(Constants.PlayerRace.Undead) || this.Race.Equals(Constants.PlayerRace.Tauren) || this.Race.Equals(Constants.PlayerRace.Troll) || this.Race.Equals(Constants.PlayerRace.BloodElf) || this.Race.Equals(Constants.PlayerRace.Goblin);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0067A568 File Offset: 0x00678768
		public bool IsNPC
		{
			get
			{
				return !this.IsPlayerControlled && !this.IsAlliance && !this.IsHorde;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0067A590 File Offset: 0x00678790
		public string Faction
		{
			get
			{
				string result = "NPC";
				if (this.IsAlliance)
				{
					result = "Alliance";
				}
				else if (this.IsHorde)
				{
					result = "Horde";
				}
				return result;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0067A5C4 File Offset: 0x006787C4
		public bool IsOpposingFaction
		{
			get
			{
				string faction = this.Faction;
				return faction != "NPC" && faction != ObjectManager.Me.Faction;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0067A5F8 File Offset: 0x006787F8
		public int GetFlag1
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_Flags1);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_Flags1);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0067A65C File Offset: 0x0067885C
		public int GetDynamicFlag
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_DynamicFlags);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_DynamicFlags);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0067A6C0 File Offset: 0x006788C0
		public bool IsInCombat
		{
			get
			{
				return Convert.ToBoolean((long)this.GetFlag1 & 524288L);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0067A6E4 File Offset: 0x006788E4
		public bool HasTarget
		{
			get
			{
				return Convert.ToBoolean(this.TargetGUID > 0);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0067A704 File Offset: 0x00678904
		public bool IsTargetingMe
		{
			get
			{
				return Convert.ToBoolean(this.TargetGUID == _globals.playerGUID128);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0067A728 File Offset: 0x00678928
		public bool IsTargetingPet
		{
			get
			{
				return Convert.ToBoolean(ObjectManager.Pet.IsReady && this.TargetGUID == _globals.petGUID128);
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0067A75C File Offset: 0x0067895C
		public bool IsInCombatWithMe
		{
			get
			{
				if (_globals.IsPVP)
				{
					return Convert.ToBoolean(this.IsOpposingFaction && this.IsPlayerControlled && this.IsInCombat && (this.IsTargetingPet || ObjectManager.Me.IsInCombat));
				}
				return Convert.ToBoolean(!this.IsPlayerControlled && this.IsInCombat && (this.IsTargetingMe || (PlayerMe.IsInDungeon && ObjectManager.Me.IsInCombat)));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0067A7E0 File Offset: 0x006789E0
		public bool IsInCombatWithPet
		{
			get
			{
				if (_globals.IsPVP)
				{
					return Convert.ToBoolean(ObjectManager.Pet.IsReady && this.IsPlayerControlled && this.IsOpposingFaction && this.IsInCombat && (this.IsTargetingPet || ObjectManager.Pet.IsInCombat));
				}
				return Convert.ToBoolean(ObjectManager.Pet.IsReady && !this.IsPlayerControlled && this.IsInCombat && (this.IsTargetingPet || (PlayerMe.IsInDungeon && ObjectManager.Pet.IsInCombat)));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0067A87C File Offset: 0x00678A7C
		public bool IsInCombatWithNPC
		{
			get
			{
				if (this.HasTarget && !this.IsTargetingMe)
				{
					using (List<Units>.Enumerator enumerator = ObjectManager.GetNPCs.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.GUID == this.TargetGUID)
							{
								return true;
							}
						}
					}
					return false;
				}
				return false;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0067A8F4 File Offset: 0x00678AF4
		public bool IsRelatedToAnotherPlayer
		{
			get
			{
				if (!_globals.IsRetail && !_globals.IsInDungeon && !_globals.IsInBattleground && this.HasTarget && !this.IsTargetingMe && !this.IsTargetingPet)
				{
					using (List<Player>.Enumerator enumerator = ObjectManager.GetPlayer.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.GUID == this.TargetGUID)
							{
								return true;
							}
						}
					}
					return false;
				}
				return false;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0067A98C File Offset: 0x00678B8C
		public bool IsFleeing
		{
			get
			{
				return Convert.ToBoolean((long)this.GetFlag1 & 8388608L);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0067A9B0 File Offset: 0x00678BB0
		public bool IsRunningBack
		{
			get
			{
				return Convert.ToBoolean((long)this.GetFlag1 & 16L);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0067A9D4 File Offset: 0x00678BD4
		public bool IsStunned
		{
			get
			{
				return Convert.ToBoolean((long)this.GetFlag1 & 262144L);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0067A9F8 File Offset: 0x00678BF8
		public bool IsSkinnable
		{
			get
			{
				return Convert.ToBoolean((long)this.GetFlag1 & 67108864L);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0067AA1C File Offset: 0x00678C1C
		public bool IsPlayerControlled
		{
			get
			{
				return Convert.ToBoolean((long)this.GetFlag1 & 8L);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0067AA40 File Offset: 0x00678C40
		public bool IsPet
		{
			get
			{
				using (List<Player>.Enumerator enumerator = ObjectManager.GetPlayer.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Player player = enumerator.Current;
						if (this.GUID128 == player.GUID128)
						{
							return false;
						}
					}
					return true;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0067AAA8 File Offset: 0x00678CA8
		public int DisplayID
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_DisplayID);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_DisplayID);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0067AB0C File Offset: 0x00678D0C
		public int MountDisplayID
		{
			get
			{
				int result;
				try
				{
					if (_globals.ObjectManagerRetail)
					{
						result = (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_MountDisplayID);
					}
					else
					{
						result = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_MountDisplayID);
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0067AB70 File Offset: 0x00678D70
		public bool IsAlive
		{
			get
			{
				return this.CurrentHealth > 0;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0067AB88 File Offset: 0x00678D88
		public bool IsDead
		{
			get
			{
				return !this.IsAlive;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0067ABA0 File Offset: 0x00678DA0
		public bool IsGhost
		{
			get
			{
				return this.CurrentHealth == 1;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0067ABBC File Offset: 0x00678DBC
		public bool IsLootable
		{
			get
			{
				return Convert.ToBoolean(this.GetDynamicFlag & 4);
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0067ABD8 File Offset: 0x00678DD8
		public bool IsMounted
		{
			get
			{
				bool result;
				try
				{
					if (this.IsDruid)
					{
						if (this.IsInFlightForm)
						{
							return true;
						}
						if (this.IsInTravelForm)
						{
							return true;
						}
						if (this.IsInAquaticForm)
						{
							return true;
						}
					}
					result = Convert.ToBoolean(this.MountDisplayID > 0);
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0067AC38 File Offset: 0x00678E38
		public bool IsFlying
		{
			get
			{
				if (_globals.TestEnv["NoFlyCheck"])
				{
					return false;
				}
				if (this.GUID128 == _globals.playerGUID128 && ObjectManager.Me.IsInVashjir)
				{
					return true;
				}
				if (_globals.ObjectManagerRetail)
				{
					return ((int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_Flying) & Descriptors.UnitFields_FlyingMask) != 0;
				}
				return ((int)Read.Combined<int>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_1) + Descriptors.UnitFields_Flying) & Descriptors.UnitFields_FlyingMask) != 0;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0067ACDC File Offset: 0x00678EDC
		public bool IsSwimming
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return ((int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_Swimming) & Descriptors.UnitFields_SwimmingMask) != 0;
				}
				return ((int)Read.Combined<int>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_1) + Descriptors.UnitFields_Swimming) & Descriptors.UnitFields_SwimmingMask) != 0;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0067AD4C File Offset: 0x00678F4C
		public Constants.CreatureType CreatureType
		{
			get
			{
				return (Constants.CreatureType)((int)Read.Combined<int>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_2) + Descriptors.UnitFields_CreatureType));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0067AD88 File Offset: 0x00678F88
		public Constants.CreatureRank CreatureRank
		{
			get
			{
				return (Constants.CreatureRank)((int)Read.Combined<int>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.UnitFields_Information_2) + Descriptors.UnitFields_CreatureRank));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0067ADC4 File Offset: 0x00678FC4
		public bool IsCritter
		{
			get
			{
				return this.CreatureType.Equals(Constants.CreatureType.Critter);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0067ADEC File Offset: 0x00678FEC
		public bool IsNonCombatPet
		{
			get
			{
				return this.CreatureType.Equals(Constants.CreatureType.NonCombatPet);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0067AE14 File Offset: 0x00679014
		public bool IsNotSpecified
		{
			get
			{
				return this.CreatureType.Equals(Constants.CreatureType.NotSpecified);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0067AE3C File Offset: 0x0067903C
		public bool IsGasCloud
		{
			get
			{
				return this.CreatureType.Equals(Constants.CreatureType.GasCloud);
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0067AE64 File Offset: 0x00679064
		public bool IsElite
		{
			get
			{
				return this.CreatureRank.Equals(Constants.CreatureRank.Elite);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0067AE8C File Offset: 0x0067908C
		public Constants.UnitClass Class
		{
			get
			{
				int num;
				if (_globals.ObjectManagerRetail)
				{
					num = (int)Read.Combined<int>(this.baseAddress + Descriptors.UnitFields_Class);
				}
				else
				{
					num = (int)Read.Combined<int>(base.DescriptorFields + Descriptors.UnitFields_Class);
				}
				return (Constants.UnitClass)(num >> 8 & 255);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0067AEE4 File Offset: 0x006790E4
		public bool IsDruid
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Druid);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0067AF0C File Offset: 0x0067910C
		public bool IsRogue
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Rogue);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0067AF34 File Offset: 0x00679134
		public bool IsWarrior
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Warrior);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0067AF5C File Offset: 0x0067915C
		public bool DeathKnight
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.DeathKnight);
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0067AF84 File Offset: 0x00679184
		public bool IsPaladin
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Paladin);
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0067AFAC File Offset: 0x006791AC
		public bool IsHunter
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Hunter);
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0067AFD4 File Offset: 0x006791D4
		public bool IsPriest
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Priest);
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0067AFFC File Offset: 0x006791FC
		public bool IsShaman
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Shaman);
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0067B024 File Offset: 0x00679224
		public bool IsMage
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Mage);
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0067B04C File Offset: 0x0067924C
		public bool IsWarlock
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Warlock);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0067B074 File Offset: 0x00679274
		public bool IsMonk
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Monk);
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0067B09C File Offset: 0x0067929C
		public bool IsDemonHunter
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.DemonHunter);
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0067B0C4 File Offset: 0x006792C4
		public Constants.DruidShapeshift DruidShapeshiftForm
		{
			get
			{
				if (_globals.ObjectManagerRetail)
				{
					return (Constants.DruidShapeshift)((byte)Read.Combined<byte>(this.baseAddress + Descriptors.ClassDruid_ShapeshiftFormID2));
				}
				return (Constants.DruidShapeshift)((byte)Read.Combined<byte>((IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.ClassDruid_ShapeshiftFormID1) + Descriptors.ClassDruid_ShapeshiftFormID2));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0067B124 File Offset: 0x00679324
		public bool IsInTravelForm
		{
			get
			{
				return this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.Travel);
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0067B14C File Offset: 0x0067934C
		public bool IsInCatForm
		{
			get
			{
				return this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.Cat);
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0067B174 File Offset: 0x00679374
		public bool IsInFlightForm
		{
			get
			{
				return Convert.ToBoolean(this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.FlightForm) | this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.EpicFlightForm));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0067B1C0 File Offset: 0x006793C0
		public bool IsInAquaticForm
		{
			get
			{
				return this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.Aqua);
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0067B1E8 File Offset: 0x006793E8
		public bool IsInBearForm
		{
			get
			{
				bool flag = this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.Bear);
				bool flag2 = this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.CreatureBear);
				bool flag3 = this.DruidShapeshiftForm.Equals(Constants.DruidShapeshift.DireBear);
				return Convert.ToBoolean(flag || flag2 || flag3);
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0067B250 File Offset: 0x00679450
		public bool IsMelee
		{
			get
			{
				return this.Class.Equals(Constants.UnitClass.Warrior) || this.Class.Equals(Constants.UnitClass.Rogue) || this.Class.Equals(Constants.UnitClass.Paladin) || this.Class.Equals(Constants.UnitClass.Shaman) || this.Class.Equals(Constants.UnitClass.Druid) || this.Class.Equals(Constants.UnitClass.DeathKnight);
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0067B314 File Offset: 0x00679514
		public bool IsManaClass
		{
			get
			{
				return this.IsPaladin || this.IsHunter || (this.IsDruid && !this.IsInBearForm) || this.IsPriest || this.IsShaman || this.IsMage || this.IsWarlock;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0067B370 File Offset: 0x00679570
		public bool IsBehind
		{
			get
			{
				return JackMath.IsBehind(this.PositionVector3, false);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0067B38C File Offset: 0x0067958C
		public bool IsBehindOverlay
		{
			get
			{
				return JackMath.IsBehind(this.PositionVector3, true);
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0067B3A8 File Offset: 0x006795A8
		public IEnumerable<Units.AurasList> GetAuras
		{
			get
			{
				if (_globals.IsRetail)
				{
					return this.GetAurasRetail;
				}
				int auras_Table = Descriptors.Auras_Table1;
				int auras_Table2 = Descriptors.Auras_Table2;
				int auras_Size = Descriptors.Auras_Size;
				int auras_SpellID = Descriptors.Auras_SpellID;
				int auras_OwnerGUID = Descriptors.Auras_OwnerGUID;
				List<Units.AurasList> list = new List<Units.AurasList>();
				if (!_globals.TestEnv["Auras"])
				{
					int num = (int)Read.Combined<int>(this.baseAddress + auras_Table);
					if (num == -1)
					{
						num = (int)Read.Combined<int>(this.baseAddress + auras_Table2);
					}
					IntPtr intPtr = IntPtr.Zero;
					if (num == -1)
					{
						intPtr = this.baseAddress + auras_Table;
					}
					else
					{
						intPtr = this.baseAddress + auras_Table2;
					}
					if (intPtr != IntPtr.Zero)
					{
						for (int i = 0; i < num; i++)
						{
							int num2 = (int)Read.Combined<int>(intPtr + i * auras_Size + auras_SpellID);
							if (num2 != 0)
							{
								UInt128 @uint = (UInt128)Read.Combined<UInt128>(intPtr + i * auras_Size + auras_OwnerGUID);
								string spellName = Spell.GetSpellName(num2);
								if (spellName != "N/A" && @uint > 0)
								{
									Units.AurasList item = new Units.AurasList
									{
										OwnerGUID = @uint,
										SpellName = spellName,
										SpellID = num2
									};
									list.Add(item);
								}
							}
						}
					}
					return list;
				}
				return list;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0067B51C File Offset: 0x0067971C
		public IEnumerable<Units.AurasList> GetAurasRetail
		{
			get
			{
				int auras_Count = Descriptors.Auras_Count1;
				int auras_Count2 = Descriptors.Auras_Count2;
				int auras_Table = Descriptors.Auras_Table1;
				int auras_Table2 = Descriptors.Auras_Table2;
				int auras_Size = Descriptors.Auras_Size;
				int auras_SpellID = Descriptors.Auras_SpellID;
				int auras_OwnerGUID = Descriptors.Auras_OwnerGUID;
				List<Units.AurasList> list = new List<Units.AurasList>();
				if (_globals.TestEnv["Auras"])
				{
					return list;
				}
				int num = (int)Read.Combined<int>(this.baseAddress + auras_Count);
				if (num == -1)
				{
					num = (int)Read.Combined<int>(this.baseAddress + auras_Count2);
				}
				for (int i = 0; i < num; i++)
				{
					UInt128 @uint = 0;
					int num2;
					if ((int)Read.Combined<int>(this.baseAddress + auras_Count) != -1)
					{
						num2 = (int)Read.Combined<int>(this.baseAddress + auras_Table + i * auras_Size + auras_SpellID);
						@uint = (UInt128)Read.Combined<UInt128>(this.baseAddress + auras_Table + i * auras_Size + auras_OwnerGUID);
					}
					else
					{
						IntPtr pointer = (IntPtr)Read.Combined<IntPtr>(this.baseAddress + auras_Table2);
						num2 = (int)Read.Combined<int>(pointer + i * auras_Size + auras_SpellID);
						@uint = (UInt128)Read.Combined<UInt128>(pointer + i * auras_Size + auras_OwnerGUID);
					}
					if (num2 > 0 && @uint > 0)
					{
						string spellName = Spell.GetSpellName(num2);
						if (spellName != "N/A")
						{
							Units.AurasList item = new Units.AurasList
							{
								OwnerGUID = @uint,
								SpellName = spellName,
								SpellID = num2
							};
							list.Add(item);
						}
					}
				}
				return list;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0067B6E0 File Offset: 0x006798E0
		public List<int> GetBuffIDs
		{
			get
			{
				return (from Aura in this.GetAuras
				select Aura.SpellID).ToList<int>();
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x0067B71C File Offset: 0x0067991C
		public List<int> GetBuffIDsCastedByMe
		{
			get
			{
				List<int> list = new List<int>();
				foreach (Units.AurasList aurasList in this.GetAuras)
				{
					if (aurasList.OwnerGUID == ObjectManager.Me.GUID128)
					{
						list.Add(aurasList.SpellID);
					}
				}
				return list;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0067B790 File Offset: 0x00679990
		public List<string> GetBuffNames
		{
			get
			{
				return (from Aura in this.GetAuras
				select Aura.SpellName).ToList<string>();
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0067B7CC File Offset: 0x006799CC
		public List<string> GetBuffNamesCastedByMe
		{
			get
			{
				List<string> list = new List<string>();
				foreach (Units.AurasList aurasList in this.GetAuras)
				{
					if (aurasList.OwnerGUID == ObjectManager.Me.GUID128)
					{
						list.Add(aurasList.SpellName);
					}
				}
				return list;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0067B840 File Offset: 0x00679A40
		public Dictionary<int, string> GetAllAuras
		{
			get
			{
				Dictionary<int, string> dictionary = new Dictionary<int, string>();
				foreach (Units.AurasList aurasList in this.GetAuras)
				{
					if (!dictionary.ContainsKey(aurasList.SpellID))
					{
						dictionary.Add(aurasList.SpellID, aurasList.SpellName);
					}
				}
				return dictionary;
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0067B8B0 File Offset: 0x00679AB0
		public bool HasBuff(int[] Buffs)
		{
			List<int> Auras = this.GetBuffIDs;
			try
			{
				if (Buffs.Any((int u) => Auras.Contains(u)))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0067B900 File Offset: 0x00679B00
		public bool HasBuff(string[] Buffs)
		{
			List<string> Auras = this.GetBuffNames;
			try
			{
				if (Buffs.Any((string u) => Auras.Contains(u)))
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x0067B950 File Offset: 0x00679B50
		public float Size
		{
			get
			{
				return (float)Read.Combined<float>(this.baseAddress + 156);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0067B978 File Offset: 0x00679B78
		public string GetFlag1GetHex
		{
			get
			{
				string result;
				using (IEnumerator enumerator = Enum.GetValues(typeof(Constants.UnitFlags)).GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
						goto IL_80;
					}
					uint num = (uint)enumerator.Current;
					if (!Convert.ToBoolean((long)this.GetFlag1 & (long)((ulong)num)))
					{
						result = num.ToString();
					}
					else
					{
						result = "0x" + ((long)this.GetFlag1 & (long)((ulong)num)).ToString("X");
					}
				}
				return result;
				IL_80:
				return "-";
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0067BA1C File Offset: 0x00679C1C
		public string GetDynamicFlagGetHex
		{
			get
			{
				for (int i = 0; i < 10000; i++)
				{
					if (Convert.ToBoolean(this.GetDynamicFlag & i))
					{
						return "0x" + (this.GetDynamicFlag & i).ToString("X");
					}
				}
				return "-";
			}
		}

		// Token: 0x02000047 RID: 71
		public struct AurasList
		{
			// Token: 0x040001F7 RID: 503
			public UInt128 OwnerGUID;

			// Token: 0x040001F8 RID: 504
			public int SpellID;

			// Token: 0x040001F9 RID: 505
			public string SpellName;
		}
	}
}
