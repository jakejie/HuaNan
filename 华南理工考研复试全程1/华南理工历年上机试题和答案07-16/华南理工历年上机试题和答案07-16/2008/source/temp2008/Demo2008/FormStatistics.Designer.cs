namespace Demo2008
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
            this.dv = new System.Windows.Forms.DataGridView();
            this.btnS2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(59, 30);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(129, 23);
            this.btnS1.TabIndex = 0;
            this.btnS1.Text = "统计1";
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // dv
            // 
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(59, 85);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(416, 201);
            this.dv.TabIndex = 1;
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(324, 30);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(151, 23);
            this.btnS2.TabIndex = 2;
            this.btnS2.Text = "统计2";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 319);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.btnS1);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.DataGridView dv;
        private System.Windows.Forms.Button btnS2;
    }
}