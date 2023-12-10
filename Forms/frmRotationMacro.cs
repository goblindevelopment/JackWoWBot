using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Models;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000063 RID: 99
	public partial class frmRotationMacro : Form
	{
		// Token: 0x06000912 RID: 2322 RVA: 0x0068678C File Offset: 0x0068498C
		public frmRotationMacro()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x006867AC File Offset: 0x006849AC
		private void frmRotationMacro_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Macro", true, true, true, true, false, false);
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x006867CC File Offset: 0x006849CC
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtMacroName.Text.Trim();
			string text2 = this.txtMacroValue.Text.Replace("\r\n", "#").Trim();
			string text3 = this.txtMacroCooldown.Text.Trim();
			if (text3.Length == 0)
			{
				text3 = "0";
			}
			if (text.Length == 0)
			{
				this.txtMacroName.BorderColor = Color.Red;
				return;
			}
			if (text2.Length <= 3)
			{
				this.txtMacroValue.BorderColor = Color.Red;
				return;
			}
			if (!Tools.IsNumber(text3, 1, 0, 0, 0))
			{
				this.txtMacroCooldown.BorderColor = Color.Red;
				return;
			}
			Rotation rotation = new Rotation();
			rotation.ID = frmRotationMacro.GenerateID;
			rotation.RequiredLevel = 0;
			rotation.Name = text;
			rotation.Rank = 0;
			rotation.Type = "Combat";
			rotation.IsItem = false;
			rotation.IsMacro = true;
			rotation.Cooldown = Convert.ToInt32(text3);
			frmRotation.RecordedRotation.Add(rotation);
			frmRotation.UpdateList();
			base.Close();
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00666D70 File Offset: 0x00664F70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x006868E0 File Offset: 0x00684AE0
		public static int GenerateID
		{
			get
			{
				bool flag = false;
				int num = 0;
				for (;;)
				{
					flag = false;
					num = Tools.Rnd.Next(10000, 99999);
					if (frmRotation.RecordedRotation.Count > 0)
					{
						using (List<Rotation>.Enumerator enumerator = frmRotation.RecordedRotation.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.ID == num)
								{
									flag = true;
									break;
								}
							}
						}
					}
					if (!flag)
					{
						break;
					}
					Thread.Sleep(5);
				}
				return num;
			}
		}
	}
}
