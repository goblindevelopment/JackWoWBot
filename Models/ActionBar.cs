using System;
using System.Collections.Generic;
using System.Linq;
using Jack.Core;
using Jack.Engine;

namespace Jack.Models
{
	// Token: 0x0200003B RID: 59
	public class ActionBar
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00678AE0 File Offset: 0x00676CE0
		public static ICollection<ActionBar.SpellList> GetSpells
		{
			get
			{
				List<ActionBar.SpellList> list = new List<ActionBar.SpellList>();
				int num = 1;
				int num2 = 1;
				for (int i = 0; i < 84; i++)
				{
					if (num2 > 12)
					{
						num++;
						num2 = 1;
					}
					int num3 = (int)Read.Single<int>(Offsets.ActionBar_FirstSlot + Descriptors.ActionBar_First * i);
					if (num3 != 0 && num3.ToString().Length != 10)
					{
						ActionBar.SpellList item;
						if (num3 <= 0)
						{
							int num4 = num3 & int.MaxValue;
							string text = "Item";
							if (num4 <= 0)
							{
								num4 = (int)JackMath.Absolute((float)num3, true);
							}
							else
							{
								text = ObjectManager.GetItemName(num4);
								if (text.Length == 0)
								{
									text = "Item";
								}
							}
							item = new ActionBar.SpellList
							{
								Bar = num,
								Slot = num2,
								ID = num4,
								Name = text
							};
						}
						else
						{
							int bar = num;
							if (num == 7)
							{
								bar = 1;
							}
							string text2 = Spell.GetSpellName(num3);
							if (_globals.IsRetail && text2 == "N/A")
							{
								text2 = ObjectManager.GetItemName(num3);
							}
							item = new ActionBar.SpellList
							{
								Bar = bar,
								Slot = num2,
								ID = num3,
								Name = text2
							};
						}
						list.Add(item);
					}
					num2++;
				}
				return list;
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00678C28 File Offset: 0x00676E28
		public static Dictionary<int, int> GetSpellsByBar(int Bar = 1)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (ActionBar.SpellList spellList in ActionBar.GetSpells)
			{
				if (spellList.Bar == Bar && !dictionary.ContainsKey(spellList.ID))
				{
					dictionary.Add(spellList.ID, spellList.Slot);
				}
			}
			return dictionary;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00678CA0 File Offset: 0x00676EA0
		public static Dictionary<int, int> GetSpellsByBar(int[] Bars)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (ActionBar.SpellList spellList in ActionBar.GetSpells)
			{
				for (int i = 0; i < Bars.Count<int>(); i++)
				{
					if (spellList.Bar == Bars[i] && !dictionary.ContainsKey(spellList.ID))
					{
						dictionary.Add(spellList.ID, spellList.Slot);
					}
				}
			}
			return dictionary;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00678D2C File Offset: 0x00676F2C
		public static bool HasSpellInActionBar(int SpellID)
		{
			foreach (KeyValuePair<int, int> keyValuePair in ActionBar.GetSpellsByBar(new int[]
			{
				1,
				6
			}))
			{
				if (keyValuePair.Key == SpellID)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00678D9C File Offset: 0x00676F9C
		public static void SetSpellKeys()
		{
			if (_globals.Rotation.Count > 0)
			{
				int num = 0;
				string findSpells = SpellRotation.RotationSettings.FindSpells;
				foreach (Rotation rotation in _globals.Rotation)
				{
					if (!rotation.IsMacro)
					{
						bool flag = false;
						using (IEnumerator<ActionBar.SpellList> enumerator2 = ActionBar.GetSpells.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								ActionBar.SpellList spellList = enumerator2.Current;
								if (spellList.Bar != 1)
								{
									if (spellList.Bar != 6)
									{
										continue;
									}
								}
								if (!(findSpells == "By ID") || rotation.ID != spellList.ID)
								{
									if (!(findSpells == "By Name") || !rotation.Name.Contains(spellList.Name))
									{
										continue;
									}
								}
								rotation.Bar = spellList.Bar;
								rotation.Slot = spellList.Slot;
								rotation.BarIndex = (spellList.Bar - 1) * 12 + spellList.Slot;
								Rotation rotation2 = rotation;
								string str = "ActionBar";
								int num2 = spellList.Bar;
								string str2 = num2.ToString();
								string str3 = "_";
								num2 = spellList.Slot;
								rotation2.Key = str + str2 + str3 + num2.ToString();
								flag = true;
								break;
							}
							goto IL_168;
						}
						IL_13F:
						rotation.Bar = 0;
						rotation.Slot = 0;
						rotation.BarIndex = 0;
						rotation.Key = "";
						num++;
						continue;
						IL_168:
						if (!flag)
						{
							goto IL_13F;
						}
					}
				}
				if (num > 0)
				{
					Tools.Console(num.ToString() + " Spell(s) could not be found in your ActionBars.", "Red", "richConsole", "frmMain", true);
				}
			}
		}

		// Token: 0x0200003C RID: 60
		public struct SpellList
		{
			// Token: 0x040001DD RID: 477
			public int Bar;

			// Token: 0x040001DE RID: 478
			public int Slot;

			// Token: 0x040001DF RID: 479
			public int ID;

			// Token: 0x040001E0 RID: 480
			public string Name;
		}
	}
}
