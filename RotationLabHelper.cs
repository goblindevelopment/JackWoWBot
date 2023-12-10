using System;
using System.Collections.Generic;
using System.Linq;
using MyU9Ep58ZH3s5ThDFJQ;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x02000042 RID: 66
	public class RotationLabHelper
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0002D984 File Offset: 0x0002BB84
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0002D994 File Offset: 0x0002BB94
		public bool HealingRotation
		{
			get
			{
				return this._HealingRotation;
			}
			set
			{
				int num = 2;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (this._HealingRotation)
						{
							goto IL_59;
						}
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f40e85c0282d4285a254092b800ae8f8 == 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					case 2:
						this._HealingRotation = value;
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						goto IL_59;
					case 4:
						goto IL_79;
					}
					break;
					IL_59:
					this.TrackParty();
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
					{
						num2 = 0;
					}
				}
				goto IL_88;
				IL_79:
				return;
				IL_88:
				this.TrackRaid();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0002DA58 File Offset: 0x0002BC58
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0002DA68 File Offset: 0x0002BC68
		public bool PVPRotation
		{
			get
			{
				return this._PVPRotation;
			}
			set
			{
				this._PVPRotation = value;
				if (this._PVPRotation)
				{
					goto IL_5B;
				}
				int num = 2;
				IL_10:
				switch (num)
				{
				case 1:
					IL_5B:
					this.TrackArena();
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
					{
						num = 0;
						goto IL_10;
					}
					goto IL_10;
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0002DAFC File Offset: 0x0002BCFC
		public int SecondLastCastSpellId
		{
			get
			{
				return this.GetSpellCastHistorySpellId(1);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0002DB0C File Offset: 0x0002BD0C
		public int LastCastSpellId
		{
			get
			{
				return this.GetSpellCastHistorySpellId(0);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000594 RID: 1428 RVA: 0x0002DB1C File Offset: 0x0002BD1C
		// (remove) Token: 0x06000595 RID: 1429 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		public event EventHandler<LogEventArgs> NewLogEvent;

		// Token: 0x06000596 RID: 1430 RVA: 0x0002DB9C File Offset: 0x0002BD9C
		public SpellCast GetSpellCastHistory(int castIndex)
		{
			if (RotationLabHelper.yuXQ1qO9WC7rEH7F4uY(this.SpellCastHistory) > 0)
			{
				IL_92:
				while (castIndex >= 0)
				{
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 1:
							goto IL_92;
						case 2:
							if (castIndex >= this.SpellCastHistory.Count)
							{
								num = 3;
								continue;
							}
							break;
						case 3:
							goto IL_73;
						}
						break;
					}
					return this.SpellCastHistory[castIndex];
					IL_73:
					break;
				}
			}
			return null;
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0002DC64 File Offset: 0x0002BE64
		public int GetSpellCastHistorySpellId(int castIndex)
		{
			SpellCast spellCastHistory = this.GetSpellCastHistory(castIndex);
			if (spellCastHistory != null)
			{
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_408cdf8d10324497825639e7638db7b2 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				return spellCastHistory.SpellId;
			}
			return 0;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0002DCC8 File Offset: 0x0002BEC8
		public int TimeSinceSpellCast(int spellId)
		{
			int num = 6;
			int num2 = num;
			int num3;
			DateTimeOffset now;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11B;
				case 1:
					goto IL_71;
				case 2:
					goto IL_E0;
				case 3:
					return 9999999;
				case 4:
					break;
				case 5:
					num3 = 0;
					goto IL_E0;
				case 6:
					if (this.SpellCastHistory.Count <= 0)
					{
						return 9999999;
					}
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 != 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				default:
					goto IL_11B;
				}
				IL_3F:
				if (this.SpellCastHistory[num3].SpellId != spellId)
				{
					num3++;
					num2 = 2;
					continue;
				}
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 != 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_11B:
				now = DateTimeOffset.Now;
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 == 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_E0:
				if (num3 < this.SpellCastHistory.Count)
				{
					goto IL_3F;
				}
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a != 0)
				{
					num2 = 3;
				}
			}
			IL_71:
			return (int)RotationLabHelper.FMRNpaOwjuXuNspPJc6((double)(now.ToUnixTimeMilliseconds() - this.SpellCastHistory[num3].Timestamp) / 10.0);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0002DE18 File Offset: 0x0002C018
		public bool IsModifierKeyPressed(string modifierName)
		{
			return this._ModifierList.ContainsKey(modifierName) && this._ModifierList[modifierName];
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0002DE48 File Offset: 0x0002C048
		public void _AddSpellName(int spellId, string name)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 2:
					if (this._SpellID2Name.ContainsKey(spellId))
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					else
					{
						this._SpellID2Name.Add(spellId, name);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0002DEE0 File Offset: 0x0002C0E0
		public void _AddItemName(int itemId, string name)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 2:
					if (this._ItemID2Name.ContainsKey(itemId))
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1259d5d4e4144ef5a0c05f808ad73078 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					else
					{
						this._ItemID2Name.Add(itemId, name);
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_827c6d37267a42a5864c59085f394f8f != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0002DF78 File Offset: 0x0002C178
		public string _GetSpellName(int spellId)
		{
			if (this._SpellID2Name.ContainsKey(spellId))
			{
				return this._SpellID2Name[spellId];
			}
			return spellId.ToString();
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		public string _GetItemName(int itemId)
		{
			if (this._ItemID2Name.ContainsKey(itemId))
			{
				return this._ItemID2Name[itemId];
			}
			return itemId.ToString();
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
		public void TrackParty()
		{
			if (!this.isTrackingParty)
			{
				this._UnitList.AddRange(this._PartyUnitList);
				int num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f == 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.isTrackingParty = true;
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 != 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0002E074 File Offset: 0x0002C274
		public void TrackArena()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.isTrackingArena)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				}
				this._UnitList.AddRange(this._ArenaUnitList);
				this.isTrackingArena = true;
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0002E10C File Offset: 0x0002C30C
		public void TrackRaid()
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.isTrackingRaid)
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				}
				this._UnitList.AddRange(this._RaidUnitList);
				this.isTrackingRaid = true;
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0002E1A4 File Offset: 0x0002C3A4
		public void _ProgrammaticCast(string key)
		{
			this.ProgramCastTable[key] = RotationLabHelper.b7X0pGOAXC9CJBs0IJK().ToUnixTimeSeconds();
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0002E1D8 File Offset: 0x0002C3D8
		public void _PlayerManualCast(string key)
		{
			int num = 17;
			int num2 = num;
			for (;;)
			{
				Dictionary<string, string>.Enumerator enumerator;
				int num5;
				Dictionary<int, string>.Enumerator enumerator2;
				switch (num2)
				{
				case 0:
					goto IL_4FF;
				case 1:
					this._ManualCastType = 0;
					num2 = 5;
					continue;
				case 2:
					return;
				case 3:
					goto IL_4CA;
				case 4:
					goto IL_82;
				case 5:
					goto IL_4A3;
				case 6:
					break;
				case 7:
					try
					{
						for (;;)
						{
							IL_3F0:
							int num3;
							KeyValuePair<string, string> keyValuePair;
							if (!enumerator.MoveNext())
							{
								num3 = 4;
							}
							else
							{
								keyValuePair = enumerator.Current;
								num3 = 5;
							}
							for (;;)
							{
								switch (num3)
								{
								default:
								{
									DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
									this._ManualCastQueueTimestamp = dateTimeOffset.ToUnixTimeMilliseconds();
									num3 = 1;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 != 0)
									{
										num3 = 0;
									}
									break;
								}
								case 1:
									goto IL_3F0;
								case 2:
									this._ManualCastType = 3;
									num3 = 3;
									break;
								case 3:
									this._ManualCastQueueMacroName = keyValuePair.Key;
									num3 = 0;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
									{
										num3 = 0;
									}
									break;
								case 4:
									goto IL_481;
								case 5:
								{
									if (!(keyValuePair.Value == key))
									{
										goto IL_3F0;
									}
									int num4 = 6;
									num3 = num4;
									break;
								}
								case 6:
									num5++;
									num3 = 2;
									break;
								}
							}
						}
						IL_481:
						break;
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					goto IL_4A3;
				case 8:
					return;
				case 9:
					return;
				case 10:
					try
					{
						for (;;)
						{
							if (enumerator2.MoveNext())
							{
								goto IL_121;
							}
							int num6 = 3;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fd0c1f052d0e476eab1db9043408a8d6 != 0)
							{
								num6 = 3;
							}
							KeyValuePair<int, string> keyValuePair2;
							for (;;)
							{
								IL_A3:
								switch (num6)
								{
								case 1:
								{
									this._ManualCastType = 2;
									this._ManualCastQueueItemID = keyValuePair2.Key;
									int num7 = 4;
									num6 = num7;
									continue;
								}
								case 2:
									num5++;
									num6 = 1;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
									{
										num6 = 0;
										continue;
									}
									continue;
								case 3:
									goto IL_1A3;
								case 4:
								{
									DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
									this._ManualCastQueueTimestamp = dateTimeOffset.ToUnixTimeMilliseconds();
									num6 = 0;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b == 0)
									{
										num6 = 0;
										continue;
									}
									continue;
								}
								case 5:
									goto IL_121;
								case 6:
									if (RotationLabHelper.fH16UaOhc4aBA3Erl2h(keyValuePair2.Value, key))
									{
										num6 = 2;
										if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
										{
											num6 = 1;
											continue;
										}
										continue;
									}
									break;
								}
								break;
							}
							continue;
							IL_121:
							keyValuePair2 = enumerator2.Current;
							num6 = 6;
							goto IL_A3;
						}
						IL_1A3:
						goto IL_4CA;
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					goto IL_1D5;
				case 11:
					return;
				case 12:
					this._ManualCastType = 0;
					num2 = 19;
					continue;
				case 13:
					try
					{
						for (;;)
						{
							IL_2DF:
							if (enumerator2.MoveNext())
							{
								goto IL_32B;
							}
							int num8 = 5;
							int num9 = num8;
							KeyValuePair<int, string> keyValuePair3;
							for (;;)
							{
								IL_25F:
								switch (num9)
								{
								case 1:
									goto IL_2DF;
								case 2:
								{
									this._ManualCastQueueSpellID = keyValuePair3.Key;
									DateTimeOffset dateTimeOffset = RotationLabHelper.b7X0pGOAXC9CJBs0IJK();
									this._ManualCastQueueTimestamp = dateTimeOffset.ToUnixTimeMilliseconds();
									num9 = 1;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 == 0)
									{
										num9 = 1;
										continue;
									}
									continue;
								}
								case 3:
									if (!(keyValuePair3.Value == key))
									{
										goto IL_2DF;
									}
									num9 = 0;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
									{
										num9 = 0;
										continue;
									}
									continue;
								case 4:
									goto IL_32B;
								case 5:
									goto IL_36F;
								case 6:
									this._ManualCastType = 1;
									num9 = 2;
									if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 != 0)
									{
										num9 = 1;
										continue;
									}
									continue;
								}
								num5++;
								num9 = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
								{
									num9 = 6;
								}
							}
							IL_32B:
							keyValuePair3 = enumerator2.Current;
							num9 = 1;
							if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 == 0)
							{
								num9 = 3;
								goto IL_25F;
							}
							goto IL_25F;
						}
						IL_36F:
						goto IL_1FC;
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
					return;
					IL_1FC:
					if (num5 == 1)
					{
						num2 = 15;
						continue;
					}
					num5 = 0;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 14:
					goto IL_1D5;
				case 15:
					return;
				case 16:
					if (this.ProgramCastTable.ContainsKey(key))
					{
						DateTimeOffset dateTimeOffset = DateTimeOffset.Now;
						num2 = 18;
						continue;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
				case 17:
					if (this._EnableManualCastQueue)
					{
						num2 = 16;
						continue;
					}
					return;
				case 18:
				{
					DateTimeOffset dateTimeOffset;
					if (dateTimeOffset.ToUnixTimeSeconds() - this.ProgramCastTable[key] <= 1500L)
					{
						num2 = 8;
						continue;
					}
					goto IL_82;
				}
				case 19:
					enumerator2 = this._ItemKeyBind.GetEnumerator();
					num2 = 10;
					continue;
				default:
					goto IL_4FF;
				}
				if (num5 != 1)
				{
					num5 = 0;
					num2 = 12;
					continue;
				}
				num2 = 11;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
				{
					num2 = 10;
					continue;
				}
				continue;
				IL_82:
				num5 = 0;
				num2 = 14;
				continue;
				IL_1D5:
				enumerator2 = this._SpellKeyBind.GetEnumerator();
				num2 = 13;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b7f67e3eba18452ab17dba1f1cebde43 != 0)
				{
					num2 = 4;
					continue;
				}
				continue;
				IL_4CA:
				if (num5 == 1)
				{
					return;
				}
				num5 = 0;
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_4A3:
				enumerator = this._MacroKeyBind.GetEnumerator();
				num2 = 6;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a != 0)
				{
					num2 = 7;
					continue;
				}
				continue;
				IL_4FF:
				this._ManualCastType = 0;
				num2 = 9;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5b41e96a488843f6bf9e80607461149a == 0)
				{
					num2 = 4;
				}
			}
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0002E828 File Offset: 0x0002CA28
		public void _SetSpellKeybind(int spellId, string key)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (!this._SpellKeyBind.ContainsKey(spellId))
					{
						num2 = 4;
						continue;
					}
					goto IL_57;
				case 2:
					if (!RotationLabHelper.Rsld5OOSFtpr4xcybEP(key, ""))
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				case 3:
					return;
				case 4:
					goto IL_6E;
				case 5:
					goto IL_57;
				}
				break;
				IL_57:
				this._SpellKeyBind.Remove(spellId);
				num2 = 3;
			}
			goto IL_AC;
			IL_6E:
			return;
			IL_AC:
			this._SpellKeyBind[spellId] = key;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0002E920 File Offset: 0x0002CB20
		public void _SetItemKeybind(int itemId, string key)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					this._ItemKeyBind[itemId] = key;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					if (RotationLabHelper.Rsld5OOSFtpr4xcybEP(key, ""))
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					else
					{
						if (this._ItemKeyBind.ContainsKey(itemId))
						{
							this._ItemKeyBind.Remove(itemId);
							num2 = 3;
							continue;
						}
						return;
					}
					break;
				case 3:
					return;
				}
				break;
			}
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0002E9E0 File Offset: 0x0002CBE0
		public void _SetMacroKeybind(string macroName, string key)
		{
			int num = 3;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						return;
					case 2:
						if (!this._MacroKeyBind.ContainsKey(macroName))
						{
							return;
						}
						this._MacroKeyBind.Remove(macroName);
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						if (!(key != ""))
						{
							goto Block_3;
						}
						break;
					case 4:
						return;
					}
					this._MacroKeyBind[macroName] = key;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e != 0)
					{
						num2 = 1;
					}
				}
				Block_3:
				num = 2;
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0002EAC8 File Offset: 0x0002CCC8
		public void _SetModifierKeybind(string modifierName, string key)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_A4;
				case 2:
					if (!this._ModifierKeyBind.ContainsKey(modifierName))
					{
						return;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					if (!RotationLabHelper.Rsld5OOSFtpr4xcybEP(key, ""))
					{
						num2 = 2;
						continue;
					}
					goto IL_7D;
				case 4:
					goto IL_7D;
				}
				break;
				IL_7D:
				this._ModifierKeyBind[modifierName] = key;
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd != 0)
				{
					num2 = 0;
				}
			}
			return;
			IL_A4:
			this._ModifierKeyBind.Remove(modifierName);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0002EBAC File Offset: 0x0002CDAC
		public string _GetSpellKeybind(int spellId)
		{
			if (this._SpellKeyBind.ContainsKey(spellId))
			{
				return this._SpellKeyBind[spellId];
			}
			return "";
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0002EBE0 File Offset: 0x0002CDE0
		public string _GetItemKeybind(int itemId)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2B;
				case 1:
					if (this._ItemKeyBind.ContainsKey(itemId))
					{
						goto IL_60;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			return "";
			IL_60:
			return this._ItemKeyBind[itemId];
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0002EC60 File Offset: 0x0002CE60
		public string _GetMacroKeybind(string macroName)
		{
			if (!this._MacroKeyBind.ContainsKey(macroName))
			{
				return "";
			}
			return this._MacroKeyBind[macroName];
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0002ECD4 File Offset: 0x0002CED4
		public bool ToggleAOE
		{
			get
			{
				return this._ToggleOptionEnabled[1];
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x0002ECE8 File Offset: 0x0002CEE8
		public bool TogglePause
		{
			get
			{
				return this._ToggleOptionEnabled[0];
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060005AC RID: 1452 RVA: 0x0002ECFC File Offset: 0x0002CEFC
		// (remove) Token: 0x060005AD RID: 1453 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		public event EventHandler<DoSpellCastArgs> DoSpellCast;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060005AE RID: 1454 RVA: 0x0002ED7C File Offset: 0x0002CF7C
		// (remove) Token: 0x060005AF RID: 1455 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		public event EventHandler<DoItemCastArgs> DoItemCast;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060005B0 RID: 1456 RVA: 0x0002EDFC File Offset: 0x0002CFFC
		// (remove) Token: 0x060005B1 RID: 1457 RVA: 0x0002EE3C File Offset: 0x0002D03C
		public event EventHandler<DoMacroCastArgs> DoMacroCast;

		// Token: 0x060005B2 RID: 1458 RVA: 0x0002EE7C File Offset: 0x0002D07C
		public void CastSpell(int spellId)
		{
			EventHandler<DoSpellCastArgs> doSpellCast = this.DoSpellCast;
			if (doSpellCast == null)
			{
				return;
			}
			doSpellCast(this, new DoSpellCastArgs(spellId));
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
		public void UseItem(int itemId)
		{
			EventHandler<DoItemCastArgs> doItemCast = this.DoItemCast;
			if (doItemCast == null)
			{
				return;
			}
			doItemCast(this, new DoItemCastArgs(itemId));
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0002EF54 File Offset: 0x0002D154
		public void UseMacro(string macroName)
		{
			int num = 1;
			int num2 = num;
			EventHandler<DoMacroCastArgs> doMacroCast;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					doMacroCast = this.DoMacroCast;
					if (doMacroCast != null)
					{
						goto Block_2;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return;
			Block_2:
			doMacroCast(this, new DoMacroCastArgs(macroName));
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0002EFCC File Offset: 0x0002D1CC
		public bool CanUseItem(int itemId, int preCastOverride = -1)
		{
			int num = this.PreCastTimeWindow;
			if (preCastOverride < 0)
			{
				goto IL_76;
			}
			int num2 = 2;
			for (;;)
			{
				IL_10:
				switch (num2)
				{
				case 1:
					goto IL_CA;
				case 2:
					num = preCastOverride;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					goto IL_62;
				case 4:
					goto IL_3B;
				}
				break;
			}
			goto IL_76;
			IL_62:
			return this.ItemCooldownDuration(itemId) <= num / 10;
			IL_CA:
			return false;
			IL_3B:
			if (this.ItemCount(itemId) > 0)
			{
				num2 = 3;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
				{
					num2 = 0;
					goto IL_10;
				}
				goto IL_10;
			}
			return false;
			IL_76:
			if (!this.ItemIsDisabled(itemId))
			{
				goto IL_3B;
			}
			num2 = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b8bb7cdbcd66488bbe9aea1b375752f3 != 0)
			{
				num2 = 1;
				goto IL_10;
			}
			goto IL_10;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		public bool HasGlyph(int glyphSpellId)
		{
			return this.GlyphList.Contains(glyphSpellId);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0002F0D0 File Offset: 0x0002D2D0
		public bool CanCastSpell(int spellId, int preCastOverride = -1, bool rangeCheck = false)
		{
			int num = 3;
			int num2 = num;
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_68;
				case 1:
					goto IL_B0;
				case 2:
					if (preCastOverride < 0)
					{
						goto IL_68;
					}
					break;
				case 3:
					num3 = this.PreCastTimeWindow;
					num2 = 2;
					continue;
				case 4:
					return false;
				case 5:
					break;
				case 6:
					goto IL_F0;
				case 7:
					goto IL_12C;
				case 8:
					return false;
				case 9:
					goto IL_A1;
				default:
					goto IL_68;
				}
				num3 = preCastOverride;
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_daf45904bfaa4c9ca932e5fef26f8db2 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_68:
				if (RotationLabHelper.fH16UaOhc4aBA3Erl2h(this._GetSpellKeybind(spellId), ""))
				{
					num2 = 8;
					continue;
				}
				if (rangeCheck && !this.SpellIsInRange(spellId))
				{
					num2 = 4;
					continue;
				}
				if (this.SpellIsDisabled(spellId))
				{
					num2 = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				IL_12C:
				if (this.SpellIsUsable(spellId))
				{
					goto IL_F0;
				}
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 != 0)
				{
					num2 = 0;
				}
			}
			return false;
			IL_A1:
			IL_B0:
			return false;
			IL_F0:
			return this.SpellCooldownDuration(spellId) <= num3 / 10;
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0002F244 File Offset: 0x0002D444
		public bool SpellIsInRange(int spellId)
		{
			return this.SpellIsKnown(spellId) && this._SpellInfo[spellId].IsInRange;
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0002F278 File Offset: 0x0002D478
		public bool CanUseMacro(string macroName, int preCastOverride = -1)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_19F;
				case 1:
				{
					int num3 = this.PreCastTimeWindow;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				case 2:
				{
					int num3;
					if (this.SpellCooldownDuration(this._MacroList[macroName].SpellID) > num3 / 10)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 == 0)
						{
							num2 = 3;
							continue;
						}
						continue;
					}
					break;
				}
				case 3:
					return false;
				case 4:
					if (this._MacroList[macroName].SpellID > 0)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_62a8cf43711147aba48e59420bf61060 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				case 5:
					if (!this._MacroList.ContainsKey(macroName))
					{
						goto IL_103;
					}
					num2 = 4;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 6:
					goto IL_1C0;
				case 7:
					if (this.CanUseItem(this._MacroList[macroName].ItemID, preCastOverride))
					{
						goto IL_103;
					}
					num2 = 9;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 == 0)
					{
						num2 = 9;
						continue;
					}
					continue;
				case 8:
					return false;
				case 9:
					return false;
				default:
					goto IL_19F;
				}
				if (this._MacroList[macroName].ItemID > 0)
				{
					num2 = 7;
					continue;
				}
				IL_103:
				if (RotationLabHelper.fH16UaOhc4aBA3Erl2h(this._GetMacroKeybind(macroName), ""))
				{
					num2 = 8;
					continue;
				}
				goto IL_4D;
				IL_19F:
				if (preCastOverride < 0)
				{
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				}
				else
				{
					int num3 = preCastOverride;
				}
				IL_1C0:
				if (!this.SpellIsUsable(this._MacroList[macroName].SpellID))
				{
					return false;
				}
				num2 = 2;
			}
			return false;
			IL_4D:
			return !this.MacroIsDisabled(macroName);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0002F46C File Offset: 0x0002D66C
		public bool Toggle(string toggleName)
		{
			int num = this._InGameToggleList.IndexOf(toggleName);
			if (num > -1)
			{
				int num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				return this._ToggleOptionEnabled[num];
			}
			return false;
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0002F4D8 File Offset: 0x0002D6D8
		public string _GetToggleMenuText(int menuIndex, int selectedIndex)
		{
			int num = 2;
			int num2 = num;
			string[] array;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DD;
				case 1:
					goto IL_DD;
				case 2:
					if (RotationLabHelper.SHtTxZOIdGEcj8m4wNr(this._InGameToggleList) > menuIndex)
					{
						goto IL_177;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_10efcbc7d65a482a889c795c7b640c03 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 3:
					goto IL_6C;
				case 4:
					break;
				case 5:
					break;
				case 6:
					goto IL_D7;
				case 7:
					array = this._InGameToggleList[menuIndex].Split(new char[]
					{
						'|'
					}).Skip(1).ToArray<string>();
					if (selectedIndex <= 0)
					{
						num2 = 2;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 != 0)
						{
							num2 = 5;
							continue;
						}
						continue;
					}
					else
					{
						if (array.Length >= selectedIndex)
						{
							goto IL_6C;
						}
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5570c327a6334a12993e71a93a06169a != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					break;
				case 8:
					goto IL_1C6;
				case 9:
					goto IL_177;
				default:
					goto IL_DD;
				}
				this.WriteLog(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1905767247 ^ 1905785783) + selectedIndex.ToString());
				num2 = 8;
				continue;
				IL_DD:
				this.WriteLog(RotationLabHelper.jLUIm5OUdsiJ4jIYyLO(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1505789866 ^ -1505808120), menuIndex.ToString()));
				num2 = 6;
				continue;
				IL_177:
				if (!RotationLabHelper.T7fw3VOZa2rXHlQYoMS(this._InGameToggleList[menuIndex], RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1055311542 ^ 1055297092)))
				{
					goto IL_DD;
				}
				num2 = 7;
			}
			IL_6C:
			return array[selectedIndex - 1];
			IL_D7:
			return "";
			IL_1C6:
			goto IL_D7;
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002F6CC File Offset: 0x0002D8CC
		public string ToggleMenu(string menuName)
		{
			int num = 6;
			int num2 = num;
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_97;
				case 2:
					goto IL_B3;
				case 3:
					goto IL_87;
				case 4:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-33448599 >> 2 ^ -8376596) + menuName);
					num2 = 3;
					continue;
				case 5:
					goto IL_97;
				case 6:
					num3 = 0;
					num2 = 5;
					continue;
				}
				num3++;
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 != 0)
				{
					num2 = 1;
					continue;
				}
				continue;
				IL_97:
				if (num3 >= this._InGameToggleList.Count)
				{
					num2 = 4;
				}
				else
				{
					if (this._InGameToggleList[num3].StartsWith(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789419076 ^ -35552607 ^ 756261359) + menuName + RotationLabHelper.JHj9LgOi1oyoBrjIhFT(2040894867 + -686633457 ^ 1354266572)))
					{
						goto IL_B3;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba == 0)
					{
						num2 = 0;
					}
				}
			}
			IL_87:
			return "";
			IL_B3:
			return this._GetToggleMenuText(num3, this._ToggleSelectIndex[num3]);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0002F820 File Offset: 0x0002DA20
		public bool IsTalentSelectedRetail(int column, int row)
		{
			int num = 7;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_74;
				case 2:
					goto IL_BF;
				case 3:
					if (column >= 3)
					{
						return false;
					}
					if (row >= 0)
					{
						goto IL_ED;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_048cbf45e2414893ae0803941a76e8e0 != 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				case 4:
					goto IL_43;
				case 5:
					goto IL_ED;
				case 6:
					column--;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923d36d0be6e41d5945d4b2a6e0fe214 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					row--;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a != 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				}
				if (column >= 0)
				{
					num2 = 3;
					continue;
				}
				return false;
				IL_ED:
				if (row < 25)
				{
					break;
				}
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f07fcafdab6044ae94aa2a4d4d748d5c != 0)
				{
					num2 = 1;
				}
			}
			IL_43:
			return RotationLabHelper.tF6KZfO1HsHVLDwX48Z(this._TalentTree, column, row);
			IL_74:
			IL_BF:
			return false;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0002F93C File Offset: 0x0002DB3C
		public bool IsTalentSelectedClassic(int spellBookTab, int spellIndex)
		{
			return this.IsTalentSelectedRetail(spellBookTab, spellIndex);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0002F950 File Offset: 0x0002DB50
		public int PlayerNextRuneCD()
		{
			return this._PlayerRuneCD.Min();
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0002F964 File Offset: 0x0002DB64
		public int PlayerRuneCD(int runeIndex)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (runeIndex >= 0)
					{
						goto IL_33;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_33;
				case 3:
					goto IL_67;
				}
				break;
			}
			goto IL_76;
			IL_33:
			if (runeIndex >= this._PlayerRuneCD.Length)
			{
				return 999999;
			}
			IL_67:
			return this._PlayerRuneCD[runeIndex];
			IL_76:
			return 999999;
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0002FA14 File Offset: 0x0002DC14
		public int PlayerRunesOnCD()
		{
			int num = 2;
			int num2 = num;
			int num4;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 1:
					num3 = 0;
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0e5e3d7d8cdf4d2a9040ab7043b65fe6 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
				case 2:
					num4 = 0;
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c835c27d43a14f3da6b7339e694b8c99 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					goto IL_126;
				case 4:
					goto IL_CF;
				case 5:
					goto IL_73;
				case 6:
					goto IL_8F;
				case 7:
					goto IL_126;
				case 8:
					goto IL_CF;
				}
				break;
				IL_73:
				if (num3 < this._PlayerRuneCD.Count<int>())
				{
					num2 = 4;
					continue;
				}
				break;
				IL_126:
				num3++;
				goto IL_73;
				IL_8F:
				num4++;
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_40d264c41f474fea9eba2908d12918c1 == 0)
				{
					num2 = 7;
					continue;
				}
				continue;
				IL_CF:
				if (this._PlayerRuneCD[num3] > 0)
				{
					goto IL_8F;
				}
				num2 = 3;
			}
			return num4;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0002FB54 File Offset: 0x0002DD54
		public int PlayerRuneType(int runeIndex)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_57;
				case 2:
					if (runeIndex < 0)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					else
					{
						if (runeIndex >= this._PlayerRuneType.Length)
						{
							return 0;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			goto IL_61;
			IL_57:
			return 0;
			IL_61:
			return this._PlayerRuneType[runeIndex];
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		public int PlayerRuneCount(int runeType, bool checkCD = true)
		{
			int num = 14;
			int num3;
			for (;;)
			{
				int num2 = num;
				int num4;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_F7;
					case 2:
						goto IL_96;
					case 3:
						goto IL_15B;
					case 4:
						goto IL_104;
					case 5:
						goto IL_B6;
					case 6:
						goto IL_B6;
					case 7:
						goto IL_E6;
					case 8:
						goto IL_132;
					case 10:
						goto IL_172;
					case 12:
						goto IL_1DD;
					case 13:
						if (runeType <= 0)
						{
							num2 = 9;
							continue;
						}
						goto IL_E6;
					case 14:
						num3 = 0;
						num2 = 13;
						continue;
					case 15:
						if (this._PlayerRuneType[num4] == 4)
						{
							num2 = 2;
							continue;
						}
						goto IL_172;
					case 16:
						goto IL_15B;
					}
					return num3;
					IL_96:
					if (checkCD)
					{
						goto IL_1DD;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f1e441e915f3465198512fda3e140bf5 == 0)
					{
						num2 = 5;
						continue;
					}
					continue;
					IL_132:
					if (this._PlayerRuneType[num4] == runeType)
					{
						goto IL_96;
					}
					num2 = 15;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
					{
						num2 = 15;
						continue;
					}
					continue;
					IL_15B:
					if (num4 < this._PlayerRuneType.Count<int>())
					{
						goto IL_132;
					}
					return num3;
					IL_B6:
					num3++;
					num2 = 10;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 != 0)
					{
						num2 = 9;
						continue;
					}
					continue;
					IL_E6:
					if (runeType > 4)
					{
						num2 = 11;
						continue;
					}
					IL_F7:
					num4 = 0;
					num2 = 16;
					continue;
					IL_1DD:
					if (this.PlayerRuneCD(num4) != 0)
					{
						break;
					}
					num3++;
					num2 = 4;
				}
				IL_172:
				num4++;
				num = 3;
				continue;
				IL_104:
				goto IL_172;
			}
			return num3;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0002FDEC File Offset: 0x0002DFEC
		public int GetPlayerPower(int powerIndex)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2F;
				case 1:
					if (powerIndex >= this._PlayerPower.Length)
					{
						return 0;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					goto IL_3B;
				}
			}
			IL_2F:
			if (powerIndex < 0)
			{
				return 0;
			}
			IL_3B:
			return this._PlayerPower[powerIndex];
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0002FE88 File Offset: 0x0002E088
		public int GetPlayerPowerMax(int powerIndex)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (powerIndex >= 0)
					{
						goto IL_78;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c609793e83ea4d9f8a76fd0fe20634d3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					if (powerIndex < this._PlayerPowerMax.Length)
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 == 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			goto IL_83;
			IL_78:
			return this._PlayerPowerMax[powerIndex];
			IL_83:
			return 0;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0002FF24 File Offset: 0x0002E124
		public int GetPlayerPowerPercent(int powerIndex)
		{
			int playerPowerMax = this.GetPlayerPowerMax(powerIndex);
			if (playerPowerMax > 0)
			{
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				return Convert.ToInt32(RotationLabHelper.FMRNpaOwjuXuNspPJc6((double)this.GetPlayerPower(powerIndex) / (double)playerPowerMax * 100.0));
			}
			return 0;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0002FFA4 File Offset: 0x0002E1A4
		public bool ItemCanUse(int itemId)
		{
			return this._ItemInfo.ContainsKey(itemId);
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0002FFBC File Offset: 0x0002E1BC
		public int ItemCooldownDuration(int itemId)
		{
			if (!this.ItemCanUse(itemId))
			{
				return 999999;
			}
			return this._ItemInfo[itemId].CooldownRemaining;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00030030 File Offset: 0x0002E230
		public bool ItemIsOnCooldown(int itemId)
		{
			return this.ItemCooldownDuration(itemId) > 0;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00030044 File Offset: 0x0002E244
		public int ItemCount(int itemId)
		{
			if (this.ItemCanUse(itemId))
			{
				return this._ItemInfo[itemId].Count;
			}
			return 0;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00030078 File Offset: 0x0002E278
		public bool SpellIsKnown(int spellId)
		{
			return this._SpellInfo.ContainsKey(spellId);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00030090 File Offset: 0x0002E290
		public bool SpellIsUsable(int spellId)
		{
			return this.SpellIsKnown(spellId) && this._SpellInfo[spellId].Usable;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00030100 File Offset: 0x0002E300
		public bool SpellHasMana(int spellId)
		{
			return this.SpellIsKnown(spellId) && !this._SpellInfo[spellId].NoMana;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00030130 File Offset: 0x0002E330
		public int SpellCooldownDuration(int spellId)
		{
			if (this.SpellIsKnown(spellId))
			{
				return this._SpellInfo[spellId].CooldownRemaining;
			}
			return 999999;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00030164 File Offset: 0x0002E364
		public bool SpellIsOnCooldown(int spellId, int preCastOverride = -1)
		{
			int num = this.PreCastTimeWindow;
			if (preCastOverride >= 0)
			{
				int num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e != 0)
				{
					num2 = 1;
				}
				for (;;)
				{
					switch (num2)
					{
					case 1:
						num = preCastOverride;
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}
			return this.SpellCooldownDuration(spellId) > num / 10;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x000301EC File Offset: 0x0002E3EC
		public int SpellCurrentCharge(int spellId)
		{
			if (this.SpellIsKnown(spellId))
			{
				return this._SpellInfo[spellId].ChargeCurrent;
			}
			return 0;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0003021C File Offset: 0x0002E41C
		public int SpellTotalChargeTime(int spellId)
		{
			if (this.SpellIsKnown(spellId))
			{
				return this._SpellInfo[spellId].ChargeTime;
			}
			return 0;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00030250 File Offset: 0x0002E450
		public double SpellCurrentChargeFraction(int spellId)
		{
			int num = 2;
			double num3;
			for (;;)
			{
				int num2 = num;
				double num4;
				double num5;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_F8;
					case 2:
						if (this.SpellIsKnown(spellId))
						{
							goto IL_43;
						}
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						num3 += (num4 - num5) / num4;
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f != 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 4:
						num4 = (double)this.SpellTotalChargeTime(spellId);
						num2 = 7;
						continue;
					case 5:
						goto IL_43;
					case 6:
						num5 = (double)this.SpellChargeCooldownDuration(spellId);
						num2 = 4;
						continue;
					case 7:
						goto IL_A9;
					}
					return num3;
					IL_43:
					num3 = (double)this.SpellCurrentCharge(spellId);
					num2 = 6;
				}
				IL_A9:
				if (num5 <= 0.0 || num4 <= 0.0)
				{
					break;
				}
				num = 3;
			}
			return num3;
			IL_F8:
			return 0.0;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00030378 File Offset: 0x0002E578
		public int SpellMaxCharge(int spellId)
		{
			if (this.SpellIsKnown(spellId))
			{
				return this._SpellInfo[spellId].ChargeMax;
			}
			return 0;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x000303A8 File Offset: 0x0002E5A8
		public int SpellChargeCooldownDuration(int spellId)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return 999999;
				case 1:
					if (this.SpellIsKnown(spellId))
					{
						goto IL_35;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5a783af3da954710be4da15470ca6dd2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			return 999999;
			IL_35:
			return this._SpellInfo[spellId].ChargeCooldownRemaining;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00030428 File Offset: 0x0002E628
		public bool UnitExists(string unit)
		{
			return this._UnitInfo.ContainsKey(unit);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00030440 File Offset: 0x0002E640
		public bool UnitHasBuff(string unit, int spellId, bool playerCasted = false)
		{
			if (!this.UnitExists(unit))
			{
				return false;
			}
			if (this._UnitInfo[unit].Buffs.ContainsKey(spellId))
			{
				goto IL_A1;
			}
			int num = 3;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 == 0)
			{
				num = 3;
			}
			IL_10:
			switch (num)
			{
			case 0:
				goto IL_A1;
			case 1:
				return false;
			case 2:
				break;
			case 3:
				return false;
			case 4:
				return true;
			default:
				goto IL_A1;
			}
			IL_2E:
			if (!this._UnitInfo[unit].Buffs[spellId].SrcPlayer)
			{
				num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af == 0)
				{
					num = 1;
					goto IL_10;
				}
				goto IL_10;
			}
			return true;
			IL_A1:
			if (playerCasted)
			{
				goto IL_2E;
			}
			num = 4;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_69e534c26f724032be7eb1d4c6a60655 == 0)
			{
				num = 4;
				goto IL_10;
			}
			goto IL_10;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00030564 File Offset: 0x0002E764
		public int UnitBuffDuration(string unit, int spellId, bool playerCasted = false)
		{
			if (!this.UnitHasBuff(unit, spellId, playerCasted))
			{
				return 0;
			}
			return this._UnitInfo[unit].Buffs[spellId].TimeRemaining;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x000305E0 File Offset: 0x0002E7E0
		public int UnitBuffStacks(string unit, int spellId, bool playerCasted = false)
		{
			if (!this.UnitHasBuff(unit, spellId, playerCasted))
			{
				return 0;
			}
			return this._UnitInfo[unit].Buffs[spellId].Stacks;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0003065C File Offset: 0x0002E85C
		public bool UnitHasDebuff(string unit, int spellId, bool playerCasted = false)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (!this.UnitExists(unit))
					{
						return false;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d40d00282484c3192de8d3f455be896 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return false;
				case 3:
					if (this._UnitInfo[unit].Debuffs[spellId].SrcPlayer)
					{
						return true;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e4c3e507bea3489ca1e59bddf0d58f83 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				if (!this._UnitInfo[unit].Debuffs.ContainsKey(spellId))
				{
					return false;
				}
				if (!playerCasted)
				{
					return true;
				}
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
				{
					num2 = 3;
				}
			}
			return false;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00030748 File Offset: 0x0002E948
		public int UnitDebuffDuration(string unit, int spellId, bool playerCasted = false)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.UnitHasDebuff(unit, spellId, playerCasted))
					{
						goto IL_53;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return 0;
			IL_53:
			return this._UnitInfo[unit].Debuffs[spellId].TimeRemaining;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000307D0 File Offset: 0x0002E9D0
		public int UnitDebuffStacks(string unit, int spellId, bool playerCasted = false)
		{
			if (this.UnitHasDebuff(unit, spellId, playerCasted))
			{
				return this._UnitInfo[unit].Debuffs[spellId].Stacks;
			}
			return 0;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0003080C File Offset: 0x0002EA0C
		public int UnitNPCID(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].NPCID;
			}
			return 0;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00030840 File Offset: 0x0002EA40
		public int UnitCurrentCastID(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].CurrentCastID;
			}
			return 0;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00030874 File Offset: 0x0002EA74
		public int UnitCurrentCastElapsedDuration(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].CurrentCastElapsedDuration;
			}
			return 0;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x000308A4 File Offset: 0x0002EAA4
		public int UnitCurrentCastTimeRemaining(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].CurrentCastTimeRemaining;
			}
			return 0;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x000308D8 File Offset: 0x0002EAD8
		public int UnitCurrentCastPercent(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].CurrentCastPercent;
			}
			return 0;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0003090C File Offset: 0x0002EB0C
		public bool UnitCurrentCastInterruptible(string unit)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.UnitExists(unit))
					{
						goto IL_2B;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return false;
			IL_2B:
			return this._UnitInfo[unit].CurrentCastInterruptible;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00030988 File Offset: 0x0002EB88
		public bool UnitCurrentCastIsChannelling(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].CurrentCastIsChannelling;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000309BC File Offset: 0x0002EBBC
		public int UnitRange(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].UnitRange;
			}
			return 99999;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x000309F4 File Offset: 0x0002EBF4
		public int UnitLevel(string unit)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.UnitExists(unit))
					{
						goto IL_2B;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return 0;
			IL_2B:
			return this._UnitInfo[unit].Level;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00030A70 File Offset: 0x0002EC70
		public int UnitHealth(string unit)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.UnitExists(unit))
					{
						goto IL_51;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return 0;
			IL_51:
			return this._UnitInfo[unit].CurrentHP;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00030AEC File Offset: 0x0002ECEC
		public int UnitHealthMax(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].MaxHP;
			}
			return 0;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00030B1C File Offset: 0x0002ED1C
		public int UnitHealthPercent(string unit)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return 0;
				case 1:
					if (this.UnitExists(unit))
					{
						goto IL_5B;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			return 0;
			IL_5B:
			return this._UnitInfo[unit].HPPercent;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00030B98 File Offset: 0x0002ED98
		public int UnitPower(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].CurrentPower;
			}
			return 0;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00030BC8 File Offset: 0x0002EDC8
		public int UnitPowerMax(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].MaxPower;
			}
			return 0;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00030BF8 File Offset: 0x0002EDF8
		public int UnitPowerPercent(string unit)
		{
			if (!this.UnitExists(unit))
			{
				return 0;
			}
			return this._UnitInfo[unit].PowerPercent;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00030C68 File Offset: 0x0002EE68
		public int UnitPowerTypeIndex(string unit)
		{
			if (!this.UnitExists(unit))
			{
				return -1;
			}
			return this._UnitInfo[unit].PowerTypeIndex;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00030CD8 File Offset: 0x0002EED8
		public string UnitPowerTypeName(string unit)
		{
			if (!this.UnitExists(unit))
			{
				return "";
			}
			return RotationLabHelper.dhIUsZOp7AFnD3iGYXF(this._UnitInfo[unit].PowerTypeIndex);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00030D50 File Offset: 0x0002EF50
		public bool PlayerCanAttackUnit(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].PlayerCanAttack;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00030D84 File Offset: 0x0002EF84
		public bool UnitIsFriend(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].IsFriend;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		public bool UnitIsInCombat(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].IsInCombat;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00030E24 File Offset: 0x0002F024
		public bool UnitIsPVP(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].IsPVP;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00030E58 File Offset: 0x0002F058
		public bool UnitIsDead(string unit)
		{
			return !this.UnitExists(unit) || this._UnitInfo[unit].IsDead;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00030E8C File Offset: 0x0002F08C
		public bool UnitIsTargetingPlayer(string unit)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return false;
				case 1:
					if (this.UnitExists(unit))
					{
						goto IL_5B;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			return false;
			IL_5B:
			return this._UnitInfo[unit].IsTargetingPlayer;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00030F08 File Offset: 0x0002F108
		public bool UnitIsAutoAttacking(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].IsAutoAttacking;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00030F3C File Offset: 0x0002F13C
		public bool UnitIsPlayer(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].UnitIsPlayer;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00030F6C File Offset: 0x0002F16C
		public bool UnitIsTarget(string unit)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (this.UnitExists(unit))
					{
						goto IL_2B;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0a2b7fe605ba404ba745ea0e50bfd1bb == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return false;
			IL_2B:
			return this._UnitInfo[unit].UnitIsTarget;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00030FE8 File Offset: 0x0002F1E8
		public bool UnitIsMouseover(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].UnitIsMouseover;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0003101C File Offset: 0x0002F21C
		public bool UnitIsFocus(string unit)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					return false;
				case 1:
					if (this.UnitExists(unit))
					{
						goto IL_35;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			return false;
			IL_35:
			return this._UnitInfo[unit].UnitIsFocus;
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00031098 File Offset: 0x0002F298
		public bool UnitIsMainTank(string unit)
		{
			return this.UnitExists(unit) && this._UnitInfo[unit].IsMainTank;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000310C8 File Offset: 0x0002F2C8
		public int UnitRaidGroupNumber(string unit)
		{
			if (!this.UnitExists(unit))
			{
				return 0;
			}
			return this._UnitInfo[unit].RaidGroupNumber;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00031138 File Offset: 0x0002F338
		public string UnitPlayerGUID(string unit)
		{
			if (!this.UnitExists(unit))
			{
				return "";
			}
			return this._UnitInfo[unit].PlayerGUID;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000311AC File Offset: 0x0002F3AC
		public int UnitPlayerTimeToDie(string unit)
		{
			if (!this.UnitExists(unit))
			{
				return 99999;
			}
			return this._UnitInfo[unit].PlayerTimeToDie;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00031220 File Offset: 0x0002F420
		public int UnitPlayerClass(string unit)
		{
			if (this.UnitExists(unit))
			{
				return this._UnitInfo[unit].PlayerClass;
			}
			return 0;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00031254 File Offset: 0x0002F454
		public int PlayerMana
		{
			get
			{
				return this.GetPlayerPower(0);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00031264 File Offset: 0x0002F464
		public int PlayerManaMax
		{
			get
			{
				return this.GetPlayerPowerMax(0);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00031274 File Offset: 0x0002F474
		public int PlayerManaPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(0);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x00031284 File Offset: 0x0002F484
		public int PlayerRage
		{
			get
			{
				return this.GetPlayerPower(1);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00031294 File Offset: 0x0002F494
		public int PlayerRageMax
		{
			get
			{
				return this.GetPlayerPowerMax(1);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000312A4 File Offset: 0x0002F4A4
		public int PlayerRagePercent
		{
			get
			{
				return this.GetPlayerPowerPercent(1);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x000312B4 File Offset: 0x0002F4B4
		public int PlayerFocus
		{
			get
			{
				return this.GetPlayerPower(2);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x000312C4 File Offset: 0x0002F4C4
		public int PlayerFocusMax
		{
			get
			{
				return this.GetPlayerPowerMax(2);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000312D4 File Offset: 0x0002F4D4
		public int PlayerFocusPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(2);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x000312E4 File Offset: 0x0002F4E4
		public int PlayerEnergy
		{
			get
			{
				return this.GetPlayerPower(3);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x000312F4 File Offset: 0x0002F4F4
		public int PlayerEnergyMax
		{
			get
			{
				return this.GetPlayerPowerMax(3);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x00031304 File Offset: 0x0002F504
		public int PlayerEnergyPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(3);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00031314 File Offset: 0x0002F514
		public int PlayerRunicPower
		{
			get
			{
				return this.GetPlayerPower(6);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x00031324 File Offset: 0x0002F524
		public int PlayerRunicPowerMax
		{
			get
			{
				return this.GetPlayerPowerMax(6);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00031334 File Offset: 0x0002F534
		public int PlayerRunicPowerPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(6);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x00031344 File Offset: 0x0002F544
		public int PlayerSoulShards
		{
			get
			{
				return this.GetPlayerPower(7);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x00031354 File Offset: 0x0002F554
		public int PlayerSoulShardsMax
		{
			get
			{
				return this.GetPlayerPowerMax(7);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x00031364 File Offset: 0x0002F564
		public int PlayerSoulShardsPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(7);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x00031374 File Offset: 0x0002F574
		public int PlayerLunarPower
		{
			get
			{
				return this.GetPlayerPower(8);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x00031384 File Offset: 0x0002F584
		public int PlayerLunarPowerMax
		{
			get
			{
				return this.GetPlayerPowerMax(8);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00031394 File Offset: 0x0002F594
		public int PlayerLunarPowerPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(8);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x000313A4 File Offset: 0x0002F5A4
		public int PlayerHolyPower
		{
			get
			{
				return this.GetPlayerPower(9);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x000313B8 File Offset: 0x0002F5B8
		public int PlayerHolyPowerMax
		{
			get
			{
				return this.GetPlayerPowerMax(9);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x000313CC File Offset: 0x0002F5CC
		public int PlayerHolyPowerPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(9);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x000313E0 File Offset: 0x0002F5E0
		public int PlayerMaelstrom
		{
			get
			{
				return this.GetPlayerPower(11);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x000313F4 File Offset: 0x0002F5F4
		public int PlayerMaelstromMax
		{
			get
			{
				return this.GetPlayerPowerMax(11);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00031408 File Offset: 0x0002F608
		public int PlayerMaelstromPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(11);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0003141C File Offset: 0x0002F61C
		public int PlayerChi
		{
			get
			{
				return this.GetPlayerPower(12);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00031430 File Offset: 0x0002F630
		public int PlayerChiMax
		{
			get
			{
				return this.GetPlayerPowerMax(12);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00031444 File Offset: 0x0002F644
		public int PlayerChiPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(12);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00031458 File Offset: 0x0002F658
		public int PlayerInsanity
		{
			get
			{
				return this.GetPlayerPower(13);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0003146C File Offset: 0x0002F66C
		public int PlayerInsanityMax
		{
			get
			{
				return this.GetPlayerPowerMax(13);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x00031480 File Offset: 0x0002F680
		public int PlayerInsanityPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(13);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00031494 File Offset: 0x0002F694
		public int PlayerArcaneCharges
		{
			get
			{
				return this.GetPlayerPower(16);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x000314A8 File Offset: 0x0002F6A8
		public int PlayerArcaneChargesMax
		{
			get
			{
				return this.GetPlayerPowerMax(16);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x000314BC File Offset: 0x0002F6BC
		public int PlayerArcaneChargesPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(16);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x000314D0 File Offset: 0x0002F6D0
		public int PlayerFury
		{
			get
			{
				return this.GetPlayerPower(17);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000314E4 File Offset: 0x0002F6E4
		public int PlayerFuryMax
		{
			get
			{
				return this.GetPlayerPowerMax(17);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000314F8 File Offset: 0x0002F6F8
		public int PlayerFuryPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(17);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0003150C File Offset: 0x0002F70C
		public int PlayerPain
		{
			get
			{
				return this.GetPlayerPower(18);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00031520 File Offset: 0x0002F720
		public int PlayerPainMax
		{
			get
			{
				return this.GetPlayerPowerMax(18);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00031534 File Offset: 0x0002F734
		public int PlayerPainPercent
		{
			get
			{
				return this.GetPlayerPowerPercent(18);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00031548 File Offset: 0x0002F748
		public bool PlayerExists
		{
			get
			{
				return this.UnitExists(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(268206341 ^ 268224759));
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00031568 File Offset: 0x0002F768
		public bool PlayerHasBuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasBuff(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(951294359 ^ 47512224 ^ 979839685), spellId, playerCasted);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00031590 File Offset: 0x0002F790
		public int PlayerBuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-309791748 - 2077333185 ^ 1907823817), spellId, playerCasted);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000315B8 File Offset: 0x0002F7B8
		public int PlayerBuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffStacks(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(--1797548854 ^ 1797530308), spellId, playerCasted);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x000315DC File Offset: 0x0002F7DC
		public bool PlayerHasDebuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasDebuff(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1089588375 ^ -1089570149), spellId, playerCasted);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00031600 File Offset: 0x0002F800
		public int PlayerDebuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-235868112 ^ -235882046), spellId, playerCasted);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00031624 File Offset: 0x0002F824
		public int PlayerDebuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffStacks(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1224731037 ^ -1224712303), spellId, playerCasted);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00031648 File Offset: 0x0002F848
		public int PlayerNPCID
		{
			get
			{
				return this.UnitNPCID(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~1053049764 ^ -1053035095));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00031668 File Offset: 0x0002F868
		public int PlayerCurrentCastID
		{
			get
			{
				return this.UnitCurrentCastID(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~1005505369 ^ -1005486764));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00031688 File Offset: 0x0002F888
		public int PlayerCurrentCastElapsedDuration
		{
			get
			{
				return this.UnitCurrentCastElapsedDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-384868386 + 510636180 ^ 125786496));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x000316B0 File Offset: 0x0002F8B0
		public int PlayerCurrentCastTimeRemaining
		{
			get
			{
				return this.UnitCurrentCastTimeRemaining(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1388170447 ^ -1388152125));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000316D0 File Offset: 0x0002F8D0
		public int PlayerCurrentCastPercent
		{
			get
			{
				return this.UnitCurrentCastPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1714141621 >> 6 ^ 26797844));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x000316F8 File Offset: 0x0002F8F8
		public bool PlayerCurrentCastInterruptible
		{
			get
			{
				return this.UnitCurrentCastInterruptible(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1745773992 ^ -1745759318));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00031718 File Offset: 0x0002F918
		public bool PlayerCurrentCastIsChannelling
		{
			get
			{
				return this.UnitCurrentCastIsChannelling(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1746511494 ^ -1746530168));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x00031738 File Offset: 0x0002F938
		public int PlayerRange
		{
			get
			{
				return this.UnitRange(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1055311542 ^ 1055297348));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00031758 File Offset: 0x0002F958
		public int PlayerLevel
		{
			get
			{
				return this.UnitLevel(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-553744847 ^ -553726013));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00031778 File Offset: 0x0002F978
		public int PlayerHealth
		{
			get
			{
				return this.UnitHealth(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-564572999 ^ -564591285));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00031798 File Offset: 0x0002F998
		public int PlayerHealthMax
		{
			get
			{
				return this.UnitHealthMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1767032709 ^ 1767018103));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000317B8 File Offset: 0x0002F9B8
		public int PlayerHealthPercent
		{
			get
			{
				return this.UnitHealthPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~2095831454 ^ -2095812717));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x000317D8 File Offset: 0x0002F9D8
		public int PlayerPower
		{
			get
			{
				return this.UnitPower(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(145144672 << 4 ^ -1972633614));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00031800 File Offset: 0x0002FA00
		public int PlayerPowerMax
		{
			get
			{
				return this.UnitPowerMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1905767247 ^ 1905785533));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00031820 File Offset: 0x0002FA20
		public int PlayerPowerPercent
		{
			get
			{
				return this.UnitPowerPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1386050510 + 11679858 ^ 1397745074));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00031848 File Offset: 0x0002FA48
		public string PlayerPowerTypeName
		{
			get
			{
				return this.UnitPowerTypeName(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1157945476 >> 1 ^ 578954672));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00031870 File Offset: 0x0002FA70
		public int PlayerPowerTypeIndex
		{
			get
			{
				return this.UnitPowerTypeIndex(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~344187374 ^ -344172573));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00031890 File Offset: 0x0002FA90
		public bool PlayerCanAttackPlayer
		{
			get
			{
				return this.PlayerCanAttackUnit(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(171996523 ^ 171981977));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x000318B0 File Offset: 0x0002FAB0
		public bool PlayerIsFriend
		{
			get
			{
				return this.UnitIsFriend(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-2018852357 ^ -2018867191));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000318D0 File Offset: 0x0002FAD0
		public bool PlayerIsInCombat
		{
			get
			{
				return this.UnitIsInCombat(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1640708702 ^ -1640723376));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000318F0 File Offset: 0x0002FAF0
		public bool PlayerIsPVP
		{
			get
			{
				return this.UnitIsPVP(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1668754258 ^ -1668768420));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x00031910 File Offset: 0x0002FB10
		public bool PlayerIsDead
		{
			get
			{
				return this.UnitIsDead(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(--2124070285 ^ 2124084351));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00031930 File Offset: 0x0002FB30
		public bool PlayerIsTargetingPlayer
		{
			get
			{
				return this.UnitIsTargetingPlayer(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1897624240 ^ -1897610078));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00031950 File Offset: 0x0002FB50
		public bool PlayerIsAutoAttacking
		{
			get
			{
				return this.UnitIsAutoAttacking(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-717857995 >> 5 ^ -22414549));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00031978 File Offset: 0x0002FB78
		public bool PlayerIsPlayer
		{
			get
			{
				return this.UnitIsPlayer(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-553744847 ^ -553726013));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00031998 File Offset: 0x0002FB98
		public bool PlayerIsTarget
		{
			get
			{
				return this.UnitIsTarget(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(259176490 ^ 259191256));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x000319B8 File Offset: 0x0002FBB8
		public int PlayerPlayerTimeToDie
		{
			get
			{
				return this.UnitPlayerTimeToDie(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(145144672 << 4 ^ -1972633614));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x000319E0 File Offset: 0x0002FBE0
		public bool TargetExists
		{
			get
			{
				return this.UnitExists(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~603785892 ^ -603799719));
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00031A00 File Offset: 0x0002FC00
		public bool TargetHasBuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasBuff(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1157945476 >> 1 ^ 578954816), spellId, playerCasted);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00031A28 File Offset: 0x0002FC28
		public int TargetBuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffDuration(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(171996523 ^ 171982697), spellId, playerCasted);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00031A4C File Offset: 0x0002FC4C
		public int TargetBuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffStacks(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352740968 ^ -1352759910), spellId, playerCasted);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x00031A70 File Offset: 0x0002FC70
		public bool TargetHasDebuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasDebuff(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1551733089 >> 2 ^ 387919450), spellId, playerCasted);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00031A98 File Offset: 0x0002FC98
		public int TargetDebuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1750427148 ^ -1750412298), spellId, playerCasted);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00031ABC File Offset: 0x0002FCBC
		public int TargetDebuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffStacks(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1638637009 >> 6 ^ 25617525), spellId, playerCasted);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00031AE4 File Offset: 0x0002FCE4
		public int TargetNPCID
		{
			get
			{
				return this.UnitNPCID(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1992869118 ^ -1992855296));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00031B04 File Offset: 0x0002FD04
		public int TargetCurrentCastID
		{
			get
			{
				return this.UnitCurrentCastID(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~463906284 ^ -463925231));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x00031B24 File Offset: 0x0002FD24
		public int TargetCurrentCastElapsedDuration
		{
			get
			{
				return this.UnitCurrentCastElapsedDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1696412362 - -137042106 ^ -1559384078));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00031B4C File Offset: 0x0002FD4C
		public int TargetCurrentCastTimeRemaining
		{
			get
			{
				return this.UnitCurrentCastTimeRemaining(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(881693030 + 414722879 ^ 1296430759));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000654 RID: 1620 RVA: 0x00031B74 File Offset: 0x0002FD74
		public int TargetCurrentCastPercent
		{
			get
			{
				return this.UnitCurrentCastPercent(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-283366293 ^ -283351447));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00031B94 File Offset: 0x0002FD94
		public bool TargetCurrentCastInterruptible
		{
			get
			{
				return this.UnitCurrentCastInterruptible(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1691472209 >> 1 ^ 845718186));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000656 RID: 1622 RVA: 0x00031BBC File Offset: 0x0002FDBC
		public bool TargetCurrentCastIsChannelling
		{
			get
			{
				return this.UnitCurrentCastIsChannelling(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352111144 ^ -1352130086));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00031BDC File Offset: 0x0002FDDC
		public int TargetRange
		{
			get
			{
				return this.UnitRange(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-260489887 - 366953631 ^ -627461440));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000658 RID: 1624 RVA: 0x00031C04 File Offset: 0x0002FE04
		public int TargetLevel
		{
			get
			{
				return this.UnitLevel(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1860104403 ^ -1860090577));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00031C24 File Offset: 0x0002FE24
		public int TargetHealth
		{
			get
			{
				return this.UnitHealth(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-860087180 << 5 ^ -1752972158));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600065A RID: 1626 RVA: 0x00031C4C File Offset: 0x0002FE4C
		public int TargetHealthMax
		{
			get
			{
				return this.UnitHealthMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1714141621 >> 6 ^ 26797284));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00031C74 File Offset: 0x0002FE74
		public int TargetHealthPercent
		{
			get
			{
				return this.UnitHealthPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-260489887 - 366953631 ^ -627461440));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x00031C9C File Offset: 0x0002FE9C
		public int TargetPower
		{
			get
			{
				return this.UnitPower(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1157945476 >> 1 ^ 578954816));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00031CC4 File Offset: 0x0002FEC4
		public int TargetPowerMax
		{
			get
			{
				return this.UnitPowerMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1690522925 ^ -1690509103));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x00031CE4 File Offset: 0x0002FEE4
		public int TargetPowerPercent
		{
			get
			{
				return this.UnitPowerPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1308721404 ^ 1308740350));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00031D04 File Offset: 0x0002FF04
		public string TargetPowerTypeName
		{
			get
			{
				return this.UnitPowerTypeName(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(764415235 ^ 764430081));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00031D24 File Offset: 0x0002FF24
		public int TargetPowerTypeIndex
		{
			get
			{
				return this.UnitPowerTypeIndex(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789419076 ^ -35552607 ^ 756261663));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00031D4C File Offset: 0x0002FF4C
		public bool PlayerCanAttackTarget
		{
			get
			{
				return this.PlayerCanAttackUnit(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1388170447 ^ -1388152525));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00031D6C File Offset: 0x0002FF6C
		public bool TargetIsFriend
		{
			get
			{
				return this.UnitIsFriend(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1621542659 + 1028479281 ^ -1644926410));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00031D94 File Offset: 0x0002FF94
		public bool TargetIsInCombat
		{
			get
			{
				return this.UnitIsInCombat(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1633072087 ^ 1633090005));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00031DB4 File Offset: 0x0002FFB4
		public bool TargetIsPVP
		{
			get
			{
				return this.UnitIsPVP(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1551733089 >> 2 ^ 387919450));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00031DDC File Offset: 0x0002FFDC
		public bool TargetIsDead
		{
			get
			{
				return this.UnitIsDead(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~2095831454 ^ -2095813533));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00031DFC File Offset: 0x0002FFFC
		public bool TargetIsTargetingPlayer
		{
			get
			{
				return this.UnitIsTargetingPlayer(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~344187374 ^ -344173549));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00031E1C File Offset: 0x0003001C
		public bool TargetIsAutoAttacking
		{
			get
			{
				return this.UnitIsAutoAttacking(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1734223699 - -1503209248 ^ -231033393));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00031E44 File Offset: 0x00030044
		public bool TargetIsPlayer
		{
			get
			{
				return this.UnitIsPlayer(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1551733089 >> 2 ^ 387919450));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00031E6C File Offset: 0x0003006C
		public bool TargetIsTarget
		{
			get
			{
				return this.UnitIsTarget(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1654110737 ^ -473083753 ^ -2124767100));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00031E94 File Offset: 0x00030094
		public int TargetPlayerTimeToDie
		{
			get
			{
				return this.UnitPlayerTimeToDie(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-825446221 ^ -825427279));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00031EB4 File Offset: 0x000300B4
		public bool MouseoverExists
		{
			get
			{
				return this.UnitExists(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-2018852357 ^ -2018866199));
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00031ED4 File Offset: 0x000300D4
		public bool MouseoverHasBuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasBuff(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(289037427 >> 1 ^ 144532523), spellId, playerCasted);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00031EFC File Offset: 0x000300FC
		public int MouseoverBuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffDuration(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1308721404 ^ 1308740334), spellId, playerCasted);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00031F20 File Offset: 0x00030120
		public int MouseoverBuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffStacks(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(152750669 ^ 152731743), spellId, playerCasted);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00031F44 File Offset: 0x00030144
		public bool MouseoverHasDebuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasDebuff(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1003780849 ^ -1003761891), spellId, playerCasted);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00031F68 File Offset: 0x00030168
		public int MouseoverDebuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffDuration(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1183576799 ^ -1183561933), spellId, playerCasted);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00031F8C File Offset: 0x0003018C
		public int MouseoverDebuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffStacks(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-717857995 >> 5 ^ -22415157), spellId, playerCasted);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00031FB4 File Offset: 0x000301B4
		public int MouseoverNPCID
		{
			get
			{
				return this.UnitNPCID(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~1005505369 ^ -1005486412));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00031FD4 File Offset: 0x000301D4
		public int MouseoverCurrentCastID
		{
			get
			{
				return this.UnitCurrentCastID(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~344187374 ^ -344173565));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00031FF4 File Offset: 0x000301F4
		public int MouseoverCurrentCastElapsedDuration
		{
			get
			{
				return this.UnitCurrentCastElapsedDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(2066732216 ^ 2066718378));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00032014 File Offset: 0x00030214
		public int MouseoverCurrentCastTimeRemaining
		{
			get
			{
				return this.UnitCurrentCastTimeRemaining(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789531856));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00032034 File Offset: 0x00030234
		public int MouseoverCurrentCastPercent
		{
			get
			{
				return this.UnitCurrentCastPercent(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(510582717 ^ 510563759));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00032054 File Offset: 0x00030254
		public bool MouseoverCurrentCastInterruptible
		{
			get
			{
				return this.UnitCurrentCastInterruptible(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(--1722095099 ^ 1722114025));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00032074 File Offset: 0x00030274
		public bool MouseoverCurrentCastIsChannelling
		{
			get
			{
				return this.UnitCurrentCastIsChannelling(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1183576799 ^ -1183561933));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00032094 File Offset: 0x00030294
		public int MouseoverRange
		{
			get
			{
				return this.UnitRange(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-185008287 ^ -185027213));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x000320B4 File Offset: 0x000302B4
		public int MouseoverLevel
		{
			get
			{
				return this.UnitLevel(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-789419076 ^ -35552607 ^ 756261647));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000320DC File Offset: 0x000302DC
		public int MouseoverHealth
		{
			get
			{
				return this.UnitHealth(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1551733089 >> 2 ^ 387919434));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00032104 File Offset: 0x00030304
		public int MouseoverHealthMax
		{
			get
			{
				return this.UnitHealthMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1050340572 ^ -1050322634));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00032124 File Offset: 0x00030324
		public int MouseoverHealthPercent
		{
			get
			{
				return this.UnitHealthPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~744818537 ^ -744836476));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x00032144 File Offset: 0x00030344
		public int MouseoverPower
		{
			get
			{
				return this.UnitPower(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1183576799 ^ -1183561933));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00032164 File Offset: 0x00030364
		public int MouseoverPowerMax
		{
			get
			{
				return this.UnitPowerMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~-1482987862 ^ 1483002695));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000680 RID: 1664 RVA: 0x00032184 File Offset: 0x00030384
		public int MouseoverPowerPercent
		{
			get
			{
				return this.UnitPowerPercent(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(950853533 >> 3 ^ 118870497));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000321AC File Offset: 0x000303AC
		public string MouseoverPowerTypeName
		{
			get
			{
				return this.UnitPowerTypeName(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1815843576 ^ -1815861478));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x000321CC File Offset: 0x000303CC
		public int MouseoverPowerTypeIndex
		{
			get
			{
				return this.UnitPowerTypeIndex(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(679327912 ^ 679342778));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x000321EC File Offset: 0x000303EC
		public bool PlayerCanAttackMouseover
		{
			get
			{
				return this.PlayerCanAttackUnit(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-764151834 ^ -764166668));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x0003220C File Offset: 0x0003040C
		public bool MouseoverIsFriend
		{
			get
			{
				return this.UnitIsFriend(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1858354135 - 1114350030 ^ 744017947));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00032234 File Offset: 0x00030434
		public bool MouseoverIsInCombat
		{
			get
			{
				return this.UnitIsInCombat(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1183576799 ^ -1183561933));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00032254 File Offset: 0x00030454
		public bool MouseoverIsPVP
		{
			get
			{
				return this.UnitIsPVP(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1055311542 ^ 1055296676));
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00032274 File Offset: 0x00030474
		public bool MouseoverIsDead
		{
			get
			{
				return this.UnitIsDead(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-693910567 ^ -693925429));
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x00032294 File Offset: 0x00030494
		public bool MouseoverIsTargetingPlayer
		{
			get
			{
				return this.UnitIsTargetingPlayer(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1872685799 ^ -1872666869));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x000322B4 File Offset: 0x000304B4
		public bool MouseoverIsAutoAttacking
		{
			get
			{
				return this.UnitIsAutoAttacking(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-582433477 + 1816872807 ^ 1234454192));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000322DC File Offset: 0x000304DC
		public bool MouseoverIsPlayer
		{
			get
			{
				return this.UnitIsPlayer(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1691472209 >> 1 ^ 845718202));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00032304 File Offset: 0x00030504
		public bool MouseoverIsTarget
		{
			get
			{
				return this.UnitIsTarget(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1765342390 ^ 1765324452));
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00032324 File Offset: 0x00030524
		public int MouseoverPlayerTimeToDie
		{
			get
			{
				return this.UnitPlayerTimeToDie(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-309791748 - 2077333185 ^ 1907824425));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x0003234C File Offset: 0x0003054C
		public bool FocusExists
		{
			get
			{
				return this.UnitExists(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1819523060 ^ 1064311800 ^ 1392764452));
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00032374 File Offset: 0x00030574
		public bool FocusHasBuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasBuff(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(2040894867 + -686633457 ^ 1354246538), spellId, playerCasted);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0003239C File Offset: 0x0003059C
		public int FocusBuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1505789866 ^ -1505807746), spellId, playerCasted);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x000323C0 File Offset: 0x000305C0
		public int FocusBuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffStacks(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1897624240 ^ -1897609352), spellId, playerCasted);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000323E4 File Offset: 0x000305E4
		public bool FocusHasDebuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasDebuff(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1750427148 ^ -1750412324), spellId, playerCasted);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00032408 File Offset: 0x00030608
		public int FocusDebuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1767032709 ^ 1767017901), spellId, playerCasted);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0003242C File Offset: 0x0003062C
		public int FocusDebuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffStacks(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-33448599 >> 2 ^ -8376974), spellId, playerCasted);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00032454 File Offset: 0x00030654
		public int FocusNPCID
		{
			get
			{
				return this.UnitNPCID(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1745773992 ^ -1745760144));
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00032474 File Offset: 0x00030674
		public int FocusCurrentCastID
		{
			get
			{
				return this.UnitCurrentCastID(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(510582717 ^ 510563733));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x00032494 File Offset: 0x00030694
		public int FocusCurrentCastElapsedDuration
		{
			get
			{
				return this.UnitCurrentCastElapsedDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-2102188928 ^ -2102169944));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x000324B4 File Offset: 0x000306B4
		public int FocusCurrentCastTimeRemaining
		{
			get
			{
				return this.UnitCurrentCastTimeRemaining(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1008853611 >> 6 ^ -15781282));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x000324DC File Offset: 0x000306DC
		public int FocusCurrentCastPercent
		{
			get
			{
				return this.UnitCurrentCastPercent(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-831735385 ^ -831720561));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x000324FC File Offset: 0x000306FC
		public bool FocusCurrentCastInterruptible
		{
			get
			{
				return this.UnitCurrentCastInterruptible(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-256932895 ^ -256914999));
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0003251C File Offset: 0x0003071C
		public bool FocusCurrentCastIsChannelling
		{
			get
			{
				return this.UnitCurrentCastIsChannelling(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1008853611 >> 6 ^ -15781282));
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00032544 File Offset: 0x00030744
		public int FocusRange
		{
			get
			{
				return this.UnitRange(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1897624240 ^ -1897609352));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00032564 File Offset: 0x00030764
		public int FocusLevel
		{
			get
			{
				return this.UnitLevel(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1638637009 >> 6 ^ 25617503));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x0003258C File Offset: 0x0003078C
		public int FocusHealth
		{
			get
			{
				return this.UnitHealth(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-2102188928 ^ -2102169944));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x000325AC File Offset: 0x000307AC
		public int FocusHealthMax
		{
			get
			{
				return this.UnitHealthMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1745773992 ^ -1745760144));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000325CC File Offset: 0x000307CC
		public int FocusHealthPercent
		{
			get
			{
				return this.UnitHealthPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1905767247 ^ 1905785191));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x000325EC File Offset: 0x000307EC
		public int FocusPower
		{
			get
			{
				return this.UnitPower(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1224731037 ^ -1224713141));
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0003260C File Offset: 0x0003080C
		public int FocusPowerMax
		{
			get
			{
				return this.UnitPowerMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~463906284 ^ -463925189));
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0003262C File Offset: 0x0003082C
		public int FocusPowerPercent
		{
			get
			{
				return this.UnitPowerPercent(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1690522925 ^ -1690509061));
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0003264C File Offset: 0x0003084C
		public string FocusPowerTypeName
		{
			get
			{
				return this.UnitPowerTypeName(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1819523060 ^ 1064311800 ^ 1392764452));
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00032674 File Offset: 0x00030874
		public int FocusPowerTypeIndex
		{
			get
			{
				return this.UnitPowerTypeIndex(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886923254));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00032694 File Offset: 0x00030894
		public bool PlayerCanAttackFocus
		{
			get
			{
				return this.PlayerCanAttackUnit(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1933679734 ^ -1218001364 ^ -1004072846));
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x000326BC File Offset: 0x000308BC
		public bool FocusIsFriend
		{
			get
			{
				return this.UnitIsFriend(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-258475567 << 4 ^ 159373112));
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x000326E4 File Offset: 0x000308E4
		public bool FocusIsInCombat
		{
			get
			{
				return this.UnitIsInCombat(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-160910942 << 4 ^ 1720406024));
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0003270C File Offset: 0x0003090C
		public bool FocusIsPVP
		{
			get
			{
				return this.UnitIsPVP(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1073891089 ^ 1073876281));
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0003272C File Offset: 0x0003092C
		public bool FocusIsDead
		{
			get
			{
				return this.UnitIsDead(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(212924216 ^ 212909328));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0003274C File Offset: 0x0003094C
		public bool FocusIsTargetingPlayer
		{
			get
			{
				return this.UnitIsTargetingPlayer(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(2066732216 ^ 2066718352));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0003276C File Offset: 0x0003096C
		public bool FocusIsAutoAttacking
		{
			get
			{
				return this.UnitIsAutoAttacking(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(--1797548854 ^ 1797529886));
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0003278C File Offset: 0x0003098C
		public bool FocusIsPlayer
		{
			get
			{
				return this.UnitIsPlayer(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1007749927 ^ -1007763727));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x000327AC File Offset: 0x000309AC
		public bool FocusIsTarget
		{
			get
			{
				return this.UnitIsTarget(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1050340572 ^ -1050322676));
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x000327CC File Offset: 0x000309CC
		public int FocusPlayerTimeToDie
		{
			get
			{
				return this.UnitPlayerTimeToDie(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1308721404 ^ 1308740308));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x000327EC File Offset: 0x000309EC
		public bool PetExists
		{
			get
			{
				return this.UnitExists(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-256932895 ^ -256914985));
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0003280C File Offset: 0x00030A0C
		public bool PetHasBuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasBuff(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1551733089 >> 2 ^ 387919470), spellId, playerCasted);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00032834 File Offset: 0x00030A34
		public int PetBuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-161182833 ^ -161168967), spellId, playerCasted);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00032858 File Offset: 0x00030A58
		public int PetBuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitBuffStacks(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-185008287 ^ -185027241), spellId, playerCasted);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0003287C File Offset: 0x00030A7C
		public bool PetHasDebuff(int spellId, bool playerCasted = false)
		{
			return this.UnitHasDebuff(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(359120413 ^ 359134251), spellId, playerCasted);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x000328A0 File Offset: 0x00030AA0
		public int PetDebuffDuration(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffDuration(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1199763274 ^ -1199744384), spellId, playerCasted);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x000328C4 File Offset: 0x00030AC4
		public int PetDebuffStacks(int spellId, bool playerCasted = false)
		{
			return this.UnitDebuffStacks(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1551733089 >> 2 ^ 387919470), spellId, playerCasted);
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x000328EC File Offset: 0x00030AEC
		public int PetNPCID
		{
			get
			{
				return this.UnitNPCID(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(790722942 ^ 790704968));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0003290C File Offset: 0x00030B0C
		public int PetCurrentCastID
		{
			get
			{
				return this.UnitCurrentCastID(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(996650866 + -609199087 ^ 387465653));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x00032934 File Offset: 0x00030B34
		public int PetCurrentCastElapsedDuration
		{
			get
			{
				return this.UnitCurrentCastElapsedDuration(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(212924216 ^ 212909326));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00032954 File Offset: 0x00030B54
		public int PetCurrentCastTimeRemaining
		{
			get
			{
				return this.UnitCurrentCastTimeRemaining(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(145144672 << 4 ^ -1972634570));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0003297C File Offset: 0x00030B7C
		public int PetCurrentCastPercent
		{
			get
			{
				return this.UnitCurrentCastPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-693910567 ^ -693925393));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0003299C File Offset: 0x00030B9C
		public bool PetCurrentCastInterruptible
		{
			get
			{
				return this.UnitCurrentCastInterruptible(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1638637009 >> 6 ^ 25617473));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x000329C4 File Offset: 0x00030BC4
		public bool PetCurrentCastIsChannelling
		{
			get
			{
				return this.UnitCurrentCastIsChannelling(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-552555469 << 5 ^ -501887914));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x000329EC File Offset: 0x00030BEC
		public int PetRange
		{
			get
			{
				return this.UnitRange(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(950853533 >> 3 ^ 118870469));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00032A14 File Offset: 0x00030C14
		public int PetLevel
		{
			get
			{
				return this.UnitLevel(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-613886095 << 1 ^ -1227758380));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00032A3C File Offset: 0x00030C3C
		public int PetHealth
		{
			get
			{
				return this.UnitHealth(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1218526815 ^ -1218540649));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00032A5C File Offset: 0x00030C5C
		public int PetHealthMax
		{
			get
			{
				return this.UnitHealthMax(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1638637009 >> 6 ^ 25617473));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00032A84 File Offset: 0x00030C84
		public int PetHealthPercent
		{
			get
			{
				return this.UnitHealthPercent(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1307524010 ^ -1307537824));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00032AA4 File Offset: 0x00030CA4
		public int PetPower
		{
			get
			{
				return this.UnitPower(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1386050510 + 11679858 ^ 1397745270));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00032ACC File Offset: 0x00030CCC
		public int PetPowerMax
		{
			get
			{
				return this.UnitPowerMax(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(451337338 ^ 451319372));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00032AEC File Offset: 0x00030CEC
		public int PetPowerPercent
		{
			get
			{
				return this.UnitPowerPercent(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-235868112 ^ -235881978));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00032B0C File Offset: 0x00030D0C
		public string PetPowerTypeName
		{
			get
			{
				return this.UnitPowerTypeName(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(152750669 ^ 152731771));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00032B2C File Offset: 0x00030D2C
		public int PetPowerTypeIndex
		{
			get
			{
				return this.UnitPowerTypeIndex(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(185404423 + 1853889833 ^ 2039309062));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00032B54 File Offset: 0x00030D54
		public bool PlayerCanAttackPet
		{
			get
			{
				return this.PlayerCanAttackUnit(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-235868112 ^ -235881978));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00032B74 File Offset: 0x00030D74
		public bool PetIsFriend
		{
			get
			{
				return this.UnitIsFriend(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1657226489 - -588572257 ^ -2049154708));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00032B9C File Offset: 0x00030D9C
		public bool PetIsInCombat
		{
			get
			{
				return this.UnitIsInCombat(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(2040894867 + -686633457 ^ 1354246548));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00032BC4 File Offset: 0x00030DC4
		public bool PetIsPVP
		{
			get
			{
				return this.UnitIsPVP(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(359120413 ^ 359134251));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00032BE4 File Offset: 0x00030DE4
		public bool PetIsDead
		{
			get
			{
				int num = 1;
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 1:
						if (!this.UnitIsDead(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(212924216 ^ 212909326)))
						{
							goto IL_2B;
						}
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					}
					break;
				}
				return true;
				IL_2B:
				return this.UnitHealth(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(171996523 ^ 171982685)) <= 1;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00032C7C File Offset: 0x00030E7C
		public bool PetIsTargetingPet
		{
			get
			{
				return this.UnitIsTargetingPlayer(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(881693030 + 414722879 ^ 1296430739));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00032CA4 File Offset: 0x00030EA4
		public bool PetIsAutoAttacking
		{
			get
			{
				return this.UnitIsAutoAttacking(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1992869118 ^ -1992855244));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00032CC4 File Offset: 0x00030EC4
		public bool PetIsPlayer
		{
			get
			{
				return this.UnitIsPlayer(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(587114080 ^ 587131990));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00032CE4 File Offset: 0x00030EE4
		public bool PetIsTarget
		{
			get
			{
				return this.UnitIsTarget(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1746511494 ^ -1746529460));
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00032D04 File Offset: 0x00030F04
		public bool SpellIsDisabled(int spellId)
		{
			return this._SpellIgnoreList.Contains(spellId);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00032D1C File Offset: 0x00030F1C
		public bool ItemIsDisabled(int spellId)
		{
			return this._ItemIgnoreList.Contains(spellId);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00032D34 File Offset: 0x00030F34
		public bool MacroIsDisabled(string macroName)
		{
			return this._MacroIgnoreList.Contains(macroName);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00032D4C File Offset: 0x00030F4C
		public bool ModifierKeyIsDisabled(string modifierName)
		{
			return this._ModifierIgnoreList.Contains(modifierName);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00032D64 File Offset: 0x00030F64
		public void _SetSpellIsDisabled(int spellId, bool disabled)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12B;
				case 1:
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_73;
				case 3:
					if (!this.SpellIsDisabled(CS$<>8__locals1.spellId))
					{
						this._SpellIgnoreList.Add(CS$<>8__locals1.spellId);
						num2 = 6;
						continue;
					}
					break;
				case 4:
					IL_57:
					if (this.SpellIsDisabled(CS$<>8__locals1.spellId))
					{
						num2 = 7;
						continue;
					}
					return;
				case 5:
					if (disabled)
					{
						num2 = 3;
						continue;
					}
					break;
				case 6:
					return;
				case 7:
					this._SpellIgnoreList.RemoveAll(new Predicate<int>(CS$<>8__locals1.qyWcbmggOa));
					num2 = 8;
					continue;
				case 8:
					return;
				default:
					goto IL_12B;
				}
				if (!disabled)
				{
					goto IL_57;
				}
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_484d9dff0be247d0909491a365bde396 == 0)
				{
					num2 = 2;
					continue;
				}
				continue;
				IL_12B:
				CS$<>8__locals1.spellId = spellId2;
				num2 = 5;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
				{
					num2 = 5;
				}
			}
			IL_73:;
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00032EC0 File Offset: 0x000310C0
		public void _SetItemIsDisabled(int itemId, bool disabled)
		{
			RotationLabHelper.<>c__DisplayClass641_0 CS$<>8__locals1 = new RotationLabHelper.<>c__DisplayClass641_0();
			CS$<>8__locals1.itemId = itemId;
			int num = 7;
			for (;;)
			{
				switch (num)
				{
				case 1:
					goto IL_B7;
				case 2:
					return;
				case 3:
					return;
				case 4:
					this._ItemIgnoreList.Add(CS$<>8__locals1.itemId);
					num = 2;
					continue;
				case 5:
					IL_3A:
					if (!this.ItemIsDisabled(CS$<>8__locals1.itemId))
					{
						int num2 = 6;
						num = num2;
						continue;
					}
					this._ItemIgnoreList.RemoveAll(new Predicate<int>(CS$<>8__locals1.WkaczQT3YR));
					num = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0d042870c9044e3385234a5737b1d0da == 0)
					{
						num = 3;
						continue;
					}
					continue;
				case 6:
					goto IL_5A;
				case 7:
					if (!disabled)
					{
						goto IL_E3;
					}
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 == 0)
					{
						num = 0;
						continue;
					}
					continue;
				}
				if (!this.ItemIsDisabled(CS$<>8__locals1.itemId))
				{
					num = 4;
					continue;
				}
				IL_E3:
				if (!disabled)
				{
					goto IL_3A;
				}
				num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_30d33a1ced8343dfb34aa8f1408e62af == 0)
				{
					num = 1;
				}
			}
			IL_5A:
			IL_B7:;
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0003300C File Offset: 0x0003120C
		public void _SetMacroIsDisabled(string macroName, bool disabled)
		{
			RotationLabHelper.<>c__DisplayClass642_0 CS$<>8__locals1 = new RotationLabHelper.<>c__DisplayClass642_0();
			CS$<>8__locals1.macroName = macroName;
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					if (disabled)
					{
						num = 4;
						continue;
					}
					goto IL_111;
				case 3:
					if (this.MacroIsDisabled(CS$<>8__locals1.macroName))
					{
						int num2 = 6;
						num = num2;
						continue;
					}
					return;
				case 4:
					if (this.MacroIsDisabled(CS$<>8__locals1.macroName))
					{
						goto IL_111;
					}
					num = 5;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_28ebedbdab9e4e3895d75e5b9bfb0d5f != 0)
					{
						num = 3;
						continue;
					}
					continue;
				case 5:
					this._MacroIgnoreList.Add(CS$<>8__locals1.macroName);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1895b09984304f78868023ed6e046da0 != 0)
					{
						num = 0;
						continue;
					}
					continue;
				case 6:
					this._MacroIgnoreList.RemoveAll(new Predicate<string>(CS$<>8__locals1.Rw45WEMIB9));
					num = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
					{
						num = 1;
						continue;
					}
					continue;
				}
				break;
				IL_111:
				if (disabled)
				{
					return;
				}
				num = 3;
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0003313C File Offset: 0x0003133C
		public void _SetModifierKeyIsDisabled(string modifierName, bool disabled)
		{
			int num = 2;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_4B;
					case 1:
						CS$<>8__locals1.modifierName = modifierName2;
						if (!disabled)
						{
							num2 = 6;
							continue;
						}
						goto IL_DD;
					case 2:
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0883e7397db64368b06c9c6e6d729e08 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					case 3:
						if (!this.ModifierKeyIsDisabled(CS$<>8__locals1.modifierName))
						{
							goto Block_4;
						}
						goto IL_13F;
					case 4:
						return;
					case 5:
						goto IL_101;
					case 6:
						break;
					case 7:
						goto IL_13F;
					case 8:
						return;
					case 9:
						goto IL_DD;
					}
					IL_7C:
					if (!disabled)
					{
						num2 = 3;
						continue;
					}
					return;
					IL_DD:
					if (this.ModifierKeyIsDisabled(CS$<>8__locals1.modifierName))
					{
						goto IL_7C;
					}
					break;
					IL_13F:
					this._ModifierIgnoreList.RemoveAll(new Predicate<string>(CS$<>8__locals1.xt95PsrCgc));
					num2 = 4;
				}
				IL_4B:
				this._ModifierIgnoreList.Add(CS$<>8__locals1.modifierName);
				num = 8;
				continue;
				Block_4:
				num = 5;
			}
			return;
			IL_101:;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000332AC File Offset: 0x000314AC
		public void AddSettingsNumberField(string settingID, string displayName, string description, int defaultValue)
		{
			int num = 1;
			for (;;)
			{
				int num2 = num;
				RotationSetting value;
				for (;;)
				{
					switch (num2)
					{
					default:
						goto IL_33;
					case 1:
						value = new RotationSetting
						{
							SettingID = settingID,
							DisplayName = displayName,
							Description = description,
							DefaultValue = defaultValue,
							CurrentValue = defaultValue,
							ObjectType = 1
						};
						num2 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						goto IL_C0;
					case 3:
						return;
					}
				}
				IL_C0:
				this._RotationSettings.Add(settingID, value);
				num = 3;
				continue;
				IL_33:
				if (this._RotationSettings.ContainsKey(settingID))
				{
					break;
				}
				goto IL_C0;
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00033394 File Offset: 0x00031594
		public void AddSettingsBooleanField(string settingID, string displayName, string description, bool defaultValue)
		{
			int num = 1;
			int num2 = num;
			RotationSetting value;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					value = new RotationSetting
					{
						SettingID = settingID,
						DisplayName = displayName,
						Description = description,
						DefaultValue = defaultValue,
						CurrentValue = defaultValue,
						ObjectType = 2
					};
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_226f95e821ae480585438175bbddf9be == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_2F;
				}
				if (this._RotationSettings.ContainsKey(settingID))
				{
					return;
				}
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 != 0)
				{
					num2 = 0;
				}
			}
			IL_2F:
			this._RotationSettings.Add(settingID, value);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00033468 File Offset: 0x00031668
		public void AddSettingsStringField(string settingID, string displayName, string description, string defaultValue)
		{
			RotationSetting value = new RotationSetting
			{
				SettingID = settingID,
				DisplayName = displayName,
				Description = description,
				DefaultValue = defaultValue,
				CurrentValue = defaultValue,
				ObjectType = 3
			};
			if (!this._RotationSettings.ContainsKey(settingID))
			{
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 != 0)
				{
					num = 1;
				}
				for (;;)
				{
					switch (num)
					{
					case 1:
						this._RotationSettings.Add(settingID, value);
						num = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
						{
							num = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00033524 File Offset: 0x00031724
		public void AddSettingsListField(string settingID, string displayName, string description, string[] possibleValues, string defaultValue)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				RotationSetting value;
				switch (num2)
				{
				case 1:
					value = new RotationSetting
					{
						SettingID = settingID,
						DisplayName = displayName,
						Description = description,
						PossibleValues = possibleValues,
						DefaultValue = defaultValue,
						CurrentValue = defaultValue,
						ObjectType = 4
					};
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					return;
				}
				if (this._RotationSettings.ContainsKey(settingID))
				{
					break;
				}
				this._RotationSettings.Add(settingID, value);
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b58cc6448c07462981f7780e6183361e == 0)
				{
					num2 = 2;
				}
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000335F4 File Offset: 0x000317F4
		public int GetSettingNumber(string settingID)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				default:
					goto IL_2B;
				case 1:
					if (!this._RotationSettings.ContainsKey(settingID))
					{
						return -1;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
			IL_2B:
			if (this._RotationSettings[settingID].ObjectType == 1)
			{
				return (int)this._RotationSettings[settingID].CurrentValue;
			}
			return -1;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0003368C File Offset: 0x0003188C
		public bool GetSettingBoolean(string settingID)
		{
			if (this._RotationSettings.ContainsKey(settingID) && this._RotationSettings[settingID].ObjectType == 2)
			{
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_df90654cf93748ec8b3f08513de52694 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				return (bool)this._RotationSettings[settingID].CurrentValue;
			}
			return false;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00033718 File Offset: 0x00031918
		public string GetSettingString(string settingID)
		{
			int num = 2;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_2F;
				case 2:
					if (!this._RotationSettings.ContainsKey(settingID))
					{
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ec1c85d27ea4a539ba7e0e334676a34 != 0)
						{
							num2 = 1;
							continue;
						}
						continue;
					}
					break;
				}
				break;
			}
			goto IL_4E;
			IL_2F:
			goto IL_AC;
			IL_4E:
			if (this._RotationSettings[settingID].ObjectType == 3)
			{
				return (string)this._RotationSettings[settingID].CurrentValue;
			}
			IL_AC:
			return "";
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x000337D8 File Offset: 0x000319D8
		public string GetSettingList(string settingID)
		{
			int num = 1;
			int num2 = num;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					if (!this._RotationSettings.ContainsKey(settingID))
					{
						goto IL_89;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			if (this._RotationSettings[settingID].ObjectType == 4)
			{
				return (string)this._RotationSettings[settingID].CurrentValue;
			}
			IL_89:
			return "";
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00033874 File Offset: 0x00031A74
		public void AddMacro(string macroName, string example = "", int spellID = 0, int itemID = 0, int spellRank = 0)
		{
			int num = 3;
			int num2 = num;
			for (;;)
			{
				Macro value;
				switch (num2)
				{
				case 1:
					return;
				case 2:
					if (this._MacroList.ContainsKey(macroName))
					{
						this.WriteLog(RotationLabHelper.u16DFCO492Q2ZPFWSAg(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(326177456 ^ 326195440), macroName.ToString(), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-860087180 << 5 ^ -1752972080)));
						num2 = 4;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 != 0)
						{
							num2 = 4;
							continue;
						}
						continue;
					}
					break;
				case 3:
					value = new Macro
					{
						Name = macroName,
						Example = example,
						SpellID = spellID,
						ItemID = itemID,
						SpellRank = spellRank
					};
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ab95fbf5c0845689e9d97c1311c612e != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return;
				}
				this._MacroList.Add(macroName, value);
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e261d078e14d4a5882d9023bb7f6495a == 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000339B0 File Offset: 0x00031BB0
		public void AddModifierKey(params string[] modifierName)
		{
			int num = 7;
			int num2 = num;
			for (;;)
			{
				string key;
				int num3;
				switch (num2)
				{
				case 1:
					goto IL_75;
				case 2:
					goto IL_75;
				case 3:
					goto IL_86;
				case 4:
					if (!this._ModifierList.ContainsKey(key))
					{
						goto IL_12B;
					}
					num2 = 8;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
					{
						num2 = 10;
						continue;
					}
					continue;
				case 6:
					num3 = 0;
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e008bee02c10447c9c4063221ddff8d1 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 7:
					num2 = 6;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_4130c9db5c2b43e596cc610f57348b4a == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 8:
					goto IL_12B;
				case 9:
					goto IL_86;
				case 10:
					this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~2095831454 ^ -2095813613) + modifierName.ToString() + RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-258475567 << 4 ^ 159373120));
					num2 = 3;
					continue;
				}
				IL_4F:
				if (num3 >= modifierName.Length)
				{
					break;
				}
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a8b0fe86ca414d59a00505e4688a2028 == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_75:
				key = modifierName[num3];
				num2 = 4;
				continue;
				IL_86:
				num3++;
				num2 = 5;
				continue;
				IL_12B:
				this._ModifierList.Add(key, false);
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 != 0)
				{
					num2 = 9;
					continue;
				}
				continue;
				goto IL_4F;
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00033B64 File Offset: 0x00031D64
		public void AddItem(params int[] itemID)
		{
			int num = 0;
			int num2 = 2;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_acfa09b970e04d3e89283a58545b6d36 == 0)
			{
				num2 = 2;
			}
			for (;;)
			{
				int item;
				switch (num2)
				{
				case 0:
					goto IL_127;
				case 1:
					this.WriteLog(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1897624240 ^ -1897609256) + item.ToString() + RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-289990612 ^ 1144181582 ^ -1434091214));
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 2:
					goto IL_151;
				case 3:
					return;
				case 4:
					goto IL_127;
				case 5:
					break;
				case 6:
					goto IL_151;
				case 7:
					goto IL_BE;
				case 8:
					if (!this._ItemList.Contains(item))
					{
						goto IL_BE;
					}
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c9958ff501e7430a9a68ee9837d30eaa != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				default:
					goto IL_127;
				}
				IL_79:
				item = itemID[num];
				num2 = 8;
				continue;
				IL_151:
				if (num < itemID.Length)
				{
					goto IL_79;
				}
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_37d2e63e4691457582d3a8717f754394 != 0)
				{
					num2 = 3;
					continue;
				}
				continue;
				IL_BE:
				this._ItemList.Add(item);
				num2 = 4;
				continue;
				IL_127:
				num++;
				num2 = 6;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a4220304efac479885fc7bed52e95949 == 0)
				{
					num2 = 3;
				}
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00033CE8 File Offset: 0x00031EE8
		public void AddSpell(params int[] spellId)
		{
			int num = 0;
			int num2 = 1;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f67918d8ca3e4dfd9e21621dec4357d8 == 0)
			{
				num2 = 1;
			}
			for (;;)
			{
				int item;
				switch (num2)
				{
				case 0:
					goto IL_118;
				case 1:
					goto IL_C7;
				case 2:
					if (this._SpellList.Contains(item))
					{
						num2 = 3;
						continue;
					}
					goto IL_97;
				case 3:
					goto IL_118;
				case 4:
					goto IL_97;
				case 5:
					break;
				case 6:
					break;
				case 7:
					return;
				case 8:
					goto IL_C7;
				default:
					goto IL_118;
				}
				num++;
				int num3 = 8;
				num2 = num3;
				continue;
				IL_97:
				this._SpellList.Add(item);
				num2 = 5;
				continue;
				IL_C7:
				if (num >= spellId.Length)
				{
					num2 = 7;
					continue;
				}
				item = spellId[num];
				num2 = 2;
				continue;
				IL_118:
				this.WriteLog(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1668754258 ^ -1668768206) + item.ToString() + RotationLabHelper.JHj9LgOi1oyoBrjIhFT(2090212177 ^ 2090225921));
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 != 0)
				{
					num2 = 6;
				}
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00033E5C File Offset: 0x0003205C
		public void AddBuff(params int[] spellId)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				int num3;
				int item;
				switch (num2)
				{
				case 0:
					goto IL_E8;
				case 1:
					return;
				case 2:
					break;
				case 3:
					goto IL_7F;
				case 4:
					num3 = 0;
					break;
				case 5:
					num2 = 4;
					continue;
				case 6:
					goto IL_163;
				case 7:
					goto IL_E8;
				case 8:
					if (!this._BuffList.Contains(item))
					{
						num2 = 9;
						continue;
					}
					goto IL_7F;
				case 9:
					this._BuffList.Add(item);
					num2 = 6;
					continue;
				default:
					goto IL_E8;
				}
				if (num3 < spellId.Length)
				{
					num2 = 7;
					continue;
				}
				break;
				IL_E8:
				item = spellId[num3];
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5d83dab2d7c4415687f4df21e1f4a0a7 != 0)
				{
					num2 = 8;
					continue;
				}
				continue;
				IL_163:
				num3++;
				num2 = 2;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1eba0904f5ed439aa0e9edb8d6f647ef == 0)
				{
					num2 = 2;
					continue;
				}
				continue;
				IL_7F:
				this.WriteLog(RotationLabHelper.u16DFCO492Q2ZPFWSAg(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1939306647 + 173235911 ^ -1766085502), item.ToString(), RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1815843576 ^ -1815861416)));
				goto IL_163;
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00033FEC File Offset: 0x000321EC
		public void AddDebuff(params int[] spellId)
		{
			int num = 5;
			int num2 = num;
			for (;;)
			{
				int item;
				int num3;
				switch (num2)
				{
				case 1:
					goto IL_99;
				case 2:
					this._DebuffList.Add(item);
					num2 = 7;
					continue;
				case 3:
					if (this._DebuffList.Contains(item))
					{
						goto IL_10F;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_034caeaa576b4bc4a97d7628b4976987 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					num3 = 0;
					num2 = 8;
					continue;
				case 5:
					num2 = 4;
					continue;
				case 6:
					goto IL_10F;
				case 7:
					goto IL_99;
				case 8:
					goto IL_EA;
				}
				break;
				IL_EA:
				if (num3 >= spellId.Length)
				{
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_82ef02aa8b754adb8434f8a772d183e3 != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				else
				{
					item = spellId[num3];
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_3033bf1c1fc44fbd97a2780a04032069 == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				}
				IL_99:
				num3++;
				goto IL_EA;
				IL_10F:
				this.WriteLog(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1654110737 ^ -473083753 ^ -2124767168) + item.ToString() + vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1005505369 ^ -1005486346));
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_24c6414a8a5b4f2680c42f1a5855f977 != 0)
				{
					num2 = 1;
				}
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0003415C File Offset: 0x0003235C
		public void AddToggle(params string[] toggleName)
		{
			int num = 10;
			for (;;)
			{
				int num2 = num;
				int num3;
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						goto IL_1AA;
					case 1:
						goto IL_BF;
					case 2:
						goto IL_23B;
					case 3:
						goto IL_23B;
					case 4:
						goto IL_14C;
					case 5:
						this._InGameToggleList.Add(text);
						num2 = 1;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fbdcf9cf6ee44fc984b2109059e5d2e6 == 0)
						{
							num2 = 0;
							continue;
						}
						continue;
					case 6:
						goto IL_1D1;
					case 7:
						goto IL_E0;
					case 8:
						goto IL_1D1;
					case 9:
						goto IL_199;
					case 10:
						goto IL_1C0;
					case 11:
						goto IL_14C;
					case 12:
						goto IL_21F;
					case 13:
						break;
					case 14:
						goto IL_BF;
					case 15:
						goto IL_BF;
					default:
						goto IL_1AA;
					}
					IL_63:
					this.WriteLog(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(579026892 ^ 579040482) + text + RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1002815721 ^ -877302260 ^ 261036875));
					num2 = 15;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_91bfb50313e244f4ba50c746ee3a2624 != 0)
					{
						num2 = 3;
						continue;
					}
					continue;
					IL_BF:
					num3++;
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba == 0)
					{
						num2 = 2;
						continue;
					}
					continue;
					IL_1AA:
					if (text == "")
					{
						goto IL_BF;
					}
					if (text.Contains(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(145144672 << 4 ^ -1972657554)))
					{
						num2 = 7;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 != 0)
						{
							num2 = 11;
							continue;
						}
						continue;
					}
					IL_E0:
					if (RotationLabHelper.tteptPOOr3Rte5ypXAH(text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-886904286 ^ -886922544)))
					{
						num2 = 4;
						continue;
					}
					goto IL_21F;
					IL_14C:
					this.WriteLog(RotationLabHelper.u16DFCO492Q2ZPFWSAg(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-613886095 << 1 ^ -1227758532), text, RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-831735385 ^ -831720613)));
					num2 = 14;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1fb8b2aca6884e69a3c8f5ed9b2ba50b != 0)
					{
						num2 = 6;
						continue;
					}
					continue;
					IL_1D1:
					text = toggleName[num3];
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a045e374816444ca92d30db5245d264e == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
					IL_23B:
					if (num3 < toggleName.Length)
					{
						num2 = 8;
						continue;
					}
					return;
					IL_21F:
					if (this._InGameToggleList.Contains(text))
					{
						goto IL_63;
					}
					num2 = 5;
				}
				IL_199:
				num3 = 0;
				num = 3;
				continue;
				IL_1C0:
				num = 9;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000343E0 File Offset: 0x000325E0
		public void AddToggleMenu(string menuName, params string[] selectOptions)
		{
			int num = 21;
			int num2 = num;
			string item;
			for (;;)
			{
				int num3;
				string text;
				switch (num2)
				{
				case 1:
					item = RotationLabHelper.nu24XEOF5WqgflNh6ak(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1002815721 ^ -877302260 ^ 261036521), menuName, RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-235868112 ^ -235871138), RotationLabHelper.cQCVcQOfLc1x28uea5W(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1815843576 ^ -1815840410), selectOptions));
					num2 = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_b018848e194944659fd6bf9f5a1f9097 == 0)
					{
						num2 = 6;
						continue;
					}
					continue;
				case 2:
					goto IL_3A6;
				case 3:
					num2 = 10;
					continue;
				case 4:
					if (RotationLabHelper.tteptPOOr3Rte5ypXAH(menuName, RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~603785892 ^ -603791051)))
					{
						num2 = 16;
						continue;
					}
					goto IL_168;
				case 5:
					return;
				case 6:
					if (!this._InGameToggleList.Contains(menuName))
					{
						goto IL_3CC;
					}
					num2 = 15;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6e7080206d494848a398a0198996a1e6 == 0)
					{
						num2 = 17;
						continue;
					}
					continue;
				case 7:
					goto IL_C6;
				case 8:
					goto IL_302;
				case 9:
					goto IL_2C2;
				case 10:
					num3 = 0;
					num2 = 2;
					continue;
				case 11:
					return;
				case 12:
					goto IL_18D;
				case 13:
					goto IL_7F;
				case 14:
					goto IL_3CC;
				case 15:
					goto IL_3A6;
				case 16:
					goto IL_302;
				case 17:
					this.WriteLog(RotationLabHelper.u16DFCO492Q2ZPFWSAg(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~1053049764 ^ -1053034635), menuName, RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-256932895 ^ -256915023)));
					num2 = 5;
					continue;
				case 18:
					if (!RotationLabHelper.tteptPOOr3Rte5ypXAH(text, RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1352740968 ^ -1352737802)))
					{
						goto IL_18D;
					}
					num2 = 13;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_289b03d4275042dab02535e36c7e14db == 0)
					{
						num2 = 12;
						continue;
					}
					continue;
				case 19:
					goto IL_168;
				case 20:
					goto IL_2C2;
				case 21:
					if (menuName == "")
					{
						num2 = 20;
						continue;
					}
					goto IL_C6;
				case 22:
					return;
				}
				break;
				IL_7F:
				this.WriteLog(RotationLabHelper.u16DFCO492Q2ZPFWSAg(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1007749927 ^ -1007763547), text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-235868112 ^ -235881780)));
				num2 = 15;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f8f2733f262849f48168e4f76ab239d7 != 0)
				{
					num2 = 22;
					continue;
				}
				continue;
				IL_18D:
				if (RotationLabHelper.tteptPOOr3Rte5ypXAH(text, RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1690522925 ^ -1690508767)))
				{
					goto IL_7F;
				}
				num3++;
				num2 = 15;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 != 0)
				{
					num2 = 3;
					continue;
				}
				continue;
				IL_C6:
				if (selectOptions.Length < 1)
				{
					goto IL_2C2;
				}
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_26eee6bc8981469dae80fe8383e39f2d != 0)
				{
					num2 = 4;
					continue;
				}
				continue;
				IL_3A6:
				if (num3 >= selectOptions.Length)
				{
					num2 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_8587ff20fd5f487a89bfe65d8ab138e4 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				else
				{
					text = selectOptions[num3];
					num2 = 7;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f247572d217b4ec7bd891923cd5e68bf != 0)
					{
						num2 = 18;
						continue;
					}
					continue;
				}
				IL_168:
				if (!RotationLabHelper.tteptPOOr3Rte5ypXAH(menuName, RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1681481889 ^ 1681467475)))
				{
					num2 = 3;
					continue;
				}
				goto IL_302;
				IL_2C2:
				this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~344187374 ^ -344173231));
				num2 = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_815f08b431b44ac887f007356b7a532a == 0)
				{
					num2 = 0;
					continue;
				}
				continue;
				IL_302:
				this.WriteLog(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1810931007 ^ 1810946017) + menuName + RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1386050510 + 11679858 ^ 1397745340));
				num2 = 11;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 == 0)
				{
					num2 = 5;
				}
			}
			return;
			IL_3CC:
			this._InGameToggleList.Add(item);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000347DC File Offset: 0x000329DC
		public void WriteLog(string logMessage)
		{
			EventHandler<LogEventArgs> newLogEvent = this.NewLogEvent;
			if (newLogEvent == null)
			{
				return;
			}
			newLogEvent(this, new LogEventArgs(logMessage));
			int num = 0;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_923fe78ab3e6434cb4a8749dafbd7eb4 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00034848 File Offset: 0x00032A48
		public RotationLabHelper()
		{
			RotationLabHelper.XxVthAOTupjb5moP3q4();
			RotationLabHelper.uA1Os6ORB4RywPmiKyk();
			this.RotationName = vua32v5yjQhjRjK4YIO.BRA5TcZvlv(--1797548854 ^ 1797529754);
			this._ToggleOptionEnabled = new bool[20];
			this._ToggleSelectIndex = new int[20];
			this._UnitInfo = new Dictionary<string, UnitInformation>();
			this._SpellInfo = new Dictionary<int, SpellInformation>();
			this._ItemInfo = new Dictionary<int, ItemInformation>();
			this._TalentTree = new bool[3, 26];
			this._PlayerRuneCD = new int[6];
			this._PlayerRuneType = new int[6];
			this._PlayerPower = new int[19];
			this._PlayerPowerMax = new int[19];
			this._BasicUnitList = new string[]
			{
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(457652205 ^ 457670175),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1041647104 ^ -1041633278),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1505789866 ^ -1505807746),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1860104403 ^ -1860090597),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1007749927 ^ -1007763765)
			};
			this._PartyUnitList = new string[]
			{
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~603785892 ^ -603799925),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1881006439 >> 3 ^ 235141068),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-185008287 ^ -185027439),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~-1605313923 ^ 1605331330)
			};
			this._ArenaUnitList = new string[]
			{
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2090212177 ^ 2090227521),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(~2095831454 ^ -2095814079),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-582433477 + 1816872807 ^ 1234452626),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-717857995 >> 5 ^ -22413671),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1007749927 ^ -1007765367)
			};
			this._RaidUnitList = new string[]
			{
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-911697958 - 376275890 ^ -1287956408),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1734223699 - -1503209248 ^ -231033949),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(--1722095099 ^ 1722112391),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(587114080 ^ 587131626),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1681481889 ^ 1681468473),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(567103098 ^ 567083740),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1640708702 ^ -1640724202),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-1755352853 ^ -1755366359),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1638637009 >> 6 ^ 25617063),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-283366293 ^ -283352907),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1073891089 ^ 1073875967),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(2090212177 ^ 2090227631),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(185404423 + 1853889833 ^ 2039309374),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(587114080 ^ 587131774),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1199763274 ^ -1199743592),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-2083830725 ^ -2083845883),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-902888658 ^ -902869408),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1767032709 ^ 1767017179),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(1905767247 ^ 1905786401),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(~463906284 ^ -463923347),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-789419076 ^ -35552607 ^ 756262035),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-865714864 ^ -865701682),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-253515656 ^ -1789645123 ^ 1706543979),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(2090212177 ^ 2090227439),
				RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-535478164 ^ -535491166)
			};
			this.SpellCastHistory = new List<SpellCast>();
			this._UnitList = new List<string>();
			this.GlyphList = new List<int>();
			this._BuffList = new List<int>();
			this._DebuffList = new List<int>();
			this._ItemList = new List<int>();
			this._SpellList = new List<int>();
			this._RotationSettings = new Dictionary<string, RotationSetting>();
			this._MacroList = new Dictionary<string, Macro>();
			this._InGameToggleList = new List<string>();
			this._ItemIgnoreList = new List<int>();
			this._SpellIgnoreList = new List<int>();
			this._MacroIgnoreList = new List<string>();
			this._ModifierIgnoreList = new List<string>();
			this._SpellID2Name = new Dictionary<int, string>();
			this._ItemID2Name = new Dictionary<int, string>();
			this._SpellKeyBind = new Dictionary<int, string>();
			this._ItemKeyBind = new Dictionary<int, string>();
			this._MacroKeyBind = new Dictionary<string, string>();
			this._ModifierList = new Dictionary<string, bool>();
			this._ModifierKeyBind = new Dictionary<string, string>();
			this.PreCastTimeWindow = 150;
			this._ManualCastQueueMacroName = "";
			this.ProgramCastTable = new Dictionary<string, long>();
			base..ctor();
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 1:
					return;
				case 2:
					this._InGameToggleList.Add(RotationLabHelper.JHj9LgOi1oyoBrjIhFT(-235868112 ^ -235880978));
					num = 3;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6fd435aca0274a86955ba7bbb960082d == 0)
					{
						num = 2;
						continue;
					}
					continue;
				case 3:
					this._InGameToggleList.Add(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1939306647 + 173235911 ^ -1766085668));
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
					{
						num = 0;
						continue;
					}
					continue;
				}
				this._UnitList.AddRange(this._BasicUnitList);
				num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_0c080a9909304bb4a8ca9ea8d5e25f67 == 0)
				{
					num = 1;
				}
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00034EFC File Offset: 0x000330FC
		// Note: this type is marked as 'beforefieldinit'.
		static RotationLabHelper()
		{
			RotationLabHelper.yIw4CCOL0lSbvtxmd3T();
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00034F0C File Offset: 0x0003310C
		internal static bool VLs8WdOQnqMbb1NTyRx()
		{
			return RotationLabHelper.WlHWBYO3IMl7oF1S9RN == null;
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00034F20 File Offset: 0x00033120
		internal static RotationLabHelper i7yfogOC6m2Uc3q332I()
		{
			return RotationLabHelper.WlHWBYO3IMl7oF1S9RN;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00034F30 File Offset: 0x00033130
		internal static int yuXQ1qO9WC7rEH7F4uY(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00034F44 File Offset: 0x00033144
		internal static double FMRNpaOwjuXuNspPJc6(double A_0)
		{
			return Math.Round(A_0);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x00034F58 File Offset: 0x00033158
		internal static DateTimeOffset b7X0pGOAXC9CJBs0IJK()
		{
			return DateTimeOffset.Now;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00034F68 File Offset: 0x00033168
		internal static bool fH16UaOhc4aBA3Erl2h(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00034F80 File Offset: 0x00033180
		internal static bool Rsld5OOSFtpr4xcybEP(object A_0, object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00034F98 File Offset: 0x00033198
		internal static int SHtTxZOIdGEcj8m4wNr(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00034FAC File Offset: 0x000331AC
		internal static object JHj9LgOi1oyoBrjIhFT(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00034FC0 File Offset: 0x000331C0
		internal static bool T7fw3VOZa2rXHlQYoMS(object A_0, object A_1)
		{
			return A_0.StartsWith(A_1);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00034FD8 File Offset: 0x000331D8
		internal static object jLUIm5OUdsiJ4jIYyLO(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00034FF0 File Offset: 0x000331F0
		internal static bool tF6KZfO1HsHVLDwX48Z(object A_0, int A_1, int A_2)
		{
			return A_0[A_1, A_2];
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0003500C File Offset: 0x0003320C
		internal static object dhIUsZOp7AFnD3iGYXF(int powerIndex)
		{
			return PowerType.PowerIndexToName(powerIndex);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00035020 File Offset: 0x00033220
		internal static object u16DFCO492Q2ZPFWSAg(object A_0, object A_1, object A_2)
		{
			return A_0 + A_1 + A_2;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0003503C File Offset: 0x0003323C
		internal static bool tteptPOOr3Rte5ypXAH(object A_0, object A_1)
		{
			return A_0.Contains(A_1);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00035054 File Offset: 0x00033254
		internal static object cQCVcQOfLc1x28uea5W(object A_0, object A_1)
		{
			return string.Join(A_0, A_1);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0003506C File Offset: 0x0003326C
		internal static object nu24XEOF5WqgflNh6ak(object A_0, object A_1, object A_2, object A_3)
		{
			return A_0 + A_1 + A_2 + A_3;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0003508C File Offset: 0x0003328C
		internal static void XxVthAOTupjb5moP3q4()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0003509C File Offset: 0x0003329C
		internal static void uA1Os6ORB4RywPmiKyk()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000350AC File Offset: 0x000332AC
		internal static void yIw4CCOL0lSbvtxmd3T()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x04000290 RID: 656
		public string RotationName;

		// Token: 0x04000291 RID: 657
		public bool TBCRotation;

		// Token: 0x04000292 RID: 658
		public bool WrathRotation;

		// Token: 0x04000293 RID: 659
		private bool _HealingRotation;

		// Token: 0x04000294 RID: 660
		private bool _PVPRotation;

		// Token: 0x04000295 RID: 661
		public bool _LastPixelReadSuccess;

		// Token: 0x04000296 RID: 662
		public int ProfileClass;

		// Token: 0x04000297 RID: 663
		public int PlayerClass;

		// Token: 0x04000298 RID: 664
		public int MainHandSwingTimer;

		// Token: 0x04000299 RID: 665
		public int MainHandSwingSpeed;

		// Token: 0x0400029A RID: 666
		public int OffHandSwingTimer;

		// Token: 0x0400029B RID: 667
		public int OffhandSwingSpeed;

		// Token: 0x0400029C RID: 668
		public int HunterSwingTimer;

		// Token: 0x0400029D RID: 669
		public int HunterSwingSpeed;

		// Token: 0x0400029E RID: 670
		public int PlayerComboPoints;

		// Token: 0x0400029F RID: 671
		public int MainHandSwingTimerWeakAura;

		// Token: 0x040002A0 RID: 672
		public int LastDodgeTime;

		// Token: 0x040002A1 RID: 673
		public int LastNotBehindTargetTime;

		// Token: 0x040002A2 RID: 674
		public int LastNotInLineOfSightTime;

		// Token: 0x040002A3 RID: 675
		public int LossOfControlSpellId;

		// Token: 0x040002A4 RID: 676
		public int LossOfControlTimeRemaining;

		// Token: 0x040002A5 RID: 677
		public int LossOfControlType;

		// Token: 0x040002A6 RID: 678
		public int PlayerForm;

		// Token: 0x040002A7 RID: 679
		public bool PlayerIsOutdoor;

		// Token: 0x040002A8 RID: 680
		public bool PlayerIsInRaid;

		// Token: 0x040002A9 RID: 681
		public bool PlayerIsInGroup;

		// Token: 0x040002AA RID: 682
		public bool PlayerIsMounted;

		// Token: 0x040002AB RID: 683
		public bool PlayerHasPet;

		// Token: 0x040002AC RID: 684
		public bool PlayerIsMoving;

		// Token: 0x040002AD RID: 685
		public bool PlayerHasShield;

		// Token: 0x040002AE RID: 686
		public bool PlayerHasOneHand;

		// Token: 0x040002AF RID: 687
		public bool PlayerHasTwoHand;

		// Token: 0x040002B0 RID: 688
		public int AOEUnitCount;

		// Token: 0x040002B1 RID: 689
		public int AOEMeleeUnitCount;

		// Token: 0x040002B2 RID: 690
		public bool PlayerIsTankingTarget;

		// Token: 0x040002B3 RID: 691
		public int PlayerTankingStatus;

		// Token: 0x040002B4 RID: 692
		public int PlayerThreatPercent;

		// Token: 0x040002B5 RID: 693
		public int PlayerRawThreatPercent;

		// Token: 0x040002B6 RID: 694
		public int CurrentGroupNumber;

		// Token: 0x040002B7 RID: 695
		public int TargetCreatureType;

		// Token: 0x040002B8 RID: 696
		public int PlayerThreatValue;

		// Token: 0x040002B9 RID: 697
		public bool Trinket1Usable;

		// Token: 0x040002BA RID: 698
		public bool Trinket2Usable;

		// Token: 0x040002BB RID: 699
		public int Trinket1CooldownRemaining;

		// Token: 0x040002BC RID: 700
		public int Trinket2CooldownRemaining;

		// Token: 0x040002BD RID: 701
		public int MainHandEnchantExpiration;

		// Token: 0x040002BE RID: 702
		public int OffHandEnchantExpiration;

		// Token: 0x040002BF RID: 703
		public int TargetTTD;

		// Token: 0x040002C0 RID: 704
		public int EnemyMaxTTD;

		// Token: 0x040002C1 RID: 705
		public int EnemyMinTTD;

		// Token: 0x040002C2 RID: 706
		public int WindFuryCD;

		// Token: 0x040002C3 RID: 707
		public int PlayerSpec;

		// Token: 0x040002C4 RID: 708
		public int PlayerRaceId;

		// Token: 0x040002C5 RID: 709
		public bool PlayerIsInVehicle;

		// Token: 0x040002C6 RID: 710
		public int FireTotemSpellId;

		// Token: 0x040002C7 RID: 711
		public int FireTotemTimeRemaining;

		// Token: 0x040002C8 RID: 712
		public int FireTotemTimeElasped;

		// Token: 0x040002C9 RID: 713
		public int EarthTotemSpellId;

		// Token: 0x040002CA RID: 714
		public int EarthTotemTimeRemaining;

		// Token: 0x040002CB RID: 715
		public int EarthTotemTimeElasped;

		// Token: 0x040002CC RID: 716
		public int WaterTotemSpellId;

		// Token: 0x040002CD RID: 717
		public int WaterTotemTimeRemaining;

		// Token: 0x040002CE RID: 718
		public int WaterTotemTimeElasped;

		// Token: 0x040002CF RID: 719
		public int AirTotemSpellId;

		// Token: 0x040002D0 RID: 720
		public int AirTotemTimeRemaining;

		// Token: 0x040002D1 RID: 721
		public int AirTotemTimeElasped;

		// Token: 0x040002D2 RID: 722
		public bool ChatFocused;

		// Token: 0x040002D3 RID: 723
		public int PlayerAttackPower;

		// Token: 0x040002D4 RID: 724
		public int PlayerArmorPenetration;

		// Token: 0x040002D5 RID: 725
		public bool SpellIsTargeting;

		// Token: 0x040002D6 RID: 726
		public int PlayerCovenant;

		// Token: 0x040002D7 RID: 727
		public int CurrentGCD;

		// Token: 0x040002D8 RID: 728
		public int TotalGCD;

		// Token: 0x040002D9 RID: 729
		public bool[] _ToggleOptionEnabled;

		// Token: 0x040002DA RID: 730
		public int[] _ToggleSelectIndex;

		// Token: 0x040002DB RID: 731
		public Dictionary<string, UnitInformation> _UnitInfo;

		// Token: 0x040002DC RID: 732
		public Dictionary<int, SpellInformation> _SpellInfo;

		// Token: 0x040002DD RID: 733
		public Dictionary<int, ItemInformation> _ItemInfo;

		// Token: 0x040002DE RID: 734
		public bool[,] _TalentTree;

		// Token: 0x040002DF RID: 735
		public int[] _PlayerRuneCD;

		// Token: 0x040002E0 RID: 736
		public int[] _PlayerRuneType;

		// Token: 0x040002E1 RID: 737
		public int[] _PlayerPower;

		// Token: 0x040002E2 RID: 738
		public int[] _PlayerPowerMax;

		// Token: 0x040002E3 RID: 739
		private string[] _BasicUnitList;

		// Token: 0x040002E4 RID: 740
		private string[] _PartyUnitList;

		// Token: 0x040002E5 RID: 741
		private string[] _ArenaUnitList;

		// Token: 0x040002E6 RID: 742
		private string[] _RaidUnitList;

		// Token: 0x040002E7 RID: 743
		public List<SpellCast> SpellCastHistory;

		// Token: 0x040002E8 RID: 744
		public List<string> _UnitList;

		// Token: 0x040002E9 RID: 745
		public List<int> GlyphList;

		// Token: 0x040002EA RID: 746
		public List<int> _BuffList;

		// Token: 0x040002EB RID: 747
		public List<int> _DebuffList;

		// Token: 0x040002EC RID: 748
		public List<int> _ItemList;

		// Token: 0x040002ED RID: 749
		public List<int> _SpellList;

		// Token: 0x040002EE RID: 750
		public Dictionary<string, RotationSetting> _RotationSettings;

		// Token: 0x040002EF RID: 751
		public Dictionary<string, Macro> _MacroList;

		// Token: 0x040002F0 RID: 752
		public List<string> _InGameToggleList;

		// Token: 0x040002F1 RID: 753
		public List<int> _ItemIgnoreList;

		// Token: 0x040002F2 RID: 754
		public List<int> _SpellIgnoreList;

		// Token: 0x040002F3 RID: 755
		public List<string> _MacroIgnoreList;

		// Token: 0x040002F4 RID: 756
		public List<string> _ModifierIgnoreList;

		// Token: 0x040002F5 RID: 757
		private Dictionary<int, string> _SpellID2Name;

		// Token: 0x040002F6 RID: 758
		private Dictionary<int, string> _ItemID2Name;

		// Token: 0x040002F7 RID: 759
		private Dictionary<int, string> _SpellKeyBind;

		// Token: 0x040002F8 RID: 760
		private Dictionary<int, string> _ItemKeyBind;

		// Token: 0x040002F9 RID: 761
		private Dictionary<string, string> _MacroKeyBind;

		// Token: 0x040002FA RID: 762
		public Dictionary<string, bool> _ModifierList;

		// Token: 0x040002FB RID: 763
		public Dictionary<string, string> _ModifierKeyBind;

		// Token: 0x040002FC RID: 764
		private bool isTrackingParty;

		// Token: 0x040002FD RID: 765
		private bool isTrackingArena;

		// Token: 0x040002FE RID: 766
		private bool isTrackingRaid;

		// Token: 0x040002FF RID: 767
		public int PreCastTimeWindow;

		// Token: 0x04000301 RID: 769
		public bool _EnableManualCastQueue;

		// Token: 0x04000302 RID: 770
		public bool _AttackPlayerNotInCombat;

		// Token: 0x04000303 RID: 771
		public bool _AttackTargetNotInCombat;

		// Token: 0x04000304 RID: 772
		public bool _AutoTab;

		// Token: 0x04000305 RID: 773
		public int _ManualCastType;

		// Token: 0x04000306 RID: 774
		public int _ManualCastQueueSpellID;

		// Token: 0x04000307 RID: 775
		public int _ManualCastQueueItemID;

		// Token: 0x04000308 RID: 776
		public string _ManualCastQueueMacroName;

		// Token: 0x04000309 RID: 777
		public long _ManualCastQueueTimestamp;

		// Token: 0x0400030A RID: 778
		private Dictionary<string, long> ProgramCastTable;

		// Token: 0x0400030E RID: 782
		internal static RotationLabHelper WlHWBYO3IMl7oF1S9RN;

		// Token: 0x02000043 RID: 67
		private sealed class thwlQccj9sB2Svm1I3s : MulticastDelegate
		{
			// Token: 0x060006FF RID: 1791
			public extern thwlQccj9sB2Svm1I3s(object \u0020, IntPtr \u0020);

			// Token: 0x06000700 RID: 1792
			public extern void Invoke(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

			// Token: 0x06000701 RID: 1793
			public extern IAsyncResult BeginInvoke(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime, AsyncCallback callback, object @object);

			// Token: 0x06000702 RID: 1794
			public extern void EndInvoke(IAsyncResult result);

			// Token: 0x06000703 RID: 1795 RVA: 0x000403FC File Offset: 0x0003E5FC
			static thwlQccj9sB2Svm1I3s()
			{
				vua32v5yjQhjRjK4YIO.aep5UvAyyY();
			}
		}
	}
}
