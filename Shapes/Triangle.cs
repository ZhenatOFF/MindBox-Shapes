using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : IClosedShape
    {
        double[] _sides;

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new ArgumentException("One or more side less than or equal to 0");
            
            if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2)
                throw new ArgumentException("Sides do not match triangle");

            _sides = new double[3] { side1, side2, side3 };
        }

        public double GetSquare()    //use Heron's formula
        {
            double p = _sides.Sum() / 2; // semi-perimeter
            return Math.Sqrt(p * (p - _sides[0]) * (p - _sides[1]) * (p - _sides[2]));
        }

        public bool IsRectangular()  //use Pythagorean theorem
        {
            return _sides[0] == Math.Sqrt(Math.Pow(_sides[1], 2) + Math.Pow(_sides[2], 2))
                    || _sides[1] == Math.Sqrt(Math.Pow(_sides[0], 2) + Math.Pow(_sides[2], 2))
                    || _sides[2] == Math.Sqrt(Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2));
        }
    }
}
