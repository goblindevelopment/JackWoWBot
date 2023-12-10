using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using Jack.ATH;
using Jack.Engine;
using Jack.Forms;
using Jack.Models;
using Newtonsoft.Json;

namespace Jack.Core
{
	// Token: 0x0200011A RID: 282
	internal class Json
	{
		// Token: 0x0600198B RID: 6539 RVA: 0x00729C34 File Offset: 0x00727E34
		public static void SaveProfile(string ProfileName)
		{
			string text = JsonConvert.SerializeObject(frmProfile.RecordedWaypoints.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			text += "|#|";
			text += JsonConvert.SerializeObject(frmProfile.ProfileSettings.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			text += "|#|";
			if (frmProfile.RecordedEvents.Count > 0)
			{
				text += JsonConvert.SerializeObject(frmProfile.RecordedEvents.ToArray(), 1, new JsonSerializerSettings
				{
					NullValueHandling = 1
				});
			}
			File.WriteAllText(_globals.JackProfiles + "\\" + ProfileName + ".json", text);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00729CE4 File Offset: 0x00727EE4
		public static void LoadProfile(string ProfileName, bool CreateAddonContent = false, bool DeleteExecutionIDs = true, bool IsPremium = false)
		{
			if (Json.ProfileIsLoading)
			{
				return;
			}
			Json.ProfileIsLoading = true;
			if (IsPremium)
			{
				if (Tools.IsNumber(ProfileName, 1, 0, 1, 0))
				{
					PFLS profileByID = PFL.GetProfileByID(Convert.ToInt32(ProfileName));
					if (profileByID != null)
					{
						_globals.PremiumMasterProfile = profileByID;
						_globals.PremiumLoadedProfile = profileByID;
						_globals.PremiumLoadedProfileSettings = PremiumSettings.GetProfileByID(profileByID.ID);
						if (_globals.PremiumLoadedProfileSettings != null)
						{
							string displayName = profileByID.DisplayName;
							string profile = profileByID.Profile;
							if (profileByID.IsConnected)
							{
								PFLS closestProfileInConnectedProfiles = PFL.GetClosestProfileInConnectedProfiles();
								if (closestProfileInConnectedProfiles != null)
								{
									_globals.PremiumLoadedProfile = closestProfileInConnectedProfiles;
									_globals.PremiumLoadedProfileSettings = PremiumSettings.GetProfileByID(closestProfileInConnectedProfiles.ID);
									displayName = closestProfileInConnectedProfiles.DisplayName;
									profile = closestProfileInConnectedProfiles.Profile;
								}
							}
							Json.LoadThisProfile(profile, displayName, CreateAddonContent, DeleteExecutionIDs, IsPremium);
						}
						else
						{
							Tools.Console("Couldn't load Premium Profile Settings.", "Red", "richConsole", "frmMain", true);
						}
					}
					else
					{
						Tools.Console("Couldn't find Profile.", "Red", "richConsole", "frmMain", true);
					}
				}
				else if (_globals.PremiumMasterProfile == null)
				{
					Tools.Console("Couldn't find Profile.", "Red", "richConsole", "frmMain", true);
					_globals.Start = false;
				}
				else
				{
					string fileName = Path.GetFileName(ProfileName);
					PFLS pfls = PFL.GetProfileByFileName(fileName, 0);
					if (pfls == null)
					{
						pfls = PFL.GetProfileByDisplayName(fileName);
					}
					if (pfls == null)
					{
						pfls = PFL.GetProfileByID(_globals.PremiumMasterProfile.ID);
					}
					if (pfls == null)
					{
						Tools.Console("Couldn't find Profile.", "Red", "richConsole", "frmMain", true);
						_globals.Start = false;
					}
					else
					{
						Json.LoadThisProfile(pfls.Profile, pfls.DisplayName, CreateAddonContent, DeleteExecutionIDs, IsPremium);
					}
				}
			}
			else
			{
				string path = _globals.JackProfiles + "\\" + ProfileName + ".json";
				if (File.Exists(path))
				{
					Json.LoadThisProfile(File.ReadAllText(path), ProfileName, CreateAddonContent, DeleteExecutionIDs, false);
				}
				else
				{
					Tools.Console("Profile \"" + ProfileName + "\" not found.", "Red", "richConsole", "frmMain", true);
				}
			}
			Json.ProfileIsLoading = false;
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00729ED4 File Offset: 0x007280D4
		private static void LoadThisProfile(string json, string ProfileName, bool CreateAddonContent = false, bool DeleteExecutionIDs = true, bool IsPremium = false)
		{
			if (json.Length <= 0 || !json.Contains("|#|"))
			{
				Tools.Console("Profile \"" + ProfileName + "\" is corrupted.", "Red", "richConsole", "frmMain", true);
				return;
			}
			_globals.Waypoints.Clear();
			object obj = _globals._lockEvents;
			lock (obj)
			{
				_globals.Events.Clear();
			}
			_globals.ProfileSettings.Clear();
			if (DeleteExecutionIDs)
			{
				EventManager.Execution.Clear();
			}
			string[] array = Regex.Split(json, "\\|\\#\\|");
			string text = array[0];
			string text2 = array[1];
			string text3 = array[2];
			if (text.Length > 0 && text2.Length > 0)
			{
				Settings.SelectedProfile = ProfileName;
				obj = ObjectManager._lockOverlay;
				lock (obj)
				{
					_globals.Waypoints = JsonConvert.DeserializeObject<List<Vector3>>(text);
				}
				_globals.ProfileSettings = JsonConvert.DeserializeObject<List<ProfileSettings>>(text2);
				if (text3.Length > 0)
				{
					obj = _globals._lockEvents;
					lock (obj)
					{
						_globals.Events = JsonConvert.DeserializeObject<List<Events>>(text3);
					}
				}
				if (CreateAddonContent)
				{
					Addon.CreateContent();
				}
				_globals.IsPremiumProfile = IsPremium;
				string color = "";
				if (_globals.IsPremiumProfile)
				{
					_globals.ProfileSettings[0].CombatMode = _globals.PremiumLoadedProfileSettings.CombatMode;
					_globals.ProfileSettings[0].WaypointMode = _globals.PremiumLoadedProfileSettings.WaypointMode;
					_globals.ProfileSettings[0].FollowFleeingTarget = _globals.PremiumLoadedProfileSettings.FollowFleeingTarget;
					_globals.ProfileSettings[0].GroundMount = _globals.PremiumLoadedProfileSettings.GroundMount;
					_globals.ProfileSettings[0].FlightMount = _globals.PremiumLoadedProfileSettings.FlightMount;
					_globals.ProfileSettings[0].Mining = _globals.PremiumLoadedProfileSettings.GatherMining;
					_globals.ProfileSettings[0].Herbalism = _globals.PremiumLoadedProfileSettings.GatherHerbalism;
					_globals.ProfileSettings[0].Skinning = _globals.PremiumLoadedProfileSettings.GatherSkinning;
					color = "Purple";
				}
				Monitor.CheckQuestIDs = "";
				Monitor.QuestsCompleted = false;
				Monitor.QuestsEventCompleted = false;
				string getEventQuestIDs = ObjectManager.GetEventQuestIDs;
				if (getEventQuestIDs.Length > 0)
				{
					Monitor.CheckQuestIDs = getEventQuestIDs;
					Tools.Console("Tracking Questprogress...", "", "richConsole", "frmMain", true);
				}
				Tools.Console(string.Concat(new string[]
				{
					"Loaded Profile \"",
					ProfileName,
					"\" with \"",
					_globals.Waypoints.Count.ToString(),
					"\" Waypoints and \"",
					_globals.Events.Count.ToString(),
					"\" Event(s)."
				}), color, "richConsole", "frmMain", true);
				return;
			}
			Tools.Console("Profile \"" + ProfileName + "\" could not be loaded.", "Red", "richConsole", "frmMain", true);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x0072A200 File Offset: 0x00728400
		public static void SaveCurrentProfile(string ProfileName)
		{
			if (!_globals.IsPremiumProfile)
			{
				string text = JsonConvert.SerializeObject(_globals.Waypoints.ToArray(), 1, new JsonSerializerSettings
				{
					NullValueHandling = 1
				});
				text += "|#|";
				text += JsonConvert.SerializeObject(_globals.ProfileSettings.ToArray(), 1, new JsonSerializerSettings
				{
					NullValueHandling = 1
				});
				text += "|#|";
				if (_globals.Events.Count > 0)
				{
					text += JsonConvert.SerializeObject(_globals.Events.ToArray(), 1, new JsonSerializerSettings
					{
						NullValueHandling = 1
					});
				}
				File.WriteAllText(_globals.JackProfiles + "\\" + ProfileName + ".json", text);
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x0072A2BC File Offset: 0x007284BC
		public static void SaveRotation(string ProfileName)
		{
			frmRotation.RecordedRotation = (from Rotation in frmRotation.RecordedRotation
			orderby Rotation.Prio
			select Rotation).ToList<Rotation>();
			string text = JsonConvert.SerializeObject(frmRotation.RecordedRotation.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			text += "|#|";
			text += JsonConvert.SerializeObject(frmRotation.RotationSettings.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			File.WriteAllText(_globals.JackRotations + "\\" + ProfileName + ".json", text);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x0072A364 File Offset: 0x00728564
		public static void LoadRotation(string ProfileName)
		{
			string path = _globals.JackRotations + "\\" + ProfileName + ".json";
			if (!File.Exists(path))
			{
				Tools.Console("Rotation \"" + ProfileName + "\" not found.", "Red", "richConsole", "frmMain", true);
				return;
			}
			string text = File.ReadAllText(path);
			if (text.Length <= 0 || !text.Contains("|#|"))
			{
				Tools.Console("Rotation \"" + ProfileName + "\" is corrupted.", "Red", "richConsole", "frmMain", true);
				return;
			}
			_globals.Rotation.Clear();
			_globals.RotationSettings.Clear();
			string[] array = Regex.Split(text, "\\|\\#\\|");
			string text2 = array[0];
			string text3 = array[1];
			if (text2.Length > 0 && text3.Length > 0)
			{
				Settings.SelectedRotation = ProfileName;
				_globals.Rotation = JsonConvert.DeserializeObject<List<Rotation>>(text2);
				_globals.RotationSettings = JsonConvert.DeserializeObject<List<RotationSettings>>(text3);
				if (_globals.RotationSettings.Count > 0)
				{
					SpellRotation.RotationSettings = _globals.RotationSettings[0];
				}
				Tools.Console(string.Concat(new string[]
				{
					"Loaded Rotation \"",
					ProfileName,
					"\" with \"",
					_globals.Rotation.Count.ToString(),
					"\" Spells."
				}), "", "richConsole", "frmMain", true);
				return;
			}
			Tools.Console("Rotation \"" + ProfileName + "\" could not be loaded.", "Red", "richConsole", "frmMain", true);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x0072A4F0 File Offset: 0x007286F0
		public static void SaveKeybinds()
		{
			if (!Directory.Exists(_globals.JackUtilities))
			{
				Directory.CreateDirectory(_globals.JackUtilities);
			}
			string contents = JsonConvert.SerializeObject(_globals.Keybinds.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			File.WriteAllText(_globals.JackUtilities + "\\Keybinds.json", contents);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x0072A548 File Offset: 0x00728748
		public static void LoadKeybinds()
		{
			string path = _globals.JackUtilities + "\\Keybinds.json";
			bool flag = File.Exists(path);
			string text = "";
			if (flag)
			{
				text = File.ReadAllText(path);
			}
			if (text.Length <= 0)
			{
				if (flag)
				{
					File.Delete(path);
				}
				Initialize.Keybinds();
				Tools.Console("Keybinds were empty. Created a new configuration.", "", "richConsole", "frmMain", true);
				return;
			}
			_globals.Keybinds.Clear();
			_globals.Keybinds = JsonConvert.DeserializeObject<List<Keybinds>>(text);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0072A5C4 File Offset: 0x007287C4
		public static void SaveMessages()
		{
			if (!Directory.Exists(_globals.JackLogs))
			{
				Directory.CreateDirectory(_globals.JackLogs);
			}
			string contents = JsonConvert.SerializeObject(_globals.Messages.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			File.WriteAllText(_globals.JackLogs + "\\Notes.json", contents);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x0072A61C File Offset: 0x0072881C
		public static void LoadMessages()
		{
			string path = _globals.JackLogs + "\\Notes.json";
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				if (text.Length > 0)
				{
					_globals.Messages.Clear();
					_globals.Messages = JsonConvert.DeserializeObject<List<MSG>>(text);
				}
			}
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x0072A668 File Offset: 0x00728868
		public static void SavePremiumSettings()
		{
			if (!Directory.Exists(_globals.JackUtilities))
			{
				Directory.CreateDirectory(_globals.JackUtilities);
			}
			string contents = JsonConvert.SerializeObject(_globals.PremiumSettings.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			File.WriteAllText(_globals.JackUtilities + "\\PRMSettings.json", contents);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x0072A6C0 File Offset: 0x007288C0
		public static void LoadPremiumSettings()
		{
			string path = _globals.JackUtilities + "\\PRMSettings.json";
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				if (text.Length > 0)
				{
					_globals.PremiumSettings.Clear();
					_globals.PremiumSettings = JsonConvert.DeserializeObject<List<PremiumSettings>>(text);
				}
			}
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x0072A70C File Offset: 0x0072890C
		public static void SaveAndReloadPremiumSettings()
		{
			Json.SavePremiumSettings();
			Json.LoadPremiumSettings();
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x0072A724 File Offset: 0x00728924
		public static void SaveStuckPaths()
		{
			if (!Directory.Exists(_globals.JackUtilities))
			{
				Directory.CreateDirectory(_globals.JackUtilities);
			}
			string contents = JsonConvert.SerializeObject(_globals.StuckPaths.ToArray(), 1, new JsonSerializerSettings
			{
				NullValueHandling = 1
			});
			File.WriteAllText(_globals.JackUtilities + "\\StuckPaths.json", contents);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x0072A77C File Offset: 0x0072897C
		public static void LoadStuckPaths()
		{
			string path = _globals.JackUtilities + "\\StuckPaths.json";
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				if (text.Length > 0)
				{
					_globals.StuckPaths.Clear();
					_globals.StuckPaths = JsonConvert.DeserializeObject<List<StuckPaths>>(text);
				}
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0072A7C8 File Offset: 0x007289C8
		public static void SaveAndReloadStuckPaths()
		{
			Json.SaveStuckPaths();
			Json.LoadStuckPaths();
		}

		// Token: 0x04000C8A RID: 3210
		private static bool ProfileIsLoading;
	}
}
