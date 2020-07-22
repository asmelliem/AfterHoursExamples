using System;
using System.Text;

namespace Week3Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Exercise 21
            /*
             * Exercise 21
             * Prompt the user to enter a series of words. Once the user is done entering the words, 
             * output a sentence containing all the words.
             */
            do
            {
                Console.WriteLine($"Your combined sentence is: {SentenceBuilder()}");
                Console.WriteLine("\nWould you like to enter another word? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");
            
            #endregion
        }
        public static StringBuilder SentenceBuilder()
        {
            StringBuilder sentence = new StringBuilder("");

            do
            {
                Console.WriteLine("Enter a word: ");
                sentence.Append($"{Console.ReadLine()} ");
                Console.WriteLine("Would you like to create another sentence? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            return sentence;
        }
    }
}
