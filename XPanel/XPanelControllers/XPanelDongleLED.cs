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
    public partial class XPanelDongleLED : UserControl
    {
        public XPanelDongleLED()
        {
            InitializeComponent();
        }

        private void BatteryIndecator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dongle LED Set To Battery Indecator");
        }

        private void DongleStrengthButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dongle LED Set To Mouse Connection");
        }

        private void TurnOffLEDButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dongle LED Set To Off");
        }
    }
}
