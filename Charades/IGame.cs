namespace курсач
{
    public interface IGame
    {
        /// <summary>
        /// Начать одиночную игру
        /// </summary>
        /// <returns>Учетные данные для одиночной игры</returns>
        SingleGameParameters StartSingleGame();

        /// <summary>
        /// Запустить двойную игру
        /// </summary>
        /// <param name="settings">Настройки игры</param>
        /// <returns>Двойные игровые данные </returns>
        DualGameParameters StartDualGame(DualGameSettings settings);
        
        /// <summary>
        /// Сделать попытку угадать слово по букве
        /// </summary>
        /// <param name="c">Буква, которую пытаются отгадать</param>
        /// <returns>Результат попытки</returns>
        AttemptResult MakeAttempt(char c);

		/// <summary>
		/// Количество неверных попыток
		/// </summary>
		int WrongAttemptsCount { get; set; }

		/// <summary>
		/// Загаданное слово
		/// </summary>
		string Word { get; set; }
	}
}
