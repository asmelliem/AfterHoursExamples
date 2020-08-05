using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public abstract class Shape
    {
        public abstract double Length { get; set; }

        public abstract double Height { get; set; }

        public abstract int NumberOfSides { get; set; }

        public abstract double CalculateArea();

        public abstract string WriteNumberOfSides();
    }
}
