using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Jack.Core
{
	// Token: 0x0200012D RID: 301
	public class OffsetsManager
	{
		// Token: 0x06001AA4 RID: 6820 RVA: 0x0072BAB8 File Offset: 0x00729CB8
		public static void Set(string Game)
		{
			string text = "";
			string text2 = "";
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
			if (Game == "Classic")
			{
				text = _globals.LCS.d100;
				text2 = _globals.LCS.d101;
			}
			else if (Game == "ClassicPrevious")
			{
				text = _globals.LCS.d103;
				text2 = _globals.LCS.d104;
			}
			else if (!(Game == "ClassicPTR"))
			{
				if (!(Game == "ClassicPTRPrevious"))
				{
					if (!(Game == "ClassicEra"))
					{
						if (!(Game == "ClassicEraPrevious"))
						{
							if (!(Game == "ClassicEraPTR"))
							{
								if (Game == "ClassicEraPTRPrevious")
								{
									text = _globals.LCS.d403;
									text2 = _globals.LCS.d404;
								}
								else if (!(Game == "Retail"))
								{
									if (Game == "RetailPrevious")
									{
										text = _globals.LCS.d503;
										text2 = _globals.LCS.d504;
									}
									else if (!(Game == "RetailPTR"))
									{
										if (Game == "RetailPTRPrevious")
										{
											text = _globals.LCS.d603;
											text2 = _globals.LCS.d604;
										}
										else if (_globals.IsTeam && Game == "Custom")
										{
											string text3 = _globals.JackData + "\\cos";
											if (File.Exists(_globals.JackData + "\\cosAlways.jk"))
											{
												text3 += "Always";
											}
											text3 += ".jk";
											string text4 = File.ReadAllText(text3);
											if (!text4.Contains("|#|") || !text4.Contains(":") || !text4.Contains(";"))
											{
												Tools.Console("Couldn't load COS file (1).", "Red", "richConsole", "frmMain", true);
												return;
											}
											string[] array = Regex.Split(text4, "\\|\\#\\|");
											if (array.Count<string>() != 2)
											{
												Tools.Console("Couldn't load COS file (2).", "Red", "richConsole", "frmMain", true);
												return;
											}
											text = OffsetsManager.PrepareCOS(array[0]);
											text2 = OffsetsManager.PrepareCOS(array[1]);
										}
									}
									else
									{
										text = _globals.LCS.d600;
										text2 = _globals.LCS.d601;
									}
								}
								else
								{
									text = _globals.LCS.d500;
									text2 = _globals.LCS.d501;
								}
							}
							else
							{
								text = _globals.LCS.d400;
								text2 = _globals.LCS.d401;
							}
						}
						else
						{
							text = _globals.LCS.d303;
							text2 = _globals.LCS.d304;
						}
					}
					else
					{
						text = _globals.LCS.d300;
						text2 = _globals.LCS.d301;
					}
				}
				else
				{
					text = _globals.LCS.d203;
					text2 = _globals.LCS.d204;
				}
			}
			else
			{
				text = _globals.LCS.d200;
				text2 = _globals.LCS.d201;
			}
			if (text.Length > 0 && text2.Length > 0)
			{
				if (text.Contains(";") && text2.Contains(";"))
				{
					dictionary = OffsetsManager.Split(text);
					dictionary2 = OffsetsManager.Split(text2);
				}
				if (dictionary.Count > 0)
				{
					Offsets offsets = new Offsets();
					foreach (PropertyInfo propertyInfo in offsets.GetType().GetProperties())
					{
						if (dictionary.ContainsKey(propertyInfo.Name))
						{
							propertyInfo.SetValue(offsets, dictionary[propertyInfo.Name]);
						}
					}
					Descriptors descriptors = new Descriptors();
					foreach (PropertyInfo propertyInfo2 in descriptors.GetType().GetProperties())
					{
						if (dictionary2.ContainsKey(propertyInfo2.Name))
						{
							propertyInfo2.SetValue(descriptors, dictionary2[propertyInfo2.Name]);
						}
					}
					if (_globals.IsTeam && Game == "Custom")
					{
						Tools.Console("Custom Offsets loaded.", "Green", "richConsole", "frmMain", true);
					}
				}
			}
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0072BEE4 File Offset: 0x0072A0E4
		private static Dictionary<string, int> Split(string Data)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			foreach (string text in Data.Split(new char[]
			{
				';'
			}))
			{
				if (text.Contains(":"))
				{
					string[] array2 = text.Split(new char[]
					{
						':'
					});
					string key = array2[0];
					string text2 = array2[1];
					int value;
					if (!text2.Contains("+"))
					{
						if (text2.Contains("-"))
						{
							string[] array3 = text2.Split(new char[]
							{
								'-'
							});
							if (!array3[1].StartsWith("0x"))
							{
								value = Convert.ToInt32(array3[0], 16) - Convert.ToInt32(array3[1]);
							}
							else
							{
								value = Convert.ToInt32(array3[0], 16) - Convert.ToInt32(array3[1], 16);
							}
						}
						else if (text2.Contains("*"))
						{
							string[] array4 = text2.Split(new char[]
							{
								'*'
							});
							if (!array4[1].StartsWith("0x"))
							{
								value = Convert.ToInt32(array4[0], 16) * Convert.ToInt32(array4[1]);
							}
							else
							{
								value = Convert.ToInt32(array4[0], 16) * Convert.ToInt32(array4[1], 16);
							}
						}
						else
						{
							value = Convert.ToInt32(text2, 16);
						}
					}
					else
					{
						string[] array5 = text2.Split(new char[]
						{
							'+'
						});
						if (array5[1].StartsWith("0x"))
						{
							value = Convert.ToInt32(array5[0], 16) + Convert.ToInt32(array5[1], 16);
						}
						else
						{
							value = Convert.ToInt32(array5[0], 16) + Convert.ToInt32(array5[1]);
						}
					}
					dictionary.Add(key, value);
				}
			}
			return dictionary;
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0072C0A0 File Offset: 0x0072A2A0
		private static string PrepareCOS(string COS)
		{
			StringBuilder stringBuilder = new StringBuilder();
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			COS = COS.Replace("\t", "");
			foreach (string text in COS.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None))
			{
				if (text.Contains("public static int") && !text.StartsWith("//"))
				{
					string text2 = Tools.GetBetween(text, "int ", " {");
					if (text2.Length != 0)
					{
						string text3 = Tools.GetBetween(text, "= ", ";");
						if (text3.Length != 0)
						{
							text2 = text2.Trim();
							text3 = text3.Trim();
							string text4 = "";
							if (text3.Contains("-"))
							{
								text4 = "-";
							}
							else if (!text3.Contains("+"))
							{
								if (!text3.Contains("*"))
								{
									if (text3.Contains("_"))
									{
										text3 = "0x" + dictionary[text3].ToString("X");
									}
								}
								else
								{
									text4 = "*";
								}
							}
							else
							{
								text4 = "+";
							}
							if (text4.Length > 0)
							{
								string[] array2 = text3.Split(new char[]
								{
									char.Parse(text4)
								});
								string text5 = array2[0].Trim();
								string text6 = array2[1].Trim();
								if (!text6.StartsWith("0x"))
								{
									text6 = "0x" + text6;
								}
								int num = Convert.ToInt32(text6, 16);
								int num2;
								if (text5.StartsWith("0x"))
								{
									num2 = Convert.ToInt32(text5, 16);
								}
								else
								{
									num2 = dictionary[text5];
								}
								if (text4 == "-")
								{
									text3 = "0x" + (num2 - num).ToString("X");
								}
								else if (!(text4 == "+"))
								{
									if (text4 == "*")
									{
										text3 = "0x" + (num2 * num).ToString("X");
									}
								}
								else
								{
									text3 = "0x" + (num2 + num).ToString("X");
								}
							}
							if (!text3.StartsWith("0x"))
							{
								text3 = text3 + "0x" + text3;
							}
							if (stringBuilder.Length > 0)
							{
								stringBuilder.Append(";");
							}
							dictionary.Add(text2, Convert.ToInt32(text3, 16));
							stringBuilder.Append(text2 + ":" + text3);
						}
					}
				}
			}
			return stringBuilder.ToString();
		}
	}
}
