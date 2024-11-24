using Tyuiu.DikanovAA.Sprint4.Task4.V24.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] { { 7, 9, 3, 4 , 5},
                                            { 1, 2, 3, 4 , 5},
                                            { 1, 2, 3, 4 , 7},
                                            { 1, 2, 3, 4 , 5},
                                            { 1, 2, 3, 4 , 5} };
            int[,] waitArray = { { 7, 9, 3, 1 , 5 },
                                 { 1, 1, 3, 1 , 5 }, 
                                 { 1, 1, 3, 1 , 7 }, 
                                 { 1, 1, 3, 1 , 5 }, 
                                 { 1, 1, 3, 1 , 5 } };

            int[,] resArray = ds.Calculate(matrix);

            CollectionAssert.AreEqual(waitArray, resArray);
        }
    }
}