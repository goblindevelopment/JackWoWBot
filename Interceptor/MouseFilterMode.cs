using System;

namespace Interceptor
{
	// Token: 0x02000007 RID: 7
	[Flags]
	public enum MouseFilterMode : ushort
	{
		// Token: 0x04000031 RID: 49
		None = 0,
		// Token: 0x04000032 RID: 50
		All = 65535,
		// Token: 0x04000033 RID: 51
		LeftDown = 1,
		// Token: 0x04000034 RID: 52
		LeftUp = 2,
		// Token: 0x04000035 RID: 53
		RightDown = 4,
		// Token: 0x04000036 RID: 54
		RightUp = 8,
		// Token: 0x04000037 RID: 55
		MiddleDown = 16,
		// Token: 0x04000038 RID: 56
		MiddleUp = 32,
		// Token: 0x04000039 RID: 57
		LeftExtraDown = 64,
		// Token: 0x0400003A RID: 58
		LeftExtraUp = 128,
		// Token: 0x0400003B RID: 59
		RightExtraDown = 256,
		// Token: 0x0400003C RID: 60
		RightExtraUp = 512,
		// Token: 0x0400003D RID: 61
		MouseWheelVertical = 1024,
		// Token: 0x0400003E RID: 62
		MouseWheelHorizontal = 2048,
		// Token: 0x0400003F RID: 63
		MouseMove = 4096
	}
}
