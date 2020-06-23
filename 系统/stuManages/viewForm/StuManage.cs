using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//调用Mysql的连接

namespace stuManages.viewForm
{
    public partial class StuManage : Form
    {

        #region 变量
        private DbUtil dbUtil = new DbUtil();
        DataSet dr = new DataSet();    //新建课程集合
        #endregion

        #region 构造函数
        public StuManage()
        {
            InitializeComponent();
            SetcombocClass();
            SetDataStaff();
        }
        #endregion

        #region 事件

        #region 窗体加载事件
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetcombocClass();
            SetDataStaff();
        }
        #endregion

        #region 查询单击事件
        private void search_Click(object sender, EventArgs e)
        {
            SetDataStaff();
        }
        #endregion

        #region 删除单击事件
        private void delete_Click(object sender, EventArgs e)
        {
            DeleteStu();
        }
        #endregion

        #region 修改单击事件
        private void edit_Click(object sender, EventArgs e)
        {
            viewForm.StudentAdd studentAdd = new StudentAdd();
            studentAdd.commodityID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            studentAdd.ShowDialog();
            //当修改完学生信息时要关闭窗口同时刷新表格
            this.SetDataStaff();//刷新表格
        }
        #endregion

        #endregion

        #region 方法

        #region 初始化表格学生数据
        private void SetDataStaff()
        {
            dr = new DataSet();
            //select u.sid as '学号',u.sname as '姓名',u.sex as '性别',u.age as '年龄',u.major as '专业',u.class_id as '班级' ,c.cname as '课程' from t_students as u ,t_course as c where u.cid=c.cid
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select u.sid as '学号',u.sname as '姓名',u.sex as '性别',u.age as '年龄',u.major as '专业',u.class_id as '班级' ,c.cname as '课程' from t_students as u ,t_course as c where u.cid=c.cid");

            //根据学生学号进行搜索
            if (s_id.Text.Trim().Length != 0)       //判断用户是否选中
            {
                sb.AppendFormat(" and u.sid like '%{0}%' ", s_id.Text.Trim());
            }
            //根据学生姓名进行搜索
            if (s_name.Text.Trim().Length != 0)     //判断用户是否选中
            {
                sb.AppendFormat(" and u.sname like '%{0}%' ", s_name.Text.Trim());
            }
            //根据课程名进行搜索
            if (s_course.Text.Trim().Length != 0)   //判断用户是否选中
            {
                sb.AppendFormat(" and c.cname like '{0}' ", s_course.Text.Trim());
            }
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter(sb.ToString(), dbUtil.Connection);
                adapter.Fill(dr, "Comminty");
                this.dataGridView1.DataSource = this.dr.Tables["Comminty"];
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 初始化表单中的课程信息
        private void SetcombocClass()
        {
            //select * from t_course;
            string sql = string.Format("select * from t_course");

            DataTable reader = MysqlUtil.GetDataTable(sql);             
            this.s_course.DataSource = reader; 
            this.s_course.ValueMember = "cid";       //用于修改
            this.s_course.DisplayMember = "cname";   //显示课程名称
            this.s_course.SelectedIndex = -1;   //便于搜索         
        }

        #endregion

        #region 删除学生方法
        private void DeleteStu()
        {
            //判断是否选中数据
            if (this.dataGridView1.CurrentRow != null)
            {
                //提示是否删除
                DialogResult dr = MessageBox.Show("确定要删除学号为 " + dataGridView1.CurrentRow.Cells[0].Value + " 的学生信息吗？", "系统提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                //如果选中是 则删除
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string sql = string.Format("delete from t_students where sid={0}",dataGridView1.CurrentRow.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(sql, dbUtil.Connection);
                        dbUtil.OpenConnection();
                        int result = cmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //删除成功重新加载数据
                            this.SetDataStaff();
                        }
                        else
                        {
                            MessageBox.Show("删除失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("数据库操作错误", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        dbUtil.CloseConnection();
                    }
                }
            }
        }

        #endregion

        #endregion
    }
}