namespace курсач
{
	public enum AttemptStatus
	{
		/// <summary>
		/// Удачная попытка, слово целиком не угадано
		/// </summary>
		LetterGuessed,

		/// <summary>
		/// Удачная попытка, слово открыто целиком
		/// </summary>
		WordGuessed,

		/// <summary>
		/// Попытка неудачная, слово не угадано
		/// </summary>
		Failed,

		/// <summary>
		/// Попытка угадать ранее названную букву, не учитывается в счетчиках
		/// </summary>
		Duplicated,

		/// <summary>
		/// Превышено количество попыток
		/// </summary>
		GameFailed
	}
}
