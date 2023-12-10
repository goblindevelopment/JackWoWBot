using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Models;
using Jack.Properties;
using Microsoft.VisualBasic;

namespace Jack.Forms
{
	// Token: 0x02000056 RID: 86
	public partial class frmList : Form
	{
		// Token: 0x0600080B RID: 2059 RVA: 0x0067FA90 File Offset: 0x0067DC90
		public frmList(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			if (args.Count<object>() > 0)
			{
				this.ListType = (string)args[0];
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0067FAE0 File Offset: 0x0067DCE0
		private void frmList_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "List", true, true, true, true, false, false);
			this.LoadSettings();
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0067FB04 File Offset: 0x0067DD04
		private void listData_Resize(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0067FB18 File Offset: 0x0067DD18
		private void CenterListViewColumns()
		{
			Tools.ColorListViewHeader(ref this.listData, null);
			Tools.CenterListViewColumns(this.listData, new int[]
			{
				60
			});
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0067FB48 File Offset: 0x0067DD48
		private void LoadSettings()
		{
			if (this.ListType == "VendorWhitelist")
			{
				this.lblInfo.Text = "Add all items you \"don't\" want to sell by Name or ID (line by line).";
				CustomUI.EnableGroupBox(false, this.grpAdd, null);
				if (frmList.CustomList == null)
				{
					this.richList.Text = this.LoadItemsFromList(frmProfileEvent.RecordedWhitelist);
				}
				else
				{
					this.richList.Text = this.LoadItemsFromList(frmList.CustomList);
				}
				this.LoadItems();
				return;
			}
			if (this.ListType == "VendorBuylist")
			{
				this.lblInfo.Text = "Add all items by Name or ID, the quantity and from how much to buy new (line by line).";
				if (frmList.CustomList == null)
				{
					this.richList.Text = this.LoadItemsFromList(frmProfileEvent.RecordedBuylist);
				}
				else
				{
					this.richList.Text = this.LoadItemsFromList(frmList.CustomList);
				}
				this.LoadItems();
				return;
			}
			if (this.ListType == "MailboxSendlist")
			{
				this.lblInfo.Text = "Add all items you want to send by Name or ID (line by line).";
				CustomUI.EnableGroupBox(false, this.grpAdd, null);
				if (frmList.CustomList != null)
				{
					this.richList.Text = this.LoadItemsFromList(frmList.CustomList);
				}
				else
				{
					this.richList.Text = this.LoadItemsFromList(frmProfileEvent.RecordedSendlist);
				}
				this.LoadItems();
				return;
			}
			if (this.ListType == "Junklist")
			{
				this.lblInfo.Text = "Add all items you want to destroy by Name or ID (line by line).";
				CustomUI.EnableGroupBox(false, this.grpAdd, null);
				this.richList.Text = this.LoadItemsFromList(Jack.Core.Settings.AddonAutoDestroyJunklist);
				this.LoadItems();
				return;
			}
			if (this.ListType == "RotationSpelllist")
			{
				this.lblInfo.Text = "Add one or more spells to be present on the desired target. By Name or ID (line by line). Select a target to list his auras.";
				CustomUI.EnableGroupBox(false, this.grpAdd, null);
				this.richList.Text = this.LoadRotationSpellsFromList(frmRotationConditions.RotationSpell.CastIfActiveSpelllist);
				this.btnReload.Enabled = false;
				this.LoadAuras();
				return;
			}
			if (this.ListType == "ObjectBlacklist")
			{
				this.lblInfo.Text = "Add all Objects/Units/Nodes you \"don't\" want to gather by Name or ID (line by line).";
				this.richList.Text = this.LoadList(frmProfile.RecordedBlacklistNameOrID);
				this.LoadObjects();
				return;
			}
			if (this.ListType == "ObjectWhitelist")
			{
				this.lblInfo.Text = "Add all Objects/Units/Nodes you \"want\" to gather by Name or ID (line by line).";
				this.richList.Text = this.LoadList(frmProfile.RecordedWhitelistNameOrID);
				this.LoadObjects();
				return;
			}
			if (this.ListType == "FishingItemlist")
			{
				this.lblInfo.Text = "Add all items by Name or ID and quantity (line by line).";
				this.richList.Text = this.LoadItemsFromList(frmProfileEvent.RecordedFishingItemlist);
				this.txtValue1.PlaceholderText = "Quantity (e.g. 20)";
				this.txtValue2.Enabled = false;
				this.LoadItems();
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0067FE18 File Offset: 0x0067E018
		private void btnReload_Click(object sender, EventArgs e)
		{
			Tools.Control(null, "listData", "frmList", true, false, true, false, 0);
			if (!(this.ListType == "ObjectBlacklist") && !(this.ListType == "ObjectWhitelist"))
			{
				this.LoadItems();
				return;
			}
			this.LoadObjects();
			this.LoadUnits();
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0067FE74 File Offset: 0x0067E074
		private void LoadObjects()
		{
			if (_globals.Ready)
			{
				List<Objects> getAllNodes = ObjectManager.GetAllNodes;
				if (getAllNodes.Count > 0)
				{
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						foreach (Objects objects in getAllNodes)
						{
							string text = objects.Name;
							if (text == "")
							{
								text = "N/A";
							}
							Tools.Control(new string[]
							{
								objects.DisplayID.ToString(),
								objects.DisplayID.ToString() + "|" + text
							}, "listData", "frmList", true, false, false, false, 0);
						}
					}
				}
			}
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0067FF6C File Offset: 0x0067E16C
		private void LoadUnits()
		{
			if (_globals.Ready)
			{
				List<Units> getUnits = ObjectManager.GetUnits;
				if (getUnits.Count > 0)
				{
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						foreach (Units units in getUnits)
						{
							string text = units.Name;
							if (text == "")
							{
								text = "N/A";
							}
							Tools.Control(new string[]
							{
								units.DisplayID.ToString(),
								units.DisplayID.ToString() + "|" + text
							}, "listData", "frmList", true, false, false, false, 0);
						}
					}
				}
			}
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00680064 File Offset: 0x0067E264
		private void LoadItems()
		{
			if (_globals.Ready)
			{
				List<Items> getItemsInBags = ObjectManager.GetItemsInBags;
				if (getItemsInBags.Count > 0)
				{
					foreach (Items items in getItemsInBags)
					{
						string text = items.ItemName;
						if (text == "")
						{
							text = "N/A";
						}
						Tools.Control(new string[]
						{
							items.ItemID.ToString(),
							items.ItemID.ToString() + "|" + text
						}, "listData", "frmList", true, false, false, false, 0);
					}
				}
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0068012C File Offset: 0x0067E32C
		private void LoadAuras()
		{
			new Thread(new ThreadStart(this.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00680158 File Offset: 0x0067E358
		private void listData_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (this.listData.SelectedItems.Count > 0 && this.listData.SelectedIndices.Count > 0)
			{
				string s = this.listData.SelectedItems[0].SubItems[0].Text.ToString();
				string text = this.listData.SelectedItems[0].SubItems[1].Text.ToString();
				int num;
				if (int.TryParse(s, out num) && num > 0)
				{
					string text2 = this.richList.Text.ToString();
					if (this.ListType == "VendorBuylist")
					{
						string text3 = Interaction.InputBox("Enter the amount you want to purchase:", Tools.RandomString(15, false), "", base.Left + 30, base.Top + 50);
						if (text3.Length > 0)
						{
							string text4 = Interaction.InputBox("From how much should I buy more?", Tools.RandomString(15, false), "", base.Left + 30, base.Top + 50);
							if (text4.Length > 0)
							{
								this.richList.Text = string.Concat(new string[]
								{
									text2,
									num.ToString(),
									";",
									text3,
									";",
									text4,
									"\r\n"
								});
								return;
							}
						}
					}
					else
					{
						if (this.ListType == "VendorWhitelist" || this.ListType == "MailboxSendlist" || this.ListType == "Junklist")
						{
							this.richList.Text = string.Concat(new string[]
							{
								text2,
								num.ToString(),
								" [",
								ObjectManager.GetItemName(num),
								"]\r\n"
							});
							return;
						}
						if (this.ListType == "ObjectBlacklist" || this.ListType == "ObjectWhitelist" || this.ListType == "RotationSpelllist")
						{
							this.richList.Text = string.Concat(new string[]
							{
								text2,
								num.ToString(),
								" [",
								text,
								"]\r\n"
							});
							return;
						}
						if (this.ListType == "FishingItemlist")
						{
							string text5 = Interaction.InputBox("Enter the desired quantity:", Tools.RandomString(15, false), "", base.Left + 30, base.Top + 50);
							if (text5.Length > 0)
							{
								this.richList.Text = string.Concat(new string[]
								{
									text2,
									num.ToString(),
									";",
									text5,
									"\r\n"
								});
							}
						}
					}
				}
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00680448 File Offset: 0x0067E648
		private void btnAdd_Click(object sender, EventArgs e)
		{
			string text = this.txtName.Text.ToString();
			string text2 = this.txtValue1.Text.ToString();
			string text3 = this.txtValue2.Text.ToString();
			string text4 = this.richList.Text.ToString();
			if (text.Length > 0 && text2.Length > 0)
			{
				if (!(this.ListType == "FishingItemlist"))
				{
					this.richList.Text = string.Concat(new string[]
					{
						text4,
						text,
						";",
						text2,
						";",
						text3,
						"\r\n"
					});
				}
				else
				{
					this.richList.Text = string.Concat(new string[]
					{
						text4,
						text,
						";",
						text2,
						"\r\n"
					});
				}
				this.txtName.Text = "";
				this.txtValue1.Text = "";
				this.txtValue2.Text = "";
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00680568 File Offset: 0x0067E768
		private void btnSave_Click(object sender, EventArgs e)
		{
			int num = 0;
			List<string> list = new List<string>();
			if (!(this.ListType == "VendorWhitelist"))
			{
				if (this.ListType == "VendorBuylist")
				{
					if (frmList.CustomList != null)
					{
						list = frmList.CustomList;
					}
					else
					{
						list = frmProfileEvent.RecordedBuylist;
					}
				}
				else if (!(this.ListType == "MailboxSendlist"))
				{
					if (!(this.ListType == "Junklist"))
					{
						if (!(this.ListType == "RotationSpelllist"))
						{
							if (!(this.ListType == "ObjectBlacklist"))
							{
								if (this.ListType == "ObjectWhitelist")
								{
									list = frmProfile.RecordedWhitelistNameOrID;
								}
								else if (this.ListType == "FishingItemlist")
								{
									list = frmProfileEvent.RecordedFishingItemlist;
								}
							}
							else
							{
								list = frmProfile.RecordedBlacklistNameOrID;
							}
						}
						else
						{
							list = frmRotationConditions.RotationSpell.CastIfActiveSpelllist;
						}
					}
					else
					{
						list = Jack.Core.Settings.AddonAutoDestroyJunklist;
					}
				}
				else if (frmList.CustomList == null)
				{
					list = frmProfileEvent.RecordedSendlist;
				}
				else
				{
					list = frmList.CustomList;
				}
			}
			else if (frmList.CustomList != null)
			{
				list = frmList.CustomList;
			}
			else
			{
				list = frmProfileEvent.RecordedWhitelist;
			}
			list.Clear();
			if (this.richList.Text.Length > 0)
			{
				foreach (string text in this.richList.Text.Split(new char[]
				{
					'\n'
				}).ToList<string>())
				{
					string text2 = text.TrimStart(Array.Empty<char>()).TrimEnd(Array.Empty<char>()).Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
					if (text2.Length != 0)
					{
						if (text2.Contains(" ["))
						{
							string str = Regex.Replace(text2, "^\\S* ", "");
							text2 = text2.Replace(" " + str, "");
						}
						list.Add(text2);
					}
				}
				num = list.Count;
			}
			if (!(this.ListType == "VendorWhitelist"))
			{
				if (this.ListType == "VendorBuylist")
				{
					if (frmList.CustomButtonName == "")
					{
						Tools.Control("Buylist (" + num.ToString() + ")", "btnRecorderVendorBuylist", "frmProfileEvent", true, false, false, false, 0);
					}
					else
					{
						Tools.Control("Buylist (" + num.ToString() + ")", frmList.CustomButtonName, frmList.CustomFormName, true, false, false, false, 0);
					}
				}
				else if (!(this.ListType == "MailboxSendlist"))
				{
					if (!(this.ListType == "Junklist"))
					{
						if (this.ListType == "RotationSpelllist")
						{
							Tools.Control("Spelllist (" + num.ToString() + ")", "btnAddition3CastIfActiveSpelllist", "frmRotationConditions", true, false, false, false, 0);
						}
						else if (!(this.ListType == "ObjectBlacklist"))
						{
							if (this.ListType == "ObjectWhitelist")
							{
								Tools.Control("Whitelist (" + num.ToString() + ")", "btnWhitelistNameOrID", "frmProfile", true, false, false, false, 0);
							}
							else if (this.ListType == "FishingItemlist")
							{
								Tools.Control("Itemlist (" + num.ToString() + ")", "btnFishingConditionItemlist", "frmProfileEvent", true, false, false, false, 0);
							}
						}
						else
						{
							Tools.Control("Extended Blacklist (" + num.ToString() + ")", "btnBlacklistNameOrID", "frmProfile", true, false, false, false, 0);
						}
					}
					else
					{
						Tools.Control("Junklist (" + num.ToString() + ")", "btnAddonOptionsAutoDestroyJunklist", "frmMainAddon", true, false, false, false, 0);
					}
				}
				else if (!(frmList.CustomButtonName == ""))
				{
					Tools.Control("Sendlist (" + num.ToString() + ")", frmList.CustomButtonName, frmList.CustomFormName, true, false, false, false, 0);
				}
				else
				{
					Tools.Control("Sendlist (" + num.ToString() + ")", "btnRecorderMailboxSendlist", "frmProfileEvent", true, false, false, false, 0);
				}
			}
			else if (frmList.CustomButtonName == "")
			{
				Tools.Control("Whitelist (" + num.ToString() + ")", "btnRecorderVendorWhitelist", "frmProfileEvent", true, false, false, false, 0);
			}
			else
			{
				Tools.Control("Whitelist (" + num.ToString() + ")", frmList.CustomButtonName, frmList.CustomFormName, true, false, false, false, 0);
			}
			base.Close();
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00680A68 File Offset: 0x0067EC68
		private string LoadItemsFromList(List<string> WhichList)
		{
			string text = "";
			if (WhichList.Count > 0)
			{
				foreach (string text2 in WhichList)
				{
					if (Tools.IsNumber(text2, 0, 0, 0, 0))
					{
						text = string.Concat(new string[]
						{
							text,
							text2,
							" [",
							ObjectManager.GetItemName(Convert.ToInt32(text2)),
							"]\r\n"
						});
					}
					else
					{
						text = text + text2 + "\r\n";
					}
				}
			}
			return text;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00680B10 File Offset: 0x0067ED10
		private string LoadRotationSpellsFromList(List<string> WhichList)
		{
			string text = "";
			if (WhichList.Count > 0)
			{
				foreach (string text2 in WhichList)
				{
					if (Tools.IsNumber(text2, 0, 0, 0, 0))
					{
						text = string.Concat(new string[]
						{
							text,
							text2,
							" [",
							Spell.GetSpellName(Convert.ToInt32(text2)),
							"]\r\n"
						});
					}
					else
					{
						text = text + text2 + "\r\n";
					}
				}
			}
			return text;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00680BB8 File Offset: 0x0067EDB8
		private string LoadList(List<string> WhichList)
		{
			string text = "";
			if (WhichList.Count > 0)
			{
				foreach (string str in WhichList)
				{
					text = text + str + "\r\n";
				}
			}
			return text;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00682448 File Offset: 0x00680648
		[CompilerGenerated]
		private void method_0()
		{
			while (Tools.IsFormOpen("frmList"))
			{
				if (_globals.Ready)
				{
					UInt128 targetGUID = ObjectManager.Me.TargetGUID;
					if (targetGUID > 0 && targetGUID != this.CurrentTargetGUID)
					{
						this.CurrentTargetGUID = targetGUID;
						Units npcbyGUID = ObjectManager.GetNPCByGUID(targetGUID);
						if (npcbyGUID != null)
						{
							Tools.Control(null, "listData", "frmList", true, false, true, false, 0);
							foreach (KeyValuePair<int, string> keyValuePair in npcbyGUID.GetAllAuras)
							{
								string text = keyValuePair.Key.ToString();
								string value = keyValuePair.Value;
								Tools.Control(new string[]
								{
									text,
									text + "|" + value
								}, "listData", "frmList", true, false, false, false, 0);
							}
						}
					}
					Thread.Sleep(500);
				}
				Thread.Sleep(250);
			}
		}

		// Token: 0x0400024D RID: 589
		private string ListType = "";

		// Token: 0x0400024E RID: 590
		public static List<string> CustomList = null;

		// Token: 0x0400024F RID: 591
		public static string CustomButtonName = "";

		// Token: 0x04000250 RID: 592
		public static string CustomFormName = "";

		// Token: 0x04000251 RID: 593
		private UInt128 CurrentTargetGUID = 0;
	}
}
