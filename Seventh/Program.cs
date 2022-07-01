using System;

namespace Seventh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var plane1 = new Plane();
            plane1.MaxSpeed = 900;
            var result = plane1.CalculateInKm();

            Console.WriteLine(result);

            Console.ReadKey();
        }

        public class Vehicle
        {
            public int MaxSpeed { get; set; }
            public int MaxDistance { get; set; }

            public int CalculateInKm()
            {
                return MaxSpeed / 100;
            }
        }

        public class Plane : Vehicle
        {
            public int MaxHeight { get; set; }
        }

        public class Submarine : Vehicle
        {
            public int MaxDepth { get; set; }
        }
    }
}