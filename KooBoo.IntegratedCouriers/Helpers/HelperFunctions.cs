using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KooBoo.IntegratedCouriers.Helpers
{
    public class HelperFunctions
    {
        public static HttpClient GetJSonHttpClient(string _baseAddress)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(_baseAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }
    }
}
