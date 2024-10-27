using Tyuiu.KhvorykhVA.Sprint3.Task2.V24.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            Console.WriteLine("Значение a = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Стоп шага = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine("Произведение ряда = " + result);
            Console.ReadKey();
        }
    }
}
