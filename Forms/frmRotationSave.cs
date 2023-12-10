using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x020000B9 RID: 185
	public partial class frmRotationSave : Form
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x007012DC File Offset: 0x006FF4DC
		public frmRotationSave(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			this.Args = args;
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00701324 File Offset: 0x006FF524
		private void frmRotationSave_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Save Rotation", true, false, true, true, false, false);
			int num = this.Args.Count<object>();
			if (num > 0)
			{
				this.ProfileFolder = (string)this.Args[0];
				if (num > 1 && this.Args[1].ToString().Length > 0)
				{
					this.Mode = "Edit";
					this.PreviousProfileName = (string)this.Args[1];
					this.txtName.Text = this.PreviousProfileName;
				}
			}
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x007013B0 File Offset: 0x006FF5B0
		private void txtName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.Save();
			}
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x007013D0 File Offset: 0x006FF5D0
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x007013E4 File Offset: 0x006FF5E4
		private void Save()
		{
			string text = this.txtName.Text.ToString();
			if (text.Length > 0)
			{
				bool flag = true;
				string path = _globals.JackRotations + "\\" + text + ".json";
				string path2 = "";
				if (this.Mode == "Edit")
				{
					path2 = _globals.JackProfiles + "\\" + this.PreviousProfileName + ".json";
				}
				if (File.Exists(path) && (this.Mode == "New" || (this.Mode == "Edit" && text != this.PreviousProfileName)))
				{
					if (MessageBox.Show("A Rotation with this name already exists.\r\nDo you want to overwrite the Profile?", Tools.RandomString(15, false), MessageBoxButtons.YesNo) != DialogResult.Yes)
					{
						flag = false;
					}
					else
					{
						File.Delete(path);
					}
				}
				if (this.Mode == "Edit" && File.Exists(path2))
				{
					File.Delete(path2);
				}
				if (flag)
				{
					Json.SaveRotation(this.ProfileFolder + text);
					Tools.InvokeMethod("frmMainRotations", "LoadProfiles", null, false);
					frmRotation.RecordedRotation.Clear();
					frmRotation.RotationSettings.Clear();
					Json.LoadRotation(this.ProfileFolder + text);
					frmMainRotations.JustSelect = true;
					Tools.InvokeMethod("frmMainRotations", "PreSelectProfile", null, false);
					frmMainRotations.JustSelect = false;
					Tools.HideForm("frmRotationConditions");
					Tools.HideForm("frmRotation");
					base.Close();
				}
			}
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00666D70 File Offset: 0x00664F70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400097B RID: 2427
		private object[] Args;

		// Token: 0x0400097C RID: 2428
		private string Mode = "New";

		// Token: 0x0400097D RID: 2429
		private string ProfileFolder = "";

		// Token: 0x0400097E RID: 2430
		private string PreviousProfileName = "";
	}
}
