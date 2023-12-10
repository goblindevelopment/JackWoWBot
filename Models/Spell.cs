using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Jack.Core;

namespace Jack.Models
{
	// Token: 0x02000040 RID: 64
	public class Spell
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x00679344 File Offset: 0x00677544
		public static int GetSpellID(string SpellName)
		{
			int num = _globals.List_Spells.Where(delegate(KeyValuePair<int, string> Spell)
			{
				KeyValuePair<int, string> keyValuePair = Spell;
				return keyValuePair.Value.Equals(SpellName);
			}).Select(delegate(KeyValuePair<int, string> Spell)
			{
				KeyValuePair<int, string> keyValuePair = Spell;
				return keyValuePair.Key;
			}).FirstOrDefault<int>();
			if (num > 0)
			{
				return num;
			}
			return 0;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x006793A8 File Offset: 0x006775A8
		public static string GetSpellName(int SpellID)
		{
			string text = _globals.List_Spells.Where(delegate(KeyValuePair<int, string> Spell)
			{
				KeyValuePair<int, string> keyValuePair = Spell;
				return keyValuePair.Key.Equals(SpellID);
			}).Select(delegate(KeyValuePair<int, string> Spell)
			{
				KeyValuePair<int, string> keyValuePair = Spell;
				return keyValuePair.Value;
			}).FirstOrDefault<string>();
			if (text == null || text.Length == 0)
			{
				text = "N/A";
			}
			return text;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00679414 File Offset: 0x00677614
		public static int GetRank(int SpellID)
		{
			int num = 0;
			string spellName = Spell.GetSpellName(SpellID);
			if (spellName != "N/A")
			{
				Dictionary<int, int> dictionary = new Dictionary<int, int>();
				foreach (KeyValuePair<int, int> keyValuePair in Spellbook.ReadSpells)
				{
					if (Spell.GetSpellName(keyValuePair.Key).Contains(spellName))
					{
						dictionary.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				if (dictionary.Count > 1)
				{
					(from RL in dictionary
					orderby RL.Value
					select RL).ToList<KeyValuePair<int, int>>();
					foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
					{
						num++;
						if (keyValuePair2.Key == SpellID)
						{
							break;
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00679528 File Offset: 0x00677728
		public static bool IsReadyOrExists(int SpellID, bool CheckExists = false)
		{
			long num;
			Spell.QueryPerformanceFrequency(out num);
			long num2;
			Spell.QueryPerformanceCounter(out num2);
			long num3 = num2 * 1000L / num;
			IntPtr intPtr = (IntPtr)Read.Single<IntPtr>(Offsets.Cooldown_Base + Descriptors.Cooldown_First);
			IntPtr value = intPtr;
			while (intPtr != IntPtr.Zero)
			{
				int num4 = (int)Read.Combined<int>(intPtr + Descriptors.Cooldown_SpellID);
				if (num4 == 0)
				{
					break;
				}
				if (num4 == SpellID)
				{
					if (CheckExists)
					{
						return true;
					}
					int num5 = (int)Read.Combined<int>(intPtr + Descriptors.Cooldown_RecoveryStart);
					int val = (int)Read.Combined<int>(intPtr + Descriptors.Cooldown_Recovery1);
					int val2 = (int)Read.Combined<int>(intPtr + Descriptors.Cooldown_Recovery2);
					int num6 = Math.Max(val, val2);
					if ((long)(num5 + num6) > num3)
					{
						return false;
					}
				}
				intPtr = (IntPtr)Read.Combined<IntPtr>(intPtr + Descriptors.Cooldown_Next);
				if (intPtr == value)
				{
					break;
				}
			}
			return !CheckExists;
		}

		// Token: 0x0600065E RID: 1630
		[DllImport("KERNEL32")]
		private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

		// Token: 0x0600065F RID: 1631
		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceFrequency(out long lpFrequency);
	}
}
