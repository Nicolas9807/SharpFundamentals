using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = Calc(new int[] { 1, 2, 3, 4, 5, 6 });
            int y = SuperCalc(1, 2, 3, 4, 23, 12, 1, 4);

            Console.WriteLine("sum1 = " + x + " sum2 = " + y);


            Console.ReadKey();
        }

        private static void Calculate(int a, int b)
        {
        }

        private static void Calculate(int a, int b, int c)
        {
        }

        private static void Calculate(int a, int b, int c, int d)
        {
        }

        private static int Calc(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }

        private static int SuperCalc(params int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }
    }
}