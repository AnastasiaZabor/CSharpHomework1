using System;

namespace Homework8
{
    public class Task2
    {
        public static void Execute()
        {
            Console.WriteLine("Enter count size1");
            int.TryParse(Console.ReadLine(), out int size1);
            Console.WriteLine("Enter count size2");
            int.TryParse(Console.ReadLine(), out int size2);
            int[,] matrix = Matrixes.FillMatrix(size1, size2);
            Matrixes.PrintMatrix(matrix);
            Console.WriteLine(NumberString(matrix));
        }

        private static int NumberString(int[,] matrix)
        {
            int lineCount = matrix.GetLength(0);
            int lineLength = matrix.GetLength(1);
            int minimalSum = 0;
            int minimalSumRowNumber = 1;
            
            for (int i = 0; i < lineCount; i++)
            {
                for (int j = 0; j < lineLength; j++)
                {
                    minimalSum += matrix[i, j];
                }
            }

            for (int i = 1; i < lineCount; i++)
            {
                int sum = 0;
                for (int j = 0; j < lineLength; j++)
                {
                    sum += matrix[i, j];
                }

                if (sum < minimalSum)
                {
                    minimalSum = sum;
                    minimalSumRowNumber = i+1;
                }
            }

            return minimalSumRowNumber;
        }
    }
}