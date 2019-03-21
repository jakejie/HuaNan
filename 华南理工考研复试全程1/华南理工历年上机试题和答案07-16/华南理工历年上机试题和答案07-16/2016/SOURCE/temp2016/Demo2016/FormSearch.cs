using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2016
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string sql = string.Format(@"select a.SName 学生姓名,b.SpecName 专业名称,b.DeptNo 系编号
                            from Student a,Class b
                            where a.ClassNo=b.CNo ");
            if (chbSNo.CheckState == CheckState.Checked)
            {
                sql += string.Format(@"and a.SName like '%{0}%' ",txtSName.Text);
            }

            if (chbSName.CheckState == CheckState.Checked)
            {
                sql += string.Format(@"and b.SpecName='{0}'", cboSpecName.SelectedValue.ToString());
            }

            if (chbDeptNo.CheckState == CheckState.Checked)
            {
                sql += string.Format(@"and b.DeptNo='{0}' ", cboDeptNo.SelectedValue.ToString());
            }
            
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            string sqlD = @"SELECT [DeptNo]
                                  ,[DeptName]
                              FROM [test2016].[dbo].[Department]";
            DataTable dtD = DBHelperSQL.TableSelect(sqlD);
            cboDeptNo.DataSource = dtD;
            cboDeptNo.DisplayMember = dtD.Columns["DeptNo"].ToString();
            cboDeptNo.ValueMember = dtD.Columns["DeptNo"].ToString();
            cboDeptNo.SelectedIndex = 0;
            string sqlS = @"SELECT [CNo]
                              ,[SpecName]
                              ,[Num]
                              ,[CYear]
                              ,[DeptNo]
                          FROM [test2016].[dbo].[Class]";
            DataTable dtS = DBHelperSQL.TableSelect(sqlS);
            cboSpecName.DataSource = dtS;
            cboSpecName.DisplayMember = dtS.Columns["SpecName"].ToString();
            cboSpecName.ValueMember = dtS.Columns["SpecName"].ToString();
            cboSpecName.SelectedIndex = 0;

        }
    }
}
