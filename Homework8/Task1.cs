using System;

namespace Homework8
{
    public class Task1
    {
        public static void Execute()
        {
            Console.WriteLine("Enter count size1");
            int.TryParse(Console.ReadLine(), out int size1);
            Console.WriteLine("Enter count size2");
            int.TryParse(Console.ReadLine(), out int size2);
            int[,] matrix = Matrixes.FillMatrix(size1,size2);
            Matrixes.PrintMatrix(matrix);
            int[,] sortedMatrix = SortDescendingElementsRow(matrix);
            Matrixes.PrintMatrix(sortedMatrix);
        }

        private static int[,] SortDescendingElementsRow(int[,] matrix)
        {
            int lineCount = matrix.GetLength(0);
            int lineLength = matrix.GetLength(1);
            int[,] newMatrix = new int[lineCount, lineLength];
            
            for (int i = 0; i < lineCount; i++)
            {
                int[] line = new int[lineLength];
                for (int j = 0; j < lineLength; j++)
                {
                    line[j] = matrix[i, j];
                }
                Array.Sort(line);
                Array.Reverse(line);
                for (int j = 0; j < lineLength; j++)
                {
                    newMatrix[i, j] = line[j];
                }
            }

            return newMatrix;
        }
    }
}