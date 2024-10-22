using Tyuiu.KhvorykhVA.Sprint3.Task0.V4.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 1;
            int stopValue = 7;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Стоп шага =  " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма рада = " + ds.GetMultiplySeries(startValue, stopValue));
            Console.ReadKey();



        }






    }






}