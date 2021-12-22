﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Ellipse:Figure
    {
        private double R1{ get; set; }
        private double R2 { get; set; }
        public Ellipse(double R1,double R2)
        {
            this.R1=R1;
            this.R2=R2;
        }

        public override double Perimeter()
        {
            return Math.PI*(R1+R2);
        }
        public override double Area()
        {
            return Math.PI*R1*R2;
        }
    }
}
