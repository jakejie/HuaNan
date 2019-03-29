using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                DBHelperSQL.conn = new SqlConnection(DBHelperSQL.connStr);
                DBHelperSQL.conn.Open();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.Run(new FormMain());
            DBHelperSQL.conn.Close();
           
        }
    }
}
