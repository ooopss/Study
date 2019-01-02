using NUnit.Framework;

namespace Charades.Tests
{
    [TestFixture(Category = "Unit")]
    public class FirstUnitTests
    {
        [Test]
        public void TestNumbaOne()
        {
            // arrange
            var expected = 10;
            var b = 5;

            // act
            var result = b * 2;

            // assert
            Assert.AreEqual(expected, b);
        }

        [Test]
        public void TestNumbaTwo()
        {
            var a = 10;
            var b = 5 * 3;

            Assert.AreNotEqual(a, b);
        }

        
    }
}
