using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace курсач
{
	public class LeadersManager : ILeadersManager
	{
		private const string _filePath = @"leaders.txt";

		public IReadOnlyCollection<LeaderRecord> GetAllRecords()
		{
			var records = new List<LeaderRecord>();
			var lines = File.ReadAllLines(_filePath);
			foreach (var line in lines)
			{
				var items = line.Split(',');
				var record = new LeaderRecord
				{
					Name = items[0],
					Score = int.Parse(items[1]),
					Date = DateTime.Parse(items[2])
				};
				records.Add(record);
			}
			return records.OrderByDescending(x => x.Score).Take(10).ToArray();
		}


		public void SaveLeaderResult(LeaderRecord newItem)
		{
			var newLine = $"{newItem.Name},{newItem.Score},{newItem.Date}";
			File.AppendAllLines(_filePath, new[] { newLine });
		}
	}
}
