using System;
using System.Collections.Generic;
using System.Linq;
using Jack.Core;
using Jack.Engine;

namespace Jack.Models
{
	// Token: 0x0200003D RID: 61
	public class Spellbook
	{
		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00678F88 File Offset: 0x00677188
		public static Dictionary<int, int> ReadSpells
		{
			get
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				int level = ObjectManager.Me.Level;
				IntPtr pointer = (IntPtr)Read.Single<IntPtr>(Offsets.Spellbook_Base);
				int num = (int)Read.Single<int>(Offsets.Spellbook_Count);
				for (int i = 0; i < num; i++)
				{
					IntPtr intPtr = (IntPtr)Read.Combined<IntPtr>(pointer + Descriptors.Spellbook_Spell * i);
					if (intPtr == IntPtr.Zero)
					{
						break;
					}
					int num2 = (int)Read.Combined<int>(intPtr + Descriptors.Spellbook_SpellID);
					if (num2 != 0)
					{
						int num3 = (int)Read.Combined<int>(intPtr + Descriptors.Spellbook_RequiredLevel);
						if (!dictionary.ContainsKey(num2) && num3 <= level)
						{
							dictionary.Add(num2, num3);
						}
					}
				}
				return dictionary;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x0067904C File Offset: 0x0067724C
		public static ICollection<Spellbook.SpellList> GetSpells
		{
			get
			{
				Dictionary<string[], int> dictionary = new Dictionary<string[], int>();
				List<Spellbook.SpellList> list = new List<Spellbook.SpellList>();
				foreach (KeyValuePair<int, int> keyValuePair in Spellbook.ReadSpells)
				{
					string[] key = new string[]
					{
						keyValuePair.Key.ToString(),
						keyValuePair.Value.ToString(),
						Spell.GetSpellName(keyValuePair.Key)
					};
					dictionary.Add(key, keyValuePair.Value);
				}
				foreach (KeyValuePair<string[], int> keyValuePair2 in dictionary)
				{
					int num = 0;
					int num2 = Convert.ToInt32(keyValuePair2.Key[0]);
					int requiredLevel = Convert.ToInt32(keyValuePair2.Key[1]);
					string text = keyValuePair2.Key[2];
					if (text != "N/A")
					{
						(from RL in dictionary
						orderby RL.Value
						select RL).ToList<KeyValuePair<string[], int>>();
						foreach (KeyValuePair<string[], int> keyValuePair3 in dictionary)
						{
							if (keyValuePair3.Key[2].Contains(text))
							{
								num++;
								if (Convert.ToInt32(keyValuePair3.Key[0]) == num2)
								{
									break;
								}
							}
						}
					}
					Spellbook.SpellList item = new Spellbook.SpellList
					{
						ID = num2,
						RequiredLevel = requiredLevel,
						Name = text,
						Rank = num
					};
					list.Add(item);
				}
				return list;
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00679260 File Offset: 0x00677460
		public static ICollection<Spellbook.SpellList> GetSpellByID(int SpellID)
		{
			List<Spellbook.SpellList> list = new List<Spellbook.SpellList>();
			foreach (KeyValuePair<int, int> keyValuePair in Spellbook.ReadSpells)
			{
				if (keyValuePair.Key == SpellID)
				{
					Spellbook.SpellList item = new Spellbook.SpellList
					{
						ID = keyValuePair.Key,
						RequiredLevel = keyValuePair.Value,
						Name = Spell.GetSpellName(keyValuePair.Key),
						Rank = Spell.GetRank(keyValuePair.Key)
					};
					list.Add(item);
					break;
				}
			}
			return list;
		}

		// Token: 0x0200003E RID: 62
		public struct SpellList
		{
			// Token: 0x040001E1 RID: 481
			public int ID;

			// Token: 0x040001E2 RID: 482
			public int RequiredLevel;

			// Token: 0x040001E3 RID: 483
			public string Name;

			// Token: 0x040001E4 RID: 484
			public int Rank;
		}
	}
}
