using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Add_NegativeAndPositive_ReturnsCorrectSum()
        {
            int result = Operations.Add(-2, 3);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(-2, -3);
            Assert.AreEqual(-5, result);
        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsSameNumber()
        {
            int result = Operations.Add(0, 5);
            Assert.AreEqual(5, result);
        }
    }
}
