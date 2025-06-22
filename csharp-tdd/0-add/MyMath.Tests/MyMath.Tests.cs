using NUnit.Framework;
using MyMath;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestAdd_PositiveIntegers()
        {
            Assert.That(Operations.Add(5, 7), Is.EqualTo(12));
        }

        [Test]
        public void TestAdd_NegativeIntegers()
        {
            Assert.That(Operations.Add(-3, -6), Is.EqualTo(-9));
        }

        [Test]
        public void TestAdd_PositiveAndNegative()
        {
            Assert.That(Operations.Add(10, -4), Is.EqualTo(6));
        }

        [Test]
        public void TestAdd_Zero()
        {
            Assert.That(Operations.Add(0, 5), Is.EqualTo(5));
            Assert.That(Operations.Add(5, 0), Is.EqualTo(5));
        }

        [Test]
        public void TestAdd_ZeroAndZero()
        {
            Assert.That(Operations.Add(0, 0), Is.EqualTo(0));
        }

        [Test]
        public void PrintXxx()
        {
            Console.WriteLine("xxx");
        }
    }
}
