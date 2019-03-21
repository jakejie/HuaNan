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
    public partial class FormDriver : Form
    {
        string name;
        string pwd;


        public FormDriver(string name,string pwd)
        {
            this.name = name;
            this.pwd = pwd;
            InitializeComponent();
        }

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2011].[dbo].[Driver]
                           SET [DName] = @DName,
                              [Sex] =@Sex,
                              [Age] = @Age,
                              [Tel] = @Tel, 
                              [Pwd] = @Pwd
                         WHERE [EmpID] =@EmpID";
            SqlParameter[] para = { new SqlParameter("@EmpID", txtEmpID.Text), 
                                      new SqlParameter("@DName", txtDName.Text),
                                      new SqlParameter("@Sex", txtSex.Text),
                                      new SqlParameter("@Age", txtAge.Text),
                                      new SqlParameter("@Tel", txtTel.Text),
                                      new SqlParameter("@Pwd", txtPwd.Text)};
            DBHelperSQL.TableChange(sql, para);
         
        }

        private void FormDriver_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT [EmpID]
                                  ,[DName]
                                  ,[Sex]
                                  ,[Age]
                                  ,[Tel]
                                  ,[Pwd]
                              FROM [test2011].[dbo].[Driver]
                               WHERE DName=@DName and Pwd=@Pwd";
            SqlParameter[] para = { new SqlParameter("@DName",name), 
                                      new SqlParameter("@Pwd", pwd)};
            DataTable dt = DBHelperSQL.TableSelect(sql, para);
            DataRow dr = dt.Rows[0];
            txtEmpID.Text = dr["EmpID"].ToString();
            txtDName.Text = dr["DName"].ToString();
            txtSex.Text = dr["Sex"].ToString();
            txtAge.Text = dr["Age"].ToString();
            txtTel.Text = dr["Tel"].ToString();
            txtPwd.Text = dr["Pwd"].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
