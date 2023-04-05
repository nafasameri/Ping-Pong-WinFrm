using System;
using System.Windows.Forms;

namespace Ping_Pong_WinFrm
{
    public partial class Setting : Form
    {
        private int speed;
        private int score;
        public Setting()
        {
            InitializeComponent();
        }

        public void SetInformation(ref int speed,ref int score)
        {
            speed = this.speed;
            score = this.score;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { speed = int.Parse(txtSpeed.Text); } catch { }
            try { score = int.Parse(txtScore.Text); } catch { }
            MessageBox.Show("Successfully saved","",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
