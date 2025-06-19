using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyMath.Tests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void Add_PositiveNumbers_ReturnsSum()
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

        [TestMethod]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            // Arrange
            int a = -5;
            int b = -3;
            int expected = -8;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_MixedNumbers_ReturnsSum()
        {
            // Arrange
            int a = -10;
            int b = 15;
            int expected = 5;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_Zero_ReturnsOtherNumber()
        {
            // Arrange
            int a = 0;
            int b = 42;
            int expected = 42;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Add_BothZero_ReturnsZero()
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