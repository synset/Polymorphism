using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private int radius;
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get => radius; set => radius = value; }

        public override double CalculateArea()
        {
            double r = Convert.ToDouble(Radius);
            double PI = 3.14;
            double areaCir = PI * r * r;
            return areaCir;
        }

        public override double CalculatePerimeter()
        {
            double r = Convert.ToDouble(Radius);
            double PI = 3.14;
            double perCir = 2 * r * PI;
            return perCir;
        }

        public override string Draw()
        {
            return base.Draw() + GetType().Name;
        }
        
    }
}
