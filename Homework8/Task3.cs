using System;

namespace Homework8
{
    public class Task3
    {
        public static void Execute()
        {
            Console.WriteLine("Enter count size1");
            int.TryParse(Console.ReadLine(), out int size1);
            Console.WriteLine("Enter count size2");
            int.TryParse(Console.ReadLine(), out int size2);
            int[,] matrix1 = Matrixes.FillMatrix(size1,size2);
            Matrixes.PrintMatrix(matrix1);
            int[,] matrix2 = Matrixes.FillMatrix(size1,size2);
            Matrixes.PrintMatrix(matrix2);
            int[,] multiplication = MultiplyMatrices(matrix1, matrix2);
            Matrixes.PrintMatrix(multiplication);
        }

        private static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] resultMatrix = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
            
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        resultMatrix[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
                }
            }

            return resultMatrix;
        }
    }
}