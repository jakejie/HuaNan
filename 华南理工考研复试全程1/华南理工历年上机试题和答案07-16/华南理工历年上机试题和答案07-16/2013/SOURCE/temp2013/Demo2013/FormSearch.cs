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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btnS1_Click(object sender, EventArgs e)
        {

        }

        private void btnS2_Click(object sender, EventArgs e)
        {

        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            string sql = @"SELECT [TNo]
                              ,[TNmae]
                              ,[TSex]
                          FROM [test2013].[dbo].[TEACHERS]";
            DataTable dt = DBHelperSQL.TableSelect(sql);
            cboTNo.DataSource = dt;
            cboTNo.DisplayMember = dt.Columns["TNo"].ToString();
            cboTNo.ValueMember = dt.Columns["TNo"].ToString();
            cboTName.DataSource = dt;
            cboTName.DisplayMember = dt.Columns["TNmae"].ToString();
            cboTName.ValueMember = dt.Columns["TNmae"].ToString();
            cboTNo.SelectedIndex = 0;
            string sqly = @"select distinct WYear from WORKS";
            DataTable dty = DBHelperSQL.TableSelect(sqly);
            cboYear.DataSource = dty;
            cboYear.DisplayMember = dty.Columns["WYear"].ToString();
            cboYear.ValueMember = dty.Columns["WYear"].ToString();
            cboYear.SelectedIndex = 0;
        }

        private void cboTNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select a.TNo,c.TNmae,b.CName,b.CTime,a.Term,a.WYear
                            from WORKS a,COURSES b,TEACHERS c
                            where a.CNo=b.CNo and c.TNo=a.TNo and a.TNo=@TNo";
            SqlParameter[] para = { new SqlParameter("@TNo", cboTNo.SelectedValue.ToString())};
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
        }

        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select a.TNo,c.TNmae,b.CName,b.CTime,a.Term,a.WYear
                            from WORKS a,COURSES b,TEACHERS c
                            where a.CNo=b.CNo and c.TNo=a.TNo and a.WYear=@WYear";
            SqlParameter[] para = { new SqlParameter("@WYear", cboYear.SelectedValue.ToString()) };
            dv.DataSource = DBHelperSQL.TableSelect(sql, para);
            
        }


    }
}
