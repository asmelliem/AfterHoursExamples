using August10_FileIO.Exercise67;
using System;
using System.Collections.Generic;
using System.IO;

namespace August10_FileIO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ClassExample();   
            string filePath = @"C:\Users\alam\Source\Repos\After Hours - GC\AfterHoursExamples\August10_FileIO\";
            Example67(filePath);         
            //Example68(filePath);

        }        

        public static void Example67(string filePath)
        {
            do
            {
                Console.WriteLine("Enter a file to read numbers from:");
                var fileName = Console.ReadLine();
                var numbers = Exercise67Utility.ReadFile(filePath + fileName);
                PrintSum(numbers);
            } while (ContinueProgram());

            Console.WriteLine("Goodbye!");
        }

        public static void Example68(string filePath)
        {
            do
            {

                Console.WriteLine("Enter a file to read translations from:");
                var fileName = Console.ReadLine();
                var translations = Exercise67Utility.CreateDictionary(filePath + fileName);

                Console.WriteLine("Enter a word in English:");
                var key = Console.ReadLine();

                if (translations.TryGetValue(key, out var result))
                {
                    Console.WriteLine($"{key} in Spanish is {result}");
                }
                else
                {
                    Console.WriteLine($"{key} cannot be translated.");
                }
            } while (ContinueProgram());

            Console.WriteLine("Goodbye!");

        }

        public static bool ContinueProgram()
        {            
            while (true)
            {
                Console.WriteLine("Would you like to continue (y/n)");
                var proceed = Console.ReadLine();
                if (proceed.ToUpper() == "Y")
                {
                    return true;
                }
                else if (proceed.ToUpper() == "N")
                {
                    return false;
                }
                else 
                {
                    Console.WriteLine("You did not enter 'y' or 'n'");
                }
            }
        }

        public static void PrintSum(List<int> numbers)
        {
            var sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count - 1)
                {
                    Console.Write($"{numbers[i]} + ");
                }
                else
                {
                    Console.Write($"{numbers[i]} = ");
                }

                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }

        public static void ClassExample()
        {
            string fileOne = @"C:\Users\alam\Source\Repos\After Hours - GC\AfterHoursExamples\August10_FileIO\ExampleFile.txt";
            string fileTwo = @"C:\Users\alam\Source\Repos\After Hours - GC\AfterHoursExamples\August10_FileIO\ExampleFile2.txt";
            //Create
            FileUtility.CreateFile(fileOne);

            //Initial Write            
            FileUtility.ModifyFile(fileOne, false);

            //Read
            FileUtility.ReadFromFile(fileTwo);

            var linesOfInput = new List<string>
            {
                "Penguins are great",
                "Hello world!",
                "I'm sleepy"
            };
            //Modify
            FileUtility.ModifyFile(fileOne, true, linesOfInput);

            //Delete
            FileUtility.DeleteFile(fileOne);
        }
    }
}