using System;

namespace Jack.Core
{
	// Token: 0x02000114 RID: 276
	public enum KeyType
	{
		// Token: 0x04000BB4 RID: 2996
		KeyDown = 256,
		// Token: 0x04000BB5 RID: 2997
		KeyUp,
		// Token: 0x04000BB6 RID: 2998
		LeftButtonDown = 513,
		// Token: 0x04000BB7 RID: 2999
		LeftButtonUp,
		// Token: 0x04000BB8 RID: 3000
		LeftButton = 1,
		// Token: 0x04000BB9 RID: 3001
		RightButton,
		// Token: 0x04000BBA RID: 3002
		Cancel,
		// Token: 0x04000BBB RID: 3003
		MiddleButton,
		// Token: 0x04000BBC RID: 3004
		ExtraButton1,
		// Token: 0x04000BBD RID: 3005
		ExtraButton2,
		// Token: 0x04000BBE RID: 3006
		Backspace = 8,
		// Token: 0x04000BBF RID: 3007
		Tab,
		// Token: 0x04000BC0 RID: 3008
		Clear = 12,
		// Token: 0x04000BC1 RID: 3009
		Return,
		// Token: 0x04000BC2 RID: 3010
		Shift = 16,
		// Token: 0x04000BC3 RID: 3011
		Control,
		// Token: 0x04000BC4 RID: 3012
		Menu,
		// Token: 0x04000BC5 RID: 3013
		Pause,
		// Token: 0x04000BC6 RID: 3014
		CapsLock,
		// Token: 0x04000BC7 RID: 3015
		Kana,
		// Token: 0x04000BC8 RID: 3016
		Hangeul = 21,
		// Token: 0x04000BC9 RID: 3017
		Hangul = 21,
		// Token: 0x04000BCA RID: 3018
		Junja = 23,
		// Token: 0x04000BCB RID: 3019
		Final,
		// Token: 0x04000BCC RID: 3020
		Hanja,
		// Token: 0x04000BCD RID: 3021
		Kanji = 25,
		// Token: 0x04000BCE RID: 3022
		Escape = 27,
		// Token: 0x04000BCF RID: 3023
		Convert,
		// Token: 0x04000BD0 RID: 3024
		NonConvert,
		// Token: 0x04000BD1 RID: 3025
		Accept,
		// Token: 0x04000BD2 RID: 3026
		ModeChange,
		// Token: 0x04000BD3 RID: 3027
		Space,
		// Token: 0x04000BD4 RID: 3028
		Prior,
		// Token: 0x04000BD5 RID: 3029
		Next,
		// Token: 0x04000BD6 RID: 3030
		End,
		// Token: 0x04000BD7 RID: 3031
		Home,
		// Token: 0x04000BD8 RID: 3032
		Left,
		// Token: 0x04000BD9 RID: 3033
		Up,
		// Token: 0x04000BDA RID: 3034
		Right,
		// Token: 0x04000BDB RID: 3035
		Down,
		// Token: 0x04000BDC RID: 3036
		Select,
		// Token: 0x04000BDD RID: 3037
		Print,
		// Token: 0x04000BDE RID: 3038
		Execute,
		// Token: 0x04000BDF RID: 3039
		Snapshot,
		// Token: 0x04000BE0 RID: 3040
		Insert,
		// Token: 0x04000BE1 RID: 3041
		Delete,
		// Token: 0x04000BE2 RID: 3042
		Help,
		// Token: 0x04000BE3 RID: 3043
		Nr0,
		// Token: 0x04000BE4 RID: 3044
		Nr1,
		// Token: 0x04000BE5 RID: 3045
		Nr2,
		// Token: 0x04000BE6 RID: 3046
		Nr3,
		// Token: 0x04000BE7 RID: 3047
		Nr4,
		// Token: 0x04000BE8 RID: 3048
		Nr5,
		// Token: 0x04000BE9 RID: 3049
		Nr6,
		// Token: 0x04000BEA RID: 3050
		Nr7,
		// Token: 0x04000BEB RID: 3051
		Nr8,
		// Token: 0x04000BEC RID: 3052
		Nr9,
		// Token: 0x04000BED RID: 3053
		A = 65,
		// Token: 0x04000BEE RID: 3054
		B,
		// Token: 0x04000BEF RID: 3055
		C,
		// Token: 0x04000BF0 RID: 3056
		D,
		// Token: 0x04000BF1 RID: 3057
		E,
		// Token: 0x04000BF2 RID: 3058
		F,
		// Token: 0x04000BF3 RID: 3059
		G,
		// Token: 0x04000BF4 RID: 3060
		H,
		// Token: 0x04000BF5 RID: 3061
		I,
		// Token: 0x04000BF6 RID: 3062
		J,
		// Token: 0x04000BF7 RID: 3063
		K,
		// Token: 0x04000BF8 RID: 3064
		L,
		// Token: 0x04000BF9 RID: 3065
		M,
		// Token: 0x04000BFA RID: 3066
		N,
		// Token: 0x04000BFB RID: 3067
		O,
		// Token: 0x04000BFC RID: 3068
		P,
		// Token: 0x04000BFD RID: 3069
		Q,
		// Token: 0x04000BFE RID: 3070
		R,
		// Token: 0x04000BFF RID: 3071
		S,
		// Token: 0x04000C00 RID: 3072
		T,
		// Token: 0x04000C01 RID: 3073
		U,
		// Token: 0x04000C02 RID: 3074
		V,
		// Token: 0x04000C03 RID: 3075
		W,
		// Token: 0x04000C04 RID: 3076
		X,
		// Token: 0x04000C05 RID: 3077
		Y,
		// Token: 0x04000C06 RID: 3078
		Z,
		// Token: 0x04000C07 RID: 3079
		LeftWindows,
		// Token: 0x04000C08 RID: 3080
		RightWindows,
		// Token: 0x04000C09 RID: 3081
		Application,
		// Token: 0x04000C0A RID: 3082
		Sleep = 95,
		// Token: 0x04000C0B RID: 3083
		Numpad0,
		// Token: 0x04000C0C RID: 3084
		Numpad1,
		// Token: 0x04000C0D RID: 3085
		Numpad2,
		// Token: 0x04000C0E RID: 3086
		Numpad3,
		// Token: 0x04000C0F RID: 3087
		Numpad4,
		// Token: 0x04000C10 RID: 3088
		Numpad5,
		// Token: 0x04000C11 RID: 3089
		Numpad6,
		// Token: 0x04000C12 RID: 3090
		Numpad7,
		// Token: 0x04000C13 RID: 3091
		Numpad8,
		// Token: 0x04000C14 RID: 3092
		Numpad9,
		// Token: 0x04000C15 RID: 3093
		Multiply,
		// Token: 0x04000C16 RID: 3094
		Add,
		// Token: 0x04000C17 RID: 3095
		Separator,
		// Token: 0x04000C18 RID: 3096
		Subtract,
		// Token: 0x04000C19 RID: 3097
		Decimal,
		// Token: 0x04000C1A RID: 3098
		Divide,
		// Token: 0x04000C1B RID: 3099
		F1,
		// Token: 0x04000C1C RID: 3100
		F2,
		// Token: 0x04000C1D RID: 3101
		F3,
		// Token: 0x04000C1E RID: 3102
		F4,
		// Token: 0x04000C1F RID: 3103
		F5,
		// Token: 0x04000C20 RID: 3104
		F6,
		// Token: 0x04000C21 RID: 3105
		F7,
		// Token: 0x04000C22 RID: 3106
		F8,
		// Token: 0x04000C23 RID: 3107
		F9,
		// Token: 0x04000C24 RID: 3108
		F10,
		// Token: 0x04000C25 RID: 3109
		F11,
		// Token: 0x04000C26 RID: 3110
		F12,
		// Token: 0x04000C27 RID: 3111
		F13,
		// Token: 0x04000C28 RID: 3112
		F14,
		// Token: 0x04000C29 RID: 3113
		F15,
		// Token: 0x04000C2A RID: 3114
		F16,
		// Token: 0x04000C2B RID: 3115
		F17,
		// Token: 0x04000C2C RID: 3116
		F18,
		// Token: 0x04000C2D RID: 3117
		F19,
		// Token: 0x04000C2E RID: 3118
		F20,
		// Token: 0x04000C2F RID: 3119
		F21,
		// Token: 0x04000C30 RID: 3120
		F22,
		// Token: 0x04000C31 RID: 3121
		F23,
		// Token: 0x04000C32 RID: 3122
		F24,
		// Token: 0x04000C33 RID: 3123
		NumLock = 144,
		// Token: 0x04000C34 RID: 3124
		ScrollLock,
		// Token: 0x04000C35 RID: 3125
		NEC_Equal,
		// Token: 0x04000C36 RID: 3126
		Fujitsu_Jisho = 146,
		// Token: 0x04000C37 RID: 3127
		Fujitsu_Masshou,
		// Token: 0x04000C38 RID: 3128
		Fujitsu_Touroku,
		// Token: 0x04000C39 RID: 3129
		Fujitsu_Loya,
		// Token: 0x04000C3A RID: 3130
		Fujitsu_Roya,
		// Token: 0x04000C3B RID: 3131
		LeftShift = 160,
		// Token: 0x04000C3C RID: 3132
		RightShift,
		// Token: 0x04000C3D RID: 3133
		LeftControl,
		// Token: 0x04000C3E RID: 3134
		RightControl,
		// Token: 0x04000C3F RID: 3135
		LeftMenu,
		// Token: 0x04000C40 RID: 3136
		RightMenu,
		// Token: 0x04000C41 RID: 3137
		BrowserBack,
		// Token: 0x04000C42 RID: 3138
		BrowserForward,
		// Token: 0x04000C43 RID: 3139
		BrowserRefresh,
		// Token: 0x04000C44 RID: 3140
		BrowserStop,
		// Token: 0x04000C45 RID: 3141
		BrowserSearch,
		// Token: 0x04000C46 RID: 3142
		BrowserFavorites,
		// Token: 0x04000C47 RID: 3143
		BrowserHome,
		// Token: 0x04000C48 RID: 3144
		VolumeMute,
		// Token: 0x04000C49 RID: 3145
		VolumeDown,
		// Token: 0x04000C4A RID: 3146
		VolumeUp,
		// Token: 0x04000C4B RID: 3147
		MediaNextTrack,
		// Token: 0x04000C4C RID: 3148
		MediaPrevTrack,
		// Token: 0x04000C4D RID: 3149
		MediaStop,
		// Token: 0x04000C4E RID: 3150
		MediaPlayPause,
		// Token: 0x04000C4F RID: 3151
		LaunchMail,
		// Token: 0x04000C50 RID: 3152
		LaunchMediaSelect,
		// Token: 0x04000C51 RID: 3153
		LaunchApplication1,
		// Token: 0x04000C52 RID: 3154
		LaunchApplication2,
		// Token: 0x04000C53 RID: 3155
		OEM1 = 186,
		// Token: 0x04000C54 RID: 3156
		OEMPlus,
		// Token: 0x04000C55 RID: 3157
		OEMComma,
		// Token: 0x04000C56 RID: 3158
		OEMMinus,
		// Token: 0x04000C57 RID: 3159
		OEMPeriod,
		// Token: 0x04000C58 RID: 3160
		OEM2,
		// Token: 0x04000C59 RID: 3161
		OEM3,
		// Token: 0x04000C5A RID: 3162
		OEM4 = 219,
		// Token: 0x04000C5B RID: 3163
		OEM5,
		// Token: 0x04000C5C RID: 3164
		OEM6,
		// Token: 0x04000C5D RID: 3165
		OEM7,
		// Token: 0x04000C5E RID: 3166
		OEM8,
		// Token: 0x04000C5F RID: 3167
		OEMAX = 225,
		// Token: 0x04000C60 RID: 3168
		OEM102,
		// Token: 0x04000C61 RID: 3169
		ICOHelp,
		// Token: 0x04000C62 RID: 3170
		ICO00,
		// Token: 0x04000C63 RID: 3171
		ProcessKey,
		// Token: 0x04000C64 RID: 3172
		ICOClear,
		// Token: 0x04000C65 RID: 3173
		Packet,
		// Token: 0x04000C66 RID: 3174
		OEMReset = 233,
		// Token: 0x04000C67 RID: 3175
		OEMJump,
		// Token: 0x04000C68 RID: 3176
		OEMPA1,
		// Token: 0x04000C69 RID: 3177
		OEMPA2,
		// Token: 0x04000C6A RID: 3178
		OEMPA3,
		// Token: 0x04000C6B RID: 3179
		OEMWSCtrl,
		// Token: 0x04000C6C RID: 3180
		OEMCUSel,
		// Token: 0x04000C6D RID: 3181
		OEMATTN,
		// Token: 0x04000C6E RID: 3182
		OEMFinish,
		// Token: 0x04000C6F RID: 3183
		OEMCopy,
		// Token: 0x04000C70 RID: 3184
		OEMAuto,
		// Token: 0x04000C71 RID: 3185
		OEMENLW,
		// Token: 0x04000C72 RID: 3186
		OEMBackTab,
		// Token: 0x04000C73 RID: 3187
		ATTN,
		// Token: 0x04000C74 RID: 3188
		CRSel,
		// Token: 0x04000C75 RID: 3189
		EXSel,
		// Token: 0x04000C76 RID: 3190
		EREOF,
		// Token: 0x04000C77 RID: 3191
		Play,
		// Token: 0x04000C78 RID: 3192
		Zoom,
		// Token: 0x04000C79 RID: 3193
		Noname,
		// Token: 0x04000C7A RID: 3194
		PA1,
		// Token: 0x04000C7B RID: 3195
		OEMClear,
		// Token: 0x04000C7C RID: 3196
		NotSet
	}
}
