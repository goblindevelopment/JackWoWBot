using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x0200006D RID: 109
	public partial class frmMainOverlay : Form
	{
		// Token: 0x06000999 RID: 2457 RVA: 0x00688CE8 File Offset: 0x00686EE8
		public frmMainOverlay()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00688D08 File Offset: 0x00686F08
		private void frmMainOverlay_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
			this.LoadControlsAndSettings();
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmMainOverlay_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void tabs_SelectedIndexChanged(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00688D44 File Offset: 0x00686F44
		private void frmMainOverlay_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00688D68 File Offset: 0x00686F68
		private void LoadControlsAndSettings()
		{
			this.NoCheck = true;
			this.checkOverlayGFXAntiAliasing.Checked = Jack.Core.Settings.OverlayGFXAntiAliasing;
			this.selectOverlayGFXFPS.SelectedIndex = this.selectOverlayGFXFPS.FindStringExact(Jack.Core.Settings.OverlayGFXFPS.ToString());
			this.checkOverlayWaypoints.Checked = Jack.Core.Settings.OverlayWaypoints;
			this.txtOverlayWaypointsDisplayRadius.Text = Jack.Core.Settings.OverlayWaypointsDisplayRadius.ToString();
			this.checkOverlayMenuConsole.Checked = Jack.Core.Settings.OverlayMenuConsole;
			this.checkOverlayMenuRecorder.Checked = Jack.Core.Settings.OverlayMenuRecorder;
			this.checkOverlayMenuStartStop.Checked = Jack.Core.Settings.OverlayMenuStartStop;
			this.checkOverlayESPObjectsHerbs.Checked = Jack.Core.Settings.OverlayESPObjectsHerbs;
			this.checkOverlayESPObjectsOres.Checked = Jack.Core.Settings.OverlayESPObjectsOres;
			this.checkOverlayESPObjectsSkinnables.Checked = Jack.Core.Settings.OverlayESPObjectsSkinnables;
			this.checkOverlayESPObjectsGatherableMobs.Checked = Jack.Core.Settings.OverlayESPObjectsGatherableMobs;
			this.checkOverlayESPObjectsChests.Checked = Jack.Core.Settings.OverlayESPObjectsChests;
			this.checkOverlayESPObjectsContainer.Checked = Jack.Core.Settings.OverlayESPObjectsContainer;
			this.checkOverlayESPObjectsFishingPools.Checked = Jack.Core.Settings.OverlayESPObjectsFishingPools;
			this.checkOverlayESPObjectsLoots.Checked = Jack.Core.Settings.OverlayESPObjectsLoots;
			this.selectOverlayESPObjectsDistance.SelectedIndex = this.selectOverlayESPObjectsDistance.FindStringExact(Jack.Core.Settings.OverlayESPObjectsDistance.ToString());
			this.checkOverlayESPUnits.Checked = Jack.Core.Settings.OverlayESPUnits;
			this.selectOverlayESPUnitsType.SelectedIndex = this.selectOverlayESPUnitsType.FindStringExact(Jack.Core.Settings.OverlayESPUnitsType);
			this.selectOverlayESPUnitsDistance.SelectedIndex = this.selectOverlayESPUnitsDistance.FindStringExact(Jack.Core.Settings.OverlayESPUnitsDistance.ToString());
			this.NoCheck = false;
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00688EF4 File Offset: 0x006870F4
		private void checkOverlayGFXAntiAliasing_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			frmMainOverlay.StopOverlay();
			Jack.Core.Settings.OverlayGFXAntiAliasing = this.checkOverlayGFXAntiAliasing.Checked;
			if (_globals.Ready)
			{
				frmMainOverlay.StartOverlay();
			}
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00688F2C File Offset: 0x0068712C
		private void selectOverlayGFXFPS_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			frmMainOverlay.StopOverlay();
			Jack.Core.Settings.OverlayGFXFPS = Convert.ToInt32(this.selectOverlayGFXFPS.SelectedItem);
			if (_globals.Ready)
			{
				frmMainOverlay.StartOverlay();
			}
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00688F68 File Offset: 0x00687168
		private void checkOverlayWaypoints_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			frmMainOverlay.EnableOverlayWaypoints(this.checkOverlayWaypoints.Checked);
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x00688F90 File Offset: 0x00687190
		public static void EnableOverlayWaypoints(bool Enable)
		{
			Jack.Core.Settings.OverlayWaypoints = Enable;
			_globals.ShowProfile = Jack.Core.Settings.OverlayWaypoints;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00688FB0 File Offset: 0x006871B0
		private void txtOverlayWaypointsDisplayRadius_TextChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			bool flag = false;
			int num;
			if (int.TryParse(this.txtOverlayWaypointsDisplayRadius.Text, out num) && num > 0 && num <= 9999)
			{
				Jack.Core.Settings.OverlayWaypointsDisplayRadius = num;
				flag = true;
			}
			if (!flag)
			{
				this.txtOverlayWaypointsDisplayRadius.Text = "100";
				this.txtOverlayWaypointsDisplayRadius.SelectAll();
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00689010 File Offset: 0x00687210
		private void checkOverlayMenuConsole_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayMenuConsole = this.checkOverlayMenuConsole.Checked;
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x00689038 File Offset: 0x00687238
		private void checkOverlayMenuRecorder_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayMenuRecorder = this.checkOverlayMenuRecorder.Checked;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00689060 File Offset: 0x00687260
		private void checkOverlayMenuStartStop_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayMenuStartStop = this.checkOverlayMenuStartStop.Checked;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00689088 File Offset: 0x00687288
		private void lblOverlayMenuConsoleDefault_Click(object sender, EventArgs e)
		{
			Jack.Core.Settings.OverlayMenuConsoleX = 0;
			Jack.Core.Settings.OverlayMenuConsoleY = 0;
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x006890A4 File Offset: 0x006872A4
		private void lblOverlayMenuRecorderDefault_Click(object sender, EventArgs e)
		{
			Jack.Core.Settings.OverlayMenuRecorderX = 0;
			Jack.Core.Settings.OverlayMenuRecorderY = 0;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x006890C0 File Offset: 0x006872C0
		private void lblOverlayMenuStartStopDefault_Click(object sender, EventArgs e)
		{
			Jack.Core.Settings.OverlayMenuStartStopX = 0;
			Jack.Core.Settings.OverlayMenuStartStopY = 0;
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x006890DC File Offset: 0x006872DC
		private void checkOverlayESPObjectsHerbs_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsHerbs = this.checkOverlayESPObjectsHerbs.Checked;
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00689104 File Offset: 0x00687304
		private void checkOverlayESPObjectsOres_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsOres = this.checkOverlayESPObjectsOres.Checked;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0068912C File Offset: 0x0068732C
		private void checkOverlayESPObjectsSkinnables_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsSkinnables = this.checkOverlayESPObjectsSkinnables.Checked;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00689154 File Offset: 0x00687354
		private void checkOverlayESPObjectsGatherableMobs_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsGatherableMobs = this.checkOverlayESPObjectsGatherableMobs.Checked;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0068917C File Offset: 0x0068737C
		private void checkOverlayESPObjectsLoots_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsLoots = this.checkOverlayESPObjectsLoots.Checked;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x006891A4 File Offset: 0x006873A4
		private void checkOverlayESPObjectsChests_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsChests = this.checkOverlayESPObjectsChests.Checked;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x006891CC File Offset: 0x006873CC
		private void checkOverlayESPObjectsContainer_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsContainer = this.checkOverlayESPObjectsContainer.Checked;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x006891F4 File Offset: 0x006873F4
		private void checkOverlayESPObjectsFishingPools_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsFishingPools = this.checkOverlayESPObjectsFishingPools.Checked;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0068921C File Offset: 0x0068741C
		private void selectOverlayESPObjectsDistance_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPObjectsDistance = Convert.ToInt32(this.selectOverlayESPObjectsDistance.SelectedItem);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00689248 File Offset: 0x00687448
		private void checkOverlayESPUnits_CheckedChanged(object sender, EventArgs e)
		{
			Jack.Core.Settings.OverlayESPUnits = this.checkOverlayESPUnits.Checked;
			CustomUI.EnableGroupBox(this.checkOverlayESPUnits.Checked, this.grpOverlayESPUnits, new string[]
			{
				"checkOverlayESPUnits"
			});
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0068928C File Offset: 0x0068748C
		private void selectOverlayESPUnitsType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPUnitsType = this.selectOverlayESPUnitsType.SelectedItem.ToString();
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x006892B8 File Offset: 0x006874B8
		private void selectOverlayESPUnitsDistance_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.NoCheck)
			{
				return;
			}
			Jack.Core.Settings.OverlayESPUnitsDistance = Convert.ToInt32(this.selectOverlayESPUnitsDistance.SelectedItem);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x006892E4 File Offset: 0x006874E4
		public static void StartOverlay()
		{
			if (!Overlay.Runs)
			{
				new Thread(new ThreadStart(Overlay.Start))
				{
					IsBackground = true
				}.Start();
			}
			if (!Overlay.AnimationRuns)
			{
				new Thread(new ThreadStart(Overlay.Animation))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0068933C File Offset: 0x0068753C
		public static void StopOverlay()
		{
			string name = Tools.RandomTimer("StopOverlay");
			Jack.Engine.Timer.Set(name, 3000);
			Overlay.Stop = true;
			while (Overlay.Runs && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(10);
			}
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00689380 File Offset: 0x00687580
		public static void OverlayMenu()
		{
			for (;;)
			{
				if (Overlay.MenuItem != null)
				{
					string a = (string)Overlay.MenuItem[0];
					int num = Overlay.MenuItem.Count<object>();
					if (num <= 1 || num <= 2)
					{
					}
					if (a == "Edit Profile...")
					{
						Overlay.MenuItem = null;
						if (Jack.Core.Settings.SelectedProfile != "")
						{
							frmMainProfiles.DisplayWaypointsAfterEditorLoaded = Jack.Core.Settings.OverlayWaypoints;
							frmMainOverlay.EnableOverlayWaypoints(false);
							frmProfile.Mode = "Edit";
							frmProfile.ProfileFolder = "";
							frmProfile.ProfileName = Jack.Core.Settings.SelectedProfile;
							Tools.ShowForm("frmProfile");
						}
					}
					else if (a == "Start")
					{
						Overlay.MenuItem = null;
						frmMain.Start();
					}
					else if (a == "Stop")
					{
						Overlay.MenuItem = null;
						frmMain.Stop();
					}
				}
				if (Overlay.ConsoleDrag)
				{
					if (Tools.CursorToClient[0] > 0 && Tools.CursorToClient[1] > 0)
					{
						Jack.Core.Settings.OverlayMenuConsoleX = Tools.CursorToClient[0];
						Jack.Core.Settings.OverlayMenuConsoleY = Tools.CursorToClient[1];
					}
				}
				else if (Overlay.RecorderDrag)
				{
					if (Tools.CursorToClient[0] > 0 && Tools.CursorToClient[1] > 0)
					{
						Jack.Core.Settings.OverlayMenuRecorderX = Tools.CursorToClient[0];
						Jack.Core.Settings.OverlayMenuRecorderY = Tools.CursorToClient[1];
					}
				}
				else if (Overlay.StartStopDrag && Tools.CursorToClient[0] > 0 && Tools.CursorToClient[1] > 0)
				{
					Jack.Core.Settings.OverlayMenuStartStopX = Tools.CursorToClient[0];
					Jack.Core.Settings.OverlayMenuStartStopY = Tools.CursorToClient[1];
				}
				Thread.Sleep(10);
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x006894F8 File Offset: 0x006876F8
		private void btnOverlayTooltip_Click(object sender, EventArgs e)
		{
			List<Tooltip> list = new List<Tooltip>();
			string tabControl = "tabs";
			string selectTabPage = "tabOverlay";
			Tooltip tooltip = new Tooltip();
			string title = "GFX";
			string text = "The overlay shows you in-game your waypoints, events and much more. ";
			text += "You can also interact with Jack directly via menus in-game.\r\n\r\n";
			text += "Here you can set graphical details for the overlay.";
			tooltip.Title = title;
			tooltip.Text = text;
			tooltip.FormName = base.Name;
			tooltip.TabControl = tabControl;
			tooltip.SelectTabPage = selectTabPage;
			tooltip.MarkControlName = "grpOverlayGFX";
			tooltip.PinTooltipToControl = true;
			Tooltip tooltip2 = new Tooltip();
			title = "Waypoints";
			text = "Set the range in which you want your waypoints to be displayed.";
			tooltip2.Title = title;
			tooltip2.Text = text;
			tooltip2.FormName = base.Name;
			tooltip2.TabControl = tabControl;
			tooltip2.SelectTabPage = selectTabPage;
			tooltip2.MarkControlName = "grpOverlayWaypoints";
			tooltip2.PinTooltipToControl = true;
			Tooltip tooltip3 = new Tooltip();
			title = "Menus";
			text = "Jack provides you with menus in-game. Here you can choose which ones you want to have displayed.";
			tooltip3.Title = title;
			tooltip3.Text = text;
			tooltip3.FormName = base.Name;
			tooltip3.TabControl = tabControl;
			tooltip3.SelectTabPage = selectTabPage;
			tooltip3.MarkControlName = "grpOverlayMenus";
			tooltip3.PinTooltipToControl = true;
			Tooltip tooltip4 = new Tooltip();
			title = "ESP: Objects";
			text = "The ESP shows you selected objects at maximum distance and also provides you ";
			text += "with further useful information about the objects.\r\n\r\n";
			text += "Set here which objects should be displayed.";
			tooltip4.Title = title;
			tooltip4.Text = text;
			tooltip4.FormName = base.Name;
			tooltip4.TabControl = tabControl;
			tooltip4.SelectTabPage = "tabESP";
			tooltip4.MarkControlName = "grpOverlayESPObjects";
			tooltip4.PinTooltipToControl = true;
			Tooltip tooltip5 = new Tooltip();
			title = "ESP: Units";
			text = "It is also possible to display different units. Whether NPC or player, friend or foe. ";
			text += "You get all the information at a glance.";
			tooltip5.Title = title;
			tooltip5.Text = text;
			tooltip5.FormName = base.Name;
			tooltip5.TabControl = tabControl;
			tooltip5.SelectTabPage = "tabESP";
			tooltip5.MarkControlName = "grpOverlayESPUnits";
			tooltip5.PinTooltipToControl = true;
			list.Add(tooltip);
			list.Add(tooltip2);
			list.Add(tooltip3);
			list.Add(tooltip4);
			list.Add(tooltip5);
			Tools.OpenTooltips(list);
		}

		// Token: 0x040002F6 RID: 758
		private bool NoCheck;
	}
}
