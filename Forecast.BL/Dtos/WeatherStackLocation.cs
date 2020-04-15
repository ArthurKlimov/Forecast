using System.Text.Json.Serialization;

namespace Forecast.BL.Dtos
{
    public class WeatherStackLocation
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("lat")]
        public string Latitude { get; set; }

        [JsonPropertyName("lot")]
        public string Longitude { get; set; }

        [JsonPropertyName("timezone_id")]
        public string TimezoneId { get; set; }

        [JsonPropertyName("localtime")]
        public string LocalTime { get; set; }

        [JsonPropertyName("localtime_epoch")]
        public long LocalTimeEpoch { get; set; }

        [JsonPropertyName("utc_offset")]
        public string UtcOffset { get; set; }
    }
}
