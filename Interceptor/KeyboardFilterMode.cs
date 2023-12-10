using System;

namespace Interceptor
{
	// Token: 0x02000005 RID: 5
	[Flags]
	public enum KeyboardFilterMode : ushort
	{
		// Token: 0x04000016 RID: 22
		None = 0,
		// Token: 0x04000017 RID: 23
		All = 65535,
		// Token: 0x04000018 RID: 24
		KeyDown = 1,
		// Token: 0x04000019 RID: 25
		KeyUp = 2,
		// Token: 0x0400001A RID: 26
		KeyE0 = 4,
		// Token: 0x0400001B RID: 27
		KeyE1 = 8,
		// Token: 0x0400001C RID: 28
		KeyTermsrvSetLED = 16,
		// Token: 0x0400001D RID: 29
		KeyTermsrvShadow = 32,
		// Token: 0x0400001E RID: 30
		KeyTermsrvVKPacket = 64
	}
}
