using System;

namespace Homework9
{
    public class Task2
    {
        public static void Execute()
        {
            Console.WriteLine("Enter M");
            int.TryParse(Console.ReadLine(), out int m);
            Console.WriteLine("Enter N");
            int.TryParse(Console.ReadLine(), out int n);
            PrintConsecutiveNumbers(m,n);
        }

        private static void PrintConsecutiveNumbers(int m, int n)
        {
            int sum = 0;
            if (m < n)
            {
                for (int i = m; i <= n ; i++)
                {
                    Console.Write($"{i}, ");
                    sum += i;
                }
                Console.WriteLine($"sum = {sum} ");
            }
            else
            {
                for (int i = m; i >= n; i--)
                {
                    Console.Write($"{i}, ");
                    sum += i;
                }
                Console.WriteLine($"sum = {sum} ");
            }
        }
    }
}