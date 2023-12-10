using System;

namespace Interceptor
{
	// Token: 0x02000004 RID: 4
	[Flags]
	public enum KeyState : ushort
	{
		// Token: 0x0400000E RID: 14
		Down = 0,
		// Token: 0x0400000F RID: 15
		Up = 1,
		// Token: 0x04000010 RID: 16
		E0 = 2,
		// Token: 0x04000011 RID: 17
		E1 = 4,
		// Token: 0x04000012 RID: 18
		TermsrvSetLED = 8,
		// Token: 0x04000013 RID: 19
		TermsrvShadow = 16,
		// Token: 0x04000014 RID: 20
		TermsrvVKPacket = 32
	}
}
