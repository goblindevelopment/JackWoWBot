using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Jack.ATH;
using Jack.Engine;
using Jack.Forms;
using Jack.Models;
using Microsoft.CSharp.RuntimeBinder;

namespace Jack.Core
{
	// Token: 0x02000117 RID: 279
	internal class Initialize
	{
		// Token: 0x0600191E RID: 6430 RVA: 0x00726C14 File Offset: 0x00724E14
		public static void PreLoadForms()
		{
			_globals.JackFormsPreLoad = true;
			_globals.JackForms.Add(new frmMainAccount());
			_globals.JackForms.Add(new frmMainModules(Array.Empty<object>()));
			_globals.JackForms.Add(new frmMainProfiles());
			_globals.JackForms.Add(new frmMainRotations());
			_globals.JackForms.Add(new frmMainKeybinds());
			_globals.JackForms.Add(new frmMainOverlay());
			_globals.JackForms.Add(new frmMainAddon());
			_globals.JackForms.Add(new frmMainSettings());
			_globals.JackForms.Add(new frmMainMessages());
			_globals.JackForms.Add(new frmProfile());
			_globals.JackForms.Add(new frmProfileEvent(Array.Empty<object>()));
			_globals.JackForms.Add(new frmRotation());
			_globals.JackForms.Add(new frmRotationConditions());
			int num = 0;
			int count = _globals.JackForms.Count;
			foreach (Form form in _globals.JackForms)
			{
				num += 100 / count;
				Tools.SetProgress("frmSplashScreenControls", "progress", num, false, "");
				if (form.Name != "frmRotationConditions")
				{
					form.Opacity = 0.0;
					form.Show();
					form.Hide();
					form.Opacity = 1.0;
				}
			}
			Tools.SetProgress("frmSplashScreenControls", "progress", 100, false, "");
			_globals.JackFormsPreLoad = false;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00726DB8 File Offset: 0x00724FB8
		public static void SplashScreen(bool Open = true, Form Form = null)
		{
			if (Open)
			{
				Initialize.tSplashScreenControls = new Thread(new ThreadStart(Initialize.smethod_0));
				Initialize.tSplashScreenControls.Start();
				return;
			}
			Tools.CloseForm("frmSplashScreenControls", Array.Empty<object>());
			Initialize.tSplashScreenControls.Abort();
			Window.Activate(Form);
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x00726E08 File Offset: 0x00725008
		public static bool Lists
		{
			get
			{
				string str = "Classic.";
				if (_globals.IsRetail)
				{
					str = "Retail.";
				}
				Initialize.LoadToList(Initialize.GetResources("Jack.Lists." + str + "Skinning", false), _globals.List_Skinning);
				Initialize.LoadToList(Initialize.GetResources("Jack.Lists." + str + "Container", false), _globals.List_Container);
				Initialize.LoadToList(Initialize.GetResources("Jack.Lists." + str + "FishingPools", false), _globals.List_FishingPools);
				Initialize.LoadToList(Initialize.GetResources("Jack.Lists." + str + "HerbalismMobs", false), _globals.List_HerbalismMobs);
				Initialize.LoadToList(Initialize.GetResources("Jack.Lists." + str + "MiningMobs", false), _globals.List_MiningMobs);
				Initialize.LoadToList(Initialize.GetResources("Jack.Lists.Pathfinder.Reagents", false), _globals.List_PathfinderReagents);
				return _globals.List_Skinning.Count<int>() > 0 && _globals.List_Container.Count<int>() > 0 && _globals.List_FishingPools.Count<int>() > 0 && _globals.List_HerbalismMobs.Count<int>() > 0 && _globals.List_MiningMobs.Count<int>() > 0;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001921 RID: 6433 RVA: 0x00726F24 File Offset: 0x00725124
		public static bool Dictionaries
		{
			get
			{
				string str = "Classic.";
				if (_globals.IsRetail)
				{
					str = "Retail.";
				}
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Herbalism", false), _globals.List_Herbalism);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Mining", false), _globals.List_Mining);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Spells", false), _globals.List_Spells);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Zones.All", false), _globals.List_Zones);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Zones.Continents", false), _globals.List_ZonesContinents);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Zones.Cities", false), _globals.List_Cities);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Dungeons", false), _globals.List_Dungeons);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Battlegrounds", false), _globals.List_Battlegrounds);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Items.All", false), _globals.List_Items);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Items.Fishing.Poles", false), _globals.List_FishingPoles);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Items.Fishing.Baits", false), _globals.List_FishingBaits);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "FlightPoints", false), _globals.List_FlightPoints);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists." + str + "Transports", false), _globals.List_Transports);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Vendor", false), _globals.List_PathfinderVendor);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Trainer", false), _globals.List_PathfinderTrainer);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Innkeeper", false), _globals.List_PathfinderInnkeeper);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Bank", false), _globals.List_PathfinderBank);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.FlightMaster", false), _globals.List_PathfinderFlightMaster);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Mailbox", false), _globals.List_PathfinderMailbox);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Portal", false), _globals.List_PathfinderPortal);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Consumables.Food", false), _globals.List_PathfinderFood);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Consumables.Drink", false), _globals.List_PathfinderDrink);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Ammunition.Arrows", false), _globals.List_PathfinderArrows);
				Initialize.LoadToDictionary(Initialize.GetResources("Jack.Lists.Pathfinder.Ammunition.Bullets", false), _globals.List_PathfinderBullets);
				return _globals.List_Herbalism.Count<KeyValuePair<int, int>>() > 0 && _globals.List_Mining.Count<KeyValuePair<int, int>>() > 0 && _globals.List_Spells.Count<KeyValuePair<int, string>>() > 0 && _globals.List_Zones.Count<KeyValuePair<int, string>>() > 0 && _globals.List_ZonesContinents.Count<KeyValuePair<int, string>>() > 0 && _globals.List_Cities.Count<KeyValuePair<int, string>>() > 0 && _globals.List_Dungeons.Count<KeyValuePair<int, string>>() > 0 && _globals.List_Battlegrounds.Count<KeyValuePair<int, string>>() > 0 && _globals.List_Items.Count<KeyValuePair<int, string>>() > 0 && _globals.List_FlightPoints.Count<KeyValuePair<int, string>>() > 0 && _globals.List_PathfinderVendor.Count<FromList>() > 0 && _globals.List_PathfinderTrainer.Count<FromList>() > 0 && _globals.List_PathfinderInnkeeper.Count<FromList>() > 0 && _globals.List_PathfinderBank.Count<FromList>() > 0 && _globals.List_PathfinderFlightMaster.Count<FromList>() > 0 && _globals.List_PathfinderMailbox.Count<FromList>() > 0 && _globals.List_PathfinderPortal.Count<FromList>() > 0 && _globals.List_PathfinderFood.Count<KeyValuePair<int, int>>() > 0 && _globals.List_PathfinderDrink.Count<KeyValuePair<int, int>>() > 0 && _globals.List_PathfinderReagents.Count<int>() > 0 && _globals.List_PathfinderArrows.Count<KeyValuePair<int, int>>() > 0 && _globals.List_PathfinderBullets.Count<KeyValuePair<int, int>>() > 0;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x00727310 File Offset: 0x00725510
		public static bool MeshMapIDs
		{
			get
			{
				string text = "";
				if (!_globals.IsRetail && _globals.PathfinderClassicReady)
				{
					text = "Classic";
				}
				else if (_globals.IsRetail && _globals.PathfinderRetailReady)
				{
					text = "Retail";
				}
				if (text.Length != 0 && File.Exists(_globals.JackPathfinder + "\\" + text + "\\0000.mmap"))
				{
					_globals.List_MeshMapIDs.Clear();
					foreach (FileInfo fileInfo in new DirectoryInfo(_globals.JackPathfinder + "\\" + text + "\\").GetFiles())
					{
						if (!(fileInfo.Extension != ".mmtile"))
						{
							string text2 = fileInfo.Name.Substring(0, 4);
							if (!text2.StartsWith("000"))
							{
								if (text2.StartsWith("00"))
								{
									text2 = text2.Substring(2, 2);
								}
								else if (text2.StartsWith("0"))
								{
									text2 = text2.Substring(1, 3);
								}
							}
							else
							{
								text2 = text2.Substring(3, 1);
							}
							if (Tools.IsNumber(text2, 1, 0, 0, 0))
							{
								int item = Convert.ToInt32(text2);
								if (!_globals.List_MeshMapIDs.Contains(item))
								{
									_globals.List_MeshMapIDs.Add(item);
								}
							}
						}
					}
					return _globals.List_MeshMapIDs.Count > 0;
				}
				return false;
			}
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x0072746C File Offset: 0x0072566C
		public static void CreateFilesAndFolders()
		{
			if (!Directory.Exists(_globals.JackLogs))
			{
				Directory.CreateDirectory(_globals.JackLogs);
			}
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00727490 File Offset: 0x00725690
		public static void CheckFirstStart()
		{
			if (!Settings.FirstStart)
			{
				object[] args = new object[]
				{
					"Redist_x86",
					"Install"
				};
				Tools.OpenForm("frmDownload", true, "frmMain", args);
				Thread.Sleep(1000);
				args = new object[]
				{
					"Redist_x64",
					"Install"
				};
				Tools.OpenForm("frmDownload", true, "frmMain", args);
			}
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00727500 File Offset: 0x00725700
		public static void DeleteUnnecessaryFiles()
		{
			foreach (string text in new List<string>
			{
				_globals.JackFolder + "\\Updater.exe",
				_globals.JackData + "\\MD1.dll",
				_globals.JackData + "\\MD2.dll",
				_globals.JackData + "\\MD3.dll",
				_globals.JackData + "\\MD4.dll",
				_globals.JackData + "\\MD5.dll"
			})
			{
				if (File.Exists(text))
				{
					while (!Tools.IsFileReady(text, true))
					{
						Thread.Sleep(10);
					}
					File.Delete(text);
				}
			}
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x007275EC File Offset: 0x007257EC
		public static void ExtractFiles(List<string[]> LocationDestinationPreCheck = null)
		{
			if (LocationDestinationPreCheck == null)
			{
				return;
			}
			int count = LocationDestinationPreCheck.Count;
			if (count == 0)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				bool flag = false;
				string[] array = LocationDestinationPreCheck[i];
				string path = array[0];
				string text = "";
				if (array.Count<string>() == 3)
				{
					text = array[2];
				}
				else if (array.Count<string>() == 2)
				{
				}
				if (File.Exists(path))
				{
					if (text.Length <= 0)
					{
						flag = true;
					}
					else if (text.Contains("."))
					{
						if (!File.Exists(text))
						{
							flag = true;
						}
					}
					else if (Directory.Exists(text))
					{
						if (Directory.GetFiles(text, "*", SearchOption.TopDirectoryOnly).Length == 0)
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
				}
				if (!flag)
				{
					LocationDestinationPreCheck.RemoveAt(i);
				}
			}
			if (LocationDestinationPreCheck.Count > 0)
			{
				object[] args = new object[]
				{
					"Extract",
					LocationDestinationPreCheck
				};
				Tools.OpenForm("frmDownload", true, "frmMain", args);
			}
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x007276D4 File Offset: 0x007258D4
		public static void CheckForPathfinderFiles(string UpdateGames = "")
		{
			bool flag = UpdateGames.Length > 0;
			if (!File.Exists(_globals.JackData + "\\Pathfinder.dll"))
			{
				MessageBox.Show("Some necessary files could not be located.\r\nPlease make sure your installation were completed.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				Tools.CloseJack(true);
			}
			bool flag2 = Initialize.CheckForPathfinderFiles("Classic", 3000);
			bool flag3 = Initialize.CheckForPathfinderFiles("Retail", 10000);
			_globals.PathfinderClassicReady = flag2;
			_globals.PathfinderRetailReady = flag3;
			if (!flag && (flag2 || flag3))
			{
				return;
			}
			if (!flag)
			{
				Tools.OpenForm("frmDownloadMaps", true, "frmMain", Array.Empty<object>());
			}
			string text;
			if (!flag)
			{
				text = frmDownloadMaps.WhichClients;
			}
			else
			{
				text = UpdateGames;
			}
			List<string> list = new List<string>();
			if (text.Contains("Classic"))
			{
				list.Add("Classic");
			}
			if (text.Contains("Retail"))
			{
				list.Add("Retail");
			}
			if (list.Count == 0)
			{
				if (flag)
				{
					return;
				}
				Tools.CloseJack(true);
			}
			List<string[]> list2 = new List<string[]>();
			bool flag4 = false;
			object[] args;
			foreach (string text2 in list)
			{
				string text3 = _globals.JackDownloads + "\\" + text2 + ".7z";
				args = new object[]
				{
					"Maps",
					text2 + ".7z"
				};
				Tools.OpenForm("frmDownload", true, "frmMain", args);
				if (!File.Exists(text3))
				{
					Tools.ControlVisible("lblInfoMaps" + text2 + "Download", "frmMainSettings", true);
					flag4 = true;
					break;
				}
				if (new FileInfo(text3).Length <= 5000000L)
				{
					File.Delete(text3);
					Tools.ControlVisible("lblInfoMaps" + text2 + "Download", "frmMainSettings", true);
					flag4 = true;
					break;
				}
				if (Directory.Exists(_globals.JackPathfinder + "\\" + text2))
				{
					Directory.Delete(_globals.JackPathfinder + "\\" + text2, true);
					Directory.CreateDirectory(_globals.JackPathfinder + "\\" + text2);
				}
				list2.Add(new string[]
				{
					_globals.JackDownloads + "\\" + text2 + ".7z",
					_globals.JackPathfinder + "\\" + text2,
					_globals.JackPathfinder + "\\" + text2 + "\\0000.mmap"
				});
			}
			if (flag4)
			{
				MessageBox.Show("Some necessary files could not be downloaded.\r\n" + "Please make sure your firewall allow outbound connections from Jack.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			args = new object[]
			{
				"Extract",
				list2
			};
			Tools.OpenForm("frmDownload", true, "frmMain", args);
			_globals.PathfinderClassicReady = Initialize.CheckForPathfinderFiles("Classic", 3000);
			_globals.PathfinderRetailReady = Initialize.CheckForPathfinderFiles("Retail", 10000);
			if (flag)
			{
				Settings.MapsClassicVersion = _globals.LatestClassicMapsVersion;
				Settings.MapsRetailVersion = _globals.LatestRetailMapsVersion;
				Settings.Save();
				Initialize.SetInfo();
			}
			using (List<string[]>.Enumerator enumerator2 = list2.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					string path = enumerator2.Current[0];
					while (File.Exists(path))
					{
						try
						{
							File.Delete(path);
							goto IL_34E;
						}
						catch
						{
							goto IL_34E;
						}
						IL_342:
						Thread.Sleep(1000);
						continue;
						IL_34E:
						if (File.Exists(path))
						{
							goto IL_342;
						}
						break;
					}
				}
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00727A98 File Offset: 0x00725C98
		public static bool CheckForPathfinderFiles(string Game, int MinAmountOfMaps)
		{
			if (!Directory.Exists(_globals.JackPathfinder))
			{
				Directory.CreateDirectory(_globals.JackPathfinder + "\\" + Game);
				return false;
			}
			if (File.Exists(_globals.JackPathfinder + "\\000.mmap"))
			{
				Directory.Delete(_globals.JackPathfinder, true);
			}
			if (!Directory.Exists(_globals.JackPathfinder + "\\" + Game))
			{
				Directory.CreateDirectory(_globals.JackPathfinder + "\\" + Game);
				return false;
			}
			int num = Directory.GetFiles(_globals.JackPathfinder + "\\" + Game + "\\", "*", SearchOption.TopDirectoryOnly).Length;
			if (!File.Exists(_globals.JackPathfinder + "\\" + Game + "\\0000.mmap"))
			{
				if (num > 0)
				{
					Directory.Delete(_globals.JackPathfinder + "\\" + Game, true);
					Directory.CreateDirectory(_globals.JackPathfinder + "\\" + Game);
				}
				return false;
			}
			if (num >= MinAmountOfMaps)
			{
				return true;
			}
			Directory.Delete(_globals.JackPathfinder + "\\" + Game, true);
			Directory.CreateDirectory(_globals.JackPathfinder + "\\" + Game);
			return false;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00727BC0 File Offset: 0x00725DC0
		public static bool CheckLicense
		{
			get
			{
				return Settings.License.Length == 14;
			}
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00727BDC File Offset: 0x00725DDC
		public static bool CheckServerResponseData()
		{
			if (File.Exists(_globals.JackData + "\\Ath.dll"))
			{
				if (!Initialize.CheckLicense)
				{
					Tools.OpenForm("frmLicense", true, "frmMain", Array.Empty<object>());
				}
				if (Initialize.CheckLicense)
				{
					Initialize.LCS(true);
					int num = Tools.CountProcess("Jack", "", false);
					if (num > 0)
					{
						num--;
					}
					string text = REQ.Ath("ATH", string.Concat(new string[]
					{
						"&v=",
						_globals.Version,
						"&HWID=",
						_globals.HWID,
						"&ses=",
						num.ToString()
					}));
					if (text == "Success")
					{
						return true;
					}
					if (!(text == "ConnectionFailed"))
					{
						if (!(text == "InvalidLicense"))
						{
							if (text == "LicenseExpired")
							{
								object[] args = new object[]
								{
									"Your license has expired."
								};
								Tools.OpenForm("frmLicense", true, "frmMain", args);
							}
							else if (!(text == "MaxSessionsReached"))
							{
								if (text == "")
								{
									object[] args2 = new object[]
									{
										"Error: " + text
									};
									Tools.OpenForm("frmLicense", true, "frmMain", args2);
								}
								else
								{
									MessageBox.Show("Something went wrong.\r\nPlease try again.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Hand);
									Tools.CloseJack(true);
								}
							}
							else
							{
								MessageBox.Show("The session limit for this license has been reached.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Hand);
								Tools.CloseJack(true);
							}
						}
						else
						{
							object[] args3 = new object[]
							{
								"Your license could not be authenticated."
							};
							Tools.OpenForm("frmLicense", true, "frmMain", args3);
						}
					}
					else
					{
						MessageBox.Show("A connection to the server could not be established.\r\nPlease check your internet connection or contact the support.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						Environment.Exit(0);
					}
				}
			}
			else
			{
				MessageBox.Show("Couldn't find Ath.dll.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			return false;
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00727DD4 File Offset: 0x00725FD4
		public static bool LCS(bool Reset = false)
		{
			if (Reset)
			{
				_globals.LCSEnc = "";
			}
			if (Settings.License.Length > 0)
			{
				if (_globals.LCSEnc == "")
				{
					_globals.LCSEnc = Crypt.md5(Settings.License, 2);
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00727E20 File Offset: 0x00726020
		public static bool StartAgent()
		{
			string text = "";
			bool flag = false;
			if (!File.Exists(_globals.JackData + "\\JKA.exe"))
			{
				MessageBox.Show("Some files could not be found.\r\n" + "Please make sure you have added the Jack folder to your Anti-Virus/Windows Defender exceptions.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return false;
			}
			List<string> list = new List<string>
			{
				"Updater.exe",
				"JKA.exe",
				"Jack.exe",
				_globals.JackExe
			};
			string[] files = Directory.GetFiles(_globals.JackData + "\\", "*.exe", SearchOption.TopDirectoryOnly);
			for (int i = 0; i < files.Length; i++)
			{
				string fileName = Path.GetFileName(files[i]);
				if (!list.Contains(fileName))
				{
					text = fileName;
					break;
				}
			}
			if (text.Length == 0)
			{
				text = "JKA.exe";
			}
			if (Tools.CountProcess("JKA", "", false) <= 0)
			{
				if (text != "JKA.exe")
				{
					File.Delete(_globals.JackData + "\\" + text);
				}
				text = Tools.RandomString(15, true) + ".exe";
				string text2 = _globals.JackData + "\\" + text;
				while (File.Exists(text2))
				{
					text = Tools.RandomString(15, true) + ".exe";
					text2 = _globals.JackData + "\\" + text;
				}
				File.Copy(_globals.JackData + "\\JKA.exe", text2);
				int num = 0;
				while (num < 3 && !(flag = Tools.StartProcess(_globals.JackData + "\\" + text, _globals.LCSEnc, false)))
				{
					Thread.Sleep(500);
					num++;
				}
				if (!flag)
				{
					MessageBox.Show("Some files could not be started.\r\n" + "Please make sure you have added the Jack folder to your Anti-Virus/Windows Defender exceptions.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				return flag;
			}
			return true;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00727FF8 File Offset: 0x007261F8
		public static void SetJackDataBeforeSplash()
		{
			if (Tools.IsNumber(_globals.LCS.d1.Replace(".", ""), 1, 0, 0, 0))
			{
				_globals.LatestVersion = _globals.LCS.d1;
			}
			if (Tools.IsNumber(_globals.LCS.d2.Replace(".", ""), 1, 0, 0, 0))
			{
				_globals.LatestAddonVersion = _globals.LCS.d2;
			}
			if (Tools.IsNumber(_globals.LCS.d3.Replace(".", ""), 1, 0, 0, 0))
			{
				_globals.LatestClassicMapsVersion = _globals.LCS.d3;
			}
			if (Tools.IsNumber(_globals.LCS.d4.Replace(".", ""), 1, 0, 0, 0))
			{
				_globals.LatestRetailMapsVersion = _globals.LCS.d4;
			}
			if (_globals.LCS.d50.Length > 0)
			{
				_globals.UserData["Username"] = _globals.LCS.d50;
			}
			_globals.Builds["Classic"] = _globals.LCS.d102;
			_globals.Builds["ClassicPrevious"] = _globals.LCS.d105;
			_globals.Builds["ClassicPTR"] = _globals.LCS.d202;
			_globals.Builds["ClassicPTRPrevious"] = _globals.LCS.d205;
			_globals.Builds["ClassicEra"] = _globals.LCS.d302;
			_globals.Builds["ClassicEraPrevious"] = _globals.LCS.d305;
			_globals.Builds["ClassicEraPTR"] = _globals.LCS.d402;
			_globals.Builds["ClassicEraPTRPrevious"] = _globals.LCS.d405;
			_globals.Builds["Retail"] = _globals.LCS.d502;
			_globals.Builds["RetailPrevious"] = _globals.LCS.d505;
			_globals.Builds["RetailPTR"] = _globals.LCS.d602;
			_globals.Builds["RetailPTRPrevious"] = _globals.LCS.d605;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00728228 File Offset: 0x00726428
		public static void SetJackDataWhileSplash()
		{
			MDL.CreateMDs();
			PFL.Get(false);
			Json.LoadStuckPaths();
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x00728248 File Offset: 0x00726448
		public static void SetInfo()
		{
			string str = "";
			if (_globals.IsTeam)
			{
				Tools.Control("Version (Team):", "lblInfoJackVersion", "frmMainSettings", true, false, false, false, 0);
				Tools.Control("Latest (Team):", "lblInfoJackLatest", "frmMainSettings", true, false, false, false, 0);
				str = "T";
			}
			Tools.Control(_globals.Version + " " + str, "lblInfoJackVersionData", "frmMainSettings", true, false, false, false, 0);
			Tools.Control(_globals.LatestVersion + " " + str, "lblInfoJackLatestData", "frmMainSettings", true, false, false, false, 0);
			Tools.Control(_globals.LatestAddonVersion, "lblInfoAddonLatestData", "frmMainSettings", true, false, false, false, 0);
			string text = Settings.GameFolder + "\\_classic_\\" + _globals.ExeNameClassic;
			string text2 = Settings.GameFolder + "\\_classic_ptr_\\" + _globals.ExeNameClassicPTR;
			string text3 = Settings.GameFolder + "\\_classic_era_\\" + _globals.ExeNameClassic;
			string text4 = Settings.GameFolder + "\\_classic_era_ptr_\\" + _globals.ExeNameClassicPTR;
			string text5 = Settings.GameFolder + "\\_retail_\\" + _globals.ExeNameRetail;
			string text6 = Settings.GameFolder + "\\_ptr_\\" + _globals.ExeNameRetailPTR;
			string text7 = "";
			string text8 = "";
			string text9 = "";
			string text10 = "";
			string text11 = "";
			string text12 = "";
			if (File.Exists(text))
			{
				try
				{
					text7 = FileVersionInfo.GetVersionInfo(text).FileVersion.Replace(" ", "");
				}
				catch
				{
				}
			}
			if (File.Exists(text2))
			{
				try
				{
					text8 = FileVersionInfo.GetVersionInfo(text2).FileVersion.Replace(" ", "");
				}
				catch
				{
				}
			}
			if (File.Exists(text3))
			{
				try
				{
					text9 = FileVersionInfo.GetVersionInfo(text3).FileVersion.Replace(" ", "");
				}
				catch
				{
				}
			}
			if (File.Exists(text4))
			{
				try
				{
					text10 = FileVersionInfo.GetVersionInfo(text4).FileVersion.Replace(" ", "");
				}
				catch
				{
				}
			}
			if (File.Exists(text5))
			{
				try
				{
					text11 = FileVersionInfo.GetVersionInfo(text5).FileVersion.Replace(" ", "");
				}
				catch
				{
				}
			}
			if (File.Exists(text6))
			{
				try
				{
					text12 = FileVersionInfo.GetVersionInfo(text6).FileVersion.Replace(" ", "");
				}
				catch
				{
				}
			}
			Tools.ControlColor("Not available", "lblInfoBuildsClassicBuild", "frmMainSettings", Color.White, null, false);
			Tools.ControlColor("Not available", "lblInfoBuildsClassicStatus", "frmMainSettings", Color.DarkGray, null, false);
			if (text7.Length > 0)
			{
				Tools.ControlColor(text7, "lblInfoBuildsClassicBuild", "frmMainSettings", Color.White, null, false);
				if (_globals.Builds["Classic"] == text7 || _globals.Builds["ClassicPrevious"] == text7)
				{
					Tools.ControlColor("Ready to Play", "lblInfoBuildsClassicStatus", "frmMainSettings", Color.LimeGreen, null, false);
				}
			}
			else
			{
				Tools.ControlColor("Game/Addon required", "lblInfoBuildsClassicStatus", "frmMainSettings", Color.DarkGray, null, false);
			}
			Tools.ControlColor("Not available", "lblInfoBuildsClassicPTRBuild", "frmMainSettings", Color.White, null, false);
			Tools.ControlColor("Not available", "lblInfoBuildsClassicPTRStatus", "frmMainSettings", Color.DarkGray, null, false);
			if (text8.Length > 0)
			{
				Tools.ControlColor(text8, "lblInfoBuildsClassicPTRBuild", "frmMainSettings", Color.White, null, false);
				if (_globals.Builds["ClassicPTR"] == text8 || _globals.Builds["ClassicPTRPrevious"] == text8)
				{
					Tools.ControlColor("Ready to Play", "lblInfoBuildsClassicPTRStatus", "frmMainSettings", Color.LimeGreen, null, false);
				}
			}
			else
			{
				Tools.ControlColor("Game/Addon required", "lblInfoBuildsClassicPTRStatus", "frmMainSettings", Color.DarkGray, null, false);
			}
			Tools.ControlColor("Not available", "lblInfoBuildsClassicEraBuild", "frmMainSettings", Color.White, null, false);
			Tools.ControlColor("Not available", "lblInfoBuildsClassicEraStatus", "frmMainSettings", Color.DarkGray, null, false);
			if (text9.Length <= 0)
			{
				Tools.ControlColor("Game/Addon required", "lblInfoBuildsClassicEraStatus", "frmMainSettings", Color.DarkGray, null, false);
			}
			else
			{
				Tools.ControlColor(text9, "lblInfoBuildsClassicEraBuild", "frmMainSettings", Color.White, null, false);
				if (_globals.Builds["ClassicEra"] == text9 || _globals.Builds["ClassicEraPrevious"] == text9)
				{
					Tools.ControlColor("Ready to Play", "lblInfoBuildsClassicEraStatus", "frmMainSettings", Color.LimeGreen, null, false);
				}
			}
			Tools.ControlColor("Not available", "lblInfoBuildsClassicEraPTRBuild", "frmMainSettings", Color.White, null, false);
			Tools.ControlColor("Not available", "lblInfoBuildsClassicEraPTRStatus", "frmMainSettings", Color.DarkGray, null, false);
			if (text10.Length > 0)
			{
				Tools.ControlColor(text10, "lblInfoBuildsClassicEraPTRBuild", "frmMainSettings", Color.White, null, false);
				if (_globals.Builds["ClassicEraPTR"] == text10 || _globals.Builds["ClassicEraPTRPrevious"] == text10)
				{
					Tools.ControlColor("Ready to Play", "lblInfoBuildsClassicEraPTRStatus", "frmMainSettings", Color.LimeGreen, null, false);
				}
			}
			else
			{
				Tools.ControlColor("Game/Addon required", "lblInfoBuildsClassicEraPTRStatus", "frmMainSettings", Color.DarkGray, null, false);
			}
			Tools.ControlColor("Not available", "lblInfoBuildsRetailBuild", "frmMainSettings", Color.White, null, false);
			Tools.ControlColor("Not available", "lblInfoBuildsRetailStatus", "frmMainSettings", Color.DarkGray, null, false);
			if (text11.Length > 0)
			{
				Tools.ControlColor(text11, "lblInfoBuildsRetailBuild", "frmMainSettings", Color.White, null, false);
				if (_globals.Builds["Retail"] == text11 || _globals.Builds["RetailPrevious"] == text11)
				{
					Tools.ControlColor("Ready to Play", "lblInfoBuildsRetailStatus", "frmMainSettings", Color.LimeGreen, null, false);
				}
			}
			else
			{
				Tools.ControlColor("Game/Addon required", "lblInfoBuildsRetailStatus", "frmMainSettings", Color.DarkGray, null, false);
			}
			Tools.ControlColor("Not available", "lblInfoBuildsRetailPTRBuild", "frmMainSettings", Color.White, null, false);
			Tools.ControlColor("Not available", "lblInfoBuildsRetailPTRStatus", "frmMainSettings", Color.DarkGray, null, false);
			if (text12.Length <= 0)
			{
				Tools.ControlColor("Game/Addon required", "lblInfoBuildsRetailPTRStatus", "frmMainSettings", Color.DarkGray, null, false);
			}
			else
			{
				Tools.ControlColor(text12, "lblInfoBuildsRetailPTRBuild", "frmMainSettings", Color.White, null, false);
				if (_globals.Builds["RetailPTR"] == text12 || _globals.Builds["RetailPTRPrevious"] == text12)
				{
					Tools.ControlColor("Ready to Play", "lblInfoBuildsRetailPTRStatus", "frmMainSettings", Color.LimeGreen, null, false);
				}
			}
			Tools.Control(_globals.LatestClassicMapsVersion, "lblInfoMapsClassicVersionData", "frmMainSettings", true, false, false, false, 0);
			if (!File.Exists(_globals.JackPathfinder + "\\Classic\\0000.mmap"))
			{
				Tools.ControlVisible("lblInfoMapsClassicDownload", "frmMainSettings", true);
			}
			Tools.Control(_globals.LatestRetailMapsVersion, "lblInfoMapsRetailVersionData", "frmMainSettings", true, false, false, false, 0);
			if (!File.Exists(_globals.JackPathfinder + "\\Retail\\0000.mmap"))
			{
				Tools.ControlVisible("lblInfoMapsRetailDownload", "frmMainSettings", true);
			}
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x007289EC File Offset: 0x00726BEC
		public static void CheckForUpdates(bool OnStart = false)
		{
			bool flag = false;
			if (!OnStart)
			{
				object arg = Tools.RequestJson("CHKUPD");
				if (Initialize.<>o__23.<>p__1 == null)
				{
					Initialize.<>o__23.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Initialize), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
					}));
				}
				Func<CallSite, object, bool> target = Initialize.<>o__23.<>p__1.Target;
				CallSite <>p__ = Initialize.<>o__23.<>p__1;
				if (Initialize.<>o__23.<>p__0 == null)
				{
					Initialize.<>o__23.<>p__0 = CallSite<Func<CallSite, object, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.NotEqual, typeof(Initialize), new CSharpArgumentInfo[]
					{
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
						CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.Constant, null)
					}));
				}
				if (target(<>p__, Initialize.<>o__23.<>p__0.Target(Initialize.<>o__23.<>p__0, arg, null)))
				{
					try
					{
						if (Initialize.<>o__23.<>p__3 == null)
						{
							Initialize.<>o__23.<>p__3 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Initialize)));
						}
						Func<CallSite, object, string> target2 = Initialize.<>o__23.<>p__3.Target;
						CallSite <>p__2 = Initialize.<>o__23.<>p__3;
						if (Initialize.<>o__23.<>p__2 == null)
						{
							Initialize.<>o__23.<>p__2 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "versionJack", typeof(Initialize), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						string text = target2(<>p__2, Initialize.<>o__23.<>p__2.Target(Initialize.<>o__23.<>p__2, arg));
						if (text.Length > 0)
						{
							_globals.LatestVersion = text;
						}
						if (Initialize.<>o__23.<>p__5 == null)
						{
							Initialize.<>o__23.<>p__5 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Initialize)));
						}
						Func<CallSite, object, string> target3 = Initialize.<>o__23.<>p__5.Target;
						CallSite <>p__3 = Initialize.<>o__23.<>p__5;
						if (Initialize.<>o__23.<>p__4 == null)
						{
							Initialize.<>o__23.<>p__4 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "versionAddon", typeof(Initialize), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						string text2 = target3(<>p__3, Initialize.<>o__23.<>p__4.Target(Initialize.<>o__23.<>p__4, arg));
						if (text2.Length > 0)
						{
							_globals.LatestAddonVersion = text2;
						}
						if (Initialize.<>o__23.<>p__7 == null)
						{
							Initialize.<>o__23.<>p__7 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Initialize)));
						}
						Func<CallSite, object, string> target4 = Initialize.<>o__23.<>p__7.Target;
						CallSite <>p__4 = Initialize.<>o__23.<>p__7;
						if (Initialize.<>o__23.<>p__6 == null)
						{
							Initialize.<>o__23.<>p__6 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "versionMapsClassic", typeof(Initialize), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						string text3 = target4(<>p__4, Initialize.<>o__23.<>p__6.Target(Initialize.<>o__23.<>p__6, arg));
						if (text3.Length > 0)
						{
							_globals.LatestClassicMapsVersion = text3;
						}
						if (Initialize.<>o__23.<>p__9 == null)
						{
							Initialize.<>o__23.<>p__9 = CallSite<Func<CallSite, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(Initialize)));
						}
						Func<CallSite, object, string> target5 = Initialize.<>o__23.<>p__9.Target;
						CallSite <>p__5 = Initialize.<>o__23.<>p__9;
						if (Initialize.<>o__23.<>p__8 == null)
						{
							Initialize.<>o__23.<>p__8 = CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, "versionMapsRetail", typeof(Initialize), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						string text4 = target5(<>p__5, Initialize.<>o__23.<>p__8.Target(Initialize.<>o__23.<>p__8, arg));
						if (text4.Length > 0)
						{
							_globals.LatestRetailMapsVersion = text4;
						}
						goto IL_32B;
					}
					catch
					{
						goto IL_32B;
					}
				}
				flag = true;
			}
			IL_32B:
			if (!flag)
			{
				bool flag2 = _globals.Version != _globals.LatestVersion;
				bool flag3 = Settings.AddonVersion != _globals.LatestAddonVersion;
				bool flag4 = Settings.MapsClassicVersion != _globals.LatestClassicMapsVersion;
				bool flag5 = Settings.MapsRetailVersion != _globals.LatestRetailMapsVersion;
				if (flag2 && MessageBox.Show("A newer version is available.\r\nDo you want to update Jack now?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
				{
					Initialize.FullUpdate();
					return;
				}
				if (flag3)
				{
					if (Settings.AddonVersion == "")
					{
						Settings.AddonVersion = _globals.LatestAddonVersion;
						flag3 = false;
					}
					if (flag3 && MessageBox.Show("A newer Addon is available.\r\nDo you want to update your Addon(s) now?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
					{
						Addon.Install("JK", true);
					}
				}
				if (flag4 || flag5)
				{
					if (Settings.MapsClassicVersion == "")
					{
						Settings.MapsClassicVersion = _globals.LatestClassicMapsVersion;
						flag4 = false;
					}
					if (Settings.MapsRetailVersion == "")
					{
						Settings.MapsRetailVersion = _globals.LatestRetailMapsVersion;
						flag5 = false;
					}
					string text5 = "";
					if (flag4)
					{
						if (File.Exists(_globals.JackPathfinder + "\\Classic\\0000.mmap"))
						{
							text5 += "Classic";
						}
						else
						{
							flag4 = false;
						}
					}
					if (flag5)
					{
						if (File.Exists(_globals.JackPathfinder + "\\Retail\\0000.mmap"))
						{
							text5 += "Retail";
						}
						else
						{
							flag5 = false;
						}
					}
					if (text5.Length > 0 && MessageBox.Show("Newer map files are available.\r\nDo you want to update your maps now?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
					{
						Initialize.CheckForPathfinderFiles(text5);
					}
				}
				if (!OnStart && !flag2 && !flag3 && !flag4 && !flag5)
				{
					MessageBox.Show("Jack is up to date.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}
			}
			else
			{
				MessageBox.Show("Connection could not be established.\r\nPlease try again later.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06001931 RID: 6449 RVA: 0x00728F08 File Offset: 0x00727108
		public static void FullUpdate()
		{
			object[] args = new object[]
			{
				"Update",
				"Update"
			};
			Tools.OpenForm("frmDownload", true, "frmMain", args);
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x00728F40 File Offset: 0x00727140
		public static void Team()
		{
			_globals.IsTeam = (Initialize.GetResources("Jack._TEAM_", true).Count > 0);
			if (_globals.IsTeam)
			{
				Tools.InvokeMethod("frmTeam", "TeamUpdate", null, true);
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00728F80 File Offset: 0x00727180
		public static void LoadProfileAndRotation()
		{
			if (Settings.SelectedProfile != "" && Directory.Exists(_globals.JackProfiles) && File.Exists(_globals.JackProfiles + "\\" + Settings.SelectedProfile + ".json"))
			{
				Json.LoadProfile(Settings.SelectedProfile, true, true, false);
			}
			if (Settings.SelectedRotation != "" && Directory.Exists(_globals.JackRotations) && File.Exists(_globals.JackRotations + "\\" + Settings.SelectedRotation + ".json"))
			{
				Json.LoadRotation(Settings.SelectedRotation);
			}
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00729020 File Offset: 0x00727220
		public static void Keybinds()
		{
			if (File.Exists(_globals.JackUtilities + "\\Keybinds.json"))
			{
				Json.LoadKeybinds();
			}
			else
			{
				Keybinds keybinds = new Keybinds();
				keybinds.GroundMount = "NotSet";
				keybinds.FlightMount = "NotSet";
				keybinds.VendorMount = "NotSet";
				keybinds.Hearthstone = "NotSet";
				keybinds.PetAttack = "NotSet";
				keybinds.FeedPet = "NotSet";
				keybinds.MainHandEnchantment = "NotSet";
				keybinds.OffHandEnchantment = "NotSet";
				keybinds.Fishing = "NotSet";
				keybinds.Bait = "NotSet";
				keybinds.GSE = "NotSet";
				keybinds.JackMacro = "F5";
				keybinds.MoveForward = "W";
				keybinds.MoveBackward = "S";
				keybinds.TurnLeft = "A";
				keybinds.TurnRight = "D";
				keybinds.StrafeLeft = "Q";
				keybinds.StrafeRight = "E";
				keybinds.MoveDown = "X";
				keybinds.Jump = "Space";
				keybinds.PitchUp = "Insert";
				keybinds.PitchDown = "Delete";
				keybinds.TargetMouseover = "F6";
				keybinds.InteractWithMouseover = "F7";
				keybinds.InteractWithTarget = "F8";
				keybinds.ActionBar1_1 = "Nr1";
				keybinds.ActionBar1_2 = "Nr2";
				keybinds.ActionBar1_3 = "Nr3";
				keybinds.ActionBar1_4 = "Nr4";
				keybinds.ActionBar1_5 = "Nr5";
				keybinds.ActionBar1_6 = "Nr6";
				keybinds.ActionBar1_7 = "Nr7";
				keybinds.ActionBar1_8 = "Nr8";
				keybinds.ActionBar1_9 = "Nr9";
				keybinds.ActionBar1_10 = "Nr0";
				keybinds.ActionBar1_11 = "F9";
				keybinds.ActionBar1_12 = "F10";
				keybinds.ActionBar6_1 = "Numpad1";
				keybinds.ActionBar6_2 = "Numpad2";
				keybinds.ActionBar6_3 = "Numpad3";
				keybinds.ActionBar6_4 = "Numpad4";
				keybinds.ActionBar6_5 = "Numpad5";
				keybinds.ActionBar6_6 = "Numpad6";
				keybinds.ActionBar6_7 = "Numpad7";
				keybinds.ActionBar6_8 = "Numpad8";
				keybinds.ActionBar6_9 = "Numpad9";
				keybinds.ActionBar6_10 = "Numpad0";
				keybinds.ActionBar6_11 = "F11";
				keybinds.ActionBar6_12 = "F12";
				_globals.Keybinds.Clear();
				_globals.Keybinds.Add(keybinds);
			}
			if (_globals.Keybinds.Count > 0)
			{
				_globals.Keys.Clear();
				_globals.KeyStatus.Clear();
				Keybinds keybinds2 = _globals.Keybinds[0];
				foreach (PropertyInfo propertyInfo in keybinds2.GetType().GetProperties())
				{
					_globals.Keys.Add(propertyInfo.Name, (string)propertyInfo.GetValue(keybinds2, null));
					_globals.KeyStatus.Add(propertyInfo.Name, false);
				}
				_globals.Keys.Add("LeftButton", "LeftButton");
				_globals.KeyStatus.Add("LeftButton", false);
			}
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00666DC0 File Offset: 0x00664FC0
		public static void HotKeys()
		{
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x00729328 File Offset: 0x00727528
		public static void MemFonts()
		{
			try
			{
				foreach (string name in Initialize.GetResources("Jack.Core.Inc.Fonts", false).ToArray())
				{
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
					IntPtr intPtr = Marshal.AllocCoTaskMem((int)manifestResourceStream.Length);
					byte[] array2 = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(array2, 0, (int)manifestResourceStream.Length);
					Marshal.Copy(array2, 0, intPtr, (int)manifestResourceStream.Length);
					uint num = 0U;
					Initialize.AddFontMemResourceEx(intPtr, (uint)array2.Length, IntPtr.Zero, ref num);
					_globals.Fonts.AddMemoryFont(intPtr, (int)manifestResourceStream.Length);
					manifestResourceStream.Close();
					Marshal.FreeCoTaskMem(intPtr);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06001937 RID: 6455
		[DllImport("gdi32.dll")]
		private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

		// Token: 0x06001938 RID: 6456 RVA: 0x007293F4 File Offset: 0x007275F4
		public static void ChangeTitle(Form Form)
		{
			Form.Text = Tools.RandomString(10, true);
			Form.Update();
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00729418 File Offset: 0x00727618
		public static void GenerateHWID()
		{
			_globals.HWID = Crypt.HWID();
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00666DC0 File Offset: 0x00664FC0
		public static void CheckClients()
		{
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00729430 File Offset: 0x00727630
		public static void Threading()
		{
			new Thread(new ThreadStart(GameClient.Check))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(ObjectManager.Update))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(Jack.Engine.Timer.Create))
			{
				IsBackground = true
			}.Start();
			Pathfinder.LoadDll();
			new Thread(delegate()
			{
				Pathfinder.LoadMeshMap(false);
			})
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(Jack.Engine.Monitor.Watch))
			{
				IsBackground = true
			}.Start();
			new Thread(new ThreadStart(SNS.Messages))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00729504 File Offset: 0x00727704
		public static void LoadToList(List<string> Resources, List<string> ToList)
		{
			if (Resources.Count<string>() > 0)
			{
				ToList.Clear();
				foreach (string name in Resources)
				{
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						using (StreamReader streamReader = new StreamReader(manifestResourceStream))
						{
							string item;
							while ((item = streamReader.ReadLine()) != null)
							{
								ToList.Add(item);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x007295B4 File Offset: 0x007277B4
		public static void LoadToList(List<string> Resources, List<int> ToList)
		{
			if (Resources.Count<string>() > 0)
			{
				ToList.Clear();
				foreach (string name in Resources)
				{
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						using (StreamReader streamReader = new StreamReader(manifestResourceStream))
						{
							string value;
							while ((value = streamReader.ReadLine()) != null)
							{
								ToList.Add(Convert.ToInt32(value));
							}
						}
					}
				}
			}
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00729668 File Offset: 0x00727868
		public static void LoadToDictionary(List<string> Resources, Dictionary<int, string> ToList)
		{
			if (Resources.Count<string>() > 0)
			{
				ToList.Clear();
				foreach (string name in Resources)
				{
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						using (StreamReader streamReader = new StreamReader(manifestResourceStream))
						{
							string text;
							while ((text = streamReader.ReadLine()) != null)
							{
								if (text.Contains(";"))
								{
									string[] array = text.Split(new char[]
									{
										';'
									});
									if (Tools.IsNumber(array[0], 1, 0, 0, 0))
									{
										int key = int.Parse(array[0]);
										if (!ToList.ContainsKey(key))
										{
											ToList.Add(int.Parse(array[0]), array[1]);
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00729770 File Offset: 0x00727970
		public static void LoadToDictionary(List<string> Resources, Dictionary<int[], string> ToList)
		{
			if (Resources.Count<string>() > 0)
			{
				ToList.Clear();
				foreach (string name in Resources)
				{
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						using (StreamReader streamReader = new StreamReader(manifestResourceStream))
						{
							string text;
							while ((text = streamReader.ReadLine()) != null)
							{
								if (text.Contains(";"))
								{
									string[] array = text.Split(new char[]
									{
										';'
									});
									ToList.Add(new int[]
									{
										int.Parse(array[0]),
										int.Parse(array[1])
									}, array[2]);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0072986C File Offset: 0x00727A6C
		public static void LoadToDictionary(List<string> Resources, Dictionary<int, int> ToList)
		{
			if (Resources.Count<string>() > 0)
			{
				ToList.Clear();
				foreach (string name in Resources)
				{
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						using (StreamReader streamReader = new StreamReader(manifestResourceStream))
						{
							string text;
							while ((text = streamReader.ReadLine()) != null)
							{
								if (text.Contains(";"))
								{
									string[] array = text.Split(new char[]
									{
										';'
									});
									ToList.Add(int.Parse(array[0]), int.Parse(array[1]));
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00729954 File Offset: 0x00727B54
		public static void LoadToDictionary(List<string> Resources, List<FromList> ToList)
		{
			if (Resources.Count<string>() > 0)
			{
				ToList.Clear();
				foreach (string name in Resources)
				{
					using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
					{
						using (StreamReader streamReader = new StreamReader(manifestResourceStream))
						{
							string text;
							while ((text = streamReader.ReadLine()) != null)
							{
								if (text.Contains(";"))
								{
									string[] array = text.Split(new char[]
									{
										';'
									});
									if (array.Count<string>() > 0)
									{
										ToList.Add(new FromList
										{
											Name = Convert.ToString(array[0]),
											Level = Convert.ToInt32(array[1]),
											LocationName = Convert.ToString(array[2]),
											DisplayID = Convert.ToInt32(array[3]),
											ZoneID = Convert.ToInt32(array[4]),
											MeshMapID = Convert.ToInt32(array[5]),
											Faction = Convert.ToString(array[6]),
											Skills = Convert.ToString(array[7]),
											Position = Tools.StringToVector3(Convert.ToString(array[8]))
										});
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x00729B04 File Offset: 0x00727D04
		public static List<string> GetResources(string ResourceName, bool All = false)
		{
			List<string> list = new List<string>();
			foreach (string text in Assembly.GetExecutingAssembly().GetManifestResourceNames())
			{
				if (text.Contains(ResourceName) && (All || text.Contains(".txt") || text.Contains(".lua") || text.Contains(".toc") || text.Contains(".ttf")))
				{
					list.Add(text);
				}
			}
			return list;
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x00729B7C File Offset: 0x00727D7C
		public static string ReadResource(string Resource)
		{
			string text = "";
			using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(Resource))
			{
				using (StreamReader streamReader = new StreamReader(manifestResourceStream))
				{
					string str;
					while ((str = streamReader.ReadLine()) != null)
					{
						text = text + str + Environment.NewLine;
					}
				}
			}
			return text;
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x00729BF0 File Offset: 0x00727DF0
		[CompilerGenerated]
		internal static void smethod_0()
		{
			Application.Run(new frmSplashScreenControls());
		}

		// Token: 0x04000C7D RID: 3197
		public static Thread tSplashScreenControls;
	}
}
