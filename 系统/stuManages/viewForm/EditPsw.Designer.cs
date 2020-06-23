namespace stuManages.viewForm
{
    partial class EditPsw
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
            this.old_password = new System.Windows.Forms.TextBox();
            this.new_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirm_psw = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Image = global::stuManages.Properties.Resources.paw;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(78, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "   原始密码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // old_password
            // 
            this.old_password.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.old_password.Font = new System.Drawing.Font("宋体", 12F);
            this.old_password.Location = new System.Drawing.Point(212, 49);
            this.old_password.Name = "old_password";
            this.old_password.PasswordChar = '*';
            this.old_password.Size = new System.Drawing.Size(139, 26);
            this.old_password.TabIndex = 1;
            // 
            // new_password
            // 
            this.new_password.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.new_password.Font = new System.Drawing.Font("宋体", 12F);
            this.new_password.Location = new System.Drawing.Point(212, 126);
            this.new_password.Name = "new_password";
            this.new_password.PasswordChar = '*';
            this.new_password.Size = new System.Drawing.Size(139, 26);
            this.new_password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Image = global::stuManages.Properties.Resources.psw;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(78, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "   新的密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Image = global::stuManages.Properties.Resources._checked;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(78, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "   确认密码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirm_psw
            // 
            this.confirm_psw.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.confirm_psw.Font = new System.Drawing.Font("宋体", 12F);
            this.confirm_psw.Location = new System.Drawing.Point(212, 210);
            this.confirm_psw.Name = "confirm_psw";
            this.confirm_psw.PasswordChar = '*';
            this.confirm_psw.Size = new System.Drawing.Size(139, 26);
            this.confirm_psw.TabIndex = 3;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.edit.Font = new System.Drawing.Font("宋体", 12F);
            this.edit.Image = global::stuManages.Properties.Resources.edit;
            this.edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit.Location = new System.Drawing.Point(111, 281);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(68, 31);
            this.edit.TabIndex = 4;
            this.edit.Text = "修改";
            this.edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.back.Font = new System.Drawing.Font("宋体", 12F);
            this.back.Image = global::stuManages.Properties.Resources.back;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(245, 281);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(68, 31);
            this.back.TabIndex = 5;
            this.back.Text = "返回";
            this.back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditPsw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::stuManages.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(422, 371);
            this.Controls.Add(this.back);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.confirm_psw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.old_password);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditPsw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox old_password;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirm_psw;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button back;
    }
}