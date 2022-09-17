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
    public partial class StartMenu : Form
    {
        public SoundPlayer player;
        public SoundPlayer intro;

        public StartMenu()
        {
            InitializeComponent();
            lblHS.Text = Properties.Settings.Default.highScore;

            MP.Visible = false;
            MP.URL = @"Gradinarot.wav";
            MP.settings.playCount = 9999; // looping
            MP.settings.volume = 30;
            MP.Ctlcontrols.play();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            MP.Ctlcontrols.stop();
            this.Hide();
            game.Show();
        }

        private void PlayIntro()
        {
            intro = new SoundPlayer(@"INTRO.wav");
            intro.Play();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            PlayIntro();
        }
    }
}
