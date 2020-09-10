using System;
using System.Diagnostics;

namespace AlgorithmExamples
{
    public class Program
    {
        static void Main(string[] args)
        {            
            //Exercise72();
            //Exercise73();
            Exercise74();
        }

        public static void Exercise72()
        {
            do
            {
                Console.WriteLine("Please enter a whole number:");
                int userInput = int.Parse(Console.ReadLine());
                var isPrime = DeterminePrimeNumber(userInput);
                if (isPrime)
                {
                    Console.WriteLine($"{userInput} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{userInput} is not prime number.");
                }
            } while (ContinueProgram());
            Console.WriteLine("Goodbye!");
        }

        public static void Exercise73()
        {
            Console.WriteLine("Here are the first 100 prime numbers: ");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            OutputListOfPrimeNumbers(100);
            watch.Stop();
            Console.WriteLine("");
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms\n");
        }

        public static void Exercise74()
        {
            Console.WriteLine("Here are the first 500 prime numbers: ");
            var watch = new Stopwatch();
            watch.Start();
            OutputListOfPrimeNumbers(500);
            watch.Stop();
            Console.WriteLine("");
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms\n");
        }

        public static void OutputListOfPrimeNumbers(int number)
        {
            var count = 0;
            for(int i = 0; count < number; i++)
            {                 
                var isPrime = DeterminePrimeNumber(i);
                if (isPrime && count != number-1)
                {
                    Console.Write($"{i}, ");
                    count++;
                }
                else if (isPrime && count == number-1)
                {
                    Console.Write($"{i}");
                    count++;
                }
            }
        }

        public static bool DeterminePrimeNumber(int number)
        {
            do
            {
                var flag = 0;                
                var m = number / 2;
                if (number == 0 || number == 1)
                {
                    return false;
                }
                else
                {
                    for (int i = 2; i <= m; i++)
                    {
                        if (number % i == 0)
                        {
                            return false;
                        }
                    }
                    if (flag == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }                         
            } while (ContinueProgram());            
        }        

        public static bool ContinueProgram()
        {
            while (true)
            {
                Console.WriteLine("\nWould you like to continue? (y/n)");
                var input = Console.ReadLine().ToUpper();

                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You didn't enter a 'Y' or 'N'");
                }
            };
        }
    }
}
