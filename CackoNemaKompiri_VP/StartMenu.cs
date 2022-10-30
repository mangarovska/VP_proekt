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
        public SoundPlayer intro;

        public StartMenu()
        {
            InitializeComponent();
            lblHS.Text = Properties.Settings.Default.highScore;

        }

        private void pbStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            MP.Ctlcontrols.stop(); // pozadinskata muzika zapira (i se pushta pak vo noviot prozorec)
            this.Hide();
            game.Show();
        }

        private void PlayIntro()
        {
            intro = new SoundPlayer(@"INTRO.wav");
            intro.Play();
        }

        private void PlayMusic()
        {
            MP.Visible = false;
            MP.URL = @"Gradinarot.wav";
            MP.settings.playCount = 9999; // looping
            MP.settings.volume = 30;
            MP.Ctlcontrols.play();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            PlayMusic();
            PlayIntro();  
        }
    }
}
