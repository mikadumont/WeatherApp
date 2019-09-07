using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlazorApp1.Data
{
    public class WeatherForecastService
    {

        public object Name { get; private set; }

        public List<WeatherForecast> GetSunnyLocation()
        {
            return GetLocationData();
        }

        public List<WeatherForecast> GetLocationData()
        {
            string locations = File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/data.json"));
            WeatherData locationObjs = JsonConvert.DeserializeObject<WeatherData>(locations);
            List<WeatherForecast> filteredLocation = new List<WeatherForecast>();
            foreach (WeatherForecast location in locationObjs.locations)
            {
                DateTime currentTime = DateTime.Now;
                DateTime currentTimePlus2 = currentTime.AddHours(2);
                if (currentTime.Hour >= int.Parse(location.StartTime) && currentTime.Hour <= int.Parse(location.EndTime))
                {
                    location.Time = string.Format("{0:hh:mm tt}", currentTime) + " - " + string.Format("{0:hh:mm tt}", currentTimePlus2);
                    filteredLocation.Add(location);
                }
            }
            return filteredLocation;
           
        }
    }
}
