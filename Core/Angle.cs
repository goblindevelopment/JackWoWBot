using System;
using System.Numerics;
using System.Threading;
using Jack.Engine;
using Jack.Models;

namespace Jack.Core
{
	// Token: 0x02000116 RID: 278
	internal class Angle
	{
		// Token: 0x06001913 RID: 6419 RVA: 0x00726A08 File Offset: 0x00724C08
		public static float FacingCenter(Vector3 from, Vector3 to, float originRotation)
		{
			float num = Angle.NormalizeRadian(Angle.Atan2Rotation(from, to, 0f) - originRotation);
			if ((double)num < 3.141592653589793)
			{
				return -num;
			}
			return Angle.NormalizeRadian(originRotation - Angle.Atan2Rotation(from, to, 0f));
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00726A4C File Offset: 0x00724C4C
		public static float NormalizeRadian(float radian)
		{
			if ((double)radian < 0.0)
			{
				return (float)(-(float)((double)(-(double)radian) % 6.283185307179586) + 6.283185307179586);
			}
			return radian % 6.283185f;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00726A88 File Offset: 0x00724C88
		public static float Atan2Rotation(Vector3 from, Vector3 to, float addRadian = 0f)
		{
			return (float)Math.Atan2((double)(to.Y - from.Y), (double)(to.X - from.X)) + addRadian;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00726ABC File Offset: 0x00724CBC
		public static void FaceMe(Vector3 From, Vector3 To, float OriginRotation, Units Unit = null, bool WalkTo = true, float Angle = 0.5f)
		{
			float num = Angle.FacingCenter(From, To, OriginRotation);
			if (num < Angle - Angle * 2f || num > Angle)
			{
				if (!WalkTo)
				{
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						while (_globals.Start)
						{
							if (_globals.NoCheck)
							{
								IL_8E:
								goto IL_B2;
							}
							if (Unit != null)
							{
								To = Unit.PositionVector3;
							}
							num = Angle.FacingCenter(ObjectManager.Me.PositionVector3, To, ObjectManager.Me.Facing);
							Walk.Direction(num, true);
							if (num > Angle - Angle * 2f && num < Angle)
							{
								break;
							}
							Thread.Sleep(10);
						}
						goto IL_8E;
					}
				}
				int pullDistance = SpellRotation.RotationSettings.PullDistance;
				Walk.Facing(To, Unit, (double)pullDistance, Angle, null);
				IL_B2:
				Key.Release("All");
			}
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00726B98 File Offset: 0x00724D98
		public static float GetAngleBetweenVectors(Vector3 From, Vector3 To)
		{
			Vector2 vector = new Vector2(To.X - From.X, To.Y - From.Y);
			return Angle.GetNormalizedAngleBetweenVectors((float)Math.Atan2((double)vector.Y, (double)vector.X));
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00726BE0 File Offset: 0x00724DE0
		private static float GetNormalizedAngleBetweenVectors(float Angle)
		{
			if (Angle < 0f)
			{
				Angle += 6.2831855f;
			}
			else if (Angle > 6.2831855f)
			{
				Angle -= 6.2831855f;
			}
			return Angle;
		}
	}
}
