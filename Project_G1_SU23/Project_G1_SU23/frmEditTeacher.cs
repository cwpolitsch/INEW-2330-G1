using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_G1_SU23
{
    public partial class frmEditTeacher : Form
    {
        public frmEditTeacher()
        {
            InitializeComponent();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuitemReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuitemLogOff_Click(object sender, EventArgs e)
        {

        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
