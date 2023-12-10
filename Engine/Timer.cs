using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace Jack.Engine
{
	// Token: 0x020000EA RID: 234
	public static class Timer
	{
		// Token: 0x0600163B RID: 5691 RVA: 0x00714C60 File Offset: 0x00712E60
		public static void Set(object Name, int Time)
		{
			string TimerID = "";
			if (!(Name.GetType() == typeof(int)))
			{
				TimerID = (string)Name;
			}
			else
			{
				TimerID = Convert.ToString(Name);
			}
			new Thread(delegate()
			{
				Jack.Engine.Timer.Add(TimerID, Time);
			})
			{
				IsBackground = true
			}.Start();
			while (Jack.Engine.Timer.Check(Name) != 1)
			{
				Thread.Sleep(10);
			}
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00714CE8 File Offset: 0x00712EE8
		private static void Add(string Name, int Time)
		{
			bool flag = false;
			for (;;)
			{
				if (!Monitor.IsEntered(Jack.Engine.Timer._lock))
				{
					lock (Jack.Engine.Timer._lock)
					{
						for (int i = 0; i < Jack.Engine.Timer.TimerList.Count; i++)
						{
							if (Jack.Engine.Timer.TimerList[i].Item1 == Name)
							{
								Jack.Engine.Timer.DuplicateList.Add(i);
							}
						}
						if (Jack.Engine.Timer.DuplicateList.Count > 0)
						{
							for (int j = 0; j < Jack.Engine.Timer.DuplicateList.Count; j++)
							{
								Jack.Engine.Timer.TimerList.RemoveAt(Jack.Engine.Timer.DuplicateList[j]);
							}
							Jack.Engine.Timer.DuplicateList.Clear();
						}
						Jack.Engine.Timer.TimerList.Add(new Tuple<string, int, bool>(Name, Time, false));
						flag = true;
						goto IL_07;
					}
					continue;
				}
				IL_07:
				if (flag)
				{
					break;
				}
				Thread.Sleep(10);
			}
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00714DDC File Offset: 0x00712FDC
		public static void Create()
		{
			for (;;)
			{
				if (!Monitor.IsEntered(Jack.Engine.Timer._lock))
				{
					lock (Jack.Engine.Timer._lock)
					{
						if (Jack.Engine.Timer.TimerList.Count > 0)
						{
							for (int i = 0; i < Jack.Engine.Timer.TimerList.Count; i++)
							{
								if (!Jack.Engine.Timer.TimerList[i].Item3)
								{
									string name = Jack.Engine.Timer.TimerList[i].Item1;
									double item = (double)Jack.Engine.Timer.TimerList[i].Item2;
									Jack.Engine.Timer.TimerList[i] = Tuple.Create<string, int, bool>(Jack.Engine.Timer.TimerList[i].Item1, Jack.Engine.Timer.TimerList[i].Item2, true);
									System.Timers.Timer timer = new System.Timers.Timer(item);
									timer.Elapsed += delegate(object sender, ElapsedEventArgs e)
									{
										Jack.Engine.Timer.Done(sender, e, name);
									};
									timer.Enabled = true;
									timer.AutoReset = false;
								}
							}
						}
					}
				}
				Thread.Sleep(1000);
			}
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00714EF0 File Offset: 0x007130F0
		private static void Done(object source, ElapsedEventArgs e, string name)
		{
			new Thread(delegate()
			{
				Jack.Engine.Timer.Delete(name);
			})
			{
				IsBackground = true
			}.Start();
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00714F28 File Offset: 0x00713128
		private static void Delete(object Name)
		{
			string TimerID = "";
			if (Name.GetType() == typeof(int))
			{
				TimerID = Convert.ToString(Name);
			}
			else
			{
				TimerID = (string)Name;
			}
			bool flag = false;
			for (;;)
			{
				if (!Monitor.IsEntered(Jack.Engine.Timer._lock))
				{
					lock (Jack.Engine.Timer._lock)
					{
						Jack.Engine.Timer.TimerList.RemoveAll((Tuple<string, int, bool> item) => item.Item1 == TimerID);
						flag = true;
						goto IL_46;
					}
					continue;
				}
				IL_46:
				if (flag)
				{
					break;
				}
				Thread.Sleep(10);
			}
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00714FD8 File Offset: 0x007131D8
		public static int Check(object Name)
		{
			string b;
			if (Name.GetType() == typeof(int))
			{
				b = Convert.ToString(Name);
			}
			else
			{
				b = (string)Name;
			}
			int result = 0;
			if (!Monitor.IsEntered(Jack.Engine.Timer._lock))
			{
				lock (Jack.Engine.Timer._lock)
				{
					if (Jack.Engine.Timer.TimerList.Count > 0)
					{
						for (int i = 0; i < Jack.Engine.Timer.TimerList.Count; i++)
						{
							if (Jack.Engine.Timer.TimerList[i].Item1 == b)
							{
								result = 1;
								break;
							}
						}
					}
					return result;
				}
			}
			result = 2;
			return result;
		}

		// Token: 0x04000A73 RID: 2675
		private static List<Tuple<string, int, bool>> TimerList = new List<Tuple<string, int, bool>>();

		// Token: 0x04000A74 RID: 2676
		private static List<int> DuplicateList = new List<int>();

		// Token: 0x04000A75 RID: 2677
		private static object _lock = new object();
	}
}
