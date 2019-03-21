using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2009
{
    public partial class FormManage : Form
    {
        public FormManage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2009].[dbo].[Product]
                           ([ProductID]
                           ,[ProductName]
                           ,[SupplierName])
                     VALUES(@ProductID,@ProductName,@SupplierName)";
            SqlParameter[] para = { new SqlParameter("@ProductID", txtPID.Text), 
                                      new SqlParameter("@ProductName", txtPName.Text), 
                                      new SqlParameter("@SupplierName", txtSName.Text) };
            DBHelperSQL.TableChange(sql,para);
            MyShow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"delete Product where ProductID=@ProductID";
            SqlParameter[] para = { new SqlParameter("@ProductID", txtPID.Text) };
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2009].[dbo].[Product]
                           SET [ProductName] = @ProductName,[SupplierName] =@SupplierName
                         WHERE [ProductID] = @ProductID";
            SqlParameter[] para = { new SqlParameter("@ProductID", txtPID.Text), 
                                      new SqlParameter("@ProductName", txtPName.Text), 
                                      new SqlParameter("@SupplierName", txtSName.Text) };
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MyShow()
        {
            string sql = @"select * from Product";
            dv.DataSource=DBHelperSQL.TableSelect(sql);
        
        }
    }
}
