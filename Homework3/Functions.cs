using System;

namespace Homework3
{
    public class Functions
    {
        public static void Task1()
        {
            Console.WriteLine("Enter a five-digit number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Palindrom(num));
        }


        public static void Task2()
        {
            Console.WriteLine("Enter coordinates of the first point");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int z1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinates of the second point");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int z2 = int.Parse(Console.ReadLine());
            double result = Distance(x1, x2, y1, y2, z1, z2);
            Console.WriteLine($"{result:f2}");
        }
        
        
        public static void Task3()
        {
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintArray(Cube(num)));
        }
        
        private static bool Palindrom(int num)
        {
            int diff = num, mod;
            int[] arr = new int[5]; 
            for (int i = 0; i < 5; i++)
            {
                mod = diff % 10;
                diff = diff / 10;
                arr[i] = mod;
            }

            if (arr[0] == arr[4] && arr[1] == arr[3])
            {
                return true;
            }

            return false;
        }


        private static double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        }


        private static int[] Cube(int num)
        {
            int[] arr = new int[num];

            for (int i = 1; i <= num; i++)
            {
                arr[i-1] = (int)Math.Pow(i, 3);
            }

            return arr;
        }

        private static string PrintArray(int[] arr)
        {
            return string.Join(", ", arr);
        }
    }
}