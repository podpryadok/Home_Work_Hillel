using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Point
    {
        private int pointA;
        private int pointB;
        private string name;

        public int PointA { get => pointA; }
        public int PointB { get => pointB; }
        public string Name { get => name; }

        public Point(int pointA, int pointB, string name)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.name = name;
        }
    }
}
