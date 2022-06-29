using System;

namespace Homework7
{
    public static class Matrixes
    {
        public static double[,] FillMatrix(int size1, int size2)
        {
            double[,] matrix = new double[size1, size2];

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 2);
                }
            }

            return matrix;
        }

        public static int[,] FillMatrixInt(int size1, int size2)
        {
            int[,] matrix = new int[size1, size2];

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    matrix[i, j] = new Random().Next(1, 10);
                }
            }

            return matrix;
        }
        
        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                
                Console.WriteLine();
            }
        }
        
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                
                Console.WriteLine();
            }
        }
    }
}