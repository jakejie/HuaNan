using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cboDeptNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboSpecName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = String.Format(@"select a.DeptNo 系编号,b.SpecName 专业名称,c.SName 学生姓名
                                        from Department a,Class b,Student c
                                        where a.DeptNo =b.DeptNo  and b.CNo=c.CNo");
            if(chbDeptNo.CheckState ==CheckState.Checked)
            {
                sql += String.Format(@" and a.DeptNo='{0}'",cboDeptNo.SelectedValue.ToString());
            }

            if (chbSpecName.CheckState == CheckState.Checked)
            {
                sql += String.Format(@" and b.SpecName='{0}'", cboSpecName.SelectedValue.ToString());
            }

            if (chbSName.CheckState == CheckState.Checked)
            {
                sql += String.Format(@" and c.SName like '%{0}%'", txt_SName.Text);
            }

            dv_search.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string sql_DeptNo = @"select * from Department";
            DataTable dt_DeptNo = DBHelperSQL.TableSelect(sql_DeptNo);

            cboDeptNo.DataSource = dt_DeptNo;
            cboDeptNo.DisplayMember = dt_DeptNo.Columns["DeptNo"].ToString();
            cboDeptNo.ValueMember = dt_DeptNo.Columns["DeptNo"].ToString();
            cboDeptNo.SelectedIndex = 0;

            string sql_SpecName = @"select * from Class";
            DataTable dt_SpecName = DBHelperSQL.TableSelect(sql_SpecName);

            cboSpecName.DataSource = dt_SpecName;
            cboSpecName.DisplayMember = dt_SpecName.Columns["SpecName"].ToString();
            cboSpecName.ValueMember = dt_SpecName.Columns["SpecName"].ToString();
            cboSpecName.SelectedIndex = 0;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            DataSet reportData = new DataSet(); //DataSet:是一个数据集，里面是DataTable的数据集合
            string path = System.Environment.CurrentDirectory + @"\grades.xml";
            reportData.ReadXml(path);

            SqlBulkCopy sbc = new SqlBulkCopy(DBHelperSQL.connStr);
            sbc.DestinationTableName = "[test2019].[dbo].[grades]";

            DataTable dt = reportData.Tables[0];//取DataSet里面的第一个DataTable
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sbc.ColumnMappings.Add(dt.Columns[i].ColumnName, dt.Columns[i].ColumnName);//将DataTable里面的列，与数据库中grades表中的列对应
            }
            sbc.WriteToServer(dt);//将DataTable中和数据写入数据库
        }
    }
}
