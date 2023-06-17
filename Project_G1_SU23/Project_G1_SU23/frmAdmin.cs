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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void mnuItemLogOff_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.CloseDisposeDatabase();
                MessageBox.Show("Database connection closed.", "Connection Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
            this.Close();
            frmLogOn logon = new frmLogOn();
            logon.ShowDialog();
        }

        private void mnuitemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuitemGrades_Click(object sender, EventArgs e)
        {
            frmGrades grades = new frmGrades();
            grades.ShowDialog();
        }

        private void btnEditStudents_Click(object sender, EventArgs e)
        {
            frmStudentEdit studentEdit = new frmStudentEdit();
            studentEdit.ShowDialog();
        }

        private void btnEditTeachers_Click(object sender, EventArgs e)
        {
            frmEditTeacher editTeacher = new frmEditTeacher();
            editTeacher.ShowDialog();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            frmEditClasses editClasses = new frmEditClasses();
            editClasses.ShowDialog();
        }

        private void mnuItemsStudents_Click(object sender, EventArgs e)
        {
            frmStudentEdit studentEdit = new frmStudentEdit();
            studentEdit.ShowDialog();
        }

        private void mnuItemsTeachers_Click(object sender, EventArgs e)
        {
            frmEditTeacher editTeacher = new frmEditTeacher();
            editTeacher.ShowDialog();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditClasses editClasses = new frmEditClasses();
            editClasses.ShowDialog();   
        }
    }
}
