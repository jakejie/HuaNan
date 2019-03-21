using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Demo2012
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                DBHelperSQL.conn = new System.Data.SqlClient.SqlConnection(DBHelperSQL.connStr);
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
