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

namespace Demo2016
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
            cboSpecName.ValueMember= dt_SpecName.Columns["SpecName"].ToString();
            cboSpecName.SelectedIndex = 0;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"select a.DeptNo 系编号,a.SpecName 专业名称,b.SName 学生姓名
                                        from Class a,Student b
                                        where a.CNo=b.CNo ");
            if(chbDeptNo.CheckState==CheckState.Checked)
            {
                sql += string.Format(@" and a.DeptNo='{0}'", cboDeptNo.SelectedValue.ToString());
            }
            if(chbSpecName.CheckState==CheckState.Checked)
            {
                sql += string.Format(@" and a.SpecName='{0}'", cboSpecName.SelectedValue.ToString());
            }
            if(chbSName.CheckState==CheckState.Checked)
            {
                sql += string.Format(@" and b.SName like '%{0}%'", txtSName.Text);
            }
            dv_search.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btnSumStuofDep_Click(object sender, EventArgs e)
        {
            string sql = @"select c.DeptNo 系编号,c.DeptName 系名,sum(a.Num) 总学生数
                            from Class a,Department c
                            where a.DeptNo=c.DeptNo
                            group by c.DeptNo,c.DeptName ";
            dv_statistics.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btnsumStuofCYear_Click(object sender, EventArgs e)
        {
            string sql = @"select a.Cyear 入学年份,sum(a.Num) 入学人数
                            from Class a
                            group by a.Cyear";
            dv_statistics.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2016].[dbo].[Student]
                                       ([SNo]
                                       ,[SName]
                                       ,[SDate]
                                       ,[CNo])
                                 VALUES(@SNo,@SName,@SDate,@CNo)";
                            
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text),
                                    new SqlParameter("@SName", txt_SName.Text),
                                    new SqlParameter("@SDate", txt_SDate.Text),
                                    new SqlParameter("@CNo", txtCNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2016].[dbo].[Student]
                                    WHERE [SNo] = @SNo";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2016].[dbo].[Student]
                               SET [SNo] = @SNo
                                  ,[SName] = @SName
                                  ,[SDate] = @SDate
                                  ,[CNo] = @CNo
                             WHERE [SNo] = @SNo";
            SqlParameter[] para = { new SqlParameter("@SNo", txtSNo.Text),
                                    new SqlParameter("@SName", txt_SName.Text),
                                    new SqlParameter("@SDate", txt_SDate.Text),
                                    new SqlParameter("@CNo", txtCNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT [SNo] 学生编号
                                  ,[SName] 学生姓名
                                  ,[SDate] 出生日期
                                  ,[CNo] 班级编号
                              FROM [test2016].[dbo].[Student]
                              WHERE [SNo]=@SNo";
            SqlParameter[] para = {new SqlParameter("@SNo",txtSNo.Text) };
            dv.DataSource = DBHelperSQL.TableSelect(sql,para);
        }

        void MyShow()
        {
            string sql = @"SELECT [SNo] 学生编号
                                  ,[SName] 学生姓名
                                  ,[SDate] 出生日期
                                  ,[CNo] 班级编号
                              FROM [test2016].[dbo].[Student]";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }

    }
}
