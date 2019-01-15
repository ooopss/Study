using System;
using System.Windows.Forms;

namespace курсач
{
	public partial class NewName : Form
	{
		public NewName()
		{
			InitializeComponent();
		}

		public string PlayerName { get; set; }

		private void ButtonOkClick(object sender, EventArgs e)
		{
			PlayerName = TextBoxName.Text;
			Close();
		}
	}
}
