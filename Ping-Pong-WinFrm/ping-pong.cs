using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Ping_Pong_WinFrm
{
    public partial class ping_pong : Form
    {
        //Move the form without border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMassage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //end


        Play frmPlay = new Play();
        int speed;
        int score;

        public ping_pong()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            frmPlay.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting frmSetting = new Setting();
            frmSetting.ShowDialog();
            frmSetting.SetInformation(ref speed, ref score);
            frmPlay.SetInformation(speed, score);
        }

        private void ping_pong_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMassage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
