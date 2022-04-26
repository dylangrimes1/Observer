using System.Collections.Generic;
using WeatherStation.Observers;

namespace WeatherStation.Subjects
{
    public class StockData : ISubject
    {
        private readonly List<IObserver> _observers;
        private double _price;
        private double _availability;
        private double _satisfaction;

        public StockData()
        {
            _observers = new List<IObserver>();
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(double price, double availability, double satisfaction)
        {
            _price = price;
            _availability = availability;
            _satisfaction = satisfaction;
            MeasurementsChanged();
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price, _availability, _satisfaction);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }
    }
}


