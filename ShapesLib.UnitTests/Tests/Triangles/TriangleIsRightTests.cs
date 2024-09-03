using ShapesLib.Shapes;

namespace ShapesLib.UnitTests.Tests.Triangles;

public class TriangleIsRightTests
{
    public class TriangeleCalculateAreaTests
    {
        [Theory]
        [InlineData(4, 5, 3)]
        public void Should_BeTrue_When_CorrectInput(int a, int b, int c)
        {
            Assert.True(new Triangle(a, b, c).IsRight);
        }

        [Theory]
        [InlineData(4, 5, 6)]
        [InlineData(6, 5, 7)]
        [InlineData(8, 9, 10)]
        [InlineData(12, 11, 13)]
        public void Should_BeFalse_When_CorrectInput(int a, int b, int c)
        {
            Assert.False(new Triangle(a, b, c).IsRight);
        }
    }
}
