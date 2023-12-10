using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using Jack.Core;
using Jack.Engine;

namespace Jack.ATH
{
	// Token: 0x0200013D RID: 317
	internal class SNS
	{
		// Token: 0x06001D4F RID: 7503 RVA: 0x00733B78 File Offset: 0x00731D78
		public static void Messages()
		{
			if (!SNS.MessagesRuns)
			{
				SNS.MessagesRuns = true;
			}
			Json.LoadMessages();
			bool flag = true;
			for (;;)
			{
				string text;
				if (!flag)
				{
					text = REQ.Ath("MSG", "&rn=true");
				}
				else
				{
					flag = false;
					text = REQ.Ath("MSG", "&rn=false");
				}
				object lockMSG;
				if (text.Length > 0 && text != "ConnectionFailed")
				{
					bool flag2 = false;
					string text2 = "";
					try
					{
						text2 = Crypt.Base64Decode(text);
						goto IL_2AB;
					}
					catch
					{
						flag2 = true;
						goto IL_2AB;
					}
					IL_68:
					if (text2.Length > 0 && text2.Contains("|"))
					{
						foreach (string text3 in text2.Split(new char[]
						{
							'|'
						}))
						{
							if (text3.Length > 0 && text3.Contains(';'))
							{
								string[] array2 = text3.Split(new char[]
								{
									';'
								});
								string text4 = array2[0];
								string title = array2[1];
								string text5 = array2[2];
								string text6 = array2[3];
								string dateOrigin = array2[4];
								string dateExpiration = array2[5];
								if (text4 == "Command")
								{
									if (!(text5 == "RemoveModuleGather"))
									{
										if (!(text5 == "RemoveModuleDungeon"))
										{
											if (!(text5 == "RemoveModuleNotifications"))
											{
												if (text5 == "RemoveModuleSession")
												{
													_globals.ModuleMultiSession = 1;
												}
											}
											else
											{
												_globals.ModuleNotifications = false;
											}
										}
										else
										{
											_globals.ModuleDungeon = false;
										}
									}
									else
									{
										_globals.ModuleGather = false;
									}
								}
								else if (!(text4 == "Update") || (text6.Length != 0 && !(text6 == _globals.Version)))
								{
									MSG msg = new MSG();
									msg.Type = text4;
									msg.Title = title;
									msg.Message = text5.Replace("\\r\\n", "\r\n");
									msg.DateOrigin = dateOrigin;
									msg.DateExpiration = dateExpiration;
									lockMSG = SNS._lockMSG;
									lock (lockMSG)
									{
										SNS.LatestMSG.Add(msg);
									}
								}
							}
						}
						goto IL_20B;
					}
					goto IL_20B;
					IL_2AB:
					if (!flag2)
					{
						goto IL_68;
					}
				}
				IL_20B:
				lockMSG = SNS._lockMSG;
				lock (lockMSG)
				{
					if (SNS.LatestMSG.Count > 0)
					{
						foreach (MSG item in SNS.LatestMSG)
						{
							_globals.Messages.Add(item);
						}
						Json.SaveMessages();
						SNS.DisplayMessages("Show");
					}
				}
				Thread.Sleep(900000);
			}
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00733E70 File Offset: 0x00732070
		public static void DisplayMessages(string Mode)
		{
			SNS.<>c__DisplayClass6_0 CS$<>8__locals1 = new SNS.<>c__DisplayClass6_0();
			CS$<>8__locals1.Mode = Mode;
			CS$<>8__locals1.ButtonText = " New Message";
			new Thread(new ThreadStart(CS$<>8__locals1.method_0))
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x00733EB0 File Offset: 0x007320B0
		public static void CreateLocalMessage(string Title, string Message, int DaysUntilExpiration, string MessageType = "News")
		{
			MSG msg = new MSG();
			msg.Type = MessageType;
			msg.Title = Title;
			msg.Message = Message;
			msg.DateOrigin = DateTime.Now.ToString("dd.MM.yyyy, HH:mm");
			msg.DateExpiration = DateTime.Now.AddDays((double)DaysUntilExpiration).ToString("dd.MM.yyyy, HH:mm");
			object lockMSG = SNS._lockMSG;
			lock (lockMSG)
			{
				SNS.LatestMSG.Add(msg);
				foreach (MSG item in SNS.LatestMSG)
				{
					_globals.Messages.Add(item);
				}
				Json.SaveMessages();
				SNS.DisplayMessages("Show");
			}
		}

		// Token: 0x06001D52 RID: 7506 RVA: 0x00733FA4 File Offset: 0x007321A4
		public static void Notifications()
		{
			if (MDL.NotifyMe)
			{
				SNS.MyLevel = ObjectManager.Me.Level;
				while (_globals.Start && MDL.NotifyMe)
				{
					if (!SNS.NotificationsRuns)
					{
						SNS.NotificationsRuns = true;
					}
					if (SNS.DelayLoopContent == 0)
					{
						SNS.NotifyLevelUp();
						SNS.SendNotes();
					}
					SNS.DelayLoopContent++;
					if (SNS.DelayLoopContent == 8)
					{
						SNS.DelayLoopContent = 0;
					}
					Thread.Sleep(1000);
				}
				SNS.NotificationsRuns = false;
			}
		}

		// Token: 0x06001D53 RID: 7507 RVA: 0x00734024 File Offset: 0x00732224
		private static void NotifyLevelUp()
		{
			if (Settings.NotificationsLevelUp)
			{
				int level = ObjectManager.Me.Level;
				if (level > SNS.MyLevel)
				{
					SNS.CreateNote("LevelUp", string.Concat(new string[]
					{
						"I've reached a new Level (",
						SNS.MyLevel.ToString(),
						" -> ",
						level.ToString(),
						")."
					}), false);
					SNS.MyLevel = level;
				}
			}
		}

		// Token: 0x06001D54 RID: 7508 RVA: 0x00734098 File Offset: 0x00732298
		public static void NotifyGhost(string Mode = "")
		{
			if (Settings.NotificationsGhost)
			{
				if (!(Mode == "Died"))
				{
					if (Mode == "Revived" && !SNS.NoteExists("Ghost", "I'm alive again."))
					{
						SNS.CreateNote("Ghost", "I'm alive again.", true);
					}
				}
				else if (!SNS.NoteExists("Ghost", "I died."))
				{
					SNS.CreateNote("Ghost", "I died.", true);
					return;
				}
			}
		}

		// Token: 0x06001D55 RID: 7509 RVA: 0x0073410C File Offset: 0x0073230C
		public static void NotifyEvent(string Message)
		{
			if (Settings.NotificationsEvent && !SNS.NoteExists("Event", Message))
			{
				SNS.CreateNote("Event", Message, true);
			}
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x0073413C File Offset: 0x0073233C
		private static bool NoteExists(string NoteType = "", string Notification = "")
		{
			object lockNotes = SNS._lockNotes;
			lock (lockNotes)
			{
				if (SNS.Notes.Count > 0)
				{
					foreach (NTS nts in SNS.Notes)
					{
						if (!nts.Sent && SNS.LastNote != Notification && nts.Type == NoteType && nts.Message == Notification)
						{
							DateTime value = DateTime.Parse(DateTime.FromFileTime(nts.DateTimeCreate).ToString("dd/MM/yyyy H:m:s"));
							if (DateTime.Now.Subtract(value) <= TimeSpan.FromSeconds(10.0))
							{
								SNS.LastNote = Notification;
								return true;
							}
						}
					}
				}
				return false;
			}
			bool result;
			return result;
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00734248 File Offset: 0x00732448
		public static void CreateNote(string Type, string Message, bool External = true)
		{
			SNS.<>c__DisplayClass17_0 CS$<>8__locals1 = new SNS.<>c__DisplayClass17_0();
			CS$<>8__locals1.Type = Type;
			CS$<>8__locals1.Message = Message;
			if (MDL.NotifyMe)
			{
				if (External)
				{
					new Thread(new ThreadStart(CS$<>8__locals1.method_0))
					{
						IsBackground = true
					}.Start();
					return;
				}
				CS$<>8__locals1.method_0();
			}
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x0073429C File Offset: 0x0073249C
		private static void SendNotes()
		{
			if (!SNS.Sending)
			{
				SNS.Sending = true;
				new Thread(new ThreadStart(SNS.smethod_0))
				{
					IsBackground = true
				}.Start();
			}
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x00734334 File Offset: 0x00732534
		[CompilerGenerated]
		internal static void smethod_0()
		{
			int num = 0;
			object lockNotes = SNS._lockNotes;
			lock (lockNotes)
			{
				using (List<NTS>.Enumerator enumerator = SNS.Notes.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.Sent)
						{
							num++;
						}
					}
				}
			}
			if (num > 0)
			{
				Tools.Console("Sending " + num.ToString() + " Notifications...", "", "richConsole", "frmMain", true);
				for (int i = 0; i < SNS.Notes.Count; i++)
				{
					NTS nts = SNS.Notes[i];
					if (!nts.Sent)
					{
						string message = SNS.smethod_1(nts.Type, nts.Message);
						SNS.smethod_2(message);
						SNS.smethod_3(message);
						SNS.Notes[i].Sent = true;
						Thread.Sleep(3000);
					}
				}
			}
			SNS.Sending = false;
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00734454 File Offset: 0x00732654
		[CompilerGenerated]
		internal static string smethod_1(string Type, string Message)
		{
			return "" + "[" + Type + "]\r\n" + Message;
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x0073447C File Offset: 0x0073267C
		[CompilerGenerated]
		internal static void smethod_2(string Message)
		{
			if (Settings.NotificationsDiscord)
			{
				REQ.Ath("NTS", "&ntst=Discord&duid=" + Settings.NotificationsDiscordUserID + "&dmsg=" + Uri.EscapeDataString(Crypt.Base64Encode(Message)));
			}
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x007344BC File Offset: 0x007326BC
		[CompilerGenerated]
		internal static void smethod_3(string Message)
		{
			if (Settings.NotificationsPushover)
			{
				Tools.CallURL("https://api.pushover.net/1/messages.json", "", "", "", new Dictionary<string, string>
				{
					{
						"token",
						Settings.NotificationsPushoverToken
					},
					{
						"&user",
						Settings.NotificationsPushoverKey
					},
					{
						"&message",
						Message
					}
				});
			}
		}

		// Token: 0x04000F89 RID: 3977
		public static List<MSG> LatestMSG = new List<MSG>();

		// Token: 0x04000F8A RID: 3978
		public static object _lockMSG = new object();

		// Token: 0x04000F8B RID: 3979
		private static List<NTS> Notes = new List<NTS>();

		// Token: 0x04000F8C RID: 3980
		public static object _lockNotes = new object();

		// Token: 0x04000F8D RID: 3981
		public static bool MessagesRuns = false;

		// Token: 0x04000F8E RID: 3982
		private static int DelayLoopContent = 0;

		// Token: 0x04000F8F RID: 3983
		private static int MyLevel = 0;

		// Token: 0x04000F90 RID: 3984
		private static string LastNote = "";

		// Token: 0x04000F91 RID: 3985
		public static bool NotificationsRuns = false;

		// Token: 0x04000F92 RID: 3986
		private static bool Sending = false;
	}
}
