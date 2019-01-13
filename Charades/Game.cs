using System.Collections.Generic;
using System.Linq;

namespace курсач
{
	public class Game : IGame
	{
		private readonly IWordGenerator _wordGenerator;
		private int _lettersGuessedCount;

		public List<char> LettersTryed { get; }

		public string Word { get; set; }
		
		public int WrongAttemptsCount { get; set; }

		public Game(IWordGenerator wordGenerator)
		{
			_wordGenerator = wordGenerator;
			LettersTryed = new List<char>();
		}

		public AttemptResult MakeAttempt(char c)
		{
			if (LettersTryed.Exists(x => x == c))
			{
				return new AttemptResult { IsAttemptDuplicated = true };
			}
			LettersTryed.Add(c);

			if (WrongAttemptsCount > 9)
			{
				return new AttemptResult { IsGameFailed = true };
			}

			if (!Word.Contains(c))
			{
				WrongAttemptsCount++;
				return new AttemptResult { IsSuccess = false };
			}


			var allPositions = GetAllPositions(c.ToString());
			_lettersGuessedCount += allPositions.Count;

			var result = new AttemptResult
			{
				AllLetterPositions = allPositions,
				IsSuccess = true,
				IsWordGuessed = (_lettersGuessedCount == Word.Length)
			};
			return result;
		}

		public DualGameCredentials StartDualGame(DualGameSettings settings)
		{
			WrongAttemptsCount = 0;
			_lettersGuessedCount = 0;
			LettersTryed.Clear();

			Word = settings.Word;
			return new DualGameCredentials();
		}

		public SingleGameCredentials StartSingleGame()
		{
			WrongAttemptsCount = 0;
			_lettersGuessedCount = 0;
			LettersTryed.Clear();

			Word = _wordGenerator.GetNewWord();

			var singleGameCredentials = new SingleGameCredentials();

			singleGameCredentials.WordLength = Word.Length;

			return singleGameCredentials;
		}

		private IReadOnlyCollection<int> GetAllPositions(string fragment)
		{
			var indices = new List<int>();

			int index = Word.IndexOf(fragment, 0);
			while (index > -1)
			{
				indices.Add(index);
				index = Word.IndexOf(fragment, index + fragment.Length);
			}
			return indices;
		}
	}
}
