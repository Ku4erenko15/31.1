using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1
{
     class Square: Figure
    {
        private double side1;

        public double Side1 { get { return side1; } set { side1 = value; } }
        

        public Square(string name, double side1) : base(name)
        {
            this.side1 = side1;
            
        }

        public override double Area() => side1 * side1;
        public override double Perimeter() => side1 * 4;

        public override void Print()        
        {
            base.Print();
            Console.WriteLine($"Сторона:{side1}. Площадь:{Area()}; Периметр:{Perimeter()}");
        }
        public static Square Enter()
        {
            Console.Clear();
            Console.WriteLine("");
            string name = Console.ReadLine();
            Console.WriteLine("");
            double side1 = double.Parse(Console.ReadLine());
            return new Square (name, side1);
        }
    }
}
