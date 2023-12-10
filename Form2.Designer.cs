namespace RotationLabEngine
{
	// Token: 0x02000028 RID: 40
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x060003EE RID: 1006 RVA: 0x00025EA4 File Offset: 0x000240A4
		protected override void Dispose(bool disposing)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 2:
					if (disposing)
					{
						goto IL_AB;
					}
					num2 = 1;
					if (global::<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					goto IL_4B;
				case 4:
					goto IL_AB;
				}
				break;
				IL_4B:
				global::RotationLabEngine.Form2.a7PmI0Z62Y1Sex25Im5(this.components);
				num2 = 5;
				if (global::<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 != 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_AB:
				if (this.components != null)
				{
					goto IL_4B;
				}
				num2 = 0;
				if (global::<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
				{
					num2 = 0;
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x040001A6 RID: 422
		private global::System.ComponentModel.IContainer components;
	}
}
