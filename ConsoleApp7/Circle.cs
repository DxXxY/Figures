using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Circle:Figure
    {
        private double R { get; set; }
        public Circle(double R)
        {
            this.R=R;
        }
        public override double Perimeter()
        {
            return Math.PI*2*R;
        }
        public override double Area()
        {
            return Math.PI*R*R;
        }
    }
}
