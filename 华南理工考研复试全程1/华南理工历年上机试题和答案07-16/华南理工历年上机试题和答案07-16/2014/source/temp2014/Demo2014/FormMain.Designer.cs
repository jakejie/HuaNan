namespace Demo2014
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.教师表维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查询ToolStripMenuItem,
            this.信息统计ToolStripMenuItem,
            this.信息维护ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            this.信息查询ToolStripMenuItem.Click += new System.EventHandler(this.信息查询ToolStripMenuItem_Click);
            // 
            // 信息统计ToolStripMenuItem
            // 
            this.信息统计ToolStripMenuItem.Name = "信息统计ToolStripMenuItem";
            this.信息统计ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息统计ToolStripMenuItem.Text = "信息统计";
            this.信息统计ToolStripMenuItem.Click += new System.EventHandler(this.信息统计ToolStripMenuItem_Click);
            // 
            // 信息维护ToolStripMenuItem
            // 
            this.信息维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.教师表维护ToolStripMenuItem});
            this.信息维护ToolStripMenuItem.Name = "信息维护ToolStripMenuItem";
            this.信息维护ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.信息维护ToolStripMenuItem.Text = "信息维护";
            // 
            // 教师表维护ToolStripMenuItem
            // 
            this.教师表维护ToolStripMenuItem.Name = "教师表维护ToolStripMenuItem";
            this.教师表维护ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.教师表维护ToolStripMenuItem.Text = "教师表维护";
            this.教师表维护ToolStripMenuItem.Click += new System.EventHandler(this.教师表维护ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 344);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 教师表维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
    }
}