using System;

namespace Homework6
{
    public class Task1
    {
        public static void Execute()
        {
            Console.WriteLine("Enter numbers");
            int count = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    if (IsPositiveNumber(number))
                    {
                        count += 1;
                    }
                }
                else break;
            }
            Console.WriteLine(count);
        }


        private static bool IsPositiveNumber(int number)
        {
            return number > 0;
        }
    }
}