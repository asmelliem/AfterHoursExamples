using System;
using System.Collections.Generic;
using System.Linq;

namespace September2ndExamples
{
    public class Program
    {
        static void Main(string[] args)
        {            
            do
            {
                Exercise68();
            } while (ContinueProgram());
            Console.WriteLine("Goodbye!");

            var result = ReturnTuple();
            if(!result.success)
            {
                throw result.exception;
            }
        }

        public static void Exercise68()
        {
            var spanishDictionary = new Dictionary<string, string>() 
            { 
                { "hello", "hola" }, 
                { "food", "comida" }, 
                { "world", "mundo" }, 
                { "computer", "computadora" }, 
                { "exercise", "ejercicio" } 
            };

            Console.WriteLine("Enter a word in English: ");
            var englishInput = Console.ReadLine();
            var spanishTranslationSuccess = spanishDictionary.TryGetValue(englishInput.ToLower(), out string spanishTranslation);
            if(spanishTranslationSuccess)
            {
                Console.WriteLine($"{englishInput} in Spanish is {spanishTranslation}");
            }
            else
            {
                Console.WriteLine("We don't have the translation in our dictionary yet.");
            }
        }

        public static (bool success, int number, Exception exception) ReturnTuple()
        {
            return (true, 1, null);
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
