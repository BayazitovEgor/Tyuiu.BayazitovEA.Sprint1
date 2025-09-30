using Newtonsoft.Json.Linq;
using Tyuiu.BayazitovEA.Sprint1.Task2.V5.Lib;
namespace Tyuiu.BayazitovEA.Sprint1.Task2.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            var res = ds.CalculateSideSquare(x);
            Assert.AreEqual(125, res);
        }
    }
}
