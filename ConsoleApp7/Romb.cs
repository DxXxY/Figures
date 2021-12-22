using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Romb: Figure
    {
        private double Dioganal1 { get; set; }
        private double Dioganal2 { get; set; }
        public Romb(float dioganal1, float dioganal2)
        {
            this.Dioganal1=dioganal1;
            this.Dioganal2=dioganal2;
        }
        public override double Perimeter()
        {
            return 2*Math.Sqrt(Convert.ToDouble(this.Dioganal1*this.Dioganal1+this.Dioganal2*this.Dioganal2));
        }
        public override double Area()
        {
            return Dioganal2*Dioganal1;
        }
    }
}
