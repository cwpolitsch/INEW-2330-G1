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
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void frmTeacher_Load(object sender, EventArgs e)
        {

        }

        private void mnuItemLogOff_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogOn logon = new frmLogOn();
            logon.ShowDialog();
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance attendance = new frmAttendance();
            attendance.ShowDialog();
        }

        private void mnuItemSeating_Click(object sender, EventArgs e)
        {
            frmAttendance attendance = new frmAttendance(); 
            attendance.ShowDialog();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            frmGrades grades = new frmGrades();
            grades.ShowDialog();
        }

        private void mnuItemEdit_Click(object sender, EventArgs e)
        {
            frmGrades grades = new frmGrades();
            grades.ShowDialog();
        }
    }
}
