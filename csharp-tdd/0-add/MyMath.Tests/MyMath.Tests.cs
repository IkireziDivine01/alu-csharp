using NUnit.Framework;
using MyMath;
using System;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            Assert.That(Operations.Add(1, 2), Is.EqualTo(3));
            Console.WriteLine("xxx");
        }
    }
}
