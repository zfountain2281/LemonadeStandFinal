using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Weather
    {
        public int temperature;
        public string condition;
        public int forecastTemperature;
        public string forecastCondition;
        Random random;
        //string dailyWeather;
        public int[] TemperatureOfWeather = new int[] { 60, 70, 80, 90, 100 };
        public string[] ConditionOfWeather = new string[] { "sunny", "cloudy", "partly cloudy", "rainy", "foggy" };
        public Weather(Random random)
        {
            this.random = random;
            ForecastTemperature();
            ForecastCondition();
        }
        public void DailyTemperature()
        {
            int DailyTemperature = random.Next(0, TemperatureOfWeather.Length);
            temperature = TemperatureOfWeather[DailyTemperature];
        }
        public void DailyCondition()
        {
            int WeatherCondition = random.Next(0, ConditionOfWeather.Length);
            condition = (ConditionOfWeather[WeatherCondition]);
        }
        public void CreateTodaysWeather()
        {
            List<string> weatherForcase = new List<string> { "Today" };
            foreach (string day in weatherForcase)
            {
                DailyTemperature();
                DailyCondition();
            }
        }
        public void DisplayTodaysWeather()
        {
            Console.WriteLine("Today's weather is: {0} {1}\n\n", temperature, condition);
        }
        public void ForecastTemperature()
        {
            int DailyTemperature = random.Next(0, TemperatureOfWeather.Length);
            forecastTemperature = TemperatureOfWeather[DailyTemperature];
        }
        public void ForecastCondition()
        {
            int WeatherCondition = random.Next(0, ConditionOfWeather.Length);
            forecastCondition = (ConditionOfWeather[WeatherCondition]);
        }

        public void CreateForecastWeather()
        {
            List<string> weatherForcase = new List<string> { "Tomorrow's", "The next day's", "And the day after that's" };
            foreach (string day in weatherForcase)
            {

                Console.WriteLine(day + " forecast is: {0} {1}  \n\n", forecastTemperature, forecastCondition);
            }
        }
    }
}
