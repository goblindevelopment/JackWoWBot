using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Jack.Core;
using Microsoft.CSharp;

namespace Jack.ATH
{
	// Token: 0x02000137 RID: 311
	internal class MDL
	{
		// Token: 0x06001CDA RID: 7386 RVA: 0x007320C8 File Offset: 0x007302C8
		public static void CreateMDs()
		{
			MDL.smethod_0("Gather", _globals.LCS.d700, _globals.LCS.d702);
			MDL.smethod_0("Skinning", _globals.LCS.d701, _globals.LCS.d703);
			string d = _globals.LCS.d710;
			if (d.Length > 0 && (d == "true" || d == "false"))
			{
				_globals.ModuleDungeon = Convert.ToBoolean(d);
			}
			string d2 = _globals.LCS.d720;
			if (d2.Length > 0 && (d2 == "true" || d2 == "false"))
			{
				_globals.ModuleNotifications = Convert.ToBoolean(d2);
			}
			string d3 = _globals.LCS.d730;
			if (Tools.IsNumber(d3, 1, 2, 1, 10) || (_globals.IsTeam && Tools.IsNumber(d3, 1, 3, 1, 999)))
			{
				_globals.ModuleMultiSession = Convert.ToInt32(d3);
			}
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x007321C0 File Offset: 0x007303C0
		public static void Create(string ModuleName, string Code)
		{
			string str = "";
			if (ModuleName == "Gather")
			{
				str = "MD1";
			}
			else if (ModuleName == "Skinning")
			{
				str = "MD2";
			}
			bool flag = false;
			string text = _globals.JackData + "\\" + str + ".dll";
			string text2 = "";
			string text3 = "";
			CSharpCodeProvider csharpCodeProvider = new CSharpCodeProvider();
			CompilerParameters compilerParameters = new CompilerParameters();
			compilerParameters.GenerateInMemory = true;
			compilerParameters.ReferencedAssemblies.Add(Assembly.GetEntryAssembly().Location);
			compilerParameters.ReferencedAssemblies.Add("System.Collections.dll");
			compilerParameters.ReferencedAssemblies.Add("mscorlib.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Core.dll");
			compilerParameters.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll");
			using (StringReader stringReader = new StringReader(Code))
			{
				string text4;
				while ((text4 = stringReader.ReadLine()) != null)
				{
					if (text4.Contains("using System.") && text4.Contains(";") && !text4.Contains("System.Collections"))
					{
						string value = text4.Replace("using ", "").Replace(";", ".dll").Replace(" ", "");
						compilerParameters.ReferencedAssemblies.Add(value);
					}
					else if (!text4.Contains(";"))
					{
						if (text2.Length == 0 && text4.Contains("namespace "))
						{
							text2 = text4.Replace("namespace ", "").Replace(" ", "");
						}
						else if (text3.Length == 0)
						{
							if (text4.Contains("public static class "))
							{
								text3 = text4.Replace("public static class ", "").Replace(" ", "");
							}
							else if (text4.Contains("public class "))
							{
								text3 = text4.Replace("public class ", "").Replace(" ", "");
							}
						}
					}
				}
			}
			if (text2.Length > 0 && text3.Length > 0)
			{
				compilerParameters.OutputAssembly = text;
				if (!csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
				{
					Code
				}).Errors.HasErrors && File.Exists(text))
				{
					Type type = Assembly.LoadFile(text).GetType(text2 + "." + text3);
					object obj = Activator.CreateInstance(type);
					if (ModuleName == "Gather")
					{
						MDL.MD1Type = type;
						MDL.MD1Instance = obj;
						if (MDL.MD1Type != null && MDL.MD1Instance != null)
						{
							flag = true;
						}
						_globals.ModuleGather = flag;
					}
					else if (ModuleName == "Skinning")
					{
						MDL.MD2Type = type;
						MDL.MD2Instance = obj;
						if (MDL.MD2Type != null && MDL.MD2Instance != null)
						{
							flag = true;
						}
						_globals.ModuleGather = flag;
					}
				}
			}
			if (!flag)
			{
				Tools.Console("Couldn't initialize Module " + ModuleName + ".", "Red", "richConsole", "frmMain", true);
				return;
			}
			Tools.Console("Module " + ModuleName + " initialized.", "Green", "richConsole", "frmMain", true);
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00732530 File Offset: 0x00730730
		public static object Call(string ModuleName, string MethodName, object[] Args = null, bool Return = false)
		{
			Type type = null;
			object obj = null;
			if (Args == null)
			{
				Args = new object[0];
			}
			if (!(ModuleName == "Gather"))
			{
				if (ModuleName == "Skinning")
				{
					type = MDL.MD2Type;
					obj = MDL.MD2Instance;
				}
			}
			else
			{
				type = MDL.MD1Type;
				obj = MDL.MD1Instance;
			}
			bool flag = false;
			MethodInfo method = type.GetMethod(MethodName);
			if (method != null)
			{
				object result;
				try
				{
					if (!Return)
					{
						method.Invoke(obj, Args);
						goto IL_78;
					}
					result = method.Invoke(obj, Args);
				}
				catch
				{
					flag = true;
					goto IL_78;
				}
				return result;
			}
			IL_78:
			if (method == null)
			{
				Tools.Console(string.Concat(new string[]
				{
					"Module Error -> ",
					MethodName,
					" -> ",
					MethodName,
					" -> NULL"
				}), "Red", "richConsole", "frmMain", true);
			}
			else if (flag)
			{
				Tools.Console("Module Error -> " + ModuleName + " -> " + MethodName, "Red", "richConsole", "frmMain", true);
			}
			return null;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0073263C File Offset: 0x0073083C
		[CompilerGenerated]
		internal static void smethod_0(string ModuleName, string EncrCode, string Hash)
		{
			if (EncrCode.Length > 0 && Hash.Length > 0)
			{
				string text = Crypt.Base64Decode(EncrCode);
				if (text.Contains("using "))
				{
					string b = Crypt.md5(text, 1);
					if (Hash == b)
					{
						MDL.Create(ModuleName, text);
					}
				}
			}
		}

		// Token: 0x04000F68 RID: 3944
		private static Type MD1Type;

		// Token: 0x04000F69 RID: 3945
		private static object MD1Instance;

		// Token: 0x04000F6A RID: 3946
		private static Type MD2Type;

		// Token: 0x04000F6B RID: 3947
		private static object MD2Instance;

		// Token: 0x04000F6C RID: 3948
		public static bool CheckDungeon;

		// Token: 0x04000F6D RID: 3949
		public static bool NotifyMe;
	}
}
