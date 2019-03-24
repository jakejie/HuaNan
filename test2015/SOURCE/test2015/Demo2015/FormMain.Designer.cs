namespace Demo2015
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
            this.cboEmpNo = new System.Windows.Forms.ComboBox();
            this.cboEmpName = new System.Windows.Forms.ComboBox();
            this.dv_search = new System.Windows.Forms.DataGridView();
            this.btnAge = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.dv_statistics = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.txtEmpAge = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.rdbtnM = new System.Windows.Forms.RadioButton();
            this.rdbtnF = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
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
            this.tabControl1.Location = new System.Drawing.Point(-3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dv_search);
            this.tabPage1.Controls.Add(this.cboEmpName);
            this.tabPage1.Controls.Add(this.cboEmpNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 378);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dv_statistics);
            this.tabPage2.Controls.Add(this.btnWork);
            this.tabPage2.Controls.Add(this.btnAge);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "信息统计";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dv);
            this.tabPage3.Controls.Add(this.btnSelect);
            this.tabPage3.Controls.Add(this.btnUpdate);
            this.tabPage3.Controls.Add(this.btnDelete);
            this.tabPage3.Controls.Add(this.btnAdd);
            this.tabPage3.Controls.Add(this.rdbtnF);
            this.tabPage3.Controls.Add(this.rdbtnM);
            this.tabPage3.Controls.Add(this.txtEmpName);
            this.tabPage3.Controls.Add(this.txtEmpAge);
            this.tabPage3.Controls.Add(this.txtEmpNo);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(497, 378);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "信息维护";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工名：";
            // 
            // cboEmpNo
            // 
            this.cboEmpNo.FormattingEnabled = true;
            this.cboEmpNo.Location = new System.Drawing.Point(195, 31);
            this.cboEmpNo.Name = "cboEmpNo";
            this.cboEmpNo.Size = new System.Drawing.Size(153, 20);
            this.cboEmpNo.TabIndex = 2;
            this.cboEmpNo.SelectedIndexChanged += new System.EventHandler(this.cboEmpNo_SelectedIndexChanged);
            // 
            // cboEmpName
            // 
            this.cboEmpName.FormattingEnabled = true;
            this.cboEmpName.Location = new System.Drawing.Point(195, 79);
            this.cboEmpName.Name = "cboEmpName";
            this.cboEmpName.Size = new System.Drawing.Size(153, 20);
            this.cboEmpName.TabIndex = 3;
            this.cboEmpName.SelectedIndexChanged += new System.EventHandler(this.cboEmpName_SelectedIndexChanged);
            // 
            // dv_search
            // 
            this.dv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_search.Location = new System.Drawing.Point(31, 148);
            this.dv_search.Name = "dv_search";
            this.dv_search.RowTemplate.Height = 23;
            this.dv_search.Size = new System.Drawing.Size(449, 207);
            this.dv_search.TabIndex = 4;
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(95, 43);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(269, 28);
            this.btnAge.TabIndex = 0;
            this.btnAge.Text = "年龄至少为40岁员工的总工资";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(95, 103);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(269, 28);
            this.btnWork.TabIndex = 1;
            this.btnWork.Text = "至少具有两份工作员工的姓名和其公司名";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // dv_statistics
            // 
            this.dv_statistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_statistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_statistics.Location = new System.Drawing.Point(42, 180);
            this.dv_statistics.Name = "dv_statistics";
            this.dv_statistics.RowTemplate.Height = 23;
            this.dv_statistics.Size = new System.Drawing.Size(427, 169);
            this.dv_statistics.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "员工号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "员工姓名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "年龄";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Location = new System.Drawing.Point(106, 20);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(114, 21);
            this.txtEmpNo.TabIndex = 4;
            // 
            // txtEmpAge
            // 
            this.txtEmpAge.Location = new System.Drawing.Point(106, 132);
            this.txtEmpAge.Name = "txtEmpAge";
            this.txtEmpAge.Size = new System.Drawing.Size(114, 21);
            this.txtEmpAge.TabIndex = 5;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(106, 61);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(114, 21);
            this.txtEmpName.TabIndex = 6;
            // 
            // rdbtnM
            // 
            this.rdbtnM.AutoSize = true;
            this.rdbtnM.Location = new System.Drawing.Point(106, 103);
            this.rdbtnM.Name = "rdbtnM";
            this.rdbtnM.Size = new System.Drawing.Size(35, 16);
            this.rdbtnM.TabIndex = 7;
            this.rdbtnM.TabStop = true;
            this.rdbtnM.Text = "男";
            this.rdbtnM.UseVisualStyleBackColor = true;
            this.rdbtnM.CheckedChanged += new System.EventHandler(this.rdbtnM_CheckedChanged);
            // 
            // rdbtnF
            // 
            this.rdbtnF.AutoSize = true;
            this.rdbtnF.Location = new System.Drawing.Point(185, 103);
            this.rdbtnF.Name = "rdbtnF";
            this.rdbtnF.Size = new System.Drawing.Size(35, 16);
            this.rdbtnF.TabIndex = 8;
            this.rdbtnF.TabStop = true;
            this.rdbtnF.Text = "女";
            this.rdbtnF.UseVisualStyleBackColor = true;
            this.rdbtnF.CheckedChanged += new System.EventHandler(this.rdbtnF_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 29);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加员工";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(381, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除员工";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(263, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "修改员工信息";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(381, 74);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(94, 23);
            this.btnSelect.TabIndex = 12;
            this.btnSelect.Text = "查询员工信息";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(35, 180);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(421, 171);
            this.dv.TabIndex = 13;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 408);
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
        private System.Windows.Forms.ComboBox cboEmpName;
        private System.Windows.Forms.ComboBox cboEmpNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dv_statistics;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rdbtnF;
        private System.Windows.Forms.RadioButton rdbtnM;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpAge;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}