using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherStation : ISubject
    {
        private float _temperature;

        private float _pressure;

        private float _humidity;

        private List<IObserver> _observers = new List<IObserver>();

        public void SetWeatherData(float temperature, float pressure, float humidity)
        {
            _temperature = temperature;
            _pressure = pressure;
            _humidity = humidity;
            MeasurementsChanged();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObserers();
        }

        public void NotifyObserers()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(_temperature, _pressure, _humidity);
            }
        }
    }
}
