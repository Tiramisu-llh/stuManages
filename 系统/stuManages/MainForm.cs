using stuManages.model;
using System;
using System.Windows.Forms;

namespace stuManages
{
    public partial class MainForm : Form
    {
        #region 变量
        public User user;
        #endregion

        #region 构造函数
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件

        #region 查看学生列表信息事件
        private void StuListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.StuManage stuM = new viewForm.StuManage();
            stuM.ShowDialog();
        }
        #endregion

        #region 学生列表单击事件
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            viewForm.StuManage stuM = new viewForm.StuManage();
            stuM.ShowDialog();
        }
        #endregion

        #region 退出系统单击事件
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出系统吗？", "系统提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit(); //退出系统
            }
        }
        #endregion

        #region 退出系统单击事件
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出系统吗？", "系统提示",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit(); //退出系统
            }
        }
        #endregion

        #region 退出系统单击事件
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        } 
        #endregion

        #region 修改密码单击事件
        private void PawEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.EditPsw edit = new viewForm.EditPsw();
            edit.user = this.user;
            edit.ShowDialog();
        }



        #endregion

        #region 添加学生单击事件
        private void AddStuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.StudentAdd StuAdd = new viewForm.StudentAdd();
            StuAdd.commodityID = 0;
            StuAdd.ShowDialog();
        }

        #endregion

        #region 课程查看单击事件
        private void CourseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.CourseManage courseManage = new viewForm.CourseManage();
            courseManage.ShowDialog();
        }

        #endregion

        #region 课程查看单击事件
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            viewForm.CourseManage courseManage = new viewForm.CourseManage();
            courseManage.ShowDialog();
        }
        #endregion

        #region 课程添加单击事件
        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.CourseAdd courseAdd = new viewForm.CourseAdd();
            courseAdd.ShowDialog();
            courseAdd.commodityID = 0;
        }

        #endregion

        #region 帮助单击事件
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewForm.About about= new viewForm.About();
            about.ShowDialog();
        }

        #endregion

        #endregion

    }
}
