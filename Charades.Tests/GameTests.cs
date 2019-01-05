﻿using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using курсач;

namespace Charades.Tests
{
    [TestFixture(Category = "Unit")]
    public class GameTests
    {
        // class under tests
        private Game _game;

        private Mock<IWordGenerator> _wordGenerator;

        [SetUp]
        public void OnStartUp()
        {
            _wordGenerator = new Mock<IWordGenerator>();
            _game = new Game(_wordGenerator.Object);
        }

        [Test]
        public void AttemptTest_Success()
        {
            // arrange
            _game.Word = "молоко";

            // act
            var result = _game.MakeAttempt('о');

            // assert
            Assert.AreEqual(true, result.IsSuccess);
            Assert.AreEqual(3, result.AllLetterPositions.Count);
            CollectionAssert.Contains(result.AllLetterPositions, 1);
            CollectionAssert.Contains(result.AllLetterPositions, 3);
            CollectionAssert.Contains(result.AllLetterPositions, 5);
        }

        [Test]
        public void AttemptTest_Fail()
        {
            // arrange
            _game.Word = "молоко";

            // act
            var result = _game.MakeAttempt('р');

            // assert
            Assert.AreEqual(false, result.IsSuccess);
        }
    }
}
