using System;

namespace Homework6
{
    public class Task2
    {
        public static void Execute()
        {
            Point p = CrossOfTwoLines(5, 2, 9, 4);
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