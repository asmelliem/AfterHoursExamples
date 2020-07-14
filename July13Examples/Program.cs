using System;

namespace July13Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Exercise 19: Prompt the user to enter two numberts. Use a for-loop to calculate the sum
            * of all the numbers from the first nmber entered to the second.
            
            var exercise = new Exercise19();
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
                else if (firstNumber >= secondNumber)
                {
                    Console.WriteLine("Your second value wasn't greater than the first value.\nPlease try again.");
                    Console.WriteLine("");
                    proceed = "Y";
                }
                else
                {
                    //version one using method below versus another class
                    //var sum = SumUserInputs(firstNumber, secondNumber);
                    var sum = Exercise19.SumUserInputs(firstNumber, secondNumber);
                    Console.WriteLine($"The sum from {firstNumber}-{secondNumber} is: {sum}");
                    Console.WriteLine("Would you like to continue? (y/n)");
                    proceed = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }
            } while (proceed == "Y");
            */


            /*
             * Example using methods
             *
            Add(5, 5);

            var accessorService = new AccessorService();
            var result = accessorService.ShowGreeting();
            foreach (var greeting in result)
            {
                Console.WriteLine(greeting);
            }
            accessorService.SomeProperty = "5";
            */


            /*
             * Exercise 18: Prompt the user to enter a number. Use a for-loop to calculate the sum of all the numbers
             * from 1 to the number entered.             
             */

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

                    var sum = SumUserInputs(number);
                    Console.WriteLine($"The sum from 1-{number} is: {sum}");
                    Console.WriteLine("Would you like to continue? (y/n)");
                    proceed = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                }

            } while (proceed == "Y");
        }

        public static int SumUserInputs(int valueOne)
        {
            var sum = 0;
            for (int i = 1; i <= valueOne; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static int SumUserInputs(int valueOne, int valueTwo)
        {
            var sum = 0;
            for (int i = valueOne; i <= valueTwo; i++)
            {
                sum += i;
            }
            return sum;
        }

        public static void Add(int value, int valueTwo)
        {
            var addition = value + valueTwo;
            Console.WriteLine(addition);
        }
    }
}
