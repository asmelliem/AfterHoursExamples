using System;
using System.Linq;

namespace Week4Exercises
{

    public static class Extensions
    {
        public static int FindIndex<T>(this T[] array, T item)
        {
            return Array.IndexOf(array, item);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 2, 8, 0, 24, 51 };
            do
            {
                //Exercise30();
                //Exercise31();
                //Exercise32();
                //Exercise33(numbers);
                Exercise35();
                Console.WriteLine("Would you like to continue (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
           
        }

        public static void Exercise30()
        {
            Console.WriteLine("Enter some text:");
            char[] text = Console.ReadLine().ToCharArray();
            Array.Reverse(text, 0, text.Length);
            foreach(var letter in text)
            {
                Console.Write(letter);
            }
        }

        public static void Exercise31()
        {
            try 
            {
                int[] numbers = { 2, 8, 0, 24, 51 };
                Console.WriteLine("Enter an index of the array:");
                bool validInput = int.TryParse(Console.ReadLine(), out int index);
                if (validInput)
                {
                    Console.WriteLine($"The value at index {index} is {numbers[index]}");
                }
                else
                {
                    Console.WriteLine("You didn't type a number.");

                }
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Looks like you chose an index that is out of range.");    
            }
            catch(Exception)
            {
                Console.WriteLine("Looks like something went wrong.");
            }
            
            
        }

        public static void Exercise32()
        {
            int[] numbers = { 2, 8, 0, 24, 51 };

            Console.WriteLine("Enter a number:");
            bool validInput = int.TryParse(Console.ReadLine(), out int number);
            var index = numbers.FindIndex(number);

            if (validInput)
            {
                if (numbers.Contains(number))
                {
                    Console.WriteLine($"The value {number} can be found at index {index}");
                }
                else
                {
                    Console.WriteLine("That value cannot be found in the array.");   
                }
            }
            else
            {
                Console.WriteLine("You did not put in a valid input.");
            }

        }

        public static void Exercise33(int [] numbers)
        {
            

            Console.WriteLine("Enter an index of the array: ");
            bool validInput = int.TryParse(Console.ReadLine(), out int index);
            bool validIndex = (index >= 0 && index < numbers.Length);

            if(validInput)
            {
                if(validIndex)
                {
                    Console.WriteLine($"The value at index {index} is {numbers[index]}. Would you like to change it (y/n)?");
                    if(Console.ReadLine().ToUpper() == "Y")
                    {
                        Console.WriteLine($"Enter a new value at index {index}:");
                        validInput = int.TryParse(Console.ReadLine(), out int newValue);

                        if(validInput)
                        {
                            numbers[index] = newValue;
                        }
                        else
                        {
                            Console.WriteLine("You didn't put in a valid number.");
                        }
                    }    
                    
                }
                else 
                {
                    Console.WriteLine("Looks like you entered an invalid index");
                }
            }
            else
            {
                Console.WriteLine("You put in an invalid input.");
            }

        }

        public static void Exercise35()
        {
            string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };

            Console.WriteLine("Enter two indices: ");
            string [] input = Console.ReadLine().Split(' ');
            int[] index = input.Select(int.Parse).ToArray();
            var animal = animals[index[0]];
            var letter = animal.ToString().ElementAt(index[1]);

            Console.WriteLine($"The value at index {index[0]} is {animal}. The letter at index {index[1]} is {letter}");

        }

        
    }
}
