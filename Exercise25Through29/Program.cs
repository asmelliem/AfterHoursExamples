using System;

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
                Console.WriteLine(BreakUpSentence(sentence));             

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
            */
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
            #endregion
        }

        public static string BreakUpSentence(string sentence)
        {
            string[] words = sentence.Split(' ');
            var result = "";
            foreach (var word in words)
            {
                result += $"{word}\n";
            }
            return result;
        }

        public static int DetermineNumberOfVowels(char[] sentence)
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

        public static int DetermineNumberOfConsonants(char[] sentence)
        {
            var consonantCount = sentence.Length;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (var letter in sentence)
            {
                foreach (var character in vowels)
                {
                    if (letter.Equals(character))
                    {
                        consonantCount--;
                    }
                }
            }
            return consonantCount;
        }       

        public static string RemoveVowels(char [] sentence)
        {
            var result = "";
            foreach (var letter in sentence)
            {
               if(letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u')
                {
                    result += letter;
                }
            }
            return result;
        }
    }
}
