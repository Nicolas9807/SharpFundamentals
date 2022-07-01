using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = 65;
            GetValue(ref a);

            Console.WriteLine(a);
            Console.ReadKey();
        }

        private static int GetValue(ref int a)
        {
            return a += 2;
        }
    }
}