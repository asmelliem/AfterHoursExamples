﻿using System;
using System.Collections.Generic;
using System.Text;

namespace August3Examples
{
    public class Square : IShape
    {
        public double Length { get; set; }

        public double Height { get; set; }

        public int NumberOfSides { get; set ; }

        public Square(double length, double height)
        {
            Length = length;
            Height = height;
            NumberOfSides = 4;
        }

        public double CalculateArea()
        {
            return Length * Height;
        }

        public string WriteNumberOfSides()
        {
            return $"It has {NumberOfSides} sides";            
        }
    }
}
