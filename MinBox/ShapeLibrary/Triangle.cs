using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinBox.ShapeLibrary
{
    public class Triangle : IShape
    {
        private readonly double side1;
        private readonly double side2;
        private readonly double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public double CalculateArea()
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public bool IsRightAngleTriangle()
        {
            return (side1 * side1 + side2 * side2 == side3 * side3) ||
                   (side1 * side1 + side3 * side3 == side2 * side2) ||
                   (side2 * side2 + side3 * side3 == side1 * side1);
        }
    }
}
