using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2009
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            string sql = @"select OrderID ,SUM(UnitPrice*Quantity) 销售总金额
                            from OrderDetails
                            group by OrderID";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select a.ProductID ,SUM(a.UnitPrice*a.Quantity)/SUM(a.Quantity) 平均销售单价,SUM(a.Quantity)总销售数量,
                            (select top 1 UnitPrice from OrderDetails where ProductID=a.ProductID order by UnitPrice desc) 最高单价,
                            (select top 1 UnitPrice from OrderDetails where ProductID=a.ProductID order by UnitPrice asc) 最低单价
                            from OrderDetails a
                            group by ProductID";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
