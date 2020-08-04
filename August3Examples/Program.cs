using System;
using System.Collections.Generic;

namespace August3Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Shape Tester!\n");

            do
            {
                try
                {
                    Console.WriteLine("Enter the radius of the circle: ");
                    var radius = double.Parse(Console.ReadLine());

                    var circle = new Circle(radius);
                    Console.WriteLine($"The circle with radius {radius} has an area of {circle.CalculateArea()}");


                    Console.WriteLine("\nEnter the length of the first side of the triangle: ");
                    var sideLengthOne = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nEnter the length of the second side of the triangle: ");
                    var sideLengthTwo = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nEnter the length of the third side of the triangle: ");
                    var sideLengthThree = double.Parse(Console.ReadLine());

                    var triangle = new Triangle(sideLengthOne, sideLengthTwo, sideLengthThree);
                    Console.WriteLine($"The triangle with the length of {sideLengthOne}, {sideLengthTwo} and {sideLengthThree} has an area of {triangle.CalculateArea()}");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }               
            } while (ContinueProgram());
        }

        public static bool ContinueProgram()
        {
            while (true)
            {
                Console.WriteLine("\nWould you like to continue? (y/n)");
                var input = Console.ReadLine().ToUpper();

                if (input == "Y")
                {
                    return true;
                }
                else if (input == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You didn't enter a 'Y' or 'N'");
                }
            };
        }
    }
}