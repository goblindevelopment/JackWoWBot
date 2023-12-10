namespace RotationLabEngine
{
	// Token: 0x0200001D RID: 29
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00013A4C File Offset: 0x00011C4C
		protected override void Dispose(bool disposing)
		{
			int num = 5;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						goto IL_AC;
					case 3:
						goto IL_5D;
					case 4:
						goto IL_AC;
					case 5:
						if (!disposing)
						{
							goto Block_2;
						}
						goto IL_5D;
					}
					IL_48:
					this.components.Dispose();
					num2 = 2;
					continue;
					IL_AC:
					global::RotationLabEngine.Form1.MQIB1bhArSPVHWLFbwW(this, disposing);
					num2 = 1;
					if (global::<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24213672444f404ab1c51fbb2634eb8c == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
					IL_5D:
					if (this.components == null)
					{
						goto IL_AC;
					}
					goto IL_48;
				}
				Block_2:
				num = 4;
			}
		}

		// Token: 0x04000110 RID: 272
		private global::System.ComponentModel.IContainer components;
	}
}
