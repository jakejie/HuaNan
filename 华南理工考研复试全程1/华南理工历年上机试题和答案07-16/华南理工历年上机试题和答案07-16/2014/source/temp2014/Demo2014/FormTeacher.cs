using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2014
{
    public partial class FormTeacher : Form
    {
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            cboDept.SelectedIndex = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2014].[dbo].[TEACHERS]
                               ([TNo]
                               ,[TName]
                               ,[Dept]
                               ,[ReNo])
                         VALUES(@TNo,@TName,@Dept,@ReNo)";
            SqlParameter[] para = { new SqlParameter("@TNo", txtTNo.Text), 
                                      new SqlParameter("@TName", txtTName.Text), 
                                      new SqlParameter("@Dept", cboDept.SelectedItem.ToString()), 
                                      new SqlParameter("@ReNo",txtReNo.Text)};
            DBHelperSQL.TableChange(sql,para);
            MyShow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2014].[dbo].[TEACHERS]
                              WHERE [TNo] = @TNo";
            SqlParameter[] para = { new SqlParameter("@TNo", txtTNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2014].[dbo].[TEACHERS]
                           SET [TName] = @TName
                              ,[Dept] = @Dept
                              ,[ReNo] = @ReNo
                         WHERE [TNo] = @TNo";
            SqlParameter[] para = { new SqlParameter("@TNo", txtTNo.Text), 
                                      new SqlParameter("@TName", txtTName.Text), 
                                      new SqlParameter("@Dept", cboDept.SelectedItem.ToString()), 
                                      new SqlParameter("@ReNo",txtReNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MyShow()
        {
            string sql = @"SELECT [TNo]
                              ,[TName]
                              ,[Dept]
                              ,[ReNo]
                          FROM [test2014].[dbo].[TEACHERS]";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
