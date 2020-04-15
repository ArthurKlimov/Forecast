using Forecast.BL.Dtos.CurrentCityWeather;

namespace Forecast.Web.ViewModels
{
    public class IndexViewModel
    {
        public IndexViewModel() { }

        public IndexViewModel(CurrentCityWeatherDto dto)
        {
            City = dto.City;
            Time = dto.Time;
            IconPath = dto.IconPath;
            WeatherDescription = dto.WeatherDescription;
            Temperature = dto.Temperature;
            FeelsLike = dto.FeelsLike;
            Pressure = dto.Pressure;
            Humidity = dto.Humidity;
        }

        public string City { get; set; }

        public string Time { get; set; }

        public string IconPath { get; set; }

        public string WeatherDescription { get; set; }

        public int Temperature { get; set; }

        public int FeelsLike { get; set; }

        public int Pressure { get; set; }

        public int Humidity { get; set; }
    }
}
