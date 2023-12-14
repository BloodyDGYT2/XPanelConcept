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
    public partial class XPanelMotionSync : UserControl
    {
        public XPanelMotionSync()
        {
            InitializeComponent();
        }

        private void TurnOnMotionSync_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Motion Sync Has Been Turned On");
        }

        private void TurnOffMotionSync_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Motion Sync Has Been Turned Off");
        }
    }
}
