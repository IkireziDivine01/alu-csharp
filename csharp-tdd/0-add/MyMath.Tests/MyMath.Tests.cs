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
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Add_NegativeAndPositive_ReturnsCorrectSum()
        {
            int result = Operations.Add(-2, 3);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            int result = Operations.Add(-2, -3);
            Assert.That(result, Is.EqualTo(-5));
        }

        [Test]
        public void Add_ZeroAndNumber_ReturnsSameNumber()
        {
            int result = Operations.Add(0, 5);
            Assert.That(result, Is.EqualTo(5));
        }
    }
}
