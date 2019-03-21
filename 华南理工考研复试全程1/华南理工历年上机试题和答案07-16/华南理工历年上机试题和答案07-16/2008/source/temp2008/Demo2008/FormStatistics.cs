using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2008
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string sql = @"select  DeptID 学院名称,Sum(AllNum) 总人数
                            From Class
                            group by DeptID";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            string sql = @"select JoinYear 入学年份,COUNT(*) 人数
                            from Student 
                            group by JoinYear";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
