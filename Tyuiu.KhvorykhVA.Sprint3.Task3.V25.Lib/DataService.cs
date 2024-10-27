using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            foreach(char c in value)
            {
                if (c == item)
                {
                    count++;
                }

            }
            return count;

              
        }
    }
}
