using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CackoNemaKompiri_VP
{
    public partial class Form1 : Form
    {
        bool left, right;
        int speed = 8;
        int score = 0;
        int missed = 0;
        //int life;

        Random randomX = new Random();
        Random randomY = new Random();

        PictureBox splash = new PictureBox();

        void hearts()
        {
            if (missed == 1)
            {
                life1.Image = Properties.Resources.GREYheart;
            }
            if (missed == 2)
            {
                life2.Image = Properties.Resources.GREYheart;
            }
            if (missed == 3)
            {
                life3.Image = Properties.Resources.GREYheart;
            }
            if (missed == 4)
            {
                life4.Image = Properties.Resources.GREYheart;
            }
            if (missed == 5)
            {
                life5.Image = Properties.Resources.GREYheart;
                //lblGameOver.Show();
                timer.Stop();
                //MessageBox.Show("Game over!\nClick to restart!");
                Menu.Show();
                //restartGame();
            }
        }

        public Form1()
        {
            InitializeComponent();
            //lblGameOver.Hide();
            Menu.Hide();
            restartGame();
            //lblHighScoreValue.Text = Properties.Settings.Default.highScore;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            //lblMissed.Text = "Missed: " + missed;

            if (left == true && Cacko.Left > 0)
            {
                Cacko.Left -= 15;
                Cacko.Image = Properties.Resources.left;
            }

            if (right == true && Cacko.Left + Cacko.Width < this.ClientSize.Width)
            {
                Cacko.Left += 15; // go pomestuva igracot 12 pixels levo
                Cacko.Image = Properties.Resources.right; // menuva slika
            }

            foreach (Control c in this.Controls)
            {

                if (c is PictureBox && (string)c.Tag == "Kompiri")
                {

                    c.Top += speed; // nosi nadolu

                    if (c.Top + c.Height > this.ClientSize.Height) // ako stigne do krajot na ekranot
                    {
                        splash.Image = Properties.Resources.pire;
                        splash.Location = new Point(c.Location.X, c.Location.Y - 5); // -20
                        splash.Height = 50;
                        splash.Width = 70;
                        splash.SizeMode = PictureBoxSizeMode.StretchImage;
                        splash.BackColor = Color.Transparent;

                        this.Controls.Add(splash);

                        c.Top = randomY.Next(80, 300) * -1;
                        c.Left = randomX.Next(5, this.ClientSize.Width - c.Width);
                        missed += 1;
                        hearts();
                        Cacko.Image = Properties.Resources.rightERROR;
                    }

                    if (Cacko.Bounds.IntersectsWith(c.Bounds))
                    {
                        c.Top = randomY.Next(80, 300) * -1;
                        c.Left = randomX.Next(5, this.ClientSize.Width - c.Width);
                        score += 1;
                    }
                }
            }

            if (score > 10)
            {
                speed = 12; // zgolemuva brzina na paganje na kompirite
            }

        }

        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                right = false;
            }

        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) // pritisnato desno kopce

            {
                right = true;
            }
        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void lblQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartGame()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Kompiri") // gi naogja kompirite
                {
                    // random gi spawn-nuva
                    x.Top = randomY.Next(80, 300) * -1;
                    x.Left = randomX.Next(5, this.ClientSize.Width - x.Width);


                }
            }

            life1.Image = Properties.Resources.heart;
            life2.Image = Properties.Resources.heart;
            life3.Image = Properties.Resources.heart;
            life4.Image = Properties.Resources.heart;
            life5.Image = Properties.Resources.heart;

            //lblGameOver.Hide();
            Menu.Hide();

            lblHighScoreValue.Text = Properties.Settings.Default.highScore;

            int max = Int32.Parse(lblHighScoreValue.Text);
            if(score > max)
            {
                lblHighScoreValue.Text = score.ToString();
                Properties.Settings.Default.highScore = lblHighScoreValue.Text;
                Properties.Settings.Default.Save();
            }

            Cacko.Left = this.ClientSize.Width / 2;
            Cacko.Image = Properties.Resources.left;

            score = 0;
            missed = 0;
            speed = 8;

            left = false;
            right = false;

            timer.Start();
        }
    }
}

