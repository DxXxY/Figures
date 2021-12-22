using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Squre : Figure
    {
        private double Lenght { get; set; }

        public Squre(double lenght)
        {
            this.Lenght=lenght;
        }
        public override double Perimeter()
        {
            return Lenght * 4;
        }
        public override double Area()
        {
            return Lenght * Lenght;
        }
    }
}
