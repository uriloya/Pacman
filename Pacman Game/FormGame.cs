using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Pacman_Game
{
    public partial class FormGame : Form
    {
        bool moving, map, mute, bStart, blue;
        string LatestKey1, LatestKey2, st, sPath, s1;
        int i, j, p, level, r, num, countblue, countd;
        int[] lposx, lposy;
        Random rnd;
        Pacman pacman, pacmanb;
        Ghost[] ghost;
        PictureBox picPacman;
        PictureBox[] picGhost;
        Label[,] lbl;
        TextReader tr, tr1;
        OpenFileDialog ofd;
        SoundPlayer sndstart, snddeath, sndchomp, sndcherry, sndbdot, sndend, sndfinal, sndghost;
        FileInfo fi;
        StreamWriter sw;
     
        public FormGame()
        {
            InitializeComponent();
            moving = false;
            p = 0;
            num = 0;
            lposx = new int[5];
            lposy = new int[5];
            rnd = new Random();
            blue = false;
            countblue = 0;
            countd = 0;
            sPath = Application.StartupPath;
            sndstart = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\sndstart.wav");
            snddeath = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\snddeath.wav");
            sndchomp = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\sndchomp.wav");
            sndcherry = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\sndcherry.wav");
            sndbdot = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\sndbdot.wav");
            sndend = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\sndend.wav");
            sndfinal = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\sndfinal.wav");
            sndghost = new SoundPlayer(sPath + "\\..\\..\\..\\Database\\sndghost.wav");

            if (level == 0)
            {
                level = 1;
            }
            lbl = new Label[23, 23];
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            moving = true;
            string Pacman_Direction = e.KeyData.ToString();
            LatestKey1 = Pacman_Direction.ToString();
        }

        private void PacmanMove()
        {
            switch (LatestKey1)
            {
                case "Left":

                    boolLeft_p();

                    break;
                case "Right":

                    boolRight_p();

                    break;
                case "Up":

                    boolUp_p();

                    break;

                case "Down":

                    boolDown_p();

                    break;     
            }

            switch (LatestKey2)
            {
                case "Left":

                    MoveLeft_p();

                    break;
                case "Right":

                    MoveRight_p();

                    break;

                case "Up":

                    MoveUp_p();

                    break;

                case "Down":

                    MoveDown_p();

                    break;
            }
            picPacman.Left = pacman.Getx();     
            picPacman.Top = pacman.Gety();                            
        }

        private void boolLeft_p()
        {
            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((pacman.Getx() - pacman.Getprogrl()) == (lbl[i, j].Location.X + 30)) && (pacman.Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        LatestKey2 = "Left";
                    }
                }
            }
        }

        private void boolRight_p()
        {
            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((pacman.Getx() + 30 - pacman.Getprogrl()) == (lbl[i, j].Location.X)) && (pacman.Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        LatestKey2 = "Right";
                    }
                }
            }
        }

        private void boolUp_p()
        {
            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((pacman.Gety() - pacman.Getprogud()) == (lbl[i, j].Location.Y + 30)) && (pacman.Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black)))
                    {
                        LatestKey2 = "Up";
                    }
                }
            }
        }

        private void boolDown_p()
        {
            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((pacman.Gety() + 30 - pacman.Getprogud()) == (lbl[i, j].Location.Y)) && (pacman.Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black)))
                    {
                        LatestKey2 = "Down";
                    }
                }
            }
        }

        private void MoveLeft_p()
        {
            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((pacman.Getx() - pacman.Getprogrl()) == (lbl[i, j].Location.X + 30)) && (pacman.Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanLeft;
                        pacman.Setx(-2);
                        pacman.Setprogrl((pacman.Getprogrl() - 2));
                        if (pacman.Getprogrl() == -30)
                        {
                            pacman.Setprogrl(0);
                        }
                        pacman.Setprogud(0);
                    }
                    else if ((((pacman.Getx() - pacman.Getprogrl()) == (lbl[i, j].Location.X + 30)) && (pacman.Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Navy && lbl[i,j].Text == "<<<<<<"))
                    {
                        countd++;
                        if (countd == 15)
                        {
                            picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanLeft;
                            pacman.SetStartPosition(lbl[22, 11].Location.X, 340);
                            pacman.Setprogrl(0);
                            pacman.Setprogud(0);
                            countd = 0;
                        }
                        else
                        {
                            picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanLeft;
                            pacman.Setx(-2);
                            pacman.Setprogrl((pacman.Getprogrl() - 2));
                            if (pacman.Getprogrl() == -30)
                            {
                                pacman.Setprogrl(0);
                            }
                            pacman.Setprogud(0);
                        }
                    }

                    if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "1"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(10);
                        p--;
                        if (mute != true)
                        {
                            sndchomp.Play();
                        }
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "2"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(50);
                        if (mute != true)
                        {
                            sndbdot.Play();
                        }
                        countblue = 0;
                        blue = true;
                        tmr1.Interval = 1;
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "3"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(200);
                        if (mute != true)
                        {
                            sndcherry.Play();
                        }
                    }
                }
            }
        }

        private void MoveRight_p()
        {
            int oxp, nxp;
            oxp = pacman.Getx();

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((pacman.Getx() + 30 - pacman.Getprogrl()) == (lbl[i, j].Location.X)) && (pacman.Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                        pacman.Setx(2);
                        pacman.Setprogrl((pacman.Getprogrl() + 2));
                        if (pacman.Getprogrl() == 30)
                        {
                            pacman.Setprogrl(0);
                        }
                        pacman.Setprogud(0);                       
                    }
                    else if ((((pacman.Getx() + 30 - pacman.Getprogrl()) == (lbl[i, j].Location.X)) && (pacman.Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Navy && lbl[i, j].Text == ">>>>>>"))
                    {
                        countd++;
                        if (countd == 15)
                        {
                            picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                            pacman.SetStartPosition(lbl[0, 11].Location.X, 340);
                            pacman.Setprogrl(0);
                            pacman.Setprogud(0);
                            countd = 0;
                        }
                        else
                        {
                            picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                            pacman.Setx(2);
                            pacman.Setprogrl((pacman.Getprogrl() + 2));
                            if (pacman.Getprogrl() == 30)
                            {
                                pacman.Setprogrl(0);
                            }
                            pacman.Setprogud(0);      
                        }
                    }

                    if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "1"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(10);
                        p--;
                        if (mute != true)
                        {
                            sndchomp.Play();
                        }
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "2"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(50);
                        if (mute != true)
                        {
                            sndbdot.Play();
                        }
                        countblue = 0;
                        blue = true;
                        tmr1.Interval = 1;
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "3"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(200);
                        if (mute != true)
                        {
                            sndcherry.Play();
                        }
                    }
                }
            }

            nxp = pacman.Getx();
            if (Math.Abs(nxp - oxp) > 2)
            {
                pacman.Setprogrl((pacman.Getprogrl() - 2));
                pacman.Setx(-2);
            }
        }

        private void MoveUp_p()
        {
            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((pacman.Gety() - pacman.Getprogud()) == (lbl[i, j].Location.Y + 30)) && (pacman.Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black)))
                    {
                        picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanUp;
                        pacman.Sety(-2);
                        pacman.Setprogud((pacman.Getprogud() - 2));
                        if (pacman.Getprogud() == -30)
                        {
                            pacman.Setprogud(0);
                        }
                        pacman.Setprogrl(0);                    
                    }

                    if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "1"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(10);
                        p--;
                        if (mute != true)
                        {
                            sndchomp.Play();
                        }
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "2"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(50);
                        if (mute != true)
                        {
                            sndbdot.Play();
                        }
                        countblue = 0;
                        blue = true;
                        tmr1.Interval = 1;
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "3"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(200);
                        if (mute != true)
                        {
                            sndcherry.Play();
                        }
                    }
                }
            }
        }

        private void MoveDown_p()
        {
            int oyp, nyp;     
            oyp = pacman.Gety();

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if (((pacman.Gety() + 30 - pacman.Getprogud()) == (lbl[i, j].Location.Y)) && (pacman.Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black))
                    {
                        picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanDown;
                        pacman.Sety(2);
                        pacman.Setprogud((pacman.Getprogud() + 2));
                        if (pacman.Getprogud() == 30)
                        {
                            pacman.Setprogud(0);     
                        }
                        pacman.Setprogrl(0);      
                    }

                    if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "1"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(10);
                        p--;
                        if (mute != true)
                        {
                            sndchomp.Play();
                        }
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "2"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(50);
                        if (mute != true)
                        {
                            sndbdot.Play();
                        }
                        countblue = 0;
                        blue = true;
                        tmr1.Interval = 1;
                    }
                    else if ((pacman.Getx() == lbl[i, j].Location.X) && (pacman.Gety() == lbl[i, j].Location.Y) && (lbl[i, j].Tag.ToString() == "3"))
                    {
                        lbl[i, j].Image = null;
                        lbl[i, j].Tag = "0";
                        pacman.Setscore(200);
                        if (mute != true)
                        {
                            sndcherry.Play();
                        }
                    }
                }
            }

            nyp = pacman.Gety();
            if (Math.Abs(nyp - oyp) > 2)
            {
                pacman.Setprogud((pacman.Getprogud() - 2));
                pacman.Sety(-2);
            }
        }

        private void Ghost_dir()
        {
            r = rnd.Next(0, 3);
            if (ghost[num].GetLatestKey2() == "Left")
            {
                switch (r)
                {
                    case 0:
                        ghost[num].SetLatestKey1("Left");
                        break;
                    case 1:
                        ghost[num].SetLatestKey1("Up");
                        break;
                    case 2:
                        ghost[num].SetLatestKey1("Down");
                        break;
                }
            }
            else if (ghost[num].GetLatestKey2() == "Right")
            {
                switch (r)
                {
                    case 0:
                        ghost[num].SetLatestKey1("Right");
                        break;
                    case 1:
                        ghost[num].SetLatestKey1("Up");
                        break;
                    case 2:
                        ghost[num].SetLatestKey1("Down");
                        break;
                }
            }
            else if (ghost[num].GetLatestKey2() == "Up")
            {
                switch (r)
                {
                    case 0:
                        ghost[num].SetLatestKey1("Left");
                        break;
                    case 1:
                        ghost[num].SetLatestKey1("Right");
                        break;
                    case 2:
                        ghost[num].SetLatestKey1("Up");
                        break;
                }
            }
            else if (ghost[num].GetLatestKey2() == "Down")
            {
                switch (r)
                {
                    case 0:
                        ghost[num].SetLatestKey1("Left");
                        break;
                    case 1:
                        ghost[num].SetLatestKey1("Right");
                        break;
                    case 2:
                        ghost[num].SetLatestKey1("Down");
                        break;
                }
            }
        }

        private void GhostMove()
        {
            switch (ghost[num].GetLatestKey1())
            {
                case "Left":

                    boolLeft_g();

                    break;
                case "Right":

                    boolRight_g();

                    break;
                case "Up":

                    boolUp_g();

                    break;

                case "Down":

                    boolDown_g();

                    break;
            }

            switch (ghost[num].GetLatestKey2())
            {
                case "Left":

                    MoveLeft_g();

                    break;
                case "Right":

                    MoveRight_g();

                    break;

                case "Up":

                    MoveUp_g();

                    break;

                case "Down":

                    MoveDown_g();

                    break;
            }
            picGhost[num].Left = ghost[num].Getx();
            picGhost[num].Top = ghost[num].Gety();

        }

        private void boolLeft_g()
        {

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((ghost[num].Getx() - ghost[num].Getprogrl()) == (lbl[i, j].Location.X + 30)) && (ghost[num].Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        ghost[num].SetLatestKey2("Left");
                    }
                }
            }

        }

        private void boolRight_g()
        {

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((ghost[num].Getx() + 30 - ghost[num].Getprogrl()) == (lbl[i, j].Location.X)) && (ghost[num].Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        ghost[num].SetLatestKey2("Right");
                    }
                }
            }

        }

        private void boolUp_g()
        {

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((ghost[num].Gety() - ghost[num].Getprogud()) == (lbl[i, j].Location.Y + 30)) && (ghost[num].Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black)))
                    {
                        ghost[num].SetLatestKey2("Up");
                    }
                }
            }

        }

        private void boolDown_g()
        {

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((ghost[num].Gety() + 30 - ghost[num].Getprogud()) == (lbl[i, j].Location.Y)) && (ghost[num].Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black)))
                    {
                        ghost[num].SetLatestKey2("Down");
                    }
                }
            }

        }

        private void MoveLeft_g()
        {

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((ghost[num].Getx() - ghost[num].Getprogrl()) == (lbl[i, j].Location.X + 30)) && (ghost[num].Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        switch (num)
                        {
                            case 0:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.GreenGhostL;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 1:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.RedGhostL;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 2:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.PurpleGhostL;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 3:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.YellowGhostL;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 4:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.BlueGhostL;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                        }
                        ghost[num].Setx(-2);
                        ghost[num].Setprogrl((ghost[num].Getprogrl() - 2));
                        if (ghost[num].Getprogrl() == -30)
                        {
                            ghost[num].Setprogrl(0);
                        }
                        ghost[num].Setprogud(0);
                    }
                }
            }
        }

        private void MoveRight_g()
        {

            int oxg, nxg;
            oxg = ghost[num].Getx();

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((ghost[num].Getx() + 30 - ghost[num].Getprogrl()) == (lbl[i, j].Location.X)) && (ghost[num].Gety() == lbl[i, j].Location.Y)) && (lbl[i, j].BackColor == Color.Black))
                    {
                        switch (num)
                        {
                            case 0:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.GreenGhostR;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 1:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.RedGhostR;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 2:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.PurpleGhostR;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 3:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.YellowGhostR;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 4:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.BlueGhostR;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                        }
                        ghost[num].Setx(2);
                        ghost[num].Setprogrl((ghost[num].Getprogrl() + 2));
                        if (ghost[num].Getprogrl() == 30)
                        {
                            ghost[num].Setprogrl(0);
                        }
                        ghost[num].Setprogud(0);
                    }
                }
            }

            nxg = ghost[num].Getx();
            if (Math.Abs(nxg - oxg) > 2)
            {
                ghost[num].Setprogrl((ghost[num].Getprogrl() - 2));
                ghost[num].Setx(-2);
            }

        }

        private void MoveUp_g()
        {

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if ((((ghost[num].Gety() - ghost[num].Getprogud()) == (lbl[i, j].Location.Y + 30)) && (ghost[num].Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black)))
                    {
                        switch (num)
                        {
                            case 0:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.GreenGhostU;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 1:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.RedGhostU;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 2:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.PurpleGhostU;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 3:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.YellowGhostU;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 4:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.BlueGhostU;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                        }
                        ghost[num].Sety(-2);
                        ghost[num].Setprogud((ghost[num].Getprogud() - 2));
                        if (ghost[num].Getprogud() == -30)
                        {
                            ghost[num].Setprogud(0);
                        }
                        ghost[num].Setprogrl(0);
                    }
                }
            }
        }


        private void MoveDown_g()
        {

            int oyg, nyg;
            oyg = ghost[num].Gety();

            for (i = 0; i < 23; i++)
            {
                for (j = 0; j < 23; j++)
                {
                    if (((ghost[num].Gety() + 30 - ghost[num].Getprogud()) == (lbl[i, j].Location.Y)) && (ghost[num].Getx() == lbl[i, j].Location.X) && (lbl[i, j].BackColor == Color.Black))
                    {
                        switch (num)
                        {
                            case 0:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.GreenGhostD;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 1:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.RedGhostD;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 2:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.PurpleGhostD;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 3:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.YellowGhostD;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                            case 4:
                                if (blue == false)
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.BlueGhostD;
                                }
                                else
                                {
                                    picGhost[num].Image = global::Pacman_Game.Properties.Resources.TheBlueGhost;
                                }
                                break;
                        }
                        ghost[num].Sety(2);
                        ghost[num].Setprogud((ghost[num].Getprogud() + 2));
                        if (ghost[num].Getprogud() == 30)
                        {
                            ghost[num].Setprogud(0);
                        }
                        ghost[num].Setprogrl(0);
                    }
                }
            }

            nyg = ghost[num].Gety();
            if (Math.Abs(nyg - oyg) > 2)
            {
                ghost[num].Setprogud((ghost[num].Getprogud() - 2));
                ghost[num].Sety(-2);
            }

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (moving == true)
            {
                PacmanMove();               
            }

            for (int w = 0; w < picGhost.Length; w++)
            {
                if (pacman.Getx() <= (ghost[w].Getx() + 10) && pacman.Getx() >= (ghost[w].Getx() - 10) && pacman.Gety() <= (ghost[w].Gety() + 10) && pacman.Gety() >= (ghost[w].Gety() - 10) && blue == false)
                {
                    if (mute != true)
                    {
                        snddeath.Play();
                    }
                    pacman.SetStartPosition(540, 520);
                    LatestKey1 = null;
                    LatestKey2 = null;    
                    pacman.Setprogrl(0);
                    pacman.Setprogud(0);
                    pacman.Setlives();
                    if (pacman.Getlives() == 0)
                    {
                        pBoxl3.Image = null;
                        tmr1.Enabled = false;
                        tmr2.Enabled = false;
                        MessageBox.Show("הפסדת");
                        UpdateScore(pacman.Getscore());
                    }
                    else if (pacman.Getlives() == 2)
                    {
                        pBoxl1.Image = null;
                    }
                    else if (pacman.Getlives() == 1)
                    {
                        pBoxl2.Image = null;
                    }
                }
                else if (pacman.Getx() <= (ghost[w].Getx() + 10) && pacman.Getx() >= (ghost[w].Getx() - 10) && pacman.Gety() <= (ghost[w].Gety() + 10) && pacman.Gety() >= (ghost[w].Gety() - 10) && blue == true)
                {
                    if (mute != true)
                    {
                        sndghost.Play();
                    }
                    ghost[w].SetStartPosition(540, 340);
                    ghost[w].Setprogrl(0);
                    ghost[w].Setprogud(0);
                    pacman.Setscore(100);
                }
            }

            lblScore.Text = pacman.Getscore().ToString();
            if (p == 0)
            {
                tmr1.Enabled = false; 
                tmr2.Enabled = false;
                if (mute != true)
                {
                    sndend.Play();
                }
                MessageBox.Show("סיימת את רמה " + level);
                level++;
                if (level == 4)
                {
                    lblLose.Text = "ניצחת!!!";
                    pBoxd.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                    if (mute != true)
                    {
                        sndfinal.Play();
                    }
                    UpdateScore(pacman.Getscore());
                }
                else
                {
                    NextMap();
                    tmr1.Enabled = true;
                    if ((tmr2.Interval * 5 / 6) == 0)
                    {
                        tmr2.Interval = 1;
                    }
                    else
                    {
                        tmr2.Interval = tmr2.Interval * 5 / 6;
                    }
                    tmr2.Enabled = true;
                }
            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            for (num = 0; num < 5; num++)
            {
                lposx[num] = ghost[num].Getx();
                lposy[num] = ghost[num].Gety();
                if (moving == true)
                {
                    Ghost_dir();
                    GhostMove();
                }
                if (blue == true && countblue != 2200)
                {                    
                    countblue++;
                }
                else if (blue == true && countblue == 2200)
                {
                    blue = false;
                    countblue = 0;
                    tmr1.Interval = tBar1.Value * 2;
                }
                if (ghost[num].Getx() == lposx[num] && ghost[num].Gety() == lposy[num])
                {
                    switch (ghost[num].GetLatestKey2())
                    {
                        case "Left":
                            ghost[num].SetLatestKey1("Right");
                            ghost[num].SetLatestKey2("Right");
                            break;
                        case "Right":
                            ghost[num].SetLatestKey1("Left");
                            ghost[num].SetLatestKey2("Left");
                            break;
                        case "Up":
                            ghost[num].SetLatestKey1("Down");
                            ghost[num].SetLatestKey2("Down");
                            break;
                        case "Down":
                            ghost[num].SetLatestKey1("Up");
                            ghost[num].SetLatestKey2("Up");
                            break;
                    }
                }
            } 
        }

        private void NextMap()
        {
            pacmanb = new Pacman();
            pacmanb.Setlives(pacman.Getlives());
            pacmanb.Setscore(pacman.Getscore());
            ClearMap();
            DrawMap();
            pacman.Setlives(pacmanb.Getlives());
            pacman.Setscore(pacmanb.Getscore());
        }

        private void DrawMap()
        {
            int c = 0;
            picGhost = new PictureBox[5];
            if (map == false)
            {
                ofd = new OpenFileDialog();
                ofd.Filter = "Uri Files Only|*.uri";
                ofd.ShowDialog();
            }
            ghost = new Ghost[5];
            for (int v = 0; v < 5; v++)
            {
                ghost[v] = new Ghost();
            }
            if (ofd.FileName.ToString() != "")
            {
                tr = new StreamReader(ofd.FileName.ToString());
                map = true;
                bStart = true;
                if (mute != true)
                {
                    sndstart.Play();
                }              

                for (j = 0; j < 23; j++)
                {
                    if (tr == null)
                    {
                        break;
                    }
                    st = tr.ReadLine().ToString();
                    for (i = 0; i < 23; i++)
                    {
                        lbl[i, j] = new Label();
                        this.lbl[i, j].Location = new System.Drawing.Point(210 + i * 30, 10 + j * 30);
                        this.lbl[i, j].Size = new System.Drawing.Size(30, 30);
                        switch (st.Substring(i, 1))
                        {
                            case "W":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Navy;
                                this.lbl[i, j].Tag = "4";
                                break;
                            case "D":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "1";
                                this.lbl[i, j].Image = global::Pacman_Game.Properties.Resources.Dot;
                                p++;
                                break;
                            case "S":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "2";
                                this.lbl[i, j].Image = global::Pacman_Game.Properties.Resources.SuperDot;
                                break;
                            case "C":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "3";
                                this.lbl[i, j].Image = global::Pacman_Game.Properties.Resources.Cherry;
                                break;
                            case "P":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "0";
                                pacman = new Pacman();
                                picPacman = new PictureBox();
                                picPacman.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                                picPacman.Size = new System.Drawing.Size(30, 30);
                                picPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                this.Controls.Add(picPacman);
                                pacman.SetStartPosition(this.lbl[i, j].Location.X, this.lbl[i, j].Location.Y);
                                picPacman.Top = pacman.Gety();
                                picPacman.Left = pacman.Getx();
                                picPacman.BringToFront();
                                break;
                            case "G":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "0";
                                picGhost[c] = new PictureBox();
                                switch (c)
                                {
                                    case 0:
                                        picGhost[c].Image = global::Pacman_Game.Properties.Resources.GreenGhostC;
                                        break;
                                    case 1:
                                        picGhost[c].Image = global::Pacman_Game.Properties.Resources.RedGhostC;
                                        break;
                                    case 2:
                                        picGhost[c].Image = global::Pacman_Game.Properties.Resources.PurpleGhostC;
                                        break;
                                    case 3:
                                        picGhost[c].Image = global::Pacman_Game.Properties.Resources.YellowGhostC;
                                        break;
                                    case 4:
                                        picGhost[c].Image = global::Pacman_Game.Properties.Resources.BlueGhostC;
                                        break;
                                }
                                picGhost[c].Size = new System.Drawing.Size(30, 30);
                                picGhost[c].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                                this.Controls.Add(picGhost[c]);
                                ghost[c].SetStartPosition(this.lbl[i, j].Location.X, this.lbl[i, j].Location.Y);
                                picGhost[c].Top = ghost[c].Gety();
                                picGhost[c].Left = ghost[c].Getx();
                                picGhost[c].BringToFront();
                                c++;
                                break;
                            default:
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "0";
                                break;
                        }
                        this.Controls.Add(lbl[i, j]);
                    }
                }

                lbl[0, 11].BackColor = Color.Navy;
                lbl[0, 11].Text = "<<<<<<";
                lbl[0, 11].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                lbl[0, 11].ForeColor = Color.White;
                lbl[0, 11].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lbl[0, 11].BringToFront();
                lbl[22, 11].BackColor = Color.Navy;
                lbl[22, 11].Text = ">>>>>>";
                lbl[22, 11].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                lbl[22, 11].ForeColor = Color.White;
                lbl[22, 11].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                lbl[22, 11].BringToFront();
            }
            else
            {
                bStart = false;
            }
        }

        private void ClearMap()
        {
            for (j = 0; j < 23; j++)
            {
                for (i = 0; i < 23; i++)
                {
                    this.Controls.Remove(lbl[i, j]);
                }
            }
            this.Controls.Remove(picPacman);
            for (int v = 0; v < 5; v++)
            {
                this.Controls.Remove(picGhost[v]);
            }
            pacman.Setprogrl(0);
            pacman.Setprogud(0);
            moving = true;
            blue = false;
        }

        private void UpdateScore(int pscore)
        {
            tmr1.Enabled = false;
            tmr2.Enabled = false;
            pnlHighScore.Visible = true;
            pnlHighScore.Size = new System.Drawing.Size(1004, 733);
            pnlHighScore.Location = new System.Drawing.Point(12, 1);
            pnlHighScore2.Location = new System.Drawing.Point(295, 200);
            pnlHighScore.BringToFront();
            lblScored.Text = "צברת " + lblScore.Text.ToString() + " נקודות";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {       
            DrawMap();
            if (bStart == true)
            {
                lblSScore.Visible = true;
                lblScore.Visible = true;
                lblMenu.Visible = true;
                lblLives.Visible = true;
                lblHelp.Visible = true;
                lblMute.Visible = true;
                lblPause.Visible = true;                
                pBoxl1.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                pBoxl2.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                pBoxl3.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
                this.Controls.Remove(btnStart);
                this.Controls.Remove(tBar1);
                this.Controls.Remove(lblSpeed);
                this.Controls.Remove(rtb1);
                tmr1.Interval = 2 * tBar1.Value;
                tmr1.Enabled = true;
                tmr2.Interval = 2 * tBar1.Value;
                tmr2.Enabled = true;
            }
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            if (tmr1.Enabled == true)
            {
                PauseGame();
            }
            DialogResult result;
            result = MessageBox.Show("???רוצה לחזור לתפריט", "", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes")
            {
                UpdateScore(pacman.Getscore());
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            if (tmr1.Enabled == true)
            {
                PauseGame();
            }
            new FormHelp().ShowDialog();
        }

        private void lblPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void PauseGame()
        {
            tmr1.Enabled = !tmr1.Enabled;
            tmr2.Enabled = !tmr2.Enabled;
            if (tmr1.Enabled == true)
            {
                lblPause.Text = "פוס משחק";
            }
            else
            {
                lblPause.Text = "המשך משחק";
            }
        }

        private void lblMute_Click(object sender, EventArgs e)
        {
            if (mute == false)
            {
                lblMute.Text = "נגן";
                mute = true;
            }
            else
            {
                lblMute.Text = "השתק";
                mute = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            tr1 = new StreamReader(sPath + "\\..\\..\\..\\" + "Database\\" + "Highscores.txt");
            s1 = tr1.ReadToEnd();
            tr1.Close();
            fi = new FileInfo(sPath + "\\..\\..\\..\\" + "Database\\" + "Highscores.txt");
            sw = fi.CreateText();
            pnlHighScore.Visible = false;
            s1 += txtName.Text.ToString() + "@" + pacman.Getscore().ToString();
            sw.WriteLine(s1);
            sw.Close();
            this.Hide();
        }

        private void pBoxd_MouseEnter(object sender, EventArgs e)
        {
            if (lblLose.Text == "ניצחת!!!")
            {
                sndfinal.Play();
            }
            else
            {
                snddeath.Play();
            }
        }
    }
}