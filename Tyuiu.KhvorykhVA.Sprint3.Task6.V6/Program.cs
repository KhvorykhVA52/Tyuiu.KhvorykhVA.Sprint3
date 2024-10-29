using Tyuiu.KhvorykhVA.Sprint3.Task6.V6.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds  = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 16;
            int stopValue = 24;
            Console.WriteLine("Старт шага  = " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();


        }



    }




}