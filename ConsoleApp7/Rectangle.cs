using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Rectangle : Figure
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double Perimeter()
        {
            return Width * 2 + Height * 2;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
