using System;

namespace Fifth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Person("Alex", new DateTime(1996, 12, 15));
            var result = "Hello " + person.Name + ", you are " + person.Age + " y.o.";

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; }
        public DateTime BirthDate { get; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public int Age
        {
            get
            {
                var span = DateTime.Now - BirthDate;
                return span.Days / 365;
            }
        }
    }
}