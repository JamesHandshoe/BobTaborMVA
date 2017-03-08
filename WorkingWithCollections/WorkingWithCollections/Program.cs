using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.VIN = "A114121";
            car1.Make = "Hyundai";
            car1.Model = "Elantra";

            Car car2 = new Car();
            car2.VIN = "B1aj90";
            car2.Make = "Dodge";
            car2.Model = "Colt";

            Book b1 = new Book();
            b1.Author = "CS Lewis";
            b1.Title = "Screwtape Letters";
            b1.ISBN = "0-1231-9919";

            //ArrayLists are dynamically sized
            //cool features like sorting, remove items
            /*
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            //List<T> makes the list accept only specific types
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            //Dictionary - key - value pairing
            //Dictionary<TKey, TValue>

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["B1aj90"].Make);

            //string[] names = { "bob", "steve", "brian", "chuck" };

            //No need for a Constructor - Object Initializer
            Car car3 = new Car() { Make = "Honda", Model = "Civic", VIN = "D6" };
            Car car4 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "E6" };

            //Collection Initializer
            List<Car> myCarList = new List<Car>()
            {
                car1, car2, car3, car4
            };

            foreach (Car car in myCarList)
            {
                Console.WriteLine(car.Model);
            }

            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

}
