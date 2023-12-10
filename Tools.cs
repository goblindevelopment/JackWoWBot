using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.ATH;
using Jack.Core;
using Jack.Engine;
using Jack.Forms;
using Jack.Models;
using Jack.Properties;
using Newtonsoft.Json;

namespace Jack
{
	// Token: 0x02000014 RID: 20
	public static class Tools
	{
		// Token: 0x06000103 RID: 259 RVA: 0x0066AA7C File Offset: 0x00668C7C
		public static Color GetColor(string ColorName)
		{
			if (ColorName.Length > 0)
			{
				if (ColorName == "Green")
				{
					ColorName = ColorName.Replace("Green", "LimeGreen");
				}
				else
				{
					if (ColorName == "ListViewHeader")
					{
						return Color.FromArgb(27, 33, 43);
					}
					if (ColorName == "Purple")
					{
						return Color.FromArgb(252, 3, 248);
					}
					if (ColorName == "Blue")
					{
						return Color.DeepSkyBlue;
					}
					if (ColorName == "Button")
					{
						return Color.FromArgb(0, 119, 230);
					}
				}
				return Color.FromName(ColorName);
			}
			return Color.Black;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0066AB28 File Offset: 0x00668D28
		public static void Console(string Data = "", string Color = "", string ControlName = "richConsole", string FormName = "frmMain", bool Timestamp = true)
		{
			if (Data.Length > 0 && Data != "clear")
			{
				Tools.AddToConsoleLog(Data, Color);
				if (Timestamp)
				{
					Data = "[" + DateTime.Now.ToString("HH:mm:ss") + "] " + Data;
				}
				object lockFullLog = Tools._lockFullLog;
				lock (lockFullLog)
				{
					Tools.FullLog.Add(Data);
				}
			}
			if (Color.Length > 0)
			{
				Tools.ControlColor(Data, ControlName, FormName, Tools.GetColor(Color), null, false);
				return;
			}
			Tools.Control(Data, ControlName, FormName, true, false, false, false, 0);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0066ABD8 File Offset: 0x00668DD8
		private static void AddToConsoleLog(string Data, string Color)
		{
			if (Data.Length > 50)
			{
				Data = Data.Substring(0, 50) + "...";
			}
			if (Color.Length == 0)
			{
				Color = "White";
			}
			else
			{
				Color = "BlueLight";
			}
			int key = Tools.ConsoleLog.Count + 1;
			try
			{
				if (!Tools.ConsoleLog.ContainsKey(key))
				{
					Tools.ConsoleLog.Add(key, new string[]
					{
						Data,
						Color
					});
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0066AC64 File Offset: 0x00668E64
		public static List<string[]> GetConsoleLog(int Last)
		{
			Tools.Log.Clear();
			int num = 1;
			int count = Tools.ConsoleLog.Count;
			if (Tools.ConsoleLog.Count > Last)
			{
				num = Tools.ConsoleLog.Count - (Last - 1);
			}
			for (int i = num; i <= count; i++)
			{
				Tools.Log.Add(Tools.ConsoleLog[i]);
			}
			return Tools.Log;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0066ACCC File Offset: 0x00668ECC
		public static void SaveLog()
		{
			object lockFullLog = Tools._lockFullLog;
			lock (lockFullLog)
			{
				string b = DateTime.Now.ToString("dd.MM.yyyy");
				if (Tools.Date != b)
				{
					Tools.Date = DateTime.Now.ToString("dd.MM.yyyy");
				}
				string path = _globals.JackLogs + "\\" + Tools.Date + ".txt";
				bool flag2 = true;
				if (!File.Exists(path))
				{
					File.Create(path);
				}
				try
				{
					File.ReadLines(path).Count<string>();
				}
				catch
				{
					flag2 = false;
				}
				if (flag2)
				{
					foreach (string str in Tools.FullLog)
					{
						try
						{
							File.AppendAllText(path, str + Environment.NewLine);
						}
						catch
						{
						}
					}
					Tools.FullLog.Clear();
				}
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0066ADFC File Offset: 0x00668FFC
		public static void ControlSelect(string ControlName, string FormName, string SelectOrDelete = "", bool Delete = false)
		{
			Form form = Application.OpenForms[FormName];
			ComboBox Control = null;
			if (form != null)
			{
				try
				{
					Control[] array = form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						Control = (array[0] as ComboBox);
						if (Control.Items.Count > 0)
						{
							if (Delete)
							{
								if (SelectOrDelete.Length > 0)
								{
									Control.Invoke(new Action(delegate()
									{
										Control.Items.RemoveAt(Control.FindString(SelectOrDelete));
									}));
								}
							}
							else if (SelectOrDelete == "")
							{
								Control.Invoke(new Action(delegate()
								{
									Control.SelectedIndex = 0;
								}));
							}
							else
							{
								Control.Invoke(new Action(delegate()
								{
									int num = Control.FindString(SelectOrDelete);
									if (num > -1)
									{
										Control.SelectedIndex = num;
									}
								}));
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0066AEEC File Offset: 0x006690EC
		public static void Control(dynamic Data, string ControlName, string Form = "frmMain", bool Enabled = true, bool DeleteOrNummering = false, bool DeleteAll = false, bool ForceAdd = false, int Checked = 0)
		{
			Tools.<>c__DisplayClass13_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass13_0();
			CS$<>8__locals1.Data = Data;
			CS$<>8__locals1.Enabled = Enabled;
			CS$<>8__locals1.DeleteOrNummering = DeleteOrNummering;
			CS$<>8__locals1.DeleteAll = DeleteAll;
			CS$<>8__locals1.ForceAdd = ForceAdd;
			CS$<>8__locals1.Checked = Checked;
			Form form = Application.OpenForms[Form];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					Control[] array = form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						CS$<>8__locals1.Control = array[0];
						if (form.InvokeRequired)
						{
							CS$<>8__locals1.Control.Invoke(new Action(delegate()
							{
								base.method_0();
							}));
						}
						else
						{
							CS$<>8__locals1.method_0();
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0066AF9C File Offset: 0x0066919C
		public static void ControlVisible(string ControlName, string FormName, bool Visible)
		{
			Tools.<>c__DisplayClass14_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass14_0();
			CS$<>8__locals1.Visible = Visible;
			Form form = Application.OpenForms[FormName];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					Control[] array = form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						CS$<>8__locals1.Control = array[0];
						if (!form.InvokeRequired)
						{
							CS$<>8__locals1.method_0();
						}
						else
						{
							CS$<>8__locals1.Control.Invoke(new Action(delegate()
							{
								base.method_0();
							}));
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0066B024 File Offset: 0x00669224
		public static void ControlColor(dynamic Data, string ControlName, string Form = "frmMain", Color Color = default(Color), string[] MustContain = null, bool BackgroundColor = false)
		{
			Tools.<>c__DisplayClass15_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass15_0();
			CS$<>8__locals1.Data = Data;
			CS$<>8__locals1.Color = Color;
			CS$<>8__locals1.MustContain = MustContain;
			CS$<>8__locals1.BackgroundColor = BackgroundColor;
			Form form = Application.OpenForms[Form];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					Control[] array = form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						CS$<>8__locals1.Control = array[0];
						if (CS$<>8__locals1.Control != null)
						{
							if (!form.InvokeRequired)
							{
								CS$<>8__locals1.method_0();
							}
							else
							{
								CS$<>8__locals1.Control.Invoke(new Action(delegate()
								{
									base.method_0();
								}));
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0066B0CC File Offset: 0x006692CC
		public static void ControlAction(string Data, Control Control, bool Enabled = true)
		{
			try
			{
				if (Data == "clear")
				{
					Control.Text = "";
				}
				else if (Data.Length > 0)
				{
					Control.Text = Data;
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0066B140 File Offset: 0x00669340
		public static void ControlAction(string Data, CheckBox Control, bool Enabled = true, int Checked = 0)
		{
			try
			{
				if (Data.Length > 0)
				{
					Control.Text = Data;
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				if (Checked == 1)
				{
					Control.Checked = true;
				}
				else if (Checked == 2)
				{
					Control.Checked = false;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0066B1B4 File Offset: 0x006693B4
		public static void ControlAction(string Data, Guna2TextBox Control, bool Enabled = true)
		{
			try
			{
				if (Data.Length > 0)
				{
					Control.Text = Data;
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0066B20C File Offset: 0x0066940C
		public static void ControlAction(string Data, Guna2ProgressBar Control, bool Enabled = true)
		{
			try
			{
				if (Data.Length > 0)
				{
					Control.Text = Data;
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0066B264 File Offset: 0x00669464
		public static void ControlAction(string Data, RichTextBox Control, bool Enabled = true)
		{
			try
			{
				if (Data == "clear")
				{
					Control.Text = "";
				}
				else
				{
					if (Control.Text.Length > 0)
					{
						Control.AppendText("\r\n");
						Control.AppendText(Data);
					}
					else
					{
						Control.AppendText(Data);
					}
					Control.SelectionStart = Control.Text.Length;
					Control.ScrollToCaret();
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0066B308 File Offset: 0x00669508
		public static void ControlAction(List<string> Data, ListBox Control, bool Enabled = true, bool Nummering = true)
		{
			try
			{
				Control.Items.Clear();
				if (Data.Count <= 0)
				{
					Control.Items.Add("None");
				}
				else
				{
					for (int i = 0; i < Data.Count; i++)
					{
						if (!Nummering)
						{
							Control.Items.Add(Data[i]);
						}
						else
						{
							Control.Items.Add((i + 1).ToString() + ". " + Data[i]);
						}
					}
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0066B3C8 File Offset: 0x006695C8
		public static void ControlAction(List<Vector3> Data, ListBox Control, bool Enabled = true, bool Nummering = true)
		{
			try
			{
				Control.Items.Clear();
				if (Data.Count <= 0)
				{
					Control.Items.Add("None");
				}
				else
				{
					for (int i = 0; i < Data.Count; i++)
					{
						if (!Nummering)
						{
							Control.Items.Add(Data[i]);
						}
						else
						{
							Control.Items.Add((i + 1).ToString() + ". " + Data[i].ToString());
						}
					}
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0066B49C File Offset: 0x0066969C
		public static void ControlAction(string Data, ListBox Control, bool Enabled = true, bool Nummering = true)
		{
			try
			{
				if (Data == "clear")
				{
					Control.Items.Clear();
					Control.Items.Add("None");
				}
				else
				{
					Control.Items.Add(Data);
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0066B51C File Offset: 0x0066971C
		public static void StartStop(string Mode)
		{
			Tools.<>c__DisplayClass24_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass24_0();
			CS$<>8__locals1.Mode = Mode;
			Form form = Application.OpenForms["frmMain"];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					CS$<>8__locals1.Control = form.Controls.Find("btnStart", true)[0];
					if (CS$<>8__locals1.Control != null)
					{
						if (form.InvokeRequired)
						{
							CS$<>8__locals1.Control.Invoke(new Action(delegate()
							{
								base.method_0();
							}));
						}
						else
						{
							CS$<>8__locals1.method_0();
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0066B5B0 File Offset: 0x006697B0
		public static void ControlAction(string Data, ComboBox Control, bool Enabled = true, bool Nummering = true)
		{
			try
			{
				if (Data == "clear")
				{
					Control.Items.Clear();
				}
				else
				{
					Control.Items.Add(Data);
				}
				if (Enabled && !Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
				else if (!Enabled && Control.Enabled)
				{
					Control.Enabled = Enabled;
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0066B620 File Offset: 0x00669820
		public static void ControlComboBoxCreate(List<string> Items, string ControlName, string FormName, bool Clear = false)
		{
			Tools.<>c__DisplayClass26_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass26_0();
			CS$<>8__locals1.Clear = Clear;
			CS$<>8__locals1.Items = Items;
			Form form = Application.OpenForms[FormName];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					Control[] array = form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						CS$<>8__locals1.Control = (array[0] as ComboBox);
						if (!form.InvokeRequired)
						{
							CS$<>8__locals1.method_0();
						}
						else
						{
							CS$<>8__locals1.Control.Invoke(new Action(delegate()
							{
								base.method_0();
							}));
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0066B6B4 File Offset: 0x006698B4
		private static void ControlAction(string[] Add, ListView Control, bool Enabled = true, bool Delete = false, bool DeleteAll = false, bool ForceAdd = false)
		{
			if (!DeleteAll)
			{
				if (Add != null && Add != null)
				{
					string ItemKey = Add[0];
					string text = Add[1];
					ListViewItem listViewItem = null;
					if (!ForceAdd)
					{
						listViewItem = (from ListViewItem x in Control.Items
						where x.Text == ItemKey
						select x).FirstOrDefault<ListViewItem>();
					}
					if (listViewItem == null)
					{
						if (!Delete)
						{
							ListViewItem listViewItem2 = new ListViewItem(ItemKey);
							if (!text.Contains("|"))
							{
								listViewItem2.SubItems.Add(text);
								if (!(text == "True"))
								{
									listViewItem2.BackColor = Color.FromArgb(23, 39, 52);
								}
								else
								{
									listViewItem2.BackColor = Color.FromArgb(0, 255, 174);
								}
							}
							else
							{
								string[] array = text.Split(new char[]
								{
									'|'
								});
								for (int i = 1; i < array.Count<string>(); i++)
								{
									listViewItem2.SubItems.Add(array[i]);
								}
							}
							Control.Items.Add(listViewItem2);
						}
					}
					else
					{
						int index = Control.Items.IndexOf(listViewItem);
						if (!Delete)
						{
							if (!text.Contains("|"))
							{
								Control.Items[index].SubItems[1].Text = text;
								if (!(text == "True"))
								{
									Control.Items[index].BackColor = Color.FromArgb(23, 39, 52);
								}
								else
								{
									Control.Items[index].BackColor = Color.FromArgb(0, 255, 174);
								}
							}
							else
							{
								string[] array2 = text.Split(new char[]
								{
									'|'
								});
								for (int j = 0; j < array2.Count<string>(); j++)
								{
									Control.Items[index].SubItems[j].Text = array2[j];
								}
							}
						}
						else
						{
							Control.Items[index].Remove();
						}
					}
				}
			}
			else if (DeleteAll && Control.Items.Count > 0)
			{
				Control.Items.Clear();
			}
			if (Enabled && !Control.Enabled)
			{
				Control.Enabled = Enabled;
				return;
			}
			if (!Enabled && Control.Enabled)
			{
				Control.Enabled = Enabled;
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0066B8FC File Offset: 0x00669AFC
		public static void ControlListViewCreate(Dictionary<string[], string[]> Items, string ControlName, string FormName, bool Clear = false, int PreSelect = -1, ImageList ImgList = null)
		{
			Tools.<>c__DisplayClass28_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass28_0();
			CS$<>8__locals1.Clear = Clear;
			CS$<>8__locals1.Items = Items;
			CS$<>8__locals1.ImgList = ImgList;
			CS$<>8__locals1.PreSelect = PreSelect;
			Form form = Application.OpenForms[FormName];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					Control[] array = form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						CS$<>8__locals1.Control = (array[0] as ListView);
						if (form.InvokeRequired)
						{
							CS$<>8__locals1.Control.Invoke(new Action(delegate()
							{
								base.method_0();
							}));
						}
						else
						{
							CS$<>8__locals1.method_0();
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0066B9A0 File Offset: 0x00669BA0
		public static void ColorListViewHeader(ref ListView list, List<string[]> HeaderData = null)
		{
			list.OwnerDraw = true;
			list.DrawColumnHeader += delegate(object sender, DrawListViewColumnHeaderEventArgs e)
			{
				Tools.ColorListViewHeaderDraw(sender, e, HeaderData);
			};
			list.DrawItem += Tools.ColorListViewBodyDraw;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0066B9E8 File Offset: 0x00669BE8
		private static void ColorListViewHeaderDraw(object sender, DrawListViewColumnHeaderEventArgs e, List<string[]> HeaderData = null)
		{
			ListView listView = (ListView)sender;
			int num = e.ColumnIndex;
			int num2 = e.Bounds.X + 4;
			int num3 = e.Bounds.Y + 4;
			Color color = Tools.GetColor("ListViewHeader");
			Color color2 = Color.Silver;
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Near;
			if (HeaderData != null)
			{
				if (HeaderData != null && num > HeaderData.Count - 1)
				{
					num = 0;
				}
				if (HeaderData[num][0].Length > 0)
				{
					color = Tools.GetColor(HeaderData[num][0]);
				}
				if (HeaderData[num][1].Length > 0)
				{
					color2 = Tools.GetColor(HeaderData[num][1]);
				}
				if (HeaderData[num][2] == "Center")
				{
					stringFormat.Alignment = StringAlignment.Center;
					num2 = e.Bounds.X + listView.Columns[e.ColumnIndex].Width / 2;
				}
				else if (HeaderData != null && HeaderData[num][2] == "Right")
				{
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				e.Graphics.FillRectangle(solidBrush, e.Bounds);
			}
			using (SolidBrush solidBrush2 = new SolidBrush(color2))
			{
				e.Graphics.DrawString(e.Header.Text, e.Font, solidBrush2, (float)num2, (float)num3, stringFormat);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0066BB8C File Offset: 0x00669D8C
		private static void ColorListViewBodyDraw(object sender, DrawListViewItemEventArgs e)
		{
			e.DrawDefault = true;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0066BBA0 File Offset: 0x00669DA0
		public static void CenterListViewColumns(ListView Listview, int[] ColumnSizes = null)
		{
			int num = -1;
			if (ColumnSizes != null)
			{
				num = ColumnSizes.Count<int>();
			}
			int count = Listview.Columns.Count;
			int width = Listview.ClientRectangle.Width / count;
			if (num > -1)
			{
				int num2 = 0;
				int num3 = 0;
				foreach (int num4 in ColumnSizes)
				{
					if (num4 > -1)
					{
						num2 += num4;
						num3++;
					}
				}
				int num5 = count - num3;
				width = Listview.ClientRectangle.Width / num5 - num2 / num5;
			}
			for (int j = 0; j < count; j++)
			{
				if (num - 1 >= j && ColumnSizes[j] > -1)
				{
					Listview.Columns[j].Width = ColumnSizes[j];
				}
				else
				{
					Listview.Columns[j].Width = width;
				}
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0066BC78 File Offset: 0x00669E78
		public static bool ListViewHasSelection(ListView List)
		{
			return List.SelectedItems.Count > 0 && List.SelectedIndices.Count > 0;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0066BCA4 File Offset: 0x00669EA4
		public static void SwitchButtonColor(string Text, string DefaultText, string ControlName, string FormName, string Color)
		{
			Tools.<>c__DisplayClass34_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass34_0();
			CS$<>8__locals1.Text = Text;
			CS$<>8__locals1.ControlName = ControlName;
			CS$<>8__locals1.FormName = FormName;
			CS$<>8__locals1.Color = Color;
			CS$<>8__locals1.DefaultText = DefaultText;
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0066BCF8 File Offset: 0x00669EF8
		public static void ButtonTimer(string ButtonText, string ButtonWaitText, int Timer, string ControlName, string FormName)
		{
			Tools.<>c__DisplayClass35_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass35_0();
			CS$<>8__locals1.Timer = Timer;
			CS$<>8__locals1.ButtonWaitText = ButtonWaitText;
			CS$<>8__locals1.ControlName = ControlName;
			CS$<>8__locals1.FormName = FormName;
			CS$<>8__locals1.ButtonText = ButtonText;
			Tools.Control("", CS$<>8__locals1.ControlName, CS$<>8__locals1.FormName, false, false, false, false, 0);
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0066BD68 File Offset: 0x00669F68
		public static void DisableButtonWithTimer(int Timer, string ControlName, string FormName)
		{
			Tools.<>c__DisplayClass36_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass36_0();
			CS$<>8__locals1.Timer = Timer;
			CS$<>8__locals1.ControlName = ControlName;
			CS$<>8__locals1.FormName = FormName;
			Tools.Control("", CS$<>8__locals1.ControlName, CS$<>8__locals1.FormName, false, false, false, false, 0);
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0066BDC8 File Offset: 0x00669FC8
		public static void SetProgress(string FormName, string ControlName, int ControlValue, bool SetMaxValue = false, string SetText = "")
		{
			Tools.<>c__DisplayClass37_0 CS$<>8__locals1 = new Tools.<>c__DisplayClass37_0();
			CS$<>8__locals1.SetMaxValue = SetMaxValue;
			CS$<>8__locals1.ControlValue = ControlValue;
			CS$<>8__locals1.SetText = SetText;
			Form form = Application.OpenForms[FormName];
			CS$<>8__locals1.Control = null;
			if (form != null)
			{
				try
				{
					CS$<>8__locals1.Control = (Guna2ProgressBar)form.Controls.Find(ControlName, true)[0];
					if (CS$<>8__locals1.Control != null)
					{
						if (form.InvokeRequired)
						{
							CS$<>8__locals1.Control.Invoke(new Action(delegate()
							{
								base.method_0();
							}));
						}
						else
						{
							CS$<>8__locals1.method_0();
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0066BE68 File Offset: 0x0066A068
		public static string HTMLColor(string Text, string Color)
		{
			if (Tools.HexColors.ContainsKey(Color))
			{
				Color = Tools.HexColors[Color];
			}
			return string.Concat(new string[]
			{
				"<font style=\"color:",
				Color,
				"\">",
				Text,
				"</font>"
			});
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0066BEBC File Offset: 0x0066A0BC
		public static void OpenForm(string frmName, bool AsDialog = false, string ParentFormLocation = "frmMain", params object[] args)
		{
			Form form = Application.OpenForms[frmName];
			if (form != null && (frmName == "frmProfile" || frmName == "frmProfileSave" || frmName == "frmProfileEvent" || frmName == "frmProfileEventSave" || frmName == "frmRotation" || frmName == "frmRotationConditions" || frmName == "frmRotationSave" || frmName == "frmOverlayMenu"))
			{
				form.Close();
				form = Application.OpenForms[frmName];
			}
			if (form == null)
			{
				Type type = Type.GetType("Jack.Forms." + frmName);
				if (!(type != null))
				{
					return;
				}
				Form form2 = Activator.CreateInstance(type, args) as Form;
				if (Jack.Core.Settings.FirstStart && ((frmName != "frmLicense" && !frmName.StartsWith("frmDownload") && frmName != "frmSplashScreen") || (frmName == "frmDownload" && Application.OpenForms["frmMain"] != null)))
				{
					Form form3 = Application.OpenForms[ParentFormLocation];
					if (form3 == null)
					{
						form3 = Application.OpenForms["frmMain"];
					}
					form2.StartPosition = FormStartPosition.Manual;
					form2.Location = new Point(form3.Location.X + (form3.Width - form2.Width) / 2, form3.Location.Y + (form3.Height - form2.Height) / 2);
				}
				try
				{
					if (AsDialog)
					{
						form2.ShowDialog();
					}
					else
					{
						form2.Show();
					}
					return;
				}
				catch
				{
					return;
				}
			}
			form.Close();
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0066C074 File Offset: 0x0066A274
		public static void CloseForm(string frmName, params object[] args)
		{
			Form frm = Application.OpenForms[frmName];
			if (frm != null)
			{
				if (frm.InvokeRequired)
				{
					frm.Invoke(new Action(delegate()
					{
						frm.Close();
					}));
					return;
				}
				frm.Close();
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0066C0D4 File Offset: 0x0066A2D4
		public static bool IsFormOpen(string FormName)
		{
			return Application.OpenForms[FormName] != null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0066C0F4 File Offset: 0x0066A2F4
		public static Form GetForm(string FormName)
		{
			using (List<Form>.Enumerator enumerator = _globals.JackForms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Form form = enumerator.Current;
					if (form.Name == FormName)
					{
						return form;
					}
				}
				goto IL_43;
			}
			Form result;
			return result;
			IL_43:
			return null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0066C158 File Offset: 0x0066A358
		public static void ShowForm(string FormName)
		{
			using (List<Form>.Enumerator enumerator = _globals.JackForms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Form form = enumerator.Current;
					if (form.Name == FormName)
					{
						if (!form.InvokeRequired)
						{
							Tools.smethod_0(form);
							break;
						}
						form.Invoke(new Action(delegate()
						{
							Tools.smethod_0(form);
						}));
						break;
					}
				}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0066C1F8 File Offset: 0x0066A3F8
		public static void HideForm(string FormName)
		{
			using (List<Form>.Enumerator enumerator = _globals.JackForms.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Form form = enumerator.Current;
					if (form.Name == FormName)
					{
						if (form.InvokeRequired)
						{
							form.Invoke(new Action(delegate()
							{
								Tools.smethod_1(form);
							}));
							break;
						}
						Tools.smethod_1(form);
						break;
					}
				}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0066C298 File Offset: 0x0066A498
		public static void CloseJack(bool EnvironmentExit = false)
		{
			if (EnvironmentExit)
			{
				Environment.Exit(0);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0066C2B0 File Offset: 0x0066A4B0
		public static void OpenTooltips(List<Tooltip> Tooltips)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
			frmTooltip.Tooltips = Tooltips;
			Tools.OpenForm("frmTooltip", false, "frmProfile", Array.Empty<object>());
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0066C2E8 File Offset: 0x0066A4E8
		public static bool InvokeMethod(string FormName, string MethodName, object[] MethodArgs = null, bool Force = false)
		{
			Form form = Application.OpenForms[FormName];
			if (Force || form != null)
			{
				Type type;
				if (!Force)
				{
					type = form.GetType();
				}
				else
				{
					type = Type.GetType("Jack.Forms." + FormName);
					form = (Activator.CreateInstance(type) as Form);
				}
				if (type != null)
				{
					MethodInfo method = type.GetMethod(MethodName);
					if (method != null)
					{
						if (MethodArgs == null)
						{
							method.Invoke(form, new object[0]);
						}
						else
						{
							method.Invoke(form, MethodArgs);
						}
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0066C370 File Offset: 0x0066A570
		public static UInt128 StringToInt128(string value)
		{
			UInt128 @uint = 0;
			if (value.Length > 0)
			{
				BigInteger bigInteger = 0;
				for (int i = 0; i < value.Length; i++)
				{
					bigInteger = bigInteger * 10 + (int)(value[i] - '0');
				}
				return (UInt128)bigInteger;
			}
			return 0;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0066C3D8 File Offset: 0x0066A5D8
		public static Vector3 StringToVector3(string V3)
		{
			if (V3.Length > 0)
			{
				V3 = V3.Replace(" ", "").Replace("<", "").Replace(">", "");
				string[] array = (from s in V3.Split(new char[]
				{
					'.'
				})
				select s.Trim()).ToArray<string>();
				if (array.Length == 3)
				{
					float x;
					float y;
					float z;
					if (float.TryParse(array[0], out x) && float.TryParse(array[1], out y) && float.TryParse(array[2], out z))
					{
						return new Vector3(x, y, z);
					}
				}
			}
			return new Vector3(0f, 0f, 0f);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0066C4A8 File Offset: 0x0066A6A8
		public static string RandomString(int length = 15, bool randomLength = false)
		{
			if (randomLength)
			{
				int num = length / 3;
				length = Tools.Rnd.Next(length - num, length + num);
			}
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Tools.Rnd.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0066C508 File Offset: 0x0066A708
		public static List<string> RandomStrings(int Amount = 2, int length = 15)
		{
			List<string> list = new List<string>();
			Random random = new Random();
			Func<string, char> <>9__0;
			for (int i = 0; i < Amount; i++)
			{
				IEnumerable<string> source = Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length);
				Func<string, char> selector;
				if ((selector = <>9__0) == null)
				{
					selector = (<>9__0 = ((string s) => s[random.Next(s.Length)]));
				}
				string item = new string(source.Select(selector).ToArray<char>());
				list.Add(item);
			}
			return list;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0066C57C File Offset: 0x0066A77C
		public static int RandomID
		{
			get
			{
				return Tools.Rnd.Next(100000, 999999);
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0066C5A0 File Offset: 0x0066A7A0
		public static string RandomTimer(string TimerName = "")
		{
			if (TimerName.Length > 0)
			{
				TimerName += "-";
			}
			return TimerName + Tools.Rnd.Next(100000, 999999).ToString();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0066C5E8 File Offset: 0x0066A7E8
		public static void ProfilesToSelection(string ControlName, string FormName, string Selection = "", bool Clear = false, bool Rotations = false)
		{
			string text = _globals.JackProfiles;
			if (Rotations)
			{
				text = _globals.JackRotations;
			}
			if (Directory.Exists(text))
			{
				string text2 = "";
				List<string> list = new List<string>();
				string[] directories = Directory.GetDirectories(text);
				for (int i = 0; i < directories.Length; i++)
				{
					string fileName = Path.GetFileName(directories[i]);
					if (fileName != "Utilities")
					{
						foreach (string path in Directory.EnumerateFiles(text + "\\" + fileName, "*.json"))
						{
							string str = Path.GetFileName(path).Replace(".json", "");
							list.Add(fileName + "\\" + str);
						}
					}
				}
				foreach (string path2 in Directory.EnumerateFiles(text, "*.json"))
				{
					string text3 = Path.GetFileName(path2).Replace(".json", "");
					list.Add(text3);
					if (Selection.Length > 0 && text3.Contains(Selection))
					{
						text2 = text3;
					}
				}
				Tools.ControlComboBoxCreate(list, ControlName, FormName, Clear);
				if (text2.Length > 0)
				{
					Tools.ControlSelect(ControlName, FormName, text2, false);
					return;
				}
				Tools.ControlSelect(ControlName, FormName, "", false);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0066C76C File Offset: 0x0066A96C
		public static void SpellsToSelectionField(string ControlName, string FormName, string Selection = "", bool Clear = false)
		{
			string text = "";
			List<string> list = new List<string>();
			list.Add("# SPELLS #");
			foreach (Spellbook.SpellList spellList in Spellbook.GetSpells)
			{
				if (spellList.Name.Length > 0)
				{
					string text2 = spellList.Name;
					int num;
					if (spellList.Rank > 0)
					{
						string str = text2;
						string str2 = " (Rank ";
						num = spellList.Rank;
						text2 = str + str2 + num.ToString() + ")";
					}
					string str3 = text2;
					string str4 = " (Required Level: ";
					num = spellList.RequiredLevel;
					text2 = str3 + str4 + num.ToString() + ")";
					string str5 = text2;
					string str6 = " [";
					num = spellList.ID;
					text2 = str5 + str6 + num.ToString() + "]";
					list.Add(text2);
					if (Selection.Length > 0 && text2.Contains(Selection))
					{
						text = text2;
					}
				}
			}
			Tools.ControlComboBoxCreate(list, ControlName, FormName, Clear);
			if (text.Length > 0)
			{
				Tools.ControlSelect(ControlName, FormName, text, false);
				return;
			}
			Tools.ControlSelect(ControlName, FormName, "", false);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0066C8A0 File Offset: 0x0066AAA0
		public static void ItemsToSelectionField(string ControlName, string FormName, string Selection = "", bool Clear = false)
		{
			string text = "";
			List<string> list = new List<string>();
			list.Add("# ITEMS #");
			foreach (Items items in ObjectManager.GetItemsInBags)
			{
				if (items.ItemName.Length > 0)
				{
					string text2 = items.ItemName + " [" + items.ItemID.ToString() + "]";
					list.Add(text2);
					if (Selection.Length > 0 && text2.Contains(Selection))
					{
						text = text2;
					}
				}
			}
			Tools.ControlComboBoxCreate(list, ControlName, FormName, Clear);
			if (text.Length > 0)
			{
				Tools.ControlSelect(ControlName, FormName, text, false);
				return;
			}
			Tools.ControlSelect(ControlName, FormName, "", false);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0066C980 File Offset: 0x0066AB80
		public static void ReplaceInProfiles(string ToReplace, string ReplaceWith, string[] ExcludeFiles = null)
		{
			if (Directory.Exists(_globals.JackProfiles))
			{
				foreach (string path in Directory.EnumerateFiles(_globals.JackProfiles, "*.json"))
				{
					if (ExcludeFiles != null && ExcludeFiles.Count<string>() > 0)
					{
						string value = Path.GetFileName(path).Replace(".json", "");
						if (ExcludeFiles.Contains(value))
						{
							continue;
						}
					}
					string text = File.ReadAllText(path);
					text = text.Replace(ToReplace, ReplaceWith);
					File.WriteAllText(path, text);
				}
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0066CA20 File Offset: 0x0066AC20
		public static bool ReplaceInFile(string FilePath, string ToReplace, string ReplaceWith, bool SearchPerLine = false)
		{
			if (File.Exists(FilePath))
			{
				if (SearchPerLine)
				{
					string[] array = File.ReadAllLines(FilePath);
					string text = "";
					for (int i = 0; i < array.Count<string>(); i++)
					{
						if (!array[i].Contains(ToReplace))
						{
							string[] array2 = array;
							int num = i;
							array2[num] += "\r\n";
						}
						else
						{
							array[i] = ReplaceWith + "\r\n";
						}
						text += array[i];
					}
					File.WriteAllText(FilePath, text);
				}
				else
				{
					string text2 = File.ReadAllText(FilePath);
					text2 = text2.Replace(ToReplace, ReplaceWith);
					File.WriteAllText(FilePath, text2);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0066CAB4 File Offset: 0x0066ACB4
		public static bool StartProcess(string FileLocation, string Args, bool WaitForExit = false)
		{
			bool result = false;
			Process process = new Process();
			process.StartInfo.FileName = Path.GetFileName(FileLocation);
			process.StartInfo.WorkingDirectory = Path.GetDirectoryName(FileLocation);
			process.StartInfo.Arguments = Args;
			try
			{
				process.Start();
				if (WaitForExit)
				{
					process.WaitForExit(60000);
				}
				result = true;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0066CB28 File Offset: 0x0066AD28
		public static int StartProcessGetID(string FileLocation, string Args)
		{
			int result = 0;
			Process process = new Process();
			process.StartInfo.FileName = Path.GetFileName(FileLocation);
			process.StartInfo.WorkingDirectory = Path.GetDirectoryName(FileLocation);
			process.StartInfo.Arguments = Args;
			try
			{
				process.Start();
				result = process.Id;
			}
			catch
			{
			}
			return result;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0066CB90 File Offset: 0x0066AD90
		public static bool IsFileReady(string FileLocation, bool Write = false)
		{
			FileInfo fileInfo = new FileInfo(FileLocation);
			bool result;
			try
			{
				if (Write)
				{
					using (FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None))
					{
						fileStream.Close();
						goto IL_42;
					}
				}
				using (FileStream fileStream2 = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.None))
				{
					fileStream2.Close();
				}
				IL_42:
				return true;
			}
			catch (IOException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0066CC14 File Offset: 0x0066AE14
		public static void CreateContextMenu(object sender, MouseEventArgs e, string FormName, string ControlName, string MethodName, string[] Items, object[] Special = null)
		{
			Form Form = Application.OpenForms[FormName];
			if (Form != null)
			{
				try
				{
					Control[] array = Form.Controls.Find(ControlName, true);
					if (array.Length != 0)
					{
						Control control = array[0];
						Type type = Form.GetType();
						MethodInfo Method = type.GetMethod(MethodName);
						if (Method != null)
						{
							ListView listView = null;
							if (control is ListView)
							{
								listView = (control as ListView);
							}
							ContextMenu contextMenu = new ContextMenu();
							if (listView != null)
							{
								for (int i = 0; i < Items.Length; i++)
								{
									string Item = Items[i];
									MenuItem menuItem = new MenuItem(Item);
									if (Item.StartsWith("Title:"))
									{
										menuItem.Text = Item.Split(new char[]
										{
											':'
										})[1];
										contextMenu.MenuItems.Add(menuItem);
									}
									else
									{
										if (Item != "-")
										{
											if (Special == null)
											{
												menuItem.Click += delegate(object sender, EventArgs e)
												{
													Method.Invoke(Form, new object[]
													{
														sender2,
														e2,
														Item
													});
												};
											}
											else
											{
												menuItem.Click += delegate(object sender, EventArgs e)
												{
													Method.Invoke(Form, new object[]
													{
														sender2,
														e2,
														Item,
														Special
													});
												};
											}
										}
										contextMenu.MenuItems.Add(menuItem);
									}
								}
								contextMenu.Show(listView, new Point(e2.X, e2.Y));
							}
						}
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0066CDEC File Offset: 0x0066AFEC
		public static void SetCursor(Vector3 Location, bool Click = false)
		{
			if (_globals.OverlayHandle != IntPtr.Zero)
			{
				Vector2 vector = W2S.Convert(Location);
				Tools.CursorPosition cursorPosition = new Tools.CursorPosition((int)vector.X, (int)vector.Y);
				Tools.ClientToScreen(_globals.OverlayHandle, ref cursorPosition);
				Point position = Cursor.Position;
				Tools.SetCursorPos(cursorPosition.X, cursorPosition.Y);
				if (Click)
				{
					Key.MouseClick("LeftButton");
					Tools.SetCursorPos(position.X, position.Y);
				}
			}
		}

		// Token: 0x0600013C RID: 316
		[DllImport("User32.Dll")]
		public static extern long SetCursorPos(int X, int Y);

		// Token: 0x0600013D RID: 317
		[DllImport("User32.Dll")]
		public static extern bool ClientToScreen(IntPtr Handle, ref Tools.CursorPosition Position);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0066CE6C File Offset: 0x0066B06C
		public static int[] CursorToClient
		{
			get
			{
				int[] array = new int[]
				{
					-1,
					-1
				};
				if (_globals.processHandle != IntPtr.Zero)
				{
					Point position = Cursor.Position;
					int[] dimensions = Window.Dimensions;
					array[0] = position.X - dimensions[0];
					array[1] = position.Y - dimensions[1];
				}
				return array;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0066CEC4 File Offset: 0x0066B0C4
		public static bool MouseIsPressed(string Which)
		{
			bool flag = (System.Windows.Forms.Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left;
			bool flag2 = (System.Windows.Forms.Control.MouseButtons & MouseButtons.Right) == MouseButtons.Right;
			if (Which == "LeftRight")
			{
				return Convert.ToBoolean(flag || flag2);
			}
			if (Which == "Left")
			{
				return flag;
			}
			return Which == "Right" && flag2;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0066CF2C File Offset: 0x0066B12C
		public static bool CtrlIsPressed
		{
			get
			{
				return (System.Windows.Forms.Control.ModifierKeys & Keys.Control) == Keys.Control;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0066CF4C File Offset: 0x0066B14C
		public static string CallURL(string URL, string User = "", string Pass = "", string Agent = "", Dictionary<string, string> Post = null)
		{
			string result = "";
			if (Post != null)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
				byte[] array = new byte[0];
				string text = "";
				foreach (KeyValuePair<string, string> keyValuePair in Post)
				{
					text = text + keyValuePair.Key + "=" + keyValuePair.Value;
				}
				array = Encoding.ASCII.GetBytes(text);
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/x-www-form-urlencoded";
				httpWebRequest.ContentLength = (long)array.Length;
				if (Agent.Length > 0)
				{
					httpWebRequest.UserAgent = Agent;
				}
				if (User.Length > 0 && Pass.Length > 0)
				{
					string str = Convert.ToBase64String(Encoding.UTF8.GetBytes(User + ":" + Pass));
					httpWebRequest.Headers.Add("Authorization", "Basic " + str);
				}
				try
				{
					using (Stream requestStream = httpWebRequest.GetRequestStream())
					{
						requestStream.Write(array, 0, array.Length);
					}
					return new StreamReader(((HttpWebResponse)httpWebRequest.GetResponse()).GetResponseStream()).ReadToEnd();
				}
				catch (Exception ex)
				{
					return ex.ToString();
				}
			}
			HttpWebRequest httpWebRequest2 = (HttpWebRequest)WebRequest.Create(URL);
			httpWebRequest2.ContentType = "text/html";
			if (Agent.Length > 0)
			{
				httpWebRequest2.UserAgent = Agent;
			}
			if (User.Length > 0 && Pass.Length > 0)
			{
				string str2 = Convert.ToBase64String(Encoding.UTF8.GetBytes(User + ":" + Pass));
				httpWebRequest2.Headers.Add("Authorization", "Basic " + str2);
			}
			try
			{
				using (Stream responseStream = httpWebRequest2.GetResponse().GetResponseStream())
				{
					using (StreamReader streamReader = new StreamReader(responseStream, Encoding.UTF8))
					{
						result = streamReader.ReadToEnd();
					}
				}
			}
			catch (Exception ex2)
			{
				result = ex2.ToString();
			}
			return result;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0066D1AC File Offset: 0x0066B3AC
		public static string CallURLUpload(string URL, string FilePath, string FileValueName, string ContentType, Dictionary<string, string> Post = null)
		{
			string result = "";
			if (File.Exists(FilePath))
			{
				string str = "---------------------------" + DateTime.Now.Ticks.ToString("x");
				byte[] bytes = Encoding.ASCII.GetBytes("\r\n--" + str + "\r\n");
				HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
				httpWebRequest.ContentType = "multipart/form-data; boundary=" + str;
				httpWebRequest.Method = "POST";
				httpWebRequest.KeepAlive = true;
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
				Stream requestStream = httpWebRequest.GetRequestStream();
				if (Post != null)
				{
					NameValueCollection nameValueCollection = new NameValueCollection();
					foreach (KeyValuePair<string, string> keyValuePair in Post)
					{
						nameValueCollection.Add(keyValuePair.Key, keyValuePair.Value);
					}
					string format = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
					foreach (object obj in nameValueCollection.Keys)
					{
						string text = (string)obj;
						requestStream.Write(bytes, 0, bytes.Length);
						string s = string.Format(format, text, nameValueCollection[text]);
						byte[] bytes2 = Encoding.UTF8.GetBytes(s);
						requestStream.Write(bytes2, 0, bytes2.Length);
					}
					requestStream.Write(bytes, 0, bytes.Length);
				}
				string s2 = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", FileValueName, FilePath, ContentType);
				byte[] bytes3 = Encoding.UTF8.GetBytes(s2);
				requestStream.Write(bytes3, 0, bytes3.Length);
				FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
				byte[] array = new byte[4096];
				int count;
				while ((count = fileStream.Read(array, 0, array.Length)) != 0)
				{
					requestStream.Write(array, 0, count);
				}
				fileStream.Close();
				byte[] bytes4 = Encoding.ASCII.GetBytes("\r\n--" + str + "--\r\n");
				requestStream.Write(bytes4, 0, bytes4.Length);
				requestStream.Close();
				WebResponse webResponse = null;
				try
				{
					webResponse = httpWebRequest.GetResponse();
					result = new StreamReader(webResponse.GetResponseStream()).ReadToEnd();
				}
				catch
				{
					if (webResponse != null)
					{
						webResponse.Close();
						webResponse = null;
					}
				}
				finally
				{
					httpWebRequest = null;
				}
			}
			return result;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0066D434 File Offset: 0x0066B634
		[return: Dynamic]
		public static dynamic RequestJson(string Mode)
		{
			object result = null;
			string text = REQ.Ath(Mode, "");
			if (text.Contains("{") && text.Contains(","))
			{
				result = JsonConvert.DeserializeObject(text);
			}
			return result;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0066D474 File Offset: 0x0066B674
		public static int FloatToInt(float Number = 0f, int DecimalPlaces = 1)
		{
			if (Number > 0f && DecimalPlaces > 0)
			{
				string text = "0.";
				for (int i = 0; i < DecimalPlaces; i++)
				{
					text += "0";
				}
				int result;
				try
				{
					return Convert.ToInt32(Number.ToString(text).Replace(",", ""));
				}
				catch
				{
					result = 0;
				}
				return result;
			}
			return 0;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0066D4E8 File Offset: 0x0066B6E8
		public static string NumberToPrice(object Number, string Separator = ".")
		{
			string text = "";
			string text2 = Number.ToString();
			if (text2.Length > 2)
			{
				char[] array = text2.ToCharArray();
				int num = array.Length - 2;
				for (int i = 0; i < num; i++)
				{
					text += array[i].ToString();
				}
				text += Separator;
				for (int j = num; j < array.Length; j++)
				{
					text += array[j].ToString();
				}
			}
			else
			{
				text = text2;
			}
			return text;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0066D570 File Offset: 0x0066B770
		public static bool IsNumber(string Data, int MinLength = 0, int MaxLength = 0, int Min = 0, int Max = 0)
		{
			int num;
			return int.TryParse(Data, out num) && (MinLength <= 0 || Data.Length >= MinLength) && (MaxLength <= 0 || Data.Length <= MaxLength) && (Min <= 0 || num >= Min) && (Max <= 0 || num <= Max);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0066D5C0 File Offset: 0x0066B7C0
		public static bool IsAlpha(string Data)
		{
			return Regex.IsMatch(Data, "^[a-zA-Z]+$");
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0066D5D8 File Offset: 0x0066B7D8
		public static bool IsAlphaNumeric(string Data)
		{
			return Regex.IsMatch(Data, "^[a-zA-Z0-9]+$");
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0066D5F0 File Offset: 0x0066B7F0
		public static bool IsAlphaNumericWithUnderscore(string Data)
		{
			return Regex.IsMatch(Data, "^[a-zA-Z0-9_]+$");
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0066D608 File Offset: 0x0066B808
		public static void CopyDirectory(string From, string To)
		{
			foreach (string text in Directory.GetDirectories(From))
			{
				string fileName = Path.GetFileName(text);
				if (!Directory.Exists(Path.Combine(To, fileName)))
				{
					Directory.CreateDirectory(Path.Combine(To, fileName));
				}
				Tools.CopyDirectory(text, Path.Combine(To, fileName));
			}
			foreach (string text2 in Directory.GetFiles(From))
			{
				File.Copy(text2, Path.Combine(To, Path.GetFileName(text2)));
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0066D688 File Offset: 0x0066B888
		public static int CountProcess(string Mode = "", string ProcessName = "", bool Kill = false)
		{
			int num = 0;
			List<string> list = new List<string>
			{
				"Updater.exe",
				"JKA.exe"
			};
			List<string> list2 = new List<string>
			{
				"Updater.exe",
				"JKA.exe",
				"Jack.exe",
				_globals.JackExe
			};
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT ProcessId, ExecutablePath, CommandLine FROM Win32_Process"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (var <>f__AnonymousType in from process in Process.GetProcesses()
					join managementObject in managementObjectCollection.Cast<ManagementObject>() on process.Id equals (int)((uint)managementObject["ProcessId"])
					select new
					{
						Process = process,
						Name = process.ProcessName,
						ID = process.Id,
						Path = (string)managementObject["ExecutablePath"]
					})
					{
						if (<>f__AnonymousType.Path != null && <>f__AnonymousType.Path.Length != 0 && <>f__AnonymousType.ID != 0 && <>f__AnonymousType.Name.Length != 0 && <>f__AnonymousType.Path.Contains(<>f__AnonymousType.Name + ".exe"))
						{
							string str = <>f__AnonymousType.Path.Replace("\\" + <>f__AnonymousType.Name + ".exe", "") + "\\";
							if (!(Mode == "Jack"))
							{
								if (!(Mode == "JKA"))
								{
									if (ProcessName.Length > 0)
									{
										<>f__AnonymousType.Name + ".exe" == ProcessName;
									}
								}
								else if (File.Exists(str + "Ath.dll") && File.Exists(str + "Pathfinder.dll") && !list2.Contains(<>f__AnonymousType.Name + ".exe") && new FileInfo(<>f__AnonymousType.Path).Length <= 5242880L)
								{
									num++;
									if (Kill)
									{
										Tools.KillProcessAndChilds(<>f__AnonymousType.ID);
									}
								}
							}
							else if (File.Exists(str + "Ath.dll") && File.Exists(str + "Pathfinder.dll") && !list.Contains(<>f__AnonymousType.Name + ".exe") && new FileInfo(<>f__AnonymousType.Path).Length >= 5242880L)
							{
								num++;
								if (Kill)
								{
									Tools.KillProcessAndChilds(<>f__AnonymousType.ID);
								}
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0066D9B8 File Offset: 0x0066BBB8
		public static void KillProcessAndChilds(int PID)
		{
			if (PID == 0)
			{
				return;
			}
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + PID.ToString()).Get())
			{
				Tools.KillProcessAndChilds(Convert.ToInt32(((ManagementObject)managementBaseObject)["ProcessID"]));
			}
			try
			{
				Process.GetProcessById(PID).Kill();
			}
			catch
			{
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0066DA50 File Offset: 0x0066BC50
		public static string GetParentOrLastDirectory(string DirPath, bool GetLastDir = false)
		{
			if (DirPath != "" && DirPath.Contains("\\"))
			{
				if (!DirPath.EndsWith("\\"))
				{
					DirPath += "\\";
				}
				if (GetLastDir)
				{
					DirPath += "n";
				}
				return new DirectoryInfo(DirPath).Parent.Name;
			}
			return "";
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0066DAB8 File Offset: 0x0066BCB8
		public static Bitmap Base64ToBitmap(string Base64Image)
		{
			Bitmap result = null;
			try
			{
				MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(Base64Image));
				result = new Bitmap(memoryStream);
				memoryStream.Close();
				memoryStream.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return result;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0066DB04 File Offset: 0x0066BD04
		public static byte[] ResourceToByteArray(Bitmap ResourcesImage)
		{
			byte[] result;
			try
			{
				result = (byte[])new ImageConverter().ConvertTo(ResourcesImage, typeof(byte[]));
			}
			catch
			{
				result = new byte[0];
			}
			return result;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0066DB4C File Offset: 0x0066BD4C
		public static void LinkToModule()
		{
			if (_globals.LCS.d803.Length > 0)
			{
				Process.Start(_globals.LCS.d803);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0066DB7C File Offset: 0x0066BD7C
		public static string ConvertToHex(int Index)
		{
			return "0x" + Index.ToString("X");
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0066DBA0 File Offset: 0x0066BDA0
		public static void CustomMessageBox(string Title, string Text, string Button1Text, string Button2Text, string ParentFormLocation = "frmMain", bool AsDialog = true)
		{
			frmMessageBox.Dialog["Title"] = Title;
			frmMessageBox.Dialog["Text"] = Text;
			frmMessageBox.Dialog["Button1"] = Button1Text;
			frmMessageBox.Dialog["Button2"] = Button2Text;
			Tools.OpenForm("frmMessageBox", AsDialog, ParentFormLocation, Array.Empty<object>());
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0066DC00 File Offset: 0x0066BE00
		public static string GetBetween(string Content, string StartString, string EndString)
		{
			if (Content.Contains(StartString) && Content.Contains(EndString))
			{
				int num = Content.IndexOf(StartString, 0) + StartString.Length;
				int num2 = Content.IndexOf(EndString, num);
				return Content.Substring(num, num2 - num);
			}
			return "";
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0066DC4C File Offset: 0x0066BE4C
		public static bool SettingExists(string SettingName)
		{
			return Jack.Properties.Settings.Default.Properties.Cast<SettingsProperty>().Any((SettingsProperty prop) => prop.Name == SettingName);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0066DC88 File Offset: 0x0066BE88
		// Note: this type is marked as 'beforefieldinit'.
		static Tools()
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["LimeGreen"] = "#32CD32";
			dictionary["DeepSkyBlue"] = "#00bfff";
			dictionary["Orange"] = "#ffa500";
			dictionary["Red"] = "#ff0000";
			Tools.HexColors = dictionary;
			Tools.Date = "";
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0066DD1C File Offset: 0x0066BF1C
		[CompilerGenerated]
		internal static void smethod_0(Form Form)
		{
			if (Form.Visible)
			{
				Form.Visible = false;
			}
			Form.Visible = true;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0066DD40 File Offset: 0x0066BF40
		[CompilerGenerated]
		internal static void smethod_1(Form Form)
		{
			if (Form.Visible && !Tools.InvokeMethod(Form.Name, "HideForm", null, false))
			{
				Form.Visible = false;
			}
		}

		// Token: 0x04000064 RID: 100
		private static Dictionary<int, string[]> ConsoleLog = new Dictionary<int, string[]>();

		// Token: 0x04000065 RID: 101
		public static List<string[]> Log = new List<string[]>();

		// Token: 0x04000066 RID: 102
		private static List<string> FullLog = new List<string>();

		// Token: 0x04000067 RID: 103
		private static object _lockFullLog = new object();

		// Token: 0x04000068 RID: 104
		public static Random Rnd = new Random();

		// Token: 0x04000069 RID: 105
		private static Dictionary<string, string> HexColors;

		// Token: 0x0400006A RID: 106
		private static string Date;

		// Token: 0x02000015 RID: 21
		public struct CursorPosition
		{
			// Token: 0x060001FB RID: 507 RVA: 0x0066DD70 File Offset: 0x0066BF70
			public CursorPosition(int x, int y)
			{
				this.X = x;
				this.Y = y;
			}

			// Token: 0x0400006B RID: 107
			public int X;

			// Token: 0x0400006C RID: 108
			public int Y;
		}
	}
}
