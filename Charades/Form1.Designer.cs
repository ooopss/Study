﻿namespace курсач
{
    partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonStartGame
			// 
			this.ButtonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ButtonStartGame.Location = new System.Drawing.Point(306, 58);
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
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(306, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 85);
			this.label1.TabIndex = 3;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(306, 2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(259, 50);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(306, 193);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(259, 43);
			this.textBox2.TabIndex = 5;
			// 
			// PictureBox
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 13);
			this.pictureBox1.Name = "PictureBox";
			this.pictureBox1.Size = new System.Drawing.Size(287, 263);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 288);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ButtonMakeAttempt);
			this.Controls.Add(this.ButtonStartGame);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonStartGame;
        private System.Windows.Forms.Button ButtonMakeAttempt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
	}
}

