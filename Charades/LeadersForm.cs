using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсач
{
	public partial class LeadersForm : Form
	{
		public LeadersForm()
		{
			InitializeComponent();
			var leaders = _manager.GetLeaders();
		}

		private void LeadersForm_Load(object sender, EventArgs e)
		{

		}
	}
}
