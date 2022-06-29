using System;

namespace Homework7
{
    public class Task2
    {
        public static void Execute()
        {
            Console.WriteLine("Enter count of lines");
            int.TryParse(Console.ReadLine(), out int size1);
            Console.WriteLine("Enter count of columns");
            int.TryParse(Console.ReadLine(), out int size2);
            double[,] matrix = Matrixes.FillMatrix(size1, size2);
            Matrixes.PrintMatrix(matrix);
            Console.WriteLine("Enter row");
            int.TryParse(Console.ReadLine(), out int row);
            Console.WriteLine("Enter column");
            int.TryParse(Console.ReadLine(), out int column);
            if (LookForElementAtPosition(matrix, row, column, out double element))
            {
                Console.WriteLine($"Element = {element}");
            }
            else
            {
                Console.WriteLine("There is no such position in matrix");
            }
        }

        private static bool LookForElementAtPosition(double[,] matrix, int row, int column, out double element)
        {
            element = 0;
            int size1 = matrix.GetLength(0);
            int size2 = matrix.GetLength(1);

            if (row < 0 || row >= size1)
            {
                return false;
            }

            if (column < 0 || column >= size2)
            {
                return false;
            }

            element = matrix[row, column];
            return true;
        }
    }
}