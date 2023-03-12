using ShapesLib.Interfaces;

namespace ShapesLib.Domain
{
    public class Triangle : IShape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        private Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public bool IsSquareness()
        {
            if (Math.Pow(_side1, 2) + Math.Pow(_side2, 2) == Math.Pow(_side3, 2)
                || Math.Pow(_side3, 2) + Math.Pow(_side2, 2) == Math.Pow(_side1, 2)
                || Math.Pow(_side1, 2) + Math.Pow(_side3, 2) == Math.Pow(_side2, 2))
                return true;
            return false;
        }

        public static IShape Create(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentOutOfRangeException(
                    "The expected values of the sides of the triangle are not positive");

            if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2)
                throw new ArgumentException("Incorrect lengths of the sides of the triangle");

            return new Triangle(side1, side2, side3);
        }

        public double Area()
        {
            double p = (_side1 + _side2 + _side3) / 2; //half-perimeter

            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public double Perimeter() => _side1 + _side2 + _side3;
    }
}
