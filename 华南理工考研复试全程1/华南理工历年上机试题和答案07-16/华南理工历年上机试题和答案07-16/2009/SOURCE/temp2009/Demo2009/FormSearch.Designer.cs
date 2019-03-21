namespace Demo2009
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
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btbnS1 = new System.Windows.Forms.Button();
            this.btnS2 = new System.Windows.Forms.Button();
            this.dv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "供应商名称：";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(135, 10);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(121, 21);
            this.txtOrderID.TabIndex = 2;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(135, 56);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(121, 21);
            this.txtSupplierName.TabIndex = 3;
            // 
            // btbnS1
            // 
            this.btbnS1.Location = new System.Drawing.Point(316, 8);
            this.btbnS1.Name = "btbnS1";
            this.btbnS1.Size = new System.Drawing.Size(75, 23);
            this.btbnS1.TabIndex = 4;
            this.btbnS1.Text = "查询1";
            this.btbnS1.UseVisualStyleBackColor = true;
            this.btbnS1.Click += new System.EventHandler(this.btbnS1_Click);
            // 
            // btnS2
            // 
            this.btnS2.Location = new System.Drawing.Point(316, 54);
            this.btnS2.Name = "btnS2";
            this.btnS2.Size = new System.Drawing.Size(75, 23);
            this.btnS2.TabIndex = 5;
            this.btnS2.Text = "查询2";
            this.btnS2.UseVisualStyleBackColor = true;
            this.btnS2.Click += new System.EventHandler(this.btnS2_Click);
            // 
            // dv
            // 
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv.Location = new System.Drawing.Point(43, 124);
            this.dv.Name = "dv";
            this.dv.RowTemplate.Height = 23;
            this.dv.Size = new System.Drawing.Size(348, 150);
            this.dv.TabIndex = 6;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 297);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.btnS2);
            this.Controls.Add(this.btbnS1);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btbnS1;
        private System.Windows.Forms.Button btnS2;
        private System.Windows.Forms.DataGridView dv;
    }
}