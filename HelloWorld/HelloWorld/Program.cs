using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "James";
            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Yo Yo World!");
            Console.WriteLine(name);
            Console.WriteLine(name + " " + lastname);
            Console.ReadLine();
        }
    }
}
