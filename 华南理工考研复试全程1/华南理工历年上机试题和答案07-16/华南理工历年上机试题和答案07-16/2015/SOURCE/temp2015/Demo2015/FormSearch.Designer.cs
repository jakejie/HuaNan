namespace Demo2015
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
            this.cboEmpNo = new System.Windows.Forms.ComboBox();
            this.cboEmpName = new System.Windows.Forms.ComboBox();
            this.dv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工名:";
            // 
            // cboEmpNo
            // 
            this.cboEmpNo.FormattingEnabled = true;
            this.cboEmpNo.Location = new System.Drawing.Point(212, 48);
            this.cboEmpNo.Name = "cboEmpNo";
            this.cboEmpNo.Size = new System.Drawing.Size(121, 20);
            this.cboEmpNo.TabIndex = 2;
            this.cboEmpNo.SelectedIndexChanged += new System.EventHandler(this.cboEmpNo_SelectedIndexChanged);
            // 
            // cboEmpName
            // 
            this.cboEmpName.FormattingEnabled = true;
            this.cboEmpName.Location = new System.Drawing.Point(212, 90);
            this.cboEmpName.Name = "cboEmpName";
            this.cboEmpName.Size = new System.Drawing.Size(121, 20);
            this.cboEmpName.TabIndex = 3;
            this.cboEmpName.SelectedIndexChanged += new System.EventHandler(this.cboEmpName_SelectedIndexChanged);
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(40, 161);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(363, 150);
            this.dv.TabIndex = 4;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 361);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.cboEmpName);
            this.Controls.Add(this.cboEmpNo);
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
        private System.Windows.Forms.ComboBox cboEmpNo;
        private System.Windows.Forms.ComboBox cboEmpName;
        private System.Windows.Forms.DataGridView dv;
    }
}