﻿using System;
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
    public partial class frmDepartmentHead : Form
    {
        public frmDepartmentHead()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
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

        private void button4_Click(object sender, EventArgs e)
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

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance Attendance = new frmAttendance();
            Attendance.ShowDialog();
        }
    }
}
