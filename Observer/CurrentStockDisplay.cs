using System;
using WeatherStation.Subjects;

namespace WeatherStation.Observers
{
    public class CurrentStockDisplay : IObserver, IDisplayElement
    {
        private double _price;
        private double _availability;
        private double _satisfaction;
        private readonly ISubject _weatherData;

        public CurrentStockDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current Availability: "+ _availability + " Price: £" + _price + " User Satisfaction: " + _satisfaction);
        }

        public void Update(double price, double availability, double satisfaction)
        {
            _price = price;
            _availability = availability;
            _satisfaction = satisfaction;
            Display();
        }
    }
}


