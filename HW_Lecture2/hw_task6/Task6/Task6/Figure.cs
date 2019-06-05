using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Figure
    {
        private Point pointA;
        private Point pointB;
        private Point pointC;
        private Point pointD;
        private Point pointE;
        private Point[] points;
        private double lengthSide;
        private double perimeter;
        private string name = string.Empty;

        public Figure(Point pointA, Point pointB, Point pointC)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
        }

        public Figure(Point pointA, Point pointB, Point pointC, Point pointD)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
            this.pointD = pointD;
        }

        public Figure(Point pointA, Point pointB, Point pointC, Point pointD, Point pointE)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;
            this.pointD = pointD;
            this.pointE = pointE;
        }

        public string Name { get => name; }

        public double LengthSide(Point pointA, Point pointB)
        {
            lengthSide = Math.Pow((pointA.PointA - pointB.PointB), 2) + Math.Pow((pointA.PointA - pointB.PointB), 2);
            lengthSide = Math.Sqrt(lengthSide);
            return lengthSide;
        }

        public double PerimeterCalculator(Point a, Point b)
        {
            //P=n*a. n = количество углов, a = длина стороны
            CountPoint();
            perimeter = points.Length * LengthSide(a,b);
            return perimeter;
        }

        private void CountPoint()
        {
            if (pointE != null)
            {
                points = new Point[5];
                points[0] = pointA;
                points[1] = pointB;
                points[2] = pointC;
                points[3] = pointD;
                points[4] = pointE;
                name = "Пятиугольник";
            }
            else if (pointD != null)
            {
                points = new Point[4];
                points[0] = pointA;
                points[1] = pointB;
                points[2] = pointC;
                points[3] = pointD;
                name = "Четырёхугольник";
            }
            else if (pointC != null)
            {
                points = new Point[3];
                points[0] = pointA;
                points[1] = pointB;
                points[2] = pointC;
                name = "Треугольник";
            }
        }
    }
}
