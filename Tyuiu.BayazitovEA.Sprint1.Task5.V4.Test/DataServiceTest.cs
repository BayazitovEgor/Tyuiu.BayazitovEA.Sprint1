using Tyuiu.BayazitovEA.Sprint1.Task5.V4.Lib;
namespace Tyuiu.BayazitovEA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int t = 13257;
            var res = ds.SecondsToHours(t);
            Assert.AreEqual(3, res);
        }
    }
}
