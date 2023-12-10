using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace Jack.Core
{
	// Token: 0x02000134 RID: 308
	public struct UInt128 : IComparable<UInt128>, IEquatable<UInt128>, IFormattable, IComparable
	{
		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x0072E3A4 File Offset: 0x0072C5A4
		public static UInt128 MinValue
		{
			get
			{
				return UInt128.zero;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x0072E3B8 File Offset: 0x0072C5B8
		public static UInt128 MaxValue
		{
			get
			{
				return UInt128.maxValue;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x0072E3A4 File Offset: 0x0072C5A4
		public static UInt128 Zero
		{
			get
			{
				return UInt128.zero;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x0072E3CC File Offset: 0x0072C5CC
		public static UInt128 One
		{
			get
			{
				return UInt128.one;
			}
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x0072E3E0 File Offset: 0x0072C5E0
		public static UInt128 Parse(string value)
		{
			UInt128 result;
			if (!UInt128.TryParse(value, out result))
			{
				throw new FormatException();
			}
			return result;
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0072E400 File Offset: 0x0072C600
		public static bool TryParse(string value, out UInt128 result)
		{
			return UInt128.TryParse(value, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out result);
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0072E41C File Offset: 0x0072C61C
		public static bool TryParse(string value, NumberStyles style, IFormatProvider provider, out UInt128 result)
		{
			BigInteger a;
			if (!BigInteger.TryParse(value, style, provider, out a))
			{
				result = UInt128.Zero;
				return false;
			}
			UInt128.Create(out result, a);
			return true;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0072E44C File Offset: 0x0072C64C
		public UInt128(long value)
		{
			UInt128.Create(out this, value);
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0072E460 File Offset: 0x0072C660
		public UInt128(ulong value)
		{
			UInt128.Create(out this, value);
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0072E474 File Offset: 0x0072C674
		public UInt128(decimal value)
		{
			UInt128.Create(out this, value);
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0072E488 File Offset: 0x0072C688
		public UInt128(double value)
		{
			UInt128.Create(out this, value);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0072E49C File Offset: 0x0072C69C
		public UInt128(BigInteger value)
		{
			UInt128.Create(out this, value);
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0072E4B0 File Offset: 0x0072C6B0
		public static void Create(out UInt128 c, uint r0, uint r1, uint r2, uint r3)
		{
			c.s0 = ((ulong)r1 << 32 | (ulong)r0);
			c.s1 = ((ulong)r3 << 32 | (ulong)r2);
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x0072E4DC File Offset: 0x0072C6DC
		public static void Create(out UInt128 c, ulong s0, ulong s1)
		{
			c.s0 = s0;
			c.s1 = s1;
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x0072E4F8 File Offset: 0x0072C6F8
		public static void Create(out UInt128 c, long a)
		{
			c.s0 = (ulong)a;
			c.s1 = ((a < 0L) ? ulong.MaxValue : 0UL);
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0072E534 File Offset: 0x0072C734
		public static void Create(out UInt128 c, ulong a)
		{
			c.s0 = a;
			c.s1 = 0UL;
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0072E558 File Offset: 0x0072C758
		public static void Create(out UInt128 c, decimal a)
		{
			int[] bits = decimal.GetBits(decimal.Truncate(a));
			UInt128.Create(out c, (uint)bits[0], (uint)bits[1], (uint)bits[2], 0U);
			if (a < 0m)
			{
				UInt128.Negate(ref c);
			}
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0072E594 File Offset: 0x0072C794
		public static void Create(out UInt128 c, BigInteger a)
		{
			int sign = a.Sign;
			if (sign == -1)
			{
				a = -a;
			}
			c.s0 = (ulong)(a & ulong.MaxValue);
			c.s1 = (ulong)(a >> 64);
			if (sign == -1)
			{
				UInt128.Negate(ref c);
			}
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0072E5F0 File Offset: 0x0072C7F0
		public static void Create(out UInt128 c, double a)
		{
			bool flag = false;
			if (a < 0.0)
			{
				flag = true;
				a = -a;
			}
			if (a <= 1.8446744073709552E+19)
			{
				c.s0 = (ulong)a;
				c.s1 = 0UL;
			}
			else
			{
				int num = Math.Max((int)Math.Ceiling(Math.Log(a, 2.0)) - 63, 0);
				c.s0 = (ulong)(a / Math.Pow(2.0, (double)num));
				c.s1 = 0UL;
				UInt128.LeftShift(ref c, num);
			}
			if (flag)
			{
				UInt128.Negate(ref c);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001BB5 RID: 7093 RVA: 0x0072E690 File Offset: 0x0072C890
		private uint r0
		{
			get
			{
				return (uint)this.s0;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0072E6A4 File Offset: 0x0072C8A4
		private uint r1
		{
			get
			{
				return (uint)(this.s0 >> 32);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001BB7 RID: 7095 RVA: 0x0072E6BC File Offset: 0x0072C8BC
		private uint r2
		{
			get
			{
				return (uint)this.s1;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0072E6D0 File Offset: 0x0072C8D0
		private uint r3
		{
			get
			{
				return (uint)(this.s1 >> 32);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x0072E6E8 File Offset: 0x0072C8E8
		public ulong S0
		{
			get
			{
				return this.s0;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0072E6FC File Offset: 0x0072C8FC
		public ulong S1
		{
			get
			{
				return this.s1;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001BBB RID: 7099 RVA: 0x0072E710 File Offset: 0x0072C910
		public bool IsZero
		{
			get
			{
				return (this.s0 | this.s1) == 0UL;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0072E738 File Offset: 0x0072C938
		public bool IsOne
		{
			get
			{
				return (this.s1 ^ this.s0) == 1UL;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001BBD RID: 7101 RVA: 0x0072E760 File Offset: 0x0072C960
		public bool IsPowerOfTwo
		{
			get
			{
				return (this & this - 1UL).IsZero;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x0072E794 File Offset: 0x0072C994
		public bool IsEven
		{
			get
			{
				return (this.s0 & 1UL) == 0UL;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001BBF RID: 7103 RVA: 0x0072E7BC File Offset: 0x0072C9BC
		public int Sign
		{
			get
			{
				if (!this.IsZero)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0072E7D4 File Offset: 0x0072C9D4
		public override string ToString()
		{
			return this.ToString();
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0072E7FC File Offset: 0x0072C9FC
		public string ToString(string format)
		{
			return this.ToString(format);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0072E820 File Offset: 0x0072CA20
		public string ToString(IFormatProvider provider)
		{
			return this.ToString(null, provider);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0072E838 File Offset: 0x0072CA38
		public string ToString(string format, IFormatProvider provider)
		{
			return this.ToString(format, provider);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0072E85C File Offset: 0x0072CA5C
		public static explicit operator UInt128(double a)
		{
			UInt128 result;
			UInt128.Create(out result, a);
			return result;
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0072E874 File Offset: 0x0072CA74
		public static explicit operator UInt128(sbyte a)
		{
			UInt128 result;
			UInt128.Create(out result, (long)a);
			return result;
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0072E88C File Offset: 0x0072CA8C
		public static implicit operator UInt128(byte a)
		{
			UInt128 result;
			UInt128.Create(out result, (long)((ulong)a));
			return result;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0072E874 File Offset: 0x0072CA74
		public static explicit operator UInt128(short a)
		{
			UInt128 result;
			UInt128.Create(out result, (long)a);
			return result;
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0072E88C File Offset: 0x0072CA8C
		public static implicit operator UInt128(ushort a)
		{
			UInt128 result;
			UInt128.Create(out result, (long)((ulong)a));
			return result;
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0072E874 File Offset: 0x0072CA74
		public static explicit operator UInt128(int a)
		{
			UInt128 result;
			UInt128.Create(out result, (long)a);
			return result;
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0072E88C File Offset: 0x0072CA8C
		public static implicit operator UInt128(uint a)
		{
			UInt128 result;
			UInt128.Create(out result, (long)((ulong)a));
			return result;
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0072E8A4 File Offset: 0x0072CAA4
		public static explicit operator UInt128(long a)
		{
			UInt128 result;
			UInt128.Create(out result, a);
			return result;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0072E8BC File Offset: 0x0072CABC
		public static implicit operator UInt128(ulong a)
		{
			UInt128 result;
			UInt128.Create(out result, a);
			return result;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x0072E8D4 File Offset: 0x0072CAD4
		public static explicit operator UInt128(decimal a)
		{
			UInt128 result;
			UInt128.Create(out result, a);
			return result;
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0072E8EC File Offset: 0x0072CAEC
		public static explicit operator UInt128(BigInteger a)
		{
			UInt128 result;
			UInt128.Create(out result, a);
			return result;
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x0072E904 File Offset: 0x0072CB04
		public static explicit operator float(UInt128 a)
		{
			return UInt128.ConvertToFloat(ref a);
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x0072E918 File Offset: 0x0072CB18
		public static explicit operator double(UInt128 a)
		{
			return UInt128.ConvertToDouble(ref a);
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x0072E92C File Offset: 0x0072CB2C
		public static float ConvertToFloat(ref UInt128 a)
		{
			if (a.s1 == 0UL)
			{
				return a.s0;
			}
			return a.s1 * 1.8446744E+19f + a.s0;
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0072E964 File Offset: 0x0072CB64
		public static double ConvertToDouble(ref UInt128 a)
		{
			if (a.s1 == 0UL)
			{
				return a.s0;
			}
			return a.s1 * 1.8446744073709552E+19 + a.s0;
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0072E9A0 File Offset: 0x0072CBA0
		public static explicit operator sbyte(UInt128 a)
		{
			return (sbyte)a.s0;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x0072E9B4 File Offset: 0x0072CBB4
		public static explicit operator byte(UInt128 a)
		{
			return (byte)a.s0;
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x0072E9C8 File Offset: 0x0072CBC8
		public static explicit operator short(UInt128 a)
		{
			return (short)a.s0;
		}

		// Token: 0x06001BD6 RID: 7126 RVA: 0x0072E9DC File Offset: 0x0072CBDC
		public static explicit operator ushort(UInt128 a)
		{
			return (ushort)a.s0;
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x0072E9F0 File Offset: 0x0072CBF0
		public static explicit operator int(UInt128 a)
		{
			return (int)a.s0;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x0072E690 File Offset: 0x0072C890
		public static explicit operator uint(UInt128 a)
		{
			return (uint)a.s0;
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x0072E6E8 File Offset: 0x0072C8E8
		public static explicit operator long(UInt128 a)
		{
			return (long)a.s0;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x0072E6E8 File Offset: 0x0072C8E8
		public static explicit operator ulong(UInt128 a)
		{
			return a.s0;
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0072EA04 File Offset: 0x0072CC04
		public static explicit operator decimal(UInt128 a)
		{
			if (a.s1 == 0UL)
			{
				return a.s0;
			}
			int num = Math.Max(0, 32 - UInt128.GetBitLength(a.s1));
			UInt128 @uint;
			UInt128.RightShift(out @uint, ref a, num);
			return new decimal((int)a.r0, (int)a.r1, (int)a.r2, false, (byte)num);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0072EA64 File Offset: 0x0072CC64
		public static implicit operator BigInteger(UInt128 a)
		{
			if (a.s1 == 0UL)
			{
				return a.s0;
			}
			return a.s1 << 64 | a.s0;
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x0072EAA8 File Offset: 0x0072CCA8
		public static UInt128 operator <<(UInt128 a, int b)
		{
			UInt128 result;
			UInt128.LeftShift(out result, ref a, b);
			return result;
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0072EAC0 File Offset: 0x0072CCC0
		public static UInt128 operator >>(UInt128 a, int b)
		{
			UInt128 result;
			UInt128.RightShift(out result, ref a, b);
			return result;
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0072EAD8 File Offset: 0x0072CCD8
		public static UInt128 operator &(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.And(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0072EAF4 File Offset: 0x0072CCF4
		public static uint operator &(UInt128 a, uint b)
		{
			return (uint)a.s0 & b;
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0072EB0C File Offset: 0x0072CD0C
		public static uint operator &(uint a, UInt128 b)
		{
			return a & (uint)b.s0;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0072EB24 File Offset: 0x0072CD24
		public static ulong operator &(UInt128 a, ulong b)
		{
			return a.s0 & b;
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0072EB3C File Offset: 0x0072CD3C
		public static ulong operator &(ulong a, UInt128 b)
		{
			return a & b.s0;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0072EB54 File Offset: 0x0072CD54
		public static UInt128 operator |(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Or(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x0072EB70 File Offset: 0x0072CD70
		public static UInt128 operator ^(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.ExclusiveOr(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x0072EB8C File Offset: 0x0072CD8C
		public static UInt128 operator ~(UInt128 a)
		{
			UInt128 result;
			UInt128.Not(out result, ref a);
			return result;
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0072EBA4 File Offset: 0x0072CDA4
		public static UInt128 operator +(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Add(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x0072EBC0 File Offset: 0x0072CDC0
		public static UInt128 operator +(UInt128 a, ulong b)
		{
			UInt128 result;
			UInt128.Add(out result, ref a, b);
			return result;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x0072EBD8 File Offset: 0x0072CDD8
		public static UInt128 operator +(ulong a, UInt128 b)
		{
			UInt128 result;
			UInt128.Add(out result, ref b, a);
			return result;
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0072EBF0 File Offset: 0x0072CDF0
		public static UInt128 operator ++(UInt128 a)
		{
			UInt128 result;
			UInt128.Add(out result, ref a, 1UL);
			return result;
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0072EC10 File Offset: 0x0072CE10
		public static UInt128 operator -(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Subtract(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0072EC2C File Offset: 0x0072CE2C
		public static UInt128 operator -(UInt128 a, ulong b)
		{
			UInt128 result;
			UInt128.Subtract(out result, ref a, b);
			return result;
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x0072EC44 File Offset: 0x0072CE44
		public static UInt128 operator -(ulong a, UInt128 b)
		{
			UInt128 result;
			UInt128.Subtract(out result, a, ref b);
			return result;
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x0072EC5C File Offset: 0x0072CE5C
		public static UInt128 operator --(UInt128 a)
		{
			UInt128 result;
			UInt128.Subtract(out result, ref a, 1UL);
			return result;
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0072EC7C File Offset: 0x0072CE7C
		public static UInt128 operator +(UInt128 a)
		{
			return a;
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0072EC8C File Offset: 0x0072CE8C
		public static UInt128 operator *(UInt128 a, uint b)
		{
			UInt128 result;
			UInt128.Multiply(out result, ref a, b);
			return result;
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0072ECA4 File Offset: 0x0072CEA4
		public static UInt128 operator *(uint a, UInt128 b)
		{
			UInt128 result;
			UInt128.Multiply(out result, ref b, a);
			return result;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0072ECBC File Offset: 0x0072CEBC
		public static UInt128 operator *(UInt128 a, ulong b)
		{
			UInt128 result;
			UInt128.Multiply(out result, ref a, b);
			return result;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0072ECD4 File Offset: 0x0072CED4
		public static UInt128 operator *(ulong a, UInt128 b)
		{
			UInt128 result;
			UInt128.Multiply(out result, ref b, a);
			return result;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x0072ECEC File Offset: 0x0072CEEC
		public static UInt128 operator *(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Multiply(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0072ED08 File Offset: 0x0072CF08
		public static UInt128 operator /(UInt128 a, ulong b)
		{
			UInt128 result;
			UInt128.Divide(out result, ref a, b);
			return result;
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0072ED20 File Offset: 0x0072CF20
		public static UInt128 operator /(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Divide(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x0072ED3C File Offset: 0x0072CF3C
		public static ulong operator %(UInt128 a, uint b)
		{
			return (ulong)UInt128.Remainder(ref a, b);
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0072ED54 File Offset: 0x0072CF54
		public static ulong operator %(UInt128 a, ulong b)
		{
			return UInt128.Remainder(ref a, b);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0072ED6C File Offset: 0x0072CF6C
		public static UInt128 operator %(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Remainder(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x0072ED88 File Offset: 0x0072CF88
		public static bool operator <(UInt128 a, UInt128 b)
		{
			return UInt128.LessThan(ref a, ref b);
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0072EDA0 File Offset: 0x0072CFA0
		public static bool operator <(UInt128 a, int b)
		{
			return UInt128.LessThan(ref a, (long)b);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x0072EDB8 File Offset: 0x0072CFB8
		public static bool operator <(int a, UInt128 b)
		{
			return UInt128.LessThan((long)a, ref b);
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x0072EDD0 File Offset: 0x0072CFD0
		public static bool operator <(UInt128 a, uint b)
		{
			return UInt128.LessThan(ref a, (long)((ulong)b));
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0072EDE8 File Offset: 0x0072CFE8
		public static bool operator <(uint a, UInt128 b)
		{
			return UInt128.LessThan((long)((ulong)a), ref b);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x0072EE00 File Offset: 0x0072D000
		public static bool operator <(UInt128 a, long b)
		{
			return UInt128.LessThan(ref a, b);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0072EE18 File Offset: 0x0072D018
		public static bool operator <(long a, UInt128 b)
		{
			return UInt128.LessThan(a, ref b);
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x0072EE30 File Offset: 0x0072D030
		public static bool operator <(UInt128 a, ulong b)
		{
			return UInt128.LessThan(ref a, b);
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x0072EE48 File Offset: 0x0072D048
		public static bool operator <(ulong a, UInt128 b)
		{
			return UInt128.LessThan(a, ref b);
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x0072EE60 File Offset: 0x0072D060
		public static bool operator <=(UInt128 a, UInt128 b)
		{
			return !UInt128.LessThan(ref b, ref a);
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0072EE7C File Offset: 0x0072D07C
		public static bool operator <=(UInt128 a, int b)
		{
			return !UInt128.LessThan((long)b, ref a);
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x0072EE98 File Offset: 0x0072D098
		public static bool operator <=(int a, UInt128 b)
		{
			return !UInt128.LessThan(ref b, (long)a);
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0072EEB4 File Offset: 0x0072D0B4
		public static bool operator <=(UInt128 a, uint b)
		{
			return !UInt128.LessThan((long)((ulong)b), ref a);
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x0072EED0 File Offset: 0x0072D0D0
		public static bool operator <=(uint a, UInt128 b)
		{
			return !UInt128.LessThan(ref b, (long)((ulong)a));
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0072EEEC File Offset: 0x0072D0EC
		public static bool operator <=(UInt128 a, long b)
		{
			return !UInt128.LessThan(b, ref a);
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0072EF04 File Offset: 0x0072D104
		public static bool operator <=(long a, UInt128 b)
		{
			return !UInt128.LessThan(ref b, a);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0072EF1C File Offset: 0x0072D11C
		public static bool operator <=(UInt128 a, ulong b)
		{
			return !UInt128.LessThan(b, ref a);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x0072EF34 File Offset: 0x0072D134
		public static bool operator <=(ulong a, UInt128 b)
		{
			return !UInt128.LessThan(ref b, a);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x0072EF4C File Offset: 0x0072D14C
		public static bool operator >(UInt128 a, UInt128 b)
		{
			return UInt128.LessThan(ref b, ref a);
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x0072EF64 File Offset: 0x0072D164
		public static bool operator >(UInt128 a, int b)
		{
			return UInt128.LessThan((long)b, ref a);
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0072EF7C File Offset: 0x0072D17C
		public static bool operator >(int a, UInt128 b)
		{
			return UInt128.LessThan(ref b, (long)a);
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0072EF94 File Offset: 0x0072D194
		public static bool operator >(UInt128 a, uint b)
		{
			return UInt128.LessThan((long)((ulong)b), ref a);
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0072EFAC File Offset: 0x0072D1AC
		public static bool operator >(uint a, UInt128 b)
		{
			return UInt128.LessThan(ref b, (long)((ulong)a));
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0072EFC4 File Offset: 0x0072D1C4
		public static bool operator >(UInt128 a, long b)
		{
			return UInt128.LessThan(b, ref a);
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0072EFDC File Offset: 0x0072D1DC
		public static bool operator >(long a, UInt128 b)
		{
			return UInt128.LessThan(ref b, a);
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0072EFF4 File Offset: 0x0072D1F4
		public static bool operator >(UInt128 a, ulong b)
		{
			return UInt128.LessThan(b, ref a);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0072F00C File Offset: 0x0072D20C
		public static bool operator >(ulong a, UInt128 b)
		{
			return UInt128.LessThan(ref b, a);
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0072F024 File Offset: 0x0072D224
		public static bool operator >=(UInt128 a, UInt128 b)
		{
			return !UInt128.LessThan(ref a, ref b);
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0072F040 File Offset: 0x0072D240
		public static bool operator >=(UInt128 a, int b)
		{
			return !UInt128.LessThan(ref a, (long)b);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0072F05C File Offset: 0x0072D25C
		public static bool operator >=(int a, UInt128 b)
		{
			return !UInt128.LessThan((long)a, ref b);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0072F078 File Offset: 0x0072D278
		public static bool operator >=(UInt128 a, uint b)
		{
			return !UInt128.LessThan(ref a, (long)((ulong)b));
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0072F094 File Offset: 0x0072D294
		public static bool operator >=(uint a, UInt128 b)
		{
			return !UInt128.LessThan((long)((ulong)a), ref b);
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0072F0B0 File Offset: 0x0072D2B0
		public static bool operator >=(UInt128 a, long b)
		{
			return !UInt128.LessThan(ref a, b);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0072F0C8 File Offset: 0x0072D2C8
		public static bool operator >=(long a, UInt128 b)
		{
			return !UInt128.LessThan(a, ref b);
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0072F0E0 File Offset: 0x0072D2E0
		public static bool operator >=(UInt128 a, ulong b)
		{
			return !UInt128.LessThan(ref a, b);
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0072F0F8 File Offset: 0x0072D2F8
		public static bool operator >=(ulong a, UInt128 b)
		{
			return !UInt128.LessThan(a, ref b);
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0072F110 File Offset: 0x0072D310
		public static bool operator ==(UInt128 a, UInt128 b)
		{
			return a.Equals(b);
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0072F128 File Offset: 0x0072D328
		public static bool operator ==(UInt128 a, int b)
		{
			return a.Equals(b);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x0072F140 File Offset: 0x0072D340
		public static bool operator ==(int a, UInt128 b)
		{
			return b.Equals(a);
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0072F158 File Offset: 0x0072D358
		public static bool operator ==(UInt128 a, uint b)
		{
			return a.Equals(b);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0072F170 File Offset: 0x0072D370
		public static bool operator ==(uint a, UInt128 b)
		{
			return b.Equals(a);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0072F188 File Offset: 0x0072D388
		public static bool operator ==(UInt128 a, long b)
		{
			return a.Equals(b);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0072F1A0 File Offset: 0x0072D3A0
		public static bool operator ==(long a, UInt128 b)
		{
			return b.Equals(a);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0072F1B8 File Offset: 0x0072D3B8
		public static bool operator ==(UInt128 a, ulong b)
		{
			return a.Equals(b);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0072F1D0 File Offset: 0x0072D3D0
		public static bool operator ==(ulong a, UInt128 b)
		{
			return b.Equals(a);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0072F1E8 File Offset: 0x0072D3E8
		public static bool operator !=(UInt128 a, UInt128 b)
		{
			return !a.Equals(b);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0072F200 File Offset: 0x0072D400
		public static bool operator !=(UInt128 a, int b)
		{
			return !a.Equals(b);
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0072F218 File Offset: 0x0072D418
		public static bool operator !=(int a, UInt128 b)
		{
			return !b.Equals(a);
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0072F230 File Offset: 0x0072D430
		public static bool operator !=(UInt128 a, uint b)
		{
			return !a.Equals(b);
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0072F248 File Offset: 0x0072D448
		public static bool operator !=(uint a, UInt128 b)
		{
			return !b.Equals(a);
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x0072F260 File Offset: 0x0072D460
		public static bool operator !=(UInt128 a, long b)
		{
			return !a.Equals(b);
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x0072F278 File Offset: 0x0072D478
		public static bool operator !=(long a, UInt128 b)
		{
			return !b.Equals(a);
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x0072F290 File Offset: 0x0072D490
		public static bool operator !=(UInt128 a, ulong b)
		{
			return !a.Equals(b);
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x0072F2A8 File Offset: 0x0072D4A8
		public static bool operator !=(ulong a, UInt128 b)
		{
			return !b.Equals(a);
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x0072F2C0 File Offset: 0x0072D4C0
		public int CompareTo(UInt128 other)
		{
			if (this.s1 != other.s1)
			{
				return this.s1.CompareTo(other.s1);
			}
			return this.s0.CompareTo(other.s0);
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0072F300 File Offset: 0x0072D500
		public int CompareTo(int other)
		{
			if (this.s1 == 0UL && other >= 0)
			{
				return this.s0.CompareTo((ulong)((long)other));
			}
			return 1;
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0072F328 File Offset: 0x0072D528
		public int CompareTo(uint other)
		{
			if (this.s1 != 0UL)
			{
				return 1;
			}
			return this.s0.CompareTo((ulong)other);
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x0072F34C File Offset: 0x0072D54C
		public int CompareTo(long other)
		{
			if (this.s1 == 0UL && other >= 0L)
			{
				return this.s0.CompareTo((ulong)other);
			}
			return 1;
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x0072F37C File Offset: 0x0072D57C
		public int CompareTo(ulong other)
		{
			if (this.s1 != 0UL)
			{
				return 1;
			}
			return this.s0.CompareTo(other);
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0072F3A0 File Offset: 0x0072D5A0
		public int CompareTo(object obj)
		{
			if (obj == null)
			{
				return 1;
			}
			if (!(obj is UInt128))
			{
				throw new ArgumentException();
			}
			return this.CompareTo((UInt128)obj);
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0072F3CC File Offset: 0x0072D5CC
		private static bool LessThan(ref UInt128 a, long b)
		{
			return b >= 0L && a.s1 == 0UL && a.s0 < (ulong)b;
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0072F3F8 File Offset: 0x0072D5F8
		private static bool LessThan(long a, ref UInt128 b)
		{
			return a < 0L || b.s1 != 0UL || a < (long)b.s0;
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0072F424 File Offset: 0x0072D624
		private static bool LessThan(ref UInt128 a, ulong b)
		{
			return a.s1 == 0UL && a.s0 < b;
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0072F444 File Offset: 0x0072D644
		private static bool LessThan(ulong a, ref UInt128 b)
		{
			return b.s1 != 0UL || a < b.s0;
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0072F464 File Offset: 0x0072D664
		private static bool LessThan(ref UInt128 a, ref UInt128 b)
		{
			if (a.s1 != b.s1)
			{
				return a.s1 < b.s1;
			}
			return a.s0 < b.s0;
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0072F49C File Offset: 0x0072D69C
		public static bool Equals(ref UInt128 a, ref UInt128 b)
		{
			return a.s0 == b.s0 && a.s1 == b.s1;
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0072F49C File Offset: 0x0072D69C
		public bool Equals(UInt128 other)
		{
			return this.s0 == other.s0 && this.s1 == other.s1;
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0072F4C8 File Offset: 0x0072D6C8
		public bool Equals(int other)
		{
			return other >= 0 && this.s0 == (ulong)other && this.s1 == 0UL;
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0072F4F8 File Offset: 0x0072D6F8
		public bool Equals(uint other)
		{
			return this.s0 == (ulong)other && this.s1 == 0UL;
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0072F524 File Offset: 0x0072D724
		public bool Equals(long other)
		{
			return other >= 0L && this.s0 == (ulong)other && this.s1 == 0UL;
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0072F55C File Offset: 0x0072D75C
		public bool Equals(ulong other)
		{
			return this.s0 == other && this.s1 == 0UL;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0072F588 File Offset: 0x0072D788
		public override bool Equals(object obj)
		{
			return obj is UInt128 && this.Equals((UInt128)obj);
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0072F5AC File Offset: 0x0072D7AC
		public override int GetHashCode()
		{
			return this.s0.GetHashCode() ^ this.s1.GetHashCode();
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0072F5D0 File Offset: 0x0072D7D0
		public static void Multiply(out UInt128 c, ref UInt128 a, uint b)
		{
			if (a.s1 == 0UL)
			{
				UInt128.Multiply64(out c, a.s0, b);
				return;
			}
			UInt128.Multiply128(out c, ref a, b);
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0072F5FC File Offset: 0x0072D7FC
		public static void Multiply(out UInt128 c, ref UInt128 a, ulong b)
		{
			if (a.s1 == 0UL)
			{
				UInt128.Multiply64(out c, a.s0, b);
				return;
			}
			UInt128.Multiply128(out c, ref a, b);
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0072F628 File Offset: 0x0072D828
		public static void Multiply(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			if ((a.s1 | b.s1) == 0UL)
			{
				UInt128.Multiply64(out c, a.s0, b.s0);
				return;
			}
			if (a.s1 == 0UL)
			{
				UInt128.Multiply128(out c, ref b, a.s0);
				return;
			}
			if (b.s1 == 0UL)
			{
				UInt128.Multiply128(out c, ref a, b.s0);
				return;
			}
			UInt128.Multiply128(out c, ref a, ref b);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x0072F68C File Offset: 0x0072D88C
		private static void Multiply(out UInt128.UInt256 c, ref UInt128 a, ref UInt128 b)
		{
			UInt128 @uint;
			UInt128.Multiply64(out @uint, a.s0, b.s0);
			UInt128 uint2;
			UInt128.Multiply64(out uint2, a.s0, b.s1);
			UInt128 uint3;
			UInt128.Multiply64(out uint3, a.s1, b.s0);
			UInt128 uint4;
			UInt128.Multiply64(out uint4, a.s1, b.s1);
			uint num = 0U;
			uint num2 = 0U;
			c.s0 = @uint.S0;
			c.s1 = UInt128.Add(UInt128.Add(@uint.s1, uint2.s0, ref num), uint3.s0, ref num);
			c.s2 = UInt128.Add(UInt128.Add(UInt128.Add(uint2.s1, uint3.s1, ref num2), uint4.s0, ref num2), (ulong)num, ref num2);
			c.s3 = uint4.s1 + (ulong)num2;
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x0072EC7C File Offset: 0x0072CE7C
		public static UInt128 Abs(UInt128 a)
		{
			return a;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x0072F760 File Offset: 0x0072D960
		public static UInt128 Square(ulong a)
		{
			UInt128 result;
			UInt128.Square64(out result, a);
			return result;
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x0072F778 File Offset: 0x0072D978
		public static UInt128 Square(UInt128 a)
		{
			UInt128 result;
			UInt128.Square(out result, ref a);
			return result;
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0072F790 File Offset: 0x0072D990
		public static void Square(out UInt128 c, ref UInt128 a)
		{
			if (a.s1 == 0UL)
			{
				UInt128.Square64(out c, a.s0);
				return;
			}
			UInt128.Multiply128(out c, ref a, ref a);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x0072F7BC File Offset: 0x0072D9BC
		public static UInt128 Cube(ulong a)
		{
			UInt128 result;
			UInt128.Cube(out result, a);
			return result;
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x0072F7D4 File Offset: 0x0072D9D4
		public static UInt128 Cube(UInt128 a)
		{
			UInt128 result;
			UInt128.Cube(out result, ref a);
			return result;
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0072F7EC File Offset: 0x0072D9EC
		public static void Cube(out UInt128 c, ulong a)
		{
			UInt128 @uint;
			UInt128.Square64(out @uint, a);
			UInt128.Multiply(out c, ref @uint, a);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0072F80C File Offset: 0x0072DA0C
		public static void Cube(out UInt128 c, ref UInt128 a)
		{
			UInt128 @uint;
			if (a.s1 == 0UL)
			{
				UInt128.Square64(out @uint, a.s0);
				UInt128.Multiply(out c, ref @uint, a.s0);
				return;
			}
			UInt128.Multiply128(out @uint, ref a, ref a);
			UInt128.Multiply128(out c, ref @uint, ref a);
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0072F850 File Offset: 0x0072DA50
		public static void Add(out UInt128 c, ulong a, ulong b)
		{
			c.s0 = a + b;
			c.s1 = 0UL;
			if (c.s0 < a && c.s0 < b)
			{
				c.s1 += 1UL;
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0072F89C File Offset: 0x0072DA9C
		public static void Add(out UInt128 c, ref UInt128 a, ulong b)
		{
			c.s0 = a.s0 + b;
			c.s1 = a.s1;
			if (c.s0 < a.s0 && c.s0 < b)
			{
				c.s1 += 1UL;
			}
		}

		// Token: 0x06001C53 RID: 7251 RVA: 0x0072F8F0 File Offset: 0x0072DAF0
		public static void Add(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			c.s0 = a.s0 + b.s0;
			c.s1 = a.s1 + b.s1;
			if (c.s0 < a.s0 && c.s0 < b.s0)
			{
				c.s1 += 1UL;
			}
		}

		// Token: 0x06001C54 RID: 7252 RVA: 0x0072F954 File Offset: 0x0072DB54
		private static ulong Add(ulong a, ulong b, ref uint carry)
		{
			ulong num = a + b;
			if (num < a && num < b)
			{
				carry += 1U;
			}
			return num;
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x0072F974 File Offset: 0x0072DB74
		public static void Add(ref UInt128 a, ulong b)
		{
			ulong num = a.s0 + b;
			if (num < a.s0 && num < b)
			{
				a.s1 += 1UL;
			}
			a.s0 = num;
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x0072F9B4 File Offset: 0x0072DBB4
		public static void Add(ref UInt128 a, ref UInt128 b)
		{
			ulong num = a.s0 + b.s0;
			if (num < a.s0 && num < b.s0)
			{
				a.s1 += 1UL;
			}
			a.s0 = num;
			a.s1 += b.s1;
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0072FA0C File Offset: 0x0072DC0C
		public static void Add(ref UInt128 a, UInt128 b)
		{
			UInt128.Add(ref a, ref b);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0072FA24 File Offset: 0x0072DC24
		public static void Subtract(out UInt128 c, ref UInt128 a, ulong b)
		{
			c.s0 = a.s0 - b;
			c.s1 = a.s1;
			if (a.s0 < b)
			{
				c.s1 -= 1UL;
			}
		}

		// Token: 0x06001C59 RID: 7257 RVA: 0x0072FA68 File Offset: 0x0072DC68
		public static void Subtract(out UInt128 c, ulong a, ref UInt128 b)
		{
			c.s0 = a - b.s0;
			c.s1 = 0UL - b.s1;
			if (a < b.s0)
			{
				c.s1 -= 1UL;
			}
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0072FAB8 File Offset: 0x0072DCB8
		public static void Subtract(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			c.s0 = a.s0 - b.s0;
			c.s1 = a.s1 - b.s1;
			if (a.s0 < b.s0)
			{
				c.s1 -= 1UL;
			}
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0072FB0C File Offset: 0x0072DD0C
		public static void Subtract(ref UInt128 a, ulong b)
		{
			if (a.s0 < b)
			{
				a.s1 -= 1UL;
			}
			a.s0 -= b;
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0072FB40 File Offset: 0x0072DD40
		public static void Subtract(ref UInt128 a, ref UInt128 b)
		{
			if (a.s0 < b.s0)
			{
				a.s1 -= 1UL;
			}
			a.s0 -= b.s0;
			a.s1 -= b.s1;
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0072FB90 File Offset: 0x0072DD90
		public static void Subtract(ref UInt128 a, UInt128 b)
		{
			UInt128.Subtract(ref a, ref b);
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0072FBA8 File Offset: 0x0072DDA8
		private static void Square64(out UInt128 w, ulong u)
		{
			ulong num = (ulong)((uint)u);
			ulong num2 = u >> 32;
			ulong num3 = num * num;
			uint num4 = (uint)num3;
			ulong num5 = num * num2;
			num3 = (num3 >> 32) + num5;
			ulong num6 = num3 >> 32;
			num3 = (ulong)((uint)num3) + num5;
			w.s0 = (num3 << 32 | (ulong)num4);
			w.s1 = (num3 >> 32) + num6 + num2 * num2;
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0072FBF8 File Offset: 0x0072DDF8
		private static void Multiply64(out UInt128 w, uint u, uint v)
		{
			w.s0 = (ulong)u * (ulong)v;
			w.s1 = 0UL;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0072FC20 File Offset: 0x0072DE20
		private static void Multiply64(out UInt128 w, ulong u, uint v)
		{
			ulong num = (ulong)((uint)u);
			ulong num2 = u >> 32;
			ulong num3 = num * (ulong)v;
			uint num4 = (uint)num3;
			num3 = (num3 >> 32) + num2 * (ulong)v;
			w.s0 = (num3 << 32 | (ulong)num4);
			w.s1 = num3 >> 32;
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0072FC60 File Offset: 0x0072DE60
		private static void Multiply64(out UInt128 w, ulong u, ulong v)
		{
			ulong num = (ulong)((uint)u);
			ulong num2 = u >> 32;
			ulong num3 = (ulong)((uint)v);
			ulong num4 = v >> 32;
			ulong num5 = num * num3;
			uint num6 = (uint)num5;
			num5 = (num5 >> 32) + num * num4;
			ulong num7 = num5 >> 32;
			num5 = (ulong)((uint)num5) + num2 * num3;
			w.s0 = (num5 << 32 | (ulong)num6);
			w.s1 = (num5 >> 32) + num7 + num2 * num4;
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0072FCC8 File Offset: 0x0072DEC8
		private static void Multiply64(out UInt128 w, ulong u, ulong v, ulong c)
		{
			ulong num = (ulong)((uint)u);
			ulong num2 = u >> 32;
			ulong num3 = (ulong)((uint)v);
			ulong num4 = v >> 32;
			ulong num5 = num * num3 + (ulong)((uint)c);
			uint num6 = (uint)num5;
			num5 = (num5 >> 32) + num * num4 + (c >> 32);
			ulong num7 = num5 >> 32;
			num5 = (ulong)((uint)num5) + num2 * num3;
			w.s0 = (num5 << 32 | (ulong)num6);
			w.s1 = (num5 >> 32) + num7 + num2 * num4;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0072FD38 File Offset: 0x0072DF38
		private static ulong MultiplyHigh64(ulong u, ulong v, ulong c)
		{
			ulong num = (ulong)((uint)u);
			ulong num2 = u >> 32;
			ulong num3 = (ulong)((uint)v);
			ulong num4 = v >> 32;
			ulong num5 = (num * num3 + (ulong)((uint)c) >> 32) + num * num4 + (c >> 32);
			ulong num6 = num5 >> 32;
			return ((ulong)((uint)num5) + num2 * num3 >> 32) + num6 + num2 * num4;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0072FD80 File Offset: 0x0072DF80
		private static void Multiply128(out UInt128 w, ref UInt128 u, uint v)
		{
			UInt128.Multiply64(out w, u.s0, v);
			w.s1 += u.s1 * (ulong)v;
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0072FDB0 File Offset: 0x0072DFB0
		private static void Multiply128(out UInt128 w, ref UInt128 u, ulong v)
		{
			UInt128.Multiply64(out w, u.s0, v);
			w.s1 += u.s1 * v;
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0072FDDC File Offset: 0x0072DFDC
		private static void Multiply128(out UInt128 w, ref UInt128 u, ref UInt128 v)
		{
			UInt128.Multiply64(out w, u.s0, v.s0);
			w.s1 += u.s1 * v.s0 + u.s0 * v.s1;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0072FE20 File Offset: 0x0072E020
		public static void Divide(out UInt128 w, ref UInt128 u, uint v)
		{
			if (u.s1 == 0UL)
			{
				UInt128.Divide64(out w, u.s0, (ulong)v);
				return;
			}
			if (u.s1 > 4294967295UL)
			{
				UInt128.Divide128(out w, ref u, v);
				return;
			}
			UInt128.Divide96(out w, ref u, v);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0072FE68 File Offset: 0x0072E068
		public static void Divide(out UInt128 w, ref UInt128 u, ulong v)
		{
			if (u.s1 == 0UL)
			{
				UInt128.Divide64(out w, u.s0, v);
				return;
			}
			uint num = (uint)v;
			if (v != (ulong)num)
			{
				if (u.s1 <= 4294967295UL)
				{
					UInt128.Divide96(out w, ref u, v);
					return;
				}
				UInt128.Divide128(out w, ref u, v);
				return;
			}
			else
			{
				if (u.s1 > 4294967295UL)
				{
					UInt128.Divide128(out w, ref u, num);
					return;
				}
				UInt128.Divide96(out w, ref u, num);
				return;
			}
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0072FED8 File Offset: 0x0072E0D8
		public static void Divide(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			if (UInt128.LessThan(ref a, ref b))
			{
				c = UInt128.Zero;
				return;
			}
			if (b.s1 == 0UL)
			{
				UInt128.Divide(out c, ref a, b.s0);
				return;
			}
			if (b.s1 <= 4294967295UL)
			{
				UInt128 @uint;
				UInt128.Create(out c, UInt128.DivRem96(out @uint, ref a, ref b));
				return;
			}
			UInt128 uint2;
			UInt128.Create(out c, (long)((ulong)UInt128.DivRem128(out uint2, ref a, ref b)));
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0072FF44 File Offset: 0x0072E144
		public static uint Remainder(ref UInt128 u, uint v)
		{
			if (u.s1 == 0UL)
			{
				return (uint)(u.s0 % (ulong)v);
			}
			if (u.s1 <= 4294967295UL)
			{
				return UInt128.Remainder96(ref u, v);
			}
			return UInt128.Remainder128(ref u, v);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0072FF84 File Offset: 0x0072E184
		public static ulong Remainder(ref UInt128 u, ulong v)
		{
			if (u.s1 == 0UL)
			{
				return u.s0 % v;
			}
			uint num = (uint)v;
			if (v != (ulong)num)
			{
				if (u.s1 <= 4294967295UL)
				{
					return UInt128.Remainder96(ref u, v);
				}
				return UInt128.Remainder128(ref u, v);
			}
			else
			{
				if (u.s1 <= 4294967295UL)
				{
					return (ulong)UInt128.Remainder96(ref u, num);
				}
				return (ulong)UInt128.Remainder128(ref u, num);
			}
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0072FFF0 File Offset: 0x0072E1F0
		public static void Remainder(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			if (UInt128.LessThan(ref a, ref b))
			{
				c = a;
				return;
			}
			if (b.s1 == 0UL)
			{
				UInt128.Create(out c, UInt128.Remainder(ref a, b.s0));
				return;
			}
			if (b.s1 > 4294967295UL)
			{
				UInt128.DivRem128(out c, ref a, ref b);
				return;
			}
			UInt128.DivRem96(out c, ref a, ref b);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x00730054 File Offset: 0x0072E254
		public static void Remainder(ref UInt128 a, ref UInt128 b)
		{
			UInt128 @uint = a;
			UInt128.Remainder(out a, ref @uint, ref b);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x00730074 File Offset: 0x0072E274
		private static void Remainder(out UInt128 c, ref UInt128.UInt256 a, ref UInt128 b)
		{
			if (b.r3 == 0U)
			{
				UInt128.Remainder192(out c, ref a, ref b);
				return;
			}
			UInt128.Remainder256(out c, ref a, ref b);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0073009C File Offset: 0x0072E29C
		private static void Divide64(out UInt128 w, ulong u, ulong v)
		{
			w.s1 = 0UL;
			w.s0 = u / v;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x007300C4 File Offset: 0x0072E2C4
		private static void Divide96(out UInt128 w, ref UInt128 u, uint v)
		{
			uint r = u.r2;
			uint num = r / v;
			ulong num2 = (ulong)(r - num * v) << 32 | (ulong)u.r1;
			uint num3 = (uint)(num2 / (ulong)v);
			uint num4 = (uint)((num2 - (ulong)(num3 * v) << 32 | (ulong)u.r0) / (ulong)v);
			w.s1 = (ulong)num;
			w.s0 = ((ulong)num3 << 32 | (ulong)num4);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0073011C File Offset: 0x0072E31C
		private static void Divide128(out UInt128 w, ref UInt128 u, uint v)
		{
			uint r = u.r3;
			uint num = r / v;
			ulong num2 = (ulong)(r - num * v) << 32 | (ulong)u.r2;
			uint num3 = (uint)(num2 / (ulong)v);
			ulong num4 = num2 - (ulong)(num3 * v) << 32 | (ulong)u.r1;
			uint num5 = (uint)(num4 / (ulong)v);
			uint num6 = (uint)((num4 - (ulong)(num5 * v) << 32 | (ulong)u.r0) / (ulong)v);
			w.s1 = ((ulong)num << 32 | (ulong)num3);
			w.s0 = ((ulong)num5 << 32 | (ulong)num6);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x00730190 File Offset: 0x0072E390
		private static void Divide96(out UInt128 w, ref UInt128 u, ulong v)
		{
			w.s1 = 0UL;
			w.s0 = 0UL;
			int num = UInt128.GetBitLength((uint)(v >> 32));
			int num2 = 32 - num;
			ulong num3 = v << num2;
			uint v2 = (uint)(num3 >> 32);
			uint v3 = (uint)num3;
			uint num4 = u.r0;
			uint num5 = u.r1;
			uint num6 = u.r2;
			uint u2 = 0U;
			if (num2 != 0)
			{
				u2 = num6 >> num;
				num6 = (num6 << num2 | num5 >> num);
				num5 = (num5 << num2 | num4 >> num);
				num4 <<= num2;
			}
			uint num7 = UInt128.DivRem(u2, ref num6, ref num5, v2, v3);
			uint num8 = UInt128.DivRem(num6, ref num5, ref num4, v2, v3);
			w.s0 = ((ulong)num7 << 32 | (ulong)num8);
			w.s1 = 0UL;
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x00730268 File Offset: 0x0072E468
		private static void Divide128(out UInt128 w, ref UInt128 u, ulong v)
		{
			w.s1 = 0UL;
			w.s0 = 0UL;
			int num = UInt128.GetBitLength((uint)(v >> 32));
			int num2 = 32 - num;
			ulong num3 = v << num2;
			uint v2 = (uint)(num3 >> 32);
			uint v3 = (uint)num3;
			uint num4 = u.r0;
			uint num5 = u.r1;
			uint num6 = u.r2;
			uint num7 = u.r3;
			uint u2 = 0U;
			if (num2 != 0)
			{
				u2 = num7 >> num;
				num7 = (num7 << num2 | num6 >> num);
				num6 = (num6 << num2 | num5 >> num);
				num5 = (num5 << num2 | num4 >> num);
				num4 <<= num2;
			}
			w.s1 = (ulong)UInt128.DivRem(u2, ref num7, ref num6, v2, v3);
			uint num8 = UInt128.DivRem(num7, ref num6, ref num5, v2, v3);
			uint num9 = UInt128.DivRem(num6, ref num5, ref num4, v2, v3);
			w.s0 = ((ulong)num8 << 32 | (ulong)num9);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x00730360 File Offset: 0x0072E560
		private static uint Remainder96(ref UInt128 u, uint v)
		{
			return (uint)((((ulong)(u.r2 % v) << 32 | (ulong)u.r1) % (ulong)v << 32 | (ulong)u.r0) % (ulong)v);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x00730394 File Offset: 0x0072E594
		private static uint Remainder128(ref UInt128 u, uint v)
		{
			return (uint)(((((ulong)(u.r3 % v) << 32 | (ulong)u.r2) % (ulong)v << 32 | (ulong)u.r1) % (ulong)v << 32 | (ulong)u.r0) % (ulong)v);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x007303D8 File Offset: 0x0072E5D8
		private static ulong Remainder96(ref UInt128 u, ulong v)
		{
			int num = UInt128.GetBitLength((uint)(v >> 32));
			int num2 = 32 - num;
			ulong num3 = v << num2;
			uint v2 = (uint)(num3 >> 32);
			uint v3 = (uint)num3;
			uint num4 = u.r0;
			uint num5 = u.r1;
			uint num6 = u.r2;
			uint u2 = 0U;
			if (num2 != 0)
			{
				u2 = num6 >> num;
				num6 = (num6 << num2 | num5 >> num);
				num5 = (num5 << num2 | num4 >> num);
				num4 <<= num2;
			}
			UInt128.DivRem(u2, ref num6, ref num5, v2, v3);
			UInt128.DivRem(num6, ref num5, ref num4, v2, v3);
			return ((ulong)num5 << 32 | (ulong)num4) >> num2;
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x00730480 File Offset: 0x0072E680
		private static ulong Remainder128(ref UInt128 u, ulong v)
		{
			int num = UInt128.GetBitLength((uint)(v >> 32));
			int num2 = 32 - num;
			ulong num3 = v << num2;
			uint v2 = (uint)(num3 >> 32);
			uint v3 = (uint)num3;
			uint num4 = u.r0;
			uint num5 = u.r1;
			uint num6 = u.r2;
			uint num7 = u.r3;
			uint u2 = 0U;
			if (num2 != 0)
			{
				u2 = num7 >> num;
				num7 = (num7 << num2 | num6 >> num);
				num6 = (num6 << num2 | num5 >> num);
				num5 = (num5 << num2 | num4 >> num);
				num4 <<= num2;
			}
			UInt128.DivRem(u2, ref num7, ref num6, v2, v3);
			UInt128.DivRem(num7, ref num6, ref num5, v2, v3);
			UInt128.DivRem(num6, ref num5, ref num4, v2, v3);
			return ((ulong)num5 << 32 | (ulong)num4) >> num2;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00730550 File Offset: 0x0072E750
		private static ulong DivRem96(out UInt128 rem, ref UInt128 a, ref UInt128 b)
		{
			int d = 32 - UInt128.GetBitLength(b.r2);
			UInt128 @uint;
			UInt128.LeftShift64(out @uint, ref b, d);
			uint u = (uint)UInt128.LeftShift64(out rem, ref a, d);
			uint r = @uint.r2;
			uint r2 = @uint.r1;
			uint r3 = @uint.r0;
			uint r4 = rem.r3;
			uint r5 = rem.r2;
			uint r6 = rem.r1;
			uint r7 = rem.r0;
			ulong num = (ulong)UInt128.DivRem(u, ref r4, ref r5, ref r6, r, r2, r3);
			uint num2 = UInt128.DivRem(r4, ref r5, ref r6, ref r7, r, r2, r3);
			UInt128.Create(out rem, r7, r6, r5, 0U);
			ulong result = num << 32 | (ulong)num2;
			UInt128.RightShift64(ref rem, d);
			return result;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x007305F8 File Offset: 0x0072E7F8
		private static uint DivRem128(out UInt128 rem, ref UInt128 a, ref UInt128 b)
		{
			int d = 32 - UInt128.GetBitLength(b.r3);
			UInt128 @uint;
			UInt128.LeftShift64(out @uint, ref b, d);
			uint u = (uint)UInt128.LeftShift64(out rem, ref a, d);
			uint r = rem.r3;
			uint r2 = rem.r2;
			uint r3 = rem.r1;
			uint r4 = rem.r0;
			uint result = UInt128.DivRem(u, ref r, ref r2, ref r3, ref r4, @uint.r3, @uint.r2, @uint.r1, @uint.r0);
			UInt128.Create(out rem, r4, r3, r2, r);
			UInt128.RightShift64(ref rem, d);
			return result;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00730684 File Offset: 0x0072E884
		private static void Remainder192(out UInt128 c, ref UInt128.UInt256 a, ref UInt128 b)
		{
			int d = 32 - UInt128.GetBitLength(b.r2);
			UInt128 @uint;
			UInt128.LeftShift64(out @uint, ref b, d);
			uint r = @uint.r2;
			uint r2 = @uint.r1;
			uint r3 = @uint.r0;
			UInt128.UInt256 uint2;
			UInt128.LeftShift64(out uint2, ref a, d);
			uint r4 = uint2.r6;
			uint r5 = uint2.r5;
			uint r6 = uint2.r4;
			uint r7 = uint2.r3;
			uint r8 = uint2.r2;
			uint r9 = uint2.r1;
			uint r10 = uint2.r0;
			UInt128.DivRem(r4, ref r5, ref r6, ref r7, r, r2, r3);
			UInt128.DivRem(r5, ref r6, ref r7, ref r8, r, r2, r3);
			UInt128.DivRem(r6, ref r7, ref r8, ref r9, r, r2, r3);
			UInt128.DivRem(r7, ref r8, ref r9, ref r10, r, r2, r3);
			UInt128.Create(out c, r10, r9, r8, 0U);
			UInt128.RightShift64(ref c, d);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00730764 File Offset: 0x0072E964
		private static void Remainder256(out UInt128 c, ref UInt128.UInt256 a, ref UInt128 b)
		{
			int d = 32 - UInt128.GetBitLength(b.r3);
			UInt128 @uint;
			UInt128.LeftShift64(out @uint, ref b, d);
			uint r = @uint.r3;
			uint r2 = @uint.r2;
			uint r3 = @uint.r1;
			uint r4 = @uint.r0;
			UInt128.UInt256 uint2;
			uint u = (uint)UInt128.LeftShift64(out uint2, ref a, d);
			uint r5 = uint2.r7;
			uint r6 = uint2.r6;
			uint r7 = uint2.r5;
			uint r8 = uint2.r4;
			uint r9 = uint2.r3;
			uint r10 = uint2.r2;
			uint r11 = uint2.r1;
			uint r12 = uint2.r0;
			UInt128.DivRem(u, ref r5, ref r6, ref r7, ref r8, r, r2, r3, r4);
			UInt128.DivRem(r5, ref r6, ref r7, ref r8, ref r9, r, r2, r3, r4);
			UInt128.DivRem(r6, ref r7, ref r8, ref r9, ref r10, r, r2, r3, r4);
			UInt128.DivRem(r7, ref r8, ref r9, ref r10, ref r11, r, r2, r3, r4);
			UInt128.DivRem(r8, ref r9, ref r10, ref r11, ref r12, r, r2, r3, r4);
			UInt128.Create(out c, r12, r11, r10, r9);
			UInt128.RightShift64(ref c, d);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00730880 File Offset: 0x0072EA80
		private static ulong Q(uint u0, uint u1, uint u2, uint v1, uint v2)
		{
			ulong num = (ulong)u0 << 32 | (ulong)u1;
			ulong num2 = (u0 == v1) ? 4294967295UL : (num / (ulong)v1);
			ulong num3 = num - num2 * (ulong)v1;
			if (num3 == (ulong)((uint)num3))
			{
				if ((ulong)v2 * num2 > (num3 << 32 | (ulong)u2))
				{
					num2 -= 1UL;
					num3 += (ulong)v1;
					if (num3 == (ulong)((uint)num3) && (ulong)v2 * num2 > (num3 << 32 | (ulong)u2))
					{
						num2 -= 1UL;
						num3 += (ulong)v1;
					}
				}
			}
			return num2;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00730900 File Offset: 0x0072EB00
		private static uint DivRem(uint u0, ref uint u1, ref uint u2, uint v1, uint v2)
		{
			ulong num = UInt128.Q(u0, u1, u2, v1, v2);
			ulong num2 = num * (ulong)v2;
			long num3 = (long)((ulong)u2 - (ulong)((uint)num2));
			num2 >>= 32;
			u2 = (uint)num3;
			num3 >>= 32;
			num2 += num * (ulong)v1;
			num3 += (long)((ulong)u1 - (ulong)((uint)num2));
			num2 >>= 32;
			u1 = (uint)num3;
			num3 >>= 32;
			num3 += (long)((ulong)u0 - (ulong)((uint)num2));
			if (num3 != 0L)
			{
				num -= 1UL;
				num2 = (ulong)u2 + (ulong)v2;
				u2 = (uint)num2;
				num2 >>= 32;
				num2 += (ulong)u1 + (ulong)v1;
				u1 = (uint)num2;
			}
			return (uint)num;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00730990 File Offset: 0x0072EB90
		private static uint DivRem(uint u0, ref uint u1, ref uint u2, ref uint u3, uint v1, uint v2, uint v3)
		{
			ulong num = UInt128.Q(u0, u1, u2, v1, v2);
			ulong num2 = num * (ulong)v3;
			long num3 = (long)((ulong)u3 - (ulong)((uint)num2));
			num2 >>= 32;
			u3 = (uint)num3;
			num3 >>= 32;
			num2 += num * (ulong)v2;
			num3 += (long)((ulong)u2 - (ulong)((uint)num2));
			num2 >>= 32;
			u2 = (uint)num3;
			num3 >>= 32;
			num2 += num * (ulong)v1;
			num3 += (long)((ulong)u1 - (ulong)((uint)num2));
			num2 >>= 32;
			u1 = (uint)num3;
			num3 >>= 32;
			num3 += (long)((ulong)u0 - (ulong)((uint)num2));
			if (num3 != 0L)
			{
				num -= 1UL;
				num2 = (ulong)u3 + (ulong)v3;
				u3 = (uint)num2;
				num2 >>= 32;
				num2 += (ulong)u2 + (ulong)v2;
				u2 = (uint)num2;
				num2 >>= 32;
				num2 += (ulong)u1 + (ulong)v1;
				u1 = (uint)num2;
			}
			return (uint)num;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00730A54 File Offset: 0x0072EC54
		private static uint DivRem(uint u0, ref uint u1, ref uint u2, ref uint u3, ref uint u4, uint v1, uint v2, uint v3, uint v4)
		{
			ulong num = UInt128.Q(u0, u1, u2, v1, v2);
			ulong num2 = num * (ulong)v4;
			long num3 = (long)((ulong)u4 - (ulong)((uint)num2));
			num2 >>= 32;
			u4 = (uint)num3;
			num3 >>= 32;
			num2 += num * (ulong)v3;
			num3 += (long)((ulong)u3 - (ulong)((uint)num2));
			num2 >>= 32;
			u3 = (uint)num3;
			num3 >>= 32;
			num2 += num * (ulong)v2;
			num3 += (long)((ulong)u2 - (ulong)((uint)num2));
			num2 >>= 32;
			u2 = (uint)num3;
			num3 >>= 32;
			num2 += num * (ulong)v1;
			num3 += (long)((ulong)u1 - (ulong)((uint)num2));
			num2 >>= 32;
			u1 = (uint)num3;
			num3 >>= 32;
			num3 += (long)((ulong)u0 - (ulong)((uint)num2));
			if (num3 != 0L)
			{
				num -= 1UL;
				num2 = (ulong)u4 + (ulong)v4;
				u4 = (uint)num2;
				num2 >>= 32;
				num2 += (ulong)u3 + (ulong)v3;
				u3 = (uint)num2;
				num2 >>= 32;
				num2 += (ulong)u2 + (ulong)v2;
				u2 = (uint)num2;
				num2 >>= 32;
				num2 += (ulong)u1 + (ulong)v1;
				u1 = (uint)num2;
			}
			return (uint)num;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00730B50 File Offset: 0x0072ED50
		public static void ModAdd(out UInt128 c, ref UInt128 a, ref UInt128 b, ref UInt128 modulus)
		{
			UInt128.Add(out c, ref a, ref b);
			if (!UInt128.LessThan(ref c, ref modulus) || (UInt128.LessThan(ref c, ref a) && UInt128.LessThan(ref c, ref b)))
			{
				UInt128.Subtract(ref c, ref modulus);
			}
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00730B88 File Offset: 0x0072ED88
		public static void ModSub(out UInt128 c, ref UInt128 a, ref UInt128 b, ref UInt128 modulus)
		{
			UInt128.Subtract(out c, ref a, ref b);
			if (UInt128.LessThan(ref a, ref b))
			{
				UInt128.Add(ref c, ref modulus);
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x00730BB0 File Offset: 0x0072EDB0
		public static void ModMul(out UInt128 c, ref UInt128 a, ref UInt128 b, ref UInt128 modulus)
		{
			if (modulus.s1 == 0UL)
			{
				UInt128 @uint;
				UInt128.Multiply64(out @uint, a.s0, b.s0);
				UInt128.Create(out c, UInt128.Remainder(ref @uint, modulus.s0));
				return;
			}
			UInt128.UInt256 uint2;
			UInt128.Multiply(out uint2, ref a, ref b);
			UInt128.Remainder(out c, ref uint2, ref modulus);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x00730C00 File Offset: 0x0072EE00
		public static void ModMul(ref UInt128 a, ref UInt128 b, ref UInt128 modulus)
		{
			if (modulus.s1 == 0UL)
			{
				UInt128 @uint;
				UInt128.Multiply64(out @uint, a.s0, b.s0);
				UInt128.Create(out a, UInt128.Remainder(ref @uint, modulus.s0));
				return;
			}
			UInt128.UInt256 uint2;
			UInt128.Multiply(out uint2, ref a, ref b);
			UInt128.Remainder(out a, ref uint2, ref modulus);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x00730C50 File Offset: 0x0072EE50
		public static void ModPow(out UInt128 result, ref UInt128 value, ref UInt128 exponent, ref UInt128 modulus)
		{
			result = UInt128.one;
			UInt128 @uint = value;
			ulong num = exponent.s0;
			if (exponent.s1 != 0UL)
			{
				for (int i = 0; i < 64; i++)
				{
					if ((num & 1UL) != 0UL)
					{
						UInt128.ModMul(ref result, ref @uint, ref modulus);
					}
					UInt128.ModMul(ref @uint, ref @uint, ref modulus);
					num >>= 1;
				}
				num = exponent.s1;
			}
			while (num != 0UL)
			{
				if ((num & 1UL) != 0UL)
				{
					UInt128.ModMul(ref result, ref @uint, ref modulus);
				}
				if (num != 1UL)
				{
					UInt128.ModMul(ref @uint, ref @uint, ref modulus);
				}
				num >>= 1;
			}
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x00730CF0 File Offset: 0x0072EEF0
		public static void Shift(out UInt128 c, ref UInt128 a, int d)
		{
			if (d < 0)
			{
				UInt128.RightShift(out c, ref a, -d);
				return;
			}
			UInt128.LeftShift(out c, ref a, d);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x00730D14 File Offset: 0x0072EF14
		public static void ArithmeticShift(out UInt128 c, ref UInt128 a, int d)
		{
			if (d < 0)
			{
				UInt128.ArithmeticRightShift(out c, ref a, -d);
				return;
			}
			UInt128.LeftShift(out c, ref a, d);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00730D38 File Offset: 0x0072EF38
		public static ulong LeftShift64(out UInt128 c, ref UInt128 a, int d)
		{
			if (d == 0)
			{
				c = a;
				return 0UL;
			}
			int num = 64 - d;
			c.s1 = (a.s1 << d | a.s0 >> num);
			c.s0 = a.s0 << d;
			return a.s1 >> num;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00730D9C File Offset: 0x0072EF9C
		private static ulong LeftShift64(out UInt128.UInt256 c, ref UInt128.UInt256 a, int d)
		{
			if (d == 0)
			{
				c = a;
				return 0UL;
			}
			int num = 64 - d;
			c.s3 = (a.s3 << d | a.s2 >> num);
			c.s2 = (a.s2 << d | a.s1 >> num);
			c.s1 = (a.s1 << d | a.s0 >> num);
			c.s0 = a.s0 << d;
			return a.s3 >> num;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00730E3C File Offset: 0x0072F03C
		public static void LeftShift(out UInt128 c, ref UInt128 a, int b)
		{
			if (b < 64)
			{
				UInt128.LeftShift64(out c, ref a, b);
				return;
			}
			if (b != 64)
			{
				c.s0 = 0UL;
				c.s1 = a.s0 << b - 64;
				return;
			}
			c.s0 = 0UL;
			c.s1 = a.s0;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x00730E9C File Offset: 0x0072F09C
		public static void RightShift64(out UInt128 c, ref UInt128 a, int b)
		{
			if (b == 0)
			{
				c = a;
				return;
			}
			c.s0 = (a.s0 >> b | a.s1 << 64 - b);
			c.s1 = a.s1 >> b;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x00730EEC File Offset: 0x0072F0EC
		public static void RightShift(out UInt128 c, ref UInt128 a, int b)
		{
			if (b < 64)
			{
				UInt128.RightShift64(out c, ref a, b);
				return;
			}
			if (b != 64)
			{
				c.s0 = a.s1 >> b - 64;
				c.s1 = 0UL;
				return;
			}
			c.s0 = a.s1;
			c.s1 = 0UL;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x00730F4C File Offset: 0x0072F14C
		public static void ArithmeticRightShift64(out UInt128 c, ref UInt128 a, int b)
		{
			if (b == 0)
			{
				c = a;
				return;
			}
			c.s0 = (a.s0 >> b | a.s1 << 64 - b);
			c.s1 = a.s1 >> b;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x00730F9C File Offset: 0x0072F19C
		public static void ArithmeticRightShift(out UInt128 c, ref UInt128 a, int b)
		{
			if (b < 64)
			{
				UInt128.ArithmeticRightShift64(out c, ref a, b);
				return;
			}
			if (b != 64)
			{
				c.s0 = a.s1 >> b - 64;
				c.s1 = a.s1 >> 63;
				return;
			}
			c.s0 = a.s1;
			c.s1 = a.s1 >> 63;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00730FFC File Offset: 0x0072F1FC
		public static void And(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			c.s0 = (a.s0 & b.s0);
			c.s1 = (a.s1 & b.s1);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00731030 File Offset: 0x0072F230
		public static void Or(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			c.s0 = (a.s0 | b.s0);
			c.s1 = (a.s1 | b.s1);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00731064 File Offset: 0x0072F264
		public static void ExclusiveOr(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			c.s0 = (a.s0 ^ b.s0);
			c.s1 = (a.s1 ^ b.s1);
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00731098 File Offset: 0x0072F298
		public static void Not(out UInt128 c, ref UInt128 a)
		{
			c.s0 = ~a.s0;
			c.s1 = ~a.s1;
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x007310C0 File Offset: 0x0072F2C0
		public static void Negate(ref UInt128 a)
		{
			ulong num = a.s0;
			a.s0 = 0UL - num;
			a.s1 = 0UL - a.s1;
			if (num > 0UL)
			{
				a.s1 -= 1UL;
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0073111C File Offset: 0x0072F31C
		public static void Negate(out UInt128 c, ref UInt128 a)
		{
			c.s0 = 0UL - a.s0;
			c.s1 = 0UL - a.s1;
			if (a.s0 > 0UL)
			{
				c.s1 -= 1UL;
			}
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0073117C File Offset: 0x0072F37C
		public static void Pow(out UInt128 result, ref UInt128 value, uint exponent)
		{
			result = UInt128.one;
			while (exponent != 0U)
			{
				if ((exponent & 1U) != 0U)
				{
					UInt128 @uint = result;
					UInt128.Multiply(out result, ref @uint, ref value);
				}
				if (exponent != 1U)
				{
					UInt128 uint2 = value;
					UInt128.Square(out value, ref uint2);
				}
				exponent >>= 1;
			}
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x007311C8 File Offset: 0x0072F3C8
		public static UInt128 Pow(UInt128 value, uint exponent)
		{
			UInt128 result;
			UInt128.Pow(out result, ref value, exponent);
			return result;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x007311E0 File Offset: 0x0072F3E0
		public static ulong FloorSqrt(UInt128 a)
		{
			if (a.s1 == 0UL && a.s0 <= UInt128.maxRep)
			{
				return (ulong)Math.Sqrt(a.s0);
			}
			ulong num = (ulong)Math.Sqrt(UInt128.ConvertToDouble(ref a));
			if (a.s1 < UInt128.maxRepSquaredHigh)
			{
				UInt128 @uint;
				UInt128.Square64(out @uint, num);
				ulong num2 = a.s0 - @uint.s0;
				if (num2 > 9223372036854775807UL)
				{
					num -= 1UL;
				}
				else if (num2 - (num << 1) <= 9223372036854775807UL)
				{
					num += 1UL;
				}
				return num;
			}
			return UInt128.FloorSqrt(ref a, num);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0073128C File Offset: 0x0072F48C
		public static ulong CeilingSqrt(UInt128 a)
		{
			if (a.s1 == 0UL && a.s0 <= UInt128.maxRep)
			{
				return (ulong)Math.Ceiling(Math.Sqrt(a.s0));
			}
			ulong num = (ulong)Math.Ceiling(Math.Sqrt(UInt128.ConvertToDouble(ref a)));
			if (!(a.s1 < UInt128.maxRepSquaredHigh))
			{
				num = UInt128.FloorSqrt(ref a, num);
				UInt128 @uint;
				UInt128.Square64(out @uint, num);
				if (@uint.S0 == a.S0)
				{
					if (@uint.S1 == a.S1)
					{
						return num;
					}
				}
				num += 1UL;
				return num;
			}
			UInt128 uint2;
			UInt128.Square64(out uint2, num);
			ulong num2 = uint2.s0 - a.s0;
			if (num2 <= 9223372036854775807UL)
			{
				if (num2 - (num << 1) <= 9223372036854775807UL)
				{
					num -= 1UL;
				}
			}
			else
			{
				num += 1UL;
			}
			return num;
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00731378 File Offset: 0x0072F578
		private static ulong FloorSqrt(ref UInt128 a, ulong s)
		{
			ulong num = 0UL;
			ulong num2;
			for (;;)
			{
				UInt128 @uint;
				UInt128.Divide(out @uint, ref a, s);
				UInt128 uint2;
				UInt128.Add(out uint2, ref @uint, s);
				num2 = uint2.S0 >> 1;
				if (uint2.S1 != 0UL)
				{
					num2 |= 9223372036854775808UL;
				}
				if (num2 == num)
				{
					break;
				}
				num = s;
				s = num2;
			}
			if (num2 < s)
			{
				s = num2;
			}
			return s;
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x007313DC File Offset: 0x0072F5DC
		public static ulong FloorCbrt(UInt128 a)
		{
			ulong num = (ulong)Math.Pow(UInt128.ConvertToDouble(ref a), 0.3333333333333333);
			UInt128 b;
			UInt128.Cube(out b, num);
			if (a < b)
			{
				num -= 1UL;
			}
			else
			{
				UInt128 @uint;
				UInt128.Multiply64(out @uint, 3UL * num, num + 1UL);
				UInt128 uint2;
				UInt128.Subtract(out uint2, ref a, ref b);
				if (UInt128.LessThan(ref @uint, ref uint2))
				{
					num += 1UL;
				}
			}
			return num;
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x00731460 File Offset: 0x0072F660
		public static ulong CeilingCbrt(UInt128 a)
		{
			ulong num = (ulong)Math.Ceiling(Math.Pow(UInt128.ConvertToDouble(ref a), 0.3333333333333333));
			UInt128 a2;
			UInt128.Cube(out a2, num);
			if (a2 < a)
			{
				num += 1UL;
			}
			else
			{
				UInt128 @uint;
				UInt128.Multiply64(out @uint, 3UL * num, num + 1UL);
				UInt128 uint2;
				UInt128.Subtract(out uint2, ref a2, ref a);
				if (UInt128.LessThan(ref @uint, ref uint2))
				{
					num -= 1UL;
				}
			}
			return num;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x007314E8 File Offset: 0x0072F6E8
		public static UInt128 Min(UInt128 a, UInt128 b)
		{
			if (UInt128.LessThan(ref a, ref b))
			{
				return a;
			}
			return b;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00731504 File Offset: 0x0072F704
		public static UInt128 Max(UInt128 a, UInt128 b)
		{
			if (UInt128.LessThan(ref b, ref a))
			{
				return a;
			}
			return b;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00731520 File Offset: 0x0072F720
		public static double Log(UInt128 a)
		{
			return UInt128.Log(a, 2.718281828459045);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0073153C File Offset: 0x0072F73C
		public static double Log10(UInt128 a)
		{
			return UInt128.Log(a, 10.0);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00731558 File Offset: 0x0072F758
		public static double Log(UInt128 a, double b)
		{
			return Math.Log(UInt128.ConvertToDouble(ref a), b);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0072EBA4 File Offset: 0x0072CDA4
		public static UInt128 Add(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Add(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0072EC10 File Offset: 0x0072CE10
		public static UInt128 Subtract(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Subtract(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0072ECEC File Offset: 0x0072CEEC
		public static UInt128 Multiply(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Multiply(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0072ED20 File Offset: 0x0072CF20
		public static UInt128 Divide(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Divide(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0072ED6C File Offset: 0x0072CF6C
		public static UInt128 Remainder(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.Remainder(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x00731574 File Offset: 0x0072F774
		public static UInt128 DivRem(UInt128 a, UInt128 b, out UInt128 remainder)
		{
			UInt128 result;
			UInt128.Divide(out result, ref a, ref b);
			UInt128.Remainder(out remainder, ref a, ref b);
			return result;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00731598 File Offset: 0x0072F798
		public static UInt128 ModAdd(UInt128 a, UInt128 b, UInt128 modulus)
		{
			UInt128 result;
			UInt128.ModAdd(out result, ref a, ref b, ref modulus);
			return result;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x007315B4 File Offset: 0x0072F7B4
		public static UInt128 ModSub(UInt128 a, UInt128 b, UInt128 modulus)
		{
			UInt128 result;
			UInt128.ModSub(out result, ref a, ref b, ref modulus);
			return result;
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x007315D0 File Offset: 0x0072F7D0
		public static UInt128 ModMul(UInt128 a, UInt128 b, UInt128 modulus)
		{
			UInt128 result;
			UInt128.ModMul(out result, ref a, ref b, ref modulus);
			return result;
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x007315EC File Offset: 0x0072F7EC
		public static UInt128 ModPow(UInt128 value, UInt128 exponent, UInt128 modulus)
		{
			UInt128 result;
			UInt128.ModPow(out result, ref value, ref exponent, ref modulus);
			return result;
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00731608 File Offset: 0x0072F808
		public static UInt128 Negate(UInt128 a)
		{
			UInt128 result;
			UInt128.Negate(out result, ref a);
			return result;
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00731620 File Offset: 0x0072F820
		public static UInt128 GreatestCommonDivisor(UInt128 a, UInt128 b)
		{
			UInt128 result;
			UInt128.GreatestCommonDivisor(out result, ref a, ref b);
			return result;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0073163C File Offset: 0x0072F83C
		private static void RightShift64(ref UInt128 c, int d)
		{
			if (d == 0)
			{
				return;
			}
			c.s0 = (c.s1 << 64 - d | c.s0 >> d);
			c.s1 >>= d;
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0073167C File Offset: 0x0072F87C
		public static void RightShift(ref UInt128 c, int d)
		{
			if (d < 64)
			{
				UInt128.RightShift64(ref c, d);
				return;
			}
			c.s0 = c.s1 >> d - 64;
			c.s1 = 0UL;
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x007316BC File Offset: 0x0072F8BC
		public static void Shift(ref UInt128 c, int d)
		{
			if (d < 0)
			{
				UInt128.RightShift(ref c, -d);
				return;
			}
			UInt128.LeftShift(ref c, d);
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x007316E0 File Offset: 0x0072F8E0
		public static void ArithmeticShift(ref UInt128 c, int d)
		{
			if (d < 0)
			{
				UInt128.ArithmeticRightShift(ref c, -d);
				return;
			}
			UInt128.LeftShift(ref c, d);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00731704 File Offset: 0x0072F904
		public static void RightShift(ref UInt128 c)
		{
			c.s0 = (c.s1 << 63 | c.s0 >> 1);
			c.s1 >>= 1;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00731734 File Offset: 0x0072F934
		private static void ArithmeticRightShift64(ref UInt128 c, int d)
		{
			if (d == 0)
			{
				return;
			}
			c.s0 = (c.s1 << 64 - d | c.s0 >> d);
			c.s1 >>= d;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00731778 File Offset: 0x0072F978
		public static void ArithmeticRightShift(ref UInt128 c, int d)
		{
			if (d < 64)
			{
				UInt128.ArithmeticRightShift64(ref c, d);
				return;
			}
			c.s0 = c.s1 >> d - 64;
			c.s1 = 0UL;
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x007317B8 File Offset: 0x0072F9B8
		public static void ArithmeticRightShift(ref UInt128 c)
		{
			c.s0 = (c.s1 << 63 | c.s0 >> 1);
			c.s1 >>= 1;
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x007317EC File Offset: 0x0072F9EC
		private static ulong LeftShift64(ref UInt128 c, int d)
		{
			if (d == 0)
			{
				return 0UL;
			}
			int num = 64 - d;
			ulong result = c.s1 >> num;
			c.s1 = (c.s1 << d | c.s0 >> num);
			c.s0 <<= d;
			return result;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00731844 File Offset: 0x0072FA44
		public static void LeftShift(ref UInt128 c, int d)
		{
			if (d < 64)
			{
				UInt128.LeftShift64(ref c, d);
				return;
			}
			c.s1 = c.s0 << d - 64;
			c.s0 = 0UL;
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00731884 File Offset: 0x0072FA84
		public static void LeftShift(ref UInt128 c)
		{
			c.s1 = (c.s1 << 1 | c.s0 >> 63);
			c.s0 <<= 1;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x007318B4 File Offset: 0x0072FAB4
		public static void Swap(ref UInt128 a, ref UInt128 b)
		{
			ulong num = a.s0;
			ulong num2 = a.s1;
			a.s0 = b.s0;
			a.s1 = b.s1;
			b.s0 = num;
			b.s1 = num2;
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x007318F8 File Offset: 0x0072FAF8
		public static void GreatestCommonDivisor(out UInt128 c, ref UInt128 a, ref UInt128 b)
		{
			UInt128 @uint;
			UInt128 uint2;
			if (a.s1 == 0UL != (b.s1 == 0UL) && !a.IsZero && !b.IsZero)
			{
				if (!UInt128.LessThan(ref a, ref b))
				{
					@uint = b;
					UInt128.Remainder(out uint2, ref a, ref b);
				}
				else
				{
					uint2 = a;
					UInt128.Remainder(out @uint, ref b, ref a);
				}
			}
			else
			{
				uint2 = a;
				@uint = b;
			}
			if (uint2.IsZero)
			{
				c = @uint;
				return;
			}
			if (@uint.IsZero)
			{
				c = uint2;
				return;
			}
			if (UInt128.LessThan(ref uint2, ref @uint))
			{
				UInt128.Swap(ref uint2, ref @uint);
			}
			while (uint2.s1 != 0UL && !b.IsZero)
			{
				int d = 63 - UInt128.GetBitLength(uint2.s1);
				UInt128 uint3;
				UInt128.Shift(out uint3, ref uint2, d);
				UInt128 uint4;
				UInt128.Shift(out uint4, ref @uint, d);
				long num = (long)uint3.s1;
				long num2 = (long)uint4.s1;
				if (num2 != 0L)
				{
					long num3 = 1L;
					long num4 = 0L;
					long num5 = 0L;
					long num6 = 1L;
					bool flag = true;
					for (;;)
					{
						long num7 = num / num2;
						long num8 = num3 - num7 * num5;
						long num9 = num4 - num7 * num6;
						long num10 = num;
						num = num2;
						num2 = num10 - num7 * num2;
						if (flag = !flag)
						{
							if (num2 < -num8)
							{
								break;
							}
							if (num - num2 < num9 - num6)
							{
								break;
							}
						}
						else if (num2 < -num9 || num - num2 < num8 - num5)
						{
							break;
						}
						num3 = num5;
						num4 = num6;
						num5 = num8;
						num6 = num9;
					}
					IL_1A0:
					if (num3 == 1L)
					{
						if (num4 == 0L)
						{
							UInt128 uint5;
							UInt128.Remainder(out uint5, ref uint2, ref @uint);
							uint2 = @uint;
							@uint = uint5;
							continue;
						}
					}
					UInt128 uint6;
					UInt128 uint7;
					if (flag)
					{
						UInt128.AddProducts(out uint6, num4, ref @uint, num3, ref uint2);
						UInt128.AddProducts(out uint7, num5, ref uint2, num6, ref @uint);
					}
					else
					{
						UInt128.AddProducts(out uint6, num3, ref uint2, num4, ref @uint);
						UInt128.AddProducts(out uint7, num6, ref @uint, num5, ref uint2);
					}
					uint2 = uint6;
					@uint = uint7;
					continue;
					goto IL_1A0;
				}
				UInt128 uint8;
				UInt128.Remainder(out uint8, ref uint2, ref @uint);
				uint2 = @uint;
				@uint = uint8;
			}
			if (@uint.IsZero)
			{
				c = uint2;
				return;
			}
			ulong num11 = uint2.s0;
			ulong num12 = @uint.s0;
			while (num11 > 4294967295UL && num12 != 0UL)
			{
				ulong num13 = num11 % num12;
				num11 = num12;
				num12 = num13;
			}
			if (num12 != 0UL)
			{
				uint num14 = (uint)num11;
				uint num16;
				for (uint num15 = (uint)num12; num15 != 0U; num15 = num16)
				{
					num16 = num14 % num15;
					num14 = num15;
				}
				UInt128.Create(out c, (long)((ulong)num14));
				return;
			}
			UInt128.Create(out c, num11);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00731B98 File Offset: 0x0072FD98
		private static void AddProducts(out UInt128 result, long x, ref UInt128 u, long y, ref UInt128 v)
		{
			UInt128 @uint;
			UInt128.Multiply(out @uint, ref u, (ulong)x);
			UInt128 uint2;
			UInt128.Multiply(out uint2, ref v, (ulong)(-(ulong)y));
			UInt128.Subtract(out result, ref @uint, ref uint2);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00731BC4 File Offset: 0x0072FDC4
		public static int Compare(UInt128 a, UInt128 b)
		{
			return a.CompareTo(b);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00731BDC File Offset: 0x0072FDDC
		private static int GetBitLength(uint value)
		{
			uint num = value >> 16;
			if (num != 0U)
			{
				uint num2 = num >> 8;
				if (num2 == 0U)
				{
					return (int)(UInt128.bitLength[(int)num] + 16);
				}
				return (int)(UInt128.bitLength[(int)num2] + 24);
			}
			else
			{
				uint num3 = value >> 8;
				if (num3 == 0U)
				{
					return (int)UInt128.bitLength[(int)value];
				}
				return (int)(UInt128.bitLength[(int)num3] + 8);
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00731C28 File Offset: 0x0072FE28
		private static int GetBitLength(ulong value)
		{
			ulong num = value >> 32;
			if (num != 0UL)
			{
				return UInt128.GetBitLength((uint)num) + 32;
			}
			return UInt128.GetBitLength((uint)value);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00731C50 File Offset: 0x0072FE50
		public static void Reduce(out UInt128 w, ref UInt128 u, ref UInt128 v, ref UInt128 n, ulong k0)
		{
			UInt128 @uint;
			UInt128.Multiply64(out @uint, u.s0, v.s0);
			ulong num = @uint.s0;
			UInt128.Multiply64(out @uint, u.s1, v.s0, @uint.s1);
			ulong b = @uint.s0;
			ulong num2 = @uint.s1;
			ulong u2 = num * k0;
			UInt128.Multiply64(out @uint, u2, n.s1, UInt128.MultiplyHigh64(u2, n.s0, num));
			UInt128.Add(ref @uint, b);
			num = @uint.s0;
			UInt128.Add(out @uint, @uint.s1, num2);
			b = @uint.s0;
			num2 = @uint.s1;
			UInt128.Multiply64(out @uint, u.s0, v.s1, num);
			num = @uint.s0;
			UInt128.Multiply64(out @uint, u.s1, v.s1, @uint.s1);
			UInt128.Add(ref @uint, b);
			b = @uint.s0;
			UInt128.Add(out @uint, @uint.s1, num2);
			num2 = @uint.s0;
			ulong num3 = @uint.s1;
			u2 = num * k0;
			UInt128.Multiply64(out @uint, u2, n.s1, UInt128.MultiplyHigh64(u2, n.s0, num));
			UInt128.Add(ref @uint, b);
			num = @uint.s0;
			UInt128.Add(out @uint, @uint.s1, num2);
			b = @uint.s0;
			num2 = num3 + @uint.s1;
			UInt128.Create(out w, num, b);
			if (num2 != 0UL || !UInt128.LessThan(ref w, ref n))
			{
				UInt128.Subtract(ref w, ref n);
			}
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00731DB4 File Offset: 0x0072FFB4
		public static void Reduce(out UInt128 w, ref UInt128 t, ref UInt128 n, ulong k0)
		{
			ulong num = t.s0;
			ulong b = t.s1;
			ulong num2 = 0UL;
			for (int i = 0; i < 2; i++)
			{
				ulong u = num * k0;
				UInt128 @uint;
				UInt128.Multiply64(out @uint, u, n.s1, UInt128.MultiplyHigh64(u, n.s0, num));
				UInt128.Add(ref @uint, b);
				num = @uint.s0;
				UInt128.Add(out @uint, @uint.s1, num2);
				b = @uint.s0;
				num2 = @uint.s1;
			}
			UInt128.Create(out w, num, b);
			if (num2 != 0UL || !UInt128.LessThan(ref w, ref n))
			{
				UInt128.Subtract(ref w, ref n);
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00731E54 File Offset: 0x00730054
		public static UInt128 Reduce(UInt128 u, UInt128 v, UInt128 n, ulong k0)
		{
			UInt128 result;
			UInt128.Reduce(out result, ref u, ref v, ref n, k0);
			return result;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x00731E70 File Offset: 0x00730070
		public static UInt128 Reduce(UInt128 t, UInt128 n, ulong k0)
		{
			UInt128 result;
			UInt128.Reduce(out result, ref t, ref n, k0);
			return result;
		}

		// Token: 0x04000F5A RID: 3930
		private ulong s0;

		// Token: 0x04000F5B RID: 3931
		private ulong s1;

		// Token: 0x04000F5C RID: 3932
		private static readonly UInt128 maxValue = ~(UInt128)0;

		// Token: 0x04000F5D RID: 3933
		private static readonly UInt128 zero = (UInt128)0;

		// Token: 0x04000F5E RID: 3934
		private static readonly UInt128 one = (UInt128)1;

		// Token: 0x04000F5F RID: 3935
		private const int maxRepShift = 53;

		// Token: 0x04000F60 RID: 3936
		private static readonly ulong maxRep = 9007199254740992UL;

		// Token: 0x04000F61 RID: 3937
		private static readonly UInt128 maxRepSquaredHigh = 4398046511104UL;

		// Token: 0x04000F62 RID: 3938
		private static byte[] bitLength = Enumerable.Range(0, 256).Select(delegate(int value)
		{
			int num = 0;
			while (value != 0)
			{
				value >>= 1;
				num++;
			}
			return (byte)num;
		}).ToArray<byte>();

		// Token: 0x02000135 RID: 309
		private struct UInt256
		{
			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06001CCB RID: 7371 RVA: 0x00731F0C File Offset: 0x0073010C
			public uint r0
			{
				get
				{
					return (uint)this.s0;
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06001CCC RID: 7372 RVA: 0x00731F20 File Offset: 0x00730120
			public uint r1
			{
				get
				{
					return (uint)(this.s0 >> 32);
				}
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06001CCD RID: 7373 RVA: 0x00731F38 File Offset: 0x00730138
			public uint r2
			{
				get
				{
					return (uint)this.s1;
				}
			}

			// Token: 0x17000426 RID: 1062
			// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00731F4C File Offset: 0x0073014C
			public uint r3
			{
				get
				{
					return (uint)(this.s1 >> 32);
				}
			}

			// Token: 0x17000427 RID: 1063
			// (get) Token: 0x06001CCF RID: 7375 RVA: 0x00731F64 File Offset: 0x00730164
			public uint r4
			{
				get
				{
					return (uint)this.s2;
				}
			}

			// Token: 0x17000428 RID: 1064
			// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00731F78 File Offset: 0x00730178
			public uint r5
			{
				get
				{
					return (uint)(this.s2 >> 32);
				}
			}

			// Token: 0x17000429 RID: 1065
			// (get) Token: 0x06001CD1 RID: 7377 RVA: 0x00731F90 File Offset: 0x00730190
			public uint r6
			{
				get
				{
					return (uint)this.s3;
				}
			}

			// Token: 0x1700042A RID: 1066
			// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x00731FA4 File Offset: 0x007301A4
			public uint r7
			{
				get
				{
					return (uint)(this.s3 >> 32);
				}
			}

			// Token: 0x1700042B RID: 1067
			// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x00731FBC File Offset: 0x007301BC
			public UInt128 t0
			{
				get
				{
					UInt128 result;
					UInt128.Create(out result, this.s0, this.s1);
					return result;
				}
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x00731FE0 File Offset: 0x007301E0
			public UInt128 t1
			{
				get
				{
					UInt128 result;
					UInt128.Create(out result, this.s2, this.s3);
					return result;
				}
			}

			// Token: 0x06001CD5 RID: 7381 RVA: 0x00732004 File Offset: 0x00730204
			public static implicit operator BigInteger(UInt128.UInt256 a)
			{
				return a.s3 << 192 | a.s2 << 128 | a.s1 << 64 | a.s0;
			}

			// Token: 0x06001CD6 RID: 7382 RVA: 0x00732068 File Offset: 0x00730268
			public override string ToString()
			{
				return this.ToString();
			}

			// Token: 0x04000F63 RID: 3939
			public ulong s0;

			// Token: 0x04000F64 RID: 3940
			public ulong s1;

			// Token: 0x04000F65 RID: 3941
			public ulong s2;

			// Token: 0x04000F66 RID: 3942
			public ulong s3;
		}
	}
}
