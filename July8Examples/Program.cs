using System;

namespace July8Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercise 1 Description:
             * Prompt the user to enter a string. After the user enters a string, output the same string back to the console.
             */
            Console.WriteLine("Enter a string:");
            var input = Console.ReadLine();
            Console.WriteLine("You entered the string: " + input);
            Console.WriteLine("");


            /*
             * Exercise 2 Description:
             * Prompt the user to enter a number. After the user enters a number, add 1 to the number and output it back to the console.
             */
            Console.WriteLine("Enter a number:");
            var userInput = Console.ReadLine();
            var isInt = int.TryParse(userInput, out int userInputAsInt);
            if (!isInt)
            {
                Console.WriteLine("You didn't input a number!");
            }
            userInputAsInt++;
            Console.WriteLine("Your number + 1 is: " + userInputAsInt);
            Console.WriteLine("");


            /*
            * Exercise 3 Description:
            * Prompt the user to enter a number. After the user enters a number, add .5 to the number and output it back to the console.
            */
            Console.WriteLine("Enter a number:");
            var userInputThree = Console.ReadLine();
            var isDecimal = decimal.TryParse(userInputThree, out decimal userInputAsDecimal);
            if (!isDecimal)
            {
                Console.WriteLine("You didn't input a number!");
            }
            userInputAsDecimal += 0.5m;
            Console.WriteLine("Your number + 0.5 is: " + userInputAsDecimal);
            Console.WriteLine("");


            /*
           * Exercise 4 Description:
           * Prompt the user to enter two numbers. After the user enters the numbers, add them together and output the sum back to the console.
           */
            Console.WriteLine("Enter 2 numbers:");
            var firstUserInput = Console.ReadLine();
            var secondUserInput = Console.ReadLine();
            var firstIsFloat = float.TryParse(firstUserInput, out float firstInputAsFloat);
            var secondIsFloat = float.TryParse(secondUserInput, out float secondtInputAsFloat);
            if (!firstIsFloat || !secondIsFloat)
            {
                Console.WriteLine("You didn't input a number!");
            }
            float sum = firstInputAsFloat + secondtInputAsFloat;
            Console.WriteLine($"{firstInputAsFloat} + {secondtInputAsFloat} = {sum}");
            Console.WriteLine("");
        }
    }
}

