using System;
using Xunit;

namespace MyMath.Tests
{
    /// <summary>
    /// Unit tests for MyMath.Operations class
    /// </summary>
    public class OperationsTests
    {
        [Fact]
        public void Add_PositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;
            int expected = 8;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -3;
            int expected = -8;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_PositiveAndNegative_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -7;
            int expected = 3;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_ZeroValues_ReturnsCorrectSum()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int expected = 0;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_OneZeroValue_ReturnsCorrectSum()
        {
            // Arrange
            int a = 15;
            int b = 0;
            int expected = 15;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_LargeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 1000000;
            int b = 2000000;
            int expected = 3000000;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}