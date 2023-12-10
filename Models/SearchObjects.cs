using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Jack.Core;
using Jack.Engine;

namespace Jack.Models
{
	// Token: 0x02000035 RID: 53
	public class SearchObjects : MemoryObject
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x00672EBC File Offset: 0x006710BC
		public SearchObjects(IntPtr baseAddress) : base(baseAddress)
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00672ED0 File Offset: 0x006710D0
		public IntPtr DescriptorFields
		{
			get
			{
				return (IntPtr)Read.Combined<IntPtr>(this.baseAddress + Descriptors.Main_DescriptorFields);
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00672EF8 File Offset: 0x006710F8
		public static void SearchReset()
		{
			SearchObjects.SearchFor = "";
			SearchObjects.SearchFrom = 0;
			SearchObjects.SearchRange = 0;
			SearchObjects.SearchType = "";
			SearchObjects.SearchAddress = "";
			SearchObjects.SearchAddressBase = IntPtr.Zero;
			SearchObjects.SearchCondition1Option = "";
			SearchObjects.SearchCondition1Compare = "";
			SearchObjects.SearchCondition1Value = 0;
			SearchObjects.SearchConditionAndOr = "";
			SearchObjects.SearchCondition2Option = "";
			SearchObjects.SearchCondition2Compare = "";
			SearchObjects.SearchCondition2Value = 0;
			SearchObjects.SearchContainOption = "";
			SearchObjects.SearchContain.Clear();
			SearchObjects.SearchCompareMode = "";
			SearchObjects.SearchStopWhenFound = false;
			SearchObjects.IsCustomSearch = false;
			SearchObjects.SearchCurrentProgressValue = 0;
			SearchObjects.SearchProgressResultsCount = 0;
			SearchObjects.Complete = false;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00672FB4 File Offset: 0x006711B4
		public void SearchConsole(string Text, string Color = "")
		{
			Tools.Console(Text, Color, "richSearchOutput", "frmTeam", true);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00672FD4 File Offset: 0x006711D4
		public void StartSearch()
		{
			SearchObjects.IsInCompareMode = (SearchObjects.SearchCompareMode == "Compare");
			SearchObjects.IsCustomSearch = SearchObjects.SearchFor.Contains("[Custom]");
			SearchObjects.CompareList.Clear();
			if (!SearchObjects.IsInCompareMode)
			{
				SearchObjects.ValuesList.Clear();
			}
			new Thread(new ThreadStart(SearchObjects.smethod_0))
			{
				IsBackground = true
			}.Start();
			Thread thread;
			if (!(SearchObjects.SearchType == "int16") && !(SearchObjects.SearchType == "short"))
			{
				if (!(SearchObjects.SearchType == "int32") && !(SearchObjects.SearchType == "int"))
				{
					if (!(SearchObjects.SearchType == "int64") && !(SearchObjects.SearchType == "long"))
					{
						if (!(SearchObjects.SearchType == "UInt128"))
						{
							if (SearchObjects.SearchType == "float")
							{
								thread = new Thread(delegate()
								{
									this.Search<float>();
								});
							}
							else if (!(SearchObjects.SearchType == "double"))
							{
								if (!(SearchObjects.SearchType == "bool"))
								{
									if (!(SearchObjects.SearchType == "byte"))
									{
										if (!(SearchObjects.SearchType == "string"))
										{
											this.SearchConsole("Please enter a valid Search-Type.", "Red");
											return;
										}
										thread = new Thread(delegate()
										{
											this.Search<string>();
										});
									}
									else
									{
										thread = new Thread(delegate()
										{
											this.Search<byte>();
										});
									}
								}
								else
								{
									thread = new Thread(delegate()
									{
										this.Search<bool>();
									});
								}
							}
							else
							{
								thread = new Thread(delegate()
								{
									this.Search<double>();
								});
							}
						}
						else
						{
							thread = new Thread(delegate()
							{
								this.Search<UInt128>();
							});
						}
					}
					else
					{
						thread = new Thread(delegate()
						{
							this.Search<long>();
						});
					}
				}
				else
				{
					thread = new Thread(delegate()
					{
						this.Search<int>();
					});
				}
			}
			else
			{
				thread = new Thread(delegate()
				{
					this.Search<short>();
				});
			}
			thread.IsBackground = true;
			thread.Start();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00673200 File Offset: 0x00671400
		private void Search<SearchType>()
		{
			SearchObjects.Running = true;
			bool flag = false;
			object @lock = ObjectManager._lock;
			lock (@lock)
			{
				SearchObjects.SearchAddressBase = this.baseAddress;
				if (SearchObjects.SearchAddress == "DescriptorFields")
				{
					SearchObjects.SearchAddressBase = this.DescriptorFields;
				}
				if (!SearchObjects.SearchFor.Contains("[Default]"))
				{
					if (SearchObjects.SearchFor.Contains("[ByShifting]"))
					{
						this.ByShifting();
					}
					else if (SearchObjects.SearchFor.Contains("[Custom]"))
					{
						SearchObjects.SearchFor = SearchObjects.SearchFor.Replace("[Custom]", "").Trim();
						if (!(SearchObjects.SearchFor == "UnitFields_Swimming"))
						{
							if (SearchObjects.SearchFor == "UnitFields_Flying")
							{
								this.UnitFields_Flying();
							}
							else if (!(SearchObjects.SearchFor == "Spellbook_Base"))
							{
								if (!(SearchObjects.SearchFor == "Spellbook_Spell"))
								{
									if (!(SearchObjects.SearchFor == "UnitFields_Information_2_And_Name"))
									{
										if (SearchObjects.SearchFor == "UnitFields_CreatureRankOrCreatureType")
										{
											this.UnitFields_CreatureRankOrCreatureType();
										}
										else if (!(SearchObjects.SearchFor == "UnitFields_Flags1"))
										{
											if (!(SearchObjects.SearchFor == "UnitFields_DynamicFlags"))
											{
												if (!(SearchObjects.SearchFor == "Auras (Classic)"))
												{
													if (!(SearchObjects.SearchFor == "Auras (Retail)"))
													{
														if (SearchObjects.SearchFor == "Professions")
														{
															this.Professions();
														}
														else if (SearchObjects.SearchFor == "Inventory_Equipped_Bags")
														{
															this.Inventory_Equipped_Bags();
														}
														else if (SearchObjects.SearchFor == "Items_MainBag_Bank_Equipment")
														{
															this.Items_MainBag_Bank_Equipment();
														}
														else if (!(SearchObjects.SearchFor == "Camera_Offset"))
														{
															if (SearchObjects.SearchFor == "Camera_Matrix")
															{
																this.Camera_Matrix();
															}
															else if (SearchObjects.SearchFor == "Object_Unit_Matrix")
															{
																this.Object_Unit_Matrix();
															}
															else if (!(SearchObjects.SearchFor == "Cooldown_Base"))
															{
																if (SearchObjects.SearchFor == "PlayerNames")
																{
																	this.PlayerNames();
																}
															}
															else
															{
																this.Cooldown_Base();
															}
														}
														else
														{
															this.Camera_Offset();
														}
													}
													else
													{
														this.AurasRetail();
													}
												}
												else
												{
													this.AurasClassic();
												}
											}
											else
											{
												this.UnitFields_DynamicFlags();
											}
										}
										else
										{
											this.UnitFields_Flags1();
										}
									}
									else
									{
										this.UnitFields_Information_2_And_Name();
									}
								}
								else
								{
									this.Spellbook_Spell();
								}
							}
							else
							{
								this.Spellbook_Base_And_Spell();
							}
						}
						else
						{
							this.UnitFields_Swimming();
						}
					}
					else if (SearchObjects.SearchFor.Contains("[Test]"))
					{
						flag = true;
						SearchObjects.SearchFor = SearchObjects.SearchFor.Replace("[Test]", "").Trim();
						if (SearchObjects.SearchFor == "Frames")
						{
							this.TestFrames();
						}
					}
				}
				else
				{
					this.DefaultSearch<SearchType>();
				}
			}
			if (!flag)
			{
				if (SearchObjects.SearchCompareMode == "")
				{
					if (SearchObjects.ValuesList.Count != 0)
					{
						StringBuilder stringBuilder = new StringBuilder();
						foreach (KeyValuePair<string, string> keyValuePair in SearchObjects.ValuesList)
						{
							stringBuilder.Append(keyValuePair.Key + " -> " + keyValuePair.Value + "\r\n");
						}
						this.SearchConsole(stringBuilder.ToString(), "");
					}
					else
					{
						this.SearchConsole("Nothing found.", "");
					}
				}
				else if (!(SearchObjects.SearchCompareMode == "Search"))
				{
					if (SearchObjects.SearchCompareMode == "Compare")
					{
						if (SearchObjects.CompareList.Count == 0)
						{
							this.SearchConsole("CompareList is empty.", "");
						}
						else
						{
							StringBuilder stringBuilder2 = new StringBuilder();
							foreach (KeyValuePair<string, string> keyValuePair2 in SearchObjects.CompareList)
							{
								string key = keyValuePair2.Key;
								if (SearchObjects.ValuesList.ContainsKey(key) && SearchObjects.ValuesList[key] != keyValuePair2.Value)
								{
									stringBuilder2.Append(string.Concat(new string[]
									{
										key,
										" -> Old: ",
										SearchObjects.ValuesList[key],
										" -> New: ",
										keyValuePair2.Value,
										"\r\n"
									}));
								}
							}
							if (stringBuilder2.Length == 0)
							{
								this.SearchConsole("No different results found.", "");
							}
							else
							{
								this.SearchConsole(stringBuilder2.ToString(), "");
							}
						}
					}
				}
				else
				{
					this.SearchConsole(SearchObjects.ValuesList.Count.ToString() + " entries found. Ready to compare...", "");
				}
			}
			if (SearchObjects.Stop)
			{
				SearchObjects.Stop = false;
			}
			SearchObjects.Complete = true;
			SearchObjects.Running = false;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00673778 File Offset: 0x00671978
		private void DefaultSearch<T>()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					try
					{
						object value;
						if (SearchObjects.SearchAddress == "SingleFromProcess")
						{
							value = (T)((object)Read.Single<T>(num));
						}
						else
						{
							value = (T)((object)Read.Combined<T>(SearchObjects.SearchAddressBase + num));
						}
						this.CheckAndSaveValues(value, text);
					}
					catch
					{
					}
				}
				num++;
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0067382C File Offset: 0x00671A2C
		private void ByShifting()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					try
					{
						int num2 = (int)Read.Combined<int>(SearchObjects.SearchAddressBase + num) >> 8 & 255;
						this.CheckAndSaveValues(num2, text);
					}
					catch
					{
					}
				}
				num++;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x006738BC File Offset: 0x00671ABC
		private void Spellbook_Base_And_Spell()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				int num2 = (int)Read.Single<int>(num);
				if (this.CheckContainCondition(num2))
				{
					num2 = num + 8;
					IntPtr intPtr = (IntPtr)Read.Single<IntPtr>(num2);
					if (!(intPtr == IntPtr.Zero))
					{
						int num3 = 0;
						while (num3 < 20 && !SearchObjects.Stop)
						{
							IntPtr intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr + num3);
							if (!(intPtr2 == IntPtr.Zero) && (int)Read.Combined<int>(intPtr2 + 4) > 0)
							{
								string text = "Spellbook_Base: " + Tools.ConvertToHex(num2);
								text = text + " -> Spellbook_Spell: " + Tools.ConvertToHex(num3);
								this.SearchConsole(text, "");
							}
							num3++;
						}
					}
				}
				num++;
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x006739B0 File Offset: 0x00671BB0
		private void Spellbook_Spell()
		{
			IntPtr pointer = (IntPtr)Read.Single<IntPtr>(Offsets.Spellbook_Base);
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					IntPtr intPtr = (IntPtr)Read.Combined<IntPtr>(pointer + num);
					if (!(intPtr == IntPtr.Zero))
					{
						int num2 = (int)Read.Combined<int>(intPtr + 4);
						if (num2 > 0)
						{
							this.CheckAndSaveValues(num2, text);
						}
					}
				}
				num++;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00673A54 File Offset: 0x00671C54
		private void UnitFields_Swimming()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					bool flag = ((int)Read.Combined<int>(SearchObjects.SearchAddressBase + num) & Descriptors.UnitFields_SwimmingMask) != 0;
					this.CheckAndSaveValues(flag, text);
				}
				num++;
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00673AD0 File Offset: 0x00671CD0
		private void UnitFields_Flying()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					bool flag = ((int)Read.Combined<int>(SearchObjects.SearchAddressBase + num) & Descriptors.UnitFields_FlyingMask) != 0;
					this.CheckAndSaveValues(flag, text);
				}
				num++;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00673B4C File Offset: 0x00671D4C
		private void UnitFields_Information_2_And_Name()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				IntPtr intPtr = (IntPtr)Read.Combined<IntPtr>(SearchObjects.SearchAddressBase + num);
				if (!(intPtr == IntPtr.Zero))
				{
					int num2 = 0;
					while (num2 < 500 && !SearchObjects.Stop)
					{
						string text = Tools.ConvertToHex(num);
						text = text + " -> " + Tools.ConvertToHex(num2);
						IntPtr intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr + num2);
						if (!(intPtr2 == IntPtr.Zero))
						{
							string value = (string)Read.Combined<string>(intPtr2);
							this.CheckAndSaveValues(value, text);
						}
						else if (num2 == 0)
						{
							break;
						}
						num2++;
					}
				}
				num++;
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00673C1C File Offset: 0x00671E1C
		private void UnitFields_CreatureRankOrCreatureType()
		{
			IntPtr pointer = (IntPtr)Read.Combined<IntPtr>(SearchObjects.SearchAddressBase + Descriptors.UnitFields_Information_2);
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					int num2 = (int)Read.Combined<int>(pointer + num);
					this.CheckAndSaveValues(num2, text);
				}
				num++;
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00673CA4 File Offset: 0x00671EA4
		private void UnitFields_Flags1()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					int num2 = (int)Read.Combined<int>(SearchObjects.SearchAddressBase + num);
					if (num2 > 0)
					{
						bool flag = Convert.ToBoolean(num2 & 524288);
						this.CheckAndSaveValues(flag, text);
					}
				}
				num++;
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00673D28 File Offset: 0x00671F28
		private void UnitFields_DynamicFlags()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					int num2 = (int)Read.Combined<int>(SearchObjects.SearchAddressBase + num);
					if (SearchObjects.IsInCompareMode || !(num2.ToString("X") != "4"))
					{
						bool flag = Convert.ToBoolean(num2 & 4);
						this.CheckAndSaveValues(flag, text);
					}
				}
				num++;
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00673DCC File Offset: 0x00671FCC
		private void AurasClassic()
		{
			this.SearchConsole("Custom Search started (Classic)...", "");
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				int offset = num;
				int offset2 = num + 8;
				try
				{
					int num2 = (int)Read.Combined<int>(_globals.playerBaseAddress + offset);
					if (num2 == -1)
					{
						num2 = (int)Read.Combined<int>(_globals.playerBaseAddress + offset2);
					}
					IntPtr intPtr = IntPtr.Zero;
					if (num2 != -1)
					{
						intPtr = _globals.playerBaseAddress + offset2;
					}
					else
					{
						intPtr = _globals.playerBaseAddress + offset;
					}
					if (!(intPtr == IntPtr.Zero))
					{
						if (!_globals.IsRetail)
						{
							if (num2 != 256)
							{
								goto IL_23D;
							}
						}
						else if (_globals.IsRetail && (num2 <= 0 || num2 > 30))
						{
							goto IL_23D;
						}
						int num3 = 0;
						while (num3 < num2 && !SearchObjects.Stop)
						{
							int num4 = 100;
							while (num4 < 200 && !SearchObjects.Stop)
							{
								bool flag = false;
								int num5 = 50;
								while (num5 < 150 && (!SearchObjects.Stop && !flag))
								{
									int num6 = (int)Read.Combined<int>(intPtr + num3 * num4 + num5);
									if (this.CheckContainCondition(num6))
									{
										int num7 = num6;
										for (int i = 0; i < num2; i++)
										{
											if (SearchObjects.Stop)
											{
												break;
											}
											num6 = (int)Read.Combined<int>(intPtr + i * num4 + num5);
											if (num6 != num7 && this.CheckContainCondition(num6))
											{
												StringBuilder stringBuilder = new StringBuilder();
												stringBuilder.Append("AuraTable: " + Tools.ConvertToHex(num) + " -> ");
												stringBuilder.Append("AuraSize: " + Tools.ConvertToHex(num4) + " -> ");
												stringBuilder.Append("AuraSpellID: " + Tools.ConvertToHex(num5));
												this.SearchConsole(stringBuilder.ToString(), "");
												flag = true;
												break;
											}
										}
									}
									num5++;
								}
								num4++;
							}
							num3++;
						}
					}
				}
				catch
				{
				}
				IL_23D:
				num++;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0067403C File Offset: 0x0067223C
		private void AurasRetail()
		{
			this.SearchConsole("Custom Search started (Retail)...", "");
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				int offset = num;
				int offset2 = num + 8;
				try
				{
					int num2 = (int)Read.Combined<int>(_globals.playerBaseAddress + offset);
					if (num2 == -1)
					{
						num2 = (int)Read.Combined<int>(_globals.playerBaseAddress + offset2);
					}
					IntPtr intPtr = IntPtr.Zero;
					if (num2 == -1)
					{
						intPtr = _globals.playerBaseAddress + offset;
					}
					else
					{
						intPtr = _globals.playerBaseAddress + offset2;
					}
					if (!(intPtr == IntPtr.Zero))
					{
						if (!_globals.IsRetail)
						{
							if (num2 != 256)
							{
								goto IL_243;
							}
						}
						else if (_globals.IsRetail && (num2 <= 0 || num2 > 30))
						{
							goto IL_243;
						}
						int num3 = 0;
						while (num3 < num2 && !SearchObjects.Stop)
						{
							int num4 = 100;
							while (num4 < 200 && !SearchObjects.Stop)
							{
								bool flag = false;
								int num5 = 50;
								while (num5 < 150 && (!SearchObjects.Stop && !flag))
								{
									int num6 = (int)Read.Combined<int>(intPtr + num3 * num4 + num5);
									if (this.CheckContainCondition(num6))
									{
										int num7 = num6;
										int num8 = 0;
										while (num8 < num2 && !SearchObjects.Stop)
										{
											num6 = (int)Read.Combined<int>(intPtr + num8 * num4 + num5);
											if (num6 != num7)
											{
												if (this.CheckContainCondition(num6))
												{
													StringBuilder stringBuilder = new StringBuilder();
													stringBuilder.Append("AuraTable: " + Tools.ConvertToHex(num) + " -> ");
													stringBuilder.Append("AuraSize: " + Tools.ConvertToHex(num4) + " -> ");
													stringBuilder.Append("AuraSpellID: " + Tools.ConvertToHex(num5));
													this.SearchConsole(stringBuilder.ToString(), "");
													flag = true;
													break;
												}
											}
											num8++;
										}
									}
									num5++;
								}
								num4++;
							}
							num3++;
						}
					}
				}
				catch
				{
				}
				IL_243:
				num++;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x006742B4 File Offset: 0x006724B4
		private void Professions()
		{
			this.SearchConsole("Custom Search started...", "");
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				if ((int)Read.Combined<int>(SearchObjects.SearchAddressBase + num * 4) > 0)
				{
					int num2 = 0;
					int num3 = 0;
					int num4 = 0;
					while (num4 < 500 && !SearchObjects.Stop)
					{
						short num5 = (short)Read.Combined<short>(SearchObjects.SearchAddressBase + num * 4 + num2);
						if (this.CheckContainCondition(num5))
						{
							int num6 = 0;
							while (num6 < 1200 && !SearchObjects.Stop)
							{
								short num7 = (short)Read.Combined<short>(SearchObjects.SearchAddressBase + num * 4 + num3 * 2 + num6);
								if ((int)num7 == SearchObjects.SearchCondition1Value)
								{
									short num8 = (short)Read.Combined<short>(SearchObjects.SearchAddressBase + num * 4 + num3 * 2 + num6 * 2);
									if ((int)num8 == SearchObjects.SearchCondition2Value)
									{
										string text = Tools.ConvertToHex(num);
										string text2 = Tools.ConvertToHex(num6);
										string text3 = Tools.ConvertToHex(num6 * 2);
										string[] array = new string[11];
										array[0] = text;
										array[1] = " * 4 (SkillLine) -> ";
										array[2] = text2;
										array[3] = " (CurrentSkill: ";
										array[4] = num7.ToString();
										array[5] = ") -> ";
										array[6] = text3;
										array[7] = " (MaxRank: ";
										array[8] = num8.ToString();
										array[9] = ") -> ";
										int num9 = 10;
										Constants.Professions professions = (Constants.Professions)num5;
										array[num9] = professions.ToString();
										this.SearchConsole(string.Concat(array), "");
									}
								}
								num6++;
							}
						}
						num2 += 2;
						num3++;
						num4++;
					}
				}
				num++;
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x006744A0 File Offset: 0x006726A0
		private void Inventory_Equipped_Bags()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					UInt128 @uint = (UInt128)Read.Single<UInt128>(Offsets.Container_BagGUIDs + num);
					if (ObjectManager.GetContainerByGUID(@uint) != null)
					{
						this.CheckAndSaveValues(@uint, text);
					}
				}
				num++;
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00674518 File Offset: 0x00672718
		private void Items_MainBag_Bank_Equipment()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string text = Tools.ConvertToHex(num);
				if (!SearchObjects.IsInCompareMode || SearchObjects.ValuesList.ContainsKey(text))
				{
					UInt128 @uint = (UInt128)Read.Combined<UInt128>(SearchObjects.SearchAddressBase + num);
					string value = @uint.ToString();
					if (!(@uint <= 0) && this.CheckContainCondition(value))
					{
						string str = "-BAG-";
						Items itemByGUID = ObjectManager.GetItemByGUID(@uint);
						if (itemByGUID != null)
						{
							str = itemByGUID.ItemName;
						}
						text = text + " (" + str + ")";
						this.CheckAndSaveValues(@uint, text);
					}
				}
				num++;
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x006745E4 File Offset: 0x006727E4
		private void Camera_Offset()
		{
			SearchObjects.SearchFrom = Descriptors.Camera_Offset - SearchObjects.SearchRange / 2;
			SearchObjects.SearchRange = Descriptors.Camera_Offset + SearchObjects.SearchRange / 2;
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				IntPtr intPtr = (IntPtr)Read.Combined<IntPtr>((IntPtr)Read.Single<IntPtr>(Offsets.Camera_Base) + num);
				if (!(intPtr == IntPtr.Zero))
				{
					int num2 = 0;
					while (num2 < 150 && !SearchObjects.Stop)
					{
						string hex = Tools.ConvertToHex(num) + " (Offset) -> " + Tools.ConvertToHex(num2);
						try
						{
							float num3 = (float)Read.Combined<float>(intPtr + num2);
							this.CheckAndSaveValues(num3, hex);
							goto IL_CF;
						}
						catch
						{
							goto IL_CF;
						}
						break;
						IL_CF:
						num2++;
					}
				}
				num++;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x006746D8 File Offset: 0x006728D8
		private void Camera_Matrix()
		{
			this.SearchConsole("Custom Search started...", "");
			IntPtr pointer = (IntPtr)Read.Combined<IntPtr>((IntPtr)Read.Single<IntPtr>(Offsets.Camera_Base) + Descriptors.Camera_Offset);
			for (int i = SearchObjects.SearchFrom; i < SearchObjects.SearchRange; i++)
			{
				try
				{
					byte[] value = _globals.processHandleRead.Memory.Read<byte>(pointer + i, 36);
					string text = new Matrix4x4(BitConverter.ToSingle(value, 0), BitConverter.ToSingle(value, 4), BitConverter.ToSingle(value, 8), 0f, BitConverter.ToSingle(value, 12), BitConverter.ToSingle(value, 16), BitConverter.ToSingle(value, 20), 0f, BitConverter.ToSingle(value, 24), BitConverter.ToSingle(value, 28), BitConverter.ToSingle(value, 32), 0f, 0f, 0f, 0f, 1f).ToString();
					if (!text.Contains("M11:0 M12:0 M13:0 M14:0") && !text.Contains("E+") && !text.Contains("E-") && !text.Contains("NaN"))
					{
						string str = Tools.ConvertToHex(i);
						this.SearchConsole(str + " -> " + text, "");
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00674838 File Offset: 0x00672A38
		private void Object_Unit_Matrix()
		{
			this.SearchConsole("Custom Search started...", "");
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				string str = Tools.ConvertToHex(num);
				try
				{
					byte[] value = _globals.processHandleRead.Memory.Read<byte>(SearchObjects.SearchAddressBase + num, 36);
					string text = new Matrix4x4(BitConverter.ToSingle(value, 0), BitConverter.ToSingle(value, 4), BitConverter.ToSingle(value, 8), 0f, BitConverter.ToSingle(value, 12), BitConverter.ToSingle(value, 16), BitConverter.ToSingle(value, 20), 0f, BitConverter.ToSingle(value, 24), BitConverter.ToSingle(value, 28), BitConverter.ToSingle(value, 32), 0f, 0f, 0f, 0f, 1f).ToString();
					if (!text.Contains("M11:0 M12:0 M13:0 M14:0") && !text.Contains("E+") && !text.Contains("E-") && !text.Contains("NaN"))
					{
						this.SearchConsole(str + " -> " + text, "");
					}
				}
				catch
				{
				}
				num++;
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00674988 File Offset: 0x00672B88
		private void Cooldown_Base()
		{
			SearchObjects.SearchFrom = Offsets.Cooldown_Base - SearchObjects.SearchRange / 2;
			SearchObjects.SearchRange = Offsets.Cooldown_Base + SearchObjects.SearchRange / 2;
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				IntPtr intPtr = (IntPtr)Read.Single<IntPtr>(num + 16);
				IntPtr value = intPtr;
				while (intPtr != IntPtr.Zero && !SearchObjects.Stop)
				{
					int num2 = 0;
					while (num2 < 100 && !SearchObjects.Stop)
					{
						int num3 = (int)Read.Combined<int>(intPtr + num2);
						if (this.CheckContainCondition(num3))
						{
							string text = Tools.ConvertToHex(num) + " (Offsets.Cooldown_Base)";
							text = text + " -> " + Tools.ConvertToHex(num2) + " (Offsets.SpellID)";
							this.CheckAndSaveValues(num3, text);
						}
						num2++;
					}
					intPtr = (IntPtr)Read.Combined<IntPtr>(intPtr + 8);
					if (intPtr == value)
					{
						break;
					}
				}
				num++;
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00674AA4 File Offset: 0x00672CA4
		private void PlayerNames()
		{
			int num = SearchObjects.SearchFrom;
			while (num < SearchObjects.SearchRange && !SearchObjects.Stop)
			{
				SearchObjects.SearchCurrentProgressValue++;
				int num2 = (int)Read.Single<int>(Offsets.Player_NameCache + num);
				if (num2 > 0 && num2 <= 256)
				{
					int num3 = 1;
					while (num3 < 80 && !SearchObjects.Stop)
					{
						IntPtr intPtr = IntPtr.Zero;
						IntPtr[] array = null;
						try
						{
							intPtr = (IntPtr)Read.Single<IntPtr>(Offsets.Player_NameCache + num3);
							if (intPtr == IntPtr.Zero)
							{
								goto IL_201;
							}
							array = _globals.processHandleRead.Memory.Read<IntPtr>(intPtr, num2);
							if (array.Length == 0 || array.Length > 256)
							{
								goto IL_201;
							}
						}
						catch
						{
							goto IL_201;
						}
						goto IL_BC;
						IL_201:
						num3++;
						continue;
						IL_BC:
						int num4 = 0;
						while (num4 < array.Length && !SearchObjects.Stop)
						{
							IntPtr intPtr2 = array[num4];
							if (!(intPtr2 == IntPtr.Zero))
							{
								int num5 = 0;
								while (intPtr2 != IntPtr.Zero && !SearchObjects.Stop)
								{
									int num6 = 1;
									while (num6 < 80 && !SearchObjects.Stop)
									{
										try
										{
											string text = (string)Read.Combined<string>(intPtr2 + num6);
											if (text.Length <= 0 || !this.CheckContainCondition(text))
											{
												goto IL_213;
											}
											if (!((UInt128)Read.Combined<UInt128>(intPtr2 + 8) != _globals.playerGUID128))
											{
												string text2 = Tools.ConvertToHex(num) + " (PlayerFields_MaxCount)";
												text2 = text2 + " -> " + Tools.ConvertToHex(num3) + " (PlayerFields_Base)";
												text2 = text2 + " -> " + Tools.ConvertToHex(num6) + " (PlayerFields_Name)";
												text2 += " -> 0x8 (PlayerFields_GUID)";
												this.CheckAndSaveValues(text, text2);
												goto IL_213;
											}
											goto IL_213;
										}
										catch
										{
											goto IL_213;
										}
										break;
										IL_213:
										num6++;
									}
									num5++;
									if (num5 >= 100)
									{
										break;
									}
									intPtr2 = (IntPtr)Read.Combined<IntPtr>(intPtr2 + 0);
								}
							}
							num4++;
						}
						goto IL_201;
					}
				}
				num++;
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00674CEC File Offset: 0x00672EEC
		private void TestFrames()
		{
			string text = Frames.GetText("GlueDialogBackground", "GlueDialogText");
			this.SearchConsole(text, "");
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00674D18 File Offset: 0x00672F18
		private void CheckAndSaveValues(object Value = null, string Hex = "")
		{
			SearchObjects.<>c__DisplayClass55_0 CS$<>8__locals1;
			CS$<>8__locals1.Hex = Hex;
			CS$<>8__locals1.Value = Value;
			if (CS$<>8__locals1.Value != null && CS$<>8__locals1.Value != null)
			{
				bool flag = true;
				bool flag2 = true;
				if (!(SearchObjects.SearchType == "int16") && !(SearchObjects.SearchType == "short"))
				{
					if (!(SearchObjects.SearchType == "int32") && !(SearchObjects.SearchType == "int"))
					{
						if (!(SearchObjects.SearchType == "int64") && !(SearchObjects.SearchType == "long"))
						{
							if (!(SearchObjects.SearchType == "UInt128"))
							{
								if (SearchObjects.SearchType == "float")
								{
									float num;
									if (!float.TryParse(CS$<>8__locals1.Value.ToString(), out num))
									{
										return;
									}
									string text = num.ToString();
									if (text.Contains("E+") || text.Contains("E-") || text.Contains("NaN"))
									{
										return;
									}
									if (SearchObjects.IsInCompareMode)
									{
										SearchObjects.smethod_1(ref CS$<>8__locals1);
										return;
									}
									if (!this.CheckContainCondition(CS$<>8__locals1.Value))
									{
										return;
									}
									if (SearchObjects.SearchCondition1Option == "Length")
									{
										if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
										{
											flag = false;
										}
									}
									else if (SearchObjects.SearchCondition1Compare == ">" && num <= (float)SearchObjects.SearchCondition1Value)
									{
										flag = false;
									}
									else if (SearchObjects.SearchCondition1Compare == "<" && num >= (float)SearchObjects.SearchCondition1Value)
									{
										flag = false;
									}
									else if (SearchObjects.SearchCondition1Compare == "==" && (num < (float)SearchObjects.SearchCondition1Value || num > (float)SearchObjects.SearchCondition1Value))
									{
										flag = false;
									}
									if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
									{
										return;
									}
									if (SearchObjects.SearchCondition2Option == "Length")
									{
										if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
										{
											flag2 = false;
										}
									}
									else if (SearchObjects.SearchCondition2Compare == ">" && num <= (float)SearchObjects.SearchCondition2Value)
									{
										flag2 = false;
									}
									else if (SearchObjects.SearchCondition2Compare == "<" && num >= (float)SearchObjects.SearchCondition2Value)
									{
										flag2 = false;
									}
									else if (SearchObjects.SearchCondition2Compare == "==" && (num < (float)SearchObjects.SearchCondition2Value || num > (float)SearchObjects.SearchCondition2Value))
									{
										flag2 = false;
									}
									if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
									{
										return;
									}
									if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
									{
										return;
									}
								}
								else if (!(SearchObjects.SearchType == "double"))
								{
									if (SearchObjects.SearchType == "bool")
									{
										bool flag3;
										if (!bool.TryParse(CS$<>8__locals1.Value.ToString(), out flag3))
										{
											return;
										}
									}
									else if (!(SearchObjects.SearchType == "byte"))
									{
										if (SearchObjects.IsInCompareMode)
										{
											SearchObjects.smethod_1(ref CS$<>8__locals1);
											return;
										}
										if (!this.CheckContainCondition(CS$<>8__locals1.Value))
										{
											return;
										}
										if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
										{
											flag = false;
										}
										if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
										{
											return;
										}
										if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
										{
											flag2 = false;
										}
										if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
										{
											return;
										}
										if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
										{
											return;
										}
									}
									else
									{
										byte b;
										if (!byte.TryParse(CS$<>8__locals1.Value.ToString(), out b))
										{
											return;
										}
										if (SearchObjects.IsInCompareMode)
										{
											SearchObjects.smethod_1(ref CS$<>8__locals1);
											return;
										}
										if (!this.CheckContainCondition(CS$<>8__locals1.Value))
										{
											return;
										}
										if (SearchObjects.SearchCondition1Option == "Length")
										{
											if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
											{
												flag = false;
											}
										}
										else if (SearchObjects.SearchCondition1Compare == ">" && (int)b <= SearchObjects.SearchCondition1Value)
										{
											flag = false;
										}
										else if (SearchObjects.SearchCondition1Compare == "<" && (int)b >= SearchObjects.SearchCondition1Value)
										{
											flag = false;
										}
										else if (SearchObjects.SearchCondition1Compare == "==" && ((int)b < SearchObjects.SearchCondition1Value || (int)b > SearchObjects.SearchCondition1Value))
										{
											flag = false;
										}
										if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
										{
											return;
										}
										if (SearchObjects.SearchCondition2Option == "Length")
										{
											if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
											{
												flag2 = false;
											}
										}
										else if (SearchObjects.SearchCondition2Compare == ">" && (int)b <= SearchObjects.SearchCondition2Value)
										{
											flag2 = false;
										}
										else if (SearchObjects.SearchCondition2Compare == "<" && (int)b >= SearchObjects.SearchCondition2Value)
										{
											flag2 = false;
										}
										else if (SearchObjects.SearchCondition2Compare == "==" && ((int)b < SearchObjects.SearchCondition2Value || (int)b > SearchObjects.SearchCondition2Value))
										{
											flag2 = false;
										}
										if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
										{
											return;
										}
										if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
										{
											return;
										}
									}
								}
								else
								{
									double num2;
									if (!double.TryParse(CS$<>8__locals1.Value.ToString(), out num2))
									{
										return;
									}
									if (SearchObjects.IsInCompareMode)
									{
										SearchObjects.smethod_1(ref CS$<>8__locals1);
										return;
									}
									if (!this.CheckContainCondition(CS$<>8__locals1.Value))
									{
										return;
									}
									if (SearchObjects.SearchCondition1Option == "Length")
									{
										if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
										{
											flag = false;
										}
									}
									else if (SearchObjects.SearchCondition1Compare == ">" && num2 <= (double)SearchObjects.SearchCondition1Value)
									{
										flag = false;
									}
									else if (SearchObjects.SearchCondition1Compare == "<" && num2 >= (double)SearchObjects.SearchCondition1Value)
									{
										flag = false;
									}
									else if (SearchObjects.SearchCondition1Compare == "==" && (num2 < (double)SearchObjects.SearchCondition1Value || num2 > (double)SearchObjects.SearchCondition1Value))
									{
										flag = false;
									}
									if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
									{
										return;
									}
									if (!(SearchObjects.SearchCondition2Option == "Length"))
									{
										if (SearchObjects.SearchCondition2Compare == ">" && num2 <= (double)SearchObjects.SearchCondition2Value)
										{
											flag2 = false;
										}
										else if (SearchObjects.SearchCondition2Compare == "<" && num2 >= (double)SearchObjects.SearchCondition2Value)
										{
											flag2 = false;
										}
										else if (SearchObjects.SearchCondition2Compare == "==" && (num2 < (double)SearchObjects.SearchCondition2Value || num2 > (double)SearchObjects.SearchCondition2Value))
										{
											flag2 = false;
										}
									}
									else if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
									{
										flag2 = false;
									}
									if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
									{
										return;
									}
									if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
									{
										return;
									}
								}
							}
							else
							{
								UInt128 a;
								if (!UInt128.TryParse(CS$<>8__locals1.Value.ToString(), out a))
								{
									return;
								}
								if (SearchObjects.IsInCompareMode)
								{
									SearchObjects.smethod_1(ref CS$<>8__locals1);
									return;
								}
								if (!this.CheckContainCondition(CS$<>8__locals1.Value))
								{
									return;
								}
								if (SearchObjects.SearchCondition1Option == "Length")
								{
									if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
									{
										flag = false;
									}
								}
								else if (SearchObjects.SearchCondition1Compare == ">" && a <= SearchObjects.SearchCondition1Value)
								{
									flag = false;
								}
								else if (SearchObjects.SearchCondition1Compare == "<" && a >= SearchObjects.SearchCondition1Value)
								{
									flag = false;
								}
								else if (SearchObjects.SearchCondition1Compare == "==" && (a < SearchObjects.SearchCondition1Value || a > SearchObjects.SearchCondition1Value))
								{
									flag = false;
								}
								if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
								{
									return;
								}
								if (SearchObjects.SearchCondition2Option == "Length")
								{
									if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
									{
										flag2 = false;
									}
								}
								else if (SearchObjects.SearchCondition2Compare == ">" && a <= SearchObjects.SearchCondition2Value)
								{
									flag2 = false;
								}
								else if (SearchObjects.SearchCondition2Compare == "<" && a >= SearchObjects.SearchCondition2Value)
								{
									flag2 = false;
								}
								else if (SearchObjects.SearchCondition2Compare == "==" && (a < SearchObjects.SearchCondition2Value || a > SearchObjects.SearchCondition2Value))
								{
									flag2 = false;
								}
								if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
								{
									return;
								}
								if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
								{
									return;
								}
							}
						}
						else
						{
							long num3;
							if (!long.TryParse(CS$<>8__locals1.Value.ToString(), out num3))
							{
								return;
							}
							if (SearchObjects.IsInCompareMode)
							{
								SearchObjects.smethod_1(ref CS$<>8__locals1);
								return;
							}
							if (!this.CheckContainCondition(CS$<>8__locals1.Value))
							{
								return;
							}
							if (!(SearchObjects.SearchCondition1Option == "Length"))
							{
								if (SearchObjects.SearchCondition1Compare == ">" && num3 <= (long)SearchObjects.SearchCondition1Value)
								{
									flag = false;
								}
								else if (SearchObjects.SearchCondition1Compare == "<" && num3 >= (long)SearchObjects.SearchCondition1Value)
								{
									flag = false;
								}
								else if (SearchObjects.SearchCondition1Compare == "==" && (num3 < (long)SearchObjects.SearchCondition1Value || num3 > (long)SearchObjects.SearchCondition1Value))
								{
									flag = false;
								}
							}
							else if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
							{
								flag = false;
							}
							if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
							{
								return;
							}
							if (SearchObjects.SearchCondition2Option == "Length")
							{
								if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
								{
									flag2 = false;
								}
							}
							else if (SearchObjects.SearchCondition2Compare == ">" && num3 <= (long)SearchObjects.SearchCondition2Value)
							{
								flag2 = false;
							}
							else if (SearchObjects.SearchCondition2Compare == "<" && num3 >= (long)SearchObjects.SearchCondition2Value)
							{
								flag2 = false;
							}
							else if (SearchObjects.SearchCondition2Compare == "==" && (num3 < (long)SearchObjects.SearchCondition2Value || num3 > (long)SearchObjects.SearchCondition2Value))
							{
								flag2 = false;
							}
							if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
							{
								return;
							}
							if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
							{
								return;
							}
						}
					}
					else
					{
						int num4;
						if (!int.TryParse(CS$<>8__locals1.Value.ToString(), out num4))
						{
							return;
						}
						if (SearchObjects.IsInCompareMode)
						{
							SearchObjects.smethod_1(ref CS$<>8__locals1);
							return;
						}
						if (!this.CheckContainCondition(CS$<>8__locals1.Value))
						{
							return;
						}
						if (SearchObjects.SearchCondition1Option == "Length")
						{
							if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
							{
								flag = false;
							}
						}
						else if (SearchObjects.SearchCondition1Compare == ">" && num4 <= SearchObjects.SearchCondition1Value)
						{
							flag = false;
						}
						else if (SearchObjects.SearchCondition1Compare == "<" && num4 >= SearchObjects.SearchCondition1Value)
						{
							flag = false;
						}
						else if (SearchObjects.SearchCondition1Compare == "==" && (num4 < SearchObjects.SearchCondition1Value || num4 > SearchObjects.SearchCondition1Value))
						{
							flag = false;
						}
						if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
						{
							return;
						}
						if (!(SearchObjects.SearchCondition2Option == "Length"))
						{
							if (SearchObjects.SearchCondition2Compare == ">" && num4 <= SearchObjects.SearchCondition2Value)
							{
								flag2 = false;
							}
							else if (SearchObjects.SearchCondition2Compare == "<" && num4 >= SearchObjects.SearchCondition2Value)
							{
								flag2 = false;
							}
							else if (SearchObjects.SearchCondition2Compare == "==" && (num4 < SearchObjects.SearchCondition2Value || num4 > SearchObjects.SearchCondition2Value))
							{
								flag2 = false;
							}
						}
						else if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
						{
							flag2 = false;
						}
						if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
						{
							return;
						}
						if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
						{
							return;
						}
					}
				}
				else
				{
					short num5;
					if (!short.TryParse(CS$<>8__locals1.Value.ToString(), out num5))
					{
						return;
					}
					if (SearchObjects.IsInCompareMode)
					{
						SearchObjects.smethod_1(ref CS$<>8__locals1);
						return;
					}
					if (!this.CheckContainCondition(CS$<>8__locals1.Value))
					{
						return;
					}
					if (!(SearchObjects.SearchCondition1Option == "Length"))
					{
						if (SearchObjects.SearchCondition1Compare == ">" && (int)num5 <= SearchObjects.SearchCondition1Value)
						{
							flag = false;
						}
						else if (SearchObjects.SearchCondition1Compare == "<" && (int)num5 >= SearchObjects.SearchCondition1Value)
						{
							flag = false;
						}
						else if (SearchObjects.SearchCondition1Compare == "==" && ((int)num5 < SearchObjects.SearchCondition1Value || (int)num5 > SearchObjects.SearchCondition1Value))
						{
							flag = false;
						}
					}
					else if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 1))
					{
						flag = false;
					}
					if (!flag && (SearchObjects.SearchConditionAndOr == "No add. Condition" || SearchObjects.SearchConditionAndOr == "AND"))
					{
						return;
					}
					if (SearchObjects.SearchCondition2Option == "Length")
					{
						if (!this.CheckLengthConditions(CS$<>8__locals1.Value, 2))
						{
							flag2 = false;
						}
					}
					else if (SearchObjects.SearchCondition2Compare == ">" && (int)num5 <= SearchObjects.SearchCondition2Value)
					{
						flag2 = false;
					}
					else if (SearchObjects.SearchCondition2Compare == "<" && (int)num5 >= SearchObjects.SearchCondition2Value)
					{
						flag2 = false;
					}
					else if (SearchObjects.SearchCondition2Compare == "==" && ((int)num5 < SearchObjects.SearchCondition2Value || (int)num5 > SearchObjects.SearchCondition2Value))
					{
						flag2 = false;
					}
					if (SearchObjects.SearchConditionAndOr == "AND" && !flag2)
					{
						return;
					}
					if (SearchObjects.SearchConditionAndOr == "OR" && !flag && !flag2)
					{
						return;
					}
				}
				SearchObjects.smethod_1(ref CS$<>8__locals1);
				return;
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00675A98 File Offset: 0x00673C98
		private bool CheckLengthConditions(object Value, int WhichCondition)
		{
			string a = "";
			int num = 0;
			if (WhichCondition == 1)
			{
				a = SearchObjects.SearchCondition1Compare;
				num = SearchObjects.SearchCondition1Value;
			}
			else if (WhichCondition == 2)
			{
				a = SearchObjects.SearchCondition2Compare;
				num = SearchObjects.SearchCondition2Value;
			}
			int length = Value.ToString().Length;
			return (!(a == ">") || length > num) && (!(a == "<") || length < num) && (!(a == "==") || (length >= num && length <= num));
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00675B1C File Offset: 0x00673D1C
		private bool CheckContainCondition(object Value)
		{
			if (SearchObjects.SearchContain.Count == 0)
			{
				return true;
			}
			string text = Value.ToString();
			if (SearchObjects.SearchContainOption == "Contain")
			{
				using (List<string>.Enumerator enumerator = SearchObjects.SearchContain.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text2 = enumerator.Current;
						if (text.ToLower().Contains(text2.ToLower()))
						{
							return true;
						}
					}
					return false;
				}
			}
			if (SearchObjects.SearchContainOption == "Starts with")
			{
				using (List<string>.Enumerator enumerator = SearchObjects.SearchContain.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text3 = enumerator.Current;
						if (text.ToLower().StartsWith(text3.ToLower()))
						{
							return true;
						}
					}
					return false;
				}
			}
			if (!(SearchObjects.SearchContainOption == "Exact"))
			{
				return false;
			}
			using (List<string>.Enumerator enumerator = SearchObjects.SearchContain.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == text)
					{
						return true;
					}
				}
				return false;
			}
			bool result;
			return result;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00675E08 File Offset: 0x00674008
		[CompilerGenerated]
		internal static void smethod_0()
		{
			Tools.Control("", "btnSearchCheck", "frmTeam", false, false, false, false, 0);
			Tools.Control("", "btnSearchReset", "frmTeam", false, false, false, false, 0);
			Tools.Control("", "btnSearchStop", "frmTeam", true, false, false, false, 0);
			Tools.SetProgress("frmTeam", "progressSearch", SearchObjects.SearchMaxProgressValue, true, "0%");
			Tools.ControlVisible("progressSearch", "frmTeam", true);
			while (!SearchObjects.Stop && !SearchObjects.Complete)
			{
				string text = JackMath.CalcToPercent(SearchObjects.SearchCurrentProgressValue, SearchObjects.SearchMaxProgressValue).ToString("0") + "%";
				if (!SearchObjects.IsCustomSearch)
				{
					text = text + " (Results: " + SearchObjects.SearchProgressResultsCount.ToString() + ")";
				}
				else
				{
					text += " (Custom)";
				}
				Tools.SetProgress("frmTeam", "progressSearch", SearchObjects.SearchCurrentProgressValue, false, text);
				Thread.Sleep(1000);
			}
			Tools.ControlVisible("progressSearch", "frmTeam", false);
			Tools.Control("", "btnSearchCheck", "frmTeam", true, false, false, false, 0);
			Tools.Control("", "btnSearchReset", "frmTeam", true, false, false, false, 0);
			Tools.Control("", "btnSearchStop", "frmTeam", false, false, false, false, 0);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00675F78 File Offset: 0x00674178
		[CompilerGenerated]
		internal static void smethod_1(ref SearchObjects.<>c__DisplayClass55_0 <>c__DisplayClass55_0_0)
		{
			if (!SearchObjects.IsInCompareMode)
			{
				if (!SearchObjects.ValuesList.ContainsKey(<>c__DisplayClass55_0_0.Hex))
				{
					SearchObjects.ValuesList.Add(<>c__DisplayClass55_0_0.Hex, <>c__DisplayClass55_0_0.Value.ToString());
				}
			}
			else if (!SearchObjects.CompareList.ContainsKey(<>c__DisplayClass55_0_0.Hex))
			{
				SearchObjects.CompareList.Add(<>c__DisplayClass55_0_0.Hex, <>c__DisplayClass55_0_0.Value.ToString());
			}
			SearchObjects.SearchProgressResultsCount++;
			if (SearchObjects.SearchStopWhenFound)
			{
				SearchObjects.Stop = true;
			}
		}

		// Token: 0x040000CC RID: 204
		public static string SearchFor = "";

		// Token: 0x040000CD RID: 205
		public static int SearchFrom = 0;

		// Token: 0x040000CE RID: 206
		public static int SearchRange = 0;

		// Token: 0x040000CF RID: 207
		public static string SearchType = "";

		// Token: 0x040000D0 RID: 208
		public static string SearchAddress = "";

		// Token: 0x040000D1 RID: 209
		public static IntPtr SearchAddressBase = IntPtr.Zero;

		// Token: 0x040000D2 RID: 210
		public static string SearchCondition1Option = "";

		// Token: 0x040000D3 RID: 211
		public static string SearchCondition1Compare = "";

		// Token: 0x040000D4 RID: 212
		public static int SearchCondition1Value = 0;

		// Token: 0x040000D5 RID: 213
		public static string SearchConditionAndOr = "";

		// Token: 0x040000D6 RID: 214
		public static string SearchCondition2Option = "";

		// Token: 0x040000D7 RID: 215
		public static string SearchCondition2Compare = "";

		// Token: 0x040000D8 RID: 216
		public static int SearchCondition2Value = 0;

		// Token: 0x040000D9 RID: 217
		public static string SearchContainOption = "";

		// Token: 0x040000DA RID: 218
		public static List<string> SearchContain = new List<string>();

		// Token: 0x040000DB RID: 219
		public static string SearchCompareMode = "";

		// Token: 0x040000DC RID: 220
		private static bool IsInCompareMode = false;

		// Token: 0x040000DD RID: 221
		public static bool SearchStopWhenFound = false;

		// Token: 0x040000DE RID: 222
		public static bool IsCustomSearch = false;

		// Token: 0x040000DF RID: 223
		public static int SearchCurrentProgressValue = 0;

		// Token: 0x040000E0 RID: 224
		public static int SearchMaxProgressValue = 0;

		// Token: 0x040000E1 RID: 225
		public static int SearchProgressResultsCount = 0;

		// Token: 0x040000E2 RID: 226
		private static Dictionary<string, string> ValuesList = new Dictionary<string, string>();

		// Token: 0x040000E3 RID: 227
		private static Dictionary<string, string> CompareList = new Dictionary<string, string>();

		// Token: 0x040000E4 RID: 228
		public static bool Stop = false;

		// Token: 0x040000E5 RID: 229
		private static bool Complete = false;

		// Token: 0x040000E6 RID: 230
		public static bool Running = false;
	}
}
