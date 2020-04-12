using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Forecast.BL.Dtos
{
    public class CurrentCityWeatherResponse
    {
        public Request Request { get; set; }
        public Location Location { get; set; }

        [JsonPropertyName("current")]
        public CurrentWeather CurrentWeather { get; set; }
    }

    public class Request
    {
        public string Type { get; set; }
        public string Query { get; set; }
        public string Language { get; set; }
        public string Unit { get; set; }
    }

    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string Lot { get; set; }
        [JsonPropertyName("timezone_id")]
        public string TimezoneId { get; set; }
        [JsonPropertyName("localtime")]
        public string LocalTime { get; set; }
        [JsonPropertyName("localtime_epoch")]
        public long LocalTimeEpoch { get; set; }
        [JsonPropertyName("utc_offset")]
        public string UtcOffset { get; set; }
    }

    public class CurrentWeather
    {
        [JsonPropertyName("observation_time")]
        public string ObservationTime { get; set; }
        public int Temperature { get; set; }
        [JsonPropertyName("weather_code")]
        public int WeatherCode { get; set; }
        [JsonPropertyName("weather_icons")]
        public List<string> WeatherIcons { get; set; }
        [JsonPropertyName("weather_descriptions")]
        public List<string> WeatherDescriptions { get; set; }
        public int WindSpeed { get; set; }
        [JsonPropertyName("weather_degree")]
        public int WindDegree { get; set; }
        [JsonPropertyName("wind_dir")]
        public string WindDirection { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int CloudCover { get; set; }
        public int FeelsLike { get; set; }
        [JsonPropertyName("uv_index")]
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        [JsonPropertyName("is_day")]
        public string IsDay { get; set; }
    }
}
