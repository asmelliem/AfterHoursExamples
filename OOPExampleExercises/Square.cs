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
            var perimeter = this.SideLength * 4;
            return perimeter;
        }

        public int CalculateArea ()
        {
            var area = this.SideLength * SideLength;
            return area;
        }

    }
}
