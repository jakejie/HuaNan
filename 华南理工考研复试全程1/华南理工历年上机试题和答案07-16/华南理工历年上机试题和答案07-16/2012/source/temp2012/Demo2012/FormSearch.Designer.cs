namespace Demo2012
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.btnS1 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工姓名：";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(120, 30);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(130, 21);
            this.txtEmpName.TabIndex = 1;
            // 
            // btnS1
            // 
            this.btnS1.Location = new System.Drawing.Point(302, 28);
            this.btnS1.Name = "btnS1";
            this.btnS1.Size = new System.Drawing.Size(75, 23);
            this.btnS1.TabIndex = 2;
            this.btnS1.Text = "查询1";
            this.btnS1.UseVisualStyleBackColor = true;
            this.btnS1.Click += new System.EventHandler(this.btnS1_Click);
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(302, 72);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(75, 23);
            this.btnS2.TabIndex = 5;
            this.btnS2.Text = "查询2";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(120, 74);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(130, 21);
            this.txtCName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "公司名称：";
            // 
            // dv
            // 
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(35, 134);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(342, 150);
            this.dv.TabIndex = 6;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 312);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnS1);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label1);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Button btnS1;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dv;
    }
}