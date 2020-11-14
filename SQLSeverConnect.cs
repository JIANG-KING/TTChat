using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SqlSeverFrame
{
    class SQLSeverConnect
    {
            //从配置文件中获取连接字符串   readonly修饰的变量只能在初始化或构造函数中赋值；其他地方只能读取
        private static readonly string constr = "Server=yunking.database.windows.net;Database=LoginInfo;user id=jiangyun;pwd=Jy1019878449";
        SqlConnection sqlCnt = new SqlConnection(constr);
        public SqlDataAdapter SqlLogin(string username,string password)
        {
            sqlCnt.Open();
            SqlCommand com = new SqlCommand("select account,password from LoginInfo where account='" + username + "' and password='" + password + "'", sqlCnt);
            SqlDataAdapter da = new SqlDataAdapter(com);
            sqlCnt.Close();
            return da;
            
        }
        public SqlDataAdapter sqlDataReader()
        {
            sqlCnt.Open();
            SqlCommand com = new SqlCommand("select * from 个人信息表", sqlCnt);
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            return da;
        }
        public int sqlSearch(string Account)
        {
            sqlCnt.Open();
            SqlCommand str = new SqlCommand("select account from LoginInfo where account=" + Account,sqlCnt);
            SqlDataAdapter da = new SqlDataAdapter(str);
            DataSet ds = new DataSet();
            int a=da.Fill(ds, "LoginInfo");
            sqlCnt.Close();
            return a;
        }
        public int  sqlInsert(string Account, string Password,string image)
        {
            sqlCnt.Open();
            SqlCommand com = new SqlCommand("INSERT INTO [dbo].[LoginInfo] ([Account],[Password],[ImageHead]) VALUES (" + Account + "," + Password +","+"'"+image+"'"+ ")", sqlCnt);
            int result= com.ExecuteNonQuery();
            sqlCnt.Close();
            return result;
        }
        public string  SearchImage(string username)
        {
            sqlCnt.Open();
            SqlCommand com = new SqlCommand("select ImageHead from LoginInfo where Account="+username, sqlCnt);
            SqlDataReader dr;//创建DataReader对象
            dr = com.ExecuteReader();
            string s = "";
            if(dr.Read())
                s=dr["imagehead"].ToString().Substring(0,5);
            sqlCnt.Close();
            return s;
        }
    }
    }
