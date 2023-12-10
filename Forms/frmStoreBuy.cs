using System;
using System.ComponentModel;
using System.Diagnostics;
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
	// Token: 0x02000078 RID: 120
	public partial class frmStoreBuy : Form
	{
		// Token: 0x06000B15 RID: 2837 RVA: 0x00696F2C File Offset: 0x0069512C
		public frmStoreBuy()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00696F4C File Offset: 0x0069514C
		private void frmStoreBuy_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Profile Store - Confirm Purchase", true, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00696F70 File Offset: 0x00695170
		private void LoadControlsAndSettings()
		{
			if (frmStoreBuy.Profile != null)
			{
				this.CheckCoinsAndPrice();
				this.LoadProfile();
				return;
			}
			MessageBox.Show("Couldn't find Profile.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			frmStoreBuy.Profile = null;
			base.Close();
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00696FB4 File Offset: 0x006951B4
		private void CheckCoinsAndPrice()
		{
			if (!frmStoreProfile.CoinsAndPriceIsValid(true))
			{
				this.checkRequirements.Enabled = false;
				this.checkRefund.Enabled = false;
				this.lblStatus.Text = Tools.HTMLColor("You have not enough Jack Coins.", "Orange");
				this.lblStatus.Visible = true;
				this.lblGetJackCoins.Visible = true;
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00697014 File Offset: 0x00695214
		private void LoadProfile()
		{
			this.lblDisplayNameData.Text = frmStoreBuy.Profile.DisplayName;
			string text = frmStoreBuy.Profile.ProfileType;
			if (frmStoreBuy.Profile.ProfileSubType.Length > 0)
			{
				text = text + " (" + frmStoreBuy.Profile.ProfileSubType + ")";
			}
			this.lblProfileTypeData.Text = text;
			string text2 = "Classic + Classic Era";
			if (frmStoreBuy.Profile.Classic && !frmStoreBuy.Profile.ClassicEra)
			{
				text2 = "Classic";
			}
			else if (!frmStoreBuy.Profile.Classic && frmStoreBuy.Profile.ClassicEra)
			{
				text2 = "Classic Era";
			}
			this.lblGamesData.Text = text2;
			bool flag = frmStoreBuy.Profile.Faction == "All" || frmStoreBuy.Profile.Faction == "Horde";
			bool flag2 = frmStoreBuy.Profile.Faction == "All" || frmStoreBuy.Profile.Faction == "Alliance";
			string text3 = "Horde + Alliance";
			if (!flag)
			{
				text3 = "Alliance";
			}
			if (!flag2)
			{
				text3 = "Horde";
			}
			this.lblFactionData.Text = text3;
			bool flag3 = frmStoreBuy.Profile.Class == "All";
			string text4 = "ALL Classes";
			if (!flag3)
			{
				if (!(frmStoreBuy.Profile.Class == "Range") && !(frmStoreBuy.Profile.Class == "Melee"))
				{
					text4 = frmStoreBuy.Profile.Class.ToUpper();
				}
				else
				{
					text4 = "All " + frmStoreBuy.Profile.Class.ToUpper() + " Classes.";
				}
			}
			this.lblClassData.Text = text4;
			int num = Convert.ToInt32(frmStoreBuy.Profile.Price.ToString().Replace(".", "").Replace(",", ""));
			this.lblPriceData.Text = string.Format("{0:n0}", num);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00697228 File Offset: 0x00695428
		private void checkRequirements_CheckedChanged(object sender, EventArgs e)
		{
			this.EnablePurchase();
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00697228 File Offset: 0x00695428
		private void checkRefund_CheckedChanged(object sender, EventArgs e)
		{
			this.EnablePurchase();
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0069723C File Offset: 0x0069543C
		private void EnablePurchase()
		{
			this.btnBuy.Enabled = (this.checkRequirements.Checked && this.checkRefund.Checked);
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00697270 File Offset: 0x00695470
		private void lblGetJackCoins_Click(object sender, EventArgs e)
		{
			if (_globals.LCS.d804.Length > 0)
			{
				Process.Start(_globals.LCS.d804);
			}
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x006972A0 File Offset: 0x006954A0
		private void btnBuy_Click(object sender, EventArgs e)
		{
			if (frmStoreProfile.CoinsAndPriceIsValid(true))
			{
				new Thread(new ThreadStart(frmStoreBuy.smethod_0))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x006972D4 File Offset: 0x006954D4
		private void btnCancel_Click(object sender, EventArgs e)
		{
			frmStoreBuy.Profile = null;
			base.Close();
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00698CA8 File Offset: 0x00696EA8
		[CompilerGenerated]
		internal static void smethod_0()
		{
			Tools.Control("", "btnBuy", "frmStoreBuy", false, false, false, false, 0);
			Tools.Control("", "btnCancel", "frmStoreBuy", false, false, false, false, 0);
			Tools.Control(Tools.HTMLColor("Waiting for Transaction...", "LimeGreen"), "lblStatus", "frmStoreBuy", true, false, false, false, 0);
			Tools.ControlVisible("lblStatus", "frmStoreBuy", true);
			Thread.Sleep(1000);
			string text = "";
			string text2 = REQ.Ath("BUY", "&pid=" + frmStoreBuy.Profile.ID.ToString());
			if (!text2.Contains(":"))
			{
				text = "Connection could not be established.\r\nPlease check your internet connection or contact the support.";
			}
			else
			{
				string[] array = text2.Split(new char[]
				{
					':'
				});
				string a = array[0];
				string text3 = array[1];
				if (a == "success")
				{
					if (Tools.IsNumber(text3, 1, 0, 0, 0))
					{
						_globals.LCS.d51 = text3;
						new Thread(delegate()
						{
							PFL.Get(true);
						})
						{
							IsBackground = true
						}.Start();
						_globals.LCS.d10 = "true";
						frmStore.SetCoins();
						frmStoreBuy.Profile.AlreadyPurchased = true;
						if (Tools.IsFormOpen("frmStoreProfile"))
						{
							Tools.Control("", "btnBuy", "frmStoreProfile", false, false, false, false, 0);
							Tools.ControlVisible("panelAlreadyPurchasedSpacer", "frmStoreProfile", true);
							Tools.ControlVisible("panelAlreadyPurchased", "frmStoreProfile", true);
							Tools.InvokeMethod("frmStoreProfile", "ResizeAfterPurchase", null, false);
						}
						Tools.Control(Tools.HTMLColor("Transaction confirmed.", "LimeGreen"), "lblStatus", "frmStoreBuy", true, false, false, false, 0);
						SNS.CreateLocalMessage("Profile Store - Purchase", "Your new profile was added to your Premium Collection:\r\n" + frmStoreBuy.Profile.DisplayName, 1, "News");
						Thread.Sleep(1000);
						string text4 = Tools.HTMLColor("Congratulations!", "LimeGreen") + "\r\n\r\n";
						text4 += "Your purchase was successful and your profile is now available.\r\n";
						text4 += "To load your profile, open the folder \"Premium\" in your \"Profile Manager\" and select the desired profile.\r\n\r\n";
						text4 += "Have fun with your new profile!";
						CustomUI.Dialog("Transaction", text4, "DarkMagenta", "frmStore", true, 0);
					}
				}
				else
				{
					text = text3;
				}
			}
			if (text.Length > 0)
			{
				MessageBox.Show(text, Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Tools.CloseForm("frmStoreBuy", Array.Empty<object>());
		}

		// Token: 0x0400039A RID: 922
		public static StoreProfiles Profile;
	}
}
