using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }

        public override double CalculateArea()
        {
            double w = Convert.ToDouble(Width);
            double h = Convert.ToDouble(Height);
            double areaRect = w * h;
            return areaRect;
        }

        public override double CalculatePerimeter()
        {
            double w = Convert.ToDouble(Width);
            double h = Convert.ToDouble(Height);
            double perRect = 2 * (w + h);
            return perRect;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
    }
}
