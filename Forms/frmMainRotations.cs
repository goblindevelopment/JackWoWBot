using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000093 RID: 147
	public partial class frmMainRotations : Form
	{
		// Token: 0x06000F10 RID: 3856 RVA: 0x006D06F4 File Offset: 0x006CE8F4
		public frmMainRotations()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x006D0744 File Offset: 0x006CE944
		private void frmMainRotations_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x006D0768 File Offset: 0x006CE968
		private void frmMainRotations_Shown(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x006D0768 File Offset: 0x006CE968
		private void frmMainRotations_SizeChanged(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x006D077C File Offset: 0x006CE97C
		private void CenterListViewColumns()
		{
			if (Jack.Core.Settings.RotationsDisplayMode == "Details")
			{
				Tools.CenterListViewColumns(this.listProfiles, null);
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x006D07A8 File Offset: 0x006CE9A8
		private void frmMainRotations_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x006D07CC File Offset: 0x006CE9CC
		private void LoadControlsAndSettings()
		{
			if (Jack.Core.Settings.RotationsDisplayMode.Length > 0)
			{
				this.selectDisplayMode.SelectedIndex = this.selectDisplayMode.FindStringExact(Jack.Core.Settings.RotationsDisplayMode);
			}
			else
			{
				this.selectDisplayMode.SelectedIndex = 0;
			}
			if (!Directory.Exists(_globals.JackRotations))
			{
				Directory.CreateDirectory(_globals.JackRotations);
			}
			if (File.Exists(_globals.JackRotations + "\\" + Jack.Core.Settings.SelectedRotation + ".json") && Jack.Core.Settings.SelectedRotation.Contains("\\"))
			{
				this.CurrentDirectory = _globals.JackRotations + "\\" + Jack.Core.Settings.SelectedRotation.Split(new char[]
				{
					'\\'
				})[0];
			}
			this.LoadProfiles();
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x006D088C File Offset: 0x006CEA8C
		public void LoadProfiles()
		{
			int num = 0;
			int num2 = 0;
			bool flag = Convert.ToBoolean(this.listProfiles.View.ToString() == "Details");
			Dictionary<string[], string[]> dictionary = new Dictionary<string[], string[]>();
			this.listProfiles.Items.Clear();
			if (this.CurrentDirectory != _globals.JackRotations)
			{
				string[] key = new string[]
				{
					"...",
					"0"
				};
				dictionary.Add(key, null);
				num++;
			}
			DirectoryInfo directoryInfo = new DirectoryInfo(this.CurrentDirectory);
			FileInfo[] files = directoryInfo.GetFiles();
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			for (int i = 0; i < directories.Count<DirectoryInfo>(); i++)
			{
				string[] key = new string[]
				{
					directories[i].Name,
					"0"
				};
				dictionary.Add(key, null);
				num++;
			}
			for (int j = 0; j < files.Count<FileInfo>(); j++)
			{
				if (files[j].Extension.ToUpper() == ".JSON")
				{
					if (flag)
					{
						string[] key = new string[]
						{
							files[j].Name.Replace(".json", ""),
							"1",
							files[j].CreationTime.ToString()
						};
						dictionary.Add(key, null);
					}
					else
					{
						string[] key = new string[]
						{
							files[j].Name.Replace(".json", ""),
							"1"
						};
						dictionary.Add(key, null);
					}
					num2++;
				}
			}
			Tools.ControlListViewCreate(dictionary, "listProfiles", "frmMainRotations", true, -1, this.imageListSmall);
			bool status = Convert.ToBoolean(num + num2 == 0);
			this.ShowNoProfilesButton(status);
			this.PreSelectProfile();
			this.Search();
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x006D0A6C File Offset: 0x006CEC6C
		public void PreSelectProfile()
		{
			if (Jack.Core.Settings.SelectedRotation.Length > 0)
			{
				string text = Jack.Core.Settings.SelectedRotation;
				if (text.Contains("\\"))
				{
					text = Jack.Core.Settings.SelectedRotation.Split(new char[]
					{
						'\\'
					})[1];
				}
				int count = this.listProfiles.Items.Count;
				if (count > 0)
				{
					for (int i = 0; i < count; i++)
					{
						if (this.listProfiles.Items[i].SubItems[0].Text == text)
						{
							this.listProfiles.Items[i].Focused = true;
							this.listProfiles.Items[i].Selected = true;
							this.listProfiles.Items[i].EnsureVisible();
							this.listProfiles.Select();
							break;
						}
					}
				}
			}
			this.EnableButtons();
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x006D0B58 File Offset: 0x006CED58
		private void btnCreateProfile_Click(object sender, EventArgs e)
		{
			this.CreateNewProfile();
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x006D0B6C File Offset: 0x006CED6C
		private void CreateNewProfile()
		{
			frmRotation.Mode = "New";
			frmRotation.ProfileFolder = "";
			frmRotation.ProfileName = "";
			if (this.CurrentDirectory != _globals.JackRotations)
			{
				frmRotation.ProfileFolder = Tools.GetParentOrLastDirectory(this.CurrentDirectory, true) + "\\";
			}
			Tools.ShowForm("frmRotation");
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x006D0BD0 File Offset: 0x006CEDD0
		private void listProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!frmMainRotations.JustSelect)
			{
				this.ChangeProfile("");
			}
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x006D0BF0 File Offset: 0x006CEDF0
		private void ChangeProfile(string OnRename = "")
		{
			string text = this.GetSelection(this.listProfiles);
			if (text.Length > 0)
			{
				if (OnRename.Length > 0)
				{
					text = OnRename;
				}
				if (File.Exists(this.CurrentDirectory + "\\" + text + ".json") && text != Jack.Core.Settings.SelectedRotation)
				{
					text = this.GetSelectionWithParentDirectory(text);
					Json.LoadRotation(text);
				}
			}
			this.EnableButtons();
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x006D0C5C File Offset: 0x006CEE5C
		public void EditProfile()
		{
			string text = this.GetSelection(this.listProfiles);
			if (text.Length > 0 && File.Exists(this.CurrentDirectory + "\\" + text + ".json"))
			{
				frmRotation.Mode = "Edit";
				frmRotation.ProfileFolder = "";
				frmRotation.ProfileName = "";
				string profileFolder = "";
				string profileName = text;
				text = this.GetSelectionWithParentDirectory(text);
				if (text.Contains("\\"))
				{
					string[] array = text.Split(new char[]
					{
						'\\'
					});
					profileFolder = array[0] + "\\";
					profileName = array[1];
				}
				frmRotation.Mode = "Edit";
				frmRotation.ProfileFolder = profileFolder;
				frmRotation.ProfileName = profileName;
				Tools.ShowForm("frmRotation");
				return;
			}
			MessageBox.Show("Please select a Rotation first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x006D0D34 File Offset: 0x006CEF34
		private void listProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string selection = this.GetSelection(this.listProfiles);
			if (selection.Length > 0)
			{
				if (File.Exists(this.CurrentDirectory + "\\" + selection + ".json"))
				{
					this.EditProfile();
					return;
				}
				this.ChangeDirectory(selection);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x006D0D84 File Offset: 0x006CEF84
		private void ChangeDirectory(string DirectoryName)
		{
			if (DirectoryName == "...")
			{
				DirectoryInfo parent = Directory.GetParent(this.CurrentDirectory + "\\");
				this.CurrentDirectory = parent.Parent.FullName;
			}
			else
			{
				this.CurrentDirectory = this.CurrentDirectory + "\\" + DirectoryName;
			}
			this.LoadProfiles();
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x006D0DE4 File Offset: 0x006CEFE4
		private void btnCreateFolder_Click(object sender, EventArgs e)
		{
			this.CreateNewDirectory();
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x006D0DF8 File Offset: 0x006CEFF8
		private void CreateNewDirectory()
		{
			string text = "";
			string path = this.CurrentDirectory + "\\" + text;
			int num = 1;
			while (Directory.Exists(path))
			{
				text = "New folder (" + num.ToString() + ")";
				path = this.CurrentDirectory + "\\" + text;
				num++;
			}
			Directory.CreateDirectory(path);
			this.LoadProfiles();
			int count = this.listProfiles.Items.Count;
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					if (this.listProfiles.Items[i].SubItems[0].Text == text)
					{
						this.listProfiles.Items[i].Focused = true;
						this.listProfiles.Items[i].Selected = true;
						this.listProfiles.Items[i].EnsureVisible();
						this.listProfiles.Select();
						this.listProfiles.Items[i].BeginEdit();
						return;
					}
				}
			}
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x006D0F24 File Offset: 0x006CF124
		private void btnDelete_Click(object sender, EventArgs e)
		{
			this.Delete();
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x006D0F38 File Offset: 0x006CF138
		private void listProfiles_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.Delete();
			}
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x006D0F58 File Offset: 0x006CF158
		private void Delete()
		{
			if (this.CurrentDirectory.StartsWith("Premium:"))
			{
				return;
			}
			ListView.SelectedListViewItemCollection selectedItems = this.listProfiles.SelectedItems;
			if (selectedItems.Count == 0)
			{
				return;
			}
			if (MessageBox.Show("Do you really want to delete the selected files?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
			{
				return;
			}
			foreach (object obj in selectedItems)
			{
				string text = ((ListViewItem)obj).SubItems[0].Text;
				string path = this.CurrentDirectory + "\\" + text + ".json";
				bool flag = Directory.Exists(this.CurrentDirectory + "\\" + text);
				if (File.Exists(path) || flag)
				{
					if (!flag)
					{
						_globals.Rotation.Clear();
						_globals.RotationSettings.Clear();
						File.Delete(path);
					}
					else
					{
						Directory.Delete(this.CurrentDirectory + "\\" + text, true);
					}
				}
			}
			this.LoadProfiles();
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x006D1078 File Offset: 0x006CF278
		private void Copy()
		{
			if (this.CurrentDirectory.StartsWith("Premium:"))
			{
				return;
			}
			ListView.SelectedListViewItemCollection selectedItems = this.listProfiles.SelectedItems;
			if (selectedItems.Count == 0)
			{
				return;
			}
			this.CopiedFiles.Clear();
			foreach (object obj in selectedItems)
			{
				string text = ((ListViewItem)obj).SubItems[0].Text;
				string text2 = this.CurrentDirectory + "\\" + text + ".json";
				if (File.Exists(text2))
				{
					this.CopiedFiles.Add(text, text2);
				}
			}
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x006D1138 File Offset: 0x006CF338
		private void Paste(string CustomPasteDirectory = "")
		{
			if (this.CutFiles)
			{
				_globals.Rotation.Clear();
				_globals.RotationSettings.Clear();
			}
			string text = this.CurrentDirectory;
			if (CustomPasteDirectory.Length > 0)
			{
				text = CustomPasteDirectory;
			}
			foreach (KeyValuePair<string, string> keyValuePair in this.CopiedFiles)
			{
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				string text2 = text + "\\" + key + ".json";
				if (File.Exists(value))
				{
					if (File.Exists(text2))
					{
						int num = 2;
						while (File.Exists(text2))
						{
							text2 = string.Concat(new string[]
							{
								text,
								"\\",
								key,
								" (",
								num.ToString(),
								").json"
							});
							num++;
						}
					}
					File.Copy(value, text2);
					if (this.CutFiles)
					{
						File.Delete(value);
					}
				}
			}
			this.CopiedFiles.Clear();
			this.CutFiles = false;
			this.LoadProfiles();
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x006D126C File Offset: 0x006CF46C
		private void listProfiles_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (e.Clicks == 1)
				{
					if (this.listProfiles.SelectedItems.Count == 0)
					{
						return;
					}
					this.IsDragging = true;
				}
			}
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x006D12B0 File Offset: 0x006CF4B0
		private void listProfiles_MouseMove(object sender, MouseEventArgs e)
		{
			if (!this.IsDragging)
			{
				return;
			}
			if (this.listProfiles.SelectedItems.Count != 0)
			{
				if (Cursor.Current != this.DragCursor)
				{
					this.listProfiles.Cursor = this.DragCursor;
					Cursor.Current = this.DragCursor;
				}
				this.GetDragDirectory();
				return;
			}
			this.DragDone();
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x006D1314 File Offset: 0x006CF514
		private void GetDragDirectory()
		{
			Point point = this.listProfiles.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
			ListViewItem itemAt = this.listProfiles.GetItemAt(point.X, point.Y);
			if (itemAt == null || itemAt.Text == "...")
			{
				return;
			}
			if (this.CurrentDraggingDirectoryName == itemAt.Text)
			{
				return;
			}
			this.CurrentDraggingDirectoryName = itemAt.Text;
			if (Directory.Exists(this.CurrentDirectory + "\\" + this.CurrentDraggingDirectoryName))
			{
				foreach (object obj in this.listProfiles.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (!File.Exists(this.CurrentDirectory + "\\" + listViewItem.Text + ".json"))
					{
						listViewItem.Selected = false;
					}
				}
				itemAt.Selected = true;
				return;
			}
			this.CurrentDraggingDirectoryName = "";
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x006D144C File Offset: 0x006CF64C
		private void DragDone()
		{
			this.CurrentDraggingDirectoryName = "";
			this.IsDragging = false;
			Cursor.Current = Cursors.Default;
			this.listProfiles.Cursor = Cursors.Default;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x006D1488 File Offset: 0x006CF688
		private void btnRename_Click(object sender, EventArgs e)
		{
			this.Rename();
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x006D149C File Offset: 0x006CF69C
		private void Rename()
		{
			if (this.GetSelection(this.listProfiles).Length > 0)
			{
				this.listProfiles.SelectedItems[0].BeginEdit();
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x006D14D4 File Offset: 0x006CF6D4
		private void listProfiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			string text = this.GetSelection(this.listProfiles);
			if (text.Length > 0 && e.Label != null)
			{
				if (e.Label.Length > 0 && text != e.Label)
				{
					string text2 = this.CurrentDirectory + "\\" + text;
					bool flag = false;
					if (File.Exists(this.CurrentDirectory + "\\" + e.Label + ".json"))
					{
						flag = true;
						text += ".json";
					}
					else if (Directory.Exists(this.CurrentDirectory + "\\" + e.Label))
					{
						flag = true;
					}
					if (flag)
					{
						MessageBox.Show("A rotation or folder with this name already exists.\r\nPlease choose another name.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						e.CancelEdit = true;
						return;
					}
					if (!File.Exists(text2 + ".json"))
					{
						if (!Directory.Exists(text2))
						{
							return;
						}
						try
						{
							Directory.Move(text2, this.CurrentDirectory + "\\" + e.Label);
							return;
						}
						catch
						{
							return;
						}
					}
					File.Move(text2 + ".json", this.CurrentDirectory + "\\" + e.Label + ".json");
					this.ChangeProfile(e.Label);
					return;
				}
				else
				{
					e.CancelEdit = true;
				}
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x006D1638 File Offset: 0x006CF838
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			this.Search();
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x006D164C File Offset: 0x006CF84C
		private void Search()
		{
			bool enabled = false;
			int count = this.listProfiles.Items.Count;
			if (count > 0)
			{
				string text = this.txtSearch.Text.ToLower();
				if (text.Length <= 0)
				{
					for (int i = 0; i < this.listProfiles.Items.Count; i++)
					{
						this.listProfiles.Items[i].ForeColor = Color.White;
					}
				}
				else
				{
					enabled = true;
					for (int j = 0; j < count; j++)
					{
						string text2 = this.listProfiles.Items[j].Text.ToLower();
						if (text2 != "..." && text2.Contains(text))
						{
							this.listProfiles.Items[j].ForeColor = Color.LimeGreen;
						}
						else
						{
							this.listProfiles.Items[j].ForeColor = Color.FromArgb(14, 17, 22);
						}
					}
				}
			}
			this.btnErase.Enabled = enabled;
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x006D175C File Offset: 0x006CF95C
		private void btnErase_Click(object sender, EventArgs e)
		{
			this.txtSearch.Text = "";
			this.LoadProfiles();
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x006D1780 File Offset: 0x006CF980
		private void EnableButtons()
		{
			bool enabled = false;
			string selection = this.GetSelection(this.listProfiles);
			if (selection.Length > 0 && selection != "...")
			{
				enabled = true;
			}
			this.btnRename.Enabled = enabled;
			this.btnDelete.Enabled = enabled;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x006D0B58 File Offset: 0x006CED58
		private void btnNoProfiles_Click(object sender, EventArgs e)
		{
			this.CreateNewProfile();
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x006D17CC File Offset: 0x006CF9CC
		private void ShowNoProfilesButton(bool Status)
		{
			this.btnNoProfiles.Location = this.listProfiles.Location;
			this.btnNoProfiles.Size = this.listProfiles.Size;
			this.listProfiles.Visible = !Status;
			this.btnNoProfiles.Visible = Status;
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x006D1820 File Offset: 0x006CFA20
		private string GetSelection(ListView WhichListView = null)
		{
			if (WhichListView.SelectedItems.Count > 0)
			{
				string text = WhichListView.SelectedItems[0].SubItems[0].Text;
				if (text != "None")
				{
					return text;
				}
			}
			return "";
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x006D186C File Offset: 0x006CFA6C
		private string GetSelectionWithParentDirectory(string Selection)
		{
			if (this.CurrentDirectory != _globals.JackRotations)
			{
				Selection = new DirectoryInfo(this.CurrentDirectory + "\\a").Parent.Name + "\\" + Selection;
			}
			return Selection;
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x006D18B8 File Offset: 0x006CFAB8
		private void selectDisplayMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.listProfiles.FullRowSelect = false;
			string text = this.selectDisplayMode.SelectedItem.ToString();
			Jack.Core.Settings.RotationsDisplayMode = text;
			if (text == "List")
			{
				this.listProfiles.View = View.List;
				return;
			}
			if (text == "Large Icon")
			{
				this.listProfiles.View = View.LargeIcon;
				return;
			}
			if (text == "Tile")
			{
				this.listProfiles.View = View.Tile;
				return;
			}
			if (text == "Details")
			{
				this.listProfiles.View = View.Details;
				this.listProfiles.FullRowSelect = true;
				this.LoadProfiles();
				this.CenterListViewColumns();
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x006D1968 File Offset: 0x006CFB68
		private void listProfiles_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.IsDragging && this.CurrentDraggingDirectoryName.Length > 0)
			{
				string customPasteDirectory = this.CurrentDirectory + "\\" + this.CurrentDraggingDirectoryName;
				this.CutFiles = true;
				this.Copy();
				this.Paste(customPasteDirectory);
			}
			this.DragDone();
			this.ShowContextMenu(sender, e);
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x006D19C4 File Offset: 0x006CFBC4
		private void ShowContextMenu(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				List<string> list = new List<string>();
				ListView.SelectedListViewItemCollection selectedItems = this.listProfiles.SelectedItems;
				bool flag;
				if ((flag = (selectedItems.Count == 1)) && selectedItems.Count > 0)
				{
					using (IEnumerator enumerator = selectedItems.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((ListViewItem)enumerator.Current).SubItems[0].Text.Contains("..."))
							{
								flag = false;
								break;
							}
						}
					}
				}
				string selection = this.GetSelection(this.listProfiles);
				if (selection != "...")
				{
					if (flag)
					{
						list.Add("Edit...");
						list.Add("-");
					}
					list.Add("Copy");
					list.Add("Cut");
				}
				if (this.CopiedFiles.Count > 0)
				{
					list.Add("Paste");
				}
				if (selection != "...")
				{
					if (flag)
					{
						list.Add("Rename");
					}
					list.Add("Delete");
					list.Add("-");
				}
				list.Add("Create new Rotation...");
				if (this.CurrentDirectory == _globals.JackRotations)
				{
					list.Add("Create new Folder");
				}
				list.Add("-");
				list.Add("Open in Explorer");
				list.Add("Reload Folder");
				Tools.CreateContextMenu(sender, e, "frmMainRotations", "listProfiles", "ItemAction", list.ToArray(), null);
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x006D1B64 File Offset: 0x006CFD64
		public void ItemAction(object sender, MouseEventArgs e, string Action = "")
		{
			if (Action == "Edit...")
			{
				this.EditProfile();
				return;
			}
			if (Action == "Create new Rotation...")
			{
				this.CreateNewProfile();
				return;
			}
			if (Action == "Create new Folder")
			{
				this.CreateNewDirectory();
				return;
			}
			if (Action == "Copy")
			{
				this.Copy();
				this.CutFiles = false;
				return;
			}
			if (Action == "Cut")
			{
				this.Copy();
				this.CutFiles = true;
				return;
			}
			if (Action == "Paste")
			{
				this.Paste("");
				return;
			}
			if (Action == "Rename")
			{
				this.Rename();
				return;
			}
			if (!(Action == "Delete"))
			{
				if (Action == "Open in Explorer")
				{
					if (this.CurrentDirectory.Length > 0)
					{
						Process.Start(this.CurrentDirectory);
						return;
					}
				}
				else if (Action == "Reload Folder")
				{
					this.LoadProfiles();
				}
				return;
			}
			this.Delete();
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x006D1C64 File Offset: 0x006CFE64
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x04000682 RID: 1666
		private string CurrentDirectory = _globals.JackRotations;

		// Token: 0x04000683 RID: 1667
		public static bool JustSelect = false;

		// Token: 0x04000684 RID: 1668
		private Dictionary<string, string> CopiedFiles = new Dictionary<string, string>();

		// Token: 0x04000685 RID: 1669
		private bool CutFiles;

		// Token: 0x04000686 RID: 1670
		private bool IsDragging;

		// Token: 0x04000687 RID: 1671
		private string CurrentDraggingDirectoryName = "";

		// Token: 0x04000688 RID: 1672
		private static MemoryStream CursorMS = new MemoryStream(Resources.icon_copy);

		// Token: 0x04000689 RID: 1673
		private Cursor DragCursor = new Cursor(frmMainRotations.CursorMS);
	}
}
