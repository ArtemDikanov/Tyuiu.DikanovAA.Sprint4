using Tyuiu.DikanovAA.Sprint4.Task1.V18.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] array = { 9, 8, 7, 6, 5};

            int wait = 21;
            int res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}