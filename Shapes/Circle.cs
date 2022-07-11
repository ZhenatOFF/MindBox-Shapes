using System;

namespace Shapes
{
    public class Circle : IClosedShape
    {
        double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius is not positive");

            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI* Math.Pow(_radius, 2);
        }
    }
}
