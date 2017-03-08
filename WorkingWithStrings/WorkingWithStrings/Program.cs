using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";

            //a new line feed
            //string myString = "What if I need a \nnew line?";

            //how to use \ in a path
            //string myString = "Go to your c:\\drive";
            //@ tells C# that we are using the \ as a string not escape
            //string newString = @"Go to your c:\users";


            //string formatting
            //string myString = String.Format("{0} = {1}", "First", "Second");

            //:C formatting for currency (uses what your computer is set up for)
            //string myString = String.Format("{0:C}", 150.75);

            //:N formatting for comas and decimal for numbers
            //string myString = String.Format("{0:N}", 12345678901);

            //:P formatting for percentages
            //string myString = String.Format("Percentage: {0:P}", .054);

            //custom format - numbers will push out because it formats from right to left.
            //string myString = String.Format("Phone Number: {0:(###)###-####}", 3178500622);

            //string myString = " That summer we took threes across the board  ";

            //substring - truncates portions of the string
            //myString = myString.Substring(6, 14);

            //make string all caps
            //myString = myString.ToUpper();

            //make string all lowercase
            //myString = myString.ToLower();

            //.Replace a character with another
            //myString = myString.Replace(" ", "--");

            //Removes portions of the string completely
            //myString = myString.Remove(6, 14);

            //Format and .Length and .Trim()
            //myString = String.Format("Length before: {0} -- Length after: {1}",
            //    myString.Length, myString.Trim().Length);


            //strings are immutable - this is inefficient
            /*
            string myString = "";

            for (int i = 0; i <= 100; i++)
            {
                myString += "--" + i;
            }
            */

            //StringBuilder and .Append is more efficient way to build strings
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i <= 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
