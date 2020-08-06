using System;
using System.Collections.Generic;
using System.Text;

namespace August5thInterfaceExample
{
    public interface IShape
    {
        public double NumberOfSides { get; set; }

        public double CalculateArea();
    }
}
