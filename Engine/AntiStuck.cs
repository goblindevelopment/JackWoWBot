using System;
using System.Numerics;
using System.Threading;
using Jack.Core;

namespace Jack.Engine
{
	// Token: 0x020000BD RID: 189
	public static class AntiStuck
	{
		// Token: 0x06001426 RID: 5158 RVA: 0x00703280 File Offset: 0x00701480
		public static void Monitor()
		{
			while (_globals.Start)
			{
				if (!AntiStuck.Runs)
				{
					AntiStuck.Runs = true;
				}
				if (_globals.KeyStatus["MoveForward"])
				{
					Vector3 positionVector = ObjectManager.Me.PositionVector3;
					Thread.Sleep(1000);
					int num = 0;
					int num2 = 0;
					int num3 = 0;
					while (_globals.Start)
					{
						if (AntiStuck.Stuck || !_globals.KeyStatus["MoveForward"] || !ObjectManager.Me.IsMoving)
						{
							break;
						}
						if (JackMath.Distance(positionVector, true, true, true) <= 2.0)
						{
							if (num == 3)
							{
								AntiStuck.StuckCounter++;
								AntiStuck.Stuck = true;
								break;
							}
							num++;
						}
						else
						{
							AntiStuck.StuckCounter = 0;
							positionVector = ObjectManager.Me.PositionVector3;
						}
						if (!AntiStuck.StuckCircle)
						{
							if (num2 < 8)
							{
								if (!_globals.KeyStatus["TurnLeft"])
								{
									num2 = 0;
								}
								else
								{
									num2++;
								}
							}
							else
							{
								AntiStuck.StuckCircle = true;
								num2 = 0;
							}
							if (num3 < 8)
							{
								if (!_globals.KeyStatus["TurnRight"])
								{
									num3 = 0;
								}
								else
								{
									num3++;
								}
							}
							else
							{
								AntiStuck.StuckCircle = true;
								num3 = 0;
							}
						}
						if (ObjectManager.Me.IsInVashjir)
						{
							Thread.Sleep(500);
						}
						Thread.Sleep(500);
					}
				}
				if (!AntiStuck.ForceUnstuck && AntiStuck.Stuck)
				{
					AntiStuck.Unstuck();
				}
				Thread.Sleep(100);
			}
			AntiStuck.Runs = false;
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x007033F0 File Offset: 0x007015F0
		public static void Unstuck()
		{
			AntiStuck.DoUnstuck = true;
			if (AntiStuck.StuckCounter == 1)
			{
				Tools.Console("I'm stuck (1/3)...", "Orange", "richConsole", "frmMain", true);
				Key.Press("Jump");
				Thread.Sleep(30);
				Key.Release("Jump");
				AntiStuck.Stuck = false;
			}
			else if (AntiStuck.StuckCounter != 2)
			{
				if (AntiStuck.StuckCounter == 3)
				{
					Tools.Console("I'm stuck (3/3)...", "Orange", "richConsole", "frmMain", true);
					Tools.Console("I'd better get back on my path...", "Orange", "richConsole", "frmMain", true);
					_globals.NoCheck = true;
				}
			}
			else
			{
				Tools.Console("I'm stuck (2/3)...", "Orange", "richConsole", "frmMain", true);
				string key = "StrafeLeft";
				if (AntiStuck.Random.Next(1, 3) == 2)
				{
					key = "StrafeRight";
				}
				Key.Press(key);
				Thread.Sleep(2000);
				Key.Release(key);
				AntiStuck.Stuck = false;
				if (!AntiStuck.WatchRuns)
				{
					new Thread(new ThreadStart(AntiStuck.Watch))
					{
						IsBackground = true
					}.Start();
				}
			}
			AntiStuck.DoUnstuck = false;
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x00703518 File Offset: 0x00701718
		private static void Watch()
		{
			AntiStuck.WatchRuns = true;
			Thread.Sleep(6000);
			if (AntiStuck.StuckCounter > 0 && AntiStuck.StuckCounter < 3)
			{
				if (AntiStuck.DoUnstuck)
				{
					while (_globals.Start && AntiStuck.DoUnstuck)
					{
						Thread.Sleep(50);
					}
				}
				if (_globals.Start)
				{
					AntiStuck.ForceUnstuck = true;
					AntiStuck.StuckCounter = 3;
					AntiStuck.Stuck = true;
					Thread.Sleep(1000);
					Tools.Console("Anti-Stuck (Force) -> I'd better get back on my path...", "Orange", "richConsole", "frmMain", true);
				}
			}
			_globals.NoCheck = (AntiStuck.StuckCounter == 3);
			AntiStuck.WatchRuns = false;
		}

		// Token: 0x040009AF RID: 2479
		public static bool Stuck = false;

		// Token: 0x040009B0 RID: 2480
		public static bool StuckCircle = false;

		// Token: 0x040009B1 RID: 2481
		public static bool ForceUnstuck = false;

		// Token: 0x040009B2 RID: 2482
		public static int StuckCounter = 0;

		// Token: 0x040009B3 RID: 2483
		private static Random Random = new Random();

		// Token: 0x040009B4 RID: 2484
		public static bool Runs = false;

		// Token: 0x040009B5 RID: 2485
		private static bool DoUnstuck = false;

		// Token: 0x040009B6 RID: 2486
		private static bool WatchRuns = false;
	}
}
