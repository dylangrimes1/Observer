namespace WeatherStation.Observers
{
    public interface IObserver
    {
        void Update(double price, double availability, double satisfaction);
    }
}


