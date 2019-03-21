using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2007
{
    public partial class FormDept : Form
    {
        public FormDept()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2007].[dbo].[Department]
                               ([DeptID]
                               ,[DeptName]
                               ,[EmpID])
                         VALUES
                               (@DeptID,@DeptName,@EmpID)";
            SqlParameter[] para = { new SqlParameter("@DeptID", txtDeptID.Text), 
                                      new SqlParameter("@DeptName", txtDeptName.Text), 
                                      new SqlParameter("@EmpID", txtEmpID.Text) };
            DBHelperSQL.TableChange(sql, para);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete Department where EmpID=@DeptID";
            SqlParameter[] para = { new SqlParameter("@DeptID", txtDeptID.Text) };
            DBHelperSQL.TableChange(sql, para);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2007].[dbo].[Department]
                           SET [DeptName] = @DeptName,[EmpID] = @EmpID
                         WHERE DeptID=@DeptID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@DeptName", txtDeptName.Text), 
                                      new SqlParameter("@DeptID", txtDeptID.Text) };
            DBHelperSQL.TableChange(sql, para);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
