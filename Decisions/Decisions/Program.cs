using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Big Jim's Giveaway");
            Console.Write("Choose a Door: 1, 2, or 3: ");
            string message = "";
            string userValue = Console.ReadLine();

            if ( userValue == "1")
            {
                message = "You did it!";
            }
            else if ( userValue == "2")
            {
                message = "Ouch - terrible choice!";
            }
            else if ( userValue == "3")
            {
                message = "Oh man - shouldn't have chose that one!";
            }
            else
            {
                message = "Yeah - that doesn't make sense! ";
                message += "You lose!";
            }
            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Big Jim's Giveaway");
            Console.Write("Choose a Door: 1, 2, or 3: ");
            string userValue = Console.ReadLine();

            //ternary operator
            string message = (userValue == "1") ? "boat" : "Sloppy Joes";

            //Console.Write("You won a ");
            //Console.Write(message + ".");

            //Formatting for cleaner string concatenation 
            Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered a {0} and won a {1}.", userValue, message);
            Console.ReadLine();
        }
    }
}
