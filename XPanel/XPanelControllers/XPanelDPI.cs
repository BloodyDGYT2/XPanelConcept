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
    public partial class XPanelDPI : UserControl
    {
        public XPanelDPI()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DPI Set To 400");
        }

        private void Two_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DPI Set To 800");
        }

        private void Three_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DPI Set To 1600");
        }

        private void XPanelDPI_Load(object sender, EventArgs e)
        {

        }

        private void Four_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DPI Set To 3200");
        }

        private void Five_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DPI Set To 6400");
        }
    }
}
