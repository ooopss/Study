using System.Collections.Generic;

namespace курсач
{
    public class AttemptResult
    {
		/// <summary>
		/// Является ли попытка угадать успешной
		/// </summary>
        public bool IsSuccess { get; set; }

		/// <summary>
		/// Является ли игра завершенной (исчерпан лимит попыток)
		/// </summary>
        public bool IsGameFailed { get; set; }

		/// <summary>
		/// Все позиции в слове, где находится угаданная буква (в случае, если попытка является успешной)
		/// </summary>
        public IReadOnlyCollection<int> AllLetterPositions { get; set; }
    }
}