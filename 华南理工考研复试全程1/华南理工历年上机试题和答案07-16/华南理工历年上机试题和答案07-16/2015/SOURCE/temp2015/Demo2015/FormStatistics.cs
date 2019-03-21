using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2015
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }



        private void btnS1_Click(object sender, EventArgs e)
        {
            string sql = @"select b.EmpName ,SUM(Salary) 薪水
                            from WORKS a,EMPLOYEE b
                            where a.EmpNo=b.EmpNo and b.EmpAge>=40
                            group by b.EmpNo ,b.EmpName
                            order by 薪水 desc";
          
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select c.EmpName 员工姓名,b.CmpName 公司名
                            from WORKS a,COMPANY b,EMPLOYEE c
                            where a.CmpNo=b.CmpNo and c.EmpNo=a.EmpNo and c.EmpNo in(select EmpNo
														                            from WORKS
														                            group by EmpNo
														                            having COUNT(*)>1)";
           
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
