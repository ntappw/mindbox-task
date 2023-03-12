using ShapesLib.Interfaces;

namespace ShapesLib.Domain
{
    public class Circle : IShape
    {
        private readonly double _radius;

        private Circle(double radius)
        {
            _radius = radius;
        }

        public static IShape Create(double radius)
        {
            return radius > 0 ? new Circle(radius) : 
                    throw new ArgumentOutOfRangeException("The expected radius value is not positive");
        }

        public double Area() => Math.PI * Math.Pow(_radius, 2);
        public double Perimeter() => 2 * Math.PI * _radius;
    }
}
