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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void cboTNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select a.TName 教师名, b.CName 课程名,b.CTime 课时
                            from TEACHERS a,COURSES b
                            where a.TNo=b.TNo and a.TNo=@TNo";
            SqlParameter[] para={new SqlParameter("@TNo",cboTNo.SelectedValue.ToString())};
            dv.DataSource = DBHelperSQL.TableSelect(sql,para);
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT [TNo]
                              ,[TName]
                              ,[Dept]
                              ,[ReNo]
                          FROM [test2014].[dbo].[TEACHERS]";
            DataTable dt = DBHelperSQL.TableSelect(sql);
            cboTNo.DataSource = dt;
            cboTNo.DisplayMember = dt.Columns["TNo"].ToString();
            cboTNo.ValueMember = dt.Columns["TNo"].ToString();
            cboTName.DataSource = dt;
            cboTName.DisplayMember = dt.Columns["TName"].ToString();
            cboTName.ValueMember = dt.Columns["TName"].ToString();
            cboTNo.SelectedIndex = 0;
        }
    }
}
