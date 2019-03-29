namespace Demo
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
            this.label1 = new System.Windows.Forms.Label();
            this.chbDeptNo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbSName = new System.Windows.Forms.CheckBox();
            this.chbSpecName = new System.Windows.Forms.CheckBox();
            this.cboDeptNo = new System.Windows.Forms.ComboBox();
            this.cboSpecName = new System.Windows.Forms.ComboBox();
            this.txt_SName = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dv_search = new System.Windows.Forms.DataGridView();
            this.btnIn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息统计";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnIn);
            this.tabPage2.Controls.Add(this.dv_search);
            this.tabPage2.Controls.Add(this.btn_search);
            this.tabPage2.Controls.Add(this.txt_SName);
            this.tabPage2.Controls.Add(this.cboSpecName);
            this.tabPage2.Controls.Add(this.cboDeptNo);
            this.tabPage2.Controls.Add(this.chbSpecName);
            this.tabPage2.Controls.Add(this.chbSName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.chbDeptNo);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "信息查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择查询条件：";
            // 
            // chbDeptNo
            // 
            this.chbDeptNo.AutoSize = true;
            this.chbDeptNo.Location = new System.Drawing.Point(49, 45);
            this.chbDeptNo.Name = "chbDeptNo";
            this.chbDeptNo.Size = new System.Drawing.Size(15, 14);
            this.chbDeptNo.TabIndex = 1;
            this.chbDeptNo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "学生姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "系编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "专业名称：";
            // 
            // chbSName
            // 
            this.chbSName.AutoSize = true;
            this.chbSName.Location = new System.Drawing.Point(49, 116);
            this.chbSName.Name = "chbSName";
            this.chbSName.Size = new System.Drawing.Size(15, 14);
            this.chbSName.TabIndex = 5;
            this.chbSName.UseVisualStyleBackColor = true;
            // 
            // chbSpecName
            // 
            this.chbSpecName.AutoSize = true;
            this.chbSpecName.Location = new System.Drawing.Point(49, 79);
            this.chbSpecName.Name = "chbSpecName";
            this.chbSpecName.Size = new System.Drawing.Size(15, 14);
            this.chbSpecName.TabIndex = 6;
            this.chbSpecName.UseVisualStyleBackColor = true;
            // 
            // cboDeptNo
            // 
            this.cboDeptNo.FormattingEnabled = true;
            this.cboDeptNo.Location = new System.Drawing.Point(155, 39);
            this.cboDeptNo.Name = "cboDeptNo";
            this.cboDeptNo.Size = new System.Drawing.Size(141, 20);
            this.cboDeptNo.TabIndex = 7;
            this.cboDeptNo.SelectedIndexChanged += new System.EventHandler(this.cboDeptNo_SelectedIndexChanged);
            // 
            // cboSpecName
            // 
            this.cboSpecName.FormattingEnabled = true;
            this.cboSpecName.Location = new System.Drawing.Point(155, 73);
            this.cboSpecName.Name = "cboSpecName";
            this.cboSpecName.Size = new System.Drawing.Size(141, 20);
            this.cboSpecName.TabIndex = 9;
            this.cboSpecName.SelectedIndexChanged += new System.EventHandler(this.cboSpecName_SelectedIndexChanged);
            // 
            // txt_SName
            // 
            this.txt_SName.Location = new System.Drawing.Point(155, 109);
            this.txt_SName.Name = "txt_SName";
            this.txt_SName.Size = new System.Drawing.Size(141, 21);
            this.txt_SName.TabIndex = 10;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(345, 39);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dv_search
            // 
            this.dv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_search.Location = new System.Drawing.Point(11, 169);
            this.dv_search.Name = "dv_search";
            this.dv_search.RowTemplate.Height = 23;
            this.dv_search.Size = new System.Drawing.Size(409, 150);
            this.dv_search.TabIndex = 12;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(345, 94);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 13;
            this.btnIn.Text = "导入数据";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dv_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_SName;
        private System.Windows.Forms.ComboBox cboSpecName;
        private System.Windows.Forms.ComboBox cboDeptNo;
        private System.Windows.Forms.CheckBox chbSpecName;
        private System.Windows.Forms.CheckBox chbSName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbDeptNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
    }
}