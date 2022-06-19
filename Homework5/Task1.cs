using System;

namespace Homework5
{
    public class Task1
    {
        public static void CreateArrayAndCountEven()
        {
            Console.WriteLine("Count of elements");
            int size = int.Parse(Console.ReadLine());
            int[] arr = FillArrayWithIntegers(size);
            Console.WriteLine(PrintArray(arr));
            Console.WriteLine(CountEven(arr));
        }


        private static int[] FillArrayWithIntegers(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = new Random().Next(100, 1000);
            }

            return arr;
        }
            
        private static int CountEven(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count += 1;
                }
                
            }
            return count;
        }

        private static string PrintArray(int[] arr)
        {
            return string.Join(", ", arr);
        }
    }
}