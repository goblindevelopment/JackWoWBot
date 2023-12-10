using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Forms.Store;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x0200007E RID: 126
	public partial class frmStoreProfiles : Form
	{
		// Token: 0x06000B9B RID: 2971 RVA: 0x0069D164 File Offset: 0x0069B364
		public frmStoreProfiles()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0069D190 File Offset: 0x0069B390
		private void frmStoreProfiles_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, true, false);
			this.CenterLabels();
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0069D1BC File Offset: 0x0069B3BC
		private void frmStoreProfiles_SizeChanged(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				this.panelProfiles.AutoScroll = false;
			}
			else
			{
				this.panelProfiles.AutoScroll = true;
			}
			this.panelProfiles.HorizontalScroll.Visible = false;
			this.CenterLabels();
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0069D204 File Offset: 0x0069B404
		private void frmStoreProfiles_Resize(object sender, EventArgs e)
		{
			this.panelProfiles.HorizontalScroll.Visible = false;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0069D224 File Offset: 0x0069B424
		private void CenterLabels()
		{
			this.progressLoading.Left = (base.ClientSize.Width - this.progressLoading.Width) / 2;
			this.progressLoading.Top = (base.ClientSize.Height - this.progressLoading.Height) / 2;
			this.lblInfo.Left = (base.ClientSize.Width - this.lblInfo.Width) / 2;
			this.lblInfo.Top = (base.ClientSize.Height - this.lblInfo.Height) / 2;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0069D2D0 File Offset: 0x0069B4D0
		private void LoadControlsAndSettings()
		{
			this.panelProfiles.HorizontalScroll.Visible = false;
			this.panelProfiles.MouseWheel += this.panelProfiles_MouseWheel;
			this.DrawProfiles(false, false);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0069D310 File Offset: 0x0069B510
		public static bool Filter(StoreProfiles Profile, string SearchFor = "")
		{
			if (frmStoreProfiles.SearchText.Length > 0 || SearchFor.Length > 0)
			{
				bool flag = false;
				string value = "";
				if (SearchFor.Length > 0)
				{
					value = SearchFor.ToLower().Trim();
				}
				else if (frmStoreProfiles.SearchText.Length > 0)
				{
					value = frmStoreProfiles.SearchText.ToLower().Trim();
				}
				if (Profile.DisplayName.ToLower().Trim().Contains(value))
				{
					flag = true;
				}
				if (!flag && Profile.Keywords.Count > 0)
				{
					using (List<string>.Enumerator enumerator = Profile.Keywords.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.ToLower().Contains(value))
							{
								flag = true;
								break;
							}
						}
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			if (!Jack.Core.Settings.StoreFilterClassic || !Jack.Core.Settings.StoreFilterClassicEra || !Jack.Core.Settings.StoreFilterRetail)
			{
				bool flag2 = true;
				if (Jack.Core.Settings.StoreFilterClassic && Profile.Classic)
				{
					flag2 = false;
				}
				if (flag2 && Jack.Core.Settings.StoreFilterClassicEra && Profile.ClassicEra)
				{
					flag2 = false;
				}
				if (flag2 && Jack.Core.Settings.StoreFilterRetail && Profile.Retail)
				{
					flag2 = false;
				}
				if (flag2)
				{
					return false;
				}
			}
			string text = Jack.Core.Settings.StoreFilterFaction;
			if (text != "All" && Profile.Faction != "All" && text != Profile.Faction)
			{
				return false;
			}
			text = Jack.Core.Settings.StoreFilterClass;
			if (text != "All" && Profile.Class != "All" && text != Profile.Class)
			{
				return false;
			}
			text = Jack.Core.Settings.StoreFilterProfileType;
			if (text != "All" && text != Profile.ProfileType)
			{
				return false;
			}
			text = Jack.Core.Settings.StoreFilterProfileSubType;
			if (text != "All" && !Profile.ProfileSubType.Contains(text))
			{
				return false;
			}
			text = Jack.Core.Settings.StoreFilterRequiredLevel;
			if (text.Length > 0 && Profile.RequiredLevel.Length > 0 && Tools.IsNumber(text, 1, 0, 1, 0) && Tools.IsNumber(Profile.RequiredLevel, 1, 0, 1, 0))
			{
				int num = Convert.ToInt32(text);
				if (Convert.ToInt32(Profile.RequiredLevel) < num)
				{
					return false;
				}
			}
			text = Jack.Core.Settings.StoreFilterRequiredSkill;
			if (text.Length > 0 && Profile.RequiredSkill.Length > 0 && Tools.IsNumber(text, 1, 0, 1, 0) && Tools.IsNumber(Profile.RequiredSkill, 1, 0, 1, 0))
			{
				int num2 = Convert.ToInt32(text);
				if (Convert.ToInt32(Profile.RequiredSkill) < num2)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0069D5B0 File Offset: 0x0069B7B0
		public void DrawProfiles(bool LoadWhileScroll = false, bool Search = false)
		{
			frmStoreProfiles.<>c__DisplayClass15_0 CS$<>8__locals1 = new frmStoreProfiles.<>c__DisplayClass15_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.LoadWhileScroll = LoadWhileScroll;
			CS$<>8__locals1.Search = Search;
			if (frmStoreProfiles.ListProfiles.Count > 0 && !this.IsDrawing)
			{
				this.IsDrawing = true;
				new Thread(new ThreadStart(CS$<>8__locals1.method_0))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0069D614 File Offset: 0x0069B814
		private void CreateProfile(string ID, Bitmap PreviewImage, string ProfileTitle, string ProfileType, bool IsHorde, bool IsAlliance, bool Classic, bool ClassicEra, bool Retail, string Price, bool AlreadyPurchased)
		{
			bool flag = PreviewImage != null;
			Guna2PictureBox guna2PictureBox = new Guna2PictureBox();
			guna2PictureBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			guna2PictureBox.BackColor = Color.Transparent;
			guna2PictureBox.BorderRadius = 4;
			guna2PictureBox.FillColor = Color.FromArgb(48, 57, 71);
			guna2PictureBox.Location = new Point(12, 12);
			guna2PictureBox.Name = "imgProfile_" + ID;
			guna2PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			guna2PictureBox.Size = new Size(94, 115);
			if (flag)
			{
				guna2PictureBox.Image = PreviewImage;
			}
			Guna2ImageButton guna2ImageButton = new Guna2ImageButton();
			guna2ImageButton.AnimatedGIF = true;
			guna2ImageButton.CheckedState.ImageSize = new Size(32, 32);
			guna2ImageButton.HoverState.ImageSize = new Size(32, 32);
			guna2ImageButton.Image = Resources.loading_32;
			guna2ImageButton.ImageOffset = new Point(0, 0);
			guna2ImageButton.ImageRotate = 0f;
			guna2ImageButton.ImageSize = new Size(32, 32);
			guna2ImageButton.Location = new Point(45, 54);
			guna2ImageButton.Name = "imgProfileLoading_" + ID;
			guna2ImageButton.PressedState.ImageSize = new Size(32, 32);
			guna2ImageButton.Size = new Size(32, 32);
			guna2ImageButton.Visible = !flag;
			Label label = new Label();
			label.AutoEllipsis = true;
			label.BackColor = Color.Transparent;
			label.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			label.ForeColor = Color.White;
			label.Location = new Point(116, 16);
			label.Name = "lblProfileTitle_" + ID;
			label.Size = new Size(240, 35);
			label.Text = ProfileTitle;
			Label label2 = new Label();
			label2.BackColor = Color.Transparent;
			label2.Font = new Font("Segoe UI", 9f);
			label2.ForeColor = Color.White;
			label2.Location = new Point(116, 62);
			label2.Name = "lblProfileType_" + ID;
			label2.Size = new Size(240, 17);
			label2.TextAlign = ContentAlignment.MiddleLeft;
			label2.Text = ProfileType;
			label2.AutoEllipsis = true;
			Guna2PictureBox guna2PictureBox2 = new Guna2PictureBox();
			guna2PictureBox2.Dock = DockStyle.Left;
			guna2PictureBox2.FillColor = Color.Transparent;
			guna2PictureBox2.Location = new Point(0, 0);
			guna2PictureBox2.Name = "imgFactionHorde_" + ID;
			guna2PictureBox2.Size = new Size(20, 20);
			guna2PictureBox2.Image = Resources.store_faction_horde_20;
			guna2PictureBox2.Visible = IsHorde;
			Guna2PictureBox guna2PictureBox3 = new Guna2PictureBox();
			guna2PictureBox3.Dock = DockStyle.Left;
			guna2PictureBox3.FillColor = Color.Transparent;
			guna2PictureBox3.Location = new Point(20, 0);
			guna2PictureBox3.Name = "imgFactionAlliance_" + ID;
			guna2PictureBox3.Size = new Size(20, 20);
			guna2PictureBox3.Image = Resources.store_faction_alliance_20;
			guna2PictureBox3.Visible = IsAlliance;
			Guna2Panel guna2Panel = new Guna2Panel();
			guna2Panel.Controls.Add(guna2PictureBox3);
			guna2Panel.Controls.Add(guna2PictureBox2);
			guna2Panel.Location = new Point(0, 3);
			guna2Panel.Name = "panelProfileFactions_" + ID;
			guna2Panel.Size = new Size(40, 20);
			Guna2VSeparator guna2VSeparator = new Guna2VSeparator();
			guna2VSeparator.FillColor = Color.FromArgb(48, 57, 71);
			guna2VSeparator.Location = new Point(44, 0);
			guna2VSeparator.Name = "sepProfile1_" + ID;
			guna2VSeparator.Size = new Size(10, 25);
			Guna2PictureBox guna2PictureBox4 = new Guna2PictureBox();
			guna2PictureBox4.FillColor = Color.Transparent;
			guna2PictureBox4.Location = new Point(61, 3);
			guna2PictureBox4.Name = "imgProfileType_" + ID;
			guna2PictureBox4.Size = new Size(107, 20);
			if (!Classic || !ClassicEra)
			{
				if (Classic)
				{
					guna2PictureBox4.Image = Resources.store_profile_type_wotlk;
				}
				else if (ClassicEra)
				{
					guna2PictureBox4.Image = Resources.store_profile_type_som;
				}
				else if (Retail)
				{
					guna2PictureBox4.Image = Resources.store_profile_type_retail;
				}
			}
			else
			{
				guna2PictureBox4.Image = Resources.store_profile_type_wotlk_som;
			}
			Guna2VSeparator guna2VSeparator2 = new Guna2VSeparator();
			guna2VSeparator2.FillColor = Color.FromArgb(48, 57, 71);
			guna2VSeparator2.Location = new Point(176, 0);
			guna2VSeparator2.Name = "sepProfile2_" + ID;
			guna2VSeparator2.Size = new Size(10, 25);
			Label label3 = new Label();
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Segoe UI", 9f);
			label3.ForeColor = Color.White;
			label3.Location = new Point(189, 5);
			label3.Name = "lblProfilePrice_" + ID;
			label3.Size = new Size(52, 15);
			label3.TextAlign = ContentAlignment.MiddleLeft;
			label3.Text = Price + " JC";
			Guna2Panel guna2Panel2 = new Guna2Panel();
			guna2Panel2.Location = new Point(115, 101);
			guna2Panel2.Name = "panelProfileIcons_" + ID;
			guna2Panel2.Size = new Size(255, 25);
			guna2Panel2.Controls.Add(guna2Panel);
			guna2Panel2.Controls.Add(label3);
			guna2Panel2.Controls.Add(guna2PictureBox4);
			guna2Panel2.Controls.Add(guna2VSeparator);
			guna2Panel2.Controls.Add(guna2VSeparator2);
			Guna2Panel guna2Panel3 = new Guna2Panel();
			guna2Panel3.BackColor = Color.Transparent;
			guna2Panel3.BorderColor = Color.FromArgb(48, 57, 71);
			guna2Panel3.BorderRadius = 4;
			guna2Panel3.BorderThickness = 1;
			guna2Panel3.Cursor = Cursors.Hand;
			guna2Panel3.FillColor = Color.Transparent;
			guna2Panel3.Location = new Point(8, 8);
			guna2Panel3.Margin = new Padding(8);
			guna2Panel3.Name = "panelProfile_" + ID;
			guna2Panel3.Size = new Size(370, 140);
			guna2Panel3.FillColor = Color.FromArgb(14, 17, 22);
			Label label4 = new Label();
			label4.BackColor = Color.Transparent;
			label4.Dock = DockStyle.Fill;
			label4.Font = new Font("Segoe UI", 8f);
			label4.ForeColor = Color.Black;
			label4.Location = new Point(0, 0);
			label4.Name = "lblAlreadyPurchased_" + ID;
			label4.Padding = new Padding(0, 0, 0, 2);
			label4.Size = new Size(94, 20);
			label4.Text = "Owned";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			Guna2Panel guna2Panel4 = new Guna2Panel();
			guna2Panel4.Controls.Add(label4);
			guna2Panel4.FillColor = Color.Orange;
			guna2Panel4.Location = new Point(12, 94);
			guna2Panel4.Name = "panelAlreadyPurchased_" + ID;
			guna2Panel4.Size = new Size(94, 20);
			guna2Panel4.Visible = AlreadyPurchased;
			guna2Panel3.Controls.Add(guna2Panel4);
			guna2Panel3.Controls.Add(guna2ImageButton);
			guna2Panel3.Controls.Add(guna2PictureBox);
			guna2Panel3.Controls.Add(label);
			guna2Panel3.Controls.Add(label2);
			guna2Panel3.Controls.Add(guna2Panel2);
			guna2Panel3.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelProfile_MouseEnter(sender, e, ID);
			};
			guna2ImageButton.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelProfile_MouseEnter(sender, e, ID);
			};
			guna2PictureBox.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelProfile_MouseEnter(sender, e, ID);
			};
			label.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelProfile_MouseEnter(sender, e, ID);
			};
			label2.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelProfile_MouseEnter(sender, e, ID);
			};
			guna2Panel2.MouseEnter += delegate(object sender, EventArgs e)
			{
				this.panelProfile_MouseEnter(sender, e, ID);
			};
			if (AlreadyPurchased)
			{
				label4.MouseEnter += delegate(object sender, EventArgs e)
				{
					this.panelProfile_MouseEnter(sender, e, ID);
				};
			}
			guna2Panel3.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelProfile_MouseClick(sender, e, ID);
			};
			guna2ImageButton.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelProfile_MouseClick(sender, e, ID);
			};
			guna2PictureBox.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelProfile_MouseClick(sender, e, ID);
			};
			label.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelProfile_MouseClick(sender, e, ID);
			};
			label2.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelProfile_MouseClick(sender, e, ID);
			};
			guna2Panel2.MouseClick += delegate(object sender, MouseEventArgs e)
			{
				this.panelProfile_MouseClick(sender, e, ID);
			};
			if (AlreadyPurchased)
			{
				label4.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.panelProfile_MouseClick(sender, e, ID);
				};
			}
			guna2Panel3.MouseLeave += delegate(object sender, EventArgs e)
			{
				this.panelProfile_MouseLeave(sender, e);
			};
			this.ListProfilePanels.Add(guna2Panel3, false);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0069DF00 File Offset: 0x0069C100
		private void panelProfile_MouseEnter(object sender, EventArgs e, string ID)
		{
			Control[] array = base.Controls.Find("panelProfile_" + ID, true);
			if (array.Length != 0)
			{
				Guna2Panel guna2Panel = (Guna2Panel)array[0];
				guna2Panel.BorderColor = Color.FromArgb(58, 68, 84);
				guna2Panel.ShadowDecoration.BorderRadius = 4;
				guna2Panel.ShadowDecoration.Color = Color.White;
				guna2Panel.ShadowDecoration.Depth = 5;
				guna2Panel.ShadowDecoration.Enabled = true;
				foreach (object obj in this.panelProfiles.Controls)
				{
					if (obj.GetType() == typeof(Guna2Panel))
					{
						Guna2Panel guna2Panel2 = (Guna2Panel)obj;
						string name = guna2Panel2.Name;
						if (name.StartsWith("panelProfile_") && name != guna2Panel.Name)
						{
							guna2Panel2.BorderColor = Color.FromArgb(48, 57, 71);
							guna2Panel2.ShadowDecoration.Enabled = false;
						}
					}
				}
			}
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0069E028 File Offset: 0x0069C228
		private void panelProfile_MouseLeave(object sender, EventArgs e)
		{
			Guna2Panel guna2Panel = (Guna2Panel)sender;
			if (!guna2Panel.ClientRectangle.Contains(guna2Panel.PointToClient(Control.MousePosition)))
			{
				guna2Panel.BorderColor = Color.FromArgb(48, 57, 71);
				guna2Panel.ShadowDecoration.Enabled = false;
			}
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0069E074 File Offset: 0x0069C274
		private void panelProfile_MouseClick(object sender, MouseEventArgs e, string ID)
		{
			StoreProfiles profileByID = frmStore.GetProfileByID(ID);
			if (profileByID != null)
			{
				frmStore.SetLastAction("Search:" + frmStoreProfiles.SearchText);
				frmStoreProfile.Profile = profileByID;
				Tools.InvokeMethod("frmStore", "LoadFormToPanel", new object[]
				{
					"frmStoreProfile",
					false,
					new object[0]
				}, false);
			}
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0069E0D8 File Offset: 0x0069C2D8
		public bool ControlIsReallyVisible(Control child)
		{
			Point pt = child.Parent.PointToClient(child.PointToScreen(Point.Empty));
			return child.Parent.GetChildAtPoint(pt) == child || child.Parent.GetChildAtPoint(new Point(pt.X + child.Width - 1, pt.Y)) == child || child.Parent.GetChildAtPoint(new Point(pt.X, pt.Y + child.Height - 1)) == child || child.Parent.GetChildAtPoint(new Point(pt.X + child.Width - 1, pt.Y + child.Height - 1)) == child;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0069E1A0 File Offset: 0x0069C3A0
		private void panelProfiles_Scroll(object sender, ScrollEventArgs e)
		{
			this.CheckScrollBar(e.NewValue);
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0069E1BC File Offset: 0x0069C3BC
		private void panelProfiles_MouseWheel(object sender, MouseEventArgs e)
		{
			this.CheckScrollBar(this.panelProfiles.VerticalScroll.Value);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0069E1E0 File Offset: 0x0069C3E0
		private void CheckScrollBar(int currPos)
		{
			if (currPos == this.panelProfiles.VerticalScroll.Maximum - this.panelProfiles.VerticalScroll.LargeChange + 1)
			{
				this.DrawProfiles(true, false);
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0069E21C File Offset: 0x0069C41C
		private void Loading(bool Status)
		{
			Tools.ControlVisible("progressLoading", "frmStoreProfiles", Status);
		}

		// Token: 0x04000400 RID: 1024
		public static List<StoreProfiles> ListProfiles = new List<StoreProfiles>();

		// Token: 0x04000401 RID: 1025
		public static List<StoreProfiles> ToplistGoldmaking = new List<StoreProfiles>();

		// Token: 0x04000402 RID: 1026
		public static List<StoreProfiles> ToplistDungeon = new List<StoreProfiles>();

		// Token: 0x04000403 RID: 1027
		public static List<StoreProfiles> ToplistGathering = new List<StoreProfiles>();

		// Token: 0x04000404 RID: 1028
		private Dictionary<Guna2Panel, bool> ListProfilePanels = new Dictionary<Guna2Panel, bool>();

		// Token: 0x04000405 RID: 1029
		public static string SearchText = "";

		// Token: 0x04000406 RID: 1030
		public static bool SearchOnLoad = false;

		// Token: 0x04000407 RID: 1031
		private bool IsDrawing;
	}
}
