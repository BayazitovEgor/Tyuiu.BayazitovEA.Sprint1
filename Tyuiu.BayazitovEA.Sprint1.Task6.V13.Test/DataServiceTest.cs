using Newtonsoft.Json.Linq;
using Tyuiu.BayazitovEA.Sprint1.Task6.V13.Lib;
namespace Tyuiu.BayazitovEA.Sprint1.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string text = "abc";
            bool result = ds.CheckWordsAlphabet(text);
            Assert.IsTrue(result);
        }
    }
}
