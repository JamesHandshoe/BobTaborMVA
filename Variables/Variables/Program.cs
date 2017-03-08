using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            /*
            //variable declaration
            int x;
            int y;

            //assign variables
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine(numbers[0]);
            Console.WriteLine("What is your name?");
            Console.Write("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //ctrl . allows us to change variable names wherever they occur.
            Console.Write("Type your last name: ");
            //initialization
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
            Console.ReadLine();
        }
    }
}
