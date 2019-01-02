using System;
using System.Drawing;
using System.Windows.Forms;
namespace курсач
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string text;
        private char[] word;
        private int imageIndex;
        private int imatrue;
        private void ButtonStartGameСlick(object sender, EventArgs e)
        {
            text = textBox1.Text; // Обнуляем все переменные
            imageIndex = 0;
            label1.Text = null;
            textBox1.Text = null;
            var dots = new string('.', text.Length);
            label1.Text = dots;
            word = dots.ToCharArray();
        }

        private void ButtonMakeAttemptClick(object sender, EventArgs e)
        {
            var words = false;
            
            if (textBox2.Text.Length == 1) // Для одной буквы
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (textBox2.Text[0] == text[i])
                    {
                        words = true;
                        imatrue++;
                        word[i] = text[i];
                        label1.Text = null;
                    }
                }
                if (words)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += word[i];
                    }
                    if (imatrue == text.Length)
                    {
                        MessageBox.Show("Ты победил!");
                    }
                }
                else
                {
                    imageIndex++;
                    string hpbuff = imageIndex.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    if (imageIndex == 10)
                    {
                        MessageBox.Show("Ты проиграл!");
                        label1.Text = null;
                        label1.Text = text;
                    }
                }

            }
            else if (textBox2.Text.Length > 1) // Для полного ответа
            {
                if (textBox2.Text == text)
                {
                    label1.Text = null;
                    for (int i = 0; i < text.Length; i++)
                    {
                        label1.Text += text[i];
                    }
                    MessageBox.Show("Ты победил!");
                }
                else
                {
                    imageIndex = 10;
                    string hpbuff = imageIndex.ToString() + ".png";
                    pictureBox1.Image = new Bitmap(hpbuff);
                    MessageBox.Show("Ты проиграл!");
                    label1.Text = null;
                    label1.Text = text;
                }
            }
            textBox2.Text = null;
        }
    }
}
