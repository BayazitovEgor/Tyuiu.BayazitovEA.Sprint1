using Tyuiu.BayazitovEA.Sprint1.Task7.V20.Lib;
namespace Tyuiu.BayazitovEA.Sprint1.Task7.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 2.0;
            var result = ds.Calculate(x,y);
            Assert.AreEqual(4.917, result);
        }
    }
}
