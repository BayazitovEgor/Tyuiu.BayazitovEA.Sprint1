using Tyuiu.BayazitovEA.Sprint1.Task4.V23.Lib;
namespace Tyuiu.BayazitovEA.Sprint1.Task4.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = 3.0;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(1, res);
        }
    }
}
