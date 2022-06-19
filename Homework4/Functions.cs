using System;
using Microsoft.VisualBasic;

namespace Homework4
{
    public class Functions
    {
        public static void Task1()
        {
            Console.WriteLine("Enter num1 and num2");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int result = Exponentiation(num1, num2);
            Console.WriteLine(result);
        }

        public static void Task2()
        {
            Console.WriteLine("Enter num");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfNumbers(num));
        }

        public static void Task3()
        {
            int[] arr = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"Enter num{i+1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Print(arr));
        }
        
        private static int Exponentiation(int num1, int num2)
        {
            return (int) Math.Pow(num1, num2);
        }

        private static int SumOfNumbers(int num)
        {
            int diff = num;
            int sum = 0;
            
            while (diff / 10 != 0)
            {
                sum += (diff % 10);
                diff /= 10;
            }

            sum += diff;
            return sum;
        }
        
        private static string Print(int[] arr)
        {
            return string.Join(", ", arr);
        }
            
    }
}