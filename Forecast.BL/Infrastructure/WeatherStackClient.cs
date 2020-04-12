using Forecast.BL.Dtos;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Forecast.BL.Infrastructure
{
    public static class WeatherStackClient
    {
        private static readonly string Domain = "http://api.weatherstack.com/";
        private static readonly string Token = "b6c8b5ef34e9ade522291a0bdaa2e14f";
        private static HttpClient HttpClient;

        static WeatherStackClient()
        {
            HttpClient = new HttpClient();
            HttpClient.BaseAddress = new Uri(Domain);
        }

        public static async Task<CurrentCityWeatherResponse> GetCurrentCityWeather (string city)
        {
            try
            {
                HttpResponseMessage response = await HttpClient.GetAsync($"current?access_key={Token}&query={city}");
                response.EnsureSuccessStatusCode();

                var responseAsString = await response.Content.ReadAsStringAsync();
                var currentCityWeather = JsonSerializer.Deserialize<CurrentCityWeatherResponse>(responseAsString);

                return currentCityWeather;
            }
            catch (HttpRequestException)
            {
                return new CurrentCityWeatherResponse();
            }
        }
    }
}
