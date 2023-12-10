using System;
using Jack.Engine;

namespace Jack.Models
{
	// Token: 0x0200004B RID: 75
	public class Player : Units
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x00672058 File Offset: 0x00670258
		public Player(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x0067BAE8 File Offset: 0x00679CE8
		public string PlayerName
		{
			get
			{
				object @lock = PlayerManager._lock;
				string result;
				lock (@lock)
				{
					if (PlayerManager.Names.ContainsKey(this.GUID128))
					{
						result = PlayerManager.Names[this.GUID128];
					}
					else
					{
						result = "N/A";
					}
				}
				return result;
			}
		}
	}
}
