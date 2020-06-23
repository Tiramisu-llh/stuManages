using stuManages.model;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace stuManages
{
    public partial class LoginForm : Form
    {
        #region 变量
        public User user;
        #endregion

        #region 构造函数
        public LoginForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件

        #region 重置单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            setFormNull();
        }
        #endregion

        #region 登录单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            if (Login() != null)
            {
                timer.Start();
                username.Visible = false;
                password.Visible = false;
                text_username.Visible = false;
                text_password.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            } else
            {
                MessageBox.Show("用户名或密码错误", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 定时器事件
        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X < 300)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
            }
            else
            {
                timer.Stop();
                MainForm mainForm = new MainForm();
                //传user
                mainForm.user = user;
                //MessageBox.Show(user.Id + user.Password);
                mainForm.Show();
                this.Hide();
            }
        }
        #endregion

        #endregion

        #region 方法

        #region 置空方法
        private void setFormNull()
        {
            text_username.Text = "";
            text_password.Text = "";
        }
        #endregion

        #region 登录方法
        private User Login()
        {
            if (text_username.Text.Trim().Length == 0)
            {
                MessageBox.Show("用户名不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            //验证密码是否为空
            if (text_password.Text == "")
            {
                MessageBox.Show("密码不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            string sql = string.Format("select * from t_user where username='{0}' and password='{1}'",
                        text_username.Text.Trim(), text_password.Text.Trim());
            DataRow dr = MysqlUtil.GetDataRow(sql);
            if (dr != null)  //用户数据存在
            {
                user = new User();
                user.Id = int.Parse(dr["id"] + "");
                user.Username = dr["username"] + "";
                user.Password = dr["password"] + "";
            }
            return user; 
        }
        #endregion

        #endregion
    }
}