using System;
using System.Collections.Generic;
using System.Numerics;

namespace Jack.Core
{
	// Token: 0x02000130 RID: 304
	public class PremiumSettings
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0072D8DC File Offset: 0x0072BADC
		// (set) Token: 0x06001B29 RID: 6953 RVA: 0x0072D8F0 File Offset: 0x0072BAF0
		public int ID { get; set; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001B2A RID: 6954 RVA: 0x0072D904 File Offset: 0x0072BB04
		// (set) Token: 0x06001B2B RID: 6955 RVA: 0x0072D918 File Offset: 0x0072BB18
		public bool HasGeneral { get; set; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0072D92C File Offset: 0x0072BB2C
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0072D940 File Offset: 0x0072BB40
		public bool HasMailbox { get; set; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0072D954 File Offset: 0x0072BB54
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0072D968 File Offset: 0x0072BB68
		public bool HasVendor { get; set; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0072D97C File Offset: 0x0072BB7C
		// (set) Token: 0x06001B31 RID: 6961 RVA: 0x0072D990 File Offset: 0x0072BB90
		public bool HasGather { get; set; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0072D9A4 File Offset: 0x0072BBA4
		// (set) Token: 0x06001B33 RID: 6963 RVA: 0x0072D9B8 File Offset: 0x0072BBB8
		public string CombatMode { get; set; } = "Defensive";

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0072D9CC File Offset: 0x0072BBCC
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0072D9E0 File Offset: 0x0072BBE0
		public string WaypointMode { get; set; } = "Best";

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0072D9F4 File Offset: 0x0072BBF4
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0072DA08 File Offset: 0x0072BC08
		public bool FollowFleeingTarget { get; set; }

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0072DA1C File Offset: 0x0072BC1C
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0072DA30 File Offset: 0x0072BC30
		public bool GroundMount { get; set; }

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001B3A RID: 6970 RVA: 0x0072DA44 File Offset: 0x0072BC44
		// (set) Token: 0x06001B3B RID: 6971 RVA: 0x0072DA58 File Offset: 0x0072BC58
		public bool FlightMount { get; set; }

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0072DA6C File Offset: 0x0072BC6C
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0072DA80 File Offset: 0x0072BC80
		public string MailboxReceiver { get; set; } = "";

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0072DA94 File Offset: 0x0072BC94
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0072DAA8 File Offset: 0x0072BCA8
		public bool MailboxSendGreys { get; set; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0072DABC File Offset: 0x0072BCBC
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0072DAD0 File Offset: 0x0072BCD0
		public bool MailboxSendWhites { get; set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0072DAE4 File Offset: 0x0072BCE4
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0072DAF8 File Offset: 0x0072BCF8
		public bool MailboxSendGreens { get; set; }

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0072DB0C File Offset: 0x0072BD0C
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x0072DB20 File Offset: 0x0072BD20
		public bool MailboxSendBlues { get; set; }

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0072DB34 File Offset: 0x0072BD34
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x0072DB48 File Offset: 0x0072BD48
		public bool MailboxSendPurples { get; set; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0072DB5C File Offset: 0x0072BD5C
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0072DB70 File Offset: 0x0072BD70
		public List<string> MailboxSendlist { get; set; } = new List<string>();

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0072DB84 File Offset: 0x0072BD84
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x0072DB98 File Offset: 0x0072BD98
		public bool BattlegroundWarsongGulch { get; set; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x0072DBAC File Offset: 0x0072BDAC
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x0072DBC0 File Offset: 0x0072BDC0
		public bool BattlegroundArathiBasin { get; set; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x0072DBD4 File Offset: 0x0072BDD4
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x0072DBE8 File Offset: 0x0072BDE8
		public bool BattlegroundAlteracValley { get; set; }

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x0072DBFC File Offset: 0x0072BDFC
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x0072DC10 File Offset: 0x0072BE10
		public bool BattlegroundEyeOfTheStorm { get; set; }

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0072DC24 File Offset: 0x0072BE24
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0072DC38 File Offset: 0x0072BE38
		public bool BattlegroundStrandOfTheAncients { get; set; }

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001B54 RID: 6996 RVA: 0x0072DC4C File Offset: 0x0072BE4C
		// (set) Token: 0x06001B55 RID: 6997 RVA: 0x0072DC60 File Offset: 0x0072BE60
		public bool HasPvP { get; set; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0072DC74 File Offset: 0x0072BE74
		// (set) Token: 0x06001B57 RID: 6999 RVA: 0x0072DC88 File Offset: 0x0072BE88
		public bool GatherMining { get; set; }

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0072DC9C File Offset: 0x0072BE9C
		// (set) Token: 0x06001B59 RID: 7001 RVA: 0x0072DCB0 File Offset: 0x0072BEB0
		public bool GatherHerbalism { get; set; }

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0072DCC4 File Offset: 0x0072BEC4
		// (set) Token: 0x06001B5B RID: 7003 RVA: 0x0072DCD8 File Offset: 0x0072BED8
		public bool GatherSkinning { get; set; }

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0072DCEC File Offset: 0x0072BEEC
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x0072DD00 File Offset: 0x0072BF00
		public Dictionary<string, Vector3> Blacklist { get; set; } = new Dictionary<string, Vector3>();

		// Token: 0x06001B61 RID: 7009 RVA: 0x0072DD14 File Offset: 0x0072BF14
		public static PremiumSettings GetProfileByID(int ID)
		{
			if (_globals.PremiumSettings.Count > 0)
			{
				using (List<PremiumSettings>.Enumerator enumerator = _globals.PremiumSettings.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PremiumSettings premiumSettings = enumerator.Current;
						if (premiumSettings.ID == ID)
						{
							return premiumSettings;
						}
					}
					goto IL_4D;
				}
				PremiumSettings result;
				return result;
			}
			IL_4D:
			return null;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0072DD80 File Offset: 0x0072BF80
		public static bool ProfileExists(int ID)
		{
			if (_globals.PremiumSettings.Count > 0)
			{
				using (List<PremiumSettings>.Enumerator enumerator = _globals.PremiumSettings.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.ID == ID)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
			return false;
		}

		// Token: 0x04000F3B RID: 3899
		public Dictionary<string, Dictionary<string, object>> Vendor = new Dictionary<string, Dictionary<string, object>>();
	}
}
