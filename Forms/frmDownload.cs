using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Jack.Core;
using Jack.Engine;
using Jack.Properties;
using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;

namespace Jack.Forms
{
	// Token: 0x0200004E RID: 78
	public partial class frmDownload : Form
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x0067CAE8 File Offset: 0x0067ACE8
		public frmDownload(params object[] args)
		{
			this.InitializeComponent();
			Initialize.ChangeTitle(this);
			this.Args = args;
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0067CB74 File Offset: 0x0067AD74
		private void Download_Shown(object sender, EventArgs e)
		{
			if (this.Args.Count<object>() > 0)
			{
				this.Mode = (string)this.Args[0];
				if (this.Args.Count<object>() > 1)
				{
					if (!(this.Args[1].GetType() == typeof(List<string[]>)))
					{
						if (this.Args[1].GetType() == typeof(string))
						{
							this.DoAfter = (string)this.Args[1];
							this.CustomAddition = this.DoAfter;
						}
					}
					else
					{
						this.ArgsList = (List<string[]>)this.Args[1];
					}
				}
				this.CreateDirectories();
				new Thread(new ThreadStart(this.Watch))
				{
					IsBackground = true
				}.Start();
				Thread thread = null;
				if (!(this.Mode == "Redist_x86"))
				{
					if (!(this.Mode == "Redist_x64"))
					{
						if (this.Mode == "Update")
						{
							thread = new Thread(delegate()
							{
								this.Download(frmDownload.URL_JackUpdate);
							});
						}
						else if (!(this.Mode == "Addons"))
						{
							if (!(this.Mode == "Maps"))
							{
								if (this.Mode == "Extract")
								{
									thread = new Thread(new ThreadStart(this.ExtractOnly));
								}
							}
							else
							{
								thread = new Thread(delegate()
								{
									this.Download(this.URL_JackMaps + "/" + this.CustomAddition);
								});
							}
						}
						else
						{
							thread = new Thread(delegate()
							{
								this.Download(this.URL_JackAddons);
							});
						}
					}
					else
					{
						thread = new Thread(delegate()
						{
							this.Download(this.URL_RedistX64);
						});
					}
				}
				else
				{
					thread = new Thread(delegate()
					{
						this.Download(this.URL_RedistX86);
					});
				}
				thread.IsBackground = true;
				thread.Start();
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0067CD40 File Offset: 0x0067AF40
		private void CreateDirectories()
		{
			if (!Directory.Exists(_globals.JackDownloads))
			{
				Directory.CreateDirectory(_globals.JackDownloads);
			}
			if (!Directory.Exists(_globals.JackUpdates))
			{
				Directory.CreateDirectory(_globals.JackUpdates);
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0067CD7C File Offset: 0x0067AF7C
		private void Watch()
		{
			while (!this.Done)
			{
				Thread.Sleep(10);
			}
			this.Done = false;
			base.Invoke(new MethodInvoker(delegate()
			{
				base.Close();
			}));
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0067CDB8 File Offset: 0x0067AFB8
		private void Download(string URL)
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.Timeout = 10000;
				try
				{
					object @lock = this._lock;
					lock (@lock)
					{
						webClient.DownloadProgressChanged += this.client_DownloadProgressChanged;
						webClient.DownloadFileCompleted += this.client_DownloadFileCompleted;
						webClient.QueryString.Add("DownloadFile", Path.GetFileName(URL));
						webClient.DownloadFileAsync(new Uri(URL), _globals.JackDownloads + "\\" + Path.GetFileName(URL), this._lock);
						System.Threading.Monitor.Wait(this._lock);
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0067CE98 File Offset: 0x0067B098
		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			double num = double.Parse(e.BytesReceived.ToString());
			double num2 = double.Parse(e.TotalBytesToReceive.ToString());
			double d = num / num2 * 100.0;
			string text = d.ToString("0");
			string text2 = e.BytesReceived.ToSize(CalcSize.SizeUnits.MB);
			string text3 = e.TotalBytesToReceive.ToSize(CalcSize.SizeUnits.MB);
			if (int.Parse(Math.Truncate(d).ToString()) >= 0)
			{
				this.SetProgress(string.Concat(new string[]
				{
					"Download (",
					text,
					"%): ",
					text2,
					"/",
					text3,
					" MB"
				}), int.Parse(Math.Truncate(d).ToString()));
			}
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0067CF6C File Offset: 0x0067B16C
		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			string fileName = ((WebClient)sender).QueryString["DownloadFile"];
			object userState = e.UserState;
			lock (userState)
			{
				System.Threading.Monitor.Pulse(e.UserState);
			}
			this.SetProgress("Process Files...", 100);
			this.DoAfterDownload(fileName);
			this.Done = true;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0067CFE4 File Offset: 0x0067B1E4
		private void ExtractOnly()
		{
			this.SetProgress("Count Files...", 0);
			foreach (string[] array in this.ArgsList)
			{
				string text = array[0];
				if (text.EndsWith(".7z"))
				{
					using (IArchive archive = ArchiveFactory.Open(text, null))
					{
						using (IEnumerator<IArchiveEntry> enumerator2 = archive.Entries.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								if (!enumerator2.Current.IsDirectory)
								{
									this.ArchivesCountAllFiles++;
								}
							}
							continue;
						}
					}
				}
				using (ZipArchive zipArchive = ZipFile.Open(text, ZipArchiveMode.Read))
				{
					this.ArchivesCountAllFiles += zipArchive.Entries.Count((ZipArchiveEntry x) => !string.IsNullOrWhiteSpace(x.Name));
				}
			}
			new Thread(new ThreadStart(this.ExtractionProgress))
			{
				IsBackground = true
			}.Start();
			Thread.Sleep(500);
			this.ExtractionStart = true;
			foreach (string[] array2 in this.ArgsList)
			{
				string text2 = array2[0];
				string text3;
				if (array2.Count<string>() <= 1)
				{
					text3 = text2;
				}
				else
				{
					text3 = array2[1];
				}
				while (!Tools.IsFileReady(text2, true))
				{
					Thread.Sleep(10);
				}
				if (text2.EndsWith(".7z"))
				{
					using (IArchive archive2 = ArchiveFactory.Open(text2, null))
					{
						IReader reader = archive2.ExtractAllEntries();
						while (reader.MoveToNextEntry())
						{
							if (!reader.Entry.IsDirectory)
							{
								IReaderExtensions.WriteEntryToDirectory(reader, text3, new ExtractionOptions
								{
									ExtractFullPath = false,
									Overwrite = true
								});
							}
						}
						goto IL_1E1;
					}
					goto IL_1D3;
				}
				goto IL_1D3;
				IL_1E1:
				if (this.ArgsList.Count > 1)
				{
					Thread.Sleep(2000);
					continue;
				}
				continue;
				IL_1D3:
				ZipFile.ExtractToDirectory(text2, Path.GetDirectoryName(text3));
				goto IL_1E1;
			}
			Thread.Sleep(1000);
			this.ExtractionStart = false;
			this.Done = true;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0067D26C File Offset: 0x0067B46C
		private void ExtractionProgress()
		{
			string name = Tools.RandomTimer("Extraction");
			Jack.Engine.Timer.Set(name, 120000);
			while (!this.ExtractionStart && Jack.Engine.Timer.Check(name) != 0)
			{
				Thread.Sleep(100);
			}
			if (this.ExtractionStart)
			{
				int num = 0;
				while (this.ExtractionStart && num <= this.ArchivesCountAllFiles)
				{
					num = 0;
					foreach (string[] array in this.ArgsList)
					{
						string path;
						if (array.Count<string>() <= 1)
						{
							path = array[0];
						}
						else
						{
							path = array[1];
						}
						if (Directory.Exists(path))
						{
							num += Directory.GetFiles(path, "*", SearchOption.TopDirectoryOnly).Length;
						}
					}
					int value = (int)Math.Round((double)(100 * num) / (double)this.ArchivesCountAllFiles);
					this.SetProgress(string.Concat(new string[]
					{
						"Extracting Files (",
						value.ToString(),
						"%): ",
						num.ToString(),
						"/",
						this.ArchivesCountAllFiles.ToString()
					}), value);
					Thread.Sleep(10);
				}
			}
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0067D3B4 File Offset: 0x0067B5B4
		private void DoAfterDownload(string FileName)
		{
			if (this.DoAfter == "Install")
			{
				string fileLocation = _globals.JackDownloads + "\\" + FileName;
				this.Install(fileLocation, "/install /quiet /norestart");
				return;
			}
			if (this.DoAfter == "Update")
			{
				bool flag = false;
				this.SetProgress("Copy Archive...", 10);
				string text = _globals.JackDownloads + "\\" + FileName;
				Thread.Sleep(5000);
				File.Move(_globals.JackDownloads + "\\" + FileName, _globals.JackUpdates + "\\" + FileName);
				int num = 20;
				this.SetProgress("Extracting Files...", 20);
				text = _globals.JackUpdates + "\\" + FileName;
				Thread.Sleep(5000);
				bool flag2;
				if (!(flag2 = this.Extract(text)))
				{
					num += 10;
					this.SetProgress("Extracting Files...", num);
					while (!flag2)
					{
						Thread.Sleep(1000);
						if (Directory.Exists(_globals.JackUpdates + "\\Jack"))
						{
							Directory.Delete(_globals.JackUpdates + "\\Jack", true);
							Thread.Sleep(1000);
						}
						flag2 = this.Extract(text);
						num += 10;
						this.SetProgress("Extracting Files...", num);
						if (num == 100)
						{
							flag = true;
							break;
						}
					}
				}
				if (!flag)
				{
					if (num >= 90)
					{
						num = 100;
					}
					else
					{
						num = 90;
					}
					this.SetProgress("Extracting Files...", num);
					text = _globals.JackUpdates + "\\Jack\\Data\\Updater.exe";
					while (!File.Exists(text))
					{
						Thread.Sleep(10);
					}
					Thread.Sleep(3000);
					File.Copy(text, _globals.JackFolder + "\\Updater.exe", true);
					text = _globals.JackFolder + "\\Updater.exe";
					Thread.Sleep(3000);
					this.SetProgress("Extracting Files...", 100);
					Process process = new Process();
					process.StartInfo.FileName = Path.GetFileName(text);
					process.StartInfo.WorkingDirectory = Path.GetDirectoryName(text);
					process.StartInfo.Arguments = "\"" + _globals.JackUpdates + "\\Jack\"";
					try
					{
						process.Start();
					}
					catch
					{
					}
					Tools.CloseJack(true);
					return;
				}
				MessageBox.Show("Some files could not be extracted.\r\nPlease try again.", Tools.RandomString(15, false), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (Directory.Exists(_globals.JackUpdates + "\\Jack"))
				{
					Directory.Delete(_globals.JackUpdates + "\\Jack", true);
					Tools.CloseJack(true);
					return;
				}
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0067D648 File Offset: 0x0067B848
		private void Install(string FileLocation, string Args)
		{
			if (File.Exists(FileLocation))
			{
				if (int.Parse(new FileInfo(FileLocation).Length.ToSize(CalcSize.SizeUnits.MB)) > 5)
				{
					while (!Tools.IsFileReady(FileLocation, false))
					{
						Thread.Sleep(10);
					}
					this.RunFile(FileLocation, Args, true);
					if (this.Mode.Contains("Redist"))
					{
						Jack.Core.Settings.FirstStart = true;
						Jack.Core.Settings.Save();
					}
				}
			}
			while (!Tools.IsFileReady(FileLocation, true))
			{
				Thread.Sleep(10);
			}
			Thread.Sleep(2000);
			File.Delete(FileLocation);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0067D6D0 File Offset: 0x0067B8D0
		private bool Extract(string FileLocation)
		{
			if (File.Exists(FileLocation))
			{
				bool result;
				try
				{
					ZipFile.ExtractToDirectory(FileLocation, Path.GetDirectoryName(FileLocation));
					return true;
				}
				catch
				{
					result = false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0067D710 File Offset: 0x0067B910
		private void RunFile(string FileLocation, string Args, bool WaitForExit = false)
		{
			while (!Tools.IsFileReady(FileLocation, false))
			{
				Thread.Sleep(10);
			}
			Tools.StartProcess(FileLocation, Args, false);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0067D73C File Offset: 0x0067B93C
		private void SetProgress(string Text, int Value)
		{
			try
			{
				this.lblProgress.Invoke(new Action(delegate()
				{
					this.lblProgress.Text = Text;
				}));
				this.progress.Invoke(new Action(delegate()
				{
					this.progress.Value = Value;
				}));
			}
			catch
			{
			}
		}

		// Token: 0x0400020B RID: 523
		private object[] Args;

		// Token: 0x0400020C RID: 524
		private string Mode = "";

		// Token: 0x0400020D RID: 525
		private string DoAfter = "";

		// Token: 0x0400020E RID: 526
		private string CustomAddition = "";

		// Token: 0x0400020F RID: 527
		private bool Done;

		// Token: 0x04000210 RID: 528
		private object _lock = new object();

		// Token: 0x04000211 RID: 529
		private List<string[]> ArgsList = new List<string[]>();

		// Token: 0x04000212 RID: 530
		private string URL_RedistX86 = "https://aka.ms/vs/16/release/vc_redist.x86.exe";

		// Token: 0x04000213 RID: 531
		private string URL_RedistX64 = "https://aka.ms/vs/16/release/vc_redist.x64.exe";

		// Token: 0x04000214 RID: 532
		public static string URL_JackUpdate = "https://dl.wow-jack.com/update/Jack.zip";

		// Token: 0x04000215 RID: 533
		private string URL_JackMaps = "http://162.19.224.124/jack/maps";

		// Token: 0x04000216 RID: 534
		private string URL_JackAddons = "https://dl.wow-jack.com/update/Addons.zip";

		// Token: 0x04000217 RID: 535
		private bool ExtractionStart;

		// Token: 0x04000218 RID: 536
		private int ArchivesCountAllFiles;
	}
}
