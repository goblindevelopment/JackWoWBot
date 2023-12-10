using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.ATH;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000094 RID: 148
	public partial class frmMainProfiles : Form
	{
		// Token: 0x06000FA6 RID: 4006 RVA: 0x006D3208 File Offset: 0x006D1408
		public frmMainProfiles()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x006D3250 File Offset: 0x006D1450
		private void frmMainProfiles_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x006D3274 File Offset: 0x006D1474
		private void frmMainProfiles_Shown(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x006D3274 File Offset: 0x006D1474
		private void frmMainProfiles_SizeChanged(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x006D3288 File Offset: 0x006D1488
		private void CenterListViewColumns()
		{
			if (Jack.Core.Settings.ProfilesDisplayMode == "Details")
			{
				ListView listview = this.listProfiles;
				int[] array = new int[3];
				array[0] = -1;
				array[1] = -1;
				Tools.CenterListViewColumns(listview, array);
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x006D32C0 File Offset: 0x006D14C0
		private void frmMainProfiles_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x006D32E4 File Offset: 0x006D14E4
		private void LoadControlsAndSettings()
		{
			if (Jack.Core.Settings.ProfilesDisplayMode.Length > 0)
			{
				this.selectDisplayMode.SelectedIndex = this.selectDisplayMode.FindStringExact(Jack.Core.Settings.ProfilesDisplayMode);
			}
			else
			{
				this.selectDisplayMode.SelectedIndex = 0;
			}
			if (!Directory.Exists(_globals.JackProfiles))
			{
				Directory.CreateDirectory(_globals.JackProfiles);
			}
			if (File.Exists(_globals.JackProfiles + "\\" + Jack.Core.Settings.SelectedProfile + ".json") && Jack.Core.Settings.SelectedProfile.Contains("\\"))
			{
				frmMainProfiles.CurrentDirectory = _globals.JackProfiles + "\\" + Jack.Core.Settings.SelectedProfile.Split(new char[]
				{
					'\\'
				})[0];
			}
			this.LoadProfiles();
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x006D33A0 File Offset: 0x006D15A0
		public void LoadProfiles()
		{
			int num = 0;
			int num2 = 0;
			bool flag = Convert.ToBoolean(this.listProfiles.View.ToString() == "Details");
			bool flag2 = false;
			Dictionary<string[], string[]> dictionary = new Dictionary<string[], string[]>();
			if (frmMainProfiles.CurrentDirectory == _globals.JackProfiles)
			{
				string[] key = new string[]
				{
					"Premium",
					"0"
				};
				dictionary.Add(key, new string[]
				{
					"",
					"Purple"
				});
				this.btnCreateFolder.Enabled = true;
			}
			else
			{
				string[] key = new string[]
				{
					"...",
					"0"
				};
				dictionary.Add(key, null);
				num++;
				this.btnCreateFolder.Enabled = false;
			}
			if (frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
			{
				flag2 = true;
				string[] key;
				if (_globals.PremiumProfiles.Count > 0)
				{
					string premiumSubFolder = this.GetPremiumSubFolder();
					if (premiumSubFolder.Length > 0)
					{
						PFLS profileByDisplayName = PFL.GetProfileByDisplayName(premiumSubFolder);
						if (profileByDisplayName == null)
						{
							goto IL_410;
						}
						using (List<PFLS>.Enumerator enumerator = PFL.GetBundleProfiles(profileByDisplayName).GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								PFLS pfls = enumerator.Current;
								key = new string[]
								{
									pfls.DisplayName,
									"2",
									"",
									pfls.ID.ToString()
								};
								dictionary.Add(key, null);
							}
							goto IL_410;
						}
					}
					foreach (PFLS pfls2 in _globals.PremiumProfiles)
					{
						if (pfls2.IsClickable && pfls2.IsBundle)
						{
							key = new string[]
							{
								pfls2.DisplayName,
								"0",
								"",
								pfls2.ID.ToString()
							};
							dictionary.Add(key, null);
						}
					}
					using (List<PFLS>.Enumerator enumerator = _globals.PremiumProfiles.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							PFLS pfls3 = enumerator.Current;
							if (pfls3.IsClickable && !pfls3.IsBundle && !PFL.IsPartOfBundle(pfls3))
							{
								key = new string[]
								{
									pfls3.DisplayName,
									"2",
									"",
									pfls3.ID.ToString()
								};
								dictionary.Add(key, null);
							}
						}
						goto IL_410;
					}
				}
				key = new string[]
				{
					"Profile Store",
					"2",
					"",
					"0"
				};
				dictionary.Add(key, new string[]
				{
					"",
					"Purple"
				});
			}
			else
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(frmMainProfiles.CurrentDirectory);
				FileInfo[] files = directoryInfo.GetFiles();
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				for (int i = 0; i < directories.Count<DirectoryInfo>(); i++)
				{
					if (directories[i].Name != "Utilities")
					{
						string[] key = new string[]
						{
							directories[i].Name,
							"0"
						};
						dictionary.Add(key, null);
						num++;
					}
				}
				for (int j = 0; j < files.Count<FileInfo>(); j++)
				{
					if (files[j].Extension.ToUpper() == ".JSON")
					{
						if (!flag)
						{
							string[] key = new string[]
							{
								files[j].Name.Replace(".json", ""),
								"1"
							};
							dictionary.Add(key, null);
						}
						else
						{
							string[] key = new string[]
							{
								files[j].Name.Replace(".json", ""),
								"1",
								files[j].CreationTime.ToString()
							};
							dictionary.Add(key, null);
						}
						num2++;
					}
				}
			}
			IL_410:
			Tools.ControlListViewCreate(dictionary, "listProfiles", "frmMainProfiles", true, -1, this.imageListSmall);
			if (flag2)
			{
				this.btnCreateProfile.Enabled = false;
				this.btnCreateFolder.Enabled = false;
				this.btnDelete.Enabled = false;
				this.btnRename.Enabled = false;
				this.lblTitle.ForeColor = Color.FromArgb(192, 0, 192);
			}
			else
			{
				this.btnCreateProfile.Enabled = true;
				this.lblTitle.ForeColor = Color.FromArgb(153, 157, 169);
				bool status = num + num2 == 0 && _globals.PremiumProfiles.Count == 0;
				this.ShowNoProfilesButton(status);
			}
			this.PreSelectProfile();
			this.Search();
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x006D38A4 File Offset: 0x006D1AA4
		public void PreSelectProfile()
		{
			if (Jack.Core.Settings.SelectedProfile.Length > 0)
			{
				string text = Jack.Core.Settings.SelectedProfile;
				if (text.Contains("\\"))
				{
					text = Jack.Core.Settings.SelectedProfile.Split(new char[]
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

		// Token: 0x06000FAF RID: 4015 RVA: 0x006D3990 File Offset: 0x006D1B90
		private void Unload()
		{
			_globals.Waypoints.Clear();
			_globals.Events.Clear();
			_globals.ProfileSettings.Clear();
			Jack.Core.Settings.SelectedProfile = "";
			this.listProfiles.SelectedItems.Clear();
			Tools.Console("Profile unloaded.", "", "richConsole", "frmMain", true);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x006D39F0 File Offset: 0x006D1BF0
		private void btnCreateProfile_Click(object sender, EventArgs e)
		{
			this.CreateNewProfile();
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x006D3A04 File Offset: 0x006D1C04
		private void CreateNewProfile()
		{
			frmProfile.Mode = "New";
			frmProfile.ProfileFolder = "";
			frmProfile.ProfileName = "";
			if (frmMainProfiles.CurrentDirectory != _globals.JackProfiles)
			{
				frmProfile.ProfileFolder = Tools.GetParentOrLastDirectory(frmMainProfiles.CurrentDirectory, true) + "\\";
			}
			Tools.ShowForm("frmProfile");
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x006D3A64 File Offset: 0x006D1C64
		private void listProfiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!frmMainProfiles.JustSelect)
			{
				if (this.listProfiles.SelectedItems.Count == 1)
				{
					this.ChangeProfile("");
				}
			}
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x006D3A98 File Offset: 0x006D1C98
		private void ChangeProfile(string OnRename = "")
		{
			string text = this.GetSelection(this.listProfiles);
			if (!frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
			{
				if (text.Length > 0)
				{
					if (OnRename.Length > 0)
					{
						text = OnRename;
					}
					if (File.Exists(frmMainProfiles.CurrentDirectory + "\\" + text + ".json") && text != Jack.Core.Settings.SelectedProfile)
					{
						text = this.GetSelectionWithParentDirectory(text);
						Json.LoadProfile(text, true, true, false);
					}
				}
				this.EnableButtons();
			}
			else if (text.Length > 0 && text != "..." && text != Jack.Core.Settings.SelectedProfile && text != "Profile Store" && !this.IsPremiumFolder(this.listProfiles))
			{
				Json.LoadProfile(this.GetPremiumID(this.listProfiles), true, true, true);
				return;
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x006D3B6C File Offset: 0x006D1D6C
		public void EditProfile()
		{
			string text = this.GetSelection(this.listProfiles);
			if (text.Length > 0 && File.Exists(frmMainProfiles.CurrentDirectory + "\\" + text + ".json"))
			{
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
				frmMainProfiles.DisplayWaypointsAfterEditorLoaded = Jack.Core.Settings.OverlayWaypoints;
				frmMainOverlay.EnableOverlayWaypoints(false);
				frmProfile.Mode = "Edit";
				frmProfile.ProfileFolder = profileFolder;
				frmProfile.ProfileName = profileName;
				Tools.ShowForm("frmProfile");
				return;
			}
			MessageBox.Show("Please select a Profile first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x006D3C34 File Offset: 0x006D1E34
		private void listProfiles_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string selection = this.GetSelection(this.listProfiles);
			if (selection.Length > 0)
			{
				if (frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
				{
					this.ChangeDirectory(selection);
					return;
				}
				if (File.Exists(frmMainProfiles.CurrentDirectory + "\\" + selection + ".json"))
				{
					this.EditProfile();
					return;
				}
				this.ChangeDirectory(selection);
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x006D3C9C File Offset: 0x006D1E9C
		private void ChangeDirectory(string Selection)
		{
			if (frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
			{
				if (Selection == "...")
				{
					if (this.GetPremiumSubFolder().Length == 0)
					{
						frmMainProfiles.CurrentDirectory = _globals.JackProfiles;
					}
					else
					{
						frmMainProfiles.CurrentDirectory = "Premium:";
					}
					this.LoadProfiles();
					return;
				}
				if (this.IsPremiumFolder(this.listProfiles))
				{
					frmMainProfiles.CurrentDirectory = "Premium:" + Selection;
					this.LoadProfiles();
					return;
				}
				if (Selection == "Profile Store")
				{
					if (!Tools.IsFormOpen("frmStore"))
					{
						Tools.OpenForm("frmStore", false, "frmMain", Array.Empty<object>());
						return;
					}
				}
				else
				{
					PFLS premiumProfileBySelection = this.GetPremiumProfileBySelection(this.listProfiles);
					if (premiumProfileBySelection != null)
					{
						Tools.CloseForm("frmMainProfilesPremium", new object[]
						{
							true
						});
						frmMainProfilesPremium.Profile = premiumProfileBySelection;
						Thread thread = new Thread(delegate()
						{
							Application.Run(new frmMainProfilesPremium());
						});
						thread.SetApartmentState(ApartmentState.STA);
						thread.Start();
						Tools.OpenForm("frmLoading", true, "frmMain", Array.Empty<object>());
						return;
					}
				}
			}
			else
			{
				if (!(Selection == "..."))
				{
					if (!(Selection == "Premium"))
					{
						frmMainProfiles.CurrentDirectory = frmMainProfiles.CurrentDirectory + "\\" + Selection;
					}
					else
					{
						frmMainProfiles.CurrentDirectory = "Premium:";
					}
				}
				else
				{
					frmMainProfiles.CurrentDirectory = Directory.GetParent(frmMainProfiles.CurrentDirectory + "\\").Parent.FullName;
				}
				this.LoadProfiles();
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x006D3E2C File Offset: 0x006D202C
		private void btnCreateFolder_Click(object sender, EventArgs e)
		{
			this.CreateNewDirectory();
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x006D3E40 File Offset: 0x006D2040
		private void CreateNewDirectory()
		{
			string text = "";
			string path = frmMainProfiles.CurrentDirectory + "\\" + text;
			int num = 1;
			while (Directory.Exists(path))
			{
				text = "New folder (" + num.ToString() + ")";
				path = frmMainProfiles.CurrentDirectory + "\\" + text;
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

		// Token: 0x06000FB9 RID: 4025 RVA: 0x006D3F68 File Offset: 0x006D2168
		private void btnDelete_Click(object sender, EventArgs e)
		{
			this.Delete();
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x006D3F7C File Offset: 0x006D217C
		private void listProfiles_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				this.Delete();
			}
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x006D3F9C File Offset: 0x006D219C
		private void Delete()
		{
			if (frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
			{
				return;
			}
			ListView.SelectedListViewItemCollection selectedItems = this.listProfiles.SelectedItems;
			if (selectedItems.Count == 0)
			{
				return;
			}
			if (MessageBox.Show("Do you really want to delete the selected files?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				foreach (object obj in selectedItems)
				{
					string text = ((ListViewItem)obj).SubItems[0].Text;
					string path = frmMainProfiles.CurrentDirectory + "\\" + text + ".json";
					bool flag = Directory.Exists(frmMainProfiles.CurrentDirectory + "\\" + text);
					if (!(text == "...") && (File.Exists(path) || flag))
					{
						if (!flag)
						{
							_globals.Waypoints.Clear();
							_globals.Events.Clear();
							_globals.ProfileSettings.Clear();
							File.Delete(path);
						}
						else
						{
							Directory.Delete(frmMainProfiles.CurrentDirectory + "\\" + text, true);
						}
					}
				}
				this.LoadProfiles();
				return;
			}
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x006D40D8 File Offset: 0x006D22D8
		private void Copy()
		{
			if (frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
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
				string text2 = frmMainProfiles.CurrentDirectory + "\\" + text + ".json";
				if (!(text == "...") && File.Exists(text2))
				{
					this.CopiedFiles.Add(text, text2);
				}
			}
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x006D41A4 File Offset: 0x006D23A4
		private void Paste(string CustomPasteDirectory = "")
		{
			if (this.CutFiles)
			{
				_globals.Waypoints.Clear();
				_globals.Events.Clear();
				_globals.ProfileSettings.Clear();
			}
			string text = frmMainProfiles.CurrentDirectory;
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

		// Token: 0x06000FBE RID: 4030 RVA: 0x006D42E0 File Offset: 0x006D24E0
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

		// Token: 0x06000FBF RID: 4031 RVA: 0x006D4324 File Offset: 0x006D2524
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

		// Token: 0x06000FC0 RID: 4032 RVA: 0x006D4388 File Offset: 0x006D2588
		private void GetDragDirectory()
		{
			Point point = this.listProfiles.PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
			ListViewItem itemAt = this.listProfiles.GetItemAt(point.X, point.Y);
			if (itemAt == null || itemAt.Text == "..." || itemAt.Text.StartsWith("Premium"))
			{
				return;
			}
			if (this.CurrentDraggingDirectoryName == itemAt.Text)
			{
				return;
			}
			this.CurrentDraggingDirectoryName = itemAt.Text;
			if (Directory.Exists(frmMainProfiles.CurrentDirectory + "\\" + this.CurrentDraggingDirectoryName))
			{
				foreach (object obj in this.listProfiles.SelectedItems)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					if (!File.Exists(frmMainProfiles.CurrentDirectory + "\\" + listViewItem.Text + ".json"))
					{
						listViewItem.Selected = false;
					}
				}
				itemAt.Selected = true;
				return;
			}
			this.CurrentDraggingDirectoryName = "";
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x006D44D8 File Offset: 0x006D26D8
		private void DragDone()
		{
			this.CurrentDraggingDirectoryName = "";
			this.IsDragging = false;
			Cursor.Current = Cursors.Default;
			this.listProfiles.Cursor = Cursors.Default;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x006D4514 File Offset: 0x006D2714
		private void btnRename_Click(object sender, EventArgs e)
		{
			this.Rename();
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x006D4528 File Offset: 0x006D2728
		private void Rename()
		{
			if (this.GetSelection(this.listProfiles).Length > 0)
			{
				this.listProfiles.SelectedItems[0].BeginEdit();
			}
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x006D4560 File Offset: 0x006D2760
		private void listProfiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
		{
			string text = this.GetSelection(this.listProfiles);
			if (text.Length > 0 && e.Label != null)
			{
				if (e.Label.Length > 0 && text != e.Label && text != "..." && !frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
				{
					string text2 = frmMainProfiles.CurrentDirectory + "\\" + text;
					bool flag = false;
					if (File.Exists(frmMainProfiles.CurrentDirectory + "\\" + e.Label + ".json"))
					{
						flag = true;
						text += ".json";
					}
					else if (Directory.Exists(frmMainProfiles.CurrentDirectory + "\\" + e.Label))
					{
						flag = true;
					}
					if (!flag)
					{
						if (!File.Exists(text2 + ".json"))
						{
							if (!Directory.Exists(text2))
							{
								return;
							}
							try
							{
								Directory.Move(text2, frmMainProfiles.CurrentDirectory + "\\" + e.Label);
								return;
							}
							catch
							{
								return;
							}
						}
						File.Move(text2 + ".json", frmMainProfiles.CurrentDirectory + "\\" + e.Label + ".json");
						this.ChangeProfile(e.Label);
						return;
					}
					MessageBox.Show("A profile or folder with this name already exists.\r\nPlease choose another name.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					e.CancelEdit = true;
					return;
				}
				else
				{
					e.CancelEdit = true;
				}
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x006D46E4 File Offset: 0x006D28E4
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			this.Search();
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x006D46F8 File Offset: 0x006D28F8
		private void Search()
		{
			bool enabled = false;
			int count = this.listProfiles.Items.Count;
			if (count > 0)
			{
				string text = this.txtSearch.Text.ToLower();
				if (text.Length > 0)
				{
					enabled = true;
					for (int i = 0; i < count; i++)
					{
						if (i != 0 || !(frmMainProfiles.CurrentDirectory == _globals.JackProfiles) || !(this.listProfiles.Items[i].Text == "Premium"))
						{
							string text2 = this.listProfiles.Items[i].Text.ToLower();
							if (text2 != "..." && text2.Contains(text))
							{
								this.listProfiles.Items[i].ForeColor = Color.LimeGreen;
							}
							else
							{
								this.listProfiles.Items[i].ForeColor = Color.FromArgb(14, 17, 22);
							}
						}
					}
				}
				else
				{
					for (int j = 0; j < this.listProfiles.Items.Count; j++)
					{
						if (j != 0 || !(frmMainProfiles.CurrentDirectory == _globals.JackProfiles) || !(this.listProfiles.Items[j].Text == "Premium"))
						{
							this.listProfiles.Items[j].ForeColor = Color.White;
						}
					}
				}
			}
			this.btnErase.Enabled = enabled;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x006D487C File Offset: 0x006D2A7C
		private void btnErase_Click(object sender, EventArgs e)
		{
			this.txtSearch.Text = "";
			this.LoadProfiles();
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x006D48A0 File Offset: 0x006D2AA0
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

		// Token: 0x06000FC9 RID: 4041 RVA: 0x006D39F0 File Offset: 0x006D1BF0
		private void btnNoProfiles_Click(object sender, EventArgs e)
		{
			this.CreateNewProfile();
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x006D48EC File Offset: 0x006D2AEC
		private void ShowNoProfilesButton(bool Status)
		{
			this.btnNoProfiles.Location = this.listProfiles.Location;
			this.btnNoProfiles.Size = this.listProfiles.Size;
			this.listProfiles.Visible = !Status;
			this.btnNoProfiles.Visible = Status;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x006D1820 File Offset: 0x006CFA20
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

		// Token: 0x06000FCC RID: 4044 RVA: 0x006D4940 File Offset: 0x006D2B40
		private string GetPremiumID(ListView WhichListView = null)
		{
			if (WhichListView.SelectedItems.Count > 0)
			{
				string text = WhichListView.SelectedItems[0].SubItems[2].Text;
				if (Tools.IsNumber(text, 1, 0, 1, 0))
				{
					return text;
				}
			}
			return "";
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x006D498C File Offset: 0x006D2B8C
		private bool IsPremiumFolder(ListView WhichListView = null)
		{
			if (_globals.PremiumProfiles.Count > 0)
			{
				string premiumID = this.GetPremiumID(this.listProfiles);
				if (premiumID != "" && Tools.IsNumber(premiumID, 1, 0, 1, 0))
				{
					PFLS profileByID = PFL.GetProfileByID(Convert.ToInt32(premiumID));
					if (profileByID != null && profileByID.IsBundle)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x006D49E8 File Offset: 0x006D2BE8
		private string GetPremiumSubFolder()
		{
			if (frmMainProfiles.CurrentDirectory.Contains("Premium:"))
			{
				string text = frmMainProfiles.CurrentDirectory.Split(new char[]
				{
					':'
				})[1];
				if (text.Length > 0)
				{
					return text;
				}
			}
			return "";
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x006D4A30 File Offset: 0x006D2C30
		private PFLS GetPremiumProfileBySelection(ListView WhichListView = null)
		{
			if (_globals.PremiumProfiles.Count > 0)
			{
				string premiumID = this.GetPremiumID(this.listProfiles);
				if (premiumID != "" && Tools.IsNumber(premiumID, 1, 0, 1, 0))
				{
					PFLS profileByID = PFL.GetProfileByID(Convert.ToInt32(premiumID));
					if (profileByID != null)
					{
						return profileByID;
					}
				}
			}
			return null;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x006D4A84 File Offset: 0x006D2C84
		private string GetSelectionWithParentDirectory(string Selection)
		{
			if (frmMainProfiles.CurrentDirectory != _globals.JackProfiles)
			{
				Selection = new DirectoryInfo(frmMainProfiles.CurrentDirectory + "\\a").Parent.Name + "\\" + Selection;
			}
			return Selection;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x006D4AD0 File Offset: 0x006D2CD0
		private void selectDisplayMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.listProfiles.FullRowSelect = false;
			string text = this.selectDisplayMode.SelectedItem.ToString();
			Jack.Core.Settings.ProfilesDisplayMode = text;
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
			if (!(text == "Tile"))
			{
				if (text == "Details")
				{
					this.listProfiles.View = View.Details;
					this.listProfiles.FullRowSelect = true;
					this.LoadProfiles();
					this.CenterListViewColumns();
				}
				return;
			}
			this.listProfiles.View = View.Tile;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x006D4B80 File Offset: 0x006D2D80
		private void listProfiles_MouseUp(object sender, MouseEventArgs e)
		{
			if (this.IsDragging && this.CurrentDraggingDirectoryName.Length > 0)
			{
				string customPasteDirectory = frmMainProfiles.CurrentDirectory + "\\" + this.CurrentDraggingDirectoryName;
				this.CutFiles = true;
				this.Copy();
				this.Paste(customPasteDirectory);
			}
			this.DragDone();
			this.ShowContextMenu(sender, e);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x006D4BDC File Offset: 0x006D2DDC
		private void ShowContextMenu(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				List<string> list = new List<string>();
				string selection = this.GetSelection(this.listProfiles);
				if (frmMainProfiles.CurrentDirectory.StartsWith("Premium:"))
				{
					if (selection.Length == 0 || selection == "...")
					{
						return;
					}
					if (selection == "Profile Store" || this.IsPremiumFolder(this.listProfiles))
					{
						return;
					}
					string premiumID = this.GetPremiumID(this.listProfiles);
					if (!Tools.IsNumber(premiumID, 1, 0, 1, 0))
					{
						return;
					}
					PFLS profileByID = PFL.GetProfileByID(Convert.ToInt32(premiumID));
					if (profileByID == null)
					{
						return;
					}
					if (!profileByID.IsConnected)
					{
						return;
					}
					this.ContextMenuConnectedProfile = profileByID;
					foreach (PFLS pfls in PFL.GetConnectedProfiles(profileByID))
					{
						list.Add(pfls.DisplayName);
					}
					Tools.CreateContextMenu(sender, e, "frmMainProfiles", "listProfiles", "ItemActionPremium", list.ToArray(), null);
					return;
				}
				else if (selection != "Premium")
				{
					ListView.SelectedListViewItemCollection selectedItems = this.listProfiles.SelectedItems;
					bool flag;
					if ((flag = (selectedItems.Count == 1)) && selectedItems.Count > 0)
					{
						using (IEnumerator enumerator2 = selectedItems.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (((ListViewItem)enumerator2.Current).SubItems[0].Text.Contains("..."))
								{
									flag = false;
									break;
								}
							}
						}
					}
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
					list.Add("Create new Profile...");
					if (frmMainProfiles.CurrentDirectory == _globals.JackProfiles)
					{
						list.Add("Create new Folder");
					}
					list.Add("-");
					list.Add("Open in Explorer");
					list.Add("Reload Folder");
					list.Add("Unload Profile");
					Tools.CreateContextMenu(sender, e, "frmMainProfiles", "listProfiles", "ItemAction", list.ToArray(), null);
				}
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x006D4E9C File Offset: 0x006D309C
		public void ItemActionPremium(object sender, MouseEventArgs e, string Action = "")
		{
			if (this.ContextMenuConnectedProfile == null)
			{
				return;
			}
			foreach (PFLS pfls in PFL.GetConnectedProfiles(this.ContextMenuConnectedProfile))
			{
				if (Action == pfls.DisplayName)
				{
					Json.LoadProfile(pfls.ID.ToString(), true, true, true);
				}
			}
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x006D4F1C File Offset: 0x006D311C
		public void ItemAction(object sender, MouseEventArgs e, string Action = "")
		{
			if (Action == "Edit...")
			{
				this.EditProfile();
				return;
			}
			if (Action == "Create new Profile...")
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
					if (frmMainProfiles.CurrentDirectory.Length > 0)
					{
						Process.Start(frmMainProfiles.CurrentDirectory);
						return;
					}
				}
				else
				{
					if (Action == "Reload Folder")
					{
						this.LoadProfiles();
						return;
					}
					if (Action == "Unload Profile")
					{
						this.Unload();
					}
				}
				return;
			}
			this.Delete();
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x006D1C64 File Offset: 0x006CFE64
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 33554432;
				return createParams;
			}
		}

		// Token: 0x0400069C RID: 1692
		public static string CurrentDirectory = _globals.JackProfiles;

		// Token: 0x0400069D RID: 1693
		public static bool JustSelect = false;

		// Token: 0x0400069E RID: 1694
		public static bool DisplayWaypointsAfterEditorLoaded = false;

		// Token: 0x0400069F RID: 1695
		private Dictionary<string, string> CopiedFiles = new Dictionary<string, string>();

		// Token: 0x040006A0 RID: 1696
		private bool CutFiles;

		// Token: 0x040006A1 RID: 1697
		private bool IsDragging;

		// Token: 0x040006A2 RID: 1698
		private string CurrentDraggingDirectoryName = "";

		// Token: 0x040006A3 RID: 1699
		private static MemoryStream CursorMS = new MemoryStream(Resources.icon_copy);

		// Token: 0x040006A4 RID: 1700
		private Cursor DragCursor = new Cursor(frmMainProfiles.CursorMS);

		// Token: 0x040006A5 RID: 1701
		private PFLS ContextMenuConnectedProfile;
	}
}
