using Tyuiu.KhvorykhVA.Sprint3.Task1.V11.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.75;
            int stapValue = 1;
            int stopValue = 14;
            double res = ds.GetMultiplySeries(value, stapValue, stopValue);
            double wait = 0.005;
            Assert.AreEqual(wait,res);
        }
    }
}