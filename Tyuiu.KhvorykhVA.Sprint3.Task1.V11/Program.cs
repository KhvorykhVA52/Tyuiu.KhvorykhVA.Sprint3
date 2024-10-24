using Tyuiu.KhvorykhVA.Sprint3.Task1.V11.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task1.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double value = 0.75;
            int startValue = 1;
            int stopValue = 14;
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
