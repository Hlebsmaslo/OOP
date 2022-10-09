using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon
{
    internal class Figure
    {
        private double per;
        public double Perimeter { get { return per; } set { this.per = value; } }
        private readonly string sh;
        enum Sh
        {
            triangle,
            rectangle,
            pentagon
        }
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private Point E;
        public Figure(Point A, Point B, Point C) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
            sh = Sh.triangle.ToString();
            Console.WriteLine(sh + " - ");
        }
        public Figure(Point A, Point B, Point C,Point D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            sh = Sh.rectangle.ToString();
            Console.WriteLine(sh + " - ");
        }
        public Figure(Point A, Point B, Point C, Point D,Point E) 
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.E = E;
            sh = Sh.pentagon.ToString();
            Console.WriteLine(sh + " - ");
        }
        public static double LengthSide(Point A,Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }
        public double PerimeterCalculator()
        {
            double perimeter = Perimeter;
            if (sh == Sh.triangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A,C) + LengthSide(B,C);
                return perimeter;
            }
            else if (sh == Sh.rectangle.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, D) + LengthSide(B, C) + LengthSide(C, D);
                return perimeter;
            }
            else if (sh == Sh.pentagon.ToString())
            {
                perimeter = LengthSide(A, B) + LengthSide(A, E) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E);
                return perimeter;
            }
            return perimeter;
        }
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(1, 2, "A"));
            points.Add(new Point(3, 4, "B"));
            points.Add(new Point(5, 6, "C"));
            points.Add(new Point(7, 8, "D"));
            points.Add(new Point(9, 10, "E"));

            Figure triangle = new Figure(points[0], points[1], points[2]);
            Console.WriteLine(triangle.PerimeterCalculator());
            Figure rectangle = new Figure(points[0], points[1], points[2], points[3]);
            Console.WriteLine(rectangle.PerimeterCalculator());
            Figure pentagon = new Figure(points[0], points[1], points[2], points[3], points[4]);
            Console.WriteLine(pentagon.PerimeterCalculator());
        }

    }
}
