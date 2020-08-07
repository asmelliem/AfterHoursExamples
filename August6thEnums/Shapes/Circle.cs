using System;
using System.Collections.Generic;
using System.Text;

namespace August6thEnums
{
    public class Circle : IShape
    {
        public NumberOfSides NumberOfSides { get; set; }

        public Circle(NumberOfSides numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
    }
}
