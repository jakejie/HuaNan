using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2013
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void btnSS1_Click(object sender, EventArgs e)
        {
            string sql = @"select c.TNmae 教师名,b.CName 课程名
                            from WORKS a,COURSES b,TEACHERS c
                            where a.CNo=b.CNo and c.TNo=a.TNo and a.TNo in(select TNo
												                            from WORKS
												                            group by TNo
												                            having COUNT(*)>1)";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
