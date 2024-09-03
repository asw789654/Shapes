using ShapesLib.Shapes;

namespace ShapesLib.UnitTests.Tests.Circles
{
    public class CircleCalculateAreaTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(500)]
        [InlineData(50)]
        public void Should_BeValid_When_CorrectInput(int radius)
        {
            Assert.IsType<double>(new Circle(radius).CalculateArea());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-500)]
        [InlineData(-50)]
        public void Should_NotBeValid_When_ZeroOrLowerInput(int radius)
        {
            Assert.Throws<InvalidDataException>(() => new Circle(radius).CalculateArea());
        }
    }

}