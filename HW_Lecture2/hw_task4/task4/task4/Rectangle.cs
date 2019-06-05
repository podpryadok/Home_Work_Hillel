using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        public Rectangle(double s1, double s2)
        {
            side1 = s1;
            side2 = s2;
        }

        public double AreaCalculator()
        {
            double ar = side1 * side2;
            return Area = ar;
        }
        public double PerimetrCalculator()
        {
            double per= (side1 + side2) * 2;
            return Perimeter = per;
        }
    }

}
