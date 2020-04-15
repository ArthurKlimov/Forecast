using System;
using System.Collections.Generic;
using System.Text;

namespace Forecast.BL.Dtos.CurrentCityWeather
{
    public class CurrentCityWeatherDto
    {
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
