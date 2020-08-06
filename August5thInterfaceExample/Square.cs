using System;
using System.Collections.Generic;
using System.Text;

namespace August5thInterfaceExample
{
    public class Square : IShape
    {
        public double NumberOfSides { get ; set; }

        public double Length { get; set; }

        public double Height { get; set; }

        public Square(double length, double height)
        {
            Length = length;
            Height = height;
            NumberOfSides = 4;
        }

        public double CalculateArea()
        {
            return Length * Height;
        }
    }
}
