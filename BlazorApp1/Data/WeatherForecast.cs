using System.Collections.Generic;

namespace BlazorApp1.Data
{
    public class WeatherData
    {
        public List<WeatherForecast> locations { get; set; }
    }
    public class WeatherForecast
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Time { get; set; }

        public string Sun { get; set; }
        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string Lat { get; set; }

        public string Long { get; set; }
    }
}
