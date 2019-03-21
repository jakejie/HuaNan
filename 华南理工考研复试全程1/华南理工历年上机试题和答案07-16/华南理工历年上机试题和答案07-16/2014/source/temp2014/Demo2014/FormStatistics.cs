using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2014
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            string sql = @"select a.TName 教师名,b.CNo 课程号, b.CName 课程名,b.CTime 课时
                            from TEACHERS a,COURSES b
                            where a.TNo=b.TNo and a.TNo in (select TNo
								                            from COURSES
								                            group by TNo
								                            having COUNT(*)=1)";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select a.TName,SUM(b.CTime*c.Salary) 薪水
                            from TEACHERS a,COURSES b,REMUNERATIONS c
                            where a.TNo=b.TNo and a.ReNo=c.ReNo
                            group by a.TName,a.TNo
                            order by 薪水 desc";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
