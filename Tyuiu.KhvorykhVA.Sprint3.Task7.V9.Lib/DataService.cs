using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task7.V9.Lib
{
    public class DataService : ISprint3Task7V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[(stopValue - startValue) + 1];

            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = Math.Cos(i) - 2 * i;
                if (denominator == 0)
                {
                    result[i - startValue] = 0;
                }
                else
                {
                    double number = ((2 * i - 3) / denominator) + 5 * i - Math.Sin(i);
                    result[i - startValue] = Math.Round(number, 2);
                }
            }
            return result;
        }
    }
}
