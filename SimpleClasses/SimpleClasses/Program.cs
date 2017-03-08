using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate or build a new Car object in memory
            Car myCar = new Car();

            //Set the values of the properties
            myCar.Make = "Hyundai";
            myCar.Model = "Elantra";
            myCar.Year = 2004;
            myCar.Color = "Maroon";

            //Get the values of the properties
            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

            //example using a helper method
            decimal myCarValue = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", myCarValue);
            Console.WriteLine("-------------------------");
            //example using a method built in the class
            Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();

        }
        //Helper Method to determine market value
        private static decimal DetermineMarketValue(Car car)
        {
            decimal carValue = 100.0M;
            return carValue;
        }
    }

    class Car
    {
        //properties and the getter and setter
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //method
        public decimal DetermineMarketValue()
        {
            decimal carValue;

            if (Year > 1990)
            {
                carValue = 10000;
            }
            else
            {
                carValue = 2000;
            }

            return carValue;
        }
    }
}
