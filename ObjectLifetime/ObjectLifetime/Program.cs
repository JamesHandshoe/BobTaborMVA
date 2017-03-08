using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //example using a constructor
            Car myCar = new Car("Hyundai", "Elantra", 2004, "Maroon");

            /* Example defining properties
            myCar.Make = "Hyundai";
            myCar.Model = "Elantra";
            myCar.Year = 2004;
            myCar.Color = "Maroon";

            Car myOtherCar;
            myOtherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3}", 
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "Accent";
            */

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            Car.CarTalk();

            Console.ReadLine();
        }
    }

    class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //Constructor Methods
        public Car()
        {
            Make = "Nissan";
        }

        //overloaded Constructor
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void CarTalk()
        {
            Console.WriteLine("Hey I vroom!");
        }
    }
}
