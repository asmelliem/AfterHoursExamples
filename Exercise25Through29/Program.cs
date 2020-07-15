using System;

namespace Exercise25Through29
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*
             * Exercise 25
             * Prompt the user to enter a sentence. 
             * Split the sentence into individual words and display eachword on its own line.
             
            do
            {
                Console.WriteLine("Enter a sentence: ");
                var sentence = Console.ReadLine();

                string[] words = sentence.Split(' ');
                foreach (var word in words)
                {
                   Console.WriteLine($"{word}");
                }

                Console.WriteLine("Would you like to continue? (y/n)");

            }while(Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
            */

            do
            {
                Console.WriteLine("Enter a sentence: ");
                var input = Console.ReadLine().ToLower();
                var sentence = input.ToCharArray();
                var vowelCount = DetermineNumberOfVowels(sentence);
                

                Console.WriteLine($"There are {vowelCount} vowels in {input}");

                Console.WriteLine("Would you like to continue? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");

        }

        public static int DetermineNumberOfVowels(char [] sentence)
        {
            var vowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (var letter in sentence)
            {
                foreach (var character in vowels)
                {
                    if (letter.Equals(character))
                    {
                        vowelCount++;
                    }
                }

            }

            return vowelCount;
        }
    }
}
