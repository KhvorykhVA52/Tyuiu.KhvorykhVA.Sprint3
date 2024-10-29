using Tyuiu.KhvorykhVA.Sprint3.Task7.V9.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Введите значние х:                                                       ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("* Введите значние y:                                                       ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");
            double[] result = ds.GetMassFunction(x, y);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            Console.ReadKey();

        }



    }




}