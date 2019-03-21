using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2012
{
    public partial class FormStatistics : Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string sql = @"select EmpID,SUM(Salary) 工资
                            from Works
                            group by EmpID
                            having COUNT(*)>1";
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
