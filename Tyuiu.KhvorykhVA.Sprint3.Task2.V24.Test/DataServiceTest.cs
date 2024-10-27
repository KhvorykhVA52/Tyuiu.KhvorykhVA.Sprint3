using Tyuiu.KhvorykhVA.Sprint3.Task2.V24.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(res, wait, 0.0001); 
        }
    }
}
