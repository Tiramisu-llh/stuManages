namespace stuManages.viewForm
{
    partial class StuManage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.s_course = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.s_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.s_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::stuManages.Properties.Resources.bg2;
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.s_course);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.s_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.s_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.search.Font = new System.Drawing.Font("宋体", 12F);
            this.search.Image = global::stuManages.Properties.Resources.search__2_;
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(761, 37);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(69, 31);
            this.search.TabIndex = 3;
            this.search.Text = "查询";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // s_course
            // 
            this.s_course.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.s_course.Font = new System.Drawing.Font("宋体", 12F);
            this.s_course.FormattingEnabled = true;
            this.s_course.Location = new System.Drawing.Point(602, 40);
            this.s_course.Name = "s_course";
            this.s_course.Size = new System.Drawing.Size(123, 24);
            this.s_course.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(508, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "学生课程：";
            // 
            // s_name
            // 
            this.s_name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.s_name.Font = new System.Drawing.Font("宋体", 12F);
            this.s_name.Location = new System.Drawing.Point(364, 38);
            this.s_name.Name = "s_name";
            this.s_name.Size = new System.Drawing.Size(114, 26);
            this.s_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(270, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "学生姓名：";
            // 
            // s_id
            // 
            this.s_id.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.s_id.Font = new System.Drawing.Font("宋体", 12F);
            this.s_id.Location = new System.Drawing.Point(116, 38);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(118, 26);
            this.s_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "学生学号：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.Location = new System.Drawing.Point(75, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(703, 281);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.delete.Font = new System.Drawing.Font("宋体", 12F);
            this.delete.Image = global::stuManages.Properties.Resources.delete__2_;
            this.delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete.Location = new System.Drawing.Point(513, 504);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(68, 31);
            this.delete.TabIndex = 3;
            this.delete.Text = "删除";
            this.delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 12F);
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-149, 919);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "搜索";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.edit.Font = new System.Drawing.Font("宋体", 12F);
            this.edit.Image = global::stuManages.Properties.Resources.edit;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(267, 504);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(68, 31);
            this.edit.TabIndex = 3;
            this.edit.Text = "修改";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // StuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuManages.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(869, 580);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StuManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息维护";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox s_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox s_course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox s_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button delete;
    }
}