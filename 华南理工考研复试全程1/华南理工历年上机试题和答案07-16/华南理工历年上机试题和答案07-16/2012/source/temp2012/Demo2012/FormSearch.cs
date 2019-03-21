using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2012
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            string sql = @"select a.EmpID 员工号,b.EmpName 员工姓名,c.CName 公司名称,c.CPlace 公司所在地
                            from Works a,Employee b,Company c
                            where a.CID=c.CID and a.EmpID=b.EmpID and b.EmpName=@EmpName";
            SqlParameter[] para = { new SqlParameter("@EmpName", txtEmpName.Text) };
            dv.DataSource= DBHelperSQL.TableSelect(sql, para);

        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select EmpID,Salary 总工资
                            from Works
                            where CID=(select CID from Company where CName=@CName)";
            SqlParameter[] para = { new SqlParameter("@CName", txtCName.Text) };
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
        }
    }
}
