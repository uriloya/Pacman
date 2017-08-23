namespace Pacman_Game
{
    partial class FormGame
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
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lblSScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblMute = new System.Windows.Forms.Label();
            this.pnlHighScore = new System.Windows.Forms.Panel();
            this.pnlHighScore2 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pBoxd = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblScored = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblPause = new System.Windows.Forms.Label();
            this.tBar1 = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.pBoxl3 = new System.Windows.Forms.PictureBox();
            this.pBoxl2 = new System.Windows.Forms.PictureBox();
            this.pBoxl1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.pnlHighScore.SuspendLayout();
            this.pnlHighScore2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxl1)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Interval = 1;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lblSScore
            // 
            this.lblSScore.BackColor = System.Drawing.Color.Black;
            this.lblSScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSScore.ForeColor = System.Drawing.Color.White;
            this.lblSScore.Location = new System.Drawing.Point(45, 176);
            this.lblSScore.Name = "lblSScore";
            this.lblSScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSScore.Size = new System.Drawing.Size(101, 41);
            this.lblSScore.TabIndex = 1;
            this.lblSScore.Text = "ניקוד:";
            this.lblSScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSScore.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.Black;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(45, 208);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(101, 41);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Visible = false;
            // 
            // lblMenu
            // 
            this.lblMenu.BackColor = System.Drawing.Color.Black;
            this.lblMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(45, 50);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(101, 91);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "חזור לתפריט הראשי";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu.Visible = false;
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click);
            // 
            // lblLives
            // 
            this.lblLives.BackColor = System.Drawing.Color.Black;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLives.ForeColor = System.Drawing.Color.White;
            this.lblLives.Location = new System.Drawing.Point(45, 268);
            this.lblLives.Name = "lblLives";
            this.lblLives.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLives.Size = new System.Drawing.Size(101, 41);
            this.lblLives.TabIndex = 1;
            this.lblLives.Text = "חיים:";
            this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLives.Visible = false;
            // 
            // lblHelp
            // 
            this.lblHelp.BackColor = System.Drawing.Color.Black;
            this.lblHelp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(45, 365);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(101, 71);
            this.lblHelp.TabIndex = 3;
            this.lblHelp.Text = "עזרה";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelp.Visible = false;
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblMute
            // 
            this.lblMute.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMute.ForeColor = System.Drawing.Color.White;
            this.lblMute.Location = new System.Drawing.Point(45, 560);
            this.lblMute.Name = "lblMute";
            this.lblMute.Size = new System.Drawing.Size(101, 47);
            this.lblMute.TabIndex = 4;
            this.lblMute.Text = "השתק";
            this.lblMute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMute.Visible = false;
            this.lblMute.Click += new System.EventHandler(this.lblMute_Click);
            // 
            // pnlHighScore
            // 
            this.pnlHighScore.BackColor = System.Drawing.Color.Black;
            this.pnlHighScore.Controls.Add(this.pnlHighScore2);
            this.pnlHighScore.ForeColor = System.Drawing.Color.White;
            this.pnlHighScore.Location = new System.Drawing.Point(160, 12);
            this.pnlHighScore.Name = "pnlHighScore";
            this.pnlHighScore.Size = new System.Drawing.Size(429, 262);
            this.pnlHighScore.TabIndex = 7;
            this.pnlHighScore.Visible = false;
            // 
            // pnlHighScore2
            // 
            this.pnlHighScore2.Controls.Add(this.txtName);
            this.pnlHighScore2.Controls.Add(this.pBoxd);
            this.pnlHighScore2.Controls.Add(this.lblName);
            this.pnlHighScore2.Controls.Add(this.btnSend);
            this.pnlHighScore2.Controls.Add(this.lblScored);
            this.pnlHighScore2.Controls.Add(this.lblLose);
            this.pnlHighScore2.Location = new System.Drawing.Point(3, 3);
            this.pnlHighScore2.Name = "pnlHighScore2";
            this.pnlHighScore2.Size = new System.Drawing.Size(423, 256);
            this.pnlHighScore2.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(182, 117);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 20);
            this.txtName.TabIndex = 4;
            // 
            // pBoxd
            // 
            this.pBoxd.Image = global::Pacman_Game.Properties.Resources.pacman_skull;
            this.pBoxd.Location = new System.Drawing.Point(28, 92);
            this.pBoxd.Name = "pBoxd";
            this.pBoxd.Size = new System.Drawing.Size(127, 141);
            this.pBoxd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxd.TabIndex = 8;
            this.pBoxd.TabStop = false;
            this.pBoxd.MouseEnter += new System.EventHandler(this.pBoxd_MouseEnter);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName.Location = new System.Drawing.Point(182, 68);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblName.Size = new System.Drawing.Size(207, 36);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "הכנס את שמך:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Black;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSend.ForeColor = System.Drawing.Color.Yellow;
            this.btnSend.Location = new System.Drawing.Point(235, 160);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 75);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "אישור";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblScored
            // 
            this.lblScored.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblScored.Location = new System.Drawing.Point(182, 27);
            this.lblScored.Name = "lblScored";
            this.lblScored.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblScored.Size = new System.Drawing.Size(207, 36);
            this.lblScored.TabIndex = 5;
            this.lblScored.Text = "צברת:";
            this.lblScored.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLose
            // 
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLose.Location = new System.Drawing.Point(18, 34);
            this.lblLose.Name = "lblLose";
            this.lblLose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLose.Size = new System.Drawing.Size(142, 36);
            this.lblLose.TabIndex = 6;
            this.lblLose.Text = "הפסדת...";
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPause
            // 
            this.lblPause.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(45, 469);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(101, 58);
            this.lblPause.TabIndex = 4;
            this.lblPause.Text = "פוס משחק";
            this.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPause.Visible = false;
            this.lblPause.Click += new System.EventHandler(this.lblPause_Click);
            // 
            // tBar1
            // 
            this.tBar1.Location = new System.Drawing.Point(369, 131);
            this.tBar1.Minimum = 1;
            this.tBar1.Name = "tBar1";
            this.tBar1.Size = new System.Drawing.Size(298, 45);
            this.tBar1.TabIndex = 8;
            this.tBar1.Value = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSpeed.ForeColor = System.Drawing.Color.White;
            this.lblSpeed.Location = new System.Drawing.Point(408, 78);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(226, 43);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = ":בחר מהירות משחק";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr2
            // 
            this.tmr2.Interval = 1;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // pBoxl3
            // 
            this.pBoxl3.Location = new System.Drawing.Point(117, 312);
            this.pBoxl3.Name = "pBoxl3";
            this.pBoxl3.Size = new System.Drawing.Size(30, 30);
            this.pBoxl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxl3.TabIndex = 2;
            this.pBoxl3.TabStop = false;
            // 
            // pBoxl2
            // 
            this.pBoxl2.Location = new System.Drawing.Point(81, 312);
            this.pBoxl2.Name = "pBoxl2";
            this.pBoxl2.Size = new System.Drawing.Size(30, 30);
            this.pBoxl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxl2.TabIndex = 2;
            this.pBoxl2.TabStop = false;
            // 
            // pBoxl1
            // 
            this.pBoxl1.Location = new System.Drawing.Point(45, 312);
            this.pBoxl1.Name = "pBoxl1";
            this.pBoxl1.Size = new System.Drawing.Size(30, 30);
            this.pBoxl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxl1.TabIndex = 2;
            this.pBoxl1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStart.ForeColor = System.Drawing.Color.Yellow;
            this.btnStart.Image = global::Pacman_Game.Properties.Resources.PacmanRight;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(345, 199);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(344, 296);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "בחר רמה והתחל       ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtb1
            // 
            this.rtb1.BackColor = System.Drawing.Color.Black;
            this.rtb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtb1.ForeColor = System.Drawing.Color.White;
            this.rtb1.Location = new System.Drawing.Point(398, 541);
            this.rtb1.Name = "rtb1";
            this.rtb1.ReadOnly = true;
            this.rtb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtb1.Size = new System.Drawing.Size(236, 106);
            this.rtb1.TabIndex = 10;
            this.rtb1.Text = "כאשר קופץ חלון עליכם לבחור את מיקום הרמה הרצויה, מיקום הרמות הוא ב-              " +
                "          Pacman Game/Maps/*****";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1028, 746);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.tBar1);
            this.Controls.Add(this.lblPause);
            this.Controls.Add(this.lblMute);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.pBoxl3);
            this.Controls.Add(this.pBoxl2);
            this.Controls.Add(this.pBoxl1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblSScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlHighScore);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormGame";
            this.Text = "משחק פקמן";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.pnlHighScore.ResumeLayout(false);
            this.pnlHighScore2.ResumeLayout(false);
            this.pnlHighScore2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.PictureBox pBoxl1;
        private System.Windows.Forms.PictureBox pBoxl2;
        private System.Windows.Forms.PictureBox pBoxl3;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblMute;
        private System.Windows.Forms.Panel pnlHighScore;
        private System.Windows.Forms.PictureBox pBoxd;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Label lblScored;
        private System.Windows.Forms.Panel pnlHighScore2;
        private System.Windows.Forms.TrackBar tBar1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.RichTextBox rtb1;
    }
}

