using System;
using System.Collections.Generic;

namespace Jack.Core
{
	// Token: 0x02000106 RID: 262
	public static class Chat
	{
		// Token: 0x060017C1 RID: 6081 RVA: 0x0071CE68 File Offset: 0x0071B068
		public static string ReadMessage(int Position)
		{
			try
			{
				string text = (string)Read.Single<string>(Offsets.Chat_BufferStart + Descriptors.Chat_FirstChannelName + Descriptors.Chat_Next * (Position - 1));
				string text2 = (string)Read.Single<string>(Offsets.Chat_BufferStart + Descriptors.Chat_FirstName + Descriptors.Chat_Next * (Position - 1));
				string text3 = (string)Read.Single<string>(Offsets.Chat_BufferStart + Descriptors.Chat_FirstMessage + Descriptors.Chat_Next * (Position - 1));
				if (Position == 0)
				{
					text = (string)Read.Single<string>(Offsets.Chat_BufferStart + Descriptors.Chat_FirstChannelName);
					text2 = (string)Read.Single<string>(Offsets.Chat_BufferStart + Descriptors.Chat_FirstName);
					text3 = (string)Read.Single<string>(Offsets.Chat_BufferStart + Descriptors.Chat_FirstMessage);
				}
				if (text3.Length > 0)
				{
					if (text.Length > 0 && text2.Length > 0)
					{
						return string.Concat(new string[]
						{
							"[",
							text,
							"][",
							text2,
							"]: ",
							text3
						});
					}
					if (text2.Length > 0)
					{
						return "[Whisper][" + text2 + "]: " + text3;
					}
				}
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0071CFAC File Offset: 0x0071B1AC
		public static string ReadLastMessage()
		{
			try
			{
				return Chat.ReadMessage((int)Read.Single<int>(Offsets.Chat_BufferPosition));
			}
			catch
			{
			}
			return "";
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0071CFEC File Offset: 0x0071B1EC
		public static void UpdateLog()
		{
			int num = 0;
			try
			{
				num = (int)Read.Single<int>(Offsets.Chat_BufferPosition);
			}
			catch
			{
			}
			if (num == Chat.LastPosition)
			{
				return;
			}
			int num2 = Chat.LastPosition;
			object @lock;
			if (num < Chat.LastPosition)
			{
				@lock = Chat._lock;
				lock (@lock)
				{
					for (int i = Chat.LastPosition + 1; i <= 60; i++)
					{
						Chat.Log.Add(Chat.ReadMessage(i));
					}
				}
				num2 = 0;
			}
			@lock = Chat._lock;
			lock (@lock)
			{
				for (int j = num2 + 1; j <= num; j++)
				{
					Chat.Log.Add(Chat.ReadMessage(j));
				}
			}
			Chat.LastPosition = num;
		}

		// Token: 0x04000ABC RID: 2748
		public static int LastPosition = 0;

		// Token: 0x04000ABD RID: 2749
		public static List<string> Log = new List<string>();

		// Token: 0x04000ABE RID: 2750
		public static object _lock = new object();
	}
}
