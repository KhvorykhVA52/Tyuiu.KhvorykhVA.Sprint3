using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task6.V6.Lib;

public class DataService : ISprint3Task6V6
{
    public int GetSumTheDivisors(int startValue, int stopValue)
    {
        int count = 0;

        for (int x = startValue; x <= stopValue; x++)
        {
            bool hasDivisorGreaterThan10 = false;

            for (int d = 11; d <= x / 2; d++) 
            {
                if (x % d == 0)
                {
                    hasDivisorGreaterThan10 = true;
                    break;
                }
            }

            if (hasDivisorGreaterThan10)
            {
                count++;
            }
        }

        return count;
    }
}
