using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.ATH;
using Jack.Core;
using Jack.Properties;

namespace Jack.Forms
{
	// Token: 0x02000086 RID: 134
	public partial class frmMainMessages : Form
	{
		// Token: 0x06000CEE RID: 3310 RVA: 0x006A8BA8 File Offset: 0x006A6DA8
		public frmMainMessages()
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x006A8BC8 File Offset: 0x006A6DC8
		private void frmMainMessages_Load(object sender, EventArgs e)
		{
			CustomUI.Set(this, "", false, false, true, true, false, false);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00688D2C File Offset: 0x00686F2C
		private void frmMainMessages_Shown(object sender, EventArgs e)
		{
			CustomUI.ResizeContent(base.Controls);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x006A8BE8 File Offset: 0x006A6DE8
		private void frmMainMessages_VisibleChanged(object sender, EventArgs e)
		{
			if (base.Visible && !_globals.JackFormsPreLoad)
			{
				this.LoadControlsAndSettings();
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x006A8C0C File Offset: 0x006A6E0C
		private void LoadControlsAndSettings()
		{
			int count = _globals.Messages.Count;
			this.panelMessages.Controls.Clear();
			if (count > 0)
			{
				List<MSG> list = new List<MSG>();
				object lockMSG = SNS._lockMSG;
				lock (lockMSG)
				{
					_globals.Messages.Reverse();
					for (int i = 0; i < count; i++)
					{
						if (i == 20)
						{
							break;
						}
						MSG msg = _globals.Messages[i];
						if (msg.Title.Length > 0 && msg.Message.Length > 0 && msg.DateOrigin.Length > 0 && msg.DateExpiration.Length > 0)
						{
							if ((DateTime.ParseExact(msg.DateExpiration, "dd.MM.yyyy, HH:mm", CultureInfo.InvariantCulture) - DateTime.Now).TotalDays > 0.0)
							{
								this.CreateMessage(msg, "New");
							}
							else
							{
								list.Add(msg);
							}
						}
					}
					_globals.Messages.Reverse();
				}
				if (list.Count > 0)
				{
					foreach (MSG message in list)
					{
						this.CreateMessage(message, "");
					}
				}
				CustomUI.ResizeContent(base.Controls);
			}
			else
			{
				this.ShowInfo();
			}
			SNS.DisplayMessages("Hide");
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x006A8DA8 File Offset: 0x006A6FA8
		private void CreateMessage(MSG Message, string Mode = "")
		{
			int num = 14;
			Control.ControlCollection controls = this.panelMessages.Controls;
			if (controls.Count > 0)
			{
				foreach (object obj in controls)
				{
					if (obj.GetType() == typeof(Guna2GroupBox))
					{
						Guna2GroupBox guna2GroupBox = obj as Guna2GroupBox;
						num += guna2GroupBox.Height + 14;
					}
				}
			}
			Guna2GroupBox guna2GroupBox2 = new Guna2GroupBox();
			Label label = new Label();
			guna2GroupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			guna2GroupBox2.Controls.Add(label);
			guna2GroupBox2.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			guna2GroupBox2.ForeColor = Color.White;
			guna2GroupBox2.Location = new Point(14, num);
			guna2GroupBox2.Name = "grpMessage";
			guna2GroupBox2.Size = new Size(841, 95);
			guna2GroupBox2.TabIndex = 8;
			guna2GroupBox2.Text = Message.Title;
			if (!(Mode == "New"))
			{
				guna2GroupBox2.FillColor = Color.FromArgb(27, 33, 43);
				guna2GroupBox2.BorderColor = Color.FromArgb(50, 61, 79);
				guna2GroupBox2.CustomBorderColor = Color.FromArgb(50, 61, 79);
			}
			else
			{
				guna2GroupBox2.FillColor = Color.FromArgb(27, 33, 43);
				guna2GroupBox2.BorderColor = Color.SteelBlue;
				guna2GroupBox2.CustomBorderColor = Color.SteelBlue;
			}
			label.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			label.Font = new Font("Segoe UI", 9f);
			label.ForeColor = Color.White;
			label.Location = new Point(22, 60);
			label.Name = "lblMessage";
			label.Size = new Size(800, 18);
			label.TabIndex = 74;
			label.Text = Message.Message;
			if (Message.Message.Contains("\r\n"))
			{
				int num2 = 0;
				using (Graphics graphics = base.CreateGraphics())
				{
					num2 = (int)Math.Ceiling((double)graphics.MeasureString(Message.Message, label.Font, label.Width).Height) - label.Height;
				}
				guna2GroupBox2.Height += num2;
			}
			this.panelMessages.Controls.Add(guna2GroupBox2);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x006A9018 File Offset: 0x006A7218
		private void ShowInfo()
		{
			Label label = new Label();
			label.Dock = DockStyle.Fill;
			label.Font = new Font("Segoe UI", 9f);
			label.ForeColor = Color.Gray;
			label.Location = new Point(0, 0);
			label.Name = "lblInfo";
			label.Size = new Size(868, 538);
			label.TabIndex = 0;
			label.Text = "No Messages found.";
			label.TextAlign = ContentAlignment.MiddleCenter;
			this.panelMessages.Controls.Add(label);
		}
	}
}
