using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_1
{
    internal class Rectangle
    {
        private readonly double s1;
        private readonly double s2;
        public Rectangle(double side1, double side2)
        {
            this.s1 = side1;
            this.s2 = side2;
        }
        private double are;
        public double Area
        {
            get
            {
                return are;
            }
        }
        public double AreaCalculator() => are = s1 * s2;
        private double per;
        public double Perimeter
        {
            get
            {
                return per;
            }
        }
        public double PerimeterCalculator() => per = s1 + s2 + s1 + s2;
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(15.5, 10.5);
            Console.WriteLine("Периметр = " + rectangle.PerimeterCalculator());
            Console.WriteLine("Площа = " + rectangle.AreaCalculator());
        }
    }
}
