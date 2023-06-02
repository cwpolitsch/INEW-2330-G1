using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_G1_SU23
{
    internal class ProgOps
    {
        private const string CONNECT_STRING = @"Server=3.130.26.194.;Database=  inew2330gsu23;User Id= team1su232330;password= P5ThnUcP9!";
        //build a connection to our database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        private static SqlCommand _sqlLoginCommand;



        public static void OpenDatabase()
        {
            _cntDatabase.Open();
        }
        public static void CloseDisposeDatabase()
        {
            _cntDatabase.Close();
            _cntDatabase.Dispose();
        }
    }
}
