using NUnit.Framework;
using TravisTest;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void MyTest1()
        {
            // arrange

            Assert.AreEqual(Class1.Test1(1,1), 2);
        }
    }
}
