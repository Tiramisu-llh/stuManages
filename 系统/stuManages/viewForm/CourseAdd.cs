using System;
using System.Data;
using System.Windows.Forms;

namespace stuManages.viewForm
{
    public partial class CourseAdd : Form
    {

        #region 变量
        public int commodityID = 0;  //commodityID = 0添加，否则修改 
        #endregion

        #region 构造函数
        public CourseAdd()
        {
            InitializeComponent();
        } 
        #endregion

        #region 事件

        #region 重置单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            setNull();
        }
        #endregion

        #region 添加单击事件
        private void c_add_Click(object sender, EventArgs e)
        {
            //判断表单是否满足条件
            if (checkInput())
            {
                //判断是修改还是添加
                if (commodityID == 0)
                {
                    AddCourse();
                }
                else
                {
                    EditCourse();
                }
            }
            
        }
        #endregion

        #region 窗体加载事件
        private void CourseAdd_Load(object sender, EventArgs e)
        {
            if (commodityID != 0)
            {
                this.setCourseById();
                this.c_add.Text = "修改";
            }
        }
        #endregion

        #endregion

        #region 方法

        #region 重置方法
        private void setNull()
        {
            c_id.Text = "";
            c_marke.Text = "";
            c_name.Text = "";
        }
        #endregion

        #region 验证表单方法
        private bool checkInput()
        {
            //验证课程编号是否为空
            if (c_id.Text.Trim().Length == 0)
            {
                MessageBox.Show("课程编号不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //验证课程名称是否为空
            if (c_name.Text.Trim().Length == 0)
            {
                MessageBox.Show("课程名称不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //验证课程介绍是否为空
            if (c_marke.Text == "")
            {
                MessageBox.Show("课程介绍不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;

        }
        #endregion

        #region 添加课程方法
        private void AddCourse()
        {
            int result = MysqlUtil.DoInsert("t_course",
                new string[] { "cid", "cname", "remake" },
                new object[] { c_id.Text.Trim(), c_name.Text.Trim(), c_marke.Text.Trim() }
                );
            if (result == 1)
            {
                MessageBox.Show("添加成功", "系统提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //添加成功后置空表单
                this.setNull();
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败", "系统提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 初始化窗体
        private void setCourseById()
        {
            string sql = string.Format("select * from t_course where id={0}", commodityID);
            DataRow reader = MysqlUtil.GetDataRow(sql);
            this.c_id.Text = reader["cid"].ToString();
            this.c_name.Text = reader["cname"].ToString();
            this.c_marke.Text = reader["remake"].ToString();
        }
        #endregion

        #region 修改课程方法
        private void EditCourse()
        {
            int result = MysqlUtil.DoUpdate("t_course",
                new string[] { "cid", "cname", "remake" },
                new object[] { c_id.Text.Trim(), c_name.Text.Trim(), c_marke.Text.Trim() },
                new string[] { "id" },
                new object[] { this.commodityID }
                );
                if (result == 1)
                {
                    MessageBox.Show("修改成功", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //添加成功后置空表单
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        #endregion

        #endregion
    }
}
