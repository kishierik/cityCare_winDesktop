using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Proyecto_Final.Request
{
    class ServerStatusRequest
    {
        public static int getStatus()
        {
            string requestResult = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Utils.Constants.serverAddress);
                    HttpResponseMessage result = client.GetAsync(Utils.Constants.serverStatus).Result;
                    requestResult = result.Content.ReadAsStringAsync().Result;
                    JToken token = JObject.Parse(requestResult);
                    return (int)token.SelectToken("error");
                }
            }
            catch (Exception e)
            {
                return 1;
            }
        }
    }
}
