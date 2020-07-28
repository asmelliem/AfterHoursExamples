using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace July27Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Exercise34();
            //Exercise36();
            //Exercise47();
            Exercise48();
            //DictionaryExample();            
            //EnumerableExample();
                    
        }

        public static void Exercise34()
        {
            int[] numbers = { 16, 32, 64, 128, 256 };
            do
            {

                Console.WriteLine("Enter a command (half/double): ");
                var input = Console.ReadLine().ToLower();

                if (input == "half")
                {
                    Console.WriteLine(PrintResult(HalfArrayValues(numbers)));
                }
                else if (input == "double")
                {
                    Console.WriteLine(PrintResult(DoubleArrayValues(numbers)));
                }
                else
                {
                    Console.WriteLine("You didn't enter a valid input.");
                }
                Console.WriteLine("Would you like to continue? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
        }

        public static void Exercise36()
        {
            int[] num = { 12, 11, 10, 9, 8 };
            string[] words = { "Drummers Drumming", "Pipers Piping", "Lords a-leaping", "Ladies Dancing", "Maids a-Milking" };
            
            Console.WriteLine("Enter a command (sing/quit): ");
            if(Console.ReadLine().ToLower() == "sing")
            {
                do
                {
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.WriteLine($"{num[i]} {words[i]}");
                    }

                    Console.WriteLine("Enter a command (sing/quit): ");

                } while (Console.ReadLine().ToLower() == "sing");
            }
            
            Console.WriteLine("Goodbye!"); 
        }

        public static void Exercise47()
        {
            /*var stringList = new List<string>() { "Jason" };
            stringList.Add("Cory");
            stringList.Add("Jason says hi");
            //linq where it returns anything in the collection that contains "Jason"
            var result = stringList.Where(entry => entry.Contains("Jason"));            
            var userInput = Console.ReadLine();
            */
            var sentence = new List<string>();

            do
            {                
                Console.WriteLine("Enter some text: ");
                sentence.Add(Console.ReadLine());
                Console.WriteLine($"You have entered: {(OutputList(sentence))}");
                Console.WriteLine("Would you like to continue (y/n)");

            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine("Goodbye!");
        }

        public static void Exercise48()
        {            
            do
            {
                var numList = new List<int>();
                var input = "";

                do
                {
                    Console.WriteLine("Enter a number (q to quit): ");
                    input = Console.ReadLine();
                    bool validInput = int.TryParse(input, out int number);

                    if (validInput)
                    {
                        numList.Add(number);
                    }
                    else if (input.ToLower() == "q")
                    {
                        Console.WriteLine(ReturnSum(numList));
                    }
                    else
                    {
                        Console.WriteLine("You didn't put in a valid input. Please try again.");
                        continue;
                    }

                } while (input != "q");

                Console.WriteLine("Would you like to continue? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!"); 
        }

        public static void EnumerableExample()
        {
            var listOfNames = new List<string> { "Ada", "Tashi", "Lily", "Rachel", "Lola", "Layal", "John", "Randy", "Johnny", "Johnathon" };
            IEnumerable<string> namesStartingWithL = listOfNames.Where(name => name.StartsWith("L"));
            IEnumerable<string> namesContainingJohn = listOfNames.Where(name => name.Contains("John"));

            Console.WriteLine("Showing list of names that start with L:");
            foreach (string name in namesStartingWithL)
            {
                Console.WriteLine(name);
            }            

            Console.WriteLine("List names that contain 'John'");
            foreach (string name in namesContainingJohn)
            {
                Console.WriteLine(name);
            }
        }

        public static StringBuilder ReturnSum(List <int> numberList)
        {
            IEnumerable<int> numbers = numberList;
            StringBuilder sumResult = new StringBuilder();
            var sum = 0;

            for(int i = 0; i < numbers.Count(); i++)
            {
                if (i < numbers.Count() - 1)
                {
                    sumResult.Append($"{numbers.ElementAt(i)} + ");
                }
                else
                {
                    sumResult.Append($"{numbers.ElementAt(i)} = ");
                }

                sum += numbers.ElementAt(i);
            }

            sumResult.Append(sum);

            return sumResult;
        }

        public static StringBuilder OutputList(List <string> sentence)
        {
            StringBuilder completeSentence = new StringBuilder();

            foreach(var word in sentence)
            {
                completeSentence.Append($"{word} ");
            }

            return completeSentence;
        }

        public static int [] HalfArrayValues(int [] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] / 2;
            }
            return numbers;
        }

        public static int [] DoubleArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
            }
            return numbers;
        }

        public static StringBuilder PrintResult(int[] numbers)
        {
            StringBuilder result = new StringBuilder("The array now contains: ");

            foreach (int num in numbers)
            {
                result.Append($" {num},");
            }
            return result;
        }

        public static void DictionaryExample()
        {
            var dictionaryForUserInput = new Dictionary<int, string>() { { 0, "Sandy" }, { 1, "Bernard" } };
            dictionaryForUserInput.Add(2, "Shari");
            dictionaryForUserInput.TryGetValue(1, out var foundValue);
            var bernardKey = dictionaryForUserInput.First(entry => entry.Value.Contains("Bernard")).Key;
            Console.WriteLine($"We found {foundValue}");
            Console.WriteLine(bernardKey);

            foreach (var entry in dictionaryForUserInput)
            {
                if (entry.Value.Contains("Bernard"))
                {
                    var bernardKeyInLoop = entry.Key;
                    Console.WriteLine(bernardKeyInLoop);
                }
            }
        }

    }
}
