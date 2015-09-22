
using NUnit.Framework;

namespace TravisTest
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public static void Test1()
        {
            int a = 1;
            int b = 1;

            Assert.AreEqual(a,b);
        }
    }
}
