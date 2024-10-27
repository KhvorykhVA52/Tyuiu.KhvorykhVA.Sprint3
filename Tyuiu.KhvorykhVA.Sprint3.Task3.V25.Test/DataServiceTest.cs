using Tyuiu.KhvorykhVA.Sprint3.Task3.V25.Lib;
namespace Tyuiu.KhvorykhVA.Sprint3.Task3.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMinCharCount()
        {
            DataService ds = new DataService();
            string str = "kjhgfuu gujut dtuu";
            char chr = 'u';
            double res = ds.GetMinCharCount(str, chr);
            int wait = 1;
            Assert.AreEqual(wait, res);

    }   }
}