using System.Collections.Generic;

namespace курсач
{
    public class AttemptResult
    {
        public bool IsSuccess { get; set; }
        public bool IsGameFailed { get; set; }
        public IReadOnlyCollection<int> AllLetterPositions { get; set; }
    }
}