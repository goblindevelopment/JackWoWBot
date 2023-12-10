using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Forms.Store;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000081 RID: 129
	public partial class frmStore : Form
	{
		// Token: 0x06000C0B RID: 3083 RVA: 0x0069F56C File Offset: 0x0069D76C
		public frmStore()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0069F598 File Offset: 0x0069D798
		private void frmStore_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.SetWindowSizeAndPosition();
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void frmStore_Shown(object sender, EventArgs e)
		{
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0069F5C4 File Offset: 0x0069D7C4
		private void SetWindowSizeAndPosition()
		{
			if (Jack.Core.Settings.WindowStoreSize.Width != 0 && Jack.Core.Settings.WindowStoreSize.Height != 0)
			{
				base.Width = Jack.Core.Settings.WindowStoreSize.Width;
				base.Height = Jack.Core.Settings.WindowStoreSize.Height;
			}
			if (Jack.Core.Settings.WindowStoreLocation.X != 0 && Jack.Core.Settings.WindowStoreLocation.Y != 0)
			{
				base.Location = Jack.Core.Settings.WindowStoreLocation;
			}
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0069F62C File Offset: 0x0069D82C
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			frmStoreProfiles.ListProfiles.Clear();
			this.LoadFormToPanel("frmStoreDashboard", true, Array.Empty<object>());
			Tools.Control("", "btnRefresh", "frmStore", false, false, false, false, 0);
			this.RefreshWait();
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0069F674 File Offset: 0x0069D874
		private void RefreshWait()
		{
			if (!frmStore.RefreshTimer)
			{
				frmStore.RefreshTimer = true;
				new Thread(new ThreadStart(frmStore.smethod_0))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0069F6AC File Offset: 0x0069D8AC
		private void imgMinimize_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00666D70 File Offset: 0x00664F70
		private void imgClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0069F6C0 File Offset: 0x0069D8C0
		private void panelHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Clicks != 2)
			{
				CustomUI.MoverMouseDown(sender, e, this);
				return;
			}
			if (base.WindowState == FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Maximized;
				return;
			}
			base.WindowState = FormWindowState.Normal;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0069F6F8 File Offset: 0x0069D8F8
		private void imgSizer_MouseDown(object sender, MouseEventArgs e)
		{
			this.panelAutoComplete.Visible = false;
			CustomUI.SizerMouseDown(sender, e, this);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00666A78 File Offset: 0x00664C78
		private void imgSizer_MouseMove(object sender, MouseEventArgs e)
		{
			CustomUI.SizerMouseMove(sender, e, this);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0069F71C File Offset: 0x0069D91C
		private void imgSizer_MouseUp(object sender, MouseEventArgs e)
		{
			CustomUI.SizerMouseUp(sender, e);
			if (Tools.IsFormOpen("frmStoreProfiles"))
			{
				Tools.InvokeMethod("frmStoreProfiles", "DrawProfiles", new object[]
				{
					true,
					false
				}, false);
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0069F768 File Offset: 0x0069D968
		private void LoadControlsAndSettings()
		{
			if (frmStore.RefreshTimer)
			{
				Tools.Control("", "btnRefresh", "frmStore", false, false, false, false, 0);
			}
			frmStoreProfiles.SearchText = "";
			this.LoadFormToPanel("frmStoreDashboard", false, Array.Empty<object>());
			frmStore.SetCoins();
			this.NoCheck = true;
			this.checkFilterClassic.Checked = Jack.Core.Settings.StoreFilterClassic;
			this.checkFilterClassicEra.Checked = Jack.Core.Settings.StoreFilterClassicEra;
			this.checkFilterRetail.Checked = Jack.Core.Settings.StoreFilterRetail;
			this.NoCheck = false;
			string s = Jack.Core.Settings.StoreFilterFaction;
			this.selectFilterFaction.SelectedIndex = this.selectFilterFaction.FindStringExact(s);
			if (this.selectFilterFaction.SelectedIndex == -1)
			{
				this.selectFilterFaction.SelectedIndex = 0;
			}
			s = Jack.Core.Settings.StoreFilterClass;
			this.selectFilterClass.SelectedIndex = this.selectFilterClass.FindStringExact(s);
			if (this.selectFilterClass.SelectedIndex == -1)
			{
				this.selectFilterClass.SelectedIndex = 0;
			}
			s = Jack.Core.Settings.StoreFilterProfileType;
			this.selectFilterProfileType.SelectedIndex = this.selectFilterProfileType.FindStringExact(s);
			if (this.selectFilterProfileType.SelectedIndex == -1)
			{
				this.selectFilterProfileType.SelectedIndex = 0;
			}
			this.txtFilterRequiredLevel.Text = Jack.Core.Settings.StoreFilterRequiredLevel;
			this.SaveFilter();
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0069F8B8 File Offset: 0x0069DAB8
		public void SetProfileTypes()
		{
			if (this.selectFilterProfileType.InvokeRequired)
			{
				this.selectFilterProfileType.Invoke(new MethodInvoker(delegate()
				{
					this.method_0();
				}));
				return;
			}
			this.method_0();
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0069F8F4 File Offset: 0x0069DAF4
		public static void SetCoins()
		{
			string d = _globals.LCS.d51;
			if (Tools.IsNumber(d, 1, 0, 1, 0))
			{
				int num = Convert.ToInt32(d);
				Tools.Control(string.Format("{0:n0}", num), "lblCoins", "frmStore", true, false, false, false, 0);
				return;
			}
			Tools.Control(string.Format("{0:n0}", d), "lblCoins", "frmStore", true, false, false, false, 0);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0069F964 File Offset: 0x0069DB64
		public void LoadFormToPanel(string FormName, bool Force = false, params object[] Args)
		{
			if ((Application.OpenForms[FormName] == null && FormName != this.OpenForm) || FormName == "frmStoreProfile" || Force)
			{
				if (this.OpenForm.Length > 0)
				{
					Tools.CloseForm(this.OpenForm, Array.Empty<object>());
				}
				Form form = Activator.CreateInstance(Type.GetType("Jack.Forms." + FormName), Args) as Form;
				form.TopLevel = false;
				this.panelContent.Controls.Add(form);
				form.FormBorderStyle = FormBorderStyle.None;
				form.Dock = DockStyle.Fill;
				form.ShowIcon = false;
				form.ShowInTaskbar = false;
				form.Visible = true;
				this.OpenForm = form.Name;
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0069FA24 File Offset: 0x0069DC24
		private void checkFilterClassic_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			if (!this.checkFilterClassic.Checked && !this.checkFilterClassicEra.Checked && !this.checkFilterRetail.Checked)
			{
				this.checkFilterClassic.CheckedChanged -= this.checkFilterClassic_CheckedChanged;
				this.checkFilterClassic.Checked = !this.checkFilterClassic.Checked;
				this.checkFilterClassic.CheckedChanged += this.checkFilterClassic_CheckedChanged;
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0069FAA8 File Offset: 0x0069DCA8
		private void checkFilterClassicEra_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			if (!this.checkFilterClassicEra.Checked && !this.checkFilterClassic.Checked && !this.checkFilterRetail.Checked)
			{
				this.checkFilterClassicEra.CheckedChanged -= this.checkFilterClassicEra_CheckedChanged;
				this.checkFilterClassicEra.Checked = !this.checkFilterClassicEra.Checked;
				this.checkFilterClassicEra.CheckedChanged += this.checkFilterClassicEra_CheckedChanged;
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0069FB2C File Offset: 0x0069DD2C
		private void checkFilterRetail_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			if (!this.checkFilterRetail.Checked && !this.checkFilterClassic.Checked && !this.checkFilterClassicEra.Checked)
			{
				this.checkFilterRetail.CheckedChanged -= this.checkFilterRetail_CheckedChanged;
				this.checkFilterRetail.Checked = !this.checkFilterRetail.Checked;
				this.checkFilterRetail.CheckedChanged += this.checkFilterRetail_CheckedChanged;
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0069FBB0 File Offset: 0x0069DDB0
		private void selectFilterProfileType_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selection = this.selectFilterProfileType.SelectedItem.ToString();
			this.EnableProfileSubType(selection);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0069FBD8 File Offset: 0x0069DDD8
		private void EnableProfileSubType(string Selection)
		{
			bool flag = true;
			if (!(Selection == "Profession"))
			{
				flag = false;
			}
			else
			{
				this.selectFilterProfileSubType.Items.Add("Mining");
				this.selectFilterProfileSubType.Items.Add("Herbalism");
				this.selectFilterProfileSubType.Items.Add("Skinning");
				this.selectFilterProfileSubType.Items.Add("Fishing");
			}
			if (flag)
			{
				string storeFilterProfileSubType = Jack.Core.Settings.StoreFilterProfileSubType;
				this.selectFilterProfileSubType.SelectedIndex = this.selectFilterProfileSubType.FindStringExact(storeFilterProfileSubType);
				if (this.selectFilterProfileSubType.SelectedIndex == -1)
				{
					this.selectFilterProfileSubType.SelectedIndex = 0;
				}
				this.txtFilterRequiredSkill.Enabled = true;
				this.selectFilterProfileSubType.Enabled = true;
				this.txtFilterRequiredSkill.Text = Jack.Core.Settings.StoreFilterRequiredSkill;
				return;
			}
			this.txtFilterRequiredSkill.Enabled = false;
			this.selectFilterProfileSubType.Enabled = false;
			if (this.selectFilterProfileSubType.Items.Count > 0)
			{
				this.selectFilterProfileSubType.Items.Clear();
			}
			this.selectFilterProfileSubType.Items.Add("All Sub-Types");
			this.selectFilterProfileSubType.SelectedIndex = 0;
			this.txtFilterRequiredSkill.Text = "";
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0069FD24 File Offset: 0x0069DF24
		private void SaveFilter()
		{
			Jack.Core.Settings.StoreFilterClassic = this.checkFilterClassic.Checked;
			Jack.Core.Settings.StoreFilterClassicEra = this.checkFilterClassicEra.Checked;
			Jack.Core.Settings.StoreFilterRetail = this.checkFilterRetail.Checked;
			string text = this.selectFilterFaction.SelectedItem.ToString();
			if (text.StartsWith("All "))
			{
				text = "All";
			}
			Jack.Core.Settings.StoreFilterFaction = text;
			text = this.selectFilterClass.SelectedItem.ToString();
			if (text.StartsWith("All ") || text.Contains("---"))
			{
				text = "All";
			}
			Jack.Core.Settings.StoreFilterClass = text;
			text = this.selectFilterProfileType.SelectedItem.ToString();
			if (text.StartsWith("All "))
			{
				text = "All";
			}
			Jack.Core.Settings.StoreFilterProfileType = text;
			text = this.selectFilterProfileSubType.SelectedItem.ToString();
			if (text.StartsWith("All "))
			{
				text = "All";
			}
			Jack.Core.Settings.StoreFilterProfileSubType = text;
			string text2 = this.txtFilterRequiredLevel.Text.Trim();
			if (text2.Length == 0 || Tools.IsNumber(text2, 1, 0, 1, 0))
			{
				Jack.Core.Settings.StoreFilterRequiredLevel = text2;
			}
			string text3 = this.txtFilterRequiredSkill.Text.Trim();
			if (text3.Length == 0 || Tools.IsNumber(text3, 1, 0, 1, 0))
			{
				Jack.Core.Settings.StoreFilterRequiredSkill = text3;
			}
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0069FE74 File Offset: 0x0069E074
		private void lblResetFilter_Click(object sender, EventArgs e)
		{
			this.checkFilterClassic.Checked = true;
			this.checkFilterClassicEra.Checked = true;
			this.checkFilterRetail.Checked = true;
			this.selectFilterFaction.SelectedIndex = 0;
			this.selectFilterClass.SelectedIndex = 0;
			this.selectFilterProfileType.SelectedIndex = 0;
			this.selectFilterProfileSubType.SelectedIndex = 0;
			this.txtFilterRequiredLevel.Text = "";
			this.SaveFilter();
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0069FEEC File Offset: 0x0069E0EC
		private void btnFilter_Click(object sender, EventArgs e)
		{
			this.SaveFilter();
			string text = this.txtSearch.Text.Trim();
			int results = this.SearchAndFilter(text);
			this.StartSearch(text, results);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0069FF20 File Offset: 0x0069E120
		private void txtSearch_KeyUp(object sender, KeyEventArgs e)
		{
			string text = this.txtSearch.Text;
			if (text.Length > 0)
			{
				this.panelAutoComplete.Controls.Clear();
				this.btnDelete.Visible = true;
				int num = this.SearchAndFilter(text);
				int num2 = 42;
				if (num <= 0)
				{
					this.CreateResult("1", "No matches found.", "");
				}
				else
				{
					num2 = num2 + 10 + (num - 1) * 35;
				}
				this.ResizeAutoCompletion(num2);
				this.panelAutoComplete.Visible = true;
				if (e.KeyCode == Keys.Return)
				{
					this.StartSearch(text, num);
					return;
				}
			}
			else
			{
				this.panelAutoComplete.Visible = false;
			}
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0069FFC4 File Offset: 0x0069E1C4
		private int SearchAndFilter(string SearchText = "")
		{
			int num = 0;
			foreach (StoreProfiles storeProfiles in frmStoreProfiles.ListProfiles)
			{
				if (frmStoreProfiles.Filter(storeProfiles, SearchText))
				{
					this.CreateResult(storeProfiles.ID.ToString(), storeProfiles.DisplayName, storeProfiles.ProfileType);
					num++;
				}
			}
			this.HasSearchResults = (num > 0);
			return num;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x006A004C File Offset: 0x0069E24C
		private void StartSearch(string Search = "", int Results = 0)
		{
			this.panelInfoSpacer.Visible = true;
			this.panelInfo.Visible = true;
			string text;
			if (Results <= 0)
			{
				if (Search.Length > 0)
				{
					text = "No matches found for \"" + Search + "\".";
				}
				else
				{
					text = "No matches found.";
				}
			}
			else
			{
				this.panelAutoComplete.Visible = false;
				frmStoreProfiles.SearchText = Search;
				if (!Tools.IsFormOpen("frmStoreProfiles"))
				{
					frmStoreProfiles.SearchOnLoad = true;
					this.LoadFormToPanel("frmStoreProfiles", false, Array.Empty<object>());
				}
				else
				{
					Tools.InvokeMethod("frmStoreProfiles", "DrawProfiles", new object[]
					{
						false,
						true
					}, false);
				}
				string text2 = "result";
				if (Results > 1)
				{
					text2 += "s";
				}
				if (Search.Length > 0)
				{
					text = string.Concat(new string[]
					{
						"Found ",
						Results.ToString(),
						" ",
						text2,
						" for \"",
						Search,
						"\"."
					});
				}
				else
				{
					text = Results.ToString() + " " + text2 + " found.";
				}
			}
			this.lblInfo.Text = text;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x006A0188 File Offset: 0x0069E388
		private void ResizeAutoCompletion(int Height = 0)
		{
			Point location = this.txtSearch.Location;
			Size size = this.txtSearch.Size;
			this.panelAutoComplete.Location = new Point(location.X, location.Y + size.Height + 5);
			if (Height <= 0)
			{
				this.panelAutoComplete.Width = size.Width;
			}
			else
			{
				this.panelAutoComplete.Size = new Size(size.Width, Height);
			}
			foreach (object obj in this.panelAutoComplete.Controls)
			{
				if (obj.GetType() == typeof(Guna2Panel))
				{
					Guna2Panel guna2Panel = (Guna2Panel)obj;
					foreach (object obj2 in guna2Panel.Controls)
					{
						if (obj2.GetType() == typeof(Label))
						{
							Label label = (Label)obj2;
							if (label.Name.StartsWith("lblSearchResultType_"))
							{
								label.Location = new Point(guna2Panel.Width - 130, 8);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x006A030C File Offset: 0x0069E50C
		private void CreateResult(string ID, string ProfileName, string ProfileType)
		{
			Label label = new Label();
			label.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			label.AutoEllipsis = true;
			label.Font = new Font("Segoe UI", 10f);
			label.ForeColor = Color.White;
			label.Location = new Point(8, 6);
			label.Name = "lblSearchResultName_" + ID;
			label.Size = new Size(319, 23);
			label.TextAlign = ContentAlignment.MiddleLeft;
			label.Text = ProfileName;
			Label label2 = new Label();
			label2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			label2.Font = new Font("Segoe UI", 10f);
			label2.ForeColor = Color.Gray;
			label2.Name = "lblSearchResultType_" + ID;
			label2.Size = new Size(120, 19);
			label2.TextAlign = ContentAlignment.MiddleRight;
			label2.Text = ProfileType;
			Guna2Panel guna2Panel = new Guna2Panel();
			guna2Panel.BackColor = Color.Transparent;
			guna2Panel.BorderColor = Color.FromArgb(23, 39, 52);
			guna2Panel.BorderRadius = 4;
			guna2Panel.BorderThickness = 1;
			guna2Panel.Controls.Add(label2);
			guna2Panel.Controls.Add(label);
			guna2Panel.CustomBorderColor = Color.FromArgb(23, 39, 52);
			guna2Panel.CustomBorderThickness = new Padding(1);
			guna2Panel.Dock = DockStyle.Top;
			guna2Panel.FillColor = Color.FromArgb(23, 39, 52);
			guna2Panel.Location = new Point(3, 3);
			guna2Panel.Margin = new Padding(0);
			guna2Panel.Name = "panelSearchResult_" + ID;
			guna2Panel.Size = new Size(461, 36);
			guna2Panel.Cursor = Cursors.Hand;
			guna2Panel.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelAutoComplete_MouseEnter(sender, e, ID);
			};
			label.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelAutoComplete_MouseEnter(sender, e, ID);
			};
			label2.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelAutoComplete_MouseEnter(sender, e, ID);
			};
			guna2Panel.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelAutoComplete_MouseClick(sender, e, ID);
			};
			label.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelAutoComplete_MouseClick(sender, e, ID);
			};
			label2.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelAutoComplete_MouseClick(sender, e, ID);
			};
			guna2Panel.MouseLeave += delegate(object sender, EventArgs e)
			{
				this.panelAutoComplete_MouseLeave(sender, e);
			};
			this.panelAutoComplete.Controls.Add(guna2Panel);
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x006A0560 File Offset: 0x0069E760
		private void panelAutoComplete_MouseEnter(object sender, EventArgs e, string ID)
		{
			Control[] array = base.Controls.Find("panelSearchResult_" + ID, true);
			if (array.Length != 0)
			{
				Guna2Panel guna2Panel = (Guna2Panel)array[0];
				guna2Panel.FillColor = Color.FromArgb(29, 48, 64);
				foreach (object obj in this.panelAutoComplete.Controls)
				{
					if (obj.GetType() == typeof(Guna2Panel))
					{
						Guna2Panel guna2Panel2 = (Guna2Panel)obj;
						string name = guna2Panel2.Name;
						if (name.StartsWith("panelSearchResult_") && name != guna2Panel.Name)
						{
							guna2Panel2.FillColor = Color.FromArgb(23, 39, 52);
						}
					}
				}
			}
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x006A0648 File Offset: 0x0069E848
		private void panelAutoComplete_MouseLeave(object sender, EventArgs e)
		{
			Guna2Panel guna2Panel = (Guna2Panel)sender;
			if (!guna2Panel.ClientRectangle.Contains(guna2Panel.PointToClient(Control.MousePosition)))
			{
				guna2Panel.FillColor = Color.FromArgb(23, 39, 52);
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x006A0688 File Offset: 0x0069E888
		private void panelAutoComplete_MouseClick(object sender, EventArgs e, string ID)
		{
			this.panelAutoComplete.Visible = false;
			StoreProfiles profileByID = frmStore.GetProfileByID(ID);
			if (profileByID != null)
			{
				frmStore.SetLastAction("Search:" + this.txtSearch.Text);
				frmStoreProfile.Profile = profileByID;
				this.LoadFormToPanel("frmStoreProfile", false, Array.Empty<object>());
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x006A06DC File Offset: 0x0069E8DC
		private void txtSearch_Leave(object sender, EventArgs e)
		{
			this.panelAutoComplete.Visible = false;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x006A06F8 File Offset: 0x0069E8F8
		private void txtSearch_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.HasSearchResults && !this.panelAutoComplete.Visible)
			{
				this.ResizeAutoCompletion(0);
				this.panelAutoComplete.Visible = true;
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x006A0730 File Offset: 0x0069E930
		private void panelCoins_Click(object sender, EventArgs e)
		{
			int x = this.panelHeader.Width - this.panelActionBar.Width + (this.panelCoins.Location.X + this.panelCoins.Width) - this.imgCoin.Width / 2 - this.panelMenuCoins.Width / 2;
			int y = this.panelCoins.Location.Y + this.panelCoins.Height + 10;
			this.panelMenuCoins.Location = new Point(x, y);
			this.panelMenuCoins.Visible = !this.panelMenuCoins.Visible;
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x006A07E0 File Offset: 0x0069E9E0
		private void btnMenuCoinsWeb_Click(object sender, EventArgs e)
		{
			if (_globals.LCS.d805.Length > 0 && MessageBox.Show("Would you like to open the Profile Store in the web version?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Process.Start(_globals.LCS.d805);
			}
			this.panelMenuCoins.Visible = false;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x006A0834 File Offset: 0x0069EA34
		private void btnMenuCoinsGet_Click(object sender, EventArgs e)
		{
			if (_globals.LCS.d804.Length > 0)
			{
				Process.Start(_globals.LCS.d804);
			}
			this.panelMenuCoins.Visible = false;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x006A0870 File Offset: 0x0069EA70
		private void btnMenuCoinsClose_Click(object sender, EventArgs e)
		{
			this.panelMenuCoins.Visible = false;
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x006A088C File Offset: 0x0069EA8C
		private void btnDashboard_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmStoreDashboard", false, Array.Empty<object>());
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x006A08AC File Offset: 0x0069EAAC
		public static void SetLastAction(string Action)
		{
			frmStore.LastAction = Action;
			Tools.ControlVisible("btnBack", "frmStore", true);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x006A08D0 File Offset: 0x0069EAD0
		private void btnBack_Click(object sender, EventArgs e)
		{
			if (frmStore.LastAction.Length > 0)
			{
				if (!(frmStore.LastAction == "Dashboard") && !(frmStore.LastAction == "Home"))
				{
					if (frmStore.LastAction.Contains("Search:"))
					{
						string text = frmStore.LastAction.Split(new char[]
						{
							':'
						})[1];
						int results = this.SearchAndFilter(text);
						this.StartSearch(text, results);
					}
				}
				else
				{
					this.LoadFormToPanel("frmStoreDashboard", false, Array.Empty<object>());
				}
				frmStore.LastAction = "";
				this.btnBack.Visible = false;
			}
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x006A0974 File Offset: 0x0069EB74
		private void btnDelete_Click(object sender, EventArgs e)
		{
			this.txtSearch.Text = "";
			frmStoreProfiles.SearchText = "";
			this.btnDelete.Visible = false;
			int results = this.SearchAndFilter("");
			this.StartSearch("", results);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x006A09C0 File Offset: 0x0069EBC0
		public static StoreProfiles GetProfileByID(object ProfileID)
		{
			int num;
			if (ProfileID.GetType() == typeof(string) && Tools.IsNumber((string)ProfileID, 1, 0, 1, 0))
			{
				num = Convert.ToInt32(ProfileID);
			}
			else
			{
				num = (int)ProfileID;
			}
			if (num > 0)
			{
				using (List<StoreProfiles>.Enumerator enumerator = frmStoreProfiles.ListProfiles.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						StoreProfiles storeProfiles = enumerator.Current;
						if (storeProfiles.ID == num)
						{
							return storeProfiles;
						}
					}
					goto IL_7E;
				}
				StoreProfiles result;
				return result;
			}
			IL_7E:
			return null;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x006A0A5C File Offset: 0x0069EC5C
		public static StoreProfiles GetProfileByName(string DisplayName)
		{
			foreach (StoreProfiles storeProfiles in frmStoreProfiles.ListProfiles)
			{
				if (storeProfiles.DisplayName == DisplayName)
				{
					return storeProfiles;
				}
			}
			return null;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x006A0AC0 File Offset: 0x0069ECC0
		private void frmStore_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveFilter();
			Jack.Core.Settings.WindowStoreLocation = base.Location;
			Jack.Core.Settings.WindowStoreSize = new Size(base.Width, base.Height);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x006A0AF4 File Offset: 0x0069ECF4
		private void frmStore_FormClosed(object sender, FormClosedEventArgs e)
		{
			Jack.Core.Settings.Save();
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x006A4754 File Offset: 0x006A2954
		[CompilerGenerated]
		internal static void smethod_0()
		{
			Thread.Sleep(60000);
			Tools.Control("", "btnRefresh", "frmStore", true, false, false, false, 0);
			frmStore.RefreshTimer = false;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x006A47A0 File Offset: 0x006A29A0
		[CompilerGenerated]
		private void method_0()
		{
			this.selectFilterProfileType.Items.Clear();
			this.selectFilterProfileType.Items.Add("All Types");
			List<string> list = new List<string>();
			foreach (StoreProfiles storeProfiles in frmStoreProfiles.ListProfiles)
			{
				if (!list.Contains(storeProfiles.ProfileType))
				{
					list.Add(storeProfiles.ProfileType);
				}
			}
			if (list.Count > 0)
			{
				foreach (string item in list)
				{
					this.selectFilterProfileType.Items.Add(item);
				}
			}
			string storeFilterProfileType = Jack.Core.Settings.StoreFilterProfileType;
			this.selectFilterProfileType.SelectedIndex = this.selectFilterProfileType.FindStringExact(storeFilterProfileType);
			if (this.selectFilterProfileType.SelectedIndex == -1)
			{
				this.selectFilterProfileType.SelectedIndex = 0;
			}
		}

		// Token: 0x04000420 RID: 1056
		private bool HasSearchResults;

		// Token: 0x04000421 RID: 1057
		private bool NoCheck;

		// Token: 0x04000422 RID: 1058
		private static bool RefreshTimer = false;

		// Token: 0x04000423 RID: 1059
		private string OpenForm = "";

		// Token: 0x04000424 RID: 1060
		public static string LastAction = "";
	}
}
