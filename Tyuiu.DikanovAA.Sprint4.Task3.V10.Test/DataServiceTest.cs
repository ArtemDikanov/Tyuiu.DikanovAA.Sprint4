using Tyuiu.DikanovAA.Sprint4.Task3.V10.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task3.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { 1, 2, 3, 4 , 5},
                                         { 1, 2, 3, 4 , 5},
                                         { 1, 2, 3, 4 , 7},
                                         { 1, 2, 3, 4 , 5},
                                         { 1, 2, 3, 4 , 5} };
            int wait = 7;
            int res = ds.Calculate(mas);

            Assert.AreEqual(wait, res);

        }
    }
}