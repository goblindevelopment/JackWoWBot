using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Windows.Forms;
using Jack.ATH;
using Jack.Models;
using Process.NET;
using Process.NET.Memory;

namespace Jack.Core
{
	// Token: 0x02000107 RID: 263
	public static class _globals
	{
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060017CB RID: 6091 RVA: 0x0071D104 File Offset: 0x0071B304
		// (set) Token: 0x060017CC RID: 6092 RVA: 0x0071D118 File Offset: 0x0071B318
		public static bool IsRetail { get; set; } = false;

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x0071D12C File Offset: 0x0071B32C
		// (set) Token: 0x060017CE RID: 6094 RVA: 0x0071D140 File Offset: 0x0071B340
		public static string ProcessFolder { get; set; } = "";

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0071D154 File Offset: 0x0071B354
		// (set) Token: 0x060017D0 RID: 6096 RVA: 0x0071D168 File Offset: 0x0071B368
		public static string HWID { get; set; } = "";

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0071D17C File Offset: 0x0071B37C
		// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0071D190 File Offset: 0x0071B390
		public static int GlobalCooldown { get; set; } = 1500;

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0071D1A4 File Offset: 0x0071B3A4
		// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0071D1B8 File Offset: 0x0071B3B8
		public static LCS LCS { get; set; } = new LCS();

		// Token: 0x060017D5 RID: 6101 RVA: 0x0071D1CC File Offset: 0x0071B3CC
		// Note: this type is marked as 'beforefieldinit'.
		static _globals()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["Classic"] = "";
			dictionary["ClassicPTR"] = "";
			dictionary["ClassicPrevious"] = "";
			dictionary["ClassicPTRPrevious"] = "";
			dictionary["ClassicEra"] = "";
			dictionary["ClassicEraPTR"] = "";
			dictionary["ClassicEraPrevious"] = "";
			dictionary["ClassicEraPTRPrevious"] = "";
			dictionary["Retail"] = "";
			dictionary["RetailPTR"] = "";
			dictionary["RetailPrevious"] = "";
			dictionary["RetailPTRPrevious"] = "";
			_globals.Builds = dictionary;
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2["Username"] = "";
			_globals.UserData = dictionary2;
			Dictionary<string, bool> dictionary3 = new Dictionary<string, bool>();
			dictionary3["AdministrationForms"] = false;
			dictionary3["Professions"] = false;
			dictionary3["Auras"] = false;
			dictionary3["StartOverlay"] = false;
			dictionary3["NoFlyCheck"] = false;
			dictionary3["NoCameraCheck"] = false;
			dictionary3["NoMeshMapLoad"] = false;
			dictionary3["TestMiningWithoutSkill"] = false;
			dictionary3["TestHerbalismWithoutSkill"] = false;
			dictionary3["OverlayTest"] = true;
			_globals.TestEnv = dictionary3;
		}

		// Token: 0x04000ABF RID: 2751
		public static string Version = "1.0.0.39";

		// Token: 0x04000AC0 RID: 2752
		public static string VersionTeam = "1.1.1.68";

		// Token: 0x04000AC1 RID: 2753
		public static string LatestVersion = "";

		// Token: 0x04000AC2 RID: 2754
		public static string LatestAddonVersion = "";

		// Token: 0x04000AC3 RID: 2755
		public static string LatestClassicMapsVersion = "";

		// Token: 0x04000AC4 RID: 2756
		public static string LatestRetailMapsVersion = "";

		// Token: 0x04000AC5 RID: 2757
		public static bool IsTeam = false;

		// Token: 0x04000AC6 RID: 2758
		public static bool ObjectManagerRetail = false;

		// Token: 0x04000AC7 RID: 2759
		public static bool IsClassic = false;

		// Token: 0x04000AC8 RID: 2760
		public static bool IsClassicEra = false;

		// Token: 0x04000ACA RID: 2762
		public static Dictionary<string, Dictionary<int, int>> OffsetsAndDescriptors = new Dictionary<string, Dictionary<int, int>>();

		// Token: 0x04000ACB RID: 2763
		public static string ProcessNameClassic = "WowClassic";

		// Token: 0x04000ACC RID: 2764
		public static string ExeNameClassic = "WowClassic.exe";

		// Token: 0x04000ACD RID: 2765
		public static string ProcessNameClassicPTR = "WowClassicT";

