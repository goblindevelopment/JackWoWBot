using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Jack.ATH;
using Jack.Engine;
using Jack.Forms;
using Jack.Models;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;

namespace Jack.Core
{
	// Token: 0x020000F8 RID: 248
	internal class Addon
	{
		// Token: 0x060016C7 RID: 5831 RVA: 0x007186D8 File Offset: 0x007168D8
		public static void CheckOnStart()
		{
			if (Settings.GameFolder.Length == 0)
			{
				if (MessageBox.Show("Jack hasn't discovered any WoW folder yet.\r\nWould you like to add it now?", Tools.RandomString(15, false), MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
				{
					MessageBox.Show("You can install the addon at a later time. Do not forget that the addon is required.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					Addon.Install("JK", false);
					if (Settings.GameFolder.Length > 0)
					{
						Tools.Control(Settings.GameFolder, "txtAddonInstallationFolder", "frmMainAddon", true, false, false, false, 0);
						return;
					}
				}
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00718754 File Offset: 0x00716954
		public static void Install(string OldAddonName = "JK", bool DeletePreviousDownloadedAddon = false)
		{
			if (Settings.GameFolder.Length == 0)
			{
				Addon.SelectWoWFolder();
			}
			Tools.Control("Installing...", "btnAddonInstall", "frmMainAddon", false, false, false, false, 0);
			Tools.Control("Renaming...", "btnAddonRename", "frmMainAddon", false, false, false, false, 0);
			Tools.Control("", "txtAddonName", "frmMainAddon", false, false, false, false, 0);
			if (Settings.GameFolder.Length > 0)
			{
				if (DeletePreviousDownloadedAddon)
				{
					if (Directory.Exists(_globals.JackDownloads + "\\Addons"))
					{
						Directory.Delete(_globals.JackDownloads + "\\Addons", true);
					}
					if (File.Exists(_globals.JackDownloads + "\\Addons.zip"))
					{
						File.Delete(_globals.JackDownloads + "\\Addons.zip");
					}
				}
				if (!Addon.ManageAddons(OldAddonName))
				{
					MessageBox.Show("Couldn't create Addon.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					Settings.AddonVersion = _globals.LatestAddonVersion;
					Settings.Save();
					Addon.ResetSettingsControls();
					frmMainKeybinds.ApplyKeybinds(true);
					MessageBox.Show("Addon Installation complete.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Tools.Control(Settings.GameFolder, "txtAddonInstallationFolder", "frmMainAddon", true, false, false, false, 0);
				}
			}
			Tools.Control("Install", "btnAddonInstall", "frmMainAddon", true, false, false, false, 0);
			Tools.Control("Rename", "btnAddonRename", "frmMainAddon", true, false, false, false, 0);
			Tools.Control("", "txtAddonName", "frmMainAddon", true, false, false, false, 0);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x007188DC File Offset: 0x00716ADC
		public static bool ManageAddons(string OldAddonName = "JK")
		{
			bool result = true;
			if (Settings.AddonVersion != _globals.LatestAddonVersion || !Directory.Exists(_globals.JackDownloads + "\\Addons"))
			{
				Addon.DownloadAndExtractAddons();
			}
			if (Settings.AddonName.Length == 0)
			{
				Settings.AddonName = "JK";
				Settings.Save();
			}
			if (Directory.Exists(Settings.GameFolder + Addon.ClassicGameFolder))
			{
				string gameAddonFolderPath = Settings.GameFolder + Addon.ClassicGameFolder;
				try
				{
					Addon.CreateAndEdit("_classic_", gameAddonFolderPath, OldAddonName);
				}
				catch
				{
					result = false;
				}
			}
			if (Directory.Exists(Settings.GameFolder + Addon.ClassicEraGameFolder))
			{
				string gameAddonFolderPath2 = Settings.GameFolder + Addon.ClassicEraGameFolder;
				try
				{
					Addon.CreateAndEdit("_classic_era_", gameAddonFolderPath2, OldAddonName);
				}
				catch
				{
					result = false;
				}
			}
			if (Directory.Exists(Settings.GameFolder + Addon.RetailGameFolder))
			{
				string gameAddonFolderPath3 = Settings.GameFolder + Addon.RetailGameFolder;
				try
				{
					Addon.CreateAndEdit("_retail_", gameAddonFolderPath3, OldAddonName);
				}
				catch
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00718A08 File Offset: 0x00716C08
		private static void CreateAndEdit(string JackAddonFolderName, string GameAddonFolderPath, string OldAddonName)
		{
			string addonName = Settings.AddonName;
			if (Directory.Exists(GameAddonFolderPath + "\\JK"))
			{
				Directory.Delete(GameAddonFolderPath + "\\JK", true);
			}
			if (OldAddonName != "JK" && Directory.Exists(GameAddonFolderPath + "\\" + OldAddonName))
			{
				Directory.Delete(GameAddonFolderPath + "\\" + OldAddonName, true);
			}
			GameAddonFolderPath = GameAddonFolderPath + "\\" + Settings.AddonName;
			if (Directory.Exists(GameAddonFolderPath))
			{
				Directory.Delete(GameAddonFolderPath, true);
			}
			Directory.CreateDirectory(GameAddonFolderPath);
			Tools.CopyDirectory(_globals.JackDownloads + "\\Addons\\" + JackAddonFolderName, GameAddonFolderPath);
			if (addonName.Length > 0 && File.Exists(GameAddonFolderPath + "\\JK.toc") && File.Exists(GameAddonFolderPath + "\\JK.lua"))
			{
				string filePath = GameAddonFolderPath + "\\JK.toc";
				string filePath2 = GameAddonFolderPath + "\\JK.lua";
				Tools.ReplaceInFile(filePath, "## Title: JK", "## Title: " + addonName, true);
				Tools.ReplaceInFile(filePath, "## Author: JK", "## Author: " + addonName, true);
				Tools.ReplaceInFile(filePath, "## SavedVariables: JKCDB", "## SavedVariables: " + addonName + "CDB", true);
				Tools.ReplaceInFile(filePath, "## SavedVariablesPerCharacter: JKDB", "## SavedVariablesPerCharacter: " + addonName + "DB", true);
				Tools.ReplaceInFile(filePath, "JK.lua", addonName + ".lua", true);
				Tools.ReplaceInFile(filePath2, "__ADDON_NAME__=\"JK\"", "__ADDON_NAME__ =\"" + addonName + "\"", false);
				Tools.ReplaceInFile(filePath2, "JKCDB", addonName + "CDB", false);
				Tools.ReplaceInFile(filePath2, "JKDB", addonName + "DB", false);
				Thread.Sleep(500);
				if (GameAddonFolderPath + "\\JK.lua" != GameAddonFolderPath + "\\" + addonName + ".lua")
				{
					File.Move(GameAddonFolderPath + "\\JK.lua", GameAddonFolderPath + "\\" + addonName + ".lua");
					File.Move(GameAddonFolderPath + "\\JK.toc", GameAddonFolderPath + "\\" + addonName + ".toc");
				}
				DirectoryInfo parent = Directory.GetParent(GameAddonFolderPath);
				if (GameAddonFolderPath != parent.FullName + "\\" + addonName)
				{
					Directory.Move(GameAddonFolderPath, parent.FullName + "\\" + addonName);
				}
			}
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00718C70 File Offset: 0x00716E70
		private static void DownloadAndExtractAddons()
		{
			if (Directory.Exists(_globals.JackDownloads))
			{
				bool flag = false;
				if (File.Exists(_globals.JackDownloads + "\\Addons.zip"))
				{
					File.Delete(_globals.JackDownloads + "\\Addons.zip");
					flag = true;
				}
				if (Directory.Exists(_globals.JackDownloads + "\\Addons"))
				{
					Directory.Delete(_globals.JackDownloads + "\\Addons", true);
					flag = true;
				}
				if (flag)
				{
					Thread.Sleep(1000);
				}
			}
			object[] args = new object[]
			{
				"Addons"
			};
			Tools.OpenForm("frmDownload", true, "frmMain", args);
			while (!Tools.IsFileReady(_globals.JackDownloads + "\\Addons.zip", true))
			{
				Thread.Sleep(10);
			}
			Initialize.ExtractFiles(new List<string[]>
			{
				new string[]
				{
					_globals.JackDownloads + "\\Addons.zip",
					_globals.JackDownloads + "\\Addons\\",
					_globals.JackDownloads + "\\Addons\\_classic_\\JK.toc"
				}
			});
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00718D80 File Offset: 0x00716F80
		public static void SelectWoWFolder()
		{
			CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
			commonOpenFileDialog.Title = "Select your WoW Folder";
			commonOpenFileDialog.InitialDirectory = Addon.InitialDirectory;
			commonOpenFileDialog.IsFolderPicker = true;
			if (commonOpenFileDialog.ShowDialog() == 1)
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				string fileName = commonOpenFileDialog.FileName;
				if (Directory.Exists(fileName + Addon.ClassicGameFolder))
				{
					flag = true;
				}
				if (Directory.Exists(fileName + Addon.ClassicEraGameFolder))
				{
					flag2 = true;
				}
				if (Directory.Exists(fileName + Addon.RetailGameFolder))
				{
					flag3 = true;
				}
				if (flag || flag2 || flag3)
				{
					Settings.GameFolder = fileName;
					Settings.Save();
					Tools.Control(Settings.GameFolder, "txtAddonInstallationFolder", "frmMainAddon", true, false, false, false, 0);
					return;
				}
				MessageBox.Show("This folder contains no WoW installation.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00718E50 File Offset: 0x00717050
		private static string InitialDirectory
		{
			get
			{
				if (IntPtr.Size != 8 && string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
				{
					return Environment.GetEnvironmentVariable("ProgramFiles");
				}
				return Environment.GetEnvironmentVariable("ProgramFiles(x86)");
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00718E8C File Offset: 0x0071708C
		public static bool ChangeSettings(string[] Categories, string Value)
		{
			string text = "__SETTINGS__";
			string text2 = text;
			foreach (string str in Categories)
			{
				text = text + "[\"" + str + "\"]";
				text2 = text2 + "[\"" + str + "\"]";
			}
			text2 = text2 + " = " + Value;
			bool flag = Tools.ReplaceInFile(string.Concat(new string[]
			{
				Settings.GameFolder,
				Addon.ClassicGameFolder,
				"\\",
				Settings.AddonName,
				"\\Settings.lua"
			}), text, text2, true);
			bool flag2 = Tools.ReplaceInFile(string.Concat(new string[]
			{
				Settings.GameFolder,
				Addon.ClassicEraGameFolder,
				"\\",
				Settings.AddonName,
				"\\Settings.lua"
			}), text, text2, true);
			bool flag3 = Tools.ReplaceInFile(string.Concat(new string[]
			{
				Settings.GameFolder,
				Addon.RetailGameFolder,
				"\\",
				Settings.AddonName,
				"\\Settings.lua"
			}), text, text2, true);
			return flag || flag2 || flag3;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00718FB4 File Offset: 0x007171B4
		private static void ResetSettingsControls()
		{
			Tools.Control("", "checkAddonOptionsAutoEquipWhite", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoEquipGreen", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoEquipBlue", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoEquipPurple", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoEquipBags", "frmMainAddon", true, false, false, false, 2);
			Settings.AddonAutoEquipWhite = false;
			Settings.AddonAutoEquipGreen = false;
			Settings.AddonAutoEquipBlue = false;
			Settings.AddonAutoEquipPurple = false;
			Settings.AddonAutoEquipBags = false;
			Tools.Control("", "checkAddonOptionsAutoDestroyGreys", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoDestroyWhites", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoDestroyGreens", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoDestroyBlues", "frmMainAddon", true, false, false, false, 2);
			Tools.Control("", "checkAddonOptionsAutoDestroyBOE", "frmMainAddon", true, false, false, false, 2);
			Settings.AddonAutoDestroyGreys = false;
			Settings.AddonAutoDestroyWhites = false;
			Settings.AddonAutoDestroyGreens = false;
			Settings.AddonAutoDestroyBlues = false;
			Settings.AddonAutoDestroyBOE = false;
			Settings.Save();
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x007190FC File Offset: 0x007172FC
		public static void ChangeKeybinds(string KeybindsTemplate)
		{
			Addon.<>c__DisplayClass14_0 CS$<>8__locals1 = new Addon.<>c__DisplayClass14_0();
			CS$<>8__locals1.KeybindsTemplate = KeybindsTemplate;
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00719134 File Offset: 0x00717334
		public static Dictionary<string, List<Events>> GetConnectedProfilesAndEvents()
		{
			List<string> list = new List<string>();
			Dictionary<string, List<Events>> dictionary = new Dictionary<string, List<Events>>();
			if (_globals.Events.Count > 0)
			{
				if (_globals.IsPremiumProfile)
				{
					if (_globals.PremiumMasterProfile == null)
					{
						return dictionary;
					}
					Dictionary<PFLS, List<Events>> dictionary2 = new Dictionary<PFLS, List<Events>>();
					if (_globals.PremiumMasterProfile.IsConnected)
					{
						dictionary2 = PFL.GetEventsFromConnectedProfiles(_globals.PremiumMasterProfile);
					}
					else
					{
						dictionary2 = PFL.GetEventsFromProfileAsList(_globals.PremiumMasterProfile);
					}
					using (Dictionary<PFLS, List<Events>>.Enumerator enumerator = dictionary2.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<PFLS, List<Events>> keyValuePair = enumerator.Current;
							PFLS key = keyValuePair.Key;
							List<Events> value = keyValuePair.Value;
							PremiumSettings profileByID = PremiumSettings.GetProfileByID(key.ID);
							if (profileByID != null)
							{
								foreach (Events events in value)
								{
									if (EventManager.IsAction(events.Action, "Add Route..."))
									{
										if (events.RouteType == "Mailbox")
										{
											if (profileByID.HasMailbox && profileByID.MailboxReceiver.Length > 0)
											{
												events.RecorderMailboxReceiver = profileByID.MailboxReceiver;
												events.RecorderMailboxSendGreys = profileByID.MailboxSendGreys;
												events.RecorderMailboxSendWhites = profileByID.MailboxSendWhites;
												events.RecorderMailboxSendGreens = profileByID.MailboxSendGreens;
												events.RecorderMailboxSendBlues = profileByID.MailboxSendBlues;
												events.RecorderMailboxSendPurples = profileByID.MailboxSendPurples;
												events.RecorderMailboxSendlist = profileByID.MailboxSendlist;
											}
										}
										else if (events.RouteType == "Vendor" && profileByID.HasVendor && profileByID.Vendor.ContainsKey(events.TargetName))
										{
											Dictionary<string, object> dictionary3 = profileByID.Vendor[events.TargetName];
											events.VendorSellGreys = (bool)dictionary3["SellGreys"];
											events.VendorSellWhites = (bool)dictionary3["SellWhites"];
											events.VendorSellGreens = (bool)dictionary3["SellGreens"];
											events.VendorSellBlues = (bool)dictionary3["SellBlues"];
											events.VendorWhitelist = JsonConvert.DeserializeObject<List<string>>(dictionary3["Whitelist"].ToString());
											events.VendorBuylist = JsonConvert.DeserializeObject<List<string>>(dictionary3["Buylist"].ToString());
										}
									}
								}
							}
							string displayName = key.DisplayName;
							if (!dictionary.ContainsKey(displayName))
							{
								dictionary.Add(displayName, value);
							}
						}
						return dictionary;
					}
				}
				list.Add(Settings.SelectedProfile);
				int num = 0;
				for (;;)
				{
					bool flag = false;
					string text = list[num];
					string path = _globals.JackProfiles + "\\" + text + ".json";
					if (File.Exists(path))
					{
						string text2 = File.ReadAllText(path);
						if (text2.Contains("|#|"))
						{
							string text3 = Regex.Split(text2, "\\|\\#\\|")[2];
							if (text3.Length > 0)
							{
								List<Events> list2 = JsonConvert.DeserializeObject<List<Events>>(text3);
								if (list2.Count > 0)
								{
									int count = list.Count;
									foreach (Events events2 in list2)
									{
										if (events2.LoadProfile.Length > 0 && !list.Contains(events2.LoadProfile))
										{
											list.Add(events2.LoadProfile);
										}
										if (events2.FlightPointProfile.Length > 0 && !list.Contains(events2.FlightPointProfile))
										{
											list.Add(events2.FlightPointProfile);
										}
										if (events2.UseHearthstoneProfile.Length > 0 && !list.Contains(events2.UseHearthstoneProfile))
										{
											list.Add(events2.UseHearthstoneProfile);
										}
									}
									if (!dictionary.ContainsKey(text))
									{
										dictionary.Add(text, list2);
									}
									if (list.Count > count)
									{
										flag = true;
									}
								}
							}
						}
					}
					if (num < list.Count - 1)
					{
						flag = true;
					}
					if (!flag)
					{
						break;
					}
					num++;
				}
			}
			return dictionary;
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x007195C4 File Offset: 0x007177C4
		public static void CreateContent()
		{
			new Thread(new ThreadStart(Addon.smethod_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x007195F0 File Offset: 0x007177F0
		private static void WaitForImport()
		{
			while (!_globals.Ready)
			{
				Thread.Sleep(100);
			}
			while (_globals.ProcessFolder.Length == 0)
			{
				Thread.Sleep(100);
			}
			Addon.Import();
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00719628 File Offset: 0x00717828
		private static void Import()
		{
			if (_globals.GameOpen && _globals.ProcessFolder.Length > 0)
			{
				string path = _globals.ProcessFolder + "\\Interface\\AddOns\\" + Settings.AddonName + "\\Import.lua";
				if (File.Exists(path))
				{
					string str = Settings.SelectedProfile.Replace("\\", "/");
					if (Addon.ImportContent.Contains("[\"NPC\"]") || Addon.ImportContent.Contains("[\"MAILBOX\"]"))
					{
						try
						{
							string str2 = "__LOAD_PROFILE_AFTER_RELOAD__ = \"" + str + "\"\r\n\r\n";
							string a = File.ReadAllText(path);
							Addon.ImportContent = str2 + Addon.ImportContent;
							if (a != Addon.ImportContent)
							{
								File.WriteAllText(path, Addon.ImportContent);
								Thread.Sleep(250);
								Addon.Reload(true);
							}
						}
						catch
						{
						}
					}
				}
			}
			Addon.WaitingForImport = false;
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00719718 File Offset: 0x00717918
		public static void Reload(bool InBackground = true)
		{
			if (_globals.Ready)
			{
				if (InBackground)
				{
					new Thread(new ThreadStart(Addon.smethod_1))
					{
						IsBackground = true
					}.Start();
					return;
				}
				Addon.smethod_1();
			}
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00719754 File Offset: 0x00717954
		public static void LUA(string Command, string Delay = "0", bool ShowResultMessageInAddon = false, bool InBackground = true)
		{
			string text = "0";
			if (ShowResultMessageInAddon)
			{
				text = "1";
			}
			Command = Command.Replace("\t", "").Replace("  ", "").Trim();
			foreach (string oldValue in new string[]
			{
				"\r\n",
				"\r",
				"\n"
			})
			{
				Command = Command.Replace(oldValue, "#");
			}
			int delayInMS;
			if (!Delay.Contains("."))
			{
				delayInMS = Convert.ToInt32(Delay) * 100;
			}
			else
			{
				string[] array2 = Delay.Split(new char[]
				{
					'.'
				});
				int num = 0;
				if (Tools.IsNumber(array2[0], 1, 0, 1, 0))
				{
					num = Convert.ToInt32(array2[0]) * 1000;
				}
				int num2 = 0;
				if (Tools.IsNumber(array2[1], 1, 0, 1, 0))
				{
					num2 = Convert.ToInt32(array2[1]) * 100;
				}
				delayInMS = num + num2;
			}
			Addon.LUAAction(string.Concat(new string[]
			{
				Delay,
				":",
				text,
				":",
				Command
			}), delayInMS, InBackground);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0071987C File Offset: 0x00717A7C
		public static void LUAAction(string Command, int DelayInMS, bool InBackground = true)
		{
			Addon.<>c__DisplayClass23_0 CS$<>8__locals1 = new Addon.<>c__DisplayClass23_0();
			CS$<>8__locals1.Command = Command;
			CS$<>8__locals1.DelayInMS = DelayInMS;
			if (!_globals.Ready)
			{
				return;
			}
			if (!InBackground)
			{
				CS$<>8__locals1.method_0();
				return;
			}
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x007198CC File Offset: 0x00717ACC
		public static string LUAAwaitingResult(string Command, bool WaitWhileJackIsRunning = true, int WaitTimer = 2000)
		{
			string text = "jkAwait";
			string text2 = "";
			Addon.LUA(Command, "0", false, false);
			string name = Tools.RandomTimer("LUAAwait");
			Jack.Engine.Timer.Set(name, WaitTimer);
			while (text2.Length == 0 && Jack.Engine.Timer.Check(name) != 0 && (!WaitWhileJackIsRunning || _globals.Start))
			{
				text2 = Frames.GetText(text, text + "Text");
				Thread.Sleep(250);
			}
			if (text2.Length > 0)
			{
				Frames.ResetText(text);
			}
			return text2;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x0071994C File Offset: 0x00717B4C
		public static List<string> LUASync(string FrameName = "", string Mode = "", string StartAt = "", List<string> Result = null)
		{
			if (StartAt.Length == 0)
			{
				Result = new List<string>();
				Tools.Console("Syncing " + Mode + "...", "", "richConsole", "frmMain", true);
			}
			Addon.LUA(string.Concat(new string[]
			{
				"_sync(\"",
				StartAt,
				"\", \"",
				FrameName,
				"\", \"",
				Mode,
				"\")"
			}), "0", false, false);
			string text = "";
			string name = Tools.RandomTimer("LUAAwait");
			Jack.Engine.Timer.Set(name, 2000);
			while (text.Length == 0 && Jack.Engine.Timer.Check(name) != 0)
			{
				text = Frames.GetText(FrameName, FrameName + "Text");
				Thread.Sleep(250);
			}
			if (text.Length > 0 && text.Contains("/"))
			{
				foreach (string text2 in text.Split(new char[]
				{
					'/'
				}))
				{
					if (text2.Length != 0)
					{
						Result.Add(text2);
					}
				}
				Frames.ResetText(FrameName);
				if (text.Contains("#next#") && Result.Count > 0)
				{
					Addon.LUASync(FrameName, Mode, Result.LastOrDefault<string>(), Result);
				}
			}
			if (StartAt.Length == 0)
			{
				Tools.Console(string.Concat(new string[]
				{
					"Syncing ",
					Mode,
					" complete. ",
					Result.Count.ToString(),
					" results found."
				}), "Green", "richConsole", "frmMain", true);
			}
			return Result;
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00719AE8 File Offset: 0x00717CE8
		public static void AutoDestroy()
		{
			if ((Settings.AddonAutoDestroyGreys || Settings.AddonAutoDestroyWhites || Settings.AddonAutoDestroyGreens || Settings.AddonAutoDestroyBlues || Settings.AddonAutoDestroyJunklist.Count > 0) && !Addon.AutoDestroyDelay)
			{
				Addon.AutoDestroyDelay = true;
				Tools.Console("Auto Destroy...", "", "richConsole", "frmMain", true);
				Addon.LUA("/run _autoDestroy()", "0", false, true);
				new Thread(new ThreadStart(Addon.smethod_2))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00719B74 File Offset: 0x00717D74
		public static bool IsReady(bool CheckInstallation, bool CheckActivated, bool CheckEnabled, bool OnStartClick = false)
		{
			if (CheckInstallation && !Addon.IsInstalled)
			{
				string title = "Jack's Addon";
				string text = "Couldn't find Jack's Addon installation.";
				Tools.CustomMessageBox(title, text, "Addon Manager", "Continue", "frmProfile", true);
				if (!frmMessageBox.Button1Pressed)
				{
					return frmMessageBox.Button2Pressed && OnStartClick;
				}
				Tools.InvokeMethod("frmMain", "LoadFormToPanelExtern", new object[]
				{
					"radioMenuAddon"
				}, false);
				return false;
			}
			else
			{
				if (CheckActivated && !Addon.IsActivated)
				{
					Frames.GetAllFrames("jkReady");
					string title2 = "Jack's Addon";
					string text2 = "Jack's Addon is installed but not activated.\r\n";
					text2 += "Press in-game \"ESC\" and click on \"Addons\".";
					Tools.CustomMessageBox(title2, text2, "Cancel", "Continue", "frmProfile", true);
					return frmMessageBox.Button2Pressed && OnStartClick;
				}
				if (CheckEnabled && !Addon.IsEnabled)
				{
					Addon.LUA("_enableAddon(true)", "0", false, true);
					Tools.Console("Addon enabled.", "", "richConsole", "frmMain", true);
				}
				return true;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00719C64 File Offset: 0x00717E64
		public static bool IsInstalled
		{
			get
			{
				if (Settings.GameFolder.Length == 0 || Settings.AddonName.Length == 0)
				{
					return false;
				}
				if (_globals.GameOpen)
				{
					return File.Exists(_globals.ProcessFolder + "\\Interface\\AddOns\\" + Settings.AddonName + "\\Settings.lua");
				}
				string path = string.Concat(new string[]
				{
					Settings.GameFolder,
					Addon.ClassicGameFolder,
					"\\",
					Settings.AddonName,
					"\\Settings.lua"
				});
				string path2 = string.Concat(new string[]
				{
					Settings.GameFolder,
					Addon.ClassicEraGameFolder,
					"\\",
					Settings.AddonName,
					"\\Settings.lua"
				});
				string path3 = string.Concat(new string[]
				{
					Settings.GameFolder,
					Addon.RetailGameFolder,
					"\\",
					Settings.AddonName,
					"\\Settings.lua"
				});
				return File.Exists(path) || File.Exists(path2) || File.Exists(path3);
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x00719D70 File Offset: 0x00717F70
		public static bool IsActivated
		{
			get
			{
				Frames.GetAllFrames("jkReady");
				return Frames.ParentFrames.Count == 1;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00719D94 File Offset: 0x00717F94
		public static bool IsEnabled
		{
			get
			{
				return Frames.GetText("jkReady", "").ToLower() == "true";
			}
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00719E0C File Offset: 0x0071800C
		[CompilerGenerated]
		internal static void smethod_0()
		{
			string text = "__PFLS__ = {}\r\n";
			Dictionary<string, List<Events>> connectedProfilesAndEvents = Addon.GetConnectedProfilesAndEvents();
			if (connectedProfilesAndEvents.Count > 0)
			{
				foreach (KeyValuePair<string, List<Events>> keyValuePair in connectedProfilesAndEvents)
				{
					string str = keyValuePair.Key.Replace("\\", "/");
					List<Events> value = keyValuePair.Value;
					string text2 = "__PFLS__[\"" + str + "\"]";
					text = text + text2 + " = {}\r\n";
					foreach (Events events in value)
					{
						if (events.RouteType.Length > 0)
						{
							if (events.RouteType == "Mailbox")
							{
								if (!text.Contains(text2 + "[\"MAILBOX\"]"))
								{
									events.TargetDisplayID.ToString();
									string recorderMailboxReceiver = events.RecorderMailboxReceiver;
									string text3 = events.RecorderMailboxSendGreys.ToString();
									string text4 = events.RecorderMailboxSendWhites.ToString();
									string text5 = events.RecorderMailboxSendGreens.ToString();
									string text6 = events.RecorderMailboxSendBlues.ToString();
									string text7 = events.RecorderMailboxSendPurples.ToString();
									List<string> recorderMailboxSendlist = events.RecorderMailboxSendlist;
									text = text + text2 + "[\"MAILBOX\"] = {}\r\n";
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"MAILBOX\"][\"Receiver\"] = \"",
										recorderMailboxReceiver,
										"\"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"MAILBOX\"][\"SendGreys\"] = ",
										text3.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"MAILBOX\"][\"SendWhites\"] = ",
										text4.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"MAILBOX\"][\"SendGreens\"] = ",
										text5.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"MAILBOX\"][\"SendBlues\"] = ",
										text6.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"MAILBOX\"][\"SendPurples\"] = ",
										text7.ToLower(),
										"\r\n"
									});
									text = text + text2 + "[\"MAILBOX\"][\"Sendlist\"] =\r\n";
									text += "{\r\n";
									if (recorderMailboxSendlist.Count > 0)
									{
										foreach (string str2 in recorderMailboxSendlist)
										{
											text = text + "    \"" + str2 + "\",\r\n";
										}
									}
									text += "}\r\n";
								}
							}
							else if (!events.RouteType.Contains("Ghost"))
							{
								string targetName = events.TargetName;
								string text8 = events.TargetDisplayID.ToString();
								if (Tools.IsNumber(text8, 1, 0, 1, 0))
								{
									string text9 = events.VendorSellGreys.ToString();
									string text10 = events.VendorSellWhites.ToString();
									string text11 = events.VendorSellGreens.ToString();
									string text12 = events.VendorSellBlues.ToString();
									string text13 = events.FlightPointID.ToString();
									if (!text.Contains(text2 + "[\"NPC\"]"))
									{
										text = text + text2 + "[\"NPC\"] = {}\r\n";
									}
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"] = {}\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Type\"] = \"",
										events.RouteType,
										"\"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Settings\"] = {}\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Settings\"][\"AutoSellGreys\"] = ",
										text9.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Settings\"][\"AutoSellWhites\"] = ",
										text10.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Settings\"][\"AutoSellGreens\"] = ",
										text11.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Settings\"][\"AutoSellBlues\"] = ",
										text12.ToLower(),
										"\r\n"
									});
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Whitelist\"] =\r\n"
									});
									text += "{\r\n";
									if (events.VendorWhitelist.Count > 0)
									{
										foreach (string str3 in events.VendorWhitelist)
										{
											text = text + "    \"" + str3 + "\",\r\n";
										}
									}
									text += "}\r\n";
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"Buylist\"] =\r\n"
									});
									text += "{\r\n";
									if (events.VendorBuylist.Count > 0)
									{
										foreach (string str4 in events.VendorBuylist)
										{
											text = text + "    \"" + str4 + "\",\r\n";
										}
									}
									text += "}\r\n";
									text = string.Concat(new string[]
									{
										text,
										text2,
										"[\"NPC\"][\"",
										text8,
										"\"][\"FlightID\"] = ",
										text13,
										"\r\n\r\n"
									});
								}
							}
						}
					}
				}
			}
			Addon.ImportContent = text;
			if (!_globals.Ready)
			{
				if (!Addon.WaitingForImport)
				{
					Tools.Console("Importing Addon data...", "", "richConsole", "frmMain", true);
					Addon.WaitingForImport = true;
					new Thread(new ThreadStart(Addon.WaitForImport))
					{
						IsBackground = true
					}.Start();
				}
				return;
			}
			Tools.Console("Importing Addon data (straight).", "", "richConsole", "frmMain", true);
			Addon.Import();
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0071A5B8 File Offset: 0x007187B8
		[CompilerGenerated]
		internal static void smethod_1()
		{
			Key.Press("JackMacro");
			Thread.Sleep(25);
			Key.Release("JackMacro");
			Thread.Sleep(250);
			Tools.Console("Reloading...", "", "richConsole", "frmMain", true);
			string name = Tools.RandomTimer("Reload");
			Jack.Engine.Timer.Set(name, 3000);
			while (!_globals.Ready && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(250);
			}
			Tools.Console("Reload done.", "", "richConsole", "frmMain", true);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0071A650 File Offset: 0x00718850
		[CompilerGenerated]
		internal static void smethod_2()
		{
			Thread.Sleep(10000);
			Addon.AutoDestroyDelay = false;
		}

		// Token: 0x04000A99 RID: 2713
		private static string ClassicGameFolder = "\\_classic_\\Interface\\AddOns";

		// Token: 0x04000A9A RID: 2714
		private static string ClassicEraGameFolder = "\\_classic_era_\\Interface\\AddOns";

		// Token: 0x04000A9B RID: 2715
		private static string RetailGameFolder = "\\_retail_\\Interface\\AddOns";

		// Token: 0x04000A9C RID: 2716
		private static bool WaitingForImport = false;

		// Token: 0x04000A9D RID: 2717
		private static string ImportContent = "";

		// Token: 0x04000A9E RID: 2718
		private static object _lockAction = new object();

		// Token: 0x04000A9F RID: 2719
		private static bool AutoDestroyDelay = false;
	}
}
