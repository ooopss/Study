using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    public interface ILeadersManager
    {
        IReadOnlyCollection<LeaderRecord> GetAllRecords();
        void SaveLeaderResult(LeaderRecord newItem);
    }
}
