namespace Demo2016
{
    partial class FormSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDeptNo = new System.Windows.Forms.ComboBox();
            this.cboSpecName = new System.Windows.Forms.ComboBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.dv = new System.Windows.Forms.DataGridView();
            this.chbSNo = new System.Windows.Forms.CheckBox();
            this.chbSName = new System.Windows.Forms.CheckBox();
            this.chbDeptNo = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "专业名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "系编号：";
            // 
            // cboDeptNo
            // 
            this.cboDeptNo.FormattingEnabled = true;
            this.cboDeptNo.Location = new System.Drawing.Point(194, 111);
            this.cboDeptNo.Name = "cboDeptNo";
            this.cboDeptNo.Size = new System.Drawing.Size(144, 20);
            this.cboDeptNo.TabIndex = 3;
            // 
            // cboSpecName
            // 
            this.cboSpecName.FormattingEnabled = true;
            this.cboSpecName.Location = new System.Drawing.Point(194, 73);
            this.cboSpecName.Name = "cboSpecName";
            this.cboSpecName.Size = new System.Drawing.Size(144, 20);
            this.cboSpecName.TabIndex = 4;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(194, 35);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(144, 21);
            this.txtSName.TabIndex = 5;
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(55, 152);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(480, 165);
            this.dv.TabIndex = 6;
            // 
            // chbSNo
            // 
            this.chbSNo.AutoSize = true;
            this.chbSNo.Location = new System.Drawing.Point(54, 44);
            this.chbSNo.Name = "chbSNo";
            this.chbSNo.Size = new System.Drawing.Size(15, 14);
            this.chbSNo.TabIndex = 7;
            this.chbSNo.UseVisualStyleBackColor = true;
            // 
            // chbSName
            // 
            this.chbSName.AutoSize = true;
            this.chbSName.Location = new System.Drawing.Point(54, 81);
            this.chbSName.Name = "chbSName";
            this.chbSName.Size = new System.Drawing.Size(15, 14);
            this.chbSName.TabIndex = 8;
            this.chbSName.UseVisualStyleBackColor = true;
            // 
            // chbDeptNo
            // 
            this.chbDeptNo.AutoSize = true;
            this.chbDeptNo.Location = new System.Drawing.Point(54, 117);
            this.chbDeptNo.Name = "chbDeptNo";
            this.chbDeptNo.Size = new System.Drawing.Size(15, 14);
            this.chbDeptNo.TabIndex = 9;
            this.chbDeptNo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "请勾选查询条件：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(419, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 356);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbDeptNo);
            this.Controls.Add(this.chbSName);
            this.Controls.Add(this.chbSNo);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.cboSpecName);
            this.Controls.Add(this.cboDeptNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDeptNo;
        private System.Windows.Forms.ComboBox cboSpecName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.CheckBox chbSNo;
        private System.Windows.Forms.CheckBox chbSName;
        private System.Windows.Forms.CheckBox chbDeptNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
    }
}