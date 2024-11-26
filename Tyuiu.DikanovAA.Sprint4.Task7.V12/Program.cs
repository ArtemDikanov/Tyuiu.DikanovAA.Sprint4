using Tyuiu.DikanovAA.Sprint4.Task7.V12.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];
            string str = "658932125478";

            int index = 0;

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int res = ds.Calculate(n, m, str);

            Console.WriteLine("Ответ: " + res);
            Console.ReadKey();

        }
    }
}
