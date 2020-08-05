using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Triangle: Shape
    {
        public double SideOneLength { get; set; }

        public double SideTwoLength { get; set; }

        public double SideThreeLength { get; set; }

        public override int NumberOfSides { get; set; }

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

        public override double CalculateArea()
        {
            var halfPerimeter = CalculatePerimeter() / 2;
            return (double)Math.Sqrt(halfPerimeter * (halfPerimeter - SideOneLength) * (halfPerimeter - SideTwoLength) * (halfPerimeter - SideThreeLength));
        }

        public override string WriteNumberOfSides()
        {
            return "It has 3 sides";

        }

        public override double Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
