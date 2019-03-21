namespace Demo2013
{
    partial class FormTeacher
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
            this.txtTNo = new System.Windows.Forms.TextBox();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.rdbtnM = new System.Windows.Forms.RadioButton();
            this.rdbtnF = new System.Windows.Forms.RadioButton();
            this.dv = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "教师名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "教师性别：";
            // 
            // txtTNo
            // 
            this.txtTNo.Location = new System.Drawing.Point(122, 24);
            this.txtTNo.Name = "txtTNo";
            this.txtTNo.Size = new System.Drawing.Size(100, 21);
            this.txtTNo.TabIndex = 3;
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(122, 63);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(100, 21);
            this.txtTName.TabIndex = 4;
            // 
            // rdbtnM
            // 
            this.rdbtnM.AutoSize = true;
            this.rdbtnM.Location = new System.Drawing.Point(122, 102);
            this.rdbtnM.Name = "rdbtnM";
            this.rdbtnM.Size = new System.Drawing.Size(35, 16);
            this.rdbtnM.TabIndex = 5;
            this.rdbtnM.TabStop = true;
            this.rdbtnM.Text = "男";
            this.rdbtnM.UseVisualStyleBackColor = true;
            this.rdbtnM.CheckedChanged += new System.EventHandler(this.rdbtnM_CheckedChanged);
            // 
            // rdbtnF
            // 
            this.rdbtnF.AutoSize = true;
            this.rdbtnF.Location = new System.Drawing.Point(187, 100);
            this.rdbtnF.Name = "rdbtnF";
            this.rdbtnF.Size = new System.Drawing.Size(35, 16);
            this.rdbtnF.TabIndex = 6;
            this.rdbtnF.TabStop = true;
            this.rdbtnF.Text = "女";
            this.rdbtnF.UseVisualStyleBackColor = true;
            this.rdbtnF.CheckedChanged += new System.EventHandler(this.rdbtnF_CheckedChanged);
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(35, 148);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(407, 169);
            this.dv.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(254, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(254, 91);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(367, 91);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 370);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.rdbtnF);
            this.Controls.Add(this.rdbtnM);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.txtTNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTNo;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.RadioButton rdbtnM;
        private System.Windows.Forms.RadioButton rdbtnF;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnUpdate;
    }
}