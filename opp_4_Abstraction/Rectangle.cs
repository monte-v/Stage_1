﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_4_Abstraction
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; } 
        public double Height { get; set; } 

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height; 
        }
    }
}