		// Token: 0x04000ACE RID: 2766
		public static string ExeNameClassicPTR = "WowClassicT.exe";

		// Token: 0x04000ACF RID: 2767
		public static string ProcessNameRetail = "Wow";

		// Token: 0x04000AD0 RID: 2768
		public static string ExeNameRetail = "Wow.exe";

		// Token: 0x04000AD1 RID: 2769
		public static string ProcessNameRetailPTR = "WowT";

		// Token: 0x04000AD2 RID: 2770
		public static string ExeNameRetailPTR = "WowT.exe";

		// Token: 0x04000AD3 RID: 2771
		public static string ProcessNameCustom_1 = "WowClassicB";

		// Token: 0x04000AD4 RID: 2772
		public static string ExeNameCustom_1 = "WowClassicB.exe";

		// Token: 0x04000AD5 RID: 2773
		public static string ProcessName = "";

		// Token: 0x04000AD6 RID: 2774
		public static string ExeName = "";

		// Token: 0x04000AD8 RID: 2776
		public static string DetectedBuild = "";

		// Token: 0x04000AD9 RID: 2777
		public static IntPtr processHandle;

		// Token: 0x04000ADA RID: 2778
		public static int processID;

		// Token: 0x04000ADB RID: 2779
		public static IntPtr MyHandle = 0;

		// Token: 0x04000ADC RID: 2780
		public static IntPtr MyHandleProfile = 0;

		// Token: 0x04000ADD RID: 2781
		public static IntPtr MyHandleProfileEvent = 0;

		// Token: 0x04000ADE RID: 2782
		public static IntPtr OverlayHandle = 0;

		// Token: 0x04000ADF RID: 2783
		public static bool WindowEnabled = true;

