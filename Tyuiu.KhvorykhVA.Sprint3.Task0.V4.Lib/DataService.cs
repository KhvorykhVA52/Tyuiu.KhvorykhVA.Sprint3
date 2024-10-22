using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            double sinValue = Math.Sin(0.1);

            for (int i = startValue; i <= stopValue; i++)
            {
                MultiplySeries *= (sinValue + i);
            }

            return Math.Round(MultiplySeries, 3);
        }
    }
}
