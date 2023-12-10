using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Jack.Core;
using Newtonsoft.Json;

namespace Jack.ATH
{
	// Token: 0x02000141 RID: 321
	internal class REQ
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x0073480C File Offset: 0x00732A0C
		public static string Ath(string Mode, string Params = "")
		{
			IntPtr intPtr = REQ._ath_(Mode, _globals.LCSEnc, Params);
			string text = Marshal.PtrToStringAnsi(intPtr);
			REQ._athFree_(intPtr);
			if (text.Length > 0 && text.Contains(";") && Mode == "ATH" && REQ.SetLCSObj(text))
			{
				return "Success";
			}
			return text;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00734864 File Offset: 0x00732A64
		private static bool SetLCSObj(string Received)
		{
			string[] array = Received.Split(new char[]
			{
				';'
			});
			string cipherText = array[0];
			string password = array[1];
			string ivstr = array[2];
			string text = Crypt.DecryptString(cipherText, password, ivstr);
			List<LCS> list = new List<LCS>();
			list = JsonConvert.DeserializeObject<List<LCS>>(text);
			if (list.Count <= 0)
			{
				return false;
			}
			_globals.LCS = list[0];
			return true;
		}

		// Token: 0x06001D89 RID: 7561
		[DllImport("Ath.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr _ath_(string Mode, string LCS, string Params);

		// Token: 0x06001D8A RID: 7562
		[DllImport("Ath.dll", CallingConvention = CallingConvention.Cdecl)]
		public static extern void _athFree_(IntPtr p);
	}
}
