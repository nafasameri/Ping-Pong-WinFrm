using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ping_Pong_WinFrm
{
    public partial class Play : Form
    {
        int speed = 1;
        int scores = 5, score1 = 0, score2 = 0;
        int Vx = 2, Vy = 1;
        int XBall, YBall;
        int XRocket1, YRocket1;
        int XRocket2, YRocket2;

        Stopwatch timer = new Stopwatch();

        public Play()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveBall();
            ///ball seen rocket
            if ((pnlBall.Left <= pnlPlayer1.Right && pnlBall.Left >= pnlPlayer1.Left) || (pnlBall.Right >= pnlPlayer2.Left  && pnlBall.Right <= pnlPlayer2.Right)) //x
                if ((pnlPlayer1.Top < pnlBall.Top && pnlPlayer1.Bottom > pnlBall.Bottom) || (pnlPlayer2.Top < pnlBall.Top && pnlPlayer2.Bottom > pnlBall.Bottom))//y
                    Vx = -Vx;
            Score();
            Win(new KeyEventArgs(Keys.Space));
        }

        private void Play_KeyDown(object sender, KeyEventArgs e)
        {
            MoveRocket1(e);
            MoveRocket2(e);
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = true;
                lblSTART.Visible = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                timer1.Enabled = false;
                lblSTART.Visible = true;
            }
            if (timer1.Enabled)
                timer1_Tick(null, null);
            Win(e);
        }

        public void MoveRocket1(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
                XRocket1--;
            if (e.KeyCode == Keys.D)
                XRocket1++;
            if (e.KeyCode == Keys.W)
                YRocket1 -= 5;
            if (e.KeyCode == Keys.S)
                YRocket1 += 5;

            if (this.ClientSize.Height - 5 < pnlPlayer1.Bottom)
                YRocket1 -= 5;
            if (pnlPlayer1.Top - 10 < 0)
                YRocket1 += 5;
            if (pnlPlayer1.Left - 5 < 0)
                XRocket1++;

            pnlPlayer1.Location = new Point(XRocket1, YRocket1);
        }

        public void MoveRocket2(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                XRocket2--;
            if (e.KeyCode == Keys.Right)
                XRocket2++;
            if (e.KeyCode == Keys.Up)
                YRocket2 -= 5;
            if (e.KeyCode == Keys.Down)
                YRocket2 += 5;

            if (this.ClientSize.Height - 5 < pnlPlayer2.Bottom)
                YRocket2 -= 5;
            if (pnlPlayer2.Top - 10 < 0)
                YRocket2 += 5;
            if (this.ClientSize.Width - 5 < pnlPlayer2.Right)
                XRocket2--; ;

            pnlPlayer2.Location = new Point(XRocket2, YRocket2);
        }

        public void MoveBall()
        {
            if (pnlBall.Top - 5 < 0 || pnlBall.Bottom > this.ClientSize.Height - 5)
                Vy = -Vy;
            XBall += speed * Vx;
            YBall += speed * Vy;
            Point point = new Point(XBall, YBall);
            pnlBall.Location = point;
        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Do you want exit this program?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            //if (result == DialogResult.Yes)
            //    this.Close();
            //else
            //    Play_Load(null, null);
            //OnClosed(e);
            //Application.Exit();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            XBall = pnlBall.Location.X;
            YBall = pnlBall.Location.Y;
            XRocket1 = pnlPlayer1.Location.X;
            YRocket1 = pnlPlayer1.Location.Y;
            XRocket2 = pnlPlayer2.Location.X;
            YRocket2 = pnlPlayer2.Location.Y;
        }

        public void Score()
        {
            if (pnlBall.Left < pnlPlayer1.Left)
            {
                score2++;
                lblScore2.Text = score2.ToString();
                XBall = pnlPlayer2.Left - pnlBall.Width;
                YBall = (pnlPlayer2.Top + pnlPlayer2.Bottom) / 2;
            }
            if (pnlBall.Right > pnlPlayer2.Right)
            {
                score1++;
                lblScore1.Text = score1.ToString();
                XBall = pnlPlayer1.Right;
                YBall = (pnlPlayer1.Top + pnlPlayer1.Bottom) / 2;
            }
        }

        public void SetInformation(int speed, int scores)
        {
            this.speed = speed;
            this.scores = scores;
        }

        public void Win(KeyEventArgs e)
        {
            if (score1 == scores)
            {
                lblSTART.Text = "Winner is RED";
                lblSTART.Location = new Point(210, 150);
                timer1.Enabled = false;
                lblSTART.Visible = true;
                if (e.KeyCode == Keys.Enter) this.Close();
            }
            if (score2 == scores)
            {
                lblSTART.Text = "Winner is BLUE";
                lblSTART.Location = new Point(210, 150);
                timer1.Enabled = false;
                lblSTART.Visible = true;
                if (e.KeyCode == Keys.Enter) this.Close();
            }
        }
    }
}