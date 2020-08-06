using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Circle: IShape
    {
        public double Radius { get; set; }

        public int NumberOfSides { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
            NumberOfSides = 0;
        }

        public double CalculateArea()
        {
            //Area = (pi)r^2
            return (Math.PI) * Math.Pow(Radius, 2);
        }
        public string WriteNumberOfSides()
        {
            return $"It has {NumberOfSides} sides";
        }
    }
}
