using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalWeather
{
    public class LocationQuery
    {
        public string Key { get; }
        public LocationQuery(string cityName)
        {
            JArray jsonData;
            using (var webClient = new System.Net.WebClient())
                jsonData = JArray.Parse(webClient.DownloadString($"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={apiKeys.AccuWeatherAPIKey}&q={cityName}"));
            Key = jsonData[0]["Key"].ToString();
        }
        public LocationQuery(double latitude, double longitude)
        {
            JObject jsonData;
            using (var webClient = new System.Net.WebClient())
                jsonData = JObject.Parse(webClient.DownloadString($"http://dataservice.accuweather.com/locations/v1/cities/geoposition/search?apikey={apiKeys.AccuWeatherAPIKey}&q={latitude}%2C{longitude}"));
            Key = jsonData["Key"].ToString();
        }

    }

    public class WeatherQuery
    {
        public string temperatureUnit { get; }
        public double tempLow { get; }
        public double tempHigh { get; }
        public string webLocation { get; }
        private JObject jsonData { get; set; }
        public WeatherQuery(LocationQuery lq)
        {
            using (var webClient = new System.Net.WebClient())
                jsonData = JObject.Parse(webClient.DownloadString($"http://dataservice.accuweather.com/forecasts/v1/daily/1day/{lq.Key}?apikey={apiKeys.AccuWeatherAPIKey}&metric=true"));
            webLocation = (string)jsonData["DailyForecasts"][0]["Link"];
            temperatureUnit = (string)jsonData["DailyForecasts"][0]["Temperature"]["Minimum"]["Unit"];
            tempLow = double.Parse((string)jsonData["DailyForecasts"][0]["Temperature"]["Minimum"]["Value"]);
            tempHigh = double.Parse((string)jsonData["DailyForecasts"][0]["Temperature"]["Maximum"]["Value"]);
        }
    }
}
