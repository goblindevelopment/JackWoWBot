using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace Jack.Core
{
	// Token: 0x020000FC RID: 252
	public static class Crypt
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x0071AE94 File Offset: 0x00719094
		public static string EncryptString(string plainText, string password, string ivstr)
		{
			Array bytes = Encoding.UTF8.GetBytes(password);
			byte[] bytes2 = Encoding.UTF8.GetBytes(ivstr);
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[16];
			Array.Copy(bytes, 0, array, 0, 16);
			aes.Key = array;
			aes.IV = bytes2;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes3 = Encoding.ASCII.GetBytes(plainText);
			cryptoStream.Write(bytes3, 0, bytes3.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array2, 0, array2.Length);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0071AF3C File Offset: 0x0071913C
		public static string DecryptString(string cipherText, string password, string ivstr)
		{
			Array bytes = Encoding.UTF8.GetBytes(password);
			byte[] bytes2 = Encoding.UTF8.GetBytes(ivstr);
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			byte[] array = new byte[16];
			Array.Copy(bytes, 0, array, 0, 16);
			aes.Key = array;
			aes.IV = bytes2;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array2 = Convert.FromBase64String(cipherText);
				cryptoStream.Write(array2, 0, array2.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array3 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array3, 0, array3.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0071B008 File Offset: 0x00719208
		public static string md5(string ToCrypt, int Amount = 1)
		{
			string text = ToCrypt;
			for (int i = 0; i < Amount; i++)
			{
				using (MD5 md = MD5.Create())
				{
					byte[] bytes = Encoding.ASCII.GetBytes(ToCrypt);
					byte[] array = md.ComputeHash(bytes);
					StringBuilder stringBuilder = new StringBuilder();
					for (int j = 0; j < array.Length; j++)
					{
						stringBuilder.Append(array[j].ToString("X2"));
					}
					text = stringBuilder.ToString().ToLower();
				}
				ToCrypt = text;
			}
			return text;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0071B0A0 File Offset: 0x007192A0
		public static string sha1(string ToCrypt)
		{
			HashAlgorithm hashAlgorithm = new SHA1Managed();
			byte[] bytes = Encoding.UTF8.GetBytes(ToCrypt);
			byte[] array = hashAlgorithm.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in array)
			{
				stringBuilder.AppendFormat("{0:x2}", b);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x0071B0F8 File Offset: 0x007192F8
		public static string Base64Encode(string plainText)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0071B118 File Offset: 0x00719318
		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0071B138 File Offset: 0x00719338
		public static string HWID()
		{
			bool flag = true;
			string result = "";
			try
			{
				string text = "";
				if (text == string.Empty)
				{
					foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
					{
						if (driveInfo.IsReady)
						{
							text = driveInfo.RootDirectory.ToString();
							break;
						}
					}
				}
				if (text.EndsWith(":\\"))
				{
					text = text.Substring(0, text.Length - 2);
				}
				string str = Crypt.VolumeSerial(text);
				string text2 = Crypt.CPUID();
				result = text2.Substring(13) + text2.Substring(1, 4) + str + text2.Substring(4, 4);
			}
			catch
			{
				flag = false;
			}
			if (!flag)
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("Select ProcessorId From Win32_processor").Get().GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						result = ((ManagementObject)enumerator.Current)["ProcessorId"].ToString();
					}
				}
			}
			return result;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0071B258 File Offset: 0x00719458
		private static string VolumeSerial(string Drive)
		{
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"" + Drive + ":\"");
			managementObject.Get();
			string result = managementObject["VolumeSerialNumber"].ToString();
			managementObject.Dispose();
			return result;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0071B298 File Offset: 0x00719498
		private static string CPUID()
		{
			string text = "";
			foreach (ManagementBaseObject managementBaseObject in new ManagementClass("win32_processor").GetInstances())
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				if (text == "")
				{
					text = managementObject.Properties["processorID"].Value.ToString();
					break;
				}
			}
			return text;
		}
	}
}
