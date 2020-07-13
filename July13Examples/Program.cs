using System;

namespace July13Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercise 18: Prompt the user to enter a number. Use a for-loop to calculate the sum of all the numbers
             * from 1 to the number entered.
             

            var proceed = "";
            do
            {
                Console.WriteLine("Please enter a number:");
                var numInput = Console.ReadLine();
                var isValidNumber = int.TryParse(numInput, out var number);

                if (!isValidNumber)
                {
                    Console.WriteLine("You did not enter a valid number.\nPlease try again.");
                    Console.WriteLine("");
                    proceed = "Y";
                }
                else
                {
                    var sum = 0;
                    for (int i = 0; i <= number; i++)
                    {
                        sum += i;
                    }

                    Console.WriteLine($"The sum from 1-{number} is: {sum}");
                    Console.WriteLine("Would you like to continue? (y/n)");
                    proceed = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }               

            } while (proceed == "Y");
            */

            /*Exercise 19: Prompt the user to enter two numberts. Use a for-loop to calculate the sum
             * of all the numbers from the first nmber entered to the second.
             */
            var proceed = "";
            do
            {
                Console.WriteLine("Please enter a number:");
                var firstNumInput = Console.ReadLine();
                var validFirstNum = int.TryParse(firstNumInput, out var firstNumber);
                Console.WriteLine("Please enter another number greater than the value above:");
                var secondNumInput = Console.ReadLine();
                var validSecondNum = int.TryParse(secondNumInput, out var secondNumber);

                if (!validFirstNum || !validSecondNum)
                {
                    Console.WriteLine("One or more of the values was not a valid number.\nPlease try again.");
                    Console.WriteLine("");
                    proceed = "Y";
                }
                else if(firstNumber >= secondNumber)
                {
                    Console.WriteLine("Your second value wasn't greater than the first value.\nPlease try again.");
                    Console.WriteLine("");
                    proceed = "Y";
                }
                else
                {
                    var sum = 0;
                    for (int i = firstNumber; i <= secondNumber; i++)
                    {
                        sum += i;
                    }

                    Console.WriteLine($"The sum from {firstNumber}-{secondNumber} is: {sum}");
                    Console.WriteLine("Would you like to continue? (y/n)");
                    proceed = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }

            } while (proceed == "Y");
        }
    }
}
