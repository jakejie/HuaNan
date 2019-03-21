using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2016
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2016].[dbo].[Student]
                               ([SNo]
                               ,[SName]
                               ,[SDate]
                               ,[ClassNo])
                         VALUES(@SNo,@SName,@SDate,@ClassNo)";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text), 
                                      new SqlParameter("@SName", txtSName.Text), 
                                      new SqlParameter("@SDate", txtDate.Text), 
                                      new SqlParameter("@ClassNo", txtClassNo.Text)};
            DBHelperSQL.TableChange(sql,para);
            MyShow();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2016].[dbo].[Student]
                            WHERE [SNo] = @SNo";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            MyShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2016].[dbo].[Student]
                           SET [SName] = @SName
                              ,[SDate] =@SDate
                              ,[ClassNo] =@ClassNo
                         WHERE [SNo] = @SNo";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text), 
                                      new SqlParameter("@SName", txtSName.Text), 
                                      new SqlParameter("@SDate", txtDate.Text), 
                                      new SqlParameter("@ClassNo", txtClassNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }
        public void MyShow()
        {
            string sql = @"SELECT [SNo]
                              ,[SName]
                              ,[SDate]
                              ,[ClassNo]
                          FROM [test2016].[dbo].[Student]";
            dv.DataSource=DBHelperSQL.TableSelect(sql);
        }
    }
}
