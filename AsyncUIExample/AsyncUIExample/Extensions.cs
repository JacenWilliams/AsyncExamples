using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AsyncUIExample
{
    public static  class Extensions
    {
        public static T GetFromJson<T>(this HttpClient client, string url)
        {
            return client.GetFromJsonAsync<T>(url).Result;
        }
    }
}