		// Token: 0x04000AE1 RID: 2785
		public static string JackFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).Replace("\\Data", "");

		// Token: 0x04000AE2 RID: 2786
		public static string JackExe = AppDomain.CurrentDomain.FriendlyName;

		// Token: 0x04000AE3 RID: 2787
		public static string Jack = _globals.JackFolder + "\\" + _globals.JackExe;

		// Token: 0x04000AE4 RID: 2788
		public static string JackProfiles = _globals.JackFolder + "\\Profiles";

		// Token: 0x04000AE5 RID: 2789
		public static string JackUtilities = _globals.JackFolder + "\\Profiles\\Utilities";

		// Token: 0x04000AE6 RID: 2790
		public static string JackRotations = _globals.JackFolder + "\\Rotations";

		// Token: 0x04000AE7 RID: 2791
		public static string JackData = _globals.JackFolder + "\\Data";

		// Token: 0x04000AE8 RID: 2792
		public static string JackDownloads = _globals.JackFolder + "\\Downloads";

		// Token: 0x04000AE9 RID: 2793
		public static string JackUpdates = _globals.JackFolder + "\\Downloads\\Update";

		// Token: 0x04000AEA RID: 2794
		public static string JackPathfinder = _globals.JackData + "\\Pathfinder";

		// Token: 0x04000AEB RID: 2795
		public static string JackLogs = _globals.JackData + "\\Log";

		// Token: 0x04000AEC RID: 2796
		public static List<Form> JackForms = new List<Form>();

		// Token: 0x04000AED RID: 2797
		public static bool JackFormsPreLoad = false;

		// Token: 0x04000AEE RID: 2798
		public static bool ModuleGather = false;

		// Token: 0x04000AEF RID: 2799
		public static bool ModuleDungeon = false;

		// Token: 0x04000AF0 RID: 2800
		public static bool ModuleNotifications = false;

		// Token: 0x04000AF1 RID: 2801
		public static int ModuleMultiSession = 1;

		// Token: 0x04000AF2 RID: 2802
		public static PrivateFontCollection Fonts = new PrivateFontCollection();

		// Token: 0x04000AF3 RID: 2803
		public static IProcess processHandleRead;

		// Token: 0x04000AF4 RID: 2804
		public static IPointer processPointerRead;

		// Token: 0x04000AF5 RID: 2805
		public static IntPtr processHandleWrite;

		// Token: 0x04000AF6 RID: 2806
		public static IntPtr processPointerWrite;

		// Token: 0x04000AF7 RID: 2807
		public static IntPtr baseObjectManager;

		// Token: 0x04000AF8 RID: 2808
		public static UInt128 playerGUID128;

		// Token: 0x04000AF9 RID: 2809
		public static UInt128 petGUID128;

		// Token: 0x04000AFA RID: 2810
		public static IntPtr playerBaseAddress = IntPtr.Zero;

		// Token: 0x04000AFB RID: 2811
		public static IntPtr petBaseAddress = IntPtr.Zero;

		// Token: 0x04000AFD RID: 2813
		public static bool Start;

		// Token: 0x04000AFE RID: 2814
		public static bool GameOpen;

		// Token: 0x04000AFF RID: 2815
		public static bool IsInWorld;

		// Token: 0x04000B00 RID: 2816
		public static bool Ready;

		// Token: 0x04000B01 RID: 2817
		public static bool IsInDungeon;

		// Token: 0x04000B02 RID: 2818
		public static bool IsInBattleground;

		// Token: 0x04000B03 RID: 2819
		public static bool IsPVP;

		// Token: 0x04000B04 RID: 2820
		public static bool PathfinderClassicReady;

		// Token: 0x04000B05 RID: 2821
		public static bool PathfinderRetailReady;

		// Token: 0x04000B06 RID: 2822
		public static bool NoCheck = false;

		// Token: 0x04000B07 RID: 2823
		public static bool AutoStart = false;

		// Token: 0x04000B08 RID: 2824
		public static string PlayerName = "";

		// Token: 0x04000B09 RID: 2825
		public static string PlayerClass = "";

		// Token: 0x04000B0A RID: 2826
		public static bool Record;

		// Token: 0x04000B0B RID: 2827
		public static bool ShowProfile = Settings.OverlayWaypoints;

		// Token: 0x04000B0C RID: 2828
		public static bool ShowRecordedProfile;

		// Token: 0x04000B0D RID: 2829
		public static bool ShowClimbSpots;

		// Token: 0x04000B0E RID: 2830
		public static bool ShowClimbSpotsConnections;

		// Token: 0x04000B0F RID: 2831
		public static bool ShowOverlayMenuProfilePreview;

		// Token: 0x04000B10 RID: 2832
		public static List<int> List_MeshMapIDs = new List<int>();

		// Token: 0x04000B11 RID: 2833
		public static Dictionary<int, int> List_Herbalism = new Dictionary<int, int>();

		// Token: 0x04000B12 RID: 2834
		public static List<int> List_HerbalismMobs = new List<int>();

		// Token: 0x04000B13 RID: 2835
		public static Dictionary<int, int> List_Mining = new Dictionary<int, int>();

		// Token: 0x04000B14 RID: 2836
		public static List<int> List_MiningMobs = new List<int>();

		// Token: 0x04000B15 RID: 2837
		public static List<int> List_Skinning = new List<int>();

		// Token: 0x04000B16 RID: 2838
		public static List<int> List_Container = new List<int>();

		// Token: 0x04000B17 RID: 2839
		public static List<int> List_FishingPools = new List<int>();

		// Token: 0x04000B18 RID: 2840
		public static Dictionary<int, string> List_Spells = new Dictionary<int, string>();

		// Token: 0x04000B19 RID: 2841
		public static Dictionary<int, string> List_Zones = new Dictionary<int, string>();

		// Token: 0x04000B1A RID: 2842
		public static Dictionary<int, string> List_ZonesContinents = new Dictionary<int, string>();

		// Token: 0x04000B1B RID: 2843
		public static Dictionary<int, string> List_Cities = new Dictionary<int, string>();

		// Token: 0x04000B1C RID: 2844
		public static Dictionary<int, string> List_Dungeons = new Dictionary<int, string>();

		// Token: 0x04000B1D RID: 2845
		public static Dictionary<int, string> List_Battlegrounds = new Dictionary<int, string>();

		// Token: 0x04000B1E RID: 2846
		public static Dictionary<int, string> List_Items = new Dictionary<int, string>();

		// Token: 0x04000B1F RID: 2847
		public static Dictionary<int, string> List_FishingPoles = new Dictionary<int, string>();

		// Token: 0x04000B20 RID: 2848
		public static Dictionary<int, string> List_FishingBaits = new Dictionary<int, string>();

		// Token: 0x04000B21 RID: 2849
		public static Dictionary<int, string> List_FlightPoints = new Dictionary<int, string>();

		// Token: 0x04000B22 RID: 2850
		public static Dictionary<int, string> List_Transports = new Dictionary<int, string>();

		// Token: 0x04000B23 RID: 2851
		public static List<FromList> List_PathfinderVendor = new List<FromList>();

		// Token: 0x04000B24 RID: 2852
		public static List<FromList> List_PathfinderTrainer = new List<FromList>();

		// Token: 0x04000B25 RID: 2853
		public static List<FromList> List_PathfinderInnkeeper = new List<FromList>();

		// Token: 0x04000B26 RID: 2854
		public static List<FromList> List_PathfinderBank = new List<FromList>();

		// Token: 0x04000B27 RID: 2855
		public static List<FromList> List_PathfinderFlightMaster = new List<FromList>();

		// Token: 0x04000B28 RID: 2856
		public static List<FromList> List_PathfinderMailbox = new List<FromList>();

		// Token: 0x04000B29 RID: 2857
		public static List<FromList> List_PathfinderPortal = new List<FromList>();

		// Token: 0x04000B2A RID: 2858
		public static Dictionary<int, int> List_PathfinderFood = new Dictionary<int, int>();

		// Token: 0x04000B2B RID: 2859
		public static Dictionary<int, int> List_PathfinderDrink = new Dictionary<int, int>();

		// Token: 0x04000B2C RID: 2860
		public static Dictionary<int, int> List_PathfinderArrows = new Dictionary<int, int>();

		// Token: 0x04000B2D RID: 2861
		public static Dictionary<int, int> List_PathfinderBullets = new Dictionary<int, int>();

		// Token: 0x04000B2E RID: 2862
		public static List<int> List_PathfinderReagents = new List<int>();

		// Token: 0x04000B2F RID: 2863
		public static List<Vector3> Waypoints = new List<Vector3>();

		// Token: 0x04000B30 RID: 2864
		public static List<Events> Events = new List<Events>();

		// Token: 0x04000B31 RID: 2865
		public static List<ProfileSettings> ProfileSettings = new List<ProfileSettings>();

		// Token: 0x04000B32 RID: 2866
		public static object _lockEvents = new object();

		// Token: 0x04000B33 RID: 2867
		public static List<Vector3> WaypointsOverlayMenuPreview = new List<Vector3>();

		// Token: 0x04000B34 RID: 2868
		public static List<Rotation> Rotation = new List<Rotation>();

		// Token: 0x04000B35 RID: 2869
		public static List<RotationSettings> RotationSettings = new List<RotationSettings>();

		// Token: 0x04000B36 RID: 2870
		public static List<Keybinds> Keybinds = new List<Keybinds>();

		// Token: 0x04000B37 RID: 2871
		public static Dictionary<string, string> Keys = new Dictionary<string, string>();

		// Token: 0x04000B38 RID: 2872
		public static Dictionary<string, bool> KeyStatus = new Dictionary<string, bool>();

		// Token: 0x04000B3A RID: 2874
		public static string LCSEnc = "";

		// Token: 0x04000B3B RID: 2875
		public static bool IsPremiumProfile = false;

		// Token: 0x04000B3C RID: 2876
		public static List<PFLS> PremiumProfiles = new List<PFLS>();

		// Token: 0x04000B3D RID: 2877
		public static List<PremiumSettings> PremiumSettings = new List<PremiumSettings>();

		// Token: 0x04000B3E RID: 2878
		public static PFLS PremiumMasterProfile = null;

		// Token: 0x04000B3F RID: 2879
		public static PFLS PremiumLoadedProfile = null;

		// Token: 0x04000B40 RID: 2880
		public static PremiumSettings PremiumLoadedProfileSettings = null;

		// Token: 0x04000B41 RID: 2881
		public static List<StuckPaths> StuckPaths = new List<StuckPaths>();

		// Token: 0x04000B42 RID: 2882
		public static List<MSG> Messages = new List<MSG>();

		// Token: 0x04000B43 RID: 2883
		public static List<int> QuestIDsCompleted = new List<int>();

		// Token: 0x04000B44 RID: 2884
		public static string QuestIDsCompletedPlayerName = "";

		// Token: 0x04000B45 RID: 2885
		public static Dictionary<string, string> Builds;

		// Token: 0x04000B46 RID: 2886
		public static Dictionary<string, string> UserData;

		// Token: 0x04000B47 RID: 2887
		public static Dictionary<string, bool> TestEnv;
	}
}
