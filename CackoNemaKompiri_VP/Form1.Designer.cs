namespace CackoNemaKompiri_VP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblRestart = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblHighScoreValue = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.GroupBox();
            this.lblQuit = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.life5 = new System.Windows.Forms.PictureBox();
            this.life4 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.Cacko = new System.Windows.Forms.PictureBox();
            this.pbMute = new System.Windows.Forms.PictureBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            this.pausedMenu = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MPForm = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblFloorNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cacko)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
            this.pausedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.BackColor = System.Drawing.Color.Transparent;
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRestart.Location = new System.Drawing.Point(183, 94);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(74, 24);
            this.lblRestart.TabIndex = 2;
            this.lblRestart.Text = "Restart";
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblGameOver.Location = new System.Drawing.Point(109, 41);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(235, 39);
            this.lblGameOver.TabIndex = 7;
            this.lblGameOver.Text = "GAME OVER";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(71, 12);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(121, 24);
            this.lblHighScore.TabIndex = 2;
            this.lblHighScore.Text = "High Score:";
            // 
            // lblHighScoreValue
            // 
            this.lblHighScoreValue.AutoSize = true;
            this.lblHighScoreValue.BackColor = System.Drawing.Color.Transparent;
            this.lblHighScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreValue.Location = new System.Drawing.Point(188, 12);
            this.lblHighScoreValue.Name = "lblHighScoreValue";
            this.lblHighScoreValue.Size = new System.Drawing.Size(21, 24);
            this.lblHighScoreValue.TabIndex = 2;
            this.lblHighScoreValue.Text = "0";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Transparent;
            this.Menu.Controls.Add(this.lblGameOver);
            this.Menu.Controls.Add(this.lblQuit);
            this.Menu.Controls.Add(this.lblRestart);
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.Location = new System.Drawing.Point(86, 216);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(434, 183);
            this.Menu.TabIndex = 8;
            this.Menu.TabStop = false;
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.BackColor = System.Drawing.Color.Transparent;
            this.lblQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblQuit.Location = new System.Drawing.Point(196, 134);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(48, 24);
            this.lblQuit.TabIndex = 2;
            this.lblQuit.Text = "Quit";
            this.lblQuit.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(71, 36);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(88, 24);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score: 0";
            // 
            // life5
            // 
            this.life5.BackColor = System.Drawing.Color.Transparent;
            this.life5.Image = ((System.Drawing.Image)(resources.GetObject("life5.Image")));
            this.life5.Location = new System.Drawing.Point(562, 23);
            this.life5.Name = "life5";
            this.life5.Size = new System.Drawing.Size(40, 34);
            this.life5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life5.TabIndex = 6;
            this.life5.TabStop = false;
            // 
            // life4
            // 
            this.life4.BackColor = System.Drawing.Color.Transparent;
            this.life4.Image = ((System.Drawing.Image)(resources.GetObject("life4.Image")));
            this.life4.Location = new System.Drawing.Point(519, 23);
            this.life4.Name = "life4";
            this.life4.Size = new System.Drawing.Size(40, 34);
            this.life4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life4.TabIndex = 6;
            this.life4.TabStop = false;
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.Image = ((System.Drawing.Image)(resources.GetObject("life3.Image")));
            this.life3.Location = new System.Drawing.Point(473, 23);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(40, 34);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life3.TabIndex = 6;
            this.life3.TabStop = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.Image = ((System.Drawing.Image)(resources.GetObject("life2.Image")));
            this.life2.Location = new System.Drawing.Point(427, 23);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(40, 34);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life2.TabIndex = 6;
            this.life2.TabStop = false;
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.Image = global::CackoNemaKompiri_VP.Properties.Resources.heart;
            this.life1.Location = new System.Drawing.Point(381, 23);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(40, 34);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.life1.TabIndex = 6;
            this.life1.TabStop = false;
            // 
            // Cacko
            // 
            this.Cacko.BackColor = System.Drawing.Color.Transparent;
            this.Cacko.Image = global::CackoNemaKompiri_VP.Properties.Resources.right;
            this.Cacko.Location = new System.Drawing.Point(249, 651);
            this.Cacko.Name = "Cacko";
            this.Cacko.Size = new System.Drawing.Size(94, 118);
            this.Cacko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cacko.TabIndex = 3;
            this.Cacko.TabStop = false;
            // 
            // pbMute
            // 
            this.pbMute.BackColor = System.Drawing.Color.Transparent;
            this.pbMute.Image = global::CackoNemaKompiri_VP.Properties.Resources.mute;
            this.pbMute.Location = new System.Drawing.Point(12, 12);
            this.pbMute.Name = "pbMute";
            this.pbMute.Size = new System.Drawing.Size(45, 45);
            this.pbMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMute.TabIndex = 10;
            this.pbMute.TabStop = false;
            this.pbMute.Click += new System.EventHandler(this.pbMute_Click);
            // 
            // pbPlay
            // 
            this.pbPlay.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay.Image = global::CackoNemaKompiri_VP.Properties.Resources.play;
            this.pbPlay.Location = new System.Drawing.Point(12, 12);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(45, 45);
            this.pbPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay.TabIndex = 10;
            this.pbPlay.TabStop = false;
            this.pbPlay.Click += new System.EventHandler(this.pbPlay_Click);
            // 
            // pausedMenu
            // 
            this.pausedMenu.BackColor = System.Drawing.Color.Transparent;
            this.pausedMenu.Controls.Add(this.label1);
            this.pausedMenu.Controls.Add(this.label2);
            this.pausedMenu.Controls.Add(this.label4);
            this.pausedMenu.Controls.Add(this.label3);
            this.pausedMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pausedMenu.Location = new System.Drawing.Point(79, 216);
            this.pausedMenu.Name = "pausedMenu";
            this.pausedMenu.Size = new System.Drawing.Size(434, 206);
            this.pausedMenu.TabIndex = 8;
            this.pausedMenu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(83, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "GAME PAUSED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(189, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quit";
            this.label2.Click += new System.EventHandler(this.lblQuit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(165, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Continue";
            this.label4.Click += new System.EventHandler(this.lblContinue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(175, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Restart";
            this.label3.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // MPForm
            // 
            this.MPForm.Enabled = true;
            this.MPForm.Location = new System.Drawing.Point(12, 63);
            this.MPForm.Name = "MPForm";
            this.MPForm.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MPForm.OcxState")));
            this.MPForm.Size = new System.Drawing.Size(37, 35);
            this.MPForm.TabIndex = 11;
            // 
            // lblFloorNumber
            // 
            this.lblFloorNumber.AutoSize = true;
            this.lblFloorNumber.BackColor = System.Drawing.Color.DarkKhaki;
            this.lblFloorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloorNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFloorNumber.Location = new System.Drawing.Point(557, 63);
            this.lblFloorNumber.Name = "lblFloorNumber";
            this.lblFloorNumber.Size = new System.Drawing.Size(25, 25);
            this.lblFloorNumber.TabIndex = 7;
            this.lblFloorNumber.Text = "I ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkKhaki;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(456, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "FLOOR: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(272, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Kompiri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(215)))), ((int)(((byte)(206)))));
            this.BackgroundImage = global::CackoNemaKompiri_VP.Properties.Resources.plocki;
            this.ClientSize = new System.Drawing.Size(614, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFloorNumber);
            this.Controls.Add(this.MPForm);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.pbMute);
            this.Controls.Add(this.pausedMenu);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.life5);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.life4);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cacko);
            this.Controls.Add(this.lblHighScoreValue);
            this.Controls.Add(this.lblHighScore);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цацко нема компири";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.life5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cacko)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.pausedMenu.ResumeLayout(false);
            this.pausedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MPForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.PictureBox Cacko;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.PictureBox life4;
        private System.Windows.Forms.PictureBox life5;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblHighScoreValue;
        private System.Windows.Forms.GroupBox Menu;
        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbMute;
        private System.Windows.Forms.PictureBox pbPlay;
        private System.Windows.Forms.GroupBox pausedMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer MPForm;
        private System.Windows.Forms.Label lblFloorNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

