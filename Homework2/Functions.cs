using System;

namespace Homework2
{
    public static class Functions
    {
        public static void Task1()
        {
            Console.WriteLine("Enter a three-digit number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(TakeSecondNumber(num));
        }


        public static void Task2()
        {
            Console.WriteLine("Enter day of the week");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(DayOfTheWeek(num));
        }
        
        
        
        private static int TakeSecondNumber(int num)
        {
            return num / 10 % 10;
        }


        private static bool DayOfTheWeek(int num)
        {
            switch (num)
            {
                case 1: return false;
                case 2: return false;
                case 3: return false;
                case 4: return false;
                case 5: return false;
                case 6: return true;
                case 7: return true;
                default: return false;
            }
        }
    }
}