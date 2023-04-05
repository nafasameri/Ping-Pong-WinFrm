namespace Ping_Pong_WinFrm
{
    partial class Play
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
            this.pnlBall = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore1 = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.lblSTART = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlBall
            // 
            this.pnlBall.BackColor = System.Drawing.Color.Transparent;
            this.pnlBall.BackgroundImage = global::Ping_Pong_WinFrm.Properties.Resources.ball;
            this.pnlBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBall.Location = new System.Drawing.Point(392, 197);
            this.pnlBall.Name = "pnlBall";
            this.pnlBall.Size = new System.Drawing.Size(18, 18);
            this.pnlBall.TabIndex = 3;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer2.Location = new System.Drawing.Point(768, 166);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(20, 80);
            this.pnlPlayer2.TabIndex = 5;
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.Color.Red;
            this.pnlPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer1.Location = new System.Drawing.Point(12, 166);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(20, 80);
            this.pnlPlayer1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.BackColor = System.Drawing.Color.Transparent;
            this.lblScore1.Location = new System.Drawing.Point(370, 20);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(16, 17);
            this.lblScore1.TabIndex = 6;
            this.lblScore1.Text = "0";
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblScore2.Location = new System.Drawing.Point(414, 20);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(16, 17);
            this.lblScore2.TabIndex = 7;
            this.lblScore2.Text = "0";
            // 
            // lblSTART
            // 
            this.lblSTART.AutoSize = true;
            this.lblSTART.BackColor = System.Drawing.Color.Transparent;
            this.lblSTART.Font = new System.Drawing.Font("Bernard MT Condensed", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTART.ForeColor = System.Drawing.Color.Tan;
            this.lblSTART.Location = new System.Drawing.Point(346, 184);
            this.lblSTART.Name = "lblSTART";
            this.lblSTART.Size = new System.Drawing.Size(101, 40);
            this.lblSTART.TabIndex = 8;
            this.lblSTART.Text = "START";
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ping_Pong_WinFrm.Properties.Resources.table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.lblSTART);
            this.Controls.Add(this.pnlBall);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.pnlPlayer2);
            this.Controls.Add(this.pnlPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Play";
            this.Text = "Play";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Play_FormClosing);
            this.Load += new System.EventHandler(this.Play_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlBall;
        public System.Windows.Forms.Panel pnlPlayer2;
        public System.Windows.Forms.Panel pnlPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Label lblSTART;
    }
}