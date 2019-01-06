namespace курсач
{
    public interface IGame
    {
        SingleGameCredentials StartSingleGame(); //Учетные данные для одиночной игры Начать одиночную игру();
        DualGameCredentials StartDualGame(DualGameSettings settings);//Двойные игровые данные 
        //Запустить двойную игру(настройки)
        AttemptResult MakeAttempt(char c);// Попытка Результат. Сделатьпопытку(символ c);
    }
    public class WordGenerator : IWordGenerator
    {
        public string GetNewWord()
        {
            throw new System.NotImplementedException();
        }
    }

  
    
    
}
