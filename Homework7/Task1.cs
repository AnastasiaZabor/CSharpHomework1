using System;

namespace Homework7
{
    public class Task1
    {
        public static void Execute()
        {
            Console.WriteLine("Enter count of lines");
            int.TryParse(Console.ReadLine(), out int size1);
            Console.WriteLine("Enter count of columns");
            int.TryParse(Console.ReadLine(), out int size2);
            double[,] matrix = Matrixes.FillMatrix(size1, size2);
            Matrixes.PrintMatrix(matrix);
        }
    }
}