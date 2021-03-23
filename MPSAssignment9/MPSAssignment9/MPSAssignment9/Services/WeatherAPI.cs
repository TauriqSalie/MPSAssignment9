using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MPSAssignment9.Models;
using Newtonsoft.Json;

namespace MPSAssignment9.Services
{
    class WeatherAPI
    {
        public const string WEATHERMAPAPIKEY = "0073d637b8d626a0404feb89fac3e2a1";
        public const string BASE_URL = "https://api.openweathermap.org/data/2.5/onecall?lat=-33.9249&lon=18.4241&units=metric&appid=0073d637b8d626a0404feb89fac3e2a1";
        public static async Task<CurrentAPI> GetCurrentAPIAsync(double lat, double lon, string units)
        {
            CurrentAPI weather = new CurrentAPI();
            string url = String.Format(BASE_URL, lat, lon, units, WEATHERMAPAPIKEY);
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var post = JsonConvert.DeserializeObject<CurrentAPI>(content);
                weather = post;
            }
            return weather;
        }

    }
}

