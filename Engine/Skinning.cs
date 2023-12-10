using System;
using System.Collections.Generic;
using Jack.ATH;
using Jack.Core;

namespace Jack.Engine
{
	// Token: 0x020000C8 RID: 200
	public static class Skinning
	{
		// Token: 0x06001507 RID: 5383 RVA: 0x0070DCA8 File Offset: 0x0070BEA8
		public static void Monitor()
		{
			MDL.Call("Skinning", "Monitor", null, false);
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0070DCC8 File Offset: 0x0070BEC8
		public static void Add(UInt128 UnitGUID)
		{
			if (_globals.ModuleGather)
			{
				MDL.Call("Skinning", "Add", new object[]
				{
					UnitGUID
				}, false);
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0070DCFC File Offset: 0x0070BEFC
		public static List<UInt128> SkinnableUnits
		{
			get
			{
				if (_globals.ModuleGather)
				{
					return (List<UInt128>)MDL.Call("Skinning", "SkinnableUnits", null, true);
				}
				return new List<UInt128>();
			}
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0070DD2C File Offset: 0x0070BF2C
		public static void Get()
		{
			if (_globals.ModuleGather)
			{
				MDL.Call("Skinning", "Get", null, false);
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0070DD54 File Offset: 0x0070BF54
		public static void GetAfterLoot(UInt128 UnitGUID)
		{
			if (_globals.ModuleGather)
			{
				MDL.Call("Skinning", "GetAfterLoot", new object[]
				{
					UnitGUID
				}, false);
			}
		}

		// Token: 0x040009F7 RID: 2551
		public static Dictionary<UInt128, bool> List = new Dictionary<UInt128, bool>();

		// Token: 0x040009F8 RID: 2552
		public static object _lock = new object();

		// Token: 0x040009F9 RID: 2553
		public static bool Runs = false;

		// Token: 0x040009FA RID: 2554
		public static bool Stop = false;
	}
}
