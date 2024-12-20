﻿
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task2.V24.Lib
{
    public class DataService : ISprint3Task2V24
    {
        public double GetMultiplySeries(double a, int startValue, int stopValue)
        {
            double result = 1.0;
            int k = startValue;

            do
            {
                double term = (Math.Pow(a, k) + 4) * Math.Cos(a);
                result *= term;
                k++;
            } while (k <= stopValue);

            return Math.Round(result, 3);
        }

    }
}
