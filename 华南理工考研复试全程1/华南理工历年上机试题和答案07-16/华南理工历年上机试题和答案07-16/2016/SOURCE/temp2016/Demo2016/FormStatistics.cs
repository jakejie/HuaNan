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
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            string sql = @"select a.DeptNo 系编号,b.DeptName 系名称,SUM(a.Num) 总人数
                            from Class a,Department b
                            where a.DeptNo=b.DeptNo
                            group by a.DeptNo,b.DeptName";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select CYear 入学年份,SUM(Num) 总人数
                            from Class
                            group by CYear";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
