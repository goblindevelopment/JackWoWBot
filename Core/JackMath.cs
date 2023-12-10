using System;
using System.Numerics;
using Jack.Engine;

namespace Jack.Core
{
	// Token: 0x02000115 RID: 277
	public static class JackMath
	{
		// Token: 0x060018F8 RID: 6392 RVA: 0x007263E8 File Offset: 0x007245E8
		public static int CalcToPercent(int Current, int Max)
		{
			return (int)Math.Round((double)(100 * Current) / (double)Max);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00726404 File Offset: 0x00724604
		public static string HealthOrPowerInfo(int Current, int Max)
		{
			int num = JackMath.CalcToPercent(Current, Max);
			return string.Concat(new string[]
			{
				Current.ToString(),
				"/",
				Max.ToString(),
				" (",
				num.ToString(),
				"%)"
			});
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x0072645C File Offset: 0x0072465C
		public static double Distance(Vector3 Position, bool X = true, bool Y = true, bool Z = true)
		{
			double value = 0.0;
			double result;
			try
			{
				Vector3 positionVector = ObjectManager.Me.PositionVector3;
				float num = 0f;
				float num2 = 0f;
				float num3 = 0f;
				if (X)
				{
					num = Position.X - positionVector.X;
				}
				if (Y)
				{
					num2 = Position.Y - positionVector.Y;
				}
				if (Z && !ObjectManager.Me.IsFlying)
				{
					num3 = Position.Z - positionVector.Z;
				}
				value = Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
				return Math.Round(value, 2);
			}
			catch
			{
				result = 0.0;
			}
			return result;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00726514 File Offset: 0x00724714
		public static double Distance(Vector3 From, Vector3 To, bool X = true, bool Y = true, bool Z = true)
		{
			double value = 0.0;
			double result;
			try
			{
				float num = 0f;
				float num2 = 0f;
				float num3 = 0f;
				if (X)
				{
					num = To.X - From.X;
				}
				if (Y)
				{
					num2 = To.Y - From.Y;
				}
				if (Z && !ObjectManager.Me.IsFlying)
				{
					num3 = To.Z - From.Z;
				}
				value = Math.Sqrt((double)(num * num + num2 * num2 + num3 * num3));
				return Math.Round(value, 2);
			}
			catch
			{
				result = 0.0;
			}
			return result;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x007265BC File Offset: 0x007247BC
		public static double DistanceAround(Vector3 Point, Vector3 Position)
		{
			if (Point.Z != 0f && Position.Z != 0f)
			{
				return Math.Sqrt(Math.Pow((double)(Position.X - Point.X), 2.0) + Math.Pow((double)(Position.Y - Point.Y), 2.0) + Math.Pow((double)(Position.Z - Point.Z), 2.0));
			}
			return Math.Sqrt(Math.Pow((double)(Position.X - Point.X), 2.0) + Math.Pow((double)(Position.Y - Point.Y), 2.0));
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00726680 File Offset: 0x00724880
		public static float Absolute(float number, bool ToPositive = true)
		{
			if (ToPositive)
			{
				return Math.Abs(number) * 1f;
			}
			return Math.Abs(number) * -1f;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x007266AC File Offset: 0x007248AC
		public static float Absolute(double number, bool ToPositive = true)
		{
			float value = Convert.ToSingle(number);
			if (ToPositive)
			{
				return Math.Abs(value) * 1f;
			}
			return Math.Abs(value) * -1f;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x007266DC File Offset: 0x007248DC
		public static bool IsBehind(Vector3 To, bool Distance = false)
		{
			if (ObjectManager.Me != null)
			{
				float num = Angle.FacingCenter(ObjectManager.Me.PositionVector3, To, ObjectManager.Me.Facing);
				if (num < 0f)
				{
					num = JackMath.Absolute(num, true);
				}
				if ((double)num >= 1.8 && (!Distance || JackMath.Distance(To, true, true, true) >= 10.0))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00726744 File Offset: 0x00724944
		public static bool IsReachable(Vector3 To, double Difference = 4.5)
		{
			if (ObjectManager.Me != null)
			{
				if (Walk.CheckProfileSettings)
				{
					if (_globals.ProfileSettings[0].DistanceIsReachable != Difference)
					{
						Difference = _globals.ProfileSettings[0].DistanceIsReachable;
					}
				}
				if ((double)(Math.Max(ObjectManager.Me.PositionZ, To.Z) - Math.Min(ObjectManager.Me.PositionZ, To.Z)) <= Difference)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x007267B8 File Offset: 0x007249B8
		public static float ZDifference(Vector3 To)
		{
			if (ObjectManager.Me != null)
			{
				return ObjectManager.Me.PositionZ - To.Z;
			}
			return 0f;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x007267E4 File Offset: 0x007249E4
		public static float ZDifference(Vector3 From, Vector3 To)
		{
			return From.Z - To.Z;
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00726800 File Offset: 0x00724A00
		public static bool ZDifference(Vector3 To, double Difference = 1.0)
		{
			return ObjectManager.Me != null && (double)(Math.Max(ObjectManager.Me.PositionZ, To.Z) - Math.Min(ObjectManager.Me.PositionZ, To.Z)) <= Difference;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00726848 File Offset: 0x00724A48
		public static bool ZDifference(float To, double Difference = 1.0)
		{
			return ObjectManager.Me != null && (double)(Math.Max(ObjectManager.Me.PositionZ, To) - Math.Min(ObjectManager.Me.PositionZ, To)) <= Difference;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00726884 File Offset: 0x00724A84
		public static bool ZDifference(float From, float To, double Difference = 1.0)
		{
			return (double)(Math.Max(From, To) - Math.Min(From, To)) <= Difference;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x007268A8 File Offset: 0x00724AA8
		public static float ZDifference(float From, float To)
		{
			return Math.Max(From, To) - Math.Min(From, To);
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x007268C4 File Offset: 0x00724AC4
		public static double ZDifferenceValue(float To)
		{
			if (ObjectManager.Me != null)
			{
				return Math.Round((double)(ObjectManager.Me.PositionZ - To), 2);
			}
			return 0.0;
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x007268F8 File Offset: 0x00724AF8
		public static double ZDifferenceValue(float From, float To)
		{
			return Math.Round((double)(From - To), 2);
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00726910 File Offset: 0x00724B10
		public static bool IsReachable(Vector3 From, Vector3 To, double Difference = 4.5)
		{
			return (ObjectManager.Me.IsFlying && !ObjectManager.Me.IsInVashjir) || (ObjectManager.Me != null && (double)(Math.Max(From.Z, To.Z) - Math.Min(From.Z, To.Z)) <= Difference);
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00726968 File Offset: 0x00724B68
		public static bool VectorIsBetween2D(Vector3 From, Vector3 To, Vector3 Between)
		{
			Vector3 vector = From;
			Vector3 vector2 = To;
			if (vector.X > vector2.X)
			{
				float x = vector.X;
				vector.X = vector2.X;
				vector2.X = x;
			}
			if (vector.Y > vector2.Y)
			{
				float y = vector.Y;
				vector.Y = vector2.Y;
				vector2.Y = y;
			}
			return Between.X > vector.X && Between.X < vector2.X && Between.Y > vector.Y && Between.Y < vector2.Y;
		}
	}
}
