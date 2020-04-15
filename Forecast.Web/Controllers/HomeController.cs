using Forecast.BL.Interfaces;
using Forecast.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Forecast.Web.Controllers
{
    public class HomeController : Controller
    {
        //private IActionContextAccessor _accessor;

        //public HomeController(IActionContextAccessor accessor)
        //{
        //    _accessor = accessor;
        //}

        private IWeatherService _weatherService;

        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index()
        {
            var currentWeather = await _weatherService.GetCurrentCityWeather("Petrozavodsk");

            var vm = new IndexViewModel(currentWeather);

            return View(vm);
        }
    }
}