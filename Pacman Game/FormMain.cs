using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class FormMain : Form
    {
        FormGame fg;
        FormME fme;
        FormHelp fh;
        FormHighScore fhs;
        FormSplash fs;

        public FormMain()
        {
            InitializeComponent();
            fs = new FormSplash();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            fs.Show();
        }   

        private void labelStart_MouseEnter(object sender, EventArgs e)
        {
            lblStart.BackColor = Color.DarkBlue;
            lblBuild.BackColor = Color.Black;
            lblHS.BackColor = Color.Black;
            lblHelp.BackColor = Color.Black;
            lblExit.BackColor = Color.Black;
            pBoxp1.Top = 180;
            pBoxp2.Top = 180;
            pBoxp1.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
            pBoxp2.Image = global::Pacman_Game.Properties.Resources.PacmanLeft;
        }

        private void labelBuild_MouseEnter(object sender, EventArgs e)
        {
            lblStart.BackColor = Color.Black;
            lblBuild.BackColor = Color.DarkBlue;
            lblHS.BackColor = Color.Black;
            lblHelp.BackColor = Color.Black;
            lblExit.BackColor = Color.Black;
            pBoxp1.Top = 290;
            pBoxp2.Top = 290;
            pBoxp1.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
            pBoxp2.Image = global::Pacman_Game.Properties.Resources.PacmanLeft;
        }

        private void labelHS_MouseEnter(object sender, EventArgs e)
        {
            lblStart.BackColor = Color.Black;
            lblBuild.BackColor = Color.Black;
            lblHS.BackColor = Color.DarkBlue;
            lblHelp.BackColor = Color.Black;
            lblExit.BackColor = Color.Black;
            pBoxp1.Top = 400;
            pBoxp2.Top = 400;
            pBoxp1.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
            pBoxp2.Image = global::Pacman_Game.Properties.Resources.PacmanLeft;
        }

        private void labelHelp_MouseEnter(object sender, EventArgs e)
        {
            lblStart.BackColor = Color.Black;
            lblBuild.BackColor = Color.Black;
            lblHS.BackColor = Color.Black;
            lblHelp.BackColor = Color.DarkBlue;
            lblExit.BackColor = Color.Black;
            pBoxp1.Top = 510;
            pBoxp2.Top = 510;
            pBoxp1.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
            pBoxp2.Image = global::Pacman_Game.Properties.Resources.PacmanLeft;
        }

        private void labelExit_MouseEnter(object sender, EventArgs e)
        {
            lblStart.BackColor = Color.Black;
            lblBuild.BackColor = Color.Black;
            lblHS.BackColor = Color.Black;
            lblHelp.BackColor = Color.Black;
            lblExit.BackColor = Color.DarkBlue;
            pBoxp1.Top = 620;
            pBoxp2.Top = 620;
            pBoxp1.Image = global::Pacman_Game.Properties.Resources.GreenGhostC;
            pBoxp2.Image = global::Pacman_Game.Properties.Resources.RedGhostC;
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            fg = new FormGame();
            fg.Show();
        }

        private void labelBuild_Click(object sender, EventArgs e)
        {
            fme = new FormME();
            fme.Show();
        }

        private void labelHS_Click(object sender, EventArgs e)
        {
            fhs = new FormHighScore();
            fhs.Show();
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            fh = new FormHelp();
            fh.Show();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("???רוצה לצאת", "", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes")
            {
                Application.Exit();
            }
        }           
    }
}