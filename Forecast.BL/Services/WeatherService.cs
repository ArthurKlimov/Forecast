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
            var iconPath = GetIconPathCorrespondsToCode(response.CurrentWeather.WeatherCode);

            var dto = new CurrentCityWeatherDto()
            {
                City = response.Location.Name,
                Time = currentTime,
                WeatherDescription = weatherDescription,
                Temperature = response.CurrentWeather.Temperature,
                FeelsLike = response.CurrentWeather.FeelsLike,
                Humidity = response.CurrentWeather.Humidity,
                Pressure = response.CurrentWeather.Pressure,
                IconPath = iconPath
            };

            return dto;
        }

        private string GetIconPathCorrespondsToCode(int weatherCode)
        {
            switch (weatherCode)
            {
                case 119: case 122: case 143:
                    {
                        return "/images/119.png";
                    }
                case 116:
                    {
                        return "/images/116.png";
                    }
                case 113:
                    {
                        return "/images/113.png";
                    }
                case 350:
                    {
                        return "/images/350.png";
                    }
                case 182: case 185:
                    {
                        return "/images/182.png";
                    }
                case 227: case 230: case 248: case 260:
                    {
                        return "/images/227.png";
                    }
                case 176: case 263: case 266: case 281: 
                case 293: case 296: case 311: case 317:
                case 320: 
                    {
                        return "/images/176.png";
                    }
                case 284: case 299: case 302: case 305: 
                case 308: case 314:
                    {
                        return "/images/284.png";
                    }
                case 179: case 323: case 326: case 329:
                case 332: case 335:  case 338: case 368:
                case 371:
                    {
                        return "/images/179.png";
                    }
                case 353: case 356: case 359: case 362:
                case 374: case 377:
                    {
                        return "/images/353.png";
                    }
                case 200: case 386: case 389: case 392:
                case 395:
                    {
                        return "/images/200.png";
                    }
                default:
                    {
                        return string.Empty;
                    }
            }
        }
    }
}
