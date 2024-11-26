using Tyuiu.DikanovAA.Sprint4.Task6.V28.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task6.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var water = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };

            string[] wait = {"Река", "Лужа", "Море"};
            string[] res = ds.Calculate(water);

            CollectionAssert.AreEqual(wait, res);


        }
    }
}