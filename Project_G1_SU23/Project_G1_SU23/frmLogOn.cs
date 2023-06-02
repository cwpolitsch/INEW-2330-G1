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
    public partial class frmLogOn : Form
    {
        public frmLogOn()
        {
            InitializeComponent();
        }

        private void frmLogOn_Load(object sender, EventArgs e)
        {
            try
            {
                ProgOps.OpenDatabase();
                MessageBox.Show("Database connection opened.", "Connection Established", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } catch (Exception ex)
            {
                MessageBox.Show("Database connection failed.", "Connection Not Established", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLogOn_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ProgOps.CloseDisposeDatabase();
                MessageBox.Show("Database connection closed.", "Connection Closed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
