using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhvorykhVA.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int adjacentCount = 0;
            char previousChar = '\0';
            foreach (char currentChar in value)
            {
                if (currentChar == item && previousChar == item)
                {
                    adjacentCount = 1;
                    break; 
                }

                previousChar = currentChar; 
            }

            return adjacentCount;
        }

    }
}
