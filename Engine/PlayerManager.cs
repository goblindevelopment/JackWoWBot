using System;
using System.Collections.Generic;
using System.Threading;
using Jack.Core;

namespace Jack.Engine
{
	// Token: 0x020000E9 RID: 233
	internal class PlayerManager
	{
		// Token: 0x06001633 RID: 5683 RVA: 0x00714AF4 File Offset: 0x00712CF4
		public static void Update()
		{
			for (;;)
			{
				if (!_globals.Ready)
				{
					Thread.Sleep(1000);
				}
				else
				{
					object @lock = PlayerManager._lock;
					lock (@lock)
					{
						PlayerManager.Names.Clear();
						int num = (int)Read.Single<int>(Offsets.Player_NameCache + Descriptors.PlayerFields_NameCount);
						IntPtr pointer = (IntPtr)Read.Single<IntPtr>(Offsets.Player_NameCache + Descriptors.PlayerFields_NameArray);
						if (num > 0)
						{
							for (int i = 0; i < num; i++)
							{
								if ((byte)Read.Combined<byte>(pointer + Descriptors.PlayerFields_NameEntryAndGUID * i) > 0)
								{
									IntPtr pointer2 = (IntPtr)Read.Combined<IntPtr>(pointer + Descriptors.PlayerFields_NameEntryAndGUID * i);
									UInt128 @uint = (UInt128)Read.Combined<UInt128>(pointer2 + Descriptors.PlayerFields_NameEntryAndGUID);
									if (@uint > 0)
									{
										try
										{
											string text = (string)Read.Combined<string>(pointer2 + 25);
											if (text.Length > 0)
											{
												PlayerManager.Names.Add(@uint, text);
											}
										}
										catch
										{
										}
									}
								}
							}
						}
					}
					Thread.Sleep(1000);
				}
			}
		}

		// Token: 0x04000A71 RID: 2673
		public static Dictionary<UInt128, string> Names = new Dictionary<UInt128, string>();

		// Token: 0x04000A72 RID: 2674
		public static object _lock = new object();
	}
}
