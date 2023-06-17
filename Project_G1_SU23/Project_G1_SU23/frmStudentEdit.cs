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
    public partial class frmStudentEdit : Form
    {
        public frmStudentEdit()
        {
            InitializeComponent();
        }

        private void mnuItemReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
