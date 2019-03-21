using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2007
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = @"select * from Employee where EmpID=
                        (Select EmpID From Department where DeptID=
                        (select DeptID From Employee where EmpName=@EmpName))";
            SqlParameter[] para = { new SqlParameter("@EmpName", txtEmpName.Text) };
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
        }

    }
}
