using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*How to define the length of the array
            int[] numbers = new int[5];

            numbers[0] = 6;
            numbers[1] = 26;
            numbers[2] = 16;
            numbers[3] = 34;
            numbers[4] = 78;
            */

            //this will have the compiler figure out the length

            int[] numbers = new int[] { 4, 8, 9, 10, 12 };

            string[] names = new string[] { "James", "Paul", "Kenn", "Rock Stars" };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            //take a string and convert it into an array of characters
            string quote = "Keep It Simple Stupid";
            char[] quoteArray = quote.ToCharArray();
            Array.Reverse(quoteArray);

            foreach (char letter in quoteArray)
            {
                Console.Write(letter);
            }

            Console.ReadLine();

        }
    }
}
