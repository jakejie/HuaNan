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
    public partial class FormDisplay : Form
    {
        public FormDisplay()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "Select * from "+cboTableName.SelectedItem.ToString();
            dv.DataSource = DBHelperSQL.TableSelect(sql);
        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            cboTableName.SelectedIndex =0;
        }
    }
}
