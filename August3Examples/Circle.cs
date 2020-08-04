using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Circle: Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            //Area = (pi)r^2
            return (Math.PI) * Math.Pow(Radius, 2);
        }

    }
}
