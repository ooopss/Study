namespace курсач
{
    public interface IGame
    {
        SingleGameCredentials StartSingleGame();
        DualGameCredentials StartDualGame(DualGameSettings settings);

        AttemptResult MakeAttempt(char c);
    }
}
