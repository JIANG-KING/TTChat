using java.lang;
using System.Data;
using System.Data.SqlClient;
namespace SqlSeverFrame
{
    class SQLSeverConnect
    {
        private static readonly string constr = "Server=yun2333.top;Database=Chattools;user id=jiangyun;pwd=Jy1019878449";
        SqlConnection sqlCnt = new SqlConnection(constr);
        public SqlCommand Injection(string sql, string letter1)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@letter1", letter1);
            command.Connection = sqlCnt;
            return command;
        }
        public SqlCommand Injection(string sql, string letter1, string letter2)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@letter1", letter1);
            command.Parameters.AddWithValue("@letter2", letter2);
            command.Connection = sqlCnt;
            return command;
        }
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
        public SqlDataAdapter SqlLogin(string username, string password)//登录验证
        {
            string strSQL = "select account,password from LoginInfo where account=@letter1 and password=@letter2";
            SqlCommand cmd = Injection(strSQL,username,password);        
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
        public int SqlSearch(string Account)//查询指定用户
        {
            string strSQL = "select account from LoginInfo where account=@letter1";
            SqlCommand cmd = Injection(strSQL, Account);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            int a = da.Fill(ds, "LoginInfo");
            return a;
        }
        public int sqlInsert(string Account, string Password, string image, string NickName)//插入一个用户，用户注册时使用
        {
            string strSQL = "INSERT INTO [dbo].[LoginInfo] ([Account],[Password],[ImageHead],[NickName]) VALUES (@letter1,@letter2,@letter3,@letter4)";
            SqlCommand cmd = Injection(strSQL,Account,Password,image,NickName);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public string SearchImage(string username)//查找用户的头像
        {
            sqlCnt.Open();
            string strSQL = "select ImageHead from LoginInfo where account=@letter1";
            SqlCommand cmd = Injection(strSQL,username);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string s = "";
            if (dr.Read())
                s = dr["imagehead"].ToString().Substring(0, 5);
            sqlCnt.Close();
            return s;
        }
        public int UpdateState(string username, string LoginState)//更新用户的状态，在线，隐身，忙碌，请勿打扰，q我吧
        {
            string strSQL = "update LoginInfo set AccountState=@letter1  where Account=@letter2";
            SqlCommand cmd = Injection(strSQL,username,LoginState);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public string SearchUserState(string username)//查找用户的在线状态
        {
            sqlCnt.Open();
            string strSQL = "select AccountState from LoginInfo where Account=@letter1";
            SqlCommand cmd = Injection(strSQL,username);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string s = "";
            if (dr.Read())
                s = dr["AccountState"].ToString();
            sqlCnt.Close();
            return s;
        }
        public string SearchNickname(string username)//查找用户的昵称
        {
            sqlCnt.Open();
            string strSQL = "select NickName from LoginInfo where Account=@letter1";
            SqlCommand cmd =  Injection(strSQL, username);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string s = "";
            if (dr.Read())
                s = dr["NickName"].ToString();
            sqlCnt.Close();
            return s;
        }
        public int UpdateIsAlive(string username, string IsAlive)//修改用户的登录状态
        {
            //sqlCnt.Open();
            string strSQL = "update LoginInfo set IsAlive=@letter1 where Account=@letter2";
            SqlCommand cmd = Injection(strSQL,username,IsAlive);
            int result = cmd.ExecuteNonQuery();
            //sqlCnt.Close();
            return result;
        }
        public int SearchIsAlive(string username)//查找用户是否已登录
        {
            sqlCnt.Open();
            string strSQL = "select IsAlive from LoginInfo where Account=@letter1";
            SqlCommand cmd = Injection(strSQL,username);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string s = "";
            if (dr.Read())
                s = dr["IsALive"].ToString();
            sqlCnt.Close();
            return Integer.parseInt(s);
        }
        public string[] SearchFriends(string username)//查找用户的好友
        {
            sqlCnt.Open();
            string strSQL = "select Friends from Friends where UserName=@letter1";
            SqlCommand cmd = Injection(strSQL,username);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string[] User = new string[2000];
            int i = 0;
            while (dr.Read())
            {
                User[i] = dr["Friends"].ToString();
                i++;
            }
            sqlCnt.Close();
            return User;
        }
        public int  IsFriends(string username,string friends)//查找是否已经是用户好友
        {
            string strSQL = "select Friends from Friends where UserName=@letter1 and friends=@letter2";
            SqlCommand cmd = Injection(strSQL,username,friends);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public string[] SearchMessage(string username, string Receiver)//查找用户收到的消息，最近的十条
        {
            sqlCnt.Open();
            string strSQL = "SELECT top(10)  [Message] FROM [Chattools].[dbo].[MeassageBox] where Sender=@letter1 And Receiver=@letter2 ORDER by SerialNumber deSC ";
            SqlCommand cmd = Injection(strSQL,username,Receiver);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string[] User = new string[10];
            int i = 0;
            while (dr.Read())
            {
                User[i] = dr["Message"].ToString();
                i++;
            }
            sqlCnt.Close();
            return User;
        }
        public int SendMessage(string Sender, string Message, string Receiver)//将发送的消息上传到数据库
        {
            string strSQL = "INSERT INTO [dbo].[MeassageBox] ([Sender],[Message],[Receiver]) VALUES (@letter1,@letter2 ,@letter3)";
            SqlCommand cmd = Injection(strSQL,Sender,Message,Receiver);
           int result = cmd.ExecuteNonQuery();
            return result;
        }
        public int[] SearchNumbers(string username, string Receiver)//查找用户收到或发送的消息的序号
        {
            sqlCnt.Open();
            string strSQL = "SELECT top(10)  [SerialNumber] FROM [Chattools].[dbo].[MeassageBox] where Sender=@letter1 And Receiver=@letter2 ORDER by SerialNumber deSC ";
            SqlCommand cmd = Injection(strSQL,username,Receiver);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            int[] User = new int[10];
            int i = 0;
            while (dr.Read())
            {
                User[i] = Integer.parseInt(dr["SerialNumber"].ToString());
                i++;
            }
            sqlCnt.Close();
            return User;
        }
        public string SearchMessageByNumber(string SerialNumber)//按序号查询消息
        {
            sqlCnt.Open();
            string strSQL = "select Message  from MeassageBox where SerialNumber=@letter1 ";
            SqlCommand cmd = Injection(strSQL, SerialNumber);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string s="";
            if (dr.Read())
            {
                s = dr["Message"].ToString();
            }
            sqlCnt.Close();
            return s;
        }
        public string SearchSenDerByNumber(string SerialNumber)//按序号查询消息发送人
        {
            sqlCnt.Open();
            string strSQL = "select Sender  from MeassageBox where SerialNumber=@letter1 ";
            SqlCommand cmd = Injection(strSQL, SerialNumber);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string s="";
            if (dr.Read())
            {
                s = dr["Sender"].ToString();
            }
            sqlCnt.Close();
            return s;
        }
        public int  AddFriends(string username,string Friends)//添加好友
        {
            string strSQL = "insert into Friends (Username,friends) values(@letter1,@letter2)";
            SqlCommand cmd = Injection(strSQL, username,Friends);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public int SendFriendApplication(string sender,string message, string Friends)//发送好友申请
        {
            string strSQL = "insert into FriendsApplication (sender,message,receiver) values(@letter1,@letter2,@letter3)";
            SqlCommand cmd = Injection(strSQL, sender,message, Friends);
            int result = cmd.ExecuteNonQuery();
            return result;
        }
        public string[] SearchFriendsApplication(string username)//查找用户的好友申请
        {
            sqlCnt.Open();
            string strSQL = "select sender from FriendsApplication where receiver=@letter1";
            SqlCommand cmd = Injection(strSQL, username);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string[] User = new string[2000];
            int i = 0;
            while (dr.Read())
            {
                if (i >= 2000) break;
                User[i] = dr["sender"].ToString();
                i++;
            }
            sqlCnt.Close();
            return User;
        }
        public string SearchFriendsApplicationMessage(string sender,string receiver)//查找用户的好友申请信息
        {
            sqlCnt.Open();
            string strSQL = "select message from FriendsApplication where sender=@letter1 and receiver=@letter2";
            SqlCommand cmd = Injection(strSQL, sender, receiver);
            SqlDataReader dr;//创建DataReader对象
            dr = cmd.ExecuteReader();
            string User="";
            if (dr.Read()) {User = dr["message"].ToString(); }           
            sqlCnt.Close();
            return User;
        }
        public int DeleteApplication(string sender,string receiver)//删除好友申请
        {
            sqlCnt.Open();
            string strSQL = "delete from FriendsApplication where sender = @letter1 and receiver=@letter2";
            SqlCommand cmd = Injection(strSQL, sender, receiver);
            int result = cmd.ExecuteNonQuery();
            sqlCnt.Close();
            return result;
        }
        public int  IsSendApplication(string sender,string receiver)//查找是否已经存在好友申请
        {
            sqlCnt.Open();
            string strSQL = "select sender from FriendsApplication where sender=@letter1 and receiver=@letter2";
            SqlCommand cmd = Injection(strSQL, sender, receiver);
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            int result=da.Fill(dataSet, "sender");
            sqlCnt.Close();
            return result;
        }
    }
    }
