namespace Demo2011
{
    partial class FormDriver
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
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDUpdate = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(119, 152);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(135, 21);
            this.txtPwd.TabIndex = 52;
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(119, 43);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(135, 21);
            this.txtDName.TabIndex = 51;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(119, 67);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(135, 21);
            this.txtSex.TabIndex = 50;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(119, 125);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(135, 21);
            this.txtTel.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 48;
            this.label9.Text = "电话号码:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 47;
            this.label8.Text = "性别:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 46;
            this.label7.Text = "密码:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 45;
            this.label5.Text = "姓名:";
            // 
            // btnDUpdate
            // 
            this.btnDUpdate.Location = new System.Drawing.Point(32, 206);
            this.btnDUpdate.Name = "btnDUpdate";
            this.btnDUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnDUpdate.TabIndex = 44;
            this.btnDUpdate.Text = "修改";
            this.btnDUpdate.UseVisualStyleBackColor = true;
            this.btnDUpdate.Click += new System.EventHandler(this.btnDUpdate_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(119, 94);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(135, 21);
            this.txtAge.TabIndex = 39;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(119, 16);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(135, 21);
            this.txtEmpID.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "年龄:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 36;
            this.label4.Text = "员工号:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(179, 206);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 288);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDUpdate);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "FormDriver";
            this.Text = "FormDriver";
            this.Load += new System.EventHandler(this.FormDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDUpdate;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
    }
}