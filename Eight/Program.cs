using System;

namespace Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Client
    {
        public string Type(string name)
        {
            var type = GetClientType();
            return type;
        }

        private string GetClientType()
        {
            return "Golden";
        }
    }

    public class Bonus
    {
        public int GetBonus()
        {
            var client = new Client();
            var ct = client.Type("Alex");
            return CalculateBonus(ct);
        }

        private int CalculateBonus(string type)
        {
            if (type == "Golden")
                return 5;
            return 0;
        }
    }
}