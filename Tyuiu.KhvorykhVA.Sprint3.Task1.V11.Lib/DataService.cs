using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task1.V11.Lib
{
    public class DataService : ISprint3Task1V11
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multSeries = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                multSeries *= (value + (double)k / 2);
                k++;
            }

            return multSeries;
        }
    }
}