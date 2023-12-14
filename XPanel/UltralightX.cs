using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPanel
{
    public partial class UltralightX : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public UltralightX()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void UltralightX_Load(object sender, EventArgs e)
        {
            xPanelOverview1.Show();
            xPaneldpi1.Hide();
            xPanellod1.Hide();
            xPanelMotionSync1.Hide();
            xPanelPollingRate1.Hide();
        }

        private void OverviewButton_Click(object sender, EventArgs e)
        {
            xPanelOverview1.Show();
            xPaneldpi1.Hide();
            xPanellod1.Hide();
            xPanelMotionSync1.Hide();
            xPanelPollingRate1.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            xPanelOverview1.Hide();
            xPaneldpi1.Hide();
            xPanellod1.Hide();
            xPanelMotionSync1.Hide();
            xPanelPollingRate1.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            xPanelOverview1.Hide();
            xPaneldpi1.Show();
            xPanellod1.Hide();
            xPanelMotionSync1.Hide();
            xPanelPollingRate1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            xPanelOverview1.Hide();
            xPaneldpi1.Hide();
            xPanellod1.Show();
            xPanelMotionSync1.Hide();
            xPanelPollingRate1.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            xPanelOverview1.Hide();
            xPaneldpi1.Hide();
            xPanellod1.Hide();
            xPanelMotionSync1.Show();
            xPanelPollingRate1.Hide();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Firmware firmware = new Firmware();
            firmware.Show();
            this.Hide();
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
