using System;

namespace OOPExampleExercises
{
    public class Program
    {
        #region Exercise 42 & 43
        //Exercise 42 & 43
        public static void Main(string[] args)
        {
            do 
            {
                try
                {
                    Console.WriteLine("Enter an X coordinate: ");
                    var xCoordinate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter an Y coordinate: ");
                    var yCoordinate = int.Parse(Console.ReadLine());

                    var coordinates = new Point(xCoordinate, yCoordinate);
                    var distance = coordinates.CalculateDistance();


                    Console.WriteLine($"You have created a point object ({coordinates.X},{coordinates.Y}). It has a disance of {distance}");
                    
                    Console.WriteLine("Would you like to try again? (y/n)");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Looks like you entered an invalid input. Would you like to try again? (y/n)");
                }              

            }while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");            
        }
        #endregion

        #region Exercise 45
        /*Exercise 45
        public static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.WriteLine("Enter a side length: ");
                    var sideLength = int.Parse(Console.ReadLine());

                    var square = new Square(sideLength);
                    var area = square.CalculateArea();
                    var perimeter = square.CalculatePerimeter();

                    Console.WriteLine($"The square has a length {square.SideLength}. It's area is {area} and it's perimeter is {perimeter}.");
                    Console.WriteLine("Would you like to try again? (y/n)");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong! Would you like to try again? (y/n)");
                }

            } while (Console.ReadLine().ToUpper() == "Y");
        }
        */
        #endregion
    }
}
