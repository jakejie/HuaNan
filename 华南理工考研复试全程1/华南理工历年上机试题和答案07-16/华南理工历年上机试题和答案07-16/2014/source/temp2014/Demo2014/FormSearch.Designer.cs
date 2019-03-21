namespace Demo2014
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
            this.cboTNo = new System.Windows.Forms.ComboBox();
            this.cboTName = new System.Windows.Forms.ComboBox();
            this.dv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "教师号:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "教师名:";
            // 
            // cboTNo
            // 
            this.cboTNo.FormattingEnabled = true;
            this.cboTNo.Location = new System.Drawing.Point(140, 24);
            this.cboTNo.Name = "cboTNo";
            this.cboTNo.Size = new System.Drawing.Size(150, 20);
            this.cboTNo.TabIndex = 2;
            this.cboTNo.SelectedIndexChanged += new System.EventHandler(this.cboTNo_SelectedIndexChanged);
            // 
            // cboTName
            // 
            this.cboTName.FormattingEnabled = true;
            this.cboTName.Location = new System.Drawing.Point(140, 52);
            this.cboTName.Name = "cboTName";
            this.cboTName.Size = new System.Drawing.Size(150, 20);
            this.cboTName.TabIndex = 3;
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(50, 137);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(411, 150);
            this.dv.TabIndex = 4;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 317);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.cboTName);
            this.Controls.Add(this.cboTNo);
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
        private System.Windows.Forms.ComboBox cboTNo;
        private System.Windows.Forms.ComboBox cboTName;
        private System.Windows.Forms.DataGridView dv;
    }
}