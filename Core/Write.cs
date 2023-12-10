using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Jack.Core
{
	// Token: 0x02000132 RID: 306
	public class Write
	{
		// Token: 0x06001B95 RID: 7061 RVA: 0x0072E204 File Offset: 0x0072C404
		public static int Do(object Offset, object Content)
		{
			try
			{
				IntPtr lpBaseAddress = IntPtr.Zero;
				if (Offset.GetType() == typeof(int))
				{
					lpBaseAddress = _globals.processPointerWrite + (int)Offset;
				}
				else if (Offset.GetType() == typeof(IntPtr))
				{
					lpBaseAddress = (IntPtr)Offset;
				}
				byte[] array;
				if (Content.GetType() == typeof(UInt128))
				{
					array = ((UInt128)Content).ToByteArray();
				}
				else if (!(Content.GetType() == typeof(string)))
				{
					array = BitConverter.GetBytes((int)Content);
				}
				else
				{
					array = Encoding.UTF8.GetBytes((string)Content + "\0");
				}
				IntPtr value;
				Write.WriteProcessMemory(_globals.processHandleWrite, lpBaseAddress, array, (IntPtr)array.Length, out value);
				return (int)value;
			}
			catch
			{
			}
			return 0;
		}

		// Token: 0x06001B96 RID: 7062
		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, IntPtr nSize, out IntPtr lpNumberOfBytesWritten);
	}
}
