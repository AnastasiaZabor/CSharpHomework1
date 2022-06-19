using System;
using Microsoft.VisualBasic;

namespace Homework5
{
    public class Task2
    {
        public static void CreateArrayAndSumOddPositions()
        {
            Console.WriteLine("Enter size array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = FillArrayWithIntegers(size);
            Console.WriteLine(PrintArray(arr));
            Console.WriteLine(SumOddPositions(arr));
        }

        private static int[] FillArrayWithIntegers(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(10,500);
            }

            return arr;
        }

        private static int SumOddPositions(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += arr[i];
                }   
            }

            return sum;
        }

        private static string PrintArray(int[] arr)
        {
            return string.Join(", ", arr);
        }
    }
}