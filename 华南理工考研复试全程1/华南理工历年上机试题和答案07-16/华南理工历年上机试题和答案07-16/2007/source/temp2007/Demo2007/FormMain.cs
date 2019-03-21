using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2007
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            FormEmp fe = new FormEmp();
            fe.Show();
        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            FormDept fd = new FormDept();
            fd.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            FormDisplay fdp = new FormDisplay();
            fdp.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch fs = new FormSearch();
            fs.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
