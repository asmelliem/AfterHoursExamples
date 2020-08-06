using System;
using System.Collections.Generic;
using System.Text;

namespace August5thInterfaceExample
{
    public class Triangle : IShape
    {
        public double NumberOfSides { get ; set; }

        public double SideOneLength { get; set; }

        public double SideTwoLength { get; set; }

        public double SideThreeLength { get; set; }

        public Triangle(double sideOneLength, double sideTwoLength, double sideThreeLength)
        {
            SideOneLength = sideOneLength;
            SideTwoLength = sideTwoLength;
            SideThreeLength = sideThreeLength;
            NumberOfSides = 3;
        }

        public double CalculatePerimeter()
        {
            return SideOneLength + SideTwoLength + SideThreeLength;
        }

        public  double CalculateArea()
        {
            var halfPerimeter = CalculatePerimeter() / 2;
            return (double)Math.Sqrt(halfPerimeter * (halfPerimeter - SideOneLength) * (halfPerimeter - SideTwoLength) * (halfPerimeter - SideThreeLength));
        }
    }
}
