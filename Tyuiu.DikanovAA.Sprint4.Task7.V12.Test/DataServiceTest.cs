using Tyuiu.DikanovAA.Sprint4.Task7.V12.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "658932125478";
            int wait = 30;
            int res = ds.Calculate(n, m, str);
            Assert.AreEqual(wait, res);
        }
    }
}