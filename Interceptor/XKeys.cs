using System;

namespace Interceptor
{
	// Token: 0x0200000F RID: 15
	public enum XKeys : ushort
	{
		// Token: 0x0400005D RID: 93
		Escape = 1,
		// Token: 0x0400005E RID: 94
		One,
		// Token: 0x0400005F RID: 95
		Two,
		// Token: 0x04000060 RID: 96
		Three,
		// Token: 0x04000061 RID: 97
		Four,
		// Token: 0x04000062 RID: 98
		Five,
		// Token: 0x04000063 RID: 99
		Six,
		// Token: 0x04000064 RID: 100
		Seven,
		// Token: 0x04000065 RID: 101
		Eight,
		// Token: 0x04000066 RID: 102
		Nine,
		// Token: 0x04000067 RID: 103
		Zero,
		// Token: 0x04000068 RID: 104
		DashUnderscore,
		// Token: 0x04000069 RID: 105
		PlusEquals,
		// Token: 0x0400006A RID: 106
		Backspace,
		// Token: 0x0400006B RID: 107
		Tab,
		// Token: 0x0400006C RID: 108
		Q,
		// Token: 0x0400006D RID: 109
		W,
		// Token: 0x0400006E RID: 110
		E,
		// Token: 0x0400006F RID: 111
		R,
		// Token: 0x04000070 RID: 112
		T,
		// Token: 0x04000071 RID: 113
		Y,
		// Token: 0x04000072 RID: 114
		U,
		// Token: 0x04000073 RID: 115
		I,
		// Token: 0x04000074 RID: 116
		O,
		// Token: 0x04000075 RID: 117
		P,
		// Token: 0x04000076 RID: 118
		OpenBracketBrace,
		// Token: 0x04000077 RID: 119
		CloseBracketBrace,
		// Token: 0x04000078 RID: 120
		Enter,
		// Token: 0x04000079 RID: 121
		Control,
		// Token: 0x0400007A RID: 122
		A,
		// Token: 0x0400007B RID: 123
		S,
		// Token: 0x0400007C RID: 124
		D,
		// Token: 0x0400007D RID: 125
		F,
		// Token: 0x0400007E RID: 126
		G,
		// Token: 0x0400007F RID: 127
		H,
		// Token: 0x04000080 RID: 128
		J,
		// Token: 0x04000081 RID: 129
		K,
		// Token: 0x04000082 RID: 130
		L,
		// Token: 0x04000083 RID: 131
		SemicolonColon,
		// Token: 0x04000084 RID: 132
		SingleDoubleQuote,
		// Token: 0x04000085 RID: 133
		Tilde,
		// Token: 0x04000086 RID: 134
		LeftShift,
		// Token: 0x04000087 RID: 135
		BackslashPipe,
		// Token: 0x04000088 RID: 136
		Z,
		// Token: 0x04000089 RID: 137
		X,
		// Token: 0x0400008A RID: 138
		C,
		// Token: 0x0400008B RID: 139
		V,
		// Token: 0x0400008C RID: 140
		B,
		// Token: 0x0400008D RID: 141
		N,
		// Token: 0x0400008E RID: 142
		M,
		// Token: 0x0400008F RID: 143
		CommaLeftArrow,
		// Token: 0x04000090 RID: 144
		PeriodRightArrow,
		// Token: 0x04000091 RID: 145
		ForwardSlashQuestionMark,
		// Token: 0x04000092 RID: 146
		RightShift,
		// Token: 0x04000093 RID: 147
		RightAlt = 56,
		// Token: 0x04000094 RID: 148
		Space,
		// Token: 0x04000095 RID: 149
		CapsLock,
		// Token: 0x04000096 RID: 150
		F1,
		// Token: 0x04000097 RID: 151
		F2,
		// Token: 0x04000098 RID: 152
		F3,
		// Token: 0x04000099 RID: 153
		F4,
		// Token: 0x0400009A RID: 154
		F5,
		// Token: 0x0400009B RID: 155
		F6,
		// Token: 0x0400009C RID: 156
		F7,
		// Token: 0x0400009D RID: 157
		F8,
		// Token: 0x0400009E RID: 158
		F9,
		// Token: 0x0400009F RID: 159
		F10,
		// Token: 0x040000A0 RID: 160
		F11 = 87,
		// Token: 0x040000A1 RID: 161
		F12,
		// Token: 0x040000A2 RID: 162
		Up = 72,
		// Token: 0x040000A3 RID: 163
		Down = 80,
		// Token: 0x040000A4 RID: 164
		Right = 77,
		// Token: 0x040000A5 RID: 165
		Left = 75,
		// Token: 0x040000A6 RID: 166
		Home = 71,
		// Token: 0x040000A7 RID: 167
		End = 79,
		// Token: 0x040000A8 RID: 168
		Delete = 83,
		// Token: 0x040000A9 RID: 169
		PageUp = 73,
		// Token: 0x040000AA RID: 170
		PageDown = 81,
		// Token: 0x040000AB RID: 171
		Insert,
		// Token: 0x040000AC RID: 172
		PrintScreen = 55,
		// Token: 0x040000AD RID: 173
		NumLock = 69,
		// Token: 0x040000AE RID: 174
		ScrollLock,
		// Token: 0x040000AF RID: 175
		Menu = 93,
		// Token: 0x040000B0 RID: 176
		WindowsKey = 91,
		// Token: 0x040000B1 RID: 177
		NumpadDivide = 53,
		// Token: 0x040000B2 RID: 178
		NumpadAsterisk = 55,
		// Token: 0x040000B3 RID: 179
		Numpad7 = 71,
		// Token: 0x040000B4 RID: 180
		Numpad8,
		// Token: 0x040000B5 RID: 181
		Numpad9,
		// Token: 0x040000B6 RID: 182
		Numpad4 = 75,
		// Token: 0x040000B7 RID: 183
		Numpad5,
		// Token: 0x040000B8 RID: 184
		Numpad6,
		// Token: 0x040000B9 RID: 185
		Numpad1 = 79,
		// Token: 0x040000BA RID: 186
		Numpad2,
		// Token: 0x040000BB RID: 187
		Numpad3,
		// Token: 0x040000BC RID: 188
		Numpad0,
		// Token: 0x040000BD RID: 189
		NumpadDelete,
		// Token: 0x040000BE RID: 190
		NumpadEnter = 28,
		// Token: 0x040000BF RID: 191
		NumpadPlus = 78,
		// Token: 0x040000C0 RID: 192
		NumpadMinus = 74
	}
}
