using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPanel.XPanelControllers
{
    public partial class XPanelPollingRate : UserControl
    {
        public XPanelPollingRate()
        {
            InitializeComponent();
        }

        private void XPanelPollingRate_Load(object sender, EventArgs e)
        {
            Four.Enabled = false;
        }

        private void One_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Polling Rate Set To 1000Hz");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Polling Rate Set To 2000Hz");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Polling Rate Set To 4000Hz");
        }

        private void Four_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Under Testing");
        }

        private void Four_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Under Testing");
        }
    }
}
