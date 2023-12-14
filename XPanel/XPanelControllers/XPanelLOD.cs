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
    public partial class XPanelLOD : UserControl
    {
        public XPanelLOD()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOD Set To 1mm");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LOD Set To 2mm");
        }
    }
}
