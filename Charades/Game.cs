using System.Collections.Generic;
using System.Linq;

namespace курсач
{
	public class Game : IGame
	{
		private readonly IWordGenerator _wordGenerator;

		/// <summary>
		/// количество угаданных букв
		/// </summary>
		private int _lettersGuessedCount;

		/// <summary>
		/// пробованные буквы
		/// </summary>
		public List<char> LettersTryed { get; }

		// слово
		public string Word { get; set; }

		/// <summary>
		/// Количество удачных попыток???
		/// </summary>
		public int WrongAttemptsCount { get; set; }

		// 
		public Game(IWordGenerator wordGenerator)
		{
			_wordGenerator = wordGenerator;
			LettersTryed = new List<char>();
		}

		//Делать попытку
		public AttemptResult MakeAttempt(char c)
		{
			//Повторная буква
			if (LettersTryed.Exists(x => x == c))
			{
				return new AttemptResult { Status = AttemptStatus.Duplicated };
			}
			LettersTryed.Add(c);

			// Слово не содержит букву
			if (!Word.Contains(c))
			{
				WrongAttemptsCount++;

				// количество неправильных попыток превышает лимит
				if (WrongAttemptsCount > 9)
				{
					return new AttemptResult { Status = AttemptStatus.GameFailed };
				}
				return new AttemptResult { Status = AttemptStatus.Failed };
			}

			var allPositions = GetAllPositions(c.ToString());
			_lettersGuessedCount += allPositions.Count;
			var result = new AttemptResult();
			if (_lettersGuessedCount == Word.Length)
			{
				return new AttemptResult
				{
					Status = AttemptStatus.WordGuessed,
					AllLetterPositions = allPositions
				};
			}
			return new AttemptResult
			{
				Status = AttemptStatus.LetterGuessed,
				AllLetterPositions = allPositions
			};
		} 

		public DualGameCredentials StartDualGame(DualGameSettings settings)
		{
			WrongAttemptsCount = 0;
			_lettersGuessedCount = 0;
			LettersTryed.Clear();

			Word = settings.Word;
			return new DualGameCredentials();
		}
		// учетные данные для одиночной игры
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

		// Получить все позиции буквы в слове
		private IReadOnlyCollection<int> GetAllPositions(string fragment)
		{
			// список с позициями номер буквы
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
