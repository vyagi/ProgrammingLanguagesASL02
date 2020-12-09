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
    }
}
