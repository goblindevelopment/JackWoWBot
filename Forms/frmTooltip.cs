using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000065 RID: 101
	public partial class frmTooltip : Form
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00687A64 File Offset: 0x00685C64
		public frmTooltip()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00687A84 File Offset: 0x00685C84
		private void frmTutorial_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "Tutorial", false, false, true, true, false, false);
			frmTooltip.CurrentTooltip = null;
			this.LoadTooltip();
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00687AB0 File Offset: 0x00685CB0
		private void LoadTooltip()
		{
			new Thread(new ThreadStart(this.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00687ADC File Offset: 0x00685CDC
		private void SetPosition()
		{
			Form form = Application.OpenForms[frmTooltip.CurrentTooltip.FormName];
			if (form != null)
			{
				Point Position = form.Location;
				Size size = form.Size;
				Form ThisForm = Application.OpenForms["frmTooltip"];
				ThisForm.Invoke(new Action(delegate()
				{
					ThisForm.Location = new Point(Position.X - ThisForm.Width - 25, Position.Y);
				}));
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00687B48 File Offset: 0x00685D48
		public void SetCustomSize()
		{
			int AddHeight = 0;
			try
			{
				using (Graphics graphics = base.CreateGraphics())
				{
					AddHeight = (int)Math.Ceiling((double)graphics.MeasureString(this.lblTooltipText.Text, this.lblTooltipText.Font, this.lblTooltipText.Width).Height) - this.lblTooltipText.Height;
				}
				Form ThisForm = Application.OpenForms["frmTooltip"];
				ThisForm.Invoke(new Action(delegate()
				{
					ThisForm.Height += AddHeight;
				}));
			}
			catch
			{
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00687C0C File Offset: 0x00685E0C
		private void MarkControl(bool ResetToDefault = false)
		{
			Color MarkColor = Color.FromArgb(148, 114, 31);
			Control Control = null;
			Form form = Application.OpenForms[frmTooltip.CurrentTooltip.FormName];
			if (form != null)
			{
				if (!ResetToDefault && frmTooltip.CurrentTooltip.TabControl.Length > 0)
				{
					Control[] array = form.Controls.Find(frmTooltip.CurrentTooltip.TabControl, true);
					if (array.Length != 0)
					{
						Control control = array[0];
						Guna2TabControl TabControl = control as Guna2TabControl;
						if (TabControl != null)
						{
							TabControl.Invoke(new Action(delegate()
							{
								TabControl.SelectedTab = TabControl.TabPages[frmTooltip.CurrentTooltip.SelectTabPage];
							}));
						}
					}
				}
				try
				{
					Control[] array2 = form.Controls.Find(frmTooltip.CurrentTooltip.MarkControlName, true);
					if (array2.Length != 0)
					{
						Control = array2[0];
					}
				}
				catch
				{
				}
			}
			if (Control != null)
			{
				if (!ResetToDefault && frmTooltip.CurrentTooltip.PinTooltipToControl)
				{
					Form ThisForm = Application.OpenForms["frmTooltip"];
					ThisForm.Invoke(new Action(delegate()
					{
						Point point = Control.PointToScreen(Point.Empty);
						ThisForm.Location = new Point(point.X - ThisForm.Width - 20, point.Y - ThisForm.Height / 2 + Control.Height / 2);
					}));
				}
				if (!(Control.GetType() == typeof(Label)))
				{
					if (!(Control.GetType() == typeof(Guna2TextBox)))
					{
						if (!(Control.GetType() == typeof(Guna2Panel)))
						{
							if (Control.GetType() == typeof(Guna2GroupBox))
							{
								Guna2GroupBox guna2GroupBox = Control as Guna2GroupBox;
								if (ResetToDefault)
								{
									guna2GroupBox.BorderColor = frmTooltip.CurrentTooltip.DefaultColor;
									guna2GroupBox.CustomBorderColor = frmTooltip.CurrentTooltip.DefaultColor;
									return;
								}
								frmTooltip.CurrentTooltip.DefaultColor = guna2GroupBox.BorderColor;
								guna2GroupBox.BorderColor = MarkColor;
								guna2GroupBox.CustomBorderColor = MarkColor;
								return;
							}
							else if (!(Control.GetType() == typeof(Guna2Button)))
							{
								if (!(Control.GetType() == typeof(Guna2ImageButton)))
								{
									if (!(Control.GetType() == typeof(Guna2ComboBox)))
									{
										if (Control.GetType() == typeof(ComboBox))
										{
											ComboBox Ctrl = Control as ComboBox;
											Ctrl.Invoke(new Action(delegate()
											{
												if (!ResetToDefault)
												{
													frmTooltip.CurrentTooltip.DefaultColor = Ctrl.BackColor;
													Ctrl.BackColor = MarkColor;
													return;
												}
												Ctrl.BackColor = frmTooltip.CurrentTooltip.DefaultColor;
											}));
											return;
										}
										if (Control.GetType() == typeof(Guna2CheckBox))
										{
											Guna2CheckBox guna2CheckBox = Control as Guna2CheckBox;
											if (!ResetToDefault)
											{
												frmTooltip.CurrentTooltip.DefaultColor = guna2CheckBox.ForeColor;
												guna2CheckBox.ForeColor = MarkColor;
												return;
											}
											guna2CheckBox.ForeColor = frmTooltip.CurrentTooltip.DefaultColor;
										}
									}
									else
									{
										Guna2ComboBox guna2ComboBox = Control as Guna2ComboBox;
										if (!ResetToDefault)
										{
											frmTooltip.CurrentTooltip.DefaultColor = guna2ComboBox.BorderColor;
											guna2ComboBox.BorderColor = MarkColor;
											guna2ComboBox.BorderThickness = 2;
											return;
										}
										guna2ComboBox.BorderColor = frmTooltip.CurrentTooltip.DefaultColor;
										guna2ComboBox.BorderThickness = 1;
										return;
									}
								}
								else
								{
									Guna2ImageButton guna2ImageButton = Control as Guna2ImageButton;
									if (ResetToDefault)
									{
										guna2ImageButton.BackColor = frmTooltip.CurrentTooltip.DefaultColor;
										return;
									}
									frmTooltip.CurrentTooltip.DefaultColor = guna2ImageButton.BackColor;
									guna2ImageButton.BackColor = MarkColor;
									return;
								}
							}
							else
							{
								Guna2Button guna2Button = Control as Guna2Button;
								if (!ResetToDefault)
								{
									frmTooltip.CurrentTooltip.DefaultColor = guna2Button.FillColor;
									guna2Button.FillColor = MarkColor;
									return;
								}
								guna2Button.FillColor = frmTooltip.CurrentTooltip.DefaultColor;
								return;
							}
						}
						else
						{
							Guna2Panel guna2Panel = Control as Guna2Panel;
							if (ResetToDefault)
							{
								guna2Panel.CustomBorderThickness = new Padding(0);
								guna2Panel.CustomBorderColor = frmTooltip.CurrentTooltip.DefaultColor;
								return;
							}
							frmTooltip.CurrentTooltip.DefaultColor = guna2Panel.CustomBorderColor;
							guna2Panel.CustomBorderThickness = new Padding(1);
							guna2Panel.CustomBorderColor = MarkColor;
							return;
						}
					}
					else
					{
						Guna2TextBox guna2TextBox = Control as Guna2TextBox;
						if (!ResetToDefault)
						{
							frmTooltip.CurrentTooltip.DefaultColor = guna2TextBox.BorderColor;
							guna2TextBox.BorderColor = MarkColor;
							guna2TextBox.BorderThickness = 2;
							return;
						}
						guna2TextBox.BorderColor = frmTooltip.CurrentTooltip.DefaultColor;
						guna2TextBox.BorderThickness = 1;
						return;
					}
				}
				else
				{
					Control = (Label)Control;
					if (ResetToDefault)
					{
						Control.BackColor = frmTooltip.CurrentTooltip.DefaultColor;
						return;
					}
					frmTooltip.CurrentTooltip.DefaultColor = Control.BackColor;
					Control.BackColor = MarkColor;
					return;
				}
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00688154 File Offset: 0x00686354
		private void btnNext_Click(object sender, EventArgs e)
		{
			if (frmTooltip.TutorialWait)
			{
				frmTooltip.TutorialWait = false;
				return;
			}
			base.Close();
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00688178 File Offset: 0x00686378
		private void frmTooltip_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (frmTooltip.Tooltips != null && frmTooltip.Tooltips.Count > 0)
			{
				List<string> list = new List<string>();
				foreach (Tooltip tooltip in frmTooltip.Tooltips)
				{
					frmTooltip.CurrentTooltip = tooltip;
					if (tooltip.DefaultColor != default(Color) && !list.Contains(tooltip.MarkControlName))
					{
						this.MarkControl(true);
						list.Add(tooltip.MarkControlName);
					}
				}
			}
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00666D70 File Offset: 0x00664F70
		private void imgClose_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00688808 File Offset: 0x00686A08
		[CompilerGenerated]
		private void method_0()
		{
			if (frmTooltip.Tooltips != null && frmTooltip.Tooltips.Count > 0)
			{
				int num = 0;
				int count = frmTooltip.Tooltips.Count;
				bool flag = count > 1;
				foreach (Tooltip tooltip in frmTooltip.Tooltips)
				{
					frmTooltip.CurrentTooltip = tooltip;
					bool flag2 = num == count - 1;
					string text = tooltip.Text.Replace("</font>", "</font>.");
					Tools.Control(tooltip.Title, "lblTooltipTitle", "frmTooltip", true, false, false, false, 0);
					Tools.Control(text, "lblTooltipText", "frmTooltip", true, false, false, false, 0);
					if (!flag)
					{
						this.SetPosition();
					}
					this.SetCustomSize();
					Tools.Control(text.Replace("\r\n", "<br>"), "lblTooltipText", "frmTooltip", true, false, false, false, 0);
					if (tooltip.MarkControlName.Length > 0 || tooltip.TabControl.Length > 0)
					{
						this.MarkControl(false);
					}
					frmTooltip.TutorialWait = (flag && !flag2);
					if (!frmTooltip.TutorialWait)
					{
						Tools.Control("Close", "btnNext", "frmTooltip", true, false, false, false, 0);
					}
					else
					{
						Tools.Control("Next", "btnNext", "frmTooltip", true, false, false, false, 0);
					}
					while (Tools.IsFormOpen("frmTooltip") && frmTooltip.TutorialWait)
					{
						Thread.Sleep(100);
					}
					if (!Tools.IsFormOpen("frmTooltip"))
					{
						break;
					}
					if (tooltip.DefaultColor != default(Color) && !flag2)
					{
						this.MarkControl(true);
					}
					num++;
				}
			}
		}

		// Token: 0x040002D9 RID: 729
		public static List<Tooltip> Tooltips;

		// Token: 0x040002DA RID: 730
		private static bool TutorialWait;

		// Token: 0x040002DB RID: 731
		private static Tooltip CurrentTooltip;
	}
}
