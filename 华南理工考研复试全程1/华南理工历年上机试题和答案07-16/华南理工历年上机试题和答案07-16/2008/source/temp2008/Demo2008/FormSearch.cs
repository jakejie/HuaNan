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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"select *
                                            from Student,Class,Department
                                            where Student.ClassNo=Class.ClassNo and Class.DeptID=Department.DeptID 
                                            and (Student.SName like '%{0}%' 
                                            or Class.ClassName like '%{1}%' 
                                            or Department.DeptName like '%{2}%')", txtVar.Text, txtVar.Text, txtVar.Text);
           dv.DataSource = DBHelperSQL.TableSelect(sql);
        }
    }
}
