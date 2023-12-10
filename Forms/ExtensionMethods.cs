using System;
using System.Collections.Generic;

namespace Jack.Forms
{
	// Token: 0x020000A6 RID: 166
	public static class ExtensionMethods
	{
		// Token: 0x06001109 RID: 4361 RVA: 0x006DAFD4 File Offset: 0x006D91D4
		public static void Swap<T>(this List<T> WhichList, int Index1, int Index2)
		{
			T value = WhichList[Index1];
			WhichList[Index1] = WhichList[Index2];
			WhichList[Index2] = value;
		}
	}
}
