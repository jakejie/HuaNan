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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 学生表的维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent fstudent = new FormStudent();
            fstudent.MdiParent = this;
            fstudent.Show();
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch fse = new FormSearch();
            fse.MdiParent = this;
            fse.Show();
        }

        private void 信息统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistics fss = new FormStatistics();
            fss.MdiParent = this;
            fss.Show();
        }

        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
