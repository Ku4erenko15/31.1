using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1
{
    class Rectangle : Figure 
    {
        private double side1, side2;

        public double Side1 { get { return side1; } set { side1 = value; } }
        public double Side2 { get { return side2; } set { side2 = value; } }

        public Rectangle(double side1, double side2) : base("Прямоугольник")
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area() => side1 * side2;
        public override double Perimeter() => (side2 + side1) * 2;

        public override void Print()
        {
            base.print();
            Console.WriteLine($"стороны:{side1} и {side2}. Площадь:{Area()}; Периметр:{Perimeter()}");
        }
    }
}
