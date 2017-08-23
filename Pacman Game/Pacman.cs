using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacman_Game
{
    class Pacman
    {
        int x, y, progrl, progud, score, lives;

        public Pacman()
        {
            x = 0;
            y = 0;
            score = 0;
            lives = 3;
            progrl = 0;
            progud = 0;
        }

        public void Setx(int x1)
        {
            x += x1;
        }

        public void Sety(int y1)
        {
            y += y1;
        }

        public void Setscore(int s1)
        {
            score += s1;
        }

        public void Setlives()
        {
            lives += -1;
        }

        public void Setlives(int lvs)
        {
            lives = lvs;
        }

        public void Setprogrl(int progrl1)
        {
            progrl = progrl1;
        }

        public void Setprogud(int progud1)
        {
            progud = progud1;
        }

        public void SetStartPosition(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public int Getx()
        {
            return x;
        }

        public int Gety()
        {
            return y;
        }

        public int Getscore()
        {
            return score;
        }

        public int Getlives()
        {
            return lives;
        }

        public int Getprogrl()
        {
            return progrl;
        }

        public int Getprogud()
        {
            return progud;
        }
    }
}
