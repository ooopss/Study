using System.Collections.Generic;


namespace курсач
{
    public interface ILeadersManager
    {
        IReadOnlyCollection<LeaderRecord> GetAllRecords();
        void SaveLeaderResult(LeaderRecord newItem);
    }
}
