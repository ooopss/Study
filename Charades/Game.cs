using System.Collections.Generic;
using System.Linq;

namespace курсач
{
	public class Game : IGame
	{
		private readonly IWordGenerator _wordGenerator;
		public string Word { get; set; }
		public int AttemptCounter { get; set; }

		public Game(IWordGenerator wordGenerator)
		{
			_wordGenerator = wordGenerator;
		}

		public AttemptResult MakeAttempt(char c)
		{
			if (AttemptCounter > 9)
			{
				return new AttemptResult { IsGameFailed = true };
			}

			if (!Word.Contains(c))
			{
				AttemptCounter++;
				return new AttemptResult { IsSuccess = false };
			}

			var allPositions = GetAllPositions(c.ToString());

			var result = new AttemptResult();
			result.AllLetterPositions = allPositions;
			result.IsSuccess = true;
			return result;
		}

		public DualGameCredentials StartDualGame(DualGameSettings settings)
		{
			AttemptCounter = 0;

			Word = settings.Word;
			return new DualGameCredentials();
		}

		public SingleGameCredentials StartSingleGame()
		{
			AttemptCounter = 0;

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
