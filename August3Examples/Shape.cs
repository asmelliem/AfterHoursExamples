using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public interface IShape
    {
        int NumberOfSides { get; set; }

        double CalculateArea();

        string WriteNumberOfSides();
    }
}
