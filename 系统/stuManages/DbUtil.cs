using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;//调用Mysql的连接

namespace stuManages
{
    class DbUtil
    {
        private static string dbUrl = @"Database=studentsmanage;Data Source=127.0.0.1;User Id=root;Password=root;pooling=false;CharSet=utf8;port=3306";
        private MySqlConnection connection; //重构数据库连接，可右击快速生成构造函数

        //public DbUtil(MySqlConnection connection)
        //{
        //   this.connection = connection;
        //}
        public MySqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(dbUrl);
                }
                return connection;
            }
        }
        //打开数据库连接
        public void OpenConnection()
        {
            //判断是否为关闭状态
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            //如果出现异常就关闭再打开
            else if(Connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
        }
        //关闭数据库
        public void CloseConnection()
        {
            //判断是否是打开状态或者出现异常
            if (Connection.State == System.Data.ConnectionState.Open || Connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
            }
        }
    }
}