using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Models;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x020000B6 RID: 182
	public partial class frmRotationAddSpell : Form
	{
		// Token: 0x0600130B RID: 4875 RVA: 0x006F6D38 File Offset: 0x006F4F38
		public frmRotationAddSpell(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			this.Args = args;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x006F6D60 File Offset: 0x006F4F60
		private void frmRotationAddSpell_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Add Spell", true, false, true, true, false, false);
			if (this.Args.Count<object>() > 0)
			{
				frmRotationAddSpell.SpellID = (int)this.Args[0];
				this.Item = ObjectManager.GetItemByID(frmRotationAddSpell.SpellID);
				if (this.Item != null)
				{
					this.selectType.Items.Clear();
					this.selectType.Items.Add("Food/Drink");
				}
			}
			this.selectType.SelectedIndex = 0;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x006F6DE8 File Offset: 0x006F4FE8
		private void btnAdd_Click(object sender, EventArgs e)
		{
			ICollection<Spellbook.SpellList> spellByID = Spellbook.GetSpellByID(frmRotationAddSpell.SpellID);
			if (this.Item == null)
			{
				if (spellByID.Count > 0)
				{
					Spellbook.SpellList spellList = spellByID.FirstOrDefault<Spellbook.SpellList>();
					Rotation rotation = new Rotation();
					rotation.ID = spellList.ID;
					rotation.RequiredLevel = spellList.RequiredLevel;
					rotation.Name = spellList.Name;
					rotation.Rank = spellList.Rank;
					rotation.Type = this.selectType.Text;
					rotation.IsItem = false;
					rotation.IsMacro = false;
					frmRotation.RecordedRotation.Add(rotation);
				}
			}
			else
			{
				Rotation rotation2 = new Rotation();
				rotation2.ID = this.Item.ItemID;
				rotation2.RequiredLevel = 0;
				rotation2.Name = this.Item.ItemName;
				rotation2.Rank = 0;
				rotation2.Type = this.selectType.Text;
				rotation2.IsItem = true;
				rotation2.IsMacro = false;
				frmRotation.RecordedRotation.Add(rotation2);
			}
			frmRotation.UpdateList();
			base.Close();
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00666D70 File Offset: 0x00664F70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x006F78B4 File Offset: 0x006F5AB4
		static DialogResult smethod_0(string string_0, string string_1, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0)
		{
			return MessageBox.Show(string_0, string_1, messageBoxButtons_0, messageBoxIcon_0);
		}

		// Token: 0x040008FD RID: 2301
		private object[] Args;

		// Token: 0x040008FE RID: 2302
		private static int SpellID;

		// Token: 0x040008FF RID: 2303
		private Items Item;
	}
}
