using System;

namespace Assessment1a
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"'a' is a vowel: {IsVowel('a')}");
            Console.WriteLine($"'b' is a vowel: {IsVowel('b')}");
            Console.WriteLine($"The word 'pokemon' has {CountVowels("pokemon")} vowels");
            Console.WriteLine($"The word 'good' has {TooManyVowels("good")}");
            Console.WriteLine($"The word 'queueing' has {TooManyVowels("queueing")}");
            Console.WriteLine($"The word 'supercalifragilisticexpialidocious' has {TooManyVowels("supercalifragilisticexpialidocious")}");
        }

        public static bool IsVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int CountVowels(string word)
        {
            int numVowels = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach(char letter in word)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    numVowels++;
                }
            }
            return numVowels;
        }

        public static string TooManyVowels(string word)
        {
            int numVowels = CountVowels(word);
            if(numVowels <= 4)
            {
                return "few vowels";
            }
            else if(numVowels >= 5 && numVowels <= 7)
            {
                return "right amount of vowels";
            }
            else 
            {
                return "too many vowels";
            }
        }
    }
}
