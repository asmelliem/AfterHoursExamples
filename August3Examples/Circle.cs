using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Circle: Shape
    {
        public double Radius { get; set; }

        public override int NumberOfSides { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            NumberOfSides = 0;
        }

        public override double CalculateArea()
        {
            //Area = (pi)r^2
            return (Math.PI) * Math.Pow(Radius, 2);
        }
        public override string WriteNumberOfSides()
        {
            return "It has 0 sides";

        }

        public override double Length { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Height { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
