using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExampleExercises
{
    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double CalculateDistance()
        {
            //distance = sqrt((x2 - x1)^2 + (y2 - y1)^2)
            var distance = Math.Sqrt((Math.Pow(X,2) + Math.Pow(Y,2)));
            return distance;
        }          
    }
}
