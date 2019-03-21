using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Demo2011
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "PJ" && txtPwdP.Text == "123")
            {
                FormMain fm = new FormMain();
                fm.Show();
            }
            else if (txtName.Text != null && txtPwdP.Text != null)
            {
                string sql = @"SELECT [EmpID]
                                  ,[DName]
                                  ,[Sex]
                                  ,[Age]
                                  ,[Tel]
                                  ,[Pwd]
                              FROM [test2011].[dbo].[Driver]
                               WHERE DName=@DName and Pwd=@Pwd";
                SqlParameter[] para = { new SqlParameter("@DName",txtName .Text), 
                                      new SqlParameter("@Pwd", txtPwdP.Text)};
                DataTable dt = DBHelperSQL.TableSelect(sql,para);
                if (dt != null)
                {
                    FormDriver fd = new FormDriver(txtName.Text, txtPwdP.Text);
                    fd.Show();
                }
                else
                {
                    MessageBox.Show("登录失败！\n请检查用户名和密码！");
                }
            }
            else
            {
                MessageBox.Show("登录失败！");

            }

        }

        private void btnregister_Click(object sender, EventArgs e)
        {

        }
    }
}
