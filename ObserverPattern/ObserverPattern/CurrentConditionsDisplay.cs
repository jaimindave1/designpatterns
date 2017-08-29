using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayItem
    {
        private float _temperature;

        private float _pressure;

        private float _humidity;

        private ISubject _subject;

        public CurrentConditionsDisplay(ISubject subject)
        {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Temperature: " + _temperature + ", Humidity: " + _humidity + "Pressure: " + _pressure);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _pressure = pressure;
            _humidity = humidity;
            Display();
        }
    }
}
