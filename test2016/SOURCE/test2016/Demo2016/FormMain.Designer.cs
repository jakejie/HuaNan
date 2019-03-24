namespace Demo2016
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDeptNo = new System.Windows.Forms.ComboBox();
            this.cboSpecName = new System.Windows.Forms.ComboBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.chbDeptNo = new System.Windows.Forms.CheckBox();
            this.chbSpecName = new System.Windows.Forms.CheckBox();
            this.chbSName = new System.Windows.Forms.CheckBox();
            this.dv_search = new System.Windows.Forms.DataGridView();
            this.btn_search = new System.Windows.Forms.Button();
            this.btnSumStuofDep = new System.Windows.Forms.Button();
            this.btnsumStuofCYear = new System.Windows.Forms.Button();
            this.dv_statistics = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSNo = new System.Windows.Forms.TextBox();
            this.txtCNo = new System.Windows.Forms.TextBox();
            this.txt_SDate = new System.Windows.Forms.TextBox();
            this.txt_SName = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dv = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv_statistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 402);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.dv_search);
            this.tabPage1.Controls.Add(this.chbSName);
            this.tabPage1.Controls.Add(this.chbSpecName);
            this.tabPage1.Controls.Add(this.chbDeptNo);
            this.tabPage1.Controls.Add(this.txtSName);
            this.tabPage1.Controls.Add(this.cboSpecName);
            this.tabPage1.Controls.Add(this.cboDeptNo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dv_statistics);
            this.tabPage2.Controls.Add(this.btnsumStuofCYear);
            this.tabPage2.Controls.Add(this.btnSumStuofDep);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "信息统计";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dv);
            this.tabPage3.Controls.Add(this.btn_Delete);
            this.tabPage3.Controls.Add(this.btn_Update);
            this.tabPage3.Controls.Add(this.btn_Select);
            this.tabPage3.Controls.Add(this.btn_Add);
            this.tabPage3.Controls.Add(this.txt_SName);
            this.tabPage3.Controls.Add(this.txt_SDate);
            this.tabPage3.Controls.Add(this.txtCNo);
            this.tabPage3.Controls.Add(this.txtSNo);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(539, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "信息维护";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择查询条件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "系编号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "专业名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "学生姓名：";
            // 
            // cboDeptNo
            // 
            this.cboDeptNo.FormattingEnabled = true;
            this.cboDeptNo.Location = new System.Drawing.Point(212, 37);
            this.cboDeptNo.Name = "cboDeptNo";
            this.cboDeptNo.Size = new System.Drawing.Size(158, 20);
            this.cboDeptNo.TabIndex = 4;
            // 
            // cboSpecName
            // 
            this.cboSpecName.FormattingEnabled = true;
            this.cboSpecName.Location = new System.Drawing.Point(212, 71);
            this.cboSpecName.Name = "cboSpecName";
            this.cboSpecName.Size = new System.Drawing.Size(158, 20);
            this.cboSpecName.TabIndex = 5;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(212, 104);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(158, 21);
            this.txtSName.TabIndex = 6;
            // 
            // chbDeptNo
            // 
            this.chbDeptNo.AutoSize = true;
            this.chbDeptNo.Location = new System.Drawing.Point(115, 45);
            this.chbDeptNo.Name = "chbDeptNo";
            this.chbDeptNo.Size = new System.Drawing.Size(15, 14);
            this.chbDeptNo.TabIndex = 7;
            this.chbDeptNo.UseVisualStyleBackColor = true;
            // 
            // chbSpecName
            // 
            this.chbSpecName.AutoSize = true;
            this.chbSpecName.Location = new System.Drawing.Point(115, 77);
            this.chbSpecName.Name = "chbSpecName";
            this.chbSpecName.Size = new System.Drawing.Size(15, 14);
            this.chbSpecName.TabIndex = 8;
            this.chbSpecName.UseVisualStyleBackColor = true;
            // 
            // chbSName
            // 
            this.chbSName.AutoSize = true;
            this.chbSName.Location = new System.Drawing.Point(115, 113);
            this.chbSName.Name = "chbSName";
            this.chbSName.Size = new System.Drawing.Size(15, 14);
            this.chbSName.TabIndex = 9;
            this.chbSName.UseVisualStyleBackColor = true;
            // 
            // dv_search
            // 
            this.dv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_search.Location = new System.Drawing.Point(42, 154);
            this.dv_search.Name = "dv_search";
            this.dv_search.RowTemplate.Height = 23;
            this.dv_search.Size = new System.Drawing.Size(464, 194);
            this.dv_search.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(419, 68);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btnSumStuofDep
            // 
            this.btnSumStuofDep.Location = new System.Drawing.Point(118, 33);
            this.btnSumStuofDep.Name = "btnSumStuofDep";
            this.btnSumStuofDep.Size = new System.Drawing.Size(258, 23);
            this.btnSumStuofDep.TabIndex = 0;
            this.btnSumStuofDep.Text = "统计每个系的总学生数";
            this.btnSumStuofDep.UseVisualStyleBackColor = true;
            this.btnSumStuofDep.Click += new System.EventHandler(this.btnSumStuofDep_Click);
            // 
            // btnsumStuofCYear
            // 
            this.btnsumStuofCYear.Location = new System.Drawing.Point(118, 73);
            this.btnsumStuofCYear.Name = "btnsumStuofCYear";
            this.btnsumStuofCYear.Size = new System.Drawing.Size(258, 23);
            this.btnsumStuofCYear.TabIndex = 1;
            this.btnsumStuofCYear.Text = "根据入学年份统计每年的入学人数";
            this.btnsumStuofCYear.UseVisualStyleBackColor = true;
            this.btnsumStuofCYear.Click += new System.EventHandler(this.btnsumStuofCYear_Click);
            // 
            // dv_statistics
            // 
            this.dv_statistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_statistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_statistics.Location = new System.Drawing.Point(47, 144);
            this.dv_statistics.Name = "dv_statistics";
            this.dv_statistics.RowTemplate.Height = 23;
            this.dv_statistics.Size = new System.Drawing.Size(417, 183);
            this.dv_statistics.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "学生编号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "班级编号：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "出生日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "学生姓名：";
            // 
            // txtSNo
            // 
            this.txtSNo.Location = new System.Drawing.Point(119, 20);
            this.txtSNo.Name = "txtSNo";
            this.txtSNo.Size = new System.Drawing.Size(126, 21);
            this.txtSNo.TabIndex = 4;
            // 
            // txtCNo
            // 
            this.txtCNo.Location = new System.Drawing.Point(119, 129);
            this.txtCNo.Name = "txtCNo";
            this.txtCNo.Size = new System.Drawing.Size(126, 21);
            this.txtCNo.TabIndex = 5;
            // 
            // txt_SDate
            // 
            this.txt_SDate.Location = new System.Drawing.Point(119, 90);
            this.txt_SDate.Name = "txt_SDate";
            this.txt_SDate.Size = new System.Drawing.Size(126, 21);
            this.txt_SDate.TabIndex = 6;
            // 
            // txt_SName
            // 
            this.txt_SName.Location = new System.Drawing.Point(119, 53);
            this.txt_SName.Name = "txt_SName";
            this.txt_SName.Size = new System.Drawing.Size(126, 21);
            this.txt_SName.TabIndex = 7;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(301, 29);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "添加学生";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(409, 99);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(89, 23);
            this.btn_Select.TabIndex = 9;
            this.btn_Select.Text = "查询学生信息";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(290, 99);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 23);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "修改学生信息";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(409, 29);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "删除学生";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(33, 189);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(465, 154);
            this.dv.TabIndex = 12;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 414);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv_statistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dv_search;
        private System.Windows.Forms.CheckBox chbSName;
        private System.Windows.Forms.CheckBox chbSpecName;
        private System.Windows.Forms.CheckBox chbDeptNo;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.ComboBox cboSpecName;
        private System.Windows.Forms.ComboBox cboDeptNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dv_statistics;
        private System.Windows.Forms.Button btnsumStuofCYear;
        private System.Windows.Forms.Button btnSumStuofDep;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_SName;
        private System.Windows.Forms.TextBox txt_SDate;
        private System.Windows.Forms.TextBox txtCNo;
        private System.Windows.Forms.TextBox txtSNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}