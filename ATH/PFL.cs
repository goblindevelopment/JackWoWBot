using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Jack.Core;
using Jack.Engine;
using Jack.Models;
using Newtonsoft.Json;

namespace Jack.ATH
{
	// Token: 0x0200013B RID: 315
	internal class PFL
	{
		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001D32 RID: 7474 RVA: 0x00732B20 File Offset: 0x00730D20
		public static bool NeedRedownloadProfiles
		{
			get
			{
				if (!File.Exists(PFL.CachedProfilesPath))
				{
					return true;
				}
				if (File.ReadAllText(PFL.CachedProfilesPath).Length != 0)
				{
					try
					{
						string text = Crypt.DecryptString(File.ReadAllText(PFL.CachedProfilesPath), _globals.LCS.d52, _globals.LCS.d53);
						if (text.Length == 0 || !text.Contains("|"))
						{
							return true;
						}
					}
					catch
					{
						return true;
					}
					return _globals.LCS.d11.Length == 0 || _globals.LCS.d11 == "true";
				}
				return true;
			}
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00732BD4 File Offset: 0x00730DD4
		public static void Get(bool ForceDownload = false)
		{
			if (_globals.LCS.d10 != "true")
			{
				return;
			}
			if (_globals.LCS.d12.Length == 0 || !_globals.LCS.d12.Contains(";"))
			{
				return;
			}
			List<int> list = new List<int>();
			foreach (string text in _globals.LCS.d12.Split(new char[]
			{
				';'
			}))
			{
				if (text.Length > 0 && Tools.IsNumber(text, 1, 0, 1, 0))
				{
					list.Add(Convert.ToInt32(text));
				}
			}
			Json.LoadPremiumSettings();
			string text2;
			if (!ForceDownload && !PFL.NeedRedownloadProfiles)
			{
				text2 = File.ReadAllText(PFL.CachedProfilesPath);
			}
			else
			{
				text2 = REQ.Ath("PFL", "");
				File.WriteAllText(PFL.CachedProfilesPath, text2);
			}
			if (text2.Length != 0 && _globals.LCS.d52.Length != 0 && _globals.LCS.d53.Length != 0)
			{
				string text3 = "";
				try
				{
					text3 = Crypt.DecryptString(text2, _globals.LCS.d52, _globals.LCS.d53);
				}
				catch
				{
					return;
				}
				if (text3.Length == 0 || !text3.Contains("|"))
				{
					return;
				}
				_globals.PremiumProfiles.Clear();
				foreach (string text4 in text3.Split(new char[]
				{
					'|'
				}))
				{
					if (text4.Length != 0 && text4.Contains(";"))
					{
						string[] array2 = text4.Split(new char[]
						{
							';'
						});
						int num = Convert.ToInt32(array2[0]);
						int parentProfileID = Convert.ToInt32(array2[1]);
						string text5 = array2[2];
						string displayName = array2[3].Replace(".json", "");
						string fileName = array2[4].Replace(".json", "");
						string base64EncodedData = array2[5];
						bool isClickable = Convert.ToBoolean(array2[6]);
						bool isBundle = Convert.ToBoolean(array2[7]);
						bool isConnected = Convert.ToBoolean(array2[8]);
						string vendorStoreName = array2[9];
						string vendorDiscordUsername = array2[10];
						string vendorEmail = array2[11];
						bool flag = Convert.ToBoolean(array2[12]);
						string text6 = array2[13];
						string text7 = array2[14];
						if (list.Contains(num))
						{
							List<int> list2 = new List<int>();
							if (text5.Length > 0 && text5.Contains(","))
							{
								foreach (string text8 in text5.Split(new char[]
								{
									','
								}))
								{
									if (text8.Length > 0 && Tools.IsNumber(text8, 1, 0, 1, 0))
									{
										list2.Add(Convert.ToInt32(text8));
									}
								}
							}
							string profile = "";
							try
							{
								profile = Crypt.Base64Decode(base64EncodedData);
							}
							catch
							{
								goto IL_3BA;
							}
							int requiredLevel = 0;
							int requiredSkill = 0;
							if (flag)
							{
								if (text6.Length > 0 && Tools.IsNumber(text6, 1, 0, 1, 0))
								{
									requiredLevel = Convert.ToInt32(text6);
								}
								if (text7.Length > 0 && Tools.IsNumber(text7, 1, 0, 1, 0))
								{
									requiredSkill = Convert.ToInt32(text7);
								}
							}
							PFLS pfls = new PFLS();
							pfls.ID = num;
							pfls.ParentProfileID = parentProfileID;
							pfls.ConnectedProfiles = list2;
							pfls.DisplayName = displayName;
							pfls.FileName = fileName;
							pfls.Profile = profile;
							pfls.IsClickable = isClickable;
							pfls.IsBundle = isBundle;
							pfls.IsConnected = isConnected;
							pfls.VendorStoreName = vendorStoreName;
							pfls.VendorDiscordUsername = vendorDiscordUsername;
							pfls.VendorEmail = vendorEmail;
							pfls.HasRequirements = flag;
							pfls.RequiredLevel = requiredLevel;
							pfls.RequiredSkill = requiredSkill;
							_globals.PremiumProfiles.Add(pfls);
						}
					}
					IL_3BA:;
				}
				int count = _globals.PremiumProfiles.Count;
				if (count > 0)
				{
					PFL.ConfigurePremiumSettings();
					Json.SaveAndReloadPremiumSettings();
					Tools.Console("Loaded " + count.ToString() + " Premium Profiles.", "Purple", "richConsole", "frmMain", true);
				}
				return;
			}
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00733010 File Offset: 0x00731210
		private static void ConfigurePremiumSettings()
		{
			foreach (PFLS pfls in _globals.PremiumProfiles)
			{
				bool flag = false;
				PFL.<>c__DisplayClass4_0 CS$<>8__locals1;
				CS$<>8__locals1.Vendor = null;
				CS$<>8__locals1.PRMSettings = null;
				PremiumSettings profileByID = PremiumSettings.GetProfileByID(pfls.ID);
				if (profileByID == null)
				{
					CS$<>8__locals1.PRMSettings = new PremiumSettings();
					CS$<>8__locals1.PRMSettings.ID = pfls.ID;
					CS$<>8__locals1.Vendor = new Dictionary<string, Dictionary<string, object>>();
				}
				else
				{
					CS$<>8__locals1.PRMSettings = profileByID;
					CS$<>8__locals1.Vendor = profileByID.Vendor;
					flag = true;
				}
				if (!CS$<>8__locals1.PRMSettings.HasGeneral)
				{
					if (pfls.Profile.Contains("\"CombatMode\": \""))
					{
						string between = Tools.GetBetween(pfls.Profile, "\"CombatMode\": \"", "\"");
						if (between.Length > 0)
						{
							CS$<>8__locals1.PRMSettings.CombatMode = between;
						}
					}
					if (pfls.Profile.Contains("\"WaypointMode\": \""))
					{
						string between2 = Tools.GetBetween(pfls.Profile, "\"WaypointMode\": \"", "\"");
						if (between2.Length > 0)
						{
							CS$<>8__locals1.PRMSettings.WaypointMode = between2;
						}
					}
					CS$<>8__locals1.PRMSettings.FollowFleeingTarget = pfls.Profile.Contains("\"FollowFleeingTarget\": true");
					CS$<>8__locals1.PRMSettings.GroundMount = pfls.Profile.Contains("\"GroundMount\": true");
					CS$<>8__locals1.PRMSettings.FlightMount = pfls.Profile.Contains("\"FlightMount\": true");
					CS$<>8__locals1.PRMSettings.HasGeneral = true;
				}
				if (!CS$<>8__locals1.PRMSettings.HasGather)
				{
					CS$<>8__locals1.PRMSettings.GatherSkinning = pfls.Profile.Contains("\"Skinning\": true");
					CS$<>8__locals1.PRMSettings.GatherMining = pfls.Profile.Contains("\"Mining\": true");
					CS$<>8__locals1.PRMSettings.GatherHerbalism = pfls.Profile.Contains("\"Herbalism\": true");
					CS$<>8__locals1.PRMSettings.HasGather = (CS$<>8__locals1.PRMSettings.GatherSkinning || CS$<>8__locals1.PRMSettings.GatherMining || CS$<>8__locals1.PRMSettings.GatherHerbalism);
				}
				if (!CS$<>8__locals1.PRMSettings.HasPvP)
				{
					CS$<>8__locals1.PRMSettings.BattlegroundWarsongGulch = pfls.Profile.Contains("\"BattlegroundsClassicWarsongGulch\": true");
					CS$<>8__locals1.PRMSettings.BattlegroundArathiBasin = pfls.Profile.Contains("\"BattlegroundsClassicArathiBasin\": true");
					CS$<>8__locals1.PRMSettings.BattlegroundAlteracValley = pfls.Profile.Contains("\"BattlegroundsClassicAlteracValley\": true");
					CS$<>8__locals1.PRMSettings.BattlegroundEyeOfTheStorm = pfls.Profile.Contains("\"BattlegroundsClassicEyeOfTheStorm\": true");
					CS$<>8__locals1.PRMSettings.HasPvP = (CS$<>8__locals1.PRMSettings.BattlegroundWarsongGulch || CS$<>8__locals1.PRMSettings.BattlegroundArathiBasin || CS$<>8__locals1.PRMSettings.BattlegroundAlteracValley || CS$<>8__locals1.PRMSettings.BattlegroundEyeOfTheStorm);
				}
				if (pfls.IsConnected)
				{
					using (Dictionary<PFLS, List<Events>>.Enumerator enumerator2 = PFL.GetEventsFromConnectedProfiles(pfls).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							KeyValuePair<PFLS, List<Events>> keyValuePair = enumerator2.Current;
							PFL.smethod_0(keyValuePair.Value, ref CS$<>8__locals1);
						}
						goto IL_312;
					}
					goto IL_305;
				}
				goto IL_305;
				IL_312:
				if (!flag)
				{
					_globals.PremiumSettings.Add(CS$<>8__locals1.PRMSettings);
					continue;
				}
				continue;
				IL_305:
				PFL.smethod_0(PFL.GetEventsFromProfile(pfls), ref CS$<>8__locals1);
				goto IL_312;
			}
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00733394 File Offset: 0x00731594
		public static PFLS GetProfileByID(int ID)
		{
			foreach (PFLS pfls in _globals.PremiumProfiles)
			{
				if (pfls.ID == ID)
				{
					return pfls;
				}
			}
			return null;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x007333F4 File Offset: 0x007315F4
		public static PFLS GetProfileByDisplayName(string DisplayName)
		{
			using (List<PFLS>.Enumerator enumerator = _globals.PremiumProfiles.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PFLS pfls = enumerator.Current;
					if (pfls.DisplayName == DisplayName)
					{
						return pfls;
					}
				}
				goto IL_43;
			}
			PFLS result;
			return result;
			IL_43:
			return null;
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00733458 File Offset: 0x00731658
		public static List<PFLS> GetBundleProfiles(PFLS Profile)
		{
			List<PFLS> list = new List<PFLS>();
			foreach (int id in Profile.ConnectedProfiles)
			{
				PFLS profileByID = PFL.GetProfileByID(id);
				if (profileByID != null && Profile.IsClickable)
				{
					list.Add(profileByID);
				}
			}
			return list;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x007334C4 File Offset: 0x007316C4
		public static List<PFLS> GetConnectedProfiles(PFLS Profile)
		{
			List<PFLS> list = new List<PFLS>();
			foreach (int id in Profile.ConnectedProfiles)
			{
				PFLS profileByID = PFL.GetProfileByID(id);
				if (profileByID != null)
				{
					list.Add(profileByID);
				}
			}
			return list;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00733528 File Offset: 0x00731728
		public static bool IsPartOfBundle(PFLS WhichProfile)
		{
			using (List<PFLS>.Enumerator enumerator = _globals.PremiumProfiles.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					PFLS pfls = enumerator.Current;
					if (pfls.IsBundle && pfls.ConnectedProfiles.Contains(WhichProfile.ID))
					{
						return true;
					}
				}
				return false;
			}
			bool result;
			return result;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00733598 File Offset: 0x00731798
		public static PFLS GetProfileByFileName(string ProfileFileName, int ParentID = 0)
		{
			if (ParentID == 0 && _globals.PremiumMasterProfile != null)
			{
				ParentID = _globals.PremiumMasterProfile.ID;
			}
			if (ParentID > 0)
			{
				using (List<PFLS>.Enumerator enumerator = _globals.PremiumProfiles.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PFLS pfls = enumerator.Current;
						if (pfls.FileName == ProfileFileName && pfls.ParentProfileID == ParentID)
						{
							return pfls;
						}
					}
					goto IL_66;
				}
				PFLS result;
				return result;
			}
			IL_66:
			return null;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x0073361C File Offset: 0x0073181C
		public static PFLS GetClosestProfileInConnectedProfiles()
		{
			int num = 0;
			if (_globals.PremiumMasterProfile != null)
			{
				num = _globals.PremiumMasterProfile.ID;
			}
			if (num > 0)
			{
				Dictionary<PFLS, double> dictionary = new Dictionary<PFLS, double>();
				using (List<PFLS>.Enumerator enumerator = _globals.PremiumProfiles.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						PFLS pfls = enumerator.Current;
						if (pfls.ParentProfileID == num)
						{
							if (!_globals.IsInWorld)
							{
								return pfls;
							}
							if (pfls.Profile.Contains("|#|"))
							{
								string text = Regex.Split(pfls.Profile, "\\|\\#\\|")[0];
								if (text.Length > 0)
								{
									List<Vector3> list = JsonConvert.DeserializeObject<List<Vector3>>(text);
									if (list.Count > 0)
									{
										double num2 = 0.0;
										foreach (Vector3 position in list)
										{
											double num3 = JackMath.Distance(position, true, true, true);
											if (num3 > 0.0)
											{
												if (num2 != 0.0)
												{
													if (num3 >= num2)
													{
														continue;
													}
												}
												num2 = num3;
											}
										}
										if (num2 > 0.0)
										{
											dictionary.Add(pfls, num2);
										}
									}
								}
							}
						}
					}
					goto IL_13A;
				}
				PFLS result;
				return result;
				IL_13A:
				if (dictionary.Count > 0)
				{
					double num4 = 0.0;
					PFLS result2 = null;
					foreach (KeyValuePair<PFLS, double> keyValuePair in dictionary)
					{
						if (keyValuePair.Value > 0.0)
						{
							if (num4 != 0.0)
							{
								if (keyValuePair.Value >= num4)
								{
									continue;
								}
							}
							num4 = keyValuePair.Value;
							result2 = keyValuePair.Key;
						}
					}
					return result2;
				}
			}
			return null;
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00733814 File Offset: 0x00731A14
		public static List<Events> GetEventsFromProfile(PFLS Profile)
		{
			List<Events> result = null;
			string[] array = Regex.Split(Profile.Profile, "\\|\\#\\|");
			if (array.Count<string>() > 1)
			{
				string text = array[2];
				if (text.Length > 0)
				{
					result = JsonConvert.DeserializeObject<List<Events>>(text);
				}
			}
			return result;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00733854 File Offset: 0x00731A54
		public static Dictionary<PFLS, List<Events>> GetEventsFromProfileAsList(PFLS Profile)
		{
			Dictionary<PFLS, List<Events>> dictionary = new Dictionary<PFLS, List<Events>>();
			string[] array = Regex.Split(Profile.Profile, "\\|\\#\\|");
			if (array.Count<string>() > 1)
			{
				string text = array[2];
				if (text.Length > 0)
				{
					dictionary.Add(Profile, JsonConvert.DeserializeObject<List<Events>>(text));
				}
			}
			return dictionary;
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0073389C File Offset: 0x00731A9C
		public static Dictionary<PFLS, List<Events>> GetEventsFromConnectedProfiles(PFLS Profile)
		{
			Dictionary<PFLS, List<Events>> dictionary = new Dictionary<PFLS, List<Events>>();
			foreach (PFLS pfls in PFL.GetConnectedProfiles(Profile))
			{
				if (pfls.Profile.Contains("|#|"))
				{
					string[] array = Regex.Split(pfls.Profile, "\\|\\#\\|");
					if (array.Count<string>() > 1)
					{
						string text = array[2];
						if (text.Length > 0)
						{
							List<Events> value = JsonConvert.DeserializeObject<List<Events>>(text);
							dictionary.Add(pfls, value);
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00733964 File Offset: 0x00731B64
		[CompilerGenerated]
		internal static void smethod_0(List<Events> ProfileEvents, ref PFL.<>c__DisplayClass4_0 <>c__DisplayClass4_0_0)
		{
			if (ProfileEvents != null)
			{
				foreach (Events events in ProfileEvents)
				{
					if (EventManager.IsAction(events.Action, "Add Route..."))
					{
						if (events.RouteType == "Mailbox" && !<>c__DisplayClass4_0_0.PRMSettings.HasMailbox)
						{
							<>c__DisplayClass4_0_0.PRMSettings.MailboxReceiver = "";
							<>c__DisplayClass4_0_0.PRMSettings.MailboxSendGreys = events.RecorderMailboxSendGreys;
							<>c__DisplayClass4_0_0.PRMSettings.MailboxSendWhites = events.RecorderMailboxSendWhites;
							<>c__DisplayClass4_0_0.PRMSettings.MailboxSendGreens = events.RecorderMailboxSendGreens;
							<>c__DisplayClass4_0_0.PRMSettings.MailboxSendBlues = events.RecorderMailboxSendBlues;
							<>c__DisplayClass4_0_0.PRMSettings.MailboxSendPurples = events.RecorderMailboxSendPurples;
							<>c__DisplayClass4_0_0.PRMSettings.MailboxSendlist = events.RecorderMailboxSendlist;
							<>c__DisplayClass4_0_0.PRMSettings.HasMailbox = true;
						}
						else if (events.RouteType == "Vendor")
						{
							if (!<>c__DisplayClass4_0_0.Vendor.ContainsKey(events.TargetName))
							{
								Dictionary<string, object> dictionary = new Dictionary<string, object>();
								dictionary.Add("SellGreys", events.VendorSellGreys);
								dictionary.Add("SellWhites", events.VendorSellWhites);
								dictionary.Add("SellGreens", events.VendorSellGreens);
								dictionary.Add("SellBlues", events.VendorSellBlues);
								dictionary.Add("CanRepair", events.VendorCanRepair);
								dictionary.Add("Whitelist", events.VendorWhitelist);
								dictionary.Add("Buylist", events.VendorBuylist);
								<>c__DisplayClass4_0_0.Vendor.Add(events.TargetName, dictionary);
							}
							<>c__DisplayClass4_0_0.PRMSettings.HasVendor = true;
						}
					}
				}
			}
			<>c__DisplayClass4_0_0.PRMSettings.Vendor = <>c__DisplayClass4_0_0.Vendor;
		}

		// Token: 0x04000F86 RID: 3974
		private static string CachedProfilesPath = _globals.JackData + "\\Cache_1.jk";
	}
}
