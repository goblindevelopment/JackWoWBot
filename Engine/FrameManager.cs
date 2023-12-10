using System;
using System.Collections.Generic;
using Jack.Core;

namespace Jack.Engine
{
	// Token: 0x020000C6 RID: 198
	internal class FrameManager
	{
		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0070DA54 File Offset: 0x0070BC54
		public static Dictionary<string, bool> Frames
		{
			get
			{
				Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
				if (_globals.Ready)
				{
					try
					{
						IntPtr pointer = (IntPtr)Read.Single<IntPtr>(Offsets.Frames_Base);
						IntPtr intPtr = (IntPtr)Read.Combined<IntPtr>(pointer + Descriptors.Frames_Base);
						while (intPtr != IntPtr.Zero)
						{
							if ((int)Read.Combined<int>(intPtr + Descriptors.Frames_Frame) > 0)
							{
								string key = (string)Read.Combined<string>((IntPtr)Read.Combined<IntPtr>(intPtr + Descriptors.Frames_Frame));
								int num = (int)Read.Combined<int>(intPtr + Descriptors.Frames_Visible);
								bool value = Convert.ToBoolean(num > 0 && num.ToString().Length == 1);
								if (!dictionary.ContainsKey(key))
								{
									dictionary.Add(key, value);
								}
							}
							int offset = (int)Read.Combined<int>(pointer + Descriptors.Frames_BaseNext);
							intPtr = (IntPtr)Read.Combined<IntPtr>(intPtr + offset + Descriptors.Frames_FrameNext);
						}
					}
					catch
					{
					}
				}
				return dictionary;
			}
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x0070DB78 File Offset: 0x0070BD78
		public static bool FrameIsVisible(string FrameName)
		{
			foreach (KeyValuePair<string, bool> keyValuePair in FrameManager.Frames)
			{
				if (keyValuePair.Key == FrameName)
				{
					return keyValuePair.Value;
				}
			}
			return false;
		}
	}
}
