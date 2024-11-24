using Tyuiu.DikanovAA.Sprint4.Task5.V29.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { -1, 2, 3, 4 , 5},
                                         { 1, 2, 3, 4 , 5 },
                                         { 1, 2, 3, 4 , 7 },
                                         { 1, 2, 3, 4 , 5 },
                                         { 1, -2, 3, 4 , 5} };
            int wait = 23;
            int res = ds.Calculate(mas);

            Assert.AreEqual(wait, res);

        }
    }
}