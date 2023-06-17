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
    public partial class frmAttendance10 : Form
    {
        public frmAttendance10()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrades grades= new frmGrades();
            grades.ShowDialog();
        }

        private void returnToMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
