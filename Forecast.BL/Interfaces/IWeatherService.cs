using Forecast.BL.Dtos.CurrentCityWeather;
using System.Threading.Tasks;

namespace Forecast.BL.Interfaces
{
    public interface IWeatherService
    {
        Task<CurrentCityWeatherDto> GetCurrentCityWeather(string city);
    }
}
