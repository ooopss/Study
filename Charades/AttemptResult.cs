using System.Collections.Generic;

namespace курсач
{
    public class AttemptResult
    {
		/// <summary>
		/// Статус попытки (угадал или нет букву)
		/// </summary>
		public AttemptStatus Status { get; set; }

	
		/// <summary>
		/// Все позиции в слове, где находится угаданная буква (в случае, если попытка является успешной)
		/// </summary>
        public IReadOnlyCollection<int> AllLetterPositions { get; set; }
	}
}