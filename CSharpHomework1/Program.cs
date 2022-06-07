using System;

namespace CSharpHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
           Task1(); 
        }

        public static void Task1()
        {
            Console.WriteLine("VVedite num1");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("VVedite num2");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
            
            Console.ReadLine();
        }
    }
}