using System;

namespace July30Examples
{
    public class Program
    {

        //Exercise 46
        public static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter the first side length of the triangle:");
                    var sideOneLength = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second side length of the triangle:");
                    var sideTwoLength = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the third side length of the triangle:");
                    var sideThreeLength = int.Parse(Console.ReadLine());

                    var triangle = new Triangle(sideOneLength, sideTwoLength, sideThreeLength);

                    Console.WriteLine($"The triangle has side lengths {sideOneLength}, {sideTwoLength}, {sideThreeLength}. " +
                        $"It's area is {triangle.CalculateArea()} and it's perimeter is {triangle.CalculatePerimeter()}");

                    Console.WriteLine("Would you like to continue? (y/n)");
                }
                catch (Exception)
                {
                    Console.WriteLine("Looks like you entered an invalid input. Would you like to try again? (y/n)");
                }

            } while (Console.ReadLine().ToUpper() == "Y");
            
            Console.WriteLine("Goobye!");
        }
    }
}
