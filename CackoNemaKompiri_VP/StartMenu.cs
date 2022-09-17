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


namespace CackoNemaKompiri_VP
{
    public partial class StartMenu : Form
    {
        SoundPlayer player;
        public StartMenu()
        {
            InitializeComponent();
            player = new SoundPlayer("INTRO.wav"); // mi treba wav
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.Show(); 
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            player.Play();
        }
    }
}
