using System;
using System.Text;

namespace July15Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Old way to concatenate

            Console.WriteLine("Hi " + "I'm " + "Ada");
            Console.WriteLine("");
            #endregion

            #region Concatenantion
            
            var somethingFunky = string.Concat("Hi", " Ada");
            Console.WriteLine(somethingFunky);
            Console.WriteLine("");
            #endregion

            #region String interpolation --> new
            
            Console.WriteLine($"{somethingFunky} I'm an example program");
            Console.WriteLine("");
            #endregion

            #region Split
            
            var sentence = "Hello, my name is Ada";
            var phrase = sentence.Split(' ');
            Console.WriteLine("Using foreach loop");
            foreach (var section in phrase)
            {
                Console.WriteLine(section);
            }
            Console.WriteLine("");

            Console.WriteLine("Using for loop");
            for (int i = 0; i < phrase.Length; i++)
            {
                Console.WriteLine($"Index{i}: {phrase[i]}");
            }
            Console.WriteLine("");
            #endregion

            #region Whitespace Example
            
            var whitespace = "     hello, this is Ada     ";
            Console.WriteLine($"Whitespace string: {whitespace}");
            Console.WriteLine($"This is the trimmed version:{whitespace.Trim()}");
            Console.WriteLine("");
            #endregion

            #region Indexof - Returns integer of the value for where that string segments starts

            var multiTeacher = "Corey Koehler Darion Thompson";
            var firstIndex = multiTeacher.IndexOf("Darion");
            var secondIndex = multiTeacher.IndexOf("Koehler");
            Console.WriteLine($"'Darion' starts at index {firstIndex}");
            Console.WriteLine($"'Koehler' starts at index {secondIndex}");
            Console.WriteLine("");
            #endregion

            #region String Comparison
          
            Console.WriteLine("Enter something:");
            var userInput = Console.ReadLine();
            if (userInput.Equals("CORY",StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Hey, your input is equal to 'CORY'");
            }
            else
            {
                Console.WriteLine("Hey, your input is not equal to 'CORY'");
            }
            Console.WriteLine("");
            #endregion

            #region String Builder
            
            var stringBuilder = new StringBuilder("Darion is teaching");
            stringBuilder.Append(" this class");
            Console.WriteLine(stringBuilder);
            Console.WriteLine("");
            #endregion
        }
    }
}
