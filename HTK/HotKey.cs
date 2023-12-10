using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace Jack.HTK
{
	// Token: 0x020000F2 RID: 242
	public class HotKey : IDisposable
	{
		// Token: 0x060016A1 RID: 5793 RVA: 0x00718358 File Offset: 0x00716558
		public static bool RegisterHotKey(string aKeyGestureString, Action aAction)
		{
			KeyGesture keyGesture = (KeyGesture)new KeyGestureConverter().ConvertFrom(aKeyGestureString);
			return HotKey.RegisterHotKey(keyGesture.Modifiers, keyGesture.Key, aAction);
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00718388 File Offset: 0x00716588
		public static bool RegisterHotKey(ModifierKeys aModifier, Key aKey, Action aAction)
		{
			if (aModifier == ModifierKeys.None)
			{
				throw new ArgumentException("Modifier must not be ModifierKeys.None");
			}
			if (aAction != null)
			{
				Keys vk = (Keys)KeyInterop.VirtualKeyFromKey(aKey);
				HotKey.currentID++;
				bool flag = HotKey.RegisterHotKey(HotKey.window.Handle, HotKey.currentID, (uint)(aModifier | (ModifierKeys)HotKey.MOD_NOREPEAT), (uint)vk);
				if (flag)
				{
					HotKey.registeredHotKeys.Add(new HotKey.HotKeyWithAction(aModifier, aKey, aAction));
				}
				return flag;
			}
			throw new ArgumentNullException("aAction");
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x007183F8 File Offset: 0x007165F8
		public void Dispose()
		{
			for (int i = HotKey.currentID; i > 0; i--)
			{
				HotKey.UnregisterHotKey(HotKey.window.Handle, i);
			}
			HotKey.window.Dispose();
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00718430 File Offset: 0x00716630
		static HotKey()
		{
			HotKey.window.KeyPressed += delegate(object sender, HotKey.InvisibleWindowForMessages.HotKeyPressedEventArgs e)
			{
				HotKey.registeredHotKeys.ForEach(delegate(HotKey.HotKeyWithAction x)
				{
					if (e.Modifier == x.Modifier && e.Key == x.Key)
					{
						x.Action();
					}
				});
			};
		}

		// Token: 0x060016A5 RID: 5797
		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

		// Token: 0x060016A6 RID: 5798
		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		// Token: 0x04000A8C RID: 2700
		private static readonly HotKey.InvisibleWindowForMessages window = new HotKey.InvisibleWindowForMessages();

		// Token: 0x04000A8D RID: 2701
		private static int currentID;

		// Token: 0x04000A8E RID: 2702
		private static uint MOD_NOREPEAT = 16384U;

		// Token: 0x04000A8F RID: 2703
		private static List<HotKey.HotKeyWithAction> registeredHotKeys = new List<HotKey.HotKeyWithAction>();

		// Token: 0x020000F3 RID: 243
		private class HotKeyWithAction
		{
			// Token: 0x060016B0 RID: 5808 RVA: 0x00718478 File Offset: 0x00716678
			public HotKeyWithAction(ModifierKeys modifier, Key key, Action action)
			{
				this.Modifier = modifier;
				this.Key = key;
				this.Action = action;
			}

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x060016B1 RID: 5809 RVA: 0x007184A0 File Offset: 0x007166A0
			public ModifierKeys Modifier { get; }

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x060016B2 RID: 5810 RVA: 0x007184B4 File Offset: 0x007166B4
			public Key Key { get; }

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x060016B3 RID: 5811 RVA: 0x007184C8 File Offset: 0x007166C8
			public Action Action { get; }
		}

		// Token: 0x020000F4 RID: 244
		private class InvisibleWindowForMessages : NativeWindow, IDisposable
		{
			// Token: 0x060016B4 RID: 5812 RVA: 0x007184DC File Offset: 0x007166DC
			public InvisibleWindowForMessages()
			{
				this.CreateHandle(new CreateParams());
			}

			// Token: 0x060016B5 RID: 5813 RVA: 0x007184FC File Offset: 0x007166FC
			protected override void WndProc(ref Message m)
			{
				base.WndProc(ref m);
				if (m.Msg == HotKey.InvisibleWindowForMessages.WM_HOTKEY)
				{
					Key key = KeyInterop.KeyFromVirtualKey((int)m.LParam >> 16 & 65535);
					ModifierKeys modifier = (ModifierKeys)((int)m.LParam & 65535);
					if (this.KeyPressed != null)
					{
						this.KeyPressed(this, new HotKey.InvisibleWindowForMessages.HotKeyPressedEventArgs(modifier, key));
					}
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x060016B6 RID: 5814 RVA: 0x00718564 File Offset: 0x00716764
			// (remove) Token: 0x060016B7 RID: 5815 RVA: 0x007185A0 File Offset: 0x007167A0
			public event EventHandler<HotKey.InvisibleWindowForMessages.HotKeyPressedEventArgs> KeyPressed;

			// Token: 0x060016B8 RID: 5816 RVA: 0x007185D8 File Offset: 0x007167D8
			public void Dispose()
			{
				this.DestroyHandle();
			}

			// Token: 0x04000A93 RID: 2707
			private static int WM_HOTKEY = 786;

			// Token: 0x020000F5 RID: 245
			public class HotKeyPressedEventArgs : EventArgs
			{
				// Token: 0x060016BF RID: 5823 RVA: 0x00718604 File Offset: 0x00716804
				internal HotKeyPressedEventArgs(ModifierKeys modifier, Key key)
				{
					this._modifier = modifier;
					this._key = key;
				}

				// Token: 0x1700031C RID: 796
				// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00718628 File Offset: 0x00716828
				public ModifierKeys Modifier
				{
					get
					{
						return this._modifier;
					}
				}

				// Token: 0x1700031D RID: 797
				// (get) Token: 0x060016C1 RID: 5825 RVA: 0x0071863C File Offset: 0x0071683C
				public Key Key
				{
					get
					{
						return this._key;
					}
				}

				// Token: 0x04000A95 RID: 2709
				private ModifierKeys _modifier;

				// Token: 0x04000A96 RID: 2710
				private Key _key;
			}
		}
	}
}
