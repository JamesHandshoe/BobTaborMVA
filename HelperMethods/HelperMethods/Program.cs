using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = "";

            Console.WriteLine("The Name Game");

            
            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("What is your city of birth? ");
            string cityOfBirth = Console.ReadLine();

            /*
            char[] firstNameArray = firstName.ToCharArray();
            Array.Reverse(firstNameArray);

            char[] lastNameArray = lastName.ToCharArray();
            Array.Reverse(lastNameArray);

            char[] cityOfBirthArray = cityOfBirth.ToCharArray();
            Array.Reverse(cityOfBirthArray);
            
            foreach (char item in firstNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in lastNameArray)
            {
                result += item;
            }

            result += " ";

            foreach (char item in cityOfBirthArray)
            {
                result += item;
            }

            Console.WriteLine("Your first name is {0} and your last name is {1} and you were born in {2}", firstName, lastName, cityOfBirth);
            Console.WriteLine("Results reversed: " + result);
            */

            Console.Write("Results: ");

            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(cityOfBirth));
            Console.WriteLine();
            DisplayResult(ReverseString(firstName) + " " + ReverseString(lastName) + " " + ReverseString(cityOfBirth));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(
            string reversedFirstName, 
            string reversedLastName, 
            string reversedCityOfBirth)
        {
           Console.Write(String.Format("{0} {1} {2}",
               reversedFirstName,
               reversedLastName,
               reversedCityOfBirth));
        }

        //overloading
        private static void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}
