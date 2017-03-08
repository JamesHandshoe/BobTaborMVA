using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesandTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            /******How to get time / date formatted with prebuilt methods*******/
            /*
            Console.WriteLine(myValue.ToString());
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToShortTimeString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToLongTimeString());
            */

            /***************Date / Time Manipulation******************/
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());
            Console.WriteLine("*********************************");
            //pulls off the month
            Console.WriteLine(myValue.Month);

            Console.WriteLine("*********************************");

            //Year, Month, Day
            DateTime myBirthday = new DateTime(1980, 7, 13);
            Console.WriteLine(myBirthday.ToShortDateString());
            Console.WriteLine("*********************************");

            DateTime newBirthday = DateTime.Parse("7/13/1980");
            TimeSpan myAge = DateTime.Now.Subtract(newBirthday);

            Console.WriteLine(myAge.TotalDays / 365);
            Console.ReadLine();
        }
    }
}
