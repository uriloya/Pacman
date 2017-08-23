using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pacman_Game
{
    public partial class FormSplash : Form
    {
        int a, b, c;
        Random rnd;
        public FormSplash()
        {
            InitializeComponent();
            rnd = new Random();
            timer1.Enabled = true;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a = rnd.Next(0, 256);
            b = rnd.Next(0, 256);
            c = rnd.Next(0, 256);
            lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(a)))), ((int)(((byte)(b)))), ((int)(((byte)(c)))));
        }
    }
}