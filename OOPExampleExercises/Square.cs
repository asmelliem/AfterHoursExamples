using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExampleExercises
{
    public class Square
    {
        public int SideLength { get; set; }

        public Square(int sideLength)
        {            
            SideLength = sideLength;
        }

        public int CalculatePerimeter()
        {
            return SideLength * 4;
        }

        public int CalculateArea ()
        {
            return SideLength * SideLength;
        }

    }
}
