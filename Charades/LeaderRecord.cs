using System;
using System.ComponentModel;

namespace курсач
{
	public class LeaderRecord
    {
		[DisplayName("Имя")]
		public string Name { get; set; }

		[DisplayName("Затраченное время")]
		public TimeSpan ElapsedTime { get; set; }

		[DisplayName("Загаданное слове")]
		public string Word { get; internal set; }

		[DisplayName("Дата")]
		public DateTime Date { get; set; }

		[DisplayName("Количество неверных попыток")]
        public int WrongAttempts { get; set; }
	}
}
