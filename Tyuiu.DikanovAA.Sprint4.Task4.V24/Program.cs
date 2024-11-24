using Tyuiu.DikanovAA.Sprint4.Task4.V24.Lib;
namespace Tyuiu.DikanovAA.Sprint4.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, columns];



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Результат: ");
            int[,] resArray = ds.Calculate(matrix);
            int rowss = resArray.GetUpperBound(0) + 1;
            int columnss = resArray.Length / rowss;
            for (int i = 0; i < rowss; i++)
            {
                for (int j = 0; j < columnss; j++)
                {
                    Console.Write($"{resArray[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}