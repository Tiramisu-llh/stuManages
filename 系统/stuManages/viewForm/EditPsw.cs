using stuManages.model;
using System;
using System.Windows.Forms;

namespace stuManages.viewForm
{
    public partial class EditPsw : Form
    {
        #region 变量
        public User user;
        #endregion

        #region 构造函数
        public EditPsw()
        {
            InitializeComponent();
        } 
        #endregion

        #region 事件

        #region 返回单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 修改密码单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                EditPassword();
            }
        }
        #endregion

        #endregion

        #region 方法

        #region 表单验证
        private bool CheckInput()
        {
            //MessageBox.Show(user.Id + user.Password);
            //判断原始密码输入框是否为空
            if (old_password.Text.Trim().Length == 0)
            {
                MessageBox.Show("原始密码不能为空。", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //判断原始密码是否是用户密码
            if (old_password.Text.Trim() != user.Password) 
            {
                /*MessageBox.Show(old_password.Text.Trim());
                MessageBox.Show(user.Password);*/
                MessageBox.Show("原始密码输入错误。", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //判断新密码是否为空
            if (new_password.Text.Trim().Length == 0)
            {
                MessageBox.Show("新密码不能为空。", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //判断确认密码是否为空
            if (confirm_psw.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入确认密码。", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //判断两次密码是否相同
            if (confirm_psw.Text.Trim() != new_password.Text.Trim())
            {
                MessageBox.Show("两次输入密码不一致。", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion

        #region 修改密码单击事件
        private void EditPassword()
        {
            int  result = MysqlUtil.DoUpdate(
                "t_user",
                new string[] { "password" },
                new object[] { new_password.Text.Trim() },
                new string[] { "id" },
                new object[] { user.Id }
            ); 
            if (result == 1)
            {
                MessageBox.Show("修改成功", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败。", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #endregion

    }
}
