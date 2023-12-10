using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.ATH;
using Jack.Core;
using Jack.Engine;
using Jack.Forms;
using Jack.Properties;

namespace Jack
{
	// Token: 0x0200000E RID: 14
	public partial class frmMain : Form
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00665D68 File Offset: 0x00663F68
		public frmMain()
		{
			Initialize.Team();
			Initialize.GenerateHWID();
			Initialize.CreateFilesAndFolders();
			Initialize.MemFonts();
			Initialize.DeleteUnnecessaryFiles();
			Initialize.CheckFirstStart();
			this.LoadLicense();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00665DAC File Offset: 0x00663FAC
		private void LoadLicense()
		{
			bool flag = true;
			bool flag2 = false;
			while (!flag2)
			{
				flag2 = Initialize.CheckServerResponseData();
			}
			if (flag2)
			{
				flag2 = Initialize.StartAgent();
			}
			if (flag2)
			{
				flag = false;
				Initialize.SetJackDataBeforeSplash();
				Initialize.CheckForUpdates(true);
				Addon.CheckOnStart();
				Initialize.CheckForPathfinderFiles("");
				Initialize.SplashScreen(true, null);
				Initialize.SetJackDataWhileSplash();
				Initialize.HotKeys();
				this.LoadApplication();
			}
			if (!flag)
			{
				return;
			}
			Environment.Exit(0);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00665E14 File Offset: 0x00664014
		private void LoadApplication()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			Initialize.PreLoadForms();
			this.TrayMenu();
			_globals.MyHandle = this.method_0();
			if (!(Initialize.Lists & Initialize.Dictionaries))
			{
				MessageBox.Show("Some files could not be initializied.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			Initialize.Threading();
			new Thread(new ThreadStart(frmMainOverlay.OverlayMenu))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00665E8C File Offset: 0x0066408C
		private void frmMain_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			if (!_globals.ModuleGather)
			{
				this.btnModuleGather.Image = Resources.btn_module_gather_disabled;
			}
			if (!_globals.ModuleDungeon)
			{
				this.btnModuleDungeon.Image = Resources.btn_module_dungeon_disabled;
			}
			if (_globals.ModuleMultiSession > 1)
			{
				this.btnAttach.Visible = !Jack.Core.Settings.JackAutoDetectWindow;
			}
			else
			{
				this.btnAttach.Visible = false;
				this.btnModuleSession.Image = Resources.btn_module_session_disabled;
			}
			if (!_globals.ModuleNotifications)
			{
				this.btnModuleNotifications.Image = Resources.btn_module_notify_disabled;
			}
			this.SetWindowPosition();
			this.SetCenter();
			Initialize.LoadProfileAndRotation();
			Initialize.Keybinds();
			this.LoadFormToPanel("frmMainProfiles", Array.Empty<object>());
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00665F50 File Offset: 0x00664150
		private void SetWindowPosition()
		{
			if (Jack.Core.Settings.WindowMainLocation.X != 0 && Jack.Core.Settings.WindowMainLocation.Y != 0)
			{
				base.Location = Jack.Core.Settings.WindowMainLocation;
			}
			if (Jack.Core.Settings.WindowMainSize.Width != 0 && Jack.Core.Settings.WindowMainSize.Height != 0)
			{
				base.Width = Jack.Core.Settings.WindowMainSize.Width;
				base.Height = Jack.Core.Settings.WindowMainSize.Height;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00665FB8 File Offset: 0x006641B8
		private void frmMain_Shown(object sender, EventArgs e)
		{
			Initialize.SplashScreen(false, this);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00665FCC File Offset: 0x006641CC
		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.ResetWindows && base.WindowState != FormWindowState.Minimized)
			{
				Jack.Core.Settings.WindowMainLocation = base.Location;
				Jack.Core.Settings.WindowMainSize = new Size(base.Width, base.Height);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0066600C File Offset: 0x0066420C
		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Jack.Core.Settings.Save();
			Json.SaveKeybinds();
			Tools.SaveLog();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00666028 File Offset: 0x00664228
		private void btnStart_Click(object sender, EventArgs e)
		{
			if (_globals.Start)
			{
				EventManager.ForcingStartWhileInBattleground = false;
			}
			else if (_globals.Ready && _globals.IsInBattleground && EventManager.LoadProfileAfterBattleground)
			{
				Tools.Console("Restarting Battleground Monitor...", "", "richConsole", "frmMain", true);
				EventManager.ForcingStartWhileInBattleground = true;
				new Thread(new ThreadStart(EventManager.ForcingStartInBattleground))
				{
					IsBackground = true
				}.Start();
			}
			frmMain.Start();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0066609C File Offset: 0x0066429C
		public static void Start()
		{
			if (_globals.Start)
			{
				frmMain.Stop();
				Tools.Console("Jack stopped.", "", "richConsole", "frmMain", true);
				return;
			}
			if (!_globals.Ready)
			{
				Tools.Console("Please login and enter the World first.", "Orange", "richConsole", "frmMain", true);
				return;
			}
			if (_globals.Waypoints.Count == 0 || _globals.ProfileSettings.Count == 0)
			{
				Tools.Console("Please select a Profile first or create a new one.", "Orange", "richConsole", "frmMain", true);
				return;
			}
			if (_globals.Rotation.Count == 0 || _globals.RotationSettings.Count == 0)
			{
				Tools.Console("Please select a Rotation first or create a new one.", "Orange", "richConsole", "frmMain", true);
				return;
			}
			if (!MDL.CheckDungeon)
			{
				Tools.Console("To play with Jack in Dungeons, you need the Dungeon Module.", "Orange", "richConsole", "frmMain", true);
				return;
			}
			if (Jack.Core.Settings.AddonCheckOnStart && !Addon.IsReady(true, true, true, true))
			{
				return;
			}
			Tools.StartStop("Start");
			Tools.Control("", "btnAddonOptionsApply", "frmMainAddon", false, false, false, false, 0);
			if (SpellRotation.RotationSettings.Class != "" && SpellRotation.RotationSettings.Class != ObjectManager.Me.Class.ToString())
			{
				Tools.Console("The loaded rotation does not match your class.", "Red", "richConsole", "frmMain", true);
			}
			Jack.Core.Settings.Save();
			_globals.Start = true;
			new Thread(new ThreadStart(Walk.Go))
			{
				IsBackground = true
			}.Start();
			Tools.Console("Jack started.", "Green", "richConsole", "frmMain", true);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0066625C File Offset: 0x0066445C
		public static void Stop()
		{
			_globals.Start = false;
			AntiStuck.Stuck = false;
			AntiStuck.StuckCounter = 0;
			Tools.StartStop("Stop");
			Tools.Control("", "btnAddonOptionsApply", "frmMainAddon", true, false, false, false, 0);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x006662A0 File Offset: 0x006644A0
		private void richConsole_TextChanged(object sender, EventArgs e)
		{
			this.richConsole.SelectionStart = this.richConsole.Text.Length;
			this.richConsole.ScrollToCaret();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x006662D4 File Offset: 0x006644D4
		private void richConsole_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			frmMainSettings.OpenLogByConsole();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x006662E8 File Offset: 0x006644E8
		private void LoadFormToPanel(string FormName, params object[] Args)
		{
			Form form = Tools.GetForm(FormName);
			if (form != null && (form.Name != this.OpenForm || form.Name == "frmMainMessages" || form.Name == "frmMainModules"))
			{
				if (this.OpenForm.Length > 0)
				{
					Tools.GetForm(this.OpenForm).Visible = false;
					if (this.OpenForm != "frmMainModules")
					{
						Jack.Core.Settings.Save();
					}
				}
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

		// Token: 0x06000074 RID: 116 RVA: 0x006663B8 File Offset: 0x006645B8
		public void LoadFormToPanelExtern(string RadioButtonName)
		{
			frmMain.<>c__DisplayClass16_0 CS$<>8__locals1 = new frmMain.<>c__DisplayClass16_0();
			Form form = Application.OpenForms["frmMain"];
			CS$<>8__locals1.Control = null;
			if (form == null)
			{
				return;
			}
			try
			{
				Control[] array = form.Controls.Find(RadioButtonName, true);
				if (array.Length != 0)
				{
					CS$<>8__locals1.Control = array[0];
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
			}
			catch
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0066644C File Offset: 0x0066464C
		private void radioMenuProfiles_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmMainProfiles", Array.Empty<object>());
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0066646C File Offset: 0x0066466C
		private void radioMenuRotations_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmMainRotations", Array.Empty<object>());
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0066648C File Offset: 0x0066468C
		private void radioMenuKeybinds_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmMainKeybinds", Array.Empty<object>());
		}

		// Token: 0x06000078 RID: 120 RVA: 0x006664AC File Offset: 0x006646AC
		private void radioMenuOverlay_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmMainOverlay", Array.Empty<object>());
		}

		// Token: 0x06000079 RID: 121 RVA: 0x006664CC File Offset: 0x006646CC
		private void radioMenuAddon_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmMainAddon", Array.Empty<object>());
		}

		// Token: 0x0600007A RID: 122 RVA: 0x006664EC File Offset: 0x006646EC
		private void radioMenuSettings_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmMainSettings", Array.Empty<object>());
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0066650C File Offset: 0x0066470C
		private void btnAccount_Click(object sender, EventArgs e)
		{
			if (_globals.IsTeam)
			{
				this.panelTeam.Location = new Point(this.radioMenuAccount.Location.X, this.radioMenuAccount.Location.Y + this.radioMenuAccount.Height);
				if (!this.panelTeam.Visible)
				{
					this.btnTeamReloadCOS.Enabled = (File.Exists(_globals.JackData + "\\cos.jk") || File.Exists(_globals.JackData + "\\cosAlways.jk"));
					this.btnTeamReloadCOS.Visible = this.btnTeamReloadCOS.Enabled;
					int num = 2;
					using (IEnumerator enumerator = this.panelTeam.Controls.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (((Guna2Button)enumerator.Current).Enabled)
							{
								num += 30;
							}
						}
					}
					this.panelTeam.Height = num;
				}
				this.panelTeam.Visible = !this.panelTeam.Visible;
				return;
			}
			this.LoadFormToPanel("frmMainAccount", Array.Empty<object>());
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00666654 File Offset: 0x00664854
		private void btnTeamAccount_Click(object sender, EventArgs e)
		{
			this.panelTeam.Visible = false;
			this.LoadFormToPanel("frmMainAccount", Array.Empty<object>());
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00666680 File Offset: 0x00664880
		private void btnTeamTools_Click(object sender, EventArgs e)
		{
			this.panelTeam.Visible = false;
			if (_globals.IsTeam)
			{
				Tools.OpenForm("frmTeam", false, "frmMain", Array.Empty<object>());
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x006666B8 File Offset: 0x006648B8
		private void btnTeamStore_Click(object sender, EventArgs e)
		{
			this.panelTeam.Visible = false;
			if (_globals.IsTeam)
			{
				Tools.OpenForm("frmTeamStore", false, "frmMain", Array.Empty<object>());
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x006666F0 File Offset: 0x006648F0
		private void btnTeamReloadCOS_Click(object sender, EventArgs e)
		{
			this.panelTeam.Visible = false;
			if (!_globals.IsTeam)
			{
				return;
			}
			if (_globals.GameOpen)
			{
				bool jackAutoDetectWindow = Jack.Core.Settings.JackAutoDetectWindow;
				if (jackAutoDetectWindow)
				{
					Jack.Core.Settings.JackAutoDetectWindow = false;
					Tools.Console("Auto Detect Window temporary disabled.", "", "richConsole", "frmMain", true);
				}
				GameClient.Reset(true);
				if (_globals.processID > 0)
				{
					Window.Attach(_globals.processID);
				}
				Tools.Console("Custom Offsets reloaded successful.", "Green", "richConsole", "frmMain", true);
				if (jackAutoDetectWindow)
				{
					new Thread(new ThreadStart(frmMain.smethod_0))
					{
						IsBackground = true
					}.Start();
				}
				return;
			}
			Tools.Console("No Reload necessary. Just start the game.", "Orange", "richConsole", "frmMain", true);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x006667AC File Offset: 0x006649AC
		private void btnTeamClose_Click(object sender, EventArgs e)
		{
			this.panelTeam.Visible = false;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x006667C8 File Offset: 0x006649C8
		private void btnStore_Click(object sender, EventArgs e)
		{
			Tools.OpenForm("frmStore", false, "frmMain", Array.Empty<object>());
		}

		// Token: 0x06000082 RID: 130 RVA: 0x006667EC File Offset: 0x006649EC
		private void btnMessages_Click(object sender, EventArgs e)
		{
			this.LoadFormToPanel("frmMainMessages", Array.Empty<object>());
			this.RadioButtons_CheckedChanged(sender, e);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00666814 File Offset: 0x00664A14
		private void RadioButtons_CheckedChanged(object sender, EventArgs e)
		{
			Guna2Button CurrentButton = null;
			if (sender.GetType() == typeof(Guna2Button))
			{
				CurrentButton = (Guna2Button)sender;
			}
			if (CurrentButton == null || CurrentButton.Checked)
			{
				foreach (Guna2Button guna2Button in from Button in new Control[]
				{
					this.panelAccount,
					this.panelActionBar,
					this.panelMainMenuButtons
				}.SelectMany((Control Ctrl) => Ctrl.Controls.OfType<Guna2Button>())
				where Button != CurrentButton
				select Button)
				{
					guna2Button.Checked = false;
				}
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x006668F8 File Offset: 0x00664AF8
		private void btnModuleGather_Click(object sender, EventArgs e)
		{
			frmMainModules.Module = "Gather";
			this.LoadFormToPanel("frmMainModules", Array.Empty<object>());
			this.RadioButtons_CheckedChanged(sender, e);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00666928 File Offset: 0x00664B28
		private void btnModuleDungeon_Click(object sender, EventArgs e)
		{
			frmMainModules.Module = "Dungeon";
			this.LoadFormToPanel("frmMainModules", Array.Empty<object>());
			this.RadioButtons_CheckedChanged(sender, e);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00666958 File Offset: 0x00664B58
		private void btnModuleSession_Click(object sender, EventArgs e)
		{
			frmMainModules.Module = "Session";
			this.LoadFormToPanel("frmMainModules", Array.Empty<object>());
			this.RadioButtons_CheckedChanged(sender, e);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00666988 File Offset: 0x00664B88
		private void btnModuleNotifications_Click(object sender, EventArgs e)
		{
			frmMainModules.Module = "Notifications";
			this.LoadFormToPanel("frmMainModules", Array.Empty<object>());
			this.RadioButtons_CheckedChanged(sender, e);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x006669B8 File Offset: 0x00664BB8
		private void btnAttach_Click(object sender, EventArgs e)
		{
			if (_globals.ModuleMultiSession > 1)
			{
				Tools.Console("Choose the Game Window you want to attach...", "Orange", "richConsole", "frmMain", true);
				new Thread(delegate()
				{
					Window.Attach(0);
				})
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00666A18 File Offset: 0x00664C18
		private void SetCenter()
		{
			this.panelMainMenuButtons.Left = (base.ClientSize.Width - this.panelMainMenuButtons.Width) / 2;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00666A4C File Offset: 0x00664C4C
		private void frmMain_SizeChanged(object sender, EventArgs e)
		{
			this.SetCenter();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00666A60 File Offset: 0x00664C60
		private void imgSizer_MouseDown(object sender, MouseEventArgs e)
		{
			CustomUI.SizerMouseDown(sender, e, this);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00666A78 File Offset: 0x00664C78
		private void imgSizer_MouseMove(object sender, MouseEventArgs e)
		{
			CustomUI.SizerMouseMove(sender, e, this);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00666A90 File Offset: 0x00664C90
		private void imgSizer_MouseUp(object sender, MouseEventArgs e)
		{
			CustomUI.SizerMouseUp(sender, e);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00666AA4 File Offset: 0x00664CA4
		private void lblTitle_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Clicks != 2)
			{
				CustomUI.MoverMouseDown(sender, e, this);
				return;
			}
			if (base.WindowState != FormWindowState.Normal)
			{
				base.WindowState = FormWindowState.Normal;
				return;
			}
			base.WindowState = FormWindowState.Maximized;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00666ADC File Offset: 0x00664CDC
		private void imgMinimize_Click(object sender, EventArgs e)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00666B00 File Offset: 0x00664D00
		private void imgClose_Click(object sender, EventArgs e)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
			if (Jack.Core.Settings.JackTray)
			{
				this.trayIcon.Visible = true;
				base.Hide();
				return;
			}
			base.Close();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00666B3C File Offset: 0x00664D3C
		private void TrayMenu()
		{
			this.trayIcon.ContextMenuStrip = new ContextMenuStrip();
			this.trayIcon.ContextMenuStrip.Items.Add("Start", null, new EventHandler(this.TrayMenu_Start));
			this.trayIcon.ContextMenuStrip.Items.Add("Stop", null, new EventHandler(this.TrayMenu_Stop));
			this.trayIcon.ContextMenuStrip.Items.Add("-");
			this.trayIcon.ContextMenuStrip.Items.Add("Profile Store", null, new EventHandler(this.TrayMenu_ProfileStore));
			this.trayIcon.ContextMenuStrip.Items.Add("-");
			this.trayIcon.ContextMenuStrip.Items.Add("Reset Window Positions", null, new EventHandler(this.TrayMenu_ResetWindows));
			this.trayIcon.ContextMenuStrip.Items.Add("-");
			this.trayIcon.ContextMenuStrip.Items.Add("Exit", null, new EventHandler(this.TrayMenu_Close));
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00666C74 File Offset: 0x00664E74
		private void TrayMenu_Start(object sender, EventArgs e)
		{
			frmMain.Start();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00666C88 File Offset: 0x00664E88
		private void TrayMenu_Stop(object sender, EventArgs e)
		{
			frmMain.Stop();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x006667C8 File Offset: 0x006649C8
		private void TrayMenu_ProfileStore(object sender, EventArgs e)
		{
			Tools.OpenForm("frmStore", false, "frmMain", Array.Empty<object>());
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00666C9C File Offset: 0x00664E9C
		private void TrayMenu_ResetWindows(object sender, EventArgs e)
		{
			if (MessageBox.Show("This resets all window positions and sizes to their default settings.\r\nDo you want to continue?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.ResetWindows = true;
				Jack.Core.Settings.WindowMainLocation = new Point(0, 0);
				Jack.Core.Settings.WindowMainSize = new Size(0, 0);
				Jack.Core.Settings.WindowProfileLocation = new Point(0, 0);
				Jack.Core.Settings.WindowProfileSize = new Size(0, 0);
				Jack.Core.Settings.WindowProfileEventSize = new Size(0, 0);
				Jack.Core.Settings.WindowRotationLocation = new Point(0, 0);
				Jack.Core.Settings.WindowRotationSize = new Size(0, 0);
				Jack.Core.Settings.WindowRotationConditionSize = new Size(0, 0);
				Jack.Core.Settings.WindowStoreLocation = new Point(0, 0);
				Jack.Core.Settings.WindowStoreSize = new Size(0, 0);
				Jack.Core.Settings.Save();
				if (MessageBox.Show("All window positions and sizes are reset.\r\n" + "Jack needs a restart to apply the changes.\r\n\r\nDo you want to close Jack now?", Tools.RandomString(15, false), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
				{
					base.Close();
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00666D70 File Offset: 0x00664F70
		private void TrayMenu_Close(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00666D84 File Offset: 0x00664F84
		private void trayIcon_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !base.Visible)
			{
				base.Show();
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00666DAC File Offset: 0x00664FAC
		private void lblCancel_Click(object sender, EventArgs e)
		{
			frmMain.Cancel = true;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00666DC0 File Offset: 0x00664FC0
		private void btnTest1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00666DD0 File Offset: 0x00664FD0
		private void btnTest2_Click(object sender, EventArgs e)
		{
			Tools.CloseForm("frmOverlayRecorder", Array.Empty<object>());
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00666DEC File Offset: 0x00664FEC
		private void Search()
		{
			new Thread(new ThreadStart(frmMain.smethod_1))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0066A394 File Offset: 0x00668594
		[CompilerGenerated]
		internal static void smethod_0()
		{
			string name = Tools.RandomTimer("AutoDetect");
			Jack.Engine.Timer.Set(name, 10000);
			while (!_globals.GameOpen && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(500);
			}
			Jack.Core.Settings.JackAutoDetectWindow = true;
			Tools.Console("Auto Detect Window enabled.", "", "richConsole", "frmMain", true);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0066A3F4 File Offset: 0x006685F4
		[CompilerGenerated]
		internal static void smethod_1()
		{
			frmMain.Cancel = false;
			Tools.ControlVisible("lblCancel", "frmMain", true);
			Tools.Console("Started...", "", "richConsole", "frmMain", true);
			frmMain.smethod_2();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0066A438 File Offset: 0x00668638
		[CompilerGenerated]
		internal static void smethod_2()
		{
			Tools.Console("Done.", "", "richConsole", "frmMain", true);
			Tools.ControlVisible("lblCancel", "frmMain", false);
			frmMain.Cancel = false;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0066A478 File Offset: 0x00668678
		IntPtr method_0()
		{
			return base.Handle;
		}

		// Token: 0x04000032 RID: 50
		private bool ResetWindows;

		// Token: 0x04000033 RID: 51
		private string OpenForm = "";

		// Token: 0x04000034 RID: 52
		public static bool Cancel;
	}
}
