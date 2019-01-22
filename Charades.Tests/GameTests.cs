using Moq;
using NUnit.Framework;
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
		public void MakeAttempt_LetterGuessed()
		{
			// arrange
			_game.Word = "молоко";

			// act
			var result = _game.MakeAttempt('о');

			// assert
			Assert.AreEqual(AttemptStatus.LetterGuessed, result.Status);
			Assert.AreEqual(3, result.AllLetterPositions.Count);
			CollectionAssert.Contains(result.AllLetterPositions, 1);
			CollectionAssert.Contains(result.AllLetterPositions, 3);
			CollectionAssert.Contains(result.AllLetterPositions, 5);
		}

		[Test]
		public void MakeAttempt_NoSuchLetter() // нет такой буквы
		{
			// arrange
			_game.Word = "молоко";

			// act
			var result = _game.MakeAttempt('р');

			// assert
			Assert.AreEqual(AttemptStatus.Failed, result.Status);
		}

		[Test]
		// Удачная попытка, слово открыто целиком
		public void MakeAttempt_WordGuessed()
		{
			// arrange
			_game.Word = "молоко";

			_game.MakeAttempt('о');
			_game.MakeAttempt('м');
			_game.MakeAttempt('л');

			// act
			var resultk = _game.MakeAttempt('к');

			// assert
			Assert.AreEqual(AttemptStatus.WordGuessed, resultk.Status);
		}
		
		[Test]
		// Попытка угадать ранее названную букву, не учитывается в счетчиках
		public void MakeAttempt_Duplicated()
		{
			// arrange
			_game.Word = "молоко";
			_game.MakeAttempt('р');

			// act
			var result = _game.MakeAttempt('р');

			// assert
			Assert.AreEqual(AttemptStatus.Duplicated, result.Status);
		}

		[Test]
		// Превышено количество попыток
		public void MakeAttempt_GameFailed()
		{
			// arrange
			_game.Word = "молоко";
			_game.MakeAttempt('ц');
			_game.MakeAttempt('т');
			_game.MakeAttempt('з');
			_game.MakeAttempt('ж');
			_game.MakeAttempt('г');
			_game.MakeAttempt('у');
			_game.MakeAttempt('а');
			_game.MakeAttempt('ч');
			_game.MakeAttempt('ф');

			// act
			var result = _game.MakeAttempt('р');

			// assert
			Assert.AreEqual(AttemptStatus.GameFailed, result.Status);
		}
	}
}
