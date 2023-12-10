using System;
using System.Text;
using Jack.Core;

namespace Jack
{
	// Token: 0x02000013 RID: 19
	public class Read
	{
		// Token: 0x060000FA RID: 250 RVA: 0x0066A544 File Offset: 0x00668744
		public static object Single<T>(int Offset)
		{
			object obj = null;
			Type typeFromHandle = typeof(T);
			if (typeFromHandle == typeof(IntPtr))
			{
				obj = IntPtr.Zero;
			}
			else if (typeFromHandle == typeof(string))
			{
				obj = "";
			}
			else
			{
				obj = 0;
			}
			object result;
			try
			{
				if (typeFromHandle == typeof(IntPtr))
				{
					obj = _globals.processPointerRead.Read<IntPtr>(Offset);
				}
				else if (!(typeFromHandle == typeof(int)))
				{
					if (typeFromHandle == typeof(byte))
					{
						obj = _globals.processPointerRead.Read<byte>(Offset);
					}
					else if (!(typeFromHandle == typeof(byte[])))
					{
						if (typeFromHandle == typeof(UInt128))
						{
							obj = _globals.processPointerRead.Read<UInt128>(Offset);
						}
						else if (typeFromHandle == typeof(bool))
						{
							obj = _globals.processPointerRead.Read<bool>(Offset);
						}
						else if (typeFromHandle == typeof(float))
						{
							obj = _globals.processPointerRead.Read<float>(Offset);
						}
						else if (typeFromHandle == typeof(double))
						{
							obj = _globals.processPointerRead.Read<double>(Offset);
						}
						else if (!(typeFromHandle == typeof(string)))
						{
							if (!(typeFromHandle == typeof(long)) && !(typeFromHandle == typeof(long)))
							{
								if (!(typeFromHandle == typeof(short)) && !(typeFromHandle == typeof(short)))
								{
									if (typeFromHandle == typeof(Guid))
									{
										obj = _globals.processPointerRead.Read<Guid>(Offset);
									}
								}
								else
								{
									obj = _globals.processPointerRead.Read<short>(Offset);
								}
							}
							else
							{
								obj = _globals.processPointerRead.Read<long>(Offset);
							}
						}
						else
						{
							obj = _globals.processPointerRead.Read(Offset, Encoding.UTF8, 512);
						}
					}
					else
					{
						obj = _globals.processPointerRead.Read<byte[]>(Offset);
					}
				}
				else
				{
					obj = _globals.processPointerRead.Read<int>(Offset);
				}
				return obj;
			}
			catch
			{
				result = obj;
			}
			return result;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0066A7C0 File Offset: 0x006689C0
		public static object Combined<T>(IntPtr Offset)
		{
			object obj = null;
			Type typeFromHandle = typeof(T);
			if (!(typeFromHandle == typeof(IntPtr)))
			{
				if (!(typeFromHandle == typeof(string)))
				{
					obj = 0;
				}
				else
				{
					obj = "";
				}
			}
			else
			{
				obj = IntPtr.Zero;
			}
			object result;
			try
			{
				if (typeFromHandle == typeof(IntPtr))
				{
					obj = _globals.processHandleRead.Memory.Read<IntPtr>(Offset);
				}
				else if (typeFromHandle == typeof(int))
				{
					obj = _globals.processHandleRead.Memory.Read<int>(Offset);
				}
				else if (typeFromHandle == typeof(byte))
				{
					obj = _globals.processHandleRead.Memory.Read<byte>(Offset);
				}
				else if (!(typeFromHandle == typeof(byte[])))
				{
					if (typeFromHandle == typeof(UInt128))
					{
						obj = _globals.processHandleRead.Memory.Read<UInt128>(Offset);
					}
					else if (!(typeFromHandle == typeof(bool)))
					{
						if (!(typeFromHandle == typeof(float)))
						{
							if (typeFromHandle == typeof(double))
							{
								obj = _globals.processHandleRead.Memory.Read<double>(Offset);
							}
							else if (typeFromHandle == typeof(string))
							{
								obj = _globals.processHandleRead.Memory.Read(Offset, Encoding.UTF8, 512);
							}
							else if (!(typeFromHandle == typeof(long)) && !(typeFromHandle == typeof(long)))
							{
								if (!(typeFromHandle == typeof(short)) && !(typeFromHandle == typeof(short)))
								{
									if (typeFromHandle == typeof(Guid))
									{
										obj = _globals.processHandleRead.Memory.Read<Guid>(Offset);
									}
								}
								else
								{
									obj = _globals.processHandleRead.Memory.Read<short>(Offset);
								}
							}
							else
							{
								obj = _globals.processHandleRead.Memory.Read<long>(Offset);
							}
						}
						else
						{
							obj = _globals.processHandleRead.Memory.Read<float>(Offset);
						}
					}
					else
					{
						obj = _globals.processHandleRead.Memory.Read<bool>(Offset);
					}
				}
				else
				{
					obj = _globals.processHandleRead.Memory.Read<byte[]>(Offset);
				}
				return obj;
			}
			catch
			{
				result = obj;
			}
			return result;
		}
	}
}
