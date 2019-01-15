using System.Collections.Generic;

namespace курсач
{
    public class AttemptResult
    {
		// TODO - вместо флагов реализовать enum AttemptStatus

		/// <summary>
		/// Является ли попытка угадать успешной
		/// </summary>
        public bool IsSuccess { get; set; }
		
		/// <summary>
		/// Является ли слово полностью угаданым
		/// </summary>
		public bool IsWordGuessed { get; set; }
		
		/// <summary>
		/// Является ли игра завершенной (исчерпан лимит попыток)
		/// </summary>
		public bool IsGameFailed { get; set; }

		/// <summary>
		/// Является ли попытка повторной (названа та же буква, что и ранее)
		/// </summary>
		public bool IsAttemptDuplicated { get; set; }

		/// <summary>
		/// Все позиции в слове, где находится угаданная буква (в случае, если попытка является успешной)
		/// </summary>
        public IReadOnlyCollection<int> AllLetterPositions { get; set; }
	}
}