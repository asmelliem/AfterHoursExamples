using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Square : Shape
    {
        public Square(double length, double height)  : base(length, height)
        {
            base.Length = length;
            base.Height = height;
        }

        public override double CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
