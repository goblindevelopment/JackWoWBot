using System;
using System.Windows.Forms;

namespace Jack
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0066A520 File Offset: 0x00668720
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmMain());
		}
	}
}
