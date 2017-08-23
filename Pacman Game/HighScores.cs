using System;
using System.Collections.Generic;
using System.Text;

namespace Pacman_Game
{
    class HighScores
    {
        string name;
        int score;

        public HighScores(string name1, int score1)
        {
            name = name1;
            score = score1;
        }
        public HighScores()
        {
            name = "";
            score = 0;
        }
        public void Setname(string name1)
        {
            name = name1;
        }
        public void Setscore(int score1)
        {
            score = score1;
        }
        public string Getname()
        {
            return name;
        }
        public int Getscore()
        {
            return score;
        }
    }
}
