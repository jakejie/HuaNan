using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2012
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [emp].[dbo].[Employee]
                                   ([EmpID]
                                   ,[EmpName]
                                   ,[EPlace])
                             VALUES(@EmpID,@EmpName,@EPlace)";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@EmpName", txtEmpName.Text), 
                                      new SqlParameter("@EPlace", txtEPlace.Text)};
            DBHelperSQL.TableChange(sql,para);
            MyShow();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [emp].[dbo].[Employee]
                              WHERE [EmpID] = @EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [emp].[dbo].[Employee]
                           SET [EmpName] = @EmpName
                              ,[EPlace] = @EPlace
                         WHERE [EmpID] = @EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@EmpName", txtEmpName.Text), 
                                      new SqlParameter("@EPlace", txtEPlace.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MyShow()
        {
            string sql = @"SELECT [EmpID]
                              ,[EmpName]
                              ,[EPlace]
                          FROM [emp].[dbo].[Employee]";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
