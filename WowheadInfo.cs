using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MyU9Ep58ZH3s5ThDFJQ;
using PeanutButter.INI;
using XR7RtrxI8Vm7Dgx9BKr;

namespace RotationLabEngine
{
	// Token: 0x02000049 RID: 73
	public class WowheadInfo
	{
		// Token: 0x06000755 RID: 1877 RVA: 0x0003A810 File Offset: 0x00038A10
		private string anYckZAQ6x(string \u0020)
		{
			int num = 3;
			int num2 = num;
			Match match;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					goto IL_EF;
				case 2:
					if (WowheadInfo.jjmpjSfwpmauPqlNsi8(match).Count >= 1)
					{
						goto IL_A6;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6112394f91444b1a8348d0503b4f813b != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					match = new Regex(WowheadInfo.OHYsyrf985vKpdhYPSk(-87166655 + -2142521002 ^ 2065300541)).Match(\u0020);
					num2 = 2;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_5e42540a7e2247379e20536f2877b437 == 0)
					{
						num2 = 1;
						continue;
					}
					continue;
				}
				this.WriteLog(WowheadInfo.OHYsyrf985vKpdhYPSk(2040894867 + -686633457 ^ 1354249560));
				num2 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f9e98f6a964b4abbaedd241bdefc81fd == 0)
				{
					num2 = 0;
				}
			}
			IL_A6:
			return WowheadInfo.KUG0WXfhJAVImhtrkc3(WowheadInfo.mYTksVfAmEZMdoaKWQy(match.Groups, 1));
			IL_EF:
			return "";
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0003A914 File Offset: 0x00038B14
		private string FV3crnVvVs(string \u0020)
		{
			Match match = WowheadInfo.ctlNfkfS9LB6IqQ6gK4(new Regex(WowheadInfo.OHYsyrf985vKpdhYPSk(-258475567 << 4 ^ 159369772)), \u0020);
			int num;
			if (WowheadInfo.QAMLt9fIAoG9c89dylp(WowheadInfo.jjmpjSfwpmauPqlNsi8(match)) >= 1)
			{
				num = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_2450e204911e419ba8c7c2ba4ba001f5 != 0)
				{
					num = 1;
				}
			}
			else
			{
				this.WriteLog(WowheadInfo.OHYsyrf985vKpdhYPSk(-1734223699 - -1503209248 ^ -231036971));
				num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a65af4741e8c4e4da9b36e623cb150b3 != 0)
				{
					num = 0;
				}
			}
			switch (num)
			{
			case 1:
				return WowheadInfo.jCJxrNfijextdGIuuKa(WowheadInfo.KUG0WXfhJAVImhtrkc3(WowheadInfo.mYTksVfAmEZMdoaKWQy(WowheadInfo.jjmpjSfwpmauPqlNsi8(match), 1)), WowheadInfo.OHYsyrf985vKpdhYPSk(-506871478 - 1486829658 ^ -1993678986), WowheadInfo.OHYsyrf985vKpdhYPSk(-1199763274 ^ -1199749296));
			}
			return "";
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0003AA10 File Offset: 0x00038C10
		private bool j4mc7xmk3q(string \u0020, string \u0020)
		{
			int num = 3;
			int num2 = num;
			bool result;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					return result;
				case 2:
					if (WowheadInfo.PnekEhfUpLG4dh7jfAx(\u0020))
					{
						num2 = 4;
						continue;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f3698823c3c74819a0d3976ddbed89ba == 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				case 3:
					if (WowheadInfo.shfy5ufZ9Iio0OZLjYZ(\u0020, ""))
					{
						return false;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_fa027ca03d194169b4d4b16c724923ba != 0)
					{
						num2 = 2;
						continue;
					}
					continue;
				case 4:
					return true;
				}
				break;
			}
			try
			{
				Directory.CreateDirectory(this.IconPath);
				this.WriteLog(WowheadInfo.xC3QSgf1sj8VU0DAb5f(vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-789513950 ^ -789536402), \u0020));
				int num3 = 3;
				for (;;)
				{
					switch (num3)
					{
					default:
						try
						{
							WebClient webClient;
							webClient.DownloadFile(\u0020, \u0020);
						}
						finally
						{
							WebClient webClient;
							if (webClient != null)
							{
								int num4 = 0;
								if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								default:
									WowheadInfo.DdatBnfp29QNXhYskWL(webClient);
									break;
								}
							}
						}
						break;
					case 1:
						goto IL_196;
					case 2:
						break;
					case 3:
					{
						WebClient webClient = new WebClient();
						num3 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_60948d6233084caaad2cec2725ac87ec == 0)
						{
							num3 = 0;
							continue;
						}
						continue;
					}
					}
					result = true;
					num3 = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e0aba0d9fb124085a8bd5fdd21baeb5d != 0)
					{
						num3 = 1;
					}
				}
				IL_196:;
			}
			catch (Exception ex)
			{
				int num5 = 1;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_1ae970e9678b41e298250f643c4313e8 == 0)
				{
					num5 = 0;
				}
				for (;;)
				{
					switch (num5)
					{
					case 1:
						this.WriteLog(WowheadInfo.G5EBpWf4kcWRpaBl4VD(ex));
						result = false;
						num5 = 0;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f33e632e358f4933afb605f58e8b0859 == 0)
						{
							num5 = 0;
							continue;
						}
						continue;
					}
					break;
				}
			}
			return result;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0003AC58 File Offset: 0x00038E58
		[return: TupleElementNames(new string[]
		{
			"itemName",
			"iconPath"
		})]
		public Task<ValueTuple<string, string>> GetItemInfo(int itemId, int locale, bool isClassic, bool isWrath)
		{
			WowheadInfo.<GetItemInfo>d__9 <GetItemInfo>d__;
			<GetItemInfo>d__.<>t__builder = AsyncTaskMethodBuilder<ValueTuple<string, string>>.Create();
			<GetItemInfo>d__.<>4__this = this;
			<GetItemInfo>d__.itemId = itemId;
			<GetItemInfo>d__.locale = locale;
			<GetItemInfo>d__.isClassic = isClassic;
			<GetItemInfo>d__.isWrath = isWrath;
			<GetItemInfo>d__.<>1__state = -1;
			<GetItemInfo>d__.<>t__builder.Start<WowheadInfo.<GetItemInfo>d__9>(ref <GetItemInfo>d__);
			return <GetItemInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0003ACC4 File Offset: 0x00038EC4
		[return: TupleElementNames(new string[]
		{
			"spellName",
			"iconPath"
		})]
		public Task<ValueTuple<string, string>> GetSpellInfo(int spellId, int locale, bool isClassic, bool isWrath)
		{
			WowheadInfo.<GetSpellInfo>d__10 <GetSpellInfo>d__;
			<GetSpellInfo>d__.<>t__builder = AsyncTaskMethodBuilder<ValueTuple<string, string>>.Create();
			<GetSpellInfo>d__.<>4__this = this;
			<GetSpellInfo>d__.spellId = spellId;
			<GetSpellInfo>d__.locale = locale;
			<GetSpellInfo>d__.isClassic = isClassic;
			<GetSpellInfo>d__.isWrath = isWrath;
			<GetSpellInfo>d__.<>1__state = -1;
			<GetSpellInfo>d__.<>t__builder.Start<WowheadInfo.<GetSpellInfo>d__10>(ref <GetSpellInfo>d__);
			return <GetSpellInfo>d__.<>t__builder.Task;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0003AD30 File Offset: 0x00038F30
		private Task X4Tc2BPORr()
		{
			WowheadInfo.<PutTaskDelay>d__11 <PutTaskDelay>d__;
			<PutTaskDelay>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<PutTaskDelay>d__.<>1__state = -1;
			int num = 1;
			if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_84a9e919b9fe4f039ce072ff9fa8ab32 == 0)
			{
				num = 1;
			}
			for (;;)
			{
				switch (num)
				{
				case 1:
					<PutTaskDelay>d__.<>t__builder.Start<WowheadInfo.<PutTaskDelay>d__11>(ref <PutTaskDelay>d__);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_cd978457d1e445849b2a5ed79e10da71 == 0)
					{
						num = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return <PutTaskDelay>d__.<>t__builder.Task;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0003ADC8 File Offset: 0x00038FC8
		private Task<string> truc6jaE94(string \u0020)
		{
			WowheadInfo.<GetWowHeadURL>d__12 <GetWowHeadURL>d__;
			<GetWowHeadURL>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetWowHeadURL>d__.<>4__this = this;
			<GetWowHeadURL>d__.url = \u0020;
			<GetWowHeadURL>d__.<>1__state = -1;
			<GetWowHeadURL>d__.<>t__builder.Start<WowheadInfo.<GetWowHeadURL>d__12>(ref <GetWowHeadURL>d__);
			return <GetWowHeadURL>d__.<>t__builder.Task;
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0003AE1C File Offset: 0x0003901C
		private string vbFcNx4ZqH(int \u0020, int \u0020, int \u0020, bool \u0020, bool \u0020)
		{
			int num = 20;
			string text;
			for (;;)
			{
				int num2 = num;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_172;
					case 1:
						goto IL_273;
					case 2:
						IL_D8:
						if (\u0020 == 1)
						{
							num2 = 3;
							continue;
						}
						goto IL_32D;
					case 3:
						text += vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1352111144 ^ -1352125734);
						num2 = 6;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_78ab67cec1824b2289ca2a9b24f27de2 == 0)
						{
							num2 = 18;
							continue;
						}
						continue;
					case 4:
						break;
					case 5:
						break;
					case 6:
						goto IL_1F1;
					case 7:
						goto IL_347;
					case 8:
						text = WowheadInfo.xC3QSgf1sj8VU0DAb5f(text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-535478164 ^ -535488310));
						num2 = 13;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_f4a460e528dc4f8f9f02849e498e6a35 == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					case 9:
						goto IL_124;
					case 10:
						goto IL_32D;
					case 11:
						return text;
					case 12:
						goto IL_9B;
					case 13:
						goto IL_372;
					case 14:
						goto IL_372;
					case 15:
						goto IL_273;
					case 16:
						if (WowheadInfo.hnn6SKfOZdP3Bg8qTdN(this.WowHeadHost[\u0020], ""))
						{
							goto IL_347;
						}
						break;
					case 17:
						text += WowheadInfo.OHYsyrf985vKpdhYPSk(-2018852357 ^ -2018862839);
						num2 = 3;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_57b2e386d0354e0b85dd8e8db78e6c05 == 0)
						{
							num2 = 10;
							continue;
						}
						continue;
					case 18:
						goto IL_32D;
					case 19:
						if (!\u0020)
						{
							num2 = 15;
							continue;
						}
						goto IL_172;
					case 20:
						text = WowheadInfo.OHYsyrf985vKpdhYPSk(-1406908615 ^ 676245432 ^ -2073382673);
						num2 = 19;
						if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_337ad221e95e4d7f9f7c49af16666ee6 == 0)
						{
							num2 = 16;
							continue;
						}
						continue;
					default:
						goto IL_172;
					}
					IL_1B3:
					if (\u0020 == 0)
					{
						num2 = 17;
						continue;
					}
					goto IL_D8;
					IL_9B:
					text = WowheadInfo.xC3QSgf1sj8VU0DAb5f(text, vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1810931007 ^ 1810941417));
					goto IL_1B3;
					IL_124:
					if (!(this.WowHeadHost[\u0020] != ""))
					{
						goto IL_9B;
					}
					text = WowheadInfo.cTTR86ffiuMECV6UEPR(text, this.WowHeadHost[\u0020], vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1307524010 ^ -1307509782));
					num2 = 12;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 == 0)
					{
						num2 = 8;
						continue;
					}
					continue;
					IL_273:
					if (!\u0020)
					{
						goto IL_124;
					}
					num2 = 8;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_e1a603e3ded74e569c1ef8e445f3828e != 0)
					{
						num2 = 4;
						continue;
					}
					continue;
					IL_1F1:
					text = WowheadInfo.cTTR86ffiuMECV6UEPR(text, this.WowHeadHost[\u0020], vua32v5yjQhjRjK4YIO.BRA5TcZvlv(881693030 + 414722879 ^ 1296401177));
					num2 = 14;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6b44d6635c594e2d8eb32a8d702c09e9 == 0)
					{
						num2 = 11;
						continue;
					}
					continue;
					IL_172:
					if (!WowheadInfo.hnn6SKfOZdP3Bg8qTdN(this.WowHeadHost[\u0020], ""))
					{
						break;
					}
					goto IL_1F1;
					IL_32D:
					text += \u0020.ToString();
					num2 = 11;
					continue;
					IL_347:
					text = text + this.WowHeadHost[\u0020] + WowheadInfo.OHYsyrf985vKpdhYPSk(-886904286 ^ -886909442);
					num2 = 4;
					continue;
					IL_372:
					text = WowheadInfo.xC3QSgf1sj8VU0DAb5f(text, WowheadInfo.OHYsyrf985vKpdhYPSk(-1746511494 ^ -1746533896));
					num2 = 5;
				}
				num = 13;
			}
			return text;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0003B1C0 File Offset: 0x000393C0
		public WowheadInfo()
		{
			WowheadInfo.IZtBVdfFuOiaWtIjc0d();
			WowheadInfo.kJsUlZfTYPZ0EJyAidp();
			this.WowHeadHost = new string[]
			{
				"",
				WowheadInfo.OHYsyrf985vKpdhYPSk(2090212177 ^ 2090222145),
				WowheadInfo.OHYsyrf985vKpdhYPSk(-940667910 + -206218605 ^ -1146896491),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-825446221 ^ -825431661),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(950853533 >> 3 ^ 118866651),
				WowheadInfo.OHYsyrf985vKpdhYPSk(-940667910 + -206218605 ^ -1146896451),
				WowheadInfo.OHYsyrf985vKpdhYPSk(2090212177 ^ 2090222185),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1199763274 ^ -1199748618),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1810931007 ^ 1810941047)
			};
			this.Sections = new string[]
			{
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-1002815721 ^ -877302260 ^ 261032011),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(950853533 >> 3 ^ 118866659),
				WowheadInfo.OHYsyrf985vKpdhYPSk(289037427 >> 1 ^ 144537377),
				WowheadInfo.OHYsyrf985vKpdhYPSk(-613886095 << 1 ^ -1227753534),
				WowheadInfo.OHYsyrf985vKpdhYPSk(-831735385 ^ -831725425),
				WowheadInfo.OHYsyrf985vKpdhYPSk(-825446221 ^ -825431677),
				WowheadInfo.OHYsyrf985vKpdhYPSk(1691472209 >> 1 ^ 845722000),
				vua32v5yjQhjRjK4YIO.BRA5TcZvlv(1765342390 ^ 1765320182),
				WowheadInfo.OHYsyrf985vKpdhYPSk(--1016420359 ^ 1016398159)
			};
			base..ctor();
			int num = 4;
			for (;;)
			{
				switch (num)
				{
				default:
					this.Spellini.DefaultEncoding = Encoding.UTF8;
					num = 1;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_01d314db732841fc934f41441894a8f2 != 0)
					{
						num = 1;
					}
					break;
				case 1:
					this.IconPath = WowheadInfo.GKFoD3faqVQkDcvH2Jo(WowheadInfo.aLtkLMflTRaHFuEwmvW(WowheadInfo.pYDxFLfRGQLsG89KrfF().Location), vua32v5yjQhjRjK4YIO.BRA5TcZvlv(-613886095 << 1 ^ -1227773196));
					num = 2;
					break;
				case 2:
					return;
				case 3:
					this.Spellini = new INIFile(Path.Combine(WowheadInfo.aLtkLMflTRaHFuEwmvW(WowheadInfo.P5j6jXfLGNSsrjgnZhh(Assembly.GetExecutingAssembly())), WowheadInfo.OHYsyrf985vKpdhYPSk(-1505789866 ^ -1505812168)));
					num = 5;
					break;
				case 4:
					this.Itemini = new INIFile(WowheadInfo.GKFoD3faqVQkDcvH2Jo(WowheadInfo.aLtkLMflTRaHFuEwmvW(WowheadInfo.P5j6jXfLGNSsrjgnZhh(WowheadInfo.pYDxFLfRGQLsG89KrfF())), WowheadInfo.OHYsyrf985vKpdhYPSk(-2018852357 ^ -2018862941)));
					num = 3;
					break;
				case 5:
					WowheadInfo.pLVEovfKt0Wfa2iMqjN(this.Itemini, Encoding.UTF8);
					num = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_a5d4b7819e164965bb08f6d803806b82 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0003B4C4 File Offset: 0x000396C4
		public void Save()
		{
			try
			{
				WowheadInfo.Yj6BGGfe2MUIvk3Kw8S(this.Itemini);
				WowheadInfo.Yj6BGGfe2MUIvk3Kw8S(this.Spellini);
				int num = 0;
				if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_c8b0d443bf9b43f59672b15574afc30a == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600075F RID: 1887 RVA: 0x0003B548 File Offset: 0x00039748
		// (remove) Token: 0x06000760 RID: 1888 RVA: 0x0003B588 File Offset: 0x00039788
		public event EventHandler<LogEventArgs> NewLogEvent;

		// Token: 0x06000761 RID: 1889 RVA: 0x0003B5C8 File Offset: 0x000397C8
		public void WriteLog(string logMessage)
		{
			int num = 1;
			int num2 = num;
			EventHandler<LogEventArgs> newLogEvent;
			for (;;)
			{
				switch (num2)
				{
				case 1:
					newLogEvent = this.NewLogEvent;
					if (newLogEvent != null)
					{
						goto IL_54;
					}
					num2 = 0;
					if (<Module>{cb13cea5-238d-4db2-b197-7f40acede0b8}.m_6ecdbee983964eca9eb75beb96e5f7ee != 0)
					{
						num2 = 0;
						continue;
					}
					continue;
				}
				break;
			}
			return;
			IL_54:
			newLogEvent(this, new LogEventArgs(logMessage));
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0003B63C File Offset: 0x0003983C
		// Note: this type is marked as 'beforefieldinit'.
		static WowheadInfo()
		{
			WowheadInfo.poxvfkfkYqpKc3vykUE();
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0003B64C File Offset: 0x0003984C
		internal static object OHYsyrf985vKpdhYPSk(int \u0020)
		{
			return vua32v5yjQhjRjK4YIO.BRA5TcZvlv(\u0020);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0003B660 File Offset: 0x00039860
		internal static object jjmpjSfwpmauPqlNsi8(object A_0)
		{
			return A_0.Groups;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0003B674 File Offset: 0x00039874
		internal static object mYTksVfAmEZMdoaKWQy(object A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0003B68C File Offset: 0x0003988C
		internal static object KUG0WXfhJAVImhtrkc3(object A_0)
		{
			return A_0.Value;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0003B6A0 File Offset: 0x000398A0
		internal static bool AkK0pDfQsqjI3juvM9a()
		{
			return WowheadInfo.WpIi7lf3iw62uTMYJtk == null;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0003B6B4 File Offset: 0x000398B4
		internal static WowheadInfo xw4k6DfC6QMr8vQbumY()
		{
			return WowheadInfo.WpIi7lf3iw62uTMYJtk;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0003B6C4 File Offset: 0x000398C4
		internal static object ctlNfkfS9LB6IqQ6gK4(object A_0, object A_1)
		{
			return A_0.Match(A_1);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0003B6DC File Offset: 0x000398DC
		internal static int QAMLt9fIAoG9c89dylp(object A_0)
		{
			return A_0.Count;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003B6F0 File Offset: 0x000398F0
		internal static object jCJxrNfijextdGIuuKa(object A_0, object A_1, object A_2)
		{
			return A_0.Replace(A_1, A_2);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0003B70C File Offset: 0x0003990C
		internal static bool shfy5ufZ9Iio0OZLjYZ(object A_0, object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0003B724 File Offset: 0x00039924
		internal static bool PnekEhfUpLG4dh7jfAx(object A_0)
		{
			return File.Exists(A_0);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0003B738 File Offset: 0x00039938
		internal static object xC3QSgf1sj8VU0DAb5f(object A_0, object A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0003B750 File Offset: 0x00039950
		internal static void DdatBnfp29QNXhYskWL(object A_0)
		{
			((IDisposable)A_0).Dispose();
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0003B764 File Offset: 0x00039964
		internal static object G5EBpWf4kcWRpaBl4VD(object A_0)
		{
			return A_0.Message;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0003B778 File Offset: 0x00039978
		internal static bool hnn6SKfOZdP3Bg8qTdN(object A_0, object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0003B790 File Offset: 0x00039990
		internal static object cTTR86ffiuMECV6UEPR(object A_0, object A_1, object A_2)
		{
			return A_0 + A_1 + A_2;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0003B7AC File Offset: 0x000399AC
		internal static void IZtBVdfFuOiaWtIjc0d()
		{
			vua32v5yjQhjRjK4YIO.p1T5fGSd8t();
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0003B7BC File Offset: 0x000399BC
		internal static void kJsUlZfTYPZ0EJyAidp()
		{
			PnrHSvxSLFnA986pZWM.QUh0QAwUQW();
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0003B7CC File Offset: 0x000399CC
		internal static object pYDxFLfRGQLsG89KrfF()
		{
			return Assembly.GetExecutingAssembly();
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0003B7DC File Offset: 0x000399DC
		internal static object P5j6jXfLGNSsrjgnZhh(object A_0)
		{
			return A_0.Location;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0003B7F0 File Offset: 0x000399F0
		internal static object aLtkLMflTRaHFuEwmvW(object A_0)
		{
			return Path.GetDirectoryName(A_0);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0003B804 File Offset: 0x00039A04
		internal static object GKFoD3faqVQkDcvH2Jo(object A_0, object A_1)
		{
			return Path.Combine(A_0, A_1);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0003B81C File Offset: 0x00039A1C
		internal static void pLVEovfKt0Wfa2iMqjN(object A_0, object A_1)
		{
			A_0.DefaultEncoding = A_1;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0003B834 File Offset: 0x00039A34
		internal static void Yj6BGGfe2MUIvk3Kw8S(object A_0)
		{
			A_0.Persist();
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0003B848 File Offset: 0x00039A48
		internal static void poxvfkfkYqpKc3vykUE()
		{
			vua32v5yjQhjRjK4YIO.aep5UvAyyY();
		}

		// Token: 0x04000329 RID: 809
		private string[] WowHeadHost;

		// Token: 0x0400032A RID: 810
		private string[] Sections;

		// Token: 0x0400032B RID: 811
		private INIFile Itemini;

		// Token: 0x0400032C RID: 812
		private INIFile Spellini;

		// Token: 0x0400032D RID: 813
		private string IconPath;

		// Token: 0x0400032E RID: 814
		private int ProcessCount;

		// Token: 0x04000330 RID: 816
		private static WowheadInfo WpIi7lf3iw62uTMYJtk;
	}
}
