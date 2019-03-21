namespace Demo2013
{
    partial class FormStatistics
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
            this.btnSS1 = new System.Windows.Forms.Button();
            this.dv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSS1
            // 
            this.btnSS1.Location = new System.Drawing.Point(71, 50);
            this.btnSS1.Name = "btnSS1";
            this.btnSS1.Size = new System.Drawing.Size(281, 23);
            this.btnSS1.TabIndex = 0;
            this.btnSS1.Text = "统计上2门以上课的老师的新明和课程名";
            this.btnSS1.UseVisualStyleBackColor = true;
            this.btnSS1.Click += new System.EventHandler(this.btnSS1_Click);
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(50, 105);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(322, 150);
            this.dv.TabIndex = 1;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 334);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.btnSS1);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSS1;
        private System.Windows.Forms.DataGridView dv;
    }
}