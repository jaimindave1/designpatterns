using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation WeatherStation = new WeatherStation();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(WeatherStation);
            ForecastDisplay forecastDisplay = new ForecastDisplay(WeatherStation);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(WeatherStation);

            WeatherStation.SetWeatherData(11, 8, 13);
            WeatherStation.SetWeatherData(33, 9, 11);
            WeatherStation.SetWeatherData(51, 10, 15);
            WeatherStation.SetWeatherData(31, 11, 16);
            
            Console.ReadLine();
        }
    }
}
