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
    public partial class Game : Form
    {
        bool left, right;
        int speed = 7;
        int score = 0;
        int missed = 0;
        int counterSpeed = 0;
        int floor = 1;
        int dir = 0; // 0 - levo; 1 - desno
        int i = 0;

        Random randomX = new Random();
        Random randomY = new Random();

        PictureBox splash = new PictureBox();
        SoundPlayer fin;
        SoundPlayer sp;

        const string R_one = "I";
        const string R_two = "II";
        const string R_three = "III";
        const string R_four = "IV";
        const string R_five = "V";
        const string R_six = "VI";
        const string R_seven = "VII";
        const string R_eight = "VIII";
        const string R_nine = "IX";
        const string R_ten = "X"; // na ovoj kat e Tosho xD

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
                Menu.Show(); // Menu e GroupBox

                fin = new SoundPlayer(@"FIN.wav");
                fin.Play();
            }
        }

        public Game()
        {
            InitializeComponent();
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

            if (left == true && Cacko.Left > 0) // ako e pritisnato kopce za levo i levata strana na Cacko e > 0
            {
                Cacko.Left -= 15; // dvizi na levo 15 pixels
                Cacko.Image = Properties.Resources.left; // ja menuva slikata za levo
                dir = 0; // levo
            }

            if (right == true && Cacko.Left + Cacko.Width < this.ClientSize.Width) // ako e pritisnato kopce za desno i Cacko ne izlaga desno od ekran
            {
                Cacko.Left += 15; // go pomestuva igracot 15 pixels desno
                Cacko.Image = Properties.Resources.right; // menuva slika za desno
                dir = 1; // desno
            }

            foreach (Control c in this.Controls) // se izminuvaat site komponenti vo prozorot
            {

                if (c is PictureBox && (string)c.Tag == "Kompiri") // ako e kompir
                {

                    c.Top += speed; // nosi nadolu

                    if (c.Top + c.Height > this.ClientSize.Height) // ako stigne do dnoto na ekranot
                    {
                        splash.Image = Properties.Resources.pire;
                        splash.Location = c.Location; // da se smeni slika od pire na istata lokacija kako kompirot
                        splash.Height = 50;
                        splash.Width = 70;
                        splash.SizeMode = PictureBoxSizeMode.StretchImage;
                        splash.BackColor = Color.Transparent;
                        
                        sp = new SoundPlayer(@"splat.wav");
                        sp.PlaySync();

                        this.Controls.Add(splash); // se dodava slikata od pire

                        // random spawn 
                        //c.Top = randomY.Next(50, 300) * -1;
                        //c.Left = randomX.Next(c.Width, this.ClientSize.Width - c.Width);

                        if (c.Name == "k1")
                        {
                            c.Top = randomY.Next(50, 100) * -1;
                            c.Left = randomX.Next(c.Width, this.ClientSize.Width / 2);
                        }
                        else if (c.Name == "k2")
                        {
                            c.Top = randomY.Next(300, 350) * -1;
                            c.Left = randomX.Next(this.ClientSize.Width / 2, this.ClientSize.Width - c.Width);
                        }

                        missed += 1;
                        hearts();

                        if(dir == 0) {
                            Cacko.Image = Properties.Resources.leftERROR;
                        } 
                        else if (dir == 1)
                        {
                            Cacko.Image = Properties.Resources.rightERROR;
                        }  
                    }

                    if (Cacko.Bounds.IntersectsWith(c.Bounds)) // Cacko go sobral kompirot
                    {
                        //random spawn
                        //c.Top = randomY.Next(50, 300) * -1;
                        //c.Left = randomX.Next(c.Width, this.ClientSize.Width - c.Width);

                        if (c.Name == "k1")
                        {
                            c.Top = randomY.Next(150, 200) * -1;
                            c.Left = randomX.Next(c.Width, this.ClientSize.Width / 2);
                        }
                        else if (c.Name == "k2")
                        {
                            c.Top = randomY.Next(400, 450) * -1;
                            c.Left = randomX.Next(this.ClientSize.Width / 2, this.ClientSize.Width - c.Width);
                        }

                        score += 1;
                        counterSpeed += 1;
                    }
                }
            }

            if (counterSpeed == 10) // na sekoj 10ti kompir da se zgolemi brzinata
            {
                speed += 3; // zgolemuva brzina na paganje na kompirite
                counterSpeed = 0;
                floor += 1;

                switch (floor)
                {
                    case 1:
                        lblFloorNumber.Text = R_one;
                        break;
                    case 2:
                        lblFloorNumber.Text = R_two;
                        break;
                    case 3:
                        lblFloorNumber.Text = R_three;
                        break;
                    case 4:
                        lblFloorNumber.Text = R_four;
                        break;
                    case 5:
                        lblFloorNumber.Text = R_five;
                        break;
                    case 6:
                        lblFloorNumber.Text = R_six;
                        break;
                    case 7:
                        lblFloorNumber.Text = R_seven;
                        break;
                    case 8:
                        lblFloorNumber.Text = R_eight;
                        break;
                    case 9:
                        lblFloorNumber.Text = R_nine;
                        break;
                    case 10:
                        lblFloorNumber.Text = R_ten;
                        break;
                    default:
                        lblFloorNumber.Text = "xD";
                        break;
                } 
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
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A) // pritisnato e kopce za levo
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D) // pritisnato e kopce za desno
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
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && (string)c.Tag == "Kompiri") // gi naogja kompirite
                {
                    // random gi spawn-nuva
                    //x.Top = randomY.Next(50, 100) * -1;
                    //x.Left = randomX.Next(5, this.ClientSize.Width - x.Width);

                    if (c.Name == "k1")
                    {
                        c.Top = randomY.Next(50, 100) * -1;
                        c.Left = randomX.Next(c.Width, this.ClientSize.Width / 2);
                    }
                    else if (c.Name == "k2")
                    {
                        c.Top = randomY.Next(300, 350) * -1;
                        c.Left = randomX.Next(this.ClientSize.Width / 2, this.ClientSize.Width - c.Width);
                    }

                }
            }

            life1.Image = Properties.Resources.heart;
            life2.Image = Properties.Resources.heart;
            life3.Image = Properties.Resources.heart;
            life4.Image = Properties.Resources.heart;
            life5.Image = Properties.Resources.heart;

            Menu.Hide();
            pausedMenu.Hide();

            lblHighScoreValue.Text = Properties.Settings.Default.highScore;
            lblFloorNumber.Text = R_one;

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
            speed = 7;

            left = false;
            right = false;

            counterSpeed = 0;
            floor = 1;

            timer.Start();
        }
    }
}

