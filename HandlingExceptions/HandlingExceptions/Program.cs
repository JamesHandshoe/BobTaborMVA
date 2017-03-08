using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Temp\Example.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("This problem occurred: " + ex.Message);
                Console.WriteLine("Make sure the file is named correctly");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("This problem occurred: " + ex.Message);
                Console.WriteLine("Make sure the path is correct and directory is available");
            }
            catch (Exception ex)
            {
                Console.WriteLine("This problem occurred: " + ex.Message);
            }
            finally
            {
                //Any code to finalize
                //Setting objects to null
                //Closing DB connections
                Console.WriteLine("Closing application now...");
            }
            Console.ReadLine();

        }
    }
}
