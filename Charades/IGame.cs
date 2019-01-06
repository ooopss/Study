namespace курсач
{
    public interface IGame
    {
        /// <summary>
        /// Начать одиночную игру
        /// </summary>
        /// <returns>Учетные данные для одиночной игры</returns>
        SingleGameCredentials StartSingleGame();

        /// <summary>
        /// Запустить двойную игру
        /// </summary>
        /// <param name="settings">Настройки игры</param>
        /// <returns>Двойные игровые данные </returns>
        DualGameCredentials StartDualGame(DualGameSettings settings);
        
        /// <summary>
        /// Сделать попытку угадать слово по букве
        /// </summary>
        /// <param name="c">Буква, которую пытаются отгадать</param>
        /// <returns>Результат попытки</returns>
        AttemptResult MakeAttempt(char c);
    }
}
