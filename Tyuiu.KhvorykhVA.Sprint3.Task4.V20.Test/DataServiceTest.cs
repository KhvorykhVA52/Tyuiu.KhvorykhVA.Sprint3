using Tyuiu.KhvorykhVA.Sprint3.Task4.V20.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 10.48303856012738;
            Assert.AreEqual(wait,res);
        }
    }
}