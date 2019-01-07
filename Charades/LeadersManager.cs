using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсач
{
    class LeadersManager : ILeadersManager
    {
        public IReadOnlyCollection<LeaderRecord> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public void SaveLeaderResult(LeaderRecord newItem)
        {
            throw new NotImplementedException();
        }
        private const string _filePath = @"leaders.txt";
    }

}
