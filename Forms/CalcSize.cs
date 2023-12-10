using System;

namespace Jack.Forms
{
	// Token: 0x02000052 RID: 82
	public static class CalcSize
	{
		// Token: 0x060007C2 RID: 1986 RVA: 0x0067DE98 File Offset: 0x0067C098
		public static string ToSize(this long value, CalcSize.SizeUnits unit)
		{
			return ((double)value / Math.Pow(1024.0, (double)((long)unit))).ToString("0");
		}

		// Token: 0x02000053 RID: 83
		public enum SizeUnits
		{
			// Token: 0x04000228 RID: 552
			Byte,
			// Token: 0x04000229 RID: 553
			KB,
			// Token: 0x0400022A RID: 554
			MB,
			// Token: 0x0400022B RID: 555
			GB,
			// Token: 0x0400022C RID: 556
			TB,
			// Token: 0x0400022D RID: 557
			PB,
			// Token: 0x0400022E RID: 558
			EB,
			// Token: 0x0400022F RID: 559
			ZB,
			// Token: 0x04000230 RID: 560
			YB
		}
	}
}
