using Tyuiu.KhvorykhVA.Sprint3.Task7.V9.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]

        public void TestMethod1()
        {
            DataService dataService = new DataService();
            Assert.AreEqual([4.84], dataService.GetMassFunction(1, 2));
        }
    }
}
