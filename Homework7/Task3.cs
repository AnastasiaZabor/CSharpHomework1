using System;

namespace Homework7
{
    public class Task3
    {
        public static void Execute()
        {
            Console.WriteLine("Enter count of lines");
            int.TryParse(Console.ReadLine(), out int size1);
            Console.WriteLine("Enter count of columns");
            int.TryParse(Console.ReadLine(), out int size2);
            int[,] matrix = Matrixes.FillMatrixInt(size1, size2);
            Matrixes.PrintMatrix(matrix);
            Console.WriteLine(PrintArray(AverageOfColumn(matrix)));
        }

        private static double[] AverageOfColumn(int[,] matrix)
        {
            int size1 = matrix.GetLength(0);
            int size2 = matrix.GetLength(1);
            double[] array = new double[size2];
            
            for (int i = 0; i < size2; i++)
            {
                double sum = 0;
                for (int j = 0; j < size1; j++)
                {
                    sum += matrix[j, i];
                }
                array[i] = sum / size1;
            }

            return array;
        }

        private static string PrintArray(double[] array)
        {
            return string.Join(", ", array);
        }
    }
}