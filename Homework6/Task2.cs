using System;

namespace Homework6
{
    public class Task2
    {
        public static void Execute()
        {
            Console.WriteLine("Enter k1");
            int.TryParse(Console.ReadLine(), out int k1);
            Console.WriteLine("Enter b1");
            int.TryParse(Console.ReadLine(), out int b1);
            Console.WriteLine("Enter k2");
            int.TryParse(Console.ReadLine(), out int k2);
            Console.WriteLine("Enter b2");
            int.TryParse(Console.ReadLine(), out int b2);
            Point p = CrossOfTwoLines(k1,b1,k2,b2);
            Console.WriteLine(p.Print());
        }

        private static Point CrossOfTwoLines(int k1, int b1, int k2, int b2)
        {
            double x = (b2 - b1) / (double)(k1 - k2);
            double y = k1 * x + b1;
            return new Point(x, y);
        }
        
        private struct Point
        {
            public double X;
            public double Y;

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public string Print()
            {
                return $"({X};{Y})";
            }
        }
    }
}