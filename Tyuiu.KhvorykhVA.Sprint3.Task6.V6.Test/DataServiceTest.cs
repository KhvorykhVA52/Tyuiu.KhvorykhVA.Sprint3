using Tyuiu.KhvorykhVA.Sprint3.Task6.V6.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 16;
            int stopValue = 24;
            int wait = 5;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}