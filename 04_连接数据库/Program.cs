using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_连接数据库
{
    class Program
    {
        static void Main(string[] args)
        {
            //编辑SQL Server数据库连接字符串
            string conString = @"Server=DESKTOP-CTV4ATU\SQLSERVER;DataBase=TEST_06;Uid=sa;pwd=123456";
            //创建连接对象
            SqlConnection conn = new SqlConnection(conString);
            //打开数据库
            conn.Open();
            //判断是否打开数据库
            if (conn.State==System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Connection is opened!");
            }
            //关闭连接
            conn.Close();
            //判断是否关闭数据库
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                Console.WriteLine("Connection is Closed!");
            }
            Console.ReadKey();
        }
    }
}
