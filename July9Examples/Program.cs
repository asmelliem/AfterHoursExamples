using System;

namespace July9Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Example showing conversion using TryParse() and the use of if-else statements
             * 
            Console.WriteLine("How old are you?");
            var userInput = Console.ReadLine();
            bool success = int.TryParse(userInput, out int number);

            if (!success)
            {
                Console.WriteLine("Invalid entry");
            }
            else if (number >= 21)
            {
                Console.WriteLine("Hey what drink will you have?");
            }
            else 
            {
                Console.WriteLine("Hey you are too young...get outta here...");
            }
            */


            /*
             * Exercise: Create an application that takes the users age, and evaluate if the user is old enough to drive.
             */
            bool proceed = false;
            do
            {
                Console.Write("How old are you? ");
                var userInput = Console.ReadLine();
                bool validInput = float.TryParse(userInput, out float age);

                if (!validInput)
                {
                    Console.WriteLine("You didn't enter a number!");
                    Console.WriteLine("");
                    proceed = true;
                }
                else if (age >= 14.75)
                {
                    Console.WriteLine("Congrats! You're allowed to drive");
                    proceed = false;
                }
                else
                {
                    Console.WriteLine("Sorry, you can't really drive yet.");
                    proceed = false;
                }
            } while (proceed == true);

           

        }                             
    }
}
