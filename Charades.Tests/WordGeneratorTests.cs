using курсач;
using NUnit.Framework;

namespace Charades.Tests
{
    [TestFixture(Category = "Unit")]
    public class WordGeneratorTests
    {
        // class under tests
        private WordGenerator _generator;

        [SetUp]
        public void OnStartUp()
        {
            _generator = new WordGenerator();
        }

        [Test]
        public void AttemptTest_Success()
        {
            // arrange

            // act
            var result = _generator.GetNewWord();

            // assert
            Assert.Greater(result.Length, 2);
        }
    }
}
