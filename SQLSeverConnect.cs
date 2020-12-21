
using System;
using System.Data;
using System.Data.SqlClient;
namespace TTChat
{
    class SQLSeverConnect
    {
        private static readonly string constr = "Server=yun2333.top;Database=Chattools;user id=jiangyun;pwd=Jy1019878449";
        SqlConnection sqlCnt = new SqlConnection(constr);
        /// <summary>
        /// 无需防止SQL注入的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlCommand Injection(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = sqlCnt;
            return command;
        }
        /// <summary>
        /// 防止sql注入
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="letter1">第一个传入的sql关键词</param>
        /// <returns></returns>
        public SqlCommand Injection(string sql, string letter1)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@letter1", letter1);
            command.Connection = sqlCnt;
            return command;
        }
        /// <summary>
        /// 双参数的
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <returns></returns>
        public SqlCommand Injection(string sql, string letter1, string letter2)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@letter1", letter1);
            command.Parameters.AddWithValue("@letter2", letter2);
            command.Connection = sqlCnt;
            return command;
        }
        /// <summary>
        /// 三参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <param name="letter3"></param>
        /// <returns></returns>
        public SqlCommand Injection(string sql, string letter1, string letter2, string letter3)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@letter1", letter1);
            command.Parameters.AddWithValue("@letter2", letter2);
            command.Parameters.AddWithValue("@letter3", letter3);
            command.Connection = sqlCnt;
            return command;
        }
        /// <summary>
        /// 四个参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <param name="letter3"></param>
        /// <param name="letter4"></param>
        /// <returns></returns>
        public SqlCommand Injection(string sql, string letter1, string letter2, string letter3, string letter4)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@letter1", letter1);
            command.Parameters.AddWithValue("@letter2", letter2);
            command.Parameters.AddWithValue("@letter3", letter3);
            command.Parameters.AddWithValue("@letter4", letter4);
            command.Connection = sqlCnt;
            return command;
        }
        /// <summary>
        /// 5个参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <param name="letter3"></param>
        /// <param name="letter4"></param>
        /// <param name="letter5"></param>
        /// <returns></returns>
        public SqlCommand Injection(string sql, string letter1, string letter2, string letter3, string letter4, string letter5)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@letter1", letter1);
            command.Parameters.AddWithValue("@letter2", letter2);
            command.Parameters.AddWithValue("@letter3", letter3);
            command.Parameters.AddWithValue("@letter4", letter4);
            command.Parameters.AddWithValue("@letter5", letter5);
            command.Connection = sqlCnt;
            return command;
        }
        /// <summary>
        /// 登录验证
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public SqlDataAdapter SqlLogin(string username, string password)
        {
            string strSQL = "select account,password from LoginInfo where account=@letter1 and password=@letter2";
            SqlCommand cmd = Injection(strSQL, username, password);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
        /// <summary>
        /// 查询指定用户是否存在
        /// </summary>
        /// <param name="Account"></param>
        /// <returns></returns>
        public int SqlSearch(string Account)
        {
            string s = "";
            int a = 0;

            sqlCnt.Open();

            string strSQL = "select Account from LoginInfo where Account=@letter1";
            SqlCommand cmd = Injection(strSQL, Account);
            SqlDataReader dr;

            dr = cmd.ExecuteReader();

            if (dr.Read())
                s = dr["Account"].ToString().Trim();
            dr.Close();
            sqlCnt.Close();
            if (s == Account) a = 1;
            return a;


        }
        public int SqlInsert(string Account, string Password, string image, string NickName)//插入一个用户，用户注册时使用
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "INSERT INTO [dbo].[LoginInfo] ([Account],[Password],[ImageHead],[NickName]) VALUES (@letter1,@letter2,@letter3,@letter4)";
                SqlCommand cmd = Injection(strSQL, Account, Password, image, NickName);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch
            {
                return 0;
            }

        }
        public string SearchImage(string username)//查找用户的头像
        {
            string s = "emty";
            try
            {
                sqlCnt.Open();
                string strSQL = "select ImageHead from LoginInfo where Account=@letter1";
                SqlCommand cmd = Injection(strSQL, username);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    s = dr["imagehead"].ToString().Trim();
                dr.Close();

                sqlCnt.Close();
                return s;
            }
            catch (System.Exception)
            {
                sqlCnt.Close();
                return "";
            }

        }
        public int UpdateUserInfo(string username, string imageHead, string NickName, string Signature)//更新用户的个人信息
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "UPDATE [dbo].[LoginInfo] SET [ImageHead] =@letter1 ,[NickName] = @letter2 ,[Signature] =@letter3 where Account=@letter4";
                SqlCommand cmd = Injection(strSQL, imageHead, NickName, Signature, username);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
        public int UpdateState(string username, string LoginState)//更新用户的状态，在线，隐身，忙碌，请勿打扰，q我吧
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "update LoginInfo set AccountState=@letter2  where Account=@letter1";
                SqlCommand cmd = Injection(strSQL, username, LoginState);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
        public string SearchUserState(string username)//查找用户的在线状态
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "select AccountState from LoginInfo where Account=@letter1";
                SqlCommand cmd = Injection(strSQL, username);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();
                string s = "";
                if (dr.Read())
                    s = dr["AccountState"].ToString().Trim();
                dr.Close();
                sqlCnt.Close();
                return s;
            }
            catch (System.Exception)
            {
                return "";
            }
        }
        public string SearchNickname(string username)//查找用户的昵称
        {
            string s = "";
            try
            {
                sqlCnt.Open();
                string strSQL = "select NickName from LoginInfo where Account=@letter1";
                SqlCommand cmd = Injection(strSQL, username);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    s = dr["NickName"].ToString().Trim();
                dr.Close();
                sqlCnt.Close();
                return s;
            }
            catch (System.Exception)
            {

                return s;
            }
        }
        public string Signature(string username)//查找用户的个性签名
        {
            string s = "";
            try
            {
                sqlCnt.Open();
                string strSQL = "select Signature from LoginInfo where Account=@letter1";
                SqlCommand cmd = Injection(strSQL, username);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                if (dr.Read())
                    s = dr["Signature"].ToString().Trim();
                dr.Close();
                sqlCnt.Close();
                return s;
            }
            catch (System.Exception)
            {

                return s;
            }
        }
        public int UpdateIsAlive(string username, string IsAlive)//修改用户的登录状态
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "update LoginInfo set IsAlive=@letter2 where Account=@letter1";
                SqlCommand cmd = Injection(strSQL, username, IsAlive);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        public int SearchIsAlive(string username)//查找用户是否已登录
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "select IsAlive from LoginInfo where Account=@letter1";
                SqlCommand cmd = Injection(strSQL, username);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();
                string s = "";
                if (dr.Read())
                    s = dr["IsALive"].ToString().Trim();
                dr.Close();
                sqlCnt.Close();
                int a = 0;
                int.TryParse(s, out a);
                return a;
            }
            catch (System.Exception)
            {

                return 2;
            }
        }
        public string[] SearchFriends(string username)//查找用户的好友
        {
            string[] User = new string[2000];
            try
            {
                sqlCnt.Open();
                string strSQL = "select Friends from Friends where UserName=@letter1";
                SqlCommand cmd = Injection(strSQL, username);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();
                int i = 0;
                while (dr.Read())
                {
                    User[i] = dr["Friends"].ToString().Trim();
                    i++;
                }
                dr.Close();
                sqlCnt.Close();
                return User;
            }
            catch (System.Exception)
            {

                return User;
            }
        }
        public int DeleteFriends(string sender, string receiver)//删除好友申请
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "delete from Friends where Username = @letter1 and friends=@letter2";
                SqlCommand cmd = Injection(strSQL, sender, receiver);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        public int IsFriends(string username, string friends)//查找是否已经是用户好友
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "select Friends from Friends where UserName=@letter1 and friends=@letter2";
                SqlCommand cmd = Injection(strSQL, username, friends);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                int result = da.Fill(ds, "LoginInfo");
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 1;
            }
        }
        public string[] SearchMessage(string username, string Receiver)//查找用户收到的消息，最近的十条
        {
            string[] User = new string[10];
            try
            {
                sqlCnt.Open();
                string strSQL = "SELECT top(10)  [Message] FROM [Chattools].[dbo].[MeassageBox] where Sender=@letter1 And Receiver=@letter2 ORDER by SerialNumber deSC ";
                SqlCommand cmd = Injection(strSQL, username, Receiver);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                int i = 0;
                while (dr.Read())
                {
                    User[i] = dr["Message"].ToString();
                    i++;
                }
                dr.Close();
                sqlCnt.Close();
                return User;
            }
            catch (System.Exception)
            {
                return User;
            }
        }
        public int SendMessage(string Sender, string Message, string Receiver)//将发送的消息上传到数据库
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "INSERT INTO [dbo].[MeassageBox] ([Sender],[Message],[Receiver]) VALUES (@letter1,@letter2 ,@letter3)";
                SqlCommand cmd = Injection(strSQL, Sender, Message, Receiver);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
        public int[] SearchNumbers(string username, string Receiver)//查找用户收到或发送的消息的序号
        {
            int[] User = new int[10];
            try
            {
                sqlCnt.Open();
                string strSQL = "SELECT top(10)  [SerialNumber] FROM [Chattools].[dbo].[MeassageBox] where Sender=@letter1 And Receiver=@letter2 ORDER by SerialNumber deSC ";
                SqlCommand cmd = Injection(strSQL, username, Receiver);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                int i = 0;
                int a = 0;
                
                while (dr.Read())
                {
                    int.TryParse(dr["SerialNumber"].ToString().Trim(), out a);
                    User[i] = a;
                    i++;
                }
                dr.Close();
                sqlCnt.Close();
                return User;
            }
            catch (System.Exception)
            {

                return User;
            }
        }
        public string SearchMessageByNumber(string SerialNumber)//按序号查询消息
        {
            string s = "";
            try
            {
                sqlCnt.Open();
                string strSQL = "select Message  from MeassageBox where SerialNumber=@letter1 ";
                SqlCommand cmd = Injection(strSQL, SerialNumber);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s = dr["Message"].ToString();
                }
                dr.Close();
                sqlCnt.Close();
                return s;
            }
            catch (System.Exception)
            {

                return s;
            }
        }
        public string SearchSenDerByNumber(string SerialNumber)//按序号查询消息发送人
        {
            string s = "";
            try
            {
                sqlCnt.Open();
                string strSQL = "select Sender  from MeassageBox where SerialNumber=@letter1 ";
                SqlCommand cmd = Injection(strSQL, SerialNumber);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s = dr["Sender"].ToString().Trim();
                }
                dr.Close();
                sqlCnt.Close();
                return s;
            }
            catch (System.Exception)
            {

                return s;
            }
        }
        public string SearchSendTimeByNumber(string SerialNumber)//按序号查询消息
        {
            string s = "";
            try
            {
                sqlCnt.Open();
                string strSQL = "select SendTime  from MeassageBox where SerialNumber=@letter1 ";
                SqlCommand cmd = Injection(strSQL, SerialNumber);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s = dr["SendTime"].ToString();
                }
                dr.Close();
                sqlCnt.Close();
                return s;
            }
            catch (System.Exception)
            {
                return s;
            }
        }
        public int AddFriends(string username, string Friends)//添加好友
        {
            try
            {
                sqlCnt.Open();
                string strsql = "insert into friends (username,friends) values(@letter1,@letter2)";
                SqlCommand cmd = Injection(strsql, username, Friends);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
        public int SendFriendApplication(string sender, string message, string Friends)//发送好友申请
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "insert into FriendsApplication (sender,message,receiver) values(@letter1,@letter2,@letter3)";
                SqlCommand cmd = Injection(strSQL, sender, message, Friends);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
        public string[] SearchFriendsApplication(string username)//查找用户所有的好友申请
        {
            string[] User = new string[2000];
            try
            {
                sqlCnt.Open();
                string strSQL = "select sender from FriendsApplication where receiver=@letter1";
                SqlCommand cmd = Injection(strSQL, username);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();

                int i = 0;
                while (dr.Read())
                {
                    if (i >= 2000) break;
                    User[i] = dr["sender"].ToString();
                    i++;
                }
                dr.Close();
                sqlCnt.Close();
                return User;
            }
            catch (System.Exception)
            {

                return User;
            }
        }
        public string SearchFriendsApplicationMessage(string sender, string receiver)//查找用户的好友申请信息，指定好友
        {
            string User = "";
            try
            {
                sqlCnt.Open();
                string strSQL = "select message from FriendsApplication where sender=@letter1 and receiver=@letter2";
                SqlCommand cmd = Injection(strSQL, sender, receiver);
                SqlDataReader dr;//创建DataReader对象
                dr = cmd.ExecuteReader();
                if (dr.Read()) { User = dr["message"].ToString(); }
                dr.Close();
                sqlCnt.Close();
                return User;
            }
            catch (System.Exception)
            {

                return User;
            }
        }

        public int DeleteApplication(string sender, string receiver)//删除好友申请
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "delete from FriendsApplication where sender = @letter1 and receiver=@letter2";
                SqlCommand cmd = Injection(strSQL, sender, receiver);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
        public int IsSendApplication(string sender, string receiver)//查找是否已经存在好友申请
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "select sender from FriendsApplication where sender=@letter1 and receiver=@letter2";
                SqlCommand cmd = Injection(strSQL, sender, receiver);
                DataSet dataSet = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                int result = da.Fill(dataSet, "sender");
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }

        public int UpdatePassword(string username, string password)//修改用户的登录密码
        {
            try
            {
                sqlCnt.Open();
                string strSQL = "update LoginInfo set password=@letter1 where Account=@letter2";
                SqlCommand cmd = Injection(strSQL, password, username);
                int result = cmd.ExecuteNonQuery();
                sqlCnt.Close();
                return result;
            }
            catch (System.Exception)
            {

                return 0;
            }
        }
        public SqlDataAdapter UserInfo()
        {
            sqlCnt.Open();
            string strSQL = "select * from LoginInfo ";
            SqlCommand cmd = Injection(strSQL);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            sqlCnt.Close();
            return da;
        }
        public ConnectionState State()
        {
            try
            {
                sqlCnt.Open();
            }
            catch (Exception)
            {
            }
            return sqlCnt.State;
        }
        public void ConnectClose()
        {
            sqlCnt.Close();
        }
    }
}
