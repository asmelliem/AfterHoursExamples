using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Shape
    {
        public double Length { get; set; }

        public double Height { get; set; }

        public virtual double CalculateArea()
        {
            return Length * Height;
        }        
    }
}
