using System;

namespace August5thInterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(3);
            Console.WriteLine($"A circle with an radius of 3 has an area of {circle.CalculateArea()}. It has {circle.NumberOfSides} sides.");

            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"A triangle with side lengths of 3, 4, and 5 has an area of {triangle.CalculateArea()}. It has {triangle.NumberOfSides} sides.");

            var square = new Square(2, 3);
            Console.WriteLine($"A square with side lengths of 2 and 3 has an area of {square.CalculateArea()}. It has {square.NumberOfSides} sides.");

            var hexagon = new RegularHexagon(5);
            Console.WriteLine($"A regular hexagon with side lengths 5 has an area of {hexagon.CalculateArea()}. It has {hexagon.NumberOfSides} sides.");
        }
    }
}
