using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhvorykhVA.Sprint3.Task7.V9.Lib;

namespace Tyuiu.KhvorykhVA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] wait = 88;
            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
