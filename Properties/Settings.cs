using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Jack.Properties
{
	// Token: 0x0200002E RID: 46
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00670D24 File Offset: 0x0066EF24
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00670D44 File Offset: 0x0066EF44
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public List<string> AddonAutoDestroyJunklist
		{
			get
			{
				return (List<string>)this["AddonAutoDestroyJunklist"];
			}
			set
			{
				this["AddonAutoDestroyJunklist"] = value;
			}
		}
	}
}
