using System;
using System.Collections.Generic;

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
             
            bool proceed;
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
             */




            /*
             * Ternary Operator Example
             * If age is greater or equal to 21, outputs first string. If not, outputs second string. 
             *
             * var oldIsEnough = age >= 21 ? "You are old enough" : "You are not old enough";
             * Console.WriteLine(oldIsEnough);
             */




            /*
             * Foreach loop example
             *
            var numbers = new List<int>
            {
                1, 2, 3, 4, 5
            };

            foreach(var number in numbers)
            {
                if(number == 2)
                {
                    Console.WriteLine("We found the number");
                    break;
                }
                Console.WriteLine(number);
            }
            */


            /*
             * 
             * Exercise 13: Prompt the user for a number. Use a for loop to output all the numbers from that number to 0. Also ask the user if they would like to continue
             */

            bool proceed;
            do
            {
                Console.WriteLine("Please enter a number: ");
                var userInput = Console.ReadLine();
                bool validInput = int.TryParse(userInput, out int num);

                if(!validInput)
                {
                    Console.WriteLine("You didn't enter a valid number");
                }
                else
                {
                    Console.WriteLine("Counting down from your number:");
                    for (int i = num; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                }

                Console.WriteLine("Would you like to to continue? (y/n)");
                string  cont = Console.ReadLine().ToUpper();

                if(cont == "Y")
                {
                    proceed = true;
                }
                else
                {
                    proceed = false;
                }

            } while (proceed == true);
        }
    }
}
