using System;

namespace July23Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            int[] arrayTwo = new int [] { 1, 2, 3, 4, 5 };

            Console.WriteLine("This is arrayTwo:");
            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.WriteLine(arrayTwo[i]);
            }

            int[] arrayThree = { 5, 4, 3, 2, 1 };

            Console.WriteLine("This is arrayThree:");
            foreach(int num in arrayThree)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Nested Array:");
            var nestedArrays = GetNestedArray();
            PrintNestedArrays(nestedArrays);
            */

            do
            {
                int[] numInput = GetUserInput();
                Console.WriteLine($"The sum your previously entered numbers is: {CalculateSum(numInput)}");
                Console.WriteLine($"The average your previously entered numbers is: {CalculateAverage(numInput)}");
                Console.WriteLine("Would you like to continue? (y/n)");

            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
        }

        public static int CalculateSum(int[] numInput)
        {
            int sum = 0;
            for (int i = 0; i < numInput.Length; i++)
            {
                sum += numInput[i];
            }
            return sum;
        }

        public static double CalculateAverage(int [] numInput)
        {
            double sum = Convert.ToDouble(CalculateSum(numInput));
            double average = sum / numInput.Length;
            return average;
        }

        public static int [] GetUserInput()
        {
            int[] numInput = new int[5];
            Console.WriteLine("Please enter 5 numbers to calculate the sum of the numbers.\n");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                numInput[i] = int.Parse(Console.ReadLine());
            }

            return numInput;
        }

        public static void PrintNestedArrays(int[][] nestedArrays)
        {
            Console.WriteLine("Printed array using for loop:");
            for (int i = 0; i < nestedArrays.Length; i++)
            {
                for (int j = 0; j < nestedArrays[i].Length; j++)
                {
                    Console.WriteLine(nestedArrays[i][j]);
                }
            }

            Console.WriteLine("Printed array using foreach loop:");
            foreach (int[] array in nestedArrays)
            {
                foreach(int num in array)
                {
                    Console.WriteLine(num);
                }
            }
        }

        public static int[][] GetNestedArray()
        {
            int[][] nestedArray = new[]
            {
                      //J  0, 1, 2, 3, 4
                new int[] {1, 2, 3, 4, 5},              //i 0
                new int[] {6, 7, 8, 9, },               //i 1
                new int[] {10, 11, 12, 13, 14, 15}      //i 2
            };

            return nestedArray;
        }

        

    }
}
