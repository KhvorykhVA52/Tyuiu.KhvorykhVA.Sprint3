using Tyuiu.KhvorykhVA.Sprint3.Task0.V4.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 3.431;
            Assert.AreEqual(wait, res);

        }
    }
}