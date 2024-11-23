using Tyuiu.DikanovAA.Sprint4.Task3.V10.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task3.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 5, 7, 6, 6 , 5},
                                           { 5, 5, 5, 4 , 6},
                                           { 8, 5, 7, 4 , 7},
                                           { 7, 6, 7, 4 , 7},
                                           { 5, 8, 7, 8 , 8} };
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            DataService ds = new DataService();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ответ: " + ds.Calculate(array));
            Console.ReadKey();


        }
    }
}
