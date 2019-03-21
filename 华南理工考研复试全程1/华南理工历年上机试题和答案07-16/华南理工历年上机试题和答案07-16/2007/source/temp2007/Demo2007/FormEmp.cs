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
    public partial class FormEmp : Form
    {
        public FormEmp()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2007].[dbo].[Employee]
                                   ([EmpID]
                                   ,[EmpName]
                                   ,[Salary]
                                   ,[DeptID])
                             VALUES(@EmpID,@EmpName,@Salary,@DeptID)";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@EmpName", txtEmpName.Text), 
                                      new SqlParameter("@Salary", txtSalary.Text), 
                                      new SqlParameter("@DeptID", txtDept.Text) };
            DBHelperSQL.TableChange(sql,para);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete Employee where EmpID=@EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text)};
            DBHelperSQL.TableChange(sql, para);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2007].[dbo].[Employee]
                           SET [EmpName] = @EmpName
                              ,[DeptID] = @DeptID
                         WHERE EmpID=@EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@EmpName", txtEmpName.Text), 
                                      new SqlParameter("@DeptID", txtDept.Text) };
            DBHelperSQL.TableChange(sql, para);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
