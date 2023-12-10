using System;
using System.Collections.Generic;
using Jack.ATH;
using Jack.Core;

namespace Jack.Engine
{
	// Token: 0x020000C7 RID: 199
	public static class Nodes
	{
		// Token: 0x06001501 RID: 5377 RVA: 0x0070DBE4 File Offset: 0x0070BDE4
		public static void Monitor()
		{
			if (_globals.ModuleGather)
			{
				MDL.Call("Gather", "Monitor", null, false);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x0070DC0C File Offset: 0x0070BE0C
		public static List<UInt128> GatherableObjects
		{
			get
			{
				if (_globals.ModuleGather)
				{
					return (List<UInt128>)MDL.Call("Gather", "GatherableObjects", null, true);
				}
				return new List<UInt128>();
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0070DC3C File Offset: 0x0070BE3C
		public static void Get()
		{
			if (_globals.ModuleGather)
			{
				MDL.Call("Gather", "Get", null, false);
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0070DC64 File Offset: 0x0070BE64
		public static bool QuestsCompleted
		{
			get
			{
				return Jack.Engine.Monitor.QuestsCompleted;
			}
		}

		// Token: 0x040009F3 RID: 2547
		public static Dictionary<UInt128, bool> List = new Dictionary<UInt128, bool>();

		// Token: 0x040009F4 RID: 2548
		public static object _lock = new object();

		// Token: 0x040009F5 RID: 2549
		public static bool Runs = false;

		// Token: 0x040009F6 RID: 2550
		public static bool Stop = false;
	}
}
