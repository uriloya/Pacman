using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacman_Game
{
    class Ghost
    {
        int x, y, progrl, progud;
        string LatestKey1, LatestKey2;

        public Ghost()
        {
            x = 0;
            y = 0;
            progrl = 0;
            progud = 0;
            LatestKey1 = "";
            LatestKey2 = "Up";
        }

        public void Setx(int x1)
        {
            x += x1;
        }

        public void Sety(int y1)
        {
            y += y1;
        }

        public void Setprogrl(int progrl1)
        {
            progrl = progrl1;
        }

        public void Setprogud(int progud1)
        {
            progud = progud1;
        }

        public void SetLatestKey1(string LatestKey11)
        {
            LatestKey1 = LatestKey11;
        }

        public void SetLatestKey2(string LatestKey21)
        {
            LatestKey2 = LatestKey21;
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

        public int Getprogrl()
        {
            return progrl;
        }

        public int Getprogud()
        {
            return progud;
        }

        public string GetLatestKey1()
        {
            return LatestKey1;
        }

        public string GetLatestKey2()
        {
            return LatestKey2;
        }
    }   
}
