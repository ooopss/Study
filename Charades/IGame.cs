namespace курсач
{
    public interface IGame
    {
        /// <summary>
        /// Учетные данные для одиночной игры Начать одиночную игру();
        /// </summary>
        /// <returns></returns>
        SingleGameCredentials StartSingleGame();
       
        /// <summary>
        /// Двойные игровые данные 
        /// Запустить двойную игру(настройки)
        /// </summary>
        /// <param name="settings"></param>
        /// <returns></returns>
        DualGameCredentials StartDualGame(DualGameSettings settings);
        
        /// <summary>
        /// Попытка Результат. Сделатьпопытку(символ c);
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        AttemptResult MakeAttempt(char c);
    }
}
