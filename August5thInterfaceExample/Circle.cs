using System;
using System.Collections.Generic;
using System.Text;

namespace August5thInterfaceExample
{
    public class Circle : IShape
    {
        private double radius;
        public double NumberOfSides { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
            NumberOfSides = 0;
        }        

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }        
    }
}
