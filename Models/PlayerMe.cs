using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Jack.Core;
using Jack.Engine;

namespace Jack.Models
{
	// Token: 0x02000034 RID: 52
	public class PlayerMe : Player
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00672130 File Offset: 0x00670330
		public PlayerMe(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00672170 File Offset: 0x00670370
		public static UInt128 LocalGUID
		{
			get
			{
				UInt128 result;
				try
				{
					result = (UInt128)Read.Single<UInt128>(Offsets.Local_GUID);
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x006721AC File Offset: 0x006703AC
		public static UInt128 LocalTargetGUID
		{
			get
			{
				UInt128 result;
				try
				{
					result = (UInt128)Read.Single<UInt128>(Offsets.Local_TargetGUID);
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x006721E8 File Offset: 0x006703E8
		public static string LocalName
		{
			get
			{
				return (string)Read.Single<string>(Offsets.Local_Name);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00672204 File Offset: 0x00670404
		public static bool IsIndoor
		{
			get
			{
				return (bool)Read.Single<bool>(Offsets.Local_IsIndoor);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00672220 File Offset: 0x00670420
		public static UInt128 MouseoverGUID
		{
			get
			{
				UInt128 result;
				try
				{
					result = (UInt128)Read.Single<UInt128>(Offsets.Local_MouseoverGUID);
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0067225C File Offset: 0x0067045C
		public static int MouseoverDisplayID
		{
			get
			{
				int result;
				try
				{
					Units npcbyGUID = ObjectManager.GetNPCByGUID(PlayerMe.MouseoverGUID);
					Objects objectByGUID = ObjectManager.GetObjectByGUID(PlayerMe.MouseoverGUID);
					Items itemByGUID = ObjectManager.GetItemByGUID(PlayerMe.MouseoverGUID);
					if (npcbyGUID != null)
					{
						result = npcbyGUID.DisplayID;
					}
					else if (objectByGUID == null)
					{
						if (itemByGUID != null)
						{
							result = itemByGUID.ItemID;
						}
						else
						{
							result = 0;
						}
					}
					else
					{
						result = objectByGUID.DisplayID;
					}
				}
				catch
				{
					result = 0;
				}
				return result;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x006722C8 File Offset: 0x006704C8
		public static int ZoneID
		{
			get
			{
				return (int)Read.Single<int>(Offsets.Local_ZoneID);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x006722E4 File Offset: 0x006704E4
		public static int MeshID
		{
			get
			{
				if (!_globals.IsInWorld)
				{
					return -1;
				}
				int result;
				try
				{
					result = (int)Read.Single<int>(Offsets.Local_MeshContinentID);
				}
				catch
				{
					result = -1;
				}
				return result;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00672324 File Offset: 0x00670524
		public static string ContinentName
		{
			get
			{
				if (!_globals.IsInWorld)
				{
					return "N/A";
				}
				if (_globals.List_ZonesContinents.ContainsKey(PlayerMe.MeshID))
				{
					return _globals.List_ZonesContinents[PlayerMe.MeshID];
				}
				return "N/A";
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00672364 File Offset: 0x00670564
		public static string ZoneName
		{
			get
			{
				int zoneID = PlayerMe.ZoneID;
				if (PlayerMe.DungeonName.Length > 0)
				{
					return PlayerMe.DungeonName;
				}
				if (PlayerMe.BattlegroundName.Length > 0)
				{
					return PlayerMe.BattlegroundName;
				}
				if (_globals.List_Zones.ContainsKey(zoneID))
				{
					return _globals.List_Zones[zoneID];
				}
				if (PlayerMe.ContinentName.Length <= 0)
				{
					return "N/A";
				}
				return PlayerMe.ContinentName;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x006723D0 File Offset: 0x006705D0
		public static bool IsInDungeon
		{
			get
			{
				using (Dictionary<int, string>.Enumerator enumerator = _globals.List_Dungeons.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, string> keyValuePair = enumerator.Current;
						if (keyValuePair.Key == PlayerMe.ZoneID)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00672434 File Offset: 0x00670634
		public static string DungeonName
		{
			get
			{
				foreach (KeyValuePair<int, string> keyValuePair in _globals.List_Dungeons)
				{
					if (keyValuePair.Key == PlayerMe.ZoneID)
					{
						return keyValuePair.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x006724A4 File Offset: 0x006706A4
		public static bool IsInBattleground
		{
			get
			{
				using (Dictionary<int, string>.Enumerator enumerator = _globals.List_Battlegrounds.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, string> keyValuePair = enumerator.Current;
						if (keyValuePair.Key == PlayerMe.ZoneID)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00672508 File Offset: 0x00670708
		public static string BattlegroundName
		{
			get
			{
				foreach (KeyValuePair<int, string> keyValuePair in _globals.List_Battlegrounds)
				{
					if (keyValuePair.Key == PlayerMe.ZoneID)
					{
						return keyValuePair.Value;
					}
				}
				return "";
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00672578 File Offset: 0x00670778
		public static bool LoadingScreen
		{
			get
			{
				bool result;
				try
				{
					result = ((byte)Read.Single<byte>(Offsets.Local_LoadingScreen) > 0);
				}
				catch
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x006725B0 File Offset: 0x006707B0
		public static float CorpsePositionX
		{
			get
			{
				return (float)Read.Single<float>(Offsets.Local_Corpse);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x006725CC File Offset: 0x006707CC
		public static float CorpsePositionY
		{
			get
			{
				return (float)Read.Single<float>(Offsets.Local_Corpse + 4);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x006725EC File Offset: 0x006707EC
		public static float CorpsePositionZ
		{
			get
			{
				return (float)Read.Single<float>(Offsets.Local_Corpse + 8);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0067260C File Offset: 0x0067080C
		public static Vector2 CorpsePositionVector2
		{
			get
			{
				return new Vector2(PlayerMe.CorpsePositionX, PlayerMe.CorpsePositionY);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00672628 File Offset: 0x00670828
		public static Vector3 CorpsePositionVector3
		{
			get
			{
				return new Vector3(PlayerMe.CorpsePositionX, PlayerMe.CorpsePositionY, PlayerMe.CorpsePositionZ);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0067264C File Offset: 0x0067084C
		public Dictionary<string, string> GetProfessions
		{
			get
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (!_globals.TestEnv["Professions"])
				{
					int professions_SkillLine = Descriptors.Professions_SkillLine;
					int num = 0;
					int num2 = 0;
					IntPtr pointer = this.baseAddress;
					if (!_globals.ObjectManagerRetail)
					{
						pointer = base.DescriptorFields;
					}
					do
					{
						short num3 = (short)Read.Combined<short>(pointer + professions_SkillLine + num);
						if (num3 > 0 && Enum.IsDefined(typeof(Constants.Professions), num3))
						{
							short num4 = (short)Read.Combined<short>(pointer + professions_SkillLine + num2 * Descriptors.Professions_ID + Descriptors.Professions_Rank);
							if (num4 > 0)
							{
								short num5 = (short)Read.Combined<short>(pointer + professions_SkillLine + num2 * Descriptors.Professions_ID + Descriptors.Professions_MaxRank);
								if (num5 > 0)
								{
									string name = Enum.GetName(typeof(Constants.Professions), num3);
									dictionary.Add(name, string.Concat(new string[]
									{
										num3.ToString(),
										";",
										num4.ToString(),
										";",
										num5.ToString()
									}));
								}
							}
						}
						num += 2;
						num2++;
					}
					while (num <= 512);
				}
				return dictionary;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x006727B4 File Offset: 0x006709B4
		public bool CanMount
		{
			get
			{
				return this.HasProfession("Riding");
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x006727CC File Offset: 0x006709CC
		public bool CanFly
		{
			get
			{
				return this.IsInVashjir || Convert.ToBoolean(ObjectManager.Me.ProfessionRank("Riding") > 150);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00672800 File Offset: 0x00670A00
		public bool CanFastFly
		{
			get
			{
				return Convert.ToBoolean(ObjectManager.Me.ProfessionRank("Riding") > 225);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00672828 File Offset: 0x00670A28
		public bool IsInVashjir
		{
			get
			{
				return this.VashjirZoneIDs.Contains(PlayerMe.ZoneID) && base.IsSwimming;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00672850 File Offset: 0x00670A50
		public static bool NeedRepair
		{
			get
			{
				using (List<Items>.Enumerator enumerator = ObjectManager.GetEquippedItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Items items = enumerator.Current;
						if (items.Durability > 0 && items.MaxDurability > 0 && JackMath.CalcToPercent(items.Durability, items.MaxDurability) <= 25)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x006728CC File Offset: 0x00670ACC
		public static bool NeedFood
		{
			get
			{
				int level = ObjectManager.Me.Level;
				int num = -1;
				foreach (KeyValuePair<int, int> keyValuePair in _globals.List_PathfinderFood)
				{
					if (level >= keyValuePair.Value)
					{
						if (num != -1 && keyValuePair.Value != num)
						{
							break;
						}
						num = keyValuePair.Value;
						using (List<Items>.Enumerator enumerator2 = ObjectManager.GetItemsInBags.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.ItemID == keyValuePair.Key && ObjectManager.GetItemAmount(keyValuePair.Key) > 3)
								{
									return false;
								}
							}
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x006729B0 File Offset: 0x00670BB0
		public static bool NeedDrink
		{
			get
			{
				int level = ObjectManager.Me.Level;
				int num = -1;
				foreach (KeyValuePair<int, int> keyValuePair in _globals.List_PathfinderDrink)
				{
					if (level >= keyValuePair.Value)
					{
						if (num != -1)
						{
							if (keyValuePair.Value != num)
							{
								break;
							}
						}
						num = keyValuePair.Value;
						using (List<Items>.Enumerator enumerator2 = ObjectManager.GetItemsInBags.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.ItemID == keyValuePair.Key && ObjectManager.GetItemAmount(keyValuePair.Key) > 3)
								{
									return false;
								}
							}
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00672A9C File Offset: 0x00670C9C
		public static bool NeedArrows
		{
			get
			{
				int level = ObjectManager.Me.Level;
				int num = -1;
				foreach (KeyValuePair<int, int> keyValuePair in _globals.List_PathfinderArrows)
				{
					if (level >= keyValuePair.Value)
					{
						if (num != -1 && keyValuePair.Value != num)
						{
							break;
						}
						num = keyValuePair.Value;
						using (List<Items>.Enumerator enumerator2 = ObjectManager.GetItemsInBags.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.ItemID == keyValuePair.Key)
								{
									if (ObjectManager.GetItemAmount(keyValuePair.Key) > 300)
									{
										return false;
									}
								}
							}
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00672B8C File Offset: 0x00670D8C
		public static bool NeedBullets
		{
			get
			{
				int level = ObjectManager.Me.Level;
				int num = -1;
				foreach (KeyValuePair<int, int> keyValuePair in _globals.List_PathfinderBullets)
				{
					if (level >= keyValuePair.Value)
					{
						if (num != -1)
						{
							if (keyValuePair.Value != num)
							{
								break;
							}
						}
						num = keyValuePair.Value;
						using (List<Items>.Enumerator enumerator2 = ObjectManager.GetItemsInBags.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (enumerator2.Current.ItemID == keyValuePair.Key)
								{
									if (ObjectManager.GetItemAmount(keyValuePair.Key) > 300)
									{
										return false;
									}
								}
							}
						}
					}
				}
				return true;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00672C7C File Offset: 0x00670E7C
		public bool HasProfession(Constants.Professions ProfessionName)
		{
			string name = Enum.GetName(typeof(Constants.Professions), (int)ProfessionName);
			return this.GetProfessions.ContainsKey(name);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00672CB0 File Offset: 0x00670EB0
		public bool HasProfession(string ProfessionName)
		{
			Constants.Professions professions;
			return Enum.TryParse<Constants.Professions>(ProfessionName, out professions) && this.GetProfessions.ContainsKey(ProfessionName);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00672CD8 File Offset: 0x00670ED8
		public short ProfessionRank(Constants.Professions ProfessionName)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetProfessions)
			{
				string[] array = keyValuePair.Value.Split(new char[]
				{
					';'
				});
				if (array.Count<string>() > 1)
				{
					int num = Convert.ToInt32(array[0]);
					short result = Convert.ToInt16(array[1]);
					if (num == (int)ProfessionName)
					{
						return result;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00672D6C File Offset: 0x00670F6C
		public short ProfessionRank(string ProfessionName)
		{
			Constants.Professions professions;
			if (Enum.TryParse<Constants.Professions>(ProfessionName, out professions))
			{
				using (Dictionary<string, string>.Enumerator enumerator = this.GetProfessions.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, string> keyValuePair = enumerator.Current;
						string[] array = keyValuePair.Value.Split(new char[]
						{
							';'
						});
						if (array.Count<string>() > 1)
						{
							int num = Convert.ToInt32(array[0]);
							short result = Convert.ToInt16(array[1]);
							if (num == (int)professions)
							{
								return result;
							}
						}
					}
					return -1;
				}
				short result2;
				return result2;
			}
			return -1;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00672E0C File Offset: 0x0067100C
		public short ProfessionMaxRank(Constants.Professions ProfessionName)
		{
			foreach (KeyValuePair<string, string> keyValuePair in this.GetProfessions)
			{
				string[] array = keyValuePair.Value.Split(new char[]
				{
					';'
				});
				if (array.Count<string>() > 1)
				{
					int num = Convert.ToInt32(array[0]);
					short result = Convert.ToInt16(array[2]);
					if (num == (int)ProfessionName)
					{
						return result;
					}
				}
			}
			return -1;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00672EA0 File Offset: 0x006710A0
		public static string LastErrorMessage
		{
			get
			{
				return (string)Read.Single<string>(Offsets.Local_LastErrorMessage);
			}
		}

		// Token: 0x040000CB RID: 203
		private List<int> VashjirZoneIDs = new List<int>
		{
			4815,
			5144,
			5145
		};
	}
}
