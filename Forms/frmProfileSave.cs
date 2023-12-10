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
	// Token: 0x020000B1 RID: 177
	public partial class frmProfileSave : Form
	{
		// Token: 0x06001232 RID: 4658 RVA: 0x006EC520 File Offset: 0x006EA720
		public frmProfileSave(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			this.Args = args;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x006EC568 File Offset: 0x006EA768
		private void frmProfileSave_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Save Profile", true, false, true, true, false, false);
			if (this.Args.Count<object>() > 0)
			{
				this.Mode = (string)this.Args[0];
				this.ProfileFolder = (string)this.Args[1];
				if (this.Mode == "Edit" && this.Args.Count<object>() > 1)
				{
					this.PreviousProfileName = (string)this.Args[2];
				}
			}
			if (this.Mode == "Edit")
			{
				this.txtName.Text = this.PreviousProfileName;
			}
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x006EC610 File Offset: 0x006EA810
		private void txtName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.Save();
			}
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x006EC630 File Offset: 0x006EA830
		private void btnSave_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x006EC644 File Offset: 0x006EA844
		private void Save()
		{
			string text = this.txtName.Text.ToString();
			if (text.Length > 0)
			{
				bool flag = true;
				string path = _globals.JackProfiles + "\\" + text + ".json";
				string path2 = "";
				if (this.Mode == "Edit")
				{
					path2 = _globals.JackProfiles + "\\" + this.PreviousProfileName + ".json";
				}
				if (File.Exists(path) && (this.Mode == "New" || (this.Mode == "Edit" && text != this.PreviousProfileName)))
				{
					if (MessageBox.Show("A Profile with this name already exists.\r\nDo you want to overwrite the Profile?", Tools.RandomString(15, false), MessageBoxButtons.YesNo) != DialogResult.Yes)
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
					if (text != this.PreviousProfileName)
					{
						Tools.ReplaceInProfiles("\"LoadProfile\": \"" + this.PreviousProfileName + "\"", "\"LoadProfile\": \"" + text + "\"", new string[]
						{
							text
						});
					}
				}
				if (flag)
				{
					_globals.ShowRecordedProfile = false;
					Json.SaveProfile(this.ProfileFolder + text);
					Tools.InvokeMethod("frmMainProfiles", "LoadProfiles", null, false);
					frmProfile.RecordedWaypoints.Clear();
					frmProfile.RecordedEvents.Clear();
					Json.LoadProfile(this.ProfileFolder + text, true, true, false);
					frmMainProfiles.JustSelect = true;
					Tools.InvokeMethod("frmMainProfiles", "PreSelectProfile", null, false);
					frmMainProfiles.JustSelect = false;
					Tools.InvokeMethod("frmProfile", "HideAfterSave", null, false);
					base.Close();
				}
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x00666D70 File Offset: 0x00664F70
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0400087C RID: 2172
		private object[] Args;

		// Token: 0x0400087D RID: 2173
		private string Mode = "";

		// Token: 0x0400087E RID: 2174
		private string ProfileFolder = "";

		// Token: 0x0400087F RID: 2175
		private string PreviousProfileName = "";
	}
}
