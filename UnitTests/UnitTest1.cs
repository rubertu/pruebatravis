using System;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public static void Test1()
        {
            int a = 1;
            int b = 1;

            Assert.AreEqual(a, b);
        }
    }
}
