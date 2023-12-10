using System;
using System.IO;

namespace Jack.Core
{
	// Token: 0x02000108 RID: 264
	internal class Build
	{
		// Token: 0x060017E0 RID: 6112 RVA: 0x0071D7D4 File Offset: 0x0071B9D4
		public static void CheckAndSetOffsets()
		{
			string text = "";
			if (_globals.Builds.ContainsValue(_globals.DetectedBuild) && !_globals.ProcessFolder.Contains("beta"))
			{
				if (!_globals.ProcessFolder.Contains("_classic_era_ptr_"))
				{
					if (_globals.ProcessFolder.Contains("_classic_ptr_"))
					{
						if (!(_globals.Builds["ClassicPTR"] == _globals.DetectedBuild))
						{
							if (_globals.Builds["ClassicPTRPrevious"] == _globals.DetectedBuild)
							{
								text = "ClassicPTRPrevious";
							}
						}
						else
						{
							text = "ClassicPTR";
						}
					}
					else if (!_globals.ProcessFolder.Contains("_ptr_"))
					{
						if (_globals.ProcessFolder.Contains("_classic_era_"))
						{
							if (!(_globals.Builds["ClassicEra"] == _globals.DetectedBuild))
							{
								if (_globals.Builds["ClassicEraPrevious"] == _globals.DetectedBuild)
								{
									text = "ClassicEraPrevious";
								}
							}
							else
							{
								text = "ClassicEra";
							}
						}
						else if (_globals.ProcessFolder.Contains("_classic_"))
						{
							if (_globals.Builds["Classic"] == _globals.DetectedBuild)
							{
								text = "Classic";
							}
							else if (_globals.Builds["ClassicPrevious"] == _globals.DetectedBuild)
							{
								text = "ClassicPrevious";
							}
						}
						else if (_globals.ProcessFolder.Contains("_retail_"))
						{
							if (_globals.Builds["Retail"] == _globals.DetectedBuild)
							{
								text = "Retail";
							}
							else if (_globals.Builds["RetailPrevious"] == _globals.DetectedBuild)
							{
								text = "RetailPrevious";
							}
						}
					}
					else if (_globals.Builds["RetailPTR"] == _globals.DetectedBuild)
					{
						text = "RetailPTR";
					}
					else if (_globals.Builds["RetailPTRPrevious"] == _globals.DetectedBuild)
					{
						text = "RetailPTRPrevious";
					}
				}
				else if (_globals.Builds["ClassicEraPTR"] == _globals.DetectedBuild)
				{
					text = "ClassicEraPTR";
				}
				else if (_globals.Builds["ClassicEraPTRPrevious"] == _globals.DetectedBuild)
				{
					text = "ClassicEraPTRPrevious";
				}
			}
			if (_globals.IsTeam && File.Exists(_globals.JackData + "\\cosAlways.jk"))
			{
				OffsetsManager.Set("Custom");
				return;
			}
			if (text.Length > 0)
			{
				OffsetsManager.Set(text);
				return;
			}
			if (_globals.IsTeam && File.Exists(_globals.JackData + "\\cos.jk"))
			{
				OffsetsManager.Set("Custom");
				return;
			}
			Tools.Console("", "", "richConsole", "frmMain", true);
			Tools.Console("########################################################################", "", "richConsole", "frmMain", true);
			Tools.Console("! This WoW Version is not supported.", "Red", "richConsole", "frmMain", true);
			Tools.Console("! Please update WoW or wait until Jack is updated.", "", "richConsole", "frmMain", true);
			Tools.Console("! My Version: " + _globals.DetectedBuild, "", "richConsole", "frmMain", true);
			Tools.Console("########################################################################", "", "richConsole", "frmMain", true);
			Tools.Console("", "", "richConsole", "frmMain", true);
		}
	}
}
