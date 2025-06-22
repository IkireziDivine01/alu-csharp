using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void CamelCase_CountsWordsCorrectly()
        {
            Assert.AreEqual(1, Str.CamelCase("word"));
            Assert.AreEqual(2, Str.CamelCase("camelCase"));
            Assert.AreEqual(3, Str.CamelCase("thisIsTest"));
            Assert.AreEqual(4, Str.CamelCase("oneTwoThreeFour"));
            Assert.AreEqual(0, Str.CamelCase(""));
            Assert.AreEqual(0, Str.CamelCase(null));
        }
    }
}
