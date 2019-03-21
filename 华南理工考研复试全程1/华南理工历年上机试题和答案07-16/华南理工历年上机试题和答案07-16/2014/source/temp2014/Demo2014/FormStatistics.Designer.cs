namespace Demo2014
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
            this.btnS1 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.dv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(142, 22);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(227, 23);
            this.btnS1.TabIndex = 0;
            this.btnS1.Text = "统计只上一门课的教师";
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(142, 61);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(227, 23);
            this.btnS2.TabIndex = 1;
            this.btnS2.Text = "统计每个教师的总薪酬";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(50, 105);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(402, 181);
            this.dv.TabIndex = 2;
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 325);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.btnS1);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.DataGridView dv;
    }
}