using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using Jack.ATH;
using Jack.Engine;
using Jack.Forms;
using Jack.Models;
using Jack.Properties;

namespace Jack.Core
{
	// Token: 0x0200012E RID: 302
	internal class Settings
	{
		// Token: 0x06001ABB RID: 6843 RVA: 0x0072C358 File Offset: 0x0072A558
		public static void Save()
		{
			Settings.Default.WindowMainLocation = Settings.WindowMainLocation;
			Settings.Default.WindowMainSize = Settings.WindowMainSize;
			Settings.Default.WindowProfileLocation = Settings.WindowProfileLocation;
			Settings.Default.WindowProfileSize = Settings.WindowProfileSize;
			Settings.Default.WindowProfileEventSize = Settings.WindowProfileEventSize;
			Settings.Default.WindowRotationLocation = Settings.WindowRotationLocation;
			Settings.Default.WindowRotationSize = Settings.WindowRotationSize;
			Settings.Default.WindowRotationConditionSize = Settings.WindowRotationConditionSize;
			Settings.Default.WindowStoreLocation = Settings.WindowStoreLocation;
			Settings.Default.WindowStoreSize = Settings.WindowStoreSize;
			Settings.Default.License = Settings.License;
			Settings.Default.FirstStart = Settings.FirstStart;
			Settings.Default.OID = Settings.OID;
			Settings.Default.JackAutoDetectWindow = Settings.JackAutoDetectWindow;
			Settings.Default.JackTray = Settings.JackTray;
			Settings.Default.JackAutoReconnect = Settings.JackAutoReconnect;
			Settings.Default.JackAutoReconnectPassword = Settings.JackAutoReconnectPassword;
			Settings.Default.ProfilesDisplayMode = Settings.ProfilesDisplayMode;
			Settings.Default.RotationsDisplayMode = Settings.RotationsDisplayMode;
			Settings.Default.GameFolder = Settings.GameFolder;
			Settings.Default.AddonName = Settings.AddonName;
			Settings.Default.SelectedProfile = Settings.SelectedProfile;
			Settings.Default.SelectedRotation = Settings.SelectedRotation;
			Settings.Default.RecorderAutoRecord = Settings.RecorderAutoRecord;
			Settings.Default.RecorderAutoDistance = Settings.RecorderAutoDistance;
			Settings.Default.RecorderShowMaxLastWaypoints = Settings.RecorderShowMaxLastWaypoints;
			Settings.Default.RecorderQuestTracker = Settings.RecorderQuestTracker;
			Settings.Default.OverlayGFXAntiAliasing = Settings.OverlayGFXAntiAliasing;
			Settings.Default.OverlayGFXFPS = Settings.OverlayGFXFPS;
			Settings.Default.OverlayWaypoints = Settings.OverlayWaypoints;
			Settings.Default.OverlayWaypointsDisplayRadius = Settings.OverlayWaypointsDisplayRadius;
			Settings.Default.OverlayMenuConsole = Settings.OverlayMenuConsole;
			Settings.Default.OverlayMenuConsoleX = Settings.OverlayMenuConsoleX;
			Settings.Default.OverlayMenuConsoleY = Settings.OverlayMenuConsoleY;
			Settings.Default.OverlayMenuRecorder = Settings.OverlayMenuRecorder;
			Settings.Default.OverlayMenuRecorderX = Settings.OverlayMenuRecorderX;
			Settings.Default.OverlayMenuRecorderY = Settings.OverlayMenuRecorderY;
			Settings.Default.OverlayMenuStartStop = Settings.OverlayMenuStartStop;
			Settings.Default.OverlayMenuStartStopX = Settings.OverlayMenuStartStopX;
			Settings.Default.OverlayMenuStartStopY = Settings.OverlayMenuStartStopY;
			Settings.Default.OverlayESPObjectsHerbs = Settings.OverlayESPObjectsHerbs;
			Settings.Default.OverlayESPObjectsOres = Settings.OverlayESPObjectsOres;
			Settings.Default.OverlayESPObjectsSkinnables = Settings.OverlayESPObjectsSkinnables;
			Settings.Default.OverlayESPObjectsGatherableMobs = Settings.OverlayESPObjectsGatherableMobs;
			Settings.Default.OverlayESPObjectsChests = Settings.OverlayESPObjectsChests;
			Settings.Default.OverlayESPObjectsContainer = Settings.OverlayESPObjectsContainer;
			Settings.Default.OverlayESPObjectsFishingPools = Settings.OverlayESPObjectsFishingPools;
			Settings.Default.OverlayESPObjectsLoots = Settings.OverlayESPObjectsLoots;
			Settings.Default.OverlayESPObjectsDistance = Settings.OverlayESPObjectsDistance;
			Settings.Default.OverlayESPUnits = Settings.OverlayESPUnits;
			Settings.Default.OverlayESPUnitsType = Settings.OverlayESPUnitsType;
			Settings.Default.OverlayESPUnitsDistance = Settings.OverlayESPUnitsDistance;
			Settings.Default.AddonVersion = Settings.AddonVersion;
			Settings.Default.AddonCheckOnStart = Settings.AddonCheckOnStart;
			Settings.Default.AddonAutoEquipWhite = Settings.AddonAutoEquipWhite;
			Settings.Default.AddonAutoEquipGreen = Settings.AddonAutoEquipGreen;
			Settings.Default.AddonAutoEquipBlue = Settings.AddonAutoEquipBlue;
			Settings.Default.AddonAutoEquipPurple = Settings.AddonAutoEquipPurple;
			Settings.Default.AddonAutoEquipBags = Settings.AddonAutoEquipBags;
			Settings.Default.AddonAutoDestroyJunklist = Settings.AddonAutoDestroyJunklist;
			Settings.Default.AddonAutoDestroyGreys = Settings.AddonAutoDestroyGreys;
			Settings.Default.AddonAutoDestroyWhites = Settings.AddonAutoDestroyWhites;
			Settings.Default.AddonAutoDestroyGreens = Settings.AddonAutoDestroyGreens;
			Settings.Default.AddonAutoDestroyBlues = Settings.AddonAutoDestroyBlues;
			Settings.Default.AddonAutoDestroyBOE = Settings.AddonAutoDestroyBOE;
			Settings.Default.MapsClassicVersion = Settings.MapsClassicVersion;
			Settings.Default.MapsRetailVersion = Settings.MapsRetailVersion;
			Settings.Default.NotificationsDiscord = Settings.NotificationsDiscord;
			Settings.Default.NotificationsDiscordUserID = Settings.NotificationsDiscordUserID;
			Settings.Default.NotificationsPushover = Settings.NotificationsPushover;
			Settings.Default.NotificationsPushoverToken = Settings.NotificationsPushoverToken;
			Settings.Default.NotificationsPushoverKey = Settings.NotificationsPushoverKey;
			Settings.Default.NotificationsWhisper = Settings.NotificationsWhisper;
			Settings.Default.NotificationsLevelUp = Settings.NotificationsLevelUp;
			Settings.Default.NotificationsGhost = Settings.NotificationsGhost;
			Settings.Default.NotificationsEvent = Settings.NotificationsEvent;
			Settings.Default.StoreFilterClassic = Settings.StoreFilterClassic;
			Settings.Default.StoreFilterClassicEra = Settings.StoreFilterClassicEra;
			Settings.Default.StoreFilterRetail = Settings.StoreFilterRetail;
			Settings.Default.StoreFilterFaction = Settings.StoreFilterFaction;
			Settings.Default.StoreFilterClass = Settings.StoreFilterClass;
			Settings.Default.StoreFilterProfileType = Settings.StoreFilterProfileType;
			Settings.Default.StoreFilterProfileSubType = Settings.StoreFilterProfileSubType;
			Settings.Default.StoreFilterRequiredLevel = Settings.StoreFilterRequiredLevel;
			Settings.Default.StoreFilterRequiredSkill = Settings.StoreFilterRequiredSkill;
			Settings.Default.Save();
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x0072C86C File Offset: 0x0072AA6C
		public static void ApplyOnStartBeforeReady()
		{
			_globals.PlayerName = PlayerMe.LocalName;
			_globals.IsInDungeon = PlayerMe.IsInDungeon;
			MDL.CheckDungeon = Convert.ToBoolean(!_globals.IsInDungeon || _globals.ModuleDungeon);
			if (_globals.IsInDungeon)
			{
				Tools.Console("Entered Dungeon: " + PlayerMe.ZoneName + ".", "", "richConsole", "frmMain", true);
			}
			_globals.IsInBattleground = PlayerMe.IsInBattleground;
			if (_globals.IsInBattleground)
			{
				Tools.Console("Entered Battleground: " + PlayerMe.BattlegroundName + ".", "", "richConsole", "frmMain", true);
			}
			if (!_globals.TestEnv["NoMeshMapLoad"])
			{
				while (!Pathfinder.LoadMeshMap(false))
				{
					Thread.Sleep(500);
				}
			}
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x0072C938 File Offset: 0x0072AB38
		public static void ApplyOnStartAfterReady()
		{
			Settings.SetCamera();
			if (!_globals.TestEnv["StartOverlay"])
			{
				frmMainOverlay.StartOverlay();
			}
			if (_globals.AutoStart)
			{
				_globals.Start = true;
				Walk.StartMonitoring();
			}
			_globals.PlayerClass = ObjectManager.Me.Class.ToString();
			Tools.Control("", "btnStart", "frmMain", true, false, false, false, 0);
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0072C9A8 File Offset: 0x0072ABA8
		public static void SetCamera()
		{
			try
			{
				IntPtr address = (IntPtr)Read.Combined<IntPtr>((IntPtr)Read.Single<IntPtr>(Offsets.Camera_Base) + Descriptors.Camera_Offset);
				ObjectManager.Camera.UpdateBaseAddress(address);
			}
			catch
			{
			}
		}

		// Token: 0x04000E9E RID: 3742
		public static Point WindowMainLocation = Settings.Default.WindowMainLocation;

		// Token: 0x04000E9F RID: 3743
		public static Size WindowMainSize = Settings.Default.WindowMainSize;

		// Token: 0x04000EA0 RID: 3744
		public static Point WindowProfileLocation = Settings.Default.WindowProfileLocation;

		// Token: 0x04000EA1 RID: 3745
		public static Size WindowProfileSize = Settings.Default.WindowProfileSize;

		// Token: 0x04000EA2 RID: 3746
		public static Size WindowProfileEventSize = Settings.Default.WindowProfileEventSize;

		// Token: 0x04000EA3 RID: 3747
		public static Point WindowRotationLocation = Settings.Default.WindowRotationLocation;

		// Token: 0x04000EA4 RID: 3748
		public static Size WindowRotationSize = Settings.Default.WindowRotationSize;

		// Token: 0x04000EA5 RID: 3749
		public static Size WindowRotationConditionSize = Settings.Default.WindowRotationConditionSize;

		// Token: 0x04000EA6 RID: 3750
		public static Point WindowStoreLocation = Settings.Default.WindowStoreLocation;

		// Token: 0x04000EA7 RID: 3751
		public static Size WindowStoreSize = Settings.Default.WindowStoreSize;

		// Token: 0x04000EA8 RID: 3752
		public static string License = Settings.Default.License;

		// Token: 0x04000EA9 RID: 3753
		public static bool FirstStart = Settings.Default.FirstStart;

		// Token: 0x04000EAA RID: 3754
		public static string OID = Settings.Default.OID;

		// Token: 0x04000EAB RID: 3755
		public static bool JackAutoDetectWindow = Settings.Default.JackAutoDetectWindow;

		// Token: 0x04000EAC RID: 3756
		public static bool JackTray = Settings.Default.JackTray;

		// Token: 0x04000EAD RID: 3757
		public static bool JackAutoReconnect = Settings.Default.JackAutoReconnect;

		// Token: 0x04000EAE RID: 3758
		public static string JackAutoReconnectPassword = Settings.Default.JackAutoReconnectPassword;

		// Token: 0x04000EAF RID: 3759
		public static string ProfilesDisplayMode = Settings.Default.ProfilesDisplayMode;

		// Token: 0x04000EB0 RID: 3760
		public static string RotationsDisplayMode = Settings.Default.RotationsDisplayMode;

		// Token: 0x04000EB1 RID: 3761
		public static string GameFolder = Settings.Default.GameFolder;

		// Token: 0x04000EB2 RID: 3762
		public static string AddonName = Settings.Default.AddonName;

		// Token: 0x04000EB3 RID: 3763
		public static string SelectedProfile = Settings.Default.SelectedProfile;

		// Token: 0x04000EB4 RID: 3764
		public static string SelectedRotation = Settings.Default.SelectedRotation;

		// Token: 0x04000EB5 RID: 3765
		public static bool RecorderAutoRecord = Settings.Default.RecorderAutoRecord;

		// Token: 0x04000EB6 RID: 3766
		public static int RecorderAutoDistance = Settings.Default.RecorderAutoDistance;

		// Token: 0x04000EB7 RID: 3767
		public static int RecorderShowMaxLastWaypoints = Settings.Default.RecorderShowMaxLastWaypoints;

		// Token: 0x04000EB8 RID: 3768
		public static bool RecorderQuestTracker = Settings.Default.RecorderQuestTracker;

		// Token: 0x04000EB9 RID: 3769
		public static bool OverlayGFXAntiAliasing = Settings.Default.OverlayGFXAntiAliasing;

		// Token: 0x04000EBA RID: 3770
		public static int OverlayGFXFPS = Settings.Default.OverlayGFXFPS;

		// Token: 0x04000EBB RID: 3771
		public static bool OverlayWaypoints = Settings.Default.OverlayWaypoints;

		// Token: 0x04000EBC RID: 3772
		public static int OverlayWaypointsDisplayRadius = Settings.Default.OverlayWaypointsDisplayRadius;

		// Token: 0x04000EBD RID: 3773
		public static bool OverlayMenuConsole = Settings.Default.OverlayMenuConsole;

		// Token: 0x04000EBE RID: 3774
		public static int OverlayMenuConsoleX = Settings.Default.OverlayMenuConsoleX;

		// Token: 0x04000EBF RID: 3775
		public static int OverlayMenuConsoleY = Settings.Default.OverlayMenuConsoleY;

		// Token: 0x04000EC0 RID: 3776
		public static bool OverlayMenuRecorder = Settings.Default.OverlayMenuRecorder;

		// Token: 0x04000EC1 RID: 3777
		public static int OverlayMenuRecorderX = Settings.Default.OverlayMenuRecorderX;

		// Token: 0x04000EC2 RID: 3778
		public static int OverlayMenuRecorderY = Settings.Default.OverlayMenuRecorderY;

		// Token: 0x04000EC3 RID: 3779
		public static bool OverlayMenuStartStop = Settings.Default.OverlayMenuStartStop;

		// Token: 0x04000EC4 RID: 3780
		public static int OverlayMenuStartStopX = Settings.Default.OverlayMenuStartStopX;

		// Token: 0x04000EC5 RID: 3781
		public static int OverlayMenuStartStopY = Settings.Default.OverlayMenuStartStopY;

		// Token: 0x04000EC6 RID: 3782
		public static bool OverlayESPObjectsHerbs = Settings.Default.OverlayESPObjectsHerbs;

		// Token: 0x04000EC7 RID: 3783
		public static bool OverlayESPObjectsOres = Settings.Default.OverlayESPObjectsOres;

		// Token: 0x04000EC8 RID: 3784
		public static bool OverlayESPObjectsSkinnables = Settings.Default.OverlayESPObjectsSkinnables;

		// Token: 0x04000EC9 RID: 3785
		public static bool OverlayESPObjectsGatherableMobs = Settings.Default.OverlayESPObjectsGatherableMobs;

		// Token: 0x04000ECA RID: 3786
		public static bool OverlayESPObjectsChests = Settings.Default.OverlayESPObjectsChests;

		// Token: 0x04000ECB RID: 3787
		public static bool OverlayESPObjectsContainer = Settings.Default.OverlayESPObjectsContainer;

		// Token: 0x04000ECC RID: 3788
		public static bool OverlayESPObjectsFishingPools = Settings.Default.OverlayESPObjectsFishingPools;

		// Token: 0x04000ECD RID: 3789
		public static bool OverlayESPObjectsLoots = Settings.Default.OverlayESPObjectsLoots;

		// Token: 0x04000ECE RID: 3790
		public static int OverlayESPObjectsDistance = Settings.Default.OverlayESPObjectsDistance;

		// Token: 0x04000ECF RID: 3791
		public static bool OverlayESPUnits = Settings.Default.OverlayESPUnits;

		// Token: 0x04000ED0 RID: 3792
		public static string OverlayESPUnitsType = Settings.Default.OverlayESPUnitsType;

		// Token: 0x04000ED1 RID: 3793
		public static int OverlayESPUnitsDistance = Settings.Default.OverlayESPUnitsDistance;

		// Token: 0x04000ED2 RID: 3794
		public static string AddonVersion = Settings.Default.AddonVersion;

		// Token: 0x04000ED3 RID: 3795
		public static bool AddonCheckOnStart = Settings.Default.AddonCheckOnStart;

		// Token: 0x04000ED4 RID: 3796
		public static bool AddonAutoEquipWhite = Settings.Default.AddonAutoEquipWhite;

		// Token: 0x04000ED5 RID: 3797
		public static bool AddonAutoEquipGreen = Settings.Default.AddonAutoEquipGreen;

		// Token: 0x04000ED6 RID: 3798
		public static bool AddonAutoEquipBlue = Settings.Default.AddonAutoEquipBlue;

		// Token: 0x04000ED7 RID: 3799
		public static bool AddonAutoEquipPurple = Settings.Default.AddonAutoEquipPurple;

		// Token: 0x04000ED8 RID: 3800
		public static bool AddonAutoEquipBags = Settings.Default.AddonAutoEquipBags;

		// Token: 0x04000ED9 RID: 3801
		public static List<string> AddonAutoDestroyJunklist = Settings.Default.AddonAutoDestroyJunklist;

		// Token: 0x04000EDA RID: 3802
		public static bool AddonAutoDestroyGreys = Settings.Default.AddonAutoDestroyGreys;

		// Token: 0x04000EDB RID: 3803
		public static bool AddonAutoDestroyWhites = Settings.Default.AddonAutoDestroyWhites;

		// Token: 0x04000EDC RID: 3804
		public static bool AddonAutoDestroyGreens = Settings.Default.AddonAutoDestroyGreens;

		// Token: 0x04000EDD RID: 3805
		public static bool AddonAutoDestroyBlues = Settings.Default.AddonAutoDestroyBlues;

		// Token: 0x04000EDE RID: 3806
		public static bool AddonAutoDestroyBOE = Settings.Default.AddonAutoDestroyBOE;

		// Token: 0x04000EDF RID: 3807
		public static string MapsClassicVersion = Settings.Default.MapsClassicVersion;

		// Token: 0x04000EE0 RID: 3808
		public static string MapsRetailVersion = Settings.Default.MapsRetailVersion;

		// Token: 0x04000EE1 RID: 3809
		public static bool NotificationsDiscord = Settings.Default.NotificationsDiscord;

		// Token: 0x04000EE2 RID: 3810
		public static string NotificationsDiscordUserID = Settings.Default.NotificationsDiscordUserID;

		// Token: 0x04000EE3 RID: 3811
		public static bool NotificationsPushover = Settings.Default.NotificationsPushover;

		// Token: 0x04000EE4 RID: 3812
		public static string NotificationsPushoverToken = Settings.Default.NotificationsPushoverToken;

		// Token: 0x04000EE5 RID: 3813
		public static string NotificationsPushoverKey = Settings.Default.NotificationsPushoverKey;

		// Token: 0x04000EE6 RID: 3814
		public static bool NotificationsWhisper = Settings.Default.NotificationsWhisper;

		// Token: 0x04000EE7 RID: 3815
		public static bool NotificationsLevelUp = Settings.Default.NotificationsLevelUp;

		// Token: 0x04000EE8 RID: 3816
		public static bool NotificationsGhost = Settings.Default.NotificationsGhost;

		// Token: 0x04000EE9 RID: 3817
		public static bool NotificationsEvent = Settings.Default.NotificationsEvent;

		// Token: 0x04000EEA RID: 3818
		public static bool StoreFilterClassic = Settings.Default.StoreFilterClassic;

		// Token: 0x04000EEB RID: 3819
		public static bool StoreFilterClassicEra = Settings.Default.StoreFilterClassicEra;

		// Token: 0x04000EEC RID: 3820
		public static bool StoreFilterRetail = Settings.Default.StoreFilterRetail;

		// Token: 0x04000EED RID: 3821
		public static string StoreFilterFaction = Settings.Default.StoreFilterFaction;

		// Token: 0x04000EEE RID: 3822
		public static string StoreFilterClass = Settings.Default.StoreFilterClass;

		// Token: 0x04000EEF RID: 3823
		public static string StoreFilterProfileType = Settings.Default.StoreFilterProfileType;

		// Token: 0x04000EF0 RID: 3824
		public static string StoreFilterProfileSubType = Settings.Default.StoreFilterProfileSubType;

		// Token: 0x04000EF1 RID: 3825
		public static string StoreFilterRequiredLevel = Settings.Default.StoreFilterRequiredLevel;

		// Token: 0x04000EF2 RID: 3826
		public static string StoreFilterRequiredSkill = Settings.Default.StoreFilterRequiredSkill;
	}
}
