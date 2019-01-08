using System;
using System.Drawing;
using System.Windows.Forms;

namespace курсач
{
	public partial class MainForm : Form
	{
		private IGame _game;

		// TODO research можно ли реализовать INotifyPropertyChanged для _letters и _imageIndex
		private char[] _letters;
		private int _imageIndex;

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

			_imageIndex = 0;
			UpdateImage();
			ShowLetters();
		}

		/// <summary>
		/// Сделать попытку
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonMakeAttemptClick(object sender, EventArgs e)
		{
			var text = TextBoxAttempt.Text.ToLower(); // преобразуем текстовый ввод в нижний регистр
			if (text.Length == 0)
			{
				return;
			}

			var letter = text.ToCharArray()[0]; // первая буква

			var result = _game.MakeAttempt(letter);

			if (result.IsSuccess) // успешная попытка
			{
				// для каждой позиции из угаданных показать букву
				foreach (var item in result.AllLetterPositions)
				{
					_letters[item] = letter;
				}
			}
			else if (result.IsGameFailed) // game over
			{
				// показать полную виселицу и слово целиком
				_imageIndex = 10;
				_letters = _game.Word.ToCharArray();
			}
			else // попытка неудачная
			{
				// прибавить 1 к индексу текущего изображения
				_imageIndex++;
			}

			UpdateImage();
			ShowLetters();
		}

		private void ShowLetters()
		{
			LabelWord.Text = new string(_letters);
		}

		private void UpdateImage()
		{
			if (_imageIndex == 0)
			{
				pictureBox1.Image = null;
				return;
			}
			pictureBox1.Image = (Bitmap)Properties.Resources.ResourceManager
				.GetObject("image" + _imageIndex.ToString());
		}
	}
}
