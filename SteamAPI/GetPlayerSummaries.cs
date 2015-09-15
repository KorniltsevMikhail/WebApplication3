using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace WebApplication3.SteamAPI
{
    public class GetPlayerSummaries
    {
        string API_METHOD_URL = "http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/";
        string token = "E83E3B926C3B56FD5C6D18AAB1376779";

        
        public SummariesResponse GetUserInfo(string id)
        {
            var values = new NameValueCollection();
            values["key"] = token;
            values["steamids"] = id;
            return performMethod<SummariesResponse>(values);
        }

        public T performMethod<T>(NameValueCollection values)
        {
            string url = API_METHOD_URL;
            return performPostRequest<T>(url, values);
        }

        public T performPostRequest<T>(string url, NameValueCollection values)
        {
            using (var client = new WebClient())
            {
                var response = client.UploadValues(url, values);
                var responseString = Encoding.UTF8.GetString(response);
                return JsonConvert.DeserializeObject<T>(responseString);

            }

        }
    }


}