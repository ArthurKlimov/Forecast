using Forecast.BL.Dtos.CurrentCityWeather;
using System.Text.Json.Serialization;

namespace Forecast.BL.Dtos
{
    public class CurrentCityWeatherResponse
    {
        [JsonPropertyName("request")]
        public WeatherStackRequest Request { get; set; }

        [JsonPropertyName("location")]
        public WeatherStackLocation Location { get; set; }

        [JsonPropertyName("current")]
        public WeatherStackCurrent CurrentWeather { get; set; }
    }
}
