using Xunit;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            int result = Operations.Add(-4, 6);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(-2, -3);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Add_ZeroAndNumber_ReturnsSameNumber()
        {
            int result = Operations.Add(0, 7);
            Assert.Equal(7, result);
        }
    }
}
