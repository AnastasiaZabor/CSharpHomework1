using System;

namespace Homework9
{
    public class Task3
    {
        public static void Execute()
        {
            Console.WriteLine("Enter M");
            uint.TryParse(Console.ReadLine(), out uint m);
            Console.WriteLine("Enter N");
            uint.TryParse(Console.ReadLine(), out uint n);
            var result = AckermanFunction(m,n);
            Console.WriteLine(result);
        }
        private static uint AckermanFunction(uint m, uint n)
        {
            if (m == 0)
                return n + 1;
            return n == 0 
                ? AckermanFunction(m - 1, 1) 
                : AckermanFunction(m - 1, AckermanFunction(m, n - 1));
        }
    }
}