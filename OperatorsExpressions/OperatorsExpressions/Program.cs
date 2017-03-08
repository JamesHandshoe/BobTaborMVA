using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;

            a = 10;
            b = 5;
            x = 24;
            y = 6;

            //order of operations PERMDAS
            x = (x + y) * (a - b); //should be 150
            Console.WriteLine(x);

            //now any mathematical operators can be implemented.

            Console.WriteLine(a % y); //should be 4

            /*Comparison Operators
             * > greater than
             * < less than
             * >= great than or equal to
             * <= less than or equal to
             * == equal to
             * != not equal to
            */

            /*Conditional Operators
                && - and (both conditions must be true)  
                || - or (at least one of the conditions must be true)
           */

            //Inline conditional operator (ternary)
            var numOne = 1;
            string message = (numOne == 1) ? "Car" : "Boat";
            Console.WriteLine(message);

            Console.ReadLine();

        }
    }
}
