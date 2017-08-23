using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pacman_Game
{
    public partial class FormHighScore : Form
    {
        HighScores[] hs;
        TextReader tr;
        string st, st2, st3, sPath;
        int j, n;

        public FormHighScore()
        {
            InitializeComponent();
            sPath = Application.StartupPath;
            Findtrlines();
            hs = new HighScores[n];
            for (int i = 0; i < n; i++)
            {
                hs[i] = new HighScores();
            }
            tr = new StreamReader(sPath + "\\..\\..\\..\\" + "Database\\" + "Highscores.txt");
            UpdateArray();
            UpdateHighscore();
            tr.Close();
        }

        public void Findtrlines()
        {
            int count = -1;
            st = "x";
            tr = new StreamReader(sPath + "\\..\\..\\..\\" + "Database\\" + "Highscores.txt");
            while (st != null)
            {
                st = tr.ReadLine();
                count++;
            }
            n = count;
        }

        public void UpdateArray()
        {
            for (int i = 0; i < hs.Length; i++)
            {
                st = tr.ReadLine();
                st2 = "";
                st3 = "";
                for (j = 0; j < st.IndexOf('@'); j++)
                {
                    st2 = st2 + st.Substring(j, 1);
                }
                hs[i].Setname(st2);
                
                for (j += 1; j < st.Length; j++)
                {
                    st3 = st3 + st.Substring(j, 1);
                }
                hs[i].Setscore(int.Parse(st3));
            }
        }

        public void UpdateHighscore()
        {
            int max = 0, arr_index = 0;
            HighScores[] hs2 = new HighScores[10];
            for (int i = 0; i < 10; i++)
            {
                hs2[i] = new HighScores();
            }

            for (int j = 0; j < 10; j++)
            {
                for (int i = 0; i < hs.Length; i++)
                {
                    if (hs[i].Getscore() > max)
                    {
                        max = hs[i].Getscore();
                        arr_index = i;
                    }
                }
                max = 0;
                hs2[j].Setname(hs[arr_index].Getname());
                hs2[j].Setscore(hs[arr_index].Getscore());
                hs[arr_index].Setname("XXXX");
                hs[arr_index].Setscore(0);
            }

            lblName1.Text = hs2[0].Getname();
            lblScore1.Text = hs2[0].Getscore().ToString();
            lblName2.Text = hs2[1].Getname();
            lblScore2.Text = hs2[1].Getscore().ToString();
            lblName3.Text = hs2[2].Getname();
            lblScore3.Text = hs2[2].Getscore().ToString();
            lblName4.Text = hs2[3].Getname();
            lblScore4.Text = hs2[3].Getscore().ToString();
            lblName5.Text = hs2[4].Getname();
            lblScore5.Text = hs2[4].Getscore().ToString();
            lblName6.Text = hs2[5].Getname();
            lblScore6.Text = hs2[5].Getscore().ToString();
            lblName7.Text = hs2[6].Getname();
            lblScore7.Text = hs2[6].Getscore().ToString();
            lblName8.Text = hs2[7].Getname();
            lblScore8.Text = hs2[7].Getscore().ToString();
            lblName9.Text = hs2[8].Getname();
            lblScore9.Text = hs2[8].Getscore().ToString();
            lblName10.Text = hs2[9].Getname();
            lblScore10.Text = hs2[9].Getscore().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}