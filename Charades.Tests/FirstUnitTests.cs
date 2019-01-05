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
            var expected = 10; // ожидаемый результат

            var b = 5; // исходное число
            
            // act
            // выполняем умножение и сохраняем фактический результат
            var result = b * 2;

            // assert
            // фактический результат произведения должно совпадать с ожидаемым результатом
            Assert.AreEqual(expected, result);
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
