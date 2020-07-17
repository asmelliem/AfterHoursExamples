using System;
using System.Linq;
using System.Text;

namespace Exercise25Through29
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Exercise 25
            /*
             * Exercise 25
             * Prompt the user to enter a sentence. 
             * Split the sentence into individual words and display eachword on its own line.
             
            do
            {
                Console.WriteLine("Enter a sentence: ");
                var sentence = Console.ReadLine();
                Console.WriteLine(BreakUpSentence(sentence).ToString());            
                Console.WriteLine("Would you like to continue? (y/n)");

            }while(Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
            */
            #endregion

            #region Exercise 26
            /*
            * Exercise 26
            * Prompt the user to enter text. Count and output how many vowels were in the string.
            
            do
            {
                Console.WriteLine("Enter some text: ");
                var input = Console.ReadLine().ToLower();
                var sentence = input.ToCharArray();
                var vowelCount = DetermineNumberOfVowels(sentence);
                
                Console.WriteLine($"There are {vowelCount} vowels in {input}");

                Console.WriteLine("Would you like to continue? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
            */
            #endregion

            #region Exercise 27
            /*
            * Exercise 27
            * Prompt the user to enter text. Count and output how many consonants were in the string.
            
            do
            {
                Console.WriteLine("Enter some text: ");
                var input = Console.ReadLine().ToLower();
                var sentence = input.ToCharArray();
                var consonantCount = DetermineNumberOfConsonants(sentence);
                
                Console.WriteLine($"There are {consonantCount} consonants in {input}");

                Console.WriteLine("Would you like to continue? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
            */
            #endregion

            #region Exercise 28
            /*
             * Exercise 28
             * Prompt the user to enter text. Remove all the vowels and output the text.
             
            do
            {
                Console.WriteLine("Enter some text: ");
                var input = Console.ReadLine().ToLower();
                var sentence = input.ToCharArray();
                var result = RemoveVowels(sentence);
                
                Console.WriteLine($"Your word, {input}, without vowels is {result}");

                Console.WriteLine("Would you like to continue? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");   
           */
            #endregion
            
        }

        public static StringBuilder BreakUpSentence(string sentence)
        {
            var words = sentence.Split(' ');
            var result = new StringBuilder("");
            foreach (var word in words)
            {
                result.Append($"{word}\n");
            }
            return result;
        }

        public static int DetermineNumberOfVowels(char[] sentence)
        {
            var vowelCount = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (var letter in sentence)
            {                
                if(vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }

        public static int DetermineNumberOfConsonants(char[] sentence)
        {
            var consonantCount = sentence.Length;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

            foreach (var letter in sentence)
            {                
                if(vowels.Contains(letter))
                {
                    consonantCount--;
                }
            }
            return consonantCount;
        }       

        public static string RemoveVowels(char [] sentence)
        {
            var result = new StringBuilder("");
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (var letter in sentence)
            {
               if(!vowels.Contains(letter))
                {
                    result.Append(letter);
                }
            }
            return result.ToString();
        }

    }
}
