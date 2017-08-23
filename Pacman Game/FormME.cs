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
    public partial class FormME : Form
    {
        int i, j;
        Label[,] lbl;
        TextReader tr;
        TextWriter tw;
        string st, tool;
        OpenFileDialog ofd;
        SaveFileDialog sfd;

        public FormME()
        {
            InitializeComponent();
            lbl = new Label[23, 23];
            Clear();
            tool = "wall";
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            ofd = new OpenFileDialog();
            ofd.Filter = "Uri Files Only|*.uri";
            ofd.ShowDialog();
            if (ofd.FileName.ToString() != "")
            {
                for (j = 0; j < 23; j++)
                {
                    for (i = 0; i < 23; i++)
                    {
                        this.Controls.Remove(lbl[i, j]);
                    }
                }
                tr = new StreamReader(ofd.FileName.ToString());
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
                            case "G":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "5";
                                break;
                            case "P":
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "6";
                                break;
                            default:
                                this.lbl[i, j].BackColor = System.Drawing.Color.Black;
                                this.lbl[i, j].Tag = "0";
                                break;
                        }
                        this.lbl[i, j].Click += new System.EventHandler(this.lbl_Click);
                        this.lbl[i, j].Location = new System.Drawing.Point(310 + i * 30, 10 + j * 30);
                        this.lbl[i, j].Size = new System.Drawing.Size(30, 30);
                        this.Controls.Add(lbl[i, j]);
                    }
                }
                tr.Close();
                this.lbl[0, 11].BackColor = Color.Navy;
                this.lbl[0, 11].Text = "<<<<<<";
                this.lbl[0, 11].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                this.lbl[0, 11].ForeColor = Color.White;
                this.lbl[0, 11].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.lbl[0, 11].Enabled = true;
                this.lbl[0, 11].Click -= new System.EventHandler(this.lbl_Click);
                this.lbl[0, 11].BringToFront();
                this.lbl[22, 11].BackColor = Color.Navy;
                this.lbl[22, 11].Text = ">>>>>>";
                this.lbl[22, 11].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
                this.lbl[22, 11].ForeColor = Color.White;
                this.lbl[22, 11].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.lbl[22, 11].Enabled = true;
                this.lbl[22, 11].Click -= new System.EventHandler(this.lbl_Click);
                this.lbl[22, 11].BringToFront();
            }
            for (j = 0; j < 23; j++)
            {
                i = 0;
                this.lbl[i, j].Enabled = false;
            }
            for (i = 0; i < 23; i++)
            {
                j = 0;
                this.lbl[i, j].Enabled = false;
            }
            for (j = 0; j < 23; j++)
            {
                i = 22;
                this.lbl[i, j].Enabled = false;
            }
            for (i = 0; i < 23; i++)
            {
                j = 22;
                this.lbl[i, j].Enabled = false;
            }
            this.lbl[0, 11].Enabled = true;
            this.lbl[22, 11].Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sfd = new SaveFileDialog();
            sfd.Filter = "Uri Files Only|*.uri";
            sfd.ShowDialog();
            if (sfd.FileName.ToString() != "")
            {
                tw = new StreamWriter(sfd.FileName.ToString());
                for (j = 0; j < 23; j++)
                {
                    for (i = 0; i < 23; i++)
                    {
                        switch (lbl[i, j].Tag.ToString())
                        {
                            case "4":
                                tw.Write("W");
                                break;
                            case "1":
                                tw.Write("D");
                                break;
                            case "2":
                                tw.Write("S");
                                break;
                            case "3":
                                tw.Write("C");
                                break;
                            case "5":
                                tw.Write("G");
                                break;
                            case "6":
                                tw.Write("P");
                                break;
                            default:
                                tw.Write("N");
                                break;
                        }
                    }
                    tw.WriteLine();
                }
                tw.Flush();
                tw.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("???אתה בטוח שאתה רוצה למחוק את הרמה", "", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes")
            {
                for (j = 0; j < 23; j++)
                {
                    for (i = 0; i < 23; i++)
                    {
                        this.Controls.Remove(lbl[i, j]);
                    }
                }
                Clear();
            }           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("???רוצה לחזור לתפריט", "", MessageBoxButtons.YesNo);
            if (result.ToString() == "Yes")
            {
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new FormHelp().ShowDialog();
        }

        private void Clear()
        {
            for (j = 0; j < 23; j++)
            {
                for (i = 0; i < 23; i++)
                {
                    lbl[i, j] = new Label();
                    this.lbl[i, j].BackColor = System.Drawing.Color.Navy;
                    this.lbl[i, j].Click += new System.EventHandler(this.lbl_Click);
                    this.lbl[i, j].Location = new System.Drawing.Point(310 + i * 30, 10 + j * 30);
                    this.lbl[i, j].Size = new System.Drawing.Size(30, 30);
                    this.lbl[i, j].Tag = "4";
                    this.Controls.Add(lbl[i, j]);
                }
            }

            for (j = 0; j < 23; j++)
            {
                i = 0;
                this.lbl[i, j].Enabled = false;
            }
            for (i = 0; i < 23; i++)
            {
                j = 0;
                this.lbl[i, j].Enabled = false;
            }
            for (j = 0; j < 23; j++)
            {
                i = 22;
                this.lbl[i, j].Enabled = false;
            }
            for (i = 0; i < 23; i++)
            {
                j = 22;
                this.lbl[i, j].Enabled = false;
            }
            this.lbl[10, 11].BackColor = System.Drawing.Color.Black;
            this.lbl[10, 11].Tag = "5";
            this.lbl[11, 10].BackColor = System.Drawing.Color.Black;
            this.lbl[11, 10].Tag = "5";
            this.lbl[12, 11].BackColor = System.Drawing.Color.Black;
            this.lbl[12, 11].Tag = "5";
            this.lbl[11, 11].BackColor = System.Drawing.Color.Black;
            this.lbl[11, 11].Tag = "5";
            this.lbl[11, 12].BackColor = System.Drawing.Color.Black;
            this.lbl[11, 12].Tag = "5";
            this.lbl[11, 17].BackColor = System.Drawing.Color.Black;
            this.lbl[11, 17].Tag = "6";

            this.lbl[0, 11].BackColor = Color.Navy;
            this.lbl[0, 11].Text = "<<<<<<";
            this.lbl[0, 11].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl[0, 11].ForeColor = Color.White;
            this.lbl[0, 11].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl[0, 11].Enabled = true;
            this.lbl[0, 11].Click -= new System.EventHandler(this.lbl_Click);
            this.lbl[0, 11].BringToFront();
            this.lbl[22, 11].BackColor = Color.Navy;
            this.lbl[22, 11].Text = ">>>>>>";
            this.lbl[22, 11].Font = new System.Drawing.Font("Microsoft Sans Serif", 8.20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl[22, 11].ForeColor = Color.White;
            this.lbl[22, 11].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl[22, 11].Enabled = true;
            this.lbl[22, 11].Click -= new System.EventHandler(this.lbl_Click);
            this.lbl[22, 11].BringToFront();
        }

        private void lbl_Click(object sender, EventArgs e)
        {
            Label lbltmp = (Label)sender;
            if (tool == "dot")
            {
                lbltmp.BackColor = System.Drawing.Color.Black;
                lbltmp.Image = global::Pacman_Game.Properties.Resources.Dot;
                lbltmp.Tag = "1";
            }
            else if (tool == "wall" && lbltmp.BackColor == System.Drawing.Color.Navy)
            {
                lbltmp.BackColor = System.Drawing.Color.Black;
                lbltmp.Image = null;
                lbltmp.Tag = "0";
            }
            else if (tool == "wall" && lbltmp.BackColor == System.Drawing.Color.Black)
            {
                lbltmp.BackColor = System.Drawing.Color.Navy;
                lbltmp.Tag = "4";
                lbltmp.Image = null;
            }            
            else if (tool == "superdot")
            {
                lbltmp.BackColor = System.Drawing.Color.Black;
                lbltmp.Image = global::Pacman_Game.Properties.Resources.SuperDot;
                lbltmp.Tag = "2";
            }
            else if (tool == "cherry")
            {
                lbltmp.BackColor = System.Drawing.Color.Black;
                lbltmp.Image = global::Pacman_Game.Properties.Resources.Cherry;
                lbltmp.Tag = "3";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.Red;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
            label8.BackColor = Color.White;
            tool = "dot";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
            label6.BackColor = Color.Red;
            label7.BackColor = Color.White;
            label8.BackColor = Color.White;
            tool = "wall";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.Red;
            label8.BackColor = Color.White;
            tool = "superdot";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label5.BackColor = Color.White;
            label6.BackColor = Color.White;
            label7.BackColor = Color.White;
            label8.BackColor = Color.Red;
            tool = "cherry";
        }
    }
}

       


        