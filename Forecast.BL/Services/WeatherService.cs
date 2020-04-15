using Forecast.BL.Dtos.CurrentCityWeather;
using Forecast.BL.Infrastructure;
using Forecast.BL.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Forecast.BL.Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<CurrentCityWeatherDto> GetCurrentCityWeather(string city)
        {
            var response = await WeatherStackClient.GetCurrentCityWeather("Petrozavodsk");
            if (response.CurrentWeather == null)
                return new CurrentCityWeatherDto();

            var currentTime = DateTime.Now.ToString("t");

            var weatherDescription = response.CurrentWeather.WeatherDescriptions.FirstOrDefault();

            var dto = new CurrentCityWeatherDto()
            {
                City = response.Location.Name,
                Time = currentTime,
                WeatherDescription = weatherDescription,
                Temperature = response.CurrentWeather.Temperature,
                FeelsLike = response.CurrentWeather.FeelsLike,
                Humidity = response.CurrentWeather.Humidity,
                Pressure = response.CurrentWeather.Pressure
            };

            return dto;
        }
    }
}
