using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forecast.BL.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Forecast.Web.Controllers
{
    public class HomeController : Controller
    {
        //private IActionContextAccessor _accessor;

        //public HomeController(IActionContextAccessor accessor)
        //{
        //    _accessor = accessor;
        //}

        public IActionResult Index()
        {
            //var userIP = _accessor.ActionContext.HttpContext.Connection.RemoteIpAddress;
            var weather = WeatherStackClient.GetCurrentCityWeather("Petrozavodsk");
            return View();
        }
    }
}