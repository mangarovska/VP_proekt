using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

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
        SoundPlayer fin;
        SoundPlayer sp;

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
                timer.Stop();
                Menu.Show();

                fin = new SoundPlayer(@"FIN.wav");
                fin.Play();


            }
        }

        public Form1()
        {
            InitializeComponent();
            //lblGameOver.Hide();
            Menu.Hide();
            pausedMenu.Hide();
            restartGame();

            MPForm.Visible = false;
            MPForm.URL = @"Gradinarot.wav";
            MPForm.settings.playCount = 9999; // looping
            MPForm.Ctlcontrols.play();

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                timer.Stop();
                pausedMenu.Show();
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
                        
                        sp = new SoundPlayer(@"splat.wav");
                        sp.PlaySync();

                        this.Controls.Add(splash);

                        c.Top = randomY.Next(80, 300) * -1;
                        c.Left = randomX.Next(5, this.ClientSize.Width - c.Width);
                        missed += 1;
                        hearts();

                        if(Cacko.Image == Properties.Resources.left) {   // ???????????????
                            Cacko.Image = Properties.Resources.leftERROR;
                        } else
                        {
                            Cacko.Image = Properties.Resources.rightERROR;
                        }
                        
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

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //player.PlayLooping();
           
        }

        private void pbPlay_Click(object sender, EventArgs e)
        {
            MPForm.Ctlcontrols.pause();     
            pbMute.Visible = true;
            pbPlay.Visible = false;
        }

        private void pbMute_Click(object sender, EventArgs e)
        {
            MPForm.Ctlcontrols.play();
            pbMute.Visible = false;
            pbPlay.Visible = true;
        }

        private void lblContinue_Click(object sender, EventArgs e)
        {
            timer.Start();
            pausedMenu.Visible = false;
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
            pausedMenu.Hide();

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

