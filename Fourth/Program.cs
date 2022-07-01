using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a, b;
            GetValue(out a, out b);
            
            Console.WriteLine("a = " + a + " b = " + b);
            Console.ReadKey();
        }

        private static void GetValue(out int a, out int b)
        {
            a = 2;
            b = 4;

            a = b + 4;
        }
    }
}