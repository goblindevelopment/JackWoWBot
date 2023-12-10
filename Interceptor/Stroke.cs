using System;
using System.Runtime.InteropServices;

namespace Interceptor
{
	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit)]
	public struct Stroke
	{
		// Token: 0x04000050 RID: 80
		[FieldOffset(0)]
		public MouseStroke Mouse;

		// Token: 0x04000051 RID: 81
		[FieldOffset(0)]
		public KeyStroke Key;
	}
}
