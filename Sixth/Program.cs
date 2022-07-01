using System;
using System.Collections.Generic;

namespace Sixth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var guestList = new GuestList();

            var player1 = guestList["Alex"] = "ManCity";
            var player2 = guestList["Diogo"] = "Liverpool";
            
            Console.WriteLine(player1);
            Console.WriteLine(player2);

            Console.ReadKey();
        }
    }

    public class GuestList
    {
        private readonly Dictionary<string, string> _guests;

        public GuestList()
        {
            _guests = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _guests[key]; }
            set { _guests[key] = value; }
        }
    }
}