using System;
using System.Collections.Generic;
using System.Threading;

namespace Jack.Core
{
	// Token: 0x020000FD RID: 253
	public static class Frames
	{
		// Token: 0x0600176D RID: 5997 RVA: 0x0071B320 File Offset: 0x00719520
		public static void GetAllFrames(string SearchFrame = "")
		{
			Frames.ParentFrames.Clear();
			IntPtr pointer = (IntPtr)Read.Single<IntPtr>(Offsets.Frames_Base);
			IntPtr intPtr = (IntPtr)Read.Combined<IntPtr>(pointer + Descriptors.Frames_Base);
			while (intPtr != IntPtr.Zero)
			{
				IntPtr intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr + Descriptors.Frames_Frame);
				if (intPtr2 != IntPtr.Zero)
				{
					string text = (string)Read.Combined<string>(intPtr2);
					if (text.Length > 0 && !Frames.ParentFrames.ContainsKey(text) && (SearchFrame == "" || text == SearchFrame))
					{
						Frames.ParentFrames.Add(text, intPtr);
						if (SearchFrame.Length > 0)
						{
							break;
						}
					}
				}
				int offset = (int)Read.Combined<int>(pointer + Descriptors.Frames_BaseNext);
				intPtr = (IntPtr)Read.Combined<IntPtr>(intPtr + offset + Descriptors.Frames_FrameNext);
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0071B41C File Offset: 0x0071961C
		public static Dictionary<string, IntPtr> GetChildFrames(string ParentFrameName, string SearchFrame = "")
		{
			Dictionary<string, IntPtr> dictionary = new Dictionary<string, IntPtr>();
			IntPtr intPtr = IntPtr.Zero;
			if (Frames.ParentFrames.ContainsKey(ParentFrameName))
			{
				intPtr = Frames.ParentFrames[ParentFrameName];
			}
			if (intPtr != IntPtr.Zero)
			{
				IntPtr intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr + Descriptors.ChildFrames_Base);
				while (intPtr2 != IntPtr.Zero)
				{
					IntPtr intPtr3 = (IntPtr)Read.Combined<IntPtr>(intPtr2 + Descriptors.ChildFrames_Frame);
					if (intPtr3 != IntPtr.Zero)
					{
						string text = (string)Read.Combined<string>(intPtr3);
						if (text.Length > 0 && !dictionary.ContainsKey(text) && (SearchFrame == "" || text == SearchFrame))
						{
							dictionary.Add(text, intPtr2);
							if (SearchFrame.Length > 0)
							{
								break;
							}
						}
					}
					int offset = (int)Read.Combined<int>(intPtr + Descriptors.ChildFrames_BaseNext);
					intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr2 + offset + Descriptors.ChildFrames_FrameNext);
				}
			}
			return dictionary;
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0071B52C File Offset: 0x0071972C
		public static IntPtr GetTextFramePointer(string FrameName, string ChildFrameName = "")
		{
			Frames.GetAllFrames(FrameName);
			IntPtr intPtr = IntPtr.Zero;
			if (Frames.ParentFrames.ContainsKey(FrameName))
			{
				if (ChildFrameName.Length > 0)
				{
					using (Dictionary<string, IntPtr>.Enumerator enumerator = Frames.GetChildFrames(FrameName, ChildFrameName).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, IntPtr> keyValuePair = enumerator.Current;
							if (keyValuePair.Key == ChildFrameName)
							{
								intPtr = keyValuePair.Value;
							}
						}
						goto IL_76;
					}
				}
				intPtr = Frames.ParentFrames[FrameName];
			}
			IL_76:
			if (intPtr != IntPtr.Zero)
			{
				IntPtr intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr + Descriptors.Frames_GetText);
				if (intPtr2 != IntPtr.Zero)
				{
					return intPtr2;
				}
			}
			return IntPtr.Zero;
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x0071B5F8 File Offset: 0x007197F8
		public static string GetText(string FrameName, string ChildFrameName = "")
		{
			if (ChildFrameName.Length == 0)
			{
				ChildFrameName = FrameName + "Text";
			}
			IntPtr textFramePointer = Frames.GetTextFramePointer(FrameName, ChildFrameName);
			if (textFramePointer != IntPtr.Zero)
			{
				string text = (string)Read.Combined<string>(textFramePointer);
				if (text.Length > 0)
				{
					return text;
				}
			}
			return "";
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x0071B64C File Offset: 0x0071984C
		public static void SetText(string FrameName, string Content = "")
		{
			IntPtr textFramePointer = Frames.GetTextFramePointer(FrameName, FrameName + "Text");
			if (textFramePointer != IntPtr.Zero)
			{
				Write.Do(textFramePointer, Content);
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x0071B688 File Offset: 0x00719888
		public static void ResetText(string FrameName)
		{
			Frames.SetText(FrameName, "");
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x0071B6A0 File Offset: 0x007198A0
		public static bool Check(string FrameName, string Text, bool Exact = true)
		{
			if (Exact)
			{
				return Frames.GetText(FrameName, FrameName + "Text") == Text;
			}
			return Frames.GetText(FrameName, FrameName + "Text").Contains(Text);
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0071B6E0 File Offset: 0x007198E0
		public static void GetFramesDescriptors()
		{
			Frames.<>c__DisplayClass8_0 CS$<>8__locals1 = new Frames.<>c__DisplayClass8_0();
			CS$<>8__locals1.StartBase = Descriptors.Frames_Base - 32;
			CS$<>8__locals1.EndBase = Descriptors.Frames_Base + 32;
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0071B72C File Offset: 0x0071992C
		public static void GetChildFramesDescriptors()
		{
			Frames.<>c__DisplayClass9_0 CS$<>8__locals1 = new Frames.<>c__DisplayClass9_0();
			CS$<>8__locals1.StartBase = Descriptors.ChildFrames_Base - 32;
			CS$<>8__locals1.EndBase = Descriptors.ChildFrames_Base + 32;
			CS$<>8__locals1.ParentFrameName = "GlueDialogBackground";
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x04000AA8 RID: 2728
		public static Dictionary<string, IntPtr> ParentFrames = new Dictionary<string, IntPtr>();
	}
}
