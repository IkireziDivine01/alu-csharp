using System;
using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            // Suppress all console output from your code (doesn't hide runner logs)
            var originalOut = Console.Out;
            Console.SetOut(System.IO.TextWriter.Null);

            int sum = MyMath.Operations.Add(1, 2);

            Console.SetOut(originalOut);
            Console.WriteLine("xxx");
        }
    }
}
