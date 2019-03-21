using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2013
{
    public partial class FormTeacher : Form
    {
        string sex;
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2013].[dbo].[TEACHERS]
                                   ([TNo]
                                   ,[TNmae]
                                   ,[TSex])
                             VALUES(@TNo,@TNmae,@TSex)";
            SqlParameter[] para = { new SqlParameter("@TNo", txtTNo.Text), 
                                      new SqlParameter("@TNmae", txtTName.Text), 
                                      new SqlParameter("@TSex",sex )};
            DBHelperSQL.TableChange(sql,para);
            MyShow();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2013].[dbo].[TEACHERS]
                            WHERE [TNo] =@TNo";
            SqlParameter[] para = { new SqlParameter("@TNo", txtTNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT [TNo]
                              ,[TNmae]
                              ,[TSex]
                          FROM [test2013].[dbo].[TEACHERS]
                           WHERE [TNo] =@TNo or [TNmae] =@TNmae or [TSex] = @TSex";
            SqlParameter[] para = { new SqlParameter("@TNo", txtTNo.Text), 
                                      new SqlParameter("@TNmae", txtTName.Text), 
                                      new SqlParameter("@TSex",sex )};
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2013].[dbo].[TEACHERS]
                               SET [TNmae] =@TNmae
                                  ,[TSex] = @TSex
                             WHERE [TNo] =@TNo";
            SqlParameter[] para = { new SqlParameter("@TNo", txtTNo.Text), 
                                      new SqlParameter("@TNmae", txtTName.Text), 
                                      new SqlParameter("@TSex",sex )};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }
        public void MyShow()
        {
            string sql = @"SELECT [TNo]
                              ,[TNmae]
                              ,[TSex]
                          FROM [test2013].[dbo].[TEACHERS]";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
        private void rdbtnM_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            switch (((RadioButton)sender).Text.ToString())
            {
                case "男":
                    sex = "男";
                    break;
                case "女":
                    sex = "女";
                    break;
                default:
                    break;
            }

        }

        private void rdbtnF_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            switch (((RadioButton)sender).Text.ToString())
            {
                case "男":
                    sex = "男";
                    break;
                case "女":
                    sex = "女";
                    break;
                default:
                    break;
            }
        }
    }
}
