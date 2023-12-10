using System;
using System.Runtime.InteropServices;
using MyU9Ep58ZH3s5ThDFJQ;

namespace Interceptor
{
	// Token: 0x02000003 RID: 3
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public sealed class Predicate : MulticastDelegate
	{
		// Token: 0x0600002E RID: 46
		public extern Predicate(object @object, IntPtr method);

		// Token: 0x0600002F RID: 47
		public extern int Invoke(int device);

		// Token: 0x06000030 RID: 48
		public extern IAsyncResult BeginInvoke(int device, AsyncCallback callback, object @object);

		// Token: 0x06000031 RID: 49
		public extern int EndInvoke(IAsyncResult result);

		// Token: 0x06000032 RID: 50 RVA: 0x00002EC8 File Offset: 0x000010C8
		static Predicate()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}
	}
}
