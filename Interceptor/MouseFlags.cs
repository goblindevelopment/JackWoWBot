using System;

namespace Interceptor
{
	// Token: 0x02000008 RID: 8
	[Flags]
	public enum MouseFlags : ushort
	{
		// Token: 0x04000041 RID: 65
		MoveRelative = 0,
		// Token: 0x04000042 RID: 66
		MoveAbsolute = 1,
		// Token: 0x04000043 RID: 67
		VirtualDesktop = 2,
		// Token: 0x04000044 RID: 68
		AttributesChanged = 4,
		// Token: 0x04000045 RID: 69
		MoveWithoutCoalescing = 8,
		// Token: 0x04000046 RID: 70
		TerminalServicesSourceShadow = 256
	}
}
