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
					ElapsedTime = TimeSpan.Parse(items[1]),
					Date = DateTime.Parse(items[2]),
					Word = items[3],
					WrongAttempts = int.Parse(items[4])
				};
				records.Add(record);
			}
			return records
				.OrderBy(x => x.ElapsedTime)
				.Take(10)
				.ToArray();
		}


		public void SaveLeaderResult(LeaderRecord newItem)
		{
			var newLine = $"{newItem.Name},{newItem.ElapsedTime},{newItem.Date},{newItem.Word},{newItem.WrongAttempts}";
			File.AppendAllLines(_filePath, new[] { newLine });
		}
	}
}
