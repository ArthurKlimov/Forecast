using System.Threading.Tasks;
using Forecast.BL.Dtos.CurrentCityWeather;
using Forecast.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Forecast.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet]
        [Route("currentWeather")]
        public async Task<CurrentCityWeatherDto> GetCurrentCityWeather(string city)
        {
            return await _weatherService.GetCurrentCityWeather(city);
        }
    }
}