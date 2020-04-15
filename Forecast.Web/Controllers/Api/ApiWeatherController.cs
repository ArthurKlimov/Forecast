using System.Threading.Tasks;
using Forecast.BL.Dtos.CurrentCityWeather;
using Forecast.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Forecast.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiWeatherController : ControllerBase
    {
        private IWeatherService _weatherService;

        public ApiWeatherController(IWeatherService weatherService)
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