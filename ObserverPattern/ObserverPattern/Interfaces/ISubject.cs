using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface ISubject
    {
        void SetWeatherData(float temperature, float pressure, float humidity);

        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void MeasurementsChanged();

        void NotifyObserers();
    }
}
