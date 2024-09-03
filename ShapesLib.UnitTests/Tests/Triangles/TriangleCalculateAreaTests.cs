using ShapesLib.Shapes;

namespace ShapesLib.UnitTests.Tests.Triangles
{
    public class TriangeleCalculateAreaTests
    {
        [Theory]
        [InlineData(4, 5, 6)]
        [InlineData(7, 8, 9)]
        [InlineData(7, 5, 6)]
        public void Should_BeValid_When_CorrectInput(int a, int b, int c)
        {
            Assert.IsType<double>(new Triangle(a, b, c).CalculateArea());
        }

        [Theory]
        [InlineData(0, 3, 4)]
        [InlineData(5, 1, 2)]
        [InlineData(-50, 3, 4)]
        public void Should_NotBeValid_When_IncorrectInput(int a, int b, int c)
        {
            Assert.Throws<InvalidDataException>(() => new Triangle(a, b, c).CalculateArea());
        }
    }

}