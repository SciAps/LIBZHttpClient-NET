using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace sciaps.libzhttpclient
{
	public class LIBZHttpClient
	{
		public static LIBZHttpClient createClient(String url) {
			LIBZHttpClient retval = new LIBZHttpClient (url);
			return retval;
		}

		private HttpClient mClient;
		private String mHost;

		private LIBZHttpClient(String host)
		{
			mClient = new HttpClient();
			mClient.DefaultRequestHeaders.Add ("user-agent", "LIBZHttpClient .NET");
			mHost = host;
		}

		public async Task<Instrument> getInstrumentAsync() {
			using (mClient) {
				string jsonStr = await mClient.GetStringAsync ("http://" + mHost + ":9000" + "/instrument/id");
				return JsonConvert.DeserializeObject<Instrument>(jsonStr);
			}
		}
	}
}

