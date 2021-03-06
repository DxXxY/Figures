using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Triangle : Figure
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }
        public Triangle(double a,double b,double c)
        {
            this.a=a;
            this.b=b;
            this.c=c;
        }
        public override double Perimeter()
        {
            return a+b+c;
        }
        public override double Area()
        {
            double P = (a+b+c)/2;
            return Math.Sqrt(P*(P-a)*(P-b)*(P-c));
        }
    }
}
