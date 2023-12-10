using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading;
using Jack.Core;
using Jack.Forms;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000CB RID: 203
	public class ObjectManager
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0070EDF4 File Offset: 0x0070CFF4
		// (set) Token: 0x06001535 RID: 5429 RVA: 0x0070EE08 File Offset: 0x0070D008
		public static PlayerMe Me { get; private set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0070EE1C File Offset: 0x0070D01C
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x0070EE30 File Offset: 0x0070D030
		public static Pet Pet { get; private set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0070EE44 File Offset: 0x0070D044
		// (set) Token: 0x06001539 RID: 5433 RVA: 0x0070EE58 File Offset: 0x0070D058
		public static Camera Camera { get; private set; }

		// Token: 0x0600153A RID: 5434 RVA: 0x0070EE6C File Offset: 0x0070D06C
		public static void Update()
		{
			ObjectManager.Me = new PlayerMe(IntPtr.Zero);
			ObjectManager.Pet = new Pet(IntPtr.Zero);
			ObjectManager.Camera = new Camera(IntPtr.Zero);
			ObjectManager.ObjectUpdateList.Clear();
			ObjectManager.ObjectList.Clear();
			ObjectManager.OverlayObjectList.Clear();
			for (;;)
			{
				if (!_globals.IsInWorld)
				{
					Thread.Sleep(1000);
				}
				else
				{
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						object lockOverlay = ObjectManager._lockOverlay;
						lock (lockOverlay)
						{
							foreach (KeyValuePair<UInt128, MemoryObject> keyValuePair in ObjectManager.ObjectUpdateList)
							{
								keyValuePair.Value.UpdateBaseAddress(IntPtr.Zero);
							}
							if (_globals.baseObjectManager != IntPtr.Zero)
							{
								for (;;)
								{
									IL_626:
									ObjectManager.Pet.Set();
									for (;;)
									{
										IL_61A:
										if (_globals.ObjectManagerRetail)
										{
											goto IL_303;
										}
										goto IL_5F8;
										uint num;
										for (;;)
										{
											IL_355:
											uint num2;
											switch ((num = (num2 ^ 1625852619U)) % 67U)
											{
											case 0U:
											case 28U:
												goto IL_5C8;
											case 1U:
												goto IL_58F;
											case 2U:
												goto IL_299;
											case 3U:
												goto IL_289;
											case 4U:
											case 13U:
											case 33U:
											case 66U:
												goto IL_5AD;
											case 6U:
												goto IL_18B;
											case 7U:
												goto IL_52C;
											case 9U:
												goto IL_4BE;
											case 10U:
												goto IL_61A;
											case 11U:
											case 48U:
												goto IL_128;
											case 12U:
												goto IL_153;
											case 14U:
												goto IL_545;
											case 15U:
												goto IL_174;
											case 16U:
												goto IL_242;
											case 17U:
												goto IL_22A;
											case 18U:
												goto IL_49D;
											case 19U:
												goto IL_57F;
											case 20U:
												num2 = (num * 4064535705U ^ 3887885149U);
												continue;
											case 21U:
												goto IL_103;
											case 22U:
												goto IL_5EA;
											case 23U:
												goto IL_5B1;
											case 24U:
												goto IL_E7;
											case 25U:
												goto IL_1F9;
											case 26U:
												goto IL_2C9;
											case 27U:
												goto IL_4D8;
											case 29U:
												goto IL_5BA;
											case 30U:
												goto IL_17D;
											case 31U:
												goto IL_2B9;
											case 32U:
											case 53U:
												goto IL_211;
											case 34U:
												goto IL_303;
											case 35U:
												goto IL_1EB;
											case 36U:
											case 45U:
												goto IL_626;
											case 37U:
												goto IL_279;
											case 38U:
											case 54U:
											case 61U:
											case 65U:
												goto IL_2D7;
											case 39U:
												goto IL_537;
											case 40U:
												goto IL_5F8;
											case 41U:
												goto IL_2A9;
											case 42U:
												goto IL_1D3;
											case 43U:
												goto IL_1DF;
											case 44U:
												goto IL_130;
											case 46U:
												goto IL_11A;
											case 47U:
												goto IL_1B4;
											case 49U:
												goto IL_56F;
											case 50U:
												goto IL_4EB;
											case 51U:
												goto IL_55F;
											case 52U:
												goto IL_59F;
											case 55U:
												goto IL_FA;
											case 56U:
												goto IL_22D;
											case 57U:
												goto IL_13E;
											case 58U:
												goto IL_1C2;
											case 59U:
												num2 = (num * 2806167668U ^ 4064507016U);
												continue;
											case 60U:
												goto IL_477;
											case 62U:
												goto IL_514;
											case 63U:
												goto IL_4AB;
											case 64U:
												goto IL_DE;
											}
											goto Block_10;
										}
										IL_242:
										Constants.ObjectType_Retail objectType_Retail;
										Objects objects;
										MemoryObject memoryObject;
										switch (objectType_Retail)
										{
										case Constants.ObjectType_Retail.Item:
											IL_279:
											memoryObject = new Items(objects.BaseAddress);
											goto IL_2D7;
										case Constants.ObjectType_Retail.Container:
											IL_289:
											memoryObject = new Container(objects.BaseAddress);
											goto IL_2D7;
										case Constants.ObjectType_Retail.EmpAzeriteItem:
										case Constants.ObjectType_Retail.AzeriteItem:
										case Constants.ObjectType_Retail.LocalPlayer:
										case Constants.ObjectType_Retail.DynamicObject:
										case Constants.ObjectType_Retail.Corpse:
											goto IL_2D7;
										case Constants.ObjectType_Retail.Unit:
											IL_299:
											memoryObject = new Units(objects.BaseAddress);
											goto IL_2D7;
										case Constants.ObjectType_Retail.Player:
											IL_2A9:
											memoryObject = new Player(objects.BaseAddress);
											goto IL_2D7;
										case Constants.ObjectType_Retail.GameObject:
											IL_2B9:
											memoryObject = new Objects(objects.BaseAddress);
											goto IL_2D7;
										case Constants.ObjectType_Retail.AreaTrigger:
											IL_2C9:
											memoryObject = new AreaTrigger(objects.BaseAddress);
											goto IL_2D7;
										default:
										{
											uint num2 = num * 3652610530U ^ 1736961971U;
											goto IL_355;
										}
										}
										IL_22D:
										IntPtr intPtr;
										objectType_Retail = (Constants.ObjectType_Retail)Read.Combined<byte>(intPtr + 16);
										goto IL_242;
										IL_22A:
										memoryObject = null;
										goto IL_22D;
										IL_1EB:
										UInt128 @uint;
										if (ObjectManager.ObjectUpdateList.ContainsKey(@uint))
										{
											goto IL_1F9;
										}
										goto IL_22A;
										IL_1B4:
										if (@uint == _globals.petGUID128)
										{
											goto IL_1C2;
										}
										goto IL_1EB;
										IL_17D:
										if (@uint == _globals.playerGUID128)
										{
											goto IL_18B;
										}
										goto IL_1B4;
										IL_174:
										objects = new Objects(intPtr);
										goto IL_17D;
										IL_153:
										IntPtr intPtr2;
										@uint = (UInt128)Read.Combined<UInt128>(intPtr2 + 8);
										if (@uint > 0)
										{
											goto IL_174;
										}
										goto IL_211;
										IL_13E:
										intPtr = (IntPtr)Read.Combined<IntPtr>(intPtr2 + 24);
										goto IL_153;
										IL_130:
										if (intPtr2 != IntPtr.Zero)
										{
											goto IL_13E;
										}
										goto IL_128;
										IL_11A:
										if (intPtr2 == IntPtr.Zero)
										{
											goto IL_128;
										}
										goto IL_130;
										IL_103:
										IntPtr pointer;
										int num3;
										intPtr2 = (IntPtr)Read.Combined<IntPtr>(pointer + num3 * 8);
										goto IL_11A;
										IL_FA:
										int num4;
										if (num3 < num4)
										{
											goto IL_103;
										}
										goto IL_632;
										IL_128:
										num3++;
										goto IL_FA;
										IL_477:
										Constants.ObjectType type;
										Objects objects2;
										MemoryObject memoryObject2;
										switch (type)
										{
										case Constants.ObjectType.Item:
											IL_55F:
											memoryObject2 = new Items(objects2.BaseAddress);
											goto IL_5AD;
										case Constants.ObjectType.Container:
											IL_56F:
											memoryObject2 = new Container(objects2.BaseAddress);
											goto IL_5AD;
										case Constants.ObjectType.Unit:
											IL_57F:
											memoryObject2 = new Units(objects2.BaseAddress);
											goto IL_5AD;
										case Constants.ObjectType.Player:
											IL_58F:
											memoryObject2 = new Player(objects2.BaseAddress);
											goto IL_5AD;
										case Constants.ObjectType.ActivePlayer:
											goto IL_5AD;
										case Constants.ObjectType.GameObject:
											IL_59F:
											memoryObject2 = new Objects(objects2.BaseAddress);
											goto IL_5AD;
										default:
										{
											uint num2 = num * 2875050119U ^ 632748600U;
											goto IL_355;
										}
										}
										IL_49D:
										memoryObject2 = null;
										type = objects2.Type;
										goto IL_477;
										IL_4AB:
										UInt128 uint2;
										if (ObjectManager.ObjectUpdateList.ContainsKey(uint2))
										{
											goto IL_545;
										}
										goto IL_49D;
										IL_4EB:
										uint2 = (UInt128)Read.Combined<UInt128>(objects2.DescriptorFields + 0);
										if (!(uint2 == _globals.playerGUID128))
										{
											goto IL_4AB;
										}
										goto IL_4D8;
										IL_514:
										IntPtr baseAddress;
										if (baseAddress.ToInt64() % 2L != 0L)
										{
											goto Block_14;
										}
										goto IL_4EB;
										IL_52C:
										baseAddress = objects2.BaseAddress;
										goto IL_514;
										IL_537:
										if (baseAddress.ToInt64() != 0L)
										{
											goto IL_52C;
										}
										goto IL_632;
										IL_5EA:
										baseAddress = objects2.BaseAddress;
										goto IL_537;
										IL_5F8:
										objects2 = new Objects((IntPtr)Read.Combined<IntPtr>(_globals.baseObjectManager + Descriptors.ObjectManager_First));
										goto IL_5EA;
										IL_5C8:
										objects2.BaseAddress = (IntPtr)Read.Combined<IntPtr>(objects2.BaseAddress + Descriptors.ObjectManager_Next);
										goto IL_5EA;
										IL_5BA:
										ObjectManager.ObjectUpdateList.Add(uint2, memoryObject2);
										goto IL_5C8;
										IL_5B1:
										memoryObject2.GUID128 = uint2;
										goto IL_5BA;
										IL_5AD:
										if (memoryObject2 != null)
										{
											goto IL_5B1;
										}
										goto IL_5C8;
										IL_545:
										ObjectManager.ObjectUpdateList[uint2].UpdateBaseAddress(objects2.BaseAddress);
										goto IL_5C8;
										IL_4BE:
										ObjectManager.Me.GUID128 = uint2;
										_globals.playerBaseAddress = objects2.BaseAddress;
										goto IL_4AB;
										IL_4D8:
										ObjectManager.Me.UpdateBaseAddress(objects2.BaseAddress);
										goto IL_4BE;
										IL_1DF:
										_globals.petBaseAddress = objects.BaseAddress;
										goto IL_1EB;
										IL_1D3:
										ObjectManager.Pet.GUID128 = @uint;
										goto IL_1DF;
										IL_1C2:
										ObjectManager.Pet.UpdateBaseAddress(objects.BaseAddress);
										goto IL_1D3;
										IL_18B:
										ObjectManager.Me.UpdateBaseAddress(objects.BaseAddress);
										ObjectManager.Me.GUID128 = @uint;
										_globals.playerBaseAddress = objects.BaseAddress;
										goto IL_1B4;
										IL_211:
										intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr2 + 0);
										goto IL_130;
										IL_2D7:
										if (memoryObject == null)
										{
											goto IL_211;
										}
										goto IL_DE;
										IL_1F9:
										ObjectManager.ObjectUpdateList[@uint].UpdateBaseAddress(objects.BaseAddress);
										goto IL_211;
										IL_E7:
										ObjectManager.ObjectUpdateList.Add(@uint, memoryObject);
										goto IL_211;
										IL_DE:
										memoryObject.GUID128 = @uint;
										goto IL_E7;
										IL_303:
										num4 = (int)Read.Combined<int>(_globals.processPointerRead.Read<IntPtr>(Offsets.ObjectManager_Base));
										pointer = (IntPtr)Read.Combined<IntPtr>(_globals.processPointerRead.Read<IntPtr>(Offsets.ObjectManager_Base) + 8);
										num3 = 0;
										goto IL_FA;
									}
								}
								Block_10:
								Block_14:
								IL_632:
								foreach (UInt128 key in ObjectManager.ObjectUpdateList.Where(delegate(KeyValuePair<UInt128, MemoryObject> obj)
								{
									KeyValuePair<UInt128, MemoryObject> keyValuePair2 = obj;
									return !keyValuePair2.Value.IsValid;
								}).Select(delegate(KeyValuePair<UInt128, MemoryObject> obj)
								{
									KeyValuePair<UInt128, MemoryObject> keyValuePair2 = obj;
									return keyValuePair2.Key;
								}).ToList<UInt128>())
								{
									ObjectManager.ObjectUpdateList.Remove(key);
								}
								ObjectManager.ObjectList = ObjectManager.ObjectUpdateList.Where(delegate(KeyValuePair<UInt128, MemoryObject> obj)
								{
									KeyValuePair<UInt128, MemoryObject> keyValuePair2 = obj;
									return keyValuePair2.Value.IsValid;
								}).Select(delegate(KeyValuePair<UInt128, MemoryObject> obj)
								{
									KeyValuePair<UInt128, MemoryObject> keyValuePair2 = obj;
									return keyValuePair2.Value;
								}).ToList<MemoryObject>();
								ObjectManager.OverlayObjectList = ObjectManager.ObjectUpdateList.Where(delegate(KeyValuePair<UInt128, MemoryObject> obj)
								{
									KeyValuePair<UInt128, MemoryObject> keyValuePair2 = obj;
									return keyValuePair2.Value.IsValid;
								}).Select(delegate(KeyValuePair<UInt128, MemoryObject> obj)
								{
									KeyValuePair<UInt128, MemoryObject> keyValuePair2 = obj;
									return keyValuePair2.Value;
								}).ToList<MemoryObject>();
								Tools.Control("Objects: " + ObjectManager.ObjectList.Count.ToString(), "btnObjects", "frmTeam", true, false, false, false, 0);
							}
						}
					}
					Thread.Sleep(600);
				}
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x0070F6B0 File Offset: 0x0070D8B0
		public static List<Player> GetPlayer
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Player> result;
				lock (@lock)
				{
					result = ObjectManager.ObjectList.OfType<Player>().ToList<Player>();
				}
				return result;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x0070F6FC File Offset: 0x0070D8FC
		public static List<Units> GetUnits
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Units> result;
				lock (@lock)
				{
					result = ObjectManager.ObjectList.OfType<Units>().ToList<Units>();
				}
				return result;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x0070F748 File Offset: 0x0070D948
		public static List<Units> GetNPCs
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Units> result;
				lock (@lock)
				{
					result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
					where !Unit.IsPlayerControlled
					select Unit).ToList<Units>();
				}
				return result;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0070F7B8 File Offset: 0x0070D9B8
		public static List<Objects> GetGameObjects
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Objects> result;
				lock (@lock)
				{
					result = ObjectManager.ObjectList.OfType<Objects>().ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0070F804 File Offset: 0x0070DA04
		public static List<AreaTrigger> GetAreaTrigger
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<AreaTrigger> result;
				lock (@lock)
				{
					result = ObjectManager.ObjectList.OfType<AreaTrigger>().ToList<AreaTrigger>();
				}
				return result;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x0070F850 File Offset: 0x0070DA50
		public static List<Items> GetItems
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Items> result;
				lock (@lock)
				{
					result = ObjectManager.ObjectList.OfType<Items>().ToList<Items>();
				}
				return result;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0070F89C File Offset: 0x0070DA9C
		public static List<Container> GetContainers
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Container> result;
				lock (@lock)
				{
					result = ObjectManager.ObjectList.OfType<Container>().ToList<Container>();
				}
				return result;
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0070F8E8 File Offset: 0x0070DAE8
		public static Player GetPlayerByGUID(UInt128 GUID)
		{
			object @lock = ObjectManager._lock;
			Player result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Player>()
				where Unit.GUID128 == GUID
				select Unit).FirstOrDefault<Player>();
			}
			return result;
		}

		// Token: 0x06001543 RID: 5443 RVA: 0x0070F950 File Offset: 0x0070DB50
		public static Objects GetObjectByGUID(UInt128 GUID)
		{
			object @lock = ObjectManager._lock;
			Objects result;
			lock (@lock)
			{
				result = (from Obj in ObjectManager.ObjectList.OfType<Objects>()
				where Obj.GUID128 == GUID
				select Obj).FirstOrDefault<Objects>();
			}
			return result;
		}

		// Token: 0x06001544 RID: 5444 RVA: 0x0070F9B8 File Offset: 0x0070DBB8
		public static Objects GetObjectByDisplayID(int DisplayID)
		{
			object @lock = ObjectManager._lock;
			Objects result;
			lock (@lock)
			{
				result = (from Obj in ObjectManager.ObjectList.OfType<Objects>()
				where Obj.DisplayID == DisplayID
				select Obj).FirstOrDefault<Objects>();
			}
			return result;
		}

		// Token: 0x06001545 RID: 5445 RVA: 0x0070FA20 File Offset: 0x0070DC20
		public static List<Objects> GetObjectsByDisplayID(int DisplayID)
		{
			List<Objects> list = new List<Objects>();
			foreach (Objects objects in ObjectManager.GetGameObjects)
			{
				if (objects.DisplayID == DisplayID)
				{
					list.Add(objects);
				}
			}
			return list;
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0070FA84 File Offset: 0x0070DC84
		public static Objects GetObjectByName(string Name)
		{
			object @lock = ObjectManager._lock;
			Objects result;
			lock (@lock)
			{
				result = (from Obj in ObjectManager.ObjectList.OfType<Objects>()
				where Obj.Name == Name
				select Obj).FirstOrDefault<Objects>();
			}
			return result;
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0070FAEC File Offset: 0x0070DCEC
		public static AreaTrigger GetAreaTriggerByGUID(UInt128 GUID)
		{
			object @lock = ObjectManager._lock;
			AreaTrigger result;
			lock (@lock)
			{
				result = (from AT in ObjectManager.ObjectList.OfType<AreaTrigger>()
				where AT.GUID128 == GUID
				select AT).FirstOrDefault<AreaTrigger>();
			}
			return result;
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0070FB54 File Offset: 0x0070DD54
		public static Units GetUnitByGUID(UInt128 GUID)
		{
			object @lock = ObjectManager._lock;
			Units result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
				where Unit.GUID128 == GUID
				select Unit).FirstOrDefault<Units>();
			}
			return result;
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x0070FBBC File Offset: 0x0070DDBC
		public static Units GetUnitByDisplayID(int DisplayID)
		{
			object @lock = ObjectManager._lock;
			Units result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
				where Unit.DisplayID == DisplayID
				select Unit).FirstOrDefault<Units>();
			}
			return result;
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0070FC24 File Offset: 0x0070DE24
		public static Units GetNPCByGUID(UInt128 GUID)
		{
			object @lock = ObjectManager._lock;
			Units result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
				where !Unit.IsPlayerControlled && Unit.GUID128 == GUID
				select Unit).FirstOrDefault<Units>();
			}
			return result;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0070FC8C File Offset: 0x0070DE8C
		public static Units GetNPCByDisplayID(int DisplayID)
		{
			object @lock = ObjectManager._lock;
			Units result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
				where !Unit.IsPlayerControlled && Unit.DisplayID == DisplayID
				select Unit).FirstOrDefault<Units>();
			}
			return result;
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0070FCF4 File Offset: 0x0070DEF4
		public static Units GetNPCByName(string Name)
		{
			object @lock = ObjectManager._lock;
			Units result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
				where !Unit.IsPlayerControlled && Unit.Name == Name
				select Unit).FirstOrDefault<Units>();
			}
			return result;
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x0070FD5C File Offset: 0x0070DF5C
		public static Items GetItemByGUID(UInt128 GUID)
		{
			object @lock = ObjectManager._lock;
			Items result;
			lock (@lock)
			{
				result = (from Item in ObjectManager.ObjectList.OfType<Items>()
				where Item.GUID128 == GUID
				select Item).FirstOrDefault<Items>();
			}
			return result;
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x0070FDC4 File Offset: 0x0070DFC4
		public static Items GetItemByDisplayID(int DisplayID)
		{
			object @lock = ObjectManager._lock;
			Items result;
			lock (@lock)
			{
				result = (from Item in ObjectManager.ObjectList.OfType<Items>()
				where Item.ItemID == DisplayID
				select Item).FirstOrDefault<Items>();
			}
			return result;
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x0070FE2C File Offset: 0x0070E02C
		public static Container GetContainerByGUID(UInt128 GUID)
		{
			object @lock = ObjectManager._lock;
			Container result;
			lock (@lock)
			{
				result = (from Item in ObjectManager.ObjectList.OfType<Container>()
				where Item.GUID128 == GUID
				select Item).FirstOrDefault<Container>();
			}
			return result;
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0070FE94 File Offset: 0x0070E094
		public static List<Objects> GetNodes(int Distance = 0)
		{
			List<Objects> list = new List<Objects>();
			bool flag = false;
			if (Walk.CheckProfileSettings)
			{
				if (Distance == 0)
				{
					Distance = Walk.ProfileSettings.DistanceLoot;
				}
				flag = (Walk.ProfileSettings.QuestItems.Count > 0);
			}
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Objects objects in ObjectManager.GetGameObjects)
				{
					if (JackMath.Distance(objects.PositionVector3, true, true, true) <= (double)Distance)
					{
						if (flag)
						{
							string b = objects.DisplayID.ToString();
							string name = objects.Name;
							bool flag3 = false;
							using (List<string>.Enumerator enumerator2 = Walk.ProfileSettings.QuestItems.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									string text = enumerator2.Current;
									if (!(text == b))
									{
										if (text == name)
										{
											flag3 = true;
										}
										else if (text.Contains("*") && name.Contains(text.Replace("*", "")))
										{
											flag3 = true;
										}
									}
									else
									{
										flag3 = true;
									}
									if (flag3)
									{
										break;
									}
								}
								goto IL_13C;
							}
							goto IL_123;
							IL_13C:
							if (!flag3)
							{
								continue;
							}
							goto IL_12F;
						}
						IL_123:
						if (!objects.IsGather)
						{
							continue;
						}
						IL_12F:
						list.Add(objects);
					}
				}
			}
			return list;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x00710050 File Offset: 0x0070E250
		public static List<Objects> GetAllNodes
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Objects> result;
				lock (@lock)
				{
					result = (from Obj in ObjectManager.ObjectList.OfType<Objects>()
					where Obj.IsGather
					select Obj).ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x007100C0 File Offset: 0x0070E2C0
		public static List<Units> GetSkins(int Distance = 0)
		{
			List<Units> list = new List<Units>();
			if (Walk.CheckProfileSettings && Distance == 0)
			{
				Distance = Walk.ProfileSettings.DistanceLoot;
			}
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Units units in ObjectManager.GetUnits)
				{
					int displayID = units.DisplayID;
					string name = units.Name;
					Vector3 positionVector = units.PositionVector3;
					if (!units.IsPlayerControlled && !units.IsAlive && (_globals.List_Skinning.Contains(displayID) || Loot.CanGatherMobs(displayID, name) || (Walk.IsOnWhitelist(displayID, name) && !Walk.IsOnBlacklist(positionVector, displayID, name))) && units.IsSkinnable && JackMath.IsReachable(positionVector, 4.5) && JackMath.Distance(positionVector, true, true, true) <= (double)Distance)
					{
						list.Add(units);
					}
				}
			}
			return list;
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x007101E8 File Offset: 0x0070E3E8
		public static List<Units> GetLoots(int Distance = 0)
		{
			if (Distance == 0 && Walk.CheckProfileSettings)
			{
				Distance = Walk.ProfileSettings.DistanceLoot;
			}
			object @lock = ObjectManager._lock;
			List<Units> result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
				where !Unit.IsPlayerControlled && Unit.IsLootable && JackMath.IsReachable(Unit.PositionVector3, 4.5) && JackMath.Distance(Unit.PositionVector3, true, true, true) <= (double)Distance
				select Unit).ToList<Units>();
			}
			return result;
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00710270 File Offset: 0x0070E470
		public static List<Player> GetPlayersAround(Vector3 ObjectPosition, string Mode = "", int Distance = 8)
		{
			object @lock = ObjectManager._lock;
			List<Player> result;
			lock (@lock)
			{
				if (Mode == "Gather")
				{
					result = (from Player in ObjectManager.ObjectList.OfType<Player>()
					where JackMath.DistanceAround(ObjectPosition, Player.PositionVector3) < (double)Distance && JackMath.IsReachable(ObjectPosition, Player.PositionVector3, 4.5) && Player.IsCasting
					select Player).ToList<Player>();
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x007102F0 File Offset: 0x0070E4F0
		public static List<Units> GetElitesAround(Vector3 ObjectPosition, int Distance = 40)
		{
			int MyLevel = ObjectManager.Me.Level;
			if (Walk.CheckProfileSettings)
			{
				Distance = Walk.ProfileSettings.DistanceAvoidElites;
			}
			return (from Unit in ObjectManager.ObjectList.OfType<Units>()
			where !Unit.IsPlayerControlled && Unit.IsAlive && Unit.IsElite && MyLevel > 10 && Unit.Level >= MyLevel - 10 && JackMath.DistanceAround(ObjectPosition, Unit.PositionVector3) < (double)Distance && JackMath.IsReachable(ObjectPosition, Unit.PositionVector3, 4.5)
			select Unit).ToList<Units>();
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00710358 File Offset: 0x0070E558
		public static List<Units> GetUnitsAround(Vector3 ObjectPosition, string mode = "", int Distance = 8)
		{
			object @lock = ObjectManager._lock;
			bool flag = false;
			List<Units> result;
			try
			{
				Monitor.Enter(@lock, ref flag);
				int MyLevel = ObjectManager.Me.Level;
				if (!(mode == "Gather"))
				{
					if (!(mode == "InCombatWithMeOrPet"))
					{
						if (mode == "Offensive")
						{
							result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
							where !Unit.IsPlayerControlled && ObjectManager.MobIsOnAttackableList(Unit.Name, Unit.DisplayID) && Unit.IsAlive && (Unit.TargetGUID == 0 || Unit.TargetGUID == _globals.playerGUID128 || Unit.IsInCombatWithNPC) && JackMath.DistanceAround(ObjectPosition, Unit.PositionVector3) <= (double)Distance && JackMath.IsReachable(ObjectPosition, Unit.PositionVector3, 4.5) && !Unit.IsCritter && !Unit.IsNonCombatPet && !Unit.IsRunningBack && !Unit.IsRelatedToAnotherPlayer
							select Unit).ToList<Units>();
						}
						else if (!(mode == "UnitToUnit"))
						{
							if (!(mode == "UnitToUnitOffensive"))
							{
								if (!(mode == "CastSpell"))
								{
									if (mode == "PvP")
									{
										result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
										where Unit.IsPlayerControlled && Unit.IsOpposingFaction && !Unit.IsPet && Combat.PlayerIsInRange(Unit.PositionVector3) && JackMath.IsReachable(ObjectPosition, Unit.PositionVector3, 4.5) && Unit.IsAlive
										select Unit).ToList<Units>();
									}
									else
									{
										result = null;
									}
								}
								else
								{
									result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
									where !Unit.IsPlayerControlled && ObjectManager.MobIsOnAttackableList(Unit.Name, Unit.DisplayID) && JackMath.Distance(ObjectPosition, Unit.PositionVector3, true, true, true) <= (double)Distance && JackMath.IsReachable(ObjectPosition, Unit.PositionVector3, 4.5) && Unit.IsAlive && !Unit.IsCritter && !Unit.IsNonCombatPet && !Unit.IsRunningBack
									select Unit).ToList<Units>();
								}
							}
							else
							{
								result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
								where !Unit.IsPlayerControlled && ObjectManager.MobIsOnAttackableList(Unit.Name, Unit.DisplayID) && Unit.IsAlive && (Unit.TargetGUID == 0 || Unit.TargetGUID == _globals.playerGUID128 || Unit.IsInCombatWithNPC) && JackMath.DistanceAround(ObjectPosition, Unit.PositionVector3) <= (double)Distance && JackMath.IsReachable(ObjectPosition, Unit.PositionVector3, 4.5) && !Unit.IsCritter && !Unit.IsNonCombatPet && !Unit.IsRunningBack && !Unit.IsRelatedToAnotherPlayer
								select Unit).ToList<Units>();
							}
						}
						else
						{
							result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
							where !Unit.IsPlayerControlled && ObjectManager.MobIsOnAttackableList(Unit.Name, Unit.DisplayID) && JackMath.DistanceAround(ObjectPosition, Unit.PositionVector3) <= (double)Distance && JackMath.IsReachable(ObjectPosition, Unit.PositionVector3, 4.5) && !Unit.IsCritter && !Unit.IsNonCombatPet && !Unit.IsRunningBack
							select Unit).ToList<Units>();
						}
					}
					else
					{
						result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
						where !Unit.IsPlayerControlled && ObjectManager.MobIsOnAttackableList(Unit.Name, Unit.DisplayID) && JackMath.DistanceAround(ObjectPosition, Unit.PositionVector3) < (double)Distance && !Unit.IsCritter && !Unit.IsNonCombatPet && !Unit.IsRunningBack && (Unit.IsInCombatWithMe || Unit.IsInCombatWithPet)
						select Unit).ToList<Units>();
					}
				}
				else
				{
					result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
					where !Unit.IsPlayerControlled && Unit.IsAlive && (Unit.TargetGUID == 0 || Unit.TargetGUID == _globals.playerGUID128) && JackMath.DistanceAround(ObjectPosition, Unit.PositionVector3) < (double)Distance && JackMath.IsReachable(ObjectPosition, Unit.PositionVector3, 4.5) && !Unit.IsCritter && !Unit.IsNonCombatPet && !Unit.IsRunningBack && Unit.Level >= MyLevel
					select Unit).ToList<Units>();
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(@lock);
				}
			}
			return result;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00710560 File Offset: 0x0070E760
		public static Dictionary<UInt128, Units> GetUnitsAroundUnits(List<Units> UnitList, string Mode = "UnitToUnit", int Distance = 10)
		{
			object @lock = ObjectManager._lock;
			Dictionary<UInt128, Units> result;
			lock (@lock)
			{
				Dictionary<UInt128, Units> dictionary = new Dictionary<UInt128, Units>();
				if (UnitList.Count > 0)
				{
					foreach (Units units in UnitList)
					{
						if (units != null && (!_globals.IsPVP || (units.IsPlayerControlled && !units.IsPet)))
						{
							UInt128 guid = units.GUID128;
							if (!dictionary.ContainsKey(guid))
							{
								dictionary.Add(guid, units);
								List<Units> unitsAround = ObjectManager.GetUnitsAround(units.PositionVector3, Mode, Distance);
								if (unitsAround.Count != 0)
								{
									foreach (Units units2 in unitsAround)
									{
										UInt128 guid2 = units2.GUID128;
										if (!dictionary.ContainsKey(guid2))
										{
											dictionary.Add(guid2, units2);
										}
									}
								}
							}
						}
					}
				}
				result = dictionary;
			}
			return result;
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x007106A4 File Offset: 0x0070E8A4
		public static Units GetClosestUnit(List<Units> Units)
		{
			Units result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Units units in Units)
				{
					if (!_globals.IsPVP || (units.IsPlayerControlled && !units.IsPet))
					{
						double num2 = JackMath.Distance(units.PositionVector3, true, true, true);
						if (num2 > 0.0)
						{
							if (num != 0.0)
							{
								if (num2 >= num)
								{
									continue;
								}
							}
							num = num2;
							result = units;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00710774 File Offset: 0x0070E974
		public static Units GetClosestUnit(List<UInt128> Units)
		{
			Units result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (UInt128 guid in Units)
				{
					Units unitByGUID = ObjectManager.GetUnitByGUID(guid);
					if (unitByGUID != null && (!_globals.IsPVP || (unitByGUID.IsPlayerControlled && !unitByGUID.IsPet)))
					{
						double num2 = JackMath.Distance(unitByGUID.PositionVector3, true, true, true);
						if (num2 > 0.0)
						{
							if (num != 0.0)
							{
								if (num2 >= num)
								{
									continue;
								}
							}
							num = num2;
							result = unitByGUID;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0071084C File Offset: 0x0070EA4C
		public static Units GetClosestUnit(Dictionary<UInt128, Units> Units)
		{
			Units result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (KeyValuePair<UInt128, Units> keyValuePair in Units)
				{
					if (!_globals.IsPVP || (keyValuePair.Value.IsPlayerControlled && !keyValuePair.Value.IsPet))
					{
						double num2 = JackMath.Distance(keyValuePair.Value.PositionVector3, true, true, true);
						if (num2 > 0.0)
						{
							if (num != 0.0)
							{
								if (num2 >= num)
								{
									continue;
								}
							}
							num = num2;
							result = keyValuePair.Value;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x00710930 File Offset: 0x0070EB30
		public static Units GetAttacker
		{
			get
			{
				object @lock = ObjectManager._lock;
				Units result;
				lock (@lock)
				{
					result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
					where (Unit.IsInCombatWithMe || Unit.IsInCombatWithPet) && Unit.IsAlive && ((_globals.IsPVP && Unit.IsPlayerControlled && !Unit.IsPet) || !Unit.IsRunningBack)
					select Unit).FirstOrDefault<Units>();
				}
				return result;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x007109A0 File Offset: 0x0070EBA0
		public static List<Units> GetAttackers
		{
			get
			{
				object @lock = ObjectManager._lock;
				List<Units> result;
				lock (@lock)
				{
					result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
					where (Unit.IsInCombatWithMe || Unit.IsInCombatWithPet) && Unit.IsAlive && ((_globals.IsPVP && Unit.IsPlayerControlled && !Unit.IsPet) || !Unit.IsRunningBack)
					select Unit).ToList<Units>();
				}
				return result;
			}
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00710A10 File Offset: 0x0070EC10
		public static List<Units> GetAttackersByDistance(int Distance = 10)
		{
			object @lock = ObjectManager._lock;
			List<Units> result;
			lock (@lock)
			{
				result = (from Unit in ObjectManager.ObjectList.OfType<Units>()
				where (Unit.IsInCombatWithMe || Unit.IsInCombatWithPet) && JackMath.Distance(Unit.PositionVector3, true, true, true) <= (double)Distance && Unit.IsAlive && ((_globals.IsPVP && Unit.IsPlayerControlled && !Unit.IsPet) || !Unit.IsRunningBack)
				select Unit).ToList<Units>();
			}
			return result;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x00710A78 File Offset: 0x0070EC78
		public static Units GetClosestAttacker
		{
			get
			{
				object @lock = ObjectManager._lock;
				Units result;
				lock (@lock)
				{
					Units units = null;
					List<Units> getAttackers = ObjectManager.GetAttackers;
					double num = 0.0;
					if (getAttackers.Count<Units>() > 0)
					{
						foreach (Units units2 in getAttackers)
						{
							if (!_globals.IsPVP || (units2.IsPlayerControlled && !units2.IsPet))
							{
								double num2 = JackMath.Distance(units2.PositionVector3, true, true, true);
								if (num2 > 0.0 && (num == 0.0 || num2 < num))
								{
									num = num2;
									units = units2;
								}
							}
						}
					}
					result = units;
				}
				return result;
			}
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00710B5C File Offset: 0x0070ED5C
		public static Objects GetClosestObject(List<UInt128> Objects)
		{
			Objects result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (UInt128 guid in Objects)
				{
					Objects objectByGUID = ObjectManager.GetObjectByGUID(guid);
					if (objectByGUID != null)
					{
						double num2 = JackMath.Distance(objectByGUID.PositionVector3, true, true, true);
						if (num2 > 0.0)
						{
							if (num != 0.0)
							{
								if (num2 >= num)
								{
									continue;
								}
							}
							num = num2;
							result = objectByGUID;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00710C1C File Offset: 0x0070EE1C
		public static Objects GetClosestObjects(List<UInt128> Objects)
		{
			Objects result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (UInt128 guid in Objects)
				{
					Objects objectByGUID = ObjectManager.GetObjectByGUID(guid);
					if (objectByGUID != null)
					{
						double num2 = JackMath.Distance(objectByGUID.PositionVector3, true, true, true);
						if (num2 > 0.0 && (num == 0.0 || num2 < num))
						{
							num = num2;
							result = objectByGUID;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00710CD8 File Offset: 0x0070EED8
		public static Objects GetClosestObjectByGUID(UInt128 GUID)
		{
			Objects result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Objects objects in ObjectManager.GetGameObjects)
				{
					if (objects.GUID128 == GUID)
					{
						double num2 = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num2 > 0.0)
						{
							if (num != 0.0)
							{
								if (num2 >= num)
								{
									continue;
								}
							}
							num = num2;
							result = objects;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x00710DA0 File Offset: 0x0070EFA0
		public static Objects GetClosestObjectByDisplayID(int DisplayID)
		{
			Objects result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Objects objects in ObjectManager.GetGameObjects)
				{
					if (objects.DisplayID == DisplayID)
					{
						double num2 = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num2 > 0.0)
						{
							if (num != 0.0)
							{
								if (num2 >= num)
								{
									continue;
								}
							}
							num = num2;
							result = objects;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x00710E64 File Offset: 0x0070F064
		public static Objects GetFurthestObject
		{
			get
			{
				Objects result = null;
				double num = 0.0;
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					foreach (Objects objects in ObjectManager.GetGameObjects)
					{
						double num2 = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num2 >= 0.0)
						{
							if (num != 0.0)
							{
								if (num2 <= num)
								{
									continue;
								}
							}
							num = num2;
							result = objects;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x00710F1C File Offset: 0x0070F11C
		public static Objects GetFurthestObjectByDisplayID(int DisplayID)
		{
			Objects result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Objects objects in ObjectManager.GetGameObjects)
				{
					if (objects.DisplayID == DisplayID)
					{
						double num2 = JackMath.Distance(objects.PositionVector3, true, true, true);
						if (num2 >= 0.0)
						{
							if (num != 0.0)
							{
								if (num2 <= num)
								{
									continue;
								}
							}
							num = num2;
							result = objects;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x00710FE0 File Offset: 0x0070F1E0
		public static Units GetClosestNPC
		{
			get
			{
				Units result = null;
				double num = 0.0;
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					foreach (Units units in ObjectManager.GetNPCs)
					{
						double num2 = JackMath.Distance(units.PositionVector3, true, true, true);
						if (num2 >= 0.0)
						{
							if (num != 0.0)
							{
								if (num2 >= num)
								{
									continue;
								}
							}
							num = num2;
							result = units;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00711098 File Offset: 0x0070F298
		public static Units GetClosestNPCByDisplayID(int DisplayID)
		{
			Units result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Units units in ObjectManager.GetNPCs)
				{
					if (units.DisplayID == DisplayID)
					{
						double num2 = JackMath.Distance(units.PositionVector3, true, true, true);
						if (num2 >= 0.0 && (num == 0.0 || num2 < num))
						{
							num = num2;
							result = units;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x00711158 File Offset: 0x0070F358
		public static Units GetFurthestNPC
		{
			get
			{
				Units result = null;
				double num = 0.0;
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					foreach (Units units in ObjectManager.GetNPCs)
					{
						double num2 = JackMath.Distance(units.PositionVector3, true, true, true);
						if (num2 >= 0.0)
						{
							if (num != 0.0)
							{
								if (num2 <= num)
								{
									continue;
								}
							}
							num = num2;
							result = units;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00711210 File Offset: 0x0070F410
		public static Units GetFurthestNPCByDisplayID(int DisplayID)
		{
			Units result = null;
			double num = 0.0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Units units in ObjectManager.GetNPCs)
				{
					if (units.DisplayID == DisplayID)
					{
						double num2 = JackMath.Distance(units.PositionVector3, true, true, true);
						if (num2 >= 0.0)
						{
							if (num != 0.0)
							{
								if (num2 <= num)
								{
									continue;
								}
							}
							num = num2;
							result = units;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x007112D4 File Offset: 0x0070F4D4
		public static List<Player> GetPlayersOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Player> result;
				lock (lockOverlay)
				{
					result = (from Player in ObjectManager.OverlayObjectList.OfType<Player>()
					where Player.IsPlayerControlled && JackMath.Distance(Player.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Player).ToList<Player>();
				}
				return result;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00711344 File Offset: 0x0070F544
		public static List<Player> GetPlayersHordeOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Player> result;
				lock (lockOverlay)
				{
					result = (from Player in ObjectManager.OverlayObjectList.OfType<Player>()
					where Player.IsPlayerControlled && Player.IsHorde && JackMath.Distance(Player.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Player).ToList<Player>();
				}
				return result;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x007113B4 File Offset: 0x0070F5B4
		public static List<Player> GetPlayersAllianceOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Player> result;
				lock (lockOverlay)
				{
					result = (from Player in ObjectManager.OverlayObjectList.OfType<Player>()
					where Player.IsPlayerControlled && Player.IsAlliance && JackMath.Distance(Player.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Player).ToList<Player>();
				}
				return result;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00711424 File Offset: 0x0070F624
		public static List<Units> GetNPCsOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Units> result;
				lock (lockOverlay)
				{
					result = (from Unit in ObjectManager.OverlayObjectList.OfType<Units>()
					where !Unit.IsPlayerControlled && JackMath.Distance(Unit.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Unit).ToList<Units>();
				}
				return result;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00711494 File Offset: 0x0070F694
		public static List<Objects> GetNodesOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Objects> result;
				lock (lockOverlay)
				{
					result = (from Obj in ObjectManager.OverlayObjectList.OfType<Objects>()
					where Obj.IsGather && JackMath.Distance(Obj.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Obj).ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00711504 File Offset: 0x0070F704
		public static List<Objects> GetHerbsOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Objects> result;
				lock (lockOverlay)
				{
					result = (from Obj in ObjectManager.OverlayObjectList.OfType<Objects>()
					where Obj.IsHerb && (!_globals.IsRetail || Obj.IsAvailable) && JackMath.Distance(Obj.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Obj).ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00711574 File Offset: 0x0070F774
		public static List<Objects> GetOresOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Objects> result;
				lock (lockOverlay)
				{
					result = (from Obj in ObjectManager.OverlayObjectList.OfType<Objects>()
					where Obj.IsOre && (!_globals.IsRetail || Obj.IsAvailable) && JackMath.Distance(Obj.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Obj).ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x007115E4 File Offset: 0x0070F7E4
		public static List<Units> GetSkinsOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Units> result;
				lock (lockOverlay)
				{
					result = (from Unit in ObjectManager.OverlayObjectList.OfType<Units>()
					where !Unit.IsPlayerControlled && !Unit.IsAlive && Unit.IsSkinnable && JackMath.Distance(Unit.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Unit).ToList<Units>();
				}
				return result;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00711654 File Offset: 0x0070F854
		public static List<Objects> GetChestsOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Objects> result;
				lock (lockOverlay)
				{
					result = (from Obj in ObjectManager.OverlayObjectList.OfType<Objects>()
					where Obj.IsChest && (!_globals.IsRetail || Obj.IsAvailable) && JackMath.Distance(Obj.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Obj).ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x007116C4 File Offset: 0x0070F8C4
		public static List<Objects> GetContainerOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Objects> result;
				lock (lockOverlay)
				{
					result = (from Obj in ObjectManager.OverlayObjectList.OfType<Objects>()
					where Obj.IsContainer && (!_globals.IsRetail || Obj.IsAvailable) && JackMath.Distance(Obj.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Obj).ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x00711734 File Offset: 0x0070F934
		public static List<Objects> GetFishingPoolsOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Objects> result;
				lock (lockOverlay)
				{
					result = (from Obj in ObjectManager.OverlayObjectList.OfType<Objects>()
					where Obj.IsFishingPool && (!_globals.IsRetail || Obj.IsAvailable) && JackMath.Distance(Obj.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Obj).ToList<Objects>();
				}
				return result;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x007117A4 File Offset: 0x0070F9A4
		public static List<Units> GetLootsOverlay
		{
			get
			{
				object lockOverlay = ObjectManager._lockOverlay;
				List<Units> result;
				lock (lockOverlay)
				{
					result = (from Unit in ObjectManager.OverlayObjectList.OfType<Units>()
					where !Unit.IsPlayerControlled && Unit.IsDead && Unit.IsLootable && JackMath.Distance(Unit.PositionVector3, true, true, true) <= (double)Settings.OverlayESPUnitsDistance
					select Unit).ToList<Units>();
				}
				return result;
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00711814 File Offset: 0x0070FA14
		public static Items GetItemByID(int ItemID)
		{
			object @lock = ObjectManager._lock;
			Items result;
			lock (@lock)
			{
				result = (from Item in ObjectManager.ObjectList.OfType<Items>()
				where Item.ItemID == ItemID
				select Item).FirstOrDefault<Items>();
			}
			return result;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0071187C File Offset: 0x0070FA7C
		public static int GetItemAmount(object ItemNameOrID)
		{
			int num = 0;
			string text = "";
			int num2 = 0;
			if (!(ItemNameOrID.GetType() == typeof(int)))
			{
				text = (string)ItemNameOrID;
				if (Tools.IsNumber(text, 1, 0, 1, 0))
				{
					num2 = Convert.ToInt32(text);
				}
			}
			else
			{
				num2 = (int)ItemNameOrID;
			}
			if (num2 > 0)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					using (List<Items>.Enumerator enumerator = ObjectManager.GetItemsInBags.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Items items = enumerator.Current;
							if (items.ItemID == num2)
							{
								num += items.StackCount;
							}
						}
						return num;
					}
				}
			}
			if (text.Length > 0)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					foreach (Items items2 in ObjectManager.GetItemsInBags)
					{
						if (items2.ItemName == text)
						{
							num += items2.StackCount;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x007119DC File Offset: 0x0070FBDC
		public static List<Items> GetItemsInMainBag
		{
			get
			{
				List<Items> list = new List<Items>();
				for (int i = 0; i < 16; i++)
				{
					try
					{
						UInt128 @uint;
						if (_globals.ObjectManagerRetail)
						{
							int offset = Descriptors.ItemFields_MainBag + i * Descriptors.ItemFields_NextSlot;
							@uint = (UInt128)Read.Combined<UInt128>(_globals.playerBaseAddress + offset);
						}
						else
						{
							IntPtr pointer = (IntPtr)Read.Combined<IntPtr>(_globals.playerBaseAddress + Descriptors.Main_DescriptorFields);
							int offset2 = Descriptors.ItemFields_MainBag + i * Descriptors.ItemFields_NextSlot;
							@uint = (UInt128)Read.Combined<UInt128>(pointer + offset2);
						}
						if (@uint > 0)
						{
							Items itemByGUID = ObjectManager.GetItemByGUID(@uint);
							if (itemByGUID != null)
							{
								list.Add(itemByGUID);
							}
						}
					}
					catch
					{
					}
				}
				return list;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00711AA0 File Offset: 0x0070FCA0
		public static int CountItemsInMainBag
		{
			get
			{
				int num = 0;
				for (int i = 0; i < 16; i++)
				{
					try
					{
						UInt128 a;
						if (_globals.ObjectManagerRetail)
						{
							int offset = Descriptors.ItemFields_MainBag + i * Descriptors.ItemFields_NextSlot;
							a = (UInt128)Read.Combined<UInt128>(_globals.playerBaseAddress + offset);
						}
						else
						{
							IntPtr pointer = (IntPtr)Read.Combined<IntPtr>(_globals.playerBaseAddress + Descriptors.Main_DescriptorFields);
							int offset2 = Descriptors.ItemFields_MainBag + i * Descriptors.ItemFields_NextSlot;
							a = (UInt128)Read.Combined<UInt128>(pointer + offset2);
						}
						if (a > 0)
						{
							num++;
						}
					}
					catch
					{
					}
				}
				return num;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x00711B50 File Offset: 0x0070FD50
		public static List<Items> GetItemsInContainers
		{
			get
			{
				List<UInt128> list = new List<UInt128>();
				foreach (Container container in ObjectManager.GetContainers)
				{
					if (!list.Contains(container.GUID128))
					{
						list.Add(container.GUID128);
					}
				}
				List<Items> list2 = new List<Items>();
				foreach (Items items in ObjectManager.GetItems)
				{
					if (list.Contains(items.ContainedInGUID))
					{
						list2.Add(items);
					}
				}
				return list2;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00711C18 File Offset: 0x0070FE18
		public static int CountItemsInContainers
		{
			get
			{
				int num = 0;
				List<UInt128> list = new List<UInt128>();
				foreach (Container container in ObjectManager.GetContainers)
				{
					if (!list.Contains(container.GUID128))
					{
						list.Add(container.GUID128);
					}
				}
				foreach (Items items in ObjectManager.GetItems)
				{
					if (list.Contains(items.ContainedInGUID))
					{
						num++;
					}
				}
				return num;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x00711CD8 File Offset: 0x0070FED8
		public static List<Items> GetItemsInBags
		{
			get
			{
				List<Items> list = new List<Items>();
				foreach (Items item in ObjectManager.GetItemsInMainBag)
				{
					list.Add(item);
				}
				foreach (Items item2 in ObjectManager.GetItemsInContainers)
				{
					list.Add(item2);
				}
				return list;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x00711D74 File Offset: 0x0070FF74
		public static int CountItemsInBags
		{
			get
			{
				return ObjectManager.CountItemsInMainBag + ObjectManager.CountItemsInContainers;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00711D8C File Offset: 0x0070FF8C
		public static List<Items> GetItemsInBank
		{
			get
			{
				List<Items> list = new List<Items>();
				for (int i = 0; i < 28; i++)
				{
					try
					{
						UInt128 @uint;
						if (_globals.ObjectManagerRetail)
						{
							int offset = Descriptors.ItemFields_Bank + i * Descriptors.ItemFields_NextSlot;
							@uint = (UInt128)Read.Combined<UInt128>(_globals.playerBaseAddress + offset);
						}
						else
						{
							IntPtr pointer = (IntPtr)Read.Combined<IntPtr>(_globals.playerBaseAddress + Descriptors.Main_DescriptorFields);
							int offset2 = Descriptors.ItemFields_Bank + i * Descriptors.ItemFields_NextSlot;
							@uint = (UInt128)Read.Combined<UInt128>(pointer + offset2);
						}
						if (@uint > 0)
						{
							Items itemByGUID = ObjectManager.GetItemByGUID(@uint);
							if (itemByGUID != null)
							{
								list.Add(itemByGUID);
							}
						}
					}
					catch
					{
					}
				}
				return list;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00711E50 File Offset: 0x00710050
		public static List<Items> GetEquippedItems
		{
			get
			{
				List<Items> list = new List<Items>();
				for (int i = 0; i < 19; i++)
				{
					try
					{
						UInt128 @uint;
						if (_globals.ObjectManagerRetail)
						{
							int offset = Descriptors.ItemFields_Equipped + i * Descriptors.ItemFields_NextSlot;
							@uint = (UInt128)Read.Combined<UInt128>(_globals.playerBaseAddress + offset);
						}
						else
						{
							IntPtr pointer = (IntPtr)Read.Combined<IntPtr>(_globals.playerBaseAddress + Descriptors.Main_DescriptorFields);
							int offset2 = Descriptors.ItemFields_Equipped + i * Descriptors.ItemFields_NextSlot;
							@uint = (UInt128)Read.Combined<UInt128>(pointer + offset2);
						}
						if (@uint > 0)
						{
							Items itemByGUID = ObjectManager.GetItemByGUID(@uint);
							if (itemByGUID != null)
							{
								list.Add(itemByGUID);
							}
						}
					}
					catch
					{
					}
				}
				return list;
			}
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00711F14 File Offset: 0x00710114
		public static Items GetItemBySlot(string SlotName)
		{
			int num = 0;
			UInt128 @uint = 0;
			if (SlotName == "MainHand")
			{
				num = 15;
			}
			else if (!(SlotName == "OffHand") && !(SlotName == "SecondHand"))
			{
				if (SlotName == "Gun")
				{
					num = 17;
				}
			}
			else
			{
				num = 16;
			}
			try
			{
				int offset = Descriptors.ItemFields_Equipped + num * Descriptors.ItemFields_NextSlot;
				@uint = (UInt128)Read.Combined<UInt128>(_globals.playerBaseAddress + offset);
			}
			catch
			{
			}
			if (@uint > 0)
			{
				Items itemByGUID = ObjectManager.GetItemByGUID(@uint);
				if (itemByGUID != null)
				{
					return itemByGUID;
				}
			}
			return null;
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00711FC0 File Offset: 0x007101C0
		public static bool NeedEnchantment(string SlotName)
		{
			Items itemBySlot = ObjectManager.GetItemBySlot(SlotName);
			return itemBySlot != null && itemBySlot.EffectID == 0;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00711FE4 File Offset: 0x007101E4
		public static string GetItemName(int ItemID)
		{
			string result = "N/A";
			if (_globals.List_Items.ContainsKey(ItemID))
			{
				result = _globals.List_Items[ItemID];
			}
			return result;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00712014 File Offset: 0x00710214
		public static Items HasFishingPole
		{
			get
			{
				foreach (Items items in ObjectManager.GetEquippedItems)
				{
					if (_globals.List_FishingPoles.ContainsKey(items.ItemID))
					{
						return items;
					}
				}
				foreach (Items items2 in ObjectManager.GetItemsInBags)
				{
					if (_globals.List_FishingPoles.ContainsKey(items2.ItemID))
					{
						return items2;
					}
				}
				return null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x007120CC File Offset: 0x007102CC
		public static bool HasFishingPoleEqquiped
		{
			get
			{
				if (_globals.IsRetail)
				{
					return true;
				}
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					Items itemBySlot = ObjectManager.GetItemBySlot("MainHand");
					if (itemBySlot != null && _globals.List_FishingPoles.ContainsKey(itemBySlot.ItemID))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x00712138 File Offset: 0x00710338
		public static bool HasBait
		{
			get
			{
				using (List<Items>.Enumerator enumerator = ObjectManager.GetItemsInBags.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Items items = enumerator.Current;
						if (_globals.List_FishingBaits.ContainsKey(items.ItemID))
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x007121A0 File Offset: 0x007103A0
		public static Objects GetBobber
		{
			get
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					using (List<Objects>.Enumerator enumerator = ObjectManager.GetGameObjects.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							Objects objects = enumerator.Current;
							if (objects.IsFishingPool && objects.CreatorGUID == _globals.playerGUID128)
							{
								return objects;
							}
						}
						goto IL_6B;
					}
				}
				Objects result;
				return result;
				IL_6B:
				return null;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x00712238 File Offset: 0x00710438
		public static Dictionary<int, Container> EquippedBags
		{
			get
			{
				Dictionary<int, Container> dictionary = new Dictionary<int, Container>();
				for (int i = 0; i < 4; i++)
				{
					try
					{
						UInt128 @uint = 0;
						if (i == 0)
						{
							@uint = (UInt128)Read.Single<UInt128>(Offsets.Container_BagGUIDs);
						}
						else
						{
							@uint = (UInt128)Read.Single<UInt128>(Offsets.Container_BagGUIDs + Descriptors.ContainerFields_GUID * i);
						}
						if (@uint > 0 && @uint.ToString().Length > 20)
						{
							Container containerByGUID = ObjectManager.GetContainerByGUID(@uint);
							if (containerByGUID != null)
							{
								dictionary.Add(i, containerByGUID);
							}
						}
					}
					catch
					{
					}
				}
				return dictionary;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x007122D4 File Offset: 0x007104D4
		public static int GetFreeBagSlots
		{
			get
			{
				int num = 0;
				foreach (KeyValuePair<int, Container> keyValuePair in ObjectManager.EquippedBags)
				{
					num += keyValuePair.Value.FreeSlots;
				}
				return num + (16 - ObjectManager.CountItemsInMainBag);
			}
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0071233C File Offset: 0x0071053C
		public static bool MobIsOnAttackableList(string UnitName, int UnitDisplayID = 0)
		{
			if (Walk.CheckProfileSettings && Walk.ProfileSettings.AttackableMobs.Count > 0)
			{
				using (List<string>.Enumerator enumerator = Walk.ProfileSettings.AttackableMobs.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						if (UnitDisplayID > 0 && Tools.IsNumber(text, 1, 0, 1, 0))
						{
							int num = Convert.ToInt32(text);
							if (num > 0)
							{
								if (UnitDisplayID == num)
								{
									return true;
								}
							}
						}
						else if (UnitName.Contains(text.Replace("*", "")) && (text.Contains("*") || text == UnitName))
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
			return false;
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x00712408 File Offset: 0x00710608
		public static Events HasEvent(Vector3 Crd)
		{
			object @lock = frmProfile._lock;
			Events result;
			lock (@lock)
			{
				result = (from evt in _globals.Events.OfType<Events>()
				where evt.Vector3 == Crd
				select evt).FirstOrDefault<Events>();
			}
			return result;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x00712470 File Offset: 0x00710670
		public static string GetEventQuestIDs
		{
			get
			{
				string text = "";
				object lockEvents = _globals._lockEvents;
				string result;
				lock (lockEvents)
				{
					if (_globals.Events.Count != 0)
					{
						using (List<Events>.Enumerator enumerator = _globals.Events.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								Events events = enumerator.Current;
								if (EventManager.IsAction(events.Action, "Load Profile..."))
								{
									string text2 = "";
									bool flag2 = false;
									if (events.Condition1 == "When Quest(s) completed")
									{
										text2 = events.Condition1Value;
										flag2 = true;
									}
									else if (events.Condition2 == "When Quest(s) completed")
									{
										text2 = events.Condition2Value;
										flag2 = true;
									}
									if (flag2)
									{
										text2 = text2.Trim().Replace(" ", "");
										if (text2.Length != 0)
										{
											if (text2.Contains(","))
											{
												foreach (string text3 in text2.Split(new char[]
												{
													','
												}))
												{
													if (Tools.IsNumber(text3, 1, 0, 1, 0))
													{
														if (text.Length > 0)
														{
															text += ",";
														}
														text += text3;
													}
												}
											}
											else if (Tools.IsNumber(text2, 1, 0, 1, 0))
											{
												if (text.Length > 0)
												{
													text += ",";
												}
												text += text2;
											}
										}
									}
								}
							}
							return text;
						}
					}
					result = "";
				}
				return result;
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00712644 File Offset: 0x00710844
		public static List<string> GetEventNames(Vector3 SelectedCrd, bool WithID = true)
		{
			List<string> list = new List<string>();
			if (SelectedCrd != default(Vector3))
			{
				object @lock = frmProfile._lock;
				lock (@lock)
				{
					foreach (Events events in frmProfile.RecordedEvents)
					{
						if (events.Vector3 == SelectedCrd)
						{
							if (WithID)
							{
								list.Add(events.Name + " [" + events.ID.ToString() + "]");
							}
							else
							{
								list.Add(events.Name);
							}
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00712720 File Offset: 0x00710920
		public static Events GetEvent(Vector3 Crd)
		{
			object @lock = frmProfile._lock;
			Events result;
			lock (@lock)
			{
				result = (from evt in frmProfile.RecordedEvents.OfType<Events>()
				where evt.Vector3 == Crd
				select evt).FirstOrDefault<Events>();
			}
			return result;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00712788 File Offset: 0x00710988
		public static Events GetEvent(int ID)
		{
			object @lock = frmProfile._lock;
			Events result;
			lock (@lock)
			{
				result = (from evt in frmProfile.RecordedEvents.OfType<Events>()
				where evt.ID == ID
				select evt).FirstOrDefault<Events>();
			}
			return result;
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x007127F0 File Offset: 0x007109F0
		public static List<Rotation> GetRotationSpellsByType(string[] SpellTypes, string[] Conditions = null)
		{
			List<Rotation> list = new List<Rotation>();
			foreach (Rotation rotation in _globals.Rotation)
			{
				if (rotation.DifferentUsage == "")
				{
					foreach (string b in SpellTypes)
					{
						if ((rotation.Type == b || SpellTypes.Contains("All")) && ((Conditions == null && !rotation.AlwaysActiveCombat && !rotation.AlwaysActiveOutOfCombat && !rotation.AlwaysActiveCombatWay) || (Conditions != null && Conditions.Contains("AlwaysActive") && (rotation.AlwaysActiveCombat || rotation.AlwaysActiveOutOfCombat)) || (Conditions != null && Conditions.Contains("AlwaysActiveWay") && rotation.AlwaysActiveCombatWay)))
						{
							list.Add(rotation);
						}
					}
				}
			}
			if (list.Count > 0)
			{
				list = (from Rotation in list
				orderby Rotation.Prio
				select Rotation).ToList<Rotation>();
			}
			return list;
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x00712928 File Offset: 0x00710B28
		public static Rotation GetRotationSpellByID(int SpellID)
		{
			foreach (Rotation rotation in _globals.Rotation)
			{
				if (rotation.ID == SpellID && rotation.Key != "")
				{
					return rotation;
				}
			}
			return null;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00712998 File Offset: 0x00710B98
		public static Rotation GetRotationSpellWithLowestPower(List<string> SpellTypes)
		{
			Rotation result = null;
			int num = 0;
			List<string> list = new List<string>
			{
				"MANA",
				"ENERGY",
				"RAGE"
			};
			foreach (Rotation rotation in _globals.Rotation)
			{
				if (rotation.DifferentUsage == "")
				{
					foreach (string b in SpellTypes)
					{
						if (rotation.Type == b)
						{
							int num2 = 0;
							if (rotation.HasPowerType1 && list.Contains(rotation.PowerType1))
							{
								num2 = rotation.PowerType1Value;
							}
							else if (rotation.HasPowerType2 && list.Contains(rotation.PowerType2))
							{
								num2 = rotation.PowerType2Value;
							}
							if (num2 > 0 && (num == 0 || num2 <= num))
							{
								num = num2;
								result = rotation;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00712AD0 File Offset: 0x00710CD0
		public static bool HasCombatInRotation
		{
			get
			{
				foreach (Rotation rotation in _globals.Rotation)
				{
					if (rotation.DifferentUsage == "" && (rotation.Type == "Combat" || rotation.Type == "Heal"))
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x00712B5C File Offset: 0x00710D5C
		public static bool HasAlwaysActiveInRotation
		{
			get
			{
				using (List<Rotation>.Enumerator enumerator = _globals.Rotation.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Rotation rotation = enumerator.Current;
						if (rotation.DifferentUsage == "" && (rotation.AlwaysActiveCombat || rotation.AlwaysActiveOutOfCombat))
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00712BD4 File Offset: 0x00710DD4
		public static bool HasAlwaysActiveWayInRotation
		{
			get
			{
				using (List<Rotation>.Enumerator enumerator = _globals.Rotation.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Rotation rotation = enumerator.Current;
						if (rotation.DifferentUsage == "" && rotation.AlwaysActiveCombatWay)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x00712C44 File Offset: 0x00710E44
		public static bool HasHealInRotation
		{
			get
			{
				foreach (Rotation rotation in _globals.Rotation)
				{
					if (rotation.DifferentUsage == "" && rotation.Type == "Heal")
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00712CC0 File Offset: 0x00710EC0
		public static bool HasBuffInRotation
		{
			get
			{
				using (List<Rotation>.Enumerator enumerator = _globals.Rotation.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Rotation rotation = enumerator.Current;
						if (rotation.DifferentUsage == "" && rotation.Type == "Buff/Aura")
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00712D38 File Offset: 0x00710F38
		public static bool HasDispelInRotation
		{
			get
			{
				foreach (Rotation rotation in _globals.Rotation)
				{
					if (rotation.DifferentUsage == "" && rotation.Type == "Dispel")
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00712DB4 File Offset: 0x00710FB4
		public static bool HasFoodDrinkInRotation
		{
			get
			{
				using (List<Rotation>.Enumerator enumerator = _globals.Rotation.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Rotation rotation = enumerator.Current;
						if (rotation.DifferentUsage == "" && rotation.Type == "Food/Drink")
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00712E2C File Offset: 0x0071102C
		public static bool HasConjuringInRotation
		{
			get
			{
				foreach (Rotation rotation in _globals.Rotation)
				{
					if (rotation.DifferentUsage == "" && rotation.Type == "Conjuring")
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00712EA8 File Offset: 0x007110A8
		public static Rotation RotationSpellIsReady(int SpellID)
		{
			if (ActionBar.HasSpellInActionBar(SpellID))
			{
				Rotation rotationSpellByID = ObjectManager.GetRotationSpellByID(SpellID);
				if (rotationSpellByID != null && SpellRotation.CheckSpellConditions(rotationSpellByID))
				{
					return rotationSpellByID;
				}
			}
			return null;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x00712ED4 File Offset: 0x007110D4
		public static List<string> GetFlightPointNames
		{
			get
			{
				List<string> list = new List<string>();
				foreach (KeyValuePair<int, string> keyValuePair in _globals.List_FlightPoints)
				{
					list.Add(keyValuePair.Value);
				}
				return list;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00712F34 File Offset: 0x00711134
		public static List<int> GetFlightPointIDs
		{
			get
			{
				List<int> list = new List<int>();
				foreach (KeyValuePair<int, string> keyValuePair in _globals.List_FlightPoints)
				{
					list.Add(keyValuePair.Key);
				}
				return list;
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x00712F94 File Offset: 0x00711194
		public static string GetFlightPoint(int FP)
		{
			foreach (KeyValuePair<int, string> keyValuePair in _globals.List_FlightPoints)
			{
				if (keyValuePair.Key == FP)
				{
					return keyValuePair.Value;
				}
			}
			return "";
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00713000 File Offset: 0x00711200
		public static int GetFlightPoint(string FP)
		{
			using (Dictionary<int, string>.Enumerator enumerator = _globals.List_FlightPoints.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, string> keyValuePair = enumerator.Current;
					if (keyValuePair.Value == FP)
					{
						return keyValuePair.Key;
					}
				}
				return 0;
			}
			int result;
			return result;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00713068 File Offset: 0x00711268
		public static bool IsInCity
		{
			get
			{
				using (Dictionary<int, string>.Enumerator enumerator = _globals.List_Cities.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, string> keyValuePair = enumerator.Current;
						if (keyValuePair.Key == PlayerMe.ZoneID)
						{
							return true;
						}
					}
					return false;
				}
				bool result;
				return result;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x007130CC File Offset: 0x007112CC
		public static Objects GetClosestTransport
		{
			get
			{
				double num = 0.0;
				Objects result = null;
				foreach (Objects objects in ObjectManager.GetGameObjects)
				{
					foreach (KeyValuePair<int, string> keyValuePair in _globals.List_Transports)
					{
						if (objects.DisplayID == keyValuePair.Key)
						{
							double num2 = JackMath.Distance(objects.PositionVector3, true, true, true);
							if (num2 > 0.0 && (num == 0.0 || num2 < num))
							{
								num = num2;
								result = objects;
							}
						}
					}
				}
				return result;
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x007131A8 File Offset: 0x007113A8
		public static bool TransportNeedReload(Objects Object)
		{
			int num = 0;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				num = Object.DisplayID;
			}
			foreach (KeyValuePair<int, string> keyValuePair in _globals.List_Transports)
			{
				if (keyValuePair.Key == num)
				{
					return keyValuePair.Value == "Zepelin" || keyValuePair.Value == "Ship";
				}
			}
			return false;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00713264 File Offset: 0x00711464
		public static void Interaction(object GUIDOrDisplayID, string Mode = "Target")
		{
			UInt128 @uint = 0;
			if (GUIDOrDisplayID.GetType() == typeof(UInt128))
			{
				@uint = (UInt128)GUIDOrDisplayID;
			}
			else if (GUIDOrDisplayID.GetType() == typeof(int))
			{
				int displayID = (int)GUIDOrDisplayID;
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					Units unitByDisplayID = ObjectManager.GetUnitByDisplayID(displayID);
					if (unitByDisplayID != null)
					{
						@uint = unitByDisplayID.GUID128;
					}
					else
					{
						Objects objectByDisplayID = ObjectManager.GetObjectByDisplayID(displayID);
						if (objectByDisplayID != null)
						{
							@uint = objectByDisplayID.GUID128;
						}
					}
				}
			}
			if (@uint > 0)
			{
				Random random = new Random();
				if (!(Mode == "Target"))
				{
					if (Mode == "Interact")
					{
						if (ObjectManager.Me.TargetGUID != @uint)
						{
							Write.Do(Offsets.Local_TargetGUID, @uint);
							Thread.Sleep(random.Next(80, 150));
						}
						Key.Press("InteractWithTarget");
						Thread.Sleep(random.Next(20, 50));
						Key.Release("InteractWithTarget");
						return;
					}
					if (Mode == "TargetMouseover")
					{
						if (ObjectManager.Me.TargetGUID != @uint)
						{
							Write.Do(Offsets.Local_MouseoverGUID, @uint);
							Thread.Sleep(random.Next(80, 150));
						}
						Key.Press("TargetMouseover");
						Thread.Sleep(random.Next(20, 50));
						Key.Release("TargetMouseover");
						return;
					}
					if (Mode == "InteractMouseover")
					{
						if (ObjectManager.Me.TargetGUID != @uint)
						{
							Write.Do(Offsets.Local_MouseoverGUID, @uint);
							Thread.Sleep(random.Next(80, 150));
						}
						Key.Press("InteractWithMouseover");
						Thread.Sleep(random.Next(20, 50));
						Key.Release("InteractWithMouseover");
					}
				}
				else if (ObjectManager.Me.TargetGUID != @uint)
				{
					Write.Do(Offsets.Local_TargetGUID, @uint);
					Thread.Sleep(random.Next(80, 150));
					return;
				}
			}
		}

		// Token: 0x04000A15 RID: 2581
		private static Dictionary<UInt128, MemoryObject> ObjectUpdateList = new Dictionary<UInt128, MemoryObject>();

		// Token: 0x04000A16 RID: 2582
		public static List<MemoryObject> ObjectList = new List<MemoryObject>();

		// Token: 0x04000A17 RID: 2583
		public static List<MemoryObject> OverlayObjectList = new List<MemoryObject>();

		// Token: 0x04000A18 RID: 2584
		public static object _lock = new object();

		// Token: 0x04000A19 RID: 2585
		public static object _lockOverlay = new object();
	}
}
