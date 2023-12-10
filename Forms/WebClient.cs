using System;
using System.Net;

namespace Jack.Forms
{
	// Token: 0x02000051 RID: 81
	public class WebClient : WebClient
	{
		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0067DE04 File Offset: 0x0067C004
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x0067DE18 File Offset: 0x0067C018
		public int Timeout { get; set; }

		// Token: 0x060007BD RID: 1981 RVA: 0x0067DE2C File Offset: 0x0067C02C
		protected override WebRequest GetWebRequest(Uri URI)
		{
			WebRequest webRequest = base.GetWebRequest(URI);
			webRequest.Timeout = this.Timeout;
			if (this.IsFTP)
			{
				((FtpWebRequest)webRequest).ReadWriteTimeout = this.Timeout;
				this.IsFTP = false;
			}
			else
			{
				((HttpWebRequest)webRequest).ReadWriteTimeout = this.Timeout;
			}
			return webRequest;
		}

		// Token: 0x04000226 RID: 550
		public bool IsFTP;
	}
}
