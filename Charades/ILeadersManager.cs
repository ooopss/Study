using System.Collections.Generic;


namespace курсач
{
	/// <summary>
	/// Отвечает за управление списком лидеров и его получением
	/// </summary>
    public interface ILeadersManager
    {
		/// <summary>
		/// Коллекция только для чтения лидеров, получать все записи 
		/// </summary>
		/// <returns></returns>
        IReadOnlyCollection<LeaderRecord> GetAllRecords();

		/// <summary>
		/// Сохранение результата лидеров 
		/// </summary>
		/// <param name="newItem"></param>
		void SaveLeaderResult(LeaderRecord newItem);
    }
}
