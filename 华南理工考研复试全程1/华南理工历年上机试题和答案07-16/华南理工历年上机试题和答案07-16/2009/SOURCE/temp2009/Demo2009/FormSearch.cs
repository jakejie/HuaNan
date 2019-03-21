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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btbnS1_Click(object sender, EventArgs e)
        {
            string sql = @"select *
                            from Orders inner join OrderDetails on Orders.OrderID=OrderDetails.OrderID
                            where Orders.OrderID=@OrderID";
            SqlParameter[] para = { new SqlParameter("@OrderID",txtOrderID.Text) };
            dv.DataSource=DBHelperSQL.TableSelect(sql,para);

        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select *
                            from Orders
                            where OrderID in(select OrderID 
					                            from OrderDetails 
					                            where ProductID in(select ProductID 
										                            from Product 
										                            where SupplierName=@Name))";
            SqlParameter[] para = { new SqlParameter("@Name", txtSupplierName.Text) };
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
        }
    }
}
