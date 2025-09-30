using Tyuiu.BayazitovEA.Sprint1.Task3.V13.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.BayazitovEA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 235.0;
            var res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(30, res);
        }
    }
}
