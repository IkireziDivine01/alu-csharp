using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Test class for MyMath.Operations
    /// </summary>
    [TestFixture]
    public class MyMathTests
    {
        /// <summary>
        /// Test adding two positive numbers
        /// </summary>
        [Test]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding positive and negative numbers
        /// </summary>
        [Test]
        public void Add_PositiveAndNegative_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -5;
            int expected = 5;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding two negative numbers
        /// </summary>
        [Test]
        public void Add_TwoNegativeNumbers_ReturnsSum()
        {
            // Arrange
            int a = -3;
            int b = -7;
            int expected = -10;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding zero to a number
        /// </summary>
        [Test]
        public void Add_NumberAndZero_ReturnsNumber()
        {
            // Arrange
            int a = 42;
            int b = 0;
            int expected = 42;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding two zeros
        /// </summary>
        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int expected = 0;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}