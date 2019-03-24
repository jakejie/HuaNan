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

namespace Demo2015
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string sql = @"select * from EMPLOYEE";
            DataTable dtEmpNo = DBHelperSQL.TableSelect(sql);
            cboEmpNo.DataSource = dtEmpNo;
            cboEmpNo.DisplayMember = dtEmpNo.Columns["EmpNo"].ToString();
            cboEmpNo.ValueMember = dtEmpNo.Columns["EmpNo"].ToString();
            cboEmpNo.SelectedIndex = 0;

            DataTable dtEmpName = DBHelperSQL.TableSelect(sql);
            cboEmpName.DataSource = dtEmpName;
            cboEmpName.DisplayMember = dtEmpName.Columns["EmpName"].ToString();
            cboEmpName.ValueMember = dtEmpName.Columns["EmpName"].ToString();
            cboEmpName.SelectedIndex = 0;
        }

        private void cboEmpNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select a.EmpNo 员工号,a.EmpName 员工姓名,b.CmpName 公司名,c.Salary 工资
                            from EMPLOYEE a,COMPANY b,WORKS c
                            where a.EmpNo=c.EmpNo and b.CmpNo=c.CmpNo and a.EmpNo=@EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo",cboEmpNo.SelectedValue.ToString())};
            dv_search.DataSource = DBHelperSQL.TableSelect(sql,para);
        }

        private void cboEmpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = @"select a.EmpNo 员工号,a.EmpName 员工姓名,b.CmpName 公司名,c.Salary 工资
                            from EMPLOYEE a,COMPANY b,WORKS c
                            where a.EmpNo=c.EmpNo and b.CmpNo=c.CmpNo and a.EmpName=@EmpName";
            SqlParameter[] para = { new SqlParameter("@EmpName", cboEmpName.SelectedValue.ToString()) };
            dv_search.DataSource = DBHelperSQL.TableSelect(sql, para);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            string sql = @"select a.EmpName 员工姓名,b.CmpName 公司名
                            from EMPLOYEE a,COMPANY b,WORKS c
                            where a.EmpNo=c.EmpNo and b.CmpNo=c.CmpNo and c.EmpNo in(
													                            select EmpNo
													                            from WORKS
													                            group by EmpNo
													                            having count(*)>1)";
            dv_statistics.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            string sql = @"select a.EmpName 员工姓名,SUM(c.Salary) 总工资
                            from EMPLOYEE a,COMPANY b,WORKS c
                            where a.EmpNo=c.EmpNo and b.CmpNo=c.CmpNo and a.EmpAge>=40
                            group by a.EmpName 
                            order by 总工资 desc ";
            dv_statistics.DataSource = DBHelperSQL.TableSelect(sql);
        }

        string sex;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO [test2015].[dbo].[EMPLOYEE]
                                   ([EmpNo]
                                   ,[EmpName]
                                   ,[EmpSex]
                                   ,[EmpAge])
                             VALUES(@EmpNo,@EmpName,@EmpSex,@EmpAge)";
            SqlParameter[] para = {new SqlParameter("@EmpNo",txtEmpNo.Text),
                                    new SqlParameter("@EmpName",txtEmpName.Text),
                                    new SqlParameter("@EmpSex",sex),
                                    new SqlParameter("@EmpAge",txtEmpAge.Text)};
            DBHelperSQL.TableChange(sql,para);
            MyShow();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = @"DELETE FROM [test2015].[dbo].[EMPLOYEE]
                                    WHERE EmpNo=@EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo",txtEmpNo.Text)};
            DBHelperSQL.TableChange(sql, para);
            MyShow();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"UPDATE [test2015].[dbo].[EMPLOYEE]
                           SET [EmpNo] = @EmpNo
                              ,[EmpName] = @EmpName
                              ,[EmpSex] = @EmpSex
                              ,[EmpAge] = @EmpAge
                         WHERE EmpNo=@EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo",txtEmpNo.Text),
                                    new SqlParameter("@EmpName",txtEmpName.Text),
                                    new SqlParameter("@EmpSex",sex),
                                    new SqlParameter("@EmpAge",txtEmpAge.Text)};
            DBHelperSQL.TableChange(sql,para);
            MyShow();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT [EmpNo] 员工号
                                  ,[EmpName] 员工姓名
                                  ,[EmpSex] 性别
                                  ,[EmpAge] 年龄
                              FROM [test2015].[dbo].[EMPLOYEE]
                              WHERE EmpNo=@EmpNo";
            SqlParameter[] para = { new SqlParameter("@EmpNo", txtEmpNo.Text) };
            dv.DataSource = DBHelperSQL.TableSelect(sql,para);
        }

       

        private void rdbtnM_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            sex = rb.Text;
        }

        private void rdbtnF_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            sex = rb.Text;

        }
        void MyShow()
        {
            string sql = @"SELECT [EmpNo] 员工号
                                  ,[EmpName] 员工姓名
                                  ,[EmpSex] 性别
                                  ,[EmpAge] 年龄
                              FROM [test2015].[dbo].[EMPLOYEE]";
         
            dv.DataSource = DBHelperSQL.TableSelect(sql);

        }
    }
}
