﻿using System;
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
		private readonly ILeadersManager _manager;
		private string _playerName;
		private DateTime _startTime;

		public MainForm()
		{
			InitializeComponent();

			// Создаем зависимости
			_game = new Game(new WordGenerator());
			_manager = new LeadersManager();
		}

		/// <summary>
		/// Начать новую игру
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonStartGameClick(object sender, EventArgs e)
		{
			using (var newNameForm = new NewName())
			{
				newNameForm.ShowDialog();
				_playerName = newNameForm.PlayerName;
			}

			_startTime = DateTime.Now;

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
				TextBoxWord.Text = string.Empty;

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
			// преобразуем текстовый ввод в нижний регистр и чистим от пробелов
			var text = TextBoxAttempt.Text.ToLower().Trim();
			if (text.Length == 0)
			{
				TextBoxAttempt.Focus();
				return;
			}

			var letter = text.ToCharArray()[0]; // первая буква

			var result = _game.MakeAttempt(letter);

			switch (result.Status)
			{
				case AttemptStatus.WordGuessed: // слово угадано целиком
				{
					var newItem = new LeaderRecord
					{
						Name = _playerName,
						ElapsedTime = DateTime.Now - _startTime,
						Date = DateTime.Today,
						Word = _game.Word,
						WrongAttempts = _game.WrongAttemptsCount
					};

					_manager.SaveLeaderResult(newItem);
					_letters = _game.Word.ToCharArray();

					MessageBox.Show("Вы победили!");
					break;
				}
				case AttemptStatus.LetterGuessed: // успешная попытка
				{
					// для каждой позиции из угаданных показать букву
					foreach (var item in result.AllLetterPositions)
					{
						_letters[item] = letter;
					}
					break;
				}
				case AttemptStatus.GameFailed: // game over
				{
					// показать полную виселицу и слово целиком
					_imageIndex = 9;
					_letters = _game.Word.ToCharArray();
					MessageBox.Show("Вы проиграли!");
					break;
				}
				case AttemptStatus.Duplicated:
				{
					MessageBox.Show("Уже было...");
					break;
				}
				case AttemptStatus.Failed: // попытка неудачная
				{
					// прибавить 1 к индексу текущего изображения
					_imageIndex++;
					break;
				}
				default:
				{
					throw new InvalidOperationException("AttemptStatus не определен");
				}
			}

			UpdateImage();
			ShowLetters();

			TextBoxAttempt.Text = string.Empty;
			TextBoxAttempt.Focus();
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

		private void RadioButtonDoubleCheckedChanged(object sender, EventArgs e)
		{
			TextBoxWord.Enabled = RadioButtonDouble.Checked;
		}

		private void ButtonShowLeadersClick(object sender, EventArgs e)
		{
			using (var newLeadersForm = new LeadersForm(_manager))
			{
				newLeadersForm.ShowDialog();
			}
		}
	}
}
