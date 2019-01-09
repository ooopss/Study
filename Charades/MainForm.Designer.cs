namespace курсач
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.ButtonStartGame = new System.Windows.Forms.Button();
			this.ButtonMakeAttempt = new System.Windows.Forms.Button();
			this.LabelWord = new System.Windows.Forms.Label();
			this.TextBoxWord = new System.Windows.Forms.TextBox();
			this.TextBoxAttempt = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.RadioButtonSingle = new System.Windows.Forms.RadioButton();
			this.RadioButtonDouble = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonStartGame
			// 
			this.ButtonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonStartGame.Location = new System.Drawing.Point(306, 125);
			this.ButtonStartGame.Name = "ButtonStartGame";
			this.ButtonStartGame.Size = new System.Drawing.Size(259, 37);
			this.ButtonStartGame.TabIndex = 1;
			this.ButtonStartGame.Text = "  Начать игру";
			this.ButtonStartGame.UseVisualStyleBackColor = true;
			this.ButtonStartGame.Click += new System.EventHandler(this.ButtonStartGameClick);
			// 
			// ButtonMakeAttempt
			// 
			this.ButtonMakeAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonMakeAttempt.Location = new System.Drawing.Point(306, 242);
			this.ButtonMakeAttempt.Name = "ButtonMakeAttempt";
			this.ButtonMakeAttempt.Size = new System.Drawing.Size(259, 39);
			this.ButtonMakeAttempt.TabIndex = 2;
			this.ButtonMakeAttempt.Text = "Добавить букву";
			this.ButtonMakeAttempt.UseVisualStyleBackColor = true;
			this.ButtonMakeAttempt.Click += new System.EventHandler(this.ButtonMakeAttemptClick);
			// 
			// LabelWord
			// 
			this.LabelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelWord.Location = new System.Drawing.Point(306, 165);
			this.LabelWord.Name = "LabelWord";
			this.LabelWord.Size = new System.Drawing.Size(259, 25);
			this.LabelWord.TabIndex = 3;
			this.LabelWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TextBoxWord
			// 
			this.TextBoxWord.Enabled = false;
			this.TextBoxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextBoxWord.Location = new System.Drawing.Point(306, 79);
			this.TextBoxWord.Multiline = true;
			this.TextBoxWord.Name = "TextBoxWord";
			this.TextBoxWord.Size = new System.Drawing.Size(259, 36);
			this.TextBoxWord.TabIndex = 4;
			// 
			// TextBoxAttempt
			// 
			this.TextBoxAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TextBoxAttempt.Location = new System.Drawing.Point(306, 193);
			this.TextBoxAttempt.Multiline = true;
			this.TextBoxAttempt.Name = "TextBoxAttempt";
			this.TextBoxAttempt.Size = new System.Drawing.Size(259, 43);
			this.TextBoxAttempt.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(287, 263);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// RadioButtonSingle
			// 
			this.RadioButtonSingle.AutoSize = true;
			this.RadioButtonSingle.Checked = true;
			this.RadioButtonSingle.Location = new System.Drawing.Point(6, 20);
			this.RadioButtonSingle.Name = "RadioButtonSingle";
			this.RadioButtonSingle.Size = new System.Drawing.Size(119, 19);
			this.RadioButtonSingle.TabIndex = 7;
			this.RadioButtonSingle.TabStop = true;
			this.RadioButtonSingle.Text = "одиночная игра ";
			this.RadioButtonSingle.UseVisualStyleBackColor = true;
			// 
			// RadioButtonDouble
			// 
			this.RadioButtonDouble.AutoSize = true;
			this.RadioButtonDouble.Location = new System.Drawing.Point(6, 43);
			this.RadioButtonDouble.Name = "RadioButtonDouble";
			this.RadioButtonDouble.Size = new System.Drawing.Size(105, 19);
			this.RadioButtonDouble.TabIndex = 8;
			this.RadioButtonDouble.Text = "игра на двоих";
			this.RadioButtonDouble.UseVisualStyleBackColor = true;
			this.RadioButtonDouble.CheckedChanged += new System.EventHandler(this.RadioButtonDoubleCheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.RadioButtonSingle);
			this.groupBox1.Controls.Add(this.RadioButtonDouble);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(306, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(127, 67);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Способ игры";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(439, 13);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 60);
			this.button1.TabIndex = 10;
			this.button1.Text = "Рейтинг победителей ";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 286);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.TextBoxAttempt);
			this.Controls.Add(this.TextBoxWord);
			this.Controls.Add(this.LabelWord);
			this.Controls.Add(this.ButtonMakeAttempt);
			this.Controls.Add(this.ButtonStartGame);
			this.Name = "MainForm";
			this.Text = "Виселица";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonStartGame;
        private System.Windows.Forms.Button ButtonMakeAttempt;
        private System.Windows.Forms.Label LabelWord;
        private System.Windows.Forms.TextBox TextBoxWord;
        private System.Windows.Forms.TextBox TextBoxAttempt;
        private System.Windows.Forms.RadioButton RadioButtonSingle;
        private System.Windows.Forms.RadioButton RadioButtonDouble;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
	}
}

