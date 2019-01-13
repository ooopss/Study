using System.Collections.Generic;


namespace курсач
{
	/// <summary>
	/// Отвечает за управление списком лидеров и его получением
	/// </summary>
    public interface ILeadersManager
    {
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
        IReadOnlyCollection<LeaderRecord> GetAllRecords();

		/// <summary>
		/// 
		/// </summary>
		/// <param name="newItem"></param>
		void SaveLeaderResult(LeaderRecord newItem);
    }
}
