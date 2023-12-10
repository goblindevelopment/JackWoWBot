using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Properties;

namespace Jack.Core
{
	// Token: 0x0200010F RID: 271
	public static class CustomUI
	{
		// Token: 0x06001878 RID: 6264 RVA: 0x00724CEC File Offset: 0x00722EEC
		public static void Set(Form Form, string WindowTitle = "", bool WindowActionBar = true, bool WindowResize = true, bool SetFonts = true, bool AddScrollbars = true, bool RoundedScrollbars = false, bool GoldenFrame = false)
		{
			Form.AutoScaleMode = AutoScaleMode.None;
			if (SetFonts)
			{
				CustomUI.SetFonts(Form.Controls);
			}
			CustomUI.SetWindowActions(Form, WindowTitle, WindowActionBar, WindowResize, GoldenFrame);
			if (AddScrollbars)
			{
				CustomUI.SetScrollbars(Form.Controls, RoundedScrollbars);
			}
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x00724D2C File Offset: 0x00722F2C
		public static void ResizeContent(Control.ControlCollection Collection)
		{
			foreach (object obj in Collection)
			{
				Control control = (Control)obj;
				Control.ControlCollection controls = control.Controls;
				if (controls != null)
				{
					CustomUI.ResizeContent(controls);
				}
				if (!(control.GetType() == typeof(Guna2TabControl)))
				{
					if (!(control.GetType() == typeof(Guna2Panel)))
					{
						continue;
					}
					using (IEnumerator enumerator2 = control.Controls.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							if (obj2.GetType() == typeof(Guna2GroupBox))
							{
								int num = 28;
								if (((Guna2Panel)control).VerticalScroll.Visible)
								{
									num += SystemInformation.VerticalScrollBarWidth;
								}
								((Guna2GroupBox)obj2).Width = control.Width - num;
							}
							else if (obj2.GetType() == typeof(TableLayoutPanel))
							{
								int num2 = 28;
								if (((Guna2Panel)control).VerticalScroll.Visible)
								{
									num2 += SystemInformation.VerticalScrollBarWidth;
								}
								((TableLayoutPanel)obj2).Width = control.Width - num2;
							}
						}
						continue;
					}
				}
				CustomUI.smethod_0((Guna2TabControl)control);
			}
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x00724ED0 File Offset: 0x007230D0
		public static void SetScrollbars(Control.ControlCollection Collection, bool RoundedScrollbars)
		{
			CustomUI.<>c__DisplayClass2_0 CS$<>8__locals1;
			CS$<>8__locals1.RoundedScrollbars = RoundedScrollbars;
			foreach (object obj in Collection)
			{
				Control control = (Control)obj;
				Control.ControlCollection controls = control.Controls;
				if (controls != null)
				{
					CustomUI.SetScrollbars(controls, CS$<>8__locals1.RoundedScrollbars);
				}
				if (control.GetType() == typeof(Guna2TabControl))
				{
					CustomUI.smethod_2((Guna2TabControl)control, ref CS$<>8__locals1);
				}
				else if (control.GetType() == typeof(Guna2Panel))
				{
					Guna2Panel guna2Panel = (Guna2Panel)control;
					if (guna2Panel.AutoScroll)
					{
						CustomUI.smethod_4(guna2Panel, ref CS$<>8__locals1);
					}
				}
				else if (control.GetType() == typeof(FlowLayoutPanel))
				{
					FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
					if (flowLayoutPanel.AutoScroll)
					{
						CustomUI.smethod_5(flowLayoutPanel, ref CS$<>8__locals1);
					}
				}
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00724FD0 File Offset: 0x007231D0
		public static void EnableGroupBox(bool Status, Guna2GroupBox Ctrl, string[] Exceptions = null)
		{
			if (Status)
			{
				Ctrl.CustomBorderColor = Color.FromArgb(50, 61, 79);
				Ctrl.BorderColor = Color.FromArgb(50, 61, 79);
				Ctrl.FillColor = Color.FromArgb(27, 33, 43);
				using (IEnumerator enumerator = Ctrl.Controls.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						((Control)obj).Enabled = true;
					}
					return;
				}
			}
			Ctrl.BorderColor = Color.FromArgb(70, 75, 82);
			Ctrl.CustomBorderColor = Color.FromArgb(70, 75, 82);
			Ctrl.FillColor = Color.FromArgb(48, 52, 56);
			foreach (object obj2 in Ctrl.Controls)
			{
				Control control = (Control)obj2;
				if (Exceptions == null || !Exceptions.Contains(control.Name))
				{
					control.Enabled = false;
				}
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x007250F0 File Offset: 0x007232F0
		public static void ColorGroupBox(string color, Guna2GroupBox Ctrl)
		{
			if (color == "Default")
			{
				Ctrl.CustomBorderColor = Color.FromArgb(50, 61, 79);
				Ctrl.BorderColor = Color.FromArgb(50, 61, 79);
				Ctrl.FillColor = Color.FromArgb(27, 33, 43);
				return;
			}
			if (color == "Bright")
			{
				Ctrl.CustomBorderColor = Color.FromArgb(62, 73, 92);
				Ctrl.BorderColor = Color.FromArgb(62, 73, 92);
				Ctrl.FillColor = Color.FromArgb(40, 46, 56);
				return;
			}
			if (!(color == "Blue"))
			{
				if (color == "Green")
				{
					Ctrl.CustomBorderColor = Color.FromArgb(62, 184, 81);
					Ctrl.BorderColor = Color.FromArgb(62, 184, 81);
					Ctrl.ForeColor = Color.FromArgb(14, 17, 22);
				}
				return;
			}
			Ctrl.CustomBorderColor = Color.SteelBlue;
			Ctrl.BorderColor = Color.SteelBlue;
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x007251EC File Offset: 0x007233EC
		public static void SetFonts(Control.ControlCollection Collection)
		{
			foreach (object obj in Collection)
			{
				Control control = (Control)obj;
				if (control.Controls != null)
				{
					CustomUI.SetFonts(control.Controls);
				}
				int num = 1;
				if (control.Name.StartsWith("lblTitle"))
				{
					num = 0;
				}
				else
				{
					string text = control.Font.FontFamily.Name.ToLower();
					if (text.Contains(" "))
					{
						text = text.Split(new char[]
						{
							' '
						})[0];
					}
					int num2 = 0;
					FontFamily[] families = _globals.Fonts.Families;
					for (int i = 0; i < families.Length; i++)
					{
						if (families[i].Name.ToLower().Contains(text))
						{
							num = num2;
							break;
						}
						num2++;
					}
				}
				if ((control.Font.Style & FontStyle.Bold) != FontStyle.Regular)
				{
					control.Font = new Font(_globals.Fonts.Families[num], control.Font.Size, FontStyle.Bold);
				}
				else
				{
					control.Font = new Font(_globals.Fonts.Families[num], control.Font.Size);
				}
				if (control.Name.StartsWith("tabs") && control.GetType() == typeof(Guna2TabControl))
				{
					Guna2TabControl guna2TabControl = (Guna2TabControl)control;
					guna2TabControl.TabButtonHoverState.Font = new Font(_globals.Fonts.Families[num], guna2TabControl.Font.Size);
					guna2TabControl.TabButtonIdleState.Font = new Font(_globals.Fonts.Families[num], guna2TabControl.Font.Size);
					guna2TabControl.TabButtonSelectedState.Font = new Font(_globals.Fonts.Families[num], guna2TabControl.Font.Size);
				}
			}
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x00725400 File Offset: 0x00723600
		public static void SetWindowActions(Form Form, string Title, bool WindowActionBar = true, bool WindowResize = true, bool GoldenFrame = false)
		{
			CustomUI.<>c__DisplayClass6_0 CS$<>8__locals1 = new CustomUI.<>c__DisplayClass6_0();
			CS$<>8__locals1.Form = Form;
			Guna2Panel guna2Panel = null;
			Guna2PictureBox guna2PictureBox = null;
			if (WindowActionBar)
			{
				Point location = new Point(12, 9);
				Size size = new Size(32, 32);
				Guna2ImageButton guna2ImageButton = new Guna2ImageButton();
				guna2ImageButton.CheckedState.ImageSize = new Size(16, 16);
				guna2ImageButton.HoverState.ImageOffset = new Point(0, -1);
				guna2ImageButton.HoverState.ImageSize = new Size(16, 16);
				guna2ImageButton.Image = Resources.jack_16;
				guna2ImageButton.ImageOffset = new Point(0, 0);
				guna2ImageButton.ImageRotate = 0f;
				guna2ImageButton.ImageSize = new Size(16, 16);
				guna2ImageButton.Name = "imgHeaderIcon";
				guna2ImageButton.PressedState.ImageSize = new Size(16, 16);
				guna2ImageButton.Location = location;
				guna2ImageButton.Size = size;
				location = new Point(CS$<>8__locals1.Form.Width - 82, 9);
				size = new Size(32, 32);
				Guna2ImageButton guna2ImageButton2 = new Guna2ImageButton();
				guna2ImageButton2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
				guna2ImageButton2.CheckedState.ImageSize = new Size(16, 16);
				guna2ImageButton2.HoverState.ImageOffset = new Point(0, -1);
				guna2ImageButton2.HoverState.ImageSize = new Size(16, 16);
				guna2ImageButton2.Image = Resources.minimize_16;
				guna2ImageButton2.ImageOffset = new Point(0, 0);
				guna2ImageButton2.ImageRotate = 0f;
				guna2ImageButton2.ImageSize = new Size(16, 16);
				guna2ImageButton2.Name = "imgHeaderMinimize";
				guna2ImageButton2.PressedState.ImageSize = new Size(16, 16);
				guna2ImageButton2.Location = location;
				guna2ImageButton2.Size = size;
				guna2ImageButton2.Click += delegate(object sender, EventArgs e)
				{
					CustomUI.WindowActionMinimize(sender, e, CS$<>8__locals1.Form);
				};
				location = new Point(CS$<>8__locals1.Form.Width - 44, 9);
				size = new Size(32, 32);
				Guna2ImageButton guna2ImageButton3 = new Guna2ImageButton();
				guna2ImageButton3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
				guna2ImageButton3.CheckedState.ImageSize = new Size(16, 16);
				guna2ImageButton3.HoverState.ImageOffset = new Point(0, -1);
				guna2ImageButton3.HoverState.ImageSize = new Size(16, 16);
				guna2ImageButton3.Image = Resources.close_16;
				guna2ImageButton3.ImageOffset = new Point(0, 0);
				guna2ImageButton3.ImageRotate = 0f;
				guna2ImageButton3.ImageSize = new Size(16, 16);
				guna2ImageButton3.Name = "imgHeaderClose";
				guna2ImageButton3.PressedState.ImageSize = new Size(16, 16);
				guna2ImageButton3.Location = location;
				guna2ImageButton3.Size = size;
				guna2ImageButton3.Click += delegate(object sender, EventArgs e)
				{
					CustomUI.WindowActionClose(sender, e, CS$<>8__locals1.Form);
				};
				location = new Point(guna2ImageButton.Size.Width + guna2ImageButton.Location.X, 0);
				size = new Size(CS$<>8__locals1.Form.Width - location.X - 82, 50);
				Label label = new Label();
				label.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
				label.BackColor = Color.Black;
				label.Font = new Font("Segoe UI", 9f);
				label.ForeColor = Color.FromArgb(153, 157, 169);
				label.Name = "lblHeaderTitle";
				label.Text = Title;
				label.TextAlign = ContentAlignment.MiddleCenter;
				label.Location = location;
				label.Size = size;
				label.MouseDown += delegate(object sender, MouseEventArgs e)
				{
					CustomUI.MoverMouseDown(sender, e, CS$<>8__locals1.Form);
				};
				guna2Panel = new Guna2Panel();
				guna2Panel.BackColor = Color.Black;
				guna2Panel.Dock = DockStyle.Top;
				guna2Panel.Location = new Point(0, 0);
				guna2Panel.Name = "panelHeader";
				guna2Panel.Size = new Size(CS$<>8__locals1.Form.Width, 50);
				guna2Panel.Controls.Add(guna2ImageButton);
				guna2Panel.Controls.Add(label);
				guna2Panel.Controls.Add(guna2ImageButton3);
				guna2Panel.Controls.Add(guna2ImageButton2);
			}
			if (WindowResize)
			{
				guna2PictureBox = new Guna2PictureBox();
				guna2PictureBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
				guna2PictureBox.Cursor = Cursors.SizeNWSE;
				guna2PictureBox.Image = Resources.resize_12;
				guna2PictureBox.ImageRotate = 0f;
				guna2PictureBox.Location = new Point(CS$<>8__locals1.Form.Width - 12 - 5, CS$<>8__locals1.Form.Height - 12 - 5);
				guna2PictureBox.Name = "imgSizer";
				guna2PictureBox.Padding = new Padding(0, 0, 5, 5);
				guna2PictureBox.Size = new Size(18, 18);
				guna2PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
				guna2PictureBox.TabStop = false;
				guna2PictureBox.MouseDown += delegate(object sender, MouseEventArgs e)
				{
					CustomUI.SizerMouseDown(sender, e, CS$<>8__locals1.Form);
				};
				guna2PictureBox.MouseMove += delegate(object sender, MouseEventArgs e)
				{
					CustomUI.SizerMouseMove(sender, e, CS$<>8__locals1.Form);
				};
				guna2PictureBox.MouseUp += delegate(object sender, MouseEventArgs e)
				{
					CustomUI.SizerMouseUp(sender, e);
				};
			}
			if (GoldenFrame)
			{
				CS$<>8__locals1.method_0(new Point(0, 0), new Size(CS$<>8__locals1.Form.Width, 1));
				CS$<>8__locals1.method_0(new Point(CS$<>8__locals1.Form.Width - 1, 1), new Size(1, CS$<>8__locals1.Form.Height - 1));
				CS$<>8__locals1.method_0(new Point(0, CS$<>8__locals1.Form.Height - 1), new Size(CS$<>8__locals1.Form.Width - 1, 1));
				CS$<>8__locals1.method_0(new Point(0, 1), new Size(1, CS$<>8__locals1.Form.Height - 1));
			}
			if (guna2Panel != null)
			{
				CS$<>8__locals1.Form.Controls.Add(guna2Panel);
			}
			if (guna2PictureBox != null)
			{
				CS$<>8__locals1.Form.Controls.Add(guna2PictureBox);
			}
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x007259B4 File Offset: 0x00723BB4
		private static void WindowActionClose(object sender, EventArgs e, Form Form)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
			if (Tools.GetForm(Form.Name) != null)
			{
				Tools.InvokeMethod(Form.Name, "HideForm", null, false);
				return;
			}
			Form.Close();
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x007259F8 File Offset: 0x00723BF8
		private static void WindowActionMinimize(object sender, EventArgs e, Form Form)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
			Form.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00725A1C File Offset: 0x00723C1C
		public static void Dialog(string Title, string Text, string TitleColor = "", string ParentFormName = "frmMain", bool AsDialog = true, int Timer = 0)
		{
			object[] args = new object[]
			{
				Title,
				Text,
				TitleColor,
				Timer
			};
			Tools.OpenForm("frmDialog", AsDialog, ParentFormName, args);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x00725A54 File Offset: 0x00723C54
		public static void DialogModule(string ParentForm = "frmMain")
		{
			Tools.OpenForm("frmModulesPricing", true, ParentForm, Array.Empty<object>());
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00725A74 File Offset: 0x00723C74
		public static void SetLocation(Form Form, string ParentFormName)
		{
			Form form = Application.OpenForms[ParentFormName];
			if (form != null)
			{
				Form.Location = new Point(form.Location.X + (form.Width - Form.Width) / 2, form.Location.Y + (form.Height - Form.Height) / 2);
			}
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x00725AD8 File Offset: 0x00723CD8
		public static void SizerMouseDown(object sender, MouseEventArgs e, Form Form)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
			CustomUI.MouseMove = true;
			CustomUI.MouseX = Control.MousePosition.X;
			CustomUI.MouseY = Control.MousePosition.Y;
			CustomUI.FormWidth = Form.Width;
			CustomUI.FormHeight = Form.Height;
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00725B34 File Offset: 0x00723D34
		public static void SizerMouseMove(object sender, MouseEventArgs e, Form Form)
		{
			if (CustomUI.MouseMove)
			{
				Form.Width = Control.MousePosition.X - CustomUI.MouseX + CustomUI.FormWidth;
				Form.Height = Control.MousePosition.Y - CustomUI.MouseY + CustomUI.FormHeight;
			}
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x00725B88 File Offset: 0x00723D88
		public static void SizerMouseUp(object sender, MouseEventArgs e)
		{
			CustomUI.MouseMove = false;
		}

		// Token: 0x06001887 RID: 6279
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06001888 RID: 6280
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06001889 RID: 6281 RVA: 0x00725B9C File Offset: 0x00723D9C
		public static void MoverMouseDown(object sender, MouseEventArgs e, Form Form)
		{
			Tools.CloseForm("frmTooltip", Array.Empty<object>());
			if (e.Button == MouseButtons.Left)
			{
				if (e.Clicks != 2)
				{
					CustomUI.ReleaseCapture();
					CustomUI.SendMessage(Form.Handle, 161, 2, 0);
				}
				else
				{
					if (Form.WindowState == FormWindowState.Normal)
					{
						Form.WindowState = FormWindowState.Maximized;
						return;
					}
					Form.WindowState = FormWindowState.Normal;
					return;
				}
			}
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00725C04 File Offset: 0x00723E04
		[CompilerGenerated]
		internal static void smethod_0(Guna2TabControl TabControl)
		{
			foreach (object obj in TabControl.TabPages)
			{
				CustomUI.smethod_1((TabPage)obj);
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00725C5C File Offset: 0x00723E5C
		[CompilerGenerated]
		internal static void smethod_1(TabPage TabPageControl)
		{
			int num = 28;
			if (TabPageControl.VerticalScroll.Visible)
			{
				num += SystemInformation.VerticalScrollBarWidth;
			}
			foreach (object obj in TabPageControl.Controls)
			{
				Control control = (Control)obj;
				if (control != null)
				{
					CustomUI.ResizeContent(control.Controls);
				}
				if (control.GetType() == typeof(Guna2GroupBox))
				{
					((Guna2GroupBox)control).Width = TabPageControl.Width - num;
				}
				else if (control.GetType() == typeof(TableLayoutPanel))
				{
					((TableLayoutPanel)control).Width = TabPageControl.Width - num;
				}
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00725D2C File Offset: 0x00723F2C
		[CompilerGenerated]
		internal static void smethod_2(Guna2TabControl TabControl, ref CustomUI.<>c__DisplayClass2_0 <>c__DisplayClass2_0_0)
		{
			foreach (object obj in TabControl.TabPages)
			{
				CustomUI.smethod_3((TabPage)obj, ref <>c__DisplayClass2_0_0);
			}
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00725D84 File Offset: 0x00723F84
		[CompilerGenerated]
		internal static void smethod_3(TabPage TabPageControl, ref CustomUI.<>c__DisplayClass2_0 <>c__DisplayClass2_0_0)
		{
			foreach (object obj in TabPageControl.Controls)
			{
				Control control = (Control)obj;
				if (!(control.GetType() == typeof(Guna2Panel)))
				{
					if (control.GetType() == typeof(FlowLayoutPanel))
					{
						FlowLayoutPanel flowLayoutPanel = (FlowLayoutPanel)control;
						if (flowLayoutPanel.AutoScroll)
						{
							CustomUI.smethod_5(flowLayoutPanel, ref <>c__DisplayClass2_0_0);
						}
					}
				}
				else
				{
					Guna2Panel guna2Panel = (Guna2Panel)control;
					if (guna2Panel.AutoScroll)
					{
						CustomUI.smethod_4(guna2Panel, ref <>c__DisplayClass2_0_0);
					}
				}
			}
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00725E38 File Offset: 0x00724038
		[CompilerGenerated]
		internal static void smethod_4(Guna2Panel Control, ref CustomUI.<>c__DisplayClass2_0 <>c__DisplayClass2_0_0)
		{
			string name = Control.Name + "_scrollbar";
			Guna2VScrollBar guna2VScrollBar = new Guna2VScrollBar();
			guna2VScrollBar.BindingContainer = Control;
			guna2VScrollBar.Name = name;
			guna2VScrollBar.Size = new Size(18, Control.Height);
			CustomUI.smethod_6(guna2VScrollBar, ref <>c__DisplayClass2_0_0);
			Control.Controls.Add(guna2VScrollBar);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00725E38 File Offset: 0x00724038
		[CompilerGenerated]
		internal static void smethod_5(FlowLayoutPanel Control, ref CustomUI.<>c__DisplayClass2_0 <>c__DisplayClass2_0_0)
		{
			string name = Control.Name + "_scrollbar";
			Guna2VScrollBar guna2VScrollBar = new Guna2VScrollBar();
			guna2VScrollBar.BindingContainer = Control;
			guna2VScrollBar.Name = name;
			guna2VScrollBar.Size = new Size(18, Control.Height);
			CustomUI.smethod_6(guna2VScrollBar, ref <>c__DisplayClass2_0_0);
			Control.Controls.Add(guna2VScrollBar);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x00725E90 File Offset: 0x00724090
		[CompilerGenerated]
		internal static void smethod_6(Guna2VScrollBar scrollbar, ref CustomUI.<>c__DisplayClass2_0 <>c__DisplayClass2_0_0)
		{
			if (<>c__DisplayClass2_0_0.RoundedScrollbars)
			{
				scrollbar.BorderRadius = 4;
			}
			scrollbar.FillColor = Color.FromArgb(14, 17, 22);
			scrollbar.FillOffset = new Padding(8, 0, 0, 0);
			scrollbar.HoverState.ThumbColor = Color.FromArgb(34, 40, 51);
			scrollbar.InUpdate = false;
			scrollbar.LargeChange = 617;
			scrollbar.Location = new Point(0, 0);
			scrollbar.Maximum = 869;
			scrollbar.Padding = new Padding(8, 0, 0, 0);
			scrollbar.PressedState.ThumbColor = Color.FromArgb(44, 52, 66);
			scrollbar.ScrollbarSize = 10;
			scrollbar.SmallChange = 5;
			scrollbar.ThumbColor = Color.FromArgb(27, 33, 43);
		}

		// Token: 0x04000BA8 RID: 2984
		private static int MouseX;

		// Token: 0x04000BA9 RID: 2985
		private static int MouseY;

		// Token: 0x04000BAA RID: 2986
		private static int FormWidth;

		// Token: 0x04000BAB RID: 2987
		private static int FormHeight;

		// Token: 0x04000BAC RID: 2988
		private static bool MouseMove;

		// Token: 0x04000BAD RID: 2989
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000BAE RID: 2990
		public const int HT_CAPTION = 2;
	}
}
