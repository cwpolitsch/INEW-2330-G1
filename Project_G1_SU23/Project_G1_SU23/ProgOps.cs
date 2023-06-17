using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_G1_SU23
{
    internal class ProgOps
    {
        private const string CONNECT_STRING = @"Server=3.130.26.194;Database= inew2330gsu23;user Id= team1su232330;password= P5ThnUcP9!;";
        //build a connection to our database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        private static SqlCommand _sqlLoginCommand;
        private static SqlDataAdapter _daLogin = new SqlDataAdapter();
        private static DataTable _dtLoginTables = new DataTable();
        private static StringBuilder errorMessages = new StringBuilder();


        public static DataTable LoginTable
        {
            get { return _dtLoginTables; }
        }


        const string strSchema = "team1su232330.";
        public static string username = "";
        public static string strEmail = "";
        public static string strStaff = "";
        public static string strStaffID = "";
        public static string strClearance = "";


        public static void OpenDatabase() // open and close database
        {
            _cntDatabase.Open();
        }
        public static void CloseDisposeDatabase()
        {
            _cntDatabase.Close();
            _cntDatabase.Dispose();
        }

        public static bool Login(string strUsername, string strPassword, string clearance)
        {
            bool Login = false;
            try
            {
                
                string strLoginCommand = "SELECT " + "UserName, " + "Password " +
                    "FROM " + strSchema + "Staff " +
                    "WHERE UserName = '" + strUsername + "' AND Password = '" + strPassword + "';";

                SqlCommand _loginCommand = new SqlCommand(strLoginCommand, _cntDatabase);
                SqlDataAdapter _loginAdapter = new SqlDataAdapter();
                DataTable _loginTable = new DataTable();


                _loginAdapter.SelectCommand = _loginCommand;
                _loginAdapter.Fill(_loginTable);

                if (_loginTable.Rows.Count > 0) // if the row is found fills in information from the table
                {
                    Login = true;
                    username = strUsername;

                    string strStaffInfo = "SELECT FirstName, LastName, ClearanceLevel, Email FROM " + strSchema + "Staff WHERE UserName = '" + username + "';";

                    SqlDataAdapter _daStaff = new SqlDataAdapter(strStaffInfo, _cntDatabase);
                    DataSet _dsStaff = new DataSet();
                    _daStaff.Fill(_dsStaff, strSchema + "Staff");
                    strStaff = _dsStaff.Tables[0].Rows[0]["FirstName"].ToString() + " " + _dsStaff.Tables[0].Rows[0]["LastName"].ToString();
                    strEmail = _dsStaff.Tables[0].Rows[0]["Email"].ToString();
                    strClearance = _dsStaff.Tables[0].Rows[0]["ClearanceLevel"].ToString();

                }
                else
                {
                    Login = false;
                    MessageBox.Show("Rows = 0", "Error", MessageBoxButtons.OK); // Debug
                }

                return Login;
            }
            catch (Exception ex) 
            {
                Login = false;
                MessageBox.Show("Incorrect Login Information", "Error", MessageBoxButtons.OK); // Debug clean up later
                return Login;
            }
            
        }
    }
}
