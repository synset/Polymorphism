using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Console.WriteLine(circle.Draw());

            double perCir = circle.CalculatePerimeter();
            Console.WriteLine("Perimeter of Circle : " + perCir);
            

            Rectangle rectangle = new Rectangle(6, 2);
            Console.WriteLine(rectangle.Draw());

            double perRect = rectangle.CalculatePerimeter();
            Console.WriteLine("Perimeter of Rectangle : " + perRect);
            
        }
    }
}
