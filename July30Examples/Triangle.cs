using System;
using System.Collections.Generic;
using System.Text;

namespace July30Examples
{
    public class Triangle
    {
        public int SideOneLength { get; set; }

        public int SideTwoLength { get; set; }   

        public int SideThreeLength { get; set; }

        public Triangle(int sideOneLength, int sideTwoLength, int sideThreeLength)
        {
            SideOneLength = sideOneLength;
            SideTwoLength = sideTwoLength;
            SideThreeLength = sideThreeLength;
        }

        public int CalculatePerimeter()
        {
            return SideOneLength + SideTwoLength + SideThreeLength;
        }

        public int CalculateArea()
        {
            var halfPerimeter = CalculatePerimeter() / 2;
            return (int)Math.Sqrt(halfPerimeter * (halfPerimeter - SideOneLength) * (halfPerimeter - SideTwoLength) * (halfPerimeter - SideThreeLength));
        }
    }
}
