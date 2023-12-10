using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Jack.Properties
{
	// Token: 0x0200002E RID: 46
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0067042C File Offset: 0x0066E62C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00670440 File Offset: 0x0066E640
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00670460 File Offset: 0x0066E660
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool OverlayGFXAntiAliasing
		{
			get
			{
				return (bool)this["OverlayGFXAntiAliasing"];
			}
			set
			{
				this["OverlayGFXAntiAliasing"] = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00670480 File Offset: 0x0066E680
		// (set) Token: 0x0600030B RID: 779 RVA: 0x006704A0 File Offset: 0x0066E6A0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("30")]
		public int OverlayGFXFPS
		{
			get
			{
				return (int)this["OverlayGFXFPS"];
			}
			set
			{
				this["OverlayGFXFPS"] = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600030C RID: 780 RVA: 0x006704C0 File Offset: 0x0066E6C0
		// (set) Token: 0x0600030D RID: 781 RVA: 0x006704E0 File Offset: 0x0066E6E0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPObjectsHerbs
		{
			get
			{
				return (bool)this["OverlayESPObjectsHerbs"];
			}
			set
			{
				this["OverlayESPObjectsHerbs"] = value;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00670500 File Offset: 0x0066E700
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00670520 File Offset: 0x0066E720
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPObjectsOres
		{
			get
			{
				return (bool)this["OverlayESPObjectsOres"];
			}
			set
			{
				this["OverlayESPObjectsOres"] = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00670540 File Offset: 0x0066E740
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00670560 File Offset: 0x0066E760
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPUnits
		{
			get
			{
				return (bool)this["OverlayESPUnits"];
			}
			set
			{
				this["OverlayESPUnits"] = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00670580 File Offset: 0x0066E780
		// (set) Token: 0x06000313 RID: 787 RVA: 0x006705A0 File Offset: 0x0066E7A0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("None")]
		public string OverlayESPUnitsType
		{
			get
			{
				return (string)this["OverlayESPUnitsType"];
			}
			set
			{
				this["OverlayESPUnitsType"] = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000314 RID: 788 RVA: 0x006705BC File Offset: 0x0066E7BC
		// (set) Token: 0x06000315 RID: 789 RVA: 0x006705DC File Offset: 0x0066E7DC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public int OverlayESPUnitsDistance
		{
			get
			{
				return (int)this["OverlayESPUnitsDistance"];
			}
			set
			{
				this["OverlayESPUnitsDistance"] = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000316 RID: 790 RVA: 0x006705FC File Offset: 0x0066E7FC
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0067061C File Offset: 0x0066E81C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("10")]
		public int RecorderAutoDistance
		{
			get
			{
				return (int)this["RecorderAutoDistance"];
			}
			set
			{
				this["RecorderAutoDistance"] = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0067063C File Offset: 0x0066E83C
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0067065C File Offset: 0x0066E85C
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool RecorderAutoRecord
		{
			get
			{
				return (bool)this["RecorderAutoRecord"];
			}
			set
			{
				this["RecorderAutoRecord"] = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0067067C File Offset: 0x0066E87C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0067069C File Offset: 0x0066E89C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string SelectedProfile
		{
			get
			{
				return (string)this["SelectedProfile"];
			}
			set
			{
				this["SelectedProfile"] = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600031C RID: 796 RVA: 0x006706B8 File Offset: 0x0066E8B8
		// (set) Token: 0x0600031D RID: 797 RVA: 0x006706D8 File Offset: 0x0066E8D8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool OverlayWaypoints
		{
			get
			{
				return (bool)this["OverlayWaypoints"];
			}
			set
			{
				this["OverlayWaypoints"] = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600031E RID: 798 RVA: 0x006706F8 File Offset: 0x0066E8F8
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00670718 File Offset: 0x0066E918
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPObjectsSkinnables
		{
			get
			{
				return (bool)this["OverlayESPObjectsSkinnables"];
			}
			set
			{
				this["OverlayESPObjectsSkinnables"] = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00670738 File Offset: 0x0066E938
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00670758 File Offset: 0x0066E958
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string SelectedRotation
		{
			get
			{
				return (string)this["SelectedRotation"];
			}
			set
			{
				this["SelectedRotation"] = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00670774 File Offset: 0x0066E974
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00670794 File Offset: 0x0066E994
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPObjectsChests
		{
			get
			{
				return (bool)this["OverlayESPObjectsChests"];
			}
			set
			{
				this["OverlayESPObjectsChests"] = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000324 RID: 804 RVA: 0x006707B4 File Offset: 0x0066E9B4
		// (set) Token: 0x06000325 RID: 805 RVA: 0x006707D4 File Offset: 0x0066E9D4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string GameFolder
		{
			get
			{
				return (string)this["GameFolder"];
			}
			set
			{
				this["GameFolder"] = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000326 RID: 806 RVA: 0x006707F0 File Offset: 0x0066E9F0
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00670810 File Offset: 0x0066EA10
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string AddonName
		{
			get
			{
				return (string)this["AddonName"];
			}
			set
			{
				this["AddonName"] = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0067082C File Offset: 0x0066EA2C
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0067084C File Offset: 0x0066EA4C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public int OverlayWaypointsDisplayRadius
		{
			get
			{
				return (int)this["OverlayWaypointsDisplayRadius"];
			}
			set
			{
				this["OverlayWaypointsDisplayRadius"] = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0067086C File Offset: 0x0066EA6C
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0067088C File Offset: 0x0066EA8C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("20")]
		public int RecorderShowMaxLastWaypoints
		{
			get
			{
				return (int)this["RecorderShowMaxLastWaypoints"];
			}
			set
			{
				this["RecorderShowMaxLastWaypoints"] = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600032C RID: 812 RVA: 0x006708AC File Offset: 0x0066EAAC
		// (set) Token: 0x0600032D RID: 813 RVA: 0x006708CC File Offset: 0x0066EACC
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string License
		{
			get
			{
				return (string)this["License"];
			}
			set
			{
				this["License"] = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600032E RID: 814 RVA: 0x006708E8 File Offset: 0x0066EAE8
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00670908 File Offset: 0x0066EB08
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool FirstStart
		{
			get
			{
				return (bool)this["FirstStart"];
			}
			set
			{
				this["FirstStart"] = value;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00670928 File Offset: 0x0066EB28
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00670948 File Offset: 0x0066EB48
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AddonAutoEquipWhite
		{
			get
			{
				return (bool)this["AddonAutoEquipWhite"];
			}
			set
			{
				this["AddonAutoEquipWhite"] = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00670968 File Offset: 0x0066EB68
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00670988 File Offset: 0x0066EB88
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AddonAutoEquipGreen
		{
			get
			{
				return (bool)this["AddonAutoEquipGreen"];
			}
			set
			{
				this["AddonAutoEquipGreen"] = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000334 RID: 820 RVA: 0x006709A8 File Offset: 0x0066EBA8
		// (set) Token: 0x06000335 RID: 821 RVA: 0x006709C8 File Offset: 0x0066EBC8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AddonAutoEquipBlue
		{
			get
			{
				return (bool)this["AddonAutoEquipBlue"];
			}
			set
			{
				this["AddonAutoEquipBlue"] = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000336 RID: 822 RVA: 0x006709E8 File Offset: 0x0066EBE8
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00670A08 File Offset: 0x0066EC08
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AddonAutoEquipPurple
		{
			get
			{
				return (bool)this["AddonAutoEquipPurple"];
			}
			set
			{
				this["AddonAutoEquipPurple"] = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00670A28 File Offset: 0x0066EC28
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00670A48 File Offset: 0x0066EC48
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AddonAutoEquipBags
		{
			get
			{
				return (bool)this["AddonAutoEquipBags"];
			}
			set
			{
				this["AddonAutoEquipBags"] = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00670A68 File Offset: 0x0066EC68
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00670A88 File Offset: 0x0066EC88
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string AddonVersion
		{
			get
			{
				return (string)this["AddonVersion"];
			}
			set
			{
				this["AddonVersion"] = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00670AA4 File Offset: 0x0066ECA4
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00670AC4 File Offset: 0x0066ECC4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPObjectsLoots
		{
			get
			{
				return (bool)this["OverlayESPObjectsLoots"];
			}
			set
			{
				this["OverlayESPObjectsLoots"] = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00670AE4 File Offset: 0x0066ECE4
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00670B04 File Offset: 0x0066ED04
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool OverlayMenuConsole
		{
			get
			{
				return (bool)this["OverlayMenuConsole"];
			}
			set
			{
				this["OverlayMenuConsole"] = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00670B24 File Offset: 0x0066ED24
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00670B44 File Offset: 0x0066ED44
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public int OverlayMenuConsoleX
		{
			get
			{
				return (int)this["OverlayMenuConsoleX"];
			}
			set
			{
				this["OverlayMenuConsoleX"] = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00670B64 File Offset: 0x0066ED64
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00670B84 File Offset: 0x0066ED84
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int OverlayMenuConsoleY
		{
			get
			{
				return (int)this["OverlayMenuConsoleY"];
			}
			set
			{
				this["OverlayMenuConsoleY"] = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00670BA4 File Offset: 0x0066EDA4
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00670BC4 File Offset: 0x0066EDC4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int OverlayMenuRecorderX
		{
			get
			{
				return (int)this["OverlayMenuRecorderX"];
			}
			set
			{
				this["OverlayMenuRecorderX"] = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00670BE4 File Offset: 0x0066EDE4
		// (set) Token: 0x06000347 RID: 839 RVA: 0x00670C04 File Offset: 0x0066EE04
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int OverlayMenuRecorderY
		{
			get
			{
				return (int)this["OverlayMenuRecorderY"];
			}
			set
			{
				this["OverlayMenuRecorderY"] = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00670C24 File Offset: 0x0066EE24
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00670C44 File Offset: 0x0066EE44
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool OverlayMenuRecorder
		{
			get
			{
				return (bool)this["OverlayMenuRecorder"];
			}
			set
			{
				this["OverlayMenuRecorder"] = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00670C64 File Offset: 0x0066EE64
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00670C84 File Offset: 0x0066EE84
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool OverlayMenuStartStop
		{
			get
			{
				return (bool)this["OverlayMenuStartStop"];
			}
			set
			{
				this["OverlayMenuStartStop"] = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00670CA4 File Offset: 0x0066EEA4
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00670CC4 File Offset: 0x0066EEC4
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		[UserScopedSetting]
		public int OverlayMenuStartStopX
		{
			get
			{
				return (int)this["OverlayMenuStartStopX"];
			}
			set
			{
				this["OverlayMenuStartStopX"] = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00670CE4 File Offset: 0x0066EEE4
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00670D04 File Offset: 0x0066EF04
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int OverlayMenuStartStopY
		{
			get
			{
				return (int)this["OverlayMenuStartStopY"];
			}
			set
			{
				this["OverlayMenuStartStopY"] = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00670D60 File Offset: 0x0066EF60
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00670D80 File Offset: 0x0066EF80
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AddonAutoDestroyGreys
		{
			get
			{
				return (bool)this["AddonAutoDestroyGreys"];
			}
			set
			{
				this["AddonAutoDestroyGreys"] = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00670DA0 File Offset: 0x0066EFA0
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00670DC0 File Offset: 0x0066EFC0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool AddonAutoDestroyWhites
		{
			get
			{
				return (bool)this["AddonAutoDestroyWhites"];
			}
			set
			{
				this["AddonAutoDestroyWhites"] = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00670DE0 File Offset: 0x0066EFE0
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00670E00 File Offset: 0x0066F000
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AddonAutoDestroyGreens
		{
			get
			{
				return (bool)this["AddonAutoDestroyGreens"];
			}
			set
			{
				this["AddonAutoDestroyGreens"] = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00670E20 File Offset: 0x0066F020
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00670E40 File Offset: 0x0066F040
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AddonAutoDestroyBlues
		{
			get
			{
				return (bool)this["AddonAutoDestroyBlues"];
			}
			set
			{
				this["AddonAutoDestroyBlues"] = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00670E60 File Offset: 0x0066F060
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00670E80 File Offset: 0x0066F080
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AddonAutoDestroyBOE
		{
			get
			{
				return (bool)this["AddonAutoDestroyBOE"];
			}
			set
			{
				this["AddonAutoDestroyBOE"] = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00670EA0 File Offset: 0x0066F0A0
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00670EC0 File Offset: 0x0066F0C0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Point WindowMainLocation
		{
			get
			{
				return (Point)this["WindowMainLocation"];
			}
			set
			{
				this["WindowMainLocation"] = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00670EE0 File Offset: 0x0066F0E0
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00670F00 File Offset: 0x0066F100
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Size WindowMainSize
		{
			get
			{
				return (Size)this["WindowMainSize"];
			}
			set
			{
				this["WindowMainSize"] = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00670F20 File Offset: 0x0066F120
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00670F40 File Offset: 0x0066F140
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("List")]
		public string ProfilesDisplayMode
		{
			get
			{
				return (string)this["ProfilesDisplayMode"];
			}
			set
			{
				this["ProfilesDisplayMode"] = value;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00670F5C File Offset: 0x0066F15C
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00670F7C File Offset: 0x0066F17C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("List")]
		public string RotationsDisplayMode
		{
			get
			{
				return (string)this["RotationsDisplayMode"];
			}
			set
			{
				this["RotationsDisplayMode"] = value;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00670F98 File Offset: 0x0066F198
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00670FB8 File Offset: 0x0066F1B8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("100")]
		public int OverlayESPObjectsDistance
		{
			get
			{
				return (int)this["OverlayESPObjectsDistance"];
			}
			set
			{
				this["OverlayESPObjectsDistance"] = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00670FD8 File Offset: 0x0066F1D8
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00670FF8 File Offset: 0x0066F1F8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Point WindowProfileLocation
		{
			get
			{
				return (Point)this["WindowProfileLocation"];
			}
			set
			{
				this["WindowProfileLocation"] = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00671018 File Offset: 0x0066F218
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00671038 File Offset: 0x0066F238
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		[UserScopedSetting]
		public Size WindowProfileSize
		{
			get
			{
				return (Size)this["WindowProfileSize"];
			}
			set
			{
				this["WindowProfileSize"] = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00671058 File Offset: 0x0066F258
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00671078 File Offset: 0x0066F278
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Size WindowProfileEventSize
		{
			get
			{
				return (Size)this["WindowProfileEventSize"];
			}
			set
			{
				this["WindowProfileEventSize"] = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00671098 File Offset: 0x0066F298
		// (set) Token: 0x0600036D RID: 877 RVA: 0x006710B8 File Offset: 0x0066F2B8
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		[UserScopedSetting]
		public Point WindowRotationLocation
		{
			get
			{
				return (Point)this["WindowRotationLocation"];
			}
			set
			{
				this["WindowRotationLocation"] = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600036E RID: 878 RVA: 0x006710D8 File Offset: 0x0066F2D8
		// (set) Token: 0x0600036F RID: 879 RVA: 0x006710F8 File Offset: 0x0066F2F8
		[DefaultSettingValue("0, 0")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public Size WindowRotationSize
		{
			get
			{
				return (Size)this["WindowRotationSize"];
			}
			set
			{
				this["WindowRotationSize"] = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00671118 File Offset: 0x0066F318
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00671138 File Offset: 0x0066F338
		[DefaultSettingValue("0, 0")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public Size WindowRotationConditionSize
		{
			get
			{
				return (Size)this["WindowRotationConditionSize"];
			}
			set
			{
				this["WindowRotationConditionSize"] = value;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00671158 File Offset: 0x0066F358
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00671178 File Offset: 0x0066F378
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Bully
		{
			get
			{
				return (string)this["Bully"];
			}
			set
			{
				this["Bully"] = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00671194 File Offset: 0x0066F394
		// (set) Token: 0x06000375 RID: 885 RVA: 0x006711B4 File Offset: 0x0066F3B4
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string OID
		{
			get
			{
				return (string)this["OID"];
			}
			set
			{
				this["OID"] = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000376 RID: 886 RVA: 0x006711D0 File Offset: 0x0066F3D0
		// (set) Token: 0x06000377 RID: 887 RVA: 0x006711F0 File Offset: 0x0066F3F0
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool JackAutoDetectWindow
		{
			get
			{
				return (bool)this["JackAutoDetectWindow"];
			}
			set
			{
				this["JackAutoDetectWindow"] = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00671210 File Offset: 0x0066F410
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00671230 File Offset: 0x0066F430
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool NotificationsDiscord
		{
			get
			{
				return (bool)this["NotificationsDiscord"];
			}
			set
			{
				this["NotificationsDiscord"] = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00671250 File Offset: 0x0066F450
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00671270 File Offset: 0x0066F470
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string NotificationsDiscordUserID
		{
			get
			{
				return (string)this["NotificationsDiscordUserID"];
			}
			set
			{
				this["NotificationsDiscordUserID"] = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0067128C File Offset: 0x0066F48C
		// (set) Token: 0x0600037D RID: 893 RVA: 0x006712AC File Offset: 0x0066F4AC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool NotificationsPushover
		{
			get
			{
				return (bool)this["NotificationsPushover"];
			}
			set
			{
				this["NotificationsPushover"] = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600037E RID: 894 RVA: 0x006712CC File Offset: 0x0066F4CC
		// (set) Token: 0x0600037F RID: 895 RVA: 0x006712EC File Offset: 0x0066F4EC
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string NotificationsPushoverToken
		{
			get
			{
				return (string)this["NotificationsPushoverToken"];
			}
			set
			{
				this["NotificationsPushoverToken"] = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00671308 File Offset: 0x0066F508
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00671328 File Offset: 0x0066F528
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		[UserScopedSetting]
		public string NotificationsPushoverKey
		{
			get
			{
				return (string)this["NotificationsPushoverKey"];
			}
			set
			{
				this["NotificationsPushoverKey"] = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00671344 File Offset: 0x0066F544
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00671364 File Offset: 0x0066F564
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool NotificationsWhisper
		{
			get
			{
				return (bool)this["NotificationsWhisper"];
			}
			set
			{
				this["NotificationsWhisper"] = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00671384 File Offset: 0x0066F584
		// (set) Token: 0x06000385 RID: 901 RVA: 0x006713A4 File Offset: 0x0066F5A4
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool NotificationsLevelUp
		{
			get
			{
				return (bool)this["NotificationsLevelUp"];
			}
			set
			{
				this["NotificationsLevelUp"] = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000386 RID: 902 RVA: 0x006713C4 File Offset: 0x0066F5C4
		// (set) Token: 0x06000387 RID: 903 RVA: 0x006713E4 File Offset: 0x0066F5E4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool NotificationsGhost
		{
			get
			{
				return (bool)this["NotificationsGhost"];
			}
			set
			{
				this["NotificationsGhost"] = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00671404 File Offset: 0x0066F604
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00671424 File Offset: 0x0066F624
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Point WindowTeamLocation
		{
			get
			{
				return (Point)this["WindowTeamLocation"];
			}
			set
			{
				this["WindowTeamLocation"] = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00671444 File Offset: 0x0066F644
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00671464 File Offset: 0x0066F664
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Size WindowTeamSize
		{
			get
			{
				return (Size)this["WindowTeamSize"];
			}
			set
			{
				this["WindowTeamSize"] = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00671484 File Offset: 0x0066F684
		// (set) Token: 0x0600038D RID: 909 RVA: 0x006714A4 File Offset: 0x0066F6A4
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		[UserScopedSetting]
		public Point WindowTeamStoreLocation
		{
			get
			{
				return (Point)this["WindowTeamStoreLocation"];
			}
			set
			{
				this["WindowTeamStoreLocation"] = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600038E RID: 910 RVA: 0x006714C4 File Offset: 0x0066F6C4
		// (set) Token: 0x0600038F RID: 911 RVA: 0x006714E4 File Offset: 0x0066F6E4
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		[UserScopedSetting]
		public Size WindowTeamStoreSize
		{
			get
			{
				return (Size)this["WindowTeamStoreSize"];
			}
			set
			{
				this["WindowTeamStoreSize"] = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00671504 File Offset: 0x0066F704
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00671524 File Offset: 0x0066F724
		[DefaultSettingValue("0, 0")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public Size WindowTeamStoreUpdateSize
		{
			get
			{
				return (Size)this["WindowTeamStoreUpdateSize"];
			}
			set
			{
				this["WindowTeamStoreUpdateSize"] = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00671544 File Offset: 0x0066F744
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00671564 File Offset: 0x0066F764
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Size WindowTeamStoreCreateSize
		{
			get
			{
				return (Size)this["WindowTeamStoreCreateSize"];
			}
			set
			{
				this["WindowTeamStoreCreateSize"] = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00671584 File Offset: 0x0066F784
		// (set) Token: 0x06000395 RID: 917 RVA: 0x006715A4 File Offset: 0x0066F7A4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Point WindowStoreLocation
		{
			get
			{
				return (Point)this["WindowStoreLocation"];
			}
			set
			{
				this["WindowStoreLocation"] = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000396 RID: 918 RVA: 0x006715C4 File Offset: 0x0066F7C4
		// (set) Token: 0x06000397 RID: 919 RVA: 0x006715E4 File Offset: 0x0066F7E4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0, 0")]
		public Size WindowStoreSize
		{
			get
			{
				return (Size)this["WindowStoreSize"];
			}
			set
			{
				this["WindowStoreSize"] = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00671604 File Offset: 0x0066F804
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00671624 File Offset: 0x0066F824
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool StoreFilterClassic
		{
			get
			{
				return (bool)this["StoreFilterClassic"];
			}
			set
			{
				this["StoreFilterClassic"] = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00671644 File Offset: 0x0066F844
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00671664 File Offset: 0x0066F864
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool StoreFilterClassicEra
		{
			get
			{
				return (bool)this["StoreFilterClassicEra"];
			}
			set
			{
				this["StoreFilterClassicEra"] = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00671684 File Offset: 0x0066F884
		// (set) Token: 0x0600039D RID: 925 RVA: 0x006716A4 File Offset: 0x0066F8A4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool StoreFilterRetail
		{
			get
			{
				return (bool)this["StoreFilterRetail"];
			}
			set
			{
				this["StoreFilterRetail"] = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600039E RID: 926 RVA: 0x006716C4 File Offset: 0x0066F8C4
		// (set) Token: 0x0600039F RID: 927 RVA: 0x006716E4 File Offset: 0x0066F8E4
		[DebuggerNonUserCode]
		[DefaultSettingValue("All")]
		[UserScopedSetting]
		public string StoreFilterFaction
		{
			get
			{
				return (string)this["StoreFilterFaction"];
			}
			set
			{
				this["StoreFilterFaction"] = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00671700 File Offset: 0x0066F900
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00671720 File Offset: 0x0066F920
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("All")]
		public string StoreFilterClass
		{
			get
			{
				return (string)this["StoreFilterClass"];
			}
			set
			{
				this["StoreFilterClass"] = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0067173C File Offset: 0x0066F93C
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x0067175C File Offset: 0x0066F95C
		[DefaultSettingValue("All")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string StoreFilterProfileType
		{
			get
			{
				return (string)this["StoreFilterProfileType"];
			}
			set
			{
				this["StoreFilterProfileType"] = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00671778 File Offset: 0x0066F978
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00671798 File Offset: 0x0066F998
		[DefaultSettingValue("All")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string StoreFilterProfileSubType
		{
			get
			{
				return (string)this["StoreFilterProfileSubType"];
			}
			set
			{
				this["StoreFilterProfileSubType"] = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x006717B4 File Offset: 0x0066F9B4
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x006717D4 File Offset: 0x0066F9D4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string StoreFilterRequiredLevel
		{
			get
			{
				return (string)this["StoreFilterRequiredLevel"];
			}
			set
			{
				this["StoreFilterRequiredLevel"] = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x006717F0 File Offset: 0x0066F9F0
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00671810 File Offset: 0x0066FA10
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string StoreFilterRequiredSkill
		{
			get
			{
				return (string)this["StoreFilterRequiredSkill"];
			}
			set
			{
				this["StoreFilterRequiredSkill"] = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0067182C File Offset: 0x0066FA2C
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0067184C File Offset: 0x0066FA4C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool JackAutoReconnect
		{
			get
			{
				return (bool)this["JackAutoReconnect"];
			}
			set
			{
				this["JackAutoReconnect"] = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0067186C File Offset: 0x0066FA6C
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0067188C File Offset: 0x0066FA8C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string JackAutoReconnectPassword
		{
			get
			{
				return (string)this["JackAutoReconnectPassword"];
			}
			set
			{
				this["JackAutoReconnectPassword"] = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060003AE RID: 942 RVA: 0x006718A8 File Offset: 0x0066FAA8
		// (set) Token: 0x060003AF RID: 943 RVA: 0x006718C8 File Offset: 0x0066FAC8
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool JackTray
		{
			get
			{
				return (bool)this["JackTray"];
			}
			set
			{
				this["JackTray"] = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x006718E8 File Offset: 0x0066FAE8
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00671908 File Offset: 0x0066FB08
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool NotificationsEvent
		{
			get
			{
				return (bool)this["NotificationsEvent"];
			}
			set
			{
				this["NotificationsEvent"] = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00671928 File Offset: 0x0066FB28
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00671948 File Offset: 0x0066FB48
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		public bool OverlayESPObjectsContainer
		{
			get
			{
				return (bool)this["OverlayESPObjectsContainer"];
			}
			set
			{
				this["OverlayESPObjectsContainer"] = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00671968 File Offset: 0x0066FB68
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00671988 File Offset: 0x0066FB88
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPObjectsFishingPools
		{
			get
			{
				return (bool)this["OverlayESPObjectsFishingPools"];
			}
			set
			{
				this["OverlayESPObjectsFishingPools"] = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x006719A8 File Offset: 0x0066FBA8
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x006719C8 File Offset: 0x0066FBC8
		[DefaultSettingValue("False")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool RecorderQuestTracker
		{
			get
			{
				return (bool)this["RecorderQuestTracker"];
			}
			set
			{
				this["RecorderQuestTracker"] = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x006719E8 File Offset: 0x0066FBE8
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00671A08 File Offset: 0x0066FC08
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool OverlayESPObjectsGatherableMobs
		{
			get
			{
				return (bool)this["OverlayESPObjectsGatherableMobs"];
			}
			set
			{
				this["OverlayESPObjectsGatherableMobs"] = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00671A28 File Offset: 0x0066FC28
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00671A48 File Offset: 0x0066FC48
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string MapsClassicVersion
		{
			get
			{
				return (string)this["MapsClassicVersion"];
			}
			set
			{
				this["MapsClassicVersion"] = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00671A64 File Offset: 0x0066FC64
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00671A84 File Offset: 0x0066FC84
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string MapsRetailVersion
		{
			get
			{
				return (string)this["MapsRetailVersion"];
			}
			set
			{
				this["MapsRetailVersion"] = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00671AA0 File Offset: 0x0066FCA0
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00671AC0 File Offset: 0x0066FCC0
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public bool AddonCheckOnStart
		{
			get
			{
				return (bool)this["AddonCheckOnStart"];
			}
			set
			{
				this["AddonCheckOnStart"] = value;
			}
		}

		// Token: 0x040000C1 RID: 193
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
