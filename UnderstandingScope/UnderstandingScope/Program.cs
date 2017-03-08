using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                k = i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine("K equals: " + k);
            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();
            Console.ReadLine();

        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from HelperMethod(): " + k);
        }
    }


    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Yo Yo I am private!";
        }
    }
}
