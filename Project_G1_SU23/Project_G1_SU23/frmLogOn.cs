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

                }
                catch (Exception ex)
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

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string staffID = "";
            string loginID = tbxUserName.Text;
            string password = tbxPassword.Text;
            string secLevel = "";               ;
            
            bool login;

            login = ProgOps.Login(tbxUserName.Text, tbxPassword.Text, secLevel);
            secLevel = ProgOps.strClearance.ToLower();

            if (login)
            {
                MessageBox.Show("Welcome " + ProgOps.strStaff + " // " + ProgOps.strClearance + ".", "Welcome", MessageBoxButtons.OK);

                switch (secLevel)
                {
                    case "tch":
                    {
                            frmTeacher TeachForm = new frmTeacher();
                            this.Visible = false;
                            TeachForm.ShowDialog();
                            break;
                    }
                    case "adm":
                    {
                            frmAdmin AdmForm = new frmAdmin();
                            this.Visible = false;
                            AdmForm.ShowDialog();
                            break;
                    }
                    case "dph":
                    {
                            frmDepartmentHead DphForm = new frmDepartmentHead();
                            this.Visible = false;
                            DphForm.ShowDialog();
                            break;
                    }
                    default:
                            break;
                }


                
            }
            else
            {
                MessageBox.Show("Incorrect username or password, please try again. If you dont remember your password please click \"Reset Password?.\"", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
