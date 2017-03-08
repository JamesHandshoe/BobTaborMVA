using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", StickerPrice = 55000, Year = 2009 },
                new Car() { VIN = "B2", Make = "Toyota", Model = "4Runner", StickerPrice = 35000, Year = 2010 },
                new Car() { VIN = "C3", Make = "BMW", Model = "745li", StickerPrice = 75000, Year = 2010 },
                new Car() { VIN = "D4", Make = "Ford", Model = "Escape", StickerPrice = 25000, Year = 2014 },
                new Car() { VIN = "E5", Make = "BMW", Model = "55i", StickerPrice = 57000, Year = 2015 },
            };

            //the var keyword in C# allows the compiler to determine what type of variable
            //you are declaring.  Useful with LINQ

            //LINQ query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */
            //LINQ method
            //Lamba expression - same as above
            var bmws = myCars.Where(car => car.Make == "BMW" && car.Year == 2010);
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} - {1}", car.Model, car.VIN);
            }

            //Query syntax
            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            //LINQ method - Lamba expression
            //var orderedCars = myCars.OrderByDescending(car => car.Year);
            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} - {1}", car.Make, car.Year);
            }
            */

            /*
            var firstBMW = myCars.OrderByDescending(car => car.Year).First(car => car.Make == "BMW");
            Console.WriteLine(firstBMW.Model);
            */

            // Console.WriteLine(myCars.TrueForAll(car => car.Year > 2000));

            myCars.ForEach(car => car.StickerPrice -= 3000);
            myCars.ForEach(car => Console.WriteLine("{0} - {1:C}", car.VIN, car.StickerPrice));


            Console.WriteLine(myCars.Exists(car => car.Model == "745li"));

            Console.WriteLine(myCars.Sum(car => car.StickerPrice));
            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(car => car.Year);
            Console.WriteLine(orderedCars.GetType());
            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }

}
