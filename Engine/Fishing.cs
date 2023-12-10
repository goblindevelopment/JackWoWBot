using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using Jack.ATH;
using Jack.Core;
using Jack.Models;

namespace Jack.Engine
{
	// Token: 0x020000BB RID: 187
	internal class Fishing
	{
		// Token: 0x06001408 RID: 5128 RVA: 0x00702580 File Offset: 0x00700780
		public static void Start(Vector3 InitialPosition, bool UseBait)
		{
			if (ObjectManager.Me.HasProfession("Fishing"))
			{
				if (Fishing.CheckKeybindAndFishingPole())
				{
					Fishing.ManageAttackers(InitialPosition);
					Key.Release("All");
					Thread.Sleep(250);
					if (ObjectManager.Me.IsMounted)
					{
						Walk.Mount(false, false);
					}
					Addon.LUA("_equipFishingPole()", "0", false, true);
					if (Fishing.WaitUntilFishingPoleIsEquipped())
					{
						Fishing.Fish(InitialPosition, UseBait);
						return;
					}
				}
			}
			else
			{
				Tools.Console("I need to learn \"Fishing\" first.", "Red", "richConsole", "frmMain", true);
			}
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0070260C File Offset: 0x0070080C
		private static bool CheckKeybindAndFishingPole()
		{
			if (!_globals.Keys.ContainsKey("Fishing") || _globals.Keys["Fishing"] == "NotSet")
			{
				Tools.Console("Fishing Keybind is not set.", "Red", "richConsole", "frmMain", true);
				return false;
			}
			if (_globals.IsRetail)
			{
				return true;
			}
			Items hasFishingPole = ObjectManager.HasFishingPole;
			if (hasFishingPole == null)
			{
				Tools.Console("I have no Fishing Pole.", "Red", "richConsole", "frmMain", true);
				return false;
			}
			string str = "";
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				str = hasFishingPole.ItemName;
			}
			Tools.Console("Found Fishing Pole: \"" + str + "\"", "Green", "richConsole", "frmMain", true);
			return true;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x007026F4 File Offset: 0x007008F4
		private static bool WaitUntilFishingPoleIsEquipped()
		{
			bool hasFishingPoleEqquiped;
			if (!(hasFishingPoleEqquiped = ObjectManager.HasFishingPoleEqquiped))
			{
				Tools.Console("Equip Fishing Pole...", "Blue", "richConsole", "frmMain", true);
				string name = Tools.RandomTimer("EquipFishingPole");
				Timer.Set(name, 5000);
				while (_globals.Start && !_globals.NoCheck && !hasFishingPoleEqquiped && Timer.Check(name) != 0)
				{
					hasFishingPoleEqquiped = ObjectManager.HasFishingPoleEqquiped;
					Thread.Sleep(500);
				}
			}
			if (hasFishingPoleEqquiped)
			{
				Tools.Console("Fishing Pole is equipped.", "Blue", "richConsole", "frmMain", true);
			}
			else
			{
				Tools.Console("Couldn't equip Fishing Pole.", "Red", "richConsole", "frmMain", true);
			}
			return hasFishingPoleEqquiped;
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x007027A0 File Offset: 0x007009A0
		private static void BaitManager()
		{
			if (Fishing.Event != null && Fishing.Event.FishingUseBait && ObjectManager.HasFishingPoleEqquiped && ObjectManager.NeedEnchantment("MainHand") && ObjectManager.HasBait)
			{
				if (_globals.Keys.ContainsKey("Bait") && _globals.Keys["Bait"] != "NotSet")
				{
					Tools.Console("Attaching Bait...", "Blue", "richConsole", "frmMain", true);
					Key.Press("Bait");
					Thread.Sleep(30);
					Key.Release("Bait");
					Thread.Sleep(1000);
					string name = Tools.RandomTimer("AttachingBobber");
					Timer.Set(name, 6000);
					while (_globals.Start && !_globals.NoCheck && Timer.Check(name) != 0 && (ObjectManager.Me.IsCasting || (ObjectManager.NeedEnchantment("MainHand") && ObjectManager.GetAttackers.Count <= 0)))
					{
						if (!ObjectManager.Me.IsCasting && ObjectManager.NeedEnchantment("MainHand") && ObjectManager.GetAttackers.Count == 0)
						{
							Key.Press("Bait");
							Thread.Sleep(30);
							Key.Release("Bait");
							Thread.Sleep(750);
						}
						Thread.Sleep(250);
					}
					if (!ObjectManager.NeedEnchantment("MainHand") && ObjectManager.GetAttackers.Count == 0)
					{
						Tools.Console("Bait attached.", "Green", "richConsole", "frmMain", true);
						return;
					}
				}
				else
				{
					Tools.Console("Couldn't find Bait Keybind.", "Red", "richConsole", "frmMain", true);
				}
			}
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0070295C File Offset: 0x00700B5C
		private static void ManageAttackers(Vector3 InitialPosition)
		{
			if (ObjectManager.GetAttackers.Count > 0)
			{
				while (_globals.Start && ObjectManager.GetAttackers.Count > 0)
				{
					EventManager.WatchAttackers(InitialPosition);
				}
				EventManager.WatchAttackers(InitialPosition);
				Fishing.IsFaced = false;
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x007029A0 File Offset: 0x00700BA0
		private static void GetLootedItems(bool CompareItems = false)
		{
			if (CompareItems)
			{
				new Thread(delegate()
				{
					Fishing.smethod_0(CompareItems);
				})
				{
					IsBackground = true
				}.Start();
				return;
			}
			Fishing.smethod_0(CompareItems);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x007029EC File Offset: 0x00700BEC
		private static void CheckForRequiredItem(string ItemName)
		{
			if (Fishing.Event != null && Fishing.Event.FishingConditionItem)
			{
				foreach (string text in Fishing.Event.FishingConditionItemList)
				{
					if (text.Contains(ItemName + ";") || text == ItemName)
					{
						string text2 = "1";
						if (text.Contains(";"))
						{
							string text3 = text.Split(new char[]
							{
								';'
							})[1];
							if (Tools.IsNumber(text3, 1, 0, 1, 0))
							{
								text2 = text3;
							}
						}
						Tools.Console(string.Concat(new string[]
						{
							"Required item collected: \"",
							ItemName,
							"\" (",
							ObjectManager.GetItemAmount(ItemName).ToString(),
							"/",
							text2,
							")"
						}), "", "richConsole", "frmMain", true);
					}
				}
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00702B0C File Offset: 0x00700D0C
		private static void FaceMe()
		{
			if (!Fishing.IsFaced && Fishing.Event != null && Fishing.Event.FishingFacing)
			{
				Tools.Console("Align me to the water...", "Blue", "richConsole", "frmMain", true);
				Angle.FaceMe(ObjectManager.Me.PositionVector3, Fishing.Event.FishingFacingDirection, ObjectManager.Me.Facing, null, false, 0.1f);
				Thread.Sleep(250);
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00702B84 File Offset: 0x00700D84
		private static bool Conditions
		{
			get
			{
				if (Fishing.Event != null && Fishing.Event.FishingCondition)
				{
					if (Fishing.Event.FishingConditionSkill)
					{
						short num = ObjectManager.Me.ProfessionRank("Fishing");
						if ((int)num >= Fishing.Event.FishingConditionSkillLevel)
						{
							Tools.Console("Fishing Rank " + num.ToString() + " reached (Fishing Condition).", "Blue", "richConsole", "frmMain", true);
							return true;
						}
					}
					if (Fishing.Event.FishingConditionItem)
					{
						int num2 = 0;
						foreach (string text in Fishing.Event.FishingConditionItemList)
						{
							if (text.Length > 0)
							{
								if (!text.Contains(";"))
								{
									if (ObjectManager.GetItemAmount(text) >= 1)
									{
										num2++;
									}
								}
								else
								{
									string[] array = text.Split(new char[]
									{
										';'
									});
									string itemNameOrID = array[0];
									string text2 = array[1];
									if (Tools.IsNumber(text2, 1, 0, 1, 0))
									{
										int num3 = Convert.ToInt32(text2);
										if (ObjectManager.GetItemAmount(itemNameOrID) >= num3)
										{
											num2++;
										}
									}
								}
							}
							else
							{
								num2++;
							}
						}
						if (num2 >= Fishing.Event.FishingConditionItemList.Count)
						{
							Tools.Console("All required items have been collected (Fishing Condition).", "Blue", "richConsole", "frmMain", true);
							return true;
						}
					}
					if (Fishing.Event.FishingConditionFullBags && ObjectManager.GetFreeBagSlots == 0)
					{
						Tools.Console("My Bags are full (Fishing Condition).", "Blue", "richConsole", "frmMain", true);
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00702D20 File Offset: 0x00700F20
		private static void RandomDelay()
		{
			if (!Fishing.Event.FishingRandomDelay)
			{
				return;
			}
			Thread.Sleep(Tools.Rnd.Next(800, 2501));
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00702D54 File Offset: 0x00700F54
		private static void Fish(Vector3 InitialPosition, bool UseBait)
		{
			SNS.NotifyEvent("Start fishing...");
			while (_globals.Start && !Fishing.Conditions)
			{
				Fishing.ManageAttackers(InitialPosition);
				Fishing.FaceMe();
				if (UseBait)
				{
					Fishing.BaitManager();
				}
				Tools.Console("Cast fishing rod. Waiting for Bobber...", "Orange", "richConsole", "frmMain", true);
				Objects objects = null;
				string name = Tools.RandomTimer("CastFishingRod");
				Timer.Set(name, 6000);
				while (_globals.Start && objects == null && ObjectManager.GetAttackers.Count == 0 && Timer.Check(name) != 0)
				{
					if (!ObjectManager.Me.IsChanneling)
					{
						Fishing.RandomDelay();
						Key.Press("Fishing");
						Thread.Sleep(30);
						Key.Release("Fishing");
						Thread.Sleep(1000);
					}
					else
					{
						Thread.Sleep(100);
					}
					objects = ObjectManager.GetBobber;
				}
				if (objects != null && ObjectManager.Me.IsChanneling)
				{
					Tools.Console("Bobber found. Waiting for bite...", "Blue", "richConsole", "frmMain", true);
					int num = 0;
					int num2 = 0;
					UInt128 @uint = 0;
					object @lock = ObjectManager._lock;
					lock (@lock)
					{
						num = objects.Flags;
						@uint = objects.GUID128;
					}
					name = Tools.RandomTimer("WaitingForBite");
					Timer.Set(name, 25000);
					while (_globals.Start && ObjectManager.Me.IsChanneling && ObjectManager.GetAttackers.Count == 0 && Timer.Check(name) != 0)
					{
						@lock = ObjectManager._lock;
						lock (@lock)
						{
							num2 = objects.Flags;
						}
						if (num2 != num)
						{
							break;
						}
						Thread.Sleep(250);
					}
					if (num2 > 0 && num > 0)
					{
						if (num2 != num)
						{
							if (@uint > 0)
							{
								Fishing.RandomDelay();
								Fishing.GetLootedItems(false);
								ObjectManager.Interaction(@uint, "InteractMouseover");
								Fishing.GetLootedItems(true);
								Thread.Sleep(500);
							}
						}
					}
				}
			}
			SNS.NotifyEvent("Fishing finished.");
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00702FA8 File Offset: 0x007011A8
		[CompilerGenerated]
		internal static void smethod_0(bool CompareLists)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			if (CompareLists)
			{
				Thread.Sleep(2000);
			}
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				foreach (Items items in ObjectManager.GetItemsInBags)
				{
					int itemID = items.ItemID;
					if (!dictionary.ContainsKey(itemID))
					{
						dictionary.Add(itemID, items.StackCount);
					}
					else
					{
						int num = dictionary[itemID];
						dictionary[itemID] = num + items.StackCount;
					}
				}
			}
			if (!CompareLists)
			{
				Fishing.PreviousItemList.Clear();
				Fishing.PreviousItemList = dictionary;
				return;
			}
			Fishing.LatestItemList.Clear();
			Fishing.LatestItemList = dictionary;
			Fishing.smethod_1();
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00703098 File Offset: 0x00701298
		[CompilerGenerated]
		internal static void smethod_1()
		{
			Dictionary<Items, int> dictionary = new Dictionary<Items, int>();
			foreach (KeyValuePair<int, int> keyValuePair in Fishing.LatestItemList)
			{
				bool flag = false;
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				using (Dictionary<int, int>.Enumerator enumerator2 = Fishing.PreviousItemList.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						KeyValuePair<int, int> keyValuePair2 = enumerator2.Current;
						int key2 = keyValuePair2.Key;
						int value2 = keyValuePair2.Value;
						if (key == key2)
						{
							if (value == value2)
							{
								flag = true;
								break;
							}
						}
					}
					goto IL_D3;
				}
				IL_91:
				int num = value;
				if (Fishing.PreviousItemList.ContainsKey(key))
				{
					num -= Fishing.PreviousItemList[key];
				}
				Items itemByID = ObjectManager.GetItemByID(key);
				if (itemByID != null)
				{
					dictionary.Add(itemByID, num);
					continue;
				}
				continue;
				IL_D3:
				if (!flag)
				{
					goto IL_91;
				}
			}
			if (dictionary.Count > 0)
			{
				object @lock = ObjectManager._lock;
				lock (@lock)
				{
					foreach (KeyValuePair<Items, int> keyValuePair3 in dictionary)
					{
						string itemName = keyValuePair3.Key.ItemName;
						Tools.Console("Loot: \"" + itemName + "\" x" + keyValuePair3.Value.ToString(), "Green", "richConsole", "frmMain", true);
						Fishing.CheckForRequiredItem(itemName);
					}
				}
			}
		}

		// Token: 0x040009AA RID: 2474
		public static Events Event = null;

		// Token: 0x040009AB RID: 2475
		public static bool IsFaced = false;

		// Token: 0x040009AC RID: 2476
		private static Dictionary<int, int> PreviousItemList = new Dictionary<int, int>();

		// Token: 0x040009AD RID: 2477
		private static Dictionary<int, int> LatestItemList = new Dictionary<int, int>();
	}
}
