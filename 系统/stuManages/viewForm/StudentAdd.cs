using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//调用Mysql的连接

namespace stuManages.viewForm
{
    public partial class StudentAdd : Form
    {

        #region 变量
        private DbUtil dbUtil = new DbUtil();
        DataSet dr = new DataSet();    //新建课程集合
        public int commodityID = 0;    //commodityID = 0添加，否则修改
        #endregion

        #region 构造函数
        public StudentAdd()
        {
            InitializeComponent();
        } 
        #endregion

        #region 事件

        #region 重置单击事件
        private void reset_Click(object sender, EventArgs e)
        {
            SetNull();
        }
        #endregion

        #region 添加学生单击事件
        private void add_Click(object sender, EventArgs e)
        {
            //判断表单是否满足输入条件
            if (checkInput())
            {
                //判断是修改还是添加
                if (commodityID == 0)
                {
                    AddStudent();
                }
                else
                {
                    EditStudent();
                }
            }
        }
        #endregion

        #region 窗体加载事件
        private void StudentAdd_Load(object sender, EventArgs e)
        {
            if (commodityID == 0)
            {
                SetComboCourse();//初始化课程信息
            }
            else
            {
                //初始化表单数据
                this.setStuById();
                this.add.Text = "修改"; //添加按钮的文本改成修改
            }
        }
        #endregion

        #endregion

        #region 方法

        #region 表单置空方法
        private void SetNull()
        {
            //输入框置空
            stu_id.Text = "";
            stu_name.Text = "";
            stu_course.Text = "";
            stu_major.Text = "";
            stu_age.Text = "";
            stu_class.Text = "";
        }

        #endregion

        #region 初始化课程信息下拉列表
        private void SetComboCourse()
        {
            try
            {
                //select * from t_course;
                string sql = string.Format(@"select * from t_course");
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, dbUtil.Connection);
                adapter.Fill(dr, "Comminty");
                this.stu_course.DataSource = dr.Tables["Comminty"];  
                this.stu_course.ValueMember = "cid";       //用于修改
                this.stu_course.DisplayMember = "cname";   //显示课程名称
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 验证表单是否满足条件
        private bool checkInput()
        {
            //验证学生学号是否为空
            if (stu_id.Text.Trim().Length == 0)
            {
                MessageBox.Show("学生学号不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //验证学生姓名是否为空
            if (stu_name.Text == "")
            {
                MessageBox.Show("学生姓名不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //验证学生专业是否为空
            if (stu_major.Text == "")
            {
                MessageBox.Show("学生专业不能为空", "系统提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        #endregion

        #region 添加学生方法
        private void AddStudent()
        {
            string sex = radio_boy.Checked ? "男" : "女";
            int result = MysqlUtil.DoInsert("t_students",
                new string[] { "sid", "sname", "sex", "age", "major", "cid", "class_id" },
                new object[] { stu_id.Text.Trim(), stu_name.Text.Trim(), sex, Convert.ToInt32(stu_age.Text.Trim()), stu_major.Text.Trim(), stu_course.SelectedValue, Convert.ToInt32(stu_class.Text.Trim()) }
                );
            if (result == 1)
            {
                MessageBox.Show("添加成功", "系统提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                //添加成功后置空表单
                this.SetNull();
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败", "系统提示",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 修改学生的时候初始化表单数据
        private void setStuById()  
        {
            //初始化课程信息下拉列表
            SetComboCourse();
            string sql = string.Format("select * from t_students where sid={0}", commodityID);
            DataRow reader = MysqlUtil.GetDataRow(sql); 
            this.stu_id.Text = reader["sid"].ToString();
            this.stu_name.Text = reader["sname"].ToString();
            //判断性别单选框是否选中
            if (reader["sex"].ToString() == "男")
            {
                this.radio_boy.Checked = true;
            }
            else
            {
                this.radio_girl.Checked = true;
            }
            this.stu_major.Text = reader["major"].ToString();
            this.stu_age.Value = Convert.ToDecimal(reader["age"]);  //18
            this.stu_course.SelectedValue = reader["cid"].ToString();
            this.stu_class.Value = Convert.ToDecimal(reader["class_id"]);
        }
        #endregion

        #region 修改学生信息方法
        private void EditStudent()
        {
            string sex = radio_boy.Checked ? "男" : "女";
            int result = MysqlUtil.DoUpdate("t_students",
                new string[] { "sid", "sname", "sex", "age", "major", "cid", "class_id" },
                new object[] { stu_id.Text.Trim(), stu_name.Text.Trim(), sex, Convert.ToInt32(stu_age.Text.Trim()), stu_major.Text.Trim(), stu_course.SelectedValue, Convert.ToInt32(stu_class.Text.Trim()) },
                new string[] {"sid"},
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
