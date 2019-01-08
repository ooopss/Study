using System;
using System.Drawing;
using System.Windows.Forms;

namespace курсач
{
	public partial class MainForm : Form
	{
		private char[] _letters;
		private IGame _game;
		private int imageIndex;

		public MainForm()
		{
			InitializeComponent();

			_game = new Game(new WordGenerator());
		}

		/// <summary>
		/// Начать новую игру
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStartGameClick(object sender, EventArgs e)
		{
			var isSingleGame = RadioButtonSingle.Checked;
			if (isSingleGame)
			{
				var credentials = _game.StartSingleGame();

				// строка из точек по количеству букв
				_letters = new string('.', credentials.WordLength).ToCharArray();
			}
			else
			{
				// преобразовать к ниженму регистру, ведь Кошка == кошка
				var word = TextBoxWord.Text.Trim().ToLower();

				var settings = new DualGameSettings
				{
					Word = word
				};

				_game.StartDualGame(settings);
				_letters = new string('.', word.Length).ToCharArray();
			}

			LabelWord.Text = new string(_letters);
		}

		private void ButtonMakeAttemptClick(object sender, EventArgs e)
		{

		}

		private void SetImage(int imageIndex)
		{
			pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("image" + imageIndex.ToString());
		}
	}
}
