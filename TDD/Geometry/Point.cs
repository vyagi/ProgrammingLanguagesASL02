using System;

namespace Geometry
{
    // FAIL, PASS, REFACTOR
    public class Point
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public Point() : this(1,1) { }

        public double Distance() => Math.Sqrt(_x * _x + _y * _y);

        public double Distance(Point point) => Math.Sqrt(Math.Pow(_x - point.X, 2) + Math.Pow(_y - point.Y, 2));

        public static double Distance(Point point1, Point point2) => point1.Distance(point2);
    }
}
