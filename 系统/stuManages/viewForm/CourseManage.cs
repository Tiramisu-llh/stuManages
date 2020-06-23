using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//调用Mysql的连接

namespace stuManages.viewForm
{
    public partial class CourseManage : Form
    {
        #region 变量
        private DbUtil dbUtil = new DbUtil();
        DataSet dr = new DataSet();    //新建课程集合
        #endregion

        #region 构造函数
        public CourseManage()
        {
            InitializeComponent();
        } 
        #endregion

        #region 事件

        #region 窗体记载事件
        private void CourseManage_Load(object sender, EventArgs e)
        {
            SetDataCourse();
        }
        #endregion

        #region 删除单击事件
        private void button2_Click(object sender, EventArgs e)
        {
            DeleteCourse();
        }
        #endregion

        #region 搜索单击事件
        private void button1_Click(object sender, EventArgs e)
        {
            SetDataCourse();
        }
        #endregion

        #region 修改单击事件
        private void button3_Click(object sender, EventArgs e)
        {
            viewForm.CourseAdd courseAdd = new viewForm.CourseAdd();
            courseAdd.commodityID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);  //数据格式不符
            courseAdd.ShowDialog();
            //当修改完课程信息时要关闭窗口同时刷新表格
            this.SetDataCourse();//刷新表格
        }
        #endregion

        #endregion

        #region 方法

        #region 初始化表单数据
        private void SetDataCourse()
        {
            dr = new DataSet();//重新new就是把dataset数据清空了
            //select cid as "课程编号",cname as "课程名称",remake as "说明" from t_course;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("select id as '编号',cid as '课程编号',cname as '课程名称',remake as '说明' from t_course");

            //搜索条件
            if (c_name.Text.Trim().Length != 0)
            {
                sb.AppendFormat(" where cname like '%{0}%' ", c_name.Text.Trim());
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

        #region 删除课程方法
        private void DeleteCourse()
        {
            if (this.dataGridView1.CurrentRow != null)
            {
                DialogResult dr = MessageBox.Show("确定要删除课程名称为 " + dataGridView1.CurrentRow.Cells[2].Value + " 的课程信息吗？", "系统提示",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        string sql = string.Format(" delete from t_course where id={0}", dataGridView1.CurrentRow.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(sql, dbUtil.Connection);
                        dbUtil.OpenConnection();
                        int result = cmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //删除成功重新加载数据
                            this.SetDataCourse();
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
