using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Demo2008
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
            MyShow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2008].[dbo].[Student]
                               ([SNo]
                               ,[SName]
                               ,[sex]
                               ,[ClassNo]
                               ,[JoinYear])
                         VALUES(@SNo, @SName,@sex,@ClassNo,@JoinYear)";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text),
                                      new SqlParameter("@SName", txtSName.Text), 
                                      new SqlParameter("@sex", txtSex.Text), 
                                      new SqlParameter("@ClassNo", txtClassNo.Text), 
                                      new SqlParameter("@JoinYear", txtJoinYear.Text), };
            DBHelperSQL.TableChange(sql,para);
            MyShow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "delete Student where SNo=@SNo";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text) };
            DBHelperSQL.TableChange(sql,para);
            MyShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2008].[dbo].[Student]
                           SET [SName] = @SName
                              ,[sex] = @sex
                              ,[ClassNo] =@ClassNo
                              ,[JoinYear] =@JoinYear
                         WHERE SNo=@SNo";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text),
                                      new SqlParameter("@SName", txtSName.Text), 
                                      new SqlParameter("@sex", txtSex.Text), 
                                      new SqlParameter("@ClassNo", txtClassNo.Text), 
                                      new SqlParameter("@JoinYear", txtJoinYear.Text), };
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MyShow()
        {
            string sql = @"select [SNo] 学号
                               ,[SName] 学生姓名
                               ,[sex] 性别
                               ,[ClassNo] 班级ID
                               ,[JoinYear] 入学年份 From Student";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
