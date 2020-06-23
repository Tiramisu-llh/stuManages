namespace stuManages.viewForm
{
    partial class CourseAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.c_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_marke = new System.Windows.Forms.TextBox();
            this.c_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.c_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(88, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "课程名称：";
            // 
            // c_name
            // 
            this.c_name.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.c_name.Font = new System.Drawing.Font("宋体", 12F);
            this.c_name.Location = new System.Drawing.Point(200, 103);
            this.c_name.Name = "c_name";
            this.c_name.Size = new System.Drawing.Size(146, 26);
            this.c_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(88, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "课程介绍：";
            // 
            // c_marke
            // 
            this.c_marke.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.c_marke.Font = new System.Drawing.Font("宋体", 12F);
            this.c_marke.Location = new System.Drawing.Point(200, 157);
            this.c_marke.Name = "c_marke";
            this.c_marke.Size = new System.Drawing.Size(146, 26);
            this.c_marke.TabIndex = 3;
            // 
            // c_add
            // 
            this.c_add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.c_add.Font = new System.Drawing.Font("宋体", 12F);
            this.c_add.Image = global::stuManages.Properties.Resources.addto;
            this.c_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.c_add.Location = new System.Drawing.Point(106, 242);
            this.c_add.Name = "c_add";
            this.c_add.Size = new System.Drawing.Size(70, 30);
            this.c_add.TabIndex = 4;
            this.c_add.Text = "添加";
            this.c_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.c_add.UseVisualStyleBackColor = false;
            this.c_add.Click += new System.EventHandler(this.c_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "课程编号：";
            // 
            // c_id
            // 
            this.c_id.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.c_id.Font = new System.Drawing.Font("宋体", 12F);
            this.c_id.Location = new System.Drawing.Point(200, 53);
            this.c_id.Name = "c_id";
            this.c_id.Size = new System.Drawing.Size(146, 26);
            this.c_id.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Image = global::stuManages.Properties.Resources.back;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(241, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "重置";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuManages.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(428, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_add);
            this.Controls.Add(this.c_marke);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.c_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_name);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CourseAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "课程添加或修改";
            this.Load += new System.EventHandler(this.CourseAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox c_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox c_marke;
        private System.Windows.Forms.Button c_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c_id;
    }
}