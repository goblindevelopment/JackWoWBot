using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.ATH;
using Jack.Core;
using Jack.Forms.Store;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000075 RID: 117
	public partial class frmStoreDashboard : Form
	{
		// Token: 0x06000AAE RID: 2734 RVA: 0x00694E1C File Offset: 0x0069301C
		public frmStoreDashboard()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00694E3C File Offset: 0x0069303C
		private void frmStoreDashboard_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, false, false, false);
			this.SetContent();
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00694E68 File Offset: 0x00693068
		private void frmStoreDashboard_Resize(object sender, EventArgs e)
		{
			this.SetContent();
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00694E68 File Offset: 0x00693068
		private void frmStoreDashboard_SizeChanged(object sender, EventArgs e)
		{
			this.SetContent();
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00694E7C File Offset: 0x0069307C
		private void SetContent()
		{
			this.panelContent.Location = new Point(this.imgJackPack.Location.X, this.imgJackPack.Location.Y + this.imgJackPack.Height + 16);
			this.panelDashboard.HorizontalScroll.Visible = false;
			this.imgJackPackLoading.Left = (this.imgJackPack.ClientSize.Width - this.imgJackPackLoading.Width) / 2;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00694F0C File Offset: 0x0069310C
		private void LoadControlsAndSettings()
		{
			Tools.InvokeMethod("frmStoreDashboard", "RequestProfilesAndHandleLists", new object[0], false);
			this.GetAndSetImages();
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00694F38 File Offset: 0x00693138
		public void RequestProfilesAndHandleLists()
		{
			Thread thread;
			if (frmStoreProfiles.ListProfiles.Count != 0)
			{
				thread = new Thread(new ThreadStart(this.HandleLists));
			}
			else
			{
				thread = new Thread(new ThreadStart(this.method_0));
			}
			thread.IsBackground = true;
			thread.Start();
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00694F88 File Offset: 0x00693188
		private void RandomizeProfilesList()
		{
			int count = frmStoreProfiles.ListProfiles.Count;
			if (count > 0)
			{
				List<StoreProfiles> list = new List<StoreProfiles>();
				int num = Tools.Rnd.Next(0, count);
				for (int i = 0; i < count; i++)
				{
					list.Add(frmStoreProfiles.ListProfiles[num]);
					if (num < count - 1)
					{
						num++;
					}
					else
					{
						num = 0;
					}
				}
				frmStoreProfiles.ListProfiles.Clear();
				frmStoreProfiles.ListProfiles = list;
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00694FF4 File Offset: 0x006931F4
		private void GetAndSetImages()
		{
			new Thread(new ThreadStart(frmStoreDashboard.smethod_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00695020 File Offset: 0x00693220
		private void imgJackPack_Click(object sender, EventArgs e)
		{
			StoreProfiles profileByName = frmStore.GetProfileByName("Jack Pack");
			if (profileByName != null)
			{
				frmStoreProfile.Profile = profileByName;
				Tools.InvokeMethod("frmStore", "LoadFormToPanel", new object[]
				{
					"frmStoreProfile",
					false,
					new object[0]
				}, false);
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00695074 File Offset: 0x00693274
		private void HandleLists()
		{
			if (this.panelContent.InvokeRequired)
			{
				this.panelContent.Invoke(new MethodInvoker(delegate()
				{
					this.method_1();
				}));
			}
			else
			{
				this.method_1();
			}
			Tools.InvokeMethod("frmStore", "SetProfileTypes", null, false);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x006950C0 File Offset: 0x006932C0
		private void DrawToplist(List<StoreProfiles> Toplist, string Title)
		{
			int num = 16;
			int count = Toplist.Count;
			if (count > 0)
			{
				int width = this.panelContent.Width;
				int height = this.panelProfile.Size.Height;
				int num2 = height * count;
				int num3 = num2 + 40;
				int num4 = 0;
				foreach (object obj in this.panelContent.Controls)
				{
					if (obj.GetType() == typeof(Guna2GroupBox))
					{
						Guna2GroupBox guna2GroupBox = (Guna2GroupBox)obj;
						if (guna2GroupBox.Name.StartsWith("grpProfiles"))
						{
							num4 += guna2GroupBox.Height + num;
						}
					}
				}
				int height2 = num3 + num4;
				Guna2GroupBox guna2GroupBox2 = new Guna2GroupBox();
				guna2GroupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				guna2GroupBox2.BackColor = Color.Transparent;
				guna2GroupBox2.BorderColor = Color.FromArgb(27, 33, 43);
				guna2GroupBox2.BorderRadius = 4;
				guna2GroupBox2.CustomBorderColor = Color.SteelBlue;
				guna2GroupBox2.FillColor = Color.FromArgb(27, 33, 43);
				guna2GroupBox2.Font = new Font("Segoe UI", 9f);
				guna2GroupBox2.ForeColor = Color.White;
				guna2GroupBox2.Location = new Point(0, num4);
				guna2GroupBox2.Name = "grpProfiles";
				guna2GroupBox2.Size = new Size(width, num3);
				Guna2HtmlLabel guna2HtmlLabel = new Guna2HtmlLabel();
				guna2HtmlLabel.BackColor = Color.Transparent;
				guna2HtmlLabel.Font = new Font("Segoe UI", 10f);
				guna2HtmlLabel.ForeColor = Color.White;
				guna2HtmlLabel.Location = new Point(11, 10);
				guna2HtmlLabel.Name = "lblTitle";
				guna2HtmlLabel.Size = new Size(174, 19);
				guna2HtmlLabel.Text = Title;
				Guna2Panel guna2Panel = new Guna2Panel();
				guna2Panel.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
				guna2Panel.Location = new Point(0, 40);
				guna2Panel.Name = "panelProfiles";
				guna2Panel.Size = new Size(width, num2);
				int num5 = 0;
				foreach (StoreProfiles storeProfiles in Toplist)
				{
					string ID = storeProfiles.ID.ToString() + "_" + frmStoreDashboard.IDAddition.ToString();
					Guna2Panel guna2Panel2 = new Guna2Panel();
					guna2Panel2.Cursor = Cursors.Hand;
					guna2Panel2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					guna2Panel2.Location = new Point(0, num5);
					guna2Panel2.Name = "panelProfile_" + ID;
					guna2Panel2.Size = new Size(guna2GroupBox2.Width, 55);
					num5 += height;
					Guna2PictureBox guna2PictureBox = new Guna2PictureBox();
					guna2PictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
					guna2PictureBox.FillColor = Color.Transparent;
					guna2PictureBox.ImageRotate = 0f;
					guna2PictureBox.Name = "imgGames_" + ID;
					guna2PictureBox.Size = new Size(107, 20);
					guna2PictureBox.Location = new Point(width - 140, 18);
					guna2PictureBox.TabStop = false;
					if (storeProfiles.Classic && storeProfiles.ClassicEra)
					{
						guna2PictureBox.Image = Resources.store_profile_type_wotlk_som;
					}
					else if (!storeProfiles.Classic)
					{
						if (storeProfiles.ClassicEra)
						{
							guna2PictureBox.Image = Resources.store_profile_type_som;
						}
					}
					else
					{
						guna2PictureBox.Image = Resources.store_profile_type_wotlk;
					}
					Label label = new Label();
					label.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
					label.AutoEllipsis = true;
					label.Font = new Font("Segoe UI", 9.5f);
					label.Location = new Point(72, 18);
					label.Name = "lblDisplayName_" + ID;
					label.Size = new Size(width - label.Location.X - 180, 19);
					label.TextAlign = ContentAlignment.MiddleLeft;
					label.Text = storeProfiles.DisplayName;
					Guna2PictureBox guna2PictureBox2 = new Guna2PictureBox();
					guna2PictureBox2.Dock = DockStyle.Right;
					guna2PictureBox2.FillColor = Color.Transparent;
					guna2PictureBox2.Image = Resources.store_faction_horde_20;
					guna2PictureBox2.ImageRotate = 0f;
					guna2PictureBox2.Location = new Point(0, 0);
					guna2PictureBox2.Name = "imgFactionHorde_" + ID;
					guna2PictureBox2.Size = new Size(20, 20);
					guna2PictureBox2.TabStop = false;
					guna2PictureBox2.Visible = (storeProfiles.Faction == "All" || storeProfiles.Faction == "Horde");
					Guna2PictureBox guna2PictureBox3 = new Guna2PictureBox();
					guna2PictureBox3.Dock = DockStyle.Right;
					guna2PictureBox3.FillColor = Color.Transparent;
					guna2PictureBox3.Image = Resources.store_faction_alliance_20;
					guna2PictureBox3.ImageRotate = 0f;
					guna2PictureBox3.Location = new Point(20, 0);
					guna2PictureBox3.Name = "imgFactionAlliance_" + ID;
					guna2PictureBox3.Size = new Size(20, 20);
					guna2PictureBox3.TabStop = false;
					guna2PictureBox3.Visible = (storeProfiles.Faction == "All" || storeProfiles.Faction == "Alliance");
					Guna2Panel guna2Panel3 = new Guna2Panel();
					guna2Panel3.Controls.Add(guna2PictureBox2);
					guna2Panel3.Controls.Add(guna2PictureBox3);
					guna2Panel3.Location = new Point(14, 18);
					guna2Panel3.Name = "panelFactions_" + ID;
					guna2Panel3.Size = new Size(40, 20);
					guna2Panel2.Controls.Add(label);
					guna2Panel2.Controls.Add(guna2PictureBox);
					guna2Panel2.Controls.Add(guna2Panel3);
					guna2Panel.Controls.Add(guna2Panel2);
					guna2Panel2.MouseEnter += delegate(object sender, EventArgs e)
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
					guna2PictureBox2.MouseEnter += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseEnter(sender, e, ID);
					};
					guna2PictureBox3.MouseEnter += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseEnter(sender, e, ID);
					};
					guna2Panel3.MouseEnter += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseEnter(sender, e, ID);
					};
					guna2Panel2.MouseLeave += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseLeave(sender, e, ID);
					};
					guna2PictureBox.MouseLeave += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseLeave(sender, e, ID);
					};
					label.MouseLeave += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseLeave(sender, e, ID);
					};
					guna2PictureBox2.MouseLeave += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseLeave(sender, e, ID);
					};
					guna2PictureBox3.MouseLeave += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseLeave(sender, e, ID);
					};
					guna2Panel3.MouseLeave += delegate(object sender, EventArgs e)
					{
						this.panelProfile_MouseLeave(sender, e, ID);
					};
					guna2Panel2.MouseClick += delegate(object sender, MouseEventArgs e)
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
					guna2PictureBox2.MouseClick += delegate(object sender, MouseEventArgs e)
					{
						this.panelProfile_MouseClick(sender, e, ID);
					};
					guna2PictureBox3.MouseClick += delegate(object sender, MouseEventArgs e)
					{
						this.panelProfile_MouseClick(sender, e, ID);
					};
					guna2Panel3.MouseClick += delegate(object sender, MouseEventArgs e)
					{
						this.panelProfile_MouseClick(sender, e, ID);
					};
					frmStoreDashboard.IDAddition++;
				}
				guna2GroupBox2.Controls.Add(guna2Panel);
				guna2GroupBox2.Controls.Add(guna2HtmlLabel);
				this.panelContent.Controls.Add(guna2GroupBox2);
				this.panelContent.Height = height2;
				this.SetContent();
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x006958B0 File Offset: 0x00693AB0
		private void panelProfile_MouseEnter(object sender, EventArgs e, string ID)
		{
			Control[] array = base.Controls.Find("panelProfile_" + ID, true);
			if (array.Length != 0)
			{
				Guna2Panel guna2Panel = (Guna2Panel)array[0];
				guna2Panel.FillColor = Color.FromArgb(48, 57, 71);
				foreach (object obj in this.panelProfiles.Controls)
				{
					if (obj.GetType() == typeof(Guna2Panel))
					{
						Guna2Panel guna2Panel2 = (Guna2Panel)obj;
						string name = guna2Panel2.Name;
						if (name.StartsWith("panelProfile_") && name != guna2Panel.Name)
						{
							guna2Panel2.FillColor = Color.FromArgb(27, 33, 43);
						}
					}
				}
			}
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00695998 File Offset: 0x00693B98
		private void panelProfile_MouseLeave(object sender, EventArgs e, string ID)
		{
			Control[] array = base.Controls.Find("panelProfile_" + ID, true);
			if (array.Length != 0)
			{
				((Guna2Panel)array[0]).FillColor = Color.FromArgb(27, 33, 43);
			}
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x006959DC File Offset: 0x00693BDC
		private void panelProfile_MouseClick(object sender, MouseEventArgs e, string ID)
		{
			if (ID.Contains("_"))
			{
				ID = ID.Split(new char[]
				{
					'_'
				})[0];
			}
			StoreProfiles profileByID = frmStore.GetProfileByID(ID);
			if (profileByID != null)
			{
				frmStore.SetLastAction("Dashboard");
				frmStoreProfile.Profile = profileByID;
				Tools.InvokeMethod("frmStore", "LoadFormToPanel", new object[]
				{
					"frmStoreProfile",
					false,
					new object[0]
				}, false);
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00696524 File Offset: 0x00694724
		// Note: this type is marked as 'beforefieldinit'.
		static frmStoreDashboard()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["JackPack.gif"] = "imgJackPack";
			frmStoreDashboard.Images = dictionary;
			Dictionary<string, Bitmap> dictionary2 = new Dictionary<string, Bitmap>();
			dictionary2["JackPack.gif"] = null;
			frmStoreDashboard.ImagesReceived = dictionary2;
			frmStoreDashboard.IDAddition = 1;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00696568 File Offset: 0x00694768
		[CompilerGenerated]
		private void method_0()
		{
			string text = REQ.Ath("STR", "");
			if (text.Length > 0)
			{
				if (text.StartsWith("offline:"))
				{
					Tools.Control(text.Split(new char[]
					{
						':'
					})[1], "lblInfo", "frmStoreProfiles", true, false, false, false, 0);
					Tools.ControlVisible("panelProfiles", "frmStoreProfiles", false);
					Tools.ControlVisible("lblInfo", "frmStoreProfiles", true);
					Tools.ControlVisible("progressLoading", "frmStoreProfiles", false);
					return;
				}
				string text2 = "";
				try
				{
					text2 = Crypt.Base64Decode(text);
				}
				catch
				{
				}
				if (text2.Contains("|"))
				{
					frmStoreProfiles.ListProfiles.Clear();
					frmStoreProfiles.ToplistGoldmaking.Clear();
					frmStoreProfiles.ToplistDungeon.Clear();
					frmStoreProfiles.ToplistGathering.Clear();
					foreach (string text3 in text2.Split(new char[]
					{
						'|'
					}))
					{
						if (text3.Length > 0 && text3.Contains(";"))
						{
							string[] array2 = text3.Split(new char[]
							{
								';'
							});
							int id = Convert.ToInt32(array2[0]);
							string product = array2[1];
							string displayName = array2[2];
							string profileType = array2[3];
							string profileSubType = array2[4];
							bool classic = Convert.ToBoolean(array2[5]);
							bool classicEra = Convert.ToBoolean(array2[6]);
							bool retail = Convert.ToBoolean(array2[7]);
							string faction = array2[8];
							string @class = array2[9];
							bool hasRequirements = Convert.ToBoolean(array2[10]);
							string requiredLevel = array2[11];
							string requiredSkill = array2[12];
							string text4 = array2[13];
							string text5 = array2[14];
							bool flag = Convert.ToBoolean(array2[15]);
							bool flag2 = Convert.ToBoolean(array2[16]);
							string text6 = array2[17];
							string text7 = array2[18];
							string text8 = array2[19];
							string text9 = array2[20];
							string text10 = array2[21];
							string text11 = array2[22];
							string text12 = array2[23];
							string text13 = array2[24];
							string storeName = array2[25];
							string storeDiscordUsername = array2[26];
							string storeEmail = array2[27];
							bool alreadyPurchased = Convert.ToBoolean(array2[28]);
							bool flag3 = Convert.ToBoolean(array2[29]);
							bool flag4 = Convert.ToBoolean(array2[30]);
							bool flag5 = Convert.ToBoolean(array2[31]);
							string text14 = array2[32];
							bool requiresModule = Convert.ToBoolean(array2[33]);
							bool requiresModuleGather = Convert.ToBoolean(array2[34]);
							bool requiresModuleDungeon = Convert.ToBoolean(array2[35]);
							if (text5.Length > 0)
							{
								text5 = Crypt.Base64Decode(text5);
							}
							if (text4.Length > 0)
							{
								text4 = Crypt.Base64Decode(text4);
							}
							List<int> list = new List<int>();
							if ((flag || flag2) && text6.Length > 0 && text6.Contains(","))
							{
								foreach (string text15 in text6.Split(new char[]
								{
									','
								}))
								{
									if (text15.Length > 0 && Tools.IsNumber(text15, 1, 0, 1, 0))
									{
										list.Add(Convert.ToInt32(text15));
									}
								}
							}
							int parentProfileID = 0;
							if (text7.Length > 0)
							{
								parentProfileID = Convert.ToInt32(text7);
							}
							double price = 0.0;
							if (text12.Length > 0)
							{
								price = double.Parse(text12, CultureInfo.InvariantCulture);
							}
							Bitmap previewImage = null;
							if (text14.Length > 0)
							{
								try
								{
									previewImage = Tools.Base64ToBitmap(text14);
									goto IL_403;
								}
								catch
								{
									goto IL_403;
								}
								goto IL_2D8;
							}
							goto IL_403;
							IL_2E6:
							StoreProfiles storeProfiles;
							if (text9.Length > 0)
							{
								storeProfiles.ImageNames.Add(text9);
							}
							if (text10.Length > 0)
							{
								storeProfiles.ImageNames.Add(text10);
							}
							if (text11.Length > 0)
							{
								storeProfiles.ImageNames.Add(text11);
							}
							if (text13.Length > 0)
							{
								text13 = Crypt.Base64Decode(text13);
								if (text13.Contains(","))
								{
									string[] array3 = text13.Split(new char[]
									{
										','
									});
									for (int j = 0; j < array3.Length; j++)
									{
										string text16 = array3[j].Trim();
										if (text16.Length > 0)
										{
											storeProfiles.Keywords.Add(text16);
										}
									}
								}
								else
								{
									storeProfiles.Keywords.Add(text13.Trim());
								}
							}
							if (storeProfiles.ImageNames.Count > 0)
							{
								frmStoreProfiles.ListProfiles.Add(storeProfiles);
							}
							if (flag3)
							{
								frmStoreProfiles.ToplistGoldmaking.Add(storeProfiles);
							}
							if (flag4)
							{
								frmStoreProfiles.ToplistDungeon.Add(storeProfiles);
							}
							if (flag5)
							{
								frmStoreProfiles.ToplistGathering.Add(storeProfiles);
								goto IL_3FA;
							}
							goto IL_3FA;
							IL_403:
							storeProfiles = new StoreProfiles();
							storeProfiles.ID = id;
							storeProfiles.Product = product;
							storeProfiles.DisplayName = displayName;
							storeProfiles.ProfileType = profileType;
							storeProfiles.ProfileSubType = profileSubType;
							storeProfiles.Classic = classic;
							storeProfiles.ClassicEra = classicEra;
							storeProfiles.Retail = retail;
							storeProfiles.Faction = faction;
							storeProfiles.Class = @class;
							storeProfiles.HasRequirements = hasRequirements;
							storeProfiles.RequiredLevel = requiredLevel;
							storeProfiles.RequiredSkill = requiredSkill;
							storeProfiles.RequiredDescription = text4;
							storeProfiles.Description = text5;
							storeProfiles.IsBundle = flag;
							storeProfiles.IsConnected = flag2;
							storeProfiles.ConnectedProfiles = list;
							storeProfiles.ParentProfileID = parentProfileID;
							storeProfiles.Price = price;
							storeProfiles.StoreName = storeName;
							storeProfiles.StoreDiscordUsername = storeDiscordUsername;
							storeProfiles.StoreEmail = storeEmail;
							storeProfiles.AlreadyPurchased = alreadyPurchased;
							storeProfiles.IsTopGoldmaking = flag3;
							storeProfiles.IsTopDungeon = flag4;
							storeProfiles.IsTopGathering = flag5;
							storeProfiles.PreviewImage = previewImage;
							storeProfiles.RequiresModule = requiresModule;
							storeProfiles.RequiresModuleGather = requiresModuleGather;
							storeProfiles.RequiresModuleDungeon = requiresModuleDungeon;
							if (text8.Length <= 0)
							{
								goto IL_2E6;
							}
							IL_2D8:
							storeProfiles.ImageNames.Add(text8);
							goto IL_2E6;
						}
						IL_3FA:;
					}
					this.RandomizeProfilesList();
					this.HandleLists();
				}
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00696B2C File Offset: 0x00694D2C
		[CompilerGenerated]
		internal static void smethod_0()
		{
			foreach (KeyValuePair<string, string> keyValuePair in frmStoreDashboard.Images)
			{
				Bitmap ReceivedImage = null;
				bool flag = false;
				string key = keyValuePair.Key;
				string value = keyValuePair.Value;
				if (frmStoreDashboard.ImagesReceived[key] == null)
				{
					try
					{
						Stream responseStream = WebRequest.Create(_globals.LCS.d801 + key).GetResponse().GetResponseStream();
						ReceivedImage = new Bitmap(responseStream);
						responseStream.Dispose();
						goto IL_176;
					}
					catch
					{
						flag = true;
						goto IL_176;
					}
					goto IL_92;
				}
				goto IL_92;
				IL_176:
				if (!flag && ReceivedImage != null)
				{
					Form form = Application.OpenForms["frmStoreDashboard"];
					if (form != null)
					{
						try
						{
							Control[] array = form.Controls.Find(value, true);
							Control[] array2 = form.Controls.Find(value + "Loading", true);
							if (array.Length != 0 && array2.Length != 0)
							{
								Guna2PictureBox ImageCtrl = array[0] as Guna2PictureBox;
								Guna2ImageButton LoadingCtrl = array2[0] as Guna2ImageButton;
								ImageCtrl.Invoke(new Action(delegate()
								{
									ImageCtrl.Image = ReceivedImage;
								}));
								LoadingCtrl.Invoke(new Action(delegate()
								{
									LoadingCtrl.Visible = false;
								}));
								frmStoreDashboard.ImagesReceived[key] = ReceivedImage;
							}
						}
						catch
						{
						}
					}
				}
				Thread.Sleep(1000);
				continue;
				IL_92:
				ReceivedImage = frmStoreDashboard.ImagesReceived[key];
				goto IL_176;
			}
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00696D28 File Offset: 0x00694F28
		[CompilerGenerated]
		private void method_1()
		{
			this.panelContent.Controls.Clear();
			this.DrawToplist(frmStoreProfiles.ToplistGoldmaking, "Popular <b>Goldmaking</b> Profiles");
			this.DrawToplist(frmStoreProfiles.ToplistGathering, "Popular <b>Gathering</b> Profiles");
			this.DrawToplist(frmStoreProfiles.ToplistDungeon, "Popular <b>Dungeon</b> Profiles");
			this.method_2();
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00696D7C File Offset: 0x00694F7C
		[CompilerGenerated]
		private void method_2()
		{
			try
			{
				Guna2VScrollBar guna2VScrollBar = new Guna2VScrollBar();
				guna2VScrollBar.BindingContainer = this.panelDashboard;
				guna2VScrollBar.BorderRadius = 4;
				guna2VScrollBar.FillColor = Color.FromArgb(14, 17, 22);
				guna2VScrollBar.FillOffset = new Padding(8, 0, 0, 0);
				guna2VScrollBar.HoverState.ThumbColor = Color.FromArgb(34, 40, 51);
				guna2VScrollBar.InUpdate = false;
				guna2VScrollBar.LargeChange = 617;
				guna2VScrollBar.Location = new Point(0, 0);
				guna2VScrollBar.Maximum = 869;
				guna2VScrollBar.Name = "scrollbar";
				guna2VScrollBar.Padding = new Padding(8, 0, 0, 0);
				guna2VScrollBar.PressedState.ThumbColor = Color.FromArgb(44, 52, 66);
				guna2VScrollBar.ScrollbarSize = 10;
				guna2VScrollBar.Size = new Size(18, this.panelDashboard.Height);
				guna2VScrollBar.SmallChange = 5;
				guna2VScrollBar.ThumbColor = Color.FromArgb(27, 33, 43);
				this.panelDashboard.Controls.Add(guna2VScrollBar);
			}
			catch
			{
			}
		}

		// Token: 0x04000384 RID: 900
		private static Dictionary<string, string> Images;

		// Token: 0x04000385 RID: 901
		private static Dictionary<string, Bitmap> ImagesReceived;

		// Token: 0x04000386 RID: 902
		private static int IDAddition;
	}
}
