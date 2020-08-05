using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Square : Shape
    {
        public override double Length { get; set; }
        public override double Height { get; set; }

        public override int NumberOfSides { get; set ; }

        public Square(double length, double height)
        {
            Length = length;
            Height = height;
            NumberOfSides = 4;
        }

        public override double CalculateArea()
        {
            return Length * Height;
        }

        public override string WriteNumberOfSides()
        {
            return "It has 4 sides";
            
        }
    }
}
