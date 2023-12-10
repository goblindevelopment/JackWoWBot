using System;
using System.Runtime.InteropServices;
using MyU9Ep58ZH3s5ThDFJQ;

namespace Interceptor
{
	// Token: 0x0200000C RID: 12
	public static class InterceptionDriver
	{
		// Token: 0x06000033 RID: 51
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_create_context")]
		public static extern IntPtr CreateContext();

		// Token: 0x06000034 RID: 52
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_destroy_context")]
		public static extern void DestroyContext(IntPtr context);

		// Token: 0x06000035 RID: 53
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_get_precedence")]
		public static extern void GetPrecedence(IntPtr context, int device);

		// Token: 0x06000036 RID: 54
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_set_precedence")]
		public static extern void SetPrecedence(IntPtr context, int device, int Precedence);

		// Token: 0x06000037 RID: 55
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_get_filter")]
		public static extern void GetFilter(IntPtr context, int device);

		// Token: 0x06000038 RID: 56
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_set_filter")]
		public static extern void SetFilter(IntPtr context, Predicate predicate, int keyboardFilterMode);

		// Token: 0x06000039 RID: 57
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_wait")]
		public static extern int Wait(IntPtr context);

		// Token: 0x0600003A RID: 58
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_wait_with_timeout")]
		public static extern int WaitWithTimeout(IntPtr context, ulong milliseconds);

		// Token: 0x0600003B RID: 59
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_send")]
		public static extern int Send(IntPtr context, int device, ref Stroke stroke, uint numStrokes);

		// Token: 0x0600003C RID: 60
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_receive")]
		public static extern int Receive(IntPtr context, int device, ref Stroke stroke, uint numStrokes);

		// Token: 0x0600003D RID: 61
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_get_hardware_id")]
		public static extern int GetHardwareId(IntPtr context, int device, string hardwareIdentifier, uint sizeOfString);

		// Token: 0x0600003E RID: 62
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_is_invalid")]
		public static extern int IsInvalid(int device);

		// Token: 0x0600003F RID: 63
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_is_keyboard")]
		public static extern int IsKeyboard(int device);

		// Token: 0x06000040 RID: 64
		[DllImport("driver.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "interception_is_mouse")]
		public static extern int IsMouse(int device);

		// Token: 0x06000041 RID: 65 RVA: 0x00002ED8 File Offset: 0x000010D8
		// Note: this type is marked as 'beforefieldinit'.
		static InterceptionDriver()
		{
			InterceptionDriver.SHTSx13p3FUx4MHikIa();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002EE0 File Offset: 0x000010E0
		internal static void SHTSx13p3FUx4MHikIa()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}
	}
}
