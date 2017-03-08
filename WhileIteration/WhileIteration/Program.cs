using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an Option: ");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit ");
            string optionChosen = Console.ReadLine();

            if (optionChosen == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (optionChosen == "2")
            {
                GuessingGame();
                return true;
            }
            else if (optionChosen == "3")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter a valid option!");
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers!");
            Console.Write("Type a number: ");
            int numberChosen = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter <= numberChosen)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.WriteLine();
            Console.WriteLine("Wasn't that a fun time!");
            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game");
            Random myRandom = new Random();
            int randoNum = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string guess = Console.ReadLine();
                guesses++;
                if (guess == randoNum.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Incorrect Guess!");
                }
            } while (incorrect);

            Console.WriteLine("You Guessed it Correctly!");
            Console.WriteLine("It took you {0} guesses!", guesses);
            Console.ReadLine();
        }
    }
}
