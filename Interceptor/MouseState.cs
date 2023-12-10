using System;

namespace Interceptor
{
	// Token: 0x02000006 RID: 6
	[Flags]
	public enum MouseState : ushort
	{
		// Token: 0x04000020 RID: 32
		LeftDown = 1,
		// Token: 0x04000021 RID: 33
		LeftUp = 2,
		// Token: 0x04000022 RID: 34
		RightDown = 4,
		// Token: 0x04000023 RID: 35
		RightUp = 8,
		// Token: 0x04000024 RID: 36
		MiddleDown = 16,
		// Token: 0x04000025 RID: 37
		MiddleUp = 32,
		// Token: 0x04000026 RID: 38
		LeftExtraDown = 64,
		// Token: 0x04000027 RID: 39
		LeftExtraUp = 128,
		// Token: 0x04000028 RID: 40
		RightExtraDown = 256,
		// Token: 0x04000029 RID: 41
		RightExtraUp = 512,
		// Token: 0x0400002A RID: 42
		ScrollVertical = 1024,
		// Token: 0x0400002B RID: 43
		ScrollUp = 1024,
		// Token: 0x0400002C RID: 44
		ScrollDown = 1024,
		// Token: 0x0400002D RID: 45
		ScrollHorizontal = 2048,
		// Token: 0x0400002E RID: 46
		ScrollLeft = 2048,
		// Token: 0x0400002F RID: 47
		ScrollRight = 2048
	}
}
