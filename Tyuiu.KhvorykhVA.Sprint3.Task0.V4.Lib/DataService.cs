using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double MultiplySeries = 0;
            int i;
            for (i = startValue; i < stopValue; i++)
            {
                MultiplySeries = MultiplySeries + (1 / Math.Sin(i));
            }
            return Math.Round(MultiplySeries, 3); 
        }
    }
}