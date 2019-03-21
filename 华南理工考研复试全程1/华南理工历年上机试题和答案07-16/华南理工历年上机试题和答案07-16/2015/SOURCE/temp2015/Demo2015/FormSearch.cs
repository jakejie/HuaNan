using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo2015
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        

        private void FormSearch_Load(object sender, EventArgs e)
        {
            string sql = @"select * From EMPLOYEE";
            DataTable dt = DBHelperSQL.TableSelect(sql);
            cboEmpNo.DataSource = dt;
            cboEmpNo.DisplayMember = dt.Columns["EmpNo"].ToString();
            cboEmpNo.ValueMember = dt.Columns["EmpNo"].ToString();
            cboEmpName.DataSource = dt;
            cboEmpName.DisplayMember = dt.Columns["EmpName"].ToString();
            cboEmpName.ValueMember = dt.Columns["EmpName"].ToString();
            cboEmpNo.SelectedIndex = 0;

        }
        private void cboEmpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select c.EmpName 员工姓名,b.CmpName 公司名,a.Salary 薪水
                            from WORKS a,COMPANY b,EMPLOYEE c
                            where a.CmpNo=b.CmpNo and c.EmpNo=a.EmpNo and c.EmpNo=@EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo", cboEmpNo.SelectedValue.ToString()) };
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
        }

        private void cboEmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select c.EmpName 员工姓名,b.CmpName 公司名,a.Salary 薪水
                            from WORKS a,COMPANY b,EMPLOYEE c
                            where a.CmpNo=b.CmpNo and c.EmpNo=a.EmpNo and c.EmpNo=@EmpName";
            SqlParameter[] para = { new SqlParameter("@EmpName", cboEmpName.SelectedValue.ToString())};
            dv.DataSource = DBHelperSQL.TableSelect(sql,para);
        }

        
    }
}
