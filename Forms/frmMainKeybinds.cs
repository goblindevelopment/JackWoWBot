using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000092 RID: 146
	public partial class frmMainKeybinds : Form
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x006CE908 File Offset: 0x006CCB08
		public frmMainKeybinds()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x006CE944 File Offset: 0x006CCB44
		private void frmMainKeybinds_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x006CE968 File Offset: 0x006CCB68
		private void frmMainKeybinds_Shown(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x006CE97C File Offset: 0x006CCB7C
		private void CenterListViewColumns()
		{
			List<string[]> headerData = new List<string[]>
			{
				new string[]
				{
					"",
					"",
					"Left"
				},
				new string[]
				{
					"",
					"",
					"Center"
				}
			};
			Tools.ColorListViewHeader(ref this.listKeybindsCustom, headerData);
			Tools.CenterListViewColumns(this.listKeybindsCustom, null);
			Tools.ColorListViewHeader(ref this.listKeybindsDefault, headerData);
			Tools.CenterListViewColumns(this.listKeybindsDefault, null);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x006CE968 File Offset: 0x006CCB68
		private void frmMainKeybinds_SizeChanged(object sender, EventArgs e)
		{
			this.CenterListViewColumns();
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x006CEA0C File Offset: 0x006CCC0C
		private void frmMainKeybinds_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x006CEA28 File Offset: 0x006CCC28
		private void LoadControlsAndSettings()
		{
			this.PopulateKeybinds();
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x006CEA3C File Offset: 0x006CCC3C
		private void listKeybindsDefault_DoubleClick(object sender, EventArgs e)
		{
			this.KeybindClick((ListView)sender);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x006CEA3C File Offset: 0x006CCC3C
		private void listKeybindsCustom_DoubleClick(object sender, EventArgs e)
		{
			this.KeybindClick((ListView)sender);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x006CEA58 File Offset: 0x006CCC58
		private void KeybindClick(ListView WhichListView)
		{
			if (this.PreviousKey.Length == 0)
			{
				ListViewItem focusedItem = WhichListView.FocusedItem;
				if (focusedItem != null)
				{
					string text = focusedItem.SubItems[1].Text.ToString();
					this.KeybindName = focusedItem.SubItems[0].Text;
					this.PreviousKey = text;
					this.KeybindIndex = WhichListView.SelectedIndices[0];
					focusedItem.SubItems[1].Text = "Press Key... (Default: " + text + ")";
				}
			}
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x006CEAE4 File Offset: 0x006CCCE4
		private void listKeybindsDefault_KeyDown(object sender, KeyEventArgs e)
		{
			this.KeybindKeyDown((ListView)sender, e);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x006CEAE4 File Offset: 0x006CCCE4
		private void listKeybindsCustom_KeyDown(object sender, KeyEventArgs e)
		{
			this.KeybindKeyDown((ListView)sender, e);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x006CEB00 File Offset: 0x006CCD00
		private void KeybindKeyDown(ListView WhichListView, KeyEventArgs e)
		{
			if (this.PreviousKey.Length > 0 && this.KeybindIndex > -1)
			{
				bool flag = false;
				string text = ((KeyType)e.KeyValue).ToString();
				if (text != "NotSet")
				{
					bool flag2 = false;
					foreach (KeyValuePair<string, string> keyValuePair in _globals.Keys)
					{
						if (keyValuePair.Value == text && text != this.PreviousKey)
						{
							flag2 = true;
							break;
						}
					}
					if (!flag2)
					{
						WhichListView.Items[this.KeybindIndex].SubItems[1].Text = text;
						WhichListView.Items[this.KeybindIndex].ForeColor = Color.White;
						Keybinds obj = _globals.Keybinds[0];
						foreach (PropertyInfo propertyInfo in typeof(Keybinds).method_0())
						{
							if (propertyInfo.Name == this.KeybindName)
							{
								propertyInfo.SetValue(obj, text);
								break;
							}
						}
						Json.SaveKeybinds();
						Initialize.Keybinds();
						if (Tools.IsFormOpen("frmRotation"))
						{
							frmRotation.CheckKeybinds();
						}
						if (Tools.IsFormOpen("frmProfileEvent"))
						{
							frmProfileEvent.CheckKeybinds();
						}
						flag = true;
					}
					else
					{
						MessageBox.Show("This Key is already in use.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else
				{
					MessageBox.Show("This is not a valid Key.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				if (!flag)
				{
					WhichListView.Items[this.KeybindIndex].SubItems[1].Text = this.PreviousKey;
				}
				this.PreviousKey = "";
			}
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x006CECE4 File Offset: 0x006CCEE4
		private void btnKeybindsAddonSet_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("This will reset \"ALL\" Keybinds.\r\nDo you want to continue?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
			{
				return;
			}
			if (!_globals.Start)
			{
				if (File.Exists(_globals.JackUtilities + "\\Keybinds.json"))
				{
					File.Delete(_globals.JackUtilities + "\\Keybinds.json");
				}
				Thread.Sleep(250);
				Json.LoadKeybinds();
				this.PopulateKeybinds();
				frmMainKeybinds.ApplyKeybinds(false);
				return;
			}
			MessageBox.Show("Please stop Jack first.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x006CED70 File Offset: 0x006CCF70
		private void PopulateKeybinds()
		{
			Tools.Control(null, "listKeybindsDefault", "frmMainKeybinds", true, false, true, false, 0);
			foreach (KeyValuePair<string, string> keyValuePair in _globals.Keys)
			{
				string str = "Default";
				if (frmMainKeybinds.CustomKeybinds.Contains(keyValuePair.Key))
				{
					str = "Custom";
				}
				Tools.Control(new string[]
				{
					keyValuePair.Key,
					keyValuePair.Key + "|" + keyValuePair.Value
				}, "listKeybinds" + str, "frmMainKeybinds", true, false, false, false, 0);
				if (keyValuePair.Value == "NotSet")
				{
					Tools.ControlColor("", "listKeybinds" + str, "frmMainKeybinds", Color.FromArgb(252, 194, 3), new string[]
					{
						keyValuePair.Key
					}, false);
				}
			}
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x006CEE8C File Offset: 0x006CD08C
		private void btnKeybindsAddonApply_Click(object sender, EventArgs e)
		{
			if (!Addon.IsReady(true, true, false, false))
			{
				return;
			}
			frmMainKeybinds.ApplyKeybinds(false);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x006CEEAC File Offset: 0x006CD0AC
		public static void ApplyKeybinds(bool ApplyAfterUpdate = false)
		{
			if (_globals.Keybinds.Count == 0)
			{
				if (!ApplyAfterUpdate)
				{
					Tools.Console("Couldn't load Keybinds.", "Red", "richConsole", "frmMain", true);
				}
				return;
			}
			if (_globals.Start)
			{
				if (!ApplyAfterUpdate)
				{
					Tools.Console("You can't change these Settings while Jack is running.", "Red", "richConsole", "frmMain", true);
				}
				return;
			}
			if (Jack.Core.Settings.GameFolder.Length != 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				Keybinds keybinds = _globals.Keybinds[0];
				foreach (PropertyInfo propertyInfo in keybinds.GetType().GetProperties())
				{
					string name = propertyInfo.Name;
					string text = (string)propertyInfo.GetValue(keybinds, null);
					if (frmMainKeybinds.WoWKeybinds.ContainsKey(name))
					{
						if (frmMainKeybinds.WoWKeys.ContainsKey(text))
						{
							text = frmMainKeybinds.WoWKeys[text];
						}
						stringBuilder.Append(string.Concat(new string[]
						{
							"__SETTINGS__[\"KEYBINDS\"][\"",
							frmMainKeybinds.WoWKeybinds[name],
							"\"] = \"",
							text,
							"\" -- ",
							name,
							"\r\n"
						}));
					}
				}
				Addon.ChangeKeybinds(stringBuilder.ToString());
				return;
			}
			if (!ApplyAfterUpdate)
			{
				Addon.CheckOnStart();
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x006CEFF0 File Offset: 0x006CD1F0
		private void btnKeybindsTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			Tooltip tooltip = new Tooltip();
			string title = "Custom Keybinds";
			string text = "Depending on your profiles you should set the appropriate keybinds here. Or set them already in advance.\r\n\r\n";
			text = text + Tools.HTMLColor("NOTE!", "DeepSkyBlue") + "\r\n";
			text += "All keybinds set here must also be set in the game.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.MarkControlName = "listKeybindsCustom";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Default Keybinds";
			text = "These keybinds are created automatically by Jack.\r\n\r\n";
			text = text + Tools.HTMLColor("NOTE!", "DeepSkyBlue") + "\r\n";
			text += "Click on \"Apply\" after change.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.MarkControlName = "listKeybindsDefault";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Set Default Keybinds";
			text = "";
			if (Jack.Core.Settings.GameFolder.Length == 0)
			{
				text = Tools.HTMLColor("Please install the Jack Addon first.", "Red") + "\r\n\r\n";
			}
			text += "Here you can reset your Keybinds do default.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.MarkControlName = "btnKeybindsAddonSet";
			tooltip3.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			Tools.OpenTooltips(list);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x006D023C File Offset: 0x006CE43C
		// Note: this type is marked as 'beforefieldinit'.
		static frmMainKeybinds()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["JackMacro"] = "MULTIACTIONBAR2BUTTON1";
			dictionary["MoveForward"] = "MOVEFORWARD";
			dictionary["MoveBackward"] = "MOVEBACKWARD";
			dictionary["TurnLeft"] = "TURNLEFT";
			dictionary["TurnRight"] = "TURNRIGHT";
			dictionary["StrafeLeft"] = "STRAFELEFT";
			dictionary["StrafeRight"] = "STRAFERIGHT";
			dictionary["MoveDown"] = "SITORSTAND";
			dictionary["Jump"] = "JUMP";
			dictionary["PitchUp"] = "PITCHUP";
			dictionary["PitchDown"] = "PITCHDOWN";
			dictionary["TargetMouseover"] = "TARGETMOUSEOVER";
			dictionary["InteractWithMouseover"] = "INTERACTMOUSEOVER";
			dictionary["InteractWithTarget"] = "INTERACTTARGET";
			dictionary["ActionBar1_1"] = "ACTIONBUTTON1";
			dictionary["ActionBar1_2"] = "ACTIONBUTTON2";
			dictionary["ActionBar1_3"] = "ACTIONBUTTON3";
			dictionary["ActionBar1_4"] = "ACTIONBUTTON4";
			dictionary["ActionBar1_5"] = "ACTIONBUTTON5";
			dictionary["ActionBar1_6"] = "ACTIONBUTTON6";
			dictionary["ActionBar1_7"] = "ACTIONBUTTON7";
			dictionary["ActionBar1_8"] = "ACTIONBUTTON8";
			dictionary["ActionBar1_9"] = "ACTIONBUTTON9";
			dictionary["ActionBar1_10"] = "ACTIONBUTTON10";
			dictionary["ActionBar1_11"] = "ACTIONBUTTON11";
			dictionary["ActionBar1_12"] = "ACTIONBUTTON12";
			dictionary["ActionBar6_1"] = "MULTIACTIONBAR1BUTTON1";
			dictionary["ActionBar6_2"] = "MULTIACTIONBAR1BUTTON2";
			dictionary["ActionBar6_3"] = "MULTIACTIONBAR1BUTTON3";
			dictionary["ActionBar6_4"] = "MULTIACTIONBAR1BUTTON4";
			dictionary["ActionBar6_5"] = "MULTIACTIONBAR1BUTTON5";
			dictionary["ActionBar6_6"] = "MULTIACTIONBAR1BUTTON6";
			dictionary["ActionBar6_7"] = "MULTIACTIONBAR1BUTTON7";
			dictionary["ActionBar6_8"] = "MULTIACTIONBAR1BUTTON8";
			dictionary["ActionBar6_9"] = "MULTIACTIONBAR1BUTTON9";
			dictionary["ActionBar6_10"] = "MULTIACTIONBAR1BUTTON10";
			dictionary["ActionBar6_11"] = "MULTIACTIONBAR1BUTTON11";
			dictionary["ActionBar6_12"] = "MULTIACTIONBAR1BUTTON12";
			frmMainKeybinds.WoWKeybinds = dictionary;
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			dictionary2["Nr1"] = "1";
			dictionary2["Nr2"] = "2";
			dictionary2["Nr3"] = "3";
			dictionary2["Nr4"] = "4";
			dictionary2["Nr5"] = "5";
			dictionary2["Nr6"] = "6";
			dictionary2["Nr7"] = "7";
			dictionary2["Nr8"] = "8";
			dictionary2["Nr9"] = "9";
			dictionary2["Nr0"] = "10";
			dictionary2["Escape"] = "ESC";
			dictionary2["Prior"] = "PAGEUP";
			dictionary2["Next"] = "PAGEDOWN";
			dictionary2["Divide"] = "NUMPADDIVIDE";
			dictionary2["Multiply"] = "NUMPADMULTIPLY";
			dictionary2["Subtract"] = "NUMPADMINUS";
			dictionary2["Add"] = "NUMPADPLUS";
			dictionary2["Decimal"] = "NUMPADDECIMAL";
			dictionary2["OEMMinus"] = "-";
			dictionary2["OEMPlus"] = "+";
			dictionary2["OEM2"] = "#";
			dictionary2["OEMComma"] = ",";
			dictionary2["OEMPeriod"] = ".";
			dictionary2["OEM5"] = "^";
			dictionary2["OEM6"] = "´";
			dictionary2["OEM102"] = "<";
			frmMainKeybinds.WoWKeys = dictionary2;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x006D06E0 File Offset: 0x006CE8E0
		PropertyInfo[] method_0()
		{
			return base.GetProperties();
		}

		// Token: 0x04000668 RID: 1640
		private string KeybindName = "";

		// Token: 0x04000669 RID: 1641
		private string PreviousKey = "";

		// Token: 0x0400066A RID: 1642
		private int KeybindIndex = -1;

		// Token: 0x0400066B RID: 1643
		public static List<string> CustomKeybinds = new List<string>
		{
			"GroundMount",
			"FlightMount",
			"VendorMount",
			"Hearthstone",
			"PetAttack",
			"FeedPet",
			"MainHandEnchantment",
			"OffHandEnchantment",
			"Fishing",
			"Bait",
			"GSE"
		};

		// Token: 0x0400066C RID: 1644
		public static Dictionary<string, string> WoWKeybinds;

		// Token: 0x0400066D RID: 1645
		public static Dictionary<string, string> WoWKeys;
	}
}
