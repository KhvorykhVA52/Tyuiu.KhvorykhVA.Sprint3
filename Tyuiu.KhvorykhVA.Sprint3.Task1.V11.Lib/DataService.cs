using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = Math.Pow(value, k) + 0.5; 
                multSeries *= term;
                k++;
            }

            
            return Math.Round(multSeries, 5);
        }
    }
}
