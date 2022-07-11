using Xunit;
using Shapes;
using System;

namespace Shapes.Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(2, Math.PI * 4)]
        public void Circle_GetSquareReturnCorrectResult(double radius, double expected)
        {
            //arrange
            Circle circle = new Circle(radius);

            //act
            double result = circle.GetSquare();

            //assert
            Assert.Equal(expected, result);
        }
    }
}