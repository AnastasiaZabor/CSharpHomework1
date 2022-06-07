using System;

namespace CSharpHomework1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Task1(); 
           //Task2();
           //Task3();
           //Task4();
        }

        public static void Task1()
        {
            Console.WriteLine("VVedite num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("VVedite num2");
            int num2 = int.Parse(Console.ReadLine());

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
        
        
        public static void Task2()
        {
            Console.WriteLine("VVedite num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("VVedite num2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("VVedite num3");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine(num2);
                }
                else
                {
                    Console.WriteLine(num3);
                }
            }
            
            Console.ReadLine();
        }
        
        
        public static void Task3()
        {
            Console.WriteLine("VVedite num");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            
            Console.ReadLine();
        }


        public static void Task4()
        {
            Console.WriteLine("VVedite N");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}