using System;
using System.ComponentModel;
using System.Drawing;
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
	// Token: 0x0200007A RID: 122
	public partial class frmStoreProfile : Form
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x00698F60 File Offset: 0x00697160
		public frmStoreProfile()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00698F80 File Offset: 0x00697180
		private void frmStoreProfile_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, true, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00698FA4 File Offset: 0x006971A4
		private void frmStoreProfile_Resize(object sender, EventArgs e)
		{
			if (frmStoreProfile.Profile != null)
			{
				this.ResizeDescription(this.lblDescription, this.lblDescriptionMore, frmStoreProfile.Profile.Description);
				if (frmStoreProfile.Profile.HasRequirements)
				{
					this.ResizeDescription(this.lblRequiredDescriptionData, this.lblRequiredDescriptionMore, frmStoreProfile.Profile.RequiredDescription);
				}
			}
			this.panelPriceCoins.Left = (this.panelPrice.ClientSize.Width - this.panelPriceCoins.Width) / 2;
			this.panelModules.Left = (this.panelNoRequirements.ClientSize.Width - this.panelModules.Width) / 2;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00699054 File Offset: 0x00697254
		private void ResizeDescription(Guna2HtmlLabel Label, Label LabelMore, string Text)
		{
			using (Graphics graphics = base.CreateGraphics())
			{
				SizeF sizeF = graphics.MeasureString(Text, Label.Font, Label.Width);
				if (sizeF.Width <= (float)Label.Width && sizeF.Height <= (float)Label.Height)
				{
					LabelMore.Visible = false;
				}
				else
				{
					LabelMore.Visible = true;
				}
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x006990C8 File Offset: 0x006972C8
		private void LoadControlsAndSettings()
		{
			if (frmStoreProfile.Profile != null)
			{
				Tools.ControlVisible("panelInfo", "frmStore", false);
				Tools.ControlVisible("panelInfoSpacer", "frmStore", false);
				this.GetAndSetImages();
				this.LoadProfile();
				return;
			}
			MessageBox.Show("Couldn't find Profile.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			frmStoreProfile.Profile = null;
			Tools.InvokeMethod("frmStore", "LoadFormToPanel", new object[]
			{
				"frmStoreProfiles",
				false,
				new object[0]
			}, false);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00699158 File Offset: 0x00697358
		private void LoadProfile()
		{
			if (frmStoreProfile.Profile.AlreadyPurchased)
			{
				this.btnBuy.Enabled = false;
				this.panelAlreadyPurchasedSpacer.Visible = true;
				this.panelAlreadyPurchased.Visible = true;
			}
			else
			{
				int num = this.panelAlreadyPurchased.Height + this.panelAlreadyPurchasedSpacer.Height;
				this.panelMore.Height -= num;
			}
			this.lblDisplayName.Text = frmStoreProfile.Profile.DisplayName;
			string text = frmStoreProfile.Profile.Description.Trim();
			if (text.Length == 0)
			{
				text = "No Description available.";
			}
			this.lblDescription.Text = text.Replace("\n", "<br>");
			this.ResizeDescription(this.lblDescription, this.lblDescriptionMore, text);
			string text2 = frmStoreProfile.Profile.ProfileType;
			if (frmStoreProfile.Profile.ProfileSubType.Length > 0)
			{
				text2 = text2 + " (" + frmStoreProfile.Profile.ProfileSubType + ")";
			}
			this.lblInfoProfileTypeData.Text = text2;
			Bitmap image = Resources.store_profile_type_wotlk_som;
			string text3 = "Classic + Classic Era";
			if (frmStoreProfile.Profile.Classic && !frmStoreProfile.Profile.ClassicEra)
			{
				image = Resources.store_profile_type_wotlk;
				text3 = "Classic";
			}
			else if (!frmStoreProfile.Profile.Classic && frmStoreProfile.Profile.ClassicEra)
			{
				image = Resources.store_profile_type_som;
				text3 = "Classic Era";
			}
			else if (frmStoreProfile.Profile.Retail)
			{
				image = Resources.store_profile_type_retail;
				text3 = "Retail";
			}
			this.imgGames.Image = image;
			this.lblInfoGamesData.Text = text3;
			bool flag = frmStoreProfile.Profile.Faction == "All" || frmStoreProfile.Profile.Faction == "Horde";
			bool flag2 = frmStoreProfile.Profile.Faction == "All" || frmStoreProfile.Profile.Faction == "Alliance";
			string text4 = Tools.HTMLColor("H", "#E62F05") + " + " + Tools.HTMLColor("A", "#03CCEB");
			if (!flag)
			{
				this.imgFactionHorde.Visible = false;
				text4 = Tools.HTMLColor("Alliance", "#03CCEB");
			}
			if (!flag2)
			{
				this.imgFactionAlliance.Visible = false;
				text4 = Tools.HTMLColor("Horde", "#E62F05");
			}
			this.lblInfoFactionData.Text = text4;
			bool flag3 = frmStoreProfile.Profile.Class == "All";
			string text5 = Tools.HTMLColor("ALL", "DeepSkyBlue") + " Classes";
			if (!flag3)
			{
				if (!(frmStoreProfile.Profile.Class == "Range") && !(frmStoreProfile.Profile.Class == "Melee"))
				{
					text5 = Tools.HTMLColor(frmStoreProfile.Profile.Class, "DeepSkyBlue").ToUpper();
				}
				else
				{
					text5 = Tools.HTMLColor(frmStoreProfile.Profile.Class, "DeepSkyBlue").ToUpper() + " Classes.";
				}
			}
			this.lblInfoClassData.Text = text5;
			string text6 = frmStoreProfile.Profile.Price.ToString().Replace(".", "").Replace(",", "");
			if (!Tools.IsNumber(text6, 1, 0, 1, 0))
			{
				this.lblPrice.Text = text6;
			}
			else
			{
				int num2 = Convert.ToInt32(text6);
				this.lblPrice.Text = string.Format("{0:n0}", num2);
			}
			if (frmStoreProfile.Profile.HasRequirements)
			{
				this.panelNoRequirementsSpacer.Visible = true;
				this.grpRequirements.Visible = true;
				this.panelNoRequirements.Visible = false;
				this.panelContactSpacer.Visible = false;
				string text7 = frmStoreProfile.Profile.RequiredLevel.Trim();
				if (text7.Length > 0 && Tools.IsNumber(text7, 1, 0, 1, 0))
				{
					this.lblRequiredLevelData.Text = "Your character needs at least " + Tools.HTMLColor("Level " + text7, "orange") + ".";
				}
				else
				{
					this.lblRequiredLevelData.Text = Tools.HTMLColor("No Level Requirements.", "LimeGreen");
				}
				string text8 = frmStoreProfile.Profile.RequiredSkill.Trim();
				if (text8.Length > 0 && Tools.IsNumber(text8, 1, 0, 1, 0))
				{
					this.lblRequiredSkillData.Text = "Your character needs at least a " + Tools.HTMLColor("Skill Level of " + text8, "orange") + ".";
				}
				else
				{
					this.lblRequiredSkillData.Text = Tools.HTMLColor("No Skill Level Requirements.", "LimeGreen");
				}
				string text9 = frmStoreProfile.Profile.RequiredDescription.Trim();
				if (text9.Length > 0)
				{
					this.lblRequiredDescriptionData.Text = text9;
				}
				this.ResizeDescription(this.lblRequiredDescriptionData, this.lblRequiredDescriptionMore, text9);
			}
			if (frmStoreProfile.Profile.RequiresModule)
			{
				this.panelNoRequirements.Visible = true;
				this.panelContactSpacer.Visible = true;
				this.lblNoRequirementsData.Location = new Point(0, 6);
				this.lblNoRequirementsData.ForeColor = Color.FromArgb(0, 191, 255);
				this.lblNoRequirementsData.Text = "This Profile requires the following Module(s):";
				if (frmStoreProfile.Profile.RequiresModuleGather && !frmStoreProfile.Profile.RequiresModuleDungeon)
				{
					this.imgModuleDungeon.Visible = false;
					this.imgModuleGather.Dock = DockStyle.Fill;
				}
				else if (!frmStoreProfile.Profile.RequiresModuleGather && frmStoreProfile.Profile.RequiresModuleDungeon)
				{
					this.imgModuleGather.Visible = false;
					this.imgModuleDungeon.Dock = DockStyle.Fill;
				}
				this.panelModules.Visible = true;
				this.lblNoRequirementsData.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.ShowDialogModules(sender, e);
				};
				this.panelModules.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.ShowDialogModules(sender, e);
				};
				this.imgModuleGather.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.ShowDialogModules(sender, e);
				};
				this.imgModuleDungeon.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.ShowDialogModules(sender, e);
				};
			}
			int num3;
			if (this.grpRequirements.Visible && this.panelNoRequirements.Visible)
			{
				num3 = 0;
			}
			else if (this.grpRequirements.Visible)
			{
				num3 = this.panelNoRequirements.Height + this.panelContactSpacer.Height;
			}
			else
			{
				num3 = this.grpRequirements.Height + this.panelNoRequirementsSpacer.Height;
			}
			this.panelMore.Height -= num3;
			this.lblAboutStoreNameData.Text = frmStoreProfile.Profile.StoreName;
			this.lblAboutDiscordData.Text = frmStoreProfile.Profile.StoreDiscordUsername;
			this.lblAboutEmailData.Text = frmStoreProfile.Profile.StoreEmail;
			if (frmStoreProfile.Profile.IsBundle)
			{
				this.imgBundle.Parent = this.img_1;
				this.imgBundle.Location = new Point(this.img_1.Width - this.imgBundle.Width, 0);
				this.imgBundle.Visible = true;
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0069987C File Offset: 0x00697A7C
		private void ShowDialogModules(object sender, MouseEventArgs e)
		{
			CustomUI.DialogModule("frmStore");
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00699894 File Offset: 0x00697A94
		private void lblDescriptionMore_Click(object sender, EventArgs e)
		{
			CustomUI.Dialog("Description", frmStoreProfile.Profile.Description, "", "frmStore", true, 0);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x006998C4 File Offset: 0x00697AC4
		private void lblRequiredDescriptionMore_Click(object sender, EventArgs e)
		{
			CustomUI.Dialog("Requirements", frmStoreProfile.Profile.RequiredDescription, "", "frmStore", true, 0);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x006998F4 File Offset: 0x00697AF4
		private void imgBundle_Click(object sender, EventArgs e)
		{
			string text = "<b>What does \"Bundle\" mean?</b>\r\n\r\n";
			text += "This is a package of several, different profiles. ";
			text += "Mostly these packages are aligned to a certain category. ";
			text += "Take a look at the profile description to see which profiles this package contains.";
			CustomUI.Dialog("Bundle", text, "", "frmStore", true, 0);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00699944 File Offset: 0x00697B44
		private void btnBuy_Click(object sender, EventArgs e)
		{
			if (frmStoreProfile.CoinsAndPriceIsValid(false))
			{
				frmStoreBuy.Profile = frmStoreProfile.Profile;
				Tools.OpenForm("frmStoreBuy", true, "frmStore", Array.Empty<object>());
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00699978 File Offset: 0x00697B78
		public static bool CoinsAndPriceIsValid(bool Compare = false)
		{
			int num = 0;
			int num2 = 0;
			string text = frmStoreProfile.Profile.Price.ToString().Replace(".", "").Replace(",", "");
			if (Tools.IsNumber(text, 1, 0, 1, 0))
			{
				num2 = Convert.ToInt32(text);
			}
			string d = _globals.LCS.d51;
			if (Tools.IsNumber(d, 1, 0, 1, 0))
			{
				num = Convert.ToInt32(d);
			}
			return num2 > 0 && num >= 0 && (!Compare || num2 <= num);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00699A00 File Offset: 0x00697C00
		public void ResizeAfterPurchase()
		{
			int PanelMoreHeight = this.panelAlreadyPurchased.Height + this.panelAlreadyPurchasedSpacer.Height;
			this.panelMore.Invoke(new MethodInvoker(delegate()
			{
				this.panelMore.Height += PanelMoreHeight;
			}));
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00699A50 File Offset: 0x00697C50
		private void GetAndSetImages()
		{
			new Thread(new ThreadStart(this.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00699A7C File Offset: 0x00697C7C
		private void img_MouseClick(object sender, MouseEventArgs e)
		{
			Guna2PictureBox guna2PictureBox = sender as Guna2PictureBox;
			Image image = this.img_1.Image;
			this.img_1.Image = guna2PictureBox.Image;
			guna2PictureBox.Image = image;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0069CE5C File Offset: 0x0069B05C
		[CompilerGenerated]
		private void method_0()
		{
			if (frmStoreProfile.Profile.FullImages.Count == 0)
			{
				string mode = "STR";
				string str = "&pid=";
				int i = frmStoreProfile.Profile.ID;
				string text = REQ.Ath(mode, str + i.ToString());
				if (text.Length > 0 && text.Contains(";"))
				{
					foreach (string text2 in text.Split(new char[]
					{
						';'
					}))
					{
						if (text2.Length > 0)
						{
							Bitmap bitmap = null;
							try
							{
								bitmap = Tools.Base64ToBitmap(text2);
								goto IL_9F;
							}
							catch
							{
								goto IL_9F;
							}
							IL_88:
							frmStoreProfile.Profile.FullImages.Add(bitmap);
							goto IL_99;
							IL_9F:
							if (bitmap != null)
							{
								goto IL_88;
							}
						}
						IL_99:;
					}
				}
			}
			this.method_1();
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0069CF24 File Offset: 0x0069B124
		[CompilerGenerated]
		private void method_1()
		{
			Form form = Application.OpenForms["frmStoreProfile"];
			if (form != null)
			{
				int count = frmStoreProfile.Profile.FullImages.Count;
				int j;
				int i;
				for (i = 1; i <= 4; i = j + 1)
				{
					Guna2PictureBox ImageControl = form.Controls.Find("img_" + i.ToString(), true)[0] as Guna2PictureBox;
					Guna2ImageButton LoadingControl = form.Controls.Find("imgLoading_" + i.ToString(), true)[0] as Guna2ImageButton;
					if (i <= count)
					{
						ImageControl.Invoke(new Action(delegate()
						{
							ImageControl.Image = frmStoreProfile.Profile.FullImages[i - 1];
							if (i != 1)
							{
								ImageControl.MouseClick += delegate(object sender, MouseEventArgs e)
								{
									this.img_MouseClick(sender, e);
								};
							}
						}));
					}
					else
					{
						try
						{
							ImageControl.Invoke(new Action(delegate()
							{
								ImageControl.Image = Resources.no_image_94x115;
								ImageControl.Cursor = Cursors.Default;
							}));
						}
						catch
						{
						}
					}
					LoadingControl.Invoke(new Action(delegate()
					{
						LoadingControl.Visible = false;
					}));
					j = i;
				}
			}
		}

		// Token: 0x040003BB RID: 955
		public static StoreProfiles Profile;
	}
}
