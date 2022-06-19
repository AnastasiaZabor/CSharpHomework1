using System;
using System.Diagnostics.CodeAnalysis;

namespace Homework5
{
    public class Task3
    {
        public static void CreateArrayAndDifferenceMaxAndMim()
        {
            Console.WriteLine("Enter size array");
            int size = int.Parse(Console.ReadLine());
            double[] arr = FillArrayWithDouble(size);
            Console.WriteLine(PrintArray(arr));
            Console.WriteLine(SearchForTheMaxAndMin(arr));
        }

        private static double[] FillArrayWithDouble(int size)
        {
            double[] arr = new double[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = Math.Round(new Random().NextDouble() * 100, 2);
            }

            return arr;
        }

        private static double SearchForTheMaxAndMin(double[] arr)
        {
            double max = arr[0];
            double min = arr[0];
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
            }

            return Math.Round(max - min, 2);
        }
        
        private static string PrintArray(double[] arr)
        {
           return string.Join(", ", arr);
        }
    }
}