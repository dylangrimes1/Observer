using System;
using WeatherStation.Observers;
using WeatherStation.Subjects;

namespace WeatherStation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StockData queststockData = new StockData();

            CurrentStockDisplay currentQuestDisplay = new CurrentStockDisplay(queststockData);
            Console.WriteLine("Here is the stock data for the Quest 2: \n");
            queststockData.SetMeasurements(65, 299, 62);
            queststockData.SetMeasurements(54, 299, 71);
            queststockData.SetMeasurements(47, 299, 84);
            Console.WriteLine("\n");
            StockData samsungstockData = new StockData();

            CurrentStockDisplay currentSamsungDisplay = new CurrentStockDisplay(samsungstockData);
            Console.WriteLine("Here is the stock data for the Samsung Galaxy s22: \n");
            samsungstockData.SetMeasurements(185, 1149, 87);
            samsungstockData.SetMeasurements(132, 999, 94);
            samsungstockData.SetMeasurements(83, 1149, 82);
            Console.WriteLine("/n");
            StockData switchstockData = new StockData();

            CurrentStockDisplay currentSwitchDisplay = new CurrentStockDisplay(switchstockData);
            Console.WriteLine("Here is the stock data for the Nintendo Switch: \n");
            switchstockData.SetMeasurements(87, 259, 80);
            switchstockData.SetMeasurements(73, 259, 88);
            switchstockData.SetMeasurements(59, 259, 95);
        }

    }
}
