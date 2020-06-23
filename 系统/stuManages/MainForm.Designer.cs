namespace stuManages
{
    partial class MainForm
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
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PawEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StuManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StuListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddStuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CourseListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.BackgroundImage = global::stuManages.Properties.Resources.bg2;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.StuManageToolStripMenuItem,
            this.CourseMToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.AutoSize = false;
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PawEditToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.SettingsToolStripMenuItem.Image = global::stuManages.Properties.Resources.setting__2_;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.SettingsToolStripMenuItem.Text = "系统设置";
            // 
            // PawEditToolStripMenuItem
            // 
            this.PawEditToolStripMenuItem.Image = global::stuManages.Properties.Resources.paw;
            this.PawEditToolStripMenuItem.Name = "PawEditToolStripMenuItem";
            this.PawEditToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.PawEditToolStripMenuItem.Text = "修改密码";
            this.PawEditToolStripMenuItem.Click += new System.EventHandler(this.PawEditToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::stuManages.Properties.Resources.exit;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ExitToolStripMenuItem.Text = "退出系统";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // StuManageToolStripMenuItem
            // 
            this.StuManageToolStripMenuItem.AutoSize = false;
            this.StuManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StuListToolStripMenuItem,
            this.AddStuToolStripMenuItem});
            this.StuManageToolStripMenuItem.Image = global::stuManages.Properties.Resources.manage__2_;
            this.StuManageToolStripMenuItem.Name = "StuManageToolStripMenuItem";
            this.StuManageToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.StuManageToolStripMenuItem.Text = "学生管理";
            // 
            // StuListToolStripMenuItem
            // 
            this.StuListToolStripMenuItem.Image = global::stuManages.Properties.Resources.menu;
            this.StuListToolStripMenuItem.Name = "StuListToolStripMenuItem";
            this.StuListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StuListToolStripMenuItem.Text = "学生信息维护";
            this.StuListToolStripMenuItem.Click += new System.EventHandler(this.StuListToolStripMenuItem_Click);
            // 
            // AddStuToolStripMenuItem
            // 
            this.AddStuToolStripMenuItem.Image = global::stuManages.Properties.Resources.addto;
            this.AddStuToolStripMenuItem.Name = "AddStuToolStripMenuItem";
            this.AddStuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddStuToolStripMenuItem.Text = "添加学生";
            this.AddStuToolStripMenuItem.Click += new System.EventHandler(this.AddStuToolStripMenuItem_Click);
            // 
            // CourseMToolStripMenuItem
            // 
            this.CourseMToolStripMenuItem.AutoSize = false;
            this.CourseMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CourseListToolStripMenuItem,
            this.AddCourseToolStripMenuItem});
            this.CourseMToolStripMenuItem.Image = global::stuManages.Properties.Resources.manage;
            this.CourseMToolStripMenuItem.Name = "CourseMToolStripMenuItem";
            this.CourseMToolStripMenuItem.Size = new System.Drawing.Size(122, 21);
            this.CourseMToolStripMenuItem.Text = "课程管理";
            // 
            // CourseListToolStripMenuItem
            // 
            this.CourseListToolStripMenuItem.Image = global::stuManages.Properties.Resources.menu;
            this.CourseListToolStripMenuItem.Name = "CourseListToolStripMenuItem";
            this.CourseListToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CourseListToolStripMenuItem.Text = "课程信息维护";
            this.CourseListToolStripMenuItem.Click += new System.EventHandler(this.CourseListToolStripMenuItem_Click);
            // 
            // AddCourseToolStripMenuItem
            // 
            this.AddCourseToolStripMenuItem.Image = global::stuManages.Properties.Resources.addto;
            this.AddCourseToolStripMenuItem.Name = "AddCourseToolStripMenuItem";
            this.AddCourseToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddCourseToolStripMenuItem.Text = "添加课程";
            this.AddCourseToolStripMenuItem.Click += new System.EventHandler(this.AddCourseToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.AutoSize = false;
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem});
            this.AboutToolStripMenuItem.Image = global::stuManages.Properties.Resources.个人;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.AboutToolStripMenuItem.Text = "关于我们";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Image = global::stuManages.Properties.Resources.help;
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.HelpToolStripMenuItem.Text = "帮助";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::stuManages.Properties.Resources.bg2;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::stuManages.Properties.Resources.menu;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton1.Text = "学生信息维护";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = global::stuManages.Properties.Resources.menu;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton2.Text = "课程信息维护";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Image = global::stuManages.Properties.Resources.exit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(100, 22);
            this.toolStripButton3.Text = "退出系统";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuManages.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(616, 425);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PawEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StuManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StuListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddStuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CourseMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CourseListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}