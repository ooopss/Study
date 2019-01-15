using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace курсач
{
	public partial class LeadersForm : Form
	{
		private readonly IReadOnlyCollection<LeaderRecord> _records;

		public LeadersForm(ILeadersManager manager)
		{
			InitializeComponent();

			_records = manager.GetAllRecords();
			dataGridView1.DataSource = _records;
		}

		private void ButtonCloseClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
