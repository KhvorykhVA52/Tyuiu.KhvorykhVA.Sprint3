using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            int startValue = 1;
            int stopValue = 14;

            
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double expected = 0.005;  
            double delta = 0.0001; 
            Assert.AreEqual(expected, res, delta, "The result of GetMultiplySeries is not as expected.");
        }
    }
}