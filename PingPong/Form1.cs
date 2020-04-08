using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        private int speed_vertical = 2;
        private int speed_hor = 2;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();

            timer.Enabled = true;

            Cursor.Hide();
            this.FormBorderStyle =  FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            GamePanel.Top = pole.Bottom -(pole.Bottom / 10);

            noWin.Visible = false;
            noWin.Left = (pole.Width / 2) - (noWin.Width / 2);
            noWin.Top = (pole.Height / 2) - (noWin.Height / 2);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.R)
            {
                pictureBox1.Top = 50;
                pictureBox1.Left = 50;
                speed_hor = 2;
                speed_vertical = 2;
                score = 0;
                noWin.Visible = false;
                timer.Enabled = true;
                schet.Text = "Результат: 0";
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GamePanel.Left = Cursor.Position.X - (GamePanel.Width / 2);
            pictureBox1.Left += speed_hor;
            pictureBox1.Top += speed_vertical;

            if (pictureBox1.Left <= pole.Left)
                speed_hor *= -1;
            if (pictureBox1.Right >= pole.Right)
                speed_hor *= -1;
            if (pictureBox1.Top <= pole.Top)
                speed_hor *= -1;
            if (pictureBox1.Bottom >= pole.Bottom)
            {
                timer.Enabled = false;
                noWin.Visible = true;
            }

            if (pictureBox1.Bottom >= GamePanel.Top && pictureBox1.Bottom <= GamePanel.Bottom && pictureBox1.Left >= GamePanel.Left && pictureBox1.Right <= GamePanel.Right)
            {
                speed_hor += 2;
                speed_vertical += 2;
                speed_vertical *= -1;
                score += 1;
                schet.Text = "Результат: " + score.ToString();

                //смена фона
                //Random randC = new Random();
                //pole.BackColor = Color.FromArgb(randC.Next(150, 300), randC.Next(150, 300), randC.Next(150, 300));
            }
        }
    }
}
