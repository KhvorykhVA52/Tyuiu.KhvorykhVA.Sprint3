using Tyuiu.KhvorykhVA.Sprint3.Task3.V25.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task3.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string str = "kjhgfuu gujut dtuu";
            char chr = 'u';
            Console.WriteLine("Исходная строка = " +  str);
            Console.WriteLine("Искомый символов = " +  chr);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество символов = " + ds.GetMinCharCount(str, chr));
            Console.ReadKey();


        }






    }



}