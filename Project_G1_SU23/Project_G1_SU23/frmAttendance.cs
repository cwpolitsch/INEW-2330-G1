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
    public partial class frmAttendance : Form
    {
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {

        }

        private void returnToMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrades grades = new frmGrades();
            grades.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
