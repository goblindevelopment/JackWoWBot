using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Models;
using Newtonsoft.Json;

namespace Jack.Forms
{
	// Token: 0x0200005D RID: 93
	public partial class frmOverlayMenu : Form
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x00685908 File Offset: 0x00683B08
		public frmOverlayMenu()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00685928 File Offset: 0x00683B28
		private void frmOverlayMenu_Load(object sender, EventArgs e)
		{
			this.AttachToWindow();
			this.LoadMenu();
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00685944 File Offset: 0x00683B44
		private void AttachToWindow()
		{
			frmOverlayMenu.<>c__DisplayClass6_0 CS$<>8__locals1 = new frmOverlayMenu.<>c__DisplayClass6_0();
			int[] dimensions = Window.Dimensions;
			CS$<>8__locals1.CurrentPosX = dimensions[0] + 30;
			CS$<>8__locals1.CurrentPosY = dimensions[1] + 30;
			base.Location = new Point(CS$<>8__locals1.CurrentPosX, CS$<>8__locals1.CurrentPosY);
			CS$<>8__locals1.LatestWindowPosition = dimensions;
			CS$<>8__locals1.LatestPosX = CS$<>8__locals1.CurrentPosX;
			CS$<>8__locals1.LatestPosY = CS$<>8__locals1.CurrentPosY;
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x006859C8 File Offset: 0x00683BC8
		private void LoadMenu()
		{
			if (frmOverlayMenu.Mode.Length == 0 || !_globals.GameOpen)
			{
				return;
			}
			int[] dimensions = Window.Dimensions;
			if (dimensions.Count<int>() <= 2)
			{
				return;
			}
			int maxButtonsPerRow = dimensions[3] / 30 - 1;
			frmOverlayMenu.WindowWidth = base.Width;
			frmOverlayMenu.WindowHeight = 24;
			if (frmOverlayMenu.Mode == "ShowProfiles")
			{
				this.ShowProfiles(maxButtonsPerRow);
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00685A2C File Offset: 0x00683C2C
		private void ShowProfiles(int MaxButtonsPerRow)
		{
			if (frmOverlayMenu.Crd == default(Vector3))
			{
				return;
			}
			string currentDirectory = frmMainProfiles.CurrentDirectory;
			if (currentDirectory.Length == 0)
			{
				return;
			}
			IEnumerable<string> enumerable = Directory.EnumerateFiles(currentDirectory, "*.json");
			int num = enumerable.Count<string>();
			if (num == 0)
			{
				return;
			}
			if (num < MaxButtonsPerRow)
			{
				frmOverlayMenu.WindowHeight += num * 30;
			}
			else
			{
				frmOverlayMenu.WindowHeight += MaxButtonsPerRow * 30;
			}
			Guna2Panel guna2Panel = this.CreatePanel();
			int num2 = 1;
			int num3 = 0;
			foreach (string path in enumerable)
			{
				if (num3 == MaxButtonsPerRow)
				{
					num3 = 0;
					frmOverlayMenu.WindowWidth += base.Width;
					base.Controls.Add(guna2Panel);
					guna2Panel = this.CreatePanel();
				}
				string ProfileName = Path.GetFileName(path).Replace(".json", "");
				string FullProfilePath = Path.Combine(currentDirectory, ProfileName + ".json");
				Guna2Button guna2Button = this.CreateButton("btn" + num2.ToString(), ProfileName, "", false);
				guna2Panel.Controls.Add(guna2Button);
				guna2Button.MouseClick += delegate(object sender, MouseEventArgs e)
				{
					this.CreateLoadProfileEvent(sender, e, ProfileName, FullProfilePath);
				};
				guna2Button.MouseEnter += delegate(object sender, EventArgs e)
				{
					this.ShowProfilePreview(sender, e, FullProfilePath);
				};
				num2++;
				num3++;
			}
			this.CreateWindow();
			base.Controls.Add(guna2Panel);
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00685BD8 File Offset: 0x00683DD8
		private void CreateLoadProfileEvent(object sender, EventArgs e, string ProfileName, string ProfilePath)
		{
			string loadProfile = ProfileName;
			string parentOrLastDirectory = Tools.GetParentOrLastDirectory(ProfilePath, false);
			if (parentOrLastDirectory != "Profiles")
			{
				loadProfile = parentOrLastDirectory + "\\" + ProfileName;
			}
			int generateID = frmProfileEventSave.GenerateID;
			Events events = new Events();
			events.Vector3 = frmOverlayMenu.Crd;
			events.Name = "Load Profile: " + ProfileName;
			events.ID = generateID;
			events.Action = "Load Profile...";
			events.LoadProfile = loadProfile;
			object @lock = frmProfile._lock;
			lock (@lock)
			{
				frmProfile.RecordedEvents.Add(events);
			}
			int num = 0;
			using (List<Vector3>.Enumerator enumerator = frmProfile.RecordedWaypoints.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == frmOverlayMenu.Crd)
					{
						break;
					}
					num++;
				}
			}
			frmProfile.UpdateListWaypoints(num);
			if (MessageBox.Show("Do you want to set a condition?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				Tools.InvokeMethod("frmProfile", "SelectEvent", new object[]
				{
					generateID
				}, false);
				frmProfileEvent.Event = ObjectManager.GetEvent(generateID);
				if (frmProfileEvent.Event != null)
				{
					frmProfileEvent.Crd = frmOverlayMenu.Crd;
					frmProfileEvent.EventName = frmProfileEvent.Event.Name;
					frmProfileEvent.EventID = frmProfileEvent.Event.ID;
					frmProfileEvent.AutoSwitchTab = false;
					frmProfileEvent.Mode = "Edit";
					Tools.ShowForm("frmProfileEvent");
				}
			}
			base.Close();
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00685D74 File Offset: 0x00683F74
		private void ShowProfilePreview(object sender, EventArgs e, string ProfilePath)
		{
			if (!File.Exists(ProfilePath))
			{
				return;
			}
			_globals.ShowOverlayMenuProfilePreview = false;
			object lockWaypoints = frmOverlayMenu._lockWaypoints;
			lock (lockWaypoints)
			{
				_globals.WaypointsOverlayMenuPreview.Clear();
			}
			string text = File.ReadAllText(ProfilePath);
			if (!text.Contains("|#|"))
			{
				return;
			}
			string text2 = Regex.Split(text, "\\|\\#\\|")[0];
			if (text2.Length != 0)
			{
				lockWaypoints = frmOverlayMenu._lockWaypoints;
				lock (lockWaypoints)
				{
					_globals.WaypointsOverlayMenuPreview = JsonConvert.DeserializeObject<List<Vector3>>(text2);
				}
				_globals.ShowOverlayMenuProfilePreview = true;
				return;
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00666D70 File Offset: 0x00664F70
		private void CloseMenu(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00685E2C File Offset: 0x0068402C
		private void CreateWindow()
		{
			base.Size = new Size(frmOverlayMenu.WindowWidth, frmOverlayMenu.WindowHeight);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00685E50 File Offset: 0x00684050
		private Guna2Panel CreatePanel()
		{
			return new Guna2Panel
			{
				Anchor = (AnchorStyles.Top | AnchorStyles.Left),
				Location = new Point(frmOverlayMenu.WindowWidth - 240 - 12, 12),
				Size = new Size(240, frmOverlayMenu.WindowHeight),
				Name = "panelMenu"
			};
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00685EA4 File Offset: 0x006840A4
		private Label CreateTitle(string Name, string Text)
		{
			Label label = new Label();
			label.Font = new Font("Segoe UI", 9f);
			label.ForeColor = Color.White;
			label.Size = new Size(240, 28);
			label.Name = Name;
			label.Dock = DockStyle.Top;
			label.TextAlign = ContentAlignment.MiddleLeft;
			label.Text = Text;
			frmOverlayMenu.WindowHeight += label.Height;
			return label;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00685F18 File Offset: 0x00684118
		private Guna2Button CreateButton(string Name, string Text, string BGColor = "", bool CountIntoWindowHeight = true)
		{
			Color fillColor = Color.FromArgb(27, 33, 43);
			if (BGColor.Length > 0)
			{
				fillColor = Color.FromName(BGColor);
			}
			Guna2Button guna2Button = new Guna2Button();
			guna2Button.BorderColor = Color.Gray;
			guna2Button.BorderThickness = 1;
			guna2Button.DisabledState.BorderColor = Color.DimGray;
			guna2Button.DisabledState.CustomBorderColor = Color.DimGray;
			guna2Button.DisabledState.FillColor = Color.FromArgb(27, 33, 43);
			guna2Button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			guna2Button.FillColor = fillColor;
			guna2Button.Font = new Font("Segoe UI", 9f);
			guna2Button.ForeColor = Color.White;
			guna2Button.HoverState.BorderColor = Color.White;
			guna2Button.Size = new Size(240, 30);
			guna2Button.Dock = DockStyle.Top;
			guna2Button.Name = Name;
			guna2Button.Text = Text;
			if (CountIntoWindowHeight)
			{
				frmOverlayMenu.WindowHeight += guna2Button.Height;
			}
			return guna2Button;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00686024 File Offset: 0x00684224
		private void frmOverlayMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			_globals.ShowOverlayMenuProfilePreview = false;
			object lockWaypoints = frmOverlayMenu._lockWaypoints;
			lock (lockWaypoints)
			{
				_globals.WaypointsOverlayMenuPreview.Clear();
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00686070 File Offset: 0x00684270
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.ExStyle |= 8;
				return createParams;
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00686468 File Offset: 0x00684668
		[CompilerGenerated]
		internal static void smethod_0()
		{
			Form form = Application.OpenForms["frmOverlayMenu"];
			if (form != null)
			{
				if (form.InvokeRequired)
				{
					form.Invoke(new Action(delegate()
					{
						if (form.Visible)
						{
							form.Visible = false;
						}
					}));
					return;
				}
				if (form.Visible)
				{
					form.Visible = false;
				}
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x006864D8 File Offset: 0x006846D8
		[CompilerGenerated]
		internal static void smethod_1()
		{
			Form form = Application.OpenForms["frmOverlayMenu"];
			if (form != null)
			{
				if (form.InvokeRequired)
				{
					form.Invoke(new Action(delegate()
					{
						if (!form.Visible)
						{
							form.Visible = true;
						}
					}));
					return;
				}
				if (!form.Visible)
				{
					form.Visible = true;
				}
			}
		}

		// Token: 0x040002B3 RID: 691
		public static string Mode = "";

		// Token: 0x040002B4 RID: 692
		public static Vector3 Crd = default(Vector3);

		// Token: 0x040002B5 RID: 693
		public static bool MenuRuns = false;

		// Token: 0x040002B6 RID: 694
		public static bool MenuStop = false;

		// Token: 0x040002B7 RID: 695
		private static int WindowWidth = 0;

		// Token: 0x040002B8 RID: 696
		private static int WindowHeight = 0;

		// Token: 0x040002B9 RID: 697
		public static object _lockWaypoints = new object();
	}
}
