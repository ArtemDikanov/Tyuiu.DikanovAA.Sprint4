using Tyuiu.DikanovAA.Sprint4.Task6.V28.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task6.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            var water = new string[] { "Река", "Озеро", "Болото", "Океан", "Лужа", "Море" };

            for (int i = 0; i <= water.Length - 1; i++)
            {
                Console.WriteLine(water[i]);
            }
            string[] res = ds.Calculate(water);
            Console.WriteLine("Результат: ");

            for (int j = 0; j <= res.Length - 1; j++)
            {
                Console.WriteLine(res[j]);
            }
        }
    }
}
