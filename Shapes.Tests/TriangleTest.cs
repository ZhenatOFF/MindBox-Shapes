using Xunit;
using Shapes;
using System;

namespace Shapes.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5.5, 3.4, 8.2, 6.86)]
        public void Triangle_GetSquareReturnCorrectResult(double side1, double side2, double side3, double expected)
        {
            //arrange
            Triangle triangle = new Triangle(side1, side2, side3);

            //act
            double result = triangle.GetSquare();

            //assert
            Assert.InRange(result, expected - 0.01, expected + 0.01);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(5, 12, 13, true)]
        [InlineData(3, 8, 7, false)]
        public void Triangle_IsRectangularReturnCorrectResult(double side1, double side2, double side3, bool expected)
        {
            //arrange
            Triangle triangle = new Triangle(side1, side2, side3);

            //act
            bool result = triangle.IsRectangular();

            //assert
            Assert.Equal(result, expected);
        }
    }
}
