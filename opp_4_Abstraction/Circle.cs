﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_4_Abstraction
{
    internal class Circle : Shape
    {
        public double Radius { get; set; } 

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius; 
        }
    }
}
