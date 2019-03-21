using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2015
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
        }
        string sex;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2015].[dbo].[EMPLOYEE]
                               ([EmpNo]
                               ,[EmpName]
                               ,[EmpSex]
                               ,[EmpAge])
                         VALUES(@EmpNo,@EmpName,@EmpSex,@EmpAge)";
            SqlParameter[] para = { new SqlParameter("@EmpNo", txtEmpNo.Text), 
                                      new SqlParameter("@EmpName", txtEmpName.Text), 
                                      new SqlParameter("@EmpSex", sex), 
                                      new SqlParameter("@EmpAge", txtEmpAge.Text)};
            DBHelperSQL.TableChange(sql,para);
            //MyShow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2015].[dbo].[EMPLOYEE]
                            WHERE [EmpNo] = @EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo", txtEmpNo.Text)};
            DBHelperSQL.TableChange(sql, para);
           // MyShow();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT * FROM [test2015].[dbo].[EMPLOYEE]
                            WHERE [EmpNo] = @EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo", txtEmpNo.Text) };
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
            //MyShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2015].[dbo].[EMPLOYEE]
                               SET [EmpName] = @EmpName
                                  ,[EmpSex] = @EmpSex
                                  ,[EmpAge] = @EmpAge
                             WHERE [EmpNo] = @EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo", txtEmpNo.Text), 
                                      new SqlParameter("@EmpName", txtEmpName.Text), 
                                      new SqlParameter("@EmpSex", sex), 
                                      new SqlParameter("@EmpAge", txtEmpAge.Text) };
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void rdbtnM_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            sex=rb.Text;
        }

        private void rdbtnF_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            sex = rb.Text;
        }
        public void MyShow()
        {
            string sql = @"SELECT [EmpNo]
                              ,[EmpName]
                              ,[EmpSex]
                              ,[EmpAge]
                          FROM [test2015].[dbo].[EMPLOYEE]";
            dv.DataSource=DBHelperSQL.TableSelect(sql);
        }
            

    }
}
