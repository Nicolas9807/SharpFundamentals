using System;
using System.Collections.Generic;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var engine = new Engine();
            engine.Model = "XXX";
            string carName = "Audi";
            int id = 3;

            var searching = new Searching();
            var searchingId = new Searching(id);

            Console.WriteLine(searching.SearchEngineByCar(carName));
            Console.WriteLine(searchingId.GetEngine().Car.Name);

            Console.ReadKey();
        }
    }

    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Engine Engine { get; set; }
    }

    public class Engine
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public Car Car { get; set; }
    }

    public class Searching
    {
        private List<Engine> _baza;
        private int _engineId;
        private string _carName;

        public Searching()
        {
            _baza = CreateBase();
        }

        public Searching(string carName) : this()
        {
            _carName = carName;
        }

        public Searching(int engineId) : this()
        {
            _engineId = engineId;
        }

        public string SearchCarByEngine(string engineModel)
        {
            var b = new EngineBase();

            foreach (var engine in b.Engines)
            {
                if (engine.Model == engineModel)
                    return engine.Car.Name;
            }

            return null;
        }

        public string SearchEngineByCar(string carName)
        {
            foreach (var engine in _baza)
            {
                if (engine.Car.Name == carName)
                    return engine.Model;
            }

            return null;
        }

        public Engine GetEngine()
        {
            foreach (var engine in _baza)
            {
                if (engine.Id == _engineId)
                    return engine;
            }

            return null;
        }

        private static List<Engine> CreateBase()
        {
            return new EngineBase().Engines;
        }
    }

    public class EngineBase
    {
        public List<Engine> Engines = new List<Engine>
        {
            new Engine() { Id = 1, Model = "XXX", Car = new Car() { Name = "BMW" } },
            new Engine() { Id = 2, Model = "YYY", Car = new Car() { Name = "Audi" } },
            new Engine() { Id = 3, Model = "ZZZ", Car = new Car() { Name = "Ferrari" } }
        };
    }
}