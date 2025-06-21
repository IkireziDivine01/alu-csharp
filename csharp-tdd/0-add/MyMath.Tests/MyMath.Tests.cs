using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MyMathTests
    {
        [Test]
        public void Add_BasicTest()
        {
            Assert.AreEqual(5, Operations.Add(2, 3));
        }
    }
}