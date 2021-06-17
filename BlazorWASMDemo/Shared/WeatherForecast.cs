using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWASMDemo.Shared
{
    public class WeatherForecast
    {
        public DateTime WeatherDate { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
